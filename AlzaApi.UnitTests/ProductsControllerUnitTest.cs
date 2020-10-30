using System;
using System.Linq;
using System.Threading.Tasks;
using AlzaApi.Models;
using AlzaApi.Models.v1_0;
using AlzaApi.UnitTests.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace AlzaApi.UnitTests
{
    public class ProductsControllerUnitTest
    {
        [Fact]
        public async Task TestGetProductsAsync()
        {
            // Arrange
            await using var dbContext = DbContextMocker.GetAlzaDbContext(nameof(TestGetProductsAsync));

            var productsCount = dbContext.Products.CountAsync();
            var controller = new Controllers.v1_0.ProductsController(dbContext);

            // Act
            var response = await controller.GetProducts();

            // Assert
            Assert.Equal(productsCount.Result, response.Value.Count());
        }

        [Fact]
        public async Task TestGetProductByIdAsync()
        {
            // Arrange
            await using var dbContext = DbContextMocker.GetAlzaDbContext(nameof(TestGetProductByIdAsync));

            var productId = new Random().Next(1, 99);
            var product = dbContext.FindAsync<Product>(productId);
            var controller = new Controllers.v1_0.ProductsController(dbContext);

            // Act
            var response = await controller.GetProductById(productId);

            // Assert
            Assert.Equal(product.Result?.ImgUri, response.Value?.ImgUri);
        }

        [Fact]
        public async Task TestUpdateDescriptionResponseOkAsync()
        {
            // Arrange
            await using var dbContext = DbContextMocker.GetAlzaDbContext(nameof(TestUpdateDescriptionResponseOkAsync));
            var productId = new Random().Next(1, 10);
            var oldProductDescription = dbContext.FindAsync<Product>(productId).Result.Description;
            var newDescription = Guid.NewGuid().ToString();
            var controller = new Controllers.v1_0.ProductsController(dbContext);

            // Act
            var response = await controller.UpdateDescription(productId, newDescription);
            
            var updatedDescription = dbContext.Find<Product>(productId)?.Description;

            // Assert
            Assert.IsType<OkResult>(response);
            Assert.NotEqual(oldProductDescription, updatedDescription);
        }

        [Fact]
        public async Task TestUpdateDescriptionResponseNotFoundAsync()
        {
            // Arrange
            await using var dbContext =
                DbContextMocker.GetAlzaDbContext(nameof(TestUpdateDescriptionResponseNotFoundAsync));
            
            var productId = new Random().Next(-10, -5);
            var newDescription = Guid.NewGuid().ToString();
            var controller = new Controllers.v1_0.ProductsController(dbContext);

            // Act
            var response = await controller.UpdateDescription(productId, newDescription);

            // Assert
            Assert.IsType<NotFoundResult>(response);
        }

        //v2
        [Fact]
        public async Task TestGetPagedProductsDefaultPageSizeAsync()
        {
            // Arrange
            await using var dbContext =
                DbContextMocker.GetAlzaDbContext(nameof(TestGetPagedProductsDefaultPageSizeAsync));

            var controller = new Controllers.v2_0.ProductsController(dbContext);
            var defaultPageSize = 10;

            // Act
            var response = await controller.GetPagedProducts(new Paging());

            // Assert
            Assert.True(response.Value.Count() == defaultPageSize);
        }

        //v2
        [Fact]
        public async Task TestGetPagedProductsPageSizeAsync()
        {
            // Arrange
            await using var dbContext = DbContextMocker.GetAlzaDbContext(nameof(TestGetPagedProductsPageSizeAsync));

            var controller = new Controllers.v2_0.ProductsController(dbContext);
            var productsPerPage = 25;

            // Act
            var response = await controller.GetPagedProducts(new Paging {Limit = productsPerPage});

            // Assert
            Assert.True(response.Value.Count() == productsPerPage);
        }

        //v2
        [Fact]
        public async Task TestGetPagedProductsOffsetAsync()
        {
            // Arrange
            await using var dbContext = DbContextMocker.GetAlzaDbContext(nameof(TestGetPagedProductsOffsetAsync));

            var controller = new Controllers.v2_0.ProductsController(dbContext);
            var productsPerPage = 50;
            var productsToSkip = 20;
            var randomContainedId = new Random().Next(21, 70);

            // Act
            var response =
                await controller.GetPagedProducts(new Paging {Offset = productsToSkip, Limit = productsPerPage});

            // Assert
            Assert.Contains(response.Value, p => p.Id == randomContainedId);
        }
    }
}

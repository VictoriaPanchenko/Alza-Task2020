using System;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace AlzaApi.Controllers
{
    /// <summary>
    /// Controller, which is responsible for exception handling 
    /// </summary>
    [ApiController]
    public class ErrorController : ControllerBase
    {
        /// <summary>
        /// Sends an RFC 7807-compliant payload to the client
        /// </summary>
        /// <returns></returns>
        [Route("/error")]
        public IActionResult Error() => Problem();

        /// <summary>
        /// Handles exceptions on local environment
        /// </summary>
        /// <param name="webHostEnvironment"></param>
        /// <returns></returns>
        [Route("/error-local-development")]
        public IActionResult ErrorLocalDevelopment(
            [FromServices] IWebHostEnvironment webHostEnvironment)
        {
            if (webHostEnvironment.EnvironmentName != "Development")
            {
                throw new InvalidOperationException(
                    "This shouldn't be invoked in non-development environments.");
            }

            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();

            return Problem(
                detail: context.Error.StackTrace,
                title: context.Error.Message);
        }

    }
}

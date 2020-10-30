I decided to use HTTP PUT method instead of PATCH because the requirement is to be able to update only one single property (field) - description. If the task has been to update different multiple properties, I would probably go for PATCH.

Steps:
1. create web app API project, create model Product. Based on the Product model => add Controller + generate dbcontext
2. Add-Migration Initial , seed initial data
3. generate http methods + versioning
4. pagination => Offset based mechanism/Cursor based pagination (offset by int Id)/page based mechanism
5. xUnit
6. Swagger

The complexity of the solution should be always considered. 
For this specific task I didn't choose to use Repository pattern or move logic from controller to services. But it definetely makes sense for more complex web api with enhanced logic and data composition 

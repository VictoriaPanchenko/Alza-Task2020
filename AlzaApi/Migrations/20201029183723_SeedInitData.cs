using Microsoft.EntityFrameworkCore.Migrations;

namespace AlzaApi.Migrations
{
    public partial class SeedInitData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 431906028);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImgUri", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Sleek Granite", "6d2322ba-2001-4fc4-ba4f-7c13606a047b", "Pants", 63.87m },
                    { 72, "Smart Granite", "76ccd403-56ad-467c-b0cd-5ac6759e63c7", "Chair", 84.82m },
                    { 71, "Ergonomic Steel", "fa78fc71-f350-4b1c-9644-a79d7c87c2e5", "Pants", 37.27m },
                    { 70, "Smart Granite", "97bcf54b-e0d6-48b4-b675-d534d63e568c", "Car", 57.92m },
                    { 69, "Ergonomic Granite", "7852a067-fa94-4761-92ea-d670908fa0f6", "Car", 72.03m },
                    { 68, "Rustic Plastic", "1beefd1e-4021-48c6-9d87-c21f8945fa5a", "Car", 32.12m },
                    { 67, "Sleek Plastic", "f68c2dcf-2958-438f-8b82-b394baa641a7", "Chair", 77.4m },
                    { 66, "Ergonomic Concrete", "3ced307a-a1e8-496b-8c87-bc33f159f32b", "Shoes", 43.89m },
                    { 65, "Ergonomic Steel", "49580862-60d9-4966-b7b4-c6fdd0aca18e", "Shoes", 67.17m },
                    { 64, "Sleek Granite", "0e0a5a4c-4be9-40ec-bf3f-00fbd9010ab3", "Car", 78.92m },
                    { 63, "Sleek Granite", "3d551fec-103f-4543-a585-19bb92d9368a", "Pants", 81.1m },
                    { 62, "Smart Steel", "c9eb84c9-0a04-401d-ac12-ad8501e32dad", "Shoes", 71.56m },
                    { 61, "Rustic Concrete", "b3a93a4b-83ac-47c9-bf55-ceb97365919b", "Computer", 59.27m },
                    { 60, "Ergonomic Plastic", "7debb192-4157-42b0-be94-986e5905e670", "Computer", 55.07m },
                    { 59, "Rustic Steel", "f015e04e-3a72-433a-9bb1-0ae3e715bb31", "Shoes", 59.56m },
                    { 58, "Sleek Steel", "6ee4eb7b-e950-437c-986b-86eba07b107f", "Shoes", 13.07m },
                    { 57, "Rustic Steel", "b60fcde4-425a-4eb5-b3ec-c46ef3d233fe", "Computer", 40.11m },
                    { 56, "Small Concrete", "71b95d79-e086-4f9b-96fd-2f15b5b37981", "Pants", 85.94m },
                    { 55, "Rustic Plastic", "3923120b-55c7-474b-9ce3-8570e7dbe1a0", "Car", 52.6m },
                    { 54, "Ergonomic Steel", "374c5276-5b05-4033-aea8-068a08e97b95", "Computer", 66.56m },
                    { 53, "Sleek Plastic", "4be19c6b-da4c-4746-a5c9-7a13f63c7827", "Computer", 12.2m },
                    { 52, "Rustic Steel", "d4b8d063-5e74-410e-b5c8-e8cc22178017", "Car", 38.04m },
                    { 73, "Small Granite", "d2b14b44-d4b1-477c-af47-1da285e2ff5d", "Pants", 51.42m },
                    { 51, "Ergonomic Granite", "ab7f8213-994e-4d59-aabc-942e1ea5c106", "Shoes", 81.34m },
                    { 74, "Smart Granite", "1e09d6f9-4260-42d6-a3fb-57308e5e3963", "Car", 30.57m },
                    { 76, "Sleek Concrete", "15b72a3f-1c11-45dd-bc4a-d5d3ba2c101d", "Shoes", 85.42m },
                    { 97, "Smart Steel", "8b96493b-b14c-486f-9ded-49360758518c", "Car", 48.29m },
                    { 96, "Small Granite", "d911a120-adeb-41fc-8996-7fafbad226e5", "Shoes", 60.24m },
                    { 95, "Sleek Steel", "579b581d-32ba-4372-a467-6731f4ec4ebf", "Computer", 33.18m },
                    { 94, "Sleek Steel", "ee8093a2-11b8-4d20-b93b-7e45a3cc21e7", "Computer", 45.12m },
                    { 93, "Small Steel", "848fad6d-2158-45e2-be85-4ff1bbd18243", "Computer", 61.93m },
                    { 92, "Sleek Concrete", "238e775b-1e6e-4ce1-8d3c-ef07e3242c86", "Car", 35.56m },
                    { 91, "Rustic Steel", "54c3963d-78dd-468a-ac58-0e982b3b6ce8", "Shoes", 66.91m },
                    { 90, "Ergonomic Plastic", "61654032-7a6a-4fda-8b3f-4b15e49d0d8b", "Shoes", 21.63m },
                    { 89, "Sleek Granite", "9707e420-89cc-4885-b1cb-a975ae3841c2", "Pants", 23.85m },
                    { 88, "Sleek Steel", "ef9985dc-3389-4072-87a3-1fd35dcaee3b", "Shoes", 23.19m },
                    { 87, "Sleek Plastic", "651efb26-8f9d-4684-9eb6-e96eb4a2d18f", "Shoes", 84.83m },
                    { 86, "Rustic Plastic", "09ca49ba-aed1-4ccd-9d21-f1c7707a04e9", "Car", 19.01m },
                    { 85, "Smart Granite", "b8e9dd72-0555-4ca9-8507-00950d0f9c84", "Computer", 88.8m },
                    { 84, "Sleek Plastic", "5f91ec4d-cf67-453a-99c5-ae1971085233", "Car", 57.07m },
                    { 83, "Smart Wooden", "b67f4520-d743-4302-8a8d-c69343a0f3db", "Chair", 38.21m },
                    { 82, "Rustic Steel", "775392ef-8c1a-4b57-ab5b-2a7c3ade55fa", "Chair", 64.64m },
                    { 81, "Small Plastic", "bba21632-4515-480c-9b1e-36d07d31c85b", "Chair", 85.32m },
                    { 80, "Ergonomic Steel", "ad10a500-e2ae-4965-8cc2-b139957f6792", "Chair", 26.47m },
                    { 79, "Ergonomic Concrete", "7853e7d9-b5a2-42b2-be07-2e7971ae4137", "Chair", 48.72m },
                    { 78, "Smart Wooden", "104d658b-6d2a-4d75-bbc4-ebc6c4793741", "Computer", 83.54m },
                    { 77, "Smart Concrete", "7ddba69f-760f-429d-92ac-59b0088b9fe3", "Car", 27.15m },
                    { 75, "Ergonomic Steel", "379b931c-e44e-43b3-a46b-b4e006b0c4f8", "Car", 14.9m },
                    { 98, "Sleek Wooden", "d3c09c28-7603-4df3-b744-bff1fca6447b", "Pants", 89.09m },
                    { 50, "Smart Concrete", "8c694790-e691-46a1-aa44-87164bd506e0", "Computer", 75.9m },
                    { 48, "Rustic Steel", "a994bf2b-073e-4852-a92c-b983cdd4965c", "Computer", 75.11m },
                    { 22, "Rustic Wooden", "db51a4ab-fa3f-41fb-99ff-63438596d414", "Computer", 79.33m },
                    { 21, "Rustic Granite", "1c52e593-bc8e-4fde-b507-83a18078d0ac", "Computer", 34.38m },
                    { 20, "Rustic Plastic", "26b664db-339c-42da-84c1-1afad5278b83", "Car", 56.24m },
                    { 19, "Ergonomic Concrete", "d31270e7-4ab3-46ff-b4e7-81e2038b3796", "Shoes", 58.36m },
                    { 18, "Small Steel", "24d3d921-02ca-4c90-bd34-df097ded40cb", "Computer", 48.23m },
                    { 17, "Rustic Wooden", "9e900702-5025-4557-a3ba-d62625c6d5e7", "Shoes", 55.87m },
                    { 16, "Ergonomic Concrete", "01758f9c-b8ce-4b18-8d18-bb4603aab54c", "Computer", 50.71m },
                    { 15, "Smart Steel", "0d976393-7241-4015-b02b-0a68fe690018", "Pants", 12.41m },
                    { 14, "Smart Plastic", "749e7807-b6c7-40d3-9410-c21634c29ef3", "Car", 36.47m },
                    { 13, "Rustic Steel", "af9ef61e-90a9-4c42-b303-7c35e21e3c6e", "Shoes", 71.4m },
                    { 12, "Small Steel", "43d71952-8070-45fb-b4f6-8af7a6b4b8c0", "Car", 59.46m },
                    { 11, "Sleek Concrete", "ea7060da-8c70-4d91-bc21-f7e7f2b9bdd0", "Chair", 24.07m },
                    { 10, "Smart Concrete", "50688757-79ca-44f3-9b4c-205cbdfc6fe8", "Shoes", 28.11m },
                    { 9, "Small Plastic", "4263fccf-fd6d-4a28-b59c-5d27c0d7708b", "Pants", 19.18m },
                    { 8, "Sleek Plastic", "d7309147-c19d-40f3-a77f-11913b1a6071", "Pants", 86.67m },
                    { 7, "Ergonomic Concrete", "13910f49-6000-4534-8c63-37b25c5d8f60", "Car", 56.65m },
                    { 6, "Small Plastic", "29862d78-e3e6-4aaa-bc48-16f1178dcb8d", "Pants", 16.86m },
                    { 5, "Small Concrete", "7ea634ec-1c92-4f6f-9982-2ce02395ff66", "Car", 57.66m },
                    { 4, "Small Steel", "86fbdf37-789a-48ac-bd14-6bdc6570f62e", "Car", 48.02m },
                    { 3, "Ergonomic Wooden", "4af08ab9-dcf4-4d83-b66b-6ea1c74cf879", "Computer", 66.03m },
                    { 2, "Sleek Granite", "81facd31-4038-4daa-abb8-5f5e903978c4", "Pants", 79.16m },
                    { 23, "Small Granite", "223f8c00-1af4-4100-8d76-95c495f29ca2", "Computer", 38.8m },
                    { 49, "Small Steel", "e9c5b94c-eb06-4c0c-9087-dad491612827", "Pants", 10.71m },
                    { 24, "Small Plastic", "28690675-d8bd-4a5e-a9fb-87fe877d8c3b", "Computer", 54.95m },
                    { 26, "Smart Concrete", "d25430c3-3073-415f-8902-244643ca7df1", "Chair", 80.03m },
                    { 47, "Sleek Steel", "6b0fb5ca-7649-40b4-a090-fa7e1ca369eb", "Chair", 83.35m },
                    { 46, "Rustic Plastic", "44462c66-29f6-4678-9b4a-948c7ce3f205", "Shoes", 77.52m },
                    { 45, "Small Wooden", "ed6083de-3f85-4f2c-975c-e0a8388ecde1", "Shoes", 44.8m },
                    { 44, "Small Concrete", "07c17165-cd25-48ea-baac-7ba93b81a69f", "Chair", 89.63m },
                    { 43, "Rustic Wooden", "85d7e516-cdf3-450b-a34b-03976a208087", "Car", 13.64m },
                    { 42, "Small Concrete", "d6ed37cd-7c3b-4f5a-85ab-486bead4d8db", "Pants", 43.54m },
                    { 41, "Small Concrete", "56f825c4-3d47-4707-b5ca-ef2e69461bb4", "Chair", 64.67m },
                    { 40, "Small Wooden", "24f7d5aa-5650-4c47-8810-e71138d0b640", "Chair", 53.63m },
                    { 39, "Rustic Granite", "7b5c2ec5-4697-4249-87c2-c676bccf0ccb", "Chair", 68.2m },
                    { 38, "Rustic Concrete", "d7ae40c7-6817-496d-801d-0322960c69fe", "Shoes", 81.09m },
                    { 37, "Ergonomic Concrete", "481b91f9-258e-4542-867f-497dca5db47e", "Shoes", 12.62m },
                    { 36, "Ergonomic Wooden", "66efa14f-e33a-41e2-bef3-d910115a2272", "Pants", 66.28m },
                    { 35, "Ergonomic Steel", "a2c121b0-d965-490b-b6b8-186bd5a4fa7e", "Pants", 80.98m },
                    { 34, "Smart Concrete", "dfde13b3-ea6e-4e45-aaac-2418919f8464", "Shoes", 85.65m },
                    { 33, "Rustic Granite", "4fac1530-fe76-4b8f-8cfd-042e7d632511", "Computer", 57.38m },
                    { 32, "Rustic Wooden", "545263da-1db7-40ae-92dd-efa06fe756d9", "Computer", 36.58m },
                    { 31, "Smart Steel", "26cde609-ec4e-4993-9b0b-ab3d45c10e7e", "Chair", 26.62m },
                    { 30, "Small Granite", "c08d1c2f-c473-44e7-81d0-c2c5e4777df8", "Chair", 38.75m },
                    { 29, "Smart Steel", "00247789-2615-43f6-be60-c7f1f6b186c2", "Computer", 88.63m },
                    { 28, "Rustic Steel", "4ce868c6-d10b-48cc-b7a4-c37dcd7a79a6", "Chair", 24.55m },
                    { 27, "Small Plastic", "7438522f-ad7c-4193-b4cb-d81f291f0be0", "Pants", 45.49m },
                    { 25, "Smart Plastic", "fc2df5a9-7a50-4cdc-9e3d-e74488cbbd15", "Shoes", 30.34m },
                    { 99, "Small Concrete", "f24a3462-e3b8-401c-b583-724ddd804045", "Pants", 17.32m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImgUri", "Name", "Price" },
                values: new object[] { 431906028, "Smart Concrete", "e5e06859-2a1c-46b6-b810-cc595d6aec4b", "Computer", 77.71m });
        }
    }
}

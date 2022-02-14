using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DogsApi.Migrations
{
    public partial class DogsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "Color", "Name", "tail_length", "weight" },
                values: new object[] { new Guid("5876973a-19cf-4059-a470-834ead1c8135"), "red & amber", "Neo", 22, 32 });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "Color", "Name", "tail_length", "weight" },
                values: new object[] { new Guid("9ec1240e-c62a-4145-ab6d-60fae2c1bb10"), "black & white", "Jessy", 7, 14 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: new Guid("5876973a-19cf-4059-a470-834ead1c8135"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: new Guid("9ec1240e-c62a-4145-ab6d-60fae2c1bb10"));
        }
    }
}

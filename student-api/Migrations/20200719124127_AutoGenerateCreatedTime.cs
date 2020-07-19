using Microsoft.EntityFrameworkCore.Migrations;
using Newtonsoft.Json;
using student_api.Models;
using System;

namespace student_api.Migrations
{
    public partial class AutoGenerateCreatedTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "timeCreated",
                table: "Student",
                defaultValueSql: "GETUTCDATE()"
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

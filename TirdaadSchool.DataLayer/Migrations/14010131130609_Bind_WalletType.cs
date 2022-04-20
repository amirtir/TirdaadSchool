using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using TirdaadSchool.DataLayer.Context;
using TirdaadSchool.DataLayer.Entities.Wallet;
using TirdaadSchool.DataLayer.Context;

namespace TirdaadSchool.DataLayer.Migrations
{
    public partial class Bind_WalletType : Migration
    {
    

      

        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData("WalletTypes",new string[] { "TypeId","TypeTitle" },new object[] {1,"Variz" });
            migrationBuilder.InsertData("WalletTypes", new string[] { "TypeId", "TypeTitle" }, new object[] { 2, "Bardasht" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

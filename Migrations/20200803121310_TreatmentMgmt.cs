using Microsoft.EntityFrameworkCore.Migrations;

namespace IPTreatmentManagementPortal.Migrations
{
    public partial class TreatmentMgmt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PatientRecords",
                columns: table => new
                {
                    PatientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Ailment = table.Column<string>(nullable: true),
                    Package = table.Column<int>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Specialist = table.Column<string>(nullable: true),
                    InsurerName = table.Column<string>(nullable: true),
                    Balance = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientRecords", x => x.PatientId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientRecords");
        }
    }
}

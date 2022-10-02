using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminisEmpleados.Servicios.Migrations
{
    public partial class spObtEmplPorId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string proces = @"Create Procedure spObtEmplPorId
                            @Id int
                            as
                            Begin
                            	Select * from Empleados
                            	Where Id = @Id
                            End";
            migrationBuilder.Sql(proces);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string proces = @"Drop Procedure spObtEmplPorId";
            migrationBuilder.Sql(proces);
        }
    }
}

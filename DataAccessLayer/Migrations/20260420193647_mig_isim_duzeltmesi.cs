using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_isim_duzeltmesi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // İmageUrl sütununu ImageUrl olarak değiştir
            migrationBuilder.RenameColumn(
                name: "İmageUrl",
                table: "Teams",
                newName: "ImageUrl");

            // FavcebookUrl sütununu FacebookUrl olarak değiştir (eski adını tablodaki haline göre yazdım)
            migrationBuilder.RenameColumn(
                name: "FavcebookUrl",
                table: "Teams",
                newName: "FacebookUrl");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Hata olursa geri alabilmek için tam tersini yazıyoruz
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Teams",
                newName: "İmageUrl");

            migrationBuilder.RenameColumn(
                name: "FacebookUrl",
                table: "Teams",
                newName: "FavcebookUrl");
        }
    }
}
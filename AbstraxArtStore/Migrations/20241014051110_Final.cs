using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AbstraxArtStore.Migrations
{
    /// <inheritdoc />
    public partial class Final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0767336b-e809-4336-8520-d54a5ad33e70", "AQAAAAIAAYagAAAAEGew9l4miihVlOWSqXP0x4rOQEkgk1Uf8dnjA1Nn2Oau69GCvoii+Qv1n1+4AD6gfw==", "4582ed3d-84e3-4d42-872c-27e05d56a51d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b95ac998-b7cd-409f-ad13-c30325e8f47d", "AQAAAAIAAYagAAAAEH9UY2wYhWZmfY8HlTIy7FbnfotKrcFz+QOWINJtd+zZcHpFcE7M3qjFSBoYYyZD2g==", "cae46cd4-89e8-425e-8270-0485b594db3b" });
        }
    }
}

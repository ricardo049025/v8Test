using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Entities.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Divisions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Salaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    EmployeeCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EmployeeSurname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaseSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductionBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CompensationBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Commission = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Contributions = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OfficeID = table.Column<int>(type: "int", nullable: false),
                    DivisionID = table.Column<int>(type: "int", nullable: false),
                    PositionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Salaries_Divisions_DivisionID",
                        column: x => x.DivisionID,
                        principalTable: "Divisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Salaries_Offices_OfficeID",
                        column: x => x.OfficeID,
                        principalTable: "Offices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Salaries_Positions_PositionID",
                        column: x => x.PositionID,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "CUSTOMER CARE" },
                    { 2, "MARKETING" },
                    { 3, "OPERATION" },
                    { 4, "SALES" }
                });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "A" },
                    { 2, "B" },
                    { 3, "C" },
                    { 4, "D" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "ACCOUNT EXECUTIVE" },
                    { 2, "CARGO ASSISTANT" },
                    { 3, "CARGO MANAGER" },
                    { 4, "CUSTOMER ASSISTANT" },
                    { 5, "CUSTOMER DIRECTOR" },
                    { 6, "HEAD OF CARGO" },
                    { 7, "MARKETING ASSISTANT" },
                    { 8, "SALES MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionID", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeID", "PositionID", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 6, 4061m, new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1600m, 2259m, 1676m, 2, "2032440", "LUIS", "JUAREZ", 17, "34877450", 9, 1, 1, 0m, 2021 },
                    { 375, 2873m, new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4029m, 3117m, 2223m, 1, "2032378", "JOSE", "ESTRADA", 14, "24582177", 11, 2, 5, 2871m, 2021 },
                    { 382, 4601m, new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2360m, 1487m, 2288m, 1, "2032377", "DAVID", "MORALES", 7, "23948768", 6, 3, 5, 0m, 2021 },
                    { 384, 4601m, new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4977m, 2086m, 2290m, 2, "2032377", "DAVID", "MORALES", 13, "23948768", 8, 2, 5, 0m, 2021 },
                    { 392, 3900m, new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3855m, 3294m, 617m, 2, "2032375", "LILIA", "VANEGAS", 14, "44387218", 7, 2, 5, 0m, 2021 },
                    { 393, 3900m, new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3358m, 2089m, 1868m, 2, "2032375", "LILIA", "VANEGAS", 9, "44387218", 1, 3, 5, 0m, 2021 },
                    { 397, 2141m, new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4925m, 1141m, 2193m, 2, "2032374", "ROBERTO", "DAVILA", 13, "28080896", 9, 1, 5, 1807m, 2021 },
                    { 365, 4252m, new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3999m, 2083m, 757m, 2, "2032380", "YORDI", "BARRAZA", 8, "45175094", 1, 2, 5, 0m, 2021 },
                    { 407, 3265m, new DateTime(2021, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3707m, 2590m, 610m, 1, "2032373", "SATURNINO", "MONTENEGRO", 9, "9388196", 8, 2, 5, 0m, 2021 },
                    { 420, 4914m, new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4664m, 1454m, 1001m, 2, "2032371", "GRACIELA", "CABALLERO", 6, "44227272", 4, 3, 5, 0m, 2021 },
                    { 422, 2541m, new DateTime(2021, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4161m, 2899m, 1486m, 3, "2032370", "EMPERATRIZ", "BLANDINO", 7, "5419134", 6, 1, 5, 2610m, 2021 },
                    { 430, 4267m, new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3819m, 3132m, 1264m, 2, "2032369", "ENEYDA", "ESPINO", 7, "39714685", 4, 3, 5, 0m, 2021 },
                    { 443, 3023m, new DateTime(2021, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3937m, 2053m, 1538m, 3, "2032367", "CARMEN", "MORALES", 17, "11138508", 7, 3, 5, 0m, 2021 },
                    { 451, 2932m, new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4467m, 1803m, 1678m, 1, "2032365", "NOE", "BORGE", 13, "30630023", 1, 3, 5, 2606m, 2021 },
                    { 453, 2932m, new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1928m, 2774m, 1752m, 3, "2032365", "NOE", "BORGE", 8, "30630023", 11, 2, 5, 2807m, 2021 },
                    { 412, 2184m, new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3211m, 2693m, 750m, 2, "2032372", "TARSIS", "ACUÑA", 9, "37554912", 5, 2, 5, 2483m, 2021 },
                    { 361, 4252m, new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2157m, 1515m, 1444m, 3, "2032380", "YORDI", "BARRAZA", 15, "45175094", 6, 1, 5, 0m, 2021 },
                    { 359, 4978m, new DateTime(2021, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3724m, 1009m, 1940m, 2, "2032381", "LEONEL", "MELENDEZ", 7, "8177551", 5, 3, 5, 0m, 2021 },
                    { 357, 4978m, new DateTime(2021, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000m, 3269m, 1414m, 3, "2032381", "LEONEL", "MELENDEZ", 13, "8177551", 10, 2, 5, 0m, 2021 },
                    { 256, 3676m, new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1627m, 1215m, 769m, 2, "2032398", "LESLY", "FERNANDEZ", 11, "21713943", 4, 1, 5, 0m, 2021 },
                    { 268, 3276m, new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1998m, 2411m, 1230m, 1, "2032396", "REYNALDO", "MEJIA", 10, "39179324", 10, 3, 5, 0m, 2021 },
                    { 269, 3276m, new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1337m, 2078m, 971m, 1, "2032396", "REYNALDO", "MEJIA", 6, "39179324", 1, 1, 5, 0m, 2021 },
                    { 276, 4147m, new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1829m, 1533m, 1953m, 1, "2032395", "ERICK", "GARCIA", 12, "16786337", 11, 2, 5, 0m, 2021 },
                    { 283, 2956m, new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2857m, 1909m, 1046m, 3, "2032393", "HENRY", "ROBLETO", 15, "39969291", 11, 2, 5, 2618m, 2021 },
                    { 286, 2956m, new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1792m, 2003m, 1875m, 3, "2032393", "HENRY", "ROBLETO", 14, "39969291", 5, 1, 5, 3072m, 2021 },
                    { 291, 3620m, new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3109m, 1098m, 1364m, 3, "2032392", "WILTON", "HUMPHREYS", 13, "3467396", 5, 3, 5, 0m, 2021 },
                    { 300, 3255m, new DateTime(2021, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2261m, 2278m, 1980m, 2, "2032391", "FRANCISCO", "RUIZ", 7, "42818064", 10, 2, 5, 0m, 2021 },
                    { 307, 2923m, new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4120m, 1301m, 1034m, 2, "2032389", "ENRIQUE", "HERNANDEZ", 12, "26937085", 5, 1, 5, 2719m, 2021 },
                    { 317, 3920m, new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3720m, 1721m, 2102m, 3, "2032388", "EDDY", "MELENDEZ", 14, "21674906", 11, 2, 5, 0m, 2021 },
                    { 328, 3976m, new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3955m, 2380m, 916m, 3, "2032386", "ALVIN", "ARAICA", 12, "5434979", 11, 3, 5, 0m, 2021 },
                    { 336, 3287m, new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 865m, 2332m, 670m, 3, "2032385", "AYLENE", "RODRIGUEZ", 12, "45206736", 5, 3, 5, 0m, 2021 },
                    { 343, 2268m, new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2749m, 2982m, 1516m, 1, "2032383", "JUAN", "ALVAREZ", 12, "17193118", 10, 2, 5, 2330m, 2021 },
                    { 347, 2268m, new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2442m, 2499m, 2243m, 3, "2032383", "JUAN", "ALVAREZ", 12, "17193118", 6, 2, 5, 2301m, 2021 },
                    { 350, 2740m, new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4865m, 1930m, 1699m, 1, "2032382", "VIRGINIA", "GUIDO", 9, "28542877", 7, 2, 5, 3025m, 2021 },
                    { 458, 4683m, new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3872m, 1225m, 1964m, 2, "2032364", "JAY", "TORRENTES", 14, "21675930", 11, 1, 5, 0m, 2021 },
                    { 460, 4683m, new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3708m, 1125m, 1731m, 2, "2032364", "JAY", "TORRENTES", 6, "21675930", 10, 2, 5, 0m, 2021 },
                    { 466, 3446m, new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1439m, 1090m, 2084m, 2, "2032363", "NORIEL", "SALGUERA", 10, "20789713", 3, 1, 5, 0m, 2021 },
                    { 467, 3446m, new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2016m, 1173m, 1439m, 3, "2032363", "NORIEL", "SALGUERA", 6, "20789713", 5, 3, 5, 0m, 2021 },
                    { 592, 3990m, new DateTime(2021, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2194m, 1413m, 934m, 1, "2032342", "MARIANO", "SANCHEZ", 9, "39003125", 1, 1, 5, 0m, 2021 },
                    { 10, 4935m, new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1802m, 2697m, 2060m, 2, "2032439", "KATHERINE", "GARCIA", 8, "9041163", 3, 2, 6, 0m, 2021 },
                    { 15, 2339m, new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4088m, 1770m, 1510m, 1, "2032438", "HAZEL", "OROZCO", 6, "35538733", 3, 1, 6, 2202m, 2021 },
                    { 27, 2304m, new DateTime(2021, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2853m, 2060m, 1771m, 2, "2032436", "DAVID", "RODRIGUEZ", 8, "19133450", 10, 3, 6, 2306m, 2021 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionID", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeID", "PositionID", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 39, 3200m, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2589m, 1709m, 620m, 1, "2032434", "NORWIN", "SOLANO", 8, "26637654", 3, 1, 6, 0m, 2021 },
                    { 41, 3200m, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 832m, 1033m, 1592m, 2, "2032434", "NORWIN", "SOLANO", 9, "26637654", 1, 2, 6, 0m, 2021 },
                    { 49, 3018m, new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4084m, 2230m, 1100m, 2, "2032432", "MARLING", "CHAVEZ", 17, "31823310", 5, 3, 6, 0m, 2021 },
                    { 53, 3018m, new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4175m, 2333m, 1132m, 3, "2032432", "MARLING", "CHAVEZ", 13, "31823310", 1, 1, 6, 0m, 2021 },
                    { 56, 2069m, new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2195m, 1317m, 2227m, 1, "2032431", "TOURREN", "HOPPINGTON", 17, "41413887", 3, 1, 6, 1914m, 2021 },
                    { 58, 2069m, new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4135m, 2963m, 1566m, 1, "2032431", "TOURREN", "HOPPINGTON", 14, "41413887", 11, 3, 6, 2271m, 2021 },
                    { 63, 3506m, new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1343m, 2410m, 1203m, 3, "2032430", "DAYSI", "MONTES", 7, "33954617", 4, 1, 6, 0m, 2021 },
                    { 89, 4226m, new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2940m, 1936m, 1476m, 2, "2032426", "ALBIN", "HAMILTON", 12, "31602242", 8, 1, 6, 0m, 2021 },
                    { 97, 4596m, new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3285m, 1380m, 2250m, 1, "2032424", "ALEXA", "GUTIERREZ", 15, "4556179", 2, 2, 6, 0m, 2021 },
                    { 99, 4596m, new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3620m, 1478m, 938m, 1, "2032424", "ALEXA", "GUTIERREZ", 9, "4556179", 11, 1, 6, 0m, 2021 },
                    { 107, 2668m, new DateTime(2021, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 937m, 3081m, 834m, 2, "2032423", "PAMELA", "LOPEZ", 12, "8386388", 4, 3, 6, 2701m, 2021 },
                    { 588, 3991m, new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4733m, 2884m, 2141m, 2, "2032343", "PEDRO", "ESPINOZA", 13, "18906271", 5, 1, 5, 0m, 2021 },
                    { 253, 3676m, new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4265m, 3203m, 1553m, 1, "2032398", "LESLY", "FERNANDEZ", 6, "21713943", 11, 3, 5, 0m, 2021 },
                    { 570, 3280m, new DateTime(2021, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2914m, 3144m, 1937m, 3, "2032346", "WILLIAM", "GAMBOA", 14, "18632460", 10, 1, 5, 0m, 2021 },
                    { 549, 2500m, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4665m, 1024m, 1809m, 1, "2032349", "JUAN", "PELAEZ", 14, "39967136", 2, 2, 5, 2158m, 2021 },
                    { 478, 2711m, new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4231m, 2009m, 1404m, 3, "2032361", "LUISAMARA", "MORENO", 16, "27450930", 4, 2, 5, 2927m, 2021 },
                    { 481, 3706m, new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3715m, 1239m, 1905m, 2, "2032360", "ANTHONY", "HODGSON", 8, "16413472", 8, 2, 5, 0m, 2021 },
                    { 488, 2927m, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1561m, 3188m, 1731m, 1, "2032359", "PERLA", "CABRERA", 12, "40578545", 7, 1, 5, 2586m, 2021 },
                    { 492, 2927m, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1673m, 2779m, 2188m, 3, "2032359", "PERLA", "CABRERA", 7, "40578545", 1, 3, 5, 2661m, 2021 },
                    { 495, 4172m, new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2654m, 3124m, 1276m, 1, "2032358", "JAVIER", "ZAMORA", 16, "11428614", 5, 1, 5, 0m, 2021 },
                    { 496, 4172m, new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2097m, 1324m, 1679m, 3, "2032358", "JAVIER", "ZAMORA", 11, "11428614", 1, 3, 5, 0m, 2021 },
                    { 498, 4172m, new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2985m, 1708m, 2278m, 3, "2032358", "JAVIER", "ZAMORA", 7, "11428614", 6, 1, 5, 0m, 2021 },
                    { 506, 4010m, new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2077m, 2234m, 1276m, 3, "2032356", "EYDER", "ALVAREZ", 10, "28586950", 1, 3, 5, 0m, 2021 },
                    { 507, 4010m, new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3627m, 2531m, 1455m, 1, "2032356", "EYDER", "ALVAREZ", 14, "28586950", 10, 1, 5, 0m, 2021 },
                    { 514, 2785m, new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2929m, 1722m, 1740m, 2, "2032355", "GIOCONDA", "ESPINO", 11, "42872115", 9, 2, 5, 2344m, 2021 },
                    { 515, 2785m, new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2046m, 1553m, 1021m, 1, "2032355", "GIOCONDA", "ESPINO", 9, "42872115", 11, 3, 5, 2669m, 2021 },
                    { 526, 2928m, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4293m, 3284m, 1247m, 2, "2032353", "WALTER", "MENDOZA", 14, "25532938", 9, 1, 5, 2583m, 2021 },
                    { 531, 4463m, new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1636m, 2804m, 601m, 3, "2032352", "JENNY", "GUZMAN", 9, "25134015", 1, 1, 5, 0m, 2021 },
                    { 533, 4463m, new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3613m, 1061m, 1320m, 2, "2032352", "JENNY", "GUZMAN", 7, "25134015", 7, 2, 5, 0m, 2021 },
                    { 548, 2500m, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2199m, 1155m, 893m, 3, "2032349", "JUAN", "PELAEZ", 15, "39967136", 6, 2, 5, 2526m, 2021 },
                    { 551, 2500m, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1850m, 2835m, 1889m, 1, "2032349", "JUAN", "PELAEZ", 6, "39967136", 9, 2, 5, 2320m, 2021 },
                    { 109, 2844m, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3502m, 1729m, 1425m, 3, "2032422", "OSMAR", "MORALES", 15, "24791557", 2, 1, 6, 2528m, 2021 },
                    { 252, 2315m, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4696m, 1725m, 956m, 1, "2032399", "BLANCA", "MORALES", 12, "29003040", 11, 3, 5, 1910m, 2021 },
                    { 229, 2858m, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4024m, 2695m, 1653m, 1, "2032402", "KARLA", "BLANDINO", 17, "35162403", 3, 3, 5, 2709m, 2021 },
                    { 441, 3023m, new DateTime(2021, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3436m, 2615m, 1573m, 1, "2032367", "CARMEN", "MORALES", 8, "11138508", 5, 2, 4, 0m, 2021 },
                    { 464, 3446m, new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2079m, 2209m, 2224m, 1, "2032363", "NORIEL", "SALGUERA", 7, "20789713", 10, 2, 4, 0m, 2021 },
                    { 473, 3132m, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 816m, 2571m, 1866m, 3, "2032362", "DIANA", "FIGUEROA", 10, "8657208", 9, 1, 4, 0m, 2021 },
                    { 482, 3706m, new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4024m, 1269m, 1702m, 2, "2032360", "ANTHONY", "HODGSON", 14, "16413472", 3, 3, 4, 0m, 2021 },
                    { 483, 3706m, new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2108m, 2020m, 1288m, 2, "2032360", "ANTHONY", "HODGSON", 11, "16413472", 1, 2, 4, 0m, 2021 },
                    { 502, 4133m, new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 873m, 3129m, 2106m, 1, "2032357", "ELIZABETH", "JUÁREZ", 13, "6918240", 8, 3, 4, 0m, 2021 },
                    { 438, 2880m, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1905m, 2547m, 1638m, 3, "2032368", "LUIS", "LOVO", 16, "19323280", 10, 3, 4, 2737m, 2021 },
                    { 503, 4133m, new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4062m, 2406m, 1532m, 3, "2032357", "ELIZABETH", "JUÁREZ", 7, "6918240", 9, 1, 4, 0m, 2021 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionID", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeID", "PositionID", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 511, 2785m, new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1136m, 1040m, 937m, 3, "2032355", "GIOCONDA", "ESPINO", 11, "42872115", 5, 2, 4, 3040m, 2021 },
                    { 516, 2785m, new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4814m, 2752m, 1692m, 1, "2032355", "GIOCONDA", "ESPINO", 12, "42872115", 7, 1, 4, 3082m, 2021 },
                    { 523, 2928m, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2343m, 2783m, 1909m, 1, "2032353", "WALTER", "MENDOZA", 7, "25532938", 8, 3, 4, 3075m, 2021 },
                    { 527, 2928m, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1424m, 1646m, 642m, 3, "2032353", "WALTER", "MENDOZA", 15, "25532938", 5, 2, 4, 3212m, 2021 },
                    { 528, 2928m, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4525m, 1561m, 2154m, 3, "2032353", "WALTER", "MENDOZA", 16, "25532938", 10, 1, 4, 2796m, 2021 },
                    { 537, 4748m, new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2636m, 2779m, 1522m, 3, "2032351", "DEYRIN", "VINDELL", 16, "16515860", 9, 3, 4, 0m, 2021 },
                    { 509, 4010m, new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2704m, 2149m, 1640m, 3, "2032356", "EYDER", "ALVAREZ", 17, "28586950", 9, 2, 4, 0m, 2021 },
                    { 426, 2541m, new DateTime(2021, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3524m, 2037m, 1581m, 2, "2032370", "EMPERATRIZ", "BLANDINO", 12, "5419134", 9, 2, 4, 2434m, 2021 },
                    { 413, 2184m, new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4851m, 2236m, 915m, 1, "2032372", "TARSIS", "ACUÑA", 10, "37554912", 7, 2, 4, 2043m, 2021 },
                    { 411, 2184m, new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1514m, 3088m, 1962m, 1, "2032372", "TARSIS", "ACUÑA", 16, "37554912", 10, 3, 4, 2426m, 2021 },
                    { 287, 2956m, new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4420m, 3291m, 855m, 3, "2032393", "HENRY", "ROBLETO", 8, "39969291", 6, 2, 4, 2679m, 2021 },
                    { 293, 3620m, new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1033m, 1526m, 1376m, 1, "2032392", "WILTON", "HUMPHREYS", 10, "3467396", 6, 3, 4, 0m, 2021 },
                    { 294, 3620m, new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1777m, 1227m, 1314m, 2, "2032392", "WILTON", "HUMPHREYS", 11, "3467396", 7, 1, 4, 0m, 2021 },
                    { 297, 3255m, new DateTime(2021, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4420m, 3009m, 836m, 3, "2032391", "FRANCISCO", "RUIZ", 16, "42818064", 2, 3, 4, 0m, 2021 },
                    { 320, 4430m, new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3642m, 2751m, 1703m, 2, "2032387", "BRYAN", "BERMUDEZ", 8, "3125873", 11, 3, 4, 0m, 2021 },
                    { 322, 4430m, new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2589m, 1473m, 2042m, 2, "2032387", "BRYAN", "BERMUDEZ", 8, "3125873", 8, 1, 4, 0m, 2021 },
                    { 329, 3976m, new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4540m, 3175m, 1436m, 3, "2032386", "ALVIN", "ARAICA", 6, "5434979", 8, 3, 4, 0m, 2021 },
                    { 333, 3287m, new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2361m, 1147m, 1194m, 3, "2032385", "AYLENE", "RODRIGUEZ", 10, "45206736", 4, 1, 4, 0m, 2021 },
                    { 363, 4252m, new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3059m, 2164m, 706m, 1, "2032380", "YORDI", "BARRAZA", 17, "45175094", 7, 1, 4, 0m, 2021 },
                    { 368, 3549m, new DateTime(2021, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4040m, 2565m, 1559m, 2, "2032379", "ANABEL", "GARCIA", 9, "16906687", 4, 2, 4, 0m, 2021 },
                    { 374, 2873m, new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2970m, 2110m, 1497m, 3, "2032378", "JOSE", "ESTRADA", 8, "24582177", 7, 1, 4, 2699m, 2021 },
                    { 380, 4601m, new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1106m, 2791m, 642m, 3, "2032377", "DAVID", "MORALES", 17, "23948768", 2, 2, 4, 0m, 2021 },
                    { 399, 2141m, new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3903m, 2695m, 1914m, 1, "2032374", "ROBERTO", "DAVILA", 11, "28080896", 3, 2, 4, 1642m, 2021 },
                    { 401, 2141m, new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2981m, 2633m, 1762m, 1, "2032374", "ROBERTO", "DAVILA", 16, "28080896", 10, 2, 4, 2422m, 2021 },
                    { 404, 3265m, new DateTime(2021, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1072m, 2443m, 1913m, 1, "2032373", "SATURNINO", "MONTENEGRO", 8, "9388196", 10, 3, 4, 0m, 2021 },
                    { 564, 4888m, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2100m, 1661m, 1398m, 1, "2032347", "FRANCISCO", "BALDELOMAR", 11, "32283414", 8, 1, 4, 0m, 2021 },
                    { 580, 2311m, new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2873m, 1273m, 1982m, 2, "2032344", "JONATHAN", "CORONADO", 16, "20152491", 2, 2, 4, 1964m, 2021 },
                    { 583, 3991m, new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3344m, 2983m, 1346m, 1, "2032343", "PEDRO", "ESPINOZA", 15, "18906271", 2, 1, 4, 0m, 2021 },
                    { 9, 4935m, new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3570m, 1132m, 1646m, 3, "2032439", "KATHERINE", "GARCIA", 8, "9041163", 9, 2, 5, 0m, 2021 },
                    { 144, 2194m, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 829m, 2304m, 1349m, 3, "2032417", "RONALDO", "GONZALEZ", 11, "19979160", 9, 2, 5, 2474m, 2021 },
                    { 145, 2784m, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2640m, 2643m, 1533m, 2, "2032416", "HEYLING", "SOZA", 7, "4103692", 8, 2, 5, 3014m, 2021 },
                    { 161, 4439m, new DateTime(2021, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2110m, 2968m, 2186m, 3, "2032414", "ERICK", "VALLECILLO", 15, "24314887", 2, 1, 5, 0m, 2021 },
                    { 163, 3445m, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1595m, 3184m, 1452m, 2, "2032413", "HADSON", "JARQUIN", 9, "25001678", 11, 1, 5, 0m, 2021 },
                    { 166, 3445m, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2948m, 1143m, 672m, 2, "2032413", "HADSON", "JARQUIN", 16, "25001678", 5, 2, 5, 0m, 2021 },
                    { 168, 3445m, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4443m, 1364m, 1051m, 3, "2032413", "HADSON", "JARQUIN", 9, "25001678", 6, 2, 5, 0m, 2021 },
                    { 173, 2933m, new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3534m, 2504m, 874m, 3, "2032412", "LEONARDO", "JUAREZ", 15, "12055409", 6, 1, 5, 3162m, 2021 },
                    { 181, 4821m, new DateTime(2021, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2028m, 1969m, 856m, 1, "2032410", "SERGIO", "REYES", 9, "39191653", 8, 2, 5, 0m, 2021 },
                    { 193, 2499m, new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2450m, 3067m, 1454m, 3, "2032408", "KEVIN", "MAYORGA", 8, "28912452", 7, 3, 5, 2403m, 2021 },
                    { 194, 2499m, new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2633m, 2750m, 1464m, 2, "2032408", "KEVIN", "MAYORGA", 9, "28912452", 2, 1, 5, 2043m, 2021 },
                    { 209, 4470m, new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1505m, 2918m, 2090m, 1, "2032406", "DANILO", "CABEZAS", 14, "40710417", 2, 1, 5, 0m, 2021 },
                    { 213, 4443m, new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1809m, 3280m, 1556m, 1, "2032405", "TANIA", "SANCHEZ", 14, "5677095", 2, 1, 5, 0m, 2021 },
                    { 215, 4443m, new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4625m, 2549m, 1763m, 3, "2032405", "TANIA", "SANCHEZ", 13, "5677095", 4, 2, 5, 0m, 2021 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionID", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeID", "PositionID", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 221, 3398m, new DateTime(2021, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4021m, 2211m, 1245m, 1, "2032404", "KELLY", "CASTANEDA", 10, "27519652", 3, 2, 5, 0m, 2021 },
                    { 223, 4815m, new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3182m, 1333m, 2220m, 3, "2032403", "ENMANUEL", "PALACIOS", 7, "15649980", 9, 3, 5, 0m, 2021 },
                    { 142, 2194m, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1936m, 923m, 1909m, 3, "2032417", "RONALDO", "GONZALEZ", 16, "19979160", 4, 3, 5, 2402m, 2021 },
                    { 243, 3571m, new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 840m, 1947m, 1802m, 1, "2032400", "HILLARY", "ANDINO", 7, "14516770", 10, 3, 5, 0m, 2021 },
                    { 138, 4323m, new DateTime(2021, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3508m, 3280m, 1287m, 1, "2032418", "JUAN", "ALVARADO", 6, "24547021", 7, 3, 5, 0m, 2021 },
                    { 127, 2373m, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3980m, 3171m, 909m, 3, "2032419", "CRISTHIAM", "SANCHEZ", 11, "6470372", 5, 2, 5, 2611m, 2021 },
                    { 12, 4935m, new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2386m, 2898m, 631m, 3, "2032439", "KATHERINE", "GARCIA", 15, "9041163", 8, 1, 5, 0m, 2021 },
                    { 18, 2339m, new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4632m, 2523m, 759m, 2, "2032438", "HAZEL", "OROZCO", 10, "35538733", 1, 3, 5, 1894m, 2021 },
                    { 20, 3128m, new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1963m, 2519m, 1860m, 1, "2032437", "BAYRON", "CHAVEZ", 11, "23711657", 1, 3, 5, 0m, 2021 },
                    { 21, 3128m, new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1607m, 1551m, 1782m, 2, "2032437", "BAYRON", "CHAVEZ", 16, "23711657", 5, 1, 5, 0m, 2021 },
                    { 25, 2304m, new DateTime(2021, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3560m, 1845m, 2243m, 3, "2032436", "DAVID", "RODRIGUEZ", 16, "19133450", 1, 3, 5, 2011m, 2021 },
                    { 28, 2304m, new DateTime(2021, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4127m, 2176m, 1465m, 1, "2032436", "DAVID", "RODRIGUEZ", 11, "19133450", 5, 1, 5, 1899m, 2021 },
                    { 42, 3200m, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 965m, 2355m, 2246m, 1, "2032434", "NORWIN", "SOLANO", 9, "26637654", 6, 3, 5, 0m, 2021 },
                    { 50, 3018m, new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3287m, 2706m, 1243m, 3, "2032432", "MARLING", "CHAVEZ", 9, "31823310", 11, 2, 5, 0m, 2021 },
                    { 61, 3506m, new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4781m, 2875m, 631m, 2, "2032430", "DAYSI", "MONTES", 14, "33954617", 2, 1, 5, 0m, 2021 },
                    { 67, 3374m, new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1623m, 2867m, 850m, 2, "2032429", "MARJORY", "SOLORZANO", 13, "41462124", 10, 1, 5, 0m, 2021 },
                    { 96, 2911m, new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3705m, 2320m, 1947m, 3, "2032425", "HAYDEE", "ARGENAL", 10, "8208741", 8, 2, 5, 3160m, 2021 },
                    { 98, 4596m, new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2808m, 2008m, 1621m, 2, "2032424", "ALEXA", "GUTIERREZ", 9, "4556179", 8, 1, 5, 0m, 2021 },
                    { 100, 4596m, new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2711m, 2215m, 1045m, 1, "2032424", "ALEXA", "GUTIERREZ", 13, "4556179", 9, 1, 5, 0m, 2021 },
                    { 105, 2668m, new DateTime(2021, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1224m, 1840m, 993m, 1, "2032423", "PAMELA", "LOPEZ", 13, "8386388", 3, 1, 5, 2645m, 2021 },
                    { 106, 2668m, new DateTime(2021, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3128m, 2701m, 1784m, 3, "2032423", "PAMELA", "LOPEZ", 17, "8386388", 9, 1, 5, 2589m, 2021 },
                    { 134, 4323m, new DateTime(2021, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4630m, 2939m, 1713m, 2, "2032418", "JUAN", "ALVARADO", 13, "24547021", 3, 1, 5, 0m, 2021 },
                    { 278, 4203m, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4181m, 1212m, 2068m, 2, "2032394", "ELEYDA", "BLANDON", 12, "23466744", 6, 2, 4, 0m, 2021 },
                    { 114, 2844m, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1905m, 2070m, 1383m, 3, "2032422", "OSMAR", "MORALES", 14, "24791557", 5, 1, 6, 2895m, 2021 },
                    { 153, 2072m, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2325m, 1989m, 933m, 3, "2032415", "ARIEL", "BURGOS", 8, "40907956", 5, 2, 6, 1630m, 2021 },
                    { 277, 4203m, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1482m, 1173m, 1350m, 3, "2032394", "ELEYDA", "BLANDON", 13, "23466744", 11, 1, 7, 0m, 2021 },
                    { 292, 3620m, new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4490m, 2482m, 1086m, 3, "2032392", "WILTON", "HUMPHREYS", 11, "3467396", 3, 2, 7, 0m, 2021 },
                    { 299, 3255m, new DateTime(2021, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3788m, 1547m, 1304m, 3, "2032391", "FRANCISCO", "RUIZ", 16, "42818064", 3, 3, 7, 0m, 2021 },
                    { 305, 2174m, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 936m, 2152m, 1085m, 3, "2032390", "NORMA", "TAISIGUE", 8, "42582994", 2, 1, 7, 2205m, 2021 },
                    { 306, 2174m, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3260m, 1040m, 1463m, 3, "2032390", "NORMA", "TAISIGUE", 6, "42582994", 4, 1, 7, 2451m, 2021 },
                    { 308, 2923m, new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1834m, 1768m, 1269m, 1, "2032389", "ENRIQUE", "HERNANDEZ", 7, "26937085", 11, 3, 7, 3087m, 2021 },
                    { 273, 4147m, new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3878m, 1438m, 638m, 3, "2032395", "ERICK", "GARCIA", 11, "16786337", 5, 3, 7, 0m, 2021 },
                    { 309, 2923m, new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4501m, 1872m, 2245m, 3, "2032389", "ENRIQUE", "HERNANDEZ", 17, "26937085", 3, 3, 7, 3164m, 2021 },
                    { 312, 2923m, new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2791m, 2495m, 1615m, 3, "2032389", "ENRIQUE", "HERNANDEZ", 13, "26937085", 10, 3, 7, 3003m, 2021 },
                    { 313, 3920m, new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2488m, 2494m, 1144m, 3, "2032388", "EDDY", "MELENDEZ", 6, "21674906", 5, 1, 7, 0m, 2021 },
                    { 315, 3920m, new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4066m, 2158m, 1132m, 3, "2032388", "EDDY", "MELENDEZ", 17, "21674906", 2, 1, 7, 0m, 2021 },
                    { 318, 3920m, new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3406m, 1828m, 780m, 3, "2032388", "EDDY", "MELENDEZ", 14, "21674906", 9, 3, 7, 0m, 2021 },
                    { 335, 3287m, new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3432m, 2944m, 814m, 2, "2032385", "AYLENE", "RODRIGUEZ", 17, "45206736", 8, 2, 7, 0m, 2021 },
                    { 337, 2414m, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2138m, 3048m, 674m, 3, "2032384", "CARLOS", "ACUNA", 8, "11081906", 8, 3, 7, 2476m, 2021 },
                    { 311, 2923m, new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2484m, 1537m, 852m, 1, "2032389", "ENRIQUE", "HERNANDEZ", 6, "26937085", 9, 1, 7, 3121m, 2021 },
                    { 251, 2315m, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2885m, 2486m, 2211m, 3, "2032399", "BLANCA", "MORALES", 11, "29003040", 10, 3, 7, 2020m, 2021 },
                    { 248, 2315m, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3486m, 3061m, 1998m, 1, "2032399", "BLANCA", "MORALES", 9, "29003040", 8, 3, 7, 2531m, 2021 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionID", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeID", "PositionID", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 241, 3571m, new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2267m, 1521m, 2269m, 3, "2032400", "HILLARY", "ANDINO", 15, "14516770", 1, 2, 7, 0m, 2021 },
                    { 140, 2194m, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1481m, 2915m, 717m, 2, "2032417", "RONALDO", "GONZALEZ", 9, "19979160", 7, 2, 7, 1850m, 2021 },
                    { 158, 4439m, new DateTime(2021, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3909m, 2345m, 634m, 2, "2032414", "ERICK", "VALLECILLO", 7, "24314887", 9, 1, 7, 0m, 2021 },
                    { 165, 3445m, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1928m, 2381m, 1444m, 3, "2032413", "HADSON", "JARQUIN", 15, "25001678", 1, 3, 7, 0m, 2021 },
                    { 176, 3110m, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4334m, 2932m, 1423m, 1, "2032411", "SAULO", "GOMEZ", 8, "26257282", 3, 2, 7, 0m, 2021 },
                    { 179, 3110m, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3657m, 2019m, 1034m, 1, "2032411", "SAULO", "GOMEZ", 7, "26257282", 10, 1, 7, 0m, 2021 },
                    { 180, 3110m, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3358m, 1920m, 2105m, 1, "2032411", "SAULO", "GOMEZ", 15, "26257282", 7, 2, 7, 0m, 2021 },
                    { 184, 4821m, new DateTime(2021, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4217m, 1687m, 893m, 1, "2032410", "SERGIO", "REYES", 8, "39191653", 5, 2, 7, 0m, 2021 },
                    { 187, 2161m, new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3531m, 1366m, 1699m, 2, "2032409", "EYRA", "MEDRANO", 9, "45353442", 8, 2, 7, 2437m, 2021 },
                    { 202, 4296m, new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3509m, 1346m, 1206m, 3, "2032407", "ROXANA", "CUADRA", 14, "35043455", 6, 3, 7, 0m, 2021 },
                    { 212, 4443m, new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3469m, 1948m, 841m, 1, "2032405", "TANIA", "SANCHEZ", 12, "5677095", 7, 1, 7, 0m, 2021 },
                    { 217, 3398m, new DateTime(2021, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4007m, 2751m, 2171m, 3, "2032404", "KELLY", "CASTANEDA", 17, "27519652", 11, 2, 7, 0m, 2021 },
                    { 228, 4815m, new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3584m, 1182m, 1176m, 1, "2032403", "ENMANUEL", "PALACIOS", 14, "15649980", 7, 2, 7, 0m, 2021 },
                    { 236, 4938m, new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4982m, 2176m, 1230m, 1, "2032401", "PAULA", "ORDONEZ", 14, "44111797", 5, 3, 7, 0m, 2021 },
                    { 237, 4938m, new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1194m, 2462m, 1623m, 1, "2032401", "PAULA", "ORDONEZ", 6, "44111797", 1, 3, 7, 0m, 2021 },
                    { 238, 4938m, new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3178m, 2911m, 2109m, 2, "2032401", "PAULA", "ORDONEZ", 15, "44111797", 2, 3, 7, 0m, 2021 },
                    { 346, 2268m, new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4891m, 1751m, 1189m, 3, "2032383", "JUAN", "ALVAREZ", 6, "17193118", 5, 2, 7, 2554m, 2021 },
                    { 369, 3549m, new DateTime(2021, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2841m, 2205m, 1181m, 1, "2032379", "ANABEL", "GARCIA", 7, "16906687", 11, 3, 7, 0m, 2021 },
                    { 371, 3549m, new DateTime(2021, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3261m, 2687m, 1503m, 3, "2032379", "ANABEL", "GARCIA", 14, "16906687", 7, 3, 7, 0m, 2021 },
                    { 373, 2873m, new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1136m, 2520m, 1394m, 1, "2032378", "JOSE", "ESTRADA", 17, "24582177", 10, 1, 7, 2404m, 2021 },
                    { 529, 4463m, new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2180m, 2620m, 1659m, 3, "2032352", "JENNY", "GUZMAN", 12, "25134015", 2, 2, 7, 0m, 2021 },
                    { 532, 4463m, new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4377m, 2128m, 1075m, 1, "2032352", "JENNY", "GUZMAN", 10, "25134015", 10, 2, 7, 0m, 2021 },
                    { 540, 4748m, new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4680m, 2707m, 1281m, 3, "2032351", "DEYRIN", "VINDELL", 15, "16515860", 11, 2, 7, 0m, 2021 },
                    { 542, 2934m, new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1075m, 3209m, 902m, 3, "2032350", "JORGE", "ROMAN", 10, "3440497", 11, 3, 7, 2664m, 2021 },
                    { 546, 2934m, new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1466m, 2039m, 645m, 1, "2032350", "JORGE", "ROMAN", 9, "3440497", 10, 1, 7, 3058m, 2021 },
                    { 547, 2500m, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3731m, 2013m, 1326m, 3, "2032349", "JUAN", "PELAEZ", 6, "39967136", 10, 3, 7, 2194m, 2021 },
                    { 554, 2398m, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1819m, 2041m, 1128m, 2, "2032348", "ALLAN", "CALERO", 11, "20220297", 5, 2, 7, 2600m, 2021 },
                    { 560, 4888m, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1319m, 2630m, 1182m, 2, "2032347", "FRANCISCO", "BALDELOMAR", 12, "32283414", 10, 2, 7, 0m, 2021 },
                    { 562, 4888m, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4300m, 1666m, 1197m, 3, "2032347", "FRANCISCO", "BALDELOMAR", 14, "32283414", 4, 3, 7, 0m, 2021 },
                    { 563, 4888m, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1803m, 927m, 1053m, 2, "2032347", "FRANCISCO", "BALDELOMAR", 14, "32283414", 6, 1, 7, 0m, 2021 },
                    { 566, 3280m, new DateTime(2021, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2292m, 2964m, 2065m, 1, "2032346", "WILLIAM", "GAMBOA", 15, "18632460", 4, 3, 7, 0m, 2021 },
                    { 567, 3280m, new DateTime(2021, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3408m, 2504m, 1687m, 1, "2032346", "WILLIAM", "GAMBOA", 15, "18632460", 8, 2, 7, 0m, 2021 },
                    { 574, 3613m, new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4106m, 2472m, 2056m, 2, "2032345", "LIZANGELA", "RODRIGUEZ", 9, "5980831", 9, 3, 7, 0m, 2021 },
                    { 594, 3990m, new DateTime(2021, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4204m, 2011m, 644m, 2, "2032342", "MARIANO", "SANCHEZ", 10, "39003125", 4, 3, 7, 0m, 2021 },
                    { 598, 3894m, new DateTime(2021, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4827m, 3000m, 1425m, 2, "2032341", "CELESTINO", "BUCARDO", 13, "13039132", 4, 1, 7, 0m, 2021 },
                    { 522, 2435m, new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4110m, 2142m, 1645m, 2, "2032354", "MERY", "PÉREZ", 6, "44749289", 10, 2, 7, 2075m, 2021 },
                    { 121, 4481m, new DateTime(2021, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3940m, 1622m, 969m, 2, "2032420", "OSCAR", "MARTIN", 17, "16206830", 7, 3, 7, 0m, 2021 },
                    { 510, 4010m, new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2967m, 1541m, 1300m, 3, "2032356", "EYDER", "ALVAREZ", 7, "28586950", 4, 1, 7, 0m, 2021 },
                    { 494, 4172m, new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1374m, 1148m, 784m, 3, "2032358", "JAVIER", "ZAMORA", 17, "11428614", 10, 2, 7, 0m, 2021 },
                    { 376, 2873m, new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2435m, 2325m, 1169m, 2, "2032378", "JOSE", "ESTRADA", 7, "24582177", 2, 3, 7, 3086m, 2021 },
                    { 396, 3900m, new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2043m, 2432m, 1556m, 2, "2032375", "LILIA", "VANEGAS", 16, "44387218", 9, 3, 7, 0m, 2021 },
                    { 414, 2184m, new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1908m, 2502m, 1023m, 1, "2032372", "TARSIS", "ACUÑA", 10, "37554912", 4, 1, 7, 2095m, 2021 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionID", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeID", "PositionID", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 428, 4267m, new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3503m, 2035m, 1826m, 2, "2032369", "ENEYDA", "ESPINO", 6, "39714685", 7, 3, 7, 0m, 2021 },
                    { 436, 2880m, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2513m, 3260m, 1827m, 1, "2032368", "LUIS", "LOVO", 7, "19323280", 1, 1, 7, 2523m, 2021 },
                    { 440, 3023m, new DateTime(2021, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1714m, 1481m, 1767m, 3, "2032367", "CARMEN", "MORALES", 12, "11138508", 11, 2, 7, 0m, 2021 },
                    { 445, 2907m, new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2149m, 1500m, 1057m, 3, "2032366", "MOISES", "LAZO", 16, "33568965", 7, 3, 7, 2419m, 2021 },
                    { 446, 2907m, new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2069m, 2514m, 895m, 3, "2032366", "MOISES", "LAZO", 15, "33568965", 6, 1, 7, 2670m, 2021 },
                    { 448, 2907m, new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2686m, 2990m, 1014m, 3, "2032366", "MOISES", "LAZO", 13, "33568965", 4, 3, 7, 3202m, 2021 },
                    { 454, 2932m, new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4787m, 2379m, 1010m, 2, "2032365", "NOE", "BORGE", 14, "30630023", 6, 3, 7, 3009m, 2021 },
                    { 463, 3446m, new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3974m, 3245m, 1890m, 2, "2032363", "NORIEL", "SALGUERA", 10, "20789713", 7, 1, 7, 0m, 2021 },
                    { 469, 3132m, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3436m, 2308m, 1040m, 3, "2032362", "DIANA", "FIGUEROA", 12, "8657208", 11, 3, 7, 0m, 2021 },
                    { 470, 3132m, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 881m, 1722m, 641m, 2, "2032362", "DIANA", "FIGUEROA", 11, "8657208", 7, 3, 7, 0m, 2021 },
                    { 480, 2711m, new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1880m, 912m, 1968m, 2, "2032361", "LUISAMARA", "MORENO", 8, "27450930", 9, 3, 7, 2301m, 2021 },
                    { 484, 3706m, new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2153m, 3257m, 1660m, 1, "2032360", "ANTHONY", "HODGSON", 7, "16413472", 6, 1, 7, 0m, 2021 },
                    { 505, 4010m, new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3552m, 1207m, 967m, 3, "2032356", "EYDER", "ALVAREZ", 17, "28586950", 11, 1, 7, 0m, 2021 },
                    { 149, 2784m, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 972m, 2875m, 1192m, 1, "2032416", "HEYLING", "SOZA", 10, "4103692", 5, 1, 6, 2984m, 2021 },
                    { 117, 2156m, new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4146m, 932m, 1877m, 1, "2032421", "VICTOR", "SANCHEZ", 10, "11512637", 3, 1, 7, 1935m, 2021 },
                    { 104, 2668m, new DateTime(2021, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4342m, 2831m, 2194m, 1, "2032423", "PAMELA", "LOPEZ", 9, "8386388", 5, 2, 7, 2379m, 2021 },
                    { 280, 4203m, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2046m, 966m, 1457m, 3, "2032394", "ELEYDA", "BLANDON", 9, "23466744", 10, 2, 6, 0m, 2021 },
                    { 285, 2956m, new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1666m, 3175m, 919m, 2, "2032393", "HENRY", "ROBLETO", 9, "39969291", 7, 1, 6, 2498m, 2021 },
                    { 290, 3620m, new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1213m, 1544m, 1248m, 1, "2032392", "WILTON", "HUMPHREYS", 15, "3467396", 8, 2, 6, 0m, 2021 },
                    { 303, 2174m, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1529m, 1408m, 2138m, 3, "2032390", "NORMA", "TAISIGUE", 14, "42582994", 8, 2, 6, 2440m, 2021 },
                    { 316, 3920m, new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1695m, 966m, 861m, 1, "2032388", "EDDY", "MELENDEZ", 8, "21674906", 1, 1, 6, 0m, 2021 },
                    { 324, 4430m, new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2460m, 2009m, 1425m, 1, "2032387", "BRYAN", "BERMUDEZ", 12, "3125873", 3, 2, 6, 0m, 2021 },
                    { 272, 4147m, new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4291m, 1038m, 2241m, 3, "2032395", "ERICK", "GARCIA", 15, "16786337", 8, 2, 6, 0m, 2021 },
                    { 332, 3287m, new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4295m, 3063m, 2253m, 1, "2032385", "AYLENE", "RODRIGUEZ", 16, "45206736", 10, 1, 6, 0m, 2021 },
                    { 353, 2740m, new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3725m, 2216m, 2043m, 1, "2032382", "VIRGINIA", "GUIDO", 10, "28542877", 3, 2, 6, 2467m, 2021 },
                    { 355, 4978m, new DateTime(2021, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2883m, 2567m, 961m, 1, "2032381", "LEONEL", "MELENDEZ", 6, "8177551", 2, 1, 6, 0m, 2021 },
                    { 360, 4978m, new DateTime(2021, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2211m, 1006m, 2181m, 2, "2032381", "LEONEL", "MELENDEZ", 12, "8177551", 7, 2, 6, 0m, 2021 },
                    { 366, 4252m, new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1541m, 1342m, 1302m, 1, "2032380", "YORDI", "BARRAZA", 8, "45175094", 11, 3, 6, 0m, 2021 },
                    { 372, 3549m, new DateTime(2021, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4900m, 1003m, 1192m, 2, "2032379", "ANABEL", "GARCIA", 8, "16906687", 10, 3, 6, 0m, 2021 },
                    { 377, 2873m, new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3482m, 1229m, 1640m, 2, "2032378", "JOSE", "ESTRADA", 16, "24582177", 5, 3, 6, 2526m, 2021 },
                    { 342, 2414m, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1769m, 2561m, 1366m, 1, "2032384", "CARLOS", "ACUNA", 11, "11081906", 3, 2, 6, 2363m, 2021 },
                    { 264, 3461m, new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2901m, 2913m, 1747m, 3, "2032397", "JULIA", "GARCIA", 7, "32459349", 5, 3, 6, 0m, 2021 },
                    { 263, 3461m, new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2176m, 1113m, 1649m, 2, "2032397", "JULIA", "GARCIA", 15, "32459349", 7, 1, 6, 0m, 2021 },
                    { 260, 3461m, new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3051m, 2111m, 2278m, 1, "2032397", "JULIA", "GARCIA", 13, "32459349", 1, 1, 6, 0m, 2021 },
                    { 160, 4439m, new DateTime(2021, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4111m, 2942m, 1959m, 3, "2032414", "ERICK", "VALLECILLO", 6, "24314887", 4, 1, 6, 0m, 2021 },
                    { 164, 3445m, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2628m, 2017m, 985m, 1, "2032413", "HADSON", "JARQUIN", 6, "25001678", 2, 2, 6, 0m, 2021 },
                    { 167, 3445m, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2874m, 2792m, 2277m, 3, "2032413", "HADSON", "JARQUIN", 12, "25001678", 4, 2, 6, 0m, 2021 },
                    { 170, 2933m, new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3978m, 1579m, 1507m, 2, "2032412", "LEONARDO", "JUAREZ", 15, "12055409", 1, 2, 6, 2965m, 2021 },
                    { 171, 2933m, new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4210m, 1274m, 764m, 2, "2032412", "LEONARDO", "JUAREZ", 14, "12055409", 3, 3, 6, 2829m, 2021 },
                    { 201, 4296m, new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1329m, 1604m, 1001m, 3, "2032407", "ROXANA", "CUADRA", 17, "35043455", 7, 2, 6, 0m, 2021 },
                    { 210, 4470m, new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1481m, 2404m, 2053m, 1, "2032406", "DANILO", "CABEZAS", 9, "40710417", 6, 2, 6, 0m, 2021 },
                    { 214, 4443m, new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2233m, 1804m, 1523m, 3, "2032405", "TANIA", "SANCHEZ", 10, "5677095", 10, 1, 6, 0m, 2021 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionID", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeID", "PositionID", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 222, 3398m, new DateTime(2021, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2339m, 2633m, 1367m, 2, "2032404", "KELLY", "CASTANEDA", 12, "27519652", 1, 3, 6, 0m, 2021 },
                    { 224, 4815m, new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4978m, 1469m, 2074m, 3, "2032403", "ENMANUEL", "PALACIOS", 10, "15649980", 6, 1, 6, 0m, 2021 },
                    { 227, 4815m, new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1434m, 2930m, 1781m, 3, "2032403", "ENMANUEL", "PALACIOS", 10, "15649980", 2, 2, 6, 0m, 2021 },
                    { 231, 2858m, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 825m, 1529m, 1607m, 3, "2032402", "KARLA", "BLANDINO", 12, "35162403", 4, 1, 6, 2431m, 2021 },
                    { 244, 3571m, new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2307m, 2127m, 1025m, 2, "2032400", "HILLARY", "ANDINO", 17, "14516770", 8, 1, 6, 0m, 2021 },
                    { 255, 3676m, new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1104m, 2081m, 1541m, 3, "2032398", "LESLY", "FERNANDEZ", 14, "21713943", 7, 1, 6, 0m, 2021 },
                    { 258, 3676m, new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1408m, 2488m, 1027m, 2, "2032398", "LESLY", "FERNANDEZ", 6, "21713943", 6, 1, 6, 0m, 2021 },
                    { 390, 2575m, new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4023m, 1932m, 2141m, 3, "2032376", "YELDING", "MEDINA", 6, "8506454", 8, 3, 6, 2536m, 2021 },
                    { 391, 3900m, new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4678m, 2678m, 1144m, 2, "2032375", "LILIA", "VANEGAS", 9, "44387218", 4, 3, 6, 0m, 2021 },
                    { 402, 2141m, new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4135m, 2418m, 1480m, 1, "2032374", "ROBERTO", "DAVILA", 10, "28080896", 11, 2, 6, 1783m, 2021 },
                    { 403, 3265m, new DateTime(2021, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4379m, 1942m, 1593m, 2, "2032373", "SATURNINO", "MONTENEGRO", 16, "9388196", 11, 1, 6, 0m, 2021 },
                    { 579, 2311m, new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3474m, 1250m, 1684m, 1, "2032344", "JONATHAN", "CORONADO", 15, "20152491", 3, 3, 6, 2403m, 2021 },
                    { 589, 3990m, new DateTime(2021, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4980m, 3201m, 2218m, 1, "2032342", "MARIANO", "SANCHEZ", 15, "39003125", 2, 2, 6, 0m, 2021 },
                    { 593, 3990m, new DateTime(2021, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2269m, 2182m, 782m, 1, "2032342", "MARIANO", "SANCHEZ", 11, "39003125", 6, 2, 6, 0m, 2021 },
                    { 5, 4061m, new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3751m, 2536m, 2057m, 3, "2032440", "LUIS", "JUAREZ", 14, "34877450", 8, 3, 7, 0m, 2021 },
                    { 14, 2339m, new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2002m, 1615m, 1806m, 1, "2032438", "HAZEL", "OROZCO", 7, "35538733", 2, 2, 7, 2626m, 2021 },
                    { 22, 3128m, new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1354m, 2572m, 1433m, 1, "2032437", "BAYRON", "CHAVEZ", 14, "23711657", 2, 3, 7, 0m, 2021 },
                    { 31, 2908m, new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1805m, 3063m, 1135m, 1, "2032435", "KARELIA", "VARGAS", 12, "34777526", 5, 2, 7, 3071m, 2021 },
                    { 32, 2908m, new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4773m, 1125m, 1443m, 2, "2032435", "KARELIA", "VARGAS", 16, "34777526", 1, 1, 7, 2861m, 2021 },
                    { 38, 3200m, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 941m, 1809m, 1419m, 3, "2032434", "NORWIN", "SOLANO", 14, "26637654", 10, 1, 7, 0m, 2021 },
                    { 54, 3018m, new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3991m, 2668m, 1376m, 2, "2032432", "MARLING", "CHAVEZ", 10, "31823310", 4, 2, 7, 0m, 2021 },
                    { 64, 3506m, new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3116m, 2787m, 1103m, 2, "2032430", "DAYSI", "MONTES", 13, "33954617", 1, 3, 7, 0m, 2021 },
                    { 73, 2568m, new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1536m, 2607m, 1188m, 1, "2032428", "YENNY", "MARTINEZ", 10, "31111491", 3, 1, 7, 2089m, 2021 },
                    { 74, 2568m, new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4567m, 2529m, 1688m, 2, "2032428", "YENNY", "MARTINEZ", 11, "31111491", 6, 1, 7, 2299m, 2021 },
                    { 82, 4371m, new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4215m, 949m, 2133m, 2, "2032427", "ORA", "JACKSON", 9, "17312991", 3, 3, 7, 0m, 2021 },
                    { 87, 4226m, new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4105m, 1495m, 1483m, 2, "2032426", "ALBIN", "HAMILTON", 11, "31602242", 3, 3, 7, 0m, 2021 },
                    { 569, 3280m, new DateTime(2021, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2645m, 966m, 1820m, 1, "2032346", "WILLIAM", "GAMBOA", 16, "18632460", 5, 2, 6, 0m, 2021 },
                    { 112, 2844m, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2216m, 1135m, 1959m, 2, "2032422", "OSMAR", "MORALES", 13, "24791557", 10, 1, 7, 2517m, 2021 },
                    { 556, 2398m, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2217m, 2302m, 1883m, 1, "2032348", "ALLAN", "CALERO", 8, "20220297", 10, 3, 6, 2042m, 2021 },
                    { 550, 2500m, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2350m, 2946m, 646m, 3, "2032349", "JUAN", "PELAEZ", 17, "39967136", 4, 3, 6, 2709m, 2021 },
                    { 415, 4914m, new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3831m, 2056m, 1408m, 2, "2032371", "GRACIELA", "CABALLERO", 12, "44227272", 10, 2, 6, 0m, 2021 },
                    { 427, 4267m, new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2753m, 2264m, 975m, 2, "2032369", "ENEYDA", "ESPINO", 15, "39714685", 10, 2, 6, 0m, 2021 },
                    { 432, 4267m, new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4515m, 2595m, 2016m, 3, "2032369", "ENEYDA", "ESPINO", 15, "39714685", 11, 3, 6, 0m, 2021 },
                    { 439, 3023m, new DateTime(2021, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2574m, 1879m, 810m, 3, "2032367", "CARMEN", "MORALES", 10, "11138508", 3, 3, 6, 0m, 2021 },
                    { 452, 2932m, new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1923m, 1855m, 1008m, 1, "2032365", "NOE", "BORGE", 7, "30630023", 4, 3, 6, 3210m, 2021 },
                    { 468, 3446m, new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4856m, 2575m, 1679m, 3, "2032363", "NORIEL", "SALGUERA", 14, "20789713", 1, 1, 6, 0m, 2021 },
                    { 486, 3706m, new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2715m, 1052m, 1509m, 2, "2032360", "ANTHONY", "HODGSON", 17, "16413472", 4, 1, 6, 0m, 2021 },
                    { 497, 4172m, new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1646m, 2393m, 978m, 3, "2032358", "JAVIER", "ZAMORA", 14, "11428614", 2, 1, 6, 0m, 2021 },
                    { 508, 4010m, new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2773m, 2521m, 1488m, 1, "2032356", "EYDER", "ALVAREZ", 14, "28586950", 6, 3, 6, 0m, 2021 },
                    { 518, 2435m, new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4247m, 2021m, 1031m, 1, "2032354", "MERY", "PÉREZ", 17, "44749289", 5, 1, 6, 2462m, 2021 },
                    { 521, 2435m, new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3058m, 1370m, 1191m, 1, "2032354", "MERY", "PÉREZ", 16, "44749289", 4, 2, 6, 2501m, 2021 },
                    { 525, 2928m, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3261m, 2183m, 756m, 2, "2032353", "WALTER", "MENDOZA", 10, "25532938", 2, 3, 6, 2448m, 2021 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionID", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeID", "PositionID", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 534, 4463m, new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3345m, 937m, 1844m, 2, "2032352", "JENNY", "GUZMAN", 11, "25134015", 8, 2, 6, 0m, 2021 },
                    { 538, 4748m, new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 894m, 1691m, 618m, 1, "2032351", "DEYRIN", "VINDELL", 17, "16515860", 6, 2, 6, 0m, 2021 },
                    { 539, 4748m, new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4697m, 2458m, 1038m, 3, "2032351", "DEYRIN", "VINDELL", 8, "16515860", 2, 3, 6, 0m, 2021 },
                    { 552, 2500m, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3598m, 2647m, 1250m, 3, "2032349", "JUAN", "PELAEZ", 17, "39967136", 3, 2, 6, 2486m, 2021 },
                    { 274, 4147m, new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2887m, 1389m, 914m, 2, "2032395", "ERICK", "GARCIA", 15, "16786337", 10, 1, 4, 0m, 2021 },
                    { 267, 3276m, new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4818m, 1038m, 955m, 1, "2032396", "REYNALDO", "MEJIA", 8, "39179324", 9, 1, 4, 0m, 2021 },
                    { 262, 3461m, new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 939m, 2545m, 2022m, 3, "2032397", "JULIA", "GARCIA", 11, "32459349", 8, 2, 4, 0m, 2021 },
                    { 188, 2161m, new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4909m, 1920m, 1991m, 2, "2032409", "EYRA", "MEDRANO", 14, "45353442", 11, 3, 2, 2332m, 2021 },
                    { 189, 2161m, new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1161m, 996m, 1390m, 1, "2032409", "EYRA", "MEDRANO", 13, "45353442", 6, 1, 2, 1931m, 2021 },
                    { 191, 2161m, new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3496m, 1574m, 1772m, 1, "2032409", "EYRA", "MEDRANO", 13, "45353442", 5, 3, 2, 1991m, 2021 },
                    { 192, 2161m, new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2585m, 1318m, 832m, 2, "2032409", "EYRA", "MEDRANO", 16, "45353442", 3, 2, 2, 2396m, 2021 },
                    { 195, 2499m, new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 986m, 1741m, 1822m, 1, "2032408", "KEVIN", "MAYORGA", 10, "28912452", 1, 1, 2, 2555m, 2021 },
                    { 198, 2499m, new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2337m, 2131m, 660m, 2, "2032408", "KEVIN", "MAYORGA", 15, "28912452", 9, 1, 2, 2080m, 2021 },
                    { 154, 2072m, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4635m, 2122m, 1994m, 2, "2032415", "ARIEL", "BURGOS", 17, "40907956", 7, 3, 2, 1581m, 2021 },
                    { 199, 4296m, new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3874m, 1490m, 1575m, 3, "2032407", "ROXANA", "CUADRA", 10, "35043455", 9, 2, 2, 0m, 2021 },
                    { 204, 4296m, new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4937m, 3169m, 2155m, 1, "2032407", "ROXANA", "CUADRA", 7, "35043455", 11, 1, 2, 0m, 2021 },
                    { 219, 3398m, new DateTime(2021, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2871m, 2212m, 1045m, 1, "2032404", "KELLY", "CASTANEDA", 10, "27519652", 7, 2, 2, 0m, 2021 },
                    { 220, 3398m, new DateTime(2021, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3376m, 3162m, 909m, 3, "2032404", "KELLY", "CASTANEDA", 14, "27519652", 5, 1, 2, 0m, 2021 },
                    { 226, 4815m, new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3440m, 2367m, 2136m, 3, "2032403", "ENMANUEL", "PALACIOS", 8, "15649980", 4, 1, 2, 0m, 2021 },
                    { 232, 2858m, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1702m, 3175m, 1673m, 1, "2032402", "KARLA", "BLANDINO", 8, "35162403", 10, 3, 2, 3116m, 2021 },
                    { 249, 2315m, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4941m, 2406m, 1791m, 3, "2032399", "BLANCA", "MORALES", 12, "29003040", 2, 1, 2, 2216m, 2021 },
                    { 200, 4296m, new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2589m, 2112m, 2092m, 3, "2032407", "ROXANA", "CUADRA", 9, "35043455", 8, 2, 2, 0m, 2021 },
                    { 150, 2784m, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3347m, 1689m, 1503m, 3, "2032416", "HEYLING", "SOZA", 13, "4103692", 6, 1, 2, 2706m, 2021 },
                    { 148, 2784m, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1551m, 2204m, 778m, 1, "2032416", "HEYLING", "SOZA", 16, "4103692", 4, 1, 2, 2738m, 2021 },
                    { 147, 2784m, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3370m, 1211m, 835m, 2, "2032416", "HEYLING", "SOZA", 11, "4103692", 11, 3, 2, 2724m, 2021 },
                    { 4, 4061m, new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3850m, 3102m, 2084m, 1, "2032440", "LUIS", "JUAREZ", 11, "34877450", 5, 3, 2, 0m, 2021 },
                    { 34, 2908m, new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2943m, 1599m, 1505m, 2, "2032435", "KARELIA", "VARGAS", 11, "34777526", 7, 1, 2, 2478m, 2021 },
                    { 51, 3018m, new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4579m, 3048m, 1122m, 2, "2032432", "MARLING", "CHAVEZ", 14, "31823310", 8, 1, 2, 0m, 2021 },
                    { 78, 2568m, new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2664m, 3277m, 1574m, 3, "2032428", "YENNY", "MARTINEZ", 15, "31111491", 4, 1, 2, 2625m, 2021 },
                    { 81, 4371m, new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3512m, 2367m, 2222m, 1, "2032427", "ORA", "JACKSON", 6, "17312991", 1, 2, 2, 0m, 2021 },
                    { 86, 4226m, new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2292m, 3093m, 1896m, 1, "2032426", "ALBIN", "HAMILTON", 17, "31602242", 2, 2, 2, 0m, 2021 },
                    { 90, 4226m, new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1563m, 2785m, 2094m, 3, "2032426", "ALBIN", "HAMILTON", 11, "31602242", 1, 2, 2, 0m, 2021 },
                    { 94, 2911m, new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1823m, 3151m, 1361m, 3, "2032425", "HAYDEE", "ARGENAL", 17, "8208741", 1, 3, 2, 3058m, 2021 },
                    { 110, 2844m, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3220m, 972m, 992m, 3, "2032422", "OSMAR", "MORALES", 14, "24791557", 8, 1, 2, 2798m, 2021 },
                    { 118, 2156m, new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4947m, 2407m, 1420m, 2, "2032421", "VICTOR", "SANCHEZ", 11, "11512637", 8, 3, 2, 2034m, 2021 },
                    { 119, 2156m, new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2680m, 1086m, 1751m, 1, "2032421", "VICTOR", "SANCHEZ", 9, "11512637", 5, 2, 2, 2264m, 2021 },
                    { 132, 2373m, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4104m, 3078m, 1434m, 1, "2032419", "CRISTHIAM", "SANCHEZ", 16, "6470372", 9, 3, 2, 2097m, 2021 },
                    { 136, 4323m, new DateTime(2021, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2455m, 2471m, 2084m, 1, "2032418", "JUAN", "ALVARADO", 12, "24547021", 5, 1, 2, 0m, 2021 },
                    { 143, 2194m, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3525m, 1793m, 2052m, 2, "2032417", "RONALDO", "GONZALEZ", 7, "19979160", 11, 1, 2, 1945m, 2021 },
                    { 146, 2784m, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2332m, 1922m, 696m, 3, "2032416", "HEYLING", "SOZA", 11, "4103692", 1, 3, 2, 2383m, 2021 },
                    { 250, 2315m, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3154m, 2005m, 1715m, 1, "2032399", "BLANCA", "MORALES", 6, "29003040", 6, 3, 2, 2275m, 2021 },
                    { 261, 3461m, new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4843m, 1774m, 644m, 1, "2032397", "JULIA", "GARCIA", 11, "32459349", 11, 2, 2, 0m, 2021 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionID", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeID", "PositionID", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 265, 3276m, new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3654m, 1520m, 1383m, 2, "2032396", "REYNALDO", "MEJIA", 9, "39179324", 4, 1, 2, 0m, 2021 },
                    { 270, 3276m, new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3721m, 1088m, 1225m, 2, "2032396", "REYNALDO", "MEJIA", 10, "39179324", 11, 2, 2, 0m, 2021 },
                    { 421, 2541m, new DateTime(2021, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 978m, 3214m, 1634m, 1, "2032370", "EMPERATRIZ", "BLANDINO", 14, "5419134", 11, 3, 2, 2451m, 2021 },
                    { 425, 2541m, new DateTime(2021, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1259m, 1728m, 2151m, 1, "2032370", "EMPERATRIZ", "BLANDINO", 6, "5419134", 4, 3, 2, 2423m, 2021 },
                    { 429, 4267m, new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4710m, 2908m, 1099m, 3, "2032369", "ENEYDA", "ESPINO", 11, "39714685", 1, 3, 2, 0m, 2021 },
                    { 455, 2932m, new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2570m, 1666m, 1963m, 2, "2032365", "NOE", "BORGE", 13, "30630023", 8, 3, 2, 2794m, 2021 },
                    { 456, 2932m, new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 895m, 2912m, 1027m, 1, "2032365", "NOE", "BORGE", 11, "30630023", 10, 2, 2, 2824m, 2021 },
                    { 461, 4683m, new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3347m, 2313m, 763m, 1, "2032364", "JAY", "TORRENTES", 15, "21675930", 1, 1, 2, 0m, 2021 },
                    { 472, 3132m, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2723m, 2303m, 1300m, 1, "2032362", "DIANA", "FIGUEROA", 17, "8657208", 2, 2, 2, 0m, 2021 },
                    { 475, 2711m, new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1249m, 2247m, 1685m, 3, "2032361", "LUISAMARA", "MORENO", 10, "27450930", 10, 2, 2, 2883m, 2021 },
                    { 476, 2711m, new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1362m, 1922m, 1275m, 3, "2032361", "LUISAMARA", "MORENO", 17, "27450930", 2, 3, 2, 2403m, 2021 },
                    { 479, 2711m, new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4354m, 2645m, 1528m, 2, "2032361", "LUISAMARA", "MORENO", 14, "27450930", 6, 2, 2, 2779m, 2021 },
                    { 493, 4172m, new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3549m, 1367m, 2110m, 3, "2032358", "JAVIER", "ZAMORA", 10, "11428614", 8, 1, 2, 0m, 2021 },
                    { 499, 4133m, new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4482m, 1038m, 1512m, 1, "2032357", "ELIZABETH", "JUÁREZ", 16, "6918240", 10, 2, 2, 0m, 2021 },
                    { 513, 2785m, new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2772m, 2978m, 1502m, 2, "2032355", "GIOCONDA", "ESPINO", 6, "42872115", 3, 3, 2, 2982m, 2021 },
                    { 517, 2435m, new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4045m, 1977m, 729m, 3, "2032354", "MERY", "PÉREZ", 12, "44749289", 6, 3, 2, 2441m, 2021 },
                    { 519, 2435m, new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3899m, 1346m, 1903m, 3, "2032354", "MERY", "PÉREZ", 12, "44749289", 9, 2, 2, 2429m, 2021 },
                    { 409, 2184m, new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1871m, 3130m, 829m, 1, "2032372", "TARSIS", "ACUÑA", 14, "37554912", 9, 1, 2, 1910m, 2021 },
                    { 1, 4061m, new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4858m, 1016m, 1683m, 1, "2032440", "LUIS", "JUAREZ", 12, "34877450", 4, 2, 2, 0m, 2021 },
                    { 383, 4601m, new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4073m, 2852m, 1078m, 1, "2032377", "DAVID", "MORALES", 9, "23948768", 4, 3, 2, 0m, 2021 },
                    { 370, 3549m, new DateTime(2021, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3725m, 1590m, 2077m, 2, "2032379", "ANABEL", "GARCIA", 7, "16906687", 1, 2, 2, 0m, 2021 },
                    { 288, 2956m, new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4636m, 1213m, 1213m, 2, "2032393", "HENRY", "ROBLETO", 12, "39969291", 10, 1, 2, 3137m, 2021 },
                    { 289, 3620m, new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 864m, 2391m, 700m, 1, "2032392", "WILTON", "HUMPHREYS", 6, "3467396", 4, 2, 2, 0m, 2021 },
                    { 321, 4430m, new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1749m, 1378m, 2219m, 1, "2032387", "BRYAN", "BERMUDEZ", 6, "3125873", 4, 1, 2, 0m, 2021 },
                    { 325, 3976m, new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4728m, 2210m, 1261m, 2, "2032386", "ALVIN", "ARAICA", 12, "5434979", 1, 2, 2, 0m, 2021 },
                    { 326, 3976m, new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1683m, 1893m, 1456m, 1, "2032386", "ALVIN", "ARAICA", 7, "5434979", 2, 1, 2, 0m, 2021 },
                    { 327, 3976m, new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2235m, 1879m, 1455m, 3, "2032386", "ALVIN", "ARAICA", 7, "5434979", 3, 3, 2, 0m, 2021 },
                    { 330, 3976m, new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3749m, 2412m, 679m, 1, "2032386", "ALVIN", "ARAICA", 9, "5434979", 10, 1, 2, 0m, 2021 },
                    { 334, 3287m, new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3245m, 1193m, 1538m, 2, "2032385", "AYLENE", "RODRIGUEZ", 15, "45206736", 9, 2, 2, 0m, 2021 },
                    { 339, 2414m, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1461m, 3232m, 745m, 3, "2032384", "CARLOS", "ACUNA", 14, "11081906", 7, 1, 2, 2638m, 2021 },
                    { 341, 2414m, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1411m, 2298m, 1602m, 2, "2032384", "CARLOS", "ACUNA", 6, "11081906", 1, 3, 2, 2340m, 2021 },
                    { 344, 2268m, new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 833m, 2974m, 1569m, 1, "2032383", "JUAN", "ALVAREZ", 8, "17193118", 7, 2, 2, 2555m, 2021 },
                    { 348, 2268m, new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4847m, 2672m, 760m, 1, "2032383", "JUAN", "ALVAREZ", 8, "17193118", 3, 2, 2, 2489m, 2021 },
                    { 352, 2740m, new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 931m, 2041m, 1784m, 1, "2032382", "VIRGINIA", "GUIDO", 6, "28542877", 4, 1, 2, 2441m, 2021 },
                    { 356, 4978m, new DateTime(2021, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2162m, 3002m, 2290m, 1, "2032381", "LEONEL", "MELENDEZ", 14, "8177551", 11, 2, 2, 0m, 2021 },
                    { 367, 3549m, new DateTime(2021, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2933m, 2963m, 966m, 2, "2032379", "ANABEL", "GARCIA", 9, "16906687", 5, 3, 2, 0m, 2021 },
                    { 381, 4601m, new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1120m, 2874m, 619m, 1, "2032377", "DAVID", "MORALES", 9, "23948768", 3, 3, 2, 0m, 2021 },
                    { 520, 2435m, new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1745m, 1288m, 846m, 3, "2032354", "MERY", "PÉREZ", 12, "44749289", 11, 1, 2, 2280m, 2021 },
                    { 595, 3894m, new DateTime(2021, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2959m, 1677m, 1730m, 2, "2032341", "CELESTINO", "BUCARDO", 17, "13039132", 7, 2, 1, 0m, 2021 },
                    { 578, 2311m, new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4185m, 1515m, 1143m, 2, "2032344", "JONATHAN", "CORONADO", 15, "20152491", 7, 1, 1, 1860m, 2021 },
                    { 133, 4323m, new DateTime(2021, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 913m, 3111m, 1931m, 3, "2032418", "JUAN", "ALVARADO", 10, "24547021", 11, 1, 1, 0m, 2021 },
                    { 152, 2072m, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4153m, 1616m, 1672m, 2, "2032415", "ARIEL", "BURGOS", 6, "40907956", 3, 1, 1, 1910m, 2021 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionID", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeID", "PositionID", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 156, 2072m, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3197m, 1409m, 1984m, 3, "2032415", "ARIEL", "BURGOS", 14, "40907956", 9, 2, 1, 1710m, 2021 },
                    { 183, 4821m, new DateTime(2021, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2135m, 3075m, 2156m, 1, "2032410", "SERGIO", "REYES", 7, "39191653", 7, 2, 1, 0m, 2021 },
                    { 186, 4821m, new DateTime(2021, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3174m, 2672m, 861m, 2, "2032410", "SERGIO", "REYES", 16, "39191653", 6, 3, 1, 0m, 2021 },
                    { 196, 2499m, new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 846m, 2578m, 1266m, 2, "2032408", "KEVIN", "MAYORGA", 9, "28912452", 6, 3, 1, 2661m, 2021 },
                    { 124, 4481m, new DateTime(2021, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2246m, 2121m, 1427m, 2, "2032420", "OSCAR", "MARTIN", 8, "16206830", 10, 1, 1, 0m, 2021 },
                    { 197, 2499m, new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3945m, 2205m, 697m, 3, "2032408", "KEVIN", "MAYORGA", 8, "28912452", 5, 2, 1, 2727m, 2021 },
                    { 206, 4470m, new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2097m, 1635m, 2017m, 2, "2032406", "DANILO", "CABEZAS", 13, "40710417", 3, 1, 1, 0m, 2021 },
                    { 208, 4470m, new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3366m, 2360m, 1354m, 1, "2032406", "DANILO", "CABEZAS", 16, "40710417", 5, 2, 1, 0m, 2021 },
                    { 225, 4815m, new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2132m, 2412m, 709m, 3, "2032403", "ENMANUEL", "PALACIOS", 8, "15649980", 10, 2, 1, 0m, 2021 },
                    { 242, 3571m, new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4201m, 963m, 1045m, 2, "2032400", "HILLARY", "ANDINO", 15, "14516770", 7, 1, 1, 0m, 2021 },
                    { 259, 3461m, new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1773m, 1928m, 2223m, 1, "2032397", "JULIA", "GARCIA", 13, "32459349", 6, 2, 1, 0m, 2021 },
                    { 266, 3276m, new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2932m, 1964m, 1002m, 1, "2032396", "REYNALDO", "MEJIA", 12, "39179324", 7, 1, 1, 0m, 2021 },
                    { 205, 4470m, new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4183m, 2884m, 1348m, 1, "2032406", "DANILO", "CABEZAS", 12, "40710417", 1, 1, 1, 0m, 2021 },
                    { 120, 2156m, new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4870m, 1603m, 2265m, 2, "2032421", "VICTOR", "SANCHEZ", 17, "11512637", 6, 3, 1, 2012m, 2021 },
                    { 113, 2844m, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1740m, 1915m, 820m, 3, "2032422", "OSMAR", "MORALES", 8, "24791557", 9, 1, 1, 2362m, 2021 },
                    { 101, 4596m, new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 984m, 3273m, 1146m, 1, "2032424", "ALEXA", "GUTIERREZ", 13, "4556179", 7, 2, 1, 0m, 2021 },
                    { 11, 4935m, new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2854m, 1694m, 1408m, 3, "2032439", "KATHERINE", "GARCIA", 6, "9041163", 5, 1, 1, 0m, 2021 },
                    { 17, 2339m, new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2161m, 901m, 620m, 1, "2032438", "HAZEL", "OROZCO", 7, "35538733", 5, 1, 1, 2508m, 2021 },
                    { 33, 2908m, new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2265m, 1856m, 1036m, 1, "2032435", "KARELIA", "VARGAS", 10, "34777526", 2, 3, 1, 3183m, 2021 },
                    { 35, 2908m, new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4820m, 3173m, 863m, 1, "2032435", "KARELIA", "VARGAS", 14, "34777526", 4, 2, 1, 3036m, 2021 },
                    { 37, 3200m, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3802m, 2274m, 1033m, 1, "2032434", "NORWIN", "SOLANO", 8, "26637654", 11, 1, 1, 0m, 2021 },
                    { 40, 3200m, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2199m, 1467m, 2069m, 3, "2032434", "NORWIN", "SOLANO", 14, "26637654", 4, 2, 1, 0m, 2021 },
                    { 62, 3506m, new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2438m, 2644m, 961m, 3, "2032430", "DAYSI", "MONTES", 15, "33954617", 5, 1, 1, 0m, 2021 },
                    { 65, 3506m, new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2546m, 2791m, 1473m, 2, "2032430", "DAYSI", "MONTES", 15, "33954617", 3, 1, 1, 0m, 2021 },
                    { 66, 3506m, new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1803m, 2658m, 901m, 3, "2032430", "DAYSI", "MONTES", 15, "33954617", 8, 1, 1, 0m, 2021 },
                    { 69, 3374m, new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3662m, 2166m, 2087m, 2, "2032429", "MARJORY", "SOLORZANO", 7, "41462124", 11, 2, 1, 0m, 2021 },
                    { 70, 3374m, new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4911m, 1937m, 1637m, 3, "2032429", "MARJORY", "SOLORZANO", 15, "41462124", 4, 2, 1, 0m, 2021 },
                    { 72, 3374m, new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3830m, 1332m, 1134m, 1, "2032429", "MARJORY", "SOLORZANO", 13, "41462124", 6, 2, 1, 0m, 2021 },
                    { 75, 2568m, new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2476m, 3203m, 1257m, 3, "2032428", "YENNY", "MARTINEZ", 10, "31111491", 5, 3, 1, 2840m, 2021 },
                    { 91, 2911m, new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2144m, 2021m, 2249m, 3, "2032425", "HAYDEE", "ARGENAL", 17, "8208741", 6, 2, 1, 3158m, 2021 },
                    { 92, 2911m, new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1211m, 1667m, 2142m, 1, "2032425", "HAYDEE", "ARGENAL", 14, "8208741", 5, 2, 1, 2450m, 2021 },
                    { 271, 4147m, new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4748m, 1982m, 617m, 2, "2032395", "ERICK", "GARCIA", 14, "16786337", 9, 1, 1, 0m, 2021 },
                    { 295, 3255m, new DateTime(2021, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2821m, 2575m, 1442m, 3, "2032391", "FRANCISCO", "RUIZ", 12, "42818064", 5, 2, 1, 0m, 2021 },
                    { 302, 2174m, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1208m, 1964m, 1623m, 1, "2032390", "NORMA", "TAISIGUE", 17, "42582994", 11, 1, 1, 1851m, 2021 },
                    { 314, 3920m, new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4851m, 3025m, 804m, 3, "2032388", "EDDY", "MELENDEZ", 17, "21674906", 10, 2, 1, 0m, 2021 },
                    { 465, 3446m, new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 991m, 2626m, 1996m, 2, "2032363", "NORIEL", "SALGUERA", 12, "20789713", 2, 2, 1, 0m, 2021 },
                    { 471, 3132m, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2193m, 3028m, 2212m, 2, "2032362", "DIANA", "FIGUEROA", 17, "8657208", 6, 3, 1, 0m, 2021 },
                    { 474, 3132m, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1841m, 1865m, 1561m, 3, "2032362", "DIANA", "FIGUEROA", 8, "8657208", 8, 1, 1, 0m, 2021 },
                    { 477, 2711m, new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1584m, 1347m, 1788m, 3, "2032361", "LUISAMARA", "MORENO", 7, "27450930", 3, 2, 1, 2971m, 2021 },
                    { 487, 2927m, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2163m, 2440m, 721m, 2, "2032359", "PERLA", "CABRERA", 17, "40578545", 9, 2, 1, 2808m, 2021 },
                    { 490, 2927m, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2720m, 2388m, 707m, 3, "2032359", "PERLA", "CABRERA", 11, "40578545", 5, 2, 1, 2577m, 2021 },
                    { 491, 2927m, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3784m, 2915m, 2219m, 1, "2032359", "PERLA", "CABRERA", 14, "40578545", 10, 2, 1, 3062m, 2021 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionID", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeID", "PositionID", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 501, 4133m, new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1490m, 3139m, 612m, 3, "2032357", "ELIZABETH", "JUÁREZ", 6, "6918240", 5, 1, 1, 0m, 2021 },
                    { 504, 4133m, new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2615m, 1780m, 773m, 3, "2032357", "ELIZABETH", "JUÁREZ", 11, "6918240", 1, 1, 1, 0m, 2021 },
                    { 512, 2785m, new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2186m, 1974m, 2257m, 2, "2032355", "GIOCONDA", "ESPINO", 9, "42872115", 4, 3, 1, 2881m, 2021 },
                    { 535, 4748m, new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1817m, 1836m, 2026m, 1, "2032351", "DEYRIN", "VINDELL", 10, "16515860", 7, 2, 1, 0m, 2021 },
                    { 544, 2934m, new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2078m, 2034m, 2230m, 3, "2032350", "JORGE", "ROMAN", 6, "3440497", 5, 3, 1, 3137m, 2021 },
                    { 553, 2398m, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 861m, 2968m, 1721m, 2, "2032348", "ALLAN", "CALERO", 16, "20220297", 4, 2, 1, 2259m, 2021 },
                    { 561, 4888m, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4814m, 1626m, 2199m, 2, "2032347", "FRANCISCO", "BALDELOMAR", 15, "32283414", 7, 2, 1, 0m, 2021 },
                    { 571, 3613m, new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1506m, 1379m, 891m, 2, "2032345", "LIZANGELA", "RODRIGUEZ", 9, "5980831", 6, 3, 1, 0m, 2021 },
                    { 462, 4683m, new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1294m, 2093m, 826m, 1, "2032364", "JAY", "TORRENTES", 12, "21675930", 9, 3, 1, 0m, 2021 },
                    { 585, 3991m, new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2009m, 1227m, 1031m, 3, "2032343", "PEDRO", "ESPINOZA", 8, "18906271", 11, 1, 1, 0m, 2021 },
                    { 449, 2907m, new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4805m, 1683m, 1698m, 3, "2032366", "MOISES", "LAZO", 16, "33568965", 1, 1, 1, 3206m, 2021 },
                    { 435, 2880m, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1424m, 1438m, 1201m, 1, "2032368", "LUIS", "LOVO", 7, "19323280", 2, 1, 1, 3176m, 2021 },
                    { 319, 4430m, new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4287m, 2652m, 1137m, 2, "2032387", "BRYAN", "BERMUDEZ", 13, "3125873", 5, 3, 1, 0m, 2021 },
                    { 340, 2414m, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3070m, 2086m, 1898m, 3, "2032384", "CARLOS", "ACUNA", 6, "11081906", 5, 3, 1, 1980m, 2021 },
                    { 345, 2268m, new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4996m, 2320m, 1472m, 2, "2032383", "JUAN", "ALVAREZ", 7, "17193118", 8, 1, 1, 1841m, 2021 },
                    { 349, 2740m, new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1901m, 1755m, 1578m, 2, "2032382", "VIRGINIA", "GUIDO", 8, "28542877", 6, 3, 1, 2599m, 2021 },
                    { 351, 2740m, new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3517m, 3051m, 922m, 1, "2032382", "VIRGINIA", "GUIDO", 7, "28542877", 2, 3, 1, 2786m, 2021 },
                    { 364, 4252m, new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2196m, 1759m, 2125m, 2, "2032380", "YORDI", "BARRAZA", 7, "45175094", 5, 1, 1, 0m, 2021 },
                    { 378, 2873m, new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1325m, 2631m, 2055m, 3, "2032378", "JOSE", "ESTRADA", 11, "24582177", 3, 3, 1, 2662m, 2021 },
                    { 379, 4601m, new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3193m, 1101m, 1459m, 3, "2032377", "DAVID", "MORALES", 7, "23948768", 11, 3, 1, 0m, 2021 },
                    { 386, 2575m, new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3298m, 2378m, 635m, 1, "2032376", "YELDING", "MEDINA", 6, "8506454", 11, 1, 1, 2392m, 2021 },
                    { 398, 2141m, new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2937m, 1884m, 1381m, 2, "2032374", "ROBERTO", "DAVILA", 8, "28080896", 5, 3, 1, 2380m, 2021 },
                    { 400, 2141m, new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4407m, 2354m, 1683m, 1, "2032374", "ROBERTO", "DAVILA", 15, "28080896", 4, 2, 1, 1828m, 2021 },
                    { 408, 3265m, new DateTime(2021, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2364m, 2892m, 881m, 1, "2032373", "SATURNINO", "MONTENEGRO", 16, "9388196", 4, 2, 1, 0m, 2021 },
                    { 410, 2184m, new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2124m, 2058m, 1797m, 3, "2032372", "TARSIS", "ACUÑA", 8, "37554912", 1, 3, 1, 2367m, 2021 },
                    { 424, 2541m, new DateTime(2021, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1800m, 971m, 921m, 1, "2032370", "EMPERATRIZ", "BLANDINO", 10, "5419134", 5, 1, 1, 2815m, 2021 },
                    { 431, 4267m, new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3317m, 2794m, 1036m, 3, "2032369", "ENEYDA", "ESPINO", 8, "39714685", 2, 2, 1, 0m, 2021 },
                    { 442, 3023m, new DateTime(2021, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 939m, 1908m, 1380m, 3, "2032367", "CARMEN", "MORALES", 10, "11138508", 4, 2, 1, 0m, 2021 },
                    { 524, 2928m, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1449m, 3037m, 767m, 2, "2032353", "WALTER", "MENDOZA", 14, "25532938", 6, 1, 2, 2494m, 2021 },
                    { 530, 4463m, new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3749m, 2984m, 1415m, 3, "2032352", "JENNY", "GUZMAN", 12, "25134015", 4, 2, 2, 0m, 2021 },
                    { 536, 4748m, new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4755m, 2333m, 812m, 1, "2032351", "DEYRIN", "VINDELL", 15, "16515860", 4, 1, 2, 0m, 2021 },
                    { 568, 3280m, new DateTime(2021, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2717m, 1490m, 902m, 1, "2032346", "WILLIAM", "GAMBOA", 10, "18632460", 7, 2, 3, 0m, 2021 },
                    { 576, 3613m, new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1805m, 1623m, 2046m, 1, "2032345", "LIZANGELA", "RODRIGUEZ", 14, "5980831", 1, 2, 3, 0m, 2021 },
                    { 577, 2311m, new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4657m, 2114m, 824m, 1, "2032344", "JONATHAN", "CORONADO", 9, "20152491", 11, 1, 3, 2151m, 2021 },
                    { 581, 2311m, new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2844m, 2032m, 1153m, 2, "2032344", "JONATHAN", "CORONADO", 10, "20152491", 1, 2, 3, 1860m, 2021 },
                    { 586, 3991m, new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1875m, 2972m, 1216m, 1, "2032343", "PEDRO", "ESPINOZA", 15, "18906271", 6, 1, 3, 0m, 2021 },
                    { 587, 3991m, new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2019m, 2701m, 1414m, 3, "2032343", "PEDRO", "ESPINOZA", 11, "18906271", 4, 3, 3, 0m, 2021 },
                    { 565, 3280m, new DateTime(2021, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3945m, 1235m, 1487m, 3, "2032346", "WILLIAM", "GAMBOA", 16, "18632460", 9, 1, 3, 0m, 2021 },
                    { 591, 3990m, new DateTime(2021, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2024m, 1610m, 2072m, 2, "2032342", "MARIANO", "SANCHEZ", 17, "39003125", 11, 1, 3, 0m, 2021 },
                    { 7, 4935m, new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1825m, 2833m, 2075m, 2, "2032439", "KATHERINE", "GARCIA", 16, "9041163", 11, 3, 4, 0m, 2021 },
                    { 8, 4935m, new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1982m, 2608m, 920m, 1, "2032439", "KATHERINE", "GARCIA", 7, "9041163", 2, 2, 4, 0m, 2021 },
                    { 13, 2339m, new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1528m, 1853m, 967m, 1, "2032438", "HAZEL", "OROZCO", 10, "35538733", 8, 1, 4, 1897m, 2021 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionID", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeID", "PositionID", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 16, 2339m, new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3768m, 2027m, 1546m, 1, "2032438", "HAZEL", "OROZCO", 10, "35538733", 9, 1, 4, 1999m, 2021 },
                    { 23, 3128m, new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1602m, 1010m, 1547m, 1, "2032437", "BAYRON", "CHAVEZ", 16, "23711657", 10, 3, 4, 0m, 2021 },
                    { 29, 2304m, new DateTime(2021, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2960m, 1511m, 753m, 2, "2032436", "DAVID", "RODRIGUEZ", 17, "19133450", 3, 1, 4, 1884m, 2021 },
                    { 2, 4061m, new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4174m, 2656m, 1704m, 3, "2032440", "LUIS", "JUAREZ", 7, "34877450", 3, 3, 4, 0m, 2021 },
                    { 555, 2398m, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3597m, 2319m, 946m, 1, "2032348", "ALLAN", "CALERO", 11, "20220297", 1, 2, 3, 2392m, 2021 },
                    { 545, 2934m, new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3120m, 3245m, 2260m, 1, "2032350", "JORGE", "ROMAN", 7, "3440497", 6, 2, 3, 2621m, 2021 },
                    { 543, 2934m, new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 919m, 2701m, 2179m, 1, "2032350", "JORGE", "ROMAN", 10, "3440497", 1, 2, 3, 2975m, 2021 },
                    { 417, 4914m, new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4742m, 1589m, 1862m, 2, "2032371", "GRACIELA", "CABALLERO", 14, "44227272", 6, 2, 3, 0m, 2021 },
                    { 418, 4914m, new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4035m, 3190m, 651m, 3, "2032371", "GRACIELA", "CABALLERO", 10, "44227272", 2, 2, 3, 0m, 2021 },
                    { 419, 4914m, new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1248m, 1010m, 1712m, 3, "2032371", "GRACIELA", "CABALLERO", 13, "44227272", 1, 3, 3, 0m, 2021 },
                    { 423, 2541m, new DateTime(2021, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4468m, 1395m, 1813m, 2, "2032370", "EMPERATRIZ", "BLANDINO", 8, "5419134", 7, 2, 3, 2073m, 2021 },
                    { 433, 2880m, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1268m, 1982m, 2241m, 2, "2032368", "LUIS", "LOVO", 14, "19323280", 11, 2, 3, 2867m, 2021 },
                    { 434, 2880m, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2597m, 1277m, 1906m, 3, "2032368", "LUIS", "LOVO", 13, "19323280", 6, 2, 3, 2465m, 2021 },
                    { 437, 2880m, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1451m, 2984m, 2257m, 3, "2032368", "LUIS", "LOVO", 11, "19323280", 3, 2, 3, 2526m, 2021 },
                    { 444, 3023m, new DateTime(2021, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2665m, 3163m, 677m, 3, "2032367", "CARMEN", "MORALES", 17, "11138508", 2, 1, 3, 0m, 2021 },
                    { 447, 2907m, new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4273m, 1491m, 1234m, 1, "2032366", "MOISES", "LAZO", 16, "33568965", 2, 3, 3, 3107m, 2021 },
                    { 450, 2907m, new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1423m, 1634m, 2015m, 1, "2032366", "MOISES", "LAZO", 15, "33568965", 10, 2, 3, 2470m, 2021 },
                    { 457, 4683m, new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2657m, 2195m, 1196m, 1, "2032364", "JAY", "TORRENTES", 10, "21675930", 3, 3, 3, 0m, 2021 },
                    { 459, 4683m, new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4191m, 2359m, 1734m, 2, "2032364", "JAY", "TORRENTES", 9, "21675930", 4, 2, 3, 0m, 2021 },
                    { 485, 3706m, new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2355m, 2015m, 605m, 3, "2032360", "ANTHONY", "HODGSON", 16, "16413472", 11, 1, 3, 0m, 2021 },
                    { 489, 2927m, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3121m, 1044m, 1079m, 3, "2032359", "PERLA", "CABRERA", 9, "40578545", 8, 2, 3, 2513m, 2021 },
                    { 500, 4133m, new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3289m, 2023m, 1814m, 2, "2032357", "ELIZABETH", "JUÁREZ", 15, "6918240", 6, 3, 3, 0m, 2021 },
                    { 30, 2304m, new DateTime(2021, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2662m, 2396m, 1451m, 3, "2032436", "DAVID", "RODRIGUEZ", 10, "19133450", 9, 3, 4, 2101m, 2021 },
                    { 36, 2908m, new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1739m, 1291m, 1589m, 3, "2032435", "KARELIA", "VARGAS", 11, "34777526", 8, 2, 4, 3108m, 2021 },
                    { 43, 3001m, new DateTime(2021, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1638m, 2665m, 1848m, 2, "2032433", "FRANCISCO", "ESPINOZA", 12, "38022829", 11, 3, 4, 0m, 2021 },
                    { 44, 3001m, new DateTime(2021, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 847m, 3257m, 1866m, 3, "2032433", "FRANCISCO", "ESPINOZA", 14, "38022829", 2, 2, 4, 0m, 2021 },
                    { 135, 4323m, new DateTime(2021, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2667m, 2664m, 2254m, 1, "2032418", "JUAN", "ALVARADO", 8, "24547021", 1, 3, 4, 0m, 2021 },
                    { 151, 2072m, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2242m, 2011m, 1089m, 2, "2032415", "ARIEL", "BURGOS", 15, "40907956", 6, 1, 4, 1686m, 2021 },
                    { 157, 4439m, new DateTime(2021, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3943m, 2051m, 1444m, 1, "2032414", "ERICK", "VALLECILLO", 17, "24314887", 5, 1, 4, 0m, 2021 },
                    { 174, 2933m, new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2944m, 1499m, 1853m, 3, "2032412", "LEONARDO", "JUAREZ", 15, "12055409", 2, 1, 4, 2946m, 2021 },
                    { 175, 3110m, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3554m, 1082m, 1673m, 2, "2032411", "SAULO", "GOMEZ", 15, "26257282", 2, 1, 4, 0m, 2021 },
                    { 178, 3110m, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1271m, 2954m, 1977m, 3, "2032411", "SAULO", "GOMEZ", 6, "26257282", 6, 1, 4, 0m, 2021 },
                    { 185, 4821m, new DateTime(2021, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4757m, 1044m, 649m, 2, "2032410", "SERGIO", "REYES", 8, "39191653", 1, 1, 4, 0m, 2021 },
                    { 203, 4296m, new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3591m, 2898m, 1980m, 1, "2032407", "ROXANA", "CUADRA", 14, "35043455", 3, 1, 4, 0m, 2021 },
                    { 207, 4470m, new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4042m, 900m, 670m, 2, "2032406", "DANILO", "CABEZAS", 11, "40710417", 7, 1, 4, 0m, 2021 },
                    { 216, 4443m, new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1406m, 2445m, 1773m, 2, "2032405", "TANIA", "SANCHEZ", 13, "5677095", 11, 1, 4, 0m, 2021 },
                    { 233, 2858m, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4881m, 1443m, 628m, 1, "2032402", "KARLA", "BLANDINO", 6, "35162403", 9, 1, 4, 2876m, 2021 },
                    { 240, 4938m, new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3370m, 2321m, 1480m, 3, "2032401", "PAULA", "ORDONEZ", 12, "44111797", 8, 1, 4, 0m, 2021 },
                    { 246, 3571m, new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1664m, 1220m, 923m, 1, "2032400", "HILLARY", "ANDINO", 7, "14516770", 9, 1, 4, 0m, 2021 },
                    { 247, 2315m, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3203m, 2342m, 1361m, 2, "2032399", "BLANCA", "MORALES", 6, "29003040", 7, 2, 4, 2343m, 2021 },
                    { 257, 3676m, new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1561m, 3034m, 2199m, 2, "2032398", "LESLY", "FERNANDEZ", 6, "21713943", 8, 3, 4, 0m, 2021 },
                    { 131, 2373m, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3256m, 1491m, 1646m, 1, "2032419", "CRISTHIAM", "SANCHEZ", 9, "6470372", 2, 2, 4, 2051m, 2021 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionID", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeID", "PositionID", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 416, 4914m, new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4017m, 2324m, 676m, 3, "2032371", "GRACIELA", "CABALLERO", 9, "44227272", 3, 1, 3, 0m, 2021 },
                    { 130, 2373m, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1637m, 1622m, 964m, 3, "2032419", "CRISTHIAM", "SANCHEZ", 13, "6470372", 4, 1, 4, 2371m, 2021 },
                    { 123, 4481m, new DateTime(2021, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4564m, 1315m, 1741m, 1, "2032420", "OSCAR", "MARTIN", 12, "16206830", 1, 1, 4, 0m, 2021 },
                    { 47, 3001m, new DateTime(2021, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3034m, 2159m, 2055m, 1, "2032433", "FRANCISCO", "ESPINOZA", 8, "38022829", 1, 1, 4, 0m, 2021 },
                    { 55, 2069m, new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3655m, 2849m, 1059m, 1, "2032431", "TOURREN", "HOPPINGTON", 10, "41413887", 10, 2, 4, 1717m, 2021 },
                    { 57, 2069m, new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1507m, 2801m, 1001m, 1, "2032431", "TOURREN", "HOPPINGTON", 10, "41413887", 6, 2, 4, 2248m, 2021 },
                    { 60, 2069m, new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2891m, 1639m, 701m, 1, "2032431", "TOURREN", "HOPPINGTON", 6, "41413887", 5, 3, 4, 1642m, 2021 },
                    { 68, 3374m, new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 883m, 1618m, 742m, 1, "2032429", "MARJORY", "SOLORZANO", 16, "41462124", 1, 3, 4, 0m, 2021 },
                    { 77, 2568m, new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1853m, 3112m, 2154m, 2, "2032428", "YENNY", "MARTINEZ", 16, "31111491", 7, 3, 4, 2301m, 2021 },
                    { 79, 4371m, new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1450m, 1366m, 1755m, 3, "2032427", "ORA", "JACKSON", 13, "17312991", 6, 1, 4, 0m, 2021 },
                    { 80, 4371m, new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4923m, 1776m, 2101m, 3, "2032427", "ORA", "JACKSON", 17, "17312991", 10, 1, 4, 0m, 2021 },
                    { 83, 4371m, new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3513m, 1942m, 1836m, 1, "2032427", "ORA", "JACKSON", 7, "17312991", 9, 1, 4, 0m, 2021 },
                    { 84, 4371m, new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1883m, 2744m, 1287m, 3, "2032427", "ORA", "JACKSON", 16, "17312991", 8, 1, 4, 0m, 2021 },
                    { 88, 4226m, new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1011m, 3139m, 1112m, 1, "2032426", "ALBIN", "HAMILTON", 6, "31602242", 9, 3, 4, 0m, 2021 },
                    { 93, 2911m, new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4142m, 2654m, 1182m, 2, "2032425", "HAYDEE", "ARGENAL", 15, "8208741", 3, 1, 4, 2503m, 2021 },
                    { 102, 4596m, new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3399m, 2960m, 2178m, 2, "2032424", "ALEXA", "GUTIERREZ", 7, "4556179", 10, 2, 4, 0m, 2021 },
                    { 111, 2844m, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2394m, 3102m, 1319m, 3, "2032422", "OSMAR", "MORALES", 12, "24791557", 4, 3, 4, 2710m, 2021 },
                    { 122, 4481m, new DateTime(2021, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4340m, 1908m, 624m, 1, "2032420", "OSCAR", "MARTIN", 17, "16206830", 4, 3, 4, 0m, 2021 },
                    { 125, 4481m, new DateTime(2021, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2103m, 1190m, 718m, 2, "2032420", "OSCAR", "MARTIN", 6, "16206830", 5, 2, 4, 0m, 2021 },
                    { 406, 3265m, new DateTime(2021, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3615m, 1102m, 2253m, 3, "2032373", "SATURNINO", "MONTENEGRO", 7, "9388196", 6, 1, 3, 0m, 2021 },
                    { 405, 3265m, new DateTime(2021, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3977m, 2019m, 1420m, 1, "2032373", "SATURNINO", "MONTENEGRO", 8, "9388196", 9, 2, 3, 0m, 2021 },
                    { 395, 3900m, new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3574m, 1190m, 1072m, 2, "2032375", "LILIA", "VANEGAS", 16, "44387218", 10, 3, 3, 0m, 2021 },
                    { 52, 3018m, new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3356m, 3173m, 1994m, 2, "2032432", "MARLING", "CHAVEZ", 16, "31823310", 7, 1, 3, 0m, 2021 },
                    { 59, 2069m, new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3064m, 2406m, 781m, 3, "2032431", "TOURREN", "HOPPINGTON", 8, "41413887", 2, 2, 3, 1938m, 2021 },
                    { 71, 3374m, new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1357m, 1832m, 734m, 2, "2032429", "MARJORY", "SOLORZANO", 13, "41462124", 3, 1, 3, 0m, 2021 },
                    { 76, 2568m, new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3998m, 1827m, 1980m, 3, "2032428", "YENNY", "MARTINEZ", 9, "31111491", 11, 1, 3, 2439m, 2021 },
                    { 85, 4226m, new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1711m, 1151m, 1905m, 3, "2032426", "ALBIN", "HAMILTON", 10, "31602242", 5, 2, 3, 0m, 2021 },
                    { 95, 2911m, new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3304m, 2245m, 2056m, 2, "2032425", "HAYDEE", "ARGENAL", 6, "8208741", 11, 1, 3, 3128m, 2021 },
                    { 103, 2668m, new DateTime(2021, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3547m, 2029m, 901m, 2, "2032423", "PAMELA", "LOPEZ", 16, "8386388", 6, 3, 3, 2537m, 2021 },
                    { 108, 2668m, new DateTime(2021, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2098m, 1595m, 1709m, 1, "2032423", "PAMELA", "LOPEZ", 9, "8386388", 2, 3, 3, 2904m, 2021 },
                    { 115, 2156m, new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4720m, 1025m, 1227m, 2, "2032421", "VICTOR", "SANCHEZ", 12, "11512637", 9, 2, 3, 2260m, 2021 },
                    { 116, 2156m, new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2919m, 1681m, 1990m, 1, "2032421", "VICTOR", "SANCHEZ", 12, "11512637", 4, 3, 3, 1982m, 2021 },
                    { 126, 4481m, new DateTime(2021, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3334m, 2600m, 2051m, 2, "2032420", "OSCAR", "MARTIN", 14, "16206830", 6, 3, 3, 0m, 2021 },
                    { 128, 2373m, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3344m, 1202m, 1373m, 3, "2032419", "CRISTHIAM", "SANCHEZ", 17, "6470372", 10, 3, 3, 1912m, 2021 },
                    { 129, 2373m, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2780m, 2313m, 1473m, 1, "2032419", "CRISTHIAM", "SANCHEZ", 17, "6470372", 11, 3, 3, 1896m, 2021 },
                    { 137, 4323m, new DateTime(2021, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1478m, 1145m, 1017m, 1, "2032418", "JUAN", "ALVARADO", 7, "24547021", 4, 2, 3, 0m, 2021 },
                    { 139, 2194m, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4246m, 1505m, 2013m, 3, "2032417", "RONALDO", "GONZALEZ", 11, "19979160", 2, 2, 3, 2388m, 2021 },
                    { 48, 3001m, new DateTime(2021, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3298m, 1682m, 1100m, 1, "2032433", "FRANCISCO", "ESPINOZA", 8, "38022829", 6, 3, 3, 0m, 2021 },
                    { 141, 2194m, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4117m, 1870m, 1918m, 2, "2032417", "RONALDO", "GONZALEZ", 9, "19979160", 6, 1, 3, 1748m, 2021 },
                    { 46, 3001m, new DateTime(2021, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4742m, 1302m, 1585m, 1, "2032433", "FRANCISCO", "ESPINOZA", 8, "38022829", 9, 2, 3, 0m, 2021 },
                    { 26, 2304m, new DateTime(2021, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1742m, 2981m, 1569m, 2, "2032436", "DAVID", "RODRIGUEZ", 15, "19133450", 6, 3, 3, 2122m, 2021 },
                    { 541, 2934m, new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1174m, 2018m, 630m, 2, "2032350", "JORGE", "ROMAN", 16, "3440497", 9, 3, 2, 3233m, 2021 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionID", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeID", "PositionID", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 557, 2398m, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3581m, 1222m, 1706m, 1, "2032348", "ALLAN", "CALERO", 16, "20220297", 2, 3, 2, 2097m, 2021 },
                    { 558, 2398m, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3852m, 2889m, 1476m, 3, "2032348", "ALLAN", "CALERO", 7, "20220297", 8, 2, 2, 2177m, 2021 },
                    { 559, 4888m, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1597m, 2804m, 707m, 1, "2032347", "FRANCISCO", "BALDELOMAR", 13, "32283414", 9, 3, 2, 0m, 2021 },
                    { 572, 3613m, new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4913m, 2213m, 635m, 1, "2032345", "LIZANGELA", "RODRIGUEZ", 8, "5980831", 3, 2, 2, 0m, 2021 },
                    { 573, 3613m, new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1660m, 3112m, 2163m, 2, "2032345", "LIZANGELA", "RODRIGUEZ", 10, "5980831", 8, 1, 2, 0m, 2021 },
                    { 575, 3613m, new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1544m, 2163m, 1480m, 3, "2032345", "LIZANGELA", "RODRIGUEZ", 6, "5980831", 7, 1, 2, 0m, 2021 },
                    { 582, 2311m, new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1016m, 2187m, 2189m, 1, "2032344", "JONATHAN", "CORONADO", 17, "20152491", 10, 1, 2, 2337m, 2021 },
                    { 584, 3991m, new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2662m, 2263m, 1107m, 3, "2032343", "PEDRO", "ESPINOZA", 13, "18906271", 8, 1, 2, 0m, 2021 },
                    { 590, 3990m, new DateTime(2021, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4480m, 1875m, 866m, 2, "2032342", "MARIANO", "SANCHEZ", 13, "39003125", 8, 2, 2, 0m, 2021 },
                    { 596, 3894m, new DateTime(2021, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3058m, 1615m, 1599m, 2, "2032341", "CELESTINO", "BUCARDO", 7, "13039132", 8, 3, 2, 0m, 2021 },
                    { 597, 3894m, new DateTime(2021, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3866m, 3241m, 1244m, 2, "2032341", "CELESTINO", "BUCARDO", 12, "13039132", 2, 1, 2, 0m, 2021 },
                    { 3, 4061m, new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1578m, 1917m, 1347m, 2, "2032440", "LUIS", "JUAREZ", 12, "34877450", 6, 1, 3, 0m, 2021 },
                    { 19, 3128m, new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4419m, 1597m, 2206m, 1, "2032437", "BAYRON", "CHAVEZ", 17, "23711657", 3, 2, 3, 0m, 2021 },
                    { 24, 3128m, new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2875m, 2615m, 2067m, 2, "2032437", "BAYRON", "CHAVEZ", 17, "23711657", 11, 1, 3, 0m, 2021 },
                    { 45, 3001m, new DateTime(2021, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3979m, 2813m, 1745m, 1, "2032433", "FRANCISCO", "ESPINOZA", 10, "38022829", 10, 3, 3, 0m, 2021 },
                    { 599, 3894m, new DateTime(2021, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3581m, 2526m, 1137m, 2, "2032341", "CELESTINO", "BUCARDO", 6, "13039132", 5, 2, 7, 0m, 2021 },
                    { 155, 2072m, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3830m, 2706m, 637m, 3, "2032415", "ARIEL", "BURGOS", 10, "40907956", 4, 2, 3, 1955m, 2021 },
                    { 162, 4439m, new DateTime(2021, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1900m, 2800m, 2243m, 2, "2032414", "ERICK", "VALLECILLO", 8, "24314887", 11, 3, 3, 0m, 2021 },
                    { 298, 3255m, new DateTime(2021, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4339m, 2030m, 1403m, 1, "2032391", "FRANCISCO", "RUIZ", 16, "42818064", 1, 3, 3, 0m, 2021 },
                    { 301, 2174m, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3783m, 1650m, 1629m, 1, "2032390", "NORMA", "TAISIGUE", 13, "42582994", 6, 2, 3, 2034m, 2021 },
                    { 304, 2174m, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4818m, 1522m, 820m, 2, "2032390", "NORMA", "TAISIGUE", 15, "42582994", 10, 3, 3, 1892m, 2021 },
                    { 310, 2923m, new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1336m, 1117m, 1808m, 2, "2032389", "ENRIQUE", "HERNANDEZ", 14, "26937085", 8, 3, 3, 3024m, 2021 },
                    { 323, 4430m, new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2737m, 1578m, 826m, 3, "2032387", "BRYAN", "BERMUDEZ", 11, "3125873", 1, 1, 3, 0m, 2021 },
                    { 331, 3287m, new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3192m, 1970m, 1889m, 1, "2032385", "AYLENE", "RODRIGUEZ", 9, "45206736", 1, 2, 3, 0m, 2021 },
                    { 338, 2414m, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2534m, 2237m, 1648m, 1, "2032384", "CARLOS", "ACUNA", 6, "11081906", 11, 1, 3, 2563m, 2021 },
                    { 354, 2740m, new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3455m, 1843m, 1316m, 1, "2032382", "VIRGINIA", "GUIDO", 12, "28542877", 9, 3, 3, 2657m, 2021 },
                    { 358, 4978m, new DateTime(2021, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4407m, 2072m, 2033m, 2, "2032381", "LEONEL", "MELENDEZ", 7, "8177551", 1, 2, 3, 0m, 2021 },
                    { 362, 4252m, new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4813m, 1876m, 1178m, 1, "2032380", "YORDI", "BARRAZA", 12, "45175094", 2, 2, 3, 0m, 2021 },
                    { 385, 2575m, new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4438m, 2203m, 2266m, 1, "2032376", "YELDING", "MEDINA", 12, "8506454", 2, 2, 3, 2582m, 2021 },
                    { 387, 2575m, new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1941m, 2840m, 2118m, 2, "2032376", "YELDING", "MEDINA", 14, "8506454", 9, 2, 3, 2802m, 2021 },
                    { 388, 2575m, new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 957m, 1329m, 1737m, 2, "2032376", "YELDING", "MEDINA", 16, "8506454", 5, 1, 3, 2721m, 2021 },
                    { 389, 2575m, new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1308m, 1616m, 877m, 2, "2032376", "YELDING", "MEDINA", 8, "8506454", 4, 2, 3, 2742m, 2021 },
                    { 394, 3900m, new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4312m, 1684m, 1288m, 1, "2032375", "LILIA", "VANEGAS", 16, "44387218", 11, 1, 3, 0m, 2021 },
                    { 296, 3255m, new DateTime(2021, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3470m, 2291m, 1709m, 3, "2032391", "FRANCISCO", "RUIZ", 10, "42818064", 11, 3, 3, 0m, 2021 },
                    { 159, 4439m, new DateTime(2021, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1013m, 2051m, 1888m, 3, "2032414", "ERICK", "VALLECILLO", 13, "24314887", 7, 3, 3, 0m, 2021 },
                    { 284, 2956m, new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3761m, 3037m, 1305m, 3, "2032393", "HENRY", "ROBLETO", 10, "39969291", 9, 3, 3, 2561m, 2021 },
                    { 281, 4203m, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3205m, 2297m, 990m, 3, "2032394", "ELEYDA", "BLANDON", 12, "23466744", 3, 1, 3, 0m, 2021 },
                    { 169, 2933m, new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4809m, 1388m, 1349m, 3, "2032412", "LEONARDO", "JUAREZ", 17, "12055409", 7, 1, 3, 2637m, 2021 },
                    { 172, 2933m, new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2557m, 2215m, 1341m, 3, "2032412", "LEONARDO", "JUAREZ", 7, "12055409", 8, 1, 3, 2931m, 2021 },
                    { 177, 3110m, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4976m, 2927m, 2111m, 1, "2032411", "SAULO", "GOMEZ", 6, "26257282", 1, 3, 3, 0m, 2021 },
                    { 182, 4821m, new DateTime(2021, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2179m, 1788m, 1385m, 2, "2032410", "SERGIO", "REYES", 11, "39191653", 2, 2, 3, 0m, 2021 },
                    { 190, 2161m, new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2624m, 2907m, 1933m, 2, "2032409", "EYRA", "MEDRANO", 11, "45353442", 1, 2, 3, 1863m, 2021 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionID", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeID", "PositionID", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 211, 4443m, new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4686m, 2738m, 1323m, 2, "2032405", "TANIA", "SANCHEZ", 8, "5677095", 9, 1, 3, 0m, 2021 },
                    { 218, 3398m, new DateTime(2021, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1513m, 1018m, 2269m, 3, "2032404", "KELLY", "CASTANEDA", 6, "27519652", 2, 3, 3, 0m, 2021 },
                    { 230, 2858m, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2791m, 2333m, 806m, 3, "2032402", "KARLA", "BLANDINO", 8, "35162403", 6, 1, 3, 2359m, 2021 },
                    { 234, 2858m, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4387m, 3291m, 1063m, 1, "2032402", "KARLA", "BLANDINO", 9, "35162403", 2, 1, 3, 2537m, 2021 },
                    { 235, 4938m, new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4354m, 3144m, 1994m, 2, "2032401", "PAULA", "ORDONEZ", 17, "44111797", 6, 3, 3, 0m, 2021 },
                    { 239, 4938m, new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1805m, 2717m, 2131m, 1, "2032401", "PAULA", "ORDONEZ", 16, "44111797", 3, 1, 3, 0m, 2021 },
                    { 245, 3571m, new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2547m, 2290m, 1616m, 1, "2032400", "HILLARY", "ANDINO", 16, "14516770", 2, 2, 3, 0m, 2021 },
                    { 254, 3676m, new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1807m, 2641m, 2083m, 3, "2032398", "LESLY", "FERNANDEZ", 8, "21713943", 10, 2, 3, 0m, 2021 },
                    { 275, 4147m, new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2054m, 2015m, 1870m, 1, "2032395", "ERICK", "GARCIA", 12, "16786337", 4, 2, 3, 0m, 2021 },
                    { 279, 4203m, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2011m, 2391m, 2235m, 2, "2032394", "ELEYDA", "BLANDON", 10, "23466744", 1, 1, 3, 0m, 2021 },
                    { 282, 4203m, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1797m, 2743m, 2173m, 2, "2032394", "ELEYDA", "BLANDON", 12, "23466744", 7, 2, 3, 0m, 2021 },
                    { 600, 3894m, new DateTime(2021, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4965m, 2541m, 1997m, 1, "2032341", "CELESTINO", "BUCARDO", 11, "13039132", 10, 1, 7, 0m, 2021 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Salaries_DivisionID",
                table: "Salaries",
                column: "DivisionID");

            migrationBuilder.CreateIndex(
                name: "IX_Salaries_OfficeID",
                table: "Salaries",
                column: "OfficeID");

            migrationBuilder.CreateIndex(
                name: "IX_Salaries_PositionID",
                table: "Salaries",
                column: "PositionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Salaries");

            migrationBuilder.DropTable(
                name: "Divisions");

            migrationBuilder.DropTable(
                name: "Offices");

            migrationBuilder.DropTable(
                name: "Positions");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveTracker.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankHolidays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Date = table.Column<DateOnly>(type: "DATE", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    CreatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankHolidays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISOCode = table.Column<string>(type: "CHAR(3)", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    CreatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    CreatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Illnesses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    CreatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Illnesses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobTitles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "VARCHAR(75)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    CreatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISOCode = table.Column<string>(type: "CHAR(3)", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    CreatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveRequestDecisionReasons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    CreatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequestDecisionReasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveRequestDecisions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    CreatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequestDecisions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    CreatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    CreatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimeUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    CreatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    CreatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkPatterns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    CreatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkPatterns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISOCode = table.Column<string>(type: "CHAR(3)", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    TimeZone = table.Column<string>(type: "VARCHAR(6)", nullable: false),
                    Locale = table.Column<string>(type: "CHAR(5)", nullable: false),
                    DateFormat = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    TimeFormat = table.Column<string>(type: "CHAR(5)", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    CreatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Countries_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Countries_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkDays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<byte>(type: "TINYINT", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "TIME", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "TIME", nullable: false),
                    WorkPatternId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    CreatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkDays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkDays_WorkPatterns_WorkPatternId",
                        column: x => x.WorkPatternId,
                        principalTable: "WorkPatterns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    CreatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(40)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    CreatedBy = table.Column<string>(type: "VARCHAR(40)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedBy = table.Column<string>(type: "VARCHAR(40)", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offices_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    OfficeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    CreatedBy = table.Column<string>(type: "VARCHAR(40)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedBy = table.Column<string>(type: "VARCHAR(40)", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Offices_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Offices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleId = table.Column<int>(type: "int", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    MiddleName = table.Column<string>(type: "VARCHAR(30)", nullable: true),
                    LastName = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "DATE", nullable: false),
                    JobTitleId = table.Column<int>(type: "int", nullable: false),
                    EmailAddress = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    PermissionId = table.Column<int>(type: "int", nullable: false),
                    EmploymentStartDate = table.Column<DateOnly>(type: "DATE", nullable: false),
                    EmploymentEndDate = table.Column<DateOnly>(type: "DATE", nullable: true),
                    WorkPatternId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    CreatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_JobTitles_JobTitleId",
                        column: x => x.JobTitleId,
                        principalTable: "JobTitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Titles_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Titles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_WorkPatterns_WorkPatternId",
                        column: x => x.WorkPatternId,
                        principalTable: "WorkPatterns",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeApprovers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ApproverId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    CreatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeApprovers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeApprovers_Employees_ApproverId",
                        column: x => x.ApproverId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeApprovers_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeaveTypeId = table.Column<int>(type: "INT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "DATE", nullable: false),
                    EndDate = table.Column<DateTime>(type: "DATE", nullable: false),
                    LeaveRequestDecisionId = table.Column<int>(type: "int", nullable: false),
                    LeaveRequestDecisionReasonId = table.Column<int>(type: "int", nullable: false),
                    RequestorId = table.Column<int>(type: "int", nullable: false),
                    ApproverId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    CreatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedBy = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_EmployeeApprovers_ApproverId",
                        column: x => x.ApproverId,
                        principalTable: "EmployeeApprovers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_EmployeeApprovers_RequestorId",
                        column: x => x.RequestorId,
                        principalTable: "EmployeeApprovers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveRequestDecisionReasons_LeaveRequestDecisionReasonId",
                        column: x => x.LeaveRequestDecisionReasonId,
                        principalTable: "LeaveRequestDecisionReasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveRequestDecisions_LeaveRequestDecisionId",
                        column: x => x.LeaveRequestDecisionId,
                        principalTable: "LeaveRequestDecisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "BankHolidays",
                columns: new[] { "Id", "CreatedBy", "Date", "IsActive", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateOnly(2025, 1, 1), true, "New Years Day", "System" },
                    { 2, "System", new DateOnly(2025, 4, 18), true, "Good Friday", "System" },
                    { 3, "System", new DateOnly(2025, 4, 21), true, "Easter Monday", "System" },
                    { 4, "System", new DateOnly(2025, 5, 5), true, "Early May Bank Holiday", "System" },
                    { 5, "System", new DateOnly(2025, 5, 26), true, "Spring Bank Holiday", "System" },
                    { 6, "System", new DateOnly(2025, 8, 25), true, "Summer Bank Holiday", "System" },
                    { 7, "System", new DateOnly(2025, 12, 25), true, "Christmas Day", "System" },
                    { 8, "System", new DateOnly(2025, 12, 26), true, "Boxing Day", "System" },
                    { 9, "System", new DateOnly(2026, 1, 1), true, "New Years Day", "System" },
                    { 10, "System", new DateOnly(2026, 4, 3), true, "Good Friday", "System" },
                    { 11, "System", new DateOnly(2026, 4, 6), true, "Easter Monday", "System" },
                    { 12, "System", new DateOnly(2026, 5, 4), true, "Early May Bank Holiday", "System" },
                    { 13, "System", new DateOnly(2026, 5, 25), true, "Spring Bank Holiday", "System" },
                    { 14, "System", new DateOnly(2026, 8, 31), true, "Summer Bank Holiday", "System" },
                    { 15, "System", new DateOnly(2026, 12, 25), true, "Christmas Day", "System" },
                    { 16, "System", new DateOnly(2026, 12, 26), true, "Boxing Day", "System" },
                    { 17, "System", new DateOnly(2027, 1, 1), true, "New Years Day", "System" },
                    { 18, "System", new DateOnly(2027, 3, 26), true, "Good Friday", "System" },
                    { 19, "System", new DateOnly(2027, 3, 29), true, "Easter Monday", "System" },
                    { 20, "System", new DateOnly(2027, 5, 3), true, "Early May Bank Holiday", "System" },
                    { 21, "System", new DateOnly(2027, 5, 31), true, "Spring Bank Holiday", "System" },
                    { 22, "System", new DateOnly(2027, 8, 30), true, "Summer Bank Holiday", "System" },
                    { 23, "System", new DateOnly(2027, 12, 25), true, "Christmas Day", "System" },
                    { 24, "System", new DateOnly(2027, 12, 26), true, "Boxing Day", "System" },
                    { 25, "System", new DateOnly(2028, 1, 1), true, "New Years Day", "System" }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "CreatedBy", "ISOCode", "IsActive", "Name", "UpdatedBy" },
                values: new object[] { 1, "System", "GBP", true, "British Pound Sterling", "System" });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "Id", "CreatedBy", "Description", "IsActive", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", "Female", true, "System" },
                    { 2, "System", "Male", true, "System" },
                    { 3, "System", "Agender", true, "System" },
                    { 4, "System", "Omnigender", true, "System" }
                });

            migrationBuilder.InsertData(
                table: "Illnesses",
                columns: new[] { "Id", "CreatedBy", "IsActive", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", true, "Abscess", "System" },
                    { 2, "System", true, "Acute Soft Tissue Injury", "System" },
                    { 3, "System", true, "Adrenal Malfunction", "System" },
                    { 4, "System", true, "Alcohol & Drug Abuse", "System" },
                    { 5, "System", true, "Allergies", "System" },
                    { 6, "System", true, "Anaemia", "System" },
                    { 7, "System", true, "Angina", "System" },
                    { 8, "System", true, "Ankylosing Spondylitis", "System" },
                    { 9, "System", true, "Anxiety", "System" },
                    { 10, "System", true, "Appendicitis", "System" },
                    { 11, "System", true, "Arrhythmia", "System" },
                    { 12, "System", true, "Arthritis", "System" },
                    { 13, "System", true, "Asthma", "System" },
                    { 14, "System", true, "Ataxia", "System" },
                    { 15, "System", true, "Back Pain", "System" },
                    { 16, "System", true, "Bells Palsy", "System" },
                    { 17, "System", true, "Bereavement", "System" },
                    { 18, "System", true, "Biopsy", "System" },
                    { 19, "System", true, "Bladder Dysfunction", "System" },
                    { 20, "System", true, "Blackouts", "System" },
                    { 21, "System", true, "Blood Dyscriasis", "System" },
                    { 22, "System", true, "Blood Investigations", "System" },
                    { 23, "System", true, "Bowel Disease", "System" },
                    { 24, "System", true, "Bowel Obstruction", "System" },
                    { 25, "System", true, "Breast Lump", "System" },
                    { 26, "System", true, "Bronchitis", "System" },
                    { 27, "System", true, "Burns", "System" },
                    { 28, "System", true, "Cancer", "System" },
                    { 29, "System", true, "Cardiac Investigations", "System" },
                    { 30, "System", true, "Cellulitis", "System" },
                    { 31, "System", true, "Chemotherapy", "System" },
                    { 32, "System", true, "Chicken Pox", "System" },
                    { 33, "System", true, "Chronic Fatigue Syndrome", "System" },
                    { 34, "System", true, "Chronic Soft Tissue Conditions", "System" },
                    { 35, "System", true, "Clotting Disorders", "System" },
                    { 36, "System", true, "Cold", "System" },
                    { 37, "System", true, "Concussion", "System" },
                    { 38, "System", true, "Congenital Conditions", "System" },
                    { 39, "System", true, "Covid", "System" },
                    { 40, "System", true, "Crohns Disease", "System" },
                    { 41, "System", true, "Debility", "System" },
                    { 42, "System", true, "Dental Treatments", "System" },
                    { 43, "System", true, "Depression", "System" },
                    { 44, "System", true, "Diabetes", "System" },
                    { 45, "System", true, "Diarrhoea", "System" },
                    { 46, "System", true, "Dislocations", "System" },
                    { 47, "System", true, "Diverticulitis", "System" },
                    { 48, "System", true, "Dyspepsia", "System" },
                    { 49, "System", true, "Eating Disorder", "System" },
                    { 50, "System", true, "Epilepsy", "System" },
                    { 51, "System", true, "Exhaustion", "System" },
                    { 52, "System", true, "Eye Problems", "System" },
                    { 53, "System", true, "Fainting", "System" },
                    { 54, "System", true, "Fatigue", "System" },
                    { 55, "System", true, "Fibroids", "System" },
                    { 56, "System", true, "Fibromyalgia", "System" },
                    { 57, "System", true, "Food Poisoning", "System" },
                    { 58, "System", true, "Fractures", "System" },
                    { 59, "System", true, "Glandular Fever", "System" },
                    { 60, "System", true, "Gout", "System" },
                    { 61, "System", true, "Hayfever", "System" },
                    { 62, "System", true, "Headache", "System" },
                    { 63, "System", true, "Hearing Loss", "System" },
                    { 64, "System", true, "Hepatitis", "System" },
                    { 65, "System", true, "HIV/AIDS", "System" },
                    { 66, "System", true, "Hodgkins Disease", "System" },
                    { 67, "System", true, "Hypertension", "System" },
                    { 68, "System", true, "Hypotension", "System" },
                    { 69, "System", true, "Impetigo", "System" },
                    { 70, "System", true, "Influenza", "System" },
                    { 71, "System", true, "Investigations", "System" },
                    { 72, "System", true, "Kidney Stones", "System" },
                    { 73, "System", true, "Labyrinthitis", "System" },
                    { 74, "System", true, "Measles", "System" },
                    { 75, "System", true, "Meningitis", "System" },
                    { 76, "System", true, "Menopause Symptoms", "System" },
                    { 77, "System", true, "Migraine", "System" },
                    { 78, "System", true, "Myocardial Infarction", "System" },
                    { 79, "System", true, "Pharyngitis", "System" },
                    { 80, "System", true, "Pulmonary Embolism", "System" },
                    { 81, "System", true, "Quarantine", "System" },
                    { 82, "System", true, "Radiotherapy", "System" },
                    { 83, "System", true, "Renal Failure", "System" },
                    { 84, "System", true, "Pleurisy", "System" },
                    { 85, "System", true, "Pneumonia", "System" },
                    { 86, "System", true, "Pneumothorax", "System" },
                    { 87, "System", true, "Poisoning", "System" },
                    { 88, "System", true, "Repetitive Strain Disorder", "System" },
                    { 89, "System", true, "Seizures", "System" },
                    { 90, "System", true, "Sexually Transmitted Diseases", "System" },
                    { 91, "System", true, "Sinusitis", "System" },
                    { 92, "System", true, "Sleep Disturbance", "System" },
                    { 93, "System", true, "Stress", "System" },
                    { 94, "System", true, "Sunburn", "System" },
                    { 95, "System", true, "Surgery", "System" },
                    { 96, "System", true, "Tendonitis", "System" },
                    { 97, "System", true, "Testicular Abnormality", "System" },
                    { 98, "System", true, "Tenosynovitis", "System" },
                    { 99, "System", true, "Tinnitus", "System" },
                    { 100, "System", true, "Tonsillitis", "System" },
                    { 101, "System", true, "Tracheitis", "System" },
                    { 102, "System", true, "Urinary Tract Infections", "System" },
                    { 103, "System", true, "Vertigo", "System" },
                    { 104, "System", true, "Vestibulitis", "System" },
                    { 105, "System", true, "Viral Infections", "System" },
                    { 106, "System", true, "Thyroid Malfunction", "System" },
                    { 107, "System", true, "Ulcer", "System" },
                    { 108, "System", true, "Ulcerative Colitis", "System" },
                    { 109, "System", true, "Urticaria", "System" },
                    { 110, "System", true, "Vomiting", "System" }
                });

            migrationBuilder.InsertData(
                table: "JobTitles",
                columns: new[] { "Id", "CreatedBy", "Description", "IsActive", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", "AI Engineer", true, "System" },
                    { 2, "System", "Business Analyst", true, "System" },
                    { 3, "System", "Chief Information Officer", true, "System" },
                    { 4, "System", "Chief Technology Officer", true, "System" },
                    { 5, "System", "Cloud Architect", true, "System" },
                    { 6, "System", "Cloud Engineer", true, "System" },
                    { 7, "System", "Computer Support Technician", true, "System" },
                    { 8, "System", "Data Architect", true, "System" },
                    { 9, "System", "Data Scientist", true, "System" },
                    { 10, "System", "Database Administrator", true, "System" },
                    { 11, "System", "Delivery Manager", true, "System" },
                    { 12, "System", "DevOps Engineer", true, "System" },
                    { 13, "System", "Engineering Manager", true, "System" },
                    { 14, "System", "Helpdesk Analyst", true, "System" },
                    { 15, "System", "Infrastructure Engineer", true, "System" },
                    { 16, "System", "IT Security Analyst", true, "System" },
                    { 17, "System", "Lead Software Engineer", true, "System" },
                    { 18, "System", "People Manager", true, "System" },
                    { 19, "System", "Product Owner", true, "System" },
                    { 20, "System", "Project Manager", true, "System" },
                    { 21, "System", "Quality Assurance Engineer", true, "System" },
                    { 22, "System", "Report Engineer", true, "System" },
                    { 23, "System", "Requirements Engineer", true, "System" },
                    { 24, "System", "Scrum Master", true, "System" },
                    { 25, "System", "Senior Software Engineer", true, "System" },
                    { 26, "System", "Software Engineer", true, "System" },
                    { 27, "System", "Solutions Architect", true, "System" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "CreatedBy", "ISOCode", "IsActive", "Name", "UpdatedBy" },
                values: new object[] { 1, "System", "ENG", true, "English", "System" });

            migrationBuilder.InsertData(
                table: "LeaveRequestDecisionReasons",
                columns: new[] { "Id", "CreatedBy", "Description", "IsActive", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", "Operational Requirements", true, "System" },
                    { 2, "System", "Insufficient Leave Balance", true, "System" },
                    { 3, "System", "Insufficient Notice Provided", true, "System" },
                    { 4, "System", "Leave Entitlement Exceeded", true, "System" },
                    { 5, "System", "Company Policy Breach", true, "System" },
                    { 6, "System", "Pending", true, "System" }
                });

            migrationBuilder.InsertData(
                table: "LeaveRequestDecisions",
                columns: new[] { "Id", "CreatedBy", "Description", "IsActive", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", "Approved", true, "System" },
                    { 2, "System", "Declined", true, "System" },
                    { 3, "System", "Pending", true, "System" }
                });

            migrationBuilder.InsertData(
                table: "LeaveTypes",
                columns: new[] { "Id", "CreatedBy", "IsActive", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", true, "Adoption Leave", "System" },
                    { 2, "System", true, "Annual Leave", "System" },
                    { 3, "System", true, "Bank Holiday", "System" },
                    { 4, "System", true, "Carers Leave", "System" },
                    { 5, "System", true, "Emergency Dependant Leave", "System" },
                    { 6, "System", true, "Garden Leave", "System" },
                    { 7, "System", true, "Maternity Leave", "System" },
                    { 8, "System", true, "Parental Bereavement Leave", "System" },
                    { 9, "System", true, "Paternity Leave", "System" },
                    { 10, "System", true, "Public Duty Leave", "System" },
                    { 11, "System", true, "Sabbatical Leave", "System" },
                    { 12, "System", true, "Shared Parental Leave", "System" },
                    { 13, "System", true, "Sick Leave", "System" },
                    { 14, "System", true, "TOIL Leave", "System" },
                    { 15, "System", true, "Unpaid Parental Leave", "System" },
                    { 16, "System", true, "Unpaid Leave", "System" },
                    { 17, "System", true, "Birthday Leave", "System" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreatedBy", "IsActive", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", true, "Administrator", "System" },
                    { 2, "System", true, "Approver", "System" },
                    { 3, "System", true, "Employee", "System" }
                });

            migrationBuilder.InsertData(
                table: "TimeUnits",
                columns: new[] { "Id", "CreatedBy", "IsActive", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", true, "Year", "System" },
                    { 2, "System", true, "Quarter", "System" },
                    { 3, "System", true, "Month", "System" },
                    { 4, "System", true, "Week", "System" },
                    { 5, "System", true, "Day", "System" },
                    { 6, "System", true, "Hour", "System" }
                });

            migrationBuilder.InsertData(
                table: "Titles",
                columns: new[] { "Id", "CreatedBy", "Description", "IsActive", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", "Mr", true, "System" },
                    { 2, "System", "Mrs", true, "System" },
                    { 3, "System", "Miss", true, "System" },
                    { 4, "System", "Ms", true, "System" },
                    { 5, "System", "Mx", true, "System" },
                    { 6, "System", "Dr", true, "System" }
                });

            migrationBuilder.InsertData(
                table: "WorkPatterns",
                columns: new[] { "Id", "CreatedBy", "IsActive", "Name", "UpdatedBy" },
                values: new object[] { 1, "System", true, "Standard", "System" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreatedBy", "CurrencyId", "DateFormat", "ISOCode", "IsActive", "LanguageId", "Locale", "Name", "TimeFormat", "TimeZone", "UpdatedBy" },
                values: new object[] { 1, "System", 1, "yyyy-MM-dd", "GBR", true, 1, "en-GB", "United Kingdom", "hh:mm", "UTC+1", "System" });

            migrationBuilder.InsertData(
                table: "WorkDays",
                columns: new[] { "Id", "CreatedBy", "Day", "EndTime", "IsActive", "StartTime", "UpdatedBy", "WorkPatternId" },
                values: new object[,]
                {
                    { 1, "System", (byte)1, new TimeSpan(0, 17, 30, 0, 0), true, new TimeSpan(0, 9, 0, 0, 0), "System", 1 },
                    { 2, "System", (byte)2, new TimeSpan(0, 17, 30, 0, 0), true, new TimeSpan(0, 9, 0, 0, 0), "System", 1 },
                    { 3, "System", (byte)3, new TimeSpan(0, 17, 30, 0, 0), true, new TimeSpan(0, 9, 0, 0, 0), "System", 1 },
                    { 4, "System", (byte)4, new TimeSpan(0, 17, 30, 0, 0), true, new TimeSpan(0, 9, 0, 0, 0), "System", 1 },
                    { 5, "System", (byte)5, new TimeSpan(0, 17, 30, 0, 0), true, new TimeSpan(0, 9, 0, 0, 0), "System", 1 }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CountryId", "CreatedBy", "IsActive", "Name", "UpdatedBy" },
                values: new object[] { 1, 1, "System", true, "Conway", "System" });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "CompanyId", "CreatedBy", "IsActive", "Name", "UpdatedBy" },
                values: new object[] { 1, 1, "System", true, "London", "System" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreatedBy", "IsActive", "Name", "OfficeId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", true, "Finance", 1, "System" },
                    { 2, "System", true, "People Services", 1, "System" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedBy", "DateOfBirth", "EmailAddress", "EmploymentEndDate", "EmploymentStartDate", "FirstName", "GenderId", "IsActive", "JobTitleId", "LastName", "MiddleName", "PermissionId", "PhoneNumber", "TeamId", "TitleId", "UpdatedBy", "WorkPatternId" },
                values: new object[,]
                {
                    { 1, "System", new DateOnly(1970, 12, 29), "marshall.flinkman@conway.co.uk", null, new DateOnly(2001, 1, 2), "Marshall", 2, true, 25, "Flinkman", "Charles", 3, "0781 455 8906", 1, 1, "System", 1 },
                    { 2, "System", new DateOnly(1972, 4, 17), "sydney.bristow@conway.co.uk", null, new DateOnly(2001, 1, 2), "Sydney", 1, true, 25, "Bristow", "Anne", 3, "0781 455 8907", 1, 3, "System", 1 },
                    { 3, "System", new DateOnly(1980, 1, 8), "rachel.gibson@conway.co.uk", null, new DateOnly(2001, 1, 2), "Rachel", 1, true, 25, "Gibson", "Kelly", 3, "0781 455 8908", 1, 3, "System", 1 },
                    { 4, "System", new DateOnly(1951, 8, 14), "marcus.dixon@conway.co.uk", null, new DateOnly(1996, 1, 2), "Marcus", 2, true, 18, "Dixon", "John", 3, "0781 455 8909", 1, 1, "System", 1 },
                    { 5, "System", new DateOnly(1971, 8, 6), "francine.calfo@conway.co.uk", null, new DateOnly(2001, 1, 2), "Francine", 1, true, 2, "Calfo", "Jennifer", 3, "0781 455 8910", 1, 3, "System", 1 },
                    { 6, "System", new DateOnly(1969, 5, 16), "jack.bristow@conway.co.uk", null, new DateOnly(1999, 1, 2), "Jackson", 2, true, 2, "Bristow", "Michael", 3, "0781 455 8911", 1, 1, "System", 1 },
                    { 7, "System", new DateOnly(1976, 8, 6), "lauren.reed@conway.co.uk", null, new DateOnly(2005, 1, 2), "Lauren", 1, true, 20, "Reed", "Amber", 3, "0781 455 8912", 1, 3, "System", 1 },
                    { 8, "System", new DateOnly(1975, 3, 22), "irina.derevko@conway.co.uk", null, new DateOnly(2003, 1, 2), "Irina", 1, true, 18, "Derevko", "Maria", 2, "0781 455 8913", 1, 3, "System", 1 },
                    { 9, "System", new DateOnly(1978, 11, 27), "michael.vaughn@conway.co.uk", null, new DateOnly(2010, 1, 2), "Michael", 2, true, 17, "Vaughn", "John", 1, "0781 455 8914", 1, 1, "System", 1 },
                    { 10, "System", new DateOnly(1966, 7, 11), "@conway.co.uk", null, new DateOnly(2010, 1, 2), "Eric", 2, true, 27, "Weisz", "Phillip", 1, "0781 455 8914", 1, 1, "System", 1 }
                });

            migrationBuilder.InsertData(
                table: "EmployeeApprovers",
                columns: new[] { "Id", "ApproverId", "CreatedBy", "EmployeeId", "IsActive", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 8, "System", 1, true, "System" },
                    { 2, 8, "System", 2, true, "System" },
                    { 3, 8, "System", 3, true, "System" },
                    { 4, 8, "System", 4, true, "System" },
                    { 5, 8, "System", 5, true, "System" },
                    { 6, 8, "System", 6, true, "System" },
                    { 7, 8, "System", 7, true, "System" },
                    { 8, 8, "System", 8, true, "System" },
                    { 9, 8, "System", 9, true, "System" },
                    { 10, 8, "System", 10, true, "System" }
                });

            migrationBuilder.InsertData(
                table: "LeaveRequests",
                columns: new[] { "Id", "ApproverId", "CreatedBy", "EndDate", "IsActive", "LeaveRequestDecisionId", "LeaveRequestDecisionReasonId", "LeaveTypeId", "RequestorId", "StartDate", "UpdatedBy" },
                values: new object[] { 1, 8, "System", new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, 6, 2, 1, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System" });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CountryId",
                table: "Companies",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CurrencyId",
                table: "Countries",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_LanguageId",
                table: "Countries",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeApprovers_ApproverId",
                table: "EmployeeApprovers",
                column: "ApproverId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeApprovers_EmployeeId",
                table: "EmployeeApprovers",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_GenderId",
                table: "Employees",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_JobTitleId",
                table: "Employees",
                column: "JobTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PermissionId",
                table: "Employees",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_TeamId",
                table: "Employees",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_TitleId",
                table: "Employees",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_WorkPatternId",
                table: "Employees",
                column: "WorkPatternId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_ApproverId",
                table: "LeaveRequests",
                column: "ApproverId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveRequestDecisionId",
                table: "LeaveRequests",
                column: "LeaveRequestDecisionId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveRequestDecisionReasonId",
                table: "LeaveRequests",
                column: "LeaveRequestDecisionReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_RequestorId",
                table: "LeaveRequests",
                column: "RequestorId");

            migrationBuilder.CreateIndex(
                name: "IX_Offices_CompanyId",
                table: "Offices",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_OfficeId",
                table: "Teams",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkDays_WorkPatternId",
                table: "WorkDays",
                column: "WorkPatternId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankHolidays");

            migrationBuilder.DropTable(
                name: "Illnesses");

            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.DropTable(
                name: "TimeUnits");

            migrationBuilder.DropTable(
                name: "WorkDays");

            migrationBuilder.DropTable(
                name: "EmployeeApprovers");

            migrationBuilder.DropTable(
                name: "LeaveRequestDecisionReasons");

            migrationBuilder.DropTable(
                name: "LeaveRequestDecisions");

            migrationBuilder.DropTable(
                name: "LeaveTypes");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "JobTitles");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Titles");

            migrationBuilder.DropTable(
                name: "WorkPatterns");

            migrationBuilder.DropTable(
                name: "Offices");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Languages");
        }
    }
}

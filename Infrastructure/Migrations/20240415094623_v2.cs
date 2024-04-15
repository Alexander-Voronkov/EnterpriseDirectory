using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Currency",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 31, 11, 35, 35, 244, DateTimeKind.Local).AddTicks(7331), "Винників майдан, 32, Південний Лаврентій, Російська Федерація", new DateTime(1982, 5, 28, 16, 10, 0, 141, DateTimeKind.Local).AddTicks(5752), "Adriana28@i.ua", null, "Марія", "Петрів", "канд. філос. наук", "8906350051", 14305.28m, "matrix" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 18, 23, 29, 0, 909, DateTimeKind.Local).AddTicks(4280), "пр. Молодіжна, 31, Севастополь, США", new DateTime(1967, 3, 21, 4, 8, 28, 207, DateTimeKind.Local).AddTicks(1066), "Kseniya72@meta.ua", new DateTime(2022, 11, 10, 5, 25, 47, 559, DateTimeKind.Local).AddTicks(7341), "Іннеса", "Мазун", "канд. техн. наук", "4581864179", "Секретар", 6150.79m, "Adaptive" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 16, 14, 48, 0, 960, DateTimeKind.Local).AddTicks(4652), "Городоцька майдан, 447, Південний Будимир, Туреччина", new DateTime(1955, 3, 27, 7, 37, 46, 802, DateTimeKind.Local).AddTicks(3033), "Velemir_Likovich0@i.ua", "Влад", "Ялюк", "канд. політ. наук", "1145935550", 18840.09m, "Phased" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 12, 24, 7, 29, 41, 313, DateTimeKind.Local).AddTicks(8073), "вулиця Городоцька, 869, Запоріжжя, Данія", new DateTime(1995, 2, 8, 3, 49, 9, 705, DateTimeKind.Local).AddTicks(5960), "Sergii41@ex.ua", null, "Оріяна", "Волощук", "канд. політ. наук", "4575333791", "Програміст", 18598.91m, "bandwidth" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 7, 20, 4, 50, 379, DateTimeKind.Local).AddTicks(8911), "Староміська майдан, 01, Луганськ, Камбоджа", new DateTime(1955, 2, 25, 14, 15, 40, 747, DateTimeKind.Local).AddTicks(281), "Panteleimon_Kononec@ukr.net", "Віталій", "Сідляк", "канд. юрид. наук", "7185096656", "Бухгалтер", 15044.67m, "system engine" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 9, 30, 15, 53, 14, 482, DateTimeKind.Local).AddTicks(2170), "пр. Вузька, 87, Західний Геннадій, Ямайка", new DateTime(2021, 5, 23, 11, 6, 58, 19, DateTimeKind.Local).AddTicks(759), "Orislava44@gmail.com", null, "Добринка", "Петренко", "канд. політ. наук", "5275002887", "Бухгалтер", 16687.48m, "Auto Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 8, 29, 5, 6, 15, 542, DateTimeKind.Local).AddTicks(3377), "Стрийська майдан, 260, Північний Орхип, Боснія і Герцеговина", new DateTime(2011, 10, 8, 3, 38, 37, 789, DateTimeKind.Local).AddTicks(4147), "Borimisl_Gaiovii@meta.ua", null, "Максим", "Демчишин", "докт. пед. наук", "3193103035", "Директор", 12627.15m, "efficient" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 8, 13, 1, 16, 385, DateTimeKind.Local).AddTicks(8580), "Городоцька майдан, 7, Макіївка, Монголія", new DateTime(1968, 2, 13, 18, 58, 31, 192, DateTimeKind.Local).AddTicks(3196), "Kvitoslava.Pavlenko51@ex.ua", new DateTime(2019, 6, 17, 14, 18, 28, 708, DateTimeKind.Local).AddTicks(14), "Августин", "Лахман", "доц.", "8536909853", 8155.12m, "Engineer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 11, 18, 54, 25, 316, DateTimeKind.Local).AddTicks(202), "провулок Рудного, 087, Дніпропетровськ, Іран", new DateTime(1954, 1, 17, 2, 17, 9, 957, DateTimeKind.Local).AddTicks(1663), "Agniya_Yemec@e-mail.ua", null, "Доляна", "Малкович", "5820952819", "Бухгалтер", 9287.63m, "generating" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 24, 20, 4, 58, 523, DateTimeKind.Local).AddTicks(341), "пл. Ліста, 152, Південний Петро, Південна Корея", new DateTime(1947, 12, 2, 14, 56, 19, 294, DateTimeKind.Local).AddTicks(9467), "Vyacheslav54@ex.ua", null, "Антін", "Семеночко", "доц.", "0804279087", "Бухгалтер", 7481.19m, "Anguilla" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 15, 22, 23, 27, 45, DateTimeKind.Local).AddTicks(4902), "Коліївщини майдан, 57, Західний Любомир, Еритрея", new DateTime(2005, 9, 23, 12, 33, 30, 476, DateTimeKind.Local).AddTicks(253), "Lyubava51@i.ua", new DateTime(2019, 10, 28, 0, 39, 23, 906, DateTimeKind.Local).AddTicks(2086), "Герасим", "Ломовий", "докт. психол. наук", "0573202047", 13130.51m, "Corners" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 8, 17, 6, 43, 16, 270, DateTimeKind.Local).AddTicks(1258), "площа Брюховичів, 6, Західний Боримир, Канада", new DateTime(1981, 2, 6, 0, 28, 29, 654, DateTimeKind.Local).AddTicks(1063), "Rayina_Galayenko@meta.ua", new DateTime(2020, 9, 12, 21, 6, 44, 909, DateTimeKind.Local).AddTicks(9979), "Марія", "Трясило", "канд. і. наук", "1838203011", 17610.17m, "Ergonomic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 26, 5, 57, 39, 785, DateTimeKind.Local).AddTicks(4202), "Рудного майдан, 0, Чернігів, Туніс", new DateTime(1970, 2, 17, 17, 37, 29, 507, DateTimeKind.Local).AddTicks(3155), "Buitur.Polishuk@yandex.ua", null, "Добринка", "Третяк", "9483292427", "Директор", 9549.10m, "user-facing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 14, 1, 29, 38, 622, DateTimeKind.Local).AddTicks(8223), "Брюховичів майдан, 231, Південний Петро, Сент-Вінсент і Гренадини", new DateTime(2017, 3, 17, 6, 6, 55, 971, DateTimeKind.Local).AddTicks(2560), "Solomiya.Makhno@gmail.com", "Агата", "Лящук", "докт. юрид. наук", "9530401426", 16594.71m, "hacking" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 9, 10, 17, 3, 24, 881, DateTimeKind.Local).AddTicks(8813), "Нижанківського майдан, 0, Західний Арсен, Болгарія", new DateTime(1995, 6, 27, 18, 43, 35, 313, DateTimeKind.Local).AddTicks(915), "Bratimir85@i.ua", null, "Василь", "Глинська", "докт. техн. наук", "4025034952", 8799.11m, "redundant" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 28, 16, 50, 18, 306, DateTimeKind.Local).AddTicks(1540), "вул. Коліївщини, 6, Сімферополь, Австралія", new DateTime(1960, 6, 1, 17, 1, 20, 512, DateTimeKind.Local).AddTicks(2015), "Zabava_Luchko@i.ua", new DateTime(2022, 1, 15, 20, 19, 0, 752, DateTimeKind.Local).AddTicks(7448), "Родіон", "Галаєнко", "докт. техн. наук", "4374170022", "Секретар", 10258.11m, "rich" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 25, 13, 59, 7, 39, DateTimeKind.Local).AddTicks(6979), "вулиця Зелена, 74, Північний Степан, Центральноафриканська Республіка", new DateTime(2014, 8, 28, 0, 4, 3, 184, DateTimeKind.Local).AddTicks(2539), "Ruslan_Suchak@ukr.net", "Назарій", "Волощук", "докт. пед. наук", "4626352899", "Директор", 2450.90m, "parsing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 30, 8, 41, 24, 402, DateTimeKind.Local).AddTicks(4975), "Городоцька майдан, 6, Дніпродзержинськ, Бангладеш", new DateTime(1957, 10, 19, 9, 41, 55, 620, DateTimeKind.Local).AddTicks(5582), "Orest_Kornyiichuk80@meta.ua", new DateTime(2020, 12, 16, 14, 21, 44, 324, DateTimeKind.Local).AddTicks(9121), "Агафія", "Гладух", "канд. психол. наук", "1861008651", 7059.04m, "Frozen" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 9, 16, 36, 2, 400, DateTimeKind.Local).AddTicks(3904), "Брюховичів майдан, 0, Східний Корнелій, Того", new DateTime(2004, 7, 1, 9, 36, 2, 718, DateTimeKind.Local).AddTicks(9346), "Khristya71@ex.ua", new DateTime(2019, 6, 13, 9, 10, 42, 737, DateTimeKind.Local).AddTicks(397), "Добринка", "Мотрієнко", "канд. філол. наук", "3534952354", "Директор", 9153.37m, "transmitting" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 25, 16, 5, 54, 748, DateTimeKind.Local).AddTicks(1142), "проспект Брюховичів, 533, Північний Адам, Південний Судан", new DateTime(1954, 1, 22, 1, 12, 22, 536, DateTimeKind.Local).AddTicks(2474), "Zabava9@ukr.net", "Людомила", "Лучко", "докт. і. наук", "6428171716", 10757.19m, "Cambridgeshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 17, 2, 14, 1, 705, DateTimeKind.Local).AddTicks(8978), "Ліста майдан, 85, Тернопіль, Мексика", new DateTime(1961, 9, 20, 13, 11, 44, 402, DateTimeKind.Local).AddTicks(7111), "Doleslava.Shumilo76@ukr.net", "Дмитро", "Саєнко", "докт. психол. наук", "9937167503", "Бухгалтер", 6541.57m, "dynamic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 5, 11, 38, 42, 355, DateTimeKind.Local).AddTicks(8500), "Ліста майдан, 3, Ялта, Гватемала", new DateTime(2014, 3, 18, 8, 13, 54, 609, DateTimeKind.Local).AddTicks(7049), "Arsen35@ex.ua", "Соня", "Махно", "проф.", "8727159047", "Секретар", 11526.13m, "transitional" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 30, 15, 43, 13, 483, DateTimeKind.Local).AddTicks(2990), "Нижанківського майдан, 60, Миколаїв, Нікарагуа", new DateTime(2022, 6, 5, 0, 42, 42, 503, DateTimeKind.Local).AddTicks(6099), "Oles29@meta.ua", null, "Іванна", "Шудрик", "канд. юрид. наук", "1016555191", "Прибиральник", 8851.59m, "cultivate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 7, 2, 16, 43, 547, DateTimeKind.Local).AddTicks(2694), "пр. Нижанківського, 08, Павлоград, Зімбабве", new DateTime(2000, 11, 25, 5, 15, 18, 568, DateTimeKind.Local).AddTicks(2998), "Antonii_Stakhiv47@ukr.net", null, "Аркадій", "Луцьків", "канд. юрид. наук", "0437371511", "Програміст", 19756.48m, "out-of-the-box" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 5, 14, 19, 19, 11, 306, DateTimeKind.Local).AddTicks(7343), "вул. Зелена, 5, Нікополь, Туреччина", new DateTime(2008, 2, 19, 21, 24, 36, 777, DateTimeKind.Local).AddTicks(3745), "Pilip_Sherbak40@gmail.com", new DateTime(2023, 12, 16, 7, 15, 13, 158, DateTimeKind.Local).AddTicks(9039), "Ярослав", "Латанський", "докт. техн. наук", "7774568531", "Програміст", 13806.78m, "Tasty" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 7, 19, 12, 29, 42, 486, DateTimeKind.Local).AddTicks(7434), "Вічева майдан, 36, Львів, Лаос", new DateTime(1956, 10, 29, 2, 23, 14, 888, DateTimeKind.Local).AddTicks(1111), "Valentina.Mazilo@yandex.ua", null, "Сологуб", "Романишин", "проф.", "6163142665", "Бухгалтер", 11888.56m, "Greece" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 30, 2, 57, 26, 11, DateTimeKind.Local).AddTicks(209), "Брюховичів майдан, 7, Західний Борис, Джибуті", new DateTime(2023, 1, 11, 23, 18, 25, 969, DateTimeKind.Local).AddTicks(868), "Zvenigor.Marinich13@gmail.com", null, "Олесь", "Гарун", "канд. філос. наук", "3785450003", "Прибиральник", 13273.01m, "panel" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 17, 12, 34, 33, 266, DateTimeKind.Local).AddTicks(5525), "проспект Ліста, 6, Одеса, Угорщина", new DateTime(1963, 1, 2, 2, 54, 54, 894, DateTimeKind.Local).AddTicks(5480), "Stefanii.Tryasun99@gmail.com", "Крентта", "Євенко", "канд. політ. наук", "6327532576", "Директор", 15264.77m, "matrix" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 22, 17, 49, 4, 740, DateTimeKind.Local).AddTicks(4529), "площа Ліста, 97, Алчевськ, Східний Тимор", new DateTime(1953, 9, 29, 16, 36, 8, 359, DateTimeKind.Local).AddTicks(9622), "Olena93@ukr.net", new DateTime(2019, 5, 27, 12, 23, 24, 151, DateTimeKind.Local).AddTicks(1721), "Галина", "Розпутній", "канд. політ. наук", "7554309657", "Прибиральник", 10527.57m, "SCSI" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 4, 29, 19, 30, 50, 36, DateTimeKind.Local).AddTicks(1255), "вулиця Зелена, 83, Львів, Вірменія", new DateTime(2005, 5, 25, 8, 16, 56, 705, DateTimeKind.Local).AddTicks(1089), "Orina.Yushik52@gmail.com", new DateTime(2019, 9, 22, 18, 55, 31, 957, DateTimeKind.Local).AddTicks(9860), "Назарій", "Люта", "докт. пед. наук", "5548445218", 19362.75m, "Awesome Steel Towels" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 12, 23, 17, 26, 368, DateTimeKind.Local).AddTicks(9581), "Коліївщини майдан, 5, Західний Арсен, Кабо-Верде", new DateTime(1972, 12, 24, 5, 57, 9, 396, DateTimeKind.Local).AddTicks(5388), "Vsevlad.Shkaraba@e-mail.ua", new DateTime(2022, 3, 4, 23, 50, 31, 233, DateTimeKind.Local).AddTicks(9077), "Лариса", "Бутько", "докт. юрид. наук", "9979480586", "Директор", 10390.62m, "Toys" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 12, 9, 12, 54, 85, DateTimeKind.Local).AddTicks(6009), "пл. Вічева, 1, Одеса, Антигуа і Барбуда", new DateTime(1983, 5, 16, 2, 21, 22, 499, DateTimeKind.Local).AddTicks(4787), "Borislava.Korovyak@meta.ua", null, "Іванна", "Башук", "канд. філос. наук", "4629021653", "Програміст", 2183.06m, "Sleek" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 7, 2, 23, 51, 34, 183, DateTimeKind.Local).AddTicks(372), "Стрийська майдан, 1, Східний Маркіян, Норвегія", new DateTime(1950, 2, 1, 20, 24, 12, 755, DateTimeKind.Local).AddTicks(3021), "Tamara.Dmitrishina84@i.ua", null, "Брячислав", "Стигайло", "проф.", "6266732524", "Директор", 19188.18m, "Auto Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 27, 9, 49, 28, 154, DateTimeKind.Local).AddTicks(5662), "Зелена майдан, 07, Алчевськ, Тувалу", new DateTime(1952, 1, 26, 19, 9, 14, 429, DateTimeKind.Local).AddTicks(2892), "Gnat91@ukr.net", "Герасим", "Галатей", "канд. і. наук", "6656101956", "Програміст", 12957.87m, "hacking" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 31, 22, 43, 48, 380, DateTimeKind.Local).AddTicks(3849), "Ліста майдан, 5, Рівне, Соломонові Острови", new DateTime(1970, 1, 20, 18, 31, 55, 454, DateTimeKind.Local).AddTicks(1891), "Slavuta55@meta.ua", null, "Ксенія", "Линдик", "докт. політ. наук", "9226684986", "Прибиральник", 18440.52m, "web-readiness" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 4, 2, 7, 13, 42, 216, DateTimeKind.Local).AddTicks(4965), "Городоцька майдан, 29, Донецьк, Чад", new DateTime(1957, 1, 21, 13, 43, 40, 372, DateTimeKind.Local).AddTicks(9683), "Yukhima.Balabukh15@ukr.net", null, "Синьоок", "Зленко", "проф.", "8091397096", "Прибиральник", 6378.51m, "foreground" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 23, 22, 52, 46, 228, DateTimeKind.Local).AddTicks(5302), "Зелена майдан, 9, Шостка, Ірландія", new DateTime(1995, 5, 18, 16, 39, 38, 277, DateTimeKind.Local).AddTicks(6864), "Rostislava45@gmail.com", null, "Мстислав", "Єрмак", "канд. філол. наук", "8739518122", "Програміст", 6908.07m, "indexing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 2, 2, 11, 59, 5, 168, DateTimeKind.Local).AddTicks(9073), "Молодіжна майдан, 446, Східний Василь, Сінгапур", new DateTime(1971, 7, 1, 1, 9, 23, 478, DateTimeKind.Local).AddTicks(9011), "Oresta23@yandex.ua", new DateTime(2021, 1, 2, 14, 33, 1, 943, DateTimeKind.Local).AddTicks(5222), "Валентин", "Ковальський", "канд. і. наук", "5198406706", 12272.83m, "South Dakota" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 42, 57, 884, DateTimeKind.Local).AddTicks(11), "вул. Нижанківського, 018, Донецьк, Гренада", new DateTime(1985, 10, 7, 3, 44, 56, 870, DateTimeKind.Local).AddTicks(4541), "Kornii.Shumilo@ex.ua", "Алла", "Петренко", "канд. психол. наук", "8717365092", "Прибиральник", 9297.29m, "interface" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 5, 22, 6, 56, 28, 239, DateTimeKind.Local).AddTicks(1336), "площа Староміська, 6, Кам’янець-Подільський, Домініканська Республіка", new DateTime(2018, 5, 31, 21, 28, 35, 452, DateTimeKind.Local).AddTicks(3325), "Zemislav67@yandex.ua", new DateTime(2022, 1, 4, 19, 50, 34, 347, DateTimeKind.Local).AddTicks(7274), "Юліанна", "Яцьків", "канд. філол. наук", "4803397624", "Програміст", 1643.33m, "whiteboard" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 3, 4, 7, 23, 25, 529, DateTimeKind.Local).AddTicks(5917), "пр. Вічева, 6, Північний Борислав, Ірландія", new DateTime(1962, 9, 5, 10, 50, 51, 419, DateTimeKind.Local).AddTicks(9192), "Miroslav17@ex.ua", null, "Далемир", "Євенко", "докт. і. наук", "9086574040", "Секретар", 10723.21m, "streamline" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 11, 12, 22, 52, 48, 306, DateTimeKind.Local).AddTicks(9595), "Зелена майдан, 01, Євпаторія, Лесото", new DateTime(1988, 12, 2, 21, 37, 31, 292, DateTimeKind.Local).AddTicks(8241), "Avreliya86@i.ua", null, "Пантелеймон", "Єрмак", "канд. юрид. наук", "1421707833", 4616.09m, "open-source" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 5, 11, 12, 17, 688, DateTimeKind.Local).AddTicks(616), "площа Нижанківського, 5, Південний Гліб, Таджикистан", new DateTime(1963, 7, 20, 13, 50, 16, 240, DateTimeKind.Local).AddTicks(421), "Ognyana_Marinich84@yandex.ua", new DateTime(2023, 1, 5, 1, 46, 34, 591, DateTimeKind.Local).AddTicks(261), "Зореслава", "Пагутяк", "докт. техн. наук", "4651319758", "Програміст", 13998.64m, "Frozen" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 14, 0, 6, 43, 189, DateTimeKind.Local).AddTicks(8182), "Молодіжна майдан, 22, Північний Добромир, Алжир", new DateTime(1999, 8, 31, 11, 26, 58, 293, DateTimeKind.Local).AddTicks(2407), "Khristina_Luckiv@yandex.ua", new DateTime(2022, 10, 5, 13, 35, 47, 117, DateTimeKind.Local).AddTicks(1289), "Харитина", "Паламарчук", "канд. політ. наук", "1571244387", "Секретар", 13050.22m, "Auto Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 28, 16, 31, 15, 230, DateTimeKind.Local).AddTicks(4076), "Городоцька майдан, 533, Ужгород, Джибуті", new DateTime(1992, 2, 27, 0, 4, 14, 177, DateTimeKind.Local).AddTicks(8587), "Oriyana_Latan96@yandex.ua", null, "Родіон", "Галаєнко", "докт. і. наук", "4840554661", "Секретар", 6969.35m, "disintermediate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 3, 2, 6, 7, 21, 393, DateTimeKind.Local).AddTicks(6071), "проспект Стрийська, 04, Південний Ладо, Туркменістан", new DateTime(2016, 1, 5, 11, 24, 59, 32, DateTimeKind.Local).AddTicks(5643), "Zoremir80@i.ua", new DateTime(2023, 5, 23, 4, 27, 38, 266, DateTimeKind.Local).AddTicks(3349), "Ладо", "Балицька", "доц.", "5513185219", "Бухгалтер", 1496.78m, "payment" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 22, 4, 0, 56, 351, DateTimeKind.Local).AddTicks(7446), "Вічева майдан, 13, Східний Нестор, Німеччина", new DateTime(1987, 1, 30, 5, 35, 22, 613, DateTimeKind.Local).AddTicks(6543), "Lyubava_Zvarich@yandex.ua", new DateTime(2023, 6, 28, 18, 11, 10, 246, DateTimeKind.Local).AddTicks(8532), "Лаврентій", "Третяк", "докт. техн. наук", "6003467235", 19233.44m, "Metal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 13, 10, 24, 21, 668, DateTimeKind.Local).AddTicks(9210), "вул. Коліївщини, 059, Артемівськ, Парагвай", new DateTime(2023, 12, 2, 2, 47, 23, 122, DateTimeKind.Local).AddTicks(8735), "Pelagiya52@yandex.ua", new DateTime(2021, 5, 6, 0, 5, 37, 163, DateTimeKind.Local).AddTicks(4519), "Милослава", "Мамій", "докт. філол. наук", "8149138384", "Секретар", 1561.52m, "Music & Clothing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 9, 29, 6, 3, 7, 581, DateTimeKind.Local).AddTicks(9222), "площа Коліївщини, 27, Західний Звенислав, Папуа-Нова Гвінея", new DateTime(1997, 11, 9, 8, 46, 57, 180, DateTimeKind.Local).AddTicks(1985), "Radimir.Openko@e-mail.ua", null, "Ратибор", "Усич", "канд. і. наук", "6068766347", "Програміст", 3949.41m, "1080p" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 8, 27, 19, 53, 48, 645, DateTimeKind.Local).AddTicks(1401), "пл. Рудного, 591, Горлівка, Гренада", new DateTime(2018, 2, 19, 19, 36, 44, 142, DateTimeKind.Local).AddTicks(5301), "Inna81@yandex.ua", null, "Олена", "Кулинич", "канд. філол. наук", "8202854818", "Секретар", 9037.71m, "quantifying" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 12, 7, 36, 33, 685, DateTimeKind.Local).AddTicks(4246), "пр. Староміська, 58, Західний Роксолан, США", new DateTime(2009, 5, 13, 0, 34, 7, 823, DateTimeKind.Local).AddTicks(7358), "Alevtin81@i.ua", new DateTime(2024, 1, 11, 9, 59, 13, 333, DateTimeKind.Local).AddTicks(6895), "Ярополк", "Луцький", "канд. політ. наук", "1056792473", "Директор", 16076.16m, "digital" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 5, 18, 4, 29, 37, 437, DateTimeKind.Local).AddTicks(5176), "вулиця Вічева, 8, Східний Мирон, Сенеґал", new DateTime(1966, 10, 9, 15, 36, 3, 892, DateTimeKind.Local).AddTicks(4307), "Agniya_Petrishin27@e-mail.ua", "Віра", "Брицька", "докт. психол. наук", "5886699522", "Прибиральник", 3218.90m, "Rubber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 4, 18, 21, 46, 388, DateTimeKind.Local).AddTicks(6494), "пров. Вічева, 43, Київ, Узбекистан", new DateTime(1988, 7, 7, 15, 18, 3, 726, DateTimeKind.Local).AddTicks(896), "Lada.Petlyura86@e-mail.ua", new DateTime(2020, 8, 20, 21, 3, 58, 380, DateTimeKind.Local).AddTicks(5724), "Велемир", "Кульчицька", "докт. філос. наук", "9303724231", "Бухгалтер", 1063.16m, "Global" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 5, 8, 1, 10, 28, 206, DateTimeKind.Local).AddTicks(7020), "проспект Нижанківського, 9, Західний Далемир, Барбадос", new DateTime(1957, 9, 8, 16, 6, 8, 488, DateTimeKind.Local).AddTicks(4380), "Natan_Prigoda91@yandex.ua", new DateTime(2023, 8, 11, 6, 8, 39, 225, DateTimeKind.Local).AddTicks(8066), "Ян", "Мазило", "докт. філол. наук", "3909505273", "Директор", 18128.60m, "Spain" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 15, 21, 11, 55, 973, DateTimeKind.Local).AddTicks(5362), "Нижанківського майдан, 81, Слов’янськ, Киргизстан", new DateTime(1952, 5, 26, 0, 55, 38, 603, DateTimeKind.Local).AddTicks(9629), "Lavrin_Bashuk38@e-mail.ua", "Лаврін", "Зінкевич", "докт. і. наук", "8403273212", 4844.15m, "Circles" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 24, 15, 10, 54, 922, DateTimeKind.Local).AddTicks(3609), "Молодіжна майдан, 0, Рівне, Туреччина", new DateTime(2012, 5, 25, 3, 57, 41, 34, DateTimeKind.Local).AddTicks(6472), "Lukyan_Bilich83@ex.ua", null, "Валентина", "Троян", "канд. політ. наук", "4189165784", "Директор", 6833.25m, "synergistic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 9, 18, 21, 5, 27, 629, DateTimeKind.Local).AddTicks(8661), "Брюховичів майдан, 414, Львів, Барбадос", new DateTime(2012, 3, 30, 15, 18, 58, 337, DateTimeKind.Local).AddTicks(1002), "Arkadii.Korovyak65@yandex.ua", null, "Лідія", "Марієвський", "доц.", "0156983715", "Бухгалтер", 13024.03m, "teal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 9, 24, 7, 10, 47, 919, DateTimeKind.Local).AddTicks(7891), "пров. Вічева, 19, Харків, Австралія", new DateTime(2020, 9, 15, 2, 53, 34, 717, DateTimeKind.Local).AddTicks(7551), "Avreliya87@i.ua", new DateTime(2022, 2, 9, 23, 26, 11, 763, DateTimeKind.Local).AddTicks(9561), "Подолян", "Василин", "докт. і. наук", "9721019173", "Бухгалтер", 5849.12m, "Landing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 18, 0, 12, 47, 641, DateTimeKind.Local).AddTicks(4018), "пров. Молодіжна, 22, Східний Орхип, Барбадос", new DateTime(1962, 12, 14, 19, 21, 52, 54, DateTimeKind.Local).AddTicks(6597), "Roksolana46@i.ua", new DateTime(2019, 9, 30, 2, 8, 30, 145, DateTimeKind.Local).AddTicks(2215), "Златомир", "Іванців", "канд. пед. наук", "7035700478", "Секретар", 8543.58m, "communities" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 14, 15, 1, 39, 407, DateTimeKind.Local).AddTicks(2031), "Стрийська майдан, 12, Львів, Кірибаті", new DateTime(1976, 11, 16, 20, 1, 48, 463, DateTimeKind.Local).AddTicks(5599), "Lyubov71@ukr.net", new DateTime(2021, 7, 10, 4, 26, 49, 922, DateTimeKind.Local).AddTicks(7091), "Милодара", "Лахман", "докт. пед. наук", "6086017080", 19850.20m, "overriding" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 11, 15, 9, 33, 42, 424, DateTimeKind.Local).AddTicks(7163), "Брюховичів майдан, 1, Луцьк, США", new DateTime(2018, 1, 5, 7, 24, 35, 888, DateTimeKind.Local).AddTicks(9271), "Vlasta73@meta.ua", "Аврора", "Поривай", "канд. пед. наук", "1423637022", 7862.31m, "EXE" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 9, 5, 3, 37, 48, 202, DateTimeKind.Local).AddTicks(5723), "вулиця Нижанківського, 62, Північний Братимир, Алжир", new DateTime(1997, 2, 20, 0, 41, 41, 394, DateTimeKind.Local).AddTicks(1435), "Milodara.Sosyura35@meta.ua", "Звенигор", "Калач", "канд. психол. наук", "1772477542", "Бухгалтер", 4467.24m, "hard drive" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 13, 2, 34, 50, 369, DateTimeKind.Local).AddTicks(6570), "Ліста майдан, 17, Східний Корній, Тувалу", new DateTime(1967, 5, 1, 23, 52, 48, 306, DateTimeKind.Local).AddTicks(8537), "Zenovii_Miklukho84@ex.ua", new DateTime(2019, 5, 15, 17, 53, 21, 384, DateTimeKind.Local).AddTicks(9143), "Денис", "Пономарів", "2773920820", 4663.41m, "Kazakhstan" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 11, 6, 17, 8, 37, 240, DateTimeKind.Local).AddTicks(9419), "Винників майдан, 0, Харків, Сент-Кітс і Невіс", new DateTime(1980, 3, 7, 7, 27, 12, 411, DateTimeKind.Local).AddTicks(6152), "Natan.Trublayevskii@ex.ua", new DateTime(2023, 2, 20, 19, 49, 42, 227, DateTimeKind.Local).AddTicks(8072), "Зеновій", "Іванишина", "докт. філос. наук", "4965059269", "Секретар", 1020.40m, "withdrawal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 3, 10, 8, 50, 32, 48, DateTimeKind.Local).AddTicks(8002), "Вічева майдан, 915, Львів, Непал", new DateTime(1950, 2, 9, 20, 46, 39, 608, DateTimeKind.Local).AddTicks(9579), "Arkadiya_Dzyubyak@gmail.com", new DateTime(2020, 6, 15, 3, 30, 35, 434, DateTimeKind.Local).AddTicks(1016), "Добромисл", "Ліхно", "канд. юрид. наук", "4665103334", 1451.39m, "e-business" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 3, 20, 22, 51, 57, 52, DateTimeKind.Local).AddTicks(2693), "вул. Вузька, 814, Східний Зоремир, Кабо-Верде", new DateTime(1991, 3, 24, 20, 23, 0, 529, DateTimeKind.Local).AddTicks(6185), "Yukhima_Semeshuk18@meta.ua", null, "Богдана", "Бамбула", "канд. і. наук", "3748486817", "Прибиральник", 2125.49m, "Fantastic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 26, 1, 26, 14, 372, DateTimeKind.Local).AddTicks(9186), "пр. Староміська, 71, Кіровоград, Ліхтенштейн", new DateTime(1999, 1, 27, 2, 49, 3, 651, DateTimeKind.Local).AddTicks(6700), "Lyuborada.Garai@gmail.com", new DateTime(2022, 11, 1, 3, 33, 47, 296, DateTimeKind.Local).AddTicks(9588), "Квітослава", "Марієвська", "докт. філос. наук", "4044459296", "Директор", 2519.88m, "Home Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 7, 25, 6, 48, 26, 916, DateTimeKind.Local).AddTicks(9453), "пров. Городоцька, 02, Хмельницький, Філіппіни", new DateTime(2004, 2, 8, 13, 23, 5, 420, DateTimeKind.Local).AddTicks(6812), "Pelagiya_Galacion@e-mail.ua", "Анастасія", "Ликович", "докт. політ. наук", "6443586403", "Програміст", 8363.76m, "Plastic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 55, 53, 666, DateTimeKind.Local).AddTicks(8340), "Вузька майдан, 3, Західний Яровид, Куба", new DateTime(1965, 4, 8, 9, 47, 37, 652, DateTimeKind.Local).AddTicks(3443), "Kvitoslava_Luchenko@ukr.net", new DateTime(2022, 8, 19, 21, 55, 7, 351, DateTimeKind.Local).AddTicks(8404), "Адріана", "Люта", "докт. філол. наук", "2640679696", "Бухгалтер", 5883.08m, "Practical" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 14, 20, 7, 16, 21, DateTimeKind.Local).AddTicks(8528), "Брюховичів майдан, 333, Східний Братослав, Зімбабве", new DateTime(2001, 10, 2, 11, 42, 54, 157, DateTimeKind.Local).AddTicks(2845), "Darii_Porivailo@e-mail.ua", new DateTime(2022, 3, 23, 22, 29, 9, 336, DateTimeKind.Local).AddTicks(7969), "Славолюб", "Усич", "докт. психол. наук", "9486268103", "Секретар", 12427.72m, "Sleek" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 12, 14, 28, 58, 305, DateTimeKind.Local).AddTicks(1198), "пр. Винників, 2, Південний Мар’ян, Кіпр", new DateTime(2004, 2, 1, 2, 6, 8, 476, DateTimeKind.Local).AddTicks(458), "Anna_Petrin@meta.ua", "Корнелій", "Бабух", "докт. філол. наук", "5616922023", "Прибиральник", 3310.73m, "experiences" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 28, 1, 41, 1, 890, DateTimeKind.Local).AddTicks(842), "Зелена майдан, 43, Західний Олелько, Самоа", new DateTime(2001, 5, 2, 22, 4, 37, 913, DateTimeKind.Local).AddTicks(9069), "Yana36@i.ua", "Ростислав", "Гриневецький", "канд. психол. наук", "1188140669", "Секретар", 13192.84m, "Sleek" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 19, 22, 47, 56, 300, DateTimeKind.Local).AddTicks(3388), "Ліста майдан, 415, Кам’янець-Подільський, Іспанія", new DateTime(1946, 7, 20, 7, 58, 2, 88, DateTimeKind.Local).AddTicks(7178), "Zoryana61@gmail.com", new DateTime(2021, 2, 8, 8, 59, 9, 610, DateTimeKind.Local).AddTicks(2632), "Артем", "Ломова", "проф.", "5840412070", "Секретар", 10376.38m, "scale" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 11, 12, 7, 11, 33, 192, DateTimeKind.Local).AddTicks(1652), "провулок Нижанківського, 6, Західний Захарій, Сент-Кітс і Невіс", new DateTime(1951, 9, 10, 23, 56, 13, 136, DateTimeKind.Local).AddTicks(3501), "Roksolan_Sirko80@meta.ua", "Валерій", "Шамрило", "канд. психол. наук", "5626630316", "Бухгалтер", 10514.52m, "Granite" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 4, 21, 6, 21, 22, 993, DateTimeKind.Local).AddTicks(1049), "провулок Ліста, 6, Східний Братимир, Гамбія", new DateTime(1996, 9, 25, 15, 44, 14, 276, DateTimeKind.Local).AddTicks(7592), "Garnoslav_Romenec40@ukr.net", null, "Братослав", "Милославський", "докт. і. наук", "5121011010", "Директор", 6304.82m, "models" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 3, 19, 22, 15, 20, 640, DateTimeKind.Local).AddTicks(5869), "площа Винників, 5, Лисичанськ, Ефіопія", new DateTime(2012, 8, 24, 5, 42, 55, 86, DateTimeKind.Local).AddTicks(298), "Mechislav_Babukh@yandex.ua", "Антоніна", "Лановий", "докт. юрид. наук", "1137895871", "Прибиральник", 16148.96m, "Turkmenistan" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 9, 8, 3, 59, 30, 356, DateTimeKind.Local).AddTicks(1519), "Винників майдан, 0, Південний Звенислав, Колумбія", new DateTime(2022, 10, 4, 18, 32, 3, 581, DateTimeKind.Local).AddTicks(8375), "Dobromila.Veredun@i.ua", "Людомила", "Бамбула", "канд. філос. наук", "1763812645", "Прибиральник", 15293.23m, "matrix" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 24, 23, 29, 49, 400, DateTimeKind.Local).AddTicks(6326), "пл. Вічева, 2, Дніпропетровськ, Естонія", new DateTime(1965, 12, 7, 5, 58, 23, 517, DateTimeKind.Local).AddTicks(1780), "Albert_Kovalskii23@yandex.ua", new DateTime(2023, 8, 3, 15, 48, 47, 491, DateTimeKind.Local).AddTicks(8009), "Щек", "Галаєнко", "канд. техн. наук", "7197651795", "Прибиральник", 8790.08m, "Administrator" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 17, 2, 48, 34, 975, DateTimeKind.Local).AddTicks(1042), "Вузька майдан, 101, Східний Степан, Сомалі", new DateTime(2004, 4, 14, 3, 1, 44, 859, DateTimeKind.Local).AddTicks(7090), "Mokrina22@ukr.net", new DateTime(2024, 3, 18, 23, 12, 47, 348, DateTimeKind.Local).AddTicks(8896), "Петро", "Карпух", "докт. і. наук", "3452175211", "Директор", 19423.37m, "Neck" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 28, 18, 58, 23, 788, DateTimeKind.Local).AddTicks(2463), "пров. Ліста, 18, Олександрія, Чехія", new DateTime(2003, 10, 27, 9, 51, 48, 446, DateTimeKind.Local).AddTicks(3964), "Marta_Yackiv@i.ua", new DateTime(2023, 2, 13, 17, 36, 21, 450, DateTimeKind.Local).AddTicks(7605), "Тиміш", "Борочко", "канд. техн. наук", "6019202296", "Директор", 19491.36m, "Sleek Metal Shirt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 12, 18, 5, 20, 30, 561, DateTimeKind.Local).AddTicks(3585), "площа Ліста, 6, Красний Луч, Бразилія", new DateTime(1977, 9, 7, 2, 35, 28, 149, DateTimeKind.Local).AddTicks(4232), "Orislava87@yandex.ua", new DateTime(2021, 4, 12, 17, 45, 51, 778, DateTimeKind.Local).AddTicks(2094), "Богуслава", "Городоцька", "канд. пед. наук", "6482495774", "Директор", 1745.55m, "Identity" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 3, 11, 21, 41, 15, 84, DateTimeKind.Local).AddTicks(8389), "Рудного майдан, 29, Артемівськ, США", new DateTime(1999, 6, 8, 12, 27, 5, 942, DateTimeKind.Local).AddTicks(5776), "Zinayida.Yalyuk@i.ua", "Квітка", "Сердюк", "докт. техн. наук", "9562232478", "Директор", 6322.81m, "Tunisia" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 19, 7, 19, 47, 911, DateTimeKind.Local).AddTicks(7290), "Винників майдан, 09, Краматорськ, Бутан", new DateTime(2013, 8, 27, 15, 29, 56, 393, DateTimeKind.Local).AddTicks(6551), "Aelina65@yandex.ua", "Анастас", "Михайлюк", "3125081681", "Бухгалтер", 12334.31m, "Lodge" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 24, 0, 1, 50, 263, DateTimeKind.Local).AddTicks(4674), "вул. Рудного, 4, Черкаси, Сомалі", new DateTime(1963, 5, 24, 23, 19, 44, 71, DateTimeKind.Local).AddTicks(7417), "Podolyan.Balaban@e-mail.ua", "Тиміш", "Ящук", "докт. філос. наук", "1273601211", "Секретар", 4766.71m, "New Mexico" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 24, 18, 45, 56, 255, DateTimeKind.Local).AddTicks(686), "Винників майдан, 878, Східний Братимир, Грузія", new DateTime(2000, 7, 16, 16, 23, 9, 10, DateTimeKind.Local).AddTicks(5204), "Orkhip_Porivailo8@i.ua", "Афанасія", "Семещук", "докт. філос. наук", "1082697597", 13237.72m, "New Mexico" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 2, 18, 24, 10, 760, DateTimeKind.Local).AddTicks(9333), "площа Вузька, 02, Нікополь, Таїланд", new DateTime(1951, 1, 9, 0, 56, 32, 495, DateTimeKind.Local).AddTicks(1111), "Yeremii_Dzyubyak@ukr.net", null, "Тимофій", "Трясун", "канд. філол. наук", "9241727372", "Програміст", 16937.17m, "Credit Card Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 3, 28, 0, 54, 8, 334, DateTimeKind.Local).AddTicks(7696), "Вічева майдан, 49, Дніпродзержинськ, Японія", new DateTime(1945, 4, 30, 7, 21, 43, 966, DateTimeKind.Local).AddTicks(6076), "Slava18@i.ua", "Кузьма", "Яцишина", "докт. техн. наук", "7611978565", 16344.44m, "Borders" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 12, 26, 2, 16, 15, 566, DateTimeKind.Local).AddTicks(8467), "Вічева майдан, 73, Севастополь, Північна Корея", new DateTime(2006, 10, 11, 13, 54, 31, 881, DateTimeKind.Local).AddTicks(3302), "Boleslav.Borochko@e-mail.ua", null, "Ганна", "Данилишина", "проф.", "3543686144", "Бухгалтер", 8221.29m, "Land" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 1, 22, 23, 17, 459, DateTimeKind.Local).AddTicks(4298), "Брюховичів майдан, 38, Суми, Італія", new DateTime(1983, 9, 13, 4, 29, 37, 562, DateTimeKind.Local).AddTicks(4679), "Yana.Dmitruk@ex.ua", null, "Іванна", "Трублаєвська", "докт. політ. наук", "7092559816", "Програміст", 7270.73m, "mission-critical" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 9, 8, 0, 27, 54, 731, DateTimeKind.Local).AddTicks(4557), "пров. Молодіжна, 0, Північний Лаврін, Ботсвана", new DateTime(1979, 7, 2, 16, 26, 49, 250, DateTimeKind.Local).AddTicks(2758), "Diyana_Vasilishina77@e-mail.ua", null, "Антонида", "Галаєнко", "докт. юрид. наук", "7090912828", "Секретар", 3414.05m, "Robust" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 28, 1, 15, 36, 302, DateTimeKind.Local).AddTicks(5246), "проспект Зелена, 53, Мелітополь, Ізраїль", new DateTime(2016, 7, 26, 22, 30, 36, 682, DateTimeKind.Local).AddTicks(7133), "Zorina.Durdinec@ukr.net", null, "Доброслава", "Білич", "канд. філос. наук", "3325911876", "Програміст", 13753.66m, "portal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 51, 14, 552, DateTimeKind.Local).AddTicks(6126), "Староміська майдан, 29, Чернігів, Албанія", new DateTime(2021, 1, 16, 3, 19, 53, 527, DateTimeKind.Local).AddTicks(102), "Afanasiya.Pagutyak@ex.ua", new DateTime(2021, 11, 21, 9, 9, 55, 193, DateTimeKind.Local).AddTicks(4346), "Пантелеймон", "Гречко", "докт. юрид. наук", "9479488839", "Бухгалтер", 11959.22m, "National" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 9, 7, 54, 22, 193, DateTimeKind.Local).AddTicks(8106), "Вузька майдан, 241, Дніпропетровськ, Екваторіальна Гвінея", new DateTime(2005, 1, 23, 10, 9, 28, 733, DateTimeKind.Local).AddTicks(196), "Klavdiya.Balaban42@gmail.com", new DateTime(2021, 4, 22, 13, 14, 24, 173, DateTimeKind.Local).AddTicks(6391), "Власта", "Балакун", "канд. і. наук", "3922018247", "Прибиральник", 17315.99m, "scale" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 7, 10, 21, 1, 597, DateTimeKind.Local).AddTicks(3149), "пров. Рудного, 63, Східний Стефаній, Мальта", new DateTime(1979, 3, 31, 5, 18, 16, 389, DateTimeKind.Local).AddTicks(3958), "Arkadiya_Korovyak@meta.ua", "Родослав", "Кандиба", "канд. і. наук", "5230316094", "Бухгалтер", 19317.66m, "Generic Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 16, 9, 13, 35, 119, DateTimeKind.Local).AddTicks(8640), "провулок Нижанківського, 984, Черкаси, Колумбія", new DateTime(2009, 10, 22, 4, 46, 17, 604, DateTimeKind.Local).AddTicks(6835), "Arkadii27@ukr.net", "Забава", "Євпак", "канд. техн. наук", "4387158929", "Програміст", 16981.35m, "Plains" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 7, 11, 3, 17, 589, DateTimeKind.Local).AddTicks(7280), "Староміська майдан, 22, Західний Архип, Андорра", new DateTime(2013, 10, 30, 9, 6, 44, 897, DateTimeKind.Local).AddTicks(4635), "Bryachislav_Miklashevska74@ukr.net", new DateTime(2023, 11, 9, 13, 51, 18, 217, DateTimeKind.Local).AddTicks(4185), "Пилип", "Спотикач", "канд. політ. наук", "4487527790", 13003.34m, "Czech Republic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 3, 7, 4, 29, 39, 317, DateTimeKind.Local).AddTicks(1355), "пров. Молодіжна, 67, Житомир, Ботсвана", new DateTime(1961, 5, 28, 15, 31, 41, 687, DateTimeKind.Local).AddTicks(3198), "Ustina.Gaiduk53@i.ua", null, "Надія", "Дзюб’як", "канд. техн. наук", "6559229369", "Директор", 13586.65m, "Cambridgeshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 12, 25, 21, 43, 49, 150, DateTimeKind.Local).AddTicks(7346), "Коліївщини майдан, 9, Одеса, Словаччина", new DateTime(2023, 3, 7, 5, 56, 44, 359, DateTimeKind.Local).AddTicks(7658), "Nazar_Korecka@meta.ua", new DateTime(2019, 10, 27, 3, 39, 12, 347, DateTimeKind.Local).AddTicks(559), "Зиновій", "Шамрило", "проф.", "5996965811", "Бухгалтер", 2293.01m, "methodologies" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 12, 19, 1, 51, 45, 607, DateTimeKind.Local).AddTicks(1365), "вул. Вузька, 38, Західний Гордій, Канада", new DateTime(1972, 8, 16, 5, 43, 36, 69, DateTimeKind.Local).AddTicks(8158), "Borimisl.Lazirko18@ukr.net", new DateTime(2022, 7, 27, 4, 56, 0, 709, DateTimeKind.Local).AddTicks(3078), "Вілена", "Третяк", "доц.", "1163058163", "Секретар", 15589.94m, "Executive" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 5, 15, 25, 28, 848, DateTimeKind.Local).AddTicks(9356), "пров. Вічева, 04, Західний Корнило, Кіпр", new DateTime(1963, 9, 8, 9, 48, 33, 30, DateTimeKind.Local).AddTicks(1585), "Lado.Yemec@ex.ua", new DateTime(2022, 2, 2, 19, 3, 17, 889, DateTimeKind.Local).AddTicks(9952), "Ірина", "Роменець", "проф.", "0951875805", "Директор", 5245.50m, "Assimilated" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 4, 16, 18, 23, 11, 353, DateTimeKind.Local).AddTicks(5123), "пл. Брюховичів, 0, Одеса, Сент-Кітс і Невіс", new DateTime(1957, 11, 6, 22, 39, 55, 9, DateTimeKind.Local).AddTicks(2753), "Oksana33@ex.ua", null, "Герасим", "Гречко", "докт. політ. наук", "7271890640", 3849.08m, "compressing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 9, 12, 6, 27, 13, 304, DateTimeKind.Local).AddTicks(2329), "вулиця Староміська, 933, Південний Арсен, Гайана", new DateTime(1960, 12, 25, 0, 55, 35, 399, DateTimeKind.Local).AddTicks(7050), "Lad12@i.ua", "Катерина", "Балицький", "канд. психол. наук", "2294544566", "Секретар", 12293.72m, "Applications" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 23, 20, 11, 0, 876, DateTimeKind.Local).AddTicks(1126), "Староміська майдан, 24, Євпаторія, Афганістан", new DateTime(1958, 3, 21, 23, 50, 14, 578, DateTimeKind.Local).AddTicks(9106), "Biloslava_Yarmak@meta.ua", new DateTime(2022, 12, 30, 9, 22, 38, 320, DateTimeKind.Local).AddTicks(805), "Любомир", "Гречко", "канд. пед. наук", "3055226689", "Секретар", 11384.83m, "connecting" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 48, 31, 724, DateTimeKind.Local).AddTicks(1046), "вулиця Стрийська, 31, Сімферополь, Колумбія", new DateTime(2012, 3, 18, 17, 5, 42, 261, DateTimeKind.Local).AddTicks(9782), "Vladislava_Unich83@ukr.net", "Варвара", "Скиба", "докт. філол. наук", "5173397717", "Програміст", 7380.57m, "Avenue" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 30, 2, 45, 33, 124, DateTimeKind.Local).AddTicks(8316), "Стрийська майдан, 11, Севастополь, Сербія", new DateTime(1992, 1, 26, 10, 37, 26, 991, DateTimeKind.Local).AddTicks(2340), "Aelayida72@i.ua", null, "Жозефіна", "Компанієць", "докт. юрид. наук", "0834744873", 10236.21m, "multi-byte" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 2, 3, 7, 2, 48, 224, DateTimeKind.Local).AddTicks(6020), "Нижанківського майдан, 0, Мелітополь, Аргентина", new DateTime(1948, 12, 27, 5, 21, 28, 408, DateTimeKind.Local).AddTicks(2906), "Pelagiya.Stepanec54@ukr.net", "Євген", "Зленко", "канд. філол. наук", "5625822501", 5818.06m, "Intelligent" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 20, 5, 7, 5, 434, DateTimeKind.Local).AddTicks(5022), "Молодіжна майдан, 035, Південний Всеволод, Ангола", new DateTime(1966, 4, 18, 2, 8, 40, 573, DateTimeKind.Local).AddTicks(2427), "Vladislava38@meta.ua", new DateTime(2023, 3, 6, 2, 58, 57, 959, DateTimeKind.Local).AddTicks(4933), "Анастасія", "Шестак", "докт. політ. наук", "6126340574", "Бухгалтер", 10231.61m, "payment" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 3, 5, 6, 22, 35, 59, DateTimeKind.Local).AddTicks(6928), "вул. Брюховичів, 853, Західний Микола, Білорусь", new DateTime(1949, 8, 4, 19, 1, 46, 124, DateTimeKind.Local).AddTicks(5355), "Budimir.Pasichnik56@meta.ua", null, "Алевтин", "Лановий", "канд. і. наук", "0325507201", "Секретар", 9637.61m, "Orchestrator" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 23, 16, 25, 53, 519, DateTimeKind.Local).AddTicks(5167), "Староміська майдан, 943, Східний Руслан, Ефіопія", new DateTime(1955, 6, 24, 13, 28, 2, 109, DateTimeKind.Local).AddTicks(7113), "Yuliya.Ganich65@e-mail.ua", null, "Яромил", "Мазило", "докт. політ. наук", "1949804475", "Бухгалтер", 5719.90m, "generate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 30, 10, 8, 15, 25, DateTimeKind.Local).AddTicks(5742), "площа Винників, 04, Кривий Ріг, Італія", new DateTime(2017, 11, 12, 23, 4, 57, 473, DateTimeKind.Local).AddTicks(6825), "Yulian.Sushko@yandex.ua", new DateTime(2020, 11, 27, 13, 0, 42, 68, DateTimeKind.Local).AddTicks(7786), "Руслана", "Коман", "докт. політ. наук", "4950978057", "Прибиральник", 12035.63m, "Walks" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 2, 21, 12, 5, 32, 759, DateTimeKind.Local).AddTicks(1561), "площа Вузька, 7, Алчевськ, Кенія", new DateTime(2002, 3, 3, 4, 49, 6, 528, DateTimeKind.Local).AddTicks(3202), "Gennadii46@ex.ua", "Аделіна", "Милославський", "докт. філол. наук", "2006610689", "Програміст", 6882.73m, "Borders" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 28, 18, 21, 9, 489, DateTimeKind.Local).AddTicks(4765), "Вузька майдан, 5, Краматорськ, Багамські Острови", new DateTime(2019, 7, 1, 13, 25, 7, 248, DateTimeKind.Local).AddTicks(5763), "Stepan12@e-mail.ua", null, "Сергій", "Гречко", "докт. філол. наук", "7013070073", "Програміст", 15875.66m, "Parks" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 3, 29, 19, 27, 19, 958, DateTimeKind.Local).AddTicks(9501), "Винників майдан, 0, Південний Юхим, Гвінея", new DateTime(1988, 1, 25, 23, 8, 27, 940, DateTimeKind.Local).AddTicks(5921), "Yaroslava58@ukr.net", null, "Костянтин", "Гришко", "докт. філол. наук", "8848920008", "Директор", 8971.08m, "Japan" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 30, 12, 12, 20, 883, DateTimeKind.Local).AddTicks(2823), "Вічева майдан, 55, Житомир, Казахстан", new DateTime(2014, 10, 10, 6, 20, 18, 920, DateTimeKind.Local).AddTicks(4396), "Zlat_Koman@e-mail.ua", null, "Всеволод", "Лагойда", "докт. техн. наук", "6793123865", "Прибиральник", 5406.30m, "multi-byte" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 9, 5, 34, 28, 384, DateTimeKind.Local).AddTicks(1025), "Молодіжна майдан, 768, Східний Аврелій, Барбадос", new DateTime(1947, 6, 2, 23, 27, 21, 935, DateTimeKind.Local).AddTicks(7805), "Radimir50@yandex.ua", new DateTime(2023, 7, 30, 9, 32, 35, 558, DateTimeKind.Local).AddTicks(1425), "Зореслава", "Балакун", "канд. філос. наук", "2949960347", "Секретар", 13936.50m, "synthesizing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 3, 20, 0, 0, 500, DateTimeKind.Local).AddTicks(9433), "проспект Нижанківського, 666, Луцьк, Мексика", new DateTime(2011, 1, 29, 3, 41, 51, 835, DateTimeKind.Local).AddTicks(5969), "Polina94@e-mail.ua", "Любомира", "Москалюк", "канд. політ. наук", "8260721556", "Секретар", 11455.70m, "white" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 11, 1, 33, 6, 404, DateTimeKind.Local).AddTicks(5287), "пр. Винників, 2, Західний Кий, Еритрея", new DateTime(1981, 11, 12, 22, 15, 12, 876, DateTimeKind.Local).AddTicks(2674), "Milana.Mazilo90@i.ua", new DateTime(2020, 5, 2, 16, 45, 33, 280, DateTimeKind.Local).AddTicks(7239), "Гнат", "Юрчишина", "канд. філос. наук", "1486496318", "Директор", 11334.21m, "Camp" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 3, 28, 2, 58, 4, 835, DateTimeKind.Local).AddTicks(2215), "пл. Нижанківського, 5, Київ, Ліберія", new DateTime(1969, 10, 30, 3, 34, 29, 332, DateTimeKind.Local).AddTicks(8692), "Radoslava_Stepanec@ex.ua", new DateTime(2022, 11, 13, 5, 5, 14, 929, DateTimeKind.Local).AddTicks(3147), "Ярополк", "Зварич", "докт. і. наук", "0871794806", "Секретар", 19221.94m, "optical" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 32, 21, 255, DateTimeKind.Local).AddTicks(625), "вулиця Зелена, 65, Луцьк, Конго", new DateTime(1991, 9, 22, 13, 29, 0, 530, DateTimeKind.Local).AddTicks(3672), "Yaroslava_Zinkevich15@yandex.ua", new DateTime(2021, 3, 27, 3, 38, 21, 929, DateTimeKind.Local).AddTicks(3463), "Орислава", "Корецький", "7367524651", "Програміст", 2334.42m, "interfaces" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 4, 15, 21, 33, 701, DateTimeKind.Local).AddTicks(1075), "Брюховичів майдан, 056, Житомир, Катар", new DateTime(1955, 2, 4, 16, 27, 44, 540, DateTimeKind.Local).AddTicks(7735), "Aelayida_Grechko@gmail.com", new DateTime(2020, 3, 9, 10, 45, 41, 449, DateTimeKind.Local).AddTicks(6945), "Орися", "Шупик", "канд. техн. наук", "7137600594", "Директор", 18025.71m, "compress" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 11, 13, 21, 51, 37, 227, DateTimeKind.Local).AddTicks(2098), "Староміська майдан, 13, Ізмаїл, Литва", new DateTime(2018, 5, 13, 6, 9, 17, 63, DateTimeKind.Local).AddTicks(3377), "Gerasim.Danilishina@yandex.ua", "Білослав", "Гарай", "7822544170", "Директор", 10401.15m, "Sleek" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 24, 8, 36, 26, 201, DateTimeKind.Local).AddTicks(6357), "пр. Винників, 653, Південний Адріян, Шрі-Ланка", new DateTime(1967, 10, 4, 7, 35, 20, 2, DateTimeKind.Local).AddTicks(3038), "Andrii_Mazun@ex.ua", new DateTime(2024, 2, 3, 21, 31, 2, 969, DateTimeKind.Local).AddTicks(2548), "Ярополк", "Латанський", "докт. і. наук", "4617248444", 8828.75m, "Integration" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 14, 17, 5, 26, 8, DateTimeKind.Local).AddTicks(1734), "Молодіжна майдан, 5, Львів, Австрія", new DateTime(1969, 1, 14, 8, 15, 50, 278, DateTimeKind.Local).AddTicks(1300), "Anastasiya85@ex.ua", null, "Яромил", "Євпак", "докт. філол. наук", "1718318755", "Секретар", 19658.90m, "Synergistic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 7, 14, 20, 54, 23, 707, DateTimeKind.Local).AddTicks(6606), "площа Городоцька, 03, Чернівці, Азербайджан", new DateTime(1977, 8, 10, 2, 38, 42, 103, DateTimeKind.Local).AddTicks(6843), "Stanislav_Yavorivska55@ukr.net", new DateTime(2023, 6, 21, 7, 50, 34, 26, DateTimeKind.Local).AddTicks(2600), "Азалія", "Корецький", "докт. філос. наук", "7361875113", "Програміст", 14072.56m, "Division" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 12, 25, 17, 44, 13, 217, DateTimeKind.Local).AddTicks(7520), "пр. Староміська, 676, Суми, Македонія", new DateTime(1949, 3, 6, 13, 54, 47, 287, DateTimeKind.Local).AddTicks(3591), "Gavrilo.Demkiv6@e-mail.ua", "Далеслава", "Балабух", "докт. політ. наук", "2708574204", "Програміст", 6502.90m, "Locks" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 3, 20, 21, 7, 3, 930, DateTimeKind.Local).AddTicks(6499), "Винників майдан, 714, Київ, Сьєрра-Леоне", new DateTime(2023, 11, 9, 14, 45, 10, 30, DateTimeKind.Local).AddTicks(462), "Klavdiya11@i.ua", "Корній", "Тарасюк", "докт. психол. наук", "3900444220", "Прибиральник", 16058.98m, "Intelligent Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 3, 12, 19, 34, 55, 589, DateTimeKind.Local).AddTicks(4365), "пр. Стрийська, 788, Західний Всеслав, Сент-Кітс і Невіс", new DateTime(2000, 7, 20, 23, 5, 1, 665, DateTimeKind.Local).AddTicks(901), "Anna_Lomova@ukr.net", "Славомир", "Цушко", "канд. юрид. наук", "5617163135", "Директор", 18973.46m, "primary" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 28, 17, 18, 20, 515, DateTimeKind.Local).AddTicks(554), "Брюховичів майдан, 411, Євпаторія, Лівія", new DateTime(1988, 2, 27, 0, 8, 27, 362, DateTimeKind.Local).AddTicks(7977), "Vilina63@ukr.net", "Гаврило", "Сердюк", "канд. психол. наук", "2991737493", "Бухгалтер", 19208.72m, "Soft" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 26, 22, 29, 36, 708, DateTimeKind.Local).AddTicks(4096), "проспект Староміська, 03, Південний Маркіян, Чорногорія", new DateTime(1946, 9, 10, 23, 29, 1, 46, DateTimeKind.Local).AddTicks(8320), "Rodion_Vasilin@ex.ua", null, "Ізяслав", "Дзюба", "докт. політ. наук", "2454180044", "Секретар", 3918.46m, "Automotive & Toys" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 18, 14, 48, 53, 522, DateTimeKind.Local).AddTicks(3551), "пров. Староміська, 79, Сєвєродонецьк, Свазіленд", new DateTime(2017, 4, 4, 3, 30, 1, 508, DateTimeKind.Local).AddTicks(3200), "Oriyana.Zabila66@meta.ua", null, "Віленіна", "Левадовська", "докт. техн. наук", "6497056608", "Програміст", 7792.57m, "withdrawal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 13, 21, 38, 29, 454, DateTimeKind.Local).AddTicks(9764), "Рудного майдан, 7, Північний Корній, Малі", new DateTime(1984, 1, 25, 5, 30, 39, 963, DateTimeKind.Local).AddTicks(880), "Sofiya_Sirko14@ukr.net", new DateTime(2019, 12, 21, 11, 7, 10, 977, DateTimeKind.Local).AddTicks(5054), "Горимир", "Поривай", "канд. і. наук", "4671361852", "Директор", 1109.46m, "IB" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 12, 3, 2, 47, 818, DateTimeKind.Local).AddTicks(2173), "Винників майдан, 54, Мелітополь, Вірменія", new DateTime(1985, 1, 7, 19, 15, 8, 788, DateTimeKind.Local).AddTicks(8537), "Yurii91@ex.ua", new DateTime(2023, 5, 24, 0, 33, 32, 459, DateTimeKind.Local).AddTicks(8879), "Лад", "Трясило", "докт. філос. наук", "6162594866", "Прибиральник", 4628.60m, "Handcrafted Concrete Sausages" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 27, 9, 32, 30, 291, DateTimeKind.Local).AddTicks(1509), "Зелена майдан, 6, Північний Святослав, Куба", new DateTime(1954, 10, 19, 8, 55, 5, 823, DateTimeKind.Local).AddTicks(9892), "Mikita0@gmail.com", null, "Братослав", "Поривай", "канд. пед. наук", "5431012606", "Прибиральник", 10881.78m, "Cambridgeshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 28, 4, 42, 13, 5, DateTimeKind.Local).AddTicks(5982), "Винників майдан, 382, Житомир, Ірак", new DateTime(1961, 11, 8, 12, 39, 45, 115, DateTimeKind.Local).AddTicks(2964), "Krentta.Bachei9@e-mail.ua", new DateTime(2020, 2, 24, 7, 55, 33, 142, DateTimeKind.Local).AddTicks(7318), "Дмитро", "Ткаченко", "канд. техн. наук", "4200413133", "Секретар", 13083.99m, "hack" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 30, 0, 37, 27, 96, DateTimeKind.Local).AddTicks(9690), "Молодіжна майдан, 926, Макіївка, Об’єднані Арабські Емірати", new DateTime(2018, 10, 3, 8, 10, 46, 55, DateTimeKind.Local).AddTicks(9772), "Yana21@gmail.com", null, "Аскольд", "Романишина", "докт. філол. наук", "4059709881", "Бухгалтер", 16956.37m, "Upgradable" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 3, 18, 23, 37, 4, 596, DateTimeKind.Local).AddTicks(2120), "Коліївщини майдан, 806, Севастополь, Сьєрра-Леоне", new DateTime(2017, 10, 7, 0, 59, 9, 107, DateTimeKind.Local).AddTicks(5211), "Yarina.Yurchishina@i.ua", new DateTime(2020, 11, 8, 19, 28, 31, 721, DateTimeKind.Local).AddTicks(8184), "Білослав", "Шкараба", "0477162578", "Програміст", 5095.80m, "Internal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 5, 14, 5, 8, 51, 970, DateTimeKind.Local).AddTicks(7549), "Стрийська майдан, 5, Східний Юліан, Італія", new DateTime(1989, 5, 15, 23, 16, 46, 403, DateTimeKind.Local).AddTicks(3754), "Roksolan36@i.ua", new DateTime(2023, 3, 9, 20, 50, 37, 865, DateTimeKind.Local).AddTicks(7936), "Артемія", "Петрів", "канд. філос. наук", "6512304788", "Секретар", 7293.19m, "archive" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 7, 18, 51, 53, 56, DateTimeKind.Local).AddTicks(1253), "Нижанківського майдан, 3, Ізмаїл, Велика Британія", new DateTime(1959, 2, 26, 21, 40, 6, 626, DateTimeKind.Local).AddTicks(2417), "Liliya32@ukr.net", new DateTime(2023, 11, 5, 6, 8, 25, 886, DateTimeKind.Local).AddTicks(4488), "Устим", "Петлюра", "канд. і. наук", "8758124991", "Програміст", 10604.00m, "SQL" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 18, 23, 28, 18, 926, DateTimeKind.Local).AddTicks(9074), "провулок Зелена, 8, Північний Микита, Російська Федерація", new DateTime(2004, 7, 30, 2, 21, 28, 22, DateTimeKind.Local).AddTicks(1614), "Marina_Malkovich10@meta.ua", "Мальва", "Кульчицька", "докт. пед. наук", "2937036817", 8305.15m, "Prairie" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 20, 17, 54, 21, 302, DateTimeKind.Local).AddTicks(6071), "Винників майдан, 9, Кіровоград, Самоа", new DateTime(1976, 6, 9, 4, 47, 27, 926, DateTimeKind.Local).AddTicks(2894), "Zakhar26@i.ua", new DateTime(2022, 7, 21, 0, 47, 4, 411, DateTimeKind.Local).AddTicks(9384), "Орхип", "Латанський", "канд. пед. наук", "1775011458", "Бухгалтер", 15674.05m, "tertiary" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 13, 17, 26, 26, 702, DateTimeKind.Local).AddTicks(1222), "Вузька майдан, 660, Північний Ігор, Угорщина", new DateTime(2008, 6, 14, 5, 29, 32, 801, DateTimeKind.Local).AddTicks(9510), "Khvalimir23@ukr.net", new DateTime(2021, 6, 4, 14, 41, 58, 851, DateTimeKind.Local).AddTicks(2674), "Жозефіна", "Борочко", "канд. пед. наук", "7709033088", "Бухгалтер", 4243.85m, "platforms" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 20, 6, 56, 5, 106, DateTimeKind.Local).AddTicks(1389), "пр. Вузька, 3, Біла Церква, Ємен", new DateTime(1963, 3, 30, 1, 44, 30, 627, DateTimeKind.Local).AddTicks(1201), "Vadim_Grechko40@meta.ua", new DateTime(2021, 3, 14, 0, 13, 44, 270, DateTimeKind.Local).AddTicks(6603), "Корній", "Сушко", "проф.", "1841494821", "Прибиральник", 6511.84m, "Maine" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 9, 21, 35, 59, 450, DateTimeKind.Local).AddTicks(7706), "проспект Коліївщини, 3, Павлоград, Словенія", new DateTime(1965, 5, 14, 13, 1, 20, 417, DateTimeKind.Local).AddTicks(4339), "Lesya51@ukr.net", new DateTime(2023, 11, 14, 11, 57, 7, 435, DateTimeKind.Local).AddTicks(3311), "Віолетта", "Линдик", "докт. і. наук", "5918939686", "Прибиральник", 19975.99m, "interface" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 14, 3, 39, 58, 187, DateTimeKind.Local).AddTicks(3192), "провулок Молодіжна, 1, Кам’янець-Подільський, Коста-Рика", new DateTime(1987, 1, 31, 21, 42, 37, 890, DateTimeKind.Local).AddTicks(7552), "Kii.Makovecka66@ex.ua", null, "Руслан", "Слободян", "докт. юрид. наук", "4674905077", "Прибиральник", 9345.75m, "Security" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 20, 3, 15, 43, 271, DateTimeKind.Local).AddTicks(8719), "Брюховичів майдан, 67, Мелітополь, Куба", new DateTime(2000, 9, 12, 16, 12, 38, 206, DateTimeKind.Local).AddTicks(792), "Lada_Gnatishin@meta.ua", null, "Потішана", "Карпух", "проф.", "4538406036", 10712.88m, "bypass" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 6, 0, 51, 36, 33, DateTimeKind.Local).AddTicks(7880), "провулок Староміська, 53, Північний Адам, Литва", new DateTime(1948, 7, 11, 15, 9, 8, 69, DateTimeKind.Local).AddTicks(8100), "Lyudomila.Berdnik@ukr.net", new DateTime(2023, 12, 15, 15, 43, 47, 649, DateTimeKind.Local).AddTicks(6615), "Орислава", "Боровський", "проф.", "5894060721", "Програміст", 17400.30m, "Investment Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 18, 19, 55, 29, 718, DateTimeKind.Local).AddTicks(9361), "провулок Винників, 466, Північний Антін, Туреччина", new DateTime(1999, 3, 23, 4, 17, 44, 971, DateTimeKind.Local).AddTicks(5571), "Dobroslava_Danilishina@ex.ua", new DateTime(2019, 5, 23, 22, 53, 21, 703, DateTimeKind.Local).AddTicks(7289), "Ксенія", "Гришко", "докт. філол. наук", "8442043696", 1569.69m, "Knoll" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 41, 45, 472, DateTimeKind.Local).AddTicks(5850), "провулок Зелена, 1, Севастополь, Коста-Рика", new DateTime(1946, 8, 3, 15, 59, 32, 881, DateTimeKind.Local).AddTicks(2709), "Smiyana88@i.ua", new DateTime(2023, 5, 17, 3, 31, 36, 500, DateTimeKind.Local).AddTicks(1400), "Юхим", "Унич", "докт. і. наук", "3766198407", "Прибиральник", 9048.74m, "Customer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 8, 1, 44, 55, 402, DateTimeKind.Local).AddTicks(5540), "площа Молодіжна, 93, Маріуполь, Шрі-Ланка", new DateTime(1991, 4, 9, 21, 38, 24, 510, DateTimeKind.Local).AddTicks(9856), "Lyubomir.Mariyevska@i.ua", new DateTime(2019, 11, 21, 20, 57, 57, 306, DateTimeKind.Local).AddTicks(8343), "Владислав", "Балицька", "канд. політ. наук", "0397501049", "Директор", 13938.06m, "Kyat" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 9, 20, 15, 2, 398, DateTimeKind.Local).AddTicks(1624), "Рудного майдан, 6, Горлівка, Зімбабве", new DateTime(2017, 5, 11, 2, 59, 34, 823, DateTimeKind.Local).AddTicks(8833), "Zlata47@ex.ua", null, "Боримисл", "Лазірко", "докт. пед. наук", "2934254540", "Директор", 3445.64m, "fault-tolerant" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 18, 17, 18, 34, 413, DateTimeKind.Local).AddTicks(2958), "Вічева майдан, 87, Макіївка, Швеція", new DateTime(1984, 4, 25, 11, 42, 22, 687, DateTimeKind.Local).AddTicks(1592), "Lada.Vitryak43@gmail.com", null, "Мар’ян", "Лученко", "докт. політ. наук", "7834475901", "Секретар", 6275.17m, "maroon" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 25, 19, 52, 10, 201, DateTimeKind.Local).AddTicks(6600), "пров. Вузька, 6, Північний Алевтин, Швейцарія", new DateTime(1950, 1, 14, 7, 26, 9, 212, DateTimeKind.Local).AddTicks(7126), "Oleksii.Osadko@ukr.net", null, "Поліна", "Сторчак", "докт. політ. наук", "9015339448", "Прибиральник", 7678.67m, "Gorgeous Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 3, 18, 12, 44, 48, 648, DateTimeKind.Local).AddTicks(6549), "Вузька майдан, 85, Суми, Барбадос", new DateTime(2011, 10, 5, 12, 17, 19, 396, DateTimeKind.Local).AddTicks(3583), "Vasilina39@gmail.com", null, "Віленіна", "Корецька", "канд. техн. наук", "3321253026", "Бухгалтер", 10103.98m, "Total" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 12, 13, 8, 26, 50, 635, DateTimeKind.Local).AddTicks(1407), "Нижанківського майдан, 79, Тернопіль, Естонія", new DateTime(1994, 9, 1, 14, 56, 2, 897, DateTimeKind.Local).AddTicks(9109), "Dobrinka.Shupik44@e-mail.ua", "Аскольд", "Коцюбинський", "канд. філос. наук", "9123883441", 9789.97m, "indexing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 16, 0, 38, 38, 171, DateTimeKind.Local).AddTicks(2792), "Брюховичів майдан, 212, Північний Василь, Гватемала", new DateTime(1990, 8, 13, 11, 35, 43, 789, DateTimeKind.Local).AddTicks(4793), "Yaroslav10@yandex.ua", new DateTime(2022, 9, 13, 6, 56, 13, 341, DateTimeKind.Local).AddTicks(9150), "Алевтина", "Борецький", "канд. психол. наук", "2926316507", "Прибиральник", 6103.27m, "parse" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 12, 20, 8, 14, 555, DateTimeKind.Local).AddTicks(8), "Коліївщини майдан, 55, Артемівськ, Гренада", new DateTime(2018, 6, 14, 11, 43, 41, 865, DateTimeKind.Local).AddTicks(9882), "Yulian44@i.ua", new DateTime(2021, 6, 18, 7, 36, 36, 264, DateTimeKind.Local).AddTicks(9667), "Віктор", "Сучак", "докт. політ. наук", "5751777857", 13865.11m, "HDD" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 4, 26, 982, DateTimeKind.Local).AddTicks(1743), "Вузька майдан, 9, Північний Лад, Італія", new DateTime(2000, 11, 2, 22, 40, 49, 393, DateTimeKind.Local).AddTicks(8595), "Kvitka.Galatei43@yandex.ua", new DateTime(2022, 2, 6, 10, 51, 57, 153, DateTimeKind.Local).AddTicks(7474), "Добромила", "Москаль", "доц.", "1430859404", 6693.72m, "Tasty Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 7, 3, 23, 22, 24, 996, DateTimeKind.Local).AddTicks(4185), "Молодіжна майдан, 84, Західний Мирослав, Папуа-Нова Гвінея", new DateTime(1998, 4, 7, 3, 44, 8, 825, DateTimeKind.Local).AddTicks(6516), "Zenovii_Lomova@meta.ua", new DateTime(2023, 4, 27, 18, 30, 43, 973, DateTimeKind.Local).AddTicks(5069), "Ярослав", "Шухевич", "канд. пед. наук", "3648121522", 5256.40m, "brand" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 26, 14, 40, 54, 312, DateTimeKind.Local).AddTicks(2188), "Городоцька майдан, 4, Сєвєродонецьк, Суринам", new DateTime(2007, 4, 26, 0, 27, 45, 68, DateTimeKind.Local).AddTicks(3170), "Dana_Petrina@ukr.net", new DateTime(2023, 11, 20, 4, 43, 43, 865, DateTimeKind.Local).AddTicks(4572), "Раїса", "Дідух", "9458589240", "Секретар", 6684.58m, "Village" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 4, 16, 47, 24, 569, DateTimeKind.Local).AddTicks(9650), "пр. Коліївщини, 436, Східний Артем, Німеччина", new DateTime(1958, 6, 18, 13, 24, 13, 384, DateTimeKind.Local).AddTicks(4907), "Biloslava14@e-mail.ua", new DateTime(2021, 7, 13, 15, 25, 47, 963, DateTimeKind.Local).AddTicks(9991), "Станислава", "Дурдинець", "докт. політ. наук", "2323817849", "Програміст", 6141.62m, "Unbranded Granite Salad" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 3, 10, 2, 7, 54, 38, DateTimeKind.Local).AddTicks(9411), "Винників майдан, 0, Північний Ратибор, Самоа", new DateTime(1954, 5, 18, 19, 53, 6, 836, DateTimeKind.Local).AddTicks(6991), "Zoryana.Chervonii@yandex.ua", new DateTime(2020, 7, 27, 20, 28, 21, 6, DateTimeKind.Local).AddTicks(9895), "Анатолія", "Карпух", "канд. психол. наук", "5180080809", "Бухгалтер", 5264.10m, "Checking Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 23, 5, 3, 43, 307, DateTimeKind.Local).AddTicks(4694), "Коліївщини майдан, 839, Рівне, Словенія", new DateTime(1999, 6, 19, 4, 54, 53, 539, DateTimeKind.Local).AddTicks(9106), "Zemislav_Prigoda47@ex.ua", new DateTime(2023, 5, 19, 1, 59, 25, 534, DateTimeKind.Local).AddTicks(7961), "Милослава", "Спотикач", "канд. техн. наук", "9719051293", "Секретар", 16043.56m, "Credit Card Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 18, 18, 46, 40, 569, DateTimeKind.Local).AddTicks(1541), "вулиця Староміська, 592, Західний Дарій, Еквадор", new DateTime(1994, 6, 6, 4, 26, 53, 487, DateTimeKind.Local).AddTicks(8075), "Nazar.Pavlenko63@e-mail.ua", new DateTime(2022, 6, 25, 14, 47, 47, 604, DateTimeKind.Local).AddTicks(7468), "Пантелеймон", "Паламарчук", "7519420785", "Програміст", 10836.28m, "Clothing, Sports & Games" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 5, 6, 5, 58, 32, 951, DateTimeKind.Local).AddTicks(7458), "пл. Ліста, 840, Південний Щек, Федеративні Штати Мікронезії", new DateTime(2004, 10, 12, 0, 11, 5, 294, DateTimeKind.Local).AddTicks(9478), "Sonya_Pavlenko@ukr.net", new DateTime(2020, 1, 9, 18, 1, 29, 757, DateTimeKind.Local).AddTicks(6302), "Натан", "Ромей", "доц.", "5224377031", 9619.59m, "Metal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 9, 11, 21, 0, 42, 417, DateTimeKind.Local).AddTicks(6888), "площа Староміська, 424, Умань, Франція", new DateTime(2006, 10, 23, 9, 34, 20, 907, DateTimeKind.Local).AddTicks(6860), "Mariya.Shindarei@i.ua", new DateTime(2022, 8, 11, 8, 52, 38, 764, DateTimeKind.Local).AddTicks(3996), "Тетяна", "Трясило", "проф.", "5250478644", "Програміст", 6029.99m, "Qatari Rial" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 3, 5, 7, 46, 5, 741, DateTimeKind.Local).AddTicks(8467), "площа Нижанківського, 63, Павлоград, Сомалі", new DateTime(1999, 9, 9, 8, 53, 27, 921, DateTimeKind.Local).AddTicks(6251), "Zoya27@gmail.com", "Біляна", "Ємець", "докт. пед. наук", "1058152732", "Секретар", 15854.85m, "Iraqi Dinar" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 1, 29, 1, 33, 43, 32, DateTimeKind.Local).AddTicks(4925), "пров. Брюховичів, 068, Дніпродзержинськ, Венесуела", new DateTime(1979, 1, 8, 8, 9, 37, 312, DateTimeKind.Local).AddTicks(7078), "Bratoslav_Palamarchuk59@meta.ua", null, "Любислава", "Кандиба", "докт. філос. наук", "9460558542", "Програміст", 5053.41m, "Persistent" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 15, 0, 29, 56, 127, DateTimeKind.Local).AddTicks(2144), "Нижанківського майдан, 0, Північний Мирослав, Вануату", new DateTime(1981, 1, 20, 8, 57, 42, 18, DateTimeKind.Local).AddTicks(7464), "Dmitro64@meta.ua", new DateTime(2022, 8, 24, 20, 39, 19, 516, DateTimeKind.Local).AddTicks(4181), "Аліна", "Магера", "докт. юрид. наук", "9281817189", "Бухгалтер", 3871.10m, "Granite" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 19, 10, 42, 13, 710, DateTimeKind.Local).AddTicks(9250), "пр. Нижанківського, 965, Південний Архип, Південний Судан", new DateTime(1960, 3, 18, 9, 3, 9, 109, DateTimeKind.Local).AddTicks(7302), "Malva_Openko45@gmail.com", new DateTime(2023, 8, 5, 19, 44, 15, 135, DateTimeKind.Local).AddTicks(5825), "Любозар", "Сідлецький", "докт. і. наук", "1712086429", "Секретар", 6893.11m, "Avon" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 16, 16, 0, 17, 586, DateTimeKind.Local).AddTicks(4009), "Рудного майдан, 553, Східний Олелько, Болівія", new DateTime(1988, 1, 17, 23, 56, 47, 718, DateTimeKind.Local).AddTicks(4825), "Stefanii_Tryasilo@e-mail.ua", null, "Віліна", "Брицький", "докт. техн. наук", "2209863036", "Директор", 9474.62m, "Administrator" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 18, 12, 3, 46, 787, DateTimeKind.Local).AddTicks(5546), "Коліївщини майдан, 688, Павлоград, Лаос", new DateTime(1991, 1, 3, 3, 56, 9, 981, DateTimeKind.Local).AddTicks(4430), "Anastasiya_Yarmak70@e-mail.ua", new DateTime(2024, 1, 31, 14, 52, 51, 451, DateTimeKind.Local).AddTicks(1656), "Зореслав", "Яцьків", "доц.", "5197198552", "Директор", 10713.81m, "SMTP" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 4, 19, 7, 5, 54, 680, DateTimeKind.Local).AddTicks(5572), "Нижанківського майдан, 3, Східний Синьоок, Туркменістан", new DateTime(2022, 12, 6, 21, 8, 19, 635, DateTimeKind.Local).AddTicks(1584), "Kii0@ex.ua", new DateTime(2019, 7, 21, 22, 55, 2, 50, DateTimeKind.Local).AddTicks(9824), "Мстислава", "Кандиба", "канд. філол. наук", "6072298168", "Прибиральник", 5539.99m, "Personal Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 29, 6, 23, 8, 167, DateTimeKind.Local).AddTicks(2414), "проспект Нижанківського, 31, Макіївка, Норвегія", new DateTime(1958, 12, 18, 2, 25, 47, 151, DateTimeKind.Local).AddTicks(8833), "Miroslava19@e-mail.ua", null, "Альбіна", "Паламарчук", "канд. політ. наук", "6979785768", "Секретар", 4018.27m, "Executive" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 8, 1, 24, 20, 213, DateTimeKind.Local).AddTicks(3805), "площа Коліївщини, 6, Північний Орест, Оман", new DateTime(2002, 7, 31, 9, 40, 58, 782, DateTimeKind.Local).AddTicks(5718), "Miron.Suchak69@e-mail.ua", new DateTime(2024, 2, 29, 8, 38, 58, 788, DateTimeKind.Local).AddTicks(877), "Чорнота", "Глинський", "доц.", "0351255515", "Прибиральник", 1684.99m, "optical" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 3, 17, 22, 34, 13, 277, DateTimeKind.Local).AddTicks(3427), "провулок Молодіжна, 142, Ялта, Маршаллові Острови", new DateTime(1952, 1, 2, 4, 2, 32, 322, DateTimeKind.Local).AddTicks(1023), "Lad.Borovska79@ex.ua", "Мстислава", "Тиндарей", "канд. і. наук", "2725824885", "Бухгалтер", 6139.90m, "magenta" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 16, 14, 4, 5, 777, DateTimeKind.Local).AddTicks(3706), "Ліста майдан, 135, Північний Ратибор, Кувейт", new DateTime(1979, 11, 24, 17, 57, 23, 717, DateTimeKind.Local).AddTicks(1612), "Zoreslav_Shupik96@i.ua", null, "Антонида", "Мазило", "канд. політ. наук", "4853344977", "Прибиральник", 18710.73m, "programming" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 12, 17, 54, 13, 215, DateTimeKind.Local).AddTicks(3483), "Вічева майдан, 27, Північний Натан, Киргизстан", new DateTime(1964, 4, 3, 13, 53, 34, 558, DateTimeKind.Local).AddTicks(4377), "Antin_Rozputnii@meta.ua", new DateTime(2022, 9, 4, 16, 35, 38, 466, DateTimeKind.Local).AddTicks(315), "Тетяна", "Башук", "проф.", "7164087023", 6005.43m, "Gorgeous Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 1, 2, 7, 22, 27, 516, DateTimeKind.Local).AddTicks(4476), "Брюховичів майдан, 052, Південний Далемир, Філіппіни", new DateTime(1991, 12, 20, 2, 46, 28, 695, DateTimeKind.Local).AddTicks(495), "Dolyana_Gordiichuk@e-mail.ua", null, "Добромира", "Лученко", "докт. психол. наук", "1035284758", "Прибиральник", 19177.83m, "Cambridgeshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 15, 7, 1, 7, 519, DateTimeKind.Local).AddTicks(480), "Ліста майдан, 57, Східний Руслан, Марокко", new DateTime(1981, 10, 19, 5, 4, 51, 585, DateTimeKind.Local).AddTicks(2557), "Nataliya.Openko94@meta.ua", "Орест", "Кононець", "докт. техн. наук", "0810979283", "Програміст", 10321.40m, "Springs" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 19, 14, 39, 15, 649, DateTimeKind.Local).AddTicks(8904), "Винників майдан, 82, Північний Велемир, Камерун", new DateTime(2004, 5, 18, 1, 35, 6, 795, DateTimeKind.Local).AddTicks(9165), "Oleg64@yandex.ua", new DateTime(2019, 5, 18, 10, 7, 45, 515, DateTimeKind.Local).AddTicks(7975), "Доброслава", "Коман", "докт. юрид. наук", "0013205525", "Секретар", 2668.27m, "enable" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 12, 16, 12, 21, 16, 927, DateTimeKind.Local).AddTicks(1677), "проспект Винників, 406, Тернопіль, Ізраїль", new DateTime(2000, 12, 17, 4, 35, 26, 538, DateTimeKind.Local).AddTicks(7885), "Semibor_Stigailo@yandex.ua", new DateTime(2021, 10, 18, 13, 36, 37, 592, DateTimeKind.Local).AddTicks(6602), "Мстислав", "Паращук", "канд. філос. наук", "9711762891", "Програміст", 8473.37m, "cyan" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 26, 7, 2, 51, 922, DateTimeKind.Local).AddTicks(9208), "вулиця Молодіжна, 45, Східний Доброслав, Демократична Республіка Конго", new DateTime(2007, 10, 26, 9, 21, 45, 382, DateTimeKind.Local).AddTicks(8610), "Zoya.Makovecka@i.ua", "Юхим", "Лютий", "проф.", "7634895681", "Прибиральник", 3357.46m, "Practical Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 8, 23, 3, 32, 609, DateTimeKind.Local).AddTicks(2793), "Винників майдан, 43, Західний Братимир, Південний Судан", new DateTime(1996, 9, 5, 5, 11, 53, 678, DateTimeKind.Local).AddTicks(2278), "Vseslav22@ukr.net", new DateTime(2021, 8, 26, 22, 34, 48, 159, DateTimeKind.Local).AddTicks(102), "Петрів", "докт. психол. наук", "7761707558", "Секретар", 15671.25m, "Computers, Health & Toys" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 22, 21, 45, 6, 206, DateTimeKind.Local).AddTicks(5859), "Молодіжна майдан, 4, Шостка, Нігер", new DateTime(2006, 8, 30, 19, 28, 27, 604, DateTimeKind.Local).AddTicks(7093), "Rostislava_Openko55@ukr.net", new DateTime(2021, 1, 25, 16, 43, 21, 891, DateTimeKind.Local).AddTicks(8479), "Мирон", "Люта", "докт. пед. наук", "7011914496", 15006.23m, "navigating" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 13, 1, 9, 34, 56, DateTimeKind.Local).AddTicks(6506), "проспект Винників, 26, Олександрія, Об’єднані Арабські Емірати", new DateTime(2002, 11, 3, 23, 13, 23, 824, DateTimeKind.Local).AddTicks(2984), "Darislava_Sherbak49@e-mail.ua", new DateTime(2019, 7, 10, 21, 7, 24, 244, DateTimeKind.Local).AddTicks(9141), "Любомила", "Сідлецька", "канд. філос. наук", "0704960075", "Програміст", 1964.50m, "feed" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 24, 0, 46, 6, 152, DateTimeKind.Local).AddTicks(7739), "вулиця Коліївщини, 34, Західний Яромил, Фінляндія", new DateTime(1997, 8, 14, 9, 18, 3, 333, DateTimeKind.Local).AddTicks(7835), "Anastasiya_Tryasun@i.ua", null, "Ілля", "Малкович", "доц.", "8713752555", "Програміст", 15891.18m, "intermediate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 30, 10, 55, 56, 787, DateTimeKind.Local).AddTicks(3521), "провулок Зелена, 1, Західний Єремій, Руанда", new DateTime(1970, 4, 22, 4, 27, 11, 13, DateTimeKind.Local).AddTicks(6702), "Dobromira21@ukr.net", new DateTime(2019, 11, 27, 21, 36, 29, 222, DateTimeKind.Local).AddTicks(9553), "Аделаїда", "Коцюбинська", "докт. філос. наук", "3819643893", "Прибиральник", 16193.77m, "Missouri" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 52, 9, 437, DateTimeKind.Local).AddTicks(6419), "вулиця Рудного, 07, Східний Велемир, Філіппіни", new DateTime(2004, 11, 19, 14, 30, 41, 83, DateTimeKind.Local).AddTicks(9963), "Mikola34@ex.ua", null, "Ангеліна", "Гарай", "докт. техн. наук", "8873116207", "Бухгалтер", 4035.80m, "deposit" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 12, 10, 30, 34, 716, DateTimeKind.Local).AddTicks(5334), "провулок Молодіжна, 3, Кривий Ріг, Шрі-Ланка", new DateTime(1991, 8, 22, 13, 1, 28, 272, DateTimeKind.Local).AddTicks(7641), "Ustina.Usich@ukr.net", null, "Любов", "Латанський", "канд. філос. наук", "0244676561", "Програміст", 8182.31m, "Games" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 26, 17, 46, 16, 378, DateTimeKind.Local).AddTicks(2501), "Староміська майдан, 1, Лисичанськ, Гвінея-Бісау", new DateTime(2013, 8, 22, 15, 55, 30, 758, DateTimeKind.Local).AddTicks(3911), "Shek_Gromiko8@gmail.com", new DateTime(2022, 8, 16, 15, 42, 36, 916, DateTimeKind.Local).AddTicks(8960), "Ладо", "Савицький", "докт. пед. наук", "4957373550", 1563.08m, "Senior" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 27, 14, 8, 43, 22, DateTimeKind.Local).AddTicks(636), "вул. Ліста, 522, Мелітополь, Кот-д’Івуар", new DateTime(1973, 3, 9, 12, 3, 7, 204, DateTimeKind.Local).AddTicks(9222), "Dmitro_Moskal4@e-mail.ua", new DateTime(2020, 5, 22, 10, 48, 56, 296, DateTimeKind.Local).AddTicks(6762), "Синьоок", "Бурмило", "канд. техн. наук", "9081956437", "Прибиральник", 4718.89m, "Wisconsin" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 12, 17, 47, 20, 880, DateTimeKind.Local).AddTicks(3421), "проспект Вузька, 71, Південний Архип, Вірменія", new DateTime(1978, 12, 30, 3, 37, 52, 169, DateTimeKind.Local).AddTicks(3537), "Roman.Shestak@ukr.net", null, "Іннеса", "Компанієць", "проф.", "4521350050", 2618.56m, "New Mexico" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 12, 4, 30, 51, 741, DateTimeKind.Local).AddTicks(8259), "Брюховичів майдан, 48, Алчевськ, Кіпр", new DateTime(2022, 5, 1, 5, 16, 37, 626, DateTimeKind.Local).AddTicks(6383), "Anna_Maistrenko@meta.ua", "Борислава", "Кордун", "канд. філос. наук", "0298981948", "Бухгалтер", 16052.79m, "Cliff" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 22, 3, 6, 39, 692, DateTimeKind.Local).AddTicks(3049), "пл. Винників, 5, Бердянськ, Гвінея", new DateTime(1947, 2, 3, 14, 20, 17, 966, DateTimeKind.Local).AddTicks(4917), "Zoreslava.Ganich30@gmail.com", new DateTime(2019, 8, 14, 11, 55, 43, 225, DateTimeKind.Local).AddTicks(7463), "Валентина", "Хитрово", "докт. політ. наук", "1848831924", "Секретар", 4866.27m, "lime" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 15, 19, 20, 3, 948, DateTimeKind.Local).AddTicks(3168), "вулиця Брюховичів, 936, Північний Семибор, Бангладеш", new DateTime(2011, 9, 1, 17, 34, 18, 0, DateTimeKind.Local).AddTicks(6108), "Yarovid_Troyan@meta.ua", new DateTime(2021, 1, 14, 22, 46, 20, 740, DateTimeKind.Local).AddTicks(8074), "Пантелеймон", "Скиба", "канд. психол. наук", "6756475513", "Програміст", 19426.15m, "Senior" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 5, 31, 7, 51, 36, 786, DateTimeKind.Local).AddTicks(7178), "Винників майдан, 3, Івано-Франківськ, Узбекистан", new DateTime(1956, 12, 6, 6, 49, 44, 983, DateTimeKind.Local).AddTicks(3212), "Zlata_Shiyan11@yandex.ua", new DateTime(2023, 2, 8, 13, 27, 1, 487, DateTimeKind.Local).AddTicks(3444), "Любомир", "Данилко", "докт. філол. наук", "2294183267", "Програміст", 19440.90m, "Terrace" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 30, 4, 23, 37, 645, DateTimeKind.Local).AddTicks(1873), "вулиця Городоцька, 961, Східний Зоремир, Венесуела", new DateTime(1982, 5, 21, 4, 47, 33, 769, DateTimeKind.Local).AddTicks(6406), "Yaroslava82@gmail.com", null, "Ореста", "Ялова", "докт. філос. наук", "0176955961", "Прибиральник", 12735.93m, "Cross-group" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 3, 28, 20, 13, 14, 765, DateTimeKind.Local).AddTicks(5693), "проспект Городоцька, 4, Північний Антін, Франція", new DateTime(1985, 7, 12, 8, 27, 10, 623, DateTimeKind.Local).AddTicks(3405), "Albert_Bilich@yandex.ua", "Доброслава", "Яцишин", "канд. психол. наук", "2521449815", 3324.87m, "robust" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 26, 21, 52, 42, 601, DateTimeKind.Local).AddTicks(9611), "Нижанківського майдан, 1, Ужгород, Замбія", new DateTime(1976, 2, 19, 16, 17, 29, 840, DateTimeKind.Local).AddTicks(1187), "Makar80@e-mail.ua", "Оксана", "Сірко", "докт. філос. наук", "4127454772", "Прибиральник", 15243.11m, "bypassing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 3, 17, 4, 25, 47, 871, DateTimeKind.Local).AddTicks(4939), "пл. Нижанківського, 53, Житомир, Танзанія", new DateTime(1964, 12, 27, 18, 32, 34, 146, DateTimeKind.Local).AddTicks(5069), "Radoslava.Romochko73@i.ua", new DateTime(2022, 2, 9, 23, 45, 7, 78, DateTimeKind.Local).AddTicks(1087), "Ростислава", "Головець", "канд. філол. наук", "2354297642", "Прибиральник", 4367.01m, "override" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 10, 7, 14, 50, 991, DateTimeKind.Local).AddTicks(1140), "Зелена майдан, 655, Західний Градимир, Угорщина", new DateTime(1962, 11, 7, 7, 5, 33, 543, DateTimeKind.Local).AddTicks(8613), "Fevroniya.Lazirko@ex.ua", new DateTime(2021, 10, 26, 17, 33, 48, 289, DateTimeKind.Local).AddTicks(3746), "Людомила", "Ломова", "докт. філос. наук", "8539603911", "Директор", 12005.87m, "PNG" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 5, 13, 17, 25, 56, 584, DateTimeKind.Local).AddTicks(9237), "вулиця Молодіжна, 675, Луганськ, Кувейт", new DateTime(1990, 9, 30, 22, 39, 13, 864, DateTimeKind.Local).AddTicks(358), "Malva20@gmail.com", new DateTime(2019, 8, 14, 20, 1, 12, 470, DateTimeKind.Local).AddTicks(9868), "Віленіна", "Васильківський", "канд. юрид. наук", "1372265589", "Програміст", 5656.57m, "benchmark" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 3, 8, 5, 52, 8, 234, DateTimeKind.Local).AddTicks(6353), "вул. Нижанківського, 51, Нікополь, Угорщина", new DateTime(1981, 7, 1, 3, 24, 23, 518, DateTimeKind.Local).AddTicks(8152), "Alina89@yandex.ua", null, "Антон", "Пасічник", "доц.", "5757523662", "Бухгалтер", 10449.84m, "Garden & Movies" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 11, 21, 57, 7, 81, DateTimeKind.Local).AddTicks(4197), "Вічева майдан, 665, Східний Славолюб, Молдова", new DateTime(1974, 4, 14, 23, 27, 21, 87, DateTimeKind.Local).AddTicks(1483), "Kupava.Yashuk79@ex.ua", new DateTime(2022, 1, 1, 22, 27, 59, 392, DateTimeKind.Local).AddTicks(6967), "Ангеліна", "Компанієць", "канд. техн. наук", "0644253607", "Секретар", 10064.79m, "e-enable" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 1, 18, 15, 13, 45, DateTimeKind.Local).AddTicks(2256), "вул. Молодіжна, 4, Південний Гордій, Угорщина", new DateTime(1992, 7, 2, 5, 36, 51, 698, DateTimeKind.Local).AddTicks(9820), "Mikola_Suchak@ukr.net", "Даромир", "Тарасюк", "канд. політ. наук", "1368624993", "Бухгалтер", 16416.18m, "Expressway" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 9, 0, 47, 57, 296, DateTimeKind.Local).AddTicks(2666), "Молодіжна майдан, 2, Східний Ратимир, Люксембург", new DateTime(2000, 10, 3, 19, 6, 1, 339, DateTimeKind.Local).AddTicks(4395), "Maryan14@ex.ua", "Богдана", "Вергун", "проф.", "6546653787", "Програміст", 11225.04m, "expedite" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 15, 0, 21, 48, 109, DateTimeKind.Local).AddTicks(5117), "Зелена майдан, 20, Південний Захар, Суринам", new DateTime(1951, 2, 6, 6, 5, 21, 622, DateTimeKind.Local).AddTicks(281), "Oleksandr_Petik@ukr.net", new DateTime(2024, 1, 19, 22, 55, 57, 901, DateTimeKind.Local).AddTicks(9505), "Щастислав", "Компанієць", "доц.", "5432436633", 16235.91m, "leading edge" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 21, 5, 29, 41, 61, DateTimeKind.Local).AddTicks(3277), "пл. Стрийська, 16, Олександрія, Австралія", new DateTime(2008, 12, 12, 20, 7, 30, 960, DateTimeKind.Local).AddTicks(9309), "Olena_Troyan1@i.ua", new DateTime(2022, 11, 16, 22, 48, 37, 942, DateTimeKind.Local).AddTicks(8935), "Ярополк", "Мотрієнко", "докт. психол. наук", "1489489649", "Секретар", 2936.87m, "metrics" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 8, 29, 9, 19, 24, 475, DateTimeKind.Local).AddTicks(3119), "пров. Староміська, 20, Єнакієве, Буркіна-Фасо", new DateTime(1982, 6, 29, 0, 50, 55, 265, DateTimeKind.Local).AddTicks(4051), "Gorimir40@ex.ua", null, "Братослав", "Гриневецький", "докт. юрид. наук", "5723856521", "Прибиральник", 9515.76m, "Granite" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 8, 28, 6, 54, 5, 254, DateTimeKind.Local).AddTicks(6342), "Винників майдан, 6, Північний Щек, Болгарія", new DateTime(1960, 11, 10, 1, 42, 22, 738, DateTimeKind.Local).AddTicks(4647), "Dobromira88@meta.ua", "Поляна", "Дмитришин", "канд. психол. наук", "5351328121", "Директор", 15126.85m, "Sleek" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 6, 21, 19, 9, 820, DateTimeKind.Local).AddTicks(1744), "вулиця Брюховичів, 620, Керч, Східний Тимор", new DateTime(1979, 4, 29, 15, 22, 18, 558, DateTimeKind.Local).AddTicks(8643), "Bratislav_Berdnik9@yandex.ua", null, "Добромила", "Бачей", "канд. психол. наук", "9064706255", "Директор", 5654.70m, "Handcrafted" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 5, 4, 9, 39, 8, 727, DateTimeKind.Local).AddTicks(2215), "Молодіжна майдан, 7, Північний Андрій, Південний Судан", new DateTime(1950, 9, 4, 20, 4, 33, 363, DateTimeKind.Local).AddTicks(1121), "Petro69@ukr.net", new DateTime(2024, 1, 8, 1, 25, 25, 797, DateTimeKind.Local).AddTicks(9417), "Анастасій", "Ярмак", "0057237529", "Директор", 18869.91m, "Associate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 26, 7, 57, 8, 217, DateTimeKind.Local).AddTicks(1503), "Ліста майдан, 9, Одеса, Гондурас", new DateTime(1998, 5, 5, 10, 14, 3, 911, DateTimeKind.Local).AddTicks(1066), "Zakhar_Yackiv12@yandex.ua", null, "Антонія", "Сплюх", "докт. філол. наук", "2159727913", 7201.64m, "hacking" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 5, 19, 50, 31, 1, DateTimeKind.Local).AddTicks(4064), "вулиця Стрийська, 4, Східний Тарас, Норвегія", new DateTime(1999, 9, 30, 19, 6, 5, 587, DateTimeKind.Local).AddTicks(5970), "Violetta.Moskal@i.ua", "Іванна", "Каськів", "канд. філос. наук", "1481023517", 6688.63m, "FTP" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 21, 23, 33, 7, 92, DateTimeKind.Local).AddTicks(7949), "Коліївщини майдан, 246, Західний Аврелій, Бенін", new DateTime(1956, 10, 21, 8, 46, 35, 791, DateTimeKind.Local).AddTicks(8471), "Karina.Latanii@yandex.ua", new DateTime(2023, 10, 13, 15, 31, 11, 722, DateTimeKind.Local).AddTicks(2816), "Юстина", "Ємець", "докт. філол. наук", "1276221343", 15911.45m, "copying" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 11, 21, 11, 26, 15, 575, DateTimeKind.Local).AddTicks(9389), "пл. Ліста, 8, Конотоп, Кенія", new DateTime(2019, 2, 3, 12, 59, 51, 435, DateTimeKind.Local).AddTicks(1303), "Miloslava_Petrin97@gmail.com", null, "Анатолій", "Розпутня", "докт. юрид. наук", "0446371682", "Бухгалтер", 10318.94m, "Books" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 17, 0, 47, 42, 269, DateTimeKind.Local).AddTicks(71), "Нижанківського майдан, 380, Суми, Коморські Острови", new DateTime(2013, 5, 15, 9, 5, 45, 483, DateTimeKind.Local).AddTicks(7976), "Dobromisl.Bachei10@ex.ua", new DateTime(2020, 7, 28, 21, 1, 20, 982, DateTimeKind.Local).AddTicks(3991), "Мальва", "Гриневський", "доц.", "5918112415", "Прибиральник", 4845.34m, "transmit" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 12, 6, 32, 54, 44, DateTimeKind.Local).AddTicks(9041), "площа Вузька, 697, Донецьк, Сальвадор", new DateTime(1986, 4, 21, 21, 39, 37, 906, DateTimeKind.Local).AddTicks(9813), "Alevtina20@ex.ua", new DateTime(2022, 1, 19, 10, 38, 57, 266, DateTimeKind.Local).AddTicks(3746), "Захарій", "Забіла", "докт. політ. наук", "8523661537", "Бухгалтер", 8968.18m, "Books & Clothing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 1, 3, 7, 15, 24, 703, DateTimeKind.Local).AddTicks(5381), "Староміська майдан, 16, Південний Немир, Руанда", new DateTime(1951, 9, 3, 5, 13, 49, 767, DateTimeKind.Local).AddTicks(6703), "Mikhailo_Mariyevska41@ukr.net", new DateTime(2021, 7, 1, 2, 33, 33, 711, DateTimeKind.Local).AddTicks(620), "Анастасія", "Ганич", "канд. техн. наук", "4613302875", "Секретар", 2563.73m, "Personal Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 5, 7, 28, 37, 507, DateTimeKind.Local).AddTicks(1944), "Рудного майдан, 64, Західний Гнат, Естонія", new DateTime(2002, 10, 22, 6, 3, 56, 536, DateTimeKind.Local).AddTicks(5319), "Kupava.Petrina@yandex.ua", "Зорян", "Щербак", "докт. політ. наук", "3974867600", 19095.91m, "Islands" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 5, 22, 24, 32, 432, DateTimeKind.Local).AddTicks(2284), "Рудного майдан, 94, Південний Всеслав, Тувалу", new DateTime(1983, 2, 8, 17, 3, 35, 416, DateTimeKind.Local).AddTicks(3273), "Dobromir_Usich@meta.ua", new DateTime(2019, 10, 11, 21, 59, 59, 133, DateTimeKind.Local).AddTicks(904), "Добринка", "Семеночко", "докт. техн. наук", "4880698104", "Бухгалтер", 3759.12m, "full-range" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 1, 9, 4, 3, 26, 227, DateTimeKind.Local).AddTicks(386), "вул. Нижанківського, 78, Південний Тихон, Бахрейн", new DateTime(1959, 7, 27, 19, 14, 10, 285, DateTimeKind.Local).AddTicks(6606), "Daleslava.Pagutyak@yandex.ua", "Корнелій", "Боярчук", "канд. юрид. наук", "8102373098", "Бухгалтер", 10322.80m, "moderator" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 20, 7, 20, 1, 832, DateTimeKind.Local).AddTicks(1604), "площа Нижанківського, 67, Північний Стефаній, Гренада", new DateTime(1992, 10, 15, 20, 44, 28, 591, DateTimeKind.Local).AddTicks(4216), "Adriyan_Vitryak79@yandex.ua", null, "Христина", "Стоян", "докт. техн. наук", "5773359341", "Секретар", 8765.53m, "Music" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 25, 22, 13, 1, 262, DateTimeKind.Local).AddTicks(5752), "пл. Зелена, 740, Бердянськ, Велика Британія", new DateTime(2023, 12, 26, 13, 38, 9, 419, DateTimeKind.Local).AddTicks(3404), "Ustim58@ukr.net", new DateTime(2023, 6, 21, 2, 7, 16, 580, DateTimeKind.Local).AddTicks(8035), "Ликера", "Уманець", "канд. філол. наук", "2581021902", "Програміст", 2946.99m, "matrix" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 31, 23, 54, 55, 801, DateTimeKind.Local).AddTicks(3568), "пр. Рудного, 3, Слов’янськ, Індонезія", new DateTime(1982, 6, 18, 8, 44, 3, 314, DateTimeKind.Local).AddTicks(1424), "Albert_Balickii55@e-mail.ua", new DateTime(2020, 2, 29, 3, 16, 47, 732, DateTimeKind.Local).AddTicks(9587), "Тетяна", "докт. юрид. наук", "9208603969", "Прибиральник", 10378.01m, "toolset" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 19, 20, 46, 3, 514, DateTimeKind.Local).AddTicks(3847), "пл. Вічева, 0, Єнакієве, Перу", new DateTime(1958, 2, 21, 4, 48, 27, 745, DateTimeKind.Local).AddTicks(9362), "Rostislav60@gmail.com", "Устим", "Роменець", "докт. філол. наук", "1933725139", "Директор", 8633.38m, "Generic Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 10, 4, 17, 50, 979, DateTimeKind.Local).AddTicks(5187), "пл. Рудного, 106, Олександрія, Замбія", new DateTime(1944, 11, 14, 21, 17, 22, 66, DateTimeKind.Local).AddTicks(8157), "Rayina.Yalovii44@i.ua", new DateTime(2020, 3, 7, 4, 41, 27, 267, DateTimeKind.Local).AddTicks(3056), "Братимир", "Стоян", "докт. юрид. наук", "8335124940", "Програміст", 12788.46m, "Supervisor" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 12, 4, 23, 46, 170, DateTimeKind.Local).AddTicks(7818), "Вічева майдан, 364, Західний Богдан, Велика Британія", new DateTime(1999, 11, 3, 3, 6, 0, 557, DateTimeKind.Local).AddTicks(7311), "Dobroslava63@ukr.net", new DateTime(2021, 7, 11, 13, 50, 36, 17, DateTimeKind.Local).AddTicks(8972), "Альберт", "Павлів", "докт. пед. наук", "6130575006", "Бухгалтер", 13523.27m, "Estates" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 23, 19, 27, 51, 724, DateTimeKind.Local).AddTicks(1438), "Винників майдан, 016, Горлівка, Камерун", new DateTime(1981, 1, 16, 5, 18, 14, 281, DateTimeKind.Local).AddTicks(5457), "Yeremii.Usich89@ukr.net", "Кузьма", "Бондаренко", "канд. юрид. наук", "5149927444", 12327.32m, "Unbranded Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 12, 10, 50, 50, 453, DateTimeKind.Local).AddTicks(1372), "Зелена майдан, 085, Ужгород, Болгарія", new DateTime(1960, 11, 30, 9, 29, 31, 317, DateTimeKind.Local).AddTicks(4059), "Vasilina.Palii@yandex.ua", "Артемія", "Петренко", "докт. філос. наук", "5084461407", 18848.56m, "UAE Dirham" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 12, 0, 54, 43, 123, DateTimeKind.Local).AddTicks(7361), "пл. Вічева, 8, Бровари, Демократична Республіка Конго", new DateTime(2000, 8, 6, 9, 41, 41, 538, DateTimeKind.Local).AddTicks(8426), "Gelena_Luckiv77@yandex.ua", new DateTime(2021, 9, 12, 23, 29, 54, 152, DateTimeKind.Local).AddTicks(613), "Любомир", "Скоропадська", "докт. політ. наук", "9212690141", 10215.83m, "distributed" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 31, 6, 49, 5, 60, DateTimeKind.Local).AddTicks(8171), "пл. Нижанківського, 5, Сімферополь, Об’єднані Арабські Емірати", new DateTime(1953, 10, 21, 21, 28, 31, 285, DateTimeKind.Local).AddTicks(69), "Diana.Tryasun3@meta.ua", new DateTime(2021, 12, 12, 9, 42, 13, 350, DateTimeKind.Local).AddTicks(7302), "Калина", "Федоришина", "докт. техн. наук", "7327699443", "Програміст", 5303.17m, "Investment Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 4, 15, 19, 34, 42, 170, DateTimeKind.Local).AddTicks(5259), "вулиця Зелена, 974, Маріуполь, Гренада", new DateTime(2013, 8, 2, 2, 4, 58, 220, DateTimeKind.Local).AddTicks(1793), "Varvara55@e-mail.ua", new DateTime(2019, 8, 9, 17, 6, 35, 652, DateTimeKind.Local).AddTicks(4778), "Омелян", "Бандера", "канд. юрид. наук", "5394143455", "Бухгалтер", 13102.37m, "drive" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 7, 21, 39, 35, 331, DateTimeKind.Local).AddTicks(2168), "вулиця Рудного, 810, Бердичів, Норвегія", new DateTime(1991, 11, 2, 1, 41, 37, 962, DateTimeKind.Local).AddTicks(6497), "Vyacheslav_Serdyuk23@meta.ua", "Альберт", "Білич", "канд. філос. наук", "1365492016", "Бухгалтер", 9555.56m, "Eritrea" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 13, 23, 25, 35, 880, DateTimeKind.Local).AddTicks(7433), "Нижанківського майдан, 71, Хмельницький, Палау", new DateTime(1999, 9, 1, 22, 41, 40, 12, DateTimeKind.Local).AddTicks(7300), "Anna_Sirko@ex.ua", null, "Буйтур", "Корнїйчук", "докт. і. наук", "6101009266", "Бухгалтер", 4618.95m, "feed" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 2, 11, 6, 32, 16, 591, DateTimeKind.Local).AddTicks(4722), "пр. Рудного, 85, Чернігів, Угорщина", new DateTime(1962, 5, 8, 21, 34, 11, 17, DateTimeKind.Local).AddTicks(9465), "Zlat_Pavlishin70@yandex.ua", null, "Владислав", "Громико", "канд. філос. наук", "4925960074", "Програміст", 9715.62m, "Freeway" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 4, 15, 3, 19, 53, 848, DateTimeKind.Local).AddTicks(4056), "пл. Староміська, 61, Західний Аврелій, Мальта", new DateTime(1981, 4, 15, 14, 58, 55, 165, DateTimeKind.Local).AddTicks(7788), "Antoniya99@yandex.ua", new DateTime(2023, 1, 5, 13, 32, 37, 364, DateTimeKind.Local).AddTicks(3554), "Братослав", "Плаксій", "докт. пед. наук", "4639606494", "Прибиральник", 4479.54m, "panel" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 29, 14, 29, 43, 791, DateTimeKind.Local).AddTicks(1785), "Нижанківського майдан, 8, Південний Немир, Домініканська Республіка", new DateTime(1974, 8, 5, 11, 34, 53, 830, DateTimeKind.Local).AddTicks(6994), "Borimisl.Rozputnya54@meta.ua", new DateTime(2020, 11, 25, 10, 3, 39, 576, DateTimeKind.Local).AddTicks(8570), "Влада", "Стахів", "проф.", "8192042805", "Прибиральник", 18683.12m, "access" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 27, 21, 17, 40, 369, DateTimeKind.Local).AddTicks(6888), "Молодіжна майдан, 1, Східний Білослав, Ангола", new DateTime(2018, 7, 11, 16, 2, 11, 400, DateTimeKind.Local).AddTicks(3824), "Apolloniya8@ukr.net", null, "Корнило", "Шестак", "докт. юрид. наук", "1143921598", "Бухгалтер", 9447.81m, "dynamic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 10, 2, 35, 44, 475, DateTimeKind.Local).AddTicks(9261), "Городоцька майдан, 549, Західний Ладислав, Кенія", new DateTime(1981, 8, 22, 2, 52, 14, 419, DateTimeKind.Local).AddTicks(6828), "Radmila_Markiv@e-mail.ua", new DateTime(2022, 6, 23, 2, 34, 52, 571, DateTimeKind.Local).AddTicks(9626), "Божемир", "Паращук", "канд. пед. наук", "2459370484", "Прибиральник", 14941.08m, "maximize" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 4, 29, 14, 26, 19, 140, DateTimeKind.Local).AddTicks(9367), "пл. Вічева, 605, Луцьк, Саудівська Аравія", new DateTime(1955, 5, 27, 13, 46, 52, 997, DateTimeKind.Local).AddTicks(6243), "Kostyantin55@yandex.ua", null, "Милодара", "Григоришин", "канд. і. наук", "1228367545", "Бухгалтер", 19881.07m, "Fiji Dollar" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 6, 19, 21, 41, 754, DateTimeKind.Local).AddTicks(4463), "пр. Нижанківського, 59, Північний Земислав, Гвінея", new DateTime(1971, 12, 9, 1, 14, 50, 184, DateTimeKind.Local).AddTicks(7499), "Anton.Yermak@ex.ua", new DateTime(2022, 7, 8, 16, 17, 29, 175, DateTimeKind.Local).AddTicks(4093), "Орест", "Майборода", "докт. і. наук", "0853922465", "Директор", 5900.90m, "alliance" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 9, 3, 20, 12, 43, 273, DateTimeKind.Local).AddTicks(7874), "площа Нижанківського, 85, Північний Захар, Східний Тимор", new DateTime(1986, 2, 24, 10, 36, 56, 798, DateTimeKind.Local).AddTicks(5329), "Anfisa.Petlyura@ukr.net", new DateTime(2020, 3, 22, 13, 27, 57, 615, DateTimeKind.Local).AddTicks(457), "Ростислав", "Сторожук", "докт. техн. наук", "0605631057", 9983.28m, "SMS" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 14, 23, 816, DateTimeKind.Local).AddTicks(4497), "провулок Вічева, 1, Східний Братослав, Сент-Люсія", new DateTime(1985, 8, 29, 4, 41, 58, 90, DateTimeKind.Local).AddTicks(5012), "Maryana.Vitryak0@ex.ua", "Дана", "Ликович", "канд. політ. наук", "6827172514", 10114.26m, "Home Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 25, 22, 10, 6, 663, DateTimeKind.Local).AddTicks(8062), "Ліста майдан, 238, Полтава, Сан-Марино", new DateTime(1992, 9, 24, 18, 44, 6, 515, DateTimeKind.Local).AddTicks(1854), "Antin.Yalovii@gmail.com", new DateTime(2022, 1, 13, 0, 48, 40, 987, DateTimeKind.Local).AddTicks(200), "Харитина", "Гамула", "канд. філол. наук", "0562907367", 12454.88m, "payment" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 2, 0, 30, 28, 634, DateTimeKind.Local).AddTicks(444), "Зелена майдан, 164, Західний Корнило, Габон", new DateTime(1984, 9, 12, 20, 2, 27, 141, DateTimeKind.Local).AddTicks(6138), "Alina70@e-mail.ua", new DateTime(2022, 11, 13, 20, 20, 55, 568, DateTimeKind.Local).AddTicks(2829), "Хорив", "Скоропадська", "канд. пед. наук", "9021964832", "Директор", 11008.57m, "Djibouti" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 9, 28, 2, 7, 11, 745, DateTimeKind.Local).AddTicks(6116), "Нижанківського майдан, 6, Нікополь, Тонга", new DateTime(1946, 6, 4, 20, 35, 59, 726, DateTimeKind.Local).AddTicks(449), "Blagovista.Stoyan@meta.ua", new DateTime(2020, 8, 10, 23, 45, 14, 648, DateTimeKind.Local).AddTicks(9030), "Братислав", "Борочко", "канд. і. наук", "7965812718", 2007.24m, "Licensed" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 12, 30, 1, 4, 28, 883, DateTimeKind.Local).AddTicks(3805), "пл. Нижанківського, 06, Південний Подолян, США", new DateTime(1972, 11, 24, 8, 20, 20, 777, DateTimeKind.Local).AddTicks(1919), "Olga5@ukr.net", "Біляна", "Паращук", "2368555960", "Програміст", 8000.82m, "Fantastic Plastic Bike" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 12, 6, 4, 36, 17, 663, DateTimeKind.Local).AddTicks(5522), "Молодіжна майдан, 1, Мелітополь, Велика Британія", new DateTime(2000, 9, 13, 20, 37, 17, 905, DateTimeKind.Local).AddTicks(6532), "Zabava_Semenochko81@ex.ua", new DateTime(2021, 11, 25, 3, 42, 26, 426, DateTimeKind.Local).AddTicks(8343), "Марія", "Галатей", "доц.", "5444572745", "Секретар", 4713.21m, "application" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 20, 14, 35, 39, 557, DateTimeKind.Local).AddTicks(8258), "Коліївщини майдан, 026, Рівне, Люксембург", new DateTime(1997, 7, 30, 10, 39, 43, 183, DateTimeKind.Local).AddTicks(7686), "Izyaslav.Galatei6@meta.ua", "Кузьма", "Лящук", "канд. психол. наук", "9719145549", 4472.64m, "withdrawal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 5, 11, 18, 46, 34, 884, DateTimeKind.Local).AddTicks(680), "Стрийська майдан, 2, Дніпропетровськ, Домініка", new DateTime(1957, 2, 23, 11, 25, 31, 349, DateTimeKind.Local).AddTicks(3928), "Yaromil7@ukr.net", new DateTime(2020, 12, 11, 5, 37, 14, 383, DateTimeKind.Local).AddTicks(8844), "Ярема", "Сторожук", "канд. психол. наук", "6292744794", "Програміст", 19828.06m, "SDD" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 13, 21, 55, 1, 858, DateTimeKind.Local).AddTicks(5413), "пров. Ліста, 159, Південний Божемир, Об’єднані Арабські Емірати", new DateTime(2002, 3, 29, 6, 29, 3, 238, DateTimeKind.Local).AddTicks(1453), "Kvitoslava27@e-mail.ua", new DateTime(2023, 3, 2, 6, 2, 21, 835, DateTimeKind.Local).AddTicks(9076), "Людомила", "Лахман", "доц.", "1462197472", "Директор", 18454.65m, "Implementation" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 9, 6, 19, 6, 19, 629, DateTimeKind.Local).AddTicks(1600), "вулиця Староміська, 79, Ужгород, Гренада", new DateTime(1954, 3, 21, 4, 51, 33, 644, DateTimeKind.Local).AddTicks(4135), "Vasilina.Minyailo@ex.ua", null, "Роман", "Данилко", "докт. філол. наук", "8855154933", 6264.04m, "FTP" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 39, 51, 87, DateTimeKind.Local).AddTicks(993), "Нижанківського майдан, 01, Вінниця, Ірак", new DateTime(1967, 4, 30, 21, 32, 42, 795, DateTimeKind.Local).AddTicks(4429), "Yulianna_Plaksii68@gmail.com", "Дарій", "Єрмак", "канд. філол. наук", "2041065052", "Програміст", 16518.00m, "Incredible Cotton Fish" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 12, 16, 59, 9, 926, DateTimeKind.Local).AddTicks(6232), "пр. Стрийська, 5, Луганськ, Сент-Кітс і Невіс", new DateTime(1946, 7, 11, 9, 56, 45, 291, DateTimeKind.Local).AddTicks(7243), "Daromir.Luchko35@e-mail.ua", new DateTime(2020, 5, 14, 21, 51, 39, 327, DateTimeKind.Local).AddTicks(7228), "Доброслав", "Гордійчук", "канд. філос. наук", "3235173572", 10760.27m, "Small Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 28, 2, 50, 5, 338, DateTimeKind.Local).AddTicks(3346), "Рудного майдан, 436, Мукачеве, Малайзія", new DateTime(1954, 4, 7, 10, 18, 11, 900, DateTimeKind.Local).AddTicks(6423), "Rayina_Potebenko@gmail.com", new DateTime(2019, 10, 24, 22, 36, 41, 670, DateTimeKind.Local).AddTicks(4870), "Левко", "Мазайло", "докт. і. наук", "8357467312", "Прибиральник", 15827.07m, "Road" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 11, 15, 19, 21, 409, DateTimeKind.Local).AddTicks(605), "пров. Рудного, 32, Нікополь, Конго", new DateTime(1961, 4, 30, 12, 13, 19, 483, DateTimeKind.Local).AddTicks(9578), "Agapiya.Durdinec@gmail.com", null, "Добринка", "Ковальська", "доц.", "3780174334", 9899.33m, "copying" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 24, 5, 45, 16, 570, DateTimeKind.Local).AddTicks(9105), "Вузька майдан, 9, Мелітополь, Єгипет", new DateTime(1964, 8, 4, 9, 8, 29, 542, DateTimeKind.Local).AddTicks(7668), "Vadim89@i.ua", null, "Матвій", "Сердюк", "канд. техн. наук", "5768428317", "Прибиральник", 3441.53m, "generating" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 16, 2, 44, 13, 491, DateTimeKind.Local).AddTicks(844), "пров. Стрийська, 140, Східний Антон, Сьєрра-Леоне", new DateTime(2003, 3, 21, 4, 36, 18, 91, DateTimeKind.Local).AddTicks(2396), "Shek_Petik@ukr.net", "Ликера", "Шкараба", "канд. юрид. наук", "8263002990", 8740.87m, "Savings Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 24, 9, 25, 40, 450, DateTimeKind.Local).AddTicks(6190), "Винників майдан, 4, Севастополь, Джибуті", new DateTime(1985, 11, 1, 21, 44, 53, 516, DateTimeKind.Local).AddTicks(2586), "Afanasii_Palii@e-mail.ua", new DateTime(2020, 10, 9, 22, 24, 27, 721, DateTimeKind.Local).AddTicks(4412), "Лада", "Яцишина", "канд. і. наук", "5924295261", 5811.65m, "Surinam Dollar" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 2, 24, 17, 58, 28, 22, DateTimeKind.Local).AddTicks(5567), "Рудного майдан, 920, Північний Олелько, Сенеґал", new DateTime(2002, 10, 25, 11, 11, 23, 873, DateTimeKind.Local).AddTicks(2183), "Avgustin_Zinkevich9@meta.ua", null, "Немир", "Ялова", "докт. пед. наук", "1721361319", "Секретар", 14116.73m, "Cotton" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 5, 13, 22, 21, 759, DateTimeKind.Local).AddTicks(7855), "вул. Нижанківського, 08, Північний Славолюб, Папуа-Нова Гвінея", new DateTime(2007, 10, 24, 0, 16, 55, 613, DateTimeKind.Local).AddTicks(725), "Vlasta_Pavlenko83@meta.ua", new DateTime(2024, 4, 2, 22, 36, 17, 169, DateTimeKind.Local).AddTicks(3086), "Оксана", "Пасічник", "канд. пед. наук", "2709883474", "Директор", 10811.18m, "Principal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 1, 19, 7, 10, 53, DateTimeKind.Local).AddTicks(6847), "Городоцька майдан, 3, Південний Петро, Афганістан", new DateTime(2020, 8, 6, 0, 45, 52, 605, DateTimeKind.Local).AddTicks(1946), "Olena.Luchenko97@e-mail.ua", new DateTime(2020, 11, 18, 2, 25, 35, 601, DateTimeKind.Local).AddTicks(8966), "Анна", "Дурдинець", "проф.", "4286169157", 9236.88m, "Handmade" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 30, 23, 0, 30, 524, DateTimeKind.Local).AddTicks(7704), "пров. Вічева, 896, Львів, Мозамбік", new DateTime(2018, 5, 12, 12, 15, 8, 207, DateTimeKind.Local).AddTicks(9759), "Afanasiya83@i.ua", new DateTime(2020, 6, 19, 15, 33, 52, 771, DateTimeKind.Local).AddTicks(8452), "Дарислава", "Цимбалістий", "докт. філол. наук", "8826531347", "Директор", 8964.01m, "Alabama" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 11, 12, 17, 48, 36, 41, DateTimeKind.Local).AddTicks(9659), "пр. Вічева, 5, Північний Сологуб, Антигуа і Барбуда", new DateTime(2011, 5, 28, 1, 41, 30, 481, DateTimeKind.Local).AddTicks(5156), "Vasil50@e-mail.ua", new DateTime(2019, 7, 12, 5, 37, 31, 55, DateTimeKind.Local).AddTicks(9640), "Зоя", "Громико", "канд. психол. наук", "4988893678", "Бухгалтер", 18739.27m, "interfaces" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 15, 0, 14, 18, 921, DateTimeKind.Local).AddTicks(8783), "Городоцька майдан, 9, Краматорськ, Ліберія", new DateTime(2014, 4, 5, 10, 47, 6, 296, DateTimeKind.Local).AddTicks(3330), "Maryana.Kivach@i.ua", new DateTime(2022, 4, 1, 12, 54, 21, 703, DateTimeKind.Local).AddTicks(6073), "Ратибор", "Палій", "докт. філос. наук", "0204039528", "Прибиральник", 18696.91m, "Ergonomic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 23, 9, 23, 6, 145, DateTimeKind.Local).AddTicks(87), "пр. Зелена, 221, Південний Сологуб, Малаві", new DateTime(1954, 11, 15, 13, 58, 26, 791, DateTimeKind.Local).AddTicks(8530), "Lado_Shukhevich@e-mail.ua", "Марина", "Юхно", "канд. і. наук", "2184123322", "Директор", 16441.95m, "Cotton" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 8, 19, 4, 38, 4, 37, DateTimeKind.Local).AddTicks(160), "Стрийська майдан, 9, Західний Стефаній, Латвія", new DateTime(1973, 12, 19, 4, 26, 14, 63, DateTimeKind.Local).AddTicks(1174), "Miron_Bricka@ex.ua", "Ізяслав", "Павлів", "канд. філос. наук", "6296828221", 13118.00m, "Rubber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 8, 8, 30, 26, 846, DateTimeKind.Local).AddTicks(1246), "Нижанківського майдан, 674, Західний Роксолан, Тринідад і Тобаго", new DateTime(1988, 12, 19, 18, 11, 14, 966, DateTimeKind.Local).AddTicks(9480), "Yulian.Babukh@gmail.com", null, "Доляна", "Пасічник", "канд. пед. наук", "1315959701", "Програміст", 13384.06m, "transform" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 4, 18, 14, 50, 16, 946, DateTimeKind.Local).AddTicks(1503), "пров. Рудного, 9, Запоріжжя, Багамські Острови", new DateTime(2022, 5, 5, 13, 48, 32, 881, DateTimeKind.Local).AddTicks(2016), "Ada98@yandex.ua", "Корнило", "Гайовий", "докт. і. наук", "2294174099", "Прибиральник", 19077.62m, "disintermediate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 7, 7, 45, 12, 903, DateTimeKind.Local).AddTicks(9353), "Нижанківського майдан, 539, Кіровоград, Мозамбік", new DateTime(2006, 1, 12, 7, 41, 25, 329, DateTimeKind.Local).AddTicks(2291), "Milodara88@e-mail.ua", new DateTime(2022, 12, 1, 4, 51, 44, 810, DateTimeKind.Local).AddTicks(1473), "Зиновій", "Трясило", "канд. пед. наук", "9210740375", "Директор", 8996.33m, "bluetooth" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 7, 19, 0, 29, 335, DateTimeKind.Local).AddTicks(8706), "Ліста майдан, 546, Миколаїв, Португалія", new DateTime(1980, 1, 9, 23, 34, 5, 968, DateTimeKind.Local).AddTicks(5152), "Alevtin14@yandex.ua", new DateTime(2023, 5, 8, 17, 30, 27, 227, DateTimeKind.Local).AddTicks(6363), "Шкараба", "докт. і. наук", "7752816031", "Прибиральник", 13869.20m, "Guarani" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 5, 10, 44, 48, 259, DateTimeKind.Local).AddTicks(4376), "Винників майдан, 8, Південний Захар, Тринідад і Тобаго", new DateTime(1967, 3, 25, 7, 45, 1, 389, DateTimeKind.Local).AddTicks(1689), "Irma_Galatei67@gmail.com", "Добринка", "Силецький", "докт. техн. наук", "3124451690", "Програміст", 3194.80m, "solid state" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 14, 16, 22, 15, 994, DateTimeKind.Local).AddTicks(5191), "вул. Винників, 322, Кременчук, Гаїті", new DateTime(1959, 4, 7, 15, 8, 50, 424, DateTimeKind.Local).AddTicks(9488), "Lyubomira_Grishko@i.ua", new DateTime(2023, 1, 10, 1, 5, 25, 778, DateTimeKind.Local).AddTicks(3214), "Майя", "Пасічник", "канд. пед. наук", "2708562469", "Програміст", 1869.09m, "CFA Franc BEAC" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 9, 22, 9, 46, 37, 185, DateTimeKind.Local).AddTicks(4131), "площа Вічева, 73, Павлоград, Шрі-Ланка", new DateTime(1960, 2, 9, 13, 11, 52, 347, DateTimeKind.Local).AddTicks(6833), "Maryana89@meta.ua", new DateTime(2020, 12, 26, 14, 33, 40, 686, DateTimeKind.Local).AddTicks(493), "Мирослав", "Свидригайло", "канд. психол. наук", "5348251859", "Прибиральник", 7437.28m, "XSS" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 14, 14, 35, 11, 487, DateTimeKind.Local).AddTicks(5186), "Староміська майдан, 323, Луцьк, Індонезія", new DateTime(1963, 12, 18, 11, 2, 42, 520, DateTimeKind.Local).AddTicks(5454), "Zakhar_Porivailo@e-mail.ua", new DateTime(2019, 5, 18, 10, 49, 23, 890, DateTimeKind.Local).AddTicks(9335), "Максим", "Калач", "докт. філос. наук", "7693653215", "Програміст", 18950.43m, "Gorgeous Metal Hat" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 9, 26, 1, 54, 42, 593, DateTimeKind.Local).AddTicks(407), "провулок Вузька, 4, Північний Зиновій, Кенія", new DateTime(1947, 11, 8, 5, 50, 24, 898, DateTimeKind.Local).AddTicks(637), "Romena.Osadko@ukr.net", "Костянтин", "Маковецька", "докт. техн. наук", "6749233799", "Бухгалтер", 16155.41m, "orchid" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 4, 4, 20, 1, 34, 951, DateTimeKind.Local).AddTicks(3319), "площа Молодіжна, 696, Тернопіль, Колумбія", new DateTime(1998, 12, 13, 8, 53, 2, 47, DateTimeKind.Local).AddTicks(3879), "Vilenina.Kocyubinska1@meta.ua", "Радослава", "Лагойда", "докт. філол. наук", "4014368528", "Програміст", 13426.68m, "Concrete" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 17, 8, 19, 13, 629, DateTimeKind.Local).AddTicks(2188), "Стрийська майдан, 8, Східний Афанасій, Малайзія", new DateTime(1968, 8, 30, 22, 9, 30, 170, DateTimeKind.Local).AddTicks(6382), "Anastasiya74@ex.ua", new DateTime(2021, 3, 15, 5, 40, 6, 311, DateTimeKind.Local).AddTicks(8842), "Дарислава", "Бердник", "докт. юрид. наук", "4130121963", "Бухгалтер", 14923.12m, "Maryland" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 1, 20, 39, 27, 808, DateTimeKind.Local).AddTicks(8065), "проспект Ліста, 210, Північний Братислав, Мозамбік", new DateTime(1987, 1, 28, 9, 40, 56, 47, DateTimeKind.Local).AddTicks(5625), "Stanislava_Skiba40@e-mail.ua", new DateTime(2020, 2, 29, 6, 8, 11, 780, DateTimeKind.Local).AddTicks(8763), "Назар", "Гарун", "канд. філос. наук", "1212054747", 18501.41m, "protocol" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 2, 22, 5, 10, 20, DateTimeKind.Local).AddTicks(216), "Рудного майдан, 0, Південний Володимир, Чехія", new DateTime(1960, 7, 11, 17, 51, 37, 632, DateTimeKind.Local).AddTicks(2305), "Dobromir_Petrenko47@i.ua", new DateTime(2020, 2, 12, 18, 8, 51, 207, DateTimeKind.Local).AddTicks(3859), "Поліна", "Кулинич", "докт. політ. наук", "9805797695", 8849.84m, "mission-critical" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 14, 14, 40, 12, 407, DateTimeKind.Local).AddTicks(1120), "провулок Зелена, 63, Південний Славолюб, Сьєрра-Леоне", new DateTime(1961, 4, 20, 14, 52, 1, 106, DateTimeKind.Local).AddTicks(3918), "Zoya_Slobodyan93@i.ua", new DateTime(2023, 5, 30, 5, 17, 25, 200, DateTimeKind.Local).AddTicks(8409), "Сміяна", "Скоропадський", "канд. пед. наук", "8905219977", "Бухгалтер", 9759.53m, "connect" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 12, 7, 18, 25, 2, 989, DateTimeKind.Local).AddTicks(7490), "Молодіжна майдан, 52, Донецьк, Бахрейн", new DateTime(1948, 4, 2, 17, 30, 7, 837, DateTimeKind.Local).AddTicks(5579), "Zinayida50@ukr.net", null, "Мусій", "Михайлюк", "докт. філол. наук", "8647481862", "Бухгалтер", 9908.97m, "Tennessee" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 11, 25, 4, 14, 17, 724, DateTimeKind.Local).AddTicks(6128), "площа Коліївщини, 5, Східний Омелян, Польща", new DateTime(1966, 4, 9, 1, 15, 54, 656, DateTimeKind.Local).AddTicks(9424), "Oleksandr_Troyan@meta.ua", new DateTime(2020, 1, 10, 4, 59, 25, 525, DateTimeKind.Local).AddTicks(8022), "Артемія", "Потебенько", "канд. і. наук", "8109426120", 9224.00m, "deposit" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 9, 22, 15, 18, 45, 398, DateTimeKind.Local).AddTicks(4643), "Староміська майдан, 117, Слов’янськ, Сент-Вінсент і Гренадини", new DateTime(1998, 1, 26, 19, 5, 24, 630, DateTimeKind.Local).AddTicks(8374), "Bogdan_Unich@i.ua", "Марія", "Ломова", "докт. філос. наук", "9116568209", "Бухгалтер", 16639.90m, "Manager" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 29, 12, 27, 31, 296, DateTimeKind.Local).AddTicks(6411), "Нижанківського майдан, 16, Східний Денис, Україна", new DateTime(2016, 1, 12, 12, 6, 44, 50, DateTimeKind.Local).AddTicks(3724), "Yulian76@gmail.com", null, "Марія", "Балабуха", "докт. філол. наук", "4009192861", "Бухгалтер", 4609.20m, "moderator" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 6, 12, 58, 12, 484, DateTimeKind.Local).AddTicks(7949), "вулиця Городоцька, 684, Західний Хорив, Північна Корея", new DateTime(2021, 7, 25, 8, 31, 59, 770, DateTimeKind.Local).AddTicks(7334), "Ratibor_Yanyuk52@ukr.net", new DateTime(2021, 7, 31, 21, 38, 23, 281, DateTimeKind.Local).AddTicks(196), "Юстина", "Шестак", "докт. філос. наук", "7770283630", 2484.98m, "parsing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 4, 9, 13, 32, 911, DateTimeKind.Local).AddTicks(8316), "вулиця Коліївщини, 78, Донецьк, Маршаллові Острови", new DateTime(1979, 2, 8, 13, 57, 26, 869, DateTimeKind.Local).AddTicks(9309), "Yurii_Didukh38@ex.ua", null, "Зеновій", "Дзюб’як", "канд. філол. наук", "2804977259", 14158.28m, "Home Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 25, 8, 49, 53, 358, DateTimeKind.Local).AddTicks(4603), "вул. Брюховичів, 52, Південний Марко, Сент-Люсія", new DateTime(1965, 8, 4, 13, 30, 16, 965, DateTimeKind.Local).AddTicks(9617), "Izyaslav4@e-mail.ua", null, "Устина", "Лазірко", "докт. політ. наук", "0856957877", "Директор", 17651.12m, "Trafficway" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 16, 21, 5, 0, 891, DateTimeKind.Local).AddTicks(5057), "пл. Стрийська, 879, Східний Остап, Словенія", new DateTime(1963, 7, 17, 17, 24, 29, 630, DateTimeKind.Local).AddTicks(6793), "Pelagiya_Ponomariv@i.ua", new DateTime(2019, 12, 5, 3, 52, 24, 464, DateTimeKind.Local).AddTicks(3518), "Ізяслав", "Компанієць", "4651229518", "Секретар", 15841.66m, "Soft" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 5, 9, 39, 58, 724, DateTimeKind.Local).AddTicks(3911), "Городоцька майдан, 8, Суми, Сінгапур", new DateTime(2012, 12, 21, 20, 48, 52, 501, DateTimeKind.Local).AddTicks(7392), "Agapiya.Gladukh18@ukr.net", new DateTime(2019, 11, 21, 3, 9, 37, 873, DateTimeKind.Local).AddTicks(4566), "Броніслава", "Червоній", "канд. філол. наук", "1144407297", "Директор", 9735.80m, "bricks-and-clicks" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 28, 18, 53, 13, 59, DateTimeKind.Local).AddTicks(5358), "Стрийська майдан, 80, Горлівка, Болівія", new DateTime(1996, 6, 12, 13, 55, 26, 485, DateTimeKind.Local).AddTicks(6560), "Svyatoslav_Savicka82@yandex.ua", null, "Радослава", "Бердник", "докт. і. наук", "8441261934", 3502.55m, "Buckinghamshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 23, 15, 784, DateTimeKind.Local).AddTicks(8534), "Стрийська майдан, 9, Нікополь, Данія", new DateTime(1967, 12, 4, 17, 44, 40, 164, DateTimeKind.Local).AddTicks(9279), "Vitalina_Zlenko51@meta.ua", "Аліна", "Могилевський", "докт. філол. наук", "6573171538", "Програміст", 11231.02m, "haptic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 20, 9, 12, 42, 555, DateTimeKind.Local).AddTicks(399), "площа Молодіжна, 01, Чернівці, Сейшельські Острови", new DateTime(1972, 2, 4, 17, 40, 38, 626, DateTimeKind.Local).AddTicks(1959), "Kornilii7@meta.ua", "Матвій", "Юрчишина", "докт. і. наук", "9763473743", "Прибиральник", 15064.63m, "Up-sized" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 13, 22, 45, 42, 653, DateTimeKind.Local).AddTicks(7238), "Ліста майдан, 19, Павлоград, Австрія", new DateTime(1988, 7, 19, 11, 29, 38, 890, DateTimeKind.Local).AddTicks(58), "Dobroslava.Baranovskii72@ukr.net", null, "Хорив", "Миклухо", "канд. політ. наук", "5862413428", "Бухгалтер", 4496.26m, "Qatari Rial" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 17, 8, 31, 42, 688, DateTimeKind.Local).AddTicks(8320), "вулиця Вузька, 35, Донецьк, Домініка", new DateTime(2006, 9, 1, 6, 27, 27, 441, DateTimeKind.Local).AddTicks(7997), "Anastasii76@ex.ua", new DateTime(2019, 9, 15, 22, 37, 21, 32, DateTimeKind.Local).AddTicks(2713), "Ольга", "Сідлецька", "канд. психол. наук", "3965885376", "Секретар", 19784.63m, "holistic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 18, 4, 52, 7, 437, DateTimeKind.Local).AddTicks(4910), "вулиця Зелена, 83, Західний Подолян, Шрі-Ланка", new DateTime(1950, 6, 12, 14, 44, 20, 610, DateTimeKind.Local).AddTicks(9713), "Bilyana45@ex.ua", new DateTime(2019, 12, 26, 18, 6, 49, 260, DateTimeKind.Local).AddTicks(6579), "Олесь", "Ліхно", "докт. філол. наук", "9212444576", "Прибиральник", 9557.69m, "back-end" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 11, 22, 17, 32, 2, 380, DateTimeKind.Local).AddTicks(9532), "площа Винників, 9, Ужгород, Гвінея", new DateTime(1968, 7, 5, 0, 17, 19, 631, DateTimeKind.Local).AddTicks(2293), "Nataliya_Butko14@i.ua", "Лариса", "Стигайло", "докт. техн. наук", "8521805156", "Секретар", 18642.06m, "Metal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 34, 58, 373, DateTimeKind.Local).AddTicks(648), "Винників майдан, 9, Східний Максим, Парагвай", new DateTime(1955, 5, 24, 17, 48, 20, 611, DateTimeKind.Local).AddTicks(2851), "Alla53@ex.ua", new DateTime(2021, 8, 11, 16, 55, 39, 651, DateTimeKind.Local).AddTicks(3132), "Катерина", "Люта", "доц.", "5999200263", "Програміст", 15351.18m, "seize" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 11, 4, 10, 15, 34, 374, DateTimeKind.Local).AddTicks(1006), "пл. Коліївщини, 0, Західний Борислав, Замбія", new DateTime(1945, 7, 4, 18, 46, 56, 895, DateTimeKind.Local).AddTicks(2852), "Dobromisl.Unich@yandex.ua", new DateTime(2022, 5, 25, 3, 59, 26, 253, DateTimeKind.Local).AddTicks(5300), "Кузьма", "Марієвська", "проф.", "2744821023", "Директор", 7967.50m, "Ergonomic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 25, 18, 15, 6, 567, DateTimeKind.Local).AddTicks(2603), "Зелена майдан, 86, Луганськ, Кірибаті", new DateTime(1979, 2, 17, 12, 41, 34, 109, DateTimeKind.Local).AddTicks(5044), "Ladislav_Yanyuk25@ex.ua", "Радміла", "Ярмак", "проф.", "7562200321", "Бухгалтер", 1503.97m, "Practical" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 4, 13, 30, 1, 262, DateTimeKind.Local).AddTicks(8551), "Староміська майдан, 236, Північний Марко, Венесуела", new DateTime(1955, 3, 18, 10, 38, 12, 602, DateTimeKind.Local).AddTicks(1492), "Ustina28@yandex.ua", new DateTime(2022, 3, 14, 2, 47, 1, 371, DateTimeKind.Local).AddTicks(6882), "Мечислав", "Ярмак", "докт. техн. наук", "1456894329", "Директор", 7071.11m, "Garden" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 8, 13, 10, 32, 27, 206, DateTimeKind.Local).AddTicks(2546), "Коліївщини майдан, 3, Північний Будимир, Нова Зеландія", new DateTime(1944, 9, 24, 18, 35, 15, 327, DateTimeKind.Local).AddTicks(5080), "Dmitro.Kovalenko97@ukr.net", null, "Калина", "Бамбула", "5468364121", 3161.15m, "Republic of Korea" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 14, 31, 932, DateTimeKind.Local).AddTicks(5518), "Молодіжна майдан, 5, Східний Хвалимир, Антигуа і Барбуда", new DateTime(1978, 5, 20, 20, 12, 58, 272, DateTimeKind.Local).AddTicks(6042), "Lesya24@gmail.com", new DateTime(2022, 8, 31, 0, 54, 39, 170, DateTimeKind.Local).AddTicks(4674), "Пелагія", "Шкараба", "канд. і. наук", "5940586339", "Програміст", 17314.46m, "PCI" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 9, 19, 21, 30, 54, 950, DateTimeKind.Local).AddTicks(5143), "вулиця Ліста, 59, Східний Синьоок, Парагвай", new DateTime(2001, 12, 13, 16, 32, 19, 182, DateTimeKind.Local).AddTicks(99), "Velemir_Ganich44@yandex.ua", null, "Юліанна", "Ющук", "канд. філос. наук", "6480699019", "Секретар", 12917.73m, "Tugrik" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 2, 11, 7, 22, 5, 922, DateTimeKind.Local).AddTicks(4499), "вул. Стрийська, 1, Південний Святослав, Ємен", new DateTime(2004, 5, 25, 11, 19, 45, 948, DateTimeKind.Local), "Agniya.Mazailo@ukr.net", new DateTime(2020, 4, 18, 21, 40, 4, 402, DateTimeKind.Local).AddTicks(2280), "Радим", "Могилевська", "канд. пед. наук", "2908678689", "Прибиральник", 7241.58m, "Wall" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 7, 14, 41, 21, 367, DateTimeKind.Local).AddTicks(5817), "Молодіжна майдан, 3, Північний Вадим, Мозамбік", new DateTime(1973, 3, 5, 8, 47, 36, 823, DateTimeKind.Local).AddTicks(6666), "Nemira.Sayenko@meta.ua", "Олелько", "Ющук", "канд. політ. наук", "1337751670", 6531.14m, "Grocery, Toys & Outdoors" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 6, 20, 7, 49, 394, DateTimeKind.Local).AddTicks(6389), "пров. Вічева, 711, Нікополь, Соломонові Острови", new DateTime(2008, 1, 10, 21, 6, 7, 891, DateTimeKind.Local).AddTicks(2665), "Afanasii.Mazailo84@gmail.com", null, "Натан", "Пагутяк", "канд. політ. наук", "2580153641", 1354.02m, "Swiss Franc" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 22, 9, 13, 1, 39, DateTimeKind.Local).AddTicks(5795), "Зелена майдан, 5, Західний Юліан, Іран", new DateTime(1947, 10, 9, 16, 8, 47, 295, DateTimeKind.Local).AddTicks(3167), "Yaroslav.Korovyak@i.ua", new DateTime(2019, 11, 2, 3, 15, 57, 342, DateTimeKind.Local).AddTicks(3540), "Буревіст", "Гайчук", "докт. філол. наук", "2389385032", "Секретар", 7688.13m, "quantifying" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 1, 7, 25, 31, 347, DateTimeKind.Local).AddTicks(9848), "пр. Коліївщини, 4, Південний Семибор, Непал", new DateTime(1964, 11, 1, 5, 28, 42, 758, DateTimeKind.Local).AddTicks(6783), "Dobromir_Pogiba@i.ua", null, "Дмитро", "Стоян", "докт. техн. наук", "1126460577", "Програміст", 16692.68m, "Program" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 3, 23, 20, 33, 7, 528, DateTimeKind.Local).AddTicks(4120), "провулок Ліста, 378, Північний Афанасій, Франція", new DateTime(1965, 6, 1, 5, 23, 23, 64, DateTimeKind.Local).AddTicks(4600), "Mikhailo.Kordun@e-mail.ua", new DateTime(2019, 8, 26, 1, 58, 51, 316, DateTimeKind.Local).AddTicks(4850), "Стефаній", "Лахман", "докт. філос. наук", "0911551031", "Секретар", 19378.68m, "Awesome Granite Towels" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 26, 6, 30, 15, 579, DateTimeKind.Local).AddTicks(8555), "Брюховичів майдан, 5, Горлівка, Швеція", new DateTime(1945, 6, 3, 21, 23, 56, 168, DateTimeKind.Local).AddTicks(7932), "Timofii.Mamii82@meta.ua", "Ярослава", "Паламарчук", "докт. юрид. наук", "9083120048", "Програміст", 12066.87m, "Land" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 20, 22, 3, 18, 801, DateTimeKind.Local).AddTicks(1615), "Ліста майдан, 778, Дніпропетровськ, Оман", new DateTime(1979, 5, 23, 17, 38, 50, 573, DateTimeKind.Local).AddTicks(6408), "Diyana84@i.ua", new DateTime(2020, 5, 27, 22, 13, 35, 737, DateTimeKind.Local).AddTicks(737), "Ратимир", "Зінкевич", "докт. філос. наук", "3445219366", 12606.79m, "Place" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 26, 7, 38, 45, 794, DateTimeKind.Local).AddTicks(6494), "площа Зелена, 134, Дніпродзержинськ, Венесуела", new DateTime(1945, 12, 3, 18, 29, 42, 726, DateTimeKind.Local).AddTicks(1911), "Borimisl73@yandex.ua", "Мечислава", "Семеночко", "канд. техн. наук", "3283960878", "Програміст", 19738.94m, "Mountain" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 1, 9, 11, 5, 1, 5, DateTimeKind.Local).AddTicks(8169), "вул. Староміська, 29, Південний Тихон, Гамбія", new DateTime(1993, 9, 29, 13, 42, 38, 225, DateTimeKind.Local).AddTicks(1201), "Avreliya36@meta.ua", "Матвій", "Довгалевська", "канд. юрид. наук", "7267807315", "Програміст", 8114.40m, "Dynamic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 16, 23, 58, 17, 837, DateTimeKind.Local).AddTicks(4162), "Ліста майдан, 1, Одеса, Північна Корея", new DateTime(1969, 11, 21, 15, 53, 16, 945, DateTimeKind.Local).AddTicks(6030), "Yana_Semenochko@yandex.ua", null, "Братослав", "Малкович", "доц.", "2883421342", "Програміст", 2291.77m, "navigate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 19, 6, 43, 18, 73, DateTimeKind.Local).AddTicks(7091), "Городоцька майдан, 7, Сімферополь, Китай", new DateTime(1962, 4, 20, 9, 28, 40, 863, DateTimeKind.Local).AddTicks(9879), "Maksim53@ukr.net", "Орест", "Сосюра", "канд. політ. наук", "7490243122", "Секретар", 19018.63m, "partnerships" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 3, 12, 21, 42, 21, 784, DateTimeKind.Local).AddTicks(4176), "вул. Староміська, 625, Сєвєродонецьк, Катар", new DateTime(1989, 8, 15, 12, 39, 13, 395, DateTimeKind.Local).AddTicks(1838), "Dobroslava_Vasilin12@ex.ua", "Леся", "Зінкевич", "докт. політ. наук", "0072293967", "Прибиральник", 14375.89m, "white" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 4, 3, 13, 53, 53, 191, DateTimeKind.Local).AddTicks(5833), "вул. Нижанківського, 91, Красний Луч, Уругвай", new DateTime(2005, 5, 1, 16, 38, 4, 223, DateTimeKind.Local).AddTicks(3068), "Lyubomila_Savicka41@gmail.com", null, "Азарій", "Ткаченко", "канд. філол. наук", "0837890039", "Секретар", 7339.48m, "bandwidth" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 1, 10, 15, 10, 830, DateTimeKind.Local).AddTicks(225), "площа Коліївщини, 075, Західний Аврелій, Алжир", new DateTime(1982, 6, 25, 0, 12, 29, 992, DateTimeKind.Local).AddTicks(9807), "Smiyana.Tretyak44@ex.ua", new DateTime(2021, 6, 15, 22, 50, 25, 323, DateTimeKind.Local).AddTicks(2766), "Тамара", "Махно", "докт. філол. наук", "4190678068", 14386.08m, "benchmark" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 4, 11, 22, 37, 933, DateTimeKind.Local).AddTicks(3542), "пров. Стрийська, 94, Луцьк, Бангладеш", new DateTime(1985, 7, 4, 1, 57, 29, 423, DateTimeKind.Local).AddTicks(8398), "Ustina54@ex.ua", null, "Аполлінарія", "Могилевський", "докт. психол. наук", "4441847732", "Програміст", 4249.20m, "Unbranded Steel Towels" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 2, 12, 44, 27, 174, DateTimeKind.Local).AddTicks(2782), "пл. Ліста, 1, Лисичанськ, Румунія", new DateTime(1961, 3, 13, 11, 42, 49, 365, DateTimeKind.Local).AddTicks(4863), "Valentin64@ukr.net", new DateTime(2021, 8, 23, 10, 48, 23, 718, DateTimeKind.Local).AddTicks(1713), "Азалія", "Петлюра", "докт. і. наук", "4433375021", "Прибиральник", 7899.85m, "web-enabled" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 12, 9, 0, 8, 50, 35, DateTimeKind.Local).AddTicks(4785), "Коліївщини майдан, 8, Південний Ладислав, Бруней", new DateTime(2006, 7, 3, 18, 55, 10, 585, DateTimeKind.Local).AddTicks(5111), "Vitalina_Gaichuk57@yandex.ua", new DateTime(2020, 4, 12, 2, 43, 5, 512, DateTimeKind.Local).AddTicks(7744), "Агнеса", "Потоцька", "канд. філос. наук", "7439386402", "Бухгалтер", 10267.42m, "Direct" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 20, 11, 43, 46, 731, DateTimeKind.Local).AddTicks(3560), "провулок Брюховичів, 12, Маріуполь, Таїланд", new DateTime(1972, 8, 25, 16, 48, 18, 21, DateTimeKind.Local).AddTicks(3114), "Inna92@ukr.net", "Олексій", "Юхно", "докт. пед. наук", "1531766397", "Директор", 11665.32m, "Forest" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 26, 12, 28, 17, 99, DateTimeKind.Local).AddTicks(7474), "пл. Нижанківського, 46, Східний Степан, Туніс", new DateTime(1944, 8, 3, 16, 39, 55, 92, DateTimeKind.Local).AddTicks(1055), "Borimir16@gmail.com", null, "Ольга", "Петик", "канд. пед. наук", "5251522165", "Прибиральник", 1294.84m, "Regional" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 16, 22, 45, 57, 636, DateTimeKind.Local).AddTicks(1934), "Нижанківського майдан, 7, Південний Лаврентій, Словаччина", new DateTime(1961, 12, 2, 8, 38, 27, 228, DateTimeKind.Local).AddTicks(3304), "Nemir.Butko19@i.ua", "Майя", "Скоропадська", "канд. філос. наук", "6164264049", 12954.33m, "hack" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 27, 8, 14, 4, 306, DateTimeKind.Local).AddTicks(5573), "Рудного майдан, 7, Східний Божен, Намібія", new DateTime(1974, 11, 17, 14, 45, 46, 144, DateTimeKind.Local).AddTicks(9016), "Dobromila_Vergun29@ex.ua", "Захар", "Опенько", "докт. філол. наук", "5962106394", "Секретар", 15493.41m, "Home Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 30, 9, 36, 38, 168, DateTimeKind.Local).AddTicks(5986), "Коліївщини майдан, 1, Одеса, Сьєрра-Леоне", new DateTime(1947, 5, 29, 23, 25, 20, 97, DateTimeKind.Local).AddTicks(6546), "Gerasim_Romochko@i.ua", "Пантелеймон", "Гайчук", "канд. філол. наук", "5775542949", "Бухгалтер", 4398.80m, "technologies" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 3, 25, 3, 42, 10, 626, DateTimeKind.Local).AddTicks(4868), "пр. Молодіжна, 8, Західний Славута, Ліван", new DateTime(2018, 9, 17, 4, 32, 40, 978, DateTimeKind.Local).AddTicks(3315), "Slavomir.Mariyevska@gmail.com", new DateTime(2022, 5, 16, 4, 31, 48, 767, DateTimeKind.Local).AddTicks(2412), "Горислав", "Лютий", "канд. політ. наук", "8301945040", "Бухгалтер", 12711.28m, "Auto Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 14, 17, 25, 45, 497, DateTimeKind.Local).AddTicks(2898), "Вузька майдан, 631, Павлоград, Філіппіни", new DateTime(2012, 5, 19, 18, 18, 7, 14, DateTimeKind.Local).AddTicks(9754), "Maryana.Moskal@gmail.com", new DateTime(2022, 3, 10, 1, 54, 15, 921, DateTimeKind.Local).AddTicks(8576), "Віліна", "Люта", "канд. філол. наук", "4783835673", "Директор", 2619.56m, "sensor" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 5, 12, 41, 24, 949, DateTimeKind.Local).AddTicks(2633), "Стрийська майдан, 532, Алчевськ, Еритрея", new DateTime(2017, 6, 6, 21, 31, 36, 283, DateTimeKind.Local).AddTicks(5502), "Dalemir95@gmail.com", "Ірма", "Шухевич", "докт. юрид. наук", "2260544141", "Прибиральник", 12048.59m, "Madagascar" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 28, 10, 37, 33, 965, DateTimeKind.Local).AddTicks(8602), "пр. Стрийська, 7, Східний Юрій, Люксембург", new DateTime(2002, 12, 24, 19, 25, 49, 637, DateTimeKind.Local).AddTicks(9605), "Kornilo92@gmail.com", new DateTime(2023, 9, 23, 2, 59, 5, 842, DateTimeKind.Local).AddTicks(3068), "Горимир", "Третяк", "докт. політ. наук", "7751247467", 10207.96m, "Granite" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 8, 19, 20, 36, 871, DateTimeKind.Local).AddTicks(7962), "пров. Рудного, 0, Північний Лад, Австрія", new DateTime(1972, 2, 17, 11, 44, 2, 974, DateTimeKind.Local).AddTicks(1380), "Khristina_Stepanec47@gmail.com", new DateTime(2021, 2, 8, 18, 48, 56, 547, DateTimeKind.Local).AddTicks(2176), "Милодара", "Спотикач", "докт. філол. наук", "6067229599", "Директор", 8068.45m, "incremental" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 4, 12, 8, 48, 33, 802, DateTimeKind.Local).AddTicks(7892), "Коліївщини майдан, 68, Макіївка, Домініканська Республіка", new DateTime(1973, 3, 7, 4, 53, 47, 449, DateTimeKind.Local).AddTicks(1769), "Avrelii_Babukh89@gmail.com", new DateTime(2022, 6, 6, 5, 45, 25, 729, DateTimeKind.Local).AddTicks(6244), "Братомил", "Балабан", "докт. юрид. наук", "7202146559", "Секретар", 4800.45m, "hard drive" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 14, 4, 35, 11, 109, DateTimeKind.Local).AddTicks(5845), "пр. Городоцька, 08, Конотоп, Бангладеш", new DateTime(1948, 9, 19, 16, 44, 53, 49, DateTimeKind.Local).AddTicks(1781), "Timofii_Korecka55@meta.ua", new DateTime(2020, 9, 14, 17, 15, 43, 41, DateTimeKind.Local).AddTicks(2151), "Велемир", "Приймак", "докт. пед. наук", "6452823803", "Бухгалтер", 5339.97m, "Auto Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 13, 10, 33, 35, 543, DateTimeKind.Local).AddTicks(4941), "Брюховичів майдан, 922, Вінниця, Македонія", new DateTime(2020, 10, 27, 7, 5, 42, 636, DateTimeKind.Local).AddTicks(8032), "Maksim_Korecka72@meta.ua", new DateTime(2021, 8, 16, 13, 31, 36, 619, DateTimeKind.Local).AddTicks(9215), "Долеслава", "Цушко", "канд. і. наук", "9942539968", "Бухгалтер", 10172.83m, "Consultant" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 15, 7, 36, 46, 450, DateTimeKind.Local).AddTicks(6661), "Вузька майдан, 50, Артемівськ, Перу", new DateTime(1972, 4, 10, 9, 44, 46, 284, DateTimeKind.Local).AddTicks(779), "Dobromisl.Makovecka22@e-mail.ua", new DateTime(2022, 6, 13, 2, 53, 44, 55, DateTimeKind.Local).AddTicks(543), "Радим", "Барановський", "докт. техн. наук", "4484164522", "Програміст", 19795.06m, "Licensed" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 18, 2, 17, 34, 936, DateTimeKind.Local).AddTicks(3718), "Стрийська майдан, 54, Східний Радимир, Куба", new DateTime(1946, 5, 30, 18, 23, 14, 607, DateTimeKind.Local).AddTicks(7194), "Lyudmila.Lucka96@gmail.com", new DateTime(2020, 4, 12, 6, 30, 33, 857, DateTimeKind.Local).AddTicks(2419), "Ростислав", "Троян", "канд. філос. наук", "3843809653", "Секретар", 14080.95m, "Practical Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 12, 1, 13, 28, 27, 593, DateTimeKind.Local).AddTicks(6952), "провулок Молодіжна, 9, Житомир, Алжир", new DateTime(1953, 4, 26, 1, 7, 35, 934, DateTimeKind.Local).AddTicks(111), "Kornilii75@ex.ua", "Клавдія", "Ломова", "канд. політ. наук", "1520000521", "Прибиральник", 15045.78m, "Unbranded Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 20, 7, 32, 47, 637, DateTimeKind.Local).AddTicks(5704), "Городоцька майдан, 078, Західний Архип, Австрія", new DateTime(1970, 10, 8, 20, 3, 48, 917, DateTimeKind.Local).AddTicks(5522), "Ganna_Kolomiyec73@ukr.net", "Болеслава", "Гнатишин", "8317520808", "Бухгалтер", 2003.94m, "channels" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 20, 12, 9, 39, 210, DateTimeKind.Local).AddTicks(3021), "вулиця Ліста, 3, Запоріжжя, Чорногорія", new DateTime(1964, 2, 12, 10, 16, 9, 363, DateTimeKind.Local).AddTicks(6727), "Vlada92@ukr.net", new DateTime(2021, 8, 2, 2, 21, 56, 372, DateTimeKind.Local).AddTicks(9653), "Біломир", "Мотрієнко", "канд. філол. наук", "5150148950", "Секретар", 8982.82m, "cutting-edge" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 18, 20, 32, 12, 288, DateTimeKind.Local).AddTicks(3259), "вулиця Брюховичів, 47, Південний Лаврентій, Чилі", new DateTime(2012, 12, 19, 22, 33, 14, 345, DateTimeKind.Local).AddTicks(6818), "Markiyan_Demkiv34@ex.ua", "Пантелеймон", "Ялюк", "канд. юрид. наук", "3739913857", 1130.83m, "flexibility" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 2, 17, 19, 51, 43, 856, DateTimeKind.Local).AddTicks(4570), "площа Ліста, 36, Північний Анастас, Кувейт", new DateTime(1982, 11, 22, 5, 53, 24, 328, DateTimeKind.Local).AddTicks(5642), "Avrelii.Gladukh@i.ua", new DateTime(2019, 11, 6, 15, 47, 4, 245, DateTimeKind.Local).AddTicks(9548), "Слава", "Гайдук", "канд. психол. наук", "1221870345", "Директор", 4118.65m, "6th generation" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 12, 14, 40, 28, 129, DateTimeKind.Local).AddTicks(6398), "пл. Городоцька, 3, Північний Захар, Судан", new DateTime(1980, 4, 9, 0, 46, 33, 978, DateTimeKind.Local).AddTicks(4853), "Olena37@meta.ua", new DateTime(2023, 12, 2, 20, 19, 37, 273, DateTimeKind.Local).AddTicks(9228), "Григорій", "Довгалевська", "проф.", "0401364402", "Прибиральник", 14701.01m, "Intelligent Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 9, 12, 16, 27, 10, DateTimeKind.Local).AddTicks(9720), "площа Рудного, 3, Західний Божен, Аргентина", new DateTime(1973, 9, 12, 23, 31, 42, 677, DateTimeKind.Local).AddTicks(3682), "Gelena.Mikhailyuk@ex.ua", new DateTime(2022, 7, 6, 12, 43, 48, 605, DateTimeKind.Local).AddTicks(4784), "Арсеній", "Мотрієнко", "докт. політ. наук", "8753358233", "Директор", 15540.80m, "tangible" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 54, 32, 86, DateTimeKind.Local).AddTicks(3707), "пр. Молодіжна, 49, Красний Луч, Швейцарія", new DateTime(1971, 2, 2, 20, 3, 19, 244, DateTimeKind.Local).AddTicks(5365), "Mechislav_Kovalskii@gmail.com", "Квітка", "Шевченко", "доц.", "1231334131", "Прибиральник", 13286.15m, "composite" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 2, 16, 44, 51, 373, DateTimeKind.Local).AddTicks(5457), "Молодіжна майдан, 519, Північний Орест, Чехія", new DateTime(1986, 3, 27, 15, 8, 1, 920, DateTimeKind.Local).AddTicks(7678), "Bozhemir_Garai@i.ua", null, "Кий", "Білич", "канд. пед. наук", "9416588737", "Бухгалтер", 17758.89m, "executive" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 3, 43, 455, DateTimeKind.Local).AddTicks(2185), "пров. Стрийська, 564, Єнакієве, Бруней", new DateTime(2019, 10, 15, 10, 54, 41, 546, DateTimeKind.Local).AddTicks(5822), "Marko45@e-mail.ua", new DateTime(2021, 2, 17, 9, 56, 39, 959, DateTimeKind.Local).AddTicks(3737), "Доброслав", "Ющук", "канд. психол. наук", "2917530498", "Секретар", 9362.64m, "24/7" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 12, 10, 13, 51, 982, DateTimeKind.Local).AddTicks(9095), "проспект Городоцька, 857, Північний Лаврін, Нова Зеландія", new DateTime(1984, 2, 4, 2, 31, 41, 723, DateTimeKind.Local).AddTicks(3590), "Pavlina81@gmail.com", null, "Григорій", "Маринич", "канд. пед. наук", "4962740089", "Бухгалтер", 15896.00m, "Tasty Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 11, 1, 9, 2, 3, 499, DateTimeKind.Local).AddTicks(2244), "Вузька майдан, 3, Східний Петро, Південний Судан", new DateTime(1962, 7, 5, 23, 10, 19, 843, DateTimeKind.Local).AddTicks(3720), "Khoriv9@yandex.ua", "Ореста", "Брицька", "докт. техн. наук", "2637198367", 6959.11m, "Kids, Health & Jewelery" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 18, 14, 32, 19, 773, DateTimeKind.Local).AddTicks(5732), "Молодіжна майдан, 67, Миколаїв, Нова Зеландія", new DateTime(1976, 4, 8, 19, 43, 35, 478, DateTimeKind.Local).AddTicks(9494), "Viktoriya.Danilko@meta.ua", null, "Мусій", "Опенько", "канд. юрид. наук", "0872872701", "Секретар", 3279.10m, "open-source" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 19, 1, 20, 36, 305, DateTimeKind.Local).AddTicks(4427), "вулиця Молодіжна, 8, Полтава, Бурунді", new DateTime(1949, 2, 26, 2, 27, 21, 434, DateTimeKind.Local).AddTicks(6830), "Khristina_Dovgalevska@ukr.net", null, "Натан", "Милославський", "докт. юрид. наук", "2069050177", "Програміст", 8350.31m, "cyan" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 25, 8, 59, 59, 431, DateTimeKind.Local).AddTicks(5517), "пл. Стрийська, 3, Східний Білослав, Білорусь", new DateTime(2011, 8, 5, 19, 1, 59, 400, DateTimeKind.Local).AddTicks(8966), "Boris_Shevchenko@gmail.com", null, "Ада", "Гордійчук", "проф.", "9520147659", "Бухгалтер", 17236.98m, "Optional" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 30, 8, 59, 14, 666, DateTimeKind.Local).AddTicks(7409), "Молодіжна майдан, 097, Керч, Естонія", new DateTime(2006, 4, 21, 12, 41, 0, 778, DateTimeKind.Local).AddTicks(8297), "Agniya.Luckiv88@ex.ua", new DateTime(2020, 1, 1, 4, 44, 51, 61, DateTimeKind.Local).AddTicks(882), "Добромисл", "Компанієць", "канд. пед. наук", "4958046427", "Бухгалтер", 13542.38m, "Myanmar" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 5, 2, 16, 45, 30, 410, DateTimeKind.Local).AddTicks(6029), "Коліївщини майдан, 727, Південний Зоремир, Бахрейн", new DateTime(1954, 4, 20, 8, 1, 37, 704, DateTimeKind.Local).AddTicks(3833), "Galina.Mazun@ukr.net", "Юхимія", "Василин", "докт. техн. наук", "4448230729", "Директор", 12231.47m, "calculating" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 45, 22, 338, DateTimeKind.Local).AddTicks(8866), "Нижанківського майдан, 4, Південний Яровид, Алжир", new DateTime(1975, 5, 24, 14, 57, 3, 727, DateTimeKind.Local).AddTicks(3779), "Viktor_Yurchishin@yandex.ua", null, "Орина", "Янюк", "6127023463", "Секретар", 2246.29m, "National" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 13, 7, 2, 34, 865, DateTimeKind.Local).AddTicks(7477), "провулок Ліста, 2, Київ, Мадаґаскар", new DateTime(1961, 10, 9, 12, 38, 40, 667, DateTimeKind.Local).AddTicks(1228), "Zoryan.Goiko16@meta.ua", new DateTime(2022, 4, 16, 5, 19, 14, 333, DateTimeKind.Local).AddTicks(998), "Святослав", "Палій", "канд. пед. наук", "1416516635", 4745.25m, "Czech Koruna" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 9, 11, 8, 56, 54, 124, DateTimeKind.Local).AddTicks(4986), "провулок Стрийська, 57, Північний Азарій, Україна", new DateTime(2012, 12, 8, 15, 3, 29, 865, DateTimeKind.Local).AddTicks(6279), "Lyudomila.Lobachevska39@ex.ua", new DateTime(2023, 10, 18, 7, 26, 29, 687, DateTimeKind.Local).AddTicks(8956), "Захарій", "Гришко", "канд. політ. наук", "1998704612", "Прибиральник", 3855.25m, "Awesome" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 3, 7, 19, 2, 18, 951, DateTimeKind.Local).AddTicks(4245), "Вузька майдан, 0, Полтава, Сент-Люсія", new DateTime(1964, 2, 11, 21, 57, 32, 744, DateTimeKind.Local).AddTicks(3187), "Oles.Miloslavska25@ex.ua", null, "Ромена", "Лановий", "проф.", "8694576589", "Програміст", 11594.21m, "RSS" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 9, 1, 35, 41, 916, DateTimeKind.Local).AddTicks(8120), "Вузька майдан, 0, Львів, Чад", new DateTime(1957, 7, 20, 16, 31, 51, 764, DateTimeKind.Local).AddTicks(5287), "Anzhela.Prigoda3@gmail.com", new DateTime(2021, 9, 16, 8, 28, 28, 190, DateTimeKind.Local).AddTicks(9261), "Звенимир", "Григоришина", "канд. політ. наук", "3208773787", "Програміст", 18292.46m, "red" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 16, 13, 54, 14, 692, DateTimeKind.Local).AddTicks(5049), "провулок Ліста, 5, Східний Доброслав, Киргизстан", new DateTime(2016, 3, 18, 18, 40, 2, 205, DateTimeKind.Local).AddTicks(1247), "Svitlana87@ukr.net", new DateTime(2021, 8, 2, 7, 47, 57, 920, DateTimeKind.Local).AddTicks(6689), "Варвара", "Кулинич", "канд. юрид. наук", "3515393642", "Директор", 11240.70m, "Security" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 27, 17, 55, 10, 636, DateTimeKind.Local).AddTicks(537), "проспект Зелена, 0, Східний Зореслав, Чорногорія", new DateTime(1989, 11, 10, 13, 8, 50, 314, DateTimeKind.Local).AddTicks(1188), "Borislava.Pavlenko@ex.ua", new DateTime(2022, 5, 19, 3, 17, 54, 690, DateTimeKind.Local).AddTicks(8032), "Кий", "Кивач", "докт. психол. наук", "8352315736", "Бухгалтер", 9831.29m, "Future" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 22, 11, 9, 57, 648, DateTimeKind.Local).AddTicks(6081), "пров. Нижанківського, 719, Західний Натан, Болгарія", new DateTime(1986, 6, 18, 8, 45, 33, 395, DateTimeKind.Local).AddTicks(5360), "Bozhen_Romaniv@i.ua", new DateTime(2020, 3, 17, 12, 41, 16, 984, DateTimeKind.Local).AddTicks(7830), "Люборада", "Лагойда", "докт. пед. наук", "0718639994", "Секретар", 14043.70m, "SQL" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 2, 4, 25, 2, 34, DateTimeKind.Local).AddTicks(1006), "Городоцька майдан, 4, Запоріжжя, Сомалі", new DateTime(1957, 3, 10, 7, 10, 51, 648, DateTimeKind.Local).AddTicks(5184), "Krentta.Bambula@meta.ua", "Ратибор", "Сідляк", "канд. філос. наук", "3269850981", "Прибиральник", 13584.50m, "SSL" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 2, 52, 225, DateTimeKind.Local).AddTicks(7639), "проспект Ліста, 0, Луцьк, Маврикій", new DateTime(1987, 11, 11, 17, 59, 10, 504, DateTimeKind.Local).AddTicks(5497), "Pelagiya.Storozhuk@yandex.ua", "Поляна", "Головець", "докт. техн. наук", "5157229701", 10111.42m, "Garden, Industrial & Garden" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 0, 25, 843, DateTimeKind.Local).AddTicks(1955), "вул. Винників, 02, Євпаторія, Сербія", new DateTime(1952, 9, 27, 14, 48, 20, 748, DateTimeKind.Local).AddTicks(7095), "Azarii_Galacion@e-mail.ua", null, "Ігор", "Гордійчук", "докт. політ. наук", "6026154594", "Директор", 9533.53m, "Creative" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 6, 4, 10, 20, 526, DateTimeKind.Local).AddTicks(4770), "Брюховичів майдан, 901, Хмельницький, Маврикій", new DateTime(1960, 2, 21, 17, 4, 17, 7, DateTimeKind.Local).AddTicks(1066), "Larisa29@e-mail.ua", null, "Брячислав", "Шамрило", "докт. філол. наук", "1702169778", "Директор", 13888.47m, "relationships" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 18, 0, 58, 22, 153, DateTimeKind.Local).AddTicks(6154), "Зелена майдан, 85, Південний Яромил, Свазіленд", new DateTime(2005, 8, 25, 7, 17, 59, 426, DateTimeKind.Local).AddTicks(1373), "Marina_Balabukh@e-mail.ua", null, "Зборислав", "Петренко", "проф.", "8016291214", "Програміст", 3002.52m, "Incredible Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 24, 22, 24, 9, 727, DateTimeKind.Local).AddTicks(6533), "площа Ліста, 35, Чернівці, Уганда", new DateTime(1996, 9, 22, 17, 2, 58, 814, DateTimeKind.Local).AddTicks(611), "Mokrina.Gaiova@gmail.com", new DateTime(2020, 11, 10, 20, 41, 4, 935, DateTimeKind.Local).AddTicks(9), "Матвій", "Євпак", "канд. психол. наук", "4263061212", "Програміст", 16125.15m, "transmitting" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 5, 23, 13, 28, 193, DateTimeKind.Local).AddTicks(4760), "Коліївщини майдан, 932, Південний Петро, Чилі", new DateTime(2001, 4, 14, 21, 32, 29, 106, DateTimeKind.Local).AddTicks(6556), "Zvenislav.Romochko12@meta.ua", new DateTime(2021, 9, 8, 7, 17, 19, 678, DateTimeKind.Local).AddTicks(4951), "Даромир", "Магера", "докт. і. наук", "1632210823", "Прибиральник", 17069.33m, "Jamaican Dollar" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 3, 15, 17, 4, 3, 913, DateTimeKind.Local).AddTicks(2598), "Винників майдан, 50, Північний Владислав, Мальта", new DateTime(1998, 5, 10, 14, 15, 25, 962, DateTimeKind.Local).AddTicks(8521), "Chornota_Savicka@yandex.ua", null, "Натан", "Вітряк", "докт. пед. наук", "9545949435", "Прибиральник", 3146.11m, "Technician" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 4, 15, 5, 20, 308, DateTimeKind.Local).AddTicks(639), "Нижанківського майдан, 834, Західний Братомил, Ліхтенштейн", new DateTime(1983, 9, 27, 10, 41, 25, 263, DateTimeKind.Local).AddTicks(3503), "Olena_Koman@gmail.com", new DateTime(2020, 10, 16, 10, 34, 9, 803, DateTimeKind.Local).AddTicks(7297), "Анжела", "Каськів", "докт. філол. наук", "1791194137", "Бухгалтер", 6420.25m, "Fork" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 33, 14, 761, DateTimeKind.Local).AddTicks(8081), "пр. Рудного, 41, Олександрія, Сенеґал", new DateTime(1945, 8, 13, 16, 22, 48, 420, DateTimeKind.Local).AddTicks(597), "Khristina_Dzyuba@gmail.com", null, "Орина", "Гамула", "канд. пед. наук", "9382938326", 5051.70m, "Small Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 4, 7, 24, 45, 23, DateTimeKind.Local).AddTicks(3536), "провулок Нижанківського, 03, Кременчук, Парагвай", new DateTime(1948, 5, 19, 20, 27, 48, 893, DateTimeKind.Local).AddTicks(3846), "Nemir.Romenec@yandex.ua", new DateTime(2020, 7, 16, 20, 46, 8, 141, DateTimeKind.Local).AddTicks(6515), "Ганна", "Луговий", "канд. техн. наук", "1285610400", "Бухгалтер", 5652.92m, "copy" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 5, 17, 6, 7, 45, 859, DateTimeKind.Local).AddTicks(5789), "Вузька майдан, 68, Східний Тур, Туреччина", new DateTime(1965, 4, 5, 21, 43, 42, 879, DateTimeKind.Local).AddTicks(1602), "Gorislav.Yevpak@ukr.net", new DateTime(2019, 7, 25, 3, 30, 52, 267, DateTimeKind.Local).AddTicks(4773), "Юхим", "Брицька", "доц.", "9406075105", "Секретар", 11752.75m, "turquoise" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 8, 4, 20, 13, 851, DateTimeKind.Local).AddTicks(9612), "Староміська майдан, 138, Східний Кузьма, Малайзія", new DateTime(1976, 11, 20, 22, 3, 22, 964, DateTimeKind.Local).AddTicks(9475), "Zlatomir36@gmail.com", new DateTime(2020, 4, 4, 18, 21, 46, 939, DateTimeKind.Local).AddTicks(1135), "Ілона", "Ліхно", "докт. юрид. наук", "8182007764", 8204.23m, "hybrid" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 24, 3, 3, 14, 649, DateTimeKind.Local).AddTicks(3221), "пл. Рудного, 307, Східний Братомил, Маврикій", new DateTime(2018, 5, 11, 11, 56, 5, 985, DateTimeKind.Local).AddTicks(2262), "Volodimir_Petrenko@ex.ua", "Богуслава", "Галатей", "0760527079", "Бухгалтер", 17929.65m, "bypass" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 5, 15, 15, 13, 234, DateTimeKind.Local).AddTicks(7811), "Зелена майдан, 89, Кременчук, Домініканська Республіка", new DateTime(1961, 5, 3, 22, 37, 47, 915, DateTimeKind.Local).AddTicks(2895), "Syuzana_Maistrenko@ukr.net", "Мокрина", "Ланова", "докт. психол. наук", "4560704316", "Бухгалтер", 4588.23m, "Small" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 4, 6, 22, 34, 45, 87, DateTimeKind.Local).AddTicks(9555), "пл. Вузька, 9, Кам’янець-Подільський, Бахрейн", new DateTime(1947, 4, 27, 12, 20, 45, 950, DateTimeKind.Local).AddTicks(8804), "Agnesa_Lindik@i.ua", new DateTime(2019, 12, 12, 22, 50, 54, 0, DateTimeKind.Local).AddTicks(6095), "Добринка", "Гойко", "8962958781", "Секретар", 2136.89m, "function" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 23, 18, 19, 27, 158, DateTimeKind.Local).AddTicks(8299), "Городоцька майдан, 10, Шостка, Оман", new DateTime(1981, 4, 15, 13, 2, 10, 279, DateTimeKind.Local).AddTicks(6618), "Okhrim32@ukr.net", "Варвара", "Гриневський", "докт. психол. наук", "6180332978", "Бухгалтер", 12695.54m, "Intelligent Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 4, 13, 33, 36, 846, DateTimeKind.Local).AddTicks(3514), "провулок Вічева, 629, Західний Мусій, Беліз", new DateTime(1965, 11, 26, 6, 20, 11, 820, DateTimeKind.Local).AddTicks(9870), "Yarovid_Malkovich91@e-mail.ua", null, "Боримисл", "Волощук", "докт. техн. наук", "1944582950", "Секретар", 5796.99m, "Clothing & Books" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 28, 15, 6, 11, 292, DateTimeKind.Local).AddTicks(3904), "вулиця Винників, 693, Південний Микола, Суринам", new DateTime(1984, 7, 31, 3, 34, 19, 741, DateTimeKind.Local).AddTicks(67), "Lyubov69@i.ua", new DateTime(2022, 6, 6, 8, 51, 23, 815, DateTimeKind.Local).AddTicks(2017), "Захар", "Головець", "доц.", "6938716549", "Секретар", 6495.81m, "wireless" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 7, 19, 23, 1, 931, DateTimeKind.Local).AddTicks(6519), "Брюховичів майдан, 36, Ужгород, Камбоджа", new DateTime(1997, 1, 23, 1, 11, 42, 265, DateTimeKind.Local).AddTicks(8924), "Radoslava_Balakun@e-mail.ua", new DateTime(2023, 8, 27, 4, 51, 23, 758, DateTimeKind.Local).AddTicks(3702), "Олелько", "Марієвська", "докт. філол. наук", "5013075019", "Секретар", 18849.76m, "Metal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 3, 2, 31, 19, 313, DateTimeKind.Local).AddTicks(3217), "Староміська майдан, 1, Східний Данило, Куба", new DateTime(2014, 3, 3, 22, 36, 19, 355, DateTimeKind.Local).AddTicks(211), "Khoriv_Dovgalevskii25@gmail.com", "Горимир", "Шудрик", "докт. пед. наук", "7505893568", "Бухгалтер", 11803.90m, "infomediaries" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 25, 3, 29, 20, 710, DateTimeKind.Local).AddTicks(1771), "площа Староміська, 83, Бердянськ, Швейцарія", new DateTime(2003, 9, 6, 16, 14, 28, 618, DateTimeKind.Local).AddTicks(8006), "Okhrim_Malkovich63@gmail.com", "Софія", "Коваленко", "канд. філос. наук", "6267623146", "Прибиральник", 18726.89m, "Drive" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 10, 8, 13, 2, 646, DateTimeKind.Local).AddTicks(1002), "вулиця Молодіжна, 02, Хмельницький, Ватикан", new DateTime(1964, 7, 9, 17, 32, 1, 301, DateTimeKind.Local).AddTicks(7587), "Miroslava_Mamii@gmail.com", "Брячислав", "Горбач", "канд. пед. наук", "7063897449", "Бухгалтер", 12246.08m, "microchip" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 16, 10, 3, 41, 505, DateTimeKind.Local).AddTicks(3190), "Староміська майдан, 63, Східний Руслан, Гайана", new DateTime(1973, 7, 24, 3, 5, 39, 417, DateTimeKind.Local).AddTicks(3058), "Denis_Lomovii@meta.ua", "Христина", "Мазун", "докт. філос. наук", "8997145742", "Бухгалтер", 12085.74m, "Electronics" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 11, 18, 17, 35, 29, 736, DateTimeKind.Local).AddTicks(3848), "вул. Зелена, 293, Північний Панас, Люксембург", new DateTime(1993, 1, 21, 4, 29, 52, 738, DateTimeKind.Local).AddTicks(6536), "Adriyan_Berdnik@meta.ua", new DateTime(2022, 8, 10, 1, 0, 54, 85, DateTimeKind.Local).AddTicks(262), "Василина", "Ялюк", "проф.", "1633169006", "Директор", 12264.13m, "optical" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 29, 1, 17, 12, 716, DateTimeKind.Local).AddTicks(5319), "Зелена майдан, 4, Північний Зборислав, Португалія", new DateTime(1978, 1, 24, 22, 15, 14, 77, DateTimeKind.Local).AddTicks(4639), "Adriana_Ponomariv@ukr.net", null, "Таїсія", "Лучко", "доц.", "8834892656", "Директор", 10197.64m, "initiatives" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 7, 22, 46, 26, 785, DateTimeKind.Local).AddTicks(1260), "Городоцька майдан, 35, Умань, Туреччина", new DateTime(2001, 11, 9, 17, 34, 43, 731, DateTimeKind.Local).AddTicks(4355), "Gavrilo_Voloshuk@e-mail.ua", "Поляна", "Уманець", "канд. пед. наук", "5994716643", "Бухгалтер", 7074.77m, "Refined Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 8, 18, 41, 59, 382, DateTimeKind.Local).AddTicks(4540), "вул. Коліївщини, 7, Кременчук, Російська Федерація", new DateTime(2008, 8, 22, 17, 27, 2, 880, DateTimeKind.Local).AddTicks(6097), "Miloslava.Kulinich92@ex.ua", "Синьоок", "Луцьків", "докт. і. наук", "1591314660", 15552.43m, "Unbranded Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 7, 24, 17, 15, 23, 145, DateTimeKind.Local).AddTicks(428), "Коліївщини майдан, 056, Полтава, Науру", new DateTime(1948, 7, 25, 18, 46, 6, 216, DateTimeKind.Local).AddTicks(4596), "Lyuborada.Gaichuk96@i.ua", new DateTime(2022, 6, 19, 0, 43, 17, 866, DateTimeKind.Local).AddTicks(6605), "Олеся", "Григоришин", "канд. і. наук", "3390681874", "Директор", 3045.80m, "Seychelles Rupee" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 9, 26, 1, 18, 32, 731, DateTimeKind.Local).AddTicks(1353), "Коліївщини майдан, 573, Південний Данило, Малаві", new DateTime(1991, 10, 7, 0, 46, 43, 457, DateTimeKind.Local).AddTicks(526), "Slavuta60@ukr.net", new DateTime(2019, 6, 13, 15, 37, 22, 634, DateTimeKind.Local).AddTicks(7210), "Мирон", "Забіла", "докт. психол. наук", "8729105241", 5557.56m, "Orchestrator" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 0, 53, 169, DateTimeKind.Local).AddTicks(4751), "проспект Вічева, 72, Східний Будимир, Болгарія", new DateTime(2005, 7, 9, 15, 8, 51, 536, DateTimeKind.Local).AddTicks(2551), "Buitur.Usich85@gmail.com", new DateTime(2020, 7, 13, 13, 52, 44, 199, DateTimeKind.Local).AddTicks(9659), "Мирон", "Ногачевський", "проф.", "2627793610", "Бухгалтер", 12804.51m, "Ameliorated" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 9, 19, 12, 52, 41, 528, DateTimeKind.Local).AddTicks(7466), "пл. Коліївщини, 3, Кременчук, Габон", new DateTime(1952, 11, 14, 2, 59, 39, 240, DateTimeKind.Local).AddTicks(8155), "Pelagiya_Tarasyuk@e-mail.ua", new DateTime(2023, 7, 14, 20, 54, 35, 463, DateTimeKind.Local).AddTicks(2446), "Оріяна", "Ногачевська", "канд. філос. наук", "8711956463", 14522.73m, "task-force" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 30, 23, 3, 44, 717, DateTimeKind.Local).AddTicks(1575), "Вузька майдан, 6, Північний Любодар, Перу", new DateTime(1957, 6, 16, 23, 28, 29, 322, DateTimeKind.Local).AddTicks(9595), "Timofii.Sirko9@ukr.net", new DateTime(2022, 12, 28, 3, 40, 25, 64, DateTimeKind.Local).AddTicks(4197), "Олеся", "Бачей", "докт. психол. наук", "4047716707", 2583.55m, "Borders" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 3, 6, 12, 51, 17, 269, DateTimeKind.Local).AddTicks(2764), "вул. Зелена, 6, Західний Горимир, Сент-Люсія", new DateTime(1985, 4, 14, 8, 47, 37, 470, DateTimeKind.Local).AddTicks(7543), "Marina.Yanyuk@ukr.net", "Добромира", "Латанська", "канд. і. наук", "5797690165", "Бухгалтер", 18336.11m, "Computers" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 27, 10, 21, 12, 89, DateTimeKind.Local).AddTicks(9019), "пров. Молодіжна, 846, Чернігів, Нігерія", new DateTime(2012, 6, 26, 10, 1, 56, 645, DateTimeKind.Local).AddTicks(9177), "Anatoliya1@gmail.com", null, "Доброслав", "Пагутяк", "докт. і. наук", "0921967034", 2414.33m, "quantifying" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 11, 10, 9, 38, 932, DateTimeKind.Local).AddTicks(6919), "Староміська майдан, 911, Львів, Шрі-Ланка", new DateTime(1963, 2, 11, 4, 10, 51, 164, DateTimeKind.Local).AddTicks(4174), "Rodion26@ex.ua", new DateTime(2021, 11, 21, 12, 6, 31, 786, DateTimeKind.Local).AddTicks(2886), "Тамара", "Романишин", "докт. техн. наук", "6025011453", 18791.97m, "olive" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 7, 17, 56, 51, 431, DateTimeKind.Local).AddTicks(6943), "Нижанківського майдан, 547, Західний Стожар, Туреччина", new DateTime(1998, 12, 23, 5, 38, 34, 199, DateTimeKind.Local).AddTicks(1072), "Larisa_Stakhiv93@yandex.ua", null, "Геннадій", "Цушко", "канд. техн. наук", "6009149893", "Секретар", 14351.78m, "Sleek Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 26, 1, 12, 2, 306, DateTimeKind.Local).AddTicks(5286), "Нижанківського майдан, 879, Західний Натан, Центральноафриканська Республіка", new DateTime(1988, 2, 29, 12, 17, 1, 409, DateTimeKind.Local).AddTicks(3750), "Zhanna9@ex.ua", "Братислав", "Шиян", "докт. пед. наук", "0809706123", "Бухгалтер", 4638.60m, "Delaware" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 13, 16, 16, 37, 462, DateTimeKind.Local).AddTicks(6272), "пр. Вузька, 209, Херсон, Японія", new DateTime(1948, 1, 19, 6, 47, 21, 182, DateTimeKind.Local).AddTicks(4914), "Andrii.Kalach72@yandex.ua", null, "Олег", "Магера", "канд. юрид. наук", "2564552974", "Програміст", 16346.94m, "reboot" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 1, 19, 4, 35, 89, DateTimeKind.Local).AddTicks(1134), "Молодіжна майдан, 176, Західний Далемир, Афганістан", new DateTime(1966, 8, 30, 7, 46, 39, 68, DateTimeKind.Local).AddTicks(1289), "Denis_Shumilo@yandex.ua", null, "Христя", "Миклашевський", "канд. філос. наук", "4602001176", "Бухгалтер", 9393.63m, "Refined" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 12, 1, 12, 38, 56, 60, DateTimeKind.Local).AddTicks(4533), "Ліста майдан, 87, Івано-Франківськ, Танзанія", new DateTime(1972, 5, 20, 22, 45, 11, 615, DateTimeKind.Local).AddTicks(3166), "Marko.Sosyura@yandex.ua", null, "Олена", "Дзюб’як", "докт. і. наук", "6744132062", "Прибиральник", 9273.45m, "Sleek" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 9, 12, 6, 47, 586, DateTimeKind.Local).AddTicks(2083), "провулок Городоцька, 5, Західний Геннадій, Гондурас", new DateTime(1954, 10, 30, 1, 55, 14, 550, DateTimeKind.Local).AddTicks(2482), "Yaropolk.Osadko@ukr.net", new DateTime(2021, 2, 28, 2, 31, 5, 700, DateTimeKind.Local).AddTicks(5514), "Ликера", "Гаман", "канд. філос. наук", "2440402139", 15327.80m, "Assimilated" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 3, 8, 5, 42, 58, 72, DateTimeKind.Local).AddTicks(527), "вул. Ліста, 086, Умань, Сент-Люсія", new DateTime(1954, 5, 31, 13, 58, 36, 407, DateTimeKind.Local).AddTicks(1735), "Motrya.Semenochko@ex.ua", null, "Ликера", "Сторожук", "докт. техн. наук", "1958663206", "Бухгалтер", 8072.02m, "Burgs" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 17, 20, 55, 19, 488, DateTimeKind.Local).AddTicks(1551), "пр. Вічева, 02, Північний Тимофій, Таджикистан", new DateTime(1962, 10, 1, 3, 6, 7, 121, DateTimeKind.Local).AddTicks(459), "Pelageya.Markiv26@ex.ua", null, "Надія", "Пономарів", "докт. юрид. наук", "3381172952", "Бухгалтер", 11581.08m, "time-frame" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 28, 23, 58, 45, 489, DateTimeKind.Local).AddTicks(6727), "Брюховичів майдан, 1, Східний Мар’ян, Філіппіни", new DateTime(1978, 1, 13, 17, 20, 37, 451, DateTimeKind.Local).AddTicks(8751), "Aelayida_Andrukhovich@gmail.com", null, "Златомир", "Яворівський", "канд. філос. наук", "8683543968", 16502.59m, "programming" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 4, 4, 1, 45, 3, 364, DateTimeKind.Local).AddTicks(8274), "вул. Молодіжна, 5, Західний Архип, Ірландія", new DateTime(1961, 7, 20, 11, 32, 23, 491, DateTimeKind.Local).AddTicks(4224), "Antin_Tarasyuk@i.ua", new DateTime(2024, 2, 3, 13, 20, 17, 778, DateTimeKind.Local).AddTicks(446), "Благовіста", "Дмитришина", "докт. філол. наук", "3307228110", 19346.93m, "Industrial" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 5, 10, 46, 9, 300, DateTimeKind.Local).AddTicks(8943), "Брюховичів майдан, 4, Західний Олесь, Люксембург", new DateTime(2000, 1, 21, 9, 40, 40, 95, DateTimeKind.Local).AddTicks(8880), "Doleslava_Lyutii51@meta.ua", new DateTime(2020, 4, 3, 23, 55, 18, 708, DateTimeKind.Local).AddTicks(9677), "Ізяслав", "Гарун", "канд. техн. наук", "3830826858", "Бухгалтер", 6009.96m, "Gorgeous Fresh Soap" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 3, 4, 54, 9, 426, DateTimeKind.Local).AddTicks(4512), "Молодіжна майдан, 8, Дніпродзержинськ, Сент-Вінсент і Гренадини", new DateTime(1959, 4, 29, 5, 32, 26, 871, DateTimeKind.Local).AddTicks(6117), "Ilona_Moskalyuk71@ukr.net", null, "Богуслава", "Ланова", "докт. юрид. наук", "8987355831", "Прибиральник", 13251.83m, "feed" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 4, 28, 15, 50, 46, 731, DateTimeKind.Local).AddTicks(9406), "вулиця Коліївщини, 49, Умань, Нідерланди", new DateTime(1968, 7, 15, 3, 9, 56, 932, DateTimeKind.Local).AddTicks(6731), "Maksim.Gnatishina@gmail.com", new DateTime(2022, 10, 28, 7, 22, 14, 142, DateTimeKind.Local).AddTicks(5071), "Братослав", "Волощук", "канд. політ. наук", "6220816611", "Директор", 1436.45m, "Technician" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 7, 16, 59, 39, 62, DateTimeKind.Local).AddTicks(9492), "Молодіжна майдан, 2, Донецьк, Малайзія", new DateTime(2016, 7, 23, 22, 28, 26, 359, DateTimeKind.Local).AddTicks(8120), "Rodion_Dovgalevska14@ex.ua", new DateTime(2023, 10, 26, 22, 16, 49, 715, DateTimeKind.Local).AddTicks(7702), "Доброслав", "Плаксій", "2325796768", "Прибиральник", 15988.71m, "Practical Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 12, 26, 1, 34, 52, 842, DateTimeKind.Local).AddTicks(1226), "Городоцька майдан, 744, Житомир, Словенія", new DateTime(1950, 3, 19, 10, 56, 39, 509, DateTimeKind.Local).AddTicks(5007), "Arsen_Petik81@i.ua", null, "Аврора", "Поліщук", "канд. юрид. наук", "3263501441", "Прибиральник", 9748.76m, "info-mediaries" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 27, 21, 12, 31, 123, DateTimeKind.Local).AddTicks(3336), "Ліста майдан, 00, Хмельницький, Індія", new DateTime(1998, 12, 27, 12, 27, 4, 765, DateTimeKind.Local).AddTicks(8071), "Marko.Zabila@e-mail.ua", "Віолетта", "Стецьків", "канд. філол. наук", "5613329295", "Бухгалтер", 12681.17m, "Developer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 4, 9, 10, 7, 808, DateTimeKind.Local).AddTicks(2051), "Вузька майдан, 678, Східний Яромил, Кувейт", new DateTime(2001, 4, 10, 8, 54, 19, 487, DateTimeKind.Local).AddTicks(6473), "Zvenigor_Shumilo74@meta.ua", null, "Федора", "Балицький", "канд. і. наук", "1551402311", "Секретар", 14410.60m, "Intelligent" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 11, 0, 7, 31, 286, DateTimeKind.Local).AddTicks(7961), "Зелена майдан, 0, Південний Валерій, Бруней", new DateTime(1951, 7, 9, 3, 16, 16, 946, DateTimeKind.Local).AddTicks(3033), "Vyacheslav_Yurchishin@meta.ua", "Таїсія", "Спотикач", "канд. і. наук", "6937119342", "Прибиральник", 13892.31m, "payment" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 1, 29, 2, 52, 6, 77, DateTimeKind.Local).AddTicks(2838), "пр. Молодіжна, 11, Ялта, Венесуела", new DateTime(1945, 12, 31, 15, 35, 11, 409, DateTimeKind.Local).AddTicks(7693), "Adriana21@gmail.com", new DateTime(2019, 12, 29, 7, 49, 44, 864, DateTimeKind.Local).AddTicks(4928), "Тиміш", "Гамула", "докт. і. наук", "5032980285", "Прибиральник", 8582.82m, "Route" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 18, 11, 1, 6, 924, DateTimeKind.Local).AddTicks(562), "вулиця Коліївщини, 54, Південний Злат, Ірландія", new DateTime(1951, 3, 31, 13, 12, 38, 935, DateTimeKind.Local).AddTicks(8380), "Stanislav.Tryasun79@meta.ua", new DateTime(2021, 10, 22, 4, 18, 23, 224, DateTimeKind.Local).AddTicks(6447), "Добромила", "Сторчак", "докт. техн. наук", "4060898358", "Секретар", 6353.24m, "Nuevo Sol" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 22, 10, 13, 39, 558, DateTimeKind.Local).AddTicks(6410), "вул. Городоцька, 687, Північний Тарас, Гамбія", new DateTime(1981, 3, 27, 14, 11, 36, 582, DateTimeKind.Local).AddTicks(3570), "Podolyan_Romenec@i.ua", new DateTime(2022, 3, 13, 8, 44, 35, 893, DateTimeKind.Local).AddTicks(5866), "Лук’ян", "Бабух", "докт. політ. наук", "1398393761", "Бухгалтер", 1503.45m, "Soft" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 4, 6, 8, 21, 28, 353, DateTimeKind.Local).AddTicks(3066), "площа Стрийська, 478, Західний Валентин, Свазіленд", new DateTime(2017, 9, 21, 12, 10, 12, 919, DateTimeKind.Local).AddTicks(1003), "Zvenigor16@yandex.ua", new DateTime(2024, 4, 4, 9, 33, 56, 554, DateTimeKind.Local).AddTicks(6808), "Білослав", "Гриневська", "докт. юрид. наук", "3729846590", "Секретар", 15877.27m, "Codes specifically reserved for testing purposes" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 18, 16, 34, 38, 624, DateTimeKind.Local).AddTicks(9779), "Коліївщини майдан, 18, Східний Максим, Уганда", new DateTime(1987, 12, 25, 0, 5, 22, 511, DateTimeKind.Local).AddTicks(9255), "Fayina.Kompaniyec43@i.ua", new DateTime(2022, 6, 25, 8, 34, 50, 762, DateTimeKind.Local).AddTicks(9037), "Ярополк", "Ромей", "докт. політ. наук", "0283196549", "Програміст", 11767.61m, "Optimized" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 16, 2, 42, 44, 592, DateTimeKind.Local).AddTicks(3537), "пров. Винників, 85, Мукачеве, Саудівська Аравія", new DateTime(1964, 5, 24, 8, 22, 23, 909, DateTimeKind.Local).AddTicks(2964), "Stozhar.Lugova@ukr.net", new DateTime(2022, 11, 1, 18, 46, 31, 45, DateTimeKind.Local).AddTicks(5344), "Тарас", "Роменець", "канд. філол. наук", "2833471590", "Програміст", 18693.56m, "West Virginia" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 9, 13, 45, 48, 973, DateTimeKind.Local).AddTicks(5328), "пл. Вічева, 36, Слов’янськ, Естонія", new DateTime(1965, 2, 28, 10, 18, 22, 304, DateTimeKind.Local).AddTicks(4148), "Rostislav.Balaban@ex.ua", null, "Ганна", "Махно", "доц.", "8812279690", "Директор", 17251.46m, "radical" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 5, 14, 9, 41, 42, 665, DateTimeKind.Local).AddTicks(1308), "Брюховичів майдан, 721, Суми, Соломонові Острови", new DateTime(1990, 3, 30, 8, 20, 14, 581, DateTimeKind.Local).AddTicks(5852), "Ada55@ex.ua", "Градимир", "Майстренко", "докт. психол. наук", "8628224687", 12259.36m, "withdrawal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 5, 13, 19, 58, 21, 829, DateTimeKind.Local).AddTicks(9166), "Ліста майдан, 2, Хмельницький, Китай", new DateTime(1979, 8, 8, 9, 51, 38, 950, DateTimeKind.Local).AddTicks(2828), "Anastasii_Pritula31@meta.ua", "Боримир", "Марків", "проф.", "7940811947", "Директор", 2826.66m, "Square" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 17, 21, 368, DateTimeKind.Local).AddTicks(9543), "Городоцька майдан, 3, Макіївка, Бруней", new DateTime(1975, 2, 10, 16, 5, 16, 399, DateTimeKind.Local).AddTicks(387), "Zinayida_Petrina16@ex.ua", new DateTime(2020, 4, 11, 13, 7, 26, 176, DateTimeKind.Local).AddTicks(8192), "Інна", "Лахман", "докт. і. наук", "6043314594", 13869.50m, "Tools" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 22, 52, 997, DateTimeKind.Local).AddTicks(7040), "Нижанківського майдан, 5, Західний Михайло, Гватемала", new DateTime(2016, 1, 8, 10, 40, 50, 347, DateTimeKind.Local).AddTicks(4264), "Dana_Luchko@ukr.net", new DateTime(2020, 12, 27, 4, 37, 23, 625, DateTimeKind.Local).AddTicks(7313), "Листвич", "Галаєнко", "докт. і. наук", "1440649093", "Бухгалтер", 2796.18m, "vertical" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 26, 4, 46, 2, 967, DateTimeKind.Local).AddTicks(8569), "Молодіжна майдан, 89, Кам’янець-Подільський, Італія", new DateTime(1988, 5, 13, 6, 13, 29, 388, DateTimeKind.Local).AddTicks(6416), "Ratimir21@e-mail.ua", new DateTime(2022, 12, 10, 8, 59, 33, 201, DateTimeKind.Local).AddTicks(5565), "Олеся", "Ящук", "докт. психол. наук", "9089558838", "Секретар", 14609.91m, "quantify" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 15, 8, 5, 6, 758, DateTimeKind.Local).AddTicks(7663), "площа Рудного, 073, Нікополь, Тонга", new DateTime(1986, 8, 20, 0, 46, 44, 499, DateTimeKind.Local).AddTicks(8322), "Nestor.Bondarenko@i.ua", new DateTime(2023, 7, 11, 12, 5, 30, 984, DateTimeKind.Local).AddTicks(6994), "Листвич", "Коров’як", "канд. техн. наук", "0196553129", "Секретар", 13104.82m, "Personal Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 8, 21, 20, 48, 24, 678, DateTimeKind.Local).AddTicks(5221), "пр. Коліївщини, 1, Запоріжжя, Аргентина", new DateTime(1949, 3, 18, 0, 43, 51, 323, DateTimeKind.Local).AddTicks(7413), "Anfisa.Skoropadskii@ukr.net", new DateTime(2022, 4, 14, 18, 45, 1, 233, DateTimeKind.Local).AddTicks(8384), "Остап", "Зварич", "докт. і. наук", "5233679927", "Секретар", 13151.44m, "Small Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 3, 8, 8, 59, 48, 466, DateTimeKind.Local).AddTicks(4118), "Нижанківського майдан, 080, Західний Брячислав, Вануату", new DateTime(1963, 11, 4, 8, 25, 12, 549, DateTimeKind.Local).AddTicks(7042), "Orislava.Parashuk27@gmail.com", new DateTime(2020, 6, 2, 5, 55, 4, 405, DateTimeKind.Local).AddTicks(3263), "Ярема", "Єрмак", "докт. психол. наук", "6283653203", 7062.09m, "bandwidth-monitored" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 3, 18, 0, 22, 24, 541, DateTimeKind.Local).AddTicks(8054), "Стрийська майдан, 5, Південний Славута, Камерун", new DateTime(1945, 7, 27, 23, 14, 23, 891, DateTimeKind.Local).AddTicks(8251), "Anatoliya.Romanishina43@e-mail.ua", new DateTime(2022, 2, 21, 0, 21, 17, 699, DateTimeKind.Local).AddTicks(1934), "Лад", "Шестак", "канд. психол. наук", "1577875468", "Секретар", 18334.40m, "Kids" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 18, 3, 6, 21, 39, DateTimeKind.Local).AddTicks(2568), "вулиця Староміська, 39, Чернігів, Джибуті", new DateTime(1965, 7, 28, 18, 37, 42, 653, DateTimeKind.Local).AddTicks(5486), "Yaromil31@meta.ua", "Мечислав", "Плаксій", "канд. техн. наук", "5239854357", "Програміст", 12664.85m, "compress" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 4, 15, 14, 5, 14, 249, DateTimeKind.Local).AddTicks(8447), "вул. Молодіжна, 0, Хмельницький, Італія", new DateTime(2001, 9, 10, 11, 0, 46, 621, DateTimeKind.Local).AddTicks(2378), "Romena_Boyarchuk93@ukr.net", new DateTime(2021, 10, 20, 9, 21, 41, 252, DateTimeKind.Local).AddTicks(5569), "Білослав", "Стоян", "канд. філос. наук", "2011580492", 6779.06m, "Future" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 22, 14, 9, 6, 237, DateTimeKind.Local).AddTicks(5503), "Винників майдан, 0, Мукачеве, Перу", new DateTime(2012, 5, 30, 15, 18, 6, 818, DateTimeKind.Local).AddTicks(4450), "Borimisl.Fedorishina@e-mail.ua", "Андрій", "Романишин", "докт. і. наук", "7350686654", "Прибиральник", 4703.10m, "Extended" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 8, 4, 10, 23, 6, 378, DateTimeKind.Local).AddTicks(9477), "вул. Староміська, 1, Західний Тихон, Коста-Рика", new DateTime(2004, 4, 1, 15, 39, 23, 668, DateTimeKind.Local).AddTicks(129), "Zlatomir_Yermak@i.ua", new DateTime(2019, 5, 12, 13, 32, 5, 348, DateTimeKind.Local).AddTicks(1215), "Анна", "Негода", "докт. юрид. наук", "2212238368", "Прибиральник", 3344.18m, "Pula" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 16, 13, 31, 50, 567, DateTimeKind.Local).AddTicks(8799), "Стрийська майдан, 150, Тернопіль, Гвінея", new DateTime(2008, 12, 30, 17, 4, 29, 223, DateTimeKind.Local).AddTicks(8389), "Darislava.Cushko80@meta.ua", "Варвара", "Шамрило", "канд. політ. наук", "0879425199", "Директор", 10733.45m, "generating" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 3, 7, 14, 38, 46, 510, DateTimeKind.Local).AddTicks(9275), "пров. Рудного, 009, Західний Роман, Лесото", new DateTime(1945, 6, 17, 21, 36, 23, 342, DateTimeKind.Local).AddTicks(1089), "Danilo6@meta.ua", new DateTime(2021, 4, 7, 21, 0, 15, 14, DateTimeKind.Local).AddTicks(1803), "Святополк", "Корнїйчук", "канд. філол. наук", "0097270095", 6387.65m, "Concrete" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 9, 24, 10, 41, 58, 811, DateTimeKind.Local).AddTicks(4201), "Зелена майдан, 0, Західний Азарій, Соломонові Острови", new DateTime(2003, 1, 27, 18, 26, 29, 138, DateTimeKind.Local).AddTicks(2667), "Varvara.Kovalskii16@yandex.ua", new DateTime(2020, 12, 31, 0, 45, 23, 542, DateTimeKind.Local).AddTicks(7145), "Олег", "Майборода", "проф.", "7402727947", "Прибиральник", 3645.61m, "Manager" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 1, 21, 15, 39, 978, DateTimeKind.Local).AddTicks(6119), "пл. Вузька, 33, Рівне, Філіппіни", new DateTime(1955, 6, 7, 12, 26, 54, 207, DateTimeKind.Local).AddTicks(8929), "Vlada.Porivai67@i.ua", new DateTime(2021, 4, 3, 3, 58, 58, 373, DateTimeKind.Local).AddTicks(2611), "Анастасій", "Юхно", "канд. філос. наук", "1020819166", 12768.15m, "capacitor" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 3, 15, 39, 44, 800, DateTimeKind.Local).AddTicks(252), "Молодіжна майдан, 06, Північний Михайло, Словаччина", new DateTime(1950, 11, 14, 5, 3, 8, 672, DateTimeKind.Local).AddTicks(2380), "Volodislav.Gnatishin34@ukr.net", new DateTime(2023, 10, 3, 5, 21, 7, 584, DateTimeKind.Local).AddTicks(4054), "Ростислава", "Ромочко", "9618618001", 3577.15m, "quantify" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 3, 22, 21, 46, 5, 850, DateTimeKind.Local).AddTicks(8299), "пров. Вузька, 472, Східний Костянтин, Кабо-Верде", new DateTime(1968, 8, 5, 17, 30, 9, 57, DateTimeKind.Local).AddTicks(5106), "Artem_Tretyak@ukr.net", new DateTime(2019, 11, 18, 0, 18, 40, 582, DateTimeKind.Local).AddTicks(961), "Захарій", "Горбач", "проф.", "4434413686", "Бухгалтер", 14567.72m, "Industrial, Toys & Movies" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 16, 4, 6, 2, 60, DateTimeKind.Local).AddTicks(1638), "Коліївщини майдан, 6, Західний Семибор, Перу", new DateTime(1968, 12, 5, 22, 6, 38, 54, DateTimeKind.Local).AddTicks(2652), "Bratimir.Kivach@ukr.net", new DateTime(2023, 5, 17, 7, 30, 22, 567, DateTimeKind.Local).AddTicks(6764), "Валентин", "Стигайло", "докт. політ. наук", "2802160981", "Бухгалтер", 7194.43m, "strategize" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 8, 2, 0, 13, 24, 410, DateTimeKind.Local).AddTicks(1511), "Брюховичів майдан, 01, Суми, Демократична Республіка Конго", new DateTime(1950, 11, 7, 16, 45, 28, 173, DateTimeKind.Local).AddTicks(3345), "Chornota58@ex.ua", new DateTime(2023, 8, 5, 22, 34, 11, 438, DateTimeKind.Local).AddTicks(9023), "Корній", "Марієвська", "канд. філол. наук", "8088905370", "Прибиральник", 6521.97m, "iterate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 22, 20, 4, 0, 697, DateTimeKind.Local).AddTicks(7215), "вулиця Стрийська, 7, Кіровоград, Бахрейн", new DateTime(2018, 9, 12, 2, 47, 55, 977, DateTimeKind.Local).AddTicks(7685), "Ognyana.Tretyak28@gmail.com", new DateTime(2023, 7, 12, 19, 4, 8, 188, DateTimeKind.Local).AddTicks(5902), "Земислав", "Поліщук", "докт. і. наук", "8239385428", 1982.14m, "Synergistic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 26, 19, 44, 43, 316, DateTimeKind.Local).AddTicks(2907), "Коліївщини майдан, 4, Західний Боримисл, Ліхтенштейн", new DateTime(1999, 3, 27, 3, 10, 25, 402, DateTimeKind.Local).AddTicks(9940), "Yeremii.Dmitrishin@i.ua", null, "Агата", "Скоропадський", "проф.", "6725440611", "Бухгалтер", 5374.98m, "Administrator" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 6, 1, 42, 29, 845, DateTimeKind.Local).AddTicks(267), "Молодіжна майдан, 533, Краматорськ, Замбія", new DateTime(1982, 6, 3, 2, 32, 17, 943, DateTimeKind.Local).AddTicks(4111), "Zvenigor16@i.ua", null, "Мстислава", "Гордійчук", "канд. і. наук", "7311200786", "Директор", 19258.80m, "Assurance" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 3, 23, 23, 50, 14, 860, DateTimeKind.Local).AddTicks(7608), "пр. Коліївщини, 596, Сімферополь, Гватемала", new DateTime(1962, 12, 6, 3, 9, 34, 424, DateTimeKind.Local).AddTicks(1034), "Dobrinka_Ponomariv99@gmail.com", new DateTime(2020, 4, 28, 22, 28, 40, 502, DateTimeKind.Local).AddTicks(5196), "Тамара", "Корецька", "канд. психол. наук", "8251620372", "Програміст", 17942.60m, "Shoal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 12, 4, 20, 6, 47, 993, DateTimeKind.Local).AddTicks(8223), "Брюховичів майдан, 44, Миколаїв, Україна", new DateTime(1975, 3, 28, 8, 7, 2, 449, DateTimeKind.Local).AddTicks(7608), "Blagovista86@ex.ua", "Олексій", "Цимбалістий", "канд. і. наук", "7757416105", "Прибиральник", 10787.10m, "Vista" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 28, 3, 52, 32, 492, DateTimeKind.Local).AddTicks(1131), "Зелена майдан, 476, Херсон, Соломонові Острови", new DateTime(1975, 8, 10, 10, 53, 48, 362, DateTimeKind.Local).AddTicks(8273), "Ruslan_Marinich@ukr.net", new DateTime(2022, 7, 22, 10, 28, 2, 291, DateTimeKind.Local).AddTicks(606), "Петро", "Юхно", "проф.", "3490192402", 6052.91m, "India" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 11, 12, 18, 16, 3, 544, DateTimeKind.Local).AddTicks(8316), "Коліївщини майдан, 7, Північний Микита, Руанда", new DateTime(1968, 6, 26, 23, 7, 53, 328, DateTimeKind.Local).AddTicks(7335), "Anzhela.Balickii0@meta.ua", null, "Ілля", "Борочко", "канд. і. наук", "9423566457", "Секретар", 11084.32m, "Massachusetts" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 5, 11, 6, 8, 20, 85, DateTimeKind.Local).AddTicks(3363), "проспект Нижанківського, 1, Східний Роксолан, Сан-Томе і Принсіпі", new DateTime(1986, 4, 13, 19, 32, 34, 171, DateTimeKind.Local).AddTicks(4281), "Stozhar_Grineveckii22@yandex.ua", new DateTime(2022, 4, 28, 16, 24, 22, 303, DateTimeKind.Local).AddTicks(8803), "Устим", "Приймак", "докт. політ. наук", "0000807845", "Директор", 15815.88m, "Gorgeous" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 4, 22, 17, 52, 33, 391, DateTimeKind.Local).AddTicks(5361), "вулиця Нижанківського, 860, Північний Віктор, Боснія і Герцеговина", new DateTime(2004, 1, 20, 18, 47, 3, 178, DateTimeKind.Local).AddTicks(69), "Antin.Mazun86@e-mail.ua", new DateTime(2024, 3, 18, 2, 5, 52, 702, DateTimeKind.Local).AddTicks(3227), "Жанна", "Ломовий", "канд. психол. наук", "1392831452", "Прибиральник", 13060.72m, "national" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 7, 21, 17, 45, 31, 862, DateTimeKind.Local).AddTicks(9316), "вулиця Молодіжна, 0, Сімферополь, Домініка", new DateTime(2012, 10, 24, 12, 20, 47, 604, DateTimeKind.Local).AddTicks(4073), "Avgustin_Kordun@meta.ua", new DateTime(2021, 8, 24, 19, 18, 10, 352, DateTimeKind.Local).AddTicks(7370), "Власта", "Негода", "докт. філос. наук", "2288217635", "Бухгалтер", 5239.96m, "Berkshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 30, 9, 40, 42, 487, DateTimeKind.Local).AddTicks(7960), "вулиця Молодіжна, 0, Тернопіль, Камбоджа", new DateTime(2022, 4, 1, 1, 10, 48, 159, DateTimeKind.Local).AddTicks(1727), "Agapiya81@e-mail.ua", null, "Юхимія", "Тарасюк", "докт. юрид. наук", "3686937647", "Бухгалтер", 15532.51m, "deposit" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 11, 15, 24, 50, 47, DateTimeKind.Local).AddTicks(4071), "Ліста майдан, 9, Житомир, В’єтнам", new DateTime(1961, 3, 14, 11, 56, 17, 691, DateTimeKind.Local).AddTicks(392), "Miroslav_Umanec21@meta.ua", new DateTime(2021, 11, 23, 0, 14, 11, 757, DateTimeKind.Local).AddTicks(2415), "Славолюб", "Ногачевська", "докт. політ. наук", "5335488226", "Прибиральник", 10793.95m, "Burundi Franc" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 19, 14, 15, 10, 681, DateTimeKind.Local).AddTicks(3930), "Стрийська майдан, 984, Південний Златомир, Судан", new DateTime(1947, 12, 1, 15, 58, 16, 684, DateTimeKind.Local).AddTicks(4735), "Polina.Ganich@ukr.net", new DateTime(2019, 6, 20, 18, 13, 21, 304, DateTimeKind.Local).AddTicks(3425), "Люборада", "Бабух", "докт. юрид. наук", "7587695332", 1429.88m, "Savings Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 9, 11, 56, 27, 521, DateTimeKind.Local).AddTicks(2577), "проспект Стрийська, 6, Південний Хвалимир, Узбекистан", new DateTime(1969, 8, 11, 11, 49, 37, 734, DateTimeKind.Local).AddTicks(2866), "Maksim_Tryasun10@meta.ua", new DateTime(2023, 11, 29, 21, 45, 50, 626, DateTimeKind.Local).AddTicks(7613), "Любомира", "Тарасюк", "канд. політ. наук", "1647156862", "Директор", 16202.65m, "Louisiana" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 5, 15, 2, 1, 56, 526, DateTimeKind.Local).AddTicks(6203), "пл. Ліста, 1, Західний Гордій, Італія", new DateTime(2009, 7, 11, 17, 56, 32, 380, DateTimeKind.Local).AddTicks(7105), "Viola_Tkachenko25@e-mail.ua", "Ярослав", "Мазун", "докт. філол. наук", "1769915893", "Бухгалтер", 12480.22m, "Berkshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 8, 2, 1, 57, 51, 47, DateTimeKind.Local).AddTicks(839), "вул. Ліста, 0, Мукачеве, Сальвадор", new DateTime(1981, 7, 28, 0, 21, 34, 182, DateTimeKind.Local).AddTicks(6389), "Omelyan.Likhno31@i.ua", new DateTime(2019, 6, 14, 6, 33, 17, 483, DateTimeKind.Local).AddTicks(3172), "Любослава", "Гарун", "докт. психол. наук", "3743785080", "Прибиральник", 6638.46m, "sensor" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 8, 19, 40, 29, 583, DateTimeKind.Local).AddTicks(4103), "Рудного майдан, 2, Східний Богдан, Таїланд", new DateTime(1982, 1, 13, 21, 0, 1, 205, DateTimeKind.Local).AddTicks(8411), "Petro18@e-mail.ua", null, "Валентин", "Поривайло", "докт. політ. наук", "8066609275", "Програміст", 14719.05m, "superstructure" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 7, 30, 20, 35, 24, 243, DateTimeKind.Local).AddTicks(8640), "проспект Зелена, 4, Південний Антон, Кабо-Верде", new DateTime(2002, 10, 16, 8, 19, 12, 556, DateTimeKind.Local).AddTicks(912), "Melaniya.Kocyubinskii85@ex.ua", new DateTime(2019, 10, 6, 6, 17, 54, 944, DateTimeKind.Local).AddTicks(2102), "Оріяна", "Левадовський", "доц.", "5045702227", "Секретар", 16668.71m, "Strategist" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 29, 9, 16, 37, 870, DateTimeKind.Local).AddTicks(5753), "проспект Брюховичів, 336, Східний Антон, Південна Корея", new DateTime(1952, 2, 8, 22, 42, 27, 102, DateTimeKind.Local).AddTicks(4920), "Kupava83@i.ua", new DateTime(2021, 11, 26, 4, 25, 36, 571, DateTimeKind.Local).AddTicks(7310), "Руслан", "Петик", "9489515709", "Секретар", 1529.67m, "Place" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 30, 15, 38, 17, 77, DateTimeKind.Local).AddTicks(7043), "Молодіжна майдан, 474, Південний Родіон, Домініканська Республіка", new DateTime(1983, 12, 5, 4, 7, 10, 821, DateTimeKind.Local).AddTicks(6368), "Zorina_Tryasun60@ukr.net", new DateTime(2023, 8, 15, 16, 11, 22, 288, DateTimeKind.Local).AddTicks(9422), "Микита", "Унич", "канд. техн. наук", "5272636316", "Директор", 6092.10m, "Automotive, Beauty & Movies" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 19, 17, 13, 44, 807, DateTimeKind.Local).AddTicks(2951), "Коліївщини майдан, 714, Слов’янськ, Саудівська Аравія", new DateTime(1966, 10, 6, 15, 9, 11, 736, DateTimeKind.Local).AddTicks(2583), "Oresta_Andrukhovich@ukr.net", "Зоя", "Бондаренко", "докт. політ. наук", "9244333629", "Секретар", 8221.40m, "time-frame" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 31, 18, 42, 43, 478, DateTimeKind.Local).AddTicks(3594), "Зелена майдан, 52, Східний Лаврін, Нігер", new DateTime(1994, 5, 19, 9, 34, 25, 101, DateTimeKind.Local).AddTicks(8557), "Ostap_Borochko@gmail.com", "Зборислав", "Бандера", "докт. юрид. наук", "0849516185", "Програміст", 19963.20m, "synthesizing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 3, 2, 14, 1, 40, 376, DateTimeKind.Local).AddTicks(2361), "Ліста майдан, 31, Кременчук, Коста-Рика", new DateTime(2020, 12, 31, 23, 32, 57, 430, DateTimeKind.Local).AddTicks(2707), "Ivan_Grigorishina@gmail.com", new DateTime(2022, 3, 30, 2, 43, 51, 819, DateTimeKind.Local).AddTicks(8956), "Олексій", "Гордійчук", "5138895892", "Програміст", 14608.01m, "alarm" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 27, 11, 27, 12, 398, DateTimeKind.Local).AddTicks(9339), "вул. Рудного, 238, Євпаторія, Сан-Томе і Принсіпі", new DateTime(1958, 4, 28, 18, 40, 6, 733, DateTimeKind.Local).AddTicks(2963), "Oresta.Latanskii85@gmail.com", "Корнилій", "Савицький", "канд. політ. наук", "0213736047", "Прибиральник", 3083.58m, "Public-key" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 5, 28, 21, 38, 30, 331, DateTimeKind.Local).AddTicks(7980), "пр. Зелена, 388, Північний Всевлад, Монголія", new DateTime(1970, 5, 21, 17, 6, 10, 334, DateTimeKind.Local).AddTicks(4862), "Bratimir8@gmail.com", "Віолетта", "Кивач", "канд. політ. наук", "2271884557", "Директор", 5006.42m, "gold" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 2, 12, 58, 6, 446, DateTimeKind.Local).AddTicks(6828), "Брюховичів майдан, 81, Південний Анатолій, Естонія", new DateTime(1998, 6, 4, 14, 40, 57, 995, DateTimeKind.Local).AddTicks(7871), "Daleslava.Andrukhovich5@yandex.ua", new DateTime(2020, 6, 5, 12, 52, 3, 949, DateTimeKind.Local).AddTicks(6514), "Агапія", "Карпух", "канд. філос. наук", "5525113332", 16449.48m, "Practical Soft Ball" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 12, 1, 0, 59, 53, 925, DateTimeKind.Local).AddTicks(7985), "Вічева майдан, 06, Бердянськ, Узбекистан", new DateTime(1970, 1, 7, 4, 23, 0, 934, DateTimeKind.Local).AddTicks(199), "Snizhana1@ukr.net", "Земислав", "докт. пед. наук", "5381075201", "Програміст", 9701.41m, "aggregate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 8, 0, 3, 26, 208, DateTimeKind.Local).AddTicks(6564), "пр. Рудного, 180, Східний Юрій, Естонія", new DateTime(2007, 4, 17, 21, 2, 13, 556, DateTimeKind.Local).AddTicks(9936), "Marko58@ex.ua", null, "Олелько", "Пономарів", "докт. юрид. наук", "6061900904", "Прибиральник", 16402.18m, "Fantastic Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 13, 6, 7, 2, 973, DateTimeKind.Local).AddTicks(1867), "Нижанківського майдан, 15, Східний Братослав, Мадаґаскар", new DateTime(1953, 6, 18, 16, 31, 22, 538, DateTimeKind.Local).AddTicks(4785), "Fevroniya13@e-mail.ua", new DateTime(2021, 8, 25, 4, 5, 55, 652, DateTimeKind.Local).AddTicks(6185), "Антоній", "Трясун", "докт. пед. наук", "4832098068", "Програміст", 1836.87m, "Via" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 22, 1, 8, 54, 14, DateTimeKind.Local).AddTicks(198), "Староміська майдан, 9, Західний Зиновій, Швеція", new DateTime(1995, 2, 21, 10, 35, 11, 747, DateTimeKind.Local).AddTicks(3827), "Marko23@i.ua", new DateTime(2022, 9, 7, 2, 8, 35, 948, DateTimeKind.Local).AddTicks(8753), "Тарас", "Вередун", "канд. філос. наук", "3873906999", "Директор", 2583.67m, "overriding" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 21, 5, 19, 42, 337, DateTimeKind.Local).AddTicks(3113), "вулиця Молодіжна, 82, Південний Щастислав, Гайана", new DateTime(1952, 6, 17, 10, 26, 44, 365, DateTimeKind.Local).AddTicks(8249), "Kostyantin.Steckiv@yandex.ua", new DateTime(2022, 10, 2, 11, 58, 0, 471, DateTimeKind.Local).AddTicks(5664), "Білослава", "Павлишин", "докт. пед. наук", "9398145018", "Бухгалтер", 13220.94m, "generate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 21, 4, 24, 17, 129, DateTimeKind.Local).AddTicks(8802), "пр. Стрийська, 47, Північний Немир, Фінляндія", new DateTime(1974, 3, 29, 16, 33, 11, 104, DateTimeKind.Local).AddTicks(9449), "Vasilina78@yandex.ua", "Ян", "Сплюха", "докт. пед. наук", "0927110198", "Секретар", 4325.77m, "Handcrafted Plastic Sausages" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 9, 19, 21, 33, 21, 755, DateTimeKind.Local).AddTicks(3789), "проспект Нижанківського, 43, Єнакієве, Екваторіальна Гвінея", new DateTime(2005, 8, 18, 1, 55, 54, 704, DateTimeKind.Local).AddTicks(2571), "Olelko_Gladukh@e-mail.ua", "Тихон", "Лобачевська", "канд. і. наук", "6016202060", "Програміст", 17859.03m, "Enhanced" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 8, 17, 12, 25, 166, DateTimeKind.Local).AddTicks(3177), "Зелена майдан, 5, Миколаїв, Уганда", new DateTime(1945, 7, 15, 9, 54, 12, 536, DateTimeKind.Local).AddTicks(5128), "Khvalimir39@e-mail.ua", null, "Людомила", "Шиндарей", "канд. психол. наук", "0470234465", "Бухгалтер", 12407.17m, "Cambridgeshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 3, 13, 10, 42, 25, 188, DateTimeKind.Local).AddTicks(7090), "пр. Винників, 471, Макіївка, Індонезія", new DateTime(1965, 8, 14, 16, 21, 44, 438, DateTimeKind.Local).AddTicks(4945), "Vlasta_Kulinich@i.ua", "Божен", "Прядун", "докт. техн. наук", "1466306158", "Директор", 19983.24m, "auxiliary" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 11, 10, 57, 36, 318, DateTimeKind.Local).AddTicks(9611), "пл. Городоцька, 25, Кременчук, Катар", new DateTime(1963, 5, 7, 21, 26, 17, 368, DateTimeKind.Local).AddTicks(7369), "Agripina98@meta.ua", new DateTime(2020, 11, 17, 12, 50, 28, 882, DateTimeKind.Local).AddTicks(3053), "Анфіса", "Трясило", "канд. техн. наук", "9607235564", "Директор", 19044.99m, "cross-media" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 12, 28, 10, 55, 12, 435, DateTimeKind.Local).AddTicks(4805), "Коліївщини майдан, 814, Черкаси, Болівія", new DateTime(1955, 9, 30, 15, 56, 27, 522, DateTimeKind.Local).AddTicks(3888), "Viola68@gmail.com", "Наталія", "Гаман", "канд. і. наук", "2735269903", 1684.46m, "Intelligent Steel Pants" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 12, 10, 21, 30, 866, DateTimeKind.Local).AddTicks(9001), "площа Нижанківського, 871, Західний Вадим, Північна Корея", new DateTime(1961, 7, 24, 12, 50, 40, 186, DateTimeKind.Local).AddTicks(1838), "Musii40@yandex.ua", "Яна", "Романишина", "докт. політ. наук", "8452483868", "Секретар", 12987.75m, "Intelligent" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 22, 8, 30, 53, 521, DateTimeKind.Local).AddTicks(6892), "Брюховичів майдан, 01, Слов’янськ, Конго", new DateTime(2008, 10, 3, 15, 11, 40, 568, DateTimeKind.Local).AddTicks(6336), "Alevtin60@gmail.com", "Болеслава", "Гладух", "докт. психол. наук", "8668638898", "Директор", 6862.02m, "Operations" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 28, 6, 4, 31, 729, DateTimeKind.Local).AddTicks(3164), "пров. Ліста, 67, Східний Остап, Ліван", new DateTime(2015, 10, 6, 5, 27, 39, 248, DateTimeKind.Local).AddTicks(3383), "Fevroniya_Usich42@e-mail.ua", null, "Добромисл", "Гаман", "докт. техн. наук", "7383478973", 9123.45m, "Cambridgeshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 28, 14, 12, 10, 496, DateTimeKind.Local).AddTicks(2881), "Брюховичів майдан, 07, Східний Кий, Гайана", new DateTime(1987, 1, 3, 8, 24, 2, 972, DateTimeKind.Local).AddTicks(7923), "Rostislav_Mikhailyuk@gmail.com", null, "Василь", "Дзюб’як", "канд. політ. наук", "9666068041", "Бухгалтер", 11116.63m, "Baby, Kids & Games" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 22, 22, 18, 58, 461, DateTimeKind.Local).AddTicks(6821), "Вічева майдан, 1, Єнакієве, Сербія", new DateTime(2020, 7, 16, 6, 53, 38, 654, DateTimeKind.Local).AddTicks(1474), "Anatolii_Borochko@i.ua", new DateTime(2020, 10, 29, 14, 28, 15, 361, DateTimeKind.Local).AddTicks(1578), "Гліб", "Ганич", "докт. філос. наук", "1395679507", 13832.78m, "Agent" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 12, 29, 23, 44, 50, 987, DateTimeKind.Local).AddTicks(2885), "площа Ліста, 20, Херсон, Швеція", new DateTime(2022, 5, 20, 21, 10, 42, 151, DateTimeKind.Local).AddTicks(4460), "Maiya20@meta.ua", null, "Олесь", "Зварич", "доц.", "8021606915", 10775.63m, "1080p" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 28, 6, 39, 8, 342, DateTimeKind.Local).AddTicks(250), "пров. Винників, 52, Луганськ, Малі", new DateTime(2009, 1, 14, 5, 43, 1, 650, DateTimeKind.Local).AddTicks(6370), "Levko.Motriyenko@ukr.net", new DateTime(2019, 12, 6, 21, 35, 27, 728, DateTimeKind.Local).AddTicks(8826), "Добринка", "Гордійчук", "канд. юрид. наук", "6850573890", "Програміст", 19160.78m, "Personal Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 9, 19, 11, 37, 5, 413, DateTimeKind.Local).AddTicks(8748), "провулок Винників, 8, Красний Луч, Словенія", new DateTime(1967, 2, 19, 6, 10, 42, 931, DateTimeKind.Local).AddTicks(6674), "Okhrim.Danilishin60@meta.ua", new DateTime(2022, 6, 13, 5, 56, 11, 705, DateTimeKind.Local).AddTicks(6699), "Добромисл", "Кульчицька", "канд. філос. наук", "3224571930", "Директор", 14063.94m, "deposit" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 2, 17, 44, 32, 108, DateTimeKind.Local).AddTicks(9793), "пл. Стрийська, 2, Західний Всеволод, Федеративні Штати Мікронезії", new DateTime(1988, 6, 13, 4, 58, 21, 58, DateTimeKind.Local).AddTicks(8192), "Vsevolod.Palii58@i.ua", "Ладо", "Білич", "докт. і. наук", "4037198015", "Директор", 17413.25m, "Borders" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 11, 18, 3, 58, 54, 862, DateTimeKind.Local).AddTicks(5949), "вул. Молодіжна, 9, Західний Братимир, Норвегія", new DateTime(1959, 7, 2, 0, 13, 38, 644, DateTimeKind.Local).AddTicks(4427), "Miloslava67@e-mail.ua", new DateTime(2020, 11, 26, 22, 56, 38, 963, DateTimeKind.Local).AddTicks(9532), "Земислав", "Демків", "докт. філос. наук", "5306035804", "Бухгалтер", 11950.09m, "Kyat" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 51, 16, 118, DateTimeKind.Local).AddTicks(3909), "пр. Зелена, 64, Північний Петро, Румунія", new DateTime(1998, 7, 12, 19, 51, 4, 737, DateTimeKind.Local).AddTicks(8251), "Tetyana66@e-mail.ua", null, "Оксана", "Лученко", "канд. техн. наук", "0285392990", "Програміст", 6110.20m, "Delaware" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 17, 10, 5, 18, 815, DateTimeKind.Local).AddTicks(3334), "Зелена майдан, 1, Мукачеве, Японія", new DateTime(1966, 10, 30, 19, 9, 39, 886, DateTimeKind.Local).AddTicks(7364), "Bratomil.Shiyan91@meta.ua", new DateTime(2022, 3, 10, 17, 56, 47, 92, DateTimeKind.Local).AddTicks(8114), "Ян", "Ющук", "канд. філол. наук", "0615615401", "Бухгалтер", 18080.23m, "Tasty" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 13, 22, 16, 15, 834, DateTimeKind.Local).AddTicks(2231), "Брюховичів майдан, 696, Керч, Канада", new DateTime(1978, 9, 29, 8, 42, 18, 856, DateTimeKind.Local).AddTicks(9899), "Albina27@gmail.com", "Устина", "Дзюба", "докт. філол. наук", "3844110040", "Секретар", 15259.42m, "calculating" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 18, 18, 44, 52, 220, DateTimeKind.Local).AddTicks(4869), "пров. Ліста, 4, Житомир, Ізраїль", new DateTime(1975, 9, 4, 10, 12, 16, 819, DateTimeKind.Local).AddTicks(3127), "Roksolan.Kordun70@ukr.net", new DateTime(2022, 11, 2, 22, 0, 32, 190, DateTimeKind.Local).AddTicks(9361), "Христина", "Гнатишин", "докт. політ. наук", "5627161466", "Бухгалтер", 1292.92m, "Solutions" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 9, 19, 5, 50, 54, 17, DateTimeKind.Local).AddTicks(5303), "Стрийська майдан, 83, Хмельницький, Йорданія", new DateTime(1947, 12, 28, 7, 3, 58, 855, DateTimeKind.Local).AddTicks(6829), "Olga.Shamrilo@e-mail.ua", new DateTime(2023, 4, 15, 2, 48, 32, 41, DateTimeKind.Local).AddTicks(5439), "Любомир", "Кивач", "канд. філос. наук", "0071827806", 12326.19m, "alliance" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 5, 3, 42, 46, 939, DateTimeKind.Local).AddTicks(794), "вул. Брюховичів, 49, Західний Ізяслав, Конго", new DateTime(1995, 4, 2, 18, 50, 38, 320, DateTimeKind.Local).AddTicks(7114), "Kvitka99@yandex.ua", new DateTime(2023, 9, 4, 14, 44, 34, 298, DateTimeKind.Local).AddTicks(1883), "Пелагея", "Калач", "канд. політ. наук", "7506006675", "Програміст", 2554.69m, "even-keeled" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 9, 29, 11, 33, 32, 34, DateTimeKind.Local).AddTicks(1638), "Вічева майдан, 99, Чернігів, Китай", new DateTime(2004, 6, 16, 5, 3, 22, 83, DateTimeKind.Local).AddTicks(9149), "Tikhon.Svidrigailo@i.ua", new DateTime(2021, 10, 3, 16, 23, 8, 560, DateTimeKind.Local).AddTicks(8690), "Богдана", "Мамій", "канд. техн. наук", "2802955933", "Секретар", 15431.02m, "compelling" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 8, 13, 8, 9, 24, 825, DateTimeKind.Local).AddTicks(3837), "Молодіжна майдан, 80, Ужгород, Андорра", new DateTime(1999, 12, 6, 5, 5, 48, 988, DateTimeKind.Local).AddTicks(7834), "Markiyan35@ukr.net", null, "Алла", "Ющук", "докт. техн. наук", "3554425547", 11426.59m, "system" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "Employees",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 8, 10, 9, 7, 328, DateTimeKind.Local).AddTicks(1285), "вулиця Вузька, 5, Харків, В’єтнам", new DateTime(2022, 6, 9, 4, 40, 4, 505, DateTimeKind.Local).AddTicks(7054), "AED", "Svitlana14@ukr.net", new DateTime(2022, 2, 28, 19, 13, 16, 17, DateTimeKind.Local).AddTicks(1666), "Мотря", "Мамій", "докт. філос. наук", "(092) 155-57-91", 3736.14m, "collaboration" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 11, 13, 19, 36, 4, 201, DateTimeKind.Local).AddTicks(8020), "вул. Городоцька, 0, Східний Гліб, Ямайка", new DateTime(1971, 7, 12, 7, 47, 29, 91, DateTimeKind.Local).AddTicks(3278), "PHP", "Glib.Lagoida36@gmail.com", null, "Юліанна", "Яворівський", "канд. юрид. наук", "(050) 641-26-11", "Директор", 17485.31m, "solid state" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 5, 30, 9, 3, 2, 921, DateTimeKind.Local).AddTicks(3421), "провулок Нижанківського, 91, Ізмаїл, Сінгапур", new DateTime(2009, 8, 26, 17, 9, 9, 35, DateTimeKind.Local).AddTicks(3738), "AED", "Ustim.Vasilishina@e-mail.ua", "Раїса", "Пономарів", "канд. філол. наук", "(063) 619-24-01", 14623.66m, "innovative" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 20, 20, 41, 10, 796, DateTimeKind.Local).AddTicks(3901), "площа Стрийська, 44, Севастополь, Тринідад і Тобаго", new DateTime(2014, 11, 17, 20, 15, 33, 608, DateTimeKind.Local).AddTicks(3653), "KES", "Listvich.Yalyuk74@e-mail.ua", new DateTime(2022, 12, 10, 16, 49, 10, 316, DateTimeKind.Local).AddTicks(7360), "Орхип", "Ромей", "канд. психол. наук", "(063) 785-77-85", "Прибиральник", 8428.11m, "synthesize" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 3, 10, 40, 45, 39, DateTimeKind.Local).AddTicks(6529), "Стрийська майдан, 05, Луганськ, Замбія", new DateTime(1958, 6, 14, 11, 21, 42, 561, DateTimeKind.Local).AddTicks(5811), "ZMK", "Zoremir_Sirko15@gmail.com", "Мирослав", "Іванців", "докт. філос. наук", "(063) 315-30-41", "Секретар", 11928.44m, "Buckinghamshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 2, 12, 7, 17, 786, DateTimeKind.Local).AddTicks(6010), "пл. Староміська, 390, Північний В’ячеслав, Свазіленд", new DateTime(2013, 4, 30, 0, 44, 33, 301, DateTimeKind.Local).AddTicks(222), "RSD", "Pelageya87@e-mail.ua", new DateTime(2023, 6, 18, 16, 55, 0, 847, DateTimeKind.Local).AddTicks(4423), "Агнія", "Скоропадська", "канд. філос. наук", "(098) 413-74-22", "Секретар", 8205.53m, "auxiliary" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 25, 17, 53, 41, 191, DateTimeKind.Local).AddTicks(8292), "Городоцька майдан, 8, Південний Тур, Еритрея", new DateTime(1988, 1, 11, 18, 58, 48, 255, DateTimeKind.Local).AddTicks(269), "LTL", "Vitalina_Gorodockii@ex.ua", new DateTime(2020, 9, 12, 17, 43, 11, 583, DateTimeKind.Local).AddTicks(5398), "Божемир", "Гойко", "докт. політ. наук", "(094) 228-36-62", "Секретар", 8239.36m, "hacking" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 9, 14, 46, 12, 987, DateTimeKind.Local).AddTicks(1090), "вулиця Вічева, 10, Суми, Пакистан", new DateTime(2008, 11, 22, 0, 27, 0, 489, DateTimeKind.Local).AddTicks(2034), "LAK", "Antonii_Miklashevskii@meta.ua", null, "Гордій", "Кандиба", "докт. техн. наук", "(099) 483-19-69", 3313.90m, "PNG" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 4, 18, 20, 42, 56, 247, DateTimeKind.Local).AddTicks(2099), "Брюховичів майдан, 0, Південний Яровид, Мавританія", new DateTime(1954, 3, 18, 0, 45, 41, 511, DateTimeKind.Local).AddTicks(3547), "CNY", "Rostislav.Shindarei21@yandex.ua", new DateTime(2022, 9, 11, 18, 37, 59, 32, DateTimeKind.Local).AddTicks(2183), "Гарнослав", "Роменець", "(063) 943-09-09", "Прибиральник", 18753.12m, "framework" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 4, 13, 53, 10, 939, DateTimeKind.Local).AddTicks(9897), "Вузька майдан, 61, Харків, Екваторіальна Гвінея", new DateTime(2023, 11, 20, 19, 5, 28, 559, DateTimeKind.Local).AddTicks(7780), "DOP", "Vita53@yandex.ua", new DateTime(2020, 4, 15, 17, 18, 20, 109, DateTimeKind.Local).AddTicks(9654), "Руслан", "Трясун", "докт. і. наук", "(094) 782-42-70", "Програміст", 12456.15m, "Web" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 22, 19, 2, 12, 907, DateTimeKind.Local).AddTicks(1942), "Городоцька майдан, 764, Львів, Узбекистан", new DateTime(2007, 11, 22, 19, 47, 35, 889, DateTimeKind.Local).AddTicks(4058), "VND", "Radim5@ukr.net", null, "Іннеса", "Євенко", "проф.", "(044) 921-24-17", 8920.21m, "Interactions" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 3, 9, 5, 40, 35, 121, DateTimeKind.Local).AddTicks(5115), "Нижанківського майдан, 6, Бердичів, Екваторіальна Гвінея", new DateTime(2018, 8, 23, 4, 38, 23, 907, DateTimeKind.Local).AddTicks(7019), "BTN", "Tur.Svidrigailo@meta.ua", null, "Аврора", "Бамбула", "докт. юрид. наук", "(050) 402-74-73", 13468.20m, "global" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 11, 3, 20, 12, 0, 471, DateTimeKind.Local).AddTicks(9647), "провулок Стрийська, 92, Південний Микола, Малаві", new DateTime(1991, 6, 10, 13, 38, 24, 44, DateTimeKind.Local).AddTicks(6905), "SHP", "Miloslava84@ex.ua", new DateTime(2020, 5, 19, 3, 43, 25, 238, DateTimeKind.Local).AddTicks(806), "Кузьма", "Демків", "(099) 555-10-88", "Секретар", 19178.19m, "Fantastic Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 2, 15, 44, 28, 763, DateTimeKind.Local).AddTicks(8088), "Староміська майдан, 1, Керч, Ізраїль", new DateTime(1984, 5, 10, 19, 23, 40, 887, DateTimeKind.Local).AddTicks(5608), "YER", "Oleksandra90@ex.ua", "Пелагія", "Петрів", "канд. психол. наук", "(044) 980-03-72", 3603.84m, "Avon" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 12, 13, 7, 10, 34, 225, DateTimeKind.Local).AddTicks(7912), "Староміська майдан, 1, Сєвєродонецьк, Гайана", new DateTime(1962, 4, 17, 14, 10, 50, 165, DateTimeKind.Local).AddTicks(771), "UGX", "Ilona_Sayenko@meta.ua", new DateTime(2021, 7, 2, 5, 50, 40, 140, DateTimeKind.Local).AddTicks(1314), "Стожар", "Кордун", "докт. і. наук", "(094) 846-52-00", 10102.42m, "tan" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 6, 6, 30, 10, 373, DateTimeKind.Local).AddTicks(7845), "проспект Зелена, 664, Керч, Бруней", new DateTime(2006, 5, 19, 13, 17, 31, 21, DateTimeKind.Local).AddTicks(9989), "XPF", "Olesya_Chervonii91@meta.ua", new DateTime(2022, 5, 31, 22, 1, 17, 566, DateTimeKind.Local).AddTicks(5117), "Пелагія", "Гордійчук", "канд. політ. наук", "(097) 029-43-74", "Прибиральник", 13322.54m, "real-time" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 17, 12, 10, 44, 145, DateTimeKind.Local).AddTicks(3171), "вулиця Нижанківського, 58, Західний Василь, Непал", new DateTime(1981, 10, 24, 10, 51, 47, 515, DateTimeKind.Local).AddTicks(7835), "BWP", "Artemiya.Chervonii@e-mail.ua", "Ореста", "Стоян", "канд. політ. наук", "(098) 619-01-90", "Прибиральник", 18489.52m, "payment" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 25, 9, 40, 48, 699, DateTimeKind.Local).AddTicks(4499), "вулиця Винників, 62, Миколаїв, Чорногорія", new DateTime(2022, 5, 19, 18, 39, 8, 8, DateTimeKind.Local).AddTicks(7599), "XTS", "Mechislav28@meta.ua", new DateTime(2019, 7, 13, 15, 25, 45, 936, DateTimeKind.Local).AddTicks(9530), "Хвалимир", "Гайчук", "докт. філол. наук", "(063) 543-06-57", 5740.27m, "Kids & Electronics" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 20, 10, 58, 52, 568, DateTimeKind.Local).AddTicks(8724), "Вузька майдан, 018, Миколаїв, Бразилія", new DateTime(1949, 9, 28, 23, 28, 53, 725, DateTimeKind.Local).AddTicks(1110), "GNF", "Alina_Polishuk26@ex.ua", null, "Марина", "Бутько", "канд. пед. наук", "(066) 516-62-81", "Прибиральник", 18738.74m, "holistic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 5, 11, 1, 23, 24, 681, DateTimeKind.Local).AddTicks(5530), "Молодіжна майдан, 0, Західний Стожар, Центральноафриканська Республіка", new DateTime(1957, 3, 22, 20, 6, 14, 335, DateTimeKind.Local).AddTicks(5064), "PYG", "Dalemir_Korecka58@e-mail.ua", "Артем", "Демчишина", "доц.", "(044) 915-56-22", 16990.01m, "Colorado" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 8, 6, 4, 17, 1, 364, DateTimeKind.Local).AddTicks(632), "пр. Вічева, 68, Східний Петро, Казахстан", new DateTime(1974, 1, 5, 23, 41, 10, 235, DateTimeKind.Local).AddTicks(22), "NAD", "Lukyan_Zinkevich@ex.ua", "Григорій", "Притула", "докт. філол. наук", "(099) 682-33-64", "Секретар", 13285.32m, "deposit" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 30, 21, 58, 22, 166, DateTimeKind.Local).AddTicks(8169), "Нижанківського майдан, 7, Південний Ладомир, Киргизстан", new DateTime(2018, 8, 6, 3, 13, 1, 577, DateTimeKind.Local).AddTicks(2), "ANG", "Kupava_Balabukh23@meta.ua", "Фаїна", "Приймак", "канд. філол. наук", "(066) 463-85-11", "Прибиральник", 10350.99m, "Producer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 3, 29, 22, 52, 0, 599, DateTimeKind.Local).AddTicks(8544), "Коліївщини майдан, 18, Східний Зеновій, Кіпр", new DateTime(2001, 5, 13, 22, 21, 32, 834, DateTimeKind.Local).AddTicks(6010), "XBD", "Nelya_Troyan95@yandex.ua", new DateTime(2020, 8, 2, 10, 43, 11, 424, DateTimeKind.Local).AddTicks(8323), "Петро", "Трясило", "канд. психол. наук", "(092) 491-04-04", "Програміст", 7822.54m, "Philippine Peso" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 8, 2, 44, 41, 861, DateTimeKind.Local).AddTicks(9270), "пр. Рудного, 3, Лисичанськ, Буркіна-Фасо", new DateTime(1995, 10, 23, 14, 30, 32, 251, DateTimeKind.Local).AddTicks(7650), "MXN", "Kalina_Zinkevich@meta.ua", new DateTime(2019, 10, 5, 4, 28, 39, 506, DateTimeKind.Local).AddTicks(6447), "Альберт", "Негода", "канд. філол. наук", "(094) 716-94-34", "Бухгалтер", 4652.61m, "Metal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 31, 9, 40, 37, 850, DateTimeKind.Local).AddTicks(317), "Брюховичів майдан, 5, Північний Іван, США", new DateTime(2000, 7, 30, 20, 17, 33, 76, DateTimeKind.Local).AddTicks(8589), "MYR", "Gorislav.Yermak@yandex.ua", null, "Антонія", "Вередун", "канд. пед. наук", "(050) 211-84-56", "Директор", 14236.22m, "Persistent" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 3, 6, 8, 20, 974, DateTimeKind.Local).AddTicks(5444), "пл. Зелена, 50, Кіровоград, Венесуела", new DateTime(1951, 9, 16, 4, 27, 46, 91, DateTimeKind.Local).AddTicks(3305), "PGK", "Rayina93@i.ua", new DateTime(2021, 2, 1, 19, 40, 53, 244, DateTimeKind.Local).AddTicks(8524), "Лада", "Коров’як", "докт. пед. наук", "(096) 434-87-28", "Секретар", 9041.29m, "Bond Markets Units European Composite Unit (EURCO)" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 22, 5, 13, 13, 81, DateTimeKind.Local).AddTicks(3312), "пров. Зелена, 747, Бердянськ, Уругвай", new DateTime(2013, 9, 2, 11, 20, 21, 18, DateTimeKind.Local).AddTicks(6591), "KRW", "Zlat.Bricka@ukr.net", new DateTime(2023, 7, 16, 20, 5, 39, 376, DateTimeKind.Local).AddTicks(8792), "Олена", "Гладківська", "докт. філос. наук", "(095) 062-98-18", "Директор", 5000.32m, "East Caribbean Dollar" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 2, 0, 1, 37, 337, DateTimeKind.Local).AddTicks(3034), "Коліївщини майдан, 064, Чернігів, Танзанія", new DateTime(2000, 6, 18, 7, 46, 17, 440, DateTimeKind.Local).AddTicks(1257), "UZS", "Lado3@i.ua", "Аркадія", "Гарун", "канд. психол. наук", "(092) 243-50-38", "Секретар", 18512.59m, "Direct" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 5, 26, 22, 44, 20, 687, DateTimeKind.Local).AddTicks(786), "вулиця Рудного, 954, Західний Стефаній, Сан-Томе і Принсіпі", new DateTime(2010, 5, 30, 12, 18, 43, 139, DateTimeKind.Local).AddTicks(1477), "GMD", "Taras_Pagutyak42@ukr.net", new DateTime(2019, 10, 27, 16, 48, 41, 288, DateTimeKind.Local).AddTicks(8761), "Яна", "Поривайло", "докт. філол. наук", "(073) 408-83-21", "Програміст", 7554.31m, "TCP" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 4, 2, 11, 32, 9, 433, DateTimeKind.Local).AddTicks(6649), "пров. Вічева, 30, Черкаси, Лаос", new DateTime(1988, 11, 20, 15, 29, 49, 348, DateTimeKind.Local).AddTicks(8893), "SCR", "Agniya32@i.ua", null, "Влад", "Семещук", "канд. техн. наук", "(098) 790-62-39", 6109.97m, "Practical Steel Table" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 12, 6, 18, 58, 106, DateTimeKind.Local).AddTicks(4698), "Винників майдан, 03, Хмельницький, Індонезія", new DateTime(1984, 7, 19, 18, 34, 24, 975, DateTimeKind.Local).AddTicks(2665), "XPT", "Danilo_Boyarchuk62@gmail.com", new DateTime(2021, 5, 4, 5, 0, 31, 446, DateTimeKind.Local).AddTicks(7681), "Влада", "Сердюк", "канд. політ. наук", "(066) 330-98-55", "Прибиральник", 10270.57m, "Developer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 8, 3, 8, 7, 484, DateTimeKind.Local).AddTicks(4273), "вулиця Рудного, 673, Північний Ростислав, Гондурас", new DateTime(2019, 8, 21, 7, 4, 21, 918, DateTimeKind.Local).AddTicks(2348), "SRD", "Musii26@ukr.net", new DateTime(2021, 12, 3, 11, 18, 59, 663, DateTimeKind.Local).AddTicks(572), "Ганна", "Демчишина", "канд. техн. наук", "(092) 705-44-02", "Прибиральник", 11771.35m, "USB" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 5, 28, 21, 40, 51, 383, DateTimeKind.Local).AddTicks(8559), "Стрийська майдан, 046, Алчевськ, Гана", new DateTime(2010, 6, 30, 7, 33, 12, 745, DateTimeKind.Local).AddTicks(6788), "LVL", "Lyudomila_Lanovii17@i.ua", new DateTime(2022, 6, 26, 3, 19, 4, 768, DateTimeKind.Local).AddTicks(114), "Віола", "Брицька", "канд. пед. наук", "(095) 755-08-83", "Бухгалтер", 17588.92m, "Roads" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 4, 9, 5, 41, 53, 983, DateTimeKind.Local).AddTicks(7878), "Стрийська майдан, 376, Одеса, Азербайджан", new DateTime(1962, 11, 15, 4, 58, 11, 221, DateTimeKind.Local).AddTicks(8600), "NOK", "Avgustin6@ukr.net", "Клавдія", "Янюк", "докт. і. наук", "(063) 893-71-91", "Бухгалтер", 18554.36m, "Zambian Kwacha" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 29, 1, 36, 42, 697, DateTimeKind.Local).AddTicks(6135), "пр. Вічева, 133, Ужгород, Бахрейн", new DateTime(1975, 3, 20, 14, 8, 17, 427, DateTimeKind.Local).AddTicks(664), "TTD", "Vadim_Koreckii47@ex.ua", new DateTime(2019, 9, 2, 18, 49, 22, 102, DateTimeKind.Local).AddTicks(4673), "Мар’яна", "Шевченко", "канд. пед. наук", "(066) 893-10-51", "Бухгалтер", 1649.74m, "Avon" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 15, 17, 37, 52, 796, DateTimeKind.Local).AddTicks(6958), "Вузька майдан, 4, Північний Герасим, Узбекистан", new DateTime(1993, 1, 20, 17, 22, 33, 939, DateTimeKind.Local).AddTicks(2881), "ANG", "Dobromisla.Slobodyan@e-mail.ua", new DateTime(2022, 8, 11, 5, 24, 5, 998, DateTimeKind.Local).AddTicks(996), "Звенислава", "Балабан", "докт. філос. наук", "(073) 898-07-38", "Секретар", 16051.04m, "Mobility" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 17, 19, 44, 54, 560, DateTimeKind.Local).AddTicks(1749), "Вічева майдан, 33, Східний Євген, Фіджі", new DateTime(2001, 8, 5, 11, 16, 3, 830, DateTimeKind.Local).AddTicks(9027), "BDT", "Borimir.Luchko@gmail.com", new DateTime(2022, 5, 22, 23, 51, 4, 522, DateTimeKind.Local).AddTicks(4381), "Алевтин", "Калач", "докт. філос. наук", "(097) 113-73-90", "Директор", 7947.26m, "Baht" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 8, 19, 23, 50, 11, 154, DateTimeKind.Local).AddTicks(8580), "площа Молодіжна, 818, Північний Зореслав, Чад", new DateTime(2003, 1, 17, 6, 10, 18, 734, DateTimeKind.Local).AddTicks(4653), "BZD", "Budimir.Minyailo7@i.ua", new DateTime(2020, 12, 17, 21, 28, 50, 925, DateTimeKind.Local).AddTicks(3979), "Тетяна", "Прядун", "докт. філол. наук", "(063) 469-68-97", 17523.52m, "online" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 15, 7, 6, 55, 708, DateTimeKind.Local).AddTicks(2592), "проспект Коліївщини, 6, Бровари, Багамські Острови", new DateTime(1947, 4, 7, 3, 20, 45, 191, DateTimeKind.Local).AddTicks(9055), "MDL", "Antoniya4@ukr.net", "Сюзана", "Мазило", "канд. техн. наук", "(093) 482-10-24", "Бухгалтер", 19270.39m, "maroon" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 18, 0, 45, 53, 233, DateTimeKind.Local).AddTicks(6620), "Вузька майдан, 6, Східний Маркіян, Малаві", new DateTime(1945, 8, 8, 8, 52, 11, 519, DateTimeKind.Local).AddTicks(8135), "EEK", "Solomiya.Makoveckii11@ukr.net", new DateTime(2023, 7, 12, 3, 47, 23, 554, DateTimeKind.Local).AddTicks(6770), "Синьоок", "Шиян", "канд. пед. наук", "(063) 335-46-55", "Секретар", 1419.94m, "Vermont" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 7, 9, 1, 14, 72, DateTimeKind.Local).AddTicks(6992), "Вічева майдан, 1, Східний Ладислав, Бангладеш", new DateTime(1963, 8, 25, 1, 18, 48, 258, DateTimeKind.Local).AddTicks(1648), "VUV", "Vyacheslav20@i.ua", new DateTime(2020, 2, 27, 18, 18, 28, 492, DateTimeKind.Local).AddTicks(6611), "Альбіна", "Палій", "докт. філос. наук", "(050) 232-36-67", "Директор", 18323.20m, "Product" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 29, 22, 30, 42, 97, DateTimeKind.Local).AddTicks(7664), "Брюховичів майдан, 2, Біла Церква, Марокко", new DateTime(1981, 7, 7, 13, 51, 43, 708, DateTimeKind.Local).AddTicks(6078), "XAF", "Rodoslav_Kornyiichuk11@ex.ua", new DateTime(2021, 10, 22, 17, 23, 30, 659, DateTimeKind.Local).AddTicks(1390), "Анатолій", "Левадовська", "докт. філос. наук", "(094) 440-40-79", 8052.47m, "International" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 10, 11, 26, 32, 906, DateTimeKind.Local).AddTicks(3263), "проспект Рудного, 286, Артемівськ, Самоа", new DateTime(1951, 8, 29, 15, 23, 9, 477, DateTimeKind.Local).AddTicks(4973), "XBC", "Ladislav7@e-mail.ua", null, "Альберт", "Линдик", "докт. психол. наук", "(050) 249-09-85", "Бухгалтер", 12762.14m, "Dynamic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 16, 11, 21, 5, 561, DateTimeKind.Local).AddTicks(150), "пл. Стрийська, 72, Східний Кий, Уругвай", new DateTime(2016, 11, 20, 12, 33, 16, 253, DateTimeKind.Local).AddTicks(8051), "PKR", "Fedora.Lyutii81@ukr.net", null, "Устим", "Балицька", "докт. юрид. наук", "(066) 987-19-42", "Програміст", 3915.37m, "Lead" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 18, 15, 38, 30, 278, DateTimeKind.Local).AddTicks(7390), "проспект Зелена, 977, Київ, Україна", new DateTime(2016, 10, 17, 0, 53, 24, 13, DateTimeKind.Local).AddTicks(5128), "BTN", "Karina.Shevchenko@yandex.ua", new DateTime(2024, 2, 5, 4, 8, 22, 48, DateTimeKind.Local).AddTicks(1461), "Мстислав", "Могилевський", "докт. політ. наук", "(091) 128-76-73", "Бухгалтер", 18506.81m, "system-worthy" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 4, 9, 23, 27, 52, 989, DateTimeKind.Local).AddTicks(9786), "Брюховичів майдан, 00, Конотоп, Камбоджа", new DateTime(2003, 1, 29, 20, 54, 52, 765, DateTimeKind.Local).AddTicks(3412), "MGA", "Mechislava_Trublayevska@e-mail.ua", new DateTime(2019, 8, 1, 0, 16, 21, 259, DateTimeKind.Local).AddTicks(3102), "Далеслава", "Плаксій", "канд. філол. наук", "(063) 489-17-58", "Директор", 8672.22m, "white" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 8, 22, 15, 8, 8, 786, DateTimeKind.Local).AddTicks(3445), "Стрийська майдан, 2, Єнакієве, Оман", new DateTime(2022, 5, 6, 15, 26, 18, 28, DateTimeKind.Local).AddTicks(1163), "XBC", "Lyubava61@yandex.ua", new DateTime(2019, 8, 3, 20, 45, 14, 358, DateTimeKind.Local).AddTicks(8093), "Владислав", "Гарун", "проф.", "(066) 759-26-23", 11790.76m, "Bedfordshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 9, 17, 405, DateTimeKind.Local).AddTicks(9766), "пров. Зелена, 155, Севастополь, Тонга", new DateTime(1957, 2, 19, 22, 3, 20, 598, DateTimeKind.Local).AddTicks(5458), "ALL", "Yaromir70@e-mail.ua", new DateTime(2020, 1, 23, 22, 5, 7, 549, DateTimeKind.Local).AddTicks(3513), "Юхима", "Маринич", "канд. філол. наук", "(091) 734-73-64", "Бухгалтер", 2812.99m, "wireless" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 8, 18, 5, 38, 19, 268, DateTimeKind.Local).AddTicks(1966), "проспект Староміська, 2, Західний Володимир, Сент-Вінсент і Гренадини", new DateTime(1945, 2, 22, 2, 23, 55, 340, DateTimeKind.Local).AddTicks(8542), "SRD", "Oles.Makoveckii@e-mail.ua", new DateTime(2023, 8, 16, 11, 53, 3, 259, DateTimeKind.Local).AddTicks(3343), "Зиновій", "Шухевич", "проф.", "(066) 298-81-83", "Бухгалтер", 16450.52m, "evolve" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 9, 24, 2, 53, 1, 252, DateTimeKind.Local).AddTicks(9612), "Рудного майдан, 24, Південний Мирослав, Маршаллові Острови", new DateTime(1949, 1, 9, 8, 13, 1, 171, DateTimeKind.Local).AddTicks(6234), "SHP", "Zoryan_Shevchenko34@ukr.net", new DateTime(2023, 2, 12, 14, 46, 1, 240, DateTimeKind.Local).AddTicks(8041), "Власта", "Бамбула", "докт. пед. наук", "(044) 401-03-19", "Програміст", 4515.65m, "reinvent" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 19, 17, 51, 33, 247, DateTimeKind.Local).AddTicks(4127), "пров. Вічева, 67, Південний Листвич, Кірибаті", new DateTime(1990, 7, 4, 22, 24, 58, 192, DateTimeKind.Local).AddTicks(1375), "SBD", "Danilo.Mazun10@ukr.net", new DateTime(2022, 8, 13, 22, 40, 33, 395, DateTimeKind.Local).AddTicks(9112), "Аврора", "Горовий", "докт. і. наук", "(098) 408-51-86", "Прибиральник", 2401.14m, "scale" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 12, 23, 22, 21, 794, DateTimeKind.Local).AddTicks(11), "пров. Ліста, 231, Східний Ярослав, Конго", new DateTime(1954, 9, 21, 2, 27, 56, 519, DateTimeKind.Local).AddTicks(9229), "KGS", "Vasilina26@ex.ua", "Братомил", "Скоропадський", "докт. юрид. наук", "(073) 279-38-85", "Програміст", 8932.07m, "Benin" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 18, 18, 17, 57, 690, DateTimeKind.Local).AddTicks(3337), "пров. Брюховичів, 8, Західний Всевлад, Марокко", new DateTime(2013, 7, 22, 14, 22, 13, 211, DateTimeKind.Local).AddTicks(4311), "ZAR", "Timofii.Demchishin67@ukr.net", new DateTime(2023, 6, 25, 3, 45, 48, 351, DateTimeKind.Local).AddTicks(4107), "Мстислав", "Коров’як", "докт. і. наук", "(044) 405-02-68", "Директор", 10827.84m, "programming" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 26, 15, 45, 2, 379, DateTimeKind.Local).AddTicks(4096), "пл. Нижанківського, 206, Східний Назар, Молдова", new DateTime(2017, 12, 9, 11, 2, 43, 73, DateTimeKind.Local).AddTicks(2943), "UZS", "Zoreslava6@gmail.com", null, "Мокрина", "Лящук", "канд. політ. наук", "(050) 126-64-97", "Програміст", 13815.97m, "composite" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 13, 0, 38, 35, 228, DateTimeKind.Local).AddTicks(4134), "Коліївщини майдан, 67, Одеса, Ангола", new DateTime(2002, 5, 22, 1, 22, 37, 424, DateTimeKind.Local).AddTicks(2017), "MGA", "Azaliya.Trublayevskii55@ex.ua", "Роман", "Сірко", "докт. філос. наук", "(094) 305-68-19", 6226.73m, "Seychelles Rupee" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 11, 7, 44, 0, 473, DateTimeKind.Local).AddTicks(2017), "Нижанківського майдан, 783, Тернопіль, Венесуела", new DateTime(1951, 2, 27, 20, 37, 6, 892, DateTimeKind.Local).AddTicks(9083), "EGP", "Lyubodar94@gmail.com", new DateTime(2023, 7, 2, 21, 59, 43, 702, DateTimeKind.Local).AddTicks(5801), "Віола", "Шиян", "доц.", "(096) 645-20-90", "Бухгалтер", 1698.58m, "SCSI" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 20, 10, 32, 52, 893, DateTimeKind.Local).AddTicks(5398), "вулиця Вузька, 0, Луцьк, Чорногорія", new DateTime(1994, 9, 22, 13, 27, 38, 507, DateTimeKind.Local).AddTicks(2267), "KZT", "Yan.Kovalenko3@meta.ua", new DateTime(2020, 7, 11, 14, 28, 30, 544, DateTimeKind.Local).AddTicks(7922), "Павліна", "Луцьків", "канд. політ. наук", "(094) 893-46-10", "Прибиральник", 6086.84m, "Generic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 3, 14, 12, 7, 16, 88, DateTimeKind.Local).AddTicks(294), "Староміська майдан, 5, Західний Земислав, Вірменія", new DateTime(1998, 4, 13, 5, 14, 35, 992, DateTimeKind.Local).AddTicks(5784), "XCD", "Agafiya70@meta.ua", new DateTime(2023, 5, 10, 10, 23, 47, 421, DateTimeKind.Local).AddTicks(5699), "Аврелія", "Милославський", "канд. філол. наук", "(093) 087-65-64", "Секретар", 1439.39m, "Bedfordshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 3, 2, 27, 30, 469, DateTimeKind.Local).AddTicks(5169), "Коліївщини майдан, 715, Північний Гарнослав, Японія", new DateTime(1947, 11, 30, 13, 31, 2, 57, DateTimeKind.Local).AddTicks(5319), "THB", "Zlat.Glinska65@ex.ua", null, "Тарас", "Опенько", "доц.", "(091) 602-59-07", "Програміст", 12869.79m, "e-enable" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 9, 10, 7, 4, 14, 330, DateTimeKind.Local).AddTicks(1690), "вул. Винників, 93, Біла Церква, Фіджі", new DateTime(1983, 7, 27, 6, 44, 51, 546, DateTimeKind.Local).AddTicks(3658), "ZMK", "Valentin.Balaban@ex.ua", null, "Тетяна", "Ярмак", "докт. філол. наук", "(073) 161-23-84", 7027.36m, "monitor" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 20, 2, 27, 55, 962, DateTimeKind.Local).AddTicks(28), "вулиця Стрийська, 947, Південний Сніжан, Бахрейн", new DateTime(2023, 8, 22, 19, 37, 42, 165, DateTimeKind.Local).AddTicks(7016), "CUP", "Zorina_Sirko0@ex.ua", "Левко", "Саєнко", "канд. психол. наук", "(044) 004-37-96", 3302.04m, "Developer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 11, 22, 5, 25, 5, 213, DateTimeKind.Local).AddTicks(4191), "пл. Коліївщини, 8, Красний Луч, Мальта", new DateTime(2002, 9, 11, 6, 14, 13, 415, DateTimeKind.Local).AddTicks(3431), "TWD", "Stanislava58@yandex.ua", "Анжела", "Малкович", "докт. пед. наук", "(093) 447-45-75", "Прибиральник", 8976.19m, "Open-architected" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 14, 5, 25, 59, 232, DateTimeKind.Local).AddTicks(6869), "Молодіжна майдан, 9, Бровари, Португалія", new DateTime(2010, 11, 3, 7, 54, 38, 585, DateTimeKind.Local).AddTicks(6020), "VEF", "Radim.Vereshuk@yandex.ua", new DateTime(2023, 12, 5, 7, 42, 27, 521, DateTimeKind.Local).AddTicks(5556), "Злат", "Щербак", "(097) 481-54-14", 7140.79m, "Berkshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 4, 7, 44, 34, 617, DateTimeKind.Local).AddTicks(2738), "пров. Староміська, 77, Західний В’ячеслав, Сьєрра-Леоне", new DateTime(1994, 12, 18, 21, 44, 6, 376, DateTimeKind.Local).AddTicks(878), "OMR", "Oksana_Kompaniyec@meta.ua", new DateTime(2023, 12, 24, 10, 41, 44, 265, DateTimeKind.Local).AddTicks(81), "Милодара", "Данилишина", "докт. психол. наук", "(097) 423-26-68", "Директор", 17859.94m, "Fresh" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 9, 13, 13, 3, 263, DateTimeKind.Local).AddTicks(2474), "площа Городоцька, 7, Північний Подолян, Буркіна-Фасо", new DateTime(2022, 11, 3, 7, 52, 22, 519, DateTimeKind.Local).AddTicks(4241), "PGK", "Zoryana30@yandex.ua", null, "Броніслава", "Майстренко", "проф.", "(063) 083-75-86", 7589.51m, "Representative" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 8, 22, 22, 50, 18, 91, DateTimeKind.Local).AddTicks(2168), "Нижанківського майдан, 21, Лисичанськ, Центральноафриканська Республіка", new DateTime(2004, 4, 14, 19, 1, 49, 920, DateTimeKind.Local).AddTicks(8970), "AOA", "Lavrentii_Baranovska81@yandex.ua", new DateTime(2024, 2, 15, 16, 42, 21, 550, DateTimeKind.Local).AddTicks(8001), "Валерій", "Забіла", "докт. філос. наук", "(098) 210-22-91", "Програміст", 10333.07m, "driver" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 7, 10, 24, 59, 377, DateTimeKind.Local).AddTicks(1168), "вул. Вузька, 3, Східний Геннадій, Ангола", new DateTime(2021, 8, 5, 7, 4, 9, 654, DateTimeKind.Local).AddTicks(1579), "XPD", "Lyubodar_Kandiba48@i.ua", new DateTime(2023, 6, 13, 23, 17, 20, 859, DateTimeKind.Local).AddTicks(3966), "Борислава", "Осадко", "докт. політ. наук", "(095) 201-42-03", "Секретар", 1698.46m, "Up-sized" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 11, 0, 21, 492, DateTimeKind.Local).AddTicks(1518), "Рудного майдан, 75, Маріуполь, Туніс", new DateTime(2006, 11, 3, 15, 41, 6, 294, DateTimeKind.Local).AddTicks(7561), "GEL", "Bilomir.Bondarenko88@ex.ua", "Земислав", "Линдик", "докт. філос. наук", "(044) 526-74-23", "Прибиральник", 16596.69m, "Bolivia" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 27, 10, 5, 38, 410, DateTimeKind.Local).AddTicks(7714), "проспект Староміська, 69, Північний Микита, Чилі", new DateTime(2003, 8, 27, 11, 53, 29, 8, DateTimeKind.Local).AddTicks(2477), "NGN", "Antonina_Garai31@ex.ua", null, "Радміла", "Пагутяк", "докт. політ. наук", "(098) 805-27-81", "Секретар", 16730.42m, "Engineer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 3, 10, 15, 9, 122, DateTimeKind.Local).AddTicks(7138), "пр. Староміська, 23, Сєвєродонецьк, Лівія", new DateTime(1967, 11, 12, 22, 51, 59, 517, DateTimeKind.Local).AddTicks(2978), "GYD", "Arkhip_Storozhuk@e-mail.ua", new DateTime(2021, 10, 12, 3, 27, 36, 413, DateTimeKind.Local).AddTicks(132), "Архип", "Євпак", "канд. філос. наук", "(073) 491-56-92", "Директор", 11342.81m, "integrated" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 7, 1, 8, 14, 742, DateTimeKind.Local).AddTicks(8723), "пл. Брюховичів, 40, Кам’янець-Подільський, Бельгія", new DateTime(1981, 5, 11, 2, 43, 29, 310, DateTimeKind.Local).AddTicks(5821), "UYU", "Igor71@ex.ua", "Агнія", "Лановий", "доц.", "(096) 590-09-06", "Секретар", 18622.74m, "Tunnel" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 3, 21, 14, 20, 46, 676, DateTimeKind.Local).AddTicks(2673), "Нижанківського майдан, 4, Західний Сніжан, Швеція", new DateTime(1995, 1, 11, 5, 1, 25, 80, DateTimeKind.Local).AddTicks(3768), "MXN", "Maryan_Gnatishina26@yandex.ua", "Дарислава", "Громико", "докт. техн. наук", "(044) 969-70-41", "Програміст", 12893.53m, "Handcrafted" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 17, 23, 19, 42, 513, DateTimeKind.Local).AddTicks(5609), "Винників майдан, 88, Макіївка, Азербайджан", new DateTime(2008, 6, 22, 14, 35, 18, 991, DateTimeKind.Local).AddTicks(2960), "LSL", "Avreliya51@yandex.ua", new DateTime(2023, 12, 29, 15, 59, 2, 873, DateTimeKind.Local).AddTicks(4338), "Богуслава", "Кивач", "канд. політ. наук", "(063) 332-35-57", "Бухгалтер", 18671.56m, "Associate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 6, 20, 11, 39, 450, DateTimeKind.Local).AddTicks(673), "Зелена майдан, 825, Північний Лад, Палау", new DateTime(1960, 3, 5, 6, 44, 21, 526, DateTimeKind.Local).AddTicks(7815), "BMD", "Lavrin3@i.ua", "Білослав", "Лобачевська", "проф.", "(066) 492-32-11", "Програміст", 19556.28m, "stable" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 19, 10, 8, 35, 918, DateTimeKind.Local).AddTicks(4451), "Вузька майдан, 667, Івано-Франківськ, Андорра", new DateTime(1999, 6, 12, 3, 33, 16, 252, DateTimeKind.Local).AddTicks(7273), "MWK", "Adriyan.Shiyan@ukr.net", new DateTime(2019, 9, 24, 5, 36, 19, 374, DateTimeKind.Local).AddTicks(1512), "Даромир", "Дмитришин", "канд. психол. наук", "(099) 330-70-82", "Секретар", 7161.09m, "functionalities" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 9, 11, 17, 12, 32, 999, DateTimeKind.Local).AddTicks(8337), "Винників майдан, 25, Біла Церква, Бенін", new DateTime(2011, 1, 26, 1, 28, 26, 773, DateTimeKind.Local).AddTicks(2693), "EGP", "Anastas61@meta.ua", "Яна", "Ялова", "канд. пед. наук", "(073) 426-02-82", "Секретар", 15310.99m, "Beauty, Health & Electronics" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 2, 14, 2, 57, 638, DateTimeKind.Local).AddTicks(8672), "Нижанківського майдан, 60, Східний Земислав, Монако", new DateTime(2012, 10, 15, 15, 27, 9, 763, DateTimeKind.Local).AddTicks(4810), "MZN", "Slavuta0@e-mail.ua", "Антонія", "Трясун", "докт. і. наук", "(063) 442-97-81", "Програміст", 14624.79m, "Cotton" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 14, 3, 30, 0, 920, DateTimeKind.Local).AddTicks(2007), "пров. Староміська, 6, Західний Мечислав, Естонія", new DateTime(1974, 8, 31, 11, 37, 59, 846, DateTimeKind.Local).AddTicks(6067), "CVE", "Yaroslava.Zlenko@i.ua", new DateTime(2021, 4, 2, 4, 14, 44, 938, DateTimeKind.Local).AddTicks(1590), "Владислав", "Барановський", "докт. і. наук", "(092) 303-56-28", "Секретар", 1578.54m, "intranet" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 27, 5, 0, 32, 322, DateTimeKind.Local).AddTicks(9161), "вул. Коліївщини, 374, Східний Мусій, Данія", new DateTime(1994, 5, 1, 12, 5, 40, 479, DateTimeKind.Local).AddTicks(1442), "DOP", "Yulianna84@i.ua", null, "Антін", "Марків", "канд. філол. наук", "(044) 273-02-52", "Бухгалтер", 11990.97m, "Granite" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 11, 15, 45, 49, 609, DateTimeKind.Local).AddTicks(4779), "вулиця Винників, 32, Біла Церква, Індія", new DateTime(1963, 12, 4, 3, 1, 22, 835, DateTimeKind.Local).AddTicks(8318), "MRO", "Ustim.Mogilevska@yandex.ua", null, "Добромира", "Щербак", "докт. юрид. наук", "(063) 722-25-00", "Прибиральник", 5660.90m, "Dale" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 11, 25, 4, 10, 16, 835, DateTimeKind.Local).AddTicks(3237), "вулиця Брюховичів, 7, Східний Любозар, Гана", new DateTime(1974, 9, 1, 6, 43, 41, 819, DateTimeKind.Local).AddTicks(4229), "TWD", "Zenovii82@gmail.com", new DateTime(2019, 5, 16, 18, 30, 31, 949, DateTimeKind.Local).AddTicks(8670), "Мальва", "Гладківський", "докт. пед. наук", "(063) 395-47-65", "Програміст", 3947.41m, "transmit" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 3, 13, 16, 32, 1, 661, DateTimeKind.Local).AddTicks(6212), "пров. Винників, 656, Слов’янськ, Російська Федерація", new DateTime(1989, 9, 16, 13, 5, 0, 136, DateTimeKind.Local).AddTicks(9583), "XBD", "Volodislav4@ukr.net", "Аврелія", "Зінкевич", "канд. техн. наук", "(094) 357-74-21", "Секретар", 5567.42m, "Wisconsin" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 5, 18, 19, 42, 39, 223, DateTimeKind.Local).AddTicks(7744), "вулиця Вічева, 12, Східний Валерій, Фіджі", new DateTime(1954, 10, 3, 4, 27, 42, 479, DateTimeKind.Local).AddTicks(9026), "LRD", "Vilenina84@i.ua", "Ада", "Горбач", "(092) 315-36-61", "Програміст", 7382.68m, "navigating" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 20, 7, 3, 28, 8, DateTimeKind.Local).AddTicks(6320), "Староміська майдан, 02, Бердичів, Ірак", new DateTime(1954, 11, 14, 7, 39, 26, 353, DateTimeKind.Local).AddTicks(3106), "ERN", "Irma.Galayenko79@ukr.net", "Біломир", "Коров’як", "докт. техн. наук", "(044) 818-89-87", "Прибиральник", 12594.50m, "Parkways" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 5, 18, 14, 44, 34, 221, DateTimeKind.Local).AddTicks(3004), "Нижанківського майдан, 99, Кременчук, Туреччина", new DateTime(2007, 9, 16, 20, 23, 1, 267, DateTimeKind.Local).AddTicks(5011), "QAR", "Bratislav33@ukr.net", "Ярема", "Савицький", "канд. філол. наук", "(073) 164-39-11", 8246.32m, "bypass" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 10, 11, 46, 30, 877, DateTimeKind.Local).AddTicks(3860), "пл. Молодіжна, 6, Макіївка, Узбекистан", new DateTime(1953, 4, 7, 18, 25, 49, 195, DateTimeKind.Local).AddTicks(6774), "PLN", "Borislav_Shestak@ukr.net", new DateTime(2020, 5, 23, 18, 57, 33, 913, DateTimeKind.Local).AddTicks(5814), "Сніжана", "Довгалевський", "канд. юрид. наук", "(063) 459-77-34", "Директор", 19222.85m, "Reduced" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 16, 15, 56, 25, 818, DateTimeKind.Local).AddTicks(5776), "площа Коліївщини, 6, Західний Пантелеймон, Чорногорія", new DateTime(1961, 10, 3, 14, 31, 38, 866, DateTimeKind.Local).AddTicks(8748), "CHF", "Vlad0@meta.ua", "Антон", "Сідляк", "докт. і. наук", "(073) 312-09-33", 15357.52m, "Intelligent Steel Bacon" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 11, 1, 29, 8, 487, DateTimeKind.Local).AddTicks(7656), "Зелена майдан, 99, Горлівка, Демократична Республіка Конго", new DateTime(1980, 8, 7, 8, 6, 58, 773, DateTimeKind.Local).AddTicks(6217), "BSD", "Yukhima42@meta.ua", new DateTime(2019, 12, 31, 13, 34, 16, 944, DateTimeKind.Local).AddTicks(3979), "Божен", "Опенько", "докт. філол. наук", "(094) 338-98-79", "Секретар", 13935.22m, "Functionality" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 22, 9, 30, 15, 517, DateTimeKind.Local).AddTicks(6852), "Городоцька майдан, 9, Київ, Киргизстан", new DateTime(1965, 2, 2, 17, 28, 59, 705, DateTimeKind.Local).AddTicks(2912), "MUR", "Anatoliya_Demkiv53@ukr.net", new DateTime(2019, 4, 26, 20, 36, 3, 441, DateTimeKind.Local).AddTicks(3994), "Ярослав", "Михайлюк", "канд. філол. наук", "(093) 951-55-35", "Секретар", 1602.34m, "Wisconsin" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 29, 11, 23, 21, 234, DateTimeKind.Local).AddTicks(2484), "Стрийська майдан, 678, Північний Зиновій, Нідерланди", new DateTime(1988, 12, 29, 9, 45, 39, 30, DateTimeKind.Local).AddTicks(7987), "LSL", "Oleksii_Petrenko46@gmail.com", new DateTime(2023, 10, 25, 5, 53, 53, 735, DateTimeKind.Local).AddTicks(4016), "Аврелій", "Гречко", "канд. психол. наук", "(044) 077-81-59", "Прибиральник", 17595.64m, "Generic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 4, 23, 18, 8, 6, 630, DateTimeKind.Local).AddTicks(6659), "вул. Брюховичів, 9, Південний Дарій, Австрія", new DateTime(2012, 11, 17, 6, 5, 14, 334, DateTimeKind.Local).AddTicks(4245), "EEK", "Krentta12@e-mail.ua", new DateTime(2019, 5, 4, 23, 10, 44, 707, DateTimeKind.Local).AddTicks(6345), "Тихон", "Кандиба", "докт. філос. наук", "(095) 766-16-42", "Секретар", 6515.37m, "index" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 3, 2, 11, 18, 29, 323, DateTimeKind.Local).AddTicks(8993), "Вузька майдан, 630, Керч, Чад", new DateTime(1989, 3, 1, 6, 13, 33, 725, DateTimeKind.Local).AddTicks(222), "IDR", "Diyana.Gamula42@ex.ua", null, "Анатолія", "Милославська", "докт. філос. наук", "(096) 688-80-93", "Програміст", 14014.62m, "indexing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 3, 9, 16, 15, 17, 474, DateTimeKind.Local).AddTicks(8031), "Стрийська майдан, 02, Артемівськ, Литва", new DateTime(2017, 10, 3, 0, 56, 30, 757, DateTimeKind.Local).AddTicks(5763), "LSL", "Potishana_Petrishina@ex.ua", null, "Златомир", "Майстренко", "докт. техн. наук", "(050) 470-44-77", "Бухгалтер", 1345.59m, "maroon" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 20, 1, 10, 8, 873, DateTimeKind.Local).AddTicks(7989), "провулок Вічева, 40, Бердянськ, Швеція", new DateTime(2012, 1, 2, 14, 49, 31, 391, DateTimeKind.Local).AddTicks(1036), "KWD", "Mokrina87@i.ua", "Фаїна", "Скоропадський", "докт. техн. наук", "(063) 028-73-65", "Директор", 14511.56m, "Garden" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 2, 1, 24, 12, 480, DateTimeKind.Local).AddTicks(1905), "Молодіжна майдан, 20, Східний Мечислав, Лівія", new DateTime(1995, 7, 10, 17, 46, 17, 120, DateTimeKind.Local).AddTicks(9754), "IDR", "Oresta_Likhno@meta.ua", "Славута", "Паламарчук", "канд. філос. наук", "(092) 557-05-30", "Бухгалтер", 10397.76m, "invoice" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 4, 4, 1, 3, 39, 934, DateTimeKind.Local).AddTicks(8465), "вулиця Рудного, 52, Східний Братослав, Нова Зеландія", new DateTime(2010, 12, 29, 7, 47, 58, 364, DateTimeKind.Local).AddTicks(7229), "RON", "Borislava_Balabukha31@ex.ua", new DateTime(2023, 5, 17, 13, 49, 24, 534, DateTimeKind.Local).AddTicks(929), "Ратимир", "Яворівський", "канд. техн. наук", "(091) 212-47-11", 17466.16m, "FTP" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 40, 58, 720, DateTimeKind.Local).AddTicks(7956), "Молодіжна майдан, 152, Рівне, Ізраїль", new DateTime(1994, 10, 3, 20, 52, 57, 494, DateTimeKind.Local).AddTicks(1390), "GEL", "Kharitina.Borovska35@ukr.net", new DateTime(2019, 12, 6, 19, 35, 27, 185, DateTimeKind.Local).AddTicks(5925), "Ладислав", "Єрмак", "доц.", "(066) 607-69-13", "Програміст", 10223.73m, "Ports" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 16, 15, 35, 59, 681, DateTimeKind.Local).AddTicks(8202), "пр. Городоцька, 36, Кіровоград, Чилі", new DateTime(1978, 7, 4, 3, 31, 28, 115, DateTimeKind.Local).AddTicks(9469), "MOP", "Zoreslav.Yalyuk21@yandex.ua", null, "Ярема", "Головець", "канд. філол. наук", "(098) 328-39-06", "Директор", 11065.07m, "Investor" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 7, 7, 41, 34, 192, DateTimeKind.Local).AddTicks(3340), "Стрийська майдан, 87, Південний Зеновій, Словаччина", new DateTime(1947, 10, 1, 13, 40, 56, 226, DateTimeKind.Local).AddTicks(3492), "XTS", "Bozhen.Palamarchuk@ex.ua", new DateTime(2022, 3, 10, 11, 27, 53, 786, DateTimeKind.Local).AddTicks(6225), "Радослава", "Михайлюк", "докт. політ. наук", "(097) 225-37-28", "Програміст", 9725.04m, "Small" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 14, 10, 45, 40, 222, DateTimeKind.Local).AddTicks(186), "Рудного майдан, 37, Північний Немир, Кіпр", new DateTime(1972, 10, 8, 8, 33, 27, 212, DateTimeKind.Local).AddTicks(6942), "AUD", "Vilena_Lakhman9@yandex.ua", null, "Августин", "Ликович", "докт. філол. наук", "(063) 393-43-29", "Прибиральник", 5269.43m, "Books, Books & Baby" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 4, 23, 18, 54, 3, 227, DateTimeKind.Local).AddTicks(6811), "Брюховичів майдан, 887, Кам’янець-Подільський, Папуа-Нова Гвінея", new DateTime(1968, 6, 15, 21, 20, 58, 802, DateTimeKind.Local).AddTicks(6858), "RUB", "Pilip75@meta.ua", new DateTime(2021, 1, 24, 5, 39, 35, 688, DateTimeKind.Local).AddTicks(2223), "Лаврін", "Гамула", "канд. техн. наук", "(093) 091-33-99", 13667.35m, "open-source" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 30, 11, 40, 50, 57, DateTimeKind.Local).AddTicks(6467), "Молодіжна майдан, 767, Лисичанськ, Алжир", new DateTime(1945, 12, 17, 2, 17, 41, 460, DateTimeKind.Local).AddTicks(4789), "NGN", "Askold94@e-mail.ua", "Слава", "Пендик", "канд. філос. наук", "(099) 566-37-22", "Директор", 17577.07m, "Savings Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 9, 22, 8, 54, 25, 400, DateTimeKind.Local).AddTicks(1620), "вулиця Ліста, 5, Івано-Франківськ, Ліберія", new DateTime(2019, 9, 5, 16, 51, 19, 758, DateTimeKind.Local).AddTicks(4420), "SBD", "Stanislava69@ex.ua", new DateTime(2022, 10, 17, 2, 32, 20, 278, DateTimeKind.Local).AddTicks(3005), "Афанасія", "Трясило", "докт. юрид. наук", "(097) 303-17-58", "Директор", 13846.29m, "compressing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 3, 9, 16, 5, 12, 150, DateTimeKind.Local).AddTicks(4611), "Староміська майдан, 6, Східний Горимир, Данія", new DateTime(1946, 4, 7, 7, 34, 12, 164, DateTimeKind.Local).AddTicks(750), "SVC", "Vitalina96@ukr.net", "Люборада", "Сосюра", "докт. і. наук", "(050) 061-84-38", "Прибиральник", 12127.18m, "structure" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 12, 27, 21, 33, 10, 416, DateTimeKind.Local).AddTicks(4128), "проспект Нижанківського, 47, Євпаторія, Аргентина", new DateTime(1993, 3, 26, 17, 22, 29, 522, DateTimeKind.Local).AddTicks(3028), "AMD", "Zakharii.Goiko@meta.ua", new DateTime(2021, 7, 14, 15, 1, 24, 899, DateTimeKind.Local).AddTicks(2446), "Руслана", "Ганич", "докт. філос. наук", "(063) 935-29-34", 4660.75m, "Product" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 11, 21, 19, 57, 2, 973, DateTimeKind.Local).AddTicks(3553), "Винників майдан, 421, Вінниця, Суринам", new DateTime(1980, 6, 14, 21, 3, 23, 793, DateTimeKind.Local).AddTicks(6158), "EEK", "Vita26@ex.ua", "Анастас", "Ромей", "канд. пед. наук", "(099) 392-56-39", 9465.20m, "Ergonomic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 8, 10, 19, 7, 2, 180, DateTimeKind.Local).AddTicks(6154), "вулиця Молодіжна, 8, Західний Кий, Португалія", new DateTime(1949, 7, 28, 9, 54, 19, 387, DateTimeKind.Local).AddTicks(1618), "XTS", "Fayina3@yandex.ua", null, "Остап", "Спотикач", "докт. філол. наук", "(095) 747-76-18", "Прибиральник", 11578.71m, "Berkshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 3, 6, 3, 15, 40, 577, DateTimeKind.Local).AddTicks(6486), "пр. Стрийська, 1, Сімферополь, Гватемала", new DateTime(1968, 12, 29, 17, 28, 37, 888, DateTimeKind.Local).AddTicks(2638), "TWD", "Svitlana.Petrenko@meta.ua", new DateTime(2023, 12, 14, 21, 9, 28, 233, DateTimeKind.Local).AddTicks(3698), "Яромил", "Приймак", "канд. політ. наук", "(094) 200-87-01", "Прибиральник", 19896.90m, "cutting-edge" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 20, 2, 42, 3, 99, DateTimeKind.Local).AddTicks(6793), "Вузька майдан, 14, Запоріжжя, Камбоджа", new DateTime(2001, 6, 23, 0, 22, 27, 378, DateTimeKind.Local).AddTicks(5444), "GMD", "Zabava.Skoropadska@i.ua", new DateTime(2023, 4, 29, 9, 58, 51, 494, DateTimeKind.Local).AddTicks(3725), "Гаврило", "Лугова", "докт. філос. наук", "(094) 320-18-15", "Секретар", 18507.41m, "Rubber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 24, 12, 57, 7, 242, DateTimeKind.Local).AddTicks(7288), "Молодіжна майдан, 91, Східний Омелян, Швеція", new DateTime(1979, 6, 28, 5, 38, 47, 890, DateTimeKind.Local).AddTicks(4473), "KGS", "Vsevolod65@i.ua", new DateTime(2023, 3, 9, 16, 15, 21, 512, DateTimeKind.Local).AddTicks(6101), "Горимир", "Корецький", "канд. і. наук", "(093) 459-48-22", "Секретар", 9338.85m, "Usability" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 52, 59, 361, DateTimeKind.Local).AddTicks(9095), "Городоцька майдан, 31, Західний Петро, Сан-Томе і Принсіпі", new DateTime(2018, 2, 9, 21, 36, 24, 12, DateTimeKind.Local).AddTicks(604), "TND", "Agripina95@e-mail.ua", "Георгій", "Міняйло", "докт. і. наук", "(095) 461-99-11", "Бухгалтер", 17459.81m, "Music" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 2, 3, 4, 22, 26, 901, DateTimeKind.Local).AddTicks(7110), "Ліста майдан, 75, Східний Горимир, Йорданія", new DateTime(1946, 5, 24, 18, 37, 7, 559, DateTimeKind.Local).AddTicks(2410), "BYR", "Bozhemir87@e-mail.ua", new DateTime(2022, 5, 10, 18, 52, 59, 229, DateTimeKind.Local).AddTicks(7760), "Ксенія", "Луцьків", "доц.", "(095) 230-34-74", "Директор", 1811.30m, "Guyana Dollar" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 18, 14, 57, 29, 303, DateTimeKind.Local).AddTicks(1318), "вул. Коліївщини, 382, Північний Боримир, Данія", new DateTime(1970, 7, 5, 21, 0, 25, 992, DateTimeKind.Local).AddTicks(9217), "TZS", "Diyana99@ex.ua", new DateTime(2022, 8, 24, 22, 36, 11, 694, DateTimeKind.Local).AddTicks(9038), "Болеслава", "Шухевич", "канд. юрид. наук", "(050) 484-59-57", "Прибиральник", 4043.02m, "morph" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 3, 0, 9, 53, 890, DateTimeKind.Local).AddTicks(672), "пр. Вічева, 820, Бровари, Монако", new DateTime(1991, 9, 1, 16, 13, 17, 964, DateTimeKind.Local).AddTicks(7225), "GBP", "Adam_Trublayevska@i.ua", new DateTime(2024, 1, 10, 16, 56, 40, 298, DateTimeKind.Local).AddTicks(9660), "Жанна", "Романів", "канд. філол. наук", "(092) 803-60-54", "Програміст", 14179.31m, "Auto Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 26, 13, 59, 32, 955, DateTimeKind.Local).AddTicks(7503), "Брюховичів майдан, 31, Черкаси, Кувейт", new DateTime(1967, 2, 20, 5, 22, 37, 949, DateTimeKind.Local).AddTicks(4181), "BHD", "Vasil8@e-mail.ua", null, "Вікторія", "Кордун", "канд. філол. наук", "(096) 819-69-23", "Бухгалтер", 13608.66m, "maximize" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 1, 34, 2, 85, DateTimeKind.Local).AddTicks(1520), "площа Коліївщини, 05, Північний Пилип, Коморські Острови", new DateTime(2019, 3, 16, 20, 33, 28, 661, DateTimeKind.Local).AddTicks(4139), "LBP", "Khristya89@meta.ua", "Немира", "Галаєнко", "докт. і. наук", "(096) 500-59-54", "Директор", 5619.87m, "Automotive" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 4, 3, 26, 59, 210, DateTimeKind.Local).AddTicks(6397), "Вічева майдан, 16, Шостка, Румунія", new DateTime(1953, 11, 29, 10, 36, 34, 566, DateTimeKind.Local).AddTicks(2452), "JMD", "Radimir.Kolomiyec10@yandex.ua", null, "Катерина", "Кульчицька", "докт. і. наук", "(092) 240-42-79", "Програміст", 16030.21m, "Trinidad and Tobago Dollar" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 29, 15, 26, 14, 105, DateTimeKind.Local).AddTicks(2529), "вул. Городоцька, 871, Східний Вадим, Нігерія", new DateTime(2003, 4, 11, 18, 31, 11, 649, DateTimeKind.Local).AddTicks(6123), "JOD", "Ratibor_Andrukhovich71@i.ua", new DateTime(2020, 12, 19, 17, 14, 20, 909, DateTimeKind.Local).AddTicks(2186), "Мар’ян", "Сосюра", "доц.", "(092) 331-33-21", "Бухгалтер", 19360.08m, "Borders" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 13, 5, 58, 4, 756, DateTimeKind.Local).AddTicks(8466), "провулок Вічева, 023, Східний Доброслав, Маврикій", new DateTime(1975, 2, 17, 21, 20, 7, 80, DateTimeKind.Local).AddTicks(8783), "XAG", "Ladislav61@gmail.com", null, "Семибор", "Петик", "(095) 924-99-30", "Директор", 17252.64m, "Trail" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 11, 14, 20, 33, 10, 398, DateTimeKind.Local).AddTicks(2584), "Брюховичів майдан, 202, Слов’янськ, Ефіопія", new DateTime(2017, 8, 2, 10, 3, 50, 638, DateTimeKind.Local).AddTicks(103), "INR", "Lyubomira_Shukhevich@i.ua", new DateTime(2023, 7, 6, 18, 36, 21, 169, DateTimeKind.Local).AddTicks(9069), "Божен", "Витребенько", "докт. пед. наук", "(095) 688-58-43", "Прибиральник", 14686.74m, "Extended" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 12, 3, 49, 26, 305, DateTimeKind.Local).AddTicks(7252), "пров. Брюховичів, 09, Макіївка, Нігер", new DateTime(1946, 7, 9, 11, 41, 5, 209, DateTimeKind.Local).AddTicks(3988), "MNT", "Avgustin.Gorodockii@e-mail.ua", "Чорнота", "Головець", "(092) 323-79-87", "Бухгалтер", 10721.68m, "Guam" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 4, 2, 20, 5, 131, DateTimeKind.Local).AddTicks(9882), "Брюховичів майдан, 5, Горлівка, Маврикій", new DateTime(1950, 5, 3, 10, 32, 48, 286, DateTimeKind.Local).AddTicks(453), "XBD", "Valentina.Gorova78@gmail.com", new DateTime(2024, 1, 12, 8, 38, 24, 700, DateTimeKind.Local).AddTicks(788), "Валерій", "Марків", "канд. філол. наук", "(092) 196-95-58", 14940.68m, "withdrawal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 30, 17, 55, 35, 714, DateTimeKind.Local).AddTicks(190), "Стрийська майдан, 3, Західний Всеслав, Сирія", new DateTime(1959, 1, 19, 0, 48, 25, 259, DateTimeKind.Local).AddTicks(8062), "XTS", "Diana_Cushko@yandex.ua", new DateTime(2019, 8, 22, 23, 22, 22, 600, DateTimeKind.Local).AddTicks(4793), "Добромисла", "Гарун", "канд. і. наук", "(093) 740-11-69", "Програміст", 2002.30m, "Falls" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 4, 9, 7, 59, 8, 919, DateTimeKind.Local).AddTicks(7904), "Вузька майдан, 4, Південний Златомир, Молдова", new DateTime(2020, 10, 27, 13, 51, 46, 391, DateTimeKind.Local).AddTicks(9696), "NOK", "Orislava91@ex.ua", null, "Антонида", "Латанська", "докт. психол. наук", "(096) 109-95-01", "Бухгалтер", 11191.34m, "Handcrafted Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 30, 44, 564, DateTimeKind.Local).AddTicks(7), "пр. Зелена, 02, Східний Іван, Швейцарія", new DateTime(2009, 12, 25, 2, 19, 56, 338, DateTimeKind.Local).AddTicks(4621), "XFU", "Zemislav26@yandex.ua", "Всевлад", "Бачей", "канд. юрид. наук", "(066) 936-03-95", "Прибиральник", 7714.95m, "Handmade Wooden Shirt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 8, 12, 13, 22, 15, 923, DateTimeKind.Local).AddTicks(6308), "Городоцька майдан, 557, Східний Максим, Ємен", new DateTime(1952, 10, 4, 16, 46, 6, 894, DateTimeKind.Local).AddTicks(297), "INR", "Georgii.Lobachevskii25@ukr.net", "Родіон", "Дмитришина", "докт. філос. наук", "(044) 354-45-83", "Директор", 19768.31m, "Mobility" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 33, 20, 34, DateTimeKind.Local).AddTicks(8290), "проспект Стрийська, 10, Північний Ярослав, Куба", new DateTime(1989, 2, 13, 21, 39, 5, 38, DateTimeKind.Local).AddTicks(1731), "GTQ", "Zhozefina_Babukh32@e-mail.ua", "Аврелія", "Хитрово", "проф.", "(091) 121-77-82", "Бухгалтер", 13071.65m, "portal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 4, 10, 50, 47, 667, DateTimeKind.Local).AddTicks(2930), "Нижанківського майдан, 137, Північний Анастас, Кувейт", new DateTime(1988, 12, 7, 3, 6, 48, 317, DateTimeKind.Local).AddTicks(3532), "KYD", "Bogdana54@yandex.ua", "Олександра", "Мазун", "докт. юрид. наук", "(099) 645-06-50", "Директор", 18969.95m, "navigate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 20, 9, 24, 37, 287, DateTimeKind.Local).AddTicks(109), "Зелена майдан, 616, Маріуполь, Камбоджа", new DateTime(1970, 11, 3, 3, 37, 7, 779, DateTimeKind.Local).AddTicks(3878), "ETB", "Violetta62@e-mail.ua", new DateTime(2024, 3, 26, 15, 4, 54, 690, DateTimeKind.Local).AddTicks(8058), "Любодар", "Потебенько", "канд. техн. наук", "(094) 113-16-15", "Прибиральник", 19373.39m, "Manager" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 13, 6, 8, 2, 43, DateTimeKind.Local).AddTicks(3539), "Рудного майдан, 616, Західний Мечислав, Самоа", new DateTime(1976, 11, 1, 4, 42, 55, 282, DateTimeKind.Local).AddTicks(2960), "EEK", "Zoreslava.Goiko32@yandex.ua", new DateTime(2020, 9, 9, 9, 31, 11, 552, DateTimeKind.Local).AddTicks(1916), "Герасим", "Третяк", "канд. пед. наук", "(073) 642-42-14", "Секретар", 11658.39m, "Kids, Home & Automotive" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 19, 9, 42, 56, 285, DateTimeKind.Local).AddTicks(5892), "вул. Коліївщини, 897, Східний Арсен, Папуа-Нова Гвінея", new DateTime(1964, 7, 16, 6, 10, 35, 646, DateTimeKind.Local).AddTicks(1204), "SAR", "Adam26@ex.ua", null, "Ладомир", "Шупик", "докт. пед. наук", "(063) 652-39-16", "Програміст", 4791.58m, "collaboration" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 13, 15, 15, 25, 975, DateTimeKind.Local).AddTicks(5588), "пр. Городоцька, 309, Північний Доброслав, Лесото", new DateTime(2009, 6, 20, 4, 52, 42, 217, DateTimeKind.Local).AddTicks(4551), "XOF", "Tayisiya_Romanishina25@ukr.net", new DateTime(2021, 12, 24, 2, 12, 32, 922, DateTimeKind.Local).AddTicks(3808), "Максим", "Сушко", "докт. психол. наук", "(095) 774-74-11", "Програміст", 5734.50m, "implement" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 4, 21, 50, 55, 267, DateTimeKind.Local).AddTicks(2533), "площа Нижанківського, 0, Єнакієве, Монако", new DateTime(2016, 1, 23, 6, 47, 6, 470, DateTimeKind.Local).AddTicks(7387), "SBD", "Boris15@e-mail.ua", new DateTime(2020, 12, 14, 13, 5, 18, 124, DateTimeKind.Local).AddTicks(631), "Анфіса", "Семеночко", "канд. психол. наук", "(092) 461-79-19", "Директор", 6973.77m, "Sleek" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 1, 13, 58, 30, 680, DateTimeKind.Local).AddTicks(6935), "пров. Брюховичів, 5, Південний Яромир, Хорватія", new DateTime(2000, 10, 26, 0, 31, 8, 511, DateTimeKind.Local).AddTicks(7695), "XBC", "Apolloniya63@e-mail.ua", null, "Корнилій", "Борецький", "докт. політ. наук", "(050) 184-61-67", "Бухгалтер", 6160.61m, "Silver" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 3, 21, 11, 10, 7, 901, DateTimeKind.Local).AddTicks(64), "вул. Брюховичів, 0, Західний Корнилій, Бельгія", new DateTime(1951, 9, 23, 14, 50, 31, 846, DateTimeKind.Local).AddTicks(5979), "PLN", "Likera.Kulchickii@gmail.com", new DateTime(2021, 3, 17, 11, 13, 29, 719, DateTimeKind.Local).AddTicks(5425), "Христя", "Линдик", "канд. політ. наук", "(050) 538-19-99", "Директор", 18762.47m, "Forks" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 20, 15, 50, 22, 488, DateTimeKind.Local).AddTicks(3153), "Коліївщини майдан, 36, Конотоп, Китай", new DateTime(1987, 5, 14, 21, 24, 28, 290, DateTimeKind.Local).AddTicks(3150), "CVE", "Oriyana_Dzyuba99@i.ua", new DateTime(2020, 6, 5, 13, 4, 49, 298, DateTimeKind.Local).AddTicks(2954), "Назарій", "Шудрик", "(073) 399-60-23", "Бухгалтер", 10135.14m, "Slovakia (Slovak Republic)" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 3, 6, 37, 7, 799, DateTimeKind.Local).AddTicks(4840), "вулиця Нижанківського, 1, Західний Боримисл, Руанда", new DateTime(1961, 3, 18, 1, 48, 59, 940, DateTimeKind.Local).AddTicks(885), "CUC", "Yukhimiya.Slobodyan@yandex.ua", null, "Назарій", "Гарай", "докт. юрид. наук", "(096) 637-86-60", "Програміст", 15110.66m, "Proactive" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 2, 11, 22, 38, 13, 266, DateTimeKind.Local).AddTicks(8996), "пр. Винників, 4, Житомир, Сент-Кітс і Невіс", new DateTime(2010, 5, 8, 11, 11, 54, 60, DateTimeKind.Local).AddTicks(7549), "OMR", "Semibor_Potockii@gmail.com", new DateTime(2020, 7, 21, 9, 17, 13, 462, DateTimeKind.Local).AddTicks(8770), "Агнеса", "Кордун", "канд. політ. наук", "(095) 766-02-02", "Бухгалтер", 19178.10m, "Tasty" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 10, 19, 17, 4, 251, DateTimeKind.Local).AddTicks(2097), "пл. Вічева, 277, Херсон, В’єтнам", new DateTime(2001, 5, 19, 20, 8, 58, 750, DateTimeKind.Local).AddTicks(2880), "NOK", "Kornelii77@meta.ua", "Зборислав", "Демчишин", "докт. техн. наук", "(091) 112-63-81", 3553.17m, "end-to-end" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 23, 23, 16, 45, 555, DateTimeKind.Local).AddTicks(2663), "Нижанківського майдан, 43, Північний Борислав, Швеція", new DateTime(1960, 7, 29, 17, 27, 29, 180, DateTimeKind.Local).AddTicks(1943), "ISK", "Ilona0@ex.ua", null, "Борис", "Мазун", "докт. і. наук", "(050) 465-74-23", "Програміст", 13449.56m, "Books" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 16, 23, 17, 54, 56, DateTimeKind.Local).AddTicks(8246), "Городоцька майдан, 4, Черкаси, Того", new DateTime(2021, 4, 16, 6, 15, 16, 153, DateTimeKind.Local).AddTicks(5451), "BIF", "Lyudomila20@yandex.ua", null, "Яромил", "Сушко", "канд. техн. наук", "(094) 218-58-91", "Програміст", 16428.09m, "ubiquitous" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 29, 6, 5, 11, 109, DateTimeKind.Local).AddTicks(5842), "Коліївщини майдан, 587, Західний Захарій, Того", new DateTime(1946, 5, 2, 9, 15, 26, 686, DateTimeKind.Local).AddTicks(6927), "HNL", "Dobroslava_Tryasilo@i.ua", null, "Данило", "Петришина", "докт. техн. наук", "(050) 948-40-62", "Директор", 1726.14m, "users" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 9, 18, 41, 3, 390, DateTimeKind.Local).AddTicks(6722), "пров. Вічева, 199, Східний Братислав, Ісландія", new DateTime(1951, 3, 22, 5, 26, 28, 117, DateTimeKind.Local).AddTicks(6466), "LTL", "Palazhka.Umanec79@gmail.com", new DateTime(2021, 4, 25, 21, 27, 16, 359, DateTimeKind.Local).AddTicks(418), "В’ячеслав", "Петик", "докт. юрид. наук", "(096) 435-26-56", "Програміст", 9606.43m, "mobile" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 19, 15, 43, 49, 549, DateTimeKind.Local).AddTicks(3867), "Староміська майдан, 751, Нікополь, Китай", new DateTime(1988, 9, 19, 5, 42, 27, 169, DateTimeKind.Local).AddTicks(7427), "BZD", "Roman94@ex.ua", new DateTime(2022, 10, 24, 18, 34, 4, 750, DateTimeKind.Local).AddTicks(3195), "Віленіна", "Стахів", "докт. психол. наук", "(044) 315-66-56", "Секретар", 12955.96m, "Consultant" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 1, 19, 6, 47, 697, DateTimeKind.Local).AddTicks(9620), "Вічева майдан, 6, Західний Костянтин, Ісландія", new DateTime(2017, 12, 19, 15, 6, 1, 345, DateTimeKind.Local).AddTicks(988), "CAD", "Oleksandr85@e-mail.ua", new DateTime(2021, 5, 11, 23, 15, 15, 844, DateTimeKind.Local).AddTicks(4963), "Павло", "Барановський", "докт. і. наук", "(098) 678-28-52", 6717.69m, "Refined" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 19, 14, 43, 55, 578, DateTimeKind.Local).AddTicks(6029), "Молодіжна майдан, 95, Західний Маркіян, Чорногорія", new DateTime(1977, 9, 9, 22, 46, 41, 335, DateTimeKind.Local).AddTicks(7568), "BHD", "Agafiya.Kompaniyec50@ukr.net", new DateTime(2020, 10, 21, 19, 25, 46, 33, DateTimeKind.Local).AddTicks(6065), "Любомила", "Шиян", "докт. філол. наук", "(063) 441-22-89", "Директор", 4621.92m, "Soft" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 4, 5, 41, 48, 215, DateTimeKind.Local).AddTicks(5068), "Винників майдан, 05, Донецьк, Ізраїль", new DateTime(1999, 5, 8, 21, 23, 39, 116, DateTimeKind.Local).AddTicks(8468), "BSD", "Borislava_Karpukh19@meta.ua", null, "Гелена", "Шестак", "канд. філос. наук", "(066) 954-00-09", 11829.98m, "navigate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 21, 22, 0, 21, 234, DateTimeKind.Local).AddTicks(6506), "вулиця Городоцька, 422, Західний Лук’ян, Пакистан", new DateTime(1944, 8, 15, 5, 38, 29, 815, DateTimeKind.Local).AddTicks(6948), "HKD", "Lavrin65@i.ua", new DateTime(2023, 8, 3, 12, 34, 38, 818, DateTimeKind.Local).AddTicks(8471), "Владислава", "Верещук", "канд. пед. наук", "(095) 046-01-75", "Секретар", 17879.38m, "Saint Lucia" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 5, 25, 12, 19, 17, 170, DateTimeKind.Local).AddTicks(4068), "Молодіжна майдан, 4, Північний Сологуб, Гондурас", new DateTime(1950, 1, 23, 16, 18, 40, 158, DateTimeKind.Local).AddTicks(1507), "EEK", "Vlasta_Polishuk@ukr.net", null, "Панас", "Зварич", "докт. пед. наук", "(066) 972-83-38", "Програміст", 7503.13m, "Money Market Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 3, 5, 9, 27, 45, 607, DateTimeKind.Local).AddTicks(1567), "провулок Коліївщини, 0, Горлівка, Узбекистан", new DateTime(1975, 3, 4, 1, 15, 3, 889, DateTimeKind.Local).AddTicks(9366), "QAR", "Makar_Banera@yandex.ua", new DateTime(2021, 11, 27, 19, 15, 23, 341, DateTimeKind.Local).AddTicks(9124), "Влада", "Кандиба", "канд. психол. наук", "(099) 791-35-55", "Прибиральник", 11217.47m, "Bulgarian Lev" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 2, 7, 15, 48, 38, 165, DateTimeKind.Local).AddTicks(3568), "пл. Вузька, 4, Євпаторія, США", new DateTime(2009, 11, 16, 14, 47, 20, 226, DateTimeKind.Local).AddTicks(7082), "CZK", "Bryachislav62@meta.ua", new DateTime(2022, 12, 9, 3, 51, 59, 473, DateTimeKind.Local).AddTicks(9864), "Звенислав", "Малкович", "докт. філос. наук", "(099) 575-11-66", "Директор", 16178.94m, "Forward" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 19, 7, 6, 14, 298, DateTimeKind.Local).AddTicks(5218), "пр. Нижанківського, 0, Східний Зорян, Південний Судан", new DateTime(2011, 11, 7, 16, 7, 54, 231, DateTimeKind.Local).AddTicks(3029), "CHF", "Yarema.Demkiv@ex.ua", new DateTime(2023, 12, 10, 6, 31, 3, 592, DateTimeKind.Local).AddTicks(4556), "Павліна", "Поривайло", "канд. психол. наук", "(096) 925-40-77", "Секретар", 5658.62m, "reboot" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 6, 10, 7, 8, 897, DateTimeKind.Local).AddTicks(6760), "пров. Винників, 4, Південний Корнелій, Шрі-Ланка", new DateTime(1973, 9, 9, 9, 47, 15, 39, DateTimeKind.Local).AddTicks(393), "DZD", "Lyubodar.Galayenko68@meta.ua", new DateTime(2022, 2, 13, 1, 4, 34, 697, DateTimeKind.Local).AddTicks(5046), "Данило", "Ялюк", "канд. і. наук", "(097) 647-45-41", "Секретар", 2105.28m, "invoice" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 7, 15, 28, 21, 548, DateTimeKind.Local).AddTicks(9801), "провулок Винників, 150, Єнакієве, Кенія", new DateTime(1975, 3, 7, 4, 58, 22, 221, DateTimeKind.Local).AddTicks(5873), "XAF", "Agniya8@i.ua", "Влада", "Павлишина", "канд. і. наук", "(098) 416-99-08", 11730.93m, "multi-byte" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 3, 17, 8, 50, 21, 163, DateTimeKind.Local).AddTicks(1516), "площа Винників, 31, Павлоград, Габон", new DateTime(1949, 10, 10, 1, 34, 29, 956, DateTimeKind.Local).AddTicks(52), "JPY", "Shastislav_Plaksii@i.ua", null, "Дарина", "Романишин", "докт. пед. наук", "(050) 525-87-82", "Бухгалтер", 9614.79m, "red" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 6, 14, 3, 17, 578, DateTimeKind.Local).AddTicks(2908), "пров. Вузька, 8, Північний Святослав, Монголія", new DateTime(1964, 3, 4, 13, 40, 37, 911, DateTimeKind.Local).AddTicks(5098), "KGS", "Nestor.Shindarei80@e-mail.ua", null, "Кузьма", "Шупик", "канд. політ. наук", "(097) 783-16-66", 9013.78m, "grey" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 7, 8, 31, 40, 651, DateTimeKind.Local).AddTicks(2417), "Зелена майдан, 184, Північний Руслан, Угорщина", new DateTime(1980, 2, 14, 0, 28, 39, 664, DateTimeKind.Local).AddTicks(9248), "ALL", "Motrya93@e-mail.ua", new DateTime(2021, 7, 26, 6, 36, 52, 853, DateTimeKind.Local).AddTicks(9772), "Діана", "Забіла", "докт. пед. наук", "(063) 057-96-00", 12499.25m, "Skyway" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 7, 12, 12, 55, 54, 634, DateTimeKind.Local).AddTicks(8401), "Винників майдан, 772, Північний Далемир, Сент-Люсія", new DateTime(1957, 1, 22, 7, 34, 54, 723, DateTimeKind.Local).AddTicks(4005), "YER", "Yuliya.Shestak@e-mail.ua", new DateTime(2021, 4, 23, 21, 9, 25, 437, DateTimeKind.Local).AddTicks(9491), "Ольга", "Іванишин", "докт. пед. наук", "(099) 930-31-95", 7494.59m, "Reduced" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 7, 25, 13, 42, 52, 632, DateTimeKind.Local).AddTicks(8718), "провулок Рудного, 033, Північний Костянтин, Тонга", new DateTime(1986, 8, 15, 2, 43, 54, 224, DateTimeKind.Local).AddTicks(7837), "MRO", "Makar63@i.ua", new DateTime(2020, 12, 2, 13, 59, 41, 355, DateTimeKind.Local).AddTicks(9119), "Яровид", "Гриневецький", "(093) 502-47-66", "Бухгалтер", 6145.84m, "world-class" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 7, 2, 22, 38, 692, DateTimeKind.Local).AddTicks(5783), "вулиця Вузька, 361, Північний Буревіст, Йорданія", new DateTime(2011, 10, 21, 18, 8, 28, 490, DateTimeKind.Local).AddTicks(4007), "RON", "Irina26@i.ua", new DateTime(2023, 4, 9, 2, 49, 53, 840, DateTimeKind.Local).AddTicks(7055), "Іннеса", "Мазун", "канд. юрид. наук", "(099) 767-08-73", "Секретар", 17017.97m, "applications" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 11, 14, 37, 31, 597, DateTimeKind.Local).AddTicks(5711), "пл. Ліста, 72, Євпаторія, Замбія", new DateTime(2008, 9, 25, 17, 3, 49, 583, DateTimeKind.Local).AddTicks(3684), "SCR", "Yuliya.Chervonii50@ukr.net", new DateTime(2023, 2, 12, 22, 18, 28, 444, DateTimeKind.Local).AddTicks(6339), "Зиновій", "Кивач", "докт. юрид. наук", "(099) 978-81-21", "Секретар", 10510.08m, "Producer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 17, 13, 8, 5, 377, DateTimeKind.Local).AddTicks(2093), "вулиця Рудного, 92, Південний Кий, Бутан", new DateTime(2023, 8, 19, 23, 1, 42, 230, DateTimeKind.Local).AddTicks(6651), "BOB", "Dobromir_Luchenko59@ex.ua", new DateTime(2019, 6, 8, 22, 41, 2, 589, DateTimeKind.Local).AddTicks(9273), "Натан", "Ярмак", "докт. філос. наук", "(063) 957-64-86", "Прибиральник", 5999.49m, "Legacy" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 30, 23, 42, 44, 653, DateTimeKind.Local).AddTicks(8119), "Брюховичів майдан, 869, Конотоп, Ямайка", new DateTime(2011, 12, 18, 7, 33, 49, 685, DateTimeKind.Local).AddTicks(4676), "TTD", "Zvenislav34@gmail.com", null, "Дарислава", "Шудрик", "(066) 128-84-98", "Бухгалтер", 10002.24m, "Tasty Frozen Car" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 7, 14, 26, 20, 778, DateTimeKind.Local).AddTicks(1095), "Нижанківського майдан, 292, Східний Яромил, Чилі", new DateTime(2013, 8, 7, 6, 15, 31, 283, DateTimeKind.Local).AddTicks(8733), "TZS", "Alevtin.Yushuk93@gmail.com", new DateTime(2024, 1, 8, 14, 18, 16, 4, DateTimeKind.Local).AddTicks(9994), "Милослава", "Галатей", "докт. політ. наук", "(098) 639-60-74", 2533.89m, "facilitate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 29, 12, 1, 44, 780, DateTimeKind.Local).AddTicks(4013), "пр. Винників, 573, Західний Потап, Чилі", new DateTime(1963, 2, 13, 2, 17, 15, 954, DateTimeKind.Local).AddTicks(7276), "MZN", "Anastasiya.Gaiova@gmail.com", new DateTime(2023, 3, 1, 7, 44, 22, 505, DateTimeKind.Local).AddTicks(4002), "Славомир", "Федоришина", "канд. техн. наук", "(099) 695-86-87", "Бухгалтер", 3669.72m, "asynchronous" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 9, 22, 40, 41, 913, DateTimeKind.Local).AddTicks(6902), "Вічева майдан, 83, Північний Славолюб, Мексика", new DateTime(1981, 11, 4, 10, 35, 37, 117, DateTimeKind.Local).AddTicks(2070), "MKD", "Bronislava.Stakhiv7@meta.ua", "Алевтина", "Гриневецький", "канд. політ. наук", "(095) 291-71-42", "Прибиральник", 10130.70m, "Beauty, Automotive & Grocery" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 16, 50, 535, DateTimeKind.Local).AddTicks(214), "вул. Рудного, 2, Північний Божен, Канада", new DateTime(1954, 9, 14, 1, 53, 57, 995, DateTimeKind.Local).AddTicks(8002), "MUR", "Zhozefina.Mogilevska86@yandex.ua", new DateTime(2020, 11, 28, 19, 0, 54, 433, DateTimeKind.Local).AddTicks(3206), "Ладо", "Гнатишин", "докт. пед. наук", "(050) 894-68-81", "Прибиральник", 14848.65m, "synergy" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 22, 16, 12, 24, 6, DateTimeKind.Local).AddTicks(7577), "Городоцька майдан, 273, Південний Ізяслав, Туреччина", new DateTime(1987, 7, 29, 6, 40, 21, 197, DateTimeKind.Local).AddTicks(3098), "ANG", "Vseslava.Makhno@meta.ua", new DateTime(2023, 11, 24, 8, 59, 9, 344, DateTimeKind.Local).AddTicks(2671), "Велемир", "Бердник", "канд. філос. наук", "(098) 827-57-25", "Програміст", 17221.65m, "evolve" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 4, 4, 54, 36, 885, DateTimeKind.Local).AddTicks(8249), "вулиця Зелена, 56, Красний Луч, Російська Федерація", new DateTime(1956, 3, 29, 12, 49, 59, 779, DateTimeKind.Local).AddTicks(5128), "KZT", "Alevtin24@yandex.ua", new DateTime(2020, 3, 8, 1, 35, 10, 69, DateTimeKind.Local).AddTicks(8901), "Купава", "Миклухо", "докт. філол. наук", "(098) 013-11-27", "Бухгалтер", 9210.91m, "wireless" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 13, 1, 24, 6, 383, DateTimeKind.Local).AddTicks(7024), "площа Зелена, 097, Східний Панас, Греція", new DateTime(1990, 7, 19, 20, 38, 49, 604, DateTimeKind.Local).AddTicks(4147), "XFU", "Alevtina.Babukh18@meta.ua", new DateTime(2023, 7, 3, 19, 6, 12, 254, DateTimeKind.Local).AddTicks(7455), "Станіслав", "Пендик", "докт. філол. наук", "(095) 070-28-41", "Бухгалтер", 18329.20m, "optical" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 11, 21, 12, 46, 954, DateTimeKind.Local).AddTicks(1640), "провулок Вузька, 5, Східний Василь, Коста-Рика", new DateTime(2013, 9, 4, 7, 21, 48, 427, DateTimeKind.Local).AddTicks(4833), "QAR", "Anastasiya_Kovalska@ukr.net", new DateTime(2023, 8, 23, 2, 4, 33, 644, DateTimeKind.Local).AddTicks(8644), "Фаїна", "Гайова", "канд. філос. наук", "(099) 386-11-49", "Секретар", 15622.24m, "bypassing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 3, 8, 877, DateTimeKind.Local).AddTicks(2497), "пров. Ліста, 86, Східний Мусій, Афганістан", new DateTime(1960, 6, 9, 0, 26, 3, 323, DateTimeKind.Local).AddTicks(6371), "LTL", "Dobroslava_Sherbak10@i.ua", new DateTime(2023, 12, 7, 17, 37, 19, 401, DateTimeKind.Local).AddTicks(8643), "Пелагея", "Палій", "канд. юрид. наук", "(044) 244-20-38", "Секретар", 1089.41m, "Global" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 25, 3, 56, 23, 134, DateTimeKind.Local).AddTicks(2841), "Молодіжна майдан, 2, Харків, Еритрея", new DateTime(1961, 6, 6, 12, 15, 49, 601, DateTimeKind.Local).AddTicks(8607), "MNT", "Apollinariya.Palamarchuk@yandex.ua", new DateTime(2023, 2, 23, 14, 26, 10, 829, DateTimeKind.Local).AddTicks(5860), "Братислав", "Балабан", "канд. техн. наук", "(091) 275-83-61", "Прибиральник", 13294.82m, "synergistic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 13, 0, 44, 38, 675, DateTimeKind.Local).AddTicks(2986), "Стрийська майдан, 4, Рівне, Кувейт", new DateTime(1987, 2, 8, 18, 38, 15, 758, DateTimeKind.Local).AddTicks(1124), "BYR", "Marina92@e-mail.ua", new DateTime(2019, 9, 5, 21, 58, 26, 323, DateTimeKind.Local).AddTicks(1297), "Роман", "Шевченко", "канд. техн. наук", "(044) 291-50-26", "Директор", 12863.50m, "Central" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 28, 10, 23, 8, 897, DateTimeKind.Local).AddTicks(8117), "Брюховичів майдан, 42, Павлоград, Лесото", new DateTime(2021, 8, 5, 18, 2, 2, 917, DateTimeKind.Local).AddTicks(3021), "ARS", "Arsenii51@yandex.ua", "Брячислав", "Барановська", "докт. техн. наук", "(098) 976-08-01", "Прибиральник", 5067.03m, "granular" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 47, 42, 149, DateTimeKind.Local).AddTicks(3102), "Ліста майдан, 38, Павлоград, Малі", new DateTime(1968, 10, 5, 6, 47, 29, 480, DateTimeKind.Local).AddTicks(3366), "BHD", "Gerasim_Vasilin53@e-mail.ua", new DateTime(2020, 2, 18, 4, 26, 27, 926, DateTimeKind.Local).AddTicks(7075), "Адам", "Трясило", "канд. і. наук", "(073) 957-91-15", "Секретар", 17848.78m, "Metal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 4, 5, 2, 12, 944, DateTimeKind.Local).AddTicks(1315), "Ліста майдан, 350, Луганськ, Домініка", new DateTime(2000, 7, 2, 17, 20, 50, 631, DateTimeKind.Local).AddTicks(6610), "CVE", "Alina31@i.ua", new DateTime(2023, 6, 3, 13, 58, 26, 465, DateTimeKind.Local).AddTicks(9850), "Лада", "Сучак", "докт. філол. наук", "(093) 405-00-37", 4432.74m, "Oman" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 4, 18, 21, 25, 56, 387, DateTimeKind.Local).AddTicks(1211), "Коліївщини майдан, 088, Львів, Туніс", new DateTime(1986, 6, 25, 23, 29, 14, 430, DateTimeKind.Local).AddTicks(6065), "MZN", "Radmila_Romanishin91@yandex.ua", new DateTime(2022, 12, 2, 7, 53, 11, 33, DateTimeKind.Local).AddTicks(7673), "Благовіста", "Сплюх", "проф.", "(098) 381-98-62", "Директор", 14368.01m, "fuchsia" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 12, 3, 21, 48, 15, 95, DateTimeKind.Local).AddTicks(8703), "Нижанківського майдан, 7, Керч, Об’єднані Арабські Емірати", new DateTime(1964, 12, 11, 14, 3, 1, 37, DateTimeKind.Local).AddTicks(790), "THB", "Violetta29@gmail.com", "Люборада", "Громико", "канд. і. наук", "(093) 132-78-19", "Бухгалтер", 9603.95m, "Inlet" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 11, 23, 16, 23, 838, DateTimeKind.Local).AddTicks(6480), "Молодіжна майдан, 859, Миколаїв, Фіджі", new DateTime(1963, 10, 15, 1, 15, 54, 557, DateTimeKind.Local).AddTicks(7442), "MKD", "Anna80@yandex.ua", new DateTime(2022, 5, 13, 22, 52, 49, 698, DateTimeKind.Local).AddTicks(6222), "Богуслава", "Корецька", "канд. психол. наук", "(063) 172-41-97", "Програміст", 3730.68m, "Generic Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 4, 21, 51, 40, 521, DateTimeKind.Local).AddTicks(7492), "Зелена майдан, 00, Північний Афанасій, Північна Корея", new DateTime(2004, 10, 29, 20, 56, 4, 602, DateTimeKind.Local).AddTicks(211), "GHS", "Tetyana_Gamula8@e-mail.ua", new DateTime(2021, 2, 9, 9, 39, 2, 859, DateTimeKind.Local).AddTicks(7425), "Антоніна", "Розпутня", "канд. психол. наук", "(050) 011-44-77", "Секретар", 13186.37m, "Macedonia" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 6, 4, 19, 25, 142, DateTimeKind.Local).AddTicks(2137), "Молодіжна майдан, 5, Миколаїв, Монголія", new DateTime(1976, 9, 2, 13, 52, 46, 348, DateTimeKind.Local).AddTicks(941), "THB", "Lyubomir78@i.ua", "Братослав", "Васильківський", "докт. філол. наук", "(050) 061-39-79", "Програміст", 17377.40m, "Steel" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 3, 5, 13, 57, 15, 894, DateTimeKind.Local).AddTicks(7458), "Брюховичів майдан, 95, Східний Братислав, Австрія", new DateTime(1961, 6, 18, 16, 35, 7, 243, DateTimeKind.Local).AddTicks(5208), "SYP", "Lyubomila.Yemec@gmail.com", null, "Глинський", "докт. пед. наук", "(094) 716-37-14", "Директор", 18186.29m, "Creative" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 12, 20, 51, 37, 21, DateTimeKind.Local).AddTicks(8547), "Вузька майдан, 2, Севастополь, Тринідад і Тобаго", new DateTime(2015, 5, 12, 4, 22, 15, 196, DateTimeKind.Local).AddTicks(9324), "PKR", "Nina82@meta.ua", new DateTime(2020, 6, 19, 3, 53, 56, 319, DateTimeKind.Local).AddTicks(323), "Всеволод", "Милославська", "докт. політ. наук", "(063) 925-20-89", 17304.40m, "Springs" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 28, 19, 45, 19, 144, DateTimeKind.Local).AddTicks(2769), "провулок Винників, 62, Маріуполь, Люксембург", new DateTime(2019, 5, 22, 22, 19, 35, 4, DateTimeKind.Local).AddTicks(9376), "XCD", "Anastasiya.Pasichnik84@gmail.com", new DateTime(2022, 4, 18, 1, 5, 18, 191, DateTimeKind.Local).AddTicks(6346), "Назар", "Павленко", "проф.", "(092) 435-60-01", "Бухгалтер", 15765.60m, "productize" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 1, 8, 6, 52, 31, 276, DateTimeKind.Local).AddTicks(374), "проспект Молодіжна, 621, Східний Ігор, Туреччина", new DateTime(1949, 5, 1, 14, 49, 28, 340, DateTimeKind.Local).AddTicks(3122), "ISK", "Apolloniya_Koman@ukr.net", new DateTime(2023, 7, 26, 3, 22, 13, 43, DateTimeKind.Local).AddTicks(3560), "Володимир", "Білич", "докт. і. наук", "(063) 597-34-34", "Директор", 5721.23m, "Texas" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 13, 23, 35, 41, 236, DateTimeKind.Local).AddTicks(9178), "пл. Ліста, 28, Івано-Франківськ, Камерун", new DateTime(1956, 1, 15, 19, 18, 29, 280, DateTimeKind.Local).AddTicks(7362), "USD", "Kseniya1@ukr.net", new DateTime(2022, 8, 6, 2, 1, 13, 425, DateTimeKind.Local).AddTicks(1838), "Віктор", "Третяк", "канд. юрид. наук", "(096) 056-50-63", "Директор", 3822.81m, "parse" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 11, 20, 13, 8, 48, 668, DateTimeKind.Local).AddTicks(7283), "пров. Винників, 28, Мелітополь, Монако", new DateTime(1999, 6, 5, 8, 15, 20, 365, DateTimeKind.Local).AddTicks(2702), "CNY", "Gorislav_Yushuk@gmail.com", new DateTime(2020, 1, 12, 22, 25, 31, 100, DateTimeKind.Local).AddTicks(4839), "Любислава", "Лазірко", "доц.", "(098) 663-02-07", "Директор", 6362.33m, "Games, Health & Outdoors" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 8, 13, 46, 38, 417, DateTimeKind.Local).AddTicks(9141), "проспект Городоцька, 88, Західний Олексій, Бурунді", new DateTime(1966, 2, 3, 19, 51, 23, 677, DateTimeKind.Local).AddTicks(7659), "FKP", "Antonii.Pavliv77@yandex.ua", new DateTime(2019, 8, 28, 19, 52, 24, 383, DateTimeKind.Local).AddTicks(9123), "Тиміш", "Янюк", "докт. пед. наук", "(066) 259-96-06", "Прибиральник", 12184.65m, "compelling" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 28, 3, 50, 14, 598, DateTimeKind.Local).AddTicks(801), "пр. Молодіжна, 6, Північний Тихон, Кот-д’Івуар", new DateTime(1951, 3, 16, 9, 38, 30, 562, DateTimeKind.Local).AddTicks(9522), "XDR", "Afanasiya_Lindik66@meta.ua", null, "Корнелій", "Шупик", "докт. психол. наук", "(098) 097-06-34", 19879.29m, "array" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 4, 8, 18, 30, 52, 771, DateTimeKind.Local).AddTicks(3855), "Рудного майдан, 05, Північний Далемир, Гаїті", new DateTime(1979, 5, 25, 8, 15, 2, 750, DateTimeKind.Local).AddTicks(9620), "RSD", "Kuzma87@meta.ua", new DateTime(2021, 2, 3, 17, 52, 35, 143, DateTimeKind.Local).AddTicks(7535), "Тетяна", "Шиндарей", "канд. пед. наук", "(066) 340-19-99", "Секретар", 9100.31m, "eyeballs" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 18, 8, 21, 4, 44, DateTimeKind.Local).AddTicks(1178), "Коліївщини майдан, 7, Південний Будимир, Багамські Острови", new DateTime(1995, 3, 24, 8, 58, 54, 491, DateTimeKind.Local).AddTicks(7723), "PKR", "Illya_Pavlenko@ukr.net", new DateTime(2019, 6, 3, 8, 57, 3, 4, DateTimeKind.Local).AddTicks(38), "Тамара", "Петришина", "доц.", "(092) 994-16-74", 18373.70m, "Senior" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 30, 12, 18, 10, 223, DateTimeKind.Local).AddTicks(9058), "Зелена майдан, 835, Тернопіль, Іспанія", new DateTime(1948, 6, 22, 5, 17, 40, 828, DateTimeKind.Local).AddTicks(2934), "GTQ", "Yana_Bilich@e-mail.ua", "Лада", "Троян", "докт. психол. наук", "(063) 190-66-20", "Секретар", 14891.03m, "Groves" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 12, 12, 9, 17, 54, 996, DateTimeKind.Local).AddTicks(4844), "Староміська майдан, 40, Красний Луч, Австралія", new DateTime(1989, 6, 29, 12, 16, 37, 495, DateTimeKind.Local).AddTicks(3319), "MRO", "Ruslan63@yandex.ua", new DateTime(2023, 11, 3, 17, 13, 42, 583, DateTimeKind.Local).AddTicks(792), "Звенимир", "Гамула", "канд. техн. наук", "(094) 239-33-42", "Прибиральник", 13412.87m, "Accountability" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 8, 31, 15, 47, 29, 63, DateTimeKind.Local).AddTicks(8093), "вул. Вічева, 24, Керч, Бельгія", new DateTime(1961, 1, 1, 14, 59, 48, 497, DateTimeKind.Local).AddTicks(4597), "ISK", "Yaroslava32@ex.ua", new DateTime(2019, 12, 21, 18, 27, 50, 958, DateTimeKind.Local).AddTicks(7944), "Петро", "Розпутній", "докт. філол. наук", "(098) 611-73-83", "Секретар", 1153.33m, "Club" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 6, 21, 16, 12, 523, DateTimeKind.Local).AddTicks(418), "Вічева майдан, 47, Біла Церква, Еквадор", new DateTime(1978, 10, 18, 9, 5, 10, 119, DateTimeKind.Local).AddTicks(8065), "PGK", "Arkadiya.Gladukh@yandex.ua", new DateTime(2021, 1, 30, 2, 17, 23, 187, DateTimeKind.Local).AddTicks(9565), "Братослав", "Балабуха", "докт. психол. наук", "(095) 564-57-33", "Секретар", 8915.71m, "enhance" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 3, 20, 10, 27, 42, 366, DateTimeKind.Local).AddTicks(5176), "пров. Молодіжна, 169, Східний Валентин, Данія", new DateTime(2004, 5, 25, 5, 24, 20, 241, DateTimeKind.Local).AddTicks(540), "PYG", "Rodoslav98@meta.ua", new DateTime(2020, 4, 29, 15, 38, 18, 643, DateTimeKind.Local).AddTicks(3964), "Немир", "Шупик", "канд. пед. наук", "(095) 718-96-90", "Директор", 5233.74m, "Frozen" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 9, 23, 6, 59, 50, 445, DateTimeKind.Local).AddTicks(1641), "проспект Староміська, 82, Олександрія, Камбоджа", new DateTime(1945, 7, 26, 1, 21, 52, 977, DateTimeKind.Local).AddTicks(3977), "LRD", "Azaliya.Borovskii71@ex.ua", "Мстислав", "Шестак", "проф.", "(093) 761-16-56", 19034.36m, "CSS" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 9, 15, 49, 16, 211, DateTimeKind.Local).AddTicks(2790), "провулок Винників, 3, Західний Августин, Сербія", new DateTime(2001, 6, 29, 16, 4, 52, 585, DateTimeKind.Local).AddTicks(546), "LBP", "Motrya86@yandex.ua", "Дарій", "Сосюра", "докт. філол. наук", "(098) 458-94-23", "Директор", 19113.46m, "customized" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 17, 15, 16, 50, 927, DateTimeKind.Local).AddTicks(4283), "Ліста майдан, 5, Східний Михайло, Нігерія", new DateTime(1995, 10, 1, 1, 49, 23, 855, DateTimeKind.Local).AddTicks(1983), "KMF", "Lavrin.Pogiba55@ukr.net", null, "Анатолій", "Вередун", "докт. техн. наук", "(098) 556-14-72", "Секретар", 13315.37m, "Generic Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 23, 15, 25, 26, 596, DateTimeKind.Local).AddTicks(9649), "пл. Молодіжна, 7, Західний Гаврило, Таїланд", new DateTime(1987, 12, 11, 3, 13, 11, 945, DateTimeKind.Local).AddTicks(3899), "XPT", "Galina.Moskalyuk@ex.ua", null, "Остап", "Савицька", "канд. філос. наук", "(093) 170-72-53", "Програміст", 15306.25m, "Checking Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 1, 10, 37, 39, 928, DateTimeKind.Local).AddTicks(1540), "Городоцька майдан, 03, Миколаїв, Сьєрра-Леоне", new DateTime(1951, 3, 19, 4, 43, 29, 172, DateTimeKind.Local).AddTicks(724), "BGN", "Bozhen_Semenochko41@meta.ua", new DateTime(2021, 2, 11, 2, 52, 39, 987, DateTimeKind.Local).AddTicks(8807), "Тиміш", "Гойко", "докт. техн. наук", "(066) 156-40-78", "Бухгалтер", 17928.02m, "Money Market Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 6, 16, 363, DateTimeKind.Local).AddTicks(571), "вулиця Молодіжна, 6, Львів, Федеративні Штати Мікронезії", new DateTime(1955, 11, 23, 16, 38, 58, 120, DateTimeKind.Local).AddTicks(7167), "SOS", "Rostislava_Sherbak@gmail.com", new DateTime(2023, 5, 3, 23, 22, 12, 328, DateTimeKind.Local).AddTicks(5475), "Данило", "Демчишина", "докт. політ. наук", "(094) 989-34-71", "Прибиральник", 2338.01m, "mobile" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 28, 12, 14, 55, 445, DateTimeKind.Local).AddTicks(6039), "Коліївщини майдан, 894, Західний Всеволод, Німеччина", new DateTime(2003, 1, 1, 1, 54, 32, 488, DateTimeKind.Local).AddTicks(8168), "SZL", "Miroslava.Semeshuk@e-mail.ua", null, "Божен", "Бандера", "канд. психол. наук", "(093) 108-60-79", "Директор", 1009.77m, "silver" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 14, 19, 2, 7, 540, DateTimeKind.Local).AddTicks(3910), "пл. Рудного, 61, Вінниця, Тринідад і Тобаго", new DateTime(1986, 10, 10, 10, 57, 48, 871, DateTimeKind.Local).AddTicks(104), "FJD", "Innesa.Likovich25@ex.ua", "Валентин", "Марків", "докт. філос. наук", "(097) 294-81-12", "Програміст", 13029.02m, "program" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 4, 1, 4, 50, 51, 469, DateTimeKind.Local).AddTicks(1554), "проспект Городоцька, 4, Донецьк, Велика Британія", new DateTime(2003, 10, 23, 13, 58, 59, 468, DateTimeKind.Local).AddTicks(7105), "KYD", "Avgustin64@e-mail.ua", "Всевлад", "Пригода", "докт. юрид. наук", "(050) 326-32-35", "Секретар", 17286.59m, "redundant" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 20, 4, 22, 41, 614, DateTimeKind.Local).AddTicks(818), "пров. Ліста, 1, Східний Георгій, Зімбабве", new DateTime(1946, 7, 27, 13, 25, 17, 692, DateTimeKind.Local).AddTicks(8989), "GEL", "Kharitina.Rozputnii45@ex.ua", null, "Хвалимир", "Корецький", "докт. політ. наук", "(099) 069-59-80", 10846.59m, "California" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 9, 15, 38, 57, 750, DateTimeKind.Local).AddTicks(5147), "Ліста майдан, 844, Ялта, Канада", new DateTime(1995, 8, 23, 4, 44, 35, 616, DateTimeKind.Local).AddTicks(921), "ALL", "Ratimir.Yavorivskii@ukr.net", new DateTime(2022, 7, 20, 9, 32, 29, 544, DateTimeKind.Local).AddTicks(3986), "Володислав", "Ящук", "канд. політ. наук", "(099) 738-56-13", "Програміст", 13740.46m, "payment" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 4, 23, 10, 4, 12, 215, DateTimeKind.Local).AddTicks(8756), "вул. Вузька, 3, Бердянськ, Того", new DateTime(1969, 1, 18, 22, 47, 37, 280, DateTimeKind.Local).AddTicks(1355), "BOB", "Zoryana.Golovec52@meta.ua", new DateTime(2024, 3, 15, 16, 57, 25, 766, DateTimeKind.Local).AddTicks(4777), "Зоремир", "Магера", "канд. пед. наук", "(097) 248-48-20", "Програміст", 11304.36m, "Senior" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 22, 7, 9, 54, 313, DateTimeKind.Local).AddTicks(7241), "Молодіжна майдан, 63, Південний Орхип, Еквадор", new DateTime(1968, 5, 29, 11, 59, 46, 644, DateTimeKind.Local).AddTicks(3741), "VEF", "Alla.Grigorishin45@i.ua", "Ада", "Калач", "докт. і. наук", "(093) 195-23-30", "Секретар", 15783.65m, "bandwidth" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 15, 7, 32, 2, 406, DateTimeKind.Local).AddTicks(6226), "вул. Городоцька, 7, Східний Борислав, Канада", new DateTime(1997, 6, 2, 15, 4, 30, 721, DateTimeKind.Local).AddTicks(2847), "STN", "Zoreslava43@gmail.com", new DateTime(2022, 12, 17, 17, 57, 38, 998, DateTimeKind.Local).AddTicks(4946), "Ігор", "Васильківський", "канд. техн. наук", "(050) 181-54-92", "Програміст", 2940.27m, "CSS" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 8, 8, 14, 49, 588, DateTimeKind.Local).AddTicks(4201), "провулок Стрийська, 518, Ужгород, Соломонові Острови", new DateTime(1988, 6, 30, 7, 8, 32, 219, DateTimeKind.Local).AddTicks(5604), "TZS", "Olga80@meta.ua", null, "Владислав", "Мазило", "(091) 282-15-68", "Прибиральник", 19542.83m, "indigo" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 4, 13, 15, 46, 839, DateTimeKind.Local).AddTicks(2225), "пров. Молодіжна, 244, Північний Зеновій, Сальвадор", new DateTime(2007, 2, 5, 2, 3, 17, 292, DateTimeKind.Local).AddTicks(6089), "ERN", "Milana_Openko53@ukr.net", new DateTime(2020, 9, 11, 6, 12, 44, 407, DateTimeKind.Local).AddTicks(8862), "Гаврило", "Яцьків", "канд. і. наук", "(094) 511-29-25", 1784.75m, "initiatives" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 30, 16, 40, 16, 488, DateTimeKind.Local).AddTicks(130), "Стрийська майдан, 210, Кривий Ріг, Чад", new DateTime(1946, 11, 25, 18, 1, 53, 111, DateTimeKind.Local).AddTicks(2540), "FKP", "Shastislav71@ex.ua", "Вілена", "Вергун", "проф.", "(050) 045-26-91", 15215.86m, "Avon" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 15, 3, 56, 9, 980, DateTimeKind.Local).AddTicks(7697), "пр. Зелена, 13, Східний Гліб, Антигуа і Барбуда", new DateTime(1984, 7, 7, 17, 48, 31, 336, DateTimeKind.Local).AddTicks(556), "VUV", "Bogdana.Tretyak@ex.ua", null, "Віктор", "Вередун", "канд. філол. наук", "(096) 393-43-88", 10245.74m, "intuitive" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 17, 59, 709, DateTimeKind.Local).AddTicks(3929), "вулиця Брюховичів, 97, Шостка, Кабо-Верде", new DateTime(1951, 2, 3, 16, 28, 42, 566, DateTimeKind.Local).AddTicks(6283), "RWF", "Zinovii_Vereshuk93@gmail.com", new DateTime(2021, 10, 25, 18, 21, 51, 529, DateTimeKind.Local).AddTicks(5032), "Борислава", "Шиян", "докт. філол. наук", "(099) 532-77-03", "Програміст", 13544.44m, "convergence" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 4, 22, 23, 53, 48, 147, DateTimeKind.Local).AddTicks(3249), "Брюховичів майдан, 80, Дніпродзержинськ, Кувейт", new DateTime(1977, 10, 2, 1, 15, 39, 675, DateTimeKind.Local).AddTicks(7044), "XTS", "Vilenina_Zvarich@i.ua", new DateTime(2022, 4, 28, 17, 8, 6, 410, DateTimeKind.Local).AddTicks(2684), "Гелена", "Москаль", "докт. техн. наук", "(099) 704-27-40", "Директор", 6834.41m, "Won" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 23, 2, 48, 13, 247, DateTimeKind.Local).AddTicks(5539), "Коліївщини майдан, 87, Хмельницький, Нова Зеландія", new DateTime(1976, 1, 2, 15, 10, 5, 318, DateTimeKind.Local).AddTicks(8062), "EGP", "Sologub.Yukhno@ukr.net", null, "Матвій", "Іванишина", "докт. техн. наук", "(091) 067-41-61", "Програміст", 13134.91m, "synthesizing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 29, 20, 57, 0, 412, DateTimeKind.Local).AddTicks(4434), "пр. Брюховичів, 42, Житомир, Панама", new DateTime(1963, 9, 9, 1, 13, 31, 345, DateTimeKind.Local).AddTicks(5839), "KRW", "Zenovii.Storchak@i.ua", null, "Ратибор", "Михайлюк", "проф.", "(097) 719-50-32", "Директор", 9651.69m, "bluetooth" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 11, 19, 18, 33, 14, 900, DateTimeKind.Local).AddTicks(8618), "Вічева майдан, 5, Східний Ладомир, Фіджі", new DateTime(1946, 6, 26, 17, 53, 4, 675, DateTimeKind.Local).AddTicks(3832), "ANG", "Irina.Savicka26@ukr.net", "Анжела", "Латанський", "докт. юрид. наук", "(096) 843-05-03", 7128.55m, "extend" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 31, 2, 0, 44, 466, DateTimeKind.Local).AddTicks(8144), "пров. Вузька, 81, Слов’янськ, Шрі-Ланка", new DateTime(1964, 6, 16, 18, 14, 26, 561, DateTimeKind.Local).AddTicks(5204), "PKR", "Zhanna.Goiko67@yandex.ua", new DateTime(2021, 11, 3, 14, 21, 48, 896, DateTimeKind.Local).AddTicks(7255), "Віола", "Стоян", "канд. пед. наук", "(073) 964-55-21", "Прибиральник", 5339.88m, "withdrawal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 19, 0, 2, 38, 363, DateTimeKind.Local).AddTicks(2832), "пл. Стрийська, 744, Горлівка, Сенеґал", new DateTime(1961, 12, 2, 20, 16, 36, 747, DateTimeKind.Local).AddTicks(2165), "DZD", "Gordii_Latanska86@e-mail.ua", "Іннеса", "Демчишина", "канд. пед. наук", "(063) 933-22-07", "Прибиральник", 9038.11m, "Handmade Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 23, 0, 26, 41, 135, DateTimeKind.Local).AddTicks(4625), "провулок Винників, 174, Дніпропетровськ, Нігерія", new DateTime(1956, 9, 22, 14, 10, 24, 63, DateTimeKind.Local).AddTicks(9233), "GTQ", "Vladislav.Shukhevich96@ukr.net", new DateTime(2020, 10, 3, 11, 35, 14, 749, DateTimeKind.Local).AddTicks(6134), "Катерина", "Скиба", "доц.", "(044) 740-32-75", "Бухгалтер", 19767.86m, "Myanmar" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 27, 6, 28, 31, 665, DateTimeKind.Local).AddTicks(2953), "проспект Вузька, 7, Ялта, Еквадор", new DateTime(1992, 5, 27, 9, 10, 58, 863, DateTimeKind.Local).AddTicks(3825), "ISK", "Darina7@e-mail.ua", null, "Варвара", "Сосюра", "канд. юрид. наук", "(095) 962-34-48", "Бухгалтер", 8396.90m, "PNG" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 1, 18, 13, 27, 45, 126, DateTimeKind.Local).AddTicks(7279), "вулиця Городоцька, 15, Севастополь, Болгарія", new DateTime(1989, 11, 16, 12, 35, 52, 849, DateTimeKind.Local).AddTicks(5103), "EUR", "Palazhka_Karpukh@gmail.com", new DateTime(2022, 4, 9, 23, 47, 0, 54, DateTimeKind.Local).AddTicks(7155), "Боримир", "канд. пед. наук", "(094) 701-64-01", "Програміст", 13840.40m, "Principal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 11, 16, 18, 10, 21, 526, DateTimeKind.Local).AddTicks(9104), "Винників майдан, 02, Південний Лаврентій, Бангладеш", new DateTime(1972, 4, 9, 10, 14, 31, 189, DateTimeKind.Local).AddTicks(2844), "SHP", "Polyana.Tkachenko@ex.ua", "Омелян", "Гайдук", "докт. політ. наук", "(092) 133-18-25", "Програміст", 10055.99m, "magenta" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 3, 12, 2, 45, 9, 971, DateTimeKind.Local).AddTicks(9524), "площа Вічева, 34, Красний Луч, Замбія", new DateTime(1964, 1, 29, 5, 49, 23, 932, DateTimeKind.Local).AddTicks(1432), "RON", "Lyubomir33@ukr.net", null, "Омелян", "Скиба", "проф.", "(073) 821-70-14", "Прибиральник", 16408.18m, "Awesome Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 15, 0, 33, 46, 354, DateTimeKind.Local).AddTicks(5005), "провулок Брюховичів, 4, Миколаїв, Туркменістан", new DateTime(1952, 3, 21, 22, 47, 32, 834, DateTimeKind.Local).AddTicks(598), "UGX", "Alla_Makovecka51@ex.ua", new DateTime(2020, 2, 15, 0, 27, 10, 701, DateTimeKind.Local).AddTicks(8636), "Віленіна", "Мазун", "докт. політ. наук", "(091) 517-27-25", "Секретар", 6850.40m, "Kazakhstan" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 11, 22, 19, 59, 54, 111, DateTimeKind.Local).AddTicks(2468), "провулок Рудного, 301, Сєвєродонецьк, Гватемала", new DateTime(1984, 7, 31, 9, 44, 43, 881, DateTimeKind.Local).AddTicks(7904), "ZWL", "Yuliya_Palii@ex.ua", "Стефаній", "Майборода", "докт. психол. наук", "(097) 554-76-26", 14335.51m, "Lead" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 14, 0, 25, 51, 477, DateTimeKind.Local).AddTicks(3738), "пров. Зелена, 47, Нікополь, Македонія", new DateTime(1996, 5, 23, 16, 50, 21, 120, DateTimeKind.Local).AddTicks(2363), "ERN", "Zvenislav2@ukr.net", "Марта", "Романів", "канд. психол. наук", "(095) 667-00-25", 9382.22m, "Buckinghamshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 10, 18, 30, 29, 239, DateTimeKind.Local).AddTicks(8348), "пр. Рудного, 7, Північний Олег, Соломонові Острови", new DateTime(1966, 11, 1, 17, 31, 37, 484, DateTimeKind.Local).AddTicks(6787), "XOF", "Zoryana_Mazilo95@i.ua", new DateTime(2020, 3, 18, 6, 8, 42, 679, DateTimeKind.Local).AddTicks(5921), "Марія", "Корецький", "докт. техн. наук", "(096) 474-56-09", 8560.29m, "quantifying" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 14, 19, 31, 53, 374, DateTimeKind.Local).AddTicks(7506), "Староміська майдан, 72, Південний Ярослав, Габон", new DateTime(2007, 6, 11, 8, 16, 31, 287, DateTimeKind.Local).AddTicks(8975), "SOS", "Bogdan5@meta.ua", new DateTime(2020, 8, 18, 9, 12, 32, 247, DateTimeKind.Local).AddTicks(6063), "Зборислав", "Мотрієнко", "доц.", "(094) 933-88-99", "Секретар", 3053.60m, "payment" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 1, 31, 1, 40, 34, 945, DateTimeKind.Local).AddTicks(5651), "проспект Винників, 651, Шостка, Барбадос", new DateTime(2005, 6, 21, 19, 57, 14, 44, DateTimeKind.Local).AddTicks(1697), "BHD", "Avrora.Vitryak@yandex.ua", null, "Любомира", "Уманець", "докт. політ. наук", "(094) 247-00-38", "Програміст", 14012.31m, "Electronics & Automotive" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 4, 19, 16, 23, 24, 370, DateTimeKind.Local).AddTicks(6306), "Вузька майдан, 60, Північний Устим, Кабо-Верде", new DateTime(1946, 6, 30, 20, 19, 47, 622, DateTimeKind.Local).AddTicks(3959), "TJS", "Radmila_Minyailo75@ex.ua", "Чорнота", "Коваленко", "канд. політ. наук", "(063) 938-58-17", "Секретар", 16638.25m, "Generic Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 14, 3, 56, 30, 8, DateTimeKind.Local).AddTicks(1400), "Городоцька майдан, 1, Херсон, Молдова", new DateTime(1987, 2, 12, 10, 49, 52, 518, DateTimeKind.Local).AddTicks(369), "TMT", "Boris.Spotikach@yandex.ua", new DateTime(2020, 4, 27, 8, 9, 7, 650, DateTimeKind.Local).AddTicks(2052), "Ніна", "Янюк", "канд. філос. наук", "(050) 118-99-67", "Прибиральник", 19150.34m, "Forward" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 15, 3, 2, 24, 717, DateTimeKind.Local).AddTicks(9338), "пров. Винників, 5, Полтава, Єгипет", new DateTime(2015, 8, 4, 11, 48, 21, 220, DateTimeKind.Local).AddTicks(5663), "ZMK", "Gordii85@ukr.net", new DateTime(2023, 9, 12, 23, 29, 42, 242, DateTimeKind.Local).AddTicks(3975), "Альвіна", "Бамбула", "канд. філол. наук", "(066) 897-01-83", "Прибиральник", 11689.89m, "SMS" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 5, 3, 16, 13, 54, 249, DateTimeKind.Local).AddTicks(3136), "пр. Зелена, 0, Рівне, Аргентина", new DateTime(1998, 10, 29, 5, 36, 56, 348, DateTimeKind.Local).AddTicks(4163), "HNL", "Bratimir_Vasilishina@meta.ua", new DateTime(2022, 12, 20, 14, 21, 6, 136, DateTimeKind.Local).AddTicks(4103), "Ростислава", "Шкараба", "доц.", "(073) 827-14-36", "Директор", 10133.96m, "Licensed Metal Chips" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 4, 24, 3, 37, 44, 498, DateTimeKind.Local).AddTicks(2504), "Ліста майдан, 406, Маріуполь, Кірибаті", new DateTime(1990, 12, 4, 2, 29, 38, 351, DateTimeKind.Local).AddTicks(6598), "SDG", "Okhrim_Petrishina@gmail.com", null, "Тихон", "Ромей", "докт. і. наук", "(098) 445-97-29", "Секретар", 15717.47m, "Fundamental" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 12, 7, 15, 13, 11, 255, DateTimeKind.Local).AddTicks(3739), "Молодіжна майдан, 120, Західний Денис, Маршаллові Острови", new DateTime(2016, 9, 22, 15, 23, 24, 597, DateTimeKind.Local).AddTicks(1748), "XAF", "Dolyana_Vereshuk@ex.ua", new DateTime(2020, 2, 21, 19, 19, 31, 818, DateTimeKind.Local).AddTicks(4070), "Маркіян", "Усич", "канд. техн. наук", "(097) 181-69-35", "Директор", 13838.45m, "Lead" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 1, 3, 17, 17, 0, 445, DateTimeKind.Local).AddTicks(4118), "площа Вузька, 6, Північний Тимофій, Малаві", new DateTime(2012, 12, 19, 22, 33, 15, 679, DateTimeKind.Local).AddTicks(8589), "BND", "Klavdiya35@e-mail.ua", new DateTime(2024, 1, 22, 22, 47, 58, 686, DateTimeKind.Local).AddTicks(761), "Добромира", "Лученко", "докт. і. наук", "(092) 234-47-35", "Секретар", 6216.22m, "Borders" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 17, 4, 36, 23, 519, DateTimeKind.Local).AddTicks(9155), "Городоцька майдан, 42, Запоріжжя, Антигуа і Барбуда", new DateTime(1987, 11, 21, 20, 58, 41, 81, DateTimeKind.Local).AddTicks(2506), "MDL", "Dobroslava.Kovalenko@yandex.ua", new DateTime(2020, 7, 12, 6, 55, 37, 710, DateTimeKind.Local).AddTicks(8686), "Валерій", "Петрів", "проф.", "(050) 549-11-54", "Програміст", 2622.07m, "enable" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 20, 8, 37, 9, 304, DateTimeKind.Local).AddTicks(2279), "Винників майдан, 5, Північний Владислав, Саудівська Аравія", new DateTime(1991, 7, 26, 8, 50, 48, 509, DateTimeKind.Local).AddTicks(9578), "YER", "Maryana_Stepanec61@i.ua", new DateTime(2021, 1, 26, 3, 56, 38, 840, DateTimeKind.Local).AddTicks(5400), "Ладислав", "Скиба", "канд. техн. наук", "(063) 116-32-81", "Прибиральник", 16224.77m, "Practical Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 4, 23, 5, 20, 35, 225, DateTimeKind.Local).AddTicks(4173), "пров. Брюховичів, 94, Умань, Індія", new DateTime(2006, 7, 27, 4, 17, 29, 129, DateTimeKind.Local).AddTicks(8674), "ERN", "Zvenimir87@gmail.com", new DateTime(2023, 12, 10, 22, 15, 6, 81, DateTimeKind.Local).AddTicks(6881), "Ігор", "Яловий", "канд. пед. наук", "(097) 301-76-53", 14448.23m, "Syrian Pound" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 29, 0, 6, 16, 824, DateTimeKind.Local).AddTicks(508), "Нижанківського майдан, 31, Південний Павло, Багамські Острови", new DateTime(1976, 9, 12, 3, 7, 31, 22, DateTimeKind.Local).AddTicks(1687), "NPR", "Viola_Koreckii47@meta.ua", "Добринка", "Осадко", "докт. психол. наук", "(063) 767-04-71", 13745.23m, "Public-key" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 13, 9, 20, 28, 510, DateTimeKind.Local).AddTicks(7384), "вулиця Брюховичів, 3, Північний Всеслав, Сальвадор", new DateTime(1954, 8, 15, 10, 54, 56, 811, DateTimeKind.Local).AddTicks(3294), "ALL", "Stanislava_Yackiv45@e-mail.ua", new DateTime(2019, 8, 12, 11, 27, 6, 591, DateTimeKind.Local).AddTicks(3253), "Віолетта", "Борецький", "докт. філос. наук", "(098) 546-36-07", 2214.06m, "Iraqi Dinar" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 13, 4, 53, 32, 272, DateTimeKind.Local).AddTicks(281), "Коліївщини майдан, 161, Східний Мечислав, Чилі", new DateTime(1949, 5, 30, 4, 42, 43, 400, DateTimeKind.Local).AddTicks(9323), "VND", "Ruslana88@yandex.ua", new DateTime(2019, 9, 18, 12, 23, 2, 345, DateTimeKind.Local).AddTicks(7380), "Огняна", "Шиндарей", "докт. і. наук", "(063) 232-56-57", "Бухгалтер", 5251.78m, "Crescent" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 7, 13, 10, 58, 23, 708, DateTimeKind.Local).AddTicks(3359), "вулиця Староміська, 8, Західний Олелько, Сомалі", new DateTime(2023, 4, 14, 14, 32, 23, 416, DateTimeKind.Local).AddTicks(1804), "MUR", "Stanislav.Kovalska@yandex.ua", new DateTime(2020, 6, 26, 5, 49, 23, 805, DateTimeKind.Local).AddTicks(7618), "Зеновій", "Шумило", "докт. пед. наук", "(099) 357-31-44", 16564.12m, "Argentine Peso" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 8, 21, 34, 50, 938, DateTimeKind.Local).AddTicks(8629), "проспект Нижанківського, 10, Південний Звенислав, Румунія", new DateTime(1945, 7, 15, 7, 17, 36, 401, DateTimeKind.Local).AddTicks(5259), "KWD", "Shastislav37@i.ua", "Любозар", "Латан", "(050) 504-61-66", "Прибиральник", 5987.41m, "e-commerce" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 22, 1, 31, 4, 612, DateTimeKind.Local).AddTicks(8564), "площа Староміська, 99, Південний Богдан, Йорданія", new DateTime(1977, 3, 27, 0, 47, 31, 298, DateTimeKind.Local).AddTicks(595), "UYU", "Anastasii.Lyashuk@i.ua", null, "Калина", "Стигайло", "проф.", "(092) 095-59-63", "Програміст", 3033.26m, "algorithm" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 11, 14, 23, 6, 132, DateTimeKind.Local).AddTicks(9351), "Городоцька майдан, 8, Павлоград, Гренада", new DateTime(1956, 10, 1, 16, 10, 5, 832, DateTimeKind.Local).AddTicks(4583), "GMD", "Kharitina_Sidlyak@ukr.net", "Клавдія", "Малкович", "докт. пед. наук", "(073) 541-08-42", 3305.42m, "quantifying" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 3, 25, 22, 29, 18, 568, DateTimeKind.Local).AddTicks(3057), "площа Брюховичів, 632, Західний Мар’ян, Сінгапур", new DateTime(2007, 7, 11, 17, 14, 48, 105, DateTimeKind.Local).AddTicks(8299), "SRD", "Ruslan70@ex.ua", null, "Людмила", "Балицька", "канд. філол. наук", "(094) 716-63-16", "Директор", 15090.48m, "Multi-layered" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 6, 1, 39, 44, 467, DateTimeKind.Local).AddTicks(4604), "Стрийська майдан, 605, Західний Олександр, Азербайджан", new DateTime(1981, 12, 27, 5, 7, 45, 702, DateTimeKind.Local).AddTicks(4615), "AZN", "Virginiya.Semenochko@ex.ua", null, "Крентта", "Коров’як", "докт. техн. наук", "(073) 991-65-37", "Секретар", 15476.95m, "Liechtenstein" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 2, 11, 46, 49, 450, DateTimeKind.Local).AddTicks(3334), "пл. Ліста, 633, Західний Вадим, Угорщина", new DateTime(1946, 10, 25, 7, 44, 23, 489, DateTimeKind.Local).AddTicks(5414), "KZT", "Oles_Borecka@i.ua", new DateTime(2019, 11, 18, 17, 32, 39, 468, DateTimeKind.Local).AddTicks(7491), "Мечислава", "Зленко", "канд. філол. наук", "(097) 075-88-50", 7143.01m, "compressing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 3, 15, 10, 18, 4, 475, DateTimeKind.Local).AddTicks(9695), "площа Коліївщини, 6, Луцьк, Екваторіальна Гвінея", new DateTime(1948, 6, 25, 18, 59, 26, 796, DateTimeKind.Local).AddTicks(8594), "XAU", "Glib_Maiboroda@ukr.net", "Яромил", "Гарун", "канд. психол. наук", "(050) 829-60-83", "Директор", 4645.23m, "info-mediaries" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 1, 12, 3, 23, 44, 729, DateTimeKind.Local).AddTicks(384), "пл. Брюховичів, 409, Західний Адріян, Центральноафриканська Республіка", new DateTime(1992, 9, 29, 13, 29, 20, 870, DateTimeKind.Local).AddTicks(2230), "LSL", "Stepan80@meta.ua", null, "Руслана", "Павлишина", "доц.", "(066) 186-45-43", 5380.01m, "system-worthy" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 2, 1, 0, 57, 899, DateTimeKind.Local).AddTicks(6310), "пл. Брюховичів, 393, Східний Мстислав, Сінгапур", new DateTime(1998, 6, 26, 4, 10, 2, 894, DateTimeKind.Local).AddTicks(9469), "ETB", "Afanasiya82@meta.ua", null, "В’ячеслав", "Бердник", "доц.", "(091) 619-82-19", "Бухгалтер", 3583.47m, "Euro" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 2, 15, 15, 59, 24, 778, DateTimeKind.Local).AddTicks(8886), "пр. Вічева, 3, Лисичанськ, Шрі-Ланка", new DateTime(2015, 7, 25, 0, 44, 38, 655, DateTimeKind.Local).AddTicks(8976), "DZD", "Listvich.Yanyuk19@e-mail.ua", new DateTime(2020, 2, 10, 4, 43, 21, 777, DateTimeKind.Local).AddTicks(6103), "Анастасій", "Маринич", "докт. філол. наук", "(099) 189-15-18", 16602.77m, "Handcrafted" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 25, 1, 5, 18, 194, DateTimeKind.Local).AddTicks(95), "вул. Вузька, 725, Західний Вадим, Чад", new DateTime(1980, 3, 30, 23, 21, 9, 471, DateTimeKind.Local).AddTicks(3268), "KHR", "Larisa.Mazailo@gmail.com", new DateTime(2021, 7, 30, 7, 9, 2, 362, DateTimeKind.Local).AddTicks(1305), "Всеслава", "Стоян", "канд. юрид. наук", "(094) 536-54-87", "Бухгалтер", 8513.89m, "bluetooth" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 20, 19, 36, 51, 672, DateTimeKind.Local).AddTicks(7433), "пров. Зелена, 708, Макіївка, Бутан", new DateTime(1975, 1, 24, 9, 11, 48, 486, DateTimeKind.Local).AddTicks(4763), "UAH", "Radoslava47@ukr.net", "Ростислава", "Бондаренко", "канд. і. наук", "(093) 195-54-71", 14404.83m, "revolutionary" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 27, 10, 32, 38, 719, DateTimeKind.Local).AddTicks(6614), "Рудного майдан, 7, Південний Мстислав, Колумбія", new DateTime(2022, 3, 8, 2, 11, 53, 983, DateTimeKind.Local).AddTicks(9337), "TOP", "Levko.Shukhevich@ukr.net", null, "Антонида", "Іванишин", "канд. філол. наук", "(098) 794-69-05", 5105.24m, "synthesize" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 18, 12, 6, 52, 428, DateTimeKind.Local).AddTicks(7309), "Коліївщини майдан, 4, Красний Луч, Східний Тимор", new DateTime(1985, 12, 30, 4, 3, 31, 149, DateTimeKind.Local).AddTicks(8140), "BHD", "Mariya13@e-mail.ua", new DateTime(2019, 12, 2, 2, 36, 46, 921, DateTimeKind.Local).AddTicks(9480), "Юхимія", "Гайова", "проф.", "(096) 040-21-06", "Прибиральник", 13724.33m, "Sri Lanka Rupee" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 17, 6, 36, 12, 243, DateTimeKind.Local).AddTicks(2185), "пр. Вузька, 73, Західний Михайло, Йорданія", new DateTime(2019, 11, 4, 16, 31, 5, 301, DateTimeKind.Local).AddTicks(5412), "PGK", "Vlasta15@i.ua", null, "Добромисла", "Білич", "докт. психол. наук", "(095) 383-87-23", "Прибиральник", 8402.70m, "Pennsylvania" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 11, 2, 13, 47, 58, 376, DateTimeKind.Local).AddTicks(2470), "Рудного майдан, 538, Північний Віктор, Канада", new DateTime(1962, 7, 12, 12, 13, 39, 644, DateTimeKind.Local).AddTicks(5105), "KHR", "Valerii44@ex.ua", null, "Радим", "Ломова", "канд. техн. наук", "(098) 232-50-39", 8838.41m, "generating" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 25, 14, 567, DateTimeKind.Local).AddTicks(8841), "Ліста майдан, 82, Західний Корнелій, Зімбабве", new DateTime(2007, 2, 21, 19, 49, 33, 192, DateTimeKind.Local).AddTicks(3523), "CZK", "Boleslav_Levadovska48@ex.ua", new DateTime(2020, 8, 5, 20, 25, 55, 615, DateTimeKind.Local).AddTicks(5039), "Боримисл", "Трясило", "канд. політ. наук", "(098) 933-50-04", "Секретар", 11335.72m, "Rubber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 11, 7, 12, 37, 473, DateTimeKind.Local).AddTicks(871), "Зелена майдан, 09, Східний Дмитро, Болівія", new DateTime(2003, 4, 17, 5, 54, 0, 716, DateTimeKind.Local).AddTicks(4687), "RSD", "Kupava.Kompaniyec25@gmail.com", new DateTime(2021, 6, 26, 15, 31, 8, 254, DateTimeKind.Local).AddTicks(2478), "Віленіна", "Махно", "докт. філол. наук", "(097) 787-50-85", "Директор", 9587.90m, "reinvent" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 5, 13, 55, 51, 203, DateTimeKind.Local).AddTicks(1905), "Вузька майдан, 40, Північний Григорій, Литва", new DateTime(2021, 8, 29, 21, 27, 21, 760, DateTimeKind.Local).AddTicks(8100), "LSL", "Albert59@e-mail.ua", new DateTime(2019, 12, 20, 16, 46, 16, 927, DateTimeKind.Local).AddTicks(9766), "Лілія", "Євпак", "докт. філол. наук", "(098) 595-70-28", "Бухгалтер", 14239.64m, "Rustic Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 22, 15, 4, 8, 281, DateTimeKind.Local).AddTicks(7036), "Староміська майдан, 375, Конотоп, Кіпр", new DateTime(1948, 4, 9, 10, 22, 53, 712, DateTimeKind.Local).AddTicks(5804), "MAD", "Vladislav.Pryadun90@ukr.net", "Павло", "Ломовий", "докт. техн. наук", "(093) 148-73-42", "Програміст", 11709.41m, "copying" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 4, 2, 17, 50, 19, 306, DateTimeKind.Local).AddTicks(5261), "Вічева майдан, 41, Євпаторія, Німеччина", new DateTime(1960, 7, 29, 2, 57, 40, 378, DateTimeKind.Local).AddTicks(8301), "SLL", "Vseslava.Semenochko53@ex.ua", "Соня", "Вергун", "докт. психол. наук", "(097) 460-32-15", 10183.93m, "ability" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 26, 3, 0, 43, 204, DateTimeKind.Local).AddTicks(2878), "провулок Ліста, 90, Кременчук, Казахстан", new DateTime(1991, 5, 6, 1, 1, 20, 807, DateTimeKind.Local).AddTicks(5054), "BGN", "Orina_Petlyura86@yandex.ua", new DateTime(2024, 1, 1, 21, 24, 50, 652, DateTimeKind.Local).AddTicks(6308), "Ганна", "Лазірко", "докт. філос. наук", "(044) 849-79-75", "Директор", 12829.52m, "Assistant" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 9, 20, 5, 46, 39, 784, DateTimeKind.Local).AddTicks(2924), "вулиця Рудного, 9, Східний Звенигор, Сан-Марино", new DateTime(2000, 5, 21, 1, 53, 4, 185, DateTimeKind.Local).AddTicks(6144), "NIO", "Ladomir24@e-mail.ua", "Добромира", "Єрмак", "докт. філол. наук", "(099) 464-02-36", "Секретар", 13650.44m, "Fantastic Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 20, 13, 24, 58, 974, DateTimeKind.Local).AddTicks(4330), "Ліста майдан, 16, Донецьк, Індія", new DateTime(1956, 8, 9, 3, 49, 14, 354, DateTimeKind.Local).AddTicks(990), "MNT", "Miloslava_Gaiduk63@gmail.com", null, "Інна", "Потебенько", "канд. техн. наук", "(098) 568-98-75", "Секретар", 13156.38m, "hub" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 7, 10, 9, 6, 8, 511, DateTimeKind.Local).AddTicks(7740), "площа Городоцька, 54, Красний Луч, Сент-Кітс і Невіс", new DateTime(1964, 2, 27, 2, 2, 0, 952, DateTimeKind.Local).AddTicks(4156), "GTQ", "Solomiya30@yandex.ua", new DateTime(2020, 1, 14, 3, 53, 18, 936, DateTimeKind.Local).AddTicks(4198), "Поривайло", "доц.", "(094) 633-61-22", "Секретар", 2223.78m, "Won" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 9, 15, 0, 56, 781, DateTimeKind.Local).AddTicks(8436), "Стрийська майдан, 25, Івано-Франківськ, Австралія", new DateTime(1982, 10, 18, 1, 10, 38, 316, DateTimeKind.Local).AddTicks(6602), "ZWL", "Lyubozar_Marinich@meta.ua", "Микола", "Гарай", "канд. пед. наук", "(066) 136-89-81", "Директор", 5353.87m, "Street" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 27, 7, 32, 37, 653, DateTimeKind.Local).AddTicks(2122), "Ліста майдан, 0, Південний Ян, Еквадор", new DateTime(1973, 1, 4, 2, 26, 58, 554, DateTimeKind.Local).AddTicks(1705), "DOP", "Ognyana_Moskalyuk@e-mail.ua", new DateTime(2023, 9, 25, 19, 33, 28, 422, DateTimeKind.Local).AddTicks(3803), "Ярослав", "Головець", "докт. пед. наук", "(098) 233-15-83", "Секретар", 10538.39m, "Ergonomic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 5, 7, 54, 54, 54, DateTimeKind.Local).AddTicks(257), "пр. Староміська, 7, Севастополь, Вануату", new DateTime(1947, 1, 11, 12, 38, 32, 306, DateTimeKind.Local).AddTicks(3124), "BWP", "Klavdiya_Yalovii22@gmail.com", new DateTime(2022, 11, 15, 16, 35, 23, 746, DateTimeKind.Local).AddTicks(3761), "Святополк", "Марків", "доц.", "(093) 891-44-73", "Секретар", 2519.84m, "Isle" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 23, 11, 30, 19, 203, DateTimeKind.Local).AddTicks(6155), "Стрийська майдан, 6, Житомир, Люксембург", new DateTime(1991, 1, 21, 10, 36, 21, 8, DateTimeKind.Local).AddTicks(7147), "DOP", "Boleslav.Skoropadska@e-mail.ua", null, "Марта", "Магера", "проф.", "(097) 225-81-33", "Бухгалтер", 5343.93m, "Rest" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 24, 22, 16, 21, 215, DateTimeKind.Local).AddTicks(1260), "проспект Винників, 065, Північний Святополк, Кувейт", new DateTime(1991, 4, 25, 4, 30, 29, 86, DateTimeKind.Local).AddTicks(3134), "SVC", "Boleslava67@yandex.ua", "Антон", "Петрин", "канд. психол. наук", "(066) 634-58-18", "Програміст", 14732.94m, "Handmade" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 17, 7, 0, 58, 834, DateTimeKind.Local).AddTicks(5408), "вул. Городоцька, 64, Красний Луч, Німеччина", new DateTime(1966, 2, 5, 14, 6, 8, 826, DateTimeKind.Local).AddTicks(1941), "XDR", "Lyudmila.Pavlenko@meta.ua", "Лад", "Сідляк", "канд. політ. наук", "(092) 858-78-48", "Секретар", 5199.62m, "Savings Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 10, 6, 25, 10, 168, DateTimeKind.Local).AddTicks(5638), "Староміська майдан, 4, Східний Яровид, Гайана", new DateTime(2012, 12, 8, 22, 39, 42, 289, DateTimeKind.Local).AddTicks(9704), "PKR", "Zoremir.Lomovii27@gmail.com", new DateTime(2021, 4, 21, 22, 53, 41, 944, DateTimeKind.Local).AddTicks(8239), "Сологуб", "Коломієць", "докт. техн. наук", "(096) 321-99-00", "Секретар", 11749.12m, "Soft" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 3, 31, 11, 0, 53, 781, DateTimeKind.Local).AddTicks(6016), "провулок Коліївщини, 14, Євпаторія, В’єтнам", new DateTime(1982, 4, 8, 15, 14, 4, 991, DateTimeKind.Local).AddTicks(443), "GYD", "Mstislava96@meta.ua", null, "Ратимир", "Балабух", "канд. юрид. наук", "(073) 966-71-64", 2260.49m, "leverage" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 6, 0, 16, 11, 609, DateTimeKind.Local).AddTicks(367), "Коліївщини майдан, 6, Північний Юрій, Сан-Томе і Принсіпі", new DateTime(2016, 10, 13, 23, 20, 40, 473, DateTimeKind.Local).AddTicks(9571), "HTG", "Anatoliya.Yevenko86@e-mail.ua", null, "Мирослав", "Гладківська", "канд. юрид. наук", "(099) 790-49-71", 4440.98m, "Checking Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 8, 26, 12, 0, 26, 842, DateTimeKind.Local).AddTicks(8217), "Стрийська майдан, 413, Західний Буйтур, Суринам", new DateTime(1945, 6, 6, 3, 11, 16, 421, DateTimeKind.Local).AddTicks(1656), "PEN", "Stozhar.Plaksii@e-mail.ua", null, "Сюзана", "Мазило", "канд. юрид. наук", "(094) 001-05-26", "Секретар", 14909.29m, "Auto Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 12, 29, 21, 38, 27, 530, DateTimeKind.Local).AddTicks(6859), "Брюховичів майдан, 864, Північний Звенигор, Барбадос", new DateTime(1949, 1, 14, 6, 0, 45, 686, DateTimeKind.Local).AddTicks(7292), "ZMK", "Smiyana.Dzyuba60@i.ua", new DateTime(2021, 1, 8, 9, 30, 36, 570, DateTimeKind.Local).AddTicks(686), "Ярина", "Левадовський", "докт. політ. наук", "(099) 863-20-25", "Прибиральник", 9944.82m, "Pre-emptive" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 11, 14, 19, 9, 5, 196, DateTimeKind.Local).AddTicks(9550), "Вічева майдан, 27, Мукачеве, Парагвай", new DateTime(2012, 9, 23, 20, 14, 17, 253, DateTimeKind.Local).AddTicks(6591), "XBA", "Antoniya_Pavlishina23@ukr.net", null, "Юхим", "Яворівський", "докт. і. наук", "(050) 554-20-04", 2913.91m, "Iowa" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 1, 21, 40, 0, 986, DateTimeKind.Local).AddTicks(5441), "пров. Коліївщини, 9, Східний Білослав, Мальта", new DateTime(1963, 11, 16, 18, 1, 49, 0, DateTimeKind.Local).AddTicks(4723), "EEK", "Darina_Moskalyuk@ukr.net", "Дарій", "Демків", "докт. психол. наук", "(095) 412-83-89", "Програміст", 17438.96m, "protocol" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 18, 21, 42, 45, 366, DateTimeKind.Local).AddTicks(7285), "Вузька майдан, 759, Північний Мечислав, Катар", new DateTime(1995, 4, 27, 18, 56, 4, 54, DateTimeKind.Local).AddTicks(5804), "IDR", "Snizhan5@e-mail.ua", new DateTime(2022, 12, 20, 21, 21, 9, 194, DateTimeKind.Local).AddTicks(7584), "Гелена", "Трясило", "канд. філос. наук", "(092) 069-13-71", "Директор", 7068.94m, "transform" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 18, 23, 22, 15, 862, DateTimeKind.Local).AddTicks(3759), "площа Нижанківського, 56, Черкаси, Болівія", new DateTime(1988, 10, 7, 18, 57, 40, 346, DateTimeKind.Local).AddTicks(8287), "JOD", "Svyatoslav_Dmitruk89@gmail.com", null, "Жозефіна", "Розпутній", "докт. техн. наук", "(094) 529-51-29", 19199.44m, "modular" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 8, 4, 31, 9, 629, DateTimeKind.Local).AddTicks(2240), "пр. Вічева, 9, Умань, Гондурас", new DateTime(1975, 4, 29, 12, 41, 0, 521, DateTimeKind.Local).AddTicks(5792), "XBB", "Pavlo_Trublayevskii@ukr.net", new DateTime(2022, 4, 8, 13, 21, 48, 686, DateTimeKind.Local).AddTicks(2374), "Марко", "Гарай", "докт. психол. наук", "(099) 909-43-30", 8942.69m, "Metical" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 26, 7, 47, 58, 524, DateTimeKind.Local).AddTicks(5558), "пр. Вузька, 0, Київ, Туніс", new DateTime(2016, 8, 23, 14, 17, 41, 50, DateTimeKind.Local).AddTicks(2806), "CNY", "Doleslava.Lucka39@yandex.ua", new DateTime(2023, 7, 13, 9, 34, 50, 718, DateTimeKind.Local).AddTicks(6030), "Мечислав", "Гладух", "канд. філос. наук", "(099) 345-51-06", "Програміст", 15877.45m, "programming" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 3, 15, 13, 24, 31, 522, DateTimeKind.Local).AddTicks(5531), "Нижанківського майдан, 92, Макіївка, Мавританія", new DateTime(1998, 8, 15, 21, 55, 59, 317, DateTimeKind.Local).AddTicks(6805), "CHF", "Bronislava_Lagoida94@yandex.ua", null, "Яна", "Балабуха", "(094) 162-12-02", "Директор", 16821.75m, "Handcrafted Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 15, 21, 41, 25, 949, DateTimeKind.Local).AddTicks(147), "пл. Винників, 498, Південний Охрім, Венесуела", new DateTime(1967, 11, 27, 8, 20, 5, 11, DateTimeKind.Local).AddTicks(6775), "PLN", "Aelayida_Ivanciv@yandex.ua", new DateTime(2019, 5, 21, 9, 51, 17, 26, DateTimeKind.Local).AddTicks(6617), "Агата", "Петрів", "докт. психол. наук", "(066) 045-18-99", "Секретар", 17698.17m, "empower" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 10, 15, 58, 30, 787, DateTimeKind.Local).AddTicks(2800), "Вузька майдан, 27, Житомир, Гвінея-Бісау", new DateTime(1945, 4, 30, 20, 29, 17, 367, DateTimeKind.Local).AddTicks(1721), "PGK", "Boleslav.Yushuk28@e-mail.ua", new DateTime(2019, 8, 10, 11, 54, 19, 730, DateTimeKind.Local).AddTicks(4445), "Вілена", "Павлишина", "канд. юрид. наук", "(097) 296-01-49", 12272.34m, "Borders" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 8, 15, 19, 5, 295, DateTimeKind.Local).AddTicks(9858), "Нижанківського майдан, 944, Кременчук, Гвінея-Бісау", new DateTime(1954, 7, 14, 14, 6, 57, 188, DateTimeKind.Local).AddTicks(7977), "XOF", "Izyaslav_Yemec@ex.ua", "Богдан", "Білич", "докт. філос. наук", "(097) 573-52-36", "Прибиральник", 3638.89m, "Louisiana" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 16, 2, 24, 34, 40, DateTimeKind.Local).AddTicks(9863), "вулиця Вічева, 66, Східний Орест, Марокко", new DateTime(1951, 2, 25, 0, 36, 59, 680, DateTimeKind.Local).AddTicks(671), "EEK", "Ognyana0@i.ua", "Вілена", "Шупик", "канд. і. наук", "(093) 708-48-77", "Бухгалтер", 15575.26m, "killer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 3, 24, 9, 8, 2, 668, DateTimeKind.Local).AddTicks(4504), "площа Староміська, 1, Нікополь, Фіджі", new DateTime(2013, 3, 30, 13, 27, 28, 246, DateTimeKind.Local).AddTicks(7694), "CDF", "Izyaslav_Stakhiv67@e-mail.ua", new DateTime(2021, 7, 12, 23, 39, 57, 301, DateTimeKind.Local).AddTicks(7917), "Іван", "Балакун", "докт. юрид. наук", "(097) 467-46-22", "Програміст", 14296.83m, "Borders" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 12, 23, 23, 44, 9, 713, DateTimeKind.Local).AddTicks(7612), "провулок Староміська, 04, Східний Арсен, Сент-Вінсент і Гренадини", new DateTime(1981, 6, 26, 17, 20, 46, 310, DateTimeKind.Local).AddTicks(9934), "ISK", "Vsevlad22@ex.ua", new DateTime(2020, 4, 16, 9, 53, 43, 94, DateTimeKind.Local).AddTicks(5486), "Надія", "Гречко", "докт. філол. наук", "(098) 529-18-02", "Прибиральник", 15530.80m, "Internal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 28, 20, 53, 11, 933, DateTimeKind.Local).AddTicks(5753), "Винників майдан, 7, Північний Ігор, Іран", new DateTime(1953, 7, 10, 13, 53, 56, 305, DateTimeKind.Local).AddTicks(4692), "LTL", "Yustina12@yandex.ua", new DateTime(2020, 9, 23, 19, 4, 45, 879, DateTimeKind.Local).AddTicks(8384), "Вілена", "Ющук", "докт. юрид. наук", "(063) 548-75-10", "Директор", 7886.81m, "deposit" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 3, 22, 6, 56, 23, 753, DateTimeKind.Local).AddTicks(7364), "пров. Староміська, 64, Павлоград, Німеччина", new DateTime(1955, 6, 21, 9, 58, 36, 806, DateTimeKind.Local).AddTicks(161), "XFU", "Zvenislav.Makoveckii@ex.ua", "Боримисл", "Сплюх", "канд. філол. наук", "(095) 163-67-67", "Директор", 6981.83m, "Ergonomic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 30, 2, 20, 32, 806, DateTimeKind.Local).AddTicks(8977), "пр. Городоцька, 88, Севастополь, Азербайджан", new DateTime(1990, 1, 10, 15, 58, 27, 188, DateTimeKind.Local).AddTicks(9506), "XTS", "Pavlina45@meta.ua", new DateTime(2022, 11, 17, 5, 31, 18, 643, DateTimeKind.Local).AddTicks(1685), "Орест", "Бердник", "докт. психол. наук", "(096) 305-49-66", "Директор", 5598.53m, "enterprise" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 14, 6, 19, 58, 837, DateTimeKind.Local).AddTicks(570), "вул. Стрийська, 08, Західний Сологуб, Сомалі", new DateTime(2021, 6, 6, 6, 59, 2, 230, DateTimeKind.Local).AddTicks(6341), "YER", "Ostap.Nogachevskii@e-mail.ua", null, "Мстислава", "Данилко", "канд. техн. наук", "(063) 344-61-89", "Секретар", 10133.34m, "Coordinator" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 9, 11, 16, 0, 36, 586, DateTimeKind.Local).AddTicks(9508), "пр. Ліста, 1, Західний Гнат, Сан-Томе і Принсіпі", new DateTime(1950, 6, 13, 9, 7, 19, 593, DateTimeKind.Local).AddTicks(6266), "PGK", "Smiyana_Zinkevich@yandex.ua", "Арсен", "Ганич", "докт. психол. наук", "(093) 182-18-78", "Програміст", 13515.65m, "Throughway" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 4, 6, 48, 42, 174, DateTimeKind.Local).AddTicks(1499), "вул. Вузька, 77, Південний Олег, Кувейт", new DateTime(2013, 7, 5, 22, 17, 14, 596, DateTimeKind.Local).AddTicks(9326), "ZAR", "Vseslava99@yandex.ua", null, "Забава", "Плаксій", "докт. філос. наук", "(094) 616-50-15", "Програміст", 6578.02m, "Ergonomic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 5, 3, 11, 42, 52, 493, DateTimeKind.Local).AddTicks(1109), "Вузька майдан, 0, Північний Радим, Киргизстан", new DateTime(2019, 2, 9, 2, 17, 16, 702, DateTimeKind.Local).AddTicks(7579), "CRC", "Zvenimir22@meta.ua", new DateTime(2019, 8, 15, 3, 0, 14, 4, DateTimeKind.Local).AddTicks(1094), "Таїсія", "Троян", "(095) 992-96-11", 17194.98m, "help-desk" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 3, 1, 13, 16, 55, 960, DateTimeKind.Local).AddTicks(785), "пр. Вузька, 354, Дніпропетровськ, Іспанія", new DateTime(1966, 3, 30, 2, 52, 18, 231, DateTimeKind.Local).AddTicks(7463), "MAD", "Ivan40@ukr.net", null, "Яна", "Юрчишин", "докт. політ. наук", "(073) 533-56-45", "Бухгалтер", 14201.50m, "upward-trending" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 24, 4, 30, 50, 855, DateTimeKind.Local).AddTicks(3400), "Городоцька майдан, 863, Північний Ярополк, Малі", new DateTime(2020, 1, 12, 18, 59, 14, 712, DateTimeKind.Local).AddTicks(196), "AZN", "Diyana.Lazirko21@gmail.com", new DateTime(2019, 8, 4, 2, 45, 19, 719, DateTimeKind.Local).AddTicks(3053), "Яна", "Балицький", "канд. психол. наук", "(093) 621-43-95", "Прибиральник", 13021.46m, "Steel" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 8, 6, 48, 29, 588, DateTimeKind.Local).AddTicks(7206), "пл. Молодіжна, 7, Біла Церква, Лівія", new DateTime(2016, 6, 5, 2, 14, 5, 976, DateTimeKind.Local).AddTicks(1021), "MDL", "Olga.Grigorishina@ex.ua", null, "Аполлінарія", "Ромочко", "докт. філол. наук", "(095) 037-14-67", "Бухгалтер", 13428.65m, "Quality" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 3, 23, 14, 40, 221, DateTimeKind.Local).AddTicks(3215), "пл. Стрийська, 4, Івано-Франківськ, Північна Корея", new DateTime(1980, 8, 10, 21, 42, 26, 963, DateTimeKind.Local).AddTicks(2787), "CAD", "Apolloniya8@gmail.com", "Костянтин", "Дзюба", "докт. техн. наук", "(066) 046-87-98", 9257.09m, "tertiary" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 14, 22, 7, 16, 731, DateTimeKind.Local).AddTicks(8071), "пр. Городоцька, 71, Житомир, Франція", new DateTime(1950, 9, 8, 3, 7, 44, 255, DateTimeKind.Local).AddTicks(868), "KGS", "Motrya_Ganich@ukr.net", new DateTime(2022, 2, 19, 10, 17, 34, 622, DateTimeKind.Local).AddTicks(738), "Захар", "Юрчишина", "канд. філол. наук", "(096) 931-03-57", 2394.37m, "Associate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 3, 19, 33, 5, 723, DateTimeKind.Local).AddTicks(8707), "Вічева майдан, 6, Східний Богдан, Ватикан", new DateTime(2011, 10, 14, 13, 4, 44, 841, DateTimeKind.Local).AddTicks(1113), "MOP", "Radmila_Petrin65@yandex.ua", null, "Божена", "Бабух", "докт. філос. наук", "(050) 207-66-14", "Директор", 11260.68m, "Gorgeous" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 5, 21, 2, 53, 400, DateTimeKind.Local).AddTicks(2363), "Вічева майдан, 0, Північний Горимир, Коста-Рика", new DateTime(1996, 5, 1, 3, 26, 7, 912, DateTimeKind.Local).AddTicks(4498), "SEK", "Polina.Gladkivskii@meta.ua", new DateTime(2020, 11, 6, 11, 19, 37, 591, DateTimeKind.Local).AddTicks(80), "Власта", "Ящук", "докт. філол. наук", "(097) 839-30-40", "Бухгалтер", 13059.85m, "5th generation" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 8, 1, 3, 48, 28, 535, DateTimeKind.Local).AddTicks(7451), "провулок Городоцька, 81, Кременчук, Соломонові Острови", new DateTime(1989, 6, 12, 10, 45, 23, 228, DateTimeKind.Local).AddTicks(6141), "LYD", "Vsevlad.Vereshuk95@ex.ua", new DateTime(2024, 1, 30, 6, 6, 52, 891, DateTimeKind.Local).AddTicks(5146), "Мальва", "Ящук", "канд. пед. наук", "(050) 196-30-07", "Директор", 19601.22m, "Gourde" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 16, 6, 26, 49, 571, DateTimeKind.Local).AddTicks(1224), "пр. Ліста, 68, Кіровоград, Науру", new DateTime(1995, 1, 9, 7, 22, 5, 742, DateTimeKind.Local).AddTicks(4378), "SVC", "Ratimir.Gladkivska28@i.ua", "Назарій", "Дурдинець", "канд. пед. наук", "(099) 168-23-04", "Директор", 11161.85m, "object-oriented" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 11, 27, 11, 55, 11, 514, DateTimeKind.Local).AddTicks(1289), "вулиця Зелена, 553, Сімферополь, Мавританія", new DateTime(1981, 4, 30, 9, 17, 39, 837, DateTimeKind.Local).AddTicks(6720), "EEK", "Okhrim.Grigorishina56@i.ua", null, "Аврелій", "Данилко", "докт. юрид. наук", "(096) 677-10-92", 17671.08m, "Investment Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 14, 0, 51, 16, 252, DateTimeKind.Local).AddTicks(1054), "Вічева майдан, 187, Західний Радим, Монголія", new DateTime(1971, 2, 19, 5, 56, 44, 866, DateTimeKind.Local).AddTicks(4307), "TRY", "Agata.Shukhevich@meta.ua", "Михайло", "Данилишин", "докт. філол. наук", "(050) 359-46-71", "Прибиральник", 9711.93m, "bandwidth" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 17, 6, 55, 9, 901, DateTimeKind.Local).AddTicks(8927), "Брюховичів майдан, 9, Ізмаїл, Беліз", new DateTime(2015, 5, 19, 17, 3, 55, 835, DateTimeKind.Local).AddTicks(6164), "MMK", "Denis.Levadovskii@e-mail.ua", "Станислава", "Бачей", "докт. філос. наук", "(063) 654-70-46", "Прибиральник", 1116.86m, "Licensed Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 12, 5, 8, 11, 51, 938, DateTimeKind.Local).AddTicks(9248), "вулиця Коліївщини, 0, Південний Алевтин, Таджикистан", new DateTime(2006, 6, 17, 12, 55, 41, 496, DateTimeKind.Local).AddTicks(6001), "BRL", "Mariya.Palii16@i.ua", new DateTime(2021, 6, 5, 12, 44, 52, 701, DateTimeKind.Local).AddTicks(3862), "Алевтин", "Левадовська", "докт. і. наук", "(093) 121-75-58", "Секретар", 12826.96m, "deposit" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 18, 18, 28, 19, 189, DateTimeKind.Local).AddTicks(385), "пл. Брюховичів, 82, Східний Устим, Гватемала", new DateTime(1992, 4, 12, 16, 1, 51, 400, DateTimeKind.Local).AddTicks(8305), "VND", "Mechislava.Chervonii15@meta.ua", "Майя", "Демків", "докт. юрид. наук", "(091) 759-59-45", "Бухгалтер", 18859.84m, "PCI" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 3, 28, 12, 25, 33, 908, DateTimeKind.Local).AddTicks(6433), "вул. Ліста, 1, Бровари, Бангладеш", new DateTime(1972, 7, 21, 5, 34, 41, 573, DateTimeKind.Local).AddTicks(8708), "ZAR", "Antoniya.Gordiichuk@ukr.net", "Наталія", "Сірко", "проф.", "(044) 236-49-92", "Директор", 1882.11m, "FTP" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 9, 12, 9, 40, 30, 941, DateTimeKind.Local).AddTicks(5312), "пров. Нижанківського, 30, Південний Боримисл, Російська Федерація", new DateTime(1999, 5, 13, 19, 16, 38, 181, DateTimeKind.Local).AddTicks(3029), "LBP", "Timofii_Usich@yandex.ua", new DateTime(2021, 10, 21, 3, 21, 19, 836, DateTimeKind.Local).AddTicks(3416), "Божемир", "Боярчук", "докт. і. наук", "(096) 207-61-57", "Прибиральник", 11937.80m, "Implementation" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 10, 23, 24, 16, 481, DateTimeKind.Local).AddTicks(6261), "провулок Стрийська, 6, Західний Подолян, Ізраїль", new DateTime(1948, 10, 4, 7, 21, 13, 906, DateTimeKind.Local).AddTicks(5703), "XAF", "Biloslav_Magera@ukr.net", null, "Власта", "Корецький", "докт. пед. наук", "(097) 082-73-55", 19634.58m, "productize" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 6, 0, 48, 56, 663, DateTimeKind.Local).AddTicks(3742), "пр. Винників, 966, Південний Мечислав, Непал", new DateTime(1957, 12, 2, 14, 54, 27, 419, DateTimeKind.Local).AddTicks(3153), "GYD", "Azaliya1@meta.ua", new DateTime(2019, 8, 22, 6, 20, 13, 491, DateTimeKind.Local).AddTicks(8955), "Будимир", "Стоян", "канд. психол. наук", "(073) 654-44-76", "Секретар", 8211.74m, "interfaces" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 3, 21, 7, 52, 49, 240, DateTimeKind.Local).AddTicks(1014), "вул. Зелена, 2, Північний Всеслав, Сьєрра-Леоне", new DateTime(1945, 9, 20, 23, 12, 53, 209, DateTimeKind.Local).AddTicks(6935), "ZAR", "Anatolii.Kaskiv@i.ua", null, "Софія", "Третяк", "докт. техн. наук", "(097) 164-47-36", "Директор", 1143.01m, "PNG" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 4, 28, 11, 32, 5, 228, DateTimeKind.Local).AddTicks(3893), "Вузька майдан, 825, Західний Братислав, Іспанія", new DateTime(1957, 9, 2, 9, 0, 23, 753, DateTimeKind.Local).AddTicks(447), "BAM", "Darina.Makhno81@yandex.ua", new DateTime(2020, 9, 1, 23, 57, 28, 84, DateTimeKind.Local).AddTicks(6264), "Мокрина", "Петрів", "канд. політ. наук", "(094) 717-39-40", "Директор", 11387.24m, "Northern Mariana Islands" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 3, 26, 1, 1, 35, 752, DateTimeKind.Local).AddTicks(1364), "пл. Ліста, 328, Західний Ізяслав, Туреччина", new DateTime(1955, 1, 12, 8, 59, 12, 151, DateTimeKind.Local).AddTicks(1797), "UAH", "Marko37@gmail.com", "Пелагея", "Приймак", "канд. і. наук", "(098) 394-52-00", "Програміст", 1140.78m, "Small Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 7, 18, 16, 56, 24, 77, DateTimeKind.Local).AddTicks(4990), "Нижанківського майдан, 22, Східний Геннадій, Вірменія", new DateTime(2017, 9, 6, 15, 27, 8, 771, DateTimeKind.Local).AddTicks(4047), "LRD", "Oleksii75@ex.ua", new DateTime(2023, 11, 25, 8, 3, 39, 414, DateTimeKind.Local).AddTicks(4211), "Вадим", "Шкараба", "канд. техн. наук", "(097) 232-69-67", "Директор", 12426.10m, "backing up" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 15, 19, 22, 29, 111, DateTimeKind.Local).AddTicks(7660), "Брюховичів майдан, 0, Південний Пантелеймон, Бразилія", new DateTime(2003, 1, 11, 12, 23, 2, 659, DateTimeKind.Local).AddTicks(777), "ANG", "Zlatomir.Borovskii44@ex.ua", "Іннеса", "Мазайло", "докт. психол. наук", "(097) 934-13-36", 6519.53m, "sky blue" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 13, 10, 7, 58, 832, DateTimeKind.Local).AddTicks(7563), "пр. Городоцька, 843, Запоріжжя, Ефіопія", new DateTime(1963, 2, 13, 13, 51, 53, 197, DateTimeKind.Local).AddTicks(3868), "GNF", "Kuzma61@i.ua", "Богдан", "Васильківська", "докт. і. наук", "(050) 728-48-66", "Програміст", 19777.04m, "Ergonomic Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 4, 11, 7, 19, 22, 371, DateTimeKind.Local).AddTicks(9848), "площа Нижанківського, 5, Північний Віктор, Гренада", new DateTime(1956, 4, 11, 5, 14, 13, 598, DateTimeKind.Local).AddTicks(2228), "EGP", "Motrya.Stigailo@i.ua", "Ликера", "Верещук", "канд. техн. наук", "(091) 662-47-55", "Прибиральник", 7084.99m, "Auto Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 26, 1, 25, 0, 939, DateTimeKind.Local).AddTicks(8221), "Стрийська майдан, 437, Західний Гарнослав, Нова Зеландія", new DateTime(1995, 7, 9, 21, 42, 36, 867, DateTimeKind.Local).AddTicks(897), "BYR", "Avrora.Mazun40@gmail.com", new DateTime(2019, 12, 30, 8, 57, 27, 352, DateTimeKind.Local).AddTicks(9111), "Станіслав", "Василишин", "докт. філос. наук", "(096) 822-41-13", "Прибиральник", 7963.93m, "Awesome Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 16, 2, 1, 27, 692, DateTimeKind.Local).AddTicks(3518), "Вузька майдан, 34, Маріуполь, Беліз", new DateTime(2001, 6, 4, 11, 15, 3, 438, DateTimeKind.Local).AddTicks(8075), "OMR", "Irma.Pasichnik52@yandex.ua", new DateTime(2022, 1, 10, 20, 15, 33, 498, DateTimeKind.Local).AddTicks(5554), "Немира", "Миклухо", "докт. психол. наук", "(073) 197-20-99", "Програміст", 13814.91m, "Sleek Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 27, 1, 58, 53, 634, DateTimeKind.Local).AddTicks(6234), "вулиця Нижанківського, 46, Східний Ігор, Саудівська Аравія", new DateTime(2002, 1, 14, 21, 10, 48, 947, DateTimeKind.Local).AddTicks(8326), "ERN", "Vyacheslav5@ex.ua", "Борислав", "Потоцький", "канд. пед. наук", "(096) 909-47-11", "Директор", 8285.27m, "Unbranded Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 11, 29, 22, 35, 8, 142, DateTimeKind.Local).AddTicks(902), "Староміська майдан, 9, Київ, Коморські Острови", new DateTime(1954, 9, 23, 2, 21, 28, 697, DateTimeKind.Local).AddTicks(8438), "UZS", "Daromir36@ukr.net", null, "Любомила", "Щербак", "доц.", "(093) 053-19-82", 9634.28m, "incubate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 1, 25, 6, 55, 26, 58, DateTimeKind.Local).AddTicks(9462), "провулок Вічева, 63, Східний Родослав, Тонга", new DateTime(1982, 8, 14, 20, 5, 51, 461, DateTimeKind.Local).AddTicks(3910), "KMF", "Zoryan_Kocyubinskii89@gmail.com", null, "Антонія", "Євенко", "докт. психол. наук", "(099) 222-45-47", "Секретар", 16566.54m, "Customer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 18, 16, 36, 38, 293, DateTimeKind.Local).AddTicks(6852), "провулок Вічева, 1, Нікополь, Габон", new DateTime(2010, 5, 6, 2, 46, 11, 685, DateTimeKind.Local).AddTicks(6534), "NGN", "Kornilii.Gladukh@meta.ua", null, "Любозар", "Левадовська", "докт. техн. наук", "(094) 700-59-37", "Директор", 14853.32m, "plum" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 3, 14, 11, 17, 5, 851, DateTimeKind.Local).AddTicks(5585), "вулиця Зелена, 198, Запоріжжя, Індія", new DateTime(1995, 3, 21, 15, 37, 3, 752, DateTimeKind.Local).AddTicks(5853), "UZS", "Ivanna_Yanyuk@yandex.ua", null, "Аркадія", "Ромей", "доц.", "(044) 336-40-23", "Директор", 18944.71m, "transmit" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 22, 19, 59, 22, 694, DateTimeKind.Local).AddTicks(5635), "Винників майдан, 7, Північний Стожар, Словаччина", new DateTime(1969, 4, 9, 4, 41, 55, 961, DateTimeKind.Local).AddTicks(8142), "LBP", "Ladomir.Gamula@gmail.com", new DateTime(2021, 7, 13, 17, 56, 19, 63, DateTimeKind.Local).AddTicks(7679), "Зоя", "Довгалевський", "канд. філол. наук", "(093) 123-47-68", "Програміст", 4839.66m, "Realigned" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 10, 19, 40, 20, 771, DateTimeKind.Local).AddTicks(3062), "вул. Винників, 731, Львів, Нікарагуа", new DateTime(1994, 7, 13, 16, 55, 31, 980, DateTimeKind.Local).AddTicks(4522), "KWD", "Azarii.Ivanishin@ex.ua", null, "В’ячеслав", "Яворівська", "докт. і. наук", "(073) 312-03-89", "Директор", 6404.20m, "Credit Card Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 8, 2, 7, 52, 6, 818, DateTimeKind.Local).AddTicks(5063), "Коліївщини майдан, 952, Івано-Франківськ, Сальвадор", new DateTime(1977, 1, 25, 19, 0, 21, 982, DateTimeKind.Local).AddTicks(2196), "ETB", "Anastas44@yandex.ua", null, "Лідія", "Лящук", "канд. психол. наук", "(073) 776-32-58", "Програміст", 8075.44m, "connect" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 3, 9, 35, 37, 884, DateTimeKind.Local).AddTicks(5138), "Вузька майдан, 006, Східний Хорив, Туніс", new DateTime(1991, 5, 15, 8, 14, 44, 887, DateTimeKind.Local).AddTicks(5942), "UGX", "Vseslav_Potockii69@meta.ua", "Сологуб", "Юхно", "докт. філос. наук", "(063) 374-46-31", "Секретар", 10371.10m, "salmon" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 4, 22, 45, 32, 514, DateTimeKind.Local).AddTicks(3701), "пл. Коліївщини, 690, Південний Зиновій, Уганда", new DateTime(2008, 2, 13, 23, 25, 5, 213, DateTimeKind.Local).AddTicks(6366), "NIO", "Orislava80@meta.ua", "Добринка", "Паращук", "(095) 233-12-18", "Програміст", 17622.23m, "Generic Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 20, 11, 4, 7, 446, DateTimeKind.Local).AddTicks(7961), "вул. Брюховичів, 5, Північний Ладислав, Домініка", new DateTime(1972, 8, 1, 12, 22, 51, 366, DateTimeKind.Local).AddTicks(9147), "XFU", "Lyubomila.Glinska48@i.ua", new DateTime(2020, 3, 7, 23, 20, 6, 745, DateTimeKind.Local).AddTicks(6577), "Роксолана", "Розпутній", "канд. і. наук", "(073) 595-79-62", "Бухгалтер", 19142.46m, "Beauty, Garden & Outdoors" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 9, 25, 15, 25, 16, 934, DateTimeKind.Local).AddTicks(5560), "Нижанківського майдан, 95, Західний Кий, Північна Корея", new DateTime(1961, 10, 17, 16, 58, 23, 236, DateTimeKind.Local).AddTicks(6587), "SCR", "Vlad_Magera97@meta.ua", "Євген", "Корнїйчук", "докт. пед. наук", "(063) 252-92-83", 1087.97m, "fuchsia" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 3, 11, 35, 11, 464, DateTimeKind.Local).AddTicks(3384), "проспект Ліста, 6, Північний Ростислав, Гондурас", new DateTime(1995, 10, 21, 2, 39, 45, 684, DateTimeKind.Local).AddTicks(5980), "GNF", "Aelina14@yandex.ua", new DateTime(2021, 4, 2, 1, 29, 42, 742, DateTimeKind.Local).AddTicks(2511), "Богдана", "Ярмак", "канд. юрид. наук", "(098) 971-32-46", "Програміст", 10553.16m, "invoice" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 11, 58, 819, DateTimeKind.Local).AddTicks(7825), "вулиця Молодіжна, 32, Кривий Ріг, Свазіленд", new DateTime(1949, 4, 18, 23, 30, 7, 399, DateTimeKind.Local).AddTicks(489), "UAH", "Vyacheslav.Bashuk74@ukr.net", new DateTime(2020, 6, 7, 6, 27, 59, 842, DateTimeKind.Local).AddTicks(6552), "Лук’ян", "Гойко", "докт. психол. наук", "(096) 264-53-56", "Секретар", 16450.36m, "Coordinator" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 31, 11, 14, 58, 418, DateTimeKind.Local).AddTicks(2410), "Винників майдан, 087, Західний Тур, Австрія", new DateTime(1961, 5, 17, 11, 22, 26, 942, DateTimeKind.Local).AddTicks(8345), "USD", "Yan_Veredun@e-mail.ua", null, "Благовіста", "Лугова", "доц.", "(091) 264-60-78", "Прибиральник", 10821.23m, "Liaison" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 10, 10, 17, 14, 931, DateTimeKind.Local).AddTicks(1529), "Вузька майдан, 79, Ялта, Люксембург", new DateTime(1965, 11, 27, 11, 28, 14, 623, DateTimeKind.Local).AddTicks(2037), "MGA", "Radmila3@e-mail.ua", "Слава", "Кононець", "канд. пед. наук", "(063) 986-77-63", "Секретар", 14401.92m, "Armenia" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 49, 59, 17, DateTimeKind.Local).AddTicks(4625), "Городоцька майдан, 8, Лисичанськ, Нігерія", new DateTime(1986, 4, 14, 3, 56, 9, 673, DateTimeKind.Local).AddTicks(7920), "XBB", "Lyubava62@e-mail.ua", new DateTime(2022, 2, 25, 20, 46, 59, 236, DateTimeKind.Local).AddTicks(677), "Долеслава", "Галаєнко", "канд. юрид. наук", "(095) 273-44-25", "Програміст", 12704.45m, "Credit Card Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 19, 4, 39, 5, 77, DateTimeKind.Local).AddTicks(1308), "пров. Вузька, 0, Північний Ян, Ботсвана", new DateTime(1965, 4, 9, 12, 41, 32, 120, DateTimeKind.Local).AddTicks(3838), "RON", "Oleg.Burmilo@yandex.ua", new DateTime(2021, 3, 9, 6, 2, 15, 808, DateTimeKind.Local).AddTicks(3904), "Орина", "Трясило", "докт. філос. наук", "(093) 704-36-39", "Директор", 15168.74m, "transmit" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 13, 5, 2, 42, 244, DateTimeKind.Local).AddTicks(65), "пров. Стрийська, 4, Східний Антін, Бурунді", new DateTime(1986, 11, 17, 21, 23, 11, 888, DateTimeKind.Local).AddTicks(3415), "DOP", "Slavuta.Splyukh30@gmail.com", new DateTime(2019, 7, 10, 23, 40, 43, 404, DateTimeKind.Local).AddTicks(5676), "Златомир", "Потоцький", "докт. юрид. наук", "(050) 767-20-83", "Директор", 10470.77m, "Directives" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 3, 28, 17, 29, 45, 399, DateTimeKind.Local).AddTicks(5714), "пров. Молодіжна, 1, Макіївка, Мексика", new DateTime(2016, 1, 8, 1, 18, 29, 484, DateTimeKind.Local).AddTicks(5789), "BTN", "Lyubomira_Lanova@e-mail.ua", "Гарнослав", "Коцюбинська", "докт. пед. наук", "(091) 073-04-88", 1160.95m, "even-keeled" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 8, 57, 246, DateTimeKind.Local).AddTicks(7606), "провулок Стрийська, 082, Південний Щастислав, Туніс", new DateTime(1947, 11, 13, 2, 14, 58, 372, DateTimeKind.Local).AddTicks(3538), "KHR", "Lyubomira65@ex.ua", new DateTime(2023, 4, 25, 14, 40, 18, 295, DateTimeKind.Local).AddTicks(8948), "Марта", "Бабух", "канд. політ. наук", "(050) 616-76-21", "Директор", 6356.73m, "payment" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 7, 10, 35, 5, 124, DateTimeKind.Local).AddTicks(9882), "Винників майдан, 2, Хмельницький, Ліван", new DateTime(1995, 10, 11, 9, 4, 57, 945, DateTimeKind.Local).AddTicks(1649), "RSD", "Larisa_Romenec6@ex.ua", new DateTime(2021, 11, 28, 16, 11, 39, 668, DateTimeKind.Local).AddTicks(8204), "Добромила", "Гаман", "доц.", "(099) 573-01-59", "Директор", 1564.57m, "Fork" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 26, 21, 11, 38, 733, DateTimeKind.Local).AddTicks(2353), "Рудного майдан, 89, Західний Роксолан, Ліхтенштейн", new DateTime(2011, 1, 16, 19, 54, 7, 665, DateTimeKind.Local).AddTicks(1338), "AED", "Kornelii_Voloshuk7@yandex.ua", new DateTime(2023, 1, 21, 10, 25, 19, 851, DateTimeKind.Local).AddTicks(4147), "Квітка", "Гайчук", "докт. і. наук", "(050) 581-05-74", "Прибиральник", 5499.18m, "SCSI" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 3, 17, 12, 34, 22, 865, DateTimeKind.Local).AddTicks(765), "пл. Рудного, 5, Конотоп, Об’єднані Арабські Емірати", new DateTime(1954, 7, 15, 5, 22, 39, 654, DateTimeKind.Local).AddTicks(8636), "SOS", "Likera_Borochko6@e-mail.ua", null, "Радміла", "Яворівська", "докт. пед. наук", "(066) 857-32-96", "Секретар", 14744.30m, "Synergized" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 21, 0, 31, 47, 527, DateTimeKind.Local).AddTicks(2005), "Зелена майдан, 671, Південний Августин, Бурунді", new DateTime(2017, 12, 22, 23, 41, 39, 837, DateTimeKind.Local).AddTicks(9676), "BIF", "Borimir_Moskalyuk@i.ua", "Звенимир", "Гнатишина", "канд. філос. наук", "(095) 264-16-40", "Прибиральник", 1041.95m, "Handcrafted Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 26, 5, 38, 35, 193, DateTimeKind.Local).AddTicks(4244), "вулиця Рудного, 214, Умань, Монголія", new DateTime(1968, 7, 26, 14, 43, 14, 45, DateTimeKind.Local).AddTicks(1825), "MDL", "Antonina48@e-mail.ua", new DateTime(2023, 12, 28, 21, 54, 53, 569, DateTimeKind.Local).AddTicks(8531), "Яромир", "Левадовська", "(091) 078-07-55", "Бухгалтер", 19367.85m, "driver" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 4, 4, 4, 55, 9, 572, DateTimeKind.Local).AddTicks(6435), "проспект Городоцька, 76, Слов’янськ, Самоа", new DateTime(1968, 6, 25, 15, 56, 4, 618, DateTimeKind.Local).AddTicks(4397), "AMD", "Ganna_Stepanec12@ex.ua", null, "Яромир", "Сірко", "докт. політ. наук", "(099) 881-70-30", 14262.84m, "Awesome Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 10, 2, 54, 31, 375, DateTimeKind.Local).AddTicks(993), "Зелена майдан, 315, Львів, Афганістан", new DateTime(1991, 6, 27, 15, 22, 44, 633, DateTimeKind.Local).AddTicks(213), "HNL", "Oleksandra97@meta.ua", new DateTime(2020, 9, 6, 17, 24, 50, 672, DateTimeKind.Local).AddTicks(7295), "Мальва", "Васильківський", "проф.", "(099) 416-09-29", "Програміст", 10658.04m, "Garden & Industrial" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 9, 26, 23, 38, 2, 107, DateTimeKind.Local).AddTicks(3493), "площа Молодіжна, 303, Слов’янськ, Сінгапур", new DateTime(2013, 12, 16, 5, 6, 21, 493, DateTimeKind.Local).AddTicks(2064), "ARS", "Lada27@meta.ua", new DateTime(2021, 7, 11, 9, 50, 27, 642, DateTimeKind.Local).AddTicks(3974), "Раїна", "Сосюра", "докт. філос. наук", "(066) 120-65-78", "Прибиральник", 13274.66m, "policy" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 5, 18, 24, 17, 912, DateTimeKind.Local).AddTicks(6376), "вулиця Вічева, 100, Північний Мирон, Болгарія", new DateTime(1956, 11, 13, 15, 35, 31, 576, DateTimeKind.Local).AddTicks(1978), "RUB", "Anton.Osadko@yandex.ua", new DateTime(2019, 11, 22, 15, 54, 26, 904, DateTimeKind.Local).AddTicks(5000), "Віталій", "Яворівський", "докт. філол. наук", "(094) 392-44-38", "Прибиральник", 13483.46m, "green" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 12, 18, 17, 49, 33, 416, DateTimeKind.Local).AddTicks(6508), "провулок Нижанківського, 4, Олександрія, Екваторіальна Гвінея", new DateTime(2023, 5, 11, 22, 5, 25, 439, DateTimeKind.Local).AddTicks(7935), "JOD", "Dobromir18@gmail.com", null, "Буревіст", "Галатей", "канд. філол. наук", "(094) 956-31-30", "Бухгалтер", 9823.41m, "District" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 11, 12, 52, 30, 8, DateTimeKind.Local).AddTicks(258), "Вузька майдан, 087, Південний Славомир, Південна Корея", new DateTime(1974, 7, 17, 1, 58, 43, 734, DateTimeKind.Local).AddTicks(7775), "BDT", "Bratislav.Splyukh65@e-mail.ua", null, "Ярослава", "Гаман", "канд. філол. наук", "(092) 875-20-39", "Секретар", 13749.68m, "Assistant" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 15, 8, 55, 53, 83, DateTimeKind.Local).AddTicks(6786), "пл. Зелена, 3, Горлівка, Венесуела", new DateTime(1986, 10, 15, 3, 51, 11, 536, DateTimeKind.Local).AddTicks(7900), "NZD", "Oleg.Prigoda38@i.ua", new DateTime(2021, 10, 25, 8, 29, 3, 928, DateTimeKind.Local).AddTicks(9574), "Братимир", "Бабух", "канд. філол. наук", "(063) 182-41-56", "Директор", 12042.35m, "Auto Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 3, 22, 32, 51, 908, DateTimeKind.Local).AddTicks(5839), "Нижанківського майдан, 78, Західний Петро, Алжир", new DateTime(2014, 11, 7, 16, 6, 47, 151, DateTimeKind.Local).AddTicks(7769), "BSD", "Volodislav_Mazilo31@ukr.net", "Руслан", "Гайчук", "канд. техн. наук", "(092) 528-79-33", "Секретар", 14906.70m, "indigo" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 8, 22, 5, 21, 717, DateTimeKind.Local).AddTicks(1314), "Стрийська майдан, 2, Східний Тур, Нігер", new DateTime(2010, 10, 23, 2, 39, 40, 955, DateTimeKind.Local).AddTicks(798), "SAR", "Gradimir39@ex.ua", "Ілона", "Федоришин", "канд. політ. наук", "(095) 716-07-51", 5187.74m, "Handcrafted Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 2, 21, 12, 16, 23, 460, DateTimeKind.Local).AddTicks(4940), "вулиця Молодіжна, 769, Керч, Мавританія", new DateTime(1964, 3, 3, 9, 55, 28, 524, DateTimeKind.Local).AddTicks(2860), "XAF", "Aelina48@gmail.com", new DateTime(2023, 11, 25, 10, 59, 36, 97, DateTimeKind.Local).AddTicks(4610), "Біляна", "Карпух", "канд. техн. наук", "(073) 644-72-26", "Програміст", 16294.27m, "Assistant" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 18, 0, 33, 20, 847, DateTimeKind.Local).AddTicks(8490), "вул. Нижанківського, 8, Кіровоград, Тринідад і Тобаго", new DateTime(1996, 5, 27, 9, 22, 34, 312, DateTimeKind.Local).AddTicks(8483), "PAB", "Ganna.Kononec@meta.ua", new DateTime(2023, 2, 27, 22, 30, 59, 126, DateTimeKind.Local).AddTicks(3749), "Каріна", "Дмитришин", "канд. філос. наук", "(093) 164-38-42", "Прибиральник", 9727.56m, "Legacy" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 28, 11, 44, 38, 445, DateTimeKind.Local).AddTicks(340), "проспект Винників, 19, Східний Ілля, Камерун", new DateTime(1965, 1, 5, 13, 9, 43, 646, DateTimeKind.Local).AddTicks(7144), "BND", "Yaroslava.Maistrenko@i.ua", new DateTime(2020, 9, 24, 7, 15, 3, 74, DateTimeKind.Local).AddTicks(9653), "Поліна", "Романів", "доц.", "(099) 269-54-80", "Секретар", 17549.18m, "Pines" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 11, 26, 21, 34, 13, 418, DateTimeKind.Local).AddTicks(1942), "Зелена майдан, 049, Східний Подолян, Швейцарія", new DateTime(2009, 1, 3, 4, 35, 52, 1, DateTimeKind.Local).AddTicks(3454), "WST", "Zinovii_Ivaniv28@yandex.ua", new DateTime(2023, 1, 3, 0, 4, 2, 836, DateTimeKind.Local).AddTicks(5291), "Анастасій", "Горбач", "канд. техн. наук", "(094) 973-44-53", "Секретар", 13347.64m, "Multi-tiered" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 2, 12, 11, 44, 5, 91, DateTimeKind.Local).AddTicks(7430), "проспект Вічева, 037, Умань, Сінгапур", new DateTime(1985, 1, 2, 5, 40, 47, 202, DateTimeKind.Local).AddTicks(3501), "ZAR", "Valentina24@meta.ua", null, "Юліан", "Плаксій", "докт. юрид. наук", "(093) 033-27-59", "Бухгалтер", 6347.49m, "Accounts" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 3, 1, 8, 59, 15, 457, DateTimeKind.Local).AddTicks(8206), "Вузька майдан, 78, Сімферополь, Конго", new DateTime(1956, 1, 31, 22, 55, 2, 521, DateTimeKind.Local).AddTicks(7974), "AZN", "Arsen.Luchko@meta.ua", new DateTime(2022, 3, 23, 13, 53, 19, 498, DateTimeKind.Local).AddTicks(5099), "Вікторія", "Бабух", "проф.", "(093) 860-64-73", "Секретар", 13797.25m, "SMTP" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 28, 11, 33, 49, 88, DateTimeKind.Local).AddTicks(3226), "Коліївщини майдан, 886, Західний Далемир, Словенія", new DateTime(1951, 5, 17, 12, 7, 30, 516, DateTimeKind.Local).AddTicks(3418), "XBA", "Sinook.Skoropadska@i.ua", null, "Станіслав", "Гришко", "канд. психол. наук", "(050) 778-59-49", "Прибиральник", 9447.81m, "Fantastic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 31, 19, 37, 1, 731, DateTimeKind.Local).AddTicks(9919), "вулиця Зелена, 2, Маріуполь, Гамбія", new DateTime(1992, 3, 26, 20, 52, 52, 733, DateTimeKind.Local).AddTicks(3912), "BRL", "Artem6@ukr.net", new DateTime(2020, 8, 18, 21, 57, 27, 968, DateTimeKind.Local).AddTicks(5499), "Жозефіна", "Євенко", "канд. психол. наук", "(050) 689-31-97", 9625.88m, "Liaison" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 12, 21, 16, 35, 39, 877, DateTimeKind.Local).AddTicks(5149), "пров. Рудного, 10, Алчевськ, Центральноафриканська Республіка", new DateTime(1999, 8, 19, 13, 21, 52, 313, DateTimeKind.Local).AddTicks(1478), "DZD", "Roksolan12@ex.ua", new DateTime(2022, 1, 28, 15, 16, 46, 719, DateTimeKind.Local).AddTicks(8586), "Буйтур", "Дмитрук", "канд. юрид. наук", "(091) 482-27-13", "Секретар", 7269.92m, "Cambridgeshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 16, 15, 14, 35, 675, DateTimeKind.Local).AddTicks(2594), "Староміська майдан, 564, Північний Микола, Бутан", new DateTime(1952, 9, 27, 17, 39, 11, 183, DateTimeKind.Local).AddTicks(5163), "SGD", "Antin_Osadko@meta.ua", new DateTime(2019, 4, 30, 0, 25, 22, 728, DateTimeKind.Local).AddTicks(5292), "Крентта", "Дзюба", "докт. психол. наук", "(091) 184-30-85", "Програміст", 2040.25m, "Island" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 8, 2, 13, 7, 34, 801, DateTimeKind.Local).AddTicks(6855), "Коліївщини майдан, 4, Шостка, Марокко", new DateTime(1963, 9, 29, 16, 21, 59, 765, DateTimeKind.Local).AddTicks(1712), "AOA", "Mechislava.Grineveckii@meta.ua", null, "Орина", "Кивач", "канд. філол. наук", "(050) 667-35-01", 9769.89m, "wireless" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 6, 1, 1, 41, 144, DateTimeKind.Local).AddTicks(4973), "провулок Вічева, 8, Кременчук, Ефіопія", new DateTime(2014, 4, 16, 17, 47, 54, 759, DateTimeKind.Local).AddTicks(4690), "GBP", "Biloslava_Yevenko@meta.ua", "Болеслава", "Семеночко", "(092) 631-60-73", "Програміст", 1818.61m, "technologies" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 2, 16, 45, 46, 381, DateTimeKind.Local).AddTicks(6021), "Рудного майдан, 730, Західний Даромир, Білорусь", new DateTime(1987, 2, 28, 19, 43, 31, 951, DateTimeKind.Local).AddTicks(6832), "SAR", "Oles97@e-mail.ua", "Болеслав", "Сучак", "докт. юрид. наук", "(093) 719-67-42", "Прибиральник", 12786.21m, "Fantastic Rubber Gloves" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 10, 8, 3, 57, 526, DateTimeKind.Local).AddTicks(5903), "проспект Рудного, 8, Західний Антоній, Того", new DateTime(2019, 6, 22, 1, 2, 28, 815, DateTimeKind.Local).AddTicks(1292), "GHS", "Burevist96@ex.ua", null, "Богдана", "Латан", "(066) 661-22-32", "Директор", 18973.17m, "Sleek" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 16, 1, 28, 17, 355, DateTimeKind.Local).AddTicks(2248), "вул. Ліста, 6, Біла Церква, Сьєрра-Леоне", new DateTime(1985, 8, 31, 16, 23, 26, 558, DateTimeKind.Local).AddTicks(3584), "DZD", "Mechislav_Mogilevska14@ukr.net", "Буйтур", "Притула", "докт. техн. наук", "(073) 847-15-58", "Програміст", 11123.20m, "compelling" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 3, 14, 59, 46, 625, DateTimeKind.Local).AddTicks(506), "площа Винників, 5, Євпаторія, Венесуела", new DateTime(1959, 8, 1, 0, 32, 37, 292, DateTimeKind.Local).AddTicks(2311), "BSD", "Orislava22@e-mail.ua", new DateTime(2020, 7, 13, 21, 43, 33, 253, DateTimeKind.Local).AddTicks(325), "Людмила", "Пасічник", "канд. пед. наук", "(050) 855-50-87", "Директор", 13145.87m, "payment" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 23, 9, 36, 19, 964, DateTimeKind.Local).AddTicks(6356), "площа Коліївщини, 089, Полтава, Білорусь", new DateTime(2012, 3, 6, 1, 40, 48, 887, DateTimeKind.Local).AddTicks(1196), "SRD", "Yeremii.Mogilevska27@ukr.net", null, "Корнелій", "Гаман", "докт. філос. наук", "(099) 845-92-24", "Директор", 16072.78m, "calculating" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 12, 21, 36, 59, 690, DateTimeKind.Local).AddTicks(4021), "Брюховичів майдан, 020, Східний Біломир, Монако", new DateTime(2021, 5, 31, 21, 24, 5, 819, DateTimeKind.Local).AddTicks(5950), "ETB", "Levko35@ukr.net", new DateTime(2022, 12, 1, 11, 46, 33, 231, DateTimeKind.Local).AddTicks(6219), "Дарій", "Пригода", "канд. філол. наук", "(091) 568-68-80", "Директор", 8348.25m, "Cape" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 23, 7, 34, 11, 143, DateTimeKind.Local).AddTicks(1839), "Брюховичів майдан, 3, Східний Ратибор, Тонга", new DateTime(1989, 4, 28, 7, 35, 59, 657, DateTimeKind.Local).AddTicks(9911), "EEK", "Pelagiya_Magera@ukr.net", "Боримисл", "Кордун", "докт. філос. наук", "(093) 812-65-53", "Прибиральник", 1470.67m, "Granite" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 8, 12, 7, 40, 45, 34, DateTimeKind.Local).AddTicks(7201), "Нижанківського майдан, 7, Луцьк, Словенія", new DateTime(1958, 2, 4, 7, 9, 39, 967, DateTimeKind.Local).AddTicks(1959), "MWK", "Fayina.Kovalenko19@ex.ua", "Звенигор", "Боровська", "докт. пед. наук", "(063) 882-15-61", "Директор", 15123.00m, "Right-sized" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 12, 9, 41, 27, 285, DateTimeKind.Local).AddTicks(1549), "пл. Стрийська, 672, Черкаси, Руанда", new DateTime(1944, 8, 5, 16, 22, 58, 262, DateTimeKind.Local).AddTicks(2903), "CUP", "Anzhela_Shukhevich3@yandex.ua", "Щек", "Федоришина", "докт. філос. наук", "(073) 545-55-68", "Секретар", 16598.89m, "Architect" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 5, 3, 2, 22, 51, 485, DateTimeKind.Local).AddTicks(7160), "проспект Зелена, 69, Західний Горислав, Куба", new DateTime(1960, 12, 19, 23, 33, 55, 664, DateTimeKind.Local).AddTicks(8755), "CZK", "Yaromil.Pavlishin26@yandex.ua", "Остап", "Яцишина", "докт. філол. наук", "(097) 856-96-22", "Програміст", 13227.62m, "Coves" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 4, 22, 6, 45, 24, 320, DateTimeKind.Local).AddTicks(419), "Рудного майдан, 6, Західний Назар, Словенія", new DateTime(1969, 1, 21, 22, 12, 41, 958, DateTimeKind.Local).AddTicks(1129), "XBD", "Yaroslava17@i.ua", null, "Альбіна", "Червоній", "канд. юрид. наук", "(093) 165-38-13", "Програміст", 5815.59m, "Enterprise-wide" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 11, 19, 49, 39, 824, DateTimeKind.Local).AddTicks(9072), "проспект Винників, 802, Бердичів, Нова Зеландія", new DateTime(1953, 7, 22, 11, 39, 38, 822, DateTimeKind.Local).AddTicks(2015), "CUP", "Bratislav.Yermak@e-mail.ua", new DateTime(2023, 8, 3, 22, 56, 25, 651, DateTimeKind.Local).AddTicks(4189), "Орина", "Гойко", "канд. техн. наук", "(093) 991-69-55", "Бухгалтер", 16573.69m, "Platinum" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 20, 8, 5, 56, 145, DateTimeKind.Local).AddTicks(5239), "пр. Ліста, 10, Керч, Андорра", new DateTime(1947, 6, 9, 3, 53, 39, 414, DateTimeKind.Local).AddTicks(9824), "IDR", "Rodoslav0@gmail.com", "Лариса", "Боровська", "доц.", "(044) 611-46-88", "Директор", 16713.23m, "Massachusetts" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 9, 29, 3, 51, 34, 896, DateTimeKind.Local).AddTicks(7884), "вулиця Коліївщини, 255, Харків, Нігерія", new DateTime(1984, 3, 16, 18, 3, 0, 11, DateTimeKind.Local).AddTicks(6092), "PKR", "Igor_Kornyiichuk49@ex.ua", "Олег", "Ліхно", "канд. психол. наук", "(097) 461-65-79", 14461.91m, "New Hampshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 21, 5, 18, 41, 70, DateTimeKind.Local).AddTicks(2705), "вул. Рудного, 946, Східний Роман, Того", new DateTime(1944, 7, 2, 18, 51, 29, 476, DateTimeKind.Local).AddTicks(9515), "PGK", "Liliya32@i.ua", new DateTime(2023, 11, 21, 9, 59, 11, 434, DateTimeKind.Local).AddTicks(2391), "Брячислав", "Поривайло", "канд. політ. наук", "(098) 054-63-18", "Програміст", 10099.34m, "hack" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 8, 26, 16, 35, 17, 104, DateTimeKind.Local).AddTicks(5288), "вул. Ліста, 2, Східний Арсен, Німеччина", new DateTime(2015, 5, 22, 11, 27, 32, 769, DateTimeKind.Local).AddTicks(7200), "DZD", "Boris42@ex.ua", null, "Святослав", "Гамула", "докт. філол. наук", "(094) 081-28-80", 7729.53m, "GB" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 22, 3, 26, 47, 654, DateTimeKind.Local).AddTicks(5756), "Зелена майдан, 5, Слов’янськ, Федеративні Штати Мікронезії", new DateTime(1958, 11, 10, 5, 9, 53, 193, DateTimeKind.Local).AddTicks(4916), "TJS", "Irma.Kivach@i.ua", new DateTime(2023, 12, 18, 7, 11, 54, 760, DateTimeKind.Local).AddTicks(7360), "Захар", "Сучак", "канд. філол. наук", "(073) 491-19-59", "Прибиральник", 3075.77m, "driver" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 18, 21, 53, 38, 49, DateTimeKind.Local).AddTicks(432), "Рудного майдан, 7, Ужгород, Тринідад і Тобаго", new DateTime(1989, 5, 9, 8, 27, 25, 189, DateTimeKind.Local).AddTicks(8858), "TOP", "Anatoliya_Kalach@gmail.com", new DateTime(2023, 4, 24, 5, 6, 5, 981, DateTimeKind.Local).AddTicks(1044), "Лук’ян", "Бурмило", "докт. і. наук", "(066) 992-13-76", 12692.11m, "Turkish Lira" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 22, 1, 5, 24, 84, DateTimeKind.Local).AddTicks(6162), "пров. Вузька, 82, Південний Златомир, Лесото", new DateTime(1969, 4, 4, 18, 23, 0, 793, DateTimeKind.Local).AddTicks(8831), "TWD", "Valentin_Kordun3@ex.ua", new DateTime(2020, 1, 28, 3, 40, 21, 938, DateTimeKind.Local).AddTicks(908), "Зоряна", "Юрчишина", "докт. техн. наук", "(066) 096-56-84", 1190.90m, "Phased" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 31, 7, 7, 18, 592, DateTimeKind.Local).AddTicks(7464), "провулок Винників, 948, Лисичанськ, Уганда", new DateTime(1994, 7, 18, 15, 30, 47, 50, DateTimeKind.Local).AddTicks(2993), "MAD", "Ivan_Kulinich@yandex.ua", "Любомир", "Яловий", "докт. філол. наук", "(066) 527-84-59", "Прибиральник", 11279.24m, "Shores" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 4, 28, 6, 54, 30, 109, DateTimeKind.Local).AddTicks(1115), "пр. Рудного, 578, Хмельницький, Узбекистан", new DateTime(2007, 2, 25, 5, 45, 55, 358, DateTimeKind.Local).AddTicks(8113), "EGP", "Okhrim_Cimbalistii90@ex.ua", new DateTime(2019, 8, 5, 11, 28, 40, 481, DateTimeKind.Local).AddTicks(8037), "Божен", "Майстренко", "докт. юрид. наук", "(097) 901-96-63", 15327.27m, "generate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 9, 11, 18, 7, 19, 281, DateTimeKind.Local).AddTicks(2693), "Вузька майдан, 6, Сєвєродонецьк, Уругвай", new DateTime(1960, 9, 20, 21, 37, 59, 191, DateTimeKind.Local).AddTicks(9441), "XAF", "Daleslava73@i.ua", null, "Марта", "Мотрієнко", "канд. політ. наук", "(096) 179-50-64", 16223.82m, "Licensed Granite Bike" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 3, 19, 0, 19, 12, 541, DateTimeKind.Local).AddTicks(8331), "Ліста майдан, 63, Північний Пилип, Маршаллові Острови", new DateTime(1952, 2, 23, 3, 49, 57, 383, DateTimeKind.Local).AddTicks(9302), "SDG", "Daromir.Tryasun@meta.ua", new DateTime(2024, 1, 29, 6, 51, 38, 153, DateTimeKind.Local).AddTicks(6515), "Корнилій", "Бутько", "канд. пед. наук", "(091) 870-99-63", "Програміст", 7109.55m, "backing up" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 16, 2, 39, 33, 814, DateTimeKind.Local).AddTicks(2876), "пр. Молодіжна, 1, Південний Корній, Південно-Африканська Республіка", new DateTime(2023, 10, 30, 19, 40, 26, 886, DateTimeKind.Local).AddTicks(8728), "KRW", "Ruslan_Dmitrishin52@ex.ua", "Тимофій", "Кульчицький", "канд. і. наук", "(091) 591-80-42", "Програміст", 19008.76m, "projection" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 13, 16, 39, 7, 866, DateTimeKind.Local).AddTicks(1825), "Зелена майдан, 095, Північний Зеновій, Саудівська Аравія", new DateTime(1945, 10, 25, 7, 32, 55, 322, DateTimeKind.Local).AddTicks(9569), "BGN", "Vasilina6@meta.ua", new DateTime(2020, 8, 14, 6, 21, 17, 69, DateTimeKind.Local).AddTicks(8988), "Антон", "Сірко", "канд. і. наук", "(098) 140-90-21", "Бухгалтер", 4808.09m, "schemas" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 8, 11, 3, 35, 6, 754, DateTimeKind.Local).AddTicks(6601), "пл. Ліста, 672, Львів, Судан", new DateTime(2016, 5, 1, 17, 13, 35, 88, DateTimeKind.Local).AddTicks(8446), "CHF", "Makar98@meta.ua", new DateTime(2022, 4, 15, 7, 55, 7, 247, DateTimeKind.Local).AddTicks(6147), "Благовіста", "Троян", "канд. техн. наук", "(092) 749-51-04", "Програміст", 13531.04m, "Fundamental" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 12, 23, 37, 1, 745, DateTimeKind.Local).AddTicks(1310), "Вічева майдан, 55, Західний Віталій, Східний Тимор", new DateTime(1968, 1, 17, 7, 12, 52, 10, DateTimeKind.Local).AddTicks(6006), "MWK", "Valeriya_Lobachevska@i.ua", new DateTime(2023, 1, 13, 13, 24, 13, 713, DateTimeKind.Local).AddTicks(9763), "Меланія", "Свидригайло", "докт. техн. наук", "(073) 336-91-94", "Секретар", 2252.45m, "New Hampshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 9, 21, 45, 56, 488, DateTimeKind.Local).AddTicks(420), "Городоцька майдан, 028, Західний Родіон, Словаччина", new DateTime(1981, 3, 8, 16, 33, 17, 938, DateTimeKind.Local).AddTicks(1342), "TRY", "Bozhena_Romei91@ex.ua", null, "Раїна", "Петрина", "канд. пед. наук", "(099) 067-79-67", 18757.69m, "Identity" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 11, 26, 1, 58, 47, 910, DateTimeKind.Local).AddTicks(5356), "Брюховичів майдан, 5, Західний Земислав, Україна", new DateTime(1957, 10, 19, 3, 41, 50, 466, DateTimeKind.Local).AddTicks(1736), "XAG", "Omelyan.Dovgalevskii1@gmail.com", new DateTime(2019, 4, 29, 14, 46, 35, 452, DateTimeKind.Local).AddTicks(4487), "Соломія", "Бачей", "канд. юрид. наук", "(093) 462-39-72", "Директор", 18704.19m, "Grocery & Sports" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 5, 25, 7, 41, 14, 381, DateTimeKind.Local).AddTicks(8797), "Стрийська майдан, 196, Північний Будимир, Бельгія", new DateTime(1947, 4, 23, 14, 18, 46, 500, DateTimeKind.Local).AddTicks(1251), "LBP", "Maiya_Luchko47@ex.ua", new DateTime(2023, 6, 9, 2, 3, 0, 496, DateTimeKind.Local).AddTicks(3741), "Ореста", "Корнїйчук", "канд. техн. наук", "(050) 752-61-92", "Директор", 7551.30m, "Frozen" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 21, 11, 22, 37, 505, DateTimeKind.Local).AddTicks(941), "Молодіжна майдан, 97, Харків, Польща", new DateTime(2014, 1, 19, 12, 43, 49, 332, DateTimeKind.Local).AddTicks(6688), "XOF", "Virginiya.Kovalenko@e-mail.ua", new DateTime(2024, 3, 18, 17, 33, 46, 246, DateTimeKind.Local).AddTicks(7997), "Ксенія", "Ткаченко", "проф.", "(044) 842-35-43", 13034.54m, "Iowa" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 11, 13, 23, 17, 17, 326, DateTimeKind.Local).AddTicks(220), "Ліста майдан, 49, Західний Лук’ян, Ватикан", new DateTime(2014, 9, 28, 9, 0, 6, 722, DateTimeKind.Local).AddTicks(8023), "BWP", "Zabava_Lindik37@gmail.com", new DateTime(2021, 12, 20, 16, 30, 36, 682, DateTimeKind.Local).AddTicks(5978), "Олександр", "Яворівська", "докт. пед. наук", "(092) 546-65-95", 8444.15m, "Florida" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 7, 1, 23, 21, 41, 702, DateTimeKind.Local).AddTicks(5567), "площа Брюховичів, 92, Західний Олелько, Португалія", new DateTime(2021, 6, 8, 10, 16, 30, 373, DateTimeKind.Local).AddTicks(5005), "PLN", "Biloslav61@meta.ua", new DateTime(2021, 5, 27, 15, 2, 9, 113, DateTimeKind.Local).AddTicks(8421), "Земислав", "Могилевський", "докт. юрид. наук", "(096) 078-75-42", "Прибиральник", 3824.16m, "Overpass" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 1, 13, 17, 27, 56, 554, DateTimeKind.Local).AddTicks(7165), "Коліївщини майдан, 238, Північний Божен, Танзанія", new DateTime(1986, 2, 13, 1, 37, 5, 589, DateTimeKind.Local).AddTicks(8318), "MWK", "Chornota.Latanska40@yandex.ua", new DateTime(2022, 12, 9, 17, 6, 1, 931, DateTimeKind.Local).AddTicks(612), "Віталій", "Гарай", "канд. юрид. наук", "(073) 510-57-70", "Секретар", 16079.62m, "Cuba" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 24, 21, 16, 51, 154, DateTimeKind.Local).AddTicks(335), "Брюховичів майдан, 44, Полтава, Самоа", new DateTime(1957, 2, 28, 22, 32, 17, 904, DateTimeKind.Local).AddTicks(3680), "CUP", "Sergii.Semeshuk18@i.ua", new DateTime(2019, 7, 24, 3, 30, 5, 329, DateTimeKind.Local).AddTicks(5929), "Зорян", "Бурмило", "канд. філос. наук", "(094) 236-30-78", "Прибиральник", 11184.79m, "Incredible Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 6, 23, 35, 17, 996, DateTimeKind.Local).AddTicks(6256), "Винників майдан, 7, Східний Захарій, Лаос", new DateTime(1997, 5, 13, 9, 5, 57, 919, DateTimeKind.Local).AddTicks(3883), "QAR", "Lyudomila8@ukr.net", null, "Федора", "Іванців", "(099) 907-45-64", "Програміст", 4124.01m, "parsing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 12, 29, 21, 28, 47, 241, DateTimeKind.Local).AddTicks(1422), "Вузька майдан, 855, Кам’янець-Подільський, Сент-Кітс і Невіс", new DateTime(1969, 8, 30, 18, 27, 2, 360, DateTimeKind.Local).AddTicks(4277), "AOA", "Ganna_Lagoida@i.ua", new DateTime(2022, 1, 29, 4, 0, 28, 564, DateTimeKind.Local).AddTicks(5953), "Юхима", "Петрів", "проф.", "(095) 493-85-76", "Секретар", 7508.72m, "Alley" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 14, 22, 18, 24, 564, DateTimeKind.Local).AddTicks(202), "Брюховичів майдан, 7, Східний Дмитро, Португалія", new DateTime(2010, 8, 4, 5, 25, 48, 205, DateTimeKind.Local).AddTicks(9832), "UYU", "Askold77@meta.ua", "Майя", "Трублаєвська", "канд. і. наук", "(092) 476-64-16", "Прибиральник", 10919.66m, "Supervisor" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 7, 20, 54, 24, 877, DateTimeKind.Local).AddTicks(2978), "вулиця Молодіжна, 722, Західний Братослав, Малаві", new DateTime(1979, 2, 15, 21, 59, 19, 425, DateTimeKind.Local).AddTicks(3967), "MNT", "Yurii60@ukr.net", new DateTime(2023, 6, 9, 3, 27, 13, 485, DateTimeKind.Local).AddTicks(9040), "Володимир", "Савицький", "канд. пед. наук", "(050) 019-95-38", "Прибиральник", 19392.50m, "monitor" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 18, 11, 4, 19, 516, DateTimeKind.Local).AddTicks(4573), "провулок Зелена, 5, Західний Божемир, Марокко", new DateTime(1949, 8, 27, 2, 51, 4, 117, DateTimeKind.Local).AddTicks(4658), "SLL", "Mechislav.Semenochko65@ukr.net", "Мотря", "Яворівський", "докт. пед. наук", "(095) 338-12-06", "Бухгалтер", 3613.62m, "Lead" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 3, 2, 19, 41, 5, 44, DateTimeKind.Local).AddTicks(2886), "вул. Городоцька, 8, Західний Анастас, Мальдіви", new DateTime(1991, 11, 18, 14, 2, 37, 876, DateTimeKind.Local).AddTicks(8673), "BSD", "Tikhon.Miloslavskii@e-mail.ua", null, "Юхим", "Гречко", "доц.", "(097) 862-74-67", "Програміст", 9398.17m, "Generic Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 4, 0, 38, 2, 730, DateTimeKind.Local).AddTicks(2673), "Городоцька майдан, 700, Північний Антін, Іспанія", new DateTime(1947, 2, 13, 17, 55, 41, 569, DateTimeKind.Local).AddTicks(7994), "TZS", "Yulianna_Sidleckii@i.ua", new DateTime(2024, 3, 7, 9, 4, 40, 602, DateTimeKind.Local).AddTicks(8897), "Нестор", "Пагутяк", "докт. філос. наук", "(073) 722-11-08", "Прибиральник", 17165.62m, "Rustic Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 30, 4, 15, 22, 117, DateTimeKind.Local).AddTicks(8876), "пр. Городоцька, 72, Маріуполь, США", new DateTime(1968, 7, 18, 0, 11, 54, 564, DateTimeKind.Local).AddTicks(2195), "NZD", "Vladislav.Vereshuk26@i.ua", null, "Долеслава", "Савицька", "канд. техн. наук", "(093) 462-75-11", "Секретар", 1462.09m, "fault-tolerant" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 8, 10, 51, 7, 643, DateTimeKind.Local).AddTicks(3006), "Нижанківського майдан, 254, Східний Адам, Зімбабве", new DateTime(2002, 6, 11, 16, 54, 49, 448, DateTimeKind.Local).AddTicks(5346), "BZD", "Vsevlad29@yandex.ua", null, "Юстина", "Петрів", "докт. психол. наук", "(097) 527-43-11", "Прибиральник", 9731.41m, "Prairie" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 4, 5, 1, 45, 15, 974, DateTimeKind.Local).AddTicks(5343), "провулок Городоцька, 8, Луцьк, Україна", new DateTime(1978, 1, 5, 3, 35, 31, 973, DateTimeKind.Local).AddTicks(9726), "LSL", "Bozhemir_Zabila@e-mail.ua", new DateTime(2023, 2, 15, 3, 50, 18, 684, DateTimeKind.Local).AddTicks(4201), "Жанна", "Білич", "докт. філол. наук", "(066) 119-90-76", "Бухгалтер", 17151.14m, "engineer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 5, 21, 5, 51, 59, 865, DateTimeKind.Local).AddTicks(625), "площа Староміська, 78, Чернігів, Сан-Марино", new DateTime(1988, 11, 26, 6, 44, 8, 347, DateTimeKind.Local).AddTicks(1312), "NIO", "Oleg27@e-mail.ua", new DateTime(2020, 7, 15, 22, 37, 30, 193, DateTimeKind.Local).AddTicks(9171), "Інна", "Гайова", "канд. і. наук", "(094) 600-37-91", "Директор", 19690.01m, "foreground" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 3, 12, 51, 45, 363, DateTimeKind.Local).AddTicks(4682), "Винників майдан, 03, Східний Юхим, Боснія і Герцеговина", new DateTime(1996, 9, 2, 17, 45, 21, 43, DateTimeKind.Local).AddTicks(3742), "CRC", "Zinayida.Sosyura@gmail.com", new DateTime(2021, 2, 16, 19, 8, 6, 959, DateTimeKind.Local).AddTicks(8893), "Лариса", "Горова", "канд. психол. наук", "(092) 035-02-45", "Бухгалтер", 7572.40m, "transform" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 12, 6, 0, 39, 34, 389, DateTimeKind.Local).AddTicks(5776), "площа Городоцька, 2, Північний В’ячеслав, Бруней", new DateTime(2019, 6, 27, 23, 28, 47, 382, DateTimeKind.Local).AddTicks(1220), "THB", "Lyubislava_Didukh33@ex.ua", "Люборада", "Лугова", "проф.", "(092) 680-96-24", 18445.73m, "Street" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 24, 12, 41, 25, 78, DateTimeKind.Local).AddTicks(9093), "вул. Вічева, 58, Південний Денис, Вірменія", new DateTime(1953, 10, 17, 1, 45, 36, 830, DateTimeKind.Local).AddTicks(593), "JPY", "Izyaslav60@ukr.net", "Іннеса", "Громико", "канд. юрид. наук", "(096) 793-92-35", "Секретар", 4763.33m, "sky blue" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 7, 8, 0, 59, 388, DateTimeKind.Local).AddTicks(7501), "вул. Зелена, 990, Південний Борислав, Фінляндія", new DateTime(2021, 9, 18, 3, 3, 7, 673, DateTimeKind.Local).AddTicks(1705), "XBA", "Listvich81@meta.ua", null, "Зеновій", "Бамбула", "докт. психол. наук", "(099) 414-32-57", 18894.40m, "user-centric" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 16, 9, 48, 28, 827, DateTimeKind.Local).AddTicks(9734), "Нижанківського майдан, 4, Південний Ладислав, Мальта", new DateTime(1973, 4, 16, 20, 36, 39, 504, DateTimeKind.Local).AddTicks(5691), "PKR", "Dobroslava40@meta.ua", null, "Галина", "Демчишина", "докт. пед. наук", "(050) 761-93-09", "Прибиральник", 2044.43m, "Sleek Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 4, 1, 7, 26, 824, DateTimeKind.Local).AddTicks(754), "Вічева майдан, 987, Алчевськ, Бурунді", new DateTime(1964, 3, 10, 11, 5, 18, 997, DateTimeKind.Local).AddTicks(9238), "ETB", "Dobroslav.Lanova@meta.ua", null, "Григорій", "Троян", "докт. філол. наук", "(073) 027-95-63", "Директор", 15609.81m, "attitude-oriented" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 30, 5, 35, 32, 96, DateTimeKind.Local).AddTicks(9080), "Вузька майдан, 296, Східний Пилип, Словенія", new DateTime(1979, 12, 1, 20, 22, 27, 727, DateTimeKind.Local).AddTicks(8236), "GBP", "Yaromil79@e-mail.ua", null, "Юхимія", "Мазайло", "докт. техн. наук", "(063) 313-64-34", "Програміст", 3124.33m, "customized" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 21, 14, 2, 57, 83, DateTimeKind.Local).AddTicks(3897), "вул. Рудного, 77, Західний Ярема, Азербайджан", new DateTime(1974, 1, 24, 17, 44, 43, 97, DateTimeKind.Local).AddTicks(2742), "BDT", "Sergii30@meta.ua", new DateTime(2022, 8, 1, 22, 43, 17, 958, DateTimeKind.Local).AddTicks(2559), "Юстина", "Гаман", "докт. філос. наук", "(098) 462-46-52", "Програміст", 5634.59m, "Practical Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 5, 21, 13, 47, 49, 393, DateTimeKind.Local).AddTicks(4591), "Староміська майдан, 324, Ужгород, Барбадос", new DateTime(2003, 11, 4, 11, 58, 45, 346, DateTimeKind.Local).AddTicks(5770), "XFU", "Viola_Shiyan82@gmail.com", new DateTime(2022, 3, 12, 9, 0, 56, 407, DateTimeKind.Local).AddTicks(2476), "Тетяна", "Усич", "проф.", "(096) 632-98-48", 8960.70m, "Games" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 4, 13, 54, 22, 59, DateTimeKind.Local).AddTicks(3947), "вулиця Городоцька, 58, Північний Всеслав, Суринам", new DateTime(2006, 10, 2, 12, 53, 58, 716, DateTimeKind.Local).AddTicks(7646), "MXN", "Slava34@ukr.net", null, "Зоя", "Щербак", "докт. філол. наук", "(092) 748-09-69", "Прибиральник", 4853.42m, "transmit" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 1, 11, 38, 57, 941, DateTimeKind.Local).AddTicks(3433), "Винників майдан, 249, Черкаси, Ірландія", new DateTime(1961, 7, 27, 19, 8, 17, 503, DateTimeKind.Local).AddTicks(9430), "WST", "Kornilo.Pagutyak56@ukr.net", "Таїсія", "Дзюб’як", "канд. політ. наук", "(091) 048-40-03", "Прибиральник", 5747.83m, "projection" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 9, 19, 21, 25, 6, 901, DateTimeKind.Local).AddTicks(7622), "Нижанківського майдан, 579, Західний Зиновій, Естонія", new DateTime(1970, 7, 2, 18, 35, 46, 623, DateTimeKind.Local).AddTicks(1201), "SYP", "Panteleimon.Slobodyan40@ex.ua", new DateTime(2021, 12, 14, 2, 5, 27, 653, DateTimeKind.Local).AddTicks(1597), "Олена", "Скиба", "канд. юрид. наук", "(091) 625-14-36", 19593.77m, "deliver" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 31, 16, 24, 21, 477, DateTimeKind.Local).AddTicks(4093), "Староміська майдан, 47, Кременчук, Кот-д’Івуар", new DateTime(1967, 6, 6, 7, 9, 24, 455, DateTimeKind.Local).AddTicks(2189), "COP", "Palazhka_Yashuk@yandex.ua", "Аврелій", "Бамбула", "канд. психол. наук", "(093) 362-60-64", "Директор", 14717.84m, "Louisiana" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 18, 5, 46, 15, 440, DateTimeKind.Local).AddTicks(6969), "Брюховичів майдан, 820, Бердичів, Ботсвана", new DateTime(1947, 8, 19, 0, 1, 34, 154, DateTimeKind.Local).AddTicks(4240), "DOP", "Miroslav94@meta.ua", null, "Сологуб", "Пономарів", "канд. і. наук", "(099) 059-81-44", "Секретар", 11475.99m, "navigating" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 3, 17, 11, 32, 13, 147, DateTimeKind.Local).AddTicks(19), "пл. Вузька, 12, Західний Левко, Сейшельські Острови", new DateTime(2000, 2, 2, 15, 52, 3, 56, DateTimeKind.Local).AddTicks(2892), "AFN", "Oresta32@e-mail.ua", "Руслан", "Коцюбинська", "канд. техн. наук", "(098) 136-14-17", "Програміст", 9355.70m, "Associate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 4, 28, 12, 37, 23, 255, DateTimeKind.Local).AddTicks(2388), "Вічева майдан, 62, Південний Юліан, Конго", new DateTime(1951, 9, 14, 10, 31, 46, 934, DateTimeKind.Local).AddTicks(1495), "LAK", "Ladomir_Dmitrishina@meta.ua", null, "Назар", "Брицький", "докт. філос. наук", "(092) 701-97-04", 7190.47m, "Flats" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 3, 27, 10, 47, 58, 358, DateTimeKind.Local).AddTicks(4704), "Нижанківського майдан, 790, Чернігів, Камбоджа", new DateTime(1988, 5, 22, 10, 46, 19, 873, DateTimeKind.Local).AddTicks(8184), "PEN", "Maiya65@e-mail.ua", null, "Гнат", "Трясило", "канд. політ. наук", "(091) 005-13-56", "Директор", 1886.00m, "Monitored" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 23, 2, 16, 53, 941, DateTimeKind.Local).AddTicks(8472), "пл. Молодіжна, 7, Бердичів, В’єтнам", new DateTime(2022, 3, 16, 3, 28, 23, 570, DateTimeKind.Local).AddTicks(5621), "TWD", "Nemir21@ukr.net", new DateTime(2019, 10, 14, 22, 48, 41, 923, DateTimeKind.Local).AddTicks(628), "Юліанна", "Мазило", "канд. і. наук", "(044) 834-40-74", 19887.11m, "Borders" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 11, 7, 12, 19, 11, 352, DateTimeKind.Local).AddTicks(7506), "пр. Староміська, 23, Вінниця, Алжир", new DateTime(2005, 12, 26, 10, 46, 28, 916, DateTimeKind.Local).AddTicks(2859), "LRD", "Rayisa_Stigailo22@ex.ua", new DateTime(2024, 2, 1, 15, 18, 2, 782, DateTimeKind.Local).AddTicks(9940), "Богуслава", "Пасічник", "(099) 034-29-62", 12130.60m, "Bedfordshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 31, 9, 24, 17, 865, DateTimeKind.Local).AddTicks(3161), "пр. Городоцька, 0, Шостка, Уругвай", new DateTime(1971, 8, 18, 22, 25, 12, 490, DateTimeKind.Local).AddTicks(3337), "MMK", "Vilena.Makoveckii56@ex.ua", null, "Потап", "Шестак", "докт. політ. наук", "(091) 456-61-55", "Директор", 11165.97m, "Netherlands Antillian Guilder" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 9, 14, 16, 6, 57, 500, DateTimeKind.Local).AddTicks(2277), "Вузька майдан, 7, Бровари, Габон", new DateTime(1951, 11, 17, 13, 41, 37, 911, DateTimeKind.Local).AddTicks(7619), "KWD", "Roksolan12@yandex.ua", new DateTime(2023, 6, 21, 4, 25, 33, 658, DateTimeKind.Local).AddTicks(5825), "Ратимир", "Дзюба", "канд. психол. наук", "(093) 706-99-07", "Програміст", 5559.93m, "capacitor" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 9, 26, 2, 33, 43, 733, DateTimeKind.Local).AddTicks(1574), "вулиця Ліста, 8, Південний Радимир, Замбія", new DateTime(1956, 11, 19, 20, 7, 37, 359, DateTimeKind.Local).AddTicks(6785), "XDR", "Maryana30@ukr.net", null, "Соня", "Сушко", "докт. юрид. наук", "(066) 784-28-45", "Директор", 15739.30m, "Practical" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 1, 25, 16, 37, 18, 438, DateTimeKind.Local).AddTicks(3604), "Брюховичів майдан, 0, Слов’янськ, Швеція", new DateTime(1975, 6, 25, 15, 38, 23, 290, DateTimeKind.Local).AddTicks(8239), "UGX", "Valentin16@i.ua", new DateTime(2022, 8, 5, 3, 10, 44, 201, DateTimeKind.Local).AddTicks(2128), "Будимир", "Павлишин", "докт. політ. наук", "(094) 042-40-18", 13775.47m, "Lao People's Democratic Republic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 12, 31, 14, 42, 17, 571, DateTimeKind.Local).AddTicks(7707), "Стрийська майдан, 65, Красний Луч, Коста-Рика", new DateTime(1954, 11, 8, 4, 28, 32, 837, DateTimeKind.Local).AddTicks(4310), "SGD", "Oksana.Berdnik@ukr.net", new DateTime(2019, 12, 20, 14, 1, 27, 837, DateTimeKind.Local).AddTicks(7099), "Матвій", "Линдик", "канд. пед. наук", "(096) 107-89-63", "Прибиральник", 16808.11m, "system" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 11, 25, 9, 41, 41, 138, DateTimeKind.Local).AddTicks(8926), "Стрийська майдан, 2, Краматорськ, Сенеґал", new DateTime(1953, 6, 4, 0, 48, 27, 213, DateTimeKind.Local).AddTicks(7807), "SBD", "Okhrim.Prigoda@yandex.ua", new DateTime(2024, 4, 3, 23, 49, 40, 32, DateTimeKind.Local).AddTicks(9693), "Орина", "Потоцька", "канд. психол. наук", "(066) 420-21-09", "Бухгалтер", 17543.55m, "Analyst" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 11, 28, 5, 13, 34, 166, DateTimeKind.Local).AddTicks(3811), "вулиця Городоцька, 47, Північний Звенимир, Туреччина", new DateTime(2006, 1, 20, 22, 55, 42, 151, DateTimeKind.Local).AddTicks(1423), "ILS", "Zinayida.Serdyuk53@ukr.net", null, "Богдан", "Тарасюк", "проф.", "(098) 794-39-47", "Секретар", 19940.69m, "system" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 11, 14, 9, 22, 54, 43, DateTimeKind.Local).AddTicks(5899), "Зелена майдан, 82, Північний Будимир, Барбадос", new DateTime(1953, 6, 6, 6, 2, 24, 483, DateTimeKind.Local).AddTicks(4136), "TMT", "Sofiya.Motriyenko86@e-mail.ua", "Володислав", "Михайлюк", "канд. юрид. наук", "(063) 260-69-07", "Програміст", 1191.19m, "Personal Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 4, 7, 2, 2, 23, 727, DateTimeKind.Local).AddTicks(4205), "пр. Зелена, 73, Північний Максим, Бруней", new DateTime(1994, 9, 2, 20, 10, 57, 373, DateTimeKind.Local).AddTicks(4320), "KZT", "Lyuboslava.Dzyuba@gmail.com", new DateTime(2023, 3, 23, 12, 57, 49, 472, DateTimeKind.Local).AddTicks(1387), "Сніжан", "Палій", "канд. філос. наук", "(094) 428-67-17", 5739.42m, "Gorgeous Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 22, 11, 41, 59, 438, DateTimeKind.Local).AddTicks(1690), "Городоцька майдан, 9, Північний Микола, Чехія", new DateTime(1964, 6, 29, 2, 34, 54, 50, DateTimeKind.Local).AddTicks(2170), "AOA", "Khristina43@e-mail.ua", new DateTime(2023, 1, 21, 1, 33, 5, 657, DateTimeKind.Local).AddTicks(8213), "Тимофій", "Спотикач", "канд. психол. наук", "(092) 492-74-67", "Прибиральник", 10870.41m, "Electronics" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 17, 1, 13, 33, 615, DateTimeKind.Local).AddTicks(1528), "вул. Староміська, 321, Північний Брячислав, Туніс", new DateTime(1945, 7, 23, 21, 18, 8, 886, DateTimeKind.Local).AddTicks(9433), "BMD", "Ivan95@e-mail.ua", null, "Діяна", "Ярмак", "докт. юрид. наук", "(092) 303-55-90", "Прибиральник", 10035.82m, "Berkshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 18, 9, 52, 51, 114, DateTimeKind.Local).AddTicks(4437), "Вузька майдан, 80, Західний Братимир, Чилі", new DateTime(1994, 5, 6, 0, 0, 57, 304, DateTimeKind.Local).AddTicks(6734), "SOS", "Oriyana_Baranovskii@meta.ua", null, "Денис", "Боровська", "докт. філол. наук", "(092) 595-59-77", "Секретар", 9057.09m, "content-based" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 9, 2, 20, 25, 44, 413, DateTimeKind.Local).AddTicks(2881), "Молодіжна майдан, 7, Південний Маркіян, Бразилія", new DateTime(1956, 8, 11, 20, 31, 29, 732, DateTimeKind.Local).AddTicks(3365), "LVL", "Anatolii_Yushik94@gmail.com", new DateTime(2020, 5, 25, 8, 37, 58, 269, DateTimeKind.Local).AddTicks(8150), "Родіон", "Дурдинець", "докт. пед. наук", "(063) 534-67-62", "Директор", 5681.49m, "JSON" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 9, 11, 21, 17, 59, 552, DateTimeKind.Local).AddTicks(3032), "Молодіжна майдан, 613, Південний Анатолій, Болгарія", new DateTime(2009, 10, 29, 16, 38, 8, 824, DateTimeKind.Local).AddTicks(3203), "INR", "Zinovii38@ex.ua", new DateTime(2020, 2, 4, 17, 22, 55, 789, DateTimeKind.Local).AddTicks(9611), "Арсеній", "Павлишина", "докт. і. наук", "(063) 945-38-65", "Секретар", 14216.89m, "paradigms" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 3, 16, 17, 31, 39, 626, DateTimeKind.Local).AddTicks(7544), "Рудного майдан, 447, Західний Мстислав, Андорра", new DateTime(1946, 4, 25, 14, 53, 33, 443, DateTimeKind.Local).AddTicks(7525), "BBD", "Andrii.Mazun@i.ua", new DateTime(2023, 7, 14, 22, 23, 23, 7, DateTimeKind.Local).AddTicks(7749), "Зореслава", "Кульчицький", "канд. філос. наук", "(098) 751-47-23", "Директор", 13542.77m, "De-engineered" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 27, 23, 42, 1, 290, DateTimeKind.Local).AddTicks(5885), "вулиця Ліста, 728, Ялта, Домініканська Республіка", new DateTime(2001, 2, 7, 4, 13, 50, 998, DateTimeKind.Local).AddTicks(5591), "CUP", "Ostap93@e-mail.ua", null, "Велемир", "Трублаєвський", "канд. філол. наук", "(095) 856-29-78", 13979.54m, "Locks" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 12, 29, 0, 57, 34, 360, DateTimeKind.Local).AddTicks(967), "пл. Рудного, 605, Західний Братислав, Самоа", new DateTime(1980, 10, 21, 8, 17, 11, 594, DateTimeKind.Local).AddTicks(9032), "AMD", "Slava.Chervonii91@gmail.com", new DateTime(2022, 8, 27, 17, 16, 17, 847, DateTimeKind.Local).AddTicks(3030), "Ромена", "Білич", "докт. політ. наук", "(066) 273-36-68", "Бухгалтер", 1192.02m, "Australian Dollar" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 11, 30, 17, 26, 56, 713, DateTimeKind.Local).AddTicks(7614), "Вічева майдан, 320, Севастополь, Уганда", new DateTime(1959, 1, 17, 21, 55, 57, 351, DateTimeKind.Local).AddTicks(2746), "XBB", "Zemislav.Borochko69@e-mail.ua", "Роксолана", "Лучко", "канд. політ. наук", "(092) 835-01-43", "Програміст", 17207.57m, "calculate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 4, 12, 1, 59, 410, DateTimeKind.Local).AddTicks(6708), "Брюховичів майдан, 348, Дніпродзержинськ, Бутан", new DateTime(2021, 5, 7, 13, 53, 27, 536, DateTimeKind.Local).AddTicks(6335), "CAD", "Shastislav99@gmail.com", new DateTime(2021, 11, 1, 0, 41, 21, 694, DateTimeKind.Local).AddTicks(8653), "Лаврін", "Усич", "докт. техн. наук", "(097) 444-52-73", "Секретар", 2772.25m, "Pennsylvania" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 11, 1, 12, 5, 14, 321, DateTimeKind.Local).AddTicks(2104), "Молодіжна майдан, 6, Західний Тимофій, Лаос", new DateTime(1971, 9, 30, 3, 7, 24, 890, DateTimeKind.Local).AddTicks(1575), "STN", "Alevtina_Palii@gmail.com", new DateTime(2021, 10, 29, 0, 34, 20, 93, DateTimeKind.Local).AddTicks(5113), "Феодосія", "Коломієць", "канд. психол. наук", "(096) 344-66-82", "Секретар", 4427.91m, "Buckinghamshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 5, 27, 6, 42, 32, 893, DateTimeKind.Local).AddTicks(5435), "Брюховичів майдан, 5, Севастополь, Чилі", new DateTime(1948, 3, 10, 22, 3, 42, 606, DateTimeKind.Local).AddTicks(7172), "BRL", "Klavdiya67@i.ua", null, "Божена", "Ромей", "канд. політ. наук", "(073) 169-99-08", "Прибиральник", 14980.82m, "distributed" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 3, 4, 6, 9, 37, 282, DateTimeKind.Local).AddTicks(385), "вул. Зелена, 216, Східний Владислав, Японія", new DateTime(1993, 10, 26, 3, 43, 50, 27, DateTimeKind.Local).AddTicks(3035), "CUP", "Vlada_Cimbalistii92@e-mail.ua", new DateTime(2020, 4, 4, 5, 21, 21, 47, DateTimeKind.Local).AddTicks(7117), "Гнат", "Калач", "(091) 547-68-16", "Прибиральник", 11291.46m, "Fantastic Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 2, 11, 9, 26, 40, 851, DateTimeKind.Local).AddTicks(2480), "вул. Ліста, 190, Східний Звенимир, Панама", new DateTime(1973, 6, 20, 19, 47, 41, 816, DateTimeKind.Local).AddTicks(3372), "GEL", "Antin.Trublayevskii@yandex.ua", null, "Доброслав", "Гайовий", "доц.", "(092) 497-16-06", "Прибиральник", 19392.11m, "Handcrafted Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 12, 9, 23, 46, 106, DateTimeKind.Local).AddTicks(9718), "пл. Вузька, 228, Східний Добромисл, Тонга", new DateTime(1987, 12, 11, 6, 57, 34, 340, DateTimeKind.Local).AddTicks(9078), "DKK", "Vilina_Luckii@meta.ua", "Дана", "Лобачевська", "канд. техн. наук", "(044) 621-91-23", "Прибиральник", 11140.16m, "sky blue" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 30, 11, 13, 41, 443, DateTimeKind.Local).AddTicks(6959), "проспект Рудного, 723, Київ, Казахстан", new DateTime(2000, 7, 27, 21, 47, 20, 792, DateTimeKind.Local).AddTicks(2801), "XBA", "Vilena_Gladukh51@gmail.com", "Віктор", "Лановий", "канд. політ. наук", "(097) 954-40-99", "Прибиральник", 7739.65m, "River" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 10, 45, 448, DateTimeKind.Local).AddTicks(8364), "провулок Староміська, 66, Бровари, Куба", new DateTime(2012, 7, 26, 14, 49, 32, 167, DateTimeKind.Local).AddTicks(5372), "SYP", "Slava_Maiboroda@gmail.com", null, "Алевтин", "Шестак", "(093) 933-21-98", "Бухгалтер", 5960.54m, "panel" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 11, 20, 6, 54, 457, DateTimeKind.Local).AddTicks(731), "Нижанківського майдан, 9, Західний Богдан, Бельгія", new DateTime(1997, 11, 13, 15, 24, 19, 649, DateTimeKind.Local).AddTicks(1503), "IRR", "Slava.Goiko83@e-mail.ua", "Аделіна", "Яловий", "проф.", "(097) 196-91-13", "Програміст", 7949.04m, "best-of-breed" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 7, 11, 10, 47, 20, 403, DateTimeKind.Local).AddTicks(4005), "вулиця Рудного, 298, Південний Віктор, Ангола", new DateTime(1959, 4, 6, 7, 51, 7, 343, DateTimeKind.Local).AddTicks(5343), "MYR", "Panteleimon.Skoropadskii@i.ua", "Зиновій", "Гайовий", "докт. психол. наук", "(091) 663-86-20", "Прибиральник", 14398.15m, "Jewelery" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 31, 5, 47, 53, 17, DateTimeKind.Local).AddTicks(8141), "площа Нижанківського, 8, Ялта, Малі", new DateTime(2014, 12, 3, 1, 50, 38, 598, DateTimeKind.Local).AddTicks(1009), "HTG", "Ruslan26@ukr.net", null, "Клавдія", "Прядун", "докт. пед. наук", "(095) 781-04-97", 7356.88m, "full-range" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 6, 20, 47, 46, 329, DateTimeKind.Local).AddTicks(8029), "провулок Стрийська, 602, Рівне, Панама", new DateTime(1990, 9, 19, 19, 59, 34, 723, DateTimeKind.Local).AddTicks(3481), "HRK", "Oleksii_Yacishin61@i.ua", "Ксенія", "канд. юрид. наук", "(050) 929-89-92", "Секретар", 17103.67m, "Brunei Darussalam" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 15, 10, 54, 6, 536, DateTimeKind.Local).AddTicks(1516), "вулиця Ліста, 435, Сєвєродонецьк, Мальта", new DateTime(1959, 9, 19, 5, 12, 42, 643, DateTimeKind.Local).AddTicks(8541), "NOK", "Shastislav.Pryadun@yandex.ua", new DateTime(2021, 4, 24, 21, 36, 16, 285, DateTimeKind.Local).AddTicks(3408), "Далеслава", "Дмитрук", "канд. філол. наук", "(097) 858-17-08", "Бухгалтер", 19846.52m, "microchip" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 3, 28, 1, 12, 43, 448, DateTimeKind.Local).AddTicks(8051), "Староміська майдан, 7, Івано-Франківськ, Туреччина", new DateTime(1957, 4, 21, 5, 57, 25, 902, DateTimeKind.Local).AddTicks(5732), "PYG", "Listvich93@gmail.com", null, "Стефаній", "Гаман", "доц.", "(073) 423-25-66", "Бухгалтер", 16130.23m, "Street" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 15, 13, 52, 59, 731, DateTimeKind.Local).AddTicks(7255), "Брюховичів майдан, 17, Східний Горимир, Саудівська Аравія", new DateTime(1989, 7, 27, 3, 53, 0, 970, DateTimeKind.Local).AddTicks(1611), "ZWL", "Olelko.Vergun@meta.ua", new DateTime(2019, 5, 7, 11, 56, 28, 304, DateTimeKind.Local).AddTicks(5640), "Жанна", "Бабух", "канд. політ. наук", "(073) 599-08-13", "Бухгалтер", 7363.57m, "Knolls" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 22, 2, 31, 20, 181, DateTimeKind.Local).AddTicks(1432), "Вузька майдан, 8, Південний Дарій, Сан-Марино", new DateTime(1977, 9, 18, 22, 23, 50, 841, DateTimeKind.Local).AddTicks(9547), "MGA", "Valentin37@ukr.net", null, "Ярослава", "Борецька", "докт. філол. наук", "(097) 215-11-12", "Програміст", 14587.48m, "hack" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 19, 15, 24, 9, 101, DateTimeKind.Local).AddTicks(3742), "площа Вузька, 0, Севастополь, Мексика", new DateTime(1950, 6, 10, 12, 38, 16, 77, DateTimeKind.Local).AddTicks(5536), "UGX", "Viktoriya_Plaksii@i.ua", "Горислав", "Башук", "канд. юрид. наук", "(097) 997-60-28", "Програміст", 10894.45m, "Function-based" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 4, 21, 19, 29, 4, 276, DateTimeKind.Local).AddTicks(6504), "Брюховичів майдан, 1, Луцьк, Мозамбік", new DateTime(1945, 9, 7, 3, 36, 43, 876, DateTimeKind.Local).AddTicks(4004), "MZN", "Gavrilo71@ex.ua", "Віола", "Паламарчук", "докт. техн. наук", "(091) 135-44-37", "Бухгалтер", 15755.92m, "Wooden" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 9, 27, 6, 12, 5, 142, DateTimeKind.Local).AddTicks(6293), "Стрийська майдан, 80, Олександрія, Сінгапур", new DateTime(1986, 1, 2, 0, 55, 14, 234, DateTimeKind.Local).AddTicks(833), "CNY", "Tetyana_Grinevecka50@ukr.net", new DateTime(2022, 10, 19, 11, 57, 4, 5, DateTimeKind.Local).AddTicks(4878), "Велемир", "Коцюбинська", "канд. філол. наук", "(044) 125-77-36", "Секретар", 3448.21m, "Plastic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 3, 14, 20, 41, 19, 674, DateTimeKind.Local).AddTicks(6550), "Винників майдан, 17, Південний Маркіян, Малі", new DateTime(1944, 6, 8, 22, 9, 19, 251, DateTimeKind.Local).AddTicks(6340), "JMD", "Gordii27@meta.ua", "В’ячеслава", "Петрина", "докт. і. наук", "(092) 329-95-13", "Секретар", 11646.18m, "Movies & Clothing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 14, 2, 32, 7, 5, DateTimeKind.Local).AddTicks(854), "Стрийська майдан, 7, Одеса, Північна Корея", new DateTime(1957, 8, 26, 14, 5, 0, 232, DateTimeKind.Local).AddTicks(669), "USD", "Tetyana.Yemec@yandex.ua", new DateTime(2022, 8, 19, 22, 30, 21, 968, DateTimeKind.Local).AddTicks(4028), "Соня", "Брицький", "докт. техн. наук", "(097) 430-95-06", "Секретар", 3580.97m, "Ergonomic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 3, 4, 23, 20, 28, 120, DateTimeKind.Local).AddTicks(5095), "Вузька майдан, 3, Краматорськ, Бразилія", new DateTime(1953, 11, 24, 17, 9, 12, 130, DateTimeKind.Local).AddTicks(502), "TJS", "Mstislava33@i.ua", "Георгій", "Компанієць", "доц.", "(066) 773-21-06", 9973.01m, "Wyoming" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 27, 1, 18, 15, 699, DateTimeKind.Local).AddTicks(7777), "площа Рудного, 2, Сєвєродонецьк, Болівія", new DateTime(2017, 5, 29, 15, 51, 34, 641, DateTimeKind.Local).AddTicks(5636), "NOK", "Vitalii37@gmail.com", "Владислава", "Семеночко", "докт. техн. наук", "(050) 345-58-18", "Прибиральник", 5498.39m, "Toys" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 11, 21, 5, 22, 58, 155, DateTimeKind.Local).AddTicks(7962), "Нижанківського майдан, 088, Східний Руслан, Туреччина", new DateTime(1949, 3, 13, 8, 39, 2, 211, DateTimeKind.Local).AddTicks(1571), "TTD", "Lyubozar_Serdyuk63@yandex.ua", "Доляна", "Лютий", "докт. філол. наук", "(050) 295-33-75", "Програміст", 8576.57m, "real-time" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 9, 10, 11, 35, 40, 691, DateTimeKind.Local).AddTicks(2821), "Городоцька майдан, 857, Луганськ, Іспанія", new DateTime(1944, 8, 3, 18, 42, 38, 309, DateTimeKind.Local).AddTicks(1438), "HUF", "Pavlo.Pavlishin@ukr.net", new DateTime(2023, 1, 26, 6, 12, 38, 778, DateTimeKind.Local).AddTicks(7636), "Мирослав", "Ногачевська", "канд. пед. наук", "(073) 602-41-21", 15447.19m, "back-end" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 20, 14, 10, 7, 686, DateTimeKind.Local).AddTicks(1709), "пр. Рудного, 588, Черкаси, Фіджі", new DateTime(1963, 6, 11, 4, 1, 50, 853, DateTimeKind.Local).AddTicks(2708), "PAB", "Yaropolk_Gladukh@ukr.net", new DateTime(2022, 8, 19, 20, 5, 13, 998, DateTimeKind.Local).AddTicks(2417), "Юліан", "Сідлецька", "канд. пед. наук", "(095) 029-71-83", "Секретар", 18092.69m, "generate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 16, 20, 47, 46, 903, DateTimeKind.Local).AddTicks(5256), "Вічева майдан, 910, Макіївка, Ізраїль", new DateTime(2020, 12, 21, 18, 30, 58, 934, DateTimeKind.Local).AddTicks(9811), "PEN", "Bogdan.Zlenko30@i.ua", new DateTime(2023, 3, 31, 0, 8, 38, 692, DateTimeKind.Local).AddTicks(3715), "Лаврін", "Зварич", "канд. психол. наук", "(044) 003-73-85", 11998.62m, "connect" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 24, 8, 42, 50, 362, DateTimeKind.Local).AddTicks(8154), "вулиця Вічева, 074, Східний Геннадій, Лівія", new DateTime(1963, 1, 10, 14, 43, 5, 541, DateTimeKind.Local).AddTicks(6758), "CUP", "Svitlana_Lyutii@e-mail.ua", new DateTime(2021, 12, 18, 10, 21, 28, 965, DateTimeKind.Local).AddTicks(3565), "Звенислав", "Гамула", "докт. філол. наук", "(092) 238-24-41", 10906.32m, "withdrawal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 2, 5, 54, 43, 996, DateTimeKind.Local).AddTicks(6417), "пров. Вузька, 7, Південний Руслан, Багамські Острови", new DateTime(2003, 8, 21, 13, 16, 2, 328, DateTimeKind.Local).AddTicks(3276), "BHD", "Mstislava_Ponomariv@ex.ua", null, "Мотря", "Бабух", "докт. юрид. наук", "(044) 521-11-22", "Прибиральник", 10973.11m, "SQL" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 4, 14, 14, 56, 29, 181, DateTimeKind.Local).AddTicks(3083), "вулиця Брюховичів, 556, Південний Олексій, США", new DateTime(1990, 9, 30, 12, 25, 8, 380, DateTimeKind.Local).AddTicks(2396), "TZS", "Yukhim_Svidrigailo66@i.ua", new DateTime(2022, 3, 22, 5, 50, 18, 722, DateTimeKind.Local).AddTicks(2488), "Славута", "Пагутяк", "докт. психол. наук", "(096) 278-26-04", "Програміст", 17474.30m, "bluetooth" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 1, 11, 31, 8, 469, DateTimeKind.Local).AddTicks(399), "площа Нижанківського, 15, Луганськ, Демократична Республіка Конго", new DateTime(1982, 5, 15, 17, 13, 0, 666, DateTimeKind.Local).AddTicks(1674), "TND", "Bogdan59@ukr.net", "Каріна", "Григоришина", "доц.", "(095) 455-76-62", "Бухгалтер", 14793.67m, "Facilitator" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 5, 27, 10, 15, 34, 529, DateTimeKind.Local).AddTicks(5939), "пров. Городоцька, 64, Східний Дарій, Сербія", new DateTime(2015, 8, 3, 15, 26, 28, 349, DateTimeKind.Local).AddTicks(411), "BHD", "Bogdana_Latanii@yandex.ua", null, "Юхима", "Боярчук", "докт. юрид. наук", "(099) 061-48-24", "Прибиральник", 9845.34m, "National" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 4, 17, 12, 29, 48, 480, DateTimeKind.Local).AddTicks(3998), "проспект Стрийська, 1, Західний Божен, Намібія", new DateTime(2012, 2, 4, 17, 39, 31, 476, DateTimeKind.Local).AddTicks(6926), "BBD", "Natan90@ex.ua", new DateTime(2023, 9, 18, 22, 17, 7, 589, DateTimeKind.Local).AddTicks(4029), "Любозар", "Кивач", "канд. філос. наук", "(073) 346-11-28", "Прибиральник", 17296.81m, "projection" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 5, 13, 9, 3, 14, 446, DateTimeKind.Local).AddTicks(699), "Стрийська майдан, 083, Бровари, Грузія", new DateTime(2015, 8, 8, 15, 29, 47, 947, DateTimeKind.Local).AddTicks(5388), "MZN", "Solomiya_Tarasyuk@ukr.net", new DateTime(2023, 10, 19, 11, 40, 20, 373, DateTimeKind.Local).AddTicks(371), "Феодосія", "Лящук", "докт. психол. наук", "(073) 997-11-32", "Секретар", 19770.31m, "Assistant" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 12, 14, 1, 16, 35, 131, DateTimeKind.Local).AddTicks(2956), "Староміська майдан, 7, Ялта, Катар", new DateTime(2020, 10, 18, 23, 10, 52, 23, DateTimeKind.Local).AddTicks(410), "CRC", "Illya.Balakun37@gmail.com", "Аскольд", "Дурдинець", "канд. пед. наук", "(094) 886-68-33", "Прибиральник", 12358.13m, "Small Plastic Car" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 29, 23, 54, 34, 493, DateTimeKind.Local).AddTicks(499), "пр. Ліста, 7, Північний Подолян, Узбекистан", new DateTime(1973, 8, 29, 0, 32, 40, 822, DateTimeKind.Local).AddTicks(4001), "RWF", "Kornilii.Zlenko53@i.ua", new DateTime(2021, 3, 15, 3, 13, 25, 106, DateTimeKind.Local).AddTicks(7288), "Макар", "Паращук", "канд. філос. наук", "(094) 475-70-07", "Секретар", 10076.57m, "Organized" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 13, 8, 1, 9, 626, DateTimeKind.Local).AddTicks(3660), "Рудного майдан, 7, Східний Роман, Пакистан", new DateTime(2019, 5, 22, 21, 13, 59, 193, DateTimeKind.Local).AddTicks(3551), "MZN", "Daleslava81@meta.ua", null, "Сергій", "Боярчук", "докт. політ. наук", "(066) 686-80-91", 12613.06m, "Generic Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 9, 22, 9, 36, 10, 867, DateTimeKind.Local).AddTicks(1586), "Вічева майдан, 191, Західний Сологуб, Фіджі", new DateTime(2000, 12, 8, 0, 35, 24, 237, DateTimeKind.Local).AddTicks(4610), "ILS", "Slavomir.Zabila93@gmail.com", null, "Ладислав", "Майстренко", "докт. юрид. наук", "(096) 582-97-55", "Директор", 10998.49m, "solutions" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 5, 14, 14, 22, 326, DateTimeKind.Local).AddTicks(1708), "Городоцька майдан, 7, Західний Братомил, Ісландія", new DateTime(1989, 12, 4, 14, 25, 41, 699, DateTimeKind.Local).AddTicks(6688), "BZD", "Timofii94@i.ua", null, "Аделіна", "Лугова", "канд. юрид. наук", "(092) 539-01-72", "Прибиральник", 16426.64m, "Manager" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 4, 2, 14, 0, 11, 337, DateTimeKind.Local).AddTicks(6844), "пл. Стрийська, 9, Східний Степан, Швейцарія", new DateTime(1975, 3, 7, 2, 15, 7, 32, DateTimeKind.Local).AddTicks(8368), "BZD", "Vlada.Sileckii26@ukr.net", new DateTime(2022, 11, 13, 0, 48, 52, 180, DateTimeKind.Local).AddTicks(51), "Гнат", "Ромей", "канд. психол. наук", "(096) 688-07-83", 6809.06m, "THX" });
        }
    }
}

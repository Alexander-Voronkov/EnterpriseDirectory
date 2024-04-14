using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Patronymic = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Salary = table.Column<decimal>(type: "TEXT", nullable: false),
                    Currency = table.Column<string>(type: "TEXT", nullable: true),
                    Position = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AcceptedOn = table.Column<DateTime>(type: "TEXT", nullable: true),
                    FiredOn = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "Datetime('now')"),
                    LastUpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.Sql(
                """
                    CREATE TRIGGER IF NOT EXISTS LastUpdatedOnFiredOnTrigger
                    BEFORE UPDATE ON Employees
                    FOR EACH ROW
                    BEGIN
                        UPDATE Employees
                        SET LastUpdatedOn = Datetime('now')
                        WHERE Id = NEW.Id;
                    END;
                """);

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AcceptedOn", "Address", "BirthDate", "Currency", "Email", "FiredOn", "FirstName", "LastName", "LastUpdatedOn", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 11, 17, 18, 41, 240, DateTimeKind.Local).AddTicks(5674), "Винників майдан, 4, Південний Олег, Пакистан", new DateTime(2019, 5, 26, 15, 21, 13, 30, DateTimeKind.Local).AddTicks(2207), "SRD", "Avrelii31@gmail.com", new DateTime(2020, 9, 25, 7, 26, 30, 790, DateTimeKind.Local).AddTicks(9018), "Олесь", "Горбач", null, "канд. і. наук", "(063) 242-00-09", "Директор", 8640.73m, "microchip" },
                    { 2, new DateTime(2020, 6, 28, 0, 43, 44, 704, DateTimeKind.Local).AddTicks(5646), "Зелена майдан, 2, Миколаїв, Домініка", new DateTime(2002, 7, 23, 4, 55, 8, 539, DateTimeKind.Local).AddTicks(5814), "DKK", "Feodosiya_Shudrik@ukr.net", new DateTime(2022, 7, 26, 23, 31, 39, 535, DateTimeKind.Local).AddTicks(6517), "Купава", "Шиян", null, "проф.", "(098) 467-77-24", "Секретар", 1109.41m, "out-of-the-box" },
                    { 3, new DateTime(2020, 12, 18, 13, 33, 58, 760, DateTimeKind.Local).AddTicks(3459), "Ліста майдан, 633, Східний Тихон, Туніс", new DateTime(2001, 11, 7, 7, 38, 10, 269, DateTimeKind.Local).AddTicks(1720), "PLN", "Nadiya.Shevchenko39@e-mail.ua", null, "Дарина", "Кульчицький", null, "докт. філос. наук", "(066) 724-88-61", "Секретар", 1491.25m, "quantify" },
                    { 4, new DateTime(2021, 7, 29, 13, 41, 12, 576, DateTimeKind.Local).AddTicks(8191), "Зелена майдан, 87, Північний Потап, Ангола", new DateTime(2003, 11, 27, 19, 46, 23, 339, DateTimeKind.Local).AddTicks(333), "LYD", "Avrelii.Yevpak@gmail.com", null, "Мстислав", "Луцький", null, "доц.", "(096) 048-05-74", "Прибиральник", 1687.93m, "deposit" },
                    { 5, new DateTime(2023, 10, 31, 11, 6, 30, 70, DateTimeKind.Local).AddTicks(5180), "пл. Ліста, 408, Західний Віталій, Малайзія", new DateTime(1987, 12, 25, 20, 52, 36, 821, DateTimeKind.Local).AddTicks(8267), "MOP", "Gorislav_Koman@ukr.net", new DateTime(2019, 12, 14, 8, 39, 2, 524, DateTimeKind.Local).AddTicks(5854), "Назар", "Петлюра", null, "канд. і. наук", "(094) 135-82-41", "Бухгалтер", 17329.83m, "feed" },
                    { 6, new DateTime(2020, 12, 7, 10, 48, 48, 914, DateTimeKind.Local).AddTicks(449), "Староміська майдан, 276, Західний Лаврентій, Гренада", new DateTime(1991, 10, 1, 17, 11, 6, 530, DateTimeKind.Local).AddTicks(9090), "NOK", "Timish93@meta.ua", new DateTime(2023, 12, 16, 12, 48, 26, 488, DateTimeKind.Local).AddTicks(1900), "Ярополк", "Ющук", null, "докт. філос. наук", "(044) 484-38-11", "Секретар", 10031.49m, "bluetooth" },
                    { 7, new DateTime(2022, 2, 19, 15, 22, 22, 353, DateTimeKind.Local).AddTicks(2776), "провулок Вузька, 2, Північний Щастислав, Кіпр", new DateTime(1950, 10, 30, 20, 13, 46, 670, DateTimeKind.Local).AddTicks(4183), "TZS", "Zoya_Shukhevich29@meta.ua", new DateTime(2022, 10, 16, 13, 7, 11, 299, DateTimeKind.Local).AddTicks(1471), "Каріна", "Гришко", null, "докт. юрид. наук", "(099) 637-95-71", "Прибиральник", 14488.93m, "Borders" },
                    { 8, new DateTime(2021, 7, 14, 22, 59, 45, 550, DateTimeKind.Local).AddTicks(2129), "Коліївщини майдан, 82, Південний Ярослав, Сенеґал", new DateTime(1981, 4, 9, 2, 33, 9, 625, DateTimeKind.Local).AddTicks(5544), "XPD", "Stanislava_Storchak36@e-mail.ua", new DateTime(2019, 8, 20, 13, 21, 51, 249, DateTimeKind.Local).AddTicks(7001), "Братимир", "Трясун", null, "канд. техн. наук", "(063) 756-12-21", "Бухгалтер", 18182.43m, "compressing" },
                    { 9, new DateTime(2022, 5, 18, 22, 54, 7, 734, DateTimeKind.Local).AddTicks(5995), "Староміська майдан, 40, Дніпропетровськ, Тувалу", new DateTime(1959, 10, 2, 1, 14, 33, 635, DateTimeKind.Local).AddTicks(6633), "ZAR", "Alla_Garai@i.ua", null, "Архип", "Латан", null, "доц.", "(063) 600-95-43", "Бухгалтер", 18068.84m, "monetize" },
                    { 10, new DateTime(2022, 10, 24, 1, 59, 19, 240, DateTimeKind.Local).AddTicks(8953), "Нижанківського майдан, 12, Південний Орест, Пакистан", new DateTime(1981, 9, 21, 7, 37, 32, 496, DateTimeKind.Local).AddTicks(603), "MAD", "Olga71@ex.ua", new DateTime(2022, 3, 8, 11, 55, 5, 264, DateTimeKind.Local).AddTicks(7413), "Яровид", "Дурдинець", null, "докт. філол. наук", "(066) 130-60-67", "Секретар", 12633.12m, "engineer" },
                    { 11, new DateTime(2023, 1, 25, 11, 28, 5, 353, DateTimeKind.Local).AddTicks(2253), "вулиця Ліста, 406, Західний Максим, Таїланд", new DateTime(1984, 4, 30, 20, 39, 18, 489, DateTimeKind.Local).AddTicks(1141), "TRY", "Bozhen9@ukr.net", null, "Зоя", "Коров’як", null, "проф.", "(073) 761-14-85", "Програміст", 12646.04m, "Bahamian Dollar" },
                    { 12, new DateTime(2024, 1, 28, 12, 33, 44, 651, DateTimeKind.Local).AddTicks(1118), "пров. Нижанківського, 58, Тернопіль, Філіппіни", new DateTime(1958, 2, 3, 10, 30, 19, 274, DateTimeKind.Local).AddTicks(9644), "THB", "Oleksandra.Ponomariv@e-mail.ua", new DateTime(2021, 1, 1, 23, 1, 38, 546, DateTimeKind.Local).AddTicks(1488), "Альвіна", "Мотрієнко", null, "докт. пед. наук", "(066) 654-30-31", "Директор", 2035.41m, "Path" },
                    { 13, new DateTime(2021, 8, 7, 17, 30, 42, 572, DateTimeKind.Local).AddTicks(4994), "провулок Молодіжна, 373, Південний Дарій, Сьєрра-Леоне", new DateTime(1976, 9, 12, 21, 46, 17, 232, DateTimeKind.Local).AddTicks(3392), "ZMK", "Feodosiya_Luckii@ex.ua", new DateTime(2019, 9, 11, 18, 29, 34, 280, DateTimeKind.Local).AddTicks(2334), "Аделіна", "Юхно", null, "канд. і. наук", "(099) 370-74-31", "Програміст", 5037.51m, "channels" },
                    { 14, new DateTime(2023, 8, 31, 7, 34, 41, 414, DateTimeKind.Local).AddTicks(4020), "пр. Коліївщини, 195, Львів, Боснія і Герцеговина", new DateTime(1965, 11, 4, 20, 16, 57, 307, DateTimeKind.Local).AddTicks(1997), "IRR", "Diyana98@i.ua", new DateTime(2021, 7, 25, 19, 11, 14, 259, DateTimeKind.Local).AddTicks(4324), "Микола", "Майборода", null, "канд. психол. наук", "(098) 898-00-61", "Секретар", 3849.04m, "Incredible Metal Mouse" },
                    { 15, new DateTime(2023, 6, 27, 7, 44, 11, 750, DateTimeKind.Local).AddTicks(6354), "Зелена майдан, 051, Єнакієве, Південно-Африканська Республіка", new DateTime(1953, 5, 12, 17, 22, 48, 290, DateTimeKind.Local).AddTicks(4440), "LSL", "Dobromir_Pavlishin@i.ua", null, "Анфіса", "Юхно", null, "канд. психол. наук", "(093) 975-58-51", "Директор", 4671.67m, "Handcrafted Fresh Pants" },
                    { 16, new DateTime(2021, 10, 17, 4, 33, 7, 727, DateTimeKind.Local).AddTicks(3067), "вул. Брюховичів, 5, Ізмаїл, США", new DateTime(2015, 5, 10, 16, 33, 34, 655, DateTimeKind.Local).AddTicks(3503), "BMD", "Antonida_Petriv21@i.ua", null, "Даромир", "Балабан", null, "докт. психол. наук", "(050) 571-40-21", "Директор", 16983.50m, "Tasty Wooden Shoes" },
                    { 17, new DateTime(2021, 7, 11, 11, 37, 12, 808, DateTimeKind.Local).AddTicks(3957), "Брюховичів майдан, 1, Алчевськ, Конго", new DateTime(2018, 4, 12, 3, 49, 44, 782, DateTimeKind.Local).AddTicks(5451), "XBB", "Anatoliya83@yandex.ua", new DateTime(2021, 11, 30, 7, 40, 21, 406, DateTimeKind.Local).AddTicks(5692), "Світлана", "Петик", null, "проф.", "(097) 454-23-34", "Програміст", 2067.15m, "Sleek Cotton Towels" },
                    { 18, new DateTime(2022, 9, 5, 21, 43, 14, 237, DateTimeKind.Local).AddTicks(4999), "провулок Молодіжна, 79, Північний Синьоок, Папуа-Нова Гвінея", new DateTime(1976, 12, 16, 1, 19, 12, 217, DateTimeKind.Local).AddTicks(1358), "TWD", "Yevgen.Yanyuk27@meta.ua", new DateTime(2021, 7, 29, 0, 26, 14, 580, DateTimeKind.Local).AddTicks(1716), "Панас", "Романишина", null, "канд. юрид. наук", "(073) 004-03-16", "Прибиральник", 10677.41m, "bluetooth" },
                    { 19, new DateTime(2021, 2, 18, 0, 19, 50, 981, DateTimeKind.Local).AddTicks(9381), "пл. Рудного, 8, Біла Церква, Бахрейн", new DateTime(1988, 8, 28, 2, 41, 8, 896, DateTimeKind.Local).AddTicks(8230), "ANG", "Yaroslav.Gromiko90@ukr.net", null, "Каріна", "Гладківська", null, "доц.", "(073) 210-12-23", "Прибиральник", 17852.70m, "productize" },
                    { 20, new DateTime(2023, 5, 5, 12, 16, 22, 671, DateTimeKind.Local).AddTicks(6242), "пров. Коліївщини, 146, Південний Славолюб, Мозамбік", new DateTime(2002, 3, 15, 12, 33, 55, 583, DateTimeKind.Local).AddTicks(8736), "KES", "Snizhan_Vereshuk62@yandex.ua", new DateTime(2020, 11, 27, 5, 36, 23, 368, DateTimeKind.Local).AddTicks(7776), "Соломія", "Яцишина", null, "канд. філос. наук", "(092) 909-71-48", "Програміст", 17351.31m, "Configuration" },
                    { 21, new DateTime(2019, 6, 3, 7, 31, 3, 442, DateTimeKind.Local).AddTicks(3742), "проспект Коліївщини, 8, Південний Пантелеймон, Іспанія", new DateTime(2012, 11, 27, 0, 10, 30, 626, DateTimeKind.Local).AddTicks(8091), "KRW", "Agapiya56@i.ua", new DateTime(2022, 7, 25, 8, 22, 23, 358, DateTimeKind.Local).AddTicks(3115), "Зореслава", "Унич", null, "докт. пед. наук", "(099) 798-84-02", "Директор", 8573.13m, "synthesizing" },
                    { 22, new DateTime(2022, 4, 11, 0, 14, 25, 780, DateTimeKind.Local).AddTicks(2058), "Зелена майдан, 75, Східний Омелян, Домініканська Республіка", new DateTime(1999, 8, 2, 22, 50, 1, 767, DateTimeKind.Local).AddTicks(3039), "SBD", "Bozhena_Malkovich73@e-mail.ua", null, "Ганна", "Лазірко", null, "канд. філол. наук", "(093) 585-94-34", "Прибиральник", 14655.08m, "Locks" },
                    { 23, new DateTime(2023, 1, 20, 16, 5, 49, 320, DateTimeKind.Local).AddTicks(1449), "Городоцька майдан, 82, Західний Андрій, Конго", new DateTime(1952, 6, 17, 12, 2, 41, 284, DateTimeKind.Local).AddTicks(7040), "BTN", "Anatolii88@e-mail.ua", new DateTime(2023, 8, 22, 23, 51, 58, 37, DateTimeKind.Local).AddTicks(5853), "Валерія", "Юхно", null, "докт. політ. наук", "(093) 002-40-70", "Прибиральник", 6781.42m, "Frozen" },
                    { 24, new DateTime(2021, 9, 20, 20, 12, 23, 758, DateTimeKind.Local).AddTicks(2632), "вулиця Вічева, 09, Черкаси, Туреччина", new DateTime(1958, 7, 1, 8, 38, 46, 255, DateTimeKind.Local).AddTicks(2205), "KHR", "Kii_Gorodocka97@i.ua", new DateTime(2019, 9, 12, 23, 34, 10, 877, DateTimeKind.Local).AddTicks(7558), "Яромил", "Бондаренко", null, "докт. філос. наук", "(096) 596-50-32", "Директор", 5435.45m, "middleware" },
                    { 25, new DateTime(2021, 1, 8, 8, 47, 30, 423, DateTimeKind.Local).AddTicks(8057), "пр. Стрийська, 7, Південний Омелян, Нова Зеландія", new DateTime(1961, 3, 18, 3, 37, 58, 610, DateTimeKind.Local).AddTicks(9249), "NZD", "Snizhana31@meta.ua", new DateTime(2020, 6, 15, 19, 28, 3, 572, DateTimeKind.Local).AddTicks(6338), "Юхимія", "Забіла", null, "канд. політ. наук", "(092) 828-12-37", "Прибиральник", 13739.13m, "Islands" },
                    { 26, new DateTime(2021, 10, 1, 3, 45, 26, 178, DateTimeKind.Local).AddTicks(6068), "Зелена майдан, 0, Черкаси, Латвія", new DateTime(1995, 1, 5, 14, 14, 29, 400, DateTimeKind.Local).AddTicks(2890), "GBP", "Nazar.Petrin@gmail.com", new DateTime(2022, 11, 30, 3, 18, 39, 896, DateTimeKind.Local).AddTicks(1567), "Злата", "Левадовський", null, "канд. філос. наук", "(050) 497-71-84", "Директор", 4636.99m, "Wooden" },
                    { 27, new DateTime(2019, 8, 29, 19, 33, 43, 527, DateTimeKind.Local).AddTicks(5321), "вулиця Вічева, 083, Луцьк, Бахрейн", new DateTime(1999, 4, 15, 14, 38, 8, 852, DateTimeKind.Local).AddTicks(4530), "ISK", "Sologub.Maistrenko@e-mail.ua", null, "Всевлад", "Осадко", null, "докт. філол. наук", "(092) 611-38-07", "Прибиральник", 13331.01m, "Credit Card Account" },
                    { 28, new DateTime(2022, 2, 3, 23, 54, 49, 845, DateTimeKind.Local).AddTicks(2194), "Ліста майдан, 8, Рівне, Гватемала", new DateTime(1971, 9, 30, 7, 10, 42, 463, DateTimeKind.Local).AddTicks(9004), "CZK", "Pavlina18@e-mail.ua", new DateTime(2023, 10, 16, 11, 17, 59, 901, DateTimeKind.Local).AddTicks(5075), "Антоніна", "Петренко", null, "канд. техн. наук", "(044) 954-35-27", "Бухгалтер", 19323.86m, "Rubber" },
                    { 29, new DateTime(2020, 2, 1, 0, 34, 2, 722, DateTimeKind.Local).AddTicks(2654), "Молодіжна майдан, 9, Північний Олелько, Малаві", new DateTime(2020, 4, 13, 21, 36, 54, 314, DateTimeKind.Local).AddTicks(2180), "KYD", "Danilo32@e-mail.ua", null, "Святослава", "Гришко", null, "проф.", "(093) 309-33-49", "Програміст", 7471.22m, "Officer" },
                    { 30, new DateTime(2022, 8, 4, 3, 24, 58, 776, DateTimeKind.Local).AddTicks(6126), "Нижанківського майдан, 59, Єнакієве, Перу", new DateTime(1972, 5, 17, 7, 45, 53, 546, DateTimeKind.Local).AddTicks(6011), "GBP", "Kornii.Porivailo49@ex.ua", null, "Яна", "Латаний", null, "докт. пед. наук", "(073) 196-11-15", "Секретар", 14989.07m, "Centers" },
                    { 31, new DateTime(2019, 9, 14, 20, 41, 1, 780, DateTimeKind.Local).AddTicks(6210), "Рудного майдан, 857, Одеса, Папуа-Нова Гвінея", new DateTime(1991, 8, 26, 11, 58, 43, 589, DateTimeKind.Local).AddTicks(4108), "LTL", "Anastas_Demchishina95@gmail.com", new DateTime(2020, 1, 17, 1, 49, 20, 30, DateTimeKind.Local).AddTicks(1930), "Мирослава", "Ялюк", null, "доц.", "(094) 065-82-03", "Бухгалтер", 4669.78m, "directional" },
                    { 32, new DateTime(2021, 2, 19, 12, 56, 12, 697, DateTimeKind.Local).AddTicks(9521), "пл. Рудного, 7, Вінниця, Гамбія", new DateTime(2020, 5, 12, 16, 39, 36, 591, DateTimeKind.Local).AddTicks(7363), "ARS", "Krentta.Tarasyuk84@e-mail.ua", null, "Захар", "Дзюба", null, "докт. юрид. наук", "(044) 314-79-09", "Програміст", 3752.81m, "Pennsylvania" },
                    { 33, new DateTime(2021, 8, 16, 3, 44, 11, 535, DateTimeKind.Local).AddTicks(2488), "Староміська майдан, 690, Черкаси, Мальдіви", new DateTime(1961, 9, 26, 19, 12, 14, 172, DateTimeKind.Local).AddTicks(1390), "AWG", "Borimir.Vitrebenko@ukr.net", new DateTime(2019, 11, 10, 6, 17, 12, 985, DateTimeKind.Local).AddTicks(5305), "Діяна", "Юрчишин", null, "докт. юрид. наук", "(063) 021-41-21", "Директор", 15990.31m, "Human" },
                    { 34, new DateTime(2022, 10, 13, 14, 48, 0, 453, DateTimeKind.Local).AddTicks(3903), "Нижанківського майдан, 1, Північний Борис, Азербайджан", new DateTime(1959, 6, 20, 11, 20, 1, 478, DateTimeKind.Local).AddTicks(7417), "LVL", "Nadiya.Lugova@i.ua", null, "Ігор", "Сідлецька", null, "докт. філос. наук", "(092) 324-41-59", "Прибиральник", 19669.21m, "Idaho" },
                    { 35, new DateTime(2019, 11, 24, 20, 16, 28, 998, DateTimeKind.Local).AddTicks(3874), "Рудного майдан, 93, Східний Олесь, Італія", new DateTime(1971, 8, 4, 5, 10, 13, 658, DateTimeKind.Local).AddTicks(8206), "BIF", "Vsevolod89@ex.ua", new DateTime(2022, 1, 6, 22, 19, 45, 945, DateTimeKind.Local).AddTicks(8648), "Богдана", "Паламарчук", null, "канд. техн. наук", "(066) 474-54-29", "Прибиральник", 2893.70m, "COM" },
                    { 36, new DateTime(2022, 1, 31, 10, 59, 49, 791, DateTimeKind.Local).AddTicks(4190), "пл. Ліста, 2, Західний В’ячеслав, Вануату", new DateTime(1977, 4, 19, 7, 38, 30, 83, DateTimeKind.Local).AddTicks(5828), "BBD", "Shek94@meta.ua", null, "Добромисл", "Цушко", null, "доц.", "(044) 425-38-39", "Бухгалтер", 6313.34m, "success" },
                    { 37, new DateTime(2021, 12, 2, 13, 57, 50, 64, DateTimeKind.Local).AddTicks(1372), "Вузька майдан, 06, Чернігів, Вірменія", new DateTime(1984, 7, 3, 12, 45, 1, 26, DateTimeKind.Local).AddTicks(7744), "JOD", "Zakharii.Yemec@yandex.ua", new DateTime(2019, 11, 3, 12, 7, 39, 803, DateTimeKind.Local).AddTicks(5606), "Звенимир", "Мамій", null, "канд. психол. наук", "(050) 076-86-94", "Секретар", 6408.64m, "Massachusetts" },
                    { 38, new DateTime(2019, 10, 15, 16, 41, 42, 190, DateTimeKind.Local).AddTicks(6882), "вул. Нижанківського, 4, Львів, Чилі", new DateTime(2016, 5, 18, 8, 42, 41, 439, DateTimeKind.Local).AddTicks(7276), "GEL", "Maiya_Kalach18@ukr.net", new DateTime(2022, 5, 10, 8, 8, 49, 160, DateTimeKind.Local).AddTicks(2132), "Назар", "Лазірко", null, "канд. філол. наук", "(097) 150-60-28", "Програміст", 11957.49m, "Persevering" },
                    { 39, new DateTime(2021, 1, 2, 20, 37, 31, 274, DateTimeKind.Local).AddTicks(6103), "Зелена майдан, 7, Бердичів, Чад", new DateTime(1960, 9, 19, 16, 13, 48, 5, DateTimeKind.Local).AddTicks(3037), "BND", "Bilomir_Gorodockii53@ex.ua", null, "Олексій", "Уманець", null, "доц.", "(095) 368-32-71", "Секретар", 12429.48m, "Mobility" },
                    { 40, new DateTime(2024, 3, 7, 7, 35, 12, 271, DateTimeKind.Local).AddTicks(6660), "Городоцька майдан, 338, Західний Анатолій, Нідерланди", new DateTime(1980, 5, 28, 11, 28, 59, 846, DateTimeKind.Local).AddTicks(6370), "MVR", "Pavlo20@ukr.net", new DateTime(2021, 1, 1, 14, 4, 21, 457, DateTimeKind.Local).AddTicks(3946), "Мотря", "Шупик", null, "докт. пед. наук", "(095) 118-84-45", "Програміст", 12410.57m, "feed" },
                    { 41, new DateTime(2019, 7, 15, 8, 39, 53, 407, DateTimeKind.Local).AddTicks(4655), "площа Рудного, 3, Північний Ярема, Ангола", new DateTime(1968, 2, 19, 1, 40, 47, 898, DateTimeKind.Local).AddTicks(7352), "MYR", "Alvina_Umanec60@yandex.ua", new DateTime(2022, 5, 25, 10, 19, 55, 984, DateTimeKind.Local).AddTicks(1194), "Костянтин", "Петренко", null, "докт. юрид. наук", "(073) 826-21-82", "Директор", 15159.47m, "Tasty Fresh Fish" },
                    { 42, new DateTime(2024, 4, 12, 11, 29, 28, 100, DateTimeKind.Local).AddTicks(1331), "вулиця Брюховичів, 79, Конотоп, Судан", new DateTime(1950, 1, 26, 5, 16, 32, 183, DateTimeKind.Local).AddTicks(1922), "AMD", "Rodoslav25@ukr.net", new DateTime(2022, 7, 10, 2, 31, 17, 409, DateTimeKind.Local).AddTicks(2863), "Віталій", "Бердник", null, "канд. юрид. наук", "(098) 951-60-64", "Секретар", 2282.52m, "national" },
                    { 43, new DateTime(2024, 4, 12, 6, 1, 42, 679, DateTimeKind.Local).AddTicks(1014), "Староміська майдан, 4, Лисичанськ, Центральноафриканська Республіка", new DateTime(1966, 8, 31, 22, 3, 27, 206, DateTimeKind.Local).AddTicks(2729), "BMD", "Mikhailo68@ex.ua", null, "Олександра", "Громико", null, "докт. політ. наук", "(063) 754-55-34", "Прибиральник", 4736.30m, "Fords" },
                    { 44, new DateTime(2023, 5, 5, 15, 14, 56, 818, DateTimeKind.Local).AddTicks(4516), "Ліста майдан, 6, Полтава, Болгарія", new DateTime(2004, 11, 9, 22, 17, 32, 475, DateTimeKind.Local).AddTicks(8101), "CLP", "Mikola35@ex.ua", null, "Валерій", "Негода", null, "канд. юрид. наук", "(094) 315-47-02", "Бухгалтер", 1781.86m, "action-items" },
                    { 45, new DateTime(2024, 3, 27, 13, 58, 8, 402, DateTimeKind.Local).AddTicks(8875), "пр. Коліївщини, 02, Львів, США", new DateTime(1996, 9, 22, 23, 35, 13, 959, DateTimeKind.Local).AddTicks(4560), "AWG", "Smiyana6@yandex.ua", null, "Святослава", "Миклухо", null, "докт. техн. наук", "(091) 422-88-36", "Бухгалтер", 13541.92m, "Glen" },
                    { 46, new DateTime(2019, 5, 15, 20, 5, 47, 758, DateTimeKind.Local).AddTicks(1806), "вулиця Винників, 86, Кременчук, Іран", new DateTime(1961, 1, 7, 22, 35, 22, 645, DateTimeKind.Local).AddTicks(7398), "SBD", "Anna17@gmail.com", null, "Костянтин", "Боровська", null, "докт. пед. наук", "(094) 040-44-36", "Секретар", 4761.94m, "Summit" },
                    { 47, new DateTime(2022, 12, 21, 23, 32, 20, 28, DateTimeKind.Local).AddTicks(5357), "Ліста майдан, 120, Івано-Франківськ, Польща", new DateTime(2009, 9, 1, 13, 53, 37, 371, DateTimeKind.Local).AddTicks(8162), "NIO", "Listvich87@e-mail.ua", null, "Тихон", "Гнатишин", null, "докт. техн. наук", "(093) 040-11-78", "Бухгалтер", 15302.68m, "Group" },
                    { 48, new DateTime(2022, 7, 18, 22, 58, 59, 583, DateTimeKind.Local).AddTicks(7661), "вул. Коліївщини, 65, Північний Пилип, Бельгія", new DateTime(1961, 9, 15, 7, 28, 9, 188, DateTimeKind.Local).AddTicks(454), "CRC", "Zoreslav.Vitrebenko@e-mail.ua", new DateTime(2021, 12, 22, 3, 46, 24, 551, DateTimeKind.Local).AddTicks(8564), "Дарій", "Барановська", null, "докт. філол. наук", "(063) 372-67-02", "Секретар", 18470.50m, "Specialist" },
                    { 49, new DateTime(2024, 2, 17, 15, 45, 5, 264, DateTimeKind.Local).AddTicks(3297), "площа Вічева, 797, Південний Азарій, Російська Федерація", new DateTime(1973, 2, 13, 2, 42, 53, 736, DateTimeKind.Local).AddTicks(9909), "CAD", "Danilo_Storchak62@gmail.com", new DateTime(2022, 10, 5, 15, 50, 34, 2, DateTimeKind.Local).AddTicks(1692), "Гарнослав", "Іванців", null, "докт. техн. наук", "(097) 656-47-32", "Бухгалтер", 18841.70m, "PCI" },
                    { 50, new DateTime(2022, 1, 4, 6, 12, 14, 593, DateTimeKind.Local).AddTicks(5366), "проспект Стрийська, 7, Західний Михайло, Швеція", new DateTime(1984, 6, 1, 7, 22, 50, 183, DateTimeKind.Local).AddTicks(2368), "MMK", "Aelina_Skoropadska40@ex.ua", null, "Валентин", "Шупик", null, "докт. психол. наук", "(063) 429-65-10", "Бухгалтер", 14450.00m, "dedicated" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CreatedOn_FirstName_LastName_Patronymic",
                table: "Employees",
                columns: new[] { "CreatedOn", "FirstName", "LastName", "Patronymic" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}

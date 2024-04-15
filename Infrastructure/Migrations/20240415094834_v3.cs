using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 18, 12, 55, 17, 382, DateTimeKind.Local).AddTicks(8630), "вул. Винників, 5, Північний Лаврентій, Румунія", new DateTime(1941, 6, 4, 0, 0, 55, 126, DateTimeKind.Utc).AddTicks(6190), "Natan_Lagoida86@meta.ua", new DateTime(2023, 12, 27, 8, 22, 14, 41, DateTimeKind.Local).AddTicks(1694), "Захарій", "Дмитришин", "5910892184", "Прибиральник", 11551.04m, "Producer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 9, 6, 20, 7, 974, DateTimeKind.Local).AddTicks(5522), "Городоцька майдан, 87, Південний Августин, Нігерія", new DateTime(1928, 3, 1, 4, 2, 29, 863, DateTimeKind.Utc).AddTicks(2680), "Khristya_Petrishin9@ukr.net", null, "Гліб", "Поривай", "докт. техн. наук", "3886015908", "Бухгалтер", 6180.58m, "bluetooth" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 8, 18, 6, 29, 30, 915, DateTimeKind.Local).AddTicks(1302), "Вузька майдан, 102, Мелітополь, Панама", new DateTime(1980, 7, 2, 13, 38, 37, 394, DateTimeKind.Utc).AddTicks(5730), "Anastas34@gmail.com", new DateTime(2024, 3, 27, 21, 50, 22, 506, DateTimeKind.Local).AddTicks(1771), "Віолетта", "Юрчишина", "докт. політ. наук", "7741132160", "Бухгалтер", 12983.31m, "Michigan" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 27, 9, 22, 21, 276, DateTimeKind.Local).AddTicks(5902), "Коліївщини майдан, 96, Слов’янськ, Кірибаті", new DateTime(1936, 10, 25, 12, 12, 7, 914, DateTimeKind.Utc).AddTicks(3931), "Nelya_Vitryak@meta.ua", "Владислава", "Забіла", "канд. пед. наук", "3259935622", "Секретар", 14177.24m, "Streets" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 14, 11, 47, 20, 609, DateTimeKind.Local).AddTicks(178), "пл. Вічева, 11, Суми, Малі", new DateTime(1981, 11, 2, 23, 1, 38, 717, DateTimeKind.Utc).AddTicks(8394), "Avrelii54@gmail.com", "Броніслава", "Ногачевський", "канд. філос. наук", "4093913123", "Директор", 10203.95m, "Small" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 23, 4, 9, 28, 509, DateTimeKind.Local).AddTicks(8029), "Стрийська майдан, 2, Південний Славута, Угорщина", new DateTime(1976, 2, 25, 10, 17, 15, 116, DateTimeKind.Utc).AddTicks(2767), "Motrya_Lucka63@yandex.ua", new DateTime(2022, 1, 7, 3, 49, 17, 389, DateTimeKind.Local).AddTicks(2659), "Августин", "Паращук", "докт. пед. наук", "5014959789", 3724.90m, "Enhanced" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 3, 16, 28, 57, 159, DateTimeKind.Local).AddTicks(9475), "вулиця Винників, 74, Західний Георгій, Малайзія", new DateTime(1958, 5, 27, 20, 27, 58, 324, DateTimeKind.Utc).AddTicks(5708), "Borislava.Gaichuk84@e-mail.ua", "Ромена", "Бачей", "канд. філос. наук", "0737771531", "Програміст", 4012.36m, "Pine" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 20, 17, 45, 36, 588, DateTimeKind.Local).AddTicks(9511), "проспект Городоцька, 485, Ізмаїл, Вірменія", new DateTime(1999, 11, 29, 10, 42, 11, 825, DateTimeKind.Utc).AddTicks(3800), "Roman.Latanska@e-mail.ua", null, "Білослава", "Павлишин", "канд. юрид. наук", "4463604813", "Бухгалтер", 3775.63m, "indigo" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 12, 1, 8, 30, 916, DateTimeKind.Local).AddTicks(5013), "пр. Ліста, 29, Алчевськ, Фіджі", new DateTime(1977, 8, 24, 23, 37, 34, 542, DateTimeKind.Utc).AddTicks(6944), "Lado.Pendik83@i.ua", "Антоній", "Зінкевич", "канд. пед. наук", "6048565007", "Секретар", 7375.59m, "bleeding-edge" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 23, 13, 14, 58, 374, DateTimeKind.Local).AddTicks(1582), "Винників майдан, 4, Східний Валентин, США", new DateTime(1991, 3, 10, 21, 30, 29, 141, DateTimeKind.Utc).AddTicks(434), "Rostislav_Porivai12@ukr.net", new DateTime(2024, 3, 29, 0, 53, 0, 178, DateTimeKind.Local).AddTicks(1521), "Зборислав", "Шиян", "докт. юрид. наук", "5503057486", "Директор", 14413.34m, "e-services" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 4, 10, 12, 0, 41, 270, DateTimeKind.Local).AddTicks(5549), "Вузька майдан, 8, Ялта, Австрія", new DateTime(1941, 4, 18, 5, 35, 59, 389, DateTimeKind.Utc).AddTicks(2999), "Gradimir_Garai16@i.ua", new DateTime(2024, 2, 17, 2, 42, 18, 751, DateTimeKind.Local).AddTicks(3055), "Кузьма", "Миклухо", "канд. психол. наук", "2422782673", "Програміст", 7496.58m, "e-business" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 20, 2, 210, DateTimeKind.Local).AddTicks(1645), "Городоцька майдан, 577, Східний Братослав, Руанда", new DateTime(1926, 10, 26, 5, 4, 53, 303, DateTimeKind.Utc).AddTicks(133), "Anna20@ex.ua", new DateTime(2023, 1, 13, 19, 5, 57, 446, DateTimeKind.Local).AddTicks(3353), "Адріана", "Паламарчук", "докт. філос. наук", "0462972079", "Програміст", 5344.62m, "Functionality" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 2, 5, 33, 19, 887, DateTimeKind.Local).AddTicks(6433), "Брюховичів майдан, 492, Південний Артем, Південно-Африканська Республіка", new DateTime(1959, 9, 17, 1, 9, 4, 160, DateTimeKind.Utc).AddTicks(6981), "Oleksandr_Likovich@gmail.com", new DateTime(2019, 12, 28, 16, 45, 58, 162, DateTimeKind.Local).AddTicks(952), "Святослав", "Ланова", "докт. юрид. наук", "9290269994", 11724.52m, "empower" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 2, 13, 2, 29, 7, 338, DateTimeKind.Local).AddTicks(6836), "Коліївщини майдан, 39, Сєвєродонецьк, Ірак", new DateTime(1979, 2, 7, 20, 42, 6, 719, DateTimeKind.Utc).AddTicks(1398), "Marina_Lazirko@ukr.net", "Хорив", "Забіла", "канд. пед. наук", "2475619100", "Прибиральник", 3059.25m, "directional" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 9, 8, 2, 14, 44, 819, DateTimeKind.Local).AddTicks(3438), "Винників майдан, 6, Західний Братислав, Самоа", new DateTime(1956, 8, 31, 21, 6, 5, 609, DateTimeKind.Utc).AddTicks(6929), "Boris55@ex.ua", new DateTime(2022, 2, 3, 11, 2, 53, 887, DateTimeKind.Local).AddTicks(3597), "Гліб", "Романишин", "докт. філол. наук", "9378756272", 7815.65m, "Stream" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 3, 20, 49, 34, 273, DateTimeKind.Local).AddTicks(490), "Стрийська майдан, 445, Східний Лаврін, Франція", new DateTime(1962, 4, 2, 3, 14, 50, 315, DateTimeKind.Utc).AddTicks(4798), "Anton.Marinich20@e-mail.ua", null, "Милодара", "Ногачевський", "докт. пед. наук", "1359462199", 18467.91m, "Legacy" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 9, 15, 19, 17, 14, 609, DateTimeKind.Local).AddTicks(9676), "Нижанківського майдан, 69, Північний Семибор, Лаос", new DateTime(1946, 1, 22, 12, 2, 29, 403, DateTimeKind.Utc).AddTicks(7032), "Malva_Pogiba@meta.ua", new DateTime(2019, 7, 5, 8, 21, 29, 790, DateTimeKind.Local).AddTicks(4624), "Нестор", "Пономарів", "канд. філос. наук", "1279839230", "Програміст", 14139.60m, "Ergonomic Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 5, 1, 16, 16, 22, 749, DateTimeKind.Local).AddTicks(9459), "Молодіжна майдан, 070, Західний Зоремир, Маврикій", new DateTime(1930, 4, 27, 7, 42, 27, 576, DateTimeKind.Utc).AddTicks(8478), "Angelina19@gmail.com", null, "Марина", "Потебенько", "канд. політ. наук", "1069296137", "Секретар", 10597.54m, "experiences" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 3, 27, 16, 22, 48, 86, DateTimeKind.Local).AddTicks(9739), "проспект Стрийська, 997, Східний Корнило, Андорра", new DateTime(1999, 7, 2, 7, 6, 31, 232, DateTimeKind.Utc).AddTicks(5390), "Borimisl42@i.ua", new DateTime(2024, 3, 14, 15, 18, 48, 225, DateTimeKind.Local).AddTicks(7057), "Жанна", "Малкович", "докт. юрид. наук", "7451575089", "Бухгалтер", 16042.97m, "Port" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 11, 14, 10, 45, 59, 175, DateTimeKind.Local).AddTicks(668), "пров. Молодіжна, 482, Східний Ізяслав, Австрія", new DateTime(1962, 6, 7, 15, 20, 3, 740, DateTimeKind.Utc).AddTicks(7366), "Valentin48@meta.ua", "Станислава", "Василишина", "докт. філос. наук", "3431467251", "Секретар", 1713.38m, "transitional" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 27, 7, 42, 47, 947, DateTimeKind.Local).AddTicks(6219), "Вузька майдан, 9, Південний Степан, Нова Зеландія", new DateTime(1972, 2, 27, 14, 29, 32, 303, DateTimeKind.Utc).AddTicks(9377), "Ruslana.Yushuk@gmail.com", "Зорина", "Марієвський", "докт. філос. наук", "7335248370", "Директор", 5536.48m, "synthesize" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 6, 0, 46, 46, 627, DateTimeKind.Local).AddTicks(3307), "Зелена майдан, 07, Бердянськ, Нігер", new DateTime(1949, 3, 26, 8, 9, 14, 377, DateTimeKind.Utc).AddTicks(8990), "Zoryana2@e-mail.ua", "Родіон", "Городоцька", "канд. психол. наук", "2833565694", "Бухгалтер", 9814.21m, "Licensed" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 31, 19, 1, 14, 188, DateTimeKind.Local).AddTicks(181), "Стрийська майдан, 1, Північний Мусій, Словаччина", new DateTime(1944, 3, 4, 20, 37, 27, 287, DateTimeKind.Utc).AddTicks(5765), "Dobroslava.Kulchicka85@ex.ua", new DateTime(2021, 4, 17, 20, 7, 33, 106, DateTimeKind.Local).AddTicks(3746), "Артемія", "Шамрило", "докт. техн. наук", "6797608495", "Секретар", 8969.23m, "Fantastic Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 2, 13, 4, 45, 933, DateTimeKind.Local).AddTicks(1334), "пл. Стрийська, 466, Північний Яровид, Парагвай", new DateTime(1968, 11, 22, 13, 27, 28, 771, DateTimeKind.Utc).AddTicks(7804), "Mikola59@yandex.ua", new DateTime(2022, 3, 17, 0, 58, 53, 785, DateTimeKind.Local).AddTicks(4708), "Радослава", "Лютий", "проф.", "6524590884", "Прибиральник", 18176.30m, "1080p" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 3, 6, 18, 40, 48, 749, DateTimeKind.Local).AddTicks(1233), "Винників майдан, 740, Східний Юліан, Бенін", new DateTime(1946, 10, 27, 17, 59, 5, 360, DateTimeKind.Utc).AddTicks(5035), "Avgustin.Petrishina55@e-mail.ua", null, "Мусій", "Гриневська", "канд. і. наук", "8988297980", 4994.07m, "Frozen" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 12, 1, 12, 36, 18, 92, DateTimeKind.Local).AddTicks(9078), "Вузька майдан, 52, Черкаси, Туреччина", new DateTime(1935, 6, 10, 20, 21, 41, 192, DateTimeKind.Utc).AddTicks(2034), "Ruslan23@e-mail.ua", "Іван", "Тиндарей", "канд. і. наук", "1805342308", "Програміст", 9427.28m, "Rue" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 1, 10, 7, 37, 37, DateTimeKind.Local).AddTicks(4063), "провулок Староміська, 1, Запоріжжя, Алжир", new DateTime(1945, 7, 28, 0, 35, 31, 967, DateTimeKind.Utc).AddTicks(5504), "Zvenimir43@i.ua", "Адріян", "Луцьків", "канд. пед. наук", "2558660334", "Секретар", 5325.67m, "Usability" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 9, 15, 19, 47, 55, 328, DateTimeKind.Local).AddTicks(2809), "Зелена майдан, 66, Східний Герасим, Саудівська Аравія", new DateTime(1936, 10, 15, 6, 37, 4, 379, DateTimeKind.Utc).AddTicks(3719), "Yulian78@gmail.com", new DateTime(2020, 6, 12, 20, 0, 59, 111, DateTimeKind.Local).AddTicks(9838), "Гнат", "Сучак", "докт. юрид. наук", "0248703313", "Бухгалтер", 9957.48m, "Granite" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 6, 4, 12, 13, 507, DateTimeKind.Local).AddTicks(1618), "Городоцька майдан, 8, Західний Ратимир, Кувейт", new DateTime(1974, 2, 21, 22, 33, 14, 230, DateTimeKind.Utc).AddTicks(7048), "Bronislava14@meta.ua", new DateTime(2021, 2, 23, 11, 2, 55, 797, DateTimeKind.Local).AddTicks(3743), "Агата", "Гордійчук", "проф.", "4000684172", 5691.06m, "Haven" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 4, 4, 2, 44, 19, 81, DateTimeKind.Local).AddTicks(2682), "пл. Зелена, 3, Кам’янець-Подільський, Боснія і Герцеговина", new DateTime(1994, 9, 20, 12, 27, 35, 934, DateTimeKind.Utc).AddTicks(5172), "Mechislav.Brickii@meta.ua", null, "Кузьма", "Шиян", "канд. пед. наук", "6756379356", "Директор", 8743.40m, "copying" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 4, 16, 16, 49, 16, 889, DateTimeKind.Local).AddTicks(8409), "вул. Вузька, 69, Бердянськ, Аргентина", new DateTime(1999, 6, 18, 2, 30, 28, 769, DateTimeKind.Utc).AddTicks(9530), "Ognyana.Vitrebenko33@ukr.net", new DateTime(2023, 7, 3, 19, 6, 28, 431, DateTimeKind.Local).AddTicks(19), "Буревіст", "Яцишин", "докт. і. наук", "4162067993", "Секретар", 7227.66m, "compress" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 11, 6, 5, 23, 350, DateTimeKind.Local).AddTicks(9667), "Городоцька майдан, 5, Північний Святослав, Куба", new DateTime(2002, 9, 1, 10, 0, 17, 890, DateTimeKind.Utc).AddTicks(3493), "Romena39@yandex.ua", "Майя", "Ющук", "канд. юрид. наук", "1544163703", "Директор", 4145.05m, "Concrete" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 4, 21, 3, 31, 218, DateTimeKind.Local).AddTicks(9979), "Коліївщини майдан, 362, Західний Лаврентій, Іран", new DateTime(1939, 6, 26, 9, 19, 1, 857, DateTimeKind.Utc).AddTicks(7770), "Rayisa93@yandex.ua", "Ярополк", "Миклашевська", "докт. і. наук", "3411457104", "Секретар", 7672.09m, "Fresh" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 24, 48, 187, DateTimeKind.Local).AddTicks(9771), "проспект Рудного, 0, Західний Антон, Саудівська Аравія", new DateTime(1970, 7, 16, 4, 26, 4, 900, DateTimeKind.Utc).AddTicks(8450), "Garnoslav_Yushik53@i.ua", "Агнія", "Дзюб’як", "докт. техн. наук", "0314195820", "Прибиральник", 13879.24m, "Palau" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 18, 13, 18, 18, 654, DateTimeKind.Local).AddTicks(713), "пров. Молодіжна, 01, Хмельницький, Албанія", new DateTime(1981, 4, 8, 8, 40, 51, 102, DateTimeKind.Utc).AddTicks(2415), "Oleksii_Balaban25@meta.ua", "Родіон", "Вередун", "канд. і. наук", "2435813986", "Секретар", 13025.16m, "Beauty" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 25, 22, 0, 11, 405, DateTimeKind.Local).AddTicks(1516), "Брюховичів майдан, 75, Дніпропетровськ, Єгипет", new DateTime(1929, 7, 15, 1, 12, 24, 911, DateTimeKind.Utc).AddTicks(4867), "Albert_Yukhno81@ukr.net", "Божен", "Паламарчук", "докт. пед. наук", "9279641625", 11598.82m, "Lodge" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 12, 22, 1, 20, 911, DateTimeKind.Local).AddTicks(8513), "пл. Молодіжна, 84, Артемівськ, Ірак", new DateTime(1996, 5, 4, 1, 43, 54, 261, DateTimeKind.Utc).AddTicks(5060), "Anna40@gmail.com", new DateTime(2024, 3, 17, 11, 22, 58, 446, DateTimeKind.Local).AddTicks(4823), "Гнат", "Мазайло", "канд. техн. наук", "2702092552", "Директор", 19204.28m, "PCI" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 4, 25, 10, 22, 22, 787, DateTimeKind.Local).AddTicks(6716), "провулок Вузька, 2, Лисичанськ, Велика Британія", new DateTime(1974, 4, 15, 22, 9, 33, 789, DateTimeKind.Utc).AddTicks(5933), "Tetyana_Cushko99@i.ua", null, "Аделіна", "Петренко", "канд. психол. наук", "5822167842", "Секретар", 3737.76m, "protocol" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 10, 23, 6, 34, 777, DateTimeKind.Local).AddTicks(7730), "пров. Молодіжна, 3, Південний Олександр, Ліхтенштейн", new DateTime(1928, 3, 16, 11, 55, 28, 189, DateTimeKind.Utc).AddTicks(3559), "Solomiya_Sileckii@meta.ua", "Юстина", "Коваленко", "докт. психол. наук", "0098384720", "Бухгалтер", 9962.74m, "Refined Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 26, 16, 0, 3, 675, DateTimeKind.Local).AddTicks(5180), "Рудного майдан, 4, Північний Орест, Швеція", new DateTime(1986, 12, 16, 23, 31, 14, 353, DateTimeKind.Utc).AddTicks(8606), "Kostyantin_Skoropadskii32@ukr.net", null, "Мар’ян", "Левадовський", "докт. юрид. наук", "9269824513", "Прибиральник", 3594.52m, "quantify" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 12, 1, 9, 42, 1, 134, DateTimeKind.Local).AddTicks(4261), "пр. Нижанківського, 4, Вінниця, Австрія", new DateTime(1939, 3, 14, 18, 51, 42, 379, DateTimeKind.Utc).AddTicks(6039), "Vitalii.Parashuk@ukr.net", "Людмила", "Спотикач", "докт. психол. наук", "7450219253", "Прибиральник", 9992.92m, "Kentucky" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 1, 16, 29, 39, 561, DateTimeKind.Local).AddTicks(2238), "Городоцька майдан, 7, Західний Горислав, Бруней", new DateTime(1974, 10, 1, 17, 23, 49, 318, DateTimeKind.Utc).AddTicks(1920), "Khristina.Grigorishina@i.ua", new DateTime(2021, 12, 30, 15, 23, 8, 883, DateTimeKind.Local).AddTicks(7105), "Любомир", "Ліхно", "докт. філос. наук", "6698536616", "Директор", 19825.60m, "Garden, Beauty & Health" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 16, 6, 57, 31, 34, DateTimeKind.Local).AddTicks(530), "Городоцька майдан, 03, Західний Зорян, Гайана", new DateTime(1957, 12, 8, 0, 27, 42, 277, DateTimeKind.Utc).AddTicks(1526), "Podolyan8@i.ua", null, "Любислава", "Степанець", "канд. техн. наук", "8857460627", "Секретар", 18846.86m, "Cotton" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 28, 11, 21, 27, 483, DateTimeKind.Local).AddTicks(8496), "вулиця Вічева, 186, Східний Степан, Боснія і Герцеговина", new DateTime(1990, 12, 4, 20, 4, 26, 153, DateTimeKind.Utc).AddTicks(8946), "Vitalina_Sirko@e-mail.ua", new DateTime(2022, 3, 30, 0, 50, 16, 788, DateTimeKind.Local).AddTicks(1073), "Микола", "Гойко", "докт. техн. наук", "9460496772", "Прибиральник", 19807.84m, "redundant" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 27, 8, 17, 50, 892, DateTimeKind.Local).AddTicks(4227), "вулиця Зелена, 977, Південний Денис, Федеративні Штати Мікронезії", new DateTime(1933, 11, 15, 23, 31, 4, 349, DateTimeKind.Utc).AddTicks(4700), "Viktoriya98@meta.ua", new DateTime(2023, 5, 9, 20, 5, 30, 862, DateTimeKind.Local).AddTicks(5627), "Богуслава", "Тарасюк", "канд. пед. наук", "5613609974", "Директор", 6900.13m, "Home Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 5, 14, 52, 8, 291, DateTimeKind.Local).AddTicks(7486), "Рудного майдан, 221, Південний Володислав, Джибуті", new DateTime(1950, 7, 12, 5, 39, 46, 299, DateTimeKind.Utc).AddTicks(3722), "Oleksii_Gladukh13@yandex.ua", null, "Радміла", "Яцишин", "канд. філол. наук", "4758392105", "Директор", 16265.46m, "Refined" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 12, 1, 1, 5, 33, 470, DateTimeKind.Local).AddTicks(5508), "Вузька майдан, 05, Східний Михайло, Лесото", new DateTime(2002, 3, 15, 22, 36, 1, 900, DateTimeKind.Utc).AddTicks(9967), "Orest.Gordiichuk71@ukr.net", null, "Любава", "Бердник", "докт. політ. наук", "1130113536", "Прибиральник", 19423.86m, "primary" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 20, 12, 46, 31, 982, DateTimeKind.Local).AddTicks(4577), "Вузька майдан, 27, Південний Ратимир, Німеччина", new DateTime(1932, 8, 23, 0, 46, 42, 85, DateTimeKind.Utc).AddTicks(4295), "Vsevlad_Grinevskii7@i.ua", new DateTime(2021, 9, 28, 13, 23, 54, 180, DateTimeKind.Local).AddTicks(8358), "Люборада", "Барановський", "канд. філос. наук", "2768268393", "Бухгалтер", 5753.83m, "open-source" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 1, 12, 57, 31, 372, DateTimeKind.Local).AddTicks(6103), "Коліївщини майдан, 5, Біла Церква, Гайана", new DateTime(2003, 1, 5, 20, 32, 8, 96, DateTimeKind.Utc).AddTicks(3133), "Boleslav14@yandex.ua", "Святослав", "Майстренко", "канд. юрид. наук", "3803216964", "Директор", 1677.74m, "Plastic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 20, 0, 50, 37, 27, DateTimeKind.Local).AddTicks(9015), "проспект Нижанківського, 6, Макіївка, Ліван", new DateTime(1941, 12, 22, 11, 53, 31, 749, DateTimeKind.Utc).AddTicks(3316), "Polyana_Shukhevich@i.ua", "Братимир", "Федоришина", "докт. пед. наук", "5021951369", "Бухгалтер", 18170.98m, "French Southern Territories" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 7, 19, 6, 15, 26, 729, DateTimeKind.Local).AddTicks(8916), "Городоцька майдан, 5, Чернівці, Уругвай", new DateTime(1963, 10, 31, 21, 33, 31, 614, DateTimeKind.Utc).AddTicks(1877), "Tamara.Pendik@e-mail.ua", new DateTime(2020, 5, 4, 13, 37, 11, 323, DateTimeKind.Local).AddTicks(3073), "Любодар", "Горбач", "докт. філос. наук", "3738106607", "Секретар", 8512.24m, "Clothing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 5, 21, 33, 57, 435, DateTimeKind.Local).AddTicks(304), "пр. Рудного, 236, Ужгород, Ірландія", new DateTime(1978, 11, 25, 19, 19, 42, 481, DateTimeKind.Utc).AddTicks(4731), "Roksolan.Dmitrishin@i.ua", "Аврелія", "Махно", "канд. і. наук", "5750628087", 3732.86m, "Investment Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 13, 13, 53, 35, 120, DateTimeKind.Local).AddTicks(49), "проспект Рудного, 39, Східний Тиміш, Йорданія", new DateTime(1942, 4, 8, 19, 22, 13, 332, DateTimeKind.Utc).AddTicks(5449), "Slava.Yushik77@i.ua", new DateTime(2022, 5, 2, 4, 8, 22, 298, DateTimeKind.Local).AddTicks(6847), "Влада", "Сплюх", "докт. техн. наук", "9880920026", "Прибиральник", 9528.75m, "Texas" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 31, 17, 18, 58, 691, DateTimeKind.Local).AddTicks(4771), "Ліста майдан, 269, Хмельницький, Таджикистан", new DateTime(1998, 12, 31, 23, 43, 7, 491, DateTimeKind.Utc).AddTicks(7971), "Gradimir.Demkiv@meta.ua", null, "Микита", "Балицький", "канд. філос. наук", "4812628167", "Бухгалтер", 9026.01m, "synthesize" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 20, 4, 25, 45, 350, DateTimeKind.Local).AddTicks(9919), "Ліста майдан, 9, Тернопіль, Багамські Острови", new DateTime(1967, 2, 12, 2, 49, 57, 227, DateTimeKind.Utc).AddTicks(9826), "Bratomil_Zlenko@ex.ua", new DateTime(2020, 8, 13, 5, 13, 16, 605, DateTimeKind.Local).AddTicks(6717), "Тиміш", "Бандера", "проф.", "2016413213", "Прибиральник", 9243.24m, "back-end" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 11, 25, 18, 21, 46, 709, DateTimeKind.Local).AddTicks(5085), "площа Брюховичів, 073, Хмельницький, Гвінея", new DateTime(1981, 8, 25, 9, 35, 17, 731, DateTimeKind.Utc).AddTicks(7542), "Oriyana.Gromiko@e-mail.ua", "Юхима", "Бердник", "докт. філос. наук", "4765373334", "Бухгалтер", 6665.53m, "Global" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 21, 20, 736, DateTimeKind.Local).AddTicks(9314), "пл. Винників, 30, Східний Пилип, Мадаґаскар", new DateTime(1987, 4, 10, 10, 36, 16, 656, DateTimeKind.Utc).AddTicks(3500), "Sologub34@i.ua", "Анатолія", "Яцишина", "докт. філол. наук", "1918832061", "Програміст", 7498.14m, "Auto Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 12, 10, 11, 13, 15, 247, DateTimeKind.Local).AddTicks(4050), "Ліста майдан, 927, Північний Микита, Кот-д’Івуар", new DateTime(1974, 7, 11, 1, 12, 31, 646, DateTimeKind.Utc).AddTicks(612), "Natan32@ex.ua", null, "Юхимія", "Корецька", "доц.", "1021691142", "Програміст", 11301.59m, "Shoes & Jewelery" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 3, 30, 2, 2, 5, 217, DateTimeKind.Local).AddTicks(8860), "Рудного майдан, 502, Ужгород, Австралія", new DateTime(1952, 12, 29, 3, 46, 4, 292, DateTimeKind.Utc).AddTicks(2035), "Oriyana_Usich@i.ua", new DateTime(2023, 5, 9, 6, 17, 1, 633, DateTimeKind.Local).AddTicks(9208), "Марія", "Сідлецький", "доц.", "4018296181", "Бухгалтер", 5748.73m, "Ramp" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 10, 14, 1, 5, 988, DateTimeKind.Local).AddTicks(5047), "Стрийська майдан, 5, Західний Анастасій, Андорра", new DateTime(1997, 7, 8, 18, 38, 23, 554, DateTimeKind.Utc).AddTicks(6679), "Ladomir_Romei@i.ua", new DateTime(2019, 10, 17, 23, 20, 19, 234, DateTimeKind.Local).AddTicks(4804), "Любомир", "Паращук", "канд. філол. наук", "6872525546", "Директор", 3172.01m, "Licensed Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 7, 30, 4, 7, 42, 9, DateTimeKind.Local).AddTicks(3374), "Брюховичів майдан, 14, Північний Зорян, Ліван", new DateTime(1965, 8, 31, 9, 58, 31, 643, DateTimeKind.Utc).AddTicks(3851), "Vladislava_Shukhevich39@e-mail.ua", new DateTime(2019, 5, 2, 16, 36, 55, 913, DateTimeKind.Local).AddTicks(7420), "Любомила", "Пригода", "канд. юрид. наук", "2445488725", "Секретар", 4779.98m, "e-markets" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 3, 4, 30, 33, 78, DateTimeKind.Local).AddTicks(2110), "вулиця Ліста, 5, Південний Ладо, Непал", new DateTime(1984, 10, 13, 11, 30, 45, 1, DateTimeKind.Utc).AddTicks(7780), "Zoremir.Gladkivskii@meta.ua", new DateTime(2023, 6, 27, 6, 35, 40, 730, DateTimeKind.Local).AddTicks(156), "Валентин", "Коваленко", "6499255723", "Директор", 18955.09m, "Dynamic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 6, 18, 24, 15, 206, DateTimeKind.Local).AddTicks(6206), "пров. Староміська, 04, Східний Данило, Мексика", new DateTime(1931, 9, 25, 14, 35, 26, 338, DateTimeKind.Utc).AddTicks(7509), "Dobroslava_Lyutii@gmail.com", new DateTime(2021, 10, 28, 11, 41, 55, 934, DateTimeKind.Local).AddTicks(199), "Ратибор", "Ющик", "канд. філос. наук", "1183857939", "Секретар", 19889.90m, "Concrete" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 30, 8, 41, 14, 162, DateTimeKind.Local).AddTicks(2724), "Городоцька майдан, 5, Євпаторія, Ліван", new DateTime(1927, 4, 23, 0, 37, 45, 86, DateTimeKind.Utc).AddTicks(1570), "Azarii_Troyan22@gmail.com", null, "Анатолія", "Павлів", "докт. пед. наук", "3635286392", "Програміст", 6561.57m, "turquoise" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 8, 27, 5, 49, 12, 169, DateTimeKind.Local).AddTicks(3400), "Зелена майдан, 082, Харків, Домініканська Республіка", new DateTime(1951, 6, 7, 22, 43, 41, 838, DateTimeKind.Utc).AddTicks(4504), "Vseslav.Makhno@ex.ua", new DateTime(2023, 2, 16, 23, 48, 2, 24, DateTimeKind.Local).AddTicks(2913), "В’ячеслава", "Зварич", "проф.", "8431556961", "Бухгалтер", 9207.75m, "Parks" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 1, 6, 20, 10, 31, 87, DateTimeKind.Local).AddTicks(7323), "вулиця Ліста, 265, Миколаїв, Естонія", new DateTime(1926, 10, 21, 8, 50, 25, 903, DateTimeKind.Utc).AddTicks(9378), "Agata75@meta.ua", new DateTime(2022, 5, 26, 13, 6, 12, 938, DateTimeKind.Local).AddTicks(1204), "Златомир", "Семещук", "канд. техн. наук", "6334752371", 4477.29m, "Toys, Automotive & Tools" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 11, 4, 6, 36, 44, 210, DateTimeKind.Local).AddTicks(4273), "Городоцька майдан, 008, Східний Михайло, Гватемала", new DateTime(1993, 5, 15, 14, 57, 1, 893, DateTimeKind.Utc).AddTicks(3110), "Gavrilo.Serdyuk@i.ua", null, "Мирослав", "Поривайло", "канд. техн. наук", "1943318611", "Бухгалтер", 10374.89m, "Handmade Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 26, 5, 52, 0, 911, DateTimeKind.Local).AddTicks(868), "Зелена майдан, 88, Дніпродзержинськ, Беліз", new DateTime(1964, 11, 30, 20, 27, 45, 272, DateTimeKind.Utc).AddTicks(695), "Sonya.Yalyuk@e-mail.ua", "Ростислав", "Головець", "докт. техн. наук", "5536775853", "Прибиральник", 19892.05m, "Optimization" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 3, 30, 6, 35, 30, 133, DateTimeKind.Local).AddTicks(8652), "вул. Молодіжна, 402, Лисичанськ, Парагвай", new DateTime(1959, 2, 2, 13, 45, 56, 545, DateTimeKind.Utc).AddTicks(354), "Vseslava.Banera30@i.ua", null, "Біломир", "Горовий", "канд. пед. наук", "9508474634", "Секретар", 6372.22m, "Licensed" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 14, 8, 20, 35, 45, DateTimeKind.Local).AddTicks(5349), "Вічева майдан, 006, Східний Петро, Гайана", new DateTime(1969, 3, 3, 15, 51, 27, 879, DateTimeKind.Utc).AddTicks(8950), "Violetta.Dmitruk65@ukr.net", null, "Білослава", "Луцька", "канд. і. наук", "0296740995", 8713.76m, "maroon" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 3, 11, 50, 47, 843, DateTimeKind.Local).AddTicks(7515), "Винників майдан, 246, Макіївка, Свазіленд", new DateTime(1986, 3, 1, 10, 0, 31, 287, DateTimeKind.Utc).AddTicks(9636), "Daleslava.Yermak62@yandex.ua", new DateTime(2020, 10, 1, 13, 24, 19, 168, DateTimeKind.Local).AddTicks(1439), "Божена", "Червоній", "канд. юрид. наук", "7967755362", "Секретар", 15412.80m, "open-source" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 28, 16, 0, 22, 558, DateTimeKind.Local).AddTicks(2541), "Нижанківського майдан, 1, Мелітополь, Бруней", new DateTime(1977, 1, 28, 3, 36, 49, 748, DateTimeKind.Utc).AddTicks(9951), "Vladislava.Maistrenko@ex.ua", new DateTime(2023, 9, 9, 18, 37, 25, 578, DateTimeKind.Local).AddTicks(358), "Ігор", "Ліхно", "докт. техн. наук", "2253912600", "Директор", 12741.83m, "District" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 12, 10, 10, 36, 30, 478, DateTimeKind.Local).AddTicks(443), "Городоцька майдан, 3, Біла Церква, Естонія", new DateTime(1934, 11, 3, 4, 45, 9, 630, DateTimeKind.Utc).AddTicks(8947), "Ruslana_Maistrenko@e-mail.ua", new DateTime(2023, 4, 15, 13, 32, 3, 811, DateTimeKind.Local).AddTicks(3885), "Любозар", "Карпух", "1381411126", "Директор", 9744.23m, "Summit" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 11, 13, 4, 46, 0, 467, DateTimeKind.Local).AddTicks(8693), "пл. Молодіжна, 08, Західний Добромисл, Алжир", new DateTime(1995, 4, 26, 15, 59, 46, 212, DateTimeKind.Utc).AddTicks(77), "Dana4@meta.ua", "Олелько", "Григоришин", "докт. філос. наук", "0195225510", "Програміст", 2818.24m, "open-source" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 4, 23, 13, 36, 21, 633, DateTimeKind.Local).AddTicks(3516), "пр. Ліста, 517, Чернівці, Сан-Марино", new DateTime(1928, 1, 31, 3, 31, 50, 297, DateTimeKind.Utc).AddTicks(5007), "Biloslava_Porivai27@gmail.com", "Аделаїда", "Мазило", "докт. філол. наук", "2949631813", "Бухгалтер", 5387.07m, "Wooden" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 1, 26, 2, 30, 2, 483, DateTimeKind.Local).AddTicks(5150), "Зелена майдан, 849, Шостка, Кірибаті", new DateTime(1996, 9, 10, 8, 42, 35, 540, DateTimeKind.Utc).AddTicks(1845), "Alvina56@i.ua", new DateTime(2022, 2, 25, 20, 39, 50, 188, DateTimeKind.Local).AddTicks(2433), "Тарас", "Бамбула", "докт. філол. наук", "2845108631", 11457.22m, "primary" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 11, 19, 0, 20, 54, 52, DateTimeKind.Local).AddTicks(1713), "вулиця Староміська, 02, Північний Зореслав, Того", new DateTime(1960, 7, 27, 14, 42, 6, 89, DateTimeKind.Utc).AddTicks(6039), "Krentta_Sirko@e-mail.ua", "Поліна", "Палій", "канд. філол. наук", "3901915125", "Програміст", 2988.57m, "Team-oriented" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 18, 11, 26, 53, 44, DateTimeKind.Local).AddTicks(4329), "пр. Винників, 32, Сєвєродонецьк, Ісландія", new DateTime(1990, 7, 24, 15, 27, 31, 450, DateTimeKind.Utc).AddTicks(1665), "Stepan_Stepanec@e-mail.ua", new DateTime(2023, 9, 21, 2, 17, 48, 955, DateTimeKind.Local).AddTicks(5496), "Анастасій", "Савицький", "канд. філол. наук", "4193365184", "Бухгалтер", 15193.66m, "Sleek Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 7, 0, 4, 6, 386, DateTimeKind.Local).AddTicks(1017), "Ліста майдан, 458, Східний Руслан, Нова Зеландія", new DateTime(1969, 5, 1, 3, 2, 32, 735, DateTimeKind.Utc).AddTicks(4723), "Polyana.Babukh@ex.ua", null, "Володимир", "Довгалевський", "докт. юрид. наук", "3841688444", 18919.13m, "Morocco" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 12, 17, 12, 41, 35, 620, DateTimeKind.Local).AddTicks(8499), "пров. Староміська, 46, Південний Даромир, Індія", new DateTime(1943, 4, 2, 17, 23, 56, 51, DateTimeKind.Utc).AddTicks(4121), "Dobromisl26@ukr.net", new DateTime(2022, 9, 30, 18, 22, 22, 813, DateTimeKind.Local).AddTicks(7410), "Юхим", "Потебенько", "канд. юрид. наук", "6602012627", "Прибиральник", 5896.63m, "web-enabled" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 30, 1, 46, 4, 696, DateTimeKind.Local).AddTicks(9531), "вул. Рудного, 402, Маріуполь, Ліберія", new DateTime(1934, 2, 12, 7, 47, 27, 760, DateTimeKind.Utc).AddTicks(4572), "Ivanna.Goiko99@ex.ua", null, "Жанна", "Верещук", "3765830158", "Прибиральник", 12071.43m, "scalable" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 8, 10, 15, 41, 51, 520, DateTimeKind.Local).AddTicks(3778), "пров. Ліста, 669, Північний Всевлад, Еритрея", new DateTime(1979, 3, 16, 6, 27, 38, 697, DateTimeKind.Utc).AddTicks(1373), "Milana_Gaiduk@meta.ua", new DateTime(2021, 12, 1, 11, 13, 39, 149, DateTimeKind.Local).AddTicks(6862), "Білослава", "Євенко", "канд. психол. наук", "0033398143", "Бухгалтер", 6718.30m, "connecting" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 18, 12, 56, 41, 283, DateTimeKind.Local).AddTicks(4606), "площа Городоцька, 32, Західний Славолюб, Барбадос", new DateTime(1935, 9, 2, 8, 34, 53, 126, DateTimeKind.Utc).AddTicks(6245), "Olesya.Usich@ukr.net", "Братомил", "Петрин", "канд. юрид. наук", "2000605974", "Програміст", 12707.99m, "Awesome Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 4, 21, 18, 5, 46, 212, DateTimeKind.Local).AddTicks(7373), "Винників майдан, 1, Вінниця, Самоа", new DateTime(1998, 9, 11, 16, 25, 32, 305, DateTimeKind.Utc).AddTicks(6326), "Oleg36@meta.ua", "Братислав", "Силецький", "канд. філол. наук", "9570445788", 11516.45m, "asynchronous" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 5, 12, 6, 30, 31, 8, DateTimeKind.Local).AddTicks(9752), "вулиця Зелена, 8, Південний Володислав, Алжир", new DateTime(1944, 3, 10, 4, 20, 11, 749, DateTimeKind.Utc).AddTicks(6911), "Yaromir96@yandex.ua", "Ілля", "Ромочко", "канд. філос. наук", "7412041494", "Програміст", 18353.03m, "synthesize" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 12, 7, 11, 49, 850, DateTimeKind.Local).AddTicks(6662), "проспект Рудного, 69, Північний Павло, Бурунді", new DateTime(1936, 10, 2, 21, 1, 35, 278, DateTimeKind.Utc).AddTicks(8690), "Musii4@yandex.ua", new DateTime(2019, 9, 29, 0, 19, 2, 830, DateTimeKind.Local).AddTicks(479), "Буревіст", "Павлів", "канд. техн. наук", "0177457571", "Бухгалтер", 13753.84m, "artificial intelligence" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 22, 7, 14, 58, 523, DateTimeKind.Local).AddTicks(4379), "пров. Молодіжна, 66, Північний Біломир, Непал", new DateTime(1958, 12, 26, 5, 24, 1, 698, DateTimeKind.Utc).AddTicks(3247), "Rostislava68@ex.ua", new DateTime(2022, 1, 15, 6, 40, 34, 485, DateTimeKind.Local).AddTicks(7889), "Антонида", "Балабух", "канд. політ. наук", "3842940895", 9222.22m, "bandwidth" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 3, 31, 22, 32, 3, 306, DateTimeKind.Local).AddTicks(4379), "Староміська майдан, 370, Південний Роман, Ісландія", new DateTime(1961, 10, 30, 2, 52, 52, 388, DateTimeKind.Utc).AddTicks(8189), "Liliya_Gamula@gmail.com", new DateTime(2020, 10, 27, 2, 30, 15, 385, DateTimeKind.Local).AddTicks(7350), "Агнія", "Кульчицька", "докт. політ. наук", "3832425570", "Прибиральник", 6198.18m, "secured line" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 6, 17, 45, 49, 593, DateTimeKind.Local).AddTicks(5146), "Винників майдан, 970, Східний Георгій, Куба", new DateTime(1961, 2, 28, 21, 21, 53, 496, DateTimeKind.Utc).AddTicks(5567), "Sinook56@i.ua", new DateTime(2021, 7, 19, 19, 28, 29, 331, DateTimeKind.Local).AddTicks(7943), "Варвара", "Плаксій", "проф.", "6802308430", "Директор", 3203.73m, "turquoise" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 5, 26, 18, 23, 47, 787, DateTimeKind.Local).AddTicks(8927), "проспект Зелена, 8, Керч, Кабо-Верде", new DateTime(1957, 11, 19, 9, 5, 22, 342, DateTimeKind.Utc).AddTicks(454), "Taras_Danilishin47@gmail.com", new DateTime(2022, 8, 22, 20, 30, 12, 273, DateTimeKind.Local).AddTicks(9970), "Звенимир", "Яворівська", "канд. техн. наук", "8888890555", "Прибиральник", 12392.05m, "Computers & Automotive" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 11, 7, 21, 6, 29, 992, DateTimeKind.Local).AddTicks(4030), "вулиця Рудного, 990, Івано-Франківськ, Екваторіальна Гвінея", new DateTime(1963, 6, 4, 10, 25, 7, 872, DateTimeKind.Utc).AddTicks(3837), "Antonii44@meta.ua", "Людомила", "Саєнко", "канд. пед. наук", "1606805592", "Прибиральник", 17232.85m, "Human" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 9, 17, 57, 43, 426, DateTimeKind.Local).AddTicks(3719), "Нижанківського майдан, 84, Західний Влад, Еритрея", new DateTime(1971, 7, 11, 16, 28, 10, 381, DateTimeKind.Utc).AddTicks(9945), "Inna.Pendik@i.ua", null, "Февронія", "Майборода", "канд. пед. наук", "0113863503", "Програміст", 17468.75m, "Strategist" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 9, 19, 7, 33, 439, DateTimeKind.Local).AddTicks(3344), "пров. Молодіжна, 5, Сімферополь, Кувейт", new DateTime(2002, 5, 14, 22, 17, 9, 273, DateTimeKind.Utc).AddTicks(8847), "Shek.Gladukh69@meta.ua", new DateTime(2019, 11, 23, 0, 43, 23, 999, DateTimeKind.Local).AddTicks(976), "Степан", "Григоришина", "докт. пед. наук", "7590463668", 12107.61m, "protocol" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 12, 11, 27, 18, 325, DateTimeKind.Local).AddTicks(6304), "Ліста майдан, 029, Миколаїв, Філіппіни", new DateTime(1989, 3, 7, 14, 52, 56, 865, DateTimeKind.Utc).AddTicks(2541), "Maryana63@meta.ua", new DateTime(2022, 4, 1, 5, 10, 55, 143, DateTimeKind.Local).AddTicks(4440), "Родіон", "Ющик", "докт. і. наук", "9712900516", "Прибиральник", 14292.57m, "middleware" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 4, 20, 33, 25, 8, DateTimeKind.Local).AddTicks(4763), "вул. Ліста, 14, Західний Хвалимир, Південна Корея", new DateTime(1928, 1, 14, 13, 41, 50, 547, DateTimeKind.Utc).AddTicks(6531), "Zinayida_Kandiba66@meta.ua", "Владислав", "Кандиба", "доц.", "8349110610", "Прибиральник", 19354.97m, "Track" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 7, 15, 0, 7, 58, DateTimeKind.Local).AddTicks(3951), "пр. Ліста, 848, Слов’янськ, Південно-Африканська Республіка", new DateTime(1932, 10, 11, 6, 32, 23, 532, DateTimeKind.Utc).AddTicks(4363), "Volodislav81@ex.ua", null, "Анжела", "Дзюб’як", "проф.", "0133700108", "Бухгалтер", 3856.12m, "generate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 9, 29, 13, 56, 58, 664, DateTimeKind.Local).AddTicks(8458), "Староміська майдан, 5, Північний Братомил, Азербайджан", new DateTime(1943, 5, 5, 6, 58, 46, 256, DateTimeKind.Utc).AddTicks(2775), "Alevtina.Boreckii@meta.ua", "Зорина", "Гречко", "канд. психол. наук", "3259106817", 15105.58m, "Games & Tools" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 26, 2, 14, 17, 818, DateTimeKind.Local).AddTicks(5832), "Рудного майдан, 0, Ялта, Грузія", new DateTime(1939, 11, 15, 23, 1, 32, 139, DateTimeKind.Utc).AddTicks(8095), "Galina.Lyuta@meta.ua", null, "Мстислав", "Прядун", "докт. юрид. наук", "9795587953", "Прибиральник", 4994.43m, "neural" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 15, 22, 9, 34, 623, DateTimeKind.Local).AddTicks(1637), "Зелена майдан, 0, Південний Захарій, Сербія", new DateTime(2006, 2, 5, 13, 36, 34, 889, DateTimeKind.Utc).AddTicks(3274), "Askold.Troyan@ukr.net", null, "Буйтур", "Мотрієнко", "докт. техн. наук", "0932783758", "Директор", 19310.86m, "innovate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 21, 5, 45, 36, 741, DateTimeKind.Local).AddTicks(9788), "Вічева майдан, 3, Східний Лаврін, Аргентина", new DateTime(1955, 5, 20, 8, 14, 20, 521, DateTimeKind.Utc).AddTicks(1912), "Valerii_Sidlyak@yandex.ua", null, "Дарислава", "Потебенько", "докт. і. наук", "2856873453", "Секретар", 11243.75m, "Rupiah" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 7, 11, 54, 51, 355, DateTimeKind.Local).AddTicks(964), "Коліївщини майдан, 2, Південний Мусій, Таджикистан", new DateTime(1971, 7, 1, 19, 52, 2, 610, DateTimeKind.Utc).AddTicks(7415), "Solomiya39@yandex.ua", new DateTime(2021, 2, 16, 20, 29, 27, 954, DateTimeKind.Local).AddTicks(2027), "Хвалимир", "Ромей", "докт. філос. наук", "1002273426", "Програміст", 10961.31m, "feed" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 10, 3, 50, 28, 671, DateTimeKind.Local).AddTicks(7049), "Нижанківського майдан, 81, Луганськ, Таджикистан", new DateTime(1960, 9, 4, 6, 34, 20, 503, DateTimeKind.Utc).AddTicks(1735), "Valentina.Zabila42@e-mail.ua", new DateTime(2020, 10, 10, 1, 2, 13, 463, DateTimeKind.Local).AddTicks(108), "Марія", "Дзюб’як", "докт. і. наук", "0151075266", "Прибиральник", 15152.36m, "Macedonia" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 11, 13, 14, 6, 26, 168, DateTimeKind.Local).AddTicks(970), "Рудного майдан, 1, Східний Орхип, Казахстан", new DateTime(1958, 1, 28, 6, 0, 35, 230, DateTimeKind.Utc).AddTicks(7177), "Yuliya_Steckiv@i.ua", new DateTime(2021, 12, 10, 2, 46, 8, 192, DateTimeKind.Local).AddTicks(479), "Антонія", "Іванів", "канд. психол. наук", "6261804159", "Директор", 15970.04m, "functionalities" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 11, 11, 20, 41, 9, 833, DateTimeKind.Local).AddTicks(2430), "провулок Городоцька, 1, Східний Юхим, Панама", new DateTime(1979, 8, 27, 19, 56, 40, 697, DateTimeKind.Utc).AddTicks(397), "Khristya83@yandex.ua", "Володимир", "Паращук", "канд. і. наук", "8670890896", "Секретар", 12787.06m, "platforms" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 29, 21, 20, 19, 335, DateTimeKind.Local).AddTicks(7741), "пл. Молодіжна, 84, Північний Дмитро, Фіджі", new DateTime(1938, 6, 22, 5, 10, 19, 794, DateTimeKind.Utc).AddTicks(7969), "Dobromisl.Dmitrishin@i.ua", "В’ячеслав", "Сторчак", "канд. і. наук", "7346643621", 19445.09m, "Planner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 2, 19, 29, 0, 619, DateTimeKind.Local).AddTicks(3589), "Вузька майдан, 985, Східний Устим, Федеративні Штати Мікронезії", new DateTime(1957, 9, 8, 14, 16, 12, 503, DateTimeKind.Utc).AddTicks(1560), "Arkadii_Miklukho@e-mail.ua", new DateTime(2022, 10, 5, 20, 27, 40, 672, DateTimeKind.Local).AddTicks(5578), "Всеслава", "Калач", "докт. психол. наук", "2090326530", "Бухгалтер", 3814.46m, "program" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 29, 22, 46, 42, 566, DateTimeKind.Local).AddTicks(9646), "проспект Нижанківського, 085, Дніпродзержинськ, Латвія", new DateTime(1949, 11, 4, 15, 53, 4, 806, DateTimeKind.Utc).AddTicks(2639), "Marta29@ukr.net", new DateTime(2020, 5, 20, 8, 58, 43, 442, DateTimeKind.Local).AddTicks(7472), "Буйтур", "Коломієць", "канд. психол. наук", "9073444302", "Директор", 10550.08m, "HDD" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 9, 16, 17, 2, 865, DateTimeKind.Local).AddTicks(414), "Нижанківського майдан, 17, Південний Боримир, Малаві", new DateTime(1996, 2, 5, 4, 11, 3, 195, DateTimeKind.Utc).AddTicks(8939), "Yurii44@yandex.ua", new DateTime(2021, 3, 28, 17, 42, 47, 46, DateTimeKind.Local).AddTicks(7097), "Борислава", "Пригода", "докт. філос. наук", "2762898693", "Програміст", 6804.85m, "Plastic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 3, 21, 14, 22, 17, 358, DateTimeKind.Local).AddTicks(3330), "проспект Винників, 308, Артемівськ, Південна Корея", new DateTime(1981, 2, 11, 6, 54, 2, 54, DateTimeKind.Utc).AddTicks(6458), "Doleslava_Pasichnik@e-mail.ua", "Віктор", "Андрухович", "докт. філос. наук", "6313703723", "Програміст", 5017.96m, "Handmade Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 18, 0, 50, 34, 93, DateTimeKind.Local).AddTicks(1671), "Вічева майдан, 698, Бердянськ, Індонезія", new DateTime(1953, 12, 7, 2, 59, 12, 734, DateTimeKind.Utc).AddTicks(2507), "Arsen4@i.ua", null, "Мілана", "Гладківська", "докт. філос. наук", "1075857781", "Секретар", 16945.57m, "Borders" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 14, 14, 1, 38, 198, DateTimeKind.Local).AddTicks(9378), "Вічева майдан, 948, Єнакієве, Україна", new DateTime(1939, 8, 29, 14, 7, 24, 395, DateTimeKind.Utc).AddTicks(3338), "Bozhen_Semeshuk40@yandex.ua", "Агнія", "Трублаєвська", "докт. політ. наук", "7866234946", 7191.23m, "maximize" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 4, 30, 3, 25, 44, 262, DateTimeKind.Local).AddTicks(8446), "Староміська майдан, 89, Ялта, Фінляндія", new DateTime(1967, 2, 22, 2, 43, 18, 112, DateTimeKind.Utc).AddTicks(3476), "Igor_Dmitrishin65@i.ua", new DateTime(2023, 12, 13, 3, 17, 8, 119, DateTimeKind.Local).AddTicks(8318), "Ратибор", "Трублаєвський", "канд. пед. наук", "6985810778", "Секретар", 7642.99m, "Unbranded" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 20, 1, 4, 20, 426, DateTimeKind.Local).AddTicks(5506), "Коліївщини майдан, 3, Маріуполь, Маршаллові Острови", new DateTime(1991, 1, 4, 20, 57, 6, 367, DateTimeKind.Utc).AddTicks(9456), "Rostislava_Shukhevich@gmail.com", "Забава", "Демчишин", "докт. політ. наук", "1592453605", "Секретар", 9073.34m, "unleash" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 30, 10, 12, 24, 789, DateTimeKind.Local).AddTicks(8246), "пл. Молодіжна, 65, Західний Зореслав, Гвінея-Бісау", new DateTime(1985, 7, 3, 23, 30, 24, 932, DateTimeKind.Utc).AddTicks(9933), "Agafiya.Pavlishin@gmail.com", "Пелагія", "Гриневська", "докт. філол. наук", "0886497133", 10221.42m, "Bedfordshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 5, 7, 7, 0, 20, 946, DateTimeKind.Local).AddTicks(1078), "Зелена майдан, 58, Донецьк, Замбія", new DateTime(1949, 1, 19, 3, 30, 27, 261, DateTimeKind.Utc).AddTicks(6703), "Alina.Shkaraba75@i.ua", null, "Ростислава", "Сірко", "докт. психол. наук", "8359028818", "Прибиральник", 6796.03m, "Legacy" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 4, 20, 6, 46, 832, DateTimeKind.Local).AddTicks(6414), "пл. Молодіжна, 772, Ялта, Сент-Кітс і Невіс", new DateTime(1971, 3, 22, 4, 42, 8, 130, DateTimeKind.Utc).AddTicks(7753), "Zoreslava_Lucka@i.ua", "Добромисл", "Гордійчук", "докт. пед. наук", "3475838030", "Програміст", 17486.90m, "Branch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 12, 5, 23, 52, 4, 670, DateTimeKind.Local).AddTicks(6134), "пл. Стрийська, 95, Східний Костянтин, Мавританія", new DateTime(1974, 1, 13, 18, 2, 29, 173, DateTimeKind.Utc).AddTicks(2653), "Zoremir.Yalovii89@i.ua", new DateTime(2019, 4, 27, 1, 45, 20, 411, DateTimeKind.Local).AddTicks(4295), "Нестор", "Гришко", "канд. пед. наук", "9600499149", "Бухгалтер", 5182.87m, "Naira" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 15, 20, 36, 15, 804, DateTimeKind.Local).AddTicks(8828), "вулиця Вічева, 08, Чернігів, Венесуела", new DateTime(1974, 1, 14, 0, 20, 29, 321, DateTimeKind.Utc).AddTicks(9755), "Liliya.Plaksii@ukr.net", new DateTime(2021, 8, 30, 15, 58, 24, 0, DateTimeKind.Local).AddTicks(1420), "В’ячеслав", "Кулинич", "канд. юрид. наук", "7008881290", "Прибиральник", 6953.74m, "Rustic Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 5, 29, 20, 8, 29, 581, DateTimeKind.Local).AddTicks(7673), "проспект Винників, 33, Південний Назар, Південна Корея", new DateTime(1960, 2, 15, 1, 4, 38, 487, DateTimeKind.Utc).AddTicks(9126), "Tayisiya.Makoveckii@gmail.com", null, "Лідія", "Мазайло", "доц.", "9131899805", 7002.93m, "Money Market Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 2, 14, 9, 18, 56, DateTimeKind.Local).AddTicks(514), "проспект Коліївщини, 681, Кіровоград, Російська Федерація", new DateTime(1959, 3, 20, 6, 57, 0, 330, DateTimeKind.Utc).AddTicks(9061), "Miroslava.Borecka@yandex.ua", new DateTime(2019, 8, 5, 10, 26, 39, 15, DateTimeKind.Local).AddTicks(1172), "Валерія", "Волощук", "3863511267", "Бухгалтер", 7917.34m, "seamless" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 31, 16, 11, 41, 970, DateTimeKind.Local).AddTicks(842), "пров. Молодіжна, 27, Західний Горислав, Багамські Острови", new DateTime(1944, 1, 20, 14, 25, 55, 375, DateTimeKind.Utc).AddTicks(7229), "Alla.Kivach@gmail.com", "Ірина", "Павлів", "докт. і. наук", "7585300202", "Прибиральник", 10440.86m, "Cape" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 15, 7, 33, 39, 174, DateTimeKind.Local).AddTicks(4506), "Брюховичів майдан, 80, Південний Артем, Нігерія", new DateTime(1932, 2, 12, 15, 39, 48, 132, DateTimeKind.Utc).AddTicks(9128), "Yukhima65@e-mail.ua", null, "Олег", "Лагойда", "докт. психол. наук", "3540043236", "Бухгалтер", 13362.27m, "generating" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 20, 8, 46, 35, 936, DateTimeKind.Local).AddTicks(2365), "Коліївщини майдан, 166, Південний Ярополк, Боснія і Герцеговина", new DateTime(1979, 5, 10, 7, 47, 6, 201, DateTimeKind.Utc).AddTicks(9450), "Petro_Lanova@ukr.net", "Добромира", "Шестак", "канд. юрид. наук", "6102526705", 4630.94m, "Metal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 11, 14, 23, 39, 32, 307, DateTimeKind.Local).AddTicks(3726), "Зелена майдан, 48, Харків, Бруней", new DateTime(1967, 11, 1, 20, 35, 33, 142, DateTimeKind.Utc).AddTicks(1291), "Pelagiya.Moskalyuk63@e-mail.ua", null, "Далемир", "Іванців", "канд. юрид. наук", "0635100081", "Директор", 16617.27m, "Armenian Dram" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 18, 21, 18, 5, 388, DateTimeKind.Local).AddTicks(8981), "площа Молодіжна, 069, Західний Златомир, Йорданія", new DateTime(1942, 1, 1, 12, 38, 9, 729, DateTimeKind.Utc).AddTicks(5151), "Adam.Luckii@yandex.ua", new DateTime(2020, 2, 19, 21, 41, 57, 445, DateTimeKind.Local).AddTicks(2199), "Олександра", "доц.", "3262893939", "Бухгалтер", 2556.17m, "Operations" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 2, 21, 10, 51, 26, 882, DateTimeKind.Local).AddTicks(1519), "Винників майдан, 7, Лисичанськ, Білорусь", new DateTime(1977, 8, 19, 1, 16, 48, 801, DateTimeKind.Utc).AddTicks(9061), "Dolyana.Lugovii21@ex.ua", "Ореста", "Цушко", "канд. психол. наук", "8554458365", "Директор", 18298.56m, "Western Sahara" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 12, 16, 13, 18, 28, 831, DateTimeKind.Local).AddTicks(193), "Нижанківського майдан, 76, Східний Злат, Фінляндія", new DateTime(1934, 1, 7, 23, 12, 38, 428, DateTimeKind.Utc).AddTicks(649), "Maiya.Maistrenko20@ex.ua", new DateTime(2021, 1, 28, 8, 30, 41, 817, DateTimeKind.Local).AddTicks(8452), "Валерія", "Петик", "канд. і. наук", "2588980893", "Прибиральник", 12974.68m, "intranet" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 12, 28, 21, 33, 2, 673, DateTimeKind.Local).AddTicks(9521), "площа Зелена, 3, Північний Любомир, Гондурас", new DateTime(1998, 10, 16, 19, 4, 28, 657, DateTimeKind.Utc).AddTicks(7888), "Lukyan.Grechko@ukr.net", new DateTime(2023, 8, 31, 19, 26, 13, 725, DateTimeKind.Local).AddTicks(5043), "Ростислава", "Лазірко", "канд. юрид. наук", "1973274879", "Секретар", 6799.31m, "Triple-buffered" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 30, 12, 23, 14, 552, DateTimeKind.Local).AddTicks(7577), "площа Вузька, 371, Західний Аскольд, Палау", new DateTime(1989, 7, 7, 16, 7, 53, 166, DateTimeKind.Utc).AddTicks(2656), "Kharitina_Gorbach@i.ua", "Григорій", "Яворівська", "докт. психол. наук", "0109522044", "Бухгалтер", 17064.61m, "e-enable" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 11, 20, 41, 25, 803, DateTimeKind.Local).AddTicks(2613), "вул. Винників, 19, Миколаїв, Австралія", new DateTime(1979, 3, 26, 22, 20, 51, 47, DateTimeKind.Utc).AddTicks(8115), "Semibor_Grechko@ukr.net", "Азарій", "Прядун", "канд. юрид. наук", "1746514745", 7947.51m, "firewall" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 28, 8, 31, 27, 572, DateTimeKind.Local).AddTicks(5730), "пров. Староміська, 5, Південний Денис, Бутан", new DateTime(1980, 2, 16, 9, 13, 18, 606, DateTimeKind.Utc).AddTicks(2992), "Mechislav23@yandex.ua", new DateTime(2020, 4, 4, 18, 58, 49, 607, DateTimeKind.Local).AddTicks(1405), "Всевлад", "Майборода", "докт. психол. наук", "2359668668", 15883.05m, "Clothing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 8, 1, 5, 58, 98, DateTimeKind.Local).AddTicks(867), "Коліївщини майдан, 77, Східний Кузьма, Багамські Острови", new DateTime(1963, 2, 17, 16, 40, 3, 415, DateTimeKind.Utc).AddTicks(5263), "Danilo.Balicka@ex.ua", null, "Ірма", "Вітряк", "канд. філос. наук", "4577017193", "Програміст", 13951.36m, "multi-byte" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 19, 56, 55, DateTimeKind.Local).AddTicks(1606), "вул. Нижанківського, 44, Південний Зиновій, Китай", new DateTime(1984, 7, 18, 16, 59, 7, 163, DateTimeKind.Utc).AddTicks(7044), "Ada49@gmail.com", new DateTime(2021, 11, 4, 11, 58, 25, 395, DateTimeKind.Local).AddTicks(772), "Адам", "Опенько", "канд. політ. наук", "5457708853", "Бухгалтер", 15025.98m, "Guyana Dollar" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 12, 10, 16, 59, 24, 754, DateTimeKind.Local).AddTicks(3879), "вулиця Коліївщини, 067, Керч, Венесуела", new DateTime(1961, 8, 3, 1, 47, 9, 521, DateTimeKind.Utc).AddTicks(4406), "Radmila.Fedorishina@e-mail.ua", new DateTime(2020, 12, 6, 8, 56, 25, 173, DateTimeKind.Local).AddTicks(2967), "Віола", "Бабух", "канд. і. наук", "1938971520", "Директор", 19947.57m, "Roads" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 3, 11, 9, 46, 18, 574, DateTimeKind.Local).AddTicks(2267), "Рудного майдан, 447, Південний Білослав, Іспанія", new DateTime(1993, 12, 13, 14, 29, 5, 847, DateTimeKind.Utc).AddTicks(3448), "Slavuta_Galayenko@e-mail.ua", "Аполлонія", "Вітряк", "канд. юрид. наук", "9160135292", "Прибиральник", 13442.36m, "Pre-emptive" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 25, 14, 39, 6, 576, DateTimeKind.Local).AddTicks(8129), "проспект Коліївщини, 28, Південний Владислав, Південна Корея", new DateTime(1965, 3, 8, 14, 24, 0, 682, DateTimeKind.Utc).AddTicks(8356), "Orisya43@e-mail.ua", null, "Злат", "Сосюра", "канд. психол. наук", "2623574233", "Секретар", 10556.90m, "Handcrafted" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 22, 12, 56, 6, 291, DateTimeKind.Local).AddTicks(6911), "Коліївщини майдан, 80, Єнакієве, Нігерія", new DateTime(1980, 12, 29, 21, 24, 44, 574, DateTimeKind.Utc).AddTicks(1545), "Natan_Likhno@ex.ua", null, "Братомил", "Лазірко", "докт. юрид. наук", "3735993338", "Прибиральник", 18941.79m, "haptic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 7, 11, 7, 4, 58, 760, DateTimeKind.Local).AddTicks(6366), "провулок Староміська, 2, Красний Луч, Індія", new DateTime(1946, 12, 5, 12, 16, 58, 604, DateTimeKind.Utc).AddTicks(1180), "Andrii_Gaiovii73@gmail.com", null, "Олесь", "Ємець", "проф.", "3330133336", "Директор", 10636.49m, "invoice" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 2, 14, 37, 20, 388, DateTimeKind.Local).AddTicks(1065), "пр. Ліста, 5, Північний Мирослав, Білорусь", new DateTime(1947, 5, 28, 0, 40, 25, 821, DateTimeKind.Utc).AddTicks(8645), "Zborislav83@yandex.ua", new DateTime(2021, 8, 11, 19, 31, 59, 282, DateTimeKind.Local).AddTicks(634), "Майя", "Петрів", "канд. філол. наук", "8157739903", "Прибиральник", 13391.22m, "budgetary management" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 11, 27, 11, 15, 25, 872, DateTimeKind.Local).AddTicks(5908), "пл. Стрийська, 7, Західний Юліан, Коста-Рика", new DateTime(1952, 8, 4, 21, 15, 14, 569, DateTimeKind.Utc).AddTicks(1993), "Olena_Balabukh53@gmail.com", new DateTime(2020, 9, 9, 14, 35, 20, 477, DateTimeKind.Local).AddTicks(1829), "Світлана", "Ромочко", "докт. політ. наук", "8626716556", "Секретар", 3377.32m, "Cambridgeshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 1, 5, 11, 46, 34, 2, DateTimeKind.Local).AddTicks(7219), "Городоцька майдан, 14, Маріуполь, Чехія", new DateTime(1944, 4, 11, 4, 6, 31, 43, DateTimeKind.Utc).AddTicks(9946), "Apollinariya_Fedorishina41@gmail.com", null, "Олександр", "Яворівська", "проф.", "1600329341", "Директор", 15650.35m, "Savings Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 30, 23, 8, 34, 536, DateTimeKind.Local).AddTicks(6399), "вул. Зелена, 9, Східний Братомил, Гвінея-Бісау", new DateTime(2000, 3, 17, 8, 15, 8, 606, DateTimeKind.Utc).AddTicks(6756), "Krentta.Nogachevskii18@i.ua", new DateTime(2020, 3, 28, 0, 6, 3, 398, DateTimeKind.Local).AddTicks(3536), "Антонида", "Бабух", "докт. юрид. наук", "8264322453", "Секретар", 16522.39m, "Mission" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 11, 40, 911, DateTimeKind.Local).AddTicks(3060), "площа Зелена, 312, Східний Ратимир, Буркіна-Фасо", new DateTime(1983, 6, 3, 14, 38, 19, 48, DateTimeKind.Utc).AddTicks(4477), "Vseslava_Skoropadska@e-mail.ua", new DateTime(2023, 8, 14, 8, 54, 48, 289, DateTimeKind.Local).AddTicks(7953), "Макар", "Андрухович", "докт. філол. наук", "1040793245", 3353.30m, "ivory" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 10, 21, 38, 35, 102, DateTimeKind.Local).AddTicks(1129), "Нижанківського майдан, 594, Лисичанськ, Саудівська Аравія", new DateTime(1938, 6, 25, 5, 58, 12, 637, DateTimeKind.Utc).AddTicks(3035), "Virginiya.Latanskii@ex.ua", "Зорина", "Луцьків", "докт. техн. наук", "6023105211", "Директор", 11271.65m, "Bedfordshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 30, 10, 21, 3, 382, DateTimeKind.Local).AddTicks(5542), "пров. Городоцька, 8, Східний Арсен, Данія", new DateTime(1965, 7, 11, 18, 5, 22, 547, DateTimeKind.Utc).AddTicks(1075), "Anastasiya_Sidlyak46@gmail.com", "Адам", "Коломієць", "докт. філос. наук", "4508155496", 8568.77m, "seamless" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 1, 4, 24, 38, 974, DateTimeKind.Local).AddTicks(4266), "пл. Винників, 7, Біла Церква, Гвінея", new DateTime(1934, 10, 14, 10, 24, 21, 802, DateTimeKind.Utc).AddTicks(9026), "Ratimir93@e-mail.ua", new DateTime(2021, 7, 19, 23, 11, 31, 810, DateTimeKind.Local).AddTicks(2266), "Азарій", "Барановський", "докт. політ. наук", "2930206692", 7997.86m, "Licensed Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 30, 16, 22, 11, 498, DateTimeKind.Local).AddTicks(1307), "провулок Вічева, 955, Кременчук, Нідерланди", new DateTime(1955, 6, 20, 18, 36, 45, 660, DateTimeKind.Utc).AddTicks(4710), "Potishana11@e-mail.ua", new DateTime(2021, 8, 15, 12, 38, 15, 118, DateTimeKind.Local).AddTicks(9347), "Захарій", "Ланова", "канд. філол. наук", "4005804343", "Секретар", 15593.14m, "frictionless" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 11, 3, 5, 21, 35, 900, DateTimeKind.Local).AddTicks(7561), "вулиця Стрийська, 562, Полтава, Екваторіальна Гвінея", new DateTime(2005, 3, 28, 1, 32, 6, 486, DateTimeKind.Utc).AddTicks(6158), "Anna.Pritula36@ukr.net", new DateTime(2021, 6, 19, 2, 14, 8, 584, DateTimeKind.Local).AddTicks(3109), "Неля", "Петик", "докт. юрид. наук", "0623374109", "Директор", 2058.66m, "synthesizing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 9, 11, 10, 46, 7, 684, DateTimeKind.Local).AddTicks(416), "провулок Городоцька, 641, Шостка, Колумбія", new DateTime(1954, 9, 13, 9, 53, 51, 365, DateTimeKind.Utc).AddTicks(3079), "Zabava.Sirko22@ex.ua", null, "Родослав", "Марієвський", "канд. і. наук", "1412735673", "Програміст", 7938.16m, "Brand" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "PhoneNumber", "Position", "Salary" },
                values: new object[] { new DateTime(2022, 1, 26, 2, 13, 44, 245, DateTimeKind.Local).AddTicks(244), "Староміська майдан, 18, Вінниця, Монако", new DateTime(1949, 2, 25, 4, 52, 44, 920, DateTimeKind.Utc).AddTicks(3232), "Miloslava_Likovich@ukr.net", "Тарас", "Спотикач", "4684392776", "Прибиральник", 1055.04m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 4, 20, 4, 34, 26, 502, DateTimeKind.Local).AddTicks(1954), "пров. Коліївщини, 9, Північний Олесь, Сент-Люсія", new DateTime(1933, 4, 24, 20, 55, 12, 469, DateTimeKind.Utc).AddTicks(9437), "Zorina_Tryasun@yandex.ua", "Сніжан", "Горбач", "докт. філол. наук", "1570465316", "Програміст", 14377.96m, "Ergonomic Rubber Cheese" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 11, 10, 4, 59, 38, 477, DateTimeKind.Local).AddTicks(9614), "пл. Стрийська, 48, Макіївка, Ботсвана", new DateTime(1998, 12, 30, 8, 11, 55, 683, DateTimeKind.Utc).AddTicks(6061), "Zoryan62@gmail.com", "Немира", "Зінкевич", "докт. філос. наук", "8992184468", "Директор", 14652.02m, "Product" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 6, 19, 16, 38, 863, DateTimeKind.Local).AddTicks(9686), "Нижанківського майдан, 21, Горлівка, Швеція", new DateTime(1986, 1, 5, 22, 8, 51, 414, DateTimeKind.Utc).AddTicks(4487), "Lyubomila_Shestak8@i.ua", "Степан", "Сідлецька", "докт. психол. наук", "4357021830", "Програміст", 2385.16m, "Russian Ruble" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 10, 23, 27, 25, 996, DateTimeKind.Local).AddTicks(969), "площа Ліста, 765, Південний Будимир, Велика Британія", new DateTime(1967, 12, 28, 4, 14, 40, 725, DateTimeKind.Utc).AddTicks(4506), "Vlada.Maiboroda97@gmail.com", new DateTime(2022, 2, 21, 8, 29, 33, 545, DateTimeKind.Local).AddTicks(8989), "Арсеній", "Магера", "докт. філос. наук", "6669458098", "Бухгалтер", 13769.79m, "COM" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 16, 21, 37, 27, 319, DateTimeKind.Local).AddTicks(3720), "площа Молодіжна, 002, Чернігів, Малаві", new DateTime(1974, 2, 2, 4, 55, 54, 848, DateTimeKind.Utc).AddTicks(8591), "Agata_Glinska57@meta.ua", new DateTime(2021, 1, 15, 18, 17, 25, 407, DateTimeKind.Local).AddTicks(179), "Макар", "Сосюра", "докт. філос. наук", "4512051794", "Бухгалтер", 17523.17m, "disintermediate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 16, 4, 51, 16, 993, DateTimeKind.Local).AddTicks(5121), "Вічева майдан, 1, Західний Марко, Бельгія", new DateTime(1961, 12, 26, 17, 31, 30, 25, DateTimeKind.Utc).AddTicks(4027), "Artemiya_Lakhman77@i.ua", null, "Дарислава", "Червоній", "докт. техн. наук", "4320864534", 19978.81m, "Generic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 9, 21, 20, 42, 618, DateTimeKind.Local).AddTicks(7079), "пр. Нижанківського, 88, Біла Церква, Шрі-Ланка", new DateTime(1929, 10, 17, 8, 26, 27, 246, DateTimeKind.Utc).AddTicks(3089), "Yaroslav.Palii0@meta.ua", new DateTime(2020, 3, 18, 22, 39, 16, 889, DateTimeKind.Local).AddTicks(7573), "Зінаїда", "Галаціон", "канд. філол. наук", "4584612802", "Директор", 11042.64m, "invoice" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 16, 1, 47, 43, 537, DateTimeKind.Local).AddTicks(5912), "Нижанківського майдан, 16, Хмельницький, Бангладеш", new DateTime(2003, 3, 9, 16, 39, 42, 879, DateTimeKind.Utc).AddTicks(6272), "Valerii.Balakun@ex.ua", new DateTime(2022, 6, 30, 19, 34, 53, 196, DateTimeKind.Local).AddTicks(6917), "Микола", "Гладківська", "канд. і. наук", "8851219848", "Прибиральник", 8836.58m, "Generic Metal Sausages" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 12, 30, 2, 7, 36, 481, DateTimeKind.Local).AddTicks(1704), "вул. Брюховичів, 57, Північний Андрій, Ізраїль", new DateTime(1933, 4, 1, 6, 56, 26, 377, DateTimeKind.Utc).AddTicks(4680), "Levko.Polishuk@gmail.com", new DateTime(2019, 11, 19, 10, 51, 16, 838, DateTimeKind.Local).AddTicks(5282), "Корнилій", "Ющук", "канд. і. наук", "4501689291", "Програміст", 12364.96m, "incentivize" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 1, 28, 13, 33, 54, 77, DateTimeKind.Local).AddTicks(9195), "пр. Винників, 6, Запоріжжя, Ефіопія", new DateTime(1945, 4, 16, 6, 33, 20, 671, DateTimeKind.Utc).AddTicks(530), "Vlada57@gmail.com", new DateTime(2021, 8, 6, 3, 54, 22, 845, DateTimeKind.Local).AddTicks(8660), "Братомил", "Стоян", "докт. філол. наук", "9245127591", "Секретар", 17097.06m, "Director" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 5, 28, 3, 46, 51, 906, DateTimeKind.Local).AddTicks(674), "Стрийська майдан, 72, Південний Мирослав, Україна", new DateTime(1946, 1, 9, 20, 46, 25, 660, DateTimeKind.Utc).AddTicks(4198), "Viktor_Stigailo56@yandex.ua", new DateTime(2020, 1, 11, 22, 3, 44, 899, DateTimeKind.Local).AddTicks(6427), "Орислава", "Пендик", "8274723471", 19639.73m, "Mongolia" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 5, 26, 3, 52, 12, 116, DateTimeKind.Local).AddTicks(8882), "провулок Нижанківського, 2, Східний Ярополк, Федеративні Штати Мікронезії", new DateTime(1994, 3, 4, 8, 24, 9, 768, DateTimeKind.Utc).AddTicks(4475), "Innesa39@yandex.ua", new DateTime(2022, 1, 12, 20, 48, 24, 844, DateTimeKind.Local).AddTicks(4517), "Мечислав", "Василин", "докт. техн. наук", "6181254225", "Прибиральник", 11210.33m, "Seychelles" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 1, 10, 40, 50, 341, DateTimeKind.Local).AddTicks(1116), "Брюховичів майдан, 76, Хмельницький, Ямайка", new DateTime(1931, 9, 2, 0, 54, 53, 629, DateTimeKind.Utc).AddTicks(4511), "Omelyan.Gordiichuk73@e-mail.ua", null, "Ада", "Червоній", "докт. філол. наук", "9022787066", "Бухгалтер", 18011.21m, "distributed" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 16, 20, 34, 29, 719, DateTimeKind.Local).AddTicks(2137), "Вічева майдан, 33, Східний Зорян, Нідерланди", new DateTime(1989, 5, 7, 2, 37, 54, 489, DateTimeKind.Utc).AddTicks(5179), "Vseslav_Sherbak28@ukr.net", new DateTime(2019, 10, 26, 14, 27, 47, 74, DateTimeKind.Local).AddTicks(4857), "Дарина", "Линдик", "0967021383", 5139.22m, "lime" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 24, 7, 52, 22, 408, DateTimeKind.Local).AddTicks(6907), "площа Нижанківського, 602, Північний Родіон, Бельгія", new DateTime(1979, 1, 28, 19, 20, 53, 363, DateTimeKind.Utc).AddTicks(49), "Alevtin.Latan77@e-mail.ua", null, "Милодара", "Ліхно", "канд. і. наук", "3895528843", 5840.97m, "Rustic Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 1, 16, 23, 53, 36, DateTimeKind.Local).AddTicks(9787), "Вічева майдан, 05, Вінниця, Сан-Марино", new DateTime(1963, 12, 16, 17, 50, 24, 615, DateTimeKind.Utc).AddTicks(6740), "Boris_Luchenko@i.ua", "Радміла", "Сучак", "докт. техн. наук", "0151258116", "Бухгалтер", 5359.70m, "Checking Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 22, 7, 46, 10, 14, DateTimeKind.Local).AddTicks(2788), "площа Брюховичів, 02, Північний Василь, Бурунді", new DateTime(1993, 11, 23, 4, 5, 36, 823, DateTimeKind.Utc).AddTicks(6403), "Solomiya_Lyutii61@gmail.com", new DateTime(2024, 1, 30, 20, 9, 56, 126, DateTimeKind.Local).AddTicks(6911), "Адріана", "Вередун", "докт. філол. наук", "3760171763", 18346.08m, "withdrawal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 27, 18, 22, 27, 226, DateTimeKind.Local).AddTicks(9858), "Ліста майдан, 712, Макіївка, Азербайджан", new DateTime(1940, 5, 16, 12, 59, 7, 808, DateTimeKind.Utc).AddTicks(649), "Mariya40@ex.ua", new DateTime(2022, 4, 17, 9, 49, 21, 825, DateTimeKind.Local).AddTicks(65), "Корнилій", "Бердник", "канд. техн. наук", "4094412928", "Директор", 16163.06m, "Programmable" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 8, 14, 0, 29, 20, 140, DateTimeKind.Local).AddTicks(8066), "Стрийська майдан, 330, Івано-Франківськ, Камерун", new DateTime(1949, 6, 3, 11, 44, 31, 572, DateTimeKind.Utc).AddTicks(2894), "Oleksandr.Vereshuk@e-mail.ua", null, "Віталій", "Сосюра", "канд. техн. наук", "1134997967", "Директор", 3007.89m, "Home Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 7, 1, 3, 30, 833, DateTimeKind.Local).AddTicks(9993), "Рудного майдан, 47, Кривий Ріг, Бельгія", new DateTime(1949, 7, 14, 23, 20, 53, 604, DateTimeKind.Utc).AddTicks(4054), "Dobromisl44@i.ua", "Добринка", "Зленко", "докт. пед. наук", "8010896031", "Секретар", 18260.43m, "South Carolina" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 8, 23, 9, 46, 38, 913, DateTimeKind.Local).AddTicks(4619), "Зелена майдан, 105, Мелітополь, Малайзія", new DateTime(1976, 6, 14, 18, 2, 36, 363, DateTimeKind.Utc).AddTicks(1954), "Rodoslav_Sayenko40@ex.ua", new DateTime(2022, 2, 19, 23, 48, 58, 334, DateTimeKind.Local).AddTicks(9932), "Яромил", "Лученко", "канд. політ. наук", "2728246686", "Програміст", 19125.82m, "RSS" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 8, 0, 2, 20, 451, DateTimeKind.Local).AddTicks(692), "пл. Стрийська, 1, Західний Станіслав, Лесото", new DateTime(1927, 11, 17, 4, 10, 19, 631, DateTimeKind.Utc).AddTicks(1980), "Dobromisl_Yushik@ex.ua", null, "Корній", "Шестак", "канд. філос. наук", "6226369683", "Бухгалтер", 12505.17m, "Tools, Industrial & Clothing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 16, 4, 57, 14, 789, DateTimeKind.Local).AddTicks(77), "Коліївщини майдан, 610, Бердянськ, Соломонові Острови", new DateTime(2004, 6, 26, 1, 14, 23, 626, DateTimeKind.Utc).AddTicks(4987), "Olena_Berdnik69@meta.ua", "Юхимія", "Васильківська", "докт. політ. наук", "7965982577", 17136.71m, "navigating" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 27, 11, 10, 6, 602, DateTimeKind.Local).AddTicks(8575), "Вічева майдан, 41, Західний Владислав, Північна Корея", new DateTime(1950, 1, 23, 20, 34, 39, 187, DateTimeKind.Utc).AddTicks(3670), "Polyana72@i.ua", null, "Вілена", "Тиндарей", "канд. техн. наук", "1761542859", "Бухгалтер", 5500.89m, "New Zealand" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 9, 25, 4, 16, 53, 295, DateTimeKind.Local).AddTicks(6030), "пров. Ліста, 68, Західний Божен, Суринам", new DateTime(1948, 5, 9, 0, 19, 34, 571, DateTimeKind.Utc).AddTicks(4420), "Dmitro21@i.ua", "Устина", "Демків", "доц.", "4077373248", 8729.72m, "Usability" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 28, 1, 33, 6, 232, DateTimeKind.Local).AddTicks(8106), "площа Молодіжна, 510, Південний Григорій, Естонія", new DateTime(1996, 6, 30, 16, 21, 37, 446, DateTimeKind.Utc).AddTicks(5636), "Aelina13@e-mail.ua", new DateTime(2020, 12, 18, 5, 16, 26, 385, DateTimeKind.Local).AddTicks(7097), "Віталіна", "Горовий", "докт. філол. наук", "0511201310", "Секретар", 19948.91m, "web-readiness" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 9, 15, 23, 7, 6, 389, DateTimeKind.Local).AddTicks(467), "вул. Зелена, 872, Північний Тур, Мексика", new DateTime(1935, 5, 15, 15, 45, 0, 303, DateTimeKind.Utc).AddTicks(6856), "Kvitoslava52@gmail.com", null, "Ярополк", "Стоян", "докт. філос. наук", "1034464148", "Секретар", 11988.36m, "FTP" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 31, 13, 24, 26, 475, DateTimeKind.Local).AddTicks(752), "Рудного майдан, 966, Східний Звенислав, Таджикистан", new DateTime(1949, 11, 12, 7, 48, 31, 419, DateTimeKind.Utc).AddTicks(8659), "Izyaslav_Tretyak@ex.ua", "Олексій", "Глинський", "канд. пед. наук", "1984220677", "Секретар", 3327.89m, "Associate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 9, 22, 9, 8, 8, 910, DateTimeKind.Local).AddTicks(3287), "провулок Вузька, 96, Чернівці, Австрія", new DateTime(1937, 3, 10, 16, 20, 51, 549, DateTimeKind.Utc).AddTicks(7923), "Radimir.Lakhman@ex.ua", new DateTime(2021, 7, 31, 18, 50, 14, 627, DateTimeKind.Local).AddTicks(8684), "Ромена", "Магера", "доц.", "9222979287", "Прибиральник", 19027.35m, "Home Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 3, 7, 35, 8, 256, DateTimeKind.Local).AddTicks(2086), "пров. Винників, 60, Луцьк, Судан", new DateTime(1932, 10, 6, 4, 3, 10, 556, DateTimeKind.Utc).AddTicks(2379), "Stozhar5@e-mail.ua", null, "Іван", "Цушко", "доц.", "5695997416", "Програміст", 7088.76m, "Marketing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 14, 4, 19, 37, 720, DateTimeKind.Local).AddTicks(5818), "Староміська майдан, 4, Донецьк, Коморські Острови", new DateTime(1983, 10, 17, 9, 4, 49, 950, DateTimeKind.Utc).AddTicks(4414), "Rostislav.Vitrebenko30@meta.ua", null, "Павло", "Зленко", "проф.", "2905750362", "Секретар", 10327.55m, "connecting" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 6, 3, 48, 2, 438, DateTimeKind.Local).AddTicks(4150), "Стрийська майдан, 47, Дніпропетровськ, Ірак", new DateTime(1994, 4, 5, 23, 20, 35, 157, DateTimeKind.Utc).AddTicks(8223), "Larisa.Svidrigailo@i.ua", new DateTime(2022, 12, 15, 21, 56, 14, 571, DateTimeKind.Local).AddTicks(7233), "Звенимир", "Линдик", "докт. філол. наук", "0709391737", "Директор", 14272.18m, "Junction" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 2, 1, 7, 11, 535, DateTimeKind.Local).AddTicks(7218), "Рудного майдан, 510, Південний Яровид, Бенін", new DateTime(1981, 12, 10, 15, 55, 52, 8, DateTimeKind.Utc).AddTicks(6339), "Okhrim_Kompaniyec@gmail.com", new DateTime(2019, 8, 3, 10, 42, 39, 374, DateTimeKind.Local).AddTicks(2859), "Добромила", "Демків", "канд. філол. наук", "1879698258", "Програміст", 15270.14m, "bandwidth-monitored" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 3, 10, 14, 34, 33, 763, DateTimeKind.Local).AddTicks(784), "вул. Зелена, 88, Євпаторія, Кувейт", new DateTime(1949, 8, 8, 21, 8, 54, 647, DateTimeKind.Utc).AddTicks(3162), "Bratislav29@e-mail.ua", new DateTime(2020, 5, 7, 7, 2, 9, 755, DateTimeKind.Local).AddTicks(1397), "Анастасія", "Сідляк", "канд. пед. наук", "6747013127", "Прибиральник", 11730.73m, "Moroccan Dirham" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 17, 8, 28, 48, 903, DateTimeKind.Local).AddTicks(1564), "провулок Винників, 2, Біла Церква, Італія", new DateTime(1940, 2, 16, 17, 15, 9, 74, DateTimeKind.Utc).AddTicks(989), "Shek.Silecka89@i.ua", new DateTime(2022, 3, 31, 0, 59, 16, 844, DateTimeKind.Local).AddTicks(1509), "Пилип", "Гайдук", "докт. психол. наук", "5821195972", "Прибиральник", 7815.75m, "Sleek Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 9, 5, 28, 7, 135, DateTimeKind.Local).AddTicks(4529), "Ліста майдан, 98, Севастополь, Буркіна-Фасо", new DateTime(2005, 1, 16, 2, 54, 30, 743, DateTimeKind.Utc).AddTicks(4376), "Syuzana_Palii@yandex.ua", new DateTime(2020, 4, 16, 22, 13, 33, 184, DateTimeKind.Local).AddTicks(6088), "Добромир", "Ліхно", "канд. філол. наук", "7353919763", "Бухгалтер", 14035.78m, "compressing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 1, 0, 53, 34, 825, DateTimeKind.Local).AddTicks(870), "пр. Вузька, 542, Західний Гнат, Папуа-Нова Гвінея", new DateTime(1993, 9, 7, 5, 55, 32, 428, DateTimeKind.Utc).AddTicks(7557), "Viola_Miklukho0@ex.ua", new DateTime(2023, 9, 25, 14, 1, 57, 102, DateTimeKind.Local).AddTicks(7482), "Поліна", "Міняйло", "докт. техн. наук", "1193472722", "Директор", 3989.73m, "Loop" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 12, 7, 14, 58, 52, 144, DateTimeKind.Local).AddTicks(5661), "провулок Винників, 077, Алчевськ, Сирія", new DateTime(1984, 1, 23, 12, 32, 51, 854, DateTimeKind.Utc).AddTicks(1573), "Vsevolod.Yushik@i.ua", "Богдан", "Данилишина", "канд. пед. наук", "7900624477", "Програміст", 8943.80m, "payment" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 9, 17, 23, 16, 43, 671, DateTimeKind.Local).AddTicks(443), "проспект Городоцька, 90, Ізмаїл, Сент-Вінсент і Гренадини", new DateTime(1957, 7, 17, 20, 53, 9, 598, DateTimeKind.Utc).AddTicks(239), "Anton_Potebenko@ex.ua", new DateTime(2019, 5, 21, 5, 0, 10, 900, DateTimeKind.Local).AddTicks(864), "Хорив", "Негода", "канд. пед. наук", "6916558524", "Секретар", 3029.09m, "Unbranded Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 8, 4, 18, 12, 11, 918, DateTimeKind.Local).AddTicks(5526), "провулок Рудного, 3, Східний Ян, Саудівська Аравія", new DateTime(1954, 1, 20, 1, 51, 54, 124, DateTimeKind.Utc).AddTicks(6939), "Roman_Burmilo@yandex.ua", new DateTime(2021, 8, 21, 12, 3, 46, 609, DateTimeKind.Local).AddTicks(8124), "Ромена", "Борецька", "докт. юрид. наук", "7978267888", "Директор", 1130.43m, "Metal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 12, 24, 3, 23, 57, 292, DateTimeKind.Local).AddTicks(5256), "Городоцька майдан, 729, Алчевськ, Чилі", new DateTime(1978, 10, 19, 12, 45, 9, 41, DateTimeKind.Utc).AddTicks(6720), "Zakharii49@e-mail.ua", null, "Анастас", "Гриневський", "канд. психол. наук", "4053255093", "Секретар", 7030.63m, "Electronics, Industrial & Movies" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 12, 4, 23, 57, 586, DateTimeKind.Local).AddTicks(4615), "Молодіжна майдан, 679, Північний Горислав, Антигуа і Барбуда", new DateTime(1987, 12, 18, 20, 0, 56, 255, DateTimeKind.Utc).AddTicks(8685), "Gennadii_Pendik@ukr.net", new DateTime(2021, 6, 22, 23, 11, 10, 745, DateTimeKind.Local).AddTicks(1692), "Нестор", "Стигайло", "докт. і. наук", "2278140342", 11494.54m, "Corporate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 23, 23, 40, 10, 143, DateTimeKind.Local).AddTicks(4862), "Вічева майдан, 11, Північний В’ячеслав, Південно-Африканська Республіка", new DateTime(1989, 8, 17, 13, 10, 36, 550, DateTimeKind.Utc).AddTicks(1669), "Mechislav.Parashuk54@yandex.ua", new DateTime(2020, 1, 6, 21, 18, 25, 164, DateTimeKind.Local).AddTicks(4413), "Гарнослав", "Сірко", "докт. філол. наук", "1543429112", "Директор", 18679.85m, "bandwidth" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 26, 5, 46, 42, 318, DateTimeKind.Local).AddTicks(229), "Стрийська майдан, 138, Нікополь, Руанда", new DateTime(1947, 11, 3, 15, 45, 2, 566, DateTimeKind.Utc).AddTicks(9992), "Mechislava_Babukh@e-mail.ua", null, "Квітослава", "Дзюб’як", "докт. філол. наук", "3066228170", 5510.57m, "Yemen" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 18, 13, 31, 9, 458, DateTimeKind.Local).AddTicks(5812), "площа Брюховичів, 05, Горлівка, Хорватія", new DateTime(1949, 1, 14, 10, 50, 15, 125, DateTimeKind.Utc).AddTicks(339), "Antonina_Yanyuk64@gmail.com", new DateTime(2023, 6, 29, 5, 26, 50, 525, DateTimeKind.Local).AddTicks(6612), "Добринка", "Линдик", "докт. юрид. наук", "3136091096", "Прибиральник", 2926.71m, "Divide" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 10, 17, 57, 24, 918, DateTimeKind.Local).AddTicks(2440), "Зелена майдан, 743, Північний Пантелеймон, Беліз", new DateTime(1959, 4, 17, 22, 12, 30, 493, DateTimeKind.Utc).AddTicks(6857), "Maksim_Kornyiichuk@yandex.ua", null, "Архип", "Демків", "канд. пед. наук", "6084466638", 10456.56m, "Licensed Steel Table" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 15, 23, 6, 9, 432, DateTimeKind.Local).AddTicks(3049), "провулок Рудного, 7, Південний Братимир, Лесото", new DateTime(1942, 12, 27, 2, 54, 9, 575, DateTimeKind.Utc).AddTicks(588), "Stanislav_Maiboroda0@meta.ua", new DateTime(2021, 12, 13, 8, 9, 59, 699, DateTimeKind.Local).AddTicks(885), "Жозефіна", "Горова", "докт. і. наук", "9592485155", 19061.88m, "Pine" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 2, 13, 592, DateTimeKind.Local).AddTicks(9055), "вул. Молодіжна, 53, Північний Родослав, Хорватія", new DateTime(1974, 9, 5, 11, 10, 31, 510, DateTimeKind.Utc).AddTicks(52), "Fedora99@ex.ua", new DateTime(2021, 12, 20, 14, 37, 16, 131, DateTimeKind.Local).AddTicks(504), "Петро", "Свидригайло", "докт. політ. наук", "7167702980", "Бухгалтер", 18304.84m, "Bhutanese Ngultrum" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 6, 0, 452, DateTimeKind.Local).AddTicks(9421), "пл. Винників, 682, Північний Мстислав, Ангола", new DateTime(1955, 1, 30, 6, 50, 44, 646, DateTimeKind.Utc).AddTicks(13), "Valentin.Shupik35@yandex.ua", new DateTime(2023, 2, 10, 17, 10, 18, 687, DateTimeKind.Local).AddTicks(5984), "Всевлад", "Янюк", "канд. і. наук", "4870112733", "Бухгалтер", 17296.44m, "Netherlands Antilles" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 13, 22, 37, 17, 695, DateTimeKind.Local).AddTicks(5422), "Брюховичів майдан, 6, Ізмаїл, Словенія", new DateTime(1971, 11, 26, 3, 45, 56, 648, DateTimeKind.Utc).AddTicks(9843), "Svyatopolk_Luchenko@e-mail.ua", new DateTime(2020, 7, 4, 19, 46, 33, 997, DateTimeKind.Local).AddTicks(1104), "Ладислав", "Горова", "докт. техн. наук", "9437086805", "Директор", 5781.24m, "incubate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 10, 4, 11, 28, 98, DateTimeKind.Local).AddTicks(4876), "пр. Коліївщини, 909, Краматорськ, Сент-Кітс і Невіс", new DateTime(1998, 5, 8, 21, 40, 25, 937, DateTimeKind.Utc).AddTicks(8861), "Anna.Borovskii99@yandex.ua", new DateTime(2020, 2, 8, 23, 32, 18, 107, DateTimeKind.Local).AddTicks(5138), "Братимир", "Яцьків", "канд. юрид. наук", "6771649794", "Секретар", 5785.39m, "Group" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 5, 6, 37, 4, 569, DateTimeKind.Local).AddTicks(6871), "пров. Староміська, 5, Південний Омелян, Румунія", new DateTime(1994, 6, 8, 15, 18, 2, 195, DateTimeKind.Utc).AddTicks(3626), "Sergii_Golovec0@e-mail.ua", null, "Далеслава", "Свидригайло", "докт. юрид. наук", "4494776632", "Прибиральник", 12414.00m, "indexing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 5, 10, 4, 28, 4, 701, DateTimeKind.Local).AddTicks(2330), "Городоцька майдан, 09, Південний Панас, США", new DateTime(1956, 3, 7, 14, 4, 43, 305, DateTimeKind.Utc).AddTicks(3938), "Lyubomir.Yalovii@ex.ua", "Поляна", "Шкараба", "канд. юрид. наук", "0235765577", "Секретар", 3511.89m, "bandwidth" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 3, 17, 8, 59, 22, 898, DateTimeKind.Local).AddTicks(9386), "Вузька майдан, 540, Єнакієве, Суринам", new DateTime(1961, 8, 15, 22, 26, 4, 651, DateTimeKind.Utc).AddTicks(3150), "Oleksandra_Kornyiichuk@i.ua", null, "Раїса", "Гаман", "докт. і. наук", "5093391414", "Програміст", 6239.14m, "Lebanese Pound" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 9, 30, 3, 22, 19, 269, DateTimeKind.Local).AddTicks(1666), "Коліївщини майдан, 2, Південний Стефаній, Латвія", new DateTime(1986, 9, 9, 11, 43, 31, 64, DateTimeKind.Utc).AddTicks(1020), "Gennadii43@meta.ua", "Слава", "Ялюк", "докт. і. наук", "7521012080", "Прибиральник", 3176.93m, "Berkshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 17, 17, 0, 32, 716, DateTimeKind.Local).AddTicks(7837), "площа Вузька, 8, Західний Славолюб, Бразилія", new DateTime(1983, 9, 19, 23, 26, 42, 489, DateTimeKind.Utc).AddTicks(6089), "Likera_Tryasun13@ex.ua", "Славомир", "Петик", "докт. психол. наук", "6142386918", 2600.57m, "hybrid" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 1, 4, 15, 36, 159, DateTimeKind.Local).AddTicks(3150), "проспект Староміська, 0, Рівне, Люксембург", new DateTime(1979, 2, 8, 14, 28, 49, 652, DateTimeKind.Utc).AddTicks(198), "Slavomir_Rozputnya@gmail.com", new DateTime(2020, 8, 25, 10, 9, 48, 906, DateTimeKind.Local).AddTicks(233), "Віктор", "Шестак", "докт. політ. наук", "9990517371", "Програміст", 9864.13m, "bifurcated" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 15, 3, 3, 3, 439, DateTimeKind.Local).AddTicks(9626), "пл. Стрийська, 456, Одеса, Палау", new DateTime(2004, 10, 10, 11, 25, 10, 247, DateTimeKind.Utc).AddTicks(6804), "Krentta17@yandex.ua", null, "Ярина", "Скиба", "докт. і. наук", "9448772984", 3333.58m, "Personal Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 4, 2, 16, 20, 320, DateTimeKind.Local).AddTicks(7361), "вулиця Брюховичів, 04, Західний Антон, Ірландія", new DateTime(1967, 7, 12, 13, 41, 52, 925, DateTimeKind.Utc).AddTicks(9144), "Orest.Sirko@e-mail.ua", "Божена", "Юрчишин", "канд. і. наук", "5816786773", "Секретар", 11525.05m, "Algeria" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 8, 0, 0, 30, 511, DateTimeKind.Local).AddTicks(868), "Брюховичів майдан, 5, Східний Гаврило, Чилі", new DateTime(1950, 2, 27, 23, 8, 44, 338, DateTimeKind.Utc).AddTicks(965), "Nataliya.Demkiv35@meta.ua", "Назар", "Погиба", "канд. пед. наук", "1910160820", 4798.32m, "Antarctica (the territory South of 60 deg S)" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 28, 13, 47, 12, 973, DateTimeKind.Local).AddTicks(6864), "Молодіжна майдан, 10, Луцьк, Йорданія", new DateTime(1953, 7, 9, 9, 14, 58, 519, DateTimeKind.Utc).AddTicks(82), "Viola.Korovyak54@e-mail.ua", new DateTime(2023, 10, 24, 13, 45, 1, 449, DateTimeKind.Local).AddTicks(5858), "Пелагея", "Гриневецький", "канд. філос. наук", "4999584456", 4809.03m, "backing up" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 5, 21, 24, 28, 349, DateTimeKind.Local).AddTicks(8498), "Рудного майдан, 7, Західний Кузьма, Марокко", new DateTime(1940, 12, 22, 16, 1, 58, 394, DateTimeKind.Utc).AddTicks(3671), "Anastasii.Sherbak@ex.ua", null, "Забава", "Шиндарей", "канд. пед. наук", "5611316187", 12326.73m, "Berkshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 20, 2, 19, 31, 113, DateTimeKind.Local).AddTicks(179), "пр. Стрийська, 77, Херсон, Італія", new DateTime(1955, 12, 12, 21, 14, 32, 148, DateTimeKind.Utc).AddTicks(5670), "Azarii_Butko@ex.ua", new DateTime(2020, 10, 9, 19, 8, 8, 250, DateTimeKind.Local).AddTicks(8895), "Стефаній", "Романів", "проф.", "9258084726", "Директор", 17148.14m, "application" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 16, 20, 20, 34, 558, DateTimeKind.Local).AddTicks(651), "Нижанківського майдан, 41, Східний Ладо, Ізраїль", new DateTime(1990, 9, 8, 22, 55, 56, 339, DateTimeKind.Utc).AddTicks(2914), "Gennadii_Mazun@meta.ua", "Любомир", "Лящук", "канд. і. наук", "0974789996", "Бухгалтер", 7730.27m, "throughput" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 22, 5, 49, 33, 738, DateTimeKind.Local).AddTicks(8895), "пров. Молодіжна, 43, Західний Корній, Туніс", new DateTime(2002, 7, 10, 21, 25, 47, 96, DateTimeKind.Utc).AddTicks(3453), "Oriyana_Miklukho79@ukr.net", new DateTime(2020, 11, 27, 0, 25, 57, 544, DateTimeKind.Local).AddTicks(4720), "Юрій", "Барановська", "канд. техн. наук", "8904055429", "Прибиральник", 17014.80m, "generate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 22, 9, 45, 49, 562, DateTimeKind.Local).AddTicks(6430), "вулиця Вузька, 482, Сімферополь, Китай", new DateTime(1981, 9, 30, 7, 47, 26, 52, DateTimeKind.Utc).AddTicks(1406), "Yarema92@meta.ua", new DateTime(2023, 8, 17, 9, 30, 39, 507, DateTimeKind.Local).AddTicks(5011), "Юхима", "Дурдинець", "докт. філос. наук", "9492809156", "Секретар", 9109.50m, "copying" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 5, 5, 1, 28, 58, 350, DateTimeKind.Local).AddTicks(56), "пр. Винників, 450, Західний Златомир, Сент-Вінсент і Гренадини", new DateTime(1981, 3, 4, 3, 26, 4, 229, DateTimeKind.Utc).AddTicks(9360), "Afanasiya54@ex.ua", null, "Юліан", "Забіла", "канд. філос. наук", "6216648812", "Директор", 5170.91m, "Pakistan Rupee" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 27, 8, 49, 46, 419, DateTimeKind.Local).AddTicks(9619), "вулиця Ліста, 433, Західний Чорнота, Намібія", new DateTime(1970, 1, 29, 13, 51, 42, 472, DateTimeKind.Utc).AddTicks(9719), "Yustina.Petrenko64@e-mail.ua", null, "Геннадій", "Євенко", "канд. політ. наук", "8978963720", "Секретар", 13695.99m, "United States Minor Outlying Islands" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 3, 4, 5, 27, 46, 172, DateTimeKind.Local).AddTicks(1714), "Рудного майдан, 330, Біла Церква, Еритрея", new DateTime(1981, 1, 6, 5, 45, 51, 162, DateTimeKind.Utc).AddTicks(3661), "Pavlina74@yandex.ua", null, "Валерій", "Розпутній", "докт. техн. наук", "9472035326", "Директор", 14530.34m, "leverage" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 4, 11, 6, 4, 44, 166, DateTimeKind.Local).AddTicks(7943), "Молодіжна майдан, 14, Сєвєродонецьк, Зімбабве", new DateTime(1931, 2, 3, 14, 11, 55, 625, DateTimeKind.Utc).AddTicks(3078), "Mstislav5@yandex.ua", new DateTime(2023, 10, 28, 5, 47, 39, 771, DateTimeKind.Local).AddTicks(3093), "Квітослава", "Гордійчук", "докт. і. наук", "1081774429", "Прибиральник", 3151.92m, "Berkshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 18, 7, 56, 18, 310, DateTimeKind.Local).AddTicks(3194), "провулок Стрийська, 23, Кременчук, Бутан", new DateTime(1995, 12, 10, 3, 13, 0, 315, DateTimeKind.Utc).AddTicks(5916), "Vseslava_Likovich35@ukr.net", new DateTime(2023, 7, 24, 14, 8, 45, 765, DateTimeKind.Local).AddTicks(4647), "Аврелія", "Шестак", "канд. юрид. наук", "5286465056", "Прибиральник", 6948.51m, "Movies" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 11, 17, 12, 0, 34, 112, DateTimeKind.Local).AddTicks(1312), "пл. Рудного, 5, Східний Радим, Македонія", new DateTime(1968, 3, 20, 17, 31, 21, 897, DateTimeKind.Utc).AddTicks(4991), "Dobromira.Potocka73@ukr.net", new DateTime(2022, 7, 22, 1, 26, 3, 417, DateTimeKind.Local).AddTicks(2276), "Софія", "Опенько", "докт. психол. наук", "4032782974", "Директор", 14826.10m, "violet" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 25, 21, 11, 11, 381, DateTimeKind.Local).AddTicks(9056), "провулок Молодіжна, 540, Західний Володислав, Антигуа і Барбуда", new DateTime(1937, 7, 7, 19, 27, 53, 235, DateTimeKind.Utc).AddTicks(1290), "Matvii_Openko43@gmail.com", "Синьоок", "Пономарів", "канд. політ. наук", "3213364196", "Прибиральник", 13207.12m, "copying" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 5, 22, 10, 32, 206, DateTimeKind.Local).AddTicks(1470), "Вузька майдан, 19, Ізмаїл, Домініка", new DateTime(1973, 4, 24, 16, 31, 1, 365, DateTimeKind.Utc).AddTicks(6383), "Feodosiya.Sidleckii@e-mail.ua", new DateTime(2019, 5, 13, 19, 7, 7, 261, DateTimeKind.Local).AddTicks(6231), "Ян", "Головець", "канд. психол. наук", "4026271133", 17863.17m, "Principal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 4, 13, 18, 17, 44, 721, DateTimeKind.Local).AddTicks(5074), "Городоцька майдан, 187, Східний Земислав, Фіджі", new DateTime(1953, 9, 4, 3, 25, 18, 864, DateTimeKind.Utc).AddTicks(2248), "Virginiya66@meta.ua", new DateTime(2022, 11, 12, 6, 29, 54, 248, DateTimeKind.Local).AddTicks(5264), "Зеновій", "Василишина", "канд. юрид. наук", "0422694209", 1584.19m, "Unbranded Steel Pants" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 30, 11, 27, 0, 611, DateTimeKind.Local).AddTicks(1042), "вул. Зелена, 88, Львів, Японія", new DateTime(1973, 9, 15, 2, 21, 6, 187, DateTimeKind.Utc).AddTicks(666), "Ratimir81@e-mail.ua", "Віліна", "Андрухович", "докт. техн. наук", "7112833249", "Прибиральник", 17413.69m, "Seychelles" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 11, 25, 8, 31, 34, 394, DateTimeKind.Local).AddTicks(8913), "Зелена майдан, 9, Західний Матвій, Італія", new DateTime(1981, 9, 18, 10, 26, 33, 995, DateTimeKind.Utc).AddTicks(4839), "Dobroslava49@yandex.ua", null, "Дана", "Глинський", "докт. техн. наук", "4506750584", "Бухгалтер", 12539.20m, "Refined Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 4, 19, 13, 16, 10, 399, DateTimeKind.Local).AddTicks(6664), "Зелена майдан, 76, Західний Болеслав, Бенін", new DateTime(1991, 9, 4, 16, 9, 35, 50, DateTimeKind.Utc).AddTicks(4151), "Danilo.Grinevska78@gmail.com", null, "Адріян", "Стоян", "канд. психол. наук", "7356043279", "Директор", 1472.93m, "payment" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 13, 12, 47, 18, 174, DateTimeKind.Local).AddTicks(6691), "Коліївщини майдан, 22, Євпаторія, Лівія", new DateTime(1934, 2, 9, 14, 2, 35, 405, DateTimeKind.Utc).AddTicks(1261), "Lyubozar_Kononec44@e-mail.ua", "Омелян", "Верещук", "канд. філос. наук", "2421816078", "Секретар", 19013.88m, "array" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 11, 19, 7, 1, 21, 900, DateTimeKind.Local).AddTicks(7151), "пр. Коліївщини, 106, Південний Лаврін, Ефіопія", new DateTime(1930, 12, 4, 2, 14, 5, 985, DateTimeKind.Utc).AddTicks(7168), "Rayina.Petrishin46@meta.ua", new DateTime(2021, 5, 9, 0, 29, 43, 728, DateTimeKind.Local).AddTicks(3916), "Влада", "Щербак", "канд. психол. наук", "9718843525", "Бухгалтер", 16108.39m, "Roads" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 5, 1, 43, 1, 722, DateTimeKind.Local).AddTicks(9335), "Стрийська майдан, 42, Євпаторія, Марокко", new DateTime(1965, 5, 9, 14, 13, 4, 421, DateTimeKind.Utc).AddTicks(5631), "Orina89@yandex.ua", new DateTime(2021, 1, 20, 15, 55, 29, 741, DateTimeKind.Local).AddTicks(7254), "Володислав", "Дмитришина", "докт. техн. наук", "0594188684", "Секретар", 8052.20m, "Washington" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 3, 6, 22, 12, 2, 506, DateTimeKind.Local).AddTicks(4163), "пр. Вічева, 791, Південний Божемир, Буркіна-Фасо", new DateTime(1938, 4, 20, 16, 45, 47, 442, DateTimeKind.Utc).AddTicks(4236), "Lesya_Petlyura41@gmail.com", null, "Віленіна", "Шудрик", "канд. філос. наук", "6664194434", "Бухгалтер", 5865.89m, "Home Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 20, 23, 43, 14, 24, DateTimeKind.Local).AddTicks(2467), "Брюховичів майдан, 0, Східний Ян, Тонга", new DateTime(1960, 4, 28, 8, 10, 50, 763, DateTimeKind.Utc).AddTicks(1803), "Omelyan_Grishko96@ukr.net", null, "Далемир", "Ліхно", "докт. психол. наук", "8855306300", "Прибиральник", 19879.18m, "hacking" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 5, 2, 21, 39, 10, 230, DateTimeKind.Local).AddTicks(4424), "вул. Городоцька, 6, Одеса, Україна", new DateTime(1936, 4, 15, 22, 50, 26, 161, DateTimeKind.Utc).AddTicks(6392), "Kii_Luckiv@e-mail.ua", "Віталіна", "Мамій", "докт. юрид. наук", "3560742729", "Секретар", 9694.93m, "metrics" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 8, 13, 13, 1, 46, 307, DateTimeKind.Local).AddTicks(1684), "Коліївщини майдан, 89, Південний Олексій, Сомалі", new DateTime(2000, 2, 2, 17, 13, 4, 788, DateTimeKind.Utc).AddTicks(3651), "Boguslava96@meta.ua", new DateTime(2021, 3, 11, 7, 19, 39, 360, DateTimeKind.Local).AddTicks(1026), "Калина", "Петренко", "0002835391", "Директор", 11516.62m, "maximize" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 5, 13, 22, 25, 41, 180, DateTimeKind.Local).AddTicks(6202), "Нижанківського майдан, 6, Біла Церква, Бруней", new DateTime(1968, 5, 25, 12, 19, 29, 29, DateTimeKind.Utc).AddTicks(9558), "Bratislav27@i.ua", "Владислава", "Свидригайло", "доц.", "3671346047", "Прибиральник", 17320.01m, "Fresh" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 8, 5, 18, 28, 49, 142, DateTimeKind.Local).AddTicks(4703), "Вічева майдан, 3, Луганськ, Бруней", new DateTime(1948, 9, 15, 3, 59, 58, 349, DateTimeKind.Utc).AddTicks(9733), "Lavrentii.Gladkivska93@yandex.ua", null, "Милослава", "Притула", "докт. юрид. наук", "7294621133", "Секретар", 11796.89m, "Intelligent" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 22, 3, 30, 51, 528, DateTimeKind.Local).AddTicks(747), "провулок Ліста, 6, Кременчук, Науру", new DateTime(1951, 2, 24, 0, 40, 13, 879, DateTimeKind.Utc).AddTicks(79), "Viktoriya22@gmail.com", null, "Аврелія", "Трублаєвський", "канд. філол. наук", "9602582321", "Секретар", 19337.70m, "Sleek" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 22, 5, 13, 54, 281, DateTimeKind.Local).AddTicks(9991), "Брюховичів майдан, 8, Південний Архип, Колумбія", new DateTime(1978, 10, 11, 8, 31, 23, 145, DateTimeKind.Utc).AddTicks(2166), "Krentta25@yandex.ua", "В’ячеслав", "Опенько", "докт. техн. наук", "4448687129", 17404.00m, "Assistant" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 7, 9, 0, 33, 491, DateTimeKind.Local).AddTicks(7661), "Вузька майдан, 8, Південний Ярема, Руанда", new DateTime(1997, 3, 1, 1, 13, 53, 816, DateTimeKind.Utc).AddTicks(8675), "Ilona_Vereshuk72@yandex.ua", new DateTime(2020, 1, 22, 11, 14, 1, 291, DateTimeKind.Local).AddTicks(4215), "Алевтина", "Гнатишин", "докт. пед. наук", "2747191878", "Бухгалтер", 11746.78m, "Unions" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 27, 7, 52, 45, 955, DateTimeKind.Local).AddTicks(5751), "Вузька майдан, 1, Південний Славолюб, Словенія", new DateTime(1944, 6, 27, 10, 43, 32, 78, DateTimeKind.Utc).AddTicks(770), "Zorina35@e-mail.ua", new DateTime(2020, 12, 8, 22, 47, 49, 846, DateTimeKind.Local).AddTicks(9701), "Віленіна", "Ящук", "докт. філол. наук", "9592303489", "Програміст", 9431.56m, "Route" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 29, 1, 28, 59, 825, DateTimeKind.Local).AddTicks(7252), "Стрийська майдан, 8, Північний Алевтин, Мальдіви", new DateTime(1979, 2, 27, 22, 21, 8, 137, DateTimeKind.Utc).AddTicks(6186), "Oresta69@meta.ua", null, "Влада", "Пагутяк", "проф.", "8364319566", "Бухгалтер", 2665.15m, "generate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 3, 5, 1, 8, 57, 300, DateTimeKind.Local).AddTicks(9645), "Винників майдан, 82, Західний Корнило, Куба", new DateTime(1960, 12, 30, 8, 10, 46, 924, DateTimeKind.Utc).AddTicks(2558), "Stefanii59@ex.ua", new DateTime(2021, 11, 8, 0, 13, 30, 491, DateTimeKind.Local).AddTicks(35), "Зборислав", "Скоропадська", "докт. і. наук", "8607770687", "Секретар", 19635.80m, "Ergonomic Cotton Mouse" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 12, 4, 10, 16, 247, DateTimeKind.Local).AddTicks(4007), "Коліївщини майдан, 321, Південний Зиновій, Папуа-Нова Гвінея", new DateTime(1953, 5, 7, 2, 23, 50, 225, DateTimeKind.Utc).AddTicks(2357), "Nazar_Spotikach40@e-mail.ua", "Любислава", "Ліхно", "докт. політ. наук", "3791278813", "Прибиральник", 11664.20m, "Unbranded" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 30, 20, 58, 57, 692, DateTimeKind.Local).AddTicks(6714), "Брюховичів майдан, 6, Західний Марко, Руанда", new DateTime(1948, 1, 2, 10, 20, 23, 336, DateTimeKind.Utc).AddTicks(5029), "Zakhar96@yandex.ua", null, "Потап", "Москалюк", "канд. філос. наук", "7194301510", "Секретар", 13429.29m, "Bridge" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 5, 1, 11, 1, 36, 627, DateTimeKind.Local).AddTicks(5523), "Ліста майдан, 126, Лисичанськ, Сент-Вінсент і Гренадини", new DateTime(1984, 7, 28, 3, 47, 5, 714, DateTimeKind.Utc).AddTicks(9770), "Zvenislava_Kolomiyec4@ex.ua", null, "Антон", "Бамбула", "проф.", "9693348513", "Бухгалтер", 4345.07m, "Unbranded" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 16, 4, 27, 24, 631, DateTimeKind.Local).AddTicks(5089), "площа Нижанківського, 00, Маріуполь, Малаві", new DateTime(1934, 2, 25, 12, 52, 39, 230, DateTimeKind.Utc).AddTicks(6111), "Stefanii41@yandex.ua", null, "Гордій", "Тарасюк", "докт. юрид. наук", "9656554375", "Директор", 19626.07m, "networks" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 3, 7, 12, 31, 17, 178, DateTimeKind.Local).AddTicks(3223), "Брюховичів майдан, 626, Полтава, Барбадос", new DateTime(1995, 8, 14, 16, 18, 22, 984, DateTimeKind.Utc).AddTicks(645), "Dolyana_Glinska41@ex.ua", "Гліб", "Євпак", "докт. філол. наук", "4742608319", "Директор", 18903.45m, "AI" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 19, 10, 980, DateTimeKind.Local).AddTicks(2167), "Зелена майдан, 8, Конотоп, Мальта", new DateTime(1978, 7, 10, 19, 24, 29, 769, DateTimeKind.Utc).AddTicks(3355), "Nadiya_Petrishina@ex.ua", null, "Зоряна", "Осадко", "докт. психол. наук", "4720258104", "Директор", 10566.75m, "Rubber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 23, 52, 587, DateTimeKind.Local).AddTicks(5875), "пров. Винників, 72, Північний Макар, Молдова", new DateTime(2006, 1, 23, 15, 26, 23, 337, DateTimeKind.Utc).AddTicks(6397), "Dobromira.Pavlenko@meta.ua", new DateTime(2022, 4, 4, 21, 48, 23, 43, DateTimeKind.Local).AddTicks(4521), "Любодар", "Ярмак", "канд. і. наук", "8121908183", "Бухгалтер", 14630.19m, "real-time" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 21, 12, 11, 28, 201, DateTimeKind.Local).AddTicks(7221), "Городоцька майдан, 6, Західний Білослав, Словенія", new DateTime(1996, 3, 3, 20, 43, 43, 240, DateTimeKind.Utc).AddTicks(8352), "Zvenislav62@ukr.net", new DateTime(2019, 12, 31, 5, 0, 38, 81, DateTimeKind.Local).AddTicks(9269), "Анастасій", "Шупик", "канд. юрид. наук", "7696207441", "Секретар", 19492.08m, "European Unit of Account 9(E.U.A.-9)" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 3, 14, 0, 36, 54, 219, DateTimeKind.Local).AddTicks(9746), "Ліста майдан, 0, Східний Мусій, Сенеґал", new DateTime(1954, 12, 9, 18, 48, 26, 185, DateTimeKind.Utc).AddTicks(8219), "Orest90@ex.ua", null, "Віола", "Шухевич", "канд. і. наук", "4916974011", "Секретар", 4965.50m, "Refined Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 11, 0, 37, 57, 154, DateTimeKind.Local).AddTicks(599), "провулок Молодіжна, 032, Південний Аскольд, Ямайка", new DateTime(1968, 10, 12, 18, 52, 25, 496, DateTimeKind.Utc).AddTicks(3781), "Boleslav_Makhno@i.ua", "Даромир", "Балакун", "докт. психол. наук", "4354255103", 13599.72m, "Profound" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 4, 19, 14, 42, 9, 505, DateTimeKind.Local).AddTicks(3544), "провулок Молодіжна, 177, Горлівка, Ватикан", new DateTime(1947, 5, 3, 6, 33, 27, 324, DateTimeKind.Utc).AddTicks(4637), "Yarema_Bashuk@ukr.net", "Богдан", "Зінкевич", "доц.", "1156258625", "Бухгалтер", 1206.87m, "core" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 6, 11, 44, 7, 913, DateTimeKind.Local).AddTicks(3731), "Рудного майдан, 480, Дніпропетровськ, Австрія", new DateTime(2001, 9, 2, 7, 48, 47, 676, DateTimeKind.Utc).AddTicks(322), "Olga.Romanishina5@ex.ua", new DateTime(2023, 11, 7, 18, 3, 35, 565, DateTimeKind.Local).AddTicks(9389), "Максим", "Притула", "докт. техн. наук", "3061935628", "Секретар", 19739.47m, "Internal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 12, 4, 6, 29, 4, 998, DateTimeKind.Local).AddTicks(8759), "вул. Рудного, 338, Івано-Франківськ, Білорусь", new DateTime(1962, 6, 17, 7, 58, 5, 845, DateTimeKind.Utc).AddTicks(6900), "Burevist.Voloshuk@yandex.ua", null, "Олег", "Балакун", "докт. юрид. наук", "6253767778", "Програміст", 5847.19m, "Junctions" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 8, 11, 7, 25, 799, DateTimeKind.Local).AddTicks(7843), "Молодіжна майдан, 70, Сімферополь, Непал", new DateTime(1958, 4, 20, 9, 35, 34, 463, DateTimeKind.Utc).AddTicks(8655), "Gradimir9@e-mail.ua", new DateTime(2019, 4, 26, 14, 55, 49, 472, DateTimeKind.Local).AddTicks(6043), "Лідія", "Брицький", "докт. філол. наук", "4262346989", 17014.32m, "FTP" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 9, 19, 8, 31, 16, 144, DateTimeKind.Local).AddTicks(4200), "провулок Городоцька, 57, Південний Мирон, Сент-Кітс і Невіс", new DateTime(1948, 1, 2, 2, 30, 1, 690, DateTimeKind.Utc).AddTicks(3732), "Timish.Osadko70@ukr.net", "Немира", "Трясило", "докт. техн. наук", "4163468180", "Програміст", 4963.77m, "infomediaries" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 8, 16, 8, 13, 6, 970, DateTimeKind.Local).AddTicks(9994), "пр. Молодіжна, 0, Артемівськ, Ямайка", new DateTime(2004, 10, 1, 16, 21, 9, 330, DateTimeKind.Utc).AddTicks(6001), "Borimir14@yandex.ua", new DateTime(2023, 5, 13, 15, 24, 10, 304, DateTimeKind.Local).AddTicks(3973), "Євген", "Потебенько", "докт. політ. наук", "8093560427", "Прибиральник", 18145.39m, "Way" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 1, 24, 18, 44, 4, 631, DateTimeKind.Local).AddTicks(7822), "Винників майдан, 498, Східний Назар, Таджикистан", new DateTime(1974, 5, 17, 10, 51, 33, 622, DateTimeKind.Utc).AddTicks(4852), "Glib.Lazirko87@meta.ua", new DateTime(2023, 1, 21, 21, 28, 25, 12, DateTimeKind.Local).AddTicks(1122), "Тетяна", "Ногачевський", "докт. юрид. наук", "9620509059", "Бухгалтер", 4890.11m, "Inlet" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 13, 8, 29, 2, 866, DateTimeKind.Local).AddTicks(7029), "Нижанківського майдан, 98, Західний Яромил, Східний Тимор", new DateTime(1941, 10, 14, 12, 55, 38, 469, DateTimeKind.Utc).AddTicks(8832), "Arsen68@ex.ua", "Мусій", "Галаєнко", "канд. філол. наук", "9511250474", "Прибиральник", 16322.30m, "relationships" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 11, 19, 2, 19, 896, DateTimeKind.Local).AddTicks(3771), "Нижанківського майдан, 0, Запоріжжя, Тонга", new DateTime(1939, 10, 28, 2, 45, 3, 521, DateTimeKind.Utc).AddTicks(6865), "Bratomil_Voloshuk20@ukr.net", new DateTime(2021, 9, 27, 18, 23, 23, 761, DateTimeKind.Local).AddTicks(4659), "Зеновій", "Гамула", "доц.", "9357405755", "Прибиральник", 12071.37m, "Multi-layered" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 14, 9, 8, 42, 704, DateTimeKind.Local).AddTicks(6606), "Рудного майдан, 509, Південний Захар, Бенін", new DateTime(1968, 4, 28, 16, 40, 40, 52, DateTimeKind.Utc).AddTicks(3875), "Slavuta_Mazailo@i.ua", new DateTime(2020, 3, 1, 12, 1, 14, 442, DateTimeKind.Local).AddTicks(1406), "Гнат", "Лахман", "доц.", "9494668199", "Програміст", 3361.57m, "asymmetric" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 29, 15, 39, 46, 277, DateTimeKind.Local).AddTicks(8474), "Молодіжна майдан, 8, Черкаси, Туреччина", new DateTime(1970, 7, 16, 7, 11, 6, 13, DateTimeKind.Utc).AddTicks(7311), "Mokrina_Osadko@e-mail.ua", null, "Валентина", "Бабух", "канд. психол. наук", "1384623922", "Секретар", 2216.13m, "Handcrafted Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 15, 3, 37, 29, 629, DateTimeKind.Local).AddTicks(7586), "Стрийська майдан, 9, Керч, Зімбабве", new DateTime(2002, 12, 17, 21, 7, 29, 152, DateTimeKind.Utc).AddTicks(6905), "Fevroniya.Stigailo0@e-mail.ua", null, "Всевлад", "Миклухо", "докт. техн. наук", "4288894565", "Програміст", 6087.95m, "hack" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 7, 4, 13, 45, 3, 603, DateTimeKind.Local).AddTicks(9358), "Зелена майдан, 334, Східний Матвій, Конго", new DateTime(1981, 4, 8, 17, 0, 38, 680, DateTimeKind.Utc).AddTicks(4475), "Pavlo.Pogiba@i.ua", null, "Віргінія", "Магера", "канд. філол. наук", "1263130747", "Секретар", 3449.26m, "deposit" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 27, 7, 2, 40, 174, DateTimeKind.Local).AddTicks(9762), "пр. Рудного, 5, Південний Олелько, Маршаллові Острови", new DateTime(1946, 3, 5, 17, 49, 52, 349, DateTimeKind.Utc).AddTicks(7618), "Biloslav35@ukr.net", new DateTime(2024, 1, 9, 1, 52, 1, 649, DateTimeKind.Local).AddTicks(2437), "Зеновій", "Васильківська", "0192157760", 16193.49m, "Architect" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 5, 0, 3, 28, 690, DateTimeKind.Local).AddTicks(587), "Ліста майдан, 11, Олександрія, Коста-Рика", new DateTime(1988, 11, 17, 5, 3, 40, 89, DateTimeKind.Utc).AddTicks(5554), "Motrya95@meta.ua", "Агафія", "Москаль", "канд. пед. наук", "4665258579", "Секретар", 3442.60m, "Louisiana" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 19, 19, 22, 2, 974, DateTimeKind.Local).AddTicks(9276), "пров. Рудного, 76, Західний Олександр, Ізраїль", new DateTime(1989, 11, 13, 12, 16, 21, 741, DateTimeKind.Utc).AddTicks(8145), "Maryan_Likhno@yandex.ua", new DateTime(2023, 11, 10, 5, 14, 42, 81, DateTimeKind.Local).AddTicks(4038), "Влад", "Семещук", "канд. і. наук", "9619754557", "Секретар", 15596.68m, "Gorgeous Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 3, 19, 12, 33, 22, 452, DateTimeKind.Local).AddTicks(7330), "вулиця Городоцька, 6, Південний Роман, Гондурас", new DateTime(1953, 4, 5, 13, 8, 26, 484, DateTimeKind.Utc).AddTicks(330), "Radoslava.Mazailo@yandex.ua", "Пелагія", "Цушко", "канд. і. наук", "0189273849", "Директор", 14667.02m, "optical" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 31, 13, 28, 12, 698, DateTimeKind.Local).AddTicks(900), "Молодіжна майдан, 1, Західний Григорій, Бельгія", new DateTime(1954, 5, 1, 9, 25, 21, 752, DateTimeKind.Utc).AddTicks(5863), "Gordii.Mogilevskii6@yandex.ua", null, "Антін", "Гриневецький", "канд. і. наук", "7511630757", "Секретар", 6828.03m, "scale" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 3, 20, 18, 10, 53, 94, DateTimeKind.Local).AddTicks(387), "Зелена майдан, 047, Північний Анатолій, Кувейт", new DateTime(1978, 12, 4, 8, 11, 6, 197, DateTimeKind.Utc).AddTicks(413), "Askold_Silecka67@e-mail.ua", null, "Адріана", "Гарун", "докт. пед. наук", "3400869365", "Бухгалтер", 3044.05m, "Garden" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 20, 4, 5, 39, 59, DateTimeKind.Local).AddTicks(6220), "пл. Винників, 8, Східний Святослав, Самоа", new DateTime(1949, 8, 19, 7, 45, 18, 863, DateTimeKind.Utc).AddTicks(133), "Vilenina_Porivailo@i.ua", "Хорив", "Гойко", "доц.", "1638544563", "Бухгалтер", 13779.00m, "Frozen" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 1, 3, 4, 36, 38, 835, DateTimeKind.Local).AddTicks(1341), "Рудного майдан, 939, Сімферополь, Камбоджа", new DateTime(1983, 6, 19, 22, 23, 20, 130, DateTimeKind.Utc).AddTicks(1784), "Agnesa_Yavorivskii@i.ua", null, "Ян", "Васильківський", "канд. техн. наук", "6359987394", "Бухгалтер", 5937.47m, "fuchsia" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 26, 5, 33, 43, 969, DateTimeKind.Local).AddTicks(8055), "пл. Вічева, 965, Південний Гордій, Ботсвана", new DateTime(1974, 6, 20, 3, 47, 22, 457, DateTimeKind.Utc).AddTicks(4994), "Fevroniya.Kivach80@meta.ua", null, "Меланія", "Балабан", "канд. юрид. наук", "4656836857", "Програміст", 19730.14m, "Granite" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 10, 18, 55, 1, 474, DateTimeKind.Local).AddTicks(3744), "Брюховичів майдан, 0, Алчевськ, Коморські Острови", new DateTime(1968, 11, 24, 7, 57, 29, 539, DateTimeKind.Utc).AddTicks(583), "Zinovii_Usich39@i.ua", new DateTime(2022, 5, 10, 19, 14, 40, 638, DateTimeKind.Local).AddTicks(2546), "Лілія", "Карпух", "докт. і. наук", "3235922794", 10346.63m, "connecting" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 2, 20, 22, 32, 44, 417, DateTimeKind.Local).AddTicks(3699), "вулиця Стрийська, 73, Луцьк, Ірландія", new DateTime(1993, 7, 10, 1, 48, 32, 298, DateTimeKind.Utc).AddTicks(2256), "Miron_Suchak72@i.ua", new DateTime(2019, 8, 3, 17, 43, 57, 547, DateTimeKind.Local).AddTicks(6243), "Охрім", "Верещук", "канд. філос. наук", "5214880895", 10724.97m, "turn-key" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 14, 2, 13, 8, 547, DateTimeKind.Local).AddTicks(6957), "Коліївщини майдан, 67, Євпаторія, Бенін", new DateTime(1952, 3, 22, 17, 55, 8, 647, DateTimeKind.Utc).AddTicks(8019), "Antonina15@i.ua", "Біломир", "Троян", "канд. психол. наук", "8720531695", "Директор", 2949.97m, "groupware" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 23, 12, 19, 56, 721, DateTimeKind.Local).AddTicks(4840), "провулок Нижанківського, 3, Севастополь, Ємен", new DateTime(1929, 3, 11, 19, 0, 15, 281, DateTimeKind.Utc).AddTicks(8048), "Tikhon59@ukr.net", new DateTime(2023, 3, 19, 21, 4, 12, 135, DateTimeKind.Local).AddTicks(7232), "Аркадія", "Мазун", "докт. і. наук", "8186730719", "Прибиральник", 16013.75m, "Rial Omani" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 19, 20, 43, 20, 51, DateTimeKind.Local).AddTicks(3128), "Стрийська майдан, 957, Західний Корнило, Литва", new DateTime(2004, 3, 29, 19, 57, 42, 58, DateTimeKind.Utc).AddTicks(4391), "Ruslan_Tkachenko61@ukr.net", null, "Аркадій", "Юхно", "канд. філол. наук", "5800366278", "Директор", 13554.03m, "Intuitive" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 4, 17, 21, 35, 12, 341, DateTimeKind.Local).AddTicks(7869), "пл. Староміська, 6, Північний Анатолій, Гвінея", new DateTime(1944, 6, 13, 9, 37, 24, 714, DateTimeKind.Utc).AddTicks(3153), "Radim_Unich@i.ua", new DateTime(2021, 2, 21, 6, 37, 44, 332, DateTimeKind.Local).AddTicks(6476), "Благовіста", "Стоян", "докт. пед. наук", "2108391358", "Директор", 14233.47m, "teal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 5, 9, 48, 3, 263, DateTimeKind.Local).AddTicks(726), "Вічева майдан, 605, Лисичанськ, Антигуа і Барбуда", new DateTime(2006, 1, 31, 4, 59, 24, 161, DateTimeKind.Utc).AddTicks(1749), "Denis.Petriv@yandex.ua", new DateTime(2020, 4, 6, 3, 42, 27, 669, DateTimeKind.Local).AddTicks(7226), "Всеслава", "Погиба", "докт. пед. наук", "3009186530", "Секретар", 10724.49m, "circuit" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 7, 4, 37, 37, 379, DateTimeKind.Local).AddTicks(9807), "Молодіжна майдан, 3, Східний Мечислав, Єгипет", new DateTime(1959, 1, 7, 9, 4, 13, 354, DateTimeKind.Utc).AddTicks(5775), "Yuliya.Vitrebenko85@e-mail.ua", new DateTime(2024, 4, 3, 10, 36, 51, 245, DateTimeKind.Local).AddTicks(1328), "Родіон", "Бандера", "канд. і. наук", "1061371700", "Секретар", 17258.98m, "migration" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 3, 21, 1, 9, 25, 977, DateTimeKind.Local).AddTicks(1309), "вул. Ліста, 9, Біла Церква, Антигуа і Барбуда", new DateTime(1953, 3, 9, 21, 10, 9, 775, DateTimeKind.Utc).AddTicks(5706), "Vira_Kalach24@e-mail.ua", new DateTime(2022, 8, 22, 13, 2, 2, 938, DateTimeKind.Local).AddTicks(9756), "Федора", "Погиба", "докт. пед. наук", "4382875688", "Секретар", 17803.41m, "Handcrafted Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 11, 23, 8, 54, 50, 116, DateTimeKind.Local).AddTicks(2456), "площа Коліївщини, 5, Північний Тарас, Намібія", new DateTime(1942, 1, 13, 4, 52, 48, 117, DateTimeKind.Utc).AddTicks(1616), "Roksolan60@gmail.com", new DateTime(2019, 11, 23, 11, 36, 34, 920, DateTimeKind.Local).AddTicks(1114), "Листвич", "Притула", "докт. психол. наук", "0913223114", "Директор", 19403.71m, "EXE" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 2, 3, 18, 17, 974, DateTimeKind.Local).AddTicks(4574), "вулиця Нижанківського, 30, Єнакієве, Ліхтенштейн", new DateTime(1948, 7, 27, 23, 21, 32, 253, DateTimeKind.Utc).AddTicks(1319), "Violetta84@i.ua", new DateTime(2021, 7, 27, 8, 3, 49, 607, DateTimeKind.Local).AddTicks(2577), "Корнило", "Витребенько", "канд. філол. наук", "9347327359", 6521.66m, "Mills" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 7, 4, 52, 48, 708, DateTimeKind.Local).AddTicks(1786), "Нижанківського майдан, 44, Північний Вадим, Італія", new DateTime(2001, 1, 8, 18, 37, 20, 530, DateTimeKind.Utc).AddTicks(8860), "Maksim.Lazirko@e-mail.ua", new DateTime(2022, 1, 9, 16, 46, 30, 256, DateTimeKind.Local).AddTicks(2427), "Орися", "Демків", "докт. філол. наук", "2974910270", "Програміст", 17351.69m, "Shoes & Tools" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 24, 19, 58, 3, 435, DateTimeKind.Local).AddTicks(1535), "провулок Брюховичів, 376, Кременчук, Єгипет", new DateTime(1950, 9, 7, 23, 3, 19, 777, DateTimeKind.Utc).AddTicks(5202), "Lado.Shiyan@meta.ua", "Болеслав", "Щербак", "канд. техн. наук", "1681601887", 6177.94m, "workforce" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 4, 0, 59, 47, 95, DateTimeKind.Local).AddTicks(2105), "вул. Рудного, 539, Північний Божен, Габон", new DateTime(1944, 9, 2, 18, 23, 58, 347, DateTimeKind.Utc).AddTicks(5844), "Lada_Lindik@ex.ua", "Аркадій", "Миклухо", "канд. і. наук", "7403169231", "Бухгалтер", 12039.89m, "Soft" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 10, 21, 34, 28, 169, DateTimeKind.Local).AddTicks(1664), "Вузька майдан, 3, Західний Владислав, Малаві", new DateTime(1987, 3, 11, 14, 21, 50, 248, DateTimeKind.Utc).AddTicks(624), "Svyatoslava.Minyailo86@ukr.net", new DateTime(2021, 11, 2, 22, 25, 15, 749, DateTimeKind.Local).AddTicks(3812), "Славомир", "Лугова", "канд. політ. наук", "5347171922", "Програміст", 1255.86m, "Silver" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 6, 0, 41, 50, 306, DateTimeKind.Local).AddTicks(2367), "пл. Староміська, 722, Суми, Коста-Рика", new DateTime(1955, 12, 29, 18, 14, 24, 558, DateTimeKind.Utc).AddTicks(3371), "Tayisiya56@gmail.com", new DateTime(2023, 12, 24, 6, 11, 21, 577, DateTimeKind.Local).AddTicks(3066), "Любов", "Барановський", "канд. пед. наук", "4400867151", "Бухгалтер", 1972.45m, "Investment Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 11, 9, 17, 55, 40, 102, DateTimeKind.Local).AddTicks(2851), "Вузька майдан, 82, Севастополь, Сенеґал", new DateTime(2000, 11, 20, 6, 17, 7, 189, DateTimeKind.Utc).AddTicks(3594), "Yevgen_Kocyubinska@i.ua", "Віталіна", "Яворівська", "докт. пед. наук", "6940506952", "Секретар", 5383.45m, "firewall" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 3, 7, 22, 12, 54, 991, DateTimeKind.Local).AddTicks(383), "Коліївщини майдан, 7, Красний Луч, Естонія", new DateTime(1989, 5, 25, 10, 52, 57, 310, DateTimeKind.Utc).AddTicks(4226), "Grigorii.Demchishina@gmail.com", new DateTime(2024, 1, 6, 21, 24, 10, 228, DateTimeKind.Local).AddTicks(9930), "Забава", "Майборода", "докт. пед. наук", "2040003145", "Прибиральник", 4800.88m, "Shore" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 28, 16, 58, 33, 59, DateTimeKind.Local).AddTicks(7543), "Ліста майдан, 27, Херсон, Ліберія", new DateTime(2005, 2, 28, 0, 31, 40, 871, DateTimeKind.Utc).AddTicks(8236), "Mechislav.Palii14@gmail.com", new DateTime(2023, 4, 15, 15, 35, 29, 868, DateTimeKind.Local).AddTicks(5425), "Галина", "Бачей", "канд. філос. наук", "0654341618", "Бухгалтер", 7824.16m, "payment" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 3, 4, 9, 54, 16, 529, DateTimeKind.Local).AddTicks(631), "Рудного майдан, 3, Західний Лаврентій, Уганда", new DateTime(2005, 8, 5, 15, 55, 46, 798, DateTimeKind.Utc).AddTicks(1875), "Alvina86@i.ua", "Віта", "Тиндарей", "докт. психол. наук", "5170697185", "Секретар", 19820.14m, "Lebanon" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 9, 2, 20, 53, 0, 590, DateTimeKind.Local).AddTicks(3439), "Ліста майдан, 859, Південний Ігор, Таїланд", new DateTime(1976, 10, 14, 11, 9, 40, 389, DateTimeKind.Utc).AddTicks(2509), "Dobromila48@ukr.net", null, "Боримисл", "Забіла", "доц.", "3720973412", "Бухгалтер", 13513.55m, "Horizontal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 21, 17, 4, 9, 488, DateTimeKind.Local).AddTicks(141), "Брюховичів майдан, 882, Південний Братослав, Фінляндія", new DateTime(1961, 11, 4, 8, 45, 46, 831, DateTimeKind.Utc).AddTicks(9081), "Avgustin_Balabukha80@i.ua", null, "Мілана", "Сідлецька", "докт. філос. наук", "4956690765", "Директор", 14814.52m, "parse" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 26, 9, 52, 7, 855, DateTimeKind.Local).AddTicks(8249), "Староміська майдан, 16, Західний Корнило, Оман", new DateTime(1973, 11, 8, 3, 46, 20, 197, DateTimeKind.Utc).AddTicks(3273), "Yustina.Galacion18@yandex.ua", new DateTime(2021, 9, 5, 22, 31, 35, 567, DateTimeKind.Local).AddTicks(9575), "Антонида", "Ломова", "доц.", "2804200199", 12538.41m, "even-keeled" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 28, 10, 48, 15, 141, DateTimeKind.Local).AddTicks(5896), "Коліївщини майдан, 70, Південний Любодар, Іспанія", new DateTime(1966, 1, 17, 3, 44, 16, 391, DateTimeKind.Utc).AddTicks(7559), "Anastas_Yalovii@meta.ua", null, "Владислав", "Дурдинець", "канд. філос. наук", "4692390590", "Прибиральник", 7663.51m, "Handcrafted" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 25, 22, 55, 25, 696, DateTimeKind.Local).AddTicks(4471), "Нижанківського майдан, 1, Східний Корній, Мадаґаскар", new DateTime(1937, 8, 3, 2, 49, 16, 580, DateTimeKind.Utc).AddTicks(6906), "Irma_Kalach@meta.ua", null, "Богуслава", "Трублаєвський", "канд. техн. наук", "0267988223", 7621.90m, "Bedfordshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 20, 19, 55, 58, 480, DateTimeKind.Local).AddTicks(2444), "площа Винників, 4, Північний Лаврін, Іран", new DateTime(1947, 5, 29, 13, 31, 25, 587, DateTimeKind.Utc).AddTicks(645), "Arsen_Veredun@ex.ua", new DateTime(2023, 6, 27, 20, 21, 49, 620, DateTimeKind.Local).AddTicks(4334), "Діяна", "Ромей", "канд. юрид. наук", "0630644824", "Директор", 4630.78m, "Industrial, Sports & Baby" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 34, 58, 222, DateTimeKind.Local).AddTicks(5817), "провулок Городоцька, 7, Північний Зоремир, Тонга", new DateTime(1941, 5, 16, 4, 38, 46, 730, DateTimeKind.Utc).AddTicks(3270), "Lesya_Pritula69@e-mail.ua", new DateTime(2021, 8, 6, 3, 47, 0, 51, DateTimeKind.Local).AddTicks(1159), "Сміяна", "Ющук", "докт. філос. наук", "4335220784", "Бухгалтер", 2142.56m, "Fort" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 22, 8, 46, 14, 639, DateTimeKind.Local).AddTicks(5534), "Винників майдан, 623, Західний Яровид, Свазіленд", new DateTime(1927, 7, 26, 3, 31, 23, 461, DateTimeKind.Utc).AddTicks(6802), "Shek.Palii16@meta.ua", "Вілена", "Лящук", "докт. психол. наук", "9304477024", "Бухгалтер", 10051.04m, "Tools & Grocery" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 28, 23, 4, 8, 772, DateTimeKind.Local).AddTicks(2730), "вул. Староміська, 569, Ужгород, Словенія", new DateTime(1974, 10, 6, 3, 50, 38, 512, DateTimeKind.Utc).AddTicks(3260), "Listvich.Gaichuk76@gmail.com", null, "Богдан", "Пасічник", "докт. техн. наук", "4345590129", 1142.16m, "Concrete" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 1, 18, 52, 28, 620, DateTimeKind.Local).AddTicks(4016), "Рудного майдан, 426, Східний Павло, Непал", new DateTime(1969, 9, 2, 0, 36, 26, 243, DateTimeKind.Utc).AddTicks(4359), "Yeremii_Yanyuk31@e-mail.ua", "Максим", "Корецька", "канд. юрид. наук", "4412255169", "Програміст", 17991.51m, "synthesize" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 3, 19, 1, 7, 18, 991, DateTimeKind.Local).AddTicks(3920), "вулиця Рудного, 22, Північний Ратибор, Чад", new DateTime(1991, 9, 1, 12, 41, 54, 885, DateTimeKind.Utc).AddTicks(9135), "Snizhana_Garun82@gmail.com", null, "Станислава", "Янюк", "докт. юрид. наук", "8157556768", "Бухгалтер", 4563.12m, "invoice" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 10, 21, 59, 47, 817, DateTimeKind.Local).AddTicks(5049), "площа Нижанківського, 0, Північний Горислав, Латвія", new DateTime(1975, 9, 10, 18, 3, 40, 272, DateTimeKind.Utc).AddTicks(1767), "Lyudomila_Balabukha@gmail.com", new DateTime(2019, 10, 30, 15, 11, 8, 148, DateTimeKind.Local).AddTicks(1554), "Зореслава", "Василишина", "докт. філол. наук", "9464213077", "Директор", 4680.55m, "Buckinghamshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 7, 14, 3, 33, 6, 868, DateTimeKind.Local).AddTicks(7942), "Рудного майдан, 5, Конотоп, Бангладеш", new DateTime(1955, 8, 13, 20, 45, 37, 511, DateTimeKind.Utc).AddTicks(3631), "Roksolana.Shumilo@gmail.com", "Роксолан", "Бутько", "докт. політ. наук", "6214949531", 1618.02m, "Berkshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 4, 0, 3, 50, 114, DateTimeKind.Local).AddTicks(8166), "Стрийська майдан, 8, Північний Всеслав, Туркменістан", new DateTime(1946, 8, 19, 17, 10, 52, 940, DateTimeKind.Utc).AddTicks(3485), "Zlat.Spotikach41@meta.ua", null, "Микита", "Стоян", "канд. філол. наук", "5823301185", "Прибиральник", 1627.97m, "expedite" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 9, 30, 8, 58, 35, 823, DateTimeKind.Local).AddTicks(6496), "площа Брюховичів, 621, Східний Боримир, Мальдіви", new DateTime(1971, 8, 19, 12, 23, 28, 187, DateTimeKind.Utc).AddTicks(929), "Adam.Miklukho39@yandex.ua", "Гордій", "Ликович", "канд. і. наук", "4535321627", "Директор", 15012.70m, "deliverables" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 11, 1, 16, 23, 45, 710, DateTimeKind.Local).AddTicks(1267), "Молодіжна майдан, 9, Північний Геннадій, Афганістан", new DateTime(1950, 11, 13, 4, 46, 38, 242, DateTimeKind.Utc).AddTicks(5504), "Petro.Umanec7@ex.ua", new DateTime(2020, 3, 18, 16, 37, 6, 972, DateTimeKind.Local).AddTicks(5536), "Калина", "Іванців", "канд. пед. наук", "0259867564", "Прибиральник", 6333.60m, "programming" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 9, 7, 8, 44, 58, 213, DateTimeKind.Local).AddTicks(1726), "Вічева майдан, 2, Східний Сергій, Ватикан", new DateTime(1984, 7, 23, 7, 49, 58, 643, DateTimeKind.Utc).AddTicks(2233), "Taras.Pavlenko@e-mail.ua", "Станислава", "Шухевич", "докт. політ. наук", "0537110921", 14809.18m, "Borders" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 2, 2, 14, 3, 57, DateTimeKind.Local).AddTicks(5902), "Винників майдан, 24, Сєвєродонецьк, Бангладеш", new DateTime(1994, 10, 16, 17, 32, 7, 451, DateTimeKind.Utc).AddTicks(8507), "Zorina36@yandex.ua", null, "Адріян", "Шиндарей", "канд. політ. наук", "8151166651", "Директор", 1705.12m, "Glens" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 1, 4, 3, 35, 158, DateTimeKind.Local).AddTicks(8856), "Нижанківського майдан, 14, Олександрія, Монголія", new DateTime(1956, 7, 15, 15, 59, 26, 860, DateTimeKind.Utc).AddTicks(3295), "Radoslava.Romanishina0@meta.ua", new DateTime(2023, 11, 20, 19, 4, 53, 218, DateTimeKind.Local).AddTicks(7389), "Стожар", "Корецький", "докт. юрид. наук", "8974157112", 14168.76m, "Customer-focused" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 26, 39, 133, DateTimeKind.Local).AddTicks(795), "Рудного майдан, 9, Чернівці, Гаїті", new DateTime(1960, 6, 11, 10, 15, 41, 468, DateTimeKind.Utc).AddTicks(8209), "Bratislav.Fedorishina23@meta.ua", new DateTime(2022, 6, 14, 1, 4, 31, 656, DateTimeKind.Local).AddTicks(3299), "Добромисла", "Євенко", "8667139420", "Секретар", 19398.56m, "Savings Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 26, 7, 22, 4, 764, DateTimeKind.Local).AddTicks(8805), "Староміська майдан, 5, Південний Алевтин, Гвінея-Бісау", new DateTime(1943, 4, 24, 7, 0, 26, 943, DateTimeKind.Utc).AddTicks(7372), "Polina_Umanec@ukr.net", "Степан", "Сплюх", "канд. пед. наук", "5274910504", "Директор", 5068.23m, "Fresh" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 12, 18, 36, 24, 456, DateTimeKind.Local).AddTicks(8625), "Городоцька майдан, 51, Південний Петро, Мексика", new DateTime(1950, 8, 23, 1, 2, 27, 666, DateTimeKind.Utc).AddTicks(6650), "Lavrin.Osadko@meta.ua", "Тихон", "Глинська", "докт. філол. наук", "2648110942", "Прибиральник", 15189.08m, "Utah" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 7, 11, 0, 53, 45, 442, DateTimeKind.Local).AddTicks(3401), "Молодіжна майдан, 6, Конотоп, Португалія", new DateTime(1929, 1, 15, 4, 27, 24, 515, DateTimeKind.Utc).AddTicks(6716), "Panas.Korovyak@gmail.com", new DateTime(2024, 3, 21, 23, 9, 52, 474, DateTimeKind.Local).AddTicks(6495), "Панас", "Москаль", "докт. психол. наук", "0638112599", "Програміст", 18173.75m, "back-end" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 16, 22, 22, 0, 766, DateTimeKind.Local).AddTicks(9052), "Винників майдан, 058, Південний Будимир, Кабо-Верде", new DateTime(1978, 5, 7, 2, 21, 28, 682, DateTimeKind.Utc).AddTicks(3275), "Inna.Savicka@meta.ua", new DateTime(2021, 11, 4, 13, 18, 23, 751, DateTimeKind.Local).AddTicks(90), "Звенислав", "Верещук", "канд. пед. наук", "1239046836", 4569.96m, "Home" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 12, 19, 2, 44, 14, 256, DateTimeKind.Local).AddTicks(546), "Рудного майдан, 40, Східний Подолян, Ватикан", new DateTime(1948, 6, 8, 3, 6, 3, 874, DateTimeKind.Utc).AddTicks(8839), "Ustim_Yevenko91@i.ua", new DateTime(2020, 9, 8, 15, 3, 56, 543, DateTimeKind.Local).AddTicks(2319), "Василина", "Шамрило", "докт. і. наук", "5797431110", "Директор", 17539.45m, "programming" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 4, 1, 22, 16, 54, 386, DateTimeKind.Local).AddTicks(3341), "Вічева майдан, 8, Північний Гордій, Сан-Марино", new DateTime(1938, 7, 7, 23, 9, 49, 446, DateTimeKind.Utc).AddTicks(1579), "Zoya91@ukr.net", new DateTime(2021, 12, 18, 11, 21, 29, 894, DateTimeKind.Local).AddTicks(9110), "Соня", "Ємець", "канд. юрид. наук", "2488466939", "Прибиральник", 18570.93m, "Intelligent Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 3, 14, 32, 14, 312, DateTimeKind.Local).AddTicks(7576), "Зелена майдан, 02, Західний Альберт, Таджикистан", new DateTime(1962, 4, 22, 9, 25, 47, 106, DateTimeKind.Utc).AddTicks(911), "Olga.Shupik@i.ua", new DateTime(2021, 12, 27, 7, 44, 22, 848, DateTimeKind.Local).AddTicks(7599), "Алла", "Ногачевський", "канд. психол. наук", "8541479786", 1385.93m, "Toys" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 53, 38, 799, DateTimeKind.Local).AddTicks(8663), "пл. Стрийська, 308, Східний Артем, Буркіна-Фасо", new DateTime(1992, 5, 5, 15, 6, 16, 949, DateTimeKind.Utc).AddTicks(8860), "Bozhena82@gmail.com", new DateTime(2020, 2, 18, 7, 29, 18, 942, DateTimeKind.Local).AddTicks(370), "Земислав", "Шиян", "канд. юрид. наук", "5084793546", 6049.23m, "Turnpike" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 24, 14, 56, 59, 571, DateTimeKind.Local).AddTicks(7390), "проспект Городоцька, 238, Східний Панас, Сирія", new DateTime(1941, 7, 15, 20, 54, 24, 531, DateTimeKind.Utc).AddTicks(4579), "Sergii_Yukhno55@gmail.com", new DateTime(2019, 8, 2, 8, 40, 32, 434, DateTimeKind.Local).AddTicks(7306), "Світлана", "Павлів", "канд. політ. наук", "0790139414", 13245.25m, "circuit" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 15, 19, 43, 46, 872, DateTimeKind.Local).AddTicks(7026), "вул. Зелена, 8, Західний Артем, Колумбія", new DateTime(2003, 8, 19, 8, 0, 50, 188, DateTimeKind.Utc).AddTicks(5390), "Oleg52@meta.ua", "Брячислав", "Сушко", "докт. психол. наук", "6336074470", "Бухгалтер", 10328.98m, "Concrete" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 24, 5, 55, 47, 626, DateTimeKind.Local).AddTicks(3456), "пр. Зелена, 665, Черкаси, Бруней", new DateTime(1968, 3, 24, 20, 8, 4, 467, DateTimeKind.Utc).AddTicks(3416), "Zemislav.Kovalskii@gmail.com", "Доброслава", "Бутько", "докт. філос. наук", "2630148681", 17005.45m, "bypassing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 24, 2, 41, 47, 453, DateTimeKind.Local).AddTicks(8518), "вул. Стрийська, 36, Західний Орест, Гватемала", new DateTime(1951, 11, 20, 7, 4, 25, 617, DateTimeKind.Utc).AddTicks(7023), "Yeremii.Bondarenko75@ex.ua", new DateTime(2022, 4, 20, 18, 45, 31, 97, DateTimeKind.Local).AddTicks(5421), "Лук’ян", "Горова", "докт. техн. наук", "2868328243", "Директор", 10088.40m, "transmit" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 9, 3, 29, 29, 298, DateTimeKind.Local).AddTicks(7877), "Вузька майдан, 237, Херсон, Сирія", new DateTime(1962, 12, 21, 21, 51, 14, 260, DateTimeKind.Utc).AddTicks(5652), "Anton.Maistrenko@ex.ua", new DateTime(2024, 2, 12, 21, 3, 48, 809, DateTimeKind.Local).AddTicks(7178), "Ореста", "Горова", "канд. пед. наук", "1696372649", 12856.48m, "Universal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 2, 7, 11, 33, 15, 820, DateTimeKind.Local).AddTicks(9873), "Вічева майдан, 40, Львів, Македонія", new DateTime(1983, 9, 18, 23, 17, 52, 468, DateTimeKind.Utc).AddTicks(3028), "Khvalimir94@ex.ua", new DateTime(2020, 9, 22, 6, 35, 53, 456, DateTimeKind.Local).AddTicks(2490), "Володислав", "Могилевський", "докт. філол. наук", "6514344374", "Секретар", 11038.22m, "Books" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 11, 5, 22, 42, 10, 971, DateTimeKind.Local).AddTicks(3839), "пл. Молодіжна, 953, Сімферополь, Сомалі", new DateTime(1937, 5, 25, 2, 57, 52, 165, DateTimeKind.Utc).AddTicks(355), "Romena99@ex.ua", new DateTime(2021, 1, 7, 12, 15, 48, 739, DateTimeKind.Local).AddTicks(6976), "Броніслава", "Гойко", "докт. юрид. наук", "4224647151", "Секретар", 15740.47m, "Guadeloupe" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 14, 3, 40, 4, 909, DateTimeKind.Local).AddTicks(2804), "провулок Городоцька, 60, Конотоп, Ватикан", new DateTime(1938, 6, 12, 17, 22, 28, 679, DateTimeKind.Utc).AddTicks(9283), "Feodosiya.Unich@i.ua", "Олена", "Шестак", "проф.", "3663866834", "Директор", 13771.20m, "Club" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 5, 9, 16, 16, 17, 378, DateTimeKind.Local).AddTicks(7274), "Вузька майдан, 483, Одеса, Бенін", new DateTime(1990, 7, 20, 6, 36, 40, 960, DateTimeKind.Utc).AddTicks(5428), "Orislava.Vitryak@ex.ua", null, "Добромира", "Трясун", "6967442841", "Програміст", 6289.85m, "parse" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 21, 1, 16, 33, 887, DateTimeKind.Local).AddTicks(5899), "провулок Молодіжна, 73, Західний Захарій, Кабо-Верде", new DateTime(1951, 12, 6, 18, 8, 40, 446, DateTimeKind.Utc).AddTicks(1769), "Irma_Latan@gmail.com", null, "Братислав", "Луговий", "1758249297", "Бухгалтер", 11084.09m, "FTP" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 3, 20, 40, 0, 835, DateTimeKind.Local).AddTicks(8369), "Староміська майдан, 47, Південний Немир, Греція", new DateTime(1949, 4, 14, 0, 50, 50, 239, DateTimeKind.Utc).AddTicks(5375), "Irina_Voloshuk@meta.ua", new DateTime(2020, 5, 23, 6, 18, 38, 652, DateTimeKind.Local).AddTicks(5201), "Афанасія", "Василишина", "канд. філос. наук", "8343103736", 18710.14m, "sensor" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 4, 22, 22, 10, 25, 547, DateTimeKind.Local).AddTicks(6334), "площа Ліста, 3, Донецьк, Сейшельські Острови", new DateTime(1997, 10, 27, 15, 22, 45, 124, DateTimeKind.Utc).AddTicks(5479), "Mokrina_Semeshuk@e-mail.ua", new DateTime(2020, 2, 26, 7, 41, 24, 572, DateTimeKind.Local).AddTicks(9441), "Агрипина", "Білич", "канд. техн. наук", "0132735682", 5912.51m, "Steel" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 4, 22, 29, 40, 384, DateTimeKind.Local).AddTicks(2258), "Винників майдан, 50, Рівне, Ботсвана", new DateTime(1928, 2, 3, 12, 38, 11, 162, DateTimeKind.Utc).AddTicks(471), "Darii_Cushko@ukr.net", null, "Антоній", "Городоцький", "докт. психол. наук", "0420766152", "Секретар", 8200.74m, "HTTP" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 7, 18, 10, 3, 51, 707, DateTimeKind.Local).AddTicks(1637), "Ліста майдан, 137, Східний Горимир, Катар", new DateTime(1997, 9, 24, 3, 11, 5, 313, DateTimeKind.Utc).AddTicks(4057), "Lyubozar.Gladkivskii71@ukr.net", new DateTime(2019, 6, 10, 20, 42, 24, 615, DateTimeKind.Local).AddTicks(1641), "Марія", "Гришко", "канд. філол. наук", "7931526205", 18043.11m, "Coordinator" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 24, 6, 51, 32, 662, DateTimeKind.Local).AddTicks(7708), "Рудного майдан, 7, Південний Петро, Чилі", new DateTime(1935, 6, 30, 7, 33, 39, 412, DateTimeKind.Utc).AddTicks(9993), "Zemislav_Miloslavskii@ukr.net", new DateTime(2019, 12, 29, 12, 1, 57, 226, DateTimeKind.Local).AddTicks(4126), "Світлана", "Червоній", "канд. психол. наук", "1839198220", "Директор", 17950.13m, "Corporate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 8, 29, 12, 26, 25, 91, DateTimeKind.Local).AddTicks(4620), "проспект Рудного, 288, Західний Петро, Північна Корея", new DateTime(1958, 3, 11, 13, 28, 57, 751, DateTimeKind.Utc).AddTicks(1419), "Albert.Petrina79@e-mail.ua", new DateTime(2024, 2, 5, 0, 24, 27, 556, DateTimeKind.Local).AddTicks(1753), "Анатолія", "Прядун", "канд. пед. наук", "1418621956", 18581.58m, "Indiana" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 25, 57, 966, DateTimeKind.Local).AddTicks(8551), "Городоцька майдан, 4, Південний Всевлад, Кувейт", new DateTime(1997, 2, 2, 23, 4, 23, 630, DateTimeKind.Utc).AddTicks(9236), "Pilip.Tryasilo18@meta.ua", "Герасим", "Савицький", "докт. пед. наук", "3248017059", 1374.97m, "teal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 15, 13, 32, 2, 221, DateTimeKind.Local).AddTicks(7332), "Коліївщини майдан, 168, Львів, Італія", new DateTime(1984, 1, 5, 8, 34, 44, 40, DateTimeKind.Utc).AddTicks(6293), "Grigorii_Moskalyuk@ex.ua", new DateTime(2023, 8, 28, 0, 38, 50, 471, DateTimeKind.Local).AddTicks(7477), "Віліна", "Махно", "проф.", "2737435793", "Прибиральник", 1168.78m, "one-to-one" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 5, 23, 15, 24, 13, 530, DateTimeKind.Local).AddTicks(1185), "Ліста майдан, 261, Південний Олесь, Йорданія", new DateTime(1988, 9, 26, 19, 40, 14, 185, DateTimeKind.Utc).AddTicks(7602), "Yevgen.Yashuk72@i.ua", new DateTime(2023, 10, 10, 18, 11, 30, 153, DateTimeKind.Local).AddTicks(8570), "Святослав", "Левадовська", "канд. політ. наук", "2626859997", "Програміст", 9022.39m, "mint green" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 25, 10, 40, 19, 632, DateTimeKind.Local).AddTicks(9722), "площа Коліївщини, 411, Східний Станіслав, Об’єднані Арабські Емірати", new DateTime(2002, 10, 18, 3, 44, 35, 754, DateTimeKind.Utc).AddTicks(4041), "Bozhen19@ex.ua", null, "Арсеній", "Свидригайло", "проф.", "5725092701", "Бухгалтер", 13486.13m, "Sri Lanka Rupee" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 9, 30, 23, 57, 19, 896, DateTimeKind.Local).AddTicks(8228), "проспект Брюховичів, 8, Конотоп, Камерун", new DateTime(1951, 3, 12, 9, 12, 3, 818, DateTimeKind.Utc).AddTicks(4803), "Yustina63@yandex.ua", null, "Кий", "Бондаренко", "докт. філос. наук", "0562022104", "Директор", 12635.58m, "executive" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 25, 6, 8, 57, 130, DateTimeKind.Local).AddTicks(5161), "вулиця Брюховичів, 839, Єнакієве, Греція", new DateTime(1930, 6, 7, 5, 18, 22, 403, DateTimeKind.Utc).AddTicks(2706), "Vadim96@meta.ua", new DateTime(2024, 2, 17, 0, 59, 32, 28, DateTimeKind.Local).AddTicks(4187), "Світлана", "Гайдук", "канд. техн. наук", "0218330398", "Бухгалтер", 11427.09m, "Small Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 24, 13, 13, 9, 649, DateTimeKind.Local).AddTicks(8792), "вулиця Коліївщини, 29, Північний Олелько, Фіджі", new DateTime(1948, 6, 19, 11, 29, 2, 30, DateTimeKind.Utc).AddTicks(6841), "Vilina.Ivaniv51@yandex.ua", "Мусій", "Уманець", "канд. і. наук", "5222699495", "Бухгалтер", 5341.78m, "Advanced" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 4, 10, 18, 2, 7, 653, DateTimeKind.Local).AddTicks(8333), "Ліста майдан, 8, Алчевськ, Фінляндія", new DateTime(1980, 7, 14, 14, 31, 44, 680, DateTimeKind.Utc).AddTicks(8206), "Adam40@gmail.com", "Тихон", "Гриневська", "докт. юрид. наук", "7796513791", "Секретар", 19548.82m, "Incredible" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 12, 21, 7, 22, 36, 876, DateTimeKind.Local).AddTicks(6435), "пл. Молодіжна, 4, Черкаси, Папуа-Нова Гвінея", new DateTime(1973, 10, 27, 0, 32, 48, 385, DateTimeKind.Utc).AddTicks(3641), "Yaroslava.Cimbalistii88@meta.ua", new DateTime(2022, 11, 23, 21, 18, 16, 440, DateTimeKind.Local).AddTicks(4213), "Мусій", "Ткаченко", "канд. і. наук", "4098190980", 16644.92m, "Rustic Wooden Table" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 12, 28, 23, 52, 18, 259, DateTimeKind.Local).AddTicks(8053), "вул. Брюховичів, 5, Кіровоград, Багамські Острови", new DateTime(1991, 5, 25, 20, 14, 14, 638, DateTimeKind.Utc).AddTicks(6079), "Podolyan.Kandiba@ex.ua", new DateTime(2023, 6, 12, 11, 4, 6, 110, DateTimeKind.Local).AddTicks(129), "Братослав", "Тарасюк", "докт. психол. наук", "9390761423", "Директор", 4828.90m, "Multi-lateral" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 7, 7, 29, 53, 223, DateTimeKind.Local).AddTicks(9496), "Рудного майдан, 48, Південний Назар, Молдова", new DateTime(2000, 11, 24, 7, 8, 56, 464, DateTimeKind.Utc).AddTicks(7160), "Miroslava_Kovalska58@meta.ua", "Іванна", "Верещук", "докт. політ. наук", "4836252148", "Секретар", 9276.09m, "withdrawal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 13, 10, 50, 29, 984, DateTimeKind.Local).AddTicks(7063), "Стрийська майдан, 0, Горлівка, Болівія", new DateTime(1940, 1, 25, 7, 32, 51, 407, DateTimeKind.Utc).AddTicks(7348), "Lidiya.Lanovii@ukr.net", new DateTime(2024, 1, 3, 9, 20, 39, 996, DateTimeKind.Local).AddTicks(7267), "Аполлонія", "Поривай", "докт. політ. наук", "6313814657", "Програміст", 10042.00m, "Home Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 5, 13, 11, 9, 52, 200, DateTimeKind.Local).AddTicks(7548), "пр. Стрийська, 6, Східний Ізяслав, Ямайка", new DateTime(1944, 9, 16, 2, 53, 57, 713, DateTimeKind.Utc).AddTicks(7941), "Zoreslav.Demchishina@ukr.net", new DateTime(2022, 8, 12, 2, 11, 57, 337, DateTimeKind.Local).AddTicks(6824), "Аврора", "Милославська", "проф.", "9338669920", "Бухгалтер", 19129.43m, "Credit Card Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 1, 23, 7, 37, 959, DateTimeKind.Local).AddTicks(6739), "пл. Вузька, 992, Східний Дмитро, Маршаллові Острови", new DateTime(1971, 11, 21, 2, 36, 31, 619, DateTimeKind.Utc).AddTicks(2397), "Antoniya.Pavlishina@i.ua", "Білослав", "Марієвська", "докт. пед. наук", "7034885652", "Директор", 9921.52m, "1080p" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 17, 18, 46, 22, 541, DateTimeKind.Local).AddTicks(4886), "Зелена майдан, 72, Кам’янець-Подільський, Індія", new DateTime(1981, 3, 9, 6, 33, 0, 853, DateTimeKind.Utc).AddTicks(9222), "Marko_Splyukh33@gmail.com", new DateTime(2020, 8, 3, 6, 51, 13, 917, DateTimeKind.Local).AddTicks(9966), "Костянтин", "Ткаченко", "докт. філос. наук", "0263896316", "Директор", 11528.22m, "generate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 6, 10, 53, 24, 489, DateTimeKind.Local).AddTicks(9055), "провулок Рудного, 7, Північний Мстислав, Бурунді", new DateTime(2002, 7, 19, 14, 54, 29, 718, DateTimeKind.Utc).AddTicks(3989), "Antin.Polishuk52@ex.ua", new DateTime(2022, 4, 27, 18, 16, 39, 228, DateTimeKind.Local).AddTicks(8244), "Пантелеймон", "Третяк", "канд. і. наук", "2589574933", "Бухгалтер", 9753.39m, "Convertible Marks" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 5, 1, 12, 13, 920, DateTimeKind.Local).AddTicks(6541), "Рудного майдан, 773, Південний Аркадій, Сент-Люсія", new DateTime(2004, 3, 19, 9, 24, 40, 45, DateTimeKind.Utc).AddTicks(303), "Tetyana_Pogiba32@i.ua", "Олена", "Романів", "докт. філос. наук", "2605840225", 7506.35m, "connecting" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 2, 14, 15, 16, 171, DateTimeKind.Local).AddTicks(5530), "вул. Нижанківського, 74, Житомир, Малаві", new DateTime(1962, 11, 8, 11, 33, 23, 433, DateTimeKind.Utc).AddTicks(494), "Apollinariya.Khitrovo@meta.ua", new DateTime(2020, 8, 8, 1, 45, 47, 938, DateTimeKind.Local).AddTicks(4222), "Лада", "Калач", "доц.", "1860268451", 14622.91m, "back up" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 7, 5, 20, 3, 5, DateTimeKind.Local).AddTicks(7929), "пл. Зелена, 2, Південний Орхип, Австралія", new DateTime(1999, 2, 2, 2, 38, 12, 826, DateTimeKind.Utc).AddTicks(8975), "Sologub_Khitrovo@ukr.net", new DateTime(2020, 12, 1, 0, 43, 16, 247, DateTimeKind.Local).AddTicks(5098), "Милослава", "Семещук", "канд. філол. наук", "8605457461", "Секретар", 16179.98m, "payment" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 24, 7, 22, 32, 875, DateTimeKind.Local).AddTicks(8814), "пр. Рудного, 90, Південний Буревіст, Кувейт", new DateTime(1949, 9, 26, 15, 27, 40, 443, DateTimeKind.Utc).AddTicks(7509), "Vyacheslav.Balabukh29@ukr.net", "Ратимир", "Забіла", "докт. юрид. наук", "7882242576", "Бухгалтер", 13131.66m, "deposit" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 3, 7, 4, 28, 10, 39, DateTimeKind.Local).AddTicks(1163), "пров. Ліста, 16, Полтава, Конго", new DateTime(1978, 3, 4, 0, 8, 11, 622, DateTimeKind.Utc).AddTicks(4440), "Yarema14@e-mail.ua", new DateTime(2021, 10, 21, 17, 49, 18, 594, DateTimeKind.Local).AddTicks(991), "Пелагея", "Лобачевська", "канд. психол. наук", "7798994505", "Директор", 7820.57m, "Wooden" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 22, 16, 1, 25, 458, DateTimeKind.Local).AddTicks(3008), "Коліївщини майдан, 8, Суми, США", new DateTime(1971, 11, 3, 0, 43, 3, 172, DateTimeKind.Utc).AddTicks(873), "Nestor.Luchko@ukr.net", null, "Ксенія", "Саєнко", "докт. юрид. наук", "5528166751", "Бухгалтер", 4341.70m, "web services" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 12, 11, 9, 37, 12, 772, DateTimeKind.Local).AddTicks(963), "Брюховичів майдан, 22, Західний Тихон, Венесуела", new DateTime(1967, 6, 14, 1, 12, 9, 790, DateTimeKind.Utc).AddTicks(4249), "Ladomir27@ukr.net", new DateTime(2019, 6, 24, 9, 38, 39, 371, DateTimeKind.Local).AddTicks(3585), "Віталій", "Петрів", "проф.", "3403432999", 2154.15m, "generating" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 25, 643, DateTimeKind.Local).AddTicks(2863), "Брюховичів майдан, 21, Західний Герасим, Тринідад і Тобаго", new DateTime(1993, 5, 21, 2, 36, 7, 575, DateTimeKind.Utc).AddTicks(4752), "Dolyana.Luchko22@e-mail.ua", null, "Адріян", "Волощук", "канд. пед. наук", "5900174909", "Програміст", 2049.21m, "ivory" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 5, 12, 31, 43, 404, DateTimeKind.Local).AddTicks(8129), "пл. Вічева, 66, Західний Мирослав, Лаос", new DateTime(1947, 4, 21, 3, 44, 52, 407, DateTimeKind.Utc).AddTicks(9625), "Avgustin_Koman14@yandex.ua", new DateTime(2022, 3, 31, 2, 20, 56, 440, DateTimeKind.Local).AddTicks(9035), "Дарина", "Пригода", "докт. психол. наук", "2507904763", "Секретар", 2303.33m, "Future-proofed" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 1, 23, 46, 52, 508, DateTimeKind.Local).AddTicks(5298), "пров. Рудного, 1, Північний Олег, Нігер", new DateTime(1977, 10, 14, 17, 13, 31, 196, DateTimeKind.Utc).AddTicks(8771), "Zabava.Makoveckii@ukr.net", new DateTime(2022, 4, 29, 0, 50, 18, 448, DateTimeKind.Local).AddTicks(7623), "Святослава", "Дзюб’як", "доц.", "2062369468", "Бухгалтер", 10839.92m, "Response" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 29, 14, 21, 33, 894, DateTimeKind.Local).AddTicks(9390), "Коліївщини майдан, 01, Житомир, Еквадор", new DateTime(1996, 5, 24, 5, 47, 47, 177, DateTimeKind.Utc).AddTicks(2154), "Matvii_Golovec@gmail.com", "Злата", "Яцьків", "канд. філос. наук", "4150003736", "Прибиральник", 4116.94m, "withdrawal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 10, 1, 3, 39, 741, DateTimeKind.Local).AddTicks(7036), "Нижанківського майдан, 1, Чернівці, Багамські Острови", new DateTime(1992, 3, 4, 6, 52, 6, 413, DateTimeKind.Utc).AddTicks(6188), "Zhanna_Potebenko@i.ua", new DateTime(2019, 11, 18, 19, 53, 17, 531, DateTimeKind.Local).AddTicks(3802), "Влад", "Милославський", "канд. пед. наук", "1839230063", "Прибиральник", 14465.30m, "enable" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 28, 13, 34, 40, 295, DateTimeKind.Local).AddTicks(7568), "пл. Нижанківського, 56, Південний Лаврін, Литва", new DateTime(1994, 7, 22, 17, 22, 1, 224, DateTimeKind.Utc).AddTicks(6509), "Inna42@yandex.ua", "Ада", "Гриневська", "канд. психол. наук", "1844766041", "Прибиральник", 3500.66m, "Future-proofed" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 29, 22, 11, 18, 714, DateTimeKind.Local).AddTicks(7785), "Молодіжна майдан, 904, Західний Руслан, Німеччина", new DateTime(1995, 8, 17, 13, 52, 54, 765, DateTimeKind.Utc).AddTicks(8459), "Svyatoslava26@i.ua", null, "Стефаній", "Спотикач", "докт. і. наук", "3534478392", "Директор", 18999.74m, "Motorway" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 15, 3, 38, 0, 948, DateTimeKind.Local).AddTicks(7444), "пров. Рудного, 70, Артемівськ, Бруней", new DateTime(1994, 3, 3, 9, 40, 27, 903, DateTimeKind.Utc).AddTicks(7275), "Radmila.Gorodockii71@yandex.ua", new DateTime(2020, 2, 17, 11, 32, 26, 837, DateTimeKind.Local).AddTicks(8952), "Тиміш", "Василин", "докт. техн. наук", "5213834736", "Директор", 18224.63m, "Cotton" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 3, 6, 19, 41, 488, DateTimeKind.Local).AddTicks(2540), "вул. Городоцька, 1, Західний Горислав, Монголія", new DateTime(1931, 3, 8, 4, 49, 9, 898, DateTimeKind.Utc).AddTicks(1688), "Yulianna57@ex.ua", "Іван", "Миклухо", "доц.", "5974130332", "Програміст", 18333.78m, "Bedfordshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 11, 20, 15, 48, 16, 38, DateTimeKind.Local).AddTicks(2619), "проспект Зелена, 999, Ужгород, Ліберія", new DateTime(1973, 6, 17, 17, 18, 21, 578, DateTimeKind.Utc).AddTicks(2344), "Alina_Balakun@meta.ua", new DateTime(2019, 6, 8, 3, 36, 11, 212, DateTimeKind.Local).AddTicks(9140), "Ростислава", "Калач", "6843974709", 15584.97m, "Rustic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 24, 19, 5, 19, 714, DateTimeKind.Local).AddTicks(7895), "Староміська майдан, 53, Східний Тимофій, Саудівська Аравія", new DateTime(1961, 5, 28, 15, 17, 36, 807, DateTimeKind.Utc).AddTicks(1513), "Anfisa_Miloslavska2@meta.ua", new DateTime(2022, 3, 1, 1, 52, 16, 60, DateTimeKind.Local).AddTicks(5732), "Білослава", "Тарасюк", "докт. філол. наук", "5373370558", "Директор", 10467.11m, "Integration" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 11, 25, 3, 49, 18, 139, DateTimeKind.Local).AddTicks(1439), "вул. Молодіжна, 963, Західний Юрій, Албанія", new DateTime(1960, 4, 29, 2, 57, 27, 75, DateTimeKind.Utc).AddTicks(6767), "Kornii_Prigoda@e-mail.ua", null, "Сніжана", "Коваленко", "докт. політ. наук", "7129840369", "Прибиральник", 10154.33m, "grey" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 12, 4, 12, 34, 18, 113, DateTimeKind.Local).AddTicks(9742), "Ліста майдан, 68, Південний Тихон, Ірландія", new DateTime(1952, 3, 22, 3, 8, 23, 825, DateTimeKind.Utc).AddTicks(5024), "Rostislav61@i.ua", new DateTime(2020, 7, 20, 22, 44, 32, 754, DateTimeKind.Local).AddTicks(3526), "Ілля", "Ємець", "докт. техн. наук", "1563030975", 6096.07m, "purple" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 12, 8, 11, 39, 27, 526, DateTimeKind.Local).AddTicks(3451), "Городоцька майдан, 94, Мукачеве, Північна Корея", new DateTime(1949, 4, 1, 19, 56, 39, 388, DateTimeKind.Utc).AddTicks(2611), "Lavrentii6@yandex.ua", new DateTime(2020, 6, 3, 18, 52, 34, 532, DateTimeKind.Local).AddTicks(6747), "Добринка", "Корнїйчук", "7677393824", "Бухгалтер", 6446.66m, "web-readiness" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 10, 14, 38, 5, 889, DateTimeKind.Local).AddTicks(6971), "Рудного майдан, 807, Харків, Малі", new DateTime(1948, 12, 14, 15, 55, 48, 805, DateTimeKind.Utc).AddTicks(7121), "Lyubozar7@meta.ua", new DateTime(2023, 3, 14, 18, 18, 14, 877, DateTimeKind.Local).AddTicks(6318), "Альвіна", "Мазун", "докт. техн. наук", "2661836327", "Прибиральник", 9289.85m, "Metrics" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 4, 21, 4, 53, 56, 69, DateTimeKind.Local).AddTicks(8382), "Винників майдан, 39, Бердичів, Естонія", new DateTime(1993, 12, 2, 11, 23, 45, 878, DateTimeKind.Utc).AddTicks(9641), "Valentina.Moskalyuk@gmail.com", new DateTime(2020, 1, 14, 6, 52, 48, 632, DateTimeKind.Local).AddTicks(1598), "Оксана", "Миклухо", "докт. пед. наук", "6389137758", "Програміст", 8006.68m, "users" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 8, 8, 0, 51, 4, 374, DateTimeKind.Local).AddTicks(8810), "пров. Вузька, 9, Краматорськ, Танзанія", new DateTime(1999, 2, 21, 14, 47, 31, 674, DateTimeKind.Utc).AddTicks(6891), "Vilenina.Storozhuk@ukr.net", null, "Далеслава", "Петик", "проф.", "8689505698", "Бухгалтер", 2421.82m, "tan" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 16, 23, 41, 31, 411, DateTimeKind.Local).AddTicks(4565), "Ліста майдан, 4, Західний Аврелій, Боснія і Герцеговина", new DateTime(1988, 9, 29, 12, 36, 31, 639, DateTimeKind.Utc).AddTicks(3917), "Dobrinka.Grigorishin@meta.ua", "Назар", "Розпутня", "докт. політ. наук", "8942341826", "Програміст", 7272.44m, "Handmade Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 29, 8, 49, 36, 371, DateTimeKind.Local).AddTicks(4309), "Нижанківського майдан, 41, Краматорськ, Свазіленд", new DateTime(1989, 4, 1, 20, 6, 25, 496, DateTimeKind.Utc).AddTicks(8624), "Roman.Savicka@ukr.net", new DateTime(2022, 9, 24, 11, 21, 12, 117, DateTimeKind.Local).AddTicks(195), "Людомила", "Опенько", "докт. політ. наук", "6224895040", 1442.62m, "Tactics" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 28, 22, 25, 13, 903, DateTimeKind.Local).AddTicks(7676), "Коліївщини майдан, 7, Південний Гарнослав, Ірландія", new DateTime(1968, 6, 10, 3, 20, 38, 855, DateTimeKind.Utc).AddTicks(6556), "Agafiya.Romei75@ukr.net", null, "Юлія", "Миклашевський", "0787909323", "Директор", 9604.62m, "high-level" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 19, 23, 46, 26, 302, DateTimeKind.Local).AddTicks(4892), "вул. Вічева, 95, Біла Церква, Боснія і Герцеговина", new DateTime(1935, 10, 11, 2, 7, 45, 989, DateTimeKind.Utc).AddTicks(6967), "Dobroslava_Moskal49@ukr.net", null, "Щастислав", "Петренко", "докт. психол. наук", "3462036602", "Програміст", 9112.65m, "index" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 10, 14, 38, 30, 243, DateTimeKind.Local).AddTicks(5303), "Вузька майдан, 409, Конотоп, Намібія", new DateTime(2001, 1, 24, 14, 55, 1, 303, DateTimeKind.Utc).AddTicks(2071), "Solomiya.Ivanishin71@i.ua", new DateTime(2020, 2, 22, 15, 22, 22, 660, DateTimeKind.Local).AddTicks(5680), "Орхип", "Бутько", "канд. і. наук", "4749578911", 8093.10m, "interfaces" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 11, 24, 6, 57, 47, 490, DateTimeKind.Local).AddTicks(890), "площа Городоцька, 0, Миколаїв, Барбадос", new DateTime(1981, 5, 2, 10, 41, 46, 660, DateTimeKind.Utc).AddTicks(5056), "Afanasiya_Romanishina63@meta.ua", "Віра", "Москалюк", "канд. політ. наук", "9137865297", "Директор", 9737.05m, "Radial" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 44, 42, 551, DateTimeKind.Local).AddTicks(806), "вулиця Стрийська, 6, Артемівськ, Ісландія", new DateTime(1953, 11, 24, 3, 2, 0, 62, DateTimeKind.Utc).AddTicks(9084), "Rodoslav_Durdinec7@ex.ua", new DateTime(2023, 1, 7, 6, 0, 24, 449, DateTimeKind.Local).AddTicks(7895), "Юліан", "Галаєнко", "доц.", "5203376312", "Прибиральник", 11207.74m, "Awesome Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 19, 20, 55, 57, 832, DateTimeKind.Local).AddTicks(4092), "пл. Брюховичів, 201, Миколаїв, Ватикан", new DateTime(1985, 6, 9, 22, 57, 8, 326, DateTimeKind.Utc).AddTicks(3257), "Volodimir.Tretyak37@ex.ua", new DateTime(2019, 11, 5, 8, 22, 22, 639, DateTimeKind.Local).AddTicks(8666), "Ярополк", "Міняйло", "канд. техн. наук", "9410558779", "Програміст", 15887.65m, "Solomon Islands" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 9, 3, 9, 10, 51, 141, DateTimeKind.Local).AddTicks(4814), "Рудного майдан, 6, Західний Даромир, Бразилія", new DateTime(1926, 11, 30, 19, 6, 38, 715, DateTimeKind.Utc).AddTicks(6927), "Ladislav_Parashuk@ex.ua", new DateTime(2021, 2, 3, 23, 26, 6, 46, DateTimeKind.Local).AddTicks(1598), "Марина", "Скиба", "канд. філос. наук", "7720045811", "Програміст", 3938.93m, "virtual" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 5, 6, 23, 47, 16, 709, DateTimeKind.Local).AddTicks(206), "Ліста майдан, 448, Південний Зиновій, Словаччина", new DateTime(1994, 7, 19, 22, 37, 59, 128, DateTimeKind.Utc).AddTicks(3986), "Zvenislav24@gmail.com", "Макар", "Головець", "докт. політ. наук", "0642544642", "Бухгалтер", 10828.52m, "Intelligent Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 9, 24, 11, 46, 11, 812, DateTimeKind.Local).AddTicks(8836), "провулок Староміська, 07, Ужгород, Японія", new DateTime(2001, 10, 29, 4, 34, 57, 371, DateTimeKind.Utc).AddTicks(196), "Bilomir_Parashuk@yandex.ua", new DateTime(2023, 8, 30, 3, 59, 25, 916, DateTimeKind.Local).AddTicks(4998), "Лаврентій", "Лящук", "докт. філол. наук", "7204357507", "Прибиральник", 11413.00m, "Ameliorated" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 20, 10, 48, 44, 686, DateTimeKind.Local).AddTicks(4624), "Винників майдан, 7, Західний Злат, Північна Корея", new DateTime(1930, 7, 2, 20, 46, 48, 193, DateTimeKind.Utc).AddTicks(5385), "Viktor4@ukr.net", "Ярослав", "Сідляк", "докт. філос. наук", "1459720698", "Директор", 3734.51m, "back-end" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 11, 30, 6, 47, 29, 673, DateTimeKind.Local).AddTicks(4013), "Стрийська майдан, 99, Західний Боримир, Монако", new DateTime(1963, 4, 16, 21, 52, 29, 784, DateTimeKind.Utc).AddTicks(3648), "Nina.Gaiovii87@yandex.ua", new DateTime(2023, 4, 20, 22, 46, 38, 907, DateTimeKind.Local).AddTicks(3281), "Радміла", "Гаман", "канд. філос. наук", "9031677645", "Програміст", 19161.84m, "protocol" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 10, 20, 17, 4, 126, DateTimeKind.Local).AddTicks(6934), "площа Брюховичів, 56, Сєвєродонецьк, Тонга", new DateTime(1970, 2, 25, 10, 54, 6, 894, DateTimeKind.Utc).AddTicks(4212), "Kornilii.Koman@gmail.com", new DateTime(2021, 8, 2, 15, 41, 55, 197, DateTimeKind.Local).AddTicks(300), "Слава", "Майборода", "докт. юрид. наук", "2294884677", "Програміст", 19107.46m, "Berkshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 8, 4, 50, 21, 451, DateTimeKind.Local).AddTicks(4802), "проспект Ліста, 2, Бровари, Іспанія", new DateTime(1985, 12, 7, 8, 13, 34, 453, DateTimeKind.Utc).AddTicks(8972), "Artemiya12@ex.ua", new DateTime(2022, 1, 22, 6, 34, 39, 169, DateTimeKind.Local).AddTicks(2561), "Дана", "Ющук", "канд. юрид. наук", "3054518576", 11622.31m, "Kids" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 13, 14, 24, 57, 762, DateTimeKind.Local).AddTicks(6215), "Ліста майдан, 92, Сімферополь, Бразилія", new DateTime(1936, 1, 21, 3, 7, 17, 757, DateTimeKind.Utc).AddTicks(9830), "Kalina.Balakun72@ukr.net", null, "Августин", "Лахман", "докт. філол. наук", "6557079743", "Директор", 7871.94m, "Bedfordshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 5, 31, 20, 28, 6, 190, DateTimeKind.Local).AddTicks(3451), "площа Городоцька, 69, Ужгород, Іспанія", new DateTime(1929, 10, 17, 17, 4, 54, 56, DateTimeKind.Utc).AddTicks(9268), "Bogdan.Moskalyuk@gmail.com", null, "Ратибор", "Коров’як", "докт. і. наук", "6731966322", 12932.11m, "invoice" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 8, 4, 9, 8, 17, 96, DateTimeKind.Local).AddTicks(2754), "площа Городоцька, 5, Західний Антоній, Мексика", new DateTime(2005, 11, 26, 12, 53, 27, 783, DateTimeKind.Utc).AddTicks(5545), "Avreliya_Butko88@i.ua", new DateTime(2019, 7, 13, 21, 16, 7, 141, DateTimeKind.Local).AddTicks(1285), "Іннеса", "Головець", "докт. психол. наук", "2845041713", "Директор", 9109.35m, "Shores" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 16, 6, 9, 43, 810, DateTimeKind.Local).AddTicks(2872), "проспект Вузька, 1, Дніпропетровськ, Туреччина", new DateTime(1970, 8, 16, 17, 55, 50, 649, DateTimeKind.Utc).AddTicks(9043), "Ivanna.Glinska38@ukr.net", new DateTime(2021, 5, 25, 9, 35, 23, 672, DateTimeKind.Local).AddTicks(381), "Омелян", "Яцишин", "доц.", "8427305500", 18156.96m, "Senior" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 25, 5, 37, 24, 151, DateTimeKind.Local).AddTicks(472), "пр. Молодіжна, 324, Східний Данило, Об’єднані Арабські Емірати", new DateTime(1968, 10, 19, 16, 49, 31, 257, DateTimeKind.Utc).AddTicks(5430), "Pelagiya.Gamula32@meta.ua", null, "Станіслав", "Забіла", "канд. політ. наук", "0307830216", 14238.03m, "Metal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 11, 15, 33, 45, 573, DateTimeKind.Local).AddTicks(901), "Вічева майдан, 8, Мукачеве, Японія", new DateTime(2004, 11, 12, 2, 41, 5, 114, DateTimeKind.Utc).AddTicks(197), "Oles.Gordiichuk59@ex.ua", "Ярополк", "Шиндарей", "канд. філос. наук", "2671000546", "Програміст", 8381.45m, "Credit Card Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 10, 17, 10, 7, 463, DateTimeKind.Local).AddTicks(216), "пров. Рудного, 8, Вінниця, Марокко", new DateTime(1938, 5, 10, 20, 42, 41, 763, DateTimeKind.Utc).AddTicks(8508), "Kharitina8@i.ua", "Майя", "Городоцька", "6893540120", "Програміст", 8852.20m, "payment" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 22, 9, 57, 52, 740, DateTimeKind.Local).AddTicks(703), "Винників майдан, 80, Північний Стожар, Сомалі", new DateTime(1950, 9, 10, 4, 26, 51, 54, DateTimeKind.Utc).AddTicks(4666), "Ivanna12@i.ua", "Горислав", "Балабуха", "докт. політ. наук", "1383842742", "Секретар", 15233.12m, "cross-platform" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 11, 7, 18, 27, 32, 879, DateTimeKind.Local).AddTicks(5915), "Коліївщини майдан, 21, Північний Анатолій, Польща", new DateTime(1979, 7, 3, 15, 35, 49, 863, DateTimeKind.Utc).AddTicks(6373), "Virginiya75@meta.ua", new DateTime(2023, 8, 16, 14, 31, 14, 110, DateTimeKind.Local).AddTicks(4937), "Крентта", "Дзюб’як", "докт. пед. наук", "5852209780", 9599.00m, "paradigm" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 11, 25, 5, 29, 41, 311, DateTimeKind.Local).AddTicks(1726), "Молодіжна майдан, 7, Західний Родіон, Саудівська Аравія", new DateTime(1926, 11, 12, 9, 44, 13, 190, DateTimeKind.Utc).AddTicks(3829), "Viktoriya.Minyailo25@e-mail.ua", "Максим", "Довгалевський", "проф.", "9853138522", "Секретар", 8076.20m, "THX" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 9, 1, 40, 57, 772, DateTimeKind.Local).AddTicks(6006), "проспект Ліста, 75, Південний Святополк, Грузія", new DateTime(1945, 8, 29, 2, 43, 6, 858, DateTimeKind.Utc).AddTicks(38), "Sofiya_Troyan35@ex.ua", new DateTime(2019, 11, 12, 1, 23, 24, 526, DateTimeKind.Local).AddTicks(6076), "Мечислава", "Прядун", "канд. юрид. наук", "1372937973", "Прибиральник", 4269.62m, "Future" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 18, 11, 0, 59, 443, DateTimeKind.Local).AddTicks(9006), "вул. Городоцька, 1, Південний Синьоок, Гамбія", new DateTime(1991, 9, 20, 16, 47, 51, 204, DateTimeKind.Utc).AddTicks(7579), "Mechislava.Sayenko35@i.ua", new DateTime(2021, 3, 23, 12, 54, 6, 686, DateTimeKind.Local).AddTicks(2996), "Юліанна", "Сосюра", "канд. юрид. наук", "3445293768", 11392.47m, "benchmark" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 4, 13, 5, 53, 200, DateTimeKind.Local).AddTicks(6339), "Староміська майдан, 909, Львів, Маршаллові Острови", new DateTime(1968, 10, 5, 12, 16, 1, 42, DateTimeKind.Utc).AddTicks(2613), "Kupava3@meta.ua", new DateTime(2022, 10, 27, 14, 1, 38, 982, DateTimeKind.Local).AddTicks(8023), "Юхимія", "Сплюх", "докт. техн. наук", "8975922498", "Директор", 8317.67m, "Baby, Baby & Games" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 31, 2, 43, 3, 153, DateTimeKind.Local).AddTicks(3883), "пл. Рудного, 74, Західний Радимир, Ефіопія", new DateTime(1949, 12, 25, 4, 52, 49, 893, DateTimeKind.Utc).AddTicks(1410), "Artemiya.Stoyan33@meta.ua", "Звенислава", "Бабух", "канд. техн. наук", "6584717513", 3761.32m, "back-end" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 9, 25, 9, 21, 51, 72, DateTimeKind.Local).AddTicks(6108), "Ліста майдан, 40, Дніпропетровськ, Камерун", new DateTime(1935, 11, 8, 19, 14, 20, 682, DateTimeKind.Utc).AddTicks(5280), "Oles_Korovyak99@yandex.ua", null, "Доброслава", "Ліхно", "докт. пед. наук", "6809824382", 4025.84m, "Concrete" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 18, 2, 23, 35, 523, DateTimeKind.Local).AddTicks(2059), "пр. Брюховичів, 989, Дніпродзержинськ, Сербія", new DateTime(1951, 12, 31, 23, 7, 12, 134, DateTimeKind.Utc).AddTicks(7738), "Dobromir_Korecka89@i.ua", null, "Тарас", "Бамбула", "докт. техн. наук", "0436024192", "Директор", 15833.96m, "Oklahoma" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 31, 14, 684, DateTimeKind.Local).AddTicks(6659), "пр. Стрийська, 58, Херсон, Вануату", new DateTime(1979, 10, 2, 9, 29, 5, 210, DateTimeKind.Utc).AddTicks(2362), "Vyacheslav_Pryadun@gmail.com", "Гаврило", "Ковальський", "канд. політ. наук", "5064543767", "Директор", 15475.61m, "client-server" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 15, 20, 28, 21, 603, DateTimeKind.Local).AddTicks(3515), "Зелена майдан, 9, Єнакієве, Папуа-Нова Гвінея", new DateTime(1929, 6, 16, 2, 23, 33, 263, DateTimeKind.Utc).AddTicks(1609), "Lyuborada_Pendik@gmail.com", new DateTime(2019, 6, 6, 11, 10, 17, 523, DateTimeKind.Local).AddTicks(9548), "Ярополк", "Миклашевський", "канд. і. наук", "9822583394", "Програміст", 12800.48m, "Squares" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 11, 12, 21, 54, 2, 222, DateTimeKind.Local).AddTicks(3928), "Зелена майдан, 2, Горлівка, Бруней", new DateTime(1992, 5, 8, 19, 48, 56, 471, DateTimeKind.Utc).AddTicks(3897), "Vlada.Porivailo@e-mail.ua", new DateTime(2020, 6, 11, 17, 11, 42, 884, DateTimeKind.Local).AddTicks(3480), "Юстина", "Сучак", "канд. психол. наук", "1559608975", "Бухгалтер", 19127.40m, "benchmark" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 14, 13, 25, 25, 147, DateTimeKind.Local).AddTicks(4231), "Вузька майдан, 1, Західний Адріян, Маршаллові Острови", new DateTime(1940, 10, 21, 21, 12, 15, 709, DateTimeKind.Utc).AddTicks(7793), "Boleslava_Yarmak@e-mail.ua", new DateTime(2021, 3, 12, 5, 31, 35, 405, DateTimeKind.Local).AddTicks(6091), "Велемир", "Міняйло", "канд. філос. наук", "2383923970", "Директор", 10996.33m, "Viaduct" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 9, 25, 5, 13, 33, 259, DateTimeKind.Local).AddTicks(9854), "площа Брюховичів, 09, Північний Ратимир, Норвегія", new DateTime(1928, 8, 27, 12, 10, 24, 407, DateTimeKind.Utc).AddTicks(6403), "Albert_Petrenko52@gmail.com", "Любомир", "Лящук", "докт. і. наук", "1640773215", "Прибиральник", 14944.16m, "hub" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 21, 19, 55, 22, 785, DateTimeKind.Local).AddTicks(656), "Вузька майдан, 97, Кіровоград, Гана", new DateTime(1992, 2, 1, 12, 31, 54, 526, DateTimeKind.Utc).AddTicks(6978), "Yulian57@gmail.com", "Альбіна", "Марків", "канд. психол. наук", "6286644507", "Прибиральник", 13289.16m, "River" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 9, 5, 25, 44, 307, DateTimeKind.Local).AddTicks(6622), "Староміська майдан, 1, Південний Володислав, Мавританія", new DateTime(1984, 7, 25, 8, 53, 21, 4, DateTimeKind.Utc).AddTicks(457), "Malva_Savickii@gmail.com", "Матвій", "Тарасюк", "докт. політ. наук", "1922858860", 6778.87m, "Balboa" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 9, 19, 1, 4, 12, 300, DateTimeKind.Local).AddTicks(1470), "проспект Стрийська, 4, Східний Маркіян, Науру", new DateTime(1953, 8, 11, 5, 51, 27, 305, DateTimeKind.Utc).AddTicks(7636), "Arkhip37@i.ua", new DateTime(2020, 3, 26, 17, 32, 29, 669, DateTimeKind.Local).AddTicks(5882), "Віліна", "Гнатишина", "канд. техн. наук", "6871357047", "Секретар", 18935.78m, "De-engineered" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 19, 9, 57, 58, 152, DateTimeKind.Local).AddTicks(5755), "вул. Коліївщини, 185, Лисичанськ, Індія", new DateTime(1958, 9, 11, 11, 13, 36, 353, DateTimeKind.Utc).AddTicks(6083), "Olelko_Shevchenko@i.ua", null, "Аврора", "Шестак", "канд. юрид. наук", "7416289486", 19219.81m, "SQL" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 11, 11, 4, 48, 220, DateTimeKind.Local).AddTicks(8547), "пр. Винників, 83, Західний Орхип, Ємен", new DateTime(1967, 1, 16, 11, 54, 50, 306, DateTimeKind.Utc).AddTicks(1712), "Lavrin_Shudrik@ex.ua", null, "Ладислав", "Шкараба", "проф.", "9120476339", 4068.04m, "next generation" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 11, 23, 23, 21, 18, 280, DateTimeKind.Local).AddTicks(3593), "Вузька майдан, 09, Макіївка, Словенія", new DateTime(1959, 9, 22, 8, 0, 25, 794, DateTimeKind.Utc).AddTicks(7275), "Kornilii_Balakun94@e-mail.ua", null, "Тихон", "Негода", "докт. психол. наук", "8721217249", "Директор", 8853.63m, "user-facing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 5, 9, 10, 39, 185, DateTimeKind.Local).AddTicks(3298), "пр. Стрийська, 108, Миколаїв, Кабо-Верде", new DateTime(1943, 8, 20, 14, 30, 45, 683, DateTimeKind.Utc).AddTicks(9068), "Yukhim21@meta.ua", null, "Родослав", "Іванишин", "докт. і. наук", "6053358171", "Прибиральник", 13178.06m, "Mountain" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 2, 19, 19, 53, 35, 767, DateTimeKind.Local).AddTicks(2910), "проспект Стрийська, 1, Східний Антоній, Болгарія", new DateTime(1971, 4, 1, 3, 19, 51, 845, DateTimeKind.Utc).AddTicks(6836), "Antin.Pavliv91@meta.ua", null, "Милослава", "Сплюх", "докт. філос. наук", "9567364281", "Секретар", 13028.25m, "Virtual" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 16, 0, 18, 52, 447, DateTimeKind.Local).AddTicks(9796), "пров. Вічева, 662, Південний Денис, Сент-Люсія", new DateTime(1963, 5, 11, 4, 27, 59, 113, DateTimeKind.Utc).AddTicks(5282), "Afanasiya56@e-mail.ua", "Людмила", "Скиба", "канд. пед. наук", "3031172160", "Програміст", 13182.95m, "Outdoors & Jewelery" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 17, 4, 28, 39, 448, DateTimeKind.Local).AddTicks(6878), "Стрийська майдан, 0, Східний Орхип, Киргизстан", new DateTime(1942, 1, 16, 11, 59, 31, 81, DateTimeKind.Utc).AddTicks(3974), "Vasilina.Spotikach@ex.ua", "Яна", "Тарасюк", "докт. пед. наук", "0456249300", "Директор", 2063.35m, "Creative" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 11, 14, 59, 22, 640, DateTimeKind.Local).AddTicks(3317), "пр. Староміська, 470, Східний Буревіст, Фіджі", new DateTime(1947, 8, 10, 19, 59, 50, 84, DateTimeKind.Utc).AddTicks(1929), "Listvich_Boyarchuk44@i.ua", "Тарас", "Гарай", "канд. і. наук", "6991136296", "Прибиральник", 6081.12m, "invoice" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 9, 7, 29, 40, 590, DateTimeKind.Local).AddTicks(5991), "вул. Молодіжна, 30, Кременчук, Ліберія", new DateTime(1929, 12, 13, 12, 5, 17, 728, DateTimeKind.Utc).AddTicks(4411), "Artemiya69@e-mail.ua", null, "Білослав", "Вітряк", "канд. пед. наук", "3258871765", "Бухгалтер", 2099.68m, "Mountains" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 18, 8, 18, 28, 66, DateTimeKind.Local).AddTicks(4653), "пр. Городоцька, 15, Миколаїв, Свазіленд", new DateTime(1991, 10, 31, 14, 10, 39, 723, DateTimeKind.Utc).AddTicks(8005), "Ladomir.Grishko@e-mail.ua", null, "Даромир", "Кордун", "канд. і. наук", "8492064253", "Прибиральник", 16135.32m, "Object-based" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 1, 23, 27, 50, 345, DateTimeKind.Local).AddTicks(8562), "проспект Ліста, 42, Південний Тиміш, Алжир", new DateTime(1971, 1, 21, 5, 23, 11, 274, DateTimeKind.Utc).AddTicks(7621), "Katerina47@e-mail.ua", null, "Людмила", "Зінкевич", "5090671021", "Директор", 8004.18m, "parse" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 3, 18, 7, 5, 44, 426, DateTimeKind.Local).AddTicks(8905), "провулок Стрийська, 2, Південний Градимир, Бангладеш", new DateTime(1994, 3, 30, 12, 39, 39, 742, DateTimeKind.Utc).AddTicks(2206), "Anna.Golovec69@gmail.com", null, "Долеслава", "Притула", "канд. психол. наук", "4124756901", "Бухгалтер", 2383.75m, "Swiss Franc" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 4, 0, 59, 20, 579, DateTimeKind.Local).AddTicks(3311), "провулок Вічева, 970, Миколаїв, Велика Британія", new DateTime(1966, 12, 24, 23, 28, 30, 633, DateTimeKind.Utc).AddTicks(5630), "Agafiya52@ex.ua", null, "Синьоок", "Бурмило", "канд. політ. наук", "5967957401", "Прибиральник", 12673.91m, "calculating" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 12, 20, 51, 53, 33, DateTimeKind.Local).AddTicks(3565), "вул. Винників, 569, Східний Ярослав, Ефіопія", new DateTime(1994, 3, 19, 7, 19, 10, 127, DateTimeKind.Utc).AddTicks(9785), "Denis82@meta.ua", null, "Тихон", "Забіла", "4497603370", "Прибиральник", 3207.99m, "Multi-lateral" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 16, 18, 46, 23, 295, DateTimeKind.Local).AddTicks(4885), "Вічева майдан, 3, Східний Ілля, Кот-д’Івуар", new DateTime(1984, 7, 31, 0, 4, 11, 588, DateTimeKind.Utc).AddTicks(3350), "Rostislav34@e-mail.ua", new DateTime(2020, 10, 13, 15, 36, 19, 160, DateTimeKind.Local).AddTicks(6787), "Августин", "Башук", "канд. філол. наук", "3348286938", "Директор", 8724.25m, "Dynamic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 7, 19, 20, 21, 12, 747, DateTimeKind.Local).AddTicks(1693), "провулок Винників, 1, Північний Юліан, Афганістан", new DateTime(1927, 9, 5, 5, 29, 55, 969, DateTimeKind.Utc).AddTicks(226), "Rayisa.Chervonii42@i.ua", new DateTime(2020, 1, 18, 19, 50, 0, 873, DateTimeKind.Local).AddTicks(5985), "Анастасія", "Гладух", "докт. філол. наук", "8655853123", "Бухгалтер", 1034.27m, "JSON" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 28, 3, 38, 20, 791, DateTimeKind.Local).AddTicks(2895), "проспект Брюховичів, 576, Київ, Самоа", new DateTime(1974, 3, 19, 3, 26, 38, 75, DateTimeKind.Utc).AddTicks(6116), "Dobromira43@ex.ua", new DateTime(2020, 12, 29, 10, 13, 40, 601, DateTimeKind.Local).AddTicks(5336), "Ладо", "Коломієць", "канд. філол. наук", "4491354017", "Прибиральник", 11426.13m, "Small Rubber Shoes" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 12, 3, 21, 15, 14, 756, DateTimeKind.Local).AddTicks(2794), "вулиця Стрийська, 178, Шостка, Кувейт", new DateTime(1984, 2, 26, 11, 25, 22, 93, DateTimeKind.Utc).AddTicks(1581), "Chornota31@gmail.com", new DateTime(2022, 12, 27, 3, 54, 5, 9, DateTimeKind.Local).AddTicks(7888), "Синьоок", "Пригода", "докт. юрид. наук", "0725132583", "Програміст", 7685.28m, "SQL" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 1, 20, 30, 31, 599, DateTimeKind.Local).AddTicks(5309), "Коліївщини майдан, 5, Маріуполь, Гондурас", new DateTime(1986, 3, 2, 22, 37, 44, 740, DateTimeKind.Utc).AddTicks(9243), "Burevist.Kivach@ex.ua", new DateTime(2023, 12, 18, 7, 30, 22, 164, DateTimeKind.Local).AddTicks(7658), "Горимир", "Петренко", "канд. пед. наук", "1812202895", "Програміст", 8673.96m, "cross-platform" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 12, 4, 10, 34, 541, DateTimeKind.Local).AddTicks(2999), "Винників майдан, 980, Східний Яровид, Східний Тимор", new DateTime(1938, 4, 15, 20, 47, 48, 108, DateTimeKind.Utc).AddTicks(5003), "Lukyan58@ex.ua", new DateTime(2019, 4, 24, 23, 0, 55, 895, DateTimeKind.Local).AddTicks(6169), "Євген", "Юхно", "канд. психол. наук", "3059181855", "Прибиральник", 2116.44m, "withdrawal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 5, 17, 7, 17, 23, 819, DateTimeKind.Local).AddTicks(4544), "вулиця Староміська, 705, Артемівськ, Іспанія", new DateTime(1973, 4, 10, 3, 27, 1, 559, DateTimeKind.Utc).AddTicks(8440), "Listvich.Motriyenko98@ukr.net", null, "Артемія", "Негода", "канд. і. наук", "2412258998", "Директор", 3802.94m, "evolve" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 2, 21, 6, 10, 770, DateTimeKind.Local).AddTicks(4887), "Ліста майдан, 783, Рівне, Маврикій", new DateTime(1934, 5, 13, 4, 45, 4, 627, DateTimeKind.Utc).AddTicks(2991), "Orisya_Romenec83@e-mail.ua", new DateTime(2023, 10, 10, 23, 17, 29, 386, DateTimeKind.Local).AddTicks(4584), "Агата", "Ткаченко", "докт. юрид. наук", "6966704394", "Програміст", 4111.81m, "Forest" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 3, 25, 23, 54, 5, 928, DateTimeKind.Local).AddTicks(1199), "Зелена майдан, 908, Північний Славолюб, Швеція", new DateTime(1996, 5, 21, 10, 59, 58, 273, DateTimeKind.Utc).AddTicks(6919), "Kornelii.Sidlecka@meta.ua", null, "Олеся", "Барановська", "канд. і. наук", "9647819370", 9341.56m, "Handmade Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 14, 5, 22, 35, 757, DateTimeKind.Local).AddTicks(5868), "пров. Коліївщини, 78, Північний Натан, Тринідад і Тобаго", new DateTime(1943, 3, 31, 19, 42, 8, 84, DateTimeKind.Utc).AddTicks(4963), "Apolloniya_Rozputnya@meta.ua", new DateTime(2023, 4, 17, 9, 10, 41, 68, DateTimeKind.Local).AddTicks(7881), "Орхип", "Петик", "докт. юрид. наук", "8046101871", "Бухгалтер", 18424.82m, "alarm" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 12, 29, 6, 13, 52, 285, DateTimeKind.Local).AddTicks(7282), "Вузька майдан, 43, Східний Валерій, Домініка", new DateTime(1953, 2, 13, 12, 52, 27, 708, DateTimeKind.Utc).AddTicks(4062), "Azarii.Svidrigailo@gmail.com", new DateTime(2022, 6, 24, 10, 9, 30, 944, DateTimeKind.Local).AddTicks(7690), "Щек", "Верещук", "канд. психол. наук", "8516029267", "Прибиральник", 19673.74m, "Internal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 10, 17, 50, 11, 204, DateTimeKind.Local).AddTicks(1561), "Брюховичів майдан, 334, Південний Юліан, Сент-Кітс і Невіс", new DateTime(1936, 5, 17, 7, 17, 1, 199, DateTimeKind.Utc).AddTicks(5030), "Sonya20@gmail.com", new DateTime(2021, 8, 24, 17, 53, 5, 525, DateTimeKind.Local).AddTicks(1479), "Антонида", "Бердник", "5639376108", "Директор", 1829.70m, "auxiliary" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 3, 1, 10, 56, 682, DateTimeKind.Local).AddTicks(7335), "Нижанківського майдан, 2, Горлівка, Японія", new DateTime(1941, 11, 6, 20, 8, 37, 654, DateTimeKind.Utc).AddTicks(1143), "Daleslava45@ukr.net", null, "Адріана", "Унич", "докт. філос. наук", "6798619142", "Директор", 9417.41m, "tan" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 4, 2, 8, 2, 5, 658, DateTimeKind.Local).AddTicks(8002), "Рудного майдан, 67, Східний Гаврило, Білорусь", new DateTime(1986, 4, 20, 16, 54, 56, 410, DateTimeKind.Utc).AddTicks(8581), "Bozhemir.Yermak@ex.ua", null, "Лаврін", "Бабух", "докт. політ. наук", "9040101580", "Прибиральник", 3455.94m, "Reduced" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 3, 16, 21, 10, 569, DateTimeKind.Local).AddTicks(8309), "пл. Стрийська, 693, Західний Панас, Сент-Кітс і Невіс", new DateTime(1962, 9, 22, 0, 37, 0, 437, DateTimeKind.Utc).AddTicks(3849), "Orkhip.Kandiba@yandex.ua", new DateTime(2019, 5, 27, 13, 3, 37, 912, DateTimeKind.Local).AddTicks(1792), "Ірма", "Осадко", "канд. пед. наук", "5257656629", "Секретар", 18303.77m, "Soft" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 16, 9, 18, 42, 378, DateTimeKind.Local).AddTicks(1335), "пр. Вічева, 25, Східний Родіон, Словаччина", new DateTime(1964, 10, 5, 1, 56, 41, 713, DateTimeKind.Utc).AddTicks(4589), "Gennadii.Yalyuk@meta.ua", "Благовіста", "Галаціон", "докт. і. наук", "6231396280", "Бухгалтер", 11387.92m, "SDD" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 13, 0, 39, 12, 589, DateTimeKind.Local).AddTicks(497), "Нижанківського майдан, 5, Північний Тимофій, Словаччина", new DateTime(1996, 6, 5, 14, 49, 18, 394, DateTimeKind.Utc).AddTicks(4940), "Igor_Storozhuk@e-mail.ua", new DateTime(2020, 11, 26, 6, 51, 37, 364, DateTimeKind.Local).AddTicks(2128), "Панас", "Негода", "канд. юрид. наук", "9751150545", "Секретар", 4744.95m, "driver" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 16, 5, 36, 43, 155, DateTimeKind.Local).AddTicks(8768), "провулок Вузька, 417, Ялта, Канада", new DateTime(2002, 6, 25, 19, 30, 58, 490, DateTimeKind.Utc).AddTicks(8603), "Vilena_Stigailo@i.ua", "Слава", "Лящук", "канд. психол. наук", "3233480101", "Директор", 1675.02m, "morph" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 11, 21, 5, 27, 57, 507, DateTimeKind.Local).AddTicks(6404), "Молодіжна майдан, 503, Севастополь, Куба", new DateTime(1940, 6, 16, 13, 42, 42, 420, DateTimeKind.Utc).AddTicks(9843), "Avreliya_Andrukhovich94@ukr.net", null, "Добромисл", "Ногачевський", "докт. політ. наук", "7032871849", "Секретар", 9963.84m, "workforce" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 9, 7, 16, 15, 52, 685, DateTimeKind.Local).AddTicks(8149), "Ліста майдан, 765, Кам’янець-Подільський, Намібія", new DateTime(1937, 4, 14, 0, 34, 53, 288, DateTimeKind.Utc).AddTicks(4410), "Darii72@ex.ua", new DateTime(2021, 9, 21, 15, 12, 9, 840, DateTimeKind.Local).AddTicks(9163), "Віра", "Ящук", "канд. пед. наук", "3897713840", 3850.54m, "copying" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 18, 15, 56, 45, 237, DateTimeKind.Local).AddTicks(7407), "Староміська майдан, 726, Шостка, Домініка", new DateTime(1946, 5, 28, 16, 58, 56, 976, DateTimeKind.Utc).AddTicks(7579), "Kornilo_Ganich@i.ua", new DateTime(2022, 10, 23, 21, 36, 29, 277, DateTimeKind.Local).AddTicks(6365), "Оксана", "Петренко", "доц.", "4993643111", "Бухгалтер", 11911.48m, "Croatia" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 30, 0, 31, 58, 81, DateTimeKind.Local).AddTicks(5631), "Ліста майдан, 96, Черкаси, Кабо-Верде", new DateTime(2002, 11, 2, 6, 27, 56, 600, DateTimeKind.Utc).AddTicks(9647), "Valentin.Magera@ex.ua", new DateTime(2019, 6, 15, 11, 49, 4, 507, DateTimeKind.Local).AddTicks(2366), "Крентта", "Бондаренко", "докт. і. наук", "9813073464", "Програміст", 1951.13m, "RSS" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 12, 23, 23, 5, 19, 514, DateTimeKind.Local).AddTicks(2724), "Молодіжна майдан, 024, Південний Добромисл, Албанія", new DateTime(1951, 10, 18, 6, 40, 41, 1, DateTimeKind.Utc).AddTicks(2992), "Bozhen45@yandex.ua", null, "Єремій", "Щербак", "9655614561", "Прибиральник", 4035.92m, "Credit Card Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 16, 9, 11, 42, 295, DateTimeKind.Local).AddTicks(5607), "Рудного майдан, 6, Південний Хорив, Парагвай", new DateTime(1981, 1, 22, 11, 52, 19, 757, DateTimeKind.Utc).AddTicks(8284), "Irina36@ex.ua", "Вілена", "Міняйло", "докт. і. наук", "2360801170", "Прибиральник", 14570.02m, "Fresh" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 16, 6, 27, 59, 69, DateTimeKind.Local).AddTicks(3920), "Стрийська майдан, 884, Чернівці, Беліз", new DateTime(2005, 8, 21, 2, 33, 50, 642, DateTimeKind.Utc).AddTicks(3663), "Alla.Sirko87@gmail.com", null, "Антонія", "Дурдинець", "проф.", "1367110056", "Бухгалтер", 19701.35m, "Agent" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 15, 9, 40, 36, 0, DateTimeKind.Local).AddTicks(4225), "пл. Вічева, 650, Східний Лад, Албанія", new DateTime(1945, 10, 23, 23, 15, 28, 346, DateTimeKind.Utc).AddTicks(1468), "Vitalina.Dzyubyak@ukr.net", new DateTime(2022, 5, 1, 13, 25, 57, 909, DateTimeKind.Local).AddTicks(9867), "Захар", "Ковальський", "канд. філос. наук", "8223639951", "Секретар", 10269.67m, "B2C" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 26, 5, 7, 45, 834, DateTimeKind.Local).AddTicks(4908), "Староміська майдан, 654, Західний Афанасій, Бутан", new DateTime(1964, 4, 19, 16, 50, 42, 820, DateTimeKind.Utc).AddTicks(6679), "Roksolana3@e-mail.ua", null, "Борислава", "Паламарчук", "докт. філол. наук", "2689353654", "Прибиральник", 18194.78m, "clicks-and-mortar" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 20, 17, 19, 32, 584, DateTimeKind.Local).AddTicks(6213), "вулиця Молодіжна, 0, Південний Антін, Суринам", new DateTime(1992, 6, 8, 17, 40, 9, 913, DateTimeKind.Utc).AddTicks(8865), "Nemira.Suchak@gmail.com", new DateTime(2020, 6, 16, 4, 7, 39, 266, DateTimeKind.Local).AddTicks(7288), "Зореслава", "Лящук", "канд. пед. наук", "8552875519", "Програміст", 1081.19m, "ubiquitous" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 22, 7, 4, 56, 540, DateTimeKind.Local).AddTicks(5235), "вул. Брюховичів, 69, Східний Антін, Філіппіни", new DateTime(1959, 3, 17, 0, 45, 32, 96, DateTimeKind.Utc).AddTicks(4185), "Dobromisla8@meta.ua", new DateTime(2020, 7, 4, 18, 11, 50, 208, DateTimeKind.Local).AddTicks(7508), "Агнія", "Силецька", "докт. філос. наук", "6617440857", "Директор", 11923.24m, "copying" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 4, 23, 51, 30, 452, DateTimeKind.Local).AddTicks(8766), "Вузька майдан, 56, Південний Лаврін, Азербайджан", new DateTime(1958, 9, 9, 17, 23, 17, 923, DateTimeKind.Utc).AddTicks(2402), "Boguslava.Gamula49@meta.ua", "Любозар", "Скоропадська", "доц.", "8084605877", "Прибиральник", 12294.12m, "CFA Franc BCEAO" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 3, 18, 15, 23, 21, 709, DateTimeKind.Local).AddTicks(306), "пр. Молодіжна, 3, Вінниця, Гаїті", new DateTime(1982, 5, 24, 8, 14, 19, 781, DateTimeKind.Utc).AddTicks(2520), "Viktor.Vasilkivskii@yandex.ua", new DateTime(2021, 7, 19, 7, 2, 10, 688, DateTimeKind.Local).AddTicks(2477), "Іван", "Роменець", "канд. пед. наук", "0603643111", "Бухгалтер", 5654.41m, "seamless" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 2, 1, 1, 14, 433, DateTimeKind.Local).AddTicks(3512), "вул. Вузька, 39, Єнакієве, Центральноафриканська Республіка", new DateTime(1983, 5, 13, 11, 37, 45, 144, DateTimeKind.Utc).AddTicks(3806), "Bronislava40@e-mail.ua", new DateTime(2020, 10, 25, 16, 29, 18, 659, DateTimeKind.Local).AddTicks(5824), "Квітослава", "Гордійчук", "проф.", "1260670011", 2965.46m, "Alaska" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 12, 11, 5, 13, 14, DateTimeKind.Local).AddTicks(918), "проспект Городоцька, 4, Чернівці, Латвія", new DateTime(1940, 1, 24, 5, 57, 54, 490, DateTimeKind.Utc).AddTicks(5386), "Yarema_Boyarchuk@meta.ua", null, "Даромир", "Корнїйчук", "докт. і. наук", "4558720413", 2438.03m, "Bedfordshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 15, 16, 58, 13, 289, DateTimeKind.Local).AddTicks(6149), "пл. Рудного, 3, Західний Анастас, Іран", new DateTime(1999, 4, 11, 19, 59, 17, 756, DateTimeKind.Utc).AddTicks(9337), "Bratislav_Boyarchuk0@ukr.net", new DateTime(2023, 5, 23, 7, 6, 24, 877, DateTimeKind.Local).AddTicks(3112), "Анатолій", "Павленко", "докт. пед. наук", "2630061837", "Директор", 1632.34m, "Licensed" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 15, 9, 3, 33, 699, DateTimeKind.Local).AddTicks(9146), "Городоцька майдан, 6, Південний Вадим, Нікарагуа", new DateTime(1969, 7, 8, 8, 26, 58, 925, DateTimeKind.Utc).AddTicks(9229), "Zlatomir0@gmail.com", new DateTime(2023, 6, 30, 0, 0, 56, 677, DateTimeKind.Local).AddTicks(3951), "Корнило", "Кононець", "докт. політ. наук", "5031690338", "Бухгалтер", 14857.14m, "uniform" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 28, 20, 0, 4, 633, DateTimeKind.Local).AddTicks(2981), "вулиця Брюховичів, 604, Південний Ратибор, Чилі", new DateTime(1970, 2, 15, 10, 24, 40, 534, DateTimeKind.Utc).AddTicks(8834), "Nazar_Sherbak@yandex.ua", new DateTime(2023, 1, 31, 23, 48, 24, 631, DateTimeKind.Local).AddTicks(619), "Станислава", "Павлишина", "докт. пед. наук", "8782279915", "Бухгалтер", 17746.48m, "encoding" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 25, 16, 30, 30, 635, DateTimeKind.Local).AddTicks(7705), "Стрийська майдан, 17, Мелітополь, Швейцарія", new DateTime(1944, 5, 9, 1, 56, 57, 695, DateTimeKind.Utc).AddTicks(2408), "Valerii_Mazun55@ukr.net", new DateTime(2022, 5, 2, 15, 38, 2, 992, DateTimeKind.Local).AddTicks(4983), "Марко", "Левадовський", "доц.", "0337567300", "Секретар", 18789.24m, "New Mexico" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 20, 26, 998, DateTimeKind.Local).AddTicks(477), "Стрийська майдан, 4, Запоріжжя, Коста-Рика", new DateTime(1966, 1, 4, 22, 15, 37, 880, DateTimeKind.Utc).AddTicks(7375), "Oleksandr73@ex.ua", new DateTime(2022, 1, 18, 13, 12, 14, 59, DateTimeKind.Local).AddTicks(2667), "Оріяна", "Боровська", "канд. психол. наук", "9472311321", "Програміст", 12128.38m, "Optimization" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 30, 11, 46, 20, 211, DateTimeKind.Local).AddTicks(5059), "Винників майдан, 32, Південний Левко, Еквадор", new DateTime(1976, 10, 8, 19, 1, 35, 952, DateTimeKind.Utc).AddTicks(5546), "Nataliya11@e-mail.ua", new DateTime(2020, 4, 6, 21, 27, 29, 696, DateTimeKind.Local).AddTicks(2206), "Білослава", "Миклашевський", "канд. політ. наук", "9875687924", "Секретар", 18338.13m, "Rustic Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 9, 29, 2, 29, 28, 774, DateTimeKind.Local).AddTicks(9587), "Староміська майдан, 79, Південний Кузьма, Андорра", new DateTime(1929, 3, 10, 13, 32, 12, 742, DateTimeKind.Utc).AddTicks(5977), "Levko_Burmilo@meta.ua", new DateTime(2020, 7, 24, 22, 59, 47, 793, DateTimeKind.Local).AddTicks(8688), "Ілона", "Білич", "канд. політ. наук", "6873789597", "Бухгалтер", 6282.24m, "payment" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 27, 5, 28, 32, 183, DateTimeKind.Local).AddTicks(334), "проспект Ліста, 905, Севастополь, Сирія", new DateTime(1982, 2, 13, 21, 19, 42, 604, DateTimeKind.Utc).AddTicks(9070), "Zvenimir72@ukr.net", new DateTime(2021, 12, 1, 3, 49, 25, 374, DateTimeKind.Local).AddTicks(3390), "Всеволод", "Палій", "канд. філол. наук", "3695402530", "Директор", 14271.24m, "Kuwaiti Dinar" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 4, 21, 13, 48, 9, 930, DateTimeKind.Local).AddTicks(6028), "пров. Вічева, 176, Харків, Чилі", new DateTime(1964, 4, 18, 8, 9, 33, 827, DateTimeKind.Utc).AddTicks(2412), "Adam72@yandex.ua", new DateTime(2020, 9, 2, 12, 46, 36, 546, DateTimeKind.Local).AddTicks(8920), "Наталія", "Янюк", "доц.", "7888855029", "Секретар", 10499.90m, "Czech Republic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 4, 15, 33, 20, 186, DateTimeKind.Local).AddTicks(1075), "Вічева майдан, 145, Східний Ладомир, Швеція", new DateTime(1978, 7, 2, 3, 12, 54, 912, DateTimeKind.Utc).AddTicks(2973), "Sergii_Splyukh@meta.ua", new DateTime(2020, 9, 1, 12, 26, 7, 584, DateTimeKind.Local).AddTicks(3613), "Орина", "Гришко", "докт. техн. наук", "9762402160", "Програміст", 10300.68m, "Martinique" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 17, 20, 23, 19, 558, DateTimeKind.Local).AddTicks(2454), "Зелена майдан, 240, Олександрія, Федеративні Штати Мікронезії", new DateTime(1980, 11, 8, 21, 7, 25, 683, DateTimeKind.Utc).AddTicks(2240), "Biloslav.Cimbalistii84@ex.ua", null, "В’ячеслава", "Корецький", "докт. філол. наук", "9430647844", 1353.00m, "Chief" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 6, 3, 4, 12, 913, DateTimeKind.Local).AddTicks(6129), "Коліївщини майдан, 3, Західний Потап, Антигуа і Барбуда", new DateTime(1951, 7, 10, 21, 3, 2, 986, DateTimeKind.Utc).AddTicks(4825), "Panas.Yermak@meta.ua", "Назарій", "Опенько", "докт. політ. наук", "0453128209", "Директор", 11049.19m, "Mauritius" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 6, 23, 51, 42, 455, DateTimeKind.Local).AddTicks(8678), "Староміська майдан, 575, Південний Алевтин, Сент-Люсія", new DateTime(1969, 7, 21, 17, 42, 55, 278, DateTimeKind.Utc).AddTicks(8708), "Mechislav.Vasilishina@yandex.ua", "Божемир", "Шудрик", "7068889847", "Бухгалтер", 11020.62m, "maroon" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 5, 3, 3, 58, 32, 430, DateTimeKind.Local).AddTicks(8521), "провулок Рудного, 3, Кривий Ріг, Болівія", new DateTime(1934, 10, 25, 13, 37, 52, 940, DateTimeKind.Utc).AddTicks(9961), "Daleslava80@e-mail.ua", new DateTime(2023, 12, 31, 11, 22, 42, 504, DateTimeKind.Local).AddTicks(8647), "Данило", "Паламарчук", "канд. філос. наук", "7687272330", "Секретар", 11974.42m, "functionalities" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 5, 4, 35, 19, 398, DateTimeKind.Local).AddTicks(2704), "Рудного майдан, 36, Шостка, Сент-Кітс і Невіс", new DateTime(1945, 11, 14, 8, 11, 26, 178, DateTimeKind.Utc).AddTicks(6598), "Zhanna63@ex.ua", "Юхима", "Шупик", "докт. політ. наук", "6053624429", 18228.88m, "Intelligent" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 8, 5, 2, 27, 9, 834, DateTimeKind.Local).AddTicks(3569), "Коліївщини майдан, 3, Північний Зорян, Іран", new DateTime(1973, 11, 15, 12, 58, 46, 558, DateTimeKind.Utc).AddTicks(6434), "Lukyan58@yandex.ua", new DateTime(2019, 8, 7, 13, 14, 36, 833, DateTimeKind.Local).AddTicks(7441), "Зборислав", "Білич", "докт. і. наук", "2860089409", 19919.78m, "Cook Islands" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 27, 23, 47, 6, 192, DateTimeKind.Local).AddTicks(6020), "Вічева майдан, 7, Бердянськ, Сербія", new DateTime(1986, 2, 5, 16, 10, 38, 72, DateTimeKind.Utc).AddTicks(8131), "Lyubomila_Malkovich75@gmail.com", new DateTime(2019, 11, 30, 7, 29, 25, 453, DateTimeKind.Local).AddTicks(32), "Любава", "Шкараба", "канд. філол. наук", "1727284862", "Секретар", 12070.97m, "Tasty Plastic Bike" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 9, 7, 11, 28, 26, 25, DateTimeKind.Local).AddTicks(4038), "пл. Брюховичів, 356, Північний Данило, Велика Британія", new DateTime(1970, 9, 11, 0, 20, 7, 382, DateTimeKind.Utc).AddTicks(4613), "Afanasii.Miloslavska@e-mail.ua", new DateTime(2021, 11, 22, 19, 6, 46, 522, DateTimeKind.Local).AddTicks(5824), "Оріяна", "Прядун", "канд. психол. наук", "0036340994", "Програміст", 2305.43m, "deposit" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 8, 21, 35, 42, 649, DateTimeKind.Local).AddTicks(9897), "вул. Зелена, 806, Горлівка, Мальта", new DateTime(2002, 10, 26, 1, 40, 50, 539, DateTimeKind.Utc).AddTicks(2850), "Vasilina.Koman12@meta.ua", new DateTime(2021, 3, 9, 13, 36, 55, 891, DateTimeKind.Local).AddTicks(6244), "Горимир", "Тарасюк", "докт. політ. наук", "9198488112", "Прибиральник", 7178.64m, "quantifying" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 30, 9, 42, 59, 350, DateTimeKind.Local).AddTicks(4837), "Винників майдан, 967, Східний Михайло, Люксембург", new DateTime(1963, 6, 24, 18, 10, 11, 486, DateTimeKind.Utc).AddTicks(4029), "Orisya27@ukr.net", new DateTime(2022, 9, 8, 10, 33, 14, 559, DateTimeKind.Local).AddTicks(2095), "Ладислав", "Майстренко", "6469592014", "Програміст", 6525.93m, "synergize" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 21, 22, 26, 33, 160, DateTimeKind.Local).AddTicks(6030), "площа Вузька, 542, Західний Руслан, Куба", new DateTime(2006, 3, 25, 20, 50, 26, 546, DateTimeKind.Utc).AddTicks(5633), "Lavrin58@i.ua", new DateTime(2021, 3, 28, 13, 32, 47, 286, DateTimeKind.Local).AddTicks(7667), "Дмитро", "Лученко", "докт. політ. наук", "7873678370", "Прибиральник", 1032.59m, "Rustic Granite Hat" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 1, 6, 13, 17, 31, 779, DateTimeKind.Local).AddTicks(6768), "вул. Брюховичів, 1, Вінниця, Сінгапур", new DateTime(1954, 7, 29, 14, 18, 19, 300, DateTimeKind.Utc).AddTicks(9832), "Motrya43@e-mail.ua", null, "Харитина", "Стигайло", "канд. пед. наук", "3839797555", "Програміст", 12383.13m, "Supervisor" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 30, 10, 51, 40, 553, DateTimeKind.Local).AddTicks(6014), "Вічева майдан, 4, Євпаторія, Зімбабве", new DateTime(1930, 4, 30, 5, 5, 41, 138, DateTimeKind.Utc).AddTicks(3529), "Antonida_Troyan72@i.ua", "Мілана", "Бамбула", "докт. і. наук", "6152239762", "Секретар", 1836.27m, "convergence" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 1, 5, 23, 35, 39, 754, DateTimeKind.Local).AddTicks(1364), "Стрийська майдан, 06, Маріуполь, Чехія", new DateTime(1929, 3, 2, 12, 29, 55, 7, DateTimeKind.Utc).AddTicks(2755), "Bilomir_Sidlecka@gmail.com", new DateTime(2023, 8, 20, 1, 56, 52, 113, DateTimeKind.Local).AddTicks(6049), "Григорій", "Потебенько", "проф.", "4247973511", "Секретар", 5957.60m, "South Carolina" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 9, 24, 9, 27, 21, 551, DateTimeKind.Local).AddTicks(6389), "Городоцька майдан, 045, Єнакієве, Ангола", new DateTime(1985, 10, 19, 23, 12, 54, 24, DateTimeKind.Utc).AddTicks(4225), "Oles16@yandex.ua", null, "Ірина", "Коцюбинська", "канд. філол. наук", "8516007629", "Секретар", 5679.75m, "Villages" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 4, 2, 20, 1, 11, 398, DateTimeKind.Local).AddTicks(9168), "Молодіжна майдан, 072, Олександрія, В’єтнам", new DateTime(1949, 12, 22, 5, 28, 11, 467, DateTimeKind.Utc).AddTicks(6006), "Gelena_Demkiv@yandex.ua", "Нестор", "Сірко", "канд. філос. наук", "7369558298", "Секретар", 17437.28m, "service-desk" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 18, 2, 6, 56, 629, DateTimeKind.Local).AddTicks(4261), "вулиця Рудного, 86, Північний Любомир, Лесото", new DateTime(1939, 3, 29, 21, 50, 52, 864, DateTimeKind.Utc).AddTicks(8193), "Antin1@ex.ua", null, "Корній", "Трясун", "докт. і. наук", "1438839184", "Програміст", 8871.19m, "North Dakota" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 16, 8, 56, 2, 792, DateTimeKind.Local).AddTicks(4077), "Рудного майдан, 45, Ужгород, Данія", new DateTime(1932, 4, 17, 12, 42, 42, 615, DateTimeKind.Utc).AddTicks(2045), "Melaniya.Romanishin@ukr.net", new DateTime(2020, 12, 25, 10, 2, 10, 598, DateTimeKind.Local).AddTicks(8927), "Далеслава", "Гаман", "канд. філос. наук", "8285241367", "Бухгалтер", 12207.76m, "cross-platform" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 2, 19, 3, 43, 782, DateTimeKind.Local).AddTicks(4288), "пл. Зелена, 6, Західний Ростислав, Македонія", new DateTime(1991, 9, 1, 14, 1, 35, 598, DateTimeKind.Utc).AddTicks(9544), "Yukhima23@gmail.com", null, "Леся", "Ліхно", "проф.", "4666048103", "Програміст", 1178.49m, "tertiary" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 9, 18, 22, 18, 373, DateTimeKind.Local).AddTicks(3018), "пр. Брюховичів, 7, Західний Хвалимир, Пакистан", new DateTime(1951, 1, 3, 0, 25, 14, 13, DateTimeKind.Utc).AddTicks(3991), "Apollinariya63@ex.ua", "Станіслав", "Павлів", "докт. філос. наук", "6652220726", "Бухгалтер", 14894.09m, "Garden" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 10, 11, 48, 56, 891, DateTimeKind.Local).AddTicks(9580), "вулиця Староміська, 0, Північний Орхип, Люксембург", new DateTime(1929, 7, 25, 18, 15, 48, 712, DateTimeKind.Utc).AddTicks(2820), "Sonya33@yandex.ua", new DateTime(2019, 4, 24, 3, 44, 37, 947, DateTimeKind.Local).AddTicks(2592), "Зореслав", "Громико", "канд. філол. наук", "4373251353", "Програміст", 19870.10m, "Lead" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 3, 30, 7, 27, 54, 337, DateTimeKind.Local).AddTicks(9227), "Вузька майдан, 157, Західний Щастислав, Австрія", new DateTime(1992, 7, 18, 21, 8, 33, 387, DateTimeKind.Utc).AddTicks(644), "Tetyana_Romanishina@ukr.net", new DateTime(2019, 8, 26, 18, 38, 33, 500, DateTimeKind.Local).AddTicks(1600), "Таїсія", "Данилишин", "7932655944", "Прибиральник", 8968.54m, "Ergonomic Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 2, 25, 23, 8, 33, 188, DateTimeKind.Local).AddTicks(2881), "пр. Ліста, 2, Північний Зборислав, Фіджі", new DateTime(1933, 5, 3, 15, 53, 45, 516, DateTimeKind.Utc).AddTicks(7152), "Bryachislav.Karpukh34@i.ua", new DateTime(2019, 6, 4, 23, 37, 1, 108, DateTimeKind.Local).AddTicks(4201), "Ольга", "Городоцька", "доц.", "1004773406", "Секретар", 1815.92m, "Alabama" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 25, 15, 16, 42, 222, DateTimeKind.Local).AddTicks(9484), "провулок Городоцька, 895, Олександрія, Литва", new DateTime(1927, 8, 11, 0, 39, 11, 992, DateTimeKind.Utc).AddTicks(822), "Radmila45@meta.ua", null, "Поліна", "Петренко", "докт. пед. наук", "5464511619", "Бухгалтер", 16387.03m, "wireless" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 20, 14, 28, 8, 634, DateTimeKind.Local).AddTicks(1716), "Вузька майдан, 18, Сєвєродонецьк, Гаїті", new DateTime(1948, 5, 4, 22, 24, 44, 492, DateTimeKind.Utc).AddTicks(6530), "Antoniya.Lucka30@i.ua", "Віталій", "Бабух", "докт. і. наук", "4249607526", "Програміст", 8626.92m, "superstructure" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 31, 11, 35, 35, 244, DateTimeKind.Local).AddTicks(7331), "Винників майдан, 32, Південний Лаврентій, Російська Федерація", new DateTime(1982, 5, 28, 16, 10, 0, 141, DateTimeKind.Local).AddTicks(5752), "Adriana28@i.ua", null, "Марія", "Петрів", "8906350051", "Бухгалтер", 14305.28m, "matrix" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 16, 14, 48, 0, 960, DateTimeKind.Local).AddTicks(4652), "Городоцька майдан, 447, Південний Будимир, Туреччина", new DateTime(1955, 3, 27, 7, 37, 46, 802, DateTimeKind.Local).AddTicks(3033), "Velemir_Likovich0@i.ua", null, "Влад", "Ялюк", "канд. політ. наук", "1145935550", "Секретар", 18840.09m, "Phased" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 12, 24, 7, 29, 41, 313, DateTimeKind.Local).AddTicks(8073), "вулиця Городоцька, 869, Запоріжжя, Данія", new DateTime(1995, 2, 8, 3, 49, 9, 705, DateTimeKind.Local).AddTicks(5960), "Sergii41@ex.ua", "Оріяна", "Волощук", "канд. політ. наук", "4575333791", "Програміст", 18598.91m, "bandwidth" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 9, 30, 15, 53, 14, 482, DateTimeKind.Local).AddTicks(2170), "пр. Вузька, 87, Західний Геннадій, Ямайка", new DateTime(2021, 5, 23, 11, 6, 58, 19, DateTimeKind.Local).AddTicks(759), "Orislava44@gmail.com", null, "Добринка", "Петренко", "канд. політ. наук", "5275002887", 16687.48m, "Auto Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 8, 29, 5, 6, 15, 542, DateTimeKind.Local).AddTicks(3377), "Стрийська майдан, 260, Північний Орхип, Боснія і Герцеговина", new DateTime(2011, 10, 8, 3, 38, 37, 789, DateTimeKind.Local).AddTicks(4147), "Borimisl_Gaiovii@meta.ua", "Максим", "Демчишин", "докт. пед. наук", "3193103035", "Директор", 12627.15m, "efficient" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 8, 13, 1, 16, 385, DateTimeKind.Local).AddTicks(8580), "Городоцька майдан, 7, Макіївка, Монголія", new DateTime(1968, 2, 13, 18, 58, 31, 192, DateTimeKind.Local).AddTicks(3196), "Kvitoslava.Pavlenko51@ex.ua", new DateTime(2019, 6, 17, 14, 18, 28, 708, DateTimeKind.Local).AddTicks(14), "Августин", "Лахман", "доц.", "8536909853", "Директор", 8155.12m, "Engineer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 11, 18, 54, 25, 316, DateTimeKind.Local).AddTicks(202), "провулок Рудного, 087, Дніпропетровськ, Іран", new DateTime(1954, 1, 17, 2, 17, 9, 957, DateTimeKind.Local).AddTicks(1663), "Agniya_Yemec@e-mail.ua", "Доляна", "Малкович", "докт. пед. наук", "5820952819", "Бухгалтер", 9287.63m, "generating" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 15, 22, 23, 27, 45, DateTimeKind.Local).AddTicks(4902), "Коліївщини майдан, 57, Західний Любомир, Еритрея", new DateTime(2005, 9, 23, 12, 33, 30, 476, DateTimeKind.Local).AddTicks(253), "Lyubava51@i.ua", new DateTime(2019, 10, 28, 0, 39, 23, 906, DateTimeKind.Local).AddTicks(2086), "Герасим", "Ломовий", "докт. психол. наук", "0573202047", "Директор", 13130.51m, "Corners" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 8, 17, 6, 43, 16, 270, DateTimeKind.Local).AddTicks(1258), "площа Брюховичів, 6, Західний Боримир, Канада", new DateTime(1981, 2, 6, 0, 28, 29, 654, DateTimeKind.Local).AddTicks(1063), "Rayina_Galayenko@meta.ua", new DateTime(2020, 9, 12, 21, 6, 44, 909, DateTimeKind.Local).AddTicks(9979), "Марія", "Трясило", "канд. і. наук", "1838203011", "Бухгалтер", 17610.17m, "Ergonomic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 26, 5, 57, 39, 785, DateTimeKind.Local).AddTicks(4202), "Рудного майдан, 0, Чернігів, Туніс", new DateTime(1970, 2, 17, 17, 37, 29, 507, DateTimeKind.Local).AddTicks(3155), "Buitur.Polishuk@yandex.ua", null, "Добринка", "Третяк", "канд. філос. наук", "9483292427", 9549.10m, "user-facing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 14, 1, 29, 38, 622, DateTimeKind.Local).AddTicks(8223), "Брюховичів майдан, 231, Південний Петро, Сент-Вінсент і Гренадини", new DateTime(2017, 3, 17, 6, 6, 55, 971, DateTimeKind.Local).AddTicks(2560), "Solomiya.Makhno@gmail.com", "Агата", "Лящук", "докт. юрид. наук", "9530401426", "Директор", 16594.71m, "hacking" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 28, 16, 50, 18, 306, DateTimeKind.Local).AddTicks(1540), "вул. Коліївщини, 6, Сімферополь, Австралія", new DateTime(1960, 6, 1, 17, 1, 20, 512, DateTimeKind.Local).AddTicks(2015), "Zabava_Luchko@i.ua", new DateTime(2022, 1, 15, 20, 19, 0, 752, DateTimeKind.Local).AddTicks(7448), "Родіон", "Галаєнко", "докт. техн. наук", "4374170022", 10258.11m, "rich" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 25, 13, 59, 7, 39, DateTimeKind.Local).AddTicks(6979), "вулиця Зелена, 74, Північний Степан, Центральноафриканська Республіка", new DateTime(2014, 8, 28, 0, 4, 3, 184, DateTimeKind.Local).AddTicks(2539), "Ruslan_Suchak@ukr.net", null, "Назарій", "Волощук", "докт. пед. наук", "4626352899", "Директор", 2450.90m, "parsing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 30, 8, 41, 24, 402, DateTimeKind.Local).AddTicks(4975), "Городоцька майдан, 6, Дніпродзержинськ, Бангладеш", new DateTime(1957, 10, 19, 9, 41, 55, 620, DateTimeKind.Local).AddTicks(5582), "Orest_Kornyiichuk80@meta.ua", new DateTime(2020, 12, 16, 14, 21, 44, 324, DateTimeKind.Local).AddTicks(9121), "Агафія", "Гладух", "канд. психол. наук", "1861008651", "Програміст", 7059.04m, "Frozen" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 25, 16, 5, 54, 748, DateTimeKind.Local).AddTicks(1142), "проспект Брюховичів, 533, Північний Адам, Південний Судан", new DateTime(1954, 1, 22, 1, 12, 22, 536, DateTimeKind.Local).AddTicks(2474), "Zabava9@ukr.net", "Людомила", "Лучко", "докт. і. наук", "6428171716", "Директор", 10757.19m, "Cambridgeshire" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 5, 14, 19, 19, 11, 306, DateTimeKind.Local).AddTicks(7343), "вул. Зелена, 5, Нікополь, Туреччина", new DateTime(2008, 2, 19, 21, 24, 36, 777, DateTimeKind.Local).AddTicks(3745), "Pilip_Sherbak40@gmail.com", new DateTime(2023, 12, 16, 7, 15, 13, 158, DateTimeKind.Local).AddTicks(9039), "Ярослав", "Латанський", "докт. техн. наук", "7774568531", 13806.78m, "Tasty" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 7, 19, 12, 29, 42, 486, DateTimeKind.Local).AddTicks(7434), "Вічева майдан, 36, Львів, Лаос", new DateTime(1956, 10, 29, 2, 23, 14, 888, DateTimeKind.Local).AddTicks(1111), "Valentina.Mazilo@yandex.ua", "Сологуб", "Романишин", "проф.", "6163142665", "Бухгалтер", 11888.56m, "Greece" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 30, 2, 57, 26, 11, DateTimeKind.Local).AddTicks(209), "Брюховичів майдан, 7, Західний Борис, Джибуті", new DateTime(2023, 1, 11, 23, 18, 25, 969, DateTimeKind.Local).AddTicks(868), "Zvenigor.Marinich13@gmail.com", "Олесь", "Гарун", "канд. філос. наук", "3785450003", "Прибиральник", 13273.01m, "panel" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 17, 12, 34, 33, 266, DateTimeKind.Local).AddTicks(5525), "проспект Ліста, 6, Одеса, Угорщина", new DateTime(1963, 1, 2, 2, 54, 54, 894, DateTimeKind.Local).AddTicks(5480), "Stefanii.Tryasun99@gmail.com", null, "Крентта", "Євенко", "канд. політ. наук", "6327532576", "Директор", 15264.77m, "matrix" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 22, 17, 49, 4, 740, DateTimeKind.Local).AddTicks(4529), "площа Ліста, 97, Алчевськ, Східний Тимор", new DateTime(1953, 9, 29, 16, 36, 8, 359, DateTimeKind.Local).AddTicks(9622), "Olena93@ukr.net", new DateTime(2019, 5, 27, 12, 23, 24, 151, DateTimeKind.Local).AddTicks(1721), "Галина", "Розпутній", "канд. політ. наук", "7554309657", 10527.57m, "SCSI" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 4, 29, 19, 30, 50, 36, DateTimeKind.Local).AddTicks(1255), "вулиця Зелена, 83, Львів, Вірменія", new DateTime(2005, 5, 25, 8, 16, 56, 705, DateTimeKind.Local).AddTicks(1089), "Orina.Yushik52@gmail.com", new DateTime(2019, 9, 22, 18, 55, 31, 957, DateTimeKind.Local).AddTicks(9860), "Назарій", "Люта", "докт. пед. наук", "5548445218", "Секретар", 19362.75m, "Awesome Steel Towels" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 12, 9, 12, 54, 85, DateTimeKind.Local).AddTicks(6009), "пл. Вічева, 1, Одеса, Антигуа і Барбуда", new DateTime(1983, 5, 16, 2, 21, 22, 499, DateTimeKind.Local).AddTicks(4787), "Borislava.Korovyak@meta.ua", "Іванна", "Башук", "канд. філос. наук", "4629021653", "Програміст", 2183.06m, "Sleek" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 7, 2, 23, 51, 34, 183, DateTimeKind.Local).AddTicks(372), "Стрийська майдан, 1, Східний Маркіян, Норвегія", new DateTime(1950, 2, 1, 20, 24, 12, 755, DateTimeKind.Local).AddTicks(3021), "Tamara.Dmitrishina84@i.ua", "Брячислав", "Стигайло", "проф.", "6266732524", "Директор", 19188.18m, "Auto Loan Account" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 31, 22, 43, 48, 380, DateTimeKind.Local).AddTicks(3849), "Ліста майдан, 5, Рівне, Соломонові Острови", new DateTime(1970, 1, 20, 18, 31, 55, 454, DateTimeKind.Local).AddTicks(1891), "Slavuta55@meta.ua", "Ксенія", "Линдик", "докт. політ. наук", "9226684986", "Прибиральник", 18440.52m, "web-readiness" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 4, 2, 7, 13, 42, 216, DateTimeKind.Local).AddTicks(4965), "Городоцька майдан, 29, Донецьк, Чад", new DateTime(1957, 1, 21, 13, 43, 40, 372, DateTimeKind.Local).AddTicks(9683), "Yukhima.Balabukh15@ukr.net", "Синьоок", "Зленко", "проф.", "8091397096", 6378.51m, "foreground" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 2, 2, 11, 59, 5, 168, DateTimeKind.Local).AddTicks(9073), "Молодіжна майдан, 446, Східний Василь, Сінгапур", new DateTime(1971, 7, 1, 1, 9, 23, 478, DateTimeKind.Local).AddTicks(9011), "Oresta23@yandex.ua", new DateTime(2021, 1, 2, 14, 33, 1, 943, DateTimeKind.Local).AddTicks(5222), "Валентин", "Ковальський", "канд. і. наук", "5198406706", "Прибиральник", 12272.83m, "South Dakota" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 3, 4, 7, 23, 25, 529, DateTimeKind.Local).AddTicks(5917), "пр. Вічева, 6, Північний Борислав, Ірландія", new DateTime(1962, 9, 5, 10, 50, 51, 419, DateTimeKind.Local).AddTicks(9192), "Miroslav17@ex.ua", "Далемир", "Євенко", "докт. і. наук", "9086574040", "Секретар", 10723.21m, "streamline" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 11, 12, 22, 52, 48, 306, DateTimeKind.Local).AddTicks(9595), "Зелена майдан, 01, Євпаторія, Лесото", new DateTime(1988, 12, 2, 21, 37, 31, 292, DateTimeKind.Local).AddTicks(8241), "Avreliya86@i.ua", null, "Пантелеймон", "Єрмак", "канд. юрид. наук", "1421707833", "Прибиральник", 4616.09m, "open-source" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 22, 4, 0, 56, 351, DateTimeKind.Local).AddTicks(7446), "Вічева майдан, 13, Східний Нестор, Німеччина", new DateTime(1987, 1, 30, 5, 35, 22, 613, DateTimeKind.Local).AddTicks(6543), "Lyubava_Zvarich@yandex.ua", new DateTime(2023, 6, 28, 18, 11, 10, 246, DateTimeKind.Local).AddTicks(8532), "Лаврентій", "Третяк", "докт. техн. наук", "6003467235", "Бухгалтер", 19233.44m, "Metal" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 9, 29, 6, 3, 7, 581, DateTimeKind.Local).AddTicks(9222), "площа Коліївщини, 27, Західний Звенислав, Папуа-Нова Гвінея", new DateTime(1997, 11, 9, 8, 46, 57, 180, DateTimeKind.Local).AddTicks(1985), "Radimir.Openko@e-mail.ua", "Ратибор", "Усич", "канд. і. наук", "6068766347", "Програміст", 3949.41m, "1080p" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 8, 27, 19, 53, 48, 645, DateTimeKind.Local).AddTicks(1401), "пл. Рудного, 591, Горлівка, Гренада", new DateTime(2018, 2, 19, 19, 36, 44, 142, DateTimeKind.Local).AddTicks(5301), "Inna81@yandex.ua", "Олена", "Кулинич", "канд. філол. наук", "8202854818", "Секретар", 9037.71m, "quantifying" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 5, 18, 4, 29, 37, 437, DateTimeKind.Local).AddTicks(5176), "вулиця Вічева, 8, Східний Мирон, Сенеґал", new DateTime(1966, 10, 9, 15, 36, 3, 892, DateTimeKind.Local).AddTicks(4307), "Agniya_Petrishin27@e-mail.ua", "Віра", "Брицька", "докт. психол. наук", "5886699522", 3218.90m, "Rubber" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 15, 21, 11, 55, 973, DateTimeKind.Local).AddTicks(5362), "Нижанківського майдан, 81, Слов’янськ, Киргизстан", new DateTime(1952, 5, 26, 0, 55, 38, 603, DateTimeKind.Local).AddTicks(9629), "Lavrin_Bashuk38@e-mail.ua", null, "Лаврін", "Зінкевич", "докт. і. наук", "8403273212", "Бухгалтер", 4844.15m, "Circles" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 24, 15, 10, 54, 922, DateTimeKind.Local).AddTicks(3609), "Молодіжна майдан, 0, Рівне, Туреччина", new DateTime(2012, 5, 25, 3, 57, 41, 34, DateTimeKind.Local).AddTicks(6472), "Lukyan_Bilich83@ex.ua", "Валентина", "Троян", "канд. політ. наук", "4189165784", "Директор", 6833.25m, "synergistic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 9, 18, 21, 5, 27, 629, DateTimeKind.Local).AddTicks(8661), "Брюховичів майдан, 414, Львів, Барбадос", new DateTime(2012, 3, 30, 15, 18, 58, 337, DateTimeKind.Local).AddTicks(1002), "Arkadii.Korovyak65@yandex.ua", "Лідія", "Марієвський", "доц.", "0156983715", "Бухгалтер", 13024.03m, "teal" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 14, 15, 1, 39, 407, DateTimeKind.Local).AddTicks(2031), "Стрийська майдан, 12, Львів, Кірибаті", new DateTime(1976, 11, 16, 20, 1, 48, 463, DateTimeKind.Local).AddTicks(5599), "Lyubov71@ukr.net", new DateTime(2021, 7, 10, 4, 26, 49, 922, DateTimeKind.Local).AddTicks(7091), "Милодара", "Лахман", "докт. пед. наук", "6086017080", "Програміст", 19850.20m, "overriding" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 11, 15, 9, 33, 42, 424, DateTimeKind.Local).AddTicks(7163), "Брюховичів майдан, 1, Луцьк, США", new DateTime(2018, 1, 5, 7, 24, 35, 888, DateTimeKind.Local).AddTicks(9271), "Vlasta73@meta.ua", null, "Аврора", "Поривай", "канд. пед. наук", "1423637022", "Бухгалтер", 7862.31m, "EXE" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 9, 5, 3, 37, 48, 202, DateTimeKind.Local).AddTicks(5723), "вулиця Нижанківського, 62, Північний Братимир, Алжир", new DateTime(1997, 2, 20, 0, 41, 41, 394, DateTimeKind.Local).AddTicks(1435), "Milodara.Sosyura35@meta.ua", null, "Звенигор", "Калач", "1772477542", "Бухгалтер", 4467.24m, "hard drive" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 13, 2, 34, 50, 369, DateTimeKind.Local).AddTicks(6570), "Ліста майдан, 17, Східний Корній, Тувалу", new DateTime(1967, 5, 1, 23, 52, 48, 306, DateTimeKind.Local).AddTicks(8537), "Zenovii_Miklukho84@ex.ua", new DateTime(2019, 5, 15, 17, 53, 21, 384, DateTimeKind.Local).AddTicks(9143), "Денис", "Пономарів", "доц.", "2773920820", "Директор", 4663.41m, "Kazakhstan" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 3, 10, 8, 50, 32, 48, DateTimeKind.Local).AddTicks(8002), "Вічева майдан, 915, Львів, Непал", new DateTime(1950, 2, 9, 20, 46, 39, 608, DateTimeKind.Local).AddTicks(9579), "Arkadiya_Dzyubyak@gmail.com", new DateTime(2020, 6, 15, 3, 30, 35, 434, DateTimeKind.Local).AddTicks(1016), "Добромисл", "Ліхно", "канд. юрид. наук", "4665103334", "Програміст", 1451.39m, "e-business" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 3, 20, 22, 51, 57, 52, DateTimeKind.Local).AddTicks(2693), "вул. Вузька, 814, Східний Зоремир, Кабо-Верде", new DateTime(1991, 3, 24, 20, 23, 0, 529, DateTimeKind.Local).AddTicks(6185), "Yukhima_Semeshuk18@meta.ua", null, "Богдана", "Бамбула", "канд. і. наук", "3748486817", 2125.49m, "Fantastic" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 14, 20, 7, 16, 21, DateTimeKind.Local).AddTicks(8528), "Брюховичів майдан, 333, Східний Братослав, Зімбабве", new DateTime(2001, 10, 2, 11, 42, 54, 157, DateTimeKind.Local).AddTicks(2845), "Darii_Porivailo@e-mail.ua", new DateTime(2022, 3, 23, 22, 29, 9, 336, DateTimeKind.Local).AddTicks(7969), "Славолюб", "Усич", "докт. психол. наук", "9486268103", 12427.72m, "Sleek" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 12, 14, 28, 58, 305, DateTimeKind.Local).AddTicks(1198), "пр. Винників, 2, Південний Мар’ян, Кіпр", new DateTime(2004, 2, 1, 2, 6, 8, 476, DateTimeKind.Local).AddTicks(458), "Anna_Petrin@meta.ua", null, "Корнелій", "Бабух", "докт. філол. наук", "5616922023", "Прибиральник", 3310.73m, "experiences" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 28, 1, 41, 1, 890, DateTimeKind.Local).AddTicks(842), "Зелена майдан, 43, Західний Олелько, Самоа", new DateTime(2001, 5, 2, 22, 4, 37, 913, DateTimeKind.Local).AddTicks(9069), "Yana36@i.ua", null, "Ростислав", "Гриневецький", "канд. психол. наук", "1188140669", "Секретар", 13192.84m, "Sleek" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 19, 22, 47, 56, 300, DateTimeKind.Local).AddTicks(3388), "Ліста майдан, 415, Кам’янець-Подільський, Іспанія", new DateTime(1946, 7, 20, 7, 58, 2, 88, DateTimeKind.Local).AddTicks(7178), "Zoryana61@gmail.com", new DateTime(2021, 2, 8, 8, 59, 9, 610, DateTimeKind.Local).AddTicks(2632), "Артем", "Ломова", "5840412070", "Секретар", 10376.38m, "scale" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 4, 21, 6, 21, 22, 993, DateTimeKind.Local).AddTicks(1049), "провулок Ліста, 6, Східний Братимир, Гамбія", new DateTime(1996, 9, 25, 15, 44, 14, 276, DateTimeKind.Local).AddTicks(7592), "Garnoslav_Romenec40@ukr.net", "Братослав", "Милославський", "докт. і. наук", "5121011010", "Директор", 6304.82m, "models" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 3, 19, 22, 15, 20, 640, DateTimeKind.Local).AddTicks(5869), "площа Винників, 5, Лисичанськ, Ефіопія", new DateTime(2012, 8, 24, 5, 42, 55, 86, DateTimeKind.Local).AddTicks(298), "Mechislav_Babukh@yandex.ua", null, "Антоніна", "Лановий", "докт. юрид. наук", "1137895871", 16148.96m, "Turkmenistan" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 17, 2, 48, 34, 975, DateTimeKind.Local).AddTicks(1042), "Вузька майдан, 101, Східний Степан, Сомалі", new DateTime(2004, 4, 14, 3, 1, 44, 859, DateTimeKind.Local).AddTicks(7090), "Mokrina22@ukr.net", new DateTime(2024, 3, 18, 23, 12, 47, 348, DateTimeKind.Local).AddTicks(8896), "Петро", "Карпух", "докт. і. наук", "3452175211", 19423.37m, "Neck" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 12, 18, 5, 20, 30, 561, DateTimeKind.Local).AddTicks(3585), "площа Ліста, 6, Красний Луч, Бразилія", new DateTime(1977, 9, 7, 2, 35, 28, 149, DateTimeKind.Local).AddTicks(4232), "Orislava87@yandex.ua", new DateTime(2021, 4, 12, 17, 45, 51, 778, DateTimeKind.Local).AddTicks(2094), "Богуслава", "Городоцька", "6482495774", "Директор", 1745.55m, "Identity" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 3, 11, 21, 41, 15, 84, DateTimeKind.Local).AddTicks(8389), "Рудного майдан, 29, Артемівськ, США", new DateTime(1999, 6, 8, 12, 27, 5, 942, DateTimeKind.Local).AddTicks(5776), "Zinayida.Yalyuk@i.ua", null, "Квітка", "Сердюк", "докт. техн. наук", "9562232478", "Директор", 6322.81m, "Tunisia" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 19, 7, 19, 47, 911, DateTimeKind.Local).AddTicks(7290), "Винників майдан, 09, Краматорськ, Бутан", new DateTime(2013, 8, 27, 15, 29, 56, 393, DateTimeKind.Local).AddTicks(6551), "Aelina65@yandex.ua", "Анастас", "Михайлюк", "проф.", "3125081681", "Бухгалтер", 12334.31m, "Lodge" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 24, 0, 1, 50, 263, DateTimeKind.Local).AddTicks(4674), "вул. Рудного, 4, Черкаси, Сомалі", new DateTime(1963, 5, 24, 23, 19, 44, 71, DateTimeKind.Local).AddTicks(7417), "Podolyan.Balaban@e-mail.ua", "Тиміш", "Ящук", "докт. філос. наук", "1273601211", 4766.71m, "New Mexico" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 24, 18, 45, 56, 255, DateTimeKind.Local).AddTicks(686), "Винників майдан, 878, Східний Братимир, Грузія", new DateTime(2000, 7, 16, 16, 23, 9, 10, DateTimeKind.Local).AddTicks(5204), "Orkhip_Porivailo8@i.ua", "Афанасія", "Семещук", "докт. філос. наук", "1082697597", "Бухгалтер", 13237.72m, "New Mexico" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 3, 28, 0, 54, 8, 334, DateTimeKind.Local).AddTicks(7696), "Вічева майдан, 49, Дніпродзержинськ, Японія", new DateTime(1945, 4, 30, 7, 21, 43, 966, DateTimeKind.Local).AddTicks(6076), "Slava18@i.ua", null, "Кузьма", "Яцишина", "докт. техн. наук", "7611978565", 16344.44m, "Borders" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 28, 1, 15, 36, 302, DateTimeKind.Local).AddTicks(5246), "проспект Зелена, 53, Мелітополь, Ізраїль", new DateTime(2016, 7, 26, 22, 30, 36, 682, DateTimeKind.Local).AddTicks(7133), "Zorina.Durdinec@ukr.net", "Доброслава", "Білич", "канд. філос. наук", "3325911876", "Програміст", 13753.66m, "portal" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 9, 7, 54, 22, 193, DateTimeKind.Local).AddTicks(8106), "Вузька майдан, 241, Дніпропетровськ, Екваторіальна Гвінея", new DateTime(2005, 1, 23, 10, 9, 28, 733, DateTimeKind.Local).AddTicks(196), "Klavdiya.Balaban42@gmail.com", new DateTime(2021, 4, 22, 13, 14, 24, 173, DateTimeKind.Local).AddTicks(6391), "Власта", "Балакун", "канд. і. наук", "3922018247", 17315.99m, "scale" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 7, 10, 21, 1, 597, DateTimeKind.Local).AddTicks(3149), "пров. Рудного, 63, Східний Стефаній, Мальта", new DateTime(1979, 3, 31, 5, 18, 16, 389, DateTimeKind.Local).AddTicks(3958), "Arkadiya_Korovyak@meta.ua", null, "Родослав", "Кандиба", "канд. і. наук", "5230316094", "Бухгалтер", 19317.66m, "Generic Soft Chair" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 7, 11, 3, 17, 589, DateTimeKind.Local).AddTicks(7280), "Староміська майдан, 22, Західний Архип, Андорра", new DateTime(2013, 10, 30, 9, 6, 44, 897, DateTimeKind.Local).AddTicks(4635), "Bryachislav_Miklashevska74@ukr.net", new DateTime(2023, 11, 9, 13, 51, 18, 217, DateTimeKind.Local).AddTicks(4185), "Пилип", "Спотикач", "канд. політ. наук", "4487527790", "Прибиральник", 13003.34m, "Czech Republic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 3, 7, 4, 29, 39, 317, DateTimeKind.Local).AddTicks(1355), "пров. Молодіжна, 67, Житомир, Ботсвана", new DateTime(1961, 5, 28, 15, 31, 41, 687, DateTimeKind.Local).AddTicks(3198), "Ustina.Gaiduk53@i.ua", "Надія", "Дзюб’як", "канд. техн. наук", "6559229369", 13586.65m, "Cambridgeshire" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 4, 16, 18, 23, 11, 353, DateTimeKind.Local).AddTicks(5123), "пл. Брюховичів, 0, Одеса, Сент-Кітс і Невіс", new DateTime(1957, 11, 6, 22, 39, 55, 9, DateTimeKind.Local).AddTicks(2753), "Oksana33@ex.ua", null, "Герасим", "Гречко", "докт. політ. наук", "7271890640", "Прибиральник", 3849.08m, "compressing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 9, 12, 6, 27, 13, 304, DateTimeKind.Local).AddTicks(2329), "вулиця Староміська, 933, Південний Арсен, Гайана", new DateTime(1960, 12, 25, 0, 55, 35, 399, DateTimeKind.Local).AddTicks(7050), "Lad12@i.ua", null, "Катерина", "Балицький", "канд. психол. наук", "2294544566", "Секретар", 12293.72m, "Applications" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 30, 2, 45, 33, 124, DateTimeKind.Local).AddTicks(8316), "Стрийська майдан, 11, Севастополь, Сербія", new DateTime(1992, 1, 26, 10, 37, 26, 991, DateTimeKind.Local).AddTicks(2340), "Aelayida72@i.ua", "Жозефіна", "Компанієць", "докт. юрид. наук", "0834744873", 10236.21m, "multi-byte" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 2, 3, 7, 2, 48, 224, DateTimeKind.Local).AddTicks(6020), "Нижанківського майдан, 0, Мелітополь, Аргентина", new DateTime(1948, 12, 27, 5, 21, 28, 408, DateTimeKind.Local).AddTicks(2906), "Pelagiya.Stepanec54@ukr.net", null, "Євген", "Зленко", "канд. філол. наук", "5625822501", "Директор", 5818.06m, "Intelligent" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 23, 16, 25, 53, 519, DateTimeKind.Local).AddTicks(5167), "Староміська майдан, 943, Східний Руслан, Ефіопія", new DateTime(1955, 6, 24, 13, 28, 2, 109, DateTimeKind.Local).AddTicks(7113), "Yuliya.Ganich65@e-mail.ua", "Яромил", "Мазило", "докт. політ. наук", "1949804475", "Бухгалтер", 5719.90m, "generate" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 2, 21, 12, 5, 32, 759, DateTimeKind.Local).AddTicks(1561), "площа Вузька, 7, Алчевськ, Кенія", new DateTime(2002, 3, 3, 4, 49, 6, 528, DateTimeKind.Local).AddTicks(3202), "Gennadii46@ex.ua", "Аделіна", "Милославський", "докт. філол. наук", "2006610689", 6882.73m, "Borders" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 3, 29, 19, 27, 19, 958, DateTimeKind.Local).AddTicks(9501), "Винників майдан, 0, Південний Юхим, Гвінея", new DateTime(1988, 1, 25, 23, 8, 27, 940, DateTimeKind.Local).AddTicks(5921), "Yaroslava58@ukr.net", "Костянтин", "Гришко", "докт. філол. наук", "8848920008", "Директор", 8971.08m, "Japan" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 30, 12, 12, 20, 883, DateTimeKind.Local).AddTicks(2823), "Вічева майдан, 55, Житомир, Казахстан", new DateTime(2014, 10, 10, 6, 20, 18, 920, DateTimeKind.Local).AddTicks(4396), "Zlat_Koman@e-mail.ua", "Всеволод", "Лагойда", "докт. техн. наук", "6793123865", 5406.30m, "multi-byte" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 32, 21, 255, DateTimeKind.Local).AddTicks(625), "вулиця Зелена, 65, Луцьк, Конго", new DateTime(1991, 9, 22, 13, 29, 0, 530, DateTimeKind.Local).AddTicks(3672), "Yaroslava_Zinkevich15@yandex.ua", new DateTime(2021, 3, 27, 3, 38, 21, 929, DateTimeKind.Local).AddTicks(3463), "Орислава", "Корецький", "докт. філол. наук", "7367524651", 2334.42m, "interfaces" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 6, 4, 15, 21, 33, 701, DateTimeKind.Local).AddTicks(1075), "Брюховичів майдан, 056, Житомир, Катар", new DateTime(1955, 2, 4, 16, 27, 44, 540, DateTimeKind.Local).AddTicks(7735), "Aelayida_Grechko@gmail.com", new DateTime(2020, 3, 9, 10, 45, 41, 449, DateTimeKind.Local).AddTicks(6945), "Орися", "Шупик", "7137600594", "Директор", 18025.71m, "compress" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 11, 13, 21, 51, 37, 227, DateTimeKind.Local).AddTicks(2098), "Староміська майдан, 13, Ізмаїл, Литва", new DateTime(2018, 5, 13, 6, 9, 17, 63, DateTimeKind.Local).AddTicks(3377), "Gerasim.Danilishina@yandex.ua", "Білослав", "Гарай", "докт. філол. наук", "7822544170", "Директор", 10401.15m, "Sleek" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 24, 8, 36, 26, 201, DateTimeKind.Local).AddTicks(6357), "пр. Винників, 653, Південний Адріян, Шрі-Ланка", new DateTime(1967, 10, 4, 7, 35, 20, 2, DateTimeKind.Local).AddTicks(3038), "Andrii_Mazun@ex.ua", new DateTime(2024, 2, 3, 21, 31, 2, 969, DateTimeKind.Local).AddTicks(2548), "Ярополк", "Латанський", "докт. і. наук", "4617248444", "Програміст", 8828.75m, "Integration" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 14, 17, 5, 26, 8, DateTimeKind.Local).AddTicks(1734), "Молодіжна майдан, 5, Львів, Австрія", new DateTime(1969, 1, 14, 8, 15, 50, 278, DateTimeKind.Local).AddTicks(1300), "Anastasiya85@ex.ua", "Яромил", "Євпак", "докт. філол. наук", "1718318755", 19658.90m, "Synergistic" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 12, 25, 17, 44, 13, 217, DateTimeKind.Local).AddTicks(7520), "пр. Староміська, 676, Суми, Македонія", new DateTime(1949, 3, 6, 13, 54, 47, 287, DateTimeKind.Local).AddTicks(3591), "Gavrilo.Demkiv6@e-mail.ua", null, "Далеслава", "докт. політ. наук", "2708574204", "Програміст", 6502.90m, "Locks" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 3, 12, 19, 34, 55, 589, DateTimeKind.Local).AddTicks(4365), "пр. Стрийська, 788, Західний Всеслав, Сент-Кітс і Невіс", new DateTime(2000, 7, 20, 23, 5, 1, 665, DateTimeKind.Local).AddTicks(901), "Anna_Lomova@ukr.net", null, "Славомир", "Цушко", "канд. юрид. наук", "5617163135", "Директор", 18973.46m, "primary" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 28, 17, 18, 20, 515, DateTimeKind.Local).AddTicks(554), "Брюховичів майдан, 411, Євпаторія, Лівія", new DateTime(1988, 2, 27, 0, 8, 27, 362, DateTimeKind.Local).AddTicks(7977), "Vilina63@ukr.net", null, "Гаврило", "Сердюк", "канд. психол. наук", "2991737493", "Бухгалтер", 19208.72m, "Soft" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 26, 22, 29, 36, 708, DateTimeKind.Local).AddTicks(4096), "проспект Староміська, 03, Південний Маркіян, Чорногорія", new DateTime(1946, 9, 10, 23, 29, 1, 46, DateTimeKind.Local).AddTicks(8320), "Rodion_Vasilin@ex.ua", "Ізяслав", "Дзюба", "докт. політ. наук", "2454180044", "Секретар", 3918.46m, "Automotive & Toys" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 18, 14, 48, 53, 522, DateTimeKind.Local).AddTicks(3551), "пров. Староміська, 79, Сєвєродонецьк, Свазіленд", new DateTime(2017, 4, 4, 3, 30, 1, 508, DateTimeKind.Local).AddTicks(3200), "Oriyana.Zabila66@meta.ua", "Віленіна", "Левадовська", "докт. техн. наук", "6497056608", 7792.57m, "withdrawal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 13, 21, 38, 29, 454, DateTimeKind.Local).AddTicks(9764), "Рудного майдан, 7, Північний Корній, Малі", new DateTime(1984, 1, 25, 5, 30, 39, 963, DateTimeKind.Local).AddTicks(880), "Sofiya_Sirko14@ukr.net", new DateTime(2019, 12, 21, 11, 7, 10, 977, DateTimeKind.Local).AddTicks(5054), "Горимир", "Поривай", "канд. і. наук", "4671361852", 1109.46m, "IB" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 30, 0, 37, 27, 96, DateTimeKind.Local).AddTicks(9690), "Молодіжна майдан, 926, Макіївка, Об’єднані Арабські Емірати", new DateTime(2018, 10, 3, 8, 10, 46, 55, DateTimeKind.Local).AddTicks(9772), "Yana21@gmail.com", "Аскольд", "Романишина", "докт. філол. наук", "4059709881", "Бухгалтер", 16956.37m, "Upgradable" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 3, 18, 23, 37, 4, 596, DateTimeKind.Local).AddTicks(2120), "Коліївщини майдан, 806, Севастополь, Сьєрра-Леоне", new DateTime(2017, 10, 7, 0, 59, 9, 107, DateTimeKind.Local).AddTicks(5211), "Yarina.Yurchishina@i.ua", new DateTime(2020, 11, 8, 19, 28, 31, 721, DateTimeKind.Local).AddTicks(8184), "Білослав", "Шкараба", "канд. філол. наук", "0477162578", "Програміст", 5095.80m, "Internal" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 18, 23, 28, 18, 926, DateTimeKind.Local).AddTicks(9074), "провулок Зелена, 8, Північний Микита, Російська Федерація", new DateTime(2004, 7, 30, 2, 21, 28, 22, DateTimeKind.Local).AddTicks(1614), "Marina_Malkovich10@meta.ua", null, "Мальва", "Кульчицька", "докт. пед. наук", "2937036817", "Програміст", 8305.15m, "Prairie" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 9, 21, 35, 59, 450, DateTimeKind.Local).AddTicks(7706), "проспект Коліївщини, 3, Павлоград, Словенія", new DateTime(1965, 5, 14, 13, 1, 20, 417, DateTimeKind.Local).AddTicks(4339), "Lesya51@ukr.net", new DateTime(2023, 11, 14, 11, 57, 7, 435, DateTimeKind.Local).AddTicks(3311), "Віолетта", "Линдик", "докт. і. наук", "5918939686", 19975.99m, "interface" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 14, 3, 39, 58, 187, DateTimeKind.Local).AddTicks(3192), "провулок Молодіжна, 1, Кам’янець-Подільський, Коста-Рика", new DateTime(1987, 1, 31, 21, 42, 37, 890, DateTimeKind.Local).AddTicks(7552), "Kii.Makovecka66@ex.ua", "Руслан", "Слободян", "докт. юрид. наук", "4674905077", "Прибиральник", 9345.75m, "Security" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 20, 3, 15, 43, 271, DateTimeKind.Local).AddTicks(8719), "Брюховичів майдан, 67, Мелітополь, Куба", new DateTime(2000, 9, 12, 16, 12, 38, 206, DateTimeKind.Local).AddTicks(792), "Lada_Gnatishin@meta.ua", "Потішана", "Карпух", "проф.", "4538406036", 10712.88m, "bypass" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 6, 0, 51, 36, 33, DateTimeKind.Local).AddTicks(7880), "провулок Староміська, 53, Північний Адам, Литва", new DateTime(1948, 7, 11, 15, 9, 8, 69, DateTimeKind.Local).AddTicks(8100), "Lyudomila.Berdnik@ukr.net", new DateTime(2023, 12, 15, 15, 43, 47, 649, DateTimeKind.Local).AddTicks(6615), "Орислава", "Боровський", "проф.", "5894060721", 17400.30m, "Investment Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 18, 19, 55, 29, 718, DateTimeKind.Local).AddTicks(9361), "провулок Винників, 466, Північний Антін, Туреччина", new DateTime(1999, 3, 23, 4, 17, 44, 971, DateTimeKind.Local).AddTicks(5571), "Dobroslava_Danilishina@ex.ua", new DateTime(2019, 5, 23, 22, 53, 21, 703, DateTimeKind.Local).AddTicks(7289), "Ксенія", "Гришко", "докт. філол. наук", "8442043696", "Бухгалтер", 1569.69m, "Knoll" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "PhoneNumber", "Position", "Salary" },
                values: new object[] { new DateTime(2023, 11, 9, 20, 15, 2, 398, DateTimeKind.Local).AddTicks(1624), "Рудного майдан, 6, Горлівка, Зімбабве", new DateTime(2017, 5, 11, 2, 59, 34, 823, DateTimeKind.Local).AddTicks(8833), "Zlata47@ex.ua", "Боримисл", "Лазірко", "2934254540", "Директор", 3445.64m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 18, 17, 18, 34, 413, DateTimeKind.Local).AddTicks(2958), "Вічева майдан, 87, Макіївка, Швеція", new DateTime(1984, 4, 25, 11, 42, 22, 687, DateTimeKind.Local).AddTicks(1592), "Lada.Vitryak43@gmail.com", "Мар’ян", "Лученко", "докт. політ. наук", "7834475901", "Секретар", 6275.17m, "maroon" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 25, 19, 52, 10, 201, DateTimeKind.Local).AddTicks(6600), "пров. Вузька, 6, Північний Алевтин, Швейцарія", new DateTime(1950, 1, 14, 7, 26, 9, 212, DateTimeKind.Local).AddTicks(7126), "Oleksii.Osadko@ukr.net", "Поліна", "Сторчак", "докт. політ. наук", "9015339448", "Прибиральник", 7678.67m, "Gorgeous Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 3, 18, 12, 44, 48, 648, DateTimeKind.Local).AddTicks(6549), "Вузька майдан, 85, Суми, Барбадос", new DateTime(2011, 10, 5, 12, 17, 19, 396, DateTimeKind.Local).AddTicks(3583), "Vasilina39@gmail.com", "Віленіна", "Корецька", "канд. техн. наук", "3321253026", "Бухгалтер", 10103.98m, "Total" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 12, 13, 8, 26, 50, 635, DateTimeKind.Local).AddTicks(1407), "Нижанківського майдан, 79, Тернопіль, Естонія", new DateTime(1994, 9, 1, 14, 56, 2, 897, DateTimeKind.Local).AddTicks(9109), "Dobrinka.Shupik44@e-mail.ua", null, "Аскольд", "Коцюбинський", "канд. філос. наук", "9123883441", "Прибиральник", 9789.97m, "indexing" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 4, 26, 982, DateTimeKind.Local).AddTicks(1743), "Вузька майдан, 9, Північний Лад, Італія", new DateTime(2000, 11, 2, 22, 40, 49, 393, DateTimeKind.Local).AddTicks(8595), "Kvitka.Galatei43@yandex.ua", new DateTime(2022, 2, 6, 10, 51, 57, 153, DateTimeKind.Local).AddTicks(7474), "Добромила", "Москаль", "доц.", "1430859404", "Бухгалтер", 6693.72m, "Tasty Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 7, 3, 23, 22, 24, 996, DateTimeKind.Local).AddTicks(4185), "Молодіжна майдан, 84, Західний Мирослав, Папуа-Нова Гвінея", new DateTime(1998, 4, 7, 3, 44, 8, 825, DateTimeKind.Local).AddTicks(6516), "Zenovii_Lomova@meta.ua", new DateTime(2023, 4, 27, 18, 30, 43, 973, DateTimeKind.Local).AddTicks(5069), "Ярослав", "Шухевич", "канд. пед. наук", "3648121522", "Секретар", 5256.40m, "brand" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 26, 14, 40, 54, 312, DateTimeKind.Local).AddTicks(2188), "Городоцька майдан, 4, Сєвєродонецьк, Суринам", new DateTime(2007, 4, 26, 0, 27, 45, 68, DateTimeKind.Local).AddTicks(3170), "Dana_Petrina@ukr.net", new DateTime(2023, 11, 20, 4, 43, 43, 865, DateTimeKind.Local).AddTicks(4572), "Раїса", "Дідух", "канд. пед. наук", "9458589240", "Секретар", 6684.58m, "Village" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 3, 10, 2, 7, 54, 38, DateTimeKind.Local).AddTicks(9411), "Винників майдан, 0, Північний Ратибор, Самоа", new DateTime(1954, 5, 18, 19, 53, 6, 836, DateTimeKind.Local).AddTicks(6991), "Zoryana.Chervonii@yandex.ua", new DateTime(2020, 7, 27, 20, 28, 21, 6, DateTimeKind.Local).AddTicks(9895), "Анатолія", "Карпух", "5180080809", 5264.10m, "Checking Account" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 18, 18, 46, 40, 569, DateTimeKind.Local).AddTicks(1541), "вулиця Староміська, 592, Західний Дарій, Еквадор", new DateTime(1994, 6, 6, 4, 26, 53, 487, DateTimeKind.Local).AddTicks(8075), "Nazar.Pavlenko63@e-mail.ua", new DateTime(2022, 6, 25, 14, 47, 47, 604, DateTimeKind.Local).AddTicks(7468), "Пантелеймон", "Паламарчук", "канд. політ. наук", "7519420785", "Програміст", 10836.28m, "Clothing, Sports & Games" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 5, 6, 5, 58, 32, 951, DateTimeKind.Local).AddTicks(7458), "пл. Ліста, 840, Південний Щек, Федеративні Штати Мікронезії", new DateTime(2004, 10, 12, 0, 11, 5, 294, DateTimeKind.Local).AddTicks(9478), "Sonya_Pavlenko@ukr.net", new DateTime(2020, 1, 9, 18, 1, 29, 757, DateTimeKind.Local).AddTicks(6302), "Натан", "Ромей", "5224377031", 9619.59m, "Metal" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 9, 11, 21, 0, 42, 417, DateTimeKind.Local).AddTicks(6888), "площа Староміська, 424, Умань, Франція", new DateTime(2006, 10, 23, 9, 34, 20, 907, DateTimeKind.Local).AddTicks(6860), "Mariya.Shindarei@i.ua", new DateTime(2022, 8, 11, 8, 52, 38, 764, DateTimeKind.Local).AddTicks(3996), "Тетяна", "Трясило", "проф.", "5250478644", 6029.99m, "Qatari Rial" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 1, 29, 1, 33, 43, 32, DateTimeKind.Local).AddTicks(4925), "пров. Брюховичів, 068, Дніпродзержинськ, Венесуела", new DateTime(1979, 1, 8, 8, 9, 37, 312, DateTimeKind.Local).AddTicks(7078), "Bratoslav_Palamarchuk59@meta.ua", null, "Любислава", "Кандиба", "докт. філос. наук", "9460558542", 5053.41m, "Persistent" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 16, 16, 0, 17, 586, DateTimeKind.Local).AddTicks(4009), "Рудного майдан, 553, Східний Олелько, Болівія", new DateTime(1988, 1, 17, 23, 56, 47, 718, DateTimeKind.Local).AddTicks(4825), "Stefanii_Tryasilo@e-mail.ua", "Віліна", "Брицький", "докт. техн. наук", "2209863036", "Директор", 9474.62m, "Administrator" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 29, 6, 23, 8, 167, DateTimeKind.Local).AddTicks(2414), "проспект Нижанківського, 31, Макіївка, Норвегія", new DateTime(1958, 12, 18, 2, 25, 47, 151, DateTimeKind.Local).AddTicks(8833), "Miroslava19@e-mail.ua", "Альбіна", "Паламарчук", "канд. політ. наук", "6979785768", 4018.27m, "Executive" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 3, 17, 22, 34, 13, 277, DateTimeKind.Local).AddTicks(3427), "провулок Молодіжна, 142, Ялта, Маршаллові Острови", new DateTime(1952, 1, 2, 4, 2, 32, 322, DateTimeKind.Local).AddTicks(1023), "Lad.Borovska79@ex.ua", "Мстислава", "Тиндарей", "канд. і. наук", "2725824885", 6139.90m, "magenta" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 12, 17, 54, 13, 215, DateTimeKind.Local).AddTicks(3483), "Вічева майдан, 27, Північний Натан, Киргизстан", new DateTime(1964, 4, 3, 13, 53, 34, 558, DateTimeKind.Local).AddTicks(4377), "Antin_Rozputnii@meta.ua", new DateTime(2022, 9, 4, 16, 35, 38, 466, DateTimeKind.Local).AddTicks(315), "Тетяна", "Башук", "проф.", "7164087023", "Директор", 6005.43m, "Gorgeous Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 1, 2, 7, 22, 27, 516, DateTimeKind.Local).AddTicks(4476), "Брюховичів майдан, 052, Південний Далемир, Філіппіни", new DateTime(1991, 12, 20, 2, 46, 28, 695, DateTimeKind.Local).AddTicks(495), "Dolyana_Gordiichuk@e-mail.ua", "Добромира", "Лученко", "докт. психол. наук", "1035284758", "Прибиральник", 19177.83m, "Cambridgeshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 15, 7, 1, 7, 519, DateTimeKind.Local).AddTicks(480), "Ліста майдан, 57, Східний Руслан, Марокко", new DateTime(1981, 10, 19, 5, 4, 51, 585, DateTimeKind.Local).AddTicks(2557), "Nataliya.Openko94@meta.ua", null, "Орест", "Кононець", "докт. техн. наук", "0810979283", "Програміст", 10321.40m, "Springs" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 26, 7, 2, 51, 922, DateTimeKind.Local).AddTicks(9208), "вулиця Молодіжна, 45, Східний Доброслав, Демократична Республіка Конго", new DateTime(2007, 10, 26, 9, 21, 45, 382, DateTimeKind.Local).AddTicks(8610), "Zoya.Makovecka@i.ua", null, "Юхим", "Лютий", "проф.", "7634895681", "Прибиральник", 3357.46m, "Practical Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 8, 23, 3, 32, 609, DateTimeKind.Local).AddTicks(2793), "Винників майдан, 43, Західний Братимир, Південний Судан", new DateTime(1996, 9, 5, 5, 11, 53, 678, DateTimeKind.Local).AddTicks(2278), "Vseslav22@ukr.net", new DateTime(2021, 8, 26, 22, 34, 48, 159, DateTimeKind.Local).AddTicks(102), "Ромена", "Петрів", "докт. психол. наук", "7761707558", "Секретар", 15671.25m, "Computers, Health & Toys" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 22, 21, 45, 6, 206, DateTimeKind.Local).AddTicks(5859), "Молодіжна майдан, 4, Шостка, Нігер", new DateTime(2006, 8, 30, 19, 28, 27, 604, DateTimeKind.Local).AddTicks(7093), "Rostislava_Openko55@ukr.net", new DateTime(2021, 1, 25, 16, 43, 21, 891, DateTimeKind.Local).AddTicks(8479), "Мирон", "Люта", "докт. пед. наук", "7011914496", "Секретар", 15006.23m, "navigating" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 52, 9, 437, DateTimeKind.Local).AddTicks(6419), "вулиця Рудного, 07, Східний Велемир, Філіппіни", new DateTime(2004, 11, 19, 14, 30, 41, 83, DateTimeKind.Local).AddTicks(9963), "Mikola34@ex.ua", "Ангеліна", "Гарай", "докт. техн. наук", "8873116207", "Бухгалтер", 4035.80m, "deposit" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 26, 17, 46, 16, 378, DateTimeKind.Local).AddTicks(2501), "Староміська майдан, 1, Лисичанськ, Гвінея-Бісау", new DateTime(2013, 8, 22, 15, 55, 30, 758, DateTimeKind.Local).AddTicks(3911), "Shek_Gromiko8@gmail.com", new DateTime(2022, 8, 16, 15, 42, 36, 916, DateTimeKind.Local).AddTicks(8960), "Ладо", "Савицький", "докт. пед. наук", "4957373550", "Бухгалтер", 1563.08m, "Senior" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 12, 4, 30, 51, 741, DateTimeKind.Local).AddTicks(8259), "Брюховичів майдан, 48, Алчевськ, Кіпр", new DateTime(2022, 5, 1, 5, 16, 37, 626, DateTimeKind.Local).AddTicks(6383), "Anna_Maistrenko@meta.ua", null, "Борислава", "Кордун", "канд. філос. наук", "0298981948", "Бухгалтер", 16052.79m, "Cliff" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 22, 3, 6, 39, 692, DateTimeKind.Local).AddTicks(3049), "пл. Винників, 5, Бердянськ, Гвінея", new DateTime(1947, 2, 3, 14, 20, 17, 966, DateTimeKind.Local).AddTicks(4917), "Zoreslava.Ganich30@gmail.com", new DateTime(2019, 8, 14, 11, 55, 43, 225, DateTimeKind.Local).AddTicks(7463), "Валентина", "Хитрово", "докт. політ. наук", "1848831924", 4866.27m, "lime" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 5, 31, 7, 51, 36, 786, DateTimeKind.Local).AddTicks(7178), "Винників майдан, 3, Івано-Франківськ, Узбекистан", new DateTime(1956, 12, 6, 6, 49, 44, 983, DateTimeKind.Local).AddTicks(3212), "Zlata_Shiyan11@yandex.ua", new DateTime(2023, 2, 8, 13, 27, 1, 487, DateTimeKind.Local).AddTicks(3444), "Любомир", "Данилко", "докт. філол. наук", "2294183267", 19440.90m, "Terrace" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 30, 4, 23, 37, 645, DateTimeKind.Local).AddTicks(1873), "вулиця Городоцька, 961, Східний Зоремир, Венесуела", new DateTime(1982, 5, 21, 4, 47, 33, 769, DateTimeKind.Local).AddTicks(6406), "Yaroslava82@gmail.com", null, "Ореста", "Ялова", "докт. філос. наук", "0176955961", 12735.93m, "Cross-group" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 3, 28, 20, 13, 14, 765, DateTimeKind.Local).AddTicks(5693), "проспект Городоцька, 4, Північний Антін, Франція", new DateTime(1985, 7, 12, 8, 27, 10, 623, DateTimeKind.Local).AddTicks(3405), "Albert_Bilich@yandex.ua", null, "Доброслава", "Яцишин", "канд. психол. наук", "2521449815", "Директор", 3324.87m, "robust" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 26, 21, 52, 42, 601, DateTimeKind.Local).AddTicks(9611), "Нижанківського майдан, 1, Ужгород, Замбія", new DateTime(1976, 2, 19, 16, 17, 29, 840, DateTimeKind.Local).AddTicks(1187), "Makar80@e-mail.ua", null, "Оксана", "Сірко", "докт. філос. наук", "4127454772", "Прибиральник", 15243.11m, "bypassing" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 3, 8, 5, 52, 8, 234, DateTimeKind.Local).AddTicks(6353), "вул. Нижанківського, 51, Нікополь, Угорщина", new DateTime(1981, 7, 1, 3, 24, 23, 518, DateTimeKind.Local).AddTicks(8152), "Alina89@yandex.ua", "Антон", "Пасічник", "доц.", "5757523662", "Бухгалтер", 10449.84m, "Garden & Movies" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 9, 0, 47, 57, 296, DateTimeKind.Local).AddTicks(2666), "Молодіжна майдан, 2, Східний Ратимир, Люксембург", new DateTime(2000, 10, 3, 19, 6, 1, 339, DateTimeKind.Local).AddTicks(4395), "Maryan14@ex.ua", "Богдана", "Вергун", "проф.", "6546653787", 11225.04m, "expedite" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 15, 0, 21, 48, 109, DateTimeKind.Local).AddTicks(5117), "Зелена майдан, 20, Південний Захар, Суринам", new DateTime(1951, 2, 6, 6, 5, 21, 622, DateTimeKind.Local).AddTicks(281), "Oleksandr_Petik@ukr.net", new DateTime(2024, 1, 19, 22, 55, 57, 901, DateTimeKind.Local).AddTicks(9505), "Щастислав", "Компанієць", "доц.", "5432436633", "Секретар", 16235.91m, "leading edge" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 21, 5, 29, 41, 61, DateTimeKind.Local).AddTicks(3277), "пл. Стрийська, 16, Олександрія, Австралія", new DateTime(2008, 12, 12, 20, 7, 30, 960, DateTimeKind.Local).AddTicks(9309), "Olena_Troyan1@i.ua", new DateTime(2022, 11, 16, 22, 48, 37, 942, DateTimeKind.Local).AddTicks(8935), "Ярополк", "Мотрієнко", "докт. психол. наук", "1489489649", 2936.87m, "metrics" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 8, 29, 9, 19, 24, 475, DateTimeKind.Local).AddTicks(3119), "пров. Староміська, 20, Єнакієве, Буркіна-Фасо", new DateTime(1982, 6, 29, 0, 50, 55, 265, DateTimeKind.Local).AddTicks(4051), "Gorimir40@ex.ua", "Братослав", "Гриневецький", "докт. юрид. наук", "5723856521", "Прибиральник", 9515.76m, "Granite" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 8, 28, 6, 54, 5, 254, DateTimeKind.Local).AddTicks(6342), "Винників майдан, 6, Північний Щек, Болгарія", new DateTime(1960, 11, 10, 1, 42, 22, 738, DateTimeKind.Local).AddTicks(4647), "Dobromira88@meta.ua", "Поляна", "Дмитришин", "канд. психол. наук", "5351328121", 15126.85m, "Sleek" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 6, 21, 19, 9, 820, DateTimeKind.Local).AddTicks(1744), "вулиця Брюховичів, 620, Керч, Східний Тимор", new DateTime(1979, 4, 29, 15, 22, 18, 558, DateTimeKind.Local).AddTicks(8643), "Bratislav_Berdnik9@yandex.ua", null, "Добромила", "Бачей", "канд. психол. наук", "9064706255", 5654.70m, "Handcrafted" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 5, 4, 9, 39, 8, 727, DateTimeKind.Local).AddTicks(2215), "Молодіжна майдан, 7, Північний Андрій, Південний Судан", new DateTime(1950, 9, 4, 20, 4, 33, 363, DateTimeKind.Local).AddTicks(1121), "Petro69@ukr.net", new DateTime(2024, 1, 8, 1, 25, 25, 797, DateTimeKind.Local).AddTicks(9417), "Анастасій", "Ярмак", "доц.", "0057237529", 18869.91m, "Associate" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 26, 7, 57, 8, 217, DateTimeKind.Local).AddTicks(1503), "Ліста майдан, 9, Одеса, Гондурас", new DateTime(1998, 5, 5, 10, 14, 3, 911, DateTimeKind.Local).AddTicks(1066), "Zakhar_Yackiv12@yandex.ua", null, "Антонія", "Сплюх", "докт. філол. наук", "2159727913", "Секретар", 7201.64m, "hacking" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 5, 19, 50, 31, 1, DateTimeKind.Local).AddTicks(4064), "вулиця Стрийська, 4, Східний Тарас, Норвегія", new DateTime(1999, 9, 30, 19, 6, 5, 587, DateTimeKind.Local).AddTicks(5970), "Violetta.Moskal@i.ua", "Іванна", "Каськів", "канд. філос. наук", "1481023517", "Програміст", 6688.63m, "FTP" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 21, 23, 33, 7, 92, DateTimeKind.Local).AddTicks(7949), "Коліївщини майдан, 246, Західний Аврелій, Бенін", new DateTime(1956, 10, 21, 8, 46, 35, 791, DateTimeKind.Local).AddTicks(8471), "Karina.Latanii@yandex.ua", new DateTime(2023, 10, 13, 15, 31, 11, 722, DateTimeKind.Local).AddTicks(2816), "Юстина", "Ємець", "докт. філол. наук", "1276221343", "Бухгалтер", 15911.45m, "copying" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 5, 7, 28, 37, 507, DateTimeKind.Local).AddTicks(1944), "Рудного майдан, 64, Західний Гнат, Естонія", new DateTime(2002, 10, 22, 6, 3, 56, 536, DateTimeKind.Local).AddTicks(5319), "Kupava.Petrina@yandex.ua", null, "Зорян", "Щербак", "докт. політ. наук", "3974867600", "Бухгалтер", 19095.91m, "Islands" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 1, 9, 4, 3, 26, 227, DateTimeKind.Local).AddTicks(386), "вул. Нижанківського, 78, Південний Тихон, Бахрейн", new DateTime(1959, 7, 27, 19, 14, 10, 285, DateTimeKind.Local).AddTicks(6606), "Daleslava.Pagutyak@yandex.ua", null, "Корнелій", "Боярчук", "канд. юрид. наук", "8102373098", "Бухгалтер", 10322.80m, "moderator" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 20, 7, 20, 1, 832, DateTimeKind.Local).AddTicks(1604), "площа Нижанківського, 67, Північний Стефаній, Гренада", new DateTime(1992, 10, 15, 20, 44, 28, 591, DateTimeKind.Local).AddTicks(4216), "Adriyan_Vitryak79@yandex.ua", "Христина", "Стоян", "докт. техн. наук", "5773359341", "Секретар", 8765.53m, "Music" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 25, 22, 13, 1, 262, DateTimeKind.Local).AddTicks(5752), "пл. Зелена, 740, Бердянськ, Велика Британія", new DateTime(2023, 12, 26, 13, 38, 9, 419, DateTimeKind.Local).AddTicks(3404), "Ustim58@ukr.net", new DateTime(2023, 6, 21, 2, 7, 16, 580, DateTimeKind.Local).AddTicks(8035), "Ликера", "Уманець", "канд. філол. наук", "2581021902", 2946.99m, "matrix" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 31, 23, 54, 55, 801, DateTimeKind.Local).AddTicks(3568), "пр. Рудного, 3, Слов’янськ, Індонезія", new DateTime(1982, 6, 18, 8, 44, 3, 314, DateTimeKind.Local).AddTicks(1424), "Albert_Balickii55@e-mail.ua", new DateTime(2020, 2, 29, 3, 16, 47, 732, DateTimeKind.Local).AddTicks(9587), "Тетяна", "Гамула", "докт. юрид. наук", "9208603969", 10378.01m, "toolset" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 23, 19, 27, 51, 724, DateTimeKind.Local).AddTicks(1438), "Винників майдан, 016, Горлівка, Камерун", new DateTime(1981, 1, 16, 5, 18, 14, 281, DateTimeKind.Local).AddTicks(5457), "Yeremii.Usich89@ukr.net", "Кузьма", "Бондаренко", "канд. юрид. наук", "5149927444", "Програміст", 12327.32m, "Unbranded Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 8, 12, 10, 50, 50, 453, DateTimeKind.Local).AddTicks(1372), "Зелена майдан, 085, Ужгород, Болгарія", new DateTime(1960, 11, 30, 9, 29, 31, 317, DateTimeKind.Local).AddTicks(4059), "Vasilina.Palii@yandex.ua", null, "Артемія", "Петренко", "докт. філос. наук", "5084461407", "Прибиральник", 18848.56m, "UAE Dirham" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 12, 0, 54, 43, 123, DateTimeKind.Local).AddTicks(7361), "пл. Вічева, 8, Бровари, Демократична Республіка Конго", new DateTime(2000, 8, 6, 9, 41, 41, 538, DateTimeKind.Local).AddTicks(8426), "Gelena_Luckiv77@yandex.ua", new DateTime(2021, 9, 12, 23, 29, 54, 152, DateTimeKind.Local).AddTicks(613), "Любомир", "Скоропадська", "докт. політ. наук", "9212690141", "Програміст", 10215.83m, "distributed" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 13, 23, 25, 35, 880, DateTimeKind.Local).AddTicks(7433), "Нижанківського майдан, 71, Хмельницький, Палау", new DateTime(1999, 9, 1, 22, 41, 40, 12, DateTimeKind.Local).AddTicks(7300), "Anna_Sirko@ex.ua", null, "Буйтур", "Корнїйчук", "6101009266", "Бухгалтер", 4618.95m, "feed" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 2, 11, 6, 32, 16, 591, DateTimeKind.Local).AddTicks(4722), "пр. Рудного, 85, Чернігів, Угорщина", new DateTime(1962, 5, 8, 21, 34, 11, 17, DateTimeKind.Local).AddTicks(9465), "Zlat_Pavlishin70@yandex.ua", "Владислав", "Громико", "канд. філос. наук", "4925960074", "Програміст", 9715.62m, "Freeway" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 27, 21, 17, 40, 369, DateTimeKind.Local).AddTicks(6888), "Молодіжна майдан, 1, Східний Білослав, Ангола", new DateTime(2018, 7, 11, 16, 2, 11, 400, DateTimeKind.Local).AddTicks(3824), "Apolloniya8@ukr.net", "Корнило", "Шестак", "докт. юрид. наук", "1143921598", 9447.81m, "dynamic" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 9, 3, 20, 12, 43, 273, DateTimeKind.Local).AddTicks(7874), "площа Нижанківського, 85, Північний Захар, Східний Тимор", new DateTime(1986, 2, 24, 10, 36, 56, 798, DateTimeKind.Local).AddTicks(5329), "Anfisa.Petlyura@ukr.net", new DateTime(2020, 3, 22, 13, 27, 57, 615, DateTimeKind.Local).AddTicks(457), "Ростислав", "Сторожук", "докт. техн. наук", "0605631057", "Прибиральник", 9983.28m, "SMS" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 14, 23, 816, DateTimeKind.Local).AddTicks(4497), "провулок Вічева, 1, Східний Братослав, Сент-Люсія", new DateTime(1985, 8, 29, 4, 41, 58, 90, DateTimeKind.Local).AddTicks(5012), "Maryana.Vitryak0@ex.ua", "Дана", "Ликович", "канд. політ. наук", "6827172514", "Програміст", 10114.26m, "Home Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 25, 22, 10, 6, 663, DateTimeKind.Local).AddTicks(8062), "Ліста майдан, 238, Полтава, Сан-Марино", new DateTime(1992, 9, 24, 18, 44, 6, 515, DateTimeKind.Local).AddTicks(1854), "Antin.Yalovii@gmail.com", new DateTime(2022, 1, 13, 0, 48, 40, 987, DateTimeKind.Local).AddTicks(200), "Харитина", "Гамула", "канд. філол. наук", "0562907367", "Бухгалтер", 12454.88m, "payment" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 9, 28, 2, 7, 11, 745, DateTimeKind.Local).AddTicks(6116), "Нижанківського майдан, 6, Нікополь, Тонга", new DateTime(1946, 6, 4, 20, 35, 59, 726, DateTimeKind.Local).AddTicks(449), "Blagovista.Stoyan@meta.ua", new DateTime(2020, 8, 10, 23, 45, 14, 648, DateTimeKind.Local).AddTicks(9030), "Братислав", "Борочко", "канд. і. наук", "7965812718", "Бухгалтер", 2007.24m, "Licensed" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 12, 30, 1, 4, 28, 883, DateTimeKind.Local).AddTicks(3805), "пл. Нижанківського, 06, Південний Подолян, США", new DateTime(1972, 11, 24, 8, 20, 20, 777, DateTimeKind.Local).AddTicks(1919), "Olga5@ukr.net", "Біляна", "Паращук", "канд. філос. наук", "2368555960", "Програміст", 8000.82m, "Fantastic Plastic Bike" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 20, 14, 35, 39, 557, DateTimeKind.Local).AddTicks(8258), "Коліївщини майдан, 026, Рівне, Люксембург", new DateTime(1997, 7, 30, 10, 39, 43, 183, DateTimeKind.Local).AddTicks(7686), "Izyaslav.Galatei6@meta.ua", null, "Кузьма", "Лящук", "канд. психол. наук", "9719145549", "Програміст", 4472.64m, "withdrawal" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 9, 6, 19, 6, 19, 629, DateTimeKind.Local).AddTicks(1600), "вулиця Староміська, 79, Ужгород, Гренада", new DateTime(1954, 3, 21, 4, 51, 33, 644, DateTimeKind.Local).AddTicks(4135), "Vasilina.Minyailo@ex.ua", "Роман", "Данилко", "докт. філол. наук", "8855154933", 6264.04m, "FTP" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 12, 16, 59, 9, 926, DateTimeKind.Local).AddTicks(6232), "пр. Стрийська, 5, Луганськ, Сент-Кітс і Невіс", new DateTime(1946, 7, 11, 9, 56, 45, 291, DateTimeKind.Local).AddTicks(7243), "Daromir.Luchko35@e-mail.ua", new DateTime(2020, 5, 14, 21, 51, 39, 327, DateTimeKind.Local).AddTicks(7228), "Доброслав", "Гордійчук", "канд. філос. наук", "3235173572", "Прибиральник", 10760.27m, "Small Steel Ball" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 24, 5, 45, 16, 570, DateTimeKind.Local).AddTicks(9105), "Вузька майдан, 9, Мелітополь, Єгипет", new DateTime(1964, 8, 4, 9, 8, 29, 542, DateTimeKind.Local).AddTicks(7668), "Vadim89@i.ua", "Матвій", "Сердюк", "канд. техн. наук", "5768428317", "Прибиральник", 3441.53m, "generating" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 16, 2, 44, 13, 491, DateTimeKind.Local).AddTicks(844), "пров. Стрийська, 140, Східний Антон, Сьєрра-Леоне", new DateTime(2003, 3, 21, 4, 36, 18, 91, DateTimeKind.Local).AddTicks(2396), "Shek_Petik@ukr.net", null, "Ликера", "Шкараба", "канд. юрид. наук", "8263002990", "Бухгалтер", 8740.87m, "Savings Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 24, 9, 25, 40, 450, DateTimeKind.Local).AddTicks(6190), "Винників майдан, 4, Севастополь, Джибуті", new DateTime(1985, 11, 1, 21, 44, 53, 516, DateTimeKind.Local).AddTicks(2586), "Afanasii_Palii@e-mail.ua", new DateTime(2020, 10, 9, 22, 24, 27, 721, DateTimeKind.Local).AddTicks(4412), "Лада", "Яцишина", "канд. і. наук", "5924295261", "Директор", 5811.65m, "Surinam Dollar" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 2, 24, 17, 58, 28, 22, DateTimeKind.Local).AddTicks(5567), "Рудного майдан, 920, Північний Олелько, Сенеґал", new DateTime(2002, 10, 25, 11, 11, 23, 873, DateTimeKind.Local).AddTicks(2183), "Avgustin_Zinkevich9@meta.ua", "Немир", "Ялова", "докт. пед. наук", "1721361319", "Секретар", 14116.73m, "Cotton" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 1, 19, 7, 10, 53, DateTimeKind.Local).AddTicks(6847), "Городоцька майдан, 3, Південний Петро, Афганістан", new DateTime(2020, 8, 6, 0, 45, 52, 605, DateTimeKind.Local).AddTicks(1946), "Olena.Luchenko97@e-mail.ua", new DateTime(2020, 11, 18, 2, 25, 35, 601, DateTimeKind.Local).AddTicks(8966), "Анна", "Дурдинець", "проф.", "4286169157", "Директор", 9236.88m, "Handmade" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 23, 9, 23, 6, 145, DateTimeKind.Local).AddTicks(87), "пр. Зелена, 221, Південний Сологуб, Малаві", new DateTime(1954, 11, 15, 13, 58, 26, 791, DateTimeKind.Local).AddTicks(8530), "Lado_Shukhevich@e-mail.ua", null, "Марина", "Юхно", "2184123322", 16441.95m, "Cotton" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 8, 19, 4, 38, 4, 37, DateTimeKind.Local).AddTicks(160), "Стрийська майдан, 9, Західний Стефаній, Латвія", new DateTime(1973, 12, 19, 4, 26, 14, 63, DateTimeKind.Local).AddTicks(1174), "Miron_Bricka@ex.ua", "Ізяслав", "Павлів", "канд. філос. наук", "6296828221", "Прибиральник", 13118.00m, "Rubber" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 7, 19, 0, 29, 335, DateTimeKind.Local).AddTicks(8706), "Ліста майдан, 546, Миколаїв, Португалія", new DateTime(1980, 1, 9, 23, 34, 5, 968, DateTimeKind.Local).AddTicks(5152), "Alevtin14@yandex.ua", new DateTime(2023, 5, 8, 17, 30, 27, 227, DateTimeKind.Local).AddTicks(6363), "Таїсія", "Шкараба", "докт. і. наук", "7752816031", "Прибиральник", 13869.20m, "Guarani" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 14, 14, 35, 11, 487, DateTimeKind.Local).AddTicks(5186), "Староміська майдан, 323, Луцьк, Індонезія", new DateTime(1963, 12, 18, 11, 2, 42, 520, DateTimeKind.Local).AddTicks(5454), "Zakhar_Porivailo@e-mail.ua", new DateTime(2019, 5, 18, 10, 49, 23, 890, DateTimeKind.Local).AddTicks(9335), "Максим", "Калач", "докт. філос. наук", "7693653215", 18950.43m, "Gorgeous Metal Hat" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 9, 26, 1, 54, 42, 593, DateTimeKind.Local).AddTicks(407), "провулок Вузька, 4, Північний Зиновій, Кенія", new DateTime(1947, 11, 8, 5, 50, 24, 898, DateTimeKind.Local).AddTicks(637), "Romena.Osadko@ukr.net", null, "Костянтин", "Маковецька", "докт. техн. наук", "6749233799", 16155.41m, "orchid" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 1, 20, 39, 27, 808, DateTimeKind.Local).AddTicks(8065), "проспект Ліста, 210, Північний Братислав, Мозамбік", new DateTime(1987, 1, 28, 9, 40, 56, 47, DateTimeKind.Local).AddTicks(5625), "Stanislava_Skiba40@e-mail.ua", new DateTime(2020, 2, 29, 6, 8, 11, 780, DateTimeKind.Local).AddTicks(8763), "Назар", "Гарун", "канд. філос. наук", "1212054747", "Секретар", 18501.41m, "protocol" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 2, 22, 5, 10, 20, DateTimeKind.Local).AddTicks(216), "Рудного майдан, 0, Південний Володимир, Чехія", new DateTime(1960, 7, 11, 17, 51, 37, 632, DateTimeKind.Local).AddTicks(2305), "Dobromir_Petrenko47@i.ua", new DateTime(2020, 2, 12, 18, 8, 51, 207, DateTimeKind.Local).AddTicks(3859), "Поліна", "Кулинич", "докт. політ. наук", "9805797695", "Секретар", 8849.84m, "mission-critical" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 11, 25, 4, 14, 17, 724, DateTimeKind.Local).AddTicks(6128), "площа Коліївщини, 5, Східний Омелян, Польща", new DateTime(1966, 4, 9, 1, 15, 54, 656, DateTimeKind.Local).AddTicks(9424), "Oleksandr_Troyan@meta.ua", new DateTime(2020, 1, 10, 4, 59, 25, 525, DateTimeKind.Local).AddTicks(8022), "Артемія", "Потебенько", "канд. і. наук", "8109426120", "Бухгалтер", 9224.00m, "deposit" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 9, 22, 15, 18, 45, 398, DateTimeKind.Local).AddTicks(4643), "Староміська майдан, 117, Слов’янськ, Сент-Вінсент і Гренадини", new DateTime(1998, 1, 26, 19, 5, 24, 630, DateTimeKind.Local).AddTicks(8374), "Bogdan_Unich@i.ua", null, "Марія", "Ломова", "докт. філос. наук", "9116568209", "Бухгалтер", 16639.90m, "Manager" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 29, 12, 27, 31, 296, DateTimeKind.Local).AddTicks(6411), "Нижанківського майдан, 16, Східний Денис, Україна", new DateTime(2016, 1, 12, 12, 6, 44, 50, DateTimeKind.Local).AddTicks(3724), "Yulian76@gmail.com", null, "Марія", "Балабуха", "докт. філол. наук", "4009192861", 4609.20m, "moderator" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 6, 12, 58, 12, 484, DateTimeKind.Local).AddTicks(7949), "вулиця Городоцька, 684, Західний Хорив, Північна Корея", new DateTime(2021, 7, 25, 8, 31, 59, 770, DateTimeKind.Local).AddTicks(7334), "Ratibor_Yanyuk52@ukr.net", new DateTime(2021, 7, 31, 21, 38, 23, 281, DateTimeKind.Local).AddTicks(196), "Юстина", "Шестак", "докт. філос. наук", "7770283630", "Директор", 2484.98m, "parsing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 4, 9, 13, 32, 911, DateTimeKind.Local).AddTicks(8316), "вулиця Коліївщини, 78, Донецьк, Маршаллові Острови", new DateTime(1979, 2, 8, 13, 57, 26, 869, DateTimeKind.Local).AddTicks(9309), "Yurii_Didukh38@ex.ua", "Зеновій", "Дзюб’як", "канд. філол. наук", "2804977259", 14158.28m, "Home Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 25, 8, 49, 53, 358, DateTimeKind.Local).AddTicks(4603), "вул. Брюховичів, 52, Південний Марко, Сент-Люсія", new DateTime(1965, 8, 4, 13, 30, 16, 965, DateTimeKind.Local).AddTicks(9617), "Izyaslav4@e-mail.ua", "Устина", "Лазірко", "докт. політ. наук", "0856957877", "Директор", 17651.12m, "Trafficway" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 16, 21, 5, 0, 891, DateTimeKind.Local).AddTicks(5057), "пл. Стрийська, 879, Східний Остап, Словенія", new DateTime(1963, 7, 17, 17, 24, 29, 630, DateTimeKind.Local).AddTicks(6793), "Pelagiya_Ponomariv@i.ua", new DateTime(2019, 12, 5, 3, 52, 24, 464, DateTimeKind.Local).AddTicks(3518), "Ізяслав", "Компанієць", "канд. філос. наук", "4651229518", "Секретар", 15841.66m, "Soft" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 28, 18, 53, 13, 59, DateTimeKind.Local).AddTicks(5358), "Стрийська майдан, 80, Горлівка, Болівія", new DateTime(1996, 6, 12, 13, 55, 26, 485, DateTimeKind.Local).AddTicks(6560), "Svyatoslav_Savicka82@yandex.ua", "Радослава", "Бердник", "докт. і. наук", "8441261934", "Програміст", 3502.55m, "Buckinghamshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 23, 15, 784, DateTimeKind.Local).AddTicks(8534), "Стрийська майдан, 9, Нікополь, Данія", new DateTime(1967, 12, 4, 17, 44, 40, 164, DateTimeKind.Local).AddTicks(9279), "Vitalina_Zlenko51@meta.ua", null, "Аліна", "Могилевський", "докт. філол. наук", "6573171538", "Програміст", 11231.02m, "haptic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 20, 9, 12, 42, 555, DateTimeKind.Local).AddTicks(399), "площа Молодіжна, 01, Чернівці, Сейшельські Острови", new DateTime(1972, 2, 4, 17, 40, 38, 626, DateTimeKind.Local).AddTicks(1959), "Kornilii7@meta.ua", null, "Матвій", "Юрчишина", "докт. і. наук", "9763473743", "Прибиральник", 15064.63m, "Up-sized" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 13, 22, 45, 42, 653, DateTimeKind.Local).AddTicks(7238), "Ліста майдан, 19, Павлоград, Австрія", new DateTime(1988, 7, 19, 11, 29, 38, 890, DateTimeKind.Local).AddTicks(58), "Dobroslava.Baranovskii72@ukr.net", "Хорив", "Миклухо", "канд. політ. наук", "5862413428", "Бухгалтер", 4496.26m, "Qatari Rial" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 11, 22, 17, 32, 2, 380, DateTimeKind.Local).AddTicks(9532), "площа Винників, 9, Ужгород, Гвінея", new DateTime(1968, 7, 5, 0, 17, 19, 631, DateTimeKind.Local).AddTicks(2293), "Nataliya_Butko14@i.ua", null, "Лариса", "Стигайло", "докт. техн. наук", "8521805156", 18642.06m, "Metal" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 11, 4, 10, 15, 34, 374, DateTimeKind.Local).AddTicks(1006), "пл. Коліївщини, 0, Західний Борислав, Замбія", new DateTime(1945, 7, 4, 18, 46, 56, 895, DateTimeKind.Local).AddTicks(2852), "Dobromisl.Unich@yandex.ua", new DateTime(2022, 5, 25, 3, 59, 26, 253, DateTimeKind.Local).AddTicks(5300), "Кузьма", "Марієвська", "проф.", "2744821023", 7967.50m, "Ergonomic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 25, 18, 15, 6, 567, DateTimeKind.Local).AddTicks(2603), "Зелена майдан, 86, Луганськ, Кірибаті", new DateTime(1979, 2, 17, 12, 41, 34, 109, DateTimeKind.Local).AddTicks(5044), "Ladislav_Yanyuk25@ex.ua", null, "Радміла", "Ярмак", "проф.", "7562200321", "Бухгалтер", 1503.97m, "Practical" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 8, 13, 10, 32, 27, 206, DateTimeKind.Local).AddTicks(2546), "Коліївщини майдан, 3, Північний Будимир, Нова Зеландія", new DateTime(1944, 9, 24, 18, 35, 15, 327, DateTimeKind.Local).AddTicks(5080), "Dmitro.Kovalenko97@ukr.net", "Калина", "Бамбула", "докт. техн. наук", "5468364121", "Прибиральник", 3161.15m, "Republic of Korea" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 14, 31, 932, DateTimeKind.Local).AddTicks(5518), "Молодіжна майдан, 5, Східний Хвалимир, Антигуа і Барбуда", new DateTime(1978, 5, 20, 20, 12, 58, 272, DateTimeKind.Local).AddTicks(6042), "Lesya24@gmail.com", new DateTime(2022, 8, 31, 0, 54, 39, 170, DateTimeKind.Local).AddTicks(4674), "Пелагія", "Шкараба", "канд. і. наук", "5940586339", 17314.46m, "PCI" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 9, 19, 21, 30, 54, 950, DateTimeKind.Local).AddTicks(5143), "вулиця Ліста, 59, Східний Синьоок, Парагвай", new DateTime(2001, 12, 13, 16, 32, 19, 182, DateTimeKind.Local).AddTicks(99), "Velemir_Ganich44@yandex.ua", "Юліанна", "Ющук", "канд. філос. наук", "6480699019", "Секретар", 12917.73m, "Tugrik" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 1, 7, 14, 41, 21, 367, DateTimeKind.Local).AddTicks(5817), "Молодіжна майдан, 3, Північний Вадим, Мозамбік", new DateTime(1973, 3, 5, 8, 47, 36, 823, DateTimeKind.Local).AddTicks(6666), "Nemira.Sayenko@meta.ua", null, "Олелько", "Ющук", "канд. політ. наук", "1337751670", "Програміст", 6531.14m, "Grocery, Toys & Outdoors" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 11, 6, 20, 7, 49, 394, DateTimeKind.Local).AddTicks(6389), "пров. Вічева, 711, Нікополь, Соломонові Острови", new DateTime(2008, 1, 10, 21, 6, 7, 891, DateTimeKind.Local).AddTicks(2665), "Afanasii.Mazailo84@gmail.com", "Натан", "Пагутяк", "канд. політ. наук", "2580153641", 1354.02m, "Swiss Franc" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 1, 7, 25, 31, 347, DateTimeKind.Local).AddTicks(9848), "пр. Коліївщини, 4, Південний Семибор, Непал", new DateTime(1964, 11, 1, 5, 28, 42, 758, DateTimeKind.Local).AddTicks(6783), "Dobromir_Pogiba@i.ua", "Дмитро", "Стоян", "докт. техн. наук", "1126460577", "Програміст", 16692.68m, "Program" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 26, 6, 30, 15, 579, DateTimeKind.Local).AddTicks(8555), "Брюховичів майдан, 5, Горлівка, Швеція", new DateTime(1945, 6, 3, 21, 23, 56, 168, DateTimeKind.Local).AddTicks(7932), "Timofii.Mamii82@meta.ua", "Ярослава", "Паламарчук", "докт. юрид. наук", "9083120048", 12066.87m, "Land" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 20, 22, 3, 18, 801, DateTimeKind.Local).AddTicks(1615), "Ліста майдан, 778, Дніпропетровськ, Оман", new DateTime(1979, 5, 23, 17, 38, 50, 573, DateTimeKind.Local).AddTicks(6408), "Diyana84@i.ua", new DateTime(2020, 5, 27, 22, 13, 35, 737, DateTimeKind.Local).AddTicks(737), "Ратимир", "Зінкевич", "докт. філос. наук", "3445219366", "Програміст", 12606.79m, "Place" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 26, 7, 38, 45, 794, DateTimeKind.Local).AddTicks(6494), "площа Зелена, 134, Дніпродзержинськ, Венесуела", new DateTime(1945, 12, 3, 18, 29, 42, 726, DateTimeKind.Local).AddTicks(1911), "Borimisl73@yandex.ua", null, "Мечислава", "Семеночко", "канд. техн. наук", "3283960878", 19738.94m, "Mountain" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 1, 9, 11, 5, 1, 5, DateTimeKind.Local).AddTicks(8169), "вул. Староміська, 29, Південний Тихон, Гамбія", new DateTime(1993, 9, 29, 13, 42, 38, 225, DateTimeKind.Local).AddTicks(1201), "Avreliya36@meta.ua", null, "Матвій", "Довгалевська", "7267807315", "Програміст", 8114.40m, "Dynamic" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 16, 23, 58, 17, 837, DateTimeKind.Local).AddTicks(4162), "Ліста майдан, 1, Одеса, Північна Корея", new DateTime(1969, 11, 21, 15, 53, 16, 945, DateTimeKind.Local).AddTicks(6030), "Yana_Semenochko@yandex.ua", "Братослав", "Малкович", "доц.", "2883421342", "Програміст", 2291.77m, "navigate" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 3, 12, 21, 42, 21, 784, DateTimeKind.Local).AddTicks(4176), "вул. Староміська, 625, Сєвєродонецьк, Катар", new DateTime(1989, 8, 15, 12, 39, 13, 395, DateTimeKind.Local).AddTicks(1838), "Dobroslava_Vasilin12@ex.ua", null, "Леся", "Зінкевич", "докт. політ. наук", "0072293967", "Прибиральник", 14375.89m, "white" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 4, 3, 13, 53, 53, 191, DateTimeKind.Local).AddTicks(5833), "вул. Нижанківського, 91, Красний Луч, Уругвай", new DateTime(2005, 5, 1, 16, 38, 4, 223, DateTimeKind.Local).AddTicks(3068), "Lyubomila_Savicka41@gmail.com", null, "Азарій", "Ткаченко", "канд. філол. наук", "0837890039", 7339.48m, "bandwidth" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 1, 10, 15, 10, 830, DateTimeKind.Local).AddTicks(225), "площа Коліївщини, 075, Західний Аврелій, Алжир", new DateTime(1982, 6, 25, 0, 12, 29, 992, DateTimeKind.Local).AddTicks(9807), "Smiyana.Tretyak44@ex.ua", new DateTime(2021, 6, 15, 22, 50, 25, 323, DateTimeKind.Local).AddTicks(2766), "Тамара", "Махно", "докт. філол. наук", "4190678068", "Програміст", 14386.08m, "benchmark" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 2, 12, 44, 27, 174, DateTimeKind.Local).AddTicks(2782), "пл. Ліста, 1, Лисичанськ, Румунія", new DateTime(1961, 3, 13, 11, 42, 49, 365, DateTimeKind.Local).AddTicks(4863), "Valentin64@ukr.net", new DateTime(2021, 8, 23, 10, 48, 23, 718, DateTimeKind.Local).AddTicks(1713), "Азалія", "Петлюра", "докт. і. наук", "4433375021", 7899.85m, "web-enabled" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 12, 9, 0, 8, 50, 35, DateTimeKind.Local).AddTicks(4785), "Коліївщини майдан, 8, Південний Ладислав, Бруней", new DateTime(2006, 7, 3, 18, 55, 10, 585, DateTimeKind.Local).AddTicks(5111), "Vitalina_Gaichuk57@yandex.ua", new DateTime(2020, 4, 12, 2, 43, 5, 512, DateTimeKind.Local).AddTicks(7744), "Агнеса", "Потоцька", "канд. філос. наук", "7439386402", 10267.42m, "Direct" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 20, 11, 43, 46, 731, DateTimeKind.Local).AddTicks(3560), "провулок Брюховичів, 12, Маріуполь, Таїланд", new DateTime(1972, 8, 25, 16, 48, 18, 21, DateTimeKind.Local).AddTicks(3114), "Inna92@ukr.net", null, "Олексій", "Юхно", "докт. пед. наук", "1531766397", 11665.32m, "Forest" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 26, 12, 28, 17, 99, DateTimeKind.Local).AddTicks(7474), "пл. Нижанківського, 46, Східний Степан, Туніс", new DateTime(1944, 8, 3, 16, 39, 55, 92, DateTimeKind.Local).AddTicks(1055), "Borimir16@gmail.com", "Ольга", "Петик", "канд. пед. наук", "5251522165", "Прибиральник", 1294.84m, "Regional" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 27, 8, 14, 4, 306, DateTimeKind.Local).AddTicks(5573), "Рудного майдан, 7, Східний Божен, Намібія", new DateTime(1974, 11, 17, 14, 45, 46, 144, DateTimeKind.Local).AddTicks(9016), "Dobromila_Vergun29@ex.ua", null, "Захар", "Опенько", "докт. філол. наук", "5962106394", "Секретар", 15493.41m, "Home Loan Account" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 30, 9, 36, 38, 168, DateTimeKind.Local).AddTicks(5986), "Коліївщини майдан, 1, Одеса, Сьєрра-Леоне", new DateTime(1947, 5, 29, 23, 25, 20, 97, DateTimeKind.Local).AddTicks(6546), "Gerasim_Romochko@i.ua", null, "Пантелеймон", "Гайчук", "канд. філол. наук", "5775542949", 4398.80m, "technologies" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 28, 10, 37, 33, 965, DateTimeKind.Local).AddTicks(8602), "пр. Стрийська, 7, Східний Юрій, Люксембург", new DateTime(2002, 12, 24, 19, 25, 49, 637, DateTimeKind.Local).AddTicks(9605), "Kornilo92@gmail.com", new DateTime(2023, 9, 23, 2, 59, 5, 842, DateTimeKind.Local).AddTicks(3068), "Горимир", "Третяк", "7751247467", "Секретар", 10207.96m, "Granite" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 11, 8, 19, 20, 36, 871, DateTimeKind.Local).AddTicks(7962), "пров. Рудного, 0, Північний Лад, Австрія", new DateTime(1972, 2, 17, 11, 44, 2, 974, DateTimeKind.Local).AddTicks(1380), "Khristina_Stepanec47@gmail.com", new DateTime(2021, 2, 8, 18, 48, 56, 547, DateTimeKind.Local).AddTicks(2176), "Милодара", "Спотикач", "6067229599", "Директор", 8068.45m, "incremental" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 4, 12, 8, 48, 33, 802, DateTimeKind.Local).AddTicks(7892), "Коліївщини майдан, 68, Макіївка, Домініканська Республіка", new DateTime(1973, 3, 7, 4, 53, 47, 449, DateTimeKind.Local).AddTicks(1769), "Avrelii_Babukh89@gmail.com", new DateTime(2022, 6, 6, 5, 45, 25, 729, DateTimeKind.Local).AddTicks(6244), "Братомил", "Балабан", "докт. юрид. наук", "7202146559", 4800.45m, "hard drive" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 4, 14, 4, 35, 11, 109, DateTimeKind.Local).AddTicks(5845), "пр. Городоцька, 08, Конотоп, Бангладеш", new DateTime(1948, 9, 19, 16, 44, 53, 49, DateTimeKind.Local).AddTicks(1781), "Timofii_Korecka55@meta.ua", new DateTime(2020, 9, 14, 17, 15, 43, 41, DateTimeKind.Local).AddTicks(2151), "Велемир", "Приймак", "докт. пед. наук", "6452823803", 5339.97m, "Auto Loan Account" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 7, 15, 7, 36, 46, 450, DateTimeKind.Local).AddTicks(6661), "Вузька майдан, 50, Артемівськ, Перу", new DateTime(1972, 4, 10, 9, 44, 46, 284, DateTimeKind.Local).AddTicks(779), "Dobromisl.Makovecka22@e-mail.ua", new DateTime(2022, 6, 13, 2, 53, 44, 55, DateTimeKind.Local).AddTicks(543), "Радим", "Барановський", "докт. техн. наук", "4484164522", 19795.06m, "Licensed" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 12, 1, 13, 28, 27, 593, DateTimeKind.Local).AddTicks(6952), "провулок Молодіжна, 9, Житомир, Алжир", new DateTime(1953, 4, 26, 1, 7, 35, 934, DateTimeKind.Local).AddTicks(111), "Kornilii75@ex.ua", null, "Клавдія", "Ломова", "канд. політ. наук", "1520000521", 15045.78m, "Unbranded Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 20, 7, 32, 47, 637, DateTimeKind.Local).AddTicks(5704), "Городоцька майдан, 078, Західний Архип, Австрія", new DateTime(1970, 10, 8, 20, 3, 48, 917, DateTimeKind.Local).AddTicks(5522), "Ganna_Kolomiyec73@ukr.net", "Болеслава", "Гнатишин", "докт. філос. наук", "8317520808", 2003.94m, "channels" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 18, 20, 32, 12, 288, DateTimeKind.Local).AddTicks(3259), "вулиця Брюховичів, 47, Південний Лаврентій, Чилі", new DateTime(2012, 12, 19, 22, 33, 14, 345, DateTimeKind.Local).AddTicks(6818), "Markiyan_Demkiv34@ex.ua", null, "Пантелеймон", "Ялюк", "канд. юрид. наук", "3739913857", "Прибиральник", 1130.83m, "flexibility" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 2, 16, 44, 51, 373, DateTimeKind.Local).AddTicks(5457), "Молодіжна майдан, 519, Північний Орест, Чехія", new DateTime(1986, 3, 27, 15, 8, 1, 920, DateTimeKind.Local).AddTicks(7678), "Bozhemir_Garai@i.ua", "Кий", "Білич", "канд. пед. наук", "9416588737", "Бухгалтер", 17758.89m, "executive" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 3, 43, 455, DateTimeKind.Local).AddTicks(2185), "пров. Стрийська, 564, Єнакієве, Бруней", new DateTime(2019, 10, 15, 10, 54, 41, 546, DateTimeKind.Local).AddTicks(5822), "Marko45@e-mail.ua", new DateTime(2021, 2, 17, 9, 56, 39, 959, DateTimeKind.Local).AddTicks(3737), "Доброслав", "Ющук", "канд. психол. наук", "2917530498", 9362.64m, "24/7" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 11, 1, 9, 2, 3, 499, DateTimeKind.Local).AddTicks(2244), "Вузька майдан, 3, Східний Петро, Південний Судан", new DateTime(1962, 7, 5, 23, 10, 19, 843, DateTimeKind.Local).AddTicks(3720), "Khoriv9@yandex.ua", "Ореста", "Брицька", "докт. техн. наук", "2637198367", "Бухгалтер", 6959.11m, "Kids, Health & Jewelery" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 25, 8, 59, 59, 431, DateTimeKind.Local).AddTicks(5517), "пл. Стрийська, 3, Східний Білослав, Білорусь", new DateTime(2011, 8, 5, 19, 1, 59, 400, DateTimeKind.Local).AddTicks(8966), "Boris_Shevchenko@gmail.com", "Ада", "Гордійчук", "проф.", "9520147659", "Бухгалтер", 17236.98m, "Optional" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 5, 2, 16, 45, 30, 410, DateTimeKind.Local).AddTicks(6029), "Коліївщини майдан, 727, Південний Зоремир, Бахрейн", new DateTime(1954, 4, 20, 8, 1, 37, 704, DateTimeKind.Local).AddTicks(3833), "Galina.Mazun@ukr.net", null, "Юхимія", "Василин", "докт. техн. наук", "4448230729", "Директор", 12231.47m, "calculating" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 45, 22, 338, DateTimeKind.Local).AddTicks(8866), "Нижанківського майдан, 4, Південний Яровид, Алжир", new DateTime(1975, 5, 24, 14, 57, 3, 727, DateTimeKind.Local).AddTicks(3779), "Viktor_Yurchishin@yandex.ua", "Орина", "Янюк", "канд. і. наук", "6127023463", 2246.29m, "National" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 3, 7, 19, 2, 18, 951, DateTimeKind.Local).AddTicks(4245), "Вузька майдан, 0, Полтава, Сент-Люсія", new DateTime(1964, 2, 11, 21, 57, 32, 744, DateTimeKind.Local).AddTicks(3187), "Oles.Miloslavska25@ex.ua", "Ромена", "Лановий", "проф.", "8694576589", "Програміст", 11594.21m, "RSS" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 27, 17, 55, 10, 636, DateTimeKind.Local).AddTicks(537), "проспект Зелена, 0, Східний Зореслав, Чорногорія", new DateTime(1989, 11, 10, 13, 8, 50, 314, DateTimeKind.Local).AddTicks(1188), "Borislava.Pavlenko@ex.ua", new DateTime(2022, 5, 19, 3, 17, 54, 690, DateTimeKind.Local).AddTicks(8032), "Кий", "Кивач", "докт. психол. наук", "8352315736", 9831.29m, "Future" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 2, 4, 25, 2, 34, DateTimeKind.Local).AddTicks(1006), "Городоцька майдан, 4, Запоріжжя, Сомалі", new DateTime(1957, 3, 10, 7, 10, 51, 648, DateTimeKind.Local).AddTicks(5184), "Krentta.Bambula@meta.ua", null, "Ратибор", "Сідляк", "канд. філос. наук", "3269850981", "Прибиральник", 13584.50m, "SSL" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 2, 52, 225, DateTimeKind.Local).AddTicks(7639), "проспект Ліста, 0, Луцьк, Маврикій", new DateTime(1987, 11, 11, 17, 59, 10, 504, DateTimeKind.Local).AddTicks(5497), "Pelagiya.Storozhuk@yandex.ua", null, "Поляна", "Головець", "докт. техн. наук", "5157229701", "Директор", 10111.42m, "Garden, Industrial & Garden" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 0, 25, 843, DateTimeKind.Local).AddTicks(1955), "вул. Винників, 02, Євпаторія, Сербія", new DateTime(1952, 9, 27, 14, 48, 20, 748, DateTimeKind.Local).AddTicks(7095), "Azarii_Galacion@e-mail.ua", "Ігор", "Гордійчук", "докт. політ. наук", "6026154594", "Директор", 9533.53m, "Creative" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 8, 18, 0, 58, 22, 153, DateTimeKind.Local).AddTicks(6154), "Зелена майдан, 85, Південний Яромил, Свазіленд", new DateTime(2005, 8, 25, 7, 17, 59, 426, DateTimeKind.Local).AddTicks(1373), "Marina_Balabukh@e-mail.ua", "Зборислав", "Петренко", "проф.", "8016291214", "Програміст", 3002.52m, "Incredible Wooden Towels" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 3, 15, 17, 4, 3, 913, DateTimeKind.Local).AddTicks(2598), "Винників майдан, 50, Північний Владислав, Мальта", new DateTime(1998, 5, 10, 14, 15, 25, 962, DateTimeKind.Local).AddTicks(8521), "Chornota_Savicka@yandex.ua", "Натан", "Вітряк", "докт. пед. наук", "9545949435", "Прибиральник", 3146.11m, "Technician" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 4, 15, 5, 20, 308, DateTimeKind.Local).AddTicks(639), "Нижанківського майдан, 834, Західний Братомил, Ліхтенштейн", new DateTime(1983, 9, 27, 10, 41, 25, 263, DateTimeKind.Local).AddTicks(3503), "Olena_Koman@gmail.com", new DateTime(2020, 10, 16, 10, 34, 9, 803, DateTimeKind.Local).AddTicks(7297), "Анжела", "Каськів", "1791194137", 6420.25m, "Fork" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 33, 14, 761, DateTimeKind.Local).AddTicks(8081), "пр. Рудного, 41, Олександрія, Сенеґал", new DateTime(1945, 8, 13, 16, 22, 48, 420, DateTimeKind.Local).AddTicks(597), "Khristina_Dzyuba@gmail.com", null, "Орина", "Гамула", "канд. пед. наук", "9382938326", "Секретар", 5051.70m, "Small Wooden Hat" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 5, 17, 6, 7, 45, 859, DateTimeKind.Local).AddTicks(5789), "Вузька майдан, 68, Східний Тур, Туреччина", new DateTime(1965, 4, 5, 21, 43, 42, 879, DateTimeKind.Local).AddTicks(1602), "Gorislav.Yevpak@ukr.net", new DateTime(2019, 7, 25, 3, 30, 52, 267, DateTimeKind.Local).AddTicks(4773), "Юхим", "Брицька", "доц.", "9406075105", 11752.75m, "turquoise" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 8, 4, 20, 13, 851, DateTimeKind.Local).AddTicks(9612), "Староміська майдан, 138, Східний Кузьма, Малайзія", new DateTime(1976, 11, 20, 22, 3, 22, 964, DateTimeKind.Local).AddTicks(9475), "Zlatomir36@gmail.com", new DateTime(2020, 4, 4, 18, 21, 46, 939, DateTimeKind.Local).AddTicks(1135), "Ілона", "Ліхно", "8182007764", "Прибиральник", 8204.23m, "hybrid" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 24, 3, 3, 14, 649, DateTimeKind.Local).AddTicks(3221), "пл. Рудного, 307, Східний Братомил, Маврикій", new DateTime(2018, 5, 11, 11, 56, 5, 985, DateTimeKind.Local).AddTicks(2262), "Volodimir_Petrenko@ex.ua", null, "Богуслава", "Галатей", "докт. філол. наук", "0760527079", "Бухгалтер", 17929.65m, "bypass" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 5, 15, 15, 13, 234, DateTimeKind.Local).AddTicks(7811), "Зелена майдан, 89, Кременчук, Домініканська Республіка", new DateTime(1961, 5, 3, 22, 37, 47, 915, DateTimeKind.Local).AddTicks(2895), "Syuzana_Maistrenko@ukr.net", null, "Мокрина", "Ланова", "докт. психол. наук", "4560704316", "Бухгалтер", 4588.23m, "Small" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 4, 6, 22, 34, 45, 87, DateTimeKind.Local).AddTicks(9555), "пл. Вузька, 9, Кам’янець-Подільський, Бахрейн", new DateTime(1947, 4, 27, 12, 20, 45, 950, DateTimeKind.Local).AddTicks(8804), "Agnesa_Lindik@i.ua", new DateTime(2019, 12, 12, 22, 50, 54, 0, DateTimeKind.Local).AddTicks(6095), "Добринка", "Гойко", "доц.", "8962958781", "Секретар", 2136.89m, "function" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 4, 13, 33, 36, 846, DateTimeKind.Local).AddTicks(3514), "провулок Вічева, 629, Західний Мусій, Беліз", new DateTime(1965, 11, 26, 6, 20, 11, 820, DateTimeKind.Local).AddTicks(9870), "Yarovid_Malkovich91@e-mail.ua", null, "Боримисл", "Волощук", "докт. техн. наук", "1944582950", 5796.99m, "Clothing & Books" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 28, 15, 6, 11, 292, DateTimeKind.Local).AddTicks(3904), "вулиця Винників, 693, Південний Микола, Суринам", new DateTime(1984, 7, 31, 3, 34, 19, 741, DateTimeKind.Local).AddTicks(67), "Lyubov69@i.ua", new DateTime(2022, 6, 6, 8, 51, 23, 815, DateTimeKind.Local).AddTicks(2017), "Захар", "Головець", "6938716549", "Секретар", 6495.81m, "wireless" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 3, 2, 31, 19, 313, DateTimeKind.Local).AddTicks(3217), "Староміська майдан, 1, Східний Данило, Куба", new DateTime(2014, 3, 3, 22, 36, 19, 355, DateTimeKind.Local).AddTicks(211), "Khoriv_Dovgalevskii25@gmail.com", null, "Горимир", "Шудрик", "докт. пед. наук", "7505893568", 11803.90m, "infomediaries" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 10, 10, 8, 13, 2, 646, DateTimeKind.Local).AddTicks(1002), "вулиця Молодіжна, 02, Хмельницький, Ватикан", new DateTime(1964, 7, 9, 17, 32, 1, 301, DateTimeKind.Local).AddTicks(7587), "Miroslava_Mamii@gmail.com", null, "Брячислав", "Горбач", "канд. пед. наук", "7063897449", "Бухгалтер", 12246.08m, "microchip" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 16, 10, 3, 41, 505, DateTimeKind.Local).AddTicks(3190), "Староміська майдан, 63, Східний Руслан, Гайана", new DateTime(1973, 7, 24, 3, 5, 39, 417, DateTimeKind.Local).AddTicks(3058), "Denis_Lomovii@meta.ua", null, "Христина", "Мазун", "докт. філос. наук", "8997145742", "Бухгалтер", 12085.74m, "Electronics" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 29, 1, 17, 12, 716, DateTimeKind.Local).AddTicks(5319), "Зелена майдан, 4, Північний Зборислав, Португалія", new DateTime(1978, 1, 24, 22, 15, 14, 77, DateTimeKind.Local).AddTicks(4639), "Adriana_Ponomariv@ukr.net", "Таїсія", "Лучко", "доц.", "8834892656", "Директор", 10197.64m, "initiatives" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 7, 22, 46, 26, 785, DateTimeKind.Local).AddTicks(1260), "Городоцька майдан, 35, Умань, Туреччина", new DateTime(2001, 11, 9, 17, 34, 43, 731, DateTimeKind.Local).AddTicks(4355), "Gavrilo_Voloshuk@e-mail.ua", null, "Поляна", "Уманець", "канд. пед. наук", "5994716643", "Бухгалтер", 7074.77m, "Refined Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 8, 18, 41, 59, 382, DateTimeKind.Local).AddTicks(4540), "вул. Коліївщини, 7, Кременчук, Російська Федерація", new DateTime(2008, 8, 22, 17, 27, 2, 880, DateTimeKind.Local).AddTicks(6097), "Miloslava.Kulinich92@ex.ua", "Синьоок", "Луцьків", "докт. і. наук", "1591314660", "Програміст", 15552.43m, "Unbranded Fresh Pizza" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 9, 26, 1, 18, 32, 731, DateTimeKind.Local).AddTicks(1353), "Коліївщини майдан, 573, Південний Данило, Малаві", new DateTime(1991, 10, 7, 0, 46, 43, 457, DateTimeKind.Local).AddTicks(526), "Slavuta60@ukr.net", new DateTime(2019, 6, 13, 15, 37, 22, 634, DateTimeKind.Local).AddTicks(7210), "Мирон", "Забіла", "докт. психол. наук", "8729105241", "Прибиральник", 5557.56m, "Orchestrator" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 9, 15, 15, 0, 53, 169, DateTimeKind.Local).AddTicks(4751), "проспект Вічева, 72, Східний Будимир, Болгарія", new DateTime(2005, 7, 9, 15, 8, 51, 536, DateTimeKind.Local).AddTicks(2551), "Buitur.Usich85@gmail.com", new DateTime(2020, 7, 13, 13, 52, 44, 199, DateTimeKind.Local).AddTicks(9659), "Мирон", "Ногачевський", "проф.", "2627793610", 12804.51m, "Ameliorated" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 9, 19, 12, 52, 41, 528, DateTimeKind.Local).AddTicks(7466), "пл. Коліївщини, 3, Кременчук, Габон", new DateTime(1952, 11, 14, 2, 59, 39, 240, DateTimeKind.Local).AddTicks(8155), "Pelagiya_Tarasyuk@e-mail.ua", new DateTime(2023, 7, 14, 20, 54, 35, 463, DateTimeKind.Local).AddTicks(2446), "Оріяна", "Ногачевська", "канд. філос. наук", "8711956463", "Прибиральник", 14522.73m, "task-force" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 3, 6, 12, 51, 17, 269, DateTimeKind.Local).AddTicks(2764), "вул. Зелена, 6, Західний Горимир, Сент-Люсія", new DateTime(1985, 4, 14, 8, 47, 37, 470, DateTimeKind.Local).AddTicks(7543), "Marina.Yanyuk@ukr.net", null, "Добромира", "Латанська", "канд. і. наук", "5797690165", "Бухгалтер", 18336.11m, "Computers" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 7, 17, 56, 51, 431, DateTimeKind.Local).AddTicks(6943), "Нижанківського майдан, 547, Західний Стожар, Туреччина", new DateTime(1998, 12, 23, 5, 38, 34, 199, DateTimeKind.Local).AddTicks(1072), "Larisa_Stakhiv93@yandex.ua", "Геннадій", "Цушко", "канд. техн. наук", "6009149893", "Секретар", 14351.78m, "Sleek Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 9, 26, 1, 12, 2, 306, DateTimeKind.Local).AddTicks(5286), "Нижанківського майдан, 879, Західний Натан, Центральноафриканська Республіка", new DateTime(1988, 2, 29, 12, 17, 1, 409, DateTimeKind.Local).AddTicks(3750), "Zhanna9@ex.ua", "Братислав", "Шиян", "0809706123", "Бухгалтер", 4638.60m, "Delaware" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 5, 13, 16, 16, 37, 462, DateTimeKind.Local).AddTicks(6272), "пр. Вузька, 209, Херсон, Японія", new DateTime(1948, 1, 19, 6, 47, 21, 182, DateTimeKind.Local).AddTicks(4914), "Andrii.Kalach72@yandex.ua", "Олег", "Магера", "канд. юрид. наук", "2564552974", "Програміст", 16346.94m, "reboot" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 1, 19, 4, 35, 89, DateTimeKind.Local).AddTicks(1134), "Молодіжна майдан, 176, Західний Далемир, Афганістан", new DateTime(1966, 8, 30, 7, 46, 39, 68, DateTimeKind.Local).AddTicks(1289), "Denis_Shumilo@yandex.ua", null, "Христя", "Миклашевський", "канд. філос. наук", "4602001176", 9393.63m, "Refined" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 12, 1, 12, 38, 56, 60, DateTimeKind.Local).AddTicks(4533), "Ліста майдан, 87, Івано-Франківськ, Танзанія", new DateTime(1972, 5, 20, 22, 45, 11, 615, DateTimeKind.Local).AddTicks(3166), "Marko.Sosyura@yandex.ua", "Олена", "Дзюб’як", "докт. і. наук", "6744132062", "Прибиральник", 9273.45m, "Sleek" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 1, 9, 12, 6, 47, 586, DateTimeKind.Local).AddTicks(2083), "провулок Городоцька, 5, Західний Геннадій, Гондурас", new DateTime(1954, 10, 30, 1, 55, 14, 550, DateTimeKind.Local).AddTicks(2482), "Yaropolk.Osadko@ukr.net", new DateTime(2021, 2, 28, 2, 31, 5, 700, DateTimeKind.Local).AddTicks(5514), "Ликера", "Гаман", "канд. філос. наук", "2440402139", "Директор", 15327.80m, "Assimilated" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 3, 8, 5, 42, 58, 72, DateTimeKind.Local).AddTicks(527), "вул. Ліста, 086, Умань, Сент-Люсія", new DateTime(1954, 5, 31, 13, 58, 36, 407, DateTimeKind.Local).AddTicks(1735), "Motrya.Semenochko@ex.ua", null, "Ликера", "Сторожук", "докт. техн. наук", "1958663206", 8072.02m, "Burgs" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 28, 23, 58, 45, 489, DateTimeKind.Local).AddTicks(6727), "Брюховичів майдан, 1, Східний Мар’ян, Філіппіни", new DateTime(1978, 1, 13, 17, 20, 37, 451, DateTimeKind.Local).AddTicks(8751), "Aelayida_Andrukhovich@gmail.com", "Златомир", "Яворівський", "канд. філос. наук", "8683543968", 16502.59m, "programming" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 3, 4, 54, 9, 426, DateTimeKind.Local).AddTicks(4512), "Молодіжна майдан, 8, Дніпродзержинськ, Сент-Вінсент і Гренадини", new DateTime(1959, 4, 29, 5, 32, 26, 871, DateTimeKind.Local).AddTicks(6117), "Ilona_Moskalyuk71@ukr.net", "Богуслава", "Ланова", "докт. юрид. наук", "8987355831", "Прибиральник", 13251.83m, "feed" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 6, 7, 16, 59, 39, 62, DateTimeKind.Local).AddTicks(9492), "Молодіжна майдан, 2, Донецьк, Малайзія", new DateTime(2016, 7, 23, 22, 28, 26, 359, DateTimeKind.Local).AddTicks(8120), "Rodion_Dovgalevska14@ex.ua", new DateTime(2023, 10, 26, 22, 16, 49, 715, DateTimeKind.Local).AddTicks(7702), "Доброслав", "Плаксій", "проф.", "2325796768", "Прибиральник", 15988.71m, "Practical Wooden Chair" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 6, 4, 9, 10, 7, 808, DateTimeKind.Local).AddTicks(2051), "Вузька майдан, 678, Східний Яромил, Кувейт", new DateTime(2001, 4, 10, 8, 54, 19, 487, DateTimeKind.Local).AddTicks(6473), "Zvenigor_Shumilo74@meta.ua", "Федора", "Балицький", "канд. і. наук", "1551402311", "Секретар", 14410.60m, "Intelligent" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 2, 11, 0, 7, 31, 286, DateTimeKind.Local).AddTicks(7961), "Зелена майдан, 0, Південний Валерій, Бруней", new DateTime(1951, 7, 9, 3, 16, 16, 946, DateTimeKind.Local).AddTicks(3033), "Vyacheslav_Yurchishin@meta.ua", "Таїсія", "Спотикач", "канд. і. наук", "6937119342", 13892.31m, "payment" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 6, 18, 11, 1, 6, 924, DateTimeKind.Local).AddTicks(562), "вулиця Коліївщини, 54, Південний Злат, Ірландія", new DateTime(1951, 3, 31, 13, 12, 38, 935, DateTimeKind.Local).AddTicks(8380), "Stanislav.Tryasun79@meta.ua", new DateTime(2021, 10, 22, 4, 18, 23, 224, DateTimeKind.Local).AddTicks(6447), "Добромила", "Сторчак", "докт. техн. наук", "4060898358", 6353.24m, "Nuevo Sol" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 10, 22, 10, 13, 39, 558, DateTimeKind.Local).AddTicks(6410), "вул. Городоцька, 687, Північний Тарас, Гамбія", new DateTime(1981, 3, 27, 14, 11, 36, 582, DateTimeKind.Local).AddTicks(3570), "Podolyan_Romenec@i.ua", new DateTime(2022, 3, 13, 8, 44, 35, 893, DateTimeKind.Local).AddTicks(5866), "Лук’ян", "Бабух", "докт. політ. наук", "1398393761", 1503.45m, "Soft" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 9, 13, 45, 48, 973, DateTimeKind.Local).AddTicks(5328), "пл. Вічева, 36, Слов’янськ, Естонія", new DateTime(1965, 2, 28, 10, 18, 22, 304, DateTimeKind.Local).AddTicks(4148), "Rostislav.Balaban@ex.ua", "Ганна", "Махно", "доц.", "8812279690", "Директор", 17251.46m, "radical" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 5, 14, 9, 41, 42, 665, DateTimeKind.Local).AddTicks(1308), "Брюховичів майдан, 721, Суми, Соломонові Острови", new DateTime(1990, 3, 30, 8, 20, 14, 581, DateTimeKind.Local).AddTicks(5852), "Ada55@ex.ua", "Градимир", "Майстренко", "докт. психол. наук", "8628224687", "Бухгалтер", 12259.36m, "withdrawal" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 17, 21, 368, DateTimeKind.Local).AddTicks(9543), "Городоцька майдан, 3, Макіївка, Бруней", new DateTime(1975, 2, 10, 16, 5, 16, 399, DateTimeKind.Local).AddTicks(387), "Zinayida_Petrina16@ex.ua", new DateTime(2020, 4, 11, 13, 7, 26, 176, DateTimeKind.Local).AddTicks(8192), "Інна", "Лахман", "докт. і. наук", "6043314594", "Прибиральник", 13869.50m, "Tools" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 26, 4, 46, 2, 967, DateTimeKind.Local).AddTicks(8569), "Молодіжна майдан, 89, Кам’янець-Подільський, Італія", new DateTime(1988, 5, 13, 6, 13, 29, 388, DateTimeKind.Local).AddTicks(6416), "Ratimir21@e-mail.ua", new DateTime(2022, 12, 10, 8, 59, 33, 201, DateTimeKind.Local).AddTicks(5565), "Олеся", "Ящук", "9089558838", "Секретар", 14609.91m, "quantify" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 3, 8, 8, 59, 48, 466, DateTimeKind.Local).AddTicks(4118), "Нижанківського майдан, 080, Західний Брячислав, Вануату", new DateTime(1963, 11, 4, 8, 25, 12, 549, DateTimeKind.Local).AddTicks(7042), "Orislava.Parashuk27@gmail.com", new DateTime(2020, 6, 2, 5, 55, 4, 405, DateTimeKind.Local).AddTicks(3263), "Ярема", "Єрмак", "6283653203", "Секретар", 7062.09m, "bandwidth-monitored" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 6, 18, 3, 6, 21, 39, DateTimeKind.Local).AddTicks(2568), "вулиця Староміська, 39, Чернігів, Джибуті", new DateTime(1965, 7, 28, 18, 37, 42, 653, DateTimeKind.Local).AddTicks(5486), "Yaromil31@meta.ua", null, "Мечислав", "Плаксій", "канд. техн. наук", "5239854357", "Програміст", 12664.85m, "compress" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 4, 15, 14, 5, 14, 249, DateTimeKind.Local).AddTicks(8447), "вул. Молодіжна, 0, Хмельницький, Італія", new DateTime(2001, 9, 10, 11, 0, 46, 621, DateTimeKind.Local).AddTicks(2378), "Romena_Boyarchuk93@ukr.net", new DateTime(2021, 10, 20, 9, 21, 41, 252, DateTimeKind.Local).AddTicks(5569), "Білослав", "Стоян", "канд. філос. наук", "2011580492", "Секретар", 6779.06m, "Future" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 10, 22, 14, 9, 6, 237, DateTimeKind.Local).AddTicks(5503), "Винників майдан, 0, Мукачеве, Перу", new DateTime(2012, 5, 30, 15, 18, 6, 818, DateTimeKind.Local).AddTicks(4450), "Borimisl.Fedorishina@e-mail.ua", null, "Андрій", "Романишин", "докт. і. наук", "7350686654", "Прибиральник", 4703.10m, "Extended" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 16, 13, 31, 50, 567, DateTimeKind.Local).AddTicks(8799), "Стрийська майдан, 150, Тернопіль, Гвінея", new DateTime(2008, 12, 30, 17, 4, 29, 223, DateTimeKind.Local).AddTicks(8389), "Darislava.Cushko80@meta.ua", null, "Варвара", "Шамрило", "канд. політ. наук", "0879425199", "Директор", 10733.45m, "generating" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 3, 7, 14, 38, 46, 510, DateTimeKind.Local).AddTicks(9275), "пров. Рудного, 009, Західний Роман, Лесото", new DateTime(1945, 6, 17, 21, 36, 23, 342, DateTimeKind.Local).AddTicks(1089), "Danilo6@meta.ua", new DateTime(2021, 4, 7, 21, 0, 15, 14, DateTimeKind.Local).AddTicks(1803), "Святополк", "Корнїйчук", "канд. філол. наук", "0097270095", "Програміст", 6387.65m, "Concrete" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 4, 3, 15, 39, 44, 800, DateTimeKind.Local).AddTicks(252), "Молодіжна майдан, 06, Північний Михайло, Словаччина", new DateTime(1950, 11, 14, 5, 3, 8, 672, DateTimeKind.Local).AddTicks(2380), "Volodislav.Gnatishin34@ukr.net", new DateTime(2023, 10, 3, 5, 21, 7, 584, DateTimeKind.Local).AddTicks(4054), "Ростислава", "Ромочко", "канд. філос. наук", "9618618001", "Секретар", 3577.15m, "quantify" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 16, 4, 6, 2, 60, DateTimeKind.Local).AddTicks(1638), "Коліївщини майдан, 6, Західний Семибор, Перу", new DateTime(1968, 12, 5, 22, 6, 38, 54, DateTimeKind.Local).AddTicks(2652), "Bratimir.Kivach@ukr.net", new DateTime(2023, 5, 17, 7, 30, 22, 567, DateTimeKind.Local).AddTicks(6764), "Валентин", "Стигайло", "2802160981", "Бухгалтер", 7194.43m, "strategize" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 22, 20, 4, 0, 697, DateTimeKind.Local).AddTicks(7215), "вулиця Стрийська, 7, Кіровоград, Бахрейн", new DateTime(2018, 9, 12, 2, 47, 55, 977, DateTimeKind.Local).AddTicks(7685), "Ognyana.Tretyak28@gmail.com", new DateTime(2023, 7, 12, 19, 4, 8, 188, DateTimeKind.Local).AddTicks(5902), "Земислав", "Поліщук", "докт. і. наук", "8239385428", "Секретар", 1982.14m, "Synergistic" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 6, 1, 42, 29, 845, DateTimeKind.Local).AddTicks(267), "Молодіжна майдан, 533, Краматорськ, Замбія", new DateTime(1982, 6, 3, 2, 32, 17, 943, DateTimeKind.Local).AddTicks(4111), "Zvenigor16@i.ua", "Мстислава", "Гордійчук", "канд. і. наук", "7311200786", "Директор", 19258.80m, "Assurance" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 10, 28, 3, 52, 32, 492, DateTimeKind.Local).AddTicks(1131), "Зелена майдан, 476, Херсон, Соломонові Острови", new DateTime(1975, 8, 10, 10, 53, 48, 362, DateTimeKind.Local).AddTicks(8273), "Ruslan_Marinich@ukr.net", new DateTime(2022, 7, 22, 10, 28, 2, 291, DateTimeKind.Local).AddTicks(606), "Петро", "Юхно", "проф.", "3490192402", "Бухгалтер", 6052.91m, "India" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 11, 12, 18, 16, 3, 544, DateTimeKind.Local).AddTicks(8316), "Коліївщини майдан, 7, Північний Микита, Руанда", new DateTime(1968, 6, 26, 23, 7, 53, 328, DateTimeKind.Local).AddTicks(7335), "Anzhela.Balickii0@meta.ua", null, "Ілля", "Борочко", "канд. і. наук", "9423566457", 11084.32m, "Massachusetts" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 7, 21, 17, 45, 31, 862, DateTimeKind.Local).AddTicks(9316), "вулиця Молодіжна, 0, Сімферополь, Домініка", new DateTime(2012, 10, 24, 12, 20, 47, 604, DateTimeKind.Local).AddTicks(4073), "Avgustin_Kordun@meta.ua", new DateTime(2021, 8, 24, 19, 18, 10, 352, DateTimeKind.Local).AddTicks(7370), "Власта", "Негода", "2288217635", "Бухгалтер", 5239.96m, "Berkshire" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 7, 30, 9, 40, 42, 487, DateTimeKind.Local).AddTicks(7960), "вулиця Молодіжна, 0, Тернопіль, Камбоджа", new DateTime(2022, 4, 1, 1, 10, 48, 159, DateTimeKind.Local).AddTicks(1727), "Agapiya81@e-mail.ua", "Юхимія", "Тарасюк", "докт. юрид. наук", "3686937647", "Бухгалтер", 15532.51m, "deposit" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 19, 14, 15, 10, 681, DateTimeKind.Local).AddTicks(3930), "Стрийська майдан, 984, Південний Златомир, Судан", new DateTime(1947, 12, 1, 15, 58, 16, 684, DateTimeKind.Local).AddTicks(4735), "Polina.Ganich@ukr.net", new DateTime(2019, 6, 20, 18, 13, 21, 304, DateTimeKind.Local).AddTicks(3425), "Люборада", "Бабух", "докт. юрид. наук", "7587695332", "Бухгалтер", 1429.88m, "Savings Account" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 5, 15, 2, 1, 56, 526, DateTimeKind.Local).AddTicks(6203), "пл. Ліста, 1, Західний Гордій, Італія", new DateTime(2009, 7, 11, 17, 56, 32, 380, DateTimeKind.Local).AddTicks(7105), "Viola_Tkachenko25@e-mail.ua", null, "Ярослав", "Мазун", "докт. філол. наук", "1769915893", "Бухгалтер", 12480.22m, "Berkshire" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 8, 19, 40, 29, 583, DateTimeKind.Local).AddTicks(4103), "Рудного майдан, 2, Східний Богдан, Таїланд", new DateTime(1982, 1, 13, 21, 0, 1, 205, DateTimeKind.Local).AddTicks(8411), "Petro18@e-mail.ua", "Валентин", "Поривайло", "докт. політ. наук", "8066609275", "Програміст", 14719.05m, "superstructure" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2024, 2, 29, 9, 16, 37, 870, DateTimeKind.Local).AddTicks(5753), "проспект Брюховичів, 336, Східний Антон, Південна Корея", new DateTime(1952, 2, 8, 22, 42, 27, 102, DateTimeKind.Local).AddTicks(4920), "Kupava83@i.ua", new DateTime(2021, 11, 26, 4, 25, 36, 571, DateTimeKind.Local).AddTicks(7310), "Руслан", "Петик", "доц.", "9489515709", 1529.67m, "Place" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 10, 30, 15, 38, 17, 77, DateTimeKind.Local).AddTicks(7043), "Молодіжна майдан, 474, Південний Родіон, Домініканська Республіка", new DateTime(1983, 12, 5, 4, 7, 10, 821, DateTimeKind.Local).AddTicks(6368), "Zorina_Tryasun60@ukr.net", new DateTime(2023, 8, 15, 16, 11, 22, 288, DateTimeKind.Local).AddTicks(9422), "Микита", "Унич", "канд. техн. наук", "5272636316", 6092.10m, "Automotive, Beauty & Movies" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 1, 19, 17, 13, 44, 807, DateTimeKind.Local).AddTicks(2951), "Коліївщини майдан, 714, Слов’янськ, Саудівська Аравія", new DateTime(1966, 10, 6, 15, 9, 11, 736, DateTimeKind.Local).AddTicks(2583), "Oresta_Andrukhovich@ukr.net", null, "Зоя", "Бондаренко", "докт. політ. наук", "9244333629", "Секретар", 8221.40m, "time-frame" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 12, 31, 18, 42, 43, 478, DateTimeKind.Local).AddTicks(3594), "Зелена майдан, 52, Східний Лаврін, Нігер", new DateTime(1994, 5, 19, 9, 34, 25, 101, DateTimeKind.Local).AddTicks(8557), "Ostap_Borochko@gmail.com", null, "Зборислав", "Бандера", "докт. юрид. наук", "0849516185", "Програміст", 19963.20m, "synthesizing" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 3, 2, 14, 1, 40, 376, DateTimeKind.Local).AddTicks(2361), "Ліста майдан, 31, Кременчук, Коста-Рика", new DateTime(2020, 12, 31, 23, 32, 57, 430, DateTimeKind.Local).AddTicks(2707), "Ivan_Grigorishina@gmail.com", new DateTime(2022, 3, 30, 2, 43, 51, 819, DateTimeKind.Local).AddTicks(8956), "Олексій", "Гордійчук", "канд. психол. наук", "5138895892", "Програміст", 14608.01m, "alarm" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 7, 27, 11, 27, 12, 398, DateTimeKind.Local).AddTicks(9339), "вул. Рудного, 238, Євпаторія, Сан-Томе і Принсіпі", new DateTime(1958, 4, 28, 18, 40, 6, 733, DateTimeKind.Local).AddTicks(2963), "Oresta.Latanskii85@gmail.com", null, "Корнилій", "Савицький", "канд. політ. наук", "0213736047", "Прибиральник", 3083.58m, "Public-key" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 5, 28, 21, 38, 30, 331, DateTimeKind.Local).AddTicks(7980), "пр. Зелена, 388, Північний Всевлад, Монголія", new DateTime(1970, 5, 21, 17, 6, 10, 334, DateTimeKind.Local).AddTicks(4862), "Bratimir8@gmail.com", null, "Віолетта", "Кивач", "канд. політ. наук", "2271884557", "Директор", 5006.42m, "gold" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 1, 2, 12, 58, 6, 446, DateTimeKind.Local).AddTicks(6828), "Брюховичів майдан, 81, Південний Анатолій, Естонія", new DateTime(1998, 6, 4, 14, 40, 57, 995, DateTimeKind.Local).AddTicks(7871), "Daleslava.Andrukhovich5@yandex.ua", new DateTime(2020, 6, 5, 12, 52, 3, 949, DateTimeKind.Local).AddTicks(6514), "Агапія", "Карпух", "канд. філос. наук", "5525113332", "Бухгалтер", 16449.48m, "Practical Soft Ball" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 12, 1, 0, 59, 53, 925, DateTimeKind.Local).AddTicks(7985), "Вічева майдан, 06, Бердянськ, Узбекистан", new DateTime(1970, 1, 7, 4, 23, 0, 934, DateTimeKind.Local).AddTicks(199), "Snizhana1@ukr.net", null, "Земислав", "Гречко", "докт. пед. наук", "5381075201", "Програміст", 9701.41m, "aggregate" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2021, 2, 21, 5, 19, 42, 337, DateTimeKind.Local).AddTicks(3113), "вулиця Молодіжна, 82, Південний Щастислав, Гайана", new DateTime(1952, 6, 17, 10, 26, 44, 365, DateTimeKind.Local).AddTicks(8249), "Kostyantin.Steckiv@yandex.ua", new DateTime(2022, 10, 2, 11, 58, 0, 471, DateTimeKind.Local).AddTicks(5664), "Білослава", "Павлишин", "докт. пед. наук", "9398145018", 13220.94m, "generate" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 9, 19, 21, 33, 21, 755, DateTimeKind.Local).AddTicks(3789), "проспект Нижанківського, 43, Єнакієве, Екваторіальна Гвінея", new DateTime(2005, 8, 18, 1, 55, 54, 704, DateTimeKind.Local).AddTicks(2571), "Olelko_Gladukh@e-mail.ua", "Тихон", "Лобачевська", "6016202060", "Програміст", 17859.03m, "Enhanced" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 3, 13, 10, 42, 25, 188, DateTimeKind.Local).AddTicks(7090), "пр. Винників, 471, Макіївка, Індонезія", new DateTime(1965, 8, 14, 16, 21, 44, 438, DateTimeKind.Local).AddTicks(4945), "Vlasta_Kulinich@i.ua", "Божен", "Прядун", "докт. техн. наук", "1466306158", 19983.24m, "auxiliary" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 7, 11, 10, 57, 36, 318, DateTimeKind.Local).AddTicks(9611), "пл. Городоцька, 25, Кременчук, Катар", new DateTime(1963, 5, 7, 21, 26, 17, 368, DateTimeKind.Local).AddTicks(7369), "Agripina98@meta.ua", new DateTime(2020, 11, 17, 12, 50, 28, 882, DateTimeKind.Local).AddTicks(3053), "Анфіса", "Трясило", "канд. техн. наук", "9607235564", 19044.99m, "cross-media" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 12, 28, 10, 55, 12, 435, DateTimeKind.Local).AddTicks(4805), "Коліївщини майдан, 814, Черкаси, Болівія", new DateTime(1955, 9, 30, 15, 56, 27, 522, DateTimeKind.Local).AddTicks(3888), "Viola68@gmail.com", null, "Наталія", "Гаман", "канд. і. наук", "2735269903", "Бухгалтер", 1684.46m, "Intelligent Steel Pants" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 5, 12, 10, 21, 30, 866, DateTimeKind.Local).AddTicks(9001), "площа Нижанківського, 871, Західний Вадим, Північна Корея", new DateTime(1961, 7, 24, 12, 50, 40, 186, DateTimeKind.Local).AddTicks(1838), "Musii40@yandex.ua", null, "Яна", "Романишина", "докт. політ. наук", "8452483868", "Секретар", 12987.75m, "Intelligent" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 8, 22, 8, 30, 53, 521, DateTimeKind.Local).AddTicks(6892), "Брюховичів майдан, 01, Слов’янськ, Конго", new DateTime(2008, 10, 3, 15, 11, 40, 568, DateTimeKind.Local).AddTicks(6336), "Alevtin60@gmail.com", null, "Болеслава", "Гладух", "докт. психол. наук", "8668638898", "Директор", 6862.02m, "Operations" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 12, 28, 6, 4, 31, 729, DateTimeKind.Local).AddTicks(3164), "пров. Ліста, 67, Східний Остап, Ліван", new DateTime(2015, 10, 6, 5, 27, 39, 248, DateTimeKind.Local).AddTicks(3383), "Fevroniya_Usich42@e-mail.ua", null, "Добромисл", "Гаман", "7383478973", "Прибиральник", 9123.45m, "Cambridgeshire" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2022, 2, 22, 22, 18, 58, 461, DateTimeKind.Local).AddTicks(6821), "Вічева майдан, 1, Єнакієве, Сербія", new DateTime(2020, 7, 16, 6, 53, 38, 654, DateTimeKind.Local).AddTicks(1474), "Anatolii_Borochko@i.ua", new DateTime(2020, 10, 29, 14, 28, 15, 361, DateTimeKind.Local).AddTicks(1578), "Гліб", "Ганич", "докт. філос. наук", "1395679507", "Директор", 13832.78m, "Agent" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2020, 12, 29, 23, 44, 50, 987, DateTimeKind.Local).AddTicks(2885), "площа Ліста, 20, Херсон, Швеція", new DateTime(2022, 5, 20, 21, 10, 42, 151, DateTimeKind.Local).AddTicks(4460), "Maiya20@meta.ua", "Олесь", "Зварич", "доц.", "8021606915", "Директор", 10775.63m, "1080p" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FiredOn", "FirstName", "LastName", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2023, 9, 19, 5, 50, 54, 17, DateTimeKind.Local).AddTicks(5303), "Стрийська майдан, 83, Хмельницький, Йорданія", new DateTime(1947, 12, 28, 7, 3, 58, 855, DateTimeKind.Local).AddTicks(6829), "Olga.Shamrilo@e-mail.ua", new DateTime(2023, 4, 15, 2, 48, 32, 41, DateTimeKind.Local).AddTicks(5439), "Любомир", "Кивач", "0071827806", "Директор", 12326.19m, "alliance" });

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
                columns: new[] { "AcceptedOn", "Address", "BirthDate", "Email", "FirstName", "LastName", "Patronymic", "PhoneNumber", "Position", "Salary", "Status" },
                values: new object[] { new DateTime(2019, 8, 13, 8, 9, 24, 825, DateTimeKind.Local).AddTicks(3837), "Молодіжна майдан, 80, Ужгород, Андорра", new DateTime(1999, 12, 6, 5, 5, 48, 988, DateTimeKind.Local).AddTicks(7834), "Markiyan35@ukr.net", "Алла", "Ющук", "докт. техн. наук", "3554425547", "Прибиральник", 11426.59m, "system" });
        }
    }
}

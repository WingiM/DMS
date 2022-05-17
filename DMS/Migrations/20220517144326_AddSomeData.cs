using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DMS.Migrations
{
    public partial class AddSomeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "rating_change_category",
                columns: new[] { "category_id", "name" },
                values: new object[,]
                {
                    { 1, "Докладная" },
                    { 2, "Поощрение" },
                    { 3, "Выговор" }
                });

            migrationBuilder.InsertData(
                table: "resident",
                columns: new[] { "resident_id", "birth_date", "course", "first_name", "gender", "is_commercial", "last_name", "patronymic", "room_number", "tin" },
                values: new object[,]
                {
                    { 1, new DateTime(2003, 4, 20, 20, 0, 0, 0, DateTimeKind.Utc), 4, "Даниил", 'M', true, "Морозов", "Артёмович", null, "737277807092" },
                    { 2, new DateTime(2005, 12, 1, 21, 0, 0, 0, DateTimeKind.Utc), 2, "Платон", 'M', true, "Дубов", "Александрович", null, "276204981825" }
                });

            migrationBuilder.InsertData(
                table: "room",
                columns: new[] { "room_number", "capacity", "gender" },
                values: new object[,]
                {
                    { 301, 3, 'M' },
                    { 302, 3, 'M' },
                    { 303, 3, 'M' },
                    { 304, 3, 'M' },
                    { 305, 3, 'M' },
                    { 306, 3, 'M' },
                    { 307, 3, 'M' }
                });

            migrationBuilder.InsertData(
                table: "passport_information",
                columns: new[] { "passport_information_id", "address", "department_code", "issue_date", "issued_by", "resident_id", "series_number" },
                values: new object[,]
                {
                    { 1, "Россия, г. Йошкар-Ола, Радужная ул., д. 4 кв.58", 930822, new DateTime(2019, 8, 18, 21, 0, 0, 0, DateTimeKind.Utc), "Отделом внутренних дел России по г. Йошкар-Ола", 1, "4943101489" },
                    { 2, "Россия, г. Екатеринбург, Центральный пер., д. 18 кв.101", 830605, new DateTime(2019, 11, 24, 21, 0, 0, 0, DateTimeKind.Utc), "Отделением УФМС России по г. Екатеринбург", 2, "4702117803" }
                });

            migrationBuilder.InsertData(
                table: "rating_operation",
                columns: new[] { "rating_operation_id", "category_id", "change_value", "description", "order_date", "resident_id" },
                values: new object[,]
                {
                    { 1, 1, -3, null, new DateTime(2022, 5, 11, 21, 0, 0, 0, DateTimeKind.Utc), 1 },
                    { 2, 2, 1, null, new DateTime(2022, 4, 10, 21, 0, 0, 0, DateTimeKind.Utc), 2 }
                });

            migrationBuilder.InsertData(
                table: "resident",
                columns: new[] { "resident_id", "birth_date", "course", "first_name", "gender", "is_commercial", "last_name", "patronymic", "room_number", "tin" },
                values: new object[,]
                {
                    { 3, new DateTime(2004, 4, 2, 20, 0, 0, 0, DateTimeKind.Utc), 1, "Артём", 'M', true, "Галкин", "Константинович", 301, "545375584419" },
                    { 4, new DateTime(2004, 4, 18, 20, 0, 0, 0, DateTimeKind.Utc), 3, "Владимир", 'M', false, "Скворцов", "Максимович", 302, "541729308186" },
                    { 5, new DateTime(2002, 6, 22, 20, 0, 0, 0, DateTimeKind.Utc), 4, "Мирон", 'M', false, "Латышев", "Глебович", 302, "498392680283" },
                    { 6, new DateTime(2005, 6, 2, 20, 0, 0, 0, DateTimeKind.Utc), 1, "Александр", 'M', false, "Маркин", "Тимурович", 302, "252251775675" },
                    { 7, new DateTime(2004, 5, 21, 20, 0, 0, 0, DateTimeKind.Utc), 4, "Андрей", 'M', false, "Майоров", "Александрович", 303, "316152736997" },
                    { 8, new DateTime(2004, 4, 21, 20, 0, 0, 0, DateTimeKind.Utc), 4, "Андрей", 'M', true, "Матвеев", "Максимович", 303, "728273836756" },
                    { 9, new DateTime(2002, 11, 15, 21, 0, 0, 0, DateTimeKind.Utc), 1, "Денис", 'M', false, "Авдеев", "Евгеньевич", 303, "715730062207" },
                    { 10, new DateTime(2002, 11, 10, 21, 0, 0, 0, DateTimeKind.Utc), 1, "Кирилл", 'M', true, "Богданов", "Кириллович", 304, "642845725453" },
                    { 11, new DateTime(2003, 11, 13, 21, 0, 0, 0, DateTimeKind.Utc), 2, "Александр", 'M', true, "Сахаров", "Егорович", 304, "359284956944" },
                    { 12, new DateTime(2005, 1, 9, 21, 0, 0, 0, DateTimeKind.Utc), 2, "Роман", 'M', false, "Иванов", "Романович", 304, "799582532172" },
                    { 13, new DateTime(2006, 12, 29, 21, 0, 0, 0, DateTimeKind.Utc), 3, "Кирилл", 'M', true, "Панов", "Романович", 305, "108102025148" },
                    { 14, new DateTime(2002, 10, 5, 20, 0, 0, 0, DateTimeKind.Utc), 4, "Руслан", 'M', false, "Ершов", "Иванович", 305, "288734150714" },
                    { 15, new DateTime(2005, 4, 18, 20, 0, 0, 0, DateTimeKind.Utc), 4, "Евгений", 'M', false, "Афанасьев", "Максимович", 305, "613391118617" }
                });

            migrationBuilder.InsertData(
                table: "settlement_order",
                columns: new[] { "order_id", "description", "order_date", "parents_name", "parents_passport_address", "parents_passport_department_code", "parents_passport_issue_date", "parents_passport_issued_by", "parents_passport_series_number", "resident_id", "room_number" },
                values: new object[,]
                {
                    { 1, null, new DateTime(21, 8, 28, 20, 0, 0, 0, DateTimeKind.Utc), "Беляков Даниил Андреевич", "Россия, г. Йошкар-Ола, Радужная ул., д. 4 кв.58", 930822, new DateTime(1987, 10, 3, 20, 0, 0, 0, DateTimeKind.Utc), "Отделением УФМС России в г. Балаково", "4605443539", 1, 301 },
                    { 2, null, new DateTime(21, 8, 29, 20, 0, 0, 0, DateTimeKind.Utc), "Игнатова Анастасия Семёновна", "Россия, г. Екатеринбург, Центральный пер., д. 18 кв.101", 830605, new DateTime(1987, 10, 3, 20, 0, 0, 0, DateTimeKind.Utc), "Отделением УФМС России по г. Владивосток", "4404497341", 2, 301 }
                });

            migrationBuilder.InsertData(
                table: "transaction",
                columns: new[] { "transaction_id", "operation_date", "resident_id", "sum" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 17, 21, 0, 0, 0, DateTimeKind.Utc), 1, 7931.1400000000003 },
                    { 2, new DateTime(2022, 9, 25, 21, 0, 0, 0, DateTimeKind.Utc), 2, 6255.4899999999998 }
                });

            migrationBuilder.InsertData(
                table: "eviction_order",
                columns: new[] { "order_id", "description", "order_date", "resident_id" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 16, 21, 0, 0, 0, DateTimeKind.Utc), 7 },
                    { 2, null, new DateTime(2022, 8, 2, 21, 0, 0, 0, DateTimeKind.Utc), 4 },
                    { 3, null, new DateTime(2022, 1, 20, 21, 0, 0, 0, DateTimeKind.Utc), 10 }
                });

            migrationBuilder.InsertData(
                table: "passport_information",
                columns: new[] { "passport_information_id", "address", "department_code", "issue_date", "issued_by", "resident_id", "series_number" },
                values: new object[,]
                {
                    { 3, "Россия, г. Новошахтинск, Пролетарская ул., д. 18 кв.32", 670210, new DateTime(2016, 10, 5, 21, 0, 0, 0, DateTimeKind.Utc), "Отделением УФМС России в г. Новошахтинск", 3, "4006644387" },
                    { 4, "Россия, г. Домодедово, Солнечный пер., д. 8 кв.4", 660389, new DateTime(2018, 12, 1, 21, 0, 0, 0, DateTimeKind.Utc), "Отделением УФМС России по г. Домодедово", 4, "4906472737" },
                    { 5, "Россия, г. Балаково, Совхозная ул., д. 8 кв.144", 920691, new DateTime(2016, 3, 16, 21, 0, 0, 0, DateTimeKind.Utc), "Отделением УФМС России в г. Балаково", 5, "4102385088" },
                    { 6, "Россия, г. Томск, Колхозный пер., д. 23 кв.218", 590726, new DateTime(2018, 7, 26, 21, 0, 0, 0, DateTimeKind.Utc), "Отделом внутренних дел России по г. Томск", 6, "4605443539" },
                    { 7, "Россия, г. Энгельс, ул. Ленина, д. 13 кв.269", 670697, new DateTime(2018, 12, 31, 21, 0, 0, 0, DateTimeKind.Utc), "ОУФМС России по г. Энгельс", 7, "4404497341" },
                    { 8, "Россия, г. Благовещенск, Цветочный пер., д. 54 кв.12", 640958, new DateTime(2018, 11, 15, 21, 0, 0, 0, DateTimeKind.Utc), "Управление внутренних дел по г. Благовещенск", 8, "4205516390" },
                    { 9, "Россия, г. Балаково, ул. Женитьбы, д. 21 кв.14", 230962, new DateTime(2017, 8, 5, 21, 0, 0, 0, DateTimeKind.Utc), "Отделением УФМС России в г. Балаково", 9, "4703955170" },
                    { 10, "Россия, г. Владивосток, ул. Красная, д. 21 кв.15", 920142, new DateTime(2018, 1, 12, 21, 0, 0, 0, DateTimeKind.Utc), "Отделением УФМС России по г. Владивосток", 10, "4906779333" }
                });

            migrationBuilder.InsertData(
                table: "rating_operation",
                columns: new[] { "rating_operation_id", "category_id", "change_value", "description", "order_date", "resident_id" },
                values: new object[,]
                {
                    { 3, 2, 2, null, new DateTime(2022, 4, 30, 21, 0, 0, 0, DateTimeKind.Utc), 3 },
                    { 4, 2, 1, null, new DateTime(2022, 6, 1, 21, 0, 0, 0, DateTimeKind.Utc), 4 },
                    { 5, 3, -1, null, new DateTime(2022, 5, 20, 21, 0, 0, 0, DateTimeKind.Utc), 5 },
                    { 6, 2, 3, null, new DateTime(2022, 3, 4, 21, 0, 0, 0, DateTimeKind.Utc), 6 }
                });

            migrationBuilder.InsertData(
                table: "settlement_order",
                columns: new[] { "order_id", "description", "order_date", "parents_name", "parents_passport_address", "parents_passport_department_code", "parents_passport_issue_date", "parents_passport_issued_by", "parents_passport_series_number", "resident_id", "room_number" },
                values: new object[,]
                {
                    { 3, null, new DateTime(21, 8, 31, 20, 0, 0, 0, DateTimeKind.Utc), "Васильев Александр Захарович", "Россия, г. Новошахтинск, Пролетарская ул., д. 18 кв.32", 670210, new DateTime(1987, 10, 3, 20, 0, 0, 0, DateTimeKind.Utc), "Отделом внутренних дел России по г. Йошкар-Ола", "4205516390", 3, 301 },
                    { 4, null, new DateTime(21, 8, 27, 20, 0, 0, 0, DateTimeKind.Utc), "Иванов Георгий Никитич", "Россия, г. Домодедово, Солнечный пер., д. 8 кв.4", 660389, new DateTime(1987, 10, 3, 20, 0, 0, 0, DateTimeKind.Utc), "Отделением УФМС России по г. Екатеринбург", "4703955170", 4, 302 },
                    { 5, null, new DateTime(21, 8, 28, 20, 0, 0, 0, DateTimeKind.Utc), "Исаков Тимур Романович", "Россия, г. Балаково, Совхозная ул., д. 8 кв.144", 920691, new DateTime(1987, 10, 3, 20, 0, 0, 0, DateTimeKind.Utc), "Отделением УФМС России в г. Новошахтинск", "4906779333", 5, 302 },
                    { 6, null, new DateTime(21, 8, 29, 20, 0, 0, 0, DateTimeKind.Utc), "Пахомова Виктория Ярославовна", "Россия, г. Томск, Колхозный пер., д. 23 кв.218", 590726, new DateTime(1987, 10, 3, 20, 0, 0, 0, DateTimeKind.Utc), "Отделением УФМС России по г. Домодедово", "4504272308", 6, 302 },
                    { 7, null, new DateTime(21, 8, 29, 20, 0, 0, 0, DateTimeKind.Utc), "Исаева Анна Васильевна", "Россия, г. Энгельс, ул. Ленина, д. 13 кв.269", 670697, new DateTime(1987, 10, 3, 20, 0, 0, 0, DateTimeKind.Utc), "Отделением УФМС России в г. Балаково", "4602684723", 7, 303 },
                    { 8, null, new DateTime(21, 8, 31, 20, 0, 0, 0, DateTimeKind.Utc), "Царева Эмилия Леонидовна", "Россия, г. Благовещенск, Цветочный пер., д. 54 кв.12", 640958, new DateTime(1987, 10, 3, 20, 0, 0, 0, DateTimeKind.Utc), "Отделом внутренних дел России по г. Томск", "4604696743", 8, 303 },
                    { 9, null, new DateTime(21, 9, 1, 20, 0, 0, 0, DateTimeKind.Utc), "Золотарева Дарья Матвеевна", "Россия, г. Балаково, ул. Женитьбы, д. 21 кв.14", 230962, new DateTime(1987, 10, 3, 20, 0, 0, 0, DateTimeKind.Utc), "ОУФМС России по г. Энгельс", "4704095718", 9, 303 },
                    { 10, null, new DateTime(21, 8, 28, 20, 0, 0, 0, DateTimeKind.Utc), "Власова София Леонидовна", "Россия, г. Владивосток, ул. Красная, д. 21 кв.15", 920142, new DateTime(1987, 10, 3, 20, 0, 0, 0, DateTimeKind.Utc), "Управление внутренних дел по г. Благовещенск", "4302520273", 10, 304 }
                });

            migrationBuilder.InsertData(
                table: "transaction",
                columns: new[] { "transaction_id", "operation_date", "resident_id", "sum" },
                values: new object[,]
                {
                    { 3, new DateTime(2022, 8, 27, 21, 0, 0, 0, DateTimeKind.Utc), 3, 9617.5300000000007 },
                    { 4, new DateTime(2022, 8, 29, 21, 0, 0, 0, DateTimeKind.Utc), 4, 5058.3800000000001 },
                    { 5, new DateTime(2022, 8, 31, 21, 0, 0, 0, DateTimeKind.Utc), 5, 9588.4799999999996 },
                    { 6, new DateTime(2022, 8, 28, 21, 0, 0, 0, DateTimeKind.Utc), 6, 7287.0699999999997 },
                    { 7, new DateTime(2022, 5, 23, 21, 0, 0, 0, DateTimeKind.Utc), 7, 8917.2099999999991 },
                    { 8, new DateTime(2022, 4, 28, 21, 0, 0, 0, DateTimeKind.Utc), 8, 5403.7799999999997 },
                    { 9, new DateTime(2022, 3, 28, 21, 0, 0, 0, DateTimeKind.Utc), 9, 6124.7700000000004 },
                    { 10, new DateTime(2022, 2, 22, 21, 0, 0, 0, DateTimeKind.Utc), 10, 5108.79 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "eviction_order",
                keyColumn: "order_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "passport_information",
                keyColumn: "passport_information_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "rating_operation",
                keyColumn: "rating_operation_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "rating_operation",
                keyColumn: "rating_operation_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "rating_operation",
                keyColumn: "rating_operation_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "rating_operation",
                keyColumn: "rating_operation_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "rating_operation",
                keyColumn: "rating_operation_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "rating_operation",
                keyColumn: "rating_operation_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "room",
                keyColumn: "room_number",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "room",
                keyColumn: "room_number",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "settlement_order",
                keyColumn: "order_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "transaction",
                keyColumn: "transaction_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "transaction",
                keyColumn: "transaction_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "transaction",
                keyColumn: "transaction_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "transaction",
                keyColumn: "transaction_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "transaction",
                keyColumn: "transaction_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "transaction",
                keyColumn: "transaction_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "transaction",
                keyColumn: "transaction_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "transaction",
                keyColumn: "transaction_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "transaction",
                keyColumn: "transaction_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "transaction",
                keyColumn: "transaction_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "rating_change_category",
                keyColumn: "category_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "rating_change_category",
                keyColumn: "category_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "rating_change_category",
                keyColumn: "category_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "resident",
                keyColumn: "resident_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "room",
                keyColumn: "room_number",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "room",
                keyColumn: "room_number",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "room",
                keyColumn: "room_number",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "room",
                keyColumn: "room_number",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "room",
                keyColumn: "room_number",
                keyValue: 304);
        }
    }
}

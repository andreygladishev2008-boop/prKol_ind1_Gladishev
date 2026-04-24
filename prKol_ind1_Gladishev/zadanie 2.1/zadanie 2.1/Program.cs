using System;
using System.Collections.Generic;
using System.Linq;

namespace PostalAddressApp
{
    class PostalAddress
    {
        private string index;
        private string city;
        private string street;
        private string house;
        private string office;
        private string organizationName;
        private static int totalCreated = 0;
        private static int totalDestroyed = 0;

        public PostalAddress()
        {
            index = "";
            city = "";
            street = "";
            house = "";
            office = "";
            organizationName = "";
            totalCreated++;
        }

        public PostalAddress(string index, string city, string street, string house, string office, string organizationName)
        {
            this.index = index;
            this.city = city;
            this.street = street;
            this.house = house;
            this.office = office;
            this.organizationName = organizationName;
            totalCreated++;
        }

        public void SetIndex(string index) { this.index = index; }
        public void SetCity(string city) { this.city = city; }
        public void SetStreet(string street) { this.street = street; }
        public void SetHouse(string house) { this.house = house; }
        public void SetOffice(string office) { this.office = office; }
        public void SetOrganizationName(string name) { this.organizationName = name; }

        public string GetIndex() { return index; }
        public string GetCity() { return city; }
        public string GetStreet() { return street; }
        public string GetHouse() { return house; }
        public string GetOffice() { return office; }
        public string GetOrganizationName() { return organizationName; }

        public void SetFullAddress(string index, string city, string street, string house, string office, string organizationName)
        {
            this.index = index;
            this.city = city;
            this.street = street;
            this.house = house;
            this.office = office;
            this.organizationName = organizationName;
        }

        public void PrintAddress()
        {
            Console.WriteLine("\n=================================");
            Console.WriteLine("  ПОЧТОВЫЙ АДРЕС ОРГАНИЗАЦИИ");
            Console.WriteLine("=================================");
            Console.WriteLine($"Организация: {organizationName}");
            Console.WriteLine($"Индекс:      {index}");
            Console.WriteLine($"Город:       {city}");
            Console.WriteLine($"Улица:       {street}");
            Console.WriteLine($"Дом:         {house}");
            Console.WriteLine($"Офис:        {office}");
            Console.WriteLine("=================================\n");
        }

        public static int GetTotalCreated() { return totalCreated; }
        public static int GetTotalDestroyed() { return totalDestroyed; }

        ~PostalAddress()
        {
            totalDestroyed++;
        }
    }

    class Program
    {
        static List<PostalAddress> addresses = new List<PostalAddress>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "Почтовый адрес организации (List)";

            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("======================================");
                Console.WriteLine("  ПОЧТОВЫЙ АДРЕС ОРГАНИЗАЦИИ (List)");
                Console.WriteLine("======================================");
                Console.WriteLine($"Всего адресов в списке: {addresses.Count}");
                Console.WriteLine($"Всего создано объектов: {PostalAddress.GetTotalCreated()}");
                Console.WriteLine($"Всего уничтожено объектов: {PostalAddress.GetTotalDestroyed()}");
                Console.WriteLine("======================================");
                Console.WriteLine("1.  Создать новый адрес и добавить в список");
                Console.WriteLine("2.  Показать все адреса");
                Console.WriteLine("3.  Показать адрес по индексу");
                Console.WriteLine("4.  Изменить индекс адреса");
                Console.WriteLine("5.  Изменить город адреса");
                Console.WriteLine("6.  Изменить улицу адреса");
                Console.WriteLine("7.  Изменить дом адреса");
                Console.WriteLine("8.  Изменить офис адреса");
                Console.WriteLine("9.  Изменить название организации");
                Console.WriteLine("10. Изменить весь адрес");
                Console.WriteLine("11. Удалить адрес из списка");
                Console.WriteLine("12. Найти адрес по названию организации (LINQ)");
                Console.WriteLine("13. Сортировать по городу (LINQ)");
                Console.WriteLine("14. Очистить весь список");
                Console.WriteLine("0.  Выход");
                Console.WriteLine("======================================");
                Console.Write("Выберите пункт меню: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": CreateAddress(); break;
                    case "2": ShowAllAddresses(); break;
                    case "3": ShowAddressByIndex(); break;
                    case "4": ChangeIndex(); break;
                    case "5": ChangeCity(); break;
                    case "6": ChangeStreet(); break;
                    case "7": ChangeHouse(); break;
                    case "8": ChangeOffice(); break;
                    case "9": ChangeOrganizationName(); break;
                    case "10": ChangeFullAddress(); break;
                    case "11": RemoveAddress(); break;
                    case "12": FindByOrganization(); break;
                    case "13": SortByCity(); break;
                    case "14": ClearAll(); break;
                    case "0": exit = true; break;
                    default:
                        Console.WriteLine("\nНеверный выбор! Нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void CreateAddress()
        {
            Console.Clear();
            Console.WriteLine("=== СОЗДАНИЕ НОВОГО АДРЕСА ===\n");

            Console.Write("Введите название организации: ");
            string orgName = Console.ReadLine();

            Console.Write("Введите индекс: ");
            string index = Console.ReadLine();

            Console.Write("Введите город: ");
            string city = Console.ReadLine();

            Console.Write("Введите улицу: ");
            string street = Console.ReadLine();

            Console.Write("Введите дом: ");
            string house = Console.ReadLine();

            Console.Write("Введите офис: ");
            string office = Console.ReadLine();

            PostalAddress newAddress = new PostalAddress(index, city, street, house, office, orgName);
            addresses.Add(newAddress);

            Console.WriteLine($"\nАдрес добавлен в список! Индекс в списке: {addresses.Count - 1}");
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        static void ShowAllAddresses()
        {
            Console.Clear();
            if (addresses.Count == 0)
            {
                Console.WriteLine("Список адресов пуст.");
                Console.WriteLine("\nНажмите любую клавишу...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine($"=== ВСЕ АДРЕСА (всего: {addresses.Count}) ===\n");
            for (int i = 0; i < addresses.Count; i++)
            {
                Console.WriteLine($"--- Адрес [{i}] ---");
                addresses[i].PrintAddress();
            }
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        static void ShowAddressByIndex()
        {
            Console.Clear();
            if (addresses.Count == 0)
            {
                Console.WriteLine("Список адресов пуст.");
                Console.WriteLine("\nНажмите любую клавишу...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("=== ПОКАЗАТЬ АДРЕС ПО ИНДЕКСУ ===\n");
            Console.WriteLine($"Допустимые индексы: 0 - {addresses.Count - 1}");
            Console.Write("Введите индекс: ");

            if (int.TryParse(Console.ReadLine(), out int index))
            {
                if (index >= 0 && index < addresses.Count)
                {
                    addresses[index].PrintAddress();
                }
                else
                {
                    Console.WriteLine($"\nОшибка: Индекс {index} вне границ списка [0, {addresses.Count - 1}]");
                }
            }
            else
            {
                Console.WriteLine("\nОшибка: введите целое число.");
            }

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        static int SelectAddressIndex(string action)
        {
            if (addresses.Count == 0)
            {
                Console.WriteLine("Список адресов пуст.");
                Console.ReadKey();
                return -1;
            }

            Console.WriteLine($"\nДоступные адреса (0 - {addresses.Count - 1}):");
            for (int i = 0; i < addresses.Count; i++)
            {
                Console.WriteLine($"  [{i}] {addresses[i].GetOrganizationName()}, {addresses[i].GetCity()}");
            }

            Console.Write($"\nВыберите индекс адреса для {action}: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < addresses.Count)
            {
                return index;
            }

            Console.WriteLine("Неверный индекс!");
            Console.ReadKey();
            return -1;
        }

        static void ChangeIndex()
        {
            Console.Clear();
            Console.WriteLine("=== ИЗМЕНЕНИЕ ИНДЕКСА ===\n");
            int index = SelectAddressIndex("изменения индекса");
            if (index == -1) return;

            Console.WriteLine($"Текущий индекс: {addresses[index].GetIndex()}");
            Console.Write("Введите новый индекс: ");
            addresses[index].SetIndex(Console.ReadLine());
            Console.WriteLine("\nИндекс изменен!");
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        static void ChangeCity()
        {
            Console.Clear();
            Console.WriteLine("=== ИЗМЕНЕНИЕ ГОРОДА ===\n");
            int index = SelectAddressIndex("изменения города");
            if (index == -1) return;

            Console.WriteLine($"Текущий город: {addresses[index].GetCity()}");
            Console.Write("Введите новый город: ");
            addresses[index].SetCity(Console.ReadLine());
            Console.WriteLine("\nГород изменен!");
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        static void ChangeStreet()
        {
            Console.Clear();
            Console.WriteLine("=== ИЗМЕНЕНИЕ УЛИЦЫ ===\n");
            int index = SelectAddressIndex("изменения улицы");
            if (index == -1) return;

            Console.WriteLine($"Текущая улица: {addresses[index].GetStreet()}");
            Console.Write("Введите новую улицу: ");
            addresses[index].SetStreet(Console.ReadLine());
            Console.WriteLine("\nУлица изменена!");
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        static void ChangeHouse()
        {
            Console.Clear();
            Console.WriteLine("=== ИЗМЕНЕНИЕ ДОМА ===\n");
            int index = SelectAddressIndex("изменения дома");
            if (index == -1) return;

            Console.WriteLine($"Текущий дом: {addresses[index].GetHouse()}");
            Console.Write("Введите новый дом: ");
            addresses[index].SetHouse(Console.ReadLine());
            Console.WriteLine("\nДом изменен!");
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        static void ChangeOffice()
        {
            Console.Clear();
            Console.WriteLine("=== ИЗМЕНЕНИЕ ОФИСА ===\n");
            int index = SelectAddressIndex("изменения офиса");
            if (index == -1) return;

            Console.WriteLine($"Текущий офис: {addresses[index].GetOffice()}");
            Console.Write("Введите новый офис: ");
            addresses[index].SetOffice(Console.ReadLine());
            Console.WriteLine("\nОфис изменен!");
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        static void ChangeOrganizationName()
        {
            Console.Clear();
            Console.WriteLine("=== ИЗМЕНЕНИЕ НАЗВАНИЯ ОРГАНИЗАЦИИ ===\n");
            int index = SelectAddressIndex("изменения названия");
            if (index == -1) return;

            Console.WriteLine($"Текущее название: {addresses[index].GetOrganizationName()}");
            Console.Write("Введите новое название: ");
            addresses[index].SetOrganizationName(Console.ReadLine());
            Console.WriteLine("\nНазвание организации изменено!");
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        static void ChangeFullAddress()
        {
            Console.Clear();
            Console.WriteLine("=== ИЗМЕНЕНИЕ ВСЕГО АДРЕСА ===\n");
            int index = SelectAddressIndex("изменения всего адреса");
            if (index == -1) return;

            Console.WriteLine("Текущий адрес:");
            addresses[index].PrintAddress();

            Console.Write("Введите новое название организации: ");
            string orgName = Console.ReadLine();
            Console.Write("Введите новый индекс: ");
            string idx = Console.ReadLine();
            Console.Write("Введите новый город: ");
            string city = Console.ReadLine();
            Console.Write("Введите новую улицу: ");
            string street = Console.ReadLine();
            Console.Write("Введите новый дом: ");
            string house = Console.ReadLine();
            Console.Write("Введите новый офис: ");
            string office = Console.ReadLine();

            addresses[index].SetFullAddress(idx, city, street, house, office, orgName);
            Console.WriteLine("\nАдрес полностью изменен!");
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        static void RemoveAddress()
        {
            Console.Clear();
            Console.WriteLine("=== УДАЛЕНИЕ АДРЕСА ИЗ СПИСКА ===\n");
            int index = SelectAddressIndex("удаления");
            if (index == -1) return;

            addresses[index].PrintAddress();
            Console.Write("Вы уверены? (да/нет): ");
            string answer = Console.ReadLine().ToLower();

            if (answer == "да" || answer == "yes" || answer == "y")
            {
                addresses.RemoveAt(index);
                Console.WriteLine("\nАдрес удален из списка!");
            }
            else
            {
                Console.WriteLine("\nУдаление отменено.");
            }

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        static void FindByOrganization()
        {
            Console.Clear();
            Console.WriteLine("=== ПОИСК ПО НАЗВАНИЮ ОРГАНИЗАЦИИ (LINQ) ===\n");

            if (addresses.Count == 0)
            {
                Console.WriteLine("Список адресов пуст.");
                Console.WriteLine("\nНажмите любую клавишу...");
                Console.ReadKey();
                return;
            }

            Console.Write("Введите название организации для поиска: ");
            string searchName = Console.ReadLine().ToLower();

            var found = addresses
                .Where(a => a.GetOrganizationName().ToLower().Contains(searchName))
                .ToList();

            if (found.Count == 0)
            {
                Console.WriteLine($"\nОрганизаций с названием, содержащим '{searchName}', не найдено.");
            }
            else
            {
                Console.WriteLine($"\nНайдено {found.Count} адресов:");
                for (int i = 0; i < found.Count; i++)
                {
                    Console.WriteLine($"\n--- Результат [{i}] ---");
                    found[i].PrintAddress();
                }
            }

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        static void SortByCity()
        {
            Console.Clear();
            Console.WriteLine("=== СОРТИРОВКА ПО ГОРОДУ (LINQ) ===\n");

            if (addresses.Count == 0)
            {
                Console.WriteLine("Список адресов пуст.");
                Console.WriteLine("\nНажмите любую клавишу...");
                Console.ReadKey();
                return;
            }

            var sorted = addresses
                .OrderBy(a => a.GetCity())
                .ThenBy(a => a.GetOrganizationName())
                .ToList();

            Console.WriteLine("Адреса, отсортированные по городу:");
            for (int i = 0; i < sorted.Count; i++)
            {
                Console.WriteLine($"\n[{i}] {sorted[i].GetOrganizationName()} — {sorted[i].GetCity()}, {sorted[i].GetStreet()}, {sorted[i].GetHouse()}");
            }

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }

        static void ClearAll()
        {
            Console.Clear();
            Console.WriteLine("=== ОЧИСТКА СПИСКА ===\n");

            if (addresses.Count == 0)
            {
                Console.WriteLine("Список уже пуст.");
                Console.WriteLine("\nНажмите любую клавишу...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine($"В списке {addresses.Count} адресов.");
            Console.Write("Вы уверены? (да/нет): ");
            string answer = Console.ReadLine().ToLower();

            if (answer == "да" || answer == "yes" || answer == "y")
            {
                addresses.Clear();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                Console.WriteLine("\nСписок очищен!");
            }
            else
            {
                Console.WriteLine("\nОчистка отменена.");
            }

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
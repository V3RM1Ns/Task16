namespace task19new;
using System.Text.Json;
class Program
    {
        static string folderPath = "/Users/apple/RiderProjects/task19new/task19new/Data";
        static string filePath = Path.Combine(folderPath, "Database.json");
        static Department department = new Department { Id = 1, Name = "IT", Employees = new List<Employee>() };

        static void Main(string[] args)
        {
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "");
            }
                

            while (true)
            {
                Console.Clear();
                Console.WriteLine("========== MENU ==========");
                Console.WriteLine("1. Add employee");
                Console.WriteLine("2. Get employee by id");
                Console.WriteLine("3. Remove employee");
                Console.WriteLine("0. Quit");
                Console.WriteLine("==========================");
                Console.Write("Seciminizi daxil edin: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddEmployee();
                        break;
                    case "2":
                        GetEmployeeById();
                        break;
                    case "3":
                        RemoveEmployeeById();
                        break;
                    case "0":
                        Console.WriteLine("\nÇıxış edildi. Proqram bağlanır...");
                        return;
                    default:
                        Console.WriteLine("\n[!] Yanlış seçim etdiniz. Zəhmət olmasa düzgün seçim edin.");
                        break;
                }
            }
        }
        

        static void AddEmployee()
        {
            Console.Clear();
            Console.WriteLine("--- Yeni işçi əlavə et ---");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine()!);

            Console.Write("Ad: ");
            string name = Console.ReadLine()!;

            Console.Write("Maaş: ");
            double salary = double.Parse(Console.ReadLine()!);

            Employee employee = new Employee { Id = id, Name = name, Salary = salary };
            department.Employees.Add(employee);

            using FileStream fs = new FileStream(filePath, FileMode.Create);
            using StreamWriter sw = new StreamWriter(fs);
            string json = JsonSerializer.Serialize(department);
            sw.WriteLine(json);

            Console.WriteLine($"\n✅ İşçi əlavə olundu: {name} (ID: {id}, Maaş: {salary})");
            Console.WriteLine("\nƏsas menyuya qayıtmaq üçün ENTER bas...");
            Console.ReadLine();
        }

        static void GetEmployeeById()
        {
            Console.Clear();
            Console.WriteLine("--- İşçini ID ilə axtar ---");
            Console.Write("ID-ni daxil edin: ");
            int id = int.Parse(Console.ReadLine()!);

            string json = File.ReadAllText(filePath);
            Department departmentFromFile = JsonSerializer.Deserialize<Department>(json);

            Employee employee = departmentFromFile.GetEmployeeById(id);

            Console.WriteLine("\n🔍 Axtarış nəticəsi:");
            Console.WriteLine("--------------------------");
            Console.WriteLine($"ID: {employee.Id}");
            Console.WriteLine($"Ad: {employee.Name}");
            Console.WriteLine($"Maaş: {employee.Salary}");
            Console.WriteLine("--------------------------");

            Console.WriteLine("\nƏsas menyuya qayıtmaq üçün ENTER bas...");
            Console.ReadLine();
        }

        static void RemoveEmployeeById()
        {
            Console.Clear();
            Console.WriteLine("--- İşçi sil ---");
            Console.Write("Silinəcək işçinin ID-sini daxil edin: ");
            int id = int.Parse(Console.ReadLine()!);

            
            string json = File.ReadAllText(filePath);
            Department departmentFromFile = JsonSerializer.Deserialize<Department>(json);

          
            Employee employee = departmentFromFile.GetEmployeeById(id);
            departmentFromFile.Employees.Remove(employee);

            
            string updatedJson = JsonSerializer.Serialize(departmentFromFile);
            File.WriteAllText(filePath, updatedJson);

            Console.WriteLine($"\n❌ İşçi silindi: {employee.Name} (ID: {employee.Id})");
            Console.WriteLine("\nƏsas menyuya qayıtmaq üçün ENTER bas...");
            Console.ReadLine();
        }
    }
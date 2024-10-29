using System;

namespace FreelancerManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectManager manager = new ProjectManager();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Оберiть дiю:");
                Console.WriteLine("1. Додати проєкт веб-розробки");
                Console.WriteLine("2. Додати проєкт мобiльної розробки");
                Console.WriteLine("3. Показати всi проєкти");
                Console.WriteLine("4. Показати деталi проєкту");
                Console.WriteLine("5. Зберегти проєкти у файл XML");
                Console.WriteLine("6. Завантажити проєкти з файлу XML");
                Console.WriteLine("7. Вийти");
                Console.Write("Введiть номер дiї: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Введiть назву проєкту: ");
                        string webTitle = Console.ReadLine();
                        Console.Write("Введiть кiлькiсть годин, необхiдних для виконання: ");
                        if (int.TryParse(Console.ReadLine(), out int webHours))
                        {
                            manager.AddProject(new WebDevelopmentProject(webTitle, webHours));
                            Console.WriteLine("Проєкт веб-розробки успiшно додано.");
                        }
                        else
                        {
                            Console.WriteLine("Помилка: введіть ціле число для кількості годин.");
                        }
                        break;

                    case "2":
                        Console.Write("Введiть назву проєкту: ");
                        string mobileTitle = Console.ReadLine();
                        Console.Write("Введiть кiлькiсть годин, необхiдних для виконання: ");
                        if (int.TryParse(Console.ReadLine(), out int mobileHours))
                        {
                            manager.AddProject(new MobileDevelopmentProject(mobileTitle, mobileHours));
                            Console.WriteLine("Проєкт мобiльної розробки успiшно додано.");
                        }
                        else
                        {
                            Console.WriteLine("Помилка: введіть ціле число для кількості годин.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Список усiх проєктів:");
                        manager.DisplayAllProjects();
                        break;

                    case "4":
                        Console.Write("Введiть номер проєкту: ");
                        if (int.TryParse(Console.ReadLine(), out int projectNumber) && projectNumber > 0)
                        {
                            manager.DisplayProjectInfo(projectNumber - 1);
                        }
                        else
                        {
                            Console.WriteLine("Помилка: введіть дійсний номер проєкту.");
                        }
                        break;

                    case "5":
                        Console.Write("Введіiь шлях до файлу для збереження: ");
                        string savePath = Console.ReadLine();
                        manager.SaveProjectsToFile(savePath);
                        Console.WriteLine("Проєкти успішно збережено у файл.");
                        break;

                    case "6":
                        Console.Write("Введiть шлях до файлу для завантаження: ");
                        string loadPath = Console.ReadLine();
                        manager.LoadProjectsFromFile(loadPath);
                        Console.WriteLine("Проєкти успішно завантажено з файлу.");
                        break;

                    case "7":
                        exit = true;
                        Console.WriteLine("Програма завершила роботу.");
                        break;

                    default:
                        Console.WriteLine("Некоректний вибiр. Спробуйте ще раз.");
                        break;
                }
            }
        }
    }
}

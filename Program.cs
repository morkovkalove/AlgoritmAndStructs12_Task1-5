using System;
using System.Collections.Generic;
using System.Threading;

//Для списка пользователей добавьте приветствие по имени.
//Если пользователь не имеет премиум-подписки, то ему нужно показать рекламу.
namespace Task12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>();
            users.Add(new User("Jonsons", "Alex", true));
            users.Add(new User("StellaCox79", "Stella", true));
            users.Add(new User("babaika784", "Semen", false));
            users.Add(new User("habibabalaaqbala", "Joshua", false));
            users.Add(new User("s645646", "Neznaikin", true));
            
            
            try
            {
                Console.WriteLine("Введите логин:");
                string login = Console.ReadLine();
                
                var user = users.Find(x => x.Login == login);

                if (user == null)
                {
                    throw new Exception("Пользователя с таким логином нет.");
                }
                else
                {
                    if (user.IsPremium)
                    {
                        Console.WriteLine($"Приветствую вас, {user.Name} !");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"Реклама:");
                        ShowAds();
                        return;
                    }
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Логин не может быть пустым.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Для выхода нажмите любую кнопку");
            Console.ReadKey();
        }
        
        
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}

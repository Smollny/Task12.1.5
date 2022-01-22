using System;
using System.Collections.Generic;
using System.Threading;

namespace Task12._1._5
{
    class Program
    {
        static void Main(string[] args)
        {
			List<User> users = new List<User> { 
				new User { Name = "John", Login = "John", IsPremium = true },
				new User { Name = "Bill", Login = "Bill", IsPremium = false },
				new User { Name = "George", Login = "George", IsPremium = true },
				new User { Name = "Mickey", Login = "Mickey", IsPremium = false } };

            foreach (var item in users)
            {
                Console.WriteLine($"Hello, {item.Name}");
				if (!item.IsPremium) ShowAds();
            }
			Console.ReadKey();
        }

		static void ShowAds()
		{
			Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
			Thread.Sleep(1000);

			Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
			Thread.Sleep(2000);

			Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
			Thread.Sleep(3000);
		}
	}
}

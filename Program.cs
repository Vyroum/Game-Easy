using System;
namespace Game

 class Program
  {
  static void Main(string[] args)
        {
            Console.WriteLine("Игра Перестрелка ");
            Tank player = new Tank("Танк игрока", 5, 100, 25); // танк игрока
            Tank ai = new Tank("Танк противника", 5, 100, 25); // танк компьютера
            int i = 1;
            string key;
            int amount = 10; // величина починки
            key = Console.ReadLine();
            Random rnd = new Random();
            while (player.GetHealth() > 0 && ai.GetHealth() > 0) // условие победы
            {
                Console.WriteLine($"Раунд {i}"); // вывод номера раунда
                
               {
                    do                   // начало валидации пользовательского ввода
                    {
                        player.PrintInfo();
                        ai.PrintInfo();
                        Console.WriteLine();
                        Console.WriteLine("Выберите действие");
                        Console.WriteLine("1. Выстрелить");
                        Console.WriteLine("2. Починка");
                        Console.WriteLine();
                        key = Console.ReadLine();
                        if (key != "1" && key != "2")
                        {
                            Console.WriteLine("Неизвестное действие, введите номер действия из списка");
                        }
                    }
                    while (key != "1" && key != "2"); // конец пользовательского ввода
                     
                }
               if (key == "1")
                {
                    player.Shoot(ref ai);
                }
                else if (key == "2")
                {
                    player.Repair(amount);
                }
                if (ai.GetHealth() <= 0)
                {
                    break;
                }
                int aim = rnd.Next(1, 3);
                if (aim == 1)
                {
                    ai.Shoot(ref player);
                    Console.WriteLine("Противник стреляет");
                }
                else if (aim == 2)
                {
                    ai.Repair(amount);
                    Console.WriteLine("Противник чинится");
                }
                i++;                     
            }
            if (player.GetHealth() > 0 || ai.GetHealth() <= 0)
            {
                Console.WriteLine("Игрок победил");
            }
            else if (player.GetHealth() <= 0 || ai.GetHealth() > 0)
            { 
             Console.WriteLine("Противник победил"); 
            }
                Console.ReadKey();

        }
  }
    class Tank // объявление класса Танк
    {
        int armor; // броня танка 
        int health; // хп танка 
        int damage; // урон танка 
        string name; //имя танка
        public Tank(string n, int a, int h, int d) // конструкторы класса Танк
        { 
            name = n;
            armor = a; 
            health = h; 
            damage = d; 
        }
        public void PrintInfo() // вывод информации о танке
        {
            Console.WriteLine($" {name} | Броня: {armor}  Жизни: {health} Урон: {damage}");
        }
        
        public void Shoot(ref Tank enemy) // метод стрельбы
        {
            enemy.health = enemy.health - damage + enemy.armor;
            
        }

        public void Repair(int amount) // метод починки
        {
            health = health + amount;
        }
        public int GetHealth() // метод получения текущего здоровья для условия окончания цикла
        {
            return health;
           
        }
    }
        
}
   


using System;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lerner2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string helper = "ты должен будешь выбрать класс за который ты будешь играть(учти... от твоего выбора будет зависить игра).Так же тебе дается изначально комлект с броней и всей этой дребедней,а дальше ты сам разберешься... good luck";
            string zomb = "зомби";
            string people = "человек";
            double armorz = 50;
            double armorPeop = 100;

            Console.WriteLine("Хотите начать играть в нашу замечательную игру? напишите ДА или НЕТ");

            string res = Console.ReadLine();
            switch (res)
            {
                case "lf":
                case "да":
                case "ДА":
                case "конечно":
                case "LA":
                case "la":
                case "Да":
                    Console.WriteLine("так продолжаем , вот наши правила... " + helper);
                    break;
                case "нет":
                case "не а":
                case "НЕ":
                case "не":
                case "НЕ А":
                case "НЕТ":
                    if (true)
                    {
                        Console.WriteLine("окей окей,нажмите ENTER для выхода");
                        Console.ReadLine();
                        return;
                    }
                default:
                    Console.WriteLine("не понял вас повторите попытку");
                    return;
            }

            Console.WriteLine("\n\n\nза кого вы хотите играть?" + zomb + " ИЛИ " + people + "?");
            string user = Console.ReadLine();


            if (user == zomb)
            {
                Console.WriteLine("у зомби соотношение брони = " + armorz);
            }
            else if (user == people)
            {
                Console.WriteLine("У человека соотношение брони = " + armorPeop);
            }
            else
            {
                Console.WriteLine("не правильный выбор");
            }

            //Console.WriteLine("мы(зомби) появились недавно,примерно в этом столетии и стех пор зомби сражаются с людьми\nидут очень кровопролитные войны но в какой то момент\nпроизошло что то ужастное.....");
            //Console.WriteLine("люди населявшие эту плонету очень долгое время и не могли представить что однажды ученные захотят воскрести какого то человека.\nи с тех пор всего один воскревший человек заразит весь мир\nименно тогда началась война за выживание ");



            // ЗОМБИ //
            if (user == zomb)
            {
                Console.WriteLine("мы(зомби) появились недавно,примерно в этом столетии и стех пор зомби сражаются с людьми\nидут очень кровопролитные войны но в какой то момент\nпроизошло что то ужастное.....");
                Thread.Sleep(3000);

                Console.WriteLine("На вас напал человек, у него 30 hp и 3 брони... будите ли вы давать отпор?");
                string otvet = Console.ReadLine();
                Thread.Sleep(3000);

                if (otvet == "да")
                {
                    Random rnd = new Random();
                    double Hp_atacc = rnd.Next(0, 20);
                    double ataccet = Hp_atacc;
                    Console.WriteLine("его урон равен: " + ataccet);
                    Thread.Sleep(2000);
                    double hp = 100 - ataccet;

                    while (hp > 0)
                    {
                        Console.WriteLine("ваше здоровье стало: " + hp);
                        Console.WriteLine("ваша броня снилазь до значения: " + armorz);
                        Thread.Sleep(2000);
                        
                    }
                    Console.WriteLine(hp);
                    Thread.Sleep(2000);

                }
                else if (otvet == "нет")
                {
                    Console.WriteLine("фух.. пронесло,можно не беспокоится о моем здоровье. Я ЖИВ");
                    Console.WriteLine("ну пока что это выглядит вот так вот:)");
                    Thread.Sleep(2000000);
                }
                else
                {
                    Console.WriteLine("не понял вашего выбора\nвозможно вы писали что то кромее'да' или 'нет'");
                    Thread.Sleep(60000);
                    return;
                }
            }







            // ЛЮДИ //
            else if (user == people)
            {
                Console.WriteLine("люди населявшие эту плонету очень долгое время и не могли представить что однажды ученные захотят воскрести какого то человека.\nи с тех пор всего один воскревший человек заразит весь мир\nименно тогда началась война за выживание ");
                Console.WriteLine("На вас напал зомби, у него 30 hp и 3 брони... будите ли вы давать отпор?");
                string otvet = Console.ReadLine();

                Thread.Sleep(3000);

                if (otvet == "да")
                {
                    Random rnd = new Random();
                    double Hp_atacc = rnd.Next(0, 20);
                    double ataccet = Hp_atacc;
                    Console.WriteLine("его урон равен: " + ataccet);
                    Thread.Sleep(2000);
                    double hp = 100 - ataccet;

                    // случайные события

                    while (hp > 0)
                    {
                        // первое нападение
                        Console.WriteLine("ваше здоровье стало: " + hp);
                        Console.WriteLine("ваша броня снилазь до значения: " + armorz);

                        string[] randoms = new string[5];
                        randoms[0] = "аптечка";
                        randoms[1] = "о нет...Зомби";
                        randoms[2] = "броня";
                        randoms[3] = "пропасть";
                        randoms[4] = "сломался";

                        Random r = new Random();
                        string eventPeop = randoms[r.Next(0, randoms.Length)];

                        if (eventPeop == "аптечка")
                        {
                            Console.WriteLine("ой я наткнулся на аптечку круто...");
                        }

                        continue;
                    }
                }
                else if (otvet == "нет")
                {
                    Console.WriteLine("фух.. пронесло,можно не беспокоится о моем здоровье. Я ЖИВ");
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("не понял вашего выбора\nвозможно вы писали что то кромее'да' или 'нет'");
                    Thread.Sleep(60000);
                    return;
                }


            }
        }
    }
}




























    /*if (user == zomb)
    {
        Console.WriteLine("у зомби соотношение брони = " + armorz);
    }
    else if (user == people)
    {
        Console.WriteLine("У человека соотношение брони = " + armorPeop);
    }
    else
    {
        Console.WriteLine("не правильный выбор");
    }*/

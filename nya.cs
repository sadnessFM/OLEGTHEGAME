using System;

namespace nynaynayyanyanynaynanyanynaynay
{
    public class KOSHAK
    {
        public KOSHAK(int age, string gender, string name)
        {
            Age = age;
            Gender = gender;
            Name = name;
            Weight = 5;
            path = "C:\Users\ArtSt\source\repos\nynaynayyanyanynaynanyanynaynay\apchi.wav";
        }

        public void pelmeni(int kolvozhratva, string zhratva)
        {
            if (Check())
                Console.WriteLine("КОТ УМЕР ОТ ОЖИРЕНИЯ");

            else
            {
                Weight += kolvozhratva;
                Console.WriteLine(Check()
                    ? $"{Name} НАЕЛСЯ {zhratva} И УМЕР ОТ КРИНЖА. ТЫ ПЛОХОЙ БУРАНЬЮЮ"
                    : $"КОШАК {Name} ПОЕЛ {kolvozhratva} {zhratva}, ПОЛУЧАЕТ БУРАНЬЮЮ");
            }
        }

        public void perekur()
        {
            if (Check())
                Console.WriteLine("КОТ УМЕР ОТ РАКА ЛЕГКИХ");

            else
            {
                Weight -= Weight + 1;
                Console.WriteLine($"{Name} достает ментоловую сигарету из ярко зеленой пачки." +
                                  "Она легонько пахнет ментолом на свежем воздухе, отдавая табаком" +
                                  $"{Name} садится на близжайшую скамейку и закуривает" +
                                  $"Спустя 5 минут {Name} выбрасывет окурок и обнаруживает что почти полностью сбросил вес"
                );
            }

        }

        public void OutInfo() { Console.WriteLine($"{GetName()}, {GetAge()}, {GetGender()}, {GetWeight()} тонн"); }

        private bool Check() => Weight > 100;

        private int GetAge() => Age;

        private string GetName() => Name;

        private string GetGender() => Gender;

        private int GetWeight() => Weight;

        private int Weight { get; set; }

        private string Gender { get; }

        private string Name { get; }

        private int Age { get; }
    }
}

/*
 * 
 *— Фима, зачем ты взял новый пакетик чая?
 *— На старом уже ниточка оборвалась.
 *— А что такое, рук нету пришить?
 *
 * В израильской армии можно не только отвечать вопросом на вопрос, но и спрашивать ответом на ответ.
 * 
*/


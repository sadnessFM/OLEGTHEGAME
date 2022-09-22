namespace nynaynayyanyanynaynanyanynaynay
{
    internal class KOSHAK
    {
        public KOSHAK(int age, string gender, string name)
        {
            Age = age;
            Gender = gender;
            Name = name;
            Weight = 50;
        }

        public string Pelmeni(int kolvozhratva)
        {
            if (Check())
                return $"{Name} ЕБАНУЛИ ДЕЗОЛЯТОРОМ 1000-7 Я УМЕР ПРОZТИ";

            else
            {
                Weight += kolvozhratva;
                return Check()
                    ? $"{Name} НАЕЛСЯ СНЮСИКА ГРОМКО ПУКНУЛ. ТЫ ПЛОХОЙ БУРАНЬЮЮ"
                    : $"{Name} НАЕЛСЯ {kolvozhratva} СНЮСИКА ГРОМКО ПУКНУЛ";
            }
        }

        public string Perekur(int amount)
        {
            if (Check())
                return $"{Name} ЕБАНУЛИ ДЕЗОЛЯТОРОМ 1000-7 Я УМЕР ПРОZТИ";

            else
            {
                Weight -= amount;
                return $"{Name} антипоел на {amount} тонн";
            }
        }



        public string OutInfo() => $"{GetName()}, {GetAge()} лет, {GetGender()}, {GetWeight()} тонн";

        public bool Check() => Weight >= 100 || Weight <= 0;

        private int GetAge() => Age;

        private string GetName() => Name;

        private string GetGender() => Gender;

        public int GetWeight() => Weight;

        private int Weight { get; set; }

        private string Gender { get; }

        private string Name { get; set; }

        private int Age { get; set; }
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

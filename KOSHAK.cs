namespace nynaynayyanyanynaynanyanynaynay
{
    internal class KOSHAK
    {
        public KOSHAK(int age, string gender, string name)
        {
            Age = age;
            Gender = gender;
            Name = name;
            Weight = 500;
        }

        public string Pelmeni(int kolvozhratva)
        {
            if (Check())
                return desoldeath(Name);

            else
            {
                Weight += kolvozhratva;
                return $"{Name} НАЕЛСЯ {kolvozhratva / 10} СНЮСИКА ГРОМКО ПУКНУЛ";
            }
        }

        public string Perekur(int amount)
        {
            if (Check())
                return desoldeath(Name);

            else
            {
                Weight -= amount;
                return $"{Name} антипоел на {amount / 10} тонн";
            }
        }



        public string OutInfo() => $"{Name}, {Age} лет, {Gender}, {Weight/10} тонн";
        public bool Check() => Weight >= 1000 || Weight <= 0;
        private string desoldeath(string catName) => $"{catName} ЕБАНУЛИ ДЕЗОЛЯТОРОМ 1000-7 Я УМЕР ПРОZТИ";

        public int Weight { get; set; }
        private string Gender { get; set; }
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
 * Мама спрашивает Вовочку: 
 * — В буфете было два куска торта, а сейчас один; можешь ты это обьяснить? 
 * — Кончно! Было темно и я не заметил второй кусок! 
 * 
*/

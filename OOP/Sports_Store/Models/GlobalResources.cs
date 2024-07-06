using Sports_store.Database;


namespace Sports_store.Models
{
    public static class GlobalResources
    {
        public static SportsContext Context;

        private static User currentUser;

        public static User CurrentUser
        {
            get { return currentUser; }
            set
            {
                currentUser = value;

            }
        }


        public static readonly List<string> Categories = new List<string>()
        {
            "Все",
            "Футбол",
            "Баскетбол",
            "Волейбол",
            "Гольф",
            "UFC",
            "Бокс",
            "Борьба",
            "Дзюдо",
            "Карате",
            "Йога",
            "Фитнес",
            "Теннис",
            "Бег",
            "Тяжелая атлетика"
        };
        public static readonly List<string> Types = new List<string>()
        {
            "Любой",
            "Обувь",
            "Одежда",
            "Тренажеры",
            "Инвентарь",
            "Аксессуары"
        };
        public static readonly List<string> Colors = new List<string>()
        {
            "Любой",
            "Красный",
            "Синий",
            "Черный",
            "Белый",
            "Желтый",
            "Зеленый",
            "Фиолетовый",
            "Оранжевый",
            "Розовый",
            "Коричневый",
            "Серый"
        };
    }
}

namespace SoTCookingTimer
{
    public class CookTime
    {
        public string Name { get; set; }
        public string[] Images { get; set; }
        public int UndercookedSeconds { get; set; }
        public int CookedSeconds { get; set; }
        public int BurnedSeconds { get; set; }

        public static CookTime[] CookTimes = new[]
        {
            new CookTime
            {
                Name = "Fish",
                Images = new [] { "Fish_Ruby_SplashTail_Small.png", "Fish_Olive_PlentiFin_Small.png"  },
                UndercookedSeconds = 30,
                CookedSeconds = 40,
                BurnedSeconds = 80,
            },
            new CookTime
            {
                Name = "Trophy Fish",
                Images = new [] { "Fish_Ruby_SplashTail.png"} ,
                UndercookedSeconds = 80,
                CookedSeconds = 90,
                BurnedSeconds = 180,
            },
            new CookTime
            {
                Name = "Animal meat",
                Images = new [] {"Food_Bacon.png", "Chicken.png" },
                UndercookedSeconds = 50,
                CookedSeconds = 60,
                BurnedSeconds = 120,
            },
            new CookTime
            {
                Name = "Monster meat",
                Images = new [] { "Kraken_Meat.png", "Meg_Meat.png" },
                UndercookedSeconds = 100,
                CookedSeconds = 120,
                BurnedSeconds = 240,
            },
        };
    }
}
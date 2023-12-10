namespace LineageEnhance.Models
{
    public class AppRuntime
    {
        public bool CoolDownState { get; set; } = false;

        public int Level { get; set; } = 48;
        public int Dex { get; set; } = 18;
        public int Experience { get; set; } = 0;

        public List<Equipment> Equipments { get; set; }

        public AppRuntime()
        {
            Equipments = new List<Equipment> {
                new Equipment { Name = "艾爾穆的祝福", Safe = 6, Defence = -6, Image = "helmet" },
                new Equipment { Name = "精靈金屬盔甲", Safe = 6, Defence = -6, Image = "armor" },
                new Equipment { Name = "保護者斗篷", Safe = 4, Defence = -3, Image = "cloak" },
                new Equipment { Name = "精靈T恤", Safe = 6, Defence = 0, Image = "shirt" },
                new Equipment { Name = "鋼靴", Safe = 4, Defence = -3, Image = "boots" },
                new Equipment { Name = "腕甲", Safe = 4, Defence = 0, Image = "glove" },
                new Equipment { Name = "尤米弓", Safe = 6, Image = "weapon", IsEnhanceable = false},
                new Equipment { Name = "妖魔鬥士護身符", Safe = 0, Defence = 0, IsEnhanceable = false, Image = "amulet" },
                new Equipment { Name = "抗魔戒指", Safe = 0, Defence = 0, IsEnhanceable = false, Image = "ring" },
                new Equipment { Name = "抗魔戒指", Safe = 0, Defence = 0, IsEnhanceable = false, Image = "ring" },
                new Equipment { Name = "多羅腰帶", Safe = 0, Defence = 0, IsEnhanceable = false, Image = "belt" }
            };
        }
    }
}

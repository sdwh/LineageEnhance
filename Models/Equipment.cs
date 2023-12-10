namespace LineageEnhance.Models
{
    public class Equipment
    {
        public string Name { get; set; } = "";
        public int Enhanced { get; set; } = 0;
        public int Safe { get; set; }
        public int Defence { get; set; }
        public bool IsEnhanceable { get; set; } = true;

        public bool IsWeapon { get; set; } = false;
        public string Image { get; set; } = "";
    }
}

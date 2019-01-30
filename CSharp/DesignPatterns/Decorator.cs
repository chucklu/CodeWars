namespace ConsoleApp.DesignPatterns
{
    //https://www.codewars.com/kata/patterncraft-decorator/train/csharp

    public interface IMarine
    {
        int Damage { get; set; }
        int Armor { get; set; }
    }

    public class Marine : IMarine
    {
        public Marine(int damage, int armor)
        {
            Damage = damage;
            Armor = armor;
        }

        public int Damage { get; set; }

        public int Armor { get; set; }
    }

    public class CustomUpgradeBase : IMarine
    {
        public CustomUpgradeBase(IMarine marine)
        {
            //shadow copy
            Marine = new Marine(marine.Damage, marine.Armor);
        }

        protected IMarine Marine;

        public int Damage
        {
            get => Marine.Damage;
            set => Marine.Damage = value;
        }

        public int Armor
        {
            get => Marine.Armor;
            set => Marine.Armor = value;
        }
    }

    public class MarineWeaponUpgrade : CustomUpgradeBase
    {

        public MarineWeaponUpgrade(IMarine marine) : base(marine)
        {
            Damage++;
        }
    }

    public class MarineArmorUpgrade : CustomUpgradeBase
    {
        public MarineArmorUpgrade(IMarine marine) : base(marine)
        {
            Armor++;
        }
    }
}

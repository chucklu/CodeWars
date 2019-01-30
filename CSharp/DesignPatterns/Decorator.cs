﻿namespace ConsoleApp.DesignPatterns
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

    public class MarineWeaponUpgrade : IMarine
    {
        private IMarine marine;

        public MarineWeaponUpgrade(IMarine marine)
        {

        }

        public int Damage { get; set; }

        public int Armor { get; set; }
    }

    public class MarineArmorUpgrade : IMarine
    {
        private IMarine marine;

        public MarineArmorUpgrade(IMarine marine)
        {

        }

        public int Damage { get; set; }

        public int Armor { get; set; }
    }
}

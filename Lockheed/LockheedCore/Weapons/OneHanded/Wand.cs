namespace LockHeedCore.Weapons.OneHanded
{
    public class Wand : Weapon
    {
        public Wand(
            string weaponType = "Wand", 
            WeaponHandling weaponHandling = WeaponHandling.OneHanded, 
            int damage = 70, 
            int range = 7) 
            : base(weaponType, weaponHandling, damage, range)
        {
        }
    }
}

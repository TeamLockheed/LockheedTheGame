namespace LockHeedCore.Weapons.OneHanded
{
    public class Hatchet : Weapon
    {
        public Hatchet(
            string weaponType = "Hatchet", 
            WeaponHandling weaponHandling = WeaponHandling.OneHanded, 
            int damage = 60, 
            int range = 2) 
            : base(weaponType, weaponHandling, damage, range)
        {
        }
    }
}

namespace LockHeedCore.Weapons.TwoHanded
{
    public class WarAxe : Weapon
    {
        public WarAxe(
            string weaponType = "War Axe", 
            WeaponHandling weaponHandling = WeaponHandling.TwoHanded, 
            int damage = 65, 
            int range = 3) 
            : base(weaponType, weaponHandling, damage, range)
        {
        }
    }
}

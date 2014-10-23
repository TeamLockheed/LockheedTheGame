namespace LockHeedCore
{
    public class Crossbow : Weapon
    {
        public Crossbow(
            string weaponType = "Crossbow", 
            WeaponHandling weaponHandling = WeaponHandling.TwoHanded, 
            int damage = 60, 
            int range = 5) 
            : base(weaponType, weaponHandling, damage, range)
        {
        }
    }
}

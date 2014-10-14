namespace LockHeedCore.Weapons.TwoHanded
{
    public class GreatSword : Weapon
    {
        public GreatSword(
            string weaponType = "Great Sword", 
            WeaponHandling weaponHandling = WeaponHandling.TwoHanded, 
            int damage = 55, 
            int range = 3) 
            : base(weaponType, weaponHandling, damage, range)
        {
        }
    }
}

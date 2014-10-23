namespace LockHeedCore.Weapons.OneHanded
{
    public class BastardSword : Weapon
    {
        public BastardSword(
            string weaponType = "Bastard Sword", 
            WeaponHandling weaponHandling = WeaponHandling.OneHanded, 
            int damage = 45, 
            int range = 2) 
            : base(weaponType, weaponHandling, damage, range)
        {
        }
    }
}

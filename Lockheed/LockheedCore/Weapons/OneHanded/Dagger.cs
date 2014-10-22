namespace LockHeedCore.Weapons.OneHanded
{
    public class Dagger : Weapon
    {
        public Dagger(
            string weaponType = "Dagger",
            WeaponHandling weaponHandling = WeaponHandling.OneHanded, 
            int damage = 45, 
            int range = 2) 
            : base(weaponType, weaponHandling, damage, range)
        {
        }
    }
}

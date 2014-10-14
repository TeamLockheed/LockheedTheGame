namespace LockHeedCore.Weapons.TwoHanded
{
    public class Bow : Weapon
    {
        public Bow(
            string weaponType = "Bow",
            WeaponHandling weaponHandling = WeaponHandling.TwoHanded,
            int damage = 50,
            int range = 6)
            : base(weaponType, weaponHandling, damage, range)
        {
        }
    }
}

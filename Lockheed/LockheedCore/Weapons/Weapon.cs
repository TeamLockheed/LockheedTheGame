namespace LockHeedCore.Weapons
{
    using System;

    public abstract class Weapon
    {
        private string weaponType;
        private WeaponHandling weaponHandling;
        private int damage;
        private int range;
        
        protected Weapon(string weaponType, WeaponHandling weaponHandling, int damage, int range)
        {
            this.weaponType = weaponType;
            this.weaponHandling = weaponHandling;
            this.damage = damage;
            this.range = range;
        }

        public string WeaponType
        {
            get
            {
                return this.weaponType;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The weapon type can't be null!");
                }

                this.weaponType = value;
            }
        }

        public WeaponHandling WeaponHandling
        {
            get { return this.weaponHandling; }
            set { this.weaponHandling = value; }
        }

        public int Damage
        {
            get
            {
                return this.damage;
            }

            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("The damage can't be negative!");
                    }

                    this.damage = value;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid damage value! " + ex);
                }
            }
        }

        public int Range
        {
            get
            {
                return this.range;
            }

            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("The range can't be negative!");
                    }

                    this.range = value;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid range value! " + ex);
                }
            }
        }
    }
}

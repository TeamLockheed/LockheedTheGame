using System;
using System.Collections.Generic;

namespace Lockheed_Inventory.Slots.Interfaces
{
    public interface IWeapon
    {
        List<Item> WeaponsList { get; set; }
    }
}

using System;
using Lockheed_Inventory.Slots.Interfaces;

namespace Lockheed_Inventory
{
    public abstract class Slot : ISlot
    {
        protected bool freeSlot = true;
        public abstract bool FreeSlot { get; set; }
        public abstract void Equip(Item item);
        public abstract void UnEquip(Item item);
    }
}

using System;

namespace Lockheed_Inventory.Slots.Interfaces
{
    public interface ISlot
    {
        bool FreeSlot
        {
            get;
            set;
        }

        void Equip(Item item);

        void UnEquip(Item item);
    }
}

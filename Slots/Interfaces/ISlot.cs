namespace Lockheed_Inventory.Slots.Interfaces
{
    using System;
    using System.Collections.Generic;
    public interface ISlot
    {
        void Equip(IEquipedItems item);
        void UnEquip(IEquipedItems item);
        List<IEquipedItems> EquipedItemsList { get; }
    }
}

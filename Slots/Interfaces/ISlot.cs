namespace Lockheed_Inventory.Slots.Interfaces
{
    using System;
    using System.Collections.Generic;
    public interface ISlot
    {
        void Equip(SlotsEnueration item);

        void UnEquip(SlotsEnueration item);
        List<SlotsEnueration> EquipedItemsList { get; }
    }
}

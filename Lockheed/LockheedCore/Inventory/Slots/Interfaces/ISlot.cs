namespace LockHeedCore
{
    using System;
    using System.Collections.Generic;
    public interface ISlot
    {
        void Equip(IEquippedItems item);
        void UnEquip(IEquippedItems item);
        List<IEquippedItems> EquippedItemsList { get; }
    }
}

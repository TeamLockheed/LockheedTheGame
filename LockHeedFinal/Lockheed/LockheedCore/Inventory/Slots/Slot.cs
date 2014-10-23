namespace LockHeedCore
{
    using System;
    using System.Collections.Generic;
 

    public class Slot : ISlot, IEquippedItems
    {
        private List<IEquippedItems> equippedItemsList = new List<IEquippedItems>();

        private bool isItemEquipped(IEquippedItems item)
        {
            if (this.equippedItemsList.IndexOf(item) != -1)
            {
                return true;
            }
            return false;
        }
        public void Equip(IEquippedItems item)
        {
            if (this.isItemEquipped(item))
            {
                this.equippedItemsList.Remove(item);
            }
            this.equippedItemsList.Add(item);
        }

        public void UnEquip(IEquippedItems item)
        {
            this.equippedItemsList.Remove(item);
        }

        public List<IEquippedItems> EquippedItemsList
        {
            get { return this.equippedItemsList; }
        }
    }
}

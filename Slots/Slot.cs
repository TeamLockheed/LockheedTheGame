namespace Lockheed_Inventory.Slots
{
    using System;
    using System.Collections.Generic;
    using Lockheed_Inventory.Slots.Interfaces;

    public class Slot : ISlot, IEquipedItems
    {
        private List<IEquipedItems> equipedItemsList = new List<IEquipedItems>();

        private bool isItemEquiped(IEquipedItems item)
        {
            if (this.equipedItemsList.IndexOf(item) != -1)
            {
                return true;
            }
            return false;
        }
        public void Equip(IEquipedItems item)
        {
            if (this.isItemEquiped(item))
            {
                this.equipedItemsList.Remove(item);
            }
            this.equipedItemsList.Add(item);
        }

        public void UnEquip(IEquipedItems item)
        {
            this.equipedItemsList.Remove(item);
        }

        public List<IEquipedItems> EquipedItemsList
        {
            get { return this.equipedItemsList; }
        }
    }
}

namespace Lockheed_Inventory.Slots
{
    using System;
    using System.Collections.Generic;
    using Lockheed_Inventory.Slots.Interfaces;

    public enum SlotsEnueration
    {
        Armor, Belt, Boots, Gloves, Helm, Weapon
    }
    public class Slot : ISlot
    {
        private List<SlotsEnueration> equipedItemsList = new List<SlotsEnueration>();

        private bool isItemEquiped(SlotsEnueration item)
        {
            if (this.equipedItemsList.IndexOf(item) != -1)
            {
                return true;
            }
            return false;
        }
        public void Equip(SlotsEnueration item)
        {
            if (this.isItemEquiped(item))
            {
                this.equipedItemsList.Remove(item);
            }
            this.equipedItemsList.Add(item);
        }

        public void UnEquip(SlotsEnueration item)
        {
            this.equipedItemsList.Remove(item);
        }

        public List<SlotsEnueration> EquipedItemsList
        {
            get { return this.equipedItemsList; }
        }
    }
}

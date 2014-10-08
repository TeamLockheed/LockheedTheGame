namespace Lockheed_Inventory
{
    using System;
    using System.Collections.Generic;
    using Slots.Interfaces;
    public class Helm : Slot, IArmor
    {
        private List<Item> armorList;
        public Helm() :
            base()
        {
            
        }

        public override void Equip(Item item)
        {
            this.armorList.Add(item);
            this.FreeSlot = false;
        }
        public override void UnEquip(Item item)
        {
            this.armorList.Remove(item);
            this.FreeSlot = true;
        }
        public List<Item> ArmorList
        {
            get { return this.armorList; }
            set { this.armorList = value; }
        }

        public override bool FreeSlot
        {
            get { return this.freeSlot; }
            set { this.freeSlot = value; }
        }
    }
}

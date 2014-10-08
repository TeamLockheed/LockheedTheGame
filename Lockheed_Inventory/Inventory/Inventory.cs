using System;
using System.Collections.Generic;
using Lockheed_Inventory.Inventory.Interfaces;

namespace Lockheed_Inventory.Inventory
{
    public abstract class Inventory : ITakeable, IRemovable
    {
        protected Inventory(List<Item> itemList)
        {
            this.ItemList = itemList;
        }

        protected readonly int inventoryLimit = 40;
        private List<Item> itemList;
        private int currentInventoryState;

        public void TakeItem(Item item)
        {
            if (CurrentInventoryState < inventoryLimit)
            {
                this.itemList.Add(item);
                this.CurrentInventoryState -= 1;
            }
        }

        public void DropItem(Item item)
        {
            if (CurrentInventoryState > 0)
            {
                this.itemList.Remove(item);
                this.CurrentInventoryState += 1;
            }
        }

        public List<Item> ItemList
        {
            get { return this.itemList; }
            set { this.itemList = value; }
        }

        public int CurrentInventoryState
        {
            get { return this.currentInventoryState; }
            set { this.currentInventoryState = value; }
        }
    }
}

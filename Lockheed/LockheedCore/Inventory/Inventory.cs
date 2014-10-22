namespace LockHeedCore
{
   
    using System;
    using System.Collections.Generic;

    public class Inventory : ITakeable, IRemovable
    {
        protected Inventory(int inventoryLimit = 40)
        {
            this.ItemList = new List<Item>(inventoryLimit);
            this.InventoryLimit = inventoryLimit;
        }

        protected readonly int InventoryLimit;
        private List<Item> itemList;

        public void TakeItem(Item item)
        {
            if (InventoryItemsCount < InventoryLimit)
            {
                this.ItemList.Add(item);
            }
        }

        public void DropItem(Item item)
        {
            if (InventoryItemsCount > 0)
            {
                this.ItemList.Remove(item);
            }
        }

        public List<Item> ItemList
        {
            get { return this.itemList; }
            private set { this.itemList = value; }
        }

        public int InventoryItemsCount
        {
            get { return this.itemList.Count; }
        }
    }
}

using System;
using System.Collections.Generic;

namespace DZ7
{

    class Item
    {

    }

    /*У класі забагато методів та завеликий функціонал.
     Порушений принцип єдиного обов'язку. Для вирішення цієї проблеми 
     розподілимо методи за окремими класами. */
    class Order
    {
        private List<Item> itemList;
        internal List<Item> ItemList
        {
            get
            {
                return itemList;
            }
            set
            {
                itemList = value;
            }
        }
        //public void CalculateTotalSum() {/*...*/}
        public void GetItems() {/*...*/}
        public void GetItemCount() {/*...*/}
        //public void AddItem(Item item) {/*...*/}
        //public void DeleteItem(Item item) {/*...*/}
        //public void PrintOrder() {/*...*/}
        //public void ShowOrder() {/*...*/}
        //public void Load() {/*...*/}
        //public void Save() {/*...*/}
        //public void Update() {/*...*/}
        //public void Delete() {/*...*/}
    }

    class OrderManager
    {
        private Order order;
        public OrderManager(Order o)
        {
            order = o;
        }

        public void AddItem(Item item) {/*...*/}
        public void DeleteItem(Item item) {/*...*/}
        public void Load() {/*...*/}
        public void Save() {/*...*/}
        public void Update() {/*...*/}
        public void Delete() {/*...*/}
    }
    
    class OrderPrinter
    {
        private Order order;
        public OrderPrinter(Order o)
        {
            order = o;
        }

        public void PrintOrder() {/*...*/}
        public void ShowOrder() {/*...*/}
    }

    class OrderCalculator
    {
        private Order order;
        public OrderCalculator(Order o)
        {
            order = o;
        }

        public void CalculateTotalSum() {/*...*/}
    }

    class Task1
    {
        static void Main(string[] args)
        {

        }
    }
}

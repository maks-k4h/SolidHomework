using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1S
{
    //Який принцип S.O.L.I.D. порушено? Виправте!
    // SRP — витягнув методи з класу Order в інші
    // OCP — перше, а також створив клас StandardOrder, який втілює фінансову логіку
    // LSP --
    // ISP --
    // DIP — Item перетворив на інтерфейс
    interface IItem
    {
        
    }
    class Order
    {
        private List<IItem> itemList;

        internal List<IItem> ItemList
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

        public void GetItems() {/*...*/}
        public void GetItemCount() {/*...*/}
        public void AddItem(IItem item) {/*...*/}
        public void DeleteItem(IItem item) {/*...*/}
    }

    class StandardOrder : Order
    {
        public void CalculateTotalSum() {/*...*/}
    }

    class OrderPrinter
    {
        public void PrintOrder(Order o) {/*...*/}

    }

    class OrderDisplay
    {
        public void ShowOrder(Order o) {/*...*/} 
    }

    class OrderManager
    {
        public void Load() {/*...*/}
        public void Save() {/*...*/}
        public void Update() {/*...*/}
        public void Delete() {/*...*/}
    }
}
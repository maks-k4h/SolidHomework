using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1
{
    //Який принцип S.O.L.I.D. порушено? Виправте!
    // порушено SRP — очевидно
    // порушено OCP — у звʼязку з першим, а також, як на мене, через присутність фінансової логіки
    // LSP не порушено — деталі не відомі, успадкування відсутні
    // ISP не порушено — інтерфейси відсутні
    // порушено DIP — Item варто перетворити на інтерфейс та працювати з цим інтерфейсом
    class Item
    {

    }
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

        public void CalculateTotalSum() {/*...*/}
        public void GetItems() {/*...*/}
        public void GetItemCount() {/*...*/}
        public void AddItem(Item item) {/*...*/}
        public void DeleteItem(Item item) {/*...*/}

        public void PrintOrder() {/*...*/}
        public void ShowOrder() {/*...*/}

        public void Load() {/*...*/}
        public void Save() {/*...*/}
        public void Update() {/*...*/}
        public void Delete() {/*...*/}
    }

    class Program
    {
        static void Main()
        {
        }
    }
}

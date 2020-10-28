using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication
{
    public class OrderInfoRepositiory
    {
        ObservableCollection<OrderInfo> orderCollection;
        public ObservableCollection<OrderInfo> OrderInfoCollection
        {
            get { return orderCollection; }
            set { orderCollection = value; }
        }

        public OrderInfoRepositiory()
        {

            orderCollection = this.GenerateOrders();
            // orderCollection1 = GenerateOrders1();

        }

        private ObservableCollection<OrderInfo> GenerateOrders()
        {
            ObservableCollection<OrderInfo> orders = new ObservableCollection<OrderInfo>();

            for (int i = 0; i < 300; i++)
            {
                orders.Add(new OrderInfo() { Status = false, OrderID = 1001, CustomerName = "Maria Anders", Country = "Germany", CustomerID = "ALFKI", ShipCity = "Berlin" });
                orders.Add(new OrderInfo() { Status = true, OrderID = 1002, CustomerName = "Ana Trujilo", Country = "Mexico", CustomerID = "ANATR", ShipCity = "Mexico" });
                orders.Add(new OrderInfo() { Status = true, OrderID = 1003, CustomerName = "Antonio Moreno", Country = "Mexico", CustomerID = "ANTON", ShipCity = "Mexico" });
                orders.Add(new OrderInfo() { Status = false, OrderID = 1004, CustomerName = "Thomas Hardy", Country = "UK", CustomerID = "AROUT", ShipCity = "London" });
                orders.Add(new OrderInfo() { Status = true, OrderID = 1005, CustomerName = "Christina Berglund", Country = "Swedan", CustomerID = "BERGS", ShipCity = "Lulea" });
                orders.Add(new OrderInfo() { Status = true, OrderID = 1006, CustomerName = "Hanna Moos", Country = "Germany", CustomerID = "BLAUS", ShipCity = "Mannheim" });
                orders.Add(new OrderInfo() { Status = true, OrderID = 1007, CustomerName = "Frédérique Citeaux", Country = "France", CustomerID = "BLONP", ShipCity = "Strasbourg" });
                orders.Add(new OrderInfo() { Status = false, OrderID = 1008, CustomerName = "Martin Sommer", Country = "Spain", CustomerID = "BOLID", ShipCity = "Madrid" });
                orders.Add(new OrderInfo() { Status = true, OrderID = 1009, CustomerName = "Laurence Lebihan", Country = "France", CustomerID = "BONAP", ShipCity = "Marseille" });
                orders.Add(new OrderInfo() { Status = false, OrderID = 1010, CustomerName = "Elizabeth Lincoln", Country = "Canada", CustomerID = "BOTTM", ShipCity = "Tsawassen" });
            }
            return orders;

        }


    }

}

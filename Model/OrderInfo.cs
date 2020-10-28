using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication
{
    public class OrderInfo
    {
        int orderID;
        string customerId;
        string country;
        string customerName;
        string shippingCity;
        bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }

        public string CustomerID
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string ShipCity
        {
            get { return shippingCity; }
            set { shippingCity = value; }
        }

    }

}

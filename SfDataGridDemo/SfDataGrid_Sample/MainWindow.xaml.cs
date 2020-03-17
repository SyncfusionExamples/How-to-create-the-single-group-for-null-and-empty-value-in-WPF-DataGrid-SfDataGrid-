using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System.ComponentModel;
using System.Data;

namespace SfDataGrid_Sample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.GroupColumnDescriptions.Add(new GroupColumnDescription() { Converter = new GroupStringNullConverter(), ColumnName = "CustomerName" });
            dataGrid.GroupColumnDescriptions.CollectionChanged += GroupColumnDescriptions_CollectionChanged;
        }

        void GroupColumnDescriptions_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                var group = e.NewItems[0] as GroupColumnDescription;
                if (group.ColumnName == "CustomerName")
                    group.Converter = new GroupStringNullConverter();
            }
        }
   }

    public class OrderInfo : INotifyPropertyChanged
    {
        int orderID;
        string customerId;
        string country;
        string customerName;
        string shippingCity;
        bool isShipped;

        public OrderInfo()
        {

        }

        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; this.OnPropertyChanged("OrderID"); }
        }

        public string CustomerID
        {
            get { return customerId; }
            set { customerId = value; this.OnPropertyChanged("CustomerID"); }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; this.OnPropertyChanged("CustomerName"); }
        }

        public string Country
        {
            get { return country; }
            set { country = value; this.OnPropertyChanged("Country"); }
        }

        public string ShipCity
        {
            get { return shippingCity; }
            set { shippingCity = value; this.OnPropertyChanged("ShipCity"); }
        }

        public bool IsShipped
        {
            get { return isShipped; }
            set { isShipped = value; this.OnPropertyChanged("IsShipped"); }
        }


        public OrderInfo(int orderId, string customerName, string country, string customerId, string shipCity, bool isShipped)
        {
            this.OrderID = orderId;
            this.CustomerName = customerName;
            this.Country = country;
            this.CustomerID = customerId;
            this.ShipCity = shipCity;
            this.IsShipped = isShipped;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class ViewModel
    {
        private ObservableCollection<OrderInfo> orders;
        public ObservableCollection<OrderInfo> Orders
        {
            get { return orders; }
            set { orders = value; }
        }

        public ViewModel()
        {
            orders = new ObservableCollection<OrderInfo>();
            orders.Add(new OrderInfo(1001, null, "Germany", "ALFKI", "Berlin", true));
            orders.Add(new OrderInfo(1002, string.Empty, "Mexico", "ANATR", "Mexico D.F.", false));
            orders.Add(new OrderInfo(1003, "Antonio Moreno", "Mexico", "ANTON", "Mexico D.F.", true));
            orders.Add(new OrderInfo(1004, "Thomas Hardy", "UK", "AROUT", "London", true));
            orders.Add(new OrderInfo(1005, "Christina Berglund", "Sweden", "BERGS", "Lula", false));
            orders.Add(new OrderInfo(1006, "Hanna Moos", "Germany", "BLAUS", "Mannheim", true));
            orders.Add(new OrderInfo(1007, "Frederique Citeaux", "France", "BLONP", "Strasbourg", true));
            orders.Add(new OrderInfo(1008, "Martin Sommer", "Spain", "BOLID", "Madrid", true));
            orders.Add(new OrderInfo(1009, "Laurence Lebihan", "France", "BONAP", "Marseille", false));
            orders.Add(new OrderInfo(1010, "Elizabeth Lincoln", "Canada", "BOTTM", "Tsawassen", true));
            orders.Add(new OrderInfo(1011, null, "Germany", "ALFKI", "Berlin", true));
            orders.Add(new OrderInfo(1012, string.Empty, "Mexico", "ANATR", "Mexico D.F.", false));
            orders.Add(new OrderInfo(1013, "Antonio Moreno", "Mexico", "ANTON", "Mexico D.F.", true));
            orders.Add(new OrderInfo(1014, "Thomas Hardy", "UK", "AROUT", "London", true));
            orders.Add(new OrderInfo(1015, "Christina Berglund", "Sweden", "BERGS", "Lula", false));
            orders.Add(new OrderInfo(1016, "Hanna Moos", "Germany", "BLAUS", "Mannheim", true));
            orders.Add(new OrderInfo(1017, "Frederique Citeaux", "France", "BLONP", "Strasbourg", true));
            orders.Add(new OrderInfo(1018, "Martin Sommer", "Spain", "BOLID", "Madrid", true));
            orders.Add(new OrderInfo(1019, "Laurence Lebihan", "France", "BONAP", "Marseille", false));
            orders.Add(new OrderInfo(1020, "Elizabeth Lincoln", "Canada", "BOTTM", "Tsawassen", true));
            orders.Add(new OrderInfo(1021, null, "Germany", "ALFKI", "Berlin", true));
            orders.Add(new OrderInfo(1022, string.Empty, "Mexico", "ANATR", "Mexico D.F.", false));
            orders.Add(new OrderInfo(1023, "Antonio Moreno", "Mexico", "ANTON", "Mexico D.F.", true));
            orders.Add(new OrderInfo(1024, "Thomas Hardy", "UK", "AROUT", "London", true));
            orders.Add(new OrderInfo(1025, "Christina Berglund", "Sweden", "BERGS", "Lula", false));
            orders.Add(new OrderInfo(1026, "Hanna Moos", "Germany", "BLAUS", "Mannheim", true));
            orders.Add(new OrderInfo(1027, "Frederique Citeaux", "France", "BLONP", "Strasbourg", true));
            orders.Add(new OrderInfo(1028, "Martin Sommer", "Spain", "BOLID", "Madrid", true));
            orders.Add(new OrderInfo(1029, "Laurence Lebihan", "France", "BONAP", "Marseille", false));
            orders.Add(new OrderInfo(1030, "Elizabeth Lincoln", "Canada", "BOTTM", "Tsawassen", true));
        }

    }

}

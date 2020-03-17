using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SfDataGrid_Sample
{
    public class GroupStringNullConverter: IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, CultureInfo culture)
        {
            var customerName = value as OrderInfo;

            if (string.IsNullOrEmpty(customerName.CustomerName))
                return null;
            else
                return customerName.CustomerName;
        }

        public object ConvertBack(object value, System.Type targetType, object parameter, CultureInfo culture)
        {
            throw new System.NotImplementedException();
        }
    }
}

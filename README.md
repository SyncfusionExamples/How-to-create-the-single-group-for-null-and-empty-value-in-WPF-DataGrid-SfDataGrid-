# How to create the single group for null and empty value in WPF DataGrid SfDataGrid

## About the sample

This example illustrates how to create the single group for null and empty value in [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid).

An empty and null values are created the separate groups in [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid). You can able to create the single group for empty and null value by using [Converter](https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfGrid.WPF~Syncfusion.UI.Xaml.Grid.GroupColumnDescription~ConverterProperty.html) in [GroupColumnDescription](https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfGrid.WPF~Syncfusion.UI.Xaml.Grid.GroupColumnDescription.html).

```C#
dataGrid.GroupColumnDescriptions.Add(new GroupColumnDescription() { Converter = new GroupStringNullConverter(), ColumnName = "CustomerName" });


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

```

KB article - [How to create the single group for null and empty value in WPF DataGrid SfDataGrid](https://www.syncfusion.com/kb/11224/how-to-create-the-single-group-for-null-and-empty-value-in-wpf-datagrid-sfdatagrid)

## Requirements to run the demo
Visual Studio 2015 and above versions

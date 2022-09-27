using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListBoxP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StringFormatter sf = new StringFormatter();
        public MainWindow()
        {
            InitializeComponent();

            List<CItem> items = new List<CItem>();
            items.Add(new CItem() { TagColor = Color.FromRgb(30, 21, 52), ItemID = "013512091613104217", ItemDepartmentName = "Miscellaneous", SubDepartmentName = "Short Sleev Shirt", SizeName = "Medium", CouponID = "CPN1209161252", DiscountDescription = "50% OFF Magenta", ItemCoupon = -9999.99M, ItemDiscount = -9999.99M, TaxRate = 100.00M, ItemExt = 9999.99M, ItemTax = -9999.99M, ItemTotal = 9999.99M });
            items.Add(new CItem() { TagColor = Color.FromRgb(3, 2, 5), ItemID = "013512091613104217", ItemDepartmentName = "Miscellaneous", SubDepartmentName = "Short Sleev Shirt", SizeName = "Medium", CouponID = "CPN1209161252", DiscountDescription = "50% OFF Magenta", ItemCoupon = -9999.99M, ItemDiscount = -9999.99M, TaxRate = 100.00M, ItemExt = 9999.99M, ItemTax = -9999.99M, ItemTotal = 9999.99M });
            items.Add(new CItem() { TagColor = Color.FromRgb(3, 2, 5), ItemID = "013512091613104217", ItemDepartmentName = "Miscellaneous", SubDepartmentName = "Short Sleev Shirt", SizeName = "Medium", CouponID = "CPN1209161252", DiscountDescription = "50% OFF Magenta", ItemCoupon = -9999.99M, ItemDiscount = -9999.99M, TaxRate = 100.00M, ItemExt = 9999.99M, ItemTax = -9999.99M, ItemTotal = 9999.99M });

            listBoxData.ItemsSource = items;
        }


    }

    public class CItem
    {
        public Color TagColor { get; set; }
        public String ItemID { get; set; }
        public String ItemDepartmentName { get; set; }
        public String SubDepartmentName { get; set; }
        public String SizeName { get; set; }
        public String CouponID { get; set; }
        public String DiscountDescription { get; set; }
        public decimal ItemCoupon { get; set; }
        public decimal ItemDiscount { get; set; }
        public decimal TaxRate { get; set; }
        public decimal ItemTax { get; set; }
        public decimal ItemExt { get; set; }
        public decimal ItemTotal { get; set; }
    }

    public class StringFormatter : IMultiValueConverter
    {

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return string.Format((string)values[1], values[0]);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

using BKP.View;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace BKP
{
    /// <summary>
    /// Логика взаимодействия для FullReserve.xaml
    /// </summary>
    public partial class FullReserve : Window
    {
        public FullReserve()
        {
            InitializeComponent();
            GetGoodsInfo();
            DataContext = this;
        }

        public void GetGoodsInfo()
        {
            List<Goods> good_info = new List<Goods>
            {
                new Goods(1, "Складной нож Minimus\nДжинсовая Микарта", "N.C. Custom", "NCC287/1", 1),
                new Goods(2, "Складной нож Cicada\nЦикада", "N.C. Custom", "NCC106", 1),
                new Goods(3, "Складной нож Ultras-F\nStonewash, Tan", "N.C. Custom", "NCC200-SW/TN", 1)
            };

            Goods.ItemsSource = good_info;
        }
    }
}

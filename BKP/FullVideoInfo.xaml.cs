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
    public partial class FullVideoInfo : Window
    {
        public FullVideoInfo()
        {
            InitializeComponent();
            GetEmployeeInfo();
            GetGoodsInVideo();
            DataContext = this;
        }

        public void GetEmployeeInfo()
        {
            List<EmployeeInVideo> employee_data = new List<EmployeeInVideo>
            {
                new EmployeeInVideo(1, "Алиев Игорь", "Младший SMM-менеджер"),
                new EmployeeInVideo(2, "Сбоев Артур", "Оператор-монтажер"),
                new EmployeeInVideo(3, "Петров Алексей", "Ведущий")
            };

            Employee_info.ItemsSource = employee_data;
        }

        public void GetGoodsInVideo()
        {
            List<Goods> good_data = new List<Goods>
            {
                new Goods(1, "Складной нож Minimus\nДжинсовая Микарта", "N.C. Custom", 1),
                new Goods(2, "Складной нож Ultras-F\nStonewash, Tan", "N.C. Custom", 1),
                new Goods(3, "Автоматический фронтальный выкидной\nнож Rover Bl", "Mr. Blade", 1),
                new Goods(4, "Складной нож Bugout Benchmade \nCarbon M4", "Benchmade", 1),
                new Goods(5, "Складной нож Counter Point XL\nAus-10A", "Pro-Tech", 1),
                new Goods(6, "Складной нож 0308 Coyote", "Zero Tolerance", 1),
            };

            Good_info.ItemsSource = good_data;
        }

        private void Employee_info_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Script().Show();
        }
    }

}


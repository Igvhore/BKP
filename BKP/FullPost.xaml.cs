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
    public partial class FullPost : Window
    {
        public FullPost()
        {
            InitializeComponent();
            GetSocial();
            DataContext = this;
        }

        public void GetSocial()
        {
            List<SocialMedia> social_info = new List<SocialMedia>
            {
                new SocialMedia("ВКонтакте")
            };

            Social_info.ItemsSource = social_info;
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

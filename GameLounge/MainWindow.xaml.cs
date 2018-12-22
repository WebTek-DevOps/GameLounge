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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameLounge
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UserControl VISIBLE_UC;
        private List<UserControl> MY_UC;
        public MainWindow()
        {
            InitializeComponent();

            MY_UC = new List<UserControl>
            {
                listview_account,
                listview_client

            };
        }

        private void Btn_client(object sender, RoutedEventArgs e)
        {
            VISIBLE_UC = listview_client;
            Update_ListView();
        }
        private void Btn_account(object sender, RoutedEventArgs e)
        {
            VISIBLE_UC = listview_account;
            Update_ListView();
        }
        private void Update_ListView()
        {
            foreach(UserControl u in MY_UC)
            {
                if (!u.Equals(VISIBLE_UC))
                {
                    u.Visibility = Visibility.Hidden;
                }

            }
            VISIBLE_UC.Visibility = Visibility.Visible;
        }

        
    }
}

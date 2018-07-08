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
using BLL;
using Model;

namespace Software_Engineering
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void _btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = new Employee(int.Parse(_txtUName.Text),"","",_cmType.Text,_txtUPass.Password);
            BLL.BLLClass bll = new BLLClass();
            bool Res = bll.Login(employee);
            if (Res)
            {
                MainWin mw = new MainWin(employee);
                this.Close();
                mw.ShowDialog();
            }
            else
            {
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه است");
            }
        }
    }
}

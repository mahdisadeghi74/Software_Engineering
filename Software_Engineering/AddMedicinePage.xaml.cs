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
using Model;

namespace Software_Engineering
{
    /// <summary>
    /// Interaction logic for AddMedicinePage.xaml
    /// </summary>
    public partial class AddMedicinePage : Window
    {
        private int PersonalID = 0;
        public AddMedicinePage()
        {
            InitializeComponent();
        }

        public AddMedicinePage(int personalID)
        {
            InitializeComponent();
            this.PersonalID = personalID;
        }

        private void _btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Model.Medicine medicine = new Medicine();
            medicine.ID = int.Parse(_txtID.Text);
            medicine.Name = _txtName.Text;
            medicine.Price = float.Parse(_txtPrice.Text);
            medicine.PersonelID = PersonalID;

            BLL.BLLClass bll = new BLL.BLLClass();
            bool Res = bll.AddMedicine(medicine);

            if (Res)
            {
                _txtName.Text = "";
                _txtID.Text = "";
                _txtPrice.Text = "";
            }
            else
            {
                MessageBox.Show("information is Wrang");
            }

        }

        private void _btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

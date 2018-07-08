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
using BLL;
using Model;

namespace Software_Engineering
{
    /// <summary>
    /// Interaction logic for EditMedicineWindows.xaml
    /// </summary>
    public partial class EditMedicineWindows : Window
    {
        private Medicine medicine = new Medicine();
        public EditMedicineWindows()
        {
            InitializeComponent();
        }

        public EditMedicineWindows(Medicine _medicine)
        {
            InitializeComponent();
            this.medicine = _medicine;
            _txtID.Text = medicine.ID.ToString();
            _txtName.Text = medicine.Name;
            _txtPrice.Text = medicine.Price.ToString();
        }

        private void _btnAdd_Click(object sender, RoutedEventArgs e)
        {
            BLL.BLLClass bll = new BLLClass();
            Medicine m = new Medicine();
            m.ID = int.Parse(_txtID.Text);
            m.Name = _txtName.Text;
            m.Price = float.Parse(_txtPrice.Text);
            bool Res = bll.EditMedicine(m);

            if (Res)
                this.Close();
            else
            {
                MessageBox.Show("error");
            }
        }

        private void _btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

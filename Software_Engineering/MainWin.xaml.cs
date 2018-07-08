using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for MainWin.xaml
    /// </summary>
    public partial class MainWin : Window
    {
        private Employee employee = new Employee();
        public MainWin()
        {
            InitializeComponent();
        }

        public MainWin(Employee _employee)
        {
            this.employee = _employee;
            InitializeComponent();
        }

        private void _btnLogin_Click(object sender, RoutedEventArgs e)
        {
            AddMedicinePage AMP = new AddMedicinePage(employee.ID);            
            AMP.ShowDialog();
            _btnShow_Click(null, null);
        }

        private void _btnShow_Click(object sender, RoutedEventArgs e)
        {
            BLL.BLLClass bll = new BLLClass();
            _dtGrid.ItemsSource = null;
            _dtGrid.ItemsSource = bll.ShowMedicine().DefaultView;
        }

        private void _btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView DRV = (DataRowView)_dtGrid.SelectedItem;
                Medicine m =new Medicine();
                m.ID = int.Parse(DRV.Row[0].ToString());
                m.Name = DRV.Row[1].ToString();
                m.Price = float.Parse(DRV.Row[2].ToString());
                m.PersonelID = int.Parse(DRV.Row[3].ToString());
                m.FactoryID = int.Parse(DRV.Row[4].ToString());
                EditMedicineWindows EMW = new EditMedicineWindows(m);
                EMW.ShowDialog();
                _btnShow_Click(null,null);
            }
            catch (Exception)
            {
            }

        }
    }
}

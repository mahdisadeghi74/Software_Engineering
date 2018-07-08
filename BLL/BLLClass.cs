using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BLL
{
    public class BLLClass
    {
        public bool Login(Model.Employee employee)
        {
            bool Res = DAL.DALClass.Login(employee);

            if (Res)
                return true;

            return false;
        }

        public bool AddMedicine(Model.Medicine medicine)
        {
            bool Res = DAL.DALClass.AddMedicine(medicine);
            if (Res)
                return true;

            return false;
        }

        public DataTable ShowMedicine()
        {
            DataTable Res = DAL.DALClass.ShowMedicine();
            return Res;
        }

        public bool EditMedicine(Medicine medicine)
        {
            bool Res = DAL.DALClass.EditMedicine(medicine);
            if (Res)
                return true;

            return false;
        }
    }
}

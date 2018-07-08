using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Task { get; set; }
        public string PassWord { get; set; }

        public Employee()
        {
            
        }

        public Employee(int id, string name, string family, string task, string password)
        {
            this.ID = id;
            this.Name = name;
            this.Family = family;
            this.Task = task;
            this.PassWord = password;
        }
    }
}

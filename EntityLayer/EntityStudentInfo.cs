using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityStudentInfo
    {
        private int _ID;
        private string _USERNAME;
        private string _PASSWORD;

        public int ID { get => _ID; set => _ID = value; }
        public string USERNAME { get => _USERNAME; set => _USERNAME = value; }
        public string PASSWORD { get => _PASSWORD; set => _PASSWORD = value; }
    }
}

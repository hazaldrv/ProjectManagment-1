using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityAcademician
    {
        int _ID;
        string _NAME;
        string _DEPARTMAN;
        string _POSITION;
        string _PHONE;
        string _EMAIL;
        string _OFFICE;
        string _TIMETABLE;

        public int ID { get => _ID; set => _ID = value; }
        public string NAME { get => _NAME; set => _NAME = value; }
        public string DEPARTMAN { get => _DEPARTMAN; set => _DEPARTMAN = value; }
        public string POSITION { get => _POSITION; set => _POSITION = value; }
        public string PHONE { get => _PHONE; set => _PHONE = value; }
        public string EMAIL { get => _EMAIL; set => _EMAIL = value; }
        public string OFFICE { get => _OFFICE; set => _OFFICE = value; }
        public string TIMETABLE { get => _TIMETABLE; set => _TIMETABLE = value; }
    }
}

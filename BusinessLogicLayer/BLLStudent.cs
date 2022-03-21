using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using FacadeLayer;
namespace BusinessLogicLayer
{
    public class BLLStudent
    {
        public static List<EntityAcademician> List()
        {
            return FacadeStudent.List();
        }
    }
}

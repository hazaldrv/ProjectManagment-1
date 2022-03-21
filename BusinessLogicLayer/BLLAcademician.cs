using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using FacadeLayer;

namespace BusinessLogicLayer
{
    public class BLLAcademician
    {
        public static bool Update(EntityAcademician value)
        {
            if (value.NAME != null && value.DEPARTMAN != null && value.POSITION != null && value.PHONE != null
               && value.EMAIL != null && value.OFFICE != null && value.TIMETABLE != null)
            {
                return FacadeAcademician.Update(value);
            }
            return false;
        }

        public static List<EntityAcademician> List()
        {
            return FacadeAcademician.List();
        }
    }
}

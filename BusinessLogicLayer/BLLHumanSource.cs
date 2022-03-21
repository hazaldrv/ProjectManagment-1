using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using FacadeLayer;
namespace BusinessLogicLayer
{
    public class BLLHumanSource
    {
        public static int Add(EntityAcademician value)
        {
            if (value.NAME != null && value.DEPARTMAN != null && value.POSITION != null && value.PHONE != null
                && value.EMAIL != null && value.OFFICE != null && value.TIMETABLE != null)
            {
                return FacadeHumanSource.Add(value);
            }
            return -1;
        }
        public static bool Update(EntityAcademician value)
        {
            if (value.NAME != null && value.DEPARTMAN != null && value.POSITION != null && value.PHONE != null
               && value.EMAIL != null && value.OFFICE != null && value.TIMETABLE != null)
            {
                return FacadeHumanSource.Update(value);
            }
            return false;
        }

        public static bool Delete(int value)
        {
            if (value != null)
            {
                return FacadeHumanSource.Delete(value);
            }
            return false;
        }
        public static List<EntityAcademician> List()
        {
            return FacadeHumanSource.List();
        }
    }
}

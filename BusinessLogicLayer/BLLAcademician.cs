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
            if (true)
            {
                return FacadeAcademician.Update(value);
            }
            
        }

        public static List<EntityAcademician> List()
        {
            return FacadeAcademician.List();
        }
    }
}

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
            if (true)
            {
                return FacadeHumanSource.Add(value);
            }
            
        }
        public static bool Update(EntityAcademician value)
        {
            if (true)
            {
                return FacadeHumanSource.Update(value);
            }
            
        }

        public static bool Delete(int value)
        {            
            
              return FacadeHumanSource.Delete(value);         
        }
        public static List<EntityAcademician> Listele()
        {
            return FacadeHumanSource.List();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
namespace FacadeLayer
{
    public class FacadeStudent
    {
        public static List<EntityAcademician> List()
        {
            List<EntityAcademician> values = new List<EntityAcademician>();

            SqlCommand command = new SqlCommand("ACADEMICIANUPDATE", SqlBaglantisi.baglanti);
            command.CommandType = CommandType.StoredProcedure;

            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }

            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                EntityAcademician ent = new EntityAcademician();
                ent.ID = Convert.ToInt32(dr["ID"]);
                ent.NAME = dr["NAME"].ToString();
                ent.DEPARTMAN = dr["DEPARTMAN"].ToString();
                ent.POSITION = dr["POSITION"].ToString();
                ent.PHONE = dr["PHONE"].ToString();
                ent.EMAIL = dr["EMAİL"].ToString();
                ent.TIMETABLE = dr["TAME_TABLE"].ToString();
                values.Add(ent);
            }
            dr.Close();
            return values;
        }
    }
}

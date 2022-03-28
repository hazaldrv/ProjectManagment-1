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
   public class FacadeAcademician
    {
        public static bool Update(EntityAcademician value)
        {
            SqlCommand command = new SqlCommand("ACADEMICIANUPDATE", SqlBaglantisi.baglanti);
            command.CommandType = CommandType.StoredProcedure;

            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            command.Parameters.AddWithValue("ID", value.ID);
            command.Parameters.AddWithValue("NAME", value.NAME);
            command.Parameters.AddWithValue("DEPARTMAN", value.DEPARTMAN);
            command.Parameters.AddWithValue("POSITION", value.POSITION);
            command.Parameters.AddWithValue("PHONE", value.PHONE);
            command.Parameters.AddWithValue("EMAIL", value.EMAIL);
            command.Parameters.AddWithValue("OFFICE", value.OFFICE);
            command.Parameters.AddWithValue("TİME_TABLE", value.TIMETABLE);
            return command.ExecuteNonQuery() > 0;

        }

        public static List<EntityAcademician> List()
        {
            List<EntityAcademician> values = new List<EntityAcademician>();

            SqlCommand command = new SqlCommand("ACADEMICIANLISTESI", SqlBaglantisi.baglanti);
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

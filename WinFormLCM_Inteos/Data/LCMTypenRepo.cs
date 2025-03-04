using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormLCM_Inteos.Entities;

namespace WinFormLCM_Inteos.Data
{
    public class LCMTypenRepo
    {
        readonly SqlConnection con = ConnectionManager.GetConnection();

        public List<LCMTypDTO> GetAll()
        {
            List<LCMTypDTO> lCMTypen = new List<LCMTypDTO>();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT l.Id, l.TypBeschreibung, l.BemerkungIntern, pe.Bezeichnung AS PruefeinheitName, pm.Pruefmethode AS PruefmethodeName FROM LCMTypen l " +
                                            "LEFT JOIN Pruefeinheiten pe on pe.id = l.PruefeinheitId " +
                                            "LEFT JOIN Pruefmerkmale pm on pm.id = l.PruefmethodeId", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                LCMTypDTO lCMTyp = new LCMTypDTO
                {
                    Id = (int)reader["Id"],
                    TypBeschreibung = reader["TypBeschreibung"].ToString(),
                    BemerkungIntern = reader["BemerkungIntern"].ToString(),
                    PruefeinheitName = reader["PruefeinheitName"].ToString(),
                    PruefmethodeName = reader["PruefmethodeName"].ToString()
                };
                lCMTypen.Add(lCMTyp);
            }
            con.Close();
            return lCMTypen;
        }
 
        public List<LCMTypDTO> Search(string search)
        {
            List<LCMTypDTO> lCMTypen = new List<LCMTypDTO>();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT l.Id, l.TypBeschreibung, l.BemerkungIntern, pe.Bezeichnung AS PruefeinheitName, pm.Pruefmethode AS PruefmethodeName FROM LCMTypen l " +
                                            "LEFT JOIN Pruefeinheiten pe on pe.id = l.PruefeinheitId " +
                                            "LEFT JOIN Pruefmerkmale pm on pm.id = l.PruefmethodeId " +
                                            "WHERE l.TypBeschreibung LIKE @search OR l.BemerkungIntern LIKE @search OR pe.Bezeichnung LIKE @search OR pm.Pruefmethode LIKE @search", con);
            cmd.Parameters.AddWithValue("@search", "%" + search + "%");
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                LCMTypDTO lCMTyp = new LCMTypDTO
                {
                    Id = (int)reader["Id"],
                    TypBeschreibung = reader["TypBeschreibung"].ToString(),
                    BemerkungIntern = reader["BemerkungIntern"].ToString(),
                    PruefeinheitName = reader["PruefeinheitName"].ToString(),
                    PruefmethodeName = reader["PruefmethodeName"].ToString()
                };
                lCMTypen.Add(lCMTyp);
            }
            con.Close();
            return lCMTypen;
        }




        public LCMTyp GetById(int id)
        {
            LCMTyp lCMTyp = new LCMTyp();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM LCMTypen WHERE Id = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lCMTyp.Id = (int)reader["Id"];
                lCMTyp.TypBeschreibung = reader["TypBeschreibung"].ToString();
                lCMTyp.BemerkungIntern = reader["BemerkungIntern"].ToString();
                lCMTyp.PruefeinheitId = reader["PruefeinheitId"] as int?;
                lCMTyp.PruefmethodeId = reader["PruefmethodeId"] as int?;
            }
            con.Close();
            return lCMTyp;
        }

        public void Insert(LCMTyp lcmTyp)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO LCMTypen(TypBeschreibung, BemerkungIntern, PruefeinheitId, PruefmethodeId) VALUES(@typBeschreibung, @bemerkungIntern, @pruefeinheitId, @pruefmethodeId)", con);
            cmd.Parameters.AddWithValue("@typBeschreibung", lcmTyp.TypBeschreibung);
            cmd.Parameters.AddWithValue("@bemerkungIntern", lcmTyp.BemerkungIntern);
            cmd.Parameters.AddWithValue("@pruefeinheitId", lcmTyp.PruefeinheitId);
            cmd.Parameters.AddWithValue("@pruefmethodeId", lcmTyp.PruefmethodeId);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Update(LCMTyp lcmTyp)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE LCMTypen SET TypBeschreibung = @typBeschreibung, BemerkungIntern = @bemerkungIntern, PruefeinheitId = @pruefeinheitId, PruefmethodeId = @pruefmethodeId WHERE Id = @id", con);
            cmd.Parameters.AddWithValue("@typBeschreibung", lcmTyp.TypBeschreibung);
            cmd.Parameters.AddWithValue("@bemerkungIntern", lcmTyp.BemerkungIntern);
            cmd.Parameters.AddWithValue("@pruefeinheitId", lcmTyp.PruefeinheitId);
            cmd.Parameters.AddWithValue("@pruefmethodeId", lcmTyp.PruefmethodeId);
            cmd.Parameters.AddWithValue("@id", lcmTyp.Id);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void Delete(int id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM LCMTypen WHERE Id = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}

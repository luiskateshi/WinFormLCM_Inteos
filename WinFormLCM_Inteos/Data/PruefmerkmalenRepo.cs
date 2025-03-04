using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormLCM_Inteos.Entities;

namespace WinFormLCM_Inteos.Data
{
    public class PruefmerkmalenRepo
    {
        readonly SqlConnection con = ConnectionManager.GetConnection();

        public List<Pruefmerkmal> GetAll()
        {
            List<Pruefmerkmal> pruefmerkmale = new List<Pruefmerkmal>();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Pruefmerkmale", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Pruefmerkmal pruefmerkmal = new Pruefmerkmal
                {
                    Id = (int)reader["Id"],
                    Pruefmethode = reader["Pruefmethode"].ToString(),
                    Verknuepfung = reader["Verknuepfung"].ToString(),
                    Anweisungen = reader["Anweisungen"].ToString()
                };
                pruefmerkmale.Add(pruefmerkmal);
            }
            con.Close();
            return pruefmerkmale;
        }
        public List<Pruefmerkmal> Search(string search)
        {
            List<Pruefmerkmal> pruefmerkmale = new List<Pruefmerkmal>();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Pruefmerkmale WHERE Pruefmethode LIKE @search OR Verknuepfung LIKE @search OR Anweisungen LIKE @search", con);
            cmd.Parameters.AddWithValue("@search", "%" + search + "%");
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Pruefmerkmal pruefmerkmal = new Pruefmerkmal
                {
                    Id = (int)reader["Id"],
                    Pruefmethode = reader["Pruefmethode"].ToString(),
                    Verknuepfung = reader["Verknuepfung"].ToString(),
                    Anweisungen = reader["Anweisungen"].ToString()
                };
                pruefmerkmale.Add(pruefmerkmal);
            }
            con.Close();
            return pruefmerkmale;
        }
        public Pruefmerkmal GetById(int id)
        {
            Pruefmerkmal pruefmerkmal = new Pruefmerkmal();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Pruefmerkmale WHERE Id = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                pruefmerkmal.Id = (int)reader["Id"];
                pruefmerkmal.Pruefmethode = reader["Pruefmethode"].ToString();
                pruefmerkmal.Verknuepfung = reader["Verknuepfung"].ToString();
                pruefmerkmal.Anweisungen = reader["Anweisungen"].ToString();
            }
            con.Close();
            return pruefmerkmal;
        }

        public void Insert(Pruefmerkmal pruefmerkmal)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Pruefmerkmale(Pruefmethode, Verknuepfung, Anweisungen) VALUES(@pruefmethode, @Verknuepfung, @Anweisungen)", con);
            cmd.Parameters.AddWithValue("@pruefmethode", pruefmerkmal.Pruefmethode);
            cmd.Parameters.AddWithValue("@Verknuepfung", pruefmerkmal.Verknuepfung);
            cmd.Parameters.AddWithValue("@Anweisungen", pruefmerkmal.Anweisungen);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Update(Pruefmerkmal pruefmerkmal)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Pruefmerkmale SET Pruefmethode = @pruefmethode, Verknuepfung = @Verknuepfung, Anweisungen = @Anweisungen WHERE Id = @id", con);
            cmd.Parameters.AddWithValue("@pruefmethode", pruefmerkmal.Pruefmethode);
            cmd.Parameters.AddWithValue("@Verknuepfung", pruefmerkmal.Verknuepfung);
            cmd.Parameters.AddWithValue("@Anweisungen", pruefmerkmal.Anweisungen);
            cmd.Parameters.AddWithValue("@id", pruefmerkmal.Id);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Delete(int id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Pruefmerkmale WHERE Id = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }



    }


}

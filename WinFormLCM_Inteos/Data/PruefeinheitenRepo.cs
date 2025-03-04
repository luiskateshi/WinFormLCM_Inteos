using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormLCM_Inteos.Entities;

namespace WinFormLCM_Inteos.Data
{
    public class PruefeinheitenRepo
    {
        readonly SqlConnection con = ConnectionManager.GetConnection();
        
        public List<Pruefeinheit> GetAll()
        {
            List<Pruefeinheit> pruefeinheiten = new List<Pruefeinheit>();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Pruefeinheiten", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Pruefeinheit pruefeinheit = new Pruefeinheit
                {
                    Id = (int)reader["Id"],
                    Bezeichnung = reader["Bezeichnung"].ToString(),
                    Symbol = reader["Symbol"].ToString()
                };
                pruefeinheiten.Add(pruefeinheit);
            }
            con.Close();
            return pruefeinheiten;
        }
        public List<Pruefeinheit> Search(string search)
        {
            List<Pruefeinheit> pruefeinheiten = new List<Pruefeinheit>();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Pruefeinheiten WHERE Bezeichnung LIKE @search OR Symbol LIKE @search", con);
            cmd.Parameters.AddWithValue("@search", "%" + search + "%");
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Pruefeinheit pruefeinheit = new Pruefeinheit
                {
                    Id = (int)reader["Id"],
                    Bezeichnung = reader["Bezeichnung"].ToString(),
                    Symbol = reader["Symbol"].ToString()
                };
                pruefeinheiten.Add(pruefeinheit);
            }
            con.Close();
            return pruefeinheiten;
        }

        public void Insert(Pruefeinheit pruefeinheit)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Pruefeinheiten(Bezeichnung, Symbol) VALUES(@bezeichnung, @symbol)", con);
            cmd.Parameters.AddWithValue("@bezeichnung", pruefeinheit.Bezeichnung);
            cmd.Parameters.AddWithValue("@symbol", pruefeinheit.Symbol);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Update(Pruefeinheit pruefeinheit)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Pruefeinheiten SET Bezeichnung = @bezeichnung, Symbol = @symbol WHERE Id = @id", con);
            cmd.Parameters.AddWithValue("@bezeichnung", pruefeinheit.Bezeichnung);
            cmd.Parameters.AddWithValue("@symbol", pruefeinheit.Symbol);
            cmd.Parameters.AddWithValue("@id", pruefeinheit.Id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Delete(int id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Pruefeinheiten WHERE Id = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}

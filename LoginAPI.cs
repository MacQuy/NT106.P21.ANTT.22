using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NT106
{
    internal class LoginAPI
    {
        static public string Login(string username, string password)
        {
            if (username == "" || password == "") return "*Missing information";
            else
            {
                int count;
                string hashedpw = SHA256Compute.ComputeSha256Hash(password);
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Hashedpw = @password";
                using (SqlConnection conn = new SqlConnection(DatabaseConnection.connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", hashedpw);

                        conn.Open();
                        count = (int)cmd.ExecuteScalar();
                    }
                }
                if (count == 1)
                {
                    return "200";
                }
                else return "*Wrong username or password";
            }
        }

        static public UserData getUserData(string username)
        {
            string query = "SELECT ID, Username, Hashedpw, Img, Win, Draw, Lose FROM Users WHERE Username = @username";
            UserData data = new UserData();
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            data = new UserData
                            {
                                Id = Convert.ToInt32(reader["ID"]),
                                Username = reader["Username"].ToString(),
                                HashedPassword = reader["Hashedpw"].ToString(),
                                Img = reader["Img"] != DBNull.Value ? (byte[])reader["Img"] : null,
                                WinMatch = Convert.ToInt32(reader["Win"]),
                                DrawMatch = Convert.ToInt32(reader["Draw"]),
                                LoseMatch = Convert.ToInt32(reader["Lose"])
                            };
                        }
                    }
                }
            }
            return data;
        }
    }
}

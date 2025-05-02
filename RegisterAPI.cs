using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NT106
{
    internal class RegisterAPI
    {
        static private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        static public string Register(string username, string password, string check, Image img)
        {
            if (username == "" || password == "") return "*Missing information";
            else if (password != check) return "*Confirm password wrong";
            else if (img == null) return "*Choose the avatar";
            else
            {
                string hashedpw = ComputeSha256Hash(password);
                byte[] imageData = null;
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, img.RawFormat);
                    imageData = ms.ToArray();
                }
                string query = @"INSERT INTO Users (Username, Hashedpw, Img, Win, Draw, Lose) VALUES (@username, @password, @img, 0, 0, 0)";
                using (SqlConnection conn = new SqlConnection(DatabaseConnection.connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", hashedpw);
                        cmd.Parameters.AddWithValue("@img", imageData);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                return "200";
            }
        }
    }
}

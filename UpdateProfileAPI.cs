using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NT106
{
    internal class UpdateProfileAPI
    {
        static public void UpdateUsername(UserData userData, string newUsername)
        {
            string query = "UPDATE Users SET Username = @NewUsername WHERE ID = @UserID";
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NewUsername", newUsername);
                    cmd.Parameters.AddWithValue("@UserID", userData.Id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            userData.Username = newUsername;
        }

        static public void UpdatePassword(UserData userData, string newPassword)
        {
            string query = "UPDATE Users SET Hashedpw = @NewPassword WHERE ID = @UserID";
            string hashedpw = SHA256Compute.ComputeSha256Hash(newPassword);
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NewPassword", hashedpw);
                    cmd.Parameters.AddWithValue("@UserID", userData.Id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            userData.HashedPassword = hashedpw;
        }

        static public void UpdateAvatar(UserData userData, Image newAvatar)
        {
            string query = "UPDATE Users SET Img = @NewAvatar WHERE ID = @UserID";
            byte[] data;
            using (MemoryStream ms = new MemoryStream())
            {
                newAvatar.Save(ms, newAvatar.RawFormat);
                data = ms.ToArray();
            }
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NewAvatar", data);
                    cmd.Parameters.AddWithValue("@UserID", userData.Id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            userData.Img = data;
        }
    }
}

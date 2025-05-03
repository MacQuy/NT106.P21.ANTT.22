using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NT106
{
    public class UserData
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string HashedPassword { get; set; }
        public byte[] Img { get; set; }
        public int WinMatch { get; set; }
        public int DrawMatch { get; set; }
        public int LoseMatch { get; set; }
    }
}

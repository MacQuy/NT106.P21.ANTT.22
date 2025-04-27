using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            DisableChessCell();
        }

        private void MicButton_Click(object sender, EventArgs e)
        {
            isOnMic = !isOnMic;

            if (isOnMic)
            {
                MicPic.Image = global::NT106.Properties.Resources.Mic;
            }
            else
            {
                MicPic.Image = global::NT106.Properties.Resources.Mute;
            }
        }
    }
}

﻿using System;
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
    public partial class RoomForm : Form
    {
        private Form previous;
        public RoomForm(Form previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            previous.Show();
        }
    }
}

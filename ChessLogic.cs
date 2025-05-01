using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106
{   
    public enum Chess
    {
        None,
        WhiteKing,
        WhiteQueen,
        WhiteKnight,
        WhiteRook,
        WhiteBishop,
        WhitePawn,
        BlackKing,
        BlackQueen,
        BlackKnight,
        BlackRook,
        BlackBishop,
        BlackPawn
    }

    public class ChessCell
    {
        public Chess chess {  get; set; }
        public bool dot { get; set; }
        public bool capture { get; set; }
        public ChessCell(Chess chess, bool dot, bool capture)
        {
            this.chess = chess;
            this.dot = dot;
            this.capture = capture;
        }
    }
    
    public class ChessLogic
    {
        private List<List<ChessCell>> matrix;
        private Form form;
        public ChessLogic(Form form)
        {
            this.form = form;

            matrix = new List<List<ChessCell>>();

            matrix.Add(new List<ChessCell>
            {
                new ChessCell(Chess.WhiteRook, false, false),
                new ChessCell(Chess.WhiteBishop, false, false),
                new ChessCell(Chess.WhiteKnight, false, false),
                new ChessCell(Chess.WhiteKing, false, false),
                new ChessCell(Chess.WhiteQueen, false, false),
                new ChessCell(Chess.WhiteKnight, false, false),
                new ChessCell(Chess.WhiteBishop, false, false),
                new ChessCell(Chess.WhiteRook, false, false)
            });

            matrix.Add(new List<ChessCell>
            {
                new ChessCell(Chess.WhitePawn, false, false),
                new ChessCell(Chess.WhitePawn, false, false),
                new ChessCell(Chess.WhitePawn, false, false),
                new ChessCell(Chess.WhitePawn, false, false),
                new ChessCell(Chess.WhitePawn, false, false),
                new ChessCell(Chess.WhitePawn, false, false),
                new ChessCell(Chess.WhitePawn, false, false),
                new ChessCell(Chess.WhitePawn, false, false)
            });

            for(int i=0; i<4; ++i)
            {
                matrix.Add(new List<ChessCell>
                {
                    new ChessCell(Chess.None, false, false),
                    new ChessCell(Chess.None, false, false),
                    new ChessCell(Chess.None, false, false),
                    new ChessCell(Chess.None, false, false),
                    new ChessCell(Chess.None, false, false),
                    new ChessCell(Chess.None, false, false),
                    new ChessCell(Chess.None, false, false),
                    new ChessCell(Chess.None, false, false),
                });
            }

            matrix.Add(new List<ChessCell>
            {
                new ChessCell(Chess.BlackPawn, false, false),
                new ChessCell(Chess.BlackPawn, false, false),
                new ChessCell(Chess.BlackPawn, false, false),
                new ChessCell(Chess.BlackPawn, false, false),
                new ChessCell(Chess.BlackPawn, false, false),
                new ChessCell(Chess.BlackPawn, false, false),
                new ChessCell(Chess.BlackPawn, false, false),
                new ChessCell(Chess.BlackPawn, false, false)
            });

            matrix.Add(new List<ChessCell>
            {
                new ChessCell(Chess.BlackRook, false, false),
                new ChessCell(Chess.BlackBishop, false, false),
                new ChessCell(Chess.BlackKnight, false, false),
                new ChessCell(Chess.BlackQueen, false, false),
                new ChessCell(Chess.BlackKing, false, false),
                new ChessCell(Chess.BlackKing, false, false),
                new ChessCell(Chess.BlackBishop, false, false),
                new ChessCell(Chess.BlackRook, false, false)
            });
        }

        private bool isEnemy(int x, int y)
        {
            return matrix[y][x].chess.ToString().Contains("Black");
        }

        private void UpdateUI()
        {
            for(int y=0; y<8; ++y)
            {
                for(int x=0; x<8; ++x)
                {
                    if (matrix[y][x].capture)
                    {
                        int Y = 590 - 75 * y;
                        int X = 600 - 75 * x;

                        Guna2CircleButton circle = new Guna2CircleButton();
                        circle.BorderThickness = 4;
                        circle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(64, 64, 64);
                        circle.DisabledState.FillColor = System.Drawing.Color.Transparent;
                        circle.Location = new System.Drawing.Point(X, Y);
                        circle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
                        circle.Size = new System.Drawing.Size(75, 75);
                        circle.UseTransparentBackground = true;
                        circle.Enabled = false;

                        form.Controls.Add(circle);
                        continue;
                    }
                    
                    if (matrix[y][x].dot)
                    {
                        int Y = 590 - 75 * y;
                        int X = 600 - 75 * x;
                        
                        Guna2CircleButton dot = new Guna2CircleButton();
                        dot.DisabledState.FillColor = System.Drawing.Color.FromArgb(64, 64, 64);
                        dot.Location = new System.Drawing.Point(X + 27, Y + 27);
                        dot.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
                        dot.Size = new System.Drawing.Size(21, 21);
                        dot.UseTransparentBackground = true;
                        dot.Enabled = false;

                        form.Controls.Add(dot);
                        dot.BringToFront();
                    }
                }
            }
        }

        private void ShowMovePawn(int x, int y)
        {
            if (y + 1 < 8 && matrix[y + 1][x].chess == Chess.None)
            {
                matrix[y + 1][x].dot = true;
                if (y == 1 && matrix[y + 2][x].chess == Chess.None)
                {
                    matrix[y + 2][x].dot = true;
                }
            }
            
            if (x - 1 > 0 && isEnemy(x - 1, y + 1))
            {
                matrix[y + 1][x - 1].capture = true;
            }
            if (x + 1 < 8 &&  isEnemy(x + 1, y + 1))
            {
                matrix[y + 1][x + 1].capture = true;
            }

            UpdateUI();
        }

        public void ShowMove(object sender, EventArgs e)
        {
            if(sender is Guna2PictureBox chess)
            {
                Point point = chess.Location;
                int y = (590 - point.Y) / 75;
                int x = (600 - point.X) / 75;

                ChessCell now = matrix[y][x];

                if (now.chess == Chess.WhitePawn) ShowMovePawn(x, y);
            }
        }
    }

}

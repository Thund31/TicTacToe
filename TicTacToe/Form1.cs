using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private int TILE_SIZE = 100;
        private String[] tokens = {"X", "O"};

        private bool isXTurn = true, computerOn = false, performed;
        private int numEmpty = 9, roundNum = 0, xScore = 0, oScore = 0;

        private Button[,] tiles = new Button[3,3];

        public Form1()
        {
            InitializeComponent();

            drawTiles();
        }

        private void drawTiles()
        {
            int x = 0, y = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button newBtn = new Button();
                    newBtn.Size = new Size(TILE_SIZE, TILE_SIZE);
                    newBtn.Location = new Point(x, y);
                    newBtn.Text = "";
                    newBtn.FlatStyle = FlatStyle.Flat;
                    newBtn.Font = new Font(FontFamily.GenericSansSerif, 60, FontStyle.Regular);
                    newBtn.Click += btnTile_Click;

                    gbTiles.Controls.Add(newBtn);
                    tiles[i, j] = newBtn;

                    x += TILE_SIZE;
                }
                x = 0;
                y += TILE_SIZE;
            }

            if ((roundNum++) % 2 == 0)
            {
                isXTurn = true;
                lblTurn.Text = "Turn: X";
            }
            else
            {
                isXTurn = false;
                lblTurn.Text = "Turn: O";
            }

            numEmpty = 9;

            computerMove();
        }

        private void btnTile_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text != "") return;

            if (isXTurn)
            {
                btn.Text = tokens[0];
                isXTurn = false;
                lblTurn.Text = "Turn: O";
            }
            else
            {
                btn.Text = tokens[1];
                isXTurn = true;
                lblTurn.Text = "Turn: X";
            }

            if (!checkWin() && --numEmpty == 0) drawGame();

            computerMove();
        }

        private void computerMove()
        {
            if (!computerOn || isXTurn) return;

            //先手
            if (numEmpty == 9)
            {
                tiles[0, 0].PerformClick();
            }
            else if ((numEmpty == 7 || numEmpty == 5) && tiles[1, 1].Text == "")
            {
                if (tiles[2, 0].Text == "")
                {
                    tiles[2, 0].PerformClick();
                }
                else if (tiles[0, 2].Text == "")
                {
                    tiles[0, 2].PerformClick();
                }
                else if (tiles[2, 2].Text == "")
                {
                    tiles[2, 2].PerformClick();
                }
            }
            //后手
            else if (numEmpty == 8 && tiles[1, 1].Text == "")
            {
                tiles[1, 1].PerformClick();
            }
            else
            {
                scanTwo();
            }
            if (!isXTurn)
            {
                for (int i = 0; i < 3 && !performed; i++)
                {
                    for (int j = 0; j < 3 && !performed; j++)
                    {
                        if (tiles[i, j].Text == "")
                        {
                            tiles[i, j].PerformClick();
                            performed = true;
                        }
                    }
                }
            }
        }

        private void scanTwo()
        {
            performed = false;
            for (int i = 0; i < 3 && !performed; i++)
            {
                if (!performed) checkTwo(i, 0, i, 1, i, 2, "x");
                if (!performed) checkTwo(0, i, 1, i, 2, i, "x");
            }
            if (!performed) checkTwo(1, 1, 2, 2, 0, 0, "x");
            if (!performed) checkTwo(0, 2, 1, 1, 2, 0, "x");

            for (int i = 0; i < 3 && !performed; i++)
            {
                if (!performed) checkTwo(i, 0, i, 1, i, 2, "o");
                if (!performed) checkTwo(0, i, 1, i, 2, i, "o");
            }
            if (!performed) checkTwo(1, 1, 2, 2, 0, 0, "o");
            if (!performed) checkTwo(0, 2, 1, 1, 2, 0, "o");
        }

        private void checkTwo(int i1, int j1, int i2, int j2, int i3, int j3, string p)
        {
            if (tiles[i1, j1].Text == p && (tiles[i1, j1].Text == tiles[i2, j2].Text && tiles[i3, j3].Text == ""))
            {
                tiles[i3, j3].PerformClick();
                performed = true;
            }
            if (tiles[i1, j1].Text == p && (tiles[i1, j1].Text == tiles[i3, j3].Text && tiles[i2, j2].Text == ""))
            {
                tiles[i2, j2].PerformClick();
                performed = true;
            }
            if (tiles[i2, j2].Text == p && (tiles[i3, j3].Text == tiles[i2, j2].Text && tiles[i1, j1].Text == ""))
            {
                tiles[i1, j1].PerformClick();
                performed = true;
            }
        }

        private bool checkWin()
        {
            String token = tokens[1];
            if (isXTurn) token = tokens[0];

            bool win = false;

            // horizontal
            for (int i = 0; i < 3; i++)
            {
                if (tiles[i, 0].Text.Equals(token) && tiles[i, 1].Text.Equals(token) && tiles[i, 2].Text.Equals(token)) win = true;
            }

            // vertical
            for (int j = 0; j < 3; j++)
            {
                if (tiles[0, j].Text.Equals(token) && tiles[1, j].Text.Equals(token) && tiles[2, j].Text.Equals(token)) win = true;
            }

            // diagonal
            if (tiles[0, 0].Text.Equals(token) && tiles[1, 1].Text.Equals(token) && tiles[2, 2].Text.Equals(token)) win = true;
            if (tiles[0, 2].Text.Equals(token) && tiles[1, 1].Text.Equals(token) && tiles[2, 0].Text.Equals(token)) win = true;

            if (win)
            {
                winGame();
                return true;
            }
            return false;
        }

        private void winGame()
        {
            if (!isXTurn)
            {
                lblResult.Text = "O WIN";
                oScore++;
            }
            else
            {
                lblResult.Text = "X WIN";
                xScore++;
            }

            lblScore.Text = "X " + xScore.ToString("D2") + ":" + oScore.ToString("D2") + " O";

            timerPause1Sec.Enabled = true;
        }

        private void drawGame()
        {
            timerPause1Sec.Enabled = true;
            lblResult.Text = "DRAW";
        }

        private void timerPause1Sec_Tick(object sender, EventArgs e)
        {
            roundNum++;
            timerPause1Sec.Enabled = false;
            gbTiles.Controls.Clear();
            gbTiles.Visible = false;
            lblResult.Visible = true;
            timerDrawTiles.Enabled = true;
        }

        private void btnComputer_Click(object sender, EventArgs e)
        {
            if (computerOn)
            {
                computerOn = false;
                btnComputer.BackColor = Color.Red;
                computerMove();
            } else
            {
                computerOn = true;
                btnComputer.BackColor = Color.LimeGreen;
            }
        }

        private void timerDrawTiles_Tick(object sender, EventArgs e)
        {
            lblResult.Visible = false;
            gbTiles.Visible = true;
            timerDrawTiles.Enabled = false;
            drawTiles();
        }
    }
}
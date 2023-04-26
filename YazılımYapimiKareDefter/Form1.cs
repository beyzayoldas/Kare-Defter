using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımYapimiKareDefter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Size = 5, Score = 0;

        private void btnStart_Click(object sender, EventArgs e)
        {
            Score = 0; 

          
            if (radioFive.Checked)
                Size = 5;
            else if (radioSix.Checked)
                Size = 6;
            else if (radioSeven.Checked)
                Size = 7;
            else if (radioEight.Checked)
                Size = 8;
            else if (radioNine.Checked)
                Size = 9;

            
            GameBoard.Enabled = true;
            GameBoard.Rows.Clear();
            GameBoard.Columns.Clear();
            GameBoard.Size = new Size(Size * 51, Size * 51);

            for (int i = 0; i < Size; i++)
            {
                GameBoard.Columns.Add(null, null);
                GameBoard.Rows.Add();
                DataGridViewColumn column = GameBoard.Columns[i]; 
                DataGridViewRow row = GameBoard.Rows[i]; 

                
                row.Height = 50;
                column.Width = 50;
            }

           
            grpPossibleMoves.Visible = true;
            grpResult.Visible = true;
        }

    private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GameBoard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OyunTahtasi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int PositionX = GameBoard.CurrentCell.RowIndex;
            int PositionY = GameBoard.CurrentCell.ColumnIndex;


            if (GameBoard.Rows[PositionX].Cells[PositionY].Style.BackColor == Color.Lavender || Score == 0)
            {
                for (int i = 0; i < Size; i++)
                {
                    for (int j = 0; j < Size; j++)
                    {
                        if (GameBoard.Rows[i].Cells[j].Style.BackColor != Color.MediumPurple)
                            GameBoard.Rows[i].Cells[j].Style.BackColor = Color.WhiteSmoke;
                    }
                }

                Score++;
                GameBoard.Rows[GameBoard.CurrentCell.RowIndex].Cells[GameBoard.CurrentCell.ColumnIndex].Value = Score;
                GameBoard.Rows[GameBoard.CurrentCell.RowIndex].Cells[GameBoard.CurrentCell.ColumnIndex].Style.BackColor = Color.MediumPurple;


                int PossibleMoveCounter = 0; 


               
                if (PositionX + 2 < Size && PositionY + 1 < Size && GameBoard.Rows[PositionX + 2].Cells[PositionY + 1].Style.BackColor != Color.MediumPurple) 
                {
                    GameBoard.Rows[PositionX + 2].Cells[PositionY + 1].Style.BackColor = Color.Lavender;
                    PossibleMoveCounter++;
                }

                if (PositionX + 2 < Size && PositionY - 1 >= 0 && GameBoard.Rows[PositionX + 2].Cells[PositionY - 1].Style.BackColor != Color.MediumPurple) 
                {
                    GameBoard.Rows[PositionX + 2].Cells[PositionY - 1].Style.BackColor = Color.Lavender;
                    PossibleMoveCounter++;
                }

                if (PositionX - 2 >= 0 && PositionY + 1 < Size && GameBoard.Rows[PositionX - 2].Cells[PositionY + 1].Style.BackColor != Color.MediumPurple)  
                {
                    GameBoard.Rows[PositionX - 2].Cells[PositionY + 1].Style.BackColor = Color.Lavender;
                    PossibleMoveCounter++;
                }
                if (PositionX - 2 >= 0 && PositionY - 1 >= 0 && GameBoard.Rows[PositionX - 2].Cells[PositionY - 1].Style.BackColor != Color.MediumPurple) 
                {
                    GameBoard.Rows[PositionX - 2].Cells[PositionY - 1].Style.BackColor = Color.Lavender;
                    PossibleMoveCounter++;
                }
                if (PositionX + 1 < Size && PositionY + 2 < Size && GameBoard.Rows[PositionX + 1].Cells[PositionY + 2].Style.BackColor != Color.MediumPurple) 
                {
                    GameBoard.Rows[PositionX + 1].Cells[PositionY + 2].Style.BackColor = Color.Lavender;
                    PossibleMoveCounter++;
                }
                if (PositionX + 1 < Size && PositionY - 2 >= 0 && GameBoard.Rows[PositionX + 1].Cells[PositionY - 2].Style.BackColor != Color.MediumPurple) 
                {
                    GameBoard.Rows[PositionX + 1].Cells[PositionY - 2].Style.BackColor = Color.Lavender;
                    PossibleMoveCounter++;
                }
                if (PositionX - 1 >= 0 && PositionY + 2 < Size && GameBoard.Rows[PositionX - 1].Cells[PositionY + 2].Style.BackColor != Color.MediumPurple) 
                {
                    GameBoard.Rows[PositionX - 1].Cells[PositionY + 2].Style.BackColor = Color.Lavender;
                    PossibleMoveCounter++;
                }

                if (PositionX - 1 >= 0 && PositionY - 2 >= 0 && GameBoard.Rows[PositionX - 1].Cells[PositionY - 2].Style.BackColor != Color.MediumPurple) 
                {
                    GameBoard.Rows[PositionX - 1].Cells[PositionY - 2].Style.BackColor = Color.Lavender;
                    PossibleMoveCounter++;
                }


                if (PossibleMoveCounter != 0) 
                {
                    lblMoveCounter.Text = "Seçenek Sayısı: " + PossibleMoveCounter ; 
                    lblGameResult.Text = "Oyun devam ediyor.";
                }

                else 
                {
                    lblGameResult.ForeColor = Color.White; 
                    lblMoveCounter.ForeColor = Color.White;
                    for (int i = 0; i < Size; i++)
                    {
                        for (int j = 0; j < Size; j++)
                            GameBoard.Rows[i].Cells[j].Style.BackColor = Color.White;
                    }
                    lblMoveCounter.Text = "Hamle Yok!";
                    lblGameResult.Text = "Tekrar Deneyin!"; 
                }

                if (Score == Size * Size) 
                {
                    for (int i = 0; i < Size; i++)
                    {
                        for (int j = 0; j < Size; j++)
                            GameBoard.Rows[i].Cells[j].Style.BackColor = Color.Green; 
                    }
                    lblMoveCounter.Text = "";
                    lblGameResult.ForeColor = Color.Green;
                    lblGameResult.Text = "Bütün kareleri tamamlayıp kazandınız!"; 
                }
            }
            if (GameBoard.Rows[PositionX].Cells[PositionX].Style.BackColor == Color.Yellow)
            {
                GameBoard.Rows[PositionX].Cells[PositionY].Value = Score;
                GameBoard.Rows[PositionX].Cells[PositionY].Style.BackColor = Color.GreenYellow;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace XOGame
{
    public partial class frmMain : Form
    {
        private bool TwoPlayers;
        private int choise;
        private int round;
        private bool win;
        private int player1Scores;
        private int player2Scores;
        private int[] point;
        private int playerTurn;




        public frmMain()
        {           
            InitializeComponent();           
        }

        private void BtClick(Button btn,int ButtonNumber)
        {
            if (btn.Text == "" && win == false)
            {
                btn.Text = Action(choise, ButtonNumber-1);
                if (btn.Text == "X")
                    btn.ForeColor = Color.Red;
                else
                    btn.ForeColor = Color.Blue;

                if (choise == 0)
                    choise++;
                else
                    choise--;

                win = CheckPoints(ButtonNumber - 1);
                CheckWin();
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {            
            BtClick(btn1, 1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            BtClick(btn2, 2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            BtClick(btn3, 3);
        }      

        private void btn4_Click(object sender, EventArgs e)
        {
            BtClick(btn4, 4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            BtClick(btn5, 5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            BtClick(btn6, 6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            BtClick(btn7, 7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            BtClick(btn8, 8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            BtClick(btn9, 9); 
        }
     

        private string Action(int Choice, int X)
        {
            point[X] = Choice;
            if (Choice == 0)
                return "X";
            else
                return "O";
        }

        private void mnu1Player_Click(object sender, EventArgs e)
        {
            mnu1Player.Checked = true;
            mnu2Player.Checked = false;
            TwoPlayers = false;
            txbPlayer2Name.Text = "Computer";
            txbPlayer2Name.ReadOnly = true;
        }

        private void mnu2Player_Click(object sender, EventArgs e)
        {
            mnu2Player.Checked = true;
            mnu1Player.Checked = false;
            TwoPlayers = true;
            txbPlayer2Name.Text = "";
            txbPlayer2Name.ReadOnly = false;
        }

        private bool CheckPoints(int X)
        {
            int sum1, sum2, sum3, sum4;
            bool result = false;
            switch (X)
            {
                case 0:
                    {
                        sum1 = point[X] + point[1] + point[2];
                        sum2 = point[X] + point[3] + point[6];
                        sum3 = point[X] + point[4] + point[8];
                        if (sum1 == 0 || sum1 == 3)
                        {
                            result = true;
                            btn1.BackColor = Color.Yellow;
                            btn2.BackColor = Color.Yellow;
                            btn3.BackColor = Color.Yellow;
                        }
                        if (sum2 == 0 || sum2 == 3)
                        {
                            result = true;
                            btn1.BackColor = Color.Yellow;
                            btn4.BackColor = Color.Yellow;
                            btn7.BackColor = Color.Yellow;
                        }
                        if (sum3 == 0 || sum3 == 3)
                        {
                            result = true;
                            btn1.BackColor = Color.Yellow;
                            btn5.BackColor = Color.Yellow;
                            btn9.BackColor = Color.Yellow;
                        }
                        break;
                    }
                case 1:
                    {
                        sum1 = point[X] + point[0] + point[2];
                        sum2 = point[X] + point[4] + point[7];
                        if (sum1 == 0 || sum1 == 3)
                        {
                            result = true;
                            btn2.BackColor = Color.Yellow;
                            btn1.BackColor = Color.Yellow;
                            btn3.BackColor = Color.Yellow;
                        }
                        if (sum2 == 0 || sum2 == 3)
                        {
                            result = true;
                            btn2.BackColor = Color.Yellow;
                            btn5.BackColor = Color.Yellow;
                            btn8.BackColor = Color.Yellow;
                        }
                        break;
                    }
                case 2:
                    {
                        sum1 = point[X] + point[1] + point[0];
                        sum2 = point[X] + point[5] + point[8];
                        sum3 = point[X] + point[4] + point[6];
                        if (sum1 == 0 || sum1 == 3)
                        {
                            result = true;
                            btn3.BackColor = Color.Yellow;
                            btn2.BackColor = Color.Yellow;
                            btn1.BackColor = Color.Yellow;
                        }
                        if (sum2 == 0 || sum2 == 3)
                        {
                            result = true;
                            btn3.BackColor = Color.Yellow;
                            btn6.BackColor = Color.Yellow;
                            btn9.BackColor = Color.Yellow;
                        }
                        if (sum3 == 0 || sum3 == 3)
                        {
                            result = true;
                            btn3.BackColor = Color.Yellow;
                            btn5.BackColor = Color.Yellow;
                            btn7.BackColor = Color.Yellow;
                        }
                        break;
                    }
                case 3:
                    {
                        sum1 = point[X] + point[0] + point[6];
                        sum2 = point[X] + point[5] + point[4];

                        if (sum1 == 0 || sum1 == 3)
                        {
                            result = true;
                            btn4.BackColor = Color.Yellow;
                            btn1.BackColor = Color.Yellow;
                            btn7.BackColor = Color.Yellow;
                        }
                        if (sum2 == 0 || sum2 == 3)
                        {
                            result = true;
                            btn4.BackColor = Color.Yellow;
                            btn6.BackColor = Color.Yellow;
                            btn5.BackColor = Color.Yellow;
                        }
                        break;
                    }
                case 4:
                    {
                        sum1 = point[X] + point[3] + point[5];
                        sum2 = point[X] + point[1] + point[7];
                        sum3 = point[X] + point[0] + point[8];
                        sum4 = point[X] + point[2] + point[6];

                        if (sum1 == 0 || sum1 == 3)
                        {
                            result = true;
                            btn5.BackColor = Color.Yellow;
                            btn4.BackColor = Color.Yellow;
                            btn6.BackColor = Color.Yellow;
                        }
                        if (sum2 == 0 || sum2 == 3)
                        {
                            result = true;
                            btn5.BackColor = Color.Yellow;
                            btn2.BackColor = Color.Yellow;
                            btn8.BackColor = Color.Yellow;
                        }
                        if (sum3 == 0 || sum3 == 3)
                        {
                            result = true;
                            btn5.BackColor = Color.Yellow;
                            btn1.BackColor = Color.Yellow;
                            btn9.BackColor = Color.Yellow;
                        }
                        if (sum4 == 0 || sum4 == 3)
                        {
                            result = true;
                            btn5.BackColor = Color.Yellow;
                            btn3.BackColor = Color.Yellow;
                            btn7.BackColor = Color.Yellow;
                        }
                        break;
                    }
                case 5:
                    {
                        sum1 = point[X] + point[2] + point[8];
                        sum2 = point[X] + point[3] + point[4];

                        if (sum1 == 0 || sum1 == 3)
                        {
                            result = true;
                            btn6.BackColor = Color.Yellow;
                            btn3.BackColor = Color.Yellow;
                            btn9.BackColor = Color.Yellow;
                        }
                        if (sum2 == 0 || sum2 == 3)
                        {
                            result = true;
                            btn6.BackColor = Color.Yellow;
                            btn4.BackColor = Color.Yellow;
                            btn5.BackColor = Color.Yellow;
                        }
                        break;
                    }
                case 6:
                    {
                        sum1 = point[X] + point[3] + point[0];
                        sum2 = point[X] + point[7] + point[8];
                        sum3 = point[X] + point[4] + point[2];
                        if (sum1 == 0 || sum1 == 3)
                        {
                            result = true;
                            btn7.BackColor = Color.Yellow;
                            btn4.BackColor = Color.Yellow;
                            btn1.BackColor = Color.Yellow;
                        }
                        if (sum2 == 0 || sum2 == 3)
                        {
                            result = true;
                            btn7.BackColor = Color.Yellow;
                            btn8.BackColor = Color.Yellow;
                            btn9.BackColor = Color.Yellow;
                        }
                        if (sum3 == 0 || sum3 == 3)
                        {
                            result = true;
                            btn7.BackColor = Color.Yellow;
                            btn5.BackColor = Color.Yellow;
                            btn3.BackColor = Color.Yellow;
                        }
                        break;
                    }
                case 7:
                    {
                        sum1 = point[X] + point[6] + point[8];
                        sum2 = point[X] + point[1] + point[4];

                         if (sum1 == 0 || sum1 == 3)
                        {
                            result = true;
                            btn8.BackColor = Color.Yellow;
                            btn7.BackColor = Color.Yellow;
                            btn9.BackColor = Color.Yellow;
                        }
                        if (sum2 == 0 || sum2 == 3)
                        {
                            result = true;
                            btn8.BackColor = Color.Yellow;
                            btn2.BackColor = Color.Yellow;
                            btn5.BackColor = Color.Yellow;
                        }
                   
                        break;
                    }
                case 8:
                    {
                        sum1 = point[X] + point[6] + point[7];
                        sum2 = point[X] + point[2] + point[5];
                        sum3 = point[X] + point[4] + point[0];
                        if (sum1 == 0 || sum1 == 3)
                        {
                            result = true;
                            btn9.BackColor = Color.Yellow;
                            btn7.BackColor = Color.Yellow;
                            btn8.BackColor = Color.Yellow;
                        }
                        if (sum2 == 0 || sum2 == 3)
                        {
                            result = true;
                            btn9.BackColor = Color.Yellow;
                            btn3.BackColor = Color.Yellow;
                            btn6.BackColor = Color.Yellow;
                        }
                        if (sum3 == 0 || sum3 == 3)
                        {
                            result = true;
                            btn9.BackColor = Color.Yellow;
                            btn5.BackColor = Color.Yellow;
                            btn1.BackColor = Color.Yellow;
                        }
                        break;
                    }

            }


            return result;
        }
       
        private void CheckWin()
        {
           
            if (win == true)
            {
                btnNewTurn.Enabled = true;
               
                if (playerTurn == 1)
                {
                    playerTurn = 2;
                    player1Scores = player1Scores + 1;
                    lblS1.Text = player1Scores.ToString();
                    lblP1Turn.Text = txbPlayer1Name.Text.Trim() + " won this turn.";
                   
                }
                else
                {
                    playerTurn = 1;
                    player2Scores = player2Scores + 1;
                    lblS2.Text = player2Scores.ToString();
                    lblP2Turn.Text = txbPlayer2Name.Text.Trim() + " won this turn.";
                }
                
            }
            else
            {
                if (playerTurn == 1)
                {
                    playerTurn = 2;
                    lblP2Turn.Text = txbPlayer2Name.Text.Trim() + "'s Turn.";
                    lblP1Turn.Text = "";
                    if (TwoPlayers == false)
                    {
                        if (CheckAllButton() == true)
                            ComputerAction();
                    }
                }
                else
                {
                    playerTurn = 1;
                    lblP1Turn.Text = txbPlayer1Name.Text.Trim() + "'s Turn.";
                    lblP2Turn.Text = "";
                }

                
                if (CheckAllButton() == false)
                {
                    btnNewTurn.Enabled = true;                    
                }
                
            }
        }

        private bool CheckAllButton()
        {
            if ((btn1.Text != "") && (btn2.Text != "") && (btn3.Text != "") && (btn4.Text != "") && (btn5.Text != "") && (btn6.Text != "") && (btn7.Text != "") && (btn8.Text != "") && (btn9.Text != ""))
                 return false;
            else
                return true;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            

            if (txbPlayer1Name.Text == "" || txbPlayer2Name.Text == "")
            {
                MessageBox.Show("Players name are empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                btnNewGame.Enabled = false;
                btnStop.Enabled = true;
                txbPlayer1Name.ReadOnly = true;
                txbPlayer2Name.ReadOnly = true;
                GameReset();
            }
        }

        private void GameReset()
        {
            panel1.Enabled = true;
            if (mnu2Player.Checked == true)
                TwoPlayers = true;
            else
                TwoPlayers = false;

            choise = 0;
            round = 1;
            win = false;
            player1Scores = 0;
            player2Scores = 0;          


            lblS1.Text = "0";
            lblS2.Text = "0";

            playerTurn = 1;
            point = new int[9] { 9, 9, 9, 9, 9, 9, 9, 9, 9 };

            

            lblRound.Visible = true;
            lblRoundNum.Text = round.ToString();
            lblP1Turn.Text = txbPlayer1Name.Text.Trim() + "'s Turn.";            
            lblP2Turn.Text = "";
            lblP1Sign.Text = "X";
            lblP1Sign.ForeColor = Color.Red;
            lblP2Sign.Text = "O";
            lblP2Sign.ForeColor = Color.Blue;

            ResetButton();

          

        }

        private void ResetButton()
        {
            btn1.BackColor = Color.White;
            btn2.BackColor = Color.White;
            btn3.BackColor = Color.White;
            btn4.BackColor = Color.White;
            btn5.BackColor = Color.White;
            btn6.BackColor = Color.White;
            btn7.BackColor = Color.White;
            btn8.BackColor = Color.White;
            btn9.BackColor = Color.White;

            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";            

        }

        private void NewTurn()
        {
            point = new int[9] { 9, 9, 9, 9, 9, 9, 9, 9, 9 };
            round = round + 1;
            win = false;
            ResetButton();  

            lblRoundNum.Text = round.ToString();

            choise = 0;

            if (playerTurn == 1)
            {

                lblP1Turn.Text = txbPlayer1Name.Text.Trim() + "'s Turn.";
                lblP2Turn.Text = "";
                lblP1Sign.Text = "X";
                lblP1Sign.ForeColor = Color.Red;
                lblP2Sign.Text = "O";
                lblP2Sign.ForeColor = Color.Blue;


            }
            else
            {
                lblP2Turn.Text = txbPlayer2Name.Text.Trim() + "'s Turn.";
                lblP1Turn.Text = "";
                lblP2Sign.Text = "X";
                lblP2Sign.ForeColor = Color.Red;
                lblP1Sign.Text = "O";
                lblP1Sign.ForeColor = Color.Blue;
                if (TwoPlayers == false)
                    ComputerAction();
             
            }

                 

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewTurn_Click(object sender, EventArgs e)
        {
            btnNewTurn.Enabled = false;
            NewTurn();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ResetButton();
            
            panel1.Enabled = false;
            btnStop.Enabled = false;
            btnNewGame.Enabled = true;
            txbPlayer1Name.ReadOnly = false;
            if (TwoPlayers == false)
                txbPlayer2Name.ReadOnly = false;
            lblP1Turn.Text = "";
            lblP2Turn.Text = "";

        }
      
        private void ComputerAction()
        {         

            ComputerPlayer cp = new ComputerPlayer(point,choise);
            int btnNumber = cp.SelectButton();

            switch(btnNumber)
            {
                case 1:
                    BtClick(btn1, 1);
                    break;
                case 2:
                    BtClick(btn2, 2);
                    break;
                case 3:
                    BtClick(btn3, 3);
                    break;
                case 4:
                    BtClick(btn4, 4);
                    break;
                case 5:
                    BtClick(btn5, 5);
                    break;
                case 6:
                    BtClick(btn6, 6);
                    break;
                case 7:
                    BtClick(btn7, 7);
                    break;
                case 8:
                    BtClick(btn8, 8);
                    break;
                case 9:
                    BtClick(btn9, 9);
                    break;

            }
           
           
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            frmAbout frmab = new frmAbout();
            frmab.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            mnu1Player.Checked = true;
            mnu2Player.Checked = false;
            TwoPlayers = false;
            txbPlayer2Name.Text = "Computer";
            txbPlayer2Name.ReadOnly = true;

        }
       
    }
}

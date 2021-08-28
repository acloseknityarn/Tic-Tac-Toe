using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace wf_TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // The InitializeComponent() call is required for Windows Forms designer support.
            lblDisplayTurn.Text = "Player X"; //Initialize game with Turn = Player X
        }

        //sql database connections
        SqlConnection con = new SqlConnection(@"Server=(LocalDB)\MSSQLLocalDB;Database=TicTacToe;Trusted_Connection=true");

        bool turn = true; //true = Player X turn, false = Player O turn
        int count_turn = 0;
        int playerX_score, playerO_score = 0; //store players scores

        private void Form1_Load(object sender, EventArgs e)
        {
            updateScore();
        }
        //Database SQL functions
        private void getScoreDetails() //get the table data & display to DisplayGrid
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM match_details", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;
        }
        private void updateScore() //update the table data & display to DisplayGrid
        {
            SqlCommand cmd = new SqlCommand("UPDATE match_details SET PlayerScoreX = @PlayerScoreX, PlayerScoreO = @PlayerScoreO", con);
            cmd.Parameters.AddWithValue("@PlayerScoreX", playerX_score);
            cmd.Parameters.AddWithValue("@PlayerScoreO", playerO_score);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            getScoreDetails();
        }

        private void btnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender; //all buttons click event functionality is similar
            if (turn)
            {
                btn.Text = "X";
            }
            else
            {
                btn.Text = "O"; 
            }

            turn = !turn; //flip the player's turn, EVENT = button pressed
            btn.Enabled = false; //disable the button, So to not overide values - by the rules of Tic Tac Toe
            count_turn++;

            displayTurn();
            checkWinner();
        }
        //Win function algorithm
        private void checkWinner()
        {
            bool win = false; //win bool condition for one of the players win

            //horizontal winner checks
            if ((X1.Text == X2.Text) && (X2.Text == X3.Text) && (!X1.Enabled))
                win = true;
            else if ((Y1.Text == Y2.Text) && (Y2.Text == Y3.Text) && (!Y1.Enabled))
                win = true;
            else if ((Z1.Text == Z2.Text) && (Z2.Text == Z3.Text) && (!Z1.Enabled))
                win = true;
            //vertical winner checks
            else if ((X1.Text == Y1.Text) && (Y1.Text == Z1.Text) && (!X1.Enabled))
                win = true;
            else if ((X2.Text == Y2.Text) && (Y2.Text == Z2.Text) && (!X2.Enabled))
                win = true;
            else if ((X3.Text == Y3.Text) && (Y3.Text == Z3.Text) && (!X3.Enabled))
                win = true;
            //diagonal winner checks
            else if ((X1.Text == Y2.Text) && (Y2.Text == Z3.Text) && (!X1.Enabled))
                win = true;
            else if ((X3.Text == Y2.Text) && (Y2.Text == Z1.Text) && (!Z1.Enabled))
                win = true;

            //check for the winner,draw and display respective message
            if (win)
            {
                disableButtons();
                if (turn)
                {
                    playerO_score++;
                    updateScore(); //Update the score on the database table
                    MessageBox.Show("O" + " Wins!");
                    lblPlayerO_Score.Text = Convert.ToString(playerO_score);
                }
                else
                {
                    playerX_score++;
                    updateScore(); //Update the score on the database table
                    MessageBox.Show("X" + " Wins!");
                    lblPlayerX_Score.Text = Convert.ToString(playerX_score);
                }
            }
            else
            {
                if(count_turn == 9)
                {
                    MessageBox.Show("Draw!");
                }
            }
        }

        private void disableButtons()
        {
            X1.Enabled = false;
            X2.Enabled = false;
            X3.Enabled = false;
            Y1.Enabled = false;
            Y2.Enabled = false;
            Y3.Enabled = false;
            Z1.Enabled = false;
            Z2.Enabled = false;
            Z3.Enabled = false;
        }
        public void displayTurn()
        {
            if (turn)
            {
                lblDisplayTurn.Text = "Player X";
            }
            else
            {
                lblDisplayTurn.Text = "Player O";
            }
        }

        //NEW GAME button
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            X1.Enabled = true;
            X2.Enabled = true;
            X3.Enabled = true;
            Y1.Enabled = true;
            Y2.Enabled = true;
            Y3.Enabled = true;
            Z1.Enabled = true;
            Z2.Enabled = true;
            Z3.Enabled = true;

            X1.Text = "";
            X2.Text = "";
            X3.Text = "";
            Y1.Text = "";
            Y2.Text = "";
            Y3.Text = "";
            Z1.Text = "";
            Z2.Text = "";
            Z3.Text = "";

            //Player X, always starts New Game
            lblDisplayTurn.Text = "Player X";
            turn = true;
            count_turn = 0;
            //Make the Scores 0, for a New Game
            playerX_score = 0;
            playerO_score = 0;
            lblPlayerX_Score.Text = "0";
            lblPlayerO_Score.Text = "0";
            //Update the score on the database table
            updateScore();
        }
        // RESET button
        private void btnReset_Click(object sender, EventArgs e)
        {
            X1.Enabled = true;
            X2.Enabled = true;
            X3.Enabled = true;
            Y1.Enabled = true;
            Y2.Enabled = true;
            Y3.Enabled = true;
            Z1.Enabled = true;
            Z2.Enabled = true;
            Z3.Enabled = true;

            X1.Text = "";
            X2.Text = "";
            X3.Text = "";
            Y1.Text = "";
            Y2.Text = "";
            Y3.Text = "";
            Z1.Text = "";
            Z2.Text = "";
            Z3.Text = "";

            lblDisplayTurn.Text = "Player X";
            turn = true;
            count_turn = 0;
        }

        /*___________________________________________________________________Menu Button Click events___________________________________________________________________*/
        //New Game Menu button
        private void newGameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Same thing as the in-game New Game button
            btnNewGame_Click(sender, e);
        }
        //Exit Menu button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Help Menu button
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Aryamann Verma", "Tic Tac Toe About");
        }

    }
}

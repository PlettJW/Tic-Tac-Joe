using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TickTackJoe
{
    public partial class Form1 : Form
    {


        bool xTurn = true; //true = xtrun/ false = o turn

        int xwins = 0, owins = 0, ties = 0;
        int numturns = 0;

        private void A1_MouseLeave(object sender, EventArgs e)//when mouse leaves a button delete the preveiw
        {
            Button Boyd = (Button)sender;

            if (Boyd.Enabled)
                Boyd.Text = "";
        }

        private void A1_MouseClick(object sender, MouseEventArgs e)//when mouse clicks on a button
        {
            Button Boyd = (Button)sender;
            if (xTurn)//if x turn place x check win then swap turns.
            {
                Boyd.Text = "X";
                Boyd.Enabled = false;
                checkWin();
                xTurn = false;

            }//dosnt do anything now that the computer is in the game
            else
            {
                Boyd.Text = "O";
                Boyd.Enabled = false;
                checkWin();
                xTurn = true;

            }
            numturns++;//counts how many turns so it can detect ties
        }

        public Form1()//initalizer dont mess with it
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)//quite button in drop down menu
        {
            DialogResult d = MessageBox.Show("Are you sure you want to quit?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);//message box with buttons asks if you want to quite

            //which button was pressed?
            if (d == DialogResult.OK)
                Application.Exit();//quit
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)//if they click info in the menu
        {
            MessageBox.Show("Created by Great Nibbly Programing inc. 2017 ALL rights Reserved");//message box with info
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)//if they click instructions in the menu
        {
            MessageBox.Show("It's tick tack toe, one of the simplist and widespread games ever created, if you dont know how to play you have problems!");//instructions
        }



        private void A1_MouseEnter(object sender, EventArgs e)//when the mouse hovers over a button
        {
            Button Boyd = (Button)sender;

            if (xTurn)//if its xturn it will display an x
            {
                if (Boyd.Enabled)
                    Boyd.Text = "X";
            }
            else//if its o turn it will use this as a trigger to run the computer player then sets it to xturn again
            {
                computer();
                xTurn = true;
                numturns++;
            }
        }



        private void Reset()//the reset function
        {
            A1.Text = "";//reset all button text to nothing again
            A2.Text = "";
            A3.Text = "";
            B1.Text = "";
            B2.Text = "";
            B3.Text = "";
            C1.Text = "";
            C2.Text = "";
            C3.Text = "";

            A1.Enabled = true;//unlocks all buttons
            A2.Enabled = true;
            A3.Enabled = true;
            B1.Enabled = true;
            B2.Enabled = true;
            B3.Enabled = true;
            C1.Enabled = true;
            C2.Enabled = true;
            C3.Enabled = true;

            numturns = 0;//sets number of turns back to none
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)//if they click reset in the menu
        {
            Reset();//calls reset
        }

        private void computer()//the computer calculates finds two in a row of the same team and adds the third, if it cant do that randomly selects a button
        {
            bool placed = false;
            int rng;

            //HORZONTAL
            if (A1.Text == A2.Text && (A1.Text == "O" || A1.Text == "X") && A3.Text == "")
            {
                A3.Text = "O";
                A3.Enabled = false;
            }

            else if (B1.Text == B2.Text && (B1.Text == "O" || B1.Text == "X") && B3.Text == "")
            {
                B3.Text = "O";
                B3.Enabled = false;
            }

            else if (C1.Text == C2.Text && (C1.Text == "O" || C1.Text == "X") && C3.Text == "")
            {
                C3.Text = "O";
                C3.Enabled = false;
            }

            //HORZONTAL
            else if (A1.Text == A3.Text && (A1.Text == "O" || A1.Text == "X") && A2.Text == "")
            {
                A2.Text = "O";
                A2.Enabled = false;
            }

            else if (B1.Text == B3.Text && (B1.Text == "O" || B1.Text == "X") && B2.Text == "")
            {
                B2.Text = "O";
                B2.Enabled = false;
            }

            else if (C1.Text == C3.Text && (C1.Text == "O" || C1.Text == "X") && C2.Text == "")
            {
                C2.Text = "O";
                C2.Enabled = false;
            }

            //HORZONTAL
            else if (A1.Text == A2.Text && (A1.Text == "O" || A1.Text == "X") && A3.Text == "")
            {
                A3.Text = "O";
                A3.Enabled = false;
            }

            else if (B1.Text == B2.Text && (B1.Text == "O" || B1.Text == "X") && B3.Text == "")
            {
                B3.Text = "O";
                B3.Enabled = false;
            }

            else if (C1.Text == C2.Text && (C1.Text == "O" || C1.Text == "X") && C3.Text == "")
            {
                C3.Text = "O";
                C3.Enabled = false;
            }


            //vertically
            else if (A1.Text == B1.Text && (A1.Text == "O" || A1.Text == "X") && C1.Text == "")
            {
                C1.Text = "O";
                C1.Enabled = false;
            }

            else if (A2.Text == B2.Text && (A2.Text == "O" || A2.Text == "X") && C2.Text == "")
            {
                C2.Text = "O";
                C2.Enabled = false;
            }

            else if (A3.Text == B3.Text && (A3.Text == "O" || A3.Text == "X") && C3.Text == "")
            {
                C3.Text = "O";
                C3.Enabled = false;
            }
            //vertically
            else if (A1.Text == C1.Text && (A1.Text == "O" || A1.Text == "X") && B1.Text == "")
            {
                B1.Text = "O";
                B1.Enabled = false;
            }

            else if (A2.Text == C2.Text && (A2.Text == "O" || A2.Text == "X") && B2.Text == "")
            {
                B2.Text = "O";
                B2.Enabled = false;
            }

            else if (A3.Text == C3.Text && (A3.Text == "O" || A3.Text == "X") && B3.Text == "")
            {
                B3.Text = "O";
                B3.Enabled = false;
            }
            //vertically
            else if (C1.Text == B1.Text && (C1.Text == "O" || C1.Text == "X") && A1.Text == "")
            {
                A1.Text = "O";
                A1.Enabled = false;
            }

            else if (C2.Text == B2.Text && (C2.Text == "O" || C2.Text == "X") && A2.Text == "")
            {
                A2.Text = "O";
                A2.Enabled = false;
            }

            else if (C3.Text == B3.Text && (C3.Text == "O" || C3.Text == "X") && A3.Text == "")
            {
                A3.Text = "O";
                A3.Enabled = false;
            }


            //diagonaly
            else if (A1.Text == B2.Text && (A1.Text == "O" || A1.Text == "X") && C3.Text == "")
            {
                C3.Text = "O";
                C3.Enabled = false;
            }

            else if (A3.Text == B2.Text && (A3.Text == "O" || A3.Text == "X") && C1.Text == "")
            {
                C1.Text = "O";
                C1.Enabled = false;
            }

            else if (C1.Text == B2.Text && (C1.Text == "O" || C1.Text == "X") && A3.Text == "")
            {
                A3.Text = "O";
                A3.Enabled = false;
            }

            else if (C3.Text == B2.Text && (C3.Text == "O" || C3.Text == "X") && A1.Text == "")
            {
                A1.Text = "O";
                A1.Enabled = false;
            }

            else if (C1.Text == A3.Text && (C1.Text == "O" || C1.Text == "X") && B2.Text == "")
            {
                B2.Text = "O";
                B2.Enabled = false;
            }

            else if (C3.Text == A1.Text && (C3.Text == "O" || C3.Text == "X") && B2.Text == "")
            {
                B2.Text = "O";
                B2.Enabled = false;
            }

            else
            {
                do
                {
                    Random r = new Random();
                    rng = r.Next(1, 10);

                    if(rng == 1)
                    {
                        if(A1.Text == "")
                        {
                            A1.Text = "O";
                            A1.Enabled = false;
                            placed = true;
                        }
                    }

                    if (rng == 2)
                    {
                        if (A2.Text == "")
                        {
                            A2.Text = "O";
                            A2.Enabled = false;
                            placed = true;
                        }
                    }

                    if (rng == 3)
                    {
                        if (A3.Text == "")
                        {
                            A3.Text = "O";
                            A3.Enabled = false;
                            placed = true;
                        }
                    }

                    if (rng == 4)
                    {
                        if (B1.Text == "")
                        {
                            B2.Text = "O";
                            B2.Enabled = false;
                            placed = true;
                        }
                    }

                    if (rng == 5)
                    {
                        if (B3.Text == "")
                        {
                            B3.Text = "O";
                            B3.Enabled = false;
                            placed = true;
                        }
                    }

                    if (rng == 6)
                    {
                        if (C1.Text == "")
                        {
                            C1.Text = "O";
                            C1.Enabled = false;
                            placed = true;
                        }
                    }

                    if (rng == 7)
                    {
                        if (C2.Text == "")
                        {
                            C2.Text = "O";
                            C2.Enabled = false;
                            placed = true;
                        }
                    }

                    if (rng == 8)
                    {
                        if (C2.Text == "")
                        {
                            C2.Text = "O";
                            C2.Enabled = false;
                            placed = true;
                        }
                    }

                    if (rng == 9)
                    {
                        if (C3.Text == "")
                        {
                            C3.Text = "O";
                            C3.Enabled = false;
                            placed = true;
                        }
                    }





                } while (!placed);
            }

            checkWin();
        }



        private void checkWin()//chickwin
        {
            bool winner = false;//vairible


            //horizontally
            if (A1.Text == A2.Text && A3.Text == A2.Text && A1.Enabled == false)
                winner = true;

            if (B1.Text == B2.Text && B3.Text == B2.Text && B1.Enabled == false)
                winner = true;

            if (C1.Text == C2.Text && C3.Text == C2.Text && C1.Enabled == false)
                winner = true;
            //vertically
            if (A1.Text == B1.Text && C1.Text == B1.Text && B1.Enabled == false)
                winner = true;

            if (A2.Text == B2.Text && C2.Text == B2.Text && B2.Enabled == false)
                winner = true;

            if (A3.Text == B3.Text && C3.Text == B3.Text && B3.Enabled == false)
                winner = true;
            //diagonaly
            if (A1.Text == B2.Text && C3.Text == B2.Text && B2.Enabled == false)
                winner = true;

            if (A3.Text == B2.Text && C1.Text == B2.Text && B2.Enabled == false)
                winner = true;

            if (winner)//if it finds a winner in one of the possiblilities
            {
                if (xTurn)//if its x turn x wins
                {
                    xwins++;
                    MessageBox.Show("X wins!");
                    XwinCounter.Text = xwins.ToString();

                }
                else//otherwise o wins
                {
                    owins++;
                    MessageBox.Show("O wins!");
                    OWinsCounter.Text = owins.ToString();
                }


                DialogResult d = MessageBox.Show("Do you Want to Play Again?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);//do you want to play again yes or no

                //which button was pressed?
                if (d == DialogResult.No)
                    Application.Exit();//quit
                else
                {
                    Reset();//if yes it resets
                }

            }
            else if (numturns == 9)//checking for 9 turns, tie
            {
                ties++;
                DialogResult d = MessageBox.Show("Its a Draw, Do you Want to Play Again?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);//do you want to play again

                //which button was pressed?
                if (d == DialogResult.No)
                    Application.Exit();//quit
                else//if yes it resets
                {
                    Reset();
                }
            }
        }
    }
}

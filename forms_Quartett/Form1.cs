using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using System.Diagnostics;
using System.Web;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace forms_Quartett
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetCardValuesFromExcelFile("D:/Github/Quartett_Projekt/Quartett_Data/Cars.xlsx");
            playerButton[0] = buttonP1;//Die buttons sollen für alle Spieler angezeigt werden
            playerButton[1] = buttonP2;
            playerButton[2] = buttonP3;
            playerButton[3] = buttonP4;

            playerButton[0].BackColor = Color.DarkGray;//Farben der Karten der Spieler bestimmen
            playerButton[1].BackColor = Color.LightGray;
            playerButton[2].BackColor = Color.LightGray;
            playerButton[3].BackColor = Color.LightGray;

            for(int i = 0; i < player.Length; i++)
                player[i] = new Player();

            for(int i = 0; i < 32; i++)
            {
                int randomPlayer = rnd.Next(0, 4);
                if (player[randomPlayer].GetAmountOfActiveCards() < 8) player[randomPlayer].AddCardAsActive(i);
                else i--;
            }

            for (int i = 0; i < player.Length; i++)
                player[i].SetNextCardAsActive();

            SetLabelText();

            for (int i = 0; i < alive.Length; i++) alive[i] = true;
        }

        Playcard[] playcard = new Playcard[32];
        Player[] player = new Player[4];
        Random rnd = new Random();

        Button[] playerButton = new Button[4];

        int category = 0, activePlayer = 0, comPlayer = 0;
        bool[] alive = new bool[4];

        

        private void buttonPS_Click(object sender, EventArgs e)
        {
            category = 1; //PS
            buttonPS.BackColor = Color.DarkGray;
            buttonKmH.BackColor = Color.LightGray;
            buttonMaxSpd.BackColor = Color.LightGray;
            buttonWert.BackColor = Color.LightGray;
            buttonGewicht.BackColor = Color.LightGray;
            buttonBaujahr.BackColor = Color.LightGray;
        }

        private void buttonKmH_Click(object sender, EventArgs e)
        {
            category = 2; //max KmH
            buttonPS.BackColor = Color.LightGray;
            buttonKmH.BackColor = Color.DarkGray;
            buttonMaxSpd.BackColor = Color.LightGray;
            buttonWert.BackColor = Color.LightGray;
            buttonGewicht.BackColor = Color.LightGray;
            buttonBaujahr.BackColor = Color.LightGray;
        }

        private void buttonMaxSpd_Click(object sender, EventArgs e)
        {
            category = 3; //time from 0-100 Km/h
            buttonPS.BackColor = Color.LightGray;
            buttonKmH.BackColor = Color.LightGray;
            buttonMaxSpd.BackColor = Color.DarkGray;
            buttonWert.BackColor = Color.LightGray;
            buttonGewicht.BackColor = Color.LightGray;
            buttonBaujahr.BackColor = Color.LightGray;
        }

        private void buttonWert_Click(object sender, EventArgs e)
        {
            category = 4; //Wert
            buttonPS.BackColor = Color.LightGray;
            buttonKmH.BackColor = Color.LightGray;
            buttonMaxSpd.BackColor = Color.LightGray;
            buttonWert.BackColor = Color.DarkGray;
            buttonGewicht.BackColor = Color.LightGray;
            buttonBaujahr.BackColor = Color.LightGray;
        }

        private void buttonGewicht_Click(object sender, EventArgs e)
        {
            category = 5; //Gewicht
            buttonPS.BackColor = Color.LightGray;
            buttonKmH.BackColor = Color.LightGray;
            buttonMaxSpd.BackColor = Color.LightGray;
            buttonWert.BackColor = Color.LightGray;
            buttonGewicht.BackColor = Color.DarkGray;
            buttonBaujahr.BackColor = Color.LightGray;
        }

        private void buttonBaujahr_Click(object sender, EventArgs e)
        {
            category = 6; //Baujahr
            buttonPS.BackColor = Color.LightGray;
            buttonKmH.BackColor = Color.LightGray;
            buttonMaxSpd.BackColor = Color.LightGray;
            buttonWert.BackColor = Color.LightGray;
            buttonGewicht.BackColor = Color.LightGray;
            buttonBaujahr.BackColor = Color.DarkGray;
        }

        private void buttonP1_Click(object sender, EventArgs e)
        {
            comPlayer = 0; //Spieler 1
            buttonP1.BackColor = Color.DarkGray;
            buttonP2.BackColor = Color.LightGray;
            buttonP3.BackColor = Color.LightGray;
            buttonP4.BackColor = Color.LightGray;
            playerButton[activePlayer].BackColor = Color.WhiteSmoke;
        }

        private void buttonP2_Click(object sender, EventArgs e)
        {
            comPlayer= 1; //Spieler 2
            buttonP1.BackColor = Color.LightGray;
            buttonP2.BackColor = Color.DarkGray;
            buttonP3.BackColor = Color.LightGray;
            buttonP4.BackColor = Color.LightGray;
            playerButton[activePlayer].BackColor = Color.WhiteSmoke;
        }

        private void buttonP3_Click(object sender, EventArgs e)
        {
            comPlayer= 2; //Spieler 3
            buttonP1.BackColor = Color.LightGray;
            buttonP2.BackColor = Color.LightGray;
            buttonP3.BackColor = Color.DarkGray;
            buttonP4.BackColor = Color.LightGray;
            playerButton[activePlayer].BackColor = Color.WhiteSmoke;
        }

        private void buttonP4_Click(object sender, EventArgs e)
        {
            comPlayer= 3; //Spieler 4
            buttonP1.BackColor = Color.LightGray;
            buttonP2.BackColor = Color.LightGray;
            buttonP3.BackColor = Color.LightGray;
            buttonP4.BackColor = Color.DarkGray;
            playerButton[activePlayer].BackColor = Color.WhiteSmoke;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (activePlayer == comPlayer) ErrorSamePlayer(); //Die Karten mit dem jeweiligen ausgewählten Wert die ausgewählt wurden, sollen mit denen der anderen Spieler verglichen werden. 
            // Dannach soll der nächst Spieler der aktive Spieler sein.

            if (alive[activePlayer] == false || alive[comPlayer] == false) ErrorDeadPlayer();
            switch (category)
            {
                case 1:
                    if (playcard[player[activePlayer].currentActiveCard].ps > playcard[player[comPlayer].currentActiveCard].ps && alive[activePlayer] && alive[comPlayer])
                    {
                        buttonStart.BackColor = Color.LightGreen;
                        player[activePlayer].AddCardAsPassive(playcard[player[comPlayer].currentActiveCard].cardIndex);
                        player[activePlayer].AddCardAsPassive(playcard[player[activePlayer].currentActiveCard].cardIndex);
                        player[comPlayer].RemoveCard(playcard[player[comPlayer].currentActiveCard].cardIndex);
                        player[comPlayer].SetNextCardAsActive();
                        player[activePlayer].SetNextCardAsActive();
                        ResetCardsToActive();
                    }
                    else
                    {
                        playerButton[activePlayer].BackColor = Color.LightGray;
                        playerButton[comPlayer].BackColor = Color.DarkGray;
                        buttonStart.BackColor = Color.Red;
                        player[comPlayer].AddCardAsPassive(playcard[player[activePlayer].currentActiveCard].cardIndex);
                        player[comPlayer].AddCardAsPassive(playcard[player[comPlayer].currentActiveCard].cardIndex);
                        player[activePlayer].RemoveCard(playcard[player[activePlayer].currentActiveCard].cardIndex);
                        player[comPlayer].SetNextCardAsActive();
                        player[activePlayer].SetNextCardAsActive();
                        ResetCardsToActive();
                        activePlayer = comPlayer;
                    }
                    break;

                
                case 2:
                    if (playcard[player[activePlayer].currentActiveCard].kmh > playcard[player[comPlayer].currentActiveCard].kmh && alive[activePlayer] && alive[comPlayer])
                    {
                        buttonStart.BackColor = Color.LightGreen;
                        player[activePlayer].AddCardAsPassive(playcard[player[comPlayer].currentActiveCard].cardIndex);
                        player[activePlayer].AddCardAsPassive(playcard[player[activePlayer].currentActiveCard].cardIndex);
                        player[comPlayer].RemoveCard(playcard[player[comPlayer].currentActiveCard].cardIndex);
                        player[comPlayer].SetNextCardAsActive();
                        player[activePlayer].SetNextCardAsActive();
                        ResetCardsToActive();
                    }
                    else
                    {
                        playerButton[activePlayer].BackColor = Color.LightGray;
                        playerButton[comPlayer].BackColor = Color.DarkGray;
                        buttonStart.BackColor = Color.Red;
                        player[comPlayer].AddCardAsPassive(playcard[player[activePlayer].currentActiveCard].cardIndex);
                        player[comPlayer].AddCardAsPassive(playcard[player[comPlayer].currentActiveCard].cardIndex);
                        player[activePlayer].RemoveCard(playcard[player[activePlayer].currentActiveCard].cardIndex);
                        player[comPlayer].SetNextCardAsActive();
                        player[activePlayer].SetNextCardAsActive();
                        ResetCardsToActive();
                        activePlayer = comPlayer;
                    }
                    break;


                case 3:
                    if (playcard[player[activePlayer].currentActiveCard].speed > playcard[player[comPlayer].currentActiveCard].speed && alive[activePlayer] && alive[comPlayer])
                    {
                        buttonStart.BackColor = Color.LightGreen;
                        player[activePlayer].AddCardAsPassive(playcard[player[comPlayer].currentActiveCard].cardIndex);
                        player[activePlayer].AddCardAsPassive(playcard[player[activePlayer].currentActiveCard].cardIndex);
                        player[comPlayer].RemoveCard(playcard[player[comPlayer].currentActiveCard].cardIndex);
                        player[comPlayer].SetNextCardAsActive();
                        player[activePlayer].SetNextCardAsActive();
                        ResetCardsToActive();
                    }
                    else
                    {
                        playerButton[activePlayer].BackColor = Color.LightGray;
                        playerButton[comPlayer].BackColor = Color.DarkGray;
                        buttonStart.BackColor = Color.Red;
                        player[comPlayer].AddCardAsPassive(playcard[player[activePlayer].currentActiveCard].cardIndex);
                        player[comPlayer].AddCardAsPassive(playcard[player[comPlayer].currentActiveCard].cardIndex);
                        player[activePlayer].RemoveCard(playcard[player[activePlayer].currentActiveCard].cardIndex);
                        player[comPlayer].SetNextCardAsActive();
                        player[activePlayer].SetNextCardAsActive();
                        ResetCardsToActive();
                        activePlayer = comPlayer;
                    }
                    break;


                case 4:
                    if (playcard[player[activePlayer].currentActiveCard].value > playcard[player[comPlayer].currentActiveCard].value && alive[activePlayer] && alive[comPlayer])
                    {
                        buttonStart.BackColor = Color.LightGreen;
                        player[activePlayer].AddCardAsPassive(playcard[player[comPlayer].currentActiveCard].cardIndex);
                        player[activePlayer].AddCardAsPassive(playcard[player[activePlayer].currentActiveCard].cardIndex);
                        player[comPlayer].RemoveCard(playcard[player[comPlayer].currentActiveCard].cardIndex);
                        player[comPlayer].SetNextCardAsActive();
                        player[activePlayer].SetNextCardAsActive();
                        ResetCardsToActive();
                    }
                    else
                    {
                        playerButton[activePlayer].BackColor = Color.LightGray;
                        playerButton[comPlayer].BackColor = Color.DarkGray;
                        buttonStart.BackColor = Color.Red;
                        player[comPlayer].AddCardAsPassive(playcard[player[activePlayer].currentActiveCard].cardIndex);
                        player[comPlayer].AddCardAsPassive(playcard[player[comPlayer].currentActiveCard].cardIndex);
                        player[activePlayer].RemoveCard(playcard[player[activePlayer].currentActiveCard].cardIndex);
                        player[comPlayer].SetNextCardAsActive();
                        player[activePlayer].SetNextCardAsActive();
                        ResetCardsToActive();
                        activePlayer = comPlayer;
                    }
                    break;


                case 5:
                    if (playcard[player[activePlayer].currentActiveCard].weight > playcard[player[comPlayer].currentActiveCard].weight && alive[activePlayer] && alive[comPlayer])
                    {
                        buttonStart.BackColor = Color.LightGreen;
                        player[activePlayer].AddCardAsPassive(playcard[player[comPlayer].currentActiveCard].cardIndex);
                        player[activePlayer].AddCardAsPassive(playcard[player[activePlayer].currentActiveCard].cardIndex);
                        player[comPlayer].RemoveCard(playcard[player[comPlayer].currentActiveCard].cardIndex);
                        player[comPlayer].SetNextCardAsActive();
                        player[activePlayer].SetNextCardAsActive();
                        ResetCardsToActive();
                    }
                    else
                    {
                        playerButton[activePlayer].BackColor = Color.LightGray;
                        playerButton[comPlayer].BackColor = Color.DarkGray;
                        buttonStart.BackColor = Color.Red;
                        player[comPlayer].AddCardAsPassive(playcard[player[activePlayer].currentActiveCard].cardIndex);
                        player[comPlayer].AddCardAsPassive(playcard[player[comPlayer].currentActiveCard].cardIndex);
                        player[activePlayer].RemoveCard(playcard[player[activePlayer].currentActiveCard].cardIndex);
                        player[comPlayer].SetNextCardAsActive();
                        player[activePlayer].SetNextCardAsActive();
                        ResetCardsToActive();
                        activePlayer = comPlayer;
                    }
                    break;


                case 6:
                    if (playcard[player[activePlayer].currentActiveCard].baujahr > playcard[player[comPlayer].currentActiveCard].baujahr && alive[activePlayer] && alive[comPlayer])
                    {
                        buttonStart.BackColor = Color.LightGreen;
                        player[activePlayer].AddCardAsPassive(playcard[player[comPlayer].currentActiveCard].cardIndex);
                        player[activePlayer].AddCardAsPassive(playcard[player[activePlayer].currentActiveCard].cardIndex);
                        player[comPlayer].RemoveCard(playcard[player[comPlayer].currentActiveCard].cardIndex);
                        player[comPlayer].SetNextCardAsActive();
                        player[activePlayer].SetNextCardAsActive();
                        ResetCardsToActive();
                    }
                    else
                    {
                        playerButton[activePlayer].BackColor = Color.LightGray;
                        playerButton[comPlayer].BackColor = Color.DarkGray;
                        buttonStart.BackColor = Color.Red;
                        player[comPlayer].AddCardAsPassive(playcard[player[activePlayer].currentActiveCard].cardIndex);
                        player[comPlayer].AddCardAsPassive(playcard[player[comPlayer].currentActiveCard].cardIndex);
                        player[activePlayer].RemoveCard(playcard[player[activePlayer].currentActiveCard].cardIndex);
                        player[comPlayer].SetNextCardAsActive();
                        player[activePlayer].SetNextCardAsActive();
                        ResetCardsToActive();
                        activePlayer = comPlayer;
                    }
                    break;
            }
            SetLabelText();
            KillPlayer();
        }

        void SetCardValuesFromExcelFile(string filePath)
        { // Kartenwerte aus einer Excel Datei festlegen.
            string[] name = new string[32];
            int[] ps = new int[32];
            int[] kmh = new int[32];
            int[] speed = new int[32];
            int[] value = new int[32];
            int[] weight = new int[32];
            int[] baujahr = new int[32];

            FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
            IExcelDataReader excelReader;

            //1. Reading Excel file
            if (Path.GetExtension(filePath).ToUpper() == ".XLS")
            {
                //1.1 Reading from a binary Excel file ('97-2003 format; *.xls)
                excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
            }
            else
            {
                //1.2 Reading from a OpenXml Excel file (2007 format; *.xlsx)
                excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            }

            //2. DataSet - The result of each spreadsheet will be created in the result.Tables
            DataSet result;
            result = excelReader.AsDataSet();

            for (int i = 0; i < ps.Length; i++)
            {
                name[i] = Convert.ToString(result.Tables[0].Rows[i + 1][0]);
                ps[i] = Convert.ToInt32(result.Tables[0].Rows[i + 1][1]);
                kmh[i] = Convert.ToInt32(result.Tables[0].Rows[i + 1][2]);
                speed[i] = Convert.ToInt32(result.Tables[0].Rows[i + 1][3]);
                value[i] = Convert.ToInt32(result.Tables[0].Rows[i + 1][4]);
                weight[i] = Convert.ToInt32(result.Tables[0].Rows[i + 1][5]);
                baujahr[i] = Convert.ToInt32(result.Tables[0].Rows[i + 1][6]);

                playcard[i] = new Playcard(name[i], ps[i], kmh[i], speed[i], value[i], weight[i], baujahr[i], i);
            }
        }


        private void ErrorSamePlayer()
        {   //Wenn man mit sich selbst spielen will, soll ein anderer Spieler für einen ausgewählt werden
            string message = "You cannot play yourself. A random Player will be choosen for you.";
            string caption = "Braindead Player Detected";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            while (activePlayer == comPlayer) comPlayer = rnd.Next(0, 4);
        }

        private void ErrorDeadPlayer()
        {
            string message = "";
            string caption = "";

            if (!alive[activePlayer])
            {
                 message = "You cannot play, when you're dead.";
                 caption = "You're dead.";

                while (!alive[activePlayer]) activePlayer= rnd.Next(0, 4);
            }else if (!alive[comPlayer])
            {
                 message = "You cannot play against a dead enemy.";
                 caption = "Dead Enemy";

                while (!alive[comPlayer]) comPlayer = rnd.Next(0, 4);
            }

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
        }

        private void SetLabelText()
        {
            labelCarName.Text = $"Audi {playcard[player[activePlayer].currentActiveCard].name}";
            labelPS.Text = $"{playcard[player[activePlayer].currentActiveCard].ps} ps";
            labelMaxSpd.Text = $"{playcard[player[activePlayer].currentActiveCard].speed} Sec";
            labelGewicht.Text = $"{playcard[player[activePlayer].currentActiveCard].weight} Kg";
            labelKmH.Text = $"{playcard[player[activePlayer].currentActiveCard].kmh} Km/h";
            labelWert.Text = $"{playcard[player[activePlayer].currentActiveCard].value} €";
            labelBaujahr.Text = $"{playcard[player[activePlayer].currentActiveCard].baujahr}";

            labelActiveHand.Text = player[activePlayer].GetAmountOfActiveCards().ToString();
            labelOffHand.Text = player[activePlayer].GetAmountOfPassiveCards().ToString();

            labelPlayer.Text = $"Player {activePlayer+1}";
        }

        private void ResetCardsToActive()
        {
            if (player[activePlayer].GetAmountOfActiveCards() == 0)
            {
                player[activePlayer].SetAllCardsToActive();
            }

            if (player[comPlayer].GetAmountOfActiveCards() == 0)
            {
                player[comPlayer].SetAllCardsToActive();
            }
        }

        private void KillPlayer()
        {
            if (player[activePlayer].GetAmountOfTotalCards() == 0)
            {
                alive[activePlayer] = false;
            }

            if (player[comPlayer].GetAmountOfTotalCards() == 0)
            {
                alive[comPlayer] = false;
            }

        }
    }
}


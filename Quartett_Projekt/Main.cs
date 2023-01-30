using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quartett_Projekt
{
    public partial class Quartett_Spielfeld : Form
    {
        //Player One
        private Label Player1;
        private ListBox CardP1;
        private ListBox CarddeckPl1;

        //Player Two
        private Label Player2;
        private ListBox CardP2;
        private ListBox CarddeckPl2;

        private Label[] PlayerName = new Label[2];
        private ListBox[] PlayerCard = new ListBox[2];
        private ListBox[] PlayerDeck = new ListBox[2];
        private ComboBox Compare;
        private Label PL1;
        private Label PL2;
        private ListBox Card_deck;
        private ListBox Discard_Pile;
        private ComboBox Comparer;

        public Quartett_Spielfeld()
        {
            InitializeComponent();

            PlayerName[0] = Player1;
            PlayerName[1] = Player2;

            PlayerCard[0] = CardP1;
            PlayerCard[1] = CardP2;

            PlayerDeck[0] = CarddeckPl1;
            PlayerDeck[1] = CarddeckPl2;
        }

        private void Quartett_Spielfeld_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.Compare = new System.Windows.Forms.ComboBox();
            this.PL1 = new System.Windows.Forms.Label();
            this.PL2 = new System.Windows.Forms.Label();
            this.Card_deck = new System.Windows.Forms.ListBox();
            this.Discard_Pile = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Compare
            // 
            this.Compare.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Compare.FormattingEnabled = true;
            this.Compare.Location = new System.Drawing.Point(590, 60);
            this.Compare.Name = "Compare";
            this.Compare.Size = new System.Drawing.Size(230, 24);
            this.Compare.TabIndex = 0;
            this.Compare.SelectedIndexChanged += new System.EventHandler(this.Compare_SelectedIndexChanged);
            // 
            // PL1
            // 
            this.PL1.AutoSize = true;
            this.PL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PL1.Location = new System.Drawing.Point(166, 60);
            this.PL1.Name = "PL1";
            this.PL1.Size = new System.Drawing.Size(111, 32);
            this.PL1.TabIndex = 1;
            this.PL1.Text = "Player1";
            this.PL1.Click += new System.EventHandler(this.PL1_Click);
            // 
            // PL2
            // 
            this.PL2.AutoSize = true;
            this.PL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PL2.Location = new System.Drawing.Point(1173, 60);
            this.PL2.Name = "PL2";
            this.PL2.Size = new System.Drawing.Size(111, 32);
            this.PL2.TabIndex = 2;
            this.PL2.Text = "Player2";
            this.PL2.Click += new System.EventHandler(this.PL2_Click);
            // 
            // Card_deck
            // 
            this.Card_deck.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Card_deck.FormattingEnabled = true;
            this.Card_deck.ItemHeight = 16;
            this.Card_deck.Location = new System.Drawing.Point(513, 164);
            this.Card_deck.Name = "Card_deck";
            this.Card_deck.Size = new System.Drawing.Size(120, 84);
            this.Card_deck.TabIndex = 3;
            this.Card_deck.SelectedIndexChanged += new System.EventHandler(this.Card_deck_SelectedIndexChanged);
            // 
            // Discard_Pile
            // 
            this.Discard_Pile.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Discard_Pile.FormattingEnabled = true;
            this.Discard_Pile.ItemHeight = 16;
            this.Discard_Pile.Location = new System.Drawing.Point(772, 164);
            this.Discard_Pile.Name = "Discard_Pile";
            this.Discard_Pile.Size = new System.Drawing.Size(120, 84);
            this.Discard_Pile.TabIndex = 4;
            this.Discard_Pile.SelectedIndexChanged += new System.EventHandler(this.Discard_Pile_SelectedIndexChanged);
            // 
            // Quartett_Spielfeld
            // 
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1436, 513);
            this.Controls.Add(this.Discard_Pile);
            this.Controls.Add(this.Card_deck);
            this.Controls.Add(this.PL2);
            this.Controls.Add(this.PL1);
            this.Controls.Add(this.Compare);
            this.Name = "Quartett_Spielfeld";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void PL1_Click(object sender, EventArgs e)
        {

        }

        private void Card_deck_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Compare_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Discard_Pile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PL2_Click(object sender, EventArgs e)
        {

        }
    }
}
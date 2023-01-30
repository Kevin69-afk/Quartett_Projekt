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

        private ComboBox Comparer;

        public Quartett_Spielfeld()
        {
            InitializeComponent();
        }

        private void Quartett_Spielfeld_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.CarddeckPl1 = new System.Windows.Forms.ListBox();
            this.CarddeckPl2 = new System.Windows.Forms.ListBox();
            this.Player1 = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.Comparer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CarddeckPl1
            // 
            this.CarddeckPl1.FormattingEnabled = true;
            this.CarddeckPl1.ItemHeight = 16;
            this.CarddeckPl1.Location = new System.Drawing.Point(219, 79);
            this.CarddeckPl1.Name = "CarddeckPl1";
            this.CarddeckPl1.Size = new System.Drawing.Size(120, 84);
            this.CarddeckPl1.TabIndex = 0;
            // 
            // CarddeckPl2
            // 
            this.CarddeckPl2.FormattingEnabled = true;
            this.CarddeckPl2.ItemHeight = 16;
            this.CarddeckPl2.Location = new System.Drawing.Point(889, 79);
            this.CarddeckPl2.Name = "CarddeckPl2";
            this.CarddeckPl2.Size = new System.Drawing.Size(120, 84);
            this.CarddeckPl2.TabIndex = 1;
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1.Location = new System.Drawing.Point(103, 79);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(94, 29);
            this.Player1.TabIndex = 2;
            this.Player1.Text = "Player1";
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2.Location = new System.Drawing.Point(756, 90);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(94, 29);
            this.Player2.TabIndex = 3;
            this.Player2.Text = "Player2";
            // 
            // Comparer
            // 
            this.Comparer.FormattingEnabled = true;
            this.Comparer.Location = new System.Drawing.Point(470, 79);
            this.Comparer.Name = "Comparer";
            this.Comparer.Size = new System.Drawing.Size(121, 24);
            this.Comparer.TabIndex = 4;
            // 
            // Quartett_Spielfeld
            // 
            this.ClientSize = new System.Drawing.Size(1064, 527);
            this.Controls.Add(this.Comparer);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.CarddeckPl2);
            this.Controls.Add(this.CarddeckPl1);
            this.Name = "Quartett_Spielfeld";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
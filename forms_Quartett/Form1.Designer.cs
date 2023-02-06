namespace forms_Quartett
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelPS = new System.Windows.Forms.Label();
            this.labelMaxSpd = new System.Windows.Forms.Label();
            this.labelGewicht = new System.Windows.Forms.Label();
            this.labelWert = new System.Windows.Forms.Label();
            this.labelBaujahr = new System.Windows.Forms.Label();
            this.labelKmH = new System.Windows.Forms.Label();
            this.labelCarName = new System.Windows.Forms.Label();
            this.buttonPS = new System.Windows.Forms.Button();
            this.buttonKmH = new System.Windows.Forms.Button();
            this.buttonMaxSpd = new System.Windows.Forms.Button();
            this.buttonWert = new System.Windows.Forms.Button();
            this.buttonGewicht = new System.Windows.Forms.Button();
            this.buttonBaujahr = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPlayer
            // 
            this.labelPlayer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelPlayer.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer.Location = new System.Drawing.Point(12, 9);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(551, 50);
            this.labelPlayer.TabIndex = 6;
            this.labelPlayer.Text = "Player";
            this.labelPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPS
            // 
            this.labelPS.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelPS.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPS.Location = new System.Drawing.Point(142, 164);
            this.labelPS.Name = "labelPS";
            this.labelPS.Size = new System.Drawing.Size(145, 50);
            this.labelPS.TabIndex = 7;
            this.labelPS.Text = "PS";
            this.labelPS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMaxSpd
            // 
            this.labelMaxSpd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelMaxSpd.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxSpd.Location = new System.Drawing.Point(142, 229);
            this.labelMaxSpd.Name = "labelMaxSpd";
            this.labelMaxSpd.Size = new System.Drawing.Size(145, 50);
            this.labelMaxSpd.TabIndex = 8;
            this.labelMaxSpd.Text = "MaxSpd";
            this.labelMaxSpd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGewicht
            // 
            this.labelGewicht.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelGewicht.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGewicht.Location = new System.Drawing.Point(142, 294);
            this.labelGewicht.Name = "labelGewicht";
            this.labelGewicht.Size = new System.Drawing.Size(145, 50);
            this.labelGewicht.TabIndex = 9;
            this.labelGewicht.Text = "Gewicht";
            this.labelGewicht.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWert
            // 
            this.labelWert.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelWert.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWert.Location = new System.Drawing.Point(293, 229);
            this.labelWert.Name = "labelWert";
            this.labelWert.Size = new System.Drawing.Size(145, 50);
            this.labelWert.TabIndex = 10;
            this.labelWert.Text = "Wert";
            this.labelWert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBaujahr
            // 
            this.labelBaujahr.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelBaujahr.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaujahr.Location = new System.Drawing.Point(293, 294);
            this.labelBaujahr.Name = "labelBaujahr";
            this.labelBaujahr.Size = new System.Drawing.Size(145, 50);
            this.labelBaujahr.TabIndex = 11;
            this.labelBaujahr.Text = "Baujahr";
            this.labelBaujahr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelKmH
            // 
            this.labelKmH.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelKmH.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmH.Location = new System.Drawing.Point(293, 164);
            this.labelKmH.Name = "labelKmH";
            this.labelKmH.Size = new System.Drawing.Size(145, 50);
            this.labelKmH.TabIndex = 12;
            this.labelKmH.Text = "Km/h";
            this.labelKmH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCarName
            // 
            this.labelCarName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelCarName.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarName.Location = new System.Drawing.Point(140, 87);
            this.labelCarName.Name = "labelCarName";
            this.labelCarName.Size = new System.Drawing.Size(296, 50);
            this.labelCarName.TabIndex = 13;
            this.labelCarName.Text = "CarName";
            this.labelCarName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPS
            // 
            this.buttonPS.Location = new System.Drawing.Point(12, 87);
            this.buttonPS.Name = "buttonPS";
            this.buttonPS.Size = new System.Drawing.Size(100, 35);
            this.buttonPS.TabIndex = 14;
            this.buttonPS.Text = "PS";
            this.buttonPS.UseVisualStyleBackColor = true;
            this.buttonPS.Click += new System.EventHandler(this.buttonPS_Click);
            // 
            // buttonKmH
            // 
            this.buttonKmH.Location = new System.Drawing.Point(12, 132);
            this.buttonKmH.Name = "buttonKmH";
            this.buttonKmH.Size = new System.Drawing.Size(100, 35);
            this.buttonKmH.TabIndex = 15;
            this.buttonKmH.Text = "Km/h";
            this.buttonKmH.UseVisualStyleBackColor = true;
            this.buttonKmH.Click += new System.EventHandler(this.buttonKmH_Click);
            // 
            // buttonMaxSpd
            // 
            this.buttonMaxSpd.Location = new System.Drawing.Point(12, 177);
            this.buttonMaxSpd.Name = "buttonMaxSpd";
            this.buttonMaxSpd.Size = new System.Drawing.Size(100, 35);
            this.buttonMaxSpd.TabIndex = 16;
            this.buttonMaxSpd.Text = "MaxSpd";
            this.buttonMaxSpd.UseVisualStyleBackColor = true;
            this.buttonMaxSpd.Click += new System.EventHandler(this.buttonMaxSpd_Click);
            // 
            // buttonWert
            // 
            this.buttonWert.Location = new System.Drawing.Point(12, 222);
            this.buttonWert.Name = "buttonWert";
            this.buttonWert.Size = new System.Drawing.Size(100, 35);
            this.buttonWert.TabIndex = 17;
            this.buttonWert.Text = "€";
            this.buttonWert.UseVisualStyleBackColor = true;
            this.buttonWert.Click += new System.EventHandler(this.buttonWert_Click);
            // 
            // buttonGewicht
            // 
            this.buttonGewicht.Location = new System.Drawing.Point(11, 267);
            this.buttonGewicht.Name = "buttonGewicht";
            this.buttonGewicht.Size = new System.Drawing.Size(100, 35);
            this.buttonGewicht.TabIndex = 18;
            this.buttonGewicht.Text = "Gewicht";
            this.buttonGewicht.UseVisualStyleBackColor = true;
            this.buttonGewicht.Click += new System.EventHandler(this.buttonGewicht_Click);
            // 
            // buttonBaujahr
            // 
            this.buttonBaujahr.Location = new System.Drawing.Point(12, 312);
            this.buttonBaujahr.Name = "buttonBaujahr";
            this.buttonBaujahr.Size = new System.Drawing.Size(100, 35);
            this.buttonBaujahr.TabIndex = 19;
            this.buttonBaujahr.Text = "Baujahr";
            this.buttonBaujahr.UseVisualStyleBackColor = true;
            this.buttonBaujahr.Click += new System.EventHandler(this.buttonBaujahr_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Arial Black", 17F, System.Drawing.FontStyle.Bold);
            this.buttonStart.Location = new System.Drawing.Point(463, 87);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonStart.Size = new System.Drawing.Size(100, 260);
            this.buttonStart.TabIndex = 20;
            this.buttonStart.Text = "S\r\nT\r\nA\r\nR\r\nT";
            this.buttonStart.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 376);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonBaujahr);
            this.Controls.Add(this.buttonGewicht);
            this.Controls.Add(this.buttonWert);
            this.Controls.Add(this.buttonMaxSpd);
            this.Controls.Add(this.buttonKmH);
            this.Controls.Add(this.buttonPS);
            this.Controls.Add(this.labelCarName);
            this.Controls.Add(this.labelKmH);
            this.Controls.Add(this.labelBaujahr);
            this.Controls.Add(this.labelWert);
            this.Controls.Add(this.labelGewicht);
            this.Controls.Add(this.labelMaxSpd);
            this.Controls.Add(this.labelPS);
            this.Controls.Add(this.labelPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label labelPS;
        private System.Windows.Forms.Label labelMaxSpd;
        private System.Windows.Forms.Label labelGewicht;
        private System.Windows.Forms.Label labelWert;
        private System.Windows.Forms.Label labelBaujahr;
        private System.Windows.Forms.Label labelKmH;
        private System.Windows.Forms.Label labelCarName;
        private System.Windows.Forms.Button buttonPS;
        private System.Windows.Forms.Button buttonKmH;
        private System.Windows.Forms.Button buttonMaxSpd;
        private System.Windows.Forms.Button buttonWert;
        private System.Windows.Forms.Button buttonGewicht;
        private System.Windows.Forms.Button buttonBaujahr;
        private System.Windows.Forms.Button buttonStart;
    }
}


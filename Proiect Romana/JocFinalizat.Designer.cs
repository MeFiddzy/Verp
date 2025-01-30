namespace Proiect_Romana
{
    partial class JocFinalizat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelJod = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.textBoxSM = new System.Windows.Forms.TextBox();
            this.labelT = new System.Windows.Forms.Label();
            this.textBoxMT = new System.Windows.Forms.TextBox();
            this.panelJod.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelJod
            // 
            this.panelJod.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelJod.Controls.Add(this.buttonClose);
            this.panelJod.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelJod.Location = new System.Drawing.Point(0, 304);
            this.panelJod.Name = "panelJod";
            this.panelJod.Size = new System.Drawing.Size(445, 50);
            this.panelJod.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(0, 2);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(445, 48);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Închide";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.textBoxMT);
            this.panel1.Controls.Add(this.labelT);
            this.panel1.Controls.Add(this.textBoxSM);
            this.panel1.Controls.Add(this.textBoxS);
            this.panel1.Controls.Add(this.textBoxT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 304);
            this.panel1.TabIndex = 1;
            // 
            // textBoxT
            // 
            this.textBoxT.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBoxT.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxT.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxT.Location = new System.Drawing.Point(82, 85);
            this.textBoxT.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxT.Multiline = true;
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.ReadOnly = true;
            this.textBoxT.Size = new System.Drawing.Size(303, 49);
            this.textBoxT.TabIndex = 15;
            this.textBoxT.Text = "Timp: 00:00:00";
            this.textBoxT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxS
            // 
            this.textBoxS.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBoxS.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxS.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxS.Location = new System.Drawing.Point(82, 156);
            this.textBoxS.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxS.Multiline = true;
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.ReadOnly = true;
            this.textBoxS.Size = new System.Drawing.Size(303, 49);
            this.textBoxS.TabIndex = 16;
            this.textBoxS.Text = "Scor: 0";
            this.textBoxS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxS.TextChanged += new System.EventHandler(this.textBoxS_TextChanged);
            // 
            // textBoxSM
            // 
            this.textBoxSM.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBoxSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSM.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxSM.Location = new System.Drawing.Point(11, 236);
            this.textBoxSM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSM.Multiline = true;
            this.textBoxSM.Name = "textBoxSM";
            this.textBoxSM.ReadOnly = true;
            this.textBoxSM.Size = new System.Drawing.Size(182, 63);
            this.textBoxSM.TabIndex = 17;
            this.textBoxSM.Text = "Scor Maxim: 0";
            this.textBoxSM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSM.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.BackColor = System.Drawing.Color.Transparent;
            this.labelT.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelT.ForeColor = System.Drawing.Color.White;
            this.labelT.Location = new System.Drawing.Point(7, 9);
            this.labelT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(436, 40);
            this.labelT.TabIndex = 18;
            this.labelT.Text = "Ai terminat jocul nostru!";
            // 
            // textBoxMT
            // 
            this.textBoxMT.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBoxMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMT.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxMT.Location = new System.Drawing.Point(197, 236);
            this.textBoxMT.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMT.Multiline = true;
            this.textBoxMT.Name = "textBoxMT";
            this.textBoxMT.ReadOnly = true;
            this.textBoxMT.Size = new System.Drawing.Size(246, 63);
            this.textBoxMT.TabIndex = 19;
            this.textBoxMT.Text = "Timp Maxim";
            this.textBoxMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // JocFinalizat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 354);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelJod);
            this.Name = "JocFinalizat";
            this.Text = "JocFinalizat";
            this.Load += new System.EventHandler(this.JocFinalizat_Load);
            this.panelJod.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelJod;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.TextBox textBoxSM;
        private System.Windows.Forms.TextBox textBoxMT;
        private System.Windows.Forms.Label labelT;
    }
}
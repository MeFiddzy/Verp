namespace Proiect_Romana
{
    partial class Settings
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelT = new System.Windows.Forms.Label();
            this.textBoxINT = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 45);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBoxINT);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.buttonReset);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 309);
            this.panel2.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(0, -2);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(445, 48);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Închide";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.labelT);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(445, 78);
            this.panel3.TabIndex = 7;
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.BackColor = System.Drawing.Color.Transparent;
            this.labelT.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelT.ForeColor = System.Drawing.Color.White;
            this.labelT.Location = new System.Drawing.Point(135, 9);
            this.labelT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(174, 60);
            this.labelT.TabIndex = 7;
            this.labelT.Text = "Setări";
            // 
            // textBoxINT
            // 
            this.textBoxINT.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxINT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxINT.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxINT.Location = new System.Drawing.Point(71, 105);
            this.textBoxINT.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxINT.Name = "textBoxINT";
            this.textBoxINT.Size = new System.Drawing.Size(152, 35);
            this.textBoxINT.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Proiect_Romana.Properties.Resources.search;
            this.button2.Location = new System.Drawing.Point(125, 157);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 41);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Proiect_Romana.Properties.Resources.check;
            this.button1.Location = new System.Drawing.Point(238, 99);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 41);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.Image = global::Proiect_Romana.Properties.Resources.refresh_cw;
            this.buttonReset.Location = new System.Drawing.Point(71, 157);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(40, 41);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 354);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.TextBox textBoxINT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
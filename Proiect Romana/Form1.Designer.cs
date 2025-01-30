namespace Proiect_Romana
{
    partial class Form1
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
            this.panelT = new System.Windows.Forms.Panel();
            this.labelT = new System.Windows.Forms.Label();
            this.panelR = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonJ = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.panelT.SuspendLayout();
            this.panelR.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelT
            // 
            this.panelT.AccessibleName = "pannelT";
            this.panelT.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelT.Controls.Add(this.labelT);
            this.panelT.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelT.Location = new System.Drawing.Point(0, 0);
            this.panelT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelT.Name = "panelT";
            this.panelT.Size = new System.Drawing.Size(445, 65);
            this.panelT.TabIndex = 0;
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.BackColor = System.Drawing.Color.Transparent;
            this.labelT.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelT.ForeColor = System.Drawing.Color.White;
            this.labelT.Location = new System.Drawing.Point(121, 5);
            this.labelT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(196, 60);
            this.labelT.TabIndex = 0;
            this.labelT.Text = "Proiect";
            this.labelT.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelR
            // 
            this.panelR.Controls.Add(this.buttonS);
            this.panelR.Controls.Add(this.buttonClose);
            this.panelR.Controls.Add(this.buttonJ);
            this.panelR.Controls.Add(this.buttonT);
            this.panelR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelR.Location = new System.Drawing.Point(0, 65);
            this.panelR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelR.Name = "panelR";
            this.panelR.Size = new System.Drawing.Size(445, 289);
            this.panelR.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(131, 200);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(177, 73);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Închide";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonJ
            // 
            this.buttonJ.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJ.ForeColor = System.Drawing.Color.White;
            this.buttonJ.Location = new System.Drawing.Point(131, 111);
            this.buttonJ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonJ.Name = "buttonJ";
            this.buttonJ.Size = new System.Drawing.Size(177, 73);
            this.buttonJ.TabIndex = 1;
            this.buttonJ.Text = "Joc";
            this.buttonJ.UseVisualStyleBackColor = false;
            this.buttonJ.Click += new System.EventHandler(this.buttonJ_Click);
            // 
            // buttonT
            // 
            this.buttonT.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonT.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonT.ForeColor = System.Drawing.Color.White;
            this.buttonT.Location = new System.Drawing.Point(131, 27);
            this.buttonT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(177, 73);
            this.buttonT.TabIndex = 0;
            this.buttonT.Text = "Teorie";
            this.buttonT.UseVisualStyleBackColor = false;
            this.buttonT.Click += new System.EventHandler(this.buttonT_Click);
            // 
            // buttonS
            // 
            this.buttonS.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonS.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonS.ForeColor = System.Drawing.Color.White;
            this.buttonS.Image = global::Proiect_Romana.Properties.Resources.settings;
            this.buttonS.Location = new System.Drawing.Point(403, 4);
            this.buttonS.Margin = new System.Windows.Forms.Padding(2);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(40, 41);
            this.buttonS.TabIndex = 3;
            this.buttonS.UseVisualStyleBackColor = false;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(445, 354);
            this.Controls.Add(this.panelR);
            this.Controls.Add(this.panelT);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelT.ResumeLayout(false);
            this.panelT.PerformLayout();
            this.panelR.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelT;
        private System.Windows.Forms.Panel panelR;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.Button buttonJ;
        private System.Windows.Forms.Button buttonT;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonS;
    }
}


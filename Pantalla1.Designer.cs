namespace TELEPRO
{
    partial class Pantalla1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla1));
            this.label1 = new System.Windows.Forms.Label();
            this.rp1 = new TELEPRO.RP();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BRR = new System.Windows.Forms.Button();
            this.BCP = new System.Windows.Forms.Button();
            this.L1R = new System.Windows.Forms.Label();
            this.ltl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rp1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(86, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sistema de Control de Pagos Colonia Residencial";
            // 
            // rp1
            // 
            this.rp1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rp1.Image = ((System.Drawing.Image)(resources.GetObject("rp1.Image")));
            this.rp1.Location = new System.Drawing.Point(21, 10);
            this.rp1.Name = "rp1";
            this.rp1.Size = new System.Drawing.Size(53, 47);
            this.rp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rp1.TabIndex = 5;
            this.rp1.TabStop = false;
            // 
            // containerPanel
            // 
            this.containerPanel.Location = new System.Drawing.Point(0, 106);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(1196, 600);
            this.containerPanel.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(-13, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(1456, 10);
            this.label15.TabIndex = 36;
            this.label15.Text = "-";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.ltl);
            this.groupBox2.Controls.Add(this.L1R);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.BCP);
            this.groupBox2.Controls.Add(this.BRR);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(0, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1196, 40);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // BRR
            // 
            this.BRR.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BRR.FlatAppearance.BorderSize = 0;
            this.BRR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRR.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRR.Location = new System.Drawing.Point(11, 0);
            this.BRR.Name = "BRR";
            this.BRR.Size = new System.Drawing.Size(191, 45);
            this.BRR.TabIndex = 2;
            this.BRR.Text = "Registro de Residentes";
            this.BRR.UseVisualStyleBackColor = true;
            this.BRR.Click += new System.EventHandler(this.BRR_Click);
            this.BRR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BRR_MouseDown);
            this.BRR.MouseLeave += new System.EventHandler(this.BRR_MouseLeave);
            this.BRR.MouseHover += new System.EventHandler(this.BRR_MouseHover);
            this.BRR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BRR_MouseUp);
            // 
            // BCP
            // 
            this.BCP.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BCP.FlatAppearance.BorderSize = 0;
            this.BCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.BCP.Location = new System.Drawing.Point(212, 0);
            this.BCP.Name = "BCP";
            this.BCP.Size = new System.Drawing.Size(191, 45);
            this.BCP.TabIndex = 3;
            this.BCP.Text = "Control de Pagos";
            this.BCP.UseVisualStyleBackColor = true;
            this.BCP.Click += new System.EventHandler(this.BCP_Click);
            this.BCP.MouseLeave += new System.EventHandler(this.BCP_MouseLeave);
            this.BCP.MouseHover += new System.EventHandler(this.BCP_MouseHover);
            // 
            // L1R
            // 
            this.L1R.BackColor = System.Drawing.Color.LightSkyBlue;
            this.L1R.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1R.Location = new System.Drawing.Point(212, 35);
            this.L1R.Name = "L1R";
            this.L1R.Size = new System.Drawing.Size(191, 5);
            this.L1R.TabIndex = 36;
            this.L1R.Text = "-";
            this.L1R.Visible = false;
            // 
            // ltl
            // 
            this.ltl.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ltl.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltl.Location = new System.Drawing.Point(7, 35);
            this.ltl.Name = "ltl";
            this.ltl.Size = new System.Drawing.Size(195, 5);
            this.ltl.TabIndex = 37;
            this.ltl.Text = "-";
            this.ltl.Visible = false;
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Image = global::TELEPRO.Properties.Resources.delete;
            this.label2.Location = new System.Drawing.Point(1124, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 37);
            this.label2.TabIndex = 6;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Pantalla1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rp1);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla1";
            this.Load += new System.EventHandler(this.Pantalla1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rp1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private RP rp1;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ltl;
        private System.Windows.Forms.Label L1R;
        private System.Windows.Forms.Button BCP;
        private System.Windows.Forms.Button BRR;
        private System.Windows.Forms.Label label2;
    }
}
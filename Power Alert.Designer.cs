namespace AESO__Power_Alert
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSilence = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPowerMode = new System.Windows.Forms.Label();
            this.txtDHSet = new System.Windows.Forms.TextBox();
            this.lblAncillary = new System.Windows.Forms.Label();
            this.lblDH = new System.Windows.Forms.Label();
            this.lbl3H = new System.Windows.Forms.Label();
            this.txt3HSet = new System.Windows.Forms.TextBox();
            this.btnSetDH = new System.Windows.Forms.Button();
            this.btnSet3H = new System.Windows.Forms.Button();
            this.lblDispatch = new System.Windows.Forms.Label();
            this.lbl16nm = new System.Windows.Forms.Label();
            this.lblMinMW = new System.Windows.Forms.Label();
            this.txtDHMin = new System.Windows.Forms.TextBox();
            this.txt3HMin = new System.Windows.Forms.TextBox();
            this.lblDHTitle = new System.Windows.Forms.Label();
            this.lbl3HTitle = new System.Windows.Forms.Label();
            this.lblClarke = new System.Windows.Forms.Label();
            this.txt3HDispatch = new System.Windows.Forms.TextBox();
            this.txtDHDispatch = new System.Windows.Forms.TextBox();
            this.txtDH16nm = new System.Windows.Forms.TextBox();
            this.txt3H16nm = new System.Windows.Forms.TextBox();
            this.txt3HClarke = new System.Windows.Forms.TextBox();
            this.txtDHClarke = new System.Windows.Forms.TextBox();
            this.lblCMH = new System.Windows.Forms.Label();
            this.txtCMHPower = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSilence
            // 
            this.btnSilence.Location = new System.Drawing.Point(552, 13);
            this.btnSilence.Name = "btnSilence";
            this.btnSilence.Size = new System.Drawing.Size(180, 124);
            this.btnSilence.TabIndex = 1;
            this.btnSilence.Text = "Silence Alarm";
            this.btnSilence.UseVisualStyleBackColor = true;
            this.btnSilence.Click += new System.EventHandler(this.Button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblPrice.Location = new System.Drawing.Point(13, 13);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(352, 69);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Power Price";
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(25, 84);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(96, 20);
            this.lblUpdate.TabIndex = 3;
            this.lblUpdate.Text = "Update time";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(720, 295);
            this.dataGridView1.TabIndex = 4;
            // 
            // lblPowerMode
            // 
            this.lblPowerMode.AutoSize = true;
            this.lblPowerMode.Location = new System.Drawing.Point(12, 120);
            this.lblPowerMode.Name = "lblPowerMode";
            this.lblPowerMode.Size = new System.Drawing.Size(114, 20);
            this.lblPowerMode.TabIndex = 5;
            this.lblPowerMode.Text = "Power Mode: 0";
            this.lblPowerMode.Click += new System.EventHandler(this.Label3_Click);
            // 
            // txtDHSet
            // 
            this.txtDHSet.Location = new System.Drawing.Point(809, 60);
            this.txtDHSet.Name = "txtDHSet";
            this.txtDHSet.Size = new System.Drawing.Size(52, 26);
            this.txtDHSet.TabIndex = 6;
            this.txtDHSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAncillary
            // 
            this.lblAncillary.AutoSize = true;
            this.lblAncillary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblAncillary.Location = new System.Drawing.Point(756, 13);
            this.lblAncillary.Name = "lblAncillary";
            this.lblAncillary.Size = new System.Drawing.Size(217, 30);
            this.lblAncillary.TabIndex = 7;
            this.lblAncillary.Text = "Ancillary Services";
            // 
            // lblDH
            // 
            this.lblDH.AutoSize = true;
            this.lblDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDH.Location = new System.Drawing.Point(757, 59);
            this.lblDH.Name = "lblDH";
            this.lblDH.Size = new System.Drawing.Size(46, 25);
            this.lblDH.TabIndex = 8;
            this.lblDH.Text = "DH:";
            // 
            // lbl3H
            // 
            this.lbl3H.AutoSize = true;
            this.lbl3H.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl3H.Location = new System.Drawing.Point(757, 112);
            this.lbl3H.Name = "lbl3H";
            this.lbl3H.Size = new System.Drawing.Size(43, 25);
            this.lbl3H.TabIndex = 10;
            this.lbl3H.Text = "3H:";
            // 
            // txt3HSet
            // 
            this.txt3HSet.Location = new System.Drawing.Point(809, 113);
            this.txt3HSet.Name = "txt3HSet";
            this.txt3HSet.Size = new System.Drawing.Size(52, 26);
            this.txt3HSet.TabIndex = 9;
            this.txt3HSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSetDH
            // 
            this.btnSetDH.Location = new System.Drawing.Point(867, 58);
            this.btnSetDH.Name = "btnSetDH";
            this.btnSetDH.Size = new System.Drawing.Size(82, 31);
            this.btnSetDH.TabIndex = 11;
            this.btnSetDH.Text = "Set";
            this.btnSetDH.UseVisualStyleBackColor = true;
            this.btnSetDH.Click += new System.EventHandler(this.BtnSetDH_Click);
            // 
            // btnSet3H
            // 
            this.btnSet3H.Location = new System.Drawing.Point(867, 110);
            this.btnSet3H.Name = "btnSet3H";
            this.btnSet3H.Size = new System.Drawing.Size(82, 32);
            this.btnSet3H.TabIndex = 12;
            this.btnSet3H.Text = "Set";
            this.btnSet3H.UseVisualStyleBackColor = true;
            this.btnSet3H.Click += new System.EventHandler(this.BtnSet3H_Click);
            // 
            // lblDispatch
            // 
            this.lblDispatch.AutoSize = true;
            this.lblDispatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDispatch.Location = new System.Drawing.Point(732, 220);
            this.lblDispatch.Name = "lblDispatch";
            this.lblDispatch.Size = new System.Drawing.Size(94, 25);
            this.lblDispatch.TabIndex = 13;
            this.lblDispatch.Text = "Dispatch:";
            // 
            // lbl16nm
            // 
            this.lbl16nm.AutoSize = true;
            this.lbl16nm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl16nm.Location = new System.Drawing.Point(732, 261);
            this.lbl16nm.Name = "lbl16nm";
            this.lbl16nm.Size = new System.Drawing.Size(67, 25);
            this.lbl16nm.TabIndex = 14;
            this.lbl16nm.Text = "16nm:";
            // 
            // lblMinMW
            // 
            this.lblMinMW.AutoSize = true;
            this.lblMinMW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMinMW.Location = new System.Drawing.Point(733, 332);
            this.lblMinMW.Name = "lblMinMW";
            this.lblMinMW.Size = new System.Drawing.Size(92, 25);
            this.lblMinMW.TabIndex = 15;
            this.lblMinMW.Text = "Min MW:";
            // 
            // txtDHMin
            // 
            this.txtDHMin.Location = new System.Drawing.Point(826, 331);
            this.txtDHMin.Name = "txtDHMin";
            this.txtDHMin.ReadOnly = true;
            this.txtDHMin.Size = new System.Drawing.Size(69, 26);
            this.txtDHMin.TabIndex = 17;
            this.txtDHMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt3HMin
            // 
            this.txt3HMin.Location = new System.Drawing.Point(901, 331);
            this.txt3HMin.Name = "txt3HMin";
            this.txt3HMin.ReadOnly = true;
            this.txt3HMin.Size = new System.Drawing.Size(72, 26);
            this.txt3HMin.TabIndex = 18;
            this.txt3HMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDHTitle
            // 
            this.lblDHTitle.AutoSize = true;
            this.lblDHTitle.Location = new System.Drawing.Point(863, 180);
            this.lblDHTitle.Name = "lblDHTitle";
            this.lblDHTitle.Size = new System.Drawing.Size(33, 20);
            this.lblDHTitle.TabIndex = 19;
            this.lblDHTitle.Text = "DH";
            // 
            // lbl3HTitle
            // 
            this.lbl3HTitle.AutoSize = true;
            this.lbl3HTitle.Location = new System.Drawing.Point(919, 180);
            this.lbl3HTitle.Name = "lbl3HTitle";
            this.lbl3HTitle.Size = new System.Drawing.Size(30, 20);
            this.lbl3HTitle.TabIndex = 20;
            this.lbl3HTitle.Text = "3H";
            // 
            // lblClarke
            // 
            this.lblClarke.AutoSize = true;
            this.lblClarke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblClarke.Location = new System.Drawing.Point(733, 298);
            this.lblClarke.Name = "lblClarke";
            this.lblClarke.Size = new System.Drawing.Size(75, 25);
            this.lblClarke.TabIndex = 21;
            this.lblClarke.Text = "Clarke:";
            // 
            // txt3HDispatch
            // 
            this.txt3HDispatch.Location = new System.Drawing.Point(901, 221);
            this.txt3HDispatch.Name = "txt3HDispatch";
            this.txt3HDispatch.ReadOnly = true;
            this.txt3HDispatch.Size = new System.Drawing.Size(72, 26);
            this.txt3HDispatch.TabIndex = 23;
            this.txt3HDispatch.Text = "0";
            this.txt3HDispatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDHDispatch
            // 
            this.txtDHDispatch.Location = new System.Drawing.Point(826, 221);
            this.txtDHDispatch.Name = "txtDHDispatch";
            this.txtDHDispatch.ReadOnly = true;
            this.txtDHDispatch.Size = new System.Drawing.Size(69, 26);
            this.txtDHDispatch.TabIndex = 22;
            this.txtDHDispatch.Text = "0";
            this.txtDHDispatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDH16nm
            // 
            this.txtDH16nm.Location = new System.Drawing.Point(826, 260);
            this.txtDH16nm.Name = "txtDH16nm";
            this.txtDH16nm.ReadOnly = true;
            this.txtDH16nm.Size = new System.Drawing.Size(69, 26);
            this.txtDH16nm.TabIndex = 25;
            this.txtDH16nm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt3H16nm
            // 
            this.txt3H16nm.Location = new System.Drawing.Point(901, 260);
            this.txt3H16nm.Name = "txt3H16nm";
            this.txt3H16nm.ReadOnly = true;
            this.txt3H16nm.Size = new System.Drawing.Size(72, 26);
            this.txt3H16nm.TabIndex = 24;
            this.txt3H16nm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt3HClarke
            // 
            this.txt3HClarke.Location = new System.Drawing.Point(901, 299);
            this.txt3HClarke.Name = "txt3HClarke";
            this.txt3HClarke.ReadOnly = true;
            this.txt3HClarke.Size = new System.Drawing.Size(72, 26);
            this.txt3HClarke.TabIndex = 27;
            this.txt3HClarke.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDHClarke
            // 
            this.txtDHClarke.Location = new System.Drawing.Point(826, 299);
            this.txtDHClarke.Name = "txtDHClarke";
            this.txtDHClarke.ReadOnly = true;
            this.txtDHClarke.Size = new System.Drawing.Size(69, 26);
            this.txtDHClarke.TabIndex = 26;
            this.txtDHClarke.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCMH
            // 
            this.lblCMH.AutoSize = true;
            this.lblCMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCMH.Location = new System.Drawing.Point(732, 418);
            this.lblCMH.Name = "lblCMH";
            this.lblCMH.Size = new System.Drawing.Size(124, 25);
            this.lblCMH.TabIndex = 28;
            this.lblCMH.Text = "CMH Power:";
            // 
            // txtCMHPower
            // 
            this.txtCMHPower.Location = new System.Drawing.Point(864, 419);
            this.txtCMHPower.Name = "txtCMHPower";
            this.txtCMHPower.ReadOnly = true;
            this.txtCMHPower.Size = new System.Drawing.Size(109, 26);
            this.txtCMHPower.TabIndex = 29;
            this.txtCMHPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 450);
            this.Controls.Add(this.txtCMHPower);
            this.Controls.Add(this.lblCMH);
            this.Controls.Add(this.txt3HClarke);
            this.Controls.Add(this.txtDHClarke);
            this.Controls.Add(this.txtDH16nm);
            this.Controls.Add(this.txt3H16nm);
            this.Controls.Add(this.txt3HDispatch);
            this.Controls.Add(this.txtDHDispatch);
            this.Controls.Add(this.lblClarke);
            this.Controls.Add(this.lbl3HTitle);
            this.Controls.Add(this.lblDHTitle);
            this.Controls.Add(this.txt3HMin);
            this.Controls.Add(this.txtDHMin);
            this.Controls.Add(this.lblMinMW);
            this.Controls.Add(this.lbl16nm);
            this.Controls.Add(this.lblDispatch);
            this.Controls.Add(this.btnSet3H);
            this.Controls.Add(this.btnSetDH);
            this.Controls.Add(this.lbl3H);
            this.Controls.Add(this.txt3HSet);
            this.Controls.Add(this.lblDH);
            this.Controls.Add(this.lblAncillary);
            this.Controls.Add(this.txtDHSet);
            this.Controls.Add(this.lblPowerMode);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnSilence);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Power Alert - AESO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSilence;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPowerMode;
        private System.Windows.Forms.TextBox txtDHSet;
        private System.Windows.Forms.Label lblAncillary;
        private System.Windows.Forms.Label lblDH;
        private System.Windows.Forms.Label lbl3H;
        private System.Windows.Forms.TextBox txt3HSet;
        private System.Windows.Forms.Button btnSetDH;
        private System.Windows.Forms.Button btnSet3H;
        private System.Windows.Forms.Label lblDispatch;
        private System.Windows.Forms.Label lbl16nm;
        private System.Windows.Forms.Label lblMinMW;
        private System.Windows.Forms.TextBox txtDHMin;
        private System.Windows.Forms.TextBox txt3HMin;
        private System.Windows.Forms.Label lblDHTitle;
        private System.Windows.Forms.Label lbl3HTitle;
        private System.Windows.Forms.Label lblClarke;
        private System.Windows.Forms.TextBox txt3HDispatch;
        private System.Windows.Forms.TextBox txtDHDispatch;
        private System.Windows.Forms.TextBox txtDH16nm;
        private System.Windows.Forms.TextBox txt3H16nm;
        private System.Windows.Forms.TextBox txt3HClarke;
        private System.Windows.Forms.TextBox txtDHClarke;
        private System.Windows.Forms.Label lblCMH;
        private System.Windows.Forms.TextBox txtCMHPower;
    }
}


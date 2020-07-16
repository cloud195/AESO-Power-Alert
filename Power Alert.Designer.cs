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
            this.lblCMH = new System.Windows.Forms.Label();
            this.txtCMHSet = new System.Windows.Forms.TextBox();
            this.btnSetDH = new System.Windows.Forms.Button();
            this.btnSetCMH = new System.Windows.Forms.Button();
            this.lblDispatch = new System.Windows.Forms.Label();
            this.lbl16nm = new System.Windows.Forms.Label();
            this.lblMinMW = new System.Windows.Forms.Label();
            this.txtDHMin = new System.Windows.Forms.TextBox();
            this.txtCMHMin = new System.Windows.Forms.TextBox();
            this.lblDHTitle = new System.Windows.Forms.Label();
            this.lblCMHTitle = new System.Windows.Forms.Label();
            this.lblClarke = new System.Windows.Forms.Label();
            this.txtCMHDispatch = new System.Windows.Forms.TextBox();
            this.txtDHDispatch = new System.Windows.Forms.TextBox();
            this.txtDH16nm = new System.Windows.Forms.TextBox();
            this.txtCMH16nm = new System.Windows.Forms.TextBox();
            this.txtCMHClarke = new System.Windows.Forms.TextBox();
            this.txtDHClarke = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDH14nm = new System.Windows.Forms.TextBox();
            this.txtCMH14nm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSilence
            // 
            this.btnSilence.Location = new System.Drawing.Point(368, 8);
            this.btnSilence.Margin = new System.Windows.Forms.Padding(2);
            this.btnSilence.Name = "btnSilence";
            this.btnSilence.Size = new System.Drawing.Size(120, 81);
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
            this.lblPrice.Location = new System.Drawing.Point(9, 8);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(237, 46);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Power Price";
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(17, 55);
            this.lblUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(64, 13);
            this.lblUpdate.TabIndex = 3;
            this.lblUpdate.Text = "Update time";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 93);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(480, 192);
            this.dataGridView1.TabIndex = 4;
            // 
            // lblPowerMode
            // 
            this.lblPowerMode.AutoSize = true;
            this.lblPowerMode.Location = new System.Drawing.Point(8, 78);
            this.lblPowerMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPowerMode.Name = "lblPowerMode";
            this.lblPowerMode.Size = new System.Drawing.Size(79, 13);
            this.lblPowerMode.TabIndex = 5;
            this.lblPowerMode.Text = "Power Mode: 0";
            this.lblPowerMode.Click += new System.EventHandler(this.Label3_Click);
            // 
            // txtDHSet
            // 
            this.txtDHSet.Location = new System.Drawing.Point(539, 39);
            this.txtDHSet.Margin = new System.Windows.Forms.Padding(2);
            this.txtDHSet.Name = "txtDHSet";
            this.txtDHSet.Size = new System.Drawing.Size(36, 20);
            this.txtDHSet.TabIndex = 6;
            this.txtDHSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAncillary
            // 
            this.lblAncillary.AutoSize = true;
            this.lblAncillary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblAncillary.Location = new System.Drawing.Point(504, 8);
            this.lblAncillary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAncillary.Name = "lblAncillary";
            this.lblAncillary.Size = new System.Drawing.Size(152, 22);
            this.lblAncillary.TabIndex = 7;
            this.lblAncillary.Text = "Ancillary Services";
            // 
            // lblDH
            // 
            this.lblDH.AutoSize = true;
            this.lblDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDH.Location = new System.Drawing.Point(505, 38);
            this.lblDH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDH.Name = "lblDH";
            this.lblDH.Size = new System.Drawing.Size(32, 17);
            this.lblDH.TabIndex = 8;
            this.lblDH.Text = "DH:";
            // 
            // lblCMH
            // 
            this.lblCMH.AutoSize = true;
            this.lblCMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCMH.Location = new System.Drawing.Point(493, 114);
            this.lblCMH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCMH.Name = "lblCMH";
            this.lblCMH.Size = new System.Drawing.Size(42, 17);
            this.lblCMH.TabIndex = 10;
            this.lblCMH.Text = "CMH:";
            // 
            // txtCMHSet
            // 
            this.txtCMHSet.Location = new System.Drawing.Point(539, 113);
            this.txtCMHSet.Margin = new System.Windows.Forms.Padding(2);
            this.txtCMHSet.Name = "txtCMHSet";
            this.txtCMHSet.Size = new System.Drawing.Size(36, 20);
            this.txtCMHSet.TabIndex = 9;
            this.txtCMHSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSetDH
            // 
            this.btnSetDH.Location = new System.Drawing.Point(578, 38);
            this.btnSetDH.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetDH.Name = "btnSetDH";
            this.btnSetDH.Size = new System.Drawing.Size(55, 21);
            this.btnSetDH.TabIndex = 11;
            this.btnSetDH.Text = "Set";
            this.btnSetDH.UseVisualStyleBackColor = true;
            this.btnSetDH.Click += new System.EventHandler(this.BtnSetDH_Click);
            // 
            // btnSetCMH
            // 
            this.btnSetCMH.Location = new System.Drawing.Point(578, 111);
            this.btnSetCMH.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetCMH.Name = "btnSetCMH";
            this.btnSetCMH.Size = new System.Drawing.Size(55, 22);
            this.btnSetCMH.TabIndex = 12;
            this.btnSetCMH.Text = "Set";
            this.btnSetCMH.UseVisualStyleBackColor = true;
            this.btnSetCMH.Click += new System.EventHandler(this.BtnSetCMH_Click);
            // 
            // lblDispatch
            // 
            this.lblDispatch.AutoSize = true;
            this.lblDispatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDispatch.Location = new System.Drawing.Point(494, 193);
            this.lblDispatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDispatch.Name = "lblDispatch";
            this.lblDispatch.Size = new System.Drawing.Size(67, 17);
            this.lblDispatch.TabIndex = 13;
            this.lblDispatch.Text = "Dispatch:";
            // 
            // lbl16nm
            // 
            this.lbl16nm.AutoSize = true;
            this.lbl16nm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl16nm.Location = new System.Drawing.Point(494, 220);
            this.lbl16nm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl16nm.Name = "lbl16nm";
            this.lbl16nm.Size = new System.Drawing.Size(47, 17);
            this.lbl16nm.TabIndex = 14;
            this.lbl16nm.Text = "16nm:";
            // 
            // lblMinMW
            // 
            this.lblMinMW.AutoSize = true;
            this.lblMinMW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMinMW.Location = new System.Drawing.Point(495, 287);
            this.lblMinMW.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinMW.Name = "lblMinMW";
            this.lblMinMW.Size = new System.Drawing.Size(62, 17);
            this.lblMinMW.TabIndex = 15;
            this.lblMinMW.Text = "Min MW:";
            // 
            // txtDHMin
            // 
            this.txtDHMin.Location = new System.Drawing.Point(557, 286);
            this.txtDHMin.Margin = new System.Windows.Forms.Padding(2);
            this.txtDHMin.Name = "txtDHMin";
            this.txtDHMin.ReadOnly = true;
            this.txtDHMin.Size = new System.Drawing.Size(47, 20);
            this.txtDHMin.TabIndex = 17;
            this.txtDHMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCMHMin
            // 
            this.txtCMHMin.Location = new System.Drawing.Point(607, 286);
            this.txtCMHMin.Margin = new System.Windows.Forms.Padding(2);
            this.txtCMHMin.Name = "txtCMHMin";
            this.txtCMHMin.ReadOnly = true;
            this.txtCMHMin.Size = new System.Drawing.Size(49, 20);
            this.txtCMHMin.TabIndex = 18;
            this.txtCMHMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDHTitle
            // 
            this.lblDHTitle.AutoSize = true;
            this.lblDHTitle.Location = new System.Drawing.Point(570, 179);
            this.lblDHTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDHTitle.Name = "lblDHTitle";
            this.lblDHTitle.Size = new System.Drawing.Size(23, 13);
            this.lblDHTitle.TabIndex = 19;
            this.lblDHTitle.Text = "DH";
            // 
            // lblCMHTitle
            // 
            this.lblCMHTitle.AutoSize = true;
            this.lblCMHTitle.Location = new System.Drawing.Point(608, 179);
            this.lblCMHTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCMHTitle.Name = "lblCMHTitle";
            this.lblCMHTitle.Size = new System.Drawing.Size(31, 13);
            this.lblCMHTitle.TabIndex = 20;
            this.lblCMHTitle.Text = "CMH";
            // 
            // lblClarke
            // 
            this.lblClarke.AutoSize = true;
            this.lblClarke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblClarke.Location = new System.Drawing.Point(495, 265);
            this.lblClarke.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClarke.Name = "lblClarke";
            this.lblClarke.Size = new System.Drawing.Size(52, 17);
            this.lblClarke.TabIndex = 21;
            this.lblClarke.Text = "Clarke:";
            // 
            // txtCMHDispatch
            // 
            this.txtCMHDispatch.Location = new System.Drawing.Point(607, 194);
            this.txtCMHDispatch.Margin = new System.Windows.Forms.Padding(2);
            this.txtCMHDispatch.Name = "txtCMHDispatch";
            this.txtCMHDispatch.ReadOnly = true;
            this.txtCMHDispatch.Size = new System.Drawing.Size(49, 20);
            this.txtCMHDispatch.TabIndex = 23;
            this.txtCMHDispatch.Text = "0";
            this.txtCMHDispatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDHDispatch
            // 
            this.txtDHDispatch.Location = new System.Drawing.Point(557, 194);
            this.txtDHDispatch.Margin = new System.Windows.Forms.Padding(2);
            this.txtDHDispatch.Name = "txtDHDispatch";
            this.txtDHDispatch.ReadOnly = true;
            this.txtDHDispatch.Size = new System.Drawing.Size(47, 20);
            this.txtDHDispatch.TabIndex = 22;
            this.txtDHDispatch.Text = "0";
            this.txtDHDispatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDH16nm
            // 
            this.txtDH16nm.Location = new System.Drawing.Point(557, 219);
            this.txtDH16nm.Margin = new System.Windows.Forms.Padding(2);
            this.txtDH16nm.Name = "txtDH16nm";
            this.txtDH16nm.ReadOnly = true;
            this.txtDH16nm.Size = new System.Drawing.Size(47, 20);
            this.txtDH16nm.TabIndex = 25;
            this.txtDH16nm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCMH16nm
            // 
            this.txtCMH16nm.Location = new System.Drawing.Point(607, 219);
            this.txtCMH16nm.Margin = new System.Windows.Forms.Padding(2);
            this.txtCMH16nm.Name = "txtCMH16nm";
            this.txtCMH16nm.ReadOnly = true;
            this.txtCMH16nm.Size = new System.Drawing.Size(49, 20);
            this.txtCMH16nm.TabIndex = 24;
            this.txtCMH16nm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCMHClarke
            // 
            this.txtCMHClarke.Location = new System.Drawing.Point(607, 265);
            this.txtCMHClarke.Margin = new System.Windows.Forms.Padding(2);
            this.txtCMHClarke.Name = "txtCMHClarke";
            this.txtCMHClarke.ReadOnly = true;
            this.txtCMHClarke.Size = new System.Drawing.Size(49, 20);
            this.txtCMHClarke.TabIndex = 27;
            this.txtCMHClarke.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDHClarke
            // 
            this.txtDHClarke.Location = new System.Drawing.Point(557, 265);
            this.txtDHClarke.Margin = new System.Windows.Forms.Padding(2);
            this.txtDHClarke.Name = "txtDHClarke";
            this.txtDHClarke.ReadOnly = true;
            this.txtDHClarke.Size = new System.Drawing.Size(47, 20);
            this.txtDHClarke.TabIndex = 26;
            this.txtDHClarke.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(544, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Min MW";
            // 
            // txtDH14nm
            // 
            this.txtDH14nm.Location = new System.Drawing.Point(557, 241);
            this.txtDH14nm.Margin = new System.Windows.Forms.Padding(2);
            this.txtDH14nm.Name = "txtDH14nm";
            this.txtDH14nm.ReadOnly = true;
            this.txtDH14nm.Size = new System.Drawing.Size(47, 20);
            this.txtDH14nm.TabIndex = 31;
            this.txtDH14nm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCMH14nm
            // 
            this.txtCMH14nm.Location = new System.Drawing.Point(607, 241);
            this.txtCMH14nm.Margin = new System.Windows.Forms.Padding(2);
            this.txtCMH14nm.Name = "txtCMH14nm";
            this.txtCMH14nm.ReadOnly = true;
            this.txtCMH14nm.Size = new System.Drawing.Size(49, 20);
            this.txtCMH14nm.TabIndex = 30;
            this.txtCMH14nm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(494, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "14nm:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 326);
            this.Controls.Add(this.txtDH14nm);
            this.Controls.Add(this.txtCMH14nm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCMHClarke);
            this.Controls.Add(this.txtDHClarke);
            this.Controls.Add(this.txtDH16nm);
            this.Controls.Add(this.txtCMH16nm);
            this.Controls.Add(this.txtCMHDispatch);
            this.Controls.Add(this.txtDHDispatch);
            this.Controls.Add(this.lblClarke);
            this.Controls.Add(this.lblCMHTitle);
            this.Controls.Add(this.lblDHTitle);
            this.Controls.Add(this.txtCMHMin);
            this.Controls.Add(this.txtDHMin);
            this.Controls.Add(this.lblMinMW);
            this.Controls.Add(this.lbl16nm);
            this.Controls.Add(this.lblDispatch);
            this.Controls.Add(this.btnSetCMH);
            this.Controls.Add(this.btnSetDH);
            this.Controls.Add(this.lblCMH);
            this.Controls.Add(this.txtCMHSet);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label lblCMH;
        private System.Windows.Forms.TextBox txtCMHSet;
        private System.Windows.Forms.Button btnSetDH;
        private System.Windows.Forms.Button btnSetCMH;
        private System.Windows.Forms.Label lblDispatch;
        private System.Windows.Forms.Label lbl16nm;
        private System.Windows.Forms.Label lblMinMW;
        private System.Windows.Forms.TextBox txtDHMin;
        private System.Windows.Forms.TextBox txtCMHMin;
        private System.Windows.Forms.Label lblDHTitle;
        private System.Windows.Forms.Label lblCMHTitle;
        private System.Windows.Forms.Label lblClarke;
        private System.Windows.Forms.TextBox txtCMHDispatch;
        private System.Windows.Forms.TextBox txtDHDispatch;
        private System.Windows.Forms.TextBox txtDH16nm;
        private System.Windows.Forms.TextBox txtCMH16nm;
        private System.Windows.Forms.TextBox txtCMHClarke;
        private System.Windows.Forms.TextBox txtDHClarke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDH14nm;
        private System.Windows.Forms.TextBox txtCMH14nm;
        private System.Windows.Forms.Label label2;
    }
}


namespace TaskWithControlsUI
{
    partial class FrmTesting
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
            this.LbxOutput = new System.Windows.Forms.ListBox();
            this.BtnClick = new System.Windows.Forms.Button();
            this.Txt01 = new System.Windows.Forms.TextBox();
            this.Txt02 = new System.Windows.Forms.TextBox();
            this.Txt03 = new System.Windows.Forms.TextBox();
            this.Txt04 = new System.Windows.Forms.TextBox();
            this.CbxT1 = new System.Windows.Forms.CheckBox();
            this.CbxT3 = new System.Windows.Forms.CheckBox();
            this.CbxT2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LbxOutput
            // 
            this.LbxOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbxOutput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbxOutput.FormattingEnabled = true;
            this.LbxOutput.ItemHeight = 21;
            this.LbxOutput.Location = new System.Drawing.Point(0, 0);
            this.LbxOutput.Name = "LbxOutput";
            this.LbxOutput.Size = new System.Drawing.Size(642, 361);
            this.LbxOutput.TabIndex = 0;
            // 
            // BtnClick
            // 
            this.BtnClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClick.Location = new System.Drawing.Point(12, 389);
            this.BtnClick.Name = "BtnClick";
            this.BtnClick.Size = new System.Drawing.Size(115, 34);
            this.BtnClick.TabIndex = 1;
            this.BtnClick.Text = "Click";
            this.BtnClick.UseVisualStyleBackColor = true;
            this.BtnClick.Click += new System.EventHandler(this.BtnClick_Click);
            // 
            // Txt01
            // 
            this.Txt01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt01.Location = new System.Drawing.Point(156, 393);
            this.Txt01.Name = "Txt01";
            this.Txt01.Size = new System.Drawing.Size(100, 26);
            this.Txt01.TabIndex = 2;
            this.Txt01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt02
            // 
            this.Txt02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt02.Location = new System.Drawing.Point(280, 393);
            this.Txt02.Name = "Txt02";
            this.Txt02.Size = new System.Drawing.Size(100, 26);
            this.Txt02.TabIndex = 3;
            this.Txt02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt03
            // 
            this.Txt03.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt03.Location = new System.Drawing.Point(404, 393);
            this.Txt03.Name = "Txt03";
            this.Txt03.Size = new System.Drawing.Size(100, 26);
            this.Txt03.TabIndex = 4;
            this.Txt03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt04
            // 
            this.Txt04.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt04.Location = new System.Drawing.Point(528, 393);
            this.Txt04.Name = "Txt04";
            this.Txt04.Size = new System.Drawing.Size(100, 26);
            this.Txt04.TabIndex = 5;
            this.Txt04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CbxT1
            // 
            this.CbxT1.AutoSize = true;
            this.CbxT1.Location = new System.Drawing.Point(12, 448);
            this.CbxT1.Name = "CbxT1";
            this.CbxT1.Size = new System.Drawing.Size(39, 17);
            this.CbxT1.TabIndex = 6;
            this.CbxT1.Text = "T1";
            this.CbxT1.UseVisualStyleBackColor = true;
            // 
            // CbxT3
            // 
            this.CbxT3.AutoSize = true;
            this.CbxT3.Location = new System.Drawing.Point(102, 448);
            this.CbxT3.Name = "CbxT3";
            this.CbxT3.Size = new System.Drawing.Size(39, 17);
            this.CbxT3.TabIndex = 7;
            this.CbxT3.Text = "T3";
            this.CbxT3.UseVisualStyleBackColor = true;
            // 
            // CbxT2
            // 
            this.CbxT2.AutoSize = true;
            this.CbxT2.Location = new System.Drawing.Point(57, 448);
            this.CbxT2.Name = "CbxT2";
            this.CbxT2.Size = new System.Drawing.Size(39, 17);
            this.CbxT2.TabIndex = 8;
            this.CbxT2.Text = "T2";
            this.CbxT2.UseVisualStyleBackColor = true;
            // 
            // FrmTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 477);
            this.Controls.Add(this.CbxT2);
            this.Controls.Add(this.CbxT3);
            this.Controls.Add(this.CbxT1);
            this.Controls.Add(this.Txt04);
            this.Controls.Add(this.Txt03);
            this.Controls.Add(this.Txt02);
            this.Controls.Add(this.Txt01);
            this.Controls.Add(this.BtnClick);
            this.Controls.Add(this.LbxOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmTesting";
            this.Text = "Listbox Output";
            this.Load += new System.EventHandler(this.FrmTesting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbxOutput;
        private System.Windows.Forms.Button BtnClick;
        private System.Windows.Forms.TextBox Txt01;
        private System.Windows.Forms.TextBox Txt02;
        private System.Windows.Forms.TextBox Txt03;
        private System.Windows.Forms.TextBox Txt04;
        private System.Windows.Forms.CheckBox CbxT1;
        private System.Windows.Forms.CheckBox CbxT3;
        private System.Windows.Forms.CheckBox CbxT2;
    }
}


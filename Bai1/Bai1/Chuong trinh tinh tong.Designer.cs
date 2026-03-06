namespace Bai1
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lba = new System.Windows.Forms.Label();
            this.lbb = new System.Windows.Forms.Label();
            this.texta = new System.Windows.Forms.TextBox();
            this.textb = new System.Windows.Forms.TextBox();
            this.tongg = new System.Windows.Forms.Button();
            this.again = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.labelTong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lba
            // 
            this.lba.AutoSize = true;
            this.lba.Location = new System.Drawing.Point(74, 76);
            this.lba.Name = "lba";
            this.lba.Size = new System.Drawing.Size(73, 20);
            this.lba.TabIndex = 0;
            this.lba.Text = "Nhập a =";
            // 
            // lbb
            // 
            this.lbb.AutoSize = true;
            this.lbb.Location = new System.Drawing.Point(74, 155);
            this.lbb.Name = "lbb";
            this.lbb.Size = new System.Drawing.Size(73, 20);
            this.lbb.TabIndex = 1;
            this.lbb.Text = "Nhập b =";
            // 
            // texta
            // 
            this.texta.Location = new System.Drawing.Point(175, 73);
            this.texta.Name = "texta";
            this.texta.Size = new System.Drawing.Size(192, 26);
            this.texta.TabIndex = 2;
            // 
            // textb
            // 
            this.textb.Location = new System.Drawing.Point(175, 149);
            this.textb.Name = "textb";
            this.textb.Size = new System.Drawing.Size(192, 26);
            this.textb.TabIndex = 3;
            // 
            // tongg
            // 
            this.tongg.Location = new System.Drawing.Point(78, 257);
            this.tongg.Name = "tongg";
            this.tongg.Size = new System.Drawing.Size(109, 32);
            this.tongg.TabIndex = 5;
            this.tongg.Text = "Tổng";
            this.tongg.UseVisualStyleBackColor = true;
            this.tongg.Click += new System.EventHandler(this.Tong);
            // 
            // again
            // 
            this.again.Location = new System.Drawing.Point(317, 257);
            this.again.Name = "again";
            this.again.Size = new System.Drawing.Size(109, 32);
            this.again.TabIndex = 6;
            this.again.Text = "Làm lại";
            this.again.UseVisualStyleBackColor = true;
            this.again.Click += new System.EventHandler(this.Again);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(562, 257);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(115, 32);
            this.exit.TabIndex = 7;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Exit);
            // 
            // labelTong
            // 
            this.labelTong.AutoSize = true;
            this.labelTong.Location = new System.Drawing.Point(74, 197);
            this.labelTong.Name = "labelTong";
            this.labelTong.Size = new System.Drawing.Size(69, 20);
            this.labelTong.TabIndex = 8;
            this.labelTong.Text = "Tong la: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTong);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.again);
            this.Controls.Add(this.tongg);
            this.Controls.Add(this.textb);
            this.Controls.Add(this.texta);
            this.Controls.Add(this.lbb);
            this.Controls.Add(this.lba);
            this.Name = "Form1";
            this.Text = "Chuong trinh tinh tong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Again_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lba;
        private System.Windows.Forms.Label lbb;
        private System.Windows.Forms.TextBox texta;
        private System.Windows.Forms.TextBox textb;
        private System.Windows.Forms.Button tongg;
        private System.Windows.Forms.Button again;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label labelTong;
    }
}



namespace PC_Satis_19381023
{
    partial class Stok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stok));
            this.label1 = new System.Windows.Forms.Label();
            this.txtstokid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtstokadet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtstokfiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnstkkyt = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 13F);
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Urun ID";
            // 
            // txtstokid
            // 
            this.txtstokid.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstokid.Location = new System.Drawing.Point(169, 21);
            this.txtstokid.Margin = new System.Windows.Forms.Padding(4);
            this.txtstokid.Name = "txtstokid";
            this.txtstokid.ReadOnly = true;
            this.txtstokid.Size = new System.Drawing.Size(216, 31);
            this.txtstokid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 13F);
            this.label2.Location = new System.Drawing.Point(25, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alım Tarihi";
            // 
            // txtstokadet
            // 
            this.txtstokadet.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstokadet.Location = new System.Drawing.Point(169, 149);
            this.txtstokadet.Margin = new System.Windows.Forms.Padding(4);
            this.txtstokadet.Name = "txtstokadet";
            this.txtstokadet.Size = new System.Drawing.Size(216, 31);
            this.txtstokadet.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Display", 13F);
            this.label3.Location = new System.Drawing.Point(25, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alım Adedi";
            // 
            // txtstokfiyat
            // 
            this.txtstokfiyat.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstokfiyat.Location = new System.Drawing.Point(169, 213);
            this.txtstokfiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txtstokfiyat.Name = "txtstokfiyat";
            this.txtstokfiyat.Size = new System.Drawing.Size(216, 31);
            this.txtstokfiyat.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SF Pro Display", 13F);
            this.label4.Location = new System.Drawing.Point(25, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alım Fiyatı";
            // 
            // btnstkkyt
            // 
            this.btnstkkyt.BackColor = System.Drawing.Color.Lavender;
            this.btnstkkyt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstkkyt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstkkyt.Font = new System.Drawing.Font("SF Compact Display", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnstkkyt.ForeColor = System.Drawing.Color.Green;
            this.btnstkkyt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnstkkyt.Location = new System.Drawing.Point(97, 278);
            this.btnstkkyt.Name = "btnstkkyt";
            this.btnstkkyt.Size = new System.Drawing.Size(216, 62);
            this.btnstkkyt.TabIndex = 10;
            this.btnstkkyt.Text = "Stok Bilgisini Kaydet";
            this.btnstkkyt.UseVisualStyleBackColor = false;
            this.btnstkkyt.Click += new System.EventHandler(this.btnstkkyt_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 85);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(216, 31);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // Stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(411, 380);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnstkkyt);
            this.Controls.Add(this.txtstokfiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtstokadet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtstokid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("SF Pro Display", 12F);
            this.ForeColor = System.Drawing.Color.Snow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Stok";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Bilgisi Ekranı";
            this.Load += new System.EventHandler(this.Stok_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtstokadet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtstokfiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnstkkyt;
        public System.Windows.Forms.TextBox txtstokid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
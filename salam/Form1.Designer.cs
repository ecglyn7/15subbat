
namespace salam
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
            this.btn_ortalama = new System.Windows.Forms.Button();
            this.txtbox_isim = new System.Windows.Forms.TextBox();
            this.txtbox_p2 = new System.Windows.Forms.TextBox();
            this.txtbox_y1 = new System.Windows.Forms.TextBox();
            this.txtbox_p1 = new System.Windows.Forms.TextBox();
            this.txtbox_y2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ortalama
            // 
            this.btn_ortalama.Location = new System.Drawing.Point(368, 177);
            this.btn_ortalama.Name = "btn_ortalama";
            this.btn_ortalama.Size = new System.Drawing.Size(100, 23);
            this.btn_ortalama.TabIndex = 0;
            this.btn_ortalama.Text = "Ortalama Bul";
            this.btn_ortalama.UseVisualStyleBackColor = true;
            this.btn_ortalama.Click += new System.EventHandler(this.btn_ortalama_Click);
            // 
            // txtbox_isim
            // 
            this.txtbox_isim.Location = new System.Drawing.Point(368, 37);
            this.txtbox_isim.Name = "txtbox_isim";
            this.txtbox_isim.Size = new System.Drawing.Size(100, 20);
            this.txtbox_isim.TabIndex = 1;
            this.txtbox_isim.Validating += new System.ComponentModel.CancelEventHandler(this.txtbox_isim_Validating);
            // 
            // txtbox_p2
            // 
            this.txtbox_p2.Location = new System.Drawing.Point(368, 141);
            this.txtbox_p2.Name = "txtbox_p2";
            this.txtbox_p2.Size = new System.Drawing.Size(100, 20);
            this.txtbox_p2.TabIndex = 2;
            this.txtbox_p2.Validating += new System.ComponentModel.CancelEventHandler(this.txtbox_p2_Validating);
            // 
            // txtbox_y1
            // 
            this.txtbox_y1.Location = new System.Drawing.Point(368, 63);
            this.txtbox_y1.Name = "txtbox_y1";
            this.txtbox_y1.Size = new System.Drawing.Size(100, 20);
            this.txtbox_y1.TabIndex = 2;
            this.txtbox_y1.Validating += new System.ComponentModel.CancelEventHandler(this.txtbox_y1_Validating);
            // 
            // txtbox_p1
            // 
            this.txtbox_p1.Location = new System.Drawing.Point(368, 115);
            this.txtbox_p1.Name = "txtbox_p1";
            this.txtbox_p1.Size = new System.Drawing.Size(100, 20);
            this.txtbox_p1.TabIndex = 2;
            this.txtbox_p1.Validating += new System.ComponentModel.CancelEventHandler(this.txtbox_p1_Validating);
            // 
            // txtbox_y2
            // 
            this.txtbox_y2.Location = new System.Drawing.Point(368, 89);
            this.txtbox_y2.Name = "txtbox_y2";
            this.txtbox_y2.Size = new System.Drawing.Size(100, 20);
            this.txtbox_y2.TabIndex = 2;
            this.txtbox_y2.Validating += new System.ComponentModel.CancelEventHandler(this.txtbox_y2_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(289, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(289, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yazılı 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(289, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yazılı 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(242, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Performans 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(242, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Performans 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(364, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ortalama:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_y2);
            this.Controls.Add(this.txtbox_p1);
            this.Controls.Add(this.txtbox_y1);
            this.Controls.Add(this.txtbox_p2);
            this.Controls.Add(this.txtbox_isim);
            this.Controls.Add(this.btn_ortalama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ortalama;
        private System.Windows.Forms.TextBox txtbox_isim;
        private System.Windows.Forms.TextBox txtbox_p2;
        private System.Windows.Forms.TextBox txtbox_y1;
        private System.Windows.Forms.TextBox txtbox_p1;
        private System.Windows.Forms.TextBox txtbox_y2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}


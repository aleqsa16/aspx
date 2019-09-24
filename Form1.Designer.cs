namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblsaxeli = new System.Windows.Forms.Label();
            this.lblgvari = new System.Windows.Forms.Label();
            this.lblsex = new System.Windows.Forms.Label();
            this.txtsex = new System.Windows.Forms.ComboBox();
            this.lblnomeri = new System.Windows.Forms.Label();
            this.txtsaxeli = new System.Windows.Forms.TextBox();
            this.txtgvari = new System.Windows.Forms.TextBox();
            this.txtnomeri = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.lbldate = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblqveyana = new System.Windows.Forms.Label();
            this.lblqalaqi = new System.Windows.Forms.Label();
            this.lblmisamarti = new System.Windows.Forms.Label();
            this.txtqveyana = new System.Windows.Forms.TextBox();
            this.txtqalaqi = new System.Windows.Forms.TextBox();
            this.txtmisamarti = new System.Windows.Forms.TextBox();
            this.rtbsum = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "გაუქმება";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(443, 557);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "შენახვა";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbldate);
            this.groupBox1.Controls.Add(this.txtdate);
            this.groupBox1.Controls.Add(this.txtnomeri);
            this.groupBox1.Controls.Add(this.txtgvari);
            this.groupBox1.Controls.Add(this.txtsaxeli);
            this.groupBox1.Controls.Add(this.lblnomeri);
            this.groupBox1.Controls.Add(this.txtsex);
            this.groupBox1.Controls.Add(this.lblsex);
            this.groupBox1.Controls.Add(this.lblgvari);
            this.groupBox1.Controls.Add(this.lblsaxeli);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 274);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "პარიკმახერის ინფორმაცია";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 139);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblsaxeli
            // 
            this.lblsaxeli.AutoSize = true;
            this.lblsaxeli.Location = new System.Drawing.Point(265, 50);
            this.lblsaxeli.Name = "lblsaxeli";
            this.lblsaxeli.Size = new System.Drawing.Size(49, 13);
            this.lblsaxeli.TabIndex = 1;
            this.lblsaxeli.Text = "სახელი";
            // 
            // lblgvari
            // 
            this.lblgvari.AutoSize = true;
            this.lblgvari.Location = new System.Drawing.Point(265, 89);
            this.lblgvari.Name = "lblgvari";
            this.lblgvari.Size = new System.Drawing.Size(39, 13);
            this.lblgvari.TabIndex = 2;
            this.lblgvari.Text = "გვარი";
            this.lblgvari.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblsex
            // 
            this.lblsex.AutoSize = true;
            this.lblsex.Location = new System.Drawing.Point(265, 131);
            this.lblsex.Name = "lblsex";
            this.lblsex.Size = new System.Drawing.Size(35, 13);
            this.lblsex.TabIndex = 3;
            this.lblsex.Text = "სქესი";
            // 
            // txtsex
            // 
            this.txtsex.FormattingEnabled = true;
            this.txtsex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Agender",
            "Androgyne",
            "Androgynous",
            "Bigender",
            "Cis",
            "Cisgender",
            "Cis Female",
            "Cis Male",
            "Cis Man",
            "Cis Woman",
            "Cisgender Female",
            "Cisgender Male",
            "Cisgender Man",
            "Cisgender Woman",
            "Female to Male",
            "FTM",
            "Gender Fluid",
            "Gender Nonconforming",
            "Gender Questioning",
            "Gender Variant",
            "Genderqueer",
            "Intersex",
            "Male to Female",
            "MTF",
            "Neither",
            "Neutrois",
            "Non-binary",
            "Other",
            "Pangender",
            "Trans",
            "Trans*",
            "Trans Female",
            "Trans* Female",
            "Trans Male",
            "Trans* Male",
            "Trans Man",
            "Trans* Man",
            "Trans Person",
            "Trans* Person",
            "Trans Woman",
            "Trans* Woman",
            "Transfeminine",
            "Transgender",
            "Transgender Female",
            "Transgender Male",
            "Transgender Man",
            "Transgender Person",
            "Transgender Woman",
            "Transmasculine",
            "Transsexual",
            "Transsexual Female",
            "Transsexual Male",
            "Transsexual Man",
            "Transsexual Person",
            "Transsexual Woman",
            "Two-Spirit"});
            this.txtsex.Location = new System.Drawing.Point(341, 128);
            this.txtsex.Name = "txtsex";
            this.txtsex.Size = new System.Drawing.Size(100, 21);
            this.txtsex.TabIndex = 6;
            // 
            // lblnomeri
            // 
            this.lblnomeri.AutoSize = true;
            this.lblnomeri.Location = new System.Drawing.Point(265, 176);
            this.lblnomeri.Name = "lblnomeri";
            this.lblnomeri.Size = new System.Drawing.Size(47, 13);
            this.lblnomeri.TabIndex = 8;
            this.lblnomeri.Text = "ნომერი";
            // 
            // txtsaxeli
            // 
            this.txtsaxeli.Location = new System.Drawing.Point(341, 47);
            this.txtsaxeli.Name = "txtsaxeli";
            this.txtsaxeli.Size = new System.Drawing.Size(100, 20);
            this.txtsaxeli.TabIndex = 9;
            // 
            // txtgvari
            // 
            this.txtgvari.Location = new System.Drawing.Point(341, 86);
            this.txtgvari.Name = "txtgvari";
            this.txtgvari.Size = new System.Drawing.Size(100, 20);
            this.txtgvari.TabIndex = 10;
            // 
            // txtnomeri
            // 
            this.txtnomeri.Location = new System.Drawing.Point(341, 176);
            this.txtnomeri.Name = "txtnomeri";
            this.txtnomeri.Size = new System.Drawing.Size(100, 20);
            this.txtnomeri.TabIndex = 11;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(341, 227);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(200, 20);
            this.txtdate.TabIndex = 12;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(238, 233);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(76, 13);
            this.lbldate.TabIndex = 13;
            this.lbldate.Text = "დაბ თარიღი";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtmisamarti);
            this.groupBox2.Controls.Add(this.txtqalaqi);
            this.groupBox2.Controls.Add(this.txtqveyana);
            this.groupBox2.Controls.Add(this.lblmisamarti);
            this.groupBox2.Controls.Add(this.lblqalaqi);
            this.groupBox2.Controls.Add(this.lblqveyana);
            this.groupBox2.Location = new System.Drawing.Point(0, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 179);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "მისამართი";
            // 
            // lblqveyana
            // 
            this.lblqveyana.AutoSize = true;
            this.lblqveyana.Location = new System.Drawing.Point(26, 34);
            this.lblqveyana.Name = "lblqveyana";
            this.lblqveyana.Size = new System.Drawing.Size(47, 13);
            this.lblqveyana.TabIndex = 0;
            this.lblqveyana.Text = "ქვეყანა";
            // 
            // lblqalaqi
            // 
            this.lblqalaqi.AutoSize = true;
            this.lblqalaqi.Location = new System.Drawing.Point(26, 75);
            this.lblqalaqi.Name = "lblqalaqi";
            this.lblqalaqi.Size = new System.Drawing.Size(45, 13);
            this.lblqalaqi.TabIndex = 1;
            this.lblqalaqi.Text = "ქალაქი";
            // 
            // lblmisamarti
            // 
            this.lblmisamarti.AutoSize = true;
            this.lblmisamarti.Location = new System.Drawing.Point(26, 116);
            this.lblmisamarti.Name = "lblmisamarti";
            this.lblmisamarti.Size = new System.Drawing.Size(67, 13);
            this.lblmisamarti.TabIndex = 2;
            this.lblmisamarti.Text = "მისამართი";
            // 
            // txtqveyana
            // 
            this.txtqveyana.Location = new System.Drawing.Point(119, 31);
            this.txtqveyana.Name = "txtqveyana";
            this.txtqveyana.Size = new System.Drawing.Size(100, 20);
            this.txtqveyana.TabIndex = 3;
            // 
            // txtqalaqi
            // 
            this.txtqalaqi.Location = new System.Drawing.Point(119, 75);
            this.txtqalaqi.Name = "txtqalaqi";
            this.txtqalaqi.Size = new System.Drawing.Size(100, 20);
            this.txtqalaqi.TabIndex = 4;
            // 
            // txtmisamarti
            // 
            this.txtmisamarti.Location = new System.Drawing.Point(119, 113);
            this.txtmisamarti.Name = "txtmisamarti";
            this.txtmisamarti.Size = new System.Drawing.Size(100, 20);
            this.txtmisamarti.TabIndex = 5;
            // 
            // rtbsum
            // 
            this.rtbsum.Location = new System.Drawing.Point(316, 294);
            this.rtbsum.Name = "rtbsum";
            this.rtbsum.Size = new System.Drawing.Size(314, 243);
            this.rtbsum.TabIndex = 16;
            this.rtbsum.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 592);
            this.Controls.Add(this.rtbsum);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblsex;
        private System.Windows.Forms.Label lblgvari;
        private System.Windows.Forms.Label lblsaxeli;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox txtsex;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.TextBox txtnomeri;
        private System.Windows.Forms.TextBox txtgvari;
        private System.Windows.Forms.TextBox txtsaxeli;
        private System.Windows.Forms.Label lblnomeri;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtmisamarti;
        private System.Windows.Forms.TextBox txtqalaqi;
        private System.Windows.Forms.TextBox txtqveyana;
        private System.Windows.Forms.Label lblmisamarti;
        private System.Windows.Forms.Label lblqalaqi;
        private System.Windows.Forms.Label lblqveyana;
        private System.Windows.Forms.RichTextBox rtbsum;

    }
}


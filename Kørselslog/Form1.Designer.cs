namespace Kørselslog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_navn = new System.Windows.Forms.TextBox();
            this.txt_nummerplade = new System.Windows.Forms.TextBox();
            this.button_opret = new System.Windows.Forms.Button();
            this.button_redigere = new System.Windows.Forms.Button();
            this.txt_rediNummerPlade = new System.Windows.Forms.TextBox();
            this.txt_rediNavn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_kørselslog = new System.Windows.Forms.Button();
            this.txt_SletBruger = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_tabellen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opret bruger";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Navn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "NummerPlade";
            // 
            // txt_navn
            // 
            this.txt_navn.Location = new System.Drawing.Point(121, 152);
            this.txt_navn.Name = "txt_navn";
            this.txt_navn.Size = new System.Drawing.Size(122, 20);
            this.txt_navn.TabIndex = 3;
            this.txt_navn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_nummerplade
            // 
            this.txt_nummerplade.Location = new System.Drawing.Point(121, 195);
            this.txt_nummerplade.Name = "txt_nummerplade";
            this.txt_nummerplade.Size = new System.Drawing.Size(122, 20);
            this.txt_nummerplade.TabIndex = 4;
            this.txt_nummerplade.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button_opret
            // 
            this.button_opret.Location = new System.Drawing.Point(168, 241);
            this.button_opret.Name = "button_opret";
            this.button_opret.Size = new System.Drawing.Size(75, 23);
            this.button_opret.TabIndex = 5;
            this.button_opret.Text = "Opret";
            this.button_opret.UseVisualStyleBackColor = true;
            this.button_opret.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_redigere
            // 
            this.button_redigere.Location = new System.Drawing.Point(401, 241);
            this.button_redigere.Name = "button_redigere";
            this.button_redigere.Size = new System.Drawing.Size(75, 23);
            this.button_redigere.TabIndex = 12;
            this.button_redigere.Text = "Redigere";
            this.button_redigere.UseVisualStyleBackColor = true;
            this.button_redigere.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_rediNummerPlade
            // 
            this.txt_rediNummerPlade.Location = new System.Drawing.Point(401, 195);
            this.txt_rediNummerPlade.Name = "txt_rediNummerPlade";
            this.txt_rediNummerPlade.Size = new System.Drawing.Size(122, 20);
            this.txt_rediNummerPlade.TabIndex = 11;
            this.txt_rediNummerPlade.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // txt_rediNavn
            // 
            this.txt_rediNavn.Location = new System.Drawing.Point(401, 152);
            this.txt_rediNavn.Name = "txt_rediNavn";
            this.txt_rediNavn.Size = new System.Drawing.Size(122, 20);
            this.txt_rediNavn.TabIndex = 10;
            this.txt_rediNavn.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "NummerPlade";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(285, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Navn";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(282, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 31);
            this.label6.TabIndex = 7;
            this.label6.Text = "Redigere bruger";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button_kørselslog
            // 
            this.button_kørselslog.Location = new System.Drawing.Point(168, 21);
            this.button_kørselslog.Name = "button_kørselslog";
            this.button_kørselslog.Size = new System.Drawing.Size(145, 32);
            this.button_kørselslog.TabIndex = 14;
            this.button_kørselslog.Text = "Gå til kørselslog";
            this.button_kørselslog.UseVisualStyleBackColor = true;
            this.button_kørselslog.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // txt_SletBruger
            // 
            this.txt_SletBruger.Location = new System.Drawing.Point(611, 152);
            this.txt_SletBruger.Name = "txt_SletBruger";
            this.txt_SletBruger.Size = new System.Drawing.Size(122, 20);
            this.txt_SletBruger.TabIndex = 17;
            this.txt_SletBruger.TextChanged += new System.EventHandler(this.textBox1_TextChanged_3);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(546, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Navn";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(584, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 31);
            this.label8.TabIndex = 15;
            this.label8.Text = "Slet Bruger";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(611, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Slet Bruger";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(466, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Skrive et navn fra tabellen";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Tabel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_tabellen
            // 
            this.button_tabellen.Location = new System.Drawing.Point(541, 21);
            this.button_tabellen.Name = "button_tabellen";
            this.button_tabellen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_tabellen.Size = new System.Drawing.Size(164, 32);
            this.button_tabellen.TabIndex = 21;
            this.button_tabellen.Text = "Se tabellen/Update tabellen";
            this.button_tabellen.UseVisualStyleBackColor = true;
            this.button_tabellen.Click += new System.EventHandler(this.button_tabellen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(289, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(236, 158);
            this.dataGridView1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_tabellen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_SletBruger);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_kørselslog);
            this.Controls.Add(this.button_redigere);
            this.Controls.Add(this.txt_rediNummerPlade);
            this.Controls.Add(this.txt_rediNavn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_opret);
            this.Controls.Add(this.txt_nummerplade);
            this.Controls.Add(this.txt_navn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bruger Håndtering";
            this.Load += new System.EventHandler(this.Brugerhåndtering_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_navn;
        private System.Windows.Forms.TextBox txt_nummerplade;
        private System.Windows.Forms.Button button_opret;
        private System.Windows.Forms.Button button_redigere;
        private System.Windows.Forms.TextBox txt_rediNummerPlade;
        private System.Windows.Forms.TextBox txt_rediNavn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_kørselslog;
        private System.Windows.Forms.TextBox txt_SletBruger;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_tabellen;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


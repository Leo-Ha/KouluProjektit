namespace SqlWindows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(66, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 119);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(14, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 57);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 28F);
            this.label1.Location = new System.Drawing.Point(108, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opiskelijatietokanta";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(66, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(654, 327);
            this.panel3.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.textBox7);
            this.panel6.Location = new System.Drawing.Point(450, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(187, 42);
            this.panel6.TabIndex = 0;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(12, 11);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(165, 20);
            this.textBox7.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.exit);
            this.panel5.Controls.Add(this.print);
            this.panel5.Controls.Add(this.reset);
            this.panel5.Controls.Add(this.delete);
            this.panel5.Controls.Add(this.update);
            this.panel5.Controls.Add(this.add);
            this.panel5.Location = new System.Drawing.Point(450, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(187, 255);
            this.panel5.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.exit.Location = new System.Drawing.Point(14, 221);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(160, 30);
            this.exit.TabIndex = 5;
            this.exit.Text = "Poistu";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.print.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.print.Location = new System.Drawing.Point(14, 178);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(160, 30);
            this.print.TabIndex = 4;
            this.print.Text = "Tulosta";
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.reset.Location = new System.Drawing.Point(14, 134);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(160, 30);
            this.reset.TabIndex = 3;
            this.reset.Text = "Tyhjennä";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.button3_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.delete.Location = new System.Drawing.Point(14, 92);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(160, 30);
            this.delete.TabIndex = 2;
            this.delete.Text = "Poista";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.button4_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.update.Location = new System.Drawing.Point(14, 50);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(160, 30);
            this.update.TabIndex = 1;
            this.update.Text = "Päivitä";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(14, 5);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(160, 30);
            this.add.TabIndex = 0;
            this.add.Text = "Lisää";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.textBox5);
            this.panel4.Controls.Add(this.textBox6);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(14, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(430, 303);
            this.panel4.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(391, 96);
            this.dataGridView1.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(38, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "Puhelin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(38, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "Postinumero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(38, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "Osoite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(38, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sukunimi";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(147, 178);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(261, 20);
            this.textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(147, 148);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(261, 20);
            this.textBox6.TabIndex = 14;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(147, 112);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(261, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(147, 82);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(261, 20);
            this.textBox4.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(261, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(38, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Etunimi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(38, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}


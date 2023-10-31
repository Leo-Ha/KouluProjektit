namespace FormsProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.ResultsPanel = new System.Windows.Forms.ListBox();
            this.MakeTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.BodyTextBox = new System.Windows.Forms.TextBox();
            this.FuelTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.Teal;
            this.SearchBox.Font = new System.Drawing.Font("Arial", 20F);
            this.SearchBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.SearchBox.Location = new System.Drawing.Point(14, 27);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(293, 38);
            this.SearchBox.TabIndex = 0;
            this.SearchBox.Text = "Haku";
            this.SearchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ResultsPanel
            // 
            this.ResultsPanel.BackColor = System.Drawing.Color.Teal;
            this.ResultsPanel.Font = new System.Drawing.Font("Arial", 15F);
            this.ResultsPanel.ForeColor = System.Drawing.SystemColors.Menu;
            this.ResultsPanel.FormattingEnabled = true;
            this.ResultsPanel.ItemHeight = 23;
            this.ResultsPanel.Location = new System.Drawing.Point(14, 82);
            this.ResultsPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ResultsPanel.Name = "ResultsPanel";
            this.ResultsPanel.Size = new System.Drawing.Size(289, 441);
            this.ResultsPanel.TabIndex = 1;
            this.ResultsPanel.SelectedIndexChanged += new System.EventHandler(this.ResultsPanel_SelectedIndexChanged);
            // 
            // MakeTextBox
            // 
            this.MakeTextBox.BackColor = System.Drawing.Color.LightSeaGreen;
            this.MakeTextBox.Font = new System.Drawing.Font("Arial", 20F);
            this.MakeTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.MakeTextBox.Location = new System.Drawing.Point(394, 42);
            this.MakeTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MakeTextBox.Name = "MakeTextBox";
            this.MakeTextBox.Size = new System.Drawing.Size(209, 38);
            this.MakeTextBox.TabIndex = 2;
            this.MakeTextBox.Text = "Merkki";
            this.MakeTextBox.TextChanged += new System.EventHandler(this.Make_TextChanged);
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ModelTextBox.Font = new System.Drawing.Font("Arial", 20F);
            this.ModelTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.ModelTextBox.Location = new System.Drawing.Point(394, 144);
            this.ModelTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(209, 38);
            this.ModelTextBox.TabIndex = 3;
            this.ModelTextBox.Text = "Malli";
            this.ModelTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // YearTextBox
            // 
            this.YearTextBox.BackColor = System.Drawing.Color.LightSeaGreen;
            this.YearTextBox.Font = new System.Drawing.Font("Arial", 20F);
            this.YearTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.YearTextBox.Location = new System.Drawing.Point(394, 253);
            this.YearTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(209, 38);
            this.YearTextBox.TabIndex = 4;
            this.YearTextBox.Text = "Vuosimalli";
            this.YearTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BodyTextBox
            // 
            this.BodyTextBox.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BodyTextBox.Font = new System.Drawing.Font("Arial", 20F);
            this.BodyTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.BodyTextBox.Location = new System.Drawing.Point(394, 363);
            this.BodyTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BodyTextBox.Name = "BodyTextBox";
            this.BodyTextBox.Size = new System.Drawing.Size(209, 38);
            this.BodyTextBox.TabIndex = 5;
            this.BodyTextBox.Text = "Korimalli";
            this.BodyTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // FuelTextBox
            // 
            this.FuelTextBox.BackColor = System.Drawing.Color.LightSeaGreen;
            this.FuelTextBox.Font = new System.Drawing.Font("Arial", 20F);
            this.FuelTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.FuelTextBox.Location = new System.Drawing.Point(394, 479);
            this.FuelTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FuelTextBox.Name = "FuelTextBox";
            this.FuelTextBox.Size = new System.Drawing.Size(209, 38);
            this.FuelTextBox.TabIndex = 6;
            this.FuelTextBox.Text = "Polttoaine";
            this.FuelTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SearchButton.Font = new System.Drawing.Font("Arial", 23F);
            this.SearchButton.ForeColor = System.Drawing.Color.Snow;
            this.SearchButton.Location = new System.Drawing.Point(725, 22);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(153, 77);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Hae";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.UpdateButton.Font = new System.Drawing.Font("Arial", 23F);
            this.UpdateButton.ForeColor = System.Drawing.Color.Snow;
            this.UpdateButton.Location = new System.Drawing.Point(725, 233);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(153, 77);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "Päivitä";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.AddButton.Font = new System.Drawing.Font("Arial", 23F);
            this.AddButton.ForeColor = System.Drawing.Color.Snow;
            this.AddButton.Location = new System.Drawing.Point(725, 124);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(153, 77);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Lisää";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClearButton.Font = new System.Drawing.Font("Arial", 23F);
            this.ClearButton.ForeColor = System.Drawing.Color.Snow;
            this.ClearButton.Location = new System.Drawing.Point(725, 343);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(153, 77);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Tyhjennä";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.DeleteButton.Font = new System.Drawing.Font("Arial", 23F);
            this.DeleteButton.ForeColor = System.Drawing.Color.Snow;
            this.DeleteButton.Location = new System.Drawing.Point(725, 446);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(153, 77);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "Poista";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.FuelTextBox);
            this.Controls.Add(this.BodyTextBox);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.MakeTextBox);
            this.Controls.Add(this.ResultsPanel);
            this.Controls.Add(this.SearchBox);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.ListBox ResultsPanel;
        private System.Windows.Forms.TextBox MakeTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.TextBox BodyTextBox;
        private System.Windows.Forms.TextBox FuelTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}


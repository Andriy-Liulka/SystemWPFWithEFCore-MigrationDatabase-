
namespace ExamProjectWinForms
{
    partial class Menu
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
            System.Windows.Forms.Label Genre_textBlock;
            this.ChooseAuthor_Combobox = new System.Windows.Forms.ComboBox();
            this.ChooseAuthor_textBlock = new System.Windows.Forms.Label();
            this.Name_textBlock = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.QuantityOfPages_textBox = new System.Windows.Forms.TextBox();
            this.QuantityOfPages_textBlock = new System.Windows.Forms.Label();
            this.VersionName_textBlock = new System.Windows.Forms.Label();
            this.VersionName_textBox = new System.Windows.Forms.TextBox();
            this.Genre_textBox = new System.Windows.Forms.TextBox();
            this.HasSequel_checkBox = new System.Windows.Forms.CheckBox();
            this.AddBook_button = new System.Windows.Forms.Button();
            Genre_textBlock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Genre_textBlock
            // 
            Genre_textBlock.AutoSize = true;
            Genre_textBlock.Location = new System.Drawing.Point(542, 34);
            Genre_textBlock.Name = "Genre_textBlock";
            Genre_textBlock.Size = new System.Drawing.Size(38, 15);
            Genre_textBlock.TabIndex = 9;
            Genre_textBlock.Text = "Genre";
            // 
            // ChooseAuthor_Combobox
            // 
            this.ChooseAuthor_Combobox.FormattingEnabled = true;
            this.ChooseAuthor_Combobox.Location = new System.Drawing.Point(322, 415);
            this.ChooseAuthor_Combobox.Name = "ChooseAuthor_Combobox";
            this.ChooseAuthor_Combobox.Size = new System.Drawing.Size(121, 23);
            this.ChooseAuthor_Combobox.TabIndex = 0;
            // 
            // ChooseAuthor_textBlock
            // 
            this.ChooseAuthor_textBlock.AutoSize = true;
            this.ChooseAuthor_textBlock.Location = new System.Drawing.Point(322, 384);
            this.ChooseAuthor_textBlock.Name = "ChooseAuthor_textBlock";
            this.ChooseAuthor_textBlock.Size = new System.Drawing.Size(84, 15);
            this.ChooseAuthor_textBlock.TabIndex = 1;
            this.ChooseAuthor_textBlock.Text = "ChooseAuthor";
            // 
            // Name_textBlock
            // 
            this.Name_textBlock.AutoSize = true;
            this.Name_textBlock.Location = new System.Drawing.Point(120, 34);
            this.Name_textBlock.Name = "Name_textBlock";
            this.Name_textBlock.Size = new System.Drawing.Size(39, 15);
            this.Name_textBlock.TabIndex = 2;
            this.Name_textBlock.Text = "Name";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(79, 65);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(136, 23);
            this.Name_textBox.TabIndex = 3;
            // 
            // QuantityOfPages_textBox
            // 
            this.QuantityOfPages_textBox.Location = new System.Drawing.Point(387, 63);
            this.QuantityOfPages_textBox.Name = "QuantityOfPages_textBox";
            this.QuantityOfPages_textBox.Size = new System.Drawing.Size(114, 23);
            this.QuantityOfPages_textBox.TabIndex = 7;
            // 
            // QuantityOfPages_textBlock
            // 
            this.QuantityOfPages_textBlock.AutoSize = true;
            this.QuantityOfPages_textBlock.Location = new System.Drawing.Point(387, 34);
            this.QuantityOfPages_textBlock.Name = "QuantityOfPages_textBlock";
            this.QuantityOfPages_textBlock.Size = new System.Drawing.Size(101, 15);
            this.QuantityOfPages_textBlock.TabIndex = 6;
            this.QuantityOfPages_textBlock.Text = "Quantity of pages";
            // 
            // VersionName_textBlock
            // 
            this.VersionName_textBlock.AutoSize = true;
            this.VersionName_textBlock.Location = new System.Drawing.Point(256, 34);
            this.VersionName_textBlock.Name = "VersionName_textBlock";
            this.VersionName_textBlock.Size = new System.Drawing.Size(78, 15);
            this.VersionName_textBlock.TabIndex = 5;
            this.VersionName_textBlock.Text = "VersionName";
            // 
            // VersionName_textBox
            // 
            this.VersionName_textBox.Location = new System.Drawing.Point(240, 65);
            this.VersionName_textBox.Name = "VersionName_textBox";
            this.VersionName_textBox.Size = new System.Drawing.Size(118, 23);
            this.VersionName_textBox.TabIndex = 8;
            // 
            // Genre_textBox
            // 
            this.Genre_textBox.Location = new System.Drawing.Point(511, 63);
            this.Genre_textBox.Name = "Genre_textBox";
            this.Genre_textBox.Size = new System.Drawing.Size(100, 23);
            this.Genre_textBox.TabIndex = 10;
            // 
            // HasSequel_checkBox
            // 
            this.HasSequel_checkBox.AutoSize = true;
            this.HasSequel_checkBox.Location = new System.Drawing.Point(635, 65);
            this.HasSequel_checkBox.Name = "HasSequel_checkBox";
            this.HasSequel_checkBox.Size = new System.Drawing.Size(92, 19);
            this.HasSequel_checkBox.TabIndex = 11;
            this.HasSequel_checkBox.Text = "Has a sequel";
            this.HasSequel_checkBox.UseVisualStyleBackColor = true;
            // 
            // AddBook_button
            // 
            this.AddBook_button.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddBook_button.Location = new System.Drawing.Point(322, 108);
            this.AddBook_button.Name = "AddBook_button";
            this.AddBook_button.Size = new System.Drawing.Size(188, 40);
            this.AddBook_button.TabIndex = 12;
            this.AddBook_button.Text = "Add";
            this.AddBook_button.UseVisualStyleBackColor = true;
            this.AddBook_button.Click += new System.EventHandler(this.AddBook_button_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddBook_button);
            this.Controls.Add(this.HasSequel_checkBox);
            this.Controls.Add(this.Genre_textBox);
            this.Controls.Add(Genre_textBlock);
            this.Controls.Add(this.VersionName_textBox);
            this.Controls.Add(this.QuantityOfPages_textBox);
            this.Controls.Add(this.QuantityOfPages_textBlock);
            this.Controls.Add(this.VersionName_textBlock);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Name_textBlock);
            this.Controls.Add(this.ChooseAuthor_textBlock);
            this.Controls.Add(this.ChooseAuthor_Combobox);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ChooseAuthor_Combobox;
        private System.Windows.Forms.Label ChooseAuthor_textBlock;
        private System.Windows.Forms.Label Name_textBlock;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TextBox QuantityOfPages_textBox;
        private System.Windows.Forms.Label QuantityOfPages_textBlock;
        private System.Windows.Forms.Label VersionName_textBlock;
        private System.Windows.Forms.TextBox VersionName_textBox;
        private System.Windows.Forms.TextBox Genre_textBox;
        private System.Windows.Forms.Label Genre_textBlock;
        private System.Windows.Forms.CheckBox HasSequel_checkBox;
        private System.Windows.Forms.Button AddBook_button;
    }
}
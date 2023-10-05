namespace Anket_Task
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            LoadTextBox = new TextBox();
            Load_Button = new Button();
            AnketGroupBox = new GroupBox();
            GenderLabel = new Label();
            FemaleRadioButton = new RadioButton();
            MaleRadioButton = new RadioButton();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            PhoneNumberTextBox = new TextBox();
            PhoneLabel = new Label();
            CityTextBox = new TextBox();
            CityLabel = new Label();
            CountryTextBox = new TextBox();
            label2 = new Label();
            FatherNameTextBox = new TextBox();
            FatherNameLabel = new Label();
            SurnameTextBox = new TextBox();
            label1 = new Label();
            NameTextBox = new TextBox();
            Name_Label = new Label();
            SaveButton = new Button();
            AnketGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // LoadTextBox
            // 
            LoadTextBox.Location = new Point(30, 12);
            LoadTextBox.Name = "LoadTextBox";
            LoadTextBox.Size = new Size(215, 23);
            LoadTextBox.TabIndex = 0;
            // 
            // Load_Button
            // 
            Load_Button.BackgroundImage = Properties.Resources.Button_PNG_Free_Image;
            Load_Button.BackgroundImageLayout = ImageLayout.Stretch;
            Load_Button.FlatStyle = FlatStyle.Popup;
            Load_Button.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Load_Button.ForeColor = SystemColors.ButtonHighlight;
            Load_Button.Image = Properties.Resources.Button_PNG_Free_Image;
            Load_Button.Location = new Point(251, 12);
            Load_Button.Name = "Load_Button";
            Load_Button.Size = new Size(69, 23);
            Load_Button.TabIndex = 1;
            Load_Button.Text = "Load";
            Load_Button.UseVisualStyleBackColor = true;
            Load_Button.Click += Load_Button_Click;
            // 
            // AnketGroupBox
            // 
            AnketGroupBox.BackColor = Color.Lavender;
            AnketGroupBox.Controls.Add(GenderLabel);
            AnketGroupBox.Controls.Add(FemaleRadioButton);
            AnketGroupBox.Controls.Add(MaleRadioButton);
            AnketGroupBox.Controls.Add(label3);
            AnketGroupBox.Controls.Add(dateTimePicker1);
            AnketGroupBox.Controls.Add(PhoneNumberTextBox);
            AnketGroupBox.Controls.Add(PhoneLabel);
            AnketGroupBox.Controls.Add(CityTextBox);
            AnketGroupBox.Controls.Add(CityLabel);
            AnketGroupBox.Controls.Add(CountryTextBox);
            AnketGroupBox.Controls.Add(label2);
            AnketGroupBox.Controls.Add(FatherNameTextBox);
            AnketGroupBox.Controls.Add(FatherNameLabel);
            AnketGroupBox.Controls.Add(SurnameTextBox);
            AnketGroupBox.Controls.Add(label1);
            AnketGroupBox.Controls.Add(NameTextBox);
            AnketGroupBox.Controls.Add(Name_Label);
            AnketGroupBox.FlatStyle = FlatStyle.Popup;
            AnketGroupBox.Location = new Point(12, 61);
            AnketGroupBox.Name = "AnketGroupBox";
            AnketGroupBox.RightToLeft = RightToLeft.No;
            AnketGroupBox.Size = new Size(338, 318);
            AnketGroupBox.TabIndex = 2;
            AnketGroupBox.TabStop = false;
            AnketGroupBox.Text = "Anket";
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            GenderLabel.Location = new Point(15, 279);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(51, 15);
            GenderLabel.TabIndex = 16;
            GenderLabel.Text = "Gender";
            // 
            // FemaleRadioButton
            // 
            FemaleRadioButton.AutoSize = true;
            FemaleRadioButton.Location = new Point(150, 279);
            FemaleRadioButton.Name = "FemaleRadioButton";
            FemaleRadioButton.Size = new Size(63, 19);
            FemaleRadioButton.TabIndex = 15;
            FemaleRadioButton.TabStop = true;
            FemaleRadioButton.Text = "Female";
            FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            MaleRadioButton.AutoSize = true;
            MaleRadioButton.Location = new Point(84, 279);
            MaleRadioButton.Name = "MaleRadioButton";
            MaleRadioButton.Size = new Size(51, 19);
            MaleRadioButton.TabIndex = 14;
            MaleRadioButton.TabStop = true;
            MaleRadioButton.Text = "Male";
            MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(6, 238);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 13;
            label3.Text = "Birth Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(88, 232);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(233, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(88, 193);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(233, 23);
            PhoneNumberTextBox.TabIndex = 11;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            PhoneLabel.Location = new Point(6, 196);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(70, 15);
            PhoneLabel.TabIndex = 10;
            PhoneLabel.Text = "Telephone";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(88, 164);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(233, 23);
            CityTextBox.TabIndex = 9;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            CityLabel.Location = new Point(6, 167);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(31, 15);
            CityLabel.TabIndex = 8;
            CityLabel.Text = "City";
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(88, 135);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(233, 23);
            CountryTextBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(6, 138);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 6;
            label2.Text = "Country";
            // 
            // FatherNameTextBox
            // 
            FatherNameTextBox.Location = new Point(88, 84);
            FatherNameTextBox.Name = "FatherNameTextBox";
            FatherNameTextBox.Size = new Size(233, 23);
            FatherNameTextBox.TabIndex = 5;
            // 
            // FatherNameLabel
            // 
            FatherNameLabel.AutoSize = true;
            FatherNameLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            FatherNameLabel.Location = new Point(0, 87);
            FatherNameLabel.Name = "FatherNameLabel";
            FatherNameLabel.Size = new Size(93, 15);
            FatherNameLabel.TabIndex = 4;
            FatherNameLabel.Text = "Father's name";
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Location = new Point(88, 55);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(233, 23);
            SurnameTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(6, 58);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 2;
            label1.Text = "Surname";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(88, 26);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(233, 23);
            NameTextBox.TabIndex = 1;
            // 
            // Name_Label
            // 
            Name_Label.AutoSize = true;
            Name_Label.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Name_Label.Location = new Point(6, 29);
            Name_Label.Name = "Name_Label";
            Name_Label.Size = new Size(43, 15);
            Name_Label.TabIndex = 0;
            Name_Label.Text = "Name";
            // 
            // SaveButton
            // 
            SaveButton.BackgroundImageLayout = ImageLayout.Stretch;
            SaveButton.FlatStyle = FlatStyle.Popup;
            SaveButton.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            SaveButton.ForeColor = SystemColors.ButtonHighlight;
            SaveButton.Image = Properties.Resources.Button_PNG_Free_Image;
            SaveButton.Location = new Point(12, 397);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(338, 39);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.anket_background;
            ClientSize = new Size(362, 448);
            Controls.Add(SaveButton);
            Controls.Add(AnketGroupBox);
            Controls.Add(Load_Button);
            Controls.Add(LoadTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Anket";
            AnketGroupBox.ResumeLayout(false);
            AnketGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoadTextBox;
        private Button Load_Button;
        private GroupBox AnketGroupBox;
        private Label Name_Label;
        private TextBox SurnameTextBox;
        private Label label1;
        private TextBox NameTextBox;
        private TextBox FatherNameTextBox;
        private Label FatherNameLabel;
        private TextBox PhoneNumberTextBox;
        private Label PhoneLabel;
        private TextBox CityTextBox;
        private Label CityLabel;
        private TextBox CountryTextBox;
        private Label label2;
        private Label GenderLabel;
        private RadioButton FemaleRadioButton;
        private RadioButton MaleRadioButton;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Button SaveButton;
    }
}
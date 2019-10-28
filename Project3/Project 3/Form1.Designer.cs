namespace Project_3
{
    partial class form
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
            this.currentDateText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberOfGuestsInput = new System.Windows.Forms.TextBox();
            this.menuChoices = new System.Windows.Forms.GroupBox();
            this.pastaOption = new System.Windows.Forms.RadioButton();
            this.chickenOption = new System.Windows.Forms.RadioButton();
            this.steakOption = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.wineOption = new System.Windows.Forms.CheckBox();
            this.openBarOption = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sidesDropdown = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.saucesDropdown = new System.Windows.Forms.ComboBox();
            this.amountDue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.summary = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuChoices.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Date:";
            // 
            // currentDateText
            // 
            this.currentDateText.AutoSize = true;
            this.currentDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateText.Location = new System.Drawing.Point(136, 9);
            this.currentDateText.Name = "currentDateText";
            this.currentDateText.Size = new System.Drawing.Size(41, 20);
            this.currentDateText.TabIndex = 1;
            this.currentDateText.Text = "date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hodge\'s Catering";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of Guests";
            // 
            // numberOfGuestsInput
            // 
            this.numberOfGuestsInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfGuestsInput.Location = new System.Drawing.Point(12, 93);
            this.numberOfGuestsInput.Name = "numberOfGuestsInput";
            this.numberOfGuestsInput.Size = new System.Drawing.Size(130, 24);
            this.numberOfGuestsInput.TabIndex = 4;
            // 
            // menuChoices
            // 
            this.menuChoices.Controls.Add(this.pastaOption);
            this.menuChoices.Controls.Add(this.chickenOption);
            this.menuChoices.Controls.Add(this.steakOption);
            this.menuChoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuChoices.Location = new System.Drawing.Point(12, 143);
            this.menuChoices.Name = "menuChoices";
            this.menuChoices.Size = new System.Drawing.Size(130, 112);
            this.menuChoices.TabIndex = 5;
            this.menuChoices.TabStop = false;
            this.menuChoices.Text = "Menu Choices";
            // 
            // pastaOption
            // 
            this.pastaOption.AutoSize = true;
            this.pastaOption.Location = new System.Drawing.Point(14, 79);
            this.pastaOption.Name = "pastaOption";
            this.pastaOption.Size = new System.Drawing.Size(64, 22);
            this.pastaOption.TabIndex = 2;
            this.pastaOption.TabStop = true;
            this.pastaOption.Text = "Pasta";
            this.pastaOption.UseVisualStyleBackColor = true;
            this.pastaOption.CheckedChanged += new System.EventHandler(this.pastaOption_CheckedChanged);
            // 
            // chickenOption
            // 
            this.chickenOption.AutoSize = true;
            this.chickenOption.Location = new System.Drawing.Point(14, 51);
            this.chickenOption.Name = "chickenOption";
            this.chickenOption.Size = new System.Drawing.Size(80, 22);
            this.chickenOption.TabIndex = 1;
            this.chickenOption.TabStop = true;
            this.chickenOption.Text = "Chicken";
            this.chickenOption.UseVisualStyleBackColor = true;
            this.chickenOption.CheckedChanged += new System.EventHandler(this.chickenOption_CheckedChanged);
            // 
            // steakOption
            // 
            this.steakOption.AutoSize = true;
            this.steakOption.Location = new System.Drawing.Point(14, 23);
            this.steakOption.Name = "steakOption";
            this.steakOption.Size = new System.Drawing.Size(64, 22);
            this.steakOption.TabIndex = 0;
            this.steakOption.TabStop = true;
            this.steakOption.Text = "Steak";
            this.steakOption.UseVisualStyleBackColor = true;
            this.steakOption.CheckedChanged += new System.EventHandler(this.steakOption_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.wineOption);
            this.groupBox3.Controls.Add(this.openBarOption);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(284, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(138, 112);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bar Selection";
            // 
            // wineOption
            // 
            this.wineOption.AutoSize = true;
            this.wineOption.Location = new System.Drawing.Point(7, 68);
            this.wineOption.Name = "wineOption";
            this.wineOption.Size = new System.Drawing.Size(123, 22);
            this.wineOption.TabIndex = 1;
            this.wineOption.Text = "Wine w/Dinner";
            this.wineOption.UseVisualStyleBackColor = true;
            // 
            // openBarOption
            // 
            this.openBarOption.AutoSize = true;
            this.openBarOption.Location = new System.Drawing.Point(7, 34);
            this.openBarOption.Name = "openBarOption";
            this.openBarOption.Size = new System.Drawing.Size(90, 22);
            this.openBarOption.TabIndex = 0;
            this.openBarOption.Text = "Open Bar";
            this.openBarOption.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sidesDropdown);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(148, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 56);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sides";
            // 
            // sidesDropdown
            // 
            this.sidesDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sidesDropdown.FormattingEnabled = true;
            this.sidesDropdown.Location = new System.Drawing.Point(4, 21);
            this.sidesDropdown.Name = "sidesDropdown";
            this.sidesDropdown.Size = new System.Drawing.Size(121, 26);
            this.sidesDropdown.TabIndex = 1;
            this.sidesDropdown.SelectedIndexChanged += new System.EventHandler(this.sidesDropdown_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.saucesDropdown);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(148, 143);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(130, 56);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sauces";
            // 
            // saucesDropdown
            // 
            this.saucesDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.saucesDropdown.FormattingEnabled = true;
            this.saucesDropdown.Location = new System.Drawing.Point(4, 21);
            this.saucesDropdown.Name = "saucesDropdown";
            this.saucesDropdown.Size = new System.Drawing.Size(121, 26);
            this.saucesDropdown.TabIndex = 0;
            this.saucesDropdown.SelectedIndexChanged += new System.EventHandler(this.saucesDropdown_SelectedIndexChanged);
            // 
            // amountDue
            // 
            this.amountDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountDue.Location = new System.Drawing.Point(194, 261);
            this.amountDue.Name = "amountDue";
            this.amountDue.ReadOnly = true;
            this.amountDue.Size = new System.Drawing.Size(130, 24);
            this.amountDue.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Amount Due:";
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(12, 297);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(111, 32);
            this.calculate.TabIndex = 10;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(140, 297);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(59, 32);
            this.clear.TabIndex = 11;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // summary
            // 
            this.summary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary.Location = new System.Drawing.Point(224, 297);
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(111, 32);
            this.summary.TabIndex = 12;
            this.summary.Text = "Summary";
            this.summary.UseVisualStyleBackColor = true;
            this.summary.Click += new System.EventHandler(this.summary_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(361, 297);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(60, 32);
            this.exit.TabIndex = 13;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 341);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.summary);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.amountDue);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuChoices);
            this.Controls.Add(this.numberOfGuestsInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentDateText);
            this.Controls.Add(this.label1);
            this.Name = "form";
            this.Text = "Hodge\'s Catering";
            this.Load += new System.EventHandler(this.form_Load);
            this.menuChoices.ResumeLayout(false);
            this.menuChoices.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentDateText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numberOfGuestsInput;
        private System.Windows.Forms.GroupBox menuChoices;
        private System.Windows.Forms.RadioButton chickenOption;
        private System.Windows.Forms.RadioButton steakOption;
        private System.Windows.Forms.RadioButton pastaOption;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox openBarOption;
        private System.Windows.Forms.CheckBox wineOption;
        private System.Windows.Forms.TextBox amountDue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button summary;
        private System.Windows.Forms.ComboBox sidesDropdown;
        private System.Windows.Forms.ComboBox saucesDropdown;
        private System.Windows.Forms.Button exit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}


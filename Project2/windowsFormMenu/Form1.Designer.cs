namespace windowsFormMenu
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.menuText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saladQuantityInput = new System.Windows.Forms.TextBox();
            this.saladPriceText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pastaSaladRadioButton = new System.Windows.Forms.RadioButton();
            this.fruitSaladRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.drinkQuantityInput = new System.Windows.Forms.TextBox();
            this.drinkPriceText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.fruitJuiceRadioButton = new System.Windows.Forms.RadioButton();
            this.smoothieRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dessertQuantityInput = new System.Windows.Forms.TextBox();
            this.dessertPriceText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.shortcakeRadioButton = new System.Windows.Forms.RadioButton();
            this.cupcakeRadioButton = new System.Windows.Forms.RadioButton();
            this.saladSelectionLabel = new System.Windows.Forms.Label();
            this.drinkSelectionLabel = new System.Windows.Forms.Label();
            this.dessertsSelectionLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.outputMessage = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(580, 12);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(679, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(778, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // menuText
            // 
            this.menuText.AutoSize = true;
            this.menuText.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuText.ForeColor = System.Drawing.Color.White;
            this.menuText.Location = new System.Drawing.Point(12, 12);
            this.menuText.Name = "menuText";
            this.menuText.Size = new System.Drawing.Size(102, 39);
            this.menuText.TabIndex = 4;
            this.menuText.Text = "Menu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saladQuantityInput);
            this.groupBox1.Controls.Add(this.saladPriceText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pastaSaladRadioButton);
            this.groupBox1.Controls.Add(this.fruitSaladRadioButton);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(19, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 313);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salads";
            // 
            // saladQuantityInput
            // 
            this.saladQuantityInput.Location = new System.Drawing.Point(135, 271);
            this.saladQuantityInput.Name = "saladQuantityInput";
            this.saladQuantityInput.Size = new System.Drawing.Size(72, 20);
            this.saladQuantityInput.TabIndex = 7;
            this.saladQuantityInput.Text = "0";
            // 
            // saladPriceText
            // 
            this.saladPriceText.Location = new System.Drawing.Point(135, 245);
            this.saladPriceText.Name = "saladPriceText";
            this.saladPriceText.ReadOnly = true;
            this.saladPriceText.Size = new System.Drawing.Size(72, 20);
            this.saladPriceText.TabIndex = 6;
            this.saladPriceText.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Salad Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Salad Price";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(135, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pastaSaladRadioButton
            // 
            this.pastaSaladRadioButton.AutoSize = true;
            this.pastaSaladRadioButton.Location = new System.Drawing.Point(10, 141);
            this.pastaSaladRadioButton.Name = "pastaSaladRadioButton";
            this.pastaSaladRadioButton.Size = new System.Drawing.Size(82, 17);
            this.pastaSaladRadioButton.TabIndex = 1;
            this.pastaSaladRadioButton.TabStop = true;
            this.pastaSaladRadioButton.Text = "Pasta Salad";
            this.pastaSaladRadioButton.UseVisualStyleBackColor = true;
            this.pastaSaladRadioButton.CheckedChanged += new System.EventHandler(this.pastaSaladRadioButton_CheckedChanged);
            // 
            // fruitSaladRadioButton
            // 
            this.fruitSaladRadioButton.AutoSize = true;
            this.fruitSaladRadioButton.Location = new System.Drawing.Point(10, 19);
            this.fruitSaladRadioButton.Name = "fruitSaladRadioButton";
            this.fruitSaladRadioButton.Size = new System.Drawing.Size(75, 17);
            this.fruitSaladRadioButton.TabIndex = 0;
            this.fruitSaladRadioButton.TabStop = true;
            this.fruitSaladRadioButton.Text = "Fruit Salad";
            this.fruitSaladRadioButton.UseVisualStyleBackColor = true;
            this.fruitSaladRadioButton.CheckedChanged += new System.EventHandler(this.fruitSaladRadioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.drinkQuantityInput);
            this.groupBox2.Controls.Add(this.drinkPriceText);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.fruitJuiceRadioButton);
            this.groupBox2.Controls.Add(this.smoothieRadioButton);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(338, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 313);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drinks";
            // 
            // drinkQuantityInput
            // 
            this.drinkQuantityInput.Location = new System.Drawing.Point(135, 271);
            this.drinkQuantityInput.Name = "drinkQuantityInput";
            this.drinkQuantityInput.Size = new System.Drawing.Size(72, 20);
            this.drinkQuantityInput.TabIndex = 7;
            this.drinkQuantityInput.Text = "0";
            // 
            // drinkPriceText
            // 
            this.drinkPriceText.Location = new System.Drawing.Point(135, 245);
            this.drinkPriceText.Name = "drinkPriceText";
            this.drinkPriceText.ReadOnly = true;
            this.drinkPriceText.Size = new System.Drawing.Size(72, 20);
            this.drinkPriceText.TabIndex = 6;
            this.drinkPriceText.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Drink Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Drink Price";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(135, 116);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 91);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(135, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 91);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // fruitJuiceRadioButton
            // 
            this.fruitJuiceRadioButton.AutoSize = true;
            this.fruitJuiceRadioButton.Location = new System.Drawing.Point(10, 141);
            this.fruitJuiceRadioButton.Name = "fruitJuiceRadioButton";
            this.fruitJuiceRadioButton.Size = new System.Drawing.Size(73, 17);
            this.fruitJuiceRadioButton.TabIndex = 1;
            this.fruitJuiceRadioButton.TabStop = true;
            this.fruitJuiceRadioButton.Text = "Fruit Juice";
            this.fruitJuiceRadioButton.UseVisualStyleBackColor = true;
            this.fruitJuiceRadioButton.CheckedChanged += new System.EventHandler(this.fruitJuiceRadioButton_CheckedChanged);
            // 
            // smoothieRadioButton
            // 
            this.smoothieRadioButton.AutoSize = true;
            this.smoothieRadioButton.Location = new System.Drawing.Point(10, 19);
            this.smoothieRadioButton.Name = "smoothieRadioButton";
            this.smoothieRadioButton.Size = new System.Drawing.Size(69, 17);
            this.smoothieRadioButton.TabIndex = 0;
            this.smoothieRadioButton.TabStop = true;
            this.smoothieRadioButton.Text = "Smoothie";
            this.smoothieRadioButton.UseVisualStyleBackColor = true;
            this.smoothieRadioButton.CheckedChanged += new System.EventHandler(this.smoothieRadioButton_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dessertQuantityInput);
            this.groupBox3.Controls.Add(this.dessertPriceText);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.pictureBox5);
            this.groupBox3.Controls.Add(this.pictureBox6);
            this.groupBox3.Controls.Add(this.shortcakeRadioButton);
            this.groupBox3.Controls.Add(this.cupcakeRadioButton);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(661, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 313);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Desserts";
            // 
            // dessertQuantityInput
            // 
            this.dessertQuantityInput.Location = new System.Drawing.Point(135, 271);
            this.dessertQuantityInput.Name = "dessertQuantityInput";
            this.dessertQuantityInput.Size = new System.Drawing.Size(72, 20);
            this.dessertQuantityInput.TabIndex = 7;
            this.dessertQuantityInput.Text = "0";
            // 
            // dessertPriceText
            // 
            this.dessertPriceText.Location = new System.Drawing.Point(135, 245);
            this.dessertPriceText.Name = "dessertPriceText";
            this.dessertPriceText.ReadOnly = true;
            this.dessertPriceText.Size = new System.Drawing.Size(72, 20);
            this.dessertPriceText.TabIndex = 6;
            this.dessertPriceText.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dessert Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Dessert Price";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(135, 116);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 91);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(135, 19);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 91);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // shortcakeRadioButton
            // 
            this.shortcakeRadioButton.AutoSize = true;
            this.shortcakeRadioButton.Location = new System.Drawing.Point(10, 141);
            this.shortcakeRadioButton.Name = "shortcakeRadioButton";
            this.shortcakeRadioButton.Size = new System.Drawing.Size(74, 17);
            this.shortcakeRadioButton.TabIndex = 1;
            this.shortcakeRadioButton.TabStop = true;
            this.shortcakeRadioButton.Text = "Shortcake";
            this.shortcakeRadioButton.UseVisualStyleBackColor = true;
            this.shortcakeRadioButton.CheckedChanged += new System.EventHandler(this.shortcakeRadioButton_CheckedChanged);
            // 
            // cupcakeRadioButton
            // 
            this.cupcakeRadioButton.AutoSize = true;
            this.cupcakeRadioButton.Location = new System.Drawing.Point(10, 19);
            this.cupcakeRadioButton.Name = "cupcakeRadioButton";
            this.cupcakeRadioButton.Size = new System.Drawing.Size(68, 17);
            this.cupcakeRadioButton.TabIndex = 0;
            this.cupcakeRadioButton.TabStop = true;
            this.cupcakeRadioButton.Text = "Cupcake";
            this.cupcakeRadioButton.UseVisualStyleBackColor = true;
            this.cupcakeRadioButton.CheckedChanged += new System.EventHandler(this.cupcakeRadioButton_CheckedChanged);
            // 
            // saladSelectionLabel
            // 
            this.saladSelectionLabel.AutoSize = true;
            this.saladSelectionLabel.BackColor = System.Drawing.Color.White;
            this.saladSelectionLabel.Location = new System.Drawing.Point(75, 370);
            this.saladSelectionLabel.Name = "saladSelectionLabel";
            this.saladSelectionLabel.Size = new System.Drawing.Size(115, 13);
            this.saladSelectionLabel.TabIndex = 10;
            this.saladSelectionLabel.Text = "Salads Selection Label";
            this.saladSelectionLabel.Visible = false;
            // 
            // drinkSelectionLabel
            // 
            this.drinkSelectionLabel.AutoSize = true;
            this.drinkSelectionLabel.BackColor = System.Drawing.Color.White;
            this.drinkSelectionLabel.Location = new System.Drawing.Point(405, 370);
            this.drinkSelectionLabel.Name = "drinkSelectionLabel";
            this.drinkSelectionLabel.Size = new System.Drawing.Size(113, 13);
            this.drinkSelectionLabel.TabIndex = 11;
            this.drinkSelectionLabel.Text = "Drinks Selection Label";
            this.drinkSelectionLabel.Visible = false;
            // 
            // dessertsSelectionLabel
            // 
            this.dessertsSelectionLabel.AutoSize = true;
            this.dessertsSelectionLabel.BackColor = System.Drawing.Color.White;
            this.dessertsSelectionLabel.Location = new System.Drawing.Point(725, 370);
            this.dessertsSelectionLabel.Name = "dessertsSelectionLabel";
            this.dessertsSelectionLabel.Size = new System.Drawing.Size(124, 13);
            this.dessertsSelectionLabel.TabIndex = 12;
            this.dessertsSelectionLabel.Text = "Desserts Selection Label";
            this.dessertsSelectionLabel.Visible = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(112, 421);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(694, 10);
            this.label10.TabIndex = 1;
            // 
            // outputMessage
            // 
            this.outputMessage.BackColor = System.Drawing.Color.White;
            this.outputMessage.Location = new System.Drawing.Point(271, 445);
            this.outputMessage.Name = "outputMessage";
            this.outputMessage.Size = new System.Drawing.Size(353, 92);
            this.outputMessage.TabIndex = 13;
            this.outputMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(778, 445);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(136, 75);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 14;
            this.pictureBox7.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(926, 546);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.outputMessage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dessertsSelectionLabel);
            this.Controls.Add(this.drinkSelectionLabel);
            this.Controls.Add(this.saladSelectionLabel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuText);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Strawberry Patch Fine Dining";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label menuText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton pastaSaladRadioButton;
        private System.Windows.Forms.RadioButton fruitSaladRadioButton;
        private System.Windows.Forms.TextBox saladQuantityInput;
        private System.Windows.Forms.TextBox saladPriceText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox drinkQuantityInput;
        private System.Windows.Forms.TextBox drinkPriceText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.RadioButton fruitJuiceRadioButton;
        private System.Windows.Forms.RadioButton smoothieRadioButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox dessertQuantityInput;
        private System.Windows.Forms.TextBox dessertPriceText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.RadioButton shortcakeRadioButton;
        private System.Windows.Forms.RadioButton cupcakeRadioButton;
        private System.Windows.Forms.Label saladSelectionLabel;
        private System.Windows.Forms.Label drinkSelectionLabel;
        private System.Windows.Forms.Label dessertsSelectionLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label outputMessage;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}


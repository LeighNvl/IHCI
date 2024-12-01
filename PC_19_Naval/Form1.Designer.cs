namespace PC_19_Naval
{
    partial class rdoWhereIn
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
            groupBox1 = new GroupBox();
            rdoSizelarge = new RadioButton();
            rdoSizeMedium = new RadioButton();
            rdoSizeSmall = new RadioButton();
            groupBox2 = new GroupBox();
            rdoCrustThin = new RadioButton();
            rdoCrustThick = new RadioButton();
            groupBox3 = new GroupBox();
            chkTomatoes = new CheckBox();
            chkPeppers = new CheckBox();
            chkOnions = new CheckBox();
            chkOlives = new CheckBox();
            chkMushroom = new CheckBox();
            chkCheese = new CheckBox();
            radioButton6 = new RadioButton();
            rdoWhereOut = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoSizelarge);
            groupBox1.Controls.Add(rdoSizeMedium);
            groupBox1.Controls.Add(rdoSizeSmall);
            groupBox1.Location = new Point(8, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(271, 113);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Size";
            // 
            // rdoSizelarge
            // 
            rdoSizelarge.AutoSize = true;
            rdoSizelarge.Location = new Point(6, 82);
            rdoSizelarge.Name = "rdoSizelarge";
            rdoSizelarge.Size = new Size(54, 19);
            rdoSizelarge.TabIndex = 4;
            rdoSizelarge.Text = "Large";
            rdoSizelarge.UseVisualStyleBackColor = true;
            rdoSizelarge.CheckedChanged += rdoSizelarge_CheckedChanged;
            // 
            // rdoSizeMedium
            // 
            rdoSizeMedium.AutoSize = true;
            rdoSizeMedium.Location = new Point(6, 57);
            rdoSizeMedium.Name = "rdoSizeMedium";
            rdoSizeMedium.Size = new Size(70, 19);
            rdoSizeMedium.TabIndex = 3;
            rdoSizeMedium.Text = "Medium";
            rdoSizeMedium.UseVisualStyleBackColor = true;
            rdoSizeMedium.CheckedChanged += rdoSizeMedium_CheckedChanged;
            // 
            // rdoSizeSmall
            // 
            rdoSizeSmall.AutoSize = true;
            rdoSizeSmall.Location = new Point(6, 32);
            rdoSizeSmall.Name = "rdoSizeSmall";
            rdoSizeSmall.Size = new Size(54, 19);
            rdoSizeSmall.TabIndex = 0;
            rdoSizeSmall.Text = "Small";
            rdoSizeSmall.UseVisualStyleBackColor = true;
            rdoSizeSmall.CheckedChanged += rdoSizeSmall_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdoCrustThin);
            groupBox2.Controls.Add(rdoCrustThick);
            groupBox2.Location = new Point(14, 125);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(269, 92);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Crust Type";
            // 
            // rdoCrustThin
            // 
            rdoCrustThin.AutoSize = true;
            rdoCrustThin.Location = new Point(4, 50);
            rdoCrustThin.Name = "rdoCrustThin";
            rdoCrustThin.Size = new Size(82, 19);
            rdoCrustThin.TabIndex = 6;
            rdoCrustThin.Text = "Thin Crust ";
            rdoCrustThin.UseVisualStyleBackColor = true;
            rdoCrustThin.CheckedChanged += rdoCrustThin_CheckedChanged;
            // 
            // rdoCrustThick
            // 
            rdoCrustThick.AutoSize = true;
            rdoCrustThick.Location = new Point(4, 25);
            rdoCrustThick.Name = "rdoCrustThick";
            rdoCrustThick.Size = new Size(84, 19);
            rdoCrustThick.TabIndex = 5;
            rdoCrustThick.Text = "Thick Crust";
            rdoCrustThick.UseVisualStyleBackColor = true;
            rdoCrustThick.CheckedChanged += rdoCrustThick_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chkTomatoes);
            groupBox3.Controls.Add(chkPeppers);
            groupBox3.Controls.Add(chkOnions);
            groupBox3.Controls.Add(chkOlives);
            groupBox3.Controls.Add(chkMushroom);
            groupBox3.Controls.Add(chkCheese);
            groupBox3.Location = new Point(295, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(226, 107);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Toppings";
            // 
            // chkTomatoes
            // 
            chkTomatoes.AutoSize = true;
            chkTomatoes.Location = new Point(113, 69);
            chkTomatoes.Name = "chkTomatoes";
            chkTomatoes.Size = new Size(77, 19);
            chkTomatoes.TabIndex = 11;
            chkTomatoes.Text = "Tomatoes";
            chkTomatoes.UseVisualStyleBackColor = true;
            // 
            // chkPeppers
            // 
            chkPeppers.AutoSize = true;
            chkPeppers.Location = new Point(113, 44);
            chkPeppers.Name = "chkPeppers";
            chkPeppers.Size = new Size(102, 19);
            chkPeppers.TabIndex = 10;
            chkPeppers.Text = "Green Peppers";
            chkPeppers.UseVisualStyleBackColor = true;
            // 
            // chkOnions
            // 
            chkOnions.AutoSize = true;
            chkOnions.Location = new Point(113, 19);
            chkOnions.Name = "chkOnions";
            chkOnions.Size = new Size(64, 19);
            chkOnions.TabIndex = 9;
            chkOnions.Text = "Onions";
            chkOnions.UseVisualStyleBackColor = true;
            // 
            // chkOlives
            // 
            chkOlives.AutoSize = true;
            chkOlives.Location = new Point(3, 69);
            chkOlives.Name = "chkOlives";
            chkOlives.Size = new Size(89, 19);
            chkOlives.TabIndex = 8;
            chkOlives.Text = "Black Olives";
            chkOlives.UseVisualStyleBackColor = true;
            // 
            // chkMushroom
            // 
            chkMushroom.AutoSize = true;
            chkMushroom.Location = new Point(3, 44);
            chkMushroom.Name = "chkMushroom";
            chkMushroom.Size = new Size(90, 19);
            chkMushroom.TabIndex = 1;
            chkMushroom.Text = "Mushrooms";
            chkMushroom.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Location = new Point(3, 19);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(91, 19);
            chkCheese.TabIndex = 0;
            chkCheese.Text = "Extra cheese";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(395, 136);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(71, 19);
            radioButton6.TabIndex = 5;
            radioButton6.TabStop = true;
            radioButton6.Text = "Take Out";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // rdoWhereOut
            // 
            rdoWhereOut.AutoSize = true;
            rdoWhereOut.Location = new Point(293, 136);
            rdoWhereOut.Name = "rdoWhereOut";
            rdoWhereOut.Size = new Size(54, 19);
            rdoWhereOut.TabIndex = 4;
            rdoWhereOut.TabStop = true;
            rdoWhereOut.Text = "Eat In";
            rdoWhereOut.UseVisualStyleBackColor = true;
            rdoWhereOut.CheckedChanged += rdoWhereOut_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(293, 161);
            button1.Name = "button1";
            button1.Size = new Size(94, 33);
            button1.TabIndex = 6;
            button1.Text = "Build Pizza";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(395, 161);
            button2.Name = "button2";
            button2.Size = new Size(94, 33);
            button2.TabIndex = 7;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // rdoWhereIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 224);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton6);
            Controls.Add(rdoWhereOut);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "rdoWhereIn";
            Text = "Pizza Order";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdoSizelarge;
        private RadioButton rdoSizeMedium;
        private RadioButton rdoSizeSmall;
        private GroupBox groupBox2;
        private RadioButton rdoCrustThin;
        private RadioButton rdoCrustThick;
        private GroupBox groupBox3;
        private RadioButton radioButton6;
        private RadioButton rdoWhereOut;
        private Button button1;
        private Button button2;
        private CheckBox chkTomatoes;
        private CheckBox chkPeppers;
        private CheckBox chkOnions;
        private CheckBox chkOlives;
        private CheckBox chkMushroom;
        private CheckBox chkCheese;
    }
}

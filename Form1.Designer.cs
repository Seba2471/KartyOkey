namespace KartyOkey
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
            this.getCard = new System.Windows.Forms.Button();
            this.CardLeft = new System.Windows.Forms.Label();
            this.choose1 = new System.Windows.Forms.Button();
            this.choose2 = new System.Windows.Forms.Button();
            this.choose3 = new System.Windows.Forms.Button();
            this.EarnPoints = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.table2delete = new System.Windows.Forms.Button();
            this.table2 = new System.Windows.Forms.Button();
            this.table3delete = new System.Windows.Forms.Button();
            this.table3 = new System.Windows.Forms.Button();
            this.table5delete = new System.Windows.Forms.Button();
            this.table5 = new System.Windows.Forms.Button();
            this.table4delete = new System.Windows.Forms.Button();
            this.table4 = new System.Windows.Forms.Button();
            this.table1delete = new System.Windows.Forms.Button();
            this.table1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getCard
            // 
            this.getCard.BackColor = System.Drawing.Color.LimeGreen;
            this.getCard.Location = new System.Drawing.Point(37, 330);
            this.getCard.Name = "getCard";
            this.getCard.Size = new System.Drawing.Size(86, 135);
            this.getCard.TabIndex = 0;
            this.getCard.Text = "Dodaj kartę";
            this.getCard.UseVisualStyleBackColor = false;
            this.getCard.Click += new System.EventHandler(this.NewCard_Click);
            // 
            // CardLeft
            // 
            this.CardLeft.AutoSize = true;
            this.CardLeft.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CardLeft.Location = new System.Drawing.Point(146, 440);
            this.CardLeft.Name = "CardLeft";
            this.CardLeft.Size = new System.Drawing.Size(32, 25);
            this.CardLeft.TabIndex = 1;
            this.CardLeft.Text = "24";
            // 
            // choose1
            // 
            this.choose1.BackColor = System.Drawing.Color.White;
            this.choose1.Location = new System.Drawing.Point(414, 266);
            this.choose1.Name = "choose1";
            this.choose1.Size = new System.Drawing.Size(107, 137);
            this.choose1.TabIndex = 7;
            this.choose1.UseVisualStyleBackColor = false;
            this.choose1.Click += new System.EventHandler(this.choose1_Click);
            // 
            // choose2
            // 
            this.choose2.BackColor = System.Drawing.Color.White;
            this.choose2.Location = new System.Drawing.Point(549, 266);
            this.choose2.Name = "choose2";
            this.choose2.Size = new System.Drawing.Size(107, 137);
            this.choose2.TabIndex = 8;
            this.choose2.UseVisualStyleBackColor = false;
            this.choose2.Click += new System.EventHandler(this.choose2_Click);
            // 
            // choose3
            // 
            this.choose3.BackColor = System.Drawing.Color.White;
            this.choose3.Location = new System.Drawing.Point(690, 266);
            this.choose3.Name = "choose3";
            this.choose3.Size = new System.Drawing.Size(107, 137);
            this.choose3.TabIndex = 9;
            this.choose3.UseVisualStyleBackColor = false;
            this.choose3.Click += new System.EventHandler(this.choose3_Click);
            // 
            // EarnPoints
            // 
            this.EarnPoints.AutoSize = true;
            this.EarnPoints.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EarnPoints.Location = new System.Drawing.Point(301, 430);
            this.EarnPoints.Name = "EarnPoints";
            this.EarnPoints.Size = new System.Drawing.Size(22, 25);
            this.EarnPoints.TabIndex = 10;
            this.EarnPoints.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(226, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Punkty";
            // 
            // table2delete
            // 
            this.table2delete.Location = new System.Drawing.Point(431, 40);
            this.table2delete.Name = "table2delete";
            this.table2delete.Size = new System.Drawing.Size(24, 23);
            this.table2delete.TabIndex = 14;
            this.table2delete.Text = " x";
            this.table2delete.UseVisualStyleBackColor = true;
            this.table2delete.Click += new System.EventHandler(this.table2delete_Click);
            // 
            // table2
            // 
            this.table2.BackColor = System.Drawing.Color.White;
            this.table2.Location = new System.Drawing.Point(331, 40);
            this.table2.Name = "table2";
            this.table2.Size = new System.Drawing.Size(124, 154);
            this.table2.TabIndex = 13;
            this.table2.UseVisualStyleBackColor = false;
            this.table2.Click += new System.EventHandler(this.table2_Click);
            // 
            // table3delete
            // 
            this.table3delete.Location = new System.Drawing.Point(576, 40);
            this.table3delete.Name = "table3delete";
            this.table3delete.Size = new System.Drawing.Size(24, 23);
            this.table3delete.TabIndex = 16;
            this.table3delete.Text = " x";
            this.table3delete.UseVisualStyleBackColor = true;
            this.table3delete.Click += new System.EventHandler(this.table3delete_Click_1);
            // 
            // table3
            // 
            this.table3.BackColor = System.Drawing.Color.White;
            this.table3.Location = new System.Drawing.Point(476, 40);
            this.table3.Name = "table3";
            this.table3.Size = new System.Drawing.Size(124, 154);
            this.table3.TabIndex = 15;
            this.table3.UseVisualStyleBackColor = false;
            this.table3.Click += new System.EventHandler(this.table3_Click);
            // 
            // table5delete
            // 
            this.table5delete.Location = new System.Drawing.Point(873, 40);
            this.table5delete.Name = "table5delete";
            this.table5delete.Size = new System.Drawing.Size(24, 23);
            this.table5delete.TabIndex = 20;
            this.table5delete.Text = " x";
            this.table5delete.UseVisualStyleBackColor = true;
            this.table5delete.Click += new System.EventHandler(this.table5delete_Click);
            // 
            // table5
            // 
            this.table5.BackColor = System.Drawing.Color.White;
            this.table5.Location = new System.Drawing.Point(773, 40);
            this.table5.Name = "table5";
            this.table5.Size = new System.Drawing.Size(124, 154);
            this.table5.TabIndex = 19;
            this.table5.UseVisualStyleBackColor = false;
            this.table5.Click += new System.EventHandler(this.table5_Click);
            // 
            // table4delete
            // 
            this.table4delete.Location = new System.Drawing.Point(727, 40);
            this.table4delete.Name = "table4delete";
            this.table4delete.Size = new System.Drawing.Size(24, 23);
            this.table4delete.TabIndex = 22;
            this.table4delete.Text = " x";
            this.table4delete.UseVisualStyleBackColor = true;
            this.table4delete.Click += new System.EventHandler(this.table4delete_Click);
            // 
            // table4
            // 
            this.table4.BackColor = System.Drawing.Color.White;
            this.table4.Location = new System.Drawing.Point(627, 40);
            this.table4.Name = "table4";
            this.table4.Size = new System.Drawing.Size(124, 154);
            this.table4.TabIndex = 21;
            this.table4.UseVisualStyleBackColor = false;
            this.table4.Click += new System.EventHandler(this.table4_Click);
            // 
            // table1delete
            // 
            this.table1delete.Location = new System.Drawing.Point(284, 40);
            this.table1delete.Name = "table1delete";
            this.table1delete.Size = new System.Drawing.Size(24, 23);
            this.table1delete.TabIndex = 24;
            this.table1delete.Text = " x";
            this.table1delete.UseVisualStyleBackColor = true;
            this.table1delete.Click += new System.EventHandler(this.table1delete_Click);
            // 
            // table1
            // 
            this.table1.BackColor = System.Drawing.Color.White;
            this.table1.Location = new System.Drawing.Point(184, 40);
            this.table1.Name = "table1";
            this.table1.Size = new System.Drawing.Size(124, 154);
            this.table1.TabIndex = 23;
            this.table1.UseVisualStyleBackColor = false;
            this.table1.Click += new System.EventHandler(this.table1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(131, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "x";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(932, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 29);
            this.button1.TabIndex = 26;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 499);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.table1delete);
            this.Controls.Add(this.table1);
            this.Controls.Add(this.table4delete);
            this.Controls.Add(this.table4);
            this.Controls.Add(this.table5delete);
            this.Controls.Add(this.table5);
            this.Controls.Add(this.table3delete);
            this.Controls.Add(this.table3);
            this.Controls.Add(this.table2delete);
            this.Controls.Add(this.table2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EarnPoints);
            this.Controls.Add(this.choose3);
            this.Controls.Add(this.choose2);
            this.Controls.Add(this.choose1);
            this.Controls.Add(this.CardLeft);
            this.Controls.Add(this.getCard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button getCard;
        private Label CardLeft;
        private Button choose1;
        private Button choose2;
        private Button choose3;
        private Label EarnPoints;
        private Label label1;
        private Button table2delete;
        private Button table2;
        private Button table3delete;
        private Button table3;
        private Button table5delete;
        private Button table5;
        private Button table4delete;
        private Button table4;
        private Button table1delete;
        private Button table1;
        private Label label2;
        private Button button1;
    }
}
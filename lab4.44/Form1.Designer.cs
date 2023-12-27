namespace lab4._44
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
            buttonchoco = new Button();
            buttoncoffee = new Button();
            buttonLattle = new Button();
            buttonmocha = new Button();
            Replenish = new Button();
            pictureBox1 = new PictureBox();
            picturecoffee = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picturecoffee).BeginInit();
            SuspendLayout();
            // 
            // buttonchoco
            // 
            buttonchoco.BackColor = SystemColors.ActiveCaption;
            buttonchoco.Location = new Point(131, 42);
            buttonchoco.Name = "buttonchoco";
            buttonchoco.Size = new Size(75, 23);
            buttonchoco.TabIndex = 0;
            buttonchoco.Text = "ช็อคโกแลต";
            buttonchoco.UseVisualStyleBackColor = false;
            buttonchoco.Click += buttonchoco_Click;
            // 
            // buttoncoffee
            // 
            buttoncoffee.BackColor = Color.FromArgb(255, 192, 255);
            buttoncoffee.Location = new Point(131, 98);
            buttoncoffee.Name = "buttoncoffee";
            buttoncoffee.Size = new Size(75, 23);
            buttoncoffee.TabIndex = 1;
            buttoncoffee.Text = "กาแฟดำ";
            buttoncoffee.UseVisualStyleBackColor = false;
            buttoncoffee.Click += buttoncoffee_Click_1;
            // 
            // buttonLattle
            // 
            buttonLattle.BackColor = Color.FromArgb(255, 255, 192);
            buttonLattle.Location = new Point(131, 161);
            buttonLattle.Name = "buttonLattle";
            buttonLattle.Size = new Size(75, 23);
            buttonLattle.TabIndex = 2;
            buttonLattle.Text = "ลาเต้";
            buttonLattle.UseVisualStyleBackColor = false;
            buttonLattle.Click += buttonLattle_Click;
            // 
            // buttonmocha
            // 
            buttonmocha.BackColor = Color.FromArgb(192, 255, 192);
            buttonmocha.Location = new Point(131, 208);
            buttonmocha.Name = "buttonmocha";
            buttonmocha.Size = new Size(75, 23);
            buttonmocha.TabIndex = 3;
            buttonmocha.Text = "ม็อคค่า";
            buttonmocha.UseVisualStyleBackColor = false;
            buttonmocha.Click += buttonmocha_Click;
            // 
            // Replenish
            // 
            Replenish.BackColor = Color.Red;
            Replenish.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Replenish.Location = new Point(615, 400);
            Replenish.Name = "Replenish";
            Replenish.Size = new Size(75, 23);
            Replenish.TabIndex = 4;
            Replenish.Text = "Replenish";
            Replenish.UseVisualStyleBackColor = false;
            Replenish.Click += Replenish_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(102, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(605, 449);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // picturecoffee
            // 
            picturecoffee.Location = new Point(541, 19);
            picturecoffee.Name = "picturecoffee";
            picturecoffee.Size = new Size(149, 102);
            picturecoffee.SizeMode = PictureBoxSizeMode.StretchImage;
            picturecoffee.TabIndex = 6;
            picturecoffee.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(330, 379);
            label1.Name = "label1";
            label1.Size = new Size(125, 30);
            label1.TabIndex = 7;
            label1.Text = "chang binn";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 128);
            label2.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(355, 161);
            label2.Name = "label2";
            label2.Size = new Size(79, 30);
            label2.TabIndex = 8;
            label2.Text = "แซ่บบบ";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 458);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picturecoffee);
            Controls.Add(Replenish);
            Controls.Add(buttonmocha);
            Controls.Add(buttonLattle);
            Controls.Add(buttoncoffee);
            Controls.Add(buttonchoco);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picturecoffee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonchoco;
        private Button buttoncoffee;
        private Button buttonLattle;
        private Button buttonmocha;
        private Button Replenish;
        private PictureBox pictureBox1;
        private PictureBox picturecoffee;
        private Label label1;
        private Label label2;
    }
}

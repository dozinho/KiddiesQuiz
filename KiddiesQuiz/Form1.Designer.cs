namespace KiddiesQuiz
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
            questionsTab = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // questionsTab
            // 
            questionsTab.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            questionsTab.Location = new Point(48, 236);
            questionsTab.Name = "questionsTab";
            questionsTab.Size = new Size(342, 23);
            questionsTab.TabIndex = 0;
            questionsTab.Text = "Questions";
            questionsTab.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.animal_trivia_jpg;
            pictureBox1.Location = new Point(28, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(395, 209);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(48, 274);
            button1.Name = "button1";
            button1.Size = new Size(140, 37);
            button1.TabIndex = 2;
            button1.Tag = "1";
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += checkAnswerEvent;
            // 
            // button2
            // 
            button2.Location = new Point(250, 274);
            button2.Name = "button2";
            button2.Size = new Size(140, 37);
            button2.TabIndex = 3;
            button2.Tag = "2";
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += checkAnswerEvent;
            // 
            // button3
            // 
            button3.Location = new Point(48, 323);
            button3.Name = "button3";
            button3.Size = new Size(140, 37);
            button3.TabIndex = 4;
            button3.Tag = "3";
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += checkAnswerEvent;
            // 
            // button4
            // 
            button4.Location = new Point(250, 323);
            button4.Name = "button4";
            button4.Size = new Size(140, 37);
            button4.TabIndex = 5;
            button4.Tag = "4";
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += checkAnswerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(questionsTab);
            Name = "Form1";
            Text = "Animal Trivia";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label questionsTab;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}

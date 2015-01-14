namespace Rock_Paper_Scissors
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.computerScissors = new System.Windows.Forms.PictureBox();
            this.humanRock = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGames = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.computerRock = new System.Windows.Forms.PictureBox();
            this.computerPaper = new System.Windows.Forms.PictureBox();
            this.humanPaper = new System.Windows.Forms.PictureBox();
            this.humanScissors = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHumanHand = new System.Windows.Forms.Label();
            this.lblComputerHand = new System.Windows.Forms.Label();
            this.rbtnNormal = new System.Windows.Forms.RadioButton();
            this.rbtnSpockLizard = new System.Windows.Forms.RadioButton();
            this.humanSpock = new System.Windows.Forms.PictureBox();
            this.humanLizard = new System.Windows.Forms.PictureBox();
            this.computerLizard = new System.Windows.Forms.PictureBox();
            this.computerSpock = new System.Windows.Forms.PictureBox();
            this.btnLizard = new System.Windows.Forms.Button();
            this.btnSpock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.computerScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanSpock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanLizard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerLizard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerSpock)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "Paper";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(184, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "Scissors";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // computerScissors
            // 
            this.computerScissors.Image = ((System.Drawing.Image)(resources.GetObject("computerScissors.Image")));
            this.computerScissors.Location = new System.Drawing.Point(282, 69);
            this.computerScissors.Name = "computerScissors";
            this.computerScissors.Size = new System.Drawing.Size(165, 147);
            this.computerScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerScissors.TabIndex = 3;
            this.computerScissors.TabStop = false;
            // 
            // humanRock
            // 
            this.humanRock.Image = ((System.Drawing.Image)(resources.GetObject("humanRock.Image")));
            this.humanRock.Location = new System.Drawing.Point(35, 69);
            this.humanRock.Name = "humanRock";
            this.humanRock.Size = new System.Drawing.Size(165, 147);
            this.humanRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.humanRock.TabIndex = 5;
            this.humanRock.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "GAMES:";
            // 
            // lblGames
            // 
            this.lblGames.AutoSize = true;
            this.lblGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGames.Location = new System.Drawing.Point(432, 365);
            this.lblGames.Name = "lblGames";
            this.lblGames.Size = new System.Drawing.Size(0, 24);
            this.lblGames.TabIndex = 9;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.Color.Red;
            this.lblOutput.Location = new System.Drawing.Point(33, 250);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 25);
            this.lblOutput.TabIndex = 12;
            // 
            // computerRock
            // 
            this.computerRock.Image = ((System.Drawing.Image)(resources.GetObject("computerRock.Image")));
            this.computerRock.Location = new System.Drawing.Point(282, 69);
            this.computerRock.Name = "computerRock";
            this.computerRock.Size = new System.Drawing.Size(165, 147);
            this.computerRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerRock.TabIndex = 13;
            this.computerRock.TabStop = false;
            // 
            // computerPaper
            // 
            this.computerPaper.Image = ((System.Drawing.Image)(resources.GetObject("computerPaper.Image")));
            this.computerPaper.Location = new System.Drawing.Point(282, 69);
            this.computerPaper.Name = "computerPaper";
            this.computerPaper.Size = new System.Drawing.Size(165, 147);
            this.computerPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerPaper.TabIndex = 14;
            this.computerPaper.TabStop = false;
            // 
            // humanPaper
            // 
            this.humanPaper.Image = ((System.Drawing.Image)(resources.GetObject("humanPaper.Image")));
            this.humanPaper.Location = new System.Drawing.Point(35, 69);
            this.humanPaper.Name = "humanPaper";
            this.humanPaper.Size = new System.Drawing.Size(165, 147);
            this.humanPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.humanPaper.TabIndex = 15;
            this.humanPaper.TabStop = false;
            // 
            // humanScissors
            // 
            this.humanScissors.Image = ((System.Drawing.Image)(resources.GetObject("humanScissors.Image")));
            this.humanScissors.Location = new System.Drawing.Point(35, 69);
            this.humanScissors.Name = "humanScissors";
            this.humanScissors.Size = new System.Drawing.Size(165, 147);
            this.humanScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.humanScissors.TabIndex = 16;
            this.humanScissors.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Human (YOU):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "COMPUTER:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "MOST HAND USED:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "MOST HAND USED:";
            // 
            // lblHumanHand
            // 
            this.lblHumanHand.AutoSize = true;
            this.lblHumanHand.Location = new System.Drawing.Point(149, 219);
            this.lblHumanHand.Name = "lblHumanHand";
            this.lblHumanHand.Size = new System.Drawing.Size(0, 13);
            this.lblHumanHand.TabIndex = 23;
            // 
            // lblComputerHand
            // 
            this.lblComputerHand.AutoSize = true;
            this.lblComputerHand.Location = new System.Drawing.Point(385, 219);
            this.lblComputerHand.Name = "lblComputerHand";
            this.lblComputerHand.Size = new System.Drawing.Size(0, 13);
            this.lblComputerHand.TabIndex = 24;
            // 
            // rbtnNormal
            // 
            this.rbtnNormal.AutoSize = true;
            this.rbtnNormal.Location = new System.Drawing.Point(38, 12);
            this.rbtnNormal.Name = "rbtnNormal";
            this.rbtnNormal.Size = new System.Drawing.Size(130, 17);
            this.rbtnNormal.TabIndex = 25;
            this.rbtnNormal.TabStop = true;
            this.rbtnNormal.Text = "Rock, Paper & Scissors";
            this.rbtnNormal.UseVisualStyleBackColor = true;
            this.rbtnNormal.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtnSpockLizard
            // 
            this.rbtnSpockLizard.AutoSize = true;
            this.rbtnSpockLizard.Location = new System.Drawing.Point(271, 12);
            this.rbtnSpockLizard.Name = "rbtnSpockLizard";
            this.rbtnSpockLizard.Size = new System.Drawing.Size(201, 17);
            this.rbtnSpockLizard.TabIndex = 26;
            this.rbtnSpockLizard.TabStop = true;
            this.rbtnSpockLizard.Text = "Rock, Paper, Scissors, Lizard & Spock";
            this.rbtnSpockLizard.UseVisualStyleBackColor = true;
            this.rbtnSpockLizard.CheckedChanged += new System.EventHandler(this.rbtnSpockLizard_CheckedChanged);
            // 
            // humanSpock
            // 
            this.humanSpock.Image = ((System.Drawing.Image)(resources.GetObject("humanSpock.Image")));
            this.humanSpock.Location = new System.Drawing.Point(35, 69);
            this.humanSpock.Name = "humanSpock";
            this.humanSpock.Size = new System.Drawing.Size(165, 147);
            this.humanSpock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.humanSpock.TabIndex = 27;
            this.humanSpock.TabStop = false;
            // 
            // humanLizard
            // 
            this.humanLizard.Image = ((System.Drawing.Image)(resources.GetObject("humanLizard.Image")));
            this.humanLizard.Location = new System.Drawing.Point(35, 69);
            this.humanLizard.Name = "humanLizard";
            this.humanLizard.Size = new System.Drawing.Size(165, 147);
            this.humanLizard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.humanLizard.TabIndex = 28;
            this.humanLizard.TabStop = false;
            // 
            // computerLizard
            // 
            this.computerLizard.Image = ((System.Drawing.Image)(resources.GetObject("computerLizard.Image")));
            this.computerLizard.Location = new System.Drawing.Point(282, 69);
            this.computerLizard.Name = "computerLizard";
            this.computerLizard.Size = new System.Drawing.Size(165, 147);
            this.computerLizard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerLizard.TabIndex = 29;
            this.computerLizard.TabStop = false;
            // 
            // computerSpock
            // 
            this.computerSpock.Image = ((System.Drawing.Image)(resources.GetObject("computerSpock.Image")));
            this.computerSpock.Location = new System.Drawing.Point(282, 69);
            this.computerSpock.Name = "computerSpock";
            this.computerSpock.Size = new System.Drawing.Size(165, 147);
            this.computerSpock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerSpock.TabIndex = 30;
            this.computerSpock.TabStop = false;
            // 
            // btnLizard
            // 
            this.btnLizard.Location = new System.Drawing.Point(184, 346);
            this.btnLizard.Name = "btnLizard";
            this.btnLizard.Size = new System.Drawing.Size(104, 25);
            this.btnLizard.TabIndex = 31;
            this.btnLizard.Text = "Lizard";
            this.btnLizard.UseVisualStyleBackColor = true;
            this.btnLizard.Click += new System.EventHandler(this.btnLizard_Click);
            // 
            // btnSpock
            // 
            this.btnSpock.Location = new System.Drawing.Point(184, 373);
            this.btnSpock.Name = "btnSpock";
            this.btnSpock.Size = new System.Drawing.Size(104, 25);
            this.btnSpock.TabIndex = 32;
            this.btnSpock.Text = "Spock";
            this.btnSpock.UseVisualStyleBackColor = true;
            this.btnSpock.Click += new System.EventHandler(this.btnSpock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 413);
            this.Controls.Add(this.btnSpock);
            this.Controls.Add(this.btnLizard);
            this.Controls.Add(this.computerSpock);
            this.Controls.Add(this.computerLizard);
            this.Controls.Add(this.humanLizard);
            this.Controls.Add(this.humanSpock);
            this.Controls.Add(this.rbtnSpockLizard);
            this.Controls.Add(this.rbtnNormal);
            this.Controls.Add(this.lblComputerHand);
            this.Controls.Add(this.lblHumanHand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.humanScissors);
            this.Controls.Add(this.humanPaper);
            this.Controls.Add(this.computerPaper);
            this.Controls.Add(this.computerRock);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblGames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.humanRock);
            this.Controls.Add(this.computerScissors);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanSpock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanLizard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerLizard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerSpock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox computerScissors;
        private System.Windows.Forms.PictureBox humanRock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGames;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.PictureBox computerRock;
        private System.Windows.Forms.PictureBox computerPaper;
        private System.Windows.Forms.PictureBox humanPaper;
        private System.Windows.Forms.PictureBox humanScissors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHumanHand;
        private System.Windows.Forms.Label lblComputerHand;
        private System.Windows.Forms.RadioButton rbtnNormal;
        private System.Windows.Forms.RadioButton rbtnSpockLizard;
        private System.Windows.Forms.PictureBox humanSpock;
        private System.Windows.Forms.PictureBox humanLizard;
        private System.Windows.Forms.PictureBox computerLizard;
        private System.Windows.Forms.PictureBox computerSpock;
        private System.Windows.Forms.Button btnLizard;
        private System.Windows.Forms.Button btnSpock;
    }
}


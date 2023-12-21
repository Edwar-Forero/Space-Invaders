namespace SpaceInvader_1._2
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.nave = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.vida1 = new System.Windows.Forms.PictureBox();
            this.vida2 = new System.Windows.Forms.PictureBox();
            this.vida3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vida1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vida2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vida3)).BeginInit();
            this.SuspendLayout();
            // 
            // nave
            // 
            this.nave.Image = global::SpaceInvader_1._2.Properties.Resources.Nave_1;
            this.nave.Location = new System.Drawing.Point(627, 509);
            this.nave.Name = "nave";
            this.nave.Size = new System.Drawing.Size(154, 102);
            this.nave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nave.TabIndex = 0;
            this.nave.TabStop = false;
            this.nave.Click += new System.EventHandler(this.nave_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(11, 638);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "LIFES:";
            // 
            // vida1
            // 
            this.vida1.Image = global::SpaceInvader_1._2.Properties.Resources.Nave_1;
            this.vida1.Location = new System.Drawing.Point(153, 620);
            this.vida1.Name = "vida1";
            this.vida1.Size = new System.Drawing.Size(74, 55);
            this.vida1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vida1.TabIndex = 10;
            this.vida1.TabStop = false;
            // 
            // vida2
            // 
            this.vida2.Image = global::SpaceInvader_1._2.Properties.Resources.Nave_1;
            this.vida2.Location = new System.Drawing.Point(233, 620);
            this.vida2.Name = "vida2";
            this.vida2.Size = new System.Drawing.Size(74, 55);
            this.vida2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vida2.TabIndex = 11;
            this.vida2.TabStop = false;
            // 
            // vida3
            // 
            this.vida3.Image = global::SpaceInvader_1._2.Properties.Resources.Nave_1;
            this.vida3.Location = new System.Drawing.Point(313, 621);
            this.vida3.Name = "vida3";
            this.vida3.Size = new System.Drawing.Size(74, 55);
            this.vida3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vida3.TabIndex = 12;
            this.vida3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Goudy Stout", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(1242, 638);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "0000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Goudy Stout", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(1108, 638);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "SCORE:";
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tag = "2";
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 65;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Goudy Stout", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(761, 638);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Goudy Stout", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(627, 636);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "LEVEL:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1355, 685);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vida3);
            this.Controls.Add(this.vida2);
            this.Controls.Add(this.vida1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nave);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closeForm2);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp_1);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.nave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vida1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vida2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vida3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox nave;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private PictureBox vida1;
        private PictureBox vida2;
        private PictureBox vida3;
        private Label label2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        public Label label3;
        private System.Windows.Forms.Timer timer4;
        public Label label4;
        private Label label5;
    }
}
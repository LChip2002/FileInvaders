using System.Windows.Forms;

namespace File_Invaders_Game
{
    partial class Player
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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.GunTask;
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Player
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(236, 180);
            Controls.Add(pictureBox1);
            KeyPreview = true;
            TopMost = true;
            Name = "Player";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

            // Associate the event-handling method with the
            // KeyDown event.
            //this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        // The form will handle all key events before the control with  
        // focus handles them.  Show the keys pressed by adding the
        // KeyCode object to ListBox1. Ensure the processing is passed
        // to the control with focus by setting the KeyEventArg.Handled
        // property to false.
        private void Player_KeyDown(object sender, KeyEventArgs e)
        {
            // Keyboard inputs
            if (e.KeyCode == Keys.Escape) 
            { 
                Application.Exit();
            }
            else if (e.KeyCode == Keys.Left) 
            {
                this.Location = new Point(this.Location.X - 10, this.Location.Y);
            }
            else if (e.KeyCode == Keys.Right)
            {
                this.Location = new Point(this.Location.X + 10, this.Location.Y);
            }
            else if (e.KeyCode == Keys.Up)
            {
                Bullet bullet = new Bullet() 
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = new Point(this.Location.X, this.Location.Y - 100),
                    Size = new Size(20, 200)
                };

                bullet.Show();
                this.TopMost = true;

                while (bullet.Location.Y != 0)
                {
                    bullet.Location = new Point(bullet.Location.X, bullet.Location.Y - 1);
                }

                //bullet.Fire();
            }

            e.Handled = false;
        }        

        #endregion

        private PictureBox pictureBox1;
    }
}

namespace gruah
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
            button1 = new Button();
            spaceButton = new PictureBox();
            dButton = new PictureBox();
            aButton = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            wButton = new PictureBox();
            sButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)spaceButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sButton).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(68, 16);
            button1.Name = "button1";
            button1.Size = new Size(196, 23);
            button1.TabIndex = 0;
            button1.Text = "removeBorder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // spaceButton
            // 
            spaceButton.BackColor = Color.Transparent;
            spaceButton.BackgroundImageLayout = ImageLayout.Stretch;
            spaceButton.ErrorImage = null;
            spaceButton.Image = Properties.Resources.spaceKey;
            spaceButton.Location = new Point(24, 225);
            spaceButton.Name = "spaceButton";
            spaceButton.Size = new Size(293, 84);
            spaceButton.SizeMode = PictureBoxSizeMode.StretchImage;
            spaceButton.TabIndex = 1;
            spaceButton.TabStop = false;
            // 
            // dButton
            // 
            dButton.BackColor = Color.Transparent;
            dButton.BackgroundImageLayout = ImageLayout.Stretch;
            dButton.Cursor = Cursors.IBeam;
            dButton.Image = Properties.Resources.dkey;
            dButton.Location = new Point(226, 135);
            dButton.Name = "dButton";
            dButton.Size = new Size(91, 84);
            dButton.SizeMode = PictureBoxSizeMode.StretchImage;
            dButton.TabIndex = 3;
            dButton.TabStop = false;
            // 
            // aButton
            // 
            aButton.BackColor = Color.Transparent;
            aButton.BackgroundImageLayout = ImageLayout.Stretch;
            aButton.Cursor = Cursors.IBeam;
            aButton.Image = Properties.Resources.aKey;
            aButton.Location = new Point(24, 135);
            aButton.Name = "aButton";
            aButton.Size = new Size(91, 84);
            aButton.SizeMode = PictureBoxSizeMode.StretchImage;
            aButton.TabIndex = 4;
            aButton.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 329);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 5;
            label1.Text = "(this art is not mine)";
            label1.QueryContinueDrag += Label1_QueryContinueDrag;
            label1.MouseMove += Label1_MouseMove;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Desktop;
            label2.Font = new Font("Segoe UI", 25F);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(12, 286);
            label2.Name = "label2";
            label2.Size = new Size(122, 46);
            label2.TabIndex = 6;
            label2.Text = "crouch";
            // 
            // wButton
            // 
            wButton.ErrorImage = null;
            wButton.Image = Properties.Resources.wKey;
            wButton.Location = new Point(129, 45);
            wButton.Name = "wButton";
            wButton.Size = new Size(91, 84);
            wButton.SizeMode = PictureBoxSizeMode.StretchImage;
            wButton.TabIndex = 7;
            wButton.TabStop = false;
            // 
            // sButton
            // 
            sButton.ErrorImage = null;
            sButton.Image = Properties.Resources.sKey;
            sButton.Location = new Point(129, 135);
            sButton.Name = "sButton";
            sButton.Size = new Size(91, 84);
            sButton.SizeMode = PictureBoxSizeMode.StretchImage;
            sButton.TabIndex = 8;
            sButton.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 350);
            Controls.Add(sButton);
            Controls.Add(wButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(aButton);
            Controls.Add(dButton);
            Controls.Add(spaceButton);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Jello....";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)spaceButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)dButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)aButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)wButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)sButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Label1_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button1;
        private PictureBox spaceButton;
        private PictureBox dButton;
        private PictureBox aButton;
        private Label label1;
        private Label label2;
        private PictureBox wButton;
        private PictureBox sButton;
    }
}

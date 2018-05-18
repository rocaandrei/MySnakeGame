namespace SnakeGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SnakeScoreLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SpaceBarLebel = new System.Windows.Forms.Label();
            this.devLabel = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.SnakeScoreLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 286);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(410, 25);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(51, 20);
            this.toolStripStatusLabel1.Text = "Score:";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // SnakeScoreLabel
            // 
            this.SnakeScoreLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnakeScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SnakeScoreLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.SnakeScoreLabel.Name = "SnakeScoreLabel";
            this.SnakeScoreLabel.Size = new System.Drawing.Size(15, 20);
            this.SnakeScoreLabel.Text = "0";
            this.SnakeScoreLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(300, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 286);
            this.panel1.TabIndex = 2;
            // 
            // SpaceBarLebel
            // 
            this.SpaceBarLebel.AutoSize = true;
            this.SpaceBarLebel.BackColor = System.Drawing.Color.Transparent;
            this.SpaceBarLebel.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpaceBarLebel.ForeColor = System.Drawing.Color.Yellow;
            this.SpaceBarLebel.Location = new System.Drawing.Point(12, 118);
            this.SpaceBarLebel.Name = "SpaceBarLebel";
            this.SpaceBarLebel.Size = new System.Drawing.Size(266, 22);
            this.SpaceBarLebel.TabIndex = 1;
            this.SpaceBarLebel.Text = "Press space to begin. ";
            // 
            // devLabel
            // 
            this.devLabel.AutoSize = true;
            this.devLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.devLabel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devLabel.ForeColor = System.Drawing.Color.Black;
            this.devLabel.Location = new System.Drawing.Point(265, 289);
            this.devLabel.Name = "devLabel";
            this.devLabel.Size = new System.Drawing.Size(112, 16);
            this.devLabel.TabIndex = 2;
            this.devLabel.Text = "Dev by Andrei Roca";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(410, 311);
            this.Controls.Add(this.devLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SpaceBarLebel);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel SnakeScoreLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SpaceBarLebel;
        private System.Windows.Forms.Label devLabel;
    }
}


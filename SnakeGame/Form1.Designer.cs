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
            this.label1 = new System.Windows.Forms.Label();
            this.cbLevel3 = new System.Windows.Forms.CheckBox();
            this.cbLevel2 = new System.Windows.Forms.CheckBox();
            this.cbLevel1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SpaceBarLebel = new System.Windows.Forms.Label();
            this.StartBt = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.StartBt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbLevel3);
            this.panel1.Controls.Add(this.cbLevel2);
            this.panel1.Controls.Add(this.cbLevel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(300, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 286);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(5, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "ENTER LEVEL";
            // 
            // cbLevel3
            // 
            this.cbLevel3.AutoSize = true;
            this.cbLevel3.Location = new System.Drawing.Point(20, 128);
            this.cbLevel3.Name = "cbLevel3";
            this.cbLevel3.Size = new System.Drawing.Size(61, 17);
            this.cbLevel3.TabIndex = 3;
            this.cbLevel3.Text = "Level 3";
            this.cbLevel3.UseVisualStyleBackColor = true;
            // 
            // cbLevel2
            // 
            this.cbLevel2.AutoSize = true;
            this.cbLevel2.Location = new System.Drawing.Point(20, 105);
            this.cbLevel2.Name = "cbLevel2";
            this.cbLevel2.Size = new System.Drawing.Size(61, 17);
            this.cbLevel2.TabIndex = 2;
            this.cbLevel2.Text = "Level 2";
            this.cbLevel2.UseVisualStyleBackColor = true;
            // 
            // cbLevel1
            // 
            this.cbLevel1.AutoSize = true;
            this.cbLevel1.Location = new System.Drawing.Point(20, 82);
            this.cbLevel1.Name = "cbLevel1";
            this.cbLevel1.Size = new System.Drawing.Size(61, 17);
            this.cbLevel1.TabIndex = 1;
            this.cbLevel1.Text = "Level 1";
            this.cbLevel1.UseVisualStyleBackColor = true;
            this.cbLevel1.CheckedChanged += new System.EventHandler(this.cbLevel1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(284, 292);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 13);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Dev by Andrei Roca";
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
            // StartBt
            // 
            this.StartBt.BackColor = System.Drawing.Color.Yellow;
            this.StartBt.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBt.ForeColor = System.Drawing.Color.Green;
            this.StartBt.Location = new System.Drawing.Point(20, 151);
            this.StartBt.Margin = new System.Windows.Forms.Padding(0);
            this.StartBt.Name = "StartBt";
            this.StartBt.Size = new System.Drawing.Size(75, 23);
            this.StartBt.TabIndex = 5;
            this.StartBt.Text = "START";
            this.StartBt.UseVisualStyleBackColor = false;
            this.StartBt.Click += new System.EventHandler(this.StartBt_Click);
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
            this.Controls.Add(this.textBox1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel SnakeScoreLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox cbLevel3;
        private System.Windows.Forms.CheckBox cbLevel2;
        private System.Windows.Forms.CheckBox cbLevel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SpaceBarLebel;
        private System.Windows.Forms.Button StartBt;
    }
}


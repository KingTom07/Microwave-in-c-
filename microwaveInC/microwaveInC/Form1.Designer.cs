namespace microwaveInC
{
    partial class Micro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Stop = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.PowerSlide = new System.Windows.Forms.TrackBar();
            this.TimerBox = new System.Windows.Forms.TextBox();
            this.powerBox = new System.Windows.Forms.TextBox();
            this.Reheat = new System.Windows.Forms.Button();
            this.Defrost = new System.Windows.Forms.Button();
            this.Frozen = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PowerSlide)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 426);
            this.panel1.TabIndex = 0;
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(595, 288);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(98, 55);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.button1_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(492, 288);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(97, 55);
            this.Start.TabIndex = 2;
            this.Start.Text = "start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(699, 288);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(89, 55);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(492, 349);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(296, 89);
            this.Open.TabIndex = 4;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // PowerSlide
            // 
            this.PowerSlide.Location = new System.Drawing.Point(492, 213);
            this.PowerSlide.Name = "PowerSlide";
            this.PowerSlide.Size = new System.Drawing.Size(296, 69);
            this.PowerSlide.TabIndex = 5;
            this.PowerSlide.Scroll += new System.EventHandler(this.PowerSlide_Scroll);
            // 
            // TimerBox
            // 
            this.TimerBox.BackColor = System.Drawing.Color.Gray;
            this.TimerBox.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TimerBox.Location = new System.Drawing.Point(493, 12);
            this.TimerBox.Multiline = true;
            this.TimerBox.Name = "TimerBox";
            this.TimerBox.Size = new System.Drawing.Size(295, 74);
            this.TimerBox.TabIndex = 6;
            this.TimerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // powerBox
            // 
            this.powerBox.Location = new System.Drawing.Point(595, 92);
            this.powerBox.Multiline = true;
            this.powerBox.Name = "powerBox";
            this.powerBox.Size = new System.Drawing.Size(193, 55);
            this.powerBox.TabIndex = 7;
            this.powerBox.TextChanged += new System.EventHandler(this.powerBox_TextChanged);
            // 
            // Reheat
            // 
            this.Reheat.Location = new System.Drawing.Point(493, 92);
            this.Reheat.Name = "Reheat";
            this.Reheat.Size = new System.Drawing.Size(96, 55);
            this.Reheat.TabIndex = 8;
            this.Reheat.Text = "Reheat";
            this.Reheat.UseVisualStyleBackColor = true;
            this.Reheat.Click += new System.EventHandler(this.Reheat_Click);
            // 
            // Defrost
            // 
            this.Defrost.Location = new System.Drawing.Point(492, 153);
            this.Defrost.Name = "Defrost";
            this.Defrost.Size = new System.Drawing.Size(134, 55);
            this.Defrost.TabIndex = 9;
            this.Defrost.Text = "Defrost";
            this.Defrost.UseVisualStyleBackColor = true;
            this.Defrost.Click += new System.EventHandler(this.Defrost_Click);
            // 
            // Frozen
            // 
            this.Frozen.Location = new System.Drawing.Point(632, 153);
            this.Frozen.Name = "Frozen";
            this.Frozen.Size = new System.Drawing.Size(156, 55);
            this.Frozen.TabIndex = 10;
            this.Frozen.Text = "Frozen";
            this.Frozen.UseVisualStyleBackColor = true;
            this.Frozen.Click += new System.EventHandler(this.Frozen_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "menu";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.helpToolStripMenuItem.Text = "help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.settingsToolStripMenuItem.Text = "settings";
            // 
            // Micro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Frozen);
            this.Controls.Add(this.Defrost);
            this.Controls.Add(this.Reheat);
            this.Controls.Add(this.powerBox);
            this.Controls.Add(this.TimerBox);
            this.Controls.Add(this.PowerSlide);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Micro";
            ((System.ComponentModel.ISupportInitialize)(this.PowerSlide)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.TrackBar PowerSlide;
        private System.Windows.Forms.TextBox TimerBox;
        private System.Windows.Forms.TextBox powerBox;
        private System.Windows.Forms.Button Reheat;
        private System.Windows.Forms.Button Defrost;
        private System.Windows.Forms.Button Frozen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}


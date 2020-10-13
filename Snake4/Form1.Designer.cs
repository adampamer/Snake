namespace Snake
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nehézségiszintekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legeslegnehezebbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nehézToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.közepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.könnyűToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.körméreteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szélességToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.növekedikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csökkenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hosszúségToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.növekedikToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.csökkenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pontok:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(601, 56);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 37);
            this.lblScore.TabIndex = 2;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(66, 75);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(102, 37);
            this.lblGameOver.TabIndex = 3;
            this.lblGameOver.Text = "label2";
            this.lblGameOver.Visible = false;
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pbCanvas.InitialImage = null;
            this.pbCanvas.Location = new System.Drawing.Point(12, 43);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(432, 382);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Click += new System.EventHandler(this.pbCanvas_Click);
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(37, 20);
            this.file.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.nehézségiszintekToolStripMenuItem,
            this.körméreteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nehézségiszintekToolStripMenuItem
            // 
            this.nehézségiszintekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.legeslegnehezebbToolStripMenuItem,
            this.nehézToolStripMenuItem,
            this.közepesToolStripMenuItem,
            this.könnyűToolStripMenuItem});
            this.nehézségiszintekToolStripMenuItem.Name = "nehézségiszintekToolStripMenuItem";
            this.nehézségiszintekToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.nehézségiszintekToolStripMenuItem.Text = "Nehézségi_szintek:";
            // 
            // legeslegnehezebbToolStripMenuItem
            // 
            this.legeslegnehezebbToolStripMenuItem.Name = "legeslegnehezebbToolStripMenuItem";
            this.legeslegnehezebbToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.legeslegnehezebbToolStripMenuItem.Text = "Legeslegnehezebb";
            this.legeslegnehezebbToolStripMenuItem.Click += new System.EventHandler(this.legeslegnehezebbToolStripMenuItem_Click);
            // 
            // nehézToolStripMenuItem
            // 
            this.nehézToolStripMenuItem.Name = "nehézToolStripMenuItem";
            this.nehézToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.nehézToolStripMenuItem.Text = "Nehéz";
            this.nehézToolStripMenuItem.Click += new System.EventHandler(this.nehézToolStripMenuItem_Click);
            // 
            // közepesToolStripMenuItem
            // 
            this.közepesToolStripMenuItem.Name = "közepesToolStripMenuItem";
            this.közepesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.közepesToolStripMenuItem.Text = "közepes";
            this.közepesToolStripMenuItem.Click += new System.EventHandler(this.közepesToolStripMenuItem_Click);
            // 
            // könnyűToolStripMenuItem
            // 
            this.könnyűToolStripMenuItem.Name = "könnyűToolStripMenuItem";
            this.könnyűToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.könnyűToolStripMenuItem.Text = "Könnyű";
            this.könnyűToolStripMenuItem.Click += new System.EventHandler(this.könnyűToolStripMenuItem_Click);
            // 
            // körméreteToolStripMenuItem
            // 
            this.körméreteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szélességToolStripMenuItem,
            this.hosszúségToolStripMenuItem});
            this.körméreteToolStripMenuItem.Name = "körméreteToolStripMenuItem";
            this.körméreteToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.körméreteToolStripMenuItem.Text = "Kör_mérete:";
            // 
            // szélességToolStripMenuItem
            // 
            this.szélességToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.növekedikToolStripMenuItem,
            this.csökkenToolStripMenuItem});
            this.szélességToolStripMenuItem.Name = "szélességToolStripMenuItem";
            this.szélességToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.szélességToolStripMenuItem.Text = "Szélesség";
            // 
            // növekedikToolStripMenuItem
            // 
            this.növekedikToolStripMenuItem.Name = "növekedikToolStripMenuItem";
            this.növekedikToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.növekedikToolStripMenuItem.Text = "Növekedik";
            this.növekedikToolStripMenuItem.Click += new System.EventHandler(this.növekedikToolStripMenuItem_Click);
            // 
            // csökkenToolStripMenuItem
            // 
            this.csökkenToolStripMenuItem.Name = "csökkenToolStripMenuItem";
            this.csökkenToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.csökkenToolStripMenuItem.Text = "Csökken";
            this.csökkenToolStripMenuItem.Click += new System.EventHandler(this.csökkenToolStripMenuItem_Click);
            // 
            // hosszúségToolStripMenuItem
            // 
            this.hosszúségToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.növekedikToolStripMenuItem1,
            this.csökkenToolStripMenuItem1});
            this.hosszúségToolStripMenuItem.Name = "hosszúségToolStripMenuItem";
            this.hosszúségToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.hosszúségToolStripMenuItem.Text = "Magasság";
            // 
            // növekedikToolStripMenuItem1
            // 
            this.növekedikToolStripMenuItem1.Name = "növekedikToolStripMenuItem1";
            this.növekedikToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.növekedikToolStripMenuItem1.Text = "Növekedik";
            this.növekedikToolStripMenuItem1.Click += new System.EventHandler(this.növekedikToolStripMenuItem1_Click);
            // 
            // csökkenToolStripMenuItem1
            // 
            this.csökkenToolStripMenuItem1.Name = "csökkenToolStripMenuItem1";
            this.csökkenToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.csökkenToolStripMenuItem1.Text = "Csökken";
            this.csökkenToolStripMenuItem1.Click += new System.EventHandler(this.csökkenToolStripMenuItem1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(774, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(450, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Legmagasabb pontszám:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(849, 434);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCanvas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nehézségiszintekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legeslegnehezebbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nehézToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem közepesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem könnyűToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem körméreteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szélességToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hosszúségToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem növekedikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem csökkenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem növekedikToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem csökkenToolStripMenuItem1;
    }
}


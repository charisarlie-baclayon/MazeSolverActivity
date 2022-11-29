namespace MazeSolverActivity
{
    partial class MazeSolverFrame
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
            this.lblDestPoint = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentPosition = new System.Windows.Forms.Label();
            this.btnResetMaze = new System.Windows.Forms.Button();
            this.chkDiagonal = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioFindPath = new System.Windows.Forms.RadioButton();
            this.radioDrawWall = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureMaze = new System.Windows.Forms.PictureBox();
            this.objectTimer = new System.Windows.Forms.Timer(this.components);
            this.runnerXObject = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaze)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDestPoint
            // 
            this.lblDestPoint.AutoSize = true;
            this.lblDestPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestPoint.Location = new System.Drawing.Point(695, 406);
            this.lblDestPoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestPoint.Name = "lblDestPoint";
            this.lblDestPoint.Size = new System.Drawing.Size(41, 20);
            this.lblDestPoint.TabIndex = 3;
            this.lblDestPoint.Text = "(0,0)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(674, 406);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(634, 389);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Path";
            // 
            // lblCurrentPosition
            // 
            this.lblCurrentPosition.AutoSize = true;
            this.lblCurrentPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPosition.Location = new System.Drawing.Point(639, 406);
            this.lblCurrentPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentPosition.Name = "lblCurrentPosition";
            this.lblCurrentPosition.Size = new System.Drawing.Size(41, 20);
            this.lblCurrentPosition.TabIndex = 0;
            this.lblCurrentPosition.Text = "(0,0)";
            // 
            // btnResetMaze
            // 
            this.btnResetMaze.Location = new System.Drawing.Point(654, 278);
            this.btnResetMaze.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetMaze.Name = "btnResetMaze";
            this.btnResetMaze.Size = new System.Drawing.Size(80, 37);
            this.btnResetMaze.TabIndex = 0;
            this.btnResetMaze.Text = "Reset Maze";
            this.btnResetMaze.UseVisualStyleBackColor = true;
            this.btnResetMaze.Click += new System.EventHandler(this.btnClearWalls_Click);
            // 
            // chkDiagonal
            // 
            this.chkDiagonal.AutoSize = true;
            this.chkDiagonal.Location = new System.Drawing.Point(643, 249);
            this.chkDiagonal.Margin = new System.Windows.Forms.Padding(2);
            this.chkDiagonal.Name = "chkDiagonal";
            this.chkDiagonal.Size = new System.Drawing.Size(101, 17);
            this.chkDiagonal.TabIndex = 0;
            this.chkDiagonal.Text = "Allow Diagonals";
            this.chkDiagonal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioFindPath);
            this.groupBox1.Controls.Add(this.radioDrawWall);
            this.groupBox1.Location = new System.Drawing.Point(625, 156);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(137, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // radioFindPath
            // 
            this.radioFindPath.AutoSize = true;
            this.radioFindPath.Location = new System.Drawing.Point(24, 46);
            this.radioFindPath.Margin = new System.Windows.Forms.Padding(2);
            this.radioFindPath.Name = "radioFindPath";
            this.radioFindPath.Size = new System.Drawing.Size(70, 17);
            this.radioFindPath.TabIndex = 6;
            this.radioFindPath.Text = "Find Path";
            this.radioFindPath.UseVisualStyleBackColor = true;
            // 
            // radioDrawWall
            // 
            this.radioDrawWall.AutoSize = true;
            this.radioDrawWall.Checked = true;
            this.radioDrawWall.Location = new System.Drawing.Point(24, 24);
            this.radioDrawWall.Margin = new System.Windows.Forms.Padding(2);
            this.radioDrawWall.Name = "radioDrawWall";
            this.radioDrawWall.Size = new System.Drawing.Size(79, 17);
            this.radioDrawWall.TabIndex = 5;
            this.radioDrawWall.TabStop = true;
            this.radioDrawWall.Text = "Draw Walls";
            this.radioDrawWall.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureMaze
            // 
            this.pictureMaze.Location = new System.Drawing.Point(26, 26);
            this.pictureMaze.Margin = new System.Windows.Forms.Padding(2);
            this.pictureMaze.Name = "pictureMaze";
            this.pictureMaze.Size = new System.Drawing.Size(562, 455);
            this.pictureMaze.TabIndex = 3;
            this.pictureMaze.TabStop = false;
            this.pictureMaze.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureMaze_Paint);
            this.pictureMaze.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureMaze_MouseMove);
            this.pictureMaze.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureMaze_MouseUp);
            // 
            // objectTimer
            // 
            this.objectTimer.Interval = 500;
            this.objectTimer.Tick += new System.EventHandler(this.objectTimer_Tick);
            // 
            // runnerXObject
            // 
            this.runnerXObject.Interval = 500;
            this.runnerXObject.Tick += new System.EventHandler(this.runnerObject_Tick);
            // 
            // MazeSolverFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 509);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDestPoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResetMaze);
            this.Controls.Add(this.pictureMaze);
            this.Controls.Add(this.lblCurrentPosition);
            this.Controls.Add(this.chkDiagonal);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MazeSolverFrame";
            this.Text = "Maze Solver";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaze)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkDiagonal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureMaze;
        private System.Windows.Forms.RadioButton radioFindPath;
        private System.Windows.Forms.RadioButton radioDrawWall;
        private System.Windows.Forms.Button btnResetMaze;
        private System.Windows.Forms.Label lblCurrentPosition;
        private System.Windows.Forms.Label lblDestPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer objectTimer;
        private System.Windows.Forms.Timer runnerXObject;
    }
}


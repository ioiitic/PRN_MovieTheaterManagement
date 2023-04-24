namespace WinApp
{
    partial class frmMovieManagement
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
            menuStrip1=new System.Windows.Forms.MenuStrip();
            homeToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            manageToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            manageTheaterToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            manageMovieToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            manageShowtimeToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            reportToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            dgvMovie=new System.Windows.Forms.DataGridView();
            btnAdd=new System.Windows.Forms.Button();
            btnDelete=new System.Windows.Forms.Button();
            label1=new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovie).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize=new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { homeToolStripMenuItem, manageToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location=new System.Drawing.Point(0, 0);
            menuStrip1.Name="menuStrip1";
            menuStrip1.Size=new System.Drawing.Size(844, 28);
            menuStrip1.TabIndex=15;
            menuStrip1.Text="menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name="homeToolStripMenuItem";
            homeToolStripMenuItem.Size=new System.Drawing.Size(64, 24);
            homeToolStripMenuItem.Text="Home";
            homeToolStripMenuItem.Click+=homeToolStripMenuItem_Click;
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { manageTheaterToolStripMenuItem, manageMovieToolStripMenuItem, manageShowtimeToolStripMenuItem, reportToolStripMenuItem });
            manageToolStripMenuItem.Name="manageToolStripMenuItem";
            manageToolStripMenuItem.Size=new System.Drawing.Size(77, 24);
            manageToolStripMenuItem.Text="Manage";
            // 
            // manageTheaterToolStripMenuItem
            // 
            manageTheaterToolStripMenuItem.Name="manageTheaterToolStripMenuItem";
            manageTheaterToolStripMenuItem.Size=new System.Drawing.Size(216, 26);
            manageTheaterToolStripMenuItem.Text="Manage Theater";
            // 
            // manageMovieToolStripMenuItem
            // 
            manageMovieToolStripMenuItem.Name="manageMovieToolStripMenuItem";
            manageMovieToolStripMenuItem.Size=new System.Drawing.Size(216, 26);
            manageMovieToolStripMenuItem.Text="Manage Movie";
            // 
            // manageShowtimeToolStripMenuItem
            // 
            manageShowtimeToolStripMenuItem.Name="manageShowtimeToolStripMenuItem";
            manageShowtimeToolStripMenuItem.Size=new System.Drawing.Size(216, 26);
            manageShowtimeToolStripMenuItem.Text="Manage Showtime";
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.Name="reportToolStripMenuItem";
            reportToolStripMenuItem.Size=new System.Drawing.Size(216, 26);
            reportToolStripMenuItem.Text="Report";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name="exitToolStripMenuItem";
            exitToolStripMenuItem.Size=new System.Drawing.Size(47, 24);
            exitToolStripMenuItem.Text="Exit";
            exitToolStripMenuItem.Click+=exitToolStripMenuItem_Click;
            // 
            // dgvMovie
            // 
            dgvMovie.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovie.Location=new System.Drawing.Point(12, 126);
            dgvMovie.Name="dgvMovie";
            dgvMovie.RowHeadersWidth=51;
            dgvMovie.RowTemplate.Height=29;
            dgvMovie.Size=new System.Drawing.Size(651, 371);
            dgvMovie.TabIndex=16;
            // 
            // btnAdd
            // 
            btnAdd.Location=new System.Drawing.Point(681, 126);
            btnAdd.Name="btnAdd";
            btnAdd.Size=new System.Drawing.Size(119, 44);
            btnAdd.TabIndex=17;
            btnAdd.Text="Add";
            btnAdd.UseVisualStyleBackColor=true;
            // 
            // btnDelete
            // 
            btnDelete.Location=new System.Drawing.Point(681, 200);
            btnDelete.Name="btnDelete";
            btnDelete.Size=new System.Drawing.Size(119, 50);
            btnDelete.TabIndex=18;
            btnDelete.Text="Delete";
            btnDelete.UseVisualStyleBackColor=true;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor=System.Drawing.Color.FromArgb(255, 192, 192);
            label1.Location=new System.Drawing.Point(338, 48);
            label1.Name="label1";
            label1.Size=new System.Drawing.Size(177, 35);
            label1.TabIndex=19;
            label1.Text="MOVIE LIST";
            // 
            // frmMovieManagement
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(844, 509);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvMovie);
            Controls.Add(menuStrip1);
            Name="frmMovieManagement";
            Text="Movie Management";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTheaterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageShowtimeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvMovie;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
    }
}

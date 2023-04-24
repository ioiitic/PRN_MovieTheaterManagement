namespace WinApp
{
    partial class frmTheaterManagement
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
            dgvTheater=new System.Windows.Forms.DataGridView();
            dgvRoom=new System.Windows.Forms.DataGridView();
            label1=new System.Windows.Forms.Label();
            label2=new System.Windows.Forms.Label();
            label3=new System.Windows.Forms.Label();
            label4=new System.Windows.Forms.Label();
            txtTheaterID=new System.Windows.Forms.TextBox();
            txtTheaterName=new System.Windows.Forms.TextBox();
            txtTheaterAdd=new System.Windows.Forms.TextBox();
            txtTheaterPhone=new System.Windows.Forms.TextBox();
            btnAddTheater=new System.Windows.Forms.Button();
            btnDeleteTheater=new System.Windows.Forms.Button();
            btnAddRoom=new System.Windows.Forms.Button();
            btnDeleteRoom=new System.Windows.Forms.Button();
            menuStrip1=new System.Windows.Forms.MenuStrip();
            homeToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            manageToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            manageTheaterToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            manageMovieToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            reportToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            manageShowtimeToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvTheater).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoom).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTheater
            // 
            dgvTheater.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTheater.Location=new System.Drawing.Point(12, 313);
            dgvTheater.Name="dgvTheater";
            dgvTheater.RowHeadersWidth=51;
            dgvTheater.RowTemplate.Height=29;
            dgvTheater.Size=new System.Drawing.Size(536, 304);
            dgvTheater.TabIndex=0;
            // 
            // dgvRoom
            // 
            dgvRoom.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoom.Location=new System.Drawing.Point(549, 42);
            dgvRoom.Name="dgvRoom";
            dgvRoom.RowHeadersWidth=51;
            dgvRoom.RowTemplate.Height=29;
            dgvRoom.Size=new System.Drawing.Size(427, 265);
            dgvRoom.TabIndex=1;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location=new System.Drawing.Point(27, 60);
            label1.Name="label1";
            label1.Size=new System.Drawing.Size(93, 25);
            label1.TabIndex=2;
            label1.Text="Theater ID";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location=new System.Drawing.Point(27, 109);
            label2.Name="label2";
            label2.Size=new System.Drawing.Size(122, 25);
            label2.TabIndex=3;
            label2.Text="Theater Name";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location=new System.Drawing.Point(27, 157);
            label3.Name="label3";
            label3.Size=new System.Drawing.Size(140, 25);
            label3.TabIndex=4;
            label3.Text="Theater Address";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Font=new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location=new System.Drawing.Point(27, 196);
            label4.Name="label4";
            label4.Size=new System.Drawing.Size(190, 25);
            label4.TabIndex=5;
            label4.Text="Theater PhoneNumber";
            // 
            // txtTheaterID
            // 
            txtTheaterID.Location=new System.Drawing.Point(236, 61);
            txtTheaterID.Name="txtTheaterID";
            txtTheaterID.Size=new System.Drawing.Size(213, 27);
            txtTheaterID.TabIndex=6;
            // 
            // txtTheaterName
            // 
            txtTheaterName.Location=new System.Drawing.Point(236, 110);
            txtTheaterName.Name="txtTheaterName";
            txtTheaterName.Size=new System.Drawing.Size(213, 27);
            txtTheaterName.TabIndex=7;
            // 
            // txtTheaterAdd
            // 
            txtTheaterAdd.Location=new System.Drawing.Point(236, 158);
            txtTheaterAdd.Name="txtTheaterAdd";
            txtTheaterAdd.Size=new System.Drawing.Size(213, 27);
            txtTheaterAdd.TabIndex=8;
            // 
            // txtTheaterPhone
            // 
            txtTheaterPhone.Location=new System.Drawing.Point(236, 197);
            txtTheaterPhone.Name="txtTheaterPhone";
            txtTheaterPhone.Size=new System.Drawing.Size(213, 27);
            txtTheaterPhone.TabIndex=9;
            // 
            // btnAddTheater
            // 
            btnAddTheater.Location=new System.Drawing.Point(148, 253);
            btnAddTheater.Name="btnAddTheater";
            btnAddTheater.Size=new System.Drawing.Size(94, 29);
            btnAddTheater.TabIndex=10;
            btnAddTheater.Text="Add";
            btnAddTheater.UseVisualStyleBackColor=true;
            // 
            // btnDeleteTheater
            // 
            btnDeleteTheater.Location=new System.Drawing.Point(292, 253);
            btnDeleteTheater.Name="btnDeleteTheater";
            btnDeleteTheater.Size=new System.Drawing.Size(94, 29);
            btnDeleteTheater.TabIndex=11;
            btnDeleteTheater.Text="Delete";
            btnDeleteTheater.UseVisualStyleBackColor=true;
            // 
            // btnAddRoom
            // 
            btnAddRoom.Location=new System.Drawing.Point(609, 330);
            btnAddRoom.Name="btnAddRoom";
            btnAddRoom.Size=new System.Drawing.Size(130, 37);
            btnAddRoom.TabIndex=12;
            btnAddRoom.Text="Add";
            btnAddRoom.UseVisualStyleBackColor=true;
            // 
            // btnDeleteRoom
            // 
            btnDeleteRoom.Location=new System.Drawing.Point(794, 330);
            btnDeleteRoom.Name="btnDeleteRoom";
            btnDeleteRoom.Size=new System.Drawing.Size(129, 39);
            btnDeleteRoom.TabIndex=13;
            btnDeleteRoom.Text="Delete";
            btnDeleteRoom.UseVisualStyleBackColor=true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize=new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { homeToolStripMenuItem, manageToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location=new System.Drawing.Point(0, 0);
            menuStrip1.Name="menuStrip1";
            menuStrip1.Size=new System.Drawing.Size(983, 28);
            menuStrip1.TabIndex=14;
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
            manageTheaterToolStripMenuItem.Size=new System.Drawing.Size(224, 26);
            manageTheaterToolStripMenuItem.Text="Manage Theater";
            // 
            // manageMovieToolStripMenuItem
            // 
            manageMovieToolStripMenuItem.Name="manageMovieToolStripMenuItem";
            manageMovieToolStripMenuItem.Size=new System.Drawing.Size(224, 26);
            manageMovieToolStripMenuItem.Text="Manage Movie";
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.Name="reportToolStripMenuItem";
            reportToolStripMenuItem.Size=new System.Drawing.Size(224, 26);
            reportToolStripMenuItem.Text="Report";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name="exitToolStripMenuItem";
            exitToolStripMenuItem.Size=new System.Drawing.Size(47, 24);
            exitToolStripMenuItem.Text="Exit";
            exitToolStripMenuItem.Click+=exitToolStripMenuItem_Click;
            // 
            // manageShowtimeToolStripMenuItem
            // 
            manageShowtimeToolStripMenuItem.Name="manageShowtimeToolStripMenuItem";
            manageShowtimeToolStripMenuItem.Size=new System.Drawing.Size(224, 26);
            manageShowtimeToolStripMenuItem.Text="Manage Showtime";
            // 
            // frmTheaterManagement
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(983, 629);
            Controls.Add(btnDeleteRoom);
            Controls.Add(btnAddRoom);
            Controls.Add(btnDeleteTheater);
            Controls.Add(btnAddTheater);
            Controls.Add(txtTheaterPhone);
            Controls.Add(txtTheaterAdd);
            Controls.Add(txtTheaterName);
            Controls.Add(txtTheaterID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvRoom);
            Controls.Add(dgvTheater);
            Controls.Add(menuStrip1);
            MainMenuStrip=menuStrip1;
            Name="frmTheaterManagement";
            StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            Text="Theater Management";
            ((System.ComponentModel.ISupportInitialize)dgvTheater).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoom).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTheater;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTheaterID;
        private System.Windows.Forms.TextBox txtTheaterName;
        private System.Windows.Forms.TextBox txtTheaterAdd;
        private System.Windows.Forms.TextBox txtTheaterPhone;
        private System.Windows.Forms.Button btnAddTheater;
        private System.Windows.Forms.Button btnDeleteTheater;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTheaterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageShowtimeToolStripMenuItem;
    }
}
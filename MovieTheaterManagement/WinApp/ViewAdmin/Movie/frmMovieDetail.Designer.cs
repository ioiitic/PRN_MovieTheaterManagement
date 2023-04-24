namespace WinApp.ViewAdmin.Movie
{
    partial class frmMovieDetail
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
            label1=new System.Windows.Forms.Label();
            btnAction=new System.Windows.Forms.Button();
            btnCancel=new System.Windows.Forms.Button();
            label2=new System.Windows.Forms.Label();
            label3=new System.Windows.Forms.Label();
            label4=new System.Windows.Forms.Label();
            label5=new System.Windows.Forms.Label();
            label6=new System.Windows.Forms.Label();
            txtMovieId=new System.Windows.Forms.TextBox();
            txtMovieTitle=new System.Windows.Forms.TextBox();
            txtDes=new System.Windows.Forms.TextBox();
            txtDuration=new System.Windows.Forms.TextBox();
            cboGenre=new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location=new System.Drawing.Point(114, 20);
            label1.Name="label1";
            label1.Size=new System.Drawing.Size(151, 31);
            label1.TabIndex=0;
            label1.Text="Movie Detail";
            // 
            // btnAction
            // 
            btnAction.Location=new System.Drawing.Point(55, 411);
            btnAction.Name="btnAction";
            btnAction.Size=new System.Drawing.Size(97, 29);
            btnAction.TabIndex=1;
            btnAction.Text="Action";
            btnAction.UseVisualStyleBackColor=true;
            // 
            // btnCancel
            // 
            btnCancel.Location=new System.Drawing.Point(231, 411);
            btnCancel.Name="btnCancel";
            btnCancel.Size=new System.Drawing.Size(99, 29);
            btnCancel.TabIndex=2;
            btnCancel.Text="Cancel";
            btnCancel.UseVisualStyleBackColor=true;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location=new System.Drawing.Point(46, 94);
            label2.Name="label2";
            label2.Size=new System.Drawing.Size(91, 28);
            label2.TabIndex=3;
            label2.Text="Movie ID";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location=new System.Drawing.Point(46, 145);
            label3.Name="label3";
            label3.Size=new System.Drawing.Size(109, 28);
            label3.TabIndex=4;
            label3.Text="Movie Title";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Font=new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location=new System.Drawing.Point(46, 248);
            label4.Name="label4";
            label4.Size=new System.Drawing.Size(112, 28);
            label4.TabIndex=5;
            label4.Text="Description";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Font=new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location=new System.Drawing.Point(46, 197);
            label5.Name="label5";
            label5.Size=new System.Drawing.Size(64, 28);
            label5.TabIndex=6;
            label5.Text="Genre";
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Font=new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location=new System.Drawing.Point(46, 307);
            label6.Name="label6";
            label6.Size=new System.Drawing.Size(89, 28);
            label6.TabIndex=7;
            label6.Text="Duration";
            // 
            // txtMovieId
            // 
            txtMovieId.Location=new System.Drawing.Point(187, 98);
            txtMovieId.Name="txtMovieId";
            txtMovieId.Size=new System.Drawing.Size(173, 27);
            txtMovieId.TabIndex=8;
            // 
            // txtMovieTitle
            // 
            txtMovieTitle.Location=new System.Drawing.Point(187, 149);
            txtMovieTitle.Name="txtMovieTitle";
            txtMovieTitle.Size=new System.Drawing.Size(173, 27);
            txtMovieTitle.TabIndex=9;
            // 
            // txtDes
            // 
            txtDes.Location=new System.Drawing.Point(187, 248);
            txtDes.Name="txtDes";
            txtDes.Size=new System.Drawing.Size(173, 27);
            txtDes.TabIndex=11;
            // 
            // txtDuration
            // 
            txtDuration.Location=new System.Drawing.Point(187, 307);
            txtDuration.Name="txtDuration";
            txtDuration.Size=new System.Drawing.Size(173, 27);
            txtDuration.TabIndex=12;
            // 
            // cboGenre
            // 
            cboGenre.FormattingEnabled=true;
            cboGenre.Location=new System.Drawing.Point(187, 197);
            cboGenre.Name="cboGenre";
            cboGenre.Size=new System.Drawing.Size(173, 28);
            cboGenre.TabIndex=13;
            // 
            // frmMovieDetail
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(372, 473);
            Controls.Add(cboGenre);
            Controls.Add(txtDuration);
            Controls.Add(txtDes);
            Controls.Add(txtMovieTitle);
            Controls.Add(txtMovieId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnAction);
            Controls.Add(label1);
            Name="frmMovieDetail";
            Text="Movie Detail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMovieId;
        private System.Windows.Forms.TextBox txtMovieTitle;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.ComboBox cboGenre;
    }
}
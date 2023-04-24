namespace WinApp
{
    partial class frmAdmin
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
            btnExit=new System.Windows.Forms.Button();
            button3=new System.Windows.Forms.Button();
            button2=new System.Windows.Forms.Button();
            btnTheater=new System.Windows.Forms.Button();
            label1=new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor=System.Drawing.Color.Red;
            btnExit.Font=new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnExit.ForeColor=System.Drawing.Color.White;
            btnExit.Location=new System.Drawing.Point(756, 392);
            btnExit.Name="btnExit";
            btnExit.Size=new System.Drawing.Size(94, 29);
            btnExit.TabIndex=9;
            btnExit.Text="Exit";
            btnExit.UseVisualStyleBackColor=false;
            // 
            // button3
            // 
            button3.BackColor=System.Drawing.Color.FromArgb(255, 192, 192);
            button3.Font=new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button3.Location=new System.Drawing.Point(600, 146);
            button3.Name="button3";
            button3.Size=new System.Drawing.Size(222, 145);
            button3.TabIndex=8;
            button3.Text="Report";
            button3.UseVisualStyleBackColor=false;
            // 
            // button2
            // 
            button2.BackColor=System.Drawing.Color.FromArgb(255, 192, 192);
            button2.Font=new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor=System.Drawing.SystemColors.ControlText;
            button2.Location=new System.Drawing.Point(319, 146);
            button2.Name="button2";
            button2.Size=new System.Drawing.Size(222, 145);
            button2.TabIndex=7;
            button2.Text="Manage Movie";
            button2.UseVisualStyleBackColor=false;
            // 
            // btnTheater
            // 
            btnTheater.BackColor=System.Drawing.Color.FromArgb(255, 192, 192);
            btnTheater.Font=new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnTheater.Location=new System.Drawing.Point(43, 146);
            btnTheater.Name="btnTheater";
            btnTheater.Size=new System.Drawing.Size(222, 145);
            btnTheater.TabIndex=6;
            btnTheater.Text="Manage Theater";
            btnTheater.UseVisualStyleBackColor=false;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location=new System.Drawing.Point(248, 38);
            label1.Name="label1";
            label1.Size=new System.Drawing.Size(405, 62);
            label1.TabIndex=5;
            label1.Text="Welcome Admin!";
            // 
            // frmAdmin
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(862, 433);
            Controls.Add(btnExit);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnTheater);
            Controls.Add(label1);
            Name="frmAdmin";
            Text="Admin Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnTheater;
        private System.Windows.Forms.Label label1;
    }
}
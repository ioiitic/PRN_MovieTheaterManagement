namespace WinApp.ViewAdmin.Theater
{
    partial class frmTheaterDetail
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
            txtPhone=new System.Windows.Forms.TextBox();
            txtAdd=new System.Windows.Forms.TextBox();
            txtTheaterName=new System.Windows.Forms.TextBox();
            txtTheaterID=new System.Windows.Forms.TextBox();
            label6=new System.Windows.Forms.Label();
            label5=new System.Windows.Forms.Label();
            label4=new System.Windows.Forms.Label();
            label3=new System.Windows.Forms.Label();
            label2=new System.Windows.Forms.Label();
            btnCancel=new System.Windows.Forms.Button();
            btnAction=new System.Windows.Forms.Button();
            label1=new System.Windows.Forms.Label();
            txtEmail=new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // txtPhone
            // 
            txtPhone.Location=new System.Drawing.Point(181, 302);
            txtPhone.Name="txtPhone";
            txtPhone.Size=new System.Drawing.Size(173, 27);
            txtPhone.TabIndex=25;
            // 
            // txtAdd
            // 
            txtAdd.Location=new System.Drawing.Point(181, 243);
            txtAdd.Name="txtAdd";
            txtAdd.Size=new System.Drawing.Size(173, 27);
            txtAdd.TabIndex=24;
            // 
            // txtTheaterName
            // 
            txtTheaterName.Location=new System.Drawing.Point(181, 144);
            txtTheaterName.Name="txtTheaterName";
            txtTheaterName.Size=new System.Drawing.Size(173, 27);
            txtTheaterName.TabIndex=23;
            // 
            // txtTheaterID
            // 
            txtTheaterID.Location=new System.Drawing.Point(181, 93);
            txtTheaterID.Name="txtTheaterID";
            txtTheaterID.Size=new System.Drawing.Size(173, 27);
            txtTheaterID.TabIndex=22;
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Font=new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location=new System.Drawing.Point(30, 298);
            label6.Name="label6";
            label6.Size=new System.Drawing.Size(144, 28);
            label6.TabIndex=21;
            label6.Text="Phone Number";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Font=new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location=new System.Drawing.Point(30, 192);
            label5.Name="label5";
            label5.Size=new System.Drawing.Size(59, 28);
            label5.TabIndex=20;
            label5.Text="Email";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Font=new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location=new System.Drawing.Point(30, 243);
            label4.Name="label4";
            label4.Size=new System.Drawing.Size(82, 28);
            label4.TabIndex=19;
            label4.Text="Address";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location=new System.Drawing.Point(30, 140);
            label3.Name="label3";
            label3.Size=new System.Drawing.Size(134, 28);
            label3.TabIndex=18;
            label3.Text="Theater Name";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location=new System.Drawing.Point(30, 93);
            label2.Name="label2";
            label2.Size=new System.Drawing.Size(101, 28);
            label2.TabIndex=17;
            label2.Text="Theater ID";
            // 
            // btnCancel
            // 
            btnCancel.Location=new System.Drawing.Point(222, 406);
            btnCancel.Name="btnCancel";
            btnCancel.Size=new System.Drawing.Size(99, 29);
            btnCancel.TabIndex=16;
            btnCancel.Text="Cancel";
            btnCancel.UseVisualStyleBackColor=true;
            // 
            // btnAction
            // 
            btnAction.Location=new System.Drawing.Point(55, 406);
            btnAction.Name="btnAction";
            btnAction.Size=new System.Drawing.Size(97, 29);
            btnAction.TabIndex=15;
            btnAction.Text="Action";
            btnAction.UseVisualStyleBackColor=true;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location=new System.Drawing.Point(86, 15);
            label1.Name="label1";
            label1.Size=new System.Drawing.Size(165, 31);
            label1.TabIndex=14;
            label1.Text="Theater Detail";
            // 
            // txtEmail
            // 
            txtEmail.Location=new System.Drawing.Point(181, 196);
            txtEmail.Name="txtEmail";
            txtEmail.Size=new System.Drawing.Size(173, 27);
            txtEmail.TabIndex=26;
            // 
            // frmTheaterDetail
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(371, 476);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtAdd);
            Controls.Add(txtTheaterName);
            Controls.Add(txtTheaterID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnAction);
            Controls.Add(label1);
            Name="frmTheaterDetail";
            Text="Theater Detail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtTheaterName;
        private System.Windows.Forms.TextBox txtTheaterID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
    }
}
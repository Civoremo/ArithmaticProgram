namespace ArithmaticProgram
{
    partial class frmMain
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
            this.txtNumOne = new System.Windows.Forms.TextBox();
            this.txtNumTwo = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblPlus = new System.Windows.Forms.Label();
            this.lblEqual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCorrect = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtWrong = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumOne
            // 
            this.txtNumOne.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumOne.Enabled = false;
            this.txtNumOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOne.Location = new System.Drawing.Point(26, 73);
            this.txtNumOne.Name = "txtNumOne";
            this.txtNumOne.ReadOnly = true;
            this.txtNumOne.Size = new System.Drawing.Size(119, 116);
            this.txtNumOne.TabIndex = 0;
            this.txtNumOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumTwo
            // 
            this.txtNumTwo.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumTwo.Enabled = false;
            this.txtNumTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTwo.Location = new System.Drawing.Point(241, 73);
            this.txtNumTwo.Name = "txtNumTwo";
            this.txtNumTwo.ReadOnly = true;
            this.txtNumTwo.Size = new System.Drawing.Size(114, 116);
            this.txtNumTwo.TabIndex = 1;
            this.txtNumTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.Window;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(451, 73);
            this.txtResult.MaxLength = 2;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(121, 116);
            this.txtResult.TabIndex = 2;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPlus
            // 
            this.lblPlus.AutoSize = true;
            this.lblPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus.Location = new System.Drawing.Point(149, 90);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(86, 91);
            this.lblPlus.TabIndex = 3;
            this.lblPlus.Text = "+";
            // 
            // lblEqual
            // 
            this.lblEqual.AutoSize = true;
            this.lblEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqual.Location = new System.Drawing.Point(359, 90);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(86, 91);
            this.lblEqual.TabIndex = 4;
            this.lblEqual.Text = "=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Correct";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Missed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total";
            // 
            // txtCorrect
            // 
            this.txtCorrect.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCorrect.Enabled = false;
            this.txtCorrect.Location = new System.Drawing.Point(58, 294);
            this.txtCorrect.Name = "txtCorrect";
            this.txtCorrect.ReadOnly = true;
            this.txtCorrect.Size = new System.Drawing.Size(50, 20);
            this.txtCorrect.TabIndex = 9;
            this.txtCorrect.Text = "0";
            this.txtCorrect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(58, 333);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(50, 20);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWrong
            // 
            this.txtWrong.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtWrong.Enabled = false;
            this.txtWrong.Location = new System.Drawing.Point(58, 313);
            this.txtWrong.Name = "txtWrong";
            this.txtWrong.ReadOnly = true;
            this.txtWrong.Size = new System.Drawing.Size(50, 20);
            this.txtWrong.TabIndex = 12;
            this.txtWrong.Text = "0";
            this.txtWrong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(179, 215);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(248, 59);
            this.btnCheck.TabIndex = 13;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(200, 15);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 55);
            this.lblAnswer.TabIndex = 14;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtWrong);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtCorrect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEqual);
            this.Controls.Add(this.lblPlus);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNumTwo);
            this.Controls.Add(this.txtNumOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Learning Math (Addition)";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumOne;
        private System.Windows.Forms.TextBox txtNumTwo;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.Label lblEqual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCorrect;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtWrong;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblAnswer;
    }
}


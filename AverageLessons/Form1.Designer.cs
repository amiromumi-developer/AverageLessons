namespace AverageLessons
{
    partial class AverageForm
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
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtRatio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAvg = new System.Windows.Forms.Button();
            this.lblResualt = new System.Windows.Forms.Label();
            this.nextLssson = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(200, 18);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(146, 21);
            this.txtScore.TabIndex = 0;
            // 
            // txtRatio
            // 
            this.txtRatio.Location = new System.Drawing.Point(200, 60);
            this.txtRatio.Name = "txtRatio";
            this.txtRatio.Size = new System.Drawing.Size(146, 21);
            this.txtRatio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "نمره درس :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "واحد درس :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(308, 91);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 45);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "اضافه";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAvg
            // 
            this.btnAvg.Location = new System.Drawing.Point(200, 91);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(100, 45);
            this.btnAvg.TabIndex = 5;
            this.btnAvg.Text = "میانگین";
            this.btnAvg.UseVisualStyleBackColor = true;
            this.btnAvg.Click += new System.EventHandler(this.btnAvg_Click);
            // 
            // lblResualt
            // 
            this.lblResualt.AutoSize = true;
            this.lblResualt.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResualt.ForeColor = System.Drawing.Color.Red;
            this.lblResualt.Location = new System.Drawing.Point(23, 118);
            this.lblResualt.Name = "lblResualt";
            this.lblResualt.Size = new System.Drawing.Size(77, 58);
            this.lblResualt.TabIndex = 6;
            this.lblResualt.Text = "11";
            this.lblResualt.Visible = false;
            this.lblResualt.Click += new System.EventHandler(this.lblResualt_Click);
            // 
            // nextLssson
            // 
            this.nextLssson.AutoSize = true;
            this.nextLssson.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextLssson.ForeColor = System.Drawing.Color.Coral;
            this.nextLssson.Location = new System.Drawing.Point(23, 21);
            this.nextLssson.Name = "nextLssson";
            this.nextLssson.Size = new System.Drawing.Size(139, 33);
            this.nextLssson.TabIndex = 7;
            this.nextLssson.Text = "درس بعدی";
            this.nextLssson.Visible = false;
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvg.ForeColor = System.Drawing.Color.Green;
            this.lblAvg.Location = new System.Drawing.Point(23, 76);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(118, 42);
            this.lblAvg.TabIndex = 8;
            this.lblAvg.Text = "معدل :";
            this.lblAvg.Visible = false;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(200, 142);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(208, 39);
            this.resetBtn.TabIndex = 9;
            this.resetBtn.Text = "بازنشانی";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // AverageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 189);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.nextLssson);
            this.Controls.Add(this.lblResualt);
            this.Controls.Add(this.btnAvg);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRatio);
            this.Controls.Add(this.txtScore);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AverageForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Calculate the average lessons";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtRatio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAvg;
        private System.Windows.Forms.Label lblResualt;
        private System.Windows.Forms.Label nextLssson;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Button resetBtn;
    }
}


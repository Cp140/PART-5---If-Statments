namespace PART_5_If_Statments
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
            this.btnSubmitAge = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmitAge
            // 
            this.btnSubmitAge.Location = new System.Drawing.Point(433, 168);
            this.btnSubmitAge.Name = "btnSubmitAge";
            this.btnSubmitAge.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitAge.TabIndex = 0;
            this.btnSubmitAge.Text = "button1";
            this.btnSubmitAge.UseVisualStyleBackColor = true;
            this.btnSubmitAge.Click += new System.EventHandler(this.btnSubmitAge_Click_1);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(424, 98);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // lblStage
            // 
            this.lblStage.AutoSize = true;
            this.lblStage.Location = new System.Drawing.Point(440, 141);
            this.lblStage.Name = "lblStage";
            this.lblStage.Size = new System.Drawing.Size(55, 13);
            this.lblStage.TabIndex = 3;
            this.lblStage.Text = "Life Stage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.btnSubmitAge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStage;
    }
}


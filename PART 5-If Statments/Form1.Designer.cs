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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblStage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmitAge
            // 
            this.btnSubmitAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitAge.Location = new System.Drawing.Point(192, 86);
            this.btnSubmitAge.Name = "btnSubmitAge";
            this.btnSubmitAge.Size = new System.Drawing.Size(91, 37);
            this.btnSubmitAge.TabIndex = 0;
            this.btnSubmitAge.Text = "Get results";
            this.btnSubmitAge.UseVisualStyleBackColor = true;
            this.btnSubmitAge.Click += new System.EventHandler(this.btnSubmitAge_Click_1);
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(12, 56);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(293, 24);
            this.txtAge.TabIndex = 1;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(12, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(284, 44);
            this.lblInstructions.TabIndex = 2;
            this.lblInstructions.Text = "Enter an age and the program will \r\ntell you what strage if life it is.";
            // 
            // lblStage
            // 
            this.lblStage.AutoSize = true;
            this.lblStage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStage.Location = new System.Drawing.Point(31, 94);
            this.lblStage.Name = "lblStage";
            this.lblStage.Size = new System.Drawing.Size(91, 22);
            this.lblStage.TabIndex = 3;
            this.lblStage.Text = "Life Stage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(332, 141);
            this.Controls.Add(this.lblStage);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.btnSubmitAge);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblStage;
    }
}


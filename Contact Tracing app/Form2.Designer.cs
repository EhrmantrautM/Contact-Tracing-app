namespace Contact_Tracing_app
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.showbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.agreeLabel = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.tyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showbtn
            // 
            this.showbtn.BackColor = System.Drawing.SystemColors.Info;
            this.showbtn.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showbtn.ForeColor = System.Drawing.Color.Black;
            this.showbtn.Location = new System.Drawing.Point(12, 376);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(195, 37);
            this.showbtn.TabIndex = 1;
            this.showbtn.Text = "Agree";
            this.showbtn.UseVisualStyleBackColor = false;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.SystemColors.Info;
            this.exitbtn.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.ForeColor = System.Drawing.Color.Black;
            this.exitbtn.Location = new System.Drawing.Point(219, 376);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(117, 37);
            this.exitbtn.TabIndex = 2;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.resultLabel.Location = new System.Drawing.Point(29, 38);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(307, 335);
            this.resultLabel.TabIndex = 3;
            // 
            // agreeLabel
            // 
            this.agreeLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agreeLabel.Location = new System.Drawing.Point(29, 38);
            this.agreeLabel.Name = "agreeLabel";
            this.agreeLabel.Size = new System.Drawing.Size(285, 313);
            this.agreeLabel.TabIndex = 4;
            this.agreeLabel.Text = "I agree that all of the informations above are true and correct , I Accept any co" +
    "nditions whenever prove by the authority that I declare wrong informations ";
            this.agreeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.Info;
            this.btnsave.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.Black;
            this.btnsave.Location = new System.Drawing.Point(12, 376);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(195, 37);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // tyLabel
            // 
            this.tyLabel.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyLabel.Location = new System.Drawing.Point(29, 38);
            this.tyLabel.Name = "tyLabel";
            this.tyLabel.Size = new System.Drawing.Size(286, 295);
            this.tyLabel.TabIndex = 6;
            this.tyLabel.Text = "YOU RESPONSE IS RECORDED\r\n THANK YOU AND STAY SAFE!";
            this.tyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(348, 425);
            this.Controls.Add(this.tyLabel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.agreeLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.showbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing Form Review";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button showbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label agreeLabel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label tyLabel;
    }
}
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
            this.resultbx = new System.Windows.Forms.TextBox();
            this.showbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultbx
            // 
            this.resultbx.BackColor = System.Drawing.SystemColors.Info;
            this.resultbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultbx.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.resultbx.Location = new System.Drawing.Point(30, 34);
            this.resultbx.Multiline = true;
            this.resultbx.Name = "resultbx";
            this.resultbx.Size = new System.Drawing.Size(297, 317);
            this.resultbx.TabIndex = 0;
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
            this.showbtn.Text = "Click to see preview";
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(348, 425);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.resultbx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Contact Tracing Form Review";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultbx;
        private System.Windows.Forms.Button showbtn;
        private System.Windows.Forms.Button exitbtn;
    }
}
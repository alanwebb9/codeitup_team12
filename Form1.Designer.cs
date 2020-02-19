namespace ECare
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
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnamb = new System.Windows.Forms.Button();
            this.txtGps = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(144, 117);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(129, 30);
            this.btnsearch.TabIndex = 0;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnamb
            // 
            this.btnamb.Location = new System.Drawing.Point(144, 206);
            this.btnamb.Name = "btnamb";
            this.btnamb.Size = new System.Drawing.Size(129, 30);
            this.btnamb.TabIndex = 2;
            this.btnamb.Text = "Call Ambulance";
            this.btnamb.UseVisualStyleBackColor = true;
            // 
            // txtGps
            // 
            this.txtGps.Location = new System.Drawing.Point(144, 29);
            this.txtGps.Name = "txtGps";
            this.txtGps.Size = new System.Drawing.Size(100, 20);
            this.txtGps.TabIndex = 3;
            this.txtGps.TextChanged += new System.EventHandler(this.txtGps_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGps);
            this.Controls.Add(this.btnamb);
            this.Controls.Add(this.btnsearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnamb;
        private System.Windows.Forms.TextBox txtGps;
    }
}


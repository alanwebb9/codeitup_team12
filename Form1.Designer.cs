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
            this.lblCounty = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.wbHosp = new System.Windows.Forms.WebBrowser();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(77, 119);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(129, 30);
            this.btnsearch.TabIndex = 0;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnamb
            // 
            this.btnamb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnamb.Location = new System.Drawing.Point(77, 200);
            this.btnamb.Name = "btnamb";
            this.btnamb.Size = new System.Drawing.Size(129, 30);
            this.btnamb.TabIndex = 2;
            this.btnamb.Text = "Call Ambulance";
            this.btnamb.UseVisualStyleBackColor = true;
            // 
            // txtGps
            // 
            this.txtGps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGps.Location = new System.Drawing.Point(77, 355);
            this.txtGps.Multiline = true;
            this.txtGps.Name = "txtGps";
            this.txtGps.Size = new System.Drawing.Size(354, 201);
            this.txtGps.TabIndex = 3;
            this.txtGps.TextChanged += new System.EventHandler(this.txtGps_TextChanged);
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(73, 43);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(126, 20);
            this.lblCounty.TabIndex = 4;
            this.lblCounty.Text = "Enter the county";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(279, 43);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(170, 26);
            this.txtLocation.TabIndex = 5;
            // 
            // wbHosp
            // 
            this.wbHosp.Location = new System.Drawing.Point(502, 43);
            this.wbHosp.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbHosp.Name = "wbHosp";
            this.wbHosp.Size = new System.Drawing.Size(844, 576);
            this.wbHosp.TabIndex = 6;
            this.wbHosp.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbHosp_DocumentCompleted);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(77, 276);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(129, 29);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnsearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1437, 674);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.wbHosp);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.txtGps);
            this.Controls.Add(this.btnamb);
            this.Controls.Add(this.btnsearch);
            this.Name = "Form1";
            this.Text = "E-Care";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnamb;
        private System.Windows.Forms.TextBox txtGps;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.WebBrowser wbHosp;
        private System.Windows.Forms.Button btnClear;
    }
}


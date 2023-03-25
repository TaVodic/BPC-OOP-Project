namespace Drug_database
{
    partial class DatabaseGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DrgName = new System.Windows.Forms.Label();
            this.DrgSearch = new System.Windows.Forms.TextBox();
            this.DrgDescrip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Searching";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // DrgName
            // 
            this.DrgName.AutoSize = true;
            this.DrgName.Location = new System.Drawing.Point(126, 115);
            this.DrgName.Name = "DrgName";
            this.DrgName.Size = new System.Drawing.Size(25, 13);
            this.DrgName.TabIndex = 3;
            this.DrgName.Text = "???";
            // 
            // DrgSearch
            // 
            this.DrgSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DrgSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.DrgSearch.Location = new System.Drawing.Point(64, 49);
            this.DrgSearch.Name = "DrgSearch";
            this.DrgSearch.Size = new System.Drawing.Size(295, 20);
            this.DrgSearch.TabIndex = 4;
            this.DrgSearch.TextChanged += new System.EventHandler(this.DrgSearch_TextChanged);
            // 
            // DrgDescrip
            // 
            this.DrgDescrip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DrgDescrip.Location = new System.Drawing.Point(129, 150);
            this.DrgDescrip.Multiline = true;
            this.DrgDescrip.Name = "DrgDescrip";
            this.DrgDescrip.ReadOnly = true;
            this.DrgDescrip.Size = new System.Drawing.Size(230, 142);
            this.DrgDescrip.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DrgDescrip);
            this.Controls.Add(this.DrgSearch);
            this.Controls.Add(this.DrgName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DrgName;
        private System.Windows.Forms.TextBox DrgSearch;
        private System.Windows.Forms.TextBox DrgDescrip;
        private System.Windows.Forms.Label label3;
    }
}


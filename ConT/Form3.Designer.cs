namespace ConT
{
    partial class Form3
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
            this.lablTitle2 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.DateIdentifier = new System.Windows.Forms.DateTimePicker();
            this.listBoxData2 = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lablTitle2
            // 
            this.lablTitle2.AutoSize = true;
            this.lablTitle2.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lablTitle2.Location = new System.Drawing.Point(123, 18);
            this.lablTitle2.Name = "lablTitle2";
            this.lablTitle2.Size = new System.Drawing.Size(547, 37);
            this.lablTitle2.TabIndex = 1;
            this.lablTitle2.Text = "CONTACT TRACING FORM DATABASE";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFilter.Location = new System.Drawing.Point(36, 95);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // DateIdentifier
            // 
            this.DateIdentifier.Location = new System.Drawing.Point(123, 95);
            this.DateIdentifier.Name = "DateIdentifier";
            this.DateIdentifier.Size = new System.Drawing.Size(200, 23);
            this.DateIdentifier.TabIndex = 3;
            // 
            // listBoxData2
            // 
            this.listBoxData2.FormattingEnabled = true;
            this.listBoxData2.ItemHeight = 15;
            this.listBoxData2.Location = new System.Drawing.Point(36, 124);
            this.listBoxData2.Name = "listBoxData2";
            this.listBoxData2.Size = new System.Drawing.Size(294, 244);
            this.listBoxData2.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Location = new System.Drawing.Point(36, 374);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.listBoxData2);
            this.Controls.Add(this.DateIdentifier);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lablTitle2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lablTitle2;
        private Button btnFilter;
        private DateTimePicker DateIdentifier;
        private ListBox listBoxData2;
        private Button btnReset;
    }
}
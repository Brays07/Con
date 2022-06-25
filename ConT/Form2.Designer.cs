namespace ConT
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
            this.lablTitle2 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.ListBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.SelectedDateInfo = new System.Windows.Forms.DateTimePicker();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnViewFilterData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lablTitle2
            // 
            this.lablTitle2.AutoSize = true;
            this.lablTitle2.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lablTitle2.Location = new System.Drawing.Point(78, 9);
            this.lablTitle2.Name = "lablTitle2";
            this.lablTitle2.Size = new System.Drawing.Size(547, 37);
            this.lablTitle2.TabIndex = 0;
            this.lablTitle2.Text = "CONTACT TRACING FORM DATABASE";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnView.Location = new System.Drawing.Point(370, 98);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(110, 23);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View All the Data";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Data
            // 
            this.Data.FormattingEnabled = true;
            this.Data.ItemHeight = 15;
            this.Data.Location = new System.Drawing.Point(65, 125);
            this.Data.Name = "Data";
            this.Data.ScrollAlwaysVisible = true;
            this.Data.Size = new System.Drawing.Size(597, 274);
            this.Data.TabIndex = 3;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFilter.Location = new System.Drawing.Point(65, 96);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(63, 23);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Filter\r\n";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // SelectedDateInfo
            // 
            this.SelectedDateInfo.Location = new System.Drawing.Point(134, 96);
            this.SelectedDateInfo.Name = "SelectedDateInfo";
            this.SelectedDateInfo.Size = new System.Drawing.Size(200, 23);
            this.SelectedDateInfo.TabIndex = 5;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Location = new System.Drawing.Point(599, 98);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(63, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnViewFilterData
            // 
            this.btnViewFilterData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewFilterData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewFilterData.Location = new System.Drawing.Point(65, 405);
            this.btnViewFilterData.Name = "btnViewFilterData";
            this.btnViewFilterData.Size = new System.Drawing.Size(139, 23);
            this.btnViewFilterData.TabIndex = 7;
            this.btnViewFilterData.Text = "View the Filtered Data";
            this.btnViewFilterData.UseVisualStyleBackColor = false;
            this.btnViewFilterData.Click += new System.EventHandler(this.btnViewFilterData_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 449);
            this.Controls.Add(this.btnViewFilterData);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.SelectedDateInfo);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lablTitle2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lablTitle2;
        private Button btnView;
        private ListBox Data;
        private Button btnFilter;
        private DateTimePicker SelectedDateInfo;
        private Button btnReset;
        private Button btnViewFilterData;
    }
}
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
            this.btnFilter = new System.Windows.Forms.Button();
            this.SelectedDate = new System.Windows.Forms.DateTimePicker();
            this.btnReset = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ColumnName = new System.Windows.Forms.ColumnHeader();
            this.ColumnDate = new System.Windows.Forms.ColumnHeader();
            this.lablDataVisit = new System.Windows.Forms.Label();
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
            this.btnView.Location = new System.Drawing.Point(326, 98);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(110, 23);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View All the Data";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(36, 96);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(63, 23);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Filter\r\n";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // SelectedDate
            // 
            this.SelectedDate.Location = new System.Drawing.Point(105, 96);
            this.SelectedDate.Name = "SelectedDate";
            this.SelectedDate.Size = new System.Drawing.Size(200, 23);
            this.SelectedDate.TabIndex = 5;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(222, 390);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(63, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(50, 125);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(386, 259);
            this.listBox1.TabIndex = 8;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnName,
            this.ColumnDate});
            this.listView1.Location = new System.Drawing.Point(483, 142);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(198, 224);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.SelectedD_IndexChanged);
            // 
            // ColumnName
            // 
            this.ColumnName.Text = "Name";
            this.ColumnName.Width = 65;
            // 
            // ColumnDate
            // 
            this.ColumnDate.Text = "Date of Visitor";
            this.ColumnDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnDate.Width = 100;
            // 
            // lablDataVisit
            // 
            this.lablDataVisit.AutoSize = true;
            this.lablDataVisit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lablDataVisit.Location = new System.Drawing.Point(522, 120);
            this.lablDataVisit.Name = "lablDataVisit";
            this.lablDataVisit.Size = new System.Drawing.Size(122, 19);
            this.lablDataVisit.TabIndex = 10;
            this.lablDataVisit.Text = "Data of Visitors";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 448);
            this.Controls.Add(this.lablDataVisit);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.SelectedDate);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lablTitle2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Shown += new System.EventHandler(this.FormInfo_Show);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lablTitle2;
        private Button btnView;
        private Button btnFilter;
        private DateTimePicker SelectedDate;
        private Button btnReset;
        private ListBox listBox1;
        private ListView listView1;
        private ColumnHeader ColumnName;
        private ColumnHeader ColumnDate;
        private Label lablDataVisit;
    }
}
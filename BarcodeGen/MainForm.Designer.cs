namespace KCASoft
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.selectionGroupBox = new System.Windows.Forms.GroupBox();
            this.SelStudentsCountLabel = new System.Windows.Forms.Label();
            this.AllStudentsCountLabel = new System.Windows.Forms.Label();
            this.SelectedStudentsLabel = new System.Windows.Forms.Label();
            this.AllStudentsLabel = new System.Windows.Forms.Label();
            this.removeAllBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.addAllBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.selStudentsListBox = new System.Windows.Forms.ListBox();
            this.allStudentsListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.instrLabel4 = new System.Windows.Forms.Label();
            this.instrLabel3 = new System.Windows.Forms.Label();
            this.instrLabel2 = new System.Windows.Forms.Label();
            this.instrLabel1 = new System.Windows.Forms.Label();
            this.selectionGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(227, 427);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(315, 427);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // selectionGroupBox
            // 
            this.selectionGroupBox.Controls.Add(this.SelStudentsCountLabel);
            this.selectionGroupBox.Controls.Add(this.AllStudentsCountLabel);
            this.selectionGroupBox.Controls.Add(this.SelectedStudentsLabel);
            this.selectionGroupBox.Controls.Add(this.AllStudentsLabel);
            this.selectionGroupBox.Controls.Add(this.removeAllBtn);
            this.selectionGroupBox.Controls.Add(this.removeBtn);
            this.selectionGroupBox.Controls.Add(this.addAllBtn);
            this.selectionGroupBox.Controls.Add(this.addBtn);
            this.selectionGroupBox.Controls.Add(this.selStudentsListBox);
            this.selectionGroupBox.Controls.Add(this.allStudentsListBox);
            this.selectionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionGroupBox.Location = new System.Drawing.Point(12, 117);
            this.selectionGroupBox.Name = "selectionGroupBox";
            this.selectionGroupBox.Size = new System.Drawing.Size(594, 296);
            this.selectionGroupBox.TabIndex = 5;
            this.selectionGroupBox.TabStop = false;
            this.selectionGroupBox.Text = "Barcode will be generated for the students on the right";
            // 
            // SelStudentsCountLabel
            // 
            this.SelStudentsCountLabel.AutoSize = true;
            this.SelStudentsCountLabel.Location = new System.Drawing.Point(505, 35);
            this.SelStudentsCountLabel.Name = "SelStudentsCountLabel";
            this.SelStudentsCountLabel.Size = new System.Drawing.Size(40, 16);
            this.SelStudentsCountLabel.TabIndex = 9;
            this.SelStudentsCountLabel.Text = "count";
            // 
            // AllStudentsCountLabel
            // 
            this.AllStudentsCountLabel.AutoSize = true;
            this.AllStudentsCountLabel.Location = new System.Drawing.Point(108, 35);
            this.AllStudentsCountLabel.Name = "AllStudentsCountLabel";
            this.AllStudentsCountLabel.Size = new System.Drawing.Size(40, 16);
            this.AllStudentsCountLabel.TabIndex = 8;
            this.AllStudentsCountLabel.Text = "count";
            // 
            // SelectedStudentsLabel
            // 
            this.SelectedStudentsLabel.AutoSize = true;
            this.SelectedStudentsLabel.Location = new System.Drawing.Point(373, 35);
            this.SelectedStudentsLabel.Name = "SelectedStudentsLabel";
            this.SelectedStudentsLabel.Size = new System.Drawing.Size(126, 16);
            this.SelectedStudentsLabel.TabIndex = 7;
            this.SelectedStudentsLabel.Text = "Selected Students : ";
            // 
            // AllStudentsLabel
            // 
            this.AllStudentsLabel.AutoSize = true;
            this.AllStudentsLabel.Location = new System.Drawing.Point(17, 35);
            this.AllStudentsLabel.Name = "AllStudentsLabel";
            this.AllStudentsLabel.Size = new System.Drawing.Size(85, 16);
            this.AllStudentsLabel.TabIndex = 6;
            this.AllStudentsLabel.Text = "All students : ";
            // 
            // removeAllBtn
            // 
            this.removeAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAllBtn.Location = new System.Drawing.Point(231, 218);
            this.removeAllBtn.Name = "removeAllBtn";
            this.removeAllBtn.Size = new System.Drawing.Size(128, 27);
            this.removeAllBtn.TabIndex = 5;
            this.removeAllBtn.Text = "<< Remove all";
            this.removeAllBtn.UseVisualStyleBackColor = true;
            this.removeAllBtn.Click += new System.EventHandler(this.removeAllBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Location = new System.Drawing.Point(231, 175);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(128, 27);
            this.removeBtn.TabIndex = 4;
            this.removeBtn.Text = "< Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // addAllBtn
            // 
            this.addAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAllBtn.Location = new System.Drawing.Point(231, 132);
            this.addAllBtn.Name = "addAllBtn";
            this.addAllBtn.Size = new System.Drawing.Size(128, 27);
            this.addAllBtn.TabIndex = 3;
            this.addAllBtn.Text = "Add all >>";
            this.addAllBtn.UseVisualStyleBackColor = true;
            this.addAllBtn.Click += new System.EventHandler(this.addAllBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(231, 89);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(128, 27);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add >";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // selStudentsListBox
            // 
            this.selStudentsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selStudentsListBox.FormattingEnabled = true;
            this.selStudentsListBox.ItemHeight = 16;
            this.selStudentsListBox.Location = new System.Drawing.Point(370, 56);
            this.selStudentsListBox.Name = "selStudentsListBox";
            this.selStudentsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.selStudentsListBox.Size = new System.Drawing.Size(208, 228);
            this.selStudentsListBox.Sorted = true;
            this.selStudentsListBox.TabIndex = 1;
            // 
            // allStudentsListBox
            // 
            this.allStudentsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allStudentsListBox.FormattingEnabled = true;
            this.allStudentsListBox.ItemHeight = 16;
            this.allStudentsListBox.Location = new System.Drawing.Point(14, 56);
            this.allStudentsListBox.Name = "allStudentsListBox";
            this.allStudentsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.allStudentsListBox.Size = new System.Drawing.Size(208, 228);
            this.allStudentsListBox.Sorted = true;
            this.allStudentsListBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.instrLabel4);
            this.groupBox1.Controls.Add(this.instrLabel3);
            this.groupBox1.Controls.Add(this.instrLabel2);
            this.groupBox1.Controls.Add(this.instrLabel1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 110);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // instrLabel4
            // 
            this.instrLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.instrLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrLabel4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.instrLabel4.Location = new System.Drawing.Point(2, 79);
            this.instrLabel4.Name = "instrLabel4";
            this.instrLabel4.Size = new System.Drawing.Size(588, 24);
            this.instrLabel4.TabIndex = 13;
            this.instrLabel4.Text = "You are ready to scan and checkin your students!";
            this.instrLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instrLabel3
            // 
            this.instrLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.instrLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrLabel3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.instrLabel3.Location = new System.Drawing.Point(2, 59);
            this.instrLabel3.Name = "instrLabel3";
            this.instrLabel3.Size = new System.Drawing.Size(588, 24);
            this.instrLabel3.TabIndex = 12;
            this.instrLabel3.Text = "Stick the labels in student folder.";
            this.instrLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instrLabel2
            // 
            this.instrLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.instrLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrLabel2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.instrLabel2.Location = new System.Drawing.Point(2, 36);
            this.instrLabel2.Name = "instrLabel2";
            this.instrLabel2.Size = new System.Drawing.Size(588, 24);
            this.instrLabel2.TabIndex = 11;
            this.instrLabel2.Text = "Use Avery US Letter - 5160 Easy Peel address labels to print.";
            this.instrLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instrLabel1
            // 
            this.instrLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.instrLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrLabel1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.instrLabel1.Location = new System.Drawing.Point(2, 14);
            this.instrLabel1.Name = "instrLabel1";
            this.instrLabel1.Size = new System.Drawing.Size(588, 24);
            this.instrLabel1.TabIndex = 10;
            this.instrLabel1.Text = "This application will produce a Microsoft Word document.";
            this.instrLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(620, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.selectionGroupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select students to print barcode";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.selectionGroupBox.ResumeLayout(false);
            this.selectionGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox selectionGroupBox;
        private System.Windows.Forms.Button removeAllBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button addAllBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ListBox selStudentsListBox;
        private System.Windows.Forms.ListBox allStudentsListBox;
        private System.Windows.Forms.Label SelectedStudentsLabel;
        private System.Windows.Forms.Label AllStudentsLabel;
        private System.Windows.Forms.Label SelStudentsCountLabel;
        private System.Windows.Forms.Label AllStudentsCountLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label instrLabel4;
        private System.Windows.Forms.Label instrLabel3;
        private System.Windows.Forms.Label instrLabel2;
        private System.Windows.Forms.Label instrLabel1;
    }
}
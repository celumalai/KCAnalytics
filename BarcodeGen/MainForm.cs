//
// Copyright 2013 KCA Software LLC. All rights reserved.
//
using KCASoft;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KCASoft
{
    public partial class MainForm : Form
    {
        private string _iFileName;
        public string FileName
        {
            get { return _iFileName; }
            set { _iFileName = value; }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            // file open dialog
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = Strings.S.SEL_STU_FOLDER;
            fbd.SelectedPath = Constants.USER_LOC;

            string s = string.Empty;
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                s = fbd.SelectedPath;
            }

            if (String.IsNullOrEmpty(s)) return;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // write out the file
            StreamWriter barCodeWriter;
            barCodeWriter = File.CreateText(InternalLogger.BarcodeLog);
            barCodeWriter.WriteLine(Constants.STU_ID + "," + Constants.STU_NAME);  // write out a header

            bool bClose = false;
            if (selStudentsListBox.Items.Count > 0)
            {
                foreach (StudentData sd in selStudentsListBox.Items)
                {
                    barCodeWriter.WriteLine("!" + sd.StudentId + "!," + sd.StudentName);
                }

                barCodeWriter.Flush();
                barCodeWriter.Close();

                // good time to close this app
                this.Close();
                bClose = true;

                if (string.IsNullOrEmpty(InternalLogger.BarcodeLog) == false)
                    WordLabelMaker.MakeLabels(InternalLogger.BarcodeLog);
            }

            if(!bClose)
                this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // prepare data
            // read the student record file 
            // encode barcode for the id

            // set instruction text
            instrLabel1.Text = Strings.S.INSTR_LABEL1;
            instrLabel2.Text = Strings.S.INSTR_LABEL2;
            instrLabel3.Text = Strings.S.INSTR_LABEL3;
            instrLabel4.Text = Strings.S.INSTR_LABEL4;

            // set the group text
            selectionGroupBox.Text = Strings.S.GRP_HEADER;
            AllStudentsLabel.Text = Strings.S.ALL_STUDENTS;
            SelectedStudentsLabel.Text = Strings.S.SEL_STUDENTS;
            
            // set the time cursor
            Cursor.Current = Cursors.WaitCursor;

            // initialize the all student list box
            StudentRecords sRecords = StudentRecords.GetStudentRecords();
            List<StudentData> sData = new List<StudentData>();
            if(sRecords != null)
            {
                sData = GetStudentData(sRecords);
            }

            foreach (StudentData sD in sData)
            {
                this.allStudentsListBox.Items.Add(sD);
            }

            this.AllStudentsCountLabel.Text = Convert.ToString(allStudentsListBox.Items.Count);
            this.SelStudentsCountLabel.Text = Convert.ToString(selStudentsListBox.Items.Count);

            if (selStudentsListBox.Items.Count == 0)
                okButton.Enabled = false;
            else
                okButton.Enabled = true;

            Cursor.Current = Cursors.Default;
        }

        private List<StudentData> GetStudentData(StudentRecords sRecords)
        {
            List<StudentData> sData = new List<StudentData>();
            foreach (StudentRecord sRec in sRecords.GetRecordList())
            {
                sData.Add(new StudentData(sRec.StudentId, sRec.StudentName));
            }
            return sData;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddSelected();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            RemoveSelected();
        }

        private void removeAllBtn_Click(object sender, EventArgs e)
        {
            selStudentsListBox.Visible = false;
            for (int i = 0; i < selStudentsListBox.Items.Count; i++)
            {
                selStudentsListBox.SetSelected(i, true);
            }
            selStudentsListBox.Visible = true;

            RemoveSelected();
        }

        private void addAllBtn_Click(object sender, EventArgs e)
        {
            allStudentsListBox.Visible = false;
            for (int i = 0; i < allStudentsListBox.Items.Count; i++)
            {
                allStudentsListBox.SetSelected(i, true);
            }
            allStudentsListBox.Visible = true;

            AddSelected();
        }

        private void AddSelected()
        {
            if (allStudentsListBox.SelectedIndex > -1)
            {
                // get the selection from left and move it to right
                foreach (StudentData sd in allStudentsListBox.SelectedItems)
                {
                    selStudentsListBox.Items.Add(sd);
                }

                for (int i = allStudentsListBox.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    allStudentsListBox.Items.RemoveAt(allStudentsListBox.SelectedIndices[i]);
                }
            }

            this.SelStudentsCountLabel.Text = Convert.ToString(selStudentsListBox.Items.Count);

            if (selStudentsListBox.Items.Count == 0)
                okButton.Enabled = false;
            else
                okButton.Enabled = true;
        }

        private void RemoveSelected()
        {
            if (selStudentsListBox.SelectedIndex > -1)
            {
                foreach (StudentData sd in selStudentsListBox.SelectedItems)
                {
                    allStudentsListBox.Items.Add(sd);
                }

                for (int i = selStudentsListBox.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    selStudentsListBox.Items.RemoveAt(selStudentsListBox.SelectedIndices[i]);
                }
            }

            this.SelStudentsCountLabel.Text = Convert.ToString(selStudentsListBox.Items.Count);
            
            if (selStudentsListBox.Items.Count == 0)
                okButton.Enabled = false;
            else
                okButton.Enabled = true;
        }
    }
}

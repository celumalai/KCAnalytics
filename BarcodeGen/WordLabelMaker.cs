//
// Copyright 2013 KCA Software LLC. All rights reserved.
//

using KCASoft;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Word = Microsoft.Office.Interop.Word;

namespace KCASoft

{
    public class WordLabelMaker
    {
        public static void MakeLabels(string iFileName)
        {
            try
            {
                Word._Application wrdApp;
                Word._Document oDataDoc;
                Word.MailMerge wrdMailMerge;
                Object oMissing = System.Type.Missing;
                Object oFalse = false;
                Object oTrue = true;
                string exeFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                Object oName = exeFolder + @"\KCASoftLabels.docx";
                Object iFileFormat = Word.WdSaveFormat.wdFormatDOSText;
                string labelFile = Constants.LABEL_LOC +
                        DateTime.Now.ToShortDateString().Replace('/', '-') + "_" +
                        DateTime.Now.ToShortTimeString().Replace(':', '-') +
                        Constants.DOC_FILE_TYPE;

                // Starting the Word Application
                wrdApp = new Word.Application();
                wrdApp.Visible = false;
                wrdApp.WindowState = Word.WdWindowState.wdWindowStateMaximize;

                // Open the template
                oDataDoc = wrdApp.Documents.Add(ref oName, ref oFalse, ref oMissing, ref oMissing);
                oDataDoc.Activate();

                // Document 2 mailmerge format
                wrdMailMerge = oDataDoc.MailMerge;
                wrdMailMerge.MainDocumentType = Word.WdMailMergeMainDocType.wdMailingLabels;
                wrdMailMerge.HighlightMergeFields = false;

                // The data part
                Object oSubType = Word.WdMergeSubType.wdMergeSubTypeWord;

                // Open the data source and merge the fields
                wrdMailMerge.OpenDataSource(iFileName, ref iFileFormat, ref oMissing, ref oMissing, ref oTrue,
                    ref oMissing, ref oMissing, ref oMissing, ref oFalse, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oSubType);
                wrdMailMerge.SuppressBlankLines = true;

                // Perform mail merge
                wrdMailMerge.Destination = Word.WdMailMergeDestination.wdSendToNewDocument;
                wrdMailMerge.Execute(ref oFalse);

                object doNotSaveChanges = Word.WdSaveOptions.wdDoNotSaveChanges;
                oDataDoc.Close(ref doNotSaveChanges, ref oMissing, ref oMissing);

                IEnumerator enumDocs = wrdApp.Documents.GetEnumerator();
                if (enumDocs.MoveNext())
                {
                    Word.Document labelsDoc = enumDocs.Current as Word.Document;

                    // coin a name with today's date/time and save it under labels
                    Status.CreateDirectory(Constants.LABEL_LOC);
                    labelsDoc.SaveAs2(labelFile);
                }

                // Unload objects from the memory
                Marshal.ReleaseComObject(wrdMailMerge);
                wrdMailMerge = null;

                Marshal.ReleaseComObject(oDataDoc);
                oDataDoc = null;

                wrdApp.Quit();
                Marshal.ReleaseComObject(wrdApp);
                wrdApp = null;

                // open the label file for viewing
                Status.RunProcess(Constants.WORD, labelFile);
            }
            catch (Exception ex)
            {
                Status.Exit(ex);
            }
        }
    }
}

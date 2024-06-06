using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PdfMerger
{
    public partial class Form1 : Form
    {
        private List<string> pdfFiles;

        public Form1()
        {
            InitializeComponent();
            pdfFiles = new List<string>();
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pdfFiles.AddRange(openFileDialog.FileNames);
                    listBoxFiles.Items.AddRange(openFileDialog.SafeFileNames);
                }
            }
        }

        private void btnMergeFiles_Click(object sender, EventArgs e)
        {
            if (pdfFiles.Count == 0)
            {
                MessageBox.Show("Please select PDF files to merge.", "No files selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    MergePdfFiles(pdfFiles, saveFileDialog.FileName);
                    MessageBox.Show("PDF files merged successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void MergePdfFiles(List<string> pdfFiles, string outputFilePath)
        {
            using (FileStream stream = new FileStream(outputFilePath, FileMode.Create))
            {
                Document pdfDoc = new Document();
                PdfCopy pdfCopy = new PdfCopy(pdfDoc, stream);
                pdfDoc.Open();

                foreach (string file in pdfFiles)
                {
                    PdfReader pdfReader = new PdfReader(file);
                    for (int page = 1; page <= pdfReader.NumberOfPages; page++)
                    {
                        PdfImportedPage importedPage = pdfCopy.GetImportedPage(pdfReader, page);
                        pdfCopy.AddPage(importedPage);
                    }
                    pdfReader.Close();
                }

                pdfDoc.Close();
            }
        }


        //private void btnMoveUp_Click(object sender, EventArgs e)
        //{
        //    MoveSelectedItem(-1);
        //}

        //private void btnMoveDown_Click(object sender, EventArgs e)
        //{
        //    MoveSelectedItem(1);
        //}

        private void MoveSelectedItem(int direction)
        {
            if (listBoxFiles.SelectedItem == null || listBoxFiles.SelectedIndex < 0)
                return;

            int oldIndex = listBoxFiles.SelectedIndex;
            int newIndex = oldIndex + direction;

            if (newIndex < 0 || newIndex >= listBoxFiles.Items.Count)
                return;

            // Move the item in the list
            object selected = listBoxFiles.SelectedItem;
            string selectedFile = pdfFiles[oldIndex];

            // Update the pdfFiles list first
            pdfFiles.RemoveAt(oldIndex);
            pdfFiles.Insert(newIndex, selectedFile);

            // Update the ListBox
            listBoxFiles.Items.RemoveAt(oldIndex);
            listBoxFiles.Items.Insert(newIndex, selected);

            // Set the new selected index
            listBoxFiles.SetSelected(newIndex, true);
        }

        private void btnMoveUp_Click_1(object sender, EventArgs e)
        {
            MoveSelectedItem(-1);
        }

        private void btnMoveDown_Click_1(object sender, EventArgs e)
        {
            MoveSelectedItem(1);
        }

        private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void listBoxFiles_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            var pdfs = files.Where(file => Path.GetExtension(file).Equals(".pdf", StringComparison.OrdinalIgnoreCase)).ToArray();

            if (pdfs.Length > 0)
            {
                pdfFiles.AddRange(pdfs);
                listBoxFiles.Items.AddRange(pdfs.Select(Path.GetFileName).ToArray());
            }
        }


        private void RemoveSelectedItem()
        {
            if (listBoxFiles.SelectedItem == null || listBoxFiles.SelectedIndex < 0)
                return;

            int selectedIndex = listBoxFiles.SelectedIndex;
            listBoxFiles.Items.RemoveAt(selectedIndex);
            pdfFiles.RemoveAt(selectedIndex);
        }


        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            RemoveSelectedItem();
        }
    }
}

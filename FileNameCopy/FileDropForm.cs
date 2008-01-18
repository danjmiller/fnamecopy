using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace FileNameCopy
{

    public partial class FileDropForm : Form
    {

        int xPos = 0;
        int yPos = 0;

        int lastHeight = 150;
        int lastWidth = 300;

        public FileDropForm()
        {
            InitializeComponent();

            lastHeight = Size.Height;
            lastWidth = Size.Width;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        /// Drag and Drop code from: "http://www.csharphelp.com/archives2/archive365.html"/>
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            // make sure they're actually dropping files (not text or anything else)
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
                // allow them to continue
                // (without this, the cursor stays a "NO" symbol
                e.Effect = DragDropEffects.All;

        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            Clipboard.Clear();
            foreach (string file in files)
            {
                fileDropListBox.Items.Add(file);
                fileDropListBox.SelectedIndex = fileDropListBox.Items.Count - 1;
                Clipboard.SetText(file);
            }
        }



        private void trayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Rectangle rct = Screen.PrimaryScreen.WorkingArea;
                xPos = rct.Right - lastWidth;
                yPos = rct.Bottom - lastHeight;

                Location = new Point(xPos, yPos);

                Show();
                WindowState = FormWindowState.Normal;

            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
            }
            else
            {
                lastWidth = Size.Width;
                lastHeight = Size.Height;
            }
        }

        private void fileNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList selectedList = getSelectedList();

                String listString = null;
                foreach (String s in selectedList)
                {
                    FileInfo fi = new FileInfo(s);
                    if (fi != null)
                    {
                        listString += fi.Name + "\n";
                    }
                }

                if (listString != null)
                {
                    Clipboard.Clear();
                    Clipboard.SetText(listString.Trim());
                }
            }
            catch (Exception)
            {
                //eat the exception
            }
        }

        private ArrayList getSelectedList()
        {
            ArrayList sel = new ArrayList();

            foreach (String s in fileDropListBox.SelectedItems)
            {

                sel.Add(s);
            }


            return sel;

        }

        private void fullNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList selectedList = getSelectedList();

                String listString = null;
                foreach (String s in selectedList)
                {
                    FileInfo fi = new FileInfo(s);
                    if (fi != null)
                    {
                        listString += fi.FullName + "\n";
                    }
                }

                if (listString != null)
                {
                    Clipboard.Clear();
                    Clipboard.SetText(listString.Trim());
                }
            }
            catch (Exception)
            {
                //eat the exception
            }
        }

        private void pathButton_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList selectedList = getSelectedList();

                String listString = null;
                foreach (String s in selectedList)
                {
                    FileInfo fi = new FileInfo(s);
                    if (fi != null)
                    {
                        listString += fi.DirectoryName + "\n";
                    }
                }

                if (listString != null)
                {
                    Clipboard.Clear();
                    Clipboard.SetText(listString.Trim());
                }
            }
            catch (Exception)
            {
                //eat the exception
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            fileDropListBox.Items.Clear();
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            trayIcon.Dispose();
        }

        
    }
}
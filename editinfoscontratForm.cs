using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Diagnostics;
using System.Drawing.Drawing2D;





namespace Brouillon_Test
{
    public partial class editinfoscontratForm : Form
    {
        public editinfoscontratForm()
        {
            InitializeComponent();
        }

        private void EditinfoscontratForm_Load(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
        private void FindAndReplace(Microsoft.Office.Interop.Word.Application wordApp, object findText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref findText,
                        ref matchCase, ref matchWholeWord,
                        ref matchWildCards, ref matchSoundLike,
                        ref nmatchAllForms, ref forward,
                        ref wrap, ref format, ref replaceWithText,
                        ref replace, ref matchKashida,
                        ref matchDiactitics, ref matchAlefHamza,
                        ref matchControl);
        }
        private void CreateWordDocument(object filename, object savaAs)
        {
            List<int> processesbeforegen = getRunningProcesses();
            object missing = Missing.Value;
            string tempPath = null;

            Word.Application wordApp = new Word.Application();

            Word.Document aDoc = null;

            if (File.Exists((string)filename))
            {
                DateTime today = DateTime.Now;

                object readOnly = false; //default
                object isVisible = false;

                wordApp.Visible = false;

                aDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing, ref missing);

                aDoc.Activate();
                //Find and replace:
                this.FindAndReplace(wordApp, "$$premiers_partenaires$$", partners.Text);
                this.FindAndReplace(wordApp, "$$nom_projet$$", nom_projet.Text);
                this.FindAndReplace(wordApp, "$$montant$$", montant.ToString());
                this.FindAndReplace(wordApp, "$$objectifs$$", objectif.Text);
            }
            else
            {
                MessageBox.Show("file dose not exist.");
                return;
            }

            //Save as: filename
            aDoc.SaveAs2(ref savaAs, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing);

            //Close Document:
            //aDoc.Close(ref missing, ref missing, ref missing);
            File.Delete(tempPath);
            MessageBox.Show("File created.");
            List<int> processesaftergen = getRunningProcesses();
            killProcesses(processesbeforegen, processesaftergen);
        }

        public List<int> getRunningProcesses()
        {
            List<int> ProcessIDs = new List<int>();
            //here we're going to get a list of all running processes on
            //the computer
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (Process.GetCurrentProcess().Id == clsProcess.Id)
                    continue;
                if (clsProcess.ProcessName.Contains("WINWORD"))
                {
                    ProcessIDs.Add(clsProcess.Id);
                }
            }
            return ProcessIDs;
        }


        private void killProcesses(List<int> processesbeforegen, List<int> processesaftergen)
        {
            foreach (int pidafter in processesaftergen)
            {
                bool processfound = false;
                foreach (int pidbefore in processesbeforegen)
                {
                    if (pidafter == pidbefore)
                    {
                        processfound = true;
                    }
                }

                if (processfound == false)
                {
                    Process clsProcess = Process.GetProcessById(pidafter);
                    clsProcess.Kill();
                }

            }
        }

        //Méthode Enabled Controles:
        private void tEnabled(bool state)
                {
                    partners.Enabled = state;
                    nom_projet.Enabled = state;
                    montant.Enabled = state;
                    objectif.Enabled = state;
                   // tfilename.Enabled = state;
                }



        //Load the Template Document:
        private void LoadDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog LoadDoc = new OpenFileDialog();
            PrintPreviewDialog tfilename = new PrintPreviewDialog();

            if (LoadDoc.ShowDialog() == DialogResult.OK)
            {
                tfilename.Text = LoadDoc.FileName;
                tEnabled(true);
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
           // OpenFileDialog LoadDoc = new OpenFileDialog();
            SaveFileDialog SaveDoc = new SaveFileDialog();

            if (SaveDoc.ShowDialog() == DialogResult.OK)
            {
                CreateWordDocument(tfilename.Text, SaveDoc.FileName);
                tEnabled(false);
                //printDocument1.DocumentName = SaveDoc.FileName;
            }
        }
    }
}

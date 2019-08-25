using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;

namespace Brouillon_Test
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            this.Application.DocumentOpen += Application_DocumentOpen;
            ((Word.ApplicationEvents4_Event)this.Application).NewDocument += ThisAddIn_NewDocument;

        }
        private void Application_DocumentOpen(Word.Document Doc)
        {
        }

        private void ThisAddIn_NewDocument(Word.Document Doc)
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
     
        
        #endregion
    }
}

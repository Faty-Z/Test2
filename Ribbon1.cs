﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace Brouillon_Test
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void Edit_infocontrat_Click(object sender, RibbonControlEventArgs e)
        {
            var editinfoscontrat = new editinfoscontratForm();
            editinfoscontrat.Show();
        }
    }
}

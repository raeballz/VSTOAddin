using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;

namespace VSTOWordAddin2013And16
{
    public partial class ThisAddIn
    {
        private AddInUtilities utilities;

        protected override object RequestComAddInAutomationService()
        {
            if (utilities == null)
            {
                utilities = new AddInUtilities();
            }
            return utilities;
        }
    }
}

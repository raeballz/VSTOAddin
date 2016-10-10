using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using VSTOWordAddin.Core.Models;
using VSTOWordAddin.Core.Interfaces;
using Newtonsoft.Json;
using Microsoft.Office.Interop.Word;

namespace VSTOWordAddin2013And16
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class AddInUtilities : IAddInUtilities
    {

        private Patient currentPatient;

        public void GetPatientData(string PatData)
        {
            this.CurrentPatient = JsonConvert.DeserializeObject<Patient>(PatData);

            var currentRange = Globals.ThisAddIn.Application.Selection.Range;
            currentRange.Text = CurrentPatient.FamilyName + currentPatient.Age + CurrentPatient.GivenName + CurrentPatient.ID;
        }

        public Patient CurrentPatient
        {
            get { return this.currentPatient; }
            set { this.currentPatient = value; }
        }
    }
}

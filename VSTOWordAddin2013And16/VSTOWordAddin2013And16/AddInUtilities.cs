using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using VSTOWordAddin.Core.Models;
using VSTOWordAddin.Core.Interfaces;

namespace VSTOWordAddin2013And16
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class AddInUtilities : IAddInUtilities
    {

        private Patient currentPatient;

        public void DisplayMessage()
        {
            MessageBox.Show("Hello World!!!! this is an exposed method", "helloWorld");
        }

        public void GetPatientData(Patient PatData)
        {
            CurrentPatient = PatData;
        }

        public Patient CurrentPatient
        {
            get { return this.currentPatient; }
            set { this.currentPatient = value; }
        }
    }
}

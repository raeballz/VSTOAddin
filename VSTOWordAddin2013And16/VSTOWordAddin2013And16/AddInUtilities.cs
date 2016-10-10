using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using VSTOWordAddin.Core.Models;
using VSTOWordAddin.Core.Interfaces;
using Office = Microsoft.Office.Core;
using Word = Microsoft.Office.Tools.Word;
using Microsoft.Office.Interop.Word;

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

        Document ActiveDocument { get; }

        object CustomDocumentProperties
        {
           get
           {
                Document doc = Globals.ThisAddIn.Application.ActiveDocument;
                return doc.CustomDocumentProperties;
           }
        }

        public void ReplaceTestProperty(string stringToReplaceCustProperty)
        {
            Office.DocumentProperties properties = (Office.DocumentProperties)this.CustomDocumentProperties;

            if (ReadDocumentProperty("New blah blah") != null)
            {
                properties["New blah blah"].Delete();
            }

            properties.Add("New blah blah", false,
                Microsoft.Office.Core.MsoDocProperties.msoPropertyTypeString,
                stringToReplaceCustProperty);
        }

        private string ReadDocumentProperty(string propertyName)
        {
            Office.DocumentProperties properties;
            properties = (Office.DocumentProperties)this.CustomDocumentProperties;

            if (properties != null)
            { 
                foreach (Office.DocumentProperty prop in properties)
                {
                    if (prop.Name == propertyName)
                    {
                        return prop.Value.ToString();
                    }
                }
            }
            return null;
        }
    }
}

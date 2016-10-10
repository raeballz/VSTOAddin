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

        /// <summary>
        /// Property for current active document
        /// </summary>
        Document ActiveDocument { get; }

        /// <summary>
        /// Fetches Custom doc properties for current open word document
        /// </summary>
        object CustomDocumentProperties
        {
           get
           {
                Document doc = Globals.ThisAddIn.Application.ActiveDocument;
                return doc.CustomDocumentProperties;
           }
        }
        
        /// <summary>
        /// Finds a custom property on a word document. If it exists, deletes
        /// and replaces it. Else, it will add the property. 
        /// </summary>
        /// <param name="stringToReplaceCustProperty"></param>
        public void ReplaceTestProperty(string custPropertyName, string custPropertyValue)
        {
            Office.DocumentProperties properties = (Office.DocumentProperties)this.CustomDocumentProperties;

            if (ReadDocumentProperty(custPropertyName) != null)
            {
                properties[custPropertyName].Delete();
            }

            properties.Add(custPropertyName, false,
                Microsoft.Office.Core.MsoDocProperties.msoPropertyTypeString,
                custPropertyValue);
        }


        /// <summary>
        /// Reads a document for custom properties, returning them as strings. 
        /// If no custom properties exist, returns null.
        /// </summary>
        /// <param name="propertyName"></param>
        /// <returns></returns>
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

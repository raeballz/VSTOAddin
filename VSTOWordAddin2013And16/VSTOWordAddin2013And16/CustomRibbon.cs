using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;
using VSTOWordAddin.Core.Models;

namespace VSTOWordAddin2013And16
{
    /// <summary>
    /// Contains logic for event handlers on custom ribbon.
    /// </summary>
    public partial class CustomRibbon
    {
        AddInUtilities addin = new AddInUtilities();

        private string docText = string.Empty;

        private void CustomRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, RibbonControlEventArgs e)
        {

        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void button3_Click(object sender, RibbonControlEventArgs e)
        {

        }

        /// <summary>
        /// Event handler to insert patient DOB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, RibbonControlEventArgs e)
        {
            InsertTag(Tags.DOB);
        }

        /// <summary>
        /// Event handler to insert patient Age
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgeButton_Click(object sender, RibbonControlEventArgs e)
        {
            InsertTag(Tags.AGE);
        }

        /// <summary>
        /// Event handler to insert patient first name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirstNameButton_Click(object sender, RibbonControlEventArgs e)
        {
            InsertTag(Tags.FORENAME);
        }

        /// <summary>
        /// Event handler to insert patient middle name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SecondNameButton_Click(object sender, RibbonControlEventArgs e)
        {
            InsertTag(Tags.MIDDLENAMES);
        }

        /// <summary>
        /// Event handler to insert patient last name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThirdNameButton_Click(object sender, RibbonControlEventArgs e)
        {
            InsertTag(Tags.SURNAME);
        }

        /// <summary>
        /// Event handler to insert patient post code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PostCodeButton_Click(object sender, RibbonControlEventArgs e)
        {
            InsertTag(Tags.POSTCODE);
        }

        /// <summary>
        /// Event handler to insert patient full address
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FullAddressButton_Click(object sender, RibbonControlEventArgs e)
        {
            InsertTag(Tags.ADDRESS);
        }

        /// <summary>
        /// Event handler to insert patient phonenumber
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneNumberButton_Click(object sender, RibbonControlEventArgs e)
        {
            InsertTag(Tags.PHONENO);
        }

        /// <summary>
        /// Event handler to insert patient email address
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailAddressButton_Click(object sender, RibbonControlEventArgs e)
        {
            InsertTag(Tags.EMAIL);
        }

        /// <summary>
        /// Event handler to insert patient mobile number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MobileTagButton_Click(object sender, RibbonControlEventArgs e)
        {
            InsertTag(Tags.MOBILENO);
        }

        /// <summary>
        /// Event handler for saving a new property. Takes text from the two
        /// input boxes, and creates the property name and input value, 
        /// saving it to the document's properties. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveProperty_Click(object sender, RibbonControlEventArgs e)
        {
            string customPropertyName = this.CustomPropertyName.Text;
            string customPropertyValue = this.CustomPropertyInput.Text;
            addin.ReplaceTestProperty(customPropertyName, customPropertyValue);
        }

        private void ReplaceTags_Click(object sender, RibbonControlEventArgs e)
        {
            
            Globals.ThisAddIn.Application.ActiveDocument.Range().Text = ViewModel.swapTagsForData(Globals.ThisAddIn.Application.ActiveDocument.Range().Text);
        }

        public void InsertTag(string tag)
        {
            Word.Range currentRange = Globals.ThisAddIn.Application.Selection.Range;

            currentRange.Text = tag;

            object what = Word.WdGoToItem.wdGoToPercent;
            object which = Word.WdGoToDirection.wdGoToLast;

            Globals.ThisAddIn.Application.Selection.GoTo(ref what, ref which);
        }
    }
}

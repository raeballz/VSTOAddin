using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;

namespace VSTOWordAddin2013And16
{
    public partial class CustomRibbon
    {

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


        private void button5_Click(object sender, RibbonControlEventArgs e)
        {
            Word.Range currentRange = Globals.ThisAddIn.Application.Selection.Range;
            currentRange.Text = "[[PATIENTDOB]]";
        }

        private void AgeButton_Click(object sender, RibbonControlEventArgs e)
        {
            Word.Range currentRange = Globals.ThisAddIn.Application.Selection.Range;
            currentRange.Text = "[[PATIENTAGE]]";
        }

        private void FirstNameButton_Click(object sender, RibbonControlEventArgs e)
        {
            Word.Range currentRange = Globals.ThisAddIn.Application.Selection.Range;
            currentRange.Text = "[[PATIENTFIRSTNAME]]";
        }

        private void SecondNameButton_Click(object sender, RibbonControlEventArgs e)
        {
            Word.Range currentRange = Globals.ThisAddIn.Application.Selection.Range;
            currentRange.Text = "[[PATIENTMIDDLENAME]]";
        }

        private void ThirdNameButton_Click(object sender, RibbonControlEventArgs e)
        {
            Word.Range currentRange = Globals.ThisAddIn.Application.Selection.Range;
            currentRange.Text = "[[PATIENTSURNAME]]";
        }

        private void PostCodeButton_Click(object sender, RibbonControlEventArgs e)
        {
            Word.Range currentRange = Globals.ThisAddIn.Application.Selection.Range;
            currentRange.Text = "[[PATIENTPOSTCODE]]";
        }

        private void FullAddressButton_Click(object sender, RibbonControlEventArgs e)
        {
            Word.Range currentRange = Globals.ThisAddIn.Application.Selection.Range;
            currentRange.Text = "[[PATIENTFULLADDRESS]]";
        }

        private void PhoneNumberButton_Click(object sender, RibbonControlEventArgs e)
        {
            Word.Range currentRange = Globals.ThisAddIn.Application.Selection.Range;
            currentRange.Text = "[[PATIENTPHONENUMBER]]";
        }

        private void EmailAddressButton_Click(object sender, RibbonControlEventArgs e)
        {
            Word.Range currentRange = Globals.ThisAddIn.Application.Selection.Range;
            currentRange.Text = "[[PATIENTEMAILADDRESS]]";
        }

        private void MobileTagButton_Click(object sender, RibbonControlEventArgs e)
        {
            Word.Range currentRange = Globals.ThisAddIn.Application.Selection.Range;
            currentRange.Text = "[[PATIENTMOBILENUMBER]]";
        }
    }
}

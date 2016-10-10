using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using VSTOWordAddin.Core.Models;
using VSTOWordAddin.Core.Interfaces;
using Newtonsoft.Json;
using Microsoft.Office.Interop.Word;
using System.Data.SQLite;

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

            SQLiteConnection con = new SQLiteConnection(@"Data Source=E:\\DataBases\\VSTODB.db;Version=3;New=True;Compress=True;");
            con.Open();

            string sqlInsert = "insert into patient(SerialisedPatient) values ('" + PatData + "')";
            var deleteCMD = new SQLiteCommand("DELETE FROM patient", con);
            var CMD = new SQLiteCommand(sqlInsert, con);

            try
            {
                deleteCMD.ExecuteNonQuery();
                CMD.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public Patient CurrentPatient
        {
            get { return this.currentPatient; }
            set { this.currentPatient = value; }
        }
    }
}

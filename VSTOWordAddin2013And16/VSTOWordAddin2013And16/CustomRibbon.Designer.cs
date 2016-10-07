namespace VSTOWordAddin2013And16
{
    partial class CustomRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public CustomRibbon()

            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonButton button4;
            this.PatientDetailsTab = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.buttonGroup1 = this.Factory.CreateRibbonButtonGroup();
            this.button1 = this.Factory.CreateRibbonButton();
            this.button2 = this.Factory.CreateRibbonButton();
            this.button3 = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.tab2 = this.Factory.CreateRibbonTab();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.PatientPersonalDetails = this.Factory.CreateRibbonTab();
            this.group4 = this.Factory.CreateRibbonGroup();
            this.button5 = this.Factory.CreateRibbonButton();
            this.group5 = this.Factory.CreateRibbonGroup();
            this.button6 = this.Factory.CreateRibbonButton();
            this.button7 = this.Factory.CreateRibbonButton();
            this.button8 = this.Factory.CreateRibbonButton();
            button4 = this.Factory.CreateRibbonButton();
            this.PatientDetailsTab.SuspendLayout();
            this.group1.SuspendLayout();
            this.buttonGroup1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.tab1.SuspendLayout();
            this.PatientPersonalDetails.SuspendLayout();
            this.group4.SuspendLayout();
            this.group5.SuspendLayout();
            this.SuspendLayout();
            // 
            // PatientDetailsTab
            // 
            this.PatientDetailsTab.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.PatientDetailsTab.Groups.Add(this.group1);
            this.PatientDetailsTab.Groups.Add(this.group2);
            this.PatientDetailsTab.Groups.Add(this.group3);
            this.PatientDetailsTab.Label = "Patient Details";
            this.PatientDetailsTab.Name = "PatientDetailsTab";
            // 
            // group1
            // 
            this.group1.Items.Add(this.buttonGroup1);
            this.group1.Label = "Personal Details";
            this.group1.Name = "group1";
            // 
            // buttonGroup1
            // 
            this.buttonGroup1.Items.Add(this.button1);
            this.buttonGroup1.Items.Add(this.button2);
            this.buttonGroup1.Items.Add(this.button3);
            this.buttonGroup1.Name = "buttonGroup1";
            this.buttonGroup1.Tag = "Insert Name";
            // 
            // button1
            // 
            this.button1.Label = "Add Forename";
            this.button1.Name = "button1";
            this.button1.ShowImage = true;
            // 
            // button2
            // 
            this.button2.Label = "Add Middle Name(s)";
            this.button2.Name = "button2";
            this.button2.ShowImage = true;
            // 
            // button3
            // 
            this.button3.Label = "Add Surname";
            this.button3.Name = "button3";
            this.button3.ShowImage = true;
            this.button3.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button3_Click);
            // 
            // group2
            // 
            this.group2.Label = "Address Details";
            this.group2.Name = "group2";
            // 
            // group3
            // 
            this.group3.Label = "group3";
            this.group3.Name = "group3";
            // 
            // tab2
            // 
            this.tab2.Label = "Patient Medication";
            this.tab2.Name = "tab2";
            // 
            // tab1
            // 
            this.tab1.Label = "Patient Health ";
            this.tab1.Name = "tab1";
            // 
            // PatientPersonalDetails
            // 
            this.PatientPersonalDetails.Groups.Add(this.group4);
            this.PatientPersonalDetails.Groups.Add(this.group5);
            this.PatientPersonalDetails.Label = "Patient Personal Details";
            this.PatientPersonalDetails.Name = "PatientPersonalDetails";
            // 
            // group4
            // 
            this.group4.Items.Add(button4);
            this.group4.Items.Add(this.button5);
            this.group4.Label = "Age";
            this.group4.Name = "group4";
            // 
            // button4
            // 
            button4.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            button4.Label = "Add Age Tag";
            button4.Name = "button4";
            button4.OfficeImageId = "NumberInsert";
            button4.ShowImage = true;
            // 
            // button5
            // 
            this.button5.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button5.Label = "Add Date Of Birth Tag";
            this.button5.Name = "button5";
            this.button5.OfficeImageId = "DateAndTimeInsert";
            this.button5.ShowImage = true;
            this.button5.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button5_Click);
            // 
            // group5
            // 
            this.group5.Items.Add(this.button6);
            this.group5.Items.Add(this.button7);
            this.group5.Items.Add(this.button8);
            this.group5.Label = "Name";
            this.group5.Name = "group5";
            // 
            // button6
            // 
            this.button6.Label = "Insert First Name Tag";
            this.button6.Name = "button6";
            this.button6.OfficeImageId = "MailMergeGoToFirstRecord";
            this.button6.ShowImage = true;
            // 
            // button7
            // 
            this.button7.Label = "Insert Second Name Tag";
            this.button7.Name = "button7";
            this.button7.OfficeImageId = "MailMergeGoToNextRecord";
            this.button7.ShowImage = true;
            // 
            // button8
            // 
            this.button8.Label = "Insert Third Name Tag";
            this.button8.Name = "button8";
            this.button8.OfficeImageId = "MailMergeGotToLastRecord";
            this.button8.ShowImage = true;
            // 
            // CustomRibbon
            // 
            this.Name = "CustomRibbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.PatientPersonalDetails);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.CustomRibbon_Load);
            this.PatientDetailsTab.ResumeLayout(false);
            this.PatientDetailsTab.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.buttonGroup1.ResumeLayout(false);
            this.buttonGroup1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.PatientPersonalDetails.ResumeLayout(false);
            this.PatientPersonalDetails.PerformLayout();
            this.group4.ResumeLayout(false);
            this.group4.PerformLayout();
            this.group5.ResumeLayout(false);
            this.group5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab PatientDetailsTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab2;
        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButtonGroup buttonGroup1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button3;
        internal Microsoft.Office.Tools.Ribbon.RibbonTab PatientPersonalDetails;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group4;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button5;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group5;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button6;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button7;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button8;
    }

    partial class ThisRibbonCollection
    {
        internal CustomRibbon CustomRibbon
        {
            get { return this.GetRibbon<CustomRibbon>(); }
        }
    }
}

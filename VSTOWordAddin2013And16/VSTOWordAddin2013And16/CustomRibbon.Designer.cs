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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomRibbon));
            this.PatientDetailsTab = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.tab2 = this.Factory.CreateRibbonTab();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.buttonGroup1 = this.Factory.CreateRibbonButtonGroup();
            this.button1 = this.Factory.CreateRibbonButton();
            this.button2 = this.Factory.CreateRibbonButton();
            this.button3 = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.PatientDetailsTab.SuspendLayout();
            this.group1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.tab1.SuspendLayout();
            this.buttonGroup1.SuspendLayout();
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
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Label = "Add Forename";
            this.button1.Name = "button1";
            this.button1.ShowImage = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Label = "Add Middle Name(s)";
            this.button2.Name = "button2";
            this.button2.ShowImage = true;
            // 
            // button3
            // 
            this.button3.Image = global::VSTOWordAddin2013And16.Properties.Resources._1475855936_number_three;
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
            // CustomRibbon
            // 
            this.Name = "CustomRibbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.PatientDetailsTab);
            this.Tabs.Add(this.tab2);
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.CustomRibbon_Load);
            this.PatientDetailsTab.ResumeLayout(false);
            this.PatientDetailsTab.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.buttonGroup1.ResumeLayout(false);
            this.buttonGroup1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab PatientDetailsTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab2;
        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButtonGroup buttonGroup1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button3;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
    }

    partial class ThisRibbonCollection
    {
        internal CustomRibbon CustomRibbon
        {
            get { return this.GetRibbon<CustomRibbon>(); }
        }
    }
}

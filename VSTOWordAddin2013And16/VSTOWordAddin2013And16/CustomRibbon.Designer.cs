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
            this.PatientDetailsTab = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.buttonGroup1 = this.Factory.CreateRibbonButtonGroup();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.tab2 = this.Factory.CreateRibbonTab();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.PatientPersonalDetails = this.Factory.CreateRibbonTab();
            this.group6 = this.Factory.CreateRibbonGroup();
            this.group4 = this.Factory.CreateRibbonGroup();
            this.group5 = this.Factory.CreateRibbonGroup();
            this.AddressGroup = this.Factory.CreateRibbonGroup();
            this.contactDetails = this.Factory.CreateRibbonGroup();
            this.DocPropTest = this.Factory.CreateRibbonTab();
            this.PropertyInputGroup = this.Factory.CreateRibbonGroup();
            this.CustomPropertyInput = this.Factory.CreateRibbonEditBox();
            this.ReplaceTags = this.Factory.CreateRibbonButton();
            this.AgeButton = this.Factory.CreateRibbonButton();
            this.DoBButton = this.Factory.CreateRibbonButton();
            this.FirstNameButton = this.Factory.CreateRibbonButton();
            this.SecondNameButton = this.Factory.CreateRibbonButton();
            this.ThirdNameButton = this.Factory.CreateRibbonButton();
            this.PostCodeButton = this.Factory.CreateRibbonButton();
            this.FullAddressButton = this.Factory.CreateRibbonButton();
            this.PhoneNumberButton = this.Factory.CreateRibbonButton();
            this.EmailAddressButton = this.Factory.CreateRibbonButton();
            this.MobileTagButton = this.Factory.CreateRibbonButton();
            this.button1 = this.Factory.CreateRibbonButton();
            this.button2 = this.Factory.CreateRibbonButton();
            this.button3 = this.Factory.CreateRibbonButton();
            this.SaveProperty = this.Factory.CreateRibbonButton();
            this.PatientDetailsTab.SuspendLayout();
            this.group1.SuspendLayout();
            this.buttonGroup1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.tab1.SuspendLayout();
            this.PatientPersonalDetails.SuspendLayout();
            this.group6.SuspendLayout();
            this.group4.SuspendLayout();
            this.group5.SuspendLayout();
            this.AddressGroup.SuspendLayout();
            this.contactDetails.SuspendLayout();
            this.DocPropTest.SuspendLayout();
            this.PropertyInputGroup.SuspendLayout();
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
            this.PatientPersonalDetails.Groups.Add(this.group6);
            this.PatientPersonalDetails.Groups.Add(this.group4);
            this.PatientPersonalDetails.Groups.Add(this.group5);
            this.PatientPersonalDetails.Groups.Add(this.AddressGroup);
            this.PatientPersonalDetails.Groups.Add(this.contactDetails);
            this.PatientPersonalDetails.Label = "Patient Personal Details";
            this.PatientPersonalDetails.Name = "PatientPersonalDetails";
            // 
            // group6
            // 
            this.group6.Items.Add(this.ReplaceTags);
            this.group6.Label = "Replace Tags";
            this.group6.Name = "group6";
            // 
            // group4
            // 
            this.group4.Items.Add(this.AgeButton);
            this.group4.Items.Add(this.DoBButton);
            this.group4.Label = "Age";
            this.group4.Name = "group4";
            // 
            // group5
            // 
            this.group5.Items.Add(this.FirstNameButton);
            this.group5.Items.Add(this.SecondNameButton);
            this.group5.Items.Add(this.ThirdNameButton);
            this.group5.Label = "Name";
            this.group5.Name = "group5";
            // 
            // AddressGroup
            // 
            this.AddressGroup.Items.Add(this.PostCodeButton);
            this.AddressGroup.Items.Add(this.FullAddressButton);
            this.AddressGroup.Label = "Address";
            this.AddressGroup.Name = "AddressGroup";
            // 
            // contactDetails
            // 
            this.contactDetails.Items.Add(this.PhoneNumberButton);
            this.contactDetails.Items.Add(this.EmailAddressButton);
            this.contactDetails.Items.Add(this.MobileTagButton);
            this.contactDetails.Label = "Contact Details";
            this.contactDetails.Name = "contactDetails";
            // 
            // DocPropTest
            // 
            this.DocPropTest.Groups.Add(this.PropertyInputGroup);
            this.DocPropTest.Label = " DOCUMENT PROPERTY TEST";
            this.DocPropTest.Name = "DocPropTest";
            // 
            // PropertyInputGroup
            // 
            this.PropertyInputGroup.Items.Add(this.CustomPropertyInput);
            this.PropertyInputGroup.Items.Add(this.SaveProperty);
            this.PropertyInputGroup.Label = "Input";
            this.PropertyInputGroup.Name = "PropertyInputGroup";
            // 
            // CustomPropertyInput
            // 
            this.CustomPropertyInput.Label = "Custom Property Text: ";
            this.CustomPropertyInput.MaxLength = 255;
            this.CustomPropertyInput.Name = "CustomPropertyInput";
            this.CustomPropertyInput.OfficeImageId = "GroupInsertText";
            this.CustomPropertyInput.ShowImage = true;
            // 
            // ReplaceTags
            // 
            this.ReplaceTags.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.ReplaceTags.Label = "Replace Tags";
            this.ReplaceTags.Name = "ReplaceTags";
            this.ReplaceTags.OfficeImageId = "ReplaceDialog";
            this.ReplaceTags.ShowImage = true;
            // 
            // AgeButton
            // 
            this.AgeButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.AgeButton.Label = "Add Age Tag";
            this.AgeButton.Name = "AgeButton";
            this.AgeButton.OfficeImageId = "NumberInsert";
            this.AgeButton.ShowImage = true;
            this.AgeButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AgeButton_Click);
            // 
            // DoBButton
            // 
            this.DoBButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.DoBButton.Label = "Add Date Of Birth Tag";
            this.DoBButton.Name = "DoBButton";
            this.DoBButton.OfficeImageId = "DateAndTimeInsert";
            this.DoBButton.ShowImage = true;
            this.DoBButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button5_Click);
            // 
            // FirstNameButton
            // 
            this.FirstNameButton.Label = "Insert First Name Tag";
            this.FirstNameButton.Name = "FirstNameButton";
            this.FirstNameButton.OfficeImageId = "MailMergeGoToFirstRecord";
            this.FirstNameButton.ShowImage = true;
            this.FirstNameButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.FirstNameButton_Click);
            // 
            // SecondNameButton
            // 
            this.SecondNameButton.Label = "Insert Second Name Tag";
            this.SecondNameButton.Name = "SecondNameButton";
            this.SecondNameButton.OfficeImageId = "MailMergeGoToNextRecord";
            this.SecondNameButton.ShowImage = true;
            this.SecondNameButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SecondNameButton_Click);
            // 
            // ThirdNameButton
            // 
            this.ThirdNameButton.Label = "Insert Third Name Tag";
            this.ThirdNameButton.Name = "ThirdNameButton";
            this.ThirdNameButton.OfficeImageId = "MailMergeGotToLastRecord";
            this.ThirdNameButton.ShowImage = true;
            this.ThirdNameButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ThirdNameButton_Click);
            // 
            // PostCodeButton
            // 
            this.PostCodeButton.Label = "Insert Post Code Tag";
            this.PostCodeButton.Name = "PostCodeButton";
            this.PostCodeButton.OfficeImageId = "JapanesePostcardDialog";
            this.PostCodeButton.ShowImage = true;
            this.PostCodeButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.PostCodeButton_Click);
            // 
            // FullAddressButton
            // 
            this.FullAddressButton.Label = "Insert Full Address";
            this.FullAddressButton.Name = "FullAddressButton";
            this.FullAddressButton.OfficeImageId = "MailMergeAddressBlockInsert";
            this.FullAddressButton.ShowImage = true;
            this.FullAddressButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.FullAddressButton_Click);
            // 
            // PhoneNumberButton
            // 
            this.PhoneNumberButton.Label = "Insert Phone Number Tag";
            this.PhoneNumberButton.Name = "PhoneNumberButton";
            this.PhoneNumberButton.OfficeImageId = "MailMergeMergeToFax";
            this.PhoneNumberButton.ShowImage = true;
            this.PhoneNumberButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.PhoneNumberButton_Click);
            // 
            // EmailAddressButton
            // 
            this.EmailAddressButton.Label = "Insert E-mail Address Tag";
            this.EmailAddressButton.Name = "EmailAddressButton";
            this.EmailAddressButton.OfficeImageId = "MailMergeStartEmail";
            this.EmailAddressButton.ShowImage = true;
            this.EmailAddressButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.EmailAddressButton_Click);
            // 
            // MobileTagButton
            // 
            this.MobileTagButton.Label = "Insert Mobile Number Tag";
            this.MobileTagButton.Name = "MobileTagButton";
            this.MobileTagButton.OfficeImageId = "InsertNumberAlternate";
            this.MobileTagButton.ShowImage = true;
            this.MobileTagButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.MobileTagButton_Click);
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
            // SaveProperty
            // 
            this.SaveProperty.Label = "Save Property Text";
            this.SaveProperty.Name = "SaveProperty";
            this.SaveProperty.OfficeImageId = "FileSave";
            this.SaveProperty.ShowImage = true;
            this.SaveProperty.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SaveProperty_Click);
            // 
            // CustomRibbon
            // 
            this.Name = "CustomRibbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.PatientPersonalDetails);
            this.Tabs.Add(this.DocPropTest);
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
            this.group6.ResumeLayout(false);
            this.group6.PerformLayout();
            this.group4.ResumeLayout(false);
            this.group4.PerformLayout();
            this.group5.ResumeLayout(false);
            this.group5.PerformLayout();
            this.AddressGroup.ResumeLayout(false);
            this.AddressGroup.PerformLayout();
            this.contactDetails.ResumeLayout(false);
            this.contactDetails.PerformLayout();
            this.DocPropTest.ResumeLayout(false);
            this.DocPropTest.PerformLayout();
            this.PropertyInputGroup.ResumeLayout(false);
            this.PropertyInputGroup.PerformLayout();
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
        internal Microsoft.Office.Tools.Ribbon.RibbonButton DoBButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group5;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton FirstNameButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton SecondNameButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ThirdNameButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group6;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ReplaceTags;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup AddressGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton PostCodeButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton FullAddressButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup contactDetails;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton PhoneNumberButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton EmailAddressButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton MobileTagButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton AgeButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonTab DocPropTest;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup PropertyInputGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox CustomPropertyInput;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton SaveProperty;
    }

    partial class ThisRibbonCollection
    {
        internal CustomRibbon CustomRibbon
        {
            get { return this.GetRibbon<CustomRibbon>(); }
        }
    }
}

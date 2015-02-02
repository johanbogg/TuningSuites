﻿namespace T8SuitePro
{
    partial class frmTuningWizard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wizardTuning = new DevExpress.XtraWizard.WizardControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.wizWelcomePage = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.wizSelectActionPage = new DevExpress.XtraWizard.WizardPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.listTuningActions = new DevExpress.XtraEditors.ListBoxControl();
            this.wizCompletedPage = new DevExpress.XtraWizard.CompletionWizardPage();
            this.wizConfirmPage = new DevExpress.XtraWizard.WizardPage();
            ((System.ComponentModel.ISupportInitialize)(this.wizardTuning)).BeginInit();
            this.wizardTuning.SuspendLayout();
            this.wizSelectActionPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listTuningActions)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardTuning
            // 
            this.wizardTuning.Controls.Add(this.labelControl3);
            this.wizardTuning.Controls.Add(this.wizWelcomePage);
            this.wizardTuning.Controls.Add(this.wizSelectActionPage);
            this.wizardTuning.Controls.Add(this.wizCompletedPage);
            this.wizardTuning.Controls.Add(this.wizConfirmPage);
            this.wizardTuning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardTuning.Location = new System.Drawing.Point(0, 0);
            this.wizardTuning.Name = "wizardTuning";
            this.wizardTuning.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.wizWelcomePage,
            this.wizSelectActionPage,
            this.wizConfirmPage,
            this.wizCompletedPage});
            this.wizardTuning.Size = new System.Drawing.Size(531, 316);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Location = new System.Drawing.Point(24, 290);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(190, 16);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "EXPERIMENTAL - Not yet working";
            // 
            // wizWelcomePage
            // 
            this.wizWelcomePage.IntroductionText = "This wizard will help you apply a pre-defined set of Tuning Actions to your binar" +
                "y file. You will be given a choice of Tuning Actions in the coming pages.";
            this.wizWelcomePage.Name = "wizWelcomePage";
            this.wizWelcomePage.Size = new System.Drawing.Size(314, 184);
            this.wizWelcomePage.Text = "Tuning Wizard";
            // 
            // wizSelectActionPage
            // 
            this.wizSelectActionPage.Controls.Add(this.splitContainerControl1);
            this.wizSelectActionPage.DescriptionText = "Selection your wanted Tuning Action from the list below and click Next";
            this.wizSelectActionPage.Name = "wizSelectActionPage";
            this.wizSelectActionPage.Size = new System.Drawing.Size(499, 173);
            this.wizSelectActionPage.Text = "Select Tuning Action";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.listTuningActions);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(499, 173);
            this.splitContainerControl1.SplitterPosition = 101;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl2.Location = new System.Drawing.Point(4, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "FFFF";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl1.Location = new System.Drawing.Point(4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Software Version";
            // 
            // listTuningActions
            // 
            this.listTuningActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listTuningActions.Location = new System.Drawing.Point(0, 0);
            this.listTuningActions.Name = "listTuningActions";
            this.listTuningActions.Size = new System.Drawing.Size(386, 173);
            this.listTuningActions.TabIndex = 0;
            // 
            // wizCompletedPage
            // 
            this.wizCompletedPage.FinishText = "You have completed the seelcted tuning action.";
            this.wizCompletedPage.Name = "wizCompletedPage";
            this.wizCompletedPage.Size = new System.Drawing.Size(314, 184);
            this.wizCompletedPage.Text = "Completed Tuning Wizard";
            // 
            // wizConfirmPage
            // 
            this.wizConfirmPage.DescriptionText = "Please confirm your Tuning Action and click Next";
            this.wizConfirmPage.Name = "wizConfirmPage";
            this.wizConfirmPage.Size = new System.Drawing.Size(499, 173);
            this.wizConfirmPage.Text = "Confirm Tuning Action";
            // 
            // frmTuningWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 316);
            this.Controls.Add(this.wizardTuning);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "frmTuningWizard";
            this.Text = "Tuning Wizard";
            ((System.ComponentModel.ISupportInitialize)(this.wizardTuning)).EndInit();
            this.wizardTuning.ResumeLayout(false);
            this.wizardTuning.PerformLayout();
            this.wizSelectActionPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listTuningActions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardTuning;
        private DevExpress.XtraWizard.WelcomeWizardPage wizWelcomePage;
        private DevExpress.XtraWizard.WizardPage wizSelectActionPage;
        private DevExpress.XtraWizard.CompletionWizardPage wizCompletedPage;
        private DevExpress.XtraWizard.WizardPage wizConfirmPage;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ListBoxControl listTuningActions;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}
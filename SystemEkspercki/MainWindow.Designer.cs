namespace SystemEkspercki
{
    partial class MainWindow
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.inferenceModuleTabPage = new System.Windows.Forms.TabPage();
            this.inferenceModulePanel = new System.Windows.Forms.TableLayoutPanel();
            this.revisionInferenceTabPage = new System.Windows.Forms.TabPage();
            this.inferenceRevisionRtb = new System.Windows.Forms.RichTextBox();
            this.knowlegdeEditorTabPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditRule = new System.Windows.Forms.Button();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.cbRules = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbRuleCreatingFact = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbQuestionContent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemoveFactFromRuleArgs = new System.Windows.Forms.Button();
            this.btnMoveFactWithFalse = new System.Windows.Forms.Button();
            this.btnMoveFactWithTrue = new System.Windows.Forms.Button();
            this.lbAllFacts = new System.Windows.Forms.ListBox();
            this.gbFacts = new System.Windows.Forms.GroupBox();
            this.lblFactRule = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditFact = new System.Windows.Forms.Button();
            this.btnRemoveFact = new System.Windows.Forms.Button();
            this.cbFacts = new System.Windows.Forms.ComboBox();
            this.btnAddFact = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.endOfInferencingLbl = new System.Windows.Forms.Label();
            this.btnDeleteRule = new System.Windows.Forms.Button();
            this.clbRuleArguments = new System.Windows.Forms.CheckedListBox();
            this.tabControl.SuspendLayout();
            this.inferenceModuleTabPage.SuspendLayout();
            this.revisionInferenceTabPage.SuspendLayout();
            this.knowlegdeEditorTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbFacts.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.inferenceModuleTabPage);
            this.tabControl.Controls.Add(this.revisionInferenceTabPage);
            this.tabControl.Controls.Add(this.knowlegdeEditorTabPage);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(372, 372);
            this.tabControl.TabIndex = 0;
            // 
            // inferenceModuleTabPage
            // 
            this.inferenceModuleTabPage.AutoScroll = true;
            this.inferenceModuleTabPage.Controls.Add(this.inferenceModulePanel);
            this.inferenceModuleTabPage.Location = new System.Drawing.Point(4, 22);
            this.inferenceModuleTabPage.Name = "inferenceModuleTabPage";
            this.inferenceModuleTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.inferenceModuleTabPage.Size = new System.Drawing.Size(364, 346);
            this.inferenceModuleTabPage.TabIndex = 0;
            this.inferenceModuleTabPage.Text = "Moduł wnioskujący";
            this.inferenceModuleTabPage.UseVisualStyleBackColor = true;
            // 
            // inferenceModulePanel
            // 
            this.inferenceModulePanel.AutoScroll = true;
            this.inferenceModulePanel.ColumnCount = 1;
            this.inferenceModulePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inferenceModulePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inferenceModulePanel.Location = new System.Drawing.Point(3, 3);
            this.inferenceModulePanel.Name = "inferenceModulePanel";
            this.inferenceModulePanel.RowCount = 1;
            this.inferenceModulePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inferenceModulePanel.Size = new System.Drawing.Size(358, 340);
            this.inferenceModulePanel.TabIndex = 0;
            // 
            // revisionInferenceTabPage
            // 
            this.revisionInferenceTabPage.Controls.Add(this.inferenceRevisionRtb);
            this.revisionInferenceTabPage.Location = new System.Drawing.Point(4, 22);
            this.revisionInferenceTabPage.Name = "revisionInferenceTabPage";
            this.revisionInferenceTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.revisionInferenceTabPage.Size = new System.Drawing.Size(364, 346);
            this.revisionInferenceTabPage.TabIndex = 1;
            this.revisionInferenceTabPage.Text = "Rewizja wnioskowania";
            this.revisionInferenceTabPage.UseVisualStyleBackColor = true;
            // 
            // inferenceRevisionRtb
            // 
            this.inferenceRevisionRtb.AcceptsTab = true;
            this.inferenceRevisionRtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inferenceRevisionRtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inferenceRevisionRtb.Location = new System.Drawing.Point(3, 3);
            this.inferenceRevisionRtb.Margin = new System.Windows.Forms.Padding(0);
            this.inferenceRevisionRtb.Name = "inferenceRevisionRtb";
            this.inferenceRevisionRtb.ReadOnly = true;
            this.inferenceRevisionRtb.Size = new System.Drawing.Size(358, 340);
            this.inferenceRevisionRtb.TabIndex = 0;
            this.inferenceRevisionRtb.Text = "";
            this.inferenceRevisionRtb.WordWrap = false;
            // 
            // knowlegdeEditorTabPage
            // 
            this.knowlegdeEditorTabPage.Controls.Add(this.panel1);
            this.knowlegdeEditorTabPage.Location = new System.Drawing.Point(4, 22);
            this.knowlegdeEditorTabPage.Name = "knowlegdeEditorTabPage";
            this.knowlegdeEditorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.knowlegdeEditorTabPage.Size = new System.Drawing.Size(364, 346);
            this.knowlegdeEditorTabPage.TabIndex = 2;
            this.knowlegdeEditorTabPage.Text = "Edytor wiedzy";
            this.knowlegdeEditorTabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gbFacts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 340);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clbRuleArguments);
            this.groupBox1.Controls.Add(this.btnDeleteRule);
            this.groupBox1.Controls.Add(this.btnEditRule);
            this.groupBox1.Controls.Add(this.btnAddRule);
            this.groupBox1.Controls.Add(this.cbRules);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbRuleCreatingFact);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbQuestionContent);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnRemoveFactFromRuleArgs);
            this.groupBox1.Controls.Add(this.btnMoveFactWithFalse);
            this.groupBox1.Controls.Add(this.btnMoveFactWithTrue);
            this.groupBox1.Controls.Add(this.lbAllFacts);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 222);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reguły";
            // 
            // btnEditRule
            // 
            this.btnEditRule.Location = new System.Drawing.Point(68, 61);
            this.btnEditRule.Name = "btnEditRule";
            this.btnEditRule.Size = new System.Drawing.Size(52, 23);
            this.btnEditRule.TabIndex = 14;
            this.btnEditRule.Text = "&Edytuj";
            this.btnEditRule.UseVisualStyleBackColor = true;
            this.btnEditRule.Click += new System.EventHandler(this.btnEditRule_Click);
            // 
            // btnAddRule
            // 
            this.btnAddRule.Location = new System.Drawing.Point(10, 61);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(52, 23);
            this.btnAddRule.TabIndex = 13;
            this.btnAddRule.Text = "&Dodaj";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // cbRules
            // 
            this.cbRules.FormattingEnabled = true;
            this.cbRules.Location = new System.Drawing.Point(10, 33);
            this.cbRules.Name = "cbRules";
            this.cbRules.Size = new System.Drawing.Size(168, 21);
            this.cbRules.TabIndex = 12;
            this.cbRules.SelectedIndexChanged += new System.EventHandler(this.cbRules_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Reguła:";
            // 
            // cbRuleCreatingFact
            // 
            this.cbRuleCreatingFact.FormattingEnabled = true;
            this.cbRuleCreatingFact.Location = new System.Drawing.Point(199, 77);
            this.cbRuleCreatingFact.Name = "cbRuleCreatingFact";
            this.cbRuleCreatingFact.Size = new System.Drawing.Size(153, 21);
            this.cbRuleCreatingFact.TabIndex = 10;
            this.cbRuleCreatingFact.SelectedIndexChanged += new System.EventHandler(this.cbRuleCreatingFact_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Reguła tworzy fakt:";
            // 
            // tbQuestionContent
            // 
            this.tbQuestionContent.Location = new System.Drawing.Point(199, 33);
            this.tbQuestionContent.Name = "tbQuestionContent";
            this.tbQuestionContent.Size = new System.Drawing.Size(153, 20);
            this.tbQuestionContent.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Treść pytania:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Argumenty:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fakty:";
            // 
            // btnRemoveFactFromRuleArgs
            // 
            this.btnRemoveFactFromRuleArgs.Location = new System.Drawing.Point(172, 193);
            this.btnRemoveFactFromRuleArgs.Name = "btnRemoveFactFromRuleArgs";
            this.btnRemoveFactFromRuleArgs.Size = new System.Drawing.Size(21, 23);
            this.btnRemoveFactFromRuleArgs.TabIndex = 4;
            this.btnRemoveFactFromRuleArgs.Text = "<";
            this.btnRemoveFactFromRuleArgs.UseVisualStyleBackColor = true;
            this.btnRemoveFactFromRuleArgs.Click += new System.EventHandler(this.btnRemoveFactFromRuleArgs_Click);
            // 
            // btnMoveFactWithFalse
            // 
            this.btnMoveFactWithFalse.Location = new System.Drawing.Point(172, 150);
            this.btnMoveFactWithFalse.Name = "btnMoveFactWithFalse";
            this.btnMoveFactWithFalse.Size = new System.Drawing.Size(21, 23);
            this.btnMoveFactWithFalse.TabIndex = 3;
            this.btnMoveFactWithFalse.Text = "F";
            this.btnMoveFactWithFalse.UseVisualStyleBackColor = true;
            this.btnMoveFactWithFalse.Click += new System.EventHandler(this.btnMoveFactWithFalse_Click);
            // 
            // btnMoveFactWithTrue
            // 
            this.btnMoveFactWithTrue.Location = new System.Drawing.Point(172, 121);
            this.btnMoveFactWithTrue.Name = "btnMoveFactWithTrue";
            this.btnMoveFactWithTrue.Size = new System.Drawing.Size(21, 23);
            this.btnMoveFactWithTrue.TabIndex = 2;
            this.btnMoveFactWithTrue.Text = "P";
            this.btnMoveFactWithTrue.UseVisualStyleBackColor = true;
            this.btnMoveFactWithTrue.Click += new System.EventHandler(this.btnMoveFactWithTrue_Click);
            // 
            // lbAllFacts
            // 
            this.lbAllFacts.FormattingEnabled = true;
            this.lbAllFacts.Location = new System.Drawing.Point(10, 121);
            this.lbAllFacts.Name = "lbAllFacts";
            this.lbAllFacts.Size = new System.Drawing.Size(156, 95);
            this.lbAllFacts.TabIndex = 1;
            // 
            // gbFacts
            // 
            this.gbFacts.Controls.Add(this.lblFactRule);
            this.gbFacts.Controls.Add(this.label3);
            this.gbFacts.Controls.Add(this.label2);
            this.gbFacts.Controls.Add(this.btnEditFact);
            this.gbFacts.Controls.Add(this.btnRemoveFact);
            this.gbFacts.Controls.Add(this.cbFacts);
            this.gbFacts.Controls.Add(this.btnAddFact);
            this.gbFacts.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFacts.Location = new System.Drawing.Point(0, 0);
            this.gbFacts.Name = "gbFacts";
            this.gbFacts.Size = new System.Drawing.Size(358, 115);
            this.gbFacts.TabIndex = 0;
            this.gbFacts.TabStop = false;
            this.gbFacts.Text = "Fakty";
            // 
            // lblFactRule
            // 
            this.lblFactRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFactRule.AutoSize = true;
            this.lblFactRule.Location = new System.Drawing.Point(54, 87);
            this.lblFactRule.Name = "lblFactRule";
            this.lblFactRule.Size = new System.Drawing.Size(39, 13);
            this.lblFactRule.TabIndex = 8;
            this.lblFactRule.Text = "BRAK!";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Reguła: ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fakty:";
            // 
            // btnEditFact
            // 
            this.btnEditFact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditFact.Location = new System.Drawing.Point(68, 61);
            this.btnEditFact.Name = "btnEditFact";
            this.btnEditFact.Size = new System.Drawing.Size(52, 23);
            this.btnEditFact.TabIndex = 4;
            this.btnEditFact.Text = "&Edytuj";
            this.btnEditFact.UseVisualStyleBackColor = true;
            this.btnEditFact.Click += new System.EventHandler(this.btnEditFact_Click);
            // 
            // btnRemoveFact
            // 
            this.btnRemoveFact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveFact.Location = new System.Drawing.Point(126, 61);
            this.btnRemoveFact.Name = "btnRemoveFact";
            this.btnRemoveFact.Size = new System.Drawing.Size(52, 23);
            this.btnRemoveFact.TabIndex = 3;
            this.btnRemoveFact.Text = "&Usuń";
            this.btnRemoveFact.UseVisualStyleBackColor = true;
            this.btnRemoveFact.Click += new System.EventHandler(this.btnRemoveFact_Click);
            // 
            // cbFacts
            // 
            this.cbFacts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFacts.FormattingEnabled = true;
            this.cbFacts.Location = new System.Drawing.Point(10, 34);
            this.cbFacts.Name = "cbFacts";
            this.cbFacts.Size = new System.Drawing.Size(168, 21);
            this.cbFacts.TabIndex = 2;
            this.cbFacts.SelectedIndexChanged += new System.EventHandler(this.cbFacts_SelectedIndexChanged);
            // 
            // btnAddFact
            // 
            this.btnAddFact.Location = new System.Drawing.Point(10, 61);
            this.btnAddFact.Name = "btnAddFact";
            this.btnAddFact.Size = new System.Drawing.Size(52, 23);
            this.btnAddFact.TabIndex = 1;
            this.btnAddFact.Text = "&Dodaj";
            this.btnAddFact.UseVisualStyleBackColor = true;
            this.btnAddFact.Click += new System.EventHandler(this.btnAddFact_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(310, 391);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "&Start!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // endOfInferencingLbl
            // 
            this.endOfInferencingLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.endOfInferencingLbl.AutoSize = true;
            this.endOfInferencingLbl.Location = new System.Drawing.Point(167, 396);
            this.endOfInferencingLbl.Name = "endOfInferencingLbl";
            this.endOfInferencingLbl.Size = new System.Drawing.Size(137, 13);
            this.endOfInferencingLbl.TabIndex = 2;
            this.endOfInferencingLbl.Text = "Zakończono wnioskowanie";
            this.endOfInferencingLbl.Visible = false;
            // 
            // btnDeleteRule
            // 
            this.btnDeleteRule.Location = new System.Drawing.Point(127, 61);
            this.btnDeleteRule.Name = "btnDeleteRule";
            this.btnDeleteRule.Size = new System.Drawing.Size(51, 23);
            this.btnDeleteRule.TabIndex = 15;
            this.btnDeleteRule.Text = "&Usuń";
            this.btnDeleteRule.UseVisualStyleBackColor = true;
            this.btnDeleteRule.Click += new System.EventHandler(this.btnDeleteRule_Click);
            // 
            // clbRuleArguments
            // 
            this.clbRuleArguments.FormattingEnabled = true;
            this.clbRuleArguments.Location = new System.Drawing.Point(199, 121);
            this.clbRuleArguments.Name = "clbRuleArguments";
            this.clbRuleArguments.Size = new System.Drawing.Size(153, 94);
            this.clbRuleArguments.TabIndex = 16;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 426);
            this.Controls.Add(this.endOfInferencingLbl);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tabControl);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "System ekspercki";
            this.tabControl.ResumeLayout(false);
            this.inferenceModuleTabPage.ResumeLayout(false);
            this.revisionInferenceTabPage.ResumeLayout(false);
            this.knowlegdeEditorTabPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbFacts.ResumeLayout(false);
            this.gbFacts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage inferenceModuleTabPage;
        private System.Windows.Forms.TabPage revisionInferenceTabPage;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TableLayoutPanel inferenceModulePanel;
        private System.Windows.Forms.RichTextBox inferenceRevisionRtb;
        private System.Windows.Forms.Label endOfInferencingLbl;
        private System.Windows.Forms.TabPage knowlegdeEditorTabPage;
        private System.Windows.Forms.GroupBox gbFacts;
        private System.Windows.Forms.Button btnEditFact;
        private System.Windows.Forms.Button btnRemoveFact;
        private System.Windows.Forms.ComboBox cbFacts;
        private System.Windows.Forms.Button btnAddFact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFactRule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditRule;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.ComboBox cbRules;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbRuleCreatingFact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbQuestionContent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemoveFactFromRuleArgs;
        private System.Windows.Forms.Button btnMoveFactWithFalse;
        private System.Windows.Forms.Button btnMoveFactWithTrue;
        private System.Windows.Forms.ListBox lbAllFacts;
        private System.Windows.Forms.Button btnDeleteRule;
        private System.Windows.Forms.CheckedListBox clbRuleArguments;
    }
}


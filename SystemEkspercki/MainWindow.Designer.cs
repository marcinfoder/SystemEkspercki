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
            this.gbFacts = new System.Windows.Forms.GroupBox();
            this.lblFactRule = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditFact = new System.Windows.Forms.Button();
            this.btnRemoveFact = new System.Windows.Forms.Button();
            this.cbFacts = new System.Windows.Forms.ComboBox();
            this.btnAddFact = new System.Windows.Forms.Button();
            this.tbNewFact = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.endOfInferencingLbl = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 222);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reguły";
            // 
            // gbFacts
            // 
            this.gbFacts.Controls.Add(this.lblFactRule);
            this.gbFacts.Controls.Add(this.label3);
            this.gbFacts.Controls.Add(this.label2);
            this.gbFacts.Controls.Add(this.label1);
            this.gbFacts.Controls.Add(this.btnEditFact);
            this.gbFacts.Controls.Add(this.btnRemoveFact);
            this.gbFacts.Controls.Add(this.cbFacts);
            this.gbFacts.Controls.Add(this.btnAddFact);
            this.gbFacts.Controls.Add(this.tbNewFact);
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
            this.lblFactRule.Location = new System.Drawing.Point(239, 91);
            this.lblFactRule.Name = "lblFactRule";
            this.lblFactRule.Size = new System.Drawing.Size(39, 13);
            this.lblFactRule.TabIndex = 8;
            this.lblFactRule.Text = "BRAK!";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Reguła: ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Zmień istniejący...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dodaj nowy...";
            // 
            // btnEditFact
            // 
            this.btnEditFact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditFact.Location = new System.Drawing.Point(196, 61);
            this.btnEditFact.Name = "btnEditFact";
            this.btnEditFact.Size = new System.Drawing.Size(75, 23);
            this.btnEditFact.TabIndex = 4;
            this.btnEditFact.Text = "&Edytuj";
            this.btnEditFact.UseVisualStyleBackColor = true;
            this.btnEditFact.Click += new System.EventHandler(this.btnEditFact_Click);
            // 
            // btnRemoveFact
            // 
            this.btnRemoveFact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveFact.Location = new System.Drawing.Point(277, 61);
            this.btnRemoveFact.Name = "btnRemoveFact";
            this.btnRemoveFact.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFact.TabIndex = 3;
            this.btnRemoveFact.Text = "&Usuń";
            this.btnRemoveFact.UseVisualStyleBackColor = true;
            this.btnRemoveFact.Click += new System.EventHandler(this.btnRemoveFact_Click);
            // 
            // cbFacts
            // 
            this.cbFacts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFacts.FormattingEnabled = true;
            this.cbFacts.Location = new System.Drawing.Point(196, 34);
            this.cbFacts.Name = "cbFacts";
            this.cbFacts.Size = new System.Drawing.Size(156, 21);
            this.cbFacts.TabIndex = 2;
            this.cbFacts.SelectedIndexChanged += new System.EventHandler(this.cbFacts_SelectedIndexChanged);
            // 
            // btnAddFact
            // 
            this.btnAddFact.Location = new System.Drawing.Point(10, 61);
            this.btnAddFact.Name = "btnAddFact";
            this.btnAddFact.Size = new System.Drawing.Size(75, 23);
            this.btnAddFact.TabIndex = 1;
            this.btnAddFact.Text = "&Dodaj";
            this.btnAddFact.UseVisualStyleBackColor = true;
            this.btnAddFact.Click += new System.EventHandler(this.btnAddFact_Click);
            // 
            // tbNewFact
            // 
            this.tbNewFact.Location = new System.Drawing.Point(10, 35);
            this.tbNewFact.Name = "tbNewFact";
            this.tbNewFact.Size = new System.Drawing.Size(156, 20);
            this.tbNewFact.TabIndex = 0;
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(199, 121);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 95);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(10, 121);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(156, 95);
            this.listBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "P";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "F";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(172, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = true;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Argumenty:";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 8;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(199, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 21);
            this.comboBox1.TabIndex = 10;
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(10, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(156, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(10, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Zapisz";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(91, 61);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Usuń";
            this.button5.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.TextBox tbNewFact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFactRule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
    }
}


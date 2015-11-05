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
            this.btnStart = new System.Windows.Forms.Button();
            this.inferenceRevisionRtb = new System.Windows.Forms.RichTextBox();
            this.tabControl.SuspendLayout();
            this.inferenceModuleTabPage.SuspendLayout();
            this.revisionInferenceTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.inferenceModuleTabPage);
            this.tabControl.Controls.Add(this.revisionInferenceTabPage);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(403, 372);
            this.tabControl.TabIndex = 0;
            // 
            // inferenceModuleTabPage
            // 
            this.inferenceModuleTabPage.AutoScroll = true;
            this.inferenceModuleTabPage.Controls.Add(this.inferenceModulePanel);
            this.inferenceModuleTabPage.Location = new System.Drawing.Point(4, 22);
            this.inferenceModuleTabPage.Name = "inferenceModuleTabPage";
            this.inferenceModuleTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.inferenceModuleTabPage.Size = new System.Drawing.Size(395, 346);
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
            this.inferenceModulePanel.Size = new System.Drawing.Size(389, 340);
            this.inferenceModulePanel.TabIndex = 0;
            // 
            // revisionInferenceTabPage
            // 
            this.revisionInferenceTabPage.Controls.Add(this.inferenceRevisionRtb);
            this.revisionInferenceTabPage.Location = new System.Drawing.Point(4, 22);
            this.revisionInferenceTabPage.Name = "revisionInferenceTabPage";
            this.revisionInferenceTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.revisionInferenceTabPage.Size = new System.Drawing.Size(395, 346);
            this.revisionInferenceTabPage.TabIndex = 1;
            this.revisionInferenceTabPage.Text = "Rewizja wnioskowania";
            this.revisionInferenceTabPage.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(341, 391);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "&Start!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
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
            this.inferenceRevisionRtb.Size = new System.Drawing.Size(389, 340);
            this.inferenceRevisionRtb.TabIndex = 0;
            this.inferenceRevisionRtb.Text = "";
            this.inferenceRevisionRtb.WordWrap = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 426);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tabControl);
            this.Name = "MainWindow";
            this.Text = "System ekspercki";
            this.tabControl.ResumeLayout(false);
            this.inferenceModuleTabPage.ResumeLayout(false);
            this.revisionInferenceTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage inferenceModuleTabPage;
        private System.Windows.Forms.TabPage revisionInferenceTabPage;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TableLayoutPanel inferenceModulePanel;
        private System.Windows.Forms.RichTextBox inferenceRevisionRtb;
    }
}


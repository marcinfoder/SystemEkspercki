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
            this.inferenceModule = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnStart = new System.Windows.Forms.Button();
            this.inferenceModulePanel = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl.SuspendLayout();
            this.inferenceModule.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.inferenceModule);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(259, 208);
            this.tabControl.TabIndex = 0;
            // 
            // inferenceModule
            // 
            this.inferenceModule.AutoScroll = true;
            this.inferenceModule.Controls.Add(this.inferenceModulePanel);
            this.inferenceModule.Location = new System.Drawing.Point(4, 22);
            this.inferenceModule.Name = "inferenceModule";
            this.inferenceModule.Padding = new System.Windows.Forms.Padding(3);
            this.inferenceModule.Size = new System.Drawing.Size(251, 182);
            this.inferenceModule.TabIndex = 0;
            this.inferenceModule.Text = "Pytania";
            this.inferenceModule.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(251, 182);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(197, 227);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = true;
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
            this.inferenceModulePanel.Size = new System.Drawing.Size(245, 176);
            this.inferenceModulePanel.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tabControl);
            this.Name = "MainWindow";
            this.Text = "System ekspercki";
            this.tabControl.ResumeLayout(false);
            this.inferenceModule.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage inferenceModule;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TableLayoutPanel inferenceModulePanel;
    }
}


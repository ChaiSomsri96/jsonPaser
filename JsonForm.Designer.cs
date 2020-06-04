using Alex75.JsonViewer.WindowsForm;

namespace JsonViewer
{
    partial class JsonForm
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
            this.components = new System.ComponentModel.Container();
            this.splitControl = new System.Windows.Forms.SplitContainer();
            this.tblPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTest = new System.Windows.Forms.Button();
            this.jsonPanel = new System.Windows.Forms.Panel();
            this.jsonTreeView = new Alex75.JsonViewer.WindowsForm.JsonTreeView();
            this.optionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitControl)).BeginInit();
            this.splitControl.Panel1.SuspendLayout();
            this.splitControl.Panel2.SuspendLayout();
            this.splitControl.SuspendLayout();
            this.tblPanel1.SuspendLayout();
            this.jsonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitControl
            // 
            this.splitControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitControl.Location = new System.Drawing.Point(0, 0);
            this.splitControl.Name = "splitControl";
            // 
            // splitControl.Panel1
            // 
            this.splitControl.Panel1.Controls.Add(this.tblPanel1);
            // 
            // splitControl.Panel2
            // 
            this.splitControl.Panel2.Controls.Add(this.jsonPanel);
            this.splitControl.Size = new System.Drawing.Size(1016, 675);
            this.splitControl.SplitterDistance = 338;
            this.splitControl.TabIndex = 0;
            // 
            // tblPanel1
            // 
            this.tblPanel1.ColumnCount = 1;
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel1.Controls.Add(this.btnTest, 0, 1);
            this.tblPanel1.Controls.Add(this.optionsPanel, 0, 0);
            this.tblPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanel1.Location = new System.Drawing.Point(0, 0);
            this.tblPanel1.Name = "tblPanel1";
            this.tblPanel1.RowCount = 2;
            this.tblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.88889F));
            this.tblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.111111F));
            this.tblPanel1.Size = new System.Drawing.Size(338, 675);
            this.tblPanel1.TabIndex = 0;
            // 
            // btnTest
            // 
            this.btnTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTest.Location = new System.Drawing.Point(3, 629);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(332, 43);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // jsonPanel
            // 
            this.jsonPanel.BackColor = System.Drawing.Color.White;
            this.jsonPanel.Controls.Add(this.jsonTreeView);
            this.jsonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jsonPanel.Location = new System.Drawing.Point(0, 0);
            this.jsonPanel.Name = "jsonPanel";
            this.jsonPanel.Size = new System.Drawing.Size(674, 675);
            this.jsonPanel.TabIndex = 0;
            // 
            // jsonTreeView
            // 
            this.jsonTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jsonTreeView.ImageIndex = 0;
            this.jsonTreeView.Location = new System.Drawing.Point(0, 0);
            this.jsonTreeView.Name = "jsonTreeView";
            this.jsonTreeView.SelectedImageIndex = 0;
            this.jsonTreeView.Size = new System.Drawing.Size(674, 675);
            this.jsonTreeView.TabIndex = 0;
            // 
            // optionsPanel
            // 
            this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsPanel.Location = new System.Drawing.Point(3, 3);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Padding = new System.Windows.Forms.Padding(20);
            this.optionsPanel.Size = new System.Drawing.Size(332, 620);
            this.optionsPanel.TabIndex = 1;
            // 
            // JsonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 675);
            this.Controls.Add(this.splitControl);
            this.Name = "JsonForm";
            this.Text = "API Tester";
            this.splitControl.Panel1.ResumeLayout(false);
            this.splitControl.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitControl)).EndInit();
            this.splitControl.ResumeLayout(false);
            this.tblPanel1.ResumeLayout(false);
            this.jsonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitControl;
        private System.Windows.Forms.TableLayoutPanel tblPanel1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Panel jsonPanel;

        private JsonTreeView jsonTreeView;
        private System.Windows.Forms.FlowLayoutPanel optionsPanel;
    }
}


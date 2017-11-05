namespace AddEventsToCalendar
{
  partial class MainForm
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.progStatus = new System.Windows.Forms.ProgressBar();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.label1 = new System.Windows.Forms.Label();
      this.treeEvents = new System.Windows.Forms.TreeView();
      this.label2 = new System.Windows.Forms.Label();
      this.tpnlCurrentEvent = new System.Windows.Forms.TableLayoutPanel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.lblNoSettings = new System.Windows.Forms.Label();
      this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
      this.btnCreate = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.tpnlCurrentEvent.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.progStatus, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(667, 414);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // progStatus
      // 
      this.progStatus.Dock = System.Windows.Forms.DockStyle.Fill;
      this.progStatus.Location = new System.Drawing.Point(3, 388);
      this.progStatus.Name = "progStatus";
      this.progStatus.Size = new System.Drawing.Size(661, 23);
      this.progStatus.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
      this.progStatus.TabIndex = 0;
      // 
      // splitContainer1
      // 
      this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlDark;
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(3, 3);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.treeEvents);
      this.splitContainer1.Panel1.Controls.Add(this.label1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.tpnlCurrentEvent);
      this.splitContainer1.Panel2.Controls.Add(this.label2);
      this.splitContainer1.Size = new System.Drawing.Size(661, 379);
      this.splitContainer1.SplitterDistance = 257;
      this.splitContainer1.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.SystemColors.Control;
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(257, 23);
      this.label1.TabIndex = 0;
      this.label1.Text = "Type of event to create";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // treeEvents
      // 
      this.treeEvents.Dock = System.Windows.Forms.DockStyle.Fill;
      this.treeEvents.FullRowSelect = true;
      this.treeEvents.HideSelection = false;
      this.treeEvents.Location = new System.Drawing.Point(0, 23);
      this.treeEvents.Name = "treeEvents";
      this.treeEvents.ShowLines = false;
      this.treeEvents.ShowNodeToolTips = true;
      this.treeEvents.ShowPlusMinus = false;
      this.treeEvents.ShowRootLines = false;
      this.treeEvents.Size = new System.Drawing.Size(257, 356);
      this.treeEvents.TabIndex = 1;
      this.treeEvents.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeEvents_AfterSelect);
      // 
      // label2
      // 
      this.label2.BackColor = System.Drawing.SystemColors.Control;
      this.label2.Dock = System.Windows.Forms.DockStyle.Top;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(0, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(400, 23);
      this.label2.TabIndex = 1;
      this.label2.Text = "Settings for Event";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tpnlCurrentEvent
      // 
      this.tpnlCurrentEvent.BackColor = System.Drawing.SystemColors.Control;
      this.tpnlCurrentEvent.ColumnCount = 1;
      this.tpnlCurrentEvent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tpnlCurrentEvent.Controls.Add(this.panel1, 0, 0);
      this.tpnlCurrentEvent.Controls.Add(this.btnCreate, 0, 1);
      this.tpnlCurrentEvent.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tpnlCurrentEvent.Location = new System.Drawing.Point(0, 23);
      this.tpnlCurrentEvent.Name = "tpnlCurrentEvent";
      this.tpnlCurrentEvent.RowCount = 2;
      this.tpnlCurrentEvent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tpnlCurrentEvent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tpnlCurrentEvent.Size = new System.Drawing.Size(400, 356);
      this.tpnlCurrentEvent.TabIndex = 2;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.lblNoSettings);
      this.panel1.Controls.Add(this.propertyGrid1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(400, 326);
      this.panel1.TabIndex = 0;
      // 
      // lblNoSettings
      // 
      this.lblNoSettings.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblNoSettings.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNoSettings.Location = new System.Drawing.Point(0, 0);
      this.lblNoSettings.Name = "lblNoSettings";
      this.lblNoSettings.Size = new System.Drawing.Size(400, 326);
      this.lblNoSettings.TabIndex = 0;
      this.lblNoSettings.Text = "This event does not have any settings. Just click the Create button.";
      this.lblNoSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // propertyGrid1
      // 
      this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.propertyGrid1.LineColor = System.Drawing.SystemColors.ControlDark;
      this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
      this.propertyGrid1.Name = "propertyGrid1";
      this.propertyGrid1.Size = new System.Drawing.Size(400, 326);
      this.propertyGrid1.TabIndex = 1;
      // 
      // btnCreate
      // 
      this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.btnCreate.Location = new System.Drawing.Point(323, 329);
      this.btnCreate.Name = "btnCreate";
      this.btnCreate.Size = new System.Drawing.Size(74, 24);
      this.btnCreate.TabIndex = 1;
      this.btnCreate.Text = "Create";
      this.btnCreate.UseVisualStyleBackColor = true;
      this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(687, 434);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "MainForm";
      this.Padding = new System.Windows.Forms.Padding(10);
      this.Text = "Form1";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.tpnlCurrentEvent.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.ProgressBar progStatus;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.TreeView treeEvents;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TableLayoutPanel tpnlCurrentEvent;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label lblNoSettings;
    private System.Windows.Forms.PropertyGrid propertyGrid1;
    private System.Windows.Forms.Button btnCreate;
  }
}


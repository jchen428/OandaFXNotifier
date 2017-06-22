namespace WindowsForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioBid = new System.Windows.Forms.RadioButton();
            this.radioAsk = new System.Windows.Forms.RadioButton();
            this.panel = new System.Windows.Forms.Panel();
            this.comboBoxInstruments = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelInvalid = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelInfo, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 211);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox
            // 
            this.groupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox.Controls.Add(this.radioBid);
            this.groupBox.Controls.Add(this.radioAsk);
            this.groupBox.Location = new System.Drawing.Point(20, 38);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(101, 71);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Ask/Bid";
            // 
            // radioBid
            // 
            this.radioBid.AutoSize = true;
            this.radioBid.Location = new System.Drawing.Point(9, 42);
            this.radioBid.Name = "radioBid";
            this.radioBid.Size = new System.Drawing.Size(40, 17);
            this.radioBid.TabIndex = 1;
            this.radioBid.TabStop = true;
            this.radioBid.Text = "Bid";
            this.radioBid.UseVisualStyleBackColor = true;
            this.radioBid.CheckedChanged += new System.EventHandler(this.radioCheckedChanged);
            // 
            // radioAsk
            // 
            this.radioAsk.AutoSize = true;
            this.radioAsk.Location = new System.Drawing.Point(9, 19);
            this.radioAsk.Name = "radioAsk";
            this.radioAsk.Size = new System.Drawing.Size(43, 17);
            this.radioAsk.TabIndex = 0;
            this.radioAsk.TabStop = true;
            this.radioAsk.Text = "Ask";
            this.radioAsk.UseVisualStyleBackColor = true;
            this.radioAsk.CheckedChanged += new System.EventHandler(this.radioCheckedChanged);
            // 
            // panel
            // 
            this.panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel.Controls.Add(this.comboBoxInstruments);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.labelInvalid);
            this.panel.Controls.Add(this.textBoxPrice);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(145, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(136, 141);
            this.panel.TabIndex = 1;
            // 
            // comboBoxInstruments
            // 
            this.comboBoxInstruments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInstruments.FormattingEnabled = true;
            this.comboBoxInstruments.Location = new System.Drawing.Point(7, 98);
            this.comboBoxInstruments.Name = "comboBoxInstruments";
            this.comboBoxInstruments.Size = new System.Drawing.Size(121, 21);
            this.comboBoxInstruments.TabIndex = 4;
            this.comboBoxInstruments.SelectionChangeCommitted += new System.EventHandler(this.comboBoxInstruments_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Instrument";
            // 
            // labelInvalid
            // 
            this.labelInvalid.AutoSize = true;
            this.labelInvalid.ForeColor = System.Drawing.Color.Red;
            this.labelInvalid.Location = new System.Drawing.Point(7, 57);
            this.labelInvalid.Name = "labelInvalid";
            this.labelInvalid.Size = new System.Drawing.Size(123, 13);
            this.labelInvalid.TabIndex = 2;
            this.labelInvalid.Text = "Must be a numeric value";
            this.labelInvalid.Visible = false;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(7, 34);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price";
            // 
            // button
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.button, 2);
            this.button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button.Location = new System.Drawing.Point(3, 181);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(278, 27);
            this.button.TabIndex = 2;
            this.button.Text = "Enable";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelInfo, 2);
            this.labelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInfo.Location = new System.Drawing.Point(3, 147);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(278, 31);
            this.labelInfo.TabIndex = 3;
            this.labelInfo.Text = "Notifications are disabled";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 250);
            this.Name = "Form1";
            this.Text = "OandaFX Notifier";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton radioBid;
        private System.Windows.Forms.RadioButton radioAsk;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelInvalid;
        private System.Windows.Forms.ComboBox comboBoxInstruments;
        private System.Windows.Forms.Label label2;
    }
}


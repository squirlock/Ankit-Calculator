namespace CalculatorAPP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonValueDecimal = new System.Windows.Forms.Button();
            this.buttonValue0 = new System.Windows.Forms.Button();
            this.buttonValueEqualTo = new System.Windows.Forms.Button();
            this.buttonValueDiv = new System.Windows.Forms.Button();
            this.buttonValueMultiply = new System.Windows.Forms.Button();
            this.buttonValueSub = new System.Windows.Forms.Button();
            this.buttonValueAdd = new System.Windows.Forms.Button();
            this.buttonValueClear = new System.Windows.Forms.Button();
            this.buttonValueClearEntry = new System.Windows.Forms.Button();
            this.labelInputValue = new System.Windows.Forms.Label();
            this.buttonValue9 = new System.Windows.Forms.Button();
            this.buttonValue8 = new System.Windows.Forms.Button();
            this.buttonValue7 = new System.Windows.Forms.Button();
            this.buttonValue6 = new System.Windows.Forms.Button();
            this.buttonValue5 = new System.Windows.Forms.Button();
            this.buttonValue4 = new System.Windows.Forms.Button();
            this.buttonValue3 = new System.Windows.Forms.Button();
            this.buttonValue2 = new System.Windows.Forms.Button();
            this.buttonValue1 = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.File = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextFileStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripHelpItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextHelpStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripAboutAppItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAboutDevItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextFileStrip.SuspendLayout();
            this.contextHelpStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonValueDecimal
            // 
            this.buttonValueDecimal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonValueDecimal.Location = new System.Drawing.Point(172, 373);
            this.buttonValueDecimal.Name = "buttonValueDecimal";
            this.buttonValueDecimal.Size = new System.Drawing.Size(80, 63);
            this.buttonValueDecimal.TabIndex = 0;
            this.buttonValueDecimal.TabStop = false;
            this.buttonValueDecimal.Text = ".";
            this.buttonValueDecimal.UseVisualStyleBackColor = true;
            this.buttonValueDecimal.Click += new System.EventHandler(this.button_num_click);
            // 
            // buttonValue0
            // 
            this.buttonValue0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonValue0.Location = new System.Drawing.Point(12, 373);
            this.buttonValue0.Name = "buttonValue0";
            this.buttonValue0.Size = new System.Drawing.Size(160, 63);
            this.buttonValue0.TabIndex = 0;
            this.buttonValue0.TabStop = false;
            this.buttonValue0.Text = "0";
            this.buttonValue0.UseVisualStyleBackColor = true;
            this.buttonValue0.Click += new System.EventHandler(this.button_num_click);
            // 
            // buttonValueEqualTo
            // 
            this.buttonValueEqualTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonValueEqualTo.Location = new System.Drawing.Point(344, 306);
            this.buttonValueEqualTo.Name = "buttonValueEqualTo";
            this.buttonValueEqualTo.Size = new System.Drawing.Size(80, 132);
            this.buttonValueEqualTo.TabIndex = 0;
            this.buttonValueEqualTo.Text = "=";
            this.buttonValueEqualTo.UseVisualStyleBackColor = true;
            this.buttonValueEqualTo.Click += new System.EventHandler(this.EqualToOpr_click);
            // 
            // buttonValueDiv
            // 
            this.buttonValueDiv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonValueDiv.Location = new System.Drawing.Point(258, 168);
            this.buttonValueDiv.Name = "buttonValueDiv";
            this.buttonValueDiv.Size = new System.Drawing.Size(80, 63);
            this.buttonValueDiv.TabIndex = 1;
            this.buttonValueDiv.TabStop = false;
            this.buttonValueDiv.Text = "/";
            this.buttonValueDiv.UseVisualStyleBackColor = true;
            this.buttonValueDiv.Click += new System.EventHandler(this.opr_click);
            // 
            // buttonValueMultiply
            // 
            this.buttonValueMultiply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonValueMultiply.Location = new System.Drawing.Point(258, 237);
            this.buttonValueMultiply.Name = "buttonValueMultiply";
            this.buttonValueMultiply.Size = new System.Drawing.Size(80, 63);
            this.buttonValueMultiply.TabIndex = 1;
            this.buttonValueMultiply.TabStop = false;
            this.buttonValueMultiply.Text = "*";
            this.buttonValueMultiply.UseVisualStyleBackColor = true;
            this.buttonValueMultiply.Click += new System.EventHandler(this.opr_click);
            // 
            // buttonValueSub
            // 
            this.buttonValueSub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonValueSub.Location = new System.Drawing.Point(258, 306);
            this.buttonValueSub.Name = "buttonValueSub";
            this.buttonValueSub.Size = new System.Drawing.Size(80, 63);
            this.buttonValueSub.TabIndex = 1;
            this.buttonValueSub.TabStop = false;
            this.buttonValueSub.Text = "-";
            this.buttonValueSub.UseVisualStyleBackColor = true;
            this.buttonValueSub.Click += new System.EventHandler(this.opr_click);
            // 
            // buttonValueAdd
            // 
            this.buttonValueAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonValueAdd.Location = new System.Drawing.Point(258, 375);
            this.buttonValueAdd.Name = "buttonValueAdd";
            this.buttonValueAdd.Size = new System.Drawing.Size(80, 63);
            this.buttonValueAdd.TabIndex = 1;
            this.buttonValueAdd.TabStop = false;
            this.buttonValueAdd.Text = "+";
            this.buttonValueAdd.UseVisualStyleBackColor = true;
            this.buttonValueAdd.Click += new System.EventHandler(this.opr_click);
            // 
            // buttonValueClear
            // 
            this.buttonValueClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonValueClear.Location = new System.Drawing.Point(344, 237);
            this.buttonValueClear.Name = "buttonValueClear";
            this.buttonValueClear.Size = new System.Drawing.Size(80, 63);
            this.buttonValueClear.TabIndex = 1;
            this.buttonValueClear.TabStop = false;
            this.buttonValueClear.Text = "C";
            this.buttonValueClear.UseVisualStyleBackColor = true;
            this.buttonValueClear.Click += new System.EventHandler(this.buttonValueClear_Click);
            // 
            // buttonValueClearEntry
            // 
            this.buttonValueClearEntry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonValueClearEntry.Location = new System.Drawing.Point(344, 168);
            this.buttonValueClearEntry.Name = "buttonValueClearEntry";
            this.buttonValueClearEntry.Size = new System.Drawing.Size(80, 63);
            this.buttonValueClearEntry.TabIndex = 1;
            this.buttonValueClearEntry.TabStop = false;
            this.buttonValueClearEntry.Text = "CE";
            this.buttonValueClearEntry.UseVisualStyleBackColor = true;
            this.buttonValueClearEntry.Click += new System.EventHandler(this.buttonValueClearEntry_Click);
            // 
            // labelInputValue
            // 
            this.labelInputValue.AutoSize = true;
            this.labelInputValue.BackColor = System.Drawing.SystemColors.Window;
            this.labelInputValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInputValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelInputValue.Location = new System.Drawing.Point(12, 83);
            this.labelInputValue.Name = "labelInputValue";
            this.labelInputValue.Size = new System.Drawing.Size(0, 20);
            this.labelInputValue.TabIndex = 3;
            // 
            // buttonValue9
            // 
            this.buttonValue9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonValue9.Location = new System.Drawing.Point(172, 168);
            this.buttonValue9.Name = "buttonValue9";
            this.buttonValue9.Size = new System.Drawing.Size(80, 63);
            this.buttonValue9.TabIndex = 1;
            this.buttonValue9.TabStop = false;
            this.buttonValue9.Text = "9";
            this.buttonValue9.UseVisualStyleBackColor = true;
            this.buttonValue9.Click += new System.EventHandler(this.button_num_click);
            // 
            // buttonValue8
            // 
            this.buttonValue8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonValue8.Location = new System.Drawing.Point(92, 168);
            this.buttonValue8.Name = "buttonValue8";
            this.buttonValue8.Size = new System.Drawing.Size(80, 63);
            this.buttonValue8.TabIndex = 1;
            this.buttonValue8.TabStop = false;
            this.buttonValue8.Text = "8";
            this.buttonValue8.UseVisualStyleBackColor = true;
            this.buttonValue8.Click += new System.EventHandler(this.button_num_click);
            // 
            // buttonValue7
            // 
            this.buttonValue7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonValue7.Location = new System.Drawing.Point(12, 168);
            this.buttonValue7.Name = "buttonValue7";
            this.buttonValue7.Size = new System.Drawing.Size(80, 63);
            this.buttonValue7.TabIndex = 1;
            this.buttonValue7.TabStop = false;
            this.buttonValue7.Text = "7";
            this.buttonValue7.UseVisualStyleBackColor = true;
            this.buttonValue7.Click += new System.EventHandler(this.button_num_click);
            // 
            // buttonValue6
            // 
            this.buttonValue6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonValue6.Location = new System.Drawing.Point(172, 237);
            this.buttonValue6.Name = "buttonValue6";
            this.buttonValue6.Size = new System.Drawing.Size(80, 63);
            this.buttonValue6.TabIndex = 1;
            this.buttonValue6.TabStop = false;
            this.buttonValue6.Text = "6";
            this.buttonValue6.UseVisualStyleBackColor = true;
            this.buttonValue6.Click += new System.EventHandler(this.button_num_click);
            // 
            // buttonValue5
            // 
            this.buttonValue5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonValue5.Location = new System.Drawing.Point(92, 237);
            this.buttonValue5.Name = "buttonValue5";
            this.buttonValue5.Size = new System.Drawing.Size(80, 63);
            this.buttonValue5.TabIndex = 1;
            this.buttonValue5.TabStop = false;
            this.buttonValue5.Text = "5";
            this.buttonValue5.UseVisualStyleBackColor = true;
            this.buttonValue5.Click += new System.EventHandler(this.button_num_click);
            // 
            // buttonValue4
            // 
            this.buttonValue4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonValue4.Location = new System.Drawing.Point(12, 237);
            this.buttonValue4.Name = "buttonValue4";
            this.buttonValue4.Size = new System.Drawing.Size(80, 63);
            this.buttonValue4.TabIndex = 1;
            this.buttonValue4.TabStop = false;
            this.buttonValue4.Text = "4";
            this.buttonValue4.UseVisualStyleBackColor = true;
            this.buttonValue4.Click += new System.EventHandler(this.button_num_click);
            // 
            // buttonValue3
            // 
            this.buttonValue3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonValue3.Location = new System.Drawing.Point(172, 304);
            this.buttonValue3.Name = "buttonValue3";
            this.buttonValue3.Size = new System.Drawing.Size(80, 63);
            this.buttonValue3.TabIndex = 1;
            this.buttonValue3.TabStop = false;
            this.buttonValue3.Text = "3";
            this.buttonValue3.UseVisualStyleBackColor = true;
            this.buttonValue3.Click += new System.EventHandler(this.button_num_click);
            // 
            // buttonValue2
            // 
            this.buttonValue2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonValue2.Location = new System.Drawing.Point(92, 304);
            this.buttonValue2.Name = "buttonValue2";
            this.buttonValue2.Size = new System.Drawing.Size(80, 63);
            this.buttonValue2.TabIndex = 1;
            this.buttonValue2.TabStop = false;
            this.buttonValue2.Text = "2";
            this.buttonValue2.UseVisualStyleBackColor = true;
            this.buttonValue2.Click += new System.EventHandler(this.button_num_click);
            // 
            // buttonValue1
            // 
            this.buttonValue1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonValue1.Location = new System.Drawing.Point(12, 304);
            this.buttonValue1.Name = "buttonValue1";
            this.buttonValue1.Size = new System.Drawing.Size(80, 63);
            this.buttonValue1.TabIndex = 1;
            this.buttonValue1.TabStop = false;
            this.buttonValue1.Text = "1";
            this.buttonValue1.UseVisualStyleBackColor = true;
            this.buttonValue1.Click += new System.EventHandler(this.button_num_click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(11, 117);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(411, 27);
            this.textBoxResult.TabIndex = 4;
            this.textBoxResult.Text = "0";
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // File
            // 
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(121, 28);
            this.File.Text = "File";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFileItem,
            this.toolStripHelpItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripFileItem
            // 
            this.toolStripFileItem.DropDown = this.contextFileStrip;
            this.toolStripFileItem.Name = "toolStripFileItem";
            this.toolStripFileItem.Size = new System.Drawing.Size(46, 24);
            this.toolStripFileItem.Text = "&File";
            // 
            // contextFileStrip
            // 
            this.contextFileStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextFileStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripExitItem});
            this.contextFileStrip.Name = "contextFileStrip";
            this.contextFileStrip.OwnerItem = this.toolStripFileItem;
            this.contextFileStrip.Size = new System.Drawing.Size(103, 28);
            this.contextFileStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextFileStrip_ItemClicked);
            // 
            // toolStripExitItem
            // 
            this.toolStripExitItem.Name = "toolStripExitItem";
            this.toolStripExitItem.Size = new System.Drawing.Size(102, 24);
            this.toolStripExitItem.Text = "Exit";
            // 
            // toolStripHelpItem
            // 
            this.toolStripHelpItem.DropDown = this.contextHelpStrip;
            this.toolStripHelpItem.Name = "toolStripHelpItem";
            this.toolStripHelpItem.Size = new System.Drawing.Size(55, 24);
            this.toolStripHelpItem.Text = "Help";
            // 
            // contextHelpStrip
            // 
            this.contextHelpStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextHelpStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAboutAppItem,
            this.toolStripAboutDevItem});
            this.contextHelpStrip.Name = "contextHelpStrip";
            this.contextHelpStrip.OwnerItem = this.toolStripHelpItem;
            this.contextHelpStrip.Size = new System.Drawing.Size(193, 52);
            this.contextHelpStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextHelpStrip_ItemClicked);
            // 
            // toolStripAboutAppItem
            // 
            this.toolStripAboutAppItem.Name = "toolStripAboutAppItem";
            this.toolStripAboutAppItem.Size = new System.Drawing.Size(192, 24);
            this.toolStripAboutAppItem.Text = "About App";
            // 
            // toolStripAboutDevItem
            // 
            this.toolStripAboutDevItem.Name = "toolStripAboutDevItem";
            this.toolStripAboutDevItem.Size = new System.Drawing.Size(192, 24);
            this.toolStripAboutDevItem.Text = "About Developer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 445);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonValue1);
            this.Controls.Add(this.buttonValue2);
            this.Controls.Add(this.buttonValue3);
            this.Controls.Add(this.buttonValue4);
            this.Controls.Add(this.buttonValue5);
            this.Controls.Add(this.buttonValue6);
            this.Controls.Add(this.buttonValue7);
            this.Controls.Add(this.buttonValue8);
            this.Controls.Add(this.buttonValue9);
            this.Controls.Add(this.labelInputValue);
            this.Controls.Add(this.buttonValueClearEntry);
            this.Controls.Add(this.buttonValueClear);
            this.Controls.Add(this.buttonValueAdd);
            this.Controls.Add(this.buttonValueSub);
            this.Controls.Add(this.buttonValueMultiply);
            this.Controls.Add(this.buttonValueDiv);
            this.Controls.Add(this.buttonValueEqualTo);
            this.Controls.Add(this.buttonValue0);
            this.Controls.Add(this.buttonValueDecimal);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ankit\'s Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextFileStrip.ResumeLayout(false);
            this.contextHelpStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonValueDecimal;
        private System.Windows.Forms.Button buttonValue0;
        private System.Windows.Forms.Button buttonValueEqualTo;
        private System.Windows.Forms.Button buttonValueDiv;
        private System.Windows.Forms.Button buttonValueMultiply;
        private System.Windows.Forms.Button buttonValueSub;
        private System.Windows.Forms.Button buttonValueAdd;
        private System.Windows.Forms.Button buttonValueClear;
        private System.Windows.Forms.Button buttonValueClearEntry;
        private System.Windows.Forms.Label labelInputValue;
        private System.Windows.Forms.Button buttonValue9;
        private System.Windows.Forms.Button buttonValue8;
        private System.Windows.Forms.Button buttonValue7;
        private System.Windows.Forms.Button buttonValue6;
        private System.Windows.Forms.Button buttonValue5;
        private System.Windows.Forms.Button buttonValue4;
        private System.Windows.Forms.Button buttonValue3;
        private System.Windows.Forms.Button buttonValue2;
        private System.Windows.Forms.Button buttonValue1;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.ToolStripComboBox File;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripFileItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripHelpItem;
        private System.Windows.Forms.ContextMenuStrip contextFileStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripExitItem;
        private System.Windows.Forms.ContextMenuStrip contextHelpStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripAboutAppItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripAboutDevItem;
    }
}


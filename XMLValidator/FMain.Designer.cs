namespace XMLValidator
{
    partial class FMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.bFileXML = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.bValidate = new System.Windows.Forms.Button();
            this.ofdXml = new System.Windows.Forms.OpenFileDialog();
            this.schemaPathTextBox = new System.Windows.Forms.TextBox();
            this.bXMLSchema = new System.Windows.Forms.Button();
            this.ofdXsd = new System.Windows.Forms.OpenFileDialog();
            this.cbWarnings = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bFileXML
            // 
            this.bFileXML.Location = new System.Drawing.Point(315, 38);
            this.bFileXML.Name = "bFileXML";
            this.bFileXML.Size = new System.Drawing.Size(132, 23);
            this.bFileXML.TabIndex = 1;
            this.bFileXML.Text = "Choose XML file";
            this.bFileXML.UseVisualStyleBackColor = true;
            this.bFileXML.Click += new System.EventHandler(this.bFileXML_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(12, 12);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(435, 20);
            this.filePathTextBox.TabIndex = 0;
            // 
            // bValidate
            // 
            this.bValidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bValidate.Location = new System.Drawing.Point(12, 211);
            this.bValidate.Name = "bValidate";
            this.bValidate.Size = new System.Drawing.Size(435, 38);
            this.bValidate.TabIndex = 5;
            this.bValidate.Text = "Validate XML file";
            this.bValidate.UseVisualStyleBackColor = true;
            this.bValidate.Click += new System.EventHandler(this.bValidate_Click);
            // 
            // ofdXml
            // 
            this.ofdXml.Filter = "XML|*.xml";
            this.ofdXml.Title = "Choose the XML file to be validated";
            this.ofdXml.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdXml_FileOk);
            // 
            // schemaPathTextBox
            // 
            this.schemaPathTextBox.Location = new System.Drawing.Point(12, 90);
            this.schemaPathTextBox.Name = "schemaPathTextBox";
            this.schemaPathTextBox.Size = new System.Drawing.Size(435, 20);
            this.schemaPathTextBox.TabIndex = 2;
            // 
            // bXMLSchema
            // 
            this.bXMLSchema.Location = new System.Drawing.Point(315, 116);
            this.bXMLSchema.Name = "bXMLSchema";
            this.bXMLSchema.Size = new System.Drawing.Size(132, 23);
            this.bXMLSchema.TabIndex = 3;
            this.bXMLSchema.Text = "Choose XSD schema";
            this.bXMLSchema.UseVisualStyleBackColor = true;
            this.bXMLSchema.Click += new System.EventHandler(this.bXMLSchema_Click);
            // 
            // ofdXsd
            // 
            this.ofdXsd.FileName = "openFDschema";
            this.ofdXsd.Filter = "Schema XSD|*.xsd";
            this.ofdXsd.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdXsd_FileOk);
            // 
            // cbWarnings
            // 
            this.cbWarnings.AutoSize = true;
            this.cbWarnings.Location = new System.Drawing.Point(12, 144);
            this.cbWarnings.Name = "cbWarnings";
            this.cbWarnings.Size = new System.Drawing.Size(151, 17);
            this.cbWarnings.TabIndex = 4;
            this.cbWarnings.Text = "Report validation warnings";
            this.cbWarnings.UseVisualStyleBackColor = true;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 262);
            this.Controls.Add(this.cbWarnings);
            this.Controls.Add(this.schemaPathTextBox);
            this.Controls.Add(this.bXMLSchema);
            this.Controls.Add(this.bValidate);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.bFileXML);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(475, 300);
            this.MinimumSize = new System.Drawing.Size(475, 300);
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Button bFileXML;
        private System.Windows.Forms.Button bValidate;
        private System.Windows.Forms.OpenFileDialog ofdXml;
        private System.Windows.Forms.TextBox schemaPathTextBox;
        private System.Windows.Forms.Button bXMLSchema;
        private System.Windows.Forms.OpenFileDialog ofdXsd;
        private System.Windows.Forms.CheckBox cbWarnings;
    }
}


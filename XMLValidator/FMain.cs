using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;

/// <author>studio451.ru</author>
/// <email>info@studio451.ru</email>
/// <summary>
/// Validate xml with xsd-schema
/// </summary>
namespace XMLValidator
{
    public partial class FMain : Form
    {

        public FMain()
        {
            InitializeComponent();
        }

        private bool ValidateXmlWithXsd(string xmlUri, string xsdUri, bool warnings = false)
        {
            XmlSchema xmlSchema = XmlSchema.Read(XmlReader.Create(xsdUri), null);

            XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
            xmlReaderSettings.Schemas = new System.Xml.Schema.XmlSchemaSet();
            xmlReaderSettings.Schemas.Add(xmlSchema);
            xmlReaderSettings.ValidationType = ValidationType.Schema;
            if (warnings)
            {
                xmlReaderSettings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
            }
            try
            {
                XmlReader reader = XmlReader.Create(xmlUri, xmlReaderSettings);
                while (reader.Read()) ;
            }
            catch (XmlSchemaValidationException ex)
            {
                MessageBox.Show(ex.Message, this.Text);
                return false;
            }
            catch (XmlException ex)
            {
                MessageBox.Show(ex.Message, this.Text);
                return false;
            }

            return true;
        }

        private void bFileXML_Click(object sender, EventArgs e)
        {
            ofdXml.ShowDialog();
        }

        private void bXMLSchema_Click(object sender, EventArgs e)
        {
            ofdXsd.ShowDialog();
        }

        private void bValidate_Click(object sender, EventArgs e)
        {
            if (filePathTextBox.Text == "")
            {
                MessageBox.Show("Select an XML file!", this.Text);
            }
            else if (schemaPathTextBox.Text == "")
            {
                MessageBox.Show("Select a Schema file!", this.Text);
            }
            else
            {
                if (ValidateXmlWithXsd(filePathTextBox.Text, schemaPathTextBox.Text, cbWarnings.Checked))
                {
                    MessageBox.Show("Valid XML!", this.Text);
                }
                else
                {
                    MessageBox.Show("Not valid XML!", this.Text);
                }
            }
        }

        private void ofdXml_FileOk(object sender, CancelEventArgs e)
        {
            filePathTextBox.Text = ofdXml.FileName;
        }

        private void ofdXsd_FileOk(object sender, CancelEventArgs e)
        {
            schemaPathTextBox.Text = ofdXsd.FileName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DacFieldsGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var region = txtMember.Text.Replace("(", "").Replace(")", "").Replace(" ", "");
            var absClassName = region[0].ToString().ToLower() + region.Substring(1);

            var attributes = $"[PXUIField(DisplayName =  \"{region}\")]\r\n";
            if (txtUIField.Text != "")
            {
                attributes = $"[PXUIField(DisplayName = \"{txtUIField.Text}\")]\r\n";
            }

            string attrAdd = string.Empty;
            if (cmbType.SelectedItem.ToString() == "int?")
            {
                attrAdd = "[PXInt]";
            }
            if (cmbType.SelectedItem.ToString() == "string")
            {
                attrAdd = "[PXString]";
            }
            if (cmbType.SelectedItem.ToString() == "decimal?")
            {
                attrAdd = "[PXDecimal]";
            }
            if (cmbType.SelectedItem.ToString() == "DateTime?")
            {
                attrAdd = "[PXDate()]";
            }
            attributes = attributes + attrAdd;
            var memberName = region[0].ToString().ToUpper() + region.Substring(1);

            //var output = string.Format(template, region, absClassName, attributes); // , cmbType.SelectedItem.ToString(), memberName);
            
            var output = $"#region {region}\r\npublic abstract class {absClassName} :  PX.Data.IBqlField\r\n{{\r\n}}\r\n\r\n " +
                         $"{attributes} " +
                         $"\r\npublic virtual {cmbType.SelectedItem.ToString()} {memberName}\r\n{{\r\nget;\r\nset;\r\n}}\r\n#endregion";


            txtOutput.Text = txtOutput.Text + output;

        }
    }
}

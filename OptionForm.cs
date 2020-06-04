using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonViewer
{
    public partial class OptionForm : Form
    {
        public JsonSetting resultSetting { get; set; }
        public OptionForm(JsonSetting setting)
        {
            InitializeComponent();

            resultSetting = new JsonSetting();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            resultSetting.defaultname = inputName.Text;
            resultSetting.defaultaddress = inputAddress.Text;

            DialogResult = DialogResult.OK;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

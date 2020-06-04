using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Dynamic;

namespace JsonViewer
{
    public partial class JsonForm : Form
    {
        JsonSetting setting { get; set; }
        public JsonForm()
        {
            InitializeComponent();

            optionsPanel.FlowDirection = FlowDirection.TopDown;

            for (int i = 1; i <= 10; i++)
            {
                var optionCtrl = new RadioButton();
                optionCtrl.Text = $"Option {i}";

                optionsPanel.Controls.Add(optionCtrl);
            }

            optionsPanel.ResumeLayout();

            string json = null;
            using (var settingReader = new StreamReader(File.OpenRead("settings.json")))
            {
                json = settingReader.ReadToEnd();
                setting = JsonConvert.DeserializeObject<JsonSetting>(json);
            }

        }

        private void BuildJSON(string jsonString)
        {
            try
            {
                jsonTreeView.ShowJson(jsonString);
                jsonTreeView.ExpandAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Fail to show JSON. " + exc);
            }
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            var type = "";

            foreach (var optionCtrl in optionsPanel.Controls)
            {
                var selected = ((RadioButton)optionCtrl).Checked;
                if (selected)
                {
                    type = ((RadioButton)optionCtrl).Text;
                }
            }

            var optionDlg = new OptionForm(setting);
            if (optionDlg.ShowDialog() == DialogResult.OK)
            {
                var resultSetting = optionDlg.resultSetting;

                List<string> fields = new List<string>();

                dynamic result = new ExpandoObject();
                ((IDictionary<String, Object>)result).Add(setting.defaultname, resultSetting.defaultname);
                ((IDictionary<String, Object>)result).Add(setting.defaultaddress, resultSetting.defaultaddress);
                ((IDictionary<String, Object>)result).Add("type", type);

                dynamic item = new
                {
                    result = result
                };

                var jsonString = JsonConvert.SerializeObject(item);
                BuildJSON(jsonString);
            }
        }
    }
}

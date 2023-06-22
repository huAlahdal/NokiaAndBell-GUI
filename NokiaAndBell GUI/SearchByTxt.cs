using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NokiaAndBell_GUI.services;
using NokiaAndBell_GUI.models;
using System.Net;
using Nancy.Json;

namespace NokiaAndBell_GUI
{
    public partial class SearchByTxt : UserControl
    {
        string saveFileName = "";
        string openFileName = "";
        public SearchByTxt()
        {
            InitializeComponent();
            Dictionary<string, string> comboBox = new Dictionary<string, string>();
            comboBox.Add("mfgSerNo", "Mfg.Ser.No");
            comboBox.Add("office", "Office");
            comboBox.Add("mru", "MRU");
            comboBox.Add("installedMeterNumber", "In.Meter.No");
            comboBox.Add("cycle", "Cycle");
            comboBox.Add("premise", "Premise");
            comboBox1.DataSource = new BindingSource(comboBox, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
        }

        private void searchCheck2_CheckedChanged(object sender, EventArgs e)
        {
            if (searchCheck2.Checked)
            {
                subscriptionRadio2.Enabled = true;
                accountRadio2.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                subscriptionRadio2.Enabled = false;
                accountRadio2.Enabled = false;
                button3.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save a Txt File";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveFileName = saveFileDialog1.FileName;
                savefile.Text = saveFileDialog1.FileName;
                startbutton.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                openFileName = theDialog.FileName;
                openfile.Text = theDialog.FileName;
                var lines = File.ReadLines(openFileName);
                totaldata2.Text = lines.Count().ToString();
                button2.Enabled = true;
            }
        }

        private async void startbutton_Click(object sender, EventArgs e)
        {
            startbutton.Enabled = false;
            await generateKeys();
            startbutton.Enabled = true;
            MessageBox.Show("Done");
        }

        async Task generateKeys()
        {
            List<DataInfo> allData = new List<DataInfo>();
            var lines = File.ReadLines(openFileName);
            System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileName);

            int n = 0;
            var pick = ((KeyValuePair<string, string>)comboBox1.SelectedItem).Key;
            Response value = null;
            
        doAgain:  try
            {
                await Task.Run(() => Parallel.ForEach(lines, line =>
                {
                    n++;
                    switch (pick)
                    {
                        case "cycle":
                            value = httprequest2.GetToken(null, null, null, null, null, line, null, null, null, 1, 1);
                            break;
                        case "installedMeterNumber":
                            value = httprequest2.GetToken(null, null, null, null, null, null, line, null, null, 1, 1);
                            break;
                        case "mfgSerNo":
                            value = httprequest2.GetToken(null, null, null, line, null, null, null, null, null, 1, 1);
                            break;
                        case "mru":
                            value = httprequest2.GetToken(null, null, line, null, null, null, null, null, null, 1, 1);
                            break;
                        case "office":
                            value = httprequest2.GetToken(null, null, null, null, null, null, null, null, line, 1, 1);
                            break;
                        case "premise":
                            value = httprequest2.GetToken(null, null, null, null, null, null, null, line, null, 1, 1);
                            break;
                    }

                    var pages = (value.data.total / 10000) + 1;
                    Response checkdata = value;
                    /*for(int i = 0; i < pages; i++)
                    {
                        SearchTxt.run(line, pick, file, i+1);
                        file.Flush();
                        this.dataGridView1.Invoke(new Action(() => { this.dataGridView1.Rows.Add((i+1) + " of " + pages, line); }));
                    }*/
                    int i = 1;
                    while (checkdata.data.meterSurveyInstalls.Length != 0)
                    {

                        checkdata = SearchTxt.run(line, pick, file, i, 10000);
                        file.Flush();
                        this.dataGridView1.Invoke(new Action(() => { this.dataGridView1.Rows.Add((i) + " of " + pages, line); }));
                        i++;
                    }
                    
                    current.Invoke(new Action(() => { current.Text = n.ToString(); }));

                }));
            }
            catch
            {
                goto doAgain;
            }

            file.Close();
        }

    }
}

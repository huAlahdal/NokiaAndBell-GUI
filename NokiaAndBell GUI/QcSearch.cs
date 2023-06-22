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
using NokiaAndBell_GUI.models;
using NokiaAndBell_GUI.services;

namespace NokiaAndBell_GUI
{
    public partial class QcSearch : UserControl
    {
        string saveFileName = "";
        string openFileName = "";
        public QcSearch()
        {
            InitializeComponent();
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
            StreamWriter file = new StreamWriter(saveFileName);
            int n = 0;

            try
            {
                await Task.Run(() => Parallel.ForEach(lines, line =>
                {
                    n++;

                    var value = GetPremiseData.GetToken(line);
                    lock (file)
                    {
                        var QcLogs = "";
                        for (int i = 0; i < value.data.meterSurveyInstal.qcMeterLogs.Length; i++)
                        {
                            QcLogs += " { Date = " + value.data.meterSurveyInstal.qcMeterLogs[i].createdAt +
                                      " , Operationer ID = " + value.data.meterSurveyInstal.qcMeterLogs[i].accountId +
                                      " , Role = QC }";
                        }
                        file.WriteLine(
                        " ID : " + value.data.meterSurveyInstal.id +
                        " | Account ID : " + value.data.meterSurveyInstal.accountId +
                        " | Survey Status : " + value.data.meterSurveyInstal.surveyStatus +
                        " | Install Status : " + value.data.meterSurveyInstal.installStatus +
                        " | installedMeterNumber : " + value.data.meterSurveyInstal.installedMeterNumber +
                        " | premise : " + value.data.meterSurveyInstal.premise +
                        " | mru : " + value.data.meterSurveyInstal.mru +
                        " | office : " + value.data.meterSurveyInstal.office +
                        " | mfgSerNo : " + value.data.meterSurveyInstal.mfgSerNo +
                        " | subscriptionNo : " + value.data.meterSurveyInstal.subscriptionNo +
                        " | latitude : " + value.data.meterSurveyInstal.latitude +
                        " | longitude : " + value.data.meterSurveyInstal.longitude +
                        " | preMeterReadingT : " + value.data.meterSurveyInstal.preMeterReadingT +
                        " | refusalReasons : " + value.data.meterSurveyInstal.refusalReasons +
                        " | workerSubmitDate : " + value.data.meterSurveyInstal.workerSubmitDate +
                        " | updatedAt : " + value.data.meterSurveyInstal.updatedAt +
                        " | QC : " + QcLogs
                        );
                    }
                    file.Flush();
                    this.dataGridView1.Invoke(new Action(() => { this.dataGridView1.Rows.Add(line, "Done"); }));

                    current.Invoke(new Action(() => { current.Text = n.ToString(); }));


                }));
            }
            catch
            {
                
            }

            file.Close();
        }
    }
}

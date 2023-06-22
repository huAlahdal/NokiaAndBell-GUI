using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NokiaAndBell_GUI.services;
using NokiaAndBell_GUI.models;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace NokiaAndBell_GUI
{
    public partial class ManualSearch : UserControl
    {
        string openfileSearch = ""; 
        public ManualSearch()
        {

            InitializeComponent();
            var addStatus = new List<Status>();
            addStatus.Add(new Status { Text = "Survey Pending", Value = "1" });
            addStatus.Add(new Status { Text = "Survey Incident", Value = "2" });
            addStatus.Add(new Status { Text = "Survey Completed", Value = "3" });
            addStatus.Add(new Status { Text = "Survey Approved by QC", Value = "4" });
            addStatus.Add(new Status { Text = "Survey Reject by QC", Value = "5" });
            addStatus.Add(new Status { Text = "Installation Pending", Value = "6" });
            addStatus.Add(new Status { Text = "Installation Completed", Value = "7" });
            addStatus.Add(new Status { Text = "Installation Approved by QC", Value = "8" });
            addStatus.Add(new Status { Text = "Installation Rejected by QC", Value = "9" });
            status.DataSource = addStatus;
            status.DisplayMember = "Text";
            status.ValueMember = "Value";
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void savetoexcel_Click(object sender, EventArgs e)
        {
        }

        private void savetoexcel_Click_1(object sender, EventArgs e)
        {
            
            if (saveFileDialog1.FileName != "")
            {
                getdata.Enabled = true;
            }
        }

        private async void getdata_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save a Txt File";
            saveFileDialog1.ShowDialog();
            List<DataInfo> Alldata = new List<DataInfo>();
            string[] statusItems = null;
            var searchLines = new List<string>();
            if (status.CheckedItems.Count != 0)
            {
                int i = 0;
                statusItems = new string[status.CheckedItems.Count];
                foreach (object item in status.CheckedItems)
                {
                    statusItems[i] = (item as Status).Value;
                    i++;
                }
            }
            if (saveFileDialog1.FileName != "")
            {
                getdata.Enabled = false;
                var value = await httpRequest.Run(
                    dateFrom.Text == "" ? null : dateFrom.Text,
                    dateTo.Text == "" ? null : dateTo.Text,
                    mru.Text == "" ? null : mru.Text,
                    mfgSerNo.Text == "" ? null : mfgSerNo.Text,
                    statusItems,
                    cycle.Text == "" ? null : cycle.Text,
                    installedMeterNumber.Text == "" ? null : installedMeterNumber.Text,
                    premise.Text == "" ? null : premise.Text,
                    office.Text == "" ? null : office.Text,
                    10, 1);

                if (value == null) { return; }
                
                if (searchCheck.Checked && openfileSearch != "")
                {
                    var lines = File.ReadLines(openfileSearch);
                    foreach (var line in lines)
                    {
                        searchLines.Add(line);
                    }
                }
                int maxPage = (value.data.total / 10000) + 1;
                totaldata.Text = value.data.total.ToString();
                totalpages.Text = maxPage.ToString();
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                  
                    for (int i = 0; i < maxPage; i++)
                    {
                        doAgain: try
                        {
                            value = await httpRequest.Run(
                            dateFrom.Text == "" ? null : dateFrom.Text,
                            dateTo.Text == "" ? null : dateTo.Text,
                            mru.Text == "" ? null : mru.Text,
                            mfgSerNo.Text == "" ? null : mfgSerNo.Text,
                            statusItems,
                            cycle.Text == "" ? null : cycle.Text,
                            installedMeterNumber.Text == "" ? null : installedMeterNumber.Text,
                            premise.Text == "" ? null : premise.Text,
                            office.Text == "" ? null : office.Text,
                            10000, i + 1);

                            for (int n = 0; n < value.data.meterSurveyInstalls.Length; n++)
                            {
                                if (value.data.meterSurveyInstalls[n].surveyStatus == null) { value.data.meterSurveyInstalls[n].surveyStatus = 0; }
                                if (value.data.meterSurveyInstalls[n].installStatus == null) { value.data.meterSurveyInstalls[n].installStatus = 0; }
                                if (searchCheck.Checked)
                                {
                                    if (subscriptionRadio.Checked)
                                    {
                                        if (searchLines.Count > 0)
                                        {
                                            foreach (var line in searchLines.ToList())
                                            {

                                                if (value.data.meterSurveyInstalls[n].subscriptionNo == line)
                                                {
                                                        file.WriteLine(
                                                     " ID : " + value.data.meterSurveyInstalls[n].id +
                                                     " | Account ID : " + value.data.meterSurveyInstalls[n].accountId +
                                                     " | Survey Status : " + value.data.meterSurveyInstalls[n].surveyStatus +
                                                     " | Install Status : " + value.data.meterSurveyInstalls[n].installStatus +
                                                     " | installedMeterNumber : " + value.data.meterSurveyInstalls[n].installedMeterNumber +
                                                     " | premise : " + value.data.meterSurveyInstalls[n].premise +
                                                     " | mru : " + value.data.meterSurveyInstalls[n].mru +
                                                     " | office : " + value.data.meterSurveyInstalls[n].office +
                                                     " | mfgSerNo : " + value.data.meterSurveyInstalls[n].mfgSerNo +
                                                     " | subscriptionNo : " + value.data.meterSurveyInstalls[n].subscriptionNo +
                                                     " | latitude : " + value.data.meterSurveyInstalls[n].latitude +
                                                     " | longitude : " + value.data.meterSurveyInstalls[n].longitude +
                                                     " | preMeterReadingT : " + value.data.meterSurveyInstalls[n].preMeterReadingT +
                                                     " | refusalReasons : " + value.data.meterSurveyInstalls[n].refusalReasons +
                                                     " | workerSubmitDate : " + value.data.meterSurveyInstalls[n].workerSubmitDate + 
                                                     " | updatedAt : " + value.data.meterSurveyInstalls[n].updatedAt
                                                     );
                                                    file.Flush();
                                                    searchLines.Remove(line);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Done Searching");
                                            return;
                                        }

                                    }
                                    else
                                    {
                                        foreach (var line in searchLines.ToList())
                                        {
                                            if (value.data.meterSurveyInstalls[n].accountId == line)
                                            {
                                                file.WriteLine(
                                                 " ID : " + value.data.meterSurveyInstalls[n].id +
                                                 " | Account ID : " + value.data.meterSurveyInstalls[n].accountId +
                                                 " | Survey Status : " + value.data.meterSurveyInstalls[n].surveyStatus +
                                                 " | Install Status : " + value.data.meterSurveyInstalls[n].installStatus +
                                                 " | installedMeterNumber : " + value.data.meterSurveyInstalls[n].installedMeterNumber +
                                                 " | premise : " + value.data.meterSurveyInstalls[n].premise +
                                                 " | mru : " + value.data.meterSurveyInstalls[n].mru +
                                                 " | office : " + value.data.meterSurveyInstalls[n].office +
                                                 " | mfgSerNo : " + value.data.meterSurveyInstalls[n].mfgSerNo +
                                                 " | subscriptionNo : " + value.data.meterSurveyInstalls[n].subscriptionNo +
                                                 " | latitude : " + value.data.meterSurveyInstalls[n].latitude +
                                                 " | longitude : " + value.data.meterSurveyInstalls[n].longitude +
                                                 " | preMeterReadingT : " + value.data.meterSurveyInstalls[n].preMeterReadingT +
                                                 " | refusalReasons : " + value.data.meterSurveyInstalls[n].refusalReasons +
                                                 " | workerSubmitDate : " + value.data.meterSurveyInstalls[n].workerSubmitDate +
                                                 " | updatedAt : " + value.data.meterSurveyInstalls[n].updatedAt
                                                 );
                                                searchLines.Remove(line);
                                            }
                                        }
                                    }

                                }
                                else
                                {
                                    file.WriteLine(
                                    " ID : " + value.data.meterSurveyInstalls[n].id +
                                 //   " | Construction ID : " + value.data.meterSurveyInstalls[n].constructionId +
                                //    " | Construction Name : " + value.data.meterSurveyInstalls[n].constructionName +
                                //    " | Account Name : " + value.data.meterSurveyInstalls[n].accountName +
                                    " | Account ID : " + value.data.meterSurveyInstalls[n].accountId +
                                    " | Survey Status : " + value.data.meterSurveyInstalls[n].surveyStatus +
                                    " | Install Status : " + value.data.meterSurveyInstalls[n].installStatus +
                                 //   " | lastLongitude : " + value.data.meterSurveyInstalls[n].lastLongitude +
                                 //   " | lastLatitude : " + value.data.meterSurveyInstalls[n].lastLatitude +
                                 //   " | lastReviewTime : " + value.data.meterSurveyInstalls[n].lastReviewTime +
                                 //   " | lastReviewPerson : " + value.data.meterSurveyInstalls[n].lastReviewPerson +
                                 //   " | lastRejectReason : " + value.data.meterSurveyInstalls[n].lastRejectReason +
                                   // " | surveyPictureJson : " + value.data.meterSurveyInstalls[n].surveyPictureJson +
                                   // " | installPictureJson : " + value.data.meterSurveyInstalls[n].installPictureJson +
                                 //   " | insttalledBreakerCap : " + value.data.meterSurveyInstalls[n].insttalledBreakerCap +
                                    " | installedMeterNumber : " + value.data.meterSurveyInstalls[n].installedMeterNumber +
                                 //   " | installedMultFactor : " + value.data.meterSurveyInstalls[n].installedMultFactor +
                                 //   " | installedMeterType : " + value.data.meterSurveyInstalls[n].installedMeterType +
                                 //   " | replcamentIntegration : " + value.data.meterSurveyInstalls[n].replcamentIntegration +
                                //    " | disconnectionStatus : " + value.data.meterSurveyInstalls[n].disconnectionStatus +
                                //    " | surveyComments : " + value.data.meterSurveyInstalls[n].surveyComments +
                                //    " | installComments : " + value.data.meterSurveyInstalls[n].installComments +
                                //    " | qcRemarks : " + value.data.meterSurveyInstalls[n].qcRemarks +
                                //    " | incident : " + value.data.meterSurveyInstalls[n].incident +
                                //    " | ccneFlag : " + value.data.meterSurveyInstalls[n].ccneFlag +
                                //    " | isDamaged : " + value.data.meterSurveyInstalls[n].isDamaged +
                                //    " | newLongitude : " + value.data.meterSurveyInstalls[n].newLongitude +
                                //    " | newLatitude : " + value.data.meterSurveyInstalls[n].newLatitude +
                                    " | premise : " + value.data.meterSurveyInstalls[n].premise +
                                    " | mru : " + value.data.meterSurveyInstalls[n].mru +
                                    " | office : " + value.data.meterSurveyInstalls[n].office +
                                    " | mfgSerNo : " + value.data.meterSurveyInstalls[n].mfgSerNo +
                                //    " | meterType : " + value.data.meterSurveyInstalls[n].meterType +
                                //    " | equipNo : " + value.data.meterSurveyInstalls[n].equipNo +
                                //    " | cycle : " + value.data.meterSurveyInstalls[n].cycle +
                                //    " | lastBillKey : " + value.data.meterSurveyInstalls[n].lastBillKey +
                                //    " | routeReadSeq : " + value.data.meterSurveyInstalls[n].routeReadSeq +
                                //    " | mrNote : " + value.data.meterSurveyInstalls[n].mrNote +
                                //    " | dateMrNote : " + value.data.meterSurveyInstalls[n].dateMrNote +
                                //    " | criticalNeed : " + value.data.meterSurveyInstalls[n].criticalNeed +
                                //    " | serviceClass : " + value.data.meterSurveyInstalls[n].serviceClass +
                                //    " | premiseAddress : " + value.data.meterSurveyInstalls[n].premiseAddress +
                                //    " | city : " + value.data.meterSurveyInstalls[n].city +
                                //    " | district : " + value.data.meterSurveyInstalls[n].district +
                                    " | subscriptionNo : " + value.data.meterSurveyInstalls[n].subscriptionNo +
                                //    " | accountNo : " + value.data.meterSurveyInstalls[n].accountNo +
                                 //   " | bpName : " + value.data.meterSurveyInstalls[n].bpName +
                                //    " | bpType : " + value.data.meterSurveyInstalls[n].bpType +
                                    " | latitude : " + value.data.meterSurveyInstalls[n].latitude +
                                    " | longitude : " + value.data.meterSurveyInstalls[n].longitude +
                                //    " | multFactor : " + value.data.meterSurveyInstalls[n].multFactor +
                                //    " | noDials : " + value.data.meterSurveyInstalls[n].noDials +
                                 //   " | breakerCap : " + value.data.meterSurveyInstalls[n].breakerCap +
                                 //   " | voltage : " + value.data.meterSurveyInstalls[n].voltage +
                                 //   " | phase : " + value.data.meterSurveyInstalls[n].phase +
                                 //   " | tariffType : " + value.data.meterSurveyInstalls[n].tariffType +
                                 //   " | prevReadDateT : " + value.data.meterSurveyInstalls[n].prevReadDateT +
                                 //   " | prevReadT : " + value.data.meterSurveyInstalls[n].prevReadT +
                                 //   " | prevReadDateT1 : " + value.data.meterSurveyInstalls[n].prevReadDateT1 +
                                 //   " | prevReadT1 : " + value.data.meterSurveyInstalls[n].prevReadT1 +
                                 //   " | prevReadDateT2 : " + value.data.meterSurveyInstalls[n].prevReadDateT2 +
                                 //   " | prevReadT2 : " + value.data.meterSurveyInstalls[n].prevReadT2 +
                                //    " | prevReadDateT3 : " + value.data.meterSurveyInstalls[n].prevReadDateT3 +
                                 //   " | prevReadT3 : " + value.data.meterSurveyInstalls[n].prevReadT3 +
                                //    " | prevReadDateT4 : " + value.data.meterSurveyInstalls[n].prevReadDateT4 +
                                //    " | prevReadT4 : " + value.data.meterSurveyInstalls[n].prevReadT4 +
                                //    " | prevReadDateT5 : " + value.data.meterSurveyInstalls[n].prevReadDateT5 +
                                //    " | prevReadT5 : " + value.data.meterSurveyInstalls[n].prevReadT5 +
                                //    " | prevReadDateT6 : " + value.data.meterSurveyInstalls[n].prevReadDateT6 +
                                //    " | prevReadT6 : " + value.data.meterSurveyInstalls[n].prevReadT6 +
                                //    " | prevReadDateT7 : " + value.data.meterSurveyInstalls[n].prevReadDateT7 +
                                //    " | prevReadT7 : " + value.data.meterSurveyInstalls[n].prevReadT7 +
                                //    " | avgConspPerDay : " + value.data.meterSurveyInstalls[n].avgConspPerDay +
                                 //   " | acclPremiseNo : " + value.data.meterSurveyInstalls[n].acclPremiseNo +
                                 //   " | mainPremiseNo : " + value.data.meterSurveyInstalls[n].mainPremiseNo +
                                 //   " | connType : " + value.data.meterSurveyInstalls[n].connType +
                                    " | preMeterReadingT : " + value.data.meterSurveyInstalls[n].preMeterReadingT +
                                 //   " | prePostDecimalReadingT : " + value.data.meterSurveyInstalls[n].prePostDecimalReadingT +
                                 //   " | preMeterReadingT1 : " + value.data.meterSurveyInstalls[n].preMeterReadingT1 +
                                 //   " | preMeterReadingT2 : " + value.data.meterSurveyInstalls[n].preMeterReadingT2 +
                                //    " | preMeterReadingT3 : " + value.data.meterSurveyInstalls[n].preMeterReadingT3 +
                                //    " | preMeterReadingT4 : " + value.data.meterSurveyInstalls[n].preMeterReadingT4 +
                                //    " | preMeterReadingT5 : " + value.data.meterSurveyInstalls[n].preMeterReadingT5 +
                                //    " | preMeterReadingT6 : " + value.data.meterSurveyInstalls[n].preMeterReadingT6 +
                                //    " | preMeterReadingT7 : " + value.data.meterSurveyInstalls[n].preMeterReadingT7 +
                                //    " | prePostDecimalReadingT1 : " + value.data.meterSurveyInstalls[n].prePostDecimalReadingT1 +
                                 //   " | prePostDecimalReadingT2 : " + value.data.meterSurveyInstalls[n].prePostDecimalReadingT2 +
                                 //   " | prePostDecimalReadingT3 : " + value.data.meterSurveyInstalls[n].prePostDecimalReadingT3 +
                                //    " | prePostDecimalReadingT4 : " + value.data.meterSurveyInstalls[n].prePostDecimalReadingT4 +
                                //    " | prePostDecimalReadingT5 : " + value.data.meterSurveyInstalls[n].prePostDecimalReadingT5 +
                                //    " | prePostDecimalReadingT6 : " + value.data.meterSurveyInstalls[n].prePostDecimalReadingT6 +
                                //    " | prePostDecimalReadingT7 : " + value.data.meterSurveyInstalls[n].prePostDecimalReadingT7 +
                                //    " | existingMeterReading : " + value.data.meterSurveyInstalls[n].existingMeterReading +
                                //    " | existingMeterReading1 : " + value.data.meterSurveyInstalls[n].existingMeterReading1 +
                                //    " | existingMeterReading2 : " + value.data.meterSurveyInstalls[n].existingMeterReading2 +
                                //    " | existingMeterReading3 : " + value.data.meterSurveyInstalls[n].existingMeterReading3 +
                                //    " | existingMeterReading4 : " + value.data.meterSurveyInstalls[n].existingMeterReading4 +
                               //     " | existingMeterReading5 : " + value.data.meterSurveyInstalls[n].existingMeterReading5 +
                               //     " | existingMeterReading6 : " + value.data.meterSurveyInstalls[n].existingMeterReading6 +
                               //     " | existingMeterReading7 : " + value.data.meterSurveyInstalls[n].existingMeterReading7 +
                               //     " | type : " + value.data.meterSurveyInstalls[n].type +
                               //     " | status : " + value.data.meterSurveyInstalls[n].status +
                                    " | refusalReasons : " + value.data.meterSurveyInstalls[n].refusalReasons +
                               //     " | requestNumber : " + value.data.meterSurveyInstalls[n].requestNumber +
                               //     " | installedManufacturerCode : " + value.data.meterSurveyInstalls[n].installedManufacturerCode +
                               //     " | installedMeterModelNumber : " + value.data.meterSurveyInstalls[n].installedMeterModelNumber +
                               //     " | surveyRefusalReasons : " + value.data.meterSurveyInstalls[n].surveyRefusalReasons +
                               //     " | replacementDate : " + value.data.meterSurveyInstalls[n].replacementDate +
                               //     " | importRecordId : " + value.data.meterSurveyInstalls[n].importRecordId +
                                //    " | foundMeterSerialNumber : " + value.data.meterSurveyInstalls[n].foundMeterSerialNumber +
                                //    " | mexSupervisorId : " + value.data.meterSurveyInstalls[n].mexSupervisorId +
                                    " | workerSubmitDate : " + value.data.meterSurveyInstalls[n].workerSubmitDate +
                                //    " | workerSaveDate : " + value.data.meterSurveyInstalls[n].workerSaveDate +
                                //    " | sapStatus : " + value.data.meterSurveyInstalls[n].sapStatus +
                                //    " | sapDate : " + value.data.meterSurveyInstalls[n].sapDate +
                                //    " | isDelete : " + value.data.meterSurveyInstalls[n].isDelete +
                                //    " | createdAt : " + value.data.meterSurveyInstalls[n].createdAt +
                                    " | updatedAt : " + value.data.meterSurveyInstalls[n].updatedAt
                                    );
                                }

                                //   this.dataGridView1.Rows.Add("Page" + (i + 1) + " - " + (n + 1), "Done");
                            }

                            this.dataGridView1.Rows.Add("Page" + (i + 1), "Done");
                        }
                        catch
                        {
                            //MessageBox.Show(error.Message);
                            goto doAgain;
                        }

                    }
                   
                    
                    
                }
                MessageBox.Show("Done.", " Nokia & Bell", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getdata.Enabled = true;
            }
        }

        private void searchCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (searchCheck.Checked)
            {
                subscriptionRadio.Enabled = true;
                accountRadio.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                subscriptionRadio.Enabled = false;
                accountRadio.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                openfileSearch = theDialog.FileName;
                openfiletext.Text = theDialog.FileName;
                var lines = File.ReadLines(openfileSearch);
                searchtotal.Text = lines.Count().ToString();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}

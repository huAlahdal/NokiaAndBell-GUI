using NokiaAndBell_GUI.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NokiaAndBell_GUI.services
{
    class SearchTxt
    {
        public static Response run (string line, string key, StreamWriter file, int page, int total)
        {
            SearchByTxt form = new SearchByTxt();
            string openfileSearch = "";
            Response value = null;
            switch (key)
            {
                case "cycle":
                    value = httprequest2.GetToken(null, null, null, null, null, line, null, null, null, total, page);
                    break;
                case "installedMeterNumber":
                    value = httprequest2.GetToken(null, null, null, null, null, null, line, null, null, total, page);
                    break;
                case "mfgSerNo":
                    value = httprequest2.GetToken(null, null, null, line, null, null, null, null, null, total, page);
                    break;
                case "mru":
                    value = httprequest2.GetToken(null, null, line, null, null, null, null, null, null, total, page);
                    break;
                case "office":
                    value = httprequest2.GetToken(null, null, null, null, null, null, null, null, line, total, page);
                    break;
                case "premise":
                    value = httprequest2.GetToken(null, null, null, null, null, null, null, line, null, total, page);
                    break;
            }

            if (value.data.meterSurveyInstalls != null)
            {
                var searchLines = new List<string>();
                if (form.searchCheck2.Checked && openfileSearch != "")
                {
                    var lines = File.ReadLines(openfileSearch);
                    foreach (var perline in lines)
                    {
                        searchLines.Add(perline);
                    }
                }
                for (int i = 0; i < value.data.meterSurveyInstalls.Length; i++)
                {
                    if (value.data.meterSurveyInstalls[i].surveyStatus == null) { value.data.meterSurveyInstalls[i].surveyStatus = 0; }
                    if (value.data.meterSurveyInstalls[i].installStatus == null) { value.data.meterSurveyInstalls[i].installStatus = 0; }

                    if (form.searchCheck2.Checked)
                    {
                        if (form.subscriptionRadio2.Checked)
                        {
                            if (searchLines.Count > 0)
                            {
                                foreach (var perline in searchLines.ToList())
                                {

                                    if (value.data.meterSurveyInstalls[i].subscriptionNo == perline)
                                    {
                                        file.WriteLine(
                                        " ID : " + value.data.meterSurveyInstalls[i].id +
                                        " | Account ID : " + value.data.meterSurveyInstalls[i].accountId +
                                        " | Survey Status : " + value.data.meterSurveyInstalls[i].surveyStatus +
                                        " | Install Status : " + value.data.meterSurveyInstalls[i].installStatus +
                                        " | installedMeterNumber : " + value.data.meterSurveyInstalls[i].installedMeterNumber +
                                        " | premise : " + value.data.meterSurveyInstalls[i].premise +
                                        " | mru : " + value.data.meterSurveyInstalls[i].mru +
                                        " | office : " + value.data.meterSurveyInstalls[i].office +
                                        " | mfgSerNo : " + value.data.meterSurveyInstalls[i].mfgSerNo +
                                        " | subscriptionNo : " + value.data.meterSurveyInstalls[i].subscriptionNo +
                                        " | latitude : " + value.data.meterSurveyInstalls[i].latitude +
                                        " | longitude : " + value.data.meterSurveyInstalls[i].longitude +
                                        " | preMeterReadingT : " + value.data.meterSurveyInstalls[i].preMeterReadingT +
                                        " | refusalReasons : " + value.data.meterSurveyInstalls[i].refusalReasons +
                                        " | workerSubmitDate : " + value.data.meterSurveyInstalls[i].workerSubmitDate +
                                        " | updatedAt : " + value.data.meterSurveyInstalls[i].updatedAt
                                        );


                                        file.Flush();
                                        searchLines.Remove(perline);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Done Searching");
                                break;
                            }

                        }
                        else
                        {
                            foreach (var perline in searchLines.ToList())
                            {
                                if (value.data.meterSurveyInstalls[i].accountId == perline)
                                {
                                    file.WriteLine(
                                    " ID : " + value.data.meterSurveyInstalls[i].id +
                                    " | Account ID : " + value.data.meterSurveyInstalls[i].accountId +
                                    " | Survey Status : " + value.data.meterSurveyInstalls[i].surveyStatus +
                                    " | Install Status : " + value.data.meterSurveyInstalls[i].installStatus +
                                    " | installedMeterNumber : " + value.data.meterSurveyInstalls[i].installedMeterNumber +
                                    " | premise : " + value.data.meterSurveyInstalls[i].premise +
                                    " | mru : " + value.data.meterSurveyInstalls[i].mru +
                                    " | office : " + value.data.meterSurveyInstalls[i].office +
                                    " | mfgSerNo : " + value.data.meterSurveyInstalls[i].mfgSerNo +
                                    " | subscriptionNo : " + value.data.meterSurveyInstalls[i].subscriptionNo +
                                    " | latitude : " + value.data.meterSurveyInstalls[i].latitude +
                                    " | longitude : " + value.data.meterSurveyInstalls[i].longitude +
                                    " | preMeterReadingT : " + value.data.meterSurveyInstalls[i].preMeterReadingT +
                                    " | refusalReasons : " + value.data.meterSurveyInstalls[i].refusalReasons +
                                    " | workerSubmitDate : " + value.data.meterSurveyInstalls[i].workerSubmitDate +
                                    " | updatedAt : " + value.data.meterSurveyInstalls[i].updatedAt
                                    );
                                    file.Flush();
                                    searchLines.Remove(perline);
                                }
                            }
                        }

                    }
                    else
                    {
                        lock (file)
                        {
                            file.WriteLine(
                            " ID : " + value.data.meterSurveyInstalls[i].id +
                            " | Account ID : " + value.data.meterSurveyInstalls[i].accountId +
                            " | Survey Status : " + value.data.meterSurveyInstalls[i].surveyStatus +
                            " | Install Status : " + value.data.meterSurveyInstalls[i].installStatus +
                            " | installedMeterNumber : " + value.data.meterSurveyInstalls[i].installedMeterNumber +
                            " | premise : " + value.data.meterSurveyInstalls[i].premise +
                            " | mru : " + value.data.meterSurveyInstalls[i].mru +
                            " | office : " + value.data.meterSurveyInstalls[i].office +
                            " | mfgSerNo : " + value.data.meterSurveyInstalls[i].mfgSerNo +
                            " | subscriptionNo : " + value.data.meterSurveyInstalls[i].subscriptionNo +
                            " | latitude : " + value.data.meterSurveyInstalls[i].latitude +
                            " | longitude : " + value.data.meterSurveyInstalls[i].longitude +
                            " | preMeterReadingT : " + value.data.meterSurveyInstalls[i].preMeterReadingT +
                            " | refusalReasons : " + value.data.meterSurveyInstalls[i].refusalReasons +
                            " | workerSubmitDate : " + value.data.meterSurveyInstalls[i].workerSubmitDate +
                            " | updatedAt : " + value.data.meterSurveyInstalls[i].updatedAt
                            );
                        }
                    }
                }
            }
            else
            {
                //  if (!searchCheck2.Checked)
                //  {
                lock (file)
                {
                    file.WriteLine(line + " : No Data");
                }
                    
              //  }
            }

            //form.dataGridView1.Invoke(new Action(() => { form.dataGridView1.Rows.Add(i, line); }));
            //  this.dataGridView1.Rows.Add(n, line);
            // current.Invoke(new Action(() => { current.Text = n.ToString(); }));
            //current.Text = n.ToString();
            return value;
        }
    }
}

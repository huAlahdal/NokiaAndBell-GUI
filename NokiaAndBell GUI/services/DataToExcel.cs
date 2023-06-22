using NokiaAndBell_GUI.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NokiaAndBell_GUI.services
{
    class DataToExcel
    {
        public static void ToExcel(List<DataInfo> AllData)
        {
            string[] colums = {
            "id", "constructionId", "constructionName", "accountName", "accountId", "surveyStatus", "installStatus", "lastLongitude", "lastLatitude", "lastReviewTime",
            "lastReviewPerson", "lastRejectReason", "surveyPictureJson", "installPictureJson", "insttalledBreakerCap", "installedMeterNumber", "installedMultFactor",
            "installedMeterType", "replcamentIntegration", "disconnectionStatus", "surveyComments", "installComments", "qcRemarks", "incident", "ccneFlag", "isDamaged",
            "newLongitude", "newLatitude", "premise", "mru", "office", "mfgSerNo", "meterType", "equipNo", "cycle", "lastBillKey", "routeReadSeq", "mrNote", "dateMrNote",
            "criticalNeed", "serviceClass", "premiseAddress", "city", "district", "subscriptionNo", "accountNo", "bpName", "bpType", "latitude", "longitude", "multFactor",
            "noDials", "breakerCap", "voltage", "phase", "tariffType", "prevReadDateT", "prevReadT", "prevReadDateT1", "prevReadT1", "prevReadDateT2", "prevReadT2", "prevReadDateT3",
            "prevReadT3", "prevReadDateT4", "prevReadT4", "prevReadDateT5", "prevReadT5", "prevReadDateT6", "prevReadT6", "prevReadDateT7", "prevReadT7", "avgConspPerDay",
            "acclPremiseNo", "mainPremiseNo", "connType", "preMeterReadingT", "prePostDecimalReadingT", "preMeterReadingT1", "preMeterReadingT2", "preMeterReadingT3",
            "preMeterReadingT4", "preMeterReadingT5", "preMeterReadingT6", "preMeterReadingT7", "prePostDecimalReadingT1", "prePostDecimalReadingT2", "prePostDecimalReadingT3",
            "prePostDecimalReadingT4", "prePostDecimalReadingT5", "prePostDecimalReadingT6", "prePostDecimalReadingT7", "existingMeterReading", "existingMeterReading1",
            "existingMeterReading2", "existingMeterReading3", "existingMeterReading4", "existingMeterReading5", "existingMeterReading6", "existingMeterReading7", "type",
            "status", "refusalReasons", "requestNumber", "installedManufacturerCode", "installedMeterModelNumber", "surveyRefusalReasons", "replacementDate", "importRecordId",
            "foundMeterSerialNumber", "mexSupervisorId", "workerSubmitDate", "workerSaveDate", "sapStatus", "sapDate", "isDelete", "createdAt", "updatedAt"};

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb = excel.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet sh = wb.Sheets[1]; // or wb.Sheets["name"]

            for (int i = 0; i < colums.Length; i++)
            {
                sh.Cells[1, i + 1].Value2 = colums[i];
            }

            for (int i = 0; i < AllData.Count; i++)
            {
                sh.Cells[i + 2, 1].Value2 = AllData[i].id;
                sh.Cells[i + 2, 2].Value2 = AllData[i].constructionId.HasValue ? AllData[i].constructionId.Value : 0;
                sh.Cells[i + 2, 3].Value2 = AllData[i].constructionName;
                sh.Cells[i + 2, 4].Value2 = AllData[i].accountName;
                sh.Cells[i + 2, 5].Value2 = AllData[i].accountId;
                sh.Cells[i + 2, 6].Value2 = AllData[i].surveyStatus.HasValue ? AllData[i].surveyStatus.Value : 0;
                sh.Cells[i + 2, 7].Value2 = AllData[i].installStatus.HasValue ? AllData[i].installStatus.Value : 0;
                sh.Cells[i + 2, 8].Value2 = AllData[i].lastLongitude;
                sh.Cells[i + 2, 9].Value2 = AllData[i].lastLatitude;
                sh.Cells[i + 2, 10].Value2 = AllData[i].lastReviewTime;
                sh.Cells[i + 2, 11].Value2 = AllData[i].lastReviewPerson;
                sh.Cells[i + 2, 12].Value2 = AllData[i].lastRejectReason;
                sh.Cells[i + 2, 13].Value2 = AllData[i].surveyPictureJson;
                sh.Cells[i + 2, 14].Value2 = AllData[i].installPictureJson;
                sh.Cells[i + 2, 15].Value2 = AllData[i].insttalledBreakerCap;
                sh.Cells[i + 2, 16].Value2 = AllData[i].installedMeterNumber;
                sh.Cells[i + 2, 17].Value2 = AllData[i].installedMultFactor;
                sh.Cells[i + 2, 18].Value2 = AllData[i].installedMeterType;
                sh.Cells[i + 2, 19].Value2 = AllData[i].replcamentIntegration;
                sh.Cells[i + 2, 20].Value2 = AllData[i].disconnectionStatus;
                sh.Cells[i + 2, 21].Value2 = AllData[i].surveyComments;
                sh.Cells[i + 2, 22].Value2 = AllData[i].installComments;
                sh.Cells[i + 2, 23].Value2 = AllData[i].qcRemarks;
                sh.Cells[i + 2, 24].Value2 = AllData[i].incident;
                sh.Cells[i + 2, 25].Value2 = AllData[i].ccneFlag;
                sh.Cells[i + 2, 26].Value2 = AllData[i].isDamaged;
                sh.Cells[i + 2, 27].Value2 = AllData[i].newLongitude;
                sh.Cells[i + 2, 28].Value2 = AllData[i].newLatitude;
                sh.Cells[i + 2, 29].Value2 = AllData[i].premise;
                sh.Cells[i + 2, 30].Value2 = AllData[i].mru;
                sh.Cells[i + 2, 31].Value2 = AllData[i].office;
                sh.Cells[i + 2, 32].Value2 = AllData[i].mfgSerNo;
                sh.Cells[i + 2, 33].Value2 = AllData[i].meterType;
                sh.Cells[i + 2, 34].Value2 = AllData[i].equipNo;
                sh.Cells[i + 2, 35].Value2 = AllData[i].cycle;
                sh.Cells[i + 2, 36].Value2 = AllData[i].lastBillKey;
                sh.Cells[i + 2, 37].Value2 = AllData[i].routeReadSeq;
                sh.Cells[i + 2, 38].Value2 = AllData[i].mrNote;
                sh.Cells[i + 2, 39].Value2 = AllData[i].dateMrNote;
                sh.Cells[i + 2, 40].Value2 = AllData[i].criticalNeed;
                sh.Cells[i + 2, 41].Value2 = AllData[i].serviceClass;
                sh.Cells[i + 2, 42].Value2 = AllData[i].premiseAddress;
                sh.Cells[i + 2, 43].Value2 = AllData[i].city;
                sh.Cells[i + 2, 44].Value2 = AllData[i].district;
                sh.Cells[i + 2, 45].Value2 = AllData[i].subscriptionNo;
                sh.Cells[i + 2, 46].Value2 = AllData[i].accountNo;
                sh.Cells[i + 2, 47].Value2 = AllData[i].bpName;
                sh.Cells[i + 2, 48].Value2 = AllData[i].bpType;
                sh.Cells[i + 2, 49].Value2 = AllData[i].latitude;
                sh.Cells[i + 2, 50].Value2 = AllData[i].longitude;
                sh.Cells[i + 2, 51].Value2 = AllData[i].multFactor;
                sh.Cells[i + 2, 52].Value2 = AllData[i].noDials;
                sh.Cells[i + 2, 53].Value2 = AllData[i].breakerCap;
                sh.Cells[i + 2, 54].Value2 = AllData[i].voltage;
                sh.Cells[i + 2, 55].Value2 = AllData[i].phase;
                sh.Cells[i + 2, 56].Value2 = AllData[i].tariffType;
                sh.Cells[i + 2, 57].Value2 = AllData[i].prevReadDateT;
                sh.Cells[i + 2, 58].Value2 = AllData[i].prevReadT;
                sh.Cells[i + 2, 59].Value2 = AllData[i].prevReadDateT1;
                sh.Cells[i + 2, 60].Value2 = AllData[i].prevReadT1;
                sh.Cells[i + 2, 61].Value2 = AllData[i].prevReadDateT2;
                sh.Cells[i + 2, 62].Value2 = AllData[i].prevReadT2;
                sh.Cells[i + 2, 63].Value2 = AllData[i].prevReadDateT3;
                sh.Cells[i + 2, 64].Value2 = AllData[i].prevReadT3;
                sh.Cells[i + 2, 65].Value2 = AllData[i].prevReadDateT4;
                sh.Cells[i + 2, 66].Value2 = AllData[i].prevReadT4;
                sh.Cells[i + 2, 67].Value2 = AllData[i].prevReadDateT5;
                sh.Cells[i + 2, 68].Value2 = AllData[i].prevReadT5;
                sh.Cells[i + 2, 69].Value2 = AllData[i].prevReadDateT6;
                sh.Cells[i + 2, 70].Value2 = AllData[i].prevReadT6;
                sh.Cells[i + 2, 71].Value2 = AllData[i].prevReadDateT7;
                sh.Cells[i + 2, 72].Value2 = AllData[i].prevReadT7;
                sh.Cells[i + 2, 73].Value2 = AllData[i].avgConspPerDay;
                sh.Cells[i + 2, 74].Value2 = AllData[i].acclPremiseNo;
                sh.Cells[i + 2, 75].Value2 = AllData[i].mainPremiseNo;
                sh.Cells[i + 2, 76].Value2 = AllData[i].connType;
                sh.Cells[i + 2, 77].Value2 = AllData[i].preMeterReadingT;
                sh.Cells[i + 2, 78].Value2 = AllData[i].prePostDecimalReadingT;
                sh.Cells[i + 2, 79].Value2 = AllData[i].preMeterReadingT1;
                sh.Cells[i + 2, 80].Value2 = AllData[i].preMeterReadingT2;
                sh.Cells[i + 2, 81].Value2 = AllData[i].preMeterReadingT3;
                sh.Cells[i + 2, 82].Value2 = AllData[i].preMeterReadingT4;
                sh.Cells[i + 2, 83].Value2 = AllData[i].preMeterReadingT5;
                sh.Cells[i + 2, 84].Value2 = AllData[i].preMeterReadingT6;
                sh.Cells[i + 2, 85].Value2 = AllData[i].preMeterReadingT7;
                sh.Cells[i + 2, 86].Value2 = AllData[i].prePostDecimalReadingT1;
                sh.Cells[i + 2, 87].Value2 = AllData[i].prePostDecimalReadingT2;
                sh.Cells[i + 2, 88].Value2 = AllData[i].prePostDecimalReadingT3;
                sh.Cells[i + 2, 89].Value2 = AllData[i].prePostDecimalReadingT4;
                sh.Cells[i + 2, 90].Value2 = AllData[i].prePostDecimalReadingT5;
                sh.Cells[i + 2, 91].Value2 = AllData[i].prePostDecimalReadingT6;
                sh.Cells[i + 2, 92].Value2 = AllData[i].prePostDecimalReadingT7;
                sh.Cells[i + 2, 93].Value2 = AllData[i].existingMeterReading;
                sh.Cells[i + 2, 94].Value2 = AllData[i].existingMeterReading1;
                sh.Cells[i + 2, 95].Value2 = AllData[i].existingMeterReading2;
                sh.Cells[i + 2, 96].Value2 = AllData[i].existingMeterReading3;
                sh.Cells[i + 2, 97].Value2 = AllData[i].existingMeterReading4;
                sh.Cells[i + 2, 98].Value2 = AllData[i].existingMeterReading5;
                sh.Cells[i + 2, 99].Value2 = AllData[i].existingMeterReading6;
                sh.Cells[i + 2, 100].Value2 = AllData[i].existingMeterReading7;
                sh.Cells[i + 2, 101].Value2 = AllData[i].type;
                sh.Cells[i + 2, 102].Value2 = AllData[i].status.HasValue ? AllData[i].status.Value : 0; ;
                sh.Cells[i + 2, 103].Value2 = AllData[i].refusalReasons;
                sh.Cells[i + 2, 104].Value2 = AllData[i].requestNumber;
                sh.Cells[i + 2, 105].Value2 = AllData[i].installedManufacturerCode;
                sh.Cells[i + 2, 106].Value2 = AllData[i].installedMeterModelNumber;
                sh.Cells[i + 2, 107].Value2 = AllData[i].surveyRefusalReasons;
                sh.Cells[i + 2, 108].Value2 = UnixTimeStampToDateTime(Convert.ToDouble(AllData[i].replacementDate)); // AllData[i].replacementDate.HasValue ? AllData[i].replacementDate.Value : 0;
                sh.Cells[i + 2, 109].Value2 = AllData[i].importRecordId.HasValue ? AllData[i].importRecordId.Value : 0;
                sh.Cells[i + 2, 110].Value2 = AllData[i].foundMeterSerialNumber;
                sh.Cells[i + 2, 111].Value2 = AllData[i].mexSupervisorId;
                sh.Cells[i + 2, 112].Value2 = UnixTimeStampToDateTime(Convert.ToDouble(AllData[i].workerSubmitDate)); // AllData[i].workerSubmitDate.HasValue ? AllData[i].workerSubmitDate.Value : 0;
                sh.Cells[i + 2, 113].Value2 = UnixTimeStampToDateTime(Convert.ToDouble(AllData[i].workerSaveDate)); // AllData[i].workerSaveDate;
                sh.Cells[i + 2, 114].Value2 = AllData[i].sapStatus.HasValue ? AllData[i].sapStatus.Value : 0;
                sh.Cells[i + 2, 115].Value2 = UnixTimeStampToDateTime(Convert.ToDouble(AllData[i].sapDate)); // AllData[i].sapDate;
                sh.Cells[i + 2, 116].Value2 = AllData[i].isDelete.HasValue ? AllData[i].isDelete.Value : 0;
                sh.Cells[i + 2, 117].Value2 = UnixTimeStampToDateTime(Convert.ToDouble(AllData[i].createdAt)); // AllData[i].createdAt;
                sh.Cells[i + 2, 118].Value2 = UnixTimeStampToDateTime(Convert.ToDouble(AllData[i].updatedAt)); // AllData[i].updatedAt;

            }

            /* if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "allSaved.xlsx"))
             {
                 Random rand = new Random();
                 wb.SaveAs(AppDomain.CurrentDomain.BaseDirectory + "allSaved(" + rand.Next() + ").xlsx");
             }
             else
             {
                 wb.SaveAs(AppDomain.CurrentDomain.BaseDirectory + "allSaved.xlsx");
             }*/
            wb.SaveAs(AppDomain.CurrentDomain.BaseDirectory + "test.xlsx");
            wb.Close();
            excel.Quit();
        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            double newNumber = unixTimeStamp;

            if (newNumber > 9999999999)
            {
                newNumber = newNumber / 1000;
            }
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(newNumber).ToLocalTime();
            return dtDateTime;
        }
    }
}

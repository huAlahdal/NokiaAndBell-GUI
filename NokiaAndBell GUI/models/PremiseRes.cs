using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NokiaAndBell_GUI.models
{
    class PremiseRes
    {
        public int code { get; set; }
        public string msg { get; set; }
        public preData data { get; set; }
    }

    class preData
    {
        public meterSurveyInstall meterSurveyInstal { get; set; }
    }

    class meterSurveyInstall
    {
        public int? id { get; set; }
        public int? constructionId { get; set; }
        public string constructionName { get; set; }
        public string accountName { get; set; }
        public string accountId { get; set; }
        public int? surveyStatus { get; set; }
        public int? installStatus { get; set; }
        public string lastLongitude { get; set; }
        public string lastLatitude { get; set; }
        public string lastReviewTime { get; set; }
        public string lastReviewPerson { get; set; }
        public string lastRejectReason { get; set; }
        public string surveyPictureJson { get; set; }
        public string installPictureJson { get; set; }
        public string insttalledBreakerCap { get; set; }
        public string installedMeterNumber { get; set; }
        public string installedMultFactor { get; set; }
        public string installedMeterType { get; set; }
        public string replcamentIntegration { get; set; }
        public string disconnectionStatus { get; set; }
        public string surveyComments { get; set; }
        public string installComments { get; set; }
        public string qcRemarks { get; set; }
        public string incident { get; set; }
        public string ccneFlag { get; set; }
        public string isDamaged { get; set; }
        public string newLongitude { get; set; }
        public string newLatitude { get; set; }
        public string premise { get; set; }
        public string mru { get; set; }
        public string office { get; set; }
        public string mfgSerNo { get; set; }
        public string meterType { get; set; }
        public string equipNo { get; set; }
        public string cycle { get; set; }
        public string lastBillKey { get; set; }
        public string routeReadSeq { get; set; }
        public string mrNote { get; set; }
        public string dateMrNote { get; set; }
        public string criticalNeed { get; set; }
        public string serviceClass { get; set; }
        public string premiseAddress { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string subscriptionNo { get; set; }
        public string accountNo { get; set; }
        public string bpName { get; set; }
        public string bpType { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string multFactor { get; set; }
        public string noDials { get; set; }
        public string breakerCap { get; set; }
        public string voltage { get; set; }
        public string phase { get; set; }
        public string tariffType { get; set; }
        public string prevReadDateT { get; set; }
        public string prevReadT { get; set; }
        public string prevReadDateT1 { get; set; }
        public string prevReadT1 { get; set; }
        public string prevReadDateT2 { get; set; }
        public string prevReadT2 { get; set; }
        public string prevReadDateT3 { get; set; }
        public string prevReadT3 { get; set; }
        public string prevReadDateT4 { get; set; }
        public string prevReadT4 { get; set; }
        public string prevReadDateT5 { get; set; }
        public string prevReadT5 { get; set; }
        public string prevReadDateT6 { get; set; }
        public string prevReadT6 { get; set; }
        public string prevReadDateT7 { get; set; }
        public string prevReadT7 { get; set; }
        public string avgConspPerDay { get; set; }
        public string acclPremiseNo { get; set; }
        public string mainPremiseNo { get; set; }
        public string connType { get; set; }
        public string preMeterReadingT { get; set; }
        public string prePostDecimalReadingT { get; set; }
        public string preMeterReadingT1 { get; set; }
        public string preMeterReadingT2 { get; set; }
        public string preMeterReadingT3 { get; set; }
        public string preMeterReadingT4 { get; set; }
        public string preMeterReadingT5 { get; set; }
        public string preMeterReadingT6 { get; set; }
        public string preMeterReadingT7 { get; set; }
        public string prePostDecimalReadingT1 { get; set; }
        public string prePostDecimalReadingT2 { get; set; }
        public string prePostDecimalReadingT3 { get; set; }
        public string prePostDecimalReadingT4 { get; set; }
        public string prePostDecimalReadingT5 { get; set; }
        public string prePostDecimalReadingT6 { get; set; }
        public string prePostDecimalReadingT7 { get; set; }
        public string existingMeterReading { get; set; }
        public string existingMeterReading1 { get; set; }
        public string existingMeterReading2 { get; set; }
        public string existingMeterReading3 { get; set; }
        public string existingMeterReading4 { get; set; }
        public string existingMeterReading5 { get; set; }
        public string existingMeterReading6 { get; set; }
        public string existingMeterReading7 { get; set; }
        public string type { get; set; }
        public int status { get; set; }
        public string refusalReasons { get; set; }
        public string requestNumber { get; set; }
        public string installedManufacturerCode { get; set; }
        public string installedMeterModelNumber { get; set; }
        public string surveyRefusalReasons { get; set; }
        public double? replacementDate { get; set; }
        public int? importRecordId { get; set; }
        public string foundMeterSerialNumber { get; set; }
        public string mexSupervisorId { get; set; }
        public double? workerSubmitDate { get; set; }
        public string workerSaveDate { get; set; }
        public int? sapStatus { get; set; }
        public string sapDate { get; set; }
        public int? isDelete { get; set; }
        public double? createdAt { get; set; }
        public double? updatedAt { get; set; }
        public QCWork[] qcMeterLogs { get; set; }
        public QCWork[] workMeterLogs { get; set; }
    }

    class QCWork
    {
        public string accountId { get; set; }
        public string accountName { get; set; }
        public string createdAt { get; set; }
        public string mob { get; set; }
        public string role { get; set; }
        public string type { get; set; }
    }

    class installPictureJson
    {
        public string[] meterPicture { get; set; }
        public string[] smartMeterPicture { get; set; }
        public string[] breakerPicture { get; set; }
        public string[] closeCoverPicture { get; set; }
    }
}

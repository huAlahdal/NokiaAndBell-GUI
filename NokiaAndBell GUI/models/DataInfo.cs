using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NokiaAndBell_GUI.models
{
    public class DataInfo
    {
        public DataInfo(int? id, int? constructionId, string accountName, string accountId, int? surveyStatus, int? installStatus, string lastLongitude, string lastLatitude, string lastReviewTime, string lastReviewPerson, string lastRejectReason, string surveyPictureJson, string installPictureJson, string insttalledBreakerCap, string installedMeterNumber, string installedMultFactor, string installedMeterType, string replcamentIntegration, string disconnectionStatus, string surveyComments, string installComments, string qcRemarks, string incident, string ccneFlag, string isDamaged, string newLongitude, string newLatitude, string premise, string mru, string office, string mfgSerNo, string meterType, string equipNo, string cycle, string lastBillKey, string routeReadSeq, string mrNote, string dateMrNote, string criticalNeed, string serviceClass, string premiseAddress, string city, string district, string subscriptionNo, string accountNo, string bpName, string bpType, string latitude, string longitude, string multFactor, string noDials, string breakerCap, string voltage, string phase, string tariffType, string prevReadDateT, string prevReadT, string prevReadDateT1, string prevReadT1, string prevReadDateT2, string prevReadT2, string prevReadDateT3, string prevReadT3, string prevReadDateT4, string prevReadT4, string prevReadDateT5, string prevReadT5, string prevReadDateT6, string prevReadT6, string prevReadDateT7, string prevReadT7, string avgConspPerDay, string acclPremiseNo, string mainPremiseNo, string connType, string preMeterReadingT, string prePostDecimalReadingT, string preMeterReadingT1, string preMeterReadingT2, string preMeterReadingT3, string preMeterReadingT4, string preMeterReadingT5, string preMeterReadingT6, string preMeterReadingT7, string prePostDecimalReadingT1, string prePostDecimalReadingT2, string prePostDecimalReadingT3, string prePostDecimalReadingT4, string prePostDecimalReadingT5, string prePostDecimalReadingT6, string prePostDecimalReadingT7, string existingMeterReading, string existingMeterReading1, string existingMeterReading2, string existingMeterReading3, string existingMeterReading4, string existingMeterReading5, string existingMeterReading6, string existingMeterReading7, string type, int? status, string refusalReasons, string requestNumber, string installedManufacturerCode, string installedMeterModelNumber, string surveyRefusalReasons, double? replacementDate, int? importRecordId, string foundMeterSerialNumber, string mexSupervisorId, double? workerSubmitDate, string workerSaveDate, int? sapStatus, string sapDate, int? isDelete, double? createdAt, double? updatedAt)
        {
            this.id = id;
            this.constructionId = constructionId;
            this.accountName = accountName;
            this.accountId = accountId;
            this.surveyStatus = surveyStatus;
            this.installStatus = installStatus;
            this.lastLongitude = lastLongitude;
            this.lastLatitude = lastLatitude;
            this.lastReviewTime = lastReviewTime;
            this.lastReviewPerson = lastReviewPerson;
            this.lastRejectReason = lastRejectReason;
            this.surveyPictureJson = surveyPictureJson;
            this.installPictureJson = installPictureJson;
            this.insttalledBreakerCap = insttalledBreakerCap;
            this.installedMeterNumber = installedMeterNumber;
            this.installedMultFactor = installedMultFactor;
            this.installedMeterType = installedMeterType;
            this.replcamentIntegration = replcamentIntegration;
            this.disconnectionStatus = disconnectionStatus;
            this.surveyComments = surveyComments;
            this.installComments = installComments;
            this.qcRemarks = qcRemarks;
            this.incident = incident;
            this.ccneFlag = ccneFlag;
            this.isDamaged = isDamaged;
            this.newLongitude = newLongitude;
            this.newLatitude = newLatitude;
            this.premise = premise;
            this.mru = mru;
            this.office = office;
            this.mfgSerNo = mfgSerNo;
            this.meterType = meterType;
            this.equipNo = equipNo;
            this.cycle = cycle;
            this.lastBillKey = lastBillKey;
            this.routeReadSeq = routeReadSeq;
            this.mrNote = mrNote;
            this.dateMrNote = dateMrNote;
            this.criticalNeed = criticalNeed;
            this.serviceClass = serviceClass;
            this.premiseAddress = premiseAddress;
            this.city = city;
            this.district = district;
            this.subscriptionNo = subscriptionNo;
            this.accountNo = accountNo;
            this.bpName = bpName;
            this.bpType = bpType;
            this.latitude = latitude;
            this.longitude = longitude;
            this.multFactor = multFactor;
            this.noDials = noDials;
            this.breakerCap = breakerCap;
            this.voltage = voltage;
            this.phase = phase;
            this.tariffType = tariffType;
            this.prevReadDateT = prevReadDateT;
            this.prevReadT = prevReadT;
            this.prevReadDateT1 = prevReadDateT1;
            this.prevReadT1 = prevReadT1;
            this.prevReadDateT2 = prevReadDateT2;
            this.prevReadT2 = prevReadT2;
            this.prevReadDateT3 = prevReadDateT3;
            this.prevReadT3 = prevReadT3;
            this.prevReadDateT4 = prevReadDateT4;
            this.prevReadT4 = prevReadT4;
            this.prevReadDateT5 = prevReadDateT5;
            this.prevReadT5 = prevReadT5;
            this.prevReadDateT6 = prevReadDateT6;
            this.prevReadT6 = prevReadT6;
            this.prevReadDateT7 = prevReadDateT7;
            this.prevReadT7 = prevReadT7;
            this.avgConspPerDay = avgConspPerDay;
            this.acclPremiseNo = acclPremiseNo;
            this.mainPremiseNo = mainPremiseNo;
            this.connType = connType;
            this.preMeterReadingT = preMeterReadingT;
            this.prePostDecimalReadingT = prePostDecimalReadingT;
            this.preMeterReadingT1 = preMeterReadingT1;
            this.preMeterReadingT2 = preMeterReadingT2;
            this.preMeterReadingT3 = preMeterReadingT3;
            this.preMeterReadingT4 = preMeterReadingT4;
            this.preMeterReadingT5 = preMeterReadingT5;
            this.preMeterReadingT6 = preMeterReadingT6;
            this.preMeterReadingT7 = preMeterReadingT7;
            this.prePostDecimalReadingT1 = prePostDecimalReadingT1;
            this.prePostDecimalReadingT2 = prePostDecimalReadingT2;
            this.prePostDecimalReadingT3 = prePostDecimalReadingT3;
            this.prePostDecimalReadingT4 = prePostDecimalReadingT4;
            this.prePostDecimalReadingT5 = prePostDecimalReadingT5;
            this.prePostDecimalReadingT6 = prePostDecimalReadingT6;
            this.prePostDecimalReadingT7 = prePostDecimalReadingT7;
            this.existingMeterReading = existingMeterReading;
            this.existingMeterReading1 = existingMeterReading1;
            this.existingMeterReading2 = existingMeterReading2;
            this.existingMeterReading3 = existingMeterReading3;
            this.existingMeterReading4 = existingMeterReading4;
            this.existingMeterReading5 = existingMeterReading5;
            this.existingMeterReading6 = existingMeterReading6;
            this.existingMeterReading7 = existingMeterReading7;
            this.type = type;
            this.status = status;
            this.refusalReasons = refusalReasons;
            this.requestNumber = requestNumber;
            this.installedManufacturerCode = installedManufacturerCode;
            this.installedMeterModelNumber = installedMeterModelNumber;
            this.surveyRefusalReasons = surveyRefusalReasons;
            this.replacementDate = replacementDate;
            this.importRecordId = importRecordId;
            this.foundMeterSerialNumber = foundMeterSerialNumber;
            this.mexSupervisorId = mexSupervisorId;
            this.workerSubmitDate = workerSubmitDate;
            this.workerSaveDate = workerSaveDate;
            this.sapStatus = sapStatus;
            this.sapDate = sapDate;
            this.isDelete = isDelete;
            this.createdAt = createdAt;
            this.updatedAt = updatedAt;
        }


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
        public int? status { get; set; }
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
    }
}

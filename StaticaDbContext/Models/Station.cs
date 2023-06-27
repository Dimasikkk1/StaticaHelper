﻿namespace StaticaDbContext.Models
{
    public partial class Station
    {
        public Guid Id { get; set; }
        public string? RecognitionUrl { get; set; }
        public string? Organization { get; set; }
        public string? Director { get; set; }
        public string? Accountant { get; set; }
        public string? FactAddres { get; set; }
        public string? LawAddres { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public bool? UseRequiredFileds { get; set; }
        public bool CloseTransitOnAuto { get; set; }
        public double? WaitPicTime { get; set; }
        public bool UseLogs { get; set; }
        public string? PsUrl { get; set; }
        public int? PsPort { get; set; }
        public bool? UseAvion { get; set; }
        public bool? AutoStart { get; set; }
        public bool? AutoNumReverse { get; set; }
        public bool? IgnoreStable { get; set; }
        public bool? NoClearNumAtWait { get; set; }
        public bool? AutoPrintPs { get; set; }
        public bool? AutoSendPs { get; set; }
        public bool IgnoreReverseStartIn { get; set; }
        public bool IgnoreReverseWaitOut { get; set; }
        public bool UseKpp { get; set; }
        public bool NumsToUpper { get; set; }
        public DateTime VerifyDate { get; set; }
        public byte[]? CompanyLabel { get; set; }
        public int? KppWaitTime { get; set; }
        public bool CleverCheck { get; set; }
        public bool RecApproachCheck { get; set; }
        public bool UseDownsuspsFromCatalogs { get; set; }
        public bool CompareNums { get; set; }
        public bool? UseReverseStatuses { get; set; }
        public bool KppNums { get; set; }
        public bool AutoPrint { get; set; }
        public bool? IgnoreTrailersNums { get; set; }
        public bool UseAllPosts { get; set; }
        public int SearchDaysTill { get; set; }
        public int PrintCopies { get; set; }
        public bool PrintAnyWeight { get; set; }
        public bool NoAutoWaiting { get; set; }
        public bool NoReverseDates { get; set; }
        public bool AlwaysUseTareFromCatalog { get; set; }
        public bool UseRefreshJournal { get; set; }
        public int RefreshJournalTime { get; set; }
        public string? ActPath { get; set; }
        public string? TnPath { get; set; }
        public string? TtnPath { get; set; }
        public int? QualityPercent { get; set; }
        public string? AvionVadPath { get; set; }
        public bool? UseCustomQr { get; set; }
        public string? QrText { get; set; }
        public bool? UseProtocolQr { get; set; }
        public bool UseBadTransits { get; set; }
        public string? VgmPath { get; set; }
        public bool? VgmWithAct { get; set; }
        public string? ScalesInfo { get; set; }
        public string? VgmInfo { get; set; }
        public string? Declaration { get; set; }
        public bool? ForceReloadScales { get; set; }
        public bool? CatchLogAvionVad { get; set; }
        public bool? UsePreview { get; set; }
        public bool? ChooseTemplate { get; set; }
        public bool? ExternFilesUse { get; set; }
        public string? ExternPath { get; set; }
        public bool? ExternSavePhotos { get; set; }
        public bool? ExternSaveXmlJson { get; set; }
        public int? SensorsDelay { get; set; }
        public bool? UseSchemes { get; set; }
        public bool? UseTtnAutoprint { get; set; }
        public bool? UseTnAutoprint { get; set; }
        public bool? SendAnonymousInfo { get; set; }
        public bool? UseBetweensFromCatalogs { get; set; }
        public bool? UseReverseOnDecisions { get; set; }
        public bool? TransitAlwaysOnTop { get; set; }
        public string? DtDefTextWrongId { get; set; }
        public string? DtDefTextWrongWeight { get; set; }
        public string? DtDefTextOkAxles { get; set; }
        public string? DtDefTextBadAxles { get; set; }
        public string? DtDefTextErrorCalc { get; set; }
        public bool? UseDownhillFromAvion { get; set; }
        public int? WaitInTicks { get; set; }
        public bool? UseOldTransitView { get; set; }
        public bool? BlockDockForUsers { get; set; }
    }
}

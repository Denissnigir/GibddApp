//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GibddApp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class DriverArchive
    {
        public int DriverArchiveId { get; set; }
        public Nullable<int> DriverId { get; set; }
        public string DriverFirstName { get; set; }
        public string DriverSecondName { get; set; }
        public string DriverMiddleNam { get; set; }
        public string DriverPassportSerial { get; set; }
        public string DriverPassportNumber { get; set; }
        public string DriverPostcode { get; set; }
        public Nullable<int> DriverTownId { get; set; }
        public string DriverAddress { get; set; }
        public Nullable<int> DriverTownLifeId { get; set; }
        public string DriverAddressLife { get; set; }
        public Nullable<int> DriverCompanyId { get; set; }
        public Nullable<int> DriverJobId { get; set; }
        public string DriverPhone { get; set; }
        public string DriverEmail { get; set; }
        public string DriverPhoto { get; set; }
        public string DriverDescrition { get; set; }
    
        public virtual Driver Driver { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MainWebApp.Models
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class spRepairCrud_Result
    {
        [Key]
        [DisplayName("Repair ID")]
        public int REPAIR_ID { get; set; }

        [DisplayName("Equip ID")]
        public int EQUIPMENT_ID { get; set; }

        [DisplayName("Requested By")]
        public string REQUESTED_BY { get; set; }

        [DisplayName("RMA #")]
        public string RMA_NUM { get; set; }

        [DisplayName("Date Shipped")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        public System.DateTime SHIPPED_DATE { get; set; }

        [DisplayName("Tracking #")]
        public string TRACKING_NUM { get; set; }

        [DisplayName("Recipient")]
        public string RECIPIENT { get; set; }

        [DisplayName("Address 1")]
        public string ADDRESS_1 { get; set; }

        [DisplayName("Address 2")]
        public string ADDRESS_2 { get; set; }

        [DisplayName("Address 3")]
        public string ADDRESS_3 { get; set; }

        [DisplayName("City")]
        public string CITY { get; set; }

        [DisplayName("ST")]
        public string STATE { get; set; }

        [DisplayName("ZIP")]
        public string ZIP { get; set; }

        [DisplayName("COUNTRY")]
        public string COUNTRY { get; set; }

        [DisplayName("Contact Phone")]
        public string CONTACT_PHONE { get; set; }

        [DisplayName("Contact Email")]
        public string CONTACT_EMAIL { get; set; }

        [DisplayName("Replacement Serial #")]
        public string REPLACEMENT_SERIAL_NUM { get; set; }

        [DisplayName("Returned?")]
        public Nullable<bool> RETURNED { get; set; }

        [DisplayName("Date Returned")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        public Nullable<System.DateTime> RETURNED_DATE { get; set; }
    }
}

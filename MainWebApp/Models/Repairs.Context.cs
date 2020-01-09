﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EQUIPMENT_REPAIRS> EQUIPMENT_REPAIRS { get; set; }
    
        public virtual ObjectResult<spRepairCrud_Result> spRepairCrud(string aCTION, Nullable<int> rEPAIR_ID, Nullable<int> eQUIPMENT_ID, string rEQUESTED_BY, string rMA_NUM, Nullable<System.DateTime> sHIPPED_DATE, string tRACKING_NUM, string rECIPIENT, string aDDRESS_1, string aDDRESS_2, string aDDRESS_3, string cITY, string sTATE, string zIP, string cOUNTRY, string cONTACT_PHONE, string cONTACT_EMAIL, string rEPLACEMENT_SERIAL_NUM, Nullable<bool> rETURNED, Nullable<System.DateTime> rETURNED_DATE)
        {
            var aCTIONParameter = aCTION != null ?
                new ObjectParameter("ACTION", aCTION) :
                new ObjectParameter("ACTION", typeof(string));
    
            var rEPAIR_IDParameter = rEPAIR_ID.HasValue ?
                new ObjectParameter("REPAIR_ID", rEPAIR_ID) :
                new ObjectParameter("REPAIR_ID", typeof(int));
    
            var eQUIPMENT_IDParameter = eQUIPMENT_ID.HasValue ?
                new ObjectParameter("EQUIPMENT_ID", eQUIPMENT_ID) :
                new ObjectParameter("EQUIPMENT_ID", typeof(int));
    
            var rEQUESTED_BYParameter = rEQUESTED_BY != null ?
                new ObjectParameter("REQUESTED_BY", rEQUESTED_BY) :
                new ObjectParameter("REQUESTED_BY", typeof(string));
    
            var rMA_NUMParameter = rMA_NUM != null ?
                new ObjectParameter("RMA_NUM", rMA_NUM) :
                new ObjectParameter("RMA_NUM", typeof(string));
    
            var sHIPPED_DATEParameter = sHIPPED_DATE.HasValue ?
                new ObjectParameter("SHIPPED_DATE", sHIPPED_DATE) :
                new ObjectParameter("SHIPPED_DATE", typeof(System.DateTime));
    
            var tRACKING_NUMParameter = tRACKING_NUM != null ?
                new ObjectParameter("TRACKING_NUM", tRACKING_NUM) :
                new ObjectParameter("TRACKING_NUM", typeof(string));
    
            var rECIPIENTParameter = rECIPIENT != null ?
                new ObjectParameter("RECIPIENT", rECIPIENT) :
                new ObjectParameter("RECIPIENT", typeof(string));
    
            var aDDRESS_1Parameter = aDDRESS_1 != null ?
                new ObjectParameter("ADDRESS_1", aDDRESS_1) :
                new ObjectParameter("ADDRESS_1", typeof(string));
    
            var aDDRESS_2Parameter = aDDRESS_2 != null ?
                new ObjectParameter("ADDRESS_2", aDDRESS_2) :
                new ObjectParameter("ADDRESS_2", typeof(string));
    
            var aDDRESS_3Parameter = aDDRESS_3 != null ?
                new ObjectParameter("ADDRESS_3", aDDRESS_3) :
                new ObjectParameter("ADDRESS_3", typeof(string));
    
            var cITYParameter = cITY != null ?
                new ObjectParameter("CITY", cITY) :
                new ObjectParameter("CITY", typeof(string));
    
            var sTATEParameter = sTATE != null ?
                new ObjectParameter("STATE", sTATE) :
                new ObjectParameter("STATE", typeof(string));
    
            var zIPParameter = zIP != null ?
                new ObjectParameter("ZIP", zIP) :
                new ObjectParameter("ZIP", typeof(string));
    
            var cOUNTRYParameter = cOUNTRY != null ?
                new ObjectParameter("COUNTRY", cOUNTRY) :
                new ObjectParameter("COUNTRY", typeof(string));
    
            var cONTACT_PHONEParameter = cONTACT_PHONE != null ?
                new ObjectParameter("CONTACT_PHONE", cONTACT_PHONE) :
                new ObjectParameter("CONTACT_PHONE", typeof(string));
    
            var cONTACT_EMAILParameter = cONTACT_EMAIL != null ?
                new ObjectParameter("CONTACT_EMAIL", cONTACT_EMAIL) :
                new ObjectParameter("CONTACT_EMAIL", typeof(string));
    
            var rEPLACEMENT_SERIAL_NUMParameter = rEPLACEMENT_SERIAL_NUM != null ?
                new ObjectParameter("REPLACEMENT_SERIAL_NUM", rEPLACEMENT_SERIAL_NUM) :
                new ObjectParameter("REPLACEMENT_SERIAL_NUM", typeof(string));
    
            var rETURNEDParameter = rETURNED.HasValue ?
                new ObjectParameter("RETURNED", rETURNED) :
                new ObjectParameter("RETURNED", typeof(bool));
    
            var rETURNED_DATEParameter = rETURNED_DATE.HasValue ?
                new ObjectParameter("RETURNED_DATE", rETURNED_DATE) :
                new ObjectParameter("RETURNED_DATE", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spRepairCrud_Result>("spRepairCrud", aCTIONParameter, rEPAIR_IDParameter, eQUIPMENT_IDParameter, rEQUESTED_BYParameter, rMA_NUMParameter, sHIPPED_DATEParameter, tRACKING_NUMParameter, rECIPIENTParameter, aDDRESS_1Parameter, aDDRESS_2Parameter, aDDRESS_3Parameter, cITYParameter, sTATEParameter, zIPParameter, cOUNTRYParameter, cONTACT_PHONEParameter, cONTACT_EMAILParameter, rEPLACEMENT_SERIAL_NUMParameter, rETURNEDParameter, rETURNED_DATEParameter);
        }
    
        public virtual ObjectResult<EQUIPMENT_REPAIRS> Repairs_CRUD(string aCTION, Nullable<int> rEPAIR_ID, Nullable<int> eQUIPMENT_ID, string rEQUESTED_BY, string rMA_NUM, Nullable<System.DateTime> sHIPPED_DATE, string tRACKING_NUM, string rECIPIENT, string aDDRESS_1, string aDDRESS_2, string aDDRESS_3, string cITY, string sTATE, string zIP, string cOUNTRY, string cONTACT_PHONE, string cONTACT_EMAIL, string rEPLACEMENT_SERIAL_NUM, Nullable<bool> rETURNED, Nullable<System.DateTime> rETURNED_DATE)
        {
            var aCTIONParameter = aCTION != null ?
                new ObjectParameter("ACTION", aCTION) :
                new ObjectParameter("ACTION", typeof(string));
    
            var rEPAIR_IDParameter = rEPAIR_ID.HasValue ?
                new ObjectParameter("REPAIR_ID", rEPAIR_ID) :
                new ObjectParameter("REPAIR_ID", typeof(int));
    
            var eQUIPMENT_IDParameter = eQUIPMENT_ID.HasValue ?
                new ObjectParameter("EQUIPMENT_ID", eQUIPMENT_ID) :
                new ObjectParameter("EQUIPMENT_ID", typeof(int));
    
            var rEQUESTED_BYParameter = rEQUESTED_BY != null ?
                new ObjectParameter("REQUESTED_BY", rEQUESTED_BY) :
                new ObjectParameter("REQUESTED_BY", typeof(string));
    
            var rMA_NUMParameter = rMA_NUM != null ?
                new ObjectParameter("RMA_NUM", rMA_NUM) :
                new ObjectParameter("RMA_NUM", typeof(string));
    
            var sHIPPED_DATEParameter = sHIPPED_DATE.HasValue ?
                new ObjectParameter("SHIPPED_DATE", sHIPPED_DATE) :
                new ObjectParameter("SHIPPED_DATE", typeof(System.DateTime));
    
            var tRACKING_NUMParameter = tRACKING_NUM != null ?
                new ObjectParameter("TRACKING_NUM", tRACKING_NUM) :
                new ObjectParameter("TRACKING_NUM", typeof(string));
    
            var rECIPIENTParameter = rECIPIENT != null ?
                new ObjectParameter("RECIPIENT", rECIPIENT) :
                new ObjectParameter("RECIPIENT", typeof(string));
    
            var aDDRESS_1Parameter = aDDRESS_1 != null ?
                new ObjectParameter("ADDRESS_1", aDDRESS_1) :
                new ObjectParameter("ADDRESS_1", typeof(string));
    
            var aDDRESS_2Parameter = aDDRESS_2 != null ?
                new ObjectParameter("ADDRESS_2", aDDRESS_2) :
                new ObjectParameter("ADDRESS_2", typeof(string));
    
            var aDDRESS_3Parameter = aDDRESS_3 != null ?
                new ObjectParameter("ADDRESS_3", aDDRESS_3) :
                new ObjectParameter("ADDRESS_3", typeof(string));
    
            var cITYParameter = cITY != null ?
                new ObjectParameter("CITY", cITY) :
                new ObjectParameter("CITY", typeof(string));
    
            var sTATEParameter = sTATE != null ?
                new ObjectParameter("STATE", sTATE) :
                new ObjectParameter("STATE", typeof(string));
    
            var zIPParameter = zIP != null ?
                new ObjectParameter("ZIP", zIP) :
                new ObjectParameter("ZIP", typeof(string));
    
            var cOUNTRYParameter = cOUNTRY != null ?
                new ObjectParameter("COUNTRY", cOUNTRY) :
                new ObjectParameter("COUNTRY", typeof(string));
    
            var cONTACT_PHONEParameter = cONTACT_PHONE != null ?
                new ObjectParameter("CONTACT_PHONE", cONTACT_PHONE) :
                new ObjectParameter("CONTACT_PHONE", typeof(string));
    
            var cONTACT_EMAILParameter = cONTACT_EMAIL != null ?
                new ObjectParameter("CONTACT_EMAIL", cONTACT_EMAIL) :
                new ObjectParameter("CONTACT_EMAIL", typeof(string));
    
            var rEPLACEMENT_SERIAL_NUMParameter = rEPLACEMENT_SERIAL_NUM != null ?
                new ObjectParameter("REPLACEMENT_SERIAL_NUM", rEPLACEMENT_SERIAL_NUM) :
                new ObjectParameter("REPLACEMENT_SERIAL_NUM", typeof(string));
    
            var rETURNEDParameter = rETURNED.HasValue ?
                new ObjectParameter("RETURNED", rETURNED) :
                new ObjectParameter("RETURNED", typeof(bool));
    
            var rETURNED_DATEParameter = rETURNED_DATE.HasValue ?
                new ObjectParameter("RETURNED_DATE", rETURNED_DATE) :
                new ObjectParameter("RETURNED_DATE", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EQUIPMENT_REPAIRS>("Repairs_CRUD", aCTIONParameter, rEPAIR_IDParameter, eQUIPMENT_IDParameter, rEQUESTED_BYParameter, rMA_NUMParameter, sHIPPED_DATEParameter, tRACKING_NUMParameter, rECIPIENTParameter, aDDRESS_1Parameter, aDDRESS_2Parameter, aDDRESS_3Parameter, cITYParameter, sTATEParameter, zIPParameter, cOUNTRYParameter, cONTACT_PHONEParameter, cONTACT_EMAILParameter, rEPLACEMENT_SERIAL_NUMParameter, rETURNEDParameter, rETURNED_DATEParameter);
        }
    
        public virtual ObjectResult<EQUIPMENT_REPAIRS> Repairs_CRUD(string aCTION, Nullable<int> rEPAIR_ID, Nullable<int> eQUIPMENT_ID, string rEQUESTED_BY, string rMA_NUM, Nullable<System.DateTime> sHIPPED_DATE, string tRACKING_NUM, string rECIPIENT, string aDDRESS_1, string aDDRESS_2, string aDDRESS_3, string cITY, string sTATE, string zIP, string cOUNTRY, string cONTACT_PHONE, string cONTACT_EMAIL, string rEPLACEMENT_SERIAL_NUM, Nullable<bool> rETURNED, Nullable<System.DateTime> rETURNED_DATE, MergeOption mergeOption)
        {
            var aCTIONParameter = aCTION != null ?
                new ObjectParameter("ACTION", aCTION) :
                new ObjectParameter("ACTION", typeof(string));
    
            var rEPAIR_IDParameter = rEPAIR_ID.HasValue ?
                new ObjectParameter("REPAIR_ID", rEPAIR_ID) :
                new ObjectParameter("REPAIR_ID", typeof(int));
    
            var eQUIPMENT_IDParameter = eQUIPMENT_ID.HasValue ?
                new ObjectParameter("EQUIPMENT_ID", eQUIPMENT_ID) :
                new ObjectParameter("EQUIPMENT_ID", typeof(int));
    
            var rEQUESTED_BYParameter = rEQUESTED_BY != null ?
                new ObjectParameter("REQUESTED_BY", rEQUESTED_BY) :
                new ObjectParameter("REQUESTED_BY", typeof(string));
    
            var rMA_NUMParameter = rMA_NUM != null ?
                new ObjectParameter("RMA_NUM", rMA_NUM) :
                new ObjectParameter("RMA_NUM", typeof(string));
    
            var sHIPPED_DATEParameter = sHIPPED_DATE.HasValue ?
                new ObjectParameter("SHIPPED_DATE", sHIPPED_DATE) :
                new ObjectParameter("SHIPPED_DATE", typeof(System.DateTime));
    
            var tRACKING_NUMParameter = tRACKING_NUM != null ?
                new ObjectParameter("TRACKING_NUM", tRACKING_NUM) :
                new ObjectParameter("TRACKING_NUM", typeof(string));
    
            var rECIPIENTParameter = rECIPIENT != null ?
                new ObjectParameter("RECIPIENT", rECIPIENT) :
                new ObjectParameter("RECIPIENT", typeof(string));
    
            var aDDRESS_1Parameter = aDDRESS_1 != null ?
                new ObjectParameter("ADDRESS_1", aDDRESS_1) :
                new ObjectParameter("ADDRESS_1", typeof(string));
    
            var aDDRESS_2Parameter = aDDRESS_2 != null ?
                new ObjectParameter("ADDRESS_2", aDDRESS_2) :
                new ObjectParameter("ADDRESS_2", typeof(string));
    
            var aDDRESS_3Parameter = aDDRESS_3 != null ?
                new ObjectParameter("ADDRESS_3", aDDRESS_3) :
                new ObjectParameter("ADDRESS_3", typeof(string));
    
            var cITYParameter = cITY != null ?
                new ObjectParameter("CITY", cITY) :
                new ObjectParameter("CITY", typeof(string));
    
            var sTATEParameter = sTATE != null ?
                new ObjectParameter("STATE", sTATE) :
                new ObjectParameter("STATE", typeof(string));
    
            var zIPParameter = zIP != null ?
                new ObjectParameter("ZIP", zIP) :
                new ObjectParameter("ZIP", typeof(string));
    
            var cOUNTRYParameter = cOUNTRY != null ?
                new ObjectParameter("COUNTRY", cOUNTRY) :
                new ObjectParameter("COUNTRY", typeof(string));
    
            var cONTACT_PHONEParameter = cONTACT_PHONE != null ?
                new ObjectParameter("CONTACT_PHONE", cONTACT_PHONE) :
                new ObjectParameter("CONTACT_PHONE", typeof(string));
    
            var cONTACT_EMAILParameter = cONTACT_EMAIL != null ?
                new ObjectParameter("CONTACT_EMAIL", cONTACT_EMAIL) :
                new ObjectParameter("CONTACT_EMAIL", typeof(string));
    
            var rEPLACEMENT_SERIAL_NUMParameter = rEPLACEMENT_SERIAL_NUM != null ?
                new ObjectParameter("REPLACEMENT_SERIAL_NUM", rEPLACEMENT_SERIAL_NUM) :
                new ObjectParameter("REPLACEMENT_SERIAL_NUM", typeof(string));
    
            var rETURNEDParameter = rETURNED.HasValue ?
                new ObjectParameter("RETURNED", rETURNED) :
                new ObjectParameter("RETURNED", typeof(bool));
    
            var rETURNED_DATEParameter = rETURNED_DATE.HasValue ?
                new ObjectParameter("RETURNED_DATE", rETURNED_DATE) :
                new ObjectParameter("RETURNED_DATE", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EQUIPMENT_REPAIRS>("Repairs_CRUD", mergeOption, aCTIONParameter, rEPAIR_IDParameter, eQUIPMENT_IDParameter, rEQUESTED_BYParameter, rMA_NUMParameter, sHIPPED_DATEParameter, tRACKING_NUMParameter, rECIPIENTParameter, aDDRESS_1Parameter, aDDRESS_2Parameter, aDDRESS_3Parameter, cITYParameter, sTATEParameter, zIPParameter, cOUNTRYParameter, cONTACT_PHONEParameter, cONTACT_EMAILParameter, rEPLACEMENT_SERIAL_NUMParameter, rETURNEDParameter, rETURNED_DATEParameter);
        }
    
        public virtual ObjectResult<PAGE_REPAIR_ITEM_Result> PAGE_REPAIR_ITEM(Nullable<int> rEPAIR_ID)
        {
            var rEPAIR_IDParameter = rEPAIR_ID.HasValue ?
                new ObjectParameter("REPAIR_ID", rEPAIR_ID) :
                new ObjectParameter("REPAIR_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PAGE_REPAIR_ITEM_Result>("PAGE_REPAIR_ITEM", rEPAIR_IDParameter);
        }
    
        public virtual int SYS_INSERT_EQUIP_REPAIRS(Nullable<int> eQUIPMENT_ID, string rEQUESTED_BY, string rMA_NUM, Nullable<System.DateTime> sHIPPED_DATE, string tRACKING_NUM, string rECIPIENT, string aDDRESS_1, string aDDRESS_2, string aDDRESS_3, string cITY, string sTATE, string zIP, string cOUNTRY, string cONTACT_PHONE, string cONTACT_EMAIL)
        {
            var eQUIPMENT_IDParameter = eQUIPMENT_ID.HasValue ?
                new ObjectParameter("EQUIPMENT_ID", eQUIPMENT_ID) :
                new ObjectParameter("EQUIPMENT_ID", typeof(int));
    
            var rEQUESTED_BYParameter = rEQUESTED_BY != null ?
                new ObjectParameter("REQUESTED_BY", rEQUESTED_BY) :
                new ObjectParameter("REQUESTED_BY", typeof(string));
    
            var rMA_NUMParameter = rMA_NUM != null ?
                new ObjectParameter("RMA_NUM", rMA_NUM) :
                new ObjectParameter("RMA_NUM", typeof(string));
    
            var sHIPPED_DATEParameter = sHIPPED_DATE.HasValue ?
                new ObjectParameter("SHIPPED_DATE", sHIPPED_DATE) :
                new ObjectParameter("SHIPPED_DATE", typeof(System.DateTime));
    
            var tRACKING_NUMParameter = tRACKING_NUM != null ?
                new ObjectParameter("TRACKING_NUM", tRACKING_NUM) :
                new ObjectParameter("TRACKING_NUM", typeof(string));
    
            var rECIPIENTParameter = rECIPIENT != null ?
                new ObjectParameter("RECIPIENT", rECIPIENT) :
                new ObjectParameter("RECIPIENT", typeof(string));
    
            var aDDRESS_1Parameter = aDDRESS_1 != null ?
                new ObjectParameter("ADDRESS_1", aDDRESS_1) :
                new ObjectParameter("ADDRESS_1", typeof(string));
    
            var aDDRESS_2Parameter = aDDRESS_2 != null ?
                new ObjectParameter("ADDRESS_2", aDDRESS_2) :
                new ObjectParameter("ADDRESS_2", typeof(string));
    
            var aDDRESS_3Parameter = aDDRESS_3 != null ?
                new ObjectParameter("ADDRESS_3", aDDRESS_3) :
                new ObjectParameter("ADDRESS_3", typeof(string));
    
            var cITYParameter = cITY != null ?
                new ObjectParameter("CITY", cITY) :
                new ObjectParameter("CITY", typeof(string));
    
            var sTATEParameter = sTATE != null ?
                new ObjectParameter("STATE", sTATE) :
                new ObjectParameter("STATE", typeof(string));
    
            var zIPParameter = zIP != null ?
                new ObjectParameter("ZIP", zIP) :
                new ObjectParameter("ZIP", typeof(string));
    
            var cOUNTRYParameter = cOUNTRY != null ?
                new ObjectParameter("COUNTRY", cOUNTRY) :
                new ObjectParameter("COUNTRY", typeof(string));
    
            var cONTACT_PHONEParameter = cONTACT_PHONE != null ?
                new ObjectParameter("CONTACT_PHONE", cONTACT_PHONE) :
                new ObjectParameter("CONTACT_PHONE", typeof(string));
    
            var cONTACT_EMAILParameter = cONTACT_EMAIL != null ?
                new ObjectParameter("CONTACT_EMAIL", cONTACT_EMAIL) :
                new ObjectParameter("CONTACT_EMAIL", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SYS_INSERT_EQUIP_REPAIRS", eQUIPMENT_IDParameter, rEQUESTED_BYParameter, rMA_NUMParameter, sHIPPED_DATEParameter, tRACKING_NUMParameter, rECIPIENTParameter, aDDRESS_1Parameter, aDDRESS_2Parameter, aDDRESS_3Parameter, cITYParameter, sTATEParameter, zIPParameter, cOUNTRYParameter, cONTACT_PHONEParameter, cONTACT_EMAILParameter);
        }
    
        public virtual int SYS_UPDATE_REPAIRS(Nullable<int> rEPAIR_ID, Nullable<int> eQUIPMENT_ID, string rEQUESTED_BY, string rMA_NUM, Nullable<System.DateTime> sHIPPED_DATE, string tRACKING_NUM, string rECIPIENT, string aDDRESS_1, string aDDRESS_2, string aDDRESS_3, string cITY, string sTATE, string zIP, string cOUNTRY, string cONTACT_PHONE, string cONTACT_EMAIL, string rEPLACEMENT_SERIAL_NUM, Nullable<bool> rETURNED, Nullable<System.DateTime> rETURNED_DATE)
        {
            var rEPAIR_IDParameter = rEPAIR_ID.HasValue ?
                new ObjectParameter("REPAIR_ID", rEPAIR_ID) :
                new ObjectParameter("REPAIR_ID", typeof(int));
    
            var eQUIPMENT_IDParameter = eQUIPMENT_ID.HasValue ?
                new ObjectParameter("EQUIPMENT_ID", eQUIPMENT_ID) :
                new ObjectParameter("EQUIPMENT_ID", typeof(int));
    
            var rEQUESTED_BYParameter = rEQUESTED_BY != null ?
                new ObjectParameter("REQUESTED_BY", rEQUESTED_BY) :
                new ObjectParameter("REQUESTED_BY", typeof(string));
    
            var rMA_NUMParameter = rMA_NUM != null ?
                new ObjectParameter("RMA_NUM", rMA_NUM) :
                new ObjectParameter("RMA_NUM", typeof(string));
    
            var sHIPPED_DATEParameter = sHIPPED_DATE.HasValue ?
                new ObjectParameter("SHIPPED_DATE", sHIPPED_DATE) :
                new ObjectParameter("SHIPPED_DATE", typeof(System.DateTime));
    
            var tRACKING_NUMParameter = tRACKING_NUM != null ?
                new ObjectParameter("TRACKING_NUM", tRACKING_NUM) :
                new ObjectParameter("TRACKING_NUM", typeof(string));
    
            var rECIPIENTParameter = rECIPIENT != null ?
                new ObjectParameter("RECIPIENT", rECIPIENT) :
                new ObjectParameter("RECIPIENT", typeof(string));
    
            var aDDRESS_1Parameter = aDDRESS_1 != null ?
                new ObjectParameter("ADDRESS_1", aDDRESS_1) :
                new ObjectParameter("ADDRESS_1", typeof(string));
    
            var aDDRESS_2Parameter = aDDRESS_2 != null ?
                new ObjectParameter("ADDRESS_2", aDDRESS_2) :
                new ObjectParameter("ADDRESS_2", typeof(string));
    
            var aDDRESS_3Parameter = aDDRESS_3 != null ?
                new ObjectParameter("ADDRESS_3", aDDRESS_3) :
                new ObjectParameter("ADDRESS_3", typeof(string));
    
            var cITYParameter = cITY != null ?
                new ObjectParameter("CITY", cITY) :
                new ObjectParameter("CITY", typeof(string));
    
            var sTATEParameter = sTATE != null ?
                new ObjectParameter("STATE", sTATE) :
                new ObjectParameter("STATE", typeof(string));
    
            var zIPParameter = zIP != null ?
                new ObjectParameter("ZIP", zIP) :
                new ObjectParameter("ZIP", typeof(string));
    
            var cOUNTRYParameter = cOUNTRY != null ?
                new ObjectParameter("COUNTRY", cOUNTRY) :
                new ObjectParameter("COUNTRY", typeof(string));
    
            var cONTACT_PHONEParameter = cONTACT_PHONE != null ?
                new ObjectParameter("CONTACT_PHONE", cONTACT_PHONE) :
                new ObjectParameter("CONTACT_PHONE", typeof(string));
    
            var cONTACT_EMAILParameter = cONTACT_EMAIL != null ?
                new ObjectParameter("CONTACT_EMAIL", cONTACT_EMAIL) :
                new ObjectParameter("CONTACT_EMAIL", typeof(string));
    
            var rEPLACEMENT_SERIAL_NUMParameter = rEPLACEMENT_SERIAL_NUM != null ?
                new ObjectParameter("REPLACEMENT_SERIAL_NUM", rEPLACEMENT_SERIAL_NUM) :
                new ObjectParameter("REPLACEMENT_SERIAL_NUM", typeof(string));
    
            var rETURNEDParameter = rETURNED.HasValue ?
                new ObjectParameter("RETURNED", rETURNED) :
                new ObjectParameter("RETURNED", typeof(bool));
    
            var rETURNED_DATEParameter = rETURNED_DATE.HasValue ?
                new ObjectParameter("RETURNED_DATE", rETURNED_DATE) :
                new ObjectParameter("RETURNED_DATE", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SYS_UPDATE_REPAIRS", rEPAIR_IDParameter, eQUIPMENT_IDParameter, rEQUESTED_BYParameter, rMA_NUMParameter, sHIPPED_DATEParameter, tRACKING_NUMParameter, rECIPIENTParameter, aDDRESS_1Parameter, aDDRESS_2Parameter, aDDRESS_3Parameter, cITYParameter, sTATEParameter, zIPParameter, cOUNTRYParameter, cONTACT_PHONEParameter, cONTACT_EMAILParameter, rEPLACEMENT_SERIAL_NUMParameter, rETURNEDParameter, rETURNED_DATEParameter);
        }
    }
}
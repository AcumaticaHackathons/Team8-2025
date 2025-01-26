using System;
using PX.Data;

namespace HackathonCore
{
    [Serializable]
    [PXCacheName("UpgradeReportObjectDetail")]
    public class UpgradeReportObjectDetail : PXBqlTable, IBqlTable
    {
        #region UpgradeReportID
        [PXDBInt()]
        [PXUIField(DisplayName = "Upgrade Report ID")]
        public virtual int? UpgradeReportID { get; set; }
        public abstract class upgradeReportID : PX.Data.BQL.BqlInt.Field<upgradeReportID> { }
        #endregion

        #region ObjectID
        [PXDBInt()]
        [PXUIField(DisplayName = "Upgrade Object ID")]
        public virtual int? ObjectID { get; set; }
        public abstract class objectID : PX.Data.BQL.BqlInt.Field<objectID> { }
        #endregion

        #region DetailID
        [PXDBIdentity(IsKey = true)]
        public virtual int? DetailID { get; set; }
        public abstract class detailID : PX.Data.BQL.BqlInt.Field<detailID> { }
        #endregion

        #region Cachetype
        [PXDBString(255, InputMask = "")]
        [PXUIField(DisplayName = "Cache")]
        public virtual string Cachetype { get; set; }
        public abstract class cachetype : PX.Data.BQL.BqlString.Field<cachetype> { }
        #endregion

        #region Cachefield
        [PXDBString(255, InputMask = "")]
        [PXUIField(DisplayName = "Cache field")]
        public virtual string Cachefield { get; set; }
        public abstract class cachefield : PX.Data.BQL.BqlString.Field<cachefield> { }
        #endregion


        #region ReleaseNotes
        [PXDBString(255, InputMask = "")]
        [PXUIField(DisplayName = "Release Notes")]
        public virtual string ReleaseNotes { get; set; }
        public abstract class releaseNotes : PX.Data.BQL.BqlString.Field<releaseNotes> { }
        #endregion

        #region CreatedByID
        [PXDBCreatedByID()]
        public virtual Guid? CreatedByID { get; set; }
        public abstract class createdByID : PX.Data.BQL.BqlGuid.Field<createdByID> { }
        #endregion

        #region CreatedByScreenID
        [PXDBCreatedByScreenID()]
        public virtual string CreatedByScreenID { get; set; }
        public abstract class createdByScreenID : PX.Data.BQL.BqlString.Field<createdByScreenID> { }
        #endregion

        #region CreatedDateTime
        [PXDBCreatedDateTime()]
        public virtual DateTime? CreatedDateTime { get; set; }
        public abstract class createdDateTime : PX.Data.BQL.BqlDateTime.Field<createdDateTime> { }
        #endregion

        #region LastModifiedByID
        [PXDBLastModifiedByID()]
        public virtual Guid? LastModifiedByID { get; set; }
        public abstract class lastModifiedByID : PX.Data.BQL.BqlGuid.Field<lastModifiedByID> { }
        #endregion

        #region LastModifiedByScreenID
        [PXDBLastModifiedByScreenID()]
        public virtual string LastModifiedByScreenID { get; set; }
        public abstract class lastModifiedByScreenID : PX.Data.BQL.BqlString.Field<lastModifiedByScreenID> { }
        #endregion

        #region LastModifiedDateTime
        [PXDBLastModifiedDateTime()]
        public virtual DateTime? LastModifiedDateTime { get; set; }
        public abstract class lastModifiedDateTime : PX.Data.BQL.BqlDateTime.Field<lastModifiedDateTime> { }
        #endregion

        #region Noteid
        [PXNote()]
        public virtual Guid? Noteid { get; set; }
        public abstract class noteid : PX.Data.BQL.BqlGuid.Field<noteid> { }
        #endregion
    }
}
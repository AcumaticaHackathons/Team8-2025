using System;
using PX.Data;

namespace HackathonCore
{
    [Serializable]
    [PXCacheName("UpgradeReportObject")]
    public class UpgradeReportObject : PXBqlTable, IBqlTable
    {
        #region UpgradeReportID
        [PXDBInt()]
        [PXUIField(DisplayName = "Upgrade Report ID")]
        public virtual int? UpgradeReportID { get; set; }
        public abstract class upgradeReportID : PX.Data.BQL.BqlInt.Field<upgradeReportID> { }
        #endregion

        #region ObjectID
        [PXDBIdentity(IsKey = true)]
        [PXUIField(DisplayName = "Upgrade Object ID")]
        public virtual int? ObjectID { get; set; }
        public abstract class objectID : PX.Data.BQL.BqlInt.Field<objectID> { }
        #endregion

        #region ObjectName
        [PXDBString(255, InputMask = "")]
        [PXUIField(DisplayName = "Object Name")]
        public virtual string ObjectName { get; set; }
        public abstract class objectName : PX.Data.BQL.BqlString.Field<objectName> { }
        #endregion

        #region ScreenID
        [PXDBString(8, InputMask = "")]
        [PXUIField(DisplayName = "Screen ID")]
        public virtual string ScreenID { get; set; }
        public abstract class screenID : PX.Data.BQL.BqlString.Field<screenID> { }
        #endregion

        #region ObjectType
        [PXDBString(1, InputMask = "")]
        [PXUIField(DisplayName = "Object Type")]
        public virtual string ObjectType { get; set; }
        public abstract class objectType : PX.Data.BQL.BqlString.Field<objectType> { }
        #endregion

        #region UpgradeStatus
        [PXDBString(1, InputMask = "")]
        [PXUIField(DisplayName = "Upgrade Status")]
        public virtual string UpgradeStatus { get; set; }
        public abstract class upgradeStatus : PX.Data.BQL.BqlString.Field<upgradeStatus> { }
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
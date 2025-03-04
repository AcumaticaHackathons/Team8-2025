﻿using System;
using PX.Data;

namespace HackathonCore
{
    [Serializable]
    [PXCacheName("UpgradeReport")]
    public class UpgradeReport : PXBqlTable, IBqlTable
    {
        #region UpgradeReportID
        [PXDBIdentity(IsKey = true)]
        public virtual int? UpgradeReportID { get; set; }
        public abstract class upgradeReportID : PX.Data.BQL.BqlInt.Field<upgradeReportID> { }
        #endregion

        #region CurrentVersion
        [PXDBString(20, InputMask = "")]
        [PXUIField(DisplayName = "Current Version")]
        public virtual string CurrentVersion { get; set; }
        public abstract class currentVersion : PX.Data.BQL.BqlString.Field<currentVersion> { }
        #endregion

        #region PreviousVersion
        [PXDBString(20, InputMask = "")]
        [PXUIField(DisplayName = "Previous Version")]
        public virtual string PreviousVersion { get; set; }
        public abstract class previousVersion : PX.Data.BQL.BqlString.Field<previousVersion> { }
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
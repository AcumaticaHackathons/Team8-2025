using System;
using PX.Data;

namespace HackathonCore
{
    [Serializable]
    [PXCacheName("VERSIONHistoryView")]
    public class VERSIONHistoryView : PXBqlTable, IBqlTable
    {
        #region DatabaseID
        [PXDBInt()]
        [PXUIField(DisplayName = "Database ID")]
        public virtual int? DatabaseID { get; set; }
        public abstract class databaseID : PX.Data.BQL.BqlInt.Field<databaseID> { }
        #endregion

        #region ComponentName
        [PXDBString(100, InputMask = "")]
        [PXUIField(DisplayName = "Component Name")]
        public virtual string ComponentName { get; set; }
        public abstract class componentName : PX.Data.BQL.BqlString.Field<componentName> { }
        #endregion

        #region ComponentType
        [PXDBString(1, InputMask = "")]
        [PXUIField(DisplayName = "Component Type")]
        public virtual string ComponentType { get; set; }
        public abstract class componentType : PX.Data.BQL.BqlString.Field<componentType> { }
        #endregion

        #region Version
        [PXDBString(20, InputMask = "")]
        [PXUIField(DisplayName = "Version")]
        public virtual string Version { get; set; }
        public abstract class version : PX.Data.BQL.BqlString.Field<version> { }
        #endregion

        #region Date
        [PXDBDate()]
        [PXUIField(DisplayName = "Date")]
        public virtual DateTime? Date { get; set; }
        public abstract class date : PX.Data.BQL.BqlDateTime.Field<date> { }
        #endregion

        #region Hash
        [PXDBInt()]
        [PXUIField(DisplayName = "Hash")]
        public virtual int? Hash { get; set; }
        public abstract class hash : PX.Data.BQL.BqlInt.Field<hash> { }
        #endregion

        #region Altered
        [PXDBDate()]
        [PXUIField(DisplayName = "Altered")]
        public virtual DateTime? Altered { get; set; }
        public abstract class altered : PX.Data.BQL.BqlDateTime.Field<altered> { }
        #endregion
    }
}
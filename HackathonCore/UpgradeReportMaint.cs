using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PX.Data;

using PX.Common;
using PX.Data.BQL;
using PX.Data.BQL.Fluent;
using PX.Objects.CN.Common.Extensions;
using static PX.Objects.FA.FABookSettings.midMonthType;

namespace HackathonCore
{
    public class UpgradeReportMaint : PXGraph<UpgradeReportMaint, UpgradeReport>
    {

        [PXViewName("UpgradeReport")]
        public SelectFrom<UpgradeReport>.View UpgradeReportRecords;
        [PXViewName("UpgradeReportObject")]
        [PXImport(typeof(UpgradeReportObject))]
        public PXSelect<UpgradeReportObject,
            Where<UpgradeReportObject.upgradeReportID, Equal<Current<UpgradeReport.upgradeReportID>>>,
            OrderBy<Asc<UpgradeReportObject.screenID>>> UpgradeReportObjectRecords;
        [PXHidden]
        [PXViewName("UpgradeReportObjectDetail")]
        [PXImport(typeof(UpgradeReportObjectDetail))]
        public PXSelect<UpgradeReportObjectDetail, Where<UpgradeReportObjectDetail.objectID, Equal<Current<UpgradeReportObject.objectID>>>> DetailsSelect;


        /// <summary>
        /// Prod. Order Link grid
        /// </summary>
        /// 
        #region CACHE ATTACHED

        #endregion

    }
}

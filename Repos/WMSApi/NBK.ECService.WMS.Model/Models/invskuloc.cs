using System;
using System.Collections.Generic;
using Abp.Domain.Entities;

namespace NBK.ECService.WMS.Model.Models
{
    public partial class invskuloc : SysIdEntity
    { 
        public System.Guid WareHouseSysId { get; set; }
        public System.Guid SkuSysId { get; set; }
        public string Loc { get; set; }
        public int Qty { get; set; }
        public int AllocatedQty { get; set; }
        public int PickedQty { get; set; }
        public long CreateBy { get; set; }
        public System.DateTime CreateDate { get; set; }
        public long UpdateBy { get; set; }
        public System.DateTime UpdateDate { get; set; }

        public string UpdateUserName { get; set; }
        public string CreateUserName { get; set; }

        public int FrozenQty { get; set; }
    }
}
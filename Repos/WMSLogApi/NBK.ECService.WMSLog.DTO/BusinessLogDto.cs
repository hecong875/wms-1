﻿using NBK.ECService.WMSLog.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NBK.ECService.WMSLog.DTO
{
    public class BusinessLogDto
    {
        public Guid access_log_sysId { get; set; }
        public Guid? doc_sysId { get; set; }
        public string doc_order { get; set; }
        public string business_type { get; set; }
        public string business_name { get; set; }
        public string business_operation { get; set; }
        public string user_id { get; set; }
        public string user_name { get; set; }
        public string descr { get; set; }
        public string request_json { get; set; }
        public string old_json { get; set; }
        public string new_json { get; set; }
        public DateTime create_date { get; set; }
        public string create_date_text { get { return create_date.ToString(PublicConst.DateTimeFormat); } }
        public bool flag { get; set; }
        public int system_id { get; set; }
    }
}
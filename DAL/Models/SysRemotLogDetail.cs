using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SysRemotLogDetail
    {
        public long LogDetailId { get; set; }
        public long? LogId { get; set; }
        public string? FieldName { get; set; }
        /// <summary>
        /// 1 insert,2 update,3 delete,4 print, preview
        /// </summary>
        public byte? LogType { get; set; }
        public string? FieldOldValue { get; set; }
        public string? FieldNewValue { get; set; }

        public virtual SysRemotTranLog? Log { get; set; }
    }
}

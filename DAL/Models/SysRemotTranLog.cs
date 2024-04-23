using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SysRemotTranLog
    {
        public SysRemotTranLog()
        {
            SysRemotLogDetails = new HashSet<SysRemotLogDetail>();
        }

        public long LogId { get; set; }
        public string? TableCode { get; set; }
        public int? TableEntityId { get; set; }
        public DateTime? LogTime { get; set; }
        public int? StoreId { get; set; }
        /// <summary>
        /// 1 insert,2 update,3 delete
        /// </summary>
        public byte? LogType { get; set; }
        public int? UserId { get; set; }
        public byte[]? LogTimStamp { get; set; }
        public bool? RemotExecuted { get; set; }
        public bool? IsMasterFile { get; set; }

        public virtual ICollection<SysRemotLogDetail> SysRemotLogDetails { get; set; }
    }
}

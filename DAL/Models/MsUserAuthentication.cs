using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsUserAuthentication
    {
        public int AuthId { get; set; }
        public int? UserId { get; set; }
        public string? AuthCode { get; set; }
        public string? AuthName { get; set; }
        public string? AuthDesc { get; set; }
        public bool? Authinticated { get; set; }
        /// <summary>
        /// the Id of the user who athurized to give this authentication
        /// </summary>
        public int? AuthenticatedBy { get; set; }
    }
}

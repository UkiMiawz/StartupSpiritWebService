//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StartupSpirit.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class SS_Player_Details
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string IpNumber { get; set; }
        public string LastUpdated { get; set; }
        public int Version { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        public virtual SS_Player SS_Player_Id { get; set; }
        public virtual SS_University_Faculty SS_University_Faculty_Id { get; set; }
    }
}
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
    
    public partial class SS_Player
    {
        public SS_Player()
        {
            this.SS_Game_Player_Progress_Id = new HashSet<SS_Game_Player_Progress>();
        }
    
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public System.DateTime LastLogin { get; set; }
        public System.DateTime LastLogout { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public int Version { get; set; }
    
        public virtual SS_Player_Details SS_Player_Details_Id { get; set; }
        public virtual ICollection<SS_Game_Player_Progress> SS_Game_Player_Progress_Id { get; set; }
        public virtual SS_User_Role SS_User_Role_Id { get; set; }
    }
}

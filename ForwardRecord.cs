//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VVUHMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class ForwardRecord
    {
        public int ID { get; set; }
        public string DID { get; set; }
        public string PID { get; set; }
    
        public virtual Patient Patient { get; set; }
        public virtual Staff Staff { get; set; }
    }
}

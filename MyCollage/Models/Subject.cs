//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyCollage.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int FullDegree { get; set; }
        public int DepartmentFk { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
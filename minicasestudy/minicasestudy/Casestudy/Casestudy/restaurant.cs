//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Casestudy
{
    using System;
    using System.Collections.Generic;
    
    public partial class restaurant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public restaurant()
        {
            this.order_food = new HashSet<order_food>();
        }
    
        public int restaurant_id { get; set; }
        public string restaurant_name { get; set; }
        public string rcity { get; set; }
        public string rlocation { get; set; }
        public string details { get; set; }
        public string branch { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order_food> order_food { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRB
{
    using System;
    using System.Collections.Generic;
    
    public partial class OMS_policy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OMS_policy()
        {
            this.Patient = new HashSet<Patient>();
        }
    
        public int id_OMS { get; set; }
        public string region { get; set; }
        public string insurance_company { get; set; }
        public string policy_number { get; set; }
        public System.DateTime start_date { get; set; }
        public System.DateTime end_date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patient> Patient { get; set; }
    }
}

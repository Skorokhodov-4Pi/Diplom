
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
    
public partial class Staff
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Staff()
    {

        this.Electronic_medical_card = new HashSet<Electronic_medical_card>();

    }


    public int id_staff { get; set; }

    public string surname { get; set; }

    public string first_name { get; set; }

    public string patronymic { get; set; }

    public System.DateTime date_birth { get; set; }

    public string SNILS { get; set; }

    public string actual_address { get; set; }

    public string registered_address { get; set; }

    public string phone_number { get; set; }

    public string email { get; set; }

    public int id_departments { get; set; }

    public int id_position { get; set; }

    public string login { get; set; }

    public string password { get; set; }



    public virtual Departments Departments { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Electronic_medical_card> Electronic_medical_card { get; set; }

    public virtual Positions Positions { get; set; }

}

}

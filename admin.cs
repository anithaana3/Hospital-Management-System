//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalManagementSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class admin
    {

        //[DisplayName("User Name")]
        //[Required(ErrorMessage = "Required Field")]
        public string UserName { get; set; }


        //[Required(ErrorMessage = "Required Field")]
        //[DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

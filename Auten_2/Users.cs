//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Auten_2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public int ID_user { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public int ID_role { get; set; }
    
        public virtual RoleTable RoleTable { get; set; }
    }
}

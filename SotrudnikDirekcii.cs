//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProfessionalniiTechnicheskiiYniversitet
{
    using System;
    using System.Collections.Generic;
    
    public partial class SotrudnikDirekcii
    {
        public int ID_SotrudnikDirekcii { get; set; }
        public string FIO_SotrudnikDirekcii { get; set; }
        public int Login { get; set; }
    
        public virtual Polzovatel Polzovatel { get; set; }
    }
}

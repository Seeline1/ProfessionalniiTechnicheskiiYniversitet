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
    
    public partial class AttestaciyaStud
    {
        public int ID_Student { get; set; }
        public int ID_Predmet { get; set; }
        public int Itogo { get; set; }
        public int Ocenka { get; set; }
    
        public virtual Predmet Predmet { get; set; }
        public virtual Student Student { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Politics
{
    using System;
    using System.Collections.Generic;
    
    public partial class candidates_lists
    {
        public int id { get; set; }
        public int election_id { get; set; }
        public int candidate_id { get; set; }
        public int votes { get; set; }
    
        public virtual candidates candidates { get; set; }
        public virtual elections elections { get; set; }
    }
}
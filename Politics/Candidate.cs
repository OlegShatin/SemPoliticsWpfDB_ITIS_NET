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
    
    public partial class Candidate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Candidate()
        {
            this.ElectionsResults = new HashSet<CandidateOnElection>();
        }
    
        public int Id { get; set; }
        public Nullable<int> PartyId { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public string Achievements { get; set; }
        public string ElectionProgram { get; set; }
        public string ImageSrc { get; set; }
        public int AgentId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CandidateOnElection> ElectionsResults { get; set; }
        public virtual Party Party { get; set; }
        public virtual User Agent { get; set; }
    }
}

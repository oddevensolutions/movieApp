//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoviesDataAccessLayes.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblMovy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblMovy()
        {
            this.tblMovieActors = new HashSet<tblMovieActor>();
        }
    
        public int MovieID { get; set; }
        public string Name { get; set; }
        public short YearOfRelease { get; set; }
        public string Plot { get; set; }
        public string PosterContentType { get; set; }
        public byte[] Poster { get; set; }
        public int ProducerID { get; set; }
    
        public virtual tblFilmCrew tblFilmCrew { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMovieActor> tblMovieActors { get; set; }
    }
}

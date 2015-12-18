//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Datamodel
{
    using System;
    using System.Collections.Generic;
    
    public partial class SectionMaster
    {
        public SectionMaster()
        {
            this.Downloads = new HashSet<Download>();
            this.PhotoGalleries = new HashSet<PhotoGallery>();
            this.Testimonials = new HashSet<Testimonial>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> SectionType { get; set; }
    
        public virtual ICollection<Download> Downloads { get; set; }
        public virtual ICollection<PhotoGallery> PhotoGalleries { get; set; }
        public virtual ICollection<Testimonial> Testimonials { get; set; }
    }
}

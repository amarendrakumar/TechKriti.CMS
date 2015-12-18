﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TechKritiCMSEntities : DbContext
    {
        public TechKritiCMSEntities()
            : base("name=TechKritiCMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Category> Categories { get; set; }
        public DbSet<CurrentOpening> CurrentOpenings { get; set; }
        public DbSet<DownloadAttachment> DownloadAttachments { get; set; }
        public DbSet<Download> Downloads { get; set; }
        public DbSet<MainCategory> MainCategories { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionsInRole> PermissionsInRoles { get; set; }
        public DbSet<PhotoGallery> PhotoGalleries { get; set; }
        public DbSet<PhotoGalleryAttachment> PhotoGalleryAttachments { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SectionMaster> SectionMasters { get; set; }
        public DbSet<SectorAttachment> SectorAttachments { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<SelectionCriteria> SelectionCriterias { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<TestimonialAttachment> TestimonialAttachments { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
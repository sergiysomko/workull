//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Workull
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;
    using Models.Report;

    public partial class Project
    {
        public ReportGenerator ReportGen {protected get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Project()
        {
            this.PersonProjectRelations = new HashSet<PersonProjectRelation>();
            this.ProjectComments = new HashSet<ProjectComment>();
            this.Tasks = new HashSet<Task>();

            this.ReportGen = new HtmlReportGenerator();
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime StartDate { get; set; }
        public int Creator { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonProjectRelation> PersonProjectRelations { get; set; }
        public virtual Person Person { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectComment> ProjectComments { get; set; }
        public virtual ProjectStatus ProjectStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task> Tasks { get; set; }

        public ActionResult GetReport()
        {
            return ReportGen.GetReport();
        }
        
    }
}

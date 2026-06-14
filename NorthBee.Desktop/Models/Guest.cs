namespace NorthBee.Desktop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Guest")]
    public partial class Guest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Guest()
        {
            History = new HashSet<History>();
        }

        [Key]
        public int IdGuest { get; set; }

        public bool IsNew => IdGuest == 0;

        [Required]
        [StringLength(150)]
        public string FullName { get; set; }

        [Column(TypeName = "date")]
        public DateTime Birthday { get; set; }

        public int GenderId { get; set; }

        public int StatusId { get; set; }

        public virtual Gender Gender { get; set; }

        public virtual Status Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<History> History { get; set; }
    }
}

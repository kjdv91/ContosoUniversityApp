using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        
        [StringLength(50, MinimumLength = 2,ErrorMessage ="El nombre no puede exceder los 50 caracteres")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", 
            ErrorMessage ="Debe comenzar Mayuscula y no puede contener caracteres especiales")]
        [Required, Display(Name = "Nombre") ]
        
        public string Name { get; set; }
        [StringLength(50, MinimumLength = 2,ErrorMessage = "El apellido no puede exceder los 50 caracteres")]

        [Required, Display(Name = "Apellido")]
        public string LastName { get; set; }
        
        [DataType(DataType.Date, ErrorMessage ="El formato de fecha no es el correcto ej:2022-10-31")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Column("FechaInscripcion")]  //la columna EnrollmentDate se llamará FechaInscripcion en la db       
        [Display(Name ="Fecha de Inscripcion")]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Nombre Completo")]
        public string FullName
        {
            get
            {
                return Name + ", " + LastName;
            }
        }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationBatchDemo
{
    public class Employee
    {
        //Annotation Id
        [Range(1,100,ErrorMessage ="Only 100 Employee")]
        public int Id { get; set; }

        //Annotation Name
        [Required(ErrorMessage ="Employee{0} is requried")]
        [StringLength(100,MinimumLength =3,ErrorMessage = "Name Should be minimum 3 charactor and a maximum of 100 charactor")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        //Annotation Age
        [Range(18,30,ErrorMessage = "Age should be above 18")]
        public int Age { get; set; }

        //Annotation Phone
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }

        //Annotation Email
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationBatchDemo
{
    public class AnnotationClass
    {
        public void DisplayMthod()
        {
            Console.WriteLine("Employee Validation Information using Annotation");
            Employee employee = new Employee();
            //Validation data
            employee.Id=1;
            employee.Name="Sn";
            employee.Age=24;
            employee.PhoneNumber="1234567890";
            employee.Email="bansodsnehal@gmail.com";

            ////inbuil class for validation to pass objet service and dictionary,
            ////if serivce and dictionaries are not used we can make it as null.
            ValidationContext validationContext = new ValidationContext(employee, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();

            /*Validator - class Determines whether the specified object is valid using the validation context
             and validation results collection*/
            bool valid = Validator.TryValidateObject(employee, validationContext, validationResults, true);
            if (!valid)
            {
                ////foreach loop is used to transversal the date if error occurs prints the message in different colours.
                foreach(ValidationResult result in validationResults)
                {
                    Console.WriteLine("Member Name :"+result.MemberNames.FirstOrDefault());
                    Console.WriteLine("Error msg :: {0}{1}", result.ErrorMessage, Environment.NewLine);//Environment.new line = space
                }
            }
            else
            { 
                Console.WriteLine("Id "+employee.Id +"\n"+"Name : " +employee.Name+"\n"+"Age :"+employee.Age+"\n"+"Phone number :"+employee.PhoneNumber+"\n"+"Email :"+employee.Email);
            }
            //// toprint the console in our with colour
            Console.WriteLine("\n Press any key to exit");
            Console.ReadKey();
        }
    }
}

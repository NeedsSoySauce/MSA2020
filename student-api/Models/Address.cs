using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace student_api.Models
{
    public class Address
    {

        /*        
         * Create another table named Address with attributes: StudentId, Street Number, Street, 
         * Suburb, City, Postcode and Country.The Student table would have a one-to-many 
         * relationship with this table. Please assign appropriate datatype (i.e. string, int etc.) 
         * for each of the attributes.
         */

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int addressId { get; set; }

        // I'm assuming that street numbers are only numbers in this case rather than something like "17b"
        public int streetNumber { get; set; }
        public string street {get; set; }
        public string city { get; set; }
        public int postcode { get; set; }
        public string country { get; set; }

        // Multiple addresses can be related to a single student
        public int studentId { get; set; }
        [JsonIgnore]
        public Student student { get; set; }

    }
}

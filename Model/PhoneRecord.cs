using System;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [Serializable]
    public class PhoneRecord
    {
        
        public int Id { get; set; }

        [Required]
        public string LastName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }
}

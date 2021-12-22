using System;

namespace Models
{
    public class UserUpdateDto
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string document { get; set; }
        public int age { get; set; }
        public char companyOrPerson { get; set; }
    }
}

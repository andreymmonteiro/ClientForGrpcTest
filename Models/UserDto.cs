using System;

namespace Models
{
    public class UserDto
    {
        public Guid id { get; set; }
        public DateTime createDate { get; set; }
        public DateTime updateDate { get; set; }
        public string name { get; set; }
        public string document { get; set; }
        public int age { get; set; }
        public char companyOrPerson { get; set; }
    }
}

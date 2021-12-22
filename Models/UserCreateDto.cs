namespace Models
{
    public class UserCreateDto
    {
        public string name { get; set; }
        public string document { get; set; }
        public int age { get; set; }
        public char companyOrPerson { get; set; }
    }
}

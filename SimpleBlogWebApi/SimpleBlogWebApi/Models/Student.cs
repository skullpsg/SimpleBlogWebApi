namespace SimpleBlogWebApi.Models
{
    public class Student
    {
        public string id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public PersonSex sex { get; set; }
        public string standard { get; set; }
    }

    public enum PersonSex
    {
        male = 0,
        female
    }
}
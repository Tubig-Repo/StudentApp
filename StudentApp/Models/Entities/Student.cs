namespace StudentApp.Models.Entities
{
    public class Student
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool paymentStatus { get; set; }
    }
}

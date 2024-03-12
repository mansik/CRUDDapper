namespace CRUDDapper.Models
{
    // 반드시 public로 선언해야 DataGridView에 데이터 원본 선택시 나타난다.
    public class Student
    {
        public int StudentID { get; set; }
        public string? FullName { get; set; }
        public bool Gender { get; set; }
        public string? Birthday { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? ImageUrl { get; set; }

    }
}

namespace LPU_Entity
{
    public class Student
    {
        public enum CourseType
        {
            Mechanical,
            Electrical,
            Civil,
            CSE,
            IT
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public CourseType Course { get; set; } //Property of Type Enum
        public string Address { get; set; }
    }
}

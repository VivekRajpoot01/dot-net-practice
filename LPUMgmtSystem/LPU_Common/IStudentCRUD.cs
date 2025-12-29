using LPU_Entity;

namespace LPU_Common
{
    public interface IStudentCRUD
    {
        Student SearchStudentById(int rollNo);
        List<Student> SearchStudentByName(string name);

        bool EnrollStudent(Student sObj);

        bool UpdateStudentDetails(int id, Student newObj);

        bool DropStudentDetails(int id);
    }
}

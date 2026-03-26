using backend.Models;
using backend.Repositories.Interfaces;

namespace backend.Services
{
    public class StudentService
    {
        private readonly IStudentRepository _repo;

        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Student>> GetAllAsync() => await _repo.GetAllAsync();

        public async Task<Student?> GetByIdAsync(int id) => await _repo.GetByIdAsync(id);

        public async Task AddAsync(Student student) => await _repo.AddAsync(student);

        public async Task<bool> UpdateAsync(int id, Student student)
        {
            var existing = await _repo.GetByIdAsync(id);
            if (existing == null) return false;

            existing.Name = student.Name;
            existing.Age = student.Age;
            existing.Course = student.Course;

            await _repo.UpdateAsync(existing);
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var student = await _repo.GetByIdAsync(id);
            if (student == null) return false;

            await _repo.DeleteAsync(student);
            return true;
        }
    }
}
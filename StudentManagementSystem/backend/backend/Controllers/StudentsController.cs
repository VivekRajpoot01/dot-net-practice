using AutoMapper;
using backend.DTOs;
using backend.Models;
using backend.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class StudentsController : ControllerBase
    {
        private readonly StudentService _service;
        private readonly IMapper _mapper;

        public StudentsController(StudentService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var students = await _service.GetAllAsync();
            return Ok(_mapper.Map<List<StudentResponseDTO>>(students));
        }

        [HttpPost]
        public async Task<IActionResult> Create(StudentCreateDTO dto)
        {
            var student = _mapper.Map<Student>(dto);
            await _service.AddAsync(student);
            return Ok(student);
        }
    }
}
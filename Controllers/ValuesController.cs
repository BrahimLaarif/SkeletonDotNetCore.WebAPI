using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SkeletonDotNetCore.WebAPI.Data;
using SkeletonDotNetCore.WebAPI.Data.Repositories;
using SkeletonDotNetCore.WebAPI.DTOs;
using SkeletonDotNetCore.WebAPI.Models;

namespace SkeletonDotNetCore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IValueRepository _repository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public ValuesController(IValueRepository repository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var values = await _repository.GetValues();

            return Ok(_mapper.Map<List<ValueDTO>>(values));
        }

        // GET api/values/5
        [HttpGet("{id}", Name = nameof(Get))]
        public async Task<IActionResult> Get(int id)
        {
            var value = await _repository.GetValue(id);

            if (value == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ValueDTO>(value));
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateValueDTO createValueDTO)
        {
            var value = _mapper.Map<Value>(createValueDTO);

            _repository.Add(value);
            await _unitOfWork.CompleteAsync();

            return CreatedAtRoute(nameof(Get), new { id = value.Id }, _mapper.Map<ValueDTO>(value));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateValueDTO updateValueDTO)
        {
            var value = await _repository.GetValue(id);

            if (value == null)
            {
                return NotFound();
            }

            _mapper.Map<UpdateValueDTO, Value>(updateValueDTO, value);

            _repository.Update(value);
            await _unitOfWork.CompleteAsync();

            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var value = await _repository.GetValue(id);

            if (value == null)
            {
                return NotFound();
            }

            _repository.Remove(value);
            await _unitOfWork.CompleteAsync();

            return NoContent();
        }
    }
}

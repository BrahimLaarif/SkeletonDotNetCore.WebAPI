using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SkeletonDotNetCore.WebAPI.Core;
using SkeletonDotNetCore.WebAPI.Core.Models;
using SkeletonDotNetCore.WebAPI.DTOs;

namespace SkeletonDotNetCore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IValueRepository _valueRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public ValuesController(IValueRepository valueRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _valueRepository = valueRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var values = await _valueRepository.GetValues();

            return Ok(_mapper.Map<List<ValueDTO>>(values));
        }

        // GET api/values/5
        [HttpGet("{id}", Name = nameof(Get))]
        public async Task<IActionResult> Get(int id)
        {
            var value = await _valueRepository.GetValue(id);

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

            _valueRepository.Add(value);
            await _unitOfWork.CompleteAsync();

            return CreatedAtRoute(nameof(Get), new { id = value.Id }, _mapper.Map<ValueDTO>(value));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateValueDTO updateValueDTO)
        {
            var value = await _valueRepository.GetValue(id);

            if (value == null)
            {
                return NotFound();
            }

            _mapper.Map<UpdateValueDTO, Value>(updateValueDTO, value);

            _valueRepository.Update(value);
            await _unitOfWork.CompleteAsync();

            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var value = await _valueRepository.GetValue(id);

            if (value == null)
            {
                return NotFound();
            }

            _valueRepository.Remove(value);
            await _unitOfWork.CompleteAsync();

            return NoContent();
        }
    }
}

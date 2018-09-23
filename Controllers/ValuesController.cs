using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SkeletonDotNetCore.WebAPI.Data;
using SkeletonDotNetCore.WebAPI.DTOs;
using SkeletonDotNetCore.WebAPI.Models;

namespace SkeletonDotNetCore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ISkeletonRepository _repo;
        private readonly IMapper _mapper;

        public ValuesController(ISkeletonRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var values = await _repo.GetValues();

            return Ok(_mapper.Map<List<ViewValueDTO>>(values));
        }

        // GET api/values/5
        [HttpGet("{id}", Name = nameof(Get))]
        public async Task<IActionResult> Get(int id)
        {
            var value = await _repo.GetValue(id);

            if (value == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ViewValueDTO>(value));
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddValueDTO addValueDTO)
        {
            var value = _mapper.Map<Value>(addValueDTO);

            _repo.Add(value);
            await _repo.SaveAll();

            return CreatedAtRoute(nameof(Get), new { id = value.Id }, _mapper.Map<ViewValueDTO>(value));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] EditValueDTO editValueDTO)
        {
            var value = await _repo.GetValue(id);

            if (value == null)
            {
                return NotFound();
            }

            _mapper.Map<EditValueDTO, Value>(editValueDTO, value);

            _repo.Update(value);
            await _repo.SaveAll();

            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var value = await _repo.GetValue(id);

            if (value == null)
            {
                return NotFound();
            }

            _repo.Remove(value);
            await _repo.SaveAll();

            return NoContent();
        }
    }
}

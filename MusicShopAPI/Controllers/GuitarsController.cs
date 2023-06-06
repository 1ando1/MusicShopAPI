using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Music_Shop.Models;
using Business.Interfaces;
using Business.DTOs;

namespace MusicShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuitarsController : ControllerBase
    {
        private readonly MusicShopDbContext context;
        private readonly IGuitarService guitarService;

        public GuitarsController(MusicShopDbContext context, IGuitarService guitarService)
        {
            this.context = context;
            this.guitarService = guitarService;
        }

        [HttpGet("show-all")]
        public IActionResult ShowAll()
        {
            return Ok(guitarService.ShowAll());
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] GuitarDTO guitar)
        {
            if (!ModelState.IsValid) return BadRequest();

            guitarService.Add(guitar);
            return Ok();
        }

        [HttpPut]
        public IActionResult Edit([FromBody] GuitarDTO guitar)
        {
            if (!ModelState.IsValid) return BadRequest();

            guitarService.Edit(guitar);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            guitarService.Delete(id);

            return Ok();
        }
    }
}

﻿using GalliumPlus.WebApi.Core.Data;
using GalliumPlus.WebApi.Core.Users;
using GalliumPlus.WebApi.Dto;
using GalliumPlus.WebApi.Middleware;
using Microsoft.AspNetCore.Mvc;

namespace GalliumPlus.WebApi.Controllers
{

    [Route("api/users")]
    [ApiController]
    public class UserController : Controller
    {
        private UserSummary.Mapper summaryMapper = new();
        private UserDetails.Mapper detailsMapper = new();

        public UserController(IMasterDao dao) : base(dao) { }

        [HttpGet]
        public IActionResult Get()
        {
            return Json(summaryMapper.FromModel(Dao.Users.Read()));
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            return Json(detailsMapper.FromModel(Dao.Users.Read(id)));
        }

        [HttpPost]
        public IActionResult Post(UserSummary newUser)
        {
            Dao.Users.Create(summaryMapper.ToModel(newUser, Dao));
            return Created();
        }

        [HttpPut("{id}")]
        public IActionResult Put(string id, UserSummary updatedUser)
        {
            Dao.Users.Update(id, summaryMapper.ToModel(updatedUser, Dao));
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            Dao.Users.Delete(id);
            return Ok();
        }

        [HttpPut("{id}/deposit")]
        public IActionResult PutDeposit(string id, [FromBody] double updatedDeposit)
        {
            Dao.Users.UpdateDeposit(id, updatedDeposit);
            return Ok();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventManager.Domain.Dtos;
using EventManager.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace EventManager.Api.Controllers
{
    [Route("api/[controller]")]
    public class LectureController : Controller
    {
        private readonly LectureService _lectureService;

        public LectureController()
        {
            _lectureService = new LectureService();
        }

        [HttpPost]
        [Route("CreateLecture")]
        public IActionResult CreateLecture([FromBody] AddLectureDto addLectureDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(_lectureService.AddLecture(addLectureDto));
        }
    }
}
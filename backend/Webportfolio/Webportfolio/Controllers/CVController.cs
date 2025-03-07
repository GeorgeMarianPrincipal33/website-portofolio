﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Webportfolio.Models;
using Webportfolio.Services;

namespace Webportfolio.Controllers
{
    public class CVController : Controller
    {
        private readonly ICVService cvService;

        public CVController(ICVService cvService)
        {
            this.cvService = cvService;
        }

        [HttpGet]
        public IEnumerable<CV> GetCVs()
        {
            return cvService.GetCVs();
        }
        
        [HttpGet]
        public CV GetCV(int id)
        {
            return cvService.GetCv(id);
        }

        [HttpPut]
        public void UpdateCV([FromBody]CV cv)
        {
            cvService.UpdateCv(cv);
        }
    }
}
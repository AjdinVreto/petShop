﻿using PetShop.Model;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class GradController : BaseReadController<Model.Drzava, object>
    {
        public GradController(IReadService<Drzava, object> service) : base(service)
        {
        }
    }
}

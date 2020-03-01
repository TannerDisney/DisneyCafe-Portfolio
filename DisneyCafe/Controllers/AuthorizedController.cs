using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DisneyCafe.Controllers
{
    [Authorize(Roles = "Administrator, Owner")]
    public class AuthorizedController : Controller
    {

    }
}
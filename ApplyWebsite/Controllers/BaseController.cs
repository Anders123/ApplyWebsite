using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplyWebsite.EfModel;
using Microsoft.AspNetCore.Mvc;

namespace ApplyWebsite.Controllers
{
    public abstract class BaseController : Controller
    {
        protected readonly ApplyDbContext Db;


        protected BaseController(ApplyDbContext db)
        {
            this.Db = db;
        }

        //protected BaseController(FastportDbContext fastportContext, ILogger logger, IMapper mapper)
        //{
        //    FastportContext = fastportContext;
        //    Logger = logger;
        //    Mapper = mapper;
        //}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNTFrameworkCore.TestWebApp.Application.Academy;
using DNTFrameworkCore.TestWebApp.Application.Academy.Models;
using DNTFrameworkCore.TestWebApp.Authorization;
using DNTFrameworkCore.Web.Mvc;
using Microsoft.AspNetCore.Mvc;


namespace DNTFrameworkCore.TestWebApp.Controllers
{
    public class AcademyController : CrudController<IAcademyService, int, AcademyModel>
    {
        public AcademyController(IAcademyService service) : base(service)
        {
        }

        protected override string CreatePermissionName => PermissionNames.Academy_Create;

        protected override string EditPermissionName => PermissionNames.Academy_Edit;

        protected override string ViewPermissionName => PermissionNames.Academy_View;

        protected override string DeletePermissionName => PermissionNames.Academy_Delete;

        protected override string ViewName => "_AcademyModal";

    }



    }

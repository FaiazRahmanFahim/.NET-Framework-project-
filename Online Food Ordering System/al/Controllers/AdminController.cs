﻿using BLL.ModelDTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http;

namespace al.Controllers
{
    public class AdminController : ApiController
    {
        [HttpPost]
        [Route("api/Admin/create")]
        public HttpResponseMessage CreateAdmin(AdminDTOs adminDTOs)
        {
            try
            {
                var data = AdminService.Create(adminDTOs);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { message = ex.Message });
            }
        }


        [HttpPost]
        [Route("api/admin/update")]
        public HttpResponseMessage UpdateAdmin(AdminDTOs adminDTOs)
        {
            try
            {
                var data = AdminService.Update(adminDTOs);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { message = ex.Message });
            }
        }
    }
}
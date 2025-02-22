﻿using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http;

namespace al.Controllers
{
    public class MonthlyIncomeController : ApiController
    {
        [HttpGet]
        [Route("api/monthlyincomes")]
        public HttpResponseMessage AllMonthlyIncomes()
        {
            try
            {
                var data = MonthlyIncomeService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/monthlyincomes/create")]
        public HttpResponseMessage NewMonthlyIncome()
        {
            try
            {
                var data = MonthlyIncomeService.TotalIncomeofMonthCreate();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
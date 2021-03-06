﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SkiSchool.Web.Models;
using SkiSchool.Web.RestHelpers;

namespace SkiSchool.Web.Controllers.Api
{
    public class EmployeesController : ApiController
    {

        private readonly string _clientToken = @"578DB399-7047-4E82-921D-DA51E8F14A4E";

        private string _employeeWithLoginIdUrl = @"http://employeeapi.resortdataservices.com/api/employees/0?loginId={0}&clienttoken={1}";

        private string _employeeWithIdUrl = @"http://employeeapi.resortdataservices.com/api/employees/{0}?loginId=&clienttoken={1}";

        // GET api/employees/5
        public Employee Get(int? loginId, int? id)
        {
            HttpStatusCode httpStatusCode;

            if (id == null)
            {
                var employeeWithLoginIdUri = new Uri(string.Format(_employeeWithLoginIdUrl, loginId, _clientToken));

                var employee = Invoke.Get<Employee>(employeeWithLoginIdUri, out httpStatusCode);

                return employee;
            }

            if (loginId == null)
            {
                var employeeWithIdUri = new Uri(string.Format(_employeeWithIdUrl, id, _clientToken));

                var employee = Invoke.Get<Employee>(employeeWithIdUri, out httpStatusCode);

                return employee;
            }

            return new Employee();
        }
    }
}

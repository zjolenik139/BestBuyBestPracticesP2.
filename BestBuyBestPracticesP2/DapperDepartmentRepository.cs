﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyBestPracticesP2_
{
    public class DapperDepartmentRepository : IDepartmentRepository
    {

        private readonly IDbConnection _conn;

        public DapperDepartmentRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _conn.Query<Department>("SELECT * FROM Departments");
        }

        public void InsertDepartment(string name)
        {
            _conn.Execute("INSERT INTO departments (Name) VALUES (@name)", new { name });
         
        }
    }
}

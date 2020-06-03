using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Demo_Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace Demo_Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestEmployeeController : ControllerBase
    {
        // GET: api/TestEmployee
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            var employees = new List<Employee>();

            string connectionString = "Server = localhost; port = 3307; Database = test; User = root; Password = tvphi1402@";

            // Khoi tao doi tuong Sql Connection 

            MySqlConnection sqlConnection = new MySqlConnection(connectionString);

            // Khoi tao doi tuong Sql Commmand - Cho phep  thao tac voi CSDL



            MySqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

            //Khai bao cau truy van

            sqlCommand.CommandText = "test.Proc_GetEmployees";

            // Mo ket noi toi Database

            sqlConnection.Open();
            //Thuc thi cong viec voi Database
            MySqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            // Xu ly du lieu tra ve

            while (sqlDataReader.Read())
            {
                var employee = new Employee();
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    // Lấy tên cột dữ liệu đang đoc

                    var colName = sqlDataReader.GetName(i);

                    // Lấy giá trị của cell đang đoc

                    var value = sqlDataReader.GetValue(i);



                    //Lấy propety giống với tên cột khia báo ở trên

                    var property = employee.GetType().GetProperty(colName,BindingFlags.Instance |
                       BindingFlags.Public |
                       BindingFlags.IgnoreCase);

                    //Nếu có property tương ứng với tên cột thì gán dữ liệu tương ứng:

                    if (property != null && value != DBNull.Value)

                    {

                        property.SetValue(employee, value);

                    }

                }

                // Them doi tuog khach hang vua build duoc vao list

                employees.Add(employee);

            }

            //Dong kết nối 

            sqlConnection.Close();

            return employees;
        }

        // GET: api/TestEmployee/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TestEmployee
        [HttpPost]
        public int Post([FromBody] Employee employee)
        {
            string connectionString = "Server = localhost; port = 3307; Database = test; User = root; Password = tvphi1402@";
            //Khởi tạo đối tượng MySql Connection
            MySqlConnection conn = new MySqlConnection(connectionString);
            //Đối tượng MySql Command cho phép thao tác với csdl
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //Khai báo câu truy vấn
            cmd.CommandText = "test.Proc_AddEmployees";
            //Mở kết nối tới Database
            conn.Open();
            //Gán giá trị đầu vào
            cmd.Parameters.AddWithValue("EmployeeCode", employee.EmployeeCode);
            cmd.Parameters.AddWithValue("EmployeeName", employee.EmployeeName);
            cmd.Parameters.AddWithValue("Age", employee.Age);
            cmd.Parameters.AddWithValue("Gender", employee.Gender);
            cmd.Parameters.AddWithValue("Phone", employee.Phone);
            cmd.Parameters.AddWithValue("Address", employee.Address);
            //Thực thi công việc
            var result = cmd.ExecuteNonQuery();
            //Đóng kết nối
            conn.Close();
            return result;


        }

        // PUT: api/TestEmployee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

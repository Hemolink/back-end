using Microsoft.AspNetCore.Mvc;
using Npgsql;
using System.Data;

namespace Hemolink.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class SangueController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public SangueController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                tipo,
                nivel_atual,
                prioritario,
                data_atualizacao
                from sangue
               ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            NpgsqlDataReader myReader;
            using (NpgsqlConnection myCon = new NpgsqlConnection(sqlDataSource))
            {
                myCon.Open();
                using(NpgsqlCommand myCommand=new NpgsqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult(table);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesss.Contracts;
using DataAccesss.Entities;
using System.Data;
using System.Data.SqlClient;

namespace DataAccesss.Repositories
{
    public class EmployeeRepository : MasterRepository, IEmployeeRepository
    {
        //Campos
        private string selectAll;
        private string insert;
        private string update;
        private string delete;
        //Propiedades
        //:::

        //Constructores
        public EmployeeRepository()
        {
            selectAll = "select * from employee";
            insert = "insert into Employee values(@idNumber,@name,@mail,@birthday)";
            update = "update Employee set IdNumber=@idNumber,Name=@name,Mail=@mail,Birthday=@birthaday";
            delete = "delete from Employee where idPk=@idPK";
        }

        public int Add(Employee entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idNumber", entity.idNumber));
            parameters.Add(new SqlParameter("@name", entity.name));
            parameters.Add(new SqlParameter("@mail", entity.mail));
            parameters.Add(new SqlParameter("@birthay", entity.birthay));
            return ExecuteNonQuery(insert);
        }

        //Metodos, comportamientos
        public int Adit(Employee entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idPK", entity.idPk));
            parameters.Add(new SqlParameter("@idNumber", entity.idNumber));
            parameters.Add(new SqlParameter("@name", entity.name));
            parameters.Add(new SqlParameter("@mail", entity.mail));
            parameters.Add(new SqlParameter("@birthay", entity.birthay));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<Employee> GetAll()
        {
            
        }

        public int Remove(int idPk)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idPK",idPk));           
            return ExecuteNonQuery(delete);
        }
    }
}

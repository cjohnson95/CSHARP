using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdDbLib {
    public class MajorsController 
    {
        private SqlConnection sqlConn { get; set; }
        public MajorsController(Connection Connection)   // the first connection is the type, which is a class, the second is 
        {
            sqlConn = Connection.SqlConnection;
        }

        public int Remove (int Id)
        {
            var major = GetByPk(Id);
            if(major == null) 
            {
                throw new Exception("Major row not found!");
            }
            var sql = $" Delete Major Where Id = {Id};";
            var cmd = new SqlCommand(sql, sqlConn);
            var rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected;
                        
                       
                        
        }

        public object Remove(Major major) {
            throw new NotImplementedException();
        }

        public int Change(Major major) 
        {
            var sql = " Update Major Set " +
                        $" Code = @Code," +
                        $" Description = @Description," +
                        $" MinSAT = @MinSAT" +  // No single quotes around MinSAT because it is an integer
                        $" Where Id = @Id " ;
            var cmd = new SqlCommand(sql, sqlConn);
            cmd.Parameters.AddWithValue("@Code" major.Code);
            cmd.Parameters.AddWithValue("@Description" major.Description);
            cmd.Parameters.AddWithValue("@MinSAT" major.MinSAT);
            cmd.Parameters.AddWithValue("@Id" major.Id);

            var rowsAffected = cmd.ExecuteNonQuery();
            var reader = cmd.ExecuteReader();
            return rowsAffected;
        }
        
        public int Create(Major major)  // This is the method called Create. Need to do one called change and affect a row in the major table
                                        // Like an update statement in SQL, changing something like the major code or description
        {
            var sql = "INSERT Major (Code, Description, MinSAT)" +
                        $" Values('{major.Code}', '{major.Description}', { major.MinSAT}); ";
            var cmd = new SqlCommand(sql, sqlConn);
            var rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected;
        }

        public List<Major> GetAll() 
        {
            var connStr = "server=localhost\\sqlexpress;database=EdDb;trusted_connection=true;";
            var sqlConn = new SqlConnection(connStr);
            sqlConn.Open();
            if(sqlConn.State != System.Data.ConnectionState.Open) 
            {
                throw new Exception("Connection failed to open!");
            }

            // connection opened fine!
            var majors = new List<Major>();
            var sql = "Select * from Major; ";
            var cmd = new SqlCommand(sql, sqlConn);
            var reader = cmd.ExecuteReader();
            while(reader.Read()) 
            {
                var major = new Major() 
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Code = reader["Code"].ToString(), 
                    Description = reader["Description"].ToString() ,
                    MinSAT = Convert.ToInt32(reader["MinSAT"])
                };
                majors.Add(major);
            }
            reader.Close();
            sqlConn.Close();
            return majors;

        }

        public Major GetByPk(int Id) 
        {
            var sql = $"Select * from Major where Id = @Id;";
            var cmd = new SqlCommand(sql, sqlConn);
            cmd.Parameters.AddWithValue("@Id", Id);
            
            { 
                throw new Exception("Connection failed to open!");
                
            }
            var sql = $"Select * from Major where Id = {Id};";
            var cmd = new SqlCommand(sql, sqlConn);
            var reader = cmd.ExecuteReader();
            
            if (!reader.HasRows) 
            {
                reader.Close();
                
                return null;                                           //this is if we don't find what we're looking for
            }
            reader.Read();
            var major = new Major() 
            {
                Id = Convert.ToInt32(reader["Id"]),
                Code =  reader["Code"].ToString(),
                Description = reader["Description"].ToString(),
                MinSAT = Convert.ToInt32(reader["MinSAT"]) 
            };


            reader.Close();
            
            return major;
           
        }
    }
} 
     
   

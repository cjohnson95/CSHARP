using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using EdDbLib;

namespace CSharp_Sql_Tutorial {
    public class Program {
        public static void Main(string[] args) {
            var connectionString
                = "server=localhost\\sqlexpress;database=EdDb;trusted_connection=true;";
            var connection = new Connection(connectionString);
            connection.Open();

            var majorsCTRL = new MajorsController(connection);

            var newMajor = new Major() 
            {
                Id = 1,
                Code = "GENB",
                Description = "General Business",
                MinSAT = 800
            };
            var major = majorsCTRL.GetByPk(1);
            Console.WriteLine(major);

            major.Description = "UWBW - By Greg";
            var rowsAffected = majorsCTRL.Change(major);
            if(rowsAffected != 1) 
            {
                Console.WriteLine("Change Failed");
            }

            rowsAffected = majorsCTRL.Remove(major.Id);
            
           
            var majors = majorsCTRL.GetAll();
            foreach (var maj in majors) {
                Console.WriteLine(maj);

            }

            connection.Close();


        }

        /*static void X() {
            var connStr = "server=localhost\\sqlexpress;database=EdDb;trusted_connection=true;";
            var sqlConn = new SqlConnection(connStr);
            sqlConn.Open();
            if (sqlConn.State != System.Data.ConnectionState.Open) {
                Console.WriteLine("Connection did not open");
                return;

            }
            Console.WriteLine("Connection opened");
            var sql = " Select * from Student " +
                " where gpa between 2.5 and 3.5 " +   //make sure there is a space in between your lines at the beginning and end so there is no
                                                      //syntax error. Basically, the spaces in between the "" ie. " Select * from Student " +
                                                      //the above spaces in between (") and (Select) are the example referred to. 

                " order by sat desc;";
            var cmd = new SqlCommand(sql, sqlConn);
            var reader = cmd.ExecuteReader();
            var students = new List<Student>();
            while (reader.Read()) {

                var student = new Student();                        // this is a list/ collection created to get speciic data. Something good
                                                                    // to put in a library so that we can get all the student instances for 
                                                                    //future projects.

                student.Id = Convert.ToInt32(reader["Id"]);         // this is getting the info. from the column identified in the square brackets, the Id's
                student.Firstname = reader["Firstname"].ToString();
                student.Lastname = Convert.ToString(reader["Lastname"]);
                student.StateCode = reader["StateCode"].ToString();
                student.SAT = reader["SAT"].Equals(DBNull.Value)  // ternary statement saying is the value from SAT allowing NULL, if so, the below happens.
                        ? (int?)null                                // The ? inside the () is a type that allows nulls
                        : Convert.ToInt32(reader["SAT"]);
                student.GPA = Convert.ToDecimal(reader["GPA"]);

                Console.WriteLine(student);
                students.Add(student);

            }


            reader.Close();
            sqlConn.Close();
        } */
    }
}



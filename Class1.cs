using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace EmployeeFormApp
{
    internal class EmployeeInfo
    {
        public int id { get; set; }
        public string Surname { get; set; }
        public string otherNames { get; set; }

        public string dateOfEmployment { get; set; }
        public string department { get; set; }
        public string role { get; set; }

        //CRUD create, read, update, delete

        //Create a connectionString to SQlite DB

        private const string connString = "Data Source=employeeDB.db;Version=3;";

        public int employeeCreate(EmployeeInfo empInfo)
        {
            try
            {
                using(SqliteConnection conn = new SqliteConnection(connString))
                {
                    conn.Open();
                    string query = "Insert into employeeInfoTbl(Surname,otherNames,dateOfEmployment,department,role)" +
                        " Values(@Surname,@otherNames,@dateOfEmployment,@department,@role)";
                    using (SqliteCommand cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Surname", empInfo.Surname);
                        cmd.Parameters.AddWithValue("@otherNames", empInfo.otherNames);
                        cmd.Parameters.AddWithValue("@dateOfEmployment", empInfo.dateOfEmployment);
                        cmd.Parameters.AddWithValue("@department", empInfo.department);
                        cmd.Parameters.AddWithValue("@role", empInfo.role);

                        int result = cmd.ExecuteNonQuery();
                        return result;
                    }
                }   
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return -1;
            }
            return -1;
        }


        public int employeeUpdate(EmployeeInfo empInfo)
        {
            try
            {
                using (SqliteConnection conn = new SqliteConnection(connString))
                {
                    conn.Open();
                    string query = "Update into employeeInfoTbl " +
                        "SET Surname=@Surname,otherNames=@otherNames,dateOfEmployment=@dateOfEmployment,department=@department,role=@role " +
                        "WHERE id=@id";

                    using (SqliteCommand cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Surname", empInfo.Surname);
                        cmd.Parameters.AddWithValue("@otherNames", empInfo.otherNames);
                        cmd.Parameters.AddWithValue("@dateOfEmployment", empInfo.dateOfEmployment);
                        cmd.Parameters.AddWithValue("@department", empInfo.department);
                        cmd.Parameters.AddWithValue("@role", empInfo.role);

                        int result = cmd.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return -1;
            }
            return -1;
        }



       /* public EmployeeInfo employeeRead(int id)
        {
            try
            {
                using (SqliteConnection conn = new SqliteConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT * FROM employeeInfoTbl WHERE id = @id";
                    using (SqliteCommand cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (SqliteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new EmployeeInfo
                                {
                                    id = reader.GetInt32(reader.GetOrdinal("id")),
                                    Surname = reader.GetString(reader.GetOrdinal("Surname")),
                                    otherNames = reader.GetString(reader.GetOrdinal("otherNames")),
                                    dateOfEmployment = reader.GetString(reader.GetOrdinal("dateOfEmployment")),
                                    department = reader.GetString(reader.GetOrdinal("department")),
                                    role = reader.GetString(reader.GetOrdinal("role"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return null;
        }



        public int employeeDelete(int id)
        {
            try
            {
                using (SqliteConnection conn = new SqliteConnection(connString))
                {
                    conn.Open();
                    string query = "DELETE FROM employeeInfoTbl WHERE id = @id";
                    using (SqliteCommand cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        int result = cmd.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return -1;
            }
        }

        */

    }
}

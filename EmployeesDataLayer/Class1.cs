using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Xml.Linq;
namespace EmpDataLayer
{
    public static class ClsData
    {
        private static string ConnectionString = "Server=.;Database=Emp;User Id=sa;Password=123456789zx;";
        private static SqlConnection connection = new SqlConnection(ConnectionString);

        public static int Insert(string Name, string Job, DateTime BirthDate, string Mstatus, string Email, string Gender, string Phone, float Salary, string Department)
        {

            string InsertQuery = @"INSERT INTO Employees( Name,Job,BirthDate,Mstatus,Email,Phone,Salary,Department,Gender)
                            VALUES
                                    (@Name,@Job,@BirthDate,@Mstatus,@Email,@Phone,@Salary,@Department,@Gender)";

            SqlCommand InsertCmd = new SqlCommand(InsertQuery, connection);

            InsertCmd.Parameters.AddWithValue("@Name", Name);
            InsertCmd.Parameters.AddWithValue("@Job", Job);
            InsertCmd.Parameters.AddWithValue("@BirthDate", BirthDate);
            InsertCmd.Parameters.AddWithValue("@Mstatus", Mstatus);
            InsertCmd.Parameters.AddWithValue("@Email", Email);
            InsertCmd.Parameters.AddWithValue("@Gender", Gender);
            InsertCmd.Parameters.AddWithValue("@Phone", Phone);
            InsertCmd.Parameters.AddWithValue("@Salary", Salary);
            InsertCmd.Parameters.AddWithValue("@Department", Department);

            connection.Open();

            int Row = InsertCmd.ExecuteNonQuery();

            connection.Close();

            return Row;

        }

        public static DataTable SelectAll()
        {
            DataTable Dt = new DataTable();

            string SelectAllQuery = @"SELECT        ID, Name, Job, BirthDate, Mstatus, Email, Phone, Salary, Department, Gender
            FROM            Employees";

            SqlCommand SelectAllCmd = new SqlCommand(SelectAllQuery, connection);

            connection.Open();

            SqlDataReader Dr = SelectAllCmd.ExecuteReader();

            Dt.Load(Dr);

            Dr.Close();
            connection.Close();

            return Dt;
 
        }
        public static DataTable FilterByName(string Name)
        {
            DataTable Dt = new DataTable();

            string FilterByName = @"SELECT        ID, Name, Job, BirthDate, Mstatus, Email, Phone, Salary, Department, Gender
            FROM            Employees
            WHERE Name=@Name";

            SqlCommand FilterByNameCmd = new SqlCommand(FilterByName, connection);

            FilterByNameCmd.Parameters.AddWithValue("@Name", Name);
            connection.Open();

            SqlDataReader Dr = FilterByNameCmd.ExecuteReader();

            Dt.Load(Dr);

            Dr.Close();
            connection.Close();

            return Dt;

        }
        public static DataTable FilterByID(int ID)
        {
            DataTable Dt = new DataTable();

            string FilterByID = @"SELECT        ID, Name, Job, BirthDate, Mstatus, Email, Phone, Salary, Department, Gender
            FROM            Employees
            WHERE ID=@ID";

            SqlCommand FilterByIDCmd = new SqlCommand(FilterByID, connection);

            FilterByIDCmd.Parameters.AddWithValue("@ID", ID);
            connection.Open();

            SqlDataReader Dr = FilterByIDCmd.ExecuteReader();

            Dt.Load(Dr);

            Dr.Close();
            connection.Close();

            return Dt;

        }
        public static int Update(int ID, string Name, string Job, DateTime BirthDate, string Mstatus, string Email, string Gender, string Phone, float Salary, string Department)
        {
            string UpdateQuery = @"UPDATE Employees
                                   SET Name = @Name,
                                       Job = @Job,
                                       BirthDate = @BirthDate,
                                       Mstatus = @Mstatus,
                                       Email = @Email,
                                       Phone = @Phone,
                                       Salary = @Salary,
                                       Department = @Department,
                                       Gender = @Gender
                                   WHERE ID = @ID";

            SqlCommand UpdateCmd = new SqlCommand(UpdateQuery, connection);
            UpdateCmd.Parameters.AddWithValue("@ID", ID);
            UpdateCmd.Parameters.AddWithValue("@Name", Name);
            UpdateCmd.Parameters.AddWithValue("@Job", Job);
            UpdateCmd.Parameters.AddWithValue("@BirthDate", BirthDate);
            UpdateCmd.Parameters.AddWithValue("@Mstatus", Mstatus);
            UpdateCmd.Parameters.AddWithValue("@Email", Email);
            UpdateCmd.Parameters.AddWithValue("@Gender", Gender);
            UpdateCmd.Parameters.AddWithValue("@Phone", Phone);
            UpdateCmd.Parameters.AddWithValue("@Salary", Salary);
            UpdateCmd.Parameters.AddWithValue("@Department", Department);

            connection.Open();
            int Row = UpdateCmd.ExecuteNonQuery();
            connection.Close();

            return Row;
        }

        public static int Delete(int ID)
        {
            string DeleteQuery = @"DELETE FROM Employees
                                   
                                   WHERE ID = @ID";

            SqlCommand UpdateCmd = new SqlCommand(DeleteQuery, connection);
            UpdateCmd.Parameters.AddWithValue("@ID", ID);

            connection.Open();
            int Row = UpdateCmd.ExecuteNonQuery();
            connection.Close();

            return Row;
        }

    }
}

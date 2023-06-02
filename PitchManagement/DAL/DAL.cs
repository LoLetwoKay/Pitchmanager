using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UB0BUD0;Initial Catalog=PitchManager;Integrated Security=True");
    }
    public class DAL_User : DBConnect
    {
        public SqlConnection GetConn()
        {
            return conn;
        }

        public DTO_User getUser(DTO_User dto_User, SqlConnection conn)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand($"select * from [USER]", conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(1) == dto_User.Username)
                {
                    if (reader.GetString(2) == dto_User.Password)
                    {
                        dto_User.IsAdmin = reader.GetBoolean(5);
                        dto_User.CorrectPassword = true;
                    }
                    else
                    {
                        dto_User.CorrectPassword = false;
                    }
                    dto_User.IsUser = true;
                    dto_User.FullName = reader.GetString(3);
                    dto_User.PhoneNumber = reader.GetString(4);
                    break;
                }
                else
                {
                    dto_User.IsUser = false;
                }
            }
            reader.Close();
            conn.Close();
            return dto_User;
        }
        public void AddUser(DTO_User dto_User)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand($"insert into [USER] (UserName, Password, FullName, PhoneNumber, IsAdmin) values ('{dto_User.Username}', '{dto_User.Password}', '{dto_User.FullName}', '{dto_User.PhoneNumber}', '{dto_User.IsAdmin}')", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
        public void UpdateUser(DTO_User dto_User)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand($"update [USER] set Password = '{dto_User.Password}', FullName = '{dto_User.FullName}', PhoneNumber = '{dto_User.PhoneNumber}' where UserName = '{dto_User.Username}'", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
    public class DAL_Pitch : DBConnect
    {
        public List<DTO_Pitch> getPitchList()
        {
            List<DTO_Pitch> Pitch_list = new List<DTO_Pitch>();

            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand($"select * from PITCH", conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                DTO_Pitch dto_Pitch = new DTO_Pitch();
                dto_Pitch.PitchName = reader.GetString(1);
                Pitch_list.Add(dto_Pitch);
            }
            reader.Close();
            return Pitch_list;
        }
        public DTO_Pitch getStatus(DTO_Pitch dto_Pitch)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand($"select * from [ORDER] where PitchName = '{dto_Pitch.PitchName}' and TIME = '{dto_Pitch.Time}' and DATE = '{dto_Pitch.Date}'", conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                dto_Pitch.Status = true;
                dto_Pitch.Booker = reader.GetString(2);
            }
            else
            {
                dto_Pitch.Status = false;
            }
            reader.Close();
            conn.Close();
            return dto_Pitch;
        }
        public DTO_Pitch getPrice(DTO_Pitch dto_Pitch)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand($"select * from PITCH inner join CATEGORY on PITCH.CateID = CATEGORY.ID where PITCH.Name = '{dto_Pitch.PitchName}'", conn);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int CateID = reader.GetInt32(2);
            dto_Pitch.Category = reader.GetString(4);
            reader.Close();

            command = new SqlCommand("select * from TIME_SLOT", conn);
            reader = command.ExecuteReader();
            int TimeSlotID = 1;
            while (reader.Read())
            {
                if (reader.GetInt32(1) <= dto_Pitch.Time && dto_Pitch.Time < reader.GetInt32(2))
                {
                    TimeSlotID = reader.GetInt32(0);
                    break;
                }
            }
            reader.Close();

            command = new SqlCommand($"select * from PRICE where CateID = '{CateID}' and TimeSlotID = '{TimeSlotID}'", conn);
            reader = command.ExecuteReader();
            reader.Read();
            dto_Pitch.Price = reader.GetInt32(3);
            reader.Close();
            conn.Close();
            return dto_Pitch;
        }
        public void Order(DTO_User dto_User, DTO_Pitch dto_Pitch)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand($"insert into [ORDER] (PitchName, Booker, Date, Time, Price) values('{dto_Pitch.PitchName}', '{dto_User.Username}', '{dto_Pitch.Date}', '{dto_Pitch.Time}', '{dto_Pitch.Price}')", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
        public void Cancel(DTO_User dto_User, DTO_Pitch dto_Pitch)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand($"Delete from [ORDER] where PitchName = '{dto_Pitch.PitchName}' and Booker = '{dto_User.Username}' and Date = '{dto_Pitch.Date}' and Time = '{dto_Pitch.Time}'", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
        public void AddPitch(DTO_Pitch dto_Pitch)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand($"select * from [CATEGORY] where Name = '{dto_Pitch.Category}'", conn);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int CateID = reader.GetInt32(0);
            reader.Close();
            command = new SqlCommand($"insert into [PITCH] (Name, CateID) values('{dto_Pitch.PitchName}', '{CateID}')", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
        public void UpdatePitch(DTO_Pitch dto_Pitch, string NewName)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand($"select * from [CATEGORY] where Name = '{dto_Pitch.Category}'", conn);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int CateID = reader.GetInt32(0);
            reader.Close();
            command = new SqlCommand($"update [PITCH] set Name = '{NewName}', CateID = '{CateID}' where Name = '{dto_Pitch.PitchName}'", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
        public void DeletePitch(DTO_Pitch dto_Pitch)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand($"delete from [PITCH] where Name = '{dto_Pitch.PitchName}'", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
    public class DAL_TimeAndPrice: DBConnect
    {
        public void UpdateTime(int Time)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand($"update [TIME_SLOT] set [To] = '{Time}' where [From] = '5'", conn);
            command.ExecuteNonQuery();
            command = new SqlCommand($"update [TIME_SLOT] set [From] = '{Time}' where [To] = '21'", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
        public void UpdatePrice(decimal price1, decimal price2, decimal price3, decimal price4)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand($"update [Price] set Price = '{price1}' where CateID = '1' and TimeSlotID = '1'", conn);
            command.ExecuteNonQuery();
            command = new SqlCommand($"update [Price] set Price = '{price2}' where CateID = '1' and TimeSlotID = '2'", conn);
            command.ExecuteNonQuery();
            command = new SqlCommand($"update [Price] set Price = '{price3}' where CateID = '2' and TimeSlotID = '1'", conn);
            command.ExecuteNonQuery();
            command = new SqlCommand($"update [Price] set Price = '{price4}' where CateID = '2' and TimeSlotID = '2'", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}

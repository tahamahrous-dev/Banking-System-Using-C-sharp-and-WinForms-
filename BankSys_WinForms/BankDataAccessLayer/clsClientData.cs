using System;
using System.Data;
using System.Data.SqlClient;

namespace BankDataAccessLayer
{
    public class clsClientDataAccess
    {
        public static bool GetClientInfoByID(int ClientID, ref string FirstName, ref string MidName,
            ref string LastName, ref DateTime DateOfBirth, ref string Gender, ref string Email,
            ref string Phone, ref int Almadireyah, ref int Almohafeza, ref string Personal_ID_Number,
            ref string Image, ref DateTime CreateDate, ref string UserName_OR_Phone,
            ref string Password, ref int Permissions)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Clients WHERE ClientID = @ClientID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    FirstName = (string)reader["FirstName"];
                    MidName = (string)reader["MidName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DataOfBirth"];
                    Gender = (string)reader["Gender"];
                    Email = (string)reader["Email"];

                    if (reader["Phone"] != DBNull.Value)
                        Phone = (string)reader["Phone"];
                    else
                        Phone = "";

                    Almadireyah = (int)reader["Almadireyah"];
                    Almohafeza = (int)reader["Almohafeza"];

                    if (reader["Personal_ID_Number"] != DBNull.Value)
                        Personal_ID_Number = (string)reader["Personal_ID_Number"];
                    else
                        Personal_ID_Number = "";

                    if (reader["Image"] != DBNull.Value)
                        Image = (string)reader["Image"];
                    else
                        Image = "";

                    CreateDate = (DateTime)reader["CreateDate"];
                    UserName_OR_Phone = (string)reader["UserName_OR_Phone"];
                    Password = (string)reader["Password"];
                    Permissions = (int)reader["Permissions"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                string MeErroe = ex.Message;
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int AddNewClient(string FirstName, string MidName, string LastName,
            DateTime DateOfBirth, string Gender, string Email, string Phone, int Almadireyah,
            int Almohafeza, string Personal_ID_Number, string Image, string UserName_OR_Phone,
            string Password, int Permissions)
        {
            int ClientID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Clients (FirstName, MidName, LastName, DataOfBirth, Gender,
                            Email, Phone, Almadireyah, Almohafeza, Personal_ID_Number, Image, CreateDate,
                            UserName_OR_Phone, Password, Permissions)
                            VALUES (@FirstName, @MidName, @LastName, @DateOfBirth, @Gender,
                            @Email, @Phone, @Almadireyah, @Almohafeza, @Personal_ID_Number, @Image, GETDATE(),
                            @UserName_OR_Phone, @Password, @Permissions);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);

            if (!string.IsNullOrEmpty(MidName))
                command.Parameters.AddWithValue("@MidName", MidName);
            else
                command.Parameters.AddWithValue("@MidName", DBNull.Value);

            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Email", Email);

            if (!string.IsNullOrEmpty(Phone))
                command.Parameters.AddWithValue("@Phone", Phone);
            else
                command.Parameters.AddWithValue("@Phone", DBNull.Value);

            command.Parameters.AddWithValue("@Almadireyah", Almadireyah);
            command.Parameters.AddWithValue("@Almohafeza", Almohafeza);

            if (!string.IsNullOrEmpty(Personal_ID_Number))
            {
                string Personal = "";

                for (int i = 0; i < Personal_ID_Number.Length; i++)
                {
                    if (Personal_ID_Number[i] != '-')
                    {
                        Personal += Personal_ID_Number[i];
                    }
                }

                command.Parameters.AddWithValue("@Personal_ID_Number", Personal);

            }
            else
            {
                command.Parameters.AddWithValue("@Personal_ID_Number", DBNull.Value);
            }

            if (!string.IsNullOrEmpty(Image))
                command.Parameters.AddWithValue("@Image", Image);
            else
                command.Parameters.AddWithValue("@Image", DBNull.Value);

            command.Parameters.AddWithValue("@UserName_OR_Phone", UserName_OR_Phone);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permissions", Permissions);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ClientID = insertedID;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return ClientID;
        }

        public static bool UpdateClient(int ClientID, string FirstName, string MidName, string LastName,
            DateTime DateOfBirth, string Gender, string Email, string Phone, int Almadireyah,
            int Almohafeza, string Personal_ID_Number, string Image, string UserName_OR_Phone,
            string Password, int Permissions)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Clients 
                            SET FirstName = @FirstName,
                                MidName = @MidName,
                                LastName = @LastName,
                                DataOfBirth = @DateOfBirth,
                                Gender = @Gender,
                                Email = @Email,
                                Phone = @Phone,
                                Almadireyah = @Almadireyah,
                                Almohafeza = @Almohafeza,
                                Personal_ID_Number = @Personal_ID_Number,
                                Image = @Image,
                                UserName_OR_Phone = @UserName_OR_Phone,
                                Password = @Password,
                                Permissions = @Permissions
                            WHERE ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@FirstName", FirstName);

            if (!string.IsNullOrEmpty(MidName))
                command.Parameters.AddWithValue("@MidName", MidName);
            else
                command.Parameters.AddWithValue("@MidName", DBNull.Value);

            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Email", Email);

            if (!string.IsNullOrEmpty(Phone))
                command.Parameters.AddWithValue("@Phone", Phone);
            else
                command.Parameters.AddWithValue("@Phone", DBNull.Value);

            command.Parameters.AddWithValue("@Almadireyah", Almadireyah);
            command.Parameters.AddWithValue("@Almohafeza", Almohafeza);

            if (!string.IsNullOrEmpty(Personal_ID_Number))
            {
                string Personal = "";

                for (int i = 0; i < Personal_ID_Number.Length; i++)
                {
                    if (Personal_ID_Number[i] != '-')
                    {
                        Personal += Personal_ID_Number[i];
                    }
                }

                command.Parameters.AddWithValue("@Personal_ID_Number", Personal);

            }
            else
            {
                command.Parameters.AddWithValue("@Personal_ID_Number", DBNull.Value);
            }

            if (!string.IsNullOrEmpty(Image))
                command.Parameters.AddWithValue("@Image", Image);
            else
                command.Parameters.AddWithValue("@Image", DBNull.Value);

            command.Parameters.AddWithValue("@UserName_OR_Phone", UserName_OR_Phone);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permissions", Permissions);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static DataTable GetAllClients()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from Clients;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static DataTable GetCostomClients()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select ClientID as [#],[الاسم] = FirstName + ' ' + MidName + ' ' + LastName, [تاريخ الميلاد] = DataOfBirth,\r\n[النوع] = Gender, [الايميل] = Email, [رقم التلفون] = Phone, [المحافظة] = Almohafeza ,[المديرية] = Almadireyah, [رقم البطاقة] = Personal_ID_Number\r\nfrom Clients;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }


        public static DataTable GetDistinctGenders()
        {
            using (SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT Gender FROM Clients", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable GetAllAlmohafezas()
        {
            using (SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Almohafezas order by AlmohafezaID", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


        public static DataTable GetCostomAlmadireyahs(int AlmohafezaID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Almadireyahs WHERE AlmohafezaID = @AlmohafezaID;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AlmohafezaID", AlmohafezaID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static bool DeleteClient(int ClientID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE FROM Clients WHERE ClientID = @ClientID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool IsClientExist(int ClientID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Clients WHERE ClientID = @ClientID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool IsClientExist(string UserName_OR_Phone)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Clients WHERE UserName_OR_Phone = @UserName_OR_Phone";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName_OR_Phone", UserName_OR_Phone);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
    }
}

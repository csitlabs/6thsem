using System;
using System.Data.SqlClient;

namespace Practical2Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practical 2, Question 3\n");
            Console.WriteLine("\n---------- \nName: Bimochan Poudel \nClass Roll: 21-00031-5 (20780638) \nTU Roll: 28555/078");

            //string connectionString = @"Data Source=DESKTOP-BC369GE\SQLEXPRESS;Initial Catalog=PracticalDB;Integrated Security=True";
            //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PracticalDB;User ID=sa;Password=admin";
            string connectionString = @"Data Source=DESKTOP-BC369GE\SQLEXPRESS;Initial Catalog=PracticalDB;User ID=sa;Password=admin";



            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Insert Data");
                Console.WriteLine("2. Display All Records");
                Console.WriteLine("3. Update Record");
                Console.WriteLine("4. Delete Record");
                Console.WriteLine("5. Display Male Users from Nepal");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        InsertData(connectionString);
                        break;
                    case 2:
                        DisplayRecords(connectionString);
                        break;
                    case 3:
                        UpdateRecord(connectionString);
                        break;
                    case 4:
                        DeleteRecord(connectionString);
                        break;
                    case 5:
                        DisplayMaleUsersFromNepal(connectionString);
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        static void InsertData(string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Enter details for user {i + 1}:");
                    Console.Write("Username: ");
                    string username = Console.ReadLine();
                    Console.Write("Password: ");
                    string password = Console.ReadLine();
                    Console.Write("Re-enter Password: ");
                    string repassword = Console.ReadLine();
                    Console.Write("Gender (Male/Female): ");
                    string gender = Console.ReadLine();
                    Console.Write("Course: ");
                    string course = Console.ReadLine();
                    Console.Write("Country: ");
                    string country = Console.ReadLine();

                    string query = "INSERT INTO tbl_registration (username, password, repassword, gender, course, country) VALUES (@username, @password, @repassword, @gender, @course, @country)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@repassword", repassword);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@course", course);
                    cmd.Parameters.AddWithValue("@country", country);
                    cmd.ExecuteNonQuery();
                }
                Console.WriteLine("Data inserted successfully.");
            }
        }

        static void DisplayRecords(string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tbl_registration";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine("\nAll Records:");
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["id"]}, Username: {reader["username"]}, Gender: {reader["gender"]}, Course: {reader["course"]}, Country: {reader["country"]}");
                }
            }
        }

        static void UpdateRecord(string connectionString)
        {
            Console.Write("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter new Name: ");
            string newName = Console.ReadLine();
            Console.Write("Enter new Course: ");
            string newCourse = Console.ReadLine();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE tbl_registration SET username = @username, course = @course WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", newName);
                cmd.Parameters.AddWithValue("@course", newCourse);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Record updated successfully.");
            }
        }

        static void DeleteRecord(string connectionString)
        {
            Console.Write("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM tbl_registration WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Record deleted successfully.");
            }
        }

        static void DisplayMaleUsersFromNepal(string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tbl_registration WHERE gender = 'Male' AND country = 'Nepal'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine("\nMale Users from Nepal:");
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["id"]}, Username: {reader["username"]}, Course: {reader["course"]}");
                }
            }
        }
    }
}

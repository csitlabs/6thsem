using System;
using System.Data.SqlClient;

namespace Practical2Question4
{
    public partial class Default : System.Web.UI.Page
    {
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string repassword = txtRepassword.Text.Trim();
            string gender = rbMale.Checked ? "Male" : rbFemale.Checked ? "Female" : "";
            string course = ddlCourse.SelectedValue;
            string country = ddlCountry.SelectedValue;

            // Server-side validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(repassword) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(course) || string.IsNullOrEmpty(country))
            {
                lblMessage.Text = "All fields are required!";
                return;
            }

            if (password != repassword)
            {
                lblMessage.Text = "Passwords do not match!";
                return;
            }

            // Database connection
            //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PracticalDB;Integrated Security=True";
            string connectionString = @"Data Source=DESKTOP-BC369GE\SQLEXPRESS;Initial Catalog=PracticalDB2;User ID=sa;Password=admin";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO tbl_registration (username, password, repassword, gender, course, country) VALUES (@username, @password, @repassword, @gender, @course, @country)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@repassword", repassword);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@country", country);

                cmd.ExecuteNonQuery();
                lblMessage.Text = "Registration successful!";
            }
        }
    }
}

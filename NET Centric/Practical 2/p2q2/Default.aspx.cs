using System;
using System.Collections.Generic;

namespace Practical2Question2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInputs(out int num1, out int num2))
            {
                txtResult.Text = (num1 + num2).ToString();
            }
        }

        protected void btnSubtract_Click(object sender, EventArgs e)
        {
            if (ValidateInputs(out int num1, out int num2))
            {
                txtResult.Text = (num1 - num2).ToString();
            }
        }

        protected void btnFindPrime_Click(object sender, EventArgs e)
        {
            if (ValidateInputs(out int num1, out int num2))
            {
                List<int> primes = FindPrimes(num2, num1); // First value > Second value as per validation
                txtResult.Text = string.Join(", ", primes);
            }
        }

        private bool ValidateInputs(out int num1, out int num2)
        {
            num1 = 0;
            num2 = 0;

            if (!int.TryParse(txtFirstNumber.Text, out num1) || !int.TryParse(txtSecondNumber.Text, out num2))
            {
                lblError.Text = "Please enter valid numbers.";
                return false;
            }

            if (num1 <= num2)
            {
                lblError.Text = "First number must be greater than the second number.";
                return false;
            }

            lblError.Text = "";
            return true;
        }

        private List<int> FindPrimes(int start, int end)
        {
            List<int> primes = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
        }

        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}

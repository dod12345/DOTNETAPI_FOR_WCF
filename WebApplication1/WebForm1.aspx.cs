using System;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void btnSave_Click(object sender, EventArgs e)
        {
            WebApplication1.EmployeeService.Employee employee = new WebApplication1.EmployeeService.Employee();
            //employee.Id = Convert.ToInt32(txtID.Text);
            employee.Name = txtName.Text;
            employee.Gender = txtGender.Text;
            employee.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);

            WebApplication1.EmployeeService.Service1Client client = new
                WebApplication1.EmployeeService.Service1Client();
            client.SaveEmployee(employee);

            lblMessage.Text = "Employee saved";
        }

        protected void btnGetEmployee_Click(object sender, EventArgs e)
        {
            WebApplication1.EmployeeService.Service1Client client = new
                WebApplication1.EmployeeService.Service1Client();

            WebApplication1.EmployeeService.Employee employee =
                client.GetEmployee(Convert.ToInt32(txtID.Text));

            txtName.Text = employee.Name;
            txtGender.Text = employee.Gender;
            txtDateOfBirth.Text = employee.DateOfBirth.ToShortDateString();

            lblMessage.Text = "Employee retrieved";
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            WebApplication1.EmployeeService.Service1Client client = new
                WebApplication1.EmployeeService.Service1Client();
            int idTry = Convert.ToInt32(txtID.Text);
            //WebApplication1.EmployeeService.Employee employee = client.DeleteEmployee(idTry);
            client.DeleteEmployee(idTry);
            /*txtName.Text = employee.Name;
            txtGender.Text = employee.Gender;
            txtDateOfBirth.Text = employee.DateOfBirth.ToShortDateString();*/

            lblMessage.Text = "Employee Deleted";
        }

        protected void Inner_Click(object sender, EventArgs e)
        {
            WebApplication1.EmployeeService.Service1Client client = new
                WebApplication1.EmployeeService.Service1Client();

            client.Stam();
            lblMessage.Text = "YUP YOU INNER JOINED";
        }

    
    }
}
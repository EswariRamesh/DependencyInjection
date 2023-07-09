using WebApplication1.Interface;
namespace WebApplication1.DAL
{
    public class Employee : IEmployee
    {
        public List<string> GetEmployeeList()
        {
            List<string> listObj = new List<string>();
            listObj.Add("Ravi");
            listObj.Add("Ramu");

            return listObj;
        }
    }
}

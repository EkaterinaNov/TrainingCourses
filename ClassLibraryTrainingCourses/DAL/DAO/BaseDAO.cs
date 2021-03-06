using System.Data.SqlClient;

namespace ClassLibraryTrainingCourses.DAL.DAO
{
    public class BaseDAO
    {
        private const string CONNECTION_STRING = @"Data Source=DESKTOP-7RL6JP4;Initial Catalog=TrainingCourses;Integrated Security=True";

        protected SqlConnection Connection { get; }
        
        public BaseDAO()
        {
            Connection = new SqlConnection(CONNECTION_STRING);
        }
    }
}

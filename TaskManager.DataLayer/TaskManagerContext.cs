using TaskManager.Entities;

namespace TaskManager.DataLayer
{
    /// <summary>
    /// This is the DB Context class to interact with database tables
    /// </summary>
    public class TaskManagerContext : System.Data.Entity.DbContext
    {
        public TaskManagerContext():base("name = taskmanagerdbconn")
        {

        }

        public System.Data.Entity.DbSet<Task> Tasks { get; set; }
    }
}

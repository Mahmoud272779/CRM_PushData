namespace App.Domain.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string arabicName { get; set; }
        public string latinName { get; set; }
        public int permissionListId { get; set; }
        public int employeesId { get; set; }
        public bool isActive { get; set; } 
        public PermissionList permissionList { get; set; }
        public Employees employees { get; set; }

    }
}

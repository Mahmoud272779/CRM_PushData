namespace App.Domain.Models.Request.Users
{
    public class AddUsersDTO
    {
        public string username { get; set; }
        public string password { get; set; }
        public string arabicName { get; set; }
        public string latinName { get; set; }
        public int permissionListId { get; set; }
        public int employeesId { get; set; }
        public bool isActive { get; set; }
    }
    public class EditUsersDTO : AddUsersDTO
    {
        public int Id { get; set; }
    }
}

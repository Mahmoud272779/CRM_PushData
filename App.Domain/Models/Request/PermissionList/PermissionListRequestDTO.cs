namespace App.Domain.Models.Request.PermissionList
{
    public class AddPermissionListRequestDTO
    {
        public string arabicName { get; set; }
        public string latinName { get; set; }
        public string? note { get; set; }
    }
    public class EditPermissionRequestDTO : AddPermissionListRequestDTO
    {
        public int Id { get; set; }
    }
}

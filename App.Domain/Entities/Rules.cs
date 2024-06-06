namespace App.Domain.Entities
{
    public class Rules
    {
        public int Id { get; set; }
        public int screenId { get; set; }
        public int permissionListId { get; set; }
        public bool canOpen { get; set; }
        public bool canAdd { get; set; }
        public bool canEdit { get; set; }
        public bool canDelete { get; set; }
        public bool canPrint { get; set; }
        public PermissionList permissionList { get; set; }


    }
}

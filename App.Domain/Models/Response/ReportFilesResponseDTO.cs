namespace App.Domain.Models.Response
{
    public class ReportFilesResponseDTO
    {
        public int Id { get; set; }
        public string fileName { get; set; }
        public bool IsArabic { get; set; }
        public int IsReport { get; set; }
        public byte[]? Files { get; set; }
    }
}

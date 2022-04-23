namespace KServerService.Domain
{
	public class File
	{
		
		public int FileId { get; set; }
		public string FileName { get; set; }
		public string FileContent { get; set; }
		public int FileHash { get; set; }
		public DateTime FileCreatedTime { get; set; }

	}
}


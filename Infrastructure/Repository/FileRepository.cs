

namespace KServerService.Infrastructure.Repository
{
	public class FileRepository : IFileRepository
	{

		private KserverContext context;

		public FileRepository(KserverContext context)
		{
			this.context = context;
		}
		
		public void Create(Domain.File file)
		{
			context.Files.Add(file);
			context.SaveChangesAsync();
		}

		
		public Domain.File Get()
		{
			return context.Files.OrderByDescending(x=>x.FileCreatedTime).First();
		}
        
        public bool IsNewerFileExist(int hashFile)
        {
			var isEqualHash = context.Files.OrderByDescending(x => x.FileCreatedTime).First().FileHash != hashFile;
			return isEqualHash;
		}
	}
}


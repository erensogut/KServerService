using KServerService.Infrastructure.Repository;

namespace KServerService.Services
{
	public class FileService : IFileService
	{
		
		private readonly IFileRepository repository;

		public FileService(IFileRepository repository)
		{
			this.repository = repository;

		}

		public void Create(Domain.File file)
		{
			repository.Create(file);
		}


		public Domain.File Get()
		{
			return repository.Get();
		}

		public bool IsNewerFileExist(int hashFile)
		{
			return repository.IsNewerFileExist(hashFile);
		}
	}
}


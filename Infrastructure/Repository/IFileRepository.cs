

namespace KServerService.Infrastructure.Repository
{
	public interface IFileRepository
	{
		public void Create(Domain.File file);

		public Domain.File Get();

		public bool IsNewerFileExist(int hashFile);

	}
}


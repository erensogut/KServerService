using System;
using Crea_Demo.Domain;

namespace KServerService.Services
{
	public interface IFileService
	{

		public void Create(Domain.File file);

		public Domain.File Get();

		public bool IsNewerFileExist(int hashFile);

	}
}


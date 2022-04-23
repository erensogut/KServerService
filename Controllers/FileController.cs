using KServerService.Services;
using KServerService.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Crea_Demo.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class FileController : ControllerBase
{
    

    private readonly ILogger<FileController> logger;
    private readonly IFileService fileService;

    public FileController(ILogger<FileController> logger,IFileService fileService)
    {
        this.logger = logger;
        this.fileService = fileService;

    }

    [HttpPost("UploadNewFile")]
    public ActionResult<KServerService.Domain.File> UploadFile(IFormFile file)
    {
        using (FileStream fs = System.IO.File.Create(file.FileName))
        {
            file.CopyTo(fs);
        }
        String fileInside="";
        
        using (var reader = new StreamReader(file.FileName))
        {
            fileInside = reader.ReadToEnd();

        }

        KServerService.Domain.File fileEntity = new KServerService.Domain.File();
        fileEntity.FileName = file.FileName;
        fileEntity.FileContent = fileInside;
        fileEntity.FileCreatedTime = DateTime.Now;
        fileEntity.FileHash = fileInside.GetHashCode();
        fileService.Create(fileEntity);
        return fileEntity;
    }
    [HttpGet("CheckNewFileExist")]
    public ActionResult<bool> CheckNewFileExist(int id)
    {
        return fileService.IsNewerFileExist(id);
    }
    [HttpGet("GetNewFileExist")]
    public KServerService.Domain.File GetNewFile()
    {
        return fileService.Get();
    }

}


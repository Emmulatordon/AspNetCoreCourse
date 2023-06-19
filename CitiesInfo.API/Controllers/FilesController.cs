using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace CitiesInfo.API.Controllers
{
    [ApiController]
    [Route("api/files")]
    public class FilesController:ControllerBase
    {
        private readonly FileExtensionContentTypeProvider _fectp;

        public FilesController(FileExtensionContentTypeProvider fectp)
        {
            this._fectp = fectp;
        }
        [HttpGet("{fileId}")]
        public ActionResult GetFile(string fileId)
        {
            var pathToFile = "Reports/billFinal.docx";
            if(!System.IO.File.Exists(pathToFile))
            {
                return NotFound();
            }

            string? contentType = string.Empty;
            if (!_fectp.TryGetContentType(pathToFile, out contentType))
            {
                contentType = "application/octet-stream";
            }

            var bytes = System.IO.File.ReadAllBytes(pathToFile);
            //return File(bytes, "application/pdf", Path.GetFileName(pathToFile));
            return File(bytes, contentType, Path.GetFileName(pathToFile));
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PdfSharpCore;
using PdfSharpCore.Pdf;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class InvoiceController : ControllerBase
    {
      
        [HttpGet]
        public async Task<IActionResult> GenaratePDF(string invoice)
        {
            var document = new PdfDocument();
            string htmlContent = " ";
            PdfGenerator.AddPdfPages(document, htmlContent, PageSize.A4);
            byte[]? responce = null;
            using (MemoryStream ms = new MemoryStream())
            {
                document.Save(ms);
                responce = ms.ToArray();
            }
            //create file name
            string FileName = $"Invoice_{invoice}+.pdf";
            Console.WriteLine("Printed succusfully"); 
            return  File(responce,"applications/pdf",FileName);
        }
    }
}

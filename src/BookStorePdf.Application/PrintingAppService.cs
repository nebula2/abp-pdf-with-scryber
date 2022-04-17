using Scryber.Components;
using System;
using System.IO;
using System.Threading.Tasks;

namespace BookStorePdf;

public class PrintingAppService : BookStorePdfAppService, IPrintingAppService
{
    private readonly IResourceAppService _resourceAppService;

    public PrintingAppService(IResourceAppService resourceAppService)
    {
        _resourceAppService = resourceAppService;
    }

    public async Task<byte[]> PrintAsync()
    {
        // get desired template from resource service into a stream
        var info = _resourceAppService.GetFileInfo("/MyResources/Test.html");
        using var stream = info.CreateReadStream();

        // use scryber to parse the stream into a document
        using var doc = Document.ParseDocument(stream, Scryber.ParseSourceType.Resource);
        
        // create some file to write the pdf to.
        // in a real world scenario you would remove the file after you're done
        var tmpDir = System.IO.Path.GetTempPath();
        var name = Guid.NewGuid().ToString() + ".pdf";
        var targetFilename = System.IO.Path.Combine(tmpDir, name);

        // let scryber write the pdf file
        doc.SaveAsPDF(targetFilename, FileMode.OpenOrCreate);
        
        // read created pdf file into bytes and return to consumer
        return await File.ReadAllBytesAsync(targetFilename);
    }
}

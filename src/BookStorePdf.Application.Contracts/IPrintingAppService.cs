using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;

namespace BookStorePdf;

public interface IPrintingAppService : IApplicationService, ITransientDependency
{
    Task<byte[]> PrintAsync();
}

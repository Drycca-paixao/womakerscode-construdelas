using System.Threading.Tasks;

namespace Biblioteca.WoMakersCode.Application.UseCases
{
    public interface IUseCaseAsync<TRequest, TResponse>
    {
        Task<TResponse> ExecuteAsync(TRequest request);
    }
}

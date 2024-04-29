using SystemOfTasks.Models;

namespace SystemOfTasks.Repositorios.Interfaces
{
    public interface IUserRepositorio
    {
        Task<List<UserModel>> BuscarTodosUsuarios();
        Task<UserModel> BuscarPorId(int id);
        Task<UserModel> Adicionar(UserModel user);
        Task<UserModel> Atualizar(UserModel usuer, int id);
        Task<bool> Apagar(int id); 
    }
}

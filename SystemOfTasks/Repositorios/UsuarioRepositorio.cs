using Microsoft.EntityFrameworkCore;
using SystemOfTasks.Data;
using SystemOfTasks.Models;
using SystemOfTasks.Repositorios.Interfaces;
namespace SystemOfTasks.Repositorios
{
    public class UsuarioRepositorio : IUserRepositorio
    {
        private readonly SistemaDeTarefasDBContext _dbContext;
        public UsuarioRepositorio(SistemaDeTarefasDBContext sistemaDeTarefasDBContext)
        {
            _dbContext = sistemaDeTarefasDBContext;
        }
        public async Task<UserModel> BuscarPorId(int id)
        {
            return await _dbContext.User.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<UserModel>> BuscarTodosUsuarios()
        {
            return await _dbContext.User.ToListAsync();
        }
        public async Task<UserModel> Adicionar(UserModel user)
        {
            await _dbContext.User.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            return user;
        }
        public async Task<UserModel> Atualizar(UserModel usuer, int id)
        {
            UserModel usuarioPorId = await BuscarPorId(id);

            if (usuarioPorId == null)
            {
                throw new Exception($"Usuario para o Id: {id} nao foi encontrado.");
            }
            usuarioPorId.Name = usuer.Name;
            usuarioPorId.Mail = usuer.Mail;

            _dbContext.User.Update(usuarioPorId);
            await _dbContext.SaveChangesAsync();

            return usuarioPorId;

        }

        public async Task<bool> Apagar(int id)
        {
            UserModel usuarioPorId = await BuscarPorId(id);
            if (usuarioPorId == null)
            {
                throw new Exception($"Usuario para o Id: {id} nao foi encontrado.");
            }
            _dbContext.User.Remove(usuarioPorId);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
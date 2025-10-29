using Microsoft.EntityFrameworkCore;
using P2_ap1_FelixMunoz.Models;
using P2_ap1_FelixMunoz1.DAL;
using System.Linq.Expressions;

namespace P2_ap1_FelixMunoz1.Service;
public class RegistroService(IDbContextFactory<Contexto> DbFactory)
{
   /* public async Task<bool> Guardar(Registro registro)
    {
        if (!await Existe(registro.IdRegistro))
        {
            return await Insertar(registro);
        }
        else
        {
            return await Modificar(registro);
        }
    }*/
    public async Task<List<Registro>> Listar(Expression<Func<Registro, bool>> criterio)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Registro.Where(criterio).AsNoTracking().ToListAsync();
    }

}

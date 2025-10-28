using P2_ap1_FelixMunoz1.DAL;

namespace P2_ap1_FelixMunoz1.Service;
public class RegistroService(IDbContextFactory<Contexto> DbFactory)
{
    public async Task<bool> Guardar(Registros registro)
    {
        if (!await Existe(registro.Id))
        {
            return await Insertar(registro);
        }
        else
        {
            return await Modificar(registro);
        }
    }
    public async Task<List<Registros>> Listar(Expression<Func<Registros, bool>> criterio)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Registros.Where(criterio).AsNoTracking().ToListAsync();
    }

}

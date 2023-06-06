using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.BC
{
    public class CoffeeBreak
{
    public string Numero { get; set; }
    public bool Vegetariana { get; set; }
    public virtual Contrato Contrato { get; set; }

    public CoffeeBreak()
    {
        this.Init();
    }

    private void Init()
    {
        this.Numero = string.Empty;
        this.Vegetariana = false;
    }

    public bool Create()
    {
        // Crear una conexión al Entities
        BD.OnBreakEntities bd = new BD.OnBreakEntities();
        BD.CoffeeBreak coffeeBreak = new BD.CoffeeBreak();

        try
        {
            // Sincronizar el contenido de las propiedades a la BD
            CommonBC.Syncronize(this, coffeeBreak);

            bd.CoffeeBreak.Add(coffeeBreak);
            bd.SaveChanges();

            return true;
        }
        catch (Exception)
        {
            bd.CoffeeBreak.Remove(coffeeBreak);
            return false;
        }
    }

    public List<CoffeeBreak> ReadAll()
    {
        BD.OnBreakEntities bd = new BD.OnBreakEntities();

        try
        {
            // Crear objeto de tipo tabla con datos de la tabla
            List<BD.CoffeeBreak> listaDatos = bd.CoffeeBreak.ToList();
            List<CoffeeBreak> listaNegocio = GenerarListado(listaDatos);

            return listaNegocio;
        }
        catch (Exception)
        {
            return new List<CoffeeBreak>();
        }
    }

    private List<CoffeeBreak> GenerarListado(List<BD.CoffeeBreak> listaDatos)
    {
        List<CoffeeBreak> listaNegocio = new List<CoffeeBreak>();

        foreach (BD.CoffeeBreak datos in listaDatos)
        {
            CoffeeBreak negocio = new CoffeeBreak();
            CommonBC.Syncronize(datos, negocio);
            listaNegocio.Add(negocio);
        }

        return listaNegocio;
    }
}

}

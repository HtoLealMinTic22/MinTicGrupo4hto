[9:17 p. m.] MARIO ALBERTO SANCHEZ CASTRO
    

usingSystem;
usingSystem.Collections.Generic;
usingSystem.Linq;
usingSystem.Threading.Tasks;
usingMicrosoft.AspNetCore.Mvc;
usingMicrosoft.AspNetCore.Mvc.RazorPages;
usingProyectoCiclo3.App.Persistencia.AppRepositorios;
usingProyectoCiclo3.App.Dominio;

namespaceProyectoCiclo3.App.Frontend.Pages
{​​​​​​​​
publicclassDetailsEstacionModel : PageModel
    {​​​​​​​​
privatereadonlyRepositorioEstacionesrepositorioEstaciones;
publicEstacionesEstacion {​​​​​​​​get;set;}​​​​​​​​

publicDetailsEstacionModel(RepositorioEstacionesrepositorioEstaciones)
       {​​​​​​​​
this.repositorioEstaciones=repositorioEstaciones;
       }​​​​​​​​

publicIActionResultOnGet(intestacionId)
        {​​​​​​​​
Estacion=repositorioEstaciones.GetWithId(estacionId);
returnPage();

        }​​​​​​​​
    }​​​​​​​​
}​​​​​​​​

​[9:24 p. m.] MARIO ALBERTO SANCHEZ CASTRO
    Estaciones/Details.cshtml

using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioBuses
    {
        List<Buses> buses;
 
    public RepositorioBuses()
        {
            
            buses= new List<Buses>()
            {
                new Buses{id=1,marca="Mercedez",modelo= 2015, kilometraje= 10342,numero_asientos= 25,placa= "EWE867"},
                new Buses{id=2,marca="Renault" ,modelo= 2018, kilometraje= 32763,numero_asientos= 32,placa= "JLA014"},
                new Buses{id=3,marca="Audi"    ,modelo= 2020, kilometraje= 15319,numero_asientos= 18,placa= "RMU732"},
                new Buses{id=4,marca="Mazda"   ,modelo= 2012, kilometraje= 83333,numero_asientos= 25,placa= "WSQ321"}                
            };
        }
 
    public IEnumerable<Buses> GetAll()
        {
            return buses;
        }


 
    public Buses GetWithId(int id){
            return buses.SingleOrDefault(e => e.id == id);
        }

    public Buses Update(Buses newBus){
            var bus= buses.SingleOrDefault(b => b.id == newBus.id);
            if(bus != null){
                bus.marca = newBus.marca;
                bus.modelo = newBus.modelo;
                bus.kilometraje = newBus.kilometraje;
                bus.numero_asientos = newBus.numero_asientos;
                bus.placa = newBus.placa;
            }
        return bus;
        }

    public Buses Create(Buses newBus)
        {
           if(buses.Count > 0){
           newBus.id=buses.Max(r => r.id) +1; 
            }else{
               newBus.id = 1; 
            }
           buses.Add(newBus);
           return newBus;
        }


    public Buses Delete(int id)
        {
            var bus= buses.SingleOrDefault(e => e.id == id);
            buses.Remove(bus);
            return bus;
        }
    }
}




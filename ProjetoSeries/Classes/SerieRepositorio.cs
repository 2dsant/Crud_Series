using System;
using System.Collections.Generic;
using System.Text;
using ProjetoSeries.Interfaces;

namespace ProjetoSeries
{
    class SerieRepositorio : IRepositorio<Serie>
    {
        //Cria uma interface e não há necessidade de criar uma lista no programa principal.
        //O código fica mais organizado.
        
        private List<Serie> ListaSerie = new List<Serie>();
        public void Atualiza(int id, Serie entidade)
        {
            ListaSerie[id] = entidade;
        }
        public void Exclui(int id)
        {
            ListaSerie[id].Excluir();
        }

        public void Insere(Serie entidade)
        {
            ListaSerie.Add(entidade);
        }

        public List<Serie> Lista()
        {
            return ListaSerie;
        }

        public int ProximoId()
        {
            return ListaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return ListaSerie[id];
        }
    }
}

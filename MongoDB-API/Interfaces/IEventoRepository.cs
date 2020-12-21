using MongoDB_API_Domains;
using System.Collections.Generic;

namespace MongoDB_API_Interfaces
{
    public interface IEventoRepository
    {
        List<EventoDomain> Listar();
        EventoDomain BuscarPorId(string id);

        void Adcionar(EventoDomain evento);

        void Atualizar(string id, EventoDomain evento);

        void Remover(string id);
    }
}

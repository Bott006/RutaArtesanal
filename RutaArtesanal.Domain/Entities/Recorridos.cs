using System;

namespace RutaArtesanal.Domain.Entities
{
    public record Recorridos(int idRecorrido, string nombreRecorrido, string descripcion, DateTime horario, 
    string tipoRecorrido, string PuntoInteres);
}
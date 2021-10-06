using System;

namespace RutaArtesanal.Domain.Entities
{
    public record Taller(int idTaller, string nombreTaller, string logotipoTaller, string telefono, string ubicacion);
}
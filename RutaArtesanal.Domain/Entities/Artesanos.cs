using System;

namespace RutaArtesanal.Domain.Entities
{
    public record Artesanos(int idArtesano, string nombres, string apellidoP, string apellidoM, string cooperativa, string estatus,
    string celular, string email, string contrasena, string redesSociales);
}
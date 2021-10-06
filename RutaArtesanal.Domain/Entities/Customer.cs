using System;

namespace RutaArtesanal.Domain.Entities
{
    public record Customer (string Firstname, string MiddleName, string LastName, string Email, string phone, int Country);
}
using System;
using RutaArtesanal.Domain;

namespace RutaArtesanal.Infrastructure
{
    public class MessageRepository
    {
        public Message GetFirst(){
            return new Message("Jeloudah");
        }
        public Message2 GetSecond(){
            return new Message2("Segundo mensaje.e");
        }
    }
}

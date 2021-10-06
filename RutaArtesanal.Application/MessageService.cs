using System.Text.RegularExpressions;
using System;
using RutaArtesanal.Infrastructure;

namespace RutaArtesanal.Application
{
    public class MessageService
    {
        public string SayHello(string name){
            var repo = new MessageRepository();
            var msg = repo.GetFirst();
            return $"{msg.Summary} {name}";
        }
    }
}

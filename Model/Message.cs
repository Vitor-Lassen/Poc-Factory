using Poc.Factory.Enum;

namespace Model
{        
    public class Message
    {
        public string Texto { get; set; }
        public SenderEnum Destino {get; set;}
    }    
}

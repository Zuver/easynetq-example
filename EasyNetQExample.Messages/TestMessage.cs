using EasyNetQ;

namespace EasyNetQExample.Messages
{
    [Queue("TextMessageQueue", ExchangeName = "AwesomeExchange")]
    public class TextMessage
    {
        public string Value { get; set; }
    }
}

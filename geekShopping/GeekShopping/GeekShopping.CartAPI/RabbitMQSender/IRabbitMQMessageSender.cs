using GeekShopping.CartAPI.Messages;
using GeekShopping.MessageBus;

namespace GeekShopping.CartAPI.RabbitMQSender {
    public interface IRabbitMQMessageSender {

        void SendMessage(CheckoutHeaderVO baseMessage, string quueuName);

    }
}

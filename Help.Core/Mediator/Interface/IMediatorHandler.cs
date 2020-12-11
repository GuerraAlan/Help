using System.Threading.Tasks;
using FluentValidation.Results;
using Help.Core.Models.Messaging;

namespace Help.Core.Mediator.Interface
{
    public interface IMediatorHandler
    {
        Task PublishEvent<T>(T @event) where T : Event;
        Task<ValidationResult> SendCommand<T>(T command) where T : Command;
    }
}

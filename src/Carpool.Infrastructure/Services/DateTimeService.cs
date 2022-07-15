using Carpool.Application.Common.Interfaces;

namespace Carpool.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}

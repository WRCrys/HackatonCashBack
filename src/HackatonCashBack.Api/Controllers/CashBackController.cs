using HackatonCashBack.Bussines.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HackatonCashBack.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CashBackController : MainController
    {
        private readonly INotificator _notificator;

        public CashBackController(INotificator notificator) : base(notificator)
        {
            _notificator = notificator;
        }
    }
}

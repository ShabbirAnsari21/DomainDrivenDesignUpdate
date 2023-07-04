using AutoMapper;
using DDDSession.API.Mediator.Queries.UserInformation;
using DDDSession.API.Model.Response;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDDSession.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInformationController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly ILogger<UserInformationController> _logger;
        public UserInformationController(IMapper mapper, IMediator mediator, ILogger<UserInformationController> logger)
        {
            _mapper = mapper;
            _mediator = mediator;
            _logger = logger;

        }
        [HttpGet]
        [ProducesResponseType(typeof(IList<UserInformationResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllUserInformationAsync()
        {
            try
            {
                return Ok(_mapper.Map<IList<UserInformationResponse>>(await _mediator.Send(new GetAllUserInformationQuery())));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        [ProducesResponseType(typeof(ResponseMessage), StatusCodes.Status201Created)]
        public async Task<IActionResult> CreateUserInformation()
        {
            try
            {
                return Created("", await _mediator.Send())
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

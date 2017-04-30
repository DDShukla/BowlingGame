using Bowling.LogicLayer;
using SimpleInjector;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Bowling.WebAPI
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class BowlingGameController : ApiController
    {
        private readonly Container _container;
        public BowlingGameController(Container container)
            : base()
        {
            _container = container;
        }


        [HttpPost]
        public int ScoreByAllRolls([FromBody] int[] rolls)
        {
            BowlingGameService service = new BowlingGameService(_container);
            return service.GetScoreByAllRolls(rolls);
        }

        [HttpPost]
        public List<int> AllFramesScoreByRolls([FromBody] int[] rolls)
        {
            BowlingGameService service = new BowlingGameService(_container);
            return service.GetAllFramesResultByRolls(rolls);
        }
    }
}
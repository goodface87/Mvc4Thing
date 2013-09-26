using System.Linq;
using System.Web.Mvc;
using Thing.Data;
using Thing.Data.Interfaces;
using Thing.Models.Statistics;
using Thing.Services.Services;

namespace Thing.Controllers
{
  public class StatisticsController : Controller
  {
    //
    // GET: /Statistics/
    private readonly StatisticsService _statisticsService;

    public StatisticsController() : this(new ThingContext())
    {}

    public StatisticsController(IContext context)
    {
      _statisticsService = new StatisticsService(context);
    }

    public ActionResult Index()
    {
      var activeGrandparentManagers = _statisticsService.GetActiveGrandparentManagers().Select(m => new GrandparentManager(m));


      return View(activeGrandparentManagers);
    }
  }
}

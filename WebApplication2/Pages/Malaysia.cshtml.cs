using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class MalaysiaModel : PageModel
    {
        private readonly ILogger<MalaysiaModel> _logger;

        public MalaysiaModel(ILogger<MalaysiaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["v1"] = "The Twin Towers were the two main buildings of the World Trade Center, a complex of seven buildings in Lower Manhattan, New York City. \r\n        They were designed by American architect Minoru Yamasaki and completed in 1973.";
            ViewData["v2"] = " Batu Caves is a complex of limestone caves and Hindu temples in Malaysia, near the capital city of Kuala Lumpur. It is one of the\r\n        most popular tourist attractions and pilgrimage sites for Tamil Hindus in the country";
            ViewData["v3"] = "This is a 421-meter-tall (1,381 ft) telecommunication tower in Kuala Lumpur, Malaysia. It is the seventh-tallest tower in the world \r\n        and the second-tallest in Southeast Asia.";
            ViewData["v4"] = "KLCC Park is a 50-acre urban park in Kuala Lumpur, Malaysia, that provides greenery and recreation to the surrounding area. The park is \r\n        located near the Petronas Twin Towers, the tallest buildings in the world, and the Suria KLCC shopping mall.";
            ViewData["v5"] = "ESCAPE Penang is a fun and adventurous theme park in Teluk Bahang, Penang, Malaysia. It is the first theme park in the world to have two\r\n        Guinness World Records: the longest tube water slide and the longest zip coaster.";
        }
    }
}
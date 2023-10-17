using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class ThailandModel : PageModel
    {
        private readonly ILogger<ThailandModel> _logger;

        public ThailandModel(ILogger<ThailandModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["v1"] = "The Grand Palace is a complex of buildings in Bangkok, Thailand, \r\n        that has been the official residence of the kings of Siam and Thailand since 1782. \r\n        The palace is located on the banks of the Chao Phraya River, on an island called Rattanakosin.";
            ViewData["v2"] = "Bangkok, the capital of Thailand, is famous for its floating markets, which offer a glimpse of the \r\n        traditional and vibrant lifestyle of the country. There are many floating markets in and around Bangkok, each with its own features and charm.";
            ViewData["v3"] = "Chiang Mai is the largest city in northern Thailand and the capital of Chiang Mai province. It is located on the Ping River, \r\n        near the centre of a fertile valley surrounded by mountains. It has a rich history and culture, dating back to the 13th century\r\n        when it was founded as the capital of the Lanna Thai kingdom.";
            ViewData["v4"] = "Khao Yai is the third largest national park in Thailand and the first to be established in 1962. It covers an area of 2,166 square kilometers (836 square miles) \r\n        in four provinces: Nakhon Ratchasima, Prachinburi, Saraburi, and Nakhon Nayok.";
            ViewData["v5"] = "Phang Nga Bay is a stunning bay in the Andaman Sea between the island of Phuket and the mainland of southern Thailand. It covers an area of 400 square kilometers \r\n        (150 square miles) and has 42 islands, many of which are made of limestone cliffs with caves and lagoons.";
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class IndonesiaModel : PageModel
    {
        private readonly ILogger<IndonesiaModel> _logger;

        public IndonesiaModel(ILogger<IndonesiaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["v1"] = "Bali is a beautiful island and province in the Lesser Sunda Islands, Indonesia.\r\n        It is situated about 1.6 km (1 mile) east of Java, separated by the Bali Strait. It has an area of 5,780 square km \r\n        (2,232 square miles) and a population of about 3.9 million people.";
            ViewData["v2"] = "Yogyakarta is a city and a special region in the island of Java, Indonesia. It is known for its cultural, historical, and natural attractions, as well as its education and tourism. \r\n        Yogyakarta was the capital of Indonesia from 1946 to 1948 during the independence struggle, and it is still ruled by a monarchy.";
            ViewData["v3"] = "Gili Air is one of the three Gili Islands located in Northwest Lombok, Indonesia. It is the closest island to Lombok and the most developed of the three. Gili Air is known for its \r\n        laid-back and relaxed atmosphere, as well as its beautiful beaches, turquoise water, and diverse marine life.";
            ViewData["v4"] = "Komodo Island is one of the 17,508 islands that make up Indonesia. It is located in the Lesser Sunda Islands, between the islands of Flores and Sumbawa. \r\n        It has an area of about 390 square kilometers (150 square miles) and a population of about 2,000 people.";
            ViewData["v5"] = "Borobudur is a massive Buddhist monument in Central Java, Indonesia, that was built in the 9th century by the Sailendra dynasty. It is the largest and \r\n        most complete Buddhist temple in the world, and a UNESCO World Heritage Site.";
        }
    }
}
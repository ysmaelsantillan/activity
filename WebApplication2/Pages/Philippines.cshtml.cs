using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Hosting;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace WebApplication2.Pages
{
    public class PhilippinesModel : PageModel
    {
        private readonly ILogger<PhilippinesModel> _logger;

        public PhilippinesModel(ILogger<PhilippinesModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["v1"] = "Boracay is a resort island in the Philippines that is famous for its white sand beaches, clear blue waters, and stunning sunsets.\r\n        It is one of the most popular tourist destinations in the country and has been recognized as one of the best islands in the world by various publications and awards.\r\n   Boracay offers a variety of activities and attractions for visitors, such as island hopping, diving, snorkeling, parasailing, kayaking, and nightlife.";
            ViewData["v2"] = "Siargao is a tear-drop shaped island in the Philippine Sea that is famous for its surfing spots, especially Cloud 9,\r\n   which attracts both local and international wave riders.It is known as the surfing capital of the Philippines and was \r\n   voted the best island in Asia in 2021";
            ViewData["v3"] = "The Chocolate Hills are a natural wonder in the Philippines that consist of thousands of cone-shaped hills \r\n        that look like chocolate mounds when the grass turns brown in the dry season. \r\n        They are located in the province of Bohol, mainly in the towns of Carmen, Batuan, and Sagbayan.";
            ViewData["v4"] = "Palawan is the southwesternmost large island of the Philippines, with a long and narrow shape that stretches between the South China Sea and the Sulu Sea. It has a mountainous backbone \r\n        that runs along its entire length, with the highest peak being Mount Mantalingajan at 2,086 meters (6,841 feet)";
            ViewData["v5"] = "ntramuros is a historic walled city within Manila, the capital of the Philippines. It was founded by the Spanish conquistador Miguel López de Legazpi in 1571 as the seat of government and the religious and educational center of the Spanish East Indies. Intramuros means \"within the walls\" in Latin, and the district beyond the walls was called extramuros, meaning \"outside the wall\". ";
        }
    }
}
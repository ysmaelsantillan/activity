using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class IndiaModel : PageModel
    {
        private readonly ILogger<IndiaModel> _logger;

        public IndiaModel(ILogger<IndiaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["v1"] = "The Taj Mahal is a magnificent monument of love and architecture in Agra, India. It was built by the Mughal emperor \r\n       Shah Jahan in the 17th century as a tribute to his beloved wife Mumtaz Mahal, \r\n       who died giving birth to their 14th child. The Taj Mahal is a white marble mausoleum that stands on a large rectangular platform surrounded by four minarets.";
            ViewData["v2"] = "Amber Fort is a historic fort and palace complex in Amer, Rajasthan, India. It was built by the Rajput rulers of Amber from the 16th to the 18th centuries, \r\n        and showcases their artistic and cultural style. The fort is made of red sandstone and marble, and has four levels, each with a courtyard.";
            ViewData["v3"] = "India Gate is a monumental arch in New Delhi, India, that serves as a war memorial for the soldiers of British India who died in the First World War and the \r\n        Third Anglo-Afghan War. It was designed by Sir Edwin Lutyens, a prominent British architect, and built from 1921 to 1931";
            ViewData["v4"] = "Qutb Minar is a towering monument of Islamic architecture in Delhi, India. It was built as a victory tower and a minaret for the Qutb complex, which includes a mosque and other structures. \r\n        The tower was started by Qutb-ud-din Aibak, the founder of the Delhi Sultanate, in 1199, and completed by his successors Iltutmish and Firoz Shah Tughlaq in the 13th and 14th centuries.";
            ViewData["v5"] = "Red Fort is a historic fort and palace complex in Delhi, India, that served as the main residence of the Mughal emperors for nearly 200 years.\r\n        It was built by Emperor Shah Jahan in the 17th century, when he shifted his capital from Agra to Delhi.";
        }
    }
}
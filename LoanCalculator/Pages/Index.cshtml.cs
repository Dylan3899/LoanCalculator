using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoanCalculator.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public int num1 { get; set; }
        public int num2 { get; set; }
        public int sum { get; set; }
        public int num3 { get; set; }
        public int num4 { get; set; }
        public int difference { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPostAddNumbers(int num1, int num2)
        {
            sum = num1 + num2;
        }
        public void OnPostSubtractNumbers(int num3, int num4)
        {
            difference = num3 - num4;
        }

        //Add a multiply function

        //Add a divide function

        //Add anything else and be creative
    }
}

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
        public int num5 { get; set; }
        public int num6 { get; set; }
        public int product { get; set; }
        public int num7 { get; set; }
        public int num8 { get; set; }
        public int quotient { get; set; }
        

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
        public void OnPostMultiplyNumbers(int num5, int num6)
        {
            product = num5 * num6;
        }

        //Add a divide function
        public void OnPostDivideNumbers(int num7, int num8)
        {
            quotient = num7 / num8;
        }

        //Add anything else and be creative
        
    }
}

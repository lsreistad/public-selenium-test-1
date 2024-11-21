using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting the automation task...");

        // Setup ChromeDriver options
        var options = new ChromeOptions();
        options.AddArgument("--headless"); // Run in headless mode

        // Initialize WebDriver
        using var driver = new ChromeDriver(options);

        try
        {
            // Step 1: Navigate to the "Inputs" page on the Heroku app
            Console.WriteLine("Step 1: Navigate to the Inputs page.");
            // TODO: Replace this comment with the code to navigate to:
            // "https://the-internet.herokuapp.com/inputs"

            // Step 2: Find the input field and enter a value
            Console.WriteLine("Step 2: Find the input field and enter a value.");
            // TODO: Replace this comment with code to find the input field by tag or ID
            // and enter the value "1234"
            driver.FindElement("").Click();

            // Step 3: Retrieve the value from the input field and verify it
            Console.WriteLine("Step 3: Retrieve the value and verify it.");
            // TODO:  get the value from the input field
            // and verify that it matches "1234"

        

            Console.WriteLine("Input test completed!");
        }
        // QUESTION: What could be bad about this, and how can we make it better?
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        finally
        {
            driver.Quit();
            Console.WriteLine("Task ended.");
        }
    }
}

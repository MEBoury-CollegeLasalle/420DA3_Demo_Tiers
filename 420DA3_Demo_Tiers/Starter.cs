using _420DA3_Demo_Tiers.Business;

namespace _420DA3_Demo_Tiers;

internal static class Starter {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main() {
        DemoApp.GetInstance().Run();
    }
}
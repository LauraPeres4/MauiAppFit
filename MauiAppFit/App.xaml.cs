namespace MauiAppFit.Helpers;

public partial class App : Application
{
    static SQLiteDataBaseHelper database;

    public static SQLiteDataBaseHelper Database
    {
        get
        {
            if (database == null)
            {
                database = new SQLiteDataBaseHelper(
                    Path.Combine(Environment.GetFolderPath(
                        Environment.SpecialFolder.LocalApplicationData),
                        "XamAppFit.db3"));
            }
            return database;
        } // FECHA DATABASE...
    }
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new AppShell());
    }
}
using Microsoft.Extensions.Configuration;


namespace ADONETLesson4_AsyncAndAwait;


public partial class AsyncAndAwait : Form
{
    IConfigurationRoot? configurationRoot = null;
    string conStr = string.Empty;


    public AsyncAndAwait()
    {
        InitializeComponent();
        Configure();
    }


    private void Configure()
    {
        string projectPath = Directory.GetCurrentDirectory().Split(@"bin\")[0];

        configurationRoot = new ConfigurationBuilder()
            .SetBasePath(projectPath)
            .AddJsonFile("appsettings.json").Build();



        conStr = configurationRoot.GetConnectionString("ConStr");
    }
}
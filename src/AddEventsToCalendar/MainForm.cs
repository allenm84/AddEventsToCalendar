using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace AddEventsToCalendar
{
  public partial class MainForm : Form
  {
    static string[] Scopes = { CalendarService.Scope.Calendar };
    static string ApplicationName = "Add Events to Calendar";

    private CalendarService mService;
    public MainForm()
    {
      InitializeComponent();
      InitializeService();
      PopulateEvents();
      ProcessSelectedNode();
    }

    private IEnumerable<SpecializedEvent> FetchEventFactories()
    {
      var eventType = typeof(SpecializedEvent);
      var types = eventType.Assembly.GetTypes();
      foreach (var type in types)
      {
        if (type.IsSubclassOf(eventType) && !type.IsAbstract)
        {
          yield return Activator.CreateInstance(type) as SpecializedEvent;
        }
      }
    }

    private void PopulateEvents()
    {
      foreach (var ev in FetchEventFactories().OrderBy(i => i.Name))
      {
        var node = new TreeNode(ev.Name);
        node.Tag = ev;
        treeEvents.Nodes.Add(node);
      }
    }

    private void SetIsWorking(bool working)
    {
      Cursor = working ? Cursors.WaitCursor : Cursors.Default;
      tableLayoutPanel1.Enabled = !working;
      progStatus.Visible = working;
    }

    private async Task<UserCredential> FetchCredential()
    {
      var stream = AssemblyHelper.OpenStream("client_secret.json");
      {
        var credPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        credPath = Path.Combine(credPath, ".credentials/addEventsToCalendar.json");
        return await GoogleWebAuthorizationBroker.AuthorizeAsync(
            GoogleClientSecrets.Load(stream).Secrets,
            Scopes,
            "user",
            CancellationToken.None,
            new FileDataStore(credPath, true));
      }
    }

    private async void InitializeService()
    {
      // wait until we're idle
      await Task.Yield();

      SetIsWorking(true);

      // Create Google Calendar API service.
      var credential = await FetchCredential();
      mService = new CalendarService(new BaseClientService.Initializer()
      {
        HttpClientInitializer = credential,
        ApplicationName = ApplicationName,
      });

      Focus();
      SetIsWorking(false);
    }

    private void ProcessSelectedNode()
    {
      var node = treeEvents.SelectedNode;
      if (node != null && node.Tag is SpecializedEvent ev)
      {
        tpnlCurrentEvent.Enabled = true;
        if (ev.HasSettings)
        {
          lblNoSettings.Visible = false;
          propertyGrid1.SelectedObject = ev.SettingsOjbect;
        }
        else
        {
          lblNoSettings.Visible = true;
        }
      }
      else
      {
        tpnlCurrentEvent.Enabled = false;
      }
    }

    private void treeEvents_AfterSelect(object sender, TreeViewEventArgs e)
    {
      ProcessSelectedNode();
    }

    private async void btnCreate_Click(object sender, EventArgs e)
    {
      if (treeEvents.SelectedNode?.Tag is SpecializedEvent ev)
      {
        var value = ev.CreateEvent();
        var request = mService.Events.Insert(value, "primary");
        var result = await request.ExecuteAsync();
        Process.Start(result.HtmlLink);
      }
    }
  }
}

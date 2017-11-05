using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Calendar.v3.Data;

namespace AddEventsToCalendar
{
  public class CakedayEvent : SpecializedEvent
  {
    const string TimeZone = "America/Chicago";

    private CakedayEventSettings mSettings = new CakedayEventSettings();

    public override string Name => "Cake Day! (2nd/4th Saturdays)";
    public override bool HasSettings => true;
    public override object SettingsOjbect => mSettings;

    public override Event CreateEvent()
    {
      var startDate = mSettings.StartDate;
      var date = new DateTime(startDate.Year, startDate.Month, 1);
      var month = date.Month;
      var saturdayCount = 0;
      while (true)
      {
        var day = date.DayOfWeek;
        if (day == DayOfWeek.Saturday)
        {
          ++saturdayCount;
          if ((saturdayCount == 2 || saturdayCount == 4) && date >= startDate)
          {
            break;
          }
        }

        date = date.AddDays(1);
        if (date.Month != month)
        {
          month = date.Month;
          saturdayCount = 0;
        }
      }

      return new Event
      {
        Summary = mSettings.Name,
        Start = new EventDateTime
        {
          DateTime = date,
          TimeZone = TimeZone,
        },
        End = new EventDateTime
        {
          DateTime = date,
          TimeZone = TimeZone,
        },
        Recurrence = new string[]
        {
          "RRULE:FREQ=MONTHLY;BYDAY=2SA,4SA",
        },
      };
    }

    private class CakedayEventSettings
    {
      const string DefaultEventName = "Cake Day";

      [DefaultValue(DefaultEventName)]
      [Description("The name of the event. The default is \""+ DefaultEventName +"\"")]
      public string Name { get; set; } = DefaultEventName;

      [Description("The date the event should start. Defaults to Today")]
      public DateTime StartDate { get; set; } = DateTime.Today;
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Calendar.v3.Data;

namespace AddEventsToCalendar
{
  public abstract class SpecializedEvent
  {
    public abstract string Name { get; }
    public virtual bool HasSettings { get; } = false;
    public virtual object SettingsOjbect { get; } = null;
    public abstract Event CreateEvent();
  }
}

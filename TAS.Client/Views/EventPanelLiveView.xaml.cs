
namespace TAS.Client.Views
{
    /// <summary>
    /// Interaction logic for EventPanel.xaml
    /// </summary>
    /// 

    public partial class EventPanelLiveView : EventPanelView
    {
        public EventPanelLiveView()
        {
            InitializeComponent();
            ApplySettings();
            _resizer = new EventPanelResizer(mainGrid, lbOffset);
        }
       readonly  EventPanelResizer _resizer;
        void ApplySettings()
        {
            UISettings.Apply(lbEventName);
            UISettings.Apply(lbTimeLeft);
            UISettings.ApplyToEventTime(lbScheduleTime);
            UISettings.ApplyToEventTime(lbOffset);
            UISettings.ApplyToEventTime(lbDuration);
            UISettings.ApplyToEventTime(lbEndTime);
        }
    }
}

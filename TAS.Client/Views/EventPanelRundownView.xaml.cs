using System.Windows.Controls;

namespace TAS.Client.Views
{
    /// <summary>
    /// Interaction logic for EventPanel.xaml
    /// </summary>
    public partial class EventPanelRundownView
    {
        public EventPanelRundownView()
        {
            InitializeComponent();
            ApplySettings();
            _resizer = new EventPanelResizer(mainGrid, lbOffset);
        }
        readonly EventPanelResizer _resizer;
        void ApplySettings()
        {
            UISettings.Apply(lbTimeLeft);
            UISettings.ApplyToEventTime(lbScheduleTime);
            UISettings.ApplyToEventTime(lbOffset);
            UISettings.ApplyToEventTime(lbDuration);
            UISettings.ApplyToEventTime(lbEndTime);
        }
    }

}

namespace SYBO.Subway.Managers;

public class QualitySettingsManager
{
	public class QualityTypeChangedEventArgs : EventArgs
	{
		private QualityType <QualityType>k__BackingField; //Field offset: 0x8

		public QualityType QualityType
		{
			 get { } //Length: 6
			internal set { } //Length: 8
		}

		public QualityTypeChangedEventArgs(QualityType qualityType) { }

		public QualityType get_QualityType() { }

		internal void set_QualityType(QualityType value) { }

	}

	private const string _QUALITY_LEVEL_NAME_GOOD = "Good"; //Field offset: 0x0
	private const string _QUALITY_LEVEL_NAME_DEMO_VIDEO_MODE = "Demo Video Mode"; //Field offset: 0x0
	private EventHandler<QualityTypeChangedEventArgs> OnQualityTypeChanged; //Field offset: 0x10

	public event EventHandler<QualityTypeChangedEventArgs> OnQualityTypeChanged
	{
		 add { } //Length: 292
		 remove { } //Length: 111
	}

	public QualitySettingsManager() { }

	public void add_OnQualityTypeChanged(EventHandler<QualityTypeChangedEventArgs> value) { }

	private void DebugLogQualitySettings(string callingMethodName) { }

	private int GetQualityLevelIntFromName(string qualityLevelName) { }

	private bool HasQualityLevelIntFromName(string qualityLevelName) { }

	private void RaiseOnQualityLevelChanged(QualityTypeChangedEventArgs e) { }

	public void remove_OnQualityTypeChanged(EventHandler<QualityTypeChangedEventArgs> value) { }

	private void SetQualityLevel(int qualityLevel) { }

	private void SetQualityLevel(string qualityLevelName) { }

	public void SetQualityType(QualityType qualityType) { }

	protected override void SubclassInitialize() { }

}


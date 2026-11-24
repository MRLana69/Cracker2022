namespace SYBO.Subway.Benchmarking.Processors;

public class GoogleSheetsProcessor : IBenchmarkProcessor
{
	private sealed class <TestGoogleConnection>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public GoogleSheetsProcessor <>4__this; //Field offset: 0x10
		private UnityWebRequest <request>5__2; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 736
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <TestGoogleConnection>d__23(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <UploadReportToGoogleSheets>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public GoogleSheetsProcessor <>4__this; //Field offset: 0x10
		public IBenchmark benchmark; //Field offset: 0x14
		private UnityWebRequest <request>5__2; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1619
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <UploadReportToGoogleSheets>d__20(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private class GoogleSheetsProcessorUpdater : MonoBehaviour
	{

		public GoogleSheetsProcessorUpdater() { }

	}

	private class ParameterContainer
	{
		private string <Key>k__BackingField; //Field offset: 0x8
		private string <Value>k__BackingField; //Field offset: 0xC

		public string Key
		{
			 get { } //Length: 6
			private set { } //Length: 8
		}

		public string Value
		{
			 get { } //Length: 6
			private set { } //Length: 11
		}

		public ParameterContainer(string key, string value) { }

		public string get_Key() { }

		public string get_Value() { }

		private void set_Key(string value) { }

		private void set_Value(string value) { }

	}

	public static Action OnUploadCompleted; //Field offset: 0x0
	private const string ValueParameterKey = "val"; //Field offset: 0x0
	private const string SpreadsheetIdParameterKey = "ssid"; //Field offset: 0x0
	private const string WorksheetNameParameterKey = "sheet"; //Field offset: 0x0
	private const string TemplateParameterKey = "template"; //Field offset: 0x0
	private const string ActionParameterKey = "action"; //Field offset: 0x0
	private const string GroupByParameterKey = "groupby"; //Field offset: 0x0
	private const string UploadSuccessResponse = "Upload Successful"; //Field offset: 0x0
	private const string ActionConnectTestParameter = "ConnectionTest"; //Field offset: 0x0
	private const string ConnectionTestSuccessResponse = "Connection Established"; //Field offset: 0x0
	private string _spreadsheetId; //Field offset: 0x8
	private string _googleScriptUrl; //Field offset: 0xC
	private string _worksheetName; //Field offset: 0x10
	private string _template; //Field offset: 0x14
	private GoogleSheetsProcessorUpdater _processorUpdater; //Field offset: 0x18
	private bool _connectionSuccessful; //Field offset: 0x1C

	public char SeparatorCharacter
	{
		 get { } //Length: 152
	}

	public GoogleSheetsProcessor(string worksheetNamePostfix = "", string overrideSheetId = "1HIlWcwxXV0dVjsf0gLpgFE0B0bei1vdn2xJNTAIxFv4", string overrideScriptUrl = "https://script.google.com/macros/s/AKfycbzysbyZuNXvOTJh5llqjN4N2dP4PAXusuwfaHjvTD3ESkx5Sas/exec") { }

	private string ConstructGetUriWithParameters(string url, List<ParameterContainer> parameters) { }

	private WWWForm ConstructPostParametersForm(List<ParameterContainer> parameters) { }

	public char get_SeparatorCharacter() { }

	public void Process(IBenchmark benchmark) { }

	private List<string> Serialize(IBenchmarkMetric[] metrics) { }

	private List<string> SerializeMetric(IBenchmarkMetric metric) { }

	private IEnumerator TestGoogleConnection() { }

	private IEnumerator UploadReportToGoogleSheets(IBenchmark benchmark) { }

}


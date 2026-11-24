using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using SYBO.Components.Analytics.Integration;
using SYBO.Components.Compression;
using SYBO.Components.Crypt;
using SYBO.Components.Logging;
using SYBO.Components.Logging.Ftp;
using UnityEngine;

namespace SYBO.Components.Analytics;

public class PersistentAnalyticsEventLog
{
	public const string LogFilePrefix = "Sybo_Analytics";

	private const int DefaultQueueSize = 16;

	private const byte LogBegin = 91;

	private const byte LogSeperator = 44;

	private const byte LogEnd = 93;

	private const string WriteFilename = "Sybo_Analytics_Buffer.log";

	private const string ChunkFilenameFormat = "Sybo_Analytics_Chunk_{0}.log";

	private string _writeFilePath;

	private string _chunkPathFormat;

	private int _chunkSizeThresholdBytes;

	private int _maxChunkCount;

	private long _storageLimitBytes;

	private MD5 _md5;

	private Queue<byte[]> _events;

	private EncryptedCTRStream _writeStream;

	private AutoResetEvent _workerThreadEvent;

	private int _chunkCount;

	private bool _full;

	private Thread _workerThread;

	private bool _workerThreadRunning;

	private bool _consumeChunk;

	private bool _isWorking;

	private AsyncRes _getChunkAsyncRes;

	private long _chunkSizes;

	private bool HasData__BackingField;

	public string LogWriteFilePath => "device_info";

	public bool HasData
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_writeFilePath != 0;
		}
		private set
		{
			//IL_01a6: Expected I, but got Obj
			//IL_01bc: Expected Obj, but got I
			//IL_022b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0230: Expected Obj, but got Unknown
			//IL_024c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0251: Expected Obj, but got Unknown
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected Obj, but got Unknown
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_00cc: Expected Obj, but got I4
			//IL_0108: Expected F4, but got I4
			//IL_01e3: Expected I4, but got F4
			//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ee: Expected Obj, but got Unknown
			//IL_0141: Expected F4, but got I4
			//IL_0189: Expected I8, but got I4
			//IL_017a: Expected F4, but got I4
			nint num = (nint)typeof(BaseSessionEvent);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Analytics.BaseSessionEvent>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BaseSessionEvent);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<SYBO.Components.Analytics.BaseSessionEvent>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((DeviceInfoEvent)this)._002Ector(value);
			object obj2 = this + 36;
			string text = BaseSessionEvent.GetOperatingSystem();
			obj2 = text;
			object obj3 = this + 40;
			string text2 = BaseSessionEvent.GetDeviceModel();
			obj3 = text2;
			object obj4 = this + 44;
			string text3 = BaseSessionEvent.GetDeviceID();
			obj4 = text3;
			object obj5 = this + 48;
			string text4 = BaseSessionEvent.GetISOThreeLetterLanguageCode();
			obj5 = text4;
			int sleepTimeout = Screen.sleepTimeout;
			_full = (byte)sleepTimeout != 0;
			int height = Screen.height;
			_workerThread = (Thread)height;
			float num3 = UnityEngine.Random.value;
			if (num3 != num3)
			{
				num3 = -2.1474836E+09f;
			}
			else if (!(num3 < 2.1474836E+09f))
			{
				num3 = -2.1474836E+09f;
			}
			else if (!(num3 > -2.1474836E+09f))
			{
				num3 = -2.1474836E+09f;
			}
			_workerThreadRunning = (byte)(int)num3 != 0;
			object obj6 = this - -64;
			IRandomGen randomGen = SyboRandom.MakeRandomGen();
			obj6 = randomGen;
			int physicalMemoryMB = SystemInfo.GetPhysicalMemoryMB();
			int processorCount = SystemInfo.GetProcessorCount();
			_chunkSizes = processorCount;
			string deviceUniqueIdentifier = SystemInfo.GetDeviceUniqueIdentifier();
		}
	}

	public bool IsWorking => HasData__BackingField;

	private bool HasWorkerThread
	{
		get
		{
			//IL_0047: Expected Obj, but got I4
			//IL_0012: Expected I4, but got Obj
			bool writeStream = GetWriteStream(openForAppend: false);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			FileStream fileStream = default;
			fileStream.Write((byte[])writeStream, 3, 1);
			return (byte)(int)((CompressionLogCategory)(object)fileStream).GetCallstackPrefixes() != 0;
		}
	}

	public unsafe PersistentAnalyticsEventLog(string storagePath, int chunkSizeThresholdKB, int storageLimitKB)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		object obj = ((int*)chunkSizeThresholdKB)->m_value;
		object obj2 = obj + 8;
		obj2 = obj;
		throw new ArrayTypeMismatchException();
	}

	public void Wipe()
	{
		HasData = true;
	}

	public void Append(string eventData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		bool flag = (byte)(eventData & 1) != 0;
		HasData__BackingField = flag;
	}

	public void Shutdown()
	{
		//IL_004e: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I4
		bool flag = default;
		bool flag2 = default;
		while (true)
		{
			int num = _maxChunkCount << 1;
			if ((flag ? 1 : 0) >= num)
			{
				break;
			}
			bool writeStream = GetWriteStream(flag);
			if (File.GetAttributes((string)writeStream) != 0)
			{
				bool writeStream2 = GetWriteStream(flag);
				((FileStream)writeStream2).ExposeHandle();
			}
			flag = (byte)((flag2 ? 1u : 0u) + 1u) != 0;
		}
		_chunkCount = 0;
		WakeWorkerThread();
		if (File.GetAttributes(_writeFilePath) != 0)
		{
			((FileStream)(object)_writeFilePath).ExposeHandle();
		}
		HasData__BackingField = false;
	}

	public void Replace(string current, string replacement)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(BaseSessionEvent);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<SYBO.Components.Analytics.BaseSessionEvent>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BaseSessionEvent);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v20 (Il2CppClass<SYBO.Components.Analytics.BaseSessionEvent>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = current + 8;
		obj2 = current;
		throw new ArrayTypeMismatchException();
	}

	public unsafe void ConsumeChunk()
	{
		if (_workerThread != null && ~(_workerThreadRunning ? 1u : 0u) == 0)
		{
			_workerThreadRunning = false;
			bool flag = ((System.Threading.ExecutionContextSwitcher*)_workerThreadEvent)->UndoNoThrow();
			while (_workerThread != null)
			{
			}
			WakeWorkerThread();
		}
	}

	public AsyncRes GetNextChunkForServerAsync()
	{
		//IL_0019: Expected Obj, but got I4
		bool isWorking = _isWorking;
		return (AsyncRes)isWorking;
	}

	public unsafe string GetMD5Hash(byte[] data)
	{
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected Obj, but got Unknown
		//IL_0322: Expected Obj, but got I4
		//IL_0028: Expected I4, but got Obj
		//IL_003b: Expected I4, but got Obj
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected Obj, but got Unknown
		//IL_036e: Expected I, but got Obj
		//IL_0384: Expected Obj, but got I
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Expected Obj, but got Unknown
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Expected Obj, but got Unknown
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected Obj, but got Unknown
		//IL_0528: Expected Obj, but got VT
		//IL_0482: Expected I, but got Obj
		//IL_0498: Expected Obj, but got I
		//IL_00e8: Expected I, but got Obj
		//IL_03ba: Expected Obj, but got VT
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected Obj, but got Unknown
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected Obj, but got Unknown
		//IL_00a5: Expected Obj, but got I4
		//IL_0247: Expected I4, but got Obj
		//IL_0247: Expected I4, but got Obj
		//IL_0247: Expected Obj, but got I
		//IL_0135: Expected I, but got Obj
		//IL_00ca: Expected I4, but got Obj
		//IL_0268: Expected Obj, but got I4
		//IL_0271: Expected Obj, but got I4
		//IL_019a: Expected I, but got Obj
		//IL_01ac: Expected I, but got Obj
		//IL_01c2: Expected Obj, but got I
		//IL_02a6: Expected I4, but got Obj
		//IL_02a6: Expected Obj, but got I
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected Obj, but got Unknown
		//IL_0437: Expected Obj, but got I
		//IL_01ed: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		if (_chunkCount == 0)
		{
			((FtpClient)this).Close();
		}
		string[] callstackPrefixes = ((AnalyticsLogCategory)this).GetCallstackPrefixes();
		string text = string.ConcatArray((string[])(object)"NLST ", (int)data);
		((AnalyticsLogCategory)this)._002Ector((int)text);
		if ((nint)_workerThreadEvent != 150 && (nint)_workerThreadEvent != 125)
		{
			string text2 = ((string)(object)_md5).Trim((char[])4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			AggregatedDataTracking.DataContainer dataContainer = default;
			dataContainer._002Ector((AggregatedDataTracking.DataCompleteness)text2, -1);
			((FtpClient)(object)dataContainer).GetFileList((string)null);
		}
		object obj3 = this + 28;
		obj3 = "";
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v24 (Il2CppClass<System.DateTime>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v100 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 32;
		object obj6 = obj2 + 24;
		object obj7 = obj2 + 8;
		DateTime utcNow = DateTime.UtcNow;
		obj = utcNow;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCA5");
		object obj9 = default;
		int totalLength = default;
		bool flag2;
		do
		{
			nint num3 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v39 (Il2CppClass<System.DateTime>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num4 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v96 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			DateTime utcNow2 = DateTime.UtcNow;
			obj7 = obj9;
			obj2 = utcNow2;
			obj6 = obj7;
			obj5 = obj2;
			object obj10 = obj6 & 0x3FFFFFFFFFFFFFFFL;
			object obj11 = obj5 & 0x3FFFFFFFFFFFFFFFL;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11))
			{
				break;
			}
			bool full = _full;
			bool full2 = _full;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S2_v16 (System.Boolean)+C]");
			bool flag = Socket.Poll_internal((IntPtr)callstackPrefixes, full2 ? SelectMode.SelectWrite : SelectMode.SelectRead, 0, out *(int*)null);
			nint num5 = (nint)typeof(FtpClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v82 (Il2CppClass<SYBO.Components.Logging.Ftp.FtpClient>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num6 = (nint)typeof(FtpClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S0_v90 (Il2CppClass<SYBO.Components.Logging.Ftp.FtpClient>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj13 = this + 28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.PersistentAnalyticsEventLog)+1C]");
			string text3 = string.ConcatArray((string[])0, totalLength);
			obj13 = text3;
			bool full3 = _full;
			flag2 = flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S1_v60 (System.Boolean)+C]");
		}
		while ((nint)(flag2 ? 1 : 0) >= (nint)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.PersistentAnalyticsEventLog)+1C]");
		string text4 = ((string)0).Remove((int)"\r", (int)"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num7 = default;
		object obj14 = num7 + 16;
		obj14 = 10;
		string text5 = text4.Substring(num7);
		((Socket)(object)callstackPrefixes).ThrowIfDisposedAndClosed();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.PersistentAnalyticsEventLog)+1C]");
		int num8 = ((string)0).LastIndexOf((char)(int)"No such file or directory");
		bool flag3 = num8 != -1;
		bool flag4 = !flag3;
		string result = text5;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			string text6 = default;
			result = text6;
		}
		((FtpClient)this).cleanup();
		if ((nint)_workerThreadEvent != 226)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			string text7 = default;
			result = text7;
		}
		return result;
	}

	private void WorkerThreadLoop(object ignored)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected Obj, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected Obj, but got Unknown
		//IL_02ee: Expected Obj, but got I4
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_034b: Expected Obj, but got I
		//IL_035f: Expected Obj, but got I4
		//IL_0384: Expected I4, but got Obj
		//IL_00f1: Expected Obj, but got I4
		//IL_0062: Expected I, but got Obj
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_0167: Expected Obj, but got I4
		//IL_021f: Expected Obj, but got I
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 4;
		object obj4 = obj2 + 16;
		obj4 = 0;
		object obj5 = obj2 + 8;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ignored @ L1 (System.Object)+8]");
		if ((nint)0 > (nint)_chunkSizeThresholdBytes)
		{
			nint num = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v89 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(Log);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v96 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ignored @ L1 (System.Object)+8]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			obj2 = _chunkSizeThresholdBytes;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string format = default;
			object arg = default;
			Log.Analytics.LogErrorFormat((int)"Trying to add supersized analytics event to log! Event data is {0} bytes, max chunk size {2}, content:\n{1}", format, ignored, arg);
			return;
		}
		if (~(_full ? 1u : 0u) == 0)
		{
			return;
		}
		Encoding uTF = Encoding.UTF32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		((AsyncRes)this)._002Ector();
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		HasData__BackingField = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		object obj7 = obj5 + 4;
		object obj8 = obj7 + 1;
		obj7 = obj8;
		object obj9 = obj8 << 2;
		object obj10 = obj5 + obj9;
		obj10 = 130;
		if (obj4 != null)
		{
			throw new ArgumentNullException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16+4]");
			object obj11 = (nint)0 << 2;
			object obj12 = obj5 + obj11;
			if ((nint)obj12 == 130)
			{
				object obj13 = obj5 + 4;
				if ((nint)obj13 > -1)
				{
					object obj14 = obj13 + -1;
					obj13 = obj14;
				}
				goto IL_03ac;
			}
		}
		object obj15 = default;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_03ac;
		IL_03ac:
		StartWorkerThreadIfNeeded();
	}

	private void UpdateChunkSizes()
	{
		_consumeChunk = true;
		StartWorkerThreadIfNeeded();
	}

	private string GetChunkFilename(int chunkIdx)
	{
		//IL_0061: Expected Obj, but got I4
		//IL_0073: Expected I, but got Obj
		//IL_0089: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		HashAlgorithm hashAlgorithmWithFipsFallback = HMAC.GetHashAlgorithmWithFipsFallback((Func<HashAlgorithm>)(object)_md5, (Func<HashAlgorithm>)chunkIdx);
		nint num = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v4 (Il2CppClass<System.Convert>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v9 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (string)(object)Convert.FromBase64String((string)(object)hashAlgorithmWithFipsFallback);
	}

	private bool GetWriteStream(bool openForAppend)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		object obj = openForAppend;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		return (byte)(int)string.Format(_chunkPathFormat, args) != 0;
	}

	private Stream GetChunkReader()
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_001d: Expected I4, but got Obj
		object obj = this - -64;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Exception ex = default;
			ex.SetErrorCode((int)"Sybo Analytics: Only one GetNextChunkForServerAsync request allowed at a time.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			return null;
		}
		object obj2 = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Stream stream = default;
		obj2 = stream;
		StartWorkerThreadIfNeeded();
		return stream;
	}

	private void CloseWriteStream()
	{
		//IL_00d2: Expected I8, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_0059: Expected Obj, but got I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected I8, but got Unknown
		_chunkSizes = 0L;
		bool flag = false;
		FileLoadException ex = default;
		while ((flag ? 1 : 0) < _chunkCount)
		{
			bool writeStream = GetWriteStream(flag);
			if (File.GetAttributes((string)writeStream) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ex._002Ector((string)writeStream);
				DateTime lastWriteTimeUtc = ((FileSystemInfo)(object)ex).LastWriteTimeUtc;
				long chunkSizes = (long)(lastWriteTimeUtc + _chunkSizes);
				_chunkSizes = chunkSizes;
			}
			bool flag2 = (byte)((flag ? 1u : 0u) + 1u) != 0;
			flag = flag2;
		}
		if (_chunkSizes >= _storageLimitBytes)
		{
			_full = true;
		}
	}

	private void WakeWorkerThread()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_004d: Expected Obj, but got I4
		if (_writeStream != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			_writeStream.Flush();
			object obj = this + 40;
			obj = 0;
		}
	}

	private unsafe void StartWorkerThreadIfNeeded()
	{
		((AsyncRes)this)._002Ector();
		_isWorking = true;
		bool flag = ((System.Threading.ExecutionContextSwitcher*)_workerThreadEvent)->UndoNoThrow();
	}

	private byte[] ReadChunk()
	{
		//IL_0019: Expected Obj, but got I4
		bool flag = _workerThread != null;
		return (byte[])flag;
	}
}

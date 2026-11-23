using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using SYBO.Components.Crypt;
using SYBO.Components.Logging;

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

	public string LogWriteFilePath => _writeFilePath;

	public bool HasData
	{
		get
		{
			return HasData__BackingField;
		}
		private set
		{
			HasData__BackingField = value;
		}
	}

	public bool IsWorking
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S0_v4+F]");
			_ = 0;
			return _isWorking;
		}
	}

	private bool HasWorkerThread
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S0_v4+F]");
			_ = 0;
			return _workerThread != null;
		}
	}

	public PersistentAnalyticsEventLog(string storagePath, int chunkSizeThresholdKB, int storageLimitKB)
	{
		//IL_0084: Expected I8, but got I4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected Obj, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected I4, but got Unknown
		//IL_0234: Expected Obj, but got I4
		if (!Directory.Exists(storagePath))
		{
			DirectoryInfo directoryInfo = Directory.CreateDirectory(storagePath);
		}
		string writeFilePath = Path.Combine(storagePath, "Sybo_Analytics_Buffer.log");
		_writeFilePath = writeFilePath;
		string chunkPathFormat = Path.Combine(storagePath, "Sybo_Analytics_Chunk_{0}.log");
		_chunkPathFormat = chunkPathFormat;
		int num = default;
		int chunkSizeThresholdBytes = num << 10;
		_chunkSizeThresholdBytes = chunkSizeThresholdBytes;
		int num2 = storageLimitKB << 10;
		_storageLimitBytes = num2;
		int num3 = num2 / _chunkSizeThresholdBytes;
		int maxChunkCount = num3 + 1;
		_maxChunkCount = maxChunkCount;
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v17+F]");
		_ = 0;
		object obj3 = obj + 16;
		_chunkCount = 0;
		object obj4 = obj3;
		int num4 = 0;
		while (_maxChunkCount > num4)
		{
			string chunkFilename = GetChunkFilename(num4);
			if (File.Exists(chunkFilename))
			{
				object obj5 = obj4 - 16;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v48+F]");
				_ = 0;
				object obj6 = obj5 + 16;
				if (num4 != _chunkCount)
				{
					object[] args = Array.Empty<object>();
					Log.Analytics.LogWarningFormat("Analytics recovering lost chunk left behind from crash.", args);
					string chunkFilename2 = GetChunkFilename(num4);
					File.Move(chunkFilename, chunkFilename2);
				}
				object obj7 = obj6 - 16;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v59+F]");
				_ = 0;
				object obj8 = obj7 + 16;
				int num5 = obj8 - 16;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v65 (System.Int32)+F]");
				_ = 0;
				object obj9 = num5 + 16;
				int chunkCount = _chunkCount + 1;
				_chunkCount = chunkCount;
				obj4 = obj9;
			}
			int num6 = num4 + 1;
			num4 = num6;
		}
		UpdateChunkSizes();
		object obj10 = obj4 - 16;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v32+F]");
		_ = 0;
		bool flag = _chunkCount >= 1 || File.Exists(_writeFilePath);
		HasData__BackingField = flag;
		MD5 md = MD5.Create();
		_md5 = md;
	}

	public void Wipe()
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		int num = 0;
		while (true)
		{
			int num2 = _maxChunkCount << 1;
			if (num >= num2)
			{
				break;
			}
			string chunkFilename = GetChunkFilename(num);
			if (File.Exists(chunkFilename))
			{
				string chunkFilename2 = GetChunkFilename(num);
				File.Delete(chunkFilename2);
			}
			int num3 = num + 1;
			num = num3;
		}
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v6+F]");
		_ = 0;
		_chunkCount = 0;
		CloseWriteStream();
		if (File.Exists(_writeFilePath))
		{
			File.Delete(_writeFilePath);
		}
		HasData__BackingField = false;
	}

	public void Append(string eventData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_01ab: Expected I, but got Obj
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_01fc: Expected Obj, but got I4
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected Obj, but got Unknown
		//IL_002f: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got I8
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		if (eventData._stringLength > _chunkSizeThresholdBytes)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			obj = eventData._stringLength;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			throw new ArrayTypeMismatchException();
		}
		object obj3 = obj - 16;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v18+F]");
		_ = 0;
		if (~(_full ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			obj = _chunkSizes;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			throw new ArrayTypeMismatchException();
		}
		Encoding uTF = Encoding.UTF8;
		nint num = (nint)uTF;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v84 @ S2_v3 (Il2CppClass<System.Text.Encoding>)+154] (should have been resolved before IL gen)");
		StartWorkerThreadIfNeeded();
		_ = 0;
		_ = _events;
		object obj4 = obj + 28;
		object obj5 = obj + 27;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		_ = 0;
		object obj6 = obj + 27;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			HasData__BackingField = true;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_0359;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj7 = default;
		object obj8 = default;
		bool flag = obj7 != obj8;
		object obj10 = default;
		object obj9 = obj10;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			object obj11 = default;
			obj = obj11;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_0359;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			object obj12 = default;
			obj9 = obj12;
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return;
		IL_0359:
		throw new ArgumentNullException();
	}

	public void Shutdown()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S0_v4+F]");
		_ = 0;
		object obj3 = obj + 16;
		if (_workerThread == null)
		{
			return;
		}
		object obj4 = obj3 - 16;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v15+F]");
		_ = 0;
		object obj5 = obj4 + 16;
		if (~(_workerThreadRunning ? 1u : 0u) == 0)
		{
			object obj6 = obj5 - 16;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v23+F]");
			_ = 0;
			object obj7 = obj6 + 16;
			_workerThreadRunning = false;
			bool flag = _workerThreadEvent.Set();
			do
			{
				object obj8 = obj7 - 16;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v36+F]");
				_ = 0;
			}
			while (_workerThread != null);
			CloseWriteStream();
		}
	}

	public void Replace(string current, string replacement)
	{
		if (~(HasData__BackingField ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotImplementedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public void ConsumeChunk()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
		_ = 0;
		_consumeChunk = true;
		WakeWorkerThread();
	}

	public AsyncRes GetNextChunkForServerAsync()
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+F]");
		_ = 0;
		object obj3 = obj + 16;
		Exception ex = default;
		if (_getChunkAsyncRes != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ex._002Ector("Sybo Analytics: Only one GetNextChunkForServerAsync request allowed at a time.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		object obj4 = obj3 - 16;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v19+F]");
		_ = 0;
		AsyncRes asyncRes = default;
		((PersistentAnalyticsEventLog)(object)ex)._getChunkAsyncRes = asyncRes;
		((PersistentAnalyticsEventLog)(object)ex).WakeWorkerThread();
		return asyncRes;
	}

	public string GetMD5Hash(byte[] data)
	{
		byte[] inArray = _md5.ComputeHash(data);
		return Convert.ToBase64String(inArray);
	}

	private void WorkerThreadLoop(object ignored)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_293b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2940: Expected Obj, but got Unknown
		//IL_2949: Unknown result type (might be due to invalid IL or missing references)
		//IL_294e: Expected Obj, but got Unknown
		//IL_2976: Unknown result type (might be due to invalid IL or missing references)
		//IL_297b: Expected Obj, but got Unknown
		//IL_2997: Unknown result type (might be due to invalid IL or missing references)
		//IL_299c: Expected Obj, but got Unknown
		//IL_289d: Unknown result type (might be due to invalid IL or missing references)
		//IL_28a2: Expected Obj, but got Unknown
		//IL_28be: Unknown result type (might be due to invalid IL or missing references)
		//IL_28c3: Expected Obj, but got Unknown
		//IL_28d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_28d8: Expected Obj, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Obj, but got Unknown
		//IL_021c: Expected Obj, but got I4
		//IL_0135: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [52F91F]");
		bool flag = (nint)0 == 0;
		bool flag2 = !flag;
		_ = 0;
		_ = 0;
		object obj3 = this - -64;
		object obj4 = obj + 32;
		_ = 0;
		object obj5 = obj;
		object obj6 = obj5 - 16;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v17+F]");
		_ = 0;
		object obj7 = obj6 + 16;
		if (~(_workerThreadRunning ? 1u : 0u) == 0)
		{
			_ = 0;
			_ = _events;
			object obj8 = obj + 44;
			object obj9 = obj + 43;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			_ = 0;
			object obj10 = obj + 43;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Queue<byte[]> events = _events;
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					bool flag3 = events._size < 1;
					bool flag4 = !flag3;
					if (!flag4)
					{
						object obj11 = 0;
					}
					else
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag5 = (nint)0 != 1;
						flag2 = flag4;
						object obj12 = default;
						object obj11 = obj12;
						if (!flag5)
						{
							goto IL_0188;
						}
					}
					goto IL_0232;
				}
			}
			goto IL_0188;
		}
		object obj13 = obj7 - 16;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v28+F]");
		_ = 0;
		object obj14 = obj13 + 16;
		_workerThread = null;
		object obj15 = obj14 - 16;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v35+F]");
		_ = 0;
		_isWorking = false;
		return;
		IL_0188:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj16 = default;
		object obj17 = default;
		bool flag6 = obj16 != obj17;
		object obj19 = default;
		object obj18 = obj19;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag7 = (nint)0 == 1;
			object obj11 = 0;
			bool flag4 = flag2;
			if (!flag7)
			{
				goto IL_0232;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			object obj20 = default;
			obj18 = obj20;
		}
		_ = 0;
		object obj21 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return;
		IL_0232:
		throw new ArgumentNullException();
	}

	private void UpdateChunkSizes()
	{
		//IL_00e6: Expected I8, but got I4
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		_chunkSizes = 0L;
		int num = 0;
		object obj2 = default;
		FileInfo fileInfo = default;
		while (true)
		{
			object obj = obj2 - 16;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v11+F]");
			_ = 0;
			obj2 = obj + 16;
			if (num >= _chunkCount)
			{
				break;
			}
			string chunkFilename = GetChunkFilename(num);
			if (File.Exists(chunkFilename))
			{
				fileInfo._002Ector(chunkFilename);
				long length = fileInfo.Length;
				long chunkSizes = _chunkSizes + length;
				_chunkSizes = chunkSizes;
			}
			int num2 = num + 1;
			num = num2;
		}
		if (_chunkSizes >= _storageLimitBytes)
		{
			object obj3 = obj2 - 16;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v23+F]");
			_ = 0;
			_full = true;
		}
	}

	private string GetChunkFilename(int chunkIdx)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		return string.Format(_chunkPathFormat, arg);
	}

	private bool GetWriteStream(bool openForAppend)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_01b3: Expected I, but got Obj
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0182: Expected I, but got Obj
		//IL_0126: Expected I, but got Obj
		EncryptedCTRStream writeStream = _writeStream;
		if (_writeStream == null)
		{
			object obj2 = default;
			object obj = obj2 - 16;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v16+F]");
			_ = 0;
			object obj3 = obj + 16;
			if (_maxChunkCount <= _chunkCount)
			{
				object obj4 = obj3 - 16;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v46+F]");
				_ = 0;
				_full = true;
				return false;
			}
			FileStream fileStream = default;
			if (!File.Exists(_writeFilePath))
			{
				fileStream._002Ector(_writeFilePath, FileMode.CreateNew, FileAccess.Write, FileShare.Read);
				EncryptedCTRStream writeStream2 = EncryptedCTRStream.WriteStream(fileStream);
				_writeStream = writeStream2;
				EncryptedCTRStream writeStream3 = _writeStream;
				nint num = (nint)writeStream3;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v155 @ S2_v8 (Il2CppClass<SYBO.Components.Crypt.EncryptedCTRStream>)+1DC] (should have been resolved before IL gen)");
				return true;
			}
			fileStream._002Ector(_writeFilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.Read);
			EncryptedCTRStream writeStream4 = EncryptedCTRStream.WriteStream(fileStream);
			_writeStream = writeStream4;
			if (openForAppend)
			{
				EncryptedCTRStream writeStream5 = _writeStream;
				nint num2 = (nint)writeStream5;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v161 @ S2_v13 (Il2CppClass<SYBO.Components.Crypt.EncryptedCTRStream>)+1DC] (should have been resolved before IL gen)");
				return true;
			}
		}
		else if (openForAppend)
		{
			nint num3 = (nint)writeStream;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v66 @ S2_v3 (Il2CppClass<SYBO.Components.Crypt.EncryptedCTRStream>)+1DC] (should have been resolved before IL gen)");
		}
		return true;
	}

	private Stream GetChunkReader()
	{
		string chunkFilename = GetChunkFilename(0);
		FileStream fileStream = default;
		fileStream._002Ector(chunkFilename, FileMode.Open, FileAccess.Read);
		return EncryptedCTRStream.ReadStream(fileStream);
	}

	private void CloseWriteStream()
	{
		//IL_0031: Expected I, but got Obj
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_0066: Expected Obj, but got I4
		EncryptedCTRStream writeStream = _writeStream;
		if (_writeStream != null)
		{
			nint num = (nint)writeStream;
			object obj = writeStream + 160;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v3 (Il2CppClass<SYBO.Components.Crypt.EncryptedCTRStream>)+15C] (should have been resolved before IL gen)");
			object obj2 = this + 40;
			((EncryptedCTRStream)obj2).Dispose();
			obj2 = 0;
		}
	}

	private void WakeWorkerThread()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected Obj, but got Unknown
		StartWorkerThreadIfNeeded();
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S0_v3+F]");
		_ = 0;
		_isWorking = true;
		bool flag = _workerThreadEvent.Set();
	}

	private unsafe void StartWorkerThreadIfNeeded()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		if (!HasWorkerThread)
		{
			object obj2 = default;
			object obj = obj2 - 16;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10+F]");
			_ = 0;
			object obj3 = obj + 16;
			_workerThreadRunning = true;
			object obj4 = obj3 - 16;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+F]");
			_ = 0;
			object obj5 = obj4 + 16;
			_isWorking = true;
			Queue<byte[]> queue = default;
			queue._002Ector(16);
			_events = queue;
			AutoResetEvent autoResetEvent = default;
			autoResetEvent._002Ector(initialState: false);
			_workerThreadEvent = autoResetEvent;
			ParameterizedThreadStart parameterizedThreadStart = default;
			parameterizedThreadStart._002Ector(this, (nint)__ldftn(PersistentAnalyticsEventLog.WorkerThreadLoop));
			Thread thread = default;
			thread._002Ector(parameterizedThreadStart);
			object obj6 = obj5 - 16;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v38+F]");
			_ = 0;
			object obj7 = obj6 + 16;
			_workerThread = thread;
			object obj8 = obj7 - 16;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v47+F]");
			_ = 0;
			_workerThread.Start();
		}
	}

	private byte[] ReadChunk()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected Obj, but got Unknown
		//IL_00af: Expected Obj, but got I
		//IL_031a: Expected Obj, but got I
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		Stream chunkReader = GetChunkReader();
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3DE");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		byte[] result;
		object obj5;
		byte[] array2;
		if ((nint)0 != 1)
		{
			object obj4 = default;
			if ((long)obj4 < 2147483648L)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3DE");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag = (nint)0 != 1;
						byte[] array = default;
						result = array;
						obj5 = obj;
						if (flag)
						{
							goto IL_03ad;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_01d3;
			}
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag2 = (nint)0 != 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				array2 = (byte[])0;
				obj5 = obj;
				if (flag2)
				{
					goto IL_031f;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_01d3;
		IL_03ad:
		object obj6 = obj5 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		return result;
		IL_031f:
		result = array2;
		goto IL_03ad;
		IL_01d3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj7 = default;
		object obj8 = default;
		bool flag3 = obj7 == obj8;
		bool flag4 = !flag3;
		byte[] array3 = default;
		array2 = array3;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag5 = (nint)0 != 1;
			result = null;
			obj5 = obj;
			if (flag5)
			{
				goto IL_03ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			byte[] array4 = default;
			array2 = array4;
		}
		_ = 0;
		object obj9 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj5 = 0;
			goto IL_031f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return array2;
	}
}

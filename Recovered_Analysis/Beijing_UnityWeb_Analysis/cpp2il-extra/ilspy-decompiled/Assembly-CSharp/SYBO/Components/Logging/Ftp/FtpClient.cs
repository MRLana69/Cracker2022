using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using SYBO.Components.Analytics;
using SYBO.Components.Analytics.Integration;
using SYBO.Components.Settings;
using UnityEngine;

namespace SYBO.Components.Logging.Ftp;

public class FtpClient
{
	public class FtpException : Exception
	{
		public int ResultCode;

		public FtpException(string message, int resultCode = -1)
		{
		}

		public FtpException(string message, Exception innerException, int resultCode = -1)
		{
			//IL_001b: Expected Obj, but got I
			//IL_002b: Expected Obj, but got I
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected Obj, but got Unknown
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected Obj, but got Unknown
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected Obj, but got Unknown
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected Obj, but got Unknown
			//IL_007f: Expected Obj, but got I4
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S2_v2 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v3+60]");
			object obj2 = 0;
			object obj3 = obj2;
			object obj4 = obj3 & 0x3FFF;
			object obj5 = obj4 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v26 @ S3_v4 (should have been resolved before IL gen)");
			object obj6 = this + 16;
			obj6 = innerException;
			object obj7 = this + 20;
			obj7 = resultCode;
		}

		public static FtpException FromResult(string result)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_0226: Expected Obj, but got Unknown
			//IL_022f: Expected Obj, but got I4
			//IL_0244: Unknown result type (might be due to invalid IL or missing references)
			//IL_0249: Expected Obj, but got Unknown
			//IL_0252: Expected Obj, but got I4
			//IL_025b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0260: Expected Obj, but got Unknown
			//IL_028a: Unknown result type (might be due to invalid IL or missing references)
			//IL_028f: Expected Obj, but got Unknown
			//IL_029c: Expected Obj, but got I4
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Expected Obj, but got Unknown
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Expected Obj, but got Unknown
			//IL_0107: Expected Obj, but got I4
			//IL_016e: Expected Obj, but got I
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Expected Obj, but got Unknown
			//IL_01da: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - -64;
			object obj3 = obj2 + 40;
			obj3 = 0;
			_ = 0;
			_ = 0;
			object obj4 = obj2 + 24;
			obj4 = 0;
			object obj5 = obj2 + 32;
			obj5 = obj;
			_ = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CachingRootFileJsonSettingsParser._003C_003Ec obj6 = default;
			obj6._002Ector();
			object obj7 = obj6 + 12;
			obj7 = result.m_firstChar;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
			_ = 0;
			object obj8 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj8 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			}
			object obj9 = obj5 + 4;
			object obj10 = obj9 + 1;
			obj9 = obj10;
			object obj11 = obj10 << 2;
			object obj12 = obj5 + obj11;
			obj12 = 90;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
				object obj13 = (nint)0 << 2;
				object obj14 = obj5 + obj13;
				if ((nint)obj14 == 90)
				{
					object obj15 = obj5 + 4;
					if ((nint)obj15 > -1)
					{
						object obj16 = obj15 + -1;
						obj15 = obj16;
					}
					goto IL_0315;
				}
			}
			object obj17 = default;
			if (obj17 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_0315;
			IL_0315:
			return (FtpException)(object)obj6;
		}
	}

	private static int BUFFER_SIZE;

	private static Encoding ASCII;

	private bool verboseDebugging;

	private string server;

	private string remotePath;

	private string username;

	private string password;

	private string message;

	private string result;

	private int port;

	private int bytes;

	private int resultCode;

	private bool loggedin;

	private bool binMode;

	private byte[] buffer;

	private Socket clientSocket;

	private int timeoutSeconds;

	public bool VerboseDebugging
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			throw new ArrayTypeMismatchException();
		}
		set
		{
			//IL_00c9: Expected I, but got Obj
			//IL_00df: Expected Obj, but got I
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Expected Obj, but got Unknown
			//IL_0144: Expected I, but got Obj
			//IL_015a: Expected Obj, but got I
			//IL_0177: Expected I, but got Obj
			//IL_0112: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(LogCategory);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			verboseDebugging = value;
			object obj2 = this + 12;
			obj2 = "Log";
			nint num3 = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v14 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			bool flag = obj3 == null;
			nint num4 = (nint)typeof(Log);
			if (!flag)
			{
				nint num5 = (nint)typeof(Log);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v21 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(Log);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(Log);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ L1_v2 (Il2CppClass<SYBO.Components.Logging.Log>)+5C]");
			object obj4 = (nint)0 + (nint)32;
			obj4 = this;
		}
	}

	public int Port
	{
		get
		{
			return verboseDebugging ? 1 : 0;
		}
		set
		{
			int num = value & 1;
			verboseDebugging = (byte)num != 0;
		}
	}

	public int Timeout
	{
		get
		{
			return port;
		}
		set
		{
			port = value;
		}
	}

	public string Server
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (string)timeoutSeconds;
		}
		set
		{
			//IL_000a: Expected I4, but got Obj
			timeoutSeconds = (int)value;
		}
	}

	public int RemotePort
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)server;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 12;
			obj = value;
		}
	}

	public string RemotePath
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (string)port;
		}
		set
		{
			//IL_000a: Expected I4, but got Obj
			port = (int)value;
		}
	}

	public string Username
	{
		get
		{
			return remotePath;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 16;
			obj = value;
		}
	}

	public string Password
	{
		get
		{
			return username;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 20;
			obj = value;
		}
	}

	public bool BinaryMode
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)password != 0;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 24;
			obj = value;
		}
	}

	public FtpClient()
	{
	}

	public FtpClient(string server, string username, string password)
	{
		//IL_0022: Expected Obj, but got I
		//IL_00f0: Expected I, but got Obj
		//IL_0106: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I4
		//IL_0062: Expected I, but got Obj
		//IL_0078: Expected Obj, but got I
		//IL_0131: Expected I, but got Obj
		//IL_01ba: Expected Obj, but got I4
		//IL_01ba: Expected Obj, but got I4
		//IL_00a3: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [server @ L1 (System.String)+14]");
		if (0 < (nint)username)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [server @ L1 (System.String)+14]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [server @ L1 (System.String)+18]");
		object obj = num - 0;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) < System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref username))
		{
			((Application.AdvertisingIdentifierCallback)3).EndInvoke(null);
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v25 (Il2CppClass<UnityEngine.Debug>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num3 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v31 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Debug.LogWarning(password);
			((Application.AdvertisingIdentifierCallback)3).EndInvoke((IAsyncResult)1);
			return;
		}
		nint num4 = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v14 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v19 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogWarning(password);
	}

	public FtpClient(string server, string username, string password, int timeoutSeconds, int port)
	{
		//IL_0022: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I
		//IL_0127: Expected I, but got Obj
		//IL_013d: Expected Obj, but got I
		//IL_020f: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I
		//IL_0168: Expected I, but got Obj
		//IL_0080: Expected I, but got Obj
		//IL_0096: Expected Obj, but got I
		//IL_01ea: Expected Obj, but got I4
		//IL_01f9: Expected Obj, but got I4
		//IL_01f9: Expected Obj, but got I4
		//IL_00c1: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [server @ L1 (System.String)+14]");
		if (0 < (nint)username)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [server @ L1 (System.String)+14]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [server @ L1 (System.String)+18]");
		object obj = num - 0;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) < System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref username))
		{
			((Application.AdvertisingIdentifierCallback)3).EndInvoke(null);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [server @ L1 (System.String)+10]");
			string format = string.ConcatArray((string[])0, timeoutSeconds);
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v31 (Il2CppClass<UnityEngine.Debug>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num3 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v37 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Debug.LogWarningFormat((UnityEngine.Object)(object)password, format, (object[])port);
			((Application.AdvertisingIdentifierCallback)3).EndInvoke((IAsyncResult)1);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [server @ L1 (System.String)+10]");
		string format2 = string.ConcatArray((string[])0, timeoutSeconds);
		nint num4 = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v17 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v22 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogWarningFormat((UnityEngine.Object)(object)password, format2, (object[])port);
	}

	public void Login()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_00bb: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		object obj = this + 12;
		obj = "localhost";
		object obj2 = this + 16;
		obj2 = ".";
		object obj3 = this + 20;
		obj3 = "anonymous";
		object obj4 = this + 24;
		obj4 = "anonymous@anonymous.net";
		port = 21;
		nint num = (nint)typeof(FtpClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v15 (Il2CppClass<SYBO.Components.Logging.Ftp.FtpClient>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(FtpClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v22 (Il2CppClass<SYBO.Components.Logging.Ftp.FtpClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = this + 52;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj7 = default;
		obj6 = obj7;
		timeoutSeconds = 10;
	}

	public void Close()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002e: Expected I4, but got Obj
		//IL_0040: Expected I, but got Obj
		//IL_0056: Expected Obj, but got I
		//IL_0081: Expected I, but got Obj
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		if (~(loggedin ? 1u : 0u) == 0)
		{
			readResponse();
		}
		string text = string.ConcatArray((string[])(object)"[FtpClient] Opening connection to ", (int)server);
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v10 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v103 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogError(text);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
		object obj4 = this + 56;
		object obj5 = default;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj7 = default;
		object obj6 = obj7 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj9 = default;
		object obj8 = obj9;
		object obj11 = default;
		object obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj12 = default;
		if (obj10 == obj12)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj14 = default;
			object obj13 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj16 = default;
			object obj15 = obj16;
		}
		else
		{
			object obj15 = obj8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	public string[] GetFileList()
	{
		//IL_0019: Expected Obj, but got I4
		bool flag = binMode;
		return (string[])flag;
	}

	public unsafe string[] GetFileList(string mask)
	{
		//IL_0024: Expected Obj, but got I4
		ref LogCategorySettings value = ref *(LogCategorySettings*)null;
		if (server != null)
		{
			bool flag = ((Dictionary<string, LogCategorySettings>)(object)server).TryGetValue(mask, out value);
			return (string[])flag;
		}
		return null;
	}

	public long GetFileSize(string fileName)
	{
		//IL_01af: Expected Obj, but got I4
		//IL_0288: Expected I8, but got Obj
		//IL_0031: Expected I, but got Obj
		//IL_0047: Expected Obj, but got I
		//IL_01ee: Expected I, but got Obj
		//IL_0204: Expected Obj, but got I
		//IL_0072: Expected I, but got Obj
		//IL_00bf: Expected I, but got Obj
		//IL_010c: Expected I, but got Obj
		//IL_0122: Expected Obj, but got I
		//IL_014d: Expected I, but got Obj
		string text = (string)0;
		if (this == null || ~(verboseDebugging ? 1u : 0u) != 0)
		{
			goto IL_0199;
		}
		nint num = (nint)typeof(CultureInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v17 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CultureInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v48 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v24 (Il2CppClass<System.DateTime>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v44 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = ((System.DefaultBinder)this).ChangeType((object)currentCulture, (Type)null, (CultureInfo)(object)text);
		if (obj3 == null)
		{
			nint num5 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v33 (Il2CppClass<System.DateTime>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v40 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCFC");
			object obj5 = default;
			if (obj5 == null)
			{
				goto IL_0199;
			}
		}
		string text2 = text;
		goto IL_0283;
		IL_0199:
		text2 = fileName;
		goto IL_0283;
		IL_0283:
		return (long)text2;
	}

	public void Download(string remFileName)
	{
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_003d: Expected I4, but got Obj
		//IL_002d: Expected I4, but got Obj
		//IL_008c: Expected Obj, but got I4
		bool flag = binMode;
		object obj = flag ^ remFileName;
		if (obj != null)
		{
			if (remFileName != null)
			{
				((AnalyticsLogCategory)this)._002Ector((int)"TYPE I");
			}
			else
			{
				((AnalyticsLogCategory)this)._002Ector((int)"TYPE A");
			}
			if (resultCode != 200)
			{
				bool flag2 = ((AnalyticsManager._003CWaitForResult_003Ed__44)(object)result).MoveNext();
				((FtpClient)flag2).BinaryMode = false;
			}
		}
	}

	public void Download(string remFileName, bool resume)
	{
	}

	public void Download(string remFileName, string locFileName)
	{
		//IL_0018: Expected I4, but got Obj
		Upload(remFileName, (byte)(int)"" != 0, locFileName);
	}

	public void Download(string remFileName, string locFileName, bool resume)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_00bb: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_014f: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		object obj = this + 12;
		obj = "localhost";
		object obj2 = this + 16;
		obj2 = ".";
		object obj3 = this + 20;
		obj3 = "anonymous";
		object obj4 = this + 24;
		obj4 = "anonymous@anonymous.net";
		port = 21;
		nint num = (nint)typeof(FtpClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v15 (Il2CppClass<SYBO.Components.Logging.Ftp.FtpClient>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(FtpClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v28 (Il2CppClass<SYBO.Components.Logging.Ftp.FtpClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = this + 52;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj7 = default;
		obj6 = obj7;
		timeoutSeconds = 10;
		object obj8 = this + 12;
		obj8 = remFileName;
		object obj9 = this + 20;
		obj9 = locFileName;
		object obj10 = this + 24;
		obj10 = resume;
	}

	public void Upload(string fileName)
	{
		//IL_0015: Expected I4, but got Obj
		Upload(fileName, (byte)(int)"" != 0, null);
	}

	public void Upload(string fileName, string destFilename)
	{
		//IL_000f: Expected I4, but got Obj
		Upload(fileName, (byte)(int)destFilename != 0, null);
	}

	public void Upload(string fileName, bool resume)
	{
		//IL_0013: Expected Obj, but got I4
		UploadDirectory(fileName, recurse: false, (string)resume);
	}

	public void Upload(string fileName, bool resume, string destFilename)
	{
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_066d: Expected Obj, but got Unknown
		//IL_0676: Expected Obj, but got I4
		//IL_001b: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		if (~(loggedin ? 1u : 0u) != 0)
		{
			Close();
		}
		Download((string)1);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public void WriteFile(string remoteFileName, byte[] data)
	{
		UploadDirectory(remoteFileName, recurse: false, null);
	}

	public unsafe void AppendFile(string remoteFileName, byte[] data)
	{
		//IL_001b: Expected Obj, but got I4
		//IL_0038: Expected I4, but got Obj
		//IL_0046: Expected I4, but got Obj
		//IL_0064: Expected I4, but got Obj
		//IL_0064: Expected I4, but got Obj
		//IL_0064: Expected I4, but got Obj
		//IL_0076: Expected I, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_01e8: Expected Obj, but got I4
		//IL_00b7: Expected I, but got Obj
		//IL_0174: Expected Obj, but got I4
		//IL_01a7: Expected I4, but got Obj
		if (~(loggedin ? 1u : 0u) != 0)
		{
			Close();
		}
		Download((string)1);
		string[] callstackPrefixes = ((AnalyticsLogCategory)this).GetCallstackPrefixes();
		string text = string.ConcatArray((string[])(object)"STOR ", (int)remoteFileName);
		((AnalyticsLogCategory)this)._002Ector((int)text);
		int num = "[FtpClient] Uploading file ".IndexOf((char)(int)remoteFileName, (int)" to ", (int)remotePath);
		nint num2 = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v10 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num3 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v26 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogError(num);
		int num4 = ((Socket)(object)callstackPrefixes).Receive(data, data.Length, SocketFlags.None);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (System.String[])+2E]");
		if ((nint)0 != 0)
		{
			((Socket)(object)callstackPrefixes).ThrowIfDisposedAndClosed();
		}
		cleanup();
		if (resultCode != 226 && resultCode != 250)
		{
			string text2 = result.Trim((char[])4);
			TypeCode typeCode = ((int*)text2)->GetTypeCode();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			AggregatedDataTracking.DataContainer dataContainer = default;
			dataContainer._002Ector((AggregatedDataTracking.DataCompleteness)result, (int)typeCode);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public void UploadDirectory(string path, bool recurse)
	{
		//IL_001b: Expected Obj, but got I4
		//IL_0038: Expected I4, but got Obj
		//IL_0046: Expected I4, but got Obj
		//IL_0064: Expected I4, but got Obj
		//IL_0064: Expected I4, but got Obj
		//IL_0064: Expected I4, but got Obj
		//IL_0076: Expected I, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_01d5: Expected Obj, but got I4
		//IL_01f3: Expected Obj, but got I4
		//IL_00b7: Expected I, but got Obj
		//IL_0174: Expected Obj, but got I4
		//IL_0199: Expected I4, but got Obj
		if (~(loggedin ? 1u : 0u) != 0)
		{
			Close();
		}
		Download((string)1);
		string[] callstackPrefixes = ((AnalyticsLogCategory)this).GetCallstackPrefixes();
		string text = string.ConcatArray((string[])(object)"APPE ", (int)path);
		((AnalyticsLogCategory)this)._002Ector((int)text);
		int num = "[FtpClient] Uploading file ".IndexOf((char)(int)path, (int)" to ", (int)remotePath);
		nint num2 = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v10 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num3 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v25 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogError(num);
		bool flag = recurse;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [recurse @ L2 (System.Boolean)+C]");
		int num4 = ((Socket)(object)callstackPrefixes).Receive((byte[])flag, 0, SocketFlags.None);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (System.String[])+2E]");
		if ((nint)0 != 0)
		{
			((Socket)(object)callstackPrefixes).ThrowIfDisposedAndClosed();
		}
		cleanup();
		if (resultCode != 226 && resultCode != 250)
		{
			string text2 = result.Trim((char[])4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			AggregatedDataTracking.DataContainer dataContainer = default;
			dataContainer._002Ector((AggregatedDataTracking.DataCompleteness)text2, -1);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public void UploadDirectory(string path, bool recurse, string mask)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_0875: Expected Obj, but got Unknown
		//IL_093b: Expected I4, but got Obj
		//IL_09a9: Expected I, but got Obj
		//IL_09bf: Expected Obj, but got I
		//IL_0a86: Expected I4, but got Obj
		//IL_0a94: Expected I4, but got Obj
		//IL_0501: Expected I, but got Obj
		//IL_0430: Expected I4, but got Obj
		//IL_0251: Expected I4, but got Obj
		//IL_0263: Expected I, but got Obj
		//IL_0279: Expected Obj, but got I
		//IL_0996: Expected Obj, but got I4
		//IL_0688: Expected I4, but got Obj
		//IL_0688: Expected I4, but got Obj
		//IL_0688: Expected I4, but got Obj
		//IL_069a: Expected I, but got Obj
		//IL_06b0: Expected Obj, but got I
		//IL_0473: Expected I, but got Obj
		//IL_0489: Expected Obj, but got I
		//IL_0340: Expected I, but got Obj
		//IL_0356: Expected Obj, but got I
		//IL_02a4: Expected I, but got Obj
		//IL_0a57: Expected Obj, but got I4
		//IL_0a06: Expected Obj, but got I4
		//IL_06db: Expected I, but got Obj
		//IL_05ef: Expected I, but got Obj
		//IL_0605: Expected Obj, but got I
		//IL_04b4: Expected I, but got Obj
		//IL_0381: Expected I, but got Obj
		//IL_0630: Expected I, but got Obj
		//IL_0833: Expected Obj, but got I4
		//IL_0858: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		obj3 = obj;
		_ = -1;
		if (~(loggedin ? 1u : 0u) != 0)
		{
			Close();
		}
		string path2 = ((mask == null) ? path : mask);
		if (recurse)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj5 = default;
			object obj4 = obj5;
			object obj7 = default;
			object obj6 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj8 = default;
			if (obj6 == obj8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				object obj10 = default;
				object obj9 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				object obj12 = default;
				object obj11 = obj12;
			}
			else
			{
				object obj11 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		FileStream fileStream = default;
		fileStream.InitBuffer((int)path, true);
		object obj14 = default;
		string[] array;
		if (recurse)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7569");
			object obj13 = default;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14))
			{
				string text = string.ConcatArray((string[])(object)"[FtpClient] Overwriting ", (int)path);
				nint num = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S1_v93 (Il2CppClass<UnityEngine.Debug>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num2 = (nint)typeof(Debug);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S1_v99 (Il2CppClass<UnityEngine.Debug>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Debug.LogError(text);
				string[] callstackPrefixes = ((AnalyticsLogCategory)this).GetCallstackPrefixes();
				array = callstackPrefixes;
				obj14 = 0;
				goto IL_099b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7569");
			object obj16 = default;
			if (obj16 == obj14)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
				object obj17 = ((IConvertible)"[FtpClient] Skipping completed ").ToType((Type)(object)path, (IFormatProvider)(object)" - turn resume off to not detect.");
				nint num3 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S1_v82 (Il2CppClass<UnityEngine.Debug>)+BA]");
				object obj18 = (nint)0 & (nint)0x200;
				if (obj18 != null)
				{
					nint num4 = (nint)typeof(Debug);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ S1_v87 (Il2CppClass<UnityEngine.Debug>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Debug.LogError(obj17);
				return;
			}
		}
		string[] callstackPrefixes2 = ((AnalyticsLogCategory)this).GetCallstackPrefixes();
		bool flag = (nint)obj14 >= 1;
		bool flag2 = !flag;
		array = callstackPrefixes2;
		if (!flag2)
		{
			obj2 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text3 = default;
			string text2 = "REST " + text3;
			((AnalyticsLogCategory)this)._002Ector((int)text2);
			bool flag3 = resultCode != 350;
			bool flag4 = !flag3;
			array = callstackPrefixes2;
			if (!flag4)
			{
				nint num5 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ S0_v106 (Il2CppClass<UnityEngine.Debug>)+BA]");
				object obj19 = (nint)0 & (nint)0x200;
				if (obj19 != null)
				{
					nint num6 = (nint)typeof(Debug);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ S0_v113 (Il2CppClass<UnityEngine.Debug>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Debug.LogError("[FtpClient] Resuming not supported");
				array = callstackPrefixes2;
				obj14 = 0;
			}
		}
		goto IL_099b;
		IL_099b:
		nint num7 = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v31 (Il2CppClass<System.IO.Path>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num8 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S0_v88 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string fullPath = Path.GetFullPath(path2);
		string text4 = string.ConcatArray((string[])(object)"STOR ", (int)fullPath);
		((AnalyticsLogCategory)this)._002Ector((int)text4);
		if (resultCode != 125 && resultCode != 150)
		{
			bool flag5 = ((AnalyticsManager._003CWaitForResult_003Ed__44)(object)result).MoveNext();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		if (obj14 != null)
		{
			obj2 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text6 = default;
			string text5 = "[FtpClient] Resuming at offset " + text6;
			nint num9 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ S1_v51 (Il2CppClass<UnityEngine.Debug>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num10 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ S1_v57 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Debug.LogError(text5);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @770A");
		}
		int num11 = "[FtpClient] Uploading file ".IndexOf((char)(int)path, (int)" to ", (int)remotePath);
		nint num12 = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ S1_v23 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj22 = (nint)0 & (nint)0x200;
		if (obj22 != null)
		{
			nint num13 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ S1_v43 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogError(num11);
		int num14 = default;
		while (true)
		{
			byte[] array2 = buffer;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
			bytes = num14;
			if (num14 < 1)
			{
				break;
			}
			int num15 = ((Socket)(object)array).Receive(buffer, bytes, SocketFlags.None);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ L2_v2 (System.String[])+2E]");
		if ((nint)0 != 0)
		{
			((Socket)(object)array).ThrowIfDisposedAndClosed();
		}
		cleanup();
		if (resultCode != 226 && resultCode != 250)
		{
			string text7 = result.Trim((char[])4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			AggregatedDataTracking.DataContainer dataContainer = default;
			dataContainer._002Ector((AggregatedDataTracking.DataCompleteness)text7, -1);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public void DeleteFile(string fileName)
	{
		UploadDirectory(fileName, recurse: false, null);
	}

	public void RenameFile(string oldFileName, string newFileName, bool overwrite)
	{
		//IL_01bb: Expected I4, but got Obj
		//IL_01bb: Expected I4, but got Obj
		//IL_01d7: Expected Obj, but got I4
		//IL_01e0: Expected Obj, but got I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0097: Expected Obj, but got I4
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_00b7: Expected Obj, but got I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_014c: Expected Obj, but got I4
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_018d: Expected Obj, but got I4
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected Obj, but got Unknown
		string text = oldFileName.Remove((int)"/", (int)"\\");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num = default;
		object obj = num + 16;
		obj = 92;
		string text2 = text.Substring(num);
		int num2 = (int)((uint)text2.m_firstChar << 2);
		object obj2 = text2 + num2;
		object obj3 = obj2 + 12;
		string mD5Hash = ((PersistentAnalyticsEventLog)this).GetMD5Hash((byte[])obj3);
		if (mD5Hash.m_firstChar <= '\0')
		{
			RemoveDir((string)obj3);
		}
		sendCommand((string)obj3);
		string[] directories = Directory.GetDirectories(oldFileName, (string)overwrite);
		object obj4 = directories + 12;
		object obj5 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
		{
			object obj6 = directories + 16;
			object obj7 = obj5 << 2;
			object remoteFileName = obj6 + obj7;
			WriteFile((string)remoteFileName, null);
			object obj8 = obj5 + 1;
			obj5 = obj8;
		}
		if (newFileName != null)
		{
			DirectoryInfo directoryInfo = Directory.CreateDirectory(oldFileName);
			object obj9 = directoryInfo + 12;
			object obj10 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9))
			{
				object obj11 = directoryInfo + 16;
				object obj12 = obj10 << 2;
				object oldFileName2 = obj11 + obj12;
				RenameFile((string)oldFileName2, (string)1, overwrite);
				object obj13 = obj10 + 1;
				obj10 = obj13;
			}
		}
		sendCommand("..");
	}

	public void MakeDir(string dirName)
	{
		//IL_001e: Expected I4, but got Obj
		//IL_002c: Expected I4, but got Obj
		//IL_00b0: Expected I4, but got Obj
		//IL_00c2: Expected I, but got Obj
		//IL_00d8: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I4
		//IL_0103: Expected I, but got Obj
		//IL_0093: Expected I4, but got Obj
		if (~(loggedin ? 1u : 0u) != 0)
		{
			Close();
		}
		string text = string.ConcatArray((string[])(object)"DELE ", (int)dirName);
		((AnalyticsLogCategory)this)._002Ector((int)text);
		if (resultCode != 250)
		{
			string text2 = result.Trim((char[])4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			AggregatedDataTracking.DataContainer dataContainer = default;
			dataContainer._002Ector((AggregatedDataTracking.DataCompleteness)text2, -1);
			((FtpClient)(object)dataContainer).DeleteFile((string)null);
		}
		string text3 = string.ConcatArray((string[])(object)"[FtpClient] Deleted file ", (int)dirName);
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v10 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v15 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogError(text3);
	}

	public void RemoveDir(string dirName)
	{
		//IL_001e: Expected I4, but got Obj
		//IL_002c: Expected I4, but got Obj
		//IL_014e: Expected I4, but got Obj
		//IL_0160: Expected I, but got Obj
		//IL_0176: Expected Obj, but got I
		//IL_00dd: Expected I, but got Obj
		//IL_009b: Expected Obj, but got I4
		//IL_00c0: Expected I4, but got Obj
		if (~(loggedin ? 1u : 0u) != 0)
		{
			Close();
		}
		string text = string.ConcatArray((string[])(object)"MKD ", (int)dirName);
		((AnalyticsLogCategory)this)._002Ector((int)text);
		if (resultCode != 250 && resultCode != 257)
		{
			string text2 = result.Trim((char[])4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			AggregatedDataTracking.DataContainer dataContainer = default;
			dataContainer._002Ector((AggregatedDataTracking.DataCompleteness)text2, -1);
			((FtpClient)(object)dataContainer).MakeDir((string)null);
		}
		string text3 = string.ConcatArray((string[])(object)"[FtpClient] Created directory ", (int)dirName);
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v10 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v15 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogError(text3);
	}

	public void ChangeDir(string dirName)
	{
		//IL_001e: Expected I4, but got Obj
		//IL_002c: Expected I4, but got Obj
		//IL_00b0: Expected I4, but got Obj
		//IL_00c2: Expected I, but got Obj
		//IL_00d8: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I4
		//IL_0103: Expected I, but got Obj
		//IL_0093: Expected I4, but got Obj
		if (~(loggedin ? 1u : 0u) != 0)
		{
			Close();
		}
		string text = string.ConcatArray((string[])(object)"RMD ", (int)dirName);
		((AnalyticsLogCategory)this)._002Ector((int)text);
		if (resultCode != 250)
		{
			string text2 = result.Trim((char[])4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			AggregatedDataTracking.DataContainer dataContainer = default;
			dataContainer._002Ector((AggregatedDataTracking.DataCompleteness)text2, -1);
			((FtpClient)(object)dataContainer).RemoveDir((string)null);
		}
		string text3 = string.ConcatArray((string[])(object)"[FtpClient] Removed directory ", (int)dirName);
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v10 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v15 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogError(text3);
	}

	private void readResponse()
	{
		//IL_0079: Expected I4, but got Obj
		//IL_008b: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_005d: Expected I4, but got Obj
		string text = string.ConcatArray((string[])(object)"[FtpClient] Closing connection to ", (int)server);
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v5 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v14 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogError(text);
		if (clientSocket != null)
		{
			((AnalyticsLogCategory)this)._002Ector((int)"QUIT");
		}
		Finalize();
	}

	private string readLine()
	{
		return ((PersistentAnalyticsEventLog)this).GetMD5Hash((byte[])(object)"*.*");
	}

	private void sendCommand(string command)
	{
		//IL_009a: Expected I4, but got Obj
		//IL_00a8: Expected I4, but got Obj
		//IL_0103: Expected I4, but got Obj
		//IL_0166: Expected Obj, but got I4
		//IL_016f: Expected Obj, but got I4
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_00f3: Expected Obj, but got I4
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_01b8: Expected I4, but got Obj
		//IL_01ca: Expected I, but got Obj
		//IL_01e0: Expected Obj, but got I
		//IL_0149: Expected Obj, but got I4
		//IL_020b: Expected I, but got Obj
		if (command == null || string.Equals(command, ".") || command.m_stringLength == 0)
		{
			return;
		}
		if (~(loggedin ? 1u : 0u) != 0)
		{
			Close();
		}
		string text = string.ConcatArray((string[])(object)"CWD ", (int)command);
		((AnalyticsLogCategory)this)._002Ector((int)text);
		if (resultCode != 250)
		{
			bool flag = ((AnalyticsManager._003CWaitForResult_003Ed__44)(object)result).MoveNext();
			((FtpClient)flag).ChangeDir(null);
		}
		((AnalyticsLogCategory)this)._002Ector((int)"PWD");
		if (resultCode != 257)
		{
			bool flag2 = ((AnalyticsManager._003CWaitForResult_003Ed__44)(object)result).MoveNext();
			((FtpClient)flag2).ChangeDir(null);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num = default;
		object obj = num + 16;
		obj = 34;
		object obj2 = this + 16;
		string text2 = message.Substring(num);
		object obj3 = text2 + 20;
		obj2 = obj3;
		string text3 = string.ConcatArray((string[])(object)"[FtpClient] Current directory is ", (int)remotePath);
		nint num2 = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v26 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num3 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v31 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogError(text3);
	}

	private unsafe Socket createDataSocket()
	{
		//IL_0022: Expected I4, but got Obj
		//IL_0022: Expected I, but got Obj
		//IL_003e: Expected I, but got Obj
		//IL_0054: Expected Obj, but got I
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected Obj, but got Unknown
		//IL_007f: Expected I, but got Obj
		//IL_00d6: Expected Obj, but got I4
		//IL_00df: Expected Obj, but got I4
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_0213: Expected Obj, but got I4
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected Obj, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		int totalLength = default;
		int num3 = default;
		string text2;
		while (true)
		{
			byte[] array = buffer;
			bool flag = Socket.Poll_internal((IntPtr)clientSocket, (SelectMode)buffer, array.Length, out *(int*)null);
			bytes = (flag ? 1 : 0);
			nint num = (nint)typeof(FtpClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v15 (Il2CppClass<SYBO.Components.Logging.Ftp.FtpClient>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FtpClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v75 (Il2CppClass<SYBO.Components.Logging.Ftp.FtpClient>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = this + 28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
			string text = string.ConcatArray((string[])(object)message, totalLength);
			obj2 = text;
			byte[] array2 = buffer;
			if (bytes < array2.Length)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				object obj3 = num3 + 16;
				obj3 = 10;
				text2 = message.Substring(num3);
				string text3 = message;
				if (text3.m_stringLength < 3)
				{
					object obj4 = this + 28;
					object obj5 = text2 + 16;
					obj4 = obj5;
				}
				else
				{
					object obj6 = this + 28;
					int num4 = (int)((uint)text2.m_firstChar << 2);
					object obj7 = text2 + num4;
					object obj8 = obj7 + 8;
					obj6 = obj8;
				}
				string text4 = message;
				if (text4.m_stringLength < 5)
				{
					break;
				}
				string a = message.InternalSubString(3, 1);
				if (string.Equals(a, " "))
				{
					break;
				}
				bool dontFragment = (byte)(timeoutSeconds * 1000) != 0;
				clientSocket.DontFragment = dontFragment;
			}
		}
		if (~(verboseDebugging ? 1u : 0u) == 0)
		{
			object obj9 = text2 + 12;
			object obj10 = 0;
			object obj11 = obj9 - 1;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				object obj12 = text2 + 16;
				object obj13 = obj10 << 2;
				object obj14 = obj12 + obj13;
				throw new ArrayTypeMismatchException();
			}
		}
		return (Socket)(object)message;
	}

	private unsafe void cleanup()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_0053: Expected Obj, but got I4
		object obj = this + 28;
		obj = "";
		object obj2 = this + 32;
		Socket socket = createDataSocket();
		obj2 = socket;
		string text = result;
		if (text.m_stringLength > 3)
		{
			string text2 = result.InternalSubString(0, 3);
			TypeCode typeCode = ((int*)text2)->GetTypeCode();
			resultCode = (int)typeCode;
		}
		else
		{
			object obj3 = this + 32;
			obj3 = 0;
		}
	}

	~FtpClient()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I4
		if (clientSocket != null)
		{
			clientSocket.ThrowIfDisposedAndClosed();
			object obj = this + 56;
			obj = 0;
		}
		loggedin = false;
	}

	static FtpClient()
	{
		//IL_0056: Expected I, but got Obj
		//IL_006c: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_003d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+5C]");
		object obj = (nint)0 + (nint)4;
		object obj2 = default;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A7");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A7");
		object obj5 = default;
		object obj4 = obj5 + 4;
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A7");
		object obj7 = default;
		object obj6 = obj7 + 8;
		obj6 = 0;
	}
}

using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Logging.Ftp;

public class FtpClient
{
	public class FtpException : Exception
	{
		public int ResultCode;

		public FtpException(string message, int resultCode = -1)
			: base(message)
		{
			ResultCode = resultCode;
		}

		public FtpException(string message, Exception innerException, int resultCode = -1)
			: base(message, innerException)
		{
			ResultCode = resultCode;
		}

		public unsafe static FtpException FromResult(string result)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Ref, but got Unknown
			string message = result.Substring(4);
			FtpException ex = default;
			ex._002Ector(message);
			string s = result.Substring(0, 3);
			bool flag = int.TryParse(s, out *(int*)(ex + 72));
			return ex;
		}
	}

	private static int BUFFER_SIZE = 512;

	private static Encoding ASCII;

	private bool verboseDebugging;

	private string server = "localhost";

	private string remotePath = ".";

	private string username = "anonymous";

	private string password = "anonymous@anonymous.net";

	private string message;

	private string result;

	private int port = 21;

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
			return verboseDebugging;
		}
		set
		{
			verboseDebugging = value;
		}
	}

	public int Port
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

	public int Timeout
	{
		get
		{
			return timeoutSeconds;
		}
		set
		{
			timeoutSeconds = value;
		}
	}

	public string Server
	{
		get
		{
			return server;
		}
		set
		{
			server = value;
		}
	}

	public int RemotePort
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

	public string RemotePath
	{
		get
		{
			return remotePath;
		}
		set
		{
			remotePath = value;
		}
	}

	public string Username
	{
		get
		{
			return username;
		}
		set
		{
			username = value;
		}
	}

	public string Password
	{
		get
		{
			return password;
		}
		set
		{
			password = value;
		}
	}

	public bool BinaryMode
	{
		get
		{
			return binMode;
		}
		set
		{
			if (binMode != value)
			{
				object command = "TYPE I";
				if (!value)
				{
					command = "TYPE A";
				}
				sendCommand((string)command);
				if (resultCode != 200)
				{
					FtpException ex = FtpException.FromResult(result);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
				}
			}
		}
	}

	public FtpClient()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		byte[] array = default;
		buffer = array;
		timeoutSeconds = 10;
	}

	public FtpClient(string server, string username, string password)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		byte[] array = default;
		buffer = array;
		timeoutSeconds = 10;
		this.server = server;
		this.username = username;
		this.password = password;
	}

	public FtpClient(string server, string username, string password, int timeoutSeconds, int port)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		byte[] array = default;
		buffer = array;
		this.timeoutSeconds = 10;
		this.server = server;
		this.username = username;
		this.password = password;
		this.port = port;
		this.timeoutSeconds = timeoutSeconds;
	}

	public void Login()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Expected Obj, but got Unknown
		//IL_04a0: Expected Obj, but got I
		//IL_0600: Expected Obj, but got I
		//IL_0712: Expected Obj, but got I
		//IL_0300: Expected Obj, but got I
		//IL_032b: Expected Obj, but got I
		//IL_0350: Expected Obj, but got I
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected Obj, but got Unknown
		//IL_041e: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		if (~(loggedin ? 1u : 0u) == 0)
		{
			Close();
		}
		string text = "[FtpClient] Opening connection to " + server;
		Debug.Log(text);
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Socket socket = default;
				clientSocket = socket;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 == 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								goto IL_01f0;
							}
							goto IL_0698;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_01f0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_01f0;
		IL_0720:
		Close();
		goto IL_0616;
		IL_01f0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj4 = default;
		object obj5 = default;
		bool flag = obj4 == obj5;
		bool flag2 = !flag;
		object obj7 = default;
		object obj6 = obj7;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			FtpClient ftpClient;
			if ((nint)0 != 1)
			{
				object obj9 = default;
				object obj8 = obj9;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj10 = default;
					bool flag3 = obj10 == null;
					object obj11 = obj9;
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj12 = (nint)0 << 2;
						object obj13 = obj3 + obj12;
						obj13 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj14 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj15 = (nint)0 << 2;
						object obj16 = obj15 + obj3;
						object obj17 = obj16 - 4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Debug.LogException((Exception)obj17);
						Socket socket2 = clientSocket;
						if (clientSocket != null && ~(socket2.is_connected ? 1u : 0u) == 0)
						{
							clientSocket.Close();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						FtpException ex = default;
						ex._002Ector("Couldn't connect to remote server", (Exception)obj17);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj18 = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
						obj11 = obj18;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj19 = obj11;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag4 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					ftpClient = (FtpClient)0;
					if (flag4)
					{
						goto IL_0720;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag5 = (nint)0 == 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			ftpClient = (FtpClient)0;
			object obj20 = default;
			obj6 = obj20;
			if (flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				ftpClient = (FtpClient)0;
				goto IL_0720;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_0698;
		IL_0616:
		string text2 = result.Substring(4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		FtpException ex2 = default;
		ex2._002Ector(text2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return;
		IL_058e:
		loggedin = true;
		string text3 = "[FtpClient] Connected to " + server;
		Debug.Log(text3);
		ChangeDir(remotePath);
		return;
		IL_0698:
		readResponse();
		if (resultCode == 220)
		{
			string command = "USER " + username;
			sendCommand(command);
			if (resultCode == 230)
			{
				goto IL_058e;
			}
			if (resultCode == 331)
			{
				string command2 = "PASS " + password;
				sendCommand(command2);
				if (resultCode == 202 || resultCode == 230)
				{
					goto IL_058e;
				}
			}
			cleanup();
			goto IL_0616;
		}
		goto IL_0720;
	}

	public void Close()
	{
		string text = "[FtpClient] Closing connection to " + server;
		Debug.Log(text);
		if (clientSocket != null)
		{
			sendCommand("QUIT");
		}
		cleanup();
	}

	public string[] GetFileList()
	{
		return GetFileList("*.*");
	}

	public unsafe string[] GetFileList(string mask)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected VT, but got Unknown
		//IL_00c8: Expected F8, but got I4
		//IL_00c8: Expected Ref, but got VT
		//IL_0128: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (~(loggedin ? 1u : 0u) != 0)
		{
			Login();
		}
		Socket socket = createDataSocket();
		string command = "NLST " + mask;
		sendCommand(command);
		bool flag = resultCode != 125;
		if (resultCode == 150)
		{
			flag = false;
		}
		if (!flag)
		{
			message = string.Empty;
			DateTime now = DateTime.Now;
			DateTime dateTime = (DateTime)(obj + 8);
			DateTime dateTime2 = ((DateTime*)dateTime)->AddSeconds(timeoutSeconds);
			int num;
			string text2 = default;
			byte[] array2;
			do
			{
				DateTime now2 = DateTime.Now;
				if (!(dateTime2 > now2))
				{
					break;
				}
				byte[] array = buffer;
				num = socket.Receive(buffer, array.Length, SocketFlags.None);
				Encoding aSCII = ASCII;
				nint num2 = (nint)aSCII;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v193 @ S6_v4 (Il2CppClass<System.Text.Encoding>)+1F4] (should have been resolved before IL gen)");
				string text = message + text2;
				message = text;
				array2 = buffer;
			}
			while (num >= array2.Length);
			string text3 = message.Replace("\r", string.Empty);
			string[] array3 = text3.Split('\n');
			socket.Close();
			int num3 = message.IndexOf("No such file or directory");
			bool flag2 = num3 != -1;
			bool flag3 = !flag2;
			string[] array4 = array3;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				string[] array5 = default;
				array4 = array5;
			}
			readResponse();
			if (resultCode != 226)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				string[] array6 = default;
				array4 = array6;
			}
			return array4;
		}
		string text4 = result.Substring(4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		FtpException ex = default;
		ex._002Ector(text4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (string[])(object)ex;
	}

	public long GetFileSize(string fileName)
	{
		//IL_00c1: Expected I8, but got Obj
		if (~(loggedin ? 1u : 0u) != 0)
		{
			Login();
		}
		string command = "SIZE " + fileName;
		sendCommand(command);
		string s = result.Substring(4);
		if (resultCode == 213)
		{
			return long.Parse(s);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		FtpException ex = default;
		ex._002Ector(s);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (long)ex;
	}

	public void Download(string remFileName)
	{
		Download(remFileName, string.Empty, resume: false);
	}

	public void Download(string remFileName, bool resume)
	{
		Download(remFileName, string.Empty, resume);
	}

	public void Download(string remFileName, string locFileName)
	{
		Download(remFileName, locFileName, resume: false);
	}

	public unsafe void Download(string remFileName, string locFileName, bool resume)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0306: Expected I8, but got I4
		//IL_0301: Expected native int or pointer, but got VT
		//IL_00cd: Expected I, but got Obj
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected I8, but got Unknown
		//IL_01ad: Expected I8, but got VT
		//IL_01a8: Expected native int or pointer, but got VT
		//IL_01bc: Expected F8, but got I4
		//IL_01bc: Expected Ref, but got VT
		//IL_0175: Expected I, but got Obj
		//IL_024c: Expected I, but got Obj
		//IL_0218: Expected I, but got Obj
		object obj = default;
		DateTime dateTime = (DateTime)(obj - 16);
		((DateTime*)(nint)dateTime)->_dateData = 0uL;
		if (~(loggedin ? 1u : 0u) != 0)
		{
			Login();
		}
		BinaryMode = true;
		bool flag = locFileName.Equals(string.Empty);
		string path = remFileName;
		if (!flag)
		{
			path = locFileName;
		}
		FileStream fileStream2;
		if (!File.Exists(path))
		{
			FileStream fileStream = File.Create(path);
			fileStream2 = fileStream;
		}
		else
		{
			FileStream fileStream3 = default;
			fileStream3._002Ector(path, FileMode.Open);
			fileStream2 = fileStream3;
		}
		Socket socket = createDataSocket();
		_ = 0;
		if (resume)
		{
			nint num = (nint)fileStream2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v79 @ S2_v26 (Il2CppClass<System.IO.FileStream>)+114] (should have been resolved before IL gen)");
			object obj2 = default;
			if ((nint)obj2 >= 1)
			{
				long num2 = (long)(dateTime + 8);
				string text = ((long*)num2)->ToString();
				string command = "REST " + text;
				sendCommand(command);
				if (resultCode != 350)
				{
					_ = 0;
				}
				else
				{
					nint num3 = (nint)fileStream2;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v176 @ S3_v22 (Il2CppClass<System.IO.FileStream>)+1A4] (should have been resolved before IL gen)");
				}
			}
		}
		string command2 = "RETR " + remFileName;
		sendCommand(command2);
		bool flag2 = resultCode != 125;
		if (resultCode == 150)
		{
			flag2 = false;
		}
		if (!flag2)
		{
			DateTime now = DateTime.Now;
			((DateTime*)(nint)dateTime)->_dateData = (ulong)(long)now;
			DateTime dateTime2 = ((DateTime*)dateTime)->AddSeconds(timeoutSeconds);
			do
			{
				DateTime now2 = DateTime.Now;
				if (!(dateTime2 > now2))
				{
					break;
				}
				byte[] array = buffer;
				int num4 = socket.Receive(buffer, array.Length, SocketFlags.None);
				bytes = num4;
				nint num5 = (nint)fileStream2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v266 @ S4_v8 (Il2CppClass<System.IO.FileStream>)+1CC] (should have been resolved before IL gen)");
			}
			while (bytes >= 1);
			nint num6 = (nint)fileStream2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v254 @ S1_v31 (Il2CppClass<System.IO.FileStream>)+14C] (should have been resolved before IL gen)");
			if (~(socket.is_connected ? 1u : 0u) == 0)
			{
				socket.Close();
			}
			readResponse();
			bool flag3 = resultCode != 226;
			if (resultCode == 250)
			{
				flag3 = false;
			}
			if (!flag3)
			{
				return;
			}
		}
		string text2 = result.Substring(4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		FtpException ex = default;
		ex._002Ector(text2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	public void Upload(string fileName)
	{
		Upload(fileName, resume: false, null);
	}

	public void Upload(string fileName, string destFilename)
	{
		Upload(fileName, resume: false, destFilename);
	}

	public void Upload(string fileName, bool resume)
	{
		Upload(fileName, resume: false, null);
	}

	public unsafe void Upload(string fileName, bool resume, string destFilename)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0406: Expected I, but got Obj
		//IL_045b: Expected I, but got Obj
		//IL_048e: Expected Obj, but got I
		//IL_03f9: Expected Obj, but got I
		//IL_044e: Expected Obj, but got I4
		//IL_04a4: Expected I, but got Obj
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Expected I8, but got Unknown
		//IL_0824: Expected I, but got Obj
		//IL_0632: Expected I, but got Obj
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Expected I8, but got Unknown
		//IL_03a0: Expected Obj, but got I
		//IL_03b8: Expected Obj, but got I
		//IL_05fa: Expected I, but got Obj
		//IL_033c: Expected Obj, but got I
		//IL_0285: Expected Obj, but got I
		//IL_02b0: Expected Obj, but got I
		//IL_02db: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		if (~(loggedin ? 1u : 0u) != 0)
		{
			Login();
		}
		_ = 0;
		if (!resume)
		{
			goto IL_0733;
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @45B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						goto IL_0733;
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
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj3 = default;
		object obj4 = default;
		bool flag = obj3 == obj4;
		bool flag2 = !flag;
		object obj6 = default;
		object obj5 = obj6;
		FtpClient ftpClient;
		FtpClient ftpClient2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj8 = default;
				object obj7 = obj8;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj9 = default;
					if (obj9 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj10 = (nint)0 << 2;
						object obj11 = obj + obj10;
						obj11 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj12 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj13 = -1;
						goto IL_0733;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj14 = obj8;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag3 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					ftpClient = (FtpClient)0;
					if (flag3)
					{
						goto IL_03db;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 == 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			ftpClient2 = (FtpClient)0;
			object obj15 = default;
			obj5 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			ftpClient = (FtpClient)0;
			if (flag4)
			{
				goto IL_0769;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		ftpClient = this;
		goto IL_0769;
		IL_0769:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		goto IL_03db;
		IL_0733:
		FileStream fileStream = default;
		fileStream._002Ector(fileName, FileMode.Open);
		object obj16;
		if (!resume)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			obj16 = 0;
		}
		else
		{
			nint num = (nint)fileStream;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v125 @ S1_v58 (Il2CppClass<System.IO.FileStream>)+114] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			object obj17 = default;
			if ((nint)obj17 < 0)
			{
				_ = 0;
				obj16 = 0;
			}
			else
			{
				nint num2 = (nint)fileStream;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v176 @ S1_v63 (Il2CppClass<System.IO.FileStream>)+114] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				object obj18 = default;
				bool flag5 = obj18 != null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				obj16 = 0;
				if (!flag5)
				{
					nint num3 = (nint)fileStream;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v197 @ S1_v68 (Il2CppClass<System.IO.FileStream>)+14C] (should have been resolved before IL gen)");
					return;
				}
			}
		}
		string path = destFilename;
		if (destFilename == null)
		{
			path = fileName;
		}
		Socket socket = createDataSocket();
		if ((nint)obj16 >= 1)
		{
			long num4 = obj + 8;
			string text = ((long*)num4)->ToString();
			string command = "REST " + text;
			sendCommand(command);
			if (resultCode != 350)
			{
				_ = 0;
			}
		}
		string fileName2 = Path.GetFileName(path);
		string command2 = "STOR " + fileName2;
		sendCommand(command2);
		if (resultCode != 125 && resultCode != 150)
		{
			FtpException ex = FtpException.FromResult(result);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		if ((nint)0 != 0)
		{
			long num5 = obj + 8;
			string text2 = ((long*)num5)->ToString();
			string text3 = "[FtpClient] Resuming at offset " + text2;
			Debug.Log(text3);
			nint num6 = (nint)fileStream;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v537 @ S3_v11 (Il2CppClass<System.IO.FileStream>)+1A4] (should have been resolved before IL gen)");
		}
		int num8 = default;
		while (true)
		{
			byte[] array = buffer;
			nint num7 = (nint)fileStream;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v467 @ S5_v4 (Il2CppClass<System.IO.FileStream>)+1B4] (should have been resolved before IL gen)");
			bytes = num8;
			if (num8 <= 0)
			{
				break;
			}
			int num9 = socket.Send(buffer, num8, SocketFlags.None);
		}
		nint num10 = (nint)fileStream;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v511 @ S1_v27 (Il2CppClass<System.IO.FileStream>)+14C] (should have been resolved before IL gen)");
		if (~(socket.is_connected ? 1u : 0u) == 0)
		{
			socket.Close();
		}
		readResponse();
		if (resultCode != 226 && resultCode != 250)
		{
			string text4 = result.Substring(4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			FtpException ex2 = default;
			ex2._002Ector(text4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		return;
		IL_03db:
		ftpClient2 = ftpClient;
		goto IL_0733;
	}

	public void WriteFile(string remoteFileName, byte[] data)
	{
		if (~(loggedin ? 1u : 0u) != 0)
		{
			Login();
		}
		BinaryMode = true;
		Socket socket = createDataSocket();
		string command = "STOR " + remoteFileName;
		sendCommand(command);
		int num = socket.Send(data, data.Length, SocketFlags.None);
		if (~(socket.is_connected ? 1u : 0u) == 0)
		{
			socket.Close();
		}
		readResponse();
		if (resultCode != 226 && resultCode != 250)
		{
			string s = result.Substring(4);
			int num2 = int.Parse(s);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			FtpException ex = default;
			ex._002Ector(result, num2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public void AppendFile(string remoteFileName, byte[] data)
	{
		if (~(loggedin ? 1u : 0u) != 0)
		{
			Login();
		}
		BinaryMode = true;
		Socket socket = createDataSocket();
		string command = "APPE " + remoteFileName;
		sendCommand(command);
		int num = socket.Send(data, data.Length, SocketFlags.None);
		if (~(socket.is_connected ? 1u : 0u) == 0)
		{
			socket.Close();
		}
		readResponse();
		if (resultCode != 226 && resultCode != 250)
		{
			string text = result.Substring(4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			FtpException ex = default;
			ex._002Ector(text);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public void UploadDirectory(string path, bool recurse)
	{
		UploadDirectory(path, recurse, "*.*");
	}

	public void UploadDirectory(string path, bool recurse, string mask)
	{
		//IL_018f: Expected Obj, but got I4
		//IL_01bc: Expected Obj, but got I
		//IL_005b: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I4
		//IL_0044: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00fb: Expected Obj, but got I4
		//IL_0136: Expected Obj, but got I
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		string text = path.Replace("/", "\\");
		string[] array = text.Split('\\');
		object obj = array.Length - 1;
		object obj2 = obj << 2;
		object obj3 = (object)array + obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v6+10]");
		string[] fileList = GetFileList((string)0);
		if (fileList.Length <= 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v6+10]");
			MakeDir((string)0);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v6+10]");
		ChangeDir((string)0);
		string[] files = Directory.GetFiles(path, mask);
		object obj4 = 0;
		while (files.Length > (nint)obj4)
		{
			object obj5 = obj4 << 2;
			object obj6 = (object)files + obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v26+10]");
			Upload((string)0, resume: false);
			object obj7 = obj4 + 1;
			obj4 = obj7;
		}
		if (recurse)
		{
			string[] directories = Directory.GetDirectories(path);
			obj4 = 0;
			while ((nint)obj4 < directories.Length)
			{
				object obj8 = obj4 << 2;
				object obj9 = (object)directories + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v22+10]");
				UploadDirectory((string)0, recurse: true, mask);
				object obj10 = obj4 + 1;
				obj4 = obj10;
			}
		}
		ChangeDir("..");
	}

	public void DeleteFile(string fileName)
	{
		if (~(loggedin ? 1u : 0u) != 0)
		{
			Login();
		}
		string command = "DELE " + fileName;
		sendCommand(command);
		if (resultCode != 250)
		{
			string text = result.Substring(4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			FtpException ex = default;
			ex._002Ector(text);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public void RenameFile(string oldFileName, string newFileName, bool overwrite)
	{
		if (~(loggedin ? 1u : 0u) != 0)
		{
			Login();
		}
		string command = "RNFR " + oldFileName;
		sendCommand(command);
		FtpException ex = default;
		if (resultCode == 350)
		{
			if (!overwrite)
			{
				string[] fileList = GetFileList(newFileName);
				if (fileList.Length != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
					ex._002Ector("File already exists");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
					goto IL_017d;
				}
			}
			string command2 = "RNTO " + newFileName;
			sendCommand(command2);
			if (resultCode == 250)
			{
				return;
			}
		}
		goto IL_017d;
		IL_017d:
		string text = ((FtpClient)(object)ex).result.Substring(4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		FtpException ex2 = default;
		ex2._002Ector(text);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	public void MakeDir(string dirName)
	{
		if (~(loggedin ? 1u : 0u) != 0)
		{
			Login();
		}
		string command = "MKD " + dirName;
		sendCommand(command);
		if (resultCode != 250 && resultCode != 257)
		{
			string text = result.Substring(4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			FtpException ex = default;
			ex._002Ector(text);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public void RemoveDir(string dirName)
	{
		if (~(loggedin ? 1u : 0u) != 0)
		{
			Login();
		}
		string command = "RMD " + dirName;
		sendCommand(command);
		if (resultCode != 250)
		{
			string text = result.Substring(4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			FtpException ex = default;
			ex._002Ector(text);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public void ChangeDir(string dirName)
	{
		if (dirName == null || dirName.Equals(".") || dirName._stringLength == 0)
		{
			return;
		}
		if (~(loggedin ? 1u : 0u) != 0)
		{
			Login();
		}
		string command = "CWD " + dirName;
		sendCommand(command);
		if (resultCode == 250)
		{
			sendCommand("PWD");
			if (resultCode == 257)
			{
				string[] array = message.Split('"');
				remotePath = array[1];
				return;
			}
		}
		FtpException ex = FtpException.FromResult(result);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	private void readResponse()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_0042: Expected Obj, but got I4
		message = string.Empty;
		string text = readLine();
		result = text;
		object obj = this + 32;
		string text2 = result;
		if (text2._stringLength >= 4)
		{
			string s = text2.Substring(0, 3);
			int num = int.Parse(s);
			resultCode = num;
		}
		else
		{
			obj = 0;
		}
	}

	private string readLine()
	{
		//IL_01a5: Expected I, but got Obj
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_00b0: Expected Obj, but got I4
		//IL_0202: Expected Obj, but got I
		//IL_00a2: Expected Obj, but got I4
		//IL_011e: Expected Obj, but got I4
		//IL_0258: Expected Obj, but got I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		string text = default;
		string[] array3;
		string text5 = default;
		while (true)
		{
			message = text;
			byte[] array = buffer;
			bool flag = bytes >= array.Length;
			byte[] array2 = array;
			if (!flag)
			{
				array3 = message.Split('\n');
				string text2 = message;
				object obj = ((text2._stringLength < 3) ? ((object)0) : ((object)(array3.Length - 2)));
				object obj2 = obj << 2;
				object obj3 = (object)array3 + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S1_v17+10]");
				message = (string)0;
				string text3 = message;
				if (text3._stringLength < 5)
				{
					break;
				}
				string text4 = text3.Substring(3, 1);
				if (text4.Equals(" "))
				{
					break;
				}
				int receiveTimeout = timeoutSeconds * 1000;
				clientSocket.ReceiveTimeout = receiveTimeout;
				array2 = buffer;
			}
			int num = clientSocket.Receive(array2, array2.Length, SocketFlags.None);
			bytes = num;
			Encoding aSCII = ASCII;
			nint num2 = (nint)aSCII;
			object obj4 = aSCII + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v93 @ S6_v4 (Il2CppClass<System.Text.Encoding>)+1F4] (should have been resolved before IL gen)");
			text = message + text5;
		}
		if (~(verboseDebugging ? 1u : 0u) == 0)
		{
			object obj5 = 0;
			while (true)
			{
				object obj6 = array3.Length - 1;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
				{
					break;
				}
				object obj7 = obj5 + 1;
				obj5 = obj7;
			}
		}
		return message;
	}

	private void sendCommand(string command)
	{
		//IL_000d: Expected I, but got Obj
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		Encoding aSCII = Encoding.ASCII;
		string text = command + "\r\n";
		char[] array = text.ToCharArray();
		nint num = (nint)aSCII;
		object obj = aSCII + 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S2_v5 (Il2CppClass<System.Text.Encoding>)+13C] (should have been resolved before IL gen)");
		byte[] array2 = default;
		int num2 = clientSocket.Send(array2, array2.Length, SocketFlags.None);
		readResponse();
	}

	private unsafe Socket createDataSocket()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005b: Expected Obj, but got I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected I4, but got Unknown
		//IL_00a1: Expected Obj, but got I4
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected I4, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected I4, but got Unknown
		//IL_01e0: Expected Obj, but got I4
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected Obj, but got Unknown
		//IL_0334: Expected I, but got Obj
		//IL_0446: Expected Obj, but got I
		//IL_0a94: Expected Obj, but got I
		//IL_0abf: Expected Obj, but got I
		//IL_0ae4: Expected Obj, but got I
		//IL_0afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aff: Expected Obj, but got Unknown
		//IL_0b58: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		sendCommand("PASV");
		bool flag = resultCode == 227;
		bool flag2 = !flag;
		string text = result;
		if (flag2)
		{
			goto IL_0bf6;
		}
		int num = result.IndexOf('(');
		int num2 = result.IndexOf(')');
		int startIndex = num + 1;
		object obj3 = num2 - num;
		int length = obj3 - 1;
		string text2 = result.Substring(startIndex, length);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		string text3 = string.Empty;
		object obj4 = 0;
		int num3 = default;
		object obj8 = default;
		int num5 = default;
		while (true)
		{
			string text6;
			if (num3 < text2._stringLength && (nint)obj4 < 7)
			{
				string s = text2.Substring(num3, 1);
				char c = char.Parse(s);
				if (!char.IsDigit(c))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E]");
					if ((nint)0 != 44)
					{
						break;
					}
				}
				else
				{
					char c2 = (char)(obj + 14);
					string text4 = ((char*)(ushort)c2)->ToString();
					string text5 = text3 + text4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E]");
					bool flag3 = (nint)0 == 44;
					text3 = text5;
					if (!flag3)
					{
						object obj5 = num3 + 1;
						bool flag4 = text2._stringLength != (nint)obj5;
						text3 = text5;
						text6 = text5;
						if (flag4)
						{
							goto IL_0c36;
						}
					}
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj6 = obj4 << 2;
					object obj7 = obj8 + obj6;
					object obj9 = obj4 + 1;
					text6 = string.Empty;
					obj4 = obj9;
					goto IL_0c36;
				}
				goto IL_0293;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			int num4 = obj8 + 16;
			string text7 = ((int*)num4)->ToString();
			throw new ArrayTypeMismatchException();
			IL_0c36:
			num3 = num5 + 1;
			text3 = text6;
		}
		string text8 = "Malformed PASV result: " + result;
		string text9 = text8;
		goto IL_0c15;
		IL_0c51:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_0c15;
		IL_0bf6:
		string text10 = text.Substring(4);
		text9 = text10;
		goto IL_0c15;
		IL_0c15:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		FtpException ex = default;
		ex._002Ector(text9);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (Socket)(object)ex;
		IL_0293:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj10 = default;
		object obj11 = default;
		bool flag5 = obj10 != obj11;
		text9 = (string)(object)this;
		Exception ex3 = default;
		Exception ex2 = ex3;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				string text11 = default;
				nint num6 = (nint)text11;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj12 = default;
					if (obj12 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj13 = (nint)0 << 2;
						object obj14 = obj + obj13;
						obj14 = text11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj15 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj16 = (nint)0 << 2;
						object obj17 = obj16 + obj;
						object obj18 = obj17 - 4;
						string text12 = "Malformed PASV result (not supported?): " + result;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						FtpException ex4 = default;
						ex4._002Ector(text12, (Exception)obj18);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						string text13 = (string)(-1);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
						text9 = text13;
						ex2 = (Exception)obj18;
						goto IL_0c51;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj19 = text11;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag6 = (nint)0 != 1;
					text = text11;
					if (flag6)
					{
						goto IL_0bf6;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag7 = (nint)0 == 1;
			Exception ex5 = default;
			text = (string)(object)ex5;
			if (flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				goto IL_0bf6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			text9 = (string)0;
			ex2 = ex5;
		}
		goto IL_0c51;
	}

	private void cleanup()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I4
		if (clientSocket != null)
		{
			clientSocket.Close();
			object obj = this + 56;
			obj = 0;
		}
		loggedin = false;
	}

	~FtpClient()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_01c9: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag = (nint)0 != 1;
		object obj4 = obj;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj5 = default;
			object obj6 = default;
			bool flag2 = obj5 == obj6;
			bool flag3 = !flag2;
			object obj8 = default;
			object obj7 = obj8;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj4 = obj;
				if (flag4)
				{
					goto IL_01da;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				object obj9 = default;
				obj7 = obj9;
			}
			_ = 0;
			object obj10 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj4 = 0;
		}
		goto IL_01da;
		IL_01da:
		object obj11 = obj4 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36E");
	}

	static FtpClient()
	{
		Encoding aSCII = Encoding.ASCII;
		ASCII = aSCII;
	}
}

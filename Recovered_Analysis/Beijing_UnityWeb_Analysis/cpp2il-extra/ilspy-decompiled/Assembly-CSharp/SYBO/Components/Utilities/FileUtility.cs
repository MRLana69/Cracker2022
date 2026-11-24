using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Cpp2ILInjected;
using SYBO.Components.Logging;
using UnityEngine;

namespace SYBO.Components.Utilities;

public static class FileUtility
{
	private sealed class _003CGetFiles_003Ed__8 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private string _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private string directoryPath;

		public string _003C_003E3__directoryPath;

		private string fileSearchPattern;

		public string _003C_003E3__fileSearchPattern;

		private Queue<string> _003Cqueue_003E5__2;

		private string[] _003Cfiles_003E5__3;

		private int _003Ci_003E5__4;

		string IEnumerator<string>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_0055: Unknown result type (might be due to invalid IL or missing references)
				//IL_005a: Expected Obj, but got Unknown
				//IL_0070: Expected Obj, but got I
				//IL_0080: Expected Obj, but got I
				//IL_0091: Unknown result type (might be due to invalid IL or missing references)
				//IL_0096: Expected Obj, but got Unknown
				//IL_009f: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a4: Expected Obj, but got Unknown
				//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c1: Expected Obj, but got Unknown
				//IL_00ef: Expected Obj, but got I4
				//IL_012b: Expected Obj, but got I4
				//IL_0139: Expected Obj, but got I4
				//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_06ad: Expected Obj, but got Unknown
				//IL_06b6: Expected Obj, but got I4
				//IL_06bf: Expected Obj, but got I4
				//IL_0253: Unknown result type (might be due to invalid IL or missing references)
				//IL_0258: Expected Obj, but got Unknown
				//IL_0179: Unknown result type (might be due to invalid IL or missing references)
				//IL_017e: Expected Obj, but got Unknown
				//IL_0189: Unknown result type (might be due to invalid IL or missing references)
				//IL_018e: Expected Obj, but got Unknown
				//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ab: Expected Obj, but got Unknown
				//IL_01c7: Expected Obj, but got I4
				//IL_01d1: Expected Obj, but got I4
				//IL_0248: Expected Obj, but got I4
				//IL_035c: Expected I, but got Obj
				//IL_0372: Expected Obj, but got I
				//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e7: Expected Obj, but got Unknown
				//IL_03f0: Expected Obj, but got I4
				//IL_0400: Expected Obj, but got I4
				//IL_039d: Expected I, but got Obj
				//IL_0536: Unknown result type (might be due to invalid IL or missing references)
				//IL_053b: Expected Obj, but got Unknown
				//IL_054f: Expected I, but got Obj
				//IL_0568: Expected Obj, but got I4
				object obj2 = default;
				object obj = obj2 + 16;
				obj2 = obj;
				_ = -1;
				object obj3;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						int num = _003Ci_003E5__4 + 1;
						_003Ci_003E5__4 = num;
						nint num2 = 1;
						obj3 = 38;
					}
					else
					{
						obj3 = 41;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj5 = default;
					object obj4 = obj5 + 8;
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v88 (Il2CppMethodInfo)+C]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v89+60]");
					object obj7 = 0;
					string text = (string)obj7;
					object obj8 = text & 0xFFF;
					object obj9 = obj8 + 1797;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v59 @ S2_v37 (should have been resolved before IL gen)");
					object obj10 = default;
					obj4 = obj10;
					object obj11 = this + 36;
					obj11 = obj5;
					_003Cqueue_003E5__2.Enqueue(directoryPath);
					nint num2 = 0;
					obj3 = 40;
				}
				object obj12 = obj3;
				string result = default;
				object obj17 = default;
				object obj18 = default;
				object obj20 = default;
				object obj21 = default;
				object obj22 = default;
				object obj24 = default;
				object obj28 = default;
				while (true)
				{
					if ((nint)obj12 == 38)
					{
						string[] array = _003Cfiles_003E5__3;
						if (_003Ci_003E5__4 < array.Length)
						{
							object obj13 = this + 12;
							object obj14 = _003Cfiles_003E5__3 + 16;
							nint num2 = _003Ci_003E5__4 << 2;
							object obj15 = obj14 + num2;
							obj13 = obj15;
							_003C_003E1__state = 1;
							result = (string)1;
							obj12 = 41;
							continue;
						}
					}
					else if ((nint)obj12 == 40)
					{
						Queue<string> queue = _003Cqueue_003E5__2;
						if (queue._size < 1)
						{
							result = null;
							obj12 = 41;
							continue;
						}
						object obj16 = this + 20;
						string text2 = _003Cqueue_003E5__2.Dequeue();
						obj16 = text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
						if (obj17 != obj18)
						{
							object obj19 = obj20;
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
						object[] args = (object[])obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						if (obj22 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @98");
							object obj23 = obj21;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
							object obj19 = obj24;
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
						nint num4 = (nint)typeof(Log);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ S0_v75 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
						object obj25 = (nint)0 & (nint)0x200;
						if (obj25 != null)
						{
							nint num5 = (nint)typeof(Log);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ S0_v82 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Log.Utilities.LogErrorFormat("{0}", args);
						object obj26 = this + 40;
						obj26 = 0;
						((Queue<string>)5109).Enqueue(directoryPath);
						object obj27 = this + 40;
						obj27 = obj28;
						nint num2 = (nint)fileSearchPattern;
						if (_003Cfiles_003E5__3 != null)
						{
							_003Ci_003E5__4 = 0;
							obj12 = 38;
							continue;
						}
					}
					else if ((nint)obj12 == 41)
					{
						return result;
					}
					object obj29 = this + 40;
					obj29 = 0;
					obj12 = 40;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CGetFiles_003Ed__8(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			bool hasShutdownStarted = Environment.HasShutdownStarted;
			_003C_003El__initialThreadId = (hasShutdownStarted ? 1 : 0);
		}

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_000a: Expected I4, but got Obj
			return (byte)(int)((IEnumerable)this).GetEnumerator() != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}

		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return (IEnumerator<string>)(object)_003C_003E2__current;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected Obj, but got Unknown
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected Obj, but got Unknown
			_003CGetFiles_003Ed__8 obj;
			if (_003C_003E1__state == -2)
			{
				bool hasShutdownStarted = Environment.HasShutdownStarted;
				if (_003C_003El__initialThreadId == (hasShutdownStarted ? 1 : 0))
				{
					_003C_003E1__state = 0;
					obj = this;
					goto IL_0069;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_003CGetFiles_003Ed__8 obj2 = default;
			obj2._002Ector(0);
			obj = obj2;
			goto IL_0069;
			IL_0069:
			object obj3 = obj + 20;
			obj3 = _003C_003E3__directoryPath;
			object obj4 = obj + 28;
			obj4 = _003C_003E3__fileSearchPattern;
			return obj;
		}
	}

	public const string LocalPathPrefix = "file://";

	public static string ConvertToPathWithBackSlashes(string path)
	{
		//IL_0009: Expected I4, but got Obj
		return Environment.GetFolderPath((Environment.SpecialFolder)path);
	}

	public static string ConvertToPathWithForwardSlashes(string path)
	{
		//IL_004d: Expected I4, but got Obj
		//IL_004d: Expected I4, but got Obj
		if (path == null || path.m_stringLength == 0)
		{
			return "";
		}
		return path.Remove((int)"/", (int)"\\");
	}

	public static bool IsLocalPath(string path)
	{
		//IL_004d: Expected I4, but got Obj
		//IL_004d: Expected I4, but got Obj
		//IL_0059: Expected I4, but got Obj
		//IL_0035: Expected I4, but got Obj
		if (path == null || path.m_stringLength == 0)
		{
			return (byte)(int)"" != 0;
		}
		string text = path.Remove((int)"\\", (int)"/");
		return (byte)(int)text != 0;
	}

	public static string ConvertSlashesToSystemSeperatorChar(string path)
	{
		//IL_0088: Expected Obj, but got I4
		//IL_001d: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		bool flag = IsLocalPath(path);
		string text = ((string)flag).ToLower((CultureInfo)(object)"http://");
		if (text != null)
		{
			return null;
		}
		string text2 = ((string)flag).ToLower((CultureInfo)(object)"https://");
		if (text2 != null)
		{
			return null;
		}
		string text3 = ((string)flag).ToLower((CultureInfo)(object)"ftp://");
		return (string)(text3 ^ 1);
	}

	public static string CombinePaths(string pathA, string pathB, bool fixSlashesToMatchSystem = true)
	{
		//IL_0011: Expected Obj, but got I4
		return (string)(object)((Type)(object)pathA).GetProperty(pathB, (Type)fixSlashesToMatchSystem);
	}

	public static string ConvertAbsolutePathToAssetFolderRelativePath(string absolutePath, bool fixSlashesToMatchSystem = true)
	{
		//IL_0065: Expected I, but got Obj
		//IL_007b: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I4
		//IL_00ab: Expected Obj, but got I4
		//IL_00ab: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.IO.Path>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string path = ((string)fixSlashesToMatchSystem).Replace((string)Path.AltDirectorySeparatorChar, (string)Path.DirectorySeparatorChar);
		int defaultBufferSize = StreamReader.DefaultBufferSize;
		return (string)Path.SameRoot((string)defaultBufferSize, path);
	}

	public static string ConvertAssetFolderRelativePathToAbsolutePath(string assetFolderRelativePath, bool fixSlashesToMatchSystem = true)
	{
		//IL_0175: Expected Obj, but got I4
		//IL_0048: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_01cf: Expected Obj, but got I4
		//IL_00d5: Expected Obj, but got I4
		//IL_0089: Expected I, but got Obj
		//IL_011e: Expected I4, but got Obj
		//IL_0167: Expected Obj, but got I4
		object obj = 0;
		string result;
		if (assetFolderRelativePath == null || assetFolderRelativePath.m_stringLength == 0)
		{
			result = "";
		}
		else
		{
			nint num = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Il2CppClass<System.IO.Path>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v35 (Il2CppClass<System.IO.Path>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num3 = Path.findExtension(assetFolderRelativePath);
			int defaultBufferSize = StreamReader.DefaultBufferSize;
			obj = Path.DirectorySeparatorChar;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E2B3");
			int totalLength = default;
			string otherUri = string.ConcatArray((string[])defaultBufferSize, totalLength);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Uri uri = default;
			uri.CreateThisFromUri((Uri)(object)otherUri);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Uri uri2 = default;
			uri2.CreateThisFromUri((Uri)(object)assetFolderRelativePath);
			string escapedParts = uri.GetEscapedParts((UriComponents)uri2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			bool flag = !fixSlashesToMatchSystem;
			NetworkReachabilityMonitor networkReachabilityMonitor = default;
			result = (string)(object)networkReachabilityMonitor;
			if (!flag)
			{
				bool isNetworkReachable = networkReachabilityMonitor.IsNetworkReachable;
				result = (string)isNetworkReachable;
			}
		}
		return result;
	}

	public static IEnumerable<string> GetFiles(string directoryPath, string fileSearchPattern)
	{
		//IL_0048: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_0089: Expected I, but got Obj
		//IL_013c: Expected Obj, but got I4
		//IL_00f9: Expected I4, but got Obj
		//IL_00f9: Expected Obj, but got I4
		string text = default;
		if (text == null || text.m_stringLength == 0)
		{
			return (IEnumerable<string>)(object)"";
		}
		nint num = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v10 (Il2CppClass<System.IO.Path>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v25 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (Path.findExtension(text) == 0)
		{
			string text2 = text.ToLower((CultureInfo)(object)"Assets");
			int defaultBufferSize = StreamReader.DefaultBufferSize;
			return (IEnumerable<string>)GameObjectUtil.GetOrAddComponent((Type)defaultBufferSize, (GameObject)(object)text, (byte)(int)fileSearchPattern != 0);
		}
		if (fileSearchPattern != null)
		{
			bool isNetworkReachable = ((NetworkReachabilityMonitor)(object)text).IsNetworkReachable;
			return (IEnumerable<string>)isNetworkReachable;
		}
		return (IEnumerable<string>)(object)text;
	}

	public static void MoveDirectory(string path, string newPath)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a0: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Exception);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Exception>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Exception);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.Exception>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Exception)(object)path).SetErrorCode((int)newPath);
	}
}

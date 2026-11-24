using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Kiloo.Common.Ads;
using Kiloo.Common.Backend.Authentication;
using Kiloo.Common.HTTP.Internal;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Timer;
using Kiloo.Common.Utility;
using Kiloo.Monetization.FlurryPlugin;
using Mono.Globalization.Unicode;
using SYBO.Subway.Level;
using UnityEngine;

namespace Kiloo.Common.Backend.Cloud;

public sealed class SimulatedCloudServer : ICloudServer
{
	private class Metadata
	{
		public string revision;

		public DateTime? lastModified;

		public string sourceDescription;

		public string sourceInstallationId;

		public int dataVersion;

		public Dictionary<string, string> userdata;
	}

	private class Item : ICloudItem
	{
		public delegate byte[] GetBytesFunction(string name);

		private string name__BackingField;

		private string revision__BackingField;

		private string sourceDescription__BackingField;

		private string sourceInstallationId__BackingField;

		private int dataVersion__BackingField;

		private ICloudUserData userData__BackingField;

		private readonly GetBytesFunction _getBytesFunction;

		public string name
		{
			get
			{
				return revision__BackingField;
			}
			private set
			{
				name__BackingField = value;
			}
		}

		public string revision
		{
			get
			{
				return name__BackingField;
			}
			private set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				object obj = this + 8;
				obj = value;
			}
		}

		public DateTime? lastModified
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				DateTime? dateTime = default;
				object obj = (Nullable)dateTime + 12;
				obj = this;
				return dateTime;
			}
			private set
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_0028: Expected Obj, but got I
				object obj = (Nullable)value + 16;
				Item item = (Item)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
				name__BackingField = (string)0;
			}
		}

		public bool isModified
		{
			get
			{
				//IL_0007: Expected I4, but got Obj
				return (byte)(int)revision__BackingField != 0;
			}
		}

		public bool isOutOfDate => false;

		public string sourceDescription
		{
			get
			{
				return null;
			}
			private set
			{
				//IL_0018: Unknown result type (might be due to invalid IL or missing references)
				//IL_001d: Expected Obj, but got Unknown
				_ = value.m_stringLength;
				object obj = this + 16;
				obj = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
			}
		}

		public string sourceInstallationId
		{
			get
			{
				return sourceDescription__BackingField;
			}
			private set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				object obj = this + 32;
				obj = value;
			}
		}

		public int dataVersion
		{
			get
			{
				//IL_0007: Expected I4, but got Obj
				return (int)sourceInstallationId__BackingField;
			}
			private set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				//IL_0013: Expected Obj, but got I4
				object obj = this + 36;
				obj = value;
			}
		}

		public ICloudUserData userData
		{
			get
			{
				//IL_0007: Expected Obj, but got I4
				return (ICloudUserData)dataVersion__BackingField;
			}
			private set
			{
				//IL_000a: Expected I4, but got Obj
				dataVersion__BackingField = (int)value;
			}
		}

		public Stream GetDataStream()
		{
			return (Stream)userData__BackingField;
		}

		public Item(string name, string revision, DateTime? lastModified, string sourceDescription, string sourceInstallationId, int dataVersion, ICloudUserData userData, GetBytesFunction getBytesFunction)
		{
			//IL_010d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Expected Obj, but got Unknown
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Expected Obj, but got Unknown
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Expected Obj, but got Unknown
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Expected Obj, but got Unknown
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			//IL_0166: Expected Obj, but got Unknown
			//IL_0179: Expected I, but got Obj
			//IL_018f: Expected Obj, but got I
			//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f6: Expected Obj, but got Unknown
			//IL_00fc: Expected VT, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_005a: Expected Obj, but got I4
			//IL_0072: Expected I, but got Obj
			//IL_0088: Expected Obj, but got I
			//IL_01b5: Expected Obj, but got I4
			//IL_00b3: Expected I, but got Obj
			object obj = this + 8;
			obj = name;
			string text = (string)(revision & 1);
			this.revision__BackingField = text;
			object obj2 = (Nullable)lastModified & 1;
			object obj3 = sourceDescription & 1;
			object obj4 = sourceInstallationId & 1;
			nint num = (nint)typeof(EnvironmentInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v15 (Il2CppClass<SYBO.Subway.Level.EnvironmentInfo>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(EnvironmentInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v52 (Il2CppClass<SYBO.Subway.Level.EnvironmentInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj7 = default;
			object obj6 = obj7 + 4;
			if (EnvironmentInfo.DefaultMaxMidPieceCount < dataVersion)
			{
				obj6 = dataVersion;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				nint num3 = (nint)typeof(EnvironmentInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v35 (Il2CppClass<SYBO.Subway.Level.EnvironmentInfo>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num4 = (nint)typeof(EnvironmentInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v46 (Il2CppClass<SYBO.Subway.Level.EnvironmentInfo>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj7 = EnvironmentInfo.DefaultMaxMidPieceCount;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				object arg = default;
				object arg2 = default;
				string msg = string.Format((IFormatProvider)(object)"[EnvironmentInfo] Kind {0} : Max mid piece count {1} larger than allowed {2}", name, arg, arg2);
				SDebug.LogFormat(msg, null);
			}
			this.lastModified__BackingField = (DateTime?)(object)dataVersion;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<KeyValuePair<string, Item>, ICloudItem> _003C_003E9__7_0;

		public static Comparison<ICloudItem> _003C_003E9__33_0;

		public static Item.GetBytesFunction _003C_003E9__44_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CloudUserDataExtensions._003C_003Ec obj = default;
			CloudUserDataExtensions._003C_003Ec._003C_003E9 = obj;
		}

		internal ICloudItem _003CGetItems_003Eb__7_0(KeyValuePair<string, Item> item)
		{
			//IL_0012: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ L1 (System.Collections.Generic.KeyValuePair`2<System.String, Kiloo.Common.Backend.Cloud.SimulatedCloudServer+Item>)+4]");
			return (ICloudItem)0;
		}

		internal int _003CInternalUpdateItems_003Eb__33_0(ICloudItem a, ICloudItem b)
		{
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected Obj, but got Unknown
			//IL_0152: Unknown result type (might be due to invalid IL or missing references)
			//IL_0157: Expected Obj, but got Unknown
			//IL_01b9: Expected Obj, but got I
			//IL_01b9: Expected Obj, but got I4
			//IL_01b9: Expected Obj, but got I4
			//IL_01b9: Expected Obj, but got I
			//IL_02d3: Expected I4, but got Obj
			//IL_0200: Expected Obj, but got I
			//IL_0210: Expected Obj, but got I
			//IL_0220: Expected Obj, but got I
			//IL_0229: Unknown result type (might be due to invalid IL or missing references)
			//IL_022e: Expected Obj, but got Unknown
			//IL_0237: Unknown result type (might be due to invalid IL or missing references)
			//IL_023c: Expected Obj, but got Unknown
			//IL_002c: Expected I, but got Obj
			//IL_0042: Expected Obj, but got I
			//IL_0275: Expected Obj, but got I
			//IL_0285: Expected Obj, but got I
			//IL_0296: Unknown result type (might be due to invalid IL or missing references)
			//IL_029b: Expected Obj, but got Unknown
			//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a9: Expected Obj, but got Unknown
			//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c1: Expected Obj, but got Unknown
			//IL_006d: Expected I, but got Obj
			object obj = this + 16;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v4+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Cloud.SimulatedCloudServer+<>c)+20]");
			bool flag = (nint)0 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Cloud.SimulatedCloudServer+<>c)+21]");
			bool flag2 = (nint)0 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			string text = (string)(obj2 + 16);
			text = (string)obj2;
			string text2 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			text2.m_stringLength = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Cloud.SimulatedCloudServer+<>c)+8]");
			nint num = 0;
			string normalizedSearchPath = text;
			bool flag3 = flag;
			bool flag4 = flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Cloud.SimulatedCloudServer+<>c)+24]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Cloud.SimulatedCloudServer+<>c)+28]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Cloud.SimulatedCloudServer+<>c)+2C]");
			System.IO.FileSystemEnumerableIterator<> fileSystemEnumerableIterator = default;
			((System.IO.FileSystemEnumerableIterator<TSource>)(object)fileSystemEnumerableIterator)._002Ector((string)num, normalizedSearchPath, (string)flag3, (string)flag4, (SearchOption)num2, (System.IO.SearchResultHandler<TSource>)num3, false);
			bool flag5 = fileSystemEnumerableIterator.normalizedSearchPath == null;
			if (b != null)
			{
				if (flag5)
				{
					nint num4 = (nint)typeof(StringComparer);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v49 (Il2CppClass<System.StringComparer>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num5 = (nint)typeof(StringComparer);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v60 (Il2CppClass<System.StringComparer>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9E25");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S3_v6 (Il2CppMethodInfo)+C]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S3_v7+60]");
					object obj5 = 0;
					object obj6 = obj5;
					object obj7 = obj6 & 0x1FFF;
					object obj8 = obj7 + 113696;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v98 @ S4_v12 (should have been resolved before IL gen)");
					object obj9 = fileSystemEnumerableIterator + 44;
					object obj10 = default;
					obj9 = obj10;
				}
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S4_v5 (Il2CppMethodInfo)+C]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S4_v6+60]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S4_v7+48]");
				object obj13 = 0;
				object obj14 = obj13 & 0x7FF;
				object obj15 = obj14 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v128 @ S5_v7 (should have been resolved before IL gen)");
			}
			else if (!flag5)
			{
				bool flag6 = ((Dictionary<string, string>)(object)fileSystemEnumerableIterator.normalizedSearchPath).Remove((string)(object)a);
			}
			return (int)fileSystemEnumerableIterator;
		}

		internal byte[] _003CGetStatusList_003Eb__44_0(string name)
		{
			//IL_001a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			return (byte[])0;
		}
	}

	private sealed class _003CListItemsCoroutine_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SimulatedCloudServer _003C_003E4__this;

		public CloudServerRequestCompleteHandler completeHandler;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Expected Obj, but got I4
				//IL_0072: Invalid comparison between I and F4
				//IL_011d: Expected VT, but got Obj
				//IL_00a2: Expected F4, but got I
				//IL_00ae: Expected Obj, but got I4
				//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b9: Expected Obj, but got Unknown
				//IL_00f5: Expected Obj, but got I4
				object obj = 0;
				SimulatedCloudServer simulatedCloudServer = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v6 (Kiloo.Common.Backend.Cloud.SimulatedCloudServer)+8]");
					if (0f > 0f)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v6 (Kiloo.Common.Backend.Cloud.SimulatedCloudServer)+8]");
						int num = Util.ConvertTimeoutToMilliseconds(0f);
						obj = num;
						object obj2 = this + 12;
						object obj3 = obj;
						_ = 1;
						IEnumerator enumerator = ((Wait.Config)obj).WaitCoroutine();
						obj2 = enumerator;
						_003C_003E1__state = 1;
						return 1;
					}
				}
				string result = ToRevision((DateTime?)(object)simulatedCloudServer);
				completeHandler.EndInvoke((IAsyncResult)(object)result);
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CListItemsCoroutine_003Ed__32(int _003C_003E1__state)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 44;
			obj = _003C_003E1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0094: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Cloud.SimulatedCloudServer+<ListItemsCoroutine>d__32)+30]");
			if ((nint)0 != 0)
			{
				int num = _003C_003E1__state;
				bool flag;
				if (_003C_003E1__state != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v11 (System.Int32)+8]");
					flag = (nint)0 == 0;
				}
				else
				{
					flag = true;
				}
				if (flag)
				{
					return false;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8DFD");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				MemoryStream memoryStream = default;
				bool disposing = default;
				memoryStream.Dispose(disposing);
				return (byte)(int)memoryStream != 0;
			}
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CUpdateItemsCoroutine_003Ed__34(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public SimulatedCloudServer _003C_003E4__this;

		public IEnumerable<ICloudItem> items;

		public CloudServerRequestCompleteHandler completeHandler;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Expected Obj, but got I4
				//IL_00a8: Expected Obj, but got I4
				//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b3: Expected Obj, but got Unknown
				//IL_00ef: Expected Obj, but got I4
				object obj = 0;
				SimulatedCloudServer simulatedCloudServer = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					if (simulatedCloudServer.simulatedLatency > 0f)
					{
						int num = Util.ConvertTimeoutToMilliseconds(simulatedCloudServer.simulatedLatency);
						obj = num;
						object obj2 = this + 12;
						object obj3 = obj;
						_ = 1;
						IEnumerator enumerator = ((Wait.Config)obj).WaitCoroutine();
						obj2 = enumerator;
						_003C_003E1__state = 1;
						return 1;
					}
				}
				CloudServerCommitResult result = simulatedCloudServer.InternalCommitItems(items);
				completeHandler.EndInvoke((IAsyncResult)result);
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CCommitItemsCoroutine_003Ed__38(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public SimulatedCloudServer _003C_003E4__this;

		public IEnumerable<ICloudItem> items;

		public CloudServerCommitCompleteHandler completeHandler;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Expected Obj, but got I4
				//IL_00a8: Expected Obj, but got I4
				//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b3: Expected Obj, but got Unknown
				//IL_00ef: Expected Obj, but got I4
				object obj = 0;
				SimulatedCloudServer simulatedCloudServer = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					if (simulatedCloudServer.simulatedLatency > 0f)
					{
						int num = Util.ConvertTimeoutToMilliseconds(simulatedCloudServer.simulatedLatency);
						obj = num;
						object obj2 = this + 12;
						object obj3 = obj;
						_ = 1;
						IEnumerator enumerator = ((Wait.Config)obj).WaitCoroutine();
						obj2 = enumerator;
						_003C_003E1__state = 1;
						return 1;
					}
				}
				string metadataPathFor = simulatedCloudServer.GetMetadataPathFor((string)(object)items);
				completeHandler.EndInvoke((IAsyncResult)(object)metadataPathFor);
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private static SimulatedCloudServer _instance;

	public float simulatedLatency;

	public bool simulateError;

	private const string REPOSITORY_DIR = ".simulatedcloudserver";

	private const string METADATA_DIR = ".metadata";

	private readonly string _localDir;

	private readonly string _metadataDir;

	private Dictionary<string, Item> _items;

	private readonly IJsonSerializer _jsonSerializer;

	private static readonly DateTime _epoch;

	public static SimulatedCloudServer instance
	{
		get
		{
			//IL_0142: Expected Obj, but got I
			//IL_0152: Expected Obj, but got I
			//IL_0163: Unknown result type (might be due to invalid IL or missing references)
			//IL_0168: Expected Obj, but got Unknown
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Expected Obj, but got Unknown
			//IL_018f: Expected I4, but got Obj
			//IL_018f: Expected I4, but got Obj
			//IL_0047: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I4
			//IL_005d: Expected Obj, but got I4
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Expected Obj, but got Unknown
			//IL_007d: Expected Obj, but got I4
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Expected Obj, but got Unknown
			//IL_00c1: Expected Obj, but got I
			//IL_00d1: Expected Obj, but got I
			//IL_00e1: Expected Obj, but got I
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected Obj, but got Unknown
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected Obj, but got Unknown
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
			object obj2 = 0;
			object obj3 = obj2;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
			int num2 = UnityEngine.Random.Range((int)"kiloowebclient_tags", (int)"");
			bool flag;
			if (num2 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v10 (System.Int32)+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				int num3 = default;
				object obj6 = num3 + 16;
				obj6 = 44;
				string text = ((string)num2).Substring(num3);
				object obj7 = text + 12;
				object obj8 = 0;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7))
				{
					object obj9 = text + 16;
					object obj10 = obj8 << 2;
					object obj11 = obj9 + obj10;
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S4_v8 (Il2CppMethodInfo)+C]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S4_v9+60]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S4_v10+48]");
					object obj14 = 0;
					object obj15 = obj14 & 0x7FF;
					object obj16 = obj15 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v90 @ S5_v8 (should have been resolved before IL gen)");
					object obj17 = obj8 + 1;
					obj8 = obj17;
				}
			}
			SimulatedCloudServer result = default;
			return result;
		}
	}

	public string kilooTag
	{
		get
		{
			//IL_00ee: Expected I, but got Obj
			//IL_0104: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0147: Expected Obj, but got Unknown
			//IL_015e: Expected I, but got Obj
			//IL_0174: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			nint num = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer+<>c>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v42 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = _003C_003Ec._003C_003E9__7_0 == null;
			bool flag2 = !flag;
			Func<KeyValuePair<string, Item>, ICloudItem> selector = _003C_003Ec._003C_003E9__7_0;
			if (!flag2)
			{
				nint num3 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v16 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer+<>c>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v36 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num5 = 0;
				_ = 0;
				Func<KeyValuePair<string, Item>, ICloudItem> func = default;
				object obj3 = func + 16;
				obj3 = _003C_003Ec._003C_003E9;
				nint num6 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v33 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer+<>c>)+5C]");
				object obj4 = (nint)0 + (nint)4;
				obj4 = func;
				selector = func;
			}
			IEnumerable<ICloudItem> source = Enumerable.Select(_items, selector);
			return (string)(object)Enumerable.OfType<TResult>((IEnumerable)source);
		}
	}

	public void Reload()
	{
	}

	public ICloudItem GetItem(string name)
	{
		//IL_000f: Expected Obj, but got I4
		return (ICloudItem)(object)ListItemsAsync(name, (CloudServerRequestCompleteHandler)1);
	}

	public List<ICloudItem> GetItems()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CloudWorkingCopy cloudWorkingCopy = default;
		cloudWorkingCopy.itemUpdated += (EventHandler<CloudItemUpdatedArgs>)(object)this;
		return (List<ICloudItem>)(object)cloudWorkingCopy;
	}

	public void SetItemLastModified(string name, DateTime lastModified)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public unsafe void SetItemRevision(string name, string revision)
	{
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected Obj, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected VT, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Ref, but got Unknown
		//IL_01cd: Expected I, but got Obj
		//IL_01e3: Expected Obj, but got I
		//IL_0026: Expected I, but got Obj
		//IL_003c: Expected Obj, but got I
		//IL_020e: Expected I, but got Obj
		//IL_02e5: Expected VT, but got I4
		//IL_02f3: Expected Obj, but got VT
		//IL_0308: Expected VT, but got Obj
		//IL_0303: Expected native int or pointer, but got VT
		//IL_00c2: Expected Obj, but got I4
		//IL_00d9: Expected Obj, but got VT
		//IL_0130: Expected I4, but got Obj
		//IL_0130: Expected I4, but got Obj
		//IL_0130: Expected I4, but got Obj
		//IL_0130: Expected I4, but got Obj
		//IL_0130: Expected I4, but got Obj
		//IL_0130: Expected I4, but got Obj
		//IL_0067: Expected I, but got Obj
		//IL_015d: Expected Obj, but got I
		//IL_016d: Expected Obj, but got I
		//IL_017d: Expected Obj, but got I
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		object obj = default;
		RealTimer realTimer = (RealTimer)(obj + 32);
		object obj2 = obj + 24;
		DateTime? dateTime = (DateTime?)(object)(obj + 8);
		ref Item reference = ref *(Item*)(obj + 48);
		reference = ref *(Item*)null;
		if (_items.TryGetValue(name, out reference))
		{
			Item item = reference;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCDB");
			nint num = (nint)typeof(TimeUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v30 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(TimeUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v74 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj4 = default;
			obj2 = obj4;
			realTimer = (RealTimer)obj2;
			DateTime currentTime = realTimer.GetCurrentTime();
			dateTime = (DateTime?)(object)0;
			_ = 0;
			obj = currentTime;
			realTimer = (RealTimer)obj;
			*(DateTime?*)(nint)dateTime = (DateTime)realTimer;
			Item item2 = reference;
			Item item3 = reference;
			Item item4 = reference;
			Item item5 = reference;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			_ = 0;
			bool flag = default;
			object obj5 = (flag ? 1 : 0) + 16;
			obj5 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			realTimer = (RealTimer)dateTime;
			RealTimer realTimer2 = realTimer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (System.Nullable`1<System.DateTime>)+8]");
			((BaseTimer)realTimer2).singleShot = false;
			Mono.Globalization.Unicode.SortKeyBuffer sortKeyBuffer = default;
			sortKeyBuffer.AppendKana((byte)(int)name, (byte)(int)item.revision__BackingField, (byte)(int)realTimer, (byte)(int)item2.sourceDescription__BackingField, (byte)(int)item3.sourceInstallationId__BackingField != 0, (byte)item4.dataVersion__BackingField, (byte)(int)item5.userData__BackingField != 0, flag);
			reference = ref *(Item*)sortKeyBuffer;
			((AuthenticateCompleteHandler)this).EndInvoke((IAsyncResult)sortKeyBuffer);
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S4_v4 (Il2CppMethodInfo)+C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S4_v5+60]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S4_v6+48]");
			object obj8 = 0;
			object obj9 = obj8 & 0x7FF;
			object obj10 = obj9 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v129 @ S5_v6 (should have been resolved before IL gen)");
			return;
		}
		object msg = ((IConvertible)"SetItemTimestamp: Item \"").ToType((Type)(object)name, (IFormatProvider)(object)"\" not found");
		nint num5 = (nint)typeof(SimulatedCloudServer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v12 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num6 = (nint)typeof(SimulatedCloudServer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v17 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Log((string)msg);
	}

	public unsafe void SetItemSourceDescription(string name, string sourceDescription)
	{
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected I4, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Ref, but got Unknown
		//IL_017b: Expected I, but got Obj
		//IL_0191: Expected Obj, but got I
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected Obj, but got Unknown
		//IL_0073: Expected Obj, but got I4
		//IL_01bc: Expected I, but got Obj
		//IL_0094: Expected I4, but got Obj
		//IL_00de: Expected I4, but got Obj
		//IL_00de: Expected I4, but got Obj
		//IL_00de: Expected I4, but got Obj
		//IL_00de: Expected I4, but got Obj
		//IL_00de: Expected I4, but got Obj
		//IL_010b: Expected Obj, but got I
		//IL_011b: Expected Obj, but got I
		//IL_012b: Expected Obj, but got I
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		object obj = default;
		byte b = (byte)(obj + 16);
		ref Item reference = ref *(Item*)(obj + 32);
		reference = ref *(Item*)null;
		if (_items.TryGetValue(name, out reference))
		{
			object obj2 = reference + 16;
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v21+8]");
			_ = 0;
			Item item = reference;
			Item item2 = reference;
			Item item3 = reference;
			Item item4 = reference;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			bool flag = default;
			object obj3 = (flag ? 1 : 0) + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			((byte*)(int)b)->m_value = (byte)(int)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Mono.Globalization.Unicode.SortKeyBuffer sortKeyBuffer = default;
			sortKeyBuffer.AppendKana((byte)(int)name, (byte)(int)sourceDescription, b, (byte)(int)item.sourceDescription__BackingField, (byte)(int)item2.sourceInstallationId__BackingField != 0, (byte)item3.dataVersion__BackingField, (byte)(int)item4.userData__BackingField != 0, flag);
			reference = ref *(Item*)sortKeyBuffer;
			((AuthenticateCompleteHandler)this).EndInvoke((IAsyncResult)sortKeyBuffer);
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S4_v4 (Il2CppMethodInfo)+C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S4_v5+60]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S4_v6+48]");
			object obj6 = 0;
			object obj7 = obj6 & 0x7FF;
			object obj8 = obj7 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v138 @ S5_v6 (should have been resolved before IL gen)");
			return;
		}
		object msg = ((IConvertible)"SetItemRevision: Item \"").ToType((Type)(object)name, (IFormatProvider)(object)"\" not found");
		nint num3 = (nint)typeof(SimulatedCloudServer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v10 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num4 = (nint)typeof(SimulatedCloudServer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v15 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Log((string)msg);
	}

	public unsafe void SetItemSourceInstallationId(string name, string sourceInstallationId)
	{
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected I4, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Ref, but got Unknown
		//IL_017b: Expected I, but got Obj
		//IL_0191: Expected Obj, but got I
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0073: Expected Obj, but got I4
		//IL_01bc: Expected I, but got Obj
		//IL_0094: Expected I4, but got Obj
		//IL_00de: Expected I4, but got Obj
		//IL_00de: Expected I4, but got Obj
		//IL_00de: Expected I4, but got Obj
		//IL_00de: Expected I4, but got Obj
		//IL_00de: Expected I4, but got Obj
		//IL_010b: Expected Obj, but got I
		//IL_011b: Expected Obj, but got I
		//IL_012b: Expected Obj, but got I
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		object obj = default;
		byte b = (byte)(obj + 16);
		ref Item reference = ref *(Item*)(obj + 32);
		reference = ref *(Item*)null;
		if (_items.TryGetValue(name, out reference))
		{
			Item item = reference;
			object obj2 = reference + 16;
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v21+8]");
			_ = 0;
			Item item2 = reference;
			Item item3 = reference;
			Item item4 = reference;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			bool flag = default;
			object obj3 = (flag ? 1 : 0) + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			((byte*)(int)b)->m_value = (byte)(int)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Mono.Globalization.Unicode.SortKeyBuffer sortKeyBuffer = default;
			sortKeyBuffer.AppendKana((byte)(int)name, (byte)(int)item.revision__BackingField, b, (byte)(int)sourceInstallationId, (byte)(int)item2.sourceInstallationId__BackingField != 0, (byte)item3.dataVersion__BackingField, (byte)(int)item4.userData__BackingField != 0, flag);
			reference = ref *(Item*)sortKeyBuffer;
			((AuthenticateCompleteHandler)this).EndInvoke((IAsyncResult)sortKeyBuffer);
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S4_v4 (Il2CppMethodInfo)+C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S4_v5+60]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S4_v6+48]");
			object obj6 = 0;
			object obj7 = obj6 & 0x7FF;
			object obj8 = obj7 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v138 @ S5_v6 (should have been resolved before IL gen)");
			return;
		}
		object msg = ((IConvertible)"SetItemSourceDescription: Item \"").ToType((Type)(object)name, (IFormatProvider)(object)"\" not found");
		nint num3 = (nint)typeof(SimulatedCloudServer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v10 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num4 = (nint)typeof(SimulatedCloudServer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v15 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Log((string)msg);
	}

	public unsafe void SetItemDataVersion(string name, int dataVersion)
	{
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected I4, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Ref, but got Unknown
		//IL_017b: Expected I, but got Obj
		//IL_0191: Expected Obj, but got I
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0073: Expected Obj, but got I4
		//IL_01bc: Expected I, but got Obj
		//IL_0094: Expected I4, but got Obj
		//IL_00de: Expected I4, but got Obj
		//IL_00de: Expected I4, but got Obj
		//IL_00de: Expected I4, but got Obj
		//IL_00de: Expected I4, but got Obj
		//IL_010b: Expected Obj, but got I
		//IL_011b: Expected Obj, but got I
		//IL_012b: Expected Obj, but got I
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		object obj = default;
		byte b = (byte)(obj + 16);
		ref Item reference = ref *(Item*)(obj + 32);
		reference = ref *(Item*)null;
		if (_items.TryGetValue(name, out reference))
		{
			Item item = reference;
			object obj2 = reference + 16;
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v21+8]");
			_ = 0;
			Item item2 = reference;
			Item item3 = reference;
			Item item4 = reference;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			bool flag = default;
			object obj3 = (flag ? 1 : 0) + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			((byte*)(int)b)->m_value = (byte)(int)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Mono.Globalization.Unicode.SortKeyBuffer sortKeyBuffer = default;
			sortKeyBuffer.AppendKana((byte)(int)name, (byte)(int)item.revision__BackingField, b, (byte)(int)item2.sourceDescription__BackingField, (byte)dataVersion != 0, (byte)item3.dataVersion__BackingField, (byte)(int)item4.userData__BackingField != 0, flag);
			reference = ref *(Item*)sortKeyBuffer;
			((AuthenticateCompleteHandler)this).EndInvoke((IAsyncResult)sortKeyBuffer);
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S4_v4 (Il2CppMethodInfo)+C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S4_v5+60]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S4_v6+48]");
			object obj6 = 0;
			object obj7 = obj6 & 0x7FF;
			object obj8 = obj7 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v138 @ S5_v6 (should have been resolved before IL gen)");
			return;
		}
		object msg = ((IConvertible)"SetItemSourceInstallationId: Item \"").ToType((Type)(object)name, (IFormatProvider)(object)"\" not found");
		nint num3 = (nint)typeof(SimulatedCloudServer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v10 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num4 = (nint)typeof(SimulatedCloudServer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v15 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Log((string)msg);
	}

	public void SimulateNewRevision(string name)
	{
		throw new InvalidOperationException();
	}

	public unsafe void SimulateNewRevision(string name, ICloudUserData userData)
	{
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected I4, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Ref, but got Unknown
		//IL_017b: Expected I, but got Obj
		//IL_0191: Expected Obj, but got I
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0073: Expected Obj, but got I4
		//IL_01bc: Expected I, but got Obj
		//IL_0094: Expected I4, but got Obj
		//IL_00de: Expected I4, but got Obj
		//IL_00de: Expected I4, but got Obj
		//IL_00de: Expected I4, but got Obj
		//IL_00de: Expected I4, but got Obj
		//IL_00de: Expected I4, but got Obj
		//IL_00de: Expected I4, but got Obj
		//IL_010b: Expected Obj, but got I
		//IL_011b: Expected Obj, but got I
		//IL_012b: Expected Obj, but got I
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		object obj = default;
		byte b = (byte)(obj + 16);
		ref Item reference = ref *(Item*)(obj + 32);
		reference = ref *(Item*)null;
		if (_items.TryGetValue(name, out reference))
		{
			Item item = reference;
			object obj2 = reference + 16;
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v21+8]");
			_ = 0;
			Item item2 = reference;
			Item item3 = reference;
			Item item4 = reference;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			bool flag = default;
			object obj3 = (flag ? 1 : 0) + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			((byte*)(int)b)->m_value = (byte)(int)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Mono.Globalization.Unicode.SortKeyBuffer sortKeyBuffer = default;
			sortKeyBuffer.AppendKana((byte)(int)name, (byte)(int)item.revision__BackingField, b, (byte)(int)item2.sourceDescription__BackingField, (byte)(int)item3.sourceInstallationId__BackingField != 0, (byte)(int)userData, (byte)(int)item4.userData__BackingField != 0, flag);
			reference = ref *(Item*)sortKeyBuffer;
			((AuthenticateCompleteHandler)this).EndInvoke((IAsyncResult)sortKeyBuffer);
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S4_v4 (Il2CppMethodInfo)+C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S4_v5+60]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S4_v6+48]");
			object obj6 = 0;
			object obj7 = obj6 & 0x7FF;
			object obj8 = obj7 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v138 @ S5_v6 (should have been resolved before IL gen)");
			return;
		}
		object msg = ((IConvertible)"SetItemDataVersion: Item \"").ToType((Type)(object)name, (IFormatProvider)(object)"\" not found");
		nint num3 = (nint)typeof(SimulatedCloudServer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v10 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num4 = (nint)typeof(SimulatedCloudServer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v15 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Log((string)msg);
	}

	public void SimulateNewRevision(string name, byte[] bytes, string sourceDescription, string sourceInstallationId, int dataVersion, ICloudUserData userData)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_001d: Expected I4, but got Obj
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0049: Expected Obj, but got I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = name;
		simulateError = (byte)(int)bytes != 0;
		string localDir = (string)(sourceDescription & 1);
		_localDir = localDir;
		_metadataDir = sourceInstallationId;
		_items = (Dictionary<string, Item>)dataVersion;
		IJsonSerializer jsonSerializer = (IJsonSerializer)(userData & 1);
		_jsonSerializer = jsonSerializer;
		((Connection)this).CheckValidOperation();
	}

	public Coroutine ListItemsAsync(string forKilooTag, CloudServerRequestCompleteHandler completeHandler)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Expected Obj, but got Unknown
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Expected Obj, but got Unknown
		//IL_05c6: Expected Obj, but got I4
		//IL_05cf: Expected Obj, but got I4
		//IL_0676: Expected Obj, but got I
		//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b1: Expected Obj, but got Unknown
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj3 = default;
		bool flag = obj3 != null;
		Coroutine coroutine;
		object obj9;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj5 = default;
			object obj4 = obj5;
			object obj7 = default;
			object obj6 = obj7;
			coroutine = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj8 = default;
			if (obj4 != obj8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				goto IL_0834;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			object obj10 = default;
			obj9 = obj10;
		}
		else
		{
			coroutine = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			object obj11 = obj2 + 4;
			object obj12 = obj11 + 1;
			obj11 = obj12;
			object obj13 = obj12 << 2;
			object obj14 = obj2 + obj13;
			obj14 = 127;
			obj9 = 0;
		}
		object obj15 = default;
		Coroutine result = default;
		if (!flag)
		{
			obj15 = obj9;
			result = coroutine;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			obj15 = obj9;
			result = coroutine;
		}
		goto IL_0834;
		IL_0834:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj16 = (nint)0 << 2;
			object obj17 = obj2 + obj16;
			if ((nint)obj17 == 127)
			{
				object obj18 = obj2 + 4;
				if ((nint)obj18 > -1)
				{
					object obj19 = obj18 + -1;
					obj18 = obj19;
				}
				goto IL_08a1;
			}
		}
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_08a1;
		IL_08a1:
		return result;
	}

	public unsafe CloudServerResult ListItems(string forKilooTag)
	{
		ref Item reference = ref *(Item*)null;
		if (_items.TryGetValue(forKilooTag, out reference))
		{
			return (CloudServerResult)(object)reference;
		}
		return null;
	}

	public Coroutine UpdateItemsAsync(string forKilooTag, IEnumerable<ICloudItem> items, CloudServerRequestCompleteHandler completeHandler)
	{
		//IL_0009: Expected Obj, but got I4
		object obj = 0;
		obj = forKilooTag;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A3");
		Coroutine result = default;
		return result;
	}

	public CloudServerResult UpdateItems(string forKilooTag, IEnumerable<ICloudItem> items)
	{
		CloudServerResult list = InternalUpdateItems(items);
		return (CloudServerResult)(object)CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	public Coroutine CommitItemsAsync(string forKilooTag, IEnumerable<ICloudItem> items, CloudServerCommitCompleteHandler completeHandler)
	{
		IEnumerator list = CommitItemsCoroutine(items, completeHandler);
		return CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	public CloudServerCommitResult CommitItems(string forKilooTag, IEnumerable<ICloudItem> items)
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		object obj = default;
		Thread thread = (Thread)(obj + 8);
		if (simulatedLatency > 0f)
		{
			nint num = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v19 (Il2CppClass<System.TimeSpan>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(TimeSpan);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v26 (Il2CppClass<System.TimeSpan>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3EB");
			object obj3 = default;
			obj = obj3;
			thread = (Thread)obj;
			thread.ConstructInternalThread();
		}
		return InternalCommitItems(items);
	}

	private SimulatedCloudServer()
	{
		LogError((string)(object)this);
	}

	private CloudServerResult InternalListItems()
	{
		return null;
	}

	private IEnumerator ListItemsCoroutine(CloudServerRequestCompleteHandler completeHandler)
	{
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_0099: Expected VT, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		object obj = default;
		Thread thread = (Thread)(obj + 8);
		if (simulatedLatency > 0f)
		{
			nint num = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v19 (Il2CppClass<System.TimeSpan>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(TimeSpan);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v26 (Il2CppClass<System.TimeSpan>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3EB");
			object obj3 = default;
			obj = obj3;
			thread = (Thread)obj;
			thread.ConstructInternalThread();
		}
		return (IEnumerator)(object)ToRevision((DateTime?)(object)this);
	}

	private CloudServerResult InternalUpdateItems(IEnumerable<ICloudItem> items)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CloudServerResult cloudServerResult = default;
		cloudServerResult.status = CloudSaveStatus.OK;
		object obj = cloudServerResult + 16;
		obj = this;
		object obj2 = cloudServerResult + 20;
		obj2 = items;
		return cloudServerResult;
	}

	private IEnumerator UpdateItemsCoroutine(IEnumerable<ICloudItem> items, CloudServerRequestCompleteHandler completeHandler)
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		object obj = default;
		Thread thread = (Thread)(obj + 8);
		if (simulatedLatency > 0f)
		{
			nint num = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v19 (Il2CppClass<System.TimeSpan>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(TimeSpan);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v26 (Il2CppClass<System.TimeSpan>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3EB");
			object obj3 = default;
			obj = obj3;
			thread = (Thread)obj;
			thread.ConstructInternalThread();
		}
		return (IEnumerator)(object)GetMetadataPathFor((string)(object)completeHandler);
	}

	private static string ToRevision(DateTime? value)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Expected Obj, but got VT
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (System.Nullable`1<System.DateTime>)+C]");
		bool flag = (nint)0 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		if (flag)
		{
			text.m_stringLength = 2;
			object obj = text + 12;
			obj = 0;
		}
		else
		{
			text.m_stringLength = 0;
			object obj2 = text + 12;
			string temporaryCode = ((KilooAuth)value).temporaryCode;
			obj2 = temporaryCode;
		}
		return text;
	}

	private unsafe CloudServerCommitResult InternalCommitItems(IEnumerable<ICloudItem> items)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Expected I4, but got Unknown
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Expected Obj, but got Unknown
		//IL_05a4: Expected Obj, but got I4
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected Obj, but got Unknown
		//IL_05c1: Expected Obj, but got I4
		//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Expected Obj, but got Unknown
		//IL_05e4: Expected Obj, but got I4
		//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f2: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_007e: Expected Obj, but got I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0042: Expected Obj, but got I4
		//IL_020b: Expected Obj, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_00cc: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected Obj, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected Obj, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected Obj, but got Unknown
		//IL_037e: Expected Obj, but got I4
		//IL_0182: Expected I4, but got Obj
		//IL_0263: Expected Obj, but got I4
		//IL_0793: Expected I, but got Obj
		//IL_07a9: Expected Obj, but got I
		//IL_03e5: Expected Obj, but got I
		//IL_07ce: Expected native int or pointer, but got Obj
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f9: Expected Obj, but got Unknown
		//IL_049d: Expected I, but got Obj
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected Obj, but got Unknown
		//IL_029e: Expected Obj, but got I
		//IL_04ea: Expected I, but got Obj
		//IL_0500: Expected Obj, but got I
		//IL_02c7: Expected Obj, but got I4
		//IL_072a: Expected Obj, but got I
		//IL_073e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0743: Expected Obj, but got Unknown
		//IL_075a: Expected I, but got Obj
		//IL_0770: Expected Obj, but got I
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected Obj, but got Unknown
		//IL_052b: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 96;
		byte b = (byte)(obj2 + 40);
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 72;
		obj4 = 0;
		_ = 0;
		_ = 0;
		object obj5 = obj2 + 16;
		obj5 = 0;
		object obj6 = obj2 - -64;
		obj6 = obj;
		_ = -1;
		ICloudItem[] array = Enumerable.ToArray(items);
		if (~(simulateError ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CloudServerCommitResult cloudServerCommitResult = default;
			cloudServerCommitResult.status = CloudSaveStatus.Error;
			object obj7 = cloudServerCommitResult + 12;
			obj7 = 0;
			return cloudServerCommitResult;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<ICloudItem> list = default;
		list._002Ector();
		object obj8 = array + 12;
		object obj9 = 0;
		object obj18 = default;
		Mono.Globalization.Unicode.SortKeyBuffer sortKeyBuffer = default;
		byte category = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8))
		{
			object obj10 = array + 16;
			object obj11 = obj9 << 2;
			object obj12 = obj10 + obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S2_v35 (Il2CppMethodInfo)+C]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S2_v36+60]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S2_v37+44]");
			object obj15 = 0;
			object obj16 = obj15 & 0x1FFF;
			object obj17 = obj16 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v202 @ S3_v19 (should have been resolved before IL gen)");
			if ((nint)obj18 <= -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
				obj2 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				((byte*)(int)b)->m_value = (byte)(int)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				sortKeyBuffer.AppendKana(category, (byte)0, b, (byte)0, false, (byte)0, false, false);
				list.Add((ICloudItem)sortKeyBuffer);
			}
			object obj19 = obj9 + 1;
			obj9 = obj19;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj4 = ((byte*)(int)b)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Byte)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Byte)+10]");
		_ = 0;
		object obj20 = default;
		nint num2 = default;
		object obj22 = default;
		object obj23 = default;
		object obj24 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj20 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj5 = ((byte*)(int)b)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj21 = num2 + 8;
			obj21 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			((Predicate<ICloudItem>)5519)._002Ector(obj23, (IntPtr)num2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
		}
		object obj25 = obj6 + 4;
		object obj26 = obj25 + 1;
		obj25 = obj26;
		object obj27 = obj26 << 2;
		object obj28 = obj6 + obj27;
		obj28 = 220;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v23+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v23+4]");
			object obj29 = (nint)0 << 2;
			object obj30 = obj6 + obj29;
			if ((nint)obj30 == 220)
			{
				object obj31 = obj6 + 4;
				if ((nint)obj31 > -1)
				{
					object obj32 = obj31 + -1;
					obj31 = obj32;
				}
				goto IL_0785;
			}
		}
		object obj33 = default;
		if (obj33 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0785;
		IL_0785:
		nint num3 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ S0_v59 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer+<>c>)+BA]");
		object obj34 = (nint)0 & (nint)0x200;
		if (obj34 != null)
		{
			nint num4 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S0_v101 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__33_0 == null;
		bool flag2 = !flag;
		Queue<_00210> q = (Queue<_00210>)(object)_003C_003Ec._003C_003E9__33_0;
		if (!flag2)
		{
			nint num5 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ S0_v75 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer+<>c>)+BA]");
			object obj35 = (nint)0 & (nint)0x200;
			if (obj35 != null)
			{
				nint num6 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ S0_v95 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num7 = 0;
			Queue<_00210> queue = default;
			queue._array = (_00210[])num7;
			queue._size = 0;
			object obj36 = queue + 16;
			obj36 = _003C_003Ec._003C_003E9;
			nint num8 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ S0_v92 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer+<>c>)+5C]");
			object obj37 = (nint)0 + (nint)8;
			obj37 = queue;
			q = queue;
		}
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)list, new Queue<T>.Enumerator((Queue<T>)(object)q));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CloudServerCommitResult cloudServerCommitResult2 = default;
		cloudServerCommitResult2.status = CloudSaveStatus.OK;
		object obj38 = cloudServerCommitResult2 + 12;
		ICloudItem[] array2 = list.ToArray();
		obj38 = array2;
		return cloudServerCommitResult2;
	}

	private IEnumerator CommitItemsCoroutine(IEnumerable<ICloudItem> items, CloudServerCommitCompleteHandler completeHandler)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		object obj2 = enumerator + 20;
		obj2 = items;
		object obj3 = enumerator + 24;
		obj3 = completeHandler;
		return enumerator;
	}

	private void CreateLocalDirsIfNecessary()
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00d5: Expected I, but got Obj
		//IL_00eb: Expected Obj, but got I
		//IL_011f: Expected I, but got Obj
		//IL_0135: Expected Obj, but got I
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_0177: Expected Obj, but got I4
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_019e: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		FlurryVideoAds.LogError(text, (UnityEngine.Object)null);
		object obj = this + 28;
		obj = text;
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v31 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string cachePath = DeviceUtility.GetCachePath();
		nint num3 = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18 (Il2CppClass<System.IO.Path>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v27 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = this + 16;
		bool flag = Path.SameRoot(cachePath, ".simulatedcloudserver");
		obj4 = flag;
		object obj5 = this + 20;
		bool flag2 = Path.SameRoot(_localDir, ".metadata");
		obj5 = flag2;
		LogError((string)(object)this);
	}

	private unsafe string GetMetadataPathFor(string name)
	{
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected Obj, but got Unknown
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected Obj, but got Unknown
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected Obj, but got Unknown
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected Obj, but got Unknown
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Expected Ref, but got Unknown
		//IL_0055: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_014a: Expected Obj, but got I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_0290: Expected I, but got Obj
		//IL_02a6: Expected Obj, but got I
		//IL_0738: Expected I, but got Obj
		//IL_074e: Expected Obj, but got I
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_0636: Expected Obj, but got I
		//IL_0646: Expected Obj, but got I
		//IL_0656: Expected Obj, but got I
		//IL_065f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Expected Obj, but got Unknown
		//IL_066d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Expected Obj, but got Unknown
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected Obj, but got Unknown
		//IL_0773: Expected Obj, but got I8
		//IL_0791: Expected VT, but got I4
		//IL_079f: Expected Obj, but got VT
		//IL_07b4: Expected VT, but got Obj
		//IL_07af: Expected native int or pointer, but got VT
		//IL_07c2: Expected I, but got Obj
		//IL_07d8: Expected Obj, but got I
		//IL_02d1: Expected I, but got Obj
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_07fd: Expected Obj, but got VT
		//IL_0828: Expected Obj, but got I4
		//IL_031e: Expected I, but got Obj
		//IL_036b: Expected I, but got Obj
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Expected Obj, but got Unknown
		//IL_0707: Unknown result type (might be due to invalid IL or missing references)
		//IL_070c: Expected Obj, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected Obj, but got Unknown
		//IL_03e6: Expected VT, but got I4
		//IL_03f4: Expected Obj, but got VT
		//IL_0409: Expected VT, but got Obj
		//IL_0404: Expected native int or pointer, but got VT
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected Obj, but got Unknown
		//IL_0466: Expected Obj, but got I4
		//IL_0482: Expected Obj, but got VT
		//IL_04c0: Expected I4, but got Obj
		//IL_04c0: Expected I4, but got Obj
		//IL_04e5: Expected Obj, but got I
		//IL_04f5: Expected Obj, but got I
		//IL_0505: Expected Obj, but got I
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected Obj, but got Unknown
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected Obj, but got Unknown
		//IL_057d: Expected Obj, but got I4
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Expected Obj, but got Unknown
		DateTime? dateTime = default;
		RealTimer realTimer = (RealTimer)((Nullable)dateTime + 40);
		object obj = (Nullable)dateTime + 32;
		object obj2 = (Nullable)dateTime + 24;
		object obj3 = (Nullable)dateTime + 16;
		ref Item reference = ref *(Item*)((Nullable)dateTime + 56);
		reference = ref *(Item*)null;
		ICloudItem[] array = Enumerable.ToArray((IEnumerable<ICloudItem>)(object)name);
		if (~(simulateError ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			string text = default;
			text.m_stringLength = 2;
			return text;
		}
		LoadRepository();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S3_v3 (Il2CppMethodInfo)+C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S3_v4+60]");
		object obj5 = 0;
		object obj6 = obj5;
		object obj7 = obj6 & 0x1FFF;
		object obj8 = obj7 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v152 @ S4_v5 (should have been resolved before IL gen)");
		object obj9 = array + 12;
		object obj10 = default;
		object obj19 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9))
		{
			object obj11 = array + 16;
			object obj12 = obj10 << 2;
			object userData = obj11 + obj12;
			Dictionary<string, string> dictionary = CloudUserDataExtensions.ToDictionary((ICloudUserData)userData);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			if (dictionary != null)
			{
				int num2 = Checksum.ComputeCrc32((Stream)(object)dictionary);
				object obj13 = dictionary + 12;
			}
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S4_v22 (Il2CppMethodInfo)+C]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S4_v23+60]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S4_v24+48]");
			object obj16 = 0;
			object obj17 = obj16 & 0x7FF;
			object obj18 = obj17 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v165 @ S5_v18 (should have been resolved before IL gen)");
			obj10 = obj19 + 1;
		}
		object obj20 = 0;
		object obj21 = obj9;
		string key = default;
		int index = default;
		object obj25 = default;
		int stringLength;
		bool flag2 = default;
		Mono.Globalization.Unicode.SortKeyBuffer sortKeyBuffer = default;
		byte category = default;
		byte lv = default;
		bool isSmallKana = default;
		byte markType = default;
		bool isKatakana = default;
		string path = default;
		while (true)
		{
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21))
			{
				object obj22 = array + 16;
				object obj23 = obj20 << 2;
				object obj24 = obj22 + obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				if (_items.TryGetValue(key, out reference))
				{
					Item item = reference;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					if (item.revision__BackingField.get_Chars(index) == '\0')
					{
						goto IL_0251;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					bool flag;
					if (obj25 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S0_v144+8]");
						flag = (nint)0 == 0;
					}
					else
					{
						flag = true;
					}
					if (flag)
					{
						goto IL_0251;
					}
				}
				stringLength = 1;
				break;
			}
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S0_v48 (Il2CppClass<System.DateTime>)+BA]");
			object obj26 = (nint)0 & (nint)0x200;
			if (obj26 != null)
			{
				nint num5 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S0_v129 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
			nint num6 = (nint)typeof(TimeUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S0_v55 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
			object obj27 = (nint)0 & (nint)0x200;
			if (obj27 != null)
			{
				nint num7 = (nint)typeof(TimeUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S0_v125 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj = systemTimeAsFileTime;
			realTimer = (RealTimer)obj;
			DateTime currentTime = realTimer.GetCurrentTime();
			dateTime = (DateTime?)(object)0;
			_ = 0;
			obj2 = currentTime;
			realTimer = (RealTimer)obj2;
			*(DateTime?*)(nint)dateTime = (DateTime)realTimer;
			nint num8 = (nint)typeof(SimulatedCloudServer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S0_v71 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer>)+BA]");
			object obj28 = (nint)0 & (nint)0x200;
			if (obj28 != null)
			{
				nint num9 = (nint)typeof(SimulatedCloudServer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S0_v121 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			realTimer = (RealTimer)dateTime;
			RealTimer realTimer2 = realTimer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (System.Nullable`1<System.DateTime>)+8]");
			((BaseTimer)realTimer2).singleShot = false;
			ICloudItem[] statusList = ((SimulatedCloudServer)(object)realTimer).GetStatusList();
			object obj29 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj29) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9))
			{
				object obj30 = array + 16;
				object obj31 = obj29 << 2;
				object userData2 = obj30 + obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				dateTime = (DateTime?)(object)0;
				_ = 0;
				obj3 = currentTime;
				realTimer = (RealTimer)obj3;
				*(DateTime?*)(nint)dateTime = (DateTime)realTimer;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num10 = 0;
				_ = 0;
				object obj32 = (flag2 ? 1 : 0) + 16;
				obj32 = this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				realTimer = (RealTimer)dateTime;
				RealTimer realTimer3 = realTimer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (System.Nullable`1<System.DateTime>)+8]");
				((BaseTimer)realTimer3).singleShot = false;
				sortKeyBuffer.AppendKana(category, (byte)(int)statusList, (byte)(int)realTimer, lv, isSmallKana, markType, isKatakana, flag2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ S4_v13 (Il2CppMethodInfo)+C]");
				object obj33 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ S4_v14+60]");
				object obj34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ S4_v15+48]");
				object obj35 = 0;
				object obj36 = obj35 & 0x7FF;
				object obj37 = obj36 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v558 @ S5_v12 (should have been resolved before IL gen)");
				((AuthenticateCompleteHandler)this).EndInvoke((IAsyncResult)sortKeyBuffer);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				string nameFor = GetNameFor(path);
				Dictionary<string, string> contentList = CloudUserDataExtensions.ToDictionary((ICloudUserData)userData2);
				((DebugSettingsPopup.DebugSettingsListAdapter)(object)nameFor)._002Ector((List<DebugSettingsCell>)(object)contentList, (GameObject)null, (GameObject)null, (GameObject)(-1), (GameObject)null, (GameObject)null, (GameObject)null, (GameObject)null, (DebugSettingsPopup)null);
				object obj38 = obj29 + 1;
				obj29 = obj38;
			}
			stringLength = 0;
			break;
			IL_0251:
			object obj39 = obj20 + 1;
			obj20 = obj39;
			obj21 = obj9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text2 = default;
		text2.m_stringLength = stringLength;
		object obj40 = text2 + 12;
		string temporaryCode = ((KilooAuth)this).temporaryCode;
		obj40 = temporaryCode;
		object obj41 = text2 + 16;
		object obj42 = default;
		obj41 = obj42;
		return text2;
	}

	private string GetPathFor(string name)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<System.IO.Path>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v8 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (string)Path.SameRoot(_metadataDir, name);
	}

	private string GetNameFor(string path)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<System.IO.Path>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v8 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (string)Path.SameRoot(_localDir, path);
	}

	private void LoadRepository()
	{
		if (!Directory.IsRootDirectory(_localDir))
		{
			DirectoryInfo directoryInfo = Directory.CreateDirectoriesInternal(_localDir);
		}
		if (!Directory.IsRootDirectory(_metadataDir))
		{
			DirectoryInfo directoryInfo2 = Directory.CreateDirectoriesInternal(_metadataDir);
		}
	}

	private unsafe ICloudItem[] GetStatusList()
	{
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected VT, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected Obj, but got Unknown
		//IL_0230: Expected Obj, but got I4
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected Obj, but got Unknown
		//IL_0247: Expected Obj, but got I4
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_025e: Expected Obj, but got I4
		//IL_0269: Invalid comparison between F4 and I4
		//IL_0017: Expected Obj, but got VT
		//IL_0034: Expected I, but got Obj
		//IL_004a: Expected Obj, but got I
		//IL_028b: Expected I, but got Obj
		//IL_02a1: Expected Obj, but got I
		//IL_0315: Expected Obj, but got VT
		//IL_0322: Expected I8, but got Obj
		//IL_031d: Expected native int or pointer, but got VT
		//IL_0337: Expected Ref, but got VT
		//IL_0343: Expected Obj, but got I8
		//IL_0075: Expected I, but got Obj
		//IL_00c2: Expected I, but got Obj
		//IL_015e: Expected F8, but got I8
		//IL_02f0: Expected Obj, but got F8
		//IL_019f: Expected F8, but got I8
		//IL_01e0: Expected F8, but got I8
		object obj = default;
		IFormatProvider formatProvider = (IFormatProvider)(obj + 48);
		DateTime dateTime = (DateTime)(obj + 40);
		object obj2 = obj + 8;
		object obj3 = obj + 32;
		obj3 = 0;
		object obj4 = obj + 24;
		obj4 = 0;
		object obj5 = obj + 16;
		obj5 = 0;
		if (simulatedLatency != 0f)
		{
			DateTime value = ((DateTime?*)this)->Value;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCDB");
			nint num = (nint)typeof(SimulatedCloudServer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v30 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(SimulatedCloudServer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v54 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v38 (Il2CppClass<System.DateTime>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num4 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v50 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj8 = default;
			obj2 = obj8;
			obj = _epoch;
			((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj2;
			formatProvider = (IFormatProvider)obj;
			long num5 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
			obj3 = num5;
			double num6 = (double)obj3 * 0.0001;
			if (num6 > 922337203685477.0)
			{
				num6 = 922337203685477.0;
			}
			else if (num6 < -922337203685477.0)
			{
				num6 = -922337203685477.0;
			}
			if (num6 != num6)
			{
				num6 = -9.223372036854776E+18;
			}
			else if (!(num6 < 9.223372036854776E+18))
			{
				num6 = -9.223372036854776E+18;
			}
			else if (!(num6 > -9.223372036854776E+18))
			{
				num6 = -9.223372036854776E+18;
			}
			obj5 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D677");
			ICloudItem[] result = default;
			return result;
		}
		return null;
	}

	private unsafe void SaveMetadata(Item item)
	{
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected I4, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected VT, but got Unknown
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Ref, but got Unknown
		//IL_01ff: Expected I, but got Obj
		//IL_0215: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0240: Expected I, but got Obj
		//IL_0308: Expected I, but got Obj
		//IL_031e: Expected Obj, but got I
		//IL_0343: Expected Obj, but got I8
		//IL_0350: Expected I4, but got Obj
		//IL_0363: Expected VT, but got I4
		//IL_0371: Expected Obj, but got I8
		//IL_037e: Expected I4, but got Obj
		//IL_038b: Expected VT, but got I4
		//IL_0386: Expected native int or pointer, but got VT
		//IL_0054: Expected I, but got Obj
		//IL_00fc: Expected Obj, but got I4
		//IL_0118: Expected I4, but got VT
		//IL_0162: Expected I4, but got Obj
		//IL_0162: Expected I4, but got Obj
		//IL_0162: Expected I4, but got Obj
		//IL_0162: Expected I4, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_018f: Expected Obj, but got I
		//IL_019f: Expected Obj, but got I
		//IL_01af: Expected Obj, but got I
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		object obj = default;
		byte b = (byte)(obj + 32);
		object obj2 = obj + 24;
		DateTime? dateTime = (DateTime?)(object)(obj + 8);
		ref Item reference = ref *(Item*)(obj + 48);
		reference = ref *(Item*)null;
		if (_items.TryGetValue((string)(object)item, out reference))
		{
			nint num = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v25 (Il2CppClass<System.DateTime>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v80 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
			nint num3 = (nint)typeof(TimeUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v32 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(TimeUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v76 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = systemTimeAsFileTime;
			((byte*)(int)b)->m_value = (byte)(int)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D76F");
			dateTime = (DateTime?)(object)0;
			_ = 0;
			obj = systemTimeAsFileTime;
			((byte*)(int)b)->m_value = (byte)(int)obj;
			*(DateTime?*)(nint)dateTime = (DateTime)b;
			Item item2 = reference;
			Item item3 = reference;
			Item item4 = reference;
			Item item5 = reference;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			bool flag = default;
			object obj5 = (flag ? 1 : 0) + 16;
			obj5 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			((byte*)(int)b)->m_value = (byte)(int)dateTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (System.Nullable`1<System.DateTime>)+8]");
			_ = 0;
			Mono.Globalization.Unicode.SortKeyBuffer sortKeyBuffer = default;
			byte lv = default;
			sortKeyBuffer.AppendKana((byte)(int)item, lv, b, (byte)(int)item2.sourceDescription__BackingField, (byte)(int)item3.sourceInstallationId__BackingField != 0, (byte)item4.dataVersion__BackingField, (byte)(int)item5.userData__BackingField != 0, flag);
			reference = ref *(Item*)sortKeyBuffer;
			((AuthenticateCompleteHandler)this).EndInvoke((IAsyncResult)sortKeyBuffer);
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S4_v4 (Il2CppMethodInfo)+C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S4_v5+60]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S4_v6+48]");
			object obj8 = 0;
			object obj9 = obj8 & 0x7FF;
			object obj10 = obj9 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v121 @ S5_v6 (should have been resolved before IL gen)");
			return;
		}
		object msg = ((IConvertible)"SimulateCommitExisting: Item \"").ToType((Type)(object)item, (IFormatProvider)(object)"\" not found");
		nint num7 = (nint)typeof(SimulatedCloudServer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v12 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num8 = (nint)typeof(SimulatedCloudServer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v17 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Log((string)msg);
	}

	private Item LoadMetadata(string filename)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.IO.Path>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (Item)(object)Path.GetFullPath(filename);
	}

	private byte[] LoadItem(string name)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected Obj, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected Obj, but got Unknown
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected Obj, but got Unknown
		//IL_0409: Expected Obj, but got I4
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected Obj, but got Unknown
		//IL_0426: Expected Obj, but got I4
		//IL_0435: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 80;
		object obj3 = obj2 + 48;
		object obj4 = obj2 - -64;
		obj4 = obj;
		_ = -1;
		object obj5 = obj2 + 32;
		obj5 = 0;
		_ = 0;
		object obj6 = obj2 + 16;
		obj6 = 0;
		_ = 0;
		obj2 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj8 = default;
		object obj7 = obj8;
		object obj10 = default;
		object obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj11 = default;
		if (obj9 == obj11)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj13 = default;
			object obj12 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj15 = default;
			object obj14 = obj15;
		}
		else
		{
			object obj14 = obj7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		byte[] result = default;
		return result;
	}

	public static void DeleteServerDebug()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		throw new ArrayTypeMismatchException();
	}

	private static void LogError(string msg)
	{
		//IL_0118: Expected Obj, but got I
		//IL_0128: Expected Obj, but got I
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected Obj, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_017d: Expected Obj, but got I
		//IL_0016: Expected Obj, but got I
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_0031: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_00ac: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v77 @ S4_v7 (should have been resolved before IL gen)");
		object obj6 = msg + 24;
		object obj7 = default;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+14]");
		if (!Directory.IsRootDirectory((string)0))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+14]");
		string[] directories = Directory.GetDirectories((string)0);
		object obj8 = directories + 12;
		object obj9 = 113696;
		object obj10 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8))
		{
			object obj11 = directories + 16;
			object obj12 = obj10 << 2;
			object name = obj11 + obj12;
			byte[] array = ((SimulatedCloudServer)(object)msg).LoadItem((string)name);
			if (array != null)
			{
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S4_v9 (Il2CppMethodInfo)+C]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S4_v10+60]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S4_v11+48]");
				obj5 = 0;
				object obj15 = obj5 & 0x7FF;
				obj9 = obj15 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v76 @ S5_v5 (should have been resolved before IL gen)");
			}
			object obj16 = obj10 + 1;
			obj10 = obj16;
		}
	}

	private static void Log(string msg)
	{
		//IL_0060: Expected I4, but got Obj
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string exception = string.ConcatArray((string[])(object)"[SimulatedCloudServer] ", (int)msg);
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogException((Exception)(object)exception);
	}

	static SimulatedCloudServer()
	{
		//IL_011c: Expected I, but got Obj
		//IL_0132: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0166: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_00f3: Expected Obj, but got I4
		//IL_00f3: Expected Obj, but got I4
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v31 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(SimulatedCloudServer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v17 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(SimulatedCloudServer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v27 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<string, AbstractAdProvider> idToAdProvider = AbstractAdProvider.idToAdProvider;
			if (Directory.IsRootDirectory((string)idToAdProvider.count))
			{
				Directory.Move((string)idToAdProvider.count, (string)1);
			}
		}
		else
		{
			SDebug.LogFormat("DEBUG is not enabled - you cannot delete files with current project settings!", null);
		}
	}
}

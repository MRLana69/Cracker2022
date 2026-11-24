using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using Cpp2ILInjected;
using Ionic.Zlib;
using Kiloo.Common.Ads;
using Kiloo.Common.Backend.Authentication;
using Kiloo.Common.Backend.PurchaseValidation;
using Kiloo.Common.Diagnostics;
using Kiloo.Common.Extensions;
using Kiloo.Common.HTTP;
using Kiloo.Common.HTTP.Internal;
using Kiloo.Common.Utility;
using UnityEngine;
using UnityEngine.Rendering;

namespace Kiloo.Common.Backend.Cloud;

public sealed class CloudServer2 : ICloudServer
{
	private class Metadata
	{
		public string sourceDescription;

		public string sourceInstallationId;

		public int dataVersion;

		public bool zipped;

		public Metadata()
		{
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected Obj, but got Unknown
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Expected Obj, but got Unknown
			//IL_010c: Expected Obj, but got I4
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Expected Obj, but got Unknown
			//IL_0054: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 1;
			Encoding uTF = Encoding.UTF32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			nint num = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v8 (Il2CppClass<System.Convert>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Convert);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v21 (Il2CppClass<System.Convert>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj3 = default;
			object obj2 = obj3 + 12;
			string s = default;
			byte[] array = Convert.FromBase64String(s);
			obj2 = array;
			object obj4 = obj3 + 16;
			obj4 = 0;
			object obj5 = sourceDescription + 16;
			obj5 = obj3;
			if (sourceInstallationId != null)
			{
				sourceInstallationId((PurchaseValidationRequest)(object)sourceDescription);
			}
		}
	}

	private class RequestItem
	{
		public string name;

		public DateTime? lastModified;

		public int? size;

		public Dictionary<string, string> metadata;

		public byte[] data;

		public RequestItem()
		{
			_ = 1;
		}
	}

	private class RequestObject
	{
		public List<RequestItem> items;
	}

	private class ResponseObject
	{
		public CloudSaveStatus status;

		public List<RequestItem> items;
	}

	public static class ErrorCodes
	{
		public const string CATEGORY = "CloudSave";

		public const int INTERNAL_ERROR = 3000;

		public const int INVALID_REQUEST = 3001;

		public const int TIMEOUT = 3002;

		public const int QUOTA_EXCEEDED = 3003;
	}

	private class Item : ICloudItem
	{
		private readonly RequestItem _requestItem;

		private readonly CloudUserData _cloudUserData;

		private readonly string _revision;

		private readonly string _sourceDescription;

		private readonly string _sourceInstallationId;

		private readonly int _dataVersion;

		private readonly bool _zipped;

		public string name => _revision;

		public string revision
		{
			get
			{
				RequestItem requestItem = _requestItem;
				return requestItem.name;
			}
		}

		public DateTime? lastModified
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				DateTime? dateTime = default;
				object obj = (Nullable)dateTime + 16;
				obj = this;
				return dateTime;
			}
		}

		public bool isModified
		{
			get
			{
				//IL_0007: Expected I4, but got Obj
				return (byte)(int)_revision != 0;
			}
		}

		public bool isOutOfDate => false;

		public string sourceDescription => null;

		public string sourceInstallationId => _sourceDescription;

		public int dataVersion
		{
			get
			{
				//IL_0007: Expected I4, but got Obj
				return (int)_sourceInstallationId;
			}
		}

		public ICloudUserData userData
		{
			get
			{
				//IL_0007: Expected Obj, but got I4
				return (ICloudUserData)_dataVersion;
			}
		}

		public Stream GetDataStream()
		{
			return (Stream)(object)_cloudUserData;
		}

		public Item(RequestItem requestItem)
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			//IL_002d: Expected Obj, but got I
			object obj = requestItem.name + 16;
			Item item = (Item)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S1_v3+8]");
			_requestItem = (RequestItem)0;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<RequestItem, ICloudItem> _003C_003E9__38_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			WebClient._003C_003Ec obj = default;
			WebClient._003C_003Ec._003C_003E9 = obj;
		}

		internal unsafe ICloudItem _003CProcessCloudItemsResponse_003Eb__38_0(RequestItem responseItem)
		{
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Expected Obj, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected Obj, but got Unknown
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Expected Obj, but got Unknown
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected Obj, but got Unknown
			//IL_00db: Expected I, but got Obj
			//IL_00f1: Expected Obj, but got I
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Expected VT, but got Unknown
			//IL_0129: Expected I4, but got Obj
			//IL_0124: Expected native int or pointer, but got VT
			//IL_0139: Expected native int or pointer, but got VT
			//IL_0147: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Expected Obj, but got Unknown
			//IL_0176: Expected Ref, but got VT
			//IL_0013: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 32;
			obj = responseItem;
			_ = responseItem.name;
			_ = responseItem.lastModified;
			object obj3 = obj2 + 16;
			object obj4 = obj + 4;
			obj3 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v12+8]");
			_ = 0;
			object obj5 = this + 8;
			obj2 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v17+8]");
			_ = 0;
			nint num = (nint)typeof(Guid);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v18 (Il2CppClass<System.Guid>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(Guid);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v30 (Il2CppClass<System.Guid>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Guid guid = (Guid)(obj2 + 56);
			((Guid*)(nint)guid)->_a = (int)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v13+8]");
			((Guid*)(nint)guid)->_d = 0;
			string text = (string)(obj2 + 72);
			text = (string)obj2;
			string text2 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			text2.m_stringLength = 0;
			return (ICloudItem)(object)((Guid*)guid)->ToString(text);
		}
	}

	private sealed class _003C_003Ec__DisplayClass50_0
	{
		public bool authSuccess;

		public Error authError;

		internal void _003CCheckAuthenticationCoroutine_003Eb__0(bool success, Error error)
		{
			//IL_0015: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I
			//IL_0132: Expected Obj, but got I
			//IL_014f: Expected Obj, but got I4
			//IL_061e: Expected Obj, but got I
			//IL_0627: Unknown result type (might be due to invalid IL or missing references)
			//IL_062c: Expected Obj, but got Unknown
			//IL_01d7: Expected Obj, but got I
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Expected Obj, but got Unknown
			//IL_0671: Unknown result type (might be due to invalid IL or missing references)
			//IL_0676: Expected Obj, but got Unknown
			//IL_05b9: Expected Obj, but got I
			//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c7: Expected Obj, but got Unknown
			//IL_05da: Expected Obj, but got I4
			//IL_019b: Expected Obj, but got I
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Expected Obj, but got Unknown
			//IL_01bc: Expected Obj, but got I4
			//IL_0402: Expected Obj, but got I
			//IL_0297: Expected Obj, but got I
			//IL_04c8: Expected Obj, but got I
			//IL_02f1: Expected Obj, but got I
			//IL_048c: Expected Obj, but got I
			//IL_0495: Unknown result type (might be due to invalid IL or missing references)
			//IL_049a: Expected Obj, but got Unknown
			//IL_04ad: Expected Obj, but got I4
			//IL_0581: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Cloud.CloudServer2+<>c__DisplayClass50_0)+34]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Cloud.CloudServer2+<>c__DisplayClass50_0)+34]");
			object obj3;
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Cloud.CloudServer2+<>c__DisplayClass50_0)+34]");
				object obj2 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
				obj3 = 0;
				obj4 = obj2;
			}
			else
			{
				obj4 = this;
				obj3 = 1;
			}
			object obj5 = default;
			object obj25 = default;
			object obj17 = default;
			object obj23 = default;
			for (; obj5 != obj3; obj5 = obj25 + 1)
			{
				object obj6 = obj5 << 2;
				object obj7 = obj4 + obj6;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+14]");
				Error error2 = (Error)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (Kiloo.Common.Backend.Error)+28]");
				if ((nint)0 == -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (Kiloo.Common.Backend.Error)+2A]");
				bool flag = (nint)0 == 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (Kiloo.Common.Backend.Error)+24]");
				object obj10 = (nint)0 & (nint)0x10;
				bool flag2 = obj10 == null;
				object obj11 = (flag2 ? 1 : 0) ^ 1;
				Error error4;
				Error error3;
				if (obj11 != null)
				{
					if (flag)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
						object obj12 = (nint)0 & (nint)0x3FFF;
						error3 = (Error)(obj12 + 97173);
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v188 @ S3_v16 (Kiloo.Common.Backend.Error) (should have been resolved before IL gen)");
						error4 = (Error)97173;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
						object obj13 = (nint)0 & (nint)0x1FFF;
						error4 = (Error)(obj13 + 113696);
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v186 @ S4_v6 (Kiloo.Common.Backend.Error) (should have been resolved before IL gen)");
						error3 = error2;
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (Kiloo.Common.Backend.Error)+28]");
				bool flag3 = (nint)0 != -1;
				if (!flag)
				{
					if (flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+10]");
						bool flag4;
						if ((nint)0 != 0)
						{
							object obj14 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v94+9C]");
							object obj15 = (nint)0 & (nint)0x100;
							flag4 = obj15 != null;
						}
						else
						{
							flag4 = false;
						}
						if (!flag4 && authError != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (Kiloo.Common.Backend.Error)+2B]");
							object obj16 = (nint)0 & (nint)3;
							bool flag5 = (nint)obj16 == 2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
							if (flag5)
							{
								if (obj17 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A75");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A76");
								}
							}
							else if (obj17 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
								error3 = error;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
							}
							continue;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
					object obj18 = (nint)0 & (nint)0x3FFF;
					error3 = (Error)(obj18 + 97173);
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v188 @ S3_v16 (Kiloo.Common.Backend.Error) (should have been resolved before IL gen)");
					error4 = (Error)97173;
					continue;
				}
				if (flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+10]");
					bool flag6;
					if ((nint)0 != 0)
					{
						object obj19 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v66+9C]");
						object obj20 = (nint)0 & (nint)0x100;
						flag6 = obj20 != null;
					}
					else
					{
						flag6 = false;
					}
					if (!flag6 && authError != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+10]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
							object obj21 = (nint)0 & (nint)0x3FFF;
							error3 = (Error)(obj21 + 97173);
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v188 @ S3_v16 (Kiloo.Common.Backend.Error) (should have been resolved before IL gen)");
							error4 = (Error)97173;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (Kiloo.Common.Backend.Error)+2B]");
						object obj22 = (nint)0 & (nint)3;
						bool flag7 = (nint)obj22 == 2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
						if (flag7)
						{
							if (obj23 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A77");
								error3 = error;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A78");
								error3 = error;
							}
						}
						else if (obj23 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
							error4 = error;
							error3 = (Error)success;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
							error3 = error;
						}
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
				object obj24 = (nint)0 & (nint)0x1FFF;
				error4 = (Error)(obj24 + 113696);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v186 @ S4_v6 (Kiloo.Common.Backend.Error) (should have been resolved before IL gen)");
				error3 = error2;
			}
		}
	}

	private sealed class _003CCheckAuthenticationCoroutine_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CloudServer2 _003C_003E4__this;

		public Action<bool> completeHandler;

		public string expectedKilooTag;

		private _003C_003Ec__DisplayClass50_0 _003C_003E8__1;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_0074: Unknown result type (might be due to invalid IL or missing references)
				//IL_0079: Expected Obj, but got Unknown
				//IL_0082: Expected Obj, but got I4
				//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ad: Expected Obj, but got Unknown
				//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c2: Expected Obj, but got Unknown
				//IL_00e8: Expected Obj, but got I4
				//IL_013f: Expected Obj, but got I4
				//IL_0152: Expected I4, but got Obj
				CloudServer2 cloudServer = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						_003C_003Ec__DisplayClass50_0 obj = _003C_003E8__1;
						bool authSuccess = obj.authSuccess;
						_003C_003Ec__DisplayClass50_0 obj2 = _003C_003E8__1;
						IEnumerator enumerator = cloudServer.UpdateItemsCoroutine(expectedKilooTag, (IEnumerable<ICloudItem>)authSuccess, (CloudServerRequestCompleteHandler)(object)obj2.authError);
						completeHandler((byte)(int)enumerator != 0);
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj3 = this + 28;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj4 = default;
				obj3 = obj4;
				_003C_003Ec__DisplayClass50_0 obj5 = _003C_003E8__1;
				obj5.authSuccess = false;
				object obj6 = _003C_003E8__1 + 12;
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num = 0;
				_ = 0;
				object obj8 = default;
				object obj7 = obj8 + 16;
				obj7 = _003C_003E8__1;
				object obj9 = this + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				object obj10 = default;
				obj9 = obj10;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public unsafe _003CCheckAuthenticationCoroutine_003Ed__50(int _003C_003E1__state)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0403: Expected Ref, but got Unknown
			//IL_0415: Unknown result type (might be due to invalid IL or missing references)
			//IL_041a: Expected Obj, but got Unknown
			//IL_0423: Expected Obj, but got I4
			//IL_0438: Unknown result type (might be due to invalid IL or missing references)
			//IL_043d: Expected Obj, but got Unknown
			//IL_0446: Expected Obj, but got I4
			//IL_044f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0454: Expected Obj, but got Unknown
			//IL_0468: Unknown result type (might be due to invalid IL or missing references)
			//IL_046d: Expected Obj, but got Unknown
			//IL_0475: Expected Obj, but got I4
			//IL_0483: Expected Obj, but got I4
			//IL_04a6: Expected I, but got Obj
			//IL_04bc: Expected Obj, but got I
			//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b5: Expected Obj, but got Unknown
			//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05dd: Expected Obj, but got Unknown
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Expected Obj, but got Unknown
			//IL_0021: Expected I, but got Obj
			//IL_00bc: Expected Obj, but got I
			//IL_04f3: Expected Obj, but got I
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Expected Ref, but got Unknown
			//IL_0143: Expected Obj, but got I
			//IL_014d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Expected Ref, but got Unknown
			//IL_016c: Expected Obj, but got I
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Expected Obj, but got Unknown
			//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bf: Expected Obj, but got Unknown
			//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cd: Expected Obj, but got Unknown
			//IL_02f9: Expected Obj, but got I4
			//IL_0360: Expected Obj, but got I
			//IL_039e: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a3: Expected Obj, but got Unknown
			//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d9: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 96;
			ref string reference = ref *(string*)(obj2 + 80);
			reference = ref *(string*)null;
			object obj3 = obj2 + 56;
			obj3 = 0;
			_ = 0;
			_ = 0;
			object obj4 = obj2 + 16;
			obj4 = 0;
			object obj5 = obj2 + 48;
			obj5 = obj;
			_ = -1;
			object obj6 = this + 8;
			obj6 = _003C_003E1__state;
			object obj7 = _003C_003E1__state + 16;
			obj2 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v18+8]");
			_ = 0;
			nint num = (nint)typeof(CloudServer2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v27 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudServer2>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num2 = (nint)typeof(CloudServer2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v167 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudServer2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = (string)(obj2 + 24);
			text = (string)obj2;
			string text2 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			text2.m_stringLength = 0;
			object obj9 = this + 16;
			string text3 = EscapeName(text);
			obj9 = text3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CloudWorkingCopy cloudWorkingCopy = default;
			cloudWorkingCopy.Clear();
			object obj10 = this + 12;
			obj10 = cloudWorkingCopy;
			int num3 = this._003C_003E1__state;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v42 (System.Int32)+28]");
			if ((nint)0 == 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v42 (System.Int32)+28]");
			if (((Dictionary<string, string>)0).TryGetValue("zipped", out reference))
			{
				bool flag = string.Equals("true", reference, StringComparison.OrdinalIgnoreCase);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v42 (System.Int32)+28]");
			if (((Dictionary<string, string>)0).TryGetValue("version", out reference))
			{
				IFormatProvider provider = (IFormatProvider)(this + 28);
				bool flag2 = ((int*)reference)->System_002EIConvertible_002EToBoolean(provider);
			}
			ref string value = ref *(string*)(this + 20);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v42 (System.Int32)+28]");
			bool flag3 = ((Dictionary<string, string>)0).TryGetValue("source", out value);
			ref string value2 = ref *(string*)(this + 24);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v42 (System.Int32)+28]");
			bool flag4 = ((Dictionary<string, string>)0).TryGetValue("installation", out value2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
			obj3 = text;
			_ = text.m_stringLength;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32 (System.String)+10]");
			_ = 0;
			object obj11 = default;
			object obj12 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj11 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj4 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj12 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
				}
			}
			object obj13 = obj5 + 4;
			object obj14 = obj13 + 1;
			obj13 = obj14;
			object obj15 = obj14 << 2;
			object obj16 = obj5 + obj15;
			obj16 = 248;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
				object obj17 = (nint)0 << 2;
				object obj18 = obj5 + obj17;
				if ((nint)obj18 == 248)
				{
					object obj19 = obj5 + 4;
					if ((nint)obj19 > -1)
					{
						object obj20 = obj19 + -1;
						obj19 = obj20;
					}
					return;
				}
			}
			object obj21 = default;
			if (obj21 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0033: Expected VT, but got I4
			//IL_0033: Expected Obj, but got I
			//IL_00dd: Expected I4, but got Obj
			//IL_0079: Expected Obj, but got I4
			//IL_0079: Expected I4, but got Obj
			int num = _003C_003E1__state;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Int32)+2C]");
			if ((nint)0 != 0)
			{
				int num2 = _003C_003E1__state;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v12 (System.Int32)+2C]");
				PathTooLongException ex = default;
				ex._002Ector((SerializationInfo)0, (StreamingContext)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Cloud.CloudServer2+<CheckAuthenticationCoroutine>d__50)+20]");
				PathTooLongException ex2;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					short[] array = default;
					Tree.gen_codes(array, (int)ex, (short[])1);
					ex2 = (PathTooLongException)(object)array;
				}
				else
				{
					ex2 = ex;
				}
				return (byte)(int)ex2 != 0;
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

	private sealed class _003C_003Ec__DisplayClass52_0
	{
		public bool authenticationOk;

		public _003C_003Ec__DisplayClass52_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CListItemsCoroutine_003Eb__0(bool authOk)
		{
			authenticationOk = authOk;
		}
	}

	private sealed class _003CListItemsCoroutine_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CloudServer2 _003C_003E4__this;

		public string forKilooTag;

		private _003C_003Ec__DisplayClass52_0 _003C_003E8__1;

		public CloudServerRequestCompleteHandler completeHandler;

		private IRequest _003Crequest_003E5__2;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0220: Unknown result type (might be due to invalid IL or missing references)
				//IL_0225: Expected VT, but got Unknown
				//IL_022e: Expected Obj, but got I4
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Expected Obj, but got Unknown
				//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b3: Expected Obj, but got Unknown
				//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c8: Expected Obj, but got Unknown
				//IL_00fd: Expected Obj, but got I4
				//IL_0139: Unknown result type (might be due to invalid IL or missing references)
				//IL_013e: Expected Obj, but got Unknown
				//IL_0149: Expected VT, but got Obj
				//IL_0283: Unknown result type (might be due to invalid IL or missing references)
				//IL_0288: Expected Obj, but got Unknown
				//IL_0291: Expected Obj, but got I4
				//IL_0171: Expected I4, but got Obj
				//IL_016c: Expected native int or pointer, but got VT
				//IL_0186: Expected Obj, but got I
				//IL_0181: Expected native int or pointer, but got VT
				//IL_018c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0191: Expected Obj, but got Unknown
				//IL_01ca: Expected Obj, but got I4
				object obj = default;
				WebClient.SendOptions sendOptions = (WebClient.SendOptions)(obj + 16);
				obj = 0;
				_ = 0;
				CloudServer2 cloudServer = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					string result;
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							return null;
						}
						_003C_003E1__state = -1;
						string text = _003C_003E4__this.BuildRefItemsQueryParameter((IEnumerable<ICloudItem>)_003Crequest_003E5__2);
						object obj2 = this + 32;
						obj2 = 0;
						result = text;
					}
					else
					{
						_003C_003E1__state = -1;
						_003C_003Ec__DisplayClass52_0 obj3 = _003C_003E8__1;
						if (~(obj3.authenticationOk ? 1u : 0u) == 0)
						{
							object obj4 = this + 32;
							string text2 = ToRevision((DateTime?)(object)_003C_003E4__this);
							obj4 = text2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
							((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj != 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
							System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions)->simulatedRequestResults, (IList<SimulatedRequestResult>)0);
							object obj5 = this + 12;
							IEnumerator enumerator = KilooAuthRequestExtensions.SendAuthenticatedAsyncCoroutine(_003Crequest_003E5__2, cloudServer.kilooAuth__BackingField, (WebClient.RequestCompleteHandler)null, sendOptions);
							obj5 = enumerator;
							_003C_003E1__state = 2;
							return 1;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						string text3 = default;
						text3.m_stringLength = 2;
						result = text3;
					}
					completeHandler.EndInvoke((IAsyncResult)(object)result);
					return null;
				}
				_003C_003E1__state = -1;
				object obj6 = this + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj7 = default;
				obj6 = obj7;
				_003C_003Ec__DisplayClass52_0 obj8 = _003C_003E8__1;
				obj8.authenticationOk = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num = 0;
				_ = 0;
				Action<bool> action = default;
				object obj9 = action + 16;
				obj9 = _003C_003E8__1;
				object obj10 = this + 12;
				IEnumerator enumerator2 = _003C_003E4__this.CheckAuthenticationCoroutine(forKilooTag, action);
				obj10 = enumerator2;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CListItemsCoroutine_003Ed__52(int _003C_003E1__state)
		{
			int num = _003C_003E1__state & 1;
			this._003C_003E1__state = num;
		}

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

	private sealed class _003C_003Ec__DisplayClass53_0
	{
		public bool authenticationOk;

		public _003C_003Ec__DisplayClass53_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CUpdateItemsCoroutine_003Eb__0(bool authOk)
		{
			authenticationOk = authOk;
		}
	}

	private sealed class _003CUpdateItemsCoroutine_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CloudServer2 _003C_003E4__this;

		public string forKilooTag;

		private _003C_003Ec__DisplayClass53_0 _003C_003E8__1;

		public IEnumerable<ICloudItem> items;

		public CloudServerRequestCompleteHandler completeHandler;

		private IRequest _003Crequest_003E5__2;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0226: Unknown result type (might be due to invalid IL or missing references)
				//IL_022b: Expected VT, but got Unknown
				//IL_0234: Expected Obj, but got I4
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Expected Obj, but got Unknown
				//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b3: Expected Obj, but got Unknown
				//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c8: Expected Obj, but got Unknown
				//IL_00fd: Expected Obj, but got I4
				//IL_0139: Unknown result type (might be due to invalid IL or missing references)
				//IL_013e: Expected Obj, but got Unknown
				//IL_015b: Expected Obj, but got I4
				//IL_0289: Unknown result type (might be due to invalid IL or missing references)
				//IL_028e: Expected Obj, but got Unknown
				//IL_0297: Expected Obj, but got I4
				//IL_0177: Expected I4, but got Obj
				//IL_0172: Expected native int or pointer, but got VT
				//IL_018c: Expected Obj, but got I
				//IL_0187: Expected native int or pointer, but got VT
				//IL_0192: Unknown result type (might be due to invalid IL or missing references)
				//IL_0197: Expected Obj, but got Unknown
				//IL_01d0: Expected Obj, but got I4
				object obj = default;
				WebClient.SendOptions sendOptions = (WebClient.SendOptions)(obj + 16);
				obj = 0;
				_ = 0;
				CloudServer2 cloudServer = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					string result;
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							return null;
						}
						_003C_003E1__state = -1;
						string text = _003C_003E4__this.BuildRefItemsQueryParameter((IEnumerable<ICloudItem>)_003Crequest_003E5__2);
						object obj2 = this + 36;
						obj2 = 0;
						result = text;
					}
					else
					{
						_003C_003E1__state = -1;
						_003C_003Ec__DisplayClass53_0 obj3 = _003C_003E8__1;
						if (~(obj3.authenticationOk ? 1u : 0u) == 0)
						{
							object obj4 = this + 36;
							bool flag = _003C_003E4__this.CheckAuthentication((string)(object)items);
							obj4 = flag;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
							((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj != 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
							System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions)->simulatedRequestResults, (IList<SimulatedRequestResult>)0);
							object obj5 = this + 12;
							IEnumerator enumerator = KilooAuthRequestExtensions.SendAuthenticatedAsyncCoroutine(_003Crequest_003E5__2, cloudServer.kilooAuth__BackingField, (WebClient.RequestCompleteHandler)null, sendOptions);
							obj5 = enumerator;
							_003C_003E1__state = 2;
							return 1;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						string text2 = default;
						text2.m_stringLength = 2;
						result = text2;
					}
					completeHandler.EndInvoke((IAsyncResult)(object)result);
					return null;
				}
				_003C_003E1__state = -1;
				object obj6 = this + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj7 = default;
				obj6 = obj7;
				_003C_003Ec__DisplayClass53_0 obj8 = _003C_003E8__1;
				obj8.authenticationOk = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num = 0;
				_ = 0;
				Action<bool> action = default;
				object obj9 = action + 16;
				obj9 = _003C_003E8__1;
				object obj10 = this + 12;
				IEnumerator enumerator2 = _003C_003E4__this.CheckAuthenticationCoroutine(forKilooTag, action);
				obj10 = enumerator2;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CUpdateItemsCoroutine_003Ed__53(int _003C_003E1__state)
		{
			int num = _003C_003E1__state & 1;
			this._003C_003E1__state = num;
		}

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

	private sealed class _003C_003Ec__DisplayClass54_0
	{
		public bool authenticationOk;

		public _003C_003Ec__DisplayClass54_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CCommitItemsCoroutine_003Eb__0(bool authOk)
		{
			authenticationOk = authOk;
		}
	}

	private sealed class _003CCommitItemsCoroutine_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CloudServer2 _003C_003E4__this;

		public string forKilooTag;

		private _003C_003Ec__DisplayClass54_0 _003C_003E8__1;

		public IEnumerable<ICloudItem> items;

		public CloudServerCommitCompleteHandler completeHandler;

		private IDictionary<string, CloudServerCommitInfo> _003CcommitInfo_003E5__2;

		private IRequest _003Crequest_003E5__3;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_022d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0232: Expected VT, but got Unknown
				//IL_023b: Expected Obj, but got I4
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Expected Obj, but got Unknown
				//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b3: Expected Obj, but got Unknown
				//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c8: Expected Obj, but got Unknown
				//IL_00fd: Expected Obj, but got I4
				//IL_0139: Unknown result type (might be due to invalid IL or missing references)
				//IL_013e: Expected Obj, but got Unknown
				//IL_0144: Unknown result type (might be due to invalid IL or missing references)
				//IL_0149: Expected I4, but got Unknown
				//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ac: Expected Obj, but got Unknown
				//IL_02b9: Expected Obj, but got I4
				//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c7: Expected Obj, but got Unknown
				//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
				//IL_02dc: Expected Obj, but got Unknown
				//IL_02e5: Expected Obj, but got I4
				//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f0: Expected Obj, but got Unknown
				//IL_02f9: Expected Obj, but got I4
				//IL_0186: Expected I4, but got Obj
				//IL_0181: Expected native int or pointer, but got VT
				//IL_019b: Expected Obj, but got I
				//IL_0196: Expected native int or pointer, but got VT
				//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a6: Expected Obj, but got Unknown
				//IL_01df: Expected Obj, but got I4
				object obj = default;
				WebClient.SendOptions sendOptions = (WebClient.SendOptions)(obj + 16);
				obj = 0;
				_ = 0;
				CloudServer2 cloudServer = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					IAsyncResult result;
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							return null;
						}
						_003C_003E1__state = -1;
						string text = _003C_003E4__this.BuildRefItemsQueryParameter((IEnumerable<ICloudItem>)_003Crequest_003E5__3);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						_ = text.m_stringLength;
						IAsyncResult asyncResult = default;
						object obj2 = asyncResult + 12;
						obj2 = text.m_firstChar;
						object obj3 = asyncResult + 16;
						obj3 = _003CcommitInfo_003E5__2;
						object obj4 = this + 36;
						obj4 = 0;
						object obj5 = this + 40;
						obj5 = 0;
						result = asyncResult;
					}
					else
					{
						_003C_003E1__state = -1;
						_003C_003Ec__DisplayClass54_0 obj6 = _003C_003E8__1;
						if (~(obj6.authenticationOk ? 1u : 0u) == 0)
						{
							object obj7 = this + 40;
							bool zipped = (byte)(this + 36) != 0;
							Dictionary<string, string> dictionary = _003C_003E4__this.MakeMetadataDictionary((ICloudItem)items, zipped);
							obj7 = dictionary;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
							((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj != 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
							System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions)->simulatedRequestResults, (IList<SimulatedRequestResult>)0);
							object obj8 = this + 12;
							IEnumerator enumerator = KilooAuthRequestExtensions.SendAuthenticatedAsyncCoroutine(_003Crequest_003E5__3, cloudServer.kilooAuth__BackingField, (WebClient.RequestCompleteHandler)null, sendOptions);
							obj8 = enumerator;
							_003C_003E1__state = 2;
							return 1;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						_ = 2;
						IAsyncResult asyncResult2 = default;
						result = asyncResult2;
					}
					completeHandler.EndInvoke(result);
					return null;
				}
				_003C_003E1__state = -1;
				object obj9 = this + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj10 = default;
				obj9 = obj10;
				_003C_003Ec__DisplayClass54_0 obj11 = _003C_003E8__1;
				obj11.authenticationOk = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num = 0;
				_ = 0;
				Action<bool> action = default;
				object obj12 = action + 16;
				obj12 = _003C_003E8__1;
				object obj13 = this + 12;
				IEnumerator enumerator2 = _003C_003E4__this.CheckAuthenticationCoroutine(forKilooTag, action);
				obj13 = enumerator2;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CCommitItemsCoroutine_003Ed__54(int _003C_003E1__state)
		{
			int num = _003C_003E1__state & 1;
			this._003C_003E1__state = num;
		}

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

	private Uri baseUri__BackingField;

	private IKilooAuth kilooAuth__BackingField;

	private IBsonSerializer bsonSerializer__BackingField;

	private float timeout__BackingField;

	private int minimumSizeForCompression__BackingField;

	private CompressionLevel compressionLevel__BackingField;

	private const string API_ROUTE = "api/v2/cloudsave";

	private static readonly DateTime _epoch;

	public Uri baseUri
	{
		get
		{
			return (Uri)kilooAuth__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 12;
			obj = value;
		}
	}

	public IKilooAuth kilooAuth
	{
		get
		{
			return (IKilooAuth)baseUri__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = value;
		}
	}

	public IBsonSerializer bsonSerializer
	{
		get
		{
			return (IBsonSerializer)kilooAuth__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 12;
			obj = value;
		}
	}

	public float timeout
	{
		get
		{
			//IL_0007: Expected F4, but got Obj
			return (float)bsonSerializer__BackingField;
		}
		set
		{
			//IL_000a: Expected Obj, but got F4
			bsonSerializer__BackingField = (IBsonSerializer)value;
		}
	}

	public int minimumSizeForCompression
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)bsonSerializer__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 16;
			obj = value;
		}
	}

	public CompressionLevel compressionLevel
	{
		get
		{
			return (CompressionLevel)minimumSizeForCompression__BackingField;
		}
		set
		{
			minimumSizeForCompression__BackingField = (int)value;
		}
	}

	public string kilooTag
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (string)compressionLevel__BackingField;
		}
	}

	public unsafe CloudServer2(Uri baseUri, IKilooAuth kilooAuth, IBsonSerializer bsonSerializer)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected VT, but got Unknown
		//IL_0057: Expected native int or pointer, but got VT
		//IL_006c: Expected native int or pointer, but got VT
		object obj = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		obj = baseUri;
		object obj2 = obj + 4;
		obj2 = kilooAuth;
		Kiloo.Common.Diagnostics.Console.Log log = (Kiloo.Common.Diagnostics.Console.Log)(obj + 12);
		System.Runtime.CompilerServices.Unsafe.Write(&((Kiloo.Common.Diagnostics.Console.Log*)(nint)log)->message, obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Kiloo.Common.Diagnostics.Console.Log*)(nint)log)->type = LogType.Error;
		((List<Kiloo.Common.Diagnostics.Console.Log>)this.bsonSerializer__BackingField).Add(log);
	}

	public Coroutine ListItemsAsync(string forKilooTag, CloudServerRequestCompleteHandler completeHandler)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_009d: Expected Obj, but got I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = forKilooTag;
		object obj3 = obj2 + 12;
		obj3 = completeHandler;
		int num = Util.ConvertTimeoutToMilliseconds(0.5f);
		object obj4 = num;
		object obj5 = obj4;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		object obj7 = default;
		object obj6 = obj7 + 16;
		obj6 = obj2;
		object obj8 = obj4 + 24;
		obj8 = obj7;
		return (Coroutine)(object)((Wait.Config)obj4).WaitCoroutine();
	}

	public CloudServerResult ListItems(string forKilooTag)
	{
		//IL_0207: Expected I, but got Obj
		//IL_021d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00c0: Expected I, but got Obj
		//IL_00d6: Expected Obj, but got I
		//IL_01ea: Expected Obj, but got VT
		//IL_01a6: Expected I, but got Obj
		//IL_0135: Expected I, but got Obj
		IRequest request = HTTPFactory.CreateRequest((string)(object)this, forKilooTag);
		nint num = (nint)typeof(KilooWebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v4 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v24 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4FD");
		float keepAlive = default;
		IRequest request2 = RequestExtensions.WithKeepAlive(request, keepAlive);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4FF");
		float minBackOffTime = default;
		IRequest request3 = RequestExtensions.WithMinBackOffTime(request2, minBackOffTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A501");
		float maxBackOffTime = default;
		IRequest request4 = RequestExtensions.WithMaxBackOffTime(request3, maxBackOffTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A503");
		float time = default;
		Wait.Config.TimeConfig timeConfig = ((Wait.Config)request4).For(time);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		nint num3 = (nint)typeof(KilooWebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v14 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 == null;
		if (KilooWebClient._clientInfoHeaders != null)
		{
			if (!flag)
			{
				nint num4 = (nint)typeof(KilooWebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v38 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Headers headers2 = default;
			Headers headers = headers2.SetAll((Dictionary<string, List<string>>)(object)KilooWebClient._clientInfoHeaders);
		}
		else
		{
			if (!flag)
			{
				nint num5 = (nint)typeof(KilooWebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v29 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			KilooWebClient.Log("KilooWebClient not initialized");
		}
		return (CloudServerResult)timeConfig;
	}

	public unsafe Coroutine UpdateItemsAsync(string forKilooTag, IEnumerable<ICloudItem> items, CloudServerRequestCompleteHandler completeHandler)
	{
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected I4, but got Unknown
		//IL_0055: Expected I4, but got Obj
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		object obj = default;
		int num = obj + 4;
		((int*)num)->m_value = 0;
		byte[] array = Util.UnZip((byte[])(object)forKilooTag);
		string result;
		if (array == null)
		{
			string text = MiscExtensions.UnifyNewlines((string)(object)this, (string)256);
			if (text == null)
			{
				string text2 = Util.PrintableContent((byte[])(object)this, null, 32, (int)completeHandler);
				result = text2;
				goto IL_0197;
			}
		}
		string text3 = Util.ContentAsHex((byte[])(object)this, (Headers)(object)forKilooTag, (int)items, num);
		bool flag = text3.m_stringLength > ((int*)num)->m_value;
		bool flag2 = !flag;
		result = text3;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			throw new ArrayTypeMismatchException();
		}
		goto IL_0197;
		IL_0197:
		return (Coroutine)(object)result;
	}

	public CloudServerResult UpdateItems(string forKilooTag, IEnumerable<ICloudItem> items)
	{
		Coroutine list = ((CloudWorkingCopy)this).UpdateAsync((CloudConflictResolver)(object)forKilooTag, (CloudWorkingCopy.CompleteHandler)(object)items);
		return (CloudServerResult)(object)CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	public Coroutine CommitItemsAsync(string forKilooTag, IEnumerable<ICloudItem> items, CloudServerCommitCompleteHandler completeHandler)
	{
		IEnumerator list = CommitItemsCoroutine(forKilooTag, items, completeHandler);
		return CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	public CloudServerCommitResult CommitItems(string forKilooTag, IEnumerable<ICloudItem> items)
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_00ae: Expected Obj, but got I4
		//IL_0052: Expected I4, but got Obj
		//IL_0052: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		object obj = default;
		string text = (string)(obj + 16);
		obj = 0;
		_ = 0;
		string text2 = ((CloudUserData)this).get_Item(forKilooTag);
		if (text2 != null)
		{
			bool flag = CheckAuthentication((string)(object)items);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			text = (string)obj;
			string text3 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			text3.m_stringLength = 0;
			((AbstractAdProvider)flag).TimeoutCaching((AdType)kilooAuth__BackingField, text);
			return (CloudServerCommitResult)(object)BuildRefItemsQueryParameter((IEnumerable<ICloudItem>)flag);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CloudServerCommitResult cloudServerCommitResult = default;
		cloudServerCommitResult.status = CloudSaveStatus.Error;
		return cloudServerCommitResult;
	}

	private CloudServerResult ProcessCloudItemsResponse(IRequest request)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00aa: Expected Obj, but got I4
		//IL_000b: Expected VT, but got Obj
		//IL_004e: Expected I4, but got Obj
		object obj = default;
		string text = (string)(obj + 16);
		obj = 0;
		_ = 0;
		string text2 = ((CloudUserData)this).get_Item((string)(object)request);
		if (text2 != null)
		{
			string text3 = ToRevision((DateTime?)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			text = (string)obj;
			string text4 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			text4.m_stringLength = 0;
			((AbstractAdProvider)(object)text3).TimeoutCaching((AdType)kilooAuth__BackingField, text);
			return (CloudServerResult)(object)BuildRefItemsQueryParameter((IEnumerable<ICloudItem>)(object)text3);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CloudServerResult cloudServerResult = default;
		cloudServerResult.status = CloudSaveStatus.Error;
		return cloudServerResult;
	}

	private IRequest PrepareListItemsRequest()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		IRequest result = default;
		return result;
	}

	private static string ToRevision(DateTime? value)
	{
		//IL_0094: Expected Obj, but got I
		//IL_00a2: Expected I, but got Obj
		//IL_00b8: Expected Obj, but got I
		//IL_00f5: Expected VT, but got Obj
		//IL_0067: Expected F4, but got I
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (System.Nullable`1<System.DateTime>)+8]");
		Uri uri = default;
		uri._002Ector((Uri)0, (Uri)(object)"api/v2/cloudsave");
		nint num = (nint)typeof(KilooWebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v20 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IRequest request = KilooWebClient.CreatePut(uri);
		Coroutine request2 = RequestExtensions.ThenMakeTheRequestAsync(request, (WebClient.RequestCompleteHandler)(object)"metaOnly", (WebClient.SendOptions)"true");
		IRequest request3 = RequestExtensions.WithQueryParameter((IRequest)(object)request2, "Accept", "application/bson");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (System.Nullable`1<System.DateTime>)+14]");
		return (string)(object)RequestExtensions.WithKeepAlive(request3, 0f);
	}

	private static DateTime? FromRevision(string value)
	{
		DateTime? result = default;
		return result;
	}

	private unsafe static string EscapeName(string name)
	{
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected Obj, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected VT, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_0233: Expected Obj, but got I4
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected Obj, but got Unknown
		//IL_024a: Expected Obj, but got I4
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected Obj, but got Unknown
		//IL_0261: Expected Obj, but got I4
		//IL_001a: Expected Obj, but got VT
		//IL_0037: Expected I, but got Obj
		//IL_004d: Expected Obj, but got I
		//IL_0291: Expected I, but got Obj
		//IL_02a7: Expected Obj, but got I
		//IL_031b: Expected Obj, but got VT
		//IL_0328: Expected I8, but got Obj
		//IL_0323: Expected native int or pointer, but got VT
		//IL_033d: Expected Ref, but got VT
		//IL_0349: Expected Obj, but got I8
		//IL_0078: Expected I, but got Obj
		//IL_00c5: Expected I, but got Obj
		//IL_0161: Expected F8, but got I8
		//IL_02f6: Expected Obj, but got F8
		//IL_01a2: Expected F8, but got I8
		//IL_01e3: Expected F8, but got I8
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
		if (name.m_stringLength != 0)
		{
			DateTime value = ((DateTime?*)name)->Value;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCDB");
			nint num = (nint)typeof(CloudServer2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v30 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudServer2>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(CloudServer2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v54 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudServer2>)+74]");
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
			string result = default;
			return result;
		}
		return null;
	}

	private string BuildRefItemsQueryParameter(IEnumerable<ICloudItem> refItems)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_05c9: Expected I, but got Obj
		//IL_05df: Expected Obj, but got I
		//IL_051a: Expected I, but got Obj
		//IL_0530: Expected Obj, but got I
		//IL_060a: Expected I, but got Obj
		//IL_055b: Expected I, but got Obj
		//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c8: Expected Obj, but got Unknown
		//IL_009e: Expected I, but got Obj
		//IL_00b4: Expected Obj, but got I
		//IL_015b: Expected I, but got Obj
		//IL_0171: Expected Obj, but got I
		//IL_00df: Expected I, but got Obj
		//IL_019c: Expected I, but got Obj
		//IL_0248: Expected I, but got Obj
		//IL_025e: Expected Obj, but got I
		//IL_0289: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		IResponse response = default;
		CloudSaveStatus stringLength;
		if (response != null && ResponseExtensions.IsTexture(response))
		{
			ServiceResponse<ResponseObject> serviceResponse = ResponseExtensions.ParseBson<ServiceResponse<ResponseObject>>(response, bsonSerializer__BackingField);
			if (serviceResponse.result == null)
			{
				string text = "ProcessResponse: request failed: " + (string)(object)serviceResponse.error;
				nint num = (nint)typeof(CloudServer2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v87 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudServer2>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num2 = (nint)typeof(CloudServer2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S1_v92 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudServer2>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((CloudUserData)(object)text)._002Ector();
				stringLength = CloudSaveStatus.Error;
			}
			else
			{
				ResponseObject result = serviceResponse.result;
				if (result.items != null)
				{
					nint num3 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v60 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudServer2+<>c>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num4 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v177 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudServer2+<>c>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					bool flag = _003C_003Ec._003C_003E9__38_0 == null;
					bool flag2 = !flag;
					object obj5 = _003C_003Ec._003C_003E9__38_0;
					object obj7;
					object obj9;
					object obj10 = default;
					if (!flag2)
					{
						nint num5 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S0_v133 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudServer2+<>c>)+BA]");
						object obj6 = (nint)0 & (nint)0x200;
						if (obj6 != null)
						{
							nint num6 = (nint)typeof(_003C_003Ec);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S0_v165 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudServer2+<>c>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj8 = default;
						obj7 = obj8;
						obj9 = obj10;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj11 = default;
						obj7 = obj11;
						obj9 = obj10;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
					object obj12 = default;
					if (obj9 == obj12)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
						object obj13 = default;
						string text2 = (string)obj13;
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
				}
				ResponseObject result2 = serviceResponse.result;
				stringLength = result2.status;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj16 = default;
			if (obj16 != null)
			{
				nint num7 = (nint)typeof(CloudServer2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v35 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudServer2>)+BA]");
				object obj17 = (nint)0 & (nint)0x200;
				if (obj17 != null)
				{
					nint num8 = (nint)typeof(CloudServer2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v41 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudServer2>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((CloudUserData)(object)"ProcessResponse: request response had unexpected content type.")._002Ector();
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				int totalLength = default;
				string text3 = string.ConcatArray((string[])(object)"ProcessResponse: request failed: ", totalLength);
				nint num9 = (nint)typeof(CloudServer2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v20 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudServer2>)+BA]");
				object obj18 = (nint)0 & (nint)0x200;
				if (obj18 != null)
				{
					nint num10 = (nint)typeof(CloudServer2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S1_v25 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudServer2>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((CloudUserData)(object)text3)._002Ector();
			}
			stringLength = CloudSaveStatus.Error;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text4 = default;
		text4.m_stringLength = (int)stringLength;
		object obj19 = text4 + 12;
		object obj20 = default;
		obj19 = obj20;
		return text4;
	}

	private IRequest PrepareUpdateItemsRequest(IEnumerable<ICloudItem> refItems)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_08a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a9: Expected Obj, but got Unknown
		//IL_08b2: Expected Obj, but got I4
		//IL_08c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c6: Expected Obj, but got Unknown
		//IL_0079: Expected Obj, but got I4
		//IL_00c6: Expected I, but got Obj
		//IL_00dc: Expected Obj, but got I
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected Obj, but got Unknown
		//IL_0107: Expected I, but got Obj
		//IL_01c8: Expected Obj, but got I4
		//IL_022c: Expected I, but got Obj
		//IL_0242: Expected Obj, but got I
		//IL_09a6: Expected Obj, but got I4
		//IL_07ce: Expected Obj, but got I
		//IL_026d: Expected I, but got Obj
		//IL_0804: Unknown result type (might be due to invalid IL or missing references)
		//IL_0809: Expected Obj, but got Unknown
		//IL_083a: Unknown result type (might be due to invalid IL or missing references)
		//IL_083f: Expected Obj, but got Unknown
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Expected Obj, but got Unknown
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Expected Obj, but got Unknown
		//IL_0733: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 16;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 32;
		obj4 = obj;
		_ = -1;
		StringBuilder stringBuilder = default;
		if (refItems != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			System.Text.StringBuilderCache.Release(stringBuilder);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj5 = default;
			object obj7 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj5 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				nint num = (nint)typeof(CloudServer2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S0_v112 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudServer2>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num2 = (nint)typeof(CloudServer2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S0_v183 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudServer2>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj7 == null)
				{
					continue;
				}
				object obj8 = stringBuilder.m_ChunkLength + stringBuilder.m_ChunkOffset;
				if ((nint)obj8 >= 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				nint num3 = (nint)typeof(CloudServer2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ S0_v141 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudServer2>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num4 = (nint)typeof(CloudServer2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ S0_v167 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudServer2>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
			}
			object obj10 = 35;
			object obj11 = obj10 - 10;
			object obj18;
			object obj19 = default;
			if ((nint)obj10 != 10)
			{
				if ((nint)obj11 != 1)
				{
					if ((nint)obj11 == 2 || (nint)obj11 == 3 || (nint)obj11 == 4)
					{
						goto IL_0972;
					}
					if ((nint)obj11 != 5 && (nint)obj11 != 6)
					{
						if ((nint)obj11 == 7 || (nint)obj11 == 8 || (nint)obj11 == 9 || (nint)obj11 == 10 || (nint)obj11 == 11 || (nint)obj11 == 12 || (nint)obj11 == 13)
						{
							goto IL_0972;
						}
						if ((nint)obj11 != 14)
						{
							if ((nint)obj11 != 15)
							{
								if ((nint)obj11 == 16 || (nint)obj11 == 17 || (nint)obj11 == 18 || (nint)obj11 == 19 || (nint)obj11 == 20 || (nint)obj11 == 21)
								{
									goto IL_0972;
								}
								if ((nint)obj11 != 22)
								{
									if ((nint)obj11 != 23)
									{
										if ((nint)obj11 != 24)
										{
											if ((nint)obj11 == 25)
											{
												object obj12 = obj4 + 4;
												object obj13 = obj12 + 1;
												obj12 = obj13;
												object obj14 = obj13 << 2;
												object obj15 = obj4 + obj14;
												obj15 = 113;
											}
											goto IL_0972;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj17 = default;
										object obj16 = obj17;
										obj18 = obj19;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj20 = default;
										object obj16 = obj20;
										obj18 = obj19;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj21 = default;
									object obj16 = obj21;
									obj18 = obj19;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj22 = default;
								object obj16 = obj22;
								obj18 = obj19;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj23 = default;
							object obj16 = obj23;
							obj18 = obj19;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj24 = default;
						object obj16 = obj24;
						obj18 = obj19;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj25 = default;
					object obj16 = obj25;
					obj18 = obj19;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj26 = default;
				object obj16 = obj26;
				obj18 = obj19;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj27 = default;
			if (obj18 == obj27)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			}
			goto IL_0972;
		}
		return null;
		IL_098f:
		object obj28 = stringBuilder.m_ChunkLength + stringBuilder.m_ChunkOffset;
		if ((nint)obj28 > 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			IRequest result = default;
			return result;
		}
		return null;
		IL_0972:
		object obj29 = default;
		if (obj29 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v8+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v8+4]");
			object obj30 = (nint)0 << 2;
			object obj31 = obj4 + obj30;
			if ((nint)obj31 == 113)
			{
				object obj32 = obj4 + 4;
				if ((nint)obj32 > -1)
				{
					object obj33 = obj32 + -1;
					obj32 = obj33;
				}
				goto IL_098f;
			}
		}
		object obj34 = default;
		if (obj34 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_098f;
	}

	private unsafe IRequest PrepareCommitItemsRequest(IEnumerable<ICloudItem> items, out IDictionary<string, CloudServerCommitInfo> commitInfo)
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected I4, but got Unknown
		//IL_0110: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got Ref
		//IL_0056: Expected I4, but got Obj
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_0098: Expected Obj, but got I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00b3: Expected Obj, but got I4
		object obj = default;
		string text = (string)(obj + 24);
		bool flag = (byte)(obj + 16) != 0;
		((bool*)(flag ? 1 : 0))->m_value = false;
		obj = 0;
		_ = 0;
		string text2 = ((CloudUserData)this).get_Item((string)(object)items);
		if (text2 != null)
		{
			Dictionary<string, string> dictionary = MakeMetadataDictionary((ICloudItem)System.Runtime.CompilerServices.Unsafe.AsPointer(ref commitInfo), flag);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			text = (string)obj;
			string text3 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			text3.m_stringLength = 0;
			((AbstractAdProvider)(object)dictionary).TimeoutCaching((AdType)kilooAuth__BackingField, text);
			string text4 = BuildRefItemsQueryParameter((IEnumerable<ICloudItem>)dictionary);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = text4.m_stringLength;
			IRequest request = default;
			object obj2 = request + 12;
			obj2 = text4.m_firstChar;
			object obj3 = request + 16;
			obj3 = ((bool*)(flag ? 1 : 0))->m_value;
			return request;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 2;
		IRequest result = default;
		return result;
	}

	private unsafe Dictionary<string, string> MakeMetadataDictionary(ICloudItem item, bool zipped)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0e6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e72: Expected Obj, but got Unknown
		//IL_0e7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e80: Expected Obj, but got Unknown
		//IL_0eae: Expected Obj, but got I
		//IL_0ebe: Expected Obj, but got I
		//IL_0ecf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed4: Expected Obj, but got Unknown
		//IL_0edd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee2: Expected Obj, but got Unknown
		//IL_0f98: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got I4
		//IL_0f1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f20: Expected Obj, but got Unknown
		//IL_005b: Expected Obj, but got I4
		//IL_0073: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got I4
		//IL_02b1: Expected Obj, but got I4
		//IL_1044: Unknown result type (might be due to invalid IL or missing references)
		//IL_1049: Expected Obj, but got Unknown
		//IL_0d10: Expected Obj, but got I
		//IL_0f68: Expected Obj, but got I4
		//IL_00d8: Expected Obj, but got I4
		//IL_0dc8: Expected I, but got Obj
		//IL_0dde: Expected Obj, but got I
		//IL_02d2: Expected Obj, but got I4
		//IL_0d46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4b: Expected Obj, but got Unknown
		//IL_02ea: Expected Obj, but got I4
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_0195: Expected Obj, but got I4
		//IL_0e09: Expected I, but got Obj
		//IL_0302: Expected Obj, but got I4
		//IL_0d7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d81: Expected Obj, but got Unknown
		//IL_031a: Expected Obj, but got I4
		//IL_0218: Expected Obj, but got I4
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected Obj, but got Unknown
		//IL_0348: Expected Obj, but got I4
		//IL_0f50: Expected Obj, but got I4
		//IL_01e4: Expected Obj, but got I4
		//IL_0239: Expected Obj, but got I4
		//IL_035b: Expected I, but got Obj
		//IL_0371: Expected Obj, but got I
		//IL_01fc: Expected Obj, but got I4
		//IL_0251: Expected Obj, but got I4
		//IL_0f80: Expected Obj, but got I4
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_027c: Expected Obj, but got I4
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected Obj, but got Unknown
		//IL_042f: Expected Obj, but got I4
		//IL_039c: Expected I, but got Obj
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected Obj, but got Unknown
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected Obj, but got Unknown
		//IL_03df: Expected Obj, but got I4
		//IL_0c36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3b: Expected Obj, but got Unknown
		//IL_0c44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c49: Expected Obj, but got Unknown
		//IL_0c75: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 16;
		object obj4 = obj2 + 32;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S3_v3+60]");
		object obj6 = 0;
		object obj7 = obj6;
		object obj8 = obj7 & 0x1FFF;
		object obj9 = obj8 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v54 @ S4_v4 (should have been resolved before IL gen)");
		bool value = default;
		((bool*)(zipped ? 1 : 0))->m_value = value;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj11 = default;
		object obj12 = default;
		object obj13 = default;
		object obj15 = default;
		object obj17 = default;
		object obj20 = default;
		object obj23 = default;
		object obj28 = default;
		object obj29 = default;
		object obj33 = default;
		object obj36 = default;
		object obj10;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj10 = 57;
			bool flag = obj11 == null;
			obj10 = 58;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj10 = 9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			obj10 = 10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			obj10 = 10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj10 = 11;
			object obj18;
			object obj24;
			object obj25;
			if (obj12 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				obj10 = 14;
				if (obj13 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DB");
					object obj14 = obj15 << 32;
					object obj16 = obj17 | obj14;
					bool flag2 = (nint)obj16 < minimumSizeForCompression__BackingField;
					obj18 = obj12;
					if (flag2)
					{
						goto IL_0226;
					}
				}
				object obj19 = obj20 + 8;
				object obj21 = obj20 + 12;
				object obj22 = obj20 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18");
				obj10 = 20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S0_v164+10]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S0_v164+C]");
				if (num2 > 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
					obj10 = 23;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					obj10 = 24;
					obj18 = obj23;
					goto IL_0226;
				}
				obj24 = 1;
				obj25 = obj12;
				goto IL_0f3d;
			}
			object obj26 = 0;
			bool flag3 = false;
			goto IL_0f55;
			IL_0f55:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj10 = 42;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
			obj10 = 43;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			obj10 = 44;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			obj10 = 44;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj10 = 45;
			object obj27 = obj28 + 8;
			obj27 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj10 = 46;
			nint num3 = (nint)typeof(CloudServer2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ S0_v232 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudServer2>)+BA]");
			object obj30 = (nint)0 & (nint)0x200;
			if (obj30 != null)
			{
				nint num4 = (nint)typeof(CloudServer2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v810 @ S0_v264 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudServer2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					obj10 = 46;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj10 = 53;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj31 = obj28 + 16;
			obj31 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			obj10 = 54;
			object obj32 = obj28 + 40;
			obj32 = obj33;
			object obj34 = obj28 + 44;
			obj34 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			continue;
			IL_0226:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj10 = 39;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj10 = 40;
			object obj35 = obj36 + 12;
			obj24 = 0;
			obj25 = obj18;
			goto IL_0f3d;
			IL_0f3d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			obj10 = 41;
			flag3 = obj24 != null;
			obj26 = obj36;
			goto IL_0f55;
		}
		object obj37 = obj10 - 9;
		object obj40;
		if ((nint)obj10 != 9)
		{
			if ((nint)obj37 != 1)
			{
				if ((nint)obj37 != 2)
				{
					if ((nint)obj37 == 3 || (nint)obj37 == 4)
					{
						goto IL_1014;
					}
					if ((nint)obj37 != 5)
					{
						if ((nint)obj37 == 6)
						{
							goto IL_1014;
						}
						if ((nint)obj37 != 7)
						{
							if ((nint)obj37 == 8 || (nint)obj37 == 9 || (nint)obj37 == 10)
							{
								goto IL_1014;
							}
							if ((nint)obj37 != 11)
							{
								if ((nint)obj37 == 12 || (nint)obj37 == 13)
								{
									goto IL_1014;
								}
								if ((nint)obj37 != 14)
								{
									if ((nint)obj37 != 15)
									{
										if ((nint)obj37 == 16 || (nint)obj37 == 17 || (nint)obj37 == 18 || (nint)obj37 == 19 || (nint)obj37 == 20 || (nint)obj37 == 21 || (nint)obj37 == 22 || (nint)obj37 == 23 || (nint)obj37 == 24 || (nint)obj37 == 25 || (nint)obj37 == 26 || (nint)obj37 == 27 || (nint)obj37 == 28 || (nint)obj37 == 29)
										{
											goto IL_1014;
										}
										if ((nint)obj37 != 30)
										{
											if ((nint)obj37 != 31)
											{
												if ((nint)obj37 != 32)
												{
													if ((nint)obj37 != 33)
													{
														if ((nint)obj37 != 34)
														{
															if ((nint)obj37 != 35)
															{
																if ((nint)obj37 != 36)
																{
																	object obj38;
																	if ((nint)obj37 != 37)
																	{
																		if ((nint)obj37 != 38 && (nint)obj37 != 39 && (nint)obj37 != 40 && (nint)obj37 != 41 && (nint)obj37 != 42 && (nint)obj37 != 43)
																		{
																			if ((nint)obj37 == 44 || (nint)obj37 == 45 || (nint)obj37 == 46)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																				object obj39 = default;
																				obj38 = obj39;
																				obj40 = obj15;
																				goto IL_0fa2;
																			}
																			if ((nint)obj37 != 47)
																			{
																				if ((nint)obj37 == 48)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																					object obj41 = default;
																					obj38 = obj41;
																					obj40 = obj15;
																					goto IL_0fa2;
																				}
																				if ((nint)obj37 == 49)
																				{
																					object obj42 = obj4 + 4;
																					object obj43 = obj42 + 1;
																					obj42 = obj43;
																					object obj44 = obj43 << 2;
																					object obj45 = obj4 + obj44;
																					obj45 = 319;
																				}
																			}
																		}
																		goto IL_1014;
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																	object obj46 = default;
																	obj38 = obj46;
																	obj40 = obj15;
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																	object obj47 = default;
																	object obj38 = obj47;
																	obj40 = obj15;
																}
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																object obj48 = default;
																object obj38 = obj48;
																obj40 = obj15;
															}
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
															object obj49 = default;
															object obj38 = obj49;
															obj40 = obj15;
														}
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
														object obj50 = default;
														object obj38 = obj50;
														obj40 = obj15;
													}
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
													object obj51 = default;
													object obj38 = obj51;
													obj40 = obj15;
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
												object obj52 = default;
												object obj38 = obj52;
												obj40 = obj15;
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj53 = default;
											object obj38 = obj53;
											obj40 = obj15;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj54 = default;
										object obj38 = obj54;
										obj40 = obj15;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj55 = default;
									object obj38 = obj55;
									obj40 = obj15;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj56 = default;
								object obj38 = obj56;
								obj40 = obj15;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj57 = default;
							object obj38 = obj57;
							obj40 = obj15;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj58 = default;
						object obj38 = obj58;
						obj40 = obj15;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj59 = default;
					object obj38 = obj59;
					obj40 = obj15;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj60 = default;
				object obj38 = obj60;
				obj40 = obj15;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj61 = default;
			object obj38 = obj61;
			obj40 = obj15;
		}
		goto IL_0fa2;
		IL_1014:
		object obj62 = default;
		if (obj62 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+4]");
			object obj63 = (nint)0 << 2;
			object obj64 = obj4 + obj63;
			if ((nint)obj64 == 319)
			{
				object obj65 = obj4 + 4;
				if ((nint)obj65 > -1)
				{
					object obj66 = obj65 + -1;
					obj65 = obj66;
				}
				goto IL_1031;
			}
		}
		object obj67 = default;
		if (obj67 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_1031;
		IL_0fa2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj68 = default;
		if (obj40 == obj68)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_1014;
		IL_1031:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		object obj69 = text + 8;
		object obj70 = default;
		obj69 = obj70;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Uri uri = default;
		uri._002Ector(baseUri__BackingField, (Uri)(object)"api/v2/cloudsave");
		nint num5 = (nint)typeof(KilooWebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ S0_v54 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
		object obj71 = (nint)0 & (nint)0x200;
		if (obj71 != null)
		{
			nint num6 = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ S0_v63 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IRequest request = KilooWebClient.CreateGet(uri);
		IRequest request2 = RequestExtensions.WithQueryParameter(request, "Accept", "application/bson");
		IRequest request3 = RequestExtensions.WithKeepAlive(request2, timeout__BackingField);
		return (Dictionary<string, string>)RequestExtensions.WithHeader(request3, text, (string)(object)bsonSerializer__BackingField);
	}

	private bool CheckAuthentication(string expectedKilooTag)
	{
		//IL_00e0: Expected I, but got Obj
		//IL_00f6: Expected Obj, but got I
		//IL_0140: Expected VT, but got Obj
		//IL_0065: Expected VT, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0093: Expected VT, but got I4
		//IL_00aa: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Uri uri = default;
		uri._002Ector(baseUri__BackingField, (Uri)(object)"api/v2/cloudsave");
		nint num = (nint)typeof(KilooWebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v22 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IRequest request = KilooWebClient.CreatePut(uri);
		IRequest request2 = ((CloudServer2)null).PrepareUpdateItemsRequest((IEnumerable<ICloudItem>)(object)expectedKilooTag);
		Coroutine request3 = RequestExtensions.ThenMakeTheRequestAsync(request, (WebClient.RequestCompleteHandler)(object)"refItems", (WebClient.SendOptions)request2);
		Coroutine request4 = RequestExtensions.ThenMakeTheRequestAsync((IRequest)(object)request3, (WebClient.RequestCompleteHandler)(object)"metaOnly", (WebClient.SendOptions)"false");
		IRequest request5 = RequestExtensions.WithQueryParameter((IRequest)(object)request4, "Accept", "application/bson");
		IRequest request6 = RequestExtensions.ThenMakeTheRequest(request5, (WebClient.SendOptions)0);
		return (byte)(int)RequestExtensions.WithKeepAlive(request6, timeout__BackingField) != 0;
	}

	private Coroutine CheckAuthenticationAsync(string expectedKilooTag, Action<bool> completeHandler)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected Obj, but got Unknown
		//IL_0434: Expected Obj, but got I4
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected Obj, but got Unknown
		//IL_045e: Expected I, but got Obj
		//IL_0474: Expected Obj, but got I
		//IL_05bd: Expected Obj, but got I
		//IL_05cd: Expected Obj, but got I
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected Obj, but got Unknown
		//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_009a: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I
		//IL_00ba: Expected Obj, but got I
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_0100: Expected Obj, but got I
		//IL_0110: Expected Obj, but got I
		//IL_0120: Expected Obj, but got I
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_016b: Expected Obj, but got I
		//IL_017b: Expected Obj, but got I
		//IL_018b: Expected Obj, but got I
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected Obj, but got Unknown
		//IL_04a7: Expected Obj, but got I
		//IL_04b7: Expected Obj, but got I
		//IL_04c7: Expected Obj, but got I
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected Obj, but got Unknown
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected Obj, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected Obj, but got Unknown
		//IL_02df: Expected Obj, but got I4
		//IL_0388: Expected Obj, but got I
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected Obj, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 8;
		obj3 = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(StringComparer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Il2CppClass<System.StringComparer>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(StringComparer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v140 (Il2CppClass<System.StringComparer>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9E25");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S3_v3+60]");
		object obj7 = 0;
		object obj8 = obj7;
		object obj9 = obj8 & 0x1FFF;
		object obj10 = obj9 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v70 @ S4_v4 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj11 = default;
		obj2 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] array = default;
		string text = string.Concat(array);
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S4_v7+60]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S4_v8+48]");
		object obj14 = 0;
		object obj15 = obj14 & 0x7FF;
		object obj16 = obj15 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v103 @ S5_v6 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S4_v12+60]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S4_v13+48]");
		object obj19 = 0;
		object obj20 = obj19 & 0x7FF;
		object obj21 = obj20 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v127 @ S5_v10 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S4_v16 (Il2CppMethodInfo)+C]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S4_v17+60]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S4_v18+48]");
		object obj24 = 0;
		object obj25 = obj24 & 0x7FF;
		object obj26 = obj25 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v151 @ S5_v14 (should have been resolved before IL gen)");
		if (completeHandler != null)
		{
			object obj27 = "true";
		}
		else
		{
			object obj27 = "false";
		}
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S4_v21 (Il2CppMethodInfo)+C]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S4_v22+60]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S4_v23+48]");
		object obj30 = 0;
		object obj31 = obj30 & 0x7FF;
		object obj32 = obj31 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v180 @ S5_v18 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj33 = default;
		if (obj33 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj34 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj34 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			}
			object obj35 = obj4 + 4;
			object obj36 = obj35 + 1;
			obj35 = obj36;
			object obj37 = obj36 << 2;
			object obj38 = obj4 + obj37;
			obj38 = 177;
			object obj39 = default;
			if (obj39 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+4]");
				object obj40 = (nint)0 << 2;
				object obj41 = obj4 + obj40;
				if ((nint)obj41 == 177)
				{
					object obj42 = obj4 + 4;
					if ((nint)obj42 > -1)
					{
						object obj43 = obj42 + -1;
						obj42 = obj43;
					}
					goto IL_060a;
				}
			}
			object obj44 = default;
			if (obj44 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		goto IL_060a;
		IL_060a:
		Coroutine result = default;
		return result;
	}

	private IEnumerator CheckAuthenticationCoroutine(string expectedKilooTag, Action<bool> completeHandler)
	{
		IEnumerator list = ListItemsCoroutine(expectedKilooTag, (CloudServerRequestCompleteHandler)(object)completeHandler);
		return (IEnumerator)(object)CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	private unsafe bool CheckAuthenticationResult(string expectedKilooTag, bool isAuthenticated, Error error)
	{
		//IL_001f: Expected Obj, but got I4
		//IL_0023: Expected I4, but got Obj
		bool flag = ((CloudWorkingCopy)this).Synchronize((CloudConflictResolver)(object)expectedKilooTag, out *(isAuthenticated ? ((bool*)1) : ((bool*)null)), out *(bool*)error);
		return (byte)(int)CoroutineUtil.WaitForAll((YieldInstruction[])flag) != 0;
	}

	private IEnumerator ListItemsCoroutine(string forKilooTag, CloudServerRequestCompleteHandler completeHandler)
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
		object obj2 = enumerator + 24;
		obj2 = forKilooTag;
		object obj3 = enumerator + 20;
		obj3 = completeHandler;
		return enumerator;
	}

	private IEnumerator UpdateItemsCoroutine(string forKilooTag, IEnumerable<ICloudItem> items, CloudServerRequestCompleteHandler completeHandler)
	{
		//IL_01d0: Expected I, but got Obj
		//IL_01e6: Expected Obj, but got I
		//IL_0142: Expected I, but got Obj
		//IL_0158: Expected Obj, but got I
		//IL_0100: Expected Obj, but got I4
		//IL_0211: Expected I, but got Obj
		//IL_0183: Expected I, but got Obj
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I4
		//IL_00b8: Expected I, but got Obj
		if (items != null)
		{
			if (forKilooTag != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				string text = default;
				if (forKilooTag != text)
				{
					return (IEnumerator)1;
				}
				nint num = (nint)typeof(CloudServer2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v31 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudServer2>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(CloudServer2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v38 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudServer2>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((CloudUserData)(object)"Wrong kiloo tag.")._002Ector();
				return null;
			}
			return (IEnumerator)1;
		}
		if (completeHandler != null)
		{
			string text2 = "Authentication failed: " + (string)(object)completeHandler;
			nint num3 = (nint)typeof(CloudServer2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v7 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudServer2>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(CloudServer2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v12 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudServer2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((CloudUserData)(object)text2)._002Ector();
			return null;
		}
		nint num5 = (nint)typeof(CloudServer2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v9 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudServer2>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(CloudServer2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v16 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudServer2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((CloudUserData)(object)"Not authenticated.")._002Ector();
		return null;
	}

	private IEnumerator CommitItemsCoroutine(string forKilooTag, IEnumerable<ICloudItem> items, CloudServerCommitCompleteHandler completeHandler)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		object obj2 = enumerator + 20;
		obj2 = forKilooTag;
		object obj3 = enumerator + 28;
		obj3 = items;
		object obj4 = enumerator + 32;
		obj4 = completeHandler;
		return enumerator;
	}

	private unsafe byte[] Zip(Stream data, out int inputCrc32, out int inputLength, out int outputLength)
	{
		//IL_000d: Expected Obj, but got I
		//IL_0016: Expected VT, but got I4
		//IL_015d: Invalid comparison between VT and Obj
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected VT, but got Unknown
		//IL_0036: Expected Obj, but got Ref
		//IL_0043: Expected Obj, but got Ref
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		object obj = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref inputLength) * (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref inputLength);
		Rect rect = (Rect)0;
		object obj2 = default;
		object obj3 = default;
		int num2 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			if (rect >= obj2)
			{
				break;
			}
			int num = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				if (num >= (nint)obj3)
				{
					break;
				}
				object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref inputCrc32, num));
				object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref inputCrc32, num));
				object obj6 = obj4 * obj5;
				object obj7 = data - rect;
				object obj8 = data - rect;
				object obj9 = obj7 * obj8;
				object obj10 = obj6 + obj9;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
				{
					((int*)num2)->m_value = outputLength;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [outputLength @ L4 (System.Int32&)+8]");
					_ = 0;
					((Texture2D)this).ReadPixels(rect, num, num2);
				}
				int num3 = num + 1;
				num = num3;
			}
			Rect rect2 = (Rect)(rect + 1);
			rect = rect2;
		}
		return (byte[])(object)this;
	}

	private static void LogError(string msg)
	{
	}

	private unsafe static void LogResult(string method, CloudServerResult result)
	{
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected VT, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Ref, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_013c: Expected Obj, but got I4
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_0153: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_006a: Expected Obj, but got I
		//IL_017f: Expected Obj, but got VT
		//IL_0192: Expected Obj, but got I4
		//IL_01b5: Expected I8, but got Obj
		//IL_01b0: Expected native int or pointer, but got VT
		//IL_01bd: Expected native int or pointer, but got Obj
		//IL_0095: Expected I, but got Obj
		object obj = default;
		DateTime dateTime = (DateTime)(obj + 40);
		ref double reference = ref *(double*)(obj + 32);
		reference = ref *(double*)null;
		object obj2 = obj + 24;
		obj2 = 0;
		object obj3 = obj + 8;
		obj3 = 0;
		_ = 0;
		string text;
		if (result != null)
		{
			NumberFormatInfo currentInfo = NumberFormatInfo.CurrentInfo;
			if (System.Number.TryParseDouble((string)(object)result, NumberStyles.AllowHexSpecifier, currentInfo, out reference))
			{
				nint num = (nint)typeof(CloudServer2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v29 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudServer2>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num2 = (nint)typeof(CloudServer2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v43 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudServer2>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = _epoch;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC9D");
				text = (string)0;
				method.m_stringLength = 0;
				object obj5 = default;
				obj = obj5;
				((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj;
				*(DateTime?*)(nint)method = dateTime;
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		text = (string)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		method.m_stringLength = 0;
	}

	static CloudServer2()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(KilooWebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string osIdentifier = KilooWebClient.GetOsIdentifier();
		((TooltipAttribute)(object)"kiloowebclient_tags")._002Ector(osIdentifier);
		RenderPipelineManager.CleanupRenderPipeline();
	}
}

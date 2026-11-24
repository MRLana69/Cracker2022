using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Components.Logging;
using SYBO.Components.Utilities;
using UnityEngine;

namespace SYBO.Components.Analytics.Albatross;

public class MinimalHTTPPost : PostAnalyticsProvider.IHTTPPostLayer
{
	private sealed class _003CWaitForWWWRequest_003Ed__4(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public byte[] bytes;

		public Dictionary<string, string> headers;

		public MinimalHTTPPost _003C_003E4__this;

		public Action<int, string, string> onFinish;

		private WWW _003Cwww_003E5__2;

		private float _003CtimeoutPoint_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_050a: Expected Obj, but got I4
				//IL_016e: Invalid comparison between Obj and F4
				object obj2 = default;
				object obj = obj2 + 16;
				obj2 = obj;
				_ = -1;
				MinimalHTTPPost minimalHTTPPost = _003C_003E4__this;
				object obj12;
				object obj13 = default;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						goto IL_0504;
					}
					_003C_003E1__state = -3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					object obj3 = default;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						object obj4 = default;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)_003CtimeoutPoint_003E5__3))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
							_003C_003E1__state = 1;
							goto IL_0504;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					object obj5 = default;
					if (obj5 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						object obj6 = default;
						if (obj6 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						}
					}
					object obj7 = default;
					bool flag = obj7 == null;
					string empty = string.Empty;
					if (!flag)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						string text = default;
						empty = text;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					object obj8 = default;
					bool flag2 = obj8 == null;
					string empty2 = string.Empty;
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						object obj9 = default;
						bool flag3;
						if (obj9 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ S0_v94+8]");
							flag3 = (nint)0 == 0;
						}
						else
						{
							flag3 = true;
						}
						bool flag4 = !flag3;
						bool flag5 = !flag4;
						empty2 = string.Empty;
						if (!flag5)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							string text2 = default;
							empty2 = text2;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj11 = default;
					object obj10 = obj11;
					obj12 = obj13;
				}
				else
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj14 = default;
					object obj10 = obj14;
					obj12 = obj13;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				object obj15 = default;
				if (obj12 != obj15)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				_003C_003Em__Finally1();
				object obj16 = default;
				if (obj16 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
				goto IL_0504;
				IL_0504:
				return 1;
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

		private void _003C_003Em__Finally1()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_002c: Expected Obj, but got I4
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Expected Obj, but got Unknown
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected Obj, but got Unknown
			//IL_010c: Expected Obj, but got I4
			//IL_015b: Expected Obj, but got I
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected Obj, but got Unknown
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 8;
			obj = obj2;
			_ = -1;
			object obj3 = _003C_003E1__state - -3;
			if (_003C_003E1__state != -3 && ((nint)obj3 == 1 || (nint)obj3 == 2 || (nint)obj3 == 3 || (nint)obj3 != 4))
			{
				return;
			}
			object obj4 = obj + 4;
			object obj5 = obj4 + 1;
			obj4 = obj5;
			object obj6 = obj5 << 2;
			object obj7 = obj + obj6;
			obj7 = 26;
			((IEnumerator)this).Reset();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			if ((nint)0 == -1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			object obj8 = (nint)0 << 2;
			object obj9 = obj + obj8;
			if ((nint)obj9 == 26)
			{
				object obj10 = obj + 4;
				if ((nint)obj10 > -1)
				{
					object obj11 = obj10 + -1;
					obj10 = obj11;
				}
			}
		}

		void IEnumerator.Reset()
		{
			_003C_003E1__state = -1;
			if (_003Cwww_003E5__2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			}
		}
	}

	private MonoBehaviour _coroutineHost;

	private float _timeout;

	public MinimalHTTPPost(MonoBehaviour coroutineHost, float timeout = 60f)
	{
	}

	public void POST(string url, Dictionary<string, string> headers, byte[] bytes, Action<int, string, string> onFinish)
	{
		//IL_0022: Expected Obj, but got I
		//IL_0115: Expected I4, but got Obj
		//IL_0115: Expected Obj, but got I
		//IL_0127: Expected I, but got Obj
		//IL_013d: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I4
		//IL_0069: Expected I4, but got Obj
		//IL_0069: Expected Obj, but got I
		//IL_0168: Expected I, but got Obj
		//IL_0080: Expected I, but got Obj
		//IL_0096: Expected Obj, but got I
		//IL_01f5: Expected Obj, but got I4
		//IL_01f5: Expected Obj, but got I4
		//IL_00c1: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [url @ L1 (System.String)+14]");
		if (0 < (nint)headers)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [url @ L1 (System.String)+14]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [url @ L1 (System.String)+18]");
		object obj = num - 0;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) < System.Runtime.CompilerServices.Unsafe.As<Dictionary<string, string>, UIntPtr>(ref headers))
		{
			((Application.AdvertisingIdentifierCallback)3).EndInvoke(null);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [url @ L1 (System.String)+10]");
			string exception = string.ConcatArray((string[])0, (int)bytes);
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v21 (Il2CppClass<UnityEngine.Debug>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num3 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v27 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Debug.LogException((Exception)(object)exception, (UnityEngine.Object)(object)onFinish);
			((Application.AdvertisingIdentifierCallback)3).EndInvoke((IAsyncResult)1);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [url @ L1 (System.String)+10]");
		string exception2 = string.ConcatArray((string[])0, (int)bytes);
		nint num4 = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v9 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v14 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogException((Exception)(object)exception2, (UnityEngine.Object)(object)onFinish);
	}

	private unsafe IEnumerator WaitForWWWRequest(string url, Dictionary<string, string> headers, byte[] bytes, Action<int, string, string> onFinish)
	{
		//IL_00bf: Expected F4, but got Obj
		//IL_00ba: Expected native int or pointer, but got VT
		//IL_00d1: Expected F4, but got Obj
		//IL_00cc: Expected native int or pointer, but got VT
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected VT, but got Unknown
		//IL_00ec: Expected F4, but got Obj
		//IL_00e7: Expected native int or pointer, but got VT
		//IL_0101: Expected F4, but got I
		//IL_00fc: Expected native int or pointer, but got VT
		//IL_0129: Expected I, but got Obj
		//IL_013f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0081: Expected I4, but got Obj
		GameObject gameObject = ((Component)(object)url).gameObject;
		Vector3 vector = default;
		((Vector3*)(nint)vector)->x = (float)headers;
		((Vector3*)(nint)vector)->z = (float)headers.buckets;
		Quaternion quaternion = (Quaternion)(vector + 16);
		((Quaternion*)(nint)quaternion)->x = (float)bytes;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bytes @ L3 (System.Byte[])+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Transform transform = ((SpawnPool)this).Spawn(gameObject, vector, quaternion, (Transform)(object)onFinish);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v32 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (transform != null)
		{
			return null;
		}
		AudioSource component = transform.GetComponent<AudioSource>();
		component.Stop();
		Transform routine = ((SpawnPool)this).get_Item((int)component);
		Coroutine coroutine = ((MonoBehaviour)this).StartCoroutine_Auto((IEnumerator)routine);
		return (IEnumerator)(object)component;
	}

	public static int GetResponseCode(WWW request)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Log);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Log.Analytics.LogException((Exception)(object)"Retrieving Random value from unsynced random generator. Client game state diverged");
		return (int)((LoggingRandomGen)(object)request._uwr).Seed;
	}

	public static int ParseResponseCode(string statusLine)
	{
		//IL_0052: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_00f9: Expected I4, but got Obj
		Dictionary<string, string> responseHeaders = ((WWW)(object)statusLine).responseHeaders;
		if (responseHeaders != null)
		{
			string text = ((WWW)(object)statusLine).text;
			if (text != null)
			{
				string text2 = ((WWW)(object)statusLine).text;
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S2_v4 (Il2CppMethodInfo)+C]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S2_v5+60]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S2_v6+44]");
				object obj3 = 0;
				object obj4 = obj3 & 0x1FFF;
				object obj5 = obj4 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v56 @ S3_v6 (should have been resolved before IL gen)");
				object obj6 = default;
				if ((nint)obj6 > -1)
				{
					string text3 = ((WWW)(object)statusLine).text;
					string text4 = ((Dictionary<string, string>)(object)text3).get_Item("STATUS");
					string text5 = ((PostAnalyticsProvider)(object)text4).SYBO_002EComponents_002EAnalytics_002EIPostAnalytics_002EBaseURL;
					return (int)text5;
				}
				return 0;
			}
			return 0;
		}
		return 0;
	}
}

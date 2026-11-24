using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Ads;
using Kiloo.Common.HTTP;
using Kiloo.Common.Utility;
using UnityEngine;

namespace Kiloo.Common.Backend.Authentication;

public static class KilooAuthRequestExtensions
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public IRequest request;

		public bool isFromCache;

		public _003C_003Ec__DisplayClass6_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CSendAuthenticatedAsyncCoroutine_003Eb__0(bool success, Error error)
		{
			//IL_0015: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I
			//IL_0132: Expected Obj, but got I
			//IL_014f: Expected Obj, but got I4
			//IL_0612: Expected Obj, but got I
			//IL_061b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0620: Expected Obj, but got Unknown
			//IL_01d7: Expected Obj, but got I
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Expected Obj, but got Unknown
			//IL_0665: Unknown result type (might be due to invalid IL or missing references)
			//IL_066a: Expected Obj, but got Unknown
			//IL_05ad: Expected Obj, but got I
			//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bb: Expected Obj, but got Unknown
			//IL_05ce: Expected Obj, but got I4
			//IL_019b: Expected Obj, but got I
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Expected Obj, but got Unknown
			//IL_01bc: Expected Obj, but got I4
			//IL_03fc: Expected Obj, but got I
			//IL_0297: Expected Obj, but got I
			//IL_04bc: Expected Obj, but got I
			//IL_02eb: Expected Obj, but got I
			//IL_0480: Expected Obj, but got I
			//IL_0489: Unknown result type (might be due to invalid IL or missing references)
			//IL_048e: Expected Obj, but got Unknown
			//IL_04a1: Expected Obj, but got I4
			//IL_0575: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Authentication.KilooAuthRequestExtensions+<>c__DisplayClass6_0)+34]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Authentication.KilooAuthRequestExtensions+<>c__DisplayClass6_0)+34]");
			object obj3;
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Authentication.KilooAuthRequestExtensions+<>c__DisplayClass6_0)+34]");
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
						if (!flag4 && ~(isFromCache ? 1u : 0u) == 0)
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
					if (!flag6 && ~(isFromCache ? 1u : 0u) == 0)
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

		internal void _003CSendAuthenticatedAsyncCoroutine_003Eb__1(IRequest rqst, bool fromCache)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 16;
			obj2 = obj;
			_ = -1;
			if (rqst == null)
			{
				if (fromCache)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj4 = default;
				object obj3 = obj4;
				object obj6 = default;
				object obj5 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				object obj7 = default;
				if (obj5 == obj7)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					object obj9 = default;
					object obj8 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
					object obj11 = default;
					object obj10 = obj11;
				}
				else
				{
					object obj10 = obj3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			}
		}
	}

	private sealed class _003CSendAuthenticatedAsyncCoroutine_003Ed__6(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public IRequest request;

		public IKilooAuth kilooAuth;

		private _003C_003Ec__DisplayClass6_0 _003C_003E8__1;

		public WebClient.SendOptions options;

		public WebClient.RequestCompleteHandler onComplete;

		private int _003Ctries_003E5__2;

		private bool _003Cretry_003E5__3;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ad: Expected VT, but got Unknown
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Expected Obj, but got Unknown
				//IL_007b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0080: Expected Obj, but got Unknown
				//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f7: Expected Obj, but got Unknown
				//IL_0307: Unknown result type (might be due to invalid IL or missing references)
				//IL_030c: Expected Obj, but got Unknown
				//IL_0337: Expected Obj, but got I4
				//IL_0105: Expected I4, but got Obj
				//IL_014d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0152: Expected Obj, but got Unknown
				//IL_0162: Unknown result type (might be due to invalid IL or missing references)
				//IL_0167: Expected Obj, but got Unknown
				//IL_0189: Expected I4, but got Obj
				//IL_0184: Expected native int or pointer, but got VT
				//IL_019e: Expected Obj, but got I
				//IL_0199: Expected native int or pointer, but got VT
				//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a9: Expected Obj, but got Unknown
				//IL_01df: Expected Obj, but got I4
				object obj = default;
				WebClient.SendOptions sendOptions = (WebClient.SendOptions)(obj + 16);
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							return null;
						}
						_003C_003E1__state = -1;
						_003C_003Ec__DisplayClass6_0 obj2 = _003C_003E8__1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						object obj3 = default;
						if (obj3 == null)
						{
							_003C_003Ec__DisplayClass6_0 obj4 = _003C_003E8__1;
							List<AdType> adTypesWithClickCallbackSupport = ((AbstractAdProvider)obj4.request).adTypesWithClickCallbackSupport;
							if (adTypesWithClickCallbackSupport != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
								_003Cretry_003E5__3 = true;
							}
						}
						if (~(_003Cretry_003E5__3 ? 1u : 0u) == 0 && _003Ctries_003E5__2 <= 1)
						{
							goto IL_02ac;
						}
					}
					else
					{
						_003C_003E1__state = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						object obj5 = default;
						if ((nint)obj5 == 2)
						{
							_003C_003Ec__DisplayClass6_0 obj6 = _003C_003E8__1;
							bool flag = ((AbstractAdProvider)obj6.request).IsSupportedOnPlatform((AdType)kilooAuth);
							_003C_003Ec__DisplayClass6_0 obj7 = _003C_003E8__1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							nint method_ptr = 0;
							WebClient.RequestCompleteHandler requestCompleteHandler = default;
							((Delegate)requestCompleteHandler).method_ptr = method_ptr;
							((Delegate)requestCompleteHandler).method = (nint)__ldftn(_003C_003Ec__DisplayClass6_0._003CSendAuthenticatedAsyncCoroutine_003Eb__1);
							object obj8 = requestCompleteHandler + 16;
							obj8 = _003C_003E8__1;
							object obj9 = this + 28;
							obj = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S1_v49+8]");
							_ = 0;
							((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj != 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
							System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions)->simulatedRequestResults, (IList<SimulatedRequestResult>)0);
							object obj10 = this + 12;
							Coroutine coroutine = WebClient.RequestAsync(obj7.request, requestCompleteHandler, sendOptions);
							obj10 = coroutine;
							_003C_003E1__state = 2;
							return 1;
						}
					}
					if (onComplete != null)
					{
						_003C_003Ec__DisplayClass6_0 obj11 = _003C_003E8__1;
						_003C_003Ec__DisplayClass6_0 obj12 = _003C_003E8__1;
						bool isFromCache = obj12.isFromCache;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj13 = this + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj14 = default;
				obj13 = obj14;
				object obj15 = _003C_003E8__1 + 8;
				obj15 = request;
				_003C_003Ec__DisplayClass6_0 obj16 = _003C_003E8__1;
				obj16.isFromCache = false;
				_003Ctries_003E5__2 = 0;
				goto IL_02ac;
				IL_02ac:
				_003Cretry_003E5__3 = false;
				int num = _003Ctries_003E5__2 + 1;
				_003Ctries_003E5__2 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num2 = 0;
				_ = 0;
				object obj18 = default;
				object obj17 = obj18 + 16;
				obj17 = _003C_003E8__1;
				object obj19 = this + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				object obj20 = default;
				obj19 = obj20;
				_003C_003E1__state = 1;
				return 1;
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

	private const string AUTHORIZATION_HEADER = "Authorization";

	private const string AUTHORIZATION_FORMAT = "KilooAuth AccessToken=\"{0}\"";

	public static IRequest WithKilooAuth(IRequest request, IKilooAuth kilooAuth)
	{
		//IL_0012: Expected Obj, but got I4
		//IL_0016: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		KeyValuePair<string, IKilooAuthPlatform> pair = default;
		bool flag = ((KilooAuth)(object)request)._003CIsCachedTokenValid_003Eb__45_0(pair);
		string text = default;
		return (IRequest)(text != (string)flag);
	}

	public static void SendAuthenticated(IRequest request, IKilooAuth kilooAuth, WebClient.SendOptions options = default(WebClient.SendOptions))
	{
		//IL_0018: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I
		//IL_011e: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I4
		//IL_040b: Expected Obj, but got I
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected VT, but got Unknown
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected Obj, but got Unknown
		//IL_01da: Expected Obj, but got I
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected VT, but got Unknown
		//IL_019e: Expected Obj, but got I
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_01bf: Expected VT, but got I4
		//IL_026e: Expected Obj, but got I
		//IL_033a: Expected Obj, but got I
		//IL_02fe: Expected Obj, but got I
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected Obj, but got Unknown
		//IL_031f: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [request @ L0 (Kiloo.Common.HTTP.IRequest)+34]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [request @ L0 (Kiloo.Common.HTTP.IRequest)+34]");
		object obj3;
		object obj4;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [request @ L0 (Kiloo.Common.HTTP.IRequest)+34]");
			object obj2 = (nint)0 + (nint)16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
			obj3 = 0;
			obj4 = obj2;
		}
		else
		{
			obj4 = request;
			obj3 = 1;
		}
		object obj5 = default;
		object obj23 = default;
		object obj21 = default;
		for (; obj5 != obj3; obj5 = obj23 + 1)
		{
			object obj6 = obj5 << 2;
			object obj7 = obj4 + obj6;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v14+10]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v14+14]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v19+28]");
			if ((nint)0 == -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v19+24]");
			object obj11 = (nint)0 & (nint)0x10;
			bool flag = obj11 == null;
			object obj12 = (flag ? 1 : 0) ^ 1;
			WebClient.SendOptions sendOptions;
			if (obj12 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v19+2A]");
				if ((nint)0 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v14+8]");
					object obj13 = (nint)0 & (nint)0x3FFF;
					object obj14 = obj13 + 97173;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v115 @ S3_v17 (should have been resolved before IL gen)");
					sendOptions = (WebClient.SendOptions)97173;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v14+8]");
					object obj15 = (nint)0 & (nint)0x1FFF;
					sendOptions = (WebClient.SendOptions)(obj15 + 113696);
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v164 @ S4_v6 (Kiloo.Common.HTTP.WebClient+SendOptions) (should have been resolved before IL gen)");
				}
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v19+28]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v14+10]");
				bool flag2;
				if ((nint)0 != 0)
				{
					object obj16 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v62+9C]");
					object obj17 = (nint)0 & (nint)0x100;
					flag2 = obj17 != null;
				}
				else
				{
					flag2 = false;
				}
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [request @ L0 (Kiloo.Common.HTTP.IRequest)+C]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v14+10]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v14+8]");
							object obj18 = (nint)0 & (nint)0x3FFF;
							object obj19 = obj18 + 97173;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v165 @ S3_v12 (should have been resolved before IL gen)");
							sendOptions = (WebClient.SendOptions)97173;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v19+2B]");
						object obj20 = (nint)0 & (nint)3;
						bool flag3 = (nint)obj20 == 2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
						if (flag3)
						{
							if (obj21 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A77");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A78");
							}
						}
						else if (obj21 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
							sendOptions = options;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
						}
						continue;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v14+8]");
			object obj22 = (nint)0 & (nint)0x1FFF;
			sendOptions = (WebClient.SendOptions)(obj22 + 113696);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v164 @ S4_v6 (Kiloo.Common.HTTP.WebClient+SendOptions) (should have been resolved before IL gen)");
		}
	}

	public static Coroutine SendAuthenticatedAsync(IRequest request, IKilooAuth kilooAuth, WebClient.RequestCompleteHandler onComplete = null, WebClient.SendOptions options = default(WebClient.SendOptions))
	{
		//IL_0011: Expected Obj, but got VT
		Coroutine list = ((KilooAuth)(object)request).DetachPlatformsAsync((string[])(object)onComplete, (KilooAuth.DetachPlatformsCompleteHandler)options);
		return CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	public static bool IsAuthenticationErrorResponse(IRequest request)
	{
		//IL_0005: Expected I4, but got Obj
		return (byte)(int)request != 0;
	}

	private static IEnumerator SendAuthenticatedAsyncCoroutine(IRequest request, IKilooAuth kilooAuth, WebClient.RequestCompleteHandler onComplete, WebClient.SendOptions options)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_001f: Expected I4, but got Obj
		//IL_0034: Expected I4, but got Obj
		//IL_0041: Expected Obj, but got I4
		string text = (string)options.disableCache;
		text.m_stringLength = (int)options.simulatedRequestResults;
		bool flag = ((AbstractAdProvider)request).ShowAd((AdType)kilooAuth, (string)(object)onComplete, text);
		return (IEnumerator)(object)CoroutineUtil.WaitForAll((YieldInstruction[])flag);
	}

	private static void Log(string msg)
	{
		//IL_0060: Expected I4, but got Obj
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string message = string.ConcatArray((string[])(object)"[KilooAuth] ", (int)msg);
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
		Debug.LogError(message);
	}
}

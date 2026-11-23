using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Networking;

namespace Kiloo.Common.HTTP.Internal;

internal class UnityRequest : Request
{
	private sealed class _003CSendCoroutine_003Ed__5(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UnityRequest _003C_003E4__this;

		private bool _003Cok_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0a86: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a8b: Expected Obj, but got Unknown
			//IL_0662: Expected Obj, but got I
			//IL_0a52: Expected Obj, but got I
			//IL_0195: Expected Obj, but got I
			//IL_01c0: Expected Obj, but got I
			//IL_01e5: Expected Obj, but got I
			//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0200: Expected Obj, but got Unknown
			//IL_0210: Expected I, but got Obj
			//IL_0244: Expected Obj, but got I4
			//IL_0af0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0af5: Expected Obj, but got Unknown
			//IL_0b03: Expected Obj, but got I4
			//IL_0b19: Expected Obj, but got I
			//IL_049e: Expected Obj, but got I
			//IL_04c9: Expected Obj, but got I
			//IL_04ee: Expected Obj, but got I
			//IL_0504: Unknown result type (might be due to invalid IL or missing references)
			//IL_0509: Expected Obj, but got Unknown
			//IL_0522: Expected Obj, but got I
			//IL_057c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0581: Expected Obj, but got Unknown
			//IL_085a: Expected Obj, but got I
			//IL_0885: Expected Obj, but got I
			//IL_08aa: Expected Obj, but got I
			//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_08c5: Expected Obj, but got Unknown
			//IL_08d5: Expected I, but got Obj
			//IL_0909: Expected Obj, but got I4
			//IL_0b69: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 16;
			object obj3 = obj + 8;
			_ = 0;
			UnityRequest unityRequest = _003C_003E4__this;
			object obj21;
			object obj19;
			object obj6;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					bool result = default;
					return result;
				}
				_003C_003E1__state = -1;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_0abf;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				object obj4 = default;
				object obj5 = default;
				bool flag = obj4 != obj5;
				object obj7 = default;
				obj6 = obj7;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
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
							if (obj10 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj11 = (nint)0 << 2;
								object obj12 = obj3 + obj11;
								obj12 = obj9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj13 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj14 = (nint)0 << 2;
								object obj15 = obj14 + obj3;
								object obj16 = obj15 - 4;
								object obj17 = obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v10 (Kiloo.Common.HTTP.Internal.UnityRequest)+58]");
								((UnityWebRequest)0).Abort();
								object obj18 = obj17;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v487 @ S1_v166+D4] (should have been resolved before IL gen)");
								if (((Request)unityRequest).state__BackingField == RequestState.TimedOut)
								{
									_003C_003E4__this.UpdateBackOffError();
								}
								obj19 = this + 20;
								goto IL_0afa;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
							object obj20 = obj9;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag2 = (nint)0 != 1;
							obj21 = obj9;
							if (flag2)
							{
								goto IL_0a33;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag3 = (nint)0 == 1;
					object obj22 = default;
					obj21 = obj22;
					if (flag3)
					{
						goto IL_0a0b;
					}
					obj6 = obj22;
				}
			}
			else
			{
				_003Cok_003E5__2 = true;
				_003C_003E1__state = -1;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_0abf;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				object obj23 = default;
				object obj24 = default;
				bool flag4 = obj23 != obj24;
				object obj25 = default;
				obj6 = obj25;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj27 = default;
						object obj26 = obj27;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj28 = default;
							if (obj28 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj29 = (nint)0 << 2;
								object obj30 = obj3 + obj29;
								obj30 = obj27;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj31 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj32 = (nint)0 << 2;
								object obj33 = obj32 + obj3;
								object obj34 = obj33 - 4;
								Exception ex = (Exception)obj34;
								nint num = (nint)ex;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v410 @ S1_v119 (Il2CppClass<System.Exception>)+D4] (should have been resolved before IL gen)");
								((Request)unityRequest).exception__BackingField = ex;
								((Request)unityRequest).response__BackingField = null;
								object obj35 = ((Request)unityRequest).state__BackingField - 3;
								if ((nint)obj35 >= 4)
								{
									((Request)unityRequest).state__BackingField = RequestState.Error;
								}
								_003C_003E4__this.UpdateBackOffError();
								obj19 = this + 20;
								goto IL_0afa;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
							object obj36 = obj27;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag5 = (nint)0 != 1;
							obj21 = obj27;
							if (flag5)
							{
								goto IL_0a33;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag6 = (nint)0 != 1;
					object obj37 = default;
					obj6 = obj37;
					if (!flag6)
					{
						obj21 = obj37;
						goto IL_0a0b;
					}
				}
			}
			goto IL_0acf;
			IL_0acf:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			goto IL_0b23;
			IL_0a0b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			goto IL_0a33;
			IL_0a33:
			obj6 = obj21;
			goto IL_0acf;
			IL_0afa:
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
			object obj38 = -1;
			goto IL_0abf;
			IL_0abf:
			if (_003Cok_003E5__2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v10 (Kiloo.Common.HTTP.Internal.UnityRequest)+54]");
				if (!((AsyncOperation)0).isDone)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				if (~(_003Cok_003E5__2 ? 1u : 0u) == 0)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							IResponse response = default;
							((Request)unityRequest).response__BackingField = response;
							((Request)unityRequest).state__BackingField = RequestState.Done;
							goto IL_0b23;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
					object obj39 = default;
					object obj40 = default;
					bool flag7 = obj39 != obj40;
					object obj41 = default;
					obj6 = obj41;
					if (!flag7)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj43 = default;
							object obj42 = obj43;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								object obj44 = default;
								if (obj44 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
									object obj45 = (nint)0 << 2;
									object obj46 = obj3 + obj45;
									obj46 = obj43;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
									object obj47 = (nint)0 + (nint)1;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
									object obj48 = (nint)0 << 2;
									object obj49 = obj48 + obj3;
									object obj50 = obj49 - 4;
									Exception ex2 = (Exception)obj50;
									nint num2 = (nint)ex2;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v603 @ S1_v58 (Il2CppClass<System.Exception>)+D4] (should have been resolved before IL gen)");
									((Request)unityRequest).exception__BackingField = ex2;
									((Request)unityRequest).response__BackingField = null;
									object obj51 = ((Request)unityRequest).state__BackingField - 3;
									if ((nint)obj51 >= 4)
									{
										((Request)unityRequest).state__BackingField = RequestState.Error;
									}
									_003C_003E4__this.UpdateBackOffError();
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
									object obj52 = -1;
									goto IL_0b23;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
								object obj53 = obj43;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag8 = (nint)0 != 1;
								obj21 = obj44;
								if (flag8)
								{
									goto IL_0a33;
								}
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag9 = (nint)0 != 1;
						object obj54 = default;
						obj21 = obj54;
						obj6 = obj54;
						if (!flag9)
						{
							goto IL_0a0b;
						}
					}
					goto IL_0acf;
				}
			}
			goto IL_0b23;
			IL_0b23:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v10 (Kiloo.Common.HTTP.Internal.UnityRequest)+58]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v10 (Kiloo.Common.HTTP.Internal.UnityRequest)+58]");
				((UnityWebRequest)0).Dispose();
				_ = 0;
			}
			_ = 0;
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private AsyncOperation _sendAsyncOperation;

	private UnityWebRequest _unityWebRequest;

	public UnityRequest(string method, Uri uri, byte[] bytes)
		: base(method, uri, bytes)
	{
	}

	public override void FetchResponseAsync()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_021c: Expected Obj, but got I
		//IL_0247: Expected Obj, but got I
		//IL_026c: Expected Obj, but got I
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_0297: Expected I, but got Obj
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_02d0: Expected Obj, but got I4
		//IL_032c: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		PrepareFetchResponse();
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					return;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj4 = default;
		object obj5 = default;
		bool flag = obj4 != obj5;
		object obj7 = default;
		object obj6 = obj7;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
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
					if (obj10 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v4+4]");
						object obj11 = (nint)0 << 2;
						object obj12 = obj3 + obj11;
						obj12 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v4+4]");
						object obj13 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v4+4]");
						object obj14 = (nint)0 << 2;
						object obj15 = obj14 + obj3;
						object obj16 = obj15 - 4;
						Exception ex = (Exception)obj16;
						nint num = (nint)ex;
						object obj17 = ex + 24;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v214 @ S1_v45 (Il2CppClass<System.Exception>)+D4] (should have been resolved before IL gen)");
						base.exception__BackingField = ex;
						base.response__BackingField = null;
						object obj18 = base.state__BackingField - 3;
						if ((nint)obj18 >= 4)
						{
							base.state__BackingField = RequestState.Error;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
						object obj19 = default;
						if (obj19 == null)
						{
							UpdateBackOffError();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v4+4]");
						object obj20 = -1;
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj21 = obj9;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag2 = (nint)0 != 1;
					obj6 = obj9;
					if (flag2)
					{
						goto IL_0429;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag3 = (nint)0 != 1;
			object obj22 = default;
			obj6 = obj22;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				obj6 = obj22;
			}
		}
		goto IL_0429;
		IL_0429:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
	}

	public override void FetchResponse()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Expected Obj, but got Unknown
		//IL_0672: Expected Obj, but got I
		//IL_069d: Expected Obj, but got I
		//IL_06c2: Expected Obj, but got I
		//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dd: Expected Obj, but got Unknown
		//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fb: Expected Obj, but got Unknown
		//IL_0409: Expected Obj, but got I
		//IL_03ee: Expected Obj, but got I
		//IL_039a: Expected Obj, but got I
		//IL_0567: Expected Obj, but got I
		//IL_0570: Expected Obj, but got I4
		//IL_0429: Expected Obj, but got I
		//IL_0454: Expected Obj, but got I
		//IL_0479: Expected Obj, but got I
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected Obj, but got Unknown
		//IL_04a4: Expected I, but got Obj
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected Obj, but got Unknown
		//IL_04dd: Expected Obj, but got I4
		//IL_0539: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		PrepareFetchResponse();
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj4 = default;
				while (true)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						break;
					}
					if (obj4 != null)
					{
						goto IL_0114;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
						}
					}
					goto IL_0186;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				goto IL_0195;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_0195;
		IL_0186:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_0195;
		IL_063a:
		UnityRequest unityRequest = default;
		if (unityRequest._unityWebRequest != null)
		{
			unityRequest._unityWebRequest.Dispose();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			object obj5 = (nint)0 + (nint)88;
			obj5 = 0;
		}
		unityRequest._sendAsyncOperation = null;
		return;
		IL_0195:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj6 = default;
		object obj7 = default;
		bool flag = obj6 == obj7;
		bool flag2 = !flag;
		object obj9 = default;
		object obj8 = obj9;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj11 = default;
				object obj10 = obj11;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					obj8 = obj11;
					object obj12 = default;
					if (obj12 != null)
					{
						goto IL_065c;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj13 = obj11;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj14 = default;
							if (obj14 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj15 = (nint)0 << 2;
								object obj16 = obj3 + obj15;
								obj16 = obj11;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj17 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj18 = (nint)0 << 2;
								object obj19 = obj18 + obj3;
								object obj20 = obj19 - 4;
								Exception ex = (Exception)obj20;
								nint num = (nint)ex;
								object obj21 = ex + 24;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v415 @ S1_v76 (Il2CppClass<System.Exception>)+D4] (should have been resolved before IL gen)");
								base.exception__BackingField = ex;
								base.response__BackingField = null;
								object obj22 = base.state__BackingField - 3;
								if ((nint)obj22 >= 4)
								{
									base.state__BackingField = RequestState.Error;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
								object obj23 = default;
								if (obj23 == null)
								{
									UpdateBackOffError();
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj24 = -1;
								goto IL_063a;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
							object obj25 = obj11;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								return;
							}
						}
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			unityRequest = (UnityRequest)0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag3 = (nint)0 == 1;
			object obj26 = default;
			obj8 = obj26;
			if (flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_065c;
		IL_065c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
		object obj27 = (nint)0 << 2;
		object obj28 = obj3 + obj27;
		obj28 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
		object obj29 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
		object obj30 = (nint)0 << 2;
		object obj31 = obj30 + obj3;
		object obj32 = obj31 - 4;
		object obj33 = obj32;
		object obj34 = obj33;
		object obj35 = obj33 + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v253 @ S1_v32+D4] (should have been resolved before IL gen)");
		if (((Request)unityRequest).state__BackingField == RequestState.TimedOut)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			((Request)0).UpdateBackOffError();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
		object obj36 = -1;
		goto IL_063a;
		IL_0114:
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			IResponse response = default;
			base.response__BackingField = response;
			base.state__BackingField = RequestState.Done;
			goto IL_063a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_0195;
	}

	private IEnumerator SendCoroutine()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void SendUnityWebRequest()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_05bb: Expected I, but got Obj
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		//IL_0637: Expected Obj, but got Unknown
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected Obj, but got Unknown
		//IL_00c4: Expected Obj, but got I
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected Obj, but got Unknown
		//IL_04d3: Expected Obj, but got I
		//IL_0149: Expected Obj, but got I
		//IL_0327: Expected Obj, but got I4
		//IL_0308: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Uri uri = base.uri__BackingField;
		nint num = (nint)uri;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S1_v8 (Il2CppClass<System.Uri>)+D4] (should have been resolved before IL gen)");
		UnityWebRequest unityWebRequest = default;
		string url = default;
		unityWebRequest._002Ector(url, base.method__BackingField);
		_unityWebRequest = unityWebRequest;
		_unityWebRequest.redirectLimit = (int)base.maxRedirectCount__BackingField;
		object obj3 = obj + 8;
		Headers headers = base.headers__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj4 = obj + 40;
		obj = obj4;
		_ = 0;
		object obj6 = default;
		object obj9 = default;
		object obj10 = default;
		UnityWebRequest unityWebRequest2;
		object obj13 = default;
		object obj14 = default;
		byte[] array = default;
		byte[] array2 = default;
		UnityRequest unityRequest = default;
		UploadHandlerRaw uploadHandlerRaw = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			object obj8;
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				if (obj6 == null)
				{
					goto IL_0443;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
				obj = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
						object obj7 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S0_v121+C]");
								if ((nint)0 == 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									bool flag = (nint)0 != 1;
									obj8 = obj9;
									if (flag)
									{
										goto IL_02dc;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								else
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag2 = (nint)0 == 1;
										obj8 = obj10;
										if (!flag2)
										{
											goto IL_02dc;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
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
			goto IL_03b4;
			IL_02dc:
			_ = 0;
			object obj11;
			if (obj8 != null)
			{
				obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ L2_v21+8]");
				if ((nint)0 != 0)
				{
					goto IL_05f8;
				}
			}
			obj11 = 1;
			goto IL_05f8;
			IL_05f8:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj11 != null)
				{
					continue;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_03b4;
			IL_0443:
			object obj12 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1961");
			byte[] data = base.bytes__BackingField;
			if (base.bytes__BackingField == null)
			{
				unityWebRequest2 = _unityWebRequest;
				break;
			}
			goto IL_0677;
			IL_03b4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag3 = obj13 != obj14;
			data = array;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_0443;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				data = array2;
			}
			_ = 0;
			object obj15 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			unityRequest = (UnityRequest)0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				goto IL_0677;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			return;
			IL_0677:
			uploadHandlerRaw._002Ector(data);
			unityRequest._unityWebRequest.uploadHandler = uploadHandlerRaw;
			UnityWebRequest unityWebRequest3 = unityRequest._unityWebRequest;
			unityWebRequest3.disposeUploadHandlerOnDispose__BackingField = true;
			unityWebRequest2 = unityWebRequest3;
			break;
		}
		DownloadHandlerBuffer downloadHandlerBuffer = default;
		downloadHandlerBuffer._002Ector();
		unityWebRequest2.downloadHandler = downloadHandlerBuffer;
		UnityWebRequest unityWebRequest4 = unityRequest._unityWebRequest;
		unityWebRequest4.disposeDownloadHandlerOnDispose__BackingField = true;
		AsyncOperation sendAsyncOperation = unityWebRequest4.Send();
		unityRequest._sendAsyncOperation = sendAsyncOperation;
	}

	private IResponse CreateResponseFromUnityWebRequest()
	{
		//IL_014f: Expected I, but got Obj
		//IL_0171: Expected I4, but got I8
		//IL_0056: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got I4
		long responseCode = _unityWebRequest.responseCode;
		bool flag = responseCode == 0;
		bool flag2 = !flag;
		UnityWebRequest unityWebRequest = _unityWebRequest;
		if (flag2)
		{
			goto IL_013a;
		}
		string error = _unityWebRequest.error;
		object obj;
		if (error != null)
		{
			obj = 0;
			if (error._stringLength != 0)
			{
				goto IL_017a;
			}
		}
		obj = 1;
		goto IL_017a;
		IL_017a:
		bool flag3 = obj == null;
		UnityRequest unityRequest = (UnityRequest)(object)error;
		if (!flag3)
		{
			unityRequest = (UnityRequest)(object)"Unknown error";
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		HTTPException ex = default;
		ex._002Ector((string)(object)this);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		unityWebRequest = (UnityWebRequest)(object)ex;
		goto IL_013a;
		IL_013a:
		DownloadHandler downloadHandler = unityWebRequest.m_DownloadHandler;
		nint num = (nint)downloadHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v43 @ S1_v5 (Il2CppClass<UnityEngine.Networking.DownloadHandler>)+F4] (should have been resolved before IL gen)");
		long responseCode2 = _unityWebRequest.responseCode;
		string text = HTTPStatus.ToString((int)responseCode2);
		Headers headers = default;
		headers._002Ector();
		Dictionary<string, string> responseHeaders = _unityWebRequest.GetResponseHeaders();
		if (responseHeaders != null)
		{
			Headers headers2 = headers.AddAll(responseHeaders);
		}
		IResponse result = default;
		return result;
	}

	private static void LogError(string msg)
	{
	}

	private static void Log(string msg)
	{
	}

	private void _003C_003En__0(Exception value)
	{
		base.exception__BackingField = value;
	}

	private void _003C_003En__1(IResponse value)
	{
		base.response__BackingField = value;
	}

	private RequestState _003C_003En__2()
	{
		return base.state__BackingField;
	}

	private void _003C_003En__3(RequestState value)
	{
		base.state__BackingField = value;
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Unity.Services.Authentication;
using Unity.Services.Core;
using Unity.Services.Leaderboards.Models;
using UnityEngine;

public class LeaderboardController : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	private struct _003CAwake_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public LeaderboardController _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private unsafe void MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_01c2: Expected Obj, but got Ref
			//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03eb: Expected Obj, but got Unknown
			//IL_01f6: Expected Obj, but got Ref
			//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d5: Expected Obj, but got Unknown
			//IL_0478: Unknown result type (might be due to invalid IL or missing references)
			//IL_047d: Expected Obj, but got Unknown
			//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ce: Expected Obj, but got Unknown
			//IL_06b6: Expected VT, but got Ref
			//IL_06bf: Expected Ref, but got VT
			//IL_052e: Expected VT, but got I
			//IL_053f: Expected Obj, but got Ref
			//IL_0548: Unknown result type (might be due to invalid IL or missing references)
			//IL_054d: Expected Obj, but got Unknown
			//IL_07db: Expected Obj, but got I
			//IL_0806: Expected Obj, but got I
			//IL_082b: Expected Obj, but got I
			//IL_0841: Unknown result type (might be due to invalid IL or missing references)
			//IL_0846: Expected Obj, but got Unknown
			//IL_085c: Expected VT, but got Ref
			//IL_0869: Expected Ref, but got VT
			//IL_0884: Expected Obj, but got I
			//IL_0278: Unknown result type (might be due to invalid IL or missing references)
			//IL_027d: Expected Obj, but got Unknown
			//IL_028b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0290: Expected Obj, but got Unknown
			//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02dc: Expected Obj, but got Unknown
			//IL_0344: Expected VT, but got I
			//IL_0355: Expected Obj, but got Ref
			//IL_035e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0363: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			_ = 0;
			_ = 0;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj3 = default;
							if (obj3 != null)
							{
								goto IL_0210;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									object obj4 = default;
									if (obj4 != null)
									{
										goto IL_0210;
									}
									goto IL_09a4;
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
					goto IL_06d3;
				}
				_ = _003C_003Eu__1;
				object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 24));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
				_003C_003E1__state = -1;
				goto IL_05c1;
			}
			_ = _003C_003Eu__1;
			object obj6 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 24));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
			_003C_003E1__state = -1;
			object obj7 = obj;
			goto IL_03d7;
			IL_06c4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_06d3;
			IL_0210:
			instance = _003C_003E4__this;
			goto IL_09a4;
			IL_05c1:
			_ = 0;
			object obj8 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				goto IL_06c4;
			}
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
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
					_003C_003E1__state = -2;
					AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
					((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->SetResult();
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_06d3;
			IL_09a4:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				goto IL_06c4;
			}
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				object obj9 = obj - 16;
				object obj10 = obj9 + 16;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ S0_v223+8]");
					_ = 0;
					object obj11 = obj + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						obj7 = obj10;
						object obj12 = default;
						if (obj12 != null)
						{
							goto IL_03d7;
						}
						_003C_003E1__state = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						_003C_003Eu__1 = (TaskAwaiter)0;
						_ = 0;
						object obj13 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
						object obj14 = obj + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
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
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_06d3;
			IL_06d3:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj15 = default;
			object obj16 = default;
			bool flag = obj15 == obj16;
			bool flag2 = !flag;
			object obj18 = default;
			object obj17 = obj18;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj20 = default;
					object obj19 = obj20;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj21 = default;
						if (obj21 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
							object obj22 = (nint)0 << 2;
							object obj23 = obj + obj22;
							obj23 = obj20;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
							object obj24 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
							object obj25 = (nint)0 << 2;
							object obj26 = obj25 + obj;
							object exception = obj26 - 4;
							_003C_003E1__state = -2;
							AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
							((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->SetException((Exception)exception);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
							object obj27 = -1;
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
						object obj28 = obj20;
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
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag3 = (nint)0 == 1;
				object obj29 = default;
				obj17 = obj29;
				if (flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
			IL_03d7:
			_ = 0;
			object obj30 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				goto IL_06c4;
			}
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				object obj31 = obj7 - 16;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S0_v133+8]");
					_ = 0;
					object obj32 = obj + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj33 = default;
						if (obj33 != null)
						{
							goto IL_05c1;
						}
						_003C_003E1__state = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						_003C_003Eu__1 = (TaskAwaiter)0;
						_ = 0;
						object obj34 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
						object obj35 = obj + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
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
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_06d3;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000b: Expected VT, but got Ref
			//IL_0018: Expected Ref, but got VT
			AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__3_0;

		public static Action<RequestFailedException> _003C_003E9__3_1;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003CSignInAnonymously_003Eb__3_0()
		{
			IAuthenticationService instance = AuthenticationService.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string text = default;
			string message = "Signed in as: " + text;
			Debug.Log(message);
		}

		internal void _003CSignInAnonymously_003Eb__3_1(RequestFailedException s)
		{
			Debug.Log(s);
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct _003CSignInAnonymously_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		private TaskAwaiter _003C_003Eu__1;

		private unsafe void MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0556: Expected Obj, but got Ref
			//IL_0904: Unknown result type (might be due to invalid IL or missing references)
			//IL_0909: Expected Obj, but got Unknown
			//IL_094a: Expected native int or pointer, but got VT
			//IL_0965: Expected VT, but got I
			//IL_096e: Expected Ref, but got VT
			//IL_07e6: Expected VT, but got I
			//IL_0696: Expected Obj, but got I
			//IL_06c1: Expected Obj, but got I
			//IL_06e6: Expected Obj, but got I
			//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0701: Expected Obj, but got Unknown
			//IL_0726: Expected VT, but got Ref
			//IL_0733: Expected Ref, but got VT
			//IL_074e: Expected Obj, but got I
			//IL_0376: Unknown result type (might be due to invalid IL or missing references)
			//IL_037b: Expected Obj, but got Unknown
			//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cc: Expected Obj, but got Unknown
			//IL_042c: Expected VT, but got I
			//IL_0486: Expected Obj, but got Ref
			//IL_048f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0494: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			_ = 0;
			_ = 0;
			if (_003C_003E1__state != 0)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
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
						bool flag = _003C_003Ec._003C_003E9__3_0 == null;
						bool flag2 = !flag;
						Action action = _003C_003Ec._003C_003E9__3_0;
						if (!flag2)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 == 1)
							{
								goto IL_0570;
							}
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
									Action action2 = default;
									_003C_003Ec._003C_003E9__3_0 = action2;
									action = action2;
									goto IL_087f;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							goto IL_058e;
						}
						goto IL_087f;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				goto IL_058e;
			}
			_ = _003C_003Eu__1;
			object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
			_003C_003E1__state = -1;
			goto IL_08f5;
			IL_058e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj4 = default;
			object obj5 = default;
			bool flag3 = obj4 == obj5;
			bool flag4 = !flag3;
			object obj7 = default;
			object obj6 = obj7;
			_003CSignInAnonymously_003Ed__3 obj18 = default;
			if (!flag4)
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
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
							object obj11 = (nint)0 << 2;
							object obj12 = obj + obj11;
							obj12 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
							object obj13 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
							object obj14 = (nint)0 << 2;
							object obj15 = obj14 + obj;
							object exception = obj15 - 4;
							_003C_003E1__state = -2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
							AsyncTaskMethodBuilder asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
							((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->SetException((Exception)exception);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
							object obj16 = -1;
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
						object obj17 = obj9;
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
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj18 = (_003CSignInAnonymously_003Ed__3)0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag5 = (nint)0 == 1;
				object obj19 = default;
				obj6 = obj19;
				if (flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			goto IL_0941;
			IL_08f5:
			_ = 0;
			object obj20 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				goto IL_0570;
			}
			goto IL_0941;
			IL_08ba:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				goto IL_0570;
			}
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					object obj21 = obj - 16;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ S0_v187+8]");
						_ = 0;
						object obj22 = obj + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj23 = default;
							if (obj23 != null)
							{
								goto IL_08f5;
							}
							_003C_003E1__state = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
							_003C_003Eu__1 = (TaskAwaiter)0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								object obj24 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
								object obj25 = obj + 8;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									return;
								}
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
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_058e;
			IL_0570:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_058e;
			IL_087f:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				goto IL_0570;
			}
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
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
					bool flag6 = _003C_003Ec._003C_003E9__3_1 == null;
					bool flag7 = !flag6;
					Action<RequestFailedException> action3 = _003C_003Ec._003C_003E9__3_1;
					if (!flag7)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							goto IL_0570;
						}
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
								Action<RequestFailedException> action4 = default;
								_003C_003Ec._003C_003E9__3_1 = action4;
								action3 = action4;
								goto IL_08ba;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						goto IL_058e;
					}
					goto IL_08ba;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_058e;
			IL_0941:
			((_003CSignInAnonymously_003Ed__3*)(nint)obj18)->_003C_003E1__state = -2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)((nint)0 + (nint)4);
			((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_0010: Expected VT, but got Ref
			//IL_001d: Expected Ref, but got VT
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
			((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct _003CAddScore_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public string name;

		public LeaderboardController _003C_003E4__this;

		public int score;

		public Action<string> callBack;

		private TaskAwaiter<LeaderboardEntry> _003C_003Eu__1;

		private unsafe void MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0397: Expected Obj, but got Ref
			//IL_07c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c8: Expected Obj, but got Unknown
			//IL_04b7: Expected VT, but got Ref
			//IL_04c0: Expected Ref, but got VT
			//IL_05eb: Expected Obj, but got I
			//IL_0616: Expected Obj, but got I
			//IL_063b: Expected Obj, but got I
			//IL_0651: Unknown result type (might be due to invalid IL or missing references)
			//IL_0656: Expected Obj, but got Unknown
			//IL_066c: Expected VT, but got Ref
			//IL_0679: Expected Ref, but got VT
			//IL_0694: Expected Obj, but got I
			//IL_0242: Unknown result type (might be due to invalid IL or missing references)
			//IL_0247: Expected Obj, but got Unknown
			//IL_02a7: Expected VT, but got I
			//IL_02b8: Expected Obj, but got Ref
			//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c6: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			_ = 0;
			_ = 0;
			if (_003C_003E1__state != 0)
			{
				LeaderboardController leaderboardController = _003C_003E4__this;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
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
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
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
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
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
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @218");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												Task<LeaderboardEntry> task = default;
												TaskAwaiter<LeaderboardEntry> awaiter = task.GetAwaiter();
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													object obj3 = obj + 8;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														object obj4 = default;
														if (obj4 != null)
														{
															goto IL_07b4;
														}
														_003C_003E1__state = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
														_003C_003Eu__1 = (TaskAwaiter<LeaderboardEntry>)0;
														_ = 0;
														object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
														object obj6 = obj + 8;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
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
										goto IL_04e3;
									}
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
						goto IL_04e3;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				goto IL_04e3;
			}
			_ = _003C_003Eu__1;
			object obj7 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 36));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
			_003C_003E1__state = -1;
			goto IL_07b4;
			IL_04a1:
			_003C_003E1__state = -2;
			AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->SetResult();
			return;
			IL_04e3:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj8 = default;
			object obj9 = default;
			bool flag = obj8 == obj9;
			bool flag2 = !flag;
			object obj11 = default;
			object obj10 = obj11;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj13 = default;
					object obj12 = obj13;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj14 = default;
						if (obj14 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
							object obj15 = (nint)0 << 2;
							object obj16 = obj + obj15;
							obj16 = obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
							object obj17 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
							object obj18 = (nint)0 << 2;
							object obj19 = obj18 + obj;
							object exception = obj19 - 4;
							_003C_003E1__state = -2;
							AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
							((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->SetException((Exception)exception);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
							object obj20 = -1;
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
						object obj21 = obj13;
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
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag3 = (nint)0 == 1;
				object obj22 = default;
				obj10 = obj22;
				if (flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
			IL_07b4:
			_ = 0;
			object obj23 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (callBack == null)
				{
					goto IL_04a1;
				}
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							goto IL_04a1;
						}
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
			goto IL_04e3;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000b: Expected VT, but got Ref
			//IL_0018: Expected Ref, but got VT
			AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct _003CGetScores_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public LeaderboardController _003C_003E4__this;

		public Action<LeaderboardData> callBack;

		private TaskAwaiter<LeaderboardScoresPage> _003C_003Eu__1;

		private unsafe void MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0710: Unknown result type (might be due to invalid IL or missing references)
			//IL_0715: Expected Obj, but got Unknown
			//IL_02e6: Expected Obj, but got Ref
			//IL_0749: Unknown result type (might be due to invalid IL or missing references)
			//IL_074e: Expected Obj, but got Unknown
			//IL_078c: Expected native int or pointer, but got VT
			//IL_07a7: Expected VT, but got I
			//IL_07b0: Expected Ref, but got VT
			//IL_0693: Expected VT, but got I
			//IL_0552: Expected Obj, but got I
			//IL_057d: Expected Obj, but got I
			//IL_05a2: Expected Obj, but got I
			//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bd: Expected Obj, but got Unknown
			//IL_05d3: Expected VT, but got Ref
			//IL_05e0: Expected Ref, but got VT
			//IL_01af: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b4: Expected Obj, but got Unknown
			//IL_05fb: Expected Obj, but got I
			//IL_0214: Expected VT, but got I
			//IL_0225: Expected Obj, but got Ref
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 32;
			_ = 0;
			object obj3 = obj + 16;
			_ = 0;
			if (_003C_003E1__state != 0)
			{
				LeaderboardController leaderboardController = _003C_003E4__this;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
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
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							_ = 0;
							_ = 1;
							_ = 1;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E]");
								_ = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Task<LeaderboardScoresPage> task = default;
									TaskAwaiter<LeaderboardScoresPage> awaiter = task.GetAwaiter();
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										object obj4 = obj + 24;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											object obj5 = default;
											if (obj5 != null)
											{
												goto IL_073a;
											}
											_003C_003E1__state = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
											_003C_003Eu__1 = (TaskAwaiter<LeaderboardScoresPage>)0;
											_ = 0;
											object obj6 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
											object obj7 = obj + 24;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
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
							goto IL_044a;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_044a;
			}
			_ = _003C_003Eu__1;
			object obj8 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 28));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
			_003C_003E1__state = -1;
			goto IL_073a;
			IL_0783:
			_003CGetScores_003Ed__5 obj9 = default;
			((_003CGetScores_003Ed__5*)(nint)obj9)->_003C_003E1__state = -2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)((nint)0 + (nint)4);
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->SetResult();
			return;
			IL_073a:
			_ = 0;
			object obj10 = obj + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (callBack != null)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									goto IL_044a;
								}
							}
							goto IL_0783;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					goto IL_044a;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_044a;
			IL_044a:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj11 = default;
			object obj12 = default;
			bool flag = obj11 == obj12;
			bool flag2 = !flag;
			object obj14 = default;
			object obj13 = obj14;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj16 = default;
					object obj15 = obj16;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj17 = default;
						if (obj17 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
							object obj18 = (nint)0 << 2;
							object obj19 = obj3 + obj18;
							obj19 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
							object obj20 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
							object obj21 = (nint)0 << 2;
							object obj22 = obj21 + obj3;
							object exception = obj22 - 4;
							_003C_003E1__state = -2;
							AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
							((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->SetException((Exception)exception);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
							object obj23 = -1;
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
						object obj24 = obj16;
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
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj9 = (_003CGetScores_003Ed__5)0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag3 = (nint)0 == 1;
				object obj25 = default;
				obj13 = obj25;
				if (flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			goto IL_0783;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000b: Expected VT, but got Ref
			//IL_0018: Expected Ref, but got VT
			AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	public string LeaderboardId = "subway-cracker";

	public static LeaderboardController instance;

	private void Awake()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		AsyncVoidMethodBuilder asyncVoidMethodBuilder = AsyncVoidMethodBuilder.Create();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_ = -1;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A7FC");
	}

	private unsafe Task SignInAnonymously()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected VT, but got Unknown
		//IL_0038: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @54F");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_ = -1;
		object obj4 = obj + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A831");
		object obj5 = obj + 40;
		AsyncTaskMethodBuilder asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)(obj5 | 4);
		return ((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->Task;
	}

	public void AddScore(string name, int score, Action<string> callBack)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + -64;
		object obj3 = obj + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
		AsyncVoidMethodBuilder asyncVoidMethodBuilder = AsyncVoidMethodBuilder.Create();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_ = -1;
		object obj4 = obj + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A7FE");
	}

	public void GetScores(int offset, int limit, Action<LeaderboardData> callBack)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		object obj3 = obj + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		AsyncVoidMethodBuilder asyncVoidMethodBuilder = AsyncVoidMethodBuilder.Create();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		obj3 = callBack;
		_ = -1;
		object obj4 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A7FA");
	}
}

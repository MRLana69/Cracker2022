using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Backend.Authentication;
using Kiloo.Common.Utility;
using Kiloo.GameCenter;
using Kiloo.Google;
using UnityEngine;

namespace Kiloo.Integration.GameCenter;

public class GameCenterKilooAuthPlatform : IKilooAuthPlatform
{
	private sealed class _003CUpdateAsyncCoroutine_003Ed__11(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public GameCenterKilooAuthPlatform _003C_003E4__this;

		private GameCenterPlugin.LocalPlayer _003CgameCenterPlayer_003E5__2;

		private GameCenterGenerateIdentityVerificationSignatureRequest _003CsignatureRequest_003E5__3;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0720: Expected Obj, but got Ref
				//IL_0061: Expected I, but got Obj
				//IL_0077: Expected Obj, but got I
				//IL_04fa: Expected I, but got Obj
				//IL_0510: Expected Obj, but got I
				//IL_00a2: Expected I, but got Obj
				//IL_05b5: Expected I, but got Obj
				//IL_05cb: Expected Obj, but got I
				//IL_053b: Expected I, but got Obj
				//IL_08cd: Expected Obj, but got VT
				//IL_08e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_08e5: Expected Obj, but got Unknown
				//IL_0900: Unknown result type (might be due to invalid IL or missing references)
				//IL_0905: Expected Obj, but got Unknown
				//IL_0580: Unknown result type (might be due to invalid IL or missing references)
				//IL_0585: Expected Obj, but got Unknown
				//IL_058e: Expected Obj, but got I4
				//IL_05a2: Expected Obj, but got I4
				//IL_044e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0453: Expected Obj, but got Unknown
				//IL_045c: Expected Obj, but got I4
				//IL_0465: Unknown result type (might be due to invalid IL or missing references)
				//IL_046a: Expected Obj, but got Unknown
				//IL_0473: Expected Obj, but got I4
				//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
				//IL_06eb: Expected Obj, but got Unknown
				//IL_05f6: Expected I, but got Obj
				//IL_04c4: Expected I4, but got Obj
				//IL_0124: Unknown result type (might be due to invalid IL or missing references)
				//IL_0129: Expected Obj, but got Unknown
				//IL_063b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0640: Expected Obj, but got Unknown
				//IL_0660: Expected I, but got Obj
				//IL_0676: Expected Obj, but got I
				//IL_04b6: Expected I4, but got Obj
				//IL_0930: Unknown result type (might be due to invalid IL or missing references)
				//IL_0935: Expected Obj, but got Unknown
				//IL_0960: Expected Obj, but got I4
				//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
				//IL_04d4: Expected Obj, but got Unknown
				//IL_04dd: Expected Obj, but got I4
				//IL_06a1: Expected I, but got Obj
				//IL_01ea: Expected Obj, but got I
				//IL_01fa: Expected Obj, but got I
				//IL_020b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0210: Expected Obj, but got Unknown
				//IL_0219: Unknown result type (might be due to invalid IL or missing references)
				//IL_021e: Expected Obj, but got Unknown
				//IL_022e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0233: Expected Obj, but got Unknown
				//IL_0249: Expected Obj, but got I
				//IL_0259: Expected Obj, but got I
				//IL_0269: Expected Obj, but got I
				//IL_0272: Unknown result type (might be due to invalid IL or missing references)
				//IL_0277: Expected Obj, but got Unknown
				//IL_0280: Unknown result type (might be due to invalid IL or missing references)
				//IL_0285: Expected Obj, but got Unknown
				//IL_02af: Expected Obj, but got I
				//IL_02bf: Expected Obj, but got I
				//IL_02cf: Expected Obj, but got I
				//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_02dd: Expected Obj, but got Unknown
				//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
				//IL_02eb: Expected Obj, but got Unknown
				//IL_030d: Expected I, but got Obj
				//IL_0323: Expected Obj, but got I
				//IL_0788: Expected Obj, but got I
				//IL_0798: Expected Obj, but got I
				//IL_07a8: Expected Obj, but got I
				//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_07b6: Expected Obj, but got Unknown
				//IL_07bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_07c4: Expected Obj, but got Unknown
				//IL_0800: Expected Obj, but got I
				//IL_0810: Expected Obj, but got I
				//IL_0820: Expected Obj, but got I
				//IL_0829: Unknown result type (might be due to invalid IL or missing references)
				//IL_082e: Expected Obj, but got Unknown
				//IL_0837: Unknown result type (might be due to invalid IL or missing references)
				//IL_083c: Expected Obj, but got Unknown
				//IL_0851: Unknown result type (might be due to invalid IL or missing references)
				//IL_0856: Expected Obj, but got Unknown
				//IL_03a3: Expected Obj, but got I
				//IL_03b3: Expected Obj, but got I
				//IL_03c3: Expected Obj, but got I
				//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
				//IL_03d1: Expected Obj, but got Unknown
				//IL_03da: Unknown result type (might be due to invalid IL or missing references)
				//IL_03df: Expected Obj, but got Unknown
				//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f7: Expected Obj, but got Unknown
				//IL_0408: Unknown result type (might be due to invalid IL or missing references)
				//IL_040d: Expected Obj, but got Unknown
				//IL_0413: Unknown result type (might be due to invalid IL or missing references)
				//IL_0418: Expected Obj, but got Unknown
				//IL_034e: Expected I, but got Obj
				ref GameCenterPlugin.LocalPlayer reference = default;
				object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 16));
				GameCenterKilooAuthPlatform gameCenterKilooAuthPlatform = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							GameCenterGenerateIdentityVerificationSignatureRequest gameCenterGenerateIdentityVerificationSignatureRequest = _003CsignatureRequest_003E5__3;
							if (((GameCenterRequest)gameCenterGenerateIdentityVerificationSignatureRequest).error__BackingField == null)
							{
								object obj2 = this + 20;
								if (obj2 != null)
								{
									GameCenterGenerateIdentityVerificationSignatureRequest gameCenterGenerateIdentityVerificationSignatureRequest2 = _003CsignatureRequest_003E5__3;
									if (gameCenterGenerateIdentityVerificationSignatureRequest2.publicKeyUrl != null)
									{
										GameCenterGenerateIdentityVerificationSignatureRequest gameCenterGenerateIdentityVerificationSignatureRequest3 = _003CsignatureRequest_003E5__3;
										if (gameCenterGenerateIdentityVerificationSignatureRequest3.salt != null)
										{
											GameCenterGenerateIdentityVerificationSignatureRequest gameCenterGenerateIdentityVerificationSignatureRequest4 = _003CsignatureRequest_003E5__3;
											if (gameCenterGenerateIdentityVerificationSignatureRequest4.signature != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
												nint num = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S3_v6 (Il2CppMethodInfo)+C]");
												object obj3 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S3_v7+60]");
												object obj4 = 0;
												object obj5 = obj4;
												object obj6 = obj5 & 0x1FFF;
												object obj7 = obj6 + 113696;
												Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v257 @ S4_v8 (should have been resolved before IL gen)");
												object obj8 = this + 20;
												nint num2 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S4_v10 (Il2CppMethodInfo)+C]");
												object obj9 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S4_v11+60]");
												object obj10 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S4_v12+48]");
												object obj11 = 0;
												object obj12 = obj11 & 0x7FF;
												object obj13 = obj12 + 39195;
												Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v277 @ S5_v10 (should have been resolved before IL gen)");
												GameCenterGenerateIdentityVerificationSignatureRequest gameCenterGenerateIdentityVerificationSignatureRequest5 = _003CsignatureRequest_003E5__3;
												nint num3 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S4_v15 (Il2CppMethodInfo)+C]");
												object obj14 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S4_v16+60]");
												object obj15 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S4_v17+48]");
												object obj16 = 0;
												object obj17 = obj16 & 0x7FF;
												object obj18 = obj17 + 39195;
												Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v297 @ S5_v14 (should have been resolved before IL gen)");
												GameCenterGenerateIdentityVerificationSignatureRequest gameCenterGenerateIdentityVerificationSignatureRequest6 = _003CsignatureRequest_003E5__3;
												nint num4 = (nint)typeof(Convert);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S1_v66 (Il2CppClass<System.Convert>)+BA]");
												object obj19 = (nint)0 & (nint)0x200;
												if (obj19 != null)
												{
													nint num5 = (nint)typeof(Convert);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ S1_v88 (Il2CppClass<System.Convert>)+74]");
													if ((nint)0 == 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
													}
												}
												byte[] array = Convert.FromBase64String((string)(object)gameCenterGenerateIdentityVerificationSignatureRequest6.salt);
												nint num6 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S4_v20 (Il2CppMethodInfo)+C]");
												object obj20 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ S4_v21+60]");
												object obj21 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S4_v22+48]");
												object obj22 = 0;
												object obj23 = obj22 & 0x7FF;
												object obj24 = obj23 + 39195;
												Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v352 @ S5_v18 (should have been resolved before IL gen)");
												GameCenterGenerateIdentityVerificationSignatureRequest gameCenterGenerateIdentityVerificationSignatureRequest7 = _003CsignatureRequest_003E5__3;
												byte[] array2 = Convert.FromBase64String((string)(object)gameCenterGenerateIdentityVerificationSignatureRequest7.signature);
												nint num7 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ S4_v25 (Il2CppMethodInfo)+C]");
												object obj25 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ S4_v26+60]");
												object obj26 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ S4_v27+48]");
												object obj27 = 0;
												object obj28 = obj27 & 0x7FF;
												object obj29 = obj28 + 39195;
												Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v387 @ S5_v22 (should have been resolved before IL gen)");
												object obj30 = _003CsignatureRequest_003E5__3 + 32;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @110F0");
												nint num8 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ S4_v30 (Il2CppMethodInfo)+C]");
												object obj31 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ S4_v31+60]");
												object obj32 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ S4_v32+48]");
												object obj33 = 0;
												object obj34 = obj33 & 0x7FF;
												object obj35 = obj34 + 39195;
												Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v204 @ S5_v26 (should have been resolved before IL gen)");
												object obj36 = gameCenterKilooAuthPlatform + 12;
												object obj37 = default;
												obj36 = obj37;
												object obj38 = gameCenterKilooAuthPlatform + 16;
												object list = this + 20;
												Coroutine s = CoroutineUtil.WaitForAll((IEnumerable<YieldInstruction>)list);
												byte[] array3 = Convert.FromBase64String((string)(object)s);
												obj38 = array3;
												goto IL_04c9;
											}
										}
									}
								}
							}
							object obj39 = gameCenterKilooAuthPlatform + 12;
							obj39 = 0;
							object obj40 = gameCenterKilooAuthPlatform + 16;
							obj40 = 0;
							GameCenterGenerateIdentityVerificationSignatureRequest gameCenterGenerateIdentityVerificationSignatureRequest8 = _003CsignatureRequest_003E5__3;
							int totalLength;
							if (((GameCenterRequest)gameCenterGenerateIdentityVerificationSignatureRequest8).error__BackingField != null)
							{
								GameCenterGenerateIdentityVerificationSignatureRequest gameCenterGenerateIdentityVerificationSignatureRequest9 = _003CsignatureRequest_003E5__3;
								totalLength = (int)((GameCenterRequest)gameCenterGenerateIdentityVerificationSignatureRequest9).error__BackingField;
							}
							else
							{
								totalLength = (int)"Invalid data";
							}
							string text = string.ConcatArray((string[])(object)"Failed to get GameCenter identity verification signature: ", totalLength);
							((GameCenterKilooAuthPlatform)(object)text)._002Ector();
							goto IL_04c9;
						}
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					nint num9 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v76 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
					object obj41 = (nint)0 & (nint)0x200;
					if (obj41 != null)
					{
						nint num10 = (nint)typeof(GameCenterPlugin);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v82 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (!GameCenterPlugin.hasLoginView)
					{
						goto IL_06fa;
					}
				}
				nint num11 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v23 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
				object obj42 = (nint)0 & (nint)0x200;
				if (obj42 != null)
				{
					nint num12 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v70 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (!GameCenterPlugin.ArePhotosSupported())
				{
					object obj43 = this + 12;
					obj43 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				nint num13 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v31 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
				object obj44 = (nint)0 & (nint)0x200;
				if (obj44 != null)
				{
					nint num14 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v62 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				GameCenterPlugin.GetLocalPlayer(ref reference);
				obj = reference;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (LocalPlayer&)+8]");
				_ = 0;
				object obj45 = this + 20;
				obj45 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				object obj46 = this + 20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S0_v42+D]");
				if ((nint)0 != 0)
				{
					object obj47 = this + 36;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj48 = default;
					obj47 = obj48;
					nint num15 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ S0_v50 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
					object obj49 = (nint)0 & (nint)0x200;
					if (obj49 != null)
					{
						nint num16 = (nint)typeof(GameCenterPlugin);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S0_v58 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj50 = this + 12;
					IEnumerator enumerator = GameCenterPlugin.GenerateIdentityVerificationSignatureCoroutine(_003CsignatureRequest_003E5__3);
					obj50 = enumerator;
					_003C_003E1__state = 2;
					return 1;
				}
				goto IL_06e0;
				IL_06fa:
				gameCenterKilooAuthPlatform._updated = true;
				return null;
				IL_06e0:
				object obj51 = this + 20;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
				goto IL_06fa;
				IL_04c9:
				object obj52 = this + 36;
				obj52 = 0;
				goto IL_06e0;
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

	public const string NAME = "GameCenter";

	private bool _updated;

	private Dictionary<string, string> _value;

	private string _signature;

	public string name
	{
		get
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			string text = default;
			text.m_stringLength = 0;
			object obj = text + 16;
			obj = this;
			return text;
		}
	}

	public IDictionary<string, string> value => (IDictionary<string, string>)(object)"GameCenter";

	public string signature
	{
		get
		{
			LogError((string)(object)this);
			return (string)(object)_value;
		}
	}

	public Coroutine UpdateAsync()
	{
		LogError((string)(object)this);
		return (Coroutine)(object)_signature;
	}

	private IEnumerator UpdateAsyncCoroutine()
	{
		//IL_0013: Expected Obj, but got I4
		bool profileIsUpdated = ((GoogleSignInPlugin)this).profileIsUpdated;
		return (IEnumerator)(object)CoroutineUtil.WaitForAll((YieldInstruction[])profileIsUpdated);
	}

	private void IsUpdatedOrThrow()
	{
	}

	private static void LogError(string msg)
	{
		if (msg.m_stringLength == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			InvalidProgramException ex = default;
			ex._002Ector("Not ready.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public GameCenterKilooAuthPlatform()
	{
		//IL_005d: Expected I4, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string exception = string.ConcatArray((string[])(object)"[GameCenterKilooAuthPlatform] ", (int)this);
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
}

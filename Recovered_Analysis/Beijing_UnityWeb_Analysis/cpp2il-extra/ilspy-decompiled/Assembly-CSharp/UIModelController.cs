using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AnimationOrTween;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using InApp;
using Info;
using Kiloo.Common.Extensions;
using SYBO.Subway.Info;
using UI.Generic;
using UI.MessageCenter;
using UI.ModelCamera;
using UI.Screens.NotEnoughCurrencyPopupInternal;
using UnityEngine;
using UnityEngine.U2D;

public class UIModelController : MonoBehaviour
{
	public enum ModelScreen
	{
		Character,
		GameOver,
		TutorialPopup,
		Popup,
		Boards,
		CelebrationCharacterUnlock,
		CelebrationBoardUnlock,
		CelebrationHighScore,
		DuelResultPopup,
		CelebrationTopRun,
		LimitedCharacterPopup,
		LimitedBoardPopup,
		BoardPromotionPopup,
		FirstPurchaseBonusBigCharacter,
		CloudSaveReminderPopup,
		CharacterPromotionPopup
	}

	private sealed class _003CAnimateRunningCharacterForBragCelebration_003Ed__79(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject model;

		public UIModelController _003C_003E4__this;

		private CharacterAnimationControl _003C_charAnimCtrl_003E5__2;

		private float _003Cfactor_003E5__3;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c4: Expected Obj, but got Unknown
				//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_03d2: Expected VT, but got Unknown
				//IL_03db: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e0: Expected Obj, but got Unknown
				//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ee: Expected Obj, but got Unknown
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_0055: Expected Obj, but got I
				//IL_0066: Unknown result type (might be due to invalid IL or missing references)
				//IL_006b: Expected Obj, but got Unknown
				//IL_0074: Unknown result type (might be due to invalid IL or missing references)
				//IL_0079: Expected Obj, but got Unknown
				//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00aa: Expected Obj, but got Unknown
				//IL_00b7: Expected F4, but got Obj
				//IL_00b2: Expected native int or pointer, but got VT
				//IL_00cc: Expected F4, but got I
				//IL_00c7: Expected native int or pointer, but got VT
				//IL_00d9: Expected Obj, but got F4
				//IL_00eb: Expected I, but got F4
				//IL_0193: Expected I, but got Obj
				//IL_01a9: Expected Obj, but got I
				//IL_01d4: Expected I, but got Obj
				//IL_02df: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e4: Expected Obj, but got Unknown
				//IL_0304: Unknown result type (might be due to invalid IL or missing references)
				//IL_0309: Expected Obj, but got Unknown
				//IL_032c: Expected I, but got Obj
				//IL_0342: Expected Obj, but got I
				//IL_04b5: Expected F4, but got Obj
				//IL_04b0: Expected native int or pointer, but got VT
				//IL_04ca: Expected F4, but got I
				//IL_04c5: Expected native int or pointer, but got VT
				//IL_04f8: Expected VT, but got Obj
				//IL_052c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0531: Expected Obj, but got Unknown
				//IL_053a: Expected Obj, but got I4
				//IL_054e: Expected Obj, but got I4
				//IL_036d: Expected I, but got Obj
				object obj = default;
				Transform transform = (Transform)(obj + 48);
				Vector3 vector = (Vector3)(obj + 36);
				object obj2 = obj + 24;
				object obj3 = obj + 12;
				UIModelController uIModelController = _003C_003E4__this;
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
					object obj4 = this + 24;
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S3_v13 (Il2CppMethodInfo)+18]");
					object obj5 = 0;
					object obj6 = obj5;
					object obj7 = obj6 & 0x1FFF;
					object obj8 = obj7 + 22691;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v59 @ S4_v10 (should have been resolved before IL gen)");
					object obj9 = default;
					obj4 = obj9;
					int layer = model.layer;
					object obj10 = _003C_003E4__this + 148;
					((Vector3*)(nint)vector)->x = (float)obj10;
					Vector3 vector2 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S2_v44+8]");
					((Vector3*)(nint)vector2)->z = 0f;
					transform = (Transform)vector.x;
					((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)vector.z;
					Vector3 eulerAngles = transform.eulerAngles;
					_003Cfactor_003E5__3 = 0f;
				}
				if (_003Cfactor_003E5__3 < 1f)
				{
					float unscaledTime = Time.unscaledTime;
					float num2 = unscaledTime / 3.5f;
					float num3 = _003Cfactor_003E5__3 + num2;
					_003Cfactor_003E5__3 = num3;
					nint num4 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v30 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj11 = (nint)0 & (nint)0x200;
					if (obj11 != null)
					{
						nint num5 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v53 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num6;
					if (_003Cfactor_003E5__3 < 0f)
					{
						num6 = 0f;
					}
					else
					{
						num6 = ((!(_003Cfactor_003E5__3 > 1f)) ? _003Cfactor_003E5__3 : 1f);
					}
					_003Cfactor_003E5__3 = num6;
					float t = ((UITweener)(object)uIModelController.celebrationBackgroundHelper).BounceLogic(_003Cfactor_003E5__3);
					float t2 = 1f - _003Cfactor_003E5__3;
					float countdownInSeconds = Mathf.LerpUnclamped(0.5f, 3.5f, t2);
					((CountdownPopupManager)(object)uIModelController.celebrationBackgroundHelper).CountdownInSeconds = countdownInSeconds;
					float num7 = _003Cfactor_003E5__3 * 3.5f;
					float t3 = num7 * 0.5f;
					float t4 = Mathf.LerpUnclamped(3f, 1f, t3);
					_003C_charAnimCtrl_003E5__2._002Ector();
					((CharacterRenderingEffects)(object)_003C_charAnimCtrl_003E5__2)._003CPlayDoubleJumpThruster_003Eb__36_0(t4);
					int layer2 = model.layer;
					object obj12 = _003C_003E4__this + 148;
					obj2 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S2_v17+8]");
					_ = 0;
					object obj13 = _003C_003E4__this + 136;
					obj3 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S2_v22+8]");
					_ = 0;
					nint num8 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S1_v31 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num9 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S1_v46 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Vector3*)(nint)vector)->x = (float)obj2;
					Vector3 vector3 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					((Vector3*)(nint)vector3)->z = 0f;
					transform = (Transform)obj3;
					Transform transform2 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
					((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
					Vector3 vector4 = Vector3.LerpUnclamped(vector, (Vector3)transform, t);
					transform = (Transform)obj;
					Transform transform3 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
					Vector3 eulerAngles2 = transform.eulerAngles;
					object obj15 = this + 12;
					obj15 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
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

	private sealed class _003CAnimateUnlockBackground_003Ed__80(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UIModelController _003C_003E4__this;

		public GameObject go;

		private Vector3 _003CcharWithBoardPosition_003E5__2;

		private Vector3 _003Crotation1CharWithBoard_003E5__3;

		private Vector3 _003Crotation2CharWithBoard_003E5__4;

		private Vector3 _003Crotation3CharWithBoard_003E5__5;

		private Vector3 _003Coffset1PosBoard_003E5__6;

		private Vector3 _003Coffset2PosBoard_003E5__7;

		private Vector3 _003Coffset3PosBoard_003E5__8;

		private Vector3 _003CcharPosition_003E5__9;

		private Vector3 _003Crotation1character_003E5__10;

		private Vector3 _003Crotation2character_003E5__11;

		private Vector3 _003Crotation3character_003E5__12;

		private Vector3 _003Coffset1PosCharacter_003E5__13;

		private Vector3 _003Coffset2PosCharacter_003E5__14;

		private Vector3 _003Coffset3PosCharacter_003E5__15;

		private Vector3 _003Coffset1BgRotationCharScreen_003E5__16;

		private Vector3 _003Coffset2BgRotationCharScreen_003E5__17;

		private Vector3 _003Coffset3BgRotationCharScreen_003E5__18;

		private int _003Cindex_003E5__19;

		private Vector3 _003CcurrentBackgroundRotationOffset_003E5__20;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0ee4: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ee9: Expected Ref, but got Unknown
				//IL_0ef2: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ef7: Expected Ref, but got Unknown
				//IL_0f00: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f05: Expected Ref, but got Unknown
				//IL_0f0e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f13: Expected I4, but got Unknown
				//IL_0f1c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f21: Expected Obj, but got Unknown
				//IL_0f2a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f2f: Expected Obj, but got Unknown
				//IL_0f38: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f3d: Expected Obj, but got Unknown
				//IL_0f46: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f4b: Expected Obj, but got Unknown
				//IL_0f54: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f59: Expected Obj, but got Unknown
				//IL_0f62: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f67: Expected Obj, but got Unknown
				//IL_0f70: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f75: Expected Obj, but got Unknown
				//IL_0f7e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f83: Expected Obj, but got Unknown
				//IL_0f8c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f91: Expected Obj, but got Unknown
				//IL_0f9a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f9f: Expected Obj, but got Unknown
				//IL_0fa8: Unknown result type (might be due to invalid IL or missing references)
				//IL_0fad: Expected Obj, but got Unknown
				//IL_0fb6: Unknown result type (might be due to invalid IL or missing references)
				//IL_0fbb: Expected Obj, but got Unknown
				//IL_0fc4: Unknown result type (might be due to invalid IL or missing references)
				//IL_0fc9: Expected Obj, but got Unknown
				//IL_0fd2: Unknown result type (might be due to invalid IL or missing references)
				//IL_0fd7: Expected Obj, but got Unknown
				//IL_0fe0: Unknown result type (might be due to invalid IL or missing references)
				//IL_0fe5: Expected Obj, but got Unknown
				//IL_0fee: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ff3: Expected Obj, but got Unknown
				//IL_0ffc: Unknown result type (might be due to invalid IL or missing references)
				//IL_1001: Expected Obj, but got Unknown
				//IL_100a: Unknown result type (might be due to invalid IL or missing references)
				//IL_100f: Expected Obj, but got Unknown
				//IL_1018: Unknown result type (might be due to invalid IL or missing references)
				//IL_101d: Expected Obj, but got Unknown
				//IL_1026: Expected Obj, but got I4
				//IL_1035: Unknown result type (might be due to invalid IL or missing references)
				//IL_103a: Expected Obj, but got Unknown
				//IL_1043: Expected Obj, but got I4
				//IL_1052: Unknown result type (might be due to invalid IL or missing references)
				//IL_1057: Expected Obj, but got Unknown
				//IL_1060: Expected Obj, but got I4
				//IL_106f: Unknown result type (might be due to invalid IL or missing references)
				//IL_1074: Expected Obj, but got Unknown
				//IL_107d: Expected Obj, but got I4
				//IL_004c: Expected Ref, but got F4
				//IL_0065: Expected Ref, but got VT
				//IL_0078: Unknown result type (might be due to invalid IL or missing references)
				//IL_007d: Expected Obj, but got Unknown
				//IL_008a: Expected Obj, but got VT
				//IL_00af: Expected Ref, but got F4
				//IL_00c8: Expected Ref, but got VT
				//IL_00db: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e0: Expected Obj, but got Unknown
				//IL_00ed: Expected Obj, but got VT
				//IL_011c: Expected I4, but got F4
				//IL_0148: Unknown result type (might be due to invalid IL or missing references)
				//IL_014d: Expected Obj, but got Unknown
				//IL_015a: Expected Obj, but got VT
				//IL_0170: Expected Obj, but got I4
				//IL_017f: Expected Obj, but got F4
				//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ab: Expected Obj, but got Unknown
				//IL_01b8: Expected Obj, but got VT
				//IL_01ce: Expected Obj, but got F4
				//IL_01e3: Expected Obj, but got I4
				//IL_01f2: Expected Obj, but got F4
				//IL_0219: Unknown result type (might be due to invalid IL or missing references)
				//IL_021e: Expected Obj, but got Unknown
				//IL_022b: Expected Obj, but got VT
				//IL_0241: Expected Obj, but got I4
				//IL_0250: Expected Obj, but got F4
				//IL_0277: Unknown result type (might be due to invalid IL or missing references)
				//IL_027c: Expected Obj, but got Unknown
				//IL_0289: Expected Obj, but got VT
				//IL_029f: Expected Obj, but got I4
				//IL_02ae: Expected Obj, but got F4
				//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
				//IL_02da: Expected Obj, but got Unknown
				//IL_02e7: Expected Obj, but got VT
				//IL_02fd: Expected Obj, but got I4
				//IL_030c: Expected Obj, but got F4
				//IL_0333: Unknown result type (might be due to invalid IL or missing references)
				//IL_0338: Expected Obj, but got Unknown
				//IL_0345: Expected Obj, but got VT
				//IL_035b: Expected Obj, but got I4
				//IL_036a: Expected Obj, but got F4
				//IL_0391: Unknown result type (might be due to invalid IL or missing references)
				//IL_0396: Expected Obj, but got Unknown
				//IL_03a3: Expected Obj, but got VT
				//IL_03b9: Expected Obj, but got I4
				//IL_03c8: Expected Obj, but got F4
				//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f4: Expected Obj, but got Unknown
				//IL_0401: Expected Obj, but got VT
				//IL_0417: Expected Obj, but got I4
				//IL_0426: Expected Obj, but got F4
				//IL_044d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0452: Expected Obj, but got Unknown
				//IL_045f: Expected Obj, but got VT
				//IL_0475: Expected Obj, but got I4
				//IL_0484: Expected Obj, but got F4
				//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
				//IL_04b0: Expected Obj, but got Unknown
				//IL_04bd: Expected Obj, but got VT
				//IL_04d3: Expected Obj, but got I4
				//IL_04e2: Expected Obj, but got F4
				//IL_0509: Unknown result type (might be due to invalid IL or missing references)
				//IL_050e: Expected Obj, but got Unknown
				//IL_051b: Expected Obj, but got VT
				//IL_0531: Expected Obj, but got I4
				//IL_0540: Expected Obj, but got F4
				//IL_0567: Unknown result type (might be due to invalid IL or missing references)
				//IL_056c: Expected Obj, but got Unknown
				//IL_0579: Expected Obj, but got VT
				//IL_058f: Expected Obj, but got I4
				//IL_059e: Expected Obj, but got F4
				//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
				//IL_05ca: Expected Obj, but got Unknown
				//IL_05d7: Expected Obj, but got VT
				//IL_05ed: Expected Obj, but got I4
				//IL_05fc: Expected Obj, but got F4
				//IL_0623: Unknown result type (might be due to invalid IL or missing references)
				//IL_0628: Expected Obj, but got Unknown
				//IL_0635: Expected Obj, but got VT
				//IL_064b: Expected Obj, but got I4
				//IL_065a: Expected Obj, but got F4
				//IL_0681: Unknown result type (might be due to invalid IL or missing references)
				//IL_0686: Expected Obj, but got Unknown
				//IL_0693: Expected Obj, but got VT
				//IL_06b4: Expected Obj, but got F4
				//IL_06c9: Expected Obj, but got F4
				//IL_06de: Expected Obj, but got I4
				//IL_06ed: Expected Obj, but got F4
				//IL_0714: Unknown result type (might be due to invalid IL or missing references)
				//IL_0719: Expected Obj, but got Unknown
				//IL_0726: Expected Obj, but got VT
				//IL_073c: Expected Obj, but got F4
				//IL_08bf: Expected Obj, but got I4
				//IL_08c9: Unknown result type (might be due to invalid IL or missing references)
				//IL_08ce: Expected Obj, but got Unknown
				//IL_0788: Expected Ref, but got F4
				//IL_07a1: Expected Ref, but got VT
				//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
				//IL_07b9: Expected Obj, but got Unknown
				//IL_07c6: Expected Obj, but got VT
				//IL_0a50: Unknown result type (might be due to invalid IL or missing references)
				//IL_0a55: Expected Obj, but got Unknown
				//IL_0a77: Expected Obj, but got VT
				//IL_0a8a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0a8f: Expected Obj, but got Unknown
				//IL_0ab1: Expected Obj, but got VT
				//IL_0ac4: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ac9: Expected Obj, but got Unknown
				//IL_0aeb: Expected Obj, but got VT
				//IL_0800: Invalid comparison between I4 and F4
				//IL_0939: Unknown result type (might be due to invalid IL or missing references)
				//IL_093e: Expected Obj, but got Unknown
				//IL_0960: Expected Obj, but got VT
				//IL_0973: Unknown result type (might be due to invalid IL or missing references)
				//IL_0978: Expected Obj, but got Unknown
				//IL_099a: Expected Obj, but got VT
				//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_09b2: Expected Obj, but got Unknown
				//IL_09bf: Expected I4, but got Obj
				//IL_09ec: Unknown result type (might be due to invalid IL or missing references)
				//IL_09f1: Expected Obj, but got Unknown
				//IL_09fe: Expected Obj, but got VT
				//IL_0a11: Unknown result type (might be due to invalid IL or missing references)
				//IL_0a16: Expected Obj, but got Unknown
				//IL_0a38: Expected Obj, but got VT
				//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_10cc: Expected Obj, but got Unknown
				//IL_10e7: Unknown result type (might be due to invalid IL or missing references)
				//IL_10ec: Expected Obj, but got Unknown
				//IL_1107: Unknown result type (might be due to invalid IL or missing references)
				//IL_110c: Expected Obj, but got Unknown
				//IL_1162: Expected I4, but got Obj
				//IL_11d5: Expected I4, but got Obj
				//IL_1233: Unknown result type (might be due to invalid IL or missing references)
				//IL_1238: Expected Obj, but got Unknown
				//IL_128e: Expected I4, but got Obj
				//IL_1301: Expected I4, but got Obj
				//IL_1331: Unknown result type (might be due to invalid IL or missing references)
				//IL_1336: Expected Obj, but got Unknown
				//IL_1352: Expected Obj, but got I4
				//IL_0c3f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0c44: Expected Obj, but got Unknown
				//IL_0c66: Expected Obj, but got VT
				//IL_0c79: Unknown result type (might be due to invalid IL or missing references)
				//IL_0c7e: Expected Obj, but got Unknown
				//IL_0ca0: Expected Obj, but got VT
				//IL_0cb3: Unknown result type (might be due to invalid IL or missing references)
				//IL_0cb8: Expected Obj, but got Unknown
				//IL_0cda: Expected Obj, but got VT
				//IL_0837: Expected Ref, but got F4
				//IL_0850: Expected Ref, but got VT
				//IL_0863: Unknown result type (might be due to invalid IL or missing references)
				//IL_0868: Expected Obj, but got Unknown
				//IL_0875: Expected Obj, but got VT
				//IL_0b28: Unknown result type (might be due to invalid IL or missing references)
				//IL_0b2d: Expected Obj, but got Unknown
				//IL_0b4f: Expected Obj, but got VT
				//IL_0b62: Unknown result type (might be due to invalid IL or missing references)
				//IL_0b67: Expected Obj, but got Unknown
				//IL_0b89: Expected Obj, but got VT
				//IL_0b9c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ba1: Expected Obj, but got Unknown
				//IL_0bae: Expected I4, but got Obj
				//IL_0bdb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0be0: Expected Obj, but got Unknown
				//IL_0bed: Expected Obj, but got VT
				//IL_0c00: Unknown result type (might be due to invalid IL or missing references)
				//IL_0c05: Expected Obj, but got Unknown
				//IL_0c27: Expected Obj, but got VT
				//IL_0e2e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e33: Expected Obj, but got Unknown
				//IL_0e55: Expected Obj, but got VT
				//IL_0e68: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e6d: Expected Obj, but got Unknown
				//IL_0e8f: Expected Obj, but got VT
				//IL_0ea2: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ea7: Expected Obj, but got Unknown
				//IL_0ec9: Expected Obj, but got VT
				//IL_0d17: Unknown result type (might be due to invalid IL or missing references)
				//IL_0d1c: Expected Obj, but got Unknown
				//IL_0d3e: Expected Obj, but got VT
				//IL_0d51: Unknown result type (might be due to invalid IL or missing references)
				//IL_0d56: Expected Obj, but got Unknown
				//IL_0d78: Expected Obj, but got VT
				//IL_0d8b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0d90: Expected Obj, but got Unknown
				//IL_0d9d: Expected I4, but got Obj
				//IL_0dca: Unknown result type (might be due to invalid IL or missing references)
				//IL_0dcf: Expected Obj, but got Unknown
				//IL_0ddc: Expected Obj, but got VT
				//IL_0def: Unknown result type (might be due to invalid IL or missing references)
				//IL_0df4: Expected Obj, but got Unknown
				//IL_0e16: Expected Obj, but got VT
				object obj = default;
				ref Vector3 reference = ref *(Vector3*)(obj + 312);
				ref Vector3 reference2 = ref *(Vector3*)(obj + 300);
				ref Matrix4x4 reference3 = ref *(Matrix4x4*)(obj + 288);
				bool flag = (byte)(obj + 276) != 0;
				object obj2 = obj + 168;
				object obj3 = obj + 156;
				object obj4 = obj + 144;
				object obj5 = obj + 132;
				object obj6 = obj + 120;
				object obj7 = obj + 108;
				object obj8 = obj + 96;
				object obj9 = obj + 84;
				object obj10 = obj + 72;
				object obj11 = obj + 60;
				object obj12 = obj + 48;
				object obj13 = obj + 36;
				object obj14 = obj + 24;
				object obj15 = obj + 12;
				object obj16 = obj + 264;
				object obj17 = obj + 252;
				object obj18 = obj + 240;
				object obj19 = obj + 228;
				object obj20 = obj + 216;
				obj20 = 0;
				_ = 0;
				object obj21 = obj + 204;
				obj21 = 0;
				_ = 0;
				object obj22 = obj + 192;
				obj22 = 0;
				_ = 0;
				object obj23 = obj + 180;
				obj23 = 0;
				_ = 0;
				UIModelController content = _003C_003E4__this;
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
					reference2 = ref *(Vector3*)null;
					_ = 0;
					reference2 = ref *(Vector3*)(-80f);
					_ = -100f;
					_ = 0f;
					reference = ref *(Vector3*)reference2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector3&)+8]");
					_ = 0;
					object obj24 = this + 24;
					obj24 = reference;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
					_ = 0;
					reference3 = ref *(Matrix4x4*)null;
					_ = 0;
					reference3 = ref *(Matrix4x4*)35f;
					_ = 205f;
					_ = 16f;
					reference = ref *(Vector3*)reference3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Matrix4x4&)+8]");
					_ = 0;
					object obj25 = this + 36;
					obj25 = reference;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
					_ = 0;
					((bool*)(flag ? 1 : 0))->m_value = false;
					_ = 0;
					((bool*)(flag ? 1 : 0))->m_value = false;
					_ = 100f;
					_ = 10f;
					reference = ref *(((bool*)(flag ? 1 : 0))->m_value ? ((Vector3*)1) : ((Vector3*)null));
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (System.Boolean)+8]");
					_ = 0;
					object obj26 = this + 48;
					obj26 = reference;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
					_ = 0;
					obj2 = 0;
					_ = 0;
					obj2 = -5f;
					_ = -125f;
					_ = 0f;
					reference = ref *(Vector3*)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
					_ = 0;
					object obj27 = this + 60;
					obj27 = reference;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
					_ = 0;
					obj20 = -5f;
					_ = -145f;
					_ = 0f;
					obj3 = 0;
					_ = 0;
					obj3 = 0f;
					_ = 0f;
					_ = -30f;
					reference = ref *(Vector3*)obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
					_ = 0;
					object obj28 = this + 72;
					obj28 = reference;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
					_ = 0;
					obj4 = 0;
					_ = 0;
					obj4 = 0f;
					_ = 0f;
					_ = -170f;
					reference = ref *(Vector3*)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
					_ = 0;
					object obj29 = this + 84;
					obj29 = reference;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
					_ = 0;
					obj5 = 0;
					_ = 0;
					obj5 = 0f;
					_ = 0f;
					_ = -100f;
					reference = ref *(Vector3*)obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
					_ = 0;
					object obj30 = this + 96;
					obj30 = reference;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
					_ = 0;
					obj6 = 0;
					_ = 0;
					obj6 = -85f;
					_ = -110f;
					_ = 0f;
					reference = ref *(Vector3*)obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
					_ = 0;
					object obj31 = this + 108;
					obj31 = reference;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
					_ = 0;
					obj7 = 0;
					_ = 0;
					obj7 = 0f;
					_ = 130f;
					_ = 0f;
					reference = ref *(Vector3*)obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27+8]");
					_ = 0;
					object obj32 = this + 120;
					obj32 = reference;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
					_ = 0;
					obj8 = 0;
					_ = 0;
					obj8 = 0f;
					_ = 180f;
					_ = 0f;
					reference = ref *(Vector3*)obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+8]");
					_ = 0;
					object obj33 = this + 132;
					obj33 = reference;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
					_ = 0;
					obj9 = 0;
					_ = 0;
					obj9 = 0f;
					_ = 240f;
					_ = 0f;
					reference = ref *(Vector3*)obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
					_ = 0;
					object obj34 = this + 144;
					obj34 = reference;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
					_ = 0;
					obj10 = 0;
					_ = 0;
					obj10 = -10f;
					_ = 0f;
					_ = -180f;
					reference = ref *(Vector3*)obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33+8]");
					_ = 0;
					object obj35 = this + 156;
					obj35 = reference;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
					_ = 0;
					obj11 = 0;
					_ = 0;
					obj11 = 0f;
					_ = 0f;
					_ = -200f;
					reference = ref *(Vector3*)obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v35+8]");
					_ = 0;
					object obj36 = this + 168;
					obj36 = reference;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
					_ = 0;
					obj12 = 0;
					_ = 0;
					obj12 = 5f;
					_ = 0f;
					_ = -200f;
					reference = ref *(Vector3*)obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v37+8]");
					_ = 0;
					object obj37 = this + 180;
					obj37 = reference;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
					_ = 0;
					obj13 = 0;
					_ = 0;
					obj13 = 70f;
					_ = 20f;
					_ = 0f;
					reference = ref *(Vector3*)obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v39+8]");
					_ = 0;
					object obj38 = this + 192;
					obj38 = reference;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
					_ = 0;
					obj14 = 0;
					_ = 0;
					obj14 = 70f;
					_ = 0f;
					_ = 0f;
					reference = ref *(Vector3*)obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v41+8]");
					_ = 0;
					object obj39 = this + 204;
					obj39 = reference;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
					_ = 0;
					obj15 = 0;
					_ = 0;
					obj15 = 70f;
					_ = -30f;
					_ = 0f;
					reference = ref *(Vector3*)obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v43+8]");
					_ = 0;
					object obj40 = this + 216;
					obj40 = reference;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
					_ = 0;
					_003Cindex_003E5__19 = 0;
					obj21 = 0f;
					_ = 0f;
					_ = 0f;
					obj22 = 0f;
					_ = 0f;
					_ = 0f;
					obj = 0;
					_ = 0;
					obj = 0f;
					_ = 0f;
					_ = 0f;
					reference = ref *(Vector3*)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					object obj41 = this + 232;
					obj41 = reference;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
					_ = 0;
					obj23 = 0f;
					_ = 0f;
					_ = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v65 (UIModelController)+78]");
					if ((nint)0 == 7)
					{
						reference2 = ref *(Vector3*)null;
						_ = 0;
						reference2 = ref *(Vector3*)0f;
						_ = 20f;
						_ = 350f;
						reference = ref *(Vector3*)reference2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector3&)+8]");
						_ = 0;
						object obj42 = this + 232;
						obj42 = reference;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
						_ = 0;
						int sleepTimeout = Screen.sleepTimeout;
						int height = Screen.height;
						int num = sleepTimeout / height;
						if ((float)num > 2f)
						{
							reference2 = ref *(Vector3*)null;
							_ = 0;
							reference2 = ref *(Vector3*)0f;
							_ = -5f;
							_ = 350f;
							reference = ref *(Vector3*)reference2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector3&)+8]");
							_ = 0;
							object obj43 = this + 232;
							obj43 = reference;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
							_ = 0;
						}
						obj16 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v53+8]");
						_ = 0;
						object obj44 = this + 24;
						obj2 = obj44;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ S1_v581+8]");
						_ = 0;
						object obj45 = this + 96;
						obj3 = obj45;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ S1_v586+8]");
						_ = 0;
						object obj46 = this + 232;
						obj4 = obj46;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ S1_v591+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v65 (UIModelController)+5C]");
						bool flag2 = (nint)0 != 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v65 (UIModelController)+5E]");
						bool considerChildren = (nint)0 != 0;
						((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj16 != 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v45+8]");
						_ = 0;
						reference3 = ref *(Matrix4x4*)obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
						_ = 0;
						reference2 = ref *(Vector3*)obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
						_ = 0;
						reference = ref *(Vector3*)obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
						_ = 0;
						NGUIMath.CalculateRelativeWidgetBounds((Transform)(object)content, (byte)(int)go != 0, flag, ref reference3, ref reference2, ref reference, ref *(flag2 ? ((bool*)1) : ((bool*)null)), considerChildren);
						return null;
					}
				}
				int num2 = _003Cindex_003E5__19 / 3;
				object obj47 = num2 * 3;
				object obj48 = _003Cindex_003E5__19 - obj47;
				if (_003Cindex_003E5__19 != (nint)obj47)
				{
					if ((nint)obj48 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v65 (UIModelController)+5D]");
						if ((nint)0 != 0)
						{
							object obj49 = this + 132;
							reference2 = ref *(Vector3*)obj49;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v947 @ S1_v183+8]");
							_ = 0;
							obj21 = reference2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector3&)+8]");
							_ = 0;
							object obj50 = this + 168;
							reference3 = ref *(Matrix4x4*)obj50;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v962 @ S1_v192+8]");
							_ = 0;
							obj22 = reference3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Matrix4x4&)+8]");
							_ = 0;
							object obj51 = this + 204;
							((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj51 != 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ S1_v201+8]");
							_ = 0;
							reference = ref *(((bool*)(flag ? 1 : 0))->m_value ? ((Vector3*)1) : ((Vector3*)null));
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (System.Boolean)+8]");
							_ = 0;
							object obj52 = this + 232;
							obj52 = reference;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
							_ = 0;
							object obj53 = this + 108;
							reference = ref *(Vector3*)obj53;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1001 @ S1_v215+8]");
							_ = 0;
							obj23 = reference;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
							_ = 0;
						}
						else
						{
							object obj54 = this + 48;
							reference = ref *(Vector3*)obj54;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1016 @ S1_v156+8]");
							_ = 0;
							obj21 = reference;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
							_ = 0;
							object obj55 = this + 84;
							reference2 = ref *(Vector3*)obj55;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1031 @ S1_v165+8]");
							_ = 0;
							obj22 = reference2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector3&)+8]");
							_ = 0;
							object obj56 = this + 24;
							reference3 = ref *(Matrix4x4*)obj56;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1046 @ S1_v174+8]");
							_ = 0;
							obj23 = reference3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Matrix4x4&)+8]");
							_ = 0;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v65 (UIModelController)+5D]");
						if ((nint)0 != 0)
						{
							object obj57 = this + 144;
							reference2 = ref *(Vector3*)obj57;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1065 @ S1_v251+8]");
							_ = 0;
							obj21 = reference2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector3&)+8]");
							_ = 0;
							object obj58 = this + 180;
							reference3 = ref *(Matrix4x4*)obj58;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1080 @ S1_v260+8]");
							_ = 0;
							obj22 = reference3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Matrix4x4&)+8]");
							_ = 0;
							object obj59 = this + 216;
							((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj59 != 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1095 @ S1_v269+8]");
							_ = 0;
							reference = ref *(((bool*)(flag ? 1 : 0))->m_value ? ((Vector3*)1) : ((Vector3*)null));
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (System.Boolean)+8]");
							_ = 0;
							object obj60 = this + 232;
							obj60 = reference;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
							_ = 0;
							object obj61 = this + 108;
							reference = ref *(Vector3*)obj61;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1119 @ S1_v283+8]");
							_ = 0;
							obj23 = reference;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
							_ = 0;
						}
						else
						{
							object obj62 = this + 60;
							reference = ref *(Vector3*)obj62;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1134 @ S1_v224+8]");
							_ = 0;
							obj21 = reference;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
							_ = 0;
							object obj63 = this + 96;
							reference2 = ref *(Vector3*)obj63;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1149 @ S1_v233+8]");
							_ = 0;
							obj22 = reference2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector3&)+8]");
							_ = 0;
							object obj64 = this + 24;
							reference3 = ref *(Matrix4x4*)obj64;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1164 @ S1_v242+8]");
							_ = 0;
							obj23 = reference3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Matrix4x4&)+8]");
							_ = 0;
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v65 (UIModelController)+5D]");
					if ((nint)0 != 0)
					{
						object obj65 = this + 120;
						reference2 = ref *(Vector3*)obj65;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ S1_v114+8]");
						_ = 0;
						obj21 = reference2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector3&)+8]");
						_ = 0;
						object obj66 = this + 156;
						reference3 = ref *(Matrix4x4*)obj66;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ S1_v123+8]");
						_ = 0;
						obj22 = reference3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Matrix4x4&)+8]");
						_ = 0;
						object obj67 = this + 192;
						((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj67 != 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ S1_v132+8]");
						_ = 0;
						reference = ref *(((bool*)(flag ? 1 : 0))->m_value ? ((Vector3*)1) : ((Vector3*)null));
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (System.Boolean)+8]");
						_ = 0;
						object obj68 = this + 232;
						obj68 = reference;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
						_ = 0;
						object obj69 = this + 108;
						reference = ref *(Vector3*)obj69;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ S1_v146+8]");
						_ = 0;
						obj23 = reference;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
						_ = 0;
					}
					else
					{
						object obj70 = this + 36;
						reference = ref *(Vector3*)obj70;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ S1_v87+8]");
						_ = 0;
						obj21 = reference;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
						_ = 0;
						object obj71 = this + 72;
						reference2 = ref *(Vector3*)obj71;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ S1_v96+8]");
						_ = 0;
						obj22 = reference2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector3&)+8]");
						_ = 0;
						object obj72 = this + 24;
						reference3 = ref *(Matrix4x4*)obj72;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ S1_v105+8]");
						_ = 0;
						obj23 = reference3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Matrix4x4&)+8]");
						_ = 0;
					}
				}
				obj17 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v56+8]");
				_ = 0;
				obj18 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v62+8]");
				_ = 0;
				obj19 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v59+8]");
				_ = 0;
				object obj73 = this + 232;
				obj2 = obj73;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1207 @ S1_v55+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v65 (UIModelController)+5C]");
				bool flag3 = (nint)0 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v65 (UIModelController)+5E]");
				bool considerChildren2 = (nint)0 != 0;
				((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj17 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v47+8]");
				_ = 0;
				reference3 = ref *(Matrix4x4*)obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v49+8]");
				_ = 0;
				reference2 = ref *(Vector3*)obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v51+8]");
				_ = 0;
				reference = ref *(Vector3*)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				_ = 0;
				NGUIMath.CalculateRelativeWidgetBounds((Transform)(object)content, (byte)(int)go != 0, flag, ref reference3, ref reference2, ref reference, ref *(flag3 ? ((bool*)1) : ((bool*)null)), considerChildren2);
				int num3 = _003Cindex_003E5__19 + 1;
				_003Cindex_003E5__19 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 2.5f;
				object obj74 = this + 12;
				object obj75 = default;
				obj74 = obj75;
				_003C_003E1__state = 1;
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

		void IEnumerator.Reset()
		{
		}
	}

	public GameObject CharacterAnchor;

	public GameObject GameOverAnchor;

	public GameObject CelebrationPopupAnchor;

	public GameObject TutorialPopupAnchor;

	public GameObject HuntPrizeAnchor;

	public GameObject PauseScreenAnchor;

	public GameObject WeeklyHuntRewardAnchor;

	public GameObject DailyChallengeRewardAnchor;

	public GameObject FirstPurchaseBonusAnchor;

	public GameObject CharacterPromotionAnchor;

	private GameObject _maskedCharacterAnchor;

	private GameObject limitedCharacterPopupAnchor__BackingField;

	private GameObject limitedBoardPopupAnchor__BackingField;

	public GameObject ModelPrefab;

	public CelebrationBackgroundHelper celebrationBackgroundHelper;

	private AnimationClip _firstPurchaseBonusIdleAnimation;

	private AnimationClip _firstPurchaseBonusBreakDanceAnimation;

	private AnimationClip _firstPurchaseBonusBreakDanceAnimation2;

	private Dictionary<ModelScreen, ModelScreenData> _cachedModelScreenDataEntries;

	private const string CELEBRATION_STRIPE_COROUTINE_NAME = "AnimateUnlockBackground";

	private const string BRAG_CELEBRATION_ANIMATION_COROUTINE = "AnimateRunningCharacterForBragCelebration";

	private bool celebrationShouldAnimateStripes;

	private bool _isCelebrationCharacterScreen;

	private bool _isCelebrationBackgroundRotating;

	private Vector3 _discoBgRotation;

	private Vector3 _tunnerBgRotationNormal;

	private ModelScreen _currentActivatedScreenModel;

	private Boards.BoardId _currentMysteryBoxBoardId;

	private static Action m_OnChangedCurrentlyShownCharacter;

	private static Action m_OnChangedCurrentlyShownHoverboard;

	private int _currentlyShownThemeIndex;

	private Characters.CharacterId _currentlyShownModel;

	private Vector3 CHAR_TO_POS;

	private Vector3 CHAR_FROM_POS;

	private const float RUNNING_SPEED_HIGH = 3f;

	private const float RUNNING_SPEED_LOW = 1f;

	private const float DURATION = 3.5f;

	private const float PARTICLE_ANIMATION_SPEED_FACTOR_LOW = 0.5f;

	private const float PARTICLE_ANIMATION_SPEED_FACTOR_HIGH = 3.5f;

	private static UIModelController _instance;

	public GameObject limitedCharacterPopupAnchor
	{
		get
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			GameObject gameObject = default;
			((UnityEngine.Object)gameObject).m_CachedPtr = (IntPtr)0;
			object obj = gameObject + 16;
			obj = this;
			return gameObject;
		}
		set
		{
			//IL_0049: Expected Obj, but got I4
			string text;
			if ((object)value != null)
			{
				text = null;
			}
			else
			{
				bool flag = (object)PauseScreenAnchor != null;
				text = (string)((flag ? 1 : 0) ^ 1);
			}
			((Component)(object)HuntPrizeAnchor).tag = text;
		}
	}

	public GameObject limitedBoardPopupAnchor
	{
		get
		{
			return limitedCharacterPopupAnchor__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 56;
			obj = value;
		}
	}

	public GameObject BoardPromotionPopupAnchor
	{
		get
		{
			return limitedBoardPopupAnchor__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 60;
			obj = value;
		}
	}

	public int currentlyShownThemeIndex
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0010: Expected I4, but got Obj
			object obj = this - -64;
			return (int)obj;
		}
	}

	public Characters.CharacterId currentlyShownModel => (Characters.CharacterId)_currentlyShownThemeIndex;

	public unsafe static UIModelController Instance
	{
		get
		{
			//IL_0188: Expected I, but got Obj
			//IL_019e: Expected Obj, but got I
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Expected I, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_01d6: Expected I, but got Obj
			//IL_01f1: Expected I, but got Obj
			//IL_0207: Expected Obj, but got I
			//IL_0249: Expected I, but got Obj
			//IL_025f: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_00ee: Expected I, but got Obj
			//IL_013b: Expected I, but got Obj
			nint num = (nint)typeof(SlideinPowerupHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SlideinPowerupHelper>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SlideinPowerupHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v53 (Il2CppClass<SlideinPowerupHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = default;
			nint num3 = (nint)(obj2 + 4);
			bool flag = (object)SlideinPowerupHelper.instance == null;
			bool flag2 = !flag;
			UIModelController result = (UIModelController)(object)SlideinPowerupHelper.instance;
			if (!flag2)
			{
				nint num4 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v25 (Il2CppClass<System.Type>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num5 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v49 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = typeof(SlideinPowerupHelper);
				((IntPtr*)num3)->m_value = (void*)(nint)obj2;
				Type type = Type.internal_from_handle((IntPtr)num3);
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num7 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = ((UnityEngine.Object)(object)type).ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
				nint num8 = (nint)typeof(SlideinPowerupHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v36 (Il2CppClass<SlideinPowerupHelper>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num9 = (nint)typeof(SlideinPowerupHelper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v43 (Il2CppClass<SlideinPowerupHelper>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UIModelController uIModelController = default;
				SlideinPowerupHelper.instance = (SlideinPowerupHelper)(object)uIModelController;
				result = uIModelController;
			}
			return result;
		}
	}

	public static event Action OnChangedCurrentlyShownCharacter
	{
		add
		{
			//IL_0011: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (System.Action)+48]");
			((CelebrationBackgroundHelper)0).Update();
		}
		remove
		{
			Delegate onChangedCurrentlyShownCharacter = UIModelController.m_OnChangedCurrentlyShownCharacter;
			Action onChangedCurrentlyShownCharacter2 = default;
			while (true)
			{
				Delegate obj = onChangedCurrentlyShownCharacter.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				if ((object)UIModelController.m_OnChangedCurrentlyShownCharacter == onChangedCurrentlyShownCharacter)
				{
					UIModelController.m_OnChangedCurrentlyShownCharacter = onChangedCurrentlyShownCharacter2;
				}
				if ((object)UIModelController.m_OnChangedCurrentlyShownCharacter != onChangedCurrentlyShownCharacter)
				{
					onChangedCurrentlyShownCharacter = UIModelController.m_OnChangedCurrentlyShownCharacter;
					continue;
				}
				break;
			}
		}
	}

	public static event Action OnChangedCurrentlyShownHoverboard
	{
		add
		{
			Delegate onChangedCurrentlyShownCharacter = UIModelController.m_OnChangedCurrentlyShownCharacter;
			Action onChangedCurrentlyShownCharacter2 = default;
			while (true)
			{
				Delegate obj = onChangedCurrentlyShownCharacter.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				if ((object)UIModelController.m_OnChangedCurrentlyShownCharacter == onChangedCurrentlyShownCharacter)
				{
					UIModelController.m_OnChangedCurrentlyShownCharacter = onChangedCurrentlyShownCharacter2;
				}
				if ((object)UIModelController.m_OnChangedCurrentlyShownCharacter != onChangedCurrentlyShownCharacter)
				{
					onChangedCurrentlyShownCharacter = UIModelController.m_OnChangedCurrentlyShownCharacter;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = UIModelController.m_OnChangedCurrentlyShownHoverboard;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(UIModelController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<UIModelController>)+5C]");
				object obj3 = (nint)0 + (nint)4;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public void ActivateGameOverModel()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		Color black = Color.black;
		object obj2 = default;
		object obj = obj2 + 16;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj3 = this + 12;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+8]");
		_ = 0;
		CancelInvoke();
	}

	public GameObject ShowCharacterInCelebration(Characters.CharacterId charId, int themeIndex, ModelScreen screen, bool cache)
	{
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected Obj, but got Unknown
		//IL_02cd: Expected Obj, but got I4
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected Obj, but got Unknown
		//IL_02ea: Expected Obj, but got I4
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_0307: Expected Obj, but got I4
		//IL_0328: Expected Obj, but got I4
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected Obj, but got Unknown
		//IL_033f: Expected Obj, but got I4
		//IL_0012: Expected VT, but got I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		//IL_003b: Expected Obj, but got I4
		//IL_0051: Expected VT, but got I4
		//IL_006c: Expected Obj, but got I4
		//IL_0082: Expected VT, but got I4
		//IL_009d: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got I4
		//IL_00fa: Expected Obj, but got I4
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_0144: Expected Obj, but got I4
		//IL_0180: Expected Obj, but got I4
		//IL_01b3: Expected Obj, but got I4
		//IL_01bc: Expected Obj, but got I4
		//IL_01d3: Expected I, but got Obj
		//IL_01e9: Expected Obj, but got I
		//IL_0351: Expected Obj, but got I4
		//IL_0214: Expected I, but got Obj
		//IL_025c: Expected Obj, but got I4
		//IL_0271: Expected I4, but got Obj
		//IL_0271: Expected Obj, but got I4
		//IL_027f: Expected Obj, but got I4
		//IL_02a7: Expected Obj, but got I4
		Transform transform = default;
		object obj = transform + 72;
		obj = 0;
		_ = 0;
		object obj2 = transform + 56;
		obj2 = 0;
		_ = 0;
		object obj3 = transform + 44;
		obj3 = 0;
		_ = 0;
		RenderTextureCamera renderTextureCamera = ((RenderTextureManager)this).CreateNewCamera(cache);
		renderTextureCamera.ClearRenderTexture((RenderTexture)screen);
		Transform transform2 = (Transform)(transform + 32);
		int layer = ((GameObject)charId).layer;
		transform2.localPosition = (Vector3)layer;
		obj = transform2;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		Transform transform3 = (Transform)(transform + 16);
		int layer2 = ((GameObject)charId).layer;
		transform3.localRotation = (Quaternion)layer2;
		obj2 = transform3;
		_ = ((UnityEngine.Object)transform3).m_CachedPtr;
		int layer3 = ((GameObject)charId).layer;
		transform.localScale = (Vector3)layer3;
		obj3 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		int layer4 = ((GameObject)charId).layer;
		string popupName = ((UIButtonChangeScreen)(object)renderTextureCamera).PopupName;
		((Transform)layer4).parentInternal = (Transform)(object)popupName;
		int layer5 = ((GameObject)charId).layer;
		Transform anchor = renderTextureCamera.GetAnchor();
		((AssignTextureAndMaterial)layer5)._003CAwake_003Eb__3_0((Material)(object)anchor);
		int layer6 = ((GameObject)charId).layer;
		Transform transform4 = (Transform)(transform + 88);
		transform4 = (Transform)obj;
		Transform transform5 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform4.eulerAngles;
		int layer7 = ((GameObject)charId).layer;
		transform4 = (Transform)obj2;
		Transform transform6 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
		Vector3 localScale = transform4.localScale;
		int layer8 = ((GameObject)charId).layer;
		transform4 = (Transform)obj3;
		Transform transform7 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
		((Transform)layer8).parent = transform4;
		Animation animation = ((GameObject)charId).AddComponent<Animation>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v43 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v56 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)themeIndex))
		{
			UnityEngine.Object obj5 = UnityEngine.Object.Instantiate((UnityEngine.Object)themeIndex);
			((AnimationState)(object)animation).AddMixingTransform((Transform)themeIndex, (byte)(int)obj5 != 0);
			UnityEngine.Object animation2 = UnityEngine.Object.Instantiate((UnityEngine.Object)themeIndex);
			AnimationState animationState = animation.CrossFadeQueued((string)(object)animation2);
			animation.CrossFade((string)2);
		}
		return (GameObject)(object)renderTextureCamera.renderTexture__BackingField;
	}

	public void DeactivateCelebrationPopupModels()
	{
		//IL_002f: Expected Obj, but got I4
		Boards.BoardId currentBoardId = PlayerSave.currentBoardId;
		Characters.CharacterId currentCharacterId = PlayerSave.currentCharacterId;
		ActiveAnimation activeAnimation = ActiveAnimation.Play((Animation)(object)this, (string)currentBoardId, (Direction)currentCharacterId, EnableCondition.EnableThenPlay, DisableCondition.DisableAfterForward);
	}

	public unsafe void ActivateCelebrationBoardWithStripes(Boards.BoardId boardId, ModelScreen screen)
	{
		//IL_00e6: Expected Obj, but got I4
		//IL_00f6: Expected Obj, but got I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected I4, but got Unknown
		//IL_004f: Expected I4, but got Obj
		PauseScreenAnchor = null;
		string text = tag;
		((GameObject)(object)text).tag = (string)1;
		((Component)(object)HuntPrizeAnchor).tag = (string)1;
		((UILabel)(object)HuntPrizeAnchor).fontSize = (int)boardId;
		object obj = this + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S2_v5+8]");
		_ = 0;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj2 + 16);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		((UIWidget)(object)HuntPrizeAnchor).rawPivot = pivot;
		if (screen != ModelScreen.Character)
		{
			((UILabel)(object)HuntPrizeAnchor).fontStyle = (FontStyle)30;
		}
		else
		{
			((UILabel)(object)HuntPrizeAnchor).fontStyle = (FontStyle)20;
		}
		Coroutine coroutine = StartCoroutine((IEnumerator)(object)"FadeOut");
	}

	public void SetDiscoLightBackground()
	{
		//IL_001c: Expected I4, but got Obj
		//IL_0027: Expected I4, but got Obj
		useGUILayout = (byte)(int)"AnimateUnlockBackground" != 0;
		useGUILayout = (byte)(int)"AnimateRunningCharacterForBragCelebration" != 0;
		ClearScreenAnchor(ModelScreen.CelebrationBoardUnlock);
		celebrationBackgroundHelper.Update();
	}

	public unsafe void ActivateCelebrationTunnel()
	{
		//IL_0060: Expected Obj, but got Ref
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_008e: Expected I, but got Obj
		//IL_00a4: Expected Obj, but got I
		//IL_00fe: Expected Ref, but got VT
		//IL_0013: Expected I, but got Obj
		ref Quaternion reference = default;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 16));
		object obj2 = this + 96;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S2_v3+8]");
		_ = 0;
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v7 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v18 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ref Quaternion reference2 = ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 32);
		reference2 = ref *(Quaternion*)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v4+8]");
		_ = 0;
		Quaternion.Inverse_Injected(ref reference, out reference2);
		reference2 = ref *(Quaternion*)reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Quaternion&)+8]");
		_ = 0;
		((CoinBoxSizer)(object)celebrationBackgroundHelper).EnableElements((byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2) != 0, false, true);
	}

	public unsafe void DeactivateCelebrationTunnel()
	{
		//IL_0060: Expected Obj, but got Ref
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_008e: Expected I, but got Obj
		//IL_00a4: Expected Obj, but got I
		//IL_00fe: Expected Ref, but got VT
		//IL_0013: Expected I, but got Obj
		ref Quaternion reference = default;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 16));
		object obj2 = this + 108;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S2_v3+8]");
		_ = 0;
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v7 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v18 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ref Quaternion reference2 = ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 32);
		reference2 = ref *(Quaternion*)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v4+8]");
		_ = 0;
		Quaternion.Inverse_Injected(ref reference, out reference2);
		reference2 = ref *(Quaternion*)reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Quaternion&)+8]");
		_ = 0;
		((CoinBoxSizer)(object)celebrationBackgroundHelper).EnableElements((byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2) != 0, false, false);
	}

	public void SelectThemeForCurrentModel(int themeVersion)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		object obj = this - -64;
		obj = themeVersion;
	}

	public void SelectCurrentModelForPlay()
	{
		//IL_007e: Expected I, but got Obj
		//IL_0094: Expected Obj, but got I
		Delegate obj = UIModelController.m_OnChangedCurrentlyShownHoverboard;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num = (nint)typeof(UIModelController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<UIModelController>)+5C]");
			object obj3 = (nint)0 + (nint)4;
			if (obj3 == obj)
			{
				obj3 = obj4;
			}
			if (obj3 != obj)
			{
				obj = (Delegate)obj3;
				continue;
			}
			break;
		}
	}

	public void SelectCharacterForPlay(Characters.CharacterId characterId, int themeIndex)
	{
		//IL_0075: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I4
		_currentMysteryBoxBoardId = (Boards.BoardId)characterId;
		if (themeIndex == 7)
		{
			Boards.BoardId currentBoardId = PlayerSave.currentBoardId;
			Characters.CharacterId currentCharacterId = PlayerSave.currentCharacterId;
			ActiveAnimation activeAnimation = ActiveAnimation.Play((Animation)(object)this, (string)currentBoardId, (Direction)currentCharacterId, (EnableCondition)7, DisableCondition.DisableAfterForward);
		}
		else
		{
			IEnumerator clipName = AnimateRunningCharacterForBragCelebration((GameObject)4);
			Characters.CharacterId currentCharacterId2 = PlayerSave.currentCharacterId;
			ActiveAnimation activeAnimation2 = ActiveAnimation.Play((Animation)(object)this, (string)(object)clipName, (Direction)currentCharacterId2, (EnableCondition)themeIndex, DisableCondition.DisableAfterForward);
		}
	}

	public unsafe bool ExistsTransformModelInModelScreen(ModelScreen screen, Transform transformModel)
	{
		//IL_01a9: Expected Obj, but got I4
		//IL_01bd: Expected I, but got Obj
		//IL_01d3: Expected Obj, but got I
		//IL_02b2: Expected Obj, but got I4
		//IL_02c4: Expected I, but got Obj
		//IL_02da: Expected Obj, but got I
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected I4, but got Unknown
		//IL_0208: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00f1: Expected I, but got Obj
		//IL_0107: Expected Obj, but got I
		//IL_0124: Expected I, but got Obj
		//IL_0289: Expected I4, but got VT
		//IL_01a0: Expected I4, but got VT
		//IL_0232: Expected Obj, but got I4
		//IL_024c: Expected I4, but got Obj
		//IL_0266: Expected Obj, but got VT
		//IL_0140: Expected I, but got Obj
		//IL_0170: Expected I, but got Obj
		//IL_0196: Expected I, but got Obj
		object obj = 0;
		_ = 0;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v60 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = NGUITools.CalculateNextDepth((GameObject)(object)this, (byte)screen != 0);
		_0021_00210 componentInChildren = (_0021_00210)((GameObject)num3).GetComponentInChildren<T>();
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v56 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIButtonOverlayOff.ButtonType buttonType = (UIButtonOverlayOff.ButtonType)(obj + 12);
		if ((UnityEngine.Object)componentInChildren != null)
		{
			SDebug.LogFormat("Unable to find TutorialMultilineLabelsHelper on prefab, check setup", null);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [transformModel @ L2 (UnityEngine.Transform)+C]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8807");
			}
			else
			{
				nint num6 = (nint)typeof(TutorialMultilineLabelsHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v41 (Il2CppClass<TutorialMultilineLabelsHelper>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num7 = (nint)typeof(TutorialMultilineLabelsHelper);
				if (!flag)
				{
					nint num8 = (nint)typeof(TutorialMultilineLabelsHelper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v47 (Il2CppClass<TutorialMultilineLabelsHelper>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num7 = (nint)typeof(TutorialMultilineLabelsHelper);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num7 = (nint)typeof(TutorialMultilineLabelsHelper);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ L0_v5 (Il2CppClass<TutorialMultilineLabelsHelper>)+5C]");
				nint num9 = 0;
				((UIButtonOverlayOff.ButtonType*)(int)buttonType)->value__ = (int)TutorialMultilineLabelsHelper._defaultPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v25 (Il2CppStaticFields<TutorialMultilineLabelsHelper>)+8]");
				_ = 0;
			}
			obj = ((UIButtonOverlayOff.ButtonType*)(int)buttonType)->value__;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v24 (UIButtonOverlayOff+ButtonType)+8]");
			_ = 0;
			((UIButtonOverlayOff.ButtonType*)(int)buttonType)->value__ = (int)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			((UIButtonOverlayOff)componentInChildren).SetButtonType(buttonType);
		}
		return (byte)(int)componentInChildren != 0;
	}

	public void ActivateHoverboardModel(ModelScreen screen = ModelScreen.Boards)
	{
		_currentlyShownThemeIndex = (int)screen;
		Init();
	}

	public void ShowHoverboardMenuModel(Boards.BoardId currentlyShownBoard, ModelScreen screen, bool willUpdateAnimation, bool willAllowSignatureAnimation, Hoverboard.BoardAbility boardAbility)
	{
		//IL_0193: Expected I, but got Obj
		//IL_01a9: Expected Obj, but got I
		//IL_01d4: Expected I, but got Obj
		//IL_027f: Expected I, but got Obj
		//IL_0295: Expected Obj, but got I
		//IL_00aa: Expected I, but got Obj
		//IL_00c0: Expected Obj, but got I
		//IL_0444: Expected I, but got Obj
		//IL_045a: Expected Obj, but got I
		//IL_02c0: Expected I, but got Obj
		//IL_0564: Expected Obj, but got I4
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected Obj, but got Unknown
		//IL_00eb: Expected I, but got Obj
		//IL_030d: Expected I, but got Obj
		//IL_059f: Expected Obj, but got I4
		//IL_059f: Expected Obj, but got I4
		//IL_035a: Expected I, but got Obj
		//IL_0370: Expected Obj, but got I
		//IL_039b: Expected I, but got Obj
		bool flag2;
		if (willAllowSignatureAnimation)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [screen @ L2 (UIModelController+ModelScreen)+C]");
			if ((nint)0 != 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [screen @ L2 (UIModelController+ModelScreen)+C]");
				bool flag = (nint)0 != 5;
				flag2 = false;
				if (flag)
				{
					goto IL_0436;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [screen @ L2 (UIModelController+ModelScreen)+8]");
			if ((nint)0 != 0)
			{
				flag2 = false;
			}
			else
			{
				nint num = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v61 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v74 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool boardId = willUpdateAnimation;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [screen @ L2 (UIModelController+ModelScreen)+28]");
				if (BoardManager.IsThemeActive(boardId ? Boards.BoardId.bouncer : Boards.BoardId.normal, HoverboardThemes.ThemeIdentifier.none))
				{
					flag2 = false;
				}
				else if ((object)CharacterPromotionAnchor != null)
				{
					GameObject characterPromotionAnchor = CharacterPromotionAnchor;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [currentlyShownBoard @ L1 (Info.Boards+BoardId)+2C]");
					flag2 = (object)characterPromotionAnchor != null;
				}
				else
				{
					flag2 = true;
				}
			}
		}
		else
		{
			nint num3 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v18 (Il2CppClass<Info.Boards>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Boards);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v45 (Il2CppClass<Info.Boards>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Boards.Board board = Boards.boardData.get_Item(willUpdateAnimation ? Boards.BoardId.bouncer : Boards.BoardId.normal);
			if (board.unlockType != PurchaseData.UnlockType.Coins)
			{
				bool flag3 = board.unlockType != PurchaseData.UnlockType.Keys;
				flag2 = false;
				if (flag3)
				{
					goto IL_0436;
				}
			}
			if (board.price != 0)
			{
				flag2 = false;
			}
			else
			{
				nint num5 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v32 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v39 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag4 = BoardManager.HasAllThemesBeenSeen(willUpdateAnimation ? Boards.BoardId.bouncer : Boards.BoardId.normal);
				flag2 = (byte)((flag4 ? 1u : 0u) ^ 1u) != 0;
			}
		}
		goto IL_0436;
		IL_0436:
		nint num7 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v8 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v13 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag5 = (willAllowSignatureAnimation ? Hoverboard.BoardAbility.Jumper : Hoverboard.BoardAbility.None) == boardAbility;
		bool flag6 = BoardManager.DoesBoardHaveThemes(willUpdateAnimation ? Boards.BoardId.bouncer : Boards.BoardId.normal);
		object obj5 = (flag6 ? 1 : 0) ^ 1;
		object obj6 = flag5 & obj5;
		nint method;
		if (obj6 != null)
		{
			nint num9 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S2_v8 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num10 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S2_v19 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UserSave.lastPurchasedBundle != InAppData.BundleTier.None)
			{
				method = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [screen @ L2 (UIModelController+ModelScreen)+18]");
				bool flag7 = (nint)0 != 0;
				method = (flag7 ? 1 : 0);
			}
		}
		else
		{
			method = 0;
		}
		((OnActivatedPrefab)currentlyShownBoard)._002Ector(flag2, method);
	}

	public void SelectCurrentlyShownBoard(Boards.BoardId boardId)
	{
		//IL_0051: Expected Obj, but got I4
		Boards.BoardId currentBoardId = PlayerSave.currentBoardId;
		_currentlyShownModel = (Characters.CharacterId)currentBoardId;
		Characters.CharacterId currentCharacterId = PlayerSave.currentCharacterId;
		_currentlyShownThemeIndex = (int)currentCharacterId;
		ActiveAnimation activeAnimation = ActiveAnimation.Play((Animation)(object)this, (string)_currentlyShownModel, (Direction)_currentlyShownThemeIndex, (EnableCondition)boardId, DisableCondition.DisableAfterForward);
		TransformExtensions.Reset((Transform)(object)UIModelController.m_OnChangedCurrentlyShownHoverboard);
	}

	public CharacterModel GetActiveCharacterModel(ModelScreen screen)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected Obj, but got Unknown
		//IL_02f6: Expected Obj, but got I4
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		//IL_004b: Expected Obj, but got I
		//IL_005b: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_009f: Expected Obj, but got I4
		//IL_00ac: Expected Obj, but got I4
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected Obj, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_0382: Expected Obj, but got I4
		//IL_01e4: Expected Obj, but got I
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [45932B]");
		bool flag = (nint)0 == 0;
		bool flag2 = !flag;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<HoverboardThemes.HoverboardTheme> list = default;
		list._002Ector();
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S3_v3+60]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S3_v4+38]");
		object obj7 = 0;
		object obj8 = obj7 & 0x1FFF;
		object obj9 = obj8 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v68 @ S4_v4 (should have been resolved before IL gen)");
		HoverboardThemes.HoverboardTheme hoverboardTheme = ((List<HoverboardThemes.HoverboardTheme>)screen).get_Item(0);
		object obj10 = 0;
		HoverboardThemes.HoverboardTheme hoverboardTheme2 = hoverboardTheme;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [screen @ L1 (UIModelController+ModelScreen)+C]");
		object obj11 = default;
		if ((nint)obj11 < 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			HoverboardThemes.UIOrder uIOrder = (HoverboardThemes.UIOrder)int.MaxValue;
			object obj12 = default;
			HoverboardThemes.HoverboardTheme hoverboardTheme3 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj12 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (hoverboardTheme3.uiOrder < uIOrder)
				{
					uIOrder = hoverboardTheme3.uiOrder;
					hoverboardTheme2 = hoverboardTheme3;
				}
			}
			object obj13 = obj4 + 4;
			object obj14 = obj13 + 1;
			obj13 = obj14;
			object obj15 = obj14 << 2;
			object obj16 = obj4 + obj15;
			obj16 = 109;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj17 = (nint)0 << 2;
				object obj18 = obj4 + obj17;
				if ((nint)obj18 == 109)
				{
					object obj19 = obj4 + 4;
					if ((nint)obj19 > -1)
					{
						object obj20 = obj19 + -1;
						obj19 = obj20;
					}
					goto IL_0270;
				}
			}
			if (obj10 == null)
			{
				goto IL_0270;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			return null;
		}
		CharacterModel result = default;
		return result;
		IL_0270:
		throw new ArrayTypeMismatchException();
	}

	public Characters.CharacterId GetActiveCharacterId(ModelScreen screen)
	{
		//IL_0022: Expected I4, but got Obj
		ModelScreenData modelScreenData = _cachedModelScreenDataEntries.get_Item(screen);
		return (Characters.CharacterId)modelScreenData.characterModel__BackingField;
	}

	public unsafe void ShowMenuModel(Characters.CharacterId charId, int themeVersion, ModelScreen screen = ModelScreen.Character)
	{
		//IL_0018: Expected Obj, but got I4
		string text = tag;
		((GameObject)(object)text).tag = (string)1;
		((UILabel)(object)CharacterAnchor).fontSize = (int)charId;
		UIWidget.Pivot pivot = default;
		((UIWidget.Pivot*)(int)pivot)->value__ = ((int*)themeVersion)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [themeVersion @ L2 (System.Int32)+8]");
		_ = 0;
		((UIWidget)(object)GameOverAnchor).rawPivot = pivot;
		((UIWidget.Pivot*)(int)pivot)->value__ = ((ModelScreen*)(int)screen)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [screen @ L3 (UIModelController+ModelScreen)+8]");
		_ = 0;
		((UIWidget)(object)CharacterAnchor).rawPivot = pivot;
	}

	private unsafe bool IsModelCurrentlyShown(Characters.CharacterId charId, int themeVersion, ModelScreen screen)
	{
		//IL_0193: Expected I, but got Obj
		//IL_01a9: Expected Obj, but got I
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_0312: Expected I, but got Obj
		//IL_0328: Expected Obj, but got I
		//IL_01dd: Expected I, but got Obj
		//IL_01f3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected VT, but got Unknown
		//IL_022b: Expected F4, but got Obj
		//IL_0226: Expected native int or pointer, but got VT
		//IL_0240: Expected F4, but got I
		//IL_023b: Expected native int or pointer, but got VT
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_027c: Expected VT, but got Obj
		//IL_027c: Expected Obj, but got I4
		//IL_028e: Expected I, but got Obj
		//IL_02a4: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_02ca: Expected VT, but got I4
		//IL_02e8: Expected Obj, but got I4
		//IL_02e8: Expected Obj, but got I4
		//IL_00ad: Expected I, but got Obj
		//IL_00fa: Expected I, but got Obj
		//IL_0161: Expected Obj, but got F4
		//IL_0173: Expected I, but got F4
		//IL_0180: Expected Obj, but got I4
		//IL_0185: Expected I4, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v60 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 16;
		Vector3 one = Vector3.one;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v16 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v56 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 zero = Vector2.zero;
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v52 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj3 + 28);
		((Vector3*)(nint)vector)->x = (float)obj2;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Transform transform = (Transform)(obj3 + 40);
		transform = (Transform)obj3;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		GameObject gameObject = UnityEngine.Object.Instantiate((GameObject)charId, vector, (Quaternion)transform);
		nint num7 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v37 (Il2CppClass<NGUITools>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num8 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v48 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector3 = NGUITools.Round((Vector3)screen);
		int layer = gameObject.layer;
		((Transform)layer).parentInternal = (Transform)themeVersion;
		int layer2 = gameObject.layer;
		Vector3 forward = Vector3.forward;
		transform = (Transform)vector.x;
		((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)vector.z;
		((Transform)layer2).parent = transform;
		return (byte)(int)gameObject != 0;
	}

	private GameObject _SetupModelAndActivateIt(Characters.CharacterId charId, int themeVersion, ModelScreen screen, bool cache = true)
	{
		//IL_0016: Expected Obj, but got I4
		return (GameObject)(object)ActiveAnimation.Play((Animation)(object)this, (string)charId, (Direction)themeVersion, (EnableCondition)screen, cache ? DisableCondition.DisableAfterForward : DisableCondition.DoNotDisable);
	}

	private void SetupModelScreen(ModelScreen screen, ModelScreenSetup screenSetup, ModelScreenData modelScreenData)
	{
		//IL_0012: Expected I4, but got Obj
		//IL_0012: Expected Obj, but got I4
		//IL_0052: Expected I4, but got Obj
		//IL_0069: Expected I4, but got Obj
		//IL_0069: Expected I4, but got Obj
		//IL_0069: Expected Obj, but got I4
		IEnumerator enumerator = AnimationExtensions.Play((Animation)(object)this, (string)screen, (byte)(int)screenSetup != 0, (Action)(object)modelScreenData);
		if (enumerator == null)
		{
			_currentlyShownModel = (Characters.CharacterId)screen;
			_currentlyShownThemeIndex = (int)screenSetup;
			ActiveAnimation activeAnimation = ActiveAnimation.Play((Animation)(object)this, (string)screen, (Direction)screenSetup, (EnableCondition)modelScreenData, DisableCondition.DisableAfterForward);
		}
	}

	private GameObject _ActivateModel(ModelScreenData modelScreenData, Characters.CharacterId characterId, int modelVersion, ModelScreen screen, bool cache, Characters.CharacterId? friendsCharacterName = null, int friendsModelVersion = -1)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0029: Expected Obj, but got I
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_00be: Expected Obj, but got I4
		object obj = this + -3020;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S1_v3+38]");
		object obj3 = (nint)0 & (nint)0xFFF;
		object obj4 = obj3 + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v11 @ S1_v6 (should have been resolved before IL gen)");
		object obj5 = default;
		if (obj5 == null)
		{
			return null;
		}
		object obj6 = this + -336;
		if (obj6 == null)
		{
			return null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5BBD");
		object obj7 = default;
		bool flag = obj7 == null;
		return (GameObject)flag;
	}

	private IEnumerator AnimateRunningCharacterForBragCelebration(GameObject model)
	{
		//IL_0049: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I
		//IL_0069: Expected Obj, but got I
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_00c4: Expected Obj, but got I4
		//IL_0014: Expected I4, but got Obj
		Boards.BoardId currentBoardId = PlayerSave.currentBoardId;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v30 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		bool flag = (nint)obj6 > -1;
		bool flag2 = !flag;
		Characters.CharacterId characterId = (Characters.CharacterId)currentBoardId;
		if (!flag2)
		{
			ModelScreenData modelScreenData = _cachedModelScreenDataEntries.get_Item((ModelScreen)model);
			characterId = modelScreenData.characterId__BackingField;
		}
		return (IEnumerator)characterId;
	}

	private IEnumerator AnimateUnlockBackground(GameObject go)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = this;
		object obj2 = enumerator + 16;
		obj2 = go;
		return enumerator;
	}

	private void UpdateCelebrationRotation(GameObject go, Vector3 charRotation, Vector3 charPosition, Vector3 charPositionOffset, Vector3 backgroundRotationOffset, bool shouldAnimateStripes, bool rotateBackground)
	{
		//IL_01dd: Expected I4, but got Obj
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_01f0: Expected Obj, but got I4
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_0224: Expected I, but got Obj
		//IL_023a: Expected Obj, but got I
		//IL_0274: Expected I4, but got Obj
		//IL_0061: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0083: Expected I4, but got Obj
		//IL_00a5: Expected I, but got Obj
		//IL_00bb: Expected Obj, but got I
		//IL_0296: Expected I4, but got Obj
		//IL_02a3: Expected Obj, but got I4
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		//IL_02c8: Expected Obj, but got I4
		//IL_0137: Expected Obj, but got I4
		//IL_00e6: Expected I, but got Obj
		//IL_014a: Expected Obj, but got I4
		//IL_0158: Expected Obj, but got I4
		//IL_016b: Expected Obj, but got I4
		//IL_0178: Expected Obj, but got I4
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected Obj, but got Unknown
		//IL_01bd: Expected Obj, but got I4
		celebrationShouldAnimateStripes = (byte)(int)go != 0;
		object obj = this + 96;
		obj = shouldAnimateStripes;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<UISprite> list = default;
		list._002Ector();
		object obj2 = this + 104;
		obj2 = list;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v10 (Il2CppClass<Strings>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v47 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("EARN_COINS_LOADING");
		((UILabel)(object)CelebrationPopupAnchor).fontSize = (int)text;
		string text2 = Strings.GetDefault("EARN_COINS_LOADING_FAILED");
		((UILabel)(object)HuntPrizeAnchor).fontSize = (int)text2;
		string text3 = Strings.GetDefault("BUTTON_TRY_AGAIN");
		((UILabel)(object)PauseScreenAnchor).fontSize = (int)text3;
		string go2 = ((Component)(object)_firstPurchaseBonusBreakDanceAnimation2).tag;
		nint num3 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S2_v9 (Il2CppClass<NGUITools>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S2_v18 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num5 = NGUITools.CalculateNextDepth((GameObject)(object)go2, (byte)(int)_firstPurchaseBonusBreakDanceAnimation != 0);
		FitSpriteToWidget component = ((GameObject)num5).GetComponent<FitSpriteToWidget>();
		object obj5 = component + 16;
		obj5 = _firstPurchaseBonusBreakDanceAnimation2;
		FitSpriteToWidget component2 = ((GameObject)num5).GetComponent<FitSpriteToWidget>();
		component2.FitStretch();
		int layer = ((GameObject)num5).layer;
		bool flag = ((SpriteAtlas)layer).CanBindTo(null);
		bool flag2 = ((SpriteAtlas)flag).CanBindTo(null);
		bool flag3 = ((SpriteAtlas)flag2).CanBindTo(null);
		string text4 = ((Component)flag3).tag;
		((GameObject)(object)text4).tag = null;
		string text5 = tag;
		UIDragScrollView component3 = ((GameObject)(object)text5).GetComponent<UIDragScrollView>();
		object obj6 = component3 + 12;
		obj6 = rotateBackground;
		((CoinEarnerVideoAds)this).UnsubscribeToEvents();
		IEnumerator enumerator = ((CoinEarnerVideoAds)this).CheckCacheState();
	}

	private bool ShouldCreateABrandNewModel()
	{
		return (byte)_currentlyShownModel != 0;
	}

	public void ActivateModelScreen(ModelScreen screen)
	{
		PlayerSave.previousBoardId = (Boards.BoardId)screen;
		TransformExtensions.Reset((Transform)(object)UIModelController.m_OnChangedCurrentlyShownHoverboard);
	}

	public void DeactivateModelScreen(ModelScreen screen)
	{
		//IL_005e: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_0042: Expected Obj, but got I4
		//IL_0042: Expected Obj, but got I4
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		if ((nint)obj6 > -1)
		{
			ModelScreenData modelScreenData = _cachedModelScreenDataEntries.get_Item(screen);
			((ModelScreenSetup)(object)modelScreenData)._002Ector();
		}
		int numberOfSpaces = ((UIPowerupHandler)this).getNumberOfSpaces((int)screen);
		((GameObject)numberOfSpaces).tag = (string)1;
	}

	public void ClearScreenAnchor(ModelScreen screen)
	{
		//IL_005a: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I4
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		if ((nint)obj6 > -1)
		{
			ModelScreenData modelScreenData = _cachedModelScreenDataEntries.get_Item(screen);
			modelScreenData.Activate();
		}
		int numberOfSpaces = ((UIPowerupHandler)this).getNumberOfSpaces((int)screen);
		((GameObject)numberOfSpaces).tag = null;
	}

	private GameObject GetScreenAnchor(ModelScreen screen)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0046: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject = default;
		((UnityEngine.Object)gameObject).m_CachedPtr = (IntPtr)0;
		object obj = gameObject + 16;
		obj = this;
		object obj2 = gameObject + 20;
		obj2 = screen;
		return gameObject;
	}

	private void Init()
	{
		//IL_0012: Expected Obj, but got I4
		((UIPowerupHandler)this).SetPowerupSlotContent((ActivePowerup)_currentlyShownModel, _currentlyShownThemeIndex);
	}

	public UIModelController()
	{
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
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
		object obj6 = this + 88;
		object obj7 = default;
		obj6 = obj7;
	}
}

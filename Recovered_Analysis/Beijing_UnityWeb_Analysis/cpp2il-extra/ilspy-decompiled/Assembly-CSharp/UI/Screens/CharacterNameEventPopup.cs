using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using Info;
using Ionic.Zlib;
using Kiloo.Common.Backend.PurchaseValidation;
using Kiloo.Common.JsonUtil;
using Microsoft.Win32;
using Missions;
using SYBO.Subway.Info;
using UI.Footer;
using UI.Generic;
using UI.Screens.RewardManagement;
using UnityEngine;

namespace UI.Screens;

public class CharacterNameEventPopup : UIScreen
{
	private enum HorizontalScrollDirections
	{
		left = -1,
		right = 1
	}

	private sealed class _003CDelayPositioning_003Ed__77 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UISprite tracker;

		public GameObject objectToPosition;

		public Vector3 positionOffset;

		public Vector3 newRotation;

		public Vector3 newScale;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_03d8: Expected VT, but got Unknown
				//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e6: Expected VT, but got Unknown
				//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f4: Expected Obj, but got Unknown
				//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0402: Expected Obj, but got Unknown
				//IL_040b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0410: Expected Obj, but got Unknown
				//IL_0419: Unknown result type (might be due to invalid IL or missing references)
				//IL_041e: Expected Obj, but got Unknown
				//IL_0427: Unknown result type (might be due to invalid IL or missing references)
				//IL_042c: Expected Obj, but got Unknown
				//IL_0435: Unknown result type (might be due to invalid IL or missing references)
				//IL_043a: Expected Obj, but got Unknown
				//IL_0443: Unknown result type (might be due to invalid IL or missing references)
				//IL_0448: Expected Obj, but got Unknown
				//IL_0451: Unknown result type (might be due to invalid IL or missing references)
				//IL_0456: Expected Obj, but got Unknown
				//IL_045f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0464: Expected Ref, but got Unknown
				//IL_046d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0472: Expected Obj, but got Unknown
				//IL_047b: Expected Obj, but got I4
				//IL_048a: Unknown result type (might be due to invalid IL or missing references)
				//IL_048f: Expected Obj, but got Unknown
				//IL_0498: Expected Obj, but got I4
				//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_04ac: Expected Obj, but got Unknown
				//IL_04b5: Expected Obj, but got I4
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_0065: Expected Obj, but got I4
				//IL_0091: Expected VT, but got Obj
				//IL_00b6: Expected I, but got Obj
				//IL_00cc: Expected Obj, but got I
				//IL_04f5: Expected F4, but got Obj
				//IL_04f0: Expected native int or pointer, but got VT
				//IL_050a: Expected F4, but got I
				//IL_0505: Expected native int or pointer, but got VT
				//IL_051f: Expected Obj, but got I
				//IL_0143: Expected F4, but got Obj
				//IL_013e: Expected native int or pointer, but got VT
				//IL_0158: Expected F4, but got I
				//IL_0153: Expected native int or pointer, but got VT
				//IL_016d: Expected Obj, but got I
				//IL_00f7: Expected I, but got Obj
				//IL_01a7: Expected F4, but got Obj
				//IL_01a2: Expected native int or pointer, but got VT
				//IL_01bc: Expected F4, but got I
				//IL_01b7: Expected native int or pointer, but got VT
				//IL_01c5: Expected Obj, but got VT
				//IL_01f9: Expected VT, but got I4
				//IL_0204: Unknown result type (might be due to invalid IL or missing references)
				//IL_0209: Expected Obj, but got Unknown
				//IL_022c: Expected I, but got Obj
				//IL_0242: Expected Obj, but got I
				//IL_0598: Expected F4, but got Obj
				//IL_0593: Expected native int or pointer, but got VT
				//IL_05aa: Expected F4, but got I
				//IL_05a5: Expected native int or pointer, but got VT
				//IL_05b7: Expected F4, but got Obj
				//IL_05b2: Expected native int or pointer, but got VT
				//IL_05cc: Expected F4, but got I
				//IL_05c7: Expected native int or pointer, but got VT
				//IL_05ea: Expected F4, but got Obj
				//IL_05e5: Expected native int or pointer, but got VT
				//IL_05ff: Expected F4, but got I
				//IL_05fa: Expected native int or pointer, but got VT
				//IL_0608: Expected Obj, but got VT
				//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b7: Expected Obj, but got Unknown
				//IL_02c4: Expected F4, but got Obj
				//IL_02bf: Expected native int or pointer, but got VT
				//IL_02d9: Expected F4, but got I
				//IL_02d4: Expected native int or pointer, but got VT
				//IL_02e7: Expected I, but got Obj
				//IL_02fd: Expected Obj, but got I
				//IL_026d: Expected I, but got Obj
				//IL_062d: Expected native int or pointer, but got VT
				//IL_063f: Expected native int or pointer, but got VT
				//IL_0651: Expected Ref, but got VT
				//IL_0663: Expected F4, but got VT
				//IL_065e: Expected native int or pointer, but got VT
				//IL_0678: Expected F4, but got I
				//IL_0673: Expected native int or pointer, but got VT
				//IL_0681: Expected Obj, but got VT
				//IL_036d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0372: Expected Obj, but got Unknown
				//IL_0394: Expected F4, but got Obj
				//IL_038f: Expected native int or pointer, but got VT
				//IL_03a9: Expected F4, but got I
				//IL_03a4: Expected native int or pointer, but got VT
				//IL_03b6: Expected Obj, but got VT
				//IL_03b6: Expected Obj, but got I4
				//IL_0328: Expected I, but got Obj
				object obj = default;
				Vector3 vector = (Vector3)(obj + 176);
				Vector3 vector2 = (Vector3)(obj + 164);
				Transform transform = (Transform)(obj + 116);
				object obj2 = obj + 104;
				object obj3 = obj + 92;
				object obj4 = obj + 80;
				object obj5 = obj + 68;
				Transform transform2 = (Transform)(obj + 56);
				object obj6 = obj + 44;
				object obj7 = obj + 32;
				ref Quaternion reference = ref *(Quaternion*)(obj + 16);
				object obj8 = obj + 152;
				obj8 = 0;
				_ = 0;
				object obj9 = obj + 140;
				obj9 = 0;
				_ = 0;
				object obj10 = obj + 128;
				obj10 = 0;
				_ = 0;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						GameObject gameObject = tracker.gameObject;
						transform.position = (Vector3)gameObject;
						obj8 = transform;
						_ = ((UnityEngine.Object)transform).m_CachedPtr;
						nint num = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v52 (Il2CppClass<UIScreenController>)+BA]");
						object obj11 = (nint)0 & (nint)0x200;
						if (obj11 != null)
						{
							nint num2 = (nint)typeof(UIScreenController);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v96 (Il2CppClass<UIScreenController>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag = UIScreenController.ShouldShowOnlineScreen();
						((Vector3*)(nint)vector)->x = (float)obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
						((Vector3*)(nint)vector)->z = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v57 (System.Boolean)+30]");
						Vector3 vector3 = ((Camera)0).WorldToViewportPoint(vector);
						obj9 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
						_ = 0;
						obj3 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
						_ = 0;
						obj4 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v34+8]");
						_ = 0;
						obj9 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+4]");
						_ = 0;
						_ = 1f;
						bool flag2 = UIScreenController.ShouldShowOnlineScreen();
						((Vector3*)(nint)vector)->x = (float)obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v34+8]");
						((Vector3*)(nint)vector)->z = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v76 (System.Boolean)+20]");
						Vector3 vector4 = ((Camera)0).ScreenToViewportPoint(vector);
						obj10 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
						_ = 0;
						int layer = objectToPosition.layer;
						((Vector3*)(nint)vector)->x = (float)obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v37+8]");
						((Vector3*)(nint)vector)->z = 0f;
						Vector3 localPosition = ((Transform)vector).localPosition;
						int layer2 = objectToPosition.layer;
						int layer3 = objectToPosition.layer;
						transform2.localPosition = (Vector3)layer3;
						object obj12 = this + 24;
						obj6 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S2_v15+8]");
						_ = 0;
						nint num3 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S1_v78 (Il2CppClass<UnityEngine.Vector3>)+BA]");
						object obj13 = (nint)0 & (nint)0x200;
						if (obj13 != null)
						{
							nint num4 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S1_v114 (Il2CppClass<UnityEngine.Vector3>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						((Vector3*)(nint)vector2)->x = (float)transform2;
						((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
						((Vector3*)(nint)vector)->x = (float)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
						((Vector3*)(nint)vector)->z = 0f;
						Vector3 vector5 = vector2 - vector;
						((Vector3*)(nint)vector)->x = (float)obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27+8]");
						((Vector3*)(nint)vector)->z = 0f;
						Vector3 eulerAngles = ((Transform)vector).eulerAngles;
						int layer4 = objectToPosition.layer;
						object obj14 = this + 36;
						((Vector3*)(nint)vector2)->x = (float)obj14;
						Vector3 vector6 = vector2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S2_v35+8]");
						((Vector3*)(nint)vector6)->z = 0f;
						nint num5 = (nint)typeof(Quaternion);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S1_v94 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
						object obj15 = (nint)0 & (nint)0x200;
						if (obj15 != null)
						{
							nint num6 = (nint)typeof(Quaternion);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S1_v110 (Il2CppClass<UnityEngine.Quaternion>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						((Vector3*)(nint)vector)->x = vector2.x;
						((Vector3*)(nint)vector)->z = vector2.z;
						Quaternion.Inverse_Injected(ref reference, out *(Quaternion*)vector);
						((Vector3*)(nint)vector)->x = (float)reference;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29 (UnityEngine.Quaternion&)+8]");
						((Vector3*)(nint)vector)->z = 0f;
						Vector3 localScale = ((Transform)vector).localScale;
						int layer5 = objectToPosition.layer;
						object obj16 = this + 48;
						obj = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S2_v51+8]");
						_ = 0;
						((Vector3*)(nint)vector)->x = (float)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						((Vector3*)(nint)vector)->z = 0f;
						((Transform)layer5).parent = (Transform)vector;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj17 = this + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj18 = default;
				obj17 = obj18;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CDelayPositioning_003Ed__77(int _003C_003E1__state)
		{
			//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b2: Expected Obj, but got Unknown
			//IL_05bb: Expected Obj, but got I4
			//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_05cf: Expected Obj, but got Unknown
			//IL_05d8: Expected Obj, but got I4
			//IL_05ec: Expected I, but got Obj
			//IL_0602: Expected Obj, but got I
			//IL_073d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0742: Expected Obj, but got Unknown
			//IL_074c: Expected Obj, but got I4
			//IL_00a4: Expected Obj, but got I4
			//IL_00ae: Expected Obj, but got I4
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Expected Obj, but got Unknown
			//IL_00c4: Expected Obj, but got I4
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Expected Obj, but got Unknown
			//IL_00f7: Expected VT, but got Obj
			//IL_00f7: Expected Obj, but got I
			//IL_0105: Expected I, but got Obj
			//IL_011b: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0628: Unknown result type (might be due to invalid IL or missing references)
			//IL_062d: Expected Obj, but got Unknown
			//IL_0636: Unknown result type (might be due to invalid IL or missing references)
			//IL_063b: Expected Obj, but got Unknown
			//IL_0645: Expected Obj, but got I4
			//IL_005c: Expected Obj, but got I4
			//IL_0146: Expected I, but got Obj
			//IL_019f: Expected Obj, but got I
			//IL_01af: Expected Obj, but got I
			//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c4: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 60;
			obj = 0;
			_ = 0;
			object obj3 = obj2 + 48;
			obj3 = 0;
			_ = 0;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v143 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Transform transform = (Transform)(obj2 + 72);
			if ((UnityEngine.Object)_003C_003E1__state != null)
			{
				transform = (Transform)this._003C_003E1__state;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				string text = default;
				string msg = "CharacterName Event Popup: GetCharacterEventScreenModel for character " + text + " has failed. Creating default model.";
				SDebug.LogFormat(msg, null);
			}
			object obj5 = _003C_003E2__current;
			obj2 = 0;
			obj2 = this._003C_003E1__state;
			object obj6 = obj2 + 4;
			obj6 = _003C_003E1__state;
			object obj7 = obj2 + 16;
			obj7 = obj2;
			transform = (Transform)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v25 (System.Object)+98]");
			((List<KeyValuePair<Characters.CharacterId, CharacterScreenController>>)0).Add((KeyValuePair<Characters.CharacterId, CharacterScreenController>)transform);
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v28 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v132 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj9 = obj2 + 36;
			Transform transform2 = (Transform)(obj2 + 24);
			if (((ComputeShader)_003C_003E1__state).FindKernel(null) != 0)
			{
				object obj10 = _003C_003E2__current;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S1_v33 (System.Object)+98]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v34+C]");
				obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				object obj12 = this + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				throw new NullReferenceException();
			}
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

	private sealed class _003CAnimateScrollBar_003Ed__90(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CharacterNameEventPopup _003C_003E4__this;

		public float amount;

		public HorizontalScrollDirections direction;

		public float speedFactor;

		private float _003CanimationLerpFactor_003E5__2;

		private Transform _003CcharacterScrollTrans_003E5__3;

		private Vector3 _003CcharacterScrollLocalPosition_003E5__4;

		private float _003CstartValue_003E5__5;

		private float _003CendValue_003E5__6;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0238: Unknown result type (might be due to invalid IL or missing references)
				//IL_023d: Expected Obj, but got Unknown
				//IL_0045: Unknown result type (might be due to invalid IL or missing references)
				//IL_004a: Expected Obj, but got Unknown
				//IL_0064: Expected Obj, but got I4
				//IL_0073: Expected VT, but got Obj
				//IL_0098: Unknown result type (might be due to invalid IL or missing references)
				//IL_009d: Expected Obj, but got Unknown
				//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ba: Expected Obj, but got Unknown
				//IL_00c4: Expected F4, but got Obj
				//IL_01af: Expected I, but got Obj
				//IL_01c5: Expected Obj, but got I
				//IL_028c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0291: Expected Obj, but got Unknown
				//IL_0297: Unknown result type (might be due to invalid IL or missing references)
				//IL_029c: Expected Obj, but got Unknown
				//IL_02a5: Expected Obj, but got I4
				//IL_02bb: Expected Obj, but got F4
				//IL_030a: Unknown result type (might be due to invalid IL or missing references)
				//IL_030f: Expected Obj, but got Unknown
				//IL_0318: Expected Obj, but got I4
				//IL_032c: Expected Obj, but got I4
				//IL_01f0: Expected I, but got Obj
				Transform transform2 = default;
				Transform transform = (Transform)(transform2 + 12);
				CharacterNameEventPopup characterNameEventPopup = _003C_003E4__this;
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
					_003CanimationLerpFactor_003E5__2 = 0f;
					object obj = this + 36;
					int layer = characterNameEventPopup.characterScrollAnchor.layer;
					obj = layer;
					transform2.localPosition = (Vector3)_003CcharacterScrollTrans_003E5__3;
					transform = transform2;
					((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
					object obj2 = this + 40;
					obj2 = transform;
					_ = ((UnityEngine.Object)transform).m_CachedPtr;
					object obj3 = this + 40;
					_003CstartValue_003E5__5 = (float)obj3;
					float num = amount * (float)direction;
					float num2 = _003CstartValue_003E5__5 + num;
					_003CendValue_003E5__6 = num2;
					characterNameEventPopup.ScrollListTo(0);
				}
				if (!(_003CanimationLerpFactor_003E5__2 < 1f))
				{
					characterNameEventPopup.ScrollListTo(1);
					return null;
				}
				float unscaledTime = Time.unscaledTime;
				float num3 = unscaledTime * speedFactor;
				float num4 = _003CanimationLerpFactor_003E5__2 + num3;
				_003CanimationLerpFactor_003E5__2 = num4;
				nint num5 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S3_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num6 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S3_v11 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num7 = Mathf.LerpUnclamped(_003CstartValue_003E5__5, _003CendValue_003E5__6, _003CanimationLerpFactor_003E5__2);
				object obj5 = this + 40;
				object obj6 = this + 40;
				transform2 = (Transform)0;
				((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
				transform2 = (Transform)num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S1_v14+4]");
				_ = 0;
				Transform transform3 = transform2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S1_v17+8]");
				((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
				transform = transform2;
				((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
				Vector3 eulerAngles = transform.eulerAngles;
				object obj7 = this + 12;
				obj7 = 0;
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

	private sealed class _003CAnimateCharacter_003Ed__91(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CharacterScreenController characterController;

		public float speedFactor;

		public float freezeStart;

		public float freezeEnd;

		public float scaleStartValue;

		public float scaleEndValue;

		public float positionStartValue;

		public float positionEndValue;

		private float _003CanimationLerpFactor_003E5__2;

		private Transform _003CcharacterModelTrans_003E5__3;

		private Vector3 _003CcharacterModelPosition_003E5__4;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c2: Expected Obj, but got Unknown
				//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
				//IL_03d0: Expected Obj, but got Unknown
				//IL_004d: Expected I, but got Obj
				//IL_0063: Expected Obj, but got I
				//IL_008e: Expected I, but got Obj
				//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d8: Expected Obj, but got Unknown
				//IL_00fe: Expected VT, but got Obj
				//IL_0123: Unknown result type (might be due to invalid IL or missing references)
				//IL_0128: Expected Obj, but got Unknown
				//IL_0224: Expected I, but got Obj
				//IL_023a: Expected Obj, but got I
				//IL_01af: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b4: Expected Obj, but got Unknown
				//IL_01bd: Expected Obj, but got I4
				//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c8: Expected Obj, but got Unknown
				//IL_02c8: Expected Obj, but got I4
				//IL_02de: Expected Obj, but got F4
				//IL_02f0: Expected I, but got F4
				//IL_0265: Expected I, but got Obj
				//IL_0324: Unknown result type (might be due to invalid IL or missing references)
				//IL_0329: Expected Obj, but got Unknown
				//IL_032f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0334: Expected Obj, but got Unknown
				//IL_033d: Expected Obj, but got I4
				//IL_038d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0392: Expected Obj, but got Unknown
				//IL_039b: Expected Obj, but got I4
				//IL_03af: Expected Obj, but got I4
				object obj = default;
				Transform transform = (Transform)(obj + 24);
				Transform transform2 = (Transform)(obj + 12);
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
					_003CanimationLerpFactor_003E5__2 = 0f;
					nint num = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v53 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v73 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)characterController).FindKernel((string)null) == 0)
					{
						return null;
					}
					object obj3 = this + 52;
					GameObject gameObject = characterController.gameObject;
					obj3 = gameObject;
					transform2.localPosition = (Vector3)_003CcharacterModelTrans_003E5__3;
					transform = transform2;
					((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
					object obj4 = this + 56;
					obj4 = transform;
					_ = ((UnityEngine.Object)transform).m_CachedPtr;
				}
				if (!(_003CanimationLerpFactor_003E5__2 < 1f))
				{
					characterController.SetFreeze(freezeEnd);
					object obj5 = this + 52;
					obj5 = 0;
					object obj6 = this + 56;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
					return null;
				}
				float unscaledTime = Time.unscaledTime;
				float num3 = unscaledTime * speedFactor;
				float num4 = _003CanimationLerpFactor_003E5__2 + num3;
				_003CanimationLerpFactor_003E5__2 = num4;
				nint num5 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S4_v3 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num6 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S4_v8 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float freeze = Mathf.LerpUnclamped(freezeStart, freezeEnd, _003CanimationLerpFactor_003E5__2);
				characterController.SetFreeze(freeze);
				float num7 = Mathf.LerpUnclamped(scaleStartValue, scaleEndValue, _003CanimationLerpFactor_003E5__2);
				float num8 = Mathf.LerpUnclamped(positionStartValue, positionEndValue, _003CanimationLerpFactor_003E5__2);
				transform2 = (Transform)0;
				((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
				transform2 = (Transform)num7;
				((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)num7;
				transform = transform2;
				((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
				_003CcharacterModelTrans_003E5__3.parent = transform;
				object obj8 = this + 56;
				object obj9 = this + 56;
				obj = 0;
				_ = 0;
				obj = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S1_v31+8]");
				_ = 0;
				transform = (Transform)obj;
				Transform transform3 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
				Vector3 eulerAngles = transform.eulerAngles;
				object obj10 = this + 12;
				obj10 = 0;
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

	private UIWidget outline;

	private GameObject characterScrollAnchor;

	private GameObject _categoryModelAnchor;

	private GameObject skipWithKeysButtonWidget;

	private GameObject skipWithAdButtonWidget;

	private GameObject completeSignWidget;

	private GameObject centerAnchor;

	private GameObject overlayClipAnchor;

	private GameObject selectButtonPrefab;

	private GameObject eventDescriptionBox;

	private UILabel eventDescriptionBoxName;

	private GameObject eventDescriptionBoxActive;

	private UILabel eventDescriptionBoxTitleInactive;

	private UILabel eventDescriptionTitleActive;

	private UILabel eventDescriptionBoxNameActive;

	private UILabel eventDescriptionBoxNameActiveShadow;

	private UILabel firstTitle;

	private UILabel secondTitle;

	private UILabel skipButtonKeyAmount;

	private GameObject _lpModelPrefab;

	private UISprite _topSplatSprite;

	private GameObject _superMysteryBoxIcon;

	private GameObject _movieIcon;

	private GameObject _danceIcon;

	private TimerHelper _timerPrefab;

	private UIWidget _timerContainer;

	private TimerHelper _timer;

	private GameObject _lpModel;

	private List<KeyValuePair<Characters.CharacterId, CharacterScreenController>> _characterControllers;

	private int _scrollPopulationStartFromSlot;

	private int _currentlyFocusedIndex;

	private bool _isFirstFocused;

	private bool _isLastFocused;

	private CharacterNameEventManager _characterNameEventManager;

	private CharacterSelectButton _selectButton;

	private BoxCollider _skipWithKeysButtonCollider;

	private BoxCollider _skipWithAdButtonCollider;

	private const float DEFAULT_SCALE_FACTOR = 9.3f;

	private const float FOCUSED_SCALE_FACTOR = 13f;

	private const float DEFAULT_Y_POSITION_ON_SCROLL = 0f;

	private const float FOCUSED_Y_POSITION_ON_SCROLL = -9f;

	private const float DEFAULT_FREEZE_VALUE = 1f;

	private const float FOCUSED_FREEZE_VALUE = 0f;

	private const float ANIMATION_SPEED_FACTOR = 2f;

	private const float SPACING_BETWEEN_CHARACTERS = 77f;

	private const string ONLINESETTINGS_ALLOW_SKIP_WITH_ADS_KEY = "character_name_event_skip_with_ads";

	private const bool DEFAULT_ALLOW_SKIP_WITH_ADS = true;

	private const string ONLINE_SETTING_EVENT_ELEMENT_NEW_POSITION_OFFSET = "event_popup_element_new_position_offset";

	private const string ONLINE_SETTING_EVENT_ELEMENT_NEW_ROTATION = "event_popup_element_new_rotation";

	private const string ONLINE_SETTING_EVENT_ELEMENT_NEW_SCALE = "event_popup_element_new_scale";

	private readonly Vector3 LP_POSITION_OFFSET;

	private readonly Vector3 LP_ROTATION;

	private readonly Vector3 LP_SCALE;

	private readonly Color32 _timerBackgroundColor;

	private readonly Color32 _timerContentColor;

	private bool isAllowedToSkipWithAds
	{
		get
		{
			//IL_000b: Expected I4, but got Obj
			return (byte)(int)"ChallengesScreen" != 0;
		}
	}

	public override void Init()
	{
		((UpgradeScreen)this).Start();
	}

	public override void GainFocus()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_0062: Expected I, but got Obj
		//IL_0078: Expected Obj, but got I
		//IL_00f0: Expected I, but got Obj
		//IL_0106: Expected Obj, but got I
		//IL_00a3: Expected I, but got Obj
		//IL_0131: Expected I, but got Obj
		ShowIfInactive();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120D9");
		InitializeTimer();
		UpdateSkipButtonState();
		object obj = this + 176;
		BoxCollider component = skipWithKeysButtonWidget.GetComponent<BoxCollider>();
		obj = component;
		object obj2 = this + 180;
		BoxCollider component2 = skipWithAdButtonWidget.GetComponent<BoxCollider>();
		obj2 = component2;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v30 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_skipWithAdButtonCollider == null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!(_skipWithKeysButtonCollider != null))
			{
				return;
			}
		}
		SDebug.LogFormat("Failed to find colliders on skip buttons", null);
	}

	public override void LoseFocus()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0020: Expected Obj, but got I4
		//IL_0035: Expected Obj, but got I4
		overlayClipAnchor.tag = (string)1;
		characterScrollAnchor.tag = (string)1;
		_categoryModelAnchor.tag = (string)1;
		InitScrollWithCharacterModels();
		CreateAndPositionLP3DElements();
		RefreshDescriptionBox();
		Hide();
	}

	private void SetActiveCharacterNameEventManager()
	{
		overlayClipAnchor.tag = null;
		characterScrollAnchor.tag = null;
		_categoryModelAnchor.tag = null;
	}

	private void InitializeSelectButton()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 168;
		string flurryUserId = Flurry.flurryUserId;
		CharacterNameEventManager typeOfActiveEventManager = ((SSEventsManagerController)(object)flurryUserId).GetTypeOfActiveEventManager<CharacterNameEventManager>();
		obj2 = typeOfActiveEventManager;
	}

	private void InitializeTimer()
	{
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0177: Expected I, but got Obj
		//IL_018d: Expected Obj, but got I
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Obj, but got Unknown
		//IL_01ff: Expected I4, but got Obj
		//IL_020c: Expected Obj, but got I4
		//IL_0226: Expected I, but got Obj
		//IL_023c: Expected Obj, but got I
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00bc: Expected Obj, but got I4
		//IL_00d9: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got F4
		object go = this - -64;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v14 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v37 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 172;
		int num3 = NGUITools.CalculateNextDepth((GameObject)go, (byte)(int)selectButtonPrefab != 0);
		CharacterSelectButton component = ((GameObject)num3).GetComponent<CharacterSelectButton>();
		obj2 = component;
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		Transform transform = (Transform)(obj4 + 12);
		if (((ComputeShader)(object)_selectButton).FindKernel((string)null) != 0)
		{
			GameObject gameObject = _selectButton.gameObject;
			((AssignTextureAndMaterial)(object)gameObject)._003CAwake_003Eb__3_0((Material)30);
			GameObject gameObject2 = _selectButton.gameObject;
			obj4 = 0;
			_ = 0;
			obj4 = 0f;
			_ = -173f;
			_ = 0f;
			transform = (Transform)obj4;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
			_selectButton.ShowLockedTokenContent(true);
			_selectButton.SetSticker(CharacterSelectButton.StickerType.Event);
		}
		else
		{
			SDebug.LogFormat("Failed to initialized select button", null);
		}
	}

	private void ReloadSelectButton(Characters.CharacterId charId, int themeIndex)
	{
		//IL_0165: Expected I, but got Obj
		//IL_017b: Expected Obj, but got I
		//IL_01f1: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_00c6: Expected I, but got Obj
		//IL_00dc: Expected Obj, but got I
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected Obj, but got Unknown
		//IL_0107: Expected I, but got Obj
		nint num = (nint)typeof(ChallengesScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.ChallengesScreen>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ChallengesScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v39 (Il2CppClass<UI.Screens.ChallengesScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ChallengesScreen._currentlySelectedPageIndex = (int)charId;
		object obj2 = 0;
		while (true)
		{
			GameObject gameObject = completeSignWidget;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v6 (UnityEngine.GameObject)+C]");
			if ((nint)obj3 >= 0)
			{
				break;
			}
			object obj4 = completeSignWidget + 16;
			object obj5 = obj2 << 2;
			object obj6 = obj4 + obj5;
			if ((nint)obj2 == (nint)charId)
			{
				((ChallengesScreen)this).ChangePage((int)charId, (byte)themeIndex != 0);
			}
			else
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v27 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v34 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)obj6).FindKernel((string)null) != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
				}
			}
			object obj8 = obj2 + 1;
			obj2 = obj8;
		}
	}

	private void UpdateSkipButtonState()
	{
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		GameObject parent = _timerContainer.gameObject;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 144;
		TimerHelper timerHelper = UnityEngine.Object.Instantiate(_timerPrefab, (Transform)(object)parent);
		obj2 = timerHelper;
	}

	private void OnSelectCharacter()
	{
		//IL_01f7: Expected I, but got Obj
		//IL_020d: Expected Obj, but got I
		//IL_0253: Expected Obj, but got I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00ab: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_0275: Expected Obj, but got I4
		//IL_00ec: Expected I, but got Obj
		//IL_0160: Expected I, but got Obj
		//IL_0176: Expected Obj, but got I
		//IL_01a1: Expected I, but got Obj
		OfferWallManager instance = OfferWallManager.instance;
		nint num = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S1_v3 (Il2CppClass<AdLocations>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v23 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = ((AdSystemManager)(object)instance).IsCaching((string)(object)AdLocations.WORDY_WEEKEND_VIDEOS);
		Characters.CharacterId initiallyCenteredCharacter = ((CharacterScreen)null).initiallyCenteredCharacter;
		object obj2 = (flag ? 1 : 0) & (int)initiallyCenteredCharacter;
		bool flag2 = _characterNameEventManager.HasLastCharacterBeenCompleted();
		object obj3 = obj2 ^ 1;
		string text = (string)(flag2 & obj3);
		skipWithKeysButtonWidget.tag = text;
		string text2 = (string)(obj2 & flag2);
		skipWithAdButtonWidget.tag = text2;
		nint num3 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v17 (Il2CppClass<AdLocations>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v42 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((WaterFallReach)(object)AdLocations.WORDY_WEEKEND_VIDEOS).OnFailedToCacheVideo((string)flag);
		if (!flag2 || ((CharacterScreen)null).initiallyCenteredCharacter == Characters.CharacterId.slick)
		{
			return;
		}
		nint num5 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v29 (Il2CppClass<AdLocations>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v36 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AdTrackingSystemLogger.LogVideoAdButtonClick(AdLocations.WORDY_WEEKEND_VIDEOS);
	}

	public override void Show()
	{
		StartTimer();
		((DiscountButton)(object)_selectButton).ShowOnSale((string)null, (string)null);
	}

	private unsafe void InitCategorySpecificElements()
	{
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected Obj, but got Unknown
		//IL_0352: Expected Obj, but got I4
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected Obj, but got Unknown
		//IL_0369: Expected Obj, but got I4
		//IL_0372: Expected Obj, but got I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0048: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected Obj, but got Unknown
		//IL_03cf: Expected I, but got Obj
		//IL_03e5: Expected Obj, but got I
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected Obj, but got Unknown
		//IL_0089: Expected I, but got Obj
		//IL_0123: Expected I, but got Obj
		//IL_0139: Expected Obj, but got I
		//IL_00d6: Expected I, but got Obj
		//IL_0484: Expected Obj, but got I
		//IL_0484: Expected Obj, but got I4
		//IL_0164: Expected I, but got Obj
		//IL_01d4: Expected Obj, but got I4
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected Obj, but got Unknown
		//IL_02e7: Expected I4, but got Obj
		//IL_02f6: Expected I4, but got Obj
		//IL_032f: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 12;
		obj = 0;
		object obj3 = obj2 + 8;
		obj3 = 0;
		obj2 = 0;
		base.Hide();
		InitializeSelectButton();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(CharacterNameEventPopup.HidePopupIfNeeded);
		object obj4 = action + 16;
		obj4 = this;
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v22 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v96 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SSEventsManagerController.OnSSEventFinishedHandler -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<Characters.CharacterId, int> action2 = default;
		object obj6 = action2 + 16;
		obj6 = this;
		nint num4 = (nint)typeof(CharacterScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v37 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num5 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v92 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterScreenManager.characterUnlocked -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr2;
		((Delegate)action3).method = (nint)__ldftn(CharacterNameEventPopup.OnSelectCharacter);
		object obj8 = action3 + 16;
		obj8 = this;
		CharacterScreenManager.onCharacterSelected -= action3;
		nint num6 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v50 (Il2CppClass<UIScreenController>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num7 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v88 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		bool flag3 = flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S1_v35 (System.Boolean)+38]");
		((UIScreenController)flag3).SetCameraToOrtographic((Camera)0, isOrtographic: true);
		bool flag4 = UIScreenController.ShouldShowOnlineScreen();
		bool flag5 = UIScreenController.ShouldShowOnlineScreen();
		bool flag6 = flag4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v38 (System.Boolean)+38]");
		((FPSLog)flag6).StartAutoFPSTest(runPreset: false);
		bool flag7 = UIScreenController.ShouldShowOnlineScreen();
		bool flag8 = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v41 (System.Boolean)+38]");
		Vector3 vector = NGUIMath.SpringDampen(ref *(Vector3*)null, 640f, 450f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action4 = default;
		((Delegate)action4).method_ptr = method_ptr3;
		((Delegate)action4).method = (nint)__ldftn(CharacterNameEventPopup.HidePopupIfNeeded);
		object obj10 = action4 + 16;
		obj10 = this;
		UIScreenController.OnApplicationResumed -= action4;
		InitScrollWithCharacterModels();
		CreateAndPositionLP3DElements();
		RefreshDescriptionBox();
		Hide();
		obj = string.Empty;
		obj3 = string.Empty;
		string flurryUserId = Flurry.flurryUserId;
		if (((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.lucy))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
		}
		firstTitle.fontSize = (int)obj;
		secondTitle.fontSize = (int)obj3;
		StartTimer();
		ScrollListTo(1);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77A9");
		((DiscountButton)(object)_selectButton).ShowOnSale((string)1, (string)obj2);
		StopTimer();
	}

	private void SetActiveIfExists(GameObject go, bool state)
	{
		StartTimer();
		if (_characterNameEventManager != null)
		{
			OnSelectCharacter();
		}
		((DiscountButton)(object)_selectButton).ShowOnSale((string)null, (string)null);
	}

	private void SetSkipButtonCollidersEnabled(bool state)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		object obj4 = default;
		object obj8 = default;
		while (true)
		{
			object obj = this - -64;
			object obj2 = obj;
			object obj3 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v4+C]");
			if ((nint)obj3 < 0)
			{
				object obj5 = this - -64;
				object obj6 = obj5 + 16;
				object obj7 = obj8 << 2;
				object obj9 = obj6 + obj7;
				bool pressed = (nint)obj8 == (state ? 1 : 0);
				((FooterButton)obj9).OnPress(pressed);
				obj4 = obj8 + 1;
				continue;
			}
			break;
		}
	}

	public override void Hide()
	{
		//IL_0115: Expected I4, but got Obj
		//IL_0133: Expected Obj, but got I4
		//IL_0151: Expected Obj, but got I4
		//IL_00f0: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I4
		if (_characterNameEventManager == null)
		{
			return;
		}
		Characters.CharacterId?[][] currentCharacterCollection = _characterNameEventManager.GetCurrentCharacterCollection();
		if (currentCharacterCollection == null)
		{
			goto IL_00a7;
		}
		Characters.CharacterId?[][] array;
		if ((nint)currentCharacterCollection != 1)
		{
			if ((nint)currentCharacterCollection == 2 || (nint)currentCharacterCollection == 3)
			{
				goto IL_00a7;
			}
			array = null;
		}
		else
		{
			EnableUIElementsForList();
			array = (Characters.CharacterId?[][])1;
		}
		goto IL_00f6;
		IL_00a7:
		array = currentCharacterCollection;
		goto IL_00f6;
		IL_00f6:
		bool focusedIndex = (nint)array == 1;
		((CharacterNameEventPopup)null).InsertCharacterIntoModelsList((Characters.CharacterId)_lpModel, focusedIndex ? 1 : 0);
		bool flag = (nint)array == 2;
		_movieIcon.tag = (string)flag;
		bool flag2 = (nint)array == 3;
		_danceIcon.tag = (string)flag2;
		bool flag3 = array == null;
		_superMysteryBoxIcon.tag = (string)flag3;
	}

	private unsafe void ClearScrollListOfCharacters()
	{
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_01fc: Expected I, but got Obj
		//IL_0212: Expected Obj, but got I
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected Obj, but got Unknown
		//IL_0285: Expected I, but got Obj
		//IL_029b: Expected Obj, but got I
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00b3: Expected I, but got Obj
		//IL_00c9: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_033a: Expected Obj, but got I
		//IL_033a: Expected Obj, but got I4
		//IL_00f4: Expected I, but got Obj
		//IL_0164: Expected Obj, but got I4
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		base.LoseFocus();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(CharacterNameEventPopup.HidePopupIfNeeded);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v66 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SSEventsManagerController.OnSSEventChangedHandler += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(CharacterNameEventPopup.ReloadSelectButton);
		object obj3 = action2 + 16;
		obj3 = this;
		nint num3 = (nint)typeof(CharacterScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v62 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterScreenManager.characterUnlockedFailure += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr3;
		((Delegate)action3).method = (nint)__ldftn(CharacterNameEventPopup.OnSelectCharacter);
		object obj5 = action3 + 16;
		obj5 = this;
		CharacterScreenManager.onFacebookStatusChanged += action3;
		InitScrollWithCharacterModels();
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v42 (Il2CppClass<UIScreenController>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v58 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		bool flag3 = flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S1_v29 (System.Boolean)+38]");
		((UIScreenController)flag3).SetCameraToOrtographic((Camera)0, isOrtographic: false);
		bool flag4 = UIScreenController.ShouldShowOnlineScreen();
		bool flag5 = UIScreenController.ShouldShowOnlineScreen();
		bool flag6 = flag4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v32 (System.Boolean)+38]");
		((FPSLog)flag6).StartAutoFPSTest(runPreset: false, runFrameTimes: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		_ = 0;
		Action<string> action4 = default;
		object obj7 = action4 + 16;
		obj7 = this;
		UIScreenController.OnPopupShown += action4;
		OnSkipClicked();
	}

	private void InitScrollWithCharacterModels()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_08cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d1: Expected Obj, but got Unknown
		//IL_08da: Expected Obj, but got I4
		//IL_08ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f4: Expected Obj, but got Unknown
		//IL_08fd: Expected Obj, but got I4
		//IL_0906: Unknown result type (might be due to invalid IL or missing references)
		//IL_090b: Expected Obj, but got Unknown
		//IL_0052: Expected Obj, but got I4
		//IL_00a7: Expected I, but got Obj
		//IL_00bd: Expected Obj, but got I
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected Obj, but got Unknown
		//IL_00e8: Expected I, but got Obj
		//IL_01a8: Expected I, but got Obj
		//IL_01be: Expected Obj, but got I
		//IL_0819: Expected Obj, but got I
		//IL_01e9: Expected I, but got Obj
		//IL_084f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0854: Expected Obj, but got Unknown
		//IL_0885: Unknown result type (might be due to invalid IL or missing references)
		//IL_088a: Expected Obj, but got Unknown
		//IL_02a9: Expected I, but got Obj
		//IL_02bf: Expected Obj, but got I
		//IL_02ea: Expected I, but got Obj
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_0778: Expected Obj, but got Unknown
		//IL_0781: Unknown result type (might be due to invalid IL or missing references)
		//IL_0786: Expected Obj, but got Unknown
		//IL_07b2: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10B1B");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj6 = default;
		object obj8 = default;
		object obj10 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v109 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S0_v179 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj8 == null)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ S0_v130 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ S0_v169 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj10 == null)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ S0_v150 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ S0_v159 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj12 = 37;
		object obj13 = obj12 - 9;
		object obj16;
		object obj17 = default;
		object obj14;
		if ((nint)obj12 != 9 && (nint)obj13 != 1)
		{
			if ((nint)obj13 != 2 && (nint)obj13 != 3)
			{
				if ((nint)obj13 == 4)
				{
					goto IL_07b7;
				}
				if ((nint)obj13 != 5 && (nint)obj13 != 6 && (nint)obj13 != 7 && (nint)obj13 != 8 && (nint)obj13 != 9 && (nint)obj13 != 10)
				{
					if ((nint)obj13 != 11)
					{
						if ((nint)obj13 != 12)
						{
							if ((nint)obj13 == 13 || (nint)obj13 == 14)
							{
								goto IL_09c6;
							}
							if ((nint)obj13 != 15)
							{
								if ((nint)obj13 == 16 || (nint)obj13 == 17 || (nint)obj13 == 18 || (nint)obj13 == 19 || (nint)obj13 == 20)
								{
									goto IL_09c6;
								}
								if ((nint)obj13 != 21)
								{
									if ((nint)obj13 != 22)
									{
										if ((nint)obj13 != 23 && (nint)obj13 != 24 && (nint)obj13 != 25 && (nint)obj13 != 26)
										{
											if ((nint)obj13 == 27)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
												object obj15 = default;
												obj14 = obj15;
												obj16 = obj17;
												goto IL_0981;
											}
											if ((nint)obj13 == 28)
											{
												object obj18 = obj5 + 4;
												object obj19 = obj18 + 1;
												obj18 = obj19;
												object obj20 = obj19 << 2;
												object obj21 = obj5 + obj20;
												obj21 = 99;
											}
										}
										goto IL_09c6;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj22 = default;
									obj14 = obj22;
									obj16 = obj17;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj23 = default;
									obj14 = obj23;
									obj16 = obj17;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj24 = default;
								obj14 = obj24;
								obj16 = obj17;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj25 = default;
							obj14 = obj25;
							obj16 = obj17;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj26 = default;
						obj14 = obj26;
						obj16 = obj17;
					}
					goto IL_0981;
				}
			}
			goto IL_09c6;
		}
		goto IL_07b7;
		IL_0981:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj27 = default;
		if (obj16 == obj27)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_09c6;
		IL_09eb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
		return;
		IL_09c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj28 = (nint)0 << 2;
			object obj29 = obj5 + obj28;
			if ((nint)obj29 == 99)
			{
				object obj30 = obj5 + 4;
				if ((nint)obj30 > -1)
				{
					object obj31 = obj30 + -1;
					obj30 = obj31;
				}
				goto IL_09eb;
			}
		}
		object obj32 = default;
		if (obj32 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_09eb;
		IL_07b7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj33 = default;
		obj14 = obj33;
		obj16 = obj17;
		goto IL_0981;
	}

	private void InsertCharacterIntoModelsList(Characters.CharacterId characterId, int focusedIndex)
	{
		//IL_0073: Expected I, but got Obj
		//IL_0089: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_005f: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)characterId).FindKernel(null) != 0)
		{
			((GameObject)characterId).tag = (string)focusedIndex;
		}
	}

	private void CreateAndPositionLP3DElements()
	{
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_026d: Expected VT, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_002f: Expected VT, but got I4
		//IL_003d: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got F4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_014a: Expected Obj, but got I4
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected I4, but got Unknown
		//IL_017c: Expected I4, but got Obj
		//IL_022e: Expected Obj, but got I4
		//IL_022e: Expected Obj, but got I4
		//IL_01dd: Expected Obj, but got I4
		//IL_01f1: Expected Obj, but got I4
		//IL_01f1: Expected Obj, but got I4
		int layer = characterScrollAnchor.layer;
		object obj = default;
		Transform transform = (Transform)(obj + 24);
		int layer2 = characterScrollAnchor.layer;
		transform.localPosition = (Vector3)layer2;
		Transform transform2 = (Transform)(obj + 12);
		int layer3 = characterScrollAnchor.layer;
		transform2.localPosition = (Vector3)layer3;
		obj = 0;
		_ = 0;
		obj = -77f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v5 (UnityEngine.Transform)+4]");
		_ = 0;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		Transform transform3 = (Transform)(obj + 36);
		transform3 = (Transform)obj;
		Transform transform4 = transform3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform3.eulerAngles;
		if (_characterNameEventManager == null)
		{
			return;
		}
		bool flag = _characterNameEventManager.IsShowingFirstElement();
		bool isFirstFocused = _characterNameEventManager.IsShowingLastElement();
		_isFirstFocused = isFirstFocused;
		bool isLastFocused = _characterNameEventManager.ShouldShowTheCompletedSign();
		_isLastFocused = isLastFocused;
		bool flag2 = _characterNameEventManager.IsLastCharacterSelected();
		if (_characterNameEventManager.IsFirstCharacterSelected())
		{
			object obj2 = (flag2 ? 1 : 0) ^ 1;
			int currentlyFocusedIndex = obj2 & 1;
			_currentlyFocusedIndex = currentlyFocusedIndex;
			_scrollPopulationStartFromSlot = (flag2 ? 1 : 0);
			((RectTransform)(object)this).SetSizeWithCurrentAnchors((RectTransform.Axis)"ScrollToNextCharacter", 0.3f);
		}
		else
		{
			bool isFirstFocused2 = _isFirstFocused;
			int currentlyFocusedIndex2 = (isFirstFocused2 ? 1 : 0) ^ 1;
			_currentlyFocusedIndex = currentlyFocusedIndex2;
			bool isFirstFocused3 = _isFirstFocused;
			_scrollPopulationStartFromSlot = (isFirstFocused3 ? 1 : 0);
		}
		int num = 0;
		while (true)
		{
			int num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v17 (System.Boolean)+C]");
			if ((nint)num2 >= (nint)0)
			{
				break;
			}
			Characters.CharacterId characterId = ((List<Characters.CharacterId>)flag).get_Item(num);
			SetInactiveCharacterBox((string)characterId, (string)_currentlyFocusedIndex);
			int num3 = num + 1;
			num = num3;
		}
		int layer4 = characterScrollAnchor.layer;
		((AssignTextureAndMaterial)layer4)._003CAwake_003Eb__3_0((Material)29);
	}

	private void PositionModelOnSprite(UISprite tracker, GameObject objectToPosition, Vector3 positionOffset, Vector3 newRotation, Vector3 newScale)
	{
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_007f: Expected Obj, but got VT
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_0092: Expected Obj, but got VT
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00a5: Expected Obj, but got VT
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x3FFF;
		object obj5 = obj4 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v26 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = this + 16;
		obj6 = objectToPosition;
		object obj7 = this + 20;
		obj7 = positionOffset;
		object obj8 = this + 24;
		obj8 = newRotation;
		object obj9 = this + 28;
		obj9 = newScale;
	}

	private unsafe IEnumerator DelayPositioning(UISprite tracker, GameObject objectToPosition, Vector3 positionOffset, Vector3 newRotation, Vector3 newScale)
	{
		//IL_00d6: Expected Obj, but got I4
		//IL_00e6: Expected Obj, but got I
		//IL_00ef: Expected Obj, but got I4
		//IL_011e: Expected Obj, but got I4
		//IL_011e: Expected Obj, but got I
		//IL_011e: Expected Obj, but got VT
		//IL_011e: Expected Ref, but got VT
		//IL_011e: Expected I, but got Obj
		//IL_0130: Expected Obj, but got I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_0152: Expected Obj, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		((Tree)(object)this).gen_bitlen((DeflateManager)19);
		object obj = (nint)((UnityEngine.Object)this).m_CachedPtr + 16;
		obj = 0;
		int num = Microsoft.Win32.Win32RegistryApi.RegQueryInfoKey((IntPtr)this, (StringBuilder)(object)tracker, (int[])null, (IntPtr)19, ref *(int*)19, (int[])null, (int[])null, ref *(int*)positionOffset, (int[])(object)objectToPosition, (int[])newRotation, (int[])(nint)((UnityEngine.Object)this).m_CachedPtr, (int[])showOldFooterSection);
		object obj2 = num - -5;
		int num2;
		if (num != -5)
		{
			if ((nint)obj2 != 1 && (nint)obj2 == 2)
			{
				object obj3 = newScale + 56;
				obj3 = "oversubscribed dynamic bit lengths tree";
				num2 = -3;
			}
			else
			{
				object obj4 = objectToPosition + 16;
				if (obj4 == null)
				{
					goto IL_00a6;
				}
				num2 = num;
			}
			goto IL_014d;
		}
		goto IL_00a6;
		IL_014d:
		return (IEnumerator)num2;
		IL_00a6:
		object obj5 = newScale + 56;
		obj5 = "incomplete dynamic bit lengths tree";
		num2 = -3;
		goto IL_014d;
	}

	private Vector3 VerifySettingOnline(string key, Vector3 defaultVal)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00d3: Expected Obj, but got I4
		//IL_0729: Expected Obj, but got I4
		//IL_0110: Expected I, but got Obj
		//IL_0126: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_01c8: Expected I, but got Obj
		//IL_01de: Expected Obj, but got I
		//IL_075c: Expected I4, but got Obj
		//IL_065d: Expected I, but got Obj
		//IL_0673: Expected Obj, but got I
		//IL_028c: Expected I4, but got Obj
		//IL_0151: Expected I, but got Obj
		//IL_05cf: Expected I, but got Obj
		//IL_05e5: Expected Obj, but got I
		//IL_02d2: Expected Obj, but got I
		//IL_0209: Expected I, but got Obj
		//IL_069e: Expected I, but got Obj
		//IL_03aa: Expected I, but got Obj
		//IL_03c0: Expected Obj, but got I
		//IL_0610: Expected I, but got Obj
		//IL_077c: Expected I4, but got Obj
		//IL_078b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0790: Expected Obj, but got Unknown
		//IL_0318: Expected Obj, but got I4
		//IL_0318: Expected Obj, but got I4
		//IL_0318: Expected Obj, but got I4
		//IL_0322: Expected Obj, but got VT
		//IL_03eb: Expected I, but got Obj
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected Obj, but got Unknown
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected Obj, but got Unknown
		//IL_04e9: Expected I, but got Obj
		//IL_04ff: Expected Obj, but got I
		//IL_07aa: Expected I4, but got Obj
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07be: Expected Obj, but got Unknown
		//IL_035e: Expected Obj, but got I4
		//IL_0368: Expected Obj, but got I4
		//IL_052a: Expected I, but got Obj
		Vector3 vector = default;
		if ((showOldFooterSection ? 1 : 0) == 10)
		{
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v107 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v115 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			_ = 1;
			bool flag2 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag2).PushScreen((string)(object)this);
		}
		else if ((showOldFooterSection ? 1 : 0) == 2)
		{
			InventorySave.AddPendingReward((CelebrationReward)(object)outline, (Func<CelebrationRewardOrigin, int>)_selectedFooterButton);
		}
		else if ((showOldFooterSection ? 1 : 0) == 3)
		{
			nint num3 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S2_v21 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S2_v26 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CharacterManager.SetOutfitSelectionIndex((Characters.CharacterId)_footerHandler, _selectedFooterButton);
		}
		else if ((showOldFooterSection ? 1 : 0) == 4)
		{
			nint num5 = (nint)typeof(Trophies);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S1_v69 (Il2CppClass<Info.Trophies>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Trophies);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S1_v74 (Il2CppClass<Info.Trophies>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((TrophyData)(object)base.parentScreen__BackingField)._002Ector();
		}
		else if ((showOldFooterSection ? 1 : 0) == 6)
		{
			GameObject gameObject = ((CelebrationPopup)null).ChooseRewardPrefab((CelebrationReward)(object)this);
			InventorySave.IncreaseAmount((UpgradeType)_selectedFooterButton, (int)gameObject);
		}
		else if (showOldFooterSection)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+2F8]");
			((CoinEarnerLoadingOffer)0).Init(null);
			GameObject sourceId = ((CelebrationPopup)null).ChooseRewardPrefab((CelebrationReward)(object)this);
			InventorySave.IncreaseKeys(_selectedFooterButton, (string)(object)sourceId);
			StayInOneLaneMission instance = StayInOneLaneMission.instance;
			((OwnBoardsAward)(object)instance)._002Ector((AwardStaticData)1, (PersistentAwardProgress)_selectedFooterButton, (Action<Award>)(-1));
			IEnumerator enumerator = ((CelebrationPopup)vector).TweenScaleUpDown((GameObject)(object)this);
			object obj4 = enumerator ^ 1;
			object obj5 = obj4 | defaultVal;
			if (obj5 == null)
			{
				((NewMonoBehaviour)33)._002Ector();
				((NewMonoBehaviour)32)._002Ector();
			}
		}
		else
		{
			if ((showOldFooterSection ? 1 : 0) == 12)
			{
				nint num7 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S1_v38 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num8 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S1_v53 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				BoardManager.LockBoard((Boards.BoardId)screenName);
				_0021_00210[] array = (_0021_00210[])(object)UnityEngine.Object.FindObjectsOfType<T>();
				object obj7 = this + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				throw new NullReferenceException();
			}
			if ((showOldFooterSection ? 1 : 0) == 7 && (nint)screenName == 6)
			{
				nint num9 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ S1_v18 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num10 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S1_v33 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				BoardManager.LockBoard((Boards.BoardId)screenName);
				_0021_00210[] array2 = (_0021_00210[])(object)UnityEngine.Object.FindObjectsOfType<T>();
				object obj9 = this + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				throw new NullReferenceException();
			}
		}
		if (key != null)
		{
			nint num11 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v23 (Il2CppClass<RewardManager>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num12 = (nint)typeof(RewardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v28 (Il2CppClass<RewardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((SaveMePopup)this).Init();
		}
		nint num13 = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v12 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num14 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v18 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveManager.Load();
		_ = 0;
		return vector;
	}

	private unsafe void EnableUIElementsForList()
	{
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_02c6: Expected Obj, but got I4
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected Obj, but got Unknown
		//IL_02eb: Expected Obj, but got I4
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected Obj, but got Unknown
		//IL_0310: Expected Obj, but got I4
		//IL_032c: Expected I, but got Obj
		//IL_0342: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected Obj, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected I4, but got Unknown
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected I4, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected Obj, but got Unknown
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected Obj, but got Unknown
		//IL_037b: Expected I4, but got Obj
		//IL_0387: Expected Obj, but got I4
		//IL_0391: Expected VT, but got I4
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_01b6: Expected I4, but got Obj
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01fe: Expected I4, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_024b: Expected I4, but got Obj
		//IL_0258: Expected I4, but got Obj
		//IL_026f: Expected I4, but got Obj
		//IL_02a9: Expected I4, but got Obj
		object obj = default;
		CoinScreen coinScreen = (CoinScreen)(obj + 60);
		coinScreen = (CoinScreen)0;
		((UnityEngine.Object)coinScreen).m_CachedPtr = (IntPtr)0;
		CoinScreen coinScreen2 = (CoinScreen)(obj + 48);
		coinScreen2 = (CoinScreen)0;
		((UnityEngine.Object)coinScreen2).m_CachedPtr = (IntPtr)0;
		CoinScreen coinScreen3 = (CoinScreen)(obj + 36);
		coinScreen3 = (CoinScreen)0;
		((UnityEngine.Object)coinScreen3).m_CachedPtr = (IntPtr)0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v88 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_lpModel != null)
		{
			nint num3 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v63 (Il2CppClass<NGUITools>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v71 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj4 = this + 148;
			int num5 = NGUITools.CalculateNextDepth(_categoryModelAnchor, (byte)(int)_lpModelPrefab != 0);
			obj4 = num5;
			Vector3 vector = NGUITools.Round((Vector3)31);
		}
		nint num6 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v79 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IPurchaseValidationResult purchaseValidationResult = (IPurchaseValidationResult)(obj + 96);
		bool flag = (byte)(obj + 84) != 0;
		bool flag2 = (byte)(obj + 72) != 0;
		object obj6 = obj + 24;
		object obj7 = obj + 12;
		if (((ComputeShader)(object)_lpModel).FindKernel((string)null) != 0)
		{
			object obj8 = this + 184;
			obj6 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v37+8]");
			_ = 0;
			purchaseValidationResult = (IPurchaseValidationResult)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S1_v31+8]");
			_ = 0;
			coinScreen.OnPurchaseSuccess((string)null, (byte)(int)"event_popup_element_new_position_offset" != 0, purchaseValidationResult);
			object obj9 = this + 196;
			obj7 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v47+8]");
			_ = 0;
			purchaseValidationResult = (IPurchaseValidationResult)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v33+8]");
			_ = 0;
			coinScreen2.OnPurchaseSuccess((string)null, (byte)(int)"event_popup_element_new_rotation" != 0, purchaseValidationResult);
			object obj10 = this + 208;
			obj = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S1_v57+8]");
			_ = 0;
			purchaseValidationResult = (IPurchaseValidationResult)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			coinScreen3.OnPurchaseSuccess((string)null, (byte)(int)"event_popup_element_new_scale" != 0, purchaseValidationResult);
			((bool*)(flag2 ? 1 : 0))->m_value = (byte)(int)coinScreen != 0;
			_ = ((UnityEngine.Object)coinScreen).m_CachedPtr;
			((bool*)(flag ? 1 : 0))->m_value = (byte)(int)coinScreen2 != 0;
			_ = ((UnityEngine.Object)coinScreen2).m_CachedPtr;
			purchaseValidationResult = (IPurchaseValidationResult)coinScreen3;
			_ = ((UnityEngine.Object)coinScreen3).m_CachedPtr;
			((LeaderboardOnlineScreen)this).InsertPlayerScoreToLeaderboard(ref *(int*)_topSplatSprite, ref *(int*)_lpModel, flag2, flag, (byte)(int)purchaseValidationResult != 0);
		}
	}

	private void RefreshDescriptionBox()
	{
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_00d0: Expected Obj, but got I4
		//IL_00d9: Expected Obj, but got I4
		//IL_005d: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I4
		//IL_008c: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		obj2 = 0;
		if (_characterNameEventManager != null)
		{
			CharacterNameEventManager characterNameEventManager = _characterNameEventManager;
			string text;
			if (characterNameEventManager._eventProgressData != null)
			{
				CharacterNameEventData eventProgressData = characterNameEventManager._eventProgressData;
				bool wasLastCharacterCompleted = eventProgressData.wasLastCharacterCompleted;
				text = (string)wasLastCharacterCompleted;
			}
			else
			{
				text = null;
			}
			completeSignWidget.tag = text;
			OnSelectCharacter();
			CharacterNameEventManager characterNameEventManager2 = _characterNameEventManager;
			object obj3;
			if (characterNameEventManager2._eventProgressData != null)
			{
				CharacterNameEventData eventProgressData2 = characterNameEventManager2._eventProgressData;
				obj3 = eventProgressData2.skippedCharacters + 3;
			}
			else
			{
				obj3 = 2;
			}
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			int fontSize = default;
			skipButtonKeyAmount.fontSize = fontSize;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77A9");
			((DiscountButton)(object)_selectButton).ShowOnSale((string)1, (string)obj2);
		}
	}

	private void SetInactiveCharacterBox(string descriptionLine1, string descriptionLine2)
	{
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_002e: Expected I, but got Obj
		//IL_0044: Expected Obj, but got I
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_006f: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 12;
		obj = this;
		if (_characterNameEventManager == null)
		{
			return;
		}
		CharacterNameEventManager characterNameEventManager = _characterNameEventManager;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
		string wordForCharacter = characterNameEventManager.GetWordForCharacter(Characters.CharacterId.slick);
		nint num = (nint)typeof(CharacterModelPreviewFactory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v18 (Il2CppClass<CharacterModelPreviewFactory>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(CharacterModelPreviewFactory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v24 (Il2CppClass<CharacterModelPreviewFactory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BoardScreenManager instance = BoardScreenManager.Instance;
		object obj4 = obj2 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	private void SetActiveCharacterBox(string descriptionLine1, string descriptionLine2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0030: Expected I4, but got Obj
		//IL_003f: Expected I4, but got Obj
		eventDescriptionBox.tag = (string)1;
		eventDescriptionBoxActive.tag = null;
		eventDescriptionBoxTitleInactive.fontSize = (int)descriptionLine1;
		eventDescriptionBoxName.fontSize = (int)descriptionLine2;
	}

	private unsafe void StartTimer()
	{
		//IL_0093: Expected I4, but got Obj
		//IL_0093: Expected I4, but got Obj
		ref string reference2 = default;
		ref string reference = ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 4);
		reference = ref *(string*)null;
		reference2 = ref *(string*)null;
		if (_characterNameEventManager != null)
		{
			((ExpiredLimitedBoardEventManager)(object)_characterNameEventManager).GetPopupTitle(out reference, out reference2);
			if (((ExpiredLimitedBoardEventManager)(object)_characterNameEventManager).GetEventType() != SSEventType.None)
			{
				((CharacterScreen)this).ChangeCurrentlyShownCharacter((Characters.CharacterId)reference, (int)reference2);
			}
			else
			{
				SetActiveCharacterBox(reference, reference2);
			}
		}
	}

	private unsafe void StopTimer()
	{
		//IL_0166: Expected I, but got Obj
		//IL_017c: Expected Obj, but got I
		//IL_024b: Expected I, but got Obj
		//IL_0261: Expected Obj, but got I
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected VT, but got Unknown
		//IL_01c6: Expected F4, but got Obj
		//IL_01c1: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v22 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		long currentEventID = ((SSEventsManagerController)(object)flurryUserId).GetCurrentEventID();
		nint num3 = (nint)typeof(TimeSpan);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v6 (Il2CppClass<System.TimeSpan>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v35 (Il2CppClass<System.TimeSpan>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3EB");
		object obj4 = default;
		object obj3 = obj4;
		Matrix4x4 matrix4x = (Matrix4x4)(obj3 + 8);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		throw new ArrayTypeMismatchException();
	}

	public void OnSkipClicked()
	{
		_timer.HideIcon();
	}

	public void OnSkipWithAdClicked()
	{
		if (_characterNameEventManager == null)
		{
			return;
		}
		if (_characterNameEventManager.SelectedCharacterMatchesFocusedCharacter())
		{
			_characterNameEventManager.LogWatchedAdToSkip();
			HidePopupIfNeeded();
			return;
		}
		SlideinPowerupHelper instance = SlideinPowerupHelper.Instance;
		CharacterNameEventManager characterNameEventManager = _characterNameEventManager;
		UpgradeType type;
		if (characterNameEventManager._eventProgressData != null)
		{
			CharacterNameEventData eventProgressData = characterNameEventManager._eventProgressData;
			type = (UpgradeType)(eventProgressData.skippedCharacters + 3);
		}
		else
		{
			type = (UpgradeType)2;
		}
		((PurchaseUpdater)(object)instance).UpgradePurchased(type);
	}

	private void OnSkipWithAdSuccessful()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_0054: Expected I, but got Obj
		if (_characterNameEventManager == null)
		{
			return;
		}
		nint num = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Il2CppClass<AdLocations>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v18 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AdTrackingSystemLogger.LogFillRequest(AdLocations.WORDY_WEEKEND_VIDEOS);
		OfferWallManager instance = OfferWallManager.instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		string text = default;
		text.m_stringLength = (int)num3;
		_ = 0;
		object obj2 = text + 16;
		obj2 = this;
		((AdSystemManager)(object)instance).FinishedWatchingVideo((string)(object)AdLocations.WORDY_WEEKEND_VIDEOS, text);
	}

	private void ScrollToNextCharacter()
	{
		//IL_0067: Expected I, but got Obj
		//IL_007d: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).AddBackButtonBehavior((string)1);
		_characterNameEventManager._002Ector();
		HidePopupIfNeeded();
	}

	private void ScrollListTo(int currentCharacterIndex)
	{
		//IL_0117: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_0074: Expected I, but got Obj
		//IL_008a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00b5: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_skipWithAdButtonCollider).FindKernel((string)null) != 0)
		{
			_skipWithAdButtonCollider.isTrigger = (byte)currentCharacterIndex != 0;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_skipWithKeysButtonCollider).FindKernel((string)null) != 0)
		{
			_skipWithKeysButtonCollider.isTrigger = (byte)currentCharacterIndex != 0;
		}
	}

	private IEnumerator AnimateScrollBar(HorizontalScrollDirections direction, float amount, float speedFactor)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_002b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = direction;
		return enumerator;
	}

	private IEnumerator AnimateCharacter(CharacterScreenController characterController, float scaleStartValue, float scaleEndValue, float positionStartValue, float positionEndValue, float freezeStart, float freezeEnd, float speedFactor)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	private bool IsFilteredCharacter(char newChar)
	{
		//IL_004d: Expected I4, but got Obj
		//IL_005b: Expected I4, but got Obj
		//IL_0069: Expected I4, but got Obj
		//IL_0077: Expected I4, but got Obj
		return newChar switch
		{
			'\0' => (byte)(int)"Word hunt" != 0, 
			'\u0001' => (byte)(int)"Missions" != 0, 
			'\u0002' => (byte)(int)"Weekly hunt" != 0, 
			_ => (byte)(int)string.Empty != 0, 
		};
	}

	public unsafe void HidePopupIfNeeded()
	{
		//IL_00d2: Expected VT, but got I4
		//IL_009b: Expected Ref, but got VT
		//IL_00af: Expected Obj, but got I4
		//IL_00af: Expected Obj, but got I4
		Characters.CharacterId? characterId = (Characters.CharacterId?)(object)0;
		if (_characterNameEventManager != null && ~(_isLastFocused ? 1u : 0u) != 0)
		{
			_isFirstFocused = false;
			_characterNameEventManager.ResetCollectProgress();
			char? c = _characterNameEventManager.NextLetterToSpawn();
			int currentlyFocusedIndex = _currentlyFocusedIndex + 1;
			_currentlyFocusedIndex = currentlyFocusedIndex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+4]");
			if ((nint)0 != 0)
			{
				Characters.CharacterId value = ((Characters.CharacterId?*)characterId)->Value;
				SetInactiveCharacterBox((string)value, (string)_currentlyFocusedIndex);
			}
			else
			{
				_isLastFocused = true;
			}
			((CharacterScreen)this).initiallyCenteredCharacter = (Characters.CharacterId)_currentlyFocusedIndex;
			StartTimer();
		}
	}

	public CharacterNameEventPopup()
	{
		//IL_012c: Expected I, but got Obj
		//IL_0142: Expected Obj, but got I
		//IL_01c0: Expected Obj, but got I4
		//IL_009d: Expected I, but got Obj
		//IL_00b3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0177: Expected Obj, but got I4
		//IL_00de: Expected I, but got Obj
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v31 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		bool flag = ((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick);
		bool flag2 = !flag;
		bool flag3 = _characterNameEventManager == null;
		object obj2 = flag2 | flag3;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750E");
			CharacterNameEventManager characterNameEventManager = _characterNameEventManager;
			object obj3 = default;
			if ((long)obj3 == characterNameEventManager._eventID)
			{
				return;
			}
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v18 (Il2CppClass<UIScreenController>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v24 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag4 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag4).ClosePopup((GameObject)(object)screenName);
	}
}

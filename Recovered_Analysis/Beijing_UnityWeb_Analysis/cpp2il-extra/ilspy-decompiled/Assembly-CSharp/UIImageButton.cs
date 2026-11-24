using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using UnityEngine;
using UnityEngine.U2D;

public class UIImageButton : MonoBehaviour
{
	public UISprite target;

	public string normalSprite;

	public string hoverSprite;

	public string pressedSprite;

	public string disabledSprite;

	public bool pixelSnap;

	public unsafe bool isEnabled
	{
		get
		{
			//IL_0369: Expected I4, but got Obj
			//IL_013e: Expected Obj, but got I4
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Expected Obj, but got Unknown
			//IL_007d: Expected I, but got Obj
			//IL_0093: Expected Obj, but got I
			//IL_0347: Expected Obj, but got I4
			//IL_00be: Expected I, but got Obj
			//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f2: Expected Obj, but got Unknown
			//IL_01fb: Expected Obj, but got I4
			//IL_0106: Expected Obj, but got I4
			//IL_0256: Unknown result type (might be due to invalid IL or missing references)
			//IL_025b: Expected Obj, but got Unknown
			//IL_0264: Expected Obj, but got I4
			//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c4: Expected Obj, but got Unknown
			//IL_02cd: Expected Obj, but got I4
			GameObject gameObject = base.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<Transform> list = default;
			list._002Ector();
			Sprite sprite = default;
			Sprite sprite2 = default;
			while (true)
			{
				int siblingIndex = ((Transform)(object)gameObject).GetSiblingIndex();
				if ((nint)sprite >= siblingIndex)
				{
					break;
				}
				bool flag = ((SpriteAtlas)(object)gameObject).CanBindTo(sprite);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIImageButton)+25]");
				if ((nint)0 != 0)
				{
					nint num = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v74 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v84 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)flag))
					{
						goto IL_0143;
					}
					string text = ((Component)flag).tag;
					if (!((GameObject)(object)text).activeInHierarchy)
					{
						goto IL_0143;
					}
				}
				list.Add((Transform)flag);
				goto IL_0143;
				IL_0143:
				sprite = (Sprite)(sprite2 + 1);
			}
			if (normalSprite != null && (nint)target != 2)
			{
				if ((nint)normalSprite == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num3 = 0;
					_ = 0;
					object obj3 = default;
					object obj2 = obj3 + 16;
					obj2 = 0;
					throw new NullReferenceException();
				}
				if ((nint)normalSprite == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num4 = 0;
					_ = 0;
					object obj5 = default;
					object obj4 = obj5 + 16;
					obj4 = 0;
					throw new NullReferenceException();
				}
				if ((nint)normalSprite == 3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num5 = 0;
					_ = 0;
					object obj7 = default;
					object obj6 = obj7 + 16;
					obj6 = 0;
					throw new NullReferenceException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIImageButton)+2C]");
				if ((nint)0 != 0)
				{
					throw new NullReferenceException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			}
			return (byte)(int)list != 0;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0e02: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e07: Expected Obj, but got Unknown
			//IL_0e10: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e15: Expected Obj, but got Unknown
			//IL_0e1e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e23: Expected Obj, but got Unknown
			//IL_0e2c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e31: Expected Obj, but got Unknown
			//IL_0e3a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e3f: Expected Obj, but got Unknown
			//IL_0e48: Expected Obj, but got I4
			//IL_0e57: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e5c: Expected Obj, but got Unknown
			//IL_0e65: Expected Obj, but got I4
			//IL_0e74: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e79: Expected Obj, but got Unknown
			//IL_0e82: Expected Obj, but got I4
			//IL_0e91: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e96: Expected Obj, but got Unknown
			//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eb2: Expected Obj, but got Unknown
			//IL_0ebb: Expected Obj, but got I4
			//IL_0eda: Expected Obj, but got I4
			//IL_0020: Expected Obj, but got I4
			//IL_0031: Expected VT, but got Obj
			//IL_0055: Expected F4, but got Obj
			//IL_0050: Expected native int or pointer, but got VT
			//IL_0067: Expected F4, but got I
			//IL_0062: Expected native int or pointer, but got VT
			//IL_0645: Expected I, but got Obj
			//IL_065b: Expected Obj, but got I
			//IL_1236: Expected F4, but got Obj
			//IL_1247: Expected F4, but got Obj
			//IL_1242: Expected native int or pointer, but got VT
			//IL_1250: Unknown result type (might be due to invalid IL or missing references)
			//IL_1255: Expected Obj, but got Unknown
			//IL_05af: Expected I, but got Obj
			//IL_05c5: Expected Obj, but got I
			//IL_0289: Expected Obj, but got I4
			//IL_02b9: Expected Obj, but got I4
			//IL_009c: Invalid comparison between Obj and F4
			//IL_0686: Expected I, but got Obj
			//IL_11bb: Expected F4, but got Obj
			//IL_11cc: Expected F4, but got Obj
			//IL_11c7: Expected native int or pointer, but got VT
			//IL_11d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_11da: Expected Obj, but got Unknown
			//IL_0fef: Expected I, but got F4
			//IL_0239: Expected Obj, but got I4
			//IL_0269: Expected Obj, but got I4
			//IL_0eea: Invalid comparison between I4 and F4
			//IL_0f0b: Expected I4, but got Obj
			//IL_05f0: Expected I, but got Obj
			//IL_130a: Expected Obj, but got I4
			//IL_00e6: Expected I, but got Obj
			//IL_00fc: Expected Obj, but got I
			//IL_0191: Expected I, but got Obj
			//IL_01a7: Expected Obj, but got I
			//IL_0f57: Expected I, but got Obj
			//IL_0473: Expected I, but got Obj
			//IL_0489: Expected Obj, but got I
			//IL_0f7d: Expected Obj, but got I
			//IL_0f91: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f96: Expected Obj, but got Unknown
			//IL_0fa9: Expected I, but got Obj
			//IL_0127: Expected I, but got Obj
			//IL_0725: Expected Obj, but got I4
			//IL_01d2: Expected I, but got Obj
			//IL_0772: Expected I, but got Obj
			//IL_0788: Expected Obj, but got I
			//IL_0967: Unknown result type (might be due to invalid IL or missing references)
			//IL_096c: Expected Obj, but got Unknown
			//IL_115f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1164: Expected Obj, but got Unknown
			//IL_04b4: Expected I, but got Obj
			//IL_07b3: Expected I, but got Obj
			//IL_0335: Expected VT, but got Obj
			//IL_0358: Expected I, but got Obj
			//IL_036e: Expected Obj, but got I
			//IL_1032: Expected F4, but got Obj
			//IL_102d: Expected native int or pointer, but got VT
			//IL_1044: Expected F4, but got I
			//IL_103f: Expected native int or pointer, but got VT
			//IL_106e: Expected VT, but got Obj
			//IL_10b9: Expected Obj, but got I
			//IL_10dd: Expected Obj, but got I
			//IL_10f3: Invalid comparison between Obj and F4
			//IL_1115: Expected I, but got Obj
			//IL_1123: Expected I, but got Obj
			//IL_08de: Expected Obj, but got F4
			//IL_08ff: Expected Obj, but got F4
			//IL_0908: Unknown result type (might be due to invalid IL or missing references)
			//IL_090d: Expected Obj, but got Unknown
			//IL_0924: Expected Obj, but got F4
			//IL_0531: Unknown result type (might be due to invalid IL or missing references)
			//IL_0536: Expected Obj, but got Unknown
			//IL_053f: Expected Obj, but got I4
			//IL_0399: Expected I, but got Obj
			//IL_0851: Unknown result type (might be due to invalid IL or missing references)
			//IL_0856: Expected Obj, but got Unknown
			//IL_086d: Expected Obj, but got F4
			//IL_0876: Unknown result type (might be due to invalid IL or missing references)
			//IL_087b: Expected Obj, but got Unknown
			//IL_0892: Expected Obj, but got F4
			//IL_0d64: Expected Obj, but got I
			//IL_0da2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0da7: Expected Obj, but got Unknown
			//IL_0dd8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ddd: Expected Obj, but got Unknown
			//IL_0cbe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cc3: Expected Obj, but got Unknown
			//IL_0ccc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cd1: Expected Obj, but got Unknown
			//IL_0cfd: Expected Obj, but got I4
			Vector3 vector = default;
			object obj = vector + 144;
			Transform transform = (Transform)(vector + 16);
			Transform transform2 = (Transform)(vector + 56);
			object obj2 = vector + 44;
			object obj3 = vector + 32;
			object obj4 = vector + 120;
			obj4 = 0;
			_ = 0;
			object obj5 = vector + 104;
			obj5 = 0;
			_ = 0;
			object obj6 = vector + 88;
			obj6 = 0;
			_ = 0;
			object obj7 = vector + 80;
			obj7 = obj;
			_ = -1;
			object obj8 = vector + 68;
			obj8 = 0;
			_ = 0;
			_ = 0;
			GameObject gameObject = base.gameObject;
			object obj9 = 0;
			int num2 = default;
			object obj13 = default;
			nint num5 = default;
			string text = default;
			object obj17 = default;
			object obj21 = default;
			int num15 = default;
			while (true)
			{
				int num = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+C]");
				if ((nint)num >= (nint)0)
				{
					break;
				}
				Transform transform3 = ((List<Transform>)value).get_Item(num2);
				transform.localPosition = (Vector3)transform3;
				obj4 = transform;
				_ = ((UnityEngine.Object)transform).m_CachedPtr;
				((Vector3*)(nint)vector)->x = (float)transform;
				((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
				if ((nint)target == 2)
				{
					if (System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref disabledSprite) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f))
					{
						transform = (Transform)obj4;
						Transform transform4 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
						((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
						nint num3 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S0_v372 (Il2CppClass<UnityEngine.Mathf>)+BA]");
						object obj10 = (nint)0 & (nint)0x200;
						if (obj10 != null)
						{
							nint num4 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ S0_v377 (Il2CppClass<UnityEngine.Mathf>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						object obj11 = (object)transform / (object)disabledSprite;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
						object obj12 = obj13 * (object)disabledSprite;
						obj4 = obj12;
						num5 = (nint)typeof(Mathf);
						text = disabledSprite;
					}
					bool flag = (float)(pixelSnap ? 1 : 0) > 0f;
					bool flag2 = !flag;
					nint num6 = num5;
					bool flag3 = (byte)(int)text != 0;
					if (!flag2)
					{
						transform = (Transform)obj4;
						Transform transform5 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
						((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
						nint num7 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ S0_v356 (Il2CppClass<UnityEngine.Mathf>)+BA]");
						object obj14 = (nint)0 & (nint)0x200;
						if (obj14 != null)
						{
							nint num8 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ S0_v361 (Il2CppClass<UnityEngine.Mathf>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Transform)+4]");
						object obj15 = (nint)0 / (nint)(pixelSnap ? 1 : 0);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
						object obj16 = obj17 * pixelSnap;
						num6 = (nint)typeof(Mathf);
						flag3 = pixelSnap;
					}
					num5 = num6;
					text = (string)flag3;
				}
				else
				{
					if ((object)target != null)
					{
						transform = (Transform)0;
						((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)0;
						object obj18 = (object)disabledSprite * obj9;
						transform = (Transform)obj18;
						object obj19 = 0 - (pixelSnap ? 1 : 0);
						object obj20 = obj19 * obj21;
					}
					else
					{
						transform = (Transform)0;
						((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)0;
						object obj22 = (object)disabledSprite * obj21;
						transform = (Transform)obj22;
						object obj23 = 0 - (pixelSnap ? 1 : 0);
						object obj24 = obj23 * obj9;
					}
					((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)vector.z;
					obj8 = transform;
					_ = ((UnityEngine.Object)transform).m_CachedPtr;
					obj4 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v32+8]");
					_ = 0;
					text = disabledSprite;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIImageButton)+24]");
				if ((nint)0 == 0 || Application.platform == RuntimePlatform.OSXEditor)
				{
					goto IL_0436;
				}
				bool flag4 = hoverSprite == null;
				bool flag5 = !flag4;
				nint num9 = num5;
				if (!flag5)
				{
					transform2.localPosition = (Vector3)transform3;
					obj2 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
					_ = 0;
					nint num10 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ S0_v299 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj25 = (nint)0 & (nint)0x200;
					if (obj25 != null)
					{
						nint num11 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ S0_v317 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Vector3*)(nint)vector)->x = (float)transform2;
					((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
					transform = (Transform)obj2;
					Transform transform6 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
					Quaternion quaternion = Quaternion.FromToRotation(vector, (Vector3)transform);
					transform = (Transform)obj3;
					Transform transform7 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
					((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
					object obj26 = (object)transform * (object)transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Transform)+4]");
					nint num12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Transform)+4]");
					object obj27 = num12 * 0;
					object obj28 = obj26 + obj27;
					object obj29 = (nint)((UnityEngine.Object)transform).m_CachedPtr * (nint)((UnityEngine.Object)transform).m_CachedPtr;
					object obj30 = obj28 + obj29;
					bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj30) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.0001f);
					bool flag7 = !flag6;
					num9 = (nint)typeof(Vector3);
					num5 = (nint)typeof(Vector3);
					if (flag7)
					{
						goto IL_0436;
					}
				}
				string text2 = transform3.tag;
				transform = (Transform)obj4;
				Transform transform8 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
				IEnumerator enumerator = ((SpawnPool)(object)text2).DoDespawnAfterSeconds(transform, 15f);
				_ = 1;
				_ = 1;
				num5 = num9;
				goto IL_0465;
				IL_0436:
				transform = (Transform)obj4;
				Transform transform9 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				((UnityEngine.Object)transform9).m_CachedPtr = (IntPtr)0;
				Vector3 eulerAngles = transform.eulerAngles;
				goto IL_0465;
				IL_0465:
				nint num13 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ S0_v252 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj31 = (nint)0 & (nint)0x200;
				if (obj31 != null)
				{
					nint num14 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ S0_v276 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) || System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9))
				{
					object obj32 = obj21 + 1;
					string text3 = pressedSprite;
					bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32) >= System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref text3);
					bool flag9 = !flag8;
					obj21 = obj32;
					if (!flag9)
					{
						bool flag10 = (nint)pressedSprite >= 1;
						bool flag11 = !flag10;
						obj21 = obj32;
						if (!flag11)
						{
							object obj33 = obj9 + 1;
							obj21 = 0;
							obj9 = obj33;
						}
					}
				}
				num2 = num15 + 1;
			}
			if (hoverSprite == null)
			{
				return;
			}
			NGUIMath.OverlayPosition(transform, (Transform)(object)hoverSprite);
			float num19;
			float num20;
			if ((object)target != null)
			{
				transform = transform;
				nint num16 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S0_v219 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj34 = (nint)0 & (nint)0x200;
				if (obj34 != null)
				{
					nint num17 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ S0_v232 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float b = (float)obj9 * (float)disabledSprite;
				float num18 = Mathf.LerpUnclamped(0f, b, (float)transform);
				((Vector3*)(nint)vector)->x = (float)transform;
				object obj35 = 0 - obj21;
				float a = (float)obj35 * (float)(pixelSnap ? 1 : 0);
				num19 = Mathf.LerpUnclamped(a, 0f, vector.y);
				num20 = num18;
			}
			else
			{
				transform = transform;
				nint num21 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v198 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj36 = (nint)0 & (nint)0x200;
				if (obj36 != null)
				{
					nint num22 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S0_v211 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float b2 = (float)obj21 * (float)disabledSprite;
				float num23 = Mathf.LerpUnclamped(0f, b2, (float)transform);
				((Vector3*)(nint)vector)->x = (float)transform;
				object obj37 = 0 - obj9;
				float a2 = (float)obj37 * (float)(pixelSnap ? 1 : 0);
				num19 = Mathf.LerpUnclamped(a2, 0f, vector.y);
				num20 = num23;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj5 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			object obj38 = default;
			object obj40 = default;
			object obj42 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj38 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num24 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ S0_v144 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj39 = (nint)0 & (nint)0x200;
				if (obj39 != null)
				{
					nint num25 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ S0_v183 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj40 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					object obj41 = obj42 + 12;
					float num26 = (float)obj41 - num20;
					obj41 = num26;
					object obj43 = obj42 + 16;
					float num27 = (float)obj43 - num19;
					obj43 = num27;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					obj6 = vector.x;
					_ = vector.z;
					float num28 = (float)obj6 - num20;
					obj6 = num28;
					object obj44 = obj6 + 4;
					float num29 = (float)obj44 - num19;
					obj44 = num29;
					transform = (Transform)obj6;
					Transform transform10 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v23+8]");
					((UnityEngine.Object)transform10).m_CachedPtr = (IntPtr)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				}
			}
			object obj45 = 72;
			object obj46 = obj45 - 52;
			object obj49;
			object obj50 = default;
			if ((nint)obj45 != 52)
			{
				if ((nint)obj46 != 1)
				{
					if ((nint)obj46 != 2)
					{
						if ((nint)obj46 == 3 || (nint)obj46 == 4)
						{
							goto IL_1356;
						}
						if ((nint)obj46 != 5)
						{
							if ((nint)obj46 == 6 || (nint)obj46 == 7 || (nint)obj46 == 8)
							{
								goto IL_1356;
							}
							if ((nint)obj46 != 9)
							{
								object obj47;
								if ((nint)obj46 != 10)
								{
									if ((nint)obj46 != 11 && (nint)obj46 != 12 && (nint)obj46 != 13 && (nint)obj46 != 14 && (nint)obj46 != 15)
									{
										if ((nint)obj46 == 16 || (nint)obj46 == 17)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj48 = default;
											obj47 = obj48;
											obj49 = obj50;
											goto IL_12a7;
										}
										if ((nint)obj46 != 18)
										{
											if ((nint)obj46 == 19)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
												object obj51 = default;
												obj47 = obj51;
												obj49 = obj50;
												goto IL_12a7;
											}
											if ((nint)obj46 == 20)
											{
												object obj52 = obj7 + 4;
												object obj53 = obj52 + 1;
												obj52 = obj53;
												object obj54 = obj53 << 2;
												object obj55 = obj7 + obj54;
												obj55 = 696;
											}
										}
									}
									goto IL_1356;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj56 = default;
								obj47 = obj56;
								obj49 = obj50;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj57 = default;
								object obj47 = obj57;
								obj49 = obj50;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj58 = default;
							object obj47 = obj58;
							obj49 = obj50;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj59 = default;
						object obj47 = obj59;
						obj49 = obj50;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj60 = default;
					object obj47 = obj60;
					obj49 = obj50;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj61 = default;
				object obj47 = obj61;
				obj49 = obj50;
			}
			goto IL_12a7;
			IL_12a7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj62 = default;
			if (obj49 == obj62)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			}
			goto IL_1356;
			IL_1356:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v29+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v29+4]");
				object obj63 = (nint)0 << 2;
				object obj64 = obj7 + obj63;
				if ((nint)obj64 == 696)
				{
					object obj65 = obj7 + 4;
					if ((nint)obj65 > -1)
					{
						object obj66 = obj65 + -1;
						obj65 = obj66;
					}
					return;
				}
			}
			object obj67 = default;
			if (obj67 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
	}

	private void OnEnable()
	{
		//IL_000b: Expected Obj, but got F4
		//IL_0016: Expected I4, but got F4
		disabledSprite = (string)200f;
		pixelSnap = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	private void OnValidate()
	{
		//IL_0082: Expected I, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (target != null)
		{
			object obj2 = this + 12;
			_0021_00210[] componentsInChildren = (_0021_00210[])(object)((Component)this).GetComponentsInChildren<T>();
			obj2 = componentsInChildren;
		}
		this._002Ector();
	}

	private void UpdateImage()
	{
		//IL_01c1: Expected I, but got Obj
		//IL_01d7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)target).FindKernel((string)null) != 0)
		{
			string text = normalSprite;
			if (normalSprite == null || text.m_stringLength == 0)
			{
				object obj2 = this + 16;
				UISprite uISprite = target;
				obj2 = uISprite.mSpriteName;
			}
			string text2 = hoverSprite;
			if (hoverSprite == null || text2.m_stringLength == 0)
			{
				object obj3 = this + 20;
				UISprite uISprite2 = target;
				obj3 = uISprite2.mSpriteName;
			}
			string text3 = pressedSprite;
			if (pressedSprite == null || text3.m_stringLength == 0)
			{
				object obj4 = this + 24;
				UISprite uISprite3 = target;
				obj4 = uISprite3.mSpriteName;
			}
			string text4 = disabledSprite;
			if (disabledSprite == null || text4.m_stringLength == 0)
			{
				object obj5 = this + 28;
				UISprite uISprite4 = target;
				obj5 = uISprite4.mSpriteName;
			}
		}
	}

	private void OnHover(bool isOver)
	{
		//IL_00c6: Expected I, but got Obj
		//IL_00dc: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006c: Expected Obj, but got I4
		string text = tag;
		Collider component = ((GameObject)(object)text).GetComponent<Collider>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)component))
		{
			bool isTrigger = component.isTrigger;
			object obj2 = isTrigger ^ isOver;
			if (obj2 != null)
			{
				component.isTrigger = isOver;
				this._002Ector();
			}
		}
	}

	private void OnPress(bool pressed)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00c5: Expected I4, but got Obj
		//IL_00b6: Expected I4, but got Obj
		string captionText = ((UIKeyBinding)this).captionText;
		if (captionText == null)
		{
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)target).FindKernel((string)null) != 0)
		{
			bool pressed2 = (byte)((!pressed) ? ((int)normalSprite) : ((int)hoverSprite)) != 0;
			((UIKeyBinding)this).OnBindingPress(pressed2);
		}
	}

	private void SetSprite(string sprite)
	{
		//IL_0029: Expected I4, but got Obj
		if (sprite != null)
		{
			((UIKeyBinding)this).OnBindingPress((byte)(int)pressedSprite != 0);
		}
		else
		{
			this._002Ector();
		}
	}

	public UIImageButton()
	{
		//IL_0159: Expected I, but got Obj
		//IL_016f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0196: Expected I4, but got Obj
		//IL_0090: Expected I4, but got Obj
		//IL_0146: Expected I4, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0137: Expected I4, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)target).FindKernel((string)null) == 0)
		{
			return;
		}
		string captionText = ((UIKeyBinding)this).captionText;
		if (captionText == null)
		{
			((UIKeyBinding)this).OnBindingPress((byte)(int)disabledSprite != 0);
			return;
		}
		string text = tag;
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v21 (Il2CppClass<UICamera>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v26 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UICamera uICamera = UICamera.FindCameraForLayer((int)text);
		bool pressed = (byte)(((object)uICamera == null) ? ((int)normalSprite) : ((int)hoverSprite)) != 0;
		((UIKeyBinding)this).OnBindingPress(pressed);
	}
}

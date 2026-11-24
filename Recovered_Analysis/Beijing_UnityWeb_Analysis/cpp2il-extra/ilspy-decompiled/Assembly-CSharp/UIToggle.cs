using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.U2D;

public class UIToggle : UIWidgetContainer
{
	public delegate bool Validate(bool choice);

	public static BetterList<UIToggle> list;

	public static UIToggle current;

	public int group;

	public UIWidget activeSprite;

	public bool invertSpriteState;

	public Animation activeAnimation;

	public Animator animator;

	public UITweener tween;

	public bool startsActive;

	public bool instantTween;

	public bool optionCanBeNone;

	public List<EventDelegate> onChange;

	public Validate validator;

	private UISprite checkSprite;

	private Animation checkAnimation;

	private GameObject eventReceiver;

	private string functionName;

	private bool startsChecked;

	private bool mIsActive;

	private bool mStarted;

	public unsafe bool value
	{
		get
		{
			//IL_03b4: Expected I4, but got Obj
			//IL_01a4: Expected Obj, but got I4
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Expected Obj, but got Unknown
			//IL_0077: Expected I, but got Obj
			//IL_008d: Expected Obj, but got I
			//IL_0220: Unknown result type (might be due to invalid IL or missing references)
			//IL_0225: Expected Obj, but got Unknown
			//IL_022e: Expected Obj, but got I4
			//IL_0374: Expected Obj, but got I4
			//IL_0289: Unknown result type (might be due to invalid IL or missing references)
			//IL_028e: Expected Obj, but got Unknown
			//IL_0297: Expected Obj, but got I4
			//IL_00b8: Expected I, but got Obj
			//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f7: Expected Obj, but got Unknown
			//IL_0300: Expected Obj, but got I4
			//IL_0100: Expected Obj, but got I4
			//IL_0112: Expected I, but got Obj
			//IL_0128: Expected Obj, but got I
			//IL_0153: Expected I, but got Obj
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
				if ((object)tween != null)
				{
					nint num = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v71 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v81 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)flag))
					{
						goto IL_01a9;
					}
					string fileName = ((Component)flag).tag;
					nint num3 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S1_v46 (Il2CppClass<NGUITools>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num4 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S1_v51 (Il2CppClass<NGUITools>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					byte[] array = NGUITools.Load(fileName);
					if (array == null)
					{
						goto IL_01a9;
					}
				}
				list.Add((Transform)flag);
				goto IL_01a9;
				IL_01a9:
				sprite = (Sprite)(sprite2 + 1);
			}
			if (~(invertSpriteState ? 1u : 0u) == 0)
			{
				if (invertSpriteState)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num5 = 0;
					_ = 0;
					object obj4 = default;
					object obj3 = obj4 + 16;
					obj3 = 0;
					throw new NullReferenceException();
				}
				if ((invertSpriteState ? 1 : 0) == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num6 = 0;
					_ = 0;
					object obj6 = default;
					object obj5 = obj6 + 16;
					obj5 = 0;
					throw new NullReferenceException();
				}
				if ((invertSpriteState ? 1 : 0) == 3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num7 = 0;
					_ = 0;
					object obj8 = default;
					object obj7 = obj8 + 16;
					obj7 = 0;
					throw new NullReferenceException();
				}
				if ((object)checkSprite != null)
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
			//IL_2842: Unknown result type (might be due to invalid IL or missing references)
			//IL_2847: Expected Obj, but got Unknown
			//IL_2850: Expected Obj, but got I4
			//IL_285f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2864: Expected Obj, but got Unknown
			//IL_286d: Expected Obj, but got I4
			//IL_2882: Unknown result type (might be due to invalid IL or missing references)
			//IL_2887: Expected Obj, but got Unknown
			//IL_2890: Expected Obj, but got I4
			//IL_289f: Unknown result type (might be due to invalid IL or missing references)
			//IL_28a4: Expected Obj, but got Unknown
			//IL_28ad: Expected Obj, but got I4
			//IL_28c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_28c7: Expected Obj, but got Unknown
			//IL_28d0: Expected Obj, but got I4
			//IL_28e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_28ea: Expected Obj, but got Unknown
			//IL_28f3: Expected Obj, but got I4
			//IL_2908: Unknown result type (might be due to invalid IL or missing references)
			//IL_290d: Expected Obj, but got Unknown
			//IL_2916: Expected Obj, but got I4
			//IL_2925: Unknown result type (might be due to invalid IL or missing references)
			//IL_292a: Expected Obj, but got Unknown
			//IL_2933: Expected Obj, but got I4
			//IL_2948: Unknown result type (might be due to invalid IL or missing references)
			//IL_294d: Expected Obj, but got Unknown
			//IL_2956: Expected Obj, but got I4
			//IL_2965: Unknown result type (might be due to invalid IL or missing references)
			//IL_296a: Expected Obj, but got Unknown
			//IL_00c5: Expected F4, but got I4
			//IL_29da: Unknown result type (might be due to invalid IL or missing references)
			//IL_29df: Expected Obj, but got Unknown
			//IL_29e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_29ed: Expected Obj, but got Unknown
			//IL_29f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_29fb: Expected Obj, but got Unknown
			//IL_2a04: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a09: Expected Obj, but got Unknown
			//IL_2a12: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a17: Expected Obj, but got Unknown
			//IL_2a20: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a25: Expected Obj, but got Unknown
			//IL_2a2e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a33: Expected Obj, but got Unknown
			//IL_2a3c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a41: Expected Obj, but got Unknown
			//IL_2a4a: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a4f: Expected VT, but got Unknown
			//IL_2a57: Expected native int or pointer, but got VT
			//IL_2a69: Expected F4, but got I4
			//IL_2a64: Expected native int or pointer, but got VT
			//IL_0067: Expected Obj, but got I4
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Expected VT, but got Unknown
			//IL_0122: Expected Obj, but got F4
			//IL_0135: Expected Obj, but got I4
			//IL_2b29: Expected Obj, but got I4
			//IL_01bd: Expected Obj, but got I4
			//IL_0179: Expected Obj, but got I4
			//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05cd: Expected Obj, but got Unknown
			//IL_026e: Expected I, but got Obj
			//IL_0284: Expected Obj, but got I
			//IL_2a98: Expected F4, but got Obj
			//IL_2a93: Expected native int or pointer, but got VT
			//IL_2aad: Expected F4, but got I
			//IL_2aa8: Expected native int or pointer, but got VT
			//IL_2aba: Expected F4, but got Obj
			//IL_2ab5: Expected native int or pointer, but got VT
			//IL_2acf: Expected F4, but got I
			//IL_2aca: Expected native int or pointer, but got VT
			//IL_2aed: Expected F4, but got Obj
			//IL_2ae8: Expected native int or pointer, but got VT
			//IL_2b02: Expected F4, but got I
			//IL_2afd: Expected native int or pointer, but got VT
			//IL_02af: Expected I, but got Obj
			//IL_0334: Expected F4, but got Obj
			//IL_032f: Expected native int or pointer, but got VT
			//IL_0349: Expected F4, but got I
			//IL_0344: Expected native int or pointer, but got VT
			//IL_0356: Expected F4, but got Obj
			//IL_0351: Expected native int or pointer, but got VT
			//IL_036b: Expected F4, but got I
			//IL_0366: Expected native int or pointer, but got VT
			//IL_0389: Expected F4, but got Obj
			//IL_0384: Expected native int or pointer, but got VT
			//IL_039e: Expected F4, but got I
			//IL_0399: Expected native int or pointer, but got VT
			//IL_03cd: Expected F4, but got Obj
			//IL_03c8: Expected native int or pointer, but got VT
			//IL_03e2: Expected F4, but got I
			//IL_03dd: Expected native int or pointer, but got VT
			//IL_0406: Expected F4, but got Obj
			//IL_0401: Expected native int or pointer, but got VT
			//IL_041b: Expected F4, but got I
			//IL_0416: Expected native int or pointer, but got VT
			//IL_0435: Expected native int or pointer, but got VT
			//IL_0447: Expected native int or pointer, but got VT
			//IL_0462: Unknown result type (might be due to invalid IL or missing references)
			//IL_0467: Expected Obj, but got Unknown
			//IL_0470: Unknown result type (might be due to invalid IL or missing references)
			//IL_0475: Expected Obj, but got Unknown
			//IL_2e03: Expected Obj, but got VT
			//IL_0b73: Expected Obj, but got I
			//IL_04d3: Expected F4, but got Obj
			//IL_04ce: Expected native int or pointer, but got VT
			//IL_04e8: Expected F4, but got I
			//IL_04e3: Expected native int or pointer, but got VT
			//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0503: Expected Obj, but got Unknown
			//IL_050c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0511: Expected Obj, but got Unknown
			//IL_0c2a: Expected Obj, but got F4
			//IL_0c3d: Expected Obj, but got I4
			//IL_0544: Unknown result type (might be due to invalid IL or missing references)
			//IL_0549: Expected Obj, but got Unknown
			//IL_2cc5: Expected Obj, but got F4
			//IL_2cd7: Expected Obj, but got I4
			//IL_0ba9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bae: Expected Obj, but got Unknown
			//IL_2cb7: Expected Obj, but got I4
			//IL_0c5a: Expected Obj, but got I4
			//IL_0bdf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0be4: Expected Obj, but got Unknown
			//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b2: Expected Obj, but got Unknown
			//IL_2b6d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b72: Expected Obj, but got Unknown
			//IL_0c7b: Expected Obj, but got I4
			//IL_0c97: Expected Obj, but got F4
			//IL_0cb7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cbc: Expected Obj, but got Unknown
			//IL_0cc5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cca: Expected Obj, but got Unknown
			//IL_0ce4: Expected F4, but got Obj
			//IL_0cdf: Expected native int or pointer, but got VT
			//IL_0cf9: Expected F4, but got I
			//IL_0cf4: Expected native int or pointer, but got VT
			//IL_0d13: Expected Obj, but got F4
			//IL_0d33: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d38: Expected Obj, but got Unknown
			//IL_0d41: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d46: Expected Obj, but got Unknown
			//IL_0daf: Expected Obj, but got I4
			//IL_0e08: Expected Obj, but got F4
			//IL_0e1b: Expected Obj, but got I4
			//IL_1f11: Expected Obj, but got I
			//IL_0e33: Expected Obj, but got I4
			//IL_0e4b: Expected Obj, but got I4
			//IL_1fca: Expected Obj, but got VT
			//IL_1f47: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f4c: Expected Obj, but got Unknown
			//IL_0e63: Expected Obj, but got I4
			//IL_1fe2: Expected I4, but got Obj
			//IL_1ff3: Expected Obj, but got F4
			//IL_0e75: Expected Obj, but got F4
			//IL_0e83: Expected I, but got Obj
			//IL_0e99: Expected Obj, but got I
			//IL_2026: Expected Obj, but got F4
			//IL_2034: Expected I, but got Obj
			//IL_204a: Expected Obj, but got I
			//IL_1f7d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f82: Expected Obj, but got Unknown
			//IL_2bc9: Expected Obj, but got I4
			//IL_2d2c: Expected F4, but got Obj
			//IL_2d2c: Expected F4, but got Obj
			//IL_2d47: Expected Obj, but got F4
			//IL_2d58: Expected F4, but got I
			//IL_2d72: Expected F4, but got I
			//IL_0f12: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f17: Expected Obj, but got Unknown
			//IL_0ec4: Expected I, but got Obj
			//IL_2075: Expected I, but got Obj
			//IL_111f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1124: Expected Obj, but got Unknown
			//IL_1137: Expected Obj, but got I4
			//IL_0f07: Expected Obj, but got I4
			//IL_114f: Expected Obj, but got I4
			//IL_0fa7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fac: Expected Obj, but got Unknown
			//IL_0fbf: Expected Obj, but got I4
			//IL_1167: Expected Obj, but got I4
			//IL_0fd7: Expected Obj, but got I4
			//IL_117f: Expected Obj, but got I4
			//IL_0fef: Expected Obj, but got I4
			//IL_2126: Expected Obj, but got I4
			//IL_1191: Expected Obj, but got F4
			//IL_119f: Expected I, but got Obj
			//IL_11b5: Expected Obj, but got I
			//IL_1007: Expected Obj, but got I4
			//IL_2173: Expected I, but got Obj
			//IL_2189: Expected Obj, but got I
			//IL_236d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2372: Expected Obj, but got Unknown
			//IL_2c62: Expected Obj, but got I
			//IL_2c72: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c77: Expected Obj, but got Unknown
			//IL_2c87: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c8c: Expected Obj, but got Unknown
			//IL_2c9f: Expected Obj, but got I4
			//IL_1019: Expected Obj, but got F4
			//IL_1027: Expected I, but got Obj
			//IL_103d: Expected Obj, but got I
			//IL_1214: Unknown result type (might be due to invalid IL or missing references)
			//IL_1219: Expected Obj, but got Unknown
			//IL_1229: Unknown result type (might be due to invalid IL or missing references)
			//IL_122e: Expected Obj, but got Unknown
			//IL_11e0: Expected I, but got Obj
			//IL_2beb: Expected Obj, but got I
			//IL_2bfb: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c00: Expected Obj, but got Unknown
			//IL_2c10: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c15: Expected Obj, but got Unknown
			//IL_2c28: Expected Obj, but got I4
			//IL_21b4: Expected I, but got Obj
			//IL_2c40: Expected Obj, but got I4
			//IL_109c: Unknown result type (might be due to invalid IL or missing references)
			//IL_10a1: Expected Obj, but got Unknown
			//IL_10b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_10b6: Expected Obj, but got Unknown
			//IL_1068: Expected I, but got Obj
			//IL_124e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1253: Expected Obj, but got Unknown
			//IL_1293: Expected F4, but got Obj
			//IL_128e: Expected native int or pointer, but got VT
			//IL_12a8: Expected F4, but got I
			//IL_12a3: Expected native int or pointer, but got VT
			//IL_12bb: Expected Obj, but got I4
			//IL_1209: Expected Obj, but got I4
			//IL_22df: Expected Obj, but got F4
			//IL_2300: Expected Obj, but got F4
			//IL_2309: Unknown result type (might be due to invalid IL or missing references)
			//IL_230e: Expected Obj, but got Unknown
			//IL_2325: Expected Obj, but got F4
			//IL_2332: Expected F4, but got Obj
			//IL_232d: Expected native int or pointer, but got VT
			//IL_2347: Expected F4, but got I
			//IL_2342: Expected native int or pointer, but got VT
			//IL_12c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_12ce: Expected Obj, but got Unknown
			//IL_1091: Expected Obj, but got I4
			//IL_2252: Unknown result type (might be due to invalid IL or missing references)
			//IL_2257: Expected Obj, but got Unknown
			//IL_226e: Expected Obj, but got F4
			//IL_2277: Unknown result type (might be due to invalid IL or missing references)
			//IL_227c: Expected Obj, but got Unknown
			//IL_2293: Expected Obj, but got F4
			//IL_2799: Expected Obj, but got I
			//IL_133a: Unknown result type (might be due to invalid IL or missing references)
			//IL_133f: Expected Obj, but got Unknown
			//IL_1362: Unknown result type (might be due to invalid IL or missing references)
			//IL_1367: Expected Obj, but got Unknown
			//IL_27d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_27dc: Expected Obj, but got Unknown
			//IL_280d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2812: Expected Obj, but got Unknown
			//IL_0a9c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aa1: Expected Obj, but got Unknown
			//IL_0aaa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aaf: Expected Obj, but got Unknown
			//IL_0adb: Expected Obj, but got I4
			//IL_0ae4: Expected Obj, but got I4
			//IL_26c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_26c9: Expected Obj, but got Unknown
			//IL_26d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_26d7: Expected Obj, but got Unknown
			//IL_2703: Expected Obj, but got I4
			//IL_1de0: Unknown result type (might be due to invalid IL or missing references)
			//IL_1de5: Expected Obj, but got Unknown
			//IL_1dee: Unknown result type (might be due to invalid IL or missing references)
			//IL_1df3: Expected Obj, but got Unknown
			//IL_1e1f: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 + 384;
			object obj3 = obj2 + 344;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 320;
			obj4 = 0;
			_ = 0;
			_ = 0;
			object obj5 = obj2 + 304;
			obj5 = 0;
			_ = 0;
			object obj6 = obj2 + 280;
			obj6 = 0;
			_ = 0;
			_ = 0;
			object obj7 = obj2 + 256;
			obj7 = 0;
			_ = 0;
			_ = 0;
			object obj8 = obj2 + 232;
			obj8 = 0;
			_ = 0;
			_ = 0;
			object obj9 = obj2 + 216;
			obj9 = 0;
			_ = 0;
			object obj10 = obj2 + 192;
			obj10 = 0;
			_ = 0;
			_ = 0;
			object obj11 = obj2 + 176;
			obj11 = 0;
			_ = 0;
			object obj12 = obj2 + 168;
			obj12 = obj;
			_ = -1;
			float x;
			if (group > 0)
			{
				int num;
				if (group != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+C]");
					bool flag = (nint)0 == int.MinValue;
					bool flag2 = group == -1;
					object obj13 = flag & flag2;
					if (obj13 != null)
					{
						num = 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+C]");
						num = (int)((nint)0 / (nint)group);
					}
				}
				else
				{
					num = 0;
				}
				x = (float)num + 1f;
			}
			else
			{
				x = 1f;
			}
			int num2;
			if (group > 0)
			{
				num2 = group;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+C]");
				num2 = 0;
			}
			object obj14 = obj2 + 144;
			object obj15 = obj2 + 40;
			object obj16 = obj2 + 128;
			object obj17 = obj2 + 24;
			object obj18 = obj2 + 8;
			object obj19 = obj2 + 116;
			object obj20 = obj2 + 104;
			object obj21 = obj2 + 80;
			Vector3 vector = (Vector3)(obj2 + 56);
			((Vector3*)(nint)vector)->x = x;
			((Vector3*)(nint)vector)->y = num2;
			OverflowException ex = new OverflowException();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			Vector3 vector2 = (Vector3)(obj2 + 360);
			bool flag3 = this.value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = vector2.x;
			_ = vector2.z;
			object obj22 = 0;
			object obj24 = default;
			object obj28 = default;
			object obj30 = default;
			object obj36 = default;
			object obj37 = default;
			object obj38 = default;
			object obj39 = default;
			object obj40 = default;
			object obj41 = default;
			object obj42 = default;
			object obj43 = default;
			object obj44 = default;
			object obj48 = default;
			object obj52 = default;
			object obj57 = default;
			object obj59 = default;
			object obj61 = default;
			object obj66 = default;
			object obj68 = default;
			object obj73 = default;
			object obj74 = default;
			object obj75 = default;
			object obj76 = default;
			object obj77 = default;
			object obj78 = default;
			object obj79 = default;
			object obj80 = default;
			object obj82 = default;
			object obj84 = default;
			object obj89 = default;
			object obj90 = default;
			object obj95 = default;
			object obj96 = default;
			object obj97 = default;
			object obj98 = default;
			object obj103 = default;
			float num15 = default;
			object obj108 = default;
			object obj121 = default;
			object obj130 = default;
			object obj139 = default;
			float num36 = default;
			object obj150 = default;
			object obj151 = default;
			object obj152 = default;
			object obj153 = default;
			object obj154 = default;
			object obj155 = default;
			object obj156 = default;
			object obj157 = default;
			object obj158 = default;
			object obj159 = default;
			object obj160 = default;
			object obj161 = default;
			object obj162 = default;
			object obj163 = default;
			object obj164 = default;
			object obj165 = default;
			object obj166 = default;
			while (true)
			{
				object obj23 = 0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					object obj29;
					object obj35;
					if (obj24 == null)
					{
						object obj25 = 47;
						object obj26 = obj25 - 16;
						if ((nint)obj25 != 16)
						{
							if ((nint)obj26 != 1)
							{
								if ((nint)obj26 != 2)
								{
									if ((nint)obj26 != 3)
									{
										if ((nint)obj26 != 4)
										{
											if ((nint)obj26 == 5 || (nint)obj26 == 6 || (nint)obj26 == 7 || (nint)obj26 == 8 || (nint)obj26 == 9 || (nint)obj26 == 10 || (nint)obj26 == 11)
											{
												goto IL_282e;
											}
											if ((nint)obj26 != 12)
											{
												if ((nint)obj26 != 13)
												{
													if ((nint)obj26 != 14)
													{
														object obj27;
														if ((nint)obj26 != 15 && (nint)obj26 != 16)
														{
															if ((nint)obj26 != 17 && (nint)obj26 != 18 && (nint)obj26 != 19 && (nint)obj26 != 20 && (nint)obj26 != 21 && (nint)obj26 != 22 && (nint)obj26 != 23 && (nint)obj26 != 24 && (nint)obj26 != 25 && (nint)obj26 != 26 && (nint)obj26 != 27 && (nint)obj26 != 28 && (nint)obj26 != 29)
															{
																if ((nint)obj26 == 30)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																	obj27 = obj28;
																	obj29 = obj30;
																	goto IL_2b2e;
																}
																if ((nint)obj26 == 31)
																{
																	object obj31 = obj12 + 4;
																	object obj32 = obj31 + 1;
																	obj31 = obj32;
																	object obj33 = obj32 << 2;
																	object obj34 = obj12 + obj33;
																	obj34 = 288;
																	obj35 = 0;
																	goto IL_0b38;
																}
															}
															goto IL_282e;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
														obj27 = obj36;
														obj29 = obj30;
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
														object obj27 = obj37;
														obj29 = obj30;
													}
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
													object obj27 = obj38;
													obj29 = obj30;
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
												object obj27 = obj39;
												obj29 = obj30;
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj27 = obj40;
											obj29 = obj30;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj27 = obj41;
										obj29 = obj30;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj27 = obj42;
									obj29 = obj30;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj27 = obj43;
								obj29 = obj30;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj27 = obj44;
							obj29 = obj30;
						}
						goto IL_2b2e;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					bool flag4 = (object)tween != null;
					object obj45 = (flag4 ? 1 : 0) ^ 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
					obj4 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v55+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v55+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					obj5 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v57+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					obj17 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+8]");
					_ = 0;
					nint num3 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ S0_v727 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj46 = (nint)0 & (nint)0x200;
					if (obj46 != null)
					{
						nint num4 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ S0_v795 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					((Vector3*)(nint)vector2)->x = (float)obj16;
					Vector3 vector3 = vector2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v59+8]");
					((Vector3*)(nint)vector3)->z = 0f;
					((Vector3*)(nint)vector)->x = (float)obj17;
					Vector3 vector4 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v61+8]");
					((Vector3*)(nint)vector4)->z = 0f;
					Vector3 vector5 = Vector3.Cross(vector2, vector);
					((Vector3*)(nint)vector)->x = (float)obj18;
					Vector3 vector6 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v63+8]");
					((Vector3*)(nint)vector6)->z = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					((Vector3*)(nint)vector2)->x = (float)obj19;
					Vector3 vector7 = vector2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v65+8]");
					((Vector3*)(nint)vector7)->z = 0f;
					((Vector3*)(nint)vector)->x = (float)obj5;
					Vector3 vector8 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+8]");
					((Vector3*)(nint)vector8)->z = 0f;
					Vector3 vector9 = Vector3.Cross(vector2, vector);
					((Vector3*)(nint)vector)->x = (float)obj20;
					Vector3 vector10 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v67+8]");
					((Vector3*)(nint)vector10)->z = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					((Vector3*)(nint)vector)->x = (float)obj4;
					Vector3 vector11 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
					((Vector3*)(nint)vector11)->z = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A6A4");
					((Vector3*)(nint)vector2)->x = (float)obj4;
					Vector3 vector12 = vector2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
					((Vector3*)(nint)vector12)->z = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+10]");
					_ = 0;
					((Vector3*)(nint)vector)->x = vector2.x;
					((Vector3*)(nint)vector)->z = vector2.z;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v83 (UnityEngine.Vector3)+10]");
					_ = 0;
					object obj47 = obj48 + 16;
					object obj49 = obj23 * 24;
					object obj50 = obj47 + obj49;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					obj21 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+10]");
					_ = 0;
					((Vector3*)(nint)vector)->x = (float)obj21;
					Vector3 vector13 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v69+8]");
					((Vector3*)(nint)vector13)->z = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v69+10]");
					_ = 0;
					object obj51 = obj52 + 16;
					object obj53 = obj22 * 24;
					object obj54 = obj51 + obj53;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					object obj55 = obj23 + 1;
					if ((nint)obj55 >= group && group >= 1)
					{
						break;
					}
					obj23 = obj55;
					continue;
					IL_2e1c:
					if ((object)activeAnimation == null)
					{
						return;
					}
					NGUIMath.OverlayPosition((Transform)vector, (Transform)(object)activeAnimation);
					GameObject gameObject = base.gameObject;
					Vector2 pivotOffset = NGUIMath.GetPivotOffset((UIWidget.Pivot)gameObject);
					obj10 = vector2.x;
					_ = vector2.z;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v83 (UnityEngine.Vector3)+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
					obj15 = vector.x;
					nint num5 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1547 @ S0_v166 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj56 = (nint)0 & (nint)0x200;
					if (obj56 != null)
					{
						nint num6 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1570 @ S0_v314 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num7 = Mathf.LerpUnclamped(0f, (float)obj14, (float)obj15);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
					obj17 = vector.x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v59+4]");
					float a = -0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v61+4]");
					float num8 = Mathf.LerpUnclamped(a, 0f, 0f);
					bool flag5 = this.value;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
					obj3 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v63+8]");
					_ = 0;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						if (obj57 == null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						nint num9 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1960 @ S0_v264 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj58 = (nint)0 & (nint)0x200;
						if (obj58 != null)
						{
							nint num10 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1989 @ S0_v303 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						if (obj59 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
							object obj60 = obj61 + 12;
							float num11 = (float)obj60 - num7;
							obj60 = num11;
							object obj62 = obj61 + 16;
							float num12 = (float)obj62 - num8;
							obj62 = num12;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
							obj11 = vector2.x;
							_ = vector2.z;
							float num13 = (float)obj11 - num7;
							obj11 = num13;
							object obj63 = obj11 + 4;
							float num14 = (float)obj63 - num8;
							obj63 = num14;
							((Vector3*)(nint)vector)->x = (float)obj11;
							Vector3 vector14 = vector;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v38+8]");
							((Vector3*)(nint)vector14)->z = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
						}
					}
					object obj64 = 174;
					object obj65 = obj64 - 154;
					object obj67;
					if ((nint)obj64 != 154)
					{
						if ((nint)obj65 != 1)
						{
							if ((nint)obj65 != 2)
							{
								if ((nint)obj65 == 3 || (nint)obj65 == 4)
								{
									goto IL_2750;
								}
								if ((nint)obj65 != 5)
								{
									if ((nint)obj65 == 6 || (nint)obj65 == 7 || (nint)obj65 == 8)
									{
										goto IL_2750;
									}
									if ((nint)obj65 != 9)
									{
										object obj27;
										if ((nint)obj65 != 10)
										{
											if ((nint)obj65 != 11 && (nint)obj65 != 12 && (nint)obj65 != 13 && (nint)obj65 != 14 && (nint)obj65 != 15)
											{
												if ((nint)obj65 == 16 || (nint)obj65 == 17)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
													obj27 = obj66;
													obj67 = obj30;
													goto IL_2d94;
												}
												if ((nint)obj65 != 18)
												{
													if ((nint)obj65 == 19)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
														obj27 = obj68;
														obj67 = obj30;
														goto IL_2d94;
													}
													if ((nint)obj65 == 20)
													{
														object obj69 = obj12 + 4;
														object obj70 = obj69 + 1;
														obj69 = obj70;
														object obj71 = obj70 << 2;
														object obj72 = obj12 + obj71;
														obj72 = 1172;
														obj73 = obj74;
													}
												}
											}
											goto IL_2750;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										obj27 = obj75;
										obj67 = obj30;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj27 = obj76;
										obj67 = obj30;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj27 = obj77;
									obj67 = obj30;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj27 = obj78;
								obj67 = obj30;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj27 = obj79;
							obj67 = obj30;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj27 = obj80;
						obj67 = obj30;
					}
					goto IL_2d94;
					IL_2ce1:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
					object obj81;
					object obj83;
					if (obj81 != obj82)
					{
						object obj27 = obj83;
						goto IL_282e;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
					obj74 = obj84;
					goto IL_1ed6;
					IL_0b38:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v44+4]");
					if ((nint)0 != -1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v44+4]");
						object obj85 = (nint)0 << 2;
						object obj86 = obj12 + obj85;
						if ((nint)obj86 == 288)
						{
							object obj87 = obj12 + 4;
							if ((nint)obj87 > -1)
							{
								object obj88 = obj87 + -1;
								obj87 = obj88;
							}
							goto IL_2df4;
						}
					}
					if (obj35 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
					}
					goto IL_2df4;
					IL_2b2e:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
					if (obj29 == obj89)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
						obj35 = obj90;
						goto IL_0b38;
					}
					goto IL_282e;
					IL_2750:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v44+4]");
					if ((nint)0 != -1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v44+4]");
						object obj91 = (nint)0 << 2;
						object obj92 = obj12 + obj91;
						if ((nint)obj92 == 1172)
						{
							object obj93 = obj12 + 4;
							if ((nint)obj93 > -1)
							{
								object obj94 = obj93 + -1;
								obj93 = obj94;
							}
							return;
						}
					}
					if (obj73 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
					}
					return;
					IL_1e2c:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					obj83 = obj95;
					obj81 = obj30;
					goto IL_2ce1;
					IL_2d94:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
					if (obj67 == obj96)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
						obj73 = obj97;
						goto IL_2750;
					}
					goto IL_282e;
					IL_1e4b:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					obj83 = obj98;
					obj81 = obj30;
					goto IL_2ce1;
					IL_1ed6:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v44+4]");
					if ((nint)0 != -1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v44+4]");
						object obj99 = (nint)0 << 2;
						object obj100 = obj12 + obj99;
						if ((nint)obj100 == 903)
						{
							object obj101 = obj12 + 4;
							if ((nint)obj101 > -1)
							{
								object obj102 = obj101 + -1;
								obj101 = obj102;
							}
							goto IL_2e1c;
						}
					}
					if (obj74 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
					}
					goto IL_2e1c;
					IL_282e:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
					return;
					IL_1e6a:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					obj83 = obj103;
					obj81 = obj30;
					goto IL_2ce1;
					IL_2df4:
					NGUIMath.OverlayPosition((Transform)vector, (Transform)(object)animator);
					bool flag6 = this.value;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
					obj3 = vector2.x;
					_ = vector2.z;
					object obj104 = 0;
					object obj107;
					while (true)
					{
						object obj105 = 0f - num15;
						float num16 = 0f;
						object obj106 = 0;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							obj107 = 135;
							bool flag7 = obj108 == null;
							obj107 = 136;
							if (flag7)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							obj107 = 65;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A6A5");
							obj6 = vector.x;
							_ = vector.z;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v71 (UnityEngine.Vector3)+10]");
							_ = 0;
							object obj109 = obj48 + 16;
							object obj110 = obj106 * 24;
							object obj111 = obj109 + obj110;
							((Vector3*)(nint)vector2)->x = (float)obj111;
							Vector3 vector15 = vector2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1243 @ S1_v232+8]");
							((Vector3*)(nint)vector15)->z = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1243 @ S1_v232+10]");
							_ = 0;
							obj7 = vector2.x;
							_ = vector2.z;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v83 (UnityEngine.Vector3)+10]");
							_ = 0;
							object obj112 = obj52 + 16;
							object obj113 = obj104 * 24;
							object obj114 = obj112 + obj113;
							obj14 = obj114;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1268 @ S1_v246+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1268 @ S1_v246+10]");
							_ = 0;
							obj8 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v55+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v55+10]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
							obj107 = 66;
							obj9 = obj15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v57+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
							float num17 = num16 + (float)obj16;
							float num18 = num17 - (float)obj17;
							obj9 = num18;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
							obj107 = 67;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
							obj107 = 68;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
							obj107 = 69;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
							obj107 = 70;
							obj2 = vector.x;
							nint num19 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1589 @ S0_v473 (Il2CppClass<UnityEngine.Mathf>)+BA]");
							object obj115 = (nint)0 & (nint)0x200;
							if (obj115 != null)
							{
								nint num20 = (nint)typeof(Mathf);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1598 @ S0_v633 (Il2CppClass<UnityEngine.Mathf>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
									obj107 = 71;
								}
							}
							object obj116 = obj18 - obj19;
							object obj117 = obj116 - obj20;
							object obj118 = obj117 + obj21;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
							obj107 = 74;
							object obj119 = this + 36;
							object obj120 = obj121 - obj119;
							object obj122 = obj9 - obj120;
							obj9 = obj122;
							if ((object)activeSprite != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
								float num21 = num15 + vector.y;
								float num22 = num21 - vector2.y;
								object obj123 = obj9 + 4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
								obj107 = 108;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
								obj107 = 109;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
								obj107 = 110;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
								obj107 = 111;
								obj18 = vector.x;
								nint num23 = (nint)typeof(Mathf);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2010 @ S0_v615 (Il2CppClass<UnityEngine.Mathf>)+BA]");
								object obj124 = (nint)0 & (nint)0x200;
								if (obj124 != null)
								{
									nint num24 = (nint)typeof(Mathf);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2049 @ S0_v626 (Il2CppClass<UnityEngine.Mathf>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
										obj107 = 112;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v55+4]");
								nint num25 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v57+4]");
								object obj125 = num25 - 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v59+4]");
								object obj126 = obj125 - 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v61+4]");
								object obj127 = obj126 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
								obj107 = 119;
								object obj128 = this + 36;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2130 @ S3_v59+4]");
								object obj129 = obj130 - 0;
								object obj131 = obj123 - obj129;
								obj123 = obj131;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
								float num26 = (float)obj105 - vector.y;
								float num27 = num26 - vector2.y;
								object obj132 = obj9 + 4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
								obj107 = 88;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
								obj107 = 89;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
								obj107 = 90;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
								obj107 = 91;
								obj18 = vector.x;
								nint num28 = (nint)typeof(Mathf);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2022 @ S0_v557 (Il2CppClass<UnityEngine.Mathf>)+BA]");
								object obj133 = (nint)0 & (nint)0x200;
								if (obj133 != null)
								{
									nint num29 = (nint)typeof(Mathf);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2068 @ S0_v568 (Il2CppClass<UnityEngine.Mathf>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
										obj107 = 92;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v55+4]");
								nint num30 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v57+4]");
								object obj134 = num30 - 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v59+4]");
								object obj135 = obj134 - 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v61+4]");
								object obj136 = obj135 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
								obj107 = 95;
								object obj137 = this + 36;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2142 @ S3_v48+4]");
								object obj138 = obj139 - 0;
								object obj140 = obj132 + obj138;
								obj132 = obj140;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
							obj107 = 125;
							object obj141 = this + 36;
							float num31 = (float)obj141 * 2f;
							float num32 = vector2.x + num31;
							float num33 = num16 + num32;
							((Vector3*)(nint)vector)->x = (float)obj9;
							Vector3 vector16 = vector;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v31+8]");
							((Vector3*)(nint)vector16)->z = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
							obj107 = 126;
							object obj142 = obj106 + 1;
							if ((nint)obj142 >= group && group >= 1)
							{
								goto IL_1331;
							}
							num16 = num33;
							obj106 = obj142;
						}
						break;
						IL_1331:
						object obj143 = obj104 + 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
						object obj144 = this + 36;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2275 @ S2_v115+4]");
						float num34 = 0f * 2f;
						float num35 = vector.y + num34;
						num15 = num36 + num35;
						obj104 = obj143;
					}
					object obj145 = obj107 - 65;
					if ((nint)obj107 != 65)
					{
						if ((nint)obj145 != 1)
						{
							if ((nint)obj145 != 2)
							{
								if ((nint)obj145 != 3)
								{
									if ((nint)obj145 != 4)
									{
										if ((nint)obj145 != 5)
										{
											if ((nint)obj145 != 6)
											{
												if ((nint)obj145 != 7 && (nint)obj145 != 8)
												{
													if ((nint)obj145 == 9)
													{
														goto IL_1e2c;
													}
													if ((nint)obj145 != 10 && (nint)obj145 != 11 && (nint)obj145 != 12 && (nint)obj145 != 13 && (nint)obj145 != 14 && (nint)obj145 != 15 && (nint)obj145 != 16 && (nint)obj145 != 17 && (nint)obj145 != 18 && (nint)obj145 != 19 && (nint)obj145 != 20 && (nint)obj145 != 21 && (nint)obj145 != 22)
													{
														if ((nint)obj145 != 23)
														{
															if ((nint)obj145 != 24)
															{
																if ((nint)obj145 != 25)
																{
																	if ((nint)obj145 != 26)
																	{
																		if ((nint)obj145 != 27)
																		{
																			if ((nint)obj145 != 28 && (nint)obj145 != 29)
																			{
																				if ((nint)obj145 == 30)
																				{
																					goto IL_1e4b;
																				}
																				if ((nint)obj145 != 31 && (nint)obj145 != 32 && (nint)obj145 != 33 && (nint)obj145 != 34 && (nint)obj145 != 35 && (nint)obj145 != 36 && (nint)obj145 != 37 && (nint)obj145 != 38 && (nint)obj145 != 39 && (nint)obj145 != 40 && (nint)obj145 != 41 && (nint)obj145 != 42)
																				{
																					if ((nint)obj145 != 43)
																					{
																						if ((nint)obj145 != 44)
																						{
																							if ((nint)obj145 != 45)
																							{
																								if ((nint)obj145 != 46)
																								{
																									if ((nint)obj145 != 47)
																									{
																										if ((nint)obj145 != 48 && (nint)obj145 != 49 && (nint)obj145 != 50 && (nint)obj145 != 51 && (nint)obj145 != 52 && (nint)obj145 != 53)
																										{
																											if ((nint)obj145 == 54)
																											{
																												goto IL_1e6a;
																											}
																											if ((nint)obj145 != 55 && (nint)obj145 != 56 && (nint)obj145 != 57 && (nint)obj145 != 58 && (nint)obj145 != 59)
																											{
																												if ((nint)obj145 != 60 && (nint)obj145 != 61)
																												{
																													if ((nint)obj145 == 62 || (nint)obj145 == 63 || (nint)obj145 == 64 || (nint)obj145 == 65 || (nint)obj145 == 66 || (nint)obj145 == 67 || (nint)obj145 == 68)
																													{
																														goto IL_1ed6;
																													}
																													if ((nint)obj145 != 69)
																													{
																														if ((nint)obj145 != 70)
																														{
																															if ((nint)obj145 == 71)
																															{
																																object obj146 = obj12 + 4;
																																object obj147 = obj146 + 1;
																																obj146 = obj147;
																																object obj148 = obj147 << 2;
																																object obj149 = obj12 + obj148;
																																obj149 = 903;
																																obj74 = obj35;
																															}
																															goto IL_1ed6;
																														}
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																														obj83 = obj150;
																														obj81 = obj30;
																													}
																													else
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																														obj83 = obj151;
																														obj81 = obj30;
																													}
																												}
																												else
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																													obj83 = obj152;
																													obj81 = obj30;
																												}
																												goto IL_2ce1;
																											}
																										}
																										goto IL_1ed6;
																									}
																									goto IL_1e6a;
																								}
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																								obj83 = obj153;
																								obj81 = obj30;
																							}
																							else
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																								obj83 = obj154;
																								obj81 = obj30;
																							}
																						}
																						else
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																							obj83 = obj155;
																							obj81 = obj30;
																						}
																					}
																					else
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																						obj83 = obj156;
																						obj81 = obj30;
																					}
																					goto IL_2ce1;
																				}
																			}
																			goto IL_1ed6;
																		}
																		goto IL_1e4b;
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																	obj83 = obj157;
																	obj81 = obj30;
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																	obj83 = obj158;
																	obj81 = obj30;
																}
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																obj83 = obj159;
																obj81 = obj30;
															}
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
															obj83 = obj160;
															obj81 = obj30;
														}
														goto IL_2ce1;
													}
												}
												goto IL_1ed6;
											}
											goto IL_1e2c;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										obj83 = obj161;
										obj81 = obj30;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										obj83 = obj162;
										obj81 = obj30;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									obj83 = obj163;
									obj81 = obj30;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								obj83 = obj164;
								obj81 = obj30;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							obj83 = obj165;
							obj81 = obj30;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						obj83 = obj166;
						obj81 = obj30;
					}
					goto IL_2ce1;
				}
				object obj167 = obj22 + 1;
				obj22 = obj167;
			}
		}
	}

	public bool isColliderEnabled
	{
		get
		{
			if (~(mStarted ? 1u : 0u) == 0)
			{
				return mIsActive;
			}
			return startsActive;
		}
	}

	public bool isChecked
	{
		get
		{
			//IL_0134: Expected I, but got Obj
			//IL_014a: Expected Obj, but got I
			//IL_007c: Expected I, but got Obj
			//IL_0092: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00bd: Expected I, but got Obj
			Collider component = GetComponent<Collider>();
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v33 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
			{
				return component.isTrigger;
			}
			Collider2D component2 = GetComponent<Collider2D>();
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v27 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component2).FindKernel((string)null) != 0)
			{
				return component2.isActiveAndEnabled;
			}
			return false;
		}
		set
		{
			//IL_0037: Expected Obj, but got I4
			//IL_00b1: Expected Obj, but got I4
			if (~(mStarted ? 1u : 0u) == 0)
			{
				bool flag = group == 0;
				object obj = flag | value;
				if (obj != null || ~(optionCanBeNone ? 1u : 0u) == 0 || !mStarted)
				{
					((UIToggledObjects)(object)this).Set((GameObject)value, true);
				}
			}
			else
			{
				startsActive = value;
			}
		}
	}

	public static UIToggle GetActiveToggle(int group)
	{
		//IL_006e: Expected Obj, but got I4
		//IL_0047: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [group @ L0 (System.Int32)+42]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [group @ L0 (System.Int32)+41]");
			bool flag = (nint)0 != 0;
			return (UIToggle)flag;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [group @ L0 (System.Int32)+24]");
		bool flag2 = (nint)0 != 0;
		return (UIToggle)flag2;
	}

	private void OnEnable()
	{
		//IL_005d: Expected Obj, but got I4
		//IL_006b: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_00c7: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		tween = (UITweener)1;
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v20 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 one = Vector2.one;
		object obj3 = default;
		object obj2 = obj3 + 8;
		obj2 = obj3;
		startsActive = (byte)(int)obj2 != 0;
		base._002Ector();
	}

	private void OnDisable()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009e: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIToggle);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIToggle>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIToggle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<UIToggle>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((BetterList<>)(object)list).RemoveAt((int)this);
	}

	public void Start()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIToggle);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIToggle>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIToggle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<UIToggle>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = ((BetterList<>.CompareFunc)(object)list).EndInvoke((IAsyncResult)this);
	}

	private void OnClick()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_00e7: Expected I, but got Obj
		//IL_00fd: Expected Obj, but got I
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0041: Expected Obj, but got I4
		//IL_00ca: Expected Obj, but got I4
		//IL_054d: Expected I, but got Obj
		//IL_0563: Expected Obj, but got I
		//IL_0128: Expected I, but got Obj
		//IL_0175: Expected I, but got Obj
		//IL_018b: Expected Obj, but got I
		//IL_0231: Expected I, but got Obj
		//IL_0606: Expected I, but got Obj
		//IL_061c: Expected Obj, but got I
		//IL_027e: Expected I, but got Obj
		//IL_0294: Expected Obj, but got I
		//IL_01b6: Expected I, but got Obj
		//IL_033a: Expected I, but got Obj
		//IL_0350: Expected Obj, but got I
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected Obj, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_021e: Expected Obj, but got I4
		//IL_045b: Expected I, but got Obj
		//IL_02bf: Expected I, but got Obj
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Expected Obj, but got Unknown
		//IL_04ae: Expected Obj, but got I4
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected Obj, but got Unknown
		//IL_04c2: Expected Obj, but got I4
		//IL_037b: Expected I, but got Obj
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected Obj, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected Obj, but got Unknown
		//IL_0327: Expected Obj, but got I4
		if (~(mStarted ? 1u : 0u) == 0)
		{
			return;
		}
		object obj = this - -64;
		if (obj != null)
		{
			object obj2 = this - -64;
			obj2 = 0;
			startsActive = true;
		}
		if (Application.platform != RuntimePlatform.OSXEditor)
		{
			bool flag = startsActive;
			bool flag2 = (byte)((flag ? 1u : 0u) ^ 1u) != 0;
			mIsActive = flag2;
			mStarted = true;
			bool flag3 = instantTween;
			instantTween = true;
			bool flag4 = startsActive;
			((UIToggledObjects)(object)this).Set((GameObject)flag4, true);
			instantTween = flag3;
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v81 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)checkSprite).FindKernel((string)null) != 0)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S1_v67 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v77 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (activeSprite != null)
			{
				object obj5 = this + 16;
				obj5 = checkSprite;
				object obj6 = this + 48;
				obj6 = 0;
			}
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S1_v62 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)checkAnimation).FindKernel((string)null) != 0)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S1_v48 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S1_v58 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (activeAnimation != null)
			{
				object obj9 = this + 24;
				obj9 = checkAnimation;
				object obj10 = this + 52;
				obj10 = 0;
			}
		}
		if (Application.platform != RuntimePlatform.OSXEditor)
		{
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S1_v35 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num10 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S1_v43 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)activeSprite).FindKernel((string)null) != 0)
			{
				bool flag5 = invertSpriteState;
				bool flag6 = startsActive;
				float num11 = ((!flag6) ? 0f : 1f);
				float num12 = ((!flag6) ? 1f : 0f);
				if (flag5)
				{
					float num13 = num12;
				}
				else
				{
					float num13 = num11;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
			}
		}
		nint num14 = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S1_v21 (Il2CppClass<EventDelegate>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num15 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S1_v30 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (Localization.LoadAndSelect((string)(object)onChange))
		{
			object obj13 = this + 56;
			obj13 = 0;
			object obj14 = this + 60;
			obj14 = 0;
		}
	}

	public unsafe void Set(bool state, bool notify = true)
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected VT, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_014c: Expected native int or pointer, but got VT
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v38 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 vector2 = default;
		Vector2 vector = vector2 + 8;
		KeyCode currentKey = UICamera.currentKey;
		if (currentKey == (KeyCode)2)
		{
			return;
		}
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v21 (Il2CppClass<UICamera>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v32 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = this + 48;
		obj3 = UICamera.currentCamera;
		UICamera.lastEventPosition = vector2;
		((Vector2*)(nint)vector)->x = vector2.x;
		float num5 = ((UIProgressBar)this).LocalToValue(vector);
		float alpha = (float)checkAnimation + num5;
		((UIProgressBar)this).alpha = alpha;
	}

	public UIToggle()
	{
		//IL_0036: Expected I, but got Obj
		//IL_004c: Expected Obj, but got I
		//IL_0077: Expected I, but got Obj
		if (!isActiveAndEnabled || !isChecked)
		{
			return;
		}
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v11 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UICamera.currentTouchID != -2)
		{
			bool flag = ((~(mStarted ? 1u : 0u) != 0) ? startsActive : mIsActive);
			bool flag2 = (byte)((flag ? 1u : 0u) ^ 1u) != 0;
			isChecked = flag2;
		}
	}

	static UIToggle()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		BetterList<UIScrollView> betterList = default;
		UIScrollView.list = betterList;
	}
}

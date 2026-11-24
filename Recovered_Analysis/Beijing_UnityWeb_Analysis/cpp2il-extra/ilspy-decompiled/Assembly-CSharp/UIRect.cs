using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Plugins.DeviceUtility;
using UnityEngine;
using UnityEngine.UI;

public abstract class UIRect : MonoBehaviour
{
	[Serializable]
	public class AnchorPoint
	{
		public Transform target;

		public float relative;

		public int absolute;

		[NonSerialized]
		public UIRect rect;

		[NonSerialized]
		public Camera targetCam;

		public AnchorPoint()
		{
			//IL_0015: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I
			//IL_011b: Expected Obj, but got I
			//IL_0138: Expected Obj, but got I4
			//IL_037a: Expected Obj, but got I
			//IL_0383: Unknown result type (might be due to invalid IL or missing references)
			//IL_0388: Expected Obj, but got Unknown
			//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cf: Expected Obj, but got Unknown
			//IL_01c4: Expected Obj, but got I
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Expected Obj, but got Unknown
			//IL_0190: Expected Obj, but got I
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected Obj, but got Unknown
			//IL_0257: Expected Obj, but got I
			//IL_0287: Invalid comparison between F4 and I4
			//IL_02b1: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIRect+AnchorPoint)+34]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIRect+AnchorPoint)+34]");
			object obj3;
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIRect+AnchorPoint)+34]");
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
			object obj23 = default;
			object obj20 = default;
			for (; obj5 != obj3; obj5 = obj23 + 1)
			{
				object obj6 = obj5 << 2;
				object obj7 = obj4 + obj6;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+14]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+28]");
				if ((nint)0 == -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+24]");
				object obj11 = (nint)0 & (nint)0x10;
				bool flag = obj11 == null;
				object obj12 = (flag ? 1 : 0) ^ 1;
				if (obj12 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+2A]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
						object obj13 = (nint)0 & (nint)0x3FFF;
						object obj14 = obj13 + 80504;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v104 @ S2_v14 (should have been resolved before IL gen)");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
						object obj15 = (nint)0 & (nint)0x7FFF;
						object obj16 = obj15 + 46824;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v111 @ S1_v33 (should have been resolved before IL gen)");
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+28]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+10]");
					bool flag2;
					if ((nint)0 != 0)
					{
						object obj17 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v59+9C]");
						object obj18 = (nint)0 & (nint)0x100;
						flag2 = obj18 != null;
					}
					else
					{
						flag2 = false;
					}
					if (!flag2 && relative != 0f)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+2B]");
						object obj19 = (nint)0 & (nint)3;
						bool flag3 = (nint)obj19 == 2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
						if (flag3)
						{
							if (obj20 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B8");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B9");
							}
						}
						else if (obj20 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
						}
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
				object obj21 = (nint)0 & (nint)0x3FFF;
				object obj22 = obj21 + 80504;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v129 @ S2_v6 (should have been resolved before IL gen)");
			}
		}

		public unsafe AnchorPoint(float relative)
		{
			//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f4: Expected Obj, but got Unknown
			//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ff: Expected Obj, but got Unknown
			//IL_041d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0422: Expected Obj, but got Unknown
			//IL_001b: Expected Obj, but got I4
			//IL_0032: Expected I, but got Obj
			//IL_0048: Expected Obj, but got I
			//IL_043f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0444: Expected VT, but got Unknown
			//IL_0451: Expected F4, but got Obj
			//IL_044c: Expected native int or pointer, but got VT
			//IL_0466: Expected F4, but got I
			//IL_0461: Expected native int or pointer, but got VT
			//IL_046f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0474: Expected Obj, but got Unknown
			//IL_048f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0494: Expected VT, but got Unknown
			//IL_04a1: Expected F4, but got Obj
			//IL_049c: Expected native int or pointer, but got VT
			//IL_04b6: Expected F4, but got I
			//IL_04b1: Expected native int or pointer, but got VT
			//IL_04c3: Expected F4, but got Obj
			//IL_04be: Expected native int or pointer, but got VT
			//IL_04d8: Expected F4, but got I
			//IL_04d3: Expected native int or pointer, but got VT
			//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e6: Expected Obj, but got Unknown
			//IL_0500: Unknown result type (might be due to invalid IL or missing references)
			//IL_0505: Expected Obj, but got Unknown
			//IL_050b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0510: Expected Obj, but got Unknown
			//IL_052e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0533: Expected Obj, but got Unknown
			//IL_00c8: Expected Obj, but got I4
			//IL_0073: Expected I, but got Obj
			//IL_00de: Expected F4, but got Obj
			//IL_00d9: Expected native int or pointer, but got VT
			//IL_00f3: Expected F4, but got I
			//IL_00ee: Expected native int or pointer, but got VT
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Expected Obj, but got Unknown
			//IL_0120: Expected F4, but got Obj
			//IL_011b: Expected native int or pointer, but got VT
			//IL_0135: Expected F4, but got I
			//IL_0130: Expected native int or pointer, but got VT
			//IL_0142: Expected F4, but got Obj
			//IL_013d: Expected native int or pointer, but got VT
			//IL_0157: Expected F4, but got I
			//IL_0152: Expected native int or pointer, but got VT
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Expected Obj, but got Unknown
			//IL_0188: Expected F4, but got Obj
			//IL_0183: Expected native int or pointer, but got VT
			//IL_019d: Expected F4, but got I
			//IL_0198: Expected native int or pointer, but got VT
			//IL_01aa: Expected F4, but got Obj
			//IL_01a5: Expected native int or pointer, but got VT
			//IL_01bf: Expected F4, but got I
			//IL_01ba: Expected native int or pointer, but got VT
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Expected Obj, but got Unknown
			//IL_01ef: Expected F4, but got Obj
			//IL_01ea: Expected native int or pointer, but got VT
			//IL_0204: Expected F4, but got I
			//IL_01ff: Expected native int or pointer, but got VT
			//IL_020d: Expected Obj, but got VT
			//IL_0252: Expected I, but got Obj
			//IL_0268: Expected Obj, but got I
			//IL_0550: Unknown result type (might be due to invalid IL or missing references)
			//IL_0555: Expected Obj, but got Unknown
			//IL_0567: Expected Obj, but got I4
			//IL_0570: Expected Obj, but got F4
			//IL_057f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0584: Expected Obj, but got Unknown
			//IL_0595: Unknown result type (might be due to invalid IL or missing references)
			//IL_059a: Expected Obj, but got Unknown
			//IL_05af: Expected F4, but got Obj
			//IL_05aa: Expected native int or pointer, but got VT
			//IL_05bc: Expected F4, but got Obj
			//IL_05b7: Expected native int or pointer, but got VT
			//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ca: Expected Obj, but got Unknown
			//IL_05df: Expected I4, but got VT
			//IL_05df: Expected Obj, but got VT
			//IL_05ec: Expected F4, but got Obj
			//IL_05e7: Expected native int or pointer, but got VT
			//IL_02ec: Expected Obj, but got I
			//IL_02fc: Expected Obj, but got I
			//IL_0293: Expected I, but got Obj
			//IL_0356: Expected native int or pointer, but got VT
			//IL_0364: Expected native int or pointer, but got VT
			//IL_0372: Expected native int or pointer, but got VT
			//IL_0380: Expected native int or pointer, but got VT
			//IL_038e: Expected native int or pointer, but got VT
			//IL_03a0: Expected native int or pointer, but got VT
			//IL_03b2: Expected native int or pointer, but got VT
			//IL_03c0: Expected Obj, but got VT
			IEnumerator enumerator = ((TutorialEvent)(object)target).ShowArrow();
			int layer = ((GameObject)(object)enumerator).layer;
			object obj2 = default;
			object obj = obj2 + 136;
			object obj3 = this + 12;
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S2_v3+8]");
			_ = 0;
			object obj4 = obj2 + 124;
			IEnumerator enumerator2 = ((TutorialEvent)(object)target).ShowArrow();
			int layer2 = ((GameObject)(object)enumerator2).layer;
			Vector3 forward = ((Transform)layer2).forward;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v11 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v90 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 vector = (Vector3)(obj2 + 160);
			((Vector3*)(nint)vector)->x = (float)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v9+8]");
			((Vector3*)(nint)vector)->z = 0f;
			object obj6 = obj2 + 112;
			Vector3 vector2 = vector / 5f;
			Vector3 vector3 = (Vector3)(obj2 + 148);
			((Vector3*)(nint)vector3)->x = (float)obj;
			Vector3 vector4 = vector3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v6+8]");
			((Vector3*)(nint)vector4)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v19+8]");
			((Vector3*)(nint)vector)->z = 0f;
			object obj7 = obj2 + 100;
			Quaternion quaternion = Quaternion.FromToRotation(vector3, vector);
			object obj8 = obj2 + 88;
			object obj9 = this + 12;
			obj8 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S2_v33+8]");
			_ = 0;
			object obj10 = obj2 + 76;
			IEnumerator enumerator3 = ((TutorialEvent)(object)target).ShowArrow();
			int layer3 = ((GameObject)(object)enumerator3).layer;
			Vector3 forward2 = ((Transform)layer3).forward;
			((Vector3*)(nint)vector)->x = (float)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S1_v31+8]");
			((Vector3*)(nint)vector)->z = 0f;
			object obj11 = obj2 - -64;
			Vector3 vector5 = vector / 5f;
			((Vector3*)(nint)vector3)->x = (float)obj8;
			Vector3 vector6 = vector3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v28+8]");
			((Vector3*)(nint)vector6)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v35+8]");
			((Vector3*)(nint)vector)->z = 0f;
			object obj12 = obj2 + 52;
			Vector3 vector7 = vector3 - vector;
			((Vector3*)(nint)vector3)->x = (float)obj7;
			Vector3 vector8 = vector3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v26+8]");
			((Vector3*)(nint)vector8)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v41+8]");
			((Vector3*)(nint)vector)->z = 0f;
			object obj13 = obj2 + 40;
			Vector3 vector9 = Vector3.LerpUnclamped(vector3, vector, relative);
			((Vector3*)(nint)vector)->x = (float)obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S1_v47+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 eulerAngles = ((Transform)vector).eulerAngles;
			IEnumerator enumerator4 = ((TutorialEvent)(object)target).ShowArrow();
			Renderer component = ((GameObject)(object)enumerator4).GetComponent<Renderer>();
			Material sharedMaterial = component.sharedMaterial;
			nint num3 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S1_v56 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num4 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S1_v86 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj15 = obj2 + 8;
			Vector2 one = Vector2.one;
			obj2 = 0;
			obj2 = 0f;
			_ = -0.035f;
			object obj16 = obj2 + 32;
			obj16 = obj15;
			object obj17 = obj2 + 24;
			obj17 = obj2;
			((Vector3*)(nint)vector3)->x = (float)obj16;
			((Vector3*)(nint)vector)->x = (float)obj17;
			LayoutGroup layoutGroup = (LayoutGroup)(obj2 + 16);
			layoutGroup.SetChildAlongAxis((RectTransform)vector3, (int)vector, relative);
			((Vector3*)(nint)vector)->x = (float)layoutGroup;
			sharedMaterial.mainTextureScale = vector;
			Transform transform = target;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v20 (UnityEngine.Transform)+C]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S0_v21+60]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S0_v22+8]");
			if ((nint)0 == 0)
			{
				IEnumerator enumerator5 = ((TutorialEvent)(object)target).ShowArrow();
				int layer4 = ((GameObject)(object)enumerator5).layer;
				((Vector3*)(nint)vector3)->x = 0f;
				((Vector3*)(nint)vector3)->z = 0f;
				((Vector3*)(nint)vector3)->x = 2000f;
				((Vector3*)(nint)vector3)->y = 2000f;
				((Vector3*)(nint)vector3)->z = 0f;
				((Vector3*)(nint)vector)->x = vector3.x;
				((Vector3*)(nint)vector)->z = vector3.z;
				Vector3 eulerAngles2 = ((Transform)vector).eulerAngles;
			}
		}

		public unsafe void Set(float relative, float absolute)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_059e: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a3: Expected Obj, but got Unknown
			//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b1: Expected VT, but got Unknown
			//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bf: Expected Obj, but got Unknown
			//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05cd: Expected Obj, but got Unknown
			//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05db: Expected Obj, but got Unknown
			//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e9: Expected Obj, but got Unknown
			//IL_05f2: Expected Obj, but got I4
			//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0600: Expected Obj, but got Unknown
			//IL_062b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0630: Expected Obj, but got Unknown
			//IL_0021: Expected I, but got Obj
			//IL_0037: Expected Obj, but got I
			//IL_066c: Expected Obj, but got I
			//IL_0062: Expected I, but got Obj
			//IL_0136: Expected I, but got Obj
			//IL_014c: Expected Obj, but got I
			//IL_069a: Expected Obj, but got I8
			//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b5: Expected Obj, but got Unknown
			//IL_06c5: Expected Obj, but got I
			//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d3: Expected Obj, but got Unknown
			//IL_06e3: Expected Obj, but got I
			//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f1: Expected Obj, but got Unknown
			//IL_0707: Expected Obj, but got I
			//IL_0724: Expected Obj, but got I
			//IL_01c4: Expected I, but got Obj
			//IL_01da: Expected Obj, but got I
			//IL_0177: Expected I, but got Obj
			//IL_0732: Unknown result type (might be due to invalid IL or missing references)
			//IL_0737: Expected Obj, but got Unknown
			//IL_0758: Expected Obj, but got I
			//IL_0205: Expected I, but got Obj
			//IL_0961: Expected I, but got Obj
			//IL_0977: Expected Obj, but got I
			//IL_0277: Unknown result type (might be due to invalid IL or missing references)
			//IL_027c: Expected Obj, but got Unknown
			//IL_0298: Expected I, but got Obj
			//IL_0323: Unknown result type (might be due to invalid IL or missing references)
			//IL_0328: Expected Obj, but got Unknown
			//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e5: Expected Obj, but got Unknown
			//IL_02fb: Expected I4, but got Obj
			//IL_02fb: Expected Obj, but got I
			//IL_07bf: Invalid comparison between I and F4
			//IL_048a: Expected I, but got Obj
			//IL_04a0: Expected Obj, but got I
			//IL_081d: Expected I, but got Obj
			//IL_0833: Expected Obj, but got I
			//IL_0858: Expected Obj, but got VT
			//IL_0877: Expected I, but got Obj
			//IL_088d: Expected Obj, but got I
			//IL_04cb: Expected I, but got Obj
			//IL_08bb: Expected Obj, but got I8
			//IL_08cb: Expected Obj, but got I
			//IL_08d8: Expected I8, but got Obj
			//IL_08d3: Expected native int or pointer, but got VT
			//IL_08ed: Expected Ref, but got VT
			//IL_08f9: Expected Obj, but got I8
			//IL_0518: Expected I, but got Obj
			//IL_0565: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 - -64;
			VariableBool variableBool = (VariableBool)(obj2 + 48);
			DateTime dateTime = (DateTime)(obj2 + 40);
			object obj3 = obj2 + 24;
			object obj4 = obj2 + 16;
			object obj5 = obj2 + 8;
			object obj6 = obj2 + 32;
			obj6 = 0;
			object obj7 = obj2 + 56;
			obj7 = obj;
			_ = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj9 = default;
			object obj8 = obj9 + 28;
			obj8 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIRect+AnchorPoint)+9]");
			if ((nint)0 == 0)
			{
				return;
			}
			nint num = (nint)typeof(Uri);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v20 (Il2CppClass<System.Uri>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num2 = (nint)typeof(Uri);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S1_v121 (Il2CppClass<System.Uri>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIRect+AnchorPoint)+30]");
			if ((Uri)0 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				InvalidProgramException ex = default;
				ex._002Ector("EventLogger.Send: ServiceUri not initialized.");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIRect+AnchorPoint)+34]");
			if ((nint)0 == 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIRect+AnchorPoint)+48]");
			if ((nint)0 != 0)
			{
				return;
			}
			_ = 1;
			nint num3 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v47 (Il2CppClass<System.DateTime>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num4 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v193 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
			obj3 = systemTimeAsFileTime;
			variableBool = (VariableBool)obj3;
			object obj12 = obj9 + 36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIRect+AnchorPoint)+1C]");
			obj12 = 0;
			object obj13 = obj9 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIRect+AnchorPoint)+20]");
			obj13 = 0;
			object obj14 = obj9 + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIRect+AnchorPoint)+34]");
			string[] directories = Directory.GetDirectories((string)0, "*");
			obj14 = directories;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v28+8]");
			Array.Sort((string[])0);
			nint num5 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v63 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num6 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v189 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj16 = obj9 + 40;
			string bundleIdentifier = DeviceUtility.GetBundleIdentifier();
			obj16 = bundleIdentifier;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v28+28]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v28+28]");
			bool flag;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S0_v70+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				object obj18 = obj9 + 40;
				obj18 = "0.0";
			}
			nint num7 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v74 (Il2CppClass<Globals>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num8 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v177 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(Globals.DEBUG ? 1u : 0u) == 0)
			{
				object obj20 = obj9 + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v28+28]");
				string text = string.ConcatArray((string[])0, (int)".0");
				obj20 = text;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			nint num9 = 0;
			_ = 0;
			object obj22 = default;
			object obj21 = obj22 + 16;
			obj21 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj23 = default;
			if (obj23 == null)
			{
				_ = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v28+C]");
			if (!(0f > 0f))
			{
				return;
			}
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIRect+AnchorPoint)+48]");
				if ((nint)0 == 0)
				{
					break;
				}
				nint num10 = (nint)typeof(TimeSpan);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ S0_v100 (Il2CppClass<System.TimeSpan>)+BA]");
				object obj24 = (nint)0 & (nint)0x200;
				if (obj24 != null)
				{
					nint num11 = (nint)typeof(TimeSpan);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ S0_v124 (Il2CppClass<System.TimeSpan>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				TimeSpan timeSpan = TimeSpan.FromMinutes(5.0);
				nint num12 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ S0_v107 (Il2CppClass<Utils>)+BA]");
				object obj25 = (nint)0 & (nint)0x200;
				if (obj25 != null)
				{
					nint num13 = (nint)typeof(Utils);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ S0_v120 (Il2CppClass<Utils>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj4 = timeSpan;
				variableBool = (VariableBool)obj4;
				variableBool._002Ector();
				nint num14 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ S1_v66 (Il2CppClass<System.DateTime>)+BA]");
				object obj26 = (nint)0 & (nint)0x200;
				if (obj26 != null)
				{
					nint num15 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ S1_v84 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				long systemTimeAsFileTime2 = DateTime.GetSystemTimeAsFileTime();
				obj5 = systemTimeAsFileTime2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v28+10]");
				obj2 = 0;
				((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj5;
				variableBool = (VariableBool)obj2;
				long num16 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64((IFormatProvider)variableBool);
				obj6 = num16;
				double num17 = (double)obj6 * 1E-07;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v28+C]");
				double num18 = 0.0 - num17;
				if (!(num18 > 0.0))
				{
					_ = 0;
					break;
				}
			}
		}

		public void Set(Transform target, float relative, float absolute)
		{
			//IL_0015: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I
			//IL_00c6: Expected F4, but got I
			//IL_0132: Expected Obj, but got I
			//IL_014f: Expected Obj, but got I4
			//IL_0626: Expected Obj, but got I
			//IL_01d9: Expected Obj, but got I
			//IL_067b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0680: Expected Obj, but got Unknown
			//IL_05bf: Expected Obj, but got I
			//IL_05e2: Expected F4, but got I4
			//IL_019b: Expected Obj, but got I
			//IL_01be: Expected F4, but got I4
			//IL_0406: Expected Obj, but got I
			//IL_029b: Expected Obj, but got I
			//IL_0436: Invalid comparison between F4 and I4
			//IL_02cb: Invalid comparison between F4 and I4
			//IL_04ce: Expected Obj, but got I
			//IL_02f5: Expected Obj, but got I
			//IL_0490: Expected Obj, but got I
			//IL_04b3: Expected F4, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIRect+AnchorPoint)+34]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIRect+AnchorPoint)+34]");
			object obj3;
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIRect+AnchorPoint)+34]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+14]");
				float num = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v19 (System.Single)+28]");
				if ((nint)0 == -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v19 (System.Single)+2A]");
				bool flag = (nint)0 == 3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v19 (System.Single)+24]");
				object obj10 = (nint)0 & (nint)0x10;
				bool flag2 = obj10 == null;
				object obj11 = (flag2 ? 1 : 0) ^ 1;
				float num3;
				float num2;
				if (obj11 != null)
				{
					if (flag)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+8]");
						object obj12 = (nint)0 & (nint)0x3F;
						num2 = (float)obj12 + 79818f;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v197 @ S4_v16 (System.Single) (should have been resolved before IL gen)");
						num3 = 79818f;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+8]");
						object obj13 = (nint)0 & (nint)0x1F;
						num3 = (float)obj13 + 96981f;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v195 @ S5_v6 (System.Single) (should have been resolved before IL gen)");
						num2 = num;
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v19 (System.Single)+28]");
				bool flag3 = (nint)0 != -1;
				if (!flag)
				{
					if (flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+10]");
						bool flag4;
						if ((nint)0 != 0)
						{
							object obj14 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v94+9C]");
							object obj15 = (nint)0 & (nint)0x100;
							flag4 = obj15 != null;
						}
						else
						{
							flag4 = false;
						}
						if (!flag4 && this.relative != 0f)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v19 (System.Single)+2B]");
							object obj16 = (nint)0 & (nint)3;
							bool flag5 = (nint)obj16 == 2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
							if (flag5)
							{
								if (obj17 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8044");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8045");
								}
							}
							else if (obj17 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8046");
								num2 = absolute;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8047");
							}
							continue;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+8]");
					object obj18 = (nint)0 & (nint)0x3F;
					num2 = (float)obj18 + 79818f;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v197 @ S4_v16 (System.Single) (should have been resolved before IL gen)");
					num3 = 79818f;
					continue;
				}
				if (flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+10]");
					bool flag6;
					if ((nint)0 != 0)
					{
						object obj19 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v66+9C]");
						object obj20 = (nint)0 & (nint)0x100;
						flag6 = obj20 != null;
					}
					else
					{
						flag6 = false;
					}
					if (!flag6 && this.relative != 0f)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+10]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+8]");
							object obj21 = (nint)0 & (nint)0x3F;
							num2 = (float)obj21 + 79818f;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v197 @ S4_v16 (System.Single) (should have been resolved before IL gen)");
							num3 = 79818f;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v19 (System.Single)+2B]");
						object obj22 = (nint)0 & (nint)3;
						bool flag7 = (nint)obj22 == 2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
						if (flag7)
						{
							if (obj23 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8048");
								num2 = absolute;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8049");
								num2 = absolute;
							}
						}
						else if (obj23 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @804A");
							num3 = absolute;
							num2 = relative;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @804B");
							num2 = absolute;
						}
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+8]");
				object obj24 = (nint)0 & (nint)0x1F;
				num3 = (float)obj24 + 96981f;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v195 @ S5_v6 (System.Single) (should have been resolved before IL gen)");
				num2 = num;
			}
		}

		public void SetToNearest(float abs0, float abs1, float abs2)
		{
			//IL_0277: Unknown result type (might be due to invalid IL or missing references)
			//IL_027c: Expected Obj, but got Unknown
			//IL_0291: Expected VT, but got I
			//IL_029f: Expected I, but got Obj
			//IL_02b5: Expected Obj, but got I
			//IL_02db: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e0: Expected Obj, but got Unknown
			//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ee: Expected Obj, but got Unknown
			//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fc: Expected Obj, but got Unknown
			//IL_0305: Unknown result type (might be due to invalid IL or missing references)
			//IL_030a: Expected Obj, but got Unknown
			//IL_0313: Unknown result type (might be due to invalid IL or missing references)
			//IL_0318: Expected Obj, but got Unknown
			//IL_0321: Unknown result type (might be due to invalid IL or missing references)
			//IL_0326: Expected Obj, but got Unknown
			//IL_01e9: Expected VT, but got I
			//IL_0206: Expected Obj, but got I4
			//IL_021d: Expected Obj, but got F4
			//IL_0241: Expected I, but got F4
			//IL_0013: Expected I, but got Obj
			//IL_0067: Expected VT, but got I
			//IL_0075: Expected I, but got Obj
			//IL_008b: Expected Obj, but got I
			//IL_03ad: Expected VT, but got Obj
			//IL_011f: Expected VT, but got Obj
			//IL_014f: Expected F4, but got I4
			//IL_014f: Expected VT, but got Obj
			//IL_00b6: Expected I, but got Obj
			//IL_019c: Expected VT, but got Obj
			//IL_019c: Expected VT, but got Obj
			object obj = default;
			Transform transform = (Transform)(obj + 84);
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIRect+AnchorPoint)+1C]");
			transform2.position = (Vector3)0;
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v42 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Transform transform3 = (Transform)(obj + 72);
			Transform transform4 = (Transform)(obj + 60);
			object obj3 = obj + 48;
			object obj4 = obj + 36;
			object obj5 = obj + 24;
			object obj6 = obj + 12;
			float value = (float)(nint)((UnityEngine.Object)transform).m_CachedPtr - abs2;
			float num3 = Math.Abs(value);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIRect+AnchorPoint)+39]");
			if ((nint)0 != 0)
			{
				Transform transform5 = transform4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIRect+AnchorPoint)+20]");
				transform5.position = (Vector3)0;
				nint num4 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v32 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num5 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S1_v58 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector3 back = Vector3.back;
				float unscaledTime = Time.unscaledTime;
				transform = (Transform)obj3;
				Transform transform6 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v22+8]");
				((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
				Vector3 vector = (Vector3)transform / unscaledTime;
				transform = (Transform)obj4;
				Transform transform7 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v24+8]");
				((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
				Vector3 vector2 = (Vector3)transform / abs0;
				transform = (Transform)obj5;
				Transform transform8 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v26+8]");
				((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
				Vector3 vector3 = (Vector3)transform / absolute;
				transform3 = transform4;
				((UnityEngine.Object)transform3).m_CachedPtr = ((UnityEngine.Object)transform4).m_CachedPtr;
				transform = (Transform)obj6;
				Transform transform9 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28+8]");
				((UnityEngine.Object)transform9).m_CachedPtr = (IntPtr)0;
				Quaternion quaternion = Quaternion.FromToRotation((Vector3)transform3, (Vector3)transform);
				transform = (Transform)obj;
				Transform transform10 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)transform10).m_CachedPtr = (IntPtr)0;
				Vector3 localPosition = transform.localPosition;
			}
			else
			{
				Transform transform11 = transform3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIRect+AnchorPoint)+1C]");
				transform11.position = (Vector3)0;
				float num6 = (float)(nint)((UnityEngine.Object)transform3).m_CachedPtr - abs1;
				transform4 = (Transform)0;
				((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
				transform4 = (Transform)0f;
				_ = 0f;
				float num7 = num6 * (float)absolute;
				((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)num7;
				transform = transform4;
				((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform4).m_CachedPtr;
				Vector3 eulerAngles = transform.eulerAngles;
			}
		}

		public void SetToNearest(float rel0, float rel1, float rel2, float abs0, float abs1, float abs2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		}

		public void SetHorizontal(Transform parent, float localPos)
		{
			//IL_0015: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I
			//IL_00c6: Expected F4, but got I
			//IL_0132: Expected Obj, but got I
			//IL_014f: Expected Obj, but got I4
			//IL_0626: Expected Obj, but got I
			//IL_01d9: Expected Obj, but got I
			//IL_067b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0680: Expected Obj, but got Unknown
			//IL_05bf: Expected Obj, but got I
			//IL_05e2: Expected F4, but got I4
			//IL_019b: Expected Obj, but got I
			//IL_01be: Expected F4, but got I4
			//IL_0406: Expected Obj, but got I
			//IL_029b: Expected Obj, but got I
			//IL_0436: Invalid comparison between F4 and I4
			//IL_02cb: Invalid comparison between F4 and I4
			//IL_04ce: Expected Obj, but got I
			//IL_02f5: Expected Obj, but got I
			//IL_0490: Expected Obj, but got I
			//IL_04b3: Expected F4, but got I4
			//IL_0587: Expected F4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIRect+AnchorPoint)+34]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIRect+AnchorPoint)+34]");
			object obj3;
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIRect+AnchorPoint)+34]");
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
				float num = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (System.Single)+28]");
				if ((nint)0 == -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (System.Single)+2A]");
				bool flag = (nint)0 == 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (System.Single)+24]");
				object obj10 = (nint)0 & (nint)0x10;
				bool flag2 = obj10 == null;
				object obj11 = (flag2 ? 1 : 0) ^ 1;
				float num3;
				float num2;
				if (obj11 != null)
				{
					if (flag)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
						object obj12 = (nint)0 & (nint)0x1FF;
						num2 = (float)obj12 + 79894f;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v188 @ S3_v16 (System.Single) (should have been resolved before IL gen)");
						num3 = 79894f;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
						object obj13 = (nint)0 & (nint)0x7F;
						num3 = (float)obj13 + 97019f;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v186 @ S4_v6 (System.Single) (should have been resolved before IL gen)");
						num2 = num;
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (System.Single)+28]");
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
						if (!flag4 && relative != 0f)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (System.Single)+2B]");
							object obj16 = (nint)0 & (nint)3;
							bool flag5 = (nint)obj16 == 2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
							if (flag5)
							{
								if (obj17 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9928");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9929");
								}
							}
							else if (obj17 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9466");
								num2 = localPos;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
							}
							continue;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
					object obj18 = (nint)0 & (nint)0x1FF;
					num2 = (float)obj18 + 79894f;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v188 @ S3_v16 (System.Single) (should have been resolved before IL gen)");
					num3 = 79894f;
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
					if (!flag6 && relative != 0f)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+10]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
							object obj21 = (nint)0 & (nint)0x1FF;
							num2 = (float)obj21 + 79894f;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v188 @ S3_v16 (System.Single) (should have been resolved before IL gen)");
							num3 = 79894f;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (System.Single)+2B]");
						object obj22 = (nint)0 & (nint)3;
						bool flag7 = (nint)obj22 == 2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
						if (flag7)
						{
							if (obj23 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A07C");
								num2 = localPos;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A07D");
								num2 = localPos;
							}
						}
						else if (obj23 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A07E");
							num3 = localPos;
							num2 = (float)parent;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A07F");
							num2 = localPos;
						}
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
				object obj24 = (nint)0 & (nint)0x7F;
				num3 = (float)obj24 + 97019f;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v186 @ S4_v6 (System.Single) (should have been resolved before IL gen)");
				num2 = num;
			}
		}

		public unsafe void SetVertical(Transform parent, float localPos)
		{
			//IL_0250: Unknown result type (might be due to invalid IL or missing references)
			//IL_0255: Expected Obj, but got Unknown
			//IL_025e: Expected Obj, but got I4
			//IL_0272: Expected I, but got Obj
			//IL_0288: Expected Obj, but got I
			//IL_038a: Unknown result type (might be due to invalid IL or missing references)
			//IL_038f: Expected Obj, but got Unknown
			//IL_0115: Expected VT, but got Obj
			//IL_0135: Expected I, but got Obj
			//IL_014b: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected Obj, but got Unknown
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected Obj, but got Unknown
			//IL_0086: Expected I, but got Obj
			//IL_009c: Expected Obj, but got I
			//IL_034e: Expected I, but got Obj
			//IL_0364: Expected Obj, but got I
			//IL_0176: Expected I, but got Obj
			//IL_02b8: Expected F4, but got Obj
			//IL_02b8: Expected F4, but got Obj
			//IL_00c7: Expected I, but got Obj
			//IL_0208: Expected I, but got Obj
			Transform transform = default;
			object obj = transform + 12;
			obj = 0;
			_ = 0;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v51 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Transform transform2 = (Transform)(transform + 24);
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)rect))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
				object obj4 = default;
				object obj3 = obj4 + 16;
				object obj5 = obj4 + 40;
				nint num3 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v60 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num4 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v65 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num5 = Mathf.LerpUnclamped((float)obj3, (float)obj5, relative);
				float num6 = localPos - num5;
				float f = num6 + 0.5f;
				int num7 = Mathf.RoundToInt(f);
				absolute = num7;
				return;
			}
			transform2.position = (Vector3)target;
			obj = transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num9 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v46 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)parent).FindKernel((string)null) != 0)
			{
				transform2 = (Transform)obj;
				Transform transform3 = transform2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
				transform.Internal_LookAt_Injected(ref *(Vector3*)parent, ref *(Vector3*)transform2);
				obj = transform;
				_ = ((UnityEngine.Object)transform).m_CachedPtr;
			}
			transform2 = (Transform)obj;
			Transform transform4 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			nint num10 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v32 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num11 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v37 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num12 = localPos - (float)transform2;
			float f2 = num12 + 0.5f;
			int num13 = Mathf.RoundToInt(f2);
			absolute = num13;
		}

		public Vector3[] GetSides(Transform relativeTo)
		{
			return (Vector3[])(object)new InvalidOperationException();
		}
	}

	public enum AnchorUpdate
	{
		OnEnable,
		OnUpdate,
		OnStart
	}

	public AnchorPoint leftAnchor;

	public AnchorPoint rightAnchor;

	public AnchorPoint bottomAnchor;

	public AnchorPoint topAnchor;

	public AnchorUpdate updateAnchors;

	[NonSerialized]
	protected GameObject mGo;

	[NonSerialized]
	protected Transform mTrans;

	[NonSerialized]
	protected BetterList<UIRect> mChildren;

	[NonSerialized]
	protected bool mChanged;

	[NonSerialized]
	protected bool mParentFound;

	[NonSerialized]
	private bool mUpdateAnchors;

	[NonSerialized]
	private int mUpdateFrame;

	[NonSerialized]
	private bool mAnchorsCached;

	[NonSerialized]
	private UIRoot mRoot;

	[NonSerialized]
	private UIRect mParent;

	[NonSerialized]
	private bool mRootSet;

	[NonSerialized]
	protected Camera mCam;

	protected bool mStarted;

	[NonSerialized]
	public float finalAlpha;

	protected static Vector3[] mSides;

	public GameObject cachedGameObject
	{
		get
		{
			//IL_001d: Invalid comparison between F4 and I4
			//IL_0065: Invalid comparison between F4 and I
			//IL_0073: Expected Obj, but got I4
			if (topAnchor != null)
			{
				AnchorPoint anchorPoint = topAnchor;
				if (anchorPoint.relative > 0f)
				{
					AnchorPoint anchorPoint2 = topAnchor;
					IntPtr cachedPtr = ((UnityEngine.Object)this).m_CachedPtr;
					float relative = anchorPoint2.relative;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v6 (System.IntPtr)+C]");
					bool flag = relative == 0f;
					return (GameObject)flag;
				}
				return null;
			}
			return null;
		}
	}

	public Transform cachedTransform
	{
		get
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (mGo != null)
			{
				object obj2 = this + 32;
				string text = tag;
				obj2 = text;
			}
			return (Transform)(object)mGo;
		}
	}

	public Camera anchorCamera
	{
		get
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (mTrans != null)
			{
				object obj2 = this + 36;
				GameObject gameObject = base.gameObject;
				obj2 = gameObject;
			}
			return (Camera)(object)mTrans;
		}
	}

	public bool isFullyAnchored
	{
		get
		{
			//IL_0090: Expected I, but got Obj
			//IL_00a6: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0082: Expected I4, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)mCam) || ~(mAnchorsCached ? 1u : 0u) != 0)
			{
				ResetAndUpdateAnchors();
			}
			return (byte)(int)mCam != 0;
		}
	}

	public virtual bool isAnchoredHorizontally
	{
		get
		{
			//IL_025c: Expected I, but got Obj
			//IL_0272: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_00ab: Expected I, but got Obj
			//IL_0102: Expected I, but got Obj
			//IL_0118: Expected Obj, but got I
			//IL_0143: Expected I, but got Obj
			//IL_019a: Expected I, but got Obj
			//IL_01b0: Expected Obj, but got I
			//IL_01db: Expected I, but got Obj
			AnchorPoint anchorPoint = leftAnchor;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v41 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint.target))
			{
				AnchorPoint anchorPoint2 = rightAnchor;
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v37 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint2.target))
				{
					AnchorPoint anchorPoint3 = topAnchor;
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num6 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint3.target))
					{
						AnchorPoint anchorPoint4 = bottomAnchor;
						nint num7 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						if (obj4 != null)
						{
							nint num8 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						return UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint4.target);
					}
					return false;
				}
				return false;
			}
			return false;
		}
	}

	public virtual bool isAnchoredVertically
	{
		get
		{
			//IL_0115: Expected I, but got Obj
			//IL_012b: Expected Obj, but got I
			//IL_0078: Expected I, but got Obj
			//IL_008e: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00b9: Expected I, but got Obj
			AnchorPoint anchorPoint = leftAnchor;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint.target))
			{
				return true;
			}
			AnchorPoint anchorPoint2 = rightAnchor;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint2.target);
		}
	}

	public virtual bool canBeAnchored
	{
		get
		{
			//IL_0115: Expected I, but got Obj
			//IL_012b: Expected Obj, but got I
			//IL_0078: Expected I, but got Obj
			//IL_008e: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00b9: Expected I, but got Obj
			AnchorPoint anchorPoint = bottomAnchor;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint.target))
			{
				return true;
			}
			AnchorPoint anchorPoint2 = topAnchor;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint2.target);
		}
	}

	public UIRect parent
	{
		get
		{
			//IL_0006: Expected Obj, but got I4
			return (UIRect)1;
		}
	}

	public UIRoot root
	{
		get
		{
			//IL_003a: Expected I, but got Obj
			//IL_0050: Expected Obj, but got I
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Expected Obj, but got Unknown
			//IL_007b: Expected I, but got Obj
			if (~(mParentFound ? 1u : 0u) != 0)
			{
				mParentFound = true;
				Camera camera = anchorCamera;
				Transform parentInternal = ((Transform)(object)camera).parentInternal;
				nint num = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v16 (Il2CppClass<NGUITools>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v22 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj2 = this + 60;
				UIRect uIRect = NGUITools.FindInParents<UIRect>(parentInternal);
				obj2 = uIRect;
			}
			return (UIRoot)(object)mParent;
		}
	}

	public bool isAnchored
	{
		get
		{
			//IL_000e: Expected I, but got Obj
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Expected Obj, but got Unknown
			//IL_01d4: Expected I4, but got Obj
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Expected Obj, but got Unknown
			//IL_00ad: Expected Obj, but got I4
			//IL_00ca: Expected I, but got Obj
			//IL_00e0: Expected Obj, but got I
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e4: Expected Obj, but got Unknown
			//IL_0167: Expected I, but got Obj
			//IL_017d: Expected Obj, but got I
			//IL_010b: Expected I, but got Obj
			UIRoot uIRoot = default;
			UIRect uIRect = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIRoot).FindKernel((string)null) != 0)
					{
						uIRect = mParent;
						uIRoot = mParent.root;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					object obj2 = mParent - -64;
					if (obj2 == null)
					{
						object obj3 = mParent - -64;
						obj3 = 1;
						Camera trans = mParent.anchorCamera;
						nint num3 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v23 (Il2CppClass<NGUITools>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						if (obj4 != null)
						{
							nint num4 = (nint)typeof(NGUITools);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v29 (Il2CppClass<NGUITools>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						object obj5 = mParent + 56;
						UIRoot uIRoot2 = NGUITools.FindInParents<UIRoot>((Transform)(object)trans);
						obj5 = uIRoot2;
					}
					return (byte)(int)uIRect.mRoot != 0;
				}
				while (obj == null);
			}
		}
	}

	public abstract float alpha { get; set; }

	public abstract Vector3[] localCorners { get; }

	public abstract Vector3[] worldCorners { get; }

	protected float cameraRayDistance => 1f;

	public abstract float CalculateFinalAlpha(int frameID);

	public virtual void Invalidate(bool includeChildren)
	{
		UIEventListener uIEventListener = UIEventListener.Get((GameObject)(object)this);
		if ((object)uIEventListener != null && ~(mStarted ? 1u : 0u) == 0)
		{
			string text = tag;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
		}
	}

	public virtual Vector3[] GetSides(Transform relativeTo)
	{
		//IL_00ab: Expected Obj, but got I4
		//IL_00b9: Expected I, but got Obj
		//IL_00cf: Expected Obj, but got I
		//IL_0022: Expected I, but got Obj
		//IL_0038: Expected Obj, but got I
		//IL_017e: Expected I4, but got Obj
		//IL_017e: Expected I4, but got Obj
		//IL_00fa: Expected I, but got Obj
		//IL_0063: Expected I, but got Obj
		UIDrawCall uIDrawCall = (UIDrawCall)(object)this;
		Transform transform;
		if ((object)this != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
			nint num = (nint)typeof(PropertyReference);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v27 (Il2CppClass<PropertyReference>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(PropertyReference);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v31 (Il2CppClass<PropertyReference>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Transform transform2 = default;
			transform = transform2;
		}
		else
		{
			uIDrawCall = (UIDrawCall)0;
			nint num3 = (nint)typeof(PropertyReference);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v15 (Il2CppClass<PropertyReference>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(PropertyReference);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v20 (Il2CppClass<PropertyReference>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			transform = relativeTo;
		}
		return (Vector3[])(object)uIDrawCall.GenerateCachedIndexBuffer((int)transform, (int)relativeTo);
	}

	protected unsafe Vector3 GetLocalPos(AnchorPoint ac, Transform trans)
	{
		//IL_1419: Unknown result type (might be due to invalid IL or missing references)
		//IL_141e: Expected Obj, but got Unknown
		//IL_1427: Expected Obj, but got I4
		//IL_1436: Unknown result type (might be due to invalid IL or missing references)
		//IL_143b: Expected Obj, but got Unknown
		//IL_1444: Expected Obj, but got I4
		//IL_145b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1460: Expected Obj, but got Unknown
		//IL_1469: Expected Obj, but got I4
		//IL_1478: Unknown result type (might be due to invalid IL or missing references)
		//IL_147d: Expected Obj, but got Unknown
		//IL_1486: Expected Obj, but got I4
		//IL_149e: Expected I, but got Obj
		//IL_14b4: Expected Obj, but got I
		//IL_14da: Unknown result type (might be due to invalid IL or missing references)
		//IL_14df: Expected VT, but got Unknown
		//IL_14e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ed: Expected Obj, but got Unknown
		//IL_14f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_14fb: Expected Obj, but got Unknown
		//IL_1504: Unknown result type (might be due to invalid IL or missing references)
		//IL_1509: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0079: Expected I, but got Obj
		//IL_008f: Expected Obj, but got I
		//IL_1548: Expected F4, but got Obj
		//IL_1543: Expected native int or pointer, but got VT
		//IL_1581: Expected F4, but got Obj
		//IL_157c: Expected native int or pointer, but got VT
		//IL_15c8: Expected I4, but got VT
		//IL_15f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f5: Expected Obj, but got Unknown
		//IL_00ba: Expected I, but got Obj
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected Obj, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_0106: Expected F4, but got Obj
		//IL_0101: Expected native int or pointer, but got VT
		//IL_0259: Expected I, but got Obj
		//IL_026f: Expected Obj, but got I
		//IL_161e: Expected F4, but got Obj
		//IL_1619: Expected native int or pointer, but got VT
		//IL_1644: Expected F4, but got Obj
		//IL_163f: Expected native int or pointer, but got VT
		//IL_014d: Expected F4, but got Obj
		//IL_0148: Expected native int or pointer, but got VT
		//IL_016b: Invalid comparison between I and F4
		//IL_167e: Expected F4, but got Obj
		//IL_1679: Expected native int or pointer, but got VT
		//IL_029a: Expected I, but got Obj
		//IL_2db5: Expected I, but got Obj
		//IL_2dcb: Expected Obj, but got I
		//IL_02e2: Expected Obj, but got F4
		//IL_0197: Expected F4, but got Obj
		//IL_0192: Expected native int or pointer, but got VT
		//IL_01b5: Invalid comparison between I and F4
		//IL_16b8: Expected F4, but got Obj
		//IL_16b3: Expected native int or pointer, but got VT
		//IL_16cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d4: Expected Obj, but got Unknown
		//IL_16e1: Expected Obj, but got F4
		//IL_1700: Unknown result type (might be due to invalid IL or missing references)
		//IL_1705: Expected Obj, but got Unknown
		//IL_1731: Unknown result type (might be due to invalid IL or missing references)
		//IL_1736: Expected Obj, but got Unknown
		//IL_1746: Expected Obj, but got I
		//IL_1765: Unknown result type (might be due to invalid IL or missing references)
		//IL_176a: Expected Obj, but got Unknown
		//IL_0400: Expected I, but got Obj
		//IL_0416: Expected Obj, but got I
		//IL_0300: Expected I, but got Obj
		//IL_01e6: Expected Obj, but got VT
		//IL_190d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1912: Expected Obj, but got Unknown
		//IL_191f: Expected F4, but got Obj
		//IL_191a: Expected native int or pointer, but got VT
		//IL_1936: Unknown result type (might be due to invalid IL or missing references)
		//IL_193b: Expected Obj, but got Unknown
		//IL_194b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1950: Expected Obj, but got Unknown
		//IL_1962: Unknown result type (might be due to invalid IL or missing references)
		//IL_1967: Expected Obj, but got Unknown
		//IL_1986: Unknown result type (might be due to invalid IL or missing references)
		//IL_198b: Expected Obj, but got Unknown
		//IL_19aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_19af: Expected Obj, but got Unknown
		//IL_19b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_19bd: Expected Obj, but got Unknown
		//IL_19cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d4: Expected Obj, but got Unknown
		//IL_19dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e2: Expected Obj, but got Unknown
		//IL_19f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f9: Expected Obj, but got Unknown
		//IL_1a02: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a07: Expected Obj, but got Unknown
		//IL_1a17: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a1c: Expected Obj, but got Unknown
		//IL_1a2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a33: Expected Obj, but got Unknown
		//IL_1a3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a41: Expected Obj, but got Unknown
		//IL_1a51: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a56: Expected Obj, but got Unknown
		//IL_0441: Expected I, but got Obj
		//IL_0541: Expected I, but got Obj
		//IL_0557: Expected Obj, but got I
		//IL_0372: Expected I, but got Obj
		//IL_0388: Expected Obj, but got I
		//IL_1c1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c21: Expected Obj, but got Unknown
		//IL_1c2e: Expected F4, but got Obj
		//IL_1c29: Expected native int or pointer, but got VT
		//IL_1c45: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c4a: Expected Obj, but got Unknown
		//IL_1c67: Expected Obj, but got I
		//IL_1c76: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c7b: Expected Obj, but got Unknown
		//IL_1c9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c9f: Expected Obj, but got Unknown
		//IL_1ccd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cd2: Expected Obj, but got Unknown
		//IL_1cdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce0: Expected Obj, but got Unknown
		//IL_1cf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cfc: Expected Obj, but got Unknown
		//IL_1d05: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d0a: Expected Obj, but got Unknown
		//IL_1d21: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d26: Expected Obj, but got Unknown
		//IL_1d2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d34: Expected Obj, but got Unknown
		//IL_1d51: Expected Obj, but got I
		//IL_1d60: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d65: Expected Obj, but got Unknown
		//IL_1d6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d73: Expected I4, but got Unknown
		//IL_1da0: Expected Obj, but got I
		//IL_1db5: Expected F4, but got I
		//IL_17a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ab: Expected Obj, but got Unknown
		//IL_17b8: Expected F4, but got Obj
		//IL_17b3: Expected native int or pointer, but got VT
		//IL_17cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d4: Expected Obj, but got Unknown
		//IL_17f0: Expected Obj, but got F4
		//IL_17fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ff: Expected Obj, but got Unknown
		//IL_181e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1823: Expected Obj, but got Unknown
		//IL_1833: Unknown result type (might be due to invalid IL or missing references)
		//IL_1838: Expected Obj, but got Unknown
		//IL_184a: Unknown result type (might be due to invalid IL or missing references)
		//IL_184f: Expected Obj, but got Unknown
		//IL_1858: Unknown result type (might be due to invalid IL or missing references)
		//IL_185d: Expected Obj, but got Unknown
		//IL_186f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1874: Expected Obj, but got Unknown
		//IL_187d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1882: Expected Obj, but got Unknown
		//IL_1894: Unknown result type (might be due to invalid IL or missing references)
		//IL_1899: Expected Obj, but got Unknown
		//IL_18a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a7: Expected Obj, but got Unknown
		//IL_18b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_18bc: Expected Obj, but got Unknown
		//IL_18ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d3: Expected Obj, but got Unknown
		//IL_18dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_18e1: Expected Obj, but got Unknown
		//IL_18f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f6: Expected Obj, but got Unknown
		//IL_2e16: Expected Obj, but got I4
		//IL_0582: Expected I, but got Obj
		//IL_03b3: Expected I, but got Obj
		//IL_04b3: Expected I, but got Obj
		//IL_04c9: Expected Obj, but got I
		//IL_1a6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a72: Expected Obj, but got Unknown
		//IL_1a7f: Expected F4, but got Obj
		//IL_1a7a: Expected native int or pointer, but got VT
		//IL_1a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a9b: Expected Obj, but got Unknown
		//IL_1ac6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1acb: Expected Obj, but got Unknown
		//IL_1aea: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aef: Expected Obj, but got Unknown
		//IL_1b1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b22: Expected Obj, but got Unknown
		//IL_1b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b30: Expected Obj, but got Unknown
		//IL_1b47: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b4c: Expected Obj, but got Unknown
		//IL_1b55: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b5a: Expected Obj, but got Unknown
		//IL_1b71: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b76: Expected Obj, but got Unknown
		//IL_1b7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b84: Expected Obj, but got Unknown
		//IL_1ba1: Expected Obj, but got I
		//IL_1bb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb5: Expected Obj, but got Unknown
		//IL_1bbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc3: Expected I4, but got Unknown
		//IL_1bf0: Expected Obj, but got I
		//IL_1c05: Expected F4, but got I
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Expected Obj, but got Unknown
		//IL_05e7: Expected Obj, but got I4
		//IL_04f4: Expected I, but got Obj
		//IL_13fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1403: Expected Obj, but got Unknown
		//IL_061f: Expected Obj, but got I4
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Expected Obj, but got Unknown
		//IL_1de4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de9: Expected Obj, but got Unknown
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected Obj, but got Unknown
		//IL_0677: Expected Obj, but got I4
		//IL_07a3: Expected I, but got Obj
		//IL_07b9: Expected Obj, but got I
		//IL_07d6: Expected I, but got Obj
		//IL_1f72: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f77: Expected Obj, but got Unknown
		//IL_1f81: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f86: Expected Obj, but got Unknown
		//IL_1fab: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fb0: Expected Obj, but got Unknown
		//IL_1fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fbf: Expected Obj, but got Unknown
		//IL_1fe4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fe9: Expected Obj, but got Unknown
		//IL_1ff3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ff8: Expected Obj, but got Unknown
		//IL_2008: Expected F4, but got I
		//IL_0cba: Expected I, but got Obj
		//IL_0cd0: Expected Obj, but got I
		//IL_0ced: Expected I, but got Obj
		//IL_228c: Invalid comparison between F4 and I
		//IL_07f2: Expected I, but got Obj
		//IL_0800: Expected I, but got Obj
		//IL_245d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2462: Expected Obj, but got Unknown
		//IL_246c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2471: Expected Obj, but got Unknown
		//IL_2496: Unknown result type (might be due to invalid IL or missing references)
		//IL_249b: Expected Obj, but got Unknown
		//IL_24c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_24c5: Expected Obj, but got Unknown
		//IL_24ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ef: Expected Obj, but got Unknown
		//IL_24f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_24fe: Expected Obj, but got Unknown
		//IL_2523: Unknown result type (might be due to invalid IL or missing references)
		//IL_2528: Expected Obj, but got Unknown
		//IL_254b: Expected F4, but got Obj
		//IL_0705: Expected I, but got Obj
		//IL_071b: Expected Obj, but got I
		//IL_0738: Expected I4, but got Obj
		//IL_1095: Expected I, but got Obj
		//IL_10ab: Expected Obj, but got I
		//IL_10c8: Expected I, but got Obj
		//IL_2680: Invalid comparison between F4 and Obj
		//IL_2699: Expected F4, but got Obj
		//IL_26a9: Expected F4, but got I
		//IL_26b9: Expected F4, but got I
		//IL_0d09: Expected I, but got Obj
		//IL_0d17: Expected I, but got Obj
		//IL_0841: Expected I, but got Obj
		//IL_0857: Expected Obj, but got I
		//IL_0874: Expected I, but got Obj
		//IL_082e: Expected I, but got Obj
		//IL_1e06: Expected Obj, but got I
		//IL_1e0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e14: Expected Obj, but got Unknown
		//IL_1e1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e23: Expected Obj, but got Unknown
		//IL_1e48: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e4d: Expected Obj, but got Unknown
		//IL_1e57: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e5c: Expected Obj, but got Unknown
		//IL_1e81: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e86: Expected Obj, but got Unknown
		//IL_1e90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e95: Expected Obj, but got Unknown
		//IL_1eba: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ebf: Expected Obj, but got Unknown
		//IL_1ec9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ece: Expected Obj, but got Unknown
		//IL_1ef6: Expected F4, but got Obj
		//IL_1ef1: Expected native int or pointer, but got VT
		//IL_1f1b: Expected F4, but got I
		//IL_1f2b: Expected F4, but got I
		//IL_1f3b: Expected F4, but got I
		//IL_1f43: Expected F4, but got Obj
		//IL_1f53: Expected F4, but got I
		//IL_1f5b: Expected F4, but got Obj
		//IL_1f63: Expected I4, but got Obj
		//IL_28a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_28ab: Expected Obj, but got Unknown
		//IL_28d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_28d5: Expected Obj, but got Unknown
		//IL_28fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_28ff: Expected Obj, but got Unknown
		//IL_2909: Unknown result type (might be due to invalid IL or missing references)
		//IL_290e: Expected Obj, but got Unknown
		//IL_2933: Unknown result type (might be due to invalid IL or missing references)
		//IL_2938: Expected Obj, but got Unknown
		//IL_295d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2962: Expected Obj, but got Unknown
		//IL_2987: Unknown result type (might be due to invalid IL or missing references)
		//IL_298c: Expected Obj, but got Unknown
		//IL_299c: Expected F4, but got I
		//IL_2028: Unknown result type (might be due to invalid IL or missing references)
		//IL_202d: Expected Obj, but got Unknown
		//IL_2055: Expected F4, but got Obj
		//IL_2050: Expected native int or pointer, but got VT
		//IL_2079: Invalid comparison between F4 and I
		//IL_0754: Expected I, but got Obj
		//IL_0762: Expected I4, but got Obj
		//IL_1365: Expected I, but got Obj
		//IL_137b: Expected Obj, but got I
		//IL_1398: Expected I4, but got Obj
		//IL_2b6d: Invalid comparison between F4 and I
		//IL_2b8e: Expected F4, but got I
		//IL_2b96: Expected F4, but got Obj
		//IL_2b9e: Expected F4, but got Obj
		//IL_10e4: Expected I, but got Obj
		//IL_10f2: Expected I, but got Obj
		//IL_0d57: Expected F4, but got Obj
		//IL_0d52: Expected native int or pointer, but got VT
		//IL_0d79: Expected I, but got Obj
		//IL_0d8f: Expected Obj, but got I
		//IL_0d45: Expected I, but got Obj
		//IL_0c1c: Expected I, but got Obj
		//IL_0c32: Expected Obj, but got I
		//IL_0c4f: Expected I4, but got Obj
		//IL_0962: Expected F4, but got I
		//IL_0973: Expected F4, but got I4
		//IL_0890: Expected I, but got Obj
		//IL_089e: Expected I, but got Obj
		//IL_2bbc: Expected Obj, but got I
		//IL_2bc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bca: Expected Obj, but got Unknown
		//IL_2bef: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bf4: Expected Obj, but got Unknown
		//IL_2c19: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c1e: Expected Obj, but got Unknown
		//IL_2c43: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c48: Expected Obj, but got Unknown
		//IL_2c6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c72: Expected Obj, but got Unknown
		//IL_2c97: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c9c: Expected Obj, but got Unknown
		//IL_2cc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cc6: Expected Obj, but got Unknown
		//IL_2ceb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cf0: Expected Obj, but got Unknown
		//IL_2d18: Expected F4, but got Obj
		//IL_2d13: Expected native int or pointer, but got VT
		//IL_2d3d: Expected F4, but got I
		//IL_2d4d: Expected F4, but got I
		//IL_2d5d: Expected F4, but got I
		//IL_2d65: Expected F4, but got Obj
		//IL_2d75: Expected F4, but got I
		//IL_2d7d: Expected F4, but got Obj
		//IL_2d85: Expected I4, but got Obj
		//IL_256b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2570: Expected Obj, but got Unknown
		//IL_2593: Invalid comparison between F4 and Obj
		//IL_25ac: Expected F4, but got Obj
		//IL_22bb: Expected Obj, but got I
		//IL_22c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_22c9: Expected Obj, but got Unknown
		//IL_22d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_22d8: Expected Obj, but got Unknown
		//IL_22fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2302: Expected Obj, but got Unknown
		//IL_2327: Unknown result type (might be due to invalid IL or missing references)
		//IL_232c: Expected Obj, but got Unknown
		//IL_2351: Unknown result type (might be due to invalid IL or missing references)
		//IL_2356: Expected Obj, but got Unknown
		//IL_2360: Unknown result type (might be due to invalid IL or missing references)
		//IL_2365: Expected Obj, but got Unknown
		//IL_238a: Unknown result type (might be due to invalid IL or missing references)
		//IL_238f: Expected Obj, but got Unknown
		//IL_23b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_23b9: Expected Obj, but got Unknown
		//IL_23e1: Expected F4, but got Obj
		//IL_23dc: Expected native int or pointer, but got VT
		//IL_2406: Expected F4, but got I
		//IL_2416: Expected F4, but got I
		//IL_2426: Expected F4, but got I
		//IL_242e: Expected F4, but got Obj
		//IL_243e: Expected F4, but got I
		//IL_2446: Expected F4, but got Obj
		//IL_244e: Expected I4, but got Obj
		//IL_2129: Expected F4, but got Obj
		//IL_2131: Expected I4, but got F4
		//IL_08de: Expected F4, but got Obj
		//IL_08d9: Expected native int or pointer, but got VT
		//IL_08ec: Expected I, but got Obj
		//IL_0902: Expected Obj, but got I
		//IL_0790: Expected I4, but got Obj
		//IL_13b4: Expected I, but got Obj
		//IL_13c2: Expected I4, but got Obj
		//IL_1133: Expected I, but got Obj
		//IL_1149: Expected Obj, but got I
		//IL_1120: Expected I, but got Obj
		//IL_0ff7: Expected I, but got Obj
		//IL_100d: Expected Obj, but got I
		//IL_102a: Expected I4, but got Obj
		//IL_2edf: Expected I, but got Obj
		//IL_2ef5: Expected Obj, but got I
		//IL_0dba: Expected I, but got Obj
		//IL_0c6b: Expected I, but got Obj
		//IL_0c79: Expected I4, but got Obj
		//IL_225d: Invalid comparison between F4 and Obj
		//IL_20e4: Expected F4, but got I
		//IL_20e4: Expected F4, but got I
		//IL_210c: Expected I, but got Obj
		//IL_211c: Expected F4, but got I
		//IL_08cc: Expected I, but got Obj
		//IL_29bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_29c1: Expected Obj, but got Unknown
		//IL_29e9: Expected F4, but got Obj
		//IL_29e4: Expected native int or pointer, but got VT
		//IL_2a0d: Invalid comparison between F4 and I
		//IL_2704: Expected Obj, but got I
		//IL_270d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2712: Expected Obj, but got Unknown
		//IL_2737: Unknown result type (might be due to invalid IL or missing references)
		//IL_273c: Expected Obj, but got Unknown
		//IL_2761: Unknown result type (might be due to invalid IL or missing references)
		//IL_2766: Expected Obj, but got Unknown
		//IL_2770: Unknown result type (might be due to invalid IL or missing references)
		//IL_2775: Expected Obj, but got Unknown
		//IL_279a: Unknown result type (might be due to invalid IL or missing references)
		//IL_279f: Expected Obj, but got Unknown
		//IL_27c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_27c9: Expected Obj, but got Unknown
		//IL_27ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_27f3: Expected Obj, but got Unknown
		//IL_27fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2802: Expected Obj, but got Unknown
		//IL_282a: Expected F4, but got Obj
		//IL_2825: Expected native int or pointer, but got VT
		//IL_284f: Expected F4, but got I
		//IL_285f: Expected F4, but got I
		//IL_286f: Expected F4, but got I
		//IL_2877: Expected F4, but got Obj
		//IL_2887: Expected F4, but got I
		//IL_288f: Expected F4, but got Obj
		//IL_2897: Expected I4, but got Obj
		//IL_261c: Expected F4, but got Obj
		//IL_2617: Expected native int or pointer, but got VT
		//IL_2640: Expected F4, but got Obj
		//IL_263b: Expected native int or pointer, but got VT
		//IL_2665: Expected I4, but got Obj
		//IL_2673: Expected I4, but got Obj
		//IL_0dec: Expected F4, but got Obj
		//IL_0de7: Expected native int or pointer, but got VT
		//IL_0dfa: Expected I, but got Obj
		//IL_0e10: Expected Obj, but got I
		//IL_0ace: Expected F4, but got Obj
		//IL_0ac9: Expected native int or pointer, but got VT
		//IL_092d: Expected I, but got Obj
		//IL_13f0: Expected I4, but got Obj
		//IL_122a: Expected F4, but got I
		//IL_1174: Expected I, but got Obj
		//IL_1046: Expected I, but got Obj
		//IL_1054: Expected I4, but got Obj
		//IL_0e6e: Expected I4, but got Obj
		//IL_25f6: Expected F4, but got Obj
		//IL_25f6: Expected F4, but got Obj
		//IL_260a: Expected F4, but got Obj
		//IL_0ca7: Expected I4, but got Obj
		//IL_0985: Expected F4, but got Obj
		//IL_0980: Expected native int or pointer, but got VT
		//IL_09a7: Expected I, but got Obj
		//IL_09bd: Expected Obj, but got I
		//IL_2ab9: Expected I, but got Obj
		//IL_2acf: Expected Obj, but got I
		//IL_11a6: Expected F4, but got Obj
		//IL_11a1: Expected native int or pointer, but got VT
		//IL_11b4: Expected I, but got Obj
		//IL_11ca: Expected Obj, but got I
		//IL_0e3b: Expected I, but got Obj
		//IL_2148: Unknown result type (might be due to invalid IL or missing references)
		//IL_214d: Expected Obj, but got Unknown
		//IL_2170: Invalid comparison between F4 and Obj
		//IL_2189: Expected F4, but got Obj
		//IL_2af9: Expected F4, but got Obj
		//IL_2af4: Expected native int or pointer, but got VT
		//IL_2b1d: Expected F4, but got Obj
		//IL_2b18: Expected native int or pointer, but got VT
		//IL_2b4a: Expected I4, but got Obj
		//IL_2b58: Expected I4, but got Obj
		//IL_2a78: Expected F4, but got I
		//IL_2a78: Expected F4, but got I
		//IL_2a94: Expected F4, but got I
		//IL_1082: Expected I4, but got Obj
		//IL_2e8c: Expected I, but got Obj
		//IL_2ea2: Expected Obj, but got I
		//IL_09e8: Expected I, but got Obj
		//IL_1245: Expected I4, but got Obj
		//IL_11f5: Expected I, but got Obj
		//IL_21f9: Expected F4, but got Obj
		//IL_21f4: Expected native int or pointer, but got VT
		//IL_221d: Expected F4, but got Obj
		//IL_2218: Expected native int or pointer, but got VT
		//IL_2242: Expected I4, but got Obj
		//IL_2250: Expected I4, but got Obj
		//IL_0a1a: Expected F4, but got Obj
		//IL_0a15: Expected native int or pointer, but got VT
		//IL_0a28: Expected I, but got Obj
		//IL_0a3e: Expected Obj, but got I
		//IL_0a9c: Expected I4, but got Obj
		//IL_21d3: Expected F4, but got Obj
		//IL_21d3: Expected F4, but got Obj
		//IL_21e7: Expected F4, but got Obj
		//IL_0a69: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 112;
		obj = 0;
		_ = 0;
		UIDrawCall uIDrawCall = (UIDrawCall)(obj2 + 96);
		uIDrawCall = (UIDrawCall)0;
		((UnityEngine.Object)uIDrawCall).m_CachedPtr = (IntPtr)0;
		object obj3 = obj2 + 80;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v1039 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 vector = (Vector2)(obj2 + 32);
		object obj6 = obj2 - -64;
		object obj7 = obj2 + 24;
		object obj8 = obj2 + 48;
		UnityEngine.Object obj9 = default;
		if (obj9 != null)
		{
			goto IL_1604;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
		nint num3 = (nint)typeof(Vector4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v43 (Il2CppClass<UnityEngine.Vector4>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num4 = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v1035 (Il2CppClass<UnityEngine.Vector4>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector2*)(nint)vector)->x = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v29+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F51F");
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		((Vector2*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Vector3 vector2 = default;
		if (vector.x == 0f)
		{
			((Vector2*)(nint)vector)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			if (vector.y == 0f)
			{
				((Vector2*)(nint)vector)->x = (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (UnityEngine.Vector2)+8]");
				if (0f == 0f)
				{
					((Vector2*)(nint)vector)->x = (float)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (UnityEngine.Vector2)+C]");
					if (0f == 0f)
					{
						((UIBasicSprite)vector2).SlicedFill((List<Vector3>)(object)this, (List<Vector2>)(object)ac, (List<Color>)(object)trans);
						goto IL_1604;
					}
				}
			}
		}
		uIDrawCall.renderQueue = (int)vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
		obj3 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v29+8]");
		_ = 0;
		object obj11 = vector2 + 344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S0_v63+8]");
		object obj13 = default;
		object obj12 = 0 * obj13;
		object obj14 = vector2 + 344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S0_v67+C]");
		object obj15 = default;
		float num5 = 0f * (float)obj15;
		obj4 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
		nint num6 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S0_v77 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num7 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S0_v1015 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj7 = obj4;
		((Vector2*)(nint)vector)->x = (float)obj7;
		float num8 = default;
		Vector2 vector3 = vector / num8;
		obj4 = obj2;
		((Vector2*)(nint)vector)->x = (float)obj2;
		if (vector.x < 1f)
		{
			obj4 = 1f;
		}
		((Vector2*)(nint)vector)->x = (float)obj4;
		if (vector.y < 1f)
		{
			_ = 1f;
		}
		nint num9 = (nint)typeof(UIBasicSprite);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ S0_v96 (Il2CppClass<UIBasicSprite>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num10 = (nint)typeof(UIBasicSprite);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S0_v1007 (Il2CppClass<UIBasicSprite>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector2*)(nint)vector)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj18 = UIBasicSprite.mTempPos + 16;
		obj18 = vector.x;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj19 = UIBasicSprite.mTempPos + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v29+4]");
		_ = 0;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj20 = UIBasicSprite.mTempPos + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		obj20 = 0;
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj21 = UIBasicSprite.mTempPos + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v33+C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+130]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+130]");
			if ((nint)0 != 3)
			{
				nint num11 = (nint)typeof(UIBasicSprite);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ S0_v968 (Il2CppClass<UIBasicSprite>)+BA]");
				object obj22 = (nint)0 & (nint)0x200;
				if (obj22 != null)
				{
					nint num12 = (nint)typeof(UIBasicSprite);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ S0_v1001 (Il2CppClass<UIBasicSprite>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj23 = UIBasicSprite.mTempPos + 16;
				((Vector2*)(nint)vector)->x = (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				object obj24 = UIBasicSprite.mTempPos + 24;
				float num13 = (float)obj23 + vector.x;
				obj24 = num13;
				object obj25 = UIBasicSprite.mTempPos + 40;
				obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				object obj26 = UIBasicSprite.mTempPos + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v29+8]");
				object obj27 = obj25 - 0;
				obj26 = obj27;
				object obj28 = UIBasicSprite.mTempUVs + 16;
				object obj29 = vector2 + 360;
				obj28 = obj29;
				object obj30 = UIBasicSprite.mTempUVs + 24;
				object obj31 = vector2 + 344;
				obj30 = obj31;
				object obj32 = UIBasicSprite.mTempUVs + 32;
				object obj33 = vector2 + 344;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ S1_v539+8]");
				object obj34 = 0 + obj33;
				obj32 = obj34;
				object obj35 = UIBasicSprite.mTempUVs + 40;
				object obj36 = vector2 + 360;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ S1_v544+8]");
				object obj37 = 0 + obj36;
				obj35 = obj37;
				goto IL_2de8;
			}
		}
		nint num14 = (nint)typeof(UIBasicSprite);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ S0_v925 (Il2CppClass<UIBasicSprite>)+BA]");
		object obj38 = (nint)0 & (nint)0x200;
		if (obj38 != null)
		{
			nint num15 = (nint)typeof(UIBasicSprite);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ S0_v958 (Il2CppClass<UIBasicSprite>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj39 = UIBasicSprite.mTempPos + 16;
		((Vector2*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj40 = UIBasicSprite.mTempPos + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (UnityEngine.Vector2)+8]");
		object obj41 = obj39 + 0;
		obj40 = obj41;
		object obj42 = UIBasicSprite.mTempPos + 40;
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj43 = UIBasicSprite.mTempPos + 32;
		object obj44 = obj42 - obj6;
		obj43 = obj44;
		object obj45 = UIBasicSprite.mTempUVs + 40;
		object obj46 = vector2 + 360;
		obj45 = obj46;
		object obj47 = UIBasicSprite.mTempUVs + 32;
		object obj48 = vector2 + 344;
		obj47 = obj48;
		object obj49 = UIBasicSprite.mTempUVs + 24;
		object obj50 = vector2 + 344;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ S1_v497+8]");
		object obj51 = 0 + obj50;
		obj49 = obj51;
		object obj52 = UIBasicSprite.mTempUVs + 16;
		object obj53 = vector2 + 360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ S1_v502+8]");
		object obj54 = 0 + obj53;
		obj52 = obj54;
		goto IL_2de8;
		IL_2e0d:
		object obj55 = 0;
		float num16 = num5;
		bool flag3;
		float num23;
		bool flag6;
		while ((nint)obj55 <= 2)
		{
			object obj56 = obj55 + 1;
			bool flag = (nint)obj55 == 1;
			object obj220;
			for (object obj57 = 0; (nint)obj57 <= 2; obj220 = obj57 + 1, obj57 = obj220)
			{
				bool flag2 = (nint)obj57 == 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+178]");
				flag3 = (nint)0 == 0;
				object obj58 = flag & flag3;
				object obj59 = flag2 & obj58;
				bool flag4 = obj59 == null;
				bool flag5 = !flag4;
				flag6 = flag2;
				if (flag5)
				{
					continue;
				}
				object obj60 = obj57 + 1;
				object obj61 = flag & flag2;
				float num19;
				float num20;
				float num21;
				float num22;
				if (obj61 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+178]");
					if ((nint)0 != 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+178]");
						bool flag7 = (nint)0 != 1;
						flag6 = flag2;
						if (flag7)
						{
							continue;
						}
						nint num17 = (nint)typeof(UIBasicSprite);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1236 @ S0_v776 (Il2CppClass<UIBasicSprite>)+BA]");
						object obj62 = (nint)0 & (nint)0x200;
						bool flag8 = obj62 == null;
						flag6 = (byte)(int)typeof(UIBasicSprite) != 0;
						if (!flag8)
						{
							nint num18 = (nint)typeof(UIBasicSprite);
							flag6 = (byte)(int)typeof(UIBasicSprite) != 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1304 @ S0_v834 (Il2CppClass<UIBasicSprite>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								flag6 = (byte)(int)typeof(UIBasicSprite) != 0;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ L4_v9 (System.Boolean)+5C]");
						object obj63 = 0;
						object obj64 = obj63 + 24;
						object obj65 = UIBasicSprite.mTempPos + 16;
						object obj66 = obj56 << 3;
						object obj67 = obj65 + obj66;
						object obj68 = UIBasicSprite.mTempPos + 24;
						object obj69 = UIBasicSprite.mTempPos + 16;
						object obj70 = obj60 << 3;
						object obj71 = obj69 + obj70;
						object obj72 = UIBasicSprite.mTempUVs + 24;
						object obj73 = UIBasicSprite.mTempUVs + 16;
						object obj74 = obj56 << 3;
						object obj75 = obj73 + obj74;
						object obj76 = UIBasicSprite.mTempUVs + 24;
						object obj77 = UIBasicSprite.mTempUVs + 16;
						object obj78 = obj60 << 3;
						object obj79 = obj77 + obj78;
						((Vector2*)(nint)vector)->x = (float)uIDrawCall;
						_ = ((UnityEngine.Object)uIDrawCall).m_CachedPtr;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9AFB");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1331 @ S0_v796+4]");
						num19 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1378 @ S0_v829+4]");
						num20 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1367 @ S0_v822+4]");
						num21 = 0f;
						num22 = (float)obj67;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1342 @ S0_v803+4]");
						num16 = 0f;
						num23 = (float)obj64;
						flag3 = (byte)(int)trans != 0;
						continue;
					}
					nint num24 = (nint)typeof(UIBasicSprite);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1228 @ S0_v627 (Il2CppClass<UIBasicSprite>)+BA]");
					object obj80 = (nint)0 & (nint)0x200;
					bool flag9 = obj80 == null;
					nint num25 = (nint)typeof(UIBasicSprite);
					if (!flag9)
					{
						nint num26 = (nint)typeof(UIBasicSprite);
						num25 = (nint)typeof(UIBasicSprite);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1241 @ S0_v767 (Il2CppClass<UIBasicSprite>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							num25 = (nint)typeof(UIBasicSprite);
						}
					}
					object obj81 = UIBasicSprite.mTempPos + 24;
					object obj82 = UIBasicSprite.mTempPos + 16;
					object obj83 = obj56 << 3;
					object obj84 = obj82 + obj83;
					object obj85 = UIBasicSprite.mTempPos + 24;
					object obj86 = UIBasicSprite.mTempPos + 16;
					object obj87 = obj60 << 3;
					object obj88 = obj86 + obj87;
					object obj89 = UIBasicSprite.mTempUVs + 24;
					object obj90 = UIBasicSprite.mTempUVs + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1269 @ S0_v647+4]");
					num19 = 0f;
					flag3 = true;
					flag6 = (byte)num25 != 0;
					while (true)
					{
						float num27 = num19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1281 @ S0_v654+4]");
						if (!(num27 < 0f))
						{
							break;
						}
						nint num28 = (nint)typeof(UIBasicSprite);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1429 @ S0_v673 (Il2CppClass<UIBasicSprite>)+BA]");
						object obj91 = (nint)0 & (nint)0x200;
						bool flag10 = obj91 == null;
						nint num29 = (nint)typeof(UIBasicSprite);
						if (!flag10)
						{
							nint num30 = (nint)typeof(UIBasicSprite);
							num29 = (nint)typeof(UIBasicSprite);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1522 @ S0_v762 (Il2CppClass<UIBasicSprite>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								num29 = (nint)typeof(UIBasicSprite);
							}
						}
						object obj92 = UIBasicSprite.mTempUVs + 16;
						object obj93 = obj60 << 3;
						object obj94 = obj92 + obj93;
						((Vector2*)(nint)vector)->x = (float)obj4;
						float num31 = num19 + vector.y;
						float num32 = num31;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1281 @ S0_v654+4]");
						float num36;
						if (num32 > 0f)
						{
							((Vector2*)(nint)vector)->x = (float)obj4;
							nint num33 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1609 @ S0_v752 (Il2CppClass<UnityEngine.Mathf>)+BA]");
							object obj95 = (nint)0 & (nint)0x200;
							if (obj95 != null)
							{
								nint num34 = (nint)typeof(Mathf);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1810 @ S0_v759 (Il2CppClass<UnityEngine.Mathf>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1281 @ S0_v654+4]");
							float num35 = 0f - num19;
							num36 = num35 / vector.y;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ S0_v666+4]");
							nint num37 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1536 @ S0_v681+4]");
							float num38 = Mathf.LerpUnclamped(num37, 0f, num36);
							num21 = num38;
							num22 = vector.y;
							num29 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1281 @ S0_v654+4]");
							num31 = 0f;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1536 @ S0_v681+4]");
							num21 = 0f;
							num22 = num31;
							num36 = 3f;
						}
						num16 = (float)obj81;
						flag3 = (byte)(int)num36 != 0;
						flag6 = (byte)num29 != 0;
						while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num16) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj84))
						{
							((Vector2*)(nint)vector)->x = (float)obj4;
							float num39 = num16 + vector.x;
							nint num40 = (nint)typeof(UIBasicSprite);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2162 @ S0_v699 (Il2CppClass<UIBasicSprite>)+BA]");
							object obj96 = (nint)0 & (nint)0x200;
							if (obj96 != null)
							{
								nint num41 = (nint)typeof(UIBasicSprite);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2224 @ S0_v741 (Il2CppClass<UIBasicSprite>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							object obj97 = UIBasicSprite.mTempUVs + 16;
							object obj98 = obj56 << 3;
							object obj99 = obj97 + obj98;
							bool flag11 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num39) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj84);
							bool flag12 = !flag11;
							num20 = (float)obj99;
							num22 = num39;
							if (!flag12)
							{
								((Vector2*)(nint)vector)->x = (float)obj4;
								nint num42 = (nint)typeof(Mathf);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2276 @ S0_v732 (Il2CppClass<UnityEngine.Mathf>)+BA]");
								object obj100 = (nint)0 & (nint)0x200;
								if (obj100 != null)
								{
									nint num43 = (nint)typeof(Mathf);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2339 @ S0_v738 (Il2CppClass<UnityEngine.Mathf>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								float num44 = (float)obj84 - num16;
								float t = num44 / vector.x;
								float num45 = Mathf.LerpUnclamped((float)obj89, (float)obj99, t);
								num20 = num45;
								num22 = (float)obj84;
							}
							obj6 = uIDrawCall;
							_ = ((UnityEngine.Object)uIDrawCall).m_CachedPtr;
							nint num46 = (nint)typeof(UIBasicSprite);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2301 @ S0_v715 (Il2CppClass<UIBasicSprite>)+BA]");
							object obj101 = (nint)0 & (nint)0x200;
							if (obj101 != null)
							{
								bool flag13 = (byte)(int)typeof(UIBasicSprite) != 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2348 @ S0_v725 (System.Boolean)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							((Vector2*)(nint)vector)->x = (float)obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v29+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9AFB");
							((Vector2*)(nint)vector)->x = (float)obj4;
							float num47 = num16 + vector.x;
							num16 = num47;
							flag3 = (byte)(int)trans != 0;
							flag6 = (byte)(int)typeof(UIBasicSprite) != 0;
						}
						((Vector2*)(nint)vector)->x = (float)obj4;
						float num48 = num19 + vector.y;
						num19 = num48;
						num23 = num31;
					}
					continue;
				}
				if (flag)
				{
					if (obj57 != null)
					{
						if ((nint)obj57 == 1 || (nint)obj57 != 2)
						{
							flag6 = flag2;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+188]");
						if ((nint)0 != 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+188]");
							bool flag14 = (nint)0 == 0;
							flag6 = flag2;
							if (flag14)
							{
								continue;
							}
							goto IL_0c0e;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+184]");
						if ((nint)0 != 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+184]");
							bool flag15 = (nint)0 == 0;
							flag6 = flag2;
							if (flag15)
							{
								continue;
							}
							goto IL_0c0e;
						}
					}
					nint num49 = (nint)typeof(UIBasicSprite);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1420 @ S0_v434 (Il2CppClass<UIBasicSprite>)+BA]");
					object obj102 = (nint)0 & (nint)0x200;
					bool flag16 = obj102 == null;
					nint num50 = (nint)typeof(UIBasicSprite);
					if (!flag16)
					{
						nint num51 = (nint)typeof(UIBasicSprite);
						num50 = (nint)typeof(UIBasicSprite);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1437 @ S0_v539 (Il2CppClass<UIBasicSprite>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							num50 = (nint)typeof(UIBasicSprite);
						}
					}
					object obj103 = UIBasicSprite.mTempPos + 24;
					object obj104 = UIBasicSprite.mTempPos + 16;
					object obj105 = obj56 << 3;
					object obj106 = obj104 + obj105;
					object obj107 = UIBasicSprite.mTempPos + 16;
					object obj108 = obj57 << 3;
					object obj109 = obj107 + obj108;
					object obj110 = UIBasicSprite.mTempPos + 16;
					object obj111 = obj60 << 3;
					object obj112 = obj110 + obj111;
					object obj113 = UIBasicSprite.mTempUVs + 24;
					object obj114 = UIBasicSprite.mTempUVs + 16;
					object obj115 = obj57 << 3;
					object obj116 = obj114 + obj115;
					object obj117 = UIBasicSprite.mTempUVs + 16;
					object obj118 = obj60 << 3;
					object obj119 = obj117 + obj118;
					num22 = (float)obj103;
					flag3 = true;
					flag6 = (byte)num50 != 0;
					while (true)
					{
						bool flag17 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num22) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj106);
						bool flag18 = !flag17;
						num19 = (float)obj106;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1499 @ S0_v475+4]");
						num20 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1481 @ S0_v462+4]");
						num21 = 0f;
						if (flag18)
						{
							break;
						}
						((Vector2*)(nint)vector)->x = (float)obj4;
						float num52 = num22 + vector.x;
						nint num53 = (nint)typeof(UIBasicSprite);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1718 @ S0_v492 (Il2CppClass<UIBasicSprite>)+BA]");
						object obj120 = (nint)0 & (nint)0x200;
						if (obj120 != null)
						{
							nint num54 = (nint)typeof(UIBasicSprite);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1835 @ S0_v534 (Il2CppClass<UIBasicSprite>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						object obj121 = UIBasicSprite.mTempUVs + 16;
						object obj122 = obj56 << 3;
						object obj123 = obj121 + obj122;
						bool flag19 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num52) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj106);
						bool flag20 = !flag19;
						num16 = (float)obj123;
						num23 = num52;
						if (!flag20)
						{
							((Vector2*)(nint)vector)->x = (float)obj4;
							nint num55 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2025 @ S0_v525 (Il2CppClass<UnityEngine.Mathf>)+BA]");
							object obj124 = (nint)0 & (nint)0x200;
							if (obj124 != null)
							{
								nint num56 = (nint)typeof(Mathf);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2174 @ S0_v531 (Il2CppClass<UnityEngine.Mathf>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							float num57 = (float)obj106 - num22;
							float t2 = num57 / vector.x;
							float num58 = Mathf.LerpUnclamped((float)obj113, (float)obj123, t2);
							num16 = num58;
							num23 = (float)obj106;
						}
						obj6 = uIDrawCall;
						_ = ((UnityEngine.Object)uIDrawCall).m_CachedPtr;
						nint num59 = (nint)typeof(UIBasicSprite);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2050 @ S0_v508 (Il2CppClass<UIBasicSprite>)+BA]");
						object obj125 = (nint)0 & (nint)0x200;
						if (obj125 != null)
						{
							bool flag21 = (byte)(int)typeof(UIBasicSprite) != 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2183 @ S0_v518 (System.Boolean)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						((Vector2*)(nint)vector)->x = (float)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v29+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9AFB");
						((Vector2*)(nint)vector)->x = (float)obj4;
						float num60 = num22 + vector.x;
						num22 = num60;
						flag3 = (byte)(int)trans != 0;
						flag6 = (byte)(int)typeof(UIBasicSprite) != 0;
					}
					continue;
				}
				if (obj57 != null)
				{
					if ((nint)obj57 == 1)
					{
						if (obj55 != null)
						{
							if ((nint)obj55 == 1 || (nint)obj55 != 2)
							{
								flag6 = flag2;
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+180]");
							if ((nint)0 != 2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+180]");
								bool flag22 = (nint)0 == 0;
								flag6 = flag2;
								if (flag22)
								{
									continue;
								}
								goto IL_0fe9;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+17C]");
							if ((nint)0 != 2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+17C]");
								bool flag23 = (nint)0 == 0;
								flag6 = flag2;
								if (flag23)
								{
									continue;
								}
								goto IL_0fe9;
							}
						}
						nint num61 = (nint)typeof(UIBasicSprite);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1592 @ S0_v237 (Il2CppClass<UIBasicSprite>)+BA]");
						object obj126 = (nint)0 & (nint)0x200;
						bool flag24 = obj126 == null;
						nint num62 = (nint)typeof(UIBasicSprite);
						if (!flag24)
						{
							nint num63 = (nint)typeof(UIBasicSprite);
							num62 = (nint)typeof(UIBasicSprite);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1726 @ S0_v344 (Il2CppClass<UIBasicSprite>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								num62 = (nint)typeof(UIBasicSprite);
							}
						}
						object obj127 = UIBasicSprite.mTempPos + 16;
						object obj128 = obj55 << 3;
						object obj129 = obj127 + obj128;
						object obj130 = UIBasicSprite.mTempPos + 16;
						object obj131 = obj56 << 3;
						object obj132 = obj130 + obj131;
						object obj133 = UIBasicSprite.mTempPos + 24;
						object obj134 = UIBasicSprite.mTempPos + 16;
						object obj135 = obj60 << 3;
						object obj136 = obj134 + obj135;
						object obj137 = UIBasicSprite.mTempUVs + 16;
						object obj138 = obj55 << 3;
						object obj139 = obj137 + obj138;
						object obj140 = UIBasicSprite.mTempUVs + 16;
						object obj141 = obj56 << 3;
						object obj142 = obj140 + obj141;
						object obj143 = UIBasicSprite.mTempUVs + 24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1758 @ S0_v258+4]");
						num22 = 0f;
						flag3 = true;
						flag6 = (byte)num62 != 0;
						while (true)
						{
							float num64 = num22;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1770 @ S0_v265+4]");
							bool flag25 = num64 < 0f;
							bool flag26 = !flag25;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1770 @ S0_v265+4]");
							num19 = 0f;
							num20 = (float)obj132;
							num21 = (float)obj129;
							if (flag26)
							{
								break;
							}
							nint num65 = (nint)typeof(UIBasicSprite);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2146 @ S0_v292 (Il2CppClass<UIBasicSprite>)+BA]");
							object obj144 = (nint)0 & (nint)0x200;
							if (obj144 != null)
							{
								nint num66 = (nint)typeof(UIBasicSprite);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2196 @ S0_v339 (Il2CppClass<UIBasicSprite>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							object obj145 = UIBasicSprite.mTempUVs + 16;
							object obj146 = obj60 << 3;
							object obj147 = obj145 + obj146;
							((Vector2*)(nint)vector)->x = (float)obj4;
							float num67 = num22 + vector.y;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1770 @ S0_v265+4]");
							float num73;
							if (num67 > 0f)
							{
								((Vector2*)(nint)vector)->x = (float)obj4;
								nint num68 = (nint)typeof(Mathf);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2259 @ S0_v329 (Il2CppClass<UnityEngine.Mathf>)+BA]");
								object obj148 = (nint)0 & (nint)0x200;
								if (obj148 != null)
								{
									nint num69 = (nint)typeof(Mathf);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2306 @ S0_v336 (Il2CppClass<UnityEngine.Mathf>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1770 @ S0_v265+4]");
								float num70 = 0f - num22;
								float t3 = num70 / vector.y;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1799 @ S0_v285+4]");
								nint num71 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2210 @ S0_v300+4]");
								float num72 = Mathf.LerpUnclamped(num71, 0f, t3);
								num16 = num72;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1770 @ S0_v265+4]");
								num73 = 0f;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2210 @ S0_v300+4]");
								num16 = 0f;
								num73 = num67;
							}
							obj6 = uIDrawCall;
							_ = ((UnityEngine.Object)uIDrawCall).m_CachedPtr;
							nint num74 = (nint)typeof(UIBasicSprite);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2334 @ S0_v310 (Il2CppClass<UIBasicSprite>)+BA]");
							object obj149 = (nint)0 & (nint)0x200;
							if (obj149 != null)
							{
								bool flag27 = (byte)(int)typeof(UIBasicSprite) != 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2360 @ S0_v320 (System.Boolean)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							((Vector2*)(nint)vector)->x = (float)obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v29+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9AFB");
							((Vector2*)(nint)vector)->x = (float)obj4;
							float num75 = num22 + vector.y;
							num22 = num75;
							num23 = num73;
							flag3 = (byte)(int)trans != 0;
							flag6 = (byte)(int)typeof(UIBasicSprite) != 0;
						}
						continue;
					}
					if ((nint)obj57 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+188]");
						bool flag28 = (nint)0 == 0;
						flag6 = flag2;
						if (flag28)
						{
							continue;
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+184]");
					bool flag29 = (nint)0 == 0;
					flag6 = flag2;
					if (flag29)
					{
						continue;
					}
				}
				if (obj55 != null)
				{
					if ((nint)obj55 != 1 && (nint)obj55 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+180]");
						bool flag30 = (nint)0 == 0;
						flag6 = flag2;
						if (flag30)
						{
							continue;
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+17C]");
					bool flag31 = (nint)0 == 0;
					flag6 = flag2;
					if (flag31)
					{
						continue;
					}
				}
				nint num76 = (nint)typeof(UIBasicSprite);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1804 @ S0_v161 (Il2CppClass<UIBasicSprite>)+BA]");
				object obj150 = (nint)0 & (nint)0x200;
				bool flag32 = obj150 == null;
				flag6 = (byte)(int)typeof(UIBasicSprite) != 0;
				if (!flag32)
				{
					nint num77 = (nint)typeof(UIBasicSprite);
					flag6 = (byte)(int)typeof(UIBasicSprite) != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1893 @ S0_v223 (Il2CppClass<UIBasicSprite>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						flag6 = (byte)(int)typeof(UIBasicSprite) != 0;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ L4_v9 (System.Boolean)+5C]");
				object obj151 = 0;
				object obj152 = obj151 + 16;
				object obj153 = obj55 << 3;
				object obj154 = obj152 + obj153;
				object obj155 = UIBasicSprite.mTempPos + 16;
				object obj156 = obj56 << 3;
				object obj157 = obj155 + obj156;
				object obj158 = UIBasicSprite.mTempPos + 16;
				object obj159 = obj57 << 3;
				object obj160 = obj158 + obj159;
				object obj161 = UIBasicSprite.mTempPos + 16;
				object obj162 = obj60 << 3;
				object obj163 = obj161 + obj162;
				object obj164 = UIBasicSprite.mTempUVs + 16;
				object obj165 = obj55 << 3;
				object obj166 = obj164 + obj165;
				object obj167 = UIBasicSprite.mTempUVs + 16;
				object obj168 = obj56 << 3;
				object obj169 = obj167 + obj168;
				object obj170 = UIBasicSprite.mTempUVs + 16;
				object obj171 = obj57 << 3;
				object obj172 = obj170 + obj171;
				object obj173 = UIBasicSprite.mTempUVs + 16;
				object obj174 = obj60 << 3;
				object obj175 = obj173 + obj174;
				((Vector2*)(nint)vector)->x = (float)uIDrawCall;
				_ = ((UnityEngine.Object)uIDrawCall).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9AFB");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1928 @ S0_v183+4]");
				num19 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1983 @ S0_v218+4]");
				num20 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1972 @ S0_v211+4]");
				num21 = 0f;
				num22 = (float)obj157;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1939 @ S0_v190+4]");
				num16 = 0f;
				num23 = (float)obj154;
				flag3 = (byte)(int)trans != 0;
				continue;
				IL_0c0e:
				nint num78 = (nint)typeof(UIBasicSprite);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1556 @ S0_v546 (Il2CppClass<UIBasicSprite>)+BA]");
				object obj176 = (nint)0 & (nint)0x200;
				bool flag33 = obj176 == null;
				flag6 = (byte)(int)typeof(UIBasicSprite) != 0;
				if (!flag33)
				{
					nint num79 = (nint)typeof(UIBasicSprite);
					flag6 = (byte)(int)typeof(UIBasicSprite) != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1618 @ S0_v606 (Il2CppClass<UIBasicSprite>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						flag6 = (byte)(int)typeof(UIBasicSprite) != 0;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ L4_v9 (System.Boolean)+5C]");
				object obj177 = 0;
				object obj178 = obj177 + 24;
				object obj179 = UIBasicSprite.mTempPos + 16;
				object obj180 = obj56 << 3;
				object obj181 = obj179 + obj180;
				object obj182 = UIBasicSprite.mTempPos + 16;
				object obj183 = obj57 << 3;
				object obj184 = obj182 + obj183;
				object obj185 = UIBasicSprite.mTempPos + 16;
				object obj186 = obj60 << 3;
				object obj187 = obj185 + obj186;
				object obj188 = UIBasicSprite.mTempUVs + 24;
				object obj189 = UIBasicSprite.mTempUVs + 16;
				object obj190 = obj56 << 3;
				object obj191 = obj189 + obj190;
				object obj192 = UIBasicSprite.mTempUVs + 16;
				object obj193 = obj57 << 3;
				object obj194 = obj192 + obj193;
				object obj195 = UIBasicSprite.mTempUVs + 16;
				object obj196 = obj60 << 3;
				object obj197 = obj195 + obj196;
				((Vector2*)(nint)vector)->x = (float)uIDrawCall;
				_ = ((UnityEngine.Object)uIDrawCall).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9AFB");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1649 @ S0_v567+4]");
				num19 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1700 @ S0_v601+4]");
				num20 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1689 @ S0_v594+4]");
				num21 = 0f;
				num22 = (float)obj181;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1660 @ S0_v574+4]");
				num16 = 0f;
				num23 = (float)obj178;
				flag3 = (byte)(int)trans != 0;
				continue;
				IL_0fe9:
				nint num80 = (nint)typeof(UIBasicSprite);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1862 @ S0_v351 (Il2CppClass<UIBasicSprite>)+BA]");
				object obj198 = (nint)0 & (nint)0x200;
				bool flag34 = obj198 == null;
				flag6 = (byte)(int)typeof(UIBasicSprite) != 0;
				if (!flag34)
				{
					nint num81 = (nint)typeof(UIBasicSprite);
					flag6 = (byte)(int)typeof(UIBasicSprite) != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2054 @ S0_v411 (Il2CppClass<UIBasicSprite>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						flag6 = (byte)(int)typeof(UIBasicSprite) != 0;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ L4_v9 (System.Boolean)+5C]");
				object obj199 = 0;
				object obj200 = obj199 + 16;
				object obj201 = obj55 << 3;
				object obj202 = obj200 + obj201;
				object obj203 = UIBasicSprite.mTempPos + 16;
				object obj204 = obj56 << 3;
				object obj205 = obj203 + obj204;
				object obj206 = UIBasicSprite.mTempPos + 24;
				object obj207 = UIBasicSprite.mTempPos + 16;
				object obj208 = obj60 << 3;
				object obj209 = obj207 + obj208;
				object obj210 = UIBasicSprite.mTempUVs + 16;
				object obj211 = obj55 << 3;
				object obj212 = obj210 + obj211;
				object obj213 = UIBasicSprite.mTempUVs + 16;
				object obj214 = obj56 << 3;
				object obj215 = obj213 + obj214;
				object obj216 = UIBasicSprite.mTempUVs + 24;
				object obj217 = UIBasicSprite.mTempUVs + 16;
				object obj218 = obj60 << 3;
				object obj219 = obj217 + obj218;
				((Vector2*)(nint)vector)->x = (float)uIDrawCall;
				_ = ((UnityEngine.Object)uIDrawCall).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9AFB");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2085 @ S0_v372+4]");
				num19 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2136 @ S0_v406+4]");
				num20 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2125 @ S0_v399+4]");
				num21 = 0f;
				num22 = (float)obj205;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2096 @ S0_v379+4]");
				num16 = 0f;
				num23 = (float)obj202;
				flag3 = (byte)(int)trans != 0;
			}
			object obj221 = obj55 + 1;
			obj55 = obj221;
		}
		goto IL_1604;
		IL_1604:
		return vector2;
		IL_2de8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+130]");
		if ((nint)0 != 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+130]");
			if ((nint)0 != 3)
			{
				nint num82 = (nint)typeof(UIBasicSprite);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ S0_v884 (Il2CppClass<UIBasicSprite>)+BA]");
				object obj222 = (nint)0 & (nint)0x200;
				if (obj222 != null)
				{
					nint num83 = (nint)typeof(UIBasicSprite);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v805 @ S0_v917 (Il2CppClass<UIBasicSprite>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj223 = UIBasicSprite.mTempPos + 16;
				((Vector2*)(nint)vector)->x = (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				object obj224 = UIBasicSprite.mTempPos + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ S1_v427+4]");
				float num84 = 0f + vector.y;
				object obj225 = UIBasicSprite.mTempPos + 40;
				obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				object obj226 = UIBasicSprite.mTempPos + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ S1_v438+4]");
				float num85 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v29+C]");
				float num86 = num85 - 0f;
				object obj227 = UIBasicSprite.mTempUVs + 16;
				object obj228 = vector2 + 360;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ S1_v447+4]");
				_ = 0;
				object obj229 = UIBasicSprite.mTempUVs + 24;
				object obj230 = vector2 + 344;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v879 @ S1_v451+4]");
				_ = 0;
				object obj231 = UIBasicSprite.mTempUVs + 32;
				object obj232 = vector2 + 344;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ S1_v455+C]");
				nint num87 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ S1_v455+4]");
				object obj233 = num87 + 0;
				object obj234 = UIBasicSprite.mTempUVs + 40;
				bool flag35 = (byte)(int)(vector2 + 360) != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ S1_v460 (System.Boolean)+4]");
				flag3 = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ S1_v460 (System.Boolean)+C]");
				nint num88 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ S1_v460 (System.Boolean)+4]");
				object obj235 = num88 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ S1_v438+4]");
				num23 = 0f;
				flag6 = flag35;
				goto IL_2e0d;
			}
		}
		nint num89 = (nint)typeof(UIBasicSprite);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ S0_v841 (Il2CppClass<UIBasicSprite>)+BA]");
		object obj236 = (nint)0 & (nint)0x200;
		if (obj236 != null)
		{
			nint num90 = (nint)typeof(UIBasicSprite);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ S0_v874 (Il2CppClass<UIBasicSprite>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj237 = UIBasicSprite.mTempPos + 16;
		((Vector2*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj238 = UIBasicSprite.mTempPos + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ S1_v385+4]");
		nint num91 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (UnityEngine.Vector2)+C]");
		object obj239 = num91 + 0;
		object obj240 = UIBasicSprite.mTempPos + 40;
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj241 = UIBasicSprite.mTempPos + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ S1_v396+4]");
		float num92 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v29+4]");
		float num93 = num92 - 0f;
		object obj242 = UIBasicSprite.mTempUVs + 40;
		object obj243 = vector2 + 360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ S1_v405+4]");
		_ = 0;
		object obj244 = UIBasicSprite.mTempUVs + 32;
		object obj245 = vector2 + 344;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ S1_v409+4]");
		_ = 0;
		object obj246 = UIBasicSprite.mTempUVs + 24;
		object obj247 = vector2 + 344;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ S1_v413+C]");
		nint num94 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ S1_v413+4]");
		object obj248 = num94 + 0;
		object obj249 = UIBasicSprite.mTempUVs + 16;
		bool flag36 = (byte)(int)(vector2 + 360) != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ S1_v418 (System.Boolean)+4]");
		flag3 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ S1_v418 (System.Boolean)+C]");
		nint num95 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ S1_v418 (System.Boolean)+4]");
		object obj250 = num95 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ S1_v396+4]");
		num23 = 0f;
		flag6 = flag36;
		goto IL_2e0d;
	}

	protected virtual void OnEnable()
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Vector3> list = default;
		list._002Ector();
		object obj = this + 8;
		obj = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Vector2> list2 = default;
		list2._002Ector();
		object obj2 = this + 12;
		obj2 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Color> list3 = default;
		list3._002Ector();
		object obj3 = this + 16;
		obj3 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Vector3> list4 = default;
		list4._002Ector();
		object obj4 = this + 24;
		obj4 = list4;
	}

	protected virtual void OnInit()
	{
		mUpdateFrame = -1;
		if (updateAnchors == AnchorUpdate.OnEnable)
		{
			mAnchorsCached = false;
			mUpdateAnchors = true;
		}
		if (~(mStarted ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
		mUpdateFrame = -1;
	}

	protected virtual void OnDisable()
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0090: Expected Obj, but got I4
		//IL_00b3: Expected I, but got Obj
		//IL_00c9: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		mChanged = true;
		object obj = this - -64;
		obj = 0;
		mParentFound = false;
		UIRoot uIRoot = root;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)uIRoot).FindKernel((string)null) != 0)
		{
			UIRect uIRect = mParent;
			uIRect.mChildren.Add(this);
		}
	}

	protected virtual void Awake()
	{
		//IL_00ca: Expected I, but got Obj
		//IL_00e0: Expected Obj, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_0088: Expected Obj, but got I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_009c: Expected Obj, but got I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00b0: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)mParent))
		{
			UIRect uIRect = mParent;
			bool flag = uIRect.mChildren.Remove(this);
		}
		object obj2 = this + 60;
		obj2 = 0;
		object obj3 = this + 56;
		obj3 = 0;
		object obj4 = this - -64;
		obj4 = 0;
		mParentFound = false;
	}

	protected void Start()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		mStarted = false;
		object obj = this + 32;
		string text = tag;
		obj = text;
		object obj2 = this + 36;
		GameObject gameObject = base.gameObject;
		obj2 = gameObject;
	}

	public void Update()
	{
		mStarted = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	protected void UpdateAnchorsInternal(int frame)
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		mChanged = true;
		if (frame == 0)
		{
			return;
		}
		object obj = default;
		object obj4 = default;
		while (true)
		{
			BetterList<UIRect> betterList = mChildren;
			if ((nint)obj < betterList.size)
			{
				BetterList<UIRect> betterList2 = mChildren;
				object obj2 = betterList2.buffer + 16;
				object obj3 = obj4 << 2;
				object obj5 = obj2 + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
				obj = obj4 + 1;
				continue;
			}
			break;
		}
	}

	public void UpdateAnchors()
	{
		//IL_0127: Expected I, but got Obj
		//IL_013d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)mCam))
		{
			if (~(mAnchorsCached ? 1u : 0u) != 0)
			{
				ResetAndUpdateAnchors();
			}
		}
		else
		{
			ParentHasChanged();
		}
		int renderedFrameCount = Time.renderedFrameCount;
		if (mUpdateFrame != renderedFrameCount)
		{
			if (updateAnchors == AnchorUpdate.OnUpdate || mUpdateAnchors)
			{
				SetAnchor((Transform)renderedFrameCount);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	protected abstract void OnAnchor();

	public void SetAnchor(Transform t)
	{
		//IL_0552: Expected I4, but got Obj
		//IL_0575: Expected I, but got Obj
		//IL_058b: Expected Obj, but got I
		//IL_0156: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_079e: Expected I, but got Obj
		//IL_07b4: Expected Obj, but got I
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0631: Expected I, but got Obj
		//IL_0647: Expected Obj, but got I
		//IL_0169: Expected I, but got Obj
		//IL_05e1: Expected Obj, but got I4
		//IL_00ab: Expected I, but got Obj
		//IL_01c0: Expected I, but got Obj
		//IL_01d6: Expected Obj, but got I
		//IL_06ba: Expected I, but got Obj
		//IL_06d0: Expected Obj, but got I
		//IL_02b1: Expected I, but got Obj
		//IL_0308: Expected I, but got Obj
		//IL_031e: Expected Obj, but got I
		//IL_069d: Expected Obj, but got I4
		//IL_0201: Expected I, but got Obj
		//IL_03f9: Expected I, but got Obj
		//IL_0450: Expected I, but got Obj
		//IL_0466: Expected Obj, but got I
		//IL_0726: Expected Obj, but got I4
		//IL_0349: Expected I, but got Obj
		//IL_0491: Expected I, but got Obj
		mUpdateFrame = (int)t;
		mUpdateAnchors = false;
		AnchorPoint anchorPoint = leftAnchor;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v89 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3;
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint.target))
		{
			AnchorPoint anchorPoint2 = leftAnchor;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v77 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v85 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)anchorPoint2.rect).FindKernel((string)null) != 0)
			{
				AnchorPoint anchorPoint3 = leftAnchor;
				UIRect rect = anchorPoint3.rect;
				if (rect.mUpdateFrame != (nint)t)
				{
					AnchorPoint anchorPoint4 = leftAnchor;
					anchorPoint4.rect.UpdateAnchors();
				}
			}
			obj3 = 1;
		}
		else
		{
			obj3 = 0;
		}
		AnchorPoint anchorPoint5 = bottomAnchor;
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v72 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint5.target);
		bool flag2 = !flag;
		object obj5 = obj3;
		if (!flag2)
		{
			AnchorPoint anchorPoint6 = bottomAnchor;
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v60 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v68 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)anchorPoint6.rect).FindKernel((string)null) != 0)
			{
				AnchorPoint anchorPoint7 = bottomAnchor;
				UIRect rect2 = anchorPoint7.rect;
				if (rect2.mUpdateFrame != (nint)t)
				{
					AnchorPoint anchorPoint8 = bottomAnchor;
					anchorPoint8.rect.UpdateAnchors();
				}
			}
			obj5 = 1;
		}
		AnchorPoint anchorPoint9 = rightAnchor;
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S1_v55 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint9.target))
		{
			AnchorPoint anchorPoint10 = rightAnchor;
			nint num11 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S1_v43 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num12 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S1_v51 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)anchorPoint10.rect).FindKernel((string)null) != 0)
			{
				AnchorPoint anchorPoint11 = rightAnchor;
				UIRect rect3 = anchorPoint11.rect;
				if (rect3.mUpdateFrame != (nint)t)
				{
					AnchorPoint anchorPoint12 = rightAnchor;
					anchorPoint12.rect.UpdateAnchors();
				}
			}
			obj5 = 1;
		}
		AnchorPoint anchorPoint13 = topAnchor;
		nint num13 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v26 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num14 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S0_v49 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint13.target))
		{
			AnchorPoint anchorPoint14 = topAnchor;
			nint num15 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num16 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S1_v38 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)anchorPoint14.rect).FindKernel((string)null) != 0)
			{
				AnchorPoint anchorPoint15 = topAnchor;
				UIRect rect4 = anchorPoint15.rect;
				if (rect4.mUpdateFrame != (nint)t)
				{
					AnchorPoint anchorPoint16 = topAnchor;
					anchorPoint16.rect.UpdateAnchors();
				}
			}
		}
		else if (obj5 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	public void SetAnchor(GameObject go)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		object obj = leftAnchor + 8;
		obj = go;
		object obj2 = rightAnchor + 8;
		obj2 = go;
		object obj3 = topAnchor + 8;
		obj3 = go;
		object obj4 = bottomAnchor + 8;
		obj4 = go;
		ResetAndUpdateAnchors();
		ResetAnchors();
	}

	public unsafe void SetAnchor(GameObject go, int left, int bottom, int right, int top)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0047: Expected Obj, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_0143: Expected Obj, but got I4
		//IL_0143: Expected Obj, but got I4
		//IL_015a: Expected Obj, but got I4
		//IL_015a: Expected Obj, but got I4
		//IL_0171: Expected Obj, but got I4
		//IL_0171: Expected Obj, but got I4
		//IL_0188: Expected Obj, but got I4
		//IL_0188: Expected Obj, but got I4
		//IL_019e: Expected Obj, but got I4
		//IL_019e: Expected Obj, but got I4
		//IL_01b9: Expected Obj, but got I4
		//IL_01b9: Expected Obj, but got I4
		object obj = ((int*)right)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [right @ L4 (System.Int32)+8]");
		_ = 0;
		object obj2 = this + 360;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		obj = ((int*)top)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [top @ L5 (System.Int32)+8]");
		_ = 0;
		object obj3 = this + 344;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj4 = default;
		if (obj4 != null)
		{
			if ((nint)obj4 != 1)
			{
				if ((nint)obj4 != 2)
				{
					if ((nint)obj4 != 3)
					{
						if ((nint)obj4 != 4)
						{
							if ((nint)obj4 == 5)
							{
								((UIBasicSprite)this).AdvancedFill((List<Vector3>)(object)go, (List<Vector2>)left, (List<Color>)bottom);
							}
						}
						else
						{
							Vector3 localPos = ((UIRect)(object)go).GetLocalPos((AnchorPoint)left, (Transform)bottom);
						}
					}
					else
					{
						((UIBasicSprite)this).FilledSlicedFill((List<Vector3>)(object)go, (List<Vector2>)left, (List<Color>)bottom);
					}
				}
				else
				{
					((UIBasicSprite)this).FilledFill((List<Vector3>)(object)go, (List<Vector2>)left, (List<Color>)bottom);
				}
			}
			else
			{
				((UIBasicSprite)this).TiledFill((List<Vector3>)(object)go, (List<Vector2>)left, (List<Color>)bottom);
			}
		}
		else
		{
			((UIBasicSprite)this).SlicedFill((List<Vector3>)(object)go, (List<Vector2>)left, (List<Color>)bottom);
		}
	}

	public void SetAnchor(GameObject go, float left, float bottom, float right, float top)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public void SetAnchor(GameObject go, float left, int leftOffset, float bottom, int bottomOffset, float right, int rightOffset, float top, int topOffset)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public void SetAnchor(float left, int leftOffset, float bottom, int bottomOffset, float right, int rightOffset, float top, int topOffset)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public unsafe void SetScreenRect(int left, int top, int width, int height)
	{
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_0845: Expected Obj, but got Unknown
		//IL_084e: Expected Obj, but got I4
		//IL_085d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Expected VT, but got Unknown
		//IL_0884: Expected I, but got Obj
		//IL_089a: Expected Obj, but got I
		//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c5: Expected Obj, but got Unknown
		//IL_08ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d3: Expected Obj, but got Unknown
		//IL_08dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e1: Expected VT, but got Unknown
		//IL_08ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ef: Expected VT, but got Unknown
		//IL_08fc: Expected native int or pointer, but got VT
		//IL_090e: Expected native int or pointer, but got VT
		//IL_091c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0921: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_06b9: Expected Obj, but got I4
		//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Expected Obj, but got Unknown
		//IL_06f3: Expected F4, but got Obj
		//IL_06ee: Expected native int or pointer, but got VT
		//IL_0708: Expected F4, but got I
		//IL_0703: Expected native int or pointer, but got VT
		//IL_0715: Expected F4, but got Obj
		//IL_0710: Expected native int or pointer, but got VT
		//IL_072a: Expected F4, but got I
		//IL_0725: Expected native int or pointer, but got VT
		//IL_0748: Expected F4, but got Obj
		//IL_0743: Expected native int or pointer, but got VT
		//IL_075d: Expected F4, but got I
		//IL_0758: Expected native int or pointer, but got VT
		//IL_076a: Expected Obj, but got I4
		//IL_005f: Expected F4, but got Obj
		//IL_005a: Expected native int or pointer, but got VT
		//IL_0074: Expected F4, but got I
		//IL_006f: Expected native int or pointer, but got VT
		//IL_01ec: Expected Obj, but got I4
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected Obj, but got Unknown
		//IL_0226: Expected F4, but got Obj
		//IL_0221: Expected native int or pointer, but got VT
		//IL_023b: Expected F4, but got I
		//IL_0236: Expected native int or pointer, but got VT
		//IL_0248: Expected F4, but got Obj
		//IL_0243: Expected native int or pointer, but got VT
		//IL_025d: Expected F4, but got I
		//IL_0258: Expected native int or pointer, but got VT
		//IL_027b: Expected F4, but got Obj
		//IL_0276: Expected native int or pointer, but got VT
		//IL_0290: Expected F4, but got I
		//IL_028b: Expected native int or pointer, but got VT
		//IL_029d: Expected Obj, but got I4
		//IL_00ae: Expected F4, but got Obj
		//IL_00a9: Expected native int or pointer, but got VT
		//IL_00c3: Expected F4, but got I
		//IL_00be: Expected native int or pointer, but got VT
		//IL_0781: Expected Obj, but got I4
		//IL_0794: Unknown result type (might be due to invalid IL or missing references)
		//IL_0799: Expected Obj, but got Unknown
		//IL_07bb: Expected F4, but got Obj
		//IL_07b6: Expected native int or pointer, but got VT
		//IL_07d0: Expected F4, but got I
		//IL_07cb: Expected native int or pointer, but got VT
		//IL_07dd: Expected F4, but got Obj
		//IL_07d8: Expected native int or pointer, but got VT
		//IL_07f2: Expected F4, but got I
		//IL_07ed: Expected native int or pointer, but got VT
		//IL_0810: Expected F4, but got Obj
		//IL_080b: Expected native int or pointer, but got VT
		//IL_0825: Expected F4, but got I
		//IL_0820: Expected native int or pointer, but got VT
		//IL_0832: Expected Obj, but got I4
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected Obj, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected Obj, but got Unknown
		//IL_0328: Expected F4, but got Obj
		//IL_0323: Expected native int or pointer, but got VT
		//IL_033d: Expected F4, but got I
		//IL_0338: Expected native int or pointer, but got VT
		//IL_034a: Expected F4, but got Obj
		//IL_0345: Expected native int or pointer, but got VT
		//IL_035f: Expected F4, but got I
		//IL_035a: Expected native int or pointer, but got VT
		//IL_0374: Expected I4, but got VT
		//IL_0374: Expected I4, but got VT
		//IL_0374: Expected Ref, but got VT
		//IL_0386: Expected F4, but got I4
		//IL_0381: Expected native int or pointer, but got VT
		//IL_039b: Expected F4, but got I
		//IL_0396: Expected native int or pointer, but got VT
		//IL_03a8: Expected native int or pointer, but got VT
		//IL_03ba: Expected native int or pointer, but got VT
		//IL_00fd: Expected F4, but got Obj
		//IL_00f8: Expected native int or pointer, but got VT
		//IL_0112: Expected F4, but got I
		//IL_010d: Expected native int or pointer, but got VT
		//IL_03e2: Expected F4, but got Obj
		//IL_03dd: Expected native int or pointer, but got VT
		//IL_03f7: Expected F4, but got I
		//IL_03f2: Expected native int or pointer, but got VT
		//IL_0404: Expected Obj, but got I4
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected Obj, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected Obj, but got Unknown
		//IL_048a: Expected F4, but got Obj
		//IL_0485: Expected native int or pointer, but got VT
		//IL_049f: Expected F4, but got I
		//IL_049a: Expected native int or pointer, but got VT
		//IL_04ac: Expected F4, but got Obj
		//IL_04a7: Expected native int or pointer, but got VT
		//IL_04c1: Expected F4, but got I
		//IL_04bc: Expected native int or pointer, but got VT
		//IL_04d6: Expected I4, but got VT
		//IL_04d6: Expected I4, but got VT
		//IL_04d6: Expected Ref, but got VT
		//IL_04e8: Expected F4, but got I4
		//IL_04e3: Expected native int or pointer, but got VT
		//IL_04fd: Expected F4, but got I
		//IL_04f8: Expected native int or pointer, but got VT
		//IL_050a: Expected native int or pointer, but got VT
		//IL_051c: Expected native int or pointer, but got VT
		//IL_014c: Expected F4, but got Obj
		//IL_0147: Expected native int or pointer, but got VT
		//IL_0161: Expected F4, but got I
		//IL_015c: Expected native int or pointer, but got VT
		//IL_0544: Expected F4, but got Obj
		//IL_053f: Expected native int or pointer, but got VT
		//IL_0559: Expected F4, but got I
		//IL_0554: Expected native int or pointer, but got VT
		//IL_0566: Expected Obj, but got I4
		//IL_0578: Expected Obj, but got I4
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected Obj, but got Unknown
		//IL_05b2: Expected F4, but got Obj
		//IL_05ad: Expected native int or pointer, but got VT
		//IL_05c7: Expected F4, but got I
		//IL_05c2: Expected native int or pointer, but got VT
		//IL_05d4: Expected F4, but got Obj
		//IL_05cf: Expected native int or pointer, but got VT
		//IL_05e9: Expected F4, but got I
		//IL_05e4: Expected native int or pointer, but got VT
		//IL_0607: Expected F4, but got Obj
		//IL_0602: Expected native int or pointer, but got VT
		//IL_061c: Expected F4, but got I
		//IL_0617: Expected native int or pointer, but got VT
		//IL_0629: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 80;
		obj = 0;
		_ = 0;
		Matrix4x4 matrix4x = (Matrix4x4)(obj2 + 96);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
		nint num = (nint)typeof(Vector4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v16 (Il2CppClass<UnityEngine.Vector4>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v167 (Il2CppClass<UnityEngine.Vector4>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 48;
		object obj5 = obj2 + 32;
		Matrix4x4 matrix4x2 = (Matrix4x4)(obj2 + 16);
		Matrix4x4 matrix4x3 = (Matrix4x4)(obj2 + 112);
		((Matrix4x4*)(nint)matrix4x3)->m00 = matrix4x.m00;
		((Matrix4x4*)(nint)matrix4x3)->m20 = matrix4x.m20;
		object obj6 = obj2 - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F51F");
		obj = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v30+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj7 = default;
		if (obj7 != null)
		{
			((Matrix4x4*)(nint)matrix4x3)->m00 = (float)obj;
			Matrix4x4 matrix4x4 = matrix4x3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Matrix4x4*)(nint)matrix4x4)->m20 = 0f;
			if (matrix4x3.m00 == 0f)
			{
				((Matrix4x4*)(nint)matrix4x3)->m00 = (float)obj;
				Matrix4x4 matrix4x5 = matrix4x3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((Matrix4x4*)(nint)matrix4x5)->m20 = 0f;
				if (matrix4x3.m10 == 0f)
				{
					((Matrix4x4*)(nint)matrix4x3)->m00 = (float)obj;
					Matrix4x4 matrix4x6 = matrix4x3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					((Matrix4x4*)(nint)matrix4x6)->m20 = 0f;
					if (matrix4x3.m20 == 0f)
					{
						((Matrix4x4*)(nint)matrix4x3)->m00 = (float)obj;
						Matrix4x4 matrix4x7 = matrix4x3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
						((Matrix4x4*)(nint)matrix4x7)->m20 = 0f;
						if (matrix4x3.m30 == 0f)
						{
							goto IL_0633;
						}
					}
				}
			}
			switch (height)
			{
			case 0:
			{
				obj6 = ((int*)top)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [top @ L2 (System.Int32)+8]");
				_ = 0;
				object obj13 = this + 328;
				obj4 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S1_v84+8]");
				_ = 0;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
				Matrix4x4 matrix4x22 = matrix4x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v30+8]");
				((Matrix4x4*)(nint)matrix4x22)->m20 = 0f;
				((Matrix4x4*)(nint)matrix4x3)->m00 = (float)obj4;
				Matrix4x4 matrix4x23 = matrix4x3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v21+8]");
				((Matrix4x4*)(nint)matrix4x23)->m20 = 0f;
				Matrix4x4 matrix4x24 = matrix4x * matrix4x3;
				((Matrix4x4*)(nint)matrix4x3)->m00 = (float)obj5;
				Matrix4x4 matrix4x25 = matrix4x3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v23+8]");
				((Matrix4x4*)(nint)matrix4x25)->m20 = 0f;
				((List<Color>)left).Add((Color)matrix4x3);
				break;
			}
			case 1:
			{
				object obj11 = this + 328;
				obj6 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S1_v103+8]");
				_ = 0;
				object obj12 = this + 312;
				obj4 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S1_v108+8]");
				_ = 0;
				obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v23+4]");
				float num4 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIRect)+68]");
				float value2 = num4 / 0f;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
				Matrix4x4 matrix4x17 = matrix4x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v30+8]");
				((Matrix4x4*)(nint)matrix4x17)->m20 = 0f;
				((Matrix4x4*)(nint)matrix4x3)->m00 = (float)obj4;
				Matrix4x4 matrix4x18 = matrix4x3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v21+8]");
				((Matrix4x4*)(nint)matrix4x18)->m20 = 0f;
				((Matrix4x4*)matrix4x2)->set_Item((int)matrix4x, (int)matrix4x3, value2);
				((Matrix4x4*)(nint)matrix4x)->m00 = ((int*)top)->m_value;
				Matrix4x4 matrix4x19 = matrix4x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [top @ L2 (System.Int32)+8]");
				((Matrix4x4*)(nint)matrix4x19)->m20 = 0f;
				((Matrix4x4*)(nint)matrix4x3)->m00 = matrix4x2.m00;
				((Matrix4x4*)(nint)matrix4x3)->m20 = matrix4x2.m20;
				Matrix4x4 matrix4x20 = matrix4x * matrix4x3;
				((Matrix4x4*)(nint)matrix4x3)->m00 = (float)obj2;
				Matrix4x4 matrix4x21 = matrix4x3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Matrix4x4*)(nint)matrix4x21)->m20 = 0f;
				((List<Color>)left).Add((Color)matrix4x3);
				break;
			}
			case 2:
			{
				object obj9 = this + 312;
				obj6 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ S1_v142+8]");
				_ = 0;
				object obj10 = this + 328;
				obj4 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ S1_v147+8]");
				_ = 0;
				obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v23+C]");
				float num3 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIRect)+68]");
				float value = num3 / 0f;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
				Matrix4x4 matrix4x12 = matrix4x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v30+8]");
				((Matrix4x4*)(nint)matrix4x12)->m20 = 0f;
				((Matrix4x4*)(nint)matrix4x3)->m00 = (float)obj4;
				Matrix4x4 matrix4x13 = matrix4x3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v21+8]");
				((Matrix4x4*)(nint)matrix4x13)->m20 = 0f;
				((Matrix4x4*)matrix4x2)->set_Item((int)matrix4x, (int)matrix4x3, value);
				((Matrix4x4*)(nint)matrix4x)->m00 = ((int*)top)->m_value;
				Matrix4x4 matrix4x14 = matrix4x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [top @ L2 (System.Int32)+8]");
				((Matrix4x4*)(nint)matrix4x14)->m20 = 0f;
				((Matrix4x4*)(nint)matrix4x3)->m00 = matrix4x2.m00;
				((Matrix4x4*)(nint)matrix4x3)->m20 = matrix4x2.m20;
				Matrix4x4 matrix4x15 = matrix4x * matrix4x3;
				((Matrix4x4*)(nint)matrix4x3)->m00 = (float)obj2;
				Matrix4x4 matrix4x16 = matrix4x3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Matrix4x4*)(nint)matrix4x16)->m20 = 0f;
				((List<Color>)left).Add((Color)matrix4x3);
				break;
			}
			case 3:
			{
				obj6 = ((int*)top)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [top @ L2 (System.Int32)+8]");
				_ = 0;
				object obj8 = this + 312;
				obj4 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ S1_v186+8]");
				_ = 0;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
				Matrix4x4 matrix4x8 = matrix4x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v30+8]");
				((Matrix4x4*)(nint)matrix4x8)->m20 = 0f;
				((Matrix4x4*)(nint)matrix4x3)->m00 = (float)obj4;
				Matrix4x4 matrix4x9 = matrix4x3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v21+8]");
				((Matrix4x4*)(nint)matrix4x9)->m20 = 0f;
				Matrix4x4 matrix4x10 = matrix4x * matrix4x3;
				((Matrix4x4*)(nint)matrix4x3)->m00 = (float)obj5;
				Matrix4x4 matrix4x11 = matrix4x3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v23+8]");
				((Matrix4x4*)(nint)matrix4x11)->m20 = 0f;
				((List<Color>)left).Add((Color)matrix4x3);
				break;
			}
			}
			return;
		}
		goto IL_0633;
		IL_0633:
		switch (height)
		{
		case 0:
		case 1:
		{
			obj6 = ((int*)top)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [top @ L2 (System.Int32)+8]");
			_ = 0;
			object obj15 = this + 328;
			obj4 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S1_v32+8]");
			_ = 0;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
			Matrix4x4 matrix4x30 = matrix4x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v30+8]");
			((Matrix4x4*)(nint)matrix4x30)->m20 = 0f;
			((Matrix4x4*)(nint)matrix4x3)->m00 = (float)obj4;
			Matrix4x4 matrix4x31 = matrix4x3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v21+8]");
			((Matrix4x4*)(nint)matrix4x31)->m20 = 0f;
			Matrix4x4 matrix4x32 = matrix4x * matrix4x3;
			((Matrix4x4*)(nint)matrix4x3)->m00 = (float)obj5;
			Matrix4x4 matrix4x33 = matrix4x3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v23+8]");
			((Matrix4x4*)(nint)matrix4x33)->m20 = 0f;
			((List<Color>)left).Add((Color)matrix4x3);
			break;
		}
		case 2:
		case 3:
		{
			obj6 = ((int*)top)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [top @ L2 (System.Int32)+8]");
			_ = 0;
			object obj14 = this + 312;
			obj4 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S1_v55+8]");
			_ = 0;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
			Matrix4x4 matrix4x26 = matrix4x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v30+8]");
			((Matrix4x4*)(nint)matrix4x26)->m20 = 0f;
			((Matrix4x4*)(nint)matrix4x3)->m00 = (float)obj4;
			Matrix4x4 matrix4x27 = matrix4x3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v21+8]");
			((Matrix4x4*)(nint)matrix4x27)->m20 = 0f;
			Matrix4x4 matrix4x28 = matrix4x * matrix4x3;
			((Matrix4x4*)(nint)matrix4x3)->m00 = (float)obj5;
			Matrix4x4 matrix4x29 = matrix4x3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v23+8]");
			((Matrix4x4*)(nint)matrix4x29)->m20 = 0f;
			((List<Color>)left).Add((Color)matrix4x3);
			break;
		}
		}
	}

	public void ResetAnchors()
	{
		//IL_0050: Expected Obj, but got I4
		UIDrawCall.OnRenderCallback onRender = ((UIWidget)this).onRender;
		if (onRender != null)
		{
			mUpdateFrame = -1;
			mUpdateAnchors = true;
			int renderedFrameCount = Time.renderedFrameCount;
			SetAnchor((Transform)renderedFrameCount);
		}
	}

	public void ResetAndUpdateAnchors()
	{
		//IL_027e: Expected I, but got Obj
		//IL_0294: Expected Obj, but got I
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_02d1: Expected I, but got Obj
		//IL_02e7: Expected Obj, but got I
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected Obj, but got Unknown
		//IL_008b: Expected I, but got Obj
		//IL_0324: Expected I, but got Obj
		//IL_033a: Expected Obj, but got I
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected Obj, but got Unknown
		//IL_0103: Expected I, but got Obj
		//IL_0377: Expected I, but got Obj
		//IL_038d: Expected Obj, but got I
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Expected Obj, but got Unknown
		//IL_017b: Expected I, but got Obj
		//IL_03d7: Expected I, but got Obj
		//IL_03ed: Expected Obj, but got I
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected Obj, but got Unknown
		//IL_041e: Expected Obj, but got I4
		//IL_01f3: Expected I, but got Obj
		mAnchorsCached = true;
		AnchorPoint anchorPoint = leftAnchor;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v98 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = leftAnchor + 20;
		UIRect uIRect;
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint.target))
		{
			AnchorPoint anchorPoint2 = leftAnchor;
			uIRect = anchorPoint2.target.GetComponent<UIRect>();
		}
		else
		{
			uIRect = null;
		}
		obj2 = uIRect;
		AnchorPoint anchorPoint3 = bottomAnchor;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v89 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = bottomAnchor + 20;
		UIRect uIRect2;
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint3.target))
		{
			AnchorPoint anchorPoint4 = bottomAnchor;
			uIRect2 = anchorPoint4.target.GetComponent<UIRect>();
		}
		else
		{
			uIRect2 = null;
		}
		obj4 = uIRect2;
		AnchorPoint anchorPoint5 = rightAnchor;
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v80 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = rightAnchor + 20;
		UIRect uIRect3;
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint5.target))
		{
			AnchorPoint anchorPoint6 = rightAnchor;
			uIRect3 = anchorPoint6.target.GetComponent<UIRect>();
		}
		else
		{
			uIRect3 = null;
		}
		obj6 = uIRect3;
		AnchorPoint anchorPoint7 = topAnchor;
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v43 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S1_v71 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj8 = topAnchor + 20;
		UIRect uIRect4;
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)anchorPoint7.target))
		{
			AnchorPoint anchorPoint8 = topAnchor;
			uIRect4 = anchorPoint8.target.GetComponent<UIRect>();
		}
		else
		{
			uIRect4 = null;
		}
		obj8 = uIRect4;
		Transform transform = cachedTransform;
		bool activeSelf = ((GameObject)(object)transform).activeSelf;
		nint num9 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v22 (Il2CppClass<NGUITools>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num10 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v33 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj10 = this + 68;
		string typeName = NGUITools.GetTypeName((UnityEngine.Object)activeSelf);
		obj10 = typeName;
		((UIWidget)null).onRender = (UIDrawCall.OnRenderCallback)(object)leftAnchor;
		((UIWidget)null).onRender = (UIDrawCall.OnRenderCallback)(object)bottomAnchor;
		((UIWidget)null).onRender = (UIDrawCall.OnRenderCallback)(object)rightAnchor;
		((UIWidget)null).onRender = (UIDrawCall.OnRenderCallback)(object)topAnchor;
		mUpdateAnchors = true;
	}

	public abstract void SetRect(float x, float y, float width, float height);

	private void FindCameraFor(AnchorPoint ap)
	{
		//IL_0080: Expected I, but got Obj
		//IL_0096: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_00cb: Expected Obj, but got I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_00e3: Expected Obj, but got I4
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_00fb: Expected Obj, but got I4
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0113: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v30 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = ((((ComputeShader)(object)ap).FindKernel((string)null) != 0) ? ((GameObject)(object)ap).layer : 0);
		object obj2 = leftAnchor + 8;
		obj2 = num3;
		object obj3 = rightAnchor + 8;
		obj3 = num3;
		object obj4 = topAnchor + 8;
		obj4 = num3;
		object obj5 = bottomAnchor + 8;
		obj5 = num3;
		ResetAndUpdateAnchors();
		ResetAnchors();
	}

	public virtual void ParentHasChanged()
	{
		ResetAndUpdateAnchors();
		ResetAnchors();
	}

	protected abstract void OnStart();

	protected virtual void OnUpdate()
	{
		//IL_0257: Expected I, but got Obj
		//IL_026d: Expected Obj, but got I
		//IL_02a5: Expected I, but got Obj
		//IL_02bb: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_0170: Expected I, but got Obj
		//IL_0186: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_0222: Expected Obj, but got I4
		//IL_01b1: Expected I, but got Obj
		mParentFound = false;
		Camera camera = anchorCamera;
		Transform parentInternal = ((Transform)(object)camera).parentInternal;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v51 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIRect uIRect = NGUITools.FindInParents<UIRect>(parentInternal);
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v47 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mParent).FindKernel((string)(object)uIRect) == 0)
		{
			return;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v43 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)mParent))
		{
			UIRect uIRect2 = mParent;
			bool flag = uIRect2.mChildren.Remove(this);
		}
		object obj4 = this + 60;
		obj4 = uIRect;
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v38 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)mParent))
		{
			UIRect uIRect3 = mParent;
			uIRect3.mChildren.Add(this);
		}
		object obj6 = this - -64;
		obj6 = 0;
	}

	static UIRect()
	{
		//IL_00cf: Expected I, but got Obj
		//IL_00e5: Expected Obj, but got I
		//IL_0013: Expected Obj, but got I4
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_004d: Expected I, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_006c: Expected Obj, but got I4
		//IL_007a: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		BetterList<UIDrawCall> mActiveList = default;
		UIDrawCall.mActiveList = mActiveList;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = (nint)typeof(UIDrawCall);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v19 (Il2CppClass<UIDrawCall>)+5C]");
		object obj = (nint)0 + (nint)4;
		object obj2 = default;
		obj = obj2;
		UIDrawCall.mColorSpace = ColorSpace.Uninitialized;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<> list = default;
		((List<T>)(object)list)._002Ector((IEnumerable<T>)10);
		nint num2 = (nint)typeof(UIDrawCall);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v29 (Il2CppClass<UIDrawCall>)+5C]");
		object obj3 = (nint)0 + (nint)12;
		obj3 = list;
		nint num3 = (nint)typeof(UIDrawCall);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v33 (Il2CppClass<UIDrawCall>)+5C]");
		object obj4 = (nint)0 + (nint)16;
		obj4 = 0;
		nint num4 = (nint)typeof(UIDrawCall);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v37 (Il2CppClass<UIDrawCall>)+5C]");
		object obj5 = (nint)0 + (nint)20;
		obj5 = 0;
		UIDrawCall.dx9BugWorkaround = -1;
	}
}

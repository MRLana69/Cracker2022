using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class UIScrollBar : UISlider
{
	private enum Direction
	{
		Horizontal,
		Vertical,
		Upgraded
	}

	protected float mSize;

	private float mScroll;

	private Direction mDir;

	public float scrollValue
	{
		get
		{
			//IL_012e: Expected I, but got Obj
			//IL_0144: Expected Obj, but got I
			//IL_006f: Expected I, but got Obj
			//IL_0085: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00b0: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v26 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mFG).FindKernel((string)null) != 0)
			{
				UIWidget uIWidget = mFG;
			}
			else
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)mBG).FindKernel((string)null) == 0)
				{
					return 1f;
				}
				UIWidget uIWidget = mBG;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
			float result = default;
			return result;
		}
		set
		{
			//IL_06e4: Expected I, but got Obj
			//IL_06fa: Expected Obj, but got I
			//IL_0750: Expected I, but got Obj
			//IL_0766: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_07e7: Expected I, but got Obj
			//IL_07fd: Expected Obj, but got I
			//IL_0227: Expected I, but got Obj
			//IL_007e: Expected I, but got Obj
			//IL_0094: Expected Obj, but got I
			//IL_043b: Expected I, but got Obj
			//IL_0292: Expected I, but got Obj
			//IL_02a8: Expected Obj, but got I
			//IL_015a: Expected I, but got Obj
			//IL_0170: Expected Obj, but got I
			//IL_00bf: Expected I, but got Obj
			//IL_0497: Expected I, but got Obj
			//IL_04ad: Expected Obj, but got I
			//IL_036e: Expected I, but got Obj
			//IL_0384: Expected Obj, but got I
			//IL_02d3: Expected I, but got Obj
			//IL_019b: Expected I, but got Obj
			//IL_0125: Invalid comparison between Obj and F4
			//IL_04d8: Expected I, but got Obj
			//IL_03af: Expected I, but got Obj
			//IL_0339: Invalid comparison between Obj and F4
			//IL_0201: Invalid comparison between Obj and F4
			//IL_0214: Expected Obj, but got I4
			//IL_0541: Expected I, but got Obj
			//IL_0557: Expected Obj, but got I
			//IL_0415: Invalid comparison between Obj and F4
			//IL_0428: Expected Obj, but got I4
			//IL_0619: Expected I, but got Obj
			//IL_062f: Expected Obj, but got I
			//IL_0582: Expected I, but got Obj
			//IL_065a: Expected I, but got Obj
			//IL_05e6: Invalid comparison between Obj and F4
			//IL_06be: Invalid comparison between Obj and F4
			//IL_06d1: Expected Obj, but got I4
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v94 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mFG).FindKernel((string)null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
				Collider component = mFG.GetComponent<Collider>();
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v93 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v122 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
				{
					Collider component2 = mFG.GetComponent<Collider>();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
					object obj3 = default;
					bool isTrigger = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.001f);
					component2.isTrigger = isTrigger;
				}
				else
				{
					Collider2D component3 = mFG.GetComponent<Collider2D>();
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S1_v103 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num6 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S1_v113 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)component3).FindKernel((string)null) != 0)
					{
						Collider2D component4 = mFG.GetComponent<Collider2D>();
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
						object obj5 = default;
						bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.001f);
						component4.tag = (string)flag;
					}
				}
			}
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v77 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mBG).FindKernel((string)null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
				Collider component5 = mBG.GetComponent<Collider>();
				nint num9 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S1_v55 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num10 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S1_v84 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)component5).FindKernel((string)null) != 0)
				{
					Collider component6 = mBG.GetComponent<Collider>();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
					object obj8 = default;
					bool isTrigger2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.001f);
					component6.isTrigger = isTrigger2;
				}
				else
				{
					Collider2D component7 = mBG.GetComponent<Collider2D>();
					nint num11 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S1_v65 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num12 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S1_v75 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)component7).FindKernel((string)null) != 0)
					{
						Collider2D component8 = mBG.GetComponent<Collider2D>();
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
						object obj10 = default;
						bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.001f);
						component8.tag = (string)flag2;
					}
				}
			}
			nint num13 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v28 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num14 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v60 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)thumb).FindKernel((string)null) == 0)
			{
				return;
			}
			UIWidget component9 = thumb.GetComponent<UIWidget>();
			nint num15 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v39 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num16 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v56 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component9).FindKernel((string)null) == 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
			Collider component10 = component9.GetComponent<Collider>();
			nint num17 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num18 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S1_v46 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component10).FindKernel((string)null) != 0)
			{
				Collider component11 = component9.GetComponent<Collider>();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
				object obj14 = default;
				bool isTrigger3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.001f);
				component11.isTrigger = isTrigger3;
				return;
			}
			Collider2D component12 = component9.GetComponent<Collider2D>();
			nint num19 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num20 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ S1_v37 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component12).FindKernel((string)null) != 0)
			{
				Collider2D component13 = component9.GetComponent<Collider2D>();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
				object obj16 = default;
				bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.001f);
				component13.tag = (string)flag3;
			}
		}
	}

	public float barSize
	{
		get
		{
			return alpha;
		}
		set
		{
			alpha = value;
		}
	}

	protected override void Upgrade()
	{
		CancelInvoke();
	}

	protected override void OnStart()
	{
		if (mDir != Direction.Upgraded)
		{
			mValue = mScroll;
			bool flag = mInverted;
			if (mDir != Direction.Horizontal)
			{
				FillDirection fillDirection = ((!flag) ? FillDirection.TopToBottom : FillDirection.BottomToTop);
				mFill = fillDirection;
			}
			else
			{
				mFill = (flag ? FillDirection.RightToLeft : FillDirection.LeftToRight);
			}
			mDir = Direction.Upgraded;
		}
	}

	protected unsafe override float LocalToValue(Vector2 localPos)
	{
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected Obj, but got Unknown
		//IL_028d: Expected Obj, but got I4
		//IL_02a1: Expected I, but got Obj
		//IL_02b7: Expected Obj, but got I
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected VT, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected Obj, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected Obj, but got Unknown
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00b0: Expected I, but got Obj
		//IL_00c6: Expected Obj, but got I
		//IL_02e1: Expected F4, but got Obj
		//IL_02dc: Expected native int or pointer, but got VT
		//IL_02f6: Expected F4, but got I
		//IL_02f1: Expected native int or pointer, but got VT
		//IL_0303: Expected F4, but got Obj
		//IL_02fe: Expected native int or pointer, but got VT
		//IL_0318: Expected F4, but got I
		//IL_0313: Expected native int or pointer, but got VT
		//IL_00f1: Expected I, but got Obj
		//IL_01ca: Expected native int or pointer, but got VT
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		//IL_01ea: Expected F4, but got Obj
		//IL_01e5: Expected native int or pointer, but got VT
		//IL_01ff: Expected F4, but got I
		//IL_01fa: Expected native int or pointer, but got VT
		//IL_021c: Expected Obj, but got I
		//IL_0161: Expected native int or pointer, but got VT
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_0181: Expected F4, but got Obj
		//IL_017c: Expected native int or pointer, but got VT
		//IL_0196: Expected F4, but got I
		//IL_0191: Expected native int or pointer, but got VT
		Vector3 vector = default;
		object obj = vector + 48;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v84 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector2 = vector + 60;
		object obj3 = vector + 36;
		object obj4 = vector + 24;
		object obj5 = vector + 12;
		float num8;
		if (((ComputeShader)(object)mFG).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj7 = default;
			object obj6 = obj7 + 40;
			obj3 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v17+8]");
			_ = 0;
			object obj8 = obj7 + 16;
			obj4 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v22+8]");
			_ = 0;
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v36 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num4 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v80 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector2)->x = (float)obj3;
			Vector3 vector3 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v21+8]");
			((Vector3*)(nint)vector3)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj4;
			Vector3 vector4 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v23+8]");
			((Vector3*)(nint)vector4)->z = 0f;
			Quaternion quaternion = Quaternion.FromToRotation(vector2, vector);
			obj = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v25+8]");
			_ = 0;
			float num5;
			object obj11;
			float num6;
			if (mFill == FillDirection.LeftToRight || mFill == FillDirection.RightToLeft)
			{
				((Vector3*)(nint)vector)->x = localPos.x;
				object obj10 = obj7 + 16;
				((Vector3*)(nint)vector2)->x = (float)obj;
				Vector3 vector5 = vector2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((Vector3*)(nint)vector5)->z = 0f;
				num5 = vector2.x;
				obj11 = obj10;
				num6 = vector.x;
			}
			else
			{
				((Vector3*)(nint)vector)->x = localPos.x;
				object obj12 = obj7 + 16;
				((Vector3*)(nint)vector2)->x = (float)obj;
				Vector3 vector6 = vector2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((Vector3*)(nint)vector6)->z = 0f;
				num5 = vector2.y;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v60+4]");
				obj11 = 0;
				num6 = vector.y;
			}
			float num7 = num6 - (float)obj11;
			num8 = num7 / num5;
			if (mFill == FillDirection.RightToLeft || mFill == FillDirection.TopToBottom)
			{
				num8 = 1f - num8;
			}
		}
		else
		{
			num8 = alpha;
		}
		return num8;
	}

	public unsafe override void ForceUpdate()
	{
		//IL_0389: Expected I, but got Obj
		//IL_039f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_007e: Expected I, but got Obj
		//IL_0094: Expected Obj, but got I
		//IL_00bf: Expected I, but got Obj
		//IL_011b: Expected I, but got Obj
		//IL_0131: Expected Obj, but got I
		//IL_015c: Expected I, but got Obj
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected Obj, but got Unknown
		//IL_02a6: Expected Obj, but got I4
		//IL_02bb: Expected Obj, but got I
		//IL_01b8: Expected I, but got Obj
		//IL_01ce: Expected Obj, but got I
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected Obj, but got Unknown
		//IL_0328: Expected Obj, but got I4
		//IL_033d: Expected Obj, but got I
		//IL_01f9: Expected I, but got Obj
		base._002Ector();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v56 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mFG).FindKernel((string)null) == 0)
		{
			return;
		}
		string text = mFG.tag;
		string text2 = tag;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S2_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S2_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)text).FindKernel(text2) == 0)
		{
			return;
		}
		Collider component = mFG.GetComponent<Collider>();
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v53 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) == 0)
		{
			Collider2D component2 = mFG.GetComponent<Collider2D>();
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S1_v44 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S1_v49 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component2).FindKernel((string)null) == 0)
			{
				return;
			}
		}
		string text3 = mFG.tag;
		bool hasVertices = ((UIGeometry)(object)text3).hasVertices;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj5 = default;
		obj5.method_ptr = method_ptr;
		obj5.method = (nint)__ldftn(UISlider.OnPressForeground);
		object obj6 = obj5 + 16;
		obj6 = this;
		object obj7 = (hasVertices ? 1 : 0) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v29 (System.Boolean)+20]");
		Delegate obj8 = ((Delegate)0).CombineImpl(obj5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj9 = default;
		obj7 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Delegate obj10 = default;
		obj10.method_ptr = method_ptr2;
		obj10.method = (nint)__ldftn(UISlider.OnDragForeground);
		object obj11 = obj10 + 16;
		obj11 = this;
		object obj12 = (hasVertices ? 1 : 0) + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v29 (System.Boolean)+30]");
		Delegate obj13 = ((Delegate)0).CombineImpl(obj10);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj14 = default;
		obj12 = obj14;
		UIWidget uIWidget = mFG;
		uIWidget.autoResizeBoxCollider = true;
	}

	public UIScrollBar()
	{
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected Obj, but got Unknown
		//IL_04ad: Expected Obj, but got I4
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected Obj, but got Unknown
		//IL_04ca: Expected Obj, but got I4
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected Obj, but got Unknown
		//IL_04e7: Expected Obj, but got I4
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Expected Obj, but got Unknown
		//IL_0504: Expected Obj, but got I4
		//IL_0518: Expected I, but got Obj
		//IL_052e: Expected Obj, but got I
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Expected Obj, but got Unknown
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_0778: Expected Obj, but got Unknown
		//IL_0781: Unknown result type (might be due to invalid IL or missing references)
		//IL_0786: Expected Obj, but got Unknown
		//IL_078f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Expected Obj, but got Unknown
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a2: Expected Obj, but got Unknown
		//IL_07ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b0: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0075: Expected I, but got Obj
		//IL_008b: Expected Obj, but got I
		//IL_00b6: Expected I, but got Obj
		//IL_02cb: Expected Obj, but got I4
		//IL_02e2: Expected Obj, but got F4
		//IL_02f5: Expected I, but got F4
		//IL_0302: Expected Obj, but got F4
		//IL_0266: Expected Obj, but got I4
		//IL_027d: Expected Obj, but got F4
		//IL_02a0: Expected I, but got F4
		//IL_02bd: Expected Obj, but got F4
		//IL_0208: Expected Obj, but got I4
		//IL_021e: Expected Obj, but got F4
		//IL_0231: Expected I, but got F4
		//IL_023f: Expected Obj, but got F4
		//IL_07f8: Expected I, but got Obj
		//IL_080e: Expected Obj, but got I
		//IL_01a3: Expected Obj, but got I4
		//IL_01c9: Expected Obj, but got F4
		//IL_01ec: Expected I, but got F4
		//IL_01fa: Expected Obj, but got F4
		//IL_0315: Expected I, but got Obj
		//IL_03ab: Expected I, but got Obj
		//IL_03c1: Expected Obj, but got I
		//IL_06e1: Expected F4, but got I
		//IL_06e1: Expected F4, but got Obj
		//IL_0731: Expected F4, but got I
		//IL_0731: Expected F4, but got I
		//IL_073d: Expected Obj, but got F4
		//IL_0455: Expected VT, but got Obj
		//IL_0480: Expected VT, but got Obj
		//IL_03ec: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 144;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 128;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 112;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 96;
		obj5 = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v151 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIWidget uIWidget = (UIWidget)(obj2 + 160);
		object obj7 = obj2 + 80;
		object obj8 = obj2 - -64;
		object obj9 = obj2 + 48;
		object obj10 = obj2 + 32;
		object obj11 = obj2 + 16;
		if (((ComputeShader)(object)mFG).FindKernel((string)null) != 0)
		{
			mIsDirty = false;
			float num3 = mSize;
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v30 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num5 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v121 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (num3 < 0f)
			{
				num3 = 0f;
			}
			else if (num3 > 1f)
			{
				num3 = 1f;
			}
			float num6 = num3 * 0.5f;
			float b = 1f - num6;
			float t = alpha;
			float num7 = Mathf.LerpUnclamped(num6, b, t);
			float num8 = num7 - num6;
			float num9 = num7 + num6;
			bool flag = mFill == FillDirection.LeftToRight || mFill == FillDirection.RightToLeft;
			bool flag2 = mFill == FillDirection.RightToLeft || mFill == FillDirection.TopToBottom;
			if (flag)
			{
				if (flag2)
				{
					((UnityEngine.Object)0).m_CachedPtr = (IntPtr)0;
					uIWidget = (UIWidget)(1f - num9);
					_ = 0f;
					((UnityEngine.Object)uIWidget).m_CachedPtr = (IntPtr)(1f - num8);
					uIWidget.leftAnchor = (UIRect.AnchorPoint)1f;
				}
				else
				{
					((UnityEngine.Object)0).m_CachedPtr = (IntPtr)0;
					uIWidget = (UIWidget)num8;
					_ = 0f;
					((UnityEngine.Object)uIWidget).m_CachedPtr = (IntPtr)num9;
					uIWidget.leftAnchor = (UIRect.AnchorPoint)1f;
				}
				obj4 = uIWidget;
				_ = ((UnityEngine.Object)uIWidget).m_CachedPtr;
				uIWidget = (UIWidget)obj4;
				UIWidget uIWidget2 = uIWidget;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
				((UnityEngine.Object)uIWidget2).m_CachedPtr = (IntPtr)0;
			}
			else
			{
				if (flag2)
				{
					((UnityEngine.Object)0).m_CachedPtr = (IntPtr)0;
					uIWidget = (UIWidget)0f;
					float num10 = 1f - num9;
					((UnityEngine.Object)uIWidget).m_CachedPtr = (IntPtr)1f;
					uIWidget.leftAnchor = (UIRect.AnchorPoint)(1f - num8);
				}
				else
				{
					((UnityEngine.Object)0).m_CachedPtr = (IntPtr)0;
					uIWidget = (UIWidget)0f;
					((UnityEngine.Object)uIWidget).m_CachedPtr = (IntPtr)1f;
					uIWidget.leftAnchor = (UIRect.AnchorPoint)num9;
				}
				obj5 = uIWidget;
				_ = ((UnityEngine.Object)uIWidget).m_CachedPtr;
				uIWidget = (UIWidget)obj5;
				UIWidget uIWidget3 = uIWidget;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
				((UnityEngine.Object)uIWidget3).m_CachedPtr = (IntPtr)0;
			}
			Vector2 pivotOffset = uIWidget.pivotOffset;
			nint num11 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S1_v54 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num12 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S1_v95 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)thumb).FindKernel((string)null) == 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
			obj = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v23+8]");
			_ = 0;
			obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v23+8]");
			_ = 0;
			obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			nint num13 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ S2_v27 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num14 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ S2_v39 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj13 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v27+8]");
			float num15 = Mathf.LerpUnclamped((float)obj13, 0f, 0.5f);
			obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v29+4]");
			nint num16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v31+C]");
			float num17 = Mathf.LerpUnclamped(num16, 0f, 0.5f);
			obj3 = num15;
			_ = 0f;
			Camera anchorCamera = mFG.anchorCamera;
			uIWidget = (UIWidget)obj3;
			UIWidget uIWidget4 = uIWidget;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			((UnityEngine.Object)uIWidget4).m_CachedPtr = (IntPtr)0;
			Vector3 vector = ((Transform)(object)anchorCamera).InverseTransformPoint((Vector3)uIWidget);
			uIWidget = (UIWidget)obj2;
			UIWidget uIWidget5 = uIWidget;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)uIWidget5).m_CachedPtr = (IntPtr)0;
			((UIProgressBar)this).OnPan((Vector2)uIWidget);
		}
		else
		{
			((UIProgressBar)this)._002Ector();
		}
	}
}

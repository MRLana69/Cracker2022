using System;
using Cpp2ILInjected;
using UnityEngine;

public class UISlider : UIProgressBar
{
	private enum Direction
	{
		Horizontal,
		Vertical,
		Upgraded
	}

	private Transform foreground;

	private float rawValue;

	private Direction direction;

	protected bool mInverted;

	public bool isColliderEnabled
	{
		get
		{
			//IL_0339: Unknown result type (might be due to invalid IL or missing references)
			//IL_033e: Expected Obj, but got Unknown
			//IL_0347: Unknown result type (might be due to invalid IL or missing references)
			//IL_034c: Expected Obj, but got Unknown
			//IL_0355: Unknown result type (might be due to invalid IL or missing references)
			//IL_035a: Expected Obj, but got Unknown
			//IL_0363: Expected Obj, but got I4
			//IL_0372: Unknown result type (might be due to invalid IL or missing references)
			//IL_0377: Expected Obj, but got Unknown
			//IL_0380: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_03c3: Expected Obj, but got I
			//IL_03f1: Expected Obj, but got I
			//IL_045c: Invalid comparison between I and F4
			//IL_0054: Expected I, but got Obj
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected Obj, but got Unknown
			//IL_04a1: Invalid comparison between I and F4
			//IL_00c6: Expected F4, but got I4
			//IL_010e: Expected F4, but got I4
			object obj2 = default;
			object obj = obj2 + 40;
			object obj3 = obj2 + 16;
			object obj4 = obj2 + 80;
			obj4 = 0;
			_ = 0;
			object obj5 = obj2 + 56;
			obj5 = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISlider)+16]");
			float num4;
			bool result;
			if ((nint)0 != 0)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v95 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISlider)+68]");
				if ((UnityEngine.Object)0 != null)
				{
					object obj7 = this + 104;
					UIPanel component = GetComponent<UIPanel>();
					obj7 = component;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISlider)+68]");
				Vector2 clipSoftness = ((UIPanel)0).clipSoftness;
				obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
				obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+10]");
				_ = 0;
				obj2 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				float num3;
				if (0f == 0f)
				{
					int height = Screen.height;
					num3 = height;
				}
				else
				{
					obj = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					num3 = 0f * 0.5f;
				}
				obj = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+C]");
				if (0f == 0f)
				{
					int sleepTimeout = Screen.sleepTimeout;
					num4 = sleepTimeout;
				}
				else
				{
					obj = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+C]");
					num4 = 0f * 0.5f;
				}
				if (!((UIScrollView)(object)this).canMoveVertically)
				{
					goto IL_020b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
				obj3 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				_ = 0;
				float num5 = (float)obj + 0.001f;
				float num6 = (float)obj3 - num3;
				bool flag = num5 < num6;
				result = true;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
					obj3 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					_ = 0;
					float num7 = (float)obj - 0.001f;
					float num8 = (float)obj3 + num3;
					bool flag2 = num7 > num8;
					result = true;
					if (!flag2)
					{
						goto IL_020b;
					}
				}
			}
			else
			{
				result = true;
			}
			goto IL_04e3;
			IL_020b:
			if (!((UIScrollView)(object)this).shouldMoveHorizontally)
			{
				goto IL_0314;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
			obj3 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
			float num9 = 0f + 0.001f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
			float num10 = 0f - num4;
			bool flag3 = num9 < num10;
			result = true;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
				obj3 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
				float num11 = 0f - 0.001f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
				float num12 = 0f + num4;
				bool flag4 = num11 > num12;
				result = true;
				if (!flag4)
				{
					goto IL_0314;
				}
			}
			goto IL_04e3;
			IL_0314:
			result = false;
			goto IL_04e3;
			IL_04e3:
			return result;
		}
	}

	public float sliderValue
	{
		get
		{
			//IL_000d: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISlider)+50]");
			return 0f;
		}
		set
		{
			//IL_001d: Expected I, but got Obj
			//IL_0033: Expected Obj, but got I
			//IL_005e: Expected I, but got Obj
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Expected Obj, but got Unknown
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Expected Obj, but got Unknown
			//IL_0127: Expected I, but got Obj
			//IL_013d: Expected Obj, but got I
			//IL_0249: Invalid comparison between I and F4
			//IL_0168: Expected I, but got Obj
			if (!isActiveAndEnabled)
			{
				return;
			}
			string fileName = tag;
			nint num = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v6 (Il2CppClass<NGUITools>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v38 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			byte[] array = NGUITools.Load(fileName);
			if (array == null || mValue == 0f)
			{
				return;
			}
			((UIScrollView)(object)this).UpdateScrollbars();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISlider)+B5]");
			bool flag = (nint)0 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj3 = default;
			object obj2 = flag | obj3;
			object obj4 = obj2 & 1;
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v19 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v34 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISlider)+98]");
			float num5 = ((0f < 0f) ? (-1f) : 1f);
			float num6 = ((value < 0f) ? (-1f) : 1f);
			if (num5 != num6)
			{
				_ = 0f;
			}
			float num7 = value * mValue;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISlider)+98]");
			float num8 = 0f + num7;
		}
	}

	public unsafe bool inverted
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
			//IL_02d8: Expected I, but got Obj
			//IL_02ee: Expected Obj, but got I
			//IL_0394: Unknown result type (might be due to invalid IL or missing references)
			//IL_0399: Expected Obj, but got Unknown
			//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a7: Expected Obj, but got Unknown
			//IL_0084: Expected I, but got Obj
			//IL_009a: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0317: Expected Obj, but got I4
			//IL_005f: Expected Obj, but got I4
			//IL_0136: Expected I, but got Obj
			//IL_014c: Expected Obj, but got I
			//IL_00c5: Expected I, but got Obj
			//IL_0111: Expected Obj, but got I4
			//IL_0177: Expected I, but got Obj
			//IL_01c4: Expected I, but got Obj
			//IL_01da: Expected Obj, but got I
			//IL_036d: Expected Obj, but got I4
			//IL_0205: Expected I, but got Obj
			//IL_0274: Expected Obj, but got I4
			//IL_027e: Expected F4, but got Obj
			//IL_02b3: Expected Obj, but got I4
			//IL_02c5: Expected F4, but got I
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v58 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj3 = default;
			object obj2 = obj3 + 16;
			object obj4 = obj3 + 8;
			if (((ComputeShader)(object)mTrans).FindKernel((string)null) != 0)
			{
				obj4 = ((bool*)(value ? 1 : 0))->m_value;
				obj2 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8D6A");
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v49 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)mIsDirty).FindKernel(null) != 0)
			{
				obj3 = ((bool*)(value ? 1 : 0))->m_value;
				obj2 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8D6A");
			}
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v38 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!(mTrans != null))
			{
				return;
			}
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S1_v40 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((UnityEngine.Object)mIsDirty != null)
			{
				if (((UIScrollView)(object)this).canMoveVertically)
				{
					obj2 = ((bool*)(value ? 1 : 0))->m_value;
					sliderValue = (float)obj2;
				}
				else if (((UIScrollView)(object)this).shouldMoveHorizontally)
				{
					obj2 = ((bool*)(value ? 1 : 0))->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v9+4]");
					sliderValue = 0f;
				}
			}
		}
	}

	protected override void Upgrade()
	{
		_ = 1;
		CancelInvoke();
	}

	protected override void OnStart()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_002a: Expected I, but got Obj
		//IL_0040: Expected Obj, but got I
		//IL_006b: Expected I, but got Obj
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		if (direction == Direction.Upgraded)
		{
			return;
		}
		mValue = rawValue;
		object obj = this - -64;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)obj).FindKernel((string)null) != 0)
		{
			object obj3 = this + 24;
			object obj4 = this - -64;
			UIWidget component = ((Component)obj4).GetComponent<UIWidget>();
			obj3 = component;
		}
		bool flag = mInverted;
		if (direction != Direction.Horizontal)
		{
			FillDirection fillDirection = ((!flag) ? FillDirection.BottomToTop : FillDirection.TopToBottom);
			mFill = fillDirection;
		}
		else
		{
			mFill = (flag ? FillDirection.RightToLeft : FillDirection.LeftToRight);
		}
		direction = Direction.Upgraded;
	}

	protected void OnPressBackground(GameObject go, bool isPressed)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
	}

	protected unsafe void OnDragBackground(GameObject go, Vector2 delta)
	{
		//IL_0144: Expected I, but got Obj
		//IL_015a: Expected Obj, but got I
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected VT, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected Obj, but got Unknown
		//IL_01a2: Expected native int or pointer, but got VT
		//IL_00e9: Invalid comparison between VT and I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v42 (Il2CppClass<UICamera>)+74]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v36 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = this + 48;
		obj3 = UICamera.currentCamera;
		UICamera.lastEventPosition = vector2;
		((Vector2*)(nint)vector)->x = vector2.x;
		float num5 = base.LocalToValue(vector);
		alpha = num5;
		if (delta == (Vector2)(object)0 && onDragFinished != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	protected unsafe void OnPressForeground(GameObject go, bool isPressed)
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected VT, but got Unknown
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v36 (Il2CppClass<UICamera>)+74]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v30 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = this + 48;
		obj3 = UICamera.currentCamera;
		UICamera.lastEventPosition = vector2;
		((Vector2*)(nint)vector)->x = vector2.x;
		float num5 = base.LocalToValue(vector);
		alpha = num5;
	}

	protected unsafe void OnDragForeground(GameObject go, Vector2 delta)
	{
		//IL_0250: Expected I, but got Obj
		//IL_0266: Expected Obj, but got I
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected VT, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected Obj, but got Unknown
		//IL_02a0: Invalid comparison between VT and I4
		//IL_011c: Expected I, but got Obj
		//IL_0132: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_01c2: Expected I, but got Obj
		//IL_01d8: Expected Obj, but got I
		//IL_015d: Expected I, but got Obj
		//IL_030e: Expected native int or pointer, but got VT
		//IL_0203: Expected I, but got Obj
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v52 (Il2CppClass<UICamera>)+74]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v46 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = this + 48;
		obj3 = UICamera.currentCamera;
		if (delta == (Vector2)(object)0)
		{
			if (onDragFinished != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
			}
			return;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v32 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v37 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num7;
		if (mFG != null)
		{
			num7 = 0f;
		}
		else
		{
			float num8 = alpha;
			nint num9 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S2_v6 (Il2CppClass<UICamera>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S2_v14 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera.lastEventPosition = vector2;
			((Vector2*)(nint)vector)->x = vector2.x;
			float num11 = base.LocalToValue(vector);
			num7 = num8 - num11;
		}
		mOffset = num7;
	}

	public override void OnPan(Vector2 delta)
	{
	}

	public unsafe UISlider()
	{
		//IL_06bb: Expected I, but got Obj
		//IL_06d1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_01e8: Expected Obj, but got I4
		//IL_01fd: Expected Obj, but got I
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got Unknown
		//IL_0265: Expected Obj, but got I4
		//IL_027a: Expected Obj, but got I
		//IL_00b0: Expected I, but got Obj
		//IL_02a3: Expected I, but got Obj
		//IL_02b9: Expected Obj, but got I
		//IL_010c: Expected I, but got Obj
		//IL_0122: Expected Obj, but got I
		//IL_02e4: Expected I, but got Obj
		//IL_014d: Expected I, but got Obj
		//IL_0340: Expected I, but got Obj
		//IL_0356: Expected Obj, but got I
		//IL_046b: Expected I, but got Obj
		//IL_0481: Expected Obj, but got I
		//IL_0381: Expected I, but got Obj
		//IL_03dd: Expected I, but got Obj
		//IL_03f3: Expected Obj, but got I
		//IL_04ac: Expected I, but got Obj
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected Obj, but got Unknown
		//IL_05f6: Expected Obj, but got I4
		//IL_060b: Expected Obj, but got I
		//IL_0508: Expected I, but got Obj
		//IL_051e: Expected Obj, but got I
		//IL_041e: Expected I, but got Obj
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected Obj, but got Unknown
		//IL_0678: Expected Obj, but got I4
		//IL_068d: Expected Obj, but got I
		//IL_0549: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v109 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mBG).FindKernel((string)null) == 0)
		{
			goto IL_019b;
		}
		Collider component = mBG.GetComponent<Collider>();
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v95 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v113 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) == 0)
		{
			Collider2D component2 = mBG.GetComponent<Collider2D>();
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S1_v104 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S1_v109 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component2).FindKernel((string)null) == 0)
			{
				goto IL_019b;
			}
		}
		Component component3 = mBG;
		goto IL_074f;
		IL_074f:
		string text = component3.tag;
		bool hasVertices = ((UIGeometry)(object)text).hasVertices;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj4 = default;
		obj4.method_ptr = method_ptr;
		obj4.method = (nint)__ldftn(UISlider.OnPressBackground);
		object obj5 = obj4 + 16;
		obj5 = this;
		object obj6 = (hasVertices ? 1 : 0) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v17 (System.Boolean)+20]");
		Delegate obj7 = ((Delegate)0).CombineImpl(obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj8 = default;
		obj6 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Delegate obj9 = default;
		obj9.method_ptr = method_ptr2;
		obj9.method = (nint)__ldftn(UISlider.OnDragBackground);
		object obj10 = obj9 + 16;
		obj10 = this;
		object obj11 = (hasVertices ? 1 : 0) + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v17 (System.Boolean)+30]");
		Delegate obj12 = ((Delegate)0).CombineImpl(obj9);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj13 = default;
		obj11 = obj13;
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v40 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v90 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)thumb).FindKernel((string)null) == 0)
		{
			return;
		}
		Collider component4 = thumb.GetComponent<Collider>();
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S1_v87 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component4).FindKernel((string)null) == 0)
		{
			Collider2D component5 = thumb.GetComponent<Collider2D>();
			nint num11 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S1_v78 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num12 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S1_v83 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component5).FindKernel((string)null) == 0)
			{
				return;
			}
		}
		nint num13 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S1_v40 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num14 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S1_v71 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(mFG != null))
		{
			Camera anchorCamera = mFG.anchorCamera;
			nint num15 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S2_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num16 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S2_v30 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)thumb).FindKernel((string)(object)anchorCamera) == 0)
			{
				return;
			}
		}
		string text2 = thumb.tag;
		bool hasVertices2 = ((UIGeometry)(object)text2).hasVertices;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Delegate obj19 = default;
		obj19.method_ptr = method_ptr3;
		obj19.method = (nint)__ldftn(UISlider.OnPressForeground);
		object obj20 = obj19 + 16;
		obj20 = this;
		object obj21 = (hasVertices2 ? 1 : 0) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ S0_v61 (System.Boolean)+20]");
		Delegate obj22 = ((Delegate)0).CombineImpl(obj19);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj23 = default;
		obj21 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		Delegate obj24 = default;
		obj24.method_ptr = method_ptr4;
		obj24.method = (nint)__ldftn(UISlider.OnDragForeground);
		object obj25 = obj24 + 16;
		obj25 = this;
		object obj26 = (hasVertices2 ? 1 : 0) + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ S0_v61 (System.Boolean)+30]");
		Delegate obj27 = ((Delegate)0).CombineImpl(obj24);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj28 = default;
		obj26 = obj28;
		return;
		IL_019b:
		component3 = this;
		goto IL_074f;
	}
}

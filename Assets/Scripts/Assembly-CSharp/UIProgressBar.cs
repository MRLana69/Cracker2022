using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class UIProgressBar : UIWidgetContainer
{
	public enum FillDirection
	{
		LeftToRight,
		RightToLeft,
		BottomToTop,
		TopToBottom
	}

	public delegate void OnDragFinished();

	public static UIProgressBar current;

	public OnDragFinished onDragFinished;

	public Transform thumb;

	protected UIWidget mBG;

	protected UIWidget mFG;

	protected Image img;

	protected float mValue = 1f;

	protected FillDirection mFill;

	protected Transform mTrans;

	protected bool mIsDirty;

	protected Camera mCam;

	protected float mOffset;

	public int numberOfSteps;

	public List<EventDelegate> onChange;

	public Transform cachedTransform
	{
		get
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			object result = this + 40;
			if (mTrans == null)
			{
				Transform transform = base.transform;
				mTrans = transform;
			}
			return (Transform)result;
		}
	}

	public Camera cachedCamera
	{
		get
		{
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected Obj, but got Unknown
			object result = this + 48;
			if (mCam == null)
			{
				GameObject gameObject = base.gameObject;
				int layer = gameObject.layer;
				Camera camera = NGUITools.FindCameraForLayer(layer);
				mCam = camera;
			}
			return (Camera)result;
		}
	}

	public Image foreground_img
	{
		get
		{
			return img;
		}
		set
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			if (img != value)
			{
				object obj = this + 28;
				obj = value;
			}
		}
	}

	public UIWidget foregroundWidget
	{
		get
		{
			return mFG;
		}
		set
		{
			if (mFG != value)
			{
				mFG = value;
				mIsDirty = true;
			}
		}
	}

	public UIWidget backgroundWidget
	{
		get
		{
			return mBG;
		}
		set
		{
			if (mBG != value)
			{
				mBG = value;
				mIsDirty = true;
			}
		}
	}

	public FillDirection fillDirection
	{
		get
		{
			return mFill;
		}
		set
		{
			//IL_003b: Expected I, but got Obj
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected Obj, but got Unknown
			if (value != mFill)
			{
				mFill = value;
				nint num = (nint)this;
				object obj = this + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v11 @ S1_v6 (Il2CppClass<UIProgressBar>)+F4] (should have been resolved before IL gen)");
			}
		}
	}

	public float value
	{
		get
		{
			//IL_0047: Expected Obj, but got I4
			//IL_0072: Expected Obj, but got I4
			float result = mValue;
			if (numberOfSteps >= 2)
			{
				object obj = numberOfSteps - 1;
				float num = mValue * (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
				object obj2 = numberOfSteps - 1;
				object obj3 = default;
				result = (float)obj3 / (float)obj2;
			}
			return result;
		}
		set
		{
			//IL_00d3: Expected I, but got Obj
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Expected Obj, but got Unknown
			float num = Math.Min(value, 1f);
			bool flag = value < 0f;
			float num2 = 0f;
			if (!flag)
			{
				num2 = num;
			}
			if (num2 == mValue)
			{
				if (img != null)
				{
					img.fillAmount = num2;
				}
				return;
			}
			float num3 = this.value;
			mValue = num2;
			if (img != null)
			{
				img.fillAmount = mValue;
			}
			float num4 = this.value;
			if (num4 != num3)
			{
				nint num5 = (nint)this;
				object obj = this + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v103 @ S1_v14 (Il2CppClass<UIProgressBar>)+F4] (should have been resolved before IL gen)");
				if (NGUITools.GetActive(this) && EventDelegate.IsValid(onChange))
				{
					current = this;
					EventDelegate.Execute(onChange);
					current = null;
				}
			}
		}
	}

	public float alpha
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Expected Obj, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected Obj, but got Unknown
			object obj;
			float result = default;
			if (mFG != null)
			{
				obj = this + 24;
			}
			else
			{
				bool flag = mBG != null;
				bool flag2 = !flag;
				result = 1f;
				if (flag2)
				{
					goto IL_00b2;
				}
				obj = this + 20;
			}
			object obj2 = obj;
			object obj3 = obj2;
			object obj4 = obj2 + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v42 @ S1_v6+F4] (should have been resolved before IL gen)");
			goto IL_00b2;
			IL_00b2:
			return result;
		}
		set
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected Obj, but got Unknown
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Expected Obj, but got Unknown
			//IL_0083: Expected I, but got Obj
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Expected Obj, but got Unknown
			//IL_00a4: Invalid comparison between Obj and F4
			//IL_0202: Expected I, but got Obj
			//IL_020b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0210: Expected Obj, but got Unknown
			//IL_0223: Invalid comparison between Obj and F4
			//IL_011d: Expected I, but got Obj
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Expected Obj, but got Unknown
			//IL_013e: Invalid comparison between Obj and F4
			//IL_0347: Unknown result type (might be due to invalid IL or missing references)
			//IL_034c: Expected Obj, but got Unknown
			//IL_029c: Expected I, but got Obj
			//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02aa: Expected Obj, but got Unknown
			//IL_02bd: Invalid comparison between Obj and F4
			//IL_03a4: Expected I, but got Obj
			//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b2: Expected Obj, but got Unknown
			//IL_03c5: Invalid comparison between Obj and F4
			//IL_042c: Expected I, but got Obj
			//IL_0435: Unknown result type (might be due to invalid IL or missing references)
			//IL_043a: Expected Obj, but got Unknown
			//IL_044d: Invalid comparison between Obj and F4
			if (mFG != null)
			{
				UIWidget uIWidget = mFG;
				object obj = uIWidget - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v32 @ S2_v47+BC] (should have been resolved before IL gen)");
				Collider component = mFG.GetComponent<Collider>();
				if (component != null)
				{
					Collider component2 = mFG.GetComponent<Collider>();
					UIWidget uIWidget2 = mFG;
					nint num = (nint)uIWidget2;
					object obj2 = uIWidget2 + 56;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v156 @ S2_v58 (Il2CppClass<UIWidget>)+F4] (should have been resolved before IL gen)");
					object obj3 = default;
					bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.001f);
					component2.enabled = flag;
				}
				else
				{
					Collider2D component3 = mFG.GetComponent<Collider2D>();
					if (component3 != null)
					{
						Collider2D component4 = mFG.GetComponent<Collider2D>();
						UIWidget uIWidget3 = mFG;
						nint num2 = (nint)uIWidget3;
						object obj4 = uIWidget3 + 56;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v251 @ S2_v52 (Il2CppClass<UIWidget>)+F4] (should have been resolved before IL gen)");
						object obj5 = default;
						bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.001f);
						component4.enabled = flag2;
					}
				}
			}
			if (mBG != null)
			{
				UIWidget uIWidget4 = mBG;
				object obj6 = uIWidget4 - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v98 @ S2_v29+BC] (should have been resolved before IL gen)");
				Collider component5 = mBG.GetComponent<Collider>();
				if (component5 != null)
				{
					Collider component6 = mBG.GetComponent<Collider>();
					UIWidget uIWidget5 = mBG;
					nint num3 = (nint)uIWidget5;
					object obj7 = uIWidget5 + 56;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v236 @ S2_v40 (Il2CppClass<UIWidget>)+F4] (should have been resolved before IL gen)");
					object obj8 = default;
					bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.001f);
					component6.enabled = flag3;
				}
				else
				{
					Collider2D component7 = mBG.GetComponent<Collider2D>();
					if (component7 != null)
					{
						Collider2D component8 = mBG.GetComponent<Collider2D>();
						UIWidget uIWidget6 = mBG;
						nint num4 = (nint)uIWidget6;
						object obj9 = uIWidget6 + 56;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v283 @ S2_v34 (Il2CppClass<UIWidget>)+F4] (should have been resolved before IL gen)");
						object obj10 = default;
						bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.001f);
						component8.enabled = flag4;
					}
				}
			}
			if (!(thumb != null))
			{
				return;
			}
			UIWidget component9 = thumb.GetComponent<UIWidget>();
			if (!(component9 != null))
			{
				return;
			}
			object obj11 = component9 - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v265 @ S2_v10+BC] (should have been resolved before IL gen)");
			Collider component10 = component9.GetComponent<Collider>();
			if (component10 != null)
			{
				Collider component11 = component9.GetComponent<Collider>();
				nint num5 = (nint)component9;
				object obj12 = component9 + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v303 @ S2_v21 (Il2CppClass<UIWidget>)+F4] (should have been resolved before IL gen)");
				object obj13 = default;
				bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.001f);
				component11.enabled = flag5;
				return;
			}
			Collider2D component12 = component9.GetComponent<Collider2D>();
			if (component12 != null)
			{
				Collider2D component13 = component9.GetComponent<Collider2D>();
				nint num6 = (nint)component9;
				object obj14 = component9 + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v319 @ S2_v15 (Il2CppClass<UIWidget>)+F4] (should have been resolved before IL gen)");
				object obj15 = default;
				bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.001f);
				component13.enabled = flag6;
			}
		}
	}

	protected bool isHorizontal => mFill < FillDirection.BottomToTop;

	protected bool isInverted
	{
		get
		{
			//IL_0010: Expected Obj, but got I4
			object obj = mFill & (FillDirection)(-3);
			return (nint)obj == 1;
		}
	}

	protected void Start()
	{
		//IL_0095: Expected I, but got Obj
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00d1: Expected I, but got Obj
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_00ec: Expected I, but got Obj
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<UIProgressBar>)+DC] (should have been resolved before IL gen)");
		if (Application.isPlaying)
		{
			if (mBG != null)
			{
				UIWidget uIWidget = mBG;
				uIWidget.autoResizeBoxCollider = true;
			}
			nint num2 = (nint)this;
			object obj2 = this + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v68 @ S1_v14 (Il2CppClass<UIProgressBar>)+E4] (should have been resolved before IL gen)");
			if (current == null && onChange != null)
			{
				current = this;
				EventDelegate.Execute(onChange);
				current = null;
			}
		}
		nint num3 = (nint)this;
		object obj3 = this + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v49 @ S1_v8 (Il2CppClass<UIProgressBar>)+F4] (should have been resolved before IL gen)");
	}

	protected virtual void Upgrade()
	{
	}

	protected virtual void OnStart()
	{
	}

	protected void Update()
	{
		//IL_001e: Expected I, but got Obj
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		if (~(mIsDirty ? 1u : 0u) == 0)
		{
			nint num = (nint)this;
			object obj = this + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v6 @ S1_v3 (Il2CppClass<UIProgressBar>)+F4] (should have been resolved before IL gen)");
		}
	}

	protected void OnValidate()
	{
		//IL_000a: Expected I, but got Obj
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_01ae: Expected I, but got Obj
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected Obj, but got Unknown
		if (NGUITools.GetActive(this))
		{
			nint num = (nint)this;
			object obj = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v19 @ S1_v14 (Il2CppClass<UIProgressBar>)+DC] (should have been resolved before IL gen)");
			mIsDirty = true;
			float num2 = Math.Min(mValue, 1f);
			bool flag = mValue < 0f;
			float num3 = 0f;
			if (!flag)
			{
				num3 = num2;
			}
			if (mValue != num3)
			{
				mValue = num3;
			}
			bool flag2 = numberOfSteps >= 0;
			bool flag3 = !flag2;
			int num4 = 0;
			if (!flag3)
			{
				bool flag4 = numberOfSteps < 21;
				num4 = 20;
				if (flag4)
				{
					goto IL_01a9;
				}
			}
			numberOfSteps = num4;
			goto IL_01a9;
		}
		float num5 = Math.Min(mValue, 1f);
		bool flag5 = mValue < 0f;
		float num6 = 0f;
		if (!flag5)
		{
			num6 = num5;
		}
		if (mValue != num6)
		{
			mValue = num6;
		}
		if (numberOfSteps <= -1)
		{
			numberOfSteps = 0;
		}
		else if (numberOfSteps >= 21)
		{
			numberOfSteps = 20;
		}
		return;
		IL_01a9:
		nint num7 = (nint)this;
		object obj2 = this + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v102 @ S1_v24 (Il2CppClass<UIProgressBar>)+F4] (should have been resolved before IL gen)");
	}

	protected unsafe float ScreenToValue(Vector2 screenPos)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_025b: Expected I, but got Obj
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected VT, but got Unknown
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected VT, but got Unknown
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected VT, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected VT, but got Unknown
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected VT, but got Unknown
		//IL_0370: Expected native int or pointer, but got VT
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected VT, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected VT, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected VT, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Ref, but got Unknown
		//IL_014b: Expected Ref, but got VT
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected VT, but got Unknown
		//IL_01a5: Expected F4, but got I
		//IL_01a5: Expected Ref, but got VT
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected VT, but got Unknown
		//IL_021e: Expected Obj, but got I
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected Obj, but got Unknown
		//IL_0231: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 288;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Transform transform = cachedTransform;
		Quaternion rotation = transform.rotation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v18 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v19 (Il2CppStaticFields<UnityEngine.Vector3>)+5C]");
		_ = 0;
		_ = Vector3.backVector;
		Quaternion quaternion = (Quaternion)(obj + 112);
		Vector3 vector = (Vector3)(obj + 96);
		Vector3 vector2 = quaternion * vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		_ = 0;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		_ = 0;
		Plane plane = (Plane)(obj + 272);
		Vector3 inNormal = (Vector3)(obj + 80);
		Vector3 inPoint = (Vector3)(obj - -64);
		*(Plane*)(nint)plane = new Plane(inNormal, inPoint);
		Camera camera = cachedCamera;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A0]");
		_ = 0;
		_ = screenPos.x;
		_ = screenPos.x;
		Vector3 pos = (Vector3)(obj + 48);
		Ray ray = camera.ScreenPointToRay(pos);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		_ = 0;
		Plane plane2 = (Plane)(obj + 272);
		Ray ray2 = (Ray)(obj + 24);
		if (!((Plane*)plane2)->Raycast(ray2, out *(float*)(obj + 244)))
		{
			return value;
		}
		Ray ray3 = (Ray)(obj + 248);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F4]");
		Vector3 point = ((Ray*)ray3)->GetPoint(0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		_ = 0;
		Vector3 position2 = (Vector3)(obj + 8);
		Vector3 vector3 = transform.InverseTransformPoint(position2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		obj = 0;
		object obj3 = obj - 16;
		nint num3 = (nint)this;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v240 @ S0_v75 (Il2CppClass<UIProgressBar>)+EC] (should have been resolved before IL gen)");
		float result = default;
		return result;
	}

	protected virtual float LocalToValue(Vector2 localPos)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0025: Expected I, but got Obj
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0074: Expected Obj, but got I
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_00a6: Expected Obj, but got I
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		//IL_018f: Expected Obj, but got I4
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_0111: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 32;
		float num4;
		if (mFG != null)
		{
			UIWidget uIWidget = mFG;
			nint num = (nint)uIWidget;
			object obj3 = uIWidget + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S2_v4 (Il2CppClass<UIWidget>)+104] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v9+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v9+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v9+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v9+10]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			object obj4 = 0 - obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			object obj5 = num2 - 0;
			object obj7 = default;
			if (mFill < FillDirection.BottomToTop)
			{
				object obj6 = obj7 + 16;
				float num3 = localPos.x - (float)obj6;
				num4 = num3 / (float)obj4;
				object obj8 = mFill & (FillDirection)(-3);
				if ((nint)obj8 == 1)
				{
					num4 = 1f - num4;
				}
			}
			else
			{
				object obj9 = obj7 + 16;
				float num5 = localPos.y;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v25+4]");
				float num6 = num5 - 0f;
				num4 = num6 / (float)obj5;
				object obj10 = mFill & (FillDirection)(-3);
				if ((nint)obj10 == 1)
				{
					num4 = 1f - num4;
				}
			}
		}
		else
		{
			num4 = value;
		}
		return num4;
	}

	public virtual void ForceUpdate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afe: Expected Obj, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Obj, but got Unknown
		//IL_02e7: Expected Obj, but got I4
		//IL_01fb: Expected I, but got Obj
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_0159: Expected Obj, but got I4
		//IL_0d50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d55: Expected VT, but got Unknown
		//IL_007b: Expected I, but got Obj
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_0d9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da1: Expected Obj, but got Unknown
		//IL_0c25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2a: Expected VT, but got Unknown
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected Obj, but got Unknown
		//IL_0471: Expected I, but got Obj
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected Obj, but got Unknown
		//IL_0ddd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de2: Expected Obj, but got Unknown
		//IL_0df2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df7: Expected Obj, but got Unknown
		//IL_0e08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0d: Expected Obj, but got Unknown
		//IL_0e1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e22: Expected Obj, but got Unknown
		//IL_0e33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e38: Expected Obj, but got Unknown
		//IL_0e48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4d: Expected Obj, but got Unknown
		//IL_0e5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e63: Expected Obj, but got Unknown
		//IL_0e73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e78: Expected Obj, but got Unknown
		//IL_0e89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8e: Expected Obj, but got Unknown
		//IL_0eab: Expected Obj, but got I
		//IL_0eb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebe: Expected Obj, but got Unknown
		//IL_0edb: Expected Obj, but got I
		//IL_0ee9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eee: Expected Obj, but got Unknown
		//IL_0f0b: Expected Obj, but got I
		//IL_0f19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1e: Expected Obj, but got Unknown
		//IL_0f3b: Expected Obj, but got I
		//IL_0f46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4b: Expected Obj, but got Unknown
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected Obj, but got Unknown
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected Obj, but got Unknown
		//IL_0cfb: Invalid comparison between F4 and I
		//IL_0caa: Expected Obj, but got I4
		//IL_0bca: Invalid comparison between F4 and I
		//IL_0f87: Expected Obj, but got I4
		//IL_0b79: Expected Obj, but got I4
		//IL_0873: Expected Obj, but got I
		//IL_08b7: Expected Obj, but got I
		//IL_08fb: Expected Obj, but got I
		//IL_0973: Expected Obj, but got I
		//IL_09b7: Expected Obj, but got I
		//IL_09fb: Expected Obj, but got I
		//IL_0a32: Expected Obj, but got I4
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected Obj, but got Unknown
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Expected VT, but got Unknown
		//IL_0540: Expected Obj, but got I
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected Obj, but got Unknown
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected Obj, but got Unknown
		//IL_0603: Expected Obj, but got I
		//IL_0647: Expected Obj, but got I
		//IL_068b: Expected Obj, but got I
		//IL_0703: Expected Obj, but got I
		//IL_0747: Expected Obj, but got I
		//IL_078b: Expected Obj, but got I
		//IL_07c2: Expected Obj, but got I4
		//IL_114a: Unknown result type (might be due to invalid IL or missing references)
		//IL_114f: Expected Obj, but got Unknown
		//IL_1193: Unknown result type (might be due to invalid IL or missing references)
		//IL_1198: Expected VT, but got Unknown
		//IL_1072: Unknown result type (might be due to invalid IL or missing references)
		//IL_1077: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 224;
		mIsDirty = false;
		bool flag7 = default;
		if (mFG != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			bool flag = mFill < FillDirection.BottomToTop;
			UnityEngine.Object obj3 = default;
			bool flag2 = obj3 != null;
			if (flag)
			{
				if (flag2)
				{
					nint num = (nint)obj3;
					object obj4 = obj3 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v196 @ S1_v282 (Il2CppClass<UnityEngine.Object>)+1F4] (should have been resolved before IL gen)");
					object obj5 = default;
					if ((nint)obj5 == 3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v209 (UnityEngine.Object)+11C]");
						if ((nint)0 <= (nint)1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v209 (UnityEngine.Object)+11C]");
							if ((nint)0 != 0)
							{
								_ = 1;
								_ = 0;
							}
							object obj6 = mFill & (FillDirection)(-3);
							bool flag3 = (nint)obj6 == 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v209 (UnityEngine.Object)+124]");
							if ((nint)0 != (flag3 ? 1 : 0))
							{
								_ = 1;
							}
						}
						float num2 = value;
						float num3 = Math.Min(num2, 1f);
						bool flag4 = num2 < 0f;
						float num4 = 0f;
						if (!flag4)
						{
							num4 = num3;
						}
						float num5 = num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v209 (UnityEngine.Object)+120]");
						if (num5 != 0f)
						{
							_ = 1;
						}
						goto IL_0af3;
					}
				}
				object obj7 = mFill & (FillDirection)(-3);
				bool flag5 = (nint)obj7 == 1;
				float num6 = value;
				if (flag5)
				{
					float num7 = 1f - num6;
					float num8 = num7;
					float num9 = 1f;
				}
				else
				{
					float num9 = num6;
				}
				_ = 1065353216;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D8]");
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D0]");
				_ = 0;
				Vector4 drawRegion = (Vector4)(obj + 48);
				mFG.drawRegion = drawRegion;
				mFG.enabled = true;
				float num10 = value;
				bool flag6 = num10 < 0.001f;
				flag7 = flag6;
			}
			else
			{
				if (flag2)
				{
					nint num11 = (nint)obj3;
					object obj8 = obj3 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v223 @ S1_v235 (Il2CppClass<UnityEngine.Object>)+1F4] (should have been resolved before IL gen)");
					object obj9 = default;
					if ((nint)obj9 == 3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v209 (UnityEngine.Object)+11C]");
						if ((nint)0 <= (nint)1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v209 (UnityEngine.Object)+11C]");
							if ((nint)0 != 1)
							{
								_ = 1;
								_ = 1;
							}
							object obj10 = mFill & (FillDirection)(-3);
							bool flag8 = (nint)obj10 == 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v209 (UnityEngine.Object)+124]");
							if ((nint)0 != (flag8 ? 1 : 0))
							{
								_ = 1;
							}
						}
						float num12 = value;
						float num13 = Math.Min(num12, 1f);
						bool flag9 = num12 < 0f;
						float num14 = 0f;
						if (!flag9)
						{
							num14 = num13;
						}
						float num15 = num14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v209 (UnityEngine.Object)+120]");
						if (num15 != 0f)
						{
							_ = 1;
						}
						goto IL_0af3;
					}
				}
				object obj11 = mFill & (FillDirection)(-3);
				bool flag10 = (nint)obj11 == 1;
				float num16 = value;
				_ = 1065353216;
				if (flag10)
				{
					float num17 = 1f - num16;
					float num8 = num17;
					float num18 = 1f;
				}
				else
				{
					float num18 = num16;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C8]");
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
				_ = 0;
				Vector4 drawRegion2 = (Vector4)(obj - -64);
				mFG.drawRegion = drawRegion2;
				mFG.enabled = true;
				float num19 = value;
				bool flag11 = num19 < 0.001f;
				flag7 = flag11;
			}
		}
		goto IL_0af3;
		IL_0af3:
		object obj12 = this + 24;
		if (thumb != null && ((UnityEngine.Object)obj12 != null || mBG != null))
		{
			object obj13 = this + 20;
			bool flag12 = mFG == null;
			object obj14 = obj12;
			if (flag12)
			{
				obj14 = obj13;
			}
			object obj15 = obj14;
			object obj16 = obj15;
			object obj17 = obj15 + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v423 @ S1_v17+104] (should have been resolved before IL gen)");
			if (mFG != null)
			{
				object obj18 = obj + 176;
				object obj19 = obj12;
				object obj20 = obj19;
				object obj21 = obj19 + 256;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v473 @ S2_v83+1BC] (should have been resolved before IL gen)");
			}
			else
			{
				object obj22 = obj + 176;
				UIWidget uIWidget = mBG;
				nint num20 = (nint)uIWidget;
				object obj23 = uIWidget + 256;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v488 @ S2_v79 (Il2CppClass<UIWidget>)+1BC] (should have been resolved before IL gen)");
			}
			object obj25 = default;
			object obj24 = obj25 + 16;
			object obj26 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
			object obj27 = obj26 + 0;
			obj24 = obj27;
			object obj28 = obj25 + 28;
			object obj29 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
			object obj30 = obj29 + 0;
			obj28 = obj30;
			object obj31 = obj25 + 40;
			object obj32 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
			object obj33 = obj32 - 0;
			obj31 = obj33;
			object obj34 = obj25 + 52;
			object obj35 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
			object obj36 = obj35 - 0;
			obj34 = obj36;
			object obj37 = obj25 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ S0_v70+4]");
			nint num21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B4]");
			object obj38 = num21 + 0;
			object obj39 = obj25 + 28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ S0_v72+4]");
			nint num22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+BC]");
			object obj40 = num22 - 0;
			object obj41 = obj25 + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ S0_v74+4]");
			nint num23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+BC]");
			object obj42 = num23 - 0;
			object obj43 = obj25 + 52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ S0_v76+4]");
			nint num24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B4]");
			object obj44 = num24 + 0;
			object obj45 = this + 20;
			bool flag13 = mFG == null;
			object obj46 = obj12;
			if (flag13)
			{
				obj46 = obj45;
			}
			Transform transform = ((UIRect)obj46).cachedTransform;
			object obj47 = 0;
			while ((nint)obj47 < 4)
			{
				object obj48 = obj47 * 12;
				object obj49 = obj25 + obj48;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ S1_v178+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ S1_v178+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
				_ = 0;
				Vector3 position = (Vector3)(obj + 16);
				Vector3 vector = transform.TransformPoint(position);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A0]");
				obj = 0;
				object obj50 = obj47 * 12;
				object obj51 = obj25 + obj50;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				object obj52 = obj47 + 1;
				obj47 = obj52;
			}
			if (mFill < FillDirection.BottomToTop)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v47+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v47+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v47+24]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v47+1C]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A0]");
				nint num25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
				object obj53 = num25 - 0;
				float num26 = (float)obj53 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
				float num27 = 0f + num26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A4]");
				nint num28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B4]");
				object obj54 = num28 - 0;
				float num29 = (float)obj54 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B4]");
				float num30 = 0f + num29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
				nint num31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
				object obj55 = num31 - 0;
				float num32 = (float)obj55 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
				float num33 = 0f + num32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v47+30]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v47+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v47+3C]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v47+34]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
				nint num34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
				object obj56 = num34 - 0;
				float num35 = (float)obj56 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
				float num36 = 0f + num35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+74]");
				nint num37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+84]");
				object obj57 = num37 - 0;
				float num38 = (float)obj57 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+84]");
				float num39 = 0f + num38;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
				nint num40 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
				object obj58 = num40 - 0;
				float num41 = (float)obj58 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
				float num42 = 0f + num41;
				object obj59 = mFill & (FillDirection)(-3);
				bool flag14 = (nint)obj59 == 1;
				float num43 = value;
				float num44 = num36 - num27;
				float num45 = 1f - num43;
				if (!flag14)
				{
					num45 = num43;
				}
				float num46 = Math.Min(num45, 1f);
				bool flag15 = num45 < 0f;
				float num47 = 0f;
				if (!flag15)
				{
					num47 = num46;
				}
				float num48 = num44 * num47;
				float num49 = num27 + num48;
				float num50 = num39 - num30;
				float num51 = num50 * num47;
				float num52 = num30 + num51;
				float num53 = num42 - num33;
				float num54 = num53 * num47;
				float num55 = num33 + num54;
				object obj60 = obj + 96;
				float num56 = num55;
				float num57 = num52;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v47+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v47+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v47+3C]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v47+34]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A0]");
				nint num58 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
				object obj61 = num58 - 0;
				float num59 = (float)obj61 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
				float num60 = 0f + num59;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A4]");
				nint num61 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B4]");
				object obj62 = num61 - 0;
				float num62 = (float)obj62 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B4]");
				float num63 = 0f + num62;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
				nint num64 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
				object obj63 = num64 - 0;
				float num65 = (float)obj63 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
				float num66 = 0f + num65;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v47+24]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v47+1C]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v47+30]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v47+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
				nint num67 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
				object obj64 = num67 - 0;
				float num68 = (float)obj64 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
				float num69 = 0f + num68;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+74]");
				nint num70 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+84]");
				object obj65 = num70 - 0;
				float num71 = (float)obj65 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+84]");
				float num72 = 0f + num71;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
				nint num73 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
				object obj66 = num73 - 0;
				float num74 = (float)obj66 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
				float num75 = 0f + num74;
				object obj67 = mFill & (FillDirection)(-3);
				bool flag16 = (nint)obj67 == 1;
				float num76 = value;
				float num77 = num69 - num60;
				float num78 = 1f - num76;
				if (!flag16)
				{
					num78 = num76;
				}
				float num79 = Math.Min(num78, 1f);
				bool flag17 = num78 < 0f;
				float num80 = 0f;
				if (!flag17)
				{
					num80 = num79;
				}
				float num81 = num77 * num80;
				float num82 = num60 + num81;
				float num83 = num72 - num63;
				float num84 = num83 * num80;
				float num85 = num63 + num84;
				float num86 = num75 - num66;
				float num87 = num86 * num80;
				float num88 = num66 + num87;
				object obj60 = obj + 80;
				float num56 = num88;
				float num57 = num85;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ S0_v92+8]");
			_ = 0;
			Vector3 thumbPosition = (Vector3)(obj + 32);
			SetThumbPosition(thumbPosition);
		}
		if (flag7)
		{
			((Behaviour)obj12).enabled = false;
		}
	}

	protected unsafe void SetThumbPosition(Vector3 worldPos)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected VT, but got Unknown
		//IL_0074: Expected F4, but got I
		//IL_006f: Expected native int or pointer, but got VT
		//IL_0089: Expected F4, but got I
		//IL_0084: Expected native int or pointer, but got VT
		//IL_00a0: Expected native int or pointer, but got VT
		//IL_00b8: Expected native int or pointer, but got VT
		//IL_00c5: Expected native int or pointer, but got VT
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected VT, but got Unknown
		//IL_00f0: Expected native int or pointer, but got VT
		//IL_0102: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj + -64);
		Transform parent = thumb.parent;
		if (parent != null)
		{
			_ = worldPos.z;
			_ = worldPos.x;
			Vector3 position = vector + 16;
			Vector3 vector2 = parent.InverseTransformPoint(position);
			Vector3 vector3 = worldPos;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			((Vector3*)(nint)vector3)->z = 0f;
			Vector3 vector4 = worldPos;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			((Vector3*)(nint)vector4)->x = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
			float num = default;
			((Vector3*)(nint)worldPos)->x = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
			((Vector3*)(nint)worldPos)->z = 0f;
			float num2 = default;
			((Vector3*)(nint)worldPos)->y = num2;
			Vector3 localPosition = thumb.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			float num3 = 0f - num;
			float num4 = num3 * num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+34]");
			float num5 = 0f - num2;
			float num6 = num5 * num5;
			float num7 = num4 + num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			float num8 = 0f - 0f;
			float num9 = num8 * num8;
			float num10 = num7 + num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
			if (num10 > 0.001f)
			{
				((Vector3*)(nint)vector)->z = worldPos.z;
				((Vector3*)(nint)vector)->x = worldPos.x;
				thumb.localPosition = vector;
			}
		}
		else
		{
			Vector3 position2 = thumb.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			float num11 = 0f - worldPos.x;
			float num12 = num11 * num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+34]");
			float num13 = 0f - worldPos.y;
			float num14 = num13 * num13;
			float num15 = num12 + num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			float num16 = 0f - worldPos.z;
			float num17 = num16 * num16;
			float num18 = num15 + num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
			if (num18 > 1E-05f)
			{
				_ = worldPos.z;
				_ = worldPos.x;
				Vector3 position3 = vector + 32;
				thumb.position = position3;
			}
		}
	}

	public virtual void OnPan(Vector2 delta)
	{
		if (!enabled)
		{
			return;
		}
		float num7;
		if (mFill != FillDirection.LeftToRight)
		{
			if (mFill != FillDirection.RightToLeft)
			{
				if (mFill != FillDirection.BottomToTop)
				{
					if (mFill == FillDirection.TopToBottom)
					{
						float num = mValue - delta.y;
						float num2 = Math.Min(num, 1f);
						bool flag = num < 0f;
						float num3 = 0f;
						if (!flag)
						{
							num3 = num2;
						}
						value = num3;
						mValue = num3;
					}
					return;
				}
				float num4 = mValue + delta.y;
				float num5 = Math.Min(num4, 1f);
				bool flag2 = num4 < 0f;
				float num6 = 0f;
				if (!flag2)
				{
					num6 = num5;
				}
				value = num6;
				num7 = num6;
			}
			else
			{
				float num8 = mValue - delta.x;
				float num9 = Math.Min(num8, 1f);
				bool flag3 = num8 < 0f;
				float num10 = 0f;
				if (!flag3)
				{
					num10 = num9;
				}
				value = num10;
				num7 = num10;
			}
		}
		else
		{
			float num11 = mValue + delta.x;
			float num12 = Math.Min(num11, 1f);
			bool flag4 = num11 < 0f;
			float num13 = 0f;
			if (!flag4)
			{
				num13 = num12;
			}
			value = num13;
			num7 = num13;
		}
		mValue = num7;
	}

	public UIProgressBar()
	{
		List<EventDelegate> list = default;
		list._002Ector();
		onChange = list;
		base._002Ector();
	}
}

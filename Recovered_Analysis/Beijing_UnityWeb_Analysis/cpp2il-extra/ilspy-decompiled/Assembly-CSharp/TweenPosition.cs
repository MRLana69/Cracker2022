using System;
using Cpp2ILInjected;
using UI.Pages;
using UnityEngine;
using UnityEngine.UI;

public class TweenPosition : UITweener
{
	public Vector3 from;

	public Vector3 to;

	public bool worldSpace;

	private Transform mTrans;

	private UIRect mRect;

	public Transform cachedTransform
	{
		get
		{
			//IL_0082: Expected I, but got Obj
			//IL_0098: Expected Obj, but got I
			//IL_00d4: Expected Obj, but got I
			//IL_00c2: Expected Obj, but got I
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenPosition)+60]");
			if ((UnityEngine.Object)0 != null)
			{
				object obj2 = this + 96;
				Camera component = GetComponent<Camera>();
				obj2 = component;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenPosition)+60]");
			return (Transform)0;
		}
	}

	public Vector3 position
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_029d: Expected Obj, but got Unknown
			//IL_02b7: Expected Obj, but got I
			//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f3: Expected Obj, but got Unknown
			//IL_0303: Expected Obj, but got I
			//IL_0313: Unknown result type (might be due to invalid IL or missing references)
			//IL_0318: Expected Obj, but got Unknown
			//IL_033f: Expected Obj, but got I4
			//IL_0390: Expected Obj, but got I
			//IL_003e: Expected Obj, but got I4
			//IL_0359: Expected Obj, but got I
			//IL_01d2: Expected Obj, but got I
			//IL_01e8: Expected Obj, but got I
			//IL_0242: Expected Obj, but got I
			//IL_0279: Unknown result type (might be due to invalid IL or missing references)
			//IL_027e: Expected Obj, but got Unknown
			//IL_0059: Expected Obj, but got I
			//IL_0092: Expected Obj, but got I
			//IL_00d6: Expected Obj, but got I
			//IL_010a: Expected F4, but got I
			//IL_0129: Expected Obj, but got I
			//IL_0162: Expected Obj, but got I
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+70]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2+10]");
			if ((nint)0 != 0)
			{
				object obj2 = 0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+6C]");
					object obj3 = 0;
					object obj4 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v35+C]");
					if ((nint)obj4 >= 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+6C]");
					object obj5 = (nint)0 + (nint)16;
					object obj6 = obj2 << 2;
					object obj7 = obj5 + obj6;
					object obj8 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+70]");
					object obj9 = (nint)0 + (nint)20;
					float num = (float)obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+20]");
					float viewSize = num * 0f;
					float num2 = ScrollRect.RubberDelta(0f, viewSize);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+70]");
					object obj10 = (nint)0 + (nint)20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v44+4]");
					float num3 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+20]");
					float overStretching = num3 * 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+20]");
					float num4 = ScrollRect.RubberDelta(overStretching, 0f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+6C]");
					object obj11 = (nint)0 + (nint)16;
					object obj12 = obj2 << 2;
					object obj13 = obj11 + obj12;
					object obj14 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+6C]");
					object obj15 = (nint)0 + (nint)16;
					object obj16 = obj2 << 2;
					object obj17 = obj15 + obj16;
					object obj18 = obj17;
					float num5 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S2_v30+8]");
					float num6 = num5 - 0f;
					object obj19 = obj2 + 1;
					obj2 = obj19;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+20]");
				object obj20 = 0 / this;
				object obj21 = obj20 * (object)this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+70]");
				object obj22 = 0;
				float num7 = 1f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v3+C]");
				float num8 = num7 - 0f;
				float num9 = (float)obj21 * num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+20]");
				object obj23 = 0 * obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+70]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S3_v3+C]");
				object obj25 = obj20 * 0;
				float num10 = num9 + (float)obj25;
				float num11 = (float)obj23 / num10;
				object obj26 = 0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+6C]");
					object obj27 = 0;
					object obj28 = obj26;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v11+C]");
					if ((nint)obj28 >= 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+6C]");
					object obj29 = (nint)0 + (nint)16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+68]");
					object obj30 = (nint)0 + (nint)16;
					object obj31 = obj26 << 2;
					object obj32 = obj30 + obj31;
					object obj33 = obj32 << 2;
					object obj34 = obj29 + obj33;
					object obj35 = obj34;
					_ = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+6C]");
					object obj36 = (nint)0 + (nint)16;
					object obj37 = obj32 << 2;
					object obj38 = obj36 + obj37;
					object obj39 = obj38;
					object obj40 = obj26 + 1;
					obj26 = obj40;
				}
			}
			Vector3 result = default;
			return result;
		}
		set
		{
			this.value = value;
		}
	}

	public Vector3 value
	{
		get
		{
			((UnityEngine.Object)this).m_CachedPtr = ((UnityEngine.Object)this).m_CachedPtr;
			Quaternion rotation = ((TweenRotation)this).rotation;
			Vector3 result = default;
			return result;
		}
		set
		{
			//IL_0023: Expected Obj, but got VT
			//IL_0059: Expected VT, but got Obj
			//IL_004a: Expected VT, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Vector3)+70]");
			bool flag = (nint)0 != 0;
			Transform transform = ((TweenRotation)value).cachedTransform;
			if (flag)
			{
				((Transform)(object)this).position = (Vector3)transform;
			}
			else
			{
				((Transform)(object)this).localPosition = (Vector3)transform;
			}
		}
	}

	private void Awake()
	{
		//IL_000b: Expected VT, but got F4
		from = (Vector3)1f;
		_ = 1f;
		((UI2DSprite)(object)this).OnUpdate();
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
		float num = 1f - factor;
		float num2 = (float)from * num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenPosition)+5C]");
		float num3 = 0f * factor;
		float volume = num2 + num3;
		((TweenVolume)this).volume = volume;
	}

	public static TweenPosition Begin(GameObject go, float duration, Vector3 pos)
	{
		//IL_0071: Expected I4, but got VT
		//IL_0018: Expected Obj, but got I4
		string go2 = ((Component)(object)go).tag;
		TweenHeight tweenHeight = UITweener.Begin<TweenHeight>((GameObject)(object)go2, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L0 (UnityEngine.GameObject)+68]");
		tweenHeight.from = 0;
		tweenHeight.to = (int)pos;
		if (!(duration > 0f))
		{
			((PageTop)(object)tweenHeight).Delay(1f, (Action)1);
			tweenHeight.tag = null;
		}
		return (TweenPosition)(object)tweenHeight;
	}

	public static TweenPosition Begin(GameObject go, float duration, Vector3 pos, bool worldSpace)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	public override void SetStartToCurrentValue()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 120;
		UIRect component = GetComponent<UIRect>();
		obj = component;
	}

	public override void SetEndToCurrentValue()
	{
		//IL_000a: Expected VT, but got Obj
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		TweenPosition tweenPosition = default;
		tweenPosition.value = (Vector3)this;
		object obj = tweenPosition + 12;
		obj = tweenPosition;
		_ = ((UnityEngine.Object)tweenPosition).m_CachedPtr;
		object obj2 = this + 88;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6+8]");
		_ = 0;
	}

	private void SetCurrentValueToStart()
	{
		//IL_000a: Expected VT, but got Obj
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		TweenPosition tweenPosition = default;
		tweenPosition.value = (Vector3)this;
		object obj = tweenPosition + 12;
		obj = tweenPosition;
		_ = ((UnityEngine.Object)tweenPosition).m_CachedPtr;
		object obj2 = this + 100;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6+8]");
		_ = 0;
	}

	private void SetCurrentValueToEnd()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		object obj = this + 88;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S1_v3+8]");
		_ = 0;
		TweenRotation tweenRotation = (TweenRotation)(obj2 + 12);
		tweenRotation = (TweenRotation)obj2;
		TweenRotation tweenRotation2 = tweenRotation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)tweenRotation2).m_CachedPtr = (IntPtr)0;
		Quaternion rotation = tweenRotation.rotation;
	}

	public TweenPosition()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		object obj = this + 100;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S1_v3+8]");
		_ = 0;
		TweenRotation tweenRotation = (TweenRotation)(obj2 + 12);
		tweenRotation = (TweenRotation)obj2;
		TweenRotation tweenRotation2 = tweenRotation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)tweenRotation2).m_CachedPtr = (IntPtr)0;
		Quaternion rotation = tweenRotation.rotation;
	}
}

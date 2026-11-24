using System;
using AnimationOrTween;
using Cpp2ILInjected;
using SYBO.Subway.Characters;
using UnityEngine;

public class TweenWidth : UITweener
{
	public int from;

	public int to;

	public bool updateTable;

	private UIWidget mWidget;

	private UITable mTable;

	public UIWidget cachedWidget
	{
		get
		{
			//IL_0244: Expected I, but got Obj
			//IL_025a: Expected Obj, but got I
			//IL_02f3: Expected Obj, but got I4
			//IL_027e: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected Obj, but got Unknown
			//IL_007d: Expected I, but got Obj
			//IL_0093: Expected Obj, but got I
			//IL_028a: Expected Obj, but got I4
			//IL_00be: Expected I, but got Obj
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Expected Obj, but got Unknown
			//IL_0128: Expected I, but got Obj
			//IL_013e: Expected Obj, but got I
			//IL_02b3: Expected Obj, but got I4
			//IL_0169: Expected I, but got Obj
			//IL_01b6: Expected I, but got Obj
			//IL_01cc: Expected Obj, but got I
			//IL_01f7: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v38 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((UnityEngine.Object)updateTable != null)
			{
				object obj2 = this + 96;
				AudioSource component = GetComponent<AudioSource>();
				obj2 = component;
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v34 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((UnityEngine.Object)updateTable != null)
				{
					object obj4 = this + 96;
					AudioSource component2 = GetComponent<AudioSource>();
					obj4 = component2;
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num6 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if ((UnityEngine.Object)updateTable != null)
					{
						nint num7 = (nint)typeof(Debug);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v22 (Il2CppClass<UnityEngine.Debug>)+BA]");
						object obj6 = (nint)0 & (nint)0x200;
						if (obj6 != null)
						{
							nint num8 = (nint)typeof(Debug);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v29 (Il2CppClass<UnityEngine.Debug>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Debug.LogErrorFormat("TweenVolume needs an AudioSource to work with", (object[])(object)this);
						tag = null;
					}
				}
			}
			return (UIWidget)updateTable;
		}
	}

	public unsafe int width
	{
		get
		{
			//IL_0082: Expected I, but got Obj
			//IL_0098: Expected Obj, but got I
			//IL_00bc: Expected I4, but got Obj
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
			if (mWidget != null)
			{
				object obj2 = this + 100;
				UIWidget component = GetComponent<UIWidget>();
				obj2 = component;
			}
			return (int)mWidget;
		}
		set
		{
			//IL_000d: Expected Obj, but got I4
			TweenScale tweenScale = (TweenScale)((int*)value)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Int32)+8]");
			((UnityEngine.Object)tweenScale).m_CachedPtr = (IntPtr)0;
			Vector3 scale = tweenScale.scale;
		}
	}

	public int value
	{
		get
		{
			return (int)direction;
		}
		set
		{
			//IL_000a: Expected Obj, but got I4
			SetOnFinished((EventDelegate.Callback)value);
		}
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
		//IL_0056: Expected Obj, but got I4
		//IL_007d: Expected Obj, but got I4
		//IL_007d: Expected Obj, but got I4
		float num = 1f - factor;
		float num2 = (float)from * num;
		float num3 = (float)to * factor;
		float num4 = num2 + num3;
		tweenFactor = num4;
		float pitch = ((AudioSource)updateTable).pitch;
		bool flag = pitch > 0.01f;
		((Component)updateTable).tag = (string)flag;
	}

	public static TweenWidth Begin(UIWidget widget, float duration, int width)
	{
		//IL_0012: Expected Obj, but got I4
		return (TweenWidth)((Character.OnTutorialMoveBackToCheckPointDelegate)(object)widget).BeginInvoke(duration, (AsyncCallback)null, (object)width);
	}

	public override void SetStartToCurrentValue()
	{
		//IL_000b: Expected I4, but got F4
		//IL_0016: Expected I4, but got F4
		from = 1;
		to = 1;
		((UI2DSprite)(object)this).OnUpdate();
	}

	public override void SetEndToCurrentValue()
	{
		Direction direction = base.direction;
		from = (int)direction;
	}

	private void SetCurrentValueToStart()
	{
		Direction direction = base.direction;
		to = (int)direction;
	}

	private void SetCurrentValueToEnd()
	{
		//IL_000c: Expected Obj, but got I4
		SetOnFinished((EventDelegate.Callback)from);
	}

	public TweenWidth()
	{
		//IL_000c: Expected Obj, but got I4
		SetOnFinished((EventDelegate.Callback)to);
	}
}

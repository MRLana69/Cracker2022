using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UI.Pages;
using UnityEngine;

public class TweenHeight : UITweener
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
			//IL_0082: Expected I, but got Obj
			//IL_0098: Expected Obj, but got I
			//IL_00c8: Expected Obj, but got I4
			//IL_00bc: Expected Obj, but got I4
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
			if ((UnityEngine.Object)updateTable != null)
			{
				object obj2 = this + 96;
				Camera component = GetComponent<Camera>();
				obj2 = component;
			}
			return (UIWidget)updateTable;
		}
	}

	public unsafe int height
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
			//IL_001e: Expected I, but got Obj
			//IL_0034: Expected Obj, but got I
			//IL_040b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0410: Expected I4, but got Unknown
			//IL_0419: Unknown result type (might be due to invalid IL or missing references)
			//IL_041e: Expected Obj, but got Unknown
			//IL_0430: Expected Obj, but got I
			//IL_00e5: Expected I, but got Obj
			//IL_00fb: Expected Obj, but got I
			//IL_005f: Expected I, but got Obj
			//IL_0463: Expected Obj, but got I
			//IL_00d2: Expected Obj, but got I
			//IL_01ac: Expected I, but got Obj
			//IL_01c2: Expected Obj, but got I
			//IL_0126: Expected I, but got Obj
			//IL_0497: Expected Obj, but got I
			//IL_0199: Expected Obj, but got I4
			//IL_0199: Expected Obj, but got I
			//IL_0273: Expected I, but got Obj
			//IL_0289: Expected Obj, but got I
			//IL_01ed: Expected I, but got Obj
			//IL_04ca: Expected Obj, but got I
			//IL_0260: Expected Obj, but got I
			//IL_02b4: Expected I, but got Obj
			//IL_0327: Expected Obj, but got I
			//IL_0353: Expected Obj, but got I4
			//IL_036d: Expected Obj, but got I4
			//IL_0394: Expected Obj, but got I
			//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a9: Expected Obj, but got Unknown
			//IL_03b2: Invalid comparison between Obj and F4
			//IL_03cd: Expected Obj, but got I4
			//IL_03cd: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenHeight)+78]");
			if ((nint)0 == 0)
			{
				((TweenColor)this).SetStartToCurrentValue();
			}
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v46 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = default;
			UIWidget.Pivot pivot = (UIWidget.Pivot)(obj2 + 32);
			object obj3 = obj2 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenHeight)+7C]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				((UIWidget.Pivot*)(int)pivot)->value__ = ((int*)value)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Int32)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenHeight)+7C]");
				((UIWidget)0).rawPivot = pivot;
				return;
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v51 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenHeight)+80]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				((UIWidget.Pivot*)(int)pivot)->value__ = ((int*)value)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Int32)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenHeight)+80]");
				((Material)0).mainTexture = (Texture)pivot;
				return;
			}
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v44 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenHeight)+88]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				((UIWidget.Pivot*)(int)pivot)->value__ = ((int*)value)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Int32)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenHeight)+88]");
				((SpriteRenderer)0).get_color_Injected(out *(Color*)(int)pivot);
				return;
			}
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v37 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenHeight)+84]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				((UIWidget.Pivot*)(int)pivot)->value__ = ((int*)value)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Int32)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenHeight)+84]");
				((Light)0).get_color_Injected(out *(Color*)(int)pivot);
				((UIWidget.Pivot*)(int)pivot)->value__ = ((int*)value)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Int32)+8]");
				_ = 0;
				obj3 = ((int*)value)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Int32)+8]");
				_ = 0;
				obj2 = ((int*)value)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Int32)+8]");
				_ = 0;
				int value__ = ((UIWidget.Pivot*)(int)pivot)->value__;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22+4]");
				object obj7 = (nint)value__ + (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				object obj8 = obj7 + 0;
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.01f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenHeight)+84]");
				((Component)0).tag = (string)flag;
			}
		}
	}

	public int value
	{
		get
		{
			//IL_000a: Expected I4, but got Obj
			return (int)((TweenOrthoSize)this).cachedCamera;
		}
		set
		{
			((TweenLetters)this).Play((byte)value != 0);
		}
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
		float num = 1f - factor;
		float num2 = (float)from * num;
		float num3 = (float)to * factor;
		float orthoSize = num2 + num3;
		((TweenOrthoSize)this).orthoSize = orthoSize;
	}

	public unsafe static TweenHeight Begin(UIWidget widget, float duration, int height)
	{
		//IL_004f: Expected VT, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_009f: Expected Obj, but got I4
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_0018: Expected Obj, but got I4
		TweenColor tweenColor = UITweener.Begin<TweenColor>((GameObject)(object)widget, duration);
		TweenColor tweenColor2 = default;
		tweenColor2.value = (Color)tweenColor;
		object obj = tweenColor2 + 16;
		obj = tweenColor2;
		_ = ((UnityEngine.Object)tweenColor2).m_CachedPtr;
		object obj2 = tweenColor + 88;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v10+8]");
		_ = 0;
		obj = ((int*)height)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [height @ L2 (System.Int32)+8]");
		_ = 0;
		object obj3 = tweenColor + 104;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v10+8]");
		_ = 0;
		if (!(duration > 0f))
		{
			((PageTop)(object)tweenColor).Delay(1f, (Action)1);
			tweenColor.tag = null;
		}
		return (TweenHeight)(object)tweenColor;
	}

	public override void SetStartToCurrentValue()
	{
		//IL_000b: Expected I4, but got F4
		//IL_0016: Expected I4, but got F4
		from = 45;
		to = 45;
		((UI2DSprite)(object)this).OnUpdate();
	}

	public override void SetEndToCurrentValue()
	{
		//IL_0014: Expected I4, but got Obj
		Camera cachedCamera = ((TweenOrthoSize)this).cachedCamera;
		from = (int)cachedCamera;
	}

	private void SetCurrentValueToStart()
	{
		//IL_0014: Expected I4, but got Obj
		Camera cachedCamera = ((TweenOrthoSize)this).cachedCamera;
		to = (int)cachedCamera;
	}

	private void SetCurrentValueToEnd()
	{
		((TweenLetters)this).Play((byte)from != 0);
	}

	public TweenHeight()
	{
		((TweenLetters)this).Play((byte)to != 0);
	}
}

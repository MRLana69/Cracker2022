using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class TweenAlpha : UITweener
{
	public float from;

	public float to;

	private bool mCached;

	private UIRect mRect;

	private Material mMat;

	private Light mLight;

	private SpriteRenderer mSr;

	private float mBaseIntensity;

	public float alpha
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0018: Expected F4, but got I
			object obj = this + 80;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			return 0f;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_001b: Invalid comparison between I and F4
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected Obj, but got Unknown
			object obj = this + 80;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			if (0f != value)
			{
				object obj2 = this + 80;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			}
		}
	}

	public float value
	{
		get
		{
			return ((TweenFill)this).value;
		}
		set
		{
			((TweenFill)this).value = value;
		}
	}

	private void Cache()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00ea: Expected I4, but got F4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v23 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		object obj3 = default;
		object obj2 = obj3 + 12;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj4 = this + 12;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v15+8]");
		_ = 0;
		ignoreTimeScale = true;
		CancelInvoke();
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
		//IL_02db: Expected I, but got Obj
		//IL_02f1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_012b: Expected I, but got Obj
		//IL_0141: Expected Obj, but got I
		//IL_016c: Expected I, but got Obj
		//IL_01b9: Expected I, but got Obj
		//IL_01cf: Expected Obj, but got I
		//IL_0377: Expected Obj, but got F4
		//IL_01fa: Expected I, but got Obj
		//IL_024d: Expected I, but got Obj
		//IL_0263: Expected Obj, but got I
		//IL_039f: Expected Obj, but got F4
		//IL_028e: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v46 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3;
		if (factor < 0f)
		{
			num3 = 0f;
		}
		else
		{
			num3 = ((!(factor > 1f)) ? factor : 1f);
		}
		if (delay == num3)
		{
			return;
		}
		float num4 = ((UIProgressBar)(object)this).alpha;
		delay = num3;
		if (~(steeperCurves ? 1u : 0u) != 0)
		{
			return;
		}
		float num5 = ((UIProgressBar)(object)this).alpha;
		if (num4 == num5)
		{
			return;
		}
		if (isFinished)
		{
			nint num6 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v25 (Il2CppClass<NGUITools>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num7 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v42 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (NGUITools.GetActive((GameObject)(object)this))
			{
				nint num8 = (nint)typeof(EventDelegate);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v16 (Il2CppClass<EventDelegate>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num9 = (nint)typeof(EventDelegate);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v33 (Il2CppClass<EventDelegate>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (Localization.LoadAndSelect((string)timeScale))
				{
					UIProgressBar.current = (UIProgressBar)(object)this;
					nint num10 = (nint)typeof(EventDelegate);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S1_v23 (Il2CppClass<EventDelegate>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num11 = (nint)typeof(EventDelegate);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v29 (Il2CppClass<EventDelegate>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Localization.dictionary = (Dictionary<string, string[]>)timeScale;
					UIProgressBar.current = null;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	public static TweenAlpha Begin(GameObject go, float duration, float alpha, float delay = 0f)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	public override void SetStartToCurrentValue()
	{
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected Obj, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected Obj, but got Unknown
		//IL_0328: Expected I, but got Obj
		//IL_033e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_010b: Expected I, but got Obj
		//IL_0121: Expected Obj, but got I
		//IL_01c1: Expected I, but got Obj
		//IL_01d7: Expected Obj, but got I
		//IL_014c: Expected I, but got Obj
		//IL_041b: Expected I, but got Obj
		//IL_0431: Expected Obj, but got I
		//IL_0202: Expected I, but got Obj
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected Obj, but got Unknown
		//IL_0274: Expected I, but got Obj
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		mCached = true;
		object obj = this + 100;
		UIRect component = GetComponent<UIRect>();
		obj = component;
		object obj2 = this + 112;
		SpriteRenderer component2 = GetComponent<SpriteRenderer>();
		obj2 = component2;
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v51 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(mRect != null))
		{
			return;
		}
		nint num3 = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v55 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(mSr != null))
		{
			return;
		}
		object obj5 = this + 108;
		Light component3 = GetComponent<Light>();
		obj5 = component3;
		nint num5 = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v51 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(mLight != null))
		{
			float bounceIntensity = mLight.bounceIntensity;
			mBaseIntensity = bounceIntensity;
			return;
		}
		Renderer component4 = GetComponent<Renderer>();
		nint num7 = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v32 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num8 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v46 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component4).FindKernel((string)null) != 0)
		{
			object obj8 = this + 104;
			Material sharedMaterial = component4.sharedMaterial;
			obj8 = sharedMaterial;
		}
		nint num9 = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num10 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v41 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (mMat != null)
		{
			object obj10 = this + 100;
			_0021_00210[] componentsInChildren = (_0021_00210[])(object)((Component)this).GetComponentsInChildren<T>();
			obj10 = componentsInChildren;
		}
	}

	public override void SetEndToCurrentValue()
	{
		float num = ((TweenFill)this).value;
		from = num;
	}

	public TweenAlpha()
	{
		float num = ((TweenFill)this).value;
		to = num;
	}
}

using Cpp2ILInjected;
using UnityEngine;

public class UISliderColors : MonoBehaviour
{
	public UISprite sprite;

	public Color[] colors;

	private UIProgressBar mBar;

	private UIBasicSprite mSprite;

	private void Start()
	{
		CancelInvoke();
	}

	private void Update()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0040: Expected Obj, but got VT
		object obj = this + 20;
		UIProgressBar component = GetComponent<UIProgressBar>();
		obj = component;
		object obj2 = this + 24;
		_0021_00210 componentInChildren = (_0021_00210)((Component)this).GetComponentInChildren<T>();
		obj2 = componentInChildren;
		this._002Ector();
	}

	public unsafe UISliderColors()
	{
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected Obj, but got Unknown
		//IL_038d: Expected Obj, but got I4
		//IL_03a1: Expected I, but got Obj
		//IL_03b7: Expected Obj, but got I
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected I4, but got Unknown
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Expected I4, but got Unknown
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected Obj, but got Unknown
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0089: Expected I, but got Obj
		//IL_009f: Expected Obj, but got I
		//IL_00ca: Expected I, but got Obj
		//IL_041c: Expected Obj, but got I4
		//IL_0439: Expected I, but got Obj
		//IL_044f: Expected Obj, but got I
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Expected Obj, but got Unknown
		//IL_0593: Expected I4, but got Obj
		//IL_05ad: Expected Obj, but got I4
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected Obj, but got Unknown
		//IL_0489: Expected I4, but got Obj
		//IL_04b0: Expected I4, but got Obj
		//IL_0147: Expected I, but got Obj
		//IL_0194: Expected Obj, but got I4
		//IL_034d: Expected Obj, but got I4
		//IL_0369: Expected I4, but got Obj
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_0254: Expected I4, but got Obj
		//IL_026e: Expected I4, but got Obj
		//IL_029f: Expected Ref, but got VT
		//IL_02ac: Expected Obj, but got F4
		//IL_04eb: Expected Obj, but got I4
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected Obj, but got Unknown
		//IL_0326: Expected I4, but got Obj
		Matrix4x4 matrix4x = default;
		object obj = matrix4x + 48;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v110 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIWidget.Pivot pivot = (UIWidget.Pivot)(matrix4x + 80);
		int num3 = matrix4x - -64;
		object obj3 = matrix4x + 32;
		object obj4 = matrix4x + 16;
		if (sprite != null)
		{
			return;
		}
		Color[] array = colors;
		if (array.Length == 0)
		{
			return;
		}
		nint num4 = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num5 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v106 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num6;
		if (((ComputeShader)(object)mBar).FindKernel((string)null) != 0)
		{
			num6 = mBar.alpha;
		}
		else
		{
			UIBasicSprite uIBasicSprite = mSprite;
			num6 = uIBasicSprite.mFillAmount;
		}
		Color[] array2 = colors;
		object obj6 = array2.Length - 1;
		float num7 = num6 * (float)obj6;
		nint num8 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v26 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num9 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v68 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num10 = Mathf.RoundToInt(num7);
		object obj8 = colors + 16;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S1_v36+8]");
		_ = 0;
		obj = ((UIWidget.Pivot*)(int)pivot)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v12 (UIWidget+Pivot)+8]");
		_ = 0;
		if (num10 >= 0)
		{
			object obj9 = num10 + 1;
			Color[] array3 = colors;
			if ((nint)obj9 < array3.Length)
			{
				object obj10 = colors + 16;
				int num11 = num10 << 4;
				object obj11 = obj10 + num11;
				obj3 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S1_v81+8]");
				_ = 0;
				int num12 = num10 << 4;
				object obj12 = colors + num12;
				object obj13 = obj12 + 32;
				obj4 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S1_v88+8]");
				_ = 0;
				((int*)num3)->m_value = (int)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v16+8]");
				_ = 0;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v18+8]");
				_ = 0;
				float value = num7 - (float)num10;
				((Matrix4x4*)matrix4x)->set_Item(num3, (int)pivot, value);
				obj = matrix4x.m00;
				_ = matrix4x.m20;
			}
			else
			{
				Color[] array4 = colors;
				if (num10 < array4.Length)
				{
					object obj14 = colors + 16;
					int num13 = num10 << 4;
					object obj15 = obj14 + num13;
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj15;
					object obj16 = obj15;
				}
				else
				{
					Color[] array5 = colors;
					object obj17 = array5.Length << 4;
					object obj18 = (object)colors + obj17;
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj18;
					object obj16 = obj18;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ L2_v7+8]");
				_ = 0;
				obj = ((UIWidget.Pivot*)(int)pivot)->value__;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v12 (UIWidget+Pivot)+8]");
				_ = 0;
			}
		}
		object obj19 = sprite + 80;
		((int*)num3)->m_value = (int)obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v48+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v14 (System.Int32)+C]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		sprite.rawPivot = pivot;
	}
}

using Cpp2ILInjected;
using UnityEngine;

public class UILocalize : MonoBehaviour
{
	public string key;

	private bool mStarted;

	public string value
	{
		set
		{
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_00dc: Expected Obj, but got I
			//IL_0054: Expected I, but got Obj
			if (value != null)
			{
				return;
			}
			nint num = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILocalize)+124]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			}
		}
	}

	private void OnEnable()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_0100: Expected I, but got Obj
		//IL_0116: Expected Obj, but got I
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_01ba: Expected Obj, but got I4
		//IL_01c9: Expected Obj, but got F4
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		_ = 2;
		object obj = this + 300;
		obj = "";
		_ = 16;
		_ = 1;
		object obj3 = default;
		object obj2 = obj3 + 48;
		Color yellow = Color.yellow;
		object obj4 = obj3 - -64;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14+8]");
		_ = 0;
		object obj5 = this + 328;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v16+8]");
		_ = 0;
		_ = 1;
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v23 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v59 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = obj3 + 8;
		Vector2 up = Vector2.up;
		obj4 = obj7;
		object obj8 = obj3 + 32;
		Color black = Color.black;
		obj4 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v32+8]");
		_ = 0;
		object obj9 = this + 364;
		obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v16+8]");
		_ = 0;
		object obj10 = obj3 + 16;
		obj10 = 0;
		_ = 0;
		obj10 = 0.7f;
		_ = 0.7f;
		_ = 0.7f;
		_ = 1f;
		obj4 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v39+8]");
		_ = 0;
		object obj11 = this + 380;
		obj11 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v16+8]");
		_ = 0;
		_ = 1;
		_ = 1f;
		_ = 1;
		Vector2 one = Vector2.one;
		obj4 = obj3;
		_ = 1f;
		((AnimatedAlpha)this).OnEnable();
	}

	private void Start()
	{
		if (~(mStarted ? 1u : 0u) == 0)
		{
			this._002Ector();
		}
	}

	private void OnLocalize()
	{
		mStarted = true;
		this._002Ector();
	}

	public UILocalize()
	{
		//IL_0044: Expected I, but got Obj
		//IL_005a: Expected Obj, but got I
		//IL_0085: Expected I, but got Obj
		//IL_0116: Expected I, but got Obj
		//IL_012c: Expected Obj, but got I
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_0238: Expected Obj, but got I4
		//IL_0157: Expected I, but got Obj
		string text = key;
		if (key == null || text.m_stringLength == 0)
		{
			UILabel component = GetComponent<UILabel>();
			nint num = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v33 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v41 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
			{
				object obj2 = this + 12;
				obj2 = component.mText;
			}
		}
		string text2 = key;
		if (key == null || text2.m_stringLength == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v17 (Il2CppClass<Localization>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v22 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string sortingLayerName = Localization.Format(key, (object[])1);
		((UIPanel)this).sortingLayerName = sortingLayerName;
	}
}

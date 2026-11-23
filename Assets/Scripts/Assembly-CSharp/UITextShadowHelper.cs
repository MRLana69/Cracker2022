using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;

public class UITextShadowHelper : MonoBehaviour
{
	public TMP_Text shadowLabel;

	public Color frontColor = (Color)4575657222473777152L;

	public Color shadowColor = (Color)1065353216;

	public bool updateDynamically;

	public bool fakeHD;

	private TMP_Text _frontLabel;

	public Vector3 shadowOffset;

	private Transform _frontTransform;

	private Transform _shadowTransform;

	private void Awake()
	{
		GameObject gameObject = base.gameObject;
		TMP_Text component = gameObject.GetComponent<TMP_Text>();
		_frontLabel = component;
		Transform frontTransform = transform;
		_frontTransform = frontTransform;
	}

	private void Start()
	{
		UpdateText();
	}

	public void UpdateNow()
	{
		UpdateText();
	}

	private unsafe void UpdateText()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0033: Expected I, but got Obj
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_008c: Expected Obj, but got I
		//IL_00c3: Expected Obj, but got I
		//IL_00fa: Expected Obj, but got I
		//IL_011d: Invalid comparison between Obj and F4
		//IL_018a: Expected I, but got Obj
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_01b4: Expected I, but got Obj
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected Obj, but got Unknown
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected Obj, but got Unknown
		//IL_051e: Expected I, but got Obj
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected Obj, but got Unknown
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected Obj, but got Unknown
		//IL_0577: Expected Obj, but got I
		//IL_05ae: Expected Obj, but got I
		//IL_05e5: Expected Obj, but got I
		//IL_0608: Invalid comparison between Obj and F4
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0212: Expected I, but got Obj
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_0232: Expected I, but got Obj
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected Obj, but got Unknown
		//IL_03bf: Expected Obj, but got I
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected Obj, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected Obj, but got Unknown
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Expected VT, but got Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected Obj, but got Unknown
		//IL_0472: Expected Obj, but got I
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Expected Obj, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected Obj, but got Unknown
		//IL_04ac: Expected F4, but got I
		//IL_04a7: Expected native int or pointer, but got VT
		//IL_04cb: Expected F4, but got I
		//IL_04c6: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 112);
		if (shadowLabel != null)
		{
			object obj2 = vector + 96;
			TMP_Text frontLabel = _frontLabel;
			nint num = (nint)frontLabel;
			object obj3 = frontLabel + 176;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S2_v4 (Il2CppClass<TMPro.TMP_Text>)+16C] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			object obj4 = 0 - frontColor;
			object obj5 = obj4 * obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITextShadowHelper)+14]");
			object obj6 = num2 - 0;
			object obj7 = obj6 * obj6;
			object obj8 = obj5 + obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITextShadowHelper)+18]");
			object obj9 = num3 - 0;
			object obj10 = obj9 * obj9;
			object obj11 = obj8 + obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+6C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITextShadowHelper)+1C]");
			object obj12 = num4 - 0;
			object obj13 = obj12 * obj12;
			object obj14 = obj11 + obj13;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)9.9999994E-11f))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITextShadowHelper)+18]");
				_ = 0;
				_ = frontColor;
				object obj15 = vector + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			}
			TMP_Text tMP_Text = shadowLabel;
			nint num5 = (nint)tMP_Text;
			object obj16 = tMP_Text + 520;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v141 @ S1_v27 (Il2CppClass<TMPro.TMP_Text>)+2C4] (should have been resolved before IL gen)");
			TMP_Text frontLabel2 = _frontLabel;
			nint num6 = (nint)frontLabel2;
			object obj17 = frontLabel2 + 520;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v153 @ S2_v21 (Il2CppClass<TMPro.TMP_Text>)+2C4] (should have been resolved before IL gen)");
			string text = default;
			string text2 = default;
			if (text != text2)
			{
				TMP_Text tMP_Text2 = shadowLabel;
				TMP_Text frontLabel3 = _frontLabel;
				nint num7 = (nint)frontLabel3;
				object obj18 = frontLabel3 + 520;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v171 @ S2_v63 (Il2CppClass<TMPro.TMP_Text>)+2C4] (should have been resolved before IL gen)");
				nint num8 = (nint)tMP_Text2;
				object obj19 = tMP_Text2 + 528;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v180 @ S2_v67 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			}
			object obj20 = vector + 96;
			TMP_Text tMP_Text3 = shadowLabel;
			nint num9 = (nint)tMP_Text3;
			object obj21 = tMP_Text3 + 176;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v201 @ S2_v27 (Il2CppClass<TMPro.TMP_Text>)+16C] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			object obj22 = 0 - shadowColor;
			object obj23 = obj22 * obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITextShadowHelper)+24]");
			object obj24 = num10 - 0;
			object obj25 = obj24 * obj24;
			object obj26 = obj23 + obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITextShadowHelper)+28]");
			object obj27 = num11 - 0;
			object obj28 = obj27 * obj27;
			object obj29 = obj26 + obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+6C]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITextShadowHelper)+2C]");
			object obj30 = num12 - 0;
			object obj31 = obj30 * obj30;
			object obj32 = obj29 + obj31;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)9.9999994E-11f))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITextShadowHelper)+28]");
				_ = 0;
				_ = shadowColor;
				object obj33 = vector + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			}
			GameObject gameObject = shadowLabel.gameObject;
			string text3 = gameObject.name;
			string text4 = name;
			string text5 = text4 + "Shadow";
			if (text3 != text5)
			{
				GameObject gameObject2 = shadowLabel.gameObject;
				string text6 = name;
				string text7 = text6 + "Shadow";
				gameObject2.name = text7;
			}
			DeviceInfo instance = DeviceInfo.Instance;
			if (~(instance.isHighres__BackingField ? 1u : 0u) == 0 || ~(fakeHD ? 1u : 0u) == 0)
			{
				Vector3 localPosition = _frontTransform.localPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
				object obj34 = 0 + shadowOffset;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
				nint num13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITextShadowHelper)+3C]");
				object obj35 = num13 + 0;
				object obj36 = this - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
				object obj37 = 0 + obj36;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
				_ = 0;
				Vector3 localPosition2 = vector + 16;
				_shadowTransform.localPosition = localPosition2;
			}
			else
			{
				Vector3 localPosition3 = _frontTransform.localPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
				object obj38 = 0 + shadowOffset;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
				nint num14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITextShadowHelper)+3C]");
				object obj39 = num14 + 0;
				object obj40 = this - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
				object obj41 = 0 + obj40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
				((Vector3*)(nint)vector)->x = 0f;
				_shadowTransform.localPosition = vector;
			}
		}
	}

	private void Update()
	{
		if (_frontLabel == shadowLabel)
		{
			GameObject gameObject = base.gameObject;
			shadowLabel = null;
		}
		if (~(updateDynamically ? 1u : 0u) == 0)
		{
			UpdateText();
		}
	}

	private void OnDisable()
	{
		if (shadowLabel != null)
		{
			GameObject gameObject = shadowLabel.gameObject;
			gameObject.SetActive(value: false);
		}
	}

	private void OnEnable()
	{
		if (shadowLabel != null)
		{
			GameObject gameObject = shadowLabel.gameObject;
			gameObject.SetActive(value: true);
		}
	}

	public UITextShadowHelper()
	{
		//IL_000b: Expected VT, but got I4
		//IL_001a: Expected VT, but got I8
		_ = 4575657222473777152L;
		_ = 4575657222473777152L;
		base._002Ector();
	}
}

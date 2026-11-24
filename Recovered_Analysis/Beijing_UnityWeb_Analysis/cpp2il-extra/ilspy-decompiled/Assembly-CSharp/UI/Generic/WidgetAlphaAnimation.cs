using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Generic;

public class WidgetAlphaAnimation : MonoBehaviour
{
	private AnimationCurve _curve;

	private float _progress;

	private UIWidget _widget;

	private float _fullCurveLength;

	private void Awake()
	{
		//IL_005e: Expected Obj, but got F4
		//IL_0067: Expected Obj, but got I4
		//IL_0070: Expected Obj, but got F4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00ac: Expected F4, but got Obj
		//IL_00e3: Expected I, but got Obj
		//IL_00f9: Expected Obj, but got I
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		_curve = (AnimationCurve)1f;
		object obj = 0;
		obj = 1f;
		_ = 5f;
		object obj2 = obj + 8;
		obj2 = obj;
		object obj3 = obj + 40;
		obj3 = obj2;
		_progress = (float)obj3;
		_fullCurveLength = 1f;
		_ = 1f;
		_ = 0.5f;
		_ = 0.2f;
		_ = 3;
		_ = float.MinValue;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v24 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v44 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj + 28;
		Vector3 one = Vector3.one;
		obj3 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v29+8]");
		_ = 0;
		object obj6 = this + 60;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v15+8]");
		_ = 0;
		object obj7 = obj + 16;
		Vector3 one2 = Vector3.one;
		obj3 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v36+8]");
		_ = 0;
		object obj8 = this + 72;
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v15+8]");
		_ = 0;
		CancelInvoke();
	}

	private void Update()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		object obj = this + 20;
		UIWidget component = GetComponent<UIWidget>();
		obj = component;
		float progress = ScrollRect.RubberDelta(0f, 1f);
		_progress = progress;
		int length = _curve.length;
		Keyframe[] keys = _curve.GetKeys();
		object obj2 = keys * 28;
		object obj3 = length + obj2;
		object obj4 = obj3 + -12;
		float fullCurveLength = (float)obj4 * 2f;
		_fullCurveLength = fullCurveLength;
	}

	public WidgetAlphaAnimation()
	{
		float fixedDeltaTime = Time.fixedDeltaTime;
		float progress = _progress + fixedDeltaTime;
		_progress = progress;
		float num = PlayerPrefs.GetFloat((string)(object)_curve, _progress);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		if (!(_progress < _fullCurveLength))
		{
			float progress2 = _progress - _fullCurveLength;
			_progress = progress2;
		}
	}
}

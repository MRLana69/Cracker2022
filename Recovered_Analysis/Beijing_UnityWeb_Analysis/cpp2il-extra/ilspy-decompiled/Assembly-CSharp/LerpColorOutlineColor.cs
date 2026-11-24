using Cpp2ILInjected;
using UnityEngine;

public class LerpColorOutlineColor : MonoBehaviour
{
	private UITexture _myHighlight;

	private Color32 _originalColor;

	private Color32 _newColor;

	private void Start()
	{
		CancelInvoke();
	}

	private void Update()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 12;
		UITexture component = GetComponent<UITexture>();
		obj = component;
	}

	private void LerpColor()
	{
		this._002Ector();
	}

	public unsafe LerpColorOutlineColor()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00ac: Expected Obj, but got VT
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected VT, but got Unknown
		//IL_00dd: Expected F4, but got Obj
		//IL_00d8: Expected native int or pointer, but got VT
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_0110: Expected Obj, but got VT
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_0133: Expected F4, but got Obj
		//IL_012e: Expected native int or pointer, but got VT
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected I4, but got Unknown
		//IL_0189: Expected I4, but got Obj
		//IL_01a3: Expected F4, but got Obj
		//IL_019e: Expected native int or pointer, but got VT
		//IL_01b8: Expected F4, but got I
		//IL_01b3: Expected native int or pointer, but got VT
		//IL_01cd: Expected I4, but got VT
		//IL_01cd: Expected Ref, but got VT
		//IL_01da: Expected native int or pointer, but got VT
		//IL_01ec: Expected native int or pointer, but got VT
		//IL_0200: Expected I4, but got VT
		//IL_0054: Expected I, but got Obj
		Matrix4x4 matrix4x = default;
		object obj = matrix4x + 56;
		obj = _originalColor;
		object obj2 = matrix4x + 60;
		obj2 = obj;
		Matrix4x4 matrix4x2 = (Matrix4x4)(matrix4x + 80);
		((Matrix4x4*)(nint)matrix4x2)->m00 = (float)obj2;
		object obj3 = matrix4x + 40;
		Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x2);
		object obj4 = matrix4x + 32;
		obj4 = _newColor;
		object obj5 = matrix4x + 36;
		obj5 = obj4;
		((Matrix4x4*)(nint)matrix4x2)->m00 = (float)obj5;
		object obj6 = matrix4x + 16;
		Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x2);
		float timeSinceLevelLoad = Time.timeSinceLevelLoad;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S2_v23 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S2_v43 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float value = Mathf.DeltaAngle(timeSinceLevelLoad, 0.8f);
		int num3 = matrix4x - -64;
		((int*)num3)->m_value = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v10+8]");
		_ = 0;
		((Matrix4x4*)(nint)matrix4x2)->m00 = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v17+8]");
		((Matrix4x4*)(nint)matrix4x2)->m20 = 0f;
		((Matrix4x4*)matrix4x)->set_Item(num3, (int)matrix4x2, value);
		((Matrix4x4*)(nint)matrix4x2)->m00 = matrix4x.m00;
		((Matrix4x4*)(nint)matrix4x2)->m20 = matrix4x.m20;
		_myHighlight.rawPivot = (UIWidget.Pivot)matrix4x2;
	}
}

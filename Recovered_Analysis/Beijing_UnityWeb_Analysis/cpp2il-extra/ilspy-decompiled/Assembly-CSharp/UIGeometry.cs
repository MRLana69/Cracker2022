using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class UIGeometry
{
	public delegate void OnCustomWrite(List<Vector3> v, List<Vector2> u, List<Color> c, List<Vector3> n, List<Vector4> t, List<Vector4> u2);

	public List<Vector3> verts;

	public List<Vector2> uvs;

	public List<Color> cols;

	public OnCustomWrite onCustomWrite;

	private List<Vector3> mRtpVerts;

	private Vector3 mRtpNormal;

	private Vector4 mRtpTan;

	public bool hasVertices
	{
		get
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			//IL_00e8: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			UIEventListener component = ((GameObject)this).GetComponent<UIEventListener>();
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = component != null;
			bool flag2 = !flag;
			UIEventListener uIEventListener = component;
			if (!flag2)
			{
				UIEventListener uIEventListener2 = ((GameObject)this).AddComponent<UIEventListener>();
				uIEventListener = uIEventListener2;
			}
			return (byte)(int)uIEventListener != 0;
		}
	}

	public bool hasTransformed
	{
		get
		{
			List<Vector3> list = verts;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+C]");
			return (nint)0 > (nint)0;
		}
	}

	public void Clear()
	{
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public void ApplyTransform(Matrix4x4 widgetToPanel, bool generateNormals = true)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got VT
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got I4
		object obj = this + 8;
		obj = widgetToPanel;
		object obj2 = this + 12;
		obj2 = generateNormals;
	}

	public void WriteToBuffers(List<Vector3> v, List<Vector2> u, List<Color> c, List<Vector3> n, List<Vector4> t, List<Vector4> u2)
	{
		//IL_0105: Expected I, but got Obj
		//IL_011b: Expected Obj, but got I
		//IL_0154: Expected I4, but got Obj
		//IL_0061: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0082: Expected I4, but got Obj
		//IL_00a3: Expected I4, but got Obj
		//IL_00c4: Expected I4, but got Obj
		//IL_00c4: Expected Obj, but got VT
		//IL_00eb: Expected I4, but got Obj
		//IL_00eb: Expected Obj, but got I
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v20 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault((string)(object)v);
		((UILabel)(object)uvs).fontSize = (int)text;
		string text2 = Strings.GetDefault((string)(object)u);
		((UILabel)(object)cols).fontSize = (int)text2;
		string text3 = Strings.GetDefault((string)(object)c);
		((UILabel)(object)onCustomWrite).fontSize = (int)text3;
		string text4 = Strings.GetDefault((string)(object)n);
		((UILabel)(object)mRtpVerts).fontSize = (int)text4;
		string text5 = Strings.GetDefault((string)(object)t);
		((UILabel)mRtpNormal).fontSize = (int)text5;
		string text6 = Strings.GetDefault((string)(object)u2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIGeometry)+20]");
		((UILabel)0).fontSize = (int)text6;
		((TutorialMultilineLabelsHelper)this)._002Ector();
	}

	public UIGeometry()
	{
		throw new IndexOutOfRangeException();
	}
}

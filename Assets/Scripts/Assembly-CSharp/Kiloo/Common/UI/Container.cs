using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.UI;

public class Container
{
	public Action onRecycleContainer;

	public Action onPositionContainer;

	public long rowId;

	public GameObject model;

	public Vector2 coordinates = Vector2.zeroVector;

	private readonly Transform _modelTransform;

	public Bounds bounds;

	public int dataIndex;

	public int modelType;

	public float height;

	public float width;

	public bool isMeasured;

	private bool _parentSet;

	private bool _scaleSet;

	public object tag;

	public float top;

	public float bottom;

	public float right;

	public float left;

	public Transform modelTransform => _modelTransform;

	public bool hasTransientState
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public Container(GameObject model)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(model);
		this.model = gameObject;
		if (this.model != null)
		{
			Transform transform = this.model.transform;
			_modelTransform = transform;
		}
	}

	public Container(GameObject model, Vector2 size)
	{
		//IL_0087: Expected I4, but got F4
		//IL_00a7: Expected I4, but got F4
		GameObject gameObject = UnityEngine.Object.Instantiate(model);
		this.model = gameObject;
		if (this.model != null)
		{
			Transform transform = this.model.transform;
			_modelTransform = transform;
		}
		UIWidget component = this.model.GetComponent<UIWidget>();
		if ((object)component != null)
		{
			double num = Math.Abs((double)size.x);
			int w = ((!(num < 2147483648.0)) ? int.MinValue : ((int)size.x));
			double num2 = Math.Abs((double)size.y);
			int h = ((!(num2 < 2147483648.0)) ? int.MinValue : ((int)size.y));
			component.SetDimensions(w, h);
		}
	}

	public unsafe virtual void Measure(bool includeInactive = true)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_009a: Expected VT, but got Obj
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected VT, but got Unknown
		//IL_00ae: Expected Ref, but got VT
		//IL_00bc: Expected F4, but got Obj
		//IL_00c5: Expected Ref, but got VT
		//IL_00eb: Expected F4, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		if (~(isMeasured ? 1u : 0u) != 0)
		{
			Transform transform = model.transform;
			Bounds bounds = NGUIMath.CalculateRelativeWidgetBounds(transform, includeInactive);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			this.bounds = (Bounds)obj;
			Bounds bounds2 = (Bounds)(this + 40);
			Vector3 size = ((Bounds*)bounds2)->size;
			width = (float)obj;
			Vector3 size2 = ((Bounds*)bounds2)->size;
			isMeasured = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			height = 0f;
		}
	}

	public unsafe void SetPosition()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_001d: Expected native int or pointer, but got VT
		//IL_0038: Expected F4, but got VT
		//IL_0033: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		_ = 0;
		((Vector3*)(nint)vector)->z = 0f;
		_ = coordinates;
		((Vector3*)(nint)vector)->x = (float)coordinates;
		_modelTransform.localPosition = vector;
		Action action = onPositionContainer;
		if (onPositionContainer != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v25.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public unsafe void SetParent(Transform parent)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0076: Expected I, but got Obj
		//IL_00a8: Expected F4, but got I
		//IL_00a3: Expected native int or pointer, but got VT
		//IL_00c3: Expected F4, but got I
		//IL_00be: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 32);
		if (~(_parentSet ? 1u : 0u) != 0)
		{
			Transform transform = model.transform;
			transform.parent = parent;
			Transform transform2 = model.transform;
			nint num = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v20 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v21 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+18]");
			((Quaternion*)(nint)quaternion)->z = 0f;
			_ = Quaternion.identityQuaternion;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+10]");
			((Quaternion*)(nint)quaternion)->x = 0f;
			transform2.localRotation = quaternion;
			_parentSet = true;
		}
	}

	public unsafe void SetScale(Vector3 scale)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0059: Expected native int or pointer, but got VT
		//IL_006b: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		if (~(_scaleSet ? 1u : 0u) != 0)
		{
			_scaleSet = true;
			Transform transform = model.transform;
			((Vector3*)(nint)vector)->z = scale.z;
			((Vector3*)(nint)vector)->x = scale.x;
			transform.localScale = vector;
		}
	}

	public void SetModelType(int mType)
	{
		modelType = mType;
	}

	public unsafe override string ToString()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0372: Expected native int or pointer, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj - 32);
		((Vector2*)(nint)vector)->x = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}

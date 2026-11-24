using Cpp2ILInjected;
using SYBO.Common.Utilities;
using UnityEngine;

public class UISpinner : MonoBehaviour
{
	private UISprite _sprite;

	private float _speed;

	private bool _rotateClockWise;

	private bool _startManually;

	private bool _enableDisableSprite;

	private bool _callStartSpinning;

	private bool _callStopSpinning;

	private bool _shouldRotate;

	private float _deltaTime;

	public bool IsAnimating
	{
		get
		{
			//IL_0023: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			bool flag = default;
			object obj = (flag ? 1 : 0) + 16;
			obj = this;
			return flag;
		}
	}

	private void OnEnable()
	{
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		object obj = obj2 + 32;
		Color green = Color.green;
		object obj3 = obj2 + 48;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12+8]");
		_ = 0;
		object obj5 = default;
		object obj4 = obj5 + 16;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+8]");
		_ = 0;
		object obj6 = obj2 + 16;
		Color magenta = Color.magenta;
		obj3 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v20+8]");
		_ = 0;
		object obj7 = obj5 + 32;
		obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+8]");
		_ = 0;
		Color blue = Color.blue;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj8 = obj5 + 48;
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+8]");
		_ = 0;
		object obj9 = this + 16;
		obj9 = obj5;
		CancelInvoke();
	}

	private void Awake()
	{
		if (~(_startManually ? 1u : 0u) != 0)
		{
			StopSpinning();
		}
	}

	private void Update()
	{
		//IL_0137: Expected I, but got Obj
		//IL_014d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_sprite != null)
		{
			UISprite component = GetComponent<UISprite>();
			nint num3 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v27 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
			{
				object obj3 = this + 12;
				obj3 = component;
			}
			else
			{
				SDebug.LogFormat("Sprite not set for this Spinner", null);
			}
		}
		if (~(_startManually ? 1u : 0u) == 0)
		{
			ResetSpriteRotation();
		}
		else
		{
			StopSpinning();
		}
	}

	public unsafe void StartSpinning()
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected VT, but got Unknown
		//IL_00fb: Expected I, but got Obj
		//IL_0111: Expected Obj, but got I
		//IL_0144: Expected F4, but got Obj
		//IL_013f: Expected native int or pointer, but got VT
		//IL_0159: Expected F4, but got I
		//IL_0154: Expected native int or pointer, but got VT
		//IL_0066: Expected I, but got Obj
		object obj = default;
		Vector3 vector = (Vector3)(obj + 12);
		if (~(_shouldRotate ? 1u : 0u) != 0)
		{
			return;
		}
		float aspectRatio = Utils.GetAspectRatio();
		_deltaTime = aspectRatio;
		float num = _deltaTime;
		float num2 = 0f - _deltaTime;
		if (~(_rotateClockWise ? 1u : 0u) != 0)
		{
			num = num2;
		}
		float angle = num * _speed;
		GameObject gameObject = _sprite.gameObject;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v10 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v18 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 up = Vector3.up;
		((Vector3*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Transform)(object)gameObject).RotateAround(vector, angle);
	}

	public void StopSpinning()
	{
		//IL_0029: Expected Obj, but got I4
		if (~(_enableDisableSprite ? 1u : 0u) == 0)
		{
			_sprite.tag = (string)1;
		}
		_shouldRotate = true;
	}

	public void ResetSpriteRotation()
	{
		if (~(_enableDisableSprite ? 1u : 0u) == 0)
		{
			_sprite.tag = null;
		}
		_shouldRotate = false;
	}

	public UISpinner()
	{
		GameObject gameObject = _sprite.gameObject;
		GameObjectUtil.ResetLocalScale((Transform)(object)gameObject);
	}
}

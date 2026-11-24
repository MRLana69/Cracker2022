using System;
using Cpp2ILInjected;
using UnityEngine;

namespace UI.VideoAdPrizes;

[Serializable]
public class QuickVideoButtonPrizeIconSetup : PrizeIconSetup
{
	private Texture2D _iconMask;

	protected UISprite _iconSprite;

	private UIPanel _maskPanel;

	private Transform _unrotateGlint;

	public Texture2D iconMask
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (Texture2D)_prizeType;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 40;
			obj = value;
		}
	}

	public UIPanel maskPanel
	{
		get
		{
			return (UIPanel)(object)_iconMask;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 40;
			obj = value;
		}
	}

	public Transform unrotateGlint
	{
		get
		{
			return (Transform)(object)_maskPanel;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 48;
			obj = value;
		}
	}

	public override UISprite iconSprite
	{
		get
		{
			return (UISprite)(object)_unrotateGlint;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 52;
			obj = value;
		}
	}

	protected override void OnSetup()
	{
		_iconHeight = 52;
	}

	private unsafe void Enable()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_009a: Expected I, but got Obj
		//IL_00b0: Expected Obj, but got I
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected VT, but got Unknown
		//IL_00e8: Expected F4, but got Obj
		//IL_00e3: Expected native int or pointer, but got VT
		//IL_00fd: Expected F4, but got I
		//IL_00f8: Expected native int or pointer, but got VT
		//IL_0117: Expected F4, but got Obj
		//IL_0112: Expected native int or pointer, but got VT
		//IL_012c: Expected F4, but got I
		//IL_0127: Expected native int or pointer, but got VT
		//IL_0135: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		OnDeactivate();
		this._002Ector();
		object obj2 = default;
		object obj = obj2 + 12;
		object obj3 = this + 24;
		obj = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S2_v3+8]");
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v20 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Quaternion quaternion = (Quaternion)(obj2 + 24);
		((Quaternion*)(nint)quaternion)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v6+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Quaternion quaternion2 = Quaternion.Inverse(quaternion);
		((Quaternion*)(nint)quaternion)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Vector3 right = ((Transform)quaternion).right;
	}

	protected override void OnDeactivate()
	{
		//IL_0010: Expected Obj, but got I4
		_maskPanel.tag = (string)1;
	}

	private void SetupMask()
	{
		_maskPanel.tag = null;
	}

	public QuickVideoButtonPrizeIconSetup()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_0116: Expected VT, but got Obj
		//IL_0137: Expected VT, but got Obj
		Vector4 clipRange = ((UIPanel)(object)_iconMask).clipRange;
		GameObject gameObject = _maskPanel.gameObject;
		Transform transform = default;
		object obj = transform + 24;
		object obj2 = this + 12;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v4+8]");
		_ = 0;
		Transform transform2 = (Transform)(transform + 36);
		transform2 = (Transform)obj;
		Transform transform3 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v6+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform2.eulerAngles;
		GameObject gameObject2 = _maskPanel.gameObject;
		object obj3 = transform + 12;
		object obj4 = this + 24;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S2_v16+8]");
		_ = 0;
		transform2 = (Transform)obj3;
		Transform transform4 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v14+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		Vector3 right = transform2.right;
		GameObject gameObject3 = _maskPanel.gameObject;
		transform2.position = (Vector3)gameObject3;
		GameObject gameObject4 = _maskPanel.gameObject;
		transform.position = (Vector3)gameObject4;
		UISprite uISprite = _iconSprite;
		UISprite uISprite2 = _iconSprite;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7F5D");
	}
}

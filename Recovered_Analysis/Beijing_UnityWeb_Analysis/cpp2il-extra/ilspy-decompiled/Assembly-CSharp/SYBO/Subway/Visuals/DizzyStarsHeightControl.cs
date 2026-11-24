using System;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Visuals;

public class DizzyStarsHeightControl : MonoBehaviour
{
	private float HeightOffset__BackingField;

	private Transform _characterTransform;

	private Transform _headTransform;

	public float HeightOffset
	{
		get
		{
			float timeSinceLevelLoad = Time.timeSinceLevelLoad;
			float num = timeSinceLevelLoad;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Visuals.DizzyStarsHeightControl)+BC]");
			return num - 0f;
		}
		set
		{
			((Game)this).LockGameSpeedTo(value);
		}
	}

	private void Start()
	{
		CancelInvoke();
	}

	private unsafe void Game_OnCharacterModelRecreated()
	{
		//IL_00bb: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_0113: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00ac: Expected Obj, but got I4
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 16;
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v5 (System.Boolean)+88]");
		GameObject gameObject = ((Component)0).gameObject;
		obj2 = gameObject;
		LateUpdate();
		bool isInstantiated2 = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(DizzyStarsHeightControl.Game_OnCharacterModelRecreated);
		object obj3 = action + 16;
		obj3 = this;
		((Game)isInstantiated2).OnCharacterModelRecreated -= action;
	}

	private void SetHeadTransform()
	{
		LateUpdate();
	}

	private void LateUpdate()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00b7: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 20;
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v5 (System.Boolean)+88]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v6+BC]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v7+C0]");
		obj2 = 0;
	}

	public DizzyStarsHeightControl()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_003a: Expected VT, but got Obj
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_0069: Expected VT, but got Obj
		//IL_009b: Expected VT, but got Obj
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		Transform transform = default;
		object obj = transform + 36;
		obj = 0;
		_ = 0;
		Transform transform2 = (Transform)(transform + 24);
		transform2.position = (Vector3)_characterTransform;
		obj = transform2;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		Transform transform3 = (Transform)(transform + 12);
		transform3.position = (Vector3)_headTransform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v12 (UnityEngine.Transform)+4]");
		float num = 0f + HeightOffset__BackingField;
		transform.position = (Vector3)_headTransform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		GameObject gameObject = base.gameObject;
		Transform transform4 = (Transform)(transform + 48);
		transform4 = (Transform)obj;
		Transform transform5 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		Vector3 localPosition = transform4.localPosition;
	}
}

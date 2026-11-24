using System.Collections;
using Cpp2ILInjected;
using Data.Save;
using Info;
using SYBO.Components.Utilities.Validators;
using UnityEngine;

public class CameraCulling : MonoBehaviour
{
	private Camera _camera;

	private float[] _distances;

	public float TransparentFXCullingDistance
	{
		set
		{
			//IL_00b8: Expected I, but got Obj
			//IL_00ce: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00a1: Expected Obj, but got I4
			nint num = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Settings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Settings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v20 (Il2CppClass<Info.Settings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (PreferencesSave.musicEnabled)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CameraCulling)+20]");
				if ((nint)0 == 0)
				{
					_ = 1;
					bool isAvailable = ((Sound)(object)this).IsAvailable;
					Coroutine coroutine = StartCoroutine_Auto((IEnumerator)isAvailable);
				}
			}
		}
	}

	private void Awake()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		obj = obj2;
		((Validator<>)(object)this)._002Ector();
	}

	public CameraCulling()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 12;
		Camera component = GetComponent<Camera>();
		obj = component;
	}
}

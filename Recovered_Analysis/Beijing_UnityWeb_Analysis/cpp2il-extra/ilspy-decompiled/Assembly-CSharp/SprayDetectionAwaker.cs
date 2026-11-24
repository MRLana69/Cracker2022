using System;
using System.IO;
using Cpp2ILInjected;
using UnityEngine;

public class SprayDetectionAwaker : MonoBehaviour
{
	private RunnerAnimPlayer _runnerAnimPlayer;

	private void Start()
	{
		((Sound)(object)this).Pause();
	}

	private void CheckScreen(string screenName)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		_ = 1;
		object obj = this + 8;
		obj = screenName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Stream stream = default;
		UnityEngine.ManagedStreamHelpers.ValidateLoadFromStream(stream);
		object obj2 = this + 12;
		obj2 = stream;
		object obj3 = this + 28;
		obj3 = "empty";
		RunnerAnimPlayer runnerAnimPlayer = _runnerAnimPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SprayDetectionAwaker)+1C]");
		UnityEngine.Object.DestroyImmediate(runnerAnimPlayer, allowDestroyingAssets: false);
		int layer = ((GameObject)(object)_runnerAnimPlayer).layer;
		GameObject parentInternal = ((Component)(object)screenName).gameObject;
		((Transform)layer).parentInternal = (Transform)(object)parentInternal;
		object obj4 = this + 20;
		AudioSource audioSource = ((GameObject)(object)_runnerAnimPlayer).AddComponent<AudioSource>();
		obj4 = audioSource;
	}

	public SprayDetectionAwaker()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_00ff: Expected Obj, but got I4
		//IL_0103: Expected VT, but got Obj
		//IL_010b: Expected Obj, but got VT
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_0144: Expected I, but got Obj
		//IL_015a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(Utils);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Utils>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v31 (Il2CppClass<Utils>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 12;
		_0021_00210 val = (_0021_00210)Utils.FindComponentInThisOrParents<T>((MonoBehaviour)1);
		obj2 = val;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<string> action = default;
		object obj3 = action + 16;
		obj3 = this;
		nint num4 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v22 (Il2CppClass<UIScreenController>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v27 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnChangedScreen -= action;
	}
}

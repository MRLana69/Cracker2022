using System;
using System.IO;
using Cpp2ILInjected;
using Data.Save;
using UnityEngine;

[Serializable]
public class AudioClipInfo
{
	public AudioClip Clip;

	public float minPitch;

	public float maxPitch;

	public float minVolume;

	public float maxVolume;

	public AudioRolloffMode Rollof;

	public override string ToString()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (string)(object)UserSave.characterOutfitsSeen;
	}

	public AudioClipInfo()
	{
		//IL_000b: Expected Obj, but got F4
		//IL_0037: Expected Obj, but got F4
		if (File.GetAttributes((string)minPitch) != 0)
		{
			((FileStream)minPitch).ExposeHandle();
		}
	}
}

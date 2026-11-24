using System;
using Cpp2ILInjected;
using Data.Save;
using UI.Generic;
using UnityEngine;

namespace TopRun;

public class PlayerInfoChangedEventArgs : EventArgs
{
	public IPlayer player
	{
		get
		{
			//IL_0069: Expected I, but got Obj
			//IL_007f: Expected Obj, but got I
			//IL_00c3: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			int missionsVersion = PlayerSave.missionsVersion;
			nint num = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S1_v3 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v10 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			SSEventType lastEventTypeShown = UserSave.lastEventTypeShown;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v8 (SSEventType)+18]");
			bool flag = (nint)missionsVersion != 0;
			return (IPlayer)flag;
		}
		internal set
		{
			//IL_007b: Expected I4, but got Obj
			//IL_007b: Expected Obj, but got I
			//IL_008c: Expected Obj, but got I
			//IL_009e: Expected Obj, but got I4
			//IL_0016: Expected Obj, but got I
			//IL_003a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRun.PlayerInfoChangedEventArgs)+14]");
			((UISprite)0).fillCenter = (byte)(int)value != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRun.PlayerInfoChangedEventArgs)+14]");
			string tag = ((Component)0).tag;
			((GameObject)(object)tag).tag = (string)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRun.PlayerInfoChangedEventArgs)+18]");
			string tag2 = ((Component)0).tag;
			((GameObject)(object)tag2).tag = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRun.PlayerInfoChangedEventArgs)+1C]");
			string tag3 = ((Component)0).tag;
			((GameObject)(object)tag3).tag = null;
			FitSpriteToWidget component = ((Component)(object)this).GetComponent<FitSpriteToWidget>();
			component.FitStretch();
		}
	}

	public PlayerInfoChangedEventArgs()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}

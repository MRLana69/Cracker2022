using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using UI.Popups.SettingsPopupInternal;
using UI.Screens;
using UnityEngine;

namespace UI.Popups.SecretPopupInternal;

public class SecretHelper : MonoBehaviour
{
	private UILabel _secretValue;

	private UILabel _secretInfo;

	private UILabel _secretTitle;

	private UILabel _secretInfo2;

	private UILabel _secretValue2;

	public void UpdateInfo(string info, string value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Expected Obj, but got Unknown
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected Obj, but got Unknown
		//IL_0491: Expected Obj, but got I4
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected Obj, but got Unknown
		//IL_04a8: Expected Obj, but got I4
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected Obj, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected Obj, but got Unknown
		//IL_0415: Expected Obj, but got I4
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected Obj, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected Obj, but got Unknown
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected Obj, but got Unknown
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected Obj, but got Unknown
		//IL_020e: Expected Obj, but got VT
		//IL_0232: Expected Obj, but got I8
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		object obj4 = obj2 + 16;
		obj4 = 0;
		object obj5 = obj2 + 8;
		obj5 = 0;
		object obj6 = obj2 + 32;
		obj6 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		object obj7 = default;
		if (obj7 != null)
		{
			object obj8 = obj7 + 12;
			object obj9 = default;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8))
			{
				object obj10 = obj7 + 16;
				object obj11 = obj9 << 2;
				object obj12 = obj10 + obj11;
				DateTime lastWriteTimeUtc = ((FileSystemInfo)obj12).LastWriteTimeUtc;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.SecretPopupInternal.SecretHelper)+90]");
				object obj13 = lastWriteTimeUtc + 0;
				DateTime lastWriteTimeUtc2 = ((FileSystemInfo)obj12).LastWriteTimeUtc;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.SecretPopupInternal.SecretHelper)+98]");
				object obj14 = lastWriteTimeUtc2 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				string path = default;
				DateTime lastWriteTime = File.GetLastWriteTime(path);
				obj4 = lastWriteTime;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				FileStream fileStream = default;
				long length = fileStream.Length;
				obj5 = length;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				obj3 = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				throw new ArrayTypeMismatchException();
			}
			string text = ((DirectoryInfo)(object)info).ToString();
			object obj15 = text + 12;
			object obj16 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15))
			{
				object obj17 = text + 16;
				object obj18 = obj16 << 2;
				object info2 = obj17 + obj18;
				UpdateInfo((string)info2, value);
				object obj19 = obj16 + 1;
				obj16 = obj19;
			}
		}
	}

	public void UpdateTitle(string title)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_01c4: Expected I, but got Obj
		//IL_01da: Expected Obj, but got I
		//IL_0278: Expected I, but got Obj
		//IL_028e: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0205: Expected I, but got Obj
		//IL_0309: Expected Obj, but got I4
		//IL_0175: Expected Obj, but got I
		//IL_0125: Expected I, but got Obj
		//IL_02ed: Expected Obj, but got I4
		//IL_00ba: Expected I, but got Obj
		if (title != null)
		{
			nint num = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v24 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v49 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool allAssetBundlesDownloaded = UserSave.allAssetBundlesDownloaded;
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v10 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			bool flag = obj2 != null;
			if (allAssetBundlesDownloaded)
			{
				if (flag)
				{
					nint num4 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v45 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag2 = UIScreenController.ShouldShowOnlineScreen();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				string text = default;
				text.m_stringLength = 13;
				_ = 1;
				((UIScreenController)flag2)._QueueMessage(text);
			}
			else
			{
				if (flag)
				{
					nint num5 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v37 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag3 = UIScreenController.ShouldShowOnlineScreen();
				((UIScreenController)flag3).QueuePopup("FBPromotionPopup");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.SecretPopupInternal.SecretHelper)+28]");
			((SettingsPopup)0)._002Ector();
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.SecretPopupInternal.SecretHelper)+2C]");
			if ((nint)0 != 0)
			{
				((SettingsLogInFacebookButton)this).QueueFacebookFailSlideIn((Action)null);
			}
			((SettingsLogInFacebookButton)this).SetToConnectingState();
		}
		nint num6 = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v8 (Il2CppClass<HouseKeeper>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num7 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HouseKeeper.DeleteSoundOptionBeforeVideoAds();
		_ = 0;
	}

	public void UpdateInfoDouble(string info, string value, string info2, string value2)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_008a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SecretCell secretCell = default;
		object obj = secretCell + 12;
		obj = info;
		object obj2 = secretCell + 16;
		obj2 = value;
		object obj3 = secretCell + 24;
		obj3 = info2;
		object obj4 = secretCell + 28;
		obj4 = value2;
		secretCell.cellType = SecretCellType.DoubleInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.SecretPopupInternal.SecretHelper)+50]");
		((List<SecretCell>)0).Add(secretCell);
	}
}

using System;
using AppRefresh;
using Cpp2ILInjected;
using Data.Save;
using Kiloo;
using UnityEngine;

namespace UI;

public class FrontHighscoreLabel : MonoBehaviour
{
	private UILabel _highScoreLabel;

	private UILabel _titleLabel;

	private void OnEnable()
	{
		CancelInvoke();
	}

	private unsafe void OnDisable()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(FrontHighscoreLabel.UpdateHighScore);
		object obj = action + 16;
		obj = this;
		PlayerSave.highScoreChanged -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<RefreshType> action2 = default;
		object obj2 = action2 + 16;
		obj2 = this;
		AppRefreshHandler.hasRefreshed -= action2;
		UpdateHighScore();
		this._002Ector();
	}

	private void UpdateTitleLabel()
	{
		//IL_005e: Expected Obj, but got I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		int num2 = default;
		object obj = num2 + 16;
		obj = this;
		PlayerSave.SetHighScore(num2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr = 0;
		AnimationPlayAfterDelay animationPlayAfterDelay = default;
		((UnityEngine.Object)animationPlayAfterDelay).m_CachedPtr = cachedPtr;
		_ = 0;
		object obj2 = animationPlayAfterDelay + 16;
		obj2 = this;
		animationPlayAfterDelay.OnEnable();
	}

	private void OnAppHasRefreshed(RefreshType refreshType)
	{
		//IL_0122: Expected Obj, but got I4
		//IL_0122: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I
		//IL_0146: Expected Obj, but got I
		//IL_0077: Expected I4, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_0092: Expected I4, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_00ad: Expected I4, but got Obj
		//IL_00ad: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I
		//IL_00f0: Expected I4, but got Obj
		//IL_00f0: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.FrontHighscoreLabel)+44]");
		((Component)0).tag = (string)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.FrontHighscoreLabel)+4C]");
		((Component)0).tag = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.FrontHighscoreLabel)+48]");
		((Component)0).tag = null;
		switch (refreshType)
		{
		case (RefreshType)0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.FrontHighscoreLabel)+44]");
			((UISprite)0).fillCenter = (byte)(int)"icon_diamond_medal" != 0;
			break;
		case RefreshType.UI:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.FrontHighscoreLabel)+44]");
			((UISprite)0).fillCenter = (byte)(int)"icon_gold_medal" != 0;
			break;
		case RefreshType.Data:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.FrontHighscoreLabel)+44]");
			((UISprite)0).fillCenter = (byte)(int)"icon_silver_medal" != 0;
			break;
		case (RefreshType)3:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.FrontHighscoreLabel)+44]");
			((UISprite)0).fillCenter = (byte)(int)"icon_bronze_medal" != 0;
			break;
		default:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.FrontHighscoreLabel)+44]");
			((Component)0).tag = null;
			break;
		}
	}

	private void UpdateHighScore()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00b0: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("FRONT_UI_SCORE_TITLE");
		_titleLabel.fontSize = (int)text;
	}

	public FrontHighscoreLabel()
	{
		//IL_0026: Expected Obj, but got I4
		//IL_0014: Expected I4, but got Obj
		int bragScoreThreshold = PlayerSave.bragScoreThreshold;
		object obj = bragScoreThreshold;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string text = $"{args:0000}";
		_highScoreLabel.fontSize = (int)text;
	}
}

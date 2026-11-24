using System;
using System.Collections;
using Cpp2ILInjected;
using UI.ModelCamera;
using UI.Screens;
using UnityEngine;

namespace UI.Pages.DailyChallengePageInternal;

public class FinalDayHelper : DayHelper
{
	private class DailyWordPayload
	{
		public bool mostRecentlyCompletedIsToday;

		public int activeDayIndex;

		public DailyWordPayload()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private UILabel _dayLabel;

	private UILabel _rewardLabel;

	private UISprite _checkMark;

	private UISprite _background;

	private Color _activeLabelColor;

	private Color _activeLabelShadowColor;

	private Color _inactiveLabelColor;

	private Color _inactiveLabelShadowColor;

	private UISprite[] _beams;

	private UISprite _glow;

	public override void Init()
	{
		CancelInvoke();
	}

	public override void RefreshDay()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	private void CompleteToday()
	{
		//IL_0014: Expected I4, but got Obj
		CharacterModel characterModel = ((ModelScreenData)null).characterModel;
		((RegularDayHelper)this).SetIndex((int)characterModel);
	}

	private void ActivateToday()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 5;
		_ = 1;
		int index = default;
		((RegularDayHelper)this).SetIndex(index);
	}

	private void DeactivateToday()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 5;
		_ = 0;
		int index = default;
		((RegularDayHelper)this).SetIndex(index);
	}

	private DailyWordPayload GetData()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DailyWordPayload dailyWordPayload = default;
		dailyWordPayload.mostRecentlyCompletedIsToday = false;
		object obj = dailyWordPayload + 16;
		obj = this;
		return dailyWordPayload;
	}

	private void SetupDay(DailyWordPayload payload)
	{
		//IL_0013: Expected I4, but got Obj
		//IL_0028: Expected VT, but got I4
		//IL_0028: Expected F4, but got Obj
		if (Application.platform != RuntimePlatform.OSXEditor)
		{
			((UISprite)(object)payload).fillCenter = (byte)(int)"mission_progress_dot_completed" != 0;
			IEnumerator routine = ((CelebrationPopup)(object)this).RotateGameObject((Transform)(object)payload, (float)_checkMark, (Vector3)0);
			Coroutine coroutine = StartCoroutine_Auto(routine);
		}
	}

	public FinalDayHelper()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 1;
		_ = 0;
		int index = default;
		((RegularDayHelper)this).SetIndex(index);
	}
}

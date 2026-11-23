using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using Kiloo;
using SYBO.Subway.Info;
using TMPro;
using UI.Screens;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ItemHuntPopup : UIScreen
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static UnityAction _003C_003E9__17_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003CAwake_003Eb__17_0()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.CloseActivePopups("ItemmHuntPopup");
		}
	}

	private sealed class _003CScrollOnTop_003Ed__20(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemHuntPopup _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0093: Expected I, but got Obj
			//IL_00bc: Expected I, but got Obj
			//IL_00ce: Expected I, but got Obj
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					Canvas.ForceUpdateCanvases();
					ScrollRect componentInChildren = _003C_003E4__this.GetComponentInChildren<ScrollRect>();
					VerticalLayoutGroup component = componentInChildren.m_Content.GetComponent<VerticalLayoutGroup>();
					nint num = (nint)component;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v78 @ S1_v13 (Il2CppClass<UnityEngine.UI.VerticalLayoutGroup>)+1A4] (should have been resolved before IL gen)");
					ContentSizeFitter component2 = componentInChildren.m_Content.GetComponent<ContentSizeFitter>();
					nint num2 = (nint)component2;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v91 @ S1_v18 (Il2CppClass<UnityEngine.UI.ContentSizeFitter>)+15C] (should have been resolved before IL gen)");
					nint num3 = (nint)componentInChildren;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v97 @ S3_v3 (Il2CppClass<UnityEngine.UI.ScrollRect>)+244] (should have been resolved before IL gen)");
				}
				return false;
			}
			_003C_003E1__state = -1;
			_ = 0.15f;
			object obj = default;
			_003C_003E2__current = obj;
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private Button CloseButton;

	private GameObject content;

	private GameObject periodPrefab;

	private TMP_Text bottomSubtitle;

	private TMP_Text bottomTitle;

	private PrizeIconPrefabReferences iconReferences;

	private ItemHuntPopupCell currentActiveCell;

	private WeeklyHuntManager.WeeklyHuntPeriodData prizeOne;

	private WeeklyHuntManager.WeeklyHuntPeriodData prizeTwo;

	private WeeklyHuntManager.WeeklyHuntPeriodData prizeThree;

	private WeeklyHuntManager.WeeklyHuntPeriodData prizeFour;

	private bool _instantiatedPeriodCells;

	private ItemHuntPopupCell periodOne;

	private ItemHuntPopupCell periodTwo;

	private ItemHuntPopupCell periodThree;

	private ItemHuntPopupCell periodFour;

	private DateTime endDate = DateTime.MinValue;

	private UIPopupIn UIPopupIn;

	private unsafe void Awake()
	{
		Button closeButton = CloseButton;
		bool flag = _003C_003Ec._003C_003E9__17_0 == null;
		bool flag2 = !flag;
		UnityAction call = _003C_003Ec._003C_003E9__17_0;
		if (!flag2)
		{
			UnityAction unityAction = default;
			unityAction._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CAwake_003Eb__17_0));
			_003C_003Ec._003C_003E9__17_0 = unityAction;
			call = unityAction;
		}
		closeButton.m_OnClick.AddListener(call);
		UnityAction unityAction2 = default;
		unityAction2._002Ector(this, (nint)__ldftn(ItemHuntPopup._003CAwake_003Eb__17_1));
		OutConplete.AddListener(unityAction2);
	}

	public override void Init()
	{
		//IL_0005: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<ItemHuntPopup>)+104] (should have been resolved before IL gen)");
	}

	public override void Show()
	{
		base.Show();
		ShowPopUp();
		WeeklyHuntManager.SetAlternativeHuntPrizeData();
		HandleData();
		IEnumerator routine = ScrollOnTop();
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator ScrollOnTop()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void GetComponent()
	{
		if (UIPopupIn == null)
		{
			UIPopupIn componentInChildren = GetComponentInChildren<UIPopupIn>();
			UIPopupIn = componentInChildren;
		}
	}

	private void ShowPopUp()
	{
		GetComponent();
		UIPopupIn.PlayAnim(UIPopupIn.TYPE.IN);
	}

	public void HidePupUp()
	{
		GetComponent();
		UIPopupIn.PlayAnim(UIPopupIn.TYPE.OUT);
	}

	public override void Hide()
	{
		base.Hide();
		periodOne.HidePrizeIcon();
		periodTwo.HidePrizeIcon();
		periodThree.HidePrizeIcon();
		periodFour.HidePrizeIcon();
		ResetCell(periodOne);
		ResetCell(periodTwo);
		ResetCell(periodThree);
		ResetCell(periodFour);
		currentActiveCell = null;
	}

	private void ResetCell(ItemHuntPopupCell cell)
	{
		if (!cell)
		{
			GameObject gameObject = base.gameObject;
			return;
		}
		cell.activeLabels.SetActive(value: false);
		cell.activeProgressSlider.SetActive(value: false);
		cell.inactiveLabels.SetActive(value: true);
		cell.stickerGroup.SetActive(value: false);
		cell.inactiveProgressGroup.SetActive(value: true);
	}

	private unsafe void HandleData()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_065f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Expected VT, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected VT, but got Unknown
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected VT, but got Unknown
		//IL_030c: Expected native int or pointer, but got VT
		//IL_0321: Expected native int or pointer, but got VT
		//IL_0336: Expected native int or pointer, but got VT
		//IL_0358: Expected native int or pointer, but got VT
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Expected Obj, but got Unknown
		//IL_04e5: Expected I, but got Obj
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected Obj, but got Unknown
		//IL_051d: Expected I, but got Obj
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected Obj, but got Unknown
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0562: Expected Obj, but got Unknown
		object obj = default;
		WeeklyHuntManager.PrizeData prizeData = (WeeklyHuntManager.PrizeData)(obj - 288);
		WeeklyHuntManager.WeeklyHuntPeriodData prizeDataForPeriod = WeeklyHuntManager.GetPrizeDataForPeriod(WeeklyHuntManager.PrizePeriodId.PeriodOne);
		prizeOne = prizeDataForPeriod;
		WeeklyHuntManager.WeeklyHuntPeriodData prizeDataForPeriod2 = WeeklyHuntManager.GetPrizeDataForPeriod(WeeklyHuntManager.PrizePeriodId.PeriodTwo);
		prizeTwo = prizeDataForPeriod2;
		WeeklyHuntManager.WeeklyHuntPeriodData prizeDataForPeriod3 = WeeklyHuntManager.GetPrizeDataForPeriod(WeeklyHuntManager.PrizePeriodId.PeriodThree);
		prizeThree = prizeDataForPeriod3;
		WeeklyHuntManager.WeeklyHuntPeriodData prizeDataForPeriod4 = WeeklyHuntManager.GetPrizeDataForPeriod(WeeklyHuntManager.PrizePeriodId.PeriodFour);
		prizeFour = prizeDataForPeriod4;
		if (~(_instantiatedPeriodCells ? 1u : 0u) != 0)
		{
			_instantiatedPeriodCells = true;
			GameObject gameObject = NGUITools.AddChild(content, periodPrefab);
			ItemHuntPopupCell component = gameObject.GetComponent<ItemHuntPopupCell>();
			periodOne = component;
			GameObject gameObject2 = NGUITools.AddChild(content, periodPrefab);
			ItemHuntPopupCell component2 = gameObject2.GetComponent<ItemHuntPopupCell>();
			periodTwo = component2;
			GameObject gameObject3 = NGUITools.AddChild(content, periodPrefab);
			ItemHuntPopupCell component3 = gameObject3.GetComponent<ItemHuntPopupCell>();
			periodThree = component3;
			GameObject gameObject4 = NGUITools.AddChild(content, periodPrefab);
			ItemHuntPopupCell component4 = gameObject4.GetComponent<ItemHuntPopupCell>();
			periodFour = component4;
		}
		ItemHuntPopupCell itemHuntPopupCell = periodOne;
		WeeklyHuntManager.PrizeData prizeForPeriod = WeeklyHuntManager.GetPrizeForPeriod(WeeklyHuntManager.PrizePeriodId.PeriodOne);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+118]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+110]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+108]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+108]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+110]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+118]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+100]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+100]");
		_ = 0;
		WeeklyHuntManager.PrizeData prizeData2 = (WeeklyHuntManager.PrizeData)(prizeData + 96);
		GameObject prefab = iconReferences.GetPrefab(prizeData2);
		itemHuntPopupCell.iconPrefab__BackingField = prefab;
		ItemHuntPopupCell itemHuntPopupCell2 = periodTwo;
		WeeklyHuntManager.PrizeData prizeForPeriod2 = WeeklyHuntManager.GetPrizeForPeriod(WeeklyHuntManager.PrizePeriodId.PeriodTwo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+118]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+110]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+108]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+108]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+110]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+118]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+100]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+100]");
		_ = 0;
		WeeklyHuntManager.PrizeData prizeData3 = (WeeklyHuntManager.PrizeData)(prizeData - -64);
		GameObject prefab2 = iconReferences.GetPrefab(prizeData3);
		itemHuntPopupCell2.iconPrefab__BackingField = prefab2;
		ItemHuntPopupCell itemHuntPopupCell3 = periodThree;
		WeeklyHuntManager.PrizeData prizeForPeriod3 = WeeklyHuntManager.GetPrizeForPeriod(WeeklyHuntManager.PrizePeriodId.PeriodThree);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+118]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+110]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+108]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+108]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+110]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+118]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+100]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+100]");
		_ = 0;
		WeeklyHuntManager.PrizeData prizeData4 = (WeeklyHuntManager.PrizeData)(prizeData + 32);
		GameObject prefab3 = iconReferences.GetPrefab(prizeData4);
		itemHuntPopupCell3.iconPrefab__BackingField = prefab3;
		ItemHuntPopupCell itemHuntPopupCell4 = periodFour;
		WeeklyHuntManager.PrizeData prizeForPeriod4 = WeeklyHuntManager.GetPrizeForPeriod(WeeklyHuntManager.PrizePeriodId.PeriodFour);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+118]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+110]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+108]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+108]");
		((WeeklyHuntManager.PrizeData*)(nint)prizeData)->rewardType = CelebrationRewardType._notset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+110]");
		((WeeklyHuntManager.PrizeData*)(nint)prizeData)->characterType = Characters.CharacterType.slick;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+118]");
		((WeeklyHuntManager.PrizeData*)(nint)prizeData)->trophyType = Trophies.Trophy.diamond;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+100]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (WeeklyHuntManager+PrizeData)+100]");
		((WeeklyHuntManager.PrizeData*)(nint)prizeData)->amount = 0;
		GameObject prefab4 = iconReferences.GetPrefab(prizeData);
		itemHuntPopupCell4.iconPrefab__BackingField = prefab4;
		switch (WeeklyHuntManager.GetActivePeriode())
		{
		case WeeklyHuntManager.PrizePeriodId.PeriodOne:
			currentActiveCell = periodOne;
			break;
		case WeeklyHuntManager.PrizePeriodId.PeriodTwo:
			currentActiveCell = periodTwo;
			break;
		case WeeklyHuntManager.PrizePeriodId.PeriodThree:
			currentActiveCell = periodThree;
			break;
		case WeeklyHuntManager.PrizePeriodId.PeriodFour:
			currentActiveCell = periodFour;
			break;
		default:
			currentActiveCell = null;
			break;
		case WeeklyHuntManager.PrizePeriodId.None:
			break;
		}
		UpdateCell(periodOne, prizeOne, WeeklyHuntManager.PrizePeriodId.PeriodOne);
		UpdateCell(periodTwo, prizeTwo, WeeklyHuntManager.PrizePeriodId.PeriodTwo);
		UpdateCell(periodThree, prizeThree, WeeklyHuntManager.PrizePeriodId.PeriodThree);
		UpdateCell(periodFour, prizeFour, WeeklyHuntManager.PrizePeriodId.PeriodFour);
		object obj4;
		bool active;
		if (!WeeklyHuntManager.IsAnyPeriodActive() && WeeklyHuntManager.GetActivePeriode() == WeeklyHuntManager.PrizePeriodId.None)
		{
			TMP_Text tMP_Text = bottomTitle;
			string text = Strings.Get(StringID.WEEKLY_HUNT_ENDED_TITLE);
			nint num = (nint)tMP_Text;
			object obj2 = tMP_Text + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v369 @ S2_v30 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			TMP_Text tMP_Text2 = bottomSubtitle;
			string text2 = Strings.Get(StringID.WEEKLY_HUNT_ENDED_SUBTITLE);
			nint num2 = (nint)tMP_Text2;
			object obj3 = tMP_Text2 + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v388 @ S2_v35 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			GameObject gameObject5 = bottomSubtitle.gameObject;
			gameObject5.SetActive(value: true);
			obj4 = this + 68;
			active = true;
		}
		else
		{
			GameObject gameObject6 = bottomSubtitle.gameObject;
			gameObject6.SetActive(value: false);
			obj4 = this + 68;
			active = false;
		}
		GameObject gameObject7 = ((Component)obj4).gameObject;
		gameObject7.SetActive(active);
	}

	private unsafe void UpdateCell(ItemHuntPopupCell cell, WeeklyHuntManager.WeeklyHuntPeriodData periodData, WeeklyHuntManager.PrizePeriodId periodId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected I4, but got Unknown
		//IL_0081: Expected I, but got Obj
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_00af: Expected Obj, but got I
		//IL_037b: Expected I, but got Obj
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected Obj, but got Unknown
		//IL_0463: Expected Obj, but got I4
		//IL_0297: Expected I, but got Obj
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_047a: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		bool flag = cell == currentActiveCell;
		WeeklyHuntManager.PrizeData prizeForPeriod = WeeklyHuntManager.GetPrizeForPeriod(periodId);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		TMP_Text amountLable = cell.amountLable;
		int num = obj + 32;
		string text = ((int*)num)->ToString();
		nint num2 = (nint)amountLable;
		object obj3 = amountLable + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v68 @ S2_v6 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
		string path = "UI/" + (string)0;
		Sprite sprite = Resources.Load<Sprite>(path);
		cell.icon.sprite = sprite;
		WeeklyHuntManager.PeriodStatus periodStatus = WeeklyHuntManager.GetPeriodStatus(periodId);
		if (flag)
		{
			cell.activeLabels.SetActive(value: true);
			cell.activeProgressSlider.SetActive(value: true);
			cell.inactiveLabels.SetActive(value: false);
			cell.stickerGroup.SetActive(value: true);
			cell.inactiveProgressGroup.SetActive(value: false);
			cell.spriteCirclePrizeUnknown.enabled = false;
			cell.fail.SetActive(value: false);
			if (periodData.itemsCollected == periodData.itemsToColect)
			{
				cell.spriteCirclePrizeCompleted.enabled = true;
				cell.spriteCirclePrizeCompleted.sprite = cell.finish;
			}
			else
			{
				cell.spriteCirclePrizeCompleted.enabled = false;
			}
			cell.stickerGroup.SetActive(value: true);
			endDate = periodData.periodEndDate;
			DateTime now = CDateTime.Now;
			TimeSpan theStickerContent = periodData.periodEndDate - now;
			cell.SetTheStickerContent(theStickerContent);
			TMP_Text inactivePeriodTitle = cell.inactivePeriodTitle;
			string text2 = Strings.Get(periodData.periodTitle);
			nint num3 = (nint)inactivePeriodTitle;
			object obj4 = inactivePeriodTitle + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v305 @ S2_v52 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			cell.RefreshProgressBar(cell.activeProgressSlider, cell.activeProgressText, periodData.itemsCollected, periodData.itemsToColect);
			return;
		}
		cell.activeLabels.SetActive(value: false);
		cell.activeProgressSlider.SetActive(value: false);
		cell.inactiveLabels.SetActive(value: true);
		cell.stickerGroup.SetActive(value: false);
		cell.inactiveProgressGroup.SetActive(value: true);
		TMP_Text activePeriodTitle = cell.activePeriodTitle;
		string text3 = Strings.Get(periodData.periodTitle);
		nint num4 = (nint)activePeriodTitle;
		object obj5 = activePeriodTitle + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v166 @ S2_v22 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		cell.RefreshProgressBar(cell.inactiveProgressSlider, cell.inactiveProgressText, periodData.itemsCollected, periodData.itemsToColect);
		switch (periodStatus)
		{
		case WeeklyHuntManager.PeriodStatus.Expired:
		{
			cell.fail.SetActive(value: false);
			cell.spriteCirclePrizeUnknown.enabled = false;
			cell.spriteCirclePrizeCompleted.enabled = true;
			bool flag2 = periodData.itemsCollected == periodData.itemsToColect;
			object obj6 = 152;
			if (!flag2)
			{
				obj6 = 156;
			}
			object sprite2 = (object)cell + obj6;
			cell.spriteCirclePrizeCompleted.sprite = (Sprite)sprite2;
			GameObject gameObject = cell.prizebgMaskSprite.gameObject;
			gameObject.SetActive(value: true);
			GameObject gameObject2 = cell.progressMask.gameObject;
			gameObject2.SetActive(value: true);
			break;
		}
		case WeeklyHuntManager.PeriodStatus.Unstarted:
			cell.fail.SetActive(value: true);
			cell.spriteCirclePrizeUnknown.enabled = false;
			cell.spriteCirclePrizeCompleted.enabled = false;
			break;
		}
	}

	private void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0032: Expected Obj, but got I8
		//IL_0094: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		DateTime now = CDateTime.Now;
		TimeSpan timeSpan = endDate - now;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		object obj3 = 0 / 864000000000L;
		if ((nint)obj3 <= 0 && currentActiveCell != null)
		{
			ItemHuntPopupCell itemHuntPopupCell = currentActiveCell;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			itemHuntPopupCell.SetTheStickerContent((TimeSpan)0);
		}
	}

	private void _003CAwake_003Eb__17_1()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<ItemHuntPopup>)+EC] (should have been resolved before IL gen)");
	}
}

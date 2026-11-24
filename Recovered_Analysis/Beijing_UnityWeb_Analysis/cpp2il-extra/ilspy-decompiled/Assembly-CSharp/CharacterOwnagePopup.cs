using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Managers;
using Kiloo.Common.Backend.PurchaseValidation;
using Kiloo.Common.HTTP;
using Kiloo.Common.UI;
using SYBO.Subway.Info;
using TopRun;
using TopRun.UI;
using UI.Screens;
using UnityEngine;

public class CharacterOwnagePopup : UIScreen
{
	private class CharacterOwnageListAdapter : ListAdapter<KeyValuePair<Characters.CharacterId, Characters.Model>>
	{
		private GameObject _cellPrefab;

		public CharacterOwnageListAdapter(List<KeyValuePair<Characters.CharacterId, Characters.Model>> items, GameObject cell)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = items;
			object obj2 = cell + 8;
			obj2 = cell;
		}

		public override Container GetContainer(Container container, int dataIndex, bool isMeasurePass = false)
		{
			//IL_0763: Expected Obj, but got I
			//IL_0536: Expected Obj, but got I4
			//IL_0536: Expected Obj, but got I
			//IL_0536: Expected Obj, but got I
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected Obj, but got Unknown
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Expected Obj, but got Unknown
			//IL_05d7: Expected Obj, but got I
			//IL_055c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0561: Expected Obj, but got Unknown
			//IL_0571: Expected Obj, but got I
			//IL_057a: Unknown result type (might be due to invalid IL or missing references)
			//IL_057f: Expected Obj, but got Unknown
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Expected Obj, but got Unknown
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Expected Obj, but got Unknown
			//IL_0149: Unknown result type (might be due to invalid IL or missing references)
			//IL_014e: Expected Obj, but got Unknown
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c5: Expected Obj, but got Unknown
			//IL_01db: Expected Obj, but got I
			//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f1: Expected Obj, but got Unknown
			//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ff: Expected Obj, but got Unknown
			//IL_021a: Unknown result type (might be due to invalid IL or missing references)
			//IL_021f: Expected Obj, but got Unknown
			//IL_0455: Unknown result type (might be due to invalid IL or missing references)
			//IL_045a: Expected Obj, but got Unknown
			//IL_047d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0482: Expected Obj, but got Unknown
			//IL_0353: Unknown result type (might be due to invalid IL or missing references)
			//IL_0358: Expected Obj, but got Unknown
			//IL_036e: Expected Obj, but got I
			//IL_037f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0384: Expected Obj, but got Unknown
			//IL_038d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0392: Expected Obj, but got Unknown
			//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b2: Expected Obj, but got Unknown
			//IL_06c5: Expected Obj, but got I4
			//IL_06c5: Expected Obj, but got I
			//IL_0726: Expected Obj, but got I
			//IL_0726: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			Container container2 = default;
			object obj6 = default;
			if (container2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6+8]");
				object obj2 = default;
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterOwnagePopup+CharacterOwnageListAdapter)+18]");
					Container container3 = default;
					container3.Measure(includeInactive: false);
					object obj = obj2 + 8;
					RankHeader component = container3.model.GetComponent<RankHeader>();
					obj = component;
					object obj3 = container3 + 84;
					obj3 = obj2;
					container2 = container3;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6+8]");
					if ((nint)0 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterOwnagePopup+CharacterOwnageListAdapter)+14]");
						Container container4 = default;
						container4.Measure(includeInactive: false);
						object obj4 = obj2 + 24;
						TopRunPlayerCell component2 = container4.model.GetComponent<TopRunPlayerCell>();
						obj4 = component2;
						object obj5 = obj6 + 32;
						obj5 = component2;
						object obj7 = container4 + 84;
						obj7 = obj2;
						container2 = container4;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6+8]");
						if ((nint)0 == 4)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterOwnagePopup+CharacterOwnageListAdapter)+28]");
							Container container5 = default;
							container5.Measure(includeInactive: false);
							object obj8 = obj2 + 28;
							nint num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S3_v14 (Il2CppMethodInfo)+18]");
							object obj9 = 0;
							object obj10 = obj9;
							object obj11 = obj10 & 0x1FFF;
							object obj12 = obj11 + 22691;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v31 @ S4_v14 (should have been resolved before IL gen)");
							object obj13 = default;
							obj8 = obj13;
							object obj14 = container5 + 84;
							obj14 = obj2;
							container2 = container5;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6+8]");
							if ((nint)0 == 5)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterOwnagePopup+CharacterOwnageListAdapter)+2C]");
								Container container6 = default;
								container6.Measure(includeInactive: false);
								container2 = container6;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6+8]");
								if ((nint)0 == 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterOwnagePopup+CharacterOwnageListAdapter)+1C]");
									Container container7 = default;
									container7.Measure(includeInactive: false);
									container2 = container7;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6+8]");
									if ((nint)0 == 6)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterOwnagePopup+CharacterOwnageListAdapter)+30]");
										Container container8 = default;
										container8.Measure(includeInactive: false);
										object obj15 = obj2 + 32;
										nint num2 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ S3_v10 (Il2CppMethodInfo)+18]");
										object obj16 = 0;
										object obj17 = obj16;
										object obj18 = obj17 & 0x1FFF;
										object obj19 = obj18 + 22691;
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v32 @ S4_v10 (should have been resolved before IL gen)");
										object obj20 = default;
										obj15 = obj20;
										object obj21 = container8 + 84;
										obj21 = obj2;
										container2 = container8;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6+8]");
										if ((nint)0 == 7)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterOwnagePopup+CharacterOwnageListAdapter)+1C]");
											Container container9 = default;
											container9.Measure(includeInactive: false);
											container2 = container9;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterOwnagePopup+CharacterOwnageListAdapter)+20]");
											Container container10 = default;
											container10.Measure(includeInactive: false);
											object obj22 = obj2 + 12;
											TopRunEmptyCell component3 = container10.model.GetComponent<TopRunEmptyCell>();
											obj22 = component3;
											object obj23 = container10 + 84;
											obj23 = obj2;
											container2 = container10;
										}
									}
								}
							}
						}
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6+8]");
				if ((nint)0 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6+18]");
					bool flag = (nint)0 != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6+19]");
					bool keys = (nint)0 != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v53+18]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6+14]");
					nint num4 = 0;
					bool flag2 = flag;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6+C]");
					((CoinEarnerVideoAds)num3).SetButtonText((string)num4, (string)flag2, 0, keys);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num5 = 0;
					_ = 0;
					object obj25 = default;
					object obj24 = obj25 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v53+18]");
					obj24 = 0;
					object obj26 = obj6 + 28;
					obj26 = obj25;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6+8]");
					if ((nint)0 == 4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v49+1C]");
						((TopRunNormalStateHelper)0).Update();
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6+8]");
						if ((nint)0 != 5)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6+8]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6+8]");
								if ((nint)0 == 6)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
									GameObject cellPrefab = _cellPrefab;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S1_v23 (UnityEngine.GameObject)+5D]");
									bool flag3 = (nint)0 != 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S0_v45+20]");
									((BundlePurchaseButton)0).OnPurchaseSuccess((string)flag3, false, (IPurchaseValidationResult)(object)_cellPrefab);
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6+8]");
									if ((nint)0 == 3)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ S0_v41+C]");
										nint num6 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6+C]");
										((TopRunEventsHandler)num6).OnTopRunChangedEvent += (EventHandler<TournamentChangedEventArgs>)0;
									}
								}
							}
						}
					}
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v16+8]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6+C]");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6+10]");
				((RankHeader)num7).setTextAndColours((int)num8, 0);
			}
			return container2;
		}
	}

	private GameObject _cellPrefab;

	private ScrollView _scrollView;

	private CharacterOwnageListAdapter _adapter;

	private bool _showAllCharacters;

	private GameObject _offIcon;

	private GameObject _onIcon;

	private List<KeyValuePair<Characters.CharacterId, Characters.Model>> _list;

	public override void Init()
	{
		CancelInvoke();
	}

	public override void Show()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_0080: Expected Obj, but got I4
		//IL_0027: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<KeyValuePair<Characters.CharacterId, Characters.Model>> list = default;
		list._002Ector();
		object obj = this - -64;
		obj = list;
		bool showAllCharacters = _showAllCharacters;
		_offIcon.tag = (string)showAllCharacters;
		bool showAllCharacters2 = _showAllCharacters;
		string text = (string)((showAllCharacters2 ? 1 : 0) ^ 1);
		_onIcon.tag = text;
	}

	public void ToggleActive()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected Obj, but got Unknown
		//IL_02c8: Expected Obj, but got I4
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected Obj, but got Unknown
		//IL_02eb: Expected Obj, but got I4
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected Obj, but got Unknown
		//IL_0330: Expected I, but got Obj
		//IL_0346: Expected Obj, but got I
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected Obj, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected Obj, but got Unknown
		//IL_03ea: Expected Obj, but got I4
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected Obj, but got Unknown
		//IL_045f: Expected I4, but got Obj
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected Obj, but got Unknown
		//IL_0483: Expected I4, but got Obj
		//IL_0206: Expected Obj, but got I
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected Obj, but got Unknown
		//IL_00c1: Expected I, but got Obj
		//IL_00d7: Expected Obj, but got I
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected Obj, but got Unknown
		//IL_0102: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 80;
		object obj3 = obj2 + 48;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 8;
		obj4 = 0;
		object obj5 = obj2 + 40;
		obj5 = obj;
		_ = -1;
		base.Hide();
		object obj6 = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
		nint num = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v25 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v136 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj8 = obj2 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v30+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v30+10]");
		_ = 0;
		object obj9 = default;
		object obj11 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj9 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj8;
			if (!_showAllCharacters)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num3 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S0_v122 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num4 = (nint)typeof(CharacterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v129 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj11 == null)
				{
					continue;
				}
			}
			object obj12 = this - -64;
			obj2 = obj4;
			obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj13 = obj5 + 4;
		object obj14 = obj13 + 1;
		obj13 = obj14;
		object obj15 = obj14 << 2;
		object obj16 = obj5 + obj15;
		obj16 = 97;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj17 = (nint)0 << 2;
			object obj18 = obj5 + obj17;
			if ((nint)obj18 == 97)
			{
				object obj19 = obj5 + 4;
				if ((nint)obj19 > -1)
				{
					object obj20 = obj19 + -1;
					obj19 = obj20;
				}
				goto IL_0437;
			}
		}
		object obj21 = default;
		if (obj21 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0437;
		IL_0437:
		object request = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DebugSettingsPopup._003C_003Ec obj22 = default;
		obj22._003CRequestAnalyticsCheck_003Eb__140_0((IRequest)request, (byte)(int)_cellPrefab != 0);
		object obj23 = this + 48;
		obj23 = obj22;
		_scrollView.CalculateVirtualRelativeWidgetBounds((ScrollView.BoundsCalculationMode)_adapter);
	}

	public CharacterOwnagePopup()
	{
		//IL_004f: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I4
		bool showAllCharacters = _showAllCharacters;
		bool showAllCharacters2 = (byte)((showAllCharacters ? 1u : 0u) ^ 1u) != 0;
		_showAllCharacters = showAllCharacters2;
		bool showAllCharacters3 = _showAllCharacters;
		_offIcon.tag = (string)showAllCharacters3;
		bool showAllCharacters4 = _showAllCharacters;
		string text = (string)((showAllCharacters4 ? 1 : 0) ^ 1);
		_onIcon.tag = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}
}

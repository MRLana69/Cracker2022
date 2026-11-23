using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo;
using Kiloo.Common.UI;
using TopRun;
using UI.Screens;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CountryPopup : UIScreen
{
	public class CountryListAdapter : ListAdapter<Country>
	{
		public GameObject countryCell;

		public Transform countryContent;

		public List<Country> countryList;

		private CountryPopup countryPopup;

		public CountryListAdapter(List<Country> countryListT, GameObject cell, CountryPopup popup)
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S3_v4 (Il2CppClass<Il2CppRgctx<Kiloo.Common.UI.ListAdapter`1<Country>>>)+4] (should have been resolved before IL gen)");
			countryCell = cell;
			countryList = countryListT;
			countryPopup = popup;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static UnityAction _003C_003E9__8_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003COnEnable_003Eb__8_0()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.CloseActivePopups("CountryPopup");
		}
	}

	private sealed class _003CScrollOnItem_003Ed__10(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CountryPopup _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_009d: Expected I, but got Obj
			//IL_00c6: Expected I, but got Obj
			//IL_00e0: Expected Obj, but got I
			//IL_00f6: Expected Obj, but got I
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Expected Obj, but got Unknown
			//IL_0123: Expected I, but got Obj
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					CountryPopup countryPopup = _003C_003E4__this;
					_003C_003E1__state = -1;
					Canvas.ForceUpdateCanvases();
					ScrollRect componentInChildren = _003C_003E4__this.GetComponentInChildren<ScrollRect>();
					VerticalLayoutGroup component = componentInChildren.m_Content.GetComponent<VerticalLayoutGroup>();
					nint num = (nint)component;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v82 @ S1_v13 (Il2CppClass<UnityEngine.UI.VerticalLayoutGroup>)+1A4] (should have been resolved before IL gen)");
					ContentSizeFitter component2 = componentInChildren.m_Content.GetComponent<ContentSizeFitter>();
					nint num2 = (nint)component2;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v95 @ S1_v18 (Il2CppClass<UnityEngine.UI.ContentSizeFitter>)+15C] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v17 (CountryPopup)+40]");
					object obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S3_v3+C]");
					object obj2 = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v17 (CountryPopup)+50]");
					object obj3 = 0 / obj2;
					float num3 = 1f - (float)obj3;
					nint num4 = (nint)componentInChildren;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v112 @ S3_v7 (Il2CppClass<UnityEngine.UI.ScrollRect>)+244] (should have been resolved before IL gen)");
				}
				return false;
			}
			_003C_003E1__state = -1;
			_ = 0.15f;
			object obj4 = default;
			_003C_003E2__current = obj4;
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

	private GameObject countryCell;

	private Transform countryContent;

	private Button CloseButton;

	private List<CountryCellController> countryCellControllers;

	private CountryListAdapter adapter;

	private string countryLocale;

	private ScrollRect scroller;

	private int startingPanel;

	private UIPopupIn UIPopupIn;

	private unsafe void OnEnable()
	{
		Button closeButton = CloseButton;
		bool flag = _003C_003Ec._003C_003E9__8_0 == null;
		bool flag2 = !flag;
		UnityAction call = _003C_003Ec._003C_003E9__8_0;
		if (!flag2)
		{
			UnityAction unityAction = default;
			unityAction._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003COnEnable_003Eb__8_0));
			_003C_003Ec._003C_003E9__8_0 = unityAction;
			call = unityAction;
		}
		closeButton.m_OnClick.AddListener(call);
		UnityAction unityAction2 = default;
		unityAction2._002Ector(this, (nint)__ldftn(CountryPopup._003COnEnable_003Eb__8_1));
		OutConplete.AddListener(unityAction2);
	}

	public override void Init()
	{
		//IL_0005: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<CountryPopup>)+104] (should have been resolved before IL gen)");
		CreateCountry();
	}

	private IEnumerator ScrollOnItem()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void CreateCountry()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Expected Obj, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_0763: Unknown result type (might be due to invalid IL or missing references)
		//IL_0768: Expected Obj, but got Unknown
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Expected Obj, but got Unknown
		//IL_063e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0643: Expected Obj, but got Unknown
		//IL_00d3: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		List<CountryCellController> list = countryCellControllers;
		if (list._size != 0)
		{
			return;
		}
		CountryManager instance = CountryManager.instance;
		List<Country> listOfCountries = CountryData.getListOfCountries();
		CountryListAdapter countryListAdapter = default;
		countryListAdapter._002Ector(listOfCountries, countryCell, this);
		adapter = countryListAdapter;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		string text2 = default;
		string text = text2.ToLower();
		object obj3 = obj + 16;
		CountryListAdapter countryListAdapter2 = adapter;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		int num = 0;
		object obj6 = default;
		object obj8 = default;
		string text3 = default;
		object obj9 = default;
		object obj10 = default;
		object obj11 = default;
		object obj13 = default;
		object obj14 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_05f0;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj7 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (obj8 != null)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									goto IL_0561;
								}
								countryLocale = text3;
								startingPanel = num;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											if (obj9 == null)
											{
												goto IL_0465;
											}
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																if ((nint)0 != 1)
																{
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																	if ((nint)0 != 1)
																	{
																		goto IL_0465;
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																}
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
															}
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														}
														goto IL_0561;
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_0561;
			IL_0561:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj10 != obj11;
			object obj12 = obj13;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_05f0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj12 = obj14;
			break;
			IL_05f0:
			object obj15 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3C3D");
			return;
			IL_0465:
			int num2 = num + 1;
			num = num2;
		}
		_ = 0;
		object obj16 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
	}

	public override void Show()
	{
		base.Show();
		ShowPopUp();
		IEnumerator routine = ScrollOnItem();
		Coroutine coroutine = StartCoroutine(routine);
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
	}

	private void OnDisable()
	{
		if (TopRunRoot.manager__BackingField != null)
		{
			throw new ArgumentException();
		}
	}

	private void TournamentChanged(object sender, TournamentChangedEventArgs eventArg)
	{
		if (TopRunRoot.manager__BackingField == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [eventArg @ L2 (System.Object)+9]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string text = default;
			string text2 = default;
			if (text != text2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A1");
				DateTime utcNow = CDateTime.UtcNow;
				DateTime dateTime = default;
				if (dateTime < utcNow)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					object obj2 = default;
					if (obj2 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
						object obj3 = default;
						if (obj3 == null)
						{
							goto IL_0156;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
				}
			}
		}
		goto IL_0156;
		IL_0156:
		throw new ArgumentException();
	}

	public void OnClick(string countryLocale)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		if (this.countryLocale != countryLocale)
		{
			object obj = this + 72;
			obj = countryLocale;
			string text = countryLocale.ToUpper();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			UpdatePopupUI();
		}
	}

	public void OnClickContainer(GameObject go)
	{
	}

	public void UpdatePopupUI()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected Obj, but got Unknown
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected Obj, but got Unknown
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Expected Obj, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected Obj, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected Obj, but got Unknown
		//IL_004e: Expected Obj, but got I
		//IL_02e3: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7;
		object obj9 = default;
		int num = default;
		int num2 = default;
		object obj10 = default;
		object obj11 = default;
		object obj13 = default;
		object obj14 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj6 == null;
				obj7 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj8 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj9 != null)
								{
									startingPanel = num;
								}
								num = num2 + 1;
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							goto IL_01a0;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_01a0;
			IL_01a0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj10 == obj11;
			bool flag3 = !flag2;
			object obj12 = obj13;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj7 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj12 = obj14;
			}
			_ = 0;
			object obj15 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj7 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj16 = obj7 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A196");
	}

	public CountryPopup()
	{
		List<CountryCellController> list = default;
		list._002Ector();
		countryCellControllers = list;
		base._002Ector();
	}

	private void _003COnEnable_003Eb__8_1()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<CountryPopup>)+EC] (should have been resolved before IL gen)");
	}
}

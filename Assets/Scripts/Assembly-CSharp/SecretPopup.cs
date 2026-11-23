using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Info;
using Kiloo;
using Kiloo.Analytics;
using Kiloo.Common.UI;
using Kiloo.Common.Utility;
using Kiloo.Plugins.DeviceUtility;
using SYBO.Components.Analytics;
using UI.Screens;
using UnityEngine;

public class SecretPopup : UIScreen
{
	private struct PageContent(string key, Func<string> value, SecretCellType infoType = SecretCellType.Info, string key2 = null, Func<string> value2 = null)
	{
		public string key = key;

		public Func<string> value = value;

		public SecretCellType infoType = infoType;

		public string key2 = key2;

		public Func<string> value2 = value2;
	}

	private enum TabNumber
	{
		Tab1,
		Tab2,
		Tab3,
		Tab4
	}

	public class SecretListAdapter : ListAdapter<SecretCell>
	{
		public SecretPopup secretScreen;

		public GameObject secretPrefab;

		public GameObject secretSubtitlePrefab;

		public GameObject secretEndList;

		public GameObject secretInfoDoublePrefab;

		private const int SECRET_INFO_PREFAB = 0;

		private const int SECRET_SUBTITLE_PREFAB = 1;

		private const int SECRET_ENDLIST_PREFAB = 2;

		private const int SECRET_INFO_DOUBLE_PREFAB = 3;

		public SecretListAdapter(List<SecretCell> contentList, GameObject newSecretPrefab, GameObject newInfoDoublePrefab, GameObject newSecretSubtitlePrefab, GameObject newSecretEndList, SecretPopup screenReference)
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S3_v4 (Il2CppClass<Il2CppRgctx<Kiloo.Common.UI.ListAdapter`1<SecretCell>>>)+4] (should have been resolved before IL gen)");
			secretPrefab = newSecretPrefab;
			secretInfoDoublePrefab = newInfoDoublePrefab;
			secretSubtitlePrefab = newSecretSubtitlePrefab;
			secretEndList = newSecretEndList;
			secretScreen = screenReference;
		}

		public void SetNewDataList(List<SecretCell> leaderboardListT)
		{
			//IL_0029: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SecretPopup+SecretListAdapter)+8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SecretPopup+SecretListAdapter)+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v17 @ S0_v9+C] (should have been resolved before IL gen)");
			}
		}

		public override int GetModelType(int index)
		{
			//IL_0005: Expected I, but got Obj
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0040: Expected Obj, but got I
			nint num = (nint)this;
			object obj = this + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S2_v2 (Il2CppClass<SecretPopup+SecretListAdapter>)+104] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v2+8]");
			int result = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v2+8]");
			object obj2 = -1;
			if ((nint)obj2 >= 3)
			{
				result = 0;
			}
			return result;
		}

		public override Container GetContainer(Container container, int dataIndex, bool isMeasurePass)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0265: Expected I, but got Obj
			//IL_01a9: Expected Obj, but got I
			//IL_01a9: Expected Obj, but got I
			//IL_01a9: Expected Obj, but got I
			//IL_0211: Expected Obj, but got I
			//IL_0211: Expected Obj, but got I
			//IL_01ef: Expected Obj, but got I
			//IL_01ef: Expected Obj, but got I
			//IL_01ef: Expected Obj, but got I
			//IL_01ef: Expected Obj, but got I
			//IL_01ef: Expected Obj, but got I
			object obj2 = default;
			Enum obj = (Enum)(obj2 - 16);
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v20 @ S2_v2 (Il2CppClass<SecretPopup+SecretListAdapter>)+104] (should have been resolved before IL gen)");
			Container container2 = default;
			if (container2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+8]");
				GameObject model;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+8]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+8]");
						if ((nint)0 != 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+8]");
							if ((nint)0 != 3)
							{
								container2 = null;
								goto IL_027d;
							}
							model = secretInfoDoublePrefab;
						}
						else
						{
							model = secretEndList;
						}
					}
					else
					{
						model = secretSubtitlePrefab;
					}
				}
				else
				{
					model = secretPrefab;
				}
				Container container3 = default;
				container3._002Ector(model);
				SecretHelper component = container3.model.GetComponent<SecretHelper>();
				object tag = default;
				container3.tag = tag;
				container2 = container3;
			}
			goto IL_027d;
			IL_027d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+8]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+8]");
					if ((nint)0 != 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+8]");
						if ((nint)0 == 3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v13+8]");
							nint num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+C]");
							nint num3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+10]");
							nint num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+18]");
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+1C]");
							((SecretHelper)num2).UpdateInfoDouble((string)num3, (string)num4, (string)num5, (string)0);
						}
						else
						{
							_ = -1;
							obj = (Enum)(object)typeof(SecretCellType);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+8]");
							_ = 0;
							string text = obj.ToString();
							string text2 = "No cell type match for: " + text;
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v13+8]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+14]");
					((SecretHelper)num6).UpdateTitle((string)0);
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v13+8]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+C]");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+10]");
				((SecretHelper)num7).UpdateInfo((string)num8, (string)0);
			}
			return container2;
		}
	}

	private sealed class _003CShowTextCopied_003Ed__47(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public SecretPopup _003C_003E4__this;

		private float _003Cduration_003E5__2;

		private float _003CfromAlpha_003E5__3;

		private float _003CtoAlpha_003E5__4;

		private float _003Cfactor2_003E5__5;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Expected Obj, but got Unknown
			//IL_029f: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a4: Expected Obj, but got Unknown
			SecretPopup secretPopup = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						if (_003C_003E1__state == 3)
						{
							_003C_003E1__state = -1;
							secretPopup._copiedTextGO.SetActive(value: false);
							secretPopup._copyButton.SetActive(value: true);
						}
						return false;
					}
					_003C_003E1__state = -1;
					if (!(_003Cfactor2_003E5__5 < 1f))
					{
						_ = -1082130432;
						_ = 0.05f;
						object obj = default;
						_003C_003E2__current = obj;
						_003C_003E1__state = 3;
						return true;
					}
				}
				else
				{
					_003CtoAlpha_003E5__4 = 0f;
					_003Cduration_003E5__2 = 0.7f;
					_003C_003E1__state = -1;
				}
				float deltaTime = RealTimeTracker.deltaTime;
				float num = deltaTime / _003Cduration_003E5__2;
				float num2 = _003Cfactor2_003E5__5 + num;
				float num3 = Math.Min(num2, 1f);
				bool flag = num2 < 0f;
				float num4 = 0f;
				if (!flag)
				{
					num4 = num3;
				}
				_003Cfactor2_003E5__5 = num4;
				UILabel copiedTextLabel = secretPopup._copiedTextLabel;
				float num5 = _003CtoAlpha_003E5__4 - _003CfromAlpha_003E5__3;
				float num6 = Math.Max(num4, 0f);
				float num7 = num5 * num6;
				float num8 = _003CfromAlpha_003E5__3 + num7;
				object obj2 = copiedTextLabel - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v160 @ S2_v16+BC] (should have been resolved before IL gen)");
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			}
			_003C_003E1__state = -1;
			secretPopup._copiedTextGO.SetActive(value: true);
			UILabel copiedTextLabel2 = secretPopup._copiedTextLabel;
			object obj3 = copiedTextLabel2 - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S2_v4+BC] (should have been resolved before IL gen)");
			secretPopup._copyButton.SetActive(value: false);
			_ = -1082130432;
			_ = 0.6f;
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

	private UILabel _popupTitle;

	private GameObject _copyButton;

	private GameObject _copiedTextGO;

	private UILabel _copiedTextLabel;

	private GameObject SecretCellPrefab;

	private GameObject SecretCellSubtitlePrefab;

	private GameObject SecretCellEndList;

	private GameObject SecretCellInfoDouble;

	private List<SecretCell> _contentList;

	private SecretListAdapter _adapter;

	private ScrollView _scrollView;

	private StringBuilder _infoToBeCopiedToClipboard;

	private int lastTab1Index;

	private int lastTab2Index;

	private int lastTab3Index;

	private int lastTab4Index;

	private TabNumber lastTabOpen;

	private Dictionary<TabNumber, List<PageContent>> _contentDict;

	private bool _listHasBeenDisplayedOnce;

	private const string ONLINESETTINGS_ANALYTICS_SAMPLE_SIZE_KEY = "kiloo_analytics_sample";

	private const float DEFAULT_ANALYTICS_SAMPLE_SIZE = 0f;

	private static Func<string> _003C_003Ef__mg_0024cache0;

	public override void Init()
	{
		//IL_0046: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<SecretPopup>)+104] (should have been resolved before IL gen)");
		if (_contentList != null)
		{
			SecretListAdapter secretListAdapter = default;
			secretListAdapter._002Ector(_contentList, SecretCellPrefab, SecretCellInfoDouble, SecretCellSubtitlePrefab, SecretCellEndList, this);
			_adapter = secretListAdapter;
		}
		PopulateContentDictionary();
	}

	public override void Show()
	{
		base.Show();
		if (lastTabOpen != TabNumber.Tab1)
		{
			if (lastTabOpen != TabNumber.Tab2)
			{
				if (lastTabOpen != TabNumber.Tab3)
				{
					if (lastTabOpen == TabNumber.Tab4)
					{
						DisplayList4();
					}
				}
				else
				{
					DisplayList3();
				}
			}
			else
			{
				DisplayList2();
			}
		}
		else
		{
			DisplayList1();
		}
		_copiedTextGO.SetActive(value: false);
		bool flag = IsWPDevice();
		bool active = (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		_copyButton.SetActive(active);
	}

	public override void Hide()
	{
		base.Hide();
		SaveIndex();
	}

	private unsafe void OnEnable()
	{
		VideoAdsManager instance = VideoAdsManager.instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(SecretPopup.CacheStateChangedForLocation));
		instance.AddOnVideoStateChangedHandler(action);
		VideoAdsManager instance2 = VideoAdsManager.instance;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(SecretPopup.CacheStateChangedForLocation));
		instance2.AddOnVideoProviderChangedHandler(action2);
	}

	private unsafe void OnDisable()
	{
		VideoAdsManager instance = VideoAdsManager.instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(SecretPopup.CacheStateChangedForLocation));
		instance.RemoveOnVideoStateChangedHandler(action);
		VideoAdsManager instance2 = VideoAdsManager.instance;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(SecretPopup.CacheStateChangedForLocation));
		instance2.RemoveOnVideoProviderChangedHandler(action2);
	}

	private bool IsAndroidDevice()
	{
		RuntimePlatform platform = Application.platform;
		return platform == RuntimePlatform.Android;
	}

	private bool IsiOSDevice()
	{
		RuntimePlatform platform = Application.platform;
		return platform == RuntimePlatform.IPhonePlayer;
	}

	private bool IsWPDevice()
	{
		RuntimePlatform platform = Application.platform;
		return platform == RuntimePlatform.MetroPlayerARM;
	}

	private void CacheStateChangedForLocation()
	{
		if (lastTabOpen == TabNumber.Tab2)
		{
			DisplayList2();
		}
	}

	private void PopulateContentDictionary()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj = default;
		SecretPopup secretPopup = (SecretPopup)(obj - 1664);
		_ = 0;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<SecretPopup+TabNumber, System.Collections.Generic.List`1<SecretPopup+PageContent>>>>)+4] (should have been resolved before IL gen)");
		Dictionary<TabNumber, List<PageContent>> contentDict = default;
		_contentDict = contentDict;
		List<PageContent> list = default;
		list._002Ector();
		throw new ArgumentException();
	}

	private void SetListContent(TabNumber tab)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected Obj, but got Unknown
		//IL_0406: Expected Obj, but got I4
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected Obj, but got Unknown
		//IL_0030: Expected Obj, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected Obj, but got Unknown
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected Obj, but got Unknown
		//IL_0471: Expected Obj, but got I
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		object obj3 = obj - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		ResetList();
		object obj4 = obj + 16;
		List<PageContent> list = _contentDict.get_Item(tab);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3A5E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj5 = obj + 48;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj7 = default;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			_ = 0;
			object obj6 = obj + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				if (obj7 == null)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+44]");
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
					if ((nint)0 == 0)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								continue;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									continue;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj8 == obj9;
			bool flag2 = !flag;
			object obj10 = obj11;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj10 = obj12;
			}
			_ = 0;
			object obj13 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			return;
		}
		object obj14 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4F77");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		((SecretPopup)0).SetEndOfList();
	}

	public void DisplayList1()
	{
		SaveIndex();
		SetListContent(TabNumber.Tab1);
		lastTabOpen = TabNumber.Tab1;
		ScrollToLastIndex(lastTab1Index);
		_listHasBeenDisplayedOnce = true;
	}

	public void DisplayList2()
	{
		SaveIndex();
		SetListContent(TabNumber.Tab2);
		lastTabOpen = TabNumber.Tab2;
		ScrollToLastIndex(lastTab2Index);
	}

	public void DisplayList3()
	{
		SaveIndex();
		SetListContent(TabNumber.Tab3);
		lastTabOpen = TabNumber.Tab3;
		ScrollToLastIndex(lastTab3Index);
	}

	public void DisplayList4()
	{
		SaveIndex();
		SetListContent(TabNumber.Tab4);
		lastTabOpen = TabNumber.Tab4;
		ScrollToLastIndex(lastTab4Index);
	}

	private void SetEndOfList()
	{
		SecretCell secretCell = default;
		secretCell.cellType = SecretCellType.EndList;
		_contentList.Add(secretCell);
		if (_scrollView != null && _adapter != null)
		{
			_scrollView.SetAdapter(_adapter);
		}
	}

	private void InsertInfo(string label, string value)
	{
		SecretCell secretCell = default;
		secretCell.cellInfo = label;
		secretCell.cellValue = value;
		secretCell.cellType = SecretCellType.Info;
		_contentList.Add(secretCell);
	}

	private void InsertTitle(string title)
	{
		SecretCell secretCell = default;
		secretCell.cellTitle = title;
		secretCell.cellType = SecretCellType.Subtitle;
		_contentList.Add(secretCell);
	}

	private void InsertDoubleInfo(string label1, string value1, string label2, string value2)
	{
		SecretCell secretCell = default;
		secretCell.cellInfo = label1;
		secretCell.cellValue = value1;
		secretCell.cellInfo2 = label2;
		secretCell.cellValue2 = value2;
		secretCell.cellType = SecretCellType.DoubleInfo;
		_contentList.Add(secretCell);
	}

	private void ResetList()
	{
		((List<T>)(object)_contentList).Clear();
	}

	private void SaveIndex()
	{
		if (~(_listHasBeenDisplayedOnce ? 1u : 0u) != 0)
		{
			return;
		}
		Container firstVisibleContainerOnScreen = _scrollView.GetFirstVisibleContainerOnScreen();
		if (lastTabOpen != TabNumber.Tab1)
		{
			if (lastTabOpen != TabNumber.Tab2)
			{
				if (lastTabOpen != TabNumber.Tab3)
				{
					if (lastTabOpen == TabNumber.Tab4)
					{
						lastTab4Index = firstVisibleContainerOnScreen.dataIndex;
					}
				}
				else
				{
					lastTab3Index = firstVisibleContainerOnScreen.dataIndex;
				}
			}
			else
			{
				lastTab2Index = firstVisibleContainerOnScreen.dataIndex;
			}
		}
		else
		{
			lastTab1Index = firstVisibleContainerOnScreen.dataIndex;
		}
	}

	private void ScrollToLastIndex(int index)
	{
		_scrollView.SetSelection(index);
	}

	private IEnumerator ShowTextCopied()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private unsafe string GetVersion()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected I4, but got Unknown
		object obj = default;
		SecretPopup secretPopup = (SecretPopup)(obj - 16);
		bool flag = secretPopup.IsAndroidDevice();
		string bundleVersion = DeviceUtility.GetBundleVersion();
		bool flag2 = !flag;
		string result = bundleVersion;
		if (!flag2)
		{
			int androidVersionCode = DeviceUtility.GetAndroidVersionCode();
			((UIScreen)secretPopup).screen = (SCREEN)androidVersionCode;
			int num = secretPopup + 12;
			string text = ((int*)num)->ToString();
			string text2 = bundleVersion + " (" + text + ")";
			result = text2;
		}
		return result;
	}

	private string GetFirstInstalledVersion()
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		PlayerInfo instance = PlayerInfo.Instance;
		string firstInstalledVersion = instance._firstInstalledVersion;
		object obj;
		if (instance._firstInstalledVersion != null)
		{
			obj = 0;
			if (firstInstalledVersion._stringLength != 0)
			{
				goto IL_0096;
			}
		}
		obj = 1;
		goto IL_0096;
		IL_0096:
		if (obj != null)
		{
			return "PreUpdateInstallVersion";
		}
		PlayerInfo instance2 = PlayerInfo.Instance;
		return (string)(instance2 + 440);
	}

	private unsafe string GetInitialInstallDate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected VT, but got Unknown
		//IL_0080: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		PlayerInfo instance = PlayerInfo.Instance;
		if (instance._firstInstallDate == DateTime.MinValue)
		{
			return "PreUpdateInstallDate";
		}
		PlayerInfo instance2 = PlayerInfo.Instance;
		_ = instance2._firstInstallDate;
		DateTime dateTime = (DateTime)(obj + 8);
		return ((DateTime*)dateTime)->ToString();
	}

	private unsafe string GetUsedDeviceMemory()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0060: Expected Obj, but got I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		int physicalMemoryMB = SystemInfo.GetPhysicalMemoryMB();
		int deviceFreeMemory = DeviceUtility.GetDeviceFreeMemory();
		object obj3 = physicalMemoryMB - deviceFreeMemory;
		int num = obj + 12;
		string text = ((int*)num)->ToString();
		string result = text + " MB";
		if (deviceFreeMemory == 0)
		{
			result = "Unknown";
		}
		return result;
	}

	private unsafe string GetApplicationMemoryLimit()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		int memoryUsageLimit = DeviceUtility.GetMemoryUsageLimit();
		int num = obj + 12;
		string text = ((int*)num)->ToString();
		string result = text + " MB";
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		if ((nint)0 == 0)
		{
			result = "Unknown";
		}
		return result;
	}

	private unsafe string GetApplicationMemoryUsage()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		int currentMemoryUsage = DeviceUtility.GetCurrentMemoryUsage();
		int num = obj + 12;
		string text = ((int*)num)->ToString();
		string result = text + " MB";
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		if ((nint)0 == 0)
		{
			result = "Unknown";
		}
		return result;
	}

	private unsafe string GetPeakMemoryUsage()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (DeviceUtility.GetPeakMemoryUsage() == 0)
		{
			return "Unknown";
		}
		int num = obj + 12;
		string text = ((int*)num)->ToString();
		return text + " MB";
	}

	private string GetDebugMode()
	{
		object result = "ON";
		if (!Globals.DEBUG)
		{
			result = "Off";
		}
		return (string)result;
	}

	private unsafe string GetScreenDPI()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0048: Expected Ref, but got F4
		object obj2 = default;
		object obj = obj2 - 16;
		float dpi = Screen.dpi;
		if (dpi == 0f)
		{
			return "Unknown";
		}
		float dpi2 = Screen.dpi;
		float num = (float)obj + 12f;
		string text = ((float*)num)->ToString();
		return text + " DPI";
	}

	private unsafe string GetBatteryLevel()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		int batteryLevel = DeviceUtility.GetBatteryLevel();
		if (batteryLevel == -1)
		{
			return "Unknown";
		}
		int num = obj + 12;
		string text = ((int*)num)->ToString();
		return text + "%";
	}

	private string GetTotalDiskSpace()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		int totalDiskSpace = DeviceUtility.GetTotalDiskSpace();
		float num = (float)totalDiskSpace * (1f / 1024f);
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		string text = $"{arg:F2}";
		string text2 = text + " GB";
		bool flag = num == -1f;
		string result = "Unknown";
		if (!flag)
		{
			result = text2;
		}
		return result;
	}

	private string GetUsedDiskSpace()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		int freeDiskSpace = DeviceUtility.GetFreeDiskSpace();
		int totalDiskSpace = DeviceUtility.GetTotalDiskSpace();
		float num = (float)totalDiskSpace * (1f / 1024f);
		float num2 = (float)freeDiskSpace * (1f / 1024f);
		float num3 = num - num2;
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		string text = $"{arg:F2}";
		string text2 = text + " GB";
		bool flag = num2 == -1f;
		string result = "Unknown";
		if (!flag)
		{
			result = text2;
		}
		return result;
	}

	private string GetUsedSDCardSpace()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		int freeSDCardSpace = DeviceUtility.GetFreeSDCardSpace();
		int totalSDCardSpace = DeviceUtility.GetTotalSDCardSpace();
		float num = (float)totalSDCardSpace * (1f / 1024f);
		float num2 = (float)freeSDCardSpace * (1f / 1024f);
		float num3 = num - num2;
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		string text = $"{arg:F2}";
		string text2 = text + " GB";
		bool flag = num2 == -1f;
		string result = "Unknown";
		if (!flag)
		{
			result = text2;
		}
		return result;
	}

	private string GetTotalSDCardSpace()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		int totalSDCardSpace = DeviceUtility.GetTotalSDCardSpace();
		float num = (float)totalSDCardSpace * (1f / 1024f);
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		string text = $"{arg:F2}";
		string text2 = text + " GB";
		bool flag = num == -1f;
		string result = "Unknown";
		if (!flag)
		{
			result = text2;
		}
		return result;
	}

	private unsafe string GetOnlineSettings()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005f: Expected Obj, but got I4
		//IL_0043: Expected Obj, but got I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (~(Globals.DEBUG_USE_ONLINESETTINGS_SET ? 1u : 0u) != 0)
		{
			goto IL_0118;
		}
		string oNLINESETTINGS_SET = Globals.ONLINESETTINGS_SET;
		object obj3;
		if (Globals.ONLINESETTINGS_SET != null)
		{
			obj3 = 0;
			if (oNLINESETTINGS_SET._stringLength != 0)
			{
				goto IL_013e;
			}
		}
		obj3 = 1;
		goto IL_013e;
		IL_013e:
		if (obj3 != null)
		{
			goto IL_0118;
		}
		string oNLINESETTINGS_SET2 = Globals.ONLINESETTINGS_SET;
		char c = Globals.ONLINESETTINGS_SET.get_Chars(0);
		char c2 = (char)(obj + 14);
		string text = ((char*)(ushort)c2)->ToString();
		bool flag = oNLINESETTINGS_SET2._stringLength < 1;
		string result = Globals.ONLINESETTINGS_SET;
		if (!flag)
		{
			string text2 = text.ToUpper();
			string text3 = Globals.ONLINESETTINGS_SET.Substring(1);
			string text4 = text2 + text3;
			result = text4;
		}
		goto IL_014c;
		IL_014c:
		return result;
		IL_0118:
		result = "Live";
		goto IL_014c;
	}

	private unsafe string GetOnlineSettingsPlatform()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		OnlineSettings instance = OnlineSettings.instance;
		string currentPlatform = instance.GetCurrentPlatform();
		char c = currentPlatform.get_Chars(0);
		char c2 = (char)(obj + 14);
		string text = ((char*)(ushort)c2)->ToString();
		string result;
		if (currentPlatform == "ios")
		{
			result = "iOS";
		}
		else if (currentPlatform == "wp8")
		{
			result = "WP8";
		}
		else
		{
			bool flag = currentPlatform._stringLength < 1;
			result = currentPlatform;
			if (!flag)
			{
				string text2 = text.ToUpper();
				string text3 = currentPlatform.Substring(1);
				string text4 = text2 + text3;
				result = text4;
			}
		}
		return result;
	}

	private string GetOnlineSettingsChecksum()
	{
		OnlineSettings instance = OnlineSettings.instance;
		string result = instance._checksumToShow;
		if (instance._checksumToShow == null)
		{
			result = "No";
		}
		return result;
	}

	private unsafe string GetKilooAnalyticsSample()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0031: Expected Ref, but got F4
		object obj2 = default;
		object obj = obj2 - 16;
		OnlineSettings instance = OnlineSettings.instance;
		float value = instance.GetValue("kiloo_analytics_sample", 0f);
		float num = (float)obj + 12f;
		string text = ((float*)num)->ToString();
		return text + "%";
	}

	private string GetKilooAnalyticsInfo()
	{
		object result = "Yes";
		if (!Manager._isPartOfSample)
		{
			result = "No";
		}
		return (string)result;
	}

	private unsafe string GetAnalyticsSamplingKey()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0036: Expected Ref, but got F4
		object obj2 = default;
		object obj = obj2 - 16;
		PlayerInfo instance = PlayerInfo.Instance;
		float analyticsSamplingKey = instance.AnalyticsSamplingKey;
		float num = (float)obj + 12f;
		return ((float*)num)->ToString("0.000000");
	}

	private unsafe string GetTimezone()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got VT
		//IL_0052: Expected Ref, but got F8
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		DateTime now = CDateTime.Now;
		TimeSpan currentTimeZoneUTCOffset = TimeUtility.GetCurrentTimeZoneUTCOffset(now);
		obj = currentTimeZoneUTCOffset;
		double num = (double)obj * 2.7777777777777777E-11;
		double num2 = (double)obj + 8.0;
		string text = ((double*)num2)->ToString("00");
		bool flag = num > 0.0;
		object obj3 = "GMT+";
		if (!flag)
		{
			obj3 = "GMT";
		}
		return (string)obj3 + text + ":00";
	}

	private unsafe string CheckForInAppLegacyPurchase()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		PlayerInfo instance = PlayerInfo.Instance;
		_ = instance._inAppLegacyPurchaseCount;
		int num = obj + 12;
		return ((int*)num)->ToString();
	}

	private unsafe string CheckForInAppConsumablePurchase()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		PlayerInfo instance = PlayerInfo.Instance;
		_ = instance._inAppConsumablePurchaseCount;
		int num = obj + 12;
		return ((int*)num)->ToString();
	}

	private unsafe string CheckForInAppNonconsumablePurchase()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		PlayerInfo instance = PlayerInfo.Instance;
		_ = instance._inAppNonconsumablePurchaseCount;
		int num = obj + 12;
		return ((int*)num)->ToString();
	}

	private unsafe string CheckForInAppRestoredPurchase()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		PlayerInfo instance = PlayerInfo.Instance;
		_ = instance._inAppRestoredPurchaseCount;
		int num = obj + 12;
		return ((int*)num)->ToString();
	}

	private string GetFacebookID()
	{
		SocialManager instance = SocialManager.instance;
		if (instance.facebookIsLoggedIn)
		{
			SocialManager instance2 = SocialManager.instance;
			if (instance2._fbProfile != null)
			{
				SocialManager instance3 = SocialManager.instance;
				FacebookProfile fbProfile = instance3._fbProfile;
				if (fbProfile.fullName != null)
				{
					SocialManager instance4 = SocialManager.instance;
					FacebookProfile fbProfile2 = instance4._fbProfile;
					if (fbProfile2.id != null)
					{
						SocialManager instance5 = SocialManager.instance;
						FacebookProfile fbProfile3 = instance5._fbProfile;
						SocialManager instance6 = SocialManager.instance;
						FacebookProfile fbProfile4 = instance6._fbProfile;
						return fbProfile3.fullName + " (id: " + fbProfile4.id + ")";
					}
				}
			}
		}
		return "Not logged in to Facebook";
	}

	private unsafe string GetGameCenterID()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_003f: Expected I, but got Obj
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected I4, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		SocialManager instance = SocialManager.instance;
		if (instance.gamecenterIsLoggedIn)
		{
			SocialManager instance2 = SocialManager.instance;
			GameCenterProfile gcProfile = instance2._gcProfile;
			Encoding aSCII = Encoding.ASCII;
			nint num = (nint)aSCII;
			object obj3 = aSCII + 152;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v63 @ S2_v3 (Il2CppClass<System.Text.Encoding>)+154] (should have been resolved before IL gen)");
			string text = string.Empty;
			object obj4 = 0;
			object obj6 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v23+C]");
				if (0 <= (nint)obj4)
				{
					break;
				}
				object obj5 = obj4 + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v12+10]");
				_ = 0;
				byte b = (byte)(obj + 15);
				string text2 = ((byte*)b)->ToString();
				string text3 = text + text2 + " ";
				object obj7 = obj4 + 1;
				text = text3;
				obj4 = obj7;
			}
			return string.Empty + text;
		}
		return "Not logged in.";
	}

	private string CheckForRootedDevice()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private unsafe string GetCurrentIntertialProvider()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Ref, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		ScreenAdsManager instance = ScreenAdsManager.instance;
		string currentProvider = instance.GetCurrentProvider(out *(bool*)(obj + 15), out *(bool*)(obj + 14));
		if (currentProvider == null)
		{
			return "None";
		}
		object obj3 = "Cached";
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
		if ((nint)0 == 0)
		{
			obj3 = "Uncached";
		}
		object obj4 = "Caching";
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E]");
		if ((nint)0 == 0)
		{
			obj4 = obj3;
		}
		string text = currentProvider.Substring(0, 2);
		return text + " (" + (string)obj4 + ")";
	}

	private string GetCurrentVideoProvider()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00c7: Expected I, but got Obj
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		VideoAdsManager instance = VideoAdsManager.instance;
		_ = instance.currentVideoState__BackingField;
		VideoAdsManager instance2 = VideoAdsManager.instance;
		VideoAdProvider currentProvider = instance2.currentProvider;
		if (instance2.currentProvider == null)
		{
			return "None";
		}
		_ = -1;
		obj = (Enum)(object)typeof(VideoAdsManager.VideoState);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
		_ = 0;
		string text = obj.ToString();
		int num = text.IndexOf('.');
		int startIndex = num + 1;
		string text2 = text.Substring(startIndex);
		nint num2 = (nint)currentProvider;
		object obj3 = currentProvider + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v81 @ S1_v17 (Il2CppClass<VideoAdProvider>)+F4] (should have been resolved before IL gen)");
		string text4 = default;
		string text3 = text4.Substring(0, 2);
		return text3 + " (" + text2 + ")";
	}

	private string GetLastIntertialProvider()
	{
		//IL_000d: Expected I, but got Obj
		ScreenAdsManager instance = ScreenAdsManager.instance;
		ScreenAdProvider lastShownProvider = instance._lastShownProvider;
		string text = default;
		if (instance._lastShownProvider != null)
		{
			nint num = (nint)lastShownProvider;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v17 @ S1_v6 (Il2CppClass<ScreenAdProvider>)+F4] (should have been resolved before IL gen)");
		}
		else
		{
			text = null;
		}
		if (text == null)
		{
			return "None";
		}
		return text.Substring(0, 2);
	}

	private string GetLastVideoProvider()
	{
		//IL_0013: Expected I, but got Obj
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		VideoAdsManager instance = VideoAdsManager.instance;
		VideoAdProvider lastShownProvider = instance.lastShownProvider;
		if (instance.lastShownProvider == null)
		{
			return "None";
		}
		nint num = (nint)lastShownProvider;
		object obj = lastShownProvider + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S1_v3 (Il2CppClass<VideoAdProvider>)+F4] (should have been resolved before IL gen)");
		string text = default;
		return text.Substring(0, 2);
	}

	private string CheckForJailbrokenDevice()
	{
		bool flag = Directory.Exists("/bin/bash");
		object result = "Yes";
		if (!flag)
		{
			result = "No";
		}
		return (string)result;
	}

	private string GetSyboAnalyticsHashedDeviceId()
	{
		Func<string> getDeviceID = BaseSessionEvent.GetDeviceID;
		if (BaseSessionEvent.GetDeviceID == null)
		{
			return "NA";
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ S0_v10 (System.Func`1<System.String>)+C] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	private unsafe string GetSyboAnalyticsSamplingThreshold()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0031: Expected Ref, but got F4
		object obj2 = default;
		object obj = obj2 - 16;
		OnlineSettings instance = OnlineSettings.instance;
		float value = instance.GetValue("sybo_analytics_sampling_threshold", 0f);
		float num = (float)obj + 12f;
		return ((float*)num)->ToString();
	}

	private unsafe string GetSyboAnalyticsEnabled()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		OnlineSettings instance = OnlineSettings.instance;
		bool value = instance.GetValue("sybo_analytics_enabled", defaultValue: false);
		bool flag = (byte)(obj + 15) != 0;
		return (flag ? ((bool*)1) : ((bool*)null))->ToString();
	}

	private string GetRestrictedLocale()
	{
		object result = "Yes";
		if (!AgeRestriction._countryCodeRestricted)
		{
			result = "No";
		}
		return (string)result;
	}

	private string GetRestrictionActive()
	{
		bool isRestricted = AgeRestriction.isRestricted;
		object result = "Yes";
		if (!isRestricted)
		{
			result = "No";
		}
		return (string)result;
	}

	private unsafe string GetUserBirthday()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected VT, but got Unknown
		//IL_002f: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		DateTime userBirthday = AgeRestriction.GetUserBirthday();
		DateTime dateTime = (DateTime)(obj + 8);
		return ((DateTime*)dateTime)->ToString("MM/yy");
	}

	public void CopyToClipboard()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Expected Obj, but got Unknown
		//IL_09c6: Expected Obj, but got I4
		//IL_0022: Expected VT, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_09f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f8: Expected Obj, but got Unknown
		//IL_0a17: Expected I, but got Obj
		//IL_0a3b: Expected Obj, but got I
		//IL_090a: Unknown result type (might be due to invalid IL or missing references)
		//IL_090f: Expected Obj, but got Unknown
		//IL_0929: Expected Obj, but got I
		//IL_0979: Expected Obj, but got I
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_01dc: Expected Obj, but got I
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected Obj, but got Unknown
		//IL_0205: Expected Obj, but got I4
		//IL_0a53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a58: Expected Obj, but got Unknown
		//IL_046a: Expected Obj, but got I
		//IL_047a: Expected Obj, but got I
		//IL_0492: Expected Obj, but got I
		//IL_0336: Expected Obj, but got I
		//IL_04dd: Expected Obj, but got I
		//IL_04ed: Expected Obj, but got I
		//IL_04f6: Expected Obj, but got I4
		//IL_0506: Expected Obj, but got I
		//IL_038a: Expected Obj, but got I4
		//IL_039a: Expected Obj, but got I
		//IL_0551: Expected Obj, but got I
		//IL_0561: Expected Obj, but got I
		//IL_056a: Expected Obj, but got I4
		//IL_057a: Expected Obj, but got I
		//IL_03e1: Expected Obj, but got I4
		//IL_03f1: Expected Obj, but got I
		//IL_05c5: Expected Obj, but got I
		//IL_05d5: Expected Obj, but got I
		//IL_05de: Expected Obj, but got I4
		//IL_05ee: Expected Obj, but got I
		//IL_0418: Expected Obj, but got I4
		//IL_0428: Expected Obj, but got I
		//IL_0639: Expected Obj, but got I
		//IL_0649: Expected Obj, but got I
		//IL_0652: Expected Obj, but got I4
		//IL_0662: Expected Obj, but got I
		//IL_06b0: Expected Obj, but got I
		//IL_06c0: Expected Obj, but got I
		//IL_06c9: Expected Obj, but got I4
		//IL_06d9: Expected Obj, but got I
		//IL_06e9: Expected Obj, but got I
		//IL_06f9: Expected Obj, but got I
		//IL_0702: Expected Obj, but got I4
		//IL_0712: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 96;
		_ = 0;
		_ = 0;
		object obj3 = obj - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		_infoToBeCopiedToClipboard = stringBuilder;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(TabNumber));
		Array values = Enum.GetValues(typeFromHandle);
		IEnumerator enumerator = values.GetEnumerator();
		object obj4 = obj + 52;
		object obj5 = obj + 92;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj11 = default;
		object obj13 = default;
		object obj15 = default;
		object obj17 = default;
		object obj18 = default;
		object obj19 = default;
		object obj20 = default;
		object obj23 = default;
		object obj24 = default;
		object obj25 = default;
		object obj26 = default;
		object obj27 = default;
		object obj28 = default;
		object obj29 = default;
		object obj30 = default;
		SecretPopup secretPopup = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			object obj21;
			object obj22;
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					break;
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							object obj7 = obj + 8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3A5E");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
								obj3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
								_ = 0;
								object obj8 = obj + 56;
								obj = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
								_ = 0;
								while (true)
								{
									_ = 0;
									object obj9 = obj + 56;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									bool flag = (nint)0 == 1;
									object obj10 = obj11;
									object obj12 = obj13;
									object obj14 = obj15;
									object obj16 = obj17;
									if (!flag)
									{
										if (obj18 == null)
										{
											break;
										}
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+44]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+54]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
										_ = 0;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag2 = (nint)0 == 1;
										obj10 = obj11;
										obj12 = obj13;
										obj14 = obj15;
										obj16 = obj17;
										if (!flag2)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
											if ((nint)0 == 0)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												bool flag3 = (nint)0 == 1;
												obj10 = obj11;
												obj12 = obj13;
												obj14 = obj15;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												obj16 = 0;
												if (!flag3)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													bool flag4 = (nint)0 == 1;
													obj10 = obj11;
													obj12 = obj13;
													obj14 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													obj16 = 0;
													if (!flag4)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														bool flag5 = (nint)0 != 1;
														obj15 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														obj17 = 0;
														if (flag5)
														{
															continue;
														}
														obj10 = obj11;
														obj12 = obj13;
														obj14 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														obj16 = 0;
													}
												}
											}
											else
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												bool flag6 = (nint)0 == 1;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												obj10 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
												obj12 = 0;
												obj14 = obj15;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
												obj16 = 0;
												if (!flag6)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													bool flag7 = (nint)0 == 1;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													obj10 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
													obj12 = 0;
													obj14 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
													obj16 = 0;
													if (!flag7)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														bool flag8 = (nint)0 == 1;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														obj10 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
														obj12 = 0;
														obj14 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
														obj16 = 0;
														if (!flag8)
														{
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															bool flag9 = (nint)0 == 1;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															obj10 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
															obj12 = 0;
															obj14 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
															obj16 = 0;
															if (!flag9)
															{
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																bool flag10 = (nint)0 == 1;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																obj10 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
																obj12 = 0;
																obj14 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
																obj16 = 0;
																if (!flag10)
																{
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																	bool flag11 = (nint)0 != 1;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																	obj10 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
																	obj12 = 0;
																	obj14 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
																	obj16 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																	obj11 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
																	obj13 = 0;
																	obj15 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
																	obj17 = 0;
																	if (flag11)
																	{
																		continue;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
									bool flag12 = obj19 != obj20;
									obj21 = obj19;
									obj22 = obj23;
									if (!flag12)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
										obj = obj24;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag13 = (nint)0 == 1;
										obj11 = obj10;
										obj13 = obj12;
										obj15 = obj14;
										obj17 = obj16;
										if (!flag13)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
										obj21 = obj25;
										obj22 = obj26;
									}
									goto IL_0aad;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									continue;
								}
							}
						}
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj21 = obj27;
			obj22 = obj28;
			goto IL_0b23;
			IL_0aad:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				goto IL_097e;
			}
			goto IL_0b23;
			IL_097e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			return;
			IL_0b23:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			if (obj29 == obj21)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj22 = obj30;
			}
			_ = 0;
			object obj31 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			secretPopup = (SecretPopup)0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				break;
			}
			goto IL_097e;
		}
		object obj32 = obj + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
		StringBuilder infoToBeCopiedToClipboard = secretPopup._infoToBeCopiedToClipboard;
		nint num = (nint)infoToBeCopiedToClipboard;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v218 @ S1_v44 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
		string deviceClipBoard = default;
		DeviceUtility.SetDeviceClipBoard(deviceClipBoard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		IEnumerator routine = ((SecretPopup)0).ShowTextCopied();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		Coroutine coroutine = ((MonoBehaviour)0).StartCoroutine(routine);
	}

	public SecretPopup()
	{
		List<SecretCell> list = default;
		list._002Ector();
		_contentList = list;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<SecretPopup+TabNumber, System.Collections.Generic.List`1<SecretPopup+PageContent>>>>)+4] (should have been resolved before IL gen)");
		Dictionary<TabNumber, List<PageContent>> contentDict = default;
		_contentDict = contentDict;
		base._002Ector();
	}
}

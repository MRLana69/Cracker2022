using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UI;

public class CoinButtonHelper : MonoBehaviour
{
	private Button BuyButton;

	private TMP_Text titleLabel;

	private TMP_Text amountLabel;

	public Image BGIcon;

	public Image powerupIcon;

	private Sprite key;

	private Sprite coin;

	private bool _inited;

	private InAppItemModel _itemData;

	private bool _scheduleSetup = true;

	private unsafe void Start()
	{
		Button buyButton = BuyButton;
		UnityAction unityAction = default;
		unityAction._002Ector(this, (nint)__ldftn(CoinButtonHelper._003CStart_003Eb__10_0));
		buyButton.m_OnClick.AddListener(unityAction);
	}

	public void Init(InAppItemModel inAppItem)
	{
		_itemData = inAppItem;
		_inited = true;
		Setup();
	}

	private void Setup()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00ab: Expected Obj, but got I4
		//IL_00ee: Expected I, but got Obj
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_0029: Expected I, but got Obj
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		InAppItemModel itemData = _itemData;
		bool flag = itemData.InAppItemType__BackingField == InAppItemModel.ItemType.Keys;
		object obj3 = 32;
		if (!flag)
		{
			obj3 = 36;
		}
		object sprite = (object)this + obj3;
		BGIcon.sprite = (Sprite)sprite;
		TMP_Text tMP_Text = titleLabel;
		InAppItemModel itemData2 = _itemData;
		nint num = (nint)tMP_Text;
		object obj4 = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v40 @ S2_v5 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text2 = amountLabel;
		InAppItemModel itemData3 = _itemData;
		_ = itemData3.PayoutAmount__BackingField;
		object obj5 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		string text = $"{arg}";
		nint num2 = (nint)tMP_Text2;
		object obj6 = tMP_Text2 + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v70 @ S2_v11 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		InAppItemModel itemData4 = _itemData;
		string path = "UI/" + itemData4.Icon__BackingField;
		Sprite sprite2 = Resources.Load<Sprite>(path);
		powerupIcon.sprite = sprite2;
	}

	private void OnEnable()
	{
		if (~(_inited ? 1u : 0u) == 0)
		{
			_scheduleSetup = true;
		}
	}

	private void Update()
	{
		if (~(_scheduleSetup ? 1u : 0u) == 0 && _itemData != null)
		{
			Setup();
			_scheduleSetup = false;
		}
	}

	private void _003CStart_003Eb__10_0()
	{
		//IL_00f3: Expected Obj, but got I4
		InAppItemModel itemData = _itemData;
		object obj = itemData.InAppItemType__BackingField - 5;
		if (itemData.InAppItemType__BackingField != InAppItemModel.ItemType.Coins)
		{
			if ((nint)obj == 1)
			{
				PlayerInfo instance = PlayerInfo.Instance;
				int amountOfKeys = instance.amountOfKeys;
				InAppItemModel itemData2 = _itemData;
				int amountOfKeys2 = amountOfKeys + itemData2.PayoutAmount__BackingField;
				instance.amountOfKeys = amountOfKeys2;
			}
		}
		else
		{
			PlayerInfo instance2 = PlayerInfo.Instance;
			int amountOfCoins = instance2.amountOfCoins;
			InAppItemModel itemData3 = _itemData;
			int amountOfCoins2 = amountOfCoins + itemData3.PayoutAmount__BackingField;
			instance2.amountOfCoins = amountOfCoins2;
		}
		PlayerInfo instance3 = PlayerInfo.Instance;
		instance3.SaveIfDirty();
	}
}

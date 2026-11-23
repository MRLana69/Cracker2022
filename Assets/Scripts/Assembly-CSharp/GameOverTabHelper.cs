using Cpp2ILInjected;
using UnityEngine;

public class GameOverTabHelper : MonoBehaviour
{
	private GameObject _leaderboardTabActive;

	private GameObject _leaderboardTabInactive;

	private UILabel _leaderboardTabLabel;

	private GameObject _toprunTabActive;

	private GameObject _toprunTabInactive;

	private UILabel _toprunTabLabel;

	private UISprite _toprunTabFlag;

	private int toprunLabelPixelOffsetX = 14;

	private int toprunLabelPixelOffsetY;

	private void Awake()
	{
		LeaderboardTapped();
	}

	private void OnEnable()
	{
		RefreshFlag();
	}

	public void RefreshFlag()
	{
		//IL_007f: Expected VT, but got I4
		//IL_0061: Expected VT, but got I4
		CountryManager instance = CountryManager.instance;
		Country currentTournamentCountry = instance.GetCurrentTournamentCountry();
		_toprunTabFlag.spriteName = currentTournamentCountry.flag__BackingField;
		UIAnchor component = _toprunTabLabel.GetComponent<UIAnchor>();
		UISprite toprunTabFlag = _toprunTabFlag;
		if (toprunTabFlag.mSpriteName == string.Empty)
		{
			component.pixelOffset = (Vector2)0;
			int num = toprunLabelPixelOffsetY;
		}
		else
		{
			component.pixelOffset = (Vector2)toprunLabelPixelOffsetX;
			int num = toprunLabelPixelOffsetY;
		}
	}

	public void LeaderboardTapped()
	{
		RefreshFlag();
		_leaderboardTabActive.SetActive(value: true);
		_leaderboardTabInactive.SetActive(value: false);
		SetLabelActive(_leaderboardTabLabel, isActive: true);
		_toprunTabActive.SetActive(value: false);
		_toprunTabInactive.SetActive(value: true);
		SetLabelActive(_toprunTabLabel, isActive: false);
	}

	public void TopRunTapped()
	{
		RefreshFlag();
		_leaderboardTabActive.SetActive(value: false);
		_leaderboardTabInactive.SetActive(value: true);
		SetLabelActive(_leaderboardTabLabel, isActive: false);
		_toprunTabActive.SetActive(value: true);
		_toprunTabInactive.SetActive(value: false);
		SetLabelActive(_toprunTabLabel, isActive: true);
	}

	private unsafe void SetLabelActive(UILabel label, bool isActive)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected VT, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_00fc: Expected Obj, but got F4
		//IL_0117: Expected F4, but got I
		//IL_0112: Expected native int or pointer, but got VT
		//IL_0124: Expected F4, but got Obj
		//IL_011f: Expected native int or pointer, but got VT
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected VT, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		object obj = default;
		Color color = (Color)(obj - 112);
		object obj2;
		if (isActive)
		{
			_ = 4575657222467263645L;
			_ = 4575657222467263645L;
			_ = 4525782065045627105L;
			_ = 4525782065045627105L;
			Color color2 = color + 16;
			label.color = color2;
			_ = 1065353216;
			obj2 = color + 80;
		}
		else
		{
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			Color color3 = color + 32;
			label.color = color3;
			_ = 0;
			obj2 = color + 48;
		}
		_ = 1065353216;
		object obj3 = obj2 + 8;
		obj3 = 1f;
		_ = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v4+8]");
		((Color*)(nint)color)->b = 0f;
		((Color*)(nint)color)->r = (float)obj2;
		label.effectColor = color;
	}

	public GameOverTabHelper()
	{
		//IL_000f: Expected I4, but got I8
	}
}

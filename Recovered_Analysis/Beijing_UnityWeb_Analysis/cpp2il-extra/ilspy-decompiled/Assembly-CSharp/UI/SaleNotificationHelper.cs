using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace UI;

public class SaleNotificationHelper : MonoBehaviour
{
	private UILabel _line1;

	private UILabel _line2;

	private UISprite _bgSprite;

	private UISprite _bgShadow;

	private string _offerText;

	public void Init(string saleHeader, string subHeader, string saleText)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected I4, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected I4, but got Unknown
		//IL_0068: Expected Obj, but got I
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LeaderboardGameoverCell leaderboardGameoverCell = default;
		leaderboardGameoverCell.cellType = LeaderboardGameoverCellType.FACEBOOK_BUTTON;
		bool noFriends = (byte)(subHeader & 1) != 0;
		leaderboardGameoverCell.noFriends = noFriends;
		bool lockList = (byte)(saleText & 1) != 0;
		leaderboardGameoverCell.lockList = lockList;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.SaleNotificationHelper)+20]");
		((List<LeaderboardGameoverCell>)0).Add(leaderboardGameoverCell);
		object obj = saleHeader + 1;
		string text = (string)obj;
	}

	public SaleNotificationHelper()
	{
		CancelInvoke();
	}
}

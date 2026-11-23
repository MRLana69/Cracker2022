using TopRun;
using UnityEngine;

public class TopRunResultsButton : MonoBehaviour
{
	private UILabel weekLabel;

	private void OnEnable()
	{
		SetWeekLabel();
	}

	private unsafe void SetWeekLabel()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		PlayerInfo instance = PlayerInfo.Instance;
		_ = instance._pendingTopRunResultsWeek;
		int num = obj + 12;
		string text = ((int*)num)->ToString();
		string text2 = "WEEK " + text;
		weekLabel.text = text2;
	}

	private void OnClick()
	{
		if (TopRunRoot.manager__BackingField != null && TopRunRewardHelper.ShouldShowResults())
		{
			((TopRunResultsButton)null).SetBeatTopRunFriendsAwardProgression();
			TopRunRewardHelper.PrepareAndCallCelebrationScreen(null);
		}
	}

	private void SetBeatTopRunFriendsAwardProgression()
	{
		//IL_007c: Expected Obj, but got I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		object obj = 0;
		while (true)
		{
			PlayerInfo instance = PlayerInfo.Instance;
			if (instance._pendingTopRunBeatenFriendsAward > (nint)obj)
			{
				PlayerInfo instance2 = PlayerInfo.Instance;
				Statistics stats = instance2._stats;
				int[] values = stats._values;
				int value = values[30] + 1;
				stats.set_Item(Stat.TopRunFriendsBeaten, value);
				object obj2 = obj + 1;
				obj = obj2;
				continue;
			}
			break;
		}
	}
}

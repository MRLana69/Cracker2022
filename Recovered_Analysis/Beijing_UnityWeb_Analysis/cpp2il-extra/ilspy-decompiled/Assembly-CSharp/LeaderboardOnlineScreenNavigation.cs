using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class LeaderboardOnlineScreenNavigation : MonoBehaviour
{
	public UIScrollBar scrollbar;

	private void Update()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<UITexture> list = default;
		list._002Ector();
		object obj = this + 16;
		obj = list;
		_ = 2;
		CancelInvoke();
	}

	public LeaderboardOnlineScreenNavigation()
	{
		if (Input.GetKeyUp(KeyCode.DownArrow))
		{
			float alpha = scrollbar.alpha;
			float unscaledTime = Time.unscaledTime;
			float num = 2f * unscaledTime;
			float factor = alpha + num;
			((TweenAlpha)(object)scrollbar).OnUpdate(factor, true);
		}
		if (Input.GetKeyUp(KeyCode.UpArrow))
		{
			float alpha2 = scrollbar.alpha;
			float unscaledTime2 = Time.unscaledTime;
			float num2 = 2f * unscaledTime2;
			float factor2 = alpha2 - num2;
			((TweenAlpha)(object)scrollbar).OnUpdate(factor2, true);
		}
	}
}

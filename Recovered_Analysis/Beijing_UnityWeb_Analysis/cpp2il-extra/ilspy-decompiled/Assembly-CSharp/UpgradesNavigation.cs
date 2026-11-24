using Cpp2ILInjected;
using UnityEngine;

public class UpgradesNavigation : MonoBehaviour
{
	private UIScrollBar _scrollbar;

	private void OnEnable()
	{
		CancelInvoke();
	}

	private void Update()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I
		object obj = this + 12;
		_0021_00210 componentInChildren = (_0021_00210)((Component)this).GetComponentInChildren<T>();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (T)+3C]");
		obj = 0;
	}

	public UpgradesNavigation()
	{
		if (Input.GetKeyUp(KeyCode.DownArrow))
		{
			float alpha = _scrollbar.alpha;
			float unscaledTime = Time.unscaledTime;
			float factor = alpha + unscaledTime;
			((TweenAlpha)(object)_scrollbar).OnUpdate(factor, true);
		}
		if (Input.GetKeyUp(KeyCode.UpArrow))
		{
			float alpha2 = _scrollbar.alpha;
			float unscaledTime2 = Time.unscaledTime;
			float factor2 = alpha2 - unscaledTime2;
			((TweenAlpha)(object)_scrollbar).OnUpdate(factor2, true);
		}
	}
}

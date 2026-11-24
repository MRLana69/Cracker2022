using System;
using Cpp2ILInjected;
using UnityEngine;

public class AwardsScreenNavigation : MonoBehaviour
{
	private UIScrollBar _scrollbar;

	private void OnEnable()
	{
		//IL_0035: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I4
		bool flag = ((UnityEngine.Object)this).m_CachedPtr != (IntPtr)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AwardsScreenNavigation)+10]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4+10]");
		bool flag2 = (nint)0 > (nint)0;
		((UnityEngine.Object)this).m_CachedPtr = (IntPtr)(flag2 ? 1 : 0);
		object obj2 = flag2 ^ flag;
		if (obj2 != null)
		{
			((VariableBool)(object)this).Clear();
		}
	}

	private void Update()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_002b: Expected Obj, but got I
		//IL_0037: Expected Obj, but got VT
		object obj = this + 12;
		_0021_00210 componentInChildren = (_0021_00210)((Component)this).GetComponentInChildren<T>();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (T)+3C]");
		_0021_00210 componentInChildren2 = (_0021_00210)((Component)0).GetComponentInChildren<T>();
		obj = componentInChildren2;
	}

	public AwardsScreenNavigation()
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

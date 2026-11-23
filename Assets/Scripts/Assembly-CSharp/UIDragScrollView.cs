using UnityEngine;

public class UIDragScrollView : MonoBehaviour
{
	public UIScrollView scrollView;

	private UIScrollView draggablePanel;

	private Transform mTrans;

	private UIScrollView mScroll;

	private bool mAutoFind;

	private bool mStarted;

	private void OnEnable()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0073: Expected Obj, but got I4
		Transform transform = base.transform;
		mTrans = transform;
		if (scrollView == null && draggablePanel != null)
		{
			object obj = this + 12;
			object obj2 = this + 16;
			obj = obj2;
			obj2 = 0;
		}
		if (~(mStarted ? 1u : 0u) == 0 && (~(mAutoFind ? 1u : 0u) == 0 || mScroll == null))
		{
			FindScrollView();
		}
	}

	private void Start()
	{
		mStarted = true;
		FindScrollView();
	}

	private void FindScrollView()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_0102: Expected Obj, but got I4
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		UIScrollView uIScrollView = NGUITools.FindInParents<UIScrollView>(mTrans);
		object obj = this + 12;
		object obj2;
		if (scrollView == null || (~(mAutoFind ? 1u : 0u) == 0 && uIScrollView != (Object)obj))
		{
			scrollView = uIScrollView;
			obj2 = this + 28;
		}
		else
		{
			if (!((Object)obj == uIScrollView))
			{
				goto IL_0107;
			}
			obj2 = this + 28;
		}
		obj2 = 1;
		goto IL_0107;
		IL_0107:
		mScroll = scrollView;
	}

	private void OnPress(bool pressed)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		if (~(mAutoFind ? 1u : 0u) == 0 && mScroll != scrollView)
		{
			mScroll = scrollView;
			mAutoFind = false;
		}
		if (!scrollView || !enabled)
		{
			return;
		}
		GameObject go = gameObject;
		if (NGUITools.GetActive(go))
		{
			object obj = this + 12;
			((UIScrollView)obj).Press(pressed);
			if (!pressed && ~(mAutoFind ? 1u : 0u) == 0)
			{
				UIScrollView uIScrollView = NGUITools.FindInParents<UIScrollView>(mTrans);
				scrollView = uIScrollView;
				mScroll = scrollView;
			}
		}
	}

	private void OnDrag(Vector2 delta)
	{
		if ((bool)scrollView && NGUITools.GetActive(this))
		{
			scrollView.Drag();
		}
	}

	private void OnScroll(float delta)
	{
		if ((bool)scrollView && NGUITools.GetActive(this))
		{
			scrollView.Scroll(delta);
		}
	}

	public unsafe void OnPan(Vector2 delta)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0048: Expected native int or pointer, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj - 16);
		if ((bool)scrollView && NGUITools.GetActive(this))
		{
			((Vector2*)(nint)vector)->x = delta.x;
			_ = delta.x;
			scrollView.OnPan(vector);
		}
	}
}

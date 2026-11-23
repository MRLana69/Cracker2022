using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;

public class TableElementAlwaysVisible : MonoBehaviour
{
	private sealed class _003CMovePanelAfterFrames_003Ed__22(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public int frames;

		public TableElementAlwaysVisible _003C_003E4__this;

		public float noOfPixels;

		private int _003CnumberOfFrames_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_0097;
				}
				_003C_003E1__state = -1;
				num = _003CnumberOfFrames_003E5__2;
			}
			else
			{
				_003CnumberOfFrames_003E5__2 = 0;
				_003C_003E1__state = -1;
				num = 0;
			}
			if (num >= frames)
			{
				_003C_003E4__this.MovePanelBy(noOfPixels);
				goto IL_0097;
			}
			_003C_003E2__current = null;
			int num2 = num + 1;
			_003CnumberOfFrames_003E5__2 = num2;
			_003C_003E1__state = 1;
			return true;
			IL_0097:
			return false;
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

	private UIPanel _scrollPanel;

	private TweenHeight _largestTweenHeight;

	private float _scrollPanelStartY;

	private UpgradeScreen _UpgradeParent;

	private BoostScreen _BoostParent;

	private int _index;

	public float ScrollPanelStartY
	{
		set
		{
			_scrollPanelStartY = value;
		}
	}

	public bool IsExpanded
	{
		get
		{
			UIWidget cachedWidget = _largestTweenHeight.cachedWidget;
			TweenHeight largestTweenHeight = _largestTweenHeight;
			return cachedWidget.mHeight != largestTweenHeight.from;
		}
	}

	public int index
	{
		get
		{
			return _index;
		}
		set
		{
			_index = value;
		}
	}

	public UpgradeScreen Upgradeparent
	{
		set
		{
			_UpgradeParent = value;
		}
	}

	public BoostScreen BoostParent
	{
		set
		{
			_BoostParent = value;
		}
	}

	private void Start()
	{
		if (_scrollPanel == null)
		{
			GameObject go = gameObject;
			UIPanel scrollPanel = NGUITools.FindInParents<UIPanel>(go);
			_scrollPanel = scrollPanel;
		}
	}

	private void TheElementIsOnBottom(float bottomPointOnScreen, float bottomPointOfTable)
	{
		//IL_00d0: Expected Obj, but got I4
		float noOfPixels;
		if (hasAnotherElementOpenOnBottom())
		{
			if (!WillExpand())
			{
				return;
			}
			noOfPixels = bottomPointOfTable - bottomPointOnScreen;
		}
		else
		{
			if (!hasAnotherElementOpenOnTop() || !WillExpand())
			{
				return;
			}
			float num = bottomPointOfTable - bottomPointOnScreen;
			TweenHeight largestTweenHeight = _largestTweenHeight;
			object obj = largestTweenHeight.to - largestTweenHeight.from;
			noOfPixels = num - (float)obj;
		}
		MovePanelBy(noOfPixels);
	}

	private void TheElementIsOnTop(float topPointOnScreen, float topPointOfTable)
	{
		//IL_006c: Expected Obj, but got I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		bool flag = hasAnotherElementOpenOnTop();
		bool flag2 = WillExpand();
		float noOfPixels;
		if (flag)
		{
			if (!flag2)
			{
				return;
			}
			TweenHeight largestTweenHeight = _largestTweenHeight;
			object obj = largestTweenHeight.to - largestTweenHeight.from;
			object obj2 = 0 - obj;
			float num = topPointOnScreen - topPointOfTable;
			float num2 = 0f - num;
			float num3 = num2 - 10f;
			noOfPixels = (float)obj2 + num3;
		}
		else
		{
			if (!flag2)
			{
				return;
			}
			float num4 = topPointOnScreen - topPointOfTable;
			float num5 = 0f - num4;
			noOfPixels = num5 - 10f;
		}
		MovePanelBy(noOfPixels);
	}

	private void OnClick()
	{
	}

	public void ToggleButtonScale()
	{
	}

	private IEnumerator MovePanelAfterFrames(float noOfPixels, int frames)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private unsafe void MovePanelBy(float noOfPixels)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected VT, but got Unknown
		//IL_00d0: Expected Obj, but got VT
		//IL_00f5: Expected Obj, but got F4
		//IL_0102: Expected F4, but got Obj
		//IL_010a: Expected native int or pointer, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj + -64);
		Transform transform = _scrollPanel.transform;
		Vector3 localPosition = transform.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+34]");
		float num = 0f + noOfPixels;
		Transform transform2 = _scrollPanel.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+20]");
		_ = 0;
		Vector3 localPosition2 = (Vector3)(vector + 8);
		transform2.localPosition = localPosition2;
		UIPanel scrollPanel = _scrollPanel;
		object obj2 = scrollPanel.mClipOffset - Vector2.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v26 (UIPanel)+F0]");
		float num2 = 0f - noOfPixels;
		object obj3 = num2 << 32;
		float x = obj2 | obj3;
		((Vector2*)(nint)vector)->x = x;
		scrollPanel.clipOffset = vector;
	}

	private bool hasAnotherElementOpenOnTop()
	{
		if (!(_UpgradeParent != null))
		{
			if (_BoostParent != null)
			{
				BoostScreen boostParent = _BoostParent;
				bool flag = boostParent._indexExpanded != -1;
				bool flag2 = boostParent._indexExpanded < _index;
				return flag & flag2;
			}
			return true;
		}
		UpgradeScreen upgradeParent = _UpgradeParent;
		bool flag3 = upgradeParent._indexExpanded != -1;
		bool flag4 = upgradeParent._indexExpanded < _index;
		return flag3 & flag4;
	}

	private bool hasAnotherElementOpenOnBottom()
	{
		if (!(_UpgradeParent != null))
		{
			if (_BoostParent != null)
			{
				BoostScreen boostParent = _BoostParent;
				bool flag = boostParent._indexExpanded != -1;
				bool flag2 = boostParent._indexExpanded > _index;
				return flag & flag2;
			}
			return false;
		}
		UpgradeScreen upgradeParent = _UpgradeParent;
		bool flag3 = upgradeParent._indexExpanded != -1;
		bool flag4 = upgradeParent._indexExpanded > _index;
		return flag3 & flag4;
	}

	private bool WillExpand()
	{
		UIWidget cachedWidget = _largestTweenHeight.cachedWidget;
		TweenHeight largestTweenHeight = _largestTweenHeight;
		return cachedWidget.mHeight == largestTweenHeight.from;
	}

	private bool AreAllClosed()
	{
		return false;
	}

	private void OnDestroy()
	{
		_UpgradeParent = null;
		_BoostParent = null;
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}

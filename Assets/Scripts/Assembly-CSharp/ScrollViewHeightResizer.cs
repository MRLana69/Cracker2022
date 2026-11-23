using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class ScrollViewHeightResizer : MonoBehaviour
{
	private sealed class _003CRepositionscrollView_003Ed__22(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public int frames;

		public ScrollViewHeightResizer _003C_003E4__this;

		private int _003Cindex_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			ScrollViewHeightResizer scrollViewHeightResizer = _003C_003E4__this;
			int num;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_0091;
				}
				_003C_003E1__state = -1;
				num = _003Cindex_003E5__2;
			}
			else
			{
				_003Cindex_003E5__2 = 0;
				_003C_003E1__state = -1;
				num = 0;
			}
			if (num >= frames)
			{
				UIScrollView component = scrollViewHeightResizer._scrollPanel.GetComponent<UIScrollView>();
				bool flag = component != null;
				goto IL_0091;
			}
			_003C_003E2__current = null;
			int num2 = num + 1;
			_003Cindex_003E5__2 = num2;
			_003C_003E1__state = 1;
			return true;
			IL_0091:
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

	private GameObject _scrollBar;

	private GameObject _scrollCollider;

	private UIPanel _scrollPanel;

	private GameObject _grid;

	private float _staticObjectsHeight;

	private float _centerOffset;

	private float _topStaticObjectsHeight;

	private bool _addTopCollider;

	private bool _addBottomcollider;

	private float _zDepth;

	private bool isCalculated;

	private bool rearrange;

	public unsafe Vector4 clipping
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0061: Expected F4, but got I
			//IL_005c: Expected native int or pointer, but got VT
			//IL_006e: Expected F4, but got Obj
			//IL_0069: Expected native int or pointer, but got VT
			object obj2 = default;
			object obj = obj2 - 16;
			if (~(isCalculated ? 1u : 0u) != 0)
			{
				RearrangeWidgets();
			}
			Vector4 finalClipRegion = _scrollPanel.finalClipRegion;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			Vector4 vector = default;
			((Vector4*)(nint)vector)->z = 0f;
			((Vector4*)(nint)vector)->x = (float)obj;
			return vector;
		}
	}

	public float Height
	{
		get
		{
			return _staticObjectsHeight;
		}
		set
		{
			_staticObjectsHeight = value;
		}
	}

	public unsafe Vector3 scrollPanelPosition
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0073: Expected F4, but got I
			//IL_006e: Expected native int or pointer, but got VT
			//IL_0080: Expected F4, but got Obj
			//IL_007b: Expected native int or pointer, but got VT
			object obj2 = default;
			object obj = obj2 - 16;
			if (~(isCalculated ? 1u : 0u) != 0)
			{
				RearrangeWidgets();
			}
			Transform transform = _scrollPanel.transform;
			Vector3 localPosition = transform.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			Vector3 vector = default;
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj;
			return vector;
		}
	}

	private void Update()
	{
		if (~(rearrange ? 1u : 0u) == 0)
		{
			RearrangeWidgets();
			rearrange = false;
		}
	}

	private void Start()
	{
		rearrange = false;
		bool flag = _scrollBar == null;
		bool flag2 = _scrollCollider == null;
		bool flag3 = _scrollPanel == null;
		bool flag4 = _grid == null;
		bool flag5 = _grid != null;
		RearrangeWidgets();
	}

	public unsafe void RearrangeWidgets()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0070: Expected Obj, but got I
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected VT, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected VT, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected VT, but got Unknown
		//IL_0245: Expected Obj, but got I
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected VT, but got Unknown
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected VT, but got Unknown
		//IL_03ba: Expected I4, but got F8
		//IL_0429: Expected F4, but got I
		//IL_0424: Expected native int or pointer, but got VT
		//IL_0450: Expected F4, but got I
		//IL_044b: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 208);
		UIScreenController instance = UIScreenController.Instance;
		UIScreenController instance2 = default;
		if (instance != null)
		{
			instance2 = UIScreenController.Instance;
			UIRoot root = instance2.root;
		}
		bool flag = instance2.root == null;
		UIScrollBar component = _scrollBar.GetComponent<UIScrollBar>();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v151 (UIRoot)+14]");
		object obj2 = (nint)0 / (nint)2;
		float num = (float)obj2 + _centerOffset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v151 (UIRoot)+14]");
		float num2 = 0f - _staticObjectsHeight;
		UIPanel scrollPanel = _scrollPanel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v31 (UIPanel)+D0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
		_ = 0;
		_ = scrollPanel.mClipRange;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
		_ = 0;
		Vector4 baseClipRegion = (Vector4)(vector + 80);
		scrollPanel.baseClipRegion = baseClipRegion;
		Transform transform = _scrollPanel.transform;
		Vector3 localPosition = transform.localPosition;
		UIPanel scrollPanel2 = _scrollPanel;
		float num3 = -0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v28 (UIPanel)+F0]");
		float num4 = num3 - 0f;
		Transform transform2 = _scrollPanel.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
		_ = 0;
		Vector3 localPosition2 = vector - -64;
		transform2.localPosition = localPosition2;
		Transform transform3 = _grid.transform;
		Vector3 localPosition3 = transform3.localPosition;
		Transform transform4 = _grid.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
		_ = 0;
		Vector3 localPosition4 = vector + 48;
		transform4.localPosition = localPosition4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v151 (UIRoot)+14]");
		object obj3 = (nint)0 / (nint)2;
		float num5 = (float)obj3 + _centerOffset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v151 (UIRoot)+14]");
		float num6 = 0f - _staticObjectsHeight;
		Transform transform5 = _scrollCollider.transform;
		Vector3 localPosition5 = transform5.localPosition;
		Transform transform6 = _scrollCollider.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		_ = 0;
		Vector3 localPosition6 = vector + 32;
		transform6.localPosition = localPosition6;
		Transform transform7 = _scrollCollider.transform;
		Vector3 localScale = transform7.localScale;
		Transform transform8 = _scrollCollider.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		_ = 0;
		Vector3 localScale2 = vector + 16;
		transform8.localScale = localScale2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num8 = default;
		double num7 = Math.Abs(num8);
		int height = ((!(num7 < 2147483648.0)) ? int.MinValue : ((int)num8));
		((UIProgressBar)component).mBG.height = height;
		((UIProgressBar)component).mFG.height = height;
		Transform transform9 = _scrollBar.transform;
		Vector3 localPosition7 = transform9.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v151 (UIRoot)+14]");
		float num9 = 0f - _topStaticObjectsHeight;
		Transform transform10 = _scrollBar.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		((Vector3*)(nint)vector)->x = 0f;
		transform10.localPosition = vector;
		IEnumerator routine = RepositionscrollView(1);
		Coroutine coroutine = StartCoroutine(routine);
		AddColliders();
		isCalculated = true;
	}

	private IEnumerator RepositionscrollView(int frames)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private unsafe void AddColliders()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected VT, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected VT, but got Unknown
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected VT, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected VT, but got Unknown
		//IL_044a: Expected native int or pointer, but got VT
		//IL_046e: Expected F4, but got I
		//IL_0469: Expected native int or pointer, but got VT
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 208);
		if (!isCalculated)
		{
			if (~(_addTopCollider ? 1u : 0u) == 0)
			{
				GameObject gameObject = base.gameObject;
				Transform transform = gameObject.transform;
				GameObject parent = transform.gameObject;
				GameObject gameObject2 = NGUITools.AddChild(parent);
				BoxCollider boxCollider = gameObject2.AddComponent<BoxCollider>();
				_ = _zDepth;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
				_ = 0;
				_ = Vector3.zeroVector;
				_ = Vector3.zeroVector;
				Vector3 center = vector + 80;
				boxCollider.center = center;
				gameObject2.name = "TopScrollBlocker";
				int height = Screen.height;
				Transform transform2 = _scrollCollider.transform;
				Vector3 localPosition = transform2.localPosition;
				Transform transform3 = _scrollCollider.transform;
				Vector3 localScale = transform3.localScale;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B4]");
				float num = 0f * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B4]");
				float num2 = 0f + num;
				float num3 = (float)height - num2;
				int height2 = Screen.height;
				float num4 = num3 * 0.5f;
				float num5 = (float)height2 - num4;
				int width = Screen.width;
				GameObject gameObject3 = base.gameObject;
				Transform transform4 = gameObject3.transform;
				Vector3 localPosition2 = transform4.localPosition;
				Transform transform5 = gameObject2.transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
				_ = 0;
				Vector3 localPosition3 = vector - -64;
				transform5.localPosition = localPosition3;
				Transform transform6 = gameObject2.transform;
				_ = 1065353216;
				_ = 1065353216;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
				_ = 0;
				Vector3 localScale2 = vector + 48;
				transform6.localScale = localScale2;
			}
			if (~(_addBottomcollider ? 1u : 0u) == 0)
			{
				GameObject gameObject4 = base.gameObject;
				Transform transform7 = gameObject4.transform;
				GameObject parent2 = transform7.gameObject;
				GameObject gameObject5 = NGUITools.AddChild(parent2);
				BoxCollider boxCollider2 = gameObject5.AddComponent<BoxCollider>();
				_ = _zDepth;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
				_ = 0;
				_ = Vector3.zeroVector;
				_ = Vector3.zeroVector;
				Vector3 center2 = vector + 32;
				boxCollider2.center = center2;
				gameObject5.name = "BottomScrollBlocker";
				Transform transform8 = _scrollCollider.transform;
				Vector3 localPosition4 = transform8.localPosition;
				Transform transform9 = _scrollCollider.transform;
				Vector3 localScale3 = transform9.localScale;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B4]");
				float num6 = 0f * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B4]");
				float num7 = 0f - num6;
				int width2 = Screen.width;
				GameObject gameObject6 = base.gameObject;
				Transform transform10 = gameObject6.transform;
				Vector3 localPosition5 = transform10.localPosition;
				Transform transform11 = gameObject5.transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
				_ = 0;
				float num8 = num7 * 0.5f;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
				_ = 0;
				Vector3 localPosition6 = vector + 16;
				transform11.localPosition = localPosition6;
				Transform transform12 = gameObject5.transform;
				_ = 1065353216;
				((Vector3*)(nint)vector)->z = 1f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
				((Vector3*)(nint)vector)->x = 0f;
				transform12.localScale = vector;
			}
		}
	}
}

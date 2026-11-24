using System;
using System.Collections;
using Cpp2ILInjected;
using UnityEngine;

public class UIDragScrollView : MonoBehaviour
{
	public UIScrollView scrollView;

	private UIScrollView draggablePanel;

	private Transform mTrans;

	private UIScrollView mScroll;

	private bool mAutoFind;

	private bool mStarted;

	[NonSerialized]
	private bool mPressed;

	private void OnEnable()
	{
		//IL_000b: Expected Obj, but got I4
		//IL_0016: Expected Obj, but got I4
		//IL_0021: Expected Obj, but got I4
		draggablePanel = (UIScrollView)8;
		mTrans = (Transform)100;
		mScroll = (UIScrollView)100;
		mAutoFind = true;
		_ = 100000;
		CancelInvoke();
	}

	private void Start()
	{
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_01f6: Expected I, but got Obj
		//IL_020c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0140: Expected I, but got Obj
		//IL_0156: Expected Obj, but got I
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_0109: Expected Obj, but got I4
		//IL_0181: Expected I, but got Obj
		object obj = this + 20;
		GameObject gameObject = base.gameObject;
		obj = gameObject;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v40 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (scrollView != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v36 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)draggablePanel).FindKernel((string)null) != 0)
			{
				object obj4 = this + 12;
				obj4 = draggablePanel;
				object obj5 = this + 16;
				obj5 = 0;
			}
		}
		if (~(mStarted ? 1u : 0u) != 0)
		{
			return;
		}
		if (~(mAutoFind ? 1u : 0u) != 0)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!(mScroll != null))
			{
				return;
			}
		}
		OnDisable();
	}

	private void FindScrollView()
	{
		mStarted = true;
		OnDisable();
	}

	private void OnDisable()
	{
		//IL_0215: Expected I, but got Obj
		//IL_022b: Expected Obj, but got I
		//IL_02d5: Expected I, but got Obj
		//IL_02eb: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0154: Expected I, but got Obj
		//IL_016a: Expected Obj, but got I
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected Obj, but got Unknown
		//IL_00c6: Expected I, but got Obj
		//IL_00dc: Expected Obj, but got I
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected Obj, but got Unknown
		//IL_0195: Expected I, but got Obj
		//IL_0107: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v34 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScrollView uIScrollView = NGUITools.FindInParents<UIScrollView>(mTrans);
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v45 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (scrollView == null)
		{
			if (~(mAutoFind ? 1u : 0u) == 0)
			{
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v35 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v41 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)uIScrollView).FindKernel((string)(object)scrollView) != 0)
				{
					goto IL_01e4;
				}
			}
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (scrollView != uIScrollView)
			{
				mAutoFind = true;
			}
			goto IL_0308;
		}
		goto IL_01e4;
		IL_0308:
		object obj5 = this + 24;
		obj5 = scrollView;
		return;
		IL_01e4:
		object obj6 = this + 12;
		obj6 = uIScrollView;
		mAutoFind = true;
		goto IL_0308;
	}

	private unsafe void OnPress(bool pressed)
	{
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected Obj, but got Unknown
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Expected Obj, but got Unknown
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected Obj, but got Unknown
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected Obj, but got Unknown
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected Obj, but got Unknown
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected Obj, but got Unknown
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected Obj, but got Unknown
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected Obj, but got Unknown
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected Obj, but got Unknown
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected Obj, but got Unknown
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Expected Obj, but got Unknown
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Expected Obj, but got Unknown
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected Obj, but got Unknown
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected VT, but got Unknown
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected Obj, but got Unknown
		//IL_0539: Expected Obj, but got F4
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected Obj, but got Unknown
		//IL_0550: Expected Obj, but got I4
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Expected Obj, but got Unknown
		//IL_0573: Expected Obj, but got I4
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Expected Obj, but got Unknown
		//IL_0590: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_0640: Unknown result type (might be due to invalid IL or missing references)
		//IL_0645: Expected Obj, but got Unknown
		//IL_00e2: Expected I, but got Obj
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_01a7: Expected Obj, but got I
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_01e8: Expected I, but got Obj
		//IL_01fe: Expected Obj, but got I
		//IL_06b3: Expected VT, but got Obj
		//IL_06b3: Expected VT, but got Obj
		//IL_06d9: Expected VT, but got Obj
		//IL_071d: Expected VT, but got Obj
		//IL_071d: Expected VT, but got Obj
		//IL_029f: Expected VT, but got Obj
		//IL_0229: Expected I, but got Obj
		//IL_02b2: Expected I, but got Obj
		//IL_02c8: Expected Obj, but got I
		//IL_0749: Expected VT, but got Obj
		//IL_075a: Expected VT, but got Obj
		//IL_0760: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Expected Obj, but got Unknown
		//IL_07be: Expected VT, but got Obj
		//IL_07be: Expected VT, but got Obj
		//IL_037d: Expected VT, but got Obj
		//IL_037d: Expected VT, but got Obj
		//IL_037d: Expected Ref, but got VT
		//IL_038a: Expected Obj, but got F4
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected Obj, but got Unknown
		//IL_02f3: Expected I, but got Obj
		//IL_0459: Expected I, but got Obj
		object obj = default;
		Transform transform = (Transform)(obj + 248);
		GameObject gameObject = (GameObject)(obj + 224);
		object obj2 = obj + 156;
		object obj3 = obj + 144;
		object obj4 = obj + 132;
		object obj5 = obj + 120;
		Transform transform2 = (Transform)(obj + 108);
		object obj6 = obj + 96;
		Transform transform3 = (Transform)(obj + 80);
		object obj7 = obj - -64;
		Transform transform4 = (Transform)(obj + 48);
		object obj8 = obj + 36;
		object obj9 = obj + 24;
		Quaternion quaternion = (Quaternion)(obj + 12);
		object obj10 = obj + 216;
		obj10 = 0f;
		object obj11 = obj + 192;
		obj11 = 0;
		_ = 0;
		_ = 0;
		object obj12 = obj + 180;
		obj12 = 0;
		_ = 0;
		object obj13 = obj + 168;
		obj13 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragScrollView)+58]");
		if ((nint)0 == 0)
		{
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S1_v151 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)scrollView).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v56 (Il2CppClass<UICamera>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num4 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v149 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UICamera.genericEventHandler = gameObject;
		obj11 = gameObject;
		_ = ((UnityEngine.Object)gameObject).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.GameObject)+10]");
		_ = 0;
		transform = (Transform)obj11;
		Transform transform5 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v39+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v39+10]");
		_ = 0;
		object obj16 = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F8D6");
		object obj17 = default;
		if (obj17 == null)
		{
			return;
		}
		Camera anchorCamera = ((UIRect)(object)scrollView).anchorCamera;
		object obj18 = this + 68;
		obj2 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S1_v54+8]");
		_ = 0;
		transform = (Transform)obj2;
		Transform transform6 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		UIScrollView uIScrollView = scrollView;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragScrollView)+50]");
		((UIWidget)(object)uIScrollView).height = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragScrollView)+54]");
		Color color = ((UIWidget)0).color;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F969");
		object obj19 = this + 56;
		obj4 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S1_v69+8]");
		_ = 0;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v86 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num6 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S0_v145 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		gameObject = (GameObject)obj3;
		GameObject gameObject2 = gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		((UnityEngine.Object)gameObject2).m_CachedPtr = (IntPtr)0;
		transform = (Transform)obj4;
		Transform transform7 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
		((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
		Quaternion quaternion2 = Quaternion.FromToRotation((Vector3)gameObject, (Vector3)transform);
		obj12 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
		_ = 0;
		transform2.position = (Vector3)anchorCamera;
		gameObject = (GameObject)(object)transform2;
		((UnityEngine.Object)gameObject).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
		transform = (Transform)obj12;
		Transform transform8 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v43+8]");
		((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
		Vector3 vector = (Vector3)gameObject - (Vector3)transform;
		transform = (Transform)obj6;
		Transform transform9 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
		((UnityEngine.Object)transform9).m_CachedPtr = (IntPtr)0;
		Vector3 localPosition = transform.localPosition;
		transform3.localRotation = (Quaternion)anchorCamera;
		nint num7 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ S0_v108 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num8 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ S0_v141 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		transform = transform3;
		((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform3).m_CachedPtr;
		Quaternion quaternion3 = Quaternion.Internal_FromEulerRad((Vector3)transform);
		transform4.localPosition = (Vector3)anchorCamera;
		object obj22 = this + 68;
		obj8 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ S1_v111+8]");
		_ = 0;
		gameObject = (GameObject)(object)transform4;
		((UnityEngine.Object)gameObject).m_CachedPtr = ((UnityEngine.Object)transform4).m_CachedPtr;
		transform = (Transform)obj8;
		Transform transform10 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
		((UnityEngine.Object)transform10).m_CachedPtr = (IntPtr)0;
		Quaternion quaternion4 = Quaternion.FromToRotation((Vector3)gameObject, (Vector3)transform);
		gameObject = (GameObject)obj7;
		GameObject gameObject3 = gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27+8]");
		((UnityEngine.Object)gameObject3).m_CachedPtr = (IntPtr)0;
		transform = (Transform)obj9;
		Transform transform11 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33+8]");
		((UnityEngine.Object)transform11).m_CachedPtr = (IntPtr)0;
		((Quaternion*)quaternion)->SetLookRotation((Vector3)gameObject, (Vector3)transform);
		obj13 = quaternion.x;
		_ = quaternion.z;
		object obj23 = this + 68;
		gameObject = (GameObject)obj23;
		GameObject gameObject4 = gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ S1_v138+8]");
		((UnityEngine.Object)gameObject4).m_CachedPtr = (IntPtr)0;
		transform = (Transform)(object)gameObject;
		((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)gameObject).m_CachedPtr;
		Vector3 eulerAngles2 = transform.eulerAngles;
		transform = (Transform)obj13;
		Transform transform12 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v46+8]");
		((UnityEngine.Object)transform12).m_CachedPtr = (IntPtr)0;
		obj = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v46+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B736");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragScrollView)+24]");
		if ((nint)0 != 0)
		{
			UnityEngine.SetupCoroutine.InvokeMoveNext((IEnumerator)scrollView, (IntPtr)"UpdateAnchors");
		}
	}

	private void OnDrag(Vector2 delta)
	{
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected I4, but got Unknown
		//IL_0376: Expected I, but got Obj
		//IL_038c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00c6: Expected I, but got Obj
		//IL_0054: Expected I, but got Obj
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_0140: Expected I, but got Obj
		//IL_0156: Expected Obj, but got I
		//IL_0181: Expected I, but got Obj
		//IL_01d8: Invalid comparison between VT and I4
		//IL_021e: Expected I, but got Obj
		//IL_0234: Expected Obj, but got I
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected Obj, but got Unknown
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected Obj, but got Unknown
		//IL_025f: Expected I, but got Obj
		bool flag = (byte)(delta & 1) != 0;
		mPressed = flag;
		if (~(mAutoFind ? 1u : 0u) == 0)
		{
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S2_v15 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mScroll).FindKernel((string)(object)scrollView) != 0)
			{
				object obj2 = this + 24;
				obj2 = scrollView;
				mAutoFind = false;
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)scrollView) || !isActiveAndEnabled)
		{
			return;
		}
		string fileName = tag;
		nint num5 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v15 (Il2CppClass<NGUITools>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S1_v28 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		byte[] array = NGUITools.Load(fileName);
		if (array == null)
		{
			return;
		}
		scrollView.OnPan(delta);
		if (delta != (Vector2)(object)0 || ~(mAutoFind ? 1u : 0u) != 0)
		{
			return;
		}
		nint num7 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v27 (Il2CppClass<NGUITools>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v35 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = this + 12;
		UIScrollView uIScrollView = NGUITools.FindInParents<UIScrollView>(mTrans);
		obj6 = uIScrollView;
		object obj7 = this + 24;
		obj7 = scrollView;
	}

	private unsafe void OnScroll(float delta)
	{
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected VT, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected VT, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00eb: Expected I, but got Obj
		//IL_0101: Expected Obj, but got I
		//IL_022f: Expected F4, but got Obj
		//IL_022a: Expected native int or pointer, but got VT
		//IL_0244: Expected F4, but got I
		//IL_023f: Expected native int or pointer, but got VT
		//IL_0272: Expected F4, but got Obj
		//IL_026d: Expected native int or pointer, but got VT
		//IL_0287: Expected F4, but got I
		//IL_0282: Expected native int or pointer, but got VT
		//IL_0294: Expected F4, but got Obj
		//IL_028f: Expected native int or pointer, but got VT
		//IL_02a9: Expected F4, but got I
		//IL_02a4: Expected native int or pointer, but got VT
		//IL_02c7: Expected F4, but got Obj
		//IL_02c2: Expected native int or pointer, but got VT
		//IL_02dc: Expected F4, but got I
		//IL_02d7: Expected native int or pointer, but got VT
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		//IL_02f4: Expected Obj, but got F4
		//IL_012c: Expected I, but got Obj
		object obj = default;
		Vector3 vector = (Vector3)(obj + 72);
		Vector3 vector2 = (Vector3)(obj + 60);
		object obj2 = obj + 48;
		object obj3 = obj + 24;
		object obj4 = obj + 12;
		object obj5 = obj + 36;
		if (!isActiveAndEnabled)
		{
			return;
		}
		string fileName = tag;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v13 (Il2CppClass<NGUITools>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v56 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		byte[] array = NGUITools.Load(fileName);
		if (array == null)
		{
			return;
		}
		object obj7 = this + 116;
		obj2 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v19+8]");
		_ = 0;
		object obj8 = this + 20;
		obj3 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v24+8]");
		_ = 0;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v32 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v51 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj5;
		Vector3 vector3 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		float num5 = delta * 0.05f;
		Vector3 vector4 = vector / num5;
		((Vector3*)(nint)vector2)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj4;
		Vector3 vector5 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		Quaternion quaternion = Quaternion.FromToRotation(vector2, vector);
		((Vector3*)(nint)vector)->x = (float)obj;
		Vector3 vector6 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		object obj10 = this + 116;
		obj10 = vector.x;
		_ = vector.z;
	}

	public void OnPan(Vector2 delta)
	{
		//IL_00fe: Expected I, but got Obj
		//IL_0114: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)scrollView))
		{
			return;
		}
		nint num3 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v10 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v18 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (NGUITools.GetActive((GameObject)(object)this))
		{
			scrollView.LateUpdate();
		}
	}

	public UIDragScrollView()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00b0: Expected I, but got Obj
		//IL_00c6: Expected Obj, but got I
		//IL_00f1: Expected I, but got Obj
		//IL_0140: Expected VT, but got I4
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_0154: Expected Obj, but got I4
		if (~(mPressed ? 1u : 0u) != 0)
		{
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mScroll).FindKernel((string)null) == 0)
		{
			return;
		}
		_0021_00210[] componentsInChildren = (_0021_00210[])(object)((Component)mScroll).GetComponentsInChildren<T>();
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)(object)componentsInChildren != null)
		{
			mScroll.OnPan((Vector2)0);
			object obj3 = this + 24;
			obj3 = 0;
		}
	}
}

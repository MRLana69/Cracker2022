using System;
using Cpp2ILInjected;
using UnityEngine;

public class CenterOnChild : MonoBehaviour
{
	private UIScrollView mDrag;

	private GameObject mCenteredObject;

	private GameObject mSelectedObject;

	[NonSerialized]
	public bool characterWasClicked;

	public GameObject centeredObject => mSelectedObject;

	public void ClearCenterObject()
	{
		mSelectedObject = null;
	}

	private void OnEnable()
	{
		Recenter();
	}

	private void OnDragFinished()
	{
		if (enabled)
		{
			Recenter();
		}
	}

	private void OnStringFinished()
	{
		mCenteredObject = mSelectedObject;
	}

	public unsafe void Recenter()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_010f: Expected Obj, but got I
		//IL_012c: Expected Obj, but got I
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected VT, but got Unknown
		//IL_065c: Expected I, but got Obj
		//IL_06ae: Expected VT, but got I
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected VT, but got Unknown
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected VT, but got Unknown
		//IL_0763: Expected Obj, but got I4
		//IL_086e: Expected F4, but got I
		//IL_0869: Expected native int or pointer, but got VT
		//IL_088d: Expected F4, but got I
		//IL_0888: Expected native int or pointer, but got VT
		//IL_05a3: Invalid comparison between I and F4
		//IL_052e: Invalid comparison between VT and F4
		object obj = default;
		Vector3 vector = (Vector3)(obj - 176);
		if (mDrag == null)
		{
			GameObject go = base.gameObject;
			UIScrollView uIScrollView = NGUITools.FindInParents<UIScrollView>(go);
			mDrag = uIScrollView;
			if (mDrag == null)
			{
				enabled = false;
				return;
			}
			UIScrollView uIScrollView2 = mDrag;
			UIScrollView.OnDragNotification onDragNotification = default;
			onDragNotification._002Ector(this, (nint)__ldftn(CenterOnChild.OnDragFinished));
			uIScrollView2.onDragFinished = onDragNotification;
		}
		UIScrollView uIScrollView3 = mDrag;
		if (!(uIScrollView3.mPanel != null))
		{
			return;
		}
		UIScrollView uIScrollView4 = mDrag;
		Vector4 finalClipRegion = uIScrollView4.mPanel.finalClipRegion;
		UIScrollView uIScrollView5 = mDrag;
		Transform cachedTransform = uIScrollView5.mPanel.cachedTransform;
		Vector3 localPosition = cachedTransform.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
		object obj2 = num + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A4]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A4]");
		object obj3 = num2 + 0;
		Transform parent = cachedTransform.parent;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
		_ = 0;
		Vector3 position = vector - -64;
		Vector3 vector2 = parent.TransformPoint(position);
		UIScrollView uIScrollView6 = mDrag;
		float num3 = uIScrollView6.momentumAmount * 0.1f;
		float num4 = (float)uIScrollView6.mMomentum * num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
		float num5 = 0f - num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v50 (UIScrollView)+90]");
		float num6 = 0f * num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A4]");
		float num7 = 0f - num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v50 (UIScrollView)+94]");
		float num8 = 0f * num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
		float num9 = 0f - num8;
		UIScrollView uIScrollView7 = mDrag;
		nint num10 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S0_v68 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v69 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		uIScrollView7.mMomentum = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		uIScrollView7.mShouldMove = true;
		Transform transform = base.transform;
		int childCount = transform.childCount;
		int num12 = 0;
		float num13 = float.MaxValue;
		UnityEngine.Object obj4 = null;
		while (num12 < childCount)
		{
			Transform child = transform.GetChild(num12);
			Vector3 position2 = child.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
			float num14 = 0f - num5;
			float num15 = num14 * num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A4]");
			float num16 = 0f - num7;
			float num17 = num16 * num16;
			float num18 = num15 + num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
			float num19 = 0f - num9;
			float num20 = num19 * num19;
			float num21 = num18 + num20;
			bool flag = num13 > num21;
			if (!flag)
			{
				num21 = num13;
			}
			UnityEngine.Object obj5 = child;
			if (!flag)
			{
				obj5 = obj4;
			}
			int num22 = num12 + 1;
			num12 = num22;
			num13 = num21;
			obj4 = obj5;
		}
		float num24;
		float num26;
		bool flag3;
		bool flag5;
		if (obj4 != null)
		{
			GameObject gameObject = ((Component)obj4).gameObject;
			mSelectedObject = gameObject;
			Vector3 position3 = ((Transform)obj4).position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
			_ = 0;
			Vector3 position4 = vector + 32;
			Vector3 vector3 = cachedTransform.InverseTransformPoint(position4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A4]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			_ = 0;
			Vector3 position5 = vector + 16;
			Vector3 vector4 = cachedTransform.InverseTransformPoint(position5);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
			float num23 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
			num24 = num23 - 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A4]");
			float num25 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A4]");
			num26 = num25 - 0f;
			UIScrollView uIScrollView8 = mDrag;
			bool flag2 = uIScrollView8.movement == UIScrollView.Movement.Horizontal;
			flag3 = true;
			if (!flag2)
			{
				if (uIScrollView8.movement != UIScrollView.Movement.Vertical)
				{
					bool flag4 = uIScrollView8.movement == UIScrollView.Movement.Unrestricted;
					flag3 = true;
					if (flag4)
					{
						goto IL_0739;
					}
					if (uIScrollView8.movement == UIScrollView.Movement.Custom)
					{
						flag5 = uIScrollView8.customMovement != (Vector2)(object)0f;
						goto IL_0746;
					}
				}
				flag3 = false;
			}
			goto IL_0739;
		}
		mSelectedObject = null;
		return;
		IL_0739:
		flag5 = flag3;
		goto IL_0746;
		IL_0746:
		UIScrollView uIScrollView9 = mDrag;
		object obj6 = uIScrollView9.movement - 1;
		bool flag6 = uIScrollView9.movement == UIScrollView.Movement.Vertical;
		bool flag7 = true;
		bool flag9;
		if (!flag6)
		{
			bool flag8 = (nint)obj6 == 1;
			flag7 = true;
			if (!flag8)
			{
				if ((nint)obj6 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ S0_v127 (UIScrollView)+34]");
					flag9 = 0f != 0f;
					goto IL_079b;
				}
				flag7 = false;
			}
		}
		flag9 = flag7;
		goto IL_079b;
		IL_079b:
		GameObject go2 = mDrag.gameObject;
		Vector3 localPosition2 = cachedTransform.localPosition;
		float num27 = num24;
		if (!flag5)
		{
			num27 = 0f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
		float num28 = 0f - num27;
		float num29 = num26;
		if (!flag9)
		{
			num29 = 0f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A4]");
		float num30 = 0f - num29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
		float num31 = 0f - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		((Vector3*)(nint)vector)->x = 0f;
		SpringPanel springPanel = SpringPanel.Begin(go2, vector, 8f);
		SpringPanel.OnFinished onFinished = default;
		onFinished._002Ector(this, (nint)__ldftn(CenterOnChild.OnStringFinished));
		springPanel.onFinished = onFinished;
	}

	public unsafe void CenterOnTransform(Transform target, bool instant = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_019f: Expected Obj, but got I
		//IL_01bc: Expected Obj, but got I
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected VT, but got Unknown
		//IL_079f: Expected I, but got Obj
		//IL_07f1: Expected VT, but got I
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_0281: Expected Obj, but got I
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected VT, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected VT, but got Unknown
		//IL_0886: Expected Obj, but got I4
		//IL_0414: Invalid comparison between VT and F4
		//IL_06cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d4: Expected VT, but got Unknown
		//IL_0564: Expected Obj, but got F4
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected Obj, but got Unknown
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Expected VT, but got Unknown
		//IL_0497: Invalid comparison between I and F4
		//IL_05b5: Expected F4, but got I
		//IL_05b0: Expected native int or pointer, but got VT
		//IL_05d4: Expected F4, but got I
		//IL_05cf: Expected native int or pointer, but got VT
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 224);
		if (mDrag == null)
		{
			GameObject go = base.gameObject;
			UIScrollView uIScrollView = NGUITools.FindInParents<UIScrollView>(go);
			mDrag = uIScrollView;
			if (mDrag == null)
			{
				enabled = false;
				return;
			}
			UIScrollView uIScrollView2 = mDrag;
			UIScrollView.OnDragNotification onDragNotification = default;
			onDragNotification._002Ector(this, (nint)__ldftn(CenterOnChild.OnDragFinished));
			uIScrollView2.onDragFinished = onDragNotification;
		}
		UIScrollView uIScrollView3 = mDrag;
		if (!(uIScrollView3.mPanel != null))
		{
			return;
		}
		Transform transform = base.transform;
		int childCount = transform.childCount;
		int num = 0;
		Transform cachedTransform;
		float num8;
		float num10;
		bool flag4;
		while (true)
		{
			if (num >= childCount)
			{
				return;
			}
			Transform child = transform.GetChild(num);
			if (!(child == target))
			{
				int num2 = num + 1;
				num = num2;
				continue;
			}
			UIScrollView uIScrollView4 = mDrag;
			Vector4 finalClipRegion = uIScrollView4.mPanel.finalClipRegion;
			UIScrollView uIScrollView5 = mDrag;
			cachedTransform = uIScrollView5.mPanel.cachedTransform;
			Vector3 localPosition = cachedTransform.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
			object obj2 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D4]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D4]");
			object obj3 = num4 + 0;
			Transform parent = cachedTransform.parent;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
			_ = 0;
			Vector3 position = vector + 88;
			Vector3 vector2 = parent.TransformPoint(position);
			UIScrollView uIScrollView6 = mDrag;
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S0_v76 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S0_v77 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
			_ = 0;
			_ = Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			uIScrollView6.mMomentum = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			_ = 0;
			uIScrollView6.mShouldMove = true;
			bool flag2;
			if (target != null)
			{
				GameObject gameObject = target.gameObject;
				mSelectedObject = gameObject;
				Vector3 position2 = target.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
				_ = 0;
				object obj4 = vector - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
				_ = 0;
				Vector3 position3 = vector + 56;
				Vector3 vector3 = cachedTransform.InverseTransformPoint(position3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D4]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
				_ = 0;
				Vector3 position4 = vector + 40;
				Vector3 vector4 = cachedTransform.InverseTransformPoint(position4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D4]");
				float num7 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D4]");
				num8 = num7 - 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
				float num9 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
				num10 = num9 - 0f;
				UIScrollView uIScrollView7 = mDrag;
				bool flag = uIScrollView7.movement == UIScrollView.Movement.Horizontal;
				flag2 = true;
				if (!flag)
				{
					if (uIScrollView7.movement != UIScrollView.Movement.Vertical)
					{
						bool flag3 = uIScrollView7.movement == UIScrollView.Movement.Unrestricted;
						flag2 = true;
						if (flag3)
						{
							goto IL_0833;
						}
						if (uIScrollView7.movement == UIScrollView.Movement.Custom)
						{
							flag4 = uIScrollView7.customMovement != (Vector2)(object)0f;
							break;
						}
					}
					flag2 = false;
				}
				goto IL_0833;
			}
			mSelectedObject = null;
			return;
			IL_0833:
			flag4 = flag2;
			break;
		}
		if (!flag4)
		{
			num10 = 0f;
		}
		UIScrollView uIScrollView8 = mDrag;
		object obj5 = uIScrollView8.movement - 1;
		bool flag5 = uIScrollView8.movement == UIScrollView.Movement.Vertical;
		bool flag6 = true;
		bool flag8;
		if (!flag5)
		{
			bool flag7 = (nint)obj5 == 1;
			flag6 = true;
			if (!flag7)
			{
				if ((nint)obj5 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S2_v27 (UIScrollView)+34]");
					flag8 = 0f != 0f;
					goto IL_085b;
				}
				flag6 = false;
			}
		}
		flag8 = flag6;
		goto IL_085b;
		IL_085b:
		if (!flag8)
		{
			num8 = 0f;
		}
		if (instant)
		{
			Vector3 localPosition2 = cachedTransform.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
			float num11 = 0f - num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D4]");
			float num12 = 0f - num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
			float num13 = 0f - 0f;
			UIScrollView uIScrollView9 = mDrag;
			UIPanel mPanel = uIScrollView9.mPanel;
			float num14 = (float)mPanel.mClipOffset + num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ S0_v159 (UIPanel)+F0]");
			float num15 = 0f + num8;
			object obj6 = num15 << 32;
			object obj7 = num14 | obj6;
			Vector2 clipOffset = (Vector2)(vector + 16);
			mPanel.clipOffset = clipOffset;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
			((Vector3*)(nint)vector)->x = 0f;
			cachedTransform.localPosition = vector;
			if (mDrag != null)
			{
				UIScrollView uIScrollView10 = mDrag;
				object obj8 = uIScrollView10 - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v547 @ S2_v48+BC] (should have been resolved before IL gen)");
			}
		}
		else
		{
			GameObject go2 = mDrag.gameObject;
			Vector3 localPosition3 = cachedTransform.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
			float num16 = 0f - num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D4]");
			float num17 = 0f - num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
			float num18 = 0f - 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Vector3 pos = vector + 24;
			SpringPanel springPanel = SpringPanel.Begin(go2, pos, 8f);
			SpringPanel.OnFinished onFinished = default;
			onFinished._002Ector(this, (nint)__ldftn(CenterOnChild.OnStringFinished));
			springPanel.onFinished = onFinished;
		}
	}

	public unsafe bool CenterOnClosestChildAtPosition(Vector2 clickPositionOnScreen)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0118: Expected Obj, but got I
		//IL_0135: Expected Obj, but got I
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected VT, but got Unknown
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected VT, but got Unknown
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected VT, but got Unknown
		//IL_07f1: Expected Obj, but got I4
		//IL_08fc: Expected F4, but got I
		//IL_08f7: Expected native int or pointer, but got VT
		//IL_091b: Expected F4, but got I
		//IL_0916: Expected native int or pointer, but got VT
		//IL_05b0: Invalid comparison between I and F4
		//IL_053b: Invalid comparison between VT and F4
		object obj = default;
		Vector3 vector = (Vector3)(obj - 144);
		bool result;
		if (mDrag == null)
		{
			GameObject go = base.gameObject;
			UIScrollView uIScrollView = NGUITools.FindInParents<UIScrollView>(go);
			mDrag = uIScrollView;
			if (mDrag == null)
			{
				enabled = false;
				result = false;
				goto IL_06f1;
			}
			UIScrollView uIScrollView2 = mDrag;
			UIScrollView.OnDragNotification onDragNotification = default;
			onDragNotification._002Ector(this, (nint)__ldftn(CenterOnChild.OnDragFinished));
			uIScrollView2.onDragFinished = onDragNotification;
		}
		UIScrollView uIScrollView3 = mDrag;
		bool flag = uIScrollView3.mPanel != null;
		result = false;
		Transform cachedTransform;
		UnityEngine.Object obj4;
		float num17;
		float num19;
		bool flag7;
		bool flag9;
		if (flag)
		{
			UIScrollView uIScrollView4 = mDrag;
			Vector4 finalClipRegion = uIScrollView4.mPanel.finalClipRegion;
			UIScrollView uIScrollView5 = mDrag;
			cachedTransform = uIScrollView5.mPanel.cachedTransform;
			Vector3 localPosition = cachedTransform.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
			object obj2 = num + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+84]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+84]");
			object obj3 = num2 + 0;
			Transform parent = cachedTransform.parent;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
			_ = 0;
			Vector3 position = vector + 48;
			Vector3 vector2 = parent.TransformPoint(position);
			int width = Screen.width;
			DeviceInfo instance = DeviceInfo.Instance;
			float num4;
			float num5;
			if (instance.formFactor__BackingField == DeviceInfo.FormFactor.iPad)
			{
				int width2 = Screen.width;
				float num3 = (float)width2 / 384f;
				num4 = num3 * 48f;
				num5 = num3;
			}
			else
			{
				float num6 = (float)width / 320f;
				num4 = num6 * 16f;
				num5 = num6;
			}
			float num7 = clickPositionOnScreen.x - num4;
			float num8 = num7 / num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
			float num9 = 0f * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
			float num10 = 0f - num9;
			float num11 = num8 + num10;
			Transform transform = base.transform;
			int childCount = transform.childCount;
			obj4 = null;
			float num12 = float.MaxValue;
			int num13 = 0;
			while (num13 < childCount)
			{
				Transform child = transform.GetChild(num13);
				Vector3 localPosition2 = child.localPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				float value = 0f - num11;
				float num14 = Math.Abs(value);
				bool flag2 = num12 > num14;
				if (!flag2)
				{
					num14 = num12;
				}
				UnityEngine.Object obj5 = child;
				if (!flag2)
				{
					obj5 = obj4;
				}
				int num15 = num13 + 1;
				obj4 = obj5;
				num12 = num14;
				num13 = num15;
			}
			bool flag3 = obj4 != null;
			bool flag4 = !flag3;
			result = false;
			if (!flag4)
			{
				GameObject gameObject = ((Component)obj4).gameObject;
				if (mSelectedObject == gameObject)
				{
					GameObject gameObject2 = ((Component)obj4).gameObject;
					bool flag5 = mCenteredObject != gameObject2;
					result = true;
					if (!flag5)
					{
						goto IL_06f1;
					}
				}
				mCenteredObject = null;
				characterWasClicked = true;
				Vector3 position2 = ((Transform)obj4).position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				_ = 0;
				Vector3 position3 = vector + 32;
				Vector3 vector3 = cachedTransform.InverseTransformPoint(position3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+84]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
				_ = 0;
				Vector3 position4 = vector + 16;
				Vector3 vector4 = cachedTransform.InverseTransformPoint(position4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				float num16 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				num17 = num16 - 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+84]");
				float num18 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+84]");
				num19 = num18 - 0f;
				UIScrollView uIScrollView6 = mDrag;
				bool flag6 = uIScrollView6.movement == UIScrollView.Movement.Horizontal;
				flag7 = true;
				if (!flag6)
				{
					if (uIScrollView6.movement != UIScrollView.Movement.Vertical)
					{
						bool flag8 = uIScrollView6.movement == UIScrollView.Movement.Unrestricted;
						flag7 = true;
						if (flag8)
						{
							goto IL_07c7;
						}
						if (uIScrollView6.movement == UIScrollView.Movement.Custom)
						{
							flag9 = uIScrollView6.customMovement != (Vector2)(object)0f;
							goto IL_07d4;
						}
					}
					flag7 = false;
				}
				goto IL_07c7;
			}
		}
		goto IL_06f1;
		IL_07d4:
		UIScrollView uIScrollView7 = mDrag;
		object obj6 = uIScrollView7.movement - 1;
		bool flag10 = uIScrollView7.movement == UIScrollView.Movement.Vertical;
		bool flag11 = true;
		bool flag13;
		if (!flag10)
		{
			bool flag12 = (nint)obj6 == 1;
			flag11 = true;
			if (!flag12)
			{
				if ((nint)obj6 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ S0_v130 (UIScrollView)+34]");
					flag13 = 0f != 0f;
					goto IL_0829;
				}
				flag11 = false;
			}
		}
		flag13 = flag11;
		goto IL_0829;
		IL_07c7:
		flag9 = flag7;
		goto IL_07d4;
		IL_06f1:
		return result;
		IL_0829:
		GameObject go2 = mDrag.gameObject;
		Vector3 localPosition3 = cachedTransform.localPosition;
		float num20 = num17;
		if (!flag9)
		{
			num20 = 0f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		float num21 = 0f - num20;
		float num22 = num19;
		if (!flag13)
		{
			num22 = 0f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+84]");
		float num23 = 0f - num22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		float num24 = 0f - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		((Vector3*)(nint)vector)->x = 0f;
		SpringPanel springPanel = SpringPanel.Begin(go2, vector, 8f);
		SpringPanel.OnFinished onFinished = default;
		onFinished._002Ector(this, (nint)__ldftn(CenterOnChild.OnStringFinished));
		springPanel.onFinished = onFinished;
		GameObject gameObject3 = ((Component)obj4).gameObject;
		if (mSelectedObject == gameObject3)
		{
			GameObject gameObject4 = ((Component)obj4).gameObject;
			bool flag14 = mCenteredObject == gameObject4;
			result = true;
			if (!flag14)
			{
				goto IL_06f1;
			}
		}
		GameObject gameObject5 = ((Component)obj4).gameObject;
		mSelectedObject = gameObject5;
		result = false;
		goto IL_06f1;
	}

	public void CharacterFocusedFromClick()
	{
		characterWasClicked = false;
	}
}

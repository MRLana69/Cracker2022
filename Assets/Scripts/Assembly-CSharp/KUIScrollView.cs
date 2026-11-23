using System;
using Cpp2ILInjected;
using Kiloo.Common.UI;
using UnityEngine;

public class KUIScrollView : UIScrollView
{
	public ScrollView scrollView;

	public unsafe override Bounds bounds
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0068: Expected native int or pointer, but got VT
			//IL_004c: Expected VT, but got I
			//IL_0047: Expected native int or pointer, but got VT
			object obj2 = default;
			object obj = obj2 - 32;
			Bounds bounds2 = default;
			if (this.scrollView == null)
			{
				Bounds bounds = base.bounds;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				((Bounds*)(nint)bounds2)->m_Center = (Vector3)0;
			}
			else
			{
				ScrollView scrollView = this.scrollView;
				((Bounds*)(nint)bounds2)->m_Center = (Vector3)scrollView._mListViewBounds;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v7 (ScrollView)+64]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v7 (ScrollView)+5C]");
				_ = 0;
			}
			return bounds2;
		}
	}

	protected unsafe override bool shouldMove
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0282: Expected I, but got Obj
			//IL_0288: Unknown result type (might be due to invalid IL or missing references)
			//IL_028d: Expected Obj, but got Unknown
			//IL_0144: Expected Obj, but got I4
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Expected VT, but got Unknown
			//IL_0103: Expected Ref, but got VT
			//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ef: Expected VT, but got Unknown
			//IL_01f8: Expected Ref, but got VT
			//IL_00d0: Invalid comparison between VT and F4
			//IL_01c5: Invalid comparison between I and F4
			object obj2 = default;
			object obj = obj2 - 48;
			_ = 0;
			_ = 0;
			_ = 0;
			bool flag = (byte)(~(disableDragIfFits ? 1u : 0u)) != 0;
			bool result = true;
			bool flag3;
			bool flag5;
			if (!flag)
			{
				if (mPanel == null)
				{
					UIPanel component = GetComponent<UIPanel>();
					mPanel = component;
				}
				UIPanel uIPanel = mPanel;
				nint num = (nint)this;
				object obj3 = this + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v96 @ S2_v5 (Il2CppClass<KUIScrollView>)+DC] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				bool flag2 = movement == Movement.Horizontal;
				flag3 = true;
				if (!flag2)
				{
					if (movement != Movement.Vertical)
					{
						bool flag4 = movement == Movement.Unrestricted;
						flag3 = true;
						if (flag4)
						{
							goto IL_02de;
						}
						if (movement == Movement.Custom)
						{
							flag5 = customMovement != (Vector2)(object)0f;
							goto IL_02eb;
						}
					}
					flag3 = false;
				}
				goto IL_02de;
			}
			goto IL_0304;
			IL_02eb:
			if (flag5)
			{
				Bounds bounds = (Bounds)(obj + 24);
				Vector3 size = ((Bounds*)bounds)->size;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v26 (UIPanel)+D0]");
				bool flag6 = (nint)obj > 0;
				result = true;
				if (flag6)
				{
					goto IL_0304;
				}
			}
			object obj4 = movement - 1;
			bool flag7 = movement == Movement.Vertical;
			bool flag8 = true;
			bool flag10;
			if (!flag7)
			{
				bool flag9 = (nint)obj4 == 1;
				flag8 = true;
				if (!flag9)
				{
					if ((nint)obj4 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (KUIScrollView)+34]");
						flag10 = 0f != 0f;
						goto IL_0316;
					}
					flag8 = false;
				}
			}
			flag10 = flag8;
			goto IL_0316;
			IL_0316:
			if (flag10)
			{
				Bounds bounds2 = (Bounds)(obj + 24);
				Vector3 size2 = ((Bounds*)bounds2)->size;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v26 (UIPanel)+D4]");
				bool flag11 = num2 > 0;
				result = true;
				if (flag11)
				{
					goto IL_0304;
				}
			}
			result = false;
			goto IL_0304;
			IL_0304:
			return result;
			IL_02de:
			flag5 = flag3;
			goto IL_02eb;
		}
	}

	public unsafe override void MoveRelative(Vector3 relative)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0216: Expected native int or pointer, but got VT
		//IL_0228: Expected native int or pointer, but got VT
		//IL_0266: Invalid comparison between F4 and I
		//IL_011e: Invalid comparison between F4 and I
		//IL_017c: Expected F4, but got I
		//IL_019c: Expected native int or pointer, but got VT
		//IL_0293: Expected I, but got Obj
		//IL_02b1: Expected F4, but got VT
		//IL_02ac: Expected native int or pointer, but got VT
		//IL_02c6: Expected F4, but got I
		//IL_02c1: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		ScrollView scrollView = this.scrollView;
		if (~(scrollView.pullDownToRefreshList ? 1u : 0u) == 0)
		{
			Transform rootPanelTransform = scrollView.rootPanelTransform;
			Vector3 localPosition = rootPanelTransform.localPosition;
			Container firstVisibleContainerOnScreen = this.scrollView.GetFirstVisibleContainerOnScreen();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+14]");
			float num = 0f - firstVisibleContainerOnScreen.top;
			Transform rootPanelTransform2 = this.scrollView.rootPanelTransform;
			Vector3 localPosition2 = rootPanelTransform2.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+14]");
			float num2 = 0f + relative.y;
			bool flag = num2 > 0f;
			bool flag2 = !flag;
			float num3 = relative.y;
			if (!flag2)
			{
				ScrollView scrollView2 = this.scrollView;
				UIPanel rootPanel = this.scrollView.rootPanel;
				float scrollViewHeight = scrollView2.scrollViewHeight;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v38 (UIPanel)+D4]");
				bool flag3 = scrollViewHeight < 0f;
				bool flag4 = !flag3;
				num3 = relative.y;
				if (!flag4)
				{
					Transform rootPanelTransform3 = this.scrollView.rootPanelTransform;
					Vector3 localPosition3 = rootPanelTransform3.localPosition;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+14]");
					float num4 = Math.Abs(0f);
					num3 = (((Vector3*)(nint)relative)->y = relative.y - num4);
				}
			}
			ScrollView scrollView3 = this.scrollView;
			UIPanel rootPanel2 = this.scrollView.rootPanel;
			float scrollViewHeight2 = scrollView3.scrollViewHeight;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S1_v25 (UIPanel)+D4]");
			if (scrollViewHeight2 < 0f && !(num < 0f) && !(num3 < 0f))
			{
				nint num5 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S1_v31 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num6 = 0;
				((Vector3*)(nint)relative)->x = (float)Vector3.zeroVector;
				Vector3 vector2 = relative;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S1_v32 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
				((Vector3*)(nint)vector2)->z = 0f;
			}
		}
		((Vector3*)(nint)vector)->z = relative.z;
		((Vector3*)(nint)vector)->x = relative.x;
		base.MoveRelative(vector);
	}
}

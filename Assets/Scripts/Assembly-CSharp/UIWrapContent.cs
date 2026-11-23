using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class UIWrapContent : MonoBehaviour
{
	public delegate void OnInitializeItem(GameObject go, int wrapIndex, int realIndex);

	public int itemSize = 100;

	public bool cullContent = true;

	public int minIndex;

	public int maxIndex;

	public OnInitializeItem onInitializeItem;

	protected Transform mTrans;

	protected UIPanel mPanel;

	protected UIScrollView mScroll;

	protected bool mHorizontal;

	protected bool mFirstTime = true;

	protected List<Transform> mChildren;

	private static Comparison<Transform> _003C_003Ef__mg_0024cache0;

	private static Comparison<Transform> _003C_003Ef__mg_0024cache1;

	private static Comparison<Transform> _003C_003Ef__mg_0024cache2;

	protected virtual void Start()
	{
		//IL_004c: Expected I, but got Obj
		//IL_005b: Expected I, but got Obj
		//IL_0030: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<UIWrapContent>)+EC] (should have been resolved before IL gen)");
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v21 @ S1_v6 (Il2CppClass<UIWrapContent>)+104] (should have been resolved before IL gen)");
		if (mScroll != null)
		{
			UIPanel component = mScroll.GetComponent<UIPanel>();
			NullReferenceException ex = new NullReferenceException();
			UIPanel.OnClippingMoved onClippingMoved = default;
			onClippingMoved._002Ector(this, (IntPtr)ex);
			component.onClipMove = onClippingMoved;
		}
		mFirstTime = false;
	}

	protected virtual void OnMove(UIPanel panel)
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<UIWrapContent>)+104] (should have been resolved before IL gen)");
	}

	public virtual void SortBasedOnScrollMovement()
	{
		do
		{
			if (!CacheScrollView())
			{
				return;
			}
			((List<T>)(object)mChildren).Clear();
			int num = 0;
			while (true)
			{
				int childCount = mTrans.childCount;
				if (childCount <= num)
				{
					break;
				}
				Transform child = mTrans.GetChild(num);
				mChildren.Add(child);
				int num2 = num + 1;
				num = num2;
			}
		}
		while (!mHorizontal);
		throw new ArgumentException();
	}

	public virtual void SortAlphabetically()
	{
		if (!CacheScrollView())
		{
			return;
		}
		((List<T>)(object)mChildren).Clear();
		int num = 0;
		while (true)
		{
			int childCount = mTrans.childCount;
			if (num >= childCount)
			{
				break;
			}
			Transform child = mTrans.GetChild(num);
			mChildren.Add(child);
			int num2 = num + 1;
			num = num2;
		}
		throw new ArgumentException();
	}

	protected bool CacheScrollView()
	{
		Transform transform = base.transform;
		mTrans = transform;
		GameObject go = gameObject;
		UIPanel uIPanel = NGUITools.FindInParents<UIPanel>(go);
		mPanel = uIPanel;
		UIScrollView component = mPanel.GetComponent<UIScrollView>();
		mScroll = component;
		bool flag = mScroll != null;
		bool result = false;
		if (flag)
		{
			UIScrollView uIScrollView = mScroll;
			bool flag2 = uIScrollView.movement == UIScrollView.Movement.Horizontal;
			bool flag3 = true;
			if (!flag2)
			{
				if (uIScrollView.movement != UIScrollView.Movement.Vertical)
				{
					result = false;
					goto IL_00fc;
				}
				flag3 = false;
			}
			mHorizontal = flag3;
			result = true;
		}
		goto IL_00fc;
		IL_00fc:
		return result;
	}

	protected unsafe virtual void ResetChildPositions()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_006c: Expected Obj, but got I4
		//IL_00b2: Expected native int or pointer, but got VT
		//IL_00d6: Expected F4, but got I
		//IL_00d1: Expected native int or pointer, but got VT
		//IL_00e8: Expected I, but got Obj
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		List<Transform> list = mChildren;
		int num = default;
		int num6 = default;
		while (num < list._size)
		{
			Transform transform = mChildren.get_Item(num);
			if (~(mHorizontal ? 1u : 0u) == 0)
			{
				float num2 = (float)num * (float)itemSize;
				float num3 = 0f;
			}
			else
			{
				object obj2 = -num;
				float num4 = (float)itemSize * (float)obj2;
				float num3 = num4;
				float num2 = 0f;
			}
			_ = 0;
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			transform.localPosition = vector;
			nint num5 = (nint)this;
			object obj3 = this + 80;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v107 @ S3_v3 (Il2CppClass<UIWrapContent>)+10C] (should have been resolved before IL gen)");
			num = num6 + 1;
		}
	}

	public virtual void WrapContent()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0f9e: Expected Obj, but got I4
		//IL_0fc0: Expected I, but got Obj
		//IL_0fc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fce: Expected Obj, but got Unknown
		//IL_0175: Expected Obj, but got I
		//IL_01b9: Expected Obj, but got I
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_0889: Expected Obj, but got I
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_0897: Expected Obj, but got Unknown
		//IL_08ae: Expected Obj, but got I
		//IL_08d2: Expected Obj, but got I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected VT, but got Unknown
		//IL_00d4: Expected Obj, but got I
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_011f: Expected Obj, but got I
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected Obj, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected Obj, but got Unknown
		//IL_0266: Expected Obj, but got I4
		//IL_1115: Unknown result type (might be due to invalid IL or missing references)
		//IL_111a: Expected Obj, but got Unknown
		//IL_1123: Unknown result type (might be due to invalid IL or missing references)
		//IL_1128: Expected I4, but got Unknown
		//IL_0ddc: Expected I, but got Obj
		//IL_0de2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de7: Expected Obj, but got Unknown
		//IL_09d5: Expected F8, but got I4
		//IL_06ee: Expected I, but got Obj
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Expected Obj, but got Unknown
		//IL_0bf6: Expected F8, but got I4
		//IL_0369: Expected F8, but got I4
		//IL_0eb1: Expected F4, but got I
		//IL_0ae6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aeb: Expected Obj, but got Unknown
		//IL_0b17: Expected Obj, but got I
		//IL_0b2f: Expected F4, but got I
		//IL_054d: Expected F8, but got I4
		//IL_0d18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1d: Expected Obj, but got Unknown
		//IL_0d49: Expected Obj, but got I
		//IL_0d61: Expected F4, but got I
		//IL_119b: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a0: Expected VT, but got Unknown
		//IL_09e4: Invalid comparison between F8 and I4
		//IL_0a16: Expected Obj, but got I
		//IL_0a2e: Expected F4, but got I
		//IL_07b5: Expected F4, but got VT
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected Obj, but got Unknown
		//IL_0496: Expected Obj, but got I
		//IL_0c05: Invalid comparison between F8 and I4
		//IL_0c37: Expected Obj, but got I
		//IL_0c4f: Expected F4, but got I
		//IL_0ceb: Expected Obj, but got I4
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Expected Obj, but got Unknown
		//IL_068b: Expected Obj, but got I
		//IL_106a: Unknown result type (might be due to invalid IL or missing references)
		//IL_106f: Expected VT, but got Unknown
		//IL_0378: Invalid comparison between F8 and I4
		//IL_03c2: Expected Obj, but got I
		//IL_0ed9: Invalid comparison between F4 and Obj
		//IL_0ee7: Invalid comparison between F4 and Obj
		//IL_0f1c: Expected F4, but got I
		//IL_0a56: Invalid comparison between F8 and I4
		//IL_0a88: Expected Obj, but got I
		//IL_0aa0: Expected F4, but got I
		//IL_055c: Invalid comparison between F8 and I4
		//IL_05a6: Expected Obj, but got I
		//IL_0622: Expected Obj, but got I4
		//IL_0c77: Invalid comparison between F8 and I4
		//IL_0cac: Expected Obj, but got I
		//IL_0cc4: Expected F4, but got I
		//IL_07dd: Invalid comparison between F4 and Obj
		//IL_07eb: Invalid comparison between F4 and Obj
		//IL_081d: Expected F4, but got VT
		//IL_03da: Invalid comparison between F8 and I4
		//IL_0424: Expected Obj, but got I
		//IL_05be: Invalid comparison between F8 and I4
		//IL_060b: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 176;
		_ = 0;
		_ = 0;
		List<Transform> list = mChildren;
		object obj3 = itemSize * list._size;
		float num = (float)obj3 * 0.5f;
		UIPanel uIPanel = mPanel;
		nint num2 = (nint)uIPanel;
		object obj4 = uIPanel + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S1_v10 (Il2CppClass<UIPanel>)+10C] (should have been resolved before IL gen)");
		object obj5 = default;
		object obj7 = default;
		object obj9 = default;
		object obj12 = default;
		while ((nint)obj5 < 4)
		{
			object obj6 = obj7 * 12;
			object obj8 = obj9 + obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v281+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v281+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
			_ = 0;
			Vector3 position = (Vector3)(obj + 16);
			Vector3 vector = mTrans.InverseTransformPoint(position);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
			obj = 0;
			object obj10 = obj7 * 12;
			object obj11 = obj9 + obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			obj5 = obj7 + 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
			obj12 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v17+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v17+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v17+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v17+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
		object obj13 = num3 - 0;
		float num4 = (float)obj13 * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
		float num5 = 0f + num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+84]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
		object obj14 = num6 - 0;
		float num7 = (float)obj14 * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
		float num8 = 0f + num7;
		float num9 = num + num;
		object obj15 = obj9 + 16;
		object obj19;
		int num27 = default;
		int num28 = default;
		double num29 = default;
		float num30 = default;
		if (~(mHorizontal ? 1u : 0u) == 0)
		{
			object obj16 = obj15 - itemSize;
			object obj17 = obj9 + 40;
			object obj18 = obj17 + itemSize;
			List<Transform> list2 = mChildren;
			float num10 = num8;
			int num11 = 0;
			obj19 = 1;
			double num18 = default;
			double num35 = default;
			while (num11 < list2._size)
			{
				Transform transform = mChildren.get_Item(num11);
				Vector3 localPosition = transform.localPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
				float num12 = 0f - num5;
				float num13 = 0f - num;
				float num14;
				float num15;
				float num16;
				int num20;
				int num21;
				double num22;
				float num23;
				float num24;
				float num25;
				object obj20;
				float num26;
				float num31;
				float num32;
				float num33;
				if (num12 < num13)
				{
					Vector3 localPosition2 = transform.localPosition;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
					num14 = 0f + num9;
					num15 = num14 - num5;
					num16 = num14 / (float)itemSize;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
					double num17 = Math.Abs(num18);
					double num19 = ((!(num17 < 2147483648.0)) ? (-2147483648.0) : num18);
					if (minIndex == maxIndex)
					{
						goto IL_0432;
					}
					bool flag = num19 < (double)minIndex;
					num20 = maxIndex;
					num21 = minIndex;
					num22 = num18;
					num23 = num16;
					num24 = num14;
					num25 = num15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
					obj20 = 0;
					if (!flag)
					{
						bool flag2 = num19 > (double)maxIndex;
						num20 = maxIndex;
						num21 = minIndex;
						num22 = num18;
						num23 = num16;
						num24 = num14;
						num25 = num15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
						obj20 = 0;
						if (!flag2)
						{
							goto IL_0432;
						}
					}
				}
				else
				{
					if (!(num12 > num))
					{
						bool flag3 = (byte)(~(mFirstTime ? 1u : 0u)) != 0;
						num26 = num12;
						num20 = num27;
						num21 = num28;
						num22 = num29;
						num23 = num30;
						num24 = num10;
						num25 = num12;
						obj20 = obj12;
						if (!flag3)
						{
							goto IL_06e9;
						}
						goto IL_10bd;
					}
					Vector3 localPosition3 = transform.localPosition;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
					num31 = 0f - num9;
					num32 = num31 - num5;
					num33 = num31 / (float)itemSize;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
					double num34 = Math.Abs(num35);
					double num36 = ((!(num34 < 2147483648.0)) ? (-2147483648.0) : num35);
					if (minIndex == maxIndex)
					{
						goto IL_0627;
					}
					bool flag4 = num36 < (double)minIndex;
					num20 = maxIndex;
					num21 = minIndex;
					num22 = num35;
					num23 = num33;
					num24 = num31;
					num25 = num32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
					obj20 = 0;
					if (!flag4)
					{
						bool flag5 = !(num36 > (double)maxIndex);
						num20 = maxIndex;
						num21 = minIndex;
						num22 = num35;
						num23 = num33;
						num24 = num31;
						num25 = num32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
						obj20 = 0;
						if (flag5)
						{
							goto IL_0627;
						}
					}
				}
				obj19 = 0;
				goto IL_10bd;
				IL_0627:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
				_ = 0;
				object obj21 = obj + 96;
				num27 = maxIndex;
				num28 = minIndex;
				num29 = num35;
				num30 = num33;
				num10 = num31;
				num26 = num32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
				obj12 = 0;
				goto IL_104f;
				IL_0432:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
				_ = 0;
				obj21 = obj + 112;
				num27 = maxIndex;
				num28 = minIndex;
				num29 = num18;
				num30 = num16;
				num10 = num14;
				num26 = num15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
				obj12 = 0;
				goto IL_104f;
				IL_104f:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v875 @ S1_v193+8]");
				_ = 0;
				Vector3 localPosition4 = (Vector3)(obj + 48);
				transform.localPosition = localPosition4;
				goto IL_06e9;
				IL_06e9:
				nint num37 = (nint)this;
				object obj22 = this + 80;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v541 @ S3_v31 (Il2CppClass<UIWrapContent>)+10C] (should have been resolved before IL gen)");
				num20 = num27;
				num21 = num28;
				num22 = num29;
				num23 = num30;
				num24 = num10;
				num25 = num26;
				obj20 = obj12;
				goto IL_10bd;
				IL_10bd:
				if (~(cullContent ? 1u : 0u) == 0)
				{
					UIPanel uIPanel2 = mPanel;
					Vector3 localPosition5 = mTrans.localPosition;
					float num38 = (float)uIPanel2.mClipOffset;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
					float num39 = num38 - 0f;
					float num40 = num25 + num39;
					GameObject go = transform.gameObject;
					bool flag6 = UICamera.IsPressed(go);
					num24 = (float)uIPanel2.mClipOffset;
					if (!flag6)
					{
						GameObject go2 = transform.gameObject;
						bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num40) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18);
						bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num40) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16);
						bool state = flag7 & flag8;
						NGUITools.SetActive(go2, state, compatibilityMode: false);
						num24 = (float)uIPanel2.mClipOffset;
					}
				}
				int num41 = num11 + 1;
				num27 = num20;
				num28 = num21;
				num29 = num22;
				num30 = num23;
				num10 = num24;
				num11 = num41;
				obj12 = obj20;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v37+4]");
			object obj23 = -itemSize;
			object obj24 = obj9 + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v49+4]");
			object obj25 = (nint)0 + (nint)itemSize;
			List<Transform> list3 = mChildren;
			float num42 = num5;
			int num43 = 0;
			obj19 = 1;
			double num50 = default;
			float num60 = default;
			object obj27 = default;
			double num65 = default;
			while (num43 < list3._size)
			{
				Transform transform2 = mChildren.get_Item(num43);
				Vector3 localPosition6 = transform2.localPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
				float num44 = 0f - num8;
				float num45 = 0f - num;
				float num46;
				float num47;
				float num48;
				int num52;
				int num53;
				float num54;
				object obj26;
				double num55;
				float num56;
				float num57;
				float num58;
				float num59;
				float num61;
				float num62;
				float num63;
				if (num44 < num45)
				{
					Vector3 localPosition7 = transform2.localPosition;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
					num46 = 0f + num9;
					num47 = num46 - num8;
					num48 = num46 / (float)itemSize;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
					double num49 = Math.Abs(num50);
					double num51 = ((!(num49 < 2147483648.0)) ? (-2147483648.0) : num50);
					if (minIndex == maxIndex)
					{
						goto IL_0abe;
					}
					bool flag9 = num51 < (double)minIndex;
					num52 = maxIndex;
					num53 = minIndex;
					num54 = num48;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
					obj26 = 0;
					num55 = num50;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
					num56 = 0f;
					num57 = num46;
					num58 = num47;
					if (!flag9)
					{
						bool flag10 = num51 > (double)maxIndex;
						num52 = maxIndex;
						num53 = minIndex;
						num54 = num48;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
						obj26 = 0;
						num55 = num50;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
						num56 = 0f;
						num57 = num46;
						num58 = num47;
						if (!flag10)
						{
							goto IL_0abe;
						}
					}
				}
				else
				{
					if (!(num44 > num))
					{
						bool flag11 = (byte)(~(mFirstTime ? 1u : 0u)) != 0;
						num59 = num44;
						num52 = num27;
						num53 = num28;
						num54 = num60;
						obj26 = obj27;
						num55 = num29;
						num56 = num30;
						num57 = num42;
						num58 = num44;
						if (!flag11)
						{
							goto IL_0dd7;
						}
						goto IL_11ee;
					}
					Vector3 localPosition8 = transform2.localPosition;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
					num61 = 0f - num9;
					num62 = num61 - num8;
					num63 = num61 / (float)itemSize;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
					double num64 = Math.Abs(num65);
					double num66 = ((!(num64 < 2147483648.0)) ? (-2147483648.0) : num65);
					if (minIndex == maxIndex)
					{
						goto IL_0cf0;
					}
					bool flag12 = num66 < (double)minIndex;
					num52 = maxIndex;
					num53 = minIndex;
					num54 = num63;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
					obj26 = 0;
					num55 = num65;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
					num56 = 0f;
					num57 = num61;
					num58 = num62;
					if (!flag12)
					{
						bool flag13 = !(num66 > (double)maxIndex);
						num52 = maxIndex;
						num53 = minIndex;
						num54 = num63;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
						obj26 = 0;
						num55 = num65;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
						num56 = 0f;
						num57 = num61;
						num58 = num62;
						if (flag13)
						{
							goto IL_0cf0;
						}
					}
				}
				obj19 = 0;
				goto IL_11ee;
				IL_0cf0:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
				_ = 0;
				object obj28 = obj - -64;
				num27 = maxIndex;
				num28 = minIndex;
				num60 = num63;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
				obj27 = 0;
				num29 = num65;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
				num30 = 0f;
				num42 = num61;
				num59 = num62;
				goto IL_1180;
				IL_0abe:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
				_ = 0;
				obj28 = obj + 80;
				num27 = maxIndex;
				num28 = minIndex;
				num60 = num48;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
				obj27 = 0;
				num29 = num50;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
				num30 = 0f;
				num42 = num46;
				num59 = num47;
				goto IL_1180;
				IL_1180:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ S1_v71+8]");
				_ = 0;
				Vector3 localPosition9 = (Vector3)(obj + 32);
				transform2.localPosition = localPosition9;
				goto IL_0dd7;
				IL_0dd7:
				nint num67 = (nint)this;
				object obj29 = this + 80;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v638 @ S3_v14 (Il2CppClass<UIWrapContent>)+10C] (should have been resolved before IL gen)");
				num52 = num27;
				num53 = num28;
				num54 = num60;
				obj26 = obj27;
				num55 = num29;
				num56 = num30;
				num57 = num42;
				num58 = num59;
				goto IL_11ee;
				IL_11ee:
				if (~(cullContent ? 1u : 0u) == 0)
				{
					UIPanel uIPanel3 = mPanel;
					Vector3 localPosition10 = mTrans.localPosition;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ S0_v73 (UIPanel)+F0]");
					float num68 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
					float num69 = num68 - 0f;
					float num70 = num58 + num69;
					GameObject go3 = transform2.gameObject;
					bool flag14 = UICamera.IsPressed(go3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ S0_v73 (UIPanel)+F0]");
					num57 = 0f;
					if (!flag14)
					{
						GameObject go4 = transform2.gameObject;
						bool flag15 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num70) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25);
						bool flag16 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num70) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23);
						bool state2 = flag15 & flag16;
						NGUITools.SetActive(go4, state2, compatibilityMode: false);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ S0_v73 (UIPanel)+F0]");
						num57 = 0f;
					}
				}
				int num71 = num43 + 1;
				num27 = num52;
				num28 = num53;
				num60 = num54;
				obj27 = obj26;
				num29 = num55;
				num30 = num56;
				num42 = num57;
				num43 = num71;
			}
		}
		UIScrollView uIScrollView = mScroll;
		object obj30 = obj19 ^ -1;
		bool restrictWithinPanel = (byte)(obj30 & 1) != 0;
		uIScrollView.restrictWithinPanel = restrictWithinPanel;
	}

	private void OnValidate()
	{
		if (minIndex > maxIndex)
		{
			maxIndex = minIndex;
		}
	}

	protected virtual void UpdateItem(Transform item, int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected I4, but got Unknown
		//IL_015b: Expected F8, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		if (this.onInitializeItem == null)
		{
			return;
		}
		UIScrollView uIScrollView = mScroll;
		int num2;
		int num3;
		if (uIScrollView.movement == UIScrollView.Movement.Vertical)
		{
			Vector3 localPosition = item.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			int num = (int)((nint)0 / (nint)itemSize);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [53458A]");
			bool flag = (nint)0 == 0;
			num2 = num;
			if (flag)
			{
				goto IL_0104;
			}
			num3 = num;
		}
		else
		{
			Vector3 localPosition2 = item.localPosition;
			int num4 = obj / itemSize;
			num2 = num4;
			num3 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [53458A]");
			if ((nint)0 == 0)
			{
				goto IL_0104;
			}
		}
		goto IL_0161;
		IL_0104:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_codegen_initialize_runtime_metadata\"");
		_ = 1;
		num3 = num2;
		goto IL_0161;
		IL_0161:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double value = default;
		double num5 = Math.Abs(value);
		if (!(num5 < 2147483648.0))
		{
			value = -2147483648.0;
		}
		OnInitializeItem onInitializeItem = this.onInitializeItem;
		GameObject gameObject = item.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v103.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
	}

	public UIWrapContent()
	{
		List<Transform> list = default;
		list._002Ector();
		mChildren = list;
		base._002Ector();
	}
}

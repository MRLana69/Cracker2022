using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class UICenterOnChild : MonoBehaviour
{
	public delegate void OnCenterCallback(GameObject centeredObject);

	public float springStrength = 8f;

	public float nextPageThreshold;

	public SpringPanel.OnFinished onFinished;

	public OnCenterCallback onCenter;

	private UIScrollView mScrollView;

	private GameObject mCenteredObject;

	public GameObject centeredObject => mCenteredObject;

	private void Start()
	{
		Recenter();
	}

	private void OnEnable()
	{
		if ((bool)mScrollView)
		{
			UIScrollView uIScrollView = mScrollView;
			uIScrollView.centerOnChild = this;
			Recenter();
		}
	}

	private void OnDisable()
	{
		if ((bool)mScrollView)
		{
			UIScrollView uIScrollView = mScrollView;
			uIScrollView.centerOnChild = null;
		}
	}

	private void OnDragFinished()
	{
		if (enabled)
		{
			Recenter();
		}
	}

	private void OnValidate()
	{
		float num = Math.Abs(nextPageThreshold);
		nextPageThreshold = num;
	}

	public unsafe void Recenter()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_02f0: Expected I, but got Obj
		//IL_034b: Expected Obj, but got I
		//IL_0378: Expected Obj, but got I
		//IL_03a5: Expected Obj, but got I
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected Ref, but got Unknown
		//IL_0e4c: Expected Obj, but got I4
		//IL_0514: Expected Obj, but got I4
		//IL_0f0f: Expected F4, but got I
		//IL_0f0a: Expected native int or pointer, but got VT
		//IL_0f2e: Expected F4, but got I
		//IL_0f29: Expected native int or pointer, but got VT
		//IL_0ee3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee8: Expected Obj, but got Unknown
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb2: Expected Obj, but got Unknown
		//IL_08ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ef: Expected VT, but got Unknown
		//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fd: Expected VT, but got Unknown
		//IL_0941: Expected F4, but got I
		//IL_0986: Expected F4, but got I
		//IL_0fe1: Expected Obj, but got I
		//IL_0d1d: Expected Obj, but got I4
		//IL_0c24: Expected Obj, but got I4
		//IL_0aff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b04: Expected I4, but got Unknown
		//IL_0d4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d52: Expected I4, but got Unknown
		//IL_0a15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1a: Expected I4, but got Unknown
		//IL_0c54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c59: Expected I4, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 160);
		_ = 0;
		_ = 0;
		if (mScrollView == null)
		{
			GameObject go = base.gameObject;
			UIScrollView uIScrollView = NGUITools.FindInParents<UIScrollView>(go);
			mScrollView = uIScrollView;
			if (mScrollView == null)
			{
				enabled = false;
				return;
			}
			if ((bool)mScrollView)
			{
				UIScrollView uIScrollView2 = mScrollView;
				uIScrollView2.centerOnChild = this;
				UIScrollView uIScrollView3 = mScrollView;
				UIScrollView.OnDragNotification onDragNotification = default;
				onDragNotification._002Ector(this, (nint)__ldftn(UICenterOnChild.OnDragFinished));
				Delegate obj2 = Delegate.Combine(uIScrollView3.onDragFinished, onDragNotification);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				UIScrollView.OnDragNotification onDragFinished = default;
				uIScrollView3.onDragFinished = onDragFinished;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			}
			UIScrollView uIScrollView4 = mScrollView;
			if (uIScrollView4.horizontalScrollBar != null)
			{
				UIScrollView uIScrollView5 = mScrollView;
				UIProgressBar horizontalScrollBar = uIScrollView5.horizontalScrollBar;
				UIProgressBar.OnDragFinished onDragFinished2 = default;
				onDragFinished2._002Ector(this, (nint)__ldftn(UICenterOnChild.OnDragFinished));
				Delegate obj3 = Delegate.Combine(horizontalScrollBar.onDragFinished, onDragFinished2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				UIProgressBar.OnDragFinished onDragFinished3 = default;
				horizontalScrollBar.onDragFinished = onDragFinished3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			}
			UIScrollView uIScrollView6 = mScrollView;
			if (uIScrollView6.verticalScrollBar != null)
			{
				UIScrollView uIScrollView7 = mScrollView;
				UIProgressBar verticalScrollBar = uIScrollView7.verticalScrollBar;
				UIProgressBar.OnDragFinished onDragFinished4 = default;
				onDragFinished4._002Ector(this, (nint)__ldftn(UICenterOnChild.OnDragFinished));
				Delegate obj4 = Delegate.Combine(verticalScrollBar.onDragFinished, onDragFinished4);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				UIProgressBar.OnDragFinished onDragFinished5 = default;
				verticalScrollBar.onDragFinished = onDragFinished5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			}
		}
		UIScrollView uIScrollView8 = mScrollView;
		if (!(uIScrollView8.mPanel != null))
		{
			return;
		}
		Transform transform = base.transform;
		if (transform.childCount == 0)
		{
			return;
		}
		UIScrollView uIScrollView9 = mScrollView;
		UIPanel mPanel = uIScrollView9.mPanel;
		nint num = (nint)mPanel;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v190 @ S2_v6 (Il2CppClass<UIPanel>)+10C] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v15+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v15+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v15+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v15+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		object obj5 = num2 + 0;
		float num3 = (float)obj5 * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+84]");
		object obj6 = num4 + 0;
		float num5 = (float)obj6 * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		object obj7 = num6 + 0;
		float num7 = (float)obj7 * 0.5f;
		UIScrollView uIScrollView10 = mScrollView;
		float num8 = (float)uIScrollView10.mMomentum * uIScrollView10.momentumAmount;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v48 (UIScrollView)+90]");
		float num9 = 0f * uIScrollView10.momentumAmount;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v48 (UIScrollView)+94]");
		float num10 = 0f * uIScrollView10.momentumAmount;
		Vector3 vector2 = NGUIMath.SpringDampen(ref *(Vector3*)(vector + 144), 9f, 2f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		float num11 = 0f * 0.01f;
		float num12 = num3 - num11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+74]");
		float num13 = 0f * 0.01f;
		float num14 = num5 - num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		float num15 = 0f * 0.01f;
		float num16 = num7 - num15;
		UIGrid component = GetComponent<UIGrid>();
		object obj8;
		Transform target;
		List<Transform> list;
		int index = default;
		object obj9 = default;
		if (component != null)
		{
			List<Transform> childList = component.GetChildList();
			float num17 = float.MaxValue;
			obj8 = 0;
			int num18 = 0;
			target = null;
			while (true)
			{
				bool flag = num18 >= childList._size;
				list = childList;
				if (flag)
				{
					break;
				}
				Transform transform2 = childList.get_Item(num18);
				GameObject gameObject = transform2.gameObject;
				if (gameObject.activeInHierarchy)
				{
					vector2 = transform2.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
					float num19 = 0f - num12;
					float num20 = num19 * num19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
					float num21 = 0f - num14;
					float num22 = num21 * num21;
					float num23 = num20 + num22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
					float num24 = 0f - num16;
					float num25 = num24 * num24;
					float num26 = num23 + num25;
					if (num17 > num26)
					{
						index = num18;
						num17 = num26;
						obj8 = obj9;
						target = transform2;
					}
					object obj10 = obj9 + 1;
					obj9 = obj10;
				}
				int num27 = num18 + 1;
				num18 = num27;
			}
		}
		else
		{
			int childCount = transform.childCount;
			float num28 = float.MaxValue;
			obj8 = 0;
			int num29 = 0;
			target = null;
			while (num29 < childCount)
			{
				Transform child = transform.GetChild(num29);
				GameObject gameObject2 = child.gameObject;
				if (gameObject2.activeInHierarchy)
				{
					vector2 = child.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
					float num30 = 0f - num12;
					float num31 = num30 * num30;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
					float num32 = 0f - num14;
					float num33 = num32 * num32;
					float num34 = num31 + num33;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
					float num35 = 0f - num16;
					float num36 = num35 * num35;
					float num37 = num34 + num36;
					if (num28 > num37)
					{
						index = num29;
						num28 = num37;
						obj8 = obj9;
						target = child;
					}
					object obj11 = obj9 + 1;
					obj9 = obj11;
				}
				int num38 = num29 + 1;
				num29 = num38;
			}
			list = null;
		}
		if (nextPageThreshold > 0f && UICamera.currentTouch != null && mCenteredObject != null)
		{
			Transform transform3 = mCenteredObject.transform;
			Transform transform4 = ((list == null) ? transform.GetChild(index) : list.get_Item(index));
			if (transform3 == transform4)
			{
				UICamera.MouseOrTouch currentTouch = UICamera.currentTouch;
				Transform transform5 = base.transform;
				Quaternion rotation = transform5.rotation;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
				_ = 0;
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
				_ = 0;
				_ = currentTouch.totalDelta;
				_ = currentTouch.totalDelta;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
				_ = 0;
				Quaternion quaternion = (Quaternion)(vector + 32);
				Vector3 vector3 = vector + 16;
				Vector3 vector4 = quaternion * vector3;
				UIScrollView uIScrollView11 = mScrollView;
				bool flag2 = uIScrollView11.movement == UIScrollView.Movement.Horizontal;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
				float num39 = 0f;
				if (!flag2)
				{
					if (uIScrollView11.movement == UIScrollView.Movement.Vertical)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
						num39 = 0f;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
						float num40 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
						float num41 = num40 * 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
						float num42 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
						float num43 = num42 * 0f;
						float num44 = num41 + num43;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
						nint num45 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
						object obj12 = num45 * 0;
						float num46 = num44 + (float)obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
						num39 = num46;
					}
				}
				float num47 = Math.Abs(num39);
				if (nextPageThreshold < num47)
				{
					if (nextPageThreshold < num39)
					{
						if (list == null)
						{
							if ((nint)obj8 >= 1)
							{
								int index2 = obj8 - 1;
								Transform child2 = transform.GetChild(index2);
								target = child2;
							}
							else
							{
								UIWrapContent component2 = GetComponent<UIWrapContent>();
								if (component2 == null)
								{
									Transform child3 = transform.GetChild(0);
									target = child3;
								}
								else
								{
									int childCount2 = transform.childCount;
									int index3 = childCount2 - 1;
									Transform child4 = transform.GetChild(index3);
									target = child4;
								}
							}
						}
						else if ((nint)obj8 >= 1)
						{
							int index4 = obj8 - 1;
							Transform transform6 = list.get_Item(index4);
							target = transform6;
						}
						else
						{
							UIWrapContent component3 = GetComponent<UIWrapContent>();
							if (component3 == null)
							{
								Transform transform7 = list.get_Item(0);
								target = transform7;
							}
							else
							{
								int index5 = list._size - 1;
								Transform transform8 = list.get_Item(index5);
								target = transform8;
							}
						}
					}
					else
					{
						float num48 = 0f - nextPageThreshold;
						if (num39 < num48)
						{
							if (list == null)
							{
								int childCount3 = transform.childCount;
								object obj13 = childCount3 - 1;
								if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13))
								{
									int index6 = obj8 + 1;
									Transform child5 = transform.GetChild(index6);
									target = child5;
								}
								else
								{
									UIWrapContent component4 = GetComponent<UIWrapContent>();
									if (component4 == null)
									{
										int childCount4 = transform.childCount;
										int index7 = childCount4 - 1;
										Transform child6 = transform.GetChild(index7);
										target = child6;
									}
									else
									{
										Transform child7 = transform.GetChild(0);
										target = child7;
									}
								}
							}
							else
							{
								object obj14 = list._size - 1;
								if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14))
								{
									int index8 = obj8 + 1;
									Transform transform9 = list.get_Item(index8);
									target = transform9;
								}
								else
								{
									UIWrapContent component5 = GetComponent<UIWrapContent>();
									if (component5 == null)
									{
										int index9 = list._size - 1;
										Transform transform10 = list.get_Item(index9);
										target = transform10;
									}
									else
									{
										Transform transform11 = list.get_Item(0);
										target = transform11;
									}
								}
							}
						}
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		((Vector3*)(nint)vector)->x = 0f;
		CenterOn(target, vector);
	}

	private unsafe void CenterOn(Transform target, Vector3 panelCenter)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected VT, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected VT, but got Unknown
		//IL_035a: Expected Obj, but got I4
		//IL_0470: Expected F4, but got I
		//IL_046b: Expected native int or pointer, but got VT
		//IL_048f: Expected F4, but got I
		//IL_048a: Expected native int or pointer, but got VT
		//IL_02b6: Invalid comparison between I and F4
		//IL_0241: Invalid comparison between VT and F4
		object obj = default;
		Vector3 vector = (Vector3)(obj - 96);
		Transform cachedTransform;
		float num2;
		float num4;
		bool flag2;
		bool flag4;
		if (target != null && mScrollView != null)
		{
			UIScrollView uIScrollView = mScrollView;
			if (uIScrollView.mPanel != null)
			{
				UIScrollView uIScrollView2 = mScrollView;
				cachedTransform = uIScrollView2.mPanel.cachedTransform;
				GameObject gameObject = target.gameObject;
				mCenteredObject = gameObject;
				Vector3 position = target.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
				_ = 0;
				Vector3 position2 = vector + 32;
				Vector3 vector2 = cachedTransform.InverseTransformPoint(position2);
				_ = panelCenter.z;
				_ = panelCenter.x;
				Vector3 position3 = vector + 16;
				Vector3 vector3 = cachedTransform.InverseTransformPoint(position3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
				float num = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
				num2 = num - 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
				float num3 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
				num4 = num3 - 0f;
				UIScrollView uIScrollView3 = mScrollView;
				bool flag = uIScrollView3.movement == UIScrollView.Movement.Horizontal;
				flag2 = true;
				if (!flag)
				{
					if (uIScrollView3.movement != UIScrollView.Movement.Vertical)
					{
						bool flag3 = uIScrollView3.movement == UIScrollView.Movement.Unrestricted;
						flag2 = true;
						if (flag3)
						{
							goto IL_0330;
						}
						if (uIScrollView3.movement == UIScrollView.Movement.Custom)
						{
							flag4 = uIScrollView3.customMovement != (Vector2)(object)0f;
							goto IL_033d;
						}
					}
					flag2 = false;
				}
				goto IL_0330;
			}
		}
		mCenteredObject = null;
		goto IL_03fe;
		IL_033d:
		UIScrollView uIScrollView4 = mScrollView;
		object obj2 = uIScrollView4.movement - 1;
		bool flag5 = uIScrollView4.movement == UIScrollView.Movement.Vertical;
		bool flag6 = true;
		bool flag8;
		if (!flag5)
		{
			bool flag7 = (nint)obj2 == 1;
			flag6 = true;
			if (!flag7)
			{
				if ((nint)obj2 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v73 (UIScrollView)+34]");
					flag8 = 0f != 0f;
					goto IL_0392;
				}
				flag6 = false;
			}
		}
		flag8 = flag6;
		goto IL_0392;
		IL_0392:
		UIScrollView uIScrollView5 = mScrollView;
		GameObject cachedGameObject = uIScrollView5.mPanel.cachedGameObject;
		Vector3 localPosition = cachedTransform.localPosition;
		float num5 = num2;
		if (!flag4)
		{
			num5 = 0f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		float num6 = 0f - num5;
		float num7 = num4;
		if (!flag8)
		{
			num7 = 0f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
		float num8 = 0f - num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		float num9 = 0f - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		((Vector3*)(nint)vector)->x = 0f;
		SpringPanel springPanel = SpringPanel.Begin(cachedGameObject, vector, springStrength);
		springPanel.onFinished = onFinished;
		goto IL_03fe;
		IL_0330:
		flag4 = flag2;
		goto IL_033d;
		IL_03fe:
		OnCenterCallback onCenterCallback = onCenter;
		if (onCenter != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v82.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public unsafe void CenterOn(Transform target)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_006d: Expected I, but got Obj
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_00d6: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I
		//IL_0130: Expected Obj, but got I
		//IL_015a: Expected F4, but got I
		//IL_0155: Expected native int or pointer, but got VT
		//IL_0179: Expected F4, but got I
		//IL_0174: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj + -64);
		if (mScrollView != null)
		{
			UIScrollView uIScrollView = mScrollView;
			if (uIScrollView.mPanel != null)
			{
				UIScrollView uIScrollView2 = mScrollView;
				UIPanel mPanel = uIScrollView2.mPanel;
				nint num = (nint)mPanel;
				object obj2 = mPanel + 80;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v67 @ S2_v5 (Il2CppClass<UIPanel>)+10C] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v10+30]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v10+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v10+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v10+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				object obj3 = num2 + 0;
				float num3 = (float)obj3 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+34]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				object obj4 = num4 + 0;
				float num5 = (float)obj4 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				object obj5 = num6 + 0;
				float num7 = (float)obj5 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
				((Vector3*)(nint)vector)->x = 0f;
				CenterOn(target, vector);
			}
		}
	}
}

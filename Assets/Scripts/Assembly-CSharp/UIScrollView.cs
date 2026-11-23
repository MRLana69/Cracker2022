using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class UIScrollView : MonoBehaviour
{
	public enum Movement
	{
		Horizontal,
		Vertical,
		Unrestricted,
		Custom
	}

	public enum DragEffect
	{
		None,
		Momentum,
		MomentumAndSpring
	}

	public enum ShowCondition
	{
		Always,
		OnlyIfNeeded,
		WhenDragging
	}

	public delegate void OnDragNotification();

	public static BetterList<UIScrollView> list;

	public Movement movement;

	public DragEffect dragEffect = DragEffect.MomentumAndSpring;

	public bool restrictWithinPanel = true;

	public bool disableDragIfFits;

	public bool smoothDragStart = true;

	public bool iOSDragEmulation;

	public float scrollWheelFactor = 0.25f;

	public float momentumAmount;

	public float dampenStrength = 9f;

	public UIProgressBar horizontalScrollBar;

	public UIProgressBar verticalScrollBar;

	public ShowCondition showScrollBars = ShowCondition.OnlyIfNeeded;

	public Vector2 customMovement;

	public UIWidget.Pivot contentPivot;

	public OnDragNotification onDragStarted;

	public OnDragNotification onDragFinished;

	public OnDragNotification onMomentumMove;

	public OnDragNotification onStoppedMoving;

	public Scrollbar scrollbar;

	private Vector3 scale = (Vector3)1065353216;

	private Vector2 relativePositionOnReset;

	protected Transform mTrans;

	protected UIPanel mPanel;

	protected Plane mPlane;

	protected Vector3 mLastPos;

	protected bool mPressed;

	protected Vector3 mMomentum;

	protected float mScroll;

	protected Bounds mBounds;

	protected bool mCalculatedBounds;

	protected bool mShouldMove;

	protected bool mIgnoreCallbacks;

	protected int mDragID;

	protected Vector2 mDragStartOffset;

	protected bool mDragStarted;

	[NonSerialized]
	private bool mStarted;

	public UICenterOnChild centerOnChild;

	public UIPanel panel => mPanel;

	public bool isDragging
	{
		get
		{
			if (~(mPressed ? 1u : 0u) != 0)
			{
				return false;
			}
			return mDragStarted;
		}
	}

	public unsafe virtual Bounds bounds
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_00bd: Expected native int or pointer, but got VT
			//IL_00ae: Expected VT, but got Obj
			object obj2 = default;
			object obj = obj2 - 48;
			if (~(mCalculatedBounds ? 1u : 0u) != 0)
			{
				mCalculatedBounds = true;
				Transform transform = base.transform;
				mTrans = transform;
				Bounds bounds = NGUIMath.CalculateRelativeWidgetBounds(mTrans, mTrans);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				mBounds = (Bounds)obj;
			}
			Bounds bounds2 = default;
			((Bounds*)(nint)bounds2)->m_Center = (Vector3)mBounds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIScrollView)+AC]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIScrollView)+A4]");
			_ = 0;
			return bounds2;
		}
	}

	public bool canMoveHorizontally
	{
		get
		{
			//IL_009e: Invalid comparison between VT and F4
			bool flag = movement == Movement.Horizontal;
			bool result = true;
			if (!flag)
			{
				if (movement != Movement.Vertical)
				{
					bool flag2 = movement == Movement.Unrestricted;
					result = true;
					if (flag2)
					{
						goto IL_00ba;
					}
					if (movement == Movement.Custom)
					{
						return customMovement != (Vector2)(object)0f;
					}
				}
				result = false;
			}
			goto IL_00ba;
			IL_00ba:
			return result;
		}
	}

	public bool canMoveVertically
	{
		get
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0091: Invalid comparison between I and F4
			object obj = movement - 1;
			bool flag = movement == Movement.Vertical;
			bool result = true;
			if (!flag)
			{
				bool flag2 = (nint)obj == 1;
				result = true;
				if (!flag2)
				{
					if ((nint)obj == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+34]");
						return 0f != 0f;
					}
					result = false;
				}
			}
			return result;
		}
	}

	public unsafe virtual bool shouldMoveHorizontally
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0025: Expected I, but got Obj
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected Obj, but got Unknown
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Expected VT, but got Unknown
			//IL_0070: Expected Ref, but got VT
			//IL_00d2: Expected Obj, but got VT
			//IL_0130: Expected F8, but got I4
			//IL_017b: Invalid comparison between F8 and I4
			object obj2 = default;
			object obj = obj2 - 48;
			_ = 0;
			_ = 0;
			_ = 0;
			nint num = (nint)this;
			object obj3 = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ S2_v2 (Il2CppClass<UIScrollView>)+DC] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			Bounds bounds = (Bounds)(obj + 24);
			Vector3 size = ((Bounds*)bounds)->size;
			UIPanel uIPanel = mPanel;
			bool flag = uIPanel.mClipping == UIDrawCall.Clipping.SoftClip;
			bool flag2 = !flag;
			object obj4 = obj;
			UIPanel uIPanel2 = uIPanel;
			if (!flag2)
			{
				object obj5 = uIPanel.mClipSoftness + uIPanel.mClipSoftness;
				object obj6 = obj + obj5;
				obj4 = obj6;
				uIPanel2 = mPanel;
			}
			float width = uIPanel2.width;
			float num2 = (float)obj4 - width;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num4 = default;
			double num3 = Math.Abs(num4);
			if (!(num3 < 2147483648.0))
			{
				num4 = -2147483648.0;
			}
			return num4 > 0.0;
		}
	}

	public unsafe virtual bool shouldMoveVertically
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0025: Expected I, but got Obj
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected Obj, but got Unknown
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Expected VT, but got Unknown
			//IL_0070: Expected Ref, but got VT
			//IL_00ad: Expected Obj, but got I
			//IL_00e0: Expected Obj, but got I
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Expected Obj, but got Unknown
			//IL_0146: Expected F8, but got I4
			//IL_0191: Invalid comparison between F8 and I4
			object obj2 = default;
			object obj = obj2 - 48;
			_ = 0;
			_ = 0;
			_ = 0;
			nint num = (nint)this;
			object obj3 = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ S2_v2 (Il2CppClass<UIScrollView>)+DC] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			Bounds bounds = (Bounds)(obj + 24);
			Vector3 size = ((Bounds*)bounds)->size;
			UIPanel uIPanel = mPanel;
			bool flag = uIPanel.mClipping == UIDrawCall.Clipping.SoftClip;
			bool flag2 = !flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			object obj4 = 0;
			UIPanel uIPanel2 = uIPanel;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v14 (UIPanel)+DC]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v14 (UIPanel)+DC]");
				object obj5 = num2 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				object obj6 = 0 + obj5;
				obj4 = obj6;
				uIPanel2 = mPanel;
			}
			float height = uIPanel2.height;
			float num3 = (float)obj4 - height;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num5 = default;
			double num4 = Math.Abs(num5);
			if (!(num4 < 2147483648.0))
			{
				num5 = -2147483648.0;
			}
			return num5 > 0.0;
		}
	}

	protected unsafe virtual bool shouldMove
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_03b1: Expected I, but got Obj
			//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bc: Expected Obj, but got Unknown
			//IL_03f6: Invalid comparison between I and F4
			//IL_0426: Invalid comparison between I and F4
			//IL_006b: Expected F4, but got I4
			//IL_009e: Expected F4, but got I4
			//IL_0200: Expected Obj, but got I4
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Expected VT, but got Unknown
			//IL_0169: Expected Ref, but got VT
			//IL_0184: Invalid comparison between Obj and F4
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Expected VT, but got Unknown
			//IL_01b8: Expected Ref, but got VT
			//IL_01d3: Invalid comparison between Obj and F4
			//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Expected VT, but got Unknown
			//IL_02b4: Expected Ref, but got VT
			//IL_02df: Invalid comparison between I and F4
			//IL_0136: Invalid comparison between VT and F4
			//IL_0281: Invalid comparison between I and F4
			//IL_0305: Unknown result type (might be due to invalid IL or missing references)
			//IL_030a: Expected VT, but got Unknown
			//IL_0313: Expected Ref, but got VT
			//IL_033e: Invalid comparison between I and F4
			object obj2 = default;
			object obj = obj2 - 48;
			_ = 0;
			_ = 0;
			_ = 0;
			bool flag = (byte)(~(disableDragIfFits ? 1u : 0u)) != 0;
			bool result = true;
			float num2;
			float num3;
			bool flag3;
			bool flag5;
			if (!flag)
			{
				if (mPanel == null)
				{
					UIPanel component = GetComponent<UIPanel>();
					mPanel = component;
				}
				Vector4 finalClipRegion = mPanel.finalClipRegion;
				nint num = (nint)this;
				object obj3 = this + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v119 @ S2_v6 (Il2CppClass<UIScrollView>)+DC] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				if (0f == 0f)
				{
					int width = Screen.width;
					num2 = width;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					num2 = 0f * 0.5f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				if (0f == 0f)
				{
					int height = Screen.height;
					num3 = height;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
					num3 = 0f * 0.5f;
				}
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
							goto IL_046d;
						}
						if (movement == Movement.Custom)
						{
							flag5 = customMovement != (Vector2)(object)0f;
							goto IL_047a;
						}
					}
					flag3 = false;
				}
				goto IL_046d;
			}
			goto IL_0493;
			IL_046d:
			flag5 = flag3;
			goto IL_047a;
			IL_035b:
			result = false;
			goto IL_0493;
			IL_04a5:
			bool flag6;
			if (!flag6)
			{
				goto IL_035b;
			}
			Bounds bounds = (Bounds)(obj + 24);
			Vector3 min = ((Bounds*)bounds)->min;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			float num4 = 0f - num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			bool flag7 = 0f < num4;
			result = true;
			if (!flag7)
			{
				Bounds bounds2 = (Bounds)(obj + 24);
				Vector3 max = ((Bounds*)bounds2)->max;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				float num5 = 0f + num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				bool flag8 = 0f > num5;
				result = true;
				if (!flag8)
				{
					goto IL_035b;
				}
			}
			goto IL_0493;
			IL_01f0:
			object obj4 = movement - 1;
			bool flag9 = movement == Movement.Vertical;
			bool flag10 = true;
			if (!flag9)
			{
				bool flag11 = (nint)obj4 == 1;
				flag10 = true;
				if (!flag11)
				{
					if ((nint)obj4 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+34]");
						flag6 = 0f != 0f;
						goto IL_04a5;
					}
					flag10 = false;
				}
			}
			flag6 = flag10;
			goto IL_04a5;
			IL_0493:
			return result;
			IL_047a:
			if (!flag5)
			{
				goto IL_01f0;
			}
			Bounds bounds3 = (Bounds)(obj + 24);
			Vector3 min2 = ((Bounds*)bounds3)->min;
			float num6 = (float)obj - num2;
			bool flag12 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num6);
			result = true;
			if (!flag12)
			{
				Bounds bounds4 = (Bounds)(obj + 24);
				Vector3 max2 = ((Bounds*)bounds4)->max;
				float num7 = (float)obj + num2;
				bool flag13 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num7);
				result = true;
				if (!flag13)
				{
					goto IL_01f0;
				}
			}
			goto IL_0493;
		}
	}

	public unsafe Vector3 currentMomentum
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Vector3 vector = default;
			((Vector3*)(nint)vector)->x = (float)mMomentum;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIScrollView)+94]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
		set
		{
			//IL_000f: Expected VT, but got F4
			mMomentum = (Vector3)value.x;
			_ = value.z;
			mShouldMove = true;
		}
	}

	private unsafe void Awake()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0083: Expected Obj, but got VT
		//IL_00a0: Expected Obj, but got I
		//IL_00ca: Expected Obj, but got I
		//IL_00e0: Invalid comparison between Obj and F4
		//IL_0331: Expected I, but got Obj
		//IL_0351: Expected Obj, but got VT
		//IL_036e: Expected Obj, but got VT
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got Unknown
		//IL_03a6: Invalid comparison between Obj and F4
		//IL_010a: Invalid comparison between VT and F4
		//IL_0164: Invalid comparison between VT and F4
		//IL_0274: Expected F4, but got I
		//IL_026f: Expected native int or pointer, but got VT
		//IL_01be: Invalid comparison between VT and F4
		//IL_0132: Invalid comparison between I and F4
		//IL_018c: Invalid comparison between I and F4
		//IL_01e6: Invalid comparison between I and F4
		//IL_03d9: Expected I, but got Obj
		object obj = default;
		Vector2 vector = (Vector2)(obj - 16);
		Transform transform = base.transform;
		mTrans = transform;
		UIPanel component = GetComponent<UIPanel>();
		mPanel = component;
		UIPanel uIPanel = mPanel;
		if (uIPanel.mClipping == UIDrawCall.Clipping.None && uIPanel.mClipping != UIDrawCall.Clipping.ConstrainButDontClip)
		{
			uIPanel.mMatrixFrame = -1;
			uIPanel.mClipping = UIDrawCall.Clipping.ConstrainButDontClip;
			uIPanel.mResized = true;
		}
		if (movement != Movement.Custom)
		{
			object obj2 = scale * scale;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+54]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+54]");
			object obj3 = num * 0;
			object obj4 = obj2 + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+58]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+58]");
			object obj5 = num2 * 0;
			object obj6 = obj4 + obj5;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.001f))
			{
				if (scale == (Vector3)(object)1f)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+54]");
					if (0f == 0f)
					{
						movement = Movement.Horizontal;
						goto IL_03cb;
					}
				}
				if (scale == (Vector3)(object)0f)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+54]");
					if (0f == 1f)
					{
						movement = Movement.Vertical;
						goto IL_03cb;
					}
				}
				if (scale == (Vector3)(object)1f)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+54]");
					if (0f == 1f)
					{
						movement = Movement.Unrestricted;
						goto IL_03cb;
					}
				}
				customMovement = scale;
				movement = Movement.Custom;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+54]");
				_ = 0;
				goto IL_03cb;
			}
		}
		goto IL_030e;
		IL_03cb:
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v69 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v70 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		scale = Vector3.zeroVector;
		goto IL_030e;
		IL_030e:
		if (contentPivot == UIWidget.Pivot.TopLeft)
		{
			nint num5 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v30 (Il2CppClass<UnityEngine.Vector2>)+5C]");
			nint num6 = 0;
			object obj7 = relativePositionOnReset - Vector2.zeroVector;
			object obj8 = obj7 * obj7;
			object obj9 = relativePositionOnReset >> 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v31 (Il2CppStaticFields<UnityEngine.Vector2>)+4]");
			object obj10 = obj9 - 0;
			object obj11 = obj10 * obj10;
			object obj12 = obj8 + obj11;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)9.9999994E-11f))
			{
				float num7 = 1f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+60]");
				float num8 = num7 - 0f;
				_ = relativePositionOnReset;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+8]");
				((Vector2*)(nint)vector)->x = 0f;
				UIWidget.Pivot pivot = NGUIMath.GetPivot(vector);
				contentPivot = pivot;
				relativePositionOnReset = Vector2.zeroVector;
			}
		}
	}

	private void OnEnable()
	{
		list.Add(this);
		if (~(mStarted ? 1u : 0u) == 0 && Application.isPlaying)
		{
			CheckScrollbars();
		}
	}

	private void Start()
	{
		mStarted = true;
		if (Application.isPlaying)
		{
			CheckScrollbars();
		}
	}

	private unsafe void CheckScrollbars()
	{
		if (horizontalScrollBar != null)
		{
			UIProgressBar uIProgressBar = horizontalScrollBar;
			EventDelegate.Callback callback = default;
			callback._002Ector(this, (nint)__ldftn(UIScrollView.OnScrollBar));
			EventDelegate eventDelegate = EventDelegate.Add(uIProgressBar.onChange, callback);
			horizontalScrollBar.BroadcastMessage("CacheDefaultColor", SendMessageOptions.DontRequireReceiver);
			float alpha = 0f;
			if (showScrollBars == ShowCondition.Always)
			{
				alpha = 1f;
			}
			horizontalScrollBar.alpha = alpha;
		}
		if (verticalScrollBar != null)
		{
			UIProgressBar uIProgressBar2 = verticalScrollBar;
			EventDelegate.Callback callback2 = default;
			callback2._002Ector(this, (nint)__ldftn(UIScrollView.OnScrollBar));
			EventDelegate eventDelegate2 = EventDelegate.Add(uIProgressBar2.onChange, callback2);
			verticalScrollBar.BroadcastMessage("CacheDefaultColor", SendMessageOptions.DontRequireReceiver);
			float alpha2 = 0f;
			if (showScrollBars == ShowCondition.Always)
			{
				alpha2 = 1f;
			}
			verticalScrollBar.alpha = alpha2;
		}
	}

	private void OnDisable()
	{
		bool flag = list.Remove(this);
	}

	public bool RestrictWithinBounds(bool instant)
	{
		return RestrictWithinBounds(instant, horizontal: true, vertical: true);
	}

	public unsafe bool RestrictWithinBounds(bool instant, bool horizontal, bool vertical)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0026: Expected I, but got Obj
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected VT, but got Unknown
		//IL_0079: Expected Ref, but got VT
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected VT, but got Unknown
		//IL_0094: Expected Ref, but got VT
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_0115: Expected F4, but got I
		//IL_034b: Expected F4, but got I
		//IL_028c: Expected Obj, but got I
		//IL_039f: Expected F4, but got I
		//IL_02db: Expected VT, but got I4
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected VT, but got Unknown
		object obj2 = default;
		object obj = obj2 - 144;
		_ = 0;
		_ = 0;
		_ = 0;
		if (mPanel != null)
		{
			object obj3 = obj + 96;
			nint num = (nint)this;
			object obj4 = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v36 @ S2_v4 (Il2CppClass<UIScrollView>)+DC] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
			_ = 0;
			Bounds bounds = (Bounds)(obj + 120);
			Vector3 min = ((Bounds*)bounds)->min;
			Bounds bounds2 = (Bounds)(obj + 120);
			Vector3 max = ((Bounds*)bounds2)->max;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
			_ = 0;
			object obj5 = obj + 96;
			object obj6 = obj + 40;
			object obj7 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @538A");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
			float num2 = 0f;
			if (!horizontal)
			{
				num2 = 0f;
			}
			float num3 = num2 * num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+64]");
			float num4 = 0f;
			if (!vertical)
			{
				num4 = 0f;
			}
			float num5 = num4 * num4;
			float num6 = num3 + num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
			float num7 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
			float num8 = num7 * 0f;
			float num9 = num6 + num8;
			if (num9 > 0.1f)
			{
				if (!instant && dragEffect == DragEffect.MomentumAndSpring)
				{
					Vector3 localPosition = mTrans.localPosition;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+64]");
					float num10 = 0f + num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
					float num11 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
					float num12 = num11 + 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
					float num13 = 0f + num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
					GameObject go = mPanel.gameObject;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
					_ = 0;
					Vector3 pos = (Vector3)(obj + 16);
					SpringPanel springPanel = SpringPanel.Begin(go, pos, 13f);
					springPanel.strength = 8f;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
					obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1BEF");
					float num14 = Math.Abs(num2);
					if (num14 > 0.01f)
					{
						mMomentum = (Vector3)0;
					}
					float num15 = Math.Abs(num4);
					if (num15 > 0.01f)
					{
						_ = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
					float num16 = Math.Abs(0f);
					if (num16 > 0.01f)
					{
						_ = 0;
					}
					mScroll = 0f;
				}
			}
		}
		return true;
	}

	public void DisableSpring()
	{
		SpringPanel component = GetComponent<SpringPanel>();
		if (component != null)
		{
			component.enabled = false;
		}
	}

	public void UpdateScrollbars()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v6 @ S2_v3+BC] (should have been resolved before IL gen)");
	}

	public unsafe virtual void UpdateScrollbars(bool recalculateBounds)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02ec: Expected I, but got Obj
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected Obj, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected VT, but got Unknown
		//IL_0337: Expected Ref, but got VT
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected VT, but got Unknown
		//IL_0352: Expected Ref, but got VT
		//IL_00a3: Expected I, but got Obj
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_0165: Expected F8, but got I4
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected Obj, but got Unknown
		//IL_0251: Expected F8, but got I4
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected Obj, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected Obj, but got Unknown
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected Obj, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		_ = 0;
		if (!(mPanel != null))
		{
			return;
		}
		if (horizontalScrollBar != null || verticalScrollBar != null)
		{
			if (recalculateBounds)
			{
				mCalculatedBounds = false;
				nint num = (nint)this;
				object obj3 = this + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v137 @ S2_v40 (Il2CppClass<UIScrollView>)+F4] (should have been resolved before IL gen)");
				bool flag = default;
				mShouldMove = flag;
			}
			nint num2 = (nint)this;
			object obj4 = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v153 @ S2_v7 (Il2CppClass<UIScrollView>)+DC] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			Bounds bounds = (Bounds)(obj + 24);
			Vector3 min = ((Bounds*)bounds)->min;
			Bounds bounds2 = (Bounds)(obj + 24);
			Vector3 max = ((Bounds*)bounds2)->max;
			if (horizontalScrollBar != null && System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
			{
				Vector4 finalClipRegion = mPanel.finalClipRegion;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
				double num4 = default;
				double num3 = Math.Abs(num4);
				if (!(num3 < 2147483648.0))
				{
					num4 = -2147483648.0;
				}
				object obj5 = num4 & 1;
				if (obj5 != null)
				{
					num4--;
				}
				double num5 = num4 * 0.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
				UIPanel uIPanel = mPanel;
				bool flag2 = uIPanel.mClipping == UIDrawCall.Clipping.SoftClip;
				bool flag3 = !flag2;
				object obj7 = default;
				object obj6 = obj7;
				if (!flag3)
				{
					object obj8 = obj7 - uIPanel.mClipSoftness;
					obj6 = obj8;
				}
				object obj9 = obj - obj6;
				float contentMin = (float)obj9 - (float)obj;
				object obj10 = obj + obj6;
				float contentMax = (float)obj - (float)obj10;
				float contentSize = (float)obj - (float)obj;
				float viewSize = (float)obj6 + (float)obj6;
				UpdateScrollbars(horizontalScrollBar, contentMin, contentMax, contentSize, viewSize, inverted: false);
			}
			if (!(verticalScrollBar != null))
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			if (num6 < 0)
			{
				Vector4 finalClipRegion2 = mPanel.finalClipRegion;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
				double num8 = default;
				double num7 = Math.Abs(num8);
				if (!(num7 < 2147483648.0))
				{
					num8 = -2147483648.0;
				}
				object obj11 = num8 & 1;
				if (obj11 != null)
				{
					num8--;
				}
				double num9 = num8 * 0.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
				UIPanel uIPanel2 = mPanel;
				bool flag4 = uIPanel2.mClipping == UIDrawCall.Clipping.SoftClip;
				bool flag5 = !flag4;
				object obj13 = default;
				object obj12 = obj13;
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S2_v19 (UIPanel)+DC]");
					object obj14 = obj13 - 0;
					obj12 = obj14;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				object obj15 = 0 - obj12;
				float num10 = (float)obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				float contentMin2 = num10 - 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				object obj16 = 0 + obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				float contentMax2 = 0f - (float)obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				float num11 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				float contentSize2 = num11 - 0f;
				float viewSize2 = (float)obj12 + (float)obj12;
				UpdateScrollbars(verticalScrollBar, contentMin2, contentMax2, contentSize2, viewSize2, inverted: true);
			}
		}
		else if (recalculateBounds)
		{
			mCalculatedBounds = false;
		}
	}

	protected void UpdateScrollbars(UIProgressBar slider, float contentMin, float contentMax, float contentSize, float viewSize, bool inverted)
	{
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Expected Obj, but got Unknown
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected Obj, but got Unknown
		if (slider == null)
		{
			return;
		}
		mIgnoreCallbacks = true;
		object obj2;
		float num11;
		if (contentSize > viewSize)
		{
			float num = contentMin / contentSize;
			float num2 = Math.Min(num, 1f);
			bool flag = num < 0f;
			float num3 = 0f;
			if (!flag)
			{
				num3 = num2;
			}
			float num4 = contentMax / contentSize;
			float num5 = Math.Min(num4, 1f);
			bool flag2 = num4 < 0f;
			float num6 = 0f;
			if (!flag2)
			{
				num6 = num5;
			}
			float num7 = num3 + num6;
			float value;
			if (!inverted)
			{
				bool flag3 = num7 > 0.001f;
				bool flag4 = !flag3;
				value = 1f;
				if (!flag4)
				{
					float num8 = num3 / num7;
					value = num8;
				}
			}
			else
			{
				bool flag5 = num7 > 0.001f;
				bool flag6 = !flag5;
				value = 0f;
				if (!flag6)
				{
					float num9 = num3 / num7;
					float num10 = 1f - num9;
					value = num10;
				}
			}
			slider.value = value;
			object obj = this + 76;
			bool flag7 = scrollbar != null;
			bool flag8 = !flag7;
			obj2 = obj;
			num11 = num7;
			if (!flag8)
			{
				scrollbar.value = value;
				obj2 = obj;
				num11 = num7;
			}
		}
		else
		{
			float num12 = 0f - contentMin;
			float num13 = num12 / contentSize;
			float num14 = Math.Min(num13, 1f);
			bool flag9 = num13 < 0f;
			float num15 = 0f;
			if (!flag9)
			{
				num15 = num14;
			}
			float num16 = 0f - contentMax;
			float num17 = num16 / contentSize;
			float num18 = Math.Min(num17, 1f);
			bool flag10 = num17 < 0f;
			float num19 = 0f;
			if (!flag10)
			{
				num19 = num18;
			}
			float num20 = num15 + num19;
			float value2;
			if (!inverted)
			{
				bool flag11 = num20 > 0.001f;
				bool flag12 = !flag11;
				value2 = 1f;
				if (!flag12)
				{
					float num21 = num15 / num20;
					value2 = num21;
				}
			}
			else
			{
				bool flag13 = num20 > 0.001f;
				bool flag14 = !flag13;
				value2 = 0f;
				if (!flag14)
				{
					float num22 = num15 / num20;
					float num23 = 1f - num22;
					value2 = num23;
				}
			}
			slider.value = value2;
			object obj3 = this + 76;
			if (scrollbar != null)
			{
				scrollbar.value = value2;
			}
			bool flag15 = contentSize > 0f;
			bool flag16 = !flag15;
			obj2 = obj3;
			num11 = num20;
			if (!flag16)
			{
				float num24 = num15 / contentSize;
				float num25 = Math.Min(num24, 1f);
				bool flag17 = num24 < 0f;
				float num26 = 0f;
				if (!flag17)
				{
					num26 = num25;
				}
				float num27 = num19 / contentSize;
				float num28 = Math.Min(num27, 1f);
				bool flag18 = num27 < 0f;
				float num29 = 0f;
				if (!flag18)
				{
					num29 = num28;
				}
				float num30 = num26 + num29;
				obj2 = obj3;
				num11 = num30;
			}
		}
		if ((UnityEngine.Object)obj2 != null)
		{
			float size = 1f - num11;
			scrollbar.size = size;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		UnityEngine.Object obj4 = default;
		if (obj4 != null)
		{
			float barSize = 1f - num11;
			((UIScrollBar)obj4).barSize = barSize;
		}
		mIgnoreCallbacks = false;
	}

	public unsafe virtual void SetDragAmount(float x, float y, bool updateScrollbars)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Expected Obj, but got Unknown
		//IL_0652: Expected I, but got Obj
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Expected Obj, but got Unknown
		//IL_0670: Unknown result type (might be due to invalid IL or missing references)
		//IL_0675: Expected Obj, but got Unknown
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected VT, but got Unknown
		//IL_06ab: Expected Ref, but got VT
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Expected VT, but got Unknown
		//IL_06c6: Expected Ref, but got VT
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected VT, but got Unknown
		//IL_006f: Expected Ref, but got VT
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected VT, but got Unknown
		//IL_008a: Expected Ref, but got VT
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected VT, but got Unknown
		//IL_0115: Expected Ref, but got VT
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected VT, but got Unknown
		//IL_014c: Expected Ref, but got VT
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected VT, but got Unknown
		//IL_017e: Expected Ref, but got VT
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected VT, but got Unknown
		//IL_01b5: Expected Ref, but got VT
		//IL_090f: Expected Obj, but got I4
		//IL_0544: Expected F4, but got I
		//IL_0870: Expected Obj, but got I4
		//IL_03e1: Expected F4, but got I
		//IL_096d: Expected F4, but got I
		//IL_0968: Expected native int or pointer, but got VT
		//IL_05ce: Expected F4, but got I
		//IL_0518: Invalid comparison between VT and F4
		//IL_08d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d7: Expected VT, but got Unknown
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Expected Obj, but got Unknown
		//IL_05a2: Invalid comparison between I and F4
		//IL_046b: Expected F4, but got I
		//IL_03b5: Invalid comparison between VT and F4
		//IL_043f: Invalid comparison between I and F4
		object obj = default;
		Vector2 vector = (Vector2)(obj - 96);
		_ = 0;
		_ = 0;
		_ = 0;
		if (mPanel == null)
		{
			UIPanel component = GetComponent<UIPanel>();
			mPanel = component;
		}
		DisableSpring();
		object obj2 = vector + 48;
		nint num = (nint)this;
		object obj3 = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S2_v4 (Il2CppClass<UIScrollView>)+DC] (should have been resolved before IL gen)");
		object obj4 = vector - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+30]");
		_ = 0;
		Bounds bounds = (Bounds)(vector + 72);
		Vector3 min = ((Bounds*)bounds)->min;
		Bounds bounds2 = (Bounds)(vector + 72);
		Vector3 max = ((Bounds*)bounds2)->max;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+30]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+30]");
		if (num2 == 0)
		{
			return;
		}
		Bounds bounds3 = (Bounds)(vector + 72);
		Vector3 min2 = ((Bounds*)bounds3)->min;
		Bounds bounds4 = (Bounds)(vector + 72);
		Vector3 max2 = ((Bounds*)bounds4)->max;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+34]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+34]");
		if (num3 == 0)
		{
			return;
		}
		Vector4 finalClipRegion = mPanel.finalClipRegion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+38]");
		float num4 = 0f * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+3C]");
		float num5 = 0f * 0.5f;
		Bounds bounds5 = (Bounds)(vector + 72);
		Vector3 min3 = ((Bounds*)bounds5)->min;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+30]");
		float num6 = 0f + num4;
		Bounds bounds6 = (Bounds)(vector + 72);
		Vector3 max3 = ((Bounds*)bounds6)->max;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+30]");
		float num7 = 0f - num4;
		Bounds bounds7 = (Bounds)(vector + 72);
		Vector3 min4 = ((Bounds*)bounds7)->min;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+34]");
		float num8 = 0f + num5;
		Bounds bounds8 = (Bounds)(vector + 72);
		Vector3 max4 = ((Bounds*)bounds8)->max;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+34]");
		float num9 = 0f - num5;
		UIPanel uIPanel = mPanel;
		bool flag = uIPanel.mClipping == UIDrawCall.Clipping.SoftClip;
		bool flag2 = !flag;
		float num10 = num8;
		float num11 = num7;
		float num12 = num6;
		float num13 = num9;
		if (!flag2)
		{
			float num14 = num6 - (float)uIPanel.mClipSoftness;
			UIPanel uIPanel2 = mPanel;
			float num15 = num7 + (float)uIPanel2.mClipSoftness;
			UIPanel uIPanel3 = mPanel;
			float num16 = num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S1_v104 (UIPanel)+DC]");
			float num17 = num16 - 0f;
			UIPanel uIPanel4 = mPanel;
			float num18 = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S1_v107 (UIPanel)+DC]");
			float num19 = num18 + 0f;
			num10 = num17;
			num11 = num15;
			num12 = num14;
			num13 = num19;
		}
		float num20 = num11 - num12;
		float num21 = Math.Min(x, 1f);
		bool flag3 = x < 0f;
		float num22 = 0f;
		if (!flag3)
		{
			num22 = num21;
		}
		float num23 = num20 * num22;
		float num24 = num12 + num23;
		float num25 = num10 - num13;
		float num26 = Math.Min(y, 1f);
		bool flag4 = y < 0f;
		float num27 = 0f;
		if (!flag4)
		{
			num27 = num26;
		}
		float num28 = num25 * num27;
		float num29 = num13 + num28;
		if (updateScrollbars)
		{
			goto IL_0470;
		}
		Vector3 localPosition = mTrans.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+30]");
		float num30 = 0f - num24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+30]");
		float num31 = 0f + num30;
		bool flag5 = movement == Movement.Horizontal;
		bool flag6 = true;
		bool flag8;
		if (!flag5)
		{
			if (movement != Movement.Vertical)
			{
				bool flag7 = movement == Movement.Unrestricted;
				flag6 = true;
				if (flag7)
				{
					goto IL_07be;
				}
				if (movement == Movement.Custom)
				{
					flag8 = customMovement != (Vector2)(object)0f;
					goto IL_07cb;
				}
			}
			flag6 = false;
		}
		goto IL_07be;
		IL_07be:
		flag8 = flag6;
		goto IL_07cb;
		IL_07f4:
		bool flag10;
		bool flag9 = flag10;
		goto IL_0801;
		IL_0470:
		UIPanel uIPanel5 = mPanel;
		bool flag11 = movement == Movement.Horizontal;
		flag10 = true;
		if (!flag11)
		{
			if (movement != Movement.Vertical)
			{
				bool flag12 = movement == Movement.Unrestricted;
				flag10 = true;
				if (flag12)
				{
					goto IL_07f4;
				}
				if (movement == Movement.Custom)
				{
					flag9 = customMovement != (Vector2)(object)0f;
					goto IL_0801;
				}
			}
			flag10 = false;
		}
		goto IL_07f4;
		IL_07cb:
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+30]");
			num31 = 0f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+34]");
		float num32 = 0f - num29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+34]");
		float num33 = 0f + num32;
		object obj5 = movement - 1;
		bool flag13 = movement == Movement.Vertical;
		bool flag14 = true;
		bool flag16;
		if (!flag13)
		{
			bool flag15 = (nint)obj5 == 1;
			flag14 = true;
			if (!flag15)
			{
				if ((nint)obj5 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+34]");
					flag16 = 0f != 0f;
					goto IL_07e6;
				}
				flag14 = false;
			}
		}
		flag16 = flag14;
		goto IL_07e6;
		IL_0801:
		if (!flag9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+30]");
			num24 = 0f;
		}
		float num34 = num24 - (float)uIPanel5.mClipRange;
		object obj6 = movement - 1;
		bool flag17 = movement == Movement.Vertical;
		bool flag18 = true;
		bool flag20;
		if (!flag17)
		{
			bool flag19 = (nint)obj6 == 1;
			flag18 = true;
			if (!flag19)
			{
				if ((nint)obj6 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+34]");
					flag20 = 0f != 0f;
					goto IL_081c;
				}
				flag18 = false;
			}
		}
		flag20 = flag18;
		goto IL_081c;
		IL_07e6:
		if (!flag16)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+34]");
			num33 = 0f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+20]");
		_ = 0;
		Vector3 localPosition2 = (Vector3)(vector + 8);
		mTrans.localPosition = localPosition2;
		goto IL_0470;
		IL_081c:
		float num35 = num29;
		if (!flag20)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+34]");
			num35 = 0f;
		}
		float num36 = num35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S0_v87 (UIPanel)+CC]");
		float num37 = num36 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+18]");
		((Vector2*)(nint)vector)->x = 0f;
		uIPanel5.clipOffset = vector;
		if (updateScrollbars)
		{
			bool flag21 = mDragID == -10;
			object obj7 = this - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v495 @ S2_v43+BC] (should have been resolved before IL gen)");
		}
	}

	public void InvalidateBounds()
	{
		mCalculatedBounds = false;
	}

	public void ResetPosition()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004a: Expected I, but got Obj
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_007c: Expected I, but got Obj
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (NGUITools.GetActive(this))
		{
			mCalculatedBounds = false;
			Vector2 pivotOffset = NGUIMath.GetPivotOffset(contentPivot);
			float num = 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			float num2 = num - 0f;
			nint num3 = (nint)this;
			object obj3 = this + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v74 @ S4_v3 (Il2CppClass<UIScrollView>)+104] (should have been resolved before IL gen)");
			float num4 = 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			float num5 = num4 - 0f;
			nint num6 = (nint)this;
			object obj4 = this + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v84 @ S4_v7 (Il2CppClass<UIScrollView>)+104] (should have been resolved before IL gen)");
		}
	}

	public void UpdatePosition()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00cf: Expected F4, but got I
		//IL_0169: Expected I, but got Obj
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (!mIgnoreCallbacks && (horizontalScrollBar != null || verticalScrollBar != null))
		{
			mCalculatedBounds = false;
			mIgnoreCallbacks = true;
			Vector2 pivotOffset = NGUIMath.GetPivotOffset(contentPivot);
			bool flag = horizontalScrollBar != null;
			bool flag2 = !flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			float num = 0f;
			if (!flag2)
			{
				float value = horizontalScrollBar.value;
				num = value;
			}
			if (verticalScrollBar != null)
			{
				float value2 = verticalScrollBar.value;
			}
			else
			{
				float num2 = 1f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				float value2 = num2 - 0f;
			}
			nint num3 = (nint)this;
			object obj3 = this + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v132 @ S4_v4 (Il2CppClass<UIScrollView>)+104] (should have been resolved before IL gen)");
			object obj4 = this - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v143 @ S2_v11+BC] (should have been resolved before IL gen)");
			mIgnoreCallbacks = false;
		}
	}

	public void OnScrollBar()
	{
		//IL_00c6: Expected I, but got Obj
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		if (~(mIgnoreCallbacks ? 1u : 0u) != 0)
		{
			mIgnoreCallbacks = true;
			if (horizontalScrollBar != null)
			{
				float value = horizontalScrollBar.value;
			}
			if (verticalScrollBar != null)
			{
				float value2 = verticalScrollBar.value;
			}
			else
			{
				float value2 = 0f;
			}
			nint num = (nint)this;
			object obj = this + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v79 @ S4_v4 (Il2CppClass<UIScrollView>)+104] (should have been resolved before IL gen)");
			mIgnoreCallbacks = false;
		}
	}

	public unsafe virtual void MoveRelative(Vector3 relative)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected VT, but got Unknown
		//IL_011a: Expected F4, but got I
		//IL_0115: Expected native int or pointer, but got VT
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		object obj = default;
		Vector2 vector = (Vector2)(obj + -64);
		Vector3 localPosition = mTrans.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+30]");
		float num = 0f + relative.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+34]");
		float num2 = 0f + relative.y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+38]");
		float num3 = 0f + relative.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+20]");
		_ = 0;
		Vector3 localPosition2 = (Vector3)(vector + 8);
		mTrans.localPosition = localPosition2;
		UIPanel uIPanel = mPanel;
		float num4 = (float)uIPanel.mClipOffset - relative.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v18 (UIPanel)+F0]");
		float num5 = 0f - relative.y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+18]");
		((Vector2*)(nint)vector)->x = 0f;
		mPanel.clipOffset = vector;
		object obj2 = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v81 @ S2_v10+BC] (should have been resolved before IL gen)");
	}

	public void MoveAbsolute(Vector3 absolute)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected VT, but got Unknown
		//IL_0056: Expected I, but got Obj
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected VT, but got Unknown
		//IL_00ca: Expected Obj, but got I
		//IL_00e7: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I
		//IL_0130: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 96;
		_ = absolute.z;
		_ = absolute.x;
		Vector3 position = (Vector3)(obj + 32);
		Vector3 vector = mTrans.InverseTransformPoint(position);
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v10 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v11 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v11 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_ = Vector3.zeroVector;
		_ = Vector3.zeroVector;
		Vector3 position2 = (Vector3)(obj + 16);
		Vector3 vector2 = mTrans.InverseTransformPoint(position2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
		object obj3 = num3 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+54]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+44]");
		object obj4 = num4 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
		object obj5 = num5 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1BEF");
	}

	public unsafe void Press(bool pressed)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0022: Expected Obj, but got I4
		//IL_04af: Expected I, but got Obj
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected Obj, but got Unknown
		//IL_04f5: Expected I, but got Obj
		//IL_053c: Expected I, but got Obj
		//IL_0586: Expected I, but got Obj
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Expected Obj, but got Unknown
		//IL_05ce: Expected Obj, but got I
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Expected VT, but got Unknown
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Expected VT, but got Unknown
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected VT, but got Unknown
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Expected VT, but got Unknown
		//IL_067a: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Expected VT, but got Unknown
		//IL_068b: Expected native int or pointer, but got VT
		//IL_06af: Expected VT, but got I
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected VT, but got Unknown
		//IL_0198: Expected F4, but got I
		//IL_0193: Expected native int or pointer, but got VT
		//IL_01b7: Expected F4, but got I
		//IL_01b2: Expected native int or pointer, but got VT
		//IL_0719: Expected Obj, but got I4
		//IL_03a0: Invalid comparison between I and F4
		//IL_032b: Invalid comparison between VT and F4
		object obj = default;
		Vector3 vector = (Vector3)(obj - 176);
		UICamera.ControlScheme currentScheme = UICamera.currentScheme;
		if (currentScheme == UICamera.ControlScheme.Controller)
		{
			return;
		}
		object obj2 = smoothDragStart & pressed;
		if (obj2 != null)
		{
			mDragStarted = false;
			mDragStartOffset = Vector2.zeroVector;
		}
		if (!enabled)
		{
			return;
		}
		GameObject go = gameObject;
		if (!NGUITools.GetActive(go))
		{
			return;
		}
		if (!pressed && mDragID == UICamera.currentTouchID)
		{
			mDragID = -10;
		}
		mCalculatedBounds = false;
		nint num = (nint)this;
		object obj3 = this + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v151 @ S2_v3 (Il2CppClass<UIScrollView>)+F4] (should have been resolved before IL gen)");
		bool flag = default;
		mShouldMove = flag;
		if (!flag)
		{
			return;
		}
		mPressed = pressed;
		if (pressed)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v76 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v77 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			_ = 0;
			mMomentum = Vector3.zeroVector;
			mScroll = 0f;
			DisableSpring();
			nint num4 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v86 (Il2CppClass<UICamera>)+5C]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v87 (Il2CppStaticFields<UICamera>)+34]");
			_ = 0;
			mLastPos = UICamera.lastWorldPosition;
			Quaternion rotation = mTrans.rotation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			_ = 0;
			nint num6 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v100 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
			_ = 0;
			object obj4 = vector - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S0_v101 (Il2CppStaticFields<UnityEngine.Vector3>)+5C]");
			obj4 = 0;
			_ = Vector3.backVector;
			Quaternion quaternion = (Quaternion)(vector + 72);
			Vector3 vector2 = vector + 56;
			Vector3 vector3 = quaternion * vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+84]");
			_ = 0;
			_ = mLastPos;
			Plane plane = (Plane)(vector + 144);
			Vector3 inNormal = vector + 40;
			Vector3 inPoint = vector + 24;
			*(Plane*)(nint)plane = new Plane(inNormal, inPoint);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			mPlane = (Plane)0;
			UIPanel uIPanel = mPanel;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
			_ = 0;
			Vector2 clipOffset = (Vector2)(vector + 16);
			mPanel.clipOffset = clipOffset;
			Vector3 localPosition = mTrans.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
			((Vector3*)(nint)vector)->x = 0f;
			mTrans.localPosition = vector;
			if (!smoothDragStart)
			{
				mDragStarted = true;
				mDragStartOffset = Vector2.zeroVector;
				OnDragNotification onDragNotification = onDragStarted;
				if (onDragStarted != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v455.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
			return;
		}
		if ((bool)centerOnChild)
		{
			centerOnChild.Recenter();
			return;
		}
		bool instant;
		bool flag3;
		bool horizontal;
		if (~(restrictWithinPanel ? 1u : 0u) == 0)
		{
			UIPanel uIPanel2 = mPanel;
			if (uIPanel2.mClipping != UIDrawCall.Clipping.None)
			{
				instant = dragEffect == DragEffect.None;
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
							goto IL_06fc;
						}
						if (movement == Movement.Custom)
						{
							horizontal = customMovement != (Vector2)(object)0f;
							goto IL_0709;
						}
					}
					flag3 = false;
				}
				goto IL_06fc;
			}
		}
		goto IL_03bc;
		IL_03bc:
		if (~(mDragStarted ? 1u : 0u) == 0)
		{
			OnDragNotification onDragNotification2 = onDragFinished;
			if (onDragFinished != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v291.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
		if (!mShouldMove)
		{
			OnDragNotification onDragNotification3 = onStoppedMoving;
			if (onStoppedMoving != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v343.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
		return;
		IL_0709:
		object obj5 = movement - 1;
		bool flag5 = movement == Movement.Vertical;
		bool flag6 = true;
		bool vertical;
		if (!flag5)
		{
			bool flag7 = (nint)obj5 == 1;
			flag6 = true;
			if (!flag7)
			{
				if ((nint)obj5 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+34]");
					vertical = 0f != 0f;
					goto IL_074e;
				}
				flag6 = false;
			}
		}
		vertical = flag6;
		goto IL_074e;
		IL_06fc:
		horizontal = flag3;
		goto IL_0709;
		IL_074e:
		bool flag8 = RestrictWithinBounds(instant, horizontal, vertical);
		goto IL_03bc;
	}

	public unsafe void Drag()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected VT, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected VT, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected VT, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected Ref, but got Unknown
		//IL_02b8: Expected Ref, but got VT
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected VT, but got Unknown
		//IL_02f8: Expected F4, but got I
		//IL_02f8: Expected Ref, but got VT
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected Obj, but got Unknown
		//IL_0330: Expected Obj, but got I
		//IL_034d: Expected Obj, but got I
		//IL_0379: Expected VT, but got I
		//IL_0382: Invalid comparison between Obj and F4
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected VT, but got Unknown
		//IL_0459: Expected F4, but got I
		//IL_0146: Expected Obj, but got VT
		//IL_0163: Expected Obj, but got I
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected VT, but got Unknown
		//IL_0c22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c27: Expected VT, but got Unknown
		//IL_0c4a: Expected Obj, but got I
		//IL_0c5a: Expected Obj, but got I
		//IL_0c6a: Expected Obj, but got I
		//IL_03a2: Invalid comparison between Obj and F4
		//IL_06c3: Expected VT, but got F4
		//IL_054b: Expected F4, but got I
		//IL_03c2: Invalid comparison between Obj and F4
		//IL_0701: Expected F4, but got I
		//IL_06fc: Expected native int or pointer, but got VT
		//IL_0720: Expected F4, but got I
		//IL_071b: Expected native int or pointer, but got VT
		//IL_0c7d: Expected I, but got Obj
		//IL_0560: Expected F4, but got I
		//IL_0579: Expected F4, but got I
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_073d: Expected Obj, but got Unknown
		//IL_0742: Expected I, but got Obj
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Expected Obj, but got Unknown
		//IL_0787: Unknown result type (might be due to invalid IL or missing references)
		//IL_078c: Expected VT, but got Unknown
		//IL_0795: Expected Ref, but got VT
		//IL_07a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a7: Expected Obj, but got Unknown
		//IL_07ac: Expected I, but got Obj
		//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b7: Expected Obj, but got Unknown
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f6: Expected VT, but got Unknown
		//IL_07ff: Expected Ref, but got VT
		//IL_0845: Unknown result type (might be due to invalid IL or missing references)
		//IL_084a: Expected Obj, but got Unknown
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_0858: Expected Obj, but got Unknown
		//IL_0861: Unknown result type (might be due to invalid IL or missing references)
		//IL_0866: Expected Obj, but got Unknown
		//IL_0cc7: Expected Obj, but got I
		//IL_0ce4: Expected Obj, but got I
		//IL_0d0e: Expected Obj, but got I
		//IL_0d2e: Invalid comparison between Obj and F4
		//IL_0973: Unknown result type (might be due to invalid IL or missing references)
		//IL_0978: Expected VT, but got Unknown
		//IL_08d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dc: Expected VT, but got Unknown
		//IL_093c: Expected VT, but got F4
		//IL_0d6a: Expected Obj, but got I4
		//IL_0afe: Invalid comparison between I and F4
		//IL_0a89: Invalid comparison between VT and F4
		object obj = default;
		Vector3 vector = (Vector3)(obj - 384);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		UICamera.ControlScheme currentScheme = UICamera.currentScheme;
		if (currentScheme == UICamera.ControlScheme.Controller || !enabled)
		{
			return;
		}
		GameObject go = gameObject;
		if (!NGUITools.GetActive(go) || ~(mShouldMove ? 1u : 0u) != 0)
		{
			return;
		}
		if (mDragID == -10)
		{
			mDragID = UICamera.currentTouchID;
		}
		UICamera.MouseOrTouch currentTouch = UICamera.currentTouch;
		currentTouch.clickNotification = UICamera.ClickNotification.BasedOnDelta;
		if (~(smoothDragStart ? 1u : 0u) == 0)
		{
			if (!mDragStarted)
			{
				mDragStarted = true;
				UICamera.MouseOrTouch currentTouch2 = UICamera.currentTouch;
				mDragStartOffset = currentTouch2.totalDelta;
				OnDragNotification onDragNotification = onDragStarted;
				if (onDragStarted != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v225.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
			if (~(smoothDragStart ? 1u : 0u) == 0)
			{
				UICamera.MouseOrTouch currentTouch3 = UICamera.currentTouch;
				object obj2 = currentTouch3.pos - mDragStartOffset;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S0_v278 (UICamera+MouseOrTouch)+10]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+C0]");
				object obj3 = num - 0;
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+108]");
				_ = 0;
				Vector3 pos = vector + 136;
				Ray ray = UICamera.currentCamera.ScreenPointToRay(pos);
				goto IL_0205;
			}
		}
		UICamera.MouseOrTouch currentTouch4 = UICamera.currentTouch;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+100]");
		_ = 0;
		_ = currentTouch4.pos;
		_ = currentTouch4.pos;
		Vector3 pos2 = vector + 120;
		Ray ray2 = UICamera.currentCamera.ScreenPointToRay(pos2);
		goto IL_0205;
		IL_0d9f:
		bool horizontal;
		bool vertical;
		bool flag = RestrictWithinBounds(instant: true, horizontal, vertical);
		return;
		IL_0205:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+128]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+120]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+118]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+140]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+138]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+138]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+140]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+130]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+130]");
		_ = 0;
		Plane plane = (Plane)(this + 108);
		Ray ray3 = (Ray)(vector + 96);
		if (!((Plane*)plane)->Raycast(ray3, out *(float*)(vector + 356)))
		{
			return;
		}
		Ray ray4 = (Ray)(vector + 360);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+164]");
		Vector3 point = ((Ray*)ray4)->GetPoint(0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+118]");
		object obj4 = 0 - mLastPos;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+11C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+80]");
		object obj5 = num2 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+120]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+84]");
		object obj6 = num3 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+120]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+11C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+118]");
		mLastPos = (Vector3)0;
		object obj7;
		object obj8;
		object obj9;
		if (obj4 == (object)0f && obj5 == (object)0f)
		{
			bool flag2 = obj6 == (object)0f;
			obj7 = obj6;
			obj8 = obj5;
			obj9 = obj4;
			if (flag2)
			{
				goto IL_0bc6;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E8]");
		_ = 0;
		Vector3 direction = vector + 80;
		Vector3 vector2 = mTrans.InverseTransformDirection(direction);
		bool flag3 = movement == Movement.Horizontal;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+118]");
		float num4 = 0f;
		float num5 = 0f;
		float num6 = 0f;
		if (!flag3)
		{
			if (movement != Movement.Vertical)
			{
				if (movement != Movement.Unrestricted)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+118]");
					float num7 = 0f * (float)customMovement;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+11C]");
					float num8 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+34]");
					float num9 = num8 * 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+120]");
					float num10 = 0f * 0f;
					num4 = num7;
					num5 = num10;
					num6 = num9;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+118]");
					num4 = 0f;
					num5 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+11C]");
					num6 = 0f;
				}
			}
			else
			{
				num4 = 0f;
				num5 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+11C]");
				num6 = 0f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
		_ = 0;
		Vector3 direction2 = vector - -64;
		Vector3 vector3 = mTrans.TransformDirection(direction2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+120]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+11C]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+118]");
		obj9 = 0;
		goto IL_0bc6;
		IL_0bc6:
		if (dragEffect != DragEffect.None)
		{
			float num11 = momentumAmount * 0.01f;
			float num12 = (float)obj9 * num11;
			float num13 = (float)obj7 * num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+94]");
			float num14 = 0f + num13;
			float num15 = num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+94]");
			float num16 = num15 - 0f;
			float num17 = num16 * 0.67f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+94]");
			float num18 = 0f + num17;
			float num19 = (float)obj8 * num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+90]");
			float num20 = 0f + num19;
			float num21 = num20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+90]");
			float num22 = num21 - 0f;
			float num23 = num22 * 0.67f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+90]");
			float num24 = 0f + num23;
			float num25 = (float)mMomentum + num12;
			float num26 = num25 - (float)mMomentum;
			float num27 = num26 * 0.67f;
			float num28 = (float)mMomentum + num27;
			mMomentum = (Vector3)num28;
		}
		else
		{
			nint num29 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ S0_v191 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ S0_v192 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			_ = 0;
			mMomentum = Vector3.zeroVector;
		}
		if (~(iOSDragEmulation ? 1u : 0u) != 0 || dragEffect != DragEffect.MomentumAndSpring)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
			((Vector3*)(nint)vector)->x = 0f;
			MoveAbsolute(vector);
		}
		else
		{
			object obj10 = vector + 280;
			nint num31 = (nint)this;
			object obj11 = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v588 @ S2_v24 (Il2CppClass<UIScrollView>)+DC] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+128]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+120]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+118]");
			_ = 0;
			Bounds bounds = (Bounds)(vector + 328);
			Vector3 min = ((Bounds*)bounds)->min;
			object obj12 = vector + 280;
			nint num32 = (nint)this;
			object obj13 = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v621 @ S2_v30 (Il2CppClass<UIScrollView>)+DC] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+128]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+120]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+118]");
			_ = 0;
			Bounds bounds2 = (Bounds)(vector + 328);
			Vector3 max = ((Bounds*)bounds2)->max;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+118]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+118]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+118]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+118]");
			_ = 0;
			object obj14 = vector + 280;
			object obj15 = vector + 56;
			object obj16 = vector + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @538A");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+118]");
			nint num33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+118]");
			object obj17 = num33 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+11C]");
			nint num34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+11C]");
			object obj18 = num34 * 0;
			object obj19 = obj17 + obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+120]");
			nint num35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+120]");
			object obj20 = num35 * 0;
			object obj21 = obj19 + obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1f))
			{
				float num36 = (float)obj7 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
				_ = 0;
				float num37 = (float)obj8 * 0.5f;
				float num38 = (float)obj9 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
				_ = 0;
				Vector3 absolute = vector + 16;
				MoveAbsolute(absolute);
				float num39 = (float)mMomentum * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+90]");
				float num40 = 0f * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+94]");
				float num41 = 0f * 0.5f;
				mMomentum = (Vector3)num39;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
				_ = 0;
				Vector3 absolute2 = vector + 32;
				MoveAbsolute(absolute2);
			}
		}
		if (~(restrictWithinPanel ? 1u : 0u) != 0)
		{
			return;
		}
		UIPanel uIPanel = mPanel;
		if (uIPanel.mClipping == UIDrawCall.Clipping.None || dragEffect == DragEffect.MomentumAndSpring)
		{
			return;
		}
		bool flag4 = movement == Movement.Horizontal;
		bool flag5 = true;
		if (!flag4)
		{
			if (movement != Movement.Vertical)
			{
				bool flag6 = movement == Movement.Unrestricted;
				flag5 = true;
				if (flag6)
				{
					goto IL_0d4d;
				}
				if (movement == Movement.Custom)
				{
					horizontal = customMovement != (Vector2)(object)0f;
					goto IL_0d5a;
				}
			}
			flag5 = false;
		}
		goto IL_0d4d;
		IL_0d4d:
		horizontal = flag5;
		goto IL_0d5a;
		IL_0d5a:
		object obj22 = movement - 1;
		bool flag7 = movement == Movement.Vertical;
		bool flag8 = true;
		if (!flag7)
		{
			bool flag9 = (nint)obj22 == 1;
			flag8 = true;
			if (!flag9)
			{
				if ((nint)obj22 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+34]");
					vertical = 0f != 0f;
					goto IL_0d9f;
				}
				flag8 = false;
			}
		}
		vertical = flag8;
		goto IL_0d9f;
	}

	public void Scroll(float delta)
	{
		//IL_0064: Expected I, but got Obj
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected I4, but got Unknown
		if (!enabled)
		{
			return;
		}
		GameObject go = gameObject;
		if (NGUITools.GetActive(go) && scrollWheelFactor != 0f)
		{
			DisableSpring();
			nint num = (nint)this;
			object obj = this + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v60 @ S3_v3 (Il2CppClass<UIScrollView>)+F4] (should have been resolved before IL gen)");
			object obj2 = default;
			bool flag = (byte)((mShouldMove | obj2) ? 1 : 0) != 0;
			mShouldMove = flag;
			bool flag2 = !(mScroll < 0f);
			float num2 = 1f;
			if (!flag2)
			{
				num2 = -1f;
			}
			bool flag3 = !(delta < 0f);
			float num3 = 1f;
			if (!flag3)
			{
				num3 = -1f;
			}
			float num4;
			if (num2 != num3)
			{
				mScroll = 0f;
				num4 = 0f;
			}
			else
			{
				num4 = mScroll;
			}
			float num5 = delta * scrollWheelFactor;
			float num6 = num4 + num5;
			mScroll = num6;
		}
	}

	private unsafe void LateUpdate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_092d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0932: Expected Ref, but got Unknown
		//IL_00ee: Expected I, but got Obj
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_0108: Expected I, but got Obj
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_0b2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b33: Expected Ref, but got Unknown
		//IL_0b44: Expected Obj, but got VT
		//IL_0b61: Expected Obj, but got I
		//IL_0b8b: Expected Obj, but got I
		//IL_0bab: Invalid comparison between Obj and F4
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected VT, but got Unknown
		//IL_039a: Expected Obj, but got I
		//IL_03aa: Expected Obj, but got I
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Expected Obj, but got Unknown
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Expected Obj, but got Unknown
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected VT, but got Unknown
		//IL_098d: Expected Obj, but got VT
		//IL_09aa: Expected Obj, but got I
		//IL_09d4: Expected Obj, but got I
		//IL_09f4: Invalid comparison between Obj and F4
		//IL_0a0e: Expected Obj, but got I4
		//IL_0643: Expected F4, but got I
		//IL_063e: Expected native int or pointer, but got VT
		//IL_0665: Expected F4, but got I
		//IL_0660: Expected native int or pointer, but got VT
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected VT, but got Unknown
		//IL_0420: Expected Obj, but got I
		//IL_0430: Expected Obj, but got I
		//IL_0c95: Expected I, but got Obj
		//IL_0cbb: Expected Ref, but got VT
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected VT, but got Unknown
		//IL_04b7: Expected Obj, but got I
		//IL_04c7: Expected Obj, but got I
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected VT, but got Unknown
		//IL_0576: Expected Obj, but got I
		//IL_0586: Expected Obj, but got I
		//IL_0c36: Expected Obj, but got I4
		//IL_0be3: Expected I, but got Obj
		//IL_0c09: Expected Ref, but got VT
		//IL_0841: Invalid comparison between I and F4
		//IL_07cc: Invalid comparison between VT and F4
		object obj = default;
		Vector3 vector = (Vector3)(obj - 176);
		_ = 0;
		_ = 0;
		if (!Application.isPlaying)
		{
			return;
		}
		float unscaledDeltaTime = Time.unscaledDeltaTime;
		if (showScrollBars == ShowCondition.Always || (!verticalScrollBar && !horizontalScrollBar))
		{
			goto IL_0265;
		}
		object obj7;
		if (showScrollBars == ShowCondition.WhenDragging && mDragID == -10)
		{
			object obj2 = mMomentum * mMomentum;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+90]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+90]");
			object obj3 = num * 0;
			object obj4 = obj2 + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+94]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+94]");
			object obj5 = num2 * 0;
			object obj6 = obj4 + obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.01f);
			bool flag2 = !flag;
			obj7 = 0;
			if (flag2)
			{
				goto IL_0a1c;
			}
		}
		nint num3 = (nint)this;
		object obj8 = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v229 @ S1_v148 (Il2CppClass<UIScrollView>)+EC] (should have been resolved before IL gen)");
		nint num4 = (nint)this;
		object obj9 = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v240 @ S1_v152 (Il2CppClass<UIScrollView>)+E4] (should have been resolved before IL gen)");
		object obj10 = default;
		obj7 = obj10;
		goto IL_0a1c;
		IL_0c26:
		object obj11 = movement - 1;
		bool flag3 = movement == Movement.Vertical;
		bool flag4 = true;
		bool vertical;
		if (!flag3)
		{
			bool flag5 = (nint)obj11 == 1;
			flag4 = true;
			if (!flag5)
			{
				if ((nint)obj11 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+34]");
					vertical = 0f != 0f;
					goto IL_0c6b;
				}
				flag4 = false;
			}
		}
		vertical = flag4;
		goto IL_0c6b;
		IL_0a1c:
		if ((bool)verticalScrollBar)
		{
			float alpha = verticalScrollBar.alpha;
			object obj12 = default;
			float num5;
			if (obj12 != null)
			{
				num5 = unscaledDeltaTime * 6f;
			}
			else
			{
				float num6 = 0f - unscaledDeltaTime;
				num5 = num6 * 3f;
			}
			float num7 = alpha + num5;
			float alpha2 = verticalScrollBar.alpha;
			float num8 = Math.Min(num7, 1f);
			bool flag6 = num7 < 0f;
			float num9 = 0f;
			if (!flag6)
			{
				num9 = num8;
			}
			if (alpha2 != num9)
			{
				verticalScrollBar.alpha = num9;
			}
		}
		if ((bool)horizontalScrollBar)
		{
			float alpha3 = horizontalScrollBar.alpha;
			float num10;
			if (obj7 != null)
			{
				num10 = unscaledDeltaTime * 6f;
			}
			else
			{
				float num11 = 0f - unscaledDeltaTime;
				num10 = num11 * 3f;
			}
			float num12 = alpha3 + num10;
			float alpha4 = horizontalScrollBar.alpha;
			float num13 = Math.Min(num12, 1f);
			bool flag7 = num12 < 0f;
			float num14 = 0f;
			if (!flag7)
			{
				num14 = num13;
			}
			if (alpha4 != num14)
			{
				horizontalScrollBar.alpha = num14;
			}
		}
		goto IL_0265;
		IL_0c6b:
		bool horizontal;
		bool flag8 = RestrictWithinBounds(instant: false, horizontal, vertical);
		goto IL_085d;
		IL_0c19:
		bool flag9;
		horizontal = flag9;
		goto IL_0c26;
		IL_0265:
		if (~(mShouldMove ? 1u : 0u) != 0)
		{
			return;
		}
		if (~(mPressed ? 1u : 0u) == 0)
		{
			mScroll = 0f;
			Vector3 vector2 = NGUIMath.SpringDampen(ref *(Vector3*)(this + 140), 9f, unscaledDeltaTime);
			return;
		}
		ref Vector3 velocity = ref *(Vector3*)(this + 140);
		object obj13 = mMomentum * mMomentum;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+90]");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+90]");
		object obj14 = num15 * 0;
		object obj15 = obj13 + obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+94]");
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+94]");
		object obj16 = num16 * 0;
		object obj17 = obj15 + obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.0001f) || mScroll != 0f)
		{
			Vector3 vector4;
			object obj18;
			object obj19;
			if (movement != Movement.Horizontal)
			{
				if (movement != Movement.Vertical)
				{
					if (movement == Movement.Unrestricted)
					{
						float num17 = mScroll * 0.05f;
						_ = 0;
						_ = 0;
						float num18 = mScroll * 0.05f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
						_ = 0;
						Vector3 direction = vector - -64;
						Vector3 vector3 = mTrans.TransformDirection(direction);
						vector4 = mMomentum;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+90]");
						obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+94]");
						obj19 = 0;
					}
					else
					{
						float num19 = mScroll * (float)customMovement;
						float num20 = num19 * 0.05f;
						float num21 = mScroll;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+34]");
						float num22 = num21 * 0f;
						float num23 = num22 * 0.05f;
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
						_ = 0;
						Vector3 direction2 = vector + 16;
						Vector3 vector5 = mTrans.TransformDirection(direction2);
						vector4 = mMomentum;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+90]");
						obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+94]");
						obj19 = 0;
					}
				}
				else
				{
					float num24 = mScroll * 0.05f;
					_ = 0;
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
					_ = 0;
					Vector3 direction3 = vector + 48;
					Vector3 vector6 = mTrans.TransformDirection(direction3);
					vector4 = mMomentum;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+90]");
					obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+94]");
					obj19 = 0;
				}
			}
			else
			{
				float num25 = mScroll * 0.05f;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				_ = 0;
				Vector3 direction4 = vector + 32;
				Vector3 vector7 = mTrans.TransformDirection(direction4);
				vector4 = mMomentum;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+90]");
				obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+94]");
				obj19 = 0;
			}
			object obj20 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+94]");
			object obj21 = obj20 - 0;
			object obj22 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			object obj23 = obj22 - 0;
			Vector3 vector8 = vector4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			Vector3 vector9 = vector8 - 0;
			mMomentum = vector9;
			float num26 = NGUIMath.SpringLerp(mScroll, 0f, 20f, unscaledDeltaTime);
			mScroll = num26;
			Vector3 vector10 = NGUIMath.SpringDampen(ref velocity, dampenStrength, unscaledDeltaTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			((Vector3*)(nint)vector)->x = 0f;
			MoveAbsolute(vector);
			if (~(restrictWithinPanel ? 1u : 0u) == 0)
			{
				UIPanel uIPanel = mPanel;
				if (uIPanel.mClipping != UIDrawCall.Clipping.None)
				{
					if (!NGUITools.GetActive(centerOnChild))
					{
						bool flag10 = movement == Movement.Horizontal;
						flag9 = true;
						if (!flag10)
						{
							if (movement != Movement.Vertical)
							{
								bool flag11 = movement == Movement.Unrestricted;
								flag9 = true;
								if (flag11)
								{
									goto IL_0c19;
								}
								if (movement == Movement.Custom)
								{
									horizontal = customMovement != (Vector2)(object)0f;
									goto IL_0c26;
								}
							}
							flag9 = false;
						}
						goto IL_0c19;
					}
					UICenterOnChild uICenterOnChild = centerOnChild;
					if (uICenterOnChild.nextPageThreshold == 0f)
					{
						uICenterOnChild.Recenter();
					}
					else
					{
						nint num27 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ S0_v100 (Il2CppClass<UnityEngine.Vector3>)+5C]");
						nint num28 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ S0_v101 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
						_ = 0;
						velocity = ref *(Vector3*)Vector3.zeroVector;
						mScroll = 0f;
					}
				}
			}
			goto IL_085d;
		}
		mScroll = 0f;
		nint num29 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ S0_v192 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ S0_v193 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		velocity = ref *(Vector3*)Vector3.zeroVector;
		SpringPanel component = GetComponent<SpringPanel>();
		if (!(component != null) || !component.enabled)
		{
			mShouldMove = false;
			OnDragNotification onDragNotification = onStoppedMoving;
			if (onStoppedMoving != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v611.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
		return;
		IL_085d:
		OnDragNotification onDragNotification2 = onMomentumMove;
		if (onMomentumMove != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v645.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void OnPan(Vector2 delta)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_007f: Expected Obj, but got F4
		//IL_00ff: Invalid comparison between VT and F4
		//IL_012f: Invalid comparison between I and F4
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected VT, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		if (horizontalScrollBar != null)
		{
			_ = delta.x;
			_ = delta.x;
			object obj3 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @684");
		}
		if (verticalScrollBar != null)
		{
			obj = delta.x;
			_ = delta.x;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @684");
		}
		if (!(horizontalScrollBar == null) || !(verticalScrollBar == null))
		{
			return;
		}
		Vector2 vector;
		if (scale == (Vector3)(object)0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIScrollView)+54]");
			if (0f == 0f)
			{
				return;
			}
			vector = delta + 4;
		}
		else
		{
			vector = delta;
		}
		Scroll(vector.x);
	}

	public UIScrollView()
	{
		//IL_000b: Expected VT, but got I4
		//IL_001a: Expected I4, but got I8
		//IL_0092: Expected I, but got Obj
		_ = 0;
		_ = 0;
		relativePositionOnReset = Vector2.zeroVector;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v21 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		mMomentum = Vector3.zeroVector;
		mDragID = -10;
		mDragStartOffset = Vector2.zeroVector;
		base._002Ector();
	}

	static UIScrollView()
	{
		BetterList<UIScrollView> betterList = default;
		list = betterList;
	}
}

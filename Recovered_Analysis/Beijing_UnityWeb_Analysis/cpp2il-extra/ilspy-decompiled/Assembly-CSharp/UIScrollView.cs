using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

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

	public DragEffect dragEffect;

	public bool restrictWithinPanel;

	public bool constrainOnDrag;

	public bool disableDragIfFits;

	public bool smoothDragStart;

	public bool iOSDragEmulation;

	public float scrollWheelFactor;

	public float momentumAmount;

	public float dampenStrength;

	public UIProgressBar horizontalScrollBar;

	public UIProgressBar verticalScrollBar;

	public ShowCondition showScrollBars;

	public Vector2 customMovement;

	public UIWidget.Pivot contentPivot;

	public OnDragNotification onDragStarted;

	public OnDragNotification onDragFinished;

	public OnDragNotification onMomentumMove;

	public OnDragNotification onStoppedMoving;

	private Vector3 scale;

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

	public UIPanel panel
	{
		get
		{
			//IL_0067: Expected Obj, but got I4
			//IL_0047: Expected I4, but got Obj
			Movement movement = this.movement;
			bool flag;
			if (this.movement != Movement.Horizontal)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (UIScrollView+Movement)+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				UnityEngine.Object obj = UnityEngine.Object.Instantiate((UnityEngine.Object)this);
				return (UIPanel)(object)string.ConcatArray((string[])(object)"NGUI State: ", (int)obj);
			}
			return (UIPanel)this.movement;
		}
	}

	public bool isDragging
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)mPanel != 0;
		}
	}

	public virtual Bounds bounds
	{
		get
		{
			//IL_0403: Expected Obj, but got VT
			//IL_00b1: Expected I, but got Obj
			//IL_00c7: Expected Obj, but got I
			//IL_00f2: Expected I, but got Obj
			//IL_0188: Expected I, but got Obj
			//IL_019e: Expected Obj, but got I
			//IL_046c: Expected Obj, but got VT
			//IL_01c9: Expected I, but got Obj
			//IL_025f: Expected I, but got Obj
			//IL_0275: Expected Obj, but got I
			//IL_04c7: Expected Obj, but got VT
			//IL_02a0: Expected I, but got Obj
			//IL_0336: Expected I, but got Obj
			//IL_034c: Expected Obj, but got I
			//IL_0525: Expected Obj, but got VT
			//IL_0377: Expected I, but got Obj
			//IL_0583: Expected Obj, but got VT
			Bounds bounds = default;
			if (((Behaviour)bounds).isActiveAndEnabled)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Bounds)+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Bounds)+20]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Bounds)+20]");
						if ((nint)0 != 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Bounds)+20]");
							if ((nint)0 == 3)
							{
								object obj = this;
								nint num = (nint)typeof(Mathf);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v68 (Il2CppClass<UnityEngine.Mathf>)+BA]");
								object obj2 = (nint)0 & (nint)0x200;
								if (obj2 != null)
								{
									nint num2 = (nint)typeof(Mathf);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v74 (Il2CppClass<UnityEngine.Mathf>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Bounds)+1C]");
								float num3 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
								float num4 = num3 - 0f;
								if (num4 < 0f)
								{
									num4 = 0f;
								}
								else if (num4 > 1f)
								{
									num4 = 1f;
								}
								((UIProgressBar)bounds).alpha = num4;
							}
						}
						else
						{
							object obj = this;
							nint num5 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v52 (Il2CppClass<UnityEngine.Mathf>)+BA]");
							object obj3 = (nint)0 & (nint)0x200;
							if (obj3 != null)
							{
								nint num6 = (nint)typeof(Mathf);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v58 (Il2CppClass<UnityEngine.Mathf>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Bounds)+1C]");
							float num7 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
							float num8 = num7 + 0f;
							if (num8 < 0f)
							{
								num8 = 0f;
							}
							else if (num8 > 1f)
							{
								num8 = 1f;
							}
							((UIProgressBar)bounds).alpha = num8;
						}
					}
					else
					{
						object obj = this;
						nint num9 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v36 (Il2CppClass<UnityEngine.Mathf>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						if (obj4 != null)
						{
							nint num10 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v42 (Il2CppClass<UnityEngine.Mathf>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Bounds)+1C]");
						float num11 = 0f - (float)obj;
						if (num11 < 0f)
						{
							num11 = 0f;
						}
						else if (num11 > 1f)
						{
							num11 = 1f;
						}
						((UIProgressBar)bounds).alpha = num11;
					}
				}
				else
				{
					object obj = this;
					nint num12 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v20 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num13 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v26 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Bounds)+1C]");
					float num14 = 0f + (float)obj;
					if (num14 < 0f)
					{
						num14 = 0f;
					}
					else if (num14 > 1f)
					{
						num14 = 1f;
					}
					((UIProgressBar)bounds).alpha = num14;
				}
			}
			return bounds;
		}
	}

	public bool canMoveHorizontally
	{
		get
		{
			if (~(mPressed ? 1u : 0u) == 0)
			{
				return mDragStarted;
			}
			return false;
		}
	}

	public bool canMoveVertically
	{
		get
		{
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Expected Obj, but got Unknown
			//IL_0095: Invalid comparison between Obj and F4
			if (movement != Movement.Horizontal)
			{
				if (movement == Movement.Unrestricted)
				{
					return true;
				}
				if (movement == Movement.Custom)
				{
					object obj = this + 52;
					return obj != (object)0f;
				}
				return false;
			}
			return true;
		}
	}

	public virtual bool shouldMoveHorizontally
	{
		get
		{
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected Obj, but got Unknown
			//IL_00b6: Invalid comparison between I and F4
			if (movement == Movement.Vertical)
			{
				return true;
			}
			if (movement == Movement.Unrestricted)
			{
				return true;
			}
			if (movement == Movement.Custom)
			{
				object obj = this + 52;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13+4]");
				return 0f != 0f;
			}
			return false;
		}
	}

	public virtual bool shouldMoveVertically
	{
		get
		{
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Expected Obj, but got Unknown
			//IL_00ac: Expected Obj, but got I4
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected Obj, but got Unknown
			//IL_012d: Expected F4, but got Obj
			//IL_0158: Expected I, but got Obj
			//IL_016e: Expected Obj, but got I
			//IL_001c: Expected Obj, but got VT
			//IL_0056: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 40;
			obj = 0;
			_ = 0;
			_ = 0;
			object obj3 = obj2 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
			UIPanel uIPanel = mPanel;
			bool flag = uIPanel.mClipping == UIDrawCall.Clipping.SoftClip;
			bool flag2 = !flag;
			float num = (float)obj2;
			if (!flag2)
			{
				UIPanel uIPanel2 = mPanel;
				obj3 = uIPanel2.mClipSoftness;
				float num2 = (float)obj3 * 2f;
				float num3 = (float)obj2 + num2;
				num = num3;
			}
			float height = mPanel.height;
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v29 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num5 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v37 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float width = num - height;
			GUILayoutOption gUILayoutOption = GUILayout.Width(width);
			return (nint)gUILayoutOption > 0;
		}
	}

	protected virtual bool shouldMove
	{
		get
		{
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected Obj, but got Unknown
			//IL_00bc: Expected Obj, but got I4
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Expected Obj, but got Unknown
			//IL_0145: Expected F4, but got I
			//IL_0170: Expected I, but got Obj
			//IL_0186: Expected Obj, but got I
			//IL_001c: Expected Obj, but got VT
			//IL_0066: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 40;
			obj = 0;
			_ = 0;
			_ = 0;
			object obj3 = obj2 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
			UIPanel uIPanel = mPanel;
			bool flag = uIPanel.mClipping == UIDrawCall.Clipping.SoftClip;
			bool flag2 = !flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			float num = 0f;
			if (!flag2)
			{
				UIPanel uIPanel2 = mPanel;
				obj3 = uIPanel2.mClipSoftness;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+4]");
				float num2 = 0f * 2f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				float num3 = 0f + num2;
				num = num3;
			}
			float pixelSizeAdjustment = ((UIRoot)(object)mPanel).pixelSizeAdjustment;
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v29 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num5 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v37 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float width = num - pixelSizeAdjustment;
			GUILayoutOption gUILayoutOption = GUILayout.Width(width);
			return (nint)gUILayoutOption > 0;
		}
	}

	public unsafe Vector3 currentMomentum
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected Obj, but got Unknown
			//IL_00e0: Expected F4, but got Obj
			//IL_00db: Expected native int or pointer, but got VT
			//IL_00f5: Expected F4, but got I
			//IL_00f0: Expected native int or pointer, but got VT
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected Obj, but got Unknown
			//IL_006b: Expected VT, but got Obj
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 24;
			if (~(mCalculatedBounds ? 1u : 0u) != 0)
			{
				mCalculatedBounds = true;
				object obj3 = this + 100;
				GameObject gameObject = base.gameObject;
				obj3 = gameObject;
				Vector2 vector = NGUIMath.ScreenToPixels((Vector2)mTrans, mTrans);
				obj = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
				_ = 0;
				object obj4 = this + 156;
				obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+10]");
				_ = 0;
			}
			object obj5 = this + 156;
			Vector3 vector2 = default;
			((Vector3*)(nint)vector2)->x = (float)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v5+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v5+10]");
			_ = 0;
			return vector2;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = value + 140;
			UIScrollView uIScrollView = (UIScrollView)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
	}

	private void Awake()
	{
		//IL_000b: Expected VT, but got F4
		scale = (Vector3)1f;
		_ = 2;
		((UISoundVolume)this).Awake();
	}

	private unsafe void OnEnable()
	{
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected Obj, but got Unknown
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected Obj, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected Obj, but got Unknown
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected VT, but got Unknown
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected Obj, but got Unknown
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected Obj, but got Unknown
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Expected Obj, but got Unknown
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected Obj, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_00a3: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got I
		//IL_00e3: Invalid comparison between Obj and F4
		//IL_0290: Expected Obj, but got VT
		//IL_029e: Expected I, but got Obj
		//IL_02b4: Expected Obj, but got I
		//IL_057a: Expected F4, but got Obj
		//IL_0575: Expected native int or pointer, but got VT
		//IL_058f: Expected Ref, but got VT
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_0116: Invalid comparison between Obj and F4
		//IL_02df: Expected I, but got Obj
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_0184: Invalid comparison between Obj and F4
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected Obj, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected Obj, but got Unknown
		//IL_033d: Expected native int or pointer, but got VT
		//IL_034f: Expected F4, but got Obj
		//IL_034a: Expected native int or pointer, but got VT
		//IL_036f: Expected native int or pointer, but got VT
		//IL_0381: Expected Obj, but got F4
		//IL_0392: Expected VT, but got Obj
		//IL_03a0: Expected I4, but got Obj
		//IL_03ae: Expected I, but got Obj
		//IL_03c4: Expected Obj, but got I
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected Obj, but got Unknown
		//IL_053d: Invalid comparison between Obj and F4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_0149: Invalid comparison between I and F4
		//IL_05c7: Expected VT, but got Obj
		//IL_0684: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Expected Obj, but got Unknown
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected Obj, but got Unknown
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Expected Obj, but got Unknown
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b2: Expected Obj, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_01bf: Invalid comparison between I and F4
		//IL_03ef: Expected I, but got Obj
		//IL_04f6: Expected I, but got Obj
		//IL_050c: Expected Obj, but got I
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		//IL_020a: Invalid comparison between I and F4
		//IL_0644: Expected Obj, but got F4
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Expected Obj, but got Unknown
		//IL_0247: Expected I, but got Obj
		object obj = this + 100;
		GameObject gameObject = base.gameObject;
		obj = gameObject;
		object obj2 = this + 104;
		UIPanel component = GetComponent<UIPanel>();
		obj2 = component;
		UIPanel uIPanel = mPanel;
		if (uIPanel.mClipping == UIDrawCall.Clipping.None)
		{
			UIPanel uIPanel2 = mPanel;
			if (uIPanel2.mClipping != UIDrawCall.Clipping.ConstrainButDontClip)
			{
				uIPanel2.mResized = true;
				uIPanel2.mClipping = UIDrawCall.Clipping.ConstrainButDontClip;
				uIPanel2.mMatrixFrame = -1;
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 52;
		Vector4 vector = (Vector4)(obj4 + 40);
		if (movement != Movement.Custom)
		{
			object obj5 = this + 80;
			object obj6 = obj5 * obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v79+4]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v79+4]");
			object obj7 = num * 0;
			object obj8 = obj6 + obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v79+8]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v79+8]");
			object obj9 = num2 * 0;
			object obj10 = obj8 + obj9;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.001f))
			{
				object obj11 = this + 80;
				if (obj11 == (object)1f)
				{
					object obj12 = this + 80;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v132+4]");
					if (0f == 0f)
					{
						movement = Movement.Horizontal;
						goto IL_04e8;
					}
				}
				object obj13 = this + 80;
				if (obj13 == (object)0f)
				{
					object obj14 = this + 80;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v127+4]");
					if (0f == 1f)
					{
						movement = Movement.Vertical;
						goto IL_04e8;
					}
				}
				object obj15 = this + 80;
				if (obj15 == (object)1f)
				{
					object obj16 = this + 80;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S0_v122+4]");
					if (0f == 1f)
					{
						movement = Movement.Unrestricted;
						goto IL_04e8;
					}
				}
				movement = Movement.Custom;
				object obj17 = this + 52;
				object obj18 = this + 80;
				obj17 = obj18;
				object obj19 = this + 52;
				object obj20 = this + 80;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S1_v86+4]");
				_ = 0;
				goto IL_04e8;
			}
		}
		goto IL_05cc;
		IL_04e8:
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S0_v91 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S0_v101 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		obj3 = vector.x;
		_ = vector.z;
		object obj22 = this + 80;
		obj22 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v18 (System.Object)+8]");
		_ = 0;
		goto IL_05cc;
		IL_05cc:
		object obj23 = obj4 + 32;
		object obj24 = obj4 + 24;
		object obj25 = obj4 + 16;
		object obj26 = obj4 + 8;
		if (contentPivot != UIWidget.Pivot.TopLeft)
		{
			return;
		}
		obj4 = relativePositionOnReset;
		nint num5 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v40 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj27 = (nint)0 & (nint)0x200;
		if (obj27 != null)
		{
			nint num6 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v74 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 one2 = Vector2.one;
		obj23 = obj4;
		((Vector4*)(nint)vector)->x = (float)obj23;
		obj3 = obj24;
		if (!((Vector4*)vector)->Equals(obj3))
		{
			return;
		}
		object obj28 = this + 92;
		object obj29 = this + 92;
		((Vector4*)(nint)vector)->x = 0f;
		((Vector4*)(nint)vector)->x = (float)obj28;
		float num7 = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S0_v54+4]");
		float y = num7 - 0f;
		((Vector4*)(nint)vector)->y = y;
		obj25 = vector.x;
		obj3 = obj25;
		string text = NGUIText.EncodeColor((Color)obj3);
		contentPivot = (UIWidget.Pivot)text;
		nint num8 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S0_v63 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj30 = (nint)0 & (nint)0x200;
		if (obj30 != null)
		{
			nint num9 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ S0_v70 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 one3 = Vector2.one;
		obj3 = obj26;
		relativePositionOnReset = (Vector2)obj3;
	}

	private void Start()
	{
		//IL_0091: Expected I, but got Obj
		//IL_00a7: Expected Obj, but got I
		//IL_00d0: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIScrollView);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScrollView>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScrollView);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<UIScrollView>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((BetterList<>)(object)list).RemoveAt((int)this);
		if (~(mStarted ? 1u : 0u) == 0 && Application.platform != RuntimePlatform.OSXEditor)
		{
			OnDisable();
		}
	}

	private void CheckScrollbars()
	{
		mStarted = true;
		if (Application.platform != RuntimePlatform.OSXEditor)
		{
			OnDisable();
		}
	}

	private unsafe void OnDisable()
	{
		//IL_029d: Expected I, but got Obj
		//IL_02b3: Expected Obj, but got I
		//IL_0137: Expected I, but got Obj
		//IL_014d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_00a9: Expected I, but got Obj
		//IL_00bf: Expected Obj, but got I
		//IL_0178: Expected I, but got Obj
		//IL_02fb: Expected Obj, but got I4
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		//IL_020e: Expected I, but got Obj
		//IL_0224: Expected Obj, but got I
		//IL_00ea: Expected I, but got Obj
		//IL_0358: Expected Obj, but got I4
		//IL_024f: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v56 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)horizontalScrollBar).FindKernel((string)null) != 0)
		{
			UIProgressBar uIProgressBar = horizontalScrollBar;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			EventDelegate.Callback callback = default;
			((Delegate)callback).method_ptr = method_ptr;
			((Delegate)callback).method = (nint)__ldftn(UIScrollView.OnScrollBar);
			object obj2 = callback + 16;
			obj2 = this;
			nint num3 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v45 (Il2CppClass<EventDelegate>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(EventDelegate);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S1_v52 (Il2CppClass<EventDelegate>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = EventDelegate.Remove(uIProgressBar.onChange, callback);
			((GameObject)(object)horizontalScrollBar)._002Ector("CacheDefaultColor", (Type[])1);
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v34 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)verticalScrollBar).FindKernel((string)null) == 0)
		{
			return;
		}
		UIProgressBar uIProgressBar2 = verticalScrollBar;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		EventDelegate.Callback callback2 = default;
		((Delegate)callback2).method_ptr = method_ptr2;
		((Delegate)callback2).method = (nint)__ldftn(UIScrollView.OnScrollBar);
		object obj5 = callback2 + 16;
		obj5 = this;
		nint num7 = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v23 (Il2CppClass<EventDelegate>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num8 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v30 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = EventDelegate.Remove(uIProgressBar2.onChange, callback2);
		((GameObject)(object)verticalScrollBar)._002Ector("CacheDefaultColor", (Type[])1);
	}

	public bool RestrictWithinBounds(bool instant)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_0054: Expected Obj, but got I4
		//IL_00d3: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		object obj3 = obj2 + 4;
		if ((instant ? 1 : 0) == 4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			throw new NullReferenceException();
		}
		obj3 = instant;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string text3 = default;
		string text = text2 + "+" + text3;
		string text4 = text;
		return (byte)(int)text4 != 0;
	}

	public bool RestrictWithinBounds(bool instant, bool horizontal, bool vertical)
	{
		return vertical;
	}

	public void DisableSpring()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIScrollView);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScrollView>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScrollView);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<UIScrollView>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = ((BetterList<>.CompareFunc)(object)list).EndInvoke((IAsyncResult)this);
		mPressed = false;
	}

	public void UpdateScrollbars()
	{
		//IL_007a: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		SpringPanel component = GetComponent<SpringPanel>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			component.tag = null;
		}
	}

	public unsafe virtual void UpdateScrollbars(bool recalculateBounds)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		object obj = ((bool*)(recalculateBounds ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [recalculateBounds @ L1 (System.Boolean)+8]");
		_ = 0;
		object obj2 = this + 140;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		mShouldMove = true;
	}

	protected void UpdateScrollbars(UIProgressBar slider, float contentMin, float contentMax, float contentSize, float viewSize, bool inverted)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public virtual void SetDragAmount(float x, float y, bool updateScrollbars)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public void InvalidateBounds()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
	}

	public void ResetPosition()
	{
		mCalculatedBounds = false;
	}

	public void UpdatePosition()
	{
		//IL_00e9: Expected I, but got Obj
		//IL_00ff: Expected Obj, but got I
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_006c: Expected Obj, but got I4
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v37 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Transform transform = (Transform)(obj2 + 32);
		object obj3 = obj2 + 24;
		object obj4 = obj2 + 16;
		object obj5 = obj2 + 8;
		if (NGUITools.GetActive((GameObject)(object)this))
		{
			mCalculatedBounds = false;
			NGUIMath.OverlayPosition(transform, (Transform)contentPivot);
			obj3 = transform;
			obj4 = transform;
			float num3 = 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v18+4]");
			float num4 = num3 - 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8D60");
			obj5 = transform;
			obj2 = transform;
			float num5 = 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			float num6 = num5 - 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8D60");
		}
	}

	public void OnScrollBar()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0146: Expected Obj, but got I4
		//IL_0154: Expected I, but got Obj
		//IL_016a: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_0200: Expected I, but got Obj
		//IL_0195: Expected I, but got Obj
		//IL_0350: Expected I, but got Obj
		//IL_0366: Expected Obj, but got I
		//IL_01eb: Expected I, but got F4
		//IL_00e2: Expected I, but got Obj
		//IL_0213: Expected I, but got Obj
		if (~(mIgnoreCallbacks ? 1u : 0u) == 0)
		{
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v42 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)horizontalScrollBar).FindKernel((string)null) == 0)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v38 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)verticalScrollBar).FindKernel((string)null) == 0)
			{
				return;
			}
		}
		mIgnoreCallbacks = true;
		mCalculatedBounds = false;
		Transform transform = default;
		NGUIMath.OverlayPosition(transform, (Transform)contentPivot);
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)horizontalScrollBar).FindKernel((string)null) != 0)
		{
			float alpha = horizontalScrollBar.alpha;
			nint num7 = (nint)alpha;
		}
		else
		{
			transform = transform;
			nint num7 = (nint)transform;
		}
		nint num8 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v30 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v37 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)verticalScrollBar).FindKernel((string)null) != 0)
		{
			float alpha2 = verticalScrollBar.alpha;
		}
		else
		{
			transform = transform;
			float num10 = 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
			float alpha2 = num10 - 0f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8D60");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		mIgnoreCallbacks = false;
	}

	public unsafe virtual void MoveRelative(Vector3 relative)
	{
		//IL_071c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0721: Expected Obj, but got Unknown
		//IL_072a: Expected Obj, but got I4
		//IL_073f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Expected Obj, but got Unknown
		//IL_074d: Expected Obj, but got I4
		//IL_075c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0761: Expected Obj, but got Unknown
		//IL_076a: Expected Obj, but got I4
		//IL_0779: Unknown result type (might be due to invalid IL or missing references)
		//IL_077e: Expected Obj, but got Unknown
		//IL_0787: Expected Obj, but got I4
		//IL_0796: Unknown result type (might be due to invalid IL or missing references)
		//IL_079b: Expected Obj, but got Unknown
		//IL_07a4: Expected Obj, but got I4
		//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b8: Expected Obj, but got Unknown
		//IL_07c1: Expected Obj, but got I4
		//IL_07d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d5: Expected Obj, but got Unknown
		//IL_07de: Expected Obj, but got I4
		//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f2: Expected Obj, but got Unknown
		//IL_07fb: Expected Obj, but got I4
		//IL_080a: Unknown result type (might be due to invalid IL or missing references)
		//IL_080f: Expected Obj, but got Unknown
		//IL_0818: Expected Obj, but got I4
		//IL_082c: Expected I, but got Obj
		//IL_0842: Expected Obj, but got I
		//IL_0c87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8c: Expected VT, but got Unknown
		//IL_0c95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected Obj, but got Unknown
		//IL_0ca3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca8: Expected Obj, but got Unknown
		//IL_0cb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb6: Expected Obj, but got Unknown
		//IL_0cbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc4: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_08a0: Invalid comparison between VT and I4
		//IL_00a1: Expected I, but got Obj
		//IL_0d3c: Expected I, but got Obj
		//IL_0d52: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_08fa: Expected F4, but got Obj
		//IL_08f5: Expected native int or pointer, but got VT
		//IL_092b: Expected F4, but got Obj
		//IL_0926: Expected native int or pointer, but got VT
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected I4, but got Unknown
		//IL_0228: Expected I, but got Obj
		//IL_023e: Expected Obj, but got I
		//IL_01db: Expected I, but got Obj
		//IL_012f: Expected I, but got Obj
		//IL_0177: Invalid comparison between VT and I4
		//IL_0985: Expected I, but got Obj
		//IL_099b: Expected Obj, but got I
		//IL_0269: Expected I, but got Obj
		//IL_02b5: Expected F4, but got Obj
		//IL_02b0: Expected native int or pointer, but got VT
		//IL_02ca: Invalid comparison between F4 and Obj
		//IL_04c1: Expected I, but got Obj
		//IL_050d: Expected F4, but got Obj
		//IL_0508: Expected native int or pointer, but got VT
		//IL_052a: Invalid comparison between F4 and I
		//IL_0305: Expected Obj, but got F4
		//IL_0320: Expected I, but got Obj
		//IL_0336: Expected Obj, but got I
		//IL_09c9: Expected F4, but got I
		//IL_09eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f0: Expected Obj, but got Unknown
		//IL_0565: Expected Obj, but got F4
		//IL_0580: Expected I, but got Obj
		//IL_0596: Expected Obj, but got I
		//IL_0361: Expected I, but got Obj
		//IL_0b18: Expected F4, but got I
		//IL_0b3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3f: Expected Obj, but got Unknown
		//IL_0a2b: Expected I, but got Obj
		//IL_0a41: Expected Obj, but got I
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected Obj, but got Unknown
		//IL_05c1: Expected I, but got Obj
		//IL_0b7a: Expected I, but got Obj
		//IL_0b90: Expected Obj, but got I
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected Obj, but got Unknown
		//IL_0400: Expected I, but got Obj
		//IL_0a6b: Expected F4, but got Obj
		//IL_0a66: Expected native int or pointer, but got VT
		//IL_045b: Expected F4, but got VT
		//IL_0456: Expected native int or pointer, but got VT
		//IL_0660: Expected I, but got Obj
		//IL_0bba: Expected F4, but got Obj
		//IL_0bb5: Expected native int or pointer, but got VT
		//IL_06bb: Expected F4, but got VT
		//IL_06b6: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 + 216;
		obj = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj2 + 200;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 184;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 168;
		obj5 = 0;
		_ = 0;
		object obj6 = obj2 + 152;
		obj6 = 0;
		_ = 0;
		object obj7 = obj2 + 136;
		obj7 = 0;
		_ = 0;
		object obj8 = obj2 + 120;
		obj8 = 0;
		_ = 0;
		object obj9 = obj2 + 104;
		obj9 = 0;
		_ = 0;
		object obj10 = obj2 + 88;
		obj10 = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v39 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v200 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 vector = (Vector2)(obj2 + 56);
		object obj12 = obj2 + 32;
		object obj13 = obj2 + 16;
		object obj14 = obj2 + 8;
		object obj15 = obj2 + 72;
		if (mPanel != null)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S1_v40 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S1_v246 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)horizontalScrollBar).FindKernel((string)null) == 0)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S1_v236 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S1_v242 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)verticalScrollBar).FindKernel((string)null) == 0)
			{
				if (relative != (Vector3)(object)0)
				{
					mCalculatedBounds = false;
				}
				return;
			}
		}
		if (relative != (Vector3)(object)0)
		{
			mCalculatedBounds = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj18 = default;
			bool flag = (byte)(obj18 & 1) != 0;
			mShouldMove = flag;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
		obj = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v46+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v46+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
		nint num7 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v69 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num8 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S0_v189 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector2*)(nint)vector)->x = (float)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v48+8]");
		_ = 0;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
		((Vector2*)(nint)vector)->x = (float)obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v52+8]");
		_ = 0;
		Vector3 vector3 = vector;
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S1_v67 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ S1_v231 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)horizontalScrollBar).FindKernel((string)null) != 0)
		{
			((Vector2*)(nint)vector)->x = (float)obj2;
			obj12 = obj14;
			float x = vector.x;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)x) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
			{
				Vector2 clipSoftness = mPanel.clipSoftness;
				obj12 = vector.x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v44 (UnityEngine.Vector2)+8]");
				_ = 0;
				nint num11 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ S1_v168 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj21 = (nint)0 & (nint)0x200;
				if (obj21 != null)
				{
					nint num12 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ S1_v227 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v46+8]");
				GUILayoutOption gUILayoutOption = GUILayout.Width(0f);
				obj4 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v46+8]");
				_ = 0;
				object obj22 = gUILayoutOption & 1;
				GUILayoutOption gUILayoutOption3;
				if (obj22 != null)
				{
					GUILayoutOption gUILayoutOption2 = (GUILayoutOption)(gUILayoutOption - 1);
					obj3 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+8]");
					_ = 0;
					gUILayoutOption3 = gUILayoutOption2;
				}
				else
				{
					obj3 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v46+8]");
					_ = 0;
					gUILayoutOption3 = gUILayoutOption;
				}
				float num13 = (float)gUILayoutOption3 * 0.5f;
				nint num14 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ S1_v181 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj23 = (nint)0 & (nint)0x200;
				if (obj23 != null)
				{
					nint num15 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ S1_v214 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
				UIPanel uIPanel = mPanel;
				obj6 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
				_ = 0;
				float num17 = default;
				float num18;
				if (uIPanel.mClipping == UIDrawCall.Clipping.SoftClip)
				{
					UIPanel uIPanel2 = mPanel;
					((Vector2*)(nint)vector)->x = (float)uIPanel2.mClipSoftness;
					float num16 = num17 - vector.x;
					obj5 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22+8]");
					_ = 0;
					num18 = num16;
				}
				else
				{
					obj5 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
					_ = 0;
					num18 = num17;
				}
				((Vector2*)(nint)vector)->x = (float)obj2;
				obj12 = obj14;
				float num19 = vector.x - (float)obj12;
				obj13 = obj14;
				obj14 = obj2;
				obj15 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19+8]");
				_ = 0;
				float num20 = (float)obj15 - num18;
				float num21 = num20 - (float)obj13;
				float num22 = (float)obj15 + num18;
				float num23 = (float)obj14 - num22;
				float num24 = num18 * 2f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8D5C");
			}
		}
		nint num25 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ S1_v74 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj24 = (nint)0 & (nint)0x200;
		if (obj24 != null)
		{
			nint num26 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ S1_v153 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)verticalScrollBar).FindKernel((string)null) == 0)
		{
			return;
		}
		((Vector2*)(nint)vector)->x = (float)obj2;
		obj12 = obj14;
		float y = vector.y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v46+4]");
		if (!(y > 0f))
		{
			return;
		}
		Vector2 clipSoftness2 = mPanel.clipSoftness;
		obj12 = vector.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v44 (UnityEngine.Vector2)+8]");
		_ = 0;
		nint num27 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ S1_v90 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj25 = (nint)0 & (nint)0x200;
		if (obj25 != null)
		{
			nint num28 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ S1_v149 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v46+C]");
		GUILayoutOption gUILayoutOption4 = GUILayout.Width(0f);
		obj8 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v46+8]");
		_ = 0;
		object obj26 = gUILayoutOption4 & 1;
		GUILayoutOption gUILayoutOption6;
		if (obj26 != null)
		{
			GUILayoutOption gUILayoutOption5 = (GUILayoutOption)(gUILayoutOption4 - 1);
			obj7 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v28+8]");
			_ = 0;
			gUILayoutOption6 = gUILayoutOption5;
		}
		else
		{
			obj7 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v46+8]");
			_ = 0;
			gUILayoutOption6 = gUILayoutOption4;
		}
		float num29 = (float)gUILayoutOption6 * 0.5f;
		nint num30 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ S1_v103 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj27 = (nint)0 & (nint)0x200;
		if (obj27 != null)
		{
			nint num31 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ S1_v136 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
		UIPanel uIPanel3 = mPanel;
		obj10 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v25+8]");
		_ = 0;
		float num33 = default;
		float num34;
		if (uIPanel3.mClipping == UIDrawCall.Clipping.SoftClip)
		{
			UIPanel uIPanel4 = mPanel;
			((Vector2*)(nint)vector)->x = (float)uIPanel4.mClipSoftness;
			float num32 = num33 - vector.y;
			obj9 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v34+8]");
			_ = 0;
			num34 = num32;
		}
		else
		{
			obj9 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v25+8]");
			_ = 0;
			num34 = num33;
		}
		((Vector2*)(nint)vector)->x = (float)obj2;
		obj12 = obj14;
		float num35 = vector.y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v46+4]");
		float num36 = num35 - 0f;
		obj13 = obj14;
		obj14 = obj2;
		obj15 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v31+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v52+4]");
		float num37 = 0f - num34;
		float num38 = num37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v48+4]");
		float num39 = num38 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v52+4]");
		float num40 = 0f + num34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v50+4]");
		float num41 = 0f - num40;
		float num42 = num34 * 2f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8D5C");
	}

	public unsafe void MoveAbsolute(Vector3 absolute)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0074: Expected Obj, but got I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_0091: Expected VT, but got Obj
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00ac: Expected Obj, but got F4
		//IL_00c4: Expected I, but got Obj
		//IL_00da: Expected Obj, but got I
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected VT, but got Unknown
		//IL_0112: Expected F4, but got Obj
		//IL_010d: Expected native int or pointer, but got VT
		//IL_0124: Expected F4, but got I
		//IL_011f: Expected native int or pointer, but got VT
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected VT, but got Unknown
		//IL_013f: Expected F4, but got Obj
		//IL_013a: Expected native int or pointer, but got VT
		//IL_0154: Expected F4, but got I
		//IL_014f: Expected native int or pointer, but got VT
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_0180: Expected F4, but got Obj
		//IL_017b: Expected native int or pointer, but got VT
		//IL_0195: Expected F4, but got I
		//IL_0190: Expected native int or pointer, but got VT
		//IL_019e: Expected Obj, but got VT
		//IL_01b9: Expected Obj, but got VT
		//IL_01c6: Expected native int or pointer, but got VT
		//IL_01d8: Expected native int or pointer, but got VT
		//IL_01f9: Expected Obj, but got F4
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_0222: Expected Obj, but got F4
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected Obj, but got Unknown
		//IL_025e: Expected F4, but got Obj
		//IL_0259: Expected native int or pointer, but got VT
		//IL_026d: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		Transform transform = (Transform)(obj2 + 52);
		transform.localPosition = (Vector3)mTrans;
		object obj3 = obj2 + 40;
		obj3 = absolute.x;
		_ = absolute.z;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v16 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v48 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 - -64);
		((Vector3*)(nint)vector)->x = (float)transform;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		Vector3 vector2 = (Vector3)(obj2 + 76);
		((Vector3*)(nint)vector2)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v13+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj5 = obj2 + 28;
		Vector3 vector3 = vector - vector2;
		((Vector3*)(nint)vector2)->x = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v27+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 eulerAngles = ((Transform)vector2).eulerAngles;
		UIPanel uIPanel = mPanel;
		obj = uIPanel.mClipOffset;
		((Vector3*)(nint)vector)->x = absolute.x;
		((Vector3*)(nint)vector)->z = absolute.z;
		float num3 = (float)obj - vector.x;
		obj = num3;
		object obj6 = obj + 4;
		object obj7 = obj2 + 16;
		obj7 = absolute.x;
		_ = absolute.z;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v41+4]");
		object obj9 = obj8 - 0;
		obj6 = obj9;
		obj2 = obj;
		((Vector3*)(nint)vector2)->x = (float)obj2;
		mPanel.clipTexture = (Texture2D)vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
	}

	public unsafe void Press(bool pressed)
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_0089: Expected Obj, but got I4
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Ref, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected VT, but got Unknown
		//IL_0193: Expected F4, but got Obj
		//IL_018e: Expected native int or pointer, but got VT
		//IL_01a8: Expected F4, but got I
		//IL_01a3: Expected native int or pointer, but got VT
		//IL_01c7: Expected VT, but got Ref
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		obj = 0;
		_ = 0;
		ref Vector3 reference = ref *(Vector3*)(obj2 + 72);
		reference = ref *(((bool*)(pressed ? 1 : 0))->m_value ? ((Vector3*)1) : ((Vector3*)null));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [pressed @ L1 (System.Boolean)+8]");
		_ = 0;
		Transform transform = (Transform)(obj2 + 36);
		transform.Internal_LookAt_Injected(ref *(Vector3*)mTrans, ref reference);
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v23 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v43 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 24;
		Vector3 one = Vector3.one;
		reference = ref *(Vector3*)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v28+8]");
		_ = 0;
		Transform transform2 = (Transform)(obj2 + 12);
		transform2.Internal_LookAt_Injected(ref *(Vector3*)mTrans, ref reference);
		Vector3 vector = (Vector3)(obj2 + 60);
		((Vector3*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector)->z = 0f;
		reference = ref *(Vector3*)transform2;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		Quaternion quaternion = Quaternion.FromToRotation(vector, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
		reference = ref *(Vector3*)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EC");
	}

	public void Drag()
	{
		//IL_001e: Expected I, but got Obj
		//IL_0034: Expected Obj, but got I
		//IL_005f: Expected I, but got Obj
		//IL_018e: Expected I, but got Obj
		//IL_01a4: Expected Obj, but got I
		//IL_00ce: Expected I, but got Obj
		if (~(mIgnoreCallbacks ? 1u : 0u) == 0)
		{
			return;
		}
		mIgnoreCallbacks = true;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)horizontalScrollBar).FindKernel((string)null) != 0)
		{
			float alpha = horizontalScrollBar.alpha;
		}
		else
		{
			float alpha = 0f;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)verticalScrollBar).FindKernel((string)null) != 0)
		{
			float alpha2 = verticalScrollBar.alpha;
		}
		else
		{
			float alpha2 = 0f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8D60");
		mIgnoreCallbacks = false;
	}

	public void Scroll(float delta)
	{
		//IL_0295: Expected I, but got Obj
		//IL_02ab: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_02d2: Invalid comparison between VT and F4
		//IL_00ad: Expected VT, but got F4
		//IL_00b8: Expected Obj, but got I4
		//IL_00c6: Expected I, but got Obj
		//IL_00dc: Expected Obj, but got I
		//IL_0107: Expected I, but got Obj
		//IL_0154: Expected I, but got Obj
		//IL_016a: Expected Obj, but got I
		//IL_0195: Expected I, but got Obj
		//IL_0207: Expected I, but got Obj
		//IL_021d: Expected Obj, but got I
		//IL_0359: Expected Obj, but got I4
		//IL_0248: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v44 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3;
		if (delta < 0f)
		{
			num3 = 0f;
		}
		else
		{
			num3 = ((!(delta > 1f)) ? delta : 1f);
		}
		if (scale == (Vector3)(object)num3)
		{
			return;
		}
		scale = (Vector3)num3;
		verticalScrollBar = (UIProgressBar)1;
		nint num4 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v17 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num5 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v40 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!NGUITools.GetActive((GameObject)(object)this))
		{
			return;
		}
		nint num6 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UIProgressBar.current != null && contentPivot != UIWidget.Pivot.TopLeft)
		{
			UIProgressBar.current = (UIProgressBar)(object)this;
			nint num8 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v21 (Il2CppClass<EventDelegate>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num9 = (nint)typeof(EventDelegate);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v27 (Il2CppClass<EventDelegate>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Localization.dictionary = (Dictionary<string, string[]>)contentPivot;
			UIProgressBar.current = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	private unsafe void LateUpdate()
	{
		//IL_0d20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d25: Expected VT, but got Unknown
		//IL_0d2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d33: Expected VT, but got Unknown
		//IL_0d3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d41: Expected Obj, but got Unknown
		//IL_0d4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4f: Expected Obj, but got Unknown
		//IL_0d58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5d: Expected Obj, but got Unknown
		//IL_0d66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6b: Expected Obj, but got Unknown
		//IL_0d74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d79: Expected Obj, but got Unknown
		//IL_0d82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d87: Expected Obj, but got Unknown
		//IL_0d90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d95: Expected Obj, but got Unknown
		//IL_0d9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da3: Expected Obj, but got Unknown
		//IL_0dac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db1: Expected Obj, but got Unknown
		//IL_0dba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbf: Expected Obj, but got Unknown
		//IL_0dc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcd: Expected Obj, but got Unknown
		//IL_0dd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddb: Expected Obj, but got Unknown
		//IL_0de4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de9: Expected Obj, but got Unknown
		//IL_0df2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df7: Expected Obj, but got Unknown
		//IL_0e00: Expected Obj, but got I4
		//IL_0e15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1a: Expected Obj, but got Unknown
		//IL_0e23: Expected Obj, but got F4
		//IL_0e2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e31: Expected Obj, but got Unknown
		//IL_0e3a: Expected Obj, but got I4
		//IL_0e49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4e: Expected Obj, but got Unknown
		//IL_0e57: Expected Obj, but got I4
		//IL_0e66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6b: Expected Obj, but got Unknown
		//IL_0e74: Expected Obj, but got I4
		//IL_0e83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e88: Expected Obj, but got Unknown
		//IL_0e91: Expected Obj, but got I4
		//IL_0ea6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eab: Expected Obj, but got Unknown
		//IL_0eb4: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00ce: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_010f: Expected I, but got Obj
		//IL_0f45: Expected I, but got Obj
		//IL_0f5b: Expected Obj, but got I
		//IL_019f: Expected I, but got Obj
		//IL_01b5: Expected Obj, but got I
		//IL_1685: Expected I, but got Obj
		//IL_169b: Expected Obj, but got I
		//IL_022d: Expected I, but got Obj
		//IL_01e0: Expected I, but got Obj
		//IL_10f4: Expected F4, but got VT
		//IL_10ef: Expected native int or pointer, but got VT
		//IL_1102: Expected I, but got Obj
		//IL_1118: Expected Obj, but got I
		//IL_160d: Expected Obj, but got F4
		//IL_161a: Expected F4, but got Obj
		//IL_1615: Expected native int or pointer, but got VT
		//IL_1634: Expected F4, but got Obj
		//IL_162f: Expected native int or pointer, but got VT
		//IL_1653: Expected Ref, but got VT
		//IL_0457: Expected I, but got Obj
		//IL_100a: Expected Obj, but got VT
		//IL_1014: Expected Obj, but got VT
		//IL_1022: Expected I, but got Obj
		//IL_1038: Expected Obj, but got I
		//IL_02a9: Expected I, but got Obj
		//IL_02bf: Expected Obj, but got I
		//IL_1080: Expected Obj, but got F4
		//IL_108d: Expected F4, but got Obj
		//IL_1088: Expected native int or pointer, but got VT
		//IL_10ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b2: Expected Obj, but got Unknown
		//IL_04a4: Expected I, but got Obj
		//IL_158a: Expected F4, but got Obj
		//IL_1585: Expected native int or pointer, but got VT
		//IL_1597: Expected F4, but got Obj
		//IL_1592: Expected native int or pointer, but got VT
		//IL_15bd: Expected F4, but got Obj
		//IL_15b8: Expected native int or pointer, but got VT
		//IL_15d7: Expected native int or pointer, but got VT
		//IL_15fb: Expected Ref, but got VT
		//IL_0375: Expected I, but got Obj
		//IL_0fa3: Expected F4, but got VT
		//IL_0f9e: Expected native int or pointer, but got VT
		//IL_0fb0: Expected Obj, but got F4
		//IL_0fbd: Expected F4, but got Obj
		//IL_0fb8: Expected native int or pointer, but got VT
		//IL_0fcc: Expected VT, but got F4
		//IL_0fd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd7: Expected Obj, but got Unknown
		//IL_03c2: Expected I, but got Obj
		//IL_02ea: Expected I, but got Obj
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected Obj, but got Unknown
		//IL_054d: Expected I, but got Obj
		//IL_0563: Expected Obj, but got I
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected Obj, but got Unknown
		//IL_1142: Expected F4, but got Obj
		//IL_113d: Expected native int or pointer, but got VT
		//IL_1159: Expected F4, but got Obj
		//IL_1154: Expected native int or pointer, but got VT
		//IL_1196: Expected F4, but got Obj
		//IL_1191: Expected native int or pointer, but got VT
		//IL_11a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ae: Expected Obj, but got Unknown
		//IL_11bb: Expected Obj, but got F4
		//IL_11d5: Expected F4, but got Obj
		//IL_11d0: Expected native int or pointer, but got VT
		//IL_0660: Expected F4, but got Obj
		//IL_065b: Expected native int or pointer, but got VT
		//IL_068d: Expected Obj, but got F4
		//IL_058e: Expected I, but got Obj
		//IL_05da: Expected F4, but got Obj
		//IL_05d5: Expected native int or pointer, but got VT
		//IL_1233: Expected F4, but got Obj
		//IL_122e: Expected native int or pointer, but got VT
		//IL_1260: Expected Obj, but got F4
		//IL_0619: Expected F4, but got Obj
		//IL_0614: Expected native int or pointer, but got VT
		//IL_0637: Invalid comparison between I and F4
		//IL_08be: Expected I, but got Obj
		//IL_08d4: Expected Obj, but got I
		//IL_073b: Expected F4, but got VT
		//IL_0736: Expected native int or pointer, but got VT
		//IL_0749: Expected I, but got Obj
		//IL_075f: Expected Obj, but got I
		//IL_06ec: Expected Obj, but got F4
		//IL_13e1: Expected native int or pointer, but got VT
		//IL_07c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cb: Expected Obj, but got Unknown
		//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07eb: Expected Obj, but got Unknown
		//IL_082b: Expected I, but got Obj
		//IL_0841: Expected Obj, but got I
		//IL_127f: Expected Obj, but got F4
		//IL_128c: Expected F4, but got Obj
		//IL_1287: Expected native int or pointer, but got VT
		//IL_12a6: Expected F4, but got Obj
		//IL_12a1: Expected native int or pointer, but got VT
		//IL_1393: Unknown result type (might be due to invalid IL or missing references)
		//IL_1398: Expected Obj, but got Unknown
		//IL_13a5: Expected Obj, but got F4
		//IL_08ff: Expected I, but got Obj
		//IL_12cf: Expected F4, but got Obj
		//IL_12ca: Expected native int or pointer, but got VT
		//IL_130c: Expected F4, but got Obj
		//IL_1307: Expected native int or pointer, but got VT
		//IL_1323: Expected F4, but got Obj
		//IL_131e: Expected native int or pointer, but got VT
		//IL_134b: Expected F4, but got Obj
		//IL_1346: Expected native int or pointer, but got VT
		//IL_1365: Expected F4, but got Obj
		//IL_1360: Expected native int or pointer, but got VT
		//IL_078a: Expected I, but got Obj
		//IL_0c49: Expected F4, but got Obj
		//IL_0c44: Expected native int or pointer, but got VT
		//IL_0c60: Expected I4, but got VT
		//IL_089e: Expected F4, but got Obj
		//IL_0899: Expected native int or pointer, but got VT
		//IL_086c: Expected I, but got Obj
		//IL_098f: Expected I, but got Obj
		//IL_09a5: Expected Obj, but got I
		//IL_1405: Expected F4, but got Obj
		//IL_1400: Expected native int or pointer, but got VT
		//IL_0a02: Expected F4, but got Obj
		//IL_09fd: Expected native int or pointer, but got VT
		//IL_0a31: Expected F4, but got Obj
		//IL_0a2c: Expected native int or pointer, but got VT
		//IL_0a3e: Expected F4, but got Obj
		//IL_0a39: Expected native int or pointer, but got VT
		//IL_09d0: Expected I, but got Obj
		//IL_1467: Invalid comparison between Obj and F4
		//IL_0d0e: Expected Obj, but got I4
		//IL_0d0e: Expected Obj, but got I4
		//IL_0b77: Expected F4, but got Obj
		//IL_0b72: Expected native int or pointer, but got VT
		//IL_0b92: Expected I, but got Obj
		//IL_0ba8: Expected Obj, but got I
		//IL_149e: Expected native int or pointer, but got VT
		//IL_14cf: Expected F4, but got Obj
		//IL_14ca: Expected native int or pointer, but got VT
		//IL_14e6: Expected I4, but got VT
		//IL_14ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f1: Expected Obj, but got Unknown
		//IL_151b: Expected F4, but got Obj
		//IL_1516: Expected native int or pointer, but got VT
		//IL_0b4e: Expected F4, but got Obj
		//IL_0b49: Expected native int or pointer, but got VT
		//IL_0b65: Expected I4, but got VT
		//IL_0ab4: Expected Obj, but got F4
		//IL_0c05: Expected F4, but got Obj
		//IL_0c00: Expected native int or pointer, but got VT
		//IL_0c18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1d: Expected Obj, but got Unknown
		//IL_0c2a: Expected Obj, but got F4
		//IL_0bd3: Expected I, but got Obj
		//IL_0ae1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae6: Expected Obj, but got Unknown
		//IL_0b04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b09: Expected Obj, but got Unknown
		//IL_0b0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b14: Expected Obj, but got Unknown
		//IL_0b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b29: Expected Obj, but got Unknown
		object obj = default;
		Vector2 vector = (Vector2)(obj + 304);
		Vector2 vector2 = (Vector2)(obj + 128);
		object obj2 = obj + 120;
		object obj3 = obj + 40;
		object obj4 = obj + 112;
		Camera camera = (Camera)(obj + 16);
		object obj5 = obj + 104;
		object obj6 = obj + 96;
		object obj7 = obj + 88;
		Camera camera2 = (Camera)(obj + 168);
		object obj8 = obj + 80;
		object obj9 = obj + 152;
		object obj10 = obj + 140;
		object obj11 = obj + 72;
		object obj12 = obj - -64;
		object obj13 = obj + 280;
		obj13 = 0;
		_ = 0;
		_ = 0;
		object obj14 = obj + 276;
		obj14 = 0f;
		object obj15 = obj + 264;
		obj15 = 0;
		_ = 0;
		object obj16 = obj + 252;
		obj16 = 0;
		_ = 0;
		object obj17 = obj + 240;
		obj17 = 0;
		_ = 0;
		object obj18 = obj + 216;
		obj18 = 0;
		_ = 0;
		_ = 0;
		object obj19 = obj + 192;
		obj19 = 0;
		_ = 0;
		_ = 0;
		if (~(mPressed ? 1u : 0u) != 0)
		{
			return;
		}
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v66 (Il2CppClass<UICamera>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v465 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		KeyCode currentKey = UICamera.currentKey;
		if (currentKey == (KeyCode)2 || !isActiveAndEnabled)
		{
			return;
		}
		string fileName = tag;
		nint num3 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S1_v47 (Il2CppClass<NGUITools>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S1_v395 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		byte[] array = NGUITools.Load(fileName);
		if (array == null || ~(mShouldMove ? 1u : 0u) != 0)
		{
			return;
		}
		if (mDragID == -10)
		{
			nint num5 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v454 (Il2CppClass<UICamera>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num6 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v459 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			mDragID = UICamera.currentTouchID;
		}
		nint num7 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v85 (Il2CppClass<UICamera>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num8 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S0_v447 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UICamera.MouseOrTouch currentTouch = UICamera.currentTouch;
		currentTouch.clickNotification = UICamera.ClickNotification.BasedOnDelta;
		if (~(smoothDragStart ? 1u : 0u) == 0 && ~(mDragStarted ? 1u : 0u) != 0)
		{
			mDragStarted = true;
			nint num9 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S0_v427 (Il2CppClass<UICamera>)+BA]");
			object obj24 = (nint)0 & (nint)0x200;
			if (obj24 != null)
			{
				nint num10 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ S0_v441 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera.MouseOrTouch currentTouch2 = UICamera.currentTouch;
			((Vector2*)(nint)vector2)->x = (float)currentTouch2.totalDelta;
			obj2 = vector2.x;
			((Vector2*)(nint)vector)->x = (float)obj2;
			mDragStartOffset = (Vector2)vector.x;
			object obj25 = this - -64;
			if (obj25 != null)
			{
				object obj26 = this - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
			}
		}
		nint num11 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S0_v96 (Il2CppClass<UICamera>)+BA]");
		object obj27 = (nint)0 & (nint)0x200;
		bool flag = obj27 == null;
		if (~(smoothDragStart ? 1u : 0u) == 0)
		{
			if (!flag)
			{
				nint num12 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ S0_v416 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera.MouseOrTouch currentTouch3 = UICamera.currentTouch;
			obj3 = currentTouch3.pos;
			camera = (Camera)mDragStartOffset;
			nint num13 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ S0_v394 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj28 = (nint)0 & (nint)0x200;
			if (obj28 != null)
			{
				nint num14 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ S0_v412 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj5 = obj3;
			obj6 = camera;
			((Vector2*)(nint)vector2)->x = (float)obj5;
			((Vector2*)(nint)vector)->x = (float)obj6;
			Vector2 vector3 = vector2 * vector;
			obj7 = obj;
			((Vector2*)(nint)vector)->x = (float)obj7;
			Vector3 vector4 = (Vector4)vector;
			((Vector2*)(nint)vector)->x = vector2.x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector2)+8]");
			_ = 0;
			camera2.ScreenToViewportPoint_Injected(ref *(Vector3*)UICamera.currentCamera, out *(Vector3*)vector);
			obj19 = camera2;
			_ = ((UnityEngine.Object)camera2).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27 (UnityEngine.Camera)+10]");
			_ = 0;
		}
		else
		{
			if (!flag)
			{
				nint num15 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ S0_v379 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera.MouseOrTouch currentTouch4 = UICamera.currentTouch;
			((Vector2*)(nint)vector2)->x = (float)currentTouch4.pos;
			nint num16 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S0_v362 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj29 = (nint)0 & (nint)0x200;
			if (obj29 != null)
			{
				nint num17 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ S0_v375 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj4 = vector2.x;
			((Vector2*)(nint)vector)->x = (float)obj4;
			Vector3 vector5 = (Vector4)vector;
			((Vector2*)(nint)vector)->x = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			_ = 0;
			camera.ScreenToViewportPoint_Injected(ref *(Vector3*)UICamera.currentCamera, out *(Vector3*)vector);
			obj19 = camera;
			_ = ((UnityEngine.Object)camera).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19 (UnityEngine.Camera)+10]");
			_ = 0;
		}
		obj13 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v58+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v58+10]");
		_ = 0;
		obj14 = 0f;
		((Vector2*)(nint)vector)->x = (float)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v39+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v39+10]");
		_ = 0;
		object obj30 = this + 108;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F8D6");
		object obj31 = default;
		if (obj31 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F969");
		obj15 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		_ = 0;
		camera = (Camera)obj3;
		Camera camera3 = camera;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		((UnityEngine.Object)camera3).m_CachedPtr = (IntPtr)0;
		object obj32 = this + 124;
		obj = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ S1_v84+8]");
		_ = 0;
		nint num18 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ S0_v121 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj33 = (nint)0 & (nint)0x200;
		if (obj33 != null)
		{
			nint num19 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ S0_v350 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector2*)(nint)vector2)->x = (float)camera;
		_ = ((UnityEngine.Object)camera).m_CachedPtr;
		((Vector2*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Quaternion quaternion = Quaternion.FromToRotation(vector2, vector);
		obj16 = camera2;
		_ = ((UnityEngine.Object)camera2).m_CachedPtr;
		((Vector2*)(nint)vector)->x = (float)obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v45+8]");
		_ = 0;
		object obj34 = this + 124;
		obj34 = vector.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector2)+8]");
		_ = 0;
		((Vector2*)(nint)vector)->x = (float)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v48+8]");
		_ = 0;
		if (vector.x == 0f)
		{
			((Vector2*)(nint)vector)->x = (float)obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v48+8]");
			_ = 0;
			if (vector.y == 0f)
			{
				((Vector2*)(nint)vector)->x = (float)obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v48+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector2)+8]");
				if (0f == 0f)
				{
					goto IL_1207;
				}
			}
		}
		((Vector2*)(nint)vector)->x = (float)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v48+8]");
		_ = 0;
		Vector3 vector6 = mTrans.TransformPoint(vector);
		obj16 = vector2.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector2)+8]");
		_ = 0;
		if (movement != Movement.Horizontal)
		{
			if (movement == Movement.Vertical)
			{
				obj16 = 0f;
				_ = 0f;
			}
			else if (movement == Movement.Unrestricted)
			{
				_ = 0f;
			}
			else
			{
				((Vector2*)(nint)vector2)->x = (float)customMovement;
				nint num20 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ S0_v324 (Il2CppClass<UnityEngine.Vector2>)+BA]");
				object obj35 = (nint)0 & (nint)0x200;
				if (obj35 != null)
				{
					nint num21 = (nint)typeof(Vector2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ S0_v334 (Il2CppClass<UnityEngine.Vector2>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj8 = vector2.x;
				((Vector2*)(nint)vector)->x = (float)obj8;
				Vector3 vector7 = (Vector4)vector;
				((Vector2*)(nint)vector)->x = (float)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11455");
			}
		}
		else
		{
			_ = 0f;
			_ = 0f;
		}
		((Vector2*)(nint)vector)->x = (float)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v48+8]");
		_ = 0;
		Vector3 vector8 = mTrans.InverseTransformDirection(vector);
		obj16 = vector2.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector2)+8]");
		_ = 0;
		goto IL_1207;
		IL_1207:
		if (dragEffect != DragEffect.None)
		{
			object obj36 = this + 140;
			obj3 = obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ S1_v230+8]");
			_ = 0;
			object obj37 = this + 140;
			camera = (Camera)obj37;
			Camera camera4 = camera;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ S1_v235+8]");
			((UnityEngine.Object)camera4).m_CachedPtr = (IntPtr)0;
			obj = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v48+8]");
			_ = 0;
			nint num22 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ S0_v274 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj38 = (nint)0 & (nint)0x200;
			if (obj38 != null)
			{
				nint num23 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ S0_v293 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector2*)(nint)vector)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			float num24 = 0.01f * momentumAmount;
			Vector3 vector9 = (Vector3)vector / num24;
			((Vector2*)(nint)vector2)->x = (float)camera;
			_ = ((UnityEngine.Object)camera).m_CachedPtr;
			((Vector2*)(nint)vector)->x = (float)camera2;
			_ = ((UnityEngine.Object)camera2).m_CachedPtr;
			Vector3 vector10 = (Vector3)vector2 - (Vector3)vector;
			((Vector2*)(nint)vector2)->x = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			_ = 0;
			((Vector2*)(nint)vector)->x = (float)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
			_ = 0;
			Vector3 vector11 = Vector3.LerpUnclamped(vector2, vector, 0.67f);
			((Vector2*)(nint)vector)->x = (float)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33+8]");
			_ = 0;
		}
		else
		{
			nint num25 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ S0_v255 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj39 = (nint)0 & (nint)0x200;
			if (obj39 != null)
			{
				nint num26 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ S0_v262 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one = Vector3.one;
			((Vector2*)(nint)vector)->x = vector2.x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector2)+8]");
			_ = 0;
		}
		object obj40 = this + 140;
		obj40 = vector.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector2)+8]");
		_ = 0;
		if (~(iOSDragEmulation ? 1u : 0u) == 0 && dragEffect == DragEffect.MomentumAndSpring)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
			obj18 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
			nint num27 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ S0_v181 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj41 = (nint)0 & (nint)0x200;
			if (obj41 != null)
			{
				nint num28 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v947 @ S0_v251 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector2*)(nint)vector)->x = (float)camera;
			_ = ((UnityEngine.Object)camera).m_CachedPtr;
			Vector3 vector12 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
			obj18 = camera2;
			_ = ((UnityEngine.Object)camera2).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27 (UnityEngine.Camera)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
			((Vector2*)(nint)vector)->x = (float)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
			_ = 0;
			Vector3 vector13 = vector;
			obj11 = obj;
			((Vector2*)(nint)vector2)->x = (float)obj11;
			((Vector2*)(nint)vector)->x = (float)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8D58");
			obj17 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33+8]");
			_ = 0;
			if (movement != Movement.Horizontal)
			{
				if (movement == Movement.Vertical)
				{
					obj17 = 0f;
				}
				else if (movement == Movement.Custom)
				{
					object obj42 = this + 52;
					object obj43 = obj17 * obj42;
					obj17 = obj43;
					object obj44 = obj17 + 4;
					object obj45 = this + 52;
					object obj46 = obj44;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1054 @ S2_v32+4]");
					object obj47 = obj46 * 0;
					obj44 = obj47;
				}
			}
			else
			{
				_ = 0f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11468");
			object obj48 = default;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj48) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1f))
			{
				((Vector2*)(nint)vector)->x = (float)obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v48+8]");
				_ = 0;
				Press((byte)(int)vector != 0);
			}
			else
			{
				((Vector2*)(nint)vector2)->x = (float)obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v48+8]");
				_ = 0;
				nint num29 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1071 @ S0_v212 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj49 = (nint)0 & (nint)0x200;
				if (obj49 != null)
				{
					nint num30 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1076 @ S0_v232 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector2*)(nint)vector)->x = vector2.x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector2)+8]");
				_ = 0;
				Vector3 vector14 = (Vector3)vector / 0.5f;
				((Vector2*)(nint)vector)->x = (float)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				_ = 0;
				Press((byte)(int)vector != 0);
				object obj50 = this + 140;
				camera = (Camera)obj50;
				Camera camera5 = camera;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1103 @ S1_v190+8]");
				((UnityEngine.Object)camera5).m_CachedPtr = (IntPtr)0;
				((Vector2*)(nint)vector)->x = (float)camera;
				_ = ((UnityEngine.Object)camera).m_CachedPtr;
				Vector3 vector15 = (Vector3)vector / 0.5f;
				((Vector2*)(nint)vector)->x = (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				object obj51 = this + 140;
				obj51 = vector.x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector2)+8]");
				_ = 0;
			}
		}
		else
		{
			((Vector2*)(nint)vector)->x = (float)obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v48+8]");
			_ = 0;
			Press((byte)(int)vector != 0);
		}
		if (~(constrainOnDrag ? 1u : 0u) == 0 && ~(restrictWithinPanel ? 1u : 0u) == 0)
		{
			UIPanel uIPanel = mPanel;
			if (uIPanel.mClipping != UIDrawCall.Clipping.None && dragEffect != DragEffect.MomentumAndSpring)
			{
				bool flag2 = canMoveVertically;
				bool depth = shouldMoveHorizontally;
				UISprite uISprite = NGUITools.AddSprite((GameObject)(object)this, (UIAtlas)1, (string)flag2, depth ? 1 : 0);
			}
		}
	}

	public unsafe void OnPan(Vector2 delta)
	{
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07be: Expected VT, but got Unknown
		//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Expected VT, but got Unknown
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected Obj, but got Unknown
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected Obj, but got Unknown
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f6: Expected Obj, but got Unknown
		//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0804: Expected Obj, but got Unknown
		//IL_080d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0812: Expected Obj, but got Unknown
		//IL_081b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0820: Expected VT, but got Unknown
		//IL_0829: Unknown result type (might be due to invalid IL or missing references)
		//IL_082e: Expected Obj, but got Unknown
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_083c: Expected Obj, but got Unknown
		//IL_0845: Unknown result type (might be due to invalid IL or missing references)
		//IL_084a: Expected Obj, but got Unknown
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_0858: Expected Obj, but got Unknown
		//IL_0861: Unknown result type (might be due to invalid IL or missing references)
		//IL_0866: Expected Obj, but got Unknown
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0874: Expected Obj, but got Unknown
		//IL_087d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Expected Obj, but got Unknown
		//IL_088b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0890: Expected Obj, but got Unknown
		//IL_0899: Unknown result type (might be due to invalid IL or missing references)
		//IL_089e: Expected Obj, but got Unknown
		//IL_08a7: Expected Obj, but got I4
		//IL_08b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b5: Expected Obj, but got Unknown
		//IL_08be: Expected Obj, but got I4
		//IL_08e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e5: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00ea: Expected I, but got Obj
		//IL_0100: Expected Obj, but got I
		//IL_0182: Expected I, but got Obj
		//IL_0198: Expected Obj, but got I
		//IL_096f: Expected Obj, but got F4
		//IL_097c: Expected F4, but got Obj
		//IL_0977: Expected native int or pointer, but got VT
		//IL_098b: Expected VT, but got F4
		//IL_012b: Expected I, but got Obj
		//IL_01c3: Expected I, but got Obj
		//IL_020b: Invalid comparison between VT and I4
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dd: Expected I4, but got Unknown
		//IL_0238: Expected I, but got Obj
		//IL_024e: Expected Obj, but got I
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected I4, but got Unknown
		//IL_02e9: Invalid comparison between VT and I4
		//IL_05e7: Expected I, but got Obj
		//IL_05fd: Expected Obj, but got I
		//IL_0279: Expected I, but got Obj
		//IL_030b: Expected I, but got Obj
		//IL_0321: Expected Obj, but got I
		//IL_0628: Expected I, but got Obj
		//IL_0a40: Expected F4, but got Obj
		//IL_0a3b: Expected native int or pointer, but got VT
		//IL_0a55: Expected F4, but got I
		//IL_0a50: Expected native int or pointer, but got VT
		//IL_0a5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a60: Expected Obj, but got Unknown
		//IL_0a6d: Expected Obj, but got F4
		//IL_0a96: Expected I, but got Obj
		//IL_0aac: Expected Obj, but got I
		//IL_0ac9: Expected I, but got Obj
		//IL_0aed: Expected Obj, but got I
		//IL_0b0f: Expected F4, but got Obj
		//IL_0b0a: Expected native int or pointer, but got VT
		//IL_0b24: Expected F4, but got I
		//IL_0b1f: Expected native int or pointer, but got VT
		//IL_0b2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2f: Expected Obj, but got Unknown
		//IL_0b3c: Expected Obj, but got F4
		//IL_0b55: Expected VT, but got Obj
		//IL_0b6c: Expected I, but got Obj
		//IL_0b82: Expected Obj, but got I
		//IL_034c: Expected I, but got Obj
		//IL_0bac: Expected F4, but got Obj
		//IL_0ba7: Expected native int or pointer, but got VT
		//IL_0bbe: Expected F4, but got I
		//IL_0bb9: Expected native int or pointer, but got VT
		//IL_0bcb: Expected F4, but got Obj
		//IL_0bc6: Expected native int or pointer, but got VT
		//IL_0be0: Expected F4, but got I
		//IL_0bdb: Expected native int or pointer, but got VT
		//IL_0bf1: Expected Ref, but got VT
		//IL_0bf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfc: Expected Obj, but got Unknown
		//IL_0c1a: Expected Obj, but got I4
		//IL_0c2d: Expected native int or pointer, but got VT
		//IL_0c3f: Expected native int or pointer, but got VT
		//IL_0c51: Expected F4, but got Obj
		//IL_0c4c: Expected native int or pointer, but got VT
		//IL_0c66: Expected F4, but got I
		//IL_0c61: Expected native int or pointer, but got VT
		//IL_0c7d: Expected F4, but got Obj
		//IL_0c78: Expected native int or pointer, but got VT
		//IL_0c92: Expected F4, but got I
		//IL_0c8d: Expected native int or pointer, but got VT
		//IL_0c98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9d: Expected Obj, but got Unknown
		//IL_0caa: Expected Obj, but got F4
		//IL_0cd0: Expected F4, but got VT
		//IL_0ccb: Expected native int or pointer, but got VT
		//IL_0cdd: Expected Obj, but got F4
		//IL_0cea: Expected Obj, but got F4
		//IL_0cf8: Expected I, but got Obj
		//IL_0d0e: Expected Obj, but got I
		//IL_0399: Expected I, but got Obj
		//IL_03c9: Expected I, but got Obj
		//IL_0d69: Expected F4, but got Obj
		//IL_0d64: Expected native int or pointer, but got VT
		//IL_0d78: Expected Obj, but got VT
		//IL_0402: Expected I, but got Obj
		//IL_049d: Expected VT, but got Obj
		//IL_044f: Expected I, but got Obj
		//IL_03ef: Expected I, but got Obj
		//IL_0509: Expected F4, but got Obj
		//IL_0504: Expected native int or pointer, but got VT
		//IL_051e: Expected F4, but got I
		//IL_0519: Expected native int or pointer, but got VT
		//IL_0527: Expected Obj, but got VT
		//IL_0749: Expected Obj, but got I4
		//IL_0749: Expected Obj, but got I4
		//IL_0559: Expected I, but got Obj
		//IL_056f: Expected Obj, but got I
		//IL_0d94: Expected F4, but got Obj
		//IL_0d8f: Expected native int or pointer, but got VT
		//IL_0da3: Expected VT, but got F4
		//IL_0da9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dae: Expected Obj, but got Unknown
		//IL_059a: Expected I, but got Obj
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj + 216);
		Vector3 vector2 = (Vector3)(obj + 40);
		object obj2 = obj + 56;
		object obj3 = obj + 188;
		object obj4 = obj + 176;
		Transform transform = (Transform)(obj + 160);
		object obj5 = obj + 144;
		Quaternion quaternion = (Quaternion)(obj + 132);
		object obj6 = obj + 120;
		object obj7 = obj + 104;
		object obj8 = obj + 8;
		object obj9 = obj + 24;
		Transform transform2 = (Transform)(obj + 88);
		object obj10 = obj + 76;
		object obj11 = obj - -64;
		object obj12 = obj + 16;
		object obj13 = obj + 32;
		obj13 = 0;
		object obj14 = obj + 200;
		obj14 = 0;
		_ = 0;
		bool flag = mPressed;
		object obj15 = flag ^ delta;
		if (obj15 == null)
		{
			return;
		}
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v52 (Il2CppClass<UICamera>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v246 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		KeyCode currentKey = UICamera.currentKey;
		if (currentKey == (KeyCode)2)
		{
			return;
		}
		bool flag2 = smoothDragStart;
		object obj17 = flag2 & delta;
		if (obj17 != null)
		{
			mDragStarted = false;
			nint num3 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v234 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num4 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v242 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector2 one = Vector2.one;
			obj2 = vector2.x;
			((Vector3*)(nint)vector)->x = (float)obj2;
			mDragStartOffset = (Vector2)vector.x;
		}
		if (!isActiveAndEnabled)
		{
			return;
		}
		string fileName = tag;
		nint num5 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S1_v35 (Il2CppClass<NGUITools>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num6 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S1_v202 (Il2CppClass<NGUITools>)+74]");
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
		if (delta == (Vector2)(object)0)
		{
			nint num7 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S1_v188 (Il2CppClass<UICamera>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num8 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S1_v196 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (mDragID == UICamera.currentTouchID)
			{
				mDragID = -10;
			}
		}
		mCalculatedBounds = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj21 = default;
		bool flag3 = (byte)(obj21 & 1) != 0;
		mShouldMove = flag3;
		if (~(mShouldMove ? 1u : 0u) != 0)
		{
			return;
		}
		bool flag4 = (byte)(delta & 1) != 0;
		mPressed = flag4;
		if (delta != (Vector2)(object)0)
		{
			nint num9 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S0_v113 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num10 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v224 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one2 = Vector3.one;
			((Vector3*)(nint)vector)->x = (float)obj3;
			Vector3 vector3 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			((Vector3*)(nint)vector3)->z = 0f;
			object obj23 = this + 140;
			obj23 = vector.x;
			_ = vector.z;
			mScroll = 0f;
			UpdateScrollbars();
			nint num11 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ S0_v126 (Il2CppClass<UICamera>)+BA]");
			object obj24 = (nint)0 & (nint)0x200;
			bool flag5 = obj24 == null;
			nint num12 = (nint)typeof(UICamera);
			if (!flag5)
			{
				nint num13 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ S0_v218 (Il2CppClass<UICamera>)+74]");
				bool flag6 = (nint)0 == 0;
				bool flag7 = !flag6;
				num12 = (nint)typeof(UICamera);
				if (!flag7)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num12 = (nint)typeof(UICamera);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ L1_v5 (Il2CppClass<UICamera>)+5C]");
			object obj25 = (nint)0 + (nint)56;
			obj4 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ S1_v86+8]");
			_ = 0;
			((Vector3*)(nint)vector)->x = (float)obj4;
			Vector3 vector4 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
			((Vector3*)(nint)vector4)->z = 0f;
			object obj26 = this + 124;
			obj26 = vector.x;
			_ = vector.z;
			transform.rotation = (Quaternion)mTrans;
			Vector3 up = Vector3.up;
			nint num14 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ S0_v140 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj27 = (nint)0 & (nint)0x200;
			if (obj27 != null)
			{
				nint num15 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ S0_v214 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector2)->x = (float)transform;
			((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
			((Vector3*)(nint)vector)->x = (float)obj5;
			Vector3 vector5 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
			((Vector3*)(nint)vector5)->z = 0f;
			((Quaternion*)quaternion)->SetLookRotation(vector2, vector);
			object obj28 = this + 124;
			obj6 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ S1_v113+8]");
			_ = 0;
			obj7 = 0;
			_ = 0;
			((Vector3*)(nint)vector2)->x = quaternion.x;
			((Vector3*)(nint)vector2)->z = quaternion.z;
			((Vector3*)(nint)vector)->x = (float)obj6;
			Vector3 vector6 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
			((Vector3*)(nint)vector6)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F8D0");
			((Vector3*)(nint)vector)->x = (float)obj7;
			Vector3 vector7 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27+8]");
			((Vector3*)(nint)vector7)->z = 0f;
			object obj29 = this + 108;
			obj29 = vector.x;
			_ = vector.z;
			UIPanel uIPanel = mPanel;
			((Vector3*)(nint)vector2)->x = (float)uIPanel.mClipOffset;
			obj13 = vector2.x;
			obj8 = vector2.x;
			nint num16 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ S0_v169 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj30 = (nint)0 & (nint)0x200;
			if (obj30 != null)
			{
				nint num17 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ S0_v210 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
			object obj31 = default;
			obj13 = obj31;
			obj = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
			obj9 = obj13;
			((Vector3*)(nint)vector)->x = (float)obj9;
			mPanel.clipTexture = (Texture2D)vector;
			transform2.localPosition = (Vector3)mTrans;
			obj14 = transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			obj10 = transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
			object obj32 = default;
			obj14 = obj32;
			obj11 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v43+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
			((Vector3*)(nint)vector)->x = (float)obj14;
			Vector3 vector8 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v43+8]");
			((Vector3*)(nint)vector8)->z = 0f;
			Vector3 eulerAngles = ((Transform)vector).eulerAngles;
			if (smoothDragStart)
			{
				return;
			}
			mDragStarted = true;
			nint num18 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ S0_v193 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj33 = (nint)0 & (nint)0x200;
			if (obj33 != null)
			{
				nint num19 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ S0_v207 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector2 one3 = Vector2.one;
			((Vector3*)(nint)vector)->x = (float)obj12;
			mDragStartOffset = (Vector2)vector.x;
			object obj34 = this - -64;
			if (obj34 != null)
			{
				object obj35 = this - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
			}
			return;
		}
		nint num20 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S1_v48 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj36 = (nint)0 & (nint)0x200;
		if (obj36 != null)
		{
			nint num21 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S1_v66 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag8 = UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)centerOnChild);
		bool flag9 = mDragStarted;
		if (flag8)
		{
			if (flag9 && onDragFinished != null)
			{
				onDragFinished();
			}
			centerOnChild._002Ector();
			return;
		}
		if (flag9 && ~(restrictWithinPanel ? 1u : 0u) == 0)
		{
			UIPanel uIPanel2 = mPanel;
			if (uIPanel2.mClipping != UIDrawCall.Clipping.None)
			{
				bool flag10 = dragEffect == DragEffect.None;
				bool flag11 = canMoveVertically;
				bool depth = shouldMoveHorizontally;
				UISprite uISprite = NGUITools.AddSprite((GameObject)(object)this, (UIAtlas)flag10, (string)flag11, depth ? 1 : 0);
			}
		}
		if (~(mDragStarted ? 1u : 0u) == 0 && onDragFinished != null)
		{
			onDragFinished();
		}
		if (!mShouldMove && onStoppedMoving != null)
		{
			onStoppedMoving();
		}
	}

	public unsafe UIScrollView()
	{
		//IL_0bfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c03: Expected VT, but got Unknown
		//IL_0c0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c11: Expected VT, but got Unknown
		//IL_0c1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1f: Expected Obj, but got Unknown
		//IL_0c28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2d: Expected Obj, but got Unknown
		//IL_0c36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3b: Expected Obj, but got Unknown
		//IL_003b: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected Obj, but got Unknown
		//IL_055c: Invalid comparison between Obj and F4
		//IL_007c: Expected I, but got Obj
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected Ref, but got Unknown
		//IL_00c9: Expected I, but got Obj
		//IL_00df: Expected Obj, but got I
		//IL_0933: Unknown result type (might be due to invalid IL or missing references)
		//IL_0938: Expected Obj, but got Unknown
		//IL_0956: Expected Obj, but got I4
		//IL_0976: Expected Obj, but got F4
		//IL_0594: Expected I, but got Obj
		//IL_05aa: Expected Obj, but got I
		//IL_0205: Expected I, but got Obj
		//IL_021b: Expected Obj, but got I
		//IL_0f66: Expected F4, but got Obj
		//IL_0f61: Expected native int or pointer, but got VT
		//IL_0f7b: Expected F4, but got I
		//IL_0f76: Expected native int or pointer, but got VT
		//IL_0f9a: Expected I, but got Obj
		//IL_0fb0: Expected Obj, but got I
		//IL_010a: Expected I, but got Obj
		//IL_0fdf: Expected F4, but got Obj
		//IL_0fda: Expected native int or pointer, but got VT
		//IL_0ff4: Expected F4, but got I
		//IL_0fef: Expected native int or pointer, but got VT
		//IL_1001: Expected F4, but got Obj
		//IL_0ffc: Expected native int or pointer, but got VT
		//IL_1016: Expected F4, but got I
		//IL_1011: Expected native int or pointer, but got VT
		//IL_1034: Expected F4, but got Obj
		//IL_102f: Expected native int or pointer, but got VT
		//IL_1049: Expected F4, but got I
		//IL_1044: Expected native int or pointer, but got VT
		//IL_104f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1054: Expected Obj, but got Unknown
		//IL_1061: Expected Obj, but got F4
		//IL_1085: Unknown result type (might be due to invalid IL or missing references)
		//IL_108a: Expected Ref, but got Unknown
		//IL_05d5: Expected I, but got Obj
		//IL_0d0b: Expected I, but got Obj
		//IL_0d21: Expected Obj, but got I
		//IL_0246: Expected I, but got Obj
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_01ab: Invalid comparison between Obj and F4
		//IL_09eb: Expected native int or pointer, but got VT
		//IL_09fd: Expected native int or pointer, but got VT
		//IL_0a0c: Expected I4, but got VT
		//IL_099f: Expected I, but got Obj
		//IL_0882: Unknown result type (might be due to invalid IL or missing references)
		//IL_0887: Expected Obj, but got Unknown
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a7: Expected Obj, but got Unknown
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Expected Obj, but got Unknown
		//IL_08bb: Expected Obj, but got I4
		//IL_08ea: Expected Obj, but got F4
		//IL_077f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0784: Expected Obj, but got Unknown
		//IL_07a2: Expected Obj, but got I4
		//IL_07b1: Expected Obj, but got F4
		//IL_062d: Expected I, but got Obj
		//IL_0643: Expected Obj, but got I
		//IL_080d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0812: Expected Obj, but got Unknown
		//IL_0830: Expected Obj, but got I4
		//IL_0850: Expected Obj, but got F4
		//IL_0eaa: Expected native int or pointer, but got VT
		//IL_0ebc: Expected native int or pointer, but got VT
		//IL_0ec7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecc: Expected Obj, but got Unknown
		//IL_0ed9: Expected Obj, but got F4
		//IL_0efb: Expected I, but got Obj
		//IL_0f11: Expected Obj, but got I
		//IL_03a4: Expected I, but got Obj
		//IL_02cf: Expected Obj, but got F4
		//IL_01c8: Expected Obj, but got I4
		//IL_01d1: Expected Obj, but got I4
		//IL_066e: Expected I, but got Obj
		//IL_0d5b: Expected I, but got Obj
		//IL_0d71: Expected Obj, but got I
		//IL_06bb: Expected I, but got Obj
		//IL_042d: Expected Obj, but got F4
		//IL_0a5f: Expected I, but got Obj
		//IL_0a75: Expected Obj, but got I
		//IL_0dd5: Expected I, but got Obj
		//IL_0deb: Expected Obj, but got I
		//IL_02f2: Expected I, but got Obj
		//IL_0aa0: Expected I, but got Obj
		//IL_0450: Expected I, but got Obj
		//IL_0b65: Expected I, but got Obj
		//IL_0b7b: Expected Obj, but got I
		//IL_110e: Expected native int or pointer, but got VT
		//IL_1120: Expected native int or pointer, but got VT
		//IL_112b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1130: Expected Obj, but got Unknown
		//IL_113d: Expected Obj, but got F4
		//IL_0b07: Expected Obj, but got I4
		//IL_0ba6: Expected I, but got Obj
		object obj = default;
		Vector3 vector = (Vector3)(obj + 60);
		Vector3 vector2 = (Vector3)(obj + 48);
		object obj2 = obj + 36;
		object obj3 = obj + 24;
		object obj4 = obj + 12;
		if (Application.platform == RuntimePlatform.OSXEditor)
		{
			return;
		}
		float fixedDeltaTime = Time.fixedDeltaTime;
		object obj7;
		object obj8 = default;
		if (showScrollBars != ShowCondition.Always)
		{
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S1_v163 (Il2CppClass<UnityEngine.Object>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S1_v247 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)verticalScrollBar))
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S1_v238 (Il2CppClass<UnityEngine.Object>)+BA]");
				if ((object)((nint)0 & (nint)0x200) != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S1_v243 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)horizontalScrollBar))
				{
					goto IL_0cbc;
				}
			}
			if (showScrollBars == ShowCondition.WhenDragging && mDragID == -10)
			{
				object obj5 = this + 140;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11468");
				object obj6 = default;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.01f))
				{
					obj7 = 0;
					obj8 = 0;
					goto IL_01f7;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj9 = default;
			obj7 = obj9;
			goto IL_01f7;
		}
		goto IL_0cbc;
		IL_01f7:
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S1_v172 (Il2CppClass<UnityEngine.Object>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ S1_v226 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)verticalScrollBar))
		{
			float num7 = ((UIScrollBar)verticalScrollBar).scrollValue + ((obj7 == null) ? ((float)(object)(0f - fixedDeltaTime) * 3f) : (fixedDeltaTime * 6f));
			nint num8 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ S0_v251 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num9 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ S0_v261 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float scrollValue = ((UIScrollBar)verticalScrollBar).scrollValue;
			float num10 = ((num7 < 0f) ? 0f : ((!(num7 > 1f)) ? num7 : 1f));
			if (scrollValue != num10)
			{
				((UIScrollBar)verticalScrollBar).scrollValue = num10;
			}
		}
		nint num11 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ S1_v179 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ S1_v203 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)horizontalScrollBar))
		{
			float num13 = ((UIScrollBar)horizontalScrollBar).scrollValue + ((obj8 == null) ? ((float)(object)(0f - fixedDeltaTime) * 3f) : (fixedDeltaTime * 6f));
			nint num14 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ S0_v232 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num15 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ S0_v242 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float scrollValue2 = ((UIScrollBar)horizontalScrollBar).scrollValue;
			float num16 = ((num13 < 0f) ? 0f : ((!(num13 > 1f)) ? num13 : 1f));
			if (scrollValue2 != num16)
			{
				((UIScrollBar)horizontalScrollBar).scrollValue = num16;
			}
		}
		goto IL_0cbc;
		IL_0cbc:
		if (~(mShouldMove ? 1u : 0u) != 0)
		{
			return;
		}
		if (~(mPressed ? 1u : 0u) == 0)
		{
			mScroll = 0f;
			Vector2 vector3 = NGUIMath.SpringDampen(ref *(Vector2*)(this + 140), 9f, fixedDeltaTime);
			return;
		}
		object obj13 = this + 140;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11468");
		object obj14 = default;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.0001f))
		{
			nint num17 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S1_v130 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num18 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S1_v155 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num19 = Math.Abs(mScroll);
			if (!(num19 > 0.0001f))
			{
				mScroll = 0f;
				nint num20 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S0_v173 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				if ((object)((nint)0 & (nint)0x200) != null)
				{
					nint num21 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ S0_v205 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector3 one = Vector3.one;
				((Vector3*)(nint)vector)->x = vector2.x;
				((Vector3*)(nint)vector)->z = vector2.z;
				object obj15 = this + 140;
				obj15 = vector.x;
				_ = vector.z;
				SpringPanel component = GetComponent<SpringPanel>();
				nint num22 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ S0_v186 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj16 = (nint)0 & (nint)0x200;
				if (obj16 != null)
				{
					nint num23 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ S0_v201 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)component).FindKernel((string)null) == 0 || !component.isActiveAndEnabled)
				{
					mShouldMove = false;
					if (onStoppedMoving != null)
					{
						onStoppedMoving();
					}
				}
				return;
			}
		}
		Transform transform;
		if (movement != Movement.Horizontal)
		{
			if (movement == Movement.Vertical)
			{
				obj2 = this + 140;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S1_v119+8]");
				_ = 0;
				obj3 = 0;
				_ = 0;
				obj3 = 0f;
				float num24 = mScroll * 0.05f;
				_ = 0f;
				transform = mTrans;
			}
			else if (movement == Movement.Unrestricted)
			{
				obj2 = this + 140;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ S1_v107+8]");
				_ = 0;
				obj3 = 0;
				_ = 0;
				obj3 = mScroll * 0.05f;
				float num25 = mScroll * 0.05f;
				_ = 0f;
				transform = mTrans;
			}
			else
			{
				obj2 = this + 140;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ S1_v91+8]");
				_ = 0;
				object obj17 = this + 52;
				object obj18 = this + 52;
				obj3 = 0;
				_ = 0;
				obj3 = mScroll * (float)obj17 * 0.05f;
				float num26 = mScroll;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ S0_v135+4]");
				float num27 = num26 * 0f * 0.05f;
				_ = 0f;
				transform = mTrans;
			}
		}
		else
		{
			obj2 = this + 140;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S1_v77+8]");
			_ = 0;
			obj3 = 0;
			_ = 0;
			obj3 = mScroll * 0.05f;
			_ = 0f;
			_ = 0f;
			transform = mTrans;
		}
		((Vector3*)(nint)vector)->x = (float)obj3;
		Vector3 vector4 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		Vector3 vector5 = transform.InverseTransformDirection(vector);
		nint num28 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ S0_v44 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num29 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ S0_v101 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)obj2;
		Vector3 vector6 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj4;
		Vector3 vector7 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
		((Vector3*)(nint)vector7)->z = 0f;
		Quaternion quaternion = Quaternion.FromToRotation(vector2, vector);
		((Vector3*)(nint)vector)->x = (float)obj;
		Vector3 vector8 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector8)->z = 0f;
		object obj20 = this + 140;
		obj20 = vector.x;
		_ = vector.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B729");
		float num30 = default;
		mScroll = num30;
		Vector2 vector9 = NGUIMath.SpringDampen(ref *(Vector2*)(this + 140), dampenStrength, fixedDeltaTime);
		((Vector3*)(nint)vector)->x = vector2.x;
		((Vector3*)(nint)vector)->z = vector2.z;
		Press((byte)(int)vector != 0);
		if (~(restrictWithinPanel ? 1u : 0u) == 0 && mPanel.mClipping != UIDrawCall.Clipping.None)
		{
			nint num31 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ S1_v52 (Il2CppClass<NGUITools>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num32 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ S1_v72 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!NGUITools.GetActive((GameObject)(object)centerOnChild))
			{
				UISprite uISprite = NGUITools.AddSprite((GameObject)(object)this, null, (string)canMoveVertically, shouldMoveHorizontally ? 1 : 0);
			}
			else if (centerOnChild.nextPageThreshold == 0f)
			{
				centerOnChild._002Ector();
			}
			else
			{
				nint num33 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ S0_v82 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj21 = (nint)0 & (nint)0x200;
				if (obj21 != null)
				{
					nint num34 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ S0_v93 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector3 one2 = Vector3.one;
				((Vector3*)(nint)vector)->x = vector2.x;
				((Vector3*)(nint)vector)->z = vector2.z;
				object obj22 = this + 140;
				obj22 = vector.x;
				_ = vector.z;
				mScroll = 0f;
			}
		}
		if (onMomentumMove != null)
		{
			onMomentumMove();
		}
	}
}

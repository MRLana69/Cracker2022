using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Cpp2ILInjected;
using UI.ModelCamera;
using UnityEngine;

public class UIPopupList : UIWidgetContainer
{
	public enum Position
	{
		Auto,
		Above,
		Below
	}

	public enum Selection
	{
		OnPress,
		OnClick
	}

	public enum OpenOn
	{
		ClickOrTap,
		RightClick,
		DoubleClick,
		Manual
	}

	public delegate void LegacyEvent(string val);

	private sealed class _003CUpdateTweenPosition_003Ed__94 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPopupList _003C_003E4__this;

		private TweenPosition _003Ctp_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c9: Expected Obj, but got Unknown
				//IL_0042: Expected I, but got Obj
				//IL_0058: Expected Obj, but got I
				//IL_0083: Expected I, but got Obj
				//IL_00d0: Expected I, but got Obj
				//IL_00e6: Expected Obj, but got I
				//IL_01a2: Expected I, but got Obj
				//IL_01b8: Expected Obj, but got I
				//IL_0111: Expected I, but got Obj
				//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a7: Expected Obj, but got Unknown
				//IL_03b0: Expected Obj, but got I4
				//IL_01e3: Expected I, but got Obj
				//IL_0156: Unknown result type (might be due to invalid IL or missing references)
				//IL_015b: Expected Obj, but got Unknown
				//IL_0274: Unknown result type (might be due to invalid IL or missing references)
				//IL_0279: Expected Obj, but got Unknown
				//IL_0294: Unknown result type (might be due to invalid IL or missing references)
				//IL_0299: Expected Obj, but got Unknown
				//IL_02a2: Expected Obj, but got I4
				//IL_02b6: Expected Obj, but got I4
				object obj2 = default;
				object obj = obj2 + 12;
				UIPopupList uIPopupList = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						goto IL_0194;
					}
					return null;
				}
				_003C_003E1__state = -1;
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v36 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v55 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)uIPopupList.mHighlight).FindKernel((string)null) != 0)
				{
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v42 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S1_v51 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)uIPopupList.mHighlightedLabel).FindKernel((string)null) != 0)
					{
						object obj5 = this + 20;
						TweenPosition component = uIPopupList.mHighlight.GetComponent<TweenPosition>();
						obj5 = component;
						goto IL_0194;
					}
				}
				goto IL_0322;
				IL_0322:
				uIPopupList.mTweening = false;
				return null;
				IL_0194:
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)_003Ctp_003E5__2).FindKernel((string)null) != 0 && _003Ctp_003E5__2.isActiveAndEnabled)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
					obj = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					object obj7 = _003Ctp_003E5__2 + 100;
					obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					object obj8 = this + 12;
					obj8 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				object obj9 = this + 20;
				obj9 = 0;
				goto IL_0322;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CUpdateTweenPosition_003Ed__94(int _003C_003E1__state)
		{
			throw new InvalidOperationException();
		}

		void IDisposable.Dispose()
		{
			//IL_0015: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I
			//IL_011b: Expected Obj, but got I
			//IL_0138: Expected Obj, but got I4
			//IL_037a: Expected Obj, but got I
			//IL_0383: Unknown result type (might be due to invalid IL or missing references)
			//IL_0388: Expected Obj, but got Unknown
			//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cf: Expected Obj, but got Unknown
			//IL_01c4: Expected Obj, but got I
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Expected Obj, but got Unknown
			//IL_0190: Expected Obj, but got I
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected Obj, but got Unknown
			//IL_0257: Expected Obj, but got I
			//IL_02b1: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPopupList+<UpdateTweenPosition>d__94)+34]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPopupList+<UpdateTweenPosition>d__94)+34]");
			object obj3;
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPopupList+<UpdateTweenPosition>d__94)+34]");
				object obj2 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
				obj3 = 0;
				obj4 = obj2;
			}
			else
			{
				obj4 = this;
				obj3 = 1;
			}
			object obj5 = default;
			object obj23 = default;
			object obj20 = default;
			for (; obj5 != obj3; obj5 = obj23 + 1)
			{
				object obj6 = obj5 << 2;
				object obj7 = obj4 + obj6;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+14]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+28]");
				if ((nint)0 == -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+24]");
				object obj11 = (nint)0 & (nint)0x10;
				bool flag = obj11 == null;
				object obj12 = (flag ? 1 : 0) ^ 1;
				if (obj12 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+2A]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
						object obj13 = (nint)0 & (nint)0x3FFF;
						object obj14 = obj13 + 80504;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v104 @ S2_v14 (should have been resolved before IL gen)");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
						object obj15 = (nint)0 & (nint)0x7FFF;
						object obj16 = obj15 + 46824;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v111 @ S1_v33 (should have been resolved before IL gen)");
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+28]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+10]");
					bool flag2;
					if ((nint)0 != 0)
					{
						object obj17 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v59+9C]");
						object obj18 = (nint)0 & (nint)0x100;
						flag2 = obj18 != null;
					}
					else
					{
						flag2 = false;
					}
					if (!flag2 && _003C_003E2__current != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+2B]");
						object obj19 = (nint)0 & (nint)3;
						bool flag3 = (nint)obj19 == 2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
						if (flag3)
						{
							if (obj20 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B8");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B9");
							}
						}
						else if (obj20 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
						}
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
				object obj21 = (nint)0 & (nint)0x3FFF;
				object obj22 = obj21 + 80504;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v129 @ S2_v6 (should have been resolved before IL gen)");
			}
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CCloseIfUnselected_003Ed__111(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPopupList _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0387: Unknown result type (might be due to invalid IL or missing references)
				//IL_038c: Expected Obj, but got Unknown
				//IL_0395: Expected Obj, but got I4
				//IL_03a9: Expected Obj, but got I4
				//IL_0052: Expected I, but got Obj
				//IL_0068: Expected Obj, but got I
				//IL_03ee: Expected I, but got Obj
				//IL_0404: Expected Obj, but got I
				//IL_0433: Expected Obj, but got I4
				//IL_0093: Expected I, but got Obj
				//IL_00e0: Expected I, but got Obj
				//IL_012d: Expected I, but got Obj
				//IL_0143: Expected Obj, but got I
				//IL_045e: Expected Obj, but got I4
				//IL_016e: Expected I, but got Obj
				//IL_01bb: Expected I, but got Obj
				//IL_01d1: Expected Obj, but got I
				//IL_0494: Expected I, but got Obj
				//IL_04aa: Expected Obj, but got I
				//IL_0555: Expected Obj, but got I4
				//IL_01fc: Expected I, but got Obj
				//IL_0296: Expected I, but got Obj
				//IL_02ac: Expected Obj, but got I
				//IL_0249: Expected I, but got Obj
				//IL_04de: Expected Obj, but got I4
				//IL_04f0: Expected I, but got Obj
				//IL_0506: Expected Obj, but got I
				//IL_0530: Expected Obj, but got I4
				//IL_0530: Expected Obj, but got I4
				//IL_02d7: Expected I, but got Obj
				//IL_0324: Expected I, but got Obj
				UIPopupList uIPopupList = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
					nint num = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v18 (Il2CppClass<UICamera>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num2 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v94 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int touchCount = UICamera.touchCount;
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v27 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v90 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)touchCount).FindKernel((string)(object)uIPopupList.mSelection) != 0)
					{
						nint num5 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v35 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj3 = (nint)0 & (nint)0x200;
						if (obj3 != null)
						{
							nint num6 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v86 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if ((UnityEngine.Object)touchCount != null)
						{
							goto IL_0363;
						}
						nint num7 = (nint)typeof(UIPopupList);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v46 (Il2CppClass<UIPopupList>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						if (obj4 != null)
						{
							nint num8 = (nint)typeof(UIPopupList);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v80 (Il2CppClass<UIPopupList>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						nint num9 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v54 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj5 = (nint)0 & (nint)0x200;
						if (obj5 != null)
						{
							nint num10 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v76 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if ((UnityEngine.Object)touchCount == mChild)
						{
							nint num11 = (nint)typeof(UIPopupList);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v61 (Il2CppClass<UIPopupList>)+BA]");
							object obj6 = (nint)0 & (nint)0x200;
							if (obj6 != null)
							{
								nint num12 = (nint)typeof(UIPopupList);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v70 (Il2CppClass<UIPopupList>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							int layer = mChild.layer;
							int layer2 = ((GameObject)touchCount).layer;
							nint num13 = (nint)typeof(NGUITools);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S2_v9 (Il2CppClass<NGUITools>)+BA]");
							object obj7 = (nint)0 & (nint)0x200;
							if (obj7 != null)
							{
								nint num14 = (nint)typeof(NGUITools);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S2_v14 (Il2CppClass<NGUITools>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (!NGUITools.Save((string)layer, (byte[])layer2))
							{
								goto IL_0363;
							}
						}
					}
				}
				else
				{
					_003C_003E1__state = -1;
				}
				object obj8 = this + 12;
				obj8 = 0;
				_003C_003E1__state = 1;
				return 1;
				IL_0363:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public static UIPopupList current;

	protected static GameObject mChild;

	protected static float mFadeOutComplete;

	private const float animSpeed = 0.15f;

	public UIAtlas atlas;

	public UIFont bitmapFont;

	public Font trueTypeFont;

	public int fontSize;

	public FontStyle fontStyle;

	public string backgroundSprite;

	public string highlightSprite;

	public Sprite background2DSprite;

	public Sprite highlight2DSprite;

	public Position position;

	public Selection selection;

	public NGUIText.Alignment alignment;

	public List<string> items;

	public List<object> itemData;

	public List<Action> itemCallbacks;

	public Vector2 padding;

	public Color textColor;

	public Color backgroundColor;

	public Color highlightColor;

	public bool isAnimated;

	public bool isLocalized;

	public UILabel.Modifier textModifier;

	public bool separatePanel;

	public int overlap;

	public OpenOn openOn;

	public List<EventDelegate> onChange;

	protected string mSelectedItem;

	protected UIPanel mPanel;

	protected UIBasicSprite mBackground;

	protected UIBasicSprite mHighlight;

	protected UILabel mHighlightedLabel;

	protected List<UILabel> mLabelList;

	protected float mBgBorder;

	public bool keepValue;

	[NonSerialized]
	protected GameObject mSelection;

	[NonSerialized]
	protected int mOpenFrame;

	private GameObject eventReceiver;

	private string functionName;

	private float textScale;

	private UIFont font;

	private UILabel textLabel;

	[NonSerialized]
	public Vector3 startingPosition;

	private LegacyEvent mLegacyEvent;

	[NonSerialized]
	protected bool mExecuting;

	protected bool mUseDynamicFont;

	[NonSerialized]
	protected bool mStarted;

	protected bool mTweening;

	public GameObject source;

	public UnityEngine.Object ambigiousFont
	{
		get
		{
			//IL_001d: Expected I, but got Obj
			//IL_0033: Expected Obj, but got I
			//IL_005e: Expected I, but got Obj
			//IL_00a6: Expected Obj, but got I4
			if (isActiveAndEnabled)
			{
				UIButton component = GetComponent<UIButton>();
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v22 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (component != null)
				{
					return (UnityEngine.Object)1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				UnityEngine.Object result = default;
				return result;
			}
			return null;
		}
		set
		{
			//IL_06da: Unknown result type (might be due to invalid IL or missing references)
			//IL_06df: Expected Obj, but got Unknown
			//IL_06e8: Expected Obj, but got I4
			//IL_06f6: Expected I, but got Obj
			//IL_070c: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0737: Expected I, but got Obj
			//IL_074d: Expected Obj, but got I
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Expected Obj, but got Unknown
			//IL_007e: Expected I, but got Obj
			//IL_01ba: Expected Obj, but got I
			//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d0: Expected Obj, but got Unknown
			//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01de: Expected Obj, but got Unknown
			//IL_0307: Unknown result type (might be due to invalid IL or missing references)
			//IL_030c: Expected Obj, but got Unknown
			//IL_031f: Expected Obj, but got I4
			//IL_00f5: Expected I, but got Obj
			//IL_010b: Expected Obj, but got I
			//IL_0136: Expected I, but got Obj
			//IL_0334: Expected Obj, but got I4
			//IL_026e: Expected I, but got Obj
			//IL_0284: Expected Obj, but got I
			//IL_0874: Unknown result type (might be due to invalid IL or missing references)
			//IL_0879: Expected Obj, but got Unknown
			//IL_02af: Expected I, but got Obj
			//IL_03be: Expected I, but got Obj
			//IL_03d4: Expected Obj, but got I
			//IL_03ab: Expected Obj, but got I4
			//IL_045a: Expected I, but got Obj
			//IL_0470: Expected Obj, but got I
			//IL_03ff: Expected I, but got Obj
			//IL_0799: Unknown result type (might be due to invalid IL or missing references)
			//IL_079e: Expected Obj, but got Unknown
			//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a9: Expected Obj, but got Unknown
			//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b7: Expected Obj, but got Unknown
			//IL_082a: Expected Obj, but got I4
			//IL_0447: Expected Obj, but got I4
			//IL_049b: Expected I, but got Obj
			//IL_0503: Unknown result type (might be due to invalid IL or missing references)
			//IL_0508: Expected Obj, but got Unknown
			//IL_051b: Expected I, but got Obj
			//IL_0531: Expected Obj, but got I
			//IL_063c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0641: Expected Obj, but got Unknown
			//IL_0654: Expected I, but got Obj
			//IL_066a: Expected Obj, but got I
			//IL_0866: Expected Obj, but got I4
			//IL_08b6: Expected Obj, but got I4
			//IL_055c: Expected I, but got Obj
			//IL_0695: Expected I, but got Obj
			object obj = this - -64;
			obj = 0;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v98 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = (string)((!(atlas != null)) ? ((object)atlas) : ((object)tag));
			nint num3 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v12 (Il2CppClass<NGUITools>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v116 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			byte[] array = NGUITools.Load(text);
			if (array == null)
			{
				if ((nint)backgroundSprite != 1)
				{
					return;
				}
				nint num5 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v107 (Il2CppClass<NGUITools>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num6 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v112 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				NGUITools.SetActiveChildren((GameObject)(object)text, state: true);
			}
			object obj5 = this + 56;
			_0021_00210[] componentsInChildren = default;
			if ((object)background2DSprite != null)
			{
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S3_v8 (Il2CppMethodInfo)+18]");
				object obj6 = 0;
				object obj7 = obj6;
				object obj8 = obj7 & 0x1FFF;
				object obj9 = obj8 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v100 @ S4_v6 (should have been resolved before IL gen)");
			}
			else
			{
				componentsInChildren = (_0021_00210[])(object)((GameObject)(object)text).GetComponentsInChildren<T>();
			}
			obj5 = componentsInChildren;
			NGUIText.Alignment alignment = this.alignment;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v23 (NGUIText+Alignment)+C]");
			if ((nint)0 == 0)
			{
				if (highlightSprite == null)
				{
					return;
				}
				nint num8 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S1_v81 (Il2CppClass<NGUITools>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num9 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S1_v86 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				NGUITools.SetActiveChildren((GameObject)(object)atlas, state: false);
				return;
			}
			bool flag = fontSize == -1;
			object obj11 = flag ^ value;
			NGUIText.Alignment alignment2 = this.alignment;
			object obj12 = 0;
			object obj14 = default;
			TextAsset textAsset = default;
			object obj26 = default;
			TextAsset textAsset2 = default;
			while (true)
			{
				object obj13 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v31 (NGUIText+Alignment)+C]");
				if ((nint)obj13 >= 0)
				{
					break;
				}
				object obj15 = this.alignment + 16;
				object obj16 = obj14 << 2;
				object obj17 = obj15 + obj16;
				UITweener uITweener = (UITweener)obj17;
				if (uITweener.tweenGroup != (nint)bitmapFont)
				{
					goto IL_086b;
				}
				object obj18;
				if (obj12 != null)
				{
					obj18 = 1;
				}
				else
				{
					nint num10 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S0_v75 (Il2CppClass<NGUITools>)+BA]");
					object obj19 = (nint)0 & (nint)0x200;
					if (obj19 != null)
					{
						nint num11 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S0_v93 (Il2CppClass<NGUITools>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					byte[] array2 = NGUITools.Load(text);
					if (array2 != null)
					{
						obj18 = 0;
					}
					else
					{
						nint num12 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ S0_v82 (Il2CppClass<NGUITools>)+BA]");
						object obj20 = (nint)0 & (nint)0x200;
						if (obj20 != null)
						{
							nint num13 = (nint)typeof(NGUITools);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S0_v88 (Il2CppClass<NGUITools>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						NGUITools.SetActiveChildren((GameObject)(object)text, state: true);
						obj18 = 1;
					}
				}
				object obj21 = this - -64;
				object obj22 = this - -64;
				object obj23 = obj22 + 1;
				obj21 = obj23;
				object obj7;
				if (fontSize == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint cachedPtr = 0;
					((UnityEngine.Object)textAsset).m_CachedPtr = cachedPtr;
					_ = 0;
					object obj24 = textAsset + 16;
					obj24 = this;
					nint num14 = (nint)typeof(EventDelegate);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S1_v66 (Il2CppClass<EventDelegate>)+BA]");
					object obj25 = (nint)0 & (nint)0x200;
					if (obj25 != null)
					{
						nint num15 = (nint)typeof(EventDelegate);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S1_v72 (Il2CppClass<EventDelegate>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag2 = Localization.LoadCSV((byte[])(object)uITweener.onFinished, textAsset, true);
					uITweener.SetStartToCurrentValue();
					obj12 = obj18;
					obj7 = 0;
					goto IL_086b;
				}
				if (fontStyle == FontStyle.Normal)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPopupList)+1D]");
					if ((nint)0 == 0 || uITweener.isActiveAndEnabled)
					{
						goto IL_0613;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
				uITweener.Toggle();
				goto IL_0613;
				IL_086b:
				obj14 = obj26 + 1;
				continue;
				IL_0613:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint cachedPtr2 = 0;
				((UnityEngine.Object)textAsset2).m_CachedPtr = cachedPtr2;
				_ = 0;
				object obj27 = textAsset2 + 16;
				obj27 = this;
				nint num16 = (nint)typeof(EventDelegate);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ S1_v44 (Il2CppClass<EventDelegate>)+BA]");
				object obj28 = (nint)0 & (nint)0x200;
				if (obj28 != null)
				{
					nint num17 = (nint)typeof(EventDelegate);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ S1_v50 (Il2CppClass<EventDelegate>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag3 = Localization.LoadCSV((byte[])(object)uITweener.onFinished, textAsset2, true);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
				obj12 = obj18;
				obj7 = 0;
				goto IL_086b;
			}
		}
	}

	public LegacyEvent onSelectionChange
	{
		get
		{
			//IL_011b: Expected I, but got Obj
			//IL_0131: Expected Obj, but got I
			//IL_006f: Expected I, but got Obj
			//IL_0085: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00b0: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)trueTypeFont).FindKernel((string)null) != 0)
			{
				return (LegacyEvent)(object)trueTypeFont;
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)bitmapFont).FindKernel((string)null) != 0)
			{
				return (LegacyEvent)(object)bitmapFont;
			}
			return (LegacyEvent)(object)font;
		}
		set
		{
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected Obj, but got Unknown
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Expected Obj, but got Unknown
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected Obj, but got Unknown
			//IL_012b: Expected Obj, but got I4
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Expected Obj, but got Unknown
			//IL_013f: Expected Obj, but got I4
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Expected Obj, but got Unknown
			//IL_01a5: Expected Obj, but got I4
			//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Expected Obj, but got Unknown
			//IL_01b9: Expected Obj, but got I4
			LegacyEvent legacyEvent;
			if (value == null)
			{
				legacyEvent = null;
			}
			else
			{
				legacyEvent = (((object)value.GetType() != typeof(Font)) ? null : value);
			}
			if (legacyEvent != null)
			{
				object obj = this + 20;
				LegacyEvent legacyEvent2;
				if (value == null)
				{
					legacyEvent2 = null;
				}
				else
				{
					legacyEvent2 = (((object)value.GetType() != typeof(Font)) ? null : value);
				}
				obj = legacyEvent2;
				object obj2 = this + 16;
				obj2 = 0;
				object obj3 = this + 204;
				obj3 = 0;
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			object obj4 = default;
			if (obj4 != null)
			{
				object obj5 = this + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
				object obj6 = default;
				obj5 = obj6;
				object obj7 = this + 20;
				obj7 = 0;
				object obj8 = this + 204;
				obj8 = 0;
			}
		}
	}

	public static bool isOpen
	{
		get
		{
			//IL_00da: Expected I, but got Obj
			//IL_00f0: Expected Obj, but got I
			//IL_014b: Expected I, but got Obj
			//IL_0161: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00c2: Expected I4, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GameObject controllerNavigationObject = UICamera.controllerNavigationObject;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (controllerNavigationObject != null)
			{
				return false;
			}
			UIKeyNavigation component = controllerNavigationObject.GetComponent<UIKeyNavigation>();
			return (byte)(int)component != 0;
		}
	}

	public virtual string value
	{
		get
		{
			return (string)(object)mLegacyEvent;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 224;
			obj = value;
		}
	}

	public virtual object data => mSelectedItem;

	public Action callback
	{
		get
		{
			//IL_00a4: Expected Obj, but got I
			//IL_00b4: Expected Obj, but got I
			//IL_00c4: Expected Obj, but got I
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Expected Obj, but got Unknown
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected Obj, but got Unknown
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Expected Obj, but got Unknown
			List<string> list = items;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S4_v2 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S4_v3+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S4_v4+8C]");
			object obj3 = 0;
			object obj4 = obj3 & 0x7FF;
			object obj5 = obj4 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v32 @ S5_v4 (should have been resolved before IL gen)");
			int num2 = default;
			if (num2 > -1)
			{
				object obj6 = this - -64;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v8+C]");
				if ((nint)num2 < (nint)0)
				{
					object obj8 = this - -64;
					return (Action)((List<object>)obj8).get_Item(num2);
				}
				return null;
			}
			return null;
		}
	}

	public bool isColliderEnabled
	{
		get
		{
			//IL_0097: Expected Obj, but got I
			//IL_00a7: Expected Obj, but got I
			//IL_00b7: Expected Obj, but got I
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Expected Obj, but got Unknown
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected Obj, but got Unknown
			//IL_0056: Expected I4, but got Obj
			List<string> list = items;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S4_v2 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S4_v3+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S4_v4+8C]");
			object obj3 = 0;
			object obj4 = obj3 & 0x7FF;
			object obj5 = obj4 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v32 @ S5_v4 (should have been resolved before IL gen)");
			int num2 = default;
			if (num2 > -1)
			{
				List<Action> list2 = itemCallbacks;
				if (num2 < list2._size)
				{
					Action action = itemCallbacks.get_Item(num2);
					return (byte)(int)action != 0;
				}
				return false;
			}
			return false;
		}
	}

	protected bool isValid
	{
		get
		{
			//IL_0134: Expected I, but got Obj
			//IL_014a: Expected Obj, but got I
			//IL_007c: Expected I, but got Obj
			//IL_0092: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00bd: Expected I, but got Obj
			Collider component = GetComponent<Collider>();
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v33 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
			{
				return component.isTrigger;
			}
			Collider2D component2 = GetComponent<Collider2D>();
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v27 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component2).FindKernel((string)null) != 0)
			{
				return component2.isActiveAndEnabled;
			}
			return false;
		}
	}

	protected int activeFontSize
	{
		get
		{
			//IL_0101: Expected I, but got Obj
			//IL_0117: Expected Obj, but got I
			//IL_006e: Expected I, but got Obj
			//IL_0084: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00af: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)bitmapFont).FindKernel((string)null) != 0)
			{
				return 1;
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return ((ComputeShader)(object)trueTypeFont).FindKernel((string)null);
		}
	}

	protected float activeFontScale
	{
		get
		{
			//IL_0007: Expected F4, but got Obj
			return (float)highlight2DSprite;
		}
	}

	protected float fitScale
	{
		get
		{
			//IL_012f: Expected I, but got Obj
			//IL_0145: Expected Obj, but got I
			//IL_006e: Expected I, but got Obj
			//IL_0084: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00af: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)trueTypeFont).FindKernel((string)null) != 0)
			{
				return 1f;
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (bitmapFont != null)
			{
				return 1f;
			}
			UISpriteData sprite = bitmapFont.sprite;
			return (float)fontSize / (float)sprite;
		}
	}

	public unsafe void Set(string value, bool notify = true)
	{
		//IL_02a9: Expected I, but got Obj
		//IL_02bf: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_031b: Expected I, but got Obj
		//IL_0331: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected Obj, but got Unknown
		//IL_03f3: Expected I, but got Obj
		//IL_0409: Expected Obj, but got I
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_024f: Expected I, but got Obj
		//IL_0139: Expected I, but got Obj
		//IL_0186: Expected I, but got Obj
		//IL_019c: Expected Obj, but got I
		//IL_01c7: Expected I, but got Obj
		//IL_022f: Expected I4, but got Obj
		//IL_022f: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v72 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)this))
		{
			return;
		}
		string text = tag;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v68 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)(object)text))
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v44 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v64 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)(object)value))
			{
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v51 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v60 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (!((UnityEngine.Object)(object)value == (UnityEngine.Object)(object)text))
				{
					return;
				}
				int layer = ((GameObject)(object)value).layer;
				GameObject gameObject = base.gameObject;
				Transform child = ((Transform)layer).GetChild((int)gameObject);
				if ((object)child != null)
				{
					return;
				}
			}
		}
		((UIPlayTween)(object)this).OnPress(false);
		nint num9 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v25 (Il2CppClass<UICamera>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v37 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj6 = default;
		obj6.method_ptr = method_ptr;
		obj6.method = (nint)__ldftn(UIPlayTween.CustomHoverListener);
		object obj7 = obj6 + 16;
		obj7 = this;
		Delegate obj8 = ((Delegate)UICamera.onHover).RemoveImpl(obj6);
		nint num11 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v34 (Il2CppClass<UICamera>)+5C]");
		object obj9 = (nint)0 + (nint)184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj10 = default;
		obj9 = obj10;
	}

	public virtual void Clear()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		fontSize = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<EventDelegate> list = default;
		list._002Ector();
		object obj = this + 44;
		obj = list;
		CancelInvoke();
	}

	public virtual void AddItem(string text)
	{
		//IL_000f: Expected Obj, but got I4
		AddItem(text, (Action)1);
	}

	public virtual void AddItem(string text, Action del)
	{
		//IL_000f: Expected I4, but got Obj
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00bd: Expected Obj, but got I4
		if (mSelectedItem.get_Chars((int)text) == '\0')
		{
			return;
		}
		object obj = this + 152;
		obj = text;
		if (mSelectedItem != null)
		{
			if (del != null && mSelectedItem != null)
			{
				OnEnable();
			}
			if (~(keepValue ? 1u : 0u) != 0)
			{
				object obj2 = this + 152;
				obj2 = 0;
			}
		}
	}

	public virtual void AddItem(string text, object data, Action del = null)
	{
		//IL_000a: Expected I4, but got Obj
		//IL_0017: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I4
		//IL_006b: Expected Obj, but got I4
		//IL_006b: Expected Obj, but got I
		int numberOfSpaces = ((UIPowerupHandler)(object)this).getNumberOfSpaces((int)text);
		int layer = ((GameObject)numberOfSpaces).layer;
		((Transform)(nint)((Delegate)del).method_ptr).parentInternal = (Transform)layer;
		bool isModelActive = ((ModelScreenData)(object)del).isModelActive;
		int localScaleOnAllAxes = ((ModelScreenSetup)(object)del).localScaleOnAllAxes;
		((RenderTextureCamera)data)._002Ector((Camera)(nint)((Delegate)del).method_ptr, (GameObject)isModelActive, (RenderTexture)localScaleOnAllAxes);
	}

	public virtual void RemoveItem(string text)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		items.Add(text);
		object obj = this - -64;
		((List<object>)obj).Add((object)text);
		itemCallbacks.Add(null);
	}

	public virtual void RemoveItemByData(object data)
	{
		//IL_009b: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I
		//IL_00bb: Expected Obj, but got I
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		List<string> list = items;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S4_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S4_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S4_v4+8C]");
		object obj3 = 0;
		object obj4 = obj3 & 0x7FF;
		object obj5 = obj4 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v32 @ S5_v4 (should have been resolved before IL gen)");
		int num2 = default;
		if (num2 != -1)
		{
			items.RemoveAt(num2);
			object obj6 = this - -64;
			((List<object>)obj6).RemoveAt(num2);
			List<Action> list2 = itemCallbacks;
			if (num2 < list2._size)
			{
				itemCallbacks.RemoveAt(num2);
			}
		}
	}

	protected void TriggerCallbacks()
	{
		throw new IndexOutOfRangeException();
	}

	protected virtual void OnEnable()
	{
		//IL_001e: Expected I, but got Obj
		//IL_0034: Expected Obj, but got I
		//IL_00c2: Expected I, but got Obj
		//IL_00d8: Expected Obj, but got I
		//IL_005f: Expected I, but got Obj
		//IL_01de: Expected I, but got Obj
		//IL_01f4: Expected Obj, but got I
		//IL_0103: Expected I, but got Obj
		//IL_0150: Expected I, but got Obj
		//IL_0166: Expected Obj, but got I
		//IL_021f: Expected I, but got Obj
		//IL_02ec: Expected I, but got Obj
		//IL_0302: Expected Obj, but got I
		//IL_0191: Expected I, but got Obj
		//IL_032d: Expected I, but got Obj
		if (~(mExecuting ? 1u : 0u) == 0)
		{
			return;
		}
		mExecuting = true;
		nint num = (nint)typeof(UIPopupList);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v11 (Il2CppClass<UIPopupList>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIPopupList);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v63 (Il2CppClass<UIPopupList>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		current = this;
		if (mLegacyEvent != null)
		{
			mLegacyEvent.EndInvoke((IAsyncResult)(object)mSelectedItem);
		}
		nint num3 = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v8 (Il2CppClass<EventDelegate>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v42 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (Localization.LoadAndSelect((string)(object)onChange))
		{
			nint num5 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v33 (Il2CppClass<EventDelegate>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(EventDelegate);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v38 (Il2CppClass<EventDelegate>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Localization.dictionary = (Dictionary<string, string[]>)(object)onChange;
		}
		else
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)eventReceiver).FindKernel((string)null) != 0)
			{
				string text = functionName;
				if (functionName != null && text.m_stringLength != 0)
				{
					eventReceiver.BroadcastMessage(functionName, mSelectedItem, SendMessageOptions.DontRequireReceiver);
				}
			}
		}
		if (isColliderEnabled)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
		nint num9 = (nint)typeof(UIPopupList);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v32 (Il2CppClass<UIPopupList>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(UIPopupList);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v39 (Il2CppClass<UIPopupList>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		current = current;
		mExecuting = false;
	}

	protected virtual void OnValidate()
	{
		//IL_051c: Expected I, but got Obj
		//IL_0532: Expected Obj, but got I
		//IL_055d: Expected I, but got Obj
		//IL_0573: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0066: Expected Obj, but got I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_007a: Expected Obj, but got I4
		//IL_008d: Expected I, but got Obj
		//IL_0726: Expected I, but got Obj
		//IL_073c: Expected Obj, but got I
		//IL_0209: Expected I, but got Obj
		//IL_021f: Expected Obj, but got I
		//IL_0156: Expected I, but got Obj
		//IL_016c: Expected Obj, but got I
		//IL_0342: Expected I, but got Obj
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_011a: Expected Obj, but got I4
		//IL_038f: Expected I, but got Obj
		//IL_03a5: Expected Obj, but got I
		//IL_032f: Expected Obj, but got I4
		//IL_024a: Expected I, but got Obj
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected Obj, but got Unknown
		//IL_05d1: Expected Obj, but got I4
		//IL_0197: Expected I, but got Obj
		//IL_0138: Expected I4, but got Obj
		//IL_0659: Expected I4, but got Obj
		//IL_02a6: Expected I, but got Obj
		//IL_02bc: Expected Obj, but got I
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got Unknown
		//IL_03d0: Expected I, but got Obj
		//IL_02e7: Expected I, but got Obj
		//IL_0453: Expected I, but got Obj
		//IL_0469: Expected Obj, but got I
		//IL_0494: Expected I, but got Obj
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected Obj, but got Unknown
		//IL_04f5: Expected Obj, but got I4
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected Obj, but got Unknown
		//IL_0509: Expected Obj, but got I4
		nint num = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<EventDelegate>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v101 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (Localization.LoadAndSelect((string)(object)onChange))
		{
			object obj2 = this + 192;
			obj2 = 0;
			object obj3 = this + 196;
			obj3 = 0;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v93 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)font).FindKernel((string)null) != 0)
		{
			Font dynamicFont = font.dynamicFont;
			if ((object)dynamicFont != null)
			{
				object obj5 = this + 20;
				FontStyle dynamicFontStyle = font.dynamicFontStyle;
				obj5 = dynamicFontStyle;
				Texture dynamicTexture = font.dynamicTexture;
				fontStyle = (FontStyle)dynamicTexture;
				mUseDynamicFont = true;
			}
			else
			{
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S1_v72 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S1_v81 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (bitmapFont != null)
				{
					object obj7 = this + 16;
					obj7 = font;
					mUseDynamicFont = false;
				}
			}
			object obj8 = this + 204;
			obj8 = 0;
		}
		if (textScale != 0f)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v38 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v44 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GUILayoutOption gUILayoutOption;
			if (((ComputeShader)(object)bitmapFont).FindKernel((string)null) != 0)
			{
				UISpriteData sprite = bitmapFont.sprite;
				nint num9 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S2_v20 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num10 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S2_v26 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float width = (float)sprite * textScale;
				gUILayoutOption = GUILayout.Width(width);
			}
			else
			{
				gUILayoutOption = (GUILayoutOption)16;
			}
			fontSize = (int)gUILayoutOption;
			textScale = 0f;
		}
		nint num11 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S1_v52 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(trueTypeFont != null))
		{
			return;
		}
		nint num13 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num14 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S1_v48 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)bitmapFont).FindKernel((string)null) == 0)
		{
			return;
		}
		Font dynamicFont2 = bitmapFont.dynamicFont;
		if ((object)dynamicFont2 == null)
		{
			return;
		}
		UIFont uIFont = bitmapFont;
		nint num15 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num16 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S1_v44 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (uIFont.mReplacement != null)
		{
			object obj14 = this + 20;
			FontStyle dynamicFontStyle2 = bitmapFont.dynamicFontStyle;
			obj14 = dynamicFontStyle2;
			object obj15 = this + 16;
			obj15 = 0;
		}
	}

	public virtual void Start()
	{
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected Obj, but got Unknown
		//IL_0342: Expected Obj, but got I4
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected Obj, but got Unknown
		//IL_0356: Expected Obj, but got I4
		//IL_0364: Expected I, but got Obj
		//IL_037a: Expected Obj, but got I
		//IL_0137: Expected I, but got Obj
		//IL_014d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01ea: Expected I, but got Obj
		//IL_0200: Expected Obj, but got I
		//IL_0178: Expected I, but got Obj
		//IL_0416: Expected Obj, but got I
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_0104: Expected Obj, but got I4
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		//IL_022b: Expected I, but got Obj
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected Obj, but got Unknown
		//IL_02b8: Expected Obj, but got I4
		//IL_02d6: Expected I4, but got Obj
		//IL_02ef: Expected I4, but got Obj
		UIFont uIFont = bitmapFont;
		object obj = this + 16;
		obj = 0;
		object obj2 = this + 20;
		obj2 = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v71 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)trueTypeFont).FindKernel((string)null) != 0)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v52 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v67 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (bitmapFont != null || !mUseDynamicFont)
			{
				object obj5 = this + 16;
				obj5 = 0;
				object obj6 = this + 20;
				obj6 = trueTypeFont;
				mUseDynamicFont = true;
				return;
			}
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v47 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)bitmapFont).FindKernel((string)null) == 0)
		{
			object obj8 = this + 20;
			obj8 = trueTypeFont;
			mUseDynamicFont = true;
			return;
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (UIFont)+28]");
		if ((UnityEngine.Object)0 != null)
		{
			Font dynamicFont = bitmapFont.dynamicFont;
			if ((object)dynamicFont != null)
			{
				object obj10 = this + 20;
				FontStyle dynamicFontStyle = bitmapFont.dynamicFontStyle;
				obj10 = dynamicFontStyle;
				Texture dynamicTexture = bitmapFont.dynamicTexture;
				fontStyle = (FontStyle)dynamicTexture;
				UISpriteData sprite = bitmapFont.sprite;
				fontSize = (int)sprite;
				mUseDynamicFont = true;
			}
			else
			{
				object obj11 = this + 16;
				obj11 = bitmapFont;
				mUseDynamicFont = false;
			}
		}
	}

	protected unsafe virtual void OnLocalize()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0060: Expected Obj, but got I4
		//IL_01b6: Expected I, but got Obj
		//IL_01cc: Expected Obj, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_003d: Expected Obj, but got I4
		//IL_0073: Expected I, but got Obj
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_0104: Expected I, but got Obj
		//IL_011a: Expected Obj, but got I
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		//IL_0210: Expected Obj, but got I4
		//IL_0145: Expected I, but got Obj
		if (~(mStarted ? 1u : 0u) == 0)
		{
			return;
		}
		mStarted = true;
		if (~(keepValue ? 1u : 0u) == 0)
		{
			object obj = this + 152;
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
		else
		{
			object obj2 = this + 152;
			obj2 = 0;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)textLabel).FindKernel((string)null) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		EventDelegate.Callback callback = default;
		((Delegate)callback).method_ptr = method_ptr;
		((Delegate)callback).method = (nint)__ldftn(UILabel.SetCurrentSelection);
		object obj4 = callback + 16;
		obj4 = textLabel;
		nint num3 = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v20 (Il2CppClass<EventDelegate>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v27 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = EventDelegate.Remove(onChange, callback);
		object obj6 = this + 208;
		obj6 = 0;
	}

	protected virtual void Highlight(UILabel lbl, bool instant)
	{
		//IL_0023: Expected Obj, but got I4
		items.Add((string)(object)lbl);
		itemCallbacks.Add((Action)instant);
	}

	protected virtual Vector3 GetHighlightPosition()
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00bf: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I
		//IL_00df: Expected Obj, but got I
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_001a: Expected Obj, but got I
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_004a: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I
		Vector3 vector = default;
		object obj = vector - -64;
		object obj2 = obj;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S4_v2 (Il2CppMethodInfo)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S4_v3+60]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S4_v4+8C]");
		object obj5 = 0;
		object obj6 = obj5 & 0x7FF;
		object obj7 = obj6 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S5_v4 (should have been resolved before IL gen)");
		int num2 = default;
		if (num2 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+3C]");
			((List<string>)0).RemoveAt(num2);
			object obj8 = vector - -64;
			((List<object>)obj8).RemoveAt(num2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+44]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v10+C]");
			if ((nint)num2 < (nint)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+44]");
				((List<Action>)0).RemoveAt(num2);
			}
		}
		return vector;
	}

	protected virtual IEnumerator UpdateTweenPosition()
	{
		//IL_0119: Expected I, but got Obj
		//IL_012f: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v24 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)trueTypeFont).FindKernel((string)null) == 0)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (bitmapFont == null)
			{
				return (IEnumerator)bitmapFont.sprite;
			}
		}
		return (IEnumerator)fontSize;
	}

	protected virtual void OnItemHover(GameObject go, bool isOver)
	{
		//IL_014b: Expected Obj, but got I4
		//IL_015f: Expected I, but got Obj
		//IL_0175: Expected Obj, but got I
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_00fc: Expected VT, but got Obj
		object obj = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v45 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = (Transform)(obj + 12);
		if (((ComputeShader)(object)mHighlight).FindKernel((string)null) == 0)
		{
			return;
		}
		object obj3 = this + 168;
		obj3 = go;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		if (!isOver && ~(isAnimated ? 1u : 0u) == 0)
		{
			string go2 = mHighlight.tag;
			transform = (Transform)obj;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			TweenRotation tweenRotation = TweenRotation.Begin((GameObject)(object)go2, 0.1f, (Quaternion)transform);
			tweenRotation.method = UITweener.Method.EaseOut;
			if (!mTweening)
			{
				mTweening = true;
				Coroutine coroutine = StartCoroutine((IEnumerator)(object)"UpdateTweenPosition");
			}
		}
		else
		{
			Camera anchorCamera = mHighlight.anchorCamera;
			transform = (Transform)obj;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
		}
	}

	protected virtual void OnItemPress(GameObject go, bool isPressed)
	{
		if (isPressed)
		{
			UILabel component = go.GetComponent<UILabel>();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
		}
	}

	protected unsafe virtual void OnItemClick(GameObject go)
	{
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected Obj, but got Unknown
		//IL_02dc: Expected Obj, but got I4
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected Obj, but got Unknown
		//IL_02f9: Expected Obj, but got I4
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got Unknown
		//IL_0316: Expected Obj, but got I4
		//IL_032a: Expected I, but got Obj
		//IL_0340: Expected Obj, but got I
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected VT, but got Unknown
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Expected VT, but got Unknown
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected Obj, but got Unknown
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected Obj, but got Unknown
		//IL_0543: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_036f: Expected Obj, but got I
		//IL_0244: Expected I, but got Obj
		//IL_025a: Expected Obj, but got I
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0393: Expected Obj, but got I
		//IL_03a4: Expected Obj, but got F4
		//IL_0285: Expected I, but got Obj
		//IL_0139: Expected I, but got Obj
		//IL_0417: Expected Obj, but got I
		//IL_0428: Expected VT, but got Obj
		//IL_0431: Expected Obj, but got I4
		//IL_0440: Expected Obj, but got F4
		//IL_0461: Expected I, but got Obj
		//IL_0477: Expected Obj, but got I
		//IL_0185: Expected Obj, but got F4
		//IL_01a0: Expected Obj, but got I
		//IL_04a1: Expected F4, but got Obj
		//IL_049c: Expected native int or pointer, but got VT
		//IL_04b3: Expected F4, but got I
		//IL_04ae: Expected native int or pointer, but got VT
		//IL_04c0: Expected F4, but got Obj
		//IL_04bb: Expected native int or pointer, but got VT
		//IL_04d5: Expected F4, but got I
		//IL_04d0: Expected native int or pointer, but got VT
		//IL_01f7: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 72;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 56;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 40;
		obj4 = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v93 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 104);
		Vector3 vector2 = (Vector3)(obj2 + 88);
		object obj6 = obj2 + 24;
		Transform transform = (Transform)(obj2 + 12);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L1 (UnityEngine.GameObject)+A8]");
		if ((UnityEngine.Object)0 == null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v80 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L1 (UnityEngine.GameObject)+A4]");
			if ((UnityEngine.Object)0 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v76 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L1 (UnityEngine.GameObject)+C]");
				int num7 = ((ComputeShader)0).FindKernel(null);
				obj3 = vector.x;
				_ = vector.z;
				float num8;
				if (num7 != 0)
				{
					obj = vector.x;
					_ = vector.z;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L1 (UnityEngine.GameObject)+C]");
					float floatSpacingX = ((UILabel)0).floatSpacingX;
					obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					num8 = floatSpacingX;
				}
				else
				{
					obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
					_ = 0;
					num8 = 1f;
				}
				obj6 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
				_ = 0;
				float num9 = (float)obj6 * num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v29+C]");
				float num10 = 0f * num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L1 (UnityEngine.GameObject)+A8]");
				Camera anchorCamera = ((UIRect)0).anchorCamera;
				transform.localPosition = (Vector3)anchorCamera;
				obj2 = 0;
				_ = 0;
				object obj9 = 0f - num9;
				obj2 = obj9;
				_ = 1f;
				nint num11 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v70 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num12 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S0_v79 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector2)->x = (float)transform;
				((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
				((Vector3*)(nint)vector)->x = (float)obj2;
				Vector3 vector3 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Vector3*)(nint)vector3)->z = 0f;
				Vector3 vector4 = vector2 - vector;
				return;
			}
		}
		nint num13 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v38 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num14 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v43 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
	}

	private void Select(UILabel lbl, bool instant)
	{
		if (instant && selection == Selection.OnPress)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
	}

	protected virtual void OnNavigate(KeyCode key)
	{
		//IL_019e: Expected Obj, but got I4
		//IL_01ba: Expected Obj, but got I4
		//IL_0241: Expected Obj, but got I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_01eb: Expected F4, but got I
		//IL_01eb: Expected Obj, but got I
		//IL_0130: Expected I, but got Obj
		UILabel component = ((GameObject)key).GetComponent<UILabel>();
		((UISlider)this).OnPressBackground((GameObject)(object)component, true);
		UIEventListener component2 = ((GameObject)key).GetComponent<UIEventListener>();
		object parameter = component2.parameter;
		if (component2.parameter != null)
		{
			if ((object)parameter.GetType() != typeof(string))
			{
				parameter = null;
			}
		}
		else
		{
			parameter = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AA3B");
		object obj = 0;
		object obj4 = default;
		while (true)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v8+C]");
			if ((nint)obj2 >= 0)
			{
				break;
			}
			object obj3 = obj4 + 16;
			object obj5 = obj << 2;
			object obj6 = obj3 + obj5;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v18+10]");
			if ((nint)0 == 0)
			{
				nint num = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S2_v15 (Il2CppClass<NGUITools>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num2 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S2_v20 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v18+C]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v18+14]");
				TweenFill tweenFill = TweenFill.Begin((GameObject)num3, 0f, 1f);
			}
			object obj9 = obj + 1;
			obj = obj9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	protected virtual void OnKey(KeyCode key)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_02a2: Expected I, but got Obj
		//IL_02b8: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_0100: Expected Obj, but got I
		//IL_0110: Expected Obj, but got I
		//IL_0120: Expected Obj, but got I
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_02e3: Expected Obj, but got I4
		//IL_017f: Expected Obj, but got I4
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected I4, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected I4, but got Unknown
		if (!isActiveAndEnabled)
		{
			return;
		}
		nint num = (nint)typeof(UIPopupList);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppClass<UIPopupList>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIPopupList);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v35 (Il2CppClass<UIPopupList>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(current != this))
		{
			return;
		}
		List<UILabel> list = mLabelList;
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S4_v3 (Il2CppMethodInfo)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S4_v4+60]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S4_v5+8C]");
		object obj5 = 0;
		object obj6 = obj5 & 0x7FF;
		object obj7 = obj6 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S5_v5 (should have been resolved before IL gen)");
		object obj8 = default;
		bool flag = (nint)obj8 == -1;
		bool flag2 = !flag;
		object obj9 = obj8;
		if (!flag2)
		{
			obj9 = 0;
		}
		object obj10 = key - 273;
		if (key != KeyCode.UpArrow)
		{
			if ((nint)obj10 == 1)
			{
				object obj11 = obj9 + 1;
				List<UILabel> list2 = mLabelList;
				if ((nint)obj11 < list2._size)
				{
					int index = obj9 + 1;
					UILabel go = mLabelList.get_Item(index);
					((UISlider)this).OnPressBackground((GameObject)(object)go, false);
				}
			}
		}
		else if ((nint)obj9 > 0)
		{
			int index2 = obj9 - 1;
			UILabel go2 = mLabelList.get_Item(index2);
			((UISlider)this).OnPressBackground((GameObject)(object)go2, false);
		}
	}

	protected virtual void OnDisable()
	{
		if (~(isLocalized ? 1u : 0u) == 0)
		{
			OnEnable();
		}
	}

	protected virtual void OnSelect(bool isSelected)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_023c: Expected I, but got Obj
		//IL_0252: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_01bd: Expected I, but got Obj
		if (!isActiveAndEnabled)
		{
			return;
		}
		nint num = (nint)typeof(UIPopupList);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppClass<UIPopupList>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIPopupList);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v51 (Il2CppClass<UIPopupList>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(current != this))
		{
			return;
		}
		nint num5 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v18 (Il2CppClass<UICamera>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v45 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UICamera uICamera = UICamera.current;
		if (uICamera.cancelKey0 != (isSelected ? ((KeyCode)1) : KeyCode.None))
		{
			nint num7 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v30 (Il2CppClass<UICamera>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v39 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera uICamera2 = UICamera.current;
			if (uICamera2.cancelKey1 != (isSelected ? ((KeyCode)1) : KeyCode.None))
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
	}

	public static void Close()
	{
	}

	public virtual void CloseSelf()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	protected virtual void AnimateColor(UIWidget widget)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_043e: Expected I, but got Obj
		//IL_0454: Expected Obj, but got I
		//IL_047b: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_04c0: Expected I, but got Obj
		//IL_04d6: Expected Obj, but got I
		//IL_05e9: Expected Obj, but got I4
		//IL_012f: Expected I, but got Obj
		//IL_01c9: Expected I, but got Obj
		//IL_01df: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_0502: Expected I, but got Obj
		//IL_0518: Expected Obj, but got I
		//IL_020a: Expected I, but got Obj
		//IL_0257: Expected I, but got Obj
		//IL_02a4: Expected I, but got Obj
		//IL_02ba: Expected Obj, but got I
		//IL_053f: Expected Obj, but got I4
		//IL_02e5: Expected I, but got Obj
		//IL_0332: Expected I, but got Obj
		//IL_0348: Expected Obj, but got I
		//IL_0577: Expected Obj, but got I4
		//IL_0589: Expected I, but got Obj
		//IL_059f: Expected Obj, but got I
		//IL_05c9: Expected Obj, but got I4
		//IL_05c9: Expected Obj, but got I4
		//IL_0373: Expected I, but got Obj
		//IL_03c0: Expected I, but got Obj
		if ((object)widget != null)
		{
			return;
		}
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v96 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int touchCount = UICamera.touchCount;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v92 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!((UnityEngine.Object)touchCount != null))
		{
			nint num5 = (nint)typeof(UIPopupList);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v26 (Il2CppClass<UIPopupList>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UIPopupList);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v86 (Il2CppClass<UIPopupList>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v34 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v82 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!((UnityEngine.Object)touchCount == mChild))
			{
				return;
			}
			nint num9 = (nint)typeof(UIPopupList);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v41 (Il2CppClass<UIPopupList>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(UIPopupList);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v76 (Il2CppClass<UIPopupList>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num11 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num12 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mChild).FindKernel((string)null) != 0)
			{
				nint num13 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v50 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num14 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v72 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)touchCount).FindKernel(null) != 0)
				{
					nint num15 = (nint)typeof(UIPopupList);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v57 (Il2CppClass<UIPopupList>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num16 = (nint)typeof(UIPopupList);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v66 (Il2CppClass<UIPopupList>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int layer = mChild.layer;
					int layer2 = ((GameObject)touchCount).layer;
					nint num17 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S2_v10 (Il2CppClass<NGUITools>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num18 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S2_v15 (Il2CppClass<NGUITools>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (NGUITools.Save((string)layer, (byte[])layer2))
					{
						return;
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	protected virtual void AnimatePosition(UIWidget widget, bool placeAbove, float bottom)
	{
		//IL_00f2: Expected Obj, but got I4
		//IL_0017: Expected Obj, but got I4
		//IL_0041: Invalid comparison between F4 and I8
		//IL_00b1: Expected Obj, but got I4
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		WWW wWW = default;
		wWW.LoadImageIntoTexture((Texture2D)placeAbove);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Stopwatch stopwatch = default;
		stopwatch.Stop();
		object obj = 0;
		while (true)
		{
			Dictionary<string, string> responseHeaders = wWW.responseHeaders;
			object obj2 = obj | (object)responseHeaders;
			if (obj2 != null)
			{
				break;
			}
			float num = bottom * 1000f;
			long elapsedTicks = stopwatch.ElapsedTicks;
			if (num < (float)elapsedTicks)
			{
				obj = 1;
			}
		}
		((ArrayConverter)(object)stopwatch)._002Ector();
		Dictionary<string, string> responseHeaders2 = wWW.responseHeaders;
		Dictionary<string, string> responseHeaders3 = wWW.responseHeaders;
		Texture2D texture = wWW.texture;
		UIPopupList uIPopupList = (UIPopupList)0;
		object obj3 = responseHeaders3 & 1;
		uIPopupList = (UIPopupList)obj3;
		object obj4 = this + 4;
		obj4 = texture;
	}

	protected virtual void AnimateScale(UIWidget widget, bool placeAbove, float bottom)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0025: Expected Obj, but got I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0042: Expected Obj, but got I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_0070: Expected VT, but got Obj
		//IL_013b: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got I4
		//IL_0190: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 + 12;
		object obj3 = obj2 + 36;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		_ = 0;
		Transform transform = (Transform)(obj2 + 48);
		Camera anchorCamera = widget.anchorCamera;
		transform.localPosition = (Vector3)anchorCamera;
		obj3 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		if (placeAbove)
		{
			transform = (Transform)obj3;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			_ = 0;
			obj2 = 0;
			_ = 0;
			obj2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
			_ = 0;
		}
		else
		{
			transform = (Transform)obj3;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			_ = 0;
			obj2 = 0;
			_ = 0;
			obj2 = transform;
			_ = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
			_ = 0;
		}
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Camera anchorCamera2 = widget.anchorCamera;
		transform = (Transform)obj4;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		string go = widget.tag;
		transform = (Transform)obj3;
		Transform transform5 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		TweenRotation tweenRotation = TweenRotation.Begin((GameObject)(object)go, 0.15f, (Quaternion)transform);
		tweenRotation.method = UITweener.Method.EaseOut;
	}

	protected void Animate(UIWidget widget, bool placeAbove, float bottom)
	{
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected Obj, but got Unknown
		//IL_02cc: Expected Obj, but got I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_0065: Expected Obj, but got I4
		//IL_007b: Expected Obj, but got F4
		//IL_00b0: Expected I, but got F4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00f3: Expected I, but got Obj
		//IL_0109: Expected Obj, but got I
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected Obj, but got Unknown
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected Obj, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected Obj, but got Unknown
		//IL_0134: Expected I, but got Obj
		//IL_0180: Expected VT, but got Obj
		//IL_01d7: Expected Obj, but got I4
		//IL_029e: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 + 60;
		obj = 0;
		_ = 0;
		string go = widget.tag;
		Camera anchorCamera = widget.anchorCamera;
		float num = ((UIProgressBar)this).value;
		IEnumerator enumerator = UpdateTweenPosition();
		float num2 = fitScale;
		float num3 = (float)enumerator * num2;
		float num4 = mBgBorder * 2f;
		float num5 = num3 + num4;
		Transform transform = (Transform)(obj2 + 48);
		transform = (Transform)0;
		((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)0;
		transform = (Transform)num;
		float num6 = num * num5;
		float num7 = num6 / (float)widget.mHeight;
		((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)num;
		Transform transform2 = (Transform)(obj2 + 72);
		transform2 = transform;
		((UnityEngine.Object)transform2).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
		((Transform)(object)anchorCamera).parent = transform2;
		nint num8 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v34 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num9 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v80 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 24;
		object obj5 = obj2 + 12;
		object obj6 = obj2 + 36;
		Vector3 forward = Vector3.forward;
		transform2 = (Transform)obj6;
		Transform transform3 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v43+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		TweenTransform tweenTransform = TweenTransform.Begin((GameObject)(object)go, 0.15f, transform2);
		tweenTransform.method = UITweener.Method.EaseOut;
		if (placeAbove)
		{
			transform.localPosition = (Vector3)anchorCamera;
			obj = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			obj6 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			obj2 = 0;
			_ = 0;
			obj2 = obj6;
			float num10 = num * (float)widget.mHeight;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v39+4]");
			float num11 = 0f - num10;
			float num12 = num * num5;
			float num13 = num11 + num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v41+8]");
			_ = 0;
			transform2 = (Transform)obj2;
			Transform transform4 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform2.eulerAngles;
			transform2 = (Transform)obj;
			Transform transform5 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
			TweenRotation tweenRotation = TweenRotation.Begin((GameObject)(object)go, 0.15f, (Quaternion)transform2);
			tweenRotation.method = UITweener.Method.EaseOut;
		}
	}

	protected virtual void OnClick()
	{
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0670: Expected Obj, but got Unknown
		//IL_0679: Expected Obj, but got I4
		//IL_068d: Expected I, but got Obj
		//IL_06a3: Expected Obj, but got I
		//IL_08dc: Expected I, but got Obj
		//IL_08f2: Expected Obj, but got I
		//IL_0a41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a46: Expected I4, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_06cf: Expected I, but got Obj
		//IL_06e5: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		//IL_0185: Expected I4, but got Obj
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_0199: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(UIPopupList);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<UIPopupList>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UIPopupList);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v170 (Il2CppClass<UIPopupList>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v100 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num5 = obj2 + 32;
		if (((ComputeShader)(object)mChild).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num6 = (nint)typeof(UIPopupList);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v23 (Il2CppClass<UIPopupList>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num7 = (nint)typeof(UIPopupList);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v164 (Il2CppClass<UIPopupList>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num8 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S1_v96 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (current != this)
		{
			useGUILayout = (byte)(int)"CloseIfUnselected" != 0;
			object obj7 = this + 184;
			obj7 = 0;
			throw new IndexOutOfRangeException();
		}
	}

	protected virtual void OnDoubleClick()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_02f5: Expected I, but got Obj
		//IL_030b: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_0223: Expected I, but got Obj
		//IL_0239: Expected Obj, but got I
		//IL_0264: Expected I, but got Obj
		int renderedFrameCount = Time.renderedFrameCount;
		if (mOpenFrame == renderedFrameCount)
		{
			return;
		}
		nint num = (nint)typeof(UIPopupList);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10 (Il2CppClass<UIPopupList>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIPopupList);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v50 (Il2CppClass<UIPopupList>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(mChild != null))
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mHighlightedLabel).FindKernel((string)null) != 0)
			{
				string text = mHighlightedLabel.tag;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
			}
		}
		else
		{
			if (openOn == OpenOn.DoubleClick || openOn == OpenOn.Manual)
			{
				return;
			}
			if (openOn == OpenOn.RightClick)
			{
				nint num7 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v31 (Il2CppClass<UICamera>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v39 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (UICamera.currentTouchID != -2)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	private IEnumerator CloseIfUnselected()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		return enumerator;
	}

	public virtual void Show()
	{
		if (openOn == OpenOn.DoubleClick)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	public UIPopupList()
	{
		//IL_27ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_27cf: Expected Obj, but got Unknown
		//IL_27d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_27dd: Expected VT, but got Unknown
		//IL_27e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_27eb: Expected Obj, but got Unknown
		//IL_27f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_27f9: Expected Obj, but got Unknown
		//IL_2802: Unknown result type (might be due to invalid IL or missing references)
		//IL_2807: Expected Obj, but got Unknown
		//IL_2810: Unknown result type (might be due to invalid IL or missing references)
		//IL_2815: Expected Obj, but got Unknown
		//IL_281e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2823: Expected Obj, but got Unknown
		//IL_282c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2831: Expected Obj, but got Unknown
		//IL_283a: Unknown result type (might be due to invalid IL or missing references)
		//IL_283f: Expected Obj, but got Unknown
		//IL_2848: Unknown result type (might be due to invalid IL or missing references)
		//IL_284d: Expected VT, but got Unknown
		//IL_2856: Unknown result type (might be due to invalid IL or missing references)
		//IL_285b: Expected Obj, but got Unknown
		//IL_2864: Unknown result type (might be due to invalid IL or missing references)
		//IL_2869: Expected Obj, but got Unknown
		//IL_2872: Unknown result type (might be due to invalid IL or missing references)
		//IL_2877: Expected Obj, but got Unknown
		//IL_2880: Unknown result type (might be due to invalid IL or missing references)
		//IL_2885: Expected Obj, but got Unknown
		//IL_288e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2893: Expected Obj, but got Unknown
		//IL_289c: Unknown result type (might be due to invalid IL or missing references)
		//IL_28a1: Expected Obj, but got Unknown
		//IL_28aa: Expected Obj, but got I4
		//IL_28b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_28be: Expected Obj, but got Unknown
		//IL_28c7: Expected Obj, but got I4
		//IL_28d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_28db: Expected Obj, but got Unknown
		//IL_28e4: Expected Obj, but got I4
		//IL_28f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_28f8: Expected Obj, but got Unknown
		//IL_2901: Expected Obj, but got I4
		//IL_2910: Unknown result type (might be due to invalid IL or missing references)
		//IL_2915: Expected Obj, but got Unknown
		//IL_291e: Expected Obj, but got I4
		//IL_292d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2932: Expected Obj, but got Unknown
		//IL_293b: Expected Obj, but got I4
		//IL_294a: Unknown result type (might be due to invalid IL or missing references)
		//IL_294f: Expected Obj, but got Unknown
		//IL_2958: Expected Obj, but got I4
		//IL_2967: Unknown result type (might be due to invalid IL or missing references)
		//IL_296c: Expected Obj, but got Unknown
		//IL_2975: Expected Obj, but got I4
		//IL_298a: Unknown result type (might be due to invalid IL or missing references)
		//IL_298f: Expected Obj, but got Unknown
		//IL_2998: Expected Obj, but got I4
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		//IL_00ab: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_29f3: Expected I, but got Obj
		//IL_2a09: Expected Obj, but got I
		//IL_00ec: Expected I, but got Obj
		//IL_0139: Expected I, but got Obj
		UIWidget uIWidget = default;
		Transform transform = (Transform)(uIWidget + 304);
		Vector2 vector = (Vector2)(uIWidget + 72);
		object obj = uIWidget + 16;
		object obj2 = uIWidget - -64;
		Transform transform2 = (Transform)(uIWidget + 176);
		Transform transform3 = (Transform)(uIWidget + 160);
		Transform transform4 = (Transform)(uIWidget + 144);
		object obj3 = uIWidget + 56;
		object obj4 = uIWidget + 48;
		Vector2 vector2 = (Vector2)(uIWidget + 132);
		object obj5 = uIWidget + 120;
		object obj6 = uIWidget + 108;
		object obj7 = uIWidget + 96;
		object obj8 = uIWidget + 40;
		object obj9 = uIWidget + 32;
		object obj10 = uIWidget + 292;
		obj10 = 0;
		_ = 0;
		object obj11 = uIWidget + 280;
		obj11 = 0;
		_ = 0;
		object obj12 = uIWidget + 264;
		obj12 = 0;
		_ = 0;
		object obj13 = uIWidget + 252;
		obj13 = 0;
		_ = 0;
		object obj14 = uIWidget + 240;
		obj14 = 0;
		_ = 0;
		object obj15 = uIWidget + 228;
		obj15 = 0;
		_ = 0;
		object obj16 = uIWidget + 216;
		obj16 = 0;
		_ = 0;
		object obj17 = uIWidget + 192;
		obj17 = 0;
		_ = 0;
		_ = 0;
		object obj18 = uIWidget + 188;
		obj18 = 0;
		if (isActiveAndEnabled)
		{
			string fileName = tag;
			nint num = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S1_v51 (Il2CppClass<NGUITools>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num2 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S1_v1002 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			byte[] array = NGUITools.Load(fileName);
			if (array != null)
			{
				nint num3 = (nint)typeof(UIPopupList);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ S0_v77 (Il2CppClass<UIPopupList>)+BA]");
				object obj20 = (nint)0 & (nint)0x200;
				if (obj20 != null)
				{
					nint num4 = (nint)typeof(UIPopupList);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ S0_v1132 (Il2CppClass<UIPopupList>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ S1_v58 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj21 = (nint)0 & (nint)0x200;
				if (obj21 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S1_v998 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (mChild != null && activeFontSize != 0)
				{
					List<string> list = items;
					if (list._size >= 1)
					{
						throw new IndexOutOfRangeException();
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
	}

	static UIPopupList()
	{
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0192: Expected I, but got Obj
		//IL_01a8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(UIPopupList);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIPopupList>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIPopupList);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v30 (Il2CppClass<UIPopupList>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)current).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num5 = (nint)typeof(UIPopupList);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v16 (Il2CppClass<UIPopupList>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UIPopupList);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v24 (Il2CppClass<UIPopupList>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		current = null;
	}
}

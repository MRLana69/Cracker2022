using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using SYBO.Components.Utilities;
using UI.Screens;
using UnityEngine;
using UnityEngine.UI;
using UnityEngineInternal;

public class HUDFPS : MonoBehaviour
{
	private sealed class _003CFPS_003Ed__26(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public HUDFPS _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_04c7: Expected Obj, but got Unknown
				//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_04d5: Expected Obj, but got Unknown
				//IL_04de: Unknown result type (might be due to invalid IL or missing references)
				//IL_04e3: Expected Obj, but got Unknown
				//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
				//IL_04f1: Expected Obj, but got Unknown
				//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
				//IL_04ff: Expected Obj, but got Unknown
				//IL_0508: Unknown result type (might be due to invalid IL or missing references)
				//IL_050d: Expected Obj, but got Unknown
				//IL_0516: Unknown result type (might be due to invalid IL or missing references)
				//IL_051b: Expected Obj, but got Unknown
				//IL_0524: Expected Obj, but got I4
				//IL_0533: Unknown result type (might be due to invalid IL or missing references)
				//IL_0538: Expected Obj, but got Unknown
				//IL_0541: Expected Obj, but got I4
				//IL_0550: Unknown result type (might be due to invalid IL or missing references)
				//IL_0555: Expected Obj, but got Unknown
				//IL_055e: Expected Obj, but got I4
				//IL_0056: Expected I, but got Obj
				//IL_006c: Expected Obj, but got I
				//IL_0097: Expected I, but got Obj
				//IL_0688: Unknown result type (might be due to invalid IL or missing references)
				//IL_068d: Expected Obj, but got Unknown
				//IL_08af: Expected I, but got Obj
				//IL_08c5: Expected Obj, but got I
				//IL_025f: Expected I, but got Obj
				//IL_01a4: Expected I, but got Obj
				//IL_01ba: Expected Obj, but got I
				//IL_01e5: Expected I, but got Obj
				//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_07b6: Expected Obj, but got Unknown
				//IL_0842: Unknown result type (might be due to invalid IL or missing references)
				//IL_0847: Expected Obj, but got Unknown
				//IL_0864: Expected Obj, but got F4
				//IL_087b: Expected Obj, but got F4
				//IL_0892: Expected Obj, but got F4
				//IL_036a: Unknown result type (might be due to invalid IL or missing references)
				//IL_036f: Expected Obj, but got Unknown
				//IL_0399: Expected Obj, but got F4
				//IL_03b5: Expected Obj, but got F4
				//IL_03cc: Expected Obj, but got F4
				//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e9: Expected Obj, but got Unknown
				//IL_0413: Expected Obj, but got F4
				//IL_042b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0430: Expected Obj, but got Unknown
				//IL_0493: Unknown result type (might be due to invalid IL or missing references)
				//IL_0498: Expected Obj, but got Unknown
				//IL_04b4: Expected Obj, but got I4
				object obj2 = default;
				object obj = obj2 + 72;
				object obj3 = obj2 + 20;
				object obj4 = obj2 + 16;
				object obj5 = obj2 + 12;
				object obj6 = obj2 + 8;
				object obj7 = obj2 + 4;
				object obj8 = obj2 + 56;
				obj8 = 0;
				_ = 0;
				object obj9 = obj2 + 40;
				obj9 = 0;
				_ = 0;
				object obj10 = obj2 + 24;
				obj10 = 0;
				_ = 0;
				HUDFPS hUDFPS = _003C_003E4__this;
				if (_003C_003E1__state != 0 && _003C_003E1__state != 1)
				{
					return null;
				}
				_003C_003E1__state = -1;
				nint num = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v42 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num2 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v174 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num3 = hUDFPS.accum / (float)hUDFPS.frames;
				float fpsMin = ((!(hUDFPS.fpsMin < num3)) ? num3 : hUDFPS.fpsMin);
				hUDFPS.fpsMin = fpsMin;
				float fpsMax = hUDFPS.fpsMax;
				if (!(hUDFPS.fpsMax > num3))
				{
					fpsMax = num3;
				}
				hUDFPS.fpsMax = fpsMax;
				if (!(num3 < 30f))
				{
					Color blue = Color.blue;
				}
				else if (num3 > 10f)
				{
					Color green = Color.green;
				}
				else
				{
					Color magenta = Color.magenta;
				}
				obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				obj = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
				_ = 0;
				object obj12 = hUDFPS + 56;
				obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				float num7;
				if (hUDFPS.timeMaxFrame > 0f)
				{
					float num4 = 1f / hUDFPS.timeMaxFrame;
					if (num4 > 0f)
					{
						nint num5 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S0_v160 (Il2CppClass<UnityEngine.Mathf>)+BA]");
						object obj13 = (nint)0 & (nint)0x200;
						if (obj13 != null)
						{
							nint num6 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v165 (Il2CppClass<UnityEngine.Mathf>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						float minFpsMin = ((!(hUDFPS.minFpsMin < num4)) ? num4 : hUDFPS.minFpsMin);
						hUDFPS.minFpsMin = minFpsMin;
					}
					num7 = num4;
				}
				else
				{
					num7 = 0f;
				}
				nint num8 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v65 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj14 = (nint)0 & (nint)0x200;
				if (obj14 != null)
				{
					nint num9 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S0_v148 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float minFpsMax = ((!(hUDFPS.minFpsMax > num7)) ? num7 : hUDFPS.minFpsMax);
				hUDFPS.minFpsMax = minFpsMax;
				if (!(num7 < 30f))
				{
					Color blue2 = Color.blue;
				}
				else if (num7 > 10f)
				{
					Color green2 = Color.green;
				}
				else
				{
					Color magenta2 = Color.magenta;
				}
				obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				obj = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v24+8]");
				_ = 0;
				object obj15 = hUDFPS + 72;
				obj15 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				float num10 = hUDFPS.accumTotal / (float)hUDFPS.framesTotal;
				if (!(num10 < 30f))
				{
					Color blue3 = Color.blue;
				}
				else if (num10 > 10f)
				{
					Color green3 = Color.green;
				}
				else
				{
					Color magenta3 = Color.magenta;
				}
				obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				obj = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v27+8]");
				_ = 0;
				object obj16 = hUDFPS + 88;
				obj16 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				obj = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				obj3 = hUDFPS.fpsMin;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				obj4 = hUDFPS.fpsMax;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				object obj17 = hUDFPS + 136;
				string format = default;
				object arg = default;
				object arg2 = default;
				string text = string.Format((IFormatProvider)(object)"{0:F1} FPS ({1:F1} - {2:F1})", format, arg, arg2);
				obj17 = text;
				obj5 = num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				obj6 = hUDFPS.minFpsMin;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				obj7 = hUDFPS.minFpsMax;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				object obj18 = hUDFPS + 140;
				string format2 = default;
				object arg3 = default;
				object arg4 = default;
				string text2 = string.Format((IFormatProvider)(object)"{0:F1} MIN ({1:F1} - {2:F1})", format2, arg3, arg4);
				obj18 = text2;
				obj2 = num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				object obj19 = hUDFPS + 144;
				object[] args = default;
				string text3 = $"{args:F1} AVG";
				obj19 = text3;
				hUDFPS.accum = 0f;
				hUDFPS.frames = 0;
				hUDFPS.timeMaxFrame = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = hUDFPS.frequency;
				object obj20 = this + 12;
				object obj21 = default;
				obj20 = obj21;
				_003C_003E1__state = 1;
				return 1;
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

	public Rect windowRect;

	public bool updateColor;

	public bool allowDrag;

	public float frequency;

	public int nbDecimal;

	private float accum;

	private int frames;

	private float accumTotal;

	private int framesTotal;

	private Color color;

	private Color minColor;

	private Color avgColor;

	private float minFpsMin;

	private float minFpsMax;

	private float fpsMin;

	private float fpsMax;

	private Rect windowRectPrev;

	private string sFPS;

	private string sMinFPS;

	private string sAvgFPS;

	private GUIStyle style;

	private float timeMaxFrame;

	private void Start()
	{
		((UpgradeScreen)this).Start();
	}

	private void Update()
	{
		Reset();
	}

	public void StartFpsCounter()
	{
		//IL_000e: Expected VT, but got Obj
		//IL_00ba: Expected I, but got Obj
		//IL_00d0: Expected Obj, but got I
		//IL_00fb: Expected I, but got Obj
		float unscaledTime = Time.unscaledTime;
		if (!(unscaledTime > 0f))
		{
			return;
		}
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float unscaledTime2 = Time.unscaledTime;
		float num = realtimeSinceStartup / unscaledTime2;
		float num2 = accum + num;
		accum = num2;
		float num3 = accumTotal + num;
		accumTotal = num3;
		int num4 = frames + 1;
		frames = num4;
		int num5 = framesTotal + 1;
		framesTotal = num5;
		float unscaledTime3 = Time.unscaledTime;
		nint num6 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v25 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num7 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v30 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num8 = ((!(timeMaxFrame > unscaledTime3)) ? unscaledTime3 : timeMaxFrame);
		timeMaxFrame = num8;
	}

	private void Reset()
	{
		OnGUI();
		WeightList layoutWeights = ((LinearLayout)this).LayoutWeights;
		Coroutine coroutine = StartCoroutine_Auto((IEnumerator)layoutWeights);
	}

	private IEnumerator FPS()
	{
		//IL_001f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HUDFPS)+19]");
		bool flag = (nint)0 != 0;
		return (IEnumerator)flag;
	}

	private void OnGUI()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		fpsMin = float.MaxValue;
		fpsMax = 0f;
		minFpsMin = float.MaxValue;
		minFpsMax = 0f;
		accum = 0f;
		frames = 0;
		accumTotal = 0f;
		framesTotal = 0;
		object obj = this + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v11+8]");
		_ = 0;
		object obj3 = obj2 + 16;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj4 = this + 120;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v15+8]");
		_ = 0;
	}

	private void DoMyWindow(int windowID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0041: Expected Obj, but got I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00a2: Expected Obj, but got I4
		//IL_00af: Expected VT, but got I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00f3: Expected VT, but got I4
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_015c: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - -64;
		Transform transform = (Transform)(obj2 + 32);
		Transform transform2 = (Transform)(obj2 + 16);
		object obj3 = obj2 + 48;
		obj3 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HUDFPS)+60]");
		if ((nint)0 == 0)
		{
			float num = ScrollRect.RubberDelta(0f, 0.5f);
			object obj4 = this + 16;
			obj4 = windowID;
			transform.localPosition = (Vector3)windowID;
			obj = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			object obj5 = this + 20;
			obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
			_ = 0;
			transform2.localRotation = (Quaternion)windowID;
			obj3 = transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F950");
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj6 = this + 32;
			obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
			_ = 0;
			bool isAnimating = ((UISpinner)this).IsAnimating;
			Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])isAnimating);
			_ = 1;
		}
	}

	public unsafe HUDFPS()
	{
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected Obj, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected Obj, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0148: Expected Obj, but got I
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_0169: Expected I, but got Obj
		//IL_017f: Expected Obj, but got I
		//IL_0290: Expected VT, but got I4
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_01aa: Expected I, but got Obj
		//IL_0257: Expected Obj, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_0054: Expected I, but got Obj
		//IL_00f7: Expected Obj, but got I4
		object obj = default;
		GUIStyle gUIStyle = (GUIStyle)(obj + 32);
		object obj2 = obj + 16;
		if (style == null)
		{
			nint num = (nint)typeof(GUI);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v45 (Il2CppClass<UnityEngine.GUI>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(GUI);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v62 (Il2CppClass<UnityEngine.GUI>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GenericStack scrollViewStates = GUI.scrollViewStates;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v50 (UnityEngineInternal.GenericStack)+1C]");
			GUIStyle gUIStyle2 = default;
			gUIStyle2.name = (string)0;
			object obj4 = this + 148;
			obj4 = gUIStyle2;
			RectOffset margin = style.margin;
			Color black = Color.black;
			gUIStyle = (GUIStyle)obj2;
			GUIStyle gUIStyle3 = gUIStyle;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			gUIStyle3.m_Ptr = (IntPtr)0;
			((GUIStyleState)(object)margin).set_textColor_Injected(ref *(Color*)gUIStyle);
			Vector2 contentOffset = ((GUIStyle)4).contentOffset;
		}
		object obj5 = this + 12;
		obj2 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint ptr = 0;
		GUIStyle gUIStyle4 = default;
		gUIStyle4.m_Ptr = ptr;
		gUIStyle4.m_Active = (GUIStyleState)0;
		object obj6 = gUIStyle4 + 16;
		obj6 = this;
		nint num3 = (nint)typeof(GUI);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v25 (Il2CppClass<UnityEngine.GUI>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(GUI);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v40 (Il2CppClass<UnityEngine.GUI>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		gUIStyle = (GUIStyle)obj2;
		GUIStyle gUIStyle5 = gUIStyle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		gUIStyle5.m_Ptr = (IntPtr)0;
		Vector2 vector = GUILayout.BeginScrollView((Vector2)0, gUIStyle, gUIStyle4, (GUILayoutOption[])(object)"");
		gUIStyle = (GUIStyle)obj;
		GUIStyle gUIStyle6 = gUIStyle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		gUIStyle6.m_Ptr = (IntPtr)0;
		object obj8 = this + 12;
		obj8 = gUIStyle;
		_ = gUIStyle.m_Ptr;
	}
}

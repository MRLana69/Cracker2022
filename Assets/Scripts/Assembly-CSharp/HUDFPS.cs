using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using UnityEngine;

public class HUDFPS : MonoBehaviour
{
	private sealed class _003CFPS_003Ed__26(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public HUDFPS _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_039c: Expected VT, but got F4
			//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03aa: Expected Obj, but got Unknown
			//IL_03d8: Expected Obj, but got F4
			//IL_05ab: Expected VT, but got F4
			//IL_062d: Expected VT, but got F4
			//IL_0682: Unknown result type (might be due to invalid IL or missing references)
			//IL_0687: Expected Obj, but got Unknown
			//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a9: Expected Obj, but got Unknown
			//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_06cb: Expected Obj, but got Unknown
			//IL_021d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0222: Expected Obj, but got Unknown
			//IL_0244: Unknown result type (might be due to invalid IL or missing references)
			//IL_0249: Expected Obj, but got Unknown
			//IL_0266: Unknown result type (might be due to invalid IL or missing references)
			//IL_026b: Expected Obj, but got Unknown
			//IL_02af: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b4: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 32;
			if (_003C_003E1__state <= 1)
			{
				HUDFPS hUDFPS = _003C_003E4__this;
				_003C_003E1__state = -1;
				_ = 1065353216;
				float fpsMin = hUDFPS.fpsMin;
				float num = hUDFPS.accum / (float)hUDFPS.frames;
				if (!(hUDFPS.fpsMin < num))
				{
					fpsMin = num;
				}
				hUDFPS.fpsMin = fpsMin;
				float fpsMax = hUDFPS.fpsMax;
				if (!(hUDFPS.fpsMax > num))
				{
					fpsMax = num;
				}
				hUDFPS.fpsMax = fpsMax;
				bool flag = !(num < 30f);
				float num2 = 0f;
				if (!flag)
				{
					num2 = 1f;
				}
				hUDFPS.color = (Color)num2;
				object obj3 = hUDFPS - -64;
				bool flag2 = num > 10f;
				float num3 = 0f;
				if (!flag2)
				{
					num3 = 4f / 255f;
				}
				float num4 = 0f;
				if (!flag)
				{
					num4 = num3;
				}
				obj3 = num4;
				float num5 = 0f;
				if (!flag2)
				{
					num5 = 235f / 255f;
				}
				float num6 = 1f;
				if (!flag)
				{
					num6 = num5;
				}
				bool flag3 = hUDFPS.timeMaxFrame > 0f;
				bool flag4 = !flag3;
				float num7 = 0f;
				if (!flag4)
				{
					float num8 = 1f / hUDFPS.timeMaxFrame;
					bool flag5 = num8 > 0f;
					bool flag6 = !flag5;
					num7 = num8;
					if (!flag6)
					{
						float minFpsMin = hUDFPS.minFpsMin;
						if (!(num8 > hUDFPS.minFpsMin))
						{
							minFpsMin = num8;
						}
						hUDFPS.minFpsMin = minFpsMin;
						num7 = num8;
					}
				}
				_ = 1065353216;
				_ = 1065353216;
				bool flag7 = !(num7 < 30f);
				float num9 = 0f;
				if (!flag7)
				{
					num9 = 1f;
				}
				hUDFPS.minColor = (Color)num9;
				bool flag8 = num7 > 10f;
				float num10 = 0f;
				if (!flag8)
				{
					num10 = 4f / 255f;
				}
				float num11 = 0f;
				if (!flag7)
				{
					num11 = num10;
				}
				float num12 = 0f;
				if (!flag8)
				{
					num12 = 235f / 255f;
				}
				float num13 = 1f;
				if (!flag7)
				{
					num13 = num12;
				}
				float minFpsMax = hUDFPS.minFpsMax;
				if (!(num7 < hUDFPS.minFpsMax))
				{
					minFpsMax = num7;
				}
				hUDFPS.minFpsMax = minFpsMax;
				float num14 = hUDFPS.accumTotal / (float)hUDFPS.framesTotal;
				bool flag9 = !(num14 < 30f);
				float num15 = 0f;
				if (!flag9)
				{
					num15 = 1f;
				}
				hUDFPS.avgColor = (Color)num15;
				bool flag10 = num14 > 10f;
				float num16 = 0f;
				if (!flag10)
				{
					num16 = 4f / 255f;
				}
				float num17 = 0f;
				if (!flag9)
				{
					num17 = num16;
				}
				float num18 = 0f;
				if (!flag10)
				{
					num18 = 235f / 255f;
				}
				float num19 = 1f;
				if (!flag9)
				{
					num19 = num18;
				}
				object obj4 = obj + 28;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				_ = hUDFPS.fpsMin;
				object obj5 = obj + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				_ = hUDFPS.fpsMax;
				object obj6 = obj + 20;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object arg = default;
				object arg2 = default;
				object arg3 = default;
				string sFPS = $"{arg:F1} FPS ({arg2:F1} - {arg3:F1})";
				hUDFPS.sFPS = sFPS;
				object obj7 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				_ = hUDFPS.minFpsMin;
				object obj8 = obj + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				_ = hUDFPS.minFpsMax;
				object obj9 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object arg4 = default;
				object arg5 = default;
				object arg6 = default;
				string sMinFPS = $"{arg4:F1} MIN ({arg5:F1} - {arg6:F1})";
				hUDFPS.sMinFPS = sMinFPS;
				object obj10 = obj + 4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object arg7 = default;
				string sAvgFPS = $"{arg7:F1} AVG";
				hUDFPS.sAvgFPS = sAvgFPS;
				hUDFPS.timeMaxFrame = 0f;
				hUDFPS.accum = 0f;
				_ = hUDFPS.frequency;
				object obj11 = default;
				_003C_003E2__current = obj11;
				_003C_003E1__state = 1;
			}
			return _003C_003E1__state < 2;
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
		StartFpsCounter();
	}

	private void Update()
	{
		//IL_000e: Expected VT, but got Obj
		float deltaTime = Time.deltaTime;
		if (deltaTime > 0f)
		{
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			float timeScale = Time.timeScale;
			float deltaTime2 = Time.deltaTime;
			float num = timeScale / deltaTime2;
			float num2 = accum + num;
			accum = num2;
			float num3 = accumTotal + num;
			accumTotal = num3;
			int num4 = frames + 1;
			frames = num4;
			int num5 = framesTotal + 1;
			framesTotal = num5;
			float num6 = timeMaxFrame;
			float deltaTime3 = Time.deltaTime;
			if (!(timeMaxFrame > deltaTime3))
			{
				num6 = deltaTime3;
			}
			timeMaxFrame = num6;
		}
	}

	public void StartFpsCounter()
	{
		Reset();
		IEnumerator routine = FPS();
		Coroutine coroutine = StartCoroutine(routine);
	}

	private void Reset()
	{
		fpsMax = 0f;
		fpsMin = float.MaxValue;
		minFpsMax = 0f;
		minFpsMin = float.MaxValue;
		accum = 0f;
		accumTotal = 0f;
		windowRectPrev = windowRect;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HUDFPS)+14]");
		_ = 0;
	}

	private IEnumerator FPS()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private unsafe void OnGUI()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00ec: Expected F4, but got I
		//IL_00e7: Expected native int or pointer, but got VT
		//IL_0101: Expected F4, but got I
		//IL_00fc: Expected native int or pointer, but got VT
		//IL_015a: Expected VT, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected VT, but got Unknown
		object obj = default;
		Rect rect = (Rect)(obj - 96);
		if (style == null)
		{
			GUISkin skin = GUI.skin;
			GUIStyle gUIStyle = default;
			gUIStyle._002Ector(skin.m_label);
			style = gUIStyle;
			GUIStyleState normal = style.normal;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			Color textColor = (Color)(rect + 16);
			normal.textColor = textColor;
			style.alignment = TextAnchor.MiddleCenter;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HUDFPS)+14]");
		_ = 0;
		_ = windowRect;
		GUI.WindowFunction windowFunction = default;
		windowFunction._002Ector(this, (nint)__ldftn(HUDFPS.DoMyWindow));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+48]");
		((Rect*)(nint)rect)->m_Width = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+40]");
		((Rect*)(nint)rect)->m_XMin = 0f;
		Rect rect2 = GUI.Window(0, rect, windowFunction, string.Empty);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+20]");
		windowRect = (Rect)0;
	}

	private unsafe void DoMyWindow(int windowID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected VT, but got Unknown
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Expected Obj, but got Unknown
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected VT, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0026: Expected F4, but got Obj
		//IL_0036: Expected F4, but got I
		//IL_0040: Expected F4, but got VT
		//IL_0050: Expected F4, but got I
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected VT, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected VT, but got Unknown
		//IL_00a2: Expected F4, but got I
		//IL_00b2: Expected F4, but got I
		//IL_00c2: Expected F4, but got I
		//IL_00cc: Expected F4, but got VT
		//IL_012e: Expected F4, but got I
		//IL_013e: Expected F4, but got I
		//IL_014e: Expected F4, but got I
		//IL_0158: Expected F4, but got VT
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected VT, but got Unknown
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected VT, but got Unknown
		//IL_020c: Expected F4, but got I
		//IL_0207: Expected native int or pointer, but got VT
		//IL_021b: Expected F4, but got VT
		//IL_0216: Expected native int or pointer, but got VT
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected VT, but got Unknown
		//IL_0268: Expected VT, but got Obj
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected VT, but got Unknown
		object obj = default;
		Rect rect = (Rect)(obj - 208);
		bool flag = (byte)(~(updateColor ? 1u : 0u)) != 0;
		float num = 1f;
		float num2 = 1f;
		float num3 = 1f;
		float num4 = 1f;
		if (!flag)
		{
			object obj2 = this - -64;
			num = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HUDFPS)+44]");
			num2 = 0f;
			num3 = (float)this.color;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HUDFPS)+3C]");
			num4 = 0f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+C0]");
		_ = 0;
		Color color = (Color)(rect + 128);
		GUI.color = color;
		object obj3 = this + 12;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v26+C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v26+8]");
		_ = 0;
		_ = -20f;
		_ = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+B0]");
		_ = 0;
		Rect position = (Rect)(rect + 112);
		GUI.Label(position, sFPS, style);
		bool flag2 = (byte)(~(updateColor ? 1u : 0u)) != 0;
		float num5 = 1f;
		float num6 = 1f;
		float num7 = 1f;
		float num8 = 1f;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HUDFPS)+54]");
			num5 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HUDFPS)+4C]");
			num6 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HUDFPS)+50]");
			num7 = 0f;
			num8 = (float)minColor;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+A0]");
		_ = 0;
		Color color2 = (Color)(rect + 96);
		GUI.color = color2;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v26+C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v26+8]");
		_ = 0;
		_ = 0f;
		_ = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+B0]");
		_ = 0;
		Rect position2 = (Rect)(rect + 80);
		GUI.Label(position2, sMinFPS, style);
		if (~(updateColor ? 1u : 0u) != 0)
		{
			float num9 = 1f;
			float num10 = 1f;
			float num11 = 1f;
			float num12 = 1f;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HUDFPS)+60]");
			float num12 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HUDFPS)+64]");
			float num9 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HUDFPS)+5C]");
			float num10 = 0f;
			float num11 = (float)avgColor;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+90]");
		_ = 0;
		Color color3 = (Color)(rect - -64);
		GUI.color = color3;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v26+C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v26+8]");
		_ = 0;
		_ = 20f;
		_ = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+B0]");
		_ = 0;
		Rect position3 = (Rect)(rect + 48);
		GUI.Label(position3, sAvgFPS, style);
		if (~(allowDrag ? 1u : 0u) == 0)
		{
			int width = Screen.width;
			int height = Screen.height;
			_ = 0;
			_ = 0;
			_ = 0f;
			_ = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+B8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+B0]");
			_ = 0;
			Rect position4 = (Rect)(rect + 32);
			GUI.DragWindow(position4);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v26+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HUDFPS)+80]");
		((Rect*)(nint)rect)->m_Width = 0f;
		((Rect*)(nint)rect)->m_XMin = (float)windowRectPrev;
		Rect rect2 = (Rect)(rect + 16);
		if (rect2 != rect)
		{
			Reset();
		}
		windowRectPrev = (Rect)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v26+8]");
		_ = 0;
	}

	public HUDFPS()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0022: Expected Obj, but got I4
		//IL_003d: Expected Obj, but got F4
		//IL_0054: Expected VT, but got Obj
		//IL_006d: Expected VT, but got I8
		//IL_0086: Expected VT, but got I8
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_009e: Expected Obj, but got I8
		//IL_00ad: Expected VT, but got I8
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		obj = 0;
		_ = 100f;
		_ = 200f;
		_ = 70f;
		obj = 10f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		windowRect = (Rect)obj;
		_ = 4575657222473777152L;
		avgColor = (Color)4575657222473777152L;
		_ = 4575657222473777152L;
		minColor = (Color)4575657222473777152L;
		object obj3 = this - -64;
		obj3 = 4575657222473777152L;
		color = (Color)4575657222473777152L;
		frequency = 0.5f;
		updateColor = true;
		minFpsMin = float.MaxValue;
		fpsMin = float.MaxValue;
		sFPS = string.Empty;
		sMinFPS = string.Empty;
		sAvgFPS = string.Empty;
		base._002Ector();
	}
}

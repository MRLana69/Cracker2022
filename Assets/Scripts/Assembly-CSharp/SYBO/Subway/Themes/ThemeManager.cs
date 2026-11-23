using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Subway.Level;
using SYBO.Subway.Routes;
using UnityEngine;

namespace SYBO.Subway.Themes;

public class ThemeManager : MonoBehaviour
{
	private Vector4 _distortion = (Vector4)(-5071816985692401041L);

	private Theme _theme;

	private Theme _themeRefDuplicate;

	private CameraCulling _cameraCulling;

	private float _backgroundStartDistance;

	private float _backgroundToFogBlendStartDistance;

	private static bool _applicationQuitting;

	private static ThemeManager _instance;

	private Action<Theme> m_ThemeChanged;

	public Theme Theme => _theme;

	public unsafe bool DistortionYFlipped
	{
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0052: Expected F4, but got I
			//IL_004d: Expected native int or pointer, but got VT
			//IL_0061: Expected F4, but got VT
			//IL_005c: Expected native int or pointer, but got VT
			object obj = default;
			Vector4 vector = (Vector4)(obj - 16);
			float num = 0.0003f;
			if (!value)
			{
				num = -0.0003f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Themes.ThemeManager)+14]");
			((Vector4*)(nint)vector)->z = 0f;
			((Vector4*)(nint)vector)->x = (float)_distortion;
			Shader.SetGlobalVector("_Distort", vector);
		}
	}

	public static ThemeManager Instance
	{
		get
		{
			ThemeManager result;
			if (~(_applicationQuitting ? 1u : 0u) == 0)
			{
				bool isPlaying = Application.isPlaying;
				result = null;
				if (isPlaying)
				{
					goto IL_0087;
				}
			}
			if (_instance == null)
			{
				ThemeManager instance = Utils.FindObject<ThemeManager>();
				_instance = instance;
			}
			result = _instance;
			goto IL_0087;
			IL_0087:
			return result;
		}
	}

	public event Action<Theme> ThemeChanged
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 48;
			Delegate obj2 = this.m_ThemeChanged;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 48;
			Delegate obj2 = this.m_ThemeChanged;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	private unsafe void Awake()
	{
		Action action = default;
		if (!(_instance != null) || !(_instance != this))
		{
			_applicationQuitting = false;
			_instance = this;
			action._002Ector(this, (nint)__ldftn(ThemeManager.UIScreenController_OnApplicationResumed));
		}
		UIScreenController.OnApplicationResumed += action;
	}

	private void Start()
	{
		if (_theme != null)
		{
			Action<Theme> themeChanged = this.m_ThemeChanged;
			if (this.m_ThemeChanged != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S0_v14 (System.Action`1<SYBO.Subway.Themes.Theme>)+C] (should have been resolved before IL gen)");
			}
		}
	}

	public void PrepoolThemePrefabs()
	{
		if (Application.isPlaying)
		{
			_theme.PrepoolPrefabs();
		}
	}

	private void Update()
	{
		if (_theme != _themeRefDuplicate && _theme != null)
		{
			_themeRefDuplicate = _theme;
			ResetTheme();
			PrepoolThemePrefabs();
		}
	}

	private void OnApplicationQuit()
	{
		_applicationQuitting = true;
	}

	private void OnValidate()
	{
		ResetTheme();
	}

	private unsafe void OnDestroy()
	{
		Action action = default;
		action._002Ector(this, (nint)__ldftn(ThemeManager.UIScreenController_OnApplicationResumed));
		UIScreenController.OnApplicationResumed -= action;
		if (_instance == this)
		{
			_applicationQuitting = true;
		}
	}

	public void ForceRefresh()
	{
		ResetTheme();
	}

	private unsafe void ResetTheme()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00cf: Expected F4, but got I
		//IL_00ca: Expected native int or pointer, but got VT
		//IL_00e1: Expected F4, but got VT
		//IL_00dc: Expected native int or pointer, but got VT
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected VT, but got Unknown
		//IL_0160: Expected VT, but got Obj
		object obj = default;
		Color color = (Color)(obj - 48);
		SetShaderStates();
		RenderSettings.fog = false;
		Camera main = Camera.main;
		if (main != null)
		{
			Camera main2 = Camera.main;
			Theme theme = _theme;
			Background background = theme._background;
			_ = background.GradientBottomColor;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v31 (SYBO.Subway.Level.Background)+3C]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+20]");
			_ = 0;
			Color backgroundColor = color + 16;
			main2.backgroundColor = backgroundColor;
		}
		Theme theme2 = _theme;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v17 (SYBO.Subway.Themes.Theme)+4C]");
		((Color*)(nint)color)->b = 0f;
		((Color*)(nint)color)->r = (float)theme2._glowGoldColor;
		theme2._glowGold.SetColor("_MainColor", color);
		Theme theme3 = _theme;
		theme3._glowGold.SetFloat("_Falloff", theme3._glowGoldFalloff);
		if (_cameraCulling == null)
		{
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(CameraCulling));
			UnityEngine.Object obj2 = UnityEngine.Object.FindObjectOfType(typeFromHandle);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			CameraCulling cameraCulling = default;
			_cameraCulling = cameraCulling;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		}
		if (_cameraCulling != null)
		{
			Theme theme4 = _theme;
			_cameraCulling.TransparentFXCullingDistance = theme4._glowGoldFalloff;
		}
		AsyncOperation asyncOperation = Resources.UnloadUnusedAssets();
	}

	private unsafe void SetShaderStates()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected VT, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected VT, but got Unknown
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected Obj, but got Unknown
		//IL_02d5: Expected Obj, but got VT
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected VT, but got Unknown
		//IL_008b: Expected F4, but got I
		//IL_0086: Expected native int or pointer, but got VT
		//IL_009d: Expected F4, but got VT
		//IL_0098: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 96);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Themes.ThemeManager)+14]");
		_ = 0;
		_ = _distortion;
		Vector4 value = (Vector4)(color + 48);
		Shader.SetGlobalVector("_Distort", value);
		Theme theme = _theme;
		Background background = theme._background;
		_ = background.GradientTopColor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v11 (SYBO.Subway.Level.Background)+2C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+50]");
		_ = 0;
		Color value2 = color + 32;
		Shader.SetGlobalColor("_BackgroundGradientTopColor", value2);
		object obj2 = color - -64;
		Theme theme2 = _theme;
		Background background2 = theme2._background;
		obj2 = background2.GradientBottomColor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v24 (SYBO.Subway.Level.Background)+3C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+40]");
		_ = 0;
		Color value3 = color + 16;
		Shader.SetGlobalColor("_BackgroundGradientBottomColor", value3);
		Theme theme3 = _theme;
		Background background3 = theme3._background;
		Shader.SetGlobalFloat("_BackgroundGradientBottom", background3.GradientBottom);
		Theme theme4 = _theme;
		Background background4 = theme4._background;
		Shader.SetGlobalFloat("_BackgroundGradientTop", background4.GradientTop);
		Theme theme5 = _theme;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v43 (SYBO.Subway.Themes.Theme)+24]");
		((Color*)(nint)color)->b = 0f;
		((Color*)(nint)color)->r = (float)theme5._fogColor;
		Shader.SetGlobalColor("_FogColor", color);
		Theme theme6 = _theme;
		Shader.SetGlobalFloat("_BackgroundStartDistance", theme6._backgroundStartDistance);
		Theme theme7 = _theme;
		Shader.SetGlobalFloat("_FogEndDistance", theme7._fogEndDistance);
		Theme theme8 = _theme;
		Shader.SetGlobalFloat("_FogStartDistance", theme8._fogStartDistance);
		Theme theme9 = _theme;
		float num = theme9._fogEndDistance - theme9._fogStartDistance;
		float num2 = 1f / num;
		bool flag = num == 0f;
		float value4 = 0f;
		if (!flag)
		{
			value4 = num2;
		}
		Shader.SetGlobalFloat("_FogTransitionLengthReciprocal", value4);
		Theme theme10 = _theme;
		float num3 = theme10._backgroundStartDistance - theme10._fogEndDistance;
		float num4 = 1f / num3;
		bool flag2 = num3 == 0f;
		float value5 = 0f;
		if (!flag2)
		{
			value5 = num4;
		}
		Shader.SetGlobalFloat("_BackgroundToFogTransitionLengthReciprocal", value5);
		Theme theme11 = _theme;
		Shader.SetGlobalFloat("_DistantBackgroundStartDistance", theme11._distantBackgroundStartDistance);
		Theme theme12 = _theme;
		Shader.SetGlobalFloat("_DistantFogEndDistance", theme12._distantFogEndDistance);
		Theme theme13 = _theme;
		Shader.SetGlobalFloat("_DistantFogStartDistance", theme13._distantFogStartDistance);
		Theme theme14 = _theme;
		float num5 = theme14._distantFogEndDistance - theme14._distantFogStartDistance;
		float num6 = 1f / num5;
		bool flag3 = num5 == 0f;
		float value6 = 0f;
		if (!flag3)
		{
			value6 = num6;
		}
		Shader.SetGlobalFloat("_DistantFogTransitionLengthReciprocal", value6);
		Theme theme15 = _theme;
		float num7 = theme15._distantBackgroundStartDistance - theme15._distantFogEndDistance;
		float num8 = 1f / num7;
		bool flag4 = num7 == 0f;
		float value7 = 0f;
		if (!flag4)
		{
			value7 = num8;
		}
		Shader.SetGlobalFloat("_DistantBackgroundToFogTransitionLengthReciprocal", value7);
	}

	private void UIScreenController_OnApplicationResumed()
	{
		SetShaderStates();
	}

	public int GetEnvironmentModelVariationCount(RouteCategory routeCategory, EnvironmentKind envTypeInfo)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_00f3: Expected Obj, but got I4
		//IL_02cf: Expected Obj, but got I
		//IL_0123: Expected Obj, but got I
		//IL_0133: Expected Obj, but got I
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_01e3: Expected Obj, but got I
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_0218: Expected Obj, but got I
		Theme theme = _theme;
		if (Enumerable.Count(theme._routeEnvironmentModelAssets) != 0)
		{
			object obj = 0;
			while (true)
			{
				Theme theme2 = _theme;
				RouteEnvironmentModelAssets[] routeEnvironmentModelAssets = theme2._routeEnvironmentModelAssets;
				if ((nint)obj >= routeEnvironmentModelAssets.Length)
				{
					break;
				}
				object obj2 = obj << 2;
				object obj3 = (object)routeEnvironmentModelAssets + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v11+10]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v12+8]");
				if ((nint)routeCategory != (nint)0)
				{
					object obj5 = obj + 1;
					obj = obj5;
					continue;
				}
				Theme theme3 = _theme;
				object obj6 = obj << 2;
				object obj7 = (object)theme3._routeEnvironmentModelAssets + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v21+10]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v21+10]");
				if ((nint)0 == 0)
				{
					break;
				}
				object obj9 = 0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v22+C]");
					object obj10 = 0;
					object obj11 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v18+C]");
					if ((nint)obj11 >= 0)
					{
						break;
					}
					object obj12 = obj9 << 2;
					object obj13 = obj10 + obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v29+10]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v30+C]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v31+8]");
					bool flag;
					if ((nint)0 == (nint)envTypeInfo._type)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v31+C]");
						flag = (nint)0 == (nint)envTypeInfo._density;
					}
					else
					{
						flag = false;
					}
					if (!flag)
					{
						object obj16 = obj9 + 1;
						obj9 = obj16;
						continue;
					}
					object obj17 = obj9 << 2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v22+C]");
					object obj18 = 0 + obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v41+10]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v41+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v42+10]");
						object obj20 = 0;
					}
					break;
				}
				break;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v45+C]");
		return 0;
	}

	public bool NeedSameVariationForAllSegments(EnvironmentType envType)
	{
		return envType == EnvironmentType.Epic;
	}

	public Transform GetEnvironmentSegmentModel(RouteCategory routeCategory, EnvironmentKind envKind, EnvironmentSequence sequence, EnvironmentSide side, int variation)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_007b: Expected Obj, but got I
		//IL_00fa: Expected Obj, but got I
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_0128: Expected Obj, but got I4
		//IL_05ab: Expected Obj, but got I
		//IL_0158: Expected Obj, but got I
		//IL_0168: Expected Obj, but got I
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_0218: Expected Obj, but got I
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_024d: Expected Obj, but got I
		//IL_05e0: Expected Obj, but got I4
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected Obj, but got Unknown
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Expected Obj, but got Unknown
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Expected Obj, but got Unknown
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Expected VT, but got Unknown
		//IL_0437: Expected Obj, but got I4
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected Obj, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected Obj, but got Unknown
		//IL_04ac: Expected Obj, but got I
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Expected Obj, but got Unknown
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected Obj, but got Unknown
		//IL_04e7: Expected Obj, but got I
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected Obj, but got Unknown
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Expected Obj, but got Unknown
		//IL_0522: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 128;
		_ = 0;
		_ = 0;
		_ = 0;
		Theme theme = _theme;
		if (Enumerable.Count(theme._routeEnvironmentModelAssets) != 0)
		{
			object obj3 = default;
			object obj7 = default;
			while (true)
			{
				Theme theme2 = _theme;
				RouteEnvironmentModelAssets[] routeEnvironmentModelAssets = theme2._routeEnvironmentModelAssets;
				if ((nint)obj3 >= routeEnvironmentModelAssets.Length)
				{
					break;
				}
				object obj4 = obj3 << 2;
				object obj5 = (object)routeEnvironmentModelAssets + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v17+10]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v18+8]");
				if ((nint)routeCategory != (nint)0)
				{
					obj3 = obj7 + 1;
					continue;
				}
				Theme theme3 = _theme;
				object obj8 = obj3 << 2;
				object obj9 = (object)theme3._routeEnvironmentModelAssets + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v28+10]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v28+10]");
				if ((nint)0 == 0)
				{
					break;
				}
				object obj11 = 0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v29+C]");
					object obj12 = 0;
					object obj13 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S1_v24+C]");
					if ((nint)obj13 >= 0)
					{
						break;
					}
					object obj14 = obj11 << 2;
					object obj15 = obj12 + obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v36+10]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v37+C]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v38+8]");
					bool flag;
					if ((nint)0 == (nint)envKind._type)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v38+C]");
						flag = (nint)0 == (nint)envKind._density;
					}
					else
					{
						flag = false;
					}
					if (!flag)
					{
						object obj18 = obj11 + 1;
						obj11 = obj18;
						continue;
					}
					object obj19 = obj11 << 2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v29+C]");
					object obj20 = 0 + obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v48+10]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v48+10]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v49+10]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S1_v34+C]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S1_v34+C]");
					if ((nint)0 < (nint)variation)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
						throw new ArrayTypeMismatchException();
					}
					ThemeManager themeManager = (ThemeManager)(variation - 1);
					object obj23 = obj - -64;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6FC");
					object obj24 = obj + 12;
					object obj25 = obj - -64;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
					EnvironmentSegmentSequence segments = (EnvironmentSegmentSequence)(obj + 12);
					EnvironmentSegmentParts? sequenceModel = themeManager.GetSequenceModel(segments, sequence);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
					if ((nint)0 == 0)
					{
						break;
					}
					object obj26 = side - 1;
					if (side != EnvironmentSide.Left)
					{
						if ((nint)obj26 == 1)
						{
							object obj27 = obj - -64;
							object obj28 = obj + 104;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @20F2");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+44]");
							return (Transform)0;
						}
						object obj29 = obj - -64;
						object obj30 = obj + 104;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @20F2");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
						return (Transform)0;
					}
					object obj31 = obj - -64;
					object obj32 = obj + 104;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @20F2");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
					return (Transform)0;
				}
				break;
			}
		}
		Transform result = default;
		return result;
	}

	private unsafe EnvironmentSegmentParts? GetSequenceModel(EnvironmentSegmentSequence segments, EnvironmentSequence sequence)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01b8: Expected Obj, but got I4
		//IL_005b: Expected VT, but got I4
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected VT, but got Unknown
		//IL_008e: Expected native int or pointer, but got VT
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00bf: Expected VT, but got I4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected VT, but got Unknown
		//IL_00ef: Expected native int or pointer, but got VT
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_0125: Expected VT, but got I4
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected VT, but got Unknown
		//IL_0155: Expected native int or pointer, but got VT
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_0199: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 - 112;
		_ = 0;
		_ = 0;
		object obj3 = sequence - 1;
		EnvironmentSegmentParts? environmentSegmentParts;
		if (sequence != EnvironmentSequence.Start)
		{
			if ((nint)obj3 != 1)
			{
				if ((nint)obj3 == 2)
				{
					object obj4 = obj + 56;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
					_ = 0;
					environmentSegmentParts = (EnvironmentSegmentParts?)(object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
					_ = 0;
					EnvironmentSegmentParts value = (EnvironmentSegmentParts)(obj + 40);
					System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)environmentSegmentParts, new EnvironmentSegmentParts?(value));
				}
				else
				{
					object obj5 = obj + 96;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
					environmentSegmentParts = (EnvironmentSegmentParts?)(object)0;
				}
			}
			else
			{
				object obj6 = obj + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
				_ = 0;
				environmentSegmentParts = (EnvironmentSegmentParts?)(object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+44]");
				_ = 0;
				EnvironmentSegmentParts value2 = (EnvironmentSegmentParts)(obj + 24);
				System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)environmentSegmentParts, new EnvironmentSegmentParts?(value2));
			}
		}
		else
		{
			environmentSegmentParts = (EnvironmentSegmentParts?)(object)0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [segments @ L2 (SYBO.Subway.Level.EnvironmentSegmentSequence)+8]");
			_ = 0;
			_ = segments.Start;
			EnvironmentSegmentParts value3 = (EnvironmentSegmentParts)(obj + 8);
			System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)environmentSegmentParts, new EnvironmentSegmentParts?(value3));
		}
		return environmentSegmentParts;
	}

	public ThemeManager()
	{
		//IL_000f: Expected VT, but got I8
		_ = 0;
		base._002Ector();
	}
}

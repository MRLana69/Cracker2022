using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Google.Internal;
using SYBO.Common;
using SYBO.Common.Utilities;
using SYBO.Subway.Level;
using SYBO.Subway.Routes;
using SYBO.Subway.Routes.Builders;
using SYBO.Subway.UI;
using SYBO.Subway.Visuals;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;
using UnityEngine.SceneManagement;

namespace SYBO.Subway.Themes;

public class ThemeManager : MonoBehaviour
{
	private Action<Theme> m_ThemeChanged;

	private Vector4 _distortion;

	private Theme _theme;

	private Theme _themeRefDuplicate;

	private CameraCulling _cameraCulling;

	private float _backgroundStartDistance;

	private float _backgroundToFogBlendStartDistance;

	private static bool _applicationQuitting;

	private static ThemeManager _instance;

	public Theme Theme
	{
		get
		{
			//IL_000d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Themes.ThemeManager)+18]");
			return (Theme)0;
		}
	}

	public bool DistortionYFlipped
	{
		set
		{
			//IL_0066: Expected Obj, but got I4
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_ThemeChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public static ThemeManager Instance
	{
		get
		{
			//IL_00a4: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_00df: Expected Obj, but got I4
			//IL_0054: Expected I, but got Obj
			bool flag = UnityEngine.ScriptingUtility.IsManagedCodeWorking();
			object obj = flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FA60");
			string text2 = default;
			string text = text2.ToLowerInvariant();
			nint num = (nint)typeof(MergeLevelStartHelp);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v8 (Il2CppClass<SYBO.Subway.UI.MergeLevelStartHelp>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(MergeLevelStartHelp);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v17 (Il2CppClass<SYBO.Subway.UI.MergeLevelStartHelp>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string value = MergeLevelStartHelp.MERGE_SCENE_NAME_SUBSTRING.ToLowerInvariant();
			return (ThemeManager)text.EndsWith(value);
		}
	}

	public event Action<Theme> ThemeChanged
	{
		add
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81F9");
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_ThemeChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	private void Awake()
	{
	}

	private unsafe void Start()
	{
		//IL_0232: Expected I, but got Obj
		//IL_0248: Expected Obj, but got I
		//IL_02ff: Expected I, but got Obj
		//IL_0315: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0273: Expected I, but got Obj
		//IL_0289: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_034a: Expected I, but got Obj
		//IL_0360: Expected Obj, but got I
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected Obj, but got Unknown
		//IL_03b2: Expected I, but got Obj
		//IL_03c8: Expected Obj, but got I
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0198: Expected I, but got Obj
		//IL_02b4: Expected I, but got Obj
		//IL_02ca: Expected Obj, but got I
		//IL_01e5: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		nint num = (nint)typeof(ThemeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ThemeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v65 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v34 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_instance).FindKernel((string)null) != 0)
		{
			nint num5 = (nint)typeof(ThemeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v49 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(ThemeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v59 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)_instance).FindKernel((string)(object)this) != 0)
			{
				SDebug.LogFormat("Instatiated multiple ThemeManagers!", null);
			}
		}
		nint num9 = (nint)typeof(ThemeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v16 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(ThemeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v42 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_applicationQuitting = false;
		nint num11 = (nint)typeof(ThemeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v23 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+5C]");
		object obj6 = (nint)0 + (nint)4;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(ThemeManager.UIScreenController_OnApplicationResumed);
		object obj7 = action + 16;
		obj7 = this;
		nint num12 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v33 (Il2CppClass<UIScreenController>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num13 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v38 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnApplicationResumed -= action;
	}

	public void PrepoolThemePrefabs()
	{
		//IL_008e: Expected I, but got Obj
		//IL_00a4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_theme).FindKernel((string)null) != 0 && this.m_ThemeChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C62");
		}
	}

	private void Update()
	{
		if (Application.platform != RuntimePlatform.OSXEditor)
		{
			_theme._002Ector();
		}
	}

	private void OnApplicationQuit()
	{
		//IL_0114: Expected I, but got Obj
		//IL_012a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v10 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_theme).FindKernel((string)(object)_themeRefDuplicate) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_theme).FindKernel((string)null) != 0)
		{
			object obj3 = this + 36;
			obj3 = _theme;
			SetShaderStates();
			Update();
		}
	}

	private void OnValidate()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(ThemeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ThemeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_applicationQuitting = true;
	}

	private void OnDestroy()
	{
		SetShaderStates();
	}

	public void ForceRefresh()
	{
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_01b3: Expected I, but got Obj
		//IL_01c9: Expected Obj, but got I
		//IL_01fd: Expected I, but got Obj
		//IL_0213: Expected Obj, but got I
		//IL_023e: Expected I, but got Obj
		//IL_0254: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00fa: Expected I, but got Obj
		//IL_0110: Expected Obj, but got I
		//IL_013b: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<string> action = default;
		object obj = action + 16;
		obj = this;
		nint num2 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v46 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnPopupShown += action;
		nint num4 = (nint)typeof(ThemeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v18 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(ThemeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v40 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num6 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(_instance != this))
		{
			return;
		}
		nint num8 = (nint)typeof(ThemeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v28 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num9 = (nint)typeof(ThemeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v34 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_applicationQuitting = true;
	}

	private void ResetTheme()
	{
		SetShaderStates();
	}

	private unsafe void SetShaderStates()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected I4, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_0136: Expected I4, but got Obj
		//IL_015a: Expected VT, but got I4
		//IL_018a: Expected I4, but got Obj
		//IL_0054: Expected I, but got Obj
		//IL_019d: Expected I, but got Obj
		//IL_01b3: Expected Obj, but got I
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00db: Expected I4, but got Obj
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected Obj, but got Unknown
		//IL_040a: Expected I, but got Obj
		//IL_0420: Expected Obj, but got I
		//IL_01de: Expected I, but got Obj
		//IL_022b: Expected I, but got Obj
		//IL_0241: Expected Obj, but got I
		//IL_0306: Expected I, but got Obj
		//IL_0458: Expected I4, but got Obj
		//IL_0473: Expected I, but got Obj
		//IL_0489: Expected Obj, but got I
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected Obj, but got Unknown
		//IL_026c: Expected I, but got Obj
		//IL_02b9: Expected I, but got Obj
		UIScreenController_OnApplicationResumed();
		((Shader)null)._002Ector();
		Camera current = Camera.current;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v62 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		CameraClearFlags cameraClearFlags = (CameraClearFlags)(obj2 + 24);
		if (((ComputeShader)(object)current).FindKernel((string)null) != 0)
		{
			Camera current2 = Camera.current;
			Theme theme = _theme;
			object obj3 = theme._background + 52;
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S2_v31+8]");
			_ = 0;
			((CameraClearFlags*)(int)cameraClearFlags)->value__ = (int)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			current2.clearFlags = cameraClearFlags;
		}
		Theme theme2 = _theme;
		object obj4 = _theme + 68;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S2_v7+8]");
		_ = 0;
		((CameraClearFlags*)(int)cameraClearFlags)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		theme2._glowGold.SetVector("_MainColor", (Vector4)cameraClearFlags);
		Theme theme3 = _theme;
		Theme theme4 = _theme;
		((SkinnedMeshRenderer)(object)theme3._glowGold).SetBlendShapeWeight((int)"_Falloff", theme4._glowGoldFalloff);
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S1_v53 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = obj2 + 16;
		if (_cameraCulling != null)
		{
			nint num5 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v36 (Il2CppClass<System.Type>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num6 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v55 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj6 = typeof(CameraCulling);
			((CameraClearFlags*)(int)cameraClearFlags)->value__ = (int)obj6;
			Type type = Type.internal_from_handle((IntPtr)(nint)cameraClearFlags);
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v45 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v51 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj9 = this + 40;
			string text = ((UnityEngine.Object)(object)type).ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			object obj10 = default;
			obj9 = obj10;
		}
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_cameraCulling).FindKernel((string)null) != 0)
		{
			Theme theme5 = _theme;
			((CharacterAnimationControl)(object)_cameraCulling).Speed(theme5._glowGoldFalloff);
		}
		Scene activeScene = SceneManager.GetActiveScene();
	}

	private unsafe void UIScreenController_OnApplicationResumed()
	{
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected Obj, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Obj, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected VT, but got Unknown
		//IL_02b0: Expected F4, but got Obj
		//IL_02ab: Expected native int or pointer, but got VT
		//IL_02c5: Expected F4, but got I
		//IL_02c0: Expected native int or pointer, but got VT
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected Obj, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_0320: Expected F4, but got Obj
		//IL_031b: Expected native int or pointer, but got VT
		//IL_0335: Expected F4, but got I
		//IL_0330: Expected native int or pointer, but got VT
		//IL_0343: Expected Ref, but got VT
		//IL_0343: Expected I4, but got Obj
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected Obj, but got Unknown
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected Obj, but got Unknown
		//IL_0390: Expected F4, but got Obj
		//IL_038b: Expected native int or pointer, but got VT
		//IL_03a5: Expected F4, but got I
		//IL_03a0: Expected native int or pointer, but got VT
		//IL_03b3: Expected Ref, but got VT
		//IL_03b3: Expected I4, but got Obj
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_0090: Expected F4, but got Obj
		//IL_008b: Expected native int or pointer, but got VT
		//IL_00a5: Expected F4, but got I
		//IL_00a0: Expected native int or pointer, but got VT
		//IL_00b3: Expected Ref, but got VT
		//IL_00b3: Expected I4, but got Obj
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected Obj, but got Unknown
		//IL_0457: Expected F4, but got Obj
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = this + 16;
		obj = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v5+8]");
		_ = 0;
		Color color = (Color)(obj2 - -64);
		((Color*)(nint)color)->r = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Color*)(nint)color)->b = 0f;
		Shader.SetGlobalColor("_Distort", color);
		object obj4 = obj2 + 32;
		Theme theme = _theme;
		object obj5 = theme._background + 36;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v17+8]");
		_ = 0;
		((Color*)(nint)color)->r = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v14+8]");
		((Color*)(nint)color)->b = 0f;
		Shader.SetGlobalVectorImpl_Injected((int)"_BackgroundGradientTopColor", ref *(Vector4*)color);
		object obj6 = obj2 + 16;
		Theme theme2 = _theme;
		object obj7 = theme2._background + 52;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v28+8]");
		_ = 0;
		((Color*)(nint)color)->r = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+8]");
		((Color*)(nint)color)->b = 0f;
		Shader.SetGlobalVectorImpl_Injected((int)"_BackgroundGradientBottomColor", ref *(Vector4*)color);
		Theme theme3 = _theme;
		Background background = theme3._background;
		((Light)(object)"_BackgroundGradientBottom").intensity = background.GradientBottom;
		Theme theme4 = _theme;
		Background background2 = theme4._background;
		((Light)(object)"_BackgroundGradientTop").intensity = background2.GradientTop;
		object obj8 = _theme + 28;
		obj2 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v45+8]");
		_ = 0;
		((Color*)(nint)color)->r = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Color*)(nint)color)->b = 0f;
		Shader.SetGlobalVectorImpl_Injected((int)"_FogColor", ref *(Vector4*)color);
		Theme theme5 = _theme;
		((Light)(object)"_BackgroundStartDistance").intensity = theme5._backgroundStartDistance;
		Theme theme6 = _theme;
		((Light)(object)"_FogEndDistance").intensity = theme6._fogEndDistance;
		Theme theme7 = _theme;
		((Light)(object)"_FogStartDistance").intensity = theme7._fogStartDistance;
		Theme theme8 = _theme;
		Theme theme9 = _theme;
		float num = theme8._fogEndDistance - theme9._fogStartDistance;
		float num2 = 1f / num;
		float intensity = ((num != 0f) ? num2 : 0f);
		((Light)(object)"_FogTransitionLengthReciprocal").intensity = intensity;
		Theme theme10 = _theme;
		Theme theme11 = _theme;
		float num3 = theme10._backgroundStartDistance - theme11._fogEndDistance;
		float num4 = 1f / num3;
		float intensity2 = ((num3 != 0f) ? num4 : 0f);
		((Light)(object)"_BackgroundToFogTransitionLengthReciprocal").intensity = intensity2;
		object obj9 = _theme - -64;
		((Light)(object)"_DistantBackgroundStartDistance").intensity = (float)obj9;
		Theme theme12 = _theme;
		((Light)(object)"_DistantFogEndDistance").intensity = theme12._distantFogEndDistance;
		Theme theme13 = _theme;
		((Light)(object)"_DistantFogStartDistance").intensity = theme13._distantFogStartDistance;
		Theme theme14 = _theme;
		Theme theme15 = _theme;
		float num5 = theme14._distantFogEndDistance - theme15._distantFogStartDistance;
		float num6 = 1f / num5;
		float intensity3 = ((num5 != 0f) ? num6 : 0f);
		((Light)(object)"_DistantFogTransitionLengthReciprocal").intensity = intensity3;
		object obj10 = _theme - -64;
		Theme theme16 = _theme;
		float num7 = (float)obj10 - theme16._distantFogEndDistance;
		float num8 = 1f / num7;
		float intensity4 = ((num7 != 0f) ? num8 : 0f);
		((Light)(object)"_DistantBackgroundToFogTransitionLengthReciprocal").intensity = intensity4;
	}

	public int GetEnvironmentModelVariationCount(RouteCategory routeCategory, EnvironmentKind envTypeInfo)
	{
		//IL_01a8: Expected I, but got Obj
		//IL_01be: Expected Obj, but got I
		//IL_01e5: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_005b: Expected Obj, but got I4
		//IL_009e: Expected I, but got Obj
		//IL_00b4: Expected Obj, but got I
		//IL_00df: Expected I, but got Obj
		//IL_0131: Expected Obj, but got I4
		((Theme)(object)this).InitializeEnvironmentTransitions();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v32 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)routeCategory != null)
		{
			EnvironmentKind environmentKind = (EnvironmentKind)0;
			return 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
		object obj2 = default;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((UnityEngine.Object)(object)envTypeInfo != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				UnityEngine.Object obj4 = UnityEngine.Object.Instantiate((UnityEngine.Object)routeCategory);
				throw new ArrayTypeMismatchException();
			}
			return 1;
		}
		return 0;
	}

	public bool NeedSameVariationForAllSegments(EnvironmentType envType)
	{
		//IL_016e: Expected Obj, but got I
		//IL_001a: Expected Obj, but got I
		//IL_002c: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_006d: Expected I, but got Obj
		int num = 0;
		bool result;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Themes.ThemeManager)+E0]");
			object obj = 0;
			int num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S2_v3+C]");
			bool flag = (nint)num2 >= (nint)0;
			result = false;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Themes.ThemeManager)+E0]");
			EnvironmentKind environmentKind = ((List<EnvironmentKind>)0).get_Item(num);
			nint num3 = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v15 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v30 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			EnvironmentType type = environmentKind._type;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L1 (SYBO.Subway.Level.EnvironmentType)+8]");
			bool flag2;
			if ((nint)type == (nint)0)
			{
				EnvironmentDensity density = environmentKind._density;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envType @ L1 (SYBO.Subway.Level.EnvironmentType)+C]");
				flag2 = (nint)density == (nint)0;
			}
			else
			{
				flag2 = false;
			}
			if (flag2)
			{
				result = true;
				break;
			}
			int num5 = num + 1;
			num = num5;
		}
		return result;
	}

	public unsafe Transform GetEnvironmentSegmentModel(RouteCategory routeCategory, EnvironmentKind envKind, EnvironmentSequence sequence, EnvironmentSide side, int variation)
	{
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected Obj, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected Obj, but got Unknown
		//IL_0345: Expected Obj, but got I4
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected Obj, but got Unknown
		//IL_036d: Expected Obj, but got I4
		//IL_0387: Expected Obj, but got I4
		//IL_03a2: Expected I, but got Obj
		//IL_03b8: Expected Obj, but got I
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Expected Obj, but got Unknown
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Expected Obj, but got Unknown
		//IL_0698: Expected VT, but got I
		//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a6: Expected I4, but got Unknown
		//IL_06b3: Expected I4, but got Obj
		//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ce: Expected I4, but got Unknown
		//IL_06db: Expected I4, but got Obj
		//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Expected I4, but got Unknown
		//IL_0703: Expected I4, but got Obj
		//IL_03db: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_005f: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I4
		//IL_00bf: Expected Obj, but got I4
		//IL_00da: Expected I, but got Obj
		//IL_00f0: Expected Obj, but got I
		//IL_0415: Expected VT, but got I
		//IL_0422: Expected I4, but got Obj
		//IL_043c: Expected I4, but got Obj
		//IL_0456: Expected I4, but got Obj
		//IL_011b: Expected I, but got Obj
		//IL_017b: Expected Obj, but got I4
		//IL_01a7: Expected Obj, but got I4
		//IL_01c2: Expected I, but got Obj
		//IL_01d8: Expected Obj, but got I
		//IL_04c2: Expected VT, but got I
		//IL_04cf: Expected I4, but got Obj
		//IL_04e9: Expected I4, but got Obj
		//IL_0503: Expected I4, but got Obj
		//IL_0525: Expected Obj, but got I4
		//IL_053d: Expected VT, but got I
		//IL_05af: Expected Obj, but got I4
		//IL_05c7: Expected VT, but got I
		//IL_0639: Expected Obj, but got I4
		//IL_0256: Expected VT, but got I
		//IL_02a1: Expected I4, but got Obj
		//IL_02da: Expected Obj, but got I4
		//IL_0203: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		obj = this;
		_ = ((UnityEngine.Object)this).m_CachedPtr;
		object obj3 = obj2 + 36;
		obj3 = envKind;
		_ = envKind._type;
		object obj4 = obj2 + 24;
		obj4 = ((EnvironmentSide*)(int)side)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [side @ L4 (SYBO.Subway.Level.EnvironmentSide)+8]");
		_ = 0;
		object obj5 = obj2 + 12;
		obj5 = ((EnvironmentSequence*)(int)sequence)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sequence @ L3 (SYBO.Subway.Level.EnvironmentSequence)+8]");
		_ = 0;
		obj2 = ((int*)variation)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [variation @ L5 (System.Int32)+8]");
		_ = 0;
		nint num = (nint)typeof(Math3D);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v23 (Il2CppClass<SYBO.Common.Math3D>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Math3D);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v111 (Il2CppClass<SYBO.Common.Math3D>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Component component = (Component)(obj2 + 60);
		component = (Component)obj;
		Component component2 = component;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)component2).m_CachedPtr = (IntPtr)0;
		Type type = (Type)(obj2 + 72);
		type = (Type)obj3;
		Type type2 = type;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12+8]");
		type2._impl = (RuntimeTypeHandle)0;
		bool flag = (byte)(obj2 + 84) != 0;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj4 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v15+8]");
		_ = 0;
		bool flag2 = (byte)(obj2 + 96) != 0;
		((bool*)(flag2 ? 1 : 0))->m_value = (byte)(int)obj5 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v18+8]");
		_ = 0;
		int num3 = obj2 + 108;
		((int*)num3)->m_value = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Component[] componentsInChildrenBFS = GameObjectUtil.GetComponentsInChildrenBFS(component, type, flag, flag2, num3);
		if (componentsInChildrenBFS == null)
		{
			obj = ((RouteCategory*)(int)routeCategory)->value__;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [routeCategory @ L1 (SYBO.Subway.Routes.RouteCategory)+8]");
			_ = 0;
			obj3 = envKind;
			_ = envKind._type;
			obj4 = ((EnvironmentSide*)(int)side)->value__;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [side @ L4 (SYBO.Subway.Level.EnvironmentSide)+8]");
			_ = 0;
			obj5 = ((EnvironmentSequence*)(int)sequence)->value__;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sequence @ L3 (SYBO.Subway.Level.EnvironmentSequence)+8]");
			_ = 0;
			obj2 = ((int*)variation)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [variation @ L5 (System.Int32)+8]");
			_ = 0;
			nint num4 = (nint)typeof(Math3D);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v59 (Il2CppClass<SYBO.Common.Math3D>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num5 = (nint)typeof(Math3D);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v106 (Il2CppClass<SYBO.Common.Math3D>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			component = (Component)obj;
			Component component3 = component;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)component3).m_CachedPtr = (IntPtr)0;
			type = (Type)obj3;
			Type type3 = type;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12+8]");
			type3._impl = (RuntimeTypeHandle)0;
			((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj4 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v15+8]");
			_ = 0;
			((bool*)(flag2 ? 1 : 0))->m_value = (byte)(int)obj5 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v18+8]");
			_ = 0;
			((int*)num3)->m_value = (int)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Component[] componentsInChildrenBFS2 = GameObjectUtil.GetComponentsInChildrenBFS(component, type, flag, flag2, num3);
			if (componentsInChildrenBFS2 == null)
			{
				component = this;
				((UnityEngine.Object)component).m_CachedPtr = ((UnityEngine.Object)this).m_CachedPtr;
				obj = ((RouteCategory*)(int)routeCategory)->value__;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [routeCategory @ L1 (SYBO.Subway.Routes.RouteCategory)+8]");
				_ = 0;
				obj3 = envKind;
				_ = envKind._type;
				obj4 = ((EnvironmentSequence*)(int)sequence)->value__;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sequence @ L3 (SYBO.Subway.Level.EnvironmentSequence)+8]");
				_ = 0;
				nint num6 = (nint)typeof(Math3D);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v85 (Il2CppClass<SYBO.Common.Math3D>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num7 = (nint)typeof(Math3D);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S0_v102 (Il2CppClass<SYBO.Common.Math3D>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				type = (Type)(object)component;
				type._impl = (RuntimeTypeHandle)(nint)((UnityEngine.Object)component).m_CachedPtr;
				((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				((bool*)(flag2 ? 1 : 0))->m_value = (byte)(int)obj3 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12+8]");
				_ = 0;
				((int*)num3)->m_value = (int)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v15+8]");
				_ = 0;
				Component[] componentsInChildrenBFS3 = GameObjectUtil.GetComponentsInChildrenBFS((Component)(object)type, (Type)flag, flag2, (byte)num3 != 0);
				type = (Type)(object)this;
				type._impl = (RuntimeTypeHandle)(nint)((UnityEngine.Object)this).m_CachedPtr;
				((bool*)(flag ? 1 : 0))->m_value = (byte)((RouteCategory*)(int)routeCategory)->value__ != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [routeCategory @ L1 (SYBO.Subway.Routes.RouteCategory)+8]");
				_ = 0;
				((bool*)(flag2 ? 1 : 0))->m_value = (byte)((EnvironmentSequence*)(int)sequence)->value__ != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sequence @ L3 (SYBO.Subway.Level.EnvironmentSequence)+8]");
				_ = 0;
				((int*)num3)->m_value = ((EnvironmentSide*)(int)side)->value__;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [side @ L4 (SYBO.Subway.Level.EnvironmentSide)+8]");
				_ = 0;
				Component[] componentsInChildrenBFS4 = GameObjectUtil.GetComponentsInChildrenBFS((Component)(object)type, (Type)flag, flag2, (byte)num3 != 0);
				type = (Type)(object)this;
				type._impl = (RuntimeTypeHandle)(nint)((UnityEngine.Object)this).m_CachedPtr;
				((bool*)(flag ? 1 : 0))->m_value = (byte)((RouteCategory*)(int)routeCategory)->value__ != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [routeCategory @ L1 (SYBO.Subway.Routes.RouteCategory)+8]");
				_ = 0;
				((bool*)(flag2 ? 1 : 0))->m_value = (byte)((EnvironmentSide*)(int)side)->value__ != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [side @ L4 (SYBO.Subway.Level.EnvironmentSide)+8]");
				_ = 0;
				((int*)num3)->m_value = ((int*)variation)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [variation @ L5 (System.Int32)+8]");
				_ = 0;
				Component[] componentsInChildrenBFS5 = GameObjectUtil.GetComponentsInChildrenBFS((Component)(object)type, (Type)flag, flag2, (byte)num3 != 0);
				type = (Type)(object)this;
				type._impl = (RuntimeTypeHandle)(nint)((UnityEngine.Object)this).m_CachedPtr;
				((bool*)(flag ? 1 : 0))->m_value = (byte)((RouteCategory*)(int)routeCategory)->value__ != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [routeCategory @ L1 (SYBO.Subway.Routes.RouteCategory)+8]");
				_ = 0;
				((bool*)(flag2 ? 1 : 0))->m_value = (byte)((int*)variation)->m_value != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [variation @ L5 (System.Int32)+8]");
				_ = 0;
				((int*)num3)->m_value = (int)envKind;
				_ = envKind._type;
				object obj9 = (object)componentsInChildrenBFS3 | (object)componentsInChildrenBFS4;
				object obj10 = obj9 | (object)componentsInChildrenBFS5;
				Component[] componentsInChildrenBFS6 = GameObjectUtil.GetComponentsInChildrenBFS((Component)(object)type, (Type)flag, flag2, (byte)num3 != 0);
				return (Transform)(obj10 | (object)componentsInChildrenBFS6);
			}
		}
		return (Transform)1;
	}

	private unsafe EnvironmentSegmentParts? GetSequenceModel(EnvironmentSegmentSequence segments, EnvironmentSequence sequence)
	{
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected Obj, but got Unknown
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected I4, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected I4, but got Unknown
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected I4, but got Unknown
		//IL_03eb: Expected Obj, but got I4
		//IL_002f: Expected I, but got Obj
		//IL_0045: Expected Obj, but got I
		//IL_046d: Expected Obj, but got VT
		//IL_047d: Expected Obj, but got I
		//IL_0070: Expected I, but got Obj
		//IL_034e: Expected VT, but got I4
		//IL_034e: Expected F4, but got VT
		//IL_0367: Expected Obj, but got I
		//IL_037b: Expected VT, but got I
		//IL_01b3: Expected Obj, but got I
		//IL_02f2: Expected F4, but got VT
		//IL_030b: Expected Obj, but got I
		//IL_0206: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got I
		//IL_0324: Expected VT, but got I
		//IL_0515: Expected Obj, but got I
		//IL_01e8: Expected Obj, but got I
		//IL_01f8: Expected Obj, but got I
		//IL_0120: Expected Obj, but got I4
		//IL_04d6: Expected Obj, but got I
		//IL_0102: Expected Obj, but got I
		//IL_0112: Expected Obj, but got I
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_025a: Expected Obj, but got VT
		//IL_017a: Expected Obj, but got VT
		RouteSection routeSection = default;
		MessageEventArgs e = (MessageEventArgs)(routeSection + 16);
		SectionSpawnMode sectionSpawnMode = (SectionSpawnMode)(routeSection + 34);
		((SectionSpawnMode*)(int)sectionSpawnMode)->value__ = 0;
		ChunkBuildMode chunkBuildMode = (ChunkBuildMode)(routeSection + 33);
		((ChunkBuildMode*)(int)chunkBuildMode)->value__ = 0;
		bool flag = (byte)(routeSection + 32) != 0;
		((bool*)(flag ? 1 : 0))->m_value = false;
		routeSection = (RouteSection)0;
		((UnityEngine.Object)routeSection).m_CachedPtr = (IntPtr)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj = default;
		EnvironmentSegmentParts? environmentSegmentParts = default;
		if ((nint)obj == 1)
		{
			((ChunkBuildMode*)(int)chunkBuildMode)->value__ = 0;
			((bool*)(flag ? 1 : 0))->m_value = false;
			nint num = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v26 (Il2CppClass<UnityEngine.Vector4>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Vector4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v106 (Il2CppClass<UnityEngine.Vector4>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			e._002Ector();
			routeSection = (RouteSection)(object)e;
			((UnityEngine.Object)routeSection).m_CachedPtr = (IntPtr)e.playerId;
			((RouteBuilder)environmentSegmentParts).EnqueueBuildDirective((int)(nint)((UnityEngine.Object)this).m_CachedPtr, sectionSpawnMode, chunkBuildMode, flag, routeSection);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Level.EnvironmentSegmentParts>)+8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v37+C]");
			bool flag2 = (nint)0 < (nint)1;
			if (((SectionSpawnMode*)(int)sectionSpawnMode)->value__ != 0)
			{
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Level.EnvironmentSegmentParts>)+8]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v61+8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v61+8]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v82+10]");
						object obj6 = 0;
					}
					else
					{
						object obj6 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v63+14]");
					RoofedCulling.CullingBlock cullingBlock = (RoofedCulling.CullingBlock)0;
					if (~(cullingBlock.Finalized ? 1u : 0u) != 0)
					{
						object obj7 = cullingBlock + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Level.EnvironmentSegmentParts>)+C]");
						if (0 == (nint)cullingBlock)
						{
							((RoofedCulling)environmentSegmentParts).NextCullingBlock = cullingBlock;
						}
						bool low = cullingBlock.Low;
						int num3 = ((ChunkBuildMode*)(int)chunkBuildMode)->value__ ^ (low ? 1 : 0);
						if (((uint)num3 | (((bool*)(flag ? 1 : 0))->m_value ? 1u : 0u)) == 0)
						{
							goto IL_04c1;
						}
						cullingBlock.Finalized = true;
					}
				}
				if (~(((bool*)(flag ? 1 : 0))->m_value ? 1u : 0u) == 0)
				{
					e = (MessageEventArgs)(object)routeSection;
					e.playerId = (int)(nint)((UnityEngine.Object)routeSection).m_CachedPtr;
					IEnumerator value = ((SimulatedGoogleSignInBridge)null).WaitAndDo((float)segments, (Action)(object)e);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Level.EnvironmentSegmentParts>)+8]");
					LinkedListNode<RoofedCulling.CullingBlock> linkedListNode = ((LinkedList<RoofedCulling.CullingBlock>)0).AddLast((RoofedCulling.CullingBlock)value);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Level.EnvironmentSegmentParts>)+8]");
					return (EnvironmentSegmentParts?)(object)0;
				}
				bool flag3 = ((ChunkBuildMode*)(int)chunkBuildMode)->value__ != 0;
				RoofedCulling.CullingBlock value2 = ((RoofedCulling)null).GenerateCustomCullingBlock((float)segments, (Vector4)flag3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Level.EnvironmentSegmentParts>)+8]");
				LinkedListNode<RoofedCulling.CullingBlock> linkedListNode2 = ((LinkedList<RoofedCulling.CullingBlock>)0).AddLast(value2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Level.EnvironmentSegmentParts>)+8]");
				return (EnvironmentSegmentParts?)(object)0;
			}
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Level.EnvironmentSegmentParts>)+8]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v90+8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v90+8]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v104+10]");
					object obj10 = 0;
				}
				else
				{
					object obj10 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v92+14]");
				RoofedCulling.CullingBlock cullingBlock2 = (RoofedCulling.CullingBlock)0;
				if (!cullingBlock2.Finalized)
				{
					object obj11 = cullingBlock2 + 8;
					cullingBlock2.Finalized = true;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Level.EnvironmentSegmentParts>)+C]");
					if (0 == (nint)cullingBlock2)
					{
						((RoofedCulling)environmentSegmentParts).NextCullingBlock = cullingBlock2;
					}
				}
			}
		}
		goto IL_04c1;
		IL_04c1:
		return environmentSegmentParts;
	}

	public ThemeManager()
	{
		UIScreenController_OnApplicationResumed();
	}

	static ThemeManager()
	{
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_004a: Expected I, but got Obj
		//IL_0060: Expected Obj, but got I
		MergeLevelStartHelp.MERGE_SCENE_NAME_FOR_BUILDS = "Merge";
		nint num = (nint)typeof(MergeLevelStartHelp);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppClass<SYBO.Subway.UI.MergeLevelStartHelp>)+5C]");
		object obj = (nint)0 + (nint)4;
		obj = "GUI";
		nint num2 = (nint)typeof(MergeLevelStartHelp);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v13 (Il2CppClass<SYBO.Subway.UI.MergeLevelStartHelp>)+5C]");
		object obj2 = (nint)0 + (nint)8;
		obj2 = "Merge";
	}
}

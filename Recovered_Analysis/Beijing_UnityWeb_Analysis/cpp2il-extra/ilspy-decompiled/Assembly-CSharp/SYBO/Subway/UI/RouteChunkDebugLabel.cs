using System;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using SYBO.Components.Utilities;
using SYBO.Subway.Characters;
using SYBO.Subway.Visuals;
using UnityEngine;

namespace SYBO.Subway.UI;

public class RouteChunkDebugLabel : MonoBehaviour
{
	private UILabel _label;

	private UISprite _background;

	private StringBuilder sb;

	private int _originalHeight;

	private int _originalWidth;

	private string _originalLabelText;

	private const string WAITING_FOR_CHUNKS = "Waiting for chunks...";

	private void Awake()
	{
		CancelInvoke();
	}

	private unsafe void Game_OnGameStarted()
	{
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0048: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected Obj, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_0101: Expected I, but got Obj
		//IL_0117: Expected Obj, but got I
		//IL_0089: Expected I, but got Obj
		//IL_031c: Expected I, but got Obj
		//IL_0332: Expected Obj, but got I
		//IL_0142: Expected I, but got Obj
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_018f: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		System.Text.StringBuilderCache.Release(stringBuilder);
		object obj = this + 20;
		obj = stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(RouteChunkDebugLabel.Game_OnGameStarted);
		object obj2 = action + 16;
		obj2 = this;
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v70 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnGameStarted -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(RouteChunkDebugLabel.Game_OnGameEnded);
		object obj4 = action2 + 16;
		obj4 = this;
		Game.OnGameEnded -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<bool> action3 = default;
		object obj5 = action3 + 16;
		obj5 = this;
		nint num4 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v39 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num5 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v66 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DebugSettingsPopup.OnRoutePrintSettingChanged -= action3;
		nint num6 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v45 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num7 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v62 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (IPhoneXSupport.CheckIsiPhoneXDevice())
		{
			UIWidget background = _background;
			int height = background.mWidth + 20;
			background.height = height;
			GameObject gameObject = _label.gameObject;
			TransformExtensions.OffsetLocalPosY((Transform)(object)gameObject, 20f);
		}
		UISprite background2 = _background;
		_originalWidth = ((UIWidget)background2).mWidth;
		UISprite background3 = _background;
		_originalHeight = ((UIWidget)background3).mHeight;
		object obj8 = this + 32;
		UILabel label = _label;
		obj8 = label.mText;
		((RouteChunkDebugLabel)null).Update();
	}

	private void Game_OnGameEnded()
	{
		//IL_0162: Expected I, but got Obj
		//IL_0178: Expected Obj, but got I
		//IL_000e: Expected VT, but got Obj
		//IL_00cf: Expected I, but got Obj
		//IL_0128: Expected Obj, but got I4
		//IL_0041: Expected I, but got Obj
		//IL_0057: Expected Obj, but got I
		//IL_0082: Expected I, but got Obj
		if (SingletonMonoBehaviour<>.HasExecuteInEditModeAttribute())
		{
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v30 (T)+10]");
			if ((nint)0 != 0)
			{
				nint num = (nint)typeof(DebugSettingsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v33 (Il2CppClass<DebugSettingsPopup>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(DebugSettingsPopup);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v39 (Il2CppClass<DebugSettingsPopup>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				DebugSettingsPopup.PrintRouteChunksInDebugLabel = false;
			}
		}
		nint num3 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v10 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v22 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(DebugSettingsPopup.PrintRouteChunksInDebugLabel ? 1u : 0u) == 0)
		{
			_background.height = 325;
			Color color = ((UIWidget)25).color;
		}
	}

	private unsafe void DebugSettingsPopup_OnRoutePrintSettingChanged(bool isEnabled)
	{
		//IL_01b1: Expected I, but got Obj
		//IL_01c7: Expected Obj, but got I
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected Obj, but got Unknown
		//IL_027d: Expected VT, but got I4
		//IL_006f: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0090: Expected VT, but got Obj
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_0122: Expected I, but got Obj
		//IL_0138: Expected Obj, but got I
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected Obj, but got Unknown
		//IL_0163: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v54 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 16;
		ParticleSystem particleSystem = UnityEngine.Object.Instantiate((ParticleSystem)(object)_label);
		obj2 = particleSystem;
		GameObject gameObject = _background.gameObject;
		((Transform)(object)gameObject).Translate((Vector3)isEnabled, Space.Self);
		string text = _background.tag;
		((GameObject)(object)text).tag = (string)1;
		GameObject gameObject2 = _background.gameObject;
		Transform transform = default;
		transform.position = (Vector3)gameObject2;
		object obj3 = transform + 12;
		obj3 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		object obj4 = this + 24;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v25+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(FallingSnowThemeEffect.Game_OnGameStarted);
		object obj5 = action + 16;
		obj5 = this;
		nint num3 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v37 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v50 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnGameStarted -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(FallingSnowThemeEffect.Game_OnGameEnded);
		object obj7 = action2 + 16;
		obj7 = this;
		Game.OnGameEnded -= action2;
	}

	private void EnableLabelIfNecessary()
	{
		//IL_001c: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		_background.height = _originalWidth;
		Color color = ((UIWidget)_originalHeight).color;
		_label.fontSize = (int)_originalLabelText;
	}

	private void Update()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v26 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v20 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool printRouteChunksInDebugLabel = Globals.BUILD_PURPOSE == Globals.BuildPurpose.DEV;
		DebugSettingsPopup.PrintRouteChunksInDebugLabel = printRouteChunksInDebugLabel;
	}

	public RouteChunkDebugLabel()
	{
		//IL_05d0: Expected I, but got Obj
		//IL_05e6: Expected Obj, but got I
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Expected Obj, but got Unknown
		//IL_07aa: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00e9: Expected VT, but got Obj
		//IL_00f9: Expected Obj, but got I
		//IL_012c: Expected I, but got Obj
		//IL_0142: Expected Obj, but got I
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Expected Obj, but got Unknown
		//IL_0656: Expected I, but got Obj
		//IL_066c: Expected Obj, but got I
		//IL_069a: Expected F4, but got I
		//IL_016d: Expected I, but got Obj
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		//IL_0236: Expected F4, but got I
		//IL_01ba: Expected I, but got Obj
		//IL_0279: Expected I, but got Obj
		//IL_028f: Expected Obj, but got I
		//IL_06dc: Expected Obj, but got I
		//IL_02ba: Expected I, but got Obj
		//IL_0309: Expected Obj, but got I
		//IL_0320: Expected Obj, but got I
		//IL_0334: Expected Obj, but got I
		//IL_0732: Expected I, but got Obj
		//IL_0748: Expected Obj, but got I
		//IL_0581: Expected I4, but got Obj
		//IL_07e1: Expected Obj, but got I
		//IL_07f3: Expected Obj, but got I4
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0800: Expected I4, but got Unknown
		//IL_0391: Expected I, but got Obj
		//IL_0460: Expected Obj, but got I
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected I4, but got Unknown
		//IL_04e4: Expected Obj, but got I
		//IL_04fb: Expected Obj, but got I
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v118 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 12;
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v16 (System.Boolean)+60]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+8]");
		if ((nint)0 == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v22 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v112 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(DebugSettingsPopup.PrintRouteChunksInDebugLabel ? 1u : 0u) != 0)
		{
			return;
		}
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v31 (T)+50]");
		object obj6 = 0;
		sb.AppendHelper((string)null);
		StringBuilder stringBuilder = sb.AppendLine("Game Z: ");
		nint num5 = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v13 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num6 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S1_v88 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterRendering instance = CharacterRendering.Instance;
		object obj8 = instance + 236;
		obj2 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S2_v7+8]");
		_ = 0;
		nint num7 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S2_v12 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num8 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S2_v53 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14+8]");
		GUILayoutOption value = GUILayout.Width(0f);
		StringBuilder stringBuilder2 = sb.Append(value);
		StringBuilder stringBuilder3 = sb.AppendLine("\t, world Z: ");
		CharacterRendering instance2 = CharacterRendering.Instance;
		object obj10 = instance2 + 248;
		obj3 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S2_v21+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		GUILayoutOption value2 = GUILayout.Width(0f);
		StringBuilder stringBuilder4 = sb.Append(value2);
		StringBuilder stringBuilder5 = sb.AppendLine("\n");
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S1_v84 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v32+C]");
		int num14;
		int num15;
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v32+C]");
			object obj12 = 0;
			StringBuilder stringBuilder6 = sb;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S1_v50+50]");
			StringBuilder stringBuilder7 = stringBuilder6.AppendLine((string)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v32+8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v32+8]");
			bool flag;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v70+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			nint num11 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S1_v53 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num12 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S1_v80 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v32+10]");
			int num13 = ((ComputeShader)0).FindKernel(null);
			object obj15 = (flag ? 1 : 0) ^ 1;
			if ((num13 | obj15) != 0)
			{
				StringBuilder stringBuilder8 = sb.AppendLine(" (");
			}
			num14 = num13 & 1;
			if (flag)
			{
				if (num13 != 0)
				{
					num15 = 0;
					goto IL_04d4;
				}
				num15 = 0;
			}
			else
			{
				StringBuilder stringBuilder9 = sb;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v32+8]");
				StringBuilder stringBuilder10 = stringBuilder9.AppendLine((string)0);
				int num16 = num13 ^ 1;
				int num17 = obj15 & num16;
				int num18 = num17 & 1;
				bool flag2 = num13 == 0;
				num15 = num18;
				if (!flag2)
				{
					StringBuilder stringBuilder11 = sb.AppendLine("/");
					num15 = 1;
					goto IL_04d4;
				}
			}
			goto IL_0504;
		}
		goto IL_06fd;
		IL_06fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj16 = default;
		bool flag3;
		if (obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v55+8]");
			flag3 = (nint)0 == 0;
		}
		else
		{
			flag3 = true;
		}
		if (flag3)
		{
			_label.fontSize = (int)"Waiting for chunks...";
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			int fontSize = default;
			_label.fontSize = fontSize;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		int fontSize2 = default;
		_label.fontSize = fontSize2;
		return;
		IL_0504:
		if ((num15 | num14) != 0)
		{
			StringBuilder stringBuilder12 = sb.AppendLine(")");
		}
		goto IL_06fd;
		IL_04d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v32+10]");
		object obj17 = 0;
		StringBuilder stringBuilder13 = sb;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ S1_v69+50]");
		StringBuilder stringBuilder14 = stringBuilder13.AppendLine((string)0);
		goto IL_0504;
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.Extensions;
using SYBO.Subway.Characters;
using SYBO.Subway.Level;
using SYBO.Subway.Routes;
using SYBO.Subway.StateSystem;
using SYBO.Subway.StateSystem.States;
using SYBO.Subway.Themes;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;

namespace SYBO.Subway.Visuals;

public class RoofedCulling
{
	[Serializable]
	public class CustomRoofedCulling
	{
		public EnvironmentType EnvironmentType;

		public Vector4 CullingBounds;

		public CustomRoofedCulling()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private class CullingBlock
	{
		private Vector4 _value;

		public bool Low;

		public bool Finalized;

		public float CullStartGameZ
		{
			get
			{
				//IL_000d: Expected F4, but got I
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Visuals.RoofedCulling+CullingBlock)+C]");
				return 0f;
			}
			set
			{
				//IL_0285: Expected I, but got Obj
				//IL_029b: Expected Obj, but got I
				//IL_0380: Expected Obj, but got I4
				//IL_039e: Expected Obj, but got I
				//IL_01b5: Expected Obj, but got I
				//IL_01dc: Expected Obj, but got I
				//IL_01f6: Expected Obj, but got I
				//IL_0229: Expected Obj, but got I
				//IL_0229: Expected Obj, but got VT
				//IL_023c: Expected Obj, but got VT
				//IL_0013: Expected I, but got Obj
				//IL_025b: Expected Obj, but got I
				//IL_0271: Expected Obj, but got I
				//IL_0062: Expected Obj, but got I
				//IL_007c: Expected Obj, but got I
				//IL_008a: Expected I, but got Obj
				//IL_00a0: Expected Obj, but got I
				//IL_02d9: Expected F4, but got I
				//IL_02d9: Expected F4, but got I
				//IL_02fc: Expected Obj, but got I
				//IL_0316: Expected Obj, but got I
				//IL_0330: Expected Obj, but got I
				//IL_0351: Expected F4, but got I
				//IL_0351: Expected F4, but got I
				//IL_0365: Expected Obj, but got VT
				//IL_012f: Expected Obj, but got I
				//IL_012f: Expected Obj, but got VT
				//IL_0142: Expected Obj, but got VT
				//IL_00cb: Expected I, but got Obj
				//IL_0161: Expected Obj, but got I
				//IL_0182: Expected F4, but got I
				//IL_0182: Expected F4, but got I
				//IL_019b: Expected Obj, but got I
				nint num = (nint)typeof(GameStateMachine);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(GameStateMachine);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v50 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
				IEnumerator enumerator = ((DeathState)useBenchmarkRoute).DelayGameOverScreen();
				Vector4 value2 = _value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v5 (UnityEngine.Vector4)+94]");
				object obj2 = 0;
				Vector4 value3 = _value;
				if (enumerator != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v8 (UnityEngine.Vector4)+90]");
					object obj3 = 0;
					Vector4 value4 = _value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v28 (UnityEngine.Vector4)+58]");
					object obj4 = 0;
					nint num3 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v32 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num4 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v46 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v25+8]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v29+8]");
					float num6 = Mathf.LerpUnclamped(num5, 0f, value);
					Vector4 value5 = _value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v38 (UnityEngine.Vector4)+94]");
					object obj6 = 0;
					Vector4 value6 = _value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v25 (UnityEngine.Vector4)+90]");
					object obj7 = 0;
					Vector4 value7 = _value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S2_v7 (UnityEngine.Vector4)+58]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v26+C]");
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S2_v8+C]");
					float num8 = Mathf.LerpUnclamped(num7, 0f, value);
					float heightOffset = ((DizzyStarsHeightControl)_value).HeightOffset;
					Vector4 value8 = _value;
					Vector4 value9 = _value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S3_v9 (UnityEngine.Vector4)+94]");
					float gameSpeed = UIExtensions.CenterChildrenHorizontally((Transform[])value9, heightOffset, (Transform)0);
					((Game)_value).LockGameSpeedTo(gameSpeed);
					Vector4 value10 = _value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v43 (UnityEngine.Vector4)+A8]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Visuals.RoofedCulling+CullingBlock)+C]");
					nint num9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Visuals.RoofedCulling+CullingBlock)+10]");
					float orthographicSize = Mathf.LerpUnclamped(num9, 0f, value);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v44+6C]");
					((Camera)0).orthographicSize = orthographicSize;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v8 (UnityEngine.Vector4)+58]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v11+8]");
					_ = 0;
					Vector4 value11 = _value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v16 (UnityEngine.Vector4)+94]");
					object obj11 = 0;
					Vector4 value12 = _value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v14 (UnityEngine.Vector4)+58]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v15+C]");
					_ = 0;
					Vector4 value13 = _value;
					Vector4 value14 = _value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S3_v3 (UnityEngine.Vector4)+94]");
					float gameSpeed2 = UIExtensions.CenterChildrenHorizontally((Transform[])value14, 0f, (Transform)0);
					((Game)_value).LockGameSpeedTo(gameSpeed2);
					Vector4 value15 = _value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v21 (UnityEngine.Vector4)+A8]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v22+6C]");
					((Camera)0).orthographicSize = 68f;
				}
			}
		}

		public float CullStartGameY
		{
			get
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				//IL_0010: Expected F4, but got Obj
				object obj = this + 8;
				return (float)obj;
			}
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				//IL_0013: Expected Obj, but got F4
				object obj = this + 8;
				obj = value;
			}
		}

		public float CullEndGameZ
		{
			get
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				//IL_0018: Expected F4, but got I
				object obj = this + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				return 0f;
			}
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				object obj = this + 8;
			}
		}

		public float CullEndGameY
		{
			get
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				//IL_0018: Expected F4, but got I
				object obj = this + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				return 0f;
			}
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				object obj = this + 8;
			}
		}

		public unsafe Vector4 ToVector4()
		{
			//IL_000a: Expected F4, but got Obj
			//IL_0005: Expected native int or pointer, but got VT
			Vector4 vector = default;
			((Vector4*)(nint)vector)->z = (float)this;
			return vector;
		}

		public CullingBlock()
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected Obj, but got Unknown
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector4>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num2 = (nint)typeof(Vector4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v21 (Il2CppClass<UnityEngine.Vector4>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			MessageEventArgs e = default;
			e._002Ector();
			object obj = e + 16;
			obj = e;
			_ = e.playerId;
			object obj2 = this + 12;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v15+8]");
			_ = 0;
		}
	}

	private const string CurrentCullingKeyword = "_RoofedCullCurrent";

	private const string NextCullingKeyword = "_RoofedCullNext";

	private const string GamePositionOffsetZKeyword = "_RoofedCullingGamePositionOffsetZ";

	private LinkedList<CullingBlock> _cullingBlockList;

	private CullingBlock _currentCullingBlock;

	private CullingBlock _nextCullingBlock;

	private CullingBlock _emptyCullingblock;

	private CullingBlock _menuCullingblock;

	private Theme _theme;

	private CullingBlock CurrentCullingBlock
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0a4e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a53: Expected Obj, but got Unknown
			//IL_0a5c: Expected Obj, but got I4
			//IL_0a6b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a70: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 48;
			object obj3 = obj2 + 24;
			obj3 = 0;
			_ = 0;
			Material material = (Material)(obj2 + 16);
			material = (Material)obj;
			_ = -1;
			throw new IndexOutOfRangeException();
		}
		set
		{
			//IL_0029: Expected Obj, but got I
			//IL_0045: Expected Obj, but got I4
			//IL_0053: Expected I4, but got Obj
			bool low = value.Low;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v4 (System.Boolean)+C]");
			object obj = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @726B");
			int index = default;
			HuntTokenCollectVFXColorCycle.ColorEntry colorEntry = ((List<HuntTokenCollectVFXColorCycle.ColorEntry>)value.Low).get_Item(index);
			((HuntTokenCollectVFXColorCycle._003CPlayEffect_003Ed__6)this)._002Ector((int)colorEntry);
		}
	}

	private unsafe CullingBlock NextCullingBlock
	{
		get
		{
			return _currentCullingBlock;
		}
		set
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected Obj, but got Unknown
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected VT, but got Unknown
			//IL_0058: Expected F4, but got Obj
			//IL_0053: Expected native int or pointer, but got VT
			//IL_006d: Expected F4, but got I
			//IL_0068: Expected native int or pointer, but got VT
			object obj = this + 12;
			obj = value;
			object obj2 = _currentCullingBlock + 8;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v7+8]");
			_ = 0;
			Color color = (Color)(obj3 + 16);
			((Color*)(nint)color)->r = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Color*)(nint)color)->b = 0f;
			Shader.SetGlobalColor("_RoofedCullCurrent", color);
		}
	}

	public void Initialize()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	private unsafe void Game_OnGameStarted()
	{
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_005b: Expected I, but got Obj
		//IL_0071: Expected Obj, but got I
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_00e9: Expected I, but got Obj
		//IL_00ff: Expected Obj, but got I
		//IL_009c: Expected I, but got Obj
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_0243: Expected Obj, but got I
		//IL_012a: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj = default;
		obj.method_ptr = method_ptr;
		obj.method = (nint)__ldftn(RoofedCulling.RouteChunk_OnEnvironmentSegmentSpawned);
		object obj2 = obj + 16;
		obj2 = this;
		Delegate obj3 = ((Delegate)RouteChunk.OnEnvironmentSegmentSpawned).CombineImpl(obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		Action<EnvironmentKind, int, Route> onEnvironmentSegmentSpawned = default;
		RouteChunk.OnEnvironmentSegmentSpawned = onEnvironmentSegmentSpawned;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr2;
		((Delegate)action).method = (nint)__ldftn(RoofedCulling.Game_OnGameStarted);
		object obj4 = action + 16;
		obj4 = this;
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v20 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v43 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnGameStarted -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr3;
		((Delegate)action2).method = (nint)__ldftn(RoofedCulling.Game_OnGameEnded);
		object obj6 = action2 + 16;
		obj6 = this;
		Game.OnGameEnded -= action2;
		nint num3 = (nint)typeof(ThemeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v33 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(ThemeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v39 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj8 = this + 28;
		GameStateMachine instance = GameStateMachine.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v32 (SYBO.Subway.StateSystem.GameStateMachine)+20]");
		obj8 = 0;
	}

	private void Game_OnGameEnded()
	{
		((FallingSnowThemeEffect)this).Initialize((Transform)(object)_emptyCullingblock);
	}

	public void UpdateCulling()
	{
		_cullingBlockList.Clear();
	}

	private void RouteChunk_OnEnvironmentSegmentSpawned(EnvironmentKind environmentKind, int gamePositionZ, Route route)
	{
		//IL_0347: Expected Obj, but got I
		_ = 0f;
		((Game)this).ResetEnemyForEnterPlay();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Visuals.RoofedCulling)+88]");
		((Character)0).ClearLastObstacleType();
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		((GameStats)(object)privacyPolicyUrl).ClearPowerups();
		throw new NullReferenceException();
	}

	private unsafe void EvaluateEnvironment(EnvironmentType environmentType, out bool cullEnvironment, ref bool cullLow, ref bool cullCustom, ref Vector4 customCullingBounds)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0038: Expected Obj, but got I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_008a: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Visuals.RoofedCulling)+88]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2+9C]");
		bool flag = (nint)0 != 0;
		object obj2 = (flag ? 1 : 0) ^ 1;
		object obj3 = obj2 | System.Runtime.CompilerServices.Unsafe.AsPointer(ref customCullingBounds);
		if (obj3 == null)
		{
			object obj4 = this + 156;
			bool isCompleted = ((RouteTransitionState)this).IsCompleted;
			obj4 = isCompleted;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Visuals.RoofedCulling)+9C]");
			Coroutine coroutine = ((MonoBehaviour)this).StartCoroutine_Auto((IEnumerator)0);
		}
	}

	private CullingBlock GenerateCullingBlock(float gamePosZ, bool low)
	{
		//IL_001d: Expected VT, but got I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0038: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CullingBlock cullingBlock = default;
		cullingBlock._value = (Vector4)0;
		object obj = cullingBlock + 20;
		obj = low;
		return cullingBlock;
	}

	private CullingBlock GenerateCustomCullingBlock(float gamePosZ, Vector4 customCullingBounds)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		//IL_004a: Expected Obj, but got F4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_0088: Invalid comparison between VT and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DeathState._003CDelayGameOverScreen_003Ed__8 obj = default;
		((IDisposable)obj).Dispose();
		object obj2 = obj + 8;
		obj2 = gamePosZ;
		object obj3 = obj + 8;
		_ = -1000f;
		object obj4 = obj + 8;
		object obj5 = obj + 8;
		if (customCullingBounds != (Vector4)(object)0)
		{
			float num = 90f;
		}
		else
		{
			float num = 1000f;
		}
		object obj6 = customCullingBounds & 1;
		return (CullingBlock)(object)obj;
	}

	public RoofedCulling()
	{
		//IL_0571: Expected I, but got Obj
		//IL_0587: Expected Obj, but got I
		//IL_06f1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_05b2: Expected I, but got Obj
		//IL_05c8: Expected Obj, but got I
		//IL_0728: Unknown result type (might be due to invalid IL or missing references)
		//IL_072d: Expected Obj, but got Unknown
		//IL_0750: Expected I, but got Obj
		//IL_0766: Expected Obj, but got I
		//IL_0605: Expected F4, but got I
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Expected Obj, but got Unknown
		//IL_0627: Expected Obj, but got I4
		//IL_0287: Expected I, but got Obj
		//IL_069b: Expected I, but got Obj
		//IL_06b1: Expected Obj, but got I
		//IL_02d4: Expected I, but got Obj
		//IL_07d3: Expected F4, but got I
		//IL_0524: Expected I, but got Obj
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v135 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14 (System.Boolean)+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		if ((nint)0 != 0)
		{
			LinkedList<CullingBlock> cullingBlockList = _cullingBlockList;
			if (cullingBlockList.count < 1)
			{
				if (_currentCullingBlock != _emptyCullingblock)
				{
					NextCullingBlock = _emptyCullingblock;
					((FallingSnowThemeEffect)this).Initialize((Transform)(object)_emptyCullingblock);
				}
			}
			else
			{
				LinkedList<CullingBlock> cullingBlockList2 = _cullingBlockList;
				LinkedListNode<CullingBlock> head = cullingBlockList2.head;
				if (_currentCullingBlock != head.item)
				{
					NextCullingBlock = head.item;
					LinkedListNode<CullingBlock> linkedListNode;
					if (head.next != null)
					{
						LinkedList<CullingBlock> list = head.list;
						linkedListNode = ((head.next != list.head) ? head.next : null);
					}
					else
					{
						linkedListNode = null;
					}
					if (linkedListNode != null)
					{
						LinkedListNode<CullingBlock> linkedListNode2;
						if (head.next != null)
						{
							LinkedList<CullingBlock> list2 = head.list;
							linkedListNode2 = ((head.next != list2.head) ? head.next : null);
						}
						else
						{
							linkedListNode2 = null;
						}
						((FallingSnowThemeEffect)this).Initialize((Transform)(object)linkedListNode2.item);
					}
				}
			}
		}
		else if (_currentCullingBlock != _menuCullingblock)
		{
			NextCullingBlock = _menuCullingblock;
			((FallingSnowThemeEffect)this).Initialize((Transform)(object)_menuCullingblock);
		}
		nint num3 = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v19 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v92 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterRendering instance = CharacterRendering.Instance;
		object obj4 = instance + 236;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S1_v10+8]");
		_ = 0;
		nint num5 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v15 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v69 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		int num7 = Mathf.RoundToInt(0f);
		object obj7 = _currentCullingBlock + 8;
		object obj8 = num7 - 90;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v30+8]");
		if (0 < (nint)obj8)
		{
			LinkedList<CullingBlock> cullingBlockList3 = _cullingBlockList;
			if (cullingBlockList3.count >= 1)
			{
				LinkedList<CullingBlock> cullingBlockList4 = _cullingBlockList;
				LinkedListNode<CullingBlock> head2 = cullingBlockList4.head;
				if (_currentCullingBlock == head2.item)
				{
					_cullingBlockList.RemoveFirst();
				}
			}
			LinkedList<CullingBlock> cullingBlockList5 = _cullingBlockList;
			if (cullingBlockList5.count < 1)
			{
				if (_currentCullingBlock != _emptyCullingblock)
				{
					NextCullingBlock = _emptyCullingblock;
					((FallingSnowThemeEffect)this).Initialize((Transform)(object)_emptyCullingblock);
				}
			}
			else
			{
				LinkedList<CullingBlock> cullingBlockList6 = _cullingBlockList;
				LinkedListNode<CullingBlock> head3 = cullingBlockList6.head;
				NextCullingBlock = head3.item;
				LinkedListNode<CullingBlock> linkedListNode3;
				if (head3.next != null)
				{
					LinkedList<CullingBlock> list3 = head3.list;
					linkedListNode3 = ((head3.next != list3.head) ? head3.next : null);
				}
				else
				{
					linkedListNode3 = null;
				}
				if (linkedListNode3 != null)
				{
					LinkedListNode<CullingBlock> linkedListNode4;
					if (head3.next != null)
					{
						LinkedList<CullingBlock> list4 = head3.list;
						linkedListNode4 = ((head3.next != list4.head) ? head3.next : null);
					}
					else
					{
						linkedListNode4 = null;
					}
					((FallingSnowThemeEffect)this).Initialize((Transform)(object)linkedListNode4.item);
				}
			}
		}
		nint num8 = (nint)typeof(GamePositionRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v35 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num9 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S0_v45 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isRestricted = AgeRestriction.isRestricted;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S0_v40 (System.Boolean)+10]");
		((Light)(object)"_RoofedCullingGamePositionOffsetZ").intensity = 0f;
	}
}

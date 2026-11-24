using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using Kiloo.Monetization.FlurryPlugin;
using SYBO.Components.Utilities;
using SYBO.Subway;
using SYBO.Subway.Benchmarking;
using SYBO.Subway.Cameras;
using SYBO.Subway.Characters;
using SYBO.Subway.Level;
using SYBO.Subway.Rendering;
using SYBO.Subway.Routes;
using SYBO.Subway.Routes.Builders.Worker;
using SYBO.Subway.Visuals;
using UnityEngine;

public class Revive : MonoBehaviour
{
	public delegate void OnSwitchToRunningDelegate();

	public delegate void OnReviveDelegate();

	private sealed class _003CReviveNow_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Revive _003C_003E4__this;

		public bool revivedWithAds;

		public bool adsWasAvailable;

		public bool adsFailed;

		private float _003CtimeLeft_003E5__2;

		private float _003CtimeLeftFX_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0073: Expected Obj, but got I4
				//IL_008f: Expected VT, but got Obj
				//IL_009d: Expected Obj, but got VT
				//IL_015f: Expected VT, but got Obj
				//IL_017c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0181: Expected Obj, but got Unknown
				//IL_01a4: Expected I, but got Obj
				//IL_01ba: Expected Obj, but got I
				//IL_012f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0134: Expected Obj, but got Unknown
				//IL_013d: Expected Obj, but got I4
				//IL_0151: Expected Obj, but got I4
				//IL_043a: Expected Obj, but got I
				//IL_0457: Expected Obj, but got I
				//IL_0484: Expected F4, but got I
				//IL_028d: Expected Obj, but got I4
				//IL_028d: Expected Obj, but got I4
				//IL_01e5: Expected I, but got Obj
				//IL_0356: Unknown result type (might be due to invalid IL or missing references)
				//IL_035b: Expected Obj, but got Unknown
				//IL_0364: Expected Obj, but got I4
				//IL_0378: Expected Obj, but got I4
				//IL_02e2: Expected Obj, but got I4
				Revive revive = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							goto IL_03f2;
						}
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					string tag = revive._reviveParticles.tag;
					((GameObject)(object)tag).tag = (string)1;
					revive._reviveParticles.Stop();
					_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
					((AudioStateLoop)val)._002Ector();
					_003CtimeLeft_003E5__2 = revive.WaitForParticlesDelay;
				}
				if (_003CtimeLeft_003E5__2 > 0f)
				{
					float unscaledTime = Time.unscaledTime;
					float num = _003CtimeLeft_003E5__2 - unscaledTime;
					_003CtimeLeft_003E5__2 = num;
					object obj = this + 12;
					obj = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				_00210 val2 = (_00210)SingletonMonoBehaviour<>.Instantiate();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object obj2 = revive.character + 236;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S2_v10+8]");
				_ = 0;
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S3_v5 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num3 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S3_v18 (Il2CppClass<SYBO.Subway.Game>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool isInstantiated = Game.IsInstantiated;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S3_v10 (System.Boolean)+58]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S3_v10 (System.Boolean)+44]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S4_v5+8]");
				object obj6 = num4 / 0;
				float reqPositionCleanedUpGameZ = revive.RemoveObstaclesDistance * (float)obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				RouteBuilderWorker routeBuilderWorker = default;
				routeBuilderWorker.UpdateWorker(0f, reqPositionCleanedUpGameZ);
				if (revive.m_OnRevive != null)
				{
					revive.m_OnRevive();
				}
				bool flag = revivedWithAds;
				bool gamePositionZ = adsWasAvailable;
				bool flag2 = adsFailed;
				((RoofedCulling)(object)revive.game).RouteChunk_OnEnvironmentSegmentSpawned((EnvironmentKind)flag, gamePositionZ ? 1 : 0, (Route)flag2);
				if (revive.m_OnSwitchToRunning != null)
				{
					revive.m_OnSwitchToRunning();
				}
				string tag2 = revive._reviveFX.tag;
				((GameObject)(object)tag2).tag = (string)1;
				ReviveFX reviveFX = revive._reviveFX;
				IEnumerator enumerator = reviveFX.ReviveAnimation.GetEnumerator();
				float frameRate = revive.ReviveAnimationClip.frameRate;
				_003CtimeLeftFX_003E5__3 = frameRate;
				goto IL_03f2;
				IL_03f2:
				if (_003CtimeLeftFX_003E5__3 > 0f)
				{
					float unscaledTime2 = Time.unscaledTime;
					float num5 = _003CtimeLeftFX_003E5__3 - unscaledTime2;
					_003CtimeLeftFX_003E5__3 = num5;
					object obj7 = this + 12;
					obj7 = 0;
					_003C_003E1__state = 2;
					return 1;
				}
				string tag3 = revive._reviveFX.tag;
				((GameObject)(object)tag3).tag = null;
				string tag4 = revive._reviveParticles.tag;
				((GameObject)(object)tag4).tag = null;
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CReviveNow_003Ed__19(int _003C_003E1__state)
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Revive+<ReviveNow>d__19)+34]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Revive+<ReviveNow>d__19)+34]");
			object obj3;
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Revive+<ReviveNow>d__19)+34]");
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

	private Game game;

	private Character character;

	public float WaitForParticlesDelay;

	public float RemoveObstaclesDistance;

	private OnSwitchToRunningDelegate m_OnSwitchToRunning;

	private OnReviveDelegate m_OnRevive;

	private MainCamera _mainCamera;

	private ParticleSystem _reviveParticles;

	private ReviveFX _reviveFX;

	private AnimationClip ReviveAnimationClip;

	private static Revive instance;

	public static Revive Instance
	{
		get
		{
			//IL_006a: Expected I4, but got Obj
			//IL_0078: Expected I, but got Obj
			//IL_008e: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			GameObject gameObject = default;
			gameObject.layer = (int)"IncomingCallReceiverBridge";
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((UnityEngine.UnitySynchronizationContext)(object)gameObject).Exec();
			return (Revive)(object)gameObject.AddComponent<AndroidIncomingCallBridge>();
		}
	}

	public event OnSwitchToRunningDelegate OnSwitchToRunning
	{
		add
		{
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnSwitchToRunning;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 28;
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

	public event OnReviveDelegate OnRevive
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnSwitchToRunning;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 28;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnRevive;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 32;
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

	private void Start()
	{
	}

	public void SendRevive(bool revivedWithAds, bool adsWasAvailable, bool adsFailed)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		object obj = this + 8;
		obj = revivedWithAds;
	}

	public void SendSkipRevive()
	{
		//IL_01a0: Expected I, but got Obj
		//IL_01b6: Expected Obj, but got I
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected Obj, but got Unknown
		//IL_02e4: Expected Obj, but got I4
		//IL_02f2: Expected I, but got Obj
		//IL_0308: Expected Obj, but got I
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_01fd: Expected I, but got Obj
		//IL_0213: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_0254: Expected Obj, but got I
		//IL_0265: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0107: Expected I, but got Obj
		//IL_011d: Expected Obj, but got I
		//IL_00ad: Expected I, but got Obj
		//IL_0293: Expected Obj, but got I4
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected Obj, but got Unknown
		//IL_0148: Expected I, but got Obj
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v43 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 12;
		bool isInstantiated = Game.IsInstantiated;
		obj2 = isInstantiated;
		nint num3 = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v13 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v39 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = this + 16;
		CharacterRendering characterRendering = CharacterRendering.Instance;
		obj4 = characterRendering;
		nint num5 = (nint)typeof(CharacterCamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v20 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(CharacterCamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v35 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = this + 40;
		int selectedBenchmarkIndex = SubwayBenchmarkContainer.SelectedBenchmarkIndex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v13 (System.Int32)+10]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v14+10]");
		ParticleSystem component = ((Component)0).GetComponent<ParticleSystem>();
		obj6 = component;
		Renderer component2 = _reviveParticles.GetComponent<Renderer>();
		Material sharedMaterial = component2.sharedMaterial;
		nint num7 = (nint)typeof(RenderQueues);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v21 (Il2CppClass<SYBO.Subway.Rendering.RenderQueues>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num8 = (nint)typeof(RenderQueues);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v34 (Il2CppClass<SYBO.Subway.Rendering.RenderQueues>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		sharedMaterial.EnableKeyword((string)RenderQueues.TransparentOverlay);
		object obj9 = this + 44;
		CharacterRendering characterRendering2 = CharacterRendering.Instance;
		obj9 = characterRendering2._shadowMeshRenderer;
		string text = _reviveFX.tag;
		((GameObject)(object)text).tag = null;
	}

	private IEnumerator ReviveNow(bool revivedWithAds, bool adsWasAvailable, bool adsFailed)
	{
		//IL_0437: Expected I, but got Obj
		//IL_044d: Expected Obj, but got I
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Expected Obj, but got Unknown
		//IL_0677: Unknown result type (might be due to invalid IL or missing references)
		//IL_067c: Expected Obj, but got Unknown
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected Obj, but got Unknown
		//IL_0694: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0473: Expected Obj, but got I4
		//IL_048d: Expected Obj, but got I
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected Obj, but got Unknown
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected Obj, but got Unknown
		//IL_04d5: Expected Obj, but got I4
		//IL_04d5: Expected Obj, but got I4
		//IL_00fb: Expected I, but got Obj
		//IL_0111: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0189: Expected I, but got Obj
		//IL_019f: Expected Obj, but got I
		//IL_013c: Expected I, but got Obj
		//IL_023c: Expected Obj, but got I4
		//IL_01ca: Expected I, but got Obj
		//IL_0256: Expected Obj, but got I
		//IL_026c: Expected Obj, but got I
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected Obj, but got Unknown
		//IL_02af: Expected Obj, but got I
		//IL_02db: Expected I, but got Obj
		//IL_02f1: Expected Obj, but got I
		//IL_0588: Expected Obj, but got I4
		//IL_0595: Expected I4, but got Obj
		//IL_05ab: Expected Obj, but got I
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Expected Obj, but got Unknown
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Expected Obj, but got Unknown
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Expected Obj, but got Unknown
		//IL_05f0: Expected Obj, but got I4
		//IL_031c: Expected I, but got Obj
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected Obj, but got Unknown
		//IL_039f: Expected I, but got Obj
		//IL_03b5: Expected Obj, but got I
		//IL_0611: Expected Obj, but got I4
		//IL_061e: Expected I4, but got Obj
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Expected Obj, but got Unknown
		//IL_03e0: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v74 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Transform transform = (Transform)(obj2 + 48);
		object obj3 = obj2 + 32;
		object obj4 = obj2 + 16;
		IEnumerator result;
		if (((ComputeShader)revivedWithAds).FindKernel(null) != 0)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v26 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v70 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GameObject gameObject = UnityEngine.Object.Instantiate((GameObject)revivedWithAds);
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S2_v4 (Il2CppMethodInfo)+18]");
			object obj6 = 0;
			object obj7 = obj6;
			object obj8 = obj7 & 0x1FFF;
			object obj9 = obj8 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v129 @ S3_v5 (should have been resolved before IL gen)");
			int layer = gameObject.layer;
			((Transform)layer).parentInternal = (Transform)adsFailed;
			int layer2 = gameObject.layer;
			nint num6 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v17 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num7 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S1_v75 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one = Vector3.one;
			transform = (Transform)obj3;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v16+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
			int layer3 = gameObject.layer;
			nint num8 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S1_v27 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num9 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S1_v71 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector2 zero = Vector2.zero;
			transform = (Transform)obj4;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v18+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			Vector3 localScale = transform.localScale;
			int layer4 = gameObject.layer;
			Vector3 forward = Vector3.forward;
			transform = (Transform)obj2;
			Transform transform4 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			((Transform)layer4).parent = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Revive)+D4]");
			((List<GameObject>)0).Add(gameObject);
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S3_v7 (Il2CppMethodInfo)+18]");
			object obj12 = 0;
			object obj13 = obj12;
			object obj14 = obj13 & 0x1FFF;
			object obj15 = obj14 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v90 @ S4_v7 (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Revive)+D8]");
			Renderer item = default;
			((List<Renderer>)0).Add(item);
			IEnumerator enumerator = default;
			if (adsWasAvailable)
			{
				nint num11 = (nint)typeof(Layers);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v47 (Il2CppClass<Layers>)+BA]");
				object obj16 = (nint)0 & (nint)0x200;
				if (obj16 != null)
				{
					nint num12 = (nint)typeof(Layers);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v66 (Il2CppClass<Layers>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool startupFinished = LoadLevelCtrl.StartupFinished;
				object obj17 = (startupFinished ? 1 : 0) - -64;
				gameObject.SetActive((byte)(int)obj17 != 0);
				nint num13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S2_v36 (Il2CppMethodInfo)+18]");
				object obj18 = 0;
				object obj19 = obj18;
				object obj20 = obj19 & 0x1FFF;
				object obj21 = obj20 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v92 @ S3_v13 (should have been resolved before IL gen)");
				object obj23 = default;
				object obj22 = obj23 + 12;
				object obj24 = 0;
				while (true)
				{
					bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22);
					result = enumerator;
					if (flag)
					{
						break;
					}
					object obj25 = obj23 + 16;
					object obj26 = obj24 << 2;
					object obj27 = obj25 + obj26;
					string text = ((Component)obj27).tag;
					nint num14 = (nint)typeof(Layers);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S1_v58 (Il2CppClass<Layers>)+BA]");
					object obj28 = (nint)0 & (nint)0x200;
					if (obj28 != null)
					{
						nint num15 = (nint)typeof(Layers);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S1_v67 (Il2CppClass<Layers>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool startupFinished2 = LoadLevelCtrl.StartupFinished;
					object obj29 = (startupFinished2 ? 1 : 0) - -64;
					((GameObject)(object)text).SetActive((byte)(int)obj29 != 0);
					object obj30 = obj24 + 1;
					obj24 = obj30;
				}
			}
			else
			{
				result = enumerator;
			}
		}
		else
		{
			result = null;
		}
		return result;
	}

	public Revive()
	{
		IEnumerator routine = game.EnableCharacterDayEventAnimation();
		Coroutine coroutine = StartCoroutine_Auto(routine);
	}

	static Revive()
	{
		//IL_0030: Expected I, but got Obj
		//IL_0046: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		FlurryVideoAds.LogError(text, (UnityEngine.Object)null);
		NotificationsObserver._jsonConverter = (IJsonSerializer)(object)text;
		nint num = (nint)typeof(NotificationsObserver);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v12 (Il2CppClass<NotificationsObserver>)+5C]");
		object obj = (nint)0 + (nint)4;
		obj = 0;
	}
}

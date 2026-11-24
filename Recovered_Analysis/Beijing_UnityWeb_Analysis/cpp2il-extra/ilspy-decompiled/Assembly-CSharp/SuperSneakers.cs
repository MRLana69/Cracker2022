using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using SYBO.Common;
using SYBO.Subway.Cameras;
using SYBO.Subway.Characters;
using UnityEngine;
using UnityEngine.Rendering;

public class SuperSneakers : CharacterModifier
{
	public delegate void OnSwitchToSuperSneakersDelegate();

	public delegate void SuperSneakerOnStopDelegate();

	private sealed class _003CBegin_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SuperSneakers _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_02f8: Expected I, but got Obj
				//IL_030e: Expected Obj, but got I
				//IL_0489: Unknown result type (might be due to invalid IL or missing references)
				//IL_048e: Expected Obj, but got Unknown
				//IL_0497: Expected Obj, but got I4
				//IL_04ab: Expected Obj, but got I4
				//IL_0339: Expected I, but got Obj
				//IL_020b: Expected I, but got Obj
				//IL_0221: Expected Obj, but got I
				//IL_024c: Expected I, but got Obj
				SuperSneakers superSneakers = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					Character character = superSneakers.character;
					character._isJumpingHigher = true;
					((CharacterModifier)superSneakers)._paused = false;
					Character character2 = superSneakers.character;
					if (~(character2._isStumbling ? 1u : 0u) == 0)
					{
						superSneakers.character.HitByTrainSequence();
					}
					CharacterRendering characterRendering = superSneakers.characterRendering;
					CharacterModel characterModel = characterRendering._characterModel;
					characterModel._meshSuperSneaker.shadowCastingMode = ShadowCastingMode.On;
					superSneakers.isActive = true;
					superSneakers.longMagnet.Deactivate();
					if (superSneakers.m_OnSwitchToSuperSneakers != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
					}
					superSneakers.stop = StopSignal.DONT_STOP;
				}
				ActivePowerup powerup = superSneakers._powerup;
				if (powerup.timeLeft > 0f && superSneakers.stop == StopSignal.DONT_STOP)
				{
					if (~(((CharacterModifier)superSneakers)._paused ? 1u : 0u) != 0)
					{
						float unscaledTime = Time.unscaledTime;
						float timeActiveInARow = superSneakers.timeActiveInARow + unscaledTime;
						superSneakers.timeActiveInARow = timeActiveInARow;
						nint num = (nint)typeof(SuperSneakers);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v70 (Il2CppClass<SuperSneakers>)+BA]");
						object obj = (nint)0 & (nint)0x200;
						if (obj != null)
						{
							nint num2 = (nint)typeof(SuperSneakers);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v78 (Il2CppClass<SuperSneakers>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (OnSupersneakersTimeActiveChange != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
						}
					}
					object obj2 = this + 12;
					obj2 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				superSneakers.timeActiveInARow = 0f;
				CharacterRendering characterRendering2 = superSneakers.characterRendering;
				CharacterModel characterModel2 = characterRendering2._characterModel;
				characterModel2._meshSuperSneaker.shadowCastingMode = ShadowCastingMode.Off;
				superSneakers.isActive = false;
				VariableBool longMagnetSuction = superSneakers.longMagnet.LongMagnetSuction;
				if (longMagnetSuction == null)
				{
					superSneakers.longMagnet._002Ector();
				}
				ActivePowerup powerup2 = superSneakers._powerup;
				if (!(powerup2.timeLeft > 0f))
				{
					nint num3 = (nint)typeof(So);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v41 (Il2CppClass<So>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num4 = (nint)typeof(So);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v49 (Il2CppClass<So>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					HoverboardBundle hoverboardBundle = ((CharacterModel)(object)So.Instance).AddHoverboard((string)(object)superSneakers.powerDownSound, false);
				}
				Character character3 = superSneakers.character;
				character3._isJumpingHigher = false;
				if (superSneakers.m_SuperSneakerOnStop != null)
				{
					superSneakers.m_SuperSneakerOnStop();
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CBegin_003Ed__23(int _003C_003E1__state)
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SuperSneakers+<Begin>d__23)+34]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SuperSneakers+<Begin>d__23)+34]");
			object obj3;
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SuperSneakers+<Begin>d__23)+34]");
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

	public bool isActive;

	private Character character;

	private CharacterRendering characterRendering;

	public AudioClipInfo powerDownSound;

	private LongMagnet longMagnet;

	public float timeActiveInARow;

	private OnSwitchToSuperSneakersDelegate m_OnSwitchToSuperSneakers;

	private SuperSneakerOnStopDelegate m_SuperSneakerOnStop;

	public static Action OnSupersneakersTimeActiveChange;

	private static SuperSneakers instance;

	public override bool ShouldPauseInAlternateRoutes
	{
		get
		{
			//IL_0023: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			bool flag = default;
			object obj = (flag ? 1 : 0) + 16;
			obj = this;
			return flag;
		}
	}

	public override bool ShouldPauseInJetpack
	{
		get
		{
			//IL_0023: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			bool flag = default;
			object obj = (flag ? 1 : 0) + 16;
			obj = this;
			return flag;
		}
	}

	public unsafe static SuperSneakers Instance
	{
		get
		{
			//IL_01a4: Expected I, but got Obj
			//IL_01ba: Expected Obj, but got I
			//IL_02da: Unknown result type (might be due to invalid IL or missing references)
			//IL_02df: Expected I, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_01f2: Expected I, but got Obj
			//IL_020d: Expected I, but got Obj
			//IL_0223: Expected Obj, but got I
			//IL_0265: Expected I, but got Obj
			//IL_027b: Expected Obj, but got I
			//IL_0298: Expected I, but got Obj
			//IL_00a1: Expected I, but got Obj
			//IL_02bc: Expected Obj, but got I
			//IL_00ee: Expected I, but got Obj
			//IL_013b: Expected I, but got Obj
			//IL_016b: Expected I, but got Obj
			//IL_0191: Expected I, but got Obj
			nint num = (nint)typeof(PlusMultiplier);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<PlusMultiplier>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(PlusMultiplier);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v54 (Il2CppClass<PlusMultiplier>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = default;
			nint num3 = (nint)(obj2 + 4);
			bool flag = (object)PlusMultiplier.instance == null;
			bool flag2 = !flag;
			SuperSneakers result = (SuperSneakers)(object)PlusMultiplier.instance;
			if (!flag2)
			{
				nint num4 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v25 (Il2CppClass<System.Type>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num5 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v50 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = typeof(PlusMultiplier);
				((IntPtr*)num3)->m_value = (void*)(nint)obj2;
				Type type = Type.internal_from_handle((IntPtr)num3);
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num7 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = ((UnityEngine.Object)(object)type).ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
				nint num8 = (nint)typeof(PlusMultiplier);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v36 (Il2CppClass<PlusMultiplier>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				bool flag3 = obj5 == null;
				nint num9 = (nint)typeof(PlusMultiplier);
				if (!flag3)
				{
					nint num10 = (nint)typeof(PlusMultiplier);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v44 (Il2CppClass<PlusMultiplier>)+74]");
					bool flag4 = (nint)0 == 0;
					bool flag5 = !flag4;
					num9 = (nint)typeof(PlusMultiplier);
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num9 = (nint)typeof(PlusMultiplier);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ L0_v8 (Il2CppClass<PlusMultiplier>)+5C]");
				object obj6 = (nint)0 + (nint)4;
				SuperSneakers superSneakers = default;
				obj6 = superSneakers;
				result = superSneakers;
			}
			return result;
		}
	}

	public event OnSwitchToSuperSneakersDelegate OnSwitchToSuperSneakers
	{
		add
		{
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected Obj, but got Unknown
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			if (value != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num = 0;
				_ = 0;
				Action<Collider> action = default;
				object obj = action + 16;
				obj = this;
				((CollisionNotifier)base.current).TriggerEnter -= action;
				Collider component = ((Component)base.current).GetComponent<Collider>();
				component.isTrigger = true;
			}
			else
			{
				Collider component2 = ((Component)base.current).GetComponent<Collider>();
				component2.isTrigger = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num2 = 0;
				_ = 0;
				Action<Collider> action2 = default;
				object obj2 = action2 + 16;
				obj2 = this;
				((CollisionNotifier)base.current).TriggerExit += action2;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnSwitchToSuperSneakers;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 56;
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

	public event SuperSneakerOnStopDelegate SuperSneakerOnStop
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnSwitchToSuperSneakers;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 56;
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
			Delegate obj = this.m_SuperSneakerOnStop;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 60;
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

	public void Awake()
	{
		base.Prepare();
	}

	public override void Pause()
	{
		//IL_0116: Expected I, but got Obj
		//IL_012c: Expected Obj, but got I
		//IL_0149: Expected I, but got Obj
		//IL_01e7: Expected Obj, but got I
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected Obj, but got Unknown
		//IL_0224: Expected I, but got Obj
		//IL_023a: Expected Obj, but got I
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_0181: Expected I, but got Obj
		//IL_0197: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_007c: Expected I, but got Obj
		//IL_00c9: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		nint num = (nint)typeof(SuperSneakers);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SuperSneakers>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(SuperSneakers);
		if (!flag)
		{
			nint num3 = (nint)typeof(SuperSneakers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v37 (Il2CppClass<SuperSneakers>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(SuperSneakers);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(SuperSneakers);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ L1_v2 (Il2CppClass<SuperSneakers>)+5C]");
		object obj2 = (nint)0 + (nint)4;
		obj2 = this;
		object obj3 = this + 48;
		string text = tag;
		LongMagnet component = ((GameObject)(object)text).GetComponent<LongMagnet>();
		obj3 = component;
		nint num4 = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v16 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v33 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = this + 36;
		CharacterRendering characterRendering = CharacterRendering.Instance;
		obj5 = characterRendering;
		nint num6 = (nint)typeof(CharacterRendering);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v23 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num7 = (nint)typeof(CharacterRendering);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v29 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = this + 40;
		CharacterCamera characterCamera = CharacterCamera.Instance;
		obj7 = characterCamera;
	}

	public override void Resume()
	{
		base._paused = true;
		if (_powerup != null)
		{
			ActivePowerup powerup = _powerup;
			powerup.Paused = true;
		}
		Character character = this.character;
		character._isJumpingHigher = false;
		isActive = false;
	}

	public override void ExpireSoon()
	{
		base._paused = false;
		if (_powerup != null)
		{
			ActivePowerup powerup = _powerup;
			powerup.Paused = false;
		}
		Character character = this.character;
		character._isJumpingHigher = true;
		isActive = true;
	}

	public void StopHack()
	{
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		ActivePowerup powerup = _powerup;
		nint num = (nint)typeof(CharacterModifierCollection);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<CharacterModifierCollection>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterModifierCollection);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<CharacterModifierCollection>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		powerup.timeLeft = CharacterModifierCollection.TIME_LEFT_FOR_EXPIRE_SOON;
	}

	public override void Prepare()
	{
		isActive = false;
		CharacterRendering characterRendering = this.characterRendering;
		CharacterModel characterModel = characterRendering._characterModel;
		characterModel._meshSuperSneaker.shadowCastingMode = ShadowCastingMode.Off;
	}

	public override IEnumerator Begin()
	{
		//IL_0006: Expected Obj, but got I4
		return (IEnumerator)1;
	}

	public SuperSneakers()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_003a: Expected Obj, but got I4
		//IL_004b: Expected Obj, but got I4
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		((GameStats)(object)privacyPolicyUrl).KeyPickupsCollectedIncrement();
		object obj = this + 20;
		string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
		bool flag = Globals.TryAddAnimationEvent((Animation)(object)privacyPolicyUrl2, (string)7, null);
		obj = flag;
	}
}

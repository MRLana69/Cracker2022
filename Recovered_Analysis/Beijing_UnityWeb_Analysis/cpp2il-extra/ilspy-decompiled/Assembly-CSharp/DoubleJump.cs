using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using SYBO.Subway.Characters;
using UnityEngine;
using UnityEngine.Rendering;

public class DoubleJump : CharacterModifier
{
	private sealed class _003CBegin_003Ed__8(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public DoubleJump _003C_003E4__this;

		private float _003Cduration_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0062: Unknown result type (might be due to invalid IL or missing references)
				//IL_0067: Expected Obj, but got Unknown
				//IL_0099: Expected Obj, but got I4
				//IL_0099: Expected Obj, but got I4
				//IL_00aa: Expected Obj, but got I4
				//IL_01d1: Expected I, but got Obj
				//IL_01e7: Expected Obj, but got I
				//IL_019c: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a1: Expected Obj, but got Unknown
				//IL_01aa: Expected Obj, but got I4
				//IL_01be: Expected Obj, but got I4
				//IL_0212: Expected I, but got Obj
				DoubleJump doubleJump = _003C_003E4__this;
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
					string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
					((GameStats)(object)privacyPolicyUrl).KeyPickupsCollectedIncrement();
					((CharacterModifier)doubleJump)._paused = false;
					object obj = doubleJump + 20;
					string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
					bool flag = ((CharacterModifier)doubleJump).TriggeredByMysteryPowerup__BackingField;
					bool flag2 = Globals.TryAddAnimationEvent((Animation)(object)privacyPolicyUrl2, (string)27, (AnimationEvent)flag);
					obj = flag2;
					ActivePowerup powerup = doubleJump._powerup;
					_003Cduration_003E5__2 = powerup.timeLeft;
					doubleJump.StopDoubleJump();
					doubleJump.stop = StopSignal.DONT_STOP;
				}
				ActivePowerup powerup2 = doubleJump._powerup;
				if (!(powerup2.timeLeft < 0f) && doubleJump.stop == StopSignal.DONT_STOP)
				{
					ActivePowerup powerup3 = doubleJump._powerup;
					float ratio = powerup3.timeLeft / _003Cduration_003E5__2;
					doubleJump.ratio = ratio;
					object obj2 = this + 12;
					obj2 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				doubleJump._002Ector();
				ActivePowerup powerup4 = doubleJump._powerup;
				if (!(powerup4.timeLeft > 0f))
				{
					nint num = (nint)typeof(So);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v24 (Il2CppClass<So>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num2 = (nint)typeof(So);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v32 (Il2CppClass<So>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					HoverboardBundle hoverboardBundle = ((CharacterModel)(object)So.Instance).AddHoverboard((string)(object)doubleJump.powerDownSound, false);
				}
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

	public float ratio;

	public AudioClipInfo powerDownSound;

	public static bool doubleJumpEnabled;

	private static DoubleJump instance;

	private Character character;

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

	public unsafe static DoubleJump Instance
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
			nint num = (nint)typeof(DoubleCoins);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<DoubleCoins>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(DoubleCoins);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v54 (Il2CppClass<DoubleCoins>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = default;
			nint num3 = (nint)(obj2 + 4);
			bool flag = (object)DoubleCoins.instance == null;
			bool flag2 = !flag;
			DoubleJump result = (DoubleJump)(object)DoubleCoins.instance;
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
				obj2 = typeof(DoubleCoins);
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
				nint num8 = (nint)typeof(DoubleCoins);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v36 (Il2CppClass<DoubleCoins>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				bool flag3 = obj5 == null;
				nint num9 = (nint)typeof(DoubleCoins);
				if (!flag3)
				{
					nint num10 = (nint)typeof(DoubleCoins);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v44 (Il2CppClass<DoubleCoins>)+74]");
					bool flag4 = (nint)0 == 0;
					bool flag5 = !flag4;
					num9 = (nint)typeof(DoubleCoins);
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num9 = (nint)typeof(DoubleCoins);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ L0_v8 (Il2CppClass<DoubleCoins>)+5C]");
				object obj6 = (nint)0 + (nint)8;
				DoubleJump doubleJump = default;
				obj6 = doubleJump;
				result = doubleJump;
			}
			return result;
		}
	}

	private void Awake()
	{
		base.Prepare();
	}

	public override IEnumerator Begin()
	{
		//IL_0006: Expected Obj, but got I4
		return (IEnumerator)1;
	}

	public override void ExpireSoon()
	{
		//IL_00c9: Expected I, but got Obj
		//IL_00df: Expected Obj, but got I
		//IL_00fc: Expected I, but got Obj
		//IL_0120: Expected Obj, but got I
		//IL_0133: Expected I, but got Obj
		//IL_0149: Expected Obj, but got I
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_007c: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		nint num = (nint)typeof(DoubleJump);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DoubleJump>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(DoubleJump);
		if (!flag)
		{
			nint num3 = (nint)typeof(DoubleJump);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v24 (Il2CppClass<DoubleJump>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(DoubleJump);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(DoubleJump);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ L1_v2 (Il2CppClass<DoubleJump>)+5C]");
		object obj2 = (nint)0 + (nint)4;
		obj2 = this;
		nint num4 = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v14 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v20 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = this + 40;
		CharacterRendering characterRendering = CharacterRendering.Instance;
		obj4 = characterRendering;
	}

	public override void Reset()
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

	public override void Pause()
	{
		base.ExpireSoon();
		this._002Ector();
	}

	public override void Resume()
	{
		//IL_019e: Expected I, but got Obj
		//IL_01b4: Expected Obj, but got I
		//IL_015d: Expected I, but got Obj
		//IL_0173: Expected Obj, but got I
		//IL_0030: Expected I, but got Obj
		//IL_007d: Expected I, but got Obj
		base._paused = true;
		if (_powerup != null)
		{
			ActivePowerup powerup = _powerup;
			powerup.Paused = true;
		}
		nint num = (nint)typeof(DoubleJump);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v10 (Il2CppClass<DoubleJump>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DoubleJump);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v28 (Il2CppClass<DoubleJump>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		doubleJumpEnabled = false;
		Character character = this.character;
		character._isDoubleJumping = false;
		Character character2 = this.character;
		CharacterModel characterModel = character2._characterModel;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)characterModel._doubleJumpers).FindKernel((string)null) != 0)
		{
			Character character3 = this.character;
			CharacterModel characterModel2 = character3._characterModel;
			characterModel2._doubleJumpers.shadowCastingMode = ShadowCastingMode.Off;
		}
	}

	public void StartDoubleJump()
	{
		//IL_019e: Expected I, but got Obj
		//IL_01b4: Expected Obj, but got I
		//IL_015d: Expected I, but got Obj
		//IL_0173: Expected Obj, but got I
		//IL_0030: Expected I, but got Obj
		//IL_007d: Expected I, but got Obj
		base._paused = false;
		if (_powerup != null)
		{
			ActivePowerup powerup = _powerup;
			powerup.Paused = false;
		}
		nint num = (nint)typeof(DoubleJump);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v10 (Il2CppClass<DoubleJump>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DoubleJump);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v28 (Il2CppClass<DoubleJump>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		doubleJumpEnabled = true;
		Character character = this.character;
		character._isDoubleJumping = true;
		Character character2 = this.character;
		CharacterModel characterModel = character2._characterModel;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)characterModel._doubleJumpers).FindKernel((string)null) != 0)
		{
			Character character3 = this.character;
			CharacterModel characterModel2 = character3._characterModel;
			characterModel2._doubleJumpers.shadowCastingMode = ShadowCastingMode.On;
		}
	}

	public void StopDoubleJump()
	{
		//IL_01c4: Expected I, but got Obj
		//IL_01da: Expected Obj, but got I
		//IL_0349: Expected I, but got Obj
		//IL_035f: Expected Obj, but got I
		//IL_0218: Expected I, but got Obj
		//IL_022e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0277: Expected I4, but got Obj
		//IL_0277: Expected Obj, but got I
		//IL_0285: Expected I, but got Obj
		//IL_029b: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_02ff: Expected I, but got Obj
		//IL_0315: Expected Obj, but got I
		//IL_00ad: Expected I, but got Obj
		//IL_00fa: Expected I, but got Obj
		//IL_0147: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v38 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		nint num3 = (nint)typeof(Upgrades);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v4 (Il2CppClass<Info.Upgrades>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Upgrades);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v29 (Il2CppClass<Info.Upgrades>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Upgrade upgrade = Upgrades.upgrades.get_Item(UpgradeType.doubleJump);
		nint num5 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S2_v4 (Il2CppClass<Strings>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S2_v14 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault(upgrade.name);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+E0]");
		((UIModelController)0).ActivateCelebrationBoardWithStripes((Boards.BoardId)text, UIModelController.ModelScreen.GameOver);
		nint num7 = (nint)typeof(DoubleJump);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14 (Il2CppClass<DoubleJump>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(DoubleJump);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v32 (Il2CppClass<DoubleJump>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		doubleJumpEnabled = true;
		Character character = this.character;
		character._isDoubleJumping = true;
		Character character2 = this.character;
		CharacterModel characterModel = character2._characterModel;
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)characterModel._doubleJumpers).FindKernel((string)null) != 0)
		{
			Character character3 = this.character;
			CharacterModel characterModel2 = character3._characterModel;
			characterModel2._doubleJumpers.shadowCastingMode = ShadowCastingMode.On;
		}
	}

	public DoubleJump()
	{
		//IL_00e8: Expected I, but got Obj
		//IL_00fe: Expected Obj, but got I
		//IL_0162: Expected I, but got Obj
		//IL_0178: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		base._paused = false;
		nint num = (nint)typeof(DoubleJump);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<DoubleJump>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DoubleJump);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v25 (Il2CppClass<DoubleJump>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		doubleJumpEnabled = false;
		Character character = this.character;
		character._isDoubleJumping = false;
		Character character2 = this.character;
		CharacterModel characterModel = character2._characterModel;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)characterModel._doubleJumpers).FindKernel((string)null) != 0)
		{
			Character character3 = this.character;
			CharacterModel characterModel2 = character3._characterModel;
			characterModel2._doubleJumpers.shadowCastingMode = ShadowCastingMode.Off;
		}
	}
}

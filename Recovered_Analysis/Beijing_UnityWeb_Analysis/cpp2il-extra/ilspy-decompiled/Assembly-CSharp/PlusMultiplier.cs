using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using UI.Screens;
using UnityEngine;

public class PlusMultiplier : CharacterModifier
{
	private sealed class _003CBegin_003Ed__5(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public PlusMultiplier _003C_003E4__this;

		private float _003Cduration_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0070: Unknown result type (might be due to invalid IL or missing references)
				//IL_0075: Expected Obj, but got Unknown
				//IL_00a7: Expected Obj, but got I4
				//IL_00a7: Expected Obj, but got I4
				//IL_00b8: Expected Obj, but got I4
				//IL_01d1: Expected I, but got Obj
				//IL_01e7: Expected Obj, but got I
				//IL_019c: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a1: Expected Obj, but got Unknown
				//IL_01aa: Expected Obj, but got I4
				//IL_01be: Expected Obj, but got I4
				//IL_0212: Expected I, but got Obj
				PlusMultiplier plusMultiplier = _003C_003E4__this;
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
					((CharacterModifier)plusMultiplier)._paused = false;
					plusMultiplier.stop = StopSignal.DONT_STOP;
					object obj = plusMultiplier + 20;
					string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
					bool flag = ((CharacterModifier)plusMultiplier).TriggeredByMysteryPowerup__BackingField;
					bool flag2 = Globals.TryAddAnimationEvent((Animation)(object)privacyPolicyUrl2, (string)28, (AnimationEvent)flag);
					obj = flag2;
					ActivePowerup powerup = plusMultiplier._powerup;
					_003Cduration_003E5__2 = powerup.timeLeft;
					plusMultiplier.StopPlusMultiplier();
				}
				ActivePowerup powerup2 = plusMultiplier._powerup;
				if (!(powerup2.timeLeft < 0f) && plusMultiplier.stop == StopSignal.DONT_STOP)
				{
					ActivePowerup powerup3 = plusMultiplier._powerup;
					float ratio = powerup3.timeLeft / _003Cduration_003E5__2;
					plusMultiplier.ratio = ratio;
					object obj2 = this + 12;
					obj2 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				plusMultiplier.ResetLabelColour();
				ActivePowerup powerup4 = plusMultiplier._powerup;
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
					HoverboardBundle hoverboardBundle = ((CharacterModel)(object)So.Instance).AddHoverboard((string)(object)plusMultiplier.powerDownSound, false);
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

	public static bool plusMultiplierEnabled;

	private static PlusMultiplier instance;

	public unsafe static PlusMultiplier Instance
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
			nint num = (nint)typeof(DoubleJump);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<DoubleJump>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(DoubleJump);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v54 (Il2CppClass<DoubleJump>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = default;
			nint num3 = (nint)(obj2 + 4);
			bool flag = (object)DoubleJump.instance == null;
			bool flag2 = !flag;
			PlusMultiplier result = (PlusMultiplier)(object)DoubleJump.instance;
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
				obj2 = typeof(DoubleJump);
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
				nint num8 = (nint)typeof(DoubleJump);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v36 (Il2CppClass<DoubleJump>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				bool flag3 = obj5 == null;
				nint num9 = (nint)typeof(DoubleJump);
				if (!flag3)
				{
					nint num10 = (nint)typeof(DoubleJump);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v44 (Il2CppClass<DoubleJump>)+74]");
					bool flag4 = (nint)0 == 0;
					bool flag5 = !flag4;
					num9 = (nint)typeof(DoubleJump);
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num9 = (nint)typeof(DoubleJump);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ L0_v8 (Il2CppClass<DoubleJump>)+5C]");
				object obj6 = (nint)0 + (nint)4;
				PlusMultiplier plusMultiplier = default;
				obj6 = plusMultiplier;
				result = plusMultiplier;
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
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_00d3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		nint num = (nint)typeof(PlusMultiplier);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<PlusMultiplier>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(PlusMultiplier);
		if (!flag)
		{
			nint num3 = (nint)typeof(PlusMultiplier);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<PlusMultiplier>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(PlusMultiplier);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(PlusMultiplier);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ L1_v2 (Il2CppClass<PlusMultiplier>)+5C]");
		object obj2 = (nint)0 + (nint)4;
		obj2 = this;
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

	public void StartPlusMultiplier()
	{
		//IL_0066: Expected I, but got Obj
		//IL_007c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		base.ExpireSoon();
		nint num = (nint)typeof(PlusMultiplier);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<PlusMultiplier>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PlusMultiplier);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v13 (Il2CppClass<PlusMultiplier>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		plusMultiplierEnabled = false;
	}

	public void StopPlusMultiplier()
	{
		//IL_0147: Expected I, but got Obj
		//IL_015d: Expected Obj, but got I
		//IL_0263: Expected I, but got Obj
		//IL_0279: Expected Obj, but got I
		//IL_019b: Expected I, but got Obj
		//IL_01b1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01fa: Expected I4, but got Obj
		//IL_01fa: Expected Obj, but got I
		//IL_0208: Expected I, but got Obj
		//IL_021e: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00fa: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<UIScreenController>)+74]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v17 (Il2CppClass<Info.Upgrades>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Upgrade upgrade = Upgrades.upgrades.get_Item(UpgradeType.plusMultiplier);
		nint num5 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S2_v4 (Il2CppClass<Strings>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S2_v10 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault(upgrade.name);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+E0]");
		((UIModelController)0).ActivateCelebrationBoardWithStripes((Boards.BoardId)text, UIModelController.ModelScreen.GameOver);
		nint num7 = (nint)typeof(PlusMultiplier);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14 (Il2CppClass<PlusMultiplier>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(PlusMultiplier);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v21 (Il2CppClass<PlusMultiplier>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		plusMultiplierEnabled = true;
		((PlusMultiplier)null)._002Ector();
	}

	private void ResetLabelColour()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(PlusMultiplier);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<PlusMultiplier>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PlusMultiplier);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<PlusMultiplier>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		plusMultiplierEnabled = false;
		((PlusMultiplier)null).ChangeTheMultiplier();
		((PlusMultiplier)null)._002Ector();
	}

	private void ChangeTheMultiplier()
	{
		//IL_0107: Expected I, but got Obj
		//IL_011d: Expected Obj, but got I
		//IL_0177: Expected Obj, but got I4
		//IL_0188: Expected Obj, but got I4
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00ab: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		IEnumerator screenName = ((UIScreenController)flag).DelayHideMainCamera();
		UIScreen uIScreen = ((UIScreenController)flag)._ActivateScreen((string)(object)screenName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ComputeShader computeShader = default;
		if (computeShader.FindKernel(null) != 0)
		{
			((IngameScreen)(object)computeShader).OnHeadstartDeactivated();
		}
	}

	public PlusMultiplier()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(ScoreMultiplierInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.ScoreMultiplierInfo>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num2 = (nint)typeof(ScoreMultiplierInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Info.ScoreMultiplierInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ScoreMultiplierInfo._002Ecctor();
	}
}

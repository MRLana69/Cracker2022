using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Managers;
using Info;
using SYBO.Subway;
using UnityEngine;

public class DoubleCoins : CharacterModifier
{
	private sealed class _003CBegin_003Ed__6(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public DoubleCoins _003C_003E4__this;

		private float _003Cduration_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0042: Expected I, but got Obj
				//IL_0058: Expected Obj, but got I
				//IL_0306: Unknown result type (might be due to invalid IL or missing references)
				//IL_030b: Expected Obj, but got Unknown
				//IL_00eb: Expected Obj, but got I4
				//IL_00eb: Expected Obj, but got I4
				//IL_00f7: Expected Obj, but got I4
				//IL_0083: Expected I, but got Obj
				//IL_0212: Expected I, but got Obj
				//IL_0228: Expected Obj, but got I
				//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e2: Expected Obj, but got Unknown
				//IL_01eb: Expected Obj, but got I4
				//IL_01ff: Expected Obj, but got I4
				//IL_0253: Expected I, but got Obj
				DoubleCoins doubleCoins = _003C_003E4__this;
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
					nint num = (nint)typeof(DoubleCoins);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v48 (Il2CppClass<DoubleCoins>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num2 = (nint)typeof(DoubleCoins);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v62 (Il2CppClass<DoubleCoins>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					numberOfAnimationBlinks = 0;
					string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
					((GameStats)(object)privacyPolicyUrl).KeyPickupsCollectedIncrement();
					((CharacterModifier)doubleCoins)._paused = false;
					doubleCoins.stop = StopSignal.DONT_STOP;
					object obj2 = doubleCoins + 20;
					string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
					bool flag = ((CharacterModifier)doubleCoins).TriggeredByMysteryPowerup__BackingField;
					bool flag2 = Globals.TryAddAnimationEvent((Animation)(object)privacyPolicyUrl2, (string)26, (AnimationEvent)flag);
					obj2 = flag2;
					ActivePowerup powerup = doubleCoins._powerup;
					_003Cduration_003E5__2 = powerup.timeLeft;
					((DoubleCoins)null).StopDoubleCoins();
				}
				ActivePowerup powerup2 = doubleCoins._powerup;
				if (!(powerup2.timeLeft < 0f) && doubleCoins.stop == StopSignal.DONT_STOP)
				{
					ActivePowerup powerup3 = doubleCoins._powerup;
					float ratio = powerup3.timeLeft / _003Cduration_003E5__2;
					doubleCoins.ratio = ratio;
					object obj3 = this + 12;
					obj3 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				((DoubleCoins)null)._002Ector();
				ActivePowerup powerup4 = doubleCoins._powerup;
				if (!(powerup4.timeLeft > 0f))
				{
					nint num3 = (nint)typeof(So);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v24 (Il2CppClass<So>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num4 = (nint)typeof(So);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v32 (Il2CppClass<So>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					HoverboardBundle hoverboardBundle = ((CharacterModel)(object)So.Instance).AddHoverboard((string)(object)doubleCoins.powerDownSound, false);
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

	public static bool HasDoubleCoinsModifier;

	public static int numberOfAnimationBlinks;

	private static DoubleCoins instance;

	public static DoubleCoins Instance
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_08da: Unknown result type (might be due to invalid IL or missing references)
			//IL_08df: Expected Obj, but got Unknown
			//IL_08e8: Expected Obj, but got I4
			//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_08fc: Expected I, but got Unknown
			//IL_0904: Expected I, but got Obj
			//IL_092b: Expected I, but got Obj
			//IL_0941: Expected Obj, but got I
			//IL_0021: Expected I, but got Obj
			//IL_00cf: Expected I, but got Obj
			//IL_00e5: Expected Obj, but got I
			//IL_009f: Expected Obj, but got I4
			//IL_037b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0380: Expected Obj, but got Unknown
			//IL_0110: Expected I, but got Obj
			//IL_0244: Expected I, but got Obj
			//IL_025a: Expected Obj, but got I
			//IL_0187: Expected I, but got Obj
			//IL_019d: Expected Obj, but got I
			//IL_0285: Expected I, but got Obj
			//IL_01c8: Expected I, but got Obj
			//IL_0827: Expected Obj, but got I
			//IL_082f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0834: Expected Obj, but got Unknown
			//IL_0862: Expected Obj, but got I
			//IL_0893: Unknown result type (might be due to invalid IL or missing references)
			//IL_0898: Expected Obj, but got Unknown
			//IL_0765: Expected Obj, but got I
			//IL_076e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0773: Expected Obj, but got Unknown
			//IL_0791: Unknown result type (might be due to invalid IL or missing references)
			//IL_0796: Expected Obj, but got Unknown
			//IL_079f: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 + 48;
			object obj3 = obj2 + 24;
			obj3 = 0;
			_ = 0;
			nint num = (nint)(obj2 + 16);
			num = (nint)obj;
			_ = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<Boards.BoardId> list = default;
			list._002Ector();
			nint num2 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v21 (Il2CppClass<Info.Boards>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num3 = (nint)typeof(Boards);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v160 (Il2CppClass<Info.Boards>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj5 = default;
			object obj7 = default;
			object obj9 = default;
			object obj11 = default;
			object obj12 = default;
			object obj13 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj5 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num4 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v86 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num5 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v150 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj7 == null)
				{
					nint num6 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ S0_v134 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num7 = (nint)typeof(BoardManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ S0_v141 (Il2CppClass<Data.Managers.BoardManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj9 == null)
					{
						continue;
					}
				}
				nint num8 = (nint)typeof(MysteryPowerup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S0_v99 (Il2CppClass<MysteryPowerup>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num9 = (nint)typeof(MysteryPowerup);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ S0_v123 (Il2CppClass<MysteryPowerup>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
					if (obj12 != obj13)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					}
				}
			}
			object obj14 = 42;
			object obj15 = obj14 - 11;
			if ((nint)obj14 != 11 && (nint)obj15 != 1)
			{
				if ((nint)obj15 != 2 && (nint)obj15 != 3)
				{
					if ((nint)obj15 == 4)
					{
						goto IL_07a4;
					}
					if ((nint)obj15 != 5 && (nint)obj15 != 6 && (nint)obj15 != 7)
					{
						if ((nint)obj15 == 8)
						{
							goto IL_07a4;
						}
						if ((nint)obj15 != 9 && (nint)obj15 != 10)
						{
							if ((nint)obj15 == 11)
							{
								goto IL_07a4;
							}
							if ((nint)obj15 != 12 && (nint)obj15 != 13 && (nint)obj15 != 14 && (nint)obj15 != 15)
							{
								if ((nint)obj15 == 16)
								{
									goto IL_07a4;
								}
								if ((nint)obj15 != 17 && (nint)obj15 != 18)
								{
									if ((nint)obj15 == 19)
									{
										goto IL_07a4;
									}
									if ((nint)obj15 != 20 && (nint)obj15 != 21)
									{
										if ((nint)obj15 == 22)
										{
											goto IL_07a4;
										}
										if ((nint)obj15 != 23 && (nint)obj15 != 24 && (nint)obj15 != 25 && (nint)obj15 != 26)
										{
											if ((nint)obj15 == 27 || (nint)obj15 == 28)
											{
												goto IL_07a4;
											}
											if ((nint)obj15 != 29 && (nint)obj15 != 30 && (nint)obj15 == 31)
											{
												object obj16 = num + 4;
												object obj17 = obj16 + 1;
												obj16 = obj17;
												object obj18 = obj17 << 2;
												object obj19 = num + obj18;
												obj19 = 96;
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_09cd;
			}
			goto IL_07a4;
			IL_09f2:
			return (DoubleCoins)(object)list;
			IL_09cd:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Il2CppMethodInfo)+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Il2CppMethodInfo)+4]");
				object obj20 = (nint)0 << 2;
				object obj21 = num + obj20;
				if ((nint)obj21 == 96)
				{
					object obj22 = num + 4;
					if ((nint)obj22 > -1)
					{
						object obj23 = obj22 + -1;
						obj22 = obj23;
					}
					goto IL_09f2;
				}
			}
			object obj24 = default;
			if (obj24 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_09f2;
			IL_07a4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj25 = default;
			object obj26 = default;
			if (obj25 == obj26)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			}
			goto IL_09cd;
		}
	}

	public void Awake()
	{
	}

	public override IEnumerator Begin()
	{
		return (IEnumerator)powerDownSound;
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
		nint num = (nint)typeof(DoubleCoins);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DoubleCoins>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(DoubleCoins);
		if (!flag)
		{
			nint num3 = (nint)typeof(DoubleCoins);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<DoubleCoins>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(DoubleCoins);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(DoubleCoins);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ L1_v2 (Il2CppClass<DoubleCoins>)+5C]");
		object obj2 = (nint)0 + (nint)8;
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

	public void StartDoubleCoins()
	{
		base.ExpireSoon();
		((DoubleCoins)null)._002Ector();
	}

	public void StopDoubleCoins()
	{
		//IL_0147: Expected I, but got Obj
		//IL_015d: Expected Obj, but got I
		//IL_025d: Expected I, but got Obj
		//IL_0273: Expected Obj, but got I
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v26 (Il2CppClass<UIScreenController>)+74]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v16 (Il2CppClass<Info.Upgrades>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Upgrade upgrade = Upgrades.upgrades.get_Item(UpgradeType.doubleCoinsMysteryPowerup);
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
		nint num7 = (nint)typeof(DoubleCoins);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14 (Il2CppClass<DoubleCoins>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(DoubleCoins);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v20 (Il2CppClass<DoubleCoins>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HasDoubleCoinsModifier = true;
	}

	public DoubleCoins()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DoubleCoins);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DoubleCoins>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DoubleCoins);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<DoubleCoins>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HasDoubleCoinsModifier = false;
		numberOfAnimationBlinks = 0;
	}

	static DoubleCoins()
	{
		//IL_01a1: Expected Obj, but got I
		//IL_01b1: Expected Obj, but got I
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_01ed: Expected I, but got Obj
		//IL_0203: Expected Obj, but got I
		//IL_0239: Expected Obj, but got I
		//IL_024f: Expected Obj, but got I
		//IL_025f: Expected Obj, but got I
		//IL_026f: Expected Obj, but got I
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected Obj, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected Obj, but got Unknown
		//IL_02ae: Expected Obj, but got I
		//IL_02c4: Expected Obj, but got I
		//IL_02d4: Expected Obj, but got I
		//IL_02e4: Expected Obj, but got I
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected Obj, but got Unknown
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_0062: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I
		//IL_0098: Expected Obj, but got I
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00d7: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I
		//IL_010d: Expected Obj, but got I
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0162: Expected I, but got Obj
		//IL_0178: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		nint num2 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v9 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num3 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v31 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S2_v3 (System.Boolean)+8C]");
		object obj7 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S4_v7+60]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S4_v8+48]");
		object obj10 = 0;
		object obj11 = obj10 & 0x7FF;
		object obj12 = obj11 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v62 @ S5_v6 (should have been resolved before IL gen)");
		bool isInstantiated2 = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S2_v7 (System.Boolean)+8C]");
		object obj13 = 0;
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S4_v12+60]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S4_v13+48]");
		object obj16 = 0;
		object obj17 = obj16 & 0x7FF;
		object obj18 = obj17 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v82 @ S5_v10 (should have been resolved before IL gen)");
		bool isInstantiated3 = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S2_v11 (System.Boolean)+8C]");
		object obj19 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S4_v16 (Il2CppMethodInfo)+C]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S4_v17+60]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S4_v18+48]");
		object obj22 = 0;
		object obj23 = obj22 & 0x7FF;
		object obj24 = obj23 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v102 @ S5_v14 (should have been resolved before IL gen)");
		bool isInstantiated4 = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S2_v15 (System.Boolean)+8C]");
		object obj25 = 0;
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S4_v21 (Il2CppMethodInfo)+C]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S4_v22+60]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S4_v23+48]");
		object obj28 = 0;
		object obj29 = obj28 & 0x7FF;
		object obj30 = obj29 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v122 @ S5_v18 (should have been resolved before IL gen)");
		Dictionary<UpgradeType, CharacterModifier> mysteryPowerupCharacterModifiers = default;
		MysteryPowerup.mysteryPowerupCharacterModifiers = mysteryPowerupCharacterModifiers;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Boards.BoardId> list = default;
		list._002Ector();
		nint num8 = (nint)typeof(MysteryPowerup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v28 (Il2CppClass<MysteryPowerup>)+5C]");
		object obj31 = (nint)0 + (nint)4;
		obj31 = list;
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using UnityEngine;

public class DoubleScoreMultiplier : CharacterModifier
{
	private sealed class _003CBegin_003Ed__6(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public DoubleScoreMultiplier _003C_003E4__this;

		private float _003Cduration_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0070: Unknown result type (might be due to invalid IL or missing references)
				//IL_0075: Expected Obj, but got Unknown
				//IL_008d: Expected Obj, but got I4
				//IL_009e: Expected Obj, but got I4
				//IL_00c4: Expected Obj, but got I4
				//IL_01b5: Expected I, but got Obj
				//IL_01cb: Expected Obj, but got I
				//IL_0180: Unknown result type (might be due to invalid IL or missing references)
				//IL_0185: Expected Obj, but got Unknown
				//IL_018e: Expected Obj, but got I4
				//IL_01a2: Expected Obj, but got I4
				//IL_01f6: Expected I, but got Obj
				DoubleScoreMultiplier doubleScoreMultiplier = _003C_003E4__this;
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
					((CharacterModifier)doubleScoreMultiplier)._paused = false;
					doubleScoreMultiplier.stop = StopSignal.DONT_STOP;
					object obj = doubleScoreMultiplier + 20;
					string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
					bool flag = Globals.TryAddAnimationEvent((Animation)(object)privacyPolicyUrl2, (string)10, null);
					obj = flag;
					ActivePowerup powerup = doubleScoreMultiplier._powerup;
					_003Cduration_003E5__2 = powerup.timeLeft;
					((DoubleScoreMultiplier)1).Reset();
				}
				ActivePowerup powerup2 = doubleScoreMultiplier._powerup;
				if (powerup2.timeLeft > 0f && doubleScoreMultiplier.stop == StopSignal.DONT_STOP)
				{
					ActivePowerup powerup3 = doubleScoreMultiplier._powerup;
					float ratio = powerup3.timeLeft / _003Cduration_003E5__2;
					doubleScoreMultiplier.ratio = ratio;
					object obj2 = this + 12;
					obj2 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				((DoubleScoreMultiplier)null).Reset();
				ActivePowerup powerup4 = doubleScoreMultiplier._powerup;
				if (!(powerup4.timeLeft > 0f))
				{
					nint num = (nint)typeof(So);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v24 (Il2CppClass<So>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num2 = (nint)typeof(So);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v32 (Il2CppClass<So>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					HoverboardBundle hoverboardBundle = ((CharacterModel)(object)So.Instance).AddHoverboard((string)(object)doubleScoreMultiplier.powerDownSound, false);
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

	private static bool _doubleScoreActive;

	public unsafe static bool doubleScoreActive
	{
		get
		{
			//IL_0188: Expected I, but got Obj
			//IL_019e: Expected Obj, but got I
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Expected I, but got Unknown
			//IL_02c4: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_01d6: Expected I, but got Obj
			//IL_01f1: Expected I, but got Obj
			//IL_0207: Expected Obj, but got I
			//IL_0249: Expected I, but got Obj
			//IL_025f: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_0285: Expected Obj, but got I4
			//IL_00ee: Expected I, but got Obj
			//IL_013b: Expected I, but got Obj
			nint num = (nint)typeof(CoinMagnet);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<CoinMagnet>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CoinMagnet);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v53 (Il2CppClass<CoinMagnet>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = default;
			nint num3 = (nint)(obj2 + 4);
			bool flag = (object)CoinMagnet.instance == null;
			bool flag2 = !flag;
			bool result = (byte)(int)CoinMagnet.instance != 0;
			if (!flag2)
			{
				nint num4 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v25 (Il2CppClass<System.Type>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num5 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v49 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = typeof(CoinMagnet);
				((IntPtr*)num3)->m_value = (void*)(nint)obj2;
				Type type = Type.internal_from_handle((IntPtr)num3);
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num7 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = ((UnityEngine.Object)(object)type).ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
				nint num8 = (nint)typeof(CoinMagnet);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v36 (Il2CppClass<CoinMagnet>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num9 = (nint)typeof(CoinMagnet);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v43 (Il2CppClass<CoinMagnet>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag3 = default;
				CoinMagnet.instance = (CoinMagnet)flag3;
				result = flag3;
			}
			return result;
		}
		private set
		{
			_ = 150f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
		}
	}

	public override IEnumerator Begin()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		return enumerator;
	}

	public override void Reset()
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected I4, but got Unknown
		//IL_0027: Expected I, but got Obj
		//IL_003d: Expected Obj, but got I
		//IL_0068: Expected I, but got Obj
		bool flag = _doubleScoreActive;
		object obj = flag ^ this;
		if (obj == null)
		{
			return;
		}
		bool flag2 = (byte)(this & 1) != 0;
		_doubleScoreActive = flag2;
		nint num = (nint)typeof(ScoreMultiplierInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v16 (Il2CppClass<Info.ScoreMultiplierInfo>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(ScoreMultiplierInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21 (Il2CppClass<Info.ScoreMultiplierInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ScoreMultiplierInfo._002Ecctor();
	}

	public DoubleScoreMultiplier()
	{
		base.ExpireSoon();
		((DoubleScoreMultiplier)null).Reset();
	}
}

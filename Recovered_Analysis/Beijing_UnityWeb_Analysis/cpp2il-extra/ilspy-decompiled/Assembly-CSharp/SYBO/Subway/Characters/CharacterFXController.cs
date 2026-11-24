using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using SYBO.Common.StateSystem;
using SYBO.Components.Utilities;
using SYBO.Subway.Routes;
using SYBO.Subway.StateSystem;
using SYBO.Subway.StateSystem.States;
using UnityEngine;
using UnityEngine.UI;

namespace SYBO.Subway.Characters;

public class CharacterFXController : MonoBehaviour
{
	private sealed class _003CDespawnCollisionEffect_003Ed__17(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public bool despawnOnDeath;

		public CharacterFXController _003C_003E4__this;

		public bool activeDuringHoverboard;

		public Transform instance;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0293: Unknown result type (might be due to invalid IL or missing references)
				//IL_0298: Expected Obj, but got Unknown
				//IL_02a1: Expected Obj, but got I4
				//IL_02af: Expected I, but got Obj
				//IL_02c5: Expected Obj, but got I
				//IL_021b: Expected I, but got Obj
				//IL_013c: Expected I, but got Obj
				//IL_0152: Expected Obj, but got I
				//IL_02f4: Expected Obj, but got I4
				//IL_017d: Expected I, but got Obj
				//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01eb: Expected Obj, but got Unknown
				//IL_01f4: Expected Obj, but got I4
				//IL_0208: Expected Obj, but got I4
				CharacterFXController characterFXController = _003C_003E4__this;
				if (_003C_003E1__state != 0 && _003C_003E1__state != 1)
				{
					return null;
				}
				_003C_003E1__state = -1;
				if (delay > 0f)
				{
					if (~(despawnOnDeath ? 1u : 0u) == 0)
					{
						Game game = characterFXController._game;
						if (game._isInStumbleDeathSequence)
						{
							goto IL_0288;
						}
					}
					Game game2 = characterFXController._game;
					Variable<bool> isInGame = game2.IsInGame;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v27 (Variable`1<System.Boolean>)+8]");
					if ((nint)0 != 0)
					{
						if (~(activeDuringHoverboard ? 1u : 0u) != 0)
						{
							Hoverboard hoverboard = characterFXController._hoverboard;
							if (hoverboard.isActive)
							{
								goto IL_0288;
							}
						}
						nint num = (nint)typeof(GameStateMachine);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v34 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
						object obj = (nint)0 & (nint)0x200;
						if (obj != null)
						{
							nint num2 = (nint)typeof(GameStateMachine);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v46 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
						if (((StateMachine)useBenchmarkRoute).IsCurrentState<RunningState>())
						{
							float unscaledTime = Time.unscaledTime;
							float num3 = delay - unscaledTime;
							delay = num3;
							object obj2 = this + 12;
							obj2 = 0;
							_003C_003E1__state = 1;
							return 1;
						}
					}
				}
				goto IL_0288;
				IL_0288:
				object obj3 = _003C_003E4__this + 60;
				obj3 = 0;
				nint num4 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v9 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num5 = (nint)typeof(PoolManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v14 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				PoolManager.AddPool((PrefabPool)(object)instance);
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

	private sealed class _003CDespawnJumpRollEffect_003Ed__21(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Character character;

		public CharacterFXController _003C_003E4__this;

		public Transform instance;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ed: Expected Obj, but got Unknown
				//IL_0309: Expected Obj, but got I4
				//IL_006b: Expected I, but got Obj
				//IL_0081: Expected Obj, but got I
				//IL_00ac: Expected I, but got Obj
				//IL_01de: Expected I, but got Obj
				//IL_01f4: Expected Obj, but got I
				//IL_0320: Expected Obj, but got I4
				//IL_021f: Expected I, but got Obj
				//IL_0264: Unknown result type (might be due to invalid IL or missing references)
				//IL_0269: Expected Obj, but got Unknown
				//IL_0272: Expected Obj, but got I4
				//IL_0286: Expected Obj, but got I4
				CharacterFXController characterFXController = _003C_003E4__this;
				if (_003C_003E1__state != 0 && _003C_003E1__state != 1)
				{
					if (_003C_003E1__state == 2)
					{
						_003C_003E1__state = -1;
						nint num = (nint)typeof(PoolManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v17 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
						object obj = (nint)0 & (nint)0x200;
						if (obj != null)
						{
							nint num2 = (nint)typeof(PoolManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v22 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						PoolManager.AddPool((PrefabPool)(object)instance);
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Character character = this.character;
				if (~(character._isRolling ? 1u : 0u) == 0)
				{
					Character character2 = this.character;
					if (character2.CurrentRunPosition__BackingField == Character.RunPositions.ground)
					{
						Game game = characterFXController._game;
						Variable<bool> isInGame = game.IsInGame;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v32 (Variable`1<System.Boolean>)+8]");
						if ((nint)0 != 0)
						{
							Hoverboard hoverboard = characterFXController._hoverboard;
							if (~(hoverboard.isActive ? 1u : 0u) != 0)
							{
								nint num3 = (nint)typeof(GameStateMachine);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v39 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
								object obj2 = (nint)0 & (nint)0x200;
								if (obj2 != null)
								{
									nint num4 = (nint)typeof(GameStateMachine);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v50 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
								if (((StateMachine)useBenchmarkRoute).IsCurrentState<RunningState>())
								{
									object obj3 = this + 12;
									obj3 = 0;
									_003C_003E1__state = 1;
									return 1;
								}
							}
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = characterFXController._jmupRollDespawnAddedDelay;
				object obj4 = this + 12;
				object obj5 = default;
				obj4 = obj5;
				_003C_003E1__state = 2;
				return 1;
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

	private sealed class _003CDespawnGrindEffect_003Ed__24(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CharacterFXController _003C_003E4__this;

		public Character character;

		public Transform instance;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0157: Expected I, but got Obj
				//IL_016d: Expected Obj, but got I
				//IL_00e6: Expected I, but got Obj
				//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b6: Expected Obj, but got Unknown
				//IL_00bf: Expected Obj, but got I4
				//IL_00d3: Expected Obj, but got I4
				if (_003C_003E1__state != 0 && _003C_003E1__state != 1)
				{
					return null;
				}
				_003C_003E1__state = -1;
				string hoverboardAnimationName = ((CharacterRendering)(object)_003C_003E4__this).GetHoverboardAnimationName((string)(object)this.character);
				if (hoverboardAnimationName != null)
				{
					Character character = this.character;
					if (~(character._isRolling ? 1u : 0u) != 0)
					{
						object obj = this + 12;
						obj = 0;
						_003C_003E1__state = 1;
						return 1;
					}
				}
				nint num = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v7 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num2 = (nint)typeof(PoolManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v12 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				PoolManager.AddPool((PrefabPool)(object)instance);
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

	private Transform _dizzyStarsPrefab;

	private float _starHeightOffset;

	private float _dizzyDuration;

	private Transform _bushLeavesPrefab;

	private float _leavesDuration;

	private Transform _jumpRollPrefab;

	private float _jmupRollDespawnAddedDelay;

	private Transform _grindSparkPrefab;

	private Game _game;

	private Hoverboard _hoverboard;

	private bool _dizzyStarsHeightOffsetSet;

	private Transform _dizzyStarsInstance;

	private IEnumerator _dizzyStarsDespawn;

	private void Awake()
	{
		//IL_0321: Expected Obj, but got F4
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected Obj, but got Unknown
		//IL_0342: Expected Obj, but got I4
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00b0: Expected Obj, but got F4
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_0173: Expected Obj, but got I
		//IL_0183: Expected Obj, but got I
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected Obj, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected Obj, but got Unknown
		//IL_01e0: Expected I, but got Obj
		//IL_01f6: Expected Obj, but got I
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected Obj, but got Unknown
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected Obj, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected Obj, but got Unknown
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected Obj, but got Unknown
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected Obj, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Obj, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		//IL_0221: Expected I, but got Obj
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected Obj, but got Unknown
		_dizzyStarsPrefab = (Transform)1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		object obj = obj2 + 76;
		obj = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
		object obj3 = obj2 + 104;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
		object obj4 = obj2 + 48;
		obj4 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v25+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v25+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v25+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		AnimationCurve animationCurve = default;
		Keyframe[] keys = default;
		animationCurve.keys = keys;
		object obj5 = this + 16;
		obj5 = animationCurve;
		_hoverboard = (Hoverboard)17f;
		_ = 0.5f;
		_ = 0.01f;
		_ = 200f;
		_ = 20f;
		_ = 40f;
		_ = -1f;
		_ = 15f;
		_ = 5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		object obj6 = this + 132;
		object obj7 = default;
		obj6 = obj7;
		_ = -1f;
		_ = -1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		VariableBool variableBool = default;
		variableBool.FireOnChange();
		object obj8 = this + 216;
		obj8 = variableBool;
		_ = 45f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj10 = default;
		object obj9 = obj10 + 8;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S1_v61 (Il2CppMethodInfo)+C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S1_v62+60]");
		object obj12 = 0;
		object obj13 = obj12;
		object obj14 = obj13 & 0xFFF;
		object obj15 = obj14 + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v159 @ S2_v9 (should have been resolved before IL gen)");
		object obj16 = default;
		obj9 = obj16;
		object obj17 = this + 228;
		obj17 = obj10;
		_ = 5;
		nint num2 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v70 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v113 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj19 = obj2 + 36;
		Vector3 one = Vector3.one;
		obj3 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v75+8]");
		_ = 0;
		object obj20 = this + 236;
		obj20 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19+8]");
		_ = 0;
		object obj21 = obj2 + 24;
		Vector3 one2 = Vector3.one;
		obj3 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v82+8]");
		_ = 0;
		object obj22 = this + 248;
		obj22 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19+8]");
		_ = 0;
		_ = 5;
		_ = 1;
		_ = 1;
		object obj23 = obj2 + 12;
		Vector3 one3 = Vector3.one;
		obj3 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S0_v92+8]");
		_ = 0;
		object obj24 = this + 504;
		obj24 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19+8]");
		_ = 0;
		Vector3 one4 = Vector3.one;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj25 = this + 516;
		obj25 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		HashSet<> hashSet = default;
		((HashSet<T>)(object)hashSet).Clear();
		object obj26 = this + 528;
		obj26 = hashSet;
		_ = 10f;
		_ = -30f;
		CancelInvoke();
	}

	private void Character_OnStumble(Character.StumbleType stumbleType, Character.StumbleHorizontalHit horizontalHit, Character.StumbleVerticalHit verticalHit, string colliderName, bool safeStumble)
	{
		//IL_004a: Expected Obj, but got I4
		//IL_004a: Expected I4, but got Obj
		//IL_004a: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.CharacterFXController)+120]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.CharacterFXController)+120]");
			((System.Collections.Generic.ArraySortHelper<TKey, TValue>)0).Sort((TKey[])stumbleType, (TValue[])horizontalHit, (int)verticalHit, (int)colliderName, (IComparer<TKey>)safeStumble);
		}
	}

	private unsafe void HandleBushStumble()
	{
		//IL_0249: Expected I, but got Obj
		//IL_025f: Expected Obj, but got I
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_038d: Expected Obj, but got I4
		//IL_039b: Expected I, but got Obj
		//IL_03b1: Expected Obj, but got I
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_02a6: Expected I, but got Obj
		//IL_02bc: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_019f: Expected I, but got Obj
		//IL_01b5: Expected Obj, but got I
		//IL_01e0: Expected I, but got Obj
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v50 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 44;
		bool isInstantiated = Game.IsInstantiated;
		obj2 = isInstantiated;
		nint num3 = (nint)typeof(Hoverboard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v13 (Il2CppClass<Hoverboard>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v46 (Il2CppClass<Hoverboard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = this + 48;
		CharacterModifier characterModifier = MysteryPowerup.SelectRandomCharacterModifier();
		obj4 = characterModifier;
		nint num5 = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v20 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v42 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterRendering instance = CharacterRendering.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Character.OnStumbleDelegate onStumbleDelegate = default;
		((Delegate)onStumbleDelegate).method_ptr = method_ptr;
		((Delegate)onStumbleDelegate).method = (nint)__ldftn(CharacterFXController.Character_OnStumble);
		object obj6 = onStumbleDelegate + 16;
		obj6 = this;
		((Character)(object)instance).OnStumble -= onStumbleDelegate;
		CharacterRendering instance2 = CharacterRendering.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		_ = 0;
		Action<Character> action = default;
		object obj7 = action + 16;
		obj7 = this;
		((Character)(object)instance2).OnLanding -= action;
		CharacterRendering instance3 = CharacterRendering.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Character.OnCriticalHitDelegate onCriticalHitDelegate = default;
		((Delegate)onCriticalHitDelegate).method_ptr = method_ptr2;
		((Delegate)onCriticalHitDelegate).method = (nint)__ldftn(CharacterFXController.Character_OnCriticalHit);
		object obj8 = onCriticalHitDelegate + 16;
		obj8 = this;
		((Character)(object)instance3).OnCriticalHit -= onCriticalHitDelegate;
		nint num8 = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S1_v36 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num9 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S1_v48 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = PoolManager.PrefabPoolExists(_dizzyStarsPrefab);
		_ = 1;
		bool flag2 = PoolManager.PrefabPoolExists(_bushLeavesPrefab);
		_ = 1;
		bool flag3 = PoolManager.PrefabPoolExists(_jumpRollPrefab);
		_ = 1;
		bool flag4 = PoolManager.PrefabPoolExists(_grindSparkPrefab);
		_ = 1;
	}

	private void HandleSideStumble()
	{
		//IL_00fc: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_0186: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v21 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PrefabPool prefabPool = PoolManager.GetPrefabPool(_bushLeavesPrefab);
		GameObject parentInternal = gameObject;
		((Transform)(object)prefabPool).parentInternal = (Transform)(object)parentInternal;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v12 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v25 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		object obj3 = default;
		Transform transform = (Transform)(obj3 + 12);
		transform = (Transform)obj3;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		IAsyncResult list = ((UIEventListener.FloatDelegate)(object)this).BeginInvoke((GameObject)(object)prefabPool, _leavesDuration, (AsyncCallback)1, (object)null);
		Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	private IEnumerator DespawnCollisionEffect(Transform instance, float delay, bool activeDuringHoverboard = false, bool despawnOnDeath = false)
	{
		//IL_0055: Expected Obj, but got I4
		//IL_0211: Expected Obj, but got I4
		//IL_0080: Expected I, but got Obj
		//IL_0096: Expected Obj, but got I
		//IL_00c1: Expected I, but got Obj
		//IL_0333: Expected I, but got Obj
		//IL_0349: Expected Obj, but got I
		//IL_02ae: Expected I, but got Obj
		//IL_02c4: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_01c9: Expected I, but got Obj
		if (delay < 0.001f)
		{
			return null;
		}
		bool flag = delay > 0.999f;
		bool flag2 = !flag;
		bool flag3 = despawnOnDeath;
		bool flag4 = flag3 ^ activeDuringHoverboard;
		object obj = flag2 | flag4;
		if (obj != null)
		{
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v15 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v57 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num3;
			if (delay < 0f)
			{
				num3 = 0f;
			}
			else
			{
				num3 = ((!(delay > 1f)) ? delay : 1f);
			}
			bool flag5 = !flag4;
			float num4 = num3;
			if (!flag5)
			{
				float num5 = 1f - num3;
				num4 = num5;
			}
			float num6 = num4 * ((float)Math.PI / 2f);
			nint num7 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v27 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num8 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v46 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E7");
			nint num9 = (nint)typeof(UIBasicSprite);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v36 (Il2CppClass<UIBasicSprite>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num10 = (nint)typeof(UIBasicSprite);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v42 (Il2CppClass<UIBasicSprite>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float cos = default;
			float sin = default;
			Image.RadialCut((Vector3[])(object)this, cos, sin, flag4, despawnOnDeath ? 1 : 0);
			Image.RadialCut((Vector3[])(object)instance, cos, sin, flag4, despawnOnDeath ? 1 : 0);
		}
		return (IEnumerator)1;
	}

	private unsafe void Character_OnCriticalHit(Character.CriticalHitType type)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_015f: Expected I4, but got Obj
		//IL_0181: Expected Obj, but got I
		//IL_019e: Expected F4, but got I
		//IL_019e: Expected Obj, but got I
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_01d0: Expected I4, but got Obj
		//IL_01ec: Expected Obj, but got F4
		//IL_0203: Expected F4, but got I
		//IL_0203: Expected Obj, but got F4
		//IL_004f: Expected Obj, but got I
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_0063: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got F4
		//IL_0092: Expected I4, but got Obj
		//IL_00b4: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got F4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_00dd: Expected Obj, but got I4
		//IL_00ec: Expected Obj, but got F4
		//IL_010c: Expected I4, but got Obj
		//IL_0128: Expected Obj, but got F4
		object obj = default;
		bool flag = (byte)(obj + 24) != 0;
		object obj2 = obj + 12;
		if (type != Character.CriticalHitType.Train)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.CharacterFXController)+B8]");
			((CapsuleCollider)0).height = 4f;
			object obj3 = this + 408;
			obj2 = 0;
			_ = 0;
			obj2 = 0f;
			_ = 2f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v26+8]");
			_ = 0;
			((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj2 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.CharacterFXController)+B8]");
			((CharacterController)0).detectCollisions = flag;
			((Rigidbody2D)_dizzyDuration).rotation = 4f;
			object obj4 = this + 428;
			obj = 0;
			_ = 0;
			obj = 0f;
			_ = 4f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v38+8]");
			_ = 0;
			((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			((CapsuleCollider)_dizzyDuration).get_center_Injected(out *(flag ? ((Vector3*)1) : ((Vector3*)null)));
		}
		else
		{
			object obj5 = this + 408;
			obj2 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v6+8]");
			_ = 0;
			((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj2 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.CharacterFXController)+B8]");
			((CharacterController)0).detectCollisions = flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.CharacterFXController)+B8]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.CharacterFXController)+1A4]");
			((CapsuleCollider)num).height = 0f;
			object obj6 = this + 428;
			obj = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S2_v6+8]");
			_ = 0;
			((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			((CapsuleCollider)_dizzyDuration).get_center_Injected(out *(flag ? ((Vector3*)1) : ((Vector3*)null)));
			float dizzyDuration = _dizzyDuration;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.CharacterFXController)+1B8]");
			((Rigidbody2D)dizzyDuration).rotation = 0f;
		}
	}

	private void Character_OnLanding(Character character)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0024: Expected Obj, but got I4
		//IL_0032: Expected I, but got Obj
		//IL_0048: Expected Obj, but got I
		//IL_0073: Expected I, but got Obj
		if (_dizzyStarsDespawn == null)
		{
			return;
		}
		CoroutineUtil.StopCoroutine((Coroutine)(object)_dizzyStarsDespawn);
		object obj = this + 60;
		obj = 0;
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v7 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v12 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PoolManager.AddPool((PrefabPool)(object)_dizzyStarsInstance);
	}

	private void HandleJumpRoll(Character character)
	{
		if (~(character._isRolling ? 1u : 0u) == 0 && character.CurrentRunPosition__BackingField == Character.RunPositions.ground)
		{
			Hoverboard hoverboard = _hoverboard;
			if (!hoverboard.isActive)
			{
				HandleGrind(character);
				return;
			}
		}
		if (~(character._isRolling ? 1u : 0u) != 0)
		{
			Hoverboard hoverboard2 = _hoverboard;
			if (~(hoverboard2.isActive ? 1u : 0u) == 0)
			{
				((CharacterRendering)this).DebugLog((string)(object)character);
			}
		}
	}

	private unsafe IEnumerator DespawnJumpRollEffect(Transform instance, Character character)
	{
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected Obj, but got Unknown
		//IL_03f9: Expected Obj, but got I4
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected Obj, but got Unknown
		//IL_041c: Expected Obj, but got I4
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected Obj, but got Unknown
		//IL_0439: Expected Obj, but got I4
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected Obj, but got Unknown
		//IL_045c: Expected Obj, but got I4
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected Obj, but got Unknown
		//IL_047f: Expected Ref, but got F4
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected Obj, but got Unknown
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_0063: Expected I, but got Obj
		//IL_0079: Expected Obj, but got I
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected VT, but got Unknown
		//IL_04ee: Expected F4, but got Obj
		//IL_04e9: Expected native int or pointer, but got VT
		//IL_0503: Expected F4, but got I
		//IL_04fe: Expected native int or pointer, but got VT
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected Obj, but got Unknown
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected VT, but got Unknown
		//IL_053e: Expected F4, but got Obj
		//IL_0539: Expected native int or pointer, but got VT
		//IL_0553: Expected F4, but got I
		//IL_054e: Expected native int or pointer, but got VT
		//IL_0560: Expected F4, but got Obj
		//IL_055b: Expected native int or pointer, but got VT
		//IL_0575: Expected F4, but got I
		//IL_0570: Expected native int or pointer, but got VT
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected Obj, but got Unknown
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Expected Obj, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0127: Expected F4, but got Obj
		//IL_0122: Expected native int or pointer, but got VT
		//IL_013c: Expected F4, but got I
		//IL_0137: Expected native int or pointer, but got VT
		//IL_0149: Expected F4, but got Obj
		//IL_0144: Expected native int or pointer, but got VT
		//IL_015e: Expected F4, but got I
		//IL_0159: Expected native int or pointer, but got VT
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_00a4: Expected I, but got Obj
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_01d8: Expected F4, but got Obj
		//IL_01d3: Expected native int or pointer, but got VT
		//IL_01ed: Expected F4, but got I
		//IL_01e8: Expected native int or pointer, but got VT
		//IL_01fa: Expected F4, but got Obj
		//IL_01f5: Expected native int or pointer, but got VT
		//IL_020f: Expected F4, but got I
		//IL_020a: Expected native int or pointer, but got VT
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected Obj, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected Obj, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected Obj, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected Obj, but got Unknown
		//IL_0297: Expected F4, but got Obj
		//IL_0292: Expected native int or pointer, but got VT
		//IL_02ac: Expected F4, but got I
		//IL_02a7: Expected native int or pointer, but got VT
		//IL_02b9: Expected F4, but got Obj
		//IL_02b4: Expected native int or pointer, but got VT
		//IL_02ce: Expected F4, but got I
		//IL_02c9: Expected native int or pointer, but got VT
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected Obj, but got Unknown
		//IL_02ff: Expected F4, but got Obj
		//IL_02fa: Expected native int or pointer, but got VT
		//IL_0314: Expected F4, but got I
		//IL_030f: Expected native int or pointer, but got VT
		//IL_032e: Expected F4, but got Obj
		//IL_0329: Expected native int or pointer, but got VT
		//IL_0343: Expected F4, but got I
		//IL_033e: Expected native int or pointer, but got VT
		//IL_0350: Expected F4, but got Obj
		//IL_034b: Expected native int or pointer, but got VT
		//IL_0365: Expected F4, but got I
		//IL_0360: Expected native int or pointer, but got VT
		//IL_03e2: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 288;
		obj = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj2 + 272;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 248;
		obj4 = 0;
		_ = 0;
		_ = 0;
		object obj5 = obj2 + 232;
		obj5 = 0;
		_ = 0;
		Collider collider = (Collider)(obj2 + 208);
		collider.get_bounds_Injected(out *(Bounds*)_dizzyDuration);
		obj = collider;
		_ = ((UnityEngine.Object)collider).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23 (UnityEngine.Collider)+10]");
		_ = 0;
		object obj6 = obj2 + 196;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
		object obj7 = obj2 + 184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
		object obj8 = obj2 + 172;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
		object obj9 = obj2 + 160;
		obj9 = 0;
		_ = 0;
		obj9 = obj7;
		_ = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v34+8]");
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v44 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v112 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 324);
		((Vector3*)(nint)vector)->x = (float)obj9;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v38+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj11 = obj2 + 148;
		Quaternion quaternion = Quaternion.AngleAxis(0.5f, vector);
		Vector3 vector3 = (Vector3)(obj2 + 312);
		((Vector3*)(nint)vector3)->x = (float)obj6;
		Vector3 vector4 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v28+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj11;
		Vector3 vector5 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v52+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		object obj12 = obj2 + 136;
		Quaternion quaternion2 = Quaternion.FromToRotation(vector3, vector);
		obj3 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v59+8]");
		_ = 0;
		Collider collider2 = (Collider)(obj2 + 112);
		collider2.get_bounds_Injected(out *(Bounds*)instance);
		obj4 = collider2;
		_ = ((UnityEngine.Object)collider2).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v63 (UnityEngine.Collider)+10]");
		_ = 0;
		object obj13 = obj2 + 96;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
		((Vector3*)(nint)vector3)->x = (float)obj13;
		Vector3 vector6 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v68+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj3;
		Vector3 vector7 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
		((Vector3*)(nint)vector7)->z = 0f;
		object obj14 = obj2 + 84;
		Quaternion quaternion3 = Quaternion.FromToRotation(vector3, vector);
		obj5 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v74+8]");
		_ = 0;
		object obj15 = obj2 + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11463");
		object obj16 = obj2 + 60;
		Vector3 right = Vector3.right;
		((Vector3*)(nint)vector3)->x = (float)obj15;
		Vector3 vector8 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v78+8]");
		((Vector3*)(nint)vector8)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj16;
		Vector3 vector9 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v80+8]");
		((Vector3*)(nint)vector9)->z = 0f;
		object obj17 = obj2 + 48;
		Vector3 vector10 = Vector3.Min(vector3, vector);
		object obj18 = obj2 + 36;
		object obj19 = this + 504;
		obj18 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S1_v101+8]");
		_ = 0;
		object obj20 = obj2 + 24;
		object obj21 = this + 516;
		obj20 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S1_v107+8]");
		_ = 0;
		((Vector3*)(nint)vector3)->x = (float)obj18;
		Vector3 vector11 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S0_v88+8]");
		((Vector3*)(nint)vector11)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj20;
		Vector3 vector12 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v91+8]");
		((Vector3*)(nint)vector12)->z = 0f;
		object obj22 = obj2 + 12;
		Quaternion quaternion4 = Quaternion.FromToRotation(vector3, vector);
		((Vector3*)(nint)vector)->x = (float)obj22;
		Vector3 vector13 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S0_v98+8]");
		((Vector3*)(nint)vector13)->z = 0f;
		Quaternion quaternion5 = Quaternion.Inverse((Quaternion)vector);
		((Vector3*)(nint)vector3)->x = (float)obj17;
		Vector3 vector14 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S0_v86+8]");
		((Vector3*)(nint)vector14)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj2;
		Vector3 vector15 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector15)->z = 0f;
		float num3 = vector3.x * vector.x;
		float num4 = vector3.y * vector.y;
		float num5 = num3 + num4;
		float num6 = vector3.z * vector.z;
		float num7 = num5 + num6;
		bool flag = num7 < 0f;
		return (IEnumerator)flag;
	}

	private void HandleGrind(Character character)
	{
		//IL_00fc: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v21 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PrefabPool prefabPool = PoolManager.GetPrefabPool(_jumpRollPrefab);
		GameObject parentInternal = gameObject;
		((Transform)(object)prefabPool).parentInternal = (Transform)(object)parentInternal;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v12 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v25 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		object obj3 = default;
		Transform transform = (Transform)(obj3 + 12);
		transform = (Transform)obj3;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		IEnumerator list = DespawnGrindEffect((Transform)(object)prefabPool, character);
		Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	private bool InGrind(Character character)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = this;
		object obj2 = character & 1;
		return flag;
	}

	private IEnumerator DespawnGrindEffect(Transform instance, Character character)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = this;
		object obj2 = enumerator + 24;
		obj2 = instance;
		object obj3 = enumerator + 16;
		obj3 = character;
		return enumerator;
	}

	public CharacterFXController()
	{
		//IL_00cb: Expected I, but got Obj
		//IL_00e1: Expected Obj, but got I
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_003d: Expected I, but got Obj
		//IL_0053: Expected Obj, but got I
		//IL_010c: Expected I, but got Obj
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		//IL_023e: Expected Obj, but got I4
		//IL_023e: Expected Obj, but got I4
		//IL_007e: Expected I, but got Obj
		Game game = _game;
		if (~(game._isInStumbleDeathSequence ? 1u : 0u) == 0)
		{
			return;
		}
		if (_dizzyStarsDespawn != null)
		{
			CoroutineUtil.StopCoroutine((Coroutine)(object)_dizzyStarsDespawn);
			nint num = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v22 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v27 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			PoolManager.AddPool((PrefabPool)(object)_dizzyStarsInstance);
		}
		nint num3 = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v16 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v37 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = this + 56;
		PrefabPool prefabPool = PoolManager.GetPrefabPool(_dizzyStarsPrefab);
		obj3 = prefabPool;
		GameObject parentInternal = gameObject;
		_dizzyStarsInstance.parentInternal = (Transform)(object)parentInternal;
		if (~(_dizzyStarsHeightOffsetSet ? 1u : 0u) != 0)
		{
			_0021_00210 componentInChildren = (_0021_00210)((Component)_dizzyStarsInstance).GetComponentInChildren<T>();
			_ = _starHeightOffset;
			_dizzyStarsHeightOffsetSet = true;
		}
		object obj4 = this + 60;
		IAsyncResult asyncResult = ((UIEventListener.FloatDelegate)(object)this).BeginInvoke((GameObject)(object)_dizzyStarsInstance, _dizzyDuration, (AsyncCallback)1, (object)1);
		obj4 = asyncResult;
		Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)_dizzyStarsDespawn);
	}
}

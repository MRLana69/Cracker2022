using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using SYBO.Common.StateSystem;
using SYBO.Components.Utilities;
using SYBO.Subway.Characters;
using SYBO.Subway.Coins;
using SYBO.Subway.Inputs;
using SYBO.Subway.Level;
using SYBO.Subway.Routes.Builders;
using SYBO.Subway.StateSystem.States.Settings;
using UnityEngine;

namespace SYBO.Subway.StateSystem.States;

public class JetpackState : FlyingState
{
	private sealed class _003CSpawnCoinCurve_003Ed__10(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float startZ;

		public float height;

		public AnimationCurve curve;

		public JetpackState _003C_003E4__this;

		public float endZ;

		private CoinManager _003CcoinManager_003E5__2;

		private float _003Cz_003E5__3;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0260: Unknown result type (might be due to invalid IL or missing references)
				//IL_0265: Expected VT, but got Unknown
				//IL_026e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0273: Expected VT, but got Unknown
				//IL_027c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0281: Expected Obj, but got Unknown
				//IL_028a: Unknown result type (might be due to invalid IL or missing references)
				//IL_028f: Expected Obj, but got Unknown
				//IL_0298: Unknown result type (might be due to invalid IL or missing references)
				//IL_029d: Expected Obj, but got Unknown
				//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ab: Expected Obj, but got Unknown
				//IL_02b4: Expected Obj, but got I4
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_0048: Expected VT, but got Obj
				//IL_0050: Expected Obj, but got VT
				//IL_00b4: Expected I, but got Obj
				//IL_00ca: Expected Obj, but got I
				//IL_02fe: Expected F4, but got Obj
				//IL_02f9: Expected native int or pointer, but got VT
				//IL_0313: Expected F4, but got I
				//IL_030e: Expected native int or pointer, but got VT
				//IL_0154: Expected F4, but got Obj
				//IL_014f: Expected native int or pointer, but got VT
				//IL_0169: Expected F4, but got I
				//IL_0164: Expected native int or pointer, but got VT
				//IL_0176: Expected F4, but got Obj
				//IL_0171: Expected native int or pointer, but got VT
				//IL_0188: Expected F4, but got Obj
				//IL_0183: Expected native int or pointer, but got VT
				//IL_00f5: Expected I, but got Obj
				//IL_01c0: Expected F4, but got Obj
				//IL_01bb: Expected native int or pointer, but got VT
				//IL_01d5: Expected F4, but got I
				//IL_01d0: Expected native int or pointer, but got VT
				//IL_01e9: Expected Obj, but got VT
				//IL_01ff: Expected Obj, but got I4
				//IL_0226: Unknown result type (might be due to invalid IL or missing references)
				//IL_022b: Expected Obj, but got Unknown
				//IL_0234: Expected Obj, but got I4
				//IL_0248: Expected Obj, but got I4
				object obj = default;
				Vector3 vector = (Vector3)(obj + 72);
				Vector3 vector2 = (Vector3)(obj + 60);
				object obj2 = obj + 36;
				object obj3 = obj + 24;
				RouteBuilder routeBuilder = (RouteBuilder)(obj + 12);
				object obj4 = obj + 48;
				obj4 = 0;
				_ = 0;
				JetpackState jetpackState = _003C_003E4__this;
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
					object obj5 = this + 36;
					_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
					obj5 = val;
					_003Cz_003E5__3 = startZ;
				}
				if (_003Cz_003E5__3 < endZ)
				{
					nint num = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v32 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num2 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v60 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Vector3 down = Vector3.down;
					((Vector3*)(nint)vector)->x = (float)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					((Vector3*)(nint)vector)->z = 0f;
					Vector3 vector3 = vector / height;
					float fromGamePositionZ = PlayerPrefs.GetFloat((string)(object)curve, _003Cz_003E5__3);
					routeBuilder.HideLogic(fromGamePositionZ, _003Cz_003E5__3);
					((Vector3*)(nint)vector2)->x = (float)obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
					((Vector3*)(nint)vector2)->z = 0f;
					((Vector3*)(nint)vector)->x = (float)routeBuilder;
					((Vector3*)(nint)vector)->z = (float)routeBuilder.OnCompletedLayingSections;
					Vector3 vector4 = vector2 - vector;
					obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					((Vector3*)(nint)vector)->x = (float)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
					((Vector3*)(nint)vector)->z = 0f;
					bool flag = ((Character)(object)_003CcoinManager_003E5__2).EnteredColliderFromBelow((Collider)vector, false);
					jetpackState._dynamicSpawnedCoins.Add((Coin)flag);
					float num3 = _003Cz_003E5__3 + 30f;
					_003Cz_003E5__3 = num3;
					object obj7 = this + 12;
					obj7 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
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

	private const float CoinStayInTrackDistance = 60f;

	private const float CoinSpacingInZ = 30f;

	private JetpackStateSettings _settings;

	private List<Coin> _dynamicSpawnedCoins;

	protected override UpgradeType UpgradeType
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.StateSystem.States.JetpackState)+90]");
			return UpgradeType._notset;
		}
	}

	public JetpackState(int id)
	{
	}

	public override void Enter(State fromState)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj = this + 124;
		object obj2 = default;
		obj = obj2;
		base.Enter(fromState);
		object obj3 = this + 120;
		_0021_00210[] array = (_0021_00210[])(object)NGUITools.FindActive<T>();
		obj3 = array;
	}

	public override void Leave(State toState)
	{
		//IL_00f9: Expected I4, but got Obj
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_00b0: Expected I, but got Obj
		base.HandleSwipe((SwipeDir)toState);
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		((GameStats)(object)privacyPolicyUrl).KeyPickupsCollectedIncrement();
		object obj = _character + 248;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		float num = 0f + _flyAheadDistance;
		JetpackStateSettings settings = _settings;
		float gameSpeed = num + settings._coinOffset;
		nint num2 = (nint)typeof(GamePositionRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v18 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v24 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isRestricted = AgeRestriction.isRestricted;
		object obj4 = this - -64;
		float num4 = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S2_v4 (System.Boolean)+10]");
		float characterPositionZ = num4 - 0f;
		FlyingStateSettings settings2 = base._settings;
		((MovingTrain)(object)this).UpdateMovingTrain(gameSpeed, characterPositionZ, settings2._flyHeight);
	}

	private void SpawnCoins(float startZ, float endZ, float height)
	{
		//IL_000a: Expected I4, but got F4
		//IL_0014: Expected Obj, but got F4
		//IL_001e: Expected Obj, but got F4
		Id = (int)startZ;
		_game = (Game)endZ;
		_character = (Character)height;
	}

	private IEnumerator SpawnCoinCurve(AnimationCurve curve, float startZ, float endZ, float height)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = curve;
		return enumerator;
	}

	private void DespawnCoins()
	{
	}

	protected override float GetFlyingSpeed()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.StateSystem.States.JetpackState)+90]");
		if ((nint)0 == 1)
		{
			JetpackStateSettings settings = _settings;
			return settings._speedup;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.StateSystem.States.JetpackState)+90]");
		if ((nint)0 == 2)
		{
			JetpackStateSettings settings2 = _settings;
			return settings2._coinOffset;
		}
		FlyingStateSettings settings3 = base._settings;
		return settings3._flyHeight;
	}
}

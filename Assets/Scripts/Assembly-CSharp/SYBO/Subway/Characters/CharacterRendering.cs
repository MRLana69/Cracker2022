using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using SYBO.Common;
using SYBO.Common.Components.Singleton;
using SYBO.Common.Utilities;
using SYBO.Subway.Cameras;
using SYBO.Subway.Characters.States;
using SYBO.Subway.Routes;
using UnityEngine;

namespace SYBO.Subway.Characters;

public class CharacterRendering : MonoBehaviour
{
	public class Animations
	{
		public List<string> TOP_MENU;

		public List<string> INTRO_RUN;

		public List<string> RUN;

		public List<string> LAND;

		public List<string> BIG_LAND;

		public List<string> SMALL_LAND;

		public List<string> JUMP;

		public List<string> SMALL_JUMP;

		public List<string> TUCK;

		public List<string> HANGTIME;

		public List<string> DOUBLEJUMP;

		public List<string> DOUBLEHANGTIME;

		public List<string> ROLL;

		public List<string> DODGE_LEFT;

		public List<string> DODGE_RIGHT;

		public List<string> TURBO_HEADSTART1;

		public List<string> TURBO_HEADSTART2;

		public List<string> STARTGRIND;

		public List<string> GRIND;

		public List<string> GET_ON_BOARD;

		public List<string> HIT_MID;

		public List<string> HIT_UPPER;

		public List<string> HIT_LOWER;

		public List<string> HIT_MOVING;

		public List<string> STUMBLE;

		public List<string> STUMBLEDEATH;

		public List<string> STUMBLE_MIX;

		public List<string> STUMBLE_LEFT_SIDE;

		public List<string> STUMBLE_RIGHT_SIDE;

		public List<string> STUMBLE_LEFT_CORNER;

		public List<string> STUMBLE_RIGHT_CORNER;

		public List<string> HOLDMAGNET;

		public List<string> WALLRIDELEFT;

		public List<string> WALLRIDELEFTEXIT;

		public List<string> WALLRIDERIGHT;

		public List<string> WALLRIDERIGHTEXIT;

		public List<string> WALLGRINDLEFT;

		public List<string> WALLGRINDLEFTEXIT;

		public List<string> WALLGRINDRIGHT;

		public List<string> WALLGRINDRIGHTEXIT;

		public List<string> ROUTE_CELEBRATE;

		public List<string> BIG_AIR_TRICK;

		public List<string> ROUTE_ENTER;

		public List<string> ROUTE_EXIT;

		public string DEFAULT_HOVERBOARD_ANIMATION;

		private List<string> _animationNamesFiltered;

		private List<string> _animationNamesExcluded;

		public string TopMenu => GetRandomAnimationName(TOP_MENU);

		public string IntroRun => GetRandomAnimationName(INTRO_RUN);

		public string Run => GetRandomAnimationName(RUN);

		public string Land => GetRandomAnimationName(LAND);

		public string BigLand => GetRandomAnimationName(BIG_LAND);

		public string SmallLand => GetRandomAnimationName(SMALL_LAND);

		public string Jump => GetRandomAnimationName(JUMP);

		public string SmallJump => GetRandomAnimationName(SMALL_JUMP);

		public string Tuck => GetRandomAnimationName(TUCK);

		public string Hangtime => GetRandomAnimationName(HANGTIME);

		public string DoubleJump => GetRandomAnimationName(DOUBLEJUMP);

		public string DoubleHangtime => GetRandomAnimationName(DOUBLEHANGTIME);

		public string TurboHeadstart1 => GetRandomAnimationName(TURBO_HEADSTART1);

		public string TurboHeadstart2 => GetRandomAnimationName(TURBO_HEADSTART2);

		public List<string> HoverboardJump => GetRandomHoverJumps(JUMP, HANGTIME);

		public string Roll => GetRandomAnimationName(ROLL);

		public string DodgeLeft => GetRandomAnimationName(DODGE_LEFT);

		public string DodgeRight => GetRandomAnimationName(DODGE_RIGHT);

		public string StartGrind => GetRandomAnimationName(STARTGRIND);

		public string GetOnBoard => GetRandomAnimationName(GET_ON_BOARD);

		public string HitMid => GetRandomAnimationName(HIT_MID);

		public string HitUpper => GetRandomAnimationName(HIT_UPPER);

		public string HitLower => GetRandomAnimationName(HIT_LOWER);

		public string HitMoving => GetRandomAnimationName(HIT_MOVING);

		public string Stumble => GetRandomAnimationName(STUMBLE);

		public string StumbleDeath => GetRandomAnimationName(STUMBLEDEATH);

		public string StumbleMix => GetRandomAnimationName(STUMBLE_MIX);

		public string StumbleLeftSide => GetRandomAnimationName(STUMBLE_LEFT_SIDE);

		public string StumbleRightSide => GetRandomAnimationName(STUMBLE_RIGHT_SIDE);

		public string StumbleLeftCorner => GetRandomAnimationName(STUMBLE_LEFT_CORNER);

		public string StumbleRightCorner => GetRandomAnimationName(STUMBLE_RIGHT_CORNER);

		public string WallRideLeft => GetRandomAnimationName(WALLRIDELEFT);

		public string WallRideLeftExit => GetRandomAnimationName(WALLRIDELEFTEXIT);

		public string WallRideRight => GetRandomAnimationName(WALLRIDERIGHT);

		public string WallRideRightExit => GetRandomAnimationName(WALLRIDERIGHTEXIT);

		public string WallGrindLeft => GetRandomAnimationName(WALLGRINDLEFT);

		public string WallGrindLeftExit => GetRandomAnimationName(WALLGRINDLEFTEXIT);

		public string WallGrindRight => GetRandomAnimationName(WALLGRINDRIGHT);

		public string WallGrindRightExit => GetRandomAnimationName(WALLGRINDRIGHTEXIT);

		public string RouteCelebrate => GetRandomAnimationName(ROUTE_CELEBRATE);

		public string BigAirTrick => GetRandomAnimationName(BIG_AIR_TRICK);

		public string RouteEnter => GetRandomAnimationName(ROUTE_ENTER);

		public string RouteExit => GetRandomAnimationName(ROUTE_EXIT);

		public string Grind(string lastAnimationName)
		{
			return GetRandomAnimationNameExcluding(GRIND, lastAnimationName);
		}

		private string GetRandomAnimationName(List<string> animationsNames)
		{
			int index = UnityEngine.Random.Range(0, animationsNames._size);
			return animationsNames.get_Item(index);
		}

		private string GetRandomAnimationNameExcluding(List<string> animationNames, string excludeAnimationName)
		{
			((List<T>)(object)_animationNamesExcluded).Clear();
			_animationNamesExcluded.Add(excludeAnimationName);
			return GetRandomAnimationNameExcluding(animationNames, _animationNamesExcluded);
		}

		private string GetRandomAnimationNameExcluding(List<string> animationNames, IEnumerable<string> excludeAnimationNames)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected Obj, but got Unknown
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected Obj, but got Unknown
			//IL_036d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0372: Expected Obj, but got Unknown
			//IL_0263: Unknown result type (might be due to invalid IL or missing references)
			//IL_0268: Expected Obj, but got Unknown
			//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c4: Expected Obj, but got Unknown
			object obj = default;
			Animations animations = (Animations)(obj - 48);
			animations.TUCK = null;
			animations.JUMP = null;
			if (animationNames._size == 1)
			{
				return animationNames.get_Item(0);
			}
			((List<T>)(object)_animationNamesFiltered).Clear();
			object obj2 = animations + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			animations.TUCK = animations.BIG_LAND;
			animations.JUMP = animations.RUN;
			List<string> tOP_MENU = (List<string>)(animations + 32);
			animations.TOP_MENU = tOP_MENU;
			animations.RUN = null;
			animations.LAND = animations.TOP_MENU;
			object obj4 = default;
			object obj5 = default;
			object obj6 = default;
			object obj7 = default;
			object obj9 = default;
			object rUN = default;
			object obj10 = default;
			while (true)
			{
				_ = 0;
				object obj3 = animations + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					if (obj4 == null)
					{
						goto IL_025a;
					}
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (obj5 != null)
							{
								continue;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag = obj6 != obj7;
				object obj8 = obj9;
				if (flag)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				animations.RUN = (List<string>)rUN;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_025a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj8 = obj10;
				break;
				IL_025a:
				object obj11 = animations + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5C5");
				return animations.GetRandomAnimationName(_animationNamesFiltered);
			}
			_ = 0;
			object obj12 = animations + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			string result = default;
			return result;
		}

		private List<string> GetRandomHoverJumps(List<string> hoverboardJump, List<string> hoverboardHangtime)
		{
			int size = hoverboardJump._size;
			if (hoverboardJump._size >= hoverboardHangtime._size)
			{
				size = hoverboardHangtime._size;
			}
			int index = UnityEngine.Random.Range(0, size);
			List<string> list = default;
			list._002Ector();
			string item = hoverboardJump.get_Item(index);
			list.Add(item);
			string item2 = hoverboardHangtime.get_Item(index);
			list.Add(item2);
			return list;
		}

		public Animations()
		{
			List<string> list = default;
			list._002Ector();
			list.Add("topMenu");
			TOP_MENU = list;
			List<string> list2 = default;
			list2._002Ector();
			list2.Add("introRun");
			INTRO_RUN = list2;
			List<string> list3 = default;
			list3._002Ector();
			list3.Add("run");
			RUN = list3;
			List<string> list4 = default;
			list4._002Ector();
			list4.Add("land");
			LAND = list4;
			List<string> list5 = default;
			list5._002Ector();
			list5.Add("land");
			BIG_LAND = list5;
			List<string> list6 = default;
			list6._002Ector();
			list6.Add("land");
			SMALL_LAND = list6;
			List<string> list7 = default;
			list7._002Ector();
			list7.Add("jump");
			JUMP = list7;
			List<string> list8 = default;
			list8._002Ector();
			list8.Add("jump");
			SMALL_JUMP = list8;
			List<string> list9 = default;
			list9._002Ector();
			list9.Add("tuck");
			TUCK = list9;
			List<string> list10 = default;
			list10._002Ector();
			list10.Add("hangtime");
			HANGTIME = list10;
			List<string> list11 = default;
			list11._002Ector();
			list11.Add("jump");
			DOUBLEJUMP = list11;
			List<string> list12 = default;
			list12._002Ector();
			list12.Add("hangtime");
			DOUBLEHANGTIME = list12;
			List<string> list13 = default;
			list13._002Ector();
			list13.Add("roll");
			ROLL = list13;
			List<string> list14 = default;
			list14._002Ector();
			list14.Add("dodgeLeft");
			DODGE_LEFT = list14;
			List<string> list15 = default;
			list15._002Ector();
			list15.Add("dodgeRight");
			DODGE_RIGHT = list15;
			List<string> list16 = default;
			list16._002Ector();
			list16.Add("dodgeRight");
			TURBO_HEADSTART1 = list16;
			List<string> list17 = default;
			list17._002Ector();
			list17.Add("dodgeRight");
			TURBO_HEADSTART2 = list17;
			List<string> list18 = default;
			list18._002Ector();
			list18.Add("grind");
			STARTGRIND = list18;
			List<string> list19 = default;
			list19._002Ector();
			list19.Add("grind");
			GRIND = list19;
			List<string> list20 = default;
			list20._002Ector();
			list20.Add("getOnBoard");
			GET_ON_BOARD = list20;
			List<string> list21 = default;
			list21._002Ector();
			list21.Add("hitMid");
			HIT_MID = list21;
			List<string> list22 = default;
			list22._002Ector();
			list22.Add("hitUpper");
			HIT_UPPER = list22;
			List<string> list23 = default;
			list23._002Ector();
			list23.Add("hitLower");
			HIT_LOWER = list23;
			List<string> list24 = default;
			list24._002Ector();
			list24.Add("hitMoving");
			HIT_MOVING = list24;
			List<string> list25 = default;
			list25._002Ector();
			list25.Add("stumble_low");
			STUMBLE = list25;
			List<string> list26 = default;
			list26._002Ector();
			list26.Add("stumbleFall");
			STUMBLEDEATH = list26;
			List<string> list27 = default;
			list27._002Ector();
			list27.Add("stumble");
			STUMBLE_MIX = list27;
			List<string> list28 = default;
			list28._002Ector();
			list28.Add("stumbleLeftSide");
			STUMBLE_LEFT_SIDE = list28;
			List<string> list29 = default;
			list29._002Ector();
			list29.Add("stumbleRightSide");
			STUMBLE_RIGHT_SIDE = list29;
			List<string> list30 = default;
			list30._002Ector();
			list30.Add("stumbleLeftCorner");
			STUMBLE_LEFT_CORNER = list30;
			List<string> list31 = default;
			list31._002Ector();
			list31.Add("stumbleRightCorner");
			STUMBLE_RIGHT_CORNER = list31;
			List<string> list32 = default;
			list32._002Ector();
			list32.Add("hold_magnet");
			HOLDMAGNET = list32;
			List<string> list33 = default;
			list33._002Ector();
			list33.Add("grind");
			WALLRIDELEFT = list33;
			List<string> list34 = default;
			list34._002Ector();
			list34.Add("grind");
			WALLRIDELEFTEXIT = list34;
			List<string> list35 = default;
			list35._002Ector();
			list35.Add("grind");
			WALLRIDERIGHT = list35;
			List<string> list36 = default;
			list36._002Ector();
			list36.Add("grind");
			WALLRIDERIGHTEXIT = list36;
			List<string> list37 = default;
			list37._002Ector();
			list37.Add("grind");
			WALLGRINDLEFT = list37;
			List<string> list38 = default;
			list38._002Ector();
			list38.Add("grind");
			WALLGRINDLEFTEXIT = list38;
			List<string> list39 = default;
			list39._002Ector();
			list39.Add("grind");
			WALLGRINDRIGHT = list39;
			List<string> list40 = default;
			list40._002Ector();
			list40.Add("grind");
			WALLGRINDRIGHTEXIT = list40;
			List<string> list41 = default;
			list41._002Ector();
			list41.Add("routeCelebrate");
			ROUTE_CELEBRATE = list41;
			List<string> list42 = default;
			list42._002Ector();
			list42.Add("bigAirTrick");
			BIG_AIR_TRICK = list42;
			List<string> list43 = default;
			list43._002Ector();
			list43.Add("routeEnter");
			ROUTE_ENTER = list43;
			List<string> list44 = default;
			list44._002Ector();
			list44.Add("routeExit");
			ROUTE_EXIT = list44;
			List<string> list45 = default;
			list45._002Ector();
			_animationNamesFiltered = list45;
			List<string> list46 = default;
			list46._002Ector();
			_animationNamesExcluded = list46;
		}
	}

	public interface ICustomAnimationClipList
	{
		void Initialize(Animations animations, CharacterRendering characterRendering);
	}

	[Serializable]
	public class AnimationClipLists
	{
		public AnimationClip[] topMenu;

		public AnimationClip[] introRun;

		public AnimationClip[] run;

		public AnimationClip[] jump;

		public AnimationClip[] hangtime;

		public AnimationClip[] doubleJump;

		public AnimationClip[] doubleHangtime;

		public AnimationClip[] landing;

		public AnimationClip[] dodgeLeft;

		public AnimationClip[] dodgeRight;

		public AnimationClip[] roll;

		public AnimationClip[] hitMid;

		public AnimationClip[] hitUpper;

		public AnimationClip[] hitLower;

		public AnimationClip[] hitMoving;

		public AnimationClip[] stumble;

		public AnimationClip[] stumbleMix;

		public AnimationClip[] stumbleDeath;

		public AnimationClip[] stumbleLeftSide;

		public AnimationClip[] stumbleRightSide;

		public AnimationClip[] stumbleLeftCorner;

		public AnimationClip[] stumbleRightCorner;

		public AnimationClip[] holdMagnet;
	}

	[Serializable]
	public class JetpackClips
	{
		public AnimationClip[] run;

		public AnimationClip[] dodgeLeft;

		public AnimationClip[] dodgeRight;

		public AnimationClip[] turboHeadstart1;

		public AnimationClip[] turboHeadstart2;
	}

	[Serializable]
	public class PogostickClips
	{
		public AnimationClip[] run;

		public AnimationClip[] hangtime;

		public AnimationClip[] dodgeLeft;

		public AnimationClip[] dodgeRight;
	}

	[Serializable]
	public class SuperSneaksClips
	{
		public AnimationClip[] run;
	}

	private sealed class _003COnRollPlayAnimation_003Ed__103(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CharacterRendering _003C_003E4__this;

		private string _003CrollAnimation_003E5__2;

		private float _003CendTime_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			CharacterRendering characterRendering = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_0283;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				characterRendering._isRolling = true;
				string roll = characterRendering.animations.Roll;
				_003CrollAnimation_003E5__2 = roll;
				string run = characterRendering.animations.Run;
				SuperSneakers superSneakers = characterRendering._superSneakers;
				float speed;
				if (~(superSneakers.isActive ? 1u : 0u) == 0)
				{
					speed = _DEFAULT_SPEED_RUN_ANIMATION;
				}
				else
				{
					Game game = characterRendering._game;
					Game.SpeedInfo speed2 = game.speed;
					speed = game.__currentSpeed / speed2.min;
				}
				characterRendering._characterSafeAnimation.SetSpeed(run, speed);
				characterRendering._characterSafeAnimation.CrossFade(_003CrollAnimation_003E5__2, 0.1f);
				Hoverboard hoverboard = characterRendering._hoverboard;
				if (~(hoverboard.isActive ? 1u : 0u) == 0)
				{
					characterRendering._characterSafeAnimation.CrossFadeQueued(run, 0.2f);
					if (characterRendering._hoverboardSafeAnimation.HasAnimation())
					{
						string hoverboardAnimationName = characterRendering.GetHoverboardAnimationName(_003CrollAnimation_003E5__2);
						characterRendering._hoverboardSafeAnimation.CrossFade(hoverboardAnimationName, 0.1f);
						string hoverboardAnimationName2 = characterRendering.GetHoverboardAnimationName(run);
						Hoverboard hoverboard2 = characterRendering._hoverboard;
						float fadeLength = 0.2f;
						if (!hoverboard2.isActive)
						{
							fadeLength = 0f;
						}
						characterRendering._hoverboardSafeAnimation.CrossFadeQueued(hoverboardAnimationName2, fadeLength);
					}
				}
				else
				{
					characterRendering._characterSafeAnimation.CrossFadeQueued(run, 0.1f);
				}
				float time = Time.time;
				AnimationState animationState = characterRendering._characterSafeAnimation.GetAnimationState(_003CrollAnimation_003E5__2);
				float length = animationState.length;
				float num = time + length;
				_003CendTime_003E5__3 = num;
			}
			float time2 = Time.time;
			if (time2 < _003CendTime_003E5__3)
			{
				AnimationState animationState2 = characterRendering._characterSafeAnimation.GetAnimationState(_003CrollAnimation_003E5__2);
				if (animationState2.enabled && characterRendering._isRolling)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
			}
			characterRendering.EndRollAnimation();
			goto IL_0283;
			IL_0283:
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private sealed class _003C_003Ec__DisplayClass125_0
	{
		public AnimationState caught;

		internal void _003CCatchPlayerAnimStarter_003Eb__0(float t)
		{
			float num = Math.Min(t, 1f);
			bool flag = t < 0f;
			float num2 = 0f;
			if (!flag)
			{
				num2 = num;
			}
			float num3 = num2 * 1f;
			float weight = num3 + 0f;
			caught.weight = weight;
		}
	}

	private sealed class _003CCatchPlayerAnimStarter_003Ed__125(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public AnimationState caught;

		public float delay;

		public CharacterRendering _003C_003E4__this;

		private _003C_003Ec__DisplayClass125_0 _003C_003E8__1;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					throw new ArgumentException();
				}
				return false;
			}
			_003C_003E1__state = -1;
			_003C_003Ec__DisplayClass125_0 obj = default;
			_003C_003E8__1 = obj;
			_003C_003Ec__DisplayClass125_0 obj2 = _003C_003E8__1;
			obj2.caught = caught;
			_003C_003Ec__DisplayClass125_0 obj3 = _003C_003E8__1;
			obj3.caught.weight = 0f;
			_003C_003Ec__DisplayClass125_0 obj4 = _003C_003E8__1;
			obj4.caught.normalizedTime = 0f;
			_003C_003Ec__DisplayClass125_0 obj5 = _003C_003E8__1;
			obj5.caught.enabled = true;
			_ = delay;
			object obj6 = default;
			_003C_003E2__current = obj6;
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private sealed class _003CRouteCelebrate_Coroutine_003Ed__146(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CharacterRendering _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num;
			if (_003C_003E1__state != 0)
			{
				bool flag = _003C_003E1__state == 1;
				num = -1;
				if (!flag)
				{
					goto IL_00e7;
				}
			}
			else
			{
				CharacterRendering characterRendering = _003C_003E4__this;
				_003C_003E1__state = -1;
				string routeCelebrate = characterRendering.animations.RouteCelebrate;
				if (characterRendering._characterSafeAnimation.HasAnimationClip(routeCelebrate))
				{
					characterRendering._characterSafeAnimation.CrossFade(routeCelebrate, 0.1f);
				}
				_003C_003E2__current = null;
				num = 1;
			}
			_003C_003E1__state = num;
			goto IL_00e7;
			IL_00e7:
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private sealed class _003CTeleboardStartScale_003Ed__150(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CharacterRendering _003C_003E4__this;

		public float duration;

		public float gameSpeed;

		private float _003Ctime_003E5__2;

		private Vector3 _003Cmodel1position_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0098: Expected VT, but got I
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Expected VT, but got Unknown
			//IL_0372: Unknown result type (might be due to invalid IL or missing references)
			//IL_0377: Expected VT, but got Unknown
			//IL_03e1: Expected I, but got Obj
			//IL_0427: Unknown result type (might be due to invalid IL or missing references)
			//IL_042c: Expected VT, but got Unknown
			//IL_045e: Expected I, but got Obj
			//IL_0490: Expected F4, but got I
			//IL_048b: Expected native int or pointer, but got VT
			//IL_04ab: Expected F4, but got I
			//IL_04a6: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj - 144);
			CharacterRendering characterRendering = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_0296;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003Ctime_003E5__2 = 0f;
				_003C_003E1__state = -1;
				Vector3 currentTransformPosition = characterRendering._character.CurrentTransformPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
				_003Cmodel1position_003E5__3 = (Vector3)0;
				Transform transform = characterRendering._characterModel.transform;
				HierarchyUtility.ReparentByHierarchyPathType(transform, HierarchyPathType.Null);
				characterRendering._characterSafeAnimation.Stop();
			}
			if (_003Ctime_003E5__2 < duration)
			{
				float deltaTime = Time.deltaTime;
				float num = (_003Ctime_003E5__2 += deltaTime);
				if (~(characterRendering._isTeleportFxActive ? 1u : 0u) == 0)
				{
					Vector3 currentTransformPosition2 = characterRendering._character.CurrentTransformPosition;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
					_ = 0;
					Transform transform2 = characterRendering._characterModel.transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.CharacterRendering+<TeleboardStartScale>d__150)+28]");
					_ = 0;
					_ = _003Cmodel1position_003E5__3;
					Vector3 position = vector + 48;
					transform2.position = position;
					Transform transform3 = characterRendering._characterModel.transform;
					float num2 = num / duration;
					float num3 = Math.Min(num2, 1f);
					bool flag = num2 < 0f;
					float num4 = 0f;
					if (!flag)
					{
						num4 = num3;
					}
					float num5 = num4 * 0.5f;
					float num6 = 1f - num5;
					float num7 = 1f - num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
					_ = 0;
					float num8 = num4 * 0.5f;
					float num9 = num8 + 1f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
					_ = 0;
					Vector3 localScale = vector + 32;
					transform3.localScale = localScale;
					float value = num4 * 0.2f;
					characterRendering.teleboardFXMaterial.SetFloat("Offset", value);
					if (num4 == 1f)
					{
						Transform transform4 = characterRendering._characterModel.transform;
						Transform transform5 = characterRendering.transform;
						transform4.parent = transform5;
						Transform transform6 = characterRendering._characterModel.transform;
						nint num10 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S0_v61 (Il2CppClass<UnityEngine.Vector3>)+5C]");
						nint num11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v62 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
						_ = 0;
						_ = Vector3.zeroVector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
						_ = 0;
						Vector3 localPosition = vector + 16;
						transform6.localPosition = localPosition;
						Transform transform7 = characterRendering._characterModel.transform;
						nint num12 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S0_v77 (Il2CppClass<UnityEngine.Vector3>)+5C]");
						nint num13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S0_v78 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
						((Vector3*)(nint)vector)->z = 0f;
						_ = Vector3.zeroVector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
						((Vector3*)(nint)vector)->x = 0f;
						transform7.localScale = vector;
						Character character = characterRendering._character;
						Variable<bool> isGrounded = character.IsGrounded;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ S0_v89 (Variable`1<System.Boolean>)+8]");
						if ((nint)0 != 0)
						{
							characterRendering.OnRun();
						}
						characterRendering.HandleOnTeleboardEnd(duration, gameSpeed);
					}
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
				}
				else
				{
					characterRendering.ResetTeleportFx();
				}
			}
			goto IL_0296;
			IL_0296:
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private sealed class _003CTeleboardEndScale_003Ed__152(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public CharacterRendering _003C_003E4__this;

		private float _003Ctime_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			CharacterRendering characterRendering = _003C_003E4__this;
			float num;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_0067;
				}
				_003C_003E1__state = -1;
				num = _003Ctime_003E5__2;
			}
			else
			{
				_003Ctime_003E5__2 = 0f;
				_003C_003E1__state = -1;
				num = 0f;
			}
			if (num < duration)
			{
				float deltaTime = Time.deltaTime;
				float num2 = (_003Ctime_003E5__2 = num + deltaTime) / duration;
				float num3 = default;
				if (!(num2 < 0f))
				{
					bool flag = num2 > 1f;
					bool flag2 = !flag;
					num3 = num2;
					if (!flag2)
					{
						num3 = 1f;
					}
				}
				float value = num3 * 0.2f;
				characterRendering.teleboardFXMaterial.SetFloat("Offset", value);
				if (num3 == 1f)
				{
					characterRendering.ResetCharacterTeleportFX();
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			goto IL_0067;
			IL_0067:
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private const int GrindIndexCornerGrindLeft = 0;

	private const int GrindIndexOnRail = 1;

	private const int GrindIndexCornerGrindRight = 2;

	private const float FaceLengthJumpAnimation = 0.15f;

	private const float FadeLengthJumpAnimationAfterTuck = 1f;

	private const float CameraShakeAmountForTurboHeadstart = 20f;

	private AnimationClipLists defaultAnimations;

	private JetpackClips jetpackAnimations;

	private SuperSneaksClips SuperSneaksAnimations;

	private PogostickClips pogostickClips;

	private GameObject teleboardWarpPrefab;

	private Material teleboardFXMaterial;

	private AnimationCurve jetpackParticleOffsetCurve;

	private GameObject characterModelPrefab;

	private GameObject characterRenderingEffectsPrefab;

	private GameObject _grindSparksPrefab;

	public Animations animations;

	private CharacterModel _characterModel;

	private static CharacterRendering _instance;

	private Game _game;

	private Character _character;

	private Hoverboard _hoverboard;

	private SuperSneakers _superSneakers;

	private JetpackState _jetpackState;

	private PogoStickState _pogoStickState;

	private FollowingGuard _followingGuard;

	private CharacterController _characterController;

	private MeshRenderer _shadowMeshRenderer;

	private CharacterRenderingEffects _characterRenderingEffects;

	private Revive _revive;

	private SafeAnimation _characterSafeAnimation;

	private SafeAnimation _hoverboardSafeAnimation;

	private bool _initialized;

	private HoverboardRendering _defaultHoverboardRendering;

	private HoverboardRendering.AbilityAnimationList _defaultHoverboardAnimationList;

	private GameObject _teleboardWarpGameObject;

	private Renderer _telewarpRenderer;

	private AnimationState _teleboardAnimation;

	private Vector3 _teleboardWarpPosition;

	private CharacterCamera _characterCamera;

	private HoverboardRendering _hoverboardRendering;

	private List<AnimationClip> _addedAnimClipsNames;

	private HoverboardBundle _cachedHoverboardBundle;

	private Hoverboard.BoardAbility[] _currentBoardAbilities;

	private Vector3 _initRot;

	private Vector3 _initScale;

	private ParticleSystem[] _killParticleSystem;

	private AnimationState _caughtAnimationState;

	private Material _cachedModelMaterial;

	private Material[] _cachedHeadMaterials;

	private Material _cachedCustomizationMaterial;

	private Material _cachedHoverboardMaterial;

	private Material _cachedSupersneakersMaterial;

	private Material _cachedDoubleJumperMaterial;

	private Material[] _cachedCustomHoverboardModelMaterials;

	private Transform _extraTeleportFX;

	private bool _isTeleportFxActive;

	private bool _isCachedCustomizationState;

	private bool _isDoublejump;

	private bool _isRolling;

	private bool _isDeath;

	private static float _DEFAULT_SPEED_RUN_ANIMATION = 1f;

	private RouteManager _routeManager;

	private string _lastGrindAnimation;

	private GameObject _grindSparks;

	private string jumpAnimation;

	private string hangtimeAnimation;

	private bool _queuedHangtime;

	public CharacterModel CharacterModel => _characterModel;

	public Animation CharacterAnimation
	{
		get
		{
			SafeAnimation characterSafeAnimation = _characterSafeAnimation;
			return characterSafeAnimation._animation;
		}
	}

	public static CharacterRendering Instance
	{
		get
		{
			if (_instance == null)
			{
				CharacterRendering instance = Utils.FindObject<CharacterRendering>();
				_instance = instance;
			}
			return _instance;
		}
	}

	public SafeAnimation CharacterSafeAnimation => _characterSafeAnimation;

	public SafeAnimation HoverboardSafeAnimation => _hoverboardSafeAnimation;

	public void Initialize()
	{
		//IL_00dd: Expected VT, but got Obj
		//IL_00e7: Expected Obj, but got VT
		_instance = this;
		Game instance = Game.Instance;
		_game = instance;
		Character instance2 = Character.Instance;
		_character = instance2;
		CharacterController charactercontroller = Game.Charactercontroller;
		_characterController = charactercontroller;
		Hoverboard instance3 = Hoverboard.Instance;
		_hoverboard = instance3;
		SuperSneakers superSneakers = Utils.FindObject<SuperSneakers>(this);
		_superSneakers = superSneakers;
		JetpackState instance4 = JetpackState.Instance;
		_jetpackState = instance4;
		PogoStickState instance5 = PogoStickState.Instance;
		_pogoStickState = instance5;
		FollowingGuard instance6 = FollowingGuard.Instance;
		_followingGuard = instance6;
		Revive instance7 = Revive.Instance;
		_revive = instance7;
		CharacterCamera instance8 = CharacterCamera.Instance;
		_characterCamera = instance8;
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		_routeManager = (RouteManager)val;
		throw new ArgumentException();
	}

	protected void Awake()
	{
		_instance = this;
	}

	protected void OnDestroy()
	{
		if (_routeManager != null)
		{
			throw new ArgumentException();
		}
	}

	public CharacterModel RecreateCharacterModel()
	{
		InitializeCharacterModel();
		InitializeAnimations();
		_characterModel.RecreateCharacter();
		_characterRenderingEffects.RecreateModel(_characterModel);
		OnStageMenuSequence();
		return _characterModel;
	}

	private void DebugLog(string message)
	{
	}

	private unsafe void InitializeCharacterModel()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00b0: Expected I, but got Obj
		//IL_00e2: Expected F4, but got I
		//IL_00dd: Expected native int or pointer, but got VT
		//IL_00fd: Expected F4, but got I
		//IL_00f8: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		GameObject gameObject = UnityEngine.Object.Instantiate(characterModelPrefab);
		Transform transform = gameObject.transform;
		Transform parent = base.transform;
		transform.parent = parent;
		Transform transform2 = gameObject.transform;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v21 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v22 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		transform2.localPosition = vector;
		nint num3 = 0;
		nint num4 = 0;
		IntPtr intPtr = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v79 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		ParticleSystem[] killParticleSystem = default;
		_killParticleSystem = killParticleSystem;
		CharacterModel component = gameObject.GetComponent<CharacterModel>();
		_characterModel = component;
		CharacterModel characterModel = _characterModel;
		_shadowMeshRenderer = characterModel._meshBlobShadow;
		CharacterModel characterModel2 = _characterModel;
		SafeAnimation safeAnimation = default;
		safeAnimation._002Ector(characterModel2._characterAnimation, loggingEnabled: false);
		_characterSafeAnimation = safeAnimation;
		SafeAnimation safeAnimation2 = default;
		safeAnimation2._002Ector(null, loggingEnabled: false);
		_hoverboardSafeAnimation = safeAnimation2;
	}

	private void InitializeCharacterRenderingEffects()
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(characterRenderingEffectsPrefab);
		Transform childTransform = gameObject.transform;
		HierarchyUtility.ReparentByHierarchyPathType(childTransform, HierarchyPathType.Dynamic);
		CharacterRenderingEffects component = gameObject.GetComponent<CharacterRenderingEffects>();
		_characterRenderingEffects = component;
		_characterRenderingEffects.Initialize(_characterModel);
		GameObject teleboardWarpGameObject = UnityEngine.Object.Instantiate(teleboardWarpPrefab);
		_teleboardWarpGameObject = teleboardWarpGameObject;
		Transform transform = _teleboardWarpGameObject.transform;
		Transform parent = _character.transform;
		transform.parent = parent;
		Animation component2 = _teleboardWarpGameObject.GetComponent<Animation>();
		AnimationState teleboardAnimation = component2.get_Item("teleboardWarp");
		_teleboardAnimation = teleboardAnimation;
		_teleboardAnimation.normalizedTime = 0f;
		_teleboardAnimation.weight = 1f;
		_teleboardAnimation.enabled = true;
		_characterSafeAnimation.SetSpeed(_teleboardAnimation, 0f);
		_teleboardWarpGameObject.SetActive(value: false);
	}

	private void InitializeAnimations()
	{
		((List<T>)(object)_addedAnimClipsNames).Clear();
		Animations animations = this.animations;
		SuperSneaksClips superSneaksAnimations = SuperSneaksAnimations;
		List<string> rUN = InitializeClips(superSneaksAnimations.run);
		animations.RUN = rUN;
		Animations animations2 = this.animations;
		AnimationClipLists animationClipLists = defaultAnimations;
		List<string> rUN2 = InitializeClips(animationClipLists.run);
		animations2.RUN = rUN2;
		Animations animations3 = this.animations;
		AnimationClipLists animationClipLists2 = defaultAnimations;
		List<string> iNTRO_RUN = InitializeClips(animationClipLists2.introRun);
		animations3.INTRO_RUN = iNTRO_RUN;
		Animations animations4 = this.animations;
		AnimationClipLists animationClipLists3 = defaultAnimations;
		List<string> lAND = InitializeClips(animationClipLists3.landing);
		animations4.LAND = lAND;
		Animations animations5 = this.animations;
		AnimationClipLists animationClipLists4 = defaultAnimations;
		List<string> bIG_LAND = InitializeClips(animationClipLists4.landing);
		animations5.BIG_LAND = bIG_LAND;
		Animations animations6 = this.animations;
		AnimationClipLists animationClipLists5 = defaultAnimations;
		List<string> sMALL_LAND = InitializeClips(animationClipLists5.landing);
		animations6.SMALL_LAND = sMALL_LAND;
		Animations animations7 = this.animations;
		AnimationClipLists animationClipLists6 = defaultAnimations;
		List<string> jUMP = InitializeClips(animationClipLists6.jump);
		animations7.JUMP = jUMP;
		Animations animations8 = this.animations;
		AnimationClipLists animationClipLists7 = defaultAnimations;
		List<string> sMALL_JUMP = InitializeClips(animationClipLists7.jump);
		animations8.SMALL_JUMP = sMALL_JUMP;
		Animations animations9 = this.animations;
		AnimationClipLists animationClipLists8 = defaultAnimations;
		List<string> hANGTIME = InitializeClips(animationClipLists8.hangtime);
		animations9.HANGTIME = hANGTIME;
		Animations animations10 = this.animations;
		AnimationClipLists animationClipLists9 = defaultAnimations;
		List<string> dOUBLEJUMP = InitializeClips(animationClipLists9.doubleJump);
		animations10.DOUBLEJUMP = dOUBLEJUMP;
		Animations animations11 = this.animations;
		AnimationClipLists animationClipLists10 = defaultAnimations;
		List<string> dOUBLEHANGTIME = InitializeClips(animationClipLists10.doubleHangtime);
		animations11.DOUBLEHANGTIME = dOUBLEHANGTIME;
		Animations animations12 = this.animations;
		AnimationClipLists animationClipLists11 = defaultAnimations;
		List<string> rOLL = InitializeClips(animationClipLists11.roll);
		animations12.ROLL = rOLL;
		Animations animations13 = this.animations;
		AnimationClipLists animationClipLists12 = defaultAnimations;
		List<string> dODGE_LEFT = InitializeClips(animationClipLists12.dodgeLeft);
		animations13.DODGE_LEFT = dODGE_LEFT;
		Animations animations14 = this.animations;
		AnimationClipLists animationClipLists13 = defaultAnimations;
		List<string> dODGE_RIGHT = InitializeClips(animationClipLists13.dodgeRight);
		animations14.DODGE_RIGHT = dODGE_RIGHT;
		Animations animations15 = this.animations;
		AnimationClipLists animationClipLists14 = defaultAnimations;
		List<string> tOP_MENU = InitializeClips(animationClipLists14.topMenu);
		animations15.TOP_MENU = tOP_MENU;
		Animations animations16 = this.animations;
		AnimationClipLists animationClipLists15 = defaultAnimations;
		List<string> hIT_MID = InitializeClips(animationClipLists15.hitMid);
		animations16.HIT_MID = hIT_MID;
		Animations animations17 = this.animations;
		AnimationClipLists animationClipLists16 = defaultAnimations;
		List<string> hIT_UPPER = InitializeClips(animationClipLists16.hitUpper);
		animations17.HIT_UPPER = hIT_UPPER;
		Animations animations18 = this.animations;
		AnimationClipLists animationClipLists17 = defaultAnimations;
		List<string> hIT_LOWER = InitializeClips(animationClipLists17.hitLower);
		animations18.HIT_LOWER = hIT_LOWER;
		Animations animations19 = this.animations;
		AnimationClipLists animationClipLists18 = defaultAnimations;
		List<string> hIT_MOVING = InitializeClips(animationClipLists18.hitMoving);
		animations19.HIT_MOVING = hIT_MOVING;
		Animations animations20 = this.animations;
		AnimationClipLists animationClipLists19 = defaultAnimations;
		List<string> sTUMBLE = InitializeClips(animationClipLists19.stumble);
		animations20.STUMBLE = sTUMBLE;
		Animations animations21 = this.animations;
		AnimationClipLists animationClipLists20 = defaultAnimations;
		List<string> sTUMBLEDEATH = InitializeClips(animationClipLists20.stumbleDeath);
		animations21.STUMBLEDEATH = sTUMBLEDEATH;
		Animations animations22 = this.animations;
		AnimationClipLists animationClipLists21 = defaultAnimations;
		List<string> sTUMBLE_MIX = InitializeClips(animationClipLists21.stumbleMix);
		animations22.STUMBLE_MIX = sTUMBLE_MIX;
		Animations animations23 = this.animations;
		AnimationClipLists animationClipLists22 = defaultAnimations;
		List<string> sTUMBLE_LEFT_SIDE = InitializeClips(animationClipLists22.stumbleLeftSide);
		animations23.STUMBLE_LEFT_SIDE = sTUMBLE_LEFT_SIDE;
		Animations animations24 = this.animations;
		AnimationClipLists animationClipLists23 = defaultAnimations;
		List<string> sTUMBLE_RIGHT_SIDE = InitializeClips(animationClipLists23.stumbleRightSide);
		animations24.STUMBLE_RIGHT_SIDE = sTUMBLE_RIGHT_SIDE;
		Animations animations25 = this.animations;
		AnimationClipLists animationClipLists24 = defaultAnimations;
		List<string> sTUMBLE_LEFT_CORNER = InitializeClips(animationClipLists24.stumbleLeftCorner);
		animations25.STUMBLE_LEFT_CORNER = sTUMBLE_LEFT_CORNER;
		Animations animations26 = this.animations;
		AnimationClipLists animationClipLists25 = defaultAnimations;
		List<string> sTUMBLE_RIGHT_CORNER = InitializeClips(animationClipLists25.stumbleRightCorner);
		animations26.STUMBLE_RIGHT_CORNER = sTUMBLE_RIGHT_CORNER;
		Animations animations27 = this.animations;
		AnimationClipLists animationClipLists26 = defaultAnimations;
		List<string> hOLDMAGNET = InitializeClips(animationClipLists26.holdMagnet);
		animations27.HOLDMAGNET = hOLDMAGNET;
		AnimationState animationState = _characterSafeAnimation.GetAnimationState("stumble");
		CharacterModel characterModel = _characterModel;
		animationState.AddMixingTransform(characterModel._spineTransform);
		AnimationState animationState2 = _characterSafeAnimation.GetAnimationState("stumble");
		animationState2.layer = 2;
		AnimationState animationState3 = _characterSafeAnimation.GetAnimationState("stumble");
		animationState3.weight = 1f;
		AnimationState animationState4 = _characterSafeAnimation.GetAnimationState("stumbleCornerLeft");
		CharacterModel characterModel2 = _characterModel;
		animationState4.AddMixingTransform(characterModel2._spineTransform);
		AnimationState animationState5 = _characterSafeAnimation.GetAnimationState("stumbleCornerLeft");
		animationState5.layer = 2;
		AnimationState animationState6 = _characterSafeAnimation.GetAnimationState("stumbleCornerLeft");
		animationState6.weight = 1f;
		AnimationState animationState7 = _characterSafeAnimation.GetAnimationState("stumbleCornerRight");
		CharacterModel characterModel3 = _characterModel;
		animationState7.AddMixingTransform(characterModel3._spineTransform);
		AnimationState animationState8 = _characterSafeAnimation.GetAnimationState("stumbleCornerRight");
		animationState8.layer = 2;
		AnimationState animationState9 = _characterSafeAnimation.GetAnimationState("stumbleCornerRight");
		animationState9.weight = 1f;
	}

	public List<string> InitializeClips(AnimationClip[] clips, IEnumerable<string> excludedAnimationNames = null)
	{
		//IL_00b6: Expected Obj, but got I
		//IL_0141: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_00f5: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I
		List<string> list = default;
		list._002Ector();
		object obj = default;
		object obj4 = default;
		for (; clips.Length > (nint)obj; obj = obj4 + 1)
		{
			object obj2 = obj << 2;
			object obj3 = (object)clips + obj2;
			if (excludedAnimationNames != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v14+10]");
				string value = ((UnityEngine.Object)0).name;
				if (Enumerable.Contains(excludedAnimationNames, value))
				{
					continue;
				}
			}
			List<AnimationClip> addedAnimClipsNames = _addedAnimClipsNames;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v14+10]");
			if (!addedAnimClipsNames.Contains((AnimationClip)0))
			{
				List<AnimationClip> addedAnimClipsNames2 = _addedAnimClipsNames;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v14+10]");
				addedAnimClipsNames2.Add((AnimationClip)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v14+10]");
				string newName = ((UnityEngine.Object)0).name;
				SafeAnimation characterSafeAnimation = _characterSafeAnimation;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v14+10]");
				characterSafeAnimation.AddClip((AnimationClip)0, newName);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v14+10]");
			string item = ((UnityEngine.Object)0).name;
			list.Add(item);
		}
		return list;
	}

	private string GetHoverboardAnimationName(string animationName)
	{
		AnimationClip animationClip = _hoverboardSafeAnimation.GetAnimationClip(animationName);
		if (animationClip != null)
		{
			return animationName;
		}
		Animations animations = this.animations;
		return animations.DEFAULT_HOVERBOARD_ANIMATION;
	}

	private bool HasHoverboardAnimation(string animationToCheck)
	{
		if (animationToCheck != null)
		{
			SafeAnimation hoverboardSafeAnimation = _hoverboardSafeAnimation;
			AnimationClip clip = hoverboardSafeAnimation._animation.GetClip(animationToCheck);
			return clip != null;
		}
		return false;
	}

	private void OnIntroRun()
	{
		//IL_0013: Expected Obj, but got I4
		//IL_0044: Expected Obj, but got I
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		ParticleSystem[] killParticleSystem = _killParticleSystem;
		object obj = 0;
		while (killParticleSystem.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)killParticleSystem + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v21+10]");
			((ParticleSystem)0).Stop();
			object obj4 = obj + 1;
			obj = obj4;
		}
		OnSwitchToRunning();
		string run = animations.Run;
		_characterSafeAnimation.CrossFadeQueued(run, 0.2f);
		GameObject sprayCanModel = _characterModel.SprayCanModel;
		sprayCanModel.SetActive(value: false);
		_characterModel.StopEyeAnimations();
		_isDeath = false;
	}

	public void OnRun()
	{
		Character character = _character;
		if (!character._isFalling && !character.__isJumping && !character._isRolling && !_isDeath)
		{
			Run();
		}
	}

	public void Run()
	{
		string run = animations.Run;
		Game game = _game;
		Game.SpeedInfo speed = game.speed;
		float speed2 = game.__currentSpeed / speed.min;
		_characterSafeAnimation.SetSpeed(run, speed2);
		if (_characterController.isGrounded)
		{
			SuperSneakers superSneakers = _superSneakers;
			if (~(superSneakers.isActive ? 1u : 0u) == 0)
			{
				_characterSafeAnimation.SetSpeed(run, _DEFAULT_SPEED_RUN_ANIMATION);
			}
			_characterSafeAnimation.CrossFade(run);
			if (_hoverboardSafeAnimation.HasAnimation())
			{
				string hoverboardAnimationName = GetHoverboardAnimationName(run);
				_hoverboardSafeAnimation.CrossFade(hoverboardAnimationName);
			}
		}
	}

	private void OnChangeTrack(Character.OnChangeTrackDirection direction)
	{
		Character character = _character;
		Variable<bool> isGrounded = character.IsGrounded;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v9 (Variable`1<System.Boolean>)+8]");
		if ((nint)0 == 0)
		{
			JetpackState instance = JetpackState.Instance;
			if (~(instance.isActive ? 1u : 0u) != 0)
			{
				goto IL_0208;
			}
		}
		PogoStickState instance2 = PogoStickState.Instance;
		string text;
		if (!instance2.isActive && !_isDeath)
		{
			text = ((direction != Character.OnChangeTrackDirection.Left) ? animations.DodgeRight : animations.DodgeLeft);
			Hoverboard hoverboard = _hoverboard;
			if (!hoverboard.isActive)
			{
				JetpackState jetpackState = _jetpackState;
				if (!jetpackState.isActive)
				{
					Game game = _game;
					Game.SpeedInfo speed = game.speed;
					float speed2 = game.__currentSpeed / speed.min;
					_characterSafeAnimation.SetSpeed(text, speed2);
					goto IL_0141;
				}
			}
			_characterSafeAnimation.SetSpeed(text, _DEFAULT_SPEED_RUN_ANIMATION);
			goto IL_0141;
		}
		goto IL_0208;
		IL_0208:
		Character character2 = _character;
		if (character2.__isJumping)
		{
			return;
		}
		string run = animations.Run;
		Hoverboard hoverboard2 = _hoverboard;
		if (!hoverboard2.isActive)
		{
			JetpackState jetpackState2 = _jetpackState;
			if (!jetpackState2.isActive)
			{
				Game game2 = _game;
				Game.SpeedInfo speed3 = game2.speed;
				float speed4 = game2.__currentSpeed / speed3.min;
				_characterSafeAnimation.SetSpeed(run, speed4);
				goto IL_02cf;
			}
		}
		_characterSafeAnimation.SetSpeed(run, _DEFAULT_SPEED_RUN_ANIMATION);
		goto IL_02cf;
		IL_02cf:
		Game game3 = _game;
		CharacterModifierCollection modifiers = game3._modifiers;
		bool flag = game3._modifiers.IsActive(modifiers.hoverboard);
		float fadeLength = 0.4f;
		if (!flag)
		{
			fadeLength = 0.02f;
		}
		_characterSafeAnimation.CrossFadeQueued(run, fadeLength);
		Hoverboard hoverboard3 = _hoverboard;
		if (~(hoverboard3.isActive ? 1u : 0u) == 0 && _hoverboardSafeAnimation.HasAnimation())
		{
			string hoverboardAnimationName = GetHoverboardAnimationName(run);
			_hoverboardSafeAnimation.CrossFadeQueued(hoverboardAnimationName, 0.02f);
		}
		return;
		IL_0141:
		if (!_characterSafeAnimation.IsPlaying(jumpAnimation))
		{
			_characterSafeAnimation.CrossFade(text, 0.2f);
		}
		Hoverboard hoverboard4 = _hoverboard;
		if (~(hoverboard4.isActive ? 1u : 0u) == 0 && _hoverboardSafeAnimation.HasAnimation())
		{
			string hoverboardAnimationName2 = GetHoverboardAnimationName(text);
			_hoverboardSafeAnimation.CrossFade(hoverboardAnimationName2, 0.2f);
		}
		goto IL_0208;
	}

	private void OnStumble(Character.StumbleType stumbleType, Character.StumbleHorizontalHit horizontalHit, Character.StumbleVerticalHit verticalHit, string colliderName, bool safeStumble)
	{
		//IL_000e: Expected Obj, but got I4
		object obj = stumbleType - 1;
		if (stumbleType != Character.StumbleType.Bush)
		{
			if ((nint)obj == 1)
			{
				Game game = _game;
				CharacterModifierCollection modifiers = game._modifiers;
				if (!game._modifiers.IsActive(modifiers.hoverboard) && !_game.IsInJetpackMode && !_game.IsInPogostickMode)
				{
					switch (horizontalHit)
					{
					case Character.StumbleHorizontalHit.Left:
					case Character.StumbleHorizontalHit.LeftCorner:
					{
						string stumbleLeftSide = animations.StumbleLeftSide;
						_characterSafeAnimation.CrossFade(stumbleLeftSide, 0.2f);
						break;
					}
					case Character.StumbleHorizontalHit.RightCorner:
					case Character.StumbleHorizontalHit.Right:
					{
						string stumbleRightSide = animations.StumbleRightSide;
						_characterSafeAnimation.CrossFade(stumbleRightSide, 0.2f);
						break;
					}
					}
				}
				Character character = _character;
				if (!character.__isJumping)
				{
					string run = animations.Run;
					Game game2 = _game;
					CharacterModifierCollection modifiers2 = game2._modifiers;
					bool flag = game2._modifiers.IsActive(modifiers2.hoverboard);
					float fadeLength = 0.4f;
					if (!flag)
					{
						fadeLength = 0.02f;
					}
					_characterSafeAnimation.CrossFadeQueued(run, fadeLength);
				}
				return;
			}
			if (horizontalHit != Character.StumbleHorizontalHit.Left)
			{
				if (horizontalHit != Character.StumbleHorizontalHit.LeftCorner)
				{
					if (horizontalHit == Character.StumbleHorizontalHit.Center)
					{
						switch (verticalHit)
						{
						default:
							return;
						case Character.StumbleVerticalHit.Lower:
							break;
						case Character.StumbleVerticalHit.Middle:
						{
							string hitMid = animations.HitMid;
							_characterSafeAnimation.CrossFade(hitMid, 0.07f);
							if (safeStumble)
							{
								string run2 = animations.Run;
								_characterSafeAnimation.CrossFadeQueued(run2, 0.3f);
							}
							return;
						}
						case Character.StumbleVerticalHit.Upper:
						{
							string hitUpper = animations.HitUpper;
							_characterSafeAnimation.CrossFade(hitUpper, 0.07f);
							return;
						}
						}
						Game game3 = _game;
						CharacterModifierCollection modifiers3 = game3._modifiers;
						string animationName = ((!game3._modifiers.IsActive(modifiers3.hoverboard)) ? animations.Stumble : animations.StumbleMix);
						_characterSafeAnimation.CrossFade(animationName, 0.05f);
						goto IL_05f9;
					}
					switch (horizontalHit)
					{
					case Character.StumbleHorizontalHit.Right:
					{
						Game game4 = _game;
						CharacterModifierCollection modifiers4 = game4._modifiers;
						string animationName2 = ((!game4._modifiers.IsActive(modifiers4.hoverboard)) ? animations.StumbleRightSide : animations.StumbleRightCorner);
						_characterSafeAnimation.Play(animationName2);
						break;
					}
					case Character.StumbleHorizontalHit.RightCorner:
					{
						string stumbleRightCorner = animations.StumbleRightCorner;
						_characterSafeAnimation.Play(stumbleRightCorner);
						break;
					}
					}
				}
				else
				{
					string stumbleLeftCorner = animations.StumbleLeftCorner;
					_characterSafeAnimation.Play(stumbleLeftCorner);
				}
			}
			else
			{
				Game game5 = _game;
				CharacterModifierCollection modifiers5 = game5._modifiers;
				string animationName3 = ((!game5._modifiers.IsActive(modifiers5.hoverboard)) ? animations.StumbleLeftSide : animations.StumbleLeftCorner);
				_characterSafeAnimation.Play(animationName3);
			}
			string run3 = animations.Run;
			_characterSafeAnimation.PlayQueued(run3);
			return;
		}
		string stumbleMix = animations.StumbleMix;
		_characterSafeAnimation.CrossFade(stumbleMix, 0.05f);
		goto IL_05f9;
		IL_05f9:
		string run4 = animations.Run;
		_characterSafeAnimation.CrossFadeQueued(run4, 0.5f);
	}

	private void Game_OnEndStumbleDeathSequence()
	{
		_isDeath = true;
		string stumbleDeath = animations.StumbleDeath;
		_characterSafeAnimation.CrossFade(stumbleDeath, 0.2f);
	}

	private void OnChangeIsGrounded(bool isGrounded)
	{
		if (_shadowMeshRenderer != null)
		{
			_shadowMeshRenderer.enabled = isGrounded;
		}
	}

	private void OnRoll()
	{
		IEnumerator routine = OnRollPlayAnimation();
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator OnRollPlayAnimation()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void ToggleDust(bool active)
	{
		_characterRenderingEffects.ToggleDust(active);
	}

	private void EndRollAnimation()
	{
		_isRolling = false;
		_character.EndRoll();
	}

	private void OverrideRollTransition()
	{
		string run = animations.Run;
		Hoverboard hoverboard = _hoverboard;
		if (~(hoverboard.isActive ? 1u : 0u) == 0)
		{
			_characterSafeAnimation.CrossFadeQueued(run, 0.2f);
			if (_hoverboardSafeAnimation.HasAnimation())
			{
				string hoverboardAnimationName = GetHoverboardAnimationName(run);
				Hoverboard hoverboard2 = _hoverboard;
				float fadeLength = 0.2f;
				if (!hoverboard2.isActive)
				{
					fadeLength = 0f;
				}
				_hoverboardSafeAnimation.CrossFadeQueued(hoverboardAnimationName, fadeLength);
			}
		}
		else
		{
			_characterSafeAnimation.CrossFadeQueued(run, 0.1f);
		}
	}

	private void OnHitByTrain()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		string hitMoving = animations.HitMoving;
		_characterSafeAnimation.Play(hitMoving);
		Vector3 currentTransformPosition = _character.CurrentTransformPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		_ = 0;
		Character character = _character;
		Transform transform = character._characterCamera.transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		throw new ArgumentException();
	}

	private void OnJump()
	{
		Character character = _character;
		OnJump(character.jumpHeightNormal, willPlaySound: false);
	}

	private void OnJump(float jumpHeight, bool willPlaySound)
	{
		if (~(_isRolling ? 1u : 0u) == 0)
		{
			EndRollAnimation();
		}
		Hoverboard hoverboard = _hoverboard;
		if (~(hoverboard.isActive ? 1u : 0u) == 0)
		{
			List<string> hoverboardJump = animations.HoverboardJump;
			string text = hoverboardJump.get_Item(0);
			jumpAnimation = text;
			string text2 = hoverboardJump.get_Item(1);
			hangtimeAnimation = text2;
		}
		else
		{
			if (jumpHeight != 0f)
			{
				Character character = _character;
				float num = character.jumpHeightNormal * 0.5f;
				if (!(jumpHeight > num))
				{
					string smallJump = animations.SmallJump;
					jumpAnimation = smallJump;
					goto IL_01ad;
				}
			}
			string jump = animations.Jump;
			jumpAnimation = jump;
		}
		goto IL_01ad;
		IL_01ad:
		Character character2 = _character;
		float fadeLength = 1f;
		if (!character2._isTucked)
		{
			fadeLength = 0.15f;
		}
		_characterSafeAnimation.CrossFade(jumpAnimation, fadeLength);
		Hoverboard hoverboard2 = _hoverboard;
		if (~(hoverboard2.isActive ? 1u : 0u) == 0 && _hoverboardSafeAnimation.HasAnimation())
		{
			string hoverboardAnimationName = GetHoverboardAnimationName(jumpAnimation);
			_hoverboardSafeAnimation.CrossFade(hoverboardAnimationName, 0.15f);
		}
	}

	private void OnJump(int intensity)
	{
		string jump = animations.Jump;
		jumpAnimation = jump;
		Character character = _character;
		float fadeLength = 1f;
		if (!character._isTucked)
		{
			fadeLength = 0.15f;
		}
		_characterSafeAnimation.CrossFade(jumpAnimation, fadeLength);
	}

	private void OnDoubleJump()
	{
		_isDoublejump = true;
		_characterRenderingEffects.PlayDoubleJumpThruster();
		Hoverboard hoverboard = _hoverboard;
		if (~(hoverboard.isActive ? 1u : 0u) == 0)
		{
			List<string> hoverboardJump = animations.HoverboardJump;
			string text = hoverboardJump.get_Item(0);
			jumpAnimation = text;
			string text2 = hoverboardJump.get_Item(1);
			hangtimeAnimation = text2;
		}
		else
		{
			string doubleJump = animations.DoubleJump;
			jumpAnimation = doubleJump;
		}
		_characterSafeAnimation.Play(jumpAnimation);
		Hoverboard hoverboard2 = _hoverboard;
		if (~(hoverboard2.isActive ? 1u : 0u) == 0 && _hoverboardSafeAnimation.HasAnimation())
		{
			string hoverboardAnimationName = GetHoverboardAnimationName(jumpAnimation);
			_hoverboardSafeAnimation.CrossFade(hoverboardAnimationName, 0.15f);
		}
	}

	private void OnRevive()
	{
		StopAllCoroutines();
		_isDeath = false;
		string jump = animations.Jump;
		jumpAnimation = jump;
		_characterSafeAnimation.Stop();
		_characterSafeAnimation.Play(jumpAnimation);
		CoinMagnet instance = CoinMagnet.Instance;
		if (~(instance.isActive ? 1u : 0u) == 0)
		{
			_characterSafeAnimation.SetEnabled("hold_magnet", isEnabled: true);
			_characterSafeAnimation.Play("hold_magnet");
		}
	}

	public void Character_OnHangtime()
	{
		Character character = _character;
		if (character._isRolling)
		{
			return;
		}
		if (~(_isDoublejump ? 1u : 0u) == 0)
		{
			OnDoubleHangtime();
			return;
		}
		Hoverboard hoverboard = _hoverboard;
		if (~(hoverboard.isActive ? 1u : 0u) != 0 || hangtimeAnimation == null)
		{
			string hangtime = animations.Hangtime;
			hangtimeAnimation = hangtime;
		}
		if (~(_queuedHangtime ? 1u : 0u) != 0 || !_characterSafeAnimation.IsPlaying(jumpAnimation))
		{
			_characterSafeAnimation.CrossFade(hangtimeAnimation, 0.3f);
		}
		else
		{
			_characterSafeAnimation.CrossFadeQueued(hangtimeAnimation);
		}
		if (_hoverboardSafeAnimation != null && _hoverboardSafeAnimation.HasAnimation())
		{
			string hoverboardAnimationName = GetHoverboardAnimationName(hangtimeAnimation);
			if (~(_queuedHangtime ? 1u : 0u) != 0)
			{
				_hoverboardSafeAnimation.CrossFade(hoverboardAnimationName, 0.3f);
			}
			else
			{
				_hoverboardSafeAnimation.CrossFadeQueued(hoverboardAnimationName);
			}
		}
	}

	private unsafe void Character_OnHangtime_AfterAlternateRoute()
	{
		_queuedHangtime = false;
		Character.OnHangtimeDelegate onHangtimeDelegate = default;
		onHangtimeDelegate._002Ector(this, (nint)__ldftn(CharacterRendering.Character_OnHangtime_AfterAlternateRoute));
		_character.OnHangtime -= onHangtimeDelegate;
	}

	private void OnDoubleHangtime()
	{
		_isDoublejump = false;
		Hoverboard hoverboard = _hoverboard;
		string animationName;
		if (~(hoverboard.isActive ? 1u : 0u) == 0)
		{
			animationName = hangtimeAnimation;
			if (hangtimeAnimation != null)
			{
				goto IL_009d;
			}
		}
		string doubleHangtime = animations.DoubleHangtime;
		hangtimeAnimation = doubleHangtime;
		animationName = hangtimeAnimation;
		goto IL_009d;
		IL_009d:
		_characterSafeAnimation.CrossFade(animationName, 0.3f);
		if (_hoverboardSafeAnimation.HasAnimation())
		{
			string hoverboardAnimationName = GetHoverboardAnimationName(hangtimeAnimation);
			_hoverboardSafeAnimation.CrossFade(hoverboardAnimationName, 0.3f);
		}
	}

	private void OnLanding(Character character)
	{
		RunningState instance = RunningState.Instance;
		instance.UpdateGroundTag(_character);
		string run = animations.Run;
		SuperSneakers superSneakers = _superSneakers;
		float speed;
		if (~(superSneakers.isActive ? 1u : 0u) == 0)
		{
			speed = _DEFAULT_SPEED_RUN_ANIMATION;
		}
		else
		{
			Game game = _game;
			Game.SpeedInfo speed2 = game.speed;
			speed = game.__currentSpeed / speed2.min;
		}
		_characterSafeAnimation.SetSpeed(run, speed);
		Character character2 = _character;
		if (character2._isRolling)
		{
			return;
		}
		Hoverboard hoverboard = _hoverboard;
		string text;
		string animationName;
		if (~(hoverboard.isActive ? 1u : 0u) == 0)
		{
			RunningState instance2 = RunningState.Instance;
			if (instance2.currentRunPosition != RunningState.RunPositions.train)
			{
				RunningState instance3 = RunningState.Instance;
				if (instance3.currentRunPosition != RunningState.RunPositions.movingTrain)
				{
					text = animations.Land;
					animationName = run;
					goto IL_014f;
				}
			}
			string text2 = animations.Grind(string.Empty);
			text = text2 + "_land";
			animationName = text2;
			goto IL_014f;
		}
		if (character2.verticalSpeed < -20f)
		{
			string animationName2;
			if (character2.verticalSpeed < -150f)
			{
				animationName2 = animations.BigLand;
			}
			else
			{
				animationName2 = ((!(character2.verticalSpeed < -40f)) ? animations.SmallLand : animations.Land);
			}
			_characterSafeAnimation.CrossFade(animationName2, 0.05f);
			_characterSafeAnimation.CrossFadeQueued(run, 0.1f);
		}
		else
		{
			_characterSafeAnimation.CrossFade(run, 0.1f);
		}
		return;
		IL_014f:
		if (_characterSafeAnimation.HasAnimationClip(text))
		{
			_characterSafeAnimation.CrossFade(text, 0.1f);
		}
		_characterSafeAnimation.CrossFadeQueued(animationName, 0.2f);
		if (_hoverboardSafeAnimation.HasAnimation())
		{
			string hoverboardAnimationName = GetHoverboardAnimationName(text);
			_hoverboardSafeAnimation.CrossFade(hoverboardAnimationName, 0.1f);
			string hoverboardAnimationName2 = GetHoverboardAnimationName(animationName);
			_hoverboardSafeAnimation.CrossFadeQueued(hoverboardAnimationName2, 0.2f);
		}
	}

	private unsafe void StartGrind(int side)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_023d: Expected I, but got Obj
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected VT, but got Unknown
		//IL_02b7: Expected I, but got Obj
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected VT, but got Unknown
		//IL_0331: Expected I, but got Obj
		//IL_0356: Expected F4, but got I
		//IL_0351: Expected native int or pointer, but got VT
		//IL_0364: Expected F4, but got VT
		//IL_035f: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		string text;
		switch (side)
		{
		default:
			text = string.Empty;
			break;
		case 0:
		{
			string wallGrindLeft = animations.WallGrindLeft;
			text = wallGrindLeft;
			break;
		}
		case 1:
		{
			string text2 = animations.Grind(_lastGrindAnimation);
			text = text2;
			break;
		}
		case 2:
		{
			string wallGrindRight = animations.WallGrindRight;
			text = wallGrindRight;
			break;
		}
		}
		if (_characterSafeAnimation.HasAnimationClip(text))
		{
			Character character = _character;
			if (character.verticalSpeed > -10f)
			{
				string startGrind = animations.StartGrind;
				_characterSafeAnimation.CrossFade(startGrind, 0.1f);
				_characterSafeAnimation.CrossFadeQueued(text, 0.1f);
			}
			else
			{
				_characterSafeAnimation.CrossFade(text, 0.1f);
			}
			_lastGrindAnimation = text;
		}
		if (_grindSparks == null)
		{
			GameObject grindSparks = UnityEngine.Object.Instantiate(_grindSparksPrefab);
			_grindSparks = grindSparks;
			Transform transform = _grindSparks.transform;
			Transform parent = _character.transform;
			transform.SetParent(parent);
			Transform transform2 = _grindSparks.transform;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v42 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v43 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			_ = Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			_ = 0;
			Vector3 localPosition = vector + 32;
			transform2.localPosition = localPosition;
			Transform transform3 = _grindSparks.transform;
			nint num3 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v58 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v59 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			_ = 0;
			_ = Quaternion.identityQuaternion;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			Quaternion localRotation = (Quaternion)(vector + 16);
			transform3.localRotation = localRotation;
			Transform transform4 = _grindSparks.transform;
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S1_v40 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S1_v41 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
			transform4.localScale = vector;
		}
	}

	public void EndGrind()
	{
		_lastGrindAnimation = string.Empty;
		if (_grindSparks != null)
		{
			UnityEngine.Object.Destroy(_grindSparks);
		}
	}

	private void OnGrindExit(int side)
	{
		string animationName;
		if (side != 0)
		{
			bool flag = side == 1;
			animationName = string.Empty;
			if (!flag)
			{
				if (side != 2)
				{
					animationName = string.Empty;
				}
				else
				{
					string wallGrindRightExit = animations.WallGrindRightExit;
					animationName = wallGrindRightExit;
				}
			}
		}
		else
		{
			string wallGrindLeftExit = animations.WallGrindLeftExit;
			animationName = wallGrindLeftExit;
		}
		_characterSafeAnimation.CrossFade(animationName, 0.1f);
	}

	private void StartWallRide(int side)
	{
		string animationName;
		switch (side)
		{
		default:
			animationName = string.Empty;
			break;
		case 0:
		{
			string wallRideLeft = animations.WallRideLeft;
			animationName = wallRideLeft;
			break;
		}
		case 1:
		{
			string wallRideRight = animations.WallRideRight;
			animationName = wallRideRight;
			break;
		}
		}
		_characterSafeAnimation.CrossFade(animationName, 0.2f);
	}

	private void StopWallRide(int side)
	{
		string animationName;
		switch (side)
		{
		default:
			animationName = string.Empty;
			break;
		case 0:
		{
			string wallRideLeftExit = animations.WallRideLeftExit;
			animationName = wallRideLeftExit;
			break;
		}
		case 1:
		{
			string wallRideRightExit = animations.WallRideRightExit;
			animationName = wallRideRightExit;
			break;
		}
		}
		_characterSafeAnimation.CrossFade(animationName, 0.1f);
	}

	private void OnTutorialMoveBackToCheckPoint(float duration)
	{
		string run = animations.Run;
		_characterSafeAnimation.CrossFade(run, duration);
	}

	private void OnTutorialStartFromCheckPoint()
	{
		string run = animations.Run;
		_characterSafeAnimation.Play(run);
	}

	private void OnCatchPlayer(string currentCharacterCaught, float catchUpTime, float waitTimeBeforeScreen)
	{
		AnimationState animationState = _characterSafeAnimation.GetAnimationState(currentCharacterCaught);
		_caughtAnimationState = animationState;
		IEnumerator routine = CatchPlayerAnimStarter(_caughtAnimationState, catchUpTime);
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator CatchPlayerAnimStarter(AnimationState caught, float delay)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private unsafe void OnStageMenuSequence()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0106: Expected I, but got Obj
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected VT, but got Unknown
		//IL_018e: Expected I, but got Obj
		//IL_01c0: Expected F4, but got I
		//IL_01bb: Expected native int or pointer, but got VT
		//IL_01db: Expected F4, but got I
		//IL_01d6: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj + -64);
		StopAllCoroutines();
		ResetTeleportFx();
		CharacterModel characterModel = _characterModel;
		bool isCachedCustomizationState = characterModel._outfitModel.enabled;
		_isCachedCustomizationState = isCachedCustomizationState;
		Transform transform = _characterModel.transform;
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v18 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+38]");
		_ = 0;
		_ = Quaternion.identityQuaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+30]");
		_ = 0;
		Quaternion localRotation = (Quaternion)(quaternion + 16);
		transform.localRotation = localRotation;
		SafeAnimation characterSafeAnimation = _characterSafeAnimation;
		if (characterSafeAnimation._animation != null)
		{
			if (_caughtAnimationState != null)
			{
				_caughtAnimationState.enabled = false;
			}
			nint num3 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v53 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v54 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+28]");
			((Quaternion*)(nint)quaternion)->z = 0f;
			_ = Quaternion.identityQuaternion;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+20]");
			((Quaternion*)(nint)quaternion)->x = 0f;
			_characterSafeAnimation.SetLocalRotation(quaternion);
			string topMenu = animations.TopMenu;
			_characterSafeAnimation.Play(topMenu);
		}
		GameObject sprayCanModel = _characterModel.SprayCanModel;
		sprayCanModel.SetActive(value: true);
		_characterModel.StartEyeAnimations(UIModelController.ModelScreen.Character);
		ResetJetpackTrusters();
	}

	internal void OnSwitchToRunningAfterAlternateRoute()
	{
		OnSwitchToRunning();
		Hoverboard hoverboard = _hoverboard;
		if (~(hoverboard.isActive ? 1u : 0u) != 0)
		{
			if (~(_isRolling ? 1u : 0u) != 0)
			{
				OnRun();
			}
			else
			{
				OverrideRollTransition();
			}
		}
	}

	public void OnSwitchToRunning()
	{
		Character character = _character;
		SuperSneakers superSneakers = character._superSneakers;
		if (~(superSneakers.isActive ? 1u : 0u) != 0)
		{
			Game game = _game;
			CharacterModifierCollection modifiers = game._modifiers;
			SuperSneakers superSneakers2 = modifiers.superSneakers;
			if (~(superSneakers2.isActive ? 1u : 0u) != 0)
			{
				Animations animations = this.animations;
				AnimationClipLists animationClipLists = defaultAnimations;
				List<string> rUN = InitializeClips(animationClipLists.run);
				animations.RUN = rUN;
				goto IL_0331;
			}
		}
		Animations animations2 = this.animations;
		SuperSneaksClips superSneaksAnimations = SuperSneaksAnimations;
		List<string> rUN2 = InitializeClips(superSneaksAnimations.run);
		animations2.RUN = rUN2;
		goto IL_0331;
		IL_0331:
		Animations animations3 = this.animations;
		AnimationClipLists animationClipLists2 = defaultAnimations;
		List<string> lAND = InitializeClips(animationClipLists2.landing);
		animations3.LAND = lAND;
		Animations animations4 = this.animations;
		AnimationClipLists animationClipLists3 = defaultAnimations;
		List<string> bIG_LAND = InitializeClips(animationClipLists3.landing);
		animations4.BIG_LAND = bIG_LAND;
		Animations animations5 = this.animations;
		AnimationClipLists animationClipLists4 = defaultAnimations;
		List<string> sMALL_LAND = InitializeClips(animationClipLists4.landing);
		animations5.SMALL_LAND = sMALL_LAND;
		Animations animations6 = this.animations;
		AnimationClipLists animationClipLists5 = defaultAnimations;
		List<string> sMALL_JUMP = InitializeClips(animationClipLists5.jump);
		animations6.SMALL_JUMP = sMALL_JUMP;
		Animations animations7 = this.animations;
		AnimationClipLists animationClipLists6 = defaultAnimations;
		List<string> hIT_MID = InitializeClips(animationClipLists6.hitMid);
		animations7.HIT_MID = hIT_MID;
		Animations animations8 = this.animations;
		AnimationClipLists animationClipLists7 = defaultAnimations;
		List<string> jUMP = InitializeClips(animationClipLists7.jump);
		animations8.JUMP = jUMP;
		Animations animations9 = this.animations;
		AnimationClipLists animationClipLists8 = defaultAnimations;
		List<string> hANGTIME = InitializeClips(animationClipLists8.hangtime);
		animations9.HANGTIME = hANGTIME;
		Animations animations10 = this.animations;
		AnimationClipLists animationClipLists9 = defaultAnimations;
		List<string> dOUBLEJUMP = InitializeClips(animationClipLists9.doubleJump);
		animations10.DOUBLEJUMP = dOUBLEJUMP;
		Animations animations11 = this.animations;
		AnimationClipLists animationClipLists10 = defaultAnimations;
		List<string> dOUBLEHANGTIME = InitializeClips(animationClipLists10.doubleHangtime);
		animations11.DOUBLEHANGTIME = dOUBLEHANGTIME;
		Animations animations12 = this.animations;
		AnimationClipLists animationClipLists11 = defaultAnimations;
		List<string> rOLL = InitializeClips(animationClipLists11.roll);
		animations12.ROLL = rOLL;
		Animations animations13 = this.animations;
		AnimationClipLists animationClipLists12 = defaultAnimations;
		List<string> dODGE_LEFT = InitializeClips(animationClipLists12.dodgeLeft);
		animations13.DODGE_LEFT = dODGE_LEFT;
		Animations animations14 = this.animations;
		AnimationClipLists animationClipLists13 = defaultAnimations;
		List<string> dODGE_RIGHT = InitializeClips(animationClipLists13.dodgeRight);
		animations14.DODGE_RIGHT = dODGE_RIGHT;
		if (_cachedHoverboardBundle != null)
		{
			ToggleCustomHoverboard(null, null);
		}
	}

	private void OnSwitchToHoverboard(HoverboardBundle hoverBoardBundle, Hoverboard.BoardAbility[] abilities)
	{
		ToggleCustomHoverboard(hoverBoardBundle, abilities);
		string getOnBoard = animations.GetOnBoard;
		string hangtime = animations.Hangtime;
		hangtimeAnimation = hangtime;
		_characterSafeAnimation.CrossFade(getOnBoard, 0.1f);
		if (_hoverboardSafeAnimation.HasAnimation())
		{
			string hoverboardAnimationName = GetHoverboardAnimationName(getOnBoard);
			_hoverboardSafeAnimation.CrossFade(hoverboardAnimationName, 0.1f);
		}
		Character character = _character;
		string animationName;
		if (!character._isFalling && !character.__isJumping)
		{
			string run = animations.Run;
			_characterSafeAnimation.CrossFadeQueued(run, 0.2f);
			bool flag = _hoverboardSafeAnimation.HasAnimation();
			animationName = run;
			if (!flag)
			{
				return;
			}
		}
		else
		{
			_characterSafeAnimation.CrossFade(hangtimeAnimation, 0.2f);
			if (!_hoverboardSafeAnimation.HasAnimation())
			{
				return;
			}
			animationName = hangtimeAnimation;
		}
		string hoverboardAnimationName2 = GetHoverboardAnimationName(animationName);
		_hoverboardSafeAnimation.CrossFadeQueued(hoverboardAnimationName2, 0.2f);
	}

	private unsafe void ToggleCustomHoverboard(HoverboardBundle newHoverboardBundle, Hoverboard.BoardAbility[] abilities)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0193: Expected Obj, but got I4
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected I4, but got Unknown
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected Obj, but got Unknown
		//IL_022b: Expected Obj, but got I
		//IL_028d: Expected Obj, but got I
		//IL_029f: Expected Obj, but got I
		//IL_02fb: Expected Obj, but got I
		//IL_030c: Expected Obj, but got I
		//IL_0542: Expected I, but got Obj
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Expected VT, but got Unknown
		//IL_05af: Expected I, but got Obj
		//IL_05e1: Expected F4, but got I
		//IL_05dc: Expected native int or pointer, but got VT
		//IL_05fc: Expected F4, but got I
		//IL_05f7: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj + -64);
		if (_cachedHoverboardBundle != null && _cachedHoverboardBundle != newHoverboardBundle)
		{
			UnityEngine.Object.Destroy(_cachedHoverboardBundle);
		}
		if (_extraTeleportFX != null)
		{
			GameObject obj2 = _extraTeleportFX.gameObject;
			UnityEngine.Object.Destroy(obj2);
		}
		_cachedHoverboardBundle = newHoverboardBundle;
		_currentBoardAbilities = abilities;
		CharacterModel characterModel = _characterModel;
		List<Renderer> currentCustomBoardModelsRenderes = characterModel.currentCustomBoardModelsRenderes;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Material[] cachedCustomHoverboardModelMaterials = default;
		_cachedCustomHoverboardModelMaterials = cachedCustomHoverboardModelMaterials;
		if (newHoverboardBundle != null)
		{
			_teleboardWarpGameObject.SetActive(value: true);
			if (_telewarpRenderer == null)
			{
				nint num = 0;
				nint num2 = 0;
				IntPtr intPtr = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v173 @ S4_v13 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
				Renderer telewarpRenderer = default;
				_telewarpRenderer = telewarpRenderer;
			}
			_telewarpRenderer.enabled = false;
			_teleboardAnimation.normalizedTime = 0f;
			_teleboardAnimation.weight = 0f;
			_teleboardAnimation.enabled = false;
			object obj3 = 1;
			while (true)
			{
				HoverboardBundle cachedHoverboardBundle = _cachedHoverboardBundle;
				HoverboardBundle.CustomSet[] customSets = cachedHoverboardBundle.customSets;
				if ((nint)obj3 >= customSets.Length)
				{
					break;
				}
				HoverboardManager instance = HoverboardManager.Instance;
				HoverboardBundle cachedHoverboardBundle2 = _cachedHoverboardBundle;
				int themeIndex = obj3 - 1;
				if (instance.IsCustomSetEquippedForBoard(cachedHoverboardBundle2.boardType, themeIndex))
				{
					HoverboardBundle cachedHoverboardBundle3 = _cachedHoverboardBundle;
					object obj4 = obj3 << 2;
					object obj5 = (object)cachedHoverboardBundle3.customSets + obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S0_v83+10]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v84+8]");
					if ((nint)0 == 7)
					{
						HoverboardBundle cachedHoverboardBundle4 = _cachedHoverboardBundle;
						object obj7 = obj3 << 2;
						object obj8 = (object)cachedHoverboardBundle4.customSets + obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S0_v90+10]");
						object obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S0_v91+20]");
						if ((UnityEngine.Object)0 != null)
						{
							HoverboardBundle cachedHoverboardBundle5 = _cachedHoverboardBundle;
							object obj10 = obj3 << 2;
							object obj11 = (object)cachedHoverboardBundle5.customSets + obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ S0_v101+10]");
							object obj12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ S0_v102+20]");
							GameObject gameObject = UnityEngine.Object.Instantiate((GameObject)0);
							Transform extraTeleportFX = gameObject.transform;
							_extraTeleportFX = extraTeleportFX;
							Transform parent = _character.transform;
							_extraTeleportFX.parent = parent;
							nint num3 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ S0_v116 (Il2CppClass<UnityEngine.Vector3>)+5C]");
							nint num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ S0_v117 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+38]");
							_ = 0;
							_ = Vector3.zeroVector;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+30]");
							_ = 0;
							Vector3 localPosition = (Vector3)(quaternion + 16);
							_extraTeleportFX.localPosition = localPosition;
							nint num5 = (nint)typeof(Quaternion);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ S0_v131 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ S0_v132 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+28]");
							((Quaternion*)(nint)quaternion)->z = 0f;
							_ = Quaternion.identityQuaternion;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+20]");
							((Quaternion*)(nint)quaternion)->x = 0f;
							_extraTeleportFX.localRotation = quaternion;
							GameObject gameObject2 = _extraTeleportFX.gameObject;
							gameObject2.SetActive(value: false);
						}
						break;
					}
				}
				object obj13 = obj3 + 1;
				obj3 = obj13;
			}
			SafeAnimation hoverboardSafeAnimation = _hoverboardSafeAnimation;
			GameObject gameObject3 = newHoverboardBundle.gameObject;
			Animation component = gameObject3.GetComponent<Animation>();
			hoverboardSafeAnimation._animation = component;
			GameObject gameObject4 = newHoverboardBundle.gameObject;
			nint num7 = 0;
			nint num8 = 0;
			IntPtr intPtr2 = num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v276 @ S4_v5 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
			HoverboardRendering hoverboardRendering = default;
			_hoverboardRendering = hoverboardRendering;
			if (_hoverboardRendering != null)
			{
				SafeAnimation characterSafeAnimation = _characterSafeAnimation;
				SafeAnimation hoverboardSafeAnimation2 = _hoverboardSafeAnimation;
				_hoverboardRendering.Initialize(characterSafeAnimation._animation, hoverboardSafeAnimation2._animation, _defaultHoverboardAnimationList, _addedAnimClipsNames, abilities);
			}
			else
			{
				_hoverboardRendering = _defaultHoverboardRendering;
				SafeAnimation characterSafeAnimation2 = _characterSafeAnimation;
				SafeAnimation hoverboardSafeAnimation3 = _hoverboardSafeAnimation;
				_hoverboardRendering.Initialize(characterSafeAnimation2._animation, hoverboardSafeAnimation3._animation, _defaultHoverboardAnimationList, _addedAnimClipsNames, abilities);
			}
		}
		else
		{
			SafeAnimation hoverboardSafeAnimation4 = _hoverboardSafeAnimation;
			hoverboardSafeAnimation4._animation = null;
			_hoverboardRendering = null;
			_teleboardWarpGameObject.SetActive(value: false);
		}
	}

	private void OnSwitchToJetpack(bool isHeadStart)
	{
		Animations animations = this.animations;
		JetpackClips jetpackClips = jetpackAnimations;
		List<string> rUN = InitializeClips(jetpackClips.run);
		animations.RUN = rUN;
		Animations animations2 = this.animations;
		JetpackClips jetpackClips2 = jetpackAnimations;
		List<string> dODGE_LEFT = InitializeClips(jetpackClips2.dodgeLeft);
		animations2.DODGE_LEFT = dODGE_LEFT;
		Animations animations3 = this.animations;
		JetpackClips jetpackClips3 = jetpackAnimations;
		List<string> dODGE_RIGHT = InitializeClips(jetpackClips3.dodgeRight);
		animations3.DODGE_RIGHT = dODGE_RIGHT;
		Animations animations4 = this.animations;
		JetpackClips jetpackClips4 = jetpackAnimations;
		List<string> tURBO_HEADSTART = InitializeClips(jetpackClips4.turboHeadstart1);
		animations4.TURBO_HEADSTART1 = tURBO_HEADSTART;
		Animations animations5 = this.animations;
		JetpackClips jetpackClips5 = jetpackAnimations;
		List<string> tURBO_HEADSTART2 = InitializeClips(jetpackClips5.turboHeadstart2);
		animations5.TURBO_HEADSTART2 = tURBO_HEADSTART2;
		MeshRenderer meshJetpack = _characterModel.MeshJetpack;
		meshJetpack.enabled = true;
		_characterRenderingEffects.SetRightAndLeftParticlesActive(active: true);
		string run = this.animations.Run;
		_characterSafeAnimation.CrossFade(run);
	}

	private unsafe void JetpackOnFlyAheadStart()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected VT, but got Unknown
		//IL_00f9: Expected F4, but got I
		//IL_00f4: Expected native int or pointer, but got VT
		//IL_0118: Expected F4, but got I
		//IL_0113: Expected native int or pointer, but got VT
		//IL_0163: Expected VT, but got I
		//IL_01ca: Expected VT, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 96);
		_ = 0;
		_ = 0;
		CharacterRenderingEffects characterRenderingEffects = _characterRenderingEffects;
		Transform transform = characterRenderingEffects.jetpackParticles.transform;
		Quaternion rotation = transform.rotation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_ = 0;
		Quaternion rotation2 = (Quaternion)(vector + 16);
		Vector3 vector2 = Quaternion.Internal_ToEulerRad(rotation2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		float num = 0f * 57.29578f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+34]");
		float num2 = 0f * 57.29578f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		float num3 = 0f * 57.29578f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		((Vector3*)(nint)vector)->x = 0f;
		Vector3 vector3 = Quaternion.Internal_MakePositive(vector);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_initRot = (Vector3)0;
		CharacterRenderingEffects characterRenderingEffects2 = _characterRenderingEffects;
		Transform transform2 = characterRenderingEffects2.jetpackParticles.transform;
		Vector3 localScale = transform2.localScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		_initScale = (Vector3)0;
	}

	private unsafe void JetpackOnFlyAheadUpdate(float ratio)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected VT, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected VT, but got Unknown
		//IL_00f1: Expected F4, but got I
		//IL_00ec: Expected native int or pointer, but got VT
		//IL_0110: Expected F4, but got I
		//IL_010b: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 112);
		float num = jetpackParticleOffsetCurve.Evaluate(ratio);
		float num2 = Math.Min(num, 1f);
		bool flag = num < 0f;
		float num3 = 0f;
		if (!flag)
		{
			num3 = num2;
		}
		float num4 = num3 * 1f;
		float num5 = num4 + 0f;
		CharacterRenderingEffects characterRenderingEffects = _characterRenderingEffects;
		Transform transform = characterRenderingEffects.jetpackParticles.transform;
		float num6 = (float)_initRot - num5;
		float num7 = num6 * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.CharacterRendering)+AC]");
		float num8 = 0f - 0f;
		float num9 = num8 * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.CharacterRendering)+B0]");
		float num10 = 0f - 0f;
		float num11 = num10 * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		_ = 0;
		Vector3 euler = vector + 32;
		Quaternion quaternion = Quaternion.Internal_FromEulerRad(euler);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		Quaternion rotation = (Quaternion)(vector + 16);
		transform.rotation = rotation;
		CharacterRenderingEffects characterRenderingEffects2 = _characterRenderingEffects;
		Transform transform2 = characterRenderingEffects2.jetpackParticles.transform;
		float num12 = (float)_initScale + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.CharacterRendering)+B8]");
		float num13 = 0f + 0f;
		float num14 = num5 + num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.CharacterRendering)+BC]");
		float num15 = 0f + num14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		((Vector3*)(nint)vector)->x = 0f;
		transform2.localScale = vector;
	}

	private unsafe void JetpackOnStop(bool isHeadstart)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0054: Expected F4, but got I
		//IL_004f: Expected native int or pointer, but got VT
		//IL_0063: Expected F4, but got VT
		//IL_005e: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		_characterRenderingEffects.SetRightAndLeftParticlesActive(active: false);
		CharacterRenderingEffects characterRenderingEffects = _characterRenderingEffects;
		Transform transform = characterRenderingEffects.jetpackParticles.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.CharacterRendering)+BC]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)_initScale;
		transform.localScale = vector;
		MeshRenderer meshJetpack = _characterModel.MeshJetpack;
		meshJetpack.enabled = false;
		Hoverboard hoverboard = _hoverboard;
		if (~(hoverboard.isActive ? 1u : 0u) == 0)
		{
			OnSwitchToHoverboard(_cachedHoverboardBundle, _currentBoardAbilities);
			return;
		}
		SuperSneakers superSneakers = _superSneakers;
		if (~(superSneakers.isActive ? 1u : 0u) == 0)
		{
			OnSwitchToSuperSneakers();
			Character_OnHangtime();
		}
		else
		{
			OnSwitchToRunning();
			Character_OnHangtime();
		}
	}

	private void HandleOnTurboHeadstart(int version)
	{
		//IL_001e: Expected Obj, but got I4
		//IL_015b: Expected Obj, but got I4
		//IL_018c: Expected Obj, but got I
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		if (~(_isRolling ? 1u : 0u) == 0)
		{
			EndRollAnimation();
		}
		object obj = version - 1;
		string text;
		string text2;
		if (version != 1)
		{
			if ((nint)obj != 1)
			{
				text = string.Empty;
				goto IL_00ef;
			}
			Character character = _character;
			character.TurboHeadstartParticleSystem.Play();
			text2 = animations.TurboHeadstart2;
		}
		else
		{
			text2 = animations.TurboHeadstart1;
		}
		_characterSafeAnimation.CrossFade(text2, 0.1f);
		string run = animations.Run;
		_characterSafeAnimation.CrossFadeQueued(run, 0.2f);
		text = text2;
		goto IL_00ef;
		IL_00ef:
		CharacterCamera instance = CharacterCamera.Instance;
		instance.FOVGip(0.8f, 1.2f);
		if (text != string.Empty)
		{
			CharacterModel characterModel = _characterModel;
			Transform[] jetpackThrusters = characterModel._jetpackThrusters;
			object obj2 = 0;
			while (jetpackThrusters.Length > (nint)obj2)
			{
				object obj3 = obj2 << 2;
				object obj4 = (object)jetpackThrusters + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v39+10]");
				Renderer component = ((Component)0).GetComponent<Renderer>();
				component.enabled = true;
				object obj5 = obj2 + 1;
				obj2 = obj5;
			}
			StopAllCoroutines();
			AnimationState animationState = _characterSafeAnimation.GetAnimationState(text);
			float length = animationState.length;
			throw new ArgumentException();
		}
	}

	private void ResetJetpackTrusters()
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0044: Expected Obj, but got I
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		CharacterModel characterModel = _characterModel;
		Transform[] jetpackThrusters = characterModel._jetpackThrusters;
		if (characterModel._jetpackThrusters != null)
		{
			object obj = 0;
			while ((nint)obj < jetpackThrusters.Length)
			{
				object obj2 = obj << 2;
				object obj3 = (object)characterModel._jetpackThrusters + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v15+10]");
				Renderer component = ((Component)0).GetComponent<Renderer>();
				component.enabled = false;
				object obj4 = obj + 1;
				obj = obj4;
			}
		}
	}

	private void HandleOnScorebooster(int tier)
	{
		_characterRenderingEffects.PlayScoreboostFX(tier);
	}

	private void PogostickOnStart()
	{
		Animations animations = this.animations;
		PogostickClips pogostickClips = this.pogostickClips;
		List<string> rUN = InitializeClips(pogostickClips.run);
		animations.RUN = rUN;
		Animations animations2 = this.animations;
		PogostickClips pogostickClips2 = this.pogostickClips;
		List<string> dODGE_LEFT = InitializeClips(pogostickClips2.dodgeLeft);
		animations2.DODGE_LEFT = dODGE_LEFT;
		Animations animations3 = this.animations;
		PogostickClips pogostickClips3 = this.pogostickClips;
		List<string> dODGE_RIGHT = InitializeClips(pogostickClips3.dodgeRight);
		animations3.DODGE_RIGHT = dODGE_RIGHT;
		Animations animations4 = this.animations;
		PogostickClips pogostickClips4 = this.pogostickClips;
		CharacterModel characterModel = _characterModel;
		CharacterRig characterRig = characterModel._characterRig;
		CharacterCustomization characterCustomization = characterRig.characterCustomization;
		CharacterCustomizationBundle characterCustomizationBundle = characterCustomization._characterCustomizationBundle;
		CharacterCustomizationBundle.OutfitInfo outfit = characterCustomizationBundle._outfit;
		List<string> hANGTIME = InitializeClips(pogostickClips4.hangtime, outfit.ExcludedAnimationsNames);
		animations4.HANGTIME = hANGTIME;
		MeshRenderer meshPogostick = _characterModel.MeshPogostick;
		meshPogostick.enabled = true;
		CharacterModel characterModel2 = _characterModel;
		characterModel2._meshBlobShadow.enabled = false;
		_characterRenderingEffects.SetPogostickParticlesActive(active: true);
		ResetTeleportFx();
		string run = this.animations.Run;
		_characterSafeAnimation.CrossFade(run);
	}

	private void PogostickOnHangtime()
	{
		string hangtime = animations.Hangtime;
		_characterSafeAnimation.CrossFade(hangtime, 0.2f);
		_characterRenderingEffects.SetPogostickParticlesActive(active: false);
	}

	private void PogostickOnStop()
	{
		MeshRenderer meshPogostick = _characterModel.MeshPogostick;
		meshPogostick.enabled = false;
		_characterRenderingEffects.SetPogostickParticlesActive(active: false);
		Hoverboard hoverboard = _hoverboard;
		if (~(hoverboard.isActive ? 1u : 0u) == 0)
		{
			OnSwitchToHoverboard(_cachedHoverboardBundle, _currentBoardAbilities);
			return;
		}
		SuperSneakers superSneakers = _superSneakers;
		if (~(superSneakers.isActive ? 1u : 0u) == 0)
		{
			OnSwitchToSuperSneakers();
			Character_OnHangtime();
		}
		else if (!_game.IsInJetpackMode)
		{
			OnSwitchToRunning();
			Character_OnHangtime();
		}
	}

	private void IsInGame_OnChange(bool isInGame)
	{
		if (!isInGame)
		{
			JetpackOnStop(isHeadstart: false);
			PogostickOnStop();
		}
	}

	private void OnSwitchToSuperSneakers()
	{
		Hoverboard hoverboard = _hoverboard;
		if (~(hoverboard.isActive ? 1u : 0u) != 0)
		{
			OnSwitchToRunning();
			if (~(_isRolling ? 1u : 0u) != 0)
			{
				OnRun();
			}
			else
			{
				OverrideRollTransition();
			}
		}
	}

	private void SuperSneakersOnStop()
	{
		Hoverboard hoverboard = _hoverboard;
		if (~(hoverboard.isActive ? 1u : 0u) != 0)
		{
			OnSwitchToRunning();
			OnRun();
		}
	}

	private void SwitchToAlternateRoute(AlternateRoute route)
	{
		//IL_0077: Expected I, but got Obj
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		nint num = (nint)route;
		object obj = route + 120;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<SYBO.Subway.Routes.AlternateRoute>)+134] (should have been resolved before IL gen)");
		object obj2 = default;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
		}
		string routeEnter = animations.RouteEnter;
		jumpAnimation = routeEnter;
		_characterSafeAnimation.CrossFade(jumpAnimation, 0.1f);
		_characterRenderingEffects.SetPogostickParticlesActive(active: true);
		_queuedHangtime = true;
		ResetTeleportFx();
	}

	private unsafe void SwitchFromAlternateRoute(bool isExitingFromAir)
	{
		if (isExitingFromAir)
		{
			Character character = _character;
			if (!character._isRolling)
			{
				string bigAirTrick = animations.BigAirTrick;
				jumpAnimation = bigAirTrick;
				if (_characterSafeAnimation.HasAnimationClip(jumpAnimation))
				{
					_characterSafeAnimation.CrossFade(jumpAnimation, 0.3f);
				}
			}
			Character.OnHangtimeDelegate onHangtimeDelegate = default;
			onHangtimeDelegate._002Ector(this, (nint)__ldftn(CharacterRendering.Character_OnHangtime_AfterAlternateRoute));
			_character.OnHangtime += onHangtimeDelegate;
		}
		else
		{
			OnSwitchToRunningAfterAlternateRoute();
		}
	}

	private IEnumerator RouteCelebrate_Coroutine()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void SetPieceTransitionTriggerState_OnHangtime()
	{
		string hangtime = animations.Hangtime;
		_characterSafeAnimation.CrossFade(hangtime, 0.2f);
		SetPieceTransitionTriggerState_OnEnd();
	}

	private void SetPieceTransitionTriggerState_OnEnd()
	{
		_characterRenderingEffects.SetPogostickParticlesActive(active: false);
	}

	private void HandleOnTeleboardStart(float duration, Vector3 offset, float gameSpeed)
	{
		//IL_0087: Expected I, but got Obj
		//IL_0172: Expected Obj, but got I4
		if (~(_isTeleportFxActive ? 1u : 0u) == 0)
		{
			StopAllCoroutines();
			ResetCharacterTeleportFX();
		}
		if (_extraTeleportFX != null)
		{
			ATeleboardEffect component = _extraTeleportFX.GetComponent<ATeleboardEffect>();
			if (component != null)
			{
				nint num = (nint)component;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v66 @ S1_v116 (Il2CppClass<ATeleboardEffect>)+DC] (should have been resolved before IL gen)");
			}
			return;
		}
		_telewarpRenderer.enabled = true;
		_teleboardAnimation.normalizedTime = 0f;
		_teleboardAnimation.weight = 0f;
		_teleboardAnimation.enabled = false;
		_isTeleportFxActive = true;
		CharacterModel characterModel = _characterModel;
		Renderer component2 = characterModel._model.GetComponent<Renderer>();
		Material sharedMaterial = component2.sharedMaterial;
		if (sharedMaterial != teleboardFXMaterial)
		{
			_cachedModelMaterial = sharedMaterial;
		}
		CharacterModel characterModel2 = _characterModel;
		Renderer component3 = characterModel2._model.GetComponent<Renderer>();
		component3.material = teleboardFXMaterial;
		CharacterModel characterModel3 = _characterModel;
		Material[] sharedMaterials = characterModel3._headModel.sharedMaterials;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Material[] cachedHeadMaterials = default;
		_cachedHeadMaterials = cachedHeadMaterials;
		object obj = 0;
		if (sharedMaterials.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)sharedMaterials + obj2;
			throw new ArrayTypeMismatchException();
		}
		CharacterModel characterModel4 = _characterModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B24");
		CharacterModel characterModel5 = _characterModel;
		Renderer component4 = characterModel5._outfitModel.GetComponent<Renderer>();
		Material sharedMaterial2 = component4.sharedMaterial;
		if (sharedMaterial2 != teleboardFXMaterial)
		{
			_cachedCustomizationMaterial = sharedMaterial2;
		}
		CharacterModel characterModel6 = _characterModel;
		Renderer component5 = characterModel6._outfitModel.GetComponent<Renderer>();
		component5.material = teleboardFXMaterial;
		CharacterModel characterModel7 = _characterModel;
		Renderer component6 = characterModel7._meshSuperSneaker.GetComponent<Renderer>();
		Material sharedMaterial3 = component6.sharedMaterial;
		if (sharedMaterial3 != teleboardFXMaterial)
		{
			_cachedSupersneakersMaterial = sharedMaterial3;
		}
		CharacterModel characterModel8 = _characterModel;
		Renderer component7 = characterModel8._meshSuperSneaker.GetComponent<Renderer>();
		component7.material = teleboardFXMaterial;
		CharacterModel characterModel9 = _characterModel;
		Renderer component8 = characterModel9._doubleJumpers.GetComponent<Renderer>();
		Material sharedMaterial4 = component8.sharedMaterial;
		if (sharedMaterial4 != teleboardFXMaterial)
		{
			_cachedDoubleJumperMaterial = sharedMaterial4;
		}
		CharacterModel characterModel10 = _characterModel;
		Renderer component9 = characterModel10._doubleJumpers.GetComponent<Renderer>();
		component9.material = teleboardFXMaterial;
		CharacterModel characterModel11 = _characterModel;
		Material sharedMaterial5 = characterModel11.currentHoverboadBasemodel.sharedMaterial;
		if (sharedMaterial5 != teleboardFXMaterial)
		{
			_cachedHoverboardMaterial = sharedMaterial5;
		}
		CharacterModel characterModel12 = _characterModel;
		characterModel12.currentHoverboadBasemodel.material = teleboardFXMaterial;
		CharacterModel characterModel13 = _characterModel;
		List<Renderer> currentCustomBoardModelsRenderes = characterModel13.currentCustomBoardModelsRenderes;
		if (currentCustomBoardModelsRenderes._size >= 1)
		{
			int num2 = 0;
			int num3;
			while (true)
			{
				CharacterModel characterModel14 = _characterModel;
				List<Renderer> currentCustomBoardModelsRenderes2 = characterModel14.currentCustomBoardModelsRenderes;
				bool flag = num2 < currentCustomBoardModelsRenderes2._size;
				bool flag2 = !flag;
				num3 = 0;
				if (flag2)
				{
					break;
				}
				CharacterModel characterModel15 = _characterModel;
				Renderer renderer = characterModel15.currentCustomBoardModelsRenderes.get_Item(num2);
				if (renderer != null)
				{
					CharacterModel characterModel16 = _characterModel;
					Renderer renderer2 = characterModel16.currentCustomBoardModelsRenderes.get_Item(num2);
					Material sharedMaterial6 = renderer2.sharedMaterial;
					if (sharedMaterial6 != teleboardFXMaterial && sharedMaterial6 != null)
					{
						throw new ArrayTypeMismatchException();
					}
				}
				int num4 = num2 + 1;
				num2 = num4;
			}
			while (true)
			{
				CharacterModel characterModel17 = _characterModel;
				List<Renderer> currentCustomBoardModelsRenderes3 = characterModel17.currentCustomBoardModelsRenderes;
				if (num3 >= currentCustomBoardModelsRenderes3._size)
				{
					break;
				}
				CharacterModel characterModel18 = _characterModel;
				Renderer renderer3 = characterModel18.currentCustomBoardModelsRenderes.get_Item(num3);
				if (renderer3 != null)
				{
					CharacterModel characterModel19 = _characterModel;
					Renderer renderer4 = characterModel19.currentCustomBoardModelsRenderes.get_Item(num3);
					renderer4.material = teleboardFXMaterial;
				}
				int num5 = num3 + 1;
				num3 = num5;
			}
		}
		CharacterModel characterModel20 = _characterModel;
		bool isCachedCustomizationState = characterModel20._outfitModel.enabled;
		_isCachedCustomizationState = isCachedCustomizationState;
		IEnumerator routine = TeleboardStartScale(duration, gameSpeed);
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator TeleboardStartScale(float duration, float gameSpeed)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public unsafe void HandleOnTeleboardEnd(float duration, float gameSpeed)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0122: Expected I, but got Obj
		//IL_0154: Expected F4, but got I
		//IL_014f: Expected native int or pointer, but got VT
		//IL_016f: Expected F4, but got I
		//IL_016a: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		Character character = _character;
		Variable<bool> isGrounded = character.IsGrounded;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v11 (Variable`1<System.Boolean>)+8]");
		if ((nint)0 != 0)
		{
			OnRun();
		}
		else
		{
			Character_OnHangtime();
		}
		Transform transform = _teleboardWarpGameObject.transform;
		Transform parent = _character.transform;
		transform.parent = parent;
		Transform transform2 = _teleboardWarpGameObject.transform;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v25 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v26 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		transform2.localPosition = vector;
		_teleboardAnimation.normalizedTime = 1f;
		_teleboardAnimation.weight = 1f;
		float num3 = gameSpeed * 0.01f;
		float speed = 0f - num3;
		_teleboardAnimation.speed = speed;
		_teleboardAnimation.enabled = true;
		IEnumerator routine = TeleboardEndScale(duration);
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator TeleboardEndScale(float duration)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private unsafe void ResetCharacterTeleportFX()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_03da: Expected I, but got Obj
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected VT, but got Unknown
		//IL_0454: Expected I, but got Obj
		//IL_0479: Expected F4, but got I
		//IL_0474: Expected native int or pointer, but got VT
		//IL_0487: Expected F4, but got VT
		//IL_0482: Expected native int or pointer, but got VT
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Obj, but got Unknown
		//IL_0259: Expected Obj, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		Transform transform = _characterModel.transform;
		Transform parent = base.transform;
		transform.parent = parent;
		Transform transform2 = _characterModel.transform;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		_ = 0;
		Vector3 localPosition = vector + 16;
		transform2.localPosition = localPosition;
		Transform transform3 = _characterModel.transform;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v20 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v21 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
		transform3.localScale = vector;
		CharacterModel characterModel = _characterModel;
		characterModel._model.enabled = true;
		CharacterModel characterModel2 = _characterModel;
		characterModel2._headModel.enabled = true;
		CharacterModel characterModel3 = _characterModel;
		characterModel3._outfitModel.enabled = _isCachedCustomizationState;
		Hoverboard instance = Hoverboard.Instance;
		if (~(instance.isActive ? 1u : 0u) == 0)
		{
			CharacterModel characterModel4 = _characterModel;
			if (characterModel4._currentHoverboard != null)
			{
				PogoStickState instance2 = PogoStickState.Instance;
				if (!instance2.isActive)
				{
					CharacterModel characterModel5 = _characterModel;
					characterModel5._currentHoverboard.SetActive(value: true);
				}
			}
			if (_cachedHoverboardMaterial != null)
			{
				CharacterModel characterModel6 = _characterModel;
				characterModel6.currentHoverboadBasemodel.material = _cachedHoverboardMaterial;
			}
			Material[] cachedCustomHoverboardModelMaterials = _cachedCustomHoverboardModelMaterials;
			if (_cachedCustomHoverboardModelMaterials != null && cachedCustomHoverboardModelMaterials.Length != 0)
			{
				int num5 = 0;
				while (true)
				{
					CharacterModel characterModel7 = _characterModel;
					List<Renderer> currentCustomBoardModelsRenderes = characterModel7.currentCustomBoardModelsRenderes;
					if (num5 >= currentCustomBoardModelsRenderes._size)
					{
						break;
					}
					CharacterModel characterModel8 = _characterModel;
					Renderer renderer = characterModel8.currentCustomBoardModelsRenderes.get_Item(num5);
					if (renderer != null)
					{
						CharacterModel characterModel9 = _characterModel;
						Renderer renderer2 = characterModel9.currentCustomBoardModelsRenderes.get_Item(num5);
						if (renderer2 != null)
						{
							int num6 = num5 << 2;
							object obj2 = _cachedCustomHoverboardModelMaterials + num6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S1_v84+10]");
							renderer2.material = (Material)0;
						}
					}
					int num7 = num5 + 1;
					num5 = num7;
				}
			}
		}
		if (_cachedModelMaterial != null)
		{
			CharacterModel characterModel10 = _characterModel;
			Renderer component = characterModel10._model.GetComponent<Renderer>();
			component.material = _cachedModelMaterial;
			_cachedModelMaterial = null;
		}
		if (_cachedHeadMaterials != null)
		{
			CharacterModel characterModel11 = _characterModel;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B24");
			_cachedHeadMaterials = null;
		}
		if (_cachedCustomizationMaterial != null)
		{
			CharacterModel characterModel12 = _characterModel;
			Renderer component2 = characterModel12._outfitModel.GetComponent<Renderer>();
			component2.material = _cachedCustomizationMaterial;
			_cachedCustomizationMaterial = null;
		}
		if (_cachedSupersneakersMaterial != null)
		{
			CharacterModel characterModel13 = _characterModel;
			Renderer component3 = characterModel13._meshSuperSneaker.GetComponent<Renderer>();
			component3.material = _cachedSupersneakersMaterial;
			_cachedSupersneakersMaterial = null;
		}
		if (_cachedDoubleJumperMaterial != null)
		{
			CharacterModel characterModel14 = _characterModel;
			Renderer component4 = characterModel14._doubleJumpers.GetComponent<Renderer>();
			component4.material = _cachedDoubleJumperMaterial;
			_cachedDoubleJumperMaterial = null;
		}
		_characterSafeAnimation.Play();
		Character character = _character;
		Variable<bool> isGrounded = character.IsGrounded;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ S0_v87 (Variable`1<System.Boolean>)+8]");
		if ((nint)0 != 0)
		{
			OnRun();
		}
		_isTeleportFxActive = false;
	}

	private void OnApplicationPause(bool isApplicationPaused)
	{
		if (isApplicationPaused)
		{
			ResetTeleportFx();
		}
	}

	public void ResetTeleportFx()
	{
		if (~(_isTeleportFxActive ? 1u : 0u) == 0)
		{
			StopAllCoroutines();
			ResetCharacterTeleportFX();
		}
	}

	private void Character_OnEnterRoute()
	{
	}

	private void Character_OnEnterRouteEnd()
	{
		_characterRenderingEffects.SetPogostickParticlesActive(active: false);
	}

	private void Character_OnExitRoute()
	{
	}

	private void RouteManager_OnRouteCreated(object sender, RouteManager.RouteCreatedEventArgs args)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		UnityEngine.Object obj = default;
		if (obj != null)
		{
			throw new ArgumentException();
		}
	}

	private void AlternateRoute_OnCharacterEntryStarted(object sender, Route.CharacterEntryStartedEventArgs args)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		AlternateRoute route = default;
		SwitchToAlternateRoute(route);
	}

	private void AlternateRoute_OnCharacterEntrySkipped(object sender, Route.CharacterEntrySkippedEventArgs args)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [args @ L2 (System.Object)+8]");
		if ((nint)0 != 0)
		{
			OnRouteDone(isRouteDestructing: false);
		}
	}

	private void AlternateRoute_OnCharacterExited(object sender, Route.CharacterExitedEventArgs args)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		throw new ArgumentException();
	}

	private void OnRouteDone(bool isRouteDestructing)
	{
		if (!isRouteDestructing)
		{
			SwitchFromAlternateRoute(isExitingFromAir: false);
		}
	}

	private void AlternateRoute_OnDestructing(object sender, EventArgs args)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
		throw new ArgumentException();
	}

	public void SafeTryAddAnimationEvent(Animation animationInstance, string animationName, AnimationEvent animationEvent)
	{
		_characterSafeAnimation.TryAddAnimationEvent(animationInstance, animationName, animationEvent);
	}

	public CharacterRendering()
	{
		//IL_0043: Expected I, but got Obj
		//IL_007e: Expected I, but got Obj
		Animations animations = default;
		animations._002Ector();
		this.animations = animations;
		List<AnimationClip> list = default;
		list._002Ector();
		_addedAnimClipsNames = list;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_initRot = Vector3.zeroVector;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v28 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v29 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		_ = 0;
		_initScale = Vector3.oneVector;
		_isCachedCustomizationState = true;
		_lastGrindAnimation = string.Empty;
		base._002Ector();
	}

	private unsafe void _003CHandleOnTurboHeadstart_003Eb__135_0(float t)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_014f: Expected Obj, but got I4
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_036b: Expected F4, but got I
		//IL_0366: Expected native int or pointer, but got VT
		//IL_0378: Expected F4, but got Obj
		//IL_0373: Expected native int or pointer, but got VT
		//IL_038d: Expected Obj, but got I
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected Obj, but got Unknown
		//IL_029b: Expected I, but got Obj
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected Obj, but got Unknown
		//IL_0180: Expected Obj, but got I
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		JetpackOnFlyAheadUpdate(t);
		_characterCamera.Shake(20f);
		float num;
		float num2;
		if (t < 0.2f)
		{
			num = t;
		}
		else
		{
			bool flag = t > 0.8f;
			bool flag2 = !flag;
			num2 = 1f;
			if (flag2)
			{
				goto IL_0209;
			}
			num = 1f - t;
		}
		num2 = num * 5f;
		goto IL_0209;
		IL_0209:
		float num3 = t + t;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @331");
		object obj2 = default;
		float num4 = (float)obj2 * 0.2f;
		float num5 = num2 + num4;
		bool flag3 = num5 < 0f;
		bool flag4 = !flag3;
		float num6 = num5;
		if (!flag4)
		{
			float num7 = -0f - num5;
			num6 = num7;
		}
		CharacterModel characterModel = _characterModel;
		Transform[] jetpackThrusters = characterModel._jetpackThrusters;
		object obj3 = default;
		object obj7 = default;
		while (jetpackThrusters.Length > (nint)obj3)
		{
			object obj4 = obj3 << 2;
			object obj5 = (object)jetpackThrusters + obj4;
			JetpackState jetpackState = _jetpackState;
			object obj6;
			if (jetpackState._turboHeadstart > 1)
			{
				float num8 = num6 * 2.5f;
				obj6 = vector + 16;
			}
			else
			{
				nint num9 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S1_v49 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num10 = 0;
				float num11 = (float)Vector3.oneVector * num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v50 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
				float num12 = 0f * num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v50 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
				float num13 = 0f * num6;
				obj6 = vector + 32;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S1_v33+8]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v42+10]");
			((Transform)0).localScale = vector;
			obj3 = obj7 + 1;
		}
		if (t == 1f)
		{
			CharacterModel characterModel2 = _characterModel;
			Transform[] jetpackThrusters2 = characterModel2._jetpackThrusters;
			object obj8 = 0;
			while ((nint)obj8 < jetpackThrusters2.Length)
			{
				object obj9 = obj8 << 2;
				object obj10 = (object)jetpackThrusters2 + obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v36+10]");
				Renderer component = ((Component)0).GetComponent<Renderer>();
				component.enabled = false;
				object obj11 = obj8 + 1;
				obj8 = obj11;
			}
		}
	}
}

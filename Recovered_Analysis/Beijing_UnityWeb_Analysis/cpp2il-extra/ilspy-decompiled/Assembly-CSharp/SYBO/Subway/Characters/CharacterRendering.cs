using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Managers;
using Info;
using Kiloo.Common.Utility;
using SYBO.Common;
using SYBO.Common.Utilities;
using SYBO.Common.Visuals;
using SYBO.Components.Utilities;
using SYBO.Subway.Benchmarking;
using SYBO.Subway.Benchmarking.Processors;
using SYBO.Subway.Cameras;
using SYBO.Subway.Info;
using SYBO.Subway.Level;
using SYBO.Subway.Pickups;
using SYBO.Subway.Placeholders.Lifecycles;
using SYBO.Subway.Placeholders.PrefabProviders;
using SYBO.Subway.Promotion;
using SYBO.Subway.Routes;
using SYBO.Subway.Routes.Builders.Worker;
using SYBO.Subway.StateSystem;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Rendering;

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

		public string TopMenu => (string)(object)INTRO_RUN;

		public string IntroRun => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)TOP_MENU);

		public string Run => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)INTRO_RUN);

		public string Land => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)RUN);

		public string BigLand => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)LAND);

		public string SmallLand => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)BIG_LAND);

		public string Jump => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)SMALL_LAND);

		public string SmallJump => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)JUMP);

		public string Tuck => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)SMALL_JUMP);

		public string Hangtime => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)TUCK);

		public string DoubleJump => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)HANGTIME);

		public string DoubleHangtime => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)DOUBLEJUMP);

		public string TurboHeadstart1 => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)DOUBLEHANGTIME);

		public string TurboHeadstart2 => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)TURBO_HEADSTART1);

		public List<string> HoverboardJump => (List<string>)(object)((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)TURBO_HEADSTART2);

		public string Roll
		{
			get
			{
				//IL_0016: Expected Obj, but got I4
				return (string)((MovingTrainUpdater._003C_003Ec)null)._003CUpdate_003Eb__13_0((MovingTrain)(object)JUMP, (MovingTrain)(object)HANGTIME);
			}
		}

		public string DodgeLeft => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)ROLL);

		public string DodgeRight => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)DODGE_LEFT);

		public string StartGrind
		{
			get
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				object bw = this - -64;
				return ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)bw);
			}
		}

		public string GetOnBoard => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)STARTGRIND);

		public string HitMid => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)GET_ON_BOARD);

		public string HitUpper => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)HIT_MID);

		public string HitLower => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)HIT_UPPER);

		public string HitMoving => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)HIT_LOWER);

		public string Stumble => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)HIT_MOVING);

		public string StumbleDeath => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)STUMBLE);

		public string StumbleMix => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)STUMBLEDEATH);

		public string StumbleLeftSide => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)STUMBLE_MIX);

		public string StumbleRightSide => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)STUMBLE_LEFT_SIDE);

		public string StumbleLeftCorner => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)STUMBLE_RIGHT_SIDE);

		public string StumbleRightCorner => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)STUMBLE_LEFT_CORNER);

		public string WallRideLeft => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)STUMBLE_RIGHT_CORNER);

		public string WallRideLeftExit => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)WALLRIDELEFT);

		public string WallRideRight => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)WALLRIDELEFTEXIT);

		public string WallRideRightExit => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)WALLRIDERIGHT);

		public string WallGrindLeft => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)WALLRIDERIGHTEXIT);

		public string WallGrindLeftExit => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)WALLGRINDLEFT);

		public string WallGrindRight => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)WALLGRINDLEFTEXIT);

		public string WallGrindRightExit => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)WALLGRINDRIGHT);

		public string RouteCelebrate => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)WALLGRINDRIGHTEXIT);

		public string BigAirTrick => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)ROUTE_CELEBRATE);

		public string RouteEnter => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)BIG_AIR_TRICK);

		public string RouteExit => ((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)(object)ROUTE_ENTER);

		public string Grind(string lastAnimationName)
		{
			//IL_001a: Expected Obj, but got I4
			bool flag = lastAnimationName.m_stringLength == (nint)TOP_MENU;
			return (string)flag;
		}

		private string GetRandomAnimationName(List<string> animationsNames)
		{
			return GetRandomAnimationNameExcluding(GRIND, animationsNames);
		}

		private string GetRandomAnimationNameExcluding(List<string> animationNames, string excludeAnimationName)
		{
			//IL_0009: Expected Obj, but got I4
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A3");
			string result = default;
			return result;
		}

		private string GetRandomAnimationNameExcluding(List<string> animationNames, IEnumerable<string> excludeAnimationNames)
		{
			throw new IndexOutOfRangeException();
		}

		private List<string> GetRandomHoverJumps(List<string> hoverboardJump, List<string> hoverboardHangtime)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0214: Unknown result type (might be due to invalid IL or missing references)
			//IL_0219: Expected Obj, but got Unknown
			//IL_0222: Expected Obj, but got I4
			//IL_0231: Unknown result type (might be due to invalid IL or missing references)
			//IL_0236: Expected I, but got Unknown
			//IL_023e: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 48;
			object obj3 = obj2 + 24;
			obj3 = 0;
			_ = 0;
			nint num = (nint)(obj2 + 16);
			num = (nint)obj;
			_ = -1;
			if (hoverboardJump._size == 1)
			{
				return (List<string>)(object)hoverboardJump.get_Item(0);
			}
			throw new IndexOutOfRangeException();
		}

		public Animations()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
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

		public AnimationClipLists()
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected Obj, but got Unknown
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Expected Obj, but got Unknown
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Expected Obj, but got Unknown
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Expected Obj, but got Unknown
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Expected Obj, but got Unknown
			//IL_0170: Unknown result type (might be due to invalid IL or missing references)
			//IL_0175: Expected Obj, but got Unknown
			//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Expected Obj, but got Unknown
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ec: Expected Obj, but got Unknown
			//IL_0220: Unknown result type (might be due to invalid IL or missing references)
			//IL_0225: Expected Obj, but got Unknown
			//IL_025e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0263: Expected Obj, but got Unknown
			//IL_0297: Unknown result type (might be due to invalid IL or missing references)
			//IL_029c: Expected Obj, but got Unknown
			//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02da: Expected Obj, but got Unknown
			//IL_030e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0313: Expected Obj, but got Unknown
			//IL_034c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0351: Expected Obj, but got Unknown
			//IL_0385: Unknown result type (might be due to invalid IL or missing references)
			//IL_038a: Expected Obj, but got Unknown
			//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c8: Expected Obj, but got Unknown
			//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0401: Expected Obj, but got Unknown
			//IL_043a: Unknown result type (might be due to invalid IL or missing references)
			//IL_043f: Expected Obj, but got Unknown
			//IL_0473: Unknown result type (might be due to invalid IL or missing references)
			//IL_0478: Expected Obj, but got Unknown
			//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b6: Expected Obj, but got Unknown
			//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ef: Expected Obj, but got Unknown
			//IL_0528: Unknown result type (might be due to invalid IL or missing references)
			//IL_052d: Expected Obj, but got Unknown
			//IL_0561: Unknown result type (might be due to invalid IL or missing references)
			//IL_0566: Expected Obj, but got Unknown
			//IL_059f: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a4: Expected Obj, but got Unknown
			//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05dd: Expected Obj, but got Unknown
			//IL_0616: Unknown result type (might be due to invalid IL or missing references)
			//IL_061b: Expected Obj, but got Unknown
			//IL_064f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0654: Expected Obj, but got Unknown
			//IL_068d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0692: Expected Obj, but got Unknown
			//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_06cb: Expected Obj, but got Unknown
			//IL_0704: Unknown result type (might be due to invalid IL or missing references)
			//IL_0709: Expected Obj, but got Unknown
			//IL_073d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0742: Expected Obj, but got Unknown
			//IL_077b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0780: Expected Obj, but got Unknown
			//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b9: Expected Obj, but got Unknown
			//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f7: Expected Obj, but got Unknown
			//IL_082b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0830: Expected Obj, but got Unknown
			//IL_0869: Unknown result type (might be due to invalid IL or missing references)
			//IL_086e: Expected Obj, but got Unknown
			//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a7: Expected Obj, but got Unknown
			//IL_08e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e5: Expected Obj, but got Unknown
			//IL_0919: Unknown result type (might be due to invalid IL or missing references)
			//IL_091e: Expected Obj, but got Unknown
			//IL_0957: Unknown result type (might be due to invalid IL or missing references)
			//IL_095c: Expected Obj, but got Unknown
			//IL_0990: Unknown result type (might be due to invalid IL or missing references)
			//IL_0995: Expected Obj, but got Unknown
			//IL_09ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_09d3: Expected Obj, but got Unknown
			//IL_0a07: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a0c: Expected Obj, but got Unknown
			//IL_0a32: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a37: Expected Obj, but got Unknown
			//IL_0a5d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a62: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list = default;
			list._002Ector();
			list.Add("topMenu");
			object obj = this + 8;
			obj = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list2 = default;
			list2._002Ector();
			list2.Add("introRun");
			object obj2 = this + 12;
			obj2 = list2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list3 = default;
			list3._002Ector();
			list3.Add("run");
			object obj3 = this + 16;
			obj3 = list3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list4 = default;
			list4._002Ector();
			list4.Add("land");
			object obj4 = this + 20;
			obj4 = list4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list5 = default;
			list5._002Ector();
			list5.Add("land");
			object obj5 = this + 24;
			obj5 = list5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list6 = default;
			list6._002Ector();
			list6.Add("land");
			object obj6 = this + 28;
			obj6 = list6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list7 = default;
			list7._002Ector();
			list7.Add("jump");
			object obj7 = this + 32;
			obj7 = list7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list8 = default;
			list8._002Ector();
			list8.Add("jump");
			object obj8 = this + 36;
			obj8 = list8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list9 = default;
			list9._002Ector();
			list9.Add("tuck");
			object obj9 = this + 40;
			obj9 = list9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list10 = default;
			list10._002Ector();
			list10.Add("hangtime");
			object obj10 = this + 44;
			obj10 = list10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list11 = default;
			list11._002Ector();
			list11.Add("jump");
			object obj11 = this + 48;
			obj11 = list11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list12 = default;
			list12._002Ector();
			list12.Add("hangtime");
			object obj12 = this + 52;
			obj12 = list12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list13 = default;
			list13._002Ector();
			list13.Add("roll");
			object obj13 = this + 56;
			obj13 = list13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list14 = default;
			list14._002Ector();
			list14.Add("dodgeLeft");
			object obj14 = this + 60;
			obj14 = list14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list15 = default;
			list15._002Ector();
			list15.Add("dodgeRight");
			object obj15 = this - -64;
			obj15 = list15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list16 = default;
			list16._002Ector();
			list16.Add("dodgeRight");
			object obj16 = this + 68;
			obj16 = list16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list17 = default;
			list17._002Ector();
			list17.Add("dodgeRight");
			object obj17 = this + 72;
			obj17 = list17;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list18 = default;
			list18._002Ector();
			list18.Add("grind");
			object obj18 = this + 76;
			obj18 = list18;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list19 = default;
			list19._002Ector();
			list19.Add("grind");
			object obj19 = this + 80;
			obj19 = list19;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list20 = default;
			list20._002Ector();
			list20.Add("getOnBoard");
			object obj20 = this + 84;
			obj20 = list20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list21 = default;
			list21._002Ector();
			list21.Add("hitMid");
			object obj21 = this + 88;
			obj21 = list21;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list22 = default;
			list22._002Ector();
			list22.Add("hitUpper");
			object obj22 = this + 92;
			obj22 = list22;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list23 = default;
			list23._002Ector();
			list23.Add("hitLower");
			object obj23 = this + 96;
			obj23 = list23;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list24 = default;
			list24._002Ector();
			list24.Add("hitMoving");
			object obj24 = this + 100;
			obj24 = list24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list25 = default;
			list25._002Ector();
			list25.Add("stumble_low");
			object obj25 = this + 104;
			obj25 = list25;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list26 = default;
			list26._002Ector();
			list26.Add("stumbleFall");
			object obj26 = this + 108;
			obj26 = list26;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list27 = default;
			list27._002Ector();
			list27.Add("stumble");
			object obj27 = this + 112;
			obj27 = list27;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list28 = default;
			list28._002Ector();
			list28.Add("stumbleLeftSide");
			object obj28 = this + 116;
			obj28 = list28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list29 = default;
			list29._002Ector();
			list29.Add("stumbleRightSide");
			object obj29 = this + 120;
			obj29 = list29;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list30 = default;
			list30._002Ector();
			list30.Add("stumbleLeftCorner");
			object obj30 = this + 124;
			obj30 = list30;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list31 = default;
			list31._002Ector();
			list31.Add("stumbleRightCorner");
			object obj31 = this + 128;
			obj31 = list31;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list32 = default;
			list32._002Ector();
			list32.Add("hold_magnet");
			object obj32 = this + 132;
			obj32 = list32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list33 = default;
			list33._002Ector();
			list33.Add("grind");
			object obj33 = this + 136;
			obj33 = list33;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list34 = default;
			list34._002Ector();
			list34.Add("grind");
			object obj34 = this + 140;
			obj34 = list34;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list35 = default;
			list35._002Ector();
			list35.Add("grind");
			object obj35 = this + 144;
			obj35 = list35;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list36 = default;
			list36._002Ector();
			list36.Add("grind");
			object obj36 = this + 148;
			obj36 = list36;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list37 = default;
			list37._002Ector();
			list37.Add("grind");
			object obj37 = this + 152;
			obj37 = list37;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list38 = default;
			list38._002Ector();
			list38.Add("grind");
			object obj38 = this + 156;
			obj38 = list38;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list39 = default;
			list39._002Ector();
			list39.Add("grind");
			object obj39 = this + 160;
			obj39 = list39;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list40 = default;
			list40._002Ector();
			list40.Add("grind");
			object obj40 = this + 164;
			obj40 = list40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list41 = default;
			list41._002Ector();
			list41.Add("routeCelebrate");
			object obj41 = this + 168;
			obj41 = list41;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list42 = default;
			list42._002Ector();
			list42.Add("bigAirTrick");
			object obj42 = this + 172;
			obj42 = list42;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list43 = default;
			list43._002Ector();
			list43.Add("routeEnter");
			object obj43 = this + 176;
			obj43 = list43;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list44 = default;
			list44._002Ector();
			list44.Add("routeExit");
			object obj44 = this + 180;
			obj44 = list44;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list45 = default;
			list45._002Ector();
			object obj45 = this + 188;
			obj45 = list45;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list46 = default;
			list46._002Ector();
			object obj46 = this + 192;
			obj46 = list46;
		}
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

	private sealed class _003COnRollPlayAnimation_003Ed__95(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CharacterRendering _003C_003E4__this;

		private string _003CrollAnimation_003E5__2;

		private float _003CendTime_003E5__3;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0048: Unknown result type (might be due to invalid IL or missing references)
				//IL_004d: Expected Obj, but got Unknown
				//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01aa: Expected Obj, but got Unknown
				//IL_00b5: Expected I, but got Obj
				//IL_00cb: Expected Obj, but got I
				//IL_00f6: Expected I, but got Obj
				//IL_0394: Expected Obj, but got I4
				//IL_0248: Expected Obj, but got I4
				//IL_0267: Unknown result type (might be due to invalid IL or missing references)
				//IL_026c: Expected Obj, but got Unknown
				//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e1: Expected Obj, but got Unknown
				//IL_03ea: Expected Obj, but got I4
				//IL_03fe: Expected Obj, but got I4
				//IL_045e: Expected Obj, but got I4
				CharacterRendering characterRendering = _003C_003E4__this;
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
					characterRendering._isRolling = true;
					object obj = this + 20;
					string dodgeLeft = characterRendering.animations.DodgeLeft;
					obj = dodgeLeft;
					string land = characterRendering.animations.Land;
					SuperSneakers superSneakers = characterRendering._superSneakers;
					if (~(superSneakers.isActive ? 1u : 0u) == 0)
					{
						nint num = (nint)typeof(CharacterRendering);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v62 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+BA]");
						object obj2 = (nint)0 & (nint)0x200;
						if (obj2 != null)
						{
							nint num2 = (nint)typeof(CharacterRendering);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v67 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						characterRendering._characterSafeAnimation.SetSpeed((AnimationState)(object)land, _DEFAULT_SPEED_RUN_ANIMATION);
					}
					else
					{
						Game game = characterRendering._game;
						Game.SpeedInfo speed = game.speed;
						float speed2 = game.__currentSpeed / speed.min;
						characterRendering._characterSafeAnimation.SetSpeed((AnimationState)(object)land, speed2);
					}
					((RouteChunk)(object)characterRendering._characterSafeAnimation).HideLogicRecursive((Transform)(object)_003CrollAnimation_003E5__2, 0.1f);
					object obj3 = characterRendering - -64;
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v46+54]");
					if ((nint)0 != 0)
					{
						characterRendering._characterSafeAnimation.CrossFade(land, 0.2f);
						if (((WorkLoadQueue)(object)characterRendering._hoverboardSafeAnimation).IsIdle)
						{
							bool flag = characterRendering.HasHoverboardAnimation(_003CrollAnimation_003E5__2);
							((RouteChunk)(object)characterRendering._hoverboardSafeAnimation).HideLogicRecursive((Transform)flag, 0.1f);
							bool flag2 = characterRendering.HasHoverboardAnimation(land);
							object obj5 = characterRendering - -64;
							object obj6 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S2_v22+54]");
							float fadeLength = (((nint)0 == 0) ? 0f : 0.2f);
							characterRendering._hoverboardSafeAnimation.CrossFade((string)flag2, fadeLength);
						}
					}
					else
					{
						characterRendering._characterSafeAnimation.CrossFade(land, 0.1f);
					}
					float timeSinceLevelLoad = Time.timeSinceLevelLoad;
					bool flag3 = characterRendering._characterSafeAnimation.HasAnimationState(_003CrollAnimation_003E5__2);
					float distance = (flag3 ? ((RaycastHit*)1) : ((RaycastHit*)null))->distance;
					float num3 = timeSinceLevelLoad + distance;
					_003CendTime_003E5__3 = num3;
				}
				float timeSinceLevelLoad2 = Time.timeSinceLevelLoad;
				if (timeSinceLevelLoad2 < _003CendTime_003E5__3)
				{
					bool flag4 = characterRendering._characterSafeAnimation.HasAnimationState(_003CrollAnimation_003E5__2);
					if (((AnimationState)flag4).wrapMode != WrapMode.Default && ~(characterRendering._isRolling ? 1u : 0u) == 0)
					{
						object obj7 = this + 12;
						obj7 = 0;
						_003C_003E1__state = 1;
						return 1;
					}
				}
				characterRendering.OverrideRollTransition();
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0012: Expected Obj, but got I
			//IL_0016: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.CharacterRendering+<OnRollPlayAnimation>d__95)+B4]");
			return (byte)(int)((SubwayBenchmarkContainer._003C_003Ec)null)._003Cget_BenchmarkNames_003Eb__6_0((SubwayBenchmarkContainer.BenchmarkWrapper)0) != 0;
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

	private sealed class _003C_003Ec__DisplayClass120_0
	{
		public AnimationState caught;

		internal unsafe void _003CCatchPlayerAnimStarter_003Eb__0(float t)
		{
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected Obj, but got Unknown
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Expected Obj, but got Unknown
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Expected Obj, but got Unknown
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Expected Obj, but got Unknown
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected Obj, but got Unknown
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected Obj, but got Unknown
			//IL_00c2: Expected Obj, but got I4
			//IL_0108: Expected I, but got Obj
			//IL_011e: Expected Obj, but got I
			//IL_0144: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Expected VT, but got Unknown
			//IL_0156: Expected F4, but got Obj
			//IL_0151: Expected native int or pointer, but got VT
			//IL_016b: Expected F4, but got I
			//IL_0166: Expected native int or pointer, but got VT
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Expected VT, but got Unknown
			//IL_0186: Expected F4, but got Obj
			//IL_0181: Expected native int or pointer, but got VT
			//IL_019b: Expected F4, but got I
			//IL_0196: Expected native int or pointer, but got VT
			//IL_01bd: Expected F4, but got Obj
			//IL_01b8: Expected native int or pointer, but got VT
			//IL_01d2: Expected F4, but got I
			//IL_01cd: Expected native int or pointer, but got VT
			//IL_01e7: Expected Obj, but got VT
			//IL_01e7: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			AnimationState animationState = caught;
			object obj2 = default;
			object obj = obj2 + 24;
			object obj3 = this + 12;
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S2_v3+8]");
			_ = 0;
			object obj4 = this + 24;
			object obj5 = this + 24;
			object obj6 = this + 12;
			object obj7 = obj2 + 12;
			obj7 = 0;
			_ = 0;
			obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v10+4]");
			float num = 0f - 33f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v13+8]");
			_ = 0;
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v22 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num3 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v36 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 vector = (Vector3)(obj2 + 36);
			((Vector3*)(nint)vector)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v4+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector2 = (Vector3)(obj2 + 48);
			((Vector3*)(nint)vector2)->x = (float)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v16+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			Vector3 vector3 = Vector3.LerpUnclamped(vector, vector2, t);
			((Vector3*)(nint)vector2)->x = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.AnimationState)+3C]");
			((Character)0).UpdateGroundTag((Character)vector2);
		}
	}

	private sealed class _003CCatchPlayerAnimStarter_003Ed__120(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public AnimationState caught;

		public float delay;

		public CharacterRendering _003C_003E4__this;

		private _003C_003Ec__DisplayClass120_0 _003C_003E8__1;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_005c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Expected Obj, but got Unknown
				//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e8: Expected Obj, but got Unknown
				//IL_0104: Expected Obj, but got I4
				//IL_0135: Unknown result type (might be due to invalid IL or missing references)
				//IL_013a: Expected Obj, but got Unknown
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						nint num = 0;
						_ = 0;
						object obj2 = default;
						object obj = obj2 + 16;
						obj = _003C_003E8__1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
						IEnumerator routine = default;
						Coroutine coroutine = _003C_003E4__this.StartCoroutine_Auto(routine);
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj3 = this + 28;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj4 = default;
				obj3 = obj4;
				object obj5 = _003C_003E8__1 + 8;
				obj5 = caught;
				_003C_003Ec__DisplayClass120_0 obj6 = _003C_003E8__1;
				obj6.caught.time = 0f;
				_003C_003Ec__DisplayClass120_0 obj7 = _003C_003E8__1;
				obj7.caught.speed = 0f;
				_003C_003Ec__DisplayClass120_0 obj8 = _003C_003E8__1;
				obj8.caught.wrapMode = WrapMode.Once;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = delay;
				object obj9 = this + 12;
				object obj10 = default;
				obj9 = obj10;
				_003C_003E1__state = 1;
				return 1;
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

	private sealed class _003CRouteCelebrate_Coroutine_003Ed__141(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CharacterRendering _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c9: Expected Obj, but got Unknown
				//IL_00d2: Expected Obj, but got I4
				//IL_00e6: Expected Obj, but got I4
				CharacterRendering characterRendering = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				string bigAirTrick = characterRendering.animations.BigAirTrick;
				AnimationClip animationClip = characterRendering._characterSafeAnimation.GetAnimationClip(bigAirTrick);
				if ((object)animationClip != null)
				{
					((RouteChunk)(object)characterRendering._characterSafeAnimation).HideLogicRecursive((Transform)(object)bigAirTrick, 0.1f);
				}
				object obj = this + 12;
				obj = 0;
				_003C_003E1__state = 1;
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

	private sealed class _003CTeleboardStartScale_003Ed__145(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public CharacterRendering _003C_003E4__this;

		public float gameSpeed;

		private float _003Ctime_003E5__2;

		private float _003CendDuration_003E5__3;

		private Vector3 _003Cmodel1position_003E5__4;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_058f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0594: Expected Obj, but got Unknown
				//IL_059d: Unknown result type (might be due to invalid IL or missing references)
				//IL_05a2: Expected Obj, but got Unknown
				//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
				//IL_05b0: Expected Obj, but got Unknown
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Expected Obj, but got Unknown
				//IL_0096: Unknown result type (might be due to invalid IL or missing references)
				//IL_009b: Expected Obj, but got Unknown
				//IL_00d2: Expected VT, but got I4
				//IL_0161: Expected I, but got Obj
				//IL_0177: Expected Obj, but got I
				//IL_01a2: Expected I, but got Obj
				//IL_0246: Unknown result type (might be due to invalid IL or missing references)
				//IL_024b: Expected Obj, but got Unknown
				//IL_0266: Unknown result type (might be due to invalid IL or missing references)
				//IL_026b: Expected Obj, but got Unknown
				//IL_0290: Unknown result type (might be due to invalid IL or missing references)
				//IL_0295: Expected Obj, but got Unknown
				//IL_02f4: Expected Obj, but got I4
				//IL_0322: Expected Obj, but got F4
				//IL_03b2: Expected I4, but got Obj
				//IL_0555: Unknown result type (might be due to invalid IL or missing references)
				//IL_055a: Expected Obj, but got Unknown
				//IL_0563: Expected Obj, but got I4
				//IL_0577: Expected Obj, but got I4
				//IL_0430: Expected I, but got Obj
				//IL_0446: Expected Obj, but got I
				//IL_0471: Expected I, but got Obj
				object obj = default;
				Transform transform = (Transform)(obj + 36);
				object obj2 = obj + 24;
				object obj3 = obj + 12;
				CharacterRendering characterRendering = _003C_003E4__this;
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
					_003Ctime_003E5__2 = 0f;
					_003CendDuration_003E5__3 = duration;
					object obj4 = characterRendering._character + 248;
					obj2 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v83+8]");
					_ = 0;
					transform = (Transform)obj2;
					Transform transform2 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
					object obj5 = this + 36;
					obj5 = transform;
					_ = ((UnityEngine.Object)transform).m_CachedPtr;
					GameObject gameObject = characterRendering._characterModel.gameObject;
					HierarchyUtility.ReparentByHierarchyPathType((Transform)(object)gameObject, HierarchyPathType.Null, (Vector3)0);
					characterRendering._characterSafeAnimation.Play();
				}
				if (_003Ctime_003E5__2 < duration)
				{
					float unscaledTime = Time.unscaledTime;
					float num = _003Ctime_003E5__2 + unscaledTime;
					_003Ctime_003E5__2 = num;
					nint num2 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S2_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num3 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S2_v54 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num4 = _003Ctime_003E5__2 / duration;
					if (num4 < 0f)
					{
						num4 = 0f;
					}
					else if (num4 > 1f)
					{
						num4 = 1f;
					}
					if (~(characterRendering._isTeleportFxActive ? 1u : 0u) != 0)
					{
						characterRendering.Character_OnEnterRoute();
						return null;
					}
					object obj7 = characterRendering._character + 248;
					obj2 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S1_v20+8]");
					_ = 0;
					object obj8 = this + 36;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					_ = 0;
					GameObject gameObject2 = characterRendering._characterModel.gameObject;
					object obj9 = this + 36;
					obj3 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S2_v12+8]");
					_ = 0;
					transform = (Transform)obj3;
					Transform transform3 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
					Vector3 localPosition = transform.localPosition;
					GameObject gameObject3 = characterRendering._characterModel.gameObject;
					obj = 0;
					_ = 0;
					float num5 = 0.5f * num4;
					float num6 = 1f - num5;
					obj = num6;
					float num7 = 0.5f * num4;
					float num8 = 1f + num7;
					float num9 = 1f - num4;
					transform = (Transform)obj;
					Transform transform4 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
					((Transform)(object)gameObject3).parent = transform;
					float value = num4 * 0.2f;
					((SkinnedMeshRenderer)(object)characterRendering.teleboardFXMaterial).SetBlendShapeWeight((int)"Offset", value);
					if (num4 == 1f)
					{
						GameObject gameObject4 = characterRendering._characterModel.gameObject;
						GameObject gameObject5 = characterRendering.gameObject;
						((Transform)(object)gameObject4).parentInternal = (Transform)(object)gameObject5;
						GameObject gameObject6 = characterRendering._characterModel.gameObject;
						nint num10 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S1_v54 (Il2CppClass<UnityEngine.Vector3>)+BA]");
						object obj10 = (nint)0 & (nint)0x200;
						if (obj10 != null)
						{
							nint num11 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S1_v71 (Il2CppClass<UnityEngine.Vector3>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Vector3 one = Vector3.one;
						transform = (Transform)obj2;
						Transform transform5 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
						((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
						Vector3 eulerAngles = transform.eulerAngles;
						GameObject gameObject7 = characterRendering._characterModel.gameObject;
						Vector3 one2 = Vector3.one;
						transform = (Transform)obj3;
						Transform transform6 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
						((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
						((Transform)(object)gameObject7).parent = transform;
						Character character = characterRendering._character;
						Variable<bool> isGrounded = character.IsGrounded;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v65 (Variable`1<System.Boolean>)+8]");
						if ((nint)0 != 0)
						{
							characterRendering.Game_OnEndStumbleDeathSequence();
						}
						((CharacterCamera)(object)characterRendering).FOVGip(_003CendDuration_003E5__3, gameSpeed);
					}
					object obj11 = this + 12;
					obj11 = 0;
					_003C_003E1__state = 1;
					return 1;
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

	private sealed class _003CTeleboardEndScale_003Ed__147(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public CharacterRendering _003C_003E4__this;

		private float _003Ctime_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00bb: Expected I, but got Obj
				//IL_00d1: Expected Obj, but got I
				//IL_00fc: Expected I, but got Obj
				//IL_0254: Expected I4, but got Obj
				//IL_0193: Unknown result type (might be due to invalid IL or missing references)
				//IL_0198: Expected Obj, but got Unknown
				//IL_01a1: Expected Obj, but got I4
				//IL_01b5: Expected Obj, but got I4
				CharacterRendering characterRendering = _003C_003E4__this;
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
					_003Ctime_003E5__2 = 0f;
				}
				if (_003Ctime_003E5__2 < duration)
				{
					float unscaledTime = Time.unscaledTime;
					float num = _003Ctime_003E5__2 + unscaledTime;
					_003Ctime_003E5__2 = num;
					nint num2 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v21 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num3 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v35 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num4 = _003Ctime_003E5__2 / duration;
					if (num4 < 0f)
					{
						num4 = 0f;
					}
					else if (num4 > 1f)
					{
						num4 = 1f;
					}
					float value = num4 * 0.2f;
					((SkinnedMeshRenderer)(object)characterRendering.teleboardFXMaterial).SetBlendShapeWeight((int)"Offset", value);
					if (num4 == 1f)
					{
						characterRendering.ResetTeleportFx();
					}
					object obj2 = this + 12;
					obj2 = 0;
					_003C_003E1__state = 1;
					return 1;
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

	public Animations animations;

	private CharacterModel _characterModel;

	private static CharacterRendering _instance;

	private Game _game;

	private Character _character;

	private Hoverboard _hoverboard;

	private SuperSneakers _superSneakers;

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

	private static float _DEFAULT_SPEED_RUN_ANIMATION;

	private RouteManager _routeManager;

	private string _lastGrindAnimation;

	private string jumpAnimation;

	private string hangtimeAnimation;

	private bool _queuedHangtime;

	public CharacterModel CharacterModel
	{
		get
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CharacterModel characterModel = default;
			((UnityEngine.Object)characterModel).m_CachedPtr = (IntPtr)0;
			object obj = characterModel + 16;
			obj = this;
			return characterModel;
		}
	}

	public Animation CharacterAnimation => (Animation)(object)_characterModel;

	public unsafe static CharacterRendering Instance
	{
		get
		{
			//IL_0222: Expected I, but got Obj
			//IL_0238: Expected Obj, but got I
			//IL_0373: Expected I, but got Obj
			//IL_0389: Expected Obj, but got I
			//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ba: Expected I, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_0263: Expected I, but got Obj
			//IL_0279: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_01d5: Expected I, but got Obj
			//IL_02b1: Expected I, but got Obj
			//IL_02cc: Expected I, but got Obj
			//IL_02e2: Expected Obj, but got I
			//IL_031a: Expected I, but got Obj
			//IL_0330: Expected Obj, but got I
			//IL_00ee: Expected I, but got Obj
			//IL_013b: Expected I, but got Obj
			//IL_0188: Expected I, but got Obj
			nint num = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Character);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v61 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj3 = default;
			nint num5 = (nint)(obj3 + 4);
			if (Character._instance != null)
			{
				nint num6 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v35 (Il2CppClass<System.Type>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num7 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v57 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj3 = typeof(Character);
				((IntPtr*)num5)->m_value = (void*)(nint)obj3;
				Type type = Type.internal_from_handle((IntPtr)num5);
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num9 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = ((UnityEngine.Object)(object)type).ToString();
				nint num10 = (nint)typeof(Character);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v45 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num11 = (nint)typeof(Character);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v51 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
				Character instance = default;
				Character._instance = instance;
			}
			nint num12 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v19 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num13 = (nint)typeof(Character);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v26 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (CharacterRendering)(object)Character._instance;
		}
	}

	public SafeAnimation CharacterSafeAnimation
	{
		get
		{
			SafeAnimation characterSafeAnimation = _characterSafeAnimation;
			return (SafeAnimation)(object)characterSafeAnimation._animation;
		}
	}

	public SafeAnimation HoverboardSafeAnimation => _characterSafeAnimation;

	public void Initialize()
	{
		//IL_000b: Expected Obj, but got F4
		//IL_0016: Expected Obj, but got F4
		//IL_0021: Expected Obj, but got F4
		jetpackAnimations = (JetpackClips)10f;
		SuperSneaksAnimations = (SuperSneaksClips)2f;
		jetpackParticleOffsetCurve = (AnimationCurve)0.2f;
		CancelInvoke();
	}

	protected unsafe void Awake()
	{
		//IL_18c3: Expected I, but got Obj
		//IL_18d9: Expected Obj, but got I
		//IL_1bc6: Expected I, but got Obj
		//IL_1bdc: Expected Obj, but got I
		//IL_1bff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c04: Expected Obj, but got Unknown
		//IL_1c15: Expected Obj, but got I4
		//IL_1c23: Expected I, but got Obj
		//IL_1c39: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_18fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1901: Expected Obj, but got Unknown
		//IL_1918: Unknown result type (might be due to invalid IL or missing references)
		//IL_191d: Expected Obj, but got Unknown
		//IL_193c: Expected I, but got Obj
		//IL_1952: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_1975: Unknown result type (might be due to invalid IL or missing references)
		//IL_197a: Expected Obj, but got Unknown
		//IL_1999: Expected I, but got Obj
		//IL_19af: Expected Obj, but got I
		//IL_00ad: Expected I, but got Obj
		//IL_19d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d7: Expected Obj, but got Unknown
		//IL_19f7: Expected I, but got Obj
		//IL_1a0d: Expected Obj, but got I
		//IL_00fa: Expected I, but got Obj
		//IL_1a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a35: Expected Obj, but got Unknown
		//IL_1a54: Expected I, but got Obj
		//IL_1a6a: Expected Obj, but got I
		//IL_0147: Expected I, but got Obj
		//IL_1a8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a92: Expected Obj, but got Unknown
		//IL_1ab1: Expected I, but got Obj
		//IL_1ac7: Expected Obj, but got I
		//IL_0194: Expected I, but got Obj
		//IL_1aea: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aef: Expected Obj, but got Unknown
		//IL_1b00: Expected Obj, but got I4
		//IL_1b06: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b0b: Expected Obj, but got Unknown
		//IL_1b14: Expected VT, but got Obj
		//IL_1b1c: Expected Obj, but got VT
		//IL_01e1: Expected I, but got Obj
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected Obj, but got Unknown
		//IL_022e: Expected I, but got Obj
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected Obj, but got Unknown
		//IL_0337: Expected Obj, but got I
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected Obj, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected Obj, but got Unknown
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected Obj, but got Unknown
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected Obj, but got Unknown
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Expected Obj, but got Unknown
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected Obj, but got Unknown
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected Obj, but got Unknown
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected Obj, but got Unknown
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_0629: Expected Obj, but got Unknown
		//IL_0677: Unknown result type (might be due to invalid IL or missing references)
		//IL_067c: Expected Obj, but got Unknown
		//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cf: Expected Obj, but got Unknown
		//IL_0709: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Expected Obj, but got Unknown
		//IL_075c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0761: Expected Obj, but got Unknown
		//IL_07c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cb: Expected Obj, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Expected Obj, but got Unknown
		//IL_07f8: Expected Obj, but got I
		//IL_0848: Unknown result type (might be due to invalid IL or missing references)
		//IL_084d: Expected Obj, but got Unknown
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08aa: Expected Obj, but got Unknown
		//IL_08ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bf: Expected Obj, but got Unknown
		//IL_0930: Unknown result type (might be due to invalid IL or missing references)
		//IL_0935: Expected Obj, but got Unknown
		//IL_0945: Unknown result type (might be due to invalid IL or missing references)
		//IL_094a: Expected Obj, but got Unknown
		//IL_09b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bb: Expected Obj, but got Unknown
		//IL_09cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d0: Expected Obj, but got Unknown
		//IL_0a41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a46: Expected Obj, but got Unknown
		//IL_0a56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5b: Expected Obj, but got Unknown
		//IL_0ac7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acc: Expected Obj, but got Unknown
		//IL_0adc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae1: Expected Obj, but got Unknown
		//IL_0b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4d: Expected Obj, but got Unknown
		//IL_0b9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba0: Expected Obj, but got Unknown
		//IL_0bda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdf: Expected Obj, but got Unknown
		//IL_0c2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c32: Expected Obj, but got Unknown
		//IL_0c4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c51: Expected Obj, but got Unknown
		//IL_0c8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c90: Expected Obj, but got Unknown
		//IL_0ca8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cad: Expected Obj, but got Unknown
		//IL_0ce7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cec: Expected Obj, but got Unknown
		//IL_0d04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d09: Expected Obj, but got Unknown
		//IL_0d43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d48: Expected Obj, but got Unknown
		//IL_0d60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d65: Expected Obj, but got Unknown
		//IL_0d9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da4: Expected Obj, but got Unknown
		//IL_0dc4: Expected I, but got Obj
		//IL_0dda: Expected Obj, but got I
		//IL_0e6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e74: Expected Obj, but got Unknown
		//IL_0e82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e87: Expected Obj, but got Unknown
		//IL_0e05: Expected I, but got Obj
		//IL_0ee9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eee: Expected Obj, but got Unknown
		//IL_0efc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f01: Expected Obj, but got Unknown
		//IL_0f68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6d: Expected Obj, but got Unknown
		//IL_0f7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f80: Expected Obj, but got Unknown
		//IL_0fe2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe7: Expected Obj, but got Unknown
		//IL_0ff5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffa: Expected Obj, but got Unknown
		//IL_100c: Expected Obj, but got I4
		//IL_1078: Unknown result type (might be due to invalid IL or missing references)
		//IL_107d: Expected Obj, but got Unknown
		//IL_108b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1090: Expected Obj, but got Unknown
		//IL_10f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f7: Expected Obj, but got Unknown
		//IL_1105: Unknown result type (might be due to invalid IL or missing references)
		//IL_110a: Expected Obj, but got Unknown
		//IL_1171: Unknown result type (might be due to invalid IL or missing references)
		//IL_1176: Expected Obj, but got Unknown
		//IL_1184: Unknown result type (might be due to invalid IL or missing references)
		//IL_1189: Expected Obj, but got Unknown
		//IL_11eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f0: Expected Obj, but got Unknown
		//IL_11fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1203: Expected Obj, but got Unknown
		//IL_1215: Expected Obj, but got I4
		//IL_1256: Unknown result type (might be due to invalid IL or missing references)
		//IL_125b: Expected Obj, but got Unknown
		//IL_126e: Expected I, but got Obj
		//IL_1284: Expected Obj, but got I
		//IL_1b8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b8f: Expected Obj, but got Unknown
		//IL_1323: Unknown result type (might be due to invalid IL or missing references)
		//IL_1328: Expected Obj, but got Unknown
		//IL_12af: Expected I, but got Obj
		//IL_138d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1392: Expected Obj, but got Unknown
		//IL_13a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a5: Expected Obj, but got Unknown
		//IL_140c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1411: Expected Obj, but got Unknown
		//IL_141f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1424: Expected Obj, but got Unknown
		//IL_1436: Expected Obj, but got I4
		//IL_1486: Unknown result type (might be due to invalid IL or missing references)
		//IL_148b: Expected Obj, but got Unknown
		//IL_1499: Unknown result type (might be due to invalid IL or missing references)
		//IL_149e: Expected Obj, but got Unknown
		//IL_150f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1514: Expected Obj, but got Unknown
		//IL_1524: Unknown result type (might be due to invalid IL or missing references)
		//IL_1529: Expected Obj, but got Unknown
		//IL_158b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1590: Expected Obj, but got Unknown
		//IL_15de: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e3: Expected Obj, but got Unknown
		//IL_1605: Expected VT, but got Obj
		//IL_1613: Expected Obj, but got VT
		//IL_162c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1631: Expected Obj, but got Unknown
		//IL_1651: Unknown result type (might be due to invalid IL or missing references)
		//IL_1656: Expected Obj, but got Unknown
		//IL_1673: Unknown result type (might be due to invalid IL or missing references)
		//IL_1678: Expected Obj, but got Unknown
		//IL_169a: Unknown result type (might be due to invalid IL or missing references)
		//IL_169f: Expected Obj, but got Unknown
		//IL_16c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c6: Expected Obj, but got Unknown
		//IL_16e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ed: Expected Obj, but got Unknown
		//IL_170f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1714: Expected Obj, but got Unknown
		//IL_1736: Unknown result type (might be due to invalid IL or missing references)
		//IL_173b: Expected Obj, but got Unknown
		//IL_175d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1762: Expected Obj, but got Unknown
		//IL_1784: Unknown result type (might be due to invalid IL or missing references)
		//IL_1789: Expected Obj, but got Unknown
		//IL_17ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b0: Expected Obj, but got Unknown
		//IL_17d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d7: Expected Obj, but got Unknown
		//IL_17f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_17fe: Expected Obj, but got Unknown
		//IL_1835: Expected I, but got Obj
		//IL_184b: Expected Obj, but got I
		//IL_1876: Expected I, but got Obj
		nint num = (nint)typeof(CharacterRendering);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterRendering);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v449 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_instance = this;
		nint num3 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v13 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v445 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = this + 56;
		bool isInstantiated = Game.IsInstantiated;
		obj3 = isInstantiated;
		nint num5 = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v20 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v441 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = this + 60;
		CharacterRendering instance = Instance;
		obj5 = instance;
		object obj6 = this + 76;
		Game instance2 = Game.Instance;
		obj6 = instance2;
		nint num7 = (nint)typeof(Hoverboard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v29 (Il2CppClass<Hoverboard>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num8 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v437 (Il2CppClass<Hoverboard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj8 = this - -64;
		CharacterModifier characterModifier = MysteryPowerup.SelectRandomCharacterModifier();
		obj8 = characterModifier;
		nint num9 = (nint)typeof(Utils);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v36 (Il2CppClass<Utils>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num10 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v433 (Il2CppClass<Utils>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj10 = this + 68;
		SuperSneakers superSneakers = Utils.FindObject<SuperSneakers>(this);
		obj10 = superSneakers;
		nint num11 = (nint)typeof(FollowingGuard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v43 (Il2CppClass<FollowingGuard>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num12 = (nint)typeof(FollowingGuard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v429 (Il2CppClass<FollowingGuard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj12 = this + 72;
		IEnumerator enumerator = HouseKeeper.InitAuthAndCloudSave();
		obj12 = enumerator;
		nint num13 = (nint)typeof(Revive);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v50 (Il2CppClass<Revive>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num14 = (nint)typeof(Revive);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v425 (Il2CppClass<Revive>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj14 = this + 88;
		string deviceToken = RemoteNotificationControl.GetDeviceToken();
		obj14 = deviceToken;
		nint num15 = (nint)typeof(CharacterCamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v57 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num16 = (nint)typeof(CharacterCamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v421 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj16 = this + 136;
		int selectedBenchmarkIndex = SubwayBenchmarkContainer.SelectedBenchmarkIndex;
		obj16 = selectedBenchmarkIndex;
		object obj17 = this + 228;
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		obj17 = val;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num17 = 0;
		_ = 0;
		EventHandler<RouteManager.RouteCreatedEventArgs> eventHandler = default;
		object obj18 = eventHandler + 16;
		obj18 = this;
		_routeManager.OnRouteCreated -= eventHandler;
		InitializeCharacterRenderingEffects();
		OnIntroRun();
		InitializeAnimations();
		Game game = _game;
		Variable<bool> isInGame = game.IsInGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj19 = default;
		obj19.method_ptr = method_ptr;
		obj19.method = (nint)__ldftn(CharacterRendering.IsInGame_OnChange);
		object obj20 = obj19 + 16;
		obj20 = this;
		object obj21 = game.IsInGame + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v72 (Variable`1<System.Boolean>)+C]");
		Delegate obj22 = ((Delegate)0).CombineImpl(obj19);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj23 = default;
		obj21 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Character.OnChangeTrackDelegate onChangeTrackDelegate = default;
		((Delegate)onChangeTrackDelegate).method_ptr = method_ptr2;
		((Delegate)onChangeTrackDelegate).method = (nint)__ldftn(CharacterRendering.OnChangeTrack);
		object obj24 = onChangeTrackDelegate + 16;
		obj24 = this;
		_character.OnChangeTrack -= onChangeTrackDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Character.OnStumbleDelegate onStumbleDelegate = default;
		((Delegate)onStumbleDelegate).method_ptr = method_ptr3;
		((Delegate)onStumbleDelegate).method = (nint)__ldftn(CharacterRendering.OnStumble);
		object obj25 = onStumbleDelegate + 16;
		obj25 = this;
		_character.OnStumble -= onStumbleDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		Character.OnReviveDelegate onReviveDelegate = default;
		((Delegate)onReviveDelegate).method_ptr = method_ptr4;
		((Delegate)onReviveDelegate).method = (nint)__ldftn(CharacterRendering.OnRevive);
		object obj26 = onReviveDelegate + 16;
		obj26 = this;
		_character.OnRevive -= onReviveDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr5 = 0;
		Character.OnResetTeleportFXDelegate onResetTeleportFXDelegate = default;
		((Delegate)onResetTeleportFXDelegate).method_ptr = method_ptr5;
		((Delegate)onResetTeleportFXDelegate).method = (nint)__ldftn(CharacterRendering.ResetCharacterTeleportFX);
		object obj27 = onResetTeleportFXDelegate + 16;
		obj27 = this;
		_character.OnResetTeleportFX -= onResetTeleportFXDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr6 = 0;
		Character.OnTutorialMoveBackToCheckPointDelegate onTutorialMoveBackToCheckPointDelegate = default;
		((Delegate)onTutorialMoveBackToCheckPointDelegate).method_ptr = method_ptr6;
		((Delegate)onTutorialMoveBackToCheckPointDelegate).method = (nint)__ldftn(CharacterRendering.OnTutorialMoveBackToCheckPoint);
		object obj28 = onTutorialMoveBackToCheckPointDelegate + 16;
		obj28 = this;
		_character.OnTutorialMoveBackToCheckPoint -= onTutorialMoveBackToCheckPointDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr7 = 0;
		Character.OnTutorialStartFromCheckPointDelegate onTutorialStartFromCheckPointDelegate = default;
		((Delegate)onTutorialStartFromCheckPointDelegate).method_ptr = method_ptr7;
		((Delegate)onTutorialStartFromCheckPointDelegate).method = (nint)__ldftn(CharacterRendering.OnTutorialStartFromCheckPoint);
		object obj29 = onTutorialStartFromCheckPointDelegate + 16;
		obj29 = this;
		_character.OnTutorialStartFromCheckPoint -= onTutorialStartFromCheckPointDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr8 = 0;
		Character.OnHitByTrainDelegate onHitByTrainDelegate = default;
		((Delegate)onHitByTrainDelegate).method_ptr = method_ptr8;
		((Delegate)onHitByTrainDelegate).method = (nint)__ldftn(CharacterRendering.OnHitByTrain);
		object obj30 = onHitByTrainDelegate + 16;
		obj30 = this;
		_character.OnHitByTrain -= onHitByTrainDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr9 = 0;
		Character.OnJumpDelegate onJumpDelegate = default;
		((Delegate)onJumpDelegate).method_ptr = method_ptr9;
		((Delegate)onJumpDelegate).method = (nint)__ldftn(CharacterRendering.OnJump);
		object obj31 = onJumpDelegate + 16;
		obj31 = this;
		_character.OnJump -= onJumpDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr10 = 0;
		Character.OnDoubleJumpDelegate onDoubleJumpDelegate = default;
		((Delegate)onDoubleJumpDelegate).method_ptr = method_ptr10;
		((Delegate)onDoubleJumpDelegate).method = (nint)__ldftn(CharacterRendering.OnDoubleJump);
		object obj32 = onDoubleJumpDelegate + 16;
		obj32 = this;
		_character.OnDoubleJump -= onDoubleJumpDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr11 = 0;
		Character.OnJumpIfHitByTrainDelegate onJumpIfHitByTrainDelegate = default;
		((Delegate)onJumpIfHitByTrainDelegate).method_ptr = method_ptr11;
		((Delegate)onJumpIfHitByTrainDelegate).method = (nint)__ldftn(CharacterRendering.OnJump);
		object obj33 = onJumpIfHitByTrainDelegate + 16;
		obj33 = this;
		_character.OnJumpIfHitByTrain -= onJumpIfHitByTrainDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr12 = 0;
		Character.OnRollDelegate onRollDelegate = default;
		((Delegate)onRollDelegate).method_ptr = method_ptr12;
		((Delegate)onRollDelegate).method = (nint)__ldftn(CharacterRendering.OnRoll);
		object obj34 = onRollDelegate + 16;
		obj34 = this;
		_character.OnRoll -= onRollDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num18 = 0;
		_ = 0;
		Action<Character> action = default;
		object obj35 = action + 16;
		obj35 = this;
		_character.OnLanding -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr13 = 0;
		Character.OnHangtimeDelegate onHangtimeDelegate = default;
		((Delegate)onHangtimeDelegate).method_ptr = method_ptr13;
		((Delegate)onHangtimeDelegate).method = (nint)__ldftn(CharacterRendering.Character_OnHangtime);
		object obj36 = onHangtimeDelegate + 16;
		obj36 = this;
		_character.OnHangtime -= onHangtimeDelegate;
		Character character = _character;
		Variable<bool> isGrounded = character.IsGrounded;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr14 = 0;
		Delegate obj37 = default;
		obj37.method_ptr = method_ptr14;
		obj37.method = (nint)__ldftn(CharacterRendering.OnChangeIsGrounded);
		object obj38 = obj37 + 16;
		obj38 = this;
		object obj39 = character.IsGrounded + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ S0_v113 (Variable`1<System.Boolean>)+C]");
		Delegate obj40 = ((Delegate)0).CombineImpl(obj37);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj41 = default;
		obj39 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr15 = 0;
		Character.OnTeleboardStartDelegate onTeleboardStartDelegate = default;
		((Delegate)onTeleboardStartDelegate).method_ptr = method_ptr15;
		((Delegate)onTeleboardStartDelegate).method = (nint)__ldftn(CharacterRendering.HandleOnTeleboardStart);
		object obj42 = onTeleboardStartDelegate + 16;
		obj42 = this;
		_character.OnTeleboardStart -= onTeleboardStartDelegate;
		Character character2 = _character;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr16 = 0;
		Delegate obj43 = default;
		obj43.method_ptr = method_ptr16;
		obj43.method = (nint)__ldftn(CharacterRendering.OnRouteDone);
		object obj44 = obj43 + 16;
		obj44 = this;
		object obj45 = _character + 372;
		Delegate obj46 = ((Delegate)character2.OnRouteDone).CombineImpl(obj43);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj47 = default;
		obj45 = obj47;
		Character character3 = _character;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr17 = 0;
		Delegate obj48 = default;
		obj48.method_ptr = method_ptr17;
		obj48.method = (nint)__ldftn(CharacterRendering.Character_OnEnterRoute);
		object obj49 = obj48 + 16;
		obj49 = this;
		object obj50 = _character + 380;
		Delegate obj51 = ((Delegate)character3.OnEnterRoute).CombineImpl(obj48);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj52 = default;
		obj50 = obj52;
		Character character4 = _character;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr18 = 0;
		Delegate obj53 = default;
		obj53.method_ptr = method_ptr18;
		obj53.method = (nint)__ldftn(CharacterRendering.Character_OnEnterRouteEnd);
		object obj54 = obj53 + 16;
		obj54 = this;
		object obj55 = _character + 384;
		Delegate obj56 = ((Delegate)character4.OnEnterRouteEnd).CombineImpl(obj53);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj57 = default;
		obj55 = obj57;
		Character character5 = _character;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr19 = 0;
		Delegate obj58 = default;
		obj58.method_ptr = method_ptr19;
		obj58.method = (nint)__ldftn(CharacterRendering.Character_OnExitRoute);
		object obj59 = obj58 + 16;
		obj59 = this;
		object obj60 = _character + 388;
		Delegate obj61 = ((Delegate)character5.OnExitRoute).CombineImpl(obj58);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj62 = default;
		obj60 = obj62;
		Character character6 = _character;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr20 = 0;
		Delegate obj63 = default;
		obj63.method_ptr = method_ptr20;
		obj63.method = (nint)__ldftn(CharacterRendering.ToggleDust);
		object obj64 = obj63 + 16;
		obj64 = this;
		object obj65 = _character + 376;
		Delegate obj66 = ((Delegate)character6.OnToggleDust).CombineImpl(obj63);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj67 = default;
		obj65 = obj67;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr21 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr21;
		((Delegate)action2).method = (nint)__ldftn(CharacterRendering.OnStageMenuSequence);
		object obj68 = action2 + 16;
		obj68 = this;
		_game.OnStageMenuSequence -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr22 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr22;
		((Delegate)action3).method = (nint)__ldftn(CharacterRendering.OnIntroRun);
		object obj69 = action3 + 16;
		obj69 = this;
		_game.OnIntroRun -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num19 = 0;
		_ = 0;
		Action<int> action4 = default;
		object obj70 = action4 + 16;
		obj70 = this;
		_game.OnTurboHeadstartInput -= action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr23 = 0;
		Action action5 = default;
		((Delegate)action5).method_ptr = method_ptr23;
		((Delegate)action5).method = (nint)__ldftn(CharacterRendering.Game_OnEndStumbleDeathSequence);
		object obj71 = action5 + 16;
		obj71 = this;
		_game.OnEndStumbleDeathSequence -= action5;
		object obj72 = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr24 = 0;
		Hoverboard.OnSwitchToHoverboardDelegate onSwitchToHoverboardDelegate = default;
		((Delegate)onSwitchToHoverboardDelegate).method_ptr = method_ptr24;
		((Delegate)onSwitchToHoverboardDelegate).method = (nint)__ldftn(CharacterRendering.OnSwitchToHoverboard);
		object obj73 = onSwitchToHoverboardDelegate + 16;
		obj73 = this;
		((Hoverboard)obj72).OnSwitchToHoverboard -= onSwitchToHoverboardDelegate;
		object obj74 = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr25 = 0;
		Hoverboard.OnEndHoverboardDelegate onEndHoverboardDelegate = default;
		((Delegate)onEndHoverboardDelegate).method_ptr = method_ptr25;
		((Delegate)onEndHoverboardDelegate).method = (nint)__ldftn(CharacterRendering.OnSwitchToRunning);
		object obj75 = onEndHoverboardDelegate + 16;
		obj75 = this;
		((Hoverboard)obj74).OnEndHoverboard -= onEndHoverboardDelegate;
		object obj76 = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr26 = 0;
		Hoverboard.OnHoverboardJumpDelegate onHoverboardJumpDelegate = default;
		((Delegate)onHoverboardJumpDelegate).method_ptr = method_ptr26;
		((Delegate)onHoverboardJumpDelegate).method = (nint)__ldftn(CharacterRendering.OnJump);
		object obj77 = onHoverboardJumpDelegate + 16;
		obj77 = this;
		((Hoverboard)obj76).OnJump -= onHoverboardJumpDelegate;
		object obj78 = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr27 = 0;
		Hoverboard.OnRunDelegate onRunDelegate = default;
		((Delegate)onRunDelegate).method_ptr = method_ptr27;
		((Delegate)onRunDelegate).method = (nint)__ldftn(CharacterRendering.OnRun);
		object obj79 = onRunDelegate + 16;
		obj79 = this;
		((Hoverboard)obj78).OnRun -= onRunDelegate;
		nint num20 = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v864 @ S0_v210 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj80 = (nint)0 & (nint)0x200;
		if (obj80 != null)
		{
			nint num21 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v870 @ S0_v417 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
		ArrayTypeMismatchException ex = new ArrayTypeMismatchException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr28 = 0;
		Delegate obj81 = default;
		obj81.method_ptr = method_ptr28;
		obj81.method = (nint)__ldftn(CharacterRendering.OnSwitchToJetpack);
		object obj82 = obj81 + 16;
		obj82 = this;
		object obj83 = ex + 28;
		Delegate obj84 = ((Delegate)((Exception)ex)._stackTrace).CombineImpl(obj81);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj85 = default;
		obj83 = obj85;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr29 = 0;
		Delegate obj86 = default;
		obj86.method_ptr = method_ptr29;
		obj86.method = (nint)__ldftn(CharacterRendering.JetpackOnStop);
		object obj87 = obj86 + 16;
		obj87 = this;
		object obj88 = ex + 32;
		Delegate obj89 = ((Delegate)(object)((Exception)ex)._stackTraceString).CombineImpl(obj86);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj90 = default;
		obj88 = obj90;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr30 = 0;
		Delegate obj91 = default;
		obj91.method_ptr = method_ptr30;
		obj91.method = (nint)__ldftn(CharacterRendering.JetpackOnFlyAheadStart);
		object obj92 = obj91 + 16;
		obj92 = this;
		object obj93 = ex + 36;
		Delegate obj94 = ((Delegate)(object)((Exception)ex)._remoteStackTraceString).CombineImpl(obj91);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj95 = default;
		obj93 = obj95;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr31 = 0;
		Delegate obj96 = default;
		obj96.method_ptr = method_ptr31;
		obj96.method = (nint)__ldftn(CharacterRendering.JetpackOnFlyAheadUpdate);
		object obj97 = obj96 + 16;
		obj97 = this;
		object obj98 = ex + 40;
		Delegate obj99 = ((Delegate)((Exception)ex)._remoteStackIndex).CombineImpl(obj96);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj100 = default;
		obj98 = obj100;
		bool useBenchmarkRoute2 = RouteManager.UseBenchmarkRoute;
		ArrayTypeMismatchException ex2 = new ArrayTypeMismatchException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr32 = 0;
		Delegate obj101 = default;
		obj101.method_ptr = method_ptr32;
		obj101.method = (nint)__ldftn(CharacterRendering.OnSwitchToJetpack);
		object obj102 = obj101 + 16;
		obj102 = this;
		object obj103 = ex2 + 28;
		Delegate obj104 = ((Delegate)((Exception)ex2)._stackTrace).CombineImpl(obj101);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj105 = default;
		obj103 = obj105;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr33 = 0;
		Delegate obj106 = default;
		obj106.method_ptr = method_ptr33;
		obj106.method = (nint)__ldftn(CharacterRendering.JetpackOnStop);
		object obj107 = obj106 + 16;
		obj107 = this;
		object obj108 = ex2 + 32;
		Delegate obj109 = ((Delegate)(object)((Exception)ex2)._stackTraceString).CombineImpl(obj106);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj110 = default;
		obj108 = obj110;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr34 = 0;
		Delegate obj111 = default;
		obj111.method_ptr = method_ptr34;
		obj111.method = (nint)__ldftn(CharacterRendering.JetpackOnFlyAheadStart);
		object obj112 = obj111 + 16;
		obj112 = this;
		object obj113 = ex2 + 36;
		Delegate obj114 = ((Delegate)(object)((Exception)ex2)._remoteStackTraceString).CombineImpl(obj111);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj115 = default;
		obj113 = obj115;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr35 = 0;
		Delegate obj116 = default;
		obj116.method_ptr = method_ptr35;
		obj116.method = (nint)__ldftn(CharacterRendering.JetpackOnFlyAheadUpdate);
		object obj117 = obj116 + 16;
		obj117 = this;
		object obj118 = ex2 + 40;
		Delegate obj119 = ((Delegate)((Exception)ex2)._remoteStackIndex).CombineImpl(obj116);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj120 = default;
		obj118 = obj120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num22 = 0;
		_ = 0;
		Action<int> action6 = default;
		object obj121 = action6 + 16;
		obj121 = this;
		nint num23 = (nint)typeof(SlideinPowerupHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1138 @ S0_v314 (Il2CppClass<SlideinPowerupHelper>)+BA]");
		object obj122 = (nint)0 & (nint)0x200;
		if (obj122 != null)
		{
			nint num24 = (nint)typeof(SlideinPowerupHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1144 @ S0_v413 (Il2CppClass<SlideinPowerupHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SlideinPowerupHelper.OnScoreBoostActivated -= action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr36 = 0;
		SuperSneakers.OnSwitchToSuperSneakersDelegate onSwitchToSuperSneakersDelegate = default;
		((Delegate)onSwitchToSuperSneakersDelegate).method_ptr = method_ptr36;
		((Delegate)onSwitchToSuperSneakersDelegate).method = (nint)__ldftn(CharacterRendering.OnSwitchToSuperSneakers);
		object obj123 = onSwitchToSuperSneakersDelegate + 16;
		obj123 = this;
		_superSneakers.OnSwitchToSuperSneakers -= onSwitchToSuperSneakersDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr37 = 0;
		SuperSneakers.SuperSneakerOnStopDelegate superSneakerOnStopDelegate = default;
		((Delegate)superSneakerOnStopDelegate).method_ptr = method_ptr37;
		((Delegate)superSneakerOnStopDelegate).method = (nint)__ldftn(CharacterRendering.SuperSneakersOnStop);
		object obj124 = superSneakerOnStopDelegate + 16;
		obj124 = this;
		_superSneakers.SuperSneakerOnStop -= superSneakerOnStopDelegate;
		bool useBenchmarkRoute3 = RouteManager.UseBenchmarkRoute;
		ArrayTypeMismatchException ex3 = new ArrayTypeMismatchException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr38 = 0;
		Delegate obj125 = default;
		obj125.method_ptr = method_ptr38;
		obj125.method = (nint)__ldftn(CharacterRendering.PogostickOnStart);
		object obj126 = obj125 + 16;
		obj126 = this;
		object obj127 = ex3 + 36;
		Delegate obj128 = ((Delegate)(object)((Exception)ex3)._remoteStackTraceString).CombineImpl(obj125);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj129 = default;
		obj127 = obj129;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr39 = 0;
		Delegate obj130 = default;
		obj130.method_ptr = method_ptr39;
		obj130.method = (nint)__ldftn(CharacterRendering.PogostickOnHangtime);
		object obj131 = obj130 + 16;
		obj131 = this;
		object obj132 = ex3 + 40;
		Delegate obj133 = ((Delegate)((Exception)ex3)._remoteStackIndex).CombineImpl(obj130);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj134 = default;
		obj132 = obj134;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr40 = 0;
		Delegate obj135 = default;
		obj135.method_ptr = method_ptr40;
		obj135.method = (nint)__ldftn(CharacterRendering.PogostickOnStop);
		object obj136 = obj135 + 16;
		obj136 = this;
		object obj137 = ex3 + 44;
		Delegate obj138 = ((Delegate)((Exception)ex3)._dynamicMethods).CombineImpl(obj135);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj139 = default;
		obj137 = obj139;
		FollowingGuard followingGuard = _followingGuard;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr41 = 0;
		Delegate obj140 = default;
		obj140.method_ptr = method_ptr41;
		obj140.method = (nint)__ldftn(CharacterRendering.OnCatchPlayer);
		object obj141 = obj140 + 16;
		obj141 = this;
		object obj142 = _followingGuard + 84;
		Delegate obj143 = ((Delegate)followingGuard.OnCatchPlayer).CombineImpl(obj140);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj144 = default;
		obj142 = obj144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr42 = 0;
		Revive.OnReviveDelegate onReviveDelegate2 = default;
		((Delegate)onReviveDelegate2).method_ptr = method_ptr42;
		((Delegate)onReviveDelegate2).method = (nint)__ldftn(CharacterRendering.OnRevive);
		object obj145 = onReviveDelegate2 + 16;
		obj145 = this;
		_revive.OnRevive -= onReviveDelegate2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr43 = 0;
		Revive.OnSwitchToRunningDelegate onSwitchToRunningDelegate = default;
		((Delegate)onSwitchToRunningDelegate).method_ptr = method_ptr43;
		((Delegate)onSwitchToRunningDelegate).method = (nint)__ldftn(CharacterRendering.OnSwitchToRunning);
		object obj146 = onSwitchToRunningDelegate + 16;
		obj146 = this;
		_revive.OnSwitchToRunning -= onSwitchToRunningDelegate;
		_00210 val2 = (_00210)SingletonMonoBehaviour<>.Instantiate();
		CharacterModel characterModel = ((HoverboardModelPreviewFactory)val2).FindCharacterModel((GameObject)(object)"normal");
		((HoverboardModelPreviewFactory)(object)characterModel).HandleOnPopupShown((string)null);
		object obj147 = this + 104;
		_0021_00210[] componentsInChildren = (_0021_00210[])(object)((Component)characterModel).GetComponentsInChildren<T>();
		obj147 = componentsInChildren;
		object obj148 = this + 108;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj149 = default;
		obj148 = obj149;
		object obj150 = _defaultHoverboardAnimationList + 16;
		HoverboardRendering defaultHoverboardRendering = _defaultHoverboardRendering;
		obj150 = defaultHoverboardRendering.defaultHoverboardAnimation;
		object obj151 = _defaultHoverboardAnimationList + 20;
		HoverboardRendering defaultHoverboardRendering2 = _defaultHoverboardRendering;
		obj151 = defaultHoverboardRendering2.runAnimations;
		object obj152 = _defaultHoverboardAnimationList + 24;
		HoverboardRendering defaultHoverboardRendering3 = _defaultHoverboardRendering;
		obj152 = defaultHoverboardRendering3.landAnimations;
		object obj153 = _defaultHoverboardAnimationList + 28;
		HoverboardRendering defaultHoverboardRendering4 = _defaultHoverboardRendering;
		obj153 = defaultHoverboardRendering4.jumpAnimations;
		object obj154 = _defaultHoverboardAnimationList + 32;
		HoverboardRendering defaultHoverboardRendering5 = _defaultHoverboardRendering;
		obj154 = defaultHoverboardRendering5.hangtimeAnimations;
		object obj155 = _defaultHoverboardAnimationList + 36;
		HoverboardRendering defaultHoverboardRendering6 = _defaultHoverboardRendering;
		obj155 = defaultHoverboardRendering6.rollAnimations;
		object obj156 = _defaultHoverboardAnimationList + 40;
		HoverboardRendering defaultHoverboardRendering7 = _defaultHoverboardRendering;
		obj156 = defaultHoverboardRendering7.dodgeLeftAnimations;
		object obj157 = _defaultHoverboardAnimationList + 44;
		HoverboardRendering defaultHoverboardRendering8 = _defaultHoverboardRendering;
		obj157 = defaultHoverboardRendering8.dodgeRightAnimations;
		object obj158 = _defaultHoverboardAnimationList + 48;
		HoverboardRendering defaultHoverboardRendering9 = _defaultHoverboardRendering;
		obj158 = defaultHoverboardRendering9.grindAnimations;
		object obj159 = _defaultHoverboardAnimationList + 52;
		HoverboardRendering defaultHoverboardRendering10 = _defaultHoverboardRendering;
		obj159 = defaultHoverboardRendering10.grindLandAnimations;
		object obj160 = _defaultHoverboardAnimationList + 56;
		HoverboardRendering defaultHoverboardRendering11 = _defaultHoverboardRendering;
		obj160 = defaultHoverboardRendering11.getOnBoardAnimations;
		string obj161 = characterModel.tag;
		nint num25 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1453 @ S1_v502 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj162 = (nint)0 & (nint)0x200;
		if (obj162 != null)
		{
			nint num26 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1459 @ S1_v507 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj161);
	}

	protected void OnDestroy()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CharacterRendering);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterRendering);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_instance = this;
	}

	public CharacterModel RecreateCharacterModel()
	{
		return (CharacterModel)(object)_hoverboardSafeAnimation;
	}

	private void DebugLog(string message)
	{
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00e2: Expected I, but got Obj
		object obj = default;
		Transform transform = (Transform)(obj + 12);
		string hoverboardAnimationName = GetHoverboardAnimationName(message);
		if (hoverboardAnimationName == null)
		{
			return;
		}
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v7 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v23 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PrefabPool prefabPool = PoolManager.GetPrefabPool((Transform)(object)characterModelPrefab);
		GameObject parentInternal = gameObject;
		((Transform)(object)prefabPool).parentInternal = (Transform)(object)parentInternal;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v18 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v29 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		transform = (Transform)obj;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		List<string> list = InitializeClips((AnimationClip[])(object)prefabPool, (IEnumerable<string>)(object)message);
		Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	private void InitializeCharacterModel()
	{
		//IL_00a0: Expected I, but got Obj
		//IL_00b6: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_routeManager).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			_ = 0;
			EventHandler<RouteManager.CharacterRouteChangedEventArgs> eventHandler = default;
			object obj2 = eventHandler + 16;
			obj2 = this;
			_routeManager.OnCharacterRouteChanged += eventHandler;
		}
	}

	private void InitializeCharacterRenderingEffects()
	{
		//IL_01a4: Expected I, but got Obj
		//IL_01ba: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_007f: Expected I, but got Obj
		//IL_0095: Expected Obj, but got I
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		//IL_0239: Expected Obj, but got I
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected Obj, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_00c0: Expected I, but got Obj
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v44 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameObject gameObject = UnityEngine.Object.Instantiate(characterModelPrefab);
		int layer = gameObject.layer;
		GameObject parentInternal = base.gameObject;
		((Transform)layer).parentInternal = (Transform)(object)parentInternal;
		int layer2 = gameObject.layer;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v15 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v40 (Il2CppClass<UnityEngine.Vector3>)+74]");
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
		object obj4 = this + 180;
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S3_v2 (Il2CppMethodInfo)+18]");
		object obj5 = 0;
		object obj6 = obj5;
		object obj7 = obj6 & 0x1FFF;
		object obj8 = obj7 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v91 @ S4_v4 (should have been resolved before IL gen)");
		object obj9 = default;
		obj4 = obj9;
		object obj10 = this + 52;
		CharacterModel component = gameObject.GetComponent<CharacterModel>();
		obj10 = component;
		object obj11 = this + 80;
		CharacterModel characterModel = _characterModel;
		obj11 = characterModel._meshBlobShadow;
		CharacterModel characterModel2 = _characterModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SafeAnimation safeAnimation = default;
		safeAnimation.DebugLog((string)(object)characterModel2._characterAnimation);
		object obj12 = this + 92;
		obj12 = safeAnimation;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SafeAnimation safeAnimation2 = default;
		safeAnimation2.DebugLog(null);
		object obj13 = this + 96;
		obj13 = safeAnimation2;
	}

	private void InitializeAnimations()
	{
		//IL_0183: Expected I, but got Obj
		//IL_0199: Expected Obj, but got I
		//IL_01e5: Expected VT, but got I4
		//IL_01e5: Expected Obj, but got I4
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_00da: Expected Obj, but got I4
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_0107: Expected I4, but got Obj
		//IL_0118: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v35 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameObject gameObject = UnityEngine.Object.Instantiate(characterRenderingEffectsPrefab);
		int layer = gameObject.layer;
		HierarchyUtility.ReparentByHierarchyPathType((Transform)layer, HierarchyPathType.Dynamic, (Vector3)0);
		object obj2 = this + 84;
		_0021_00210 componentInChildren = (_0021_00210)gameObject.GetComponentInChildren<T>();
		obj2 = componentInChildren;
		_characterRenderingEffects.InitializeModel(_characterModel);
		object obj3 = this + 112;
		GameObject gameObject2 = UnityEngine.Object.Instantiate(teleboardWarpPrefab);
		obj3 = gameObject2;
		int layer2 = _teleboardWarpGameObject.layer;
		GameObject parentInternal = _character.gameObject;
		((Transform)layer2).parentInternal = (Transform)(object)parentInternal;
		object obj4 = this + 120;
		Animation component = _teleboardWarpGameObject.GetComponent<Animation>();
		bool flag = component.Play((PlayMode)"teleboardWarp");
		obj4 = flag;
		_teleboardAnimation.speed = 0f;
		_teleboardAnimation.time = 1f;
		_teleboardAnimation.wrapMode = WrapMode.Once;
		_characterSafeAnimation.CrossFadeQueued((string)(object)_teleboardAnimation, 0f);
		_teleboardWarpGameObject.tag = null;
	}

	public List<string> InitializeClips(AnimationClip[] clips, IEnumerable<string> excludedAnimationNames = null)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._items = null;
		object obj = list + 16;
		obj = this;
		object obj2 = list + 24;
		obj2 = clips;
		object obj3 = list + 20;
		obj3 = excludedAnimationNames;
		return list;
	}

	private string GetHoverboardAnimationName(string animationName)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_005d: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [animationName @ L1 (System.String)+E0]");
		if ((nint)0 == 2)
		{
			return (string)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [animationName @ L1 (System.String)+E0]");
		if ((nint)0 == 3)
		{
			GameObject gameObject = characterRenderingEffectsPrefab;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (UnityEngine.GameObject)+60]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v17+8]");
			bool flag = (nint)0 != 0;
			return (string)flag;
		}
		return null;
	}

	private bool HasHoverboardAnimation(string animationToCheck)
	{
		//IL_0082: Expected I, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_00f5: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		string animationStateName = default;
		AnimationState animationState = _hoverboardSafeAnimation.GetAnimationState(animationStateName);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Animations animations = default;
		if (((ComputeShader)(object)animationState).FindKernel((string)null) == 0)
		{
			animations = this.animations;
		}
		return (byte)(int)animations.DEFAULT_HOVERBOARD_ANIMATION != 0;
	}

	private void OnIntroRun()
	{
		throw new IndexOutOfRangeException();
	}

	public void OnRun()
	{
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_01b6: Expected Obj, but got I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_0091: Expected I, but got F4
		//IL_00b8: Expected I4, but got Obj
		//IL_00b8: Expected VT, but got Obj
		//IL_00dd: Expected I4, but got Obj
		//IL_00dd: Expected VT, but got Obj
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_0107: Expected I4, but got Obj
		//IL_0107: Expected VT, but got Obj
		//IL_012c: Expected I4, but got Obj
		//IL_012c: Expected VT, but got Obj
		object obj = _killParticleSystem + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = _killParticleSystem + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			((ParticleSystem)obj5).Clear();
			object obj6 = obj2 + 1;
			obj2 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Animation animation = default;
		animation.Stop();
		object obj7 = animation + 12;
		obj7 = "SetAnimationSpeedEvent";
		((UnityEngine.Object)animation).m_CachedPtr = (IntPtr)0.1f;
		_ = 0;
		SafeAnimation characterSafeAnimation = _characterSafeAnimation;
		AnimationInitializer.Config config = ((AnimationInitializer)(object)characterSafeAnimation._animation).ClampToDefaultAnimationLength((AnimationInitializer.Config)"run", (byte)(int)animation != 0);
		SafeAnimation characterSafeAnimation2 = _characterSafeAnimation;
		AnimationInitializer.Config config2 = ((AnimationInitializer)(object)characterSafeAnimation2._animation).ClampToDefaultAnimationLength((AnimationInitializer.Config)"run2", (byte)(int)animation != 0);
		SafeAnimation characterSafeAnimation3 = _characterSafeAnimation;
		AnimationInitializer.Config config3 = ((AnimationInitializer)(object)characterSafeAnimation3._animation).ClampToDefaultAnimationLength((AnimationInitializer.Config)"run3", (byte)(int)animation != 0);
		SafeAnimation characterSafeAnimation4 = _characterSafeAnimation;
		AnimationInitializer.Config config4 = ((AnimationInitializer)(object)characterSafeAnimation4._animation).ClampToDefaultAnimationLength((AnimationInitializer.Config)"run4_long", (byte)(int)animation != 0);
		OnSwitchToJetpack();
		string land = animations.Land;
		_characterSafeAnimation.CrossFade(land, 0.2f);
		MeshRenderer meshCoinMagnet = _characterModel.MeshCoinMagnet;
		((GameObject)(object)meshCoinMagnet).tag = null;
		_characterModel.StartIdlePopupAnimations();
		_isDeath = false;
	}

	private void OnChangeTrack(Character.OnChangeTrackDirection direction)
	{
	}

	private void OnStumble(Character.StumbleType stumbleType, Character.StumbleHorizontalHit horizontalHit, Character.StumbleVerticalHit verticalHit, string colliderName, bool safeStumble)
	{
		//IL_005e: Expected Obj, but got I4
		if (stumbleType == Character.StumbleType.Bush)
		{
			((CharacterFXController)this).HandleSideStumble();
			return;
		}
		bool flag = horizontalHit == Character.StumbleHorizontalHit.Center;
		bool flag2 = verticalHit == Character.StumbleVerticalHit.Middle;
		object obj = flag & flag2;
		if (obj == null)
		{
			((CharacterFXController)this)._002Ector();
		}
	}

	private unsafe void Game_OnEndStumbleDeathSequence()
	{
		//IL_0142: Expected I, but got Obj
		//IL_0158: Expected Obj, but got I
		//IL_021b: Expected Obj, but got I4
		//IL_0183: Expected I, but got Obj
		Character character = _character;
		if (~(character._isFalling ? 1u : 0u) == 0)
		{
			return;
		}
		Character character2 = _character;
		if (~(character2.__isJumping ? 1u : 0u) == 0)
		{
			return;
		}
		Character character3 = _character;
		if (~(character3._isRolling ? 1u : 0u) == 0 || ~(_isDeath ? 1u : 0u) == 0)
		{
			return;
		}
		string land = animations.Land;
		Game game = _game;
		Game.SpeedInfo speed = game.speed;
		float speed2 = game.__currentSpeed / speed.min;
		_characterSafeAnimation.SetSpeed((AnimationState)(object)land, speed2);
		string text = ((PhysicsScene*)_characterController)->ToString();
		if (text == null)
		{
			return;
		}
		SuperSneakers superSneakers = _superSneakers;
		if (~(superSneakers.isActive ? 1u : 0u) == 0)
		{
			nint num = (nint)typeof(CharacterRendering);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v12 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterRendering);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v17 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_characterSafeAnimation.SetSpeed((AnimationState)(object)land, _DEFAULT_SPEED_RUN_ANIMATION);
		}
		_characterSafeAnimation.PlayQueued(land);
		if (((WorkLoadQueue)(object)_hoverboardSafeAnimation).IsIdle)
		{
			bool flag = HasHoverboardAnimation(land);
			_hoverboardSafeAnimation.PlayQueued((string)flag);
		}
	}

	private void OnChangeIsGrounded(bool isGrounded)
	{
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected Obj, but got Unknown
		//IL_034f: Expected I, but got Obj
		//IL_0365: Expected Obj, but got I
		//IL_0390: Expected I, but got Obj
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_014c: Expected I, but got Obj
		//IL_0162: Expected Obj, but got I
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Expected Obj, but got Unknown
		//IL_018d: Expected I, but got Obj
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected Obj, but got Unknown
		//IL_048e: Expected Obj, but got I4
		//IL_02a4: Expected Obj, but got I4
		Character character = _character;
		Variable<bool> isGrounded2 = character.IsGrounded;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Variable`1<System.Boolean>)+8]");
		if (((nint)0 != 0 || ((Game)null).IsInPogostickMode) && !((Game)null).HasSuperSneakers && ~(_isDeath ? 1u : 0u) != 0)
		{
			string text = ((!isGrounded) ? animations.DodgeRight : animations.StartGrind);
			object obj = this - -64;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v60+54]");
			if ((nint)0 == 0 && !((Game)null).IsInPogostickMode)
			{
				Game game = _game;
				Game.SpeedInfo speed = game.speed;
				float speed2 = game.__currentSpeed / speed.min;
				_characterSafeAnimation.SetSpeed((AnimationState)(object)text, speed2);
			}
			else
			{
				nint num = (nint)typeof(CharacterRendering);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S1_v42 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num2 = (nint)typeof(CharacterRendering);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S1_v47 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				_characterSafeAnimation.SetSpeed((AnimationState)(object)text, _DEFAULT_SPEED_RUN_ANIMATION);
			}
			IEnumerator enumerator = ((CombineableMesh)(object)_characterSafeAnimation).CombineMeshesAsync((IList<CombineableMesh>)(object)jumpAnimation);
			if (enumerator == null)
			{
				((RouteChunk)(object)_characterSafeAnimation).HideLogicRecursive((Transform)(object)text, 0.2f);
			}
			object obj4 = this - -64;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S0_v70+54]");
			if ((nint)0 != 0 && ((WorkLoadQueue)(object)_hoverboardSafeAnimation).IsIdle)
			{
				bool flag = HasHoverboardAnimation(text);
				((RouteChunk)(object)_hoverboardSafeAnimation).HideLogicRecursive((Transform)flag, 0.2f);
			}
		}
		Character character2 = _character;
		if (~(character2.__isJumping ? 1u : 0u) == 0)
		{
			return;
		}
		string land = animations.Land;
		object obj6 = this - -64;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v22+54]");
		if ((nint)0 == 0 && !((Game)null).IsInPogostickMode)
		{
			Game game2 = _game;
			Game.SpeedInfo speed3 = game2.speed;
			float speed4 = game2.__currentSpeed / speed3.min;
			_characterSafeAnimation.SetSpeed((AnimationState)(object)land, speed4);
		}
		else
		{
			nint num3 = (nint)typeof(CharacterRendering);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S1_v14 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num4 = (nint)typeof(CharacterRendering);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S1_v19 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_characterSafeAnimation.SetSpeed((AnimationState)(object)land, _DEFAULT_SPEED_RUN_ANIMATION);
		}
		Game game3 = _game;
		Game game4 = _game;
		CharacterModifierCollection modifiers = game4._modifiers;
		IEnumerator enumerator2 = ((LongMagnet)(object)game3._modifiers).PullPickupSpawnPoint((PickupSpawnPoint)(object)modifiers.hoverboard);
		float fadeLength = ((enumerator2 == null) ? 0.02f : 0.4f);
		_characterSafeAnimation.CrossFade(land, fadeLength);
		object obj9 = this - -64;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S0_v29+54]");
		if ((nint)0 != 0 && ((WorkLoadQueue)(object)_hoverboardSafeAnimation).IsIdle)
		{
			bool flag2 = HasHoverboardAnimation(land);
			_hoverboardSafeAnimation.CrossFade((string)flag2, 0.02f);
		}
	}

	private void OnRoll()
	{
		_isDeath = true;
		string stumbleMix = animations.StumbleMix;
		((RouteChunk)(object)_characterSafeAnimation).HideLogicRecursive((Transform)(object)stumbleMix, 0.2f);
	}

	private IEnumerator OnRollPlayAnimation()
	{
		//IL_002d: Expected I4, but got Obj
		InitializeCharacterRenderingEffects();
		OnIntroRun();
		_characterModel.RemoveCurrentHoverboard();
		_characterRenderingEffects.PlayScoreboostFX((int)_characterModel);
		OnSwitchToRunningAfterAlternateRoute();
		return (IEnumerator)_characterModel;
	}

	private void ToggleDust(bool active)
	{
		//IL_0075: Expected I, but got Obj
		//IL_008b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_shadowMeshRenderer).FindKernel((string)null) != 0)
		{
			_shadowMeshRenderer.shadowCastingMode = (active ? ShadowCastingMode.On : ShadowCastingMode.Off);
		}
	}

	private void EndRollAnimation()
	{
		IEnumerator routine = RouteCelebrate_Coroutine();
		Coroutine coroutine = StartCoroutine_Auto(routine);
	}

	private void OverrideRollTransition()
	{
		_isRolling = false;
		_character.StopStumble();
	}

	private void OnHitByTrain()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_011c: Expected Obj, but got I4
		string land = animations.Land;
		object obj = this - -64;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v8+54]");
		if ((nint)0 != 0)
		{
			_characterSafeAnimation.CrossFade(land, 0.2f);
			if (((WorkLoadQueue)(object)_hoverboardSafeAnimation).IsIdle)
			{
				bool flag = HasHoverboardAnimation(land);
				object obj3 = this - -64;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S2_v8+54]");
				float fadeLength = (((nint)0 == 0) ? 0f : 0.2f);
				_hoverboardSafeAnimation.CrossFade((string)flag, fadeLength);
			}
		}
		else
		{
			_characterSafeAnimation.CrossFade(land, 0.1f);
		}
	}

	private void OnJump()
	{
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_008c: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I
		//IL_0202: Expected VT, but got Obj
		//IL_0202: Expected Obj, but got I4
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_00cd: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		string stumble = animations.Stumble;
		((WorkLoadQueue)(object)_characterSafeAnimation).EnqueueWork((IEnumerator)(object)stumble);
		object obj4 = default;
		object obj3 = obj4 + 12;
		object obj5 = _character + 236;
		obj3 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v11+8]");
		_ = 0;
		object obj6 = obj4 + 24;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v15+8]");
		_ = 0;
		object obj7 = obj2 + 12;
		obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v18+8]");
		_ = 0;
		nint num = (nint)typeof(GamePositionRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v24 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num2 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v46 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isRestricted = AgeRestriction.isRestricted;
		Character character = _character;
		GameObject gameObject = character._characterCamera.gameObject;
		Vector3 gamePosition = ((GamePositionRoot)isRestricted).GetGamePosition((Vector3)gameObject);
		obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj9 = obj2 + 24;
		obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v18+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		object obj11 = default;
		object obj10 = obj11 + 16;
		obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
		IEnumerator routine = default;
		Coroutine coroutine = StartCoroutine_Auto(routine);
	}

	private void OnJump(float jumpHeight, bool willPlaySound)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.CharacterRendering)+134]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9916");
		}
	}

	private void OnJump(int intensity)
	{
		((CharacterStats)(object)_characterRenderingEffects).OnPassedObstacle((Character.ObstaclePassType)intensity);
	}

	private void OnDoubleJump()
	{
		Character character = _character;
		((FramerateTracker)(object)this)._002Ector(character.jumpHeightNormal, 0);
	}

	private void OnRevive()
	{
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_00db: Expected Obj, but got I4
		_isDoublejump = true;
		_characterRenderingEffects.Update();
		object obj = this - -64;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v12+54]");
		if ((nint)0 != 0)
		{
			object obj3 = this + 236;
			string roll = animations.Roll;
			string text = ((List<string>)(object)roll).get_Item(0);
			obj3 = text;
			object obj4 = this + 240;
			string text2 = ((List<string>)(object)roll).get_Item(1);
			obj4 = text2;
		}
		else
		{
			object obj5 = this + 236;
			string doubleHangtime = animations.DoubleHangtime;
			obj5 = doubleHangtime;
		}
		((WorkLoadQueue)(object)_characterSafeAnimation).EnqueueWork((IEnumerator)(object)jumpAnimation);
		object obj6 = this - -64;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v19+54]");
		if ((nint)0 != 0 && ((WorkLoadQueue)(object)_hoverboardSafeAnimation).IsIdle)
		{
			bool flag = HasHoverboardAnimation(jumpAnimation);
			((RouteChunk)(object)_hoverboardSafeAnimation).HideLogicRecursive((Transform)flag, 0.15f);
		}
	}

	public void Character_OnHangtime()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_0024: Expected I, but got Obj
		//IL_003a: Expected Obj, but got I
		//IL_0065: Expected I, but got Obj
		//IL_00b9: Expected Obj, but got I4
		MonoBehaviour.print(this);
		_isDeath = false;
		object obj = this + 236;
		string smallJump = animations.SmallJump;
		obj = smallJump;
		_characterSafeAnimation.Play();
		((WorkLoadQueue)(object)_characterSafeAnimation).EnqueueWork((IEnumerator)(object)jumpAnimation);
		nint num = (nint)typeof(CoinMagnet);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14 (Il2CppClass<CoinMagnet>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(CoinMagnet);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v26 (Il2CppClass<CoinMagnet>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool doubleScoreActive = DoubleScoreMultiplier.doubleScoreActive;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v19 (System.Boolean)+20]");
		if ((nint)0 != 0)
		{
			_characterSafeAnimation.RaiseOnSafeAnimationEvent("hold_magnet", (object)1);
			((WorkLoadQueue)(object)_characterSafeAnimation).EnqueueWork((IEnumerator)(object)"hold_magnet");
		}
	}

	private void Character_OnHangtime_AfterAlternateRoute()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_01e7: Expected Obj, but got I4
		//IL_01ce: Expected Obj, but got I4
		Character character = _character;
		if (~(character._isRolling ? 1u : 0u) == 0)
		{
			return;
		}
		if (~(_isDoublejump ? 1u : 0u) == 0)
		{
			EndGrind();
			return;
		}
		object obj = this - -64;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v10+54]");
		if ((nint)0 == 0 || hangtimeAnimation == null)
		{
			object obj3 = this + 240;
			string doubleJump = animations.DoubleJump;
			obj3 = doubleJump;
		}
		if (~(_queuedHangtime ? 1u : 0u) == 0)
		{
			IEnumerator enumerator = ((CombineableMesh)(object)_characterSafeAnimation).CombineMeshesAsync((IList<CombineableMesh>)(object)jumpAnimation);
			if (enumerator != null)
			{
				_characterSafeAnimation.CrossFade(hangtimeAnimation);
				goto IL_013b;
			}
		}
		((RouteChunk)(object)_characterSafeAnimation).HideLogicRecursive((Transform)(object)hangtimeAnimation, 0.3f);
		goto IL_013b;
		IL_013b:
		if (_hoverboardSafeAnimation != null && ((WorkLoadQueue)(object)_hoverboardSafeAnimation).IsIdle)
		{
			bool queuedHangtime = _queuedHangtime;
			bool flag = HasHoverboardAnimation(hangtimeAnimation);
			if (queuedHangtime)
			{
				_hoverboardSafeAnimation.CrossFade((string)flag);
			}
			else
			{
				((RouteChunk)(object)_hoverboardSafeAnimation).HideLogicRecursive((Transform)flag, 0.3f);
			}
		}
	}

	private unsafe void OnDoubleHangtime()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		_queuedHangtime = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Character.OnRollDelegate onRollDelegate = default;
		((Delegate)onRollDelegate).method_ptr = method_ptr;
		((Delegate)onRollDelegate).method = (nint)__ldftn(CharacterRendering.Character_OnHangtime_AfterAlternateRoute);
		object obj = onRollDelegate + 16;
		obj = this;
		_character.OnRoll += onRollDelegate;
	}

	private void OnLanding(Character character)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 236;
		string smallJump = animations.SmallJump;
		obj = smallJump;
		Character character2 = _character;
		if (character2._isTucked)
		{
			((RouteChunk)(object)_characterSafeAnimation).HideLogicRecursive((Transform)(object)jumpAnimation, 1f);
		}
		else
		{
			((RouteChunk)(object)_characterSafeAnimation).HideLogicRecursive((Transform)(object)jumpAnimation, 0.15f);
		}
	}

	private void StartGrind(int side)
	{
		//IL_03d2: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_0054: Expected I, but got Obj
		//IL_01da: Expected I4, but got Obj
		//IL_0297: Expected Obj, but got I4
		//IL_02be: Expected Obj, but got I4
		((Character)side).LandedOnTrain((Collider)(object)_character);
		string land = animations.Land;
		SuperSneakers superSneakers = _superSneakers;
		if (~(superSneakers.isActive ? 1u : 0u) == 0)
		{
			nint num = (nint)typeof(CharacterRendering);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v89 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterRendering);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v94 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_characterSafeAnimation.SetSpeed((AnimationState)(object)land, _DEFAULT_SPEED_RUN_ANIMATION);
		}
		else
		{
			Game game = _game;
			Game.SpeedInfo speed = game.speed;
			float speed2 = game.__currentSpeed / speed.min;
			_characterSafeAnimation.SetSpeed((AnimationState)(object)land, speed2);
		}
		Character character = _character;
		if (~(character._isRolling ? 1u : 0u) == 0)
		{
			return;
		}
		Character character2 = _character;
		object obj2 = this - -64;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v24+54]");
		string text;
		string text2;
		if ((nint)0 != 0)
		{
			if (character2.CurrentRunPosition__BackingField != Character.RunPositions.train)
			{
				Character character3 = _character;
				if (character3.CurrentRunPosition__BackingField != Character.RunPositions.movingTrain)
				{
					text = animations.BigLand;
					text2 = land;
					goto IL_01eb;
				}
			}
			string randomAnimationName = animations.GetRandomAnimationName((List<string>)(object)"");
			text = string.ConcatArray((string[])(object)randomAnimationName, (int)"_land");
			text2 = randomAnimationName;
			goto IL_01eb;
		}
		if (!(character2.verticalSpeed < -20f))
		{
			((RouteChunk)(object)_characterSafeAnimation).HideLogicRecursive((Transform)(object)land, 0.1f);
			return;
		}
		Character character4 = _character;
		string target;
		if (character4.verticalSpeed < -150f)
		{
			target = animations.SmallLand;
		}
		else
		{
			Character character5 = _character;
			target = ((!(character5.verticalSpeed < -40f)) ? animations.Jump : animations.BigLand);
		}
		((RouteChunk)(object)_characterSafeAnimation).HideLogicRecursive((Transform)(object)target, 0.05f);
		_characterSafeAnimation.CrossFade(land, 0.1f);
		return;
		IL_01eb:
		AnimationClip animationClip = _characterSafeAnimation.GetAnimationClip(text);
		if ((object)animationClip != null)
		{
			((RouteChunk)(object)_characterSafeAnimation).HideLogicRecursive((Transform)(object)text, 0.1f);
		}
		_characterSafeAnimation.CrossFade(text2, 0.2f);
		if (((WorkLoadQueue)(object)_hoverboardSafeAnimation).IsIdle)
		{
			bool flag = HasHoverboardAnimation(text);
			((RouteChunk)(object)_hoverboardSafeAnimation).HideLogicRecursive((Transform)flag, 0.1f);
			bool flag2 = HasHoverboardAnimation(text2);
			_hoverboardSafeAnimation.CrossFade((string)flag2, 0.2f);
		}
	}

	public void EndGrind()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_00b2: Expected Obj, but got I4
		_isDoublejump = false;
		object obj = this - -64;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S0_v4+54]");
		if ((nint)0 == 0 || hangtimeAnimation == null)
		{
			object obj3 = this + 240;
			string turboHeadstart = animations.TurboHeadstart1;
			obj3 = turboHeadstart;
		}
		((RouteChunk)(object)_characterSafeAnimation).HideLogicRecursive((Transform)(object)hangtimeAnimation, 0.3f);
		if (((WorkLoadQueue)(object)_hoverboardSafeAnimation).IsIdle)
		{
			bool flag = HasHoverboardAnimation(hangtimeAnimation);
			((RouteChunk)(object)_hoverboardSafeAnimation).HideLogicRecursive((Transform)flag, 0.3f);
		}
	}

	private void OnGrindExit(int side)
	{
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		string text;
		switch (side)
		{
		default:
			text = "";
			break;
		case 0:
		{
			string wallGrindLeftExit = animations.WallGrindLeftExit;
			text = wallGrindLeftExit;
			break;
		}
		case 1:
		{
			string randomAnimationName = animations.GetRandomAnimationName((List<string>)(object)_lastGrindAnimation);
			text = randomAnimationName;
			break;
		}
		case 2:
		{
			string wallGrindRightExit = animations.WallGrindRightExit;
			text = wallGrindRightExit;
			break;
		}
		}
		AnimationClip animationClip = _characterSafeAnimation.GetAnimationClip(text);
		if ((object)animationClip != null)
		{
			Character character = _character;
			if (character.verticalSpeed > -10f)
			{
				string getOnBoard = animations.GetOnBoard;
				((RouteChunk)(object)_characterSafeAnimation).HideLogicRecursive((Transform)(object)getOnBoard, 0.1f);
				_characterSafeAnimation.CrossFade(text, 0.1f);
			}
			else
			{
				((RouteChunk)(object)_characterSafeAnimation).HideLogicRecursive((Transform)(object)text, 0.1f);
			}
			object obj = this + 232;
			obj = text;
		}
	}

	private void StartWallRide(int side)
	{
		string target;
		if (side != 0)
		{
			bool flag = side == 1;
			target = "";
			if (!flag)
			{
				if (side != 2)
				{
					target = "";
				}
				else
				{
					string routeCelebrate = animations.RouteCelebrate;
					target = routeCelebrate;
				}
			}
		}
		else
		{
			string wallGrindRight = animations.WallGrindRight;
			target = wallGrindRight;
		}
		((RouteChunk)(object)_characterSafeAnimation).HideLogicRecursive((Transform)(object)target, 0.1f);
	}

	private void StopWallRide(int side)
	{
		string target;
		switch (side)
		{
		default:
			target = "";
			break;
		case 0:
		{
			string wallRideLeftExit = animations.WallRideLeftExit;
			target = wallRideLeftExit;
			break;
		}
		case 1:
		{
			string wallRideRightExit = animations.WallRideRightExit;
			target = wallRideRightExit;
			break;
		}
		}
		((RouteChunk)(object)_characterSafeAnimation).HideLogicRecursive((Transform)(object)target, 0.2f);
	}

	private void OnTutorialMoveBackToCheckPoint(float duration)
	{
		//IL_003a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.CharacterRendering)+158]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.CharacterRendering)+158]");
			((Character._003C_003Ec__DisplayClass374_0)0)._003CChangeTrackCoroutine_003Eb__0(duration);
		}
	}

	private void OnTutorialStartFromCheckPoint()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 232;
		obj = "";
	}

	private void OnCatchPlayer(string currentCharacterCaught, float catchUpTime, float waitTimeBeforeScreen)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0039: Expected Obj, but got I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0079: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got I
		//IL_00ee: Expected Obj, but got I4
		//IL_00ee: Expected Obj, but got I4
		//IL_013b: Expected Obj, but got I
		ScrollView scrollView = default;
		object obj = scrollView + 36;
		obj = 0;
		_ = 0;
		ScrollView scrollView2 = (ScrollView)(scrollView + 24);
		float metersInCurrentGame = ((GameStats)currentCharacterCaught.m_firstChar).MetersInCurrentGame;
		scrollView2.FillFromIndex((int)currentCharacterCaught.m_firstChar, metersInCurrentGame, ContainerPivot.Top);
		ScrollView scrollView3 = (ScrollView)(scrollView + 12);
		float minTime = ((CurveParent)currentCharacterCaught.m_firstChar).MinTime;
		scrollView3.FillFromIndex((int)currentCharacterCaught.m_firstChar, minTime, ContainerPivot.Top);
		object obj2 = (nint)((UnityEngine.Object)scrollView3).m_CachedPtr - (nint)((UnityEngine.Object)scrollView2).m_CachedPtr;
		float num = (float)obj2 * catchUpTime;
		float time = (float)(nint)((UnityEngine.Object)scrollView2).m_CachedPtr + num;
		float topOffset = ((Game)currentCharacterCaught.m_firstChar).Speed(time, (Game.SpeedInfo)1);
		scrollView.FillFromIndex((int)currentCharacterCaught.m_firstChar, topOffset, ContainerPivot.Center);
		obj = scrollView;
		_ = ((UnityEngine.Object)scrollView).m_CachedPtr;
		object obj3 = (nint)((UnityEngine.Object)scrollView3).m_CachedPtr - (nint)((UnityEngine.Object)scrollView2).m_CachedPtr;
		float num2 = catchUpTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [currentCharacterCaught @ L1 (System.String)+18]");
		float num3 = num2 - 0f;
		float num4 = (float)obj3 * num3;
		float num5 = waitTimeBeforeScreen / 110f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [currentCharacterCaught @ L1 (System.String)+10]");
		float num6 = (((nint)0 == 0) ? 1f : num5);
		float num7 = num6 * num4;
		float num8 = (float)(nint)((UnityEngine.Object)scrollView2).m_CachedPtr + num7;
		CharacterRendering characterRendering = (CharacterRendering)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
		((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
	}

	private IEnumerator CatchPlayerAnimStarter(AnimationState caught, float delay)
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

	private void OnStageMenuSequence()
	{
		string land = animations.Land;
		((WorkLoadQueue)(object)_characterSafeAnimation).EnqueueWork((IEnumerator)(object)land);
	}

	internal void OnSwitchToRunningAfterAlternateRoute()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected I4, but got Unknown
		//IL_003a: Expected I, but got Obj
		//IL_0050: Expected Obj, but got I
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_02ab: Expected I, but got Obj
		//IL_02c1: Expected Obj, but got I
		//IL_007b: Expected I, but got Obj
		//IL_0204: Expected Obj, but got I4
		//IL_00c8: Expected I, but got Obj
		//IL_0153: Expected I, but got Obj
		//IL_0169: Expected Obj, but got I
		//IL_0194: Expected I, but got Obj
		MonoBehaviour.print(this);
		Character_OnEnterRoute();
		CharacterModel characterModel = _characterModel;
		string sortingLayerName = characterModel._outfitModel.sortingLayerName;
		bool isCachedCustomizationState = (byte)(sortingLayerName & 1) != 0;
		_isCachedCustomizationState = isCachedCustomizationState;
		GameObject gameObject = _characterModel.gameObject;
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v12 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v55 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 zero = Vector2.zero;
		object obj2 = default;
		Transform transform = (Transform)(obj2 + 16);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 localScale = transform.localScale;
		SafeAnimation characterSafeAnimation = _characterSafeAnimation;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v51 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)characterSafeAnimation._animation).FindKernel((string)null) != 0)
		{
			if (_caughtAnimationState.Equals(null))
			{
				_caughtAnimationState.wrapMode = WrapMode.Default;
			}
			nint num5 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S1_v35 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S1_v46 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector2 zero2 = Vector2.zero;
			transform = (Transform)obj2;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			_characterSafeAnimation.CrossFadeQueued((string)(object)transform);
			string introRun = animations.IntroRun;
			((WorkLoadQueue)(object)_characterSafeAnimation).EnqueueWork((IEnumerator)(object)introRun);
		}
		MeshRenderer meshCoinMagnet = _characterModel.MeshCoinMagnet;
		((GameObject)(object)meshCoinMagnet).tag = (string)1;
		_characterModel.StartIdleAnimations(UIModelController.ModelScreen.Character);
		PogostickOnStart();
	}

	public void OnSwitchToRunning()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		OnSwitchToJetpack();
		object obj = this - -64;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S0_v4+54]");
		if ((nint)0 == 0)
		{
			if (~(_isRolling ? 1u : 0u) == 0)
			{
				OnHitByTrain();
			}
			else
			{
				Game_OnEndStumbleDeathSequence();
			}
		}
	}

	private void OnSwitchToHoverboard(HoverboardBundle hoverBoardBundle, Hoverboard.BoardAbility[] abilities)
	{
		//IL_0037: Expected Obj, but got I4
		if (((UnityEngine.Object)(object)abilities).m_CachedPtr != (IntPtr)0)
		{
			bool flag = ((CharacterFXController)this).InGrind((Character)null);
			Coroutine coroutine = StartCoroutine_Auto((IEnumerator)flag);
		}
	}

	private void ToggleCustomHoverboard(HoverboardBundle newHoverboardBundle, Hoverboard.BoardAbility[] abilities)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_00a7: Expected Obj, but got I4
		//IL_01c9: Expected Obj, but got I4
		//IL_0158: Expected Obj, but got I4
		RouteManager_OnRouteCreated(newHoverboardBundle, (RouteManager.RouteCreatedEventArgs)(object)abilities);
		string hitMid = animations.HitMid;
		object obj = this + 240;
		string doubleJump = animations.DoubleJump;
		obj = doubleJump;
		((RouteChunk)(object)_characterSafeAnimation).HideLogicRecursive((Transform)(object)hitMid, 0.1f);
		if (((WorkLoadQueue)(object)_hoverboardSafeAnimation).IsIdle)
		{
			bool flag = HasHoverboardAnimation(hitMid);
			((RouteChunk)(object)_hoverboardSafeAnimation).HideLogicRecursive((Transform)flag, 0.1f);
		}
		Character character = _character;
		if (!character._isFalling)
		{
			Character character2 = _character;
			if (!character2.__isJumping)
			{
				string land = animations.Land;
				_characterSafeAnimation.CrossFade(land, 0.2f);
				if (((WorkLoadQueue)(object)_hoverboardSafeAnimation).IsIdle)
				{
					bool flag2 = HasHoverboardAnimation(land);
					_hoverboardSafeAnimation.CrossFade((string)flag2, 0.2f);
				}
				return;
			}
		}
		((RouteChunk)(object)_characterSafeAnimation).HideLogicRecursive((Transform)(object)hangtimeAnimation, 0.2f);
		if (((WorkLoadQueue)(object)_hoverboardSafeAnimation).IsIdle)
		{
			bool flag3 = HasHoverboardAnimation(hangtimeAnimation);
			_hoverboardSafeAnimation.CrossFade((string)flag3, 0.2f);
		}
	}

	private void OnSwitchToJetpack()
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected Obj, but got Unknown
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected Obj, but got Unknown
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected Obj, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected Obj, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected Obj, but got Unknown
		//IL_02c2: Expected I, but got Obj
		//IL_02d8: Expected Obj, but got I
		//IL_0303: Expected I, but got Obj
		Character character = _character;
		SuperSneakers superSneakers = character._superSneakers;
		if (!superSneakers.isActive)
		{
			Game game = _game;
			CharacterModifierCollection modifiers = game._modifiers;
			SuperSneakers superSneakers2 = modifiers.superSneakers;
			if (!superSneakers2.isActive)
			{
				object obj = animations + 16;
				AnimationClipLists animationClipLists = defaultAnimations;
				string text = ((GoogleSheetsProcessor)(object)this).ConstructGetUriWithParameters((string)(object)animationClipLists.run, (List<GoogleSheetsProcessor.ParameterContainer>)null);
				obj = text;
				goto IL_037a;
			}
		}
		object obj2 = animations + 16;
		SuperSneaksClips superSneaksAnimations = SuperSneaksAnimations;
		string text2 = ((GoogleSheetsProcessor)(object)this).ConstructGetUriWithParameters((string)(object)superSneaksAnimations.run, (List<GoogleSheetsProcessor.ParameterContainer>)null);
		obj2 = text2;
		goto IL_037a;
		IL_037a:
		object obj3 = animations + 20;
		AnimationClipLists animationClipLists2 = defaultAnimations;
		string text3 = ((GoogleSheetsProcessor)(object)this).ConstructGetUriWithParameters((string)(object)animationClipLists2.landing, (List<GoogleSheetsProcessor.ParameterContainer>)null);
		obj3 = text3;
		object obj4 = animations + 24;
		AnimationClipLists animationClipLists3 = defaultAnimations;
		string text4 = ((GoogleSheetsProcessor)(object)this).ConstructGetUriWithParameters((string)(object)animationClipLists3.landing, (List<GoogleSheetsProcessor.ParameterContainer>)null);
		obj4 = text4;
		object obj5 = animations + 28;
		AnimationClipLists animationClipLists4 = defaultAnimations;
		string text5 = ((GoogleSheetsProcessor)(object)this).ConstructGetUriWithParameters((string)(object)animationClipLists4.landing, (List<GoogleSheetsProcessor.ParameterContainer>)null);
		obj5 = text5;
		object obj6 = animations + 36;
		AnimationClipLists animationClipLists5 = defaultAnimations;
		string text6 = ((GoogleSheetsProcessor)(object)this).ConstructGetUriWithParameters((string)(object)animationClipLists5.jump, (List<GoogleSheetsProcessor.ParameterContainer>)null);
		obj6 = text6;
		object obj7 = animations + 88;
		AnimationClipLists animationClipLists6 = defaultAnimations;
		string text7 = ((GoogleSheetsProcessor)(object)this).ConstructGetUriWithParameters((string)(object)animationClipLists6.hitMid, (List<GoogleSheetsProcessor.ParameterContainer>)null);
		obj7 = text7;
		object obj8 = animations + 32;
		AnimationClipLists animationClipLists7 = defaultAnimations;
		string text8 = ((GoogleSheetsProcessor)(object)this).ConstructGetUriWithParameters((string)(object)animationClipLists7.jump, (List<GoogleSheetsProcessor.ParameterContainer>)null);
		obj8 = text8;
		object obj9 = animations + 44;
		AnimationClipLists animationClipLists8 = defaultAnimations;
		string text9 = ((GoogleSheetsProcessor)(object)this).ConstructGetUriWithParameters((string)(object)animationClipLists8.hangtime, (List<GoogleSheetsProcessor.ParameterContainer>)null);
		obj9 = text9;
		object obj10 = animations + 48;
		AnimationClipLists animationClipLists9 = defaultAnimations;
		string text10 = ((GoogleSheetsProcessor)(object)this).ConstructGetUriWithParameters((string)(object)animationClipLists9.doubleJump, (List<GoogleSheetsProcessor.ParameterContainer>)null);
		obj10 = text10;
		object obj11 = animations + 52;
		AnimationClipLists animationClipLists10 = defaultAnimations;
		string text11 = ((GoogleSheetsProcessor)(object)this).ConstructGetUriWithParameters((string)(object)animationClipLists10.doubleHangtime, (List<GoogleSheetsProcessor.ParameterContainer>)null);
		obj11 = text11;
		object obj12 = animations + 56;
		AnimationClipLists animationClipLists11 = defaultAnimations;
		string text12 = ((GoogleSheetsProcessor)(object)this).ConstructGetUriWithParameters((string)(object)animationClipLists11.roll, (List<GoogleSheetsProcessor.ParameterContainer>)null);
		obj12 = text12;
		object obj13 = animations + 60;
		AnimationClipLists animationClipLists12 = defaultAnimations;
		string text13 = ((GoogleSheetsProcessor)(object)this).ConstructGetUriWithParameters((string)(object)animationClipLists12.dodgeLeft, (List<GoogleSheetsProcessor.ParameterContainer>)null);
		obj13 = text13;
		object obj14 = animations - -64;
		AnimationClipLists animationClipLists13 = defaultAnimations;
		string text14 = ((GoogleSheetsProcessor)(object)this).ConstructGetUriWithParameters((string)(object)animationClipLists13.dodgeRight, (List<GoogleSheetsProcessor.ParameterContainer>)null);
		obj14 = text14;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S1_v40 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S1_v47 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_cachedHoverboardBundle).FindKernel((string)null) != 0)
		{
			RouteManager_OnRouteCreated(null, null);
		}
	}

	private void JetpackOnFlyAheadStart()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		object obj = animations + 16;
		JetpackClips jetpackClips = jetpackAnimations;
		string text = ((GoogleSheetsProcessor)(object)this).ConstructGetUriWithParameters((string)(object)jetpackClips.run, (List<GoogleSheetsProcessor.ParameterContainer>)null);
		obj = text;
		object obj2 = animations + 60;
		JetpackClips jetpackClips2 = jetpackAnimations;
		string text2 = ((GoogleSheetsProcessor)(object)this).ConstructGetUriWithParameters((string)(object)jetpackClips2.dodgeLeft, (List<GoogleSheetsProcessor.ParameterContainer>)null);
		obj2 = text2;
		object obj3 = animations - -64;
		JetpackClips jetpackClips3 = jetpackAnimations;
		string text3 = ((GoogleSheetsProcessor)(object)this).ConstructGetUriWithParameters((string)(object)jetpackClips3.dodgeRight, (List<GoogleSheetsProcessor.ParameterContainer>)null);
		obj3 = text3;
		object obj4 = animations + 68;
		JetpackClips jetpackClips4 = jetpackAnimations;
		string text4 = ((GoogleSheetsProcessor)(object)this).ConstructGetUriWithParameters((string)(object)jetpackClips4.turboHeadstart1, (List<GoogleSheetsProcessor.ParameterContainer>)null);
		obj4 = text4;
		object obj5 = animations + 72;
		JetpackClips jetpackClips5 = jetpackAnimations;
		string text5 = ((GoogleSheetsProcessor)(object)this).ConstructGetUriWithParameters((string)(object)jetpackClips5.turboHeadstart2, (List<GoogleSheetsProcessor.ParameterContainer>)null);
		obj5 = text5;
		MeshRenderer meshPogostick = _characterModel.MeshPogostick;
		meshPogostick.shadowCastingMode = ShadowCastingMode.On;
		_characterRenderingEffects.SetPogostickParticlesActive(active: true);
		string land = animations.Land;
		_characterSafeAnimation.PlayQueued(land);
	}

	private void JetpackOnFlyAheadUpdate(float ratio)
	{
		string land = animations.Land;
		((RouteChunk)(object)_characterSafeAnimation).HideLogicRecursive((Transform)(object)land, ratio);
	}

	private void JetpackOnStop()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0054: Expected VT, but got I4
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_00f4: Expected VT, but got I4
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		Transform transform = default;
		object obj = transform + 40;
		obj = 0;
		_ = 0;
		Transform transform2 = (Transform)(transform + 24);
		CharacterRenderingEffects characterRenderingEffects = _characterRenderingEffects;
		int layer = characterRenderingEffects.jetpackParticles.layer;
		transform2.rotation = (Quaternion)layer;
		obj = transform2;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		object obj2 = transform + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F950");
		object obj3 = transform + 56;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v12+8]");
		_ = 0;
		object obj4 = this + 156;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v14+8]");
		_ = 0;
		CharacterRenderingEffects characterRenderingEffects2 = _characterRenderingEffects;
		int layer2 = characterRenderingEffects2.jetpackParticles.layer;
		transform.localScale = (Vector3)layer2;
		obj3 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		object obj5 = this + 168;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v14+8]");
		_ = 0;
	}

	private void HandleOnTurboHeadstart(int version)
	{
		string target;
		switch (version)
		{
		default:
			target = "";
			break;
		case 0:
		{
			string wallRideRight = animations.WallRideRight;
			target = wallRideRight;
			break;
		}
		case 1:
		{
			string wallGrindLeft = animations.WallGrindLeft;
			target = wallGrindLeft;
			break;
		}
		}
		((RouteChunk)(object)_characterSafeAnimation).HideLogicRecursive((Transform)(object)target, 0.1f);
	}

	private void ResetJetpackTrusters()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_0089: Expected Obj, but got I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		_characterRenderingEffects.SetPogostickParticlesActive(active: false);
		CharacterRenderingEffects characterRenderingEffects = _characterRenderingEffects;
		int layer = characterRenderingEffects.jetpackParticles.layer;
		object obj = this + 168;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S2_v3+8]");
		_ = 0;
		Transform transform = (Transform)(obj2 + 12);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		((Transform)layer).parent = transform;
		MeshRenderer meshPogostick = _characterModel.MeshPogostick;
		meshPogostick.shadowCastingMode = ShadowCastingMode.Off;
		object obj3 = this - -64;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v15+54]");
		if ((nint)0 != 0)
		{
			ToggleCustomHoverboard(_cachedHoverboardBundle, _currentBoardAbilities);
			return;
		}
		SuperSneakers superSneakers = _superSneakers;
		if (~(superSneakers.isActive ? 1u : 0u) == 0)
		{
			SuperSneakersOnStop();
		}
		else
		{
			OnSwitchToJetpack();
		}
		Character_OnHangtime_AfterAlternateRoute();
	}

	private unsafe void HandleOnScorebooster(int tier)
	{
		//IL_001e: Expected Obj, but got I4
		//IL_0271: Expected I4, but got Obj
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_0163: Expected Obj, but got I4
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected Obj, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected Obj, but got Unknown
		if (~(_isRolling ? 1u : 0u) == 0)
		{
			OverrideRollTransition();
		}
		object obj = tier - 1;
		string text;
		if (tier != 1)
		{
			if ((nint)obj == 1)
			{
				Character character = _character;
				character.TurboHeadstartParticleSystem.Stop();
				List<string> hoverboardJump = animations.HoverboardJump;
				((RouteChunk)(object)_characterSafeAnimation).HideLogicRecursive((Transform)(object)hoverboardJump, 0.1f);
				string land = animations.Land;
				_characterSafeAnimation.CrossFade(land, 0.2f);
				text = (string)(object)hoverboardJump;
			}
			else
			{
				text = "";
			}
		}
		else
		{
			string turboHeadstart = animations.TurboHeadstart2;
			((RouteChunk)(object)_characterSafeAnimation).HideLogicRecursive((Transform)(object)turboHeadstart, 0.1f);
			string land2 = animations.Land;
			_characterSafeAnimation.CrossFade(land2, 0.2f);
			text = turboHeadstart;
		}
		if (text.get_Chars((int)"") != '\0')
		{
			CharacterModel characterModel = _characterModel;
			object obj2 = characterModel._jetpackThrusters + 12;
			object obj3 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
			{
				object obj4 = characterModel._jetpackThrusters + 16;
				object obj5 = obj3 << 2;
				object obj6 = obj4 + obj5;
				Renderer component = ((Component)obj6).GetComponent<Renderer>();
				component.shadowCastingMode = ShadowCastingMode.On;
				object obj7 = obj3 + 1;
				obj3 = obj7;
			}
			MonoBehaviour.print(this);
			bool flag = _characterSafeAnimation.HasAnimationState(text);
			float distance = (flag ? ((RaycastHit*)1) : ((RaycastHit*)null))->distance;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			object obj9 = default;
			object obj8 = obj9 + 16;
			obj8 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
			IEnumerator routine = default;
			Coroutine coroutine = StartCoroutine_Auto(routine);
		}
	}

	private void PogostickOnStart()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_002b: Expected Obj, but got I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		CharacterModel characterModel = _characterModel;
		if (characterModel._jetpackThrusters != null)
		{
			CharacterModel characterModel2 = _characterModel;
			object obj = characterModel2._jetpackThrusters + 12;
			object obj2 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
			{
				object obj3 = characterModel2._jetpackThrusters + 16;
				object obj4 = obj2 << 2;
				object obj5 = obj3 + obj4;
				Renderer component = ((Component)obj5).GetComponent<Renderer>();
				component.shadowCastingMode = ShadowCastingMode.Off;
				object obj6 = obj2 + 1;
				obj2 = obj6;
			}
		}
	}

	private void PogostickOnHangtime()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		object obj = animations + 16;
		PogostickClips pogostickClips = this.pogostickClips;
		string text = ((GoogleSheetsProcessor)(object)this).ConstructGetUriWithParameters((string)(object)pogostickClips.run, (List<GoogleSheetsProcessor.ParameterContainer>)null);
		obj = text;
		object obj2 = animations + 60;
		PogostickClips pogostickClips2 = this.pogostickClips;
		string text2 = ((GoogleSheetsProcessor)(object)this).ConstructGetUriWithParameters((string)(object)pogostickClips2.dodgeLeft, (List<GoogleSheetsProcessor.ParameterContainer>)null);
		obj2 = text2;
		object obj3 = animations - -64;
		PogostickClips pogostickClips3 = this.pogostickClips;
		string text3 = ((GoogleSheetsProcessor)(object)this).ConstructGetUriWithParameters((string)(object)pogostickClips3.dodgeRight, (List<GoogleSheetsProcessor.ParameterContainer>)null);
		obj3 = text3;
		object obj4 = animations + 44;
		PogostickClips pogostickClips4 = this.pogostickClips;
		CharacterModel characterModel = _characterModel;
		CharacterRig characterRig = characterModel._characterRig;
		CharacterCustomization characterCustomization = characterRig.characterCustomization;
		CharacterCustomizationBundle characterCustomizationBundle = characterCustomization._characterCustomizationBundle;
		CharacterCustomizationBundle.OutfitInfo outfit = characterCustomizationBundle._outfit;
		string text4 = ((GoogleSheetsProcessor)(object)this).ConstructGetUriWithParameters((string)(object)pogostickClips4.hangtime, (List<GoogleSheetsProcessor.ParameterContainer>)(object)outfit.ExcludedAnimationsNames);
		obj4 = text4;
		Transform jetpackCloudPositionL = _characterModel.JetpackCloudPositionL;
		((Renderer)(object)jetpackCloudPositionL).shadowCastingMode = ShadowCastingMode.On;
		CharacterModel characterModel2 = _characterModel;
		characterModel2._meshBlobShadow.shadowCastingMode = ShadowCastingMode.Off;
		_characterRenderingEffects.ToggleDust(active: true);
		Character_OnEnterRoute();
		string land = animations.Land;
		_characterSafeAnimation.PlayQueued(land);
	}

	private void PogostickOnStop()
	{
		string doubleJump = animations.DoubleJump;
		((RouteChunk)(object)_characterSafeAnimation).HideLogicRecursive((Transform)(object)doubleJump, 0.2f);
		_characterRenderingEffects.ToggleDust(active: false);
	}

	private void IsInGame_OnChange(bool isInGame)
	{
		_characterRenderingEffects.SetRightAndLeftParticlesActive(isInGame);
	}

	private void OnSwitchToSuperSneakers()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		Transform jetpackCloudPositionL = _characterModel.JetpackCloudPositionL;
		((Renderer)(object)jetpackCloudPositionL).shadowCastingMode = ShadowCastingMode.Off;
		_characterRenderingEffects.ToggleDust(active: false);
		object obj = this - -64;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v8+54]");
		if ((nint)0 != 0)
		{
			ToggleCustomHoverboard(_cachedHoverboardBundle, _currentBoardAbilities);
			return;
		}
		SuperSneakers superSneakers = _superSneakers;
		if (~(superSneakers.isActive ? 1u : 0u) == 0)
		{
			SuperSneakersOnStop();
			Character_OnHangtime_AfterAlternateRoute();
		}
		else if (!((Game)null).IsInPogostickMode)
		{
			OnSwitchToJetpack();
			Character_OnHangtime_AfterAlternateRoute();
		}
	}

	private void SuperSneakersOnStop()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this - -64;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ S0_v3+54]");
		if ((nint)0 == 0)
		{
			OnSwitchToJetpack();
			if (~(_isRolling ? 1u : 0u) == 0)
			{
				OnHitByTrain();
			}
			else
			{
				Game_OnEndStumbleDeathSequence();
			}
		}
	}

	private void SwitchToAlternateRoute(AlternateRoute route)
	{
		if ((object)route == null)
		{
			ResetJetpackTrusters();
			OnSwitchToSuperSneakers();
		}
	}

	private void SwitchFromAlternateRoute(bool isExitingFromAir)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
		}
		object obj2 = this + 236;
		string routeExit = animations.RouteExit;
		obj2 = routeExit;
		((RouteChunk)(object)_characterSafeAnimation).HideLogicRecursive((Transform)(object)jumpAnimation, 0.1f);
		_characterRenderingEffects.ToggleDust(active: true);
		_queuedHangtime = true;
		Character_OnEnterRoute();
	}

	private IEnumerator RouteCelebrate_Coroutine()
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

	private void SetPieceTransitionTriggerState_OnHangtime()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this - -64;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ S0_v3+54]");
		if ((nint)0 == 0)
		{
			OnSwitchToJetpack();
			Game_OnEndStumbleDeathSequence();
		}
	}

	private void SetPieceTransitionTriggerState_OnEnd()
	{
		string doubleJump = animations.DoubleJump;
		((RouteChunk)(object)_characterSafeAnimation).HideLogicRecursive((Transform)(object)doubleJump, 0.2f);
		ResetCharacterTeleportFX();
	}

	private unsafe void HandleOnTeleboardStart(float duration, Vector3 offset, float gameSpeed)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Expected VT, but got Unknown
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected Obj, but got Unknown
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected Obj, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected Obj, but got Unknown
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected Obj, but got Unknown
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Expected Obj, but got Unknown
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected Obj, but got Unknown
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Expected Obj, but got Unknown
		//IL_0451: Expected Obj, but got I4
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected Obj, but got Unknown
		//IL_0474: Expected Obj, but got I4
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected Obj, but got Unknown
		//IL_04b7: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got F4
		//IL_001c: Expected Obj, but got I4
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected Obj, but got Unknown
		//IL_02c7: Expected Obj, but got I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I4
		//IL_032e: Expected Obj, but got I
		//IL_016f: Expected I, but got Obj
		//IL_0185: Expected Obj, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_054b: Expected F4, but got Obj
		//IL_0546: Expected native int or pointer, but got VT
		//IL_0560: Expected F4, but got I
		//IL_055b: Expected native int or pointer, but got VT
		//IL_057e: Expected Obj, but got F4
		//IL_0596: Expected I, but got Obj
		//IL_05ac: Expected Obj, but got I
		//IL_0038: Expected Obj, but got I4
		//IL_005d: Expected F4, but got Obj
		//IL_0058: Expected native int or pointer, but got VT
		//IL_0072: Expected F4, but got I
		//IL_006d: Expected native int or pointer, but got VT
		//IL_007f: Expected I4, but got VT
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected Obj, but got Unknown
		//IL_0600: Expected F4, but got Obj
		//IL_05fb: Expected native int or pointer, but got VT
		//IL_0615: Expected F4, but got I
		//IL_0610: Expected native int or pointer, but got VT
		//IL_01b0: Expected I, but got Obj
		//IL_01fd: Expected I, but got Obj
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 160;
		Vector3 vector = (Vector3)(obj2 + 136);
		object obj3 = obj2 + 124;
		object obj4 = obj2 + 112;
		object obj5 = obj2 + 52;
		object obj6 = obj2 + 40;
		object obj7 = obj2 + 28;
		object obj8 = obj2 + 16;
		object obj9 = obj2 + 88;
		obj9 = 0;
		_ = 0;
		_ = 0;
		object obj10 = obj2 + 72;
		obj10 = 0;
		_ = 0;
		object obj11 = obj2 - -64;
		obj11 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Vector3> list = default;
		list._002Ector(27);
		object obj12 = -1;
		while ((nint)obj12 <= 1)
		{
			object obj13 = -1;
			while ((nint)obj13 <= 1)
			{
				object obj14 = -1;
				while ((nint)obj14 <= 1)
				{
					obj3 = 0;
					_ = 0;
					obj3 = obj12;
					((Vector3*)(nint)vector)->x = (float)obj3;
					Vector3 vector2 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					((Vector3*)(nint)vector2)->z = 0f;
					list._002Ector((int)vector);
					object obj15 = obj14 + 1;
					obj14 = obj15;
				}
				object obj16 = obj13 + 1;
				obj13 = obj16;
			}
			object obj17 = obj12 + 1;
			obj12 = obj17;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BBBC");
		obj9 = vector.x;
		_ = vector.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3)+10]");
		_ = 0;
		object obj18 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj18 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj10 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			_ = 0;
			obj6 = this;
			_ = ((UnityEngine.Object)this).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S0_v114 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num2 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S0_v146 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			((Vector3*)(nint)vector)->x = (float)obj7;
			Vector3 vector3 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
			((Vector3*)(nint)vector3)->z = 0f;
			Vector3 vector4 = vector / duration;
			obj2 = offset.x;
			_ = offset.z;
			nint num3 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ S0_v124 (Il2CppClass<UnityEngine.Debug>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num4 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ S0_v139 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			obj4 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
			_ = 0;
			obj3 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
			_ = 0;
			((Vector3*)(nint)vector)->x = (float)obj2;
			Vector3 vector5 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector5)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @29");
		}
		object obj21 = obj11 + 4;
		object obj22 = obj21 + 1;
		obj21 = obj22;
		object obj23 = obj22 << 2;
		object obj24 = obj11 + obj23;
		obj24 = 126;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v33+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v33+4]");
			object obj25 = (nint)0 << 2;
			object obj26 = obj11 + obj25;
			if ((nint)obj26 == 126)
			{
				object obj27 = obj11 + 4;
				if ((nint)obj27 > -1)
				{
					object obj28 = obj27 + -1;
					obj27 = obj28;
				}
				return;
			}
		}
		object obj29 = default;
		if (obj29 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private IEnumerator TeleboardStartScale(float duration, float gameSpeed)
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

	public void HandleOnTeleboardEnd(float duration, float gameSpeed)
	{
		//IL_041c: Expected I, but got Obj
		//IL_0432: Expected Obj, but got I
		//IL_01bb: Expected I, but got Obj
		//IL_023a: Expected I, but got Obj
		//IL_0250: Expected Obj, but got I
		//IL_027b: Expected I, but got Obj
		//IL_02e0: Expected Obj, but got I4
		//IL_0320: Expected Obj, but got I
		((BoardPromotion)(object)this)._002Ector();
		SuperSneaksClips superSneaksAnimations = SuperSneaksAnimations;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v12 (SYBO.Subway.Characters.CharacterRendering+SuperSneaksClips)+14]");
		if ((nint)0 == 0)
		{
			return;
		}
		RouteBuilderWorker.WorkWrapper workWrapper = ((Queue<RouteBuilderWorker.WorkWrapper>)(object)SuperSneaksAnimations).Peek();
		float num2;
		if (workWrapper.WorkType == RouteBuilderWorker.WorkType.Spawning)
		{
			float timeInDefaultRoute = ((RouteManager)(object)workWrapper.Chunk).TimeInDefaultRoute;
			float num = timeInDefaultRoute - duration;
			if (num < 0f)
			{
				num2 = 1f;
			}
			else if (num < 100f)
			{
				float num3 = 100f - num;
				num2 = num3 / 100f;
			}
			else
			{
				num2 = 0f;
			}
		}
		else
		{
			EnvironmentBaseKind environmentBaseKind = RouteChunk.EnvironentBaseToBaseKind((EnvironmentBase)(object)workWrapper.Chunk);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			float num4 = 0f - gameSpeed;
			if (num4 < 0f)
			{
				num2 = 1f;
			}
			else if (num4 < 1830f)
			{
				float num5 = 1830f - num4;
				num2 = num5 / 1830f;
			}
			else
			{
				num2 = 0f;
			}
		}
		nint num6 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v23 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num7 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v66 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float t;
		if (num2 > 0f)
		{
			t = num2;
		}
		else
		{
			t = 0f;
			num2 = 0f;
		}
		if (num2 == 1f)
		{
			((MultiplePlaceholderPrefabProvider.GenericSpawnInfo)(object)workWrapper)._002Ector();
		}
		else
		{
			nint num8 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v41 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num9 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v59 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num10 = Mathf.LerpUnclamped(0.002f, 0.005f, t);
			float maxDelay = NetworkServer.maxDelay;
			object obj3;
			do
			{
				bool flag = ((ModelSelectionPlaceholderLifecycle._003CCombineMeshesAsync_003Ed__12)(object)workWrapper).MoveNext();
				float maxDelay2 = NetworkServer.maxDelay;
				float num11 = maxDelay2 - maxDelay;
				bool flag2 = workWrapper.Work();
				bool flag3 = num11 < num10;
				bool flag4 = !flag3;
				obj3 = flag2 | flag4;
			}
			while (obj3 == null);
		}
		if (workWrapper.Work())
		{
			_00210 val = (_00210)((Queue<T>)(object)SuperSneaksAnimations).Peek();
			bool flag5 = ((Dictionary<RouteChunk, RouteBuilderWorker.WorkWrapper>)(nint)((UnityEngine.Object)this).m_CachedPtr).Remove(workWrapper.Chunk);
		}
	}

	private IEnumerator TeleboardEndScale(float duration)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = this;
		return enumerator;
	}

	private void ResetCharacterTeleportFX()
	{
		_characterRenderingEffects.ToggleDust(active: false);
	}

	private unsafe void OnApplicationPause(bool isApplicationPaused)
	{
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		if (isApplicationPaused)
		{
			Character character = _character;
			if (~(character._isRolling ? 1u : 0u) != 0)
			{
				object obj = this + 236;
				string routeEnter = animations.RouteEnter;
				obj = routeEnter;
				AnimationClip animationClip = _characterSafeAnimation.GetAnimationClip(jumpAnimation);
				if ((object)animationClip != null)
				{
					((RouteChunk)(object)_characterSafeAnimation).HideLogicRecursive((Transform)(object)jumpAnimation, 0.3f);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Character.OnHangtimeDelegate onHangtimeDelegate = default;
			((Delegate)onHangtimeDelegate).method_ptr = method_ptr;
			((Delegate)onHangtimeDelegate).method = (nint)__ldftn(CharacterRendering.Character_OnHangtime_AfterAlternateRoute);
			object obj2 = onHangtimeDelegate + 16;
			obj2 = this;
			_character.OnHangtime -= onHangtimeDelegate;
		}
		else
		{
			OnSwitchToRunning();
		}
	}

	public void ResetTeleportFx()
	{
		//IL_0022: Expected I, but got Obj
		//IL_0038: Expected Obj, but got I
		//IL_07f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f5: Expected Obj, but got Unknown
		//IL_0807: Unknown result type (might be due to invalid IL or missing references)
		//IL_080c: Expected Obj, but got Unknown
		//IL_0063: Expected I, but got Obj
		//IL_0157: Expected I, but got Obj
		//IL_016d: Expected Obj, but got I
		//IL_08f7: Expected I, but got Obj
		//IL_090d: Expected Obj, but got I
		//IL_0198: Expected I, but got Obj
		//IL_01ef: Expected I, but got Obj
		//IL_0205: Expected Obj, but got I
		//IL_052e: Expected I, but got Obj
		//IL_0b54: Expected I, but got Obj
		//IL_0b6a: Expected Obj, but got I
		//IL_08b6: Expected I, but got Obj
		//IL_08cc: Expected Obj, but got I
		//IL_0230: Expected I, but got Obj
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Expected Obj, but got Unknown
		//IL_05de: Expected Obj, but got I4
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected Obj, but got Unknown
		//IL_05b1: Expected Obj, but got I4
		//IL_09f6: Expected I, but got Obj
		//IL_0a0c: Expected Obj, but got I
		//IL_05f1: Expected I, but got Obj
		//IL_02cd: Expected I, but got Obj
		//IL_02ba: Expected Obj, but got I4
		//IL_0a37: Expected I, but got Obj
		//IL_0a4d: Expected Obj, but got I
		//IL_0687: Expected I, but got Obj
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Expected Obj, but got Unknown
		//IL_0674: Expected Obj, but got I4
		//IL_071d: Expected I, but got Obj
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Expected Obj, but got Unknown
		//IL_070a: Expected Obj, but got I4
		//IL_0792: Unknown result type (might be due to invalid IL or missing references)
		//IL_0797: Expected Obj, but got Unknown
		//IL_07a0: Expected Obj, but got I4
		//IL_03b3: Expected I, but got Obj
		//IL_03c9: Expected Obj, but got I
		//IL_03f4: Expected I, but got Obj
		//IL_0461: Expected I, but got Obj
		//IL_0477: Expected Obj, but got I
		//IL_04a2: Expected I, but got Obj
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected Obj, but got Unknown
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected Obj, but got Unknown
		GameObject gameObject = _characterModel.gameObject;
		GameObject parentInternal = base.gameObject;
		((Transform)(object)gameObject).parentInternal = (Transform)(object)parentInternal;
		GameObject gameObject2 = _characterModel.gameObject;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v8 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v159 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 12;
		Vector3 one = Vector3.one;
		Transform transform = (Transform)(obj3 + 24);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v13+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		GameObject gameObject3 = _characterModel.gameObject;
		Vector3 forward = Vector3.forward;
		transform = (Transform)obj3;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		((Transform)(object)gameObject3).parent = transform;
		CharacterModel characterModel = _characterModel;
		characterModel._model.shadowCastingMode = ShadowCastingMode.On;
		CharacterModel characterModel2 = _characterModel;
		characterModel2._headModel.shadowCastingMode = ShadowCastingMode.On;
		CharacterModel characterModel3 = _characterModel;
		bool isCachedCustomizationState = _isCachedCustomizationState;
		characterModel3._outfitModel.shadowCastingMode = (isCachedCustomizationState ? ShadowCastingMode.On : ShadowCastingMode.Off);
		nint num3 = (nint)typeof(Hoverboard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v27 (Il2CppClass<Hoverboard>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v150 (Il2CppClass<Hoverboard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterModifier characterModifier = MysteryPowerup.SelectRandomCharacterModifier();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v32 (CharacterModifier)+54]");
		if ((nint)0 != 0)
		{
			CharacterModel characterModel4 = _characterModel;
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v108 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S1_v155 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)characterModel4._currentHoverboard).FindKernel((string)null) != 0 && !((Game)null).HasSuperSneakers)
			{
				CharacterModel characterModel5 = _characterModel;
				characterModel5._currentHoverboard.tag = (string)1;
			}
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S1_v115 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S1_v149 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)_cachedHoverboardMaterial).FindKernel((string)null) != 0)
			{
				CharacterModel characterModel6 = _characterModel;
				characterModel6.currentHoverboadBasemodel.sharedMaterials = (Material[])(object)_cachedHoverboardMaterial;
			}
			if (_cachedCustomHoverboardModelMaterials != null)
			{
				Material[] cachedCustomHoverboardModelMaterials = _cachedCustomHoverboardModelMaterials;
				if (cachedCustomHoverboardModelMaterials.Length != 0)
				{
					int num9 = 0;
					while (true)
					{
						CharacterModel characterModel7 = _characterModel;
						List<Renderer> currentCustomBoardModelsRenderes = characterModel7.currentCustomBoardModelsRenderes;
						if (num9 >= currentCustomBoardModelsRenderes._size)
						{
							break;
						}
						CharacterModel characterModel8 = _characterModel;
						Renderer renderer = characterModel8.currentCustomBoardModelsRenderes.get_Item(num9);
						nint num10 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S1_v128 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj7 = (nint)0 & (nint)0x200;
						if (obj7 != null)
						{
							nint num11 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ S1_v143 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (((ComputeShader)(object)renderer).FindKernel((string)null) != 0)
						{
							CharacterModel characterModel9 = _characterModel;
							Renderer renderer2 = characterModel9.currentCustomBoardModelsRenderes.get_Item(num9);
							nint num12 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ S0_v128 (Il2CppClass<UnityEngine.Object>)+BA]");
							object obj8 = (nint)0 & (nint)0x200;
							if (obj8 != null)
							{
								nint num13 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ S0_v135 (Il2CppClass<UnityEngine.Object>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (((ComputeShader)(object)renderer2).FindKernel((string)null) != 0)
							{
								object obj9 = _cachedCustomHoverboardModelMaterials + 16;
								int num14 = num9 << 2;
								object sharedMaterials = obj9 + num14;
								renderer2.sharedMaterials = (Material[])sharedMaterials;
							}
						}
						int num15 = num9 + 1;
						num9 = num15;
					}
				}
			}
		}
		nint num16 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num17 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S1_v103 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_cachedModelMaterial).FindKernel((string)null) != 0)
		{
			CharacterModel characterModel10 = _characterModel;
			Renderer component = characterModel10._model.GetComponent<Renderer>();
			component.sharedMaterials = (Material[])(object)_cachedModelMaterial;
			object obj11 = this + 188;
			obj11 = 0;
		}
		if (_cachedHeadMaterials != null)
		{
			CharacterModel characterModel11 = _characterModel;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FA1F");
			object obj12 = this + 192;
			obj12 = 0;
		}
		nint num18 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num19 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S1_v89 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_cachedCustomizationMaterial).FindKernel((string)null) != 0)
		{
			CharacterModel characterModel12 = _characterModel;
			Renderer component2 = characterModel12._outfitModel.GetComponent<Renderer>();
			component2.sharedMaterials = (Material[])(object)_cachedCustomizationMaterial;
			object obj14 = this + 196;
			obj14 = 0;
		}
		nint num20 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S1_v46 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num21 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S1_v79 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_cachedSupersneakersMaterial).FindKernel((string)null) != 0)
		{
			CharacterModel characterModel13 = _characterModel;
			Renderer component3 = characterModel13._meshSuperSneaker.GetComponent<Renderer>();
			component3.sharedMaterials = (Material[])(object)_cachedSupersneakersMaterial;
			object obj16 = this + 204;
			obj16 = 0;
		}
		nint num22 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S1_v53 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num23 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ S1_v69 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_cachedDoubleJumperMaterial).FindKernel((string)null) != 0)
		{
			CharacterModel characterModel14 = _characterModel;
			Renderer component4 = characterModel14._doubleJumpers.GetComponent<Renderer>();
			component4.sharedMaterials = (Material[])(object)_cachedDoubleJumperMaterial;
			object obj18 = this + 208;
			obj18 = 0;
		}
		((ScriptBehaviour)(object)_characterSafeAnimation)._002Ector();
		Character character = _character;
		Variable<bool> isGrounded = character.IsGrounded;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ S0_v60 (Variable`1<System.Boolean>)+8]");
		if ((nint)0 != 0)
		{
			Game_OnEndStumbleDeathSequence();
		}
		_isTeleportFxActive = false;
	}

	private void Character_OnEnterRoute()
	{
		if (~(_isTeleportFxActive ? 1u : 0u) == 0)
		{
			MonoBehaviour.print(this);
			ResetTeleportFx();
		}
	}

	private void Character_OnEnterRouteEnd()
	{
	}

	private void Character_OnExitRoute()
	{
		_characterRenderingEffects.ToggleDust(active: false);
	}

	private unsafe void RouteManager_OnRouteCreated(object sender, RouteManager.RouteCreatedEventArgs args)
	{
		//IL_0950: Expected I, but got Obj
		//IL_0966: Expected Obj, but got I
		//IL_0991: Expected I, but got Obj
		//IL_09a7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected Obj, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected Obj, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected Obj, but got Unknown
		//IL_02c0: Expected I, but got Obj
		//IL_02d6: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_0a1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a20: Expected Obj, but got Unknown
		//IL_0a29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2e: Expected Obj, but got Unknown
		//IL_01d8: Expected I, but got Obj
		//IL_01ee: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_090e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0913: Expected Obj, but got Unknown
		//IL_091c: Expected Obj, but got I4
		//IL_0922: Unknown result type (might be due to invalid IL or missing references)
		//IL_0927: Expected Obj, but got Unknown
		//IL_0930: Expected Obj, but got I4
		//IL_0301: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0350: Expected Obj, but got I4
		//IL_035e: Expected I, but got Obj
		//IL_0374: Expected Obj, but got I
		//IL_0219: Expected I, but got Obj
		//IL_012f: Expected I, but got Obj
		//IL_039f: Expected I, but got Obj
		//IL_0453: Expected Obj, but got I4
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected Obj, but got Unknown
		//IL_03ff: Expected Obj, but got I
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected Obj, but got Unknown
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected Obj, but got Unknown
		//IL_0b3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3f: Expected Obj, but got Unknown
		//IL_0b67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6c: Expected Obj, but got Unknown
		//IL_0475: Expected I, but got Obj
		//IL_048b: Expected Obj, but got I
		//IL_0825: Expected Obj, but got I
		//IL_0836: Unknown result type (might be due to invalid IL or missing references)
		//IL_083b: Expected Obj, but got Unknown
		//IL_0844: Unknown result type (might be due to invalid IL or missing references)
		//IL_0849: Expected Obj, but got Unknown
		//IL_0869: Expected I, but got Obj
		//IL_087f: Expected Obj, but got I
		//IL_0ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac5: Expected I4, but got Unknown
		//IL_0ad2: Expected I4, but got Obj
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected Obj, but got Unknown
		//IL_04b6: Expected I, but got Obj
		//IL_0d2e: Expected I4, but got Obj
		//IL_08aa: Expected I, but got Obj
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected Obj, but got Unknown
		//IL_08ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f4: Expected Obj, but got Unknown
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected Obj, but got Unknown
		//IL_05c8: Expected I, but got Obj
		//IL_05de: Expected Obj, but got I
		//IL_0b90: Expected Obj, but got I
		//IL_0609: Expected I, but got Obj
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected Obj, but got Unknown
		//IL_0696: Expected I, but got Obj
		//IL_06ac: Expected Obj, but got I
		//IL_0bb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbc: Expected Obj, but got Unknown
		//IL_0bcd: Expected Obj, but got I
		//IL_0be6: Expected Obj, but got I4
		//IL_0733: Expected I, but got Obj
		//IL_0749: Expected Obj, but got I
		//IL_06d7: Expected I, but got Obj
		//IL_0c3b: Expected I, but got Obj
		//IL_0c51: Expected Obj, but got I
		//IL_0774: Expected I, but got Obj
		//IL_07c1: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v191 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_cachedHoverboardBundle).FindKernel((string)null) != 0)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v172 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v187 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)_cachedHoverboardBundle).FindKernel((string)sender) != 0)
			{
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v178 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S1_v183 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UnityEngine.Object.DestroyImmediate(_cachedHoverboardBundle);
			}
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v167 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_extraTeleportFX).FindKernel((string)null) != 0)
		{
			string obj5 = _extraTeleportFX.tag;
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v158 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num10 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v163 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj5);
		}
		object obj7 = this + 148;
		obj7 = sender;
		object obj8 = this + 152;
		obj8 = args;
		object obj9 = this + 212;
		CharacterModel characterModel = _characterModel;
		List<Renderer> currentCustomBoardModelsRenderes = characterModel.currentCustomBoardModelsRenderes;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj10 = default;
		obj9 = obj10;
		nint num11 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v127 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj12 = default;
		Transform transform = (Transform)(obj12 + 32);
		object obj13 = obj12 + 16;
		if (((ComputeShader)sender).FindKernel((string)null) != 0)
		{
			_teleboardWarpGameObject.tag = (string)1;
			nint num13 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S1_v37 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num14 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S1_v152 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (_telewarpRenderer != null)
			{
				object obj15 = this + 116;
				nint num15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S3_v10 (Il2CppMethodInfo)+18]");
				object obj16 = 0;
				object obj17 = obj16;
				object obj18 = obj17 & 0x1FFF;
				object obj19 = obj18 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v258 @ S4_v12 (should have been resolved before IL gen)");
				object obj20 = default;
				obj15 = obj20;
			}
			_telewarpRenderer.shadowCastingMode = ShadowCastingMode.Off;
			_teleboardAnimation.speed = 0f;
			_teleboardAnimation.time = 0f;
			_teleboardAnimation.wrapMode = WrapMode.Default;
			object obj21 = 1;
			while (true)
			{
				HoverboardBundle cachedHoverboardBundle = _cachedHoverboardBundle;
				HoverboardBundle.CustomSet[] customSets = cachedHoverboardBundle.customSets;
				if ((nint)obj21 >= customSets.Length)
				{
					break;
				}
				CharacterModel charactermodel = _cachedHoverboardBundle.Charactermodel;
				nint num16 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S1_v80 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj22 = (nint)0 & (nint)0x200;
				if (obj22 != null)
				{
					nint num17 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S1_v144 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				HoverboardThemes.ThemeIdentifier themeId = (HoverboardThemes.ThemeIdentifier)(obj21 - 1);
				if (BoardManager.IsThemeOwned((Boards.BoardId)charactermodel, themeId))
				{
					HoverboardBundle cachedHoverboardBundle2 = _cachedHoverboardBundle;
					object obj23 = cachedHoverboardBundle2.customSets + 16;
					object obj24 = obj21 << 2;
					object obj25 = obj23 + obj24;
					object obj26 = obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ S0_v87+8]");
					if ((nint)0 == 7)
					{
						HoverboardBundle cachedHoverboardBundle3 = _cachedHoverboardBundle;
						object obj27 = cachedHoverboardBundle3.customSets + 16;
						object obj28 = obj21 << 2;
						object obj29 = obj27 + obj28;
						object obj30 = obj29;
						nint num18 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ S1_v96 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj31 = (nint)0 & (nint)0x200;
						if (obj31 != null)
						{
							nint num19 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ S1_v140 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ S0_v95+20]");
						if (((ComputeShader)0).FindKernel(null) == 0)
						{
							break;
						}
						HoverboardBundle cachedHoverboardBundle4 = _cachedHoverboardBundle;
						object obj32 = cachedHoverboardBundle4.customSets + 16;
						object obj33 = obj21 << 2;
						object obj34 = obj32 + obj33;
						object obj35 = obj34;
						nint num20 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ S0_v106 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj36 = (nint)0 & (nint)0x200;
						if (obj36 != null)
						{
							nint num21 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ S0_v121 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						object obj37 = this + 216;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ S0_v103+20]");
						GameObject gameObject = UnityEngine.Object.Instantiate((GameObject)0);
						int layer = gameObject.layer;
						obj37 = layer;
						GameObject parentInternal = _character.gameObject;
						_extraTeleportFX.parentInternal = (Transform)(object)parentInternal;
						nint num22 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ S1_v113 (Il2CppClass<UnityEngine.Vector3>)+BA]");
						object obj38 = (nint)0 & (nint)0x200;
						if (obj38 != null)
						{
							nint num23 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ S1_v136 (Il2CppClass<UnityEngine.Vector3>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Vector3 one = Vector3.one;
						transform = (Transform)obj13;
						Transform transform2 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v30+8]");
						((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
						Vector3 eulerAngles = transform.eulerAngles;
						nint num24 = (nint)typeof(Quaternion);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ S1_v122 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
						object obj39 = (nint)0 & (nint)0x200;
						if (obj39 != null)
						{
							nint num25 = (nint)typeof(Quaternion);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ S1_v132 (Il2CppClass<UnityEngine.Quaternion>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Vector2 zero = Vector2.zero;
						transform = (Transform)obj12;
						Transform transform3 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
						Vector3 localScale = transform.localScale;
						string text = _extraTeleportFX.tag;
						((GameObject)(object)text).tag = null;
						break;
					}
				}
				object obj40 = obj21 + 1;
				obj21 = obj40;
			}
			object obj41 = _hoverboardSafeAnimation + 16;
			string text2 = ((Component)sender).tag;
			Animation component = ((GameObject)(object)text2).GetComponent<Animation>();
			obj41 = component;
			object obj42 = this + 140;
			string text3 = ((Component)sender).tag;
			nint num26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ S3_v4 (Il2CppMethodInfo)+18]");
			object obj43 = 0;
			object obj44 = obj43;
			object obj45 = obj44 & 0x1FFF;
			object obj46 = obj45 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v385 @ S4_v6 (should have been resolved before IL gen)");
			object obj47 = default;
			obj42 = obj47;
			nint num27 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ S1_v62 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj48 = (nint)0 & (nint)0x200;
			if (obj48 != null)
			{
				nint num28 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ S1_v74 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)_hoverboardRendering).FindKernel((string)null) == 0)
			{
				object obj49 = this + 140;
				obj49 = _defaultHoverboardRendering;
			}
			SafeAnimation characterSafeAnimation = _characterSafeAnimation;
			SafeAnimation hoverboardSafeAnimation = _hoverboardSafeAnimation;
			((HouseKeeper)(object)_hoverboardRendering).IncrementTypeOfOwnedCharacter((SYBO.Subway.Info.Characters.CharacterId)characterSafeAnimation._animation, ref *(int*)hoverboardSafeAnimation._animation, ref *(int*)_defaultHoverboardAnimationList, ref *(int*)_addedAnimClipsNames, ref *(int*)args);
		}
		else
		{
			object obj50 = _hoverboardSafeAnimation + 16;
			obj50 = 0;
			object obj51 = this + 140;
			obj51 = 0;
			_teleboardWarpGameObject.tag = null;
		}
	}

	private unsafe void AlternateRoute_OnCharacterEntryStarted(object sender, Route.CharacterEntryStartedEventArgs args)
	{
		//IL_0173: Expected I, but got Obj
		//IL_0189: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v53 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ComputeShader computeShader = default;
		if (computeShader.FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			_ = 0;
			EventHandler<Route.CharacterExitedEventArgs> eventHandler = default;
			object obj2 = eventHandler + 16;
			obj2 = this;
			((Route)(object)computeShader).OnCharacterExited -= eventHandler;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			EventHandler eventHandler2 = default;
			((Delegate)eventHandler2).method_ptr = method_ptr;
			((Delegate)eventHandler2).method = (nint)__ldftn(CharacterRendering.AlternateRoute_OnDestructing);
			object obj3 = eventHandler2 + 16;
			obj3 = this;
			((Route)(object)computeShader).OnDestructing -= eventHandler2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num4 = 0;
			_ = 0;
			EventHandler<Route.CharacterEntryStartedEventArgs> eventHandler3 = default;
			object obj4 = eventHandler3 + 16;
			obj4 = this;
			((Route)(object)computeShader).OnCharacterEntryStarted -= eventHandler3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			EventHandler<Route.CharacterEntrySkippedEventArgs> eventHandler4 = default;
			object obj5 = eventHandler4 + 16;
			obj5 = this;
			((Route)(object)computeShader).OnCharacterEntrySkipped -= eventHandler4;
		}
	}

	private void AlternateRoute_OnCharacterEntrySkipped(object sender, Route.CharacterEntrySkippedEventArgs args)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		bool isExitingFromAir = default;
		SwitchFromAlternateRoute(isExitingFromAir);
	}

	private void AlternateRoute_OnCharacterExited(object sender, Route.CharacterExitedEventArgs args)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [args @ L2 (System.Object)+8]");
		if ((nint)0 != 0)
		{
			((CameraData)(object)this).CameraDataMode = CameraDataMode.CameraUpdateEnabled_IgnoreMe;
		}
	}

	private void OnRouteDone(bool isRouteDestructing)
	{
		if (isRouteDestructing)
		{
			Character_OnEnterRoute();
		}
	}

	private unsafe void AlternateRoute_OnDestructing(object sender, EventArgs args)
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		EventHandler eventHandler = default;
		((Delegate)eventHandler).method_ptr = method_ptr;
		((Delegate)eventHandler).method = (nint)__ldftn(CharacterRendering.AlternateRoute_OnCharacterExited);
		object obj = eventHandler + 16;
		obj = this;
		Route route = default;
		route.OnDestructing += eventHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		EventHandler<Route.CharacterEnteredEventArgs> eventHandler2 = default;
		object obj2 = eventHandler2 + 16;
		obj2 = this;
		route.OnCharacterEntered += eventHandler2;
		OnApplicationPause(isApplicationPaused: true);
	}

	private unsafe void _003CHandleOnTurboHeadstart_003Eb__130_0(float t)
	{
		//IL_0206: Expected I, but got Obj
		//IL_021c: Expected Obj, but got I
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected Obj, but got Unknown
		//IL_02b1: Expected Obj, but got I4
		//IL_02bf: Expected Obj, but got F4
		//IL_02d9: Expected I, but got Obj
		//IL_02ef: Expected Obj, but got I
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected VT, but got Unknown
		//IL_0327: Expected F4, but got Obj
		//IL_0322: Expected native int or pointer, but got VT
		//IL_033c: Expected F4, but got I
		//IL_0337: Expected native int or pointer, but got VT
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected VT, but got Unknown
		//IL_0357: Expected F4, but got Obj
		//IL_0352: Expected native int or pointer, but got VT
		//IL_036c: Expected F4, but got I
		//IL_0367: Expected native int or pointer, but got VT
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected Obj, but got Unknown
		//IL_0399: Expected I, but got Obj
		//IL_03af: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_03d9: Expected F4, but got Obj
		//IL_03d4: Expected native int or pointer, but got VT
		//IL_03ee: Expected F4, but got I
		//IL_03e9: Expected native int or pointer, but got VT
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected Ref, but got Unknown
		//IL_0409: Expected Ref, but got VT
		//IL_041b: Expected F4, but got VT
		//IL_0416: Expected native int or pointer, but got VT
		//IL_0430: Expected F4, but got I
		//IL_042b: Expected native int or pointer, but got VT
		//IL_0439: Expected Obj, but got VT
		//IL_0060: Expected I, but got Obj
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_0131: Expected Obj, but got I4
		//IL_0140: Expected Obj, but got F4
		//IL_0168: Expected F4, but got Obj
		//IL_0163: Expected native int or pointer, but got VT
		//IL_017d: Expected F4, but got I
		//IL_0178: Expected native int or pointer, but got VT
		//IL_018a: Expected F4, but got Obj
		//IL_0185: Expected native int or pointer, but got VT
		//IL_019f: Expected F4, but got I
		//IL_019a: Expected native int or pointer, but got VT
		//IL_01bd: Expected F4, but got Obj
		//IL_01b8: Expected native int or pointer, but got VT
		//IL_01d2: Expected F4, but got I
		//IL_01cd: Expected native int or pointer, but got VT
		//IL_01df: Expected Obj, but got VT
		//IL_01df: Expected Obj, but got I4
		//IL_00ad: Expected I, but got Obj
		float t2 = PlayerPrefs.GetFloat((string)(object)jetpackParticleOffsetCurve, t);
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v27 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = Mathf.LerpUnclamped(0f, 1f, t2);
		CharacterRenderingEffects characterRenderingEffects = _characterRenderingEffects;
		int layer = characterRenderingEffects.jetpackParticles.layer;
		object obj3 = default;
		object obj2 = obj3 + 80;
		object obj4 = this + 156;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S2_v5+8]");
		_ = 0;
		object obj5 = obj3 + 68;
		obj5 = 0;
		_ = 0;
		obj5 = num3;
		_ = 0f;
		_ = 0f;
		nint num4 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v17 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v63 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj3 + 92);
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v8+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector2 = (Vector3)(obj3 + 104);
		((Vector3*)(nint)vector2)->x = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v11+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj7 = obj3 + 56;
		Quaternion quaternion = Quaternion.FromToRotation(vector, vector2);
		nint num6 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v30 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num7 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S1_v59 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S1_v28+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		ref Quaternion reference = ref *(Quaternion*)(obj3 + 40);
		Quaternion.Inverse_Injected(ref reference, out *(Quaternion*)vector2);
		((Vector3*)(nint)vector2)->x = (float)reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S1_v37 (UnityEngine.Quaternion&)+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Quaternion localRotation = ((Transform)vector2).localRotation;
		CharacterRenderingEffects characterRenderingEffects2 = _characterRenderingEffects;
		int layer2 = characterRenderingEffects2.jetpackParticles.layer;
		object obj9 = obj3 + 24;
		object obj10 = this + 168;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S2_v42+8]");
		_ = 0;
		object obj11 = obj3 + 12;
		obj11 = 0;
		_ = 0;
		obj11 = 0f;
		_ = 0f;
		float num8 = num3 * 2f;
		((Vector3*)(nint)vector)->x = (float)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v43+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S1_v46+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector3 = vector - vector2;
		((Vector3*)(nint)vector2)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		((Transform)layer2).parent = (Transform)vector2;
	}
}

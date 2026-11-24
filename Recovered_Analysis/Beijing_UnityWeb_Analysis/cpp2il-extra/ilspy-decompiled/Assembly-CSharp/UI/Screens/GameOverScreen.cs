using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ABTest;
using Cpp2ILInjected;
using Data.Save;
using InApp;
using Info;
using Kiloo;
using Kiloo.Common.Backend.PurchaseValidation;
using Kiloo.Common.Extensions;
using Kiloo.Common.Plugins.DeviceUtility;
using Missions;
using SYBO.Subway;
using SYBO.Subway.Info;
using UI.Breadcrumbs;
using UI.DoubleCoinsVideo;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.Screens.PauseScreenInternal;
using UI.Screens.RewardManagement;
using UnityEngine;

namespace UI.Screens;

public class GameOverScreen : RunStartScreen
{
	private enum DoubleCoinsElementType
	{
		Button,
		SmallBanner,
		BigBanner
	}

	public enum ActiveTabState
	{
		LeaderBoard,
		TopRun
	}

	private sealed class _003CCorouReloadFriends_003Ed__103(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public bool framedelay;

		public GameOverScreen _003C_003E4__this;

		private float _003Cframestamp_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0061: Expected I, but got Obj
				//IL_0077: Expected Obj, but got I
				//IL_00a2: Expected I, but got Obj
				//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ea: Expected Obj, but got Unknown
				//IL_01f3: Expected Obj, but got I4
				//IL_0207: Expected Obj, but got I4
				//IL_0164: Invalid comparison between F4 and I4
				//IL_010d: Expected F4, but got I4
				//IL_0189: Unknown result type (might be due to invalid IL or missing references)
				//IL_018e: Expected Obj, but got Unknown
				//IL_0197: Expected Obj, but got I4
				//IL_01ab: Expected Obj, but got I4
				GameOverScreen gameOverScreen = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							return null;
						}
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					nint num = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v34 (Il2CppClass<UIScreenController>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num2 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v45 (Il2CppClass<UIScreenController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					FPSLog instance = FPSLog.instance;
					if (instance == null || ~(framedelay ? 1u : 0u) != 0)
					{
						goto IL_01b0;
					}
					int renderedFrameCount = Time.renderedFrameCount;
					_003Cframestamp_003E5__2 = renderedFrameCount;
				}
				int renderedFrameCount2 = Time.renderedFrameCount;
				float num3 = _003Cframestamp_003E5__2 + 2f;
				if (num3 > (float)renderedFrameCount2)
				{
					object obj2 = this + 12;
					obj2 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				goto IL_01b0;
				IL_01b0:
				if (~(gameOverScreen._leaderboardTabActive ? 1u : 0u) == 0)
				{
					gameOverScreen.leaderboardHandler.ScrollToMyPosition();
				}
				object obj3 = this + 12;
				obj3 = 0;
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

	private sealed class _003CCountUpCoins_003Ed__111(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public GameOverScreen _003C_003E4__this;

		private float _003CcountTime_003E5__2;

		private float _003CcountFactor_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_05b1: Expected Obj, but got I4
				//IL_0061: Expected I, but got Obj
				//IL_0077: Expected Obj, but got I
				//IL_0631: Unknown result type (might be due to invalid IL or missing references)
				//IL_0636: Expected Obj, but got Unknown
				//IL_00a2: Expected I, but got Obj
				//IL_0152: Expected Obj, but got I4
				//IL_010e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0113: Expected Obj, but got Unknown
				//IL_012f: Expected Obj, but got I4
				//IL_02c1: Expected I, but got Obj
				//IL_02d7: Expected Obj, but got I
				//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c5: Expected Obj, but got Unknown
				//IL_0667: Expected F4, but got I4
				//IL_0667: Expected F4, but got I4
				//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f4: Expected Obj, but got Unknown
				//IL_0370: Expected F4, but got I4
				//IL_0370: Expected F4, but got I4
				//IL_0302: Expected I, but got Obj
				//IL_021e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0223: Expected Obj, but got Unknown
				//IL_03df: Expected F4, but got I4
				//IL_03df: Expected F4, but got I4
				//IL_042c: Expected I, but got Obj
				//IL_0442: Expected Obj, but got I
				//IL_0581: Unknown result type (might be due to invalid IL or missing references)
				//IL_0586: Expected Obj, but got Unknown
				//IL_058f: Expected Obj, but got I4
				//IL_05a3: Expected Obj, but got I4
				//IL_046d: Expected I, but got Obj
				//IL_04ba: Expected I, but got Obj
				//IL_04d0: Expected Obj, but got I
				//IL_06dc: Expected F4, but got I4
				//IL_06dc: Expected F4, but got I4
				//IL_04fb: Expected I, but got Obj
				object obj = 0;
				GameOverScreen gameOverScreen = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							return null;
						}
						_003C_003E1__state = -1;
					}
					else
					{
						_003C_003E1__state = -1;
						((CoinEarnerLoadingOffer)(object)gameOverScreen._coinBoxSizer).Init((Action)1);
						_003CcountFactor_003E5__3 = 0f;
					}
					if (!(_003CcountFactor_003E5__3 < 1f))
					{
						_ = 0;
						object obj2 = gameOverScreen + 112;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
						int fontSize = default;
						gameOverScreen.scoreLabel.fontSize = fontSize;
						object obj3 = gameOverScreen + 120;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
						int fontSize2 = default;
						gameOverScreen._coinboxLabel.fontSize = fontSize2;
						object obj4 = gameOverScreen + 128;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
						int fontSize3 = default;
						gameOverScreen.collectedCoinLabel.fontSize = fontSize3;
						gameOverScreen._countingUpCoins = false;
						gameOverScreen.OnFriendsChanged();
						return null;
					}
					((CameraCulling)(object)gameOverScreen._scoreCounterSoundPlayer).TransparentFXCullingDistance = _003CcountFactor_003E5__3;
					float unscaledTime = Time.unscaledTime;
					float num = unscaledTime / _003CcountTime_003E5__2;
					float num2 = _003CcountFactor_003E5__3 + num;
					_003CcountFactor_003E5__3 = num2;
					nint num3 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S1_v33 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num4 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S1_v78 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float width = Mathf.InverseLerp(gameOverScreen._scoreFrom, gameOverScreen._scoreTo, _003CcountFactor_003E5__3);
					GUILayoutOption gUILayoutOption = GUILayout.Width(width);
					obj = gUILayoutOption;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
					int fontSize4 = default;
					gameOverScreen.scoreLabel.fontSize = fontSize4;
					float width2 = Mathf.InverseLerp(gameOverScreen._coinboxFrom, gameOverScreen._coinboxTo, _003CcountFactor_003E5__3);
					GUILayoutOption gUILayoutOption2 = GUILayout.Width(width2);
					obj = gUILayoutOption2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
					int fontSize5 = default;
					gameOverScreen._coinboxLabel.fontSize = fontSize5;
					gameOverScreen._coinBoxSizer._AdjustKeysSegmentSize();
					float width3 = Mathf.InverseLerp(gameOverScreen._collectedCoinsFrom, gameOverScreen._collectedCoinsTo, _003CcountFactor_003E5__3);
					GUILayoutOption gUILayoutOption3 = GUILayout.Width(width3);
					obj = gUILayoutOption3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
					int fontSize6 = default;
					gameOverScreen.collectedCoinLabel.fontSize = fontSize6;
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S1_v48 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num6 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S1_v74 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)gameOverScreen._doubleCoinsVideoElement).FindKernel((string)null) != 0)
					{
						nint num7 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S1_v62 (Il2CppClass<UnityEngine.Mathf>)+BA]");
						object obj7 = (nint)0 & (nint)0x200;
						if (obj7 != null)
						{
							nint num8 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S1_v70 (Il2CppClass<UnityEngine.Mathf>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						float f = Mathf.InverseLerp(gameOverScreen._collectedCoinsFrom, gameOverScreen._collectedCoinsTo, _003CcountFactor_003E5__3);
						int num9 = NumberExtensions.CeilToInt(f);
						bool flag = Breadcrumb.CheckNewWeeklyHunt();
						if (num9 < (flag ? 1 : 0))
						{
							bool flag2 = (byte)num9 != 0;
						}
						else
						{
							bool flag2 = flag;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
					}
					object obj8 = this + 12;
					obj8 = 0;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				nint num10 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v18 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num11 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v34 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float t = (float)gameOverScreen._collectedCoinsTo / 100f;
				float num12 = Mathf.LerpUnclamped(0.3f, 2f, t);
				_003CcountTime_003E5__2 = num12;
				gameOverScreen._countingUpCoins = true;
				gameOverScreen.onTabClicked += null;
				object obj10 = gameOverScreen + 124;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
				int fontSize7 = default;
				gameOverScreen.collectedCoinLabel.fontSize = fontSize7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 1.2f;
				object obj11 = this + 12;
				object obj12 = default;
				obj11 = obj12;
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

	private sealed class _003CCountUpDoubleCoinsVideo_003Ed__112(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public GameOverScreen _003C_003E4__this;

		public int coinsToPayout;

		private int _003Cfrom_003E5__2;

		private int _003Cto_003E5__3;

		private float _003CcountTime_003E5__4;

		private int _003CtotalTo_003E5__5;

		private int _003CtotalFrom_003E5__6;

		private float _003CcountFactor_003E5__7;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_047a: Unknown result type (might be due to invalid IL or missing references)
				//IL_047f: Expected VT, but got Unknown
				//IL_0488: Unknown result type (might be due to invalid IL or missing references)
				//IL_048d: Expected Obj, but got Unknown
				//IL_0496: Expected Obj, but got I4
				//IL_008b: Expected I, but got Obj
				//IL_00a1: Expected Obj, but got I
				//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
				//IL_04fd: Expected Obj, but got Unknown
				//IL_00cc: Expected I, but got Obj
				//IL_0198: Expected Obj, but got I4
				//IL_0154: Unknown result type (might be due to invalid IL or missing references)
				//IL_0159: Expected Obj, but got Unknown
				//IL_0175: Expected Obj, but got I4
				//IL_0263: Expected I, but got Obj
				//IL_0279: Expected Obj, but got I
				//IL_053a: Expected F4, but got I4
				//IL_053a: Expected F4, but got I4
				//IL_0553: Expected Obj, but got I4
				//IL_02a4: Expected I, but got Obj
				//IL_0320: Expected I, but got Obj
				//IL_0336: Expected Obj, but got I
				//IL_0579: Expected Obj, but got I4
				//IL_059b: Expected I4, but got Obj
				//IL_0596: Expected native int or pointer, but got VT
				//IL_0361: Expected I, but got Obj
				object obj = default;
				Color32 color = (Color32)(obj + 24);
				object obj2 = obj + 16;
				obj2 = 0;
				GameOverScreen gameOverScreen = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							return null;
						}
						_003C_003E1__state = -1;
					}
					else
					{
						_003C_003E1__state = -1;
						((CoinEarnerLoadingOffer)(object)gameOverScreen._coinBoxSizer).Init((Action)1);
						_003CcountFactor_003E5__7 = 0f;
					}
					if (!(_003CcountFactor_003E5__7 < 1f))
					{
						_ = 0;
						return null;
					}
					((CameraCulling)(object)gameOverScreen._scoreCounterSoundPlayer).TransparentFXCullingDistance = _003CcountFactor_003E5__7;
					float unscaledTime = Time.unscaledTime;
					float num = unscaledTime / _003CcountTime_003E5__4;
					float num2 = _003CcountFactor_003E5__7 + num;
					_003CcountFactor_003E5__7 = num2;
					nint num3 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S1_v43 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num4 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S1_v80 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float f = Mathf.InverseLerp(_003CtotalFrom_003E5__6, _003CtotalTo_003E5__5, _003CcountFactor_003E5__7);
					int num5 = NumberExtensions.CeilToInt(f);
					obj2 = num5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
					int fontSize = default;
					gameOverScreen._coinboxLabel.fontSize = fontSize;
					gameOverScreen._coinBoxSizer._AdjustKeysSegmentSize();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					nint num6 = (nint)typeof(ColorData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S1_v55 (Il2CppClass<UI.ColorData>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num7 = (nint)typeof(ColorData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S1_v76 (Il2CppClass<UI.ColorData>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
					object obj5 = (flag ? 1 : 0) + 268;
					obj = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S2_v25+8]");
					_ = 0;
					((Color32*)(nint)color)->rgba = (int)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					string text = MiscExtensions.ToHex(color);
					throw new ArrayTypeMismatchException();
				}
				_003C_003E1__state = -1;
				_003Cfrom_003E5__2 = gameOverScreen._collectedCoinsTo;
				int num8 = coinsToPayout + _003Cfrom_003E5__2;
				_003Cto_003E5__3 = num8;
				nint num9 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v23 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num10 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v39 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float t = (float)coinsToPayout / 100f;
				float num11 = Mathf.LerpUnclamped(0.3f, 2f, t);
				_003CcountTime_003E5__4 = num11;
				object obj7 = this + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
				int fontSize2 = default;
				gameOverScreen.collectedCoinLabel.fontSize = fontSize2;
				int unrewardedCoins = InventorySave.unrewardedCoins;
				_003CtotalTo_003E5__5 = unrewardedCoins;
				int num12 = _003CtotalTo_003E5__5 - coinsToPayout;
				_003CtotalFrom_003E5__6 = num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 0.5f;
				object obj8 = this + 12;
				object obj9 = default;
				obj8 = obj9;
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

	private UILabel scoreLabel;

	private UILabel collectedCoinLabel;

	private UILabel _doubleCoinsLabel;

	private UISprite _doubleCoinDots;

	private UISprite _doubleCoinInfo;

	private Layout _doubleCoinLayout;

	private GameObject _scoreBoard;

	private GameObject _doubleCoinsButton;

	private GameObject _doubleCoinVariationAnchor;

	private GameObject _DoubleCoinVariationBPrefab;

	private GameObject _DoubleCoinVariationCPrefab;

	private GameObject _DoubleCoinVariationDPrefab;

	private GameObject _DoubleCoinVariationEPrefab;

	private string _currentVariation;

	private DoubleCoinsButton _currentButton;

	private CoinBoxSizer _coinBoxSizer;

	private UILabel _coinboxLabel;

	private int _scoreFrom;

	private int _scoreTo;

	private int _coinboxFrom;

	private int _coinboxTo;

	private int _collectedCoinsFrom;

	private int _collectedCoinsTo;

	private bool _countingUpCoins;

	private ScoreCounterSoundPlayer _scoreCounterSoundPlayer;

	private int _counter;

	private int _facebookShowCounter;

	private const uint DEFAULT_COUNTER_EXPIRE_TIME = 72000u;

	private const uint DEFAULT_TOTAL_SHOW_SLOTS = 5u;

	private const uint DEFAULT_ACTIVE_SHOW_SLOT = 1u;

	private const string INTERSTITIAL_GAMEOVER_COUNTER_EXPIRE_TIME = "interstitial_game_over_counter_expire_time";

	private const string INTERSTITIAL_GAMEOVER_TOTAL_SHOW_SLOTS = "interstitial_game_over_total_show_slots";

	private const string INTERSTITIAL_GAMEOVER_ACTIVE_SHOW_SLOT = "interstitial_game_over_active_show_slot";

	private const string RATING_POPUP_ENABLED_ONLINESETTINGS_KEY = "rating_popup_enabled";

	private const bool RATING_POPUP_ENABLED_DEFAULT_VALUE = true;

	private const int RATING_POPUP_RUN_LIMIT = 15;

	private DateTime _lastCountUpTimeStamp;

	private bool _hasAttemptedToShowAdOnTopOfPopup;

	private GameObject discountSticker;

	private UISprite discountStickerSprite;

	private UILabel discountLabel;

	private UILabel discountLabelSingleLine;

	private UISprite playButtonFill;

	private UIButtonOverlayOff playButtonOverlayOff;

	private UILabel homeButtonLabel;

	private UILabel boostsButtonLabel;

	private UILabel boostsButtonCoolDealLabel;

	private UILabel playButtonLabel;

	private UILabel topScoreLabel;

	private Layout _topScoreLayout;

	private UIWidget _topContainer;

	private GameOverLeaderboardHandler leaderboardHandler;

	private GameObject _leaderboardContent;

	private GameObject _topRunContent;

	private TopRunOnlineGameOverScreen _topRunContentScript;

	private BreadCrumbHelper _breadcrumb;

	private GameObject _eventRibbon;

	private UILabel[] _ribbonLabels;

	private GameObject _characterDayParticleSystem;

	private UIPanel _leaderboardPanel;

	private UIPanel _topRunPanel;

	private Transform _doubleCoinVideoButtonParent;

	private Transform _doubleCoinVideoBannerParent;

	private UI.DoubleCoinsVideo.DoubleCoinsVideo _doubleCoinVideoButtonPrefab;

	private UI.DoubleCoinsVideo.DoubleCoinsVideo _doubleCoinsVideoBannerSmallPrefab;

	private UI.DoubleCoinsVideo.DoubleCoinsVideo _doubleCoinsVideoBannerBigPrefab;

	private UI.DoubleCoinsVideo.DoubleCoinsVideo _doubleCoinsVideoElement;

	private bool _hasDoubledCoinsThisRun;

	private bool _disableDoubleCoinsVideoByABTest;

	private bool _leaderboardTabActive;

	private Color darkBlue;

	private Color yellow;

	private bool _hasBeenSetupAfterAGame;

	private static Action m_onGameOverScreenShown;

	private IEnumerator _reloadFriendsCoroutine;

	private bool _hasSetListiPhoneXOffset;

	private Dictionary<string, string> _doubleCoinsVideoResultParams;

	private ActiveTabState _currentActiveTab;

	private Action m_onTabClicked;

	public static event Action onGameOverScreenShown
	{
		add
		{
			((FrontScreen)(object)value).ResetAnimation(FrontScreen.AnimatingButton.PromotionButton);
		}
		remove
		{
			Delegate obj = GameOverScreen.m_onGameOverScreenShown;
			Action action = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				if ((object)GameOverScreen.m_onGameOverScreenShown == obj)
				{
					GameOverScreen.m_onGameOverScreenShown = action;
				}
				if ((object)GameOverScreen.m_onGameOverScreenShown != obj)
				{
					obj = GameOverScreen.m_onGameOverScreenShown;
					continue;
				}
				break;
			}
		}
	}

	private unsafe event Action onTabClicked
	{
		add
		{
			//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cb: Expected I4, but got Unknown
			//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d9: Expected Obj, but got Unknown
			//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e7: Expected Obj, but got Unknown
			//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f5: Expected Obj, but got Unknown
			//IL_043d: Expected I, but got Obj
			//IL_0453: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_047e: Expected I, but got Obj
			//IL_053f: Expected I4, but got Obj
			//IL_054d: Expected I, but got Obj
			//IL_0563: Expected Obj, but got I
			//IL_0054: Expected I, but got Obj
			//IL_0202: Unknown result type (might be due to invalid IL or missing references)
			//IL_0207: Expected Obj, but got Unknown
			//IL_0229: Expected I4, but got Obj
			//IL_024b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0250: Expected Obj, but got Unknown
			//IL_0272: Expected I4, but got Obj
			//IL_00a1: Expected I, but got Obj
			//IL_0299: Unknown result type (might be due to invalid IL or missing references)
			//IL_029e: Expected Obj, but got Unknown
			//IL_02c0: Expected I4, but got Obj
			//IL_00f6: Expected I4, but got Obj
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected Obj, but got Unknown
			//IL_0144: Expected I4, but got Obj
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Expected Obj, but got Unknown
			//IL_018d: Expected I4, but got Obj
			//IL_031c: Expected I, but got Obj
			//IL_0332: Expected Obj, but got I
			//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Expected Obj, but got Unknown
			//IL_01db: Expected I4, but got Obj
			//IL_035d: Expected I, but got Obj
			//IL_03aa: Expected I, but got Obj
			//IL_03c0: Expected Obj, but got I
			//IL_03eb: Expected I, but got Obj
			object obj = default;
			UIWidget.Pivot pivot = (UIWidget.Pivot)(obj - -64);
			object obj2 = obj + 48;
			object obj3 = obj + 32;
			object obj4 = obj + 16;
			if (_currentVariation != "A")
			{
				nint num = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v23 (Il2CppClass<Strings>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num2 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v83 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = Strings.GetDefault("DOUBLE_COINS_TITLE");
				_doubleCoinsLabel.fontSize = (int)text;
				nint num3 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v28 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num4 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v82 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Dictionary<Characters.CharacterId, bool> hasCharacterBeenSeen = UserSave.hasCharacterBeenSeen;
				if (hasCharacterBeenSeen == null)
				{
					Color black = Color.black;
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					_ = 0;
					collectedCoinLabel.rawPivot = pivot;
					object obj7 = this + 284;
					obj3 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S2_v35+8]");
					_ = 0;
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					_ = 0;
					_doubleCoinDots.rawPivot = pivot;
					object obj8 = this + 284;
					obj4 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S2_v45+8]");
					_ = 0;
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
					_ = 0;
					_doubleCoinsLabel.rawPivot = pivot;
					object obj9 = this + 284;
					obj = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S2_v55+8]");
					_ = 0;
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					_doubleCoinInfo.rawPivot = pivot;
				}
				else
				{
					object obj10 = this + 300;
					obj2 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v34+8]");
					_ = 0;
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					_ = 0;
					collectedCoinLabel.rawPivot = pivot;
					object obj11 = this + 300;
					obj3 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S2_v12+8]");
					_ = 0;
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					_ = 0;
					_doubleCoinDots.rawPivot = pivot;
					object obj12 = this + 300;
					obj4 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S2_v22+8]");
					_ = 0;
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
					_ = 0;
					_doubleCoinsLabel.rawPivot = pivot;
					string text2 = _doubleCoinInfo.tag;
					((GameObject)(object)text2).tag = null;
					Collider component = _doubleCoinLayout.GetComponent<Collider>();
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S0_v51 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj13 = (nint)0 & (nint)0x200;
					if (obj13 != null)
					{
						nint num6 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S0_v68 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
					{
						nint num7 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S0_v59 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj14 = (nint)0 & (nint)0x200;
						if (obj14 != null)
						{
							nint num8 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S0_v64 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						UnityEngine.Object.DestroyImmediate(component);
					}
				}
			}
			else
			{
				nint num9 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v12 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num10 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v18 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Dictionary<Characters.CharacterId, bool> hasCharacterBeenSeen2 = UserSave.hasCharacterBeenSeen;
				((EventButtonBreadcrumb)(object)_currentButton).PopupWasShown((string)(object)hasCharacterBeenSeen2);
			}
			((RewardForVideoButton)(object)_doubleCoinLayout).Init((VideoButtonPayload)null);
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onTabClicked;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 336;
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

	protected override string GetFlurryName()
	{
		//IL_0062: Expected I, but got Obj
		//IL_0078: Expected Obj, but got I
		//IL_0205: Expected Obj, but got I4
		//IL_00a3: Expected I, but got Obj
		//IL_0129: Expected I, but got Obj
		//IL_013f: Expected Obj, but got I
		//IL_0241: Expected Obj, but got I4
		//IL_016a: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @790E");
		object obj = default;
		if (obj != null)
		{
			return null;
		}
		if ((object)playButtonOverlayOff != null)
		{
			if (OnboardingSave.numberOfRunsSinceLastGuideline != 0)
			{
				nint num = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16 (Il2CppClass<UIScreenController>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num2 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v31 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = UIScreenController.ShouldShowOnlineScreen();
				if (((UIScreenController)flag).IsPopupQueueEmpty())
				{
					return null;
				}
				AdSystemManager instance = AdSystemManager.instance;
				if (instance != null)
				{
					OfferWallManager instance2 = OfferWallManager.instance;
					nint num3 = (nint)typeof(AdLocations);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v8 (Il2CppClass<AdLocations>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num4 = (nint)typeof(AdLocations);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v15 (Il2CppClass<AdLocations>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag2 = ((AdSystemManager)(object)instance2).IsCaching((string)(object)AdLocations.HOME_INTERSTITIALS);
					return (string)flag2;
				}
				return null;
			}
			return null;
		}
		return null;
	}

	private void OnEnable()
	{
		Delegate obj = GameOverScreen.m_onGameOverScreenShown;
		Action action = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			if ((object)GameOverScreen.m_onGameOverScreenShown == obj)
			{
				GameOverScreen.m_onGameOverScreenShown = action;
			}
			if ((object)GameOverScreen.m_onGameOverScreenShown != obj)
			{
				obj = GameOverScreen.m_onGameOverScreenShown;
				continue;
			}
			break;
		}
	}

	public override void Init()
	{
		_hasAttemptedToShowAdOnTopOfPopup = false;
	}

	public unsafe override void Show()
	{
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected Obj, but got Unknown
		//IL_03f3: Expected Obj, but got VT
		//IL_0401: Expected I, but got Obj
		//IL_0417: Expected Obj, but got I
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected Obj, but got Unknown
		//IL_044b: Expected Obj, but got VT
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected Obj, but got Unknown
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Expected VT, but got Unknown
		//IL_047c: Expected F4, but got Obj
		//IL_0477: Expected native int or pointer, but got VT
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected Obj, but got Unknown
		//IL_04a4: Expected F4, but got Obj
		//IL_049f: Expected native int or pointer, but got VT
		//IL_04b9: Expected F4, but got I
		//IL_04b4: Expected native int or pointer, but got VT
		//IL_04c8: Expected I4, but got VT
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected Obj, but got Unknown
		//IL_0068: Expected Obj, but got I
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00ce: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_04f9: Expected Obj, but got I4
		//IL_051b: Expected F4, but got Obj
		//IL_0516: Expected native int or pointer, but got VT
		//IL_0530: Expected F4, but got I
		//IL_052b: Expected native int or pointer, but got VT
		//IL_0539: Expected Obj, but got VT
		//IL_054b: Expected I, but got Obj
		//IL_0561: Expected Obj, but got I
		//IL_059b: Expected I4, but got Obj
		//IL_010f: Expected I, but got Obj
		//IL_01aa: Expected I4, but got Obj
		//IL_015c: Expected I, but got Obj
		//IL_01cc: Expected I4, but got Obj
		//IL_01ee: Expected I4, but got Obj
		//IL_0210: Expected I4, but got Obj
		//IL_021e: Expected I, but got Obj
		//IL_0234: Expected Obj, but got I
		//IL_05c6: Expected Obj, but got I4
		//IL_05d4: Expected I, but got Obj
		//IL_05ea: Expected Obj, but got I
		//IL_025f: Expected I, but got Obj
		//IL_02ac: Expected I, but got Obj
		//IL_031d: Expected I, but got Obj
		//IL_0333: Expected Obj, but got I
		//IL_069c: Expected F4, but got I4
		//IL_035e: Expected I, but got Obj
		ShowIfInactive();
		object obj = this + 136;
		_0021_00210 componentInChildren = (_0021_00210)((Component)this).GetComponentInChildren<T>();
		obj = componentInChildren;
		nint num = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v8 (Il2CppClass<GlobalColors>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v99 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 36;
		obj3 = GlobalColors.FOOTER_BIG_PLAY_RESUME_COLOR;
		object obj5 = obj4 + 32;
		obj5 = obj3;
		Matrix4x4 matrix4x = (Matrix4x4)(obj4 + 40);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		object obj6 = obj4 + 16;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v19+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		playButtonFill.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj7 = this + 100;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120D9");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S3_v4 (Il2CppMethodInfo)+18]");
		object obj8 = 0;
		object obj9 = obj8;
		object obj10 = obj9 & 0x1FFF;
		object obj11 = obj10 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v105 @ S4_v5 (should have been resolved before IL gen)");
		object obj12 = default;
		obj7 = obj12;
		object obj13 = this + 104;
		CoinBoxSizer coinBoxSizer = _coinBoxSizer;
		obj13 = coinBoxSizer.coinAmountLabel;
		nint num4 = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S1_v32 (Il2CppClass<UI.ColorData>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num5 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v95 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj15 = (flag ? 1 : 0) + 732;
		obj4 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S2_v26+8]");
		_ = 0;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		Vector2 effectDistance = ((UILabel)matrix4x).effectDistance;
		nint num6 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S1_v42 (Il2CppClass<Strings>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num7 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S1_v91 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("FOOTER_HOME_BUTTON_TITLE");
		homeButtonLabel.fontSize = (int)text;
		string text2 = Strings.GetDefault("FOOTER_BOOSTS_BUTTON_TITLE");
		boostsButtonLabel.fontSize = (int)text2;
		string text3 = Strings.GetDefault("COOL_DEAL_SINGLE_LINE");
		discountLabelSingleLine.fontSize = (int)text3;
		string text4 = Strings.GetDefault("GAMEOVER_UI_PLAY");
		playButtonLabel.fontSize = (int)text4;
		string text5 = Strings.GetDefault("GAMEOVER_UI_SCORE");
		topScoreLabel.fontSize = (int)text5;
		nint num8 = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v30 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num9 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v66 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool payloadBool = ABTestManager.GetPayloadBool("doublecoins");
		UpdateDoubleCoin((string)payloadBool);
		nint num10 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v36 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num11 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v62 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (IPhoneXSupport.CheckIsiPhoneXDevice() && ~(_hasSetListiPhoneXOffset ? 1u : 0u) != 0)
		{
			nint num12 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S1_v74 (Il2CppClass<IPhoneXSupport>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num13 = (nint)typeof(IPhoneXSupport);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S1_v85 (Il2CppClass<IPhoneXSupport>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float y = 0f - (float)IPhoneXSupport.OFFSET_TOP;
			NGUIMath.MoveRect(_topContainer, 0f, y);
			UIWidget component = _doubleCoinVideoBannerParent.GetComponent<UIWidget>();
			NGUIMath.MoveRect(component, 0f, IPhoneXSupport.OFFSET_BOTTOM);
			((UIRect)_topContainer).ParentHasChanged();
			((UIRect)component).ParentHasChanged();
			_hasSetListiPhoneXOffset = true;
		}
		UIWidget component2 = _doubleCoinVideoBannerParent.GetComponent<UIWidget>();
		((UIRect)component2).ParentHasChanged();
		UIWidget component3 = _doubleCoinVideoButtonParent.GetComponent<UIWidget>();
		((UIRect)component3).ParentHasChanged();
	}

	public override void Hide()
	{
		base.Hide();
		throw new IndexOutOfRangeException();
	}

	public unsafe override void StartRun()
	{
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected Obj, but got Unknown
		//IL_02c6: Expected I, but got Obj
		//IL_02dc: Expected Obj, but got I
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected Obj, but got Unknown
		//IL_03a5: Expected I, but got Obj
		//IL_03bb: Expected Obj, but got I
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected Obj, but got Unknown
		//IL_0125: Expected I, but got Obj
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_0172: Expected I, but got Obj
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		//IL_023a: Expected Obj, but got I4
		base.LoseFocus();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(GameOverScreen.OnPopupShown);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v107 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnLastPopupClosed += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(GameOverScreen.OnCoinsChanged);
		object obj3 = action2 + 16;
		obj3 = this;
		InventorySave.keysChanged += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		MissionsManager missionsManager = default;
		missionsManager._currentMissionTemplateSetLoaded = (int)num3;
		missionsManager._defaultMissionIndexUpdateInterval = 0;
		object obj4 = missionsManager + 16;
		obj4 = this;
		missionsManager._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr = 0;
		SocialManager socialManager = default;
		((UnityEngine.Object)socialManager).m_CachedPtr = cachedPtr;
		socialManager._latestSuccesfullyConsolidatedFacebookIds = (List<string>)0;
		object obj5 = socialManager + 16;
		obj5 = this;
		nint num4 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v42 (Il2CppClass<SocialManager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num5 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v103 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		socialManager.FriendsDidChange();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr3;
		((Delegate)action3).method = (nint)__ldftn(GameOverScreen.SetUpEventUIElements);
		object obj7 = action3 + 16;
		obj7 = this;
		nint num6 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v54 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num7 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v99 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SSEventsManagerController.OnSSEventChangedHandler += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		Action action4 = default;
		((Delegate)action4).method_ptr = method_ptr4;
		((Delegate)action4).method = (nint)__ldftn(GameOverScreen.SetUpEventUIElements);
		object obj9 = action4 + 16;
		obj9 = this;
		SSEventsManagerController.OnSSEventFinishedHandler += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num8 = 0;
		_ = 0;
		Action<string> action5 = default;
		object obj10 = action5 + 16;
		obj10 = this;
		UIScreenController.OnPopupShown += action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num9 = 0;
		_ = 0;
		Action<string> action6 = default;
		object obj11 = action6 + 16;
		obj11 = this;
		UIScreenController.OnPopupClosed += action6;
		bool isInstanced = UIScreenController.IsInstanced;
		((UIModelController)isInstanced).ClearScreenAnchor(UIModelController.ModelScreen.GameOver);
		if (~(_disableDoubleCoinsVideoByABTest ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			throw new IndexOutOfRangeException();
		}
	}

	private void StartRunAfterAd()
	{
		//IL_0047: Expected I, but got Obj
		//IL_005d: Expected Obj, but got I
		//IL_025d: Expected I, but got Obj
		//IL_0273: Expected Obj, but got I
		//IL_029a: Expected Obj, but got I4
		//IL_0088: Expected I, but got Obj
		//IL_018d: Expected I, but got Obj
		//IL_01a3: Expected Obj, but got I
		//IL_00d5: Expected I, but got Obj
		//IL_02d3: Expected Obj, but got I4
		//IL_01ce: Expected I, but got Obj
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_015b: Expected Obj, but got I4
		//IL_0175: Expected Obj, but got I4
		bool isInitialized = AdSystemManager.isInitialized;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (System.Boolean)+E]");
		if ((nint)0 != 0)
		{
			return;
		}
		bool touchSupported = Input.touchSupported;
		if ((touchSupported ? 1 : 0) > (true ? 1 : 0))
		{
			return;
		}
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v14 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v37 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)isInstantiated).FindKernel(null) != 0)
		{
			bool isInitialized2 = AdSystemManager.isInitialized;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			object obj4 = default;
			object obj3 = obj4 + 16;
			obj3 = this;
			object obj5 = (isInitialized2 ? 1 : 0) + 16;
			obj5 = obj4;
			bool isInitialized3 = AdSystemManager.isInitialized;
			((PokiUnitySDK)isInitialized3).rewardedBreak();
			return;
		}
		nint num6 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v22 (Il2CppClass<UIScreenController>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num7 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v28 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).SwitchScreen("GameOverScreen");
	}

	public void OnDoubleCoinsClicked()
	{
		//IL_0194: Expected I, but got Obj
		//IL_01aa: Expected Obj, but got I
		//IL_02de: Expected I, but got Obj
		//IL_02f4: Expected Obj, but got I
		//IL_01e7: Expected I, but got Obj
		//IL_01fd: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_022c: Expected Obj, but got I4
		//IL_023a: Expected I, but got Obj
		//IL_0250: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0284: Expected Obj, but got I4
		//IL_0292: Expected I, but got Obj
		//IL_02a8: Expected Obj, but got I
		//IL_00ad: Expected I, but got Obj
		//IL_00fa: Expected I, but got Obj
		//IL_0147: Expected I, but got Obj
		nint num = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<HouseKeeper>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v54 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HouseKeeper.RefreshOnlineSettingsAndInappsIfNeeded();
		nint num3 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v12 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v50 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		((SSEventsManagerController)(object)flurryUserId).CurrentEventHasBeenTriedNow();
		nint num5 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v46 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		((Game)isInstantiated).Update();
		nint num7 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v26 (Il2CppClass<UIScreenController>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v42 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).SwitchScreen("IngameUI");
		nint num9 = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v33 (Il2CppClass<SaveMeManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v38 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveMeManager.SkipReviveIfPurchaseFailed();
	}

	private void SetRibbonInfo(CharacterScreen.RibbonPayload payload)
	{
	}

	private void HideEventStarsIfNecessary()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0106: Expected I, but got Obj
		//IL_011c: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v21 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v17 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag)._ActivateNextPopup("TutorialDoubleCoinsPopup");
	}

	private void OnLastPopupClosed()
	{
		//IL_0099: Expected I, but got Obj
		//IL_00af: Expected Obj, but got I
		//IL_00df: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		if (((UIScreenController)flag).IsPopupQueueEmpty() && _characterDayParticleSystem.activeInHierarchy)
		{
			_characterDayParticleSystem.tag = null;
		}
	}

	private bool ShouldEnableCharacterDayEventElements(IEventManager activeEventManager)
	{
		//IL_0014: Expected I4, but got Obj
		return ((List<FrontScreen.AnimatingButton>)(object)_topScoreLayout).Contains((FrontScreen.AnimatingButton)activeEventManager);
	}

	private void SetUpEventUIElements()
	{
		//IL_015d: Expected Obj, but got I4
		//IL_016b: Expected I, but got Obj
		//IL_0181: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00cb: Expected I, but got Obj
		//IL_00e1: Expected Obj, but got I
		//IL_010c: Expected I, but got Obj
		bool isInstanced = UIScreenController.IsInstanced;
		((UIModelController)isInstanced).DeactivateCelebrationPopupModels();
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v25 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		bool flag = ((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.king);
		if (flag)
		{
			IEnumerator enumerator = ((GameOverScreen)null).CorouReloadFriends(flag);
			_characterDayParticleSystem.tag = (string)(object)enumerator;
		}
		if (~(_hasAttemptedToShowAdOnTopOfPopup ? 1u : 0u) != 0)
		{
			return;
		}
		IEnumerator enumerator2 = CountUpCoins();
		if (enumerator2 == null)
		{
			return;
		}
		OfferWallManager instance = OfferWallManager.instance;
		nint num3 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v9 (Il2CppClass<AdLocations>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v16 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((AdSystemManager)(object)instance).FinishedWatchingVideo((string)(object)AdLocations.GAME_OVER_INTERSTITIALS, (string)null);
	}

	private void ActivateEventRibbon(bool currentCharIsRelevant, IEventManager activeEventManager)
	{
		((FrontScreen)this).AnimatePromotionButton();
	}

	private void ChangePlayButtonState()
	{
		//IL_0123: Expected I, but got Obj
		//IL_0139: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_008b: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		//IL_0168: Expected Obj, but got I4
		//IL_017a: Expected Obj, but got I4
		//IL_00cc: Expected I, but got Obj
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		bool flag = ((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick);
		IEnumerator enumerator = ((GameOverScreen)null).CorouReloadFriends(flag);
		OnMissionComplete((string)(object)enumerator, flag ? 1 : 0);
		string text;
		if (enumerator != null)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v9 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v17 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = UIScreenController.ShouldShowOnlineScreen();
			bool flag3 = ((UIScreenController)flag2).IsPopupQueueEmpty();
			text = (string)((flag3 ? 1 : 0) ^ 1);
		}
		else
		{
			text = null;
		}
		_characterDayParticleSystem.tag = text;
	}

	private void OnApplicationPause(bool pause)
	{
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected Obj, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected Obj, but got Unknown
		//IL_035b: Expected Obj, but got I4
		//IL_038a: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I
		//IL_00d3: Expected Obj, but got I
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected Obj, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected Obj, but got Unknown
		//IL_01cd: Expected VT, but got Obj
		//IL_0432: Invalid comparison between Obj and F4
		//IL_026e: Invalid comparison between Obj and F4
		//IL_02a3: Expected Obj, but got F4
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected Obj, but got Unknown
		//IL_0295: Expected F4, but got Obj
		//IL_02b6: Expected I, but got Obj
		//IL_02cc: Expected Obj, but got I
		//IL_04fb: Expected Obj, but got F4
		//IL_02f7: Expected I, but got Obj
		object obj = default;
		Transform transform = (Transform)(obj + 20);
		object obj2 = obj + 8;
		obj2 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [pause @ L1 (System.Boolean)+8]");
		bool flag = (nint)0 != 0;
		_eventRibbon.tag = (string)flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [pause @ L1 (System.Boolean)+8]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [pause @ L1 (System.Boolean)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [pause @ L1 (System.Boolean)+C]");
		bool flag2;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v20+8]");
			flag2 = (nint)0 == 0;
		}
		else
		{
			flag2 = true;
		}
		if (flag2)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [pause @ L1 (System.Boolean)+10]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [pause @ L1 (System.Boolean)+10]");
		bool flag3;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v24+8]");
			flag3 = (nint)0 == 0;
		}
		else
		{
			flag3 = true;
		}
		if (flag3)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [pause @ L1 (System.Boolean)+14]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [pause @ L1 (System.Boolean)+14]");
		bool flag4;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v28+8]");
			flag4 = (nint)0 == 0;
		}
		else
		{
			flag4 = true;
		}
		if (flag4)
		{
			return;
		}
		object obj6 = _ribbonLabels + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [pause @ L1 (System.Boolean)+C]");
		((UILabel)obj6).fontSize = 0;
		object obj7 = _ribbonLabels + 20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [pause @ L1 (System.Boolean)+10]");
		((UILabel)obj7).fontSize = 0;
		object obj8 = _ribbonLabels + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [pause @ L1 (System.Boolean)+14]");
		((UILabel)obj8).fontSize = 0;
		object obj9 = _ribbonLabels + 24;
		Component component = (Component)obj9;
		GameObject gameObject = ((Component)obj9).gameObject;
		transform.localPosition = (Vector3)gameObject;
		obj2 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v23 (UnityEngine.Component)+164]");
		if ((nint)0 != 2)
		{
			_ = 2;
			_ = 1;
			_ = 1;
		}
		Vector2 localSize = ((UILabel)obj9).localSize;
		float num;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)155f))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v23 (UnityEngine.Component)+164]");
			if ((nint)0 != 0)
			{
				_ = 0;
				_ = 1;
				_ = 1;
			}
			int height = NumberExtensions.CeilToInt(155f);
			((UIWidget)obj9).height = height;
			num = 155f;
		}
		else
		{
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)136f))
			{
				obj2 = 0f;
				goto IL_047a;
			}
			num = (float)obj;
		}
		nint num2 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v62 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v67 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float value = num - 136f;
		float num4 = Math.Abs(value);
		float num5 = num4 * 0.5f;
		obj2 = num5;
		goto IL_047a;
		IL_047a:
		object obj11 = _ribbonLabels + 24;
		GameObject gameObject2 = ((Component)obj11).gameObject;
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
	}

	private unsafe void InAppManager_OnPurchaseSuccess(string productId, bool wasRestored, IPurchaseValidationResult validationResult)
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected I4, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		object obj = productId + 12;
		object obj2 = default;
		CollectCoinsCell collectCoinsCell = default;
		object obj7 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			collectCoinsCell.cellType = CollectCoinsCellType.FRIEND;
			object obj3 = collectCoinsCell + 12;
			object obj4 = productId + 16;
			object obj5 = obj2 << 2;
			object obj6 = obj4 + obj5;
			obj3 = obj6;
			bool useDarkColour = !((bool*)(wasRestored ? 1 : 0))->m_value;
			collectCoinsCell.useDarkColour = useDarkColour;
			bool disableScrolling = (byte)(validationResult & 1) != 0;
			collectCoinsCell.disableScrolling = disableScrolling;
			((List<CollectCoinsCell>)(object)_doubleCoinsButton).Add(collectCoinsCell);
			bool value = (byte)((((bool*)(wasRestored ? 1 : 0))->m_value ? 1u : 0u) + 1u) != 0;
			((bool*)(wasRestored ? 1 : 0))->m_value = value;
			obj2 = obj7 + 1;
		}
	}

	public void SetupBeforeMysteryBox()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_00b1: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v11 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("GAMEOVER_UI_PLAY");
		playButtonLabel.fontSize = (int)text;
		playButtonOverlayOff.GoToNotAvailableState();
	}

	public void SetupAfterMysteryBox()
	{
		//IL_015e: Expected I, but got Obj
		//IL_0174: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_012f: Expected I4, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v32 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_USE_CELEBRATION_TESTER ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(CelebrationTesterPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v23 (Il2CppClass<CelebrationTesterPopup>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(CelebrationTesterPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v28 (Il2CppClass<CelebrationTesterPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CelebrationTesterPopup._002Ecctor();
		}
		_hasBeenSetupAfterAGame = true;
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S2_v2 (System.String)+74]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] array = default;
		string text = string.Concat(array);
		scoreLabel.fontSize = (int)text;
		string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v12 (System.String)+74]");
		_scoreFrom = 0;
	}

	private void PushNewHighScoreCelebrationScreen(int newHighSchore)
	{
		if (newHighSchore == 0 && ~(_countingUpCoins ? 1u : 0u) != 0)
		{
			CountUpCompleted();
		}
	}

	private void UpdateUpgradeSticker()
	{
		//IL_02e4: Expected I, but got Obj
		//IL_02fa: Expected Obj, but got I
		//IL_0325: Expected I, but got Obj
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected I4, but got Unknown
		//IL_00e7: Expected Obj, but got I4
		//IL_00e7: Expected Obj, but got I4
		//IL_00e7: Expected Obj, but got I4
		//IL_0114: Expected I, but got Obj
		//IL_012a: Expected Obj, but got I
		//IL_0155: Expected I, but got Obj
		//IL_01a2: Expected I, but got Obj
		//IL_01b8: Expected Obj, but got I
		//IL_01e3: Expected I, but got Obj
		//IL_0256: Expected I, but got Obj
		//IL_026c: Expected Obj, but got I
		//IL_0417: Expected Obj, but got I4
		//IL_0297: Expected I, but got Obj
		if (~(_hasBeenSetupAfterAGame ? 1u : 0u) == 0)
		{
			string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
			int coinsCollectedRun = ((GameStats)(object)privacyPolicyUrl).CoinsCollectedRun;
			((CoinEarnerLoadingOffer)(object)_coinBoxSizer).Init((Action)null);
			_collectedCoinsFrom = 0;
			_collectedCoinsTo = coinsCollectedRun;
			Friend[] debugFriends = Globals.GetDebugFriends(coinsCollectedRun);
			int scoreTo = debugFriends + _scoreFrom;
			_scoreTo = scoreTo;
			int unrewardedCoins = InventorySave.unrewardedCoins;
			_coinboxFrom = unrewardedCoins;
			int coinboxTo = coinsCollectedRun + _coinboxFrom;
			_coinboxTo = coinboxTo;
			InventorySave.lastAddedReward = null;
			int amount = _coinboxTo - _coinboxFrom;
			InventorySave.IncreaseKeys(amount, "MysteryBox");
			StayInOneLaneMission instance = StayInOneLaneMission.instance;
			((OwnBoardsAward)(object)instance)._002Ector((AwardStaticData)78, (PersistentAwardProgress)coinsCollectedRun, (Action<Award>)(-1));
			Coroutine coroutine = StartCoroutine((IEnumerator)(object)"CountUpCoins");
			_hasBeenSetupAfterAGame = false;
			nint num = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v45 (Il2CppClass<SSEventsManagerController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v79 (Il2CppClass<SSEventsManagerController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string flurryUserId = Flurry.flurryUserId;
			if (((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.lucy))
			{
				nint num3 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v55 (Il2CppClass<SSEventsManagerController>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(SSEventsManagerController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v75 (Il2CppClass<SSEventsManagerController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string flurryUserId2 = Flurry.flurryUserId;
				CharacterNameEventManager typeOfActiveEventManager = ((SSEventsManagerController)(object)flurryUserId2).GetTypeOfActiveEventManager<CharacterNameEventManager>();
				if (typeOfActiveEventManager != null && typeOfActiveEventManager.IsFirstCharacterSelected())
				{
					nint num5 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v65 (Il2CppClass<UIScreenController>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num6 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v71 (Il2CppClass<UIScreenController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag = UIScreenController.ShouldShowOnlineScreen();
					((UIScreenController)flag)._ActivateNextPopup("CharacterNameEventPopup");
				}
			}
			OnLastPopupClosed();
		}
		nint num7 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v9 (Il2CppClass<UIScreenController>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v19 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v14 (System.Boolean)+7A]");
		if ((nint)0 != 0)
		{
			_topRunContentScript.RefreshOrFetchNewTournament();
		}
	}

	private unsafe void OnCoinsChanged()
	{
		//IL_018e: Expected I, but got Obj
		//IL_01a4: Expected Obj, but got I
		//IL_01ea: Expected I, but got Obj
		//IL_0200: Expected Obj, but got I
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected VT, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected Obj, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_0292: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00af: Expected Obj, but got I4
		//IL_00bd: Expected I, but got Obj
		//IL_00d3: Expected Obj, but got I
		//IL_02b8: Expected Obj, but got VT
		//IL_02cd: Expected F4, but got Obj
		//IL_02c8: Expected native int or pointer, but got VT
		//IL_02e7: Expected F4, but got Obj
		//IL_02e2: Expected native int or pointer, but got VT
		//IL_02fc: Expected F4, but got I
		//IL_02f7: Expected native int or pointer, but got VT
		//IL_030b: Expected I4, but got VT
		//IL_0314: Expected Obj, but got VT
		//IL_0329: Expected F4, but got Obj
		//IL_0324: Expected native int or pointer, but got VT
		//IL_014a: Expected F4, but got Obj
		//IL_0145: Expected native int or pointer, but got VT
		//IL_015f: Expected F4, but got I
		//IL_015a: Expected native int or pointer, but got VT
		//IL_016e: Expected I4, but got VT
		//IL_00fe: Expected I, but got Obj
		discountSticker.tag = null;
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v28 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		bool flag = ((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.yutani);
		nint num3 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v7 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v52 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj3 + 48);
		object obj4 = obj3 + 40;
		object obj5 = obj3 + 24;
		object obj6 = obj3 + 44;
		object obj7 = obj3 + 16;
		object obj8 = obj3 + 20;
		bool flag2 = !flag;
		bool isAnyCurrencyDiscountActive = InAppManager.IsAnyCurrencyDiscountActive;
		object obj9 = flag2 & isAnyCurrencyDiscountActive;
		if (obj9 == null)
		{
			return;
		}
		discountSticker.tag = (string)1;
		nint num5 = (nint)typeof(GlobalColorsGenerated);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v28 (Il2CppClass<GlobalColorsGenerated>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num6 = (nint)typeof(GlobalColorsGenerated);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S1_v46 (Il2CppClass<GlobalColorsGenerated>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj4 = GlobalColorsGenerated.DISCOUNT_STICKER_COLOR;
		obj6 = obj4;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v16+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		discountStickerSprite.rawPivot = (UIWidget.Pivot)matrix4x;
		obj7 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR;
		obj8 = obj7;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
		Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		discountLabelSingleLine.rawPivot = (UIWidget.Pivot)matrix4x;
	}

	private void OnMissionComplete(string message, int missionIndex)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_0188: Expected I, but got Obj
		//IL_019e: Expected Obj, but got I
		//IL_01d2: Expected Obj, but got I4
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_00b8: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I4
		//IL_00e4: Expected Obj, but got I4
		//IL_003f: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 8;
		obj = string.Empty;
		object obj3 = obj2 + 4;
		obj3 = string.Empty;
		obj2 = string.Empty;
		bool flag = missionIndex == 0;
		object obj4 = message ^ 1;
		object obj5 = flag | obj4;
		bool flag2;
		if (obj5 != null)
		{
			flag2 = false;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj6 = default;
			flag2 = (nint)obj6 == 7;
		}
		nint num = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v21 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v43 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = IPhoneXSupport.CheckIsiPhoneXDevice();
		object obj8 = (flag3 ? 1 : 0) ^ 1;
		object obj9 = flag2 & obj8;
		if (obj9 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77FE");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj10 = obj9 & 1;
		bool flag4 = default;
		object obj11 = (flag4 ? 1 : 0) + 12;
		obj11 = obj;
		object obj12 = (flag4 ? 1 : 0) + 16;
		obj12 = obj3;
		object obj13 = (flag4 ? 1 : 0) + 20;
		obj13 = obj2;
		OnApplicationPause(flag4);
	}

	private void ReloadFriends()
	{
		OnCoinsChanged();
	}

	private IEnumerator CorouReloadFriends(bool framedelay)
	{
		//IL_008d: Expected Obj, but got I4
		//IL_006b: Expected Obj, but got I4
		object obj = 0;
		Boards.BoardId currentBoardId = PlayerSave.currentBoardId;
		if (framedelay)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj2 = default;
			if ((nint)obj2 == 7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @758F");
				object obj3 = default;
				bool flag = (nint)currentBoardId == (nint)obj3;
				bool flag2 = (nint)obj == 1;
				return (IEnumerator)(flag & flag2);
			}
			return null;
		}
		return null;
	}

	private void CountUpCompleted()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		if (_reloadFriendsCoroutine != null)
		{
			StopCoroutine((Coroutine)(object)_reloadFriendsCoroutine);
		}
		object obj = this + 320;
		IEnumerator enumerator = CountUpDoubleCoinsVideo(0);
		obj = enumerator;
		Coroutine coroutine = StartCoroutine_Auto(_reloadFriendsCoroutine);
	}

	private bool IsAllowedToShowInterstitial()
	{
		//IL_000b: Expected I4, but got Obj
		return (byte)(int)"GameoverUI" != 0;
	}

	private void OnPopupShown(string popupName)
	{
		//IL_00e5: Expected Obj, but got I4
		//IL_0012: Expected Obj, but got I4
		//IL_0028: Expected Obj, but got I4
		//IL_0036: Expected I, but got Obj
		//IL_004c: Expected Obj, but got I
		//IL_0077: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DailyChallengeRewardHelper dailyChallengeRewardHelper = default;
		dailyChallengeRewardHelper.Refresh();
		((UnityEngine.Object)dailyChallengeRewardHelper).m_CachedPtr = (IntPtr)9;
		dailyChallengeRewardHelper._rewardLayout = (Layout)9;
		Boards.BoardId currentBoardId = PlayerSave.currentBoardId;
		dailyChallengeRewardHelper._rewardLabel = (UILabel)currentBoardId;
		Characters.CharacterId currentCharacterId = PlayerSave.currentCharacterId;
		dailyChallengeRewardHelper._3BagsReward = (GameObject)currentCharacterId;
		nint num = (nint)typeof(RewardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (Il2CppClass<RewardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v18 (Il2CppClass<RewardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RewardManager.AddMysteryBoxToUnlock((CelebrationReward)(object)dailyChallengeRewardHelper);
	}

	private unsafe void OnFriendsChanged()
	{
		//IL_0615: Expected I, but got Obj
		//IL_062b: Expected Obj, but got I
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_011d: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0148: Expected I4, but got Obj
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_016c: Expected Obj, but got I4
		//IL_0197: Expected I4, but got Obj
		//IL_01a1: Expected Obj, but got I4
		//IL_00aa: Expected I, but got Obj
		//IL_01cc: Expected I4, but got Obj
		//IL_05ea: Expected Obj, but got I4
		//IL_0601: Expected Obj, but got I4
		//IL_0601: Expected Obj, but got I4
		//IL_0550: Expected I, but got Obj
		//IL_0566: Expected Obj, but got I
		//IL_0258: Expected Obj, but got I4
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected Obj, but got Unknown
		//IL_0591: Expected I, but got Obj
		//IL_029b: Expected I, but got Obj
		//IL_02b1: Expected Obj, but got I
		//IL_06c4: Expected I, but got Obj
		//IL_06da: Expected Obj, but got I
		//IL_070d: Expected I4, but got Obj
		//IL_070d: Expected Obj, but got I4
		//IL_02dc: Expected I, but got Obj
		//IL_0329: Expected I, but got Obj
		//IL_0376: Expected I, but got Obj
		//IL_038c: Expected Obj, but got I
		//IL_03b7: Expected I, but got Obj
		//IL_042b: Expected I, but got Obj
		//IL_0441: Expected Obj, but got I
		//IL_046c: Expected I, but got Obj
		//IL_04b9: Expected I, but got Obj
		//IL_04cf: Expected Obj, but got I
		//IL_07c8: Expected Obj, but got I4
		//IL_04fa: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v69 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_doubleCoinsVideoElement).FindKernel((string)null) != 0)
		{
			bool flag = Breadcrumb.CheckNewWeeklyHunt();
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v97 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v102 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (_collectedCoinsTo < (flag ? 1 : 0))
			{
				bool collectedCoinsTo = (byte)_collectedCoinsTo != 0;
			}
			else
			{
				bool collectedCoinsTo = flag;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
		object obj4 = default;
		object obj3 = obj4 + 8;
		obj3 = _scoreTo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] array = default;
		string text = string.Concat(array);
		scoreLabel.fontSize = (int)text;
		object obj5 = obj4 + 4;
		int unrewardedCoins = InventorySave.unrewardedCoins;
		obj5 = unrewardedCoins;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] array2 = default;
		string text2 = string.Concat(array2);
		_coinboxLabel.fontSize = (int)text2;
		obj4 = _collectedCoinsTo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] array3 = default;
		string text3 = string.Concat(array3);
		collectedCoinLabel.fontSize = (int)text3;
		string language = PreferencesSave.language;
		if (language == null)
		{
			int currentOutfitIndex = PlayerSave.currentOutfitIndex;
			if (currentOutfitIndex > 0)
			{
				int currentOutfitIndex2 = PlayerSave.currentOutfitIndex;
				int num5 = currentOutfitIndex2 / 15;
				object obj6 = num5 * 15;
				object obj7 = currentOutfitIndex2 - obj6;
				if (obj7 == null)
				{
					nint num6 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v39 (Il2CppClass<Data.Save.UserSave>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num7 = (nint)typeof(UserSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v86 (Il2CppClass<Data.Save.UserSave>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int numberOfBreadCrumbsShownOnFrontPage = UserSave.numberOfBreadCrumbsShownOnFrontPage;
					nint num8 = (nint)typeof(DeviceUtility);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S1_v50 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num9 = (nint)typeof(DeviceUtility);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S1_v63 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string bundleIdentifier = DeviceUtility.GetBundleIdentifier();
					if (((string)numberOfBreadCrumbsShownOnFrontPage).get_Chars((int)bundleIdentifier) != '\0')
					{
						nint num10 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v47 (Il2CppClass<Globals>)+BA]");
						object obj10 = (nint)0 & (nint)0x200;
						if (obj10 != null)
						{
							nint num11 = (nint)typeof(Globals);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v82 (Il2CppClass<Globals>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string appStoreURL = Globals.AppStoreURL;
						if (appStoreURL != null && appStoreURL.m_stringLength != 0)
						{
							nint num12 = (nint)typeof(OnlineSettings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v56 (Il2CppClass<Info.OnlineSettings>)+BA]");
							object obj11 = (nint)0 & (nint)0x200;
							if (obj11 != null)
							{
								nint num13 = (nint)typeof(OnlineSettings);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S0_v74 (Il2CppClass<Info.OnlineSettings>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							string saveDataPath = OnlineSettings.GetSaveDataPath();
							if (((OnlineSettings)(object)saveDataPath).TryGetValue("rating_popup_enabled", out *(string*)1))
							{
								nint num14 = (nint)typeof(UIScreenController);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S0_v64 (Il2CppClass<UIScreenController>)+BA]");
								object obj12 = (nint)0 & (nint)0x200;
								if (obj12 != null)
								{
									nint num15 = (nint)typeof(UIScreenController);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S0_v70 (Il2CppClass<UIScreenController>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								bool flag2 = UIScreenController.ShouldShowOnlineScreen();
								((UIScreenController)flag2)._ActivateNextPopup("RatingPopup");
							}
						}
					}
				}
			}
		}
		CountUpCompleted();
		IEnumerator enumerator = CountUpCoins();
		if (enumerator != null)
		{
			OfferWallManager instance = OfferWallManager.instance;
			nint num16 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S1_v33 (Il2CppClass<AdLocations>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num17 = (nint)typeof(AdLocations);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S1_v40 (Il2CppClass<AdLocations>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((AdSystemManager)(object)instance).FinishedWatchingVideo((string)(object)AdLocations.GAME_OVER_INTERSTITIALS, (string)null);
		}
		StayInOneLaneMission instance2 = StayInOneLaneMission.instance;
		PersistentAwardProgress savedProgress = (PersistentAwardProgress)(_scoreTo - _scoreFrom);
		((OwnBoardsAward)(object)instance2)._002Ector((AwardStaticData)3, savedProgress, (Action<Award>)(-1));
	}

	private void SpawnDoubleCoinVariation(string variation)
	{
		OnLastPopupClosed();
	}

	private unsafe void UpdateDoubleCoin(string data = "")
	{
		//IL_00b2: Expected I4, but got Obj
		//IL_00cb: Expected I4, but got Obj
		//IL_026f: Expected I, but got Obj
		//IL_0285: Expected Obj, but got I
		//IL_00e4: Expected I4, but got Obj
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected Obj, but got Unknown
		//IL_02f3: Expected Obj, but got I4
		//IL_02ff: Expected Obj, but got VT
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		//IL_0322: Expected I, but got Obj
		//IL_0338: Expected Obj, but got I
		//IL_00fd: Expected I4, but got Obj
		//IL_0110: Expected I, but got Obj
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_015d: Expected I, but got Obj
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected Obj, but got Unknown
		GameObject doubleCoinVariationAnchor;
		bool ignoreChildrenWithColliders;
		while (true)
		{
			_doubleCoinsButton.tag = null;
			if (_currentVariation == "B")
			{
				if (_currentVariation == "C")
				{
					if (_currentVariation == "D")
					{
						if (!(_currentVariation == "E"))
						{
							doubleCoinVariationAnchor = _doubleCoinVariationAnchor;
							ignoreChildrenWithColliders = (byte)(int)_DoubleCoinVariationEPrefab != 0;
							break;
						}
						if (!(_currentVariation == "A"))
						{
							object obj = this + 92;
							obj = _currentVariation;
							return;
						}
						continue;
					}
					doubleCoinVariationAnchor = _doubleCoinVariationAnchor;
					ignoreChildrenWithColliders = (byte)(int)_DoubleCoinVariationDPrefab != 0;
					break;
				}
				doubleCoinVariationAnchor = _doubleCoinVariationAnchor;
				ignoreChildrenWithColliders = (byte)(int)_DoubleCoinVariationCPrefab != 0;
				break;
			}
			doubleCoinVariationAnchor = _doubleCoinVariationAnchor;
			ignoreChildrenWithColliders = (byte)(int)_DoubleCoinVariationBPrefab != 0;
			break;
		}
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v19 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v35 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = this + 96;
		int num3 = NGUITools.CalculateNextDepth(doubleCoinVariationAnchor, ignoreChildrenWithColliders);
		_0021_00210 componentInChildren = (_0021_00210)((GameObject)num3).GetComponentInChildren<T>();
		obj3 = componentInChildren;
		object obj4 = this + 92;
		obj4 = _currentVariation;
		nint num4 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v20 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num5 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v39 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<Characters.CharacterId, bool> hasCharacterBeenSeen = UserSave.hasCharacterBeenSeen;
		((EventButtonBreadcrumb)(object)_currentButton).PopupWasShown((string)(object)hasCharacterBeenSeen);
		UIEventTrigger component = _currentButton.GetComponent<UIEventTrigger>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		EventDelegate.Callback callback = default;
		((Delegate)callback).method_ptr = method_ptr;
		((Delegate)callback).method = (nint)__ldftn(GameOverScreen.OnDoubleCoinsClicked);
		object obj6 = callback + 16;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		EventDelegate eventDelegate = default;
		eventDelegate.Set(callback);
		component.onClick.Add(eventDelegate);
		_doubleCoinVariationAnchor.tag = null;
	}

	public void StopCoinsCountUp()
	{
		//IL_003b: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		CountUpCompleted();
		this._002Ector();
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		int coinsCollectedRun = ((GameStats)(object)privacyPolicyUrl).CoinsCollectedRun;
		SetupDoubleCoinsVideoBanner((UI.DoubleCoinsVideo.DoubleCoinsVideo)coinsCollectedRun, (Transform)1);
	}

	private IEnumerator CountUpCoins()
	{
		//IL_031c: Expected I, but got Obj
		//IL_0332: Expected Obj, but got I
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Expected Obj, but got Unknown
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Expected Obj, but got Unknown
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Expected Obj, but got Unknown
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Expected Obj, but got Unknown
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Expected Obj, but got Unknown
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected Obj, but got Unknown
		//IL_05f1: Expected Obj, but got I4
		//IL_0075: Expected I, but got Obj
		//IL_008b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0370: Expected Obj, but got I4
		//IL_0382: Expected I, but got Obj
		//IL_0398: Expected Obj, but got I
		//IL_03cd: Expected I, but got Obj
		//IL_03e3: Expected Obj, but got I
		//IL_00b6: Expected I, but got Obj
		//IL_040a: Expected Obj, but got VT
		//IL_043d: Expected Obj, but got VT
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected Obj, but got Unknown
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected Obj, but got Unknown
		//IL_0103: Expected I, but got Obj
		//IL_01b9: Expected Obj, but got I4
		//IL_0150: Expected I, but got Obj
		//IL_0198: Expected Obj, but got I4
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Expected Obj, but got Unknown
		//IL_0631: Expected I, but got Obj
		//IL_0647: Expected Obj, but got I
		//IL_04d9: Expected I, but got Obj
		//IL_04ef: Expected Obj, but got I
		//IL_0680: Expected Obj, but got I4
		//IL_01ea: Expected I, but got Obj
		//IL_0289: Expected Obj, but got I4
		//IL_0237: Expected I, but got Obj
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected I4, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected Obj, but got Unknown
		//IL_02be: Expected Obj, but got I4
		//IL_0309: Expected Obj, but got I4
		//IL_0552: Expected Obj, but got VT
		//IL_0564: Expected VT, but got Obj
		//IL_0586: Expected Obj, but got I4
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v118 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 48;
		object obj4 = obj3 + 40;
		object obj5 = obj3 + 32;
		object obj6 = obj3 + 24;
		object obj7 = obj3 + 16;
		object obj8 = obj3 + 8;
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		if (((UIScreenController)flag).IsPopupQueueEmpty())
		{
			_hasAttemptedToShowAdOnTopOfPopup = true;
			return null;
		}
		nint num3 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v32 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num4 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v112 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		string value = ((OnlineSettings)(object)saveDataPath).GetValue("interstitial_game_over_counter_expire_time", (string)72000);
		nint num5 = (nint)typeof(TimeSpan);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v18 (Il2CppClass<System.TimeSpan>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num6 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v73 (Il2CppClass<System.TimeSpan>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3EB");
		nint num7 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v41 (Il2CppClass<System.DateTime>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num8 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v108 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj5 = _lastCountUpTimeStamp;
		object obj12 = default;
		obj6 = obj12;
		obj4 = obj5;
		obj2 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCFF");
		DateTime utcNow = CDateTime.UtcNow;
		obj7 = utcNow;
		object obj13 = default;
		obj8 = obj13;
		obj4 = obj7;
		obj2 = obj8;
		object obj14 = obj4 & 0x3FFFFFFFFFFFFFFFL;
		object obj15 = obj2 & 0x3FFFFFFFFFFFFFFFL;
		object obj16;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15))
		{
			obj16 = 1;
		}
		else
		{
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15);
			object obj17 = (flag2 ? 1u : 0u) << 31;
			obj16 = obj17 >> 31;
		}
		if ((nint)obj16 >= 1)
		{
			_counter = 0;
		}
		object obj18 = this + 140;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		nint num9 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v66 (Il2CppClass<Flurry>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num10 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v98 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num11 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v71 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num12 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v94 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath2 = OnlineSettings.GetSaveDataPath();
		string value2 = ((OnlineSettings)(object)saveDataPath2).GetValue("interstitial_game_over_total_show_slots", (string)5);
		string saveDataPath3 = OnlineSettings.GetSaveDataPath();
		string value3 = ((OnlineSettings)(object)saveDataPath3).GetValue("interstitial_game_over_active_show_slot", (string)1);
		object obj21;
		if (value2 == null)
		{
			obj21 = 0;
		}
		else
		{
			int num13 = _counter / value2;
			object obj22 = num13 * value2;
			obj21 = _counter - obj22;
		}
		string text = ((System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref value3) >= System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref value2)) ? ((string)1) : value3);
		bool flag3 = obj21 == text;
		DateTime utcNow2 = CDateTime.UtcNow;
		obj3 = utcNow2;
		obj2 = obj3;
		_lastCountUpTimeStamp = (DateTime)obj2;
		int counter = _counter + 1;
		_counter = counter;
		return (IEnumerator)flag3;
	}

	private IEnumerator CountUpDoubleCoinsVideo(int coinsToPayout)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = this;
		int num = coinsToPayout & 1;
		return enumerator;
	}

	public void LeaderboardTabTapped()
	{
		//IL_0010: Expected I4, but got Obj
		//IL_0038: Expected Obj, but got I4
		if (~(_countingUpCoins ? 1u : 0u) == 0)
		{
			useGUILayout = (byte)(int)"CountUpCoins" != 0;
			ScoreCounterSoundPlayer scoreCounterSoundPlayer = _scoreCounterSoundPlayer;
			scoreCounterSoundPlayer.playScore = false;
			((CoinEarnerLoadingOffer)(object)_coinBoxSizer).Init((Action)1);
			_countingUpCoins = false;
			OnFriendsChanged();
		}
	}

	public void TopRunTabTapped()
	{
		//IL_0040: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I4
		if (~(_leaderboardTabActive ? 1u : 0u) != 0)
		{
			_topRunContent.tag = null;
			_leaderboardContent.tag = (string)1;
			leaderboardHandler.ScrollToMyPosition();
			_leaderboardTabActive = true;
			_currentActiveTab = ActiveTabState.LeaderBoard;
			this._002Ector();
			string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
			int coinsCollectedRun = ((GameStats)(object)privacyPolicyUrl).CoinsCollectedRun;
			SetupDoubleCoinsVideoBanner((UI.DoubleCoinsVideo.DoubleCoinsVideo)coinsCollectedRun, (Transform)1);
			TransformExtensions.Reset((Transform)(object)this.m_onTabClicked);
		}
	}

	private void SetupDoubleCoinsVideo(int coinsCollectedTotal, bool showValueImmediately = false)
	{
		OnCoinsChanged();
	}

	private void SetupLoggedInDoubleCoinsVideoButton()
	{
		//IL_0040: Expected Obj, but got I4
		//IL_0080: Expected Obj, but got I4
		//IL_0080: Expected Obj, but got I4
		if (~(_leaderboardTabActive ? 1u : 0u) == 0)
		{
			_leaderboardTabActive = false;
			_leaderboardContent.tag = null;
			_topRunContent.tag = (string)1;
			_currentActiveTab = ActiveTabState.TopRun;
			this._002Ector();
			string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
			int coinsCollectedRun = ((GameStats)(object)privacyPolicyUrl).CoinsCollectedRun;
			SetupDoubleCoinsVideoBanner((UI.DoubleCoinsVideo.DoubleCoinsVideo)coinsCollectedRun, (Transform)1);
			TransformExtensions.Reset((Transform)(object)this.m_onTabClicked);
		}
	}

	private void SetupBigBanner()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_0056: Expected I4, but got Obj
		//IL_0056: Expected I4, but got Obj
		bool isInitialized = AdSystemManager.isInitialized;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ S0_v2 (System.Boolean)+D]");
		if ((nint)0 == 0)
		{
			object obj = this + 276;
			GameObject gameObject = ((UpgradeScreen)(object)this).MakeBuyable((UpgradeType)_doubleCoinVideoButtonPrefab, (byte)(int)_doubleCoinVideoButtonParent != 0);
			obj = gameObject;
			UIPanel leaderboardPanel = _leaderboardPanel;
			UIRect.AnchorPoint topAnchor = leaderboardPanel.topAnchor;
			topAnchor.relative = 0f;
			UIPanel leaderboardPanel2 = _leaderboardPanel;
			UIRect.AnchorPoint topAnchor2 = leaderboardPanel2.topAnchor;
			topAnchor2.absolute = -3;
			UIPanel topRunPanel = _topRunPanel;
			UIRect.AnchorPoint topAnchor3 = topRunPanel.topAnchor;
			topAnchor3.relative = 0f;
			UIPanel topRunPanel2 = _topRunPanel;
			UIRect.AnchorPoint topAnchor4 = topRunPanel2.topAnchor;
			topAnchor4.absolute = -3;
			((UIRect)_leaderboardPanel).ParentHasChanged();
			((UIRect)_topRunPanel).ParentHasChanged();
			if (~(_leaderboardTabActive ? 1u : 0u) == 0)
			{
				leaderboardHandler.ScrollToMyPosition();
			}
		}
	}

	private void SetupSmallBanner()
	{
		//IL_0012: Expected I4, but got Obj
		((GameOverTabHelper)(object)this).SetLabelActive((UILabel)(object)_doubleCoinsVideoBannerBigPrefab, (byte)(int)_doubleCoinVideoBannerParent != 0);
	}

	private void SetupDoubleCoinsVideoBanner(UI.DoubleCoinsVideo.DoubleCoinsVideo prefab, Transform container)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0044: Expected I, but got Obj
		//IL_005a: Expected Obj, but got I
		//IL_0085: Expected I, but got Obj
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_023b: Expected I, but got Obj
		//IL_0251: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I4
		//IL_00ec: Expected I, but got Obj
		bool isInitialized = AdSystemManager.isInitialized;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (System.Boolean)+D]");
		if ((nint)0 != 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 12;
		obj = this;
		SetupBigBanner();
		bool flag = Breadcrumb.CheckNewWeeklyHunt();
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v18 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v42 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((flag ? 1 : 0) < (nint)prefab)
		{
			UI.DoubleCoinsVideo.DoubleCoinsVideo doubleCoinsVideo = (UI.DoubleCoinsVideo.DoubleCoinsVideo)flag;
		}
		else
		{
			UI.DoubleCoinsVideo.DoubleCoinsVideo doubleCoinsVideo = prefab;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		object obj5 = default;
		object obj4 = obj5 + 16;
		obj4 = obj2;
		object obj7 = default;
		object obj6 = obj7 + 12;
		obj6 = obj5;
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_doubleCoinsVideoElement != null)
		{
			SetupBigBanner();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		if ((object)container != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
	}

	private void RemoveDoubleCoinsVideo()
	{
		//IL_0012: Expected I4, but got Obj
		((GameOverTabHelper)(object)this).SetLabelActive((UILabel)(object)_doubleCoinsVideoBannerSmallPrefab, (byte)(int)_doubleCoinVideoBannerParent != 0);
	}

	private UI.DoubleCoinsVideo.DoubleCoinsVideo GetDoubleCoinsInstance(UI.DoubleCoinsVideo.DoubleCoinsVideo prefab, Transform container)
	{
		//IL_0009: Expected Obj, but got I4
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A3");
		UI.DoubleCoinsVideo.DoubleCoinsVideo result = default;
		return result;
	}

	private bool IsLoggedInToFacebook()
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = this;
		return flag;
	}

	private bool HasAdFill()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a5: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		return ((SocialManager)facebookDialogsSupported).HasFacebookAccessToken();
	}

	private DoubleCoinsElementType GetDoubleCoinsElementType()
	{
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		OfferWallManager instance = OfferWallManager.instance;
		nint num = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S1_v3 (Il2CppClass<AdLocations>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v10 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return ((AdSystemManager)(object)instance).IsCaching((string)(object)AdLocations.GAMEOVER_DOUBLE_COINS_VIDEOS) ? DoubleCoinsElementType.SmallBanner : DoubleCoinsElementType.Button;
	}

	private bool IsSmallAspect()
	{
		if (((LeaderboardOnlineScreen)null).GetMyIndexInTheList() == 0 && !((GameOverScreen)null).HasAdFill())
		{
			if (_currentActiveTab == ActiveTabState.TopRun)
			{
				return false;
			}
			return true;
		}
		return false;
	}

	public ActiveTabState GetActiveTabState(Action onTabChanged)
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		ActiveTabState activeTabState = default;
		object obj = activeTabState + 16;
		obj = this;
		return activeTabState;
	}

	public GameOverScreen()
	{
		//IL_0033: Expected I, but got Obj
		//IL_0049: Expected Obj, but got I
		//IL_0074: Expected I, but got Obj
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_0102: Expected Obj, but got I4
		UIPanel leaderboardPanel = _leaderboardPanel;
		UIRect.AnchorPoint topAnchor = leaderboardPanel.topAnchor;
		topAnchor.relative = 1f;
		UIPanel leaderboardPanel2 = _leaderboardPanel;
		UIRect.AnchorPoint topAnchor2 = leaderboardPanel2.topAnchor;
		topAnchor2.absolute = 1;
		UIPanel leaderboardPanel3 = _leaderboardPanel;
		UIRect.AnchorPoint bottomAnchor = leaderboardPanel3.bottomAnchor;
		bottomAnchor.relative = 0f;
		UIPanel leaderboardPanel4 = _leaderboardPanel;
		UIRect.AnchorPoint bottomAnchor2 = leaderboardPanel4.bottomAnchor;
		bottomAnchor2.absolute = 1;
		((UIRect)_leaderboardPanel).ParentHasChanged();
		UIPanel topRunPanel = _topRunPanel;
		UIRect.AnchorPoint topAnchor3 = topRunPanel.topAnchor;
		topAnchor3.relative = 1f;
		UIPanel topRunPanel2 = _topRunPanel;
		UIRect.AnchorPoint topAnchor4 = topRunPanel2.topAnchor;
		topAnchor4.absolute = 1;
		UIPanel topRunPanel3 = _topRunPanel;
		UIRect.AnchorPoint bottomAnchor3 = topRunPanel3.bottomAnchor;
		bottomAnchor3.relative = 0f;
		UIPanel topRunPanel4 = _topRunPanel;
		UIRect.AnchorPoint bottomAnchor4 = topRunPanel4.bottomAnchor;
		bottomAnchor4.absolute = 1;
		((UIRect)_topRunPanel).ParentHasChanged();
		if (~(_leaderboardTabActive ? 1u : 0u) == 0)
		{
			leaderboardHandler.ScrollToMyPosition();
		}
		else
		{
			_topRunContentScript.AnimateMedalIfNeeded();
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_doubleCoinsVideoElement).FindKernel((string)null) != 0)
		{
			string text = _doubleCoinsVideoElement.tag;
			((GameObject)(object)text).tag = null;
			string action = _doubleCoinsVideoElement.tag;
			MiscExtensions.SafeInvoke((Action)(object)action);
			object obj2 = this + 276;
			obj2 = 0;
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using AppRefresh;
using Cpp2ILInjected;
using Data.Save;
using InAppPurchase.Internal;
using Ionic.Crc;
using Ionic.Zlib;
using Kiloo;
using Kiloo.Common.Backend.PurchaseValidation;
using Kiloo.Common.Extensions;
using Missions;
using SYBO.Subway.Info;
using UI;
using UnityEngine;
using UnityEngine.Networking;
using WeeklyHunt;

namespace WordHunt;

public class WordHuntManager
{
	private enum WordHuntServerData
	{
		wordIndex,
		dailyWord,
		year,
		checksum,
		month,
		day,
		hour,
		minute,
		second,
		expireSeconds
	}

	public class WordHuntPayload
	{
		public bool todayCompleted;

		public int activeDayIndex;
	}

	public enum WordHuntRewardType
	{
		Coins,
		MysteryBox
	}

	[StructLayout((LayoutKind)0, Size = 12)]
	public struct WordHuntReward
	{
		public WordHuntRewardType type;

		public int coins;

		public MysteryBox.Type mysteryBoxType;
	}

	private sealed class _003CDownloadDailyCoroutine_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WordHuntManager _003C_003E4__this;

		private string _003Ckey_003E5__2;

		private WWW _003Cwww_003E5__3;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f2: Expected I4, but got Unknown
				//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0400: Expected Obj, but got Unknown
				//IL_0045: Expected Obj, but got VT
				//IL_0052: Expected I4, but got Obj
				//IL_0061: Expected I4, but got Obj
				//IL_008f: Expected Obj, but got VT
				//IL_009c: Expected I4, but got Obj
				//IL_00b4: Expected I, but got Obj
				//IL_00ca: Expected Obj, but got I
				//IL_0425: Unknown result type (might be due to invalid IL or missing references)
				//IL_042a: Expected Obj, but got Unknown
				//IL_035a: Expected I, but got Obj
				//IL_0370: Expected Obj, but got I
				//IL_0148: Expected I4, but got Obj
				//IL_00f5: Expected I, but got Obj
				//IL_045e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0463: Expected Obj, but got Unknown
				//IL_046c: Expected Obj, but got I4
				//IL_0472: Unknown result type (might be due to invalid IL or missing references)
				//IL_0477: Expected Obj, but got Unknown
				//IL_0480: Expected Obj, but got I4
				//IL_021e: Expected Obj, but got I4
				//IL_0227: Expected Obj, but got I4
				//IL_0169: Expected I4, but got Obj
				//IL_0169: Expected I4, but got Obj
				//IL_016f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0174: Expected Obj, but got Unknown
				//IL_0182: Unknown result type (might be due to invalid IL or missing references)
				//IL_0187: Expected Obj, but got Unknown
				//IL_01a5: Expected Obj, but got I4
				//IL_039b: Expected I, but got Obj
				//IL_02a6: Expected I, but got Obj
				//IL_02bc: Expected Obj, but got I
				//IL_0279: Unknown result type (might be due to invalid IL or missing references)
				//IL_027e: Expected Obj, but got Unknown
				//IL_028f: Expected I4, but got Obj
				//IL_02e7: Expected I, but got Obj
				object obj = default;
				int num = obj + 16;
				object obj2 = obj + 8;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						if (!_003Cwww_003E5__3.isDone)
						{
							Texture2D texture = _003Cwww_003E5__3.texture;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
							int num2 = default;
							object obj3 = num2 + 16;
							obj3 = 59;
							string text = ((string)(object)texture).Substring(num2);
							IEnumerator enumerator = ((AwardCellHelper)null).AnimateChangingOfTierSprite((UISprite)(object)text, (AwardTierHelper)(object)_003Ckey_003E5__2);
							if (enumerator != null)
							{
								object obj4 = _003C_003E4__this + 8;
								obj4 = text;
								WordHuntReward rewardForDay = GetRewardForDay((int)text);
							}
							else
							{
								nint num3 = (nint)typeof(WordHuntManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v87 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
								object obj5 = (nint)0 & (nint)0x200;
								if (obj5 != null)
								{
									nint num4 = (nint)typeof(WordHuntManager);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v93 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
							}
						}
						else
						{
							bool isDone = _003Cwww_003E5__3.isDone;
							string text2 = string.ConcatArray((string[])(object)"DailyWord.DownloadDailyCoroutine: www.error: ", isDone ? 1 : 0);
							nint num5 = (nint)typeof(WordHuntManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v71 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
							object obj6 = (nint)0 & (nint)0x200;
							if (obj6 != null)
							{
								nint num6 = (nint)typeof(WordHuntManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v74 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
						}
						object obj7 = this + 20;
						obj7 = 0;
						object obj8 = this + 24;
						obj8 = 0;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				DateTime today = CDateTime.Today;
				obj2 = today;
				((int*)num)->m_value = (int)obj2;
				if (RandomNumber((int)_003C_003E4__this, num) != 0)
				{
					obj = today;
					((int*)num)->m_value = (int)obj;
					_ = ((int*)num)->m_value;
					nint num7 = (nint)typeof(WordHuntManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v28 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num8 = (nint)typeof(WordHuntManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v47 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj10 = this + 20;
					WordHuntPayload wordHuntPayload = GetWordHuntPayload();
					obj10 = wordHuntPayload;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					CertificateHandler certificateHandler = default;
					certificateHandler.Release();
					((WWWForm)(object)certificateHandler).AddField("key", (int)_003Ckey_003E5__2);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					string text3 = default;
					ScreenCapture.CaptureScreenshot(text3, (int)"http://hoodrunner.kiloo.com/hr_dailyquests2.php", (ScreenCapture.StereoScreenCaptureMode)certificateHandler);
					object obj11 = this + 24;
					obj11 = text3;
					object obj12 = this + 12;
					obj12 = _003Cwww_003E5__3;
					_003C_003E1__state = 1;
					return 1;
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CDownloadDailyCoroutine_003Ed__10(int _003C_003E1__state)
		{
			//IL_00f6: Expected Obj, but got I
			//IL_00f6: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_0054: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj = default;
			if ((nint)obj == 2)
			{
				nint num = (nint)typeof(PurchaseValidationExtensions);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v15 (Il2CppClass<InAppPurchase.Internal.PurchaseValidationExtensions>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num2 = (nint)typeof(PurchaseValidationExtensions);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<InAppPurchase.Internal.PurchaseValidationExtensions>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				PurchaseValidationExtensions._hasDetectedAnyInvalidPurchases = true;
			}
			object obj3 = _003C_003E2__current;
			int num3 = this._003C_003E1__state;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v10 (System.Object)+8]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v7 (System.Int32)+10]");
			((Action<IPurchaseValidationResult>)num4)((IPurchaseValidationResult)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected Obj, but got Unknown
			//IL_00bf: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(DeflateManager.Config);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Ionic.Zlib.DeflateManager+Config>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(DeflateManager.Config);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<Ionic.Zlib.DeflateManager+Config>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = DeflateManager.Config.Table + 16;
			object obj3 = (object)this << 2;
			object obj4 = obj2 + obj3;
			return (byte)(int)obj4 != 0;
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

	private static readonly WordHuntReward[] REWARDS;

	private string[] _lastRawData;

	private DateTime _lastRequestTime;

	private static WordHuntManager _instance;

	private static Action m_OnPickedUpLetter;

	private static Action m_OnDailyWordInRowChanged;

	private static Action<int> m_OnDailyLetterCoinsRewarded;

	private List<string> _wordHuntWords;

	public static WordHuntManager instance
	{
		get
		{
			//IL_0103: Expected Obj, but got I4
			//IL_0111: Expected I, but got Obj
			//IL_0127: Expected Obj, but got I
			//IL_01ac: Expected I, but got Obj
			//IL_01c2: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_020d: Expected Obj, but got I4
			//IL_00da: Expected Obj, but got I4
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Expected Obj, but got Unknown
			WordHuntManager wordHuntManager = (WordHuntManager)0;
			nint num = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(WordHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v44 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = wordHuntManager.GetDailyWordOffline();
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v17 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v40 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((nint)text < 0)
			{
				text = null;
			}
			else if ((nint)text > 5)
			{
				text = (string)5;
			}
			bool flag = wordHuntManager == null;
			string text2 = text;
			if (!flag)
			{
				string text3 = (string)(text - 1);
				text2 = text3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			bool flag2 = wordHuntManager != null;
			WordHuntManager wordHuntManager2 = default;
			wordHuntManager2._lastRawData = (string[])flag2;
			return wordHuntManager2;
		}
	}

	public static event Action OnPickedUpLetter
	{
		add
		{
			((PrizeIconPrefabData)(object)value)._002Ector();
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(WordHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = WordHuntManager.m_OnPickedUpLetter;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(WordHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(WordHuntManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(WordHuntManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(WordHuntManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(WordHuntManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<WordHunt.WordHuntManager>)+5C]");
				object obj5 = (nint)0 + (nint)8;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public static event Action OnDailyWordInRowChanged
	{
		add
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(WordHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = WordHuntManager.m_OnPickedUpLetter;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(WordHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(WordHuntManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(WordHuntManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(WordHuntManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(WordHuntManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<WordHunt.WordHuntManager>)+5C]");
				object obj5 = (nint)0 + (nint)8;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(WordHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = WordHuntManager.m_OnDailyWordInRowChanged;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(WordHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(WordHuntManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(WordHuntManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(WordHuntManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(WordHuntManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<WordHunt.WordHuntManager>)+5C]");
				object obj5 = (nint)0 + (nint)12;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<int> OnDailyLetterCoinsRewarded
	{
		add
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(WordHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = WordHuntManager.m_OnDailyWordInRowChanged;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(WordHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(WordHuntManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(WordHuntManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(WordHuntManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(WordHuntManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<WordHunt.WordHuntManager>)+5C]");
				object obj5 = (nint)0 + (nint)12;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(WordHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = WordHuntManager.m_OnDailyLetterCoinsRewarded;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(WordHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(WordHuntManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(WordHuntManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(WordHuntManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(WordHuntManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<WordHunt.WordHuntManager>)+5C]");
				object obj5 = (nint)0 + (nint)16;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	private WordHuntManager()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00e5: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 8;
		obj = obj2;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		object obj3 = obj + 4;
		object obj4 = obj3 + 1;
		obj3 = obj4;
		object obj5 = obj4 << 2;
		object obj6 = obj + obj5;
		obj6 = 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			object obj7 = (nint)0 << 2;
			object obj8 = obj + obj7;
			if ((nint)obj8 == 16)
			{
				object obj9 = obj + 4;
				if ((nint)obj9 > -1)
				{
					object obj10 = obj9 + -1;
					obj9 = obj10;
				}
				return;
			}
		}
		object obj11 = default;
		if (obj11 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private void AppHasRefreshed(RefreshType obj)
	{
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00c5: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (WordHunt.WordHuntManager)+29]");
		if ((nint)0 != 0)
		{
			return;
		}
		if (obj != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (WordHunt.WordHuntManager)+14]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (WordHunt.WordHuntManager)+28]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E4D3");
				}
				object obj2 = this + 20;
				obj2 = 0;
			}
		}
		_ = 1;
	}

	private void AutoSyncer(string screenName)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0053: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 4;
		obj = screenName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		obj2 = 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Enum obj3 = default;
		IFormatProvider provider = default;
		if (obj3.System_002EIConvertible_002EToBoolean(provider))
		{
			DownloadDailyIfExpired();
		}
	}

	public void DownloadDaily()
	{
		//IL_0416: Expected I, but got Obj
		//IL_042c: Expected Obj, but got I
		//IL_0494: Expected Obj, but got VT
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected Obj, but got Unknown
		//IL_04b4: Expected VT, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected Obj, but got Unknown
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected Obj, but got Unknown
		//IL_0387: Expected I, but got Obj
		//IL_039d: Expected Obj, but got I
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected Obj, but got Unknown
		//IL_03c8: Expected I, but got Obj
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<System.DateTime>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v98 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = DateTime.MinValue;
		object obj3 = obj2 + 8;
		obj3 = obj2;
		_lastRequestTime = (DateTime)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		list.Add("BEAT");
		list.Add("ZOOM");
		list.Add("ROLL");
		list.Add("NYC");
		list.Add("GOAL");
		list.Add("MOVE");
		list.Add("SUPER");
		list.Add("PLAY");
		list.Add("SCORE");
		list.Add("TRAIN");
		list.Add("NICE");
		list.Add("APPLE");
		list.Add("JIVE");
		list.Add("JUMP");
		list.Add("SPORT");
		list.Add("PARK");
		list.Add("STYLE");
		list.Add("WIN");
		list.Add("SLAM");
		list.Add("RUSH");
		list.Add("CHAMP");
		list.Add("LEAD");
		list.Add("SPRAY");
		list.Add("TAXI");
		list.Add("REBEL");
		list.Add("SLICK");
		list.Add("WIN");
		list.Add("CHASE");
		list.Add("BLAST");
		list.Add("FUN");
		list.Add("BRONX");
		list.Add("SKATE");
		list.Add("TOP");
		list.Add("BOOM");
		list.Add("CREW");
		list.Add("DASH");
		list.Add("COOL");
		list.Add("HOOD");
		list.Add("DARE");
		list.Add("FLEE");
		list.Add("FRESH");
		list.Add("FEEL");
		list.Add("GREAT");
		list.Add("RUN");
		list.Add("JUMP");
		list.Add("BIG");
		object obj4 = this + 24;
		obj4 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<string> action = default;
		object obj5 = action + 16;
		obj5 = this;
		nint num4 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S0_v78 (Il2CppClass<UIScreenController>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num5 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S0_v94 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnChangedScreen -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num6 = 0;
		_ = 0;
		Action<RefreshType> action2 = default;
		object obj7 = action2 + 16;
		obj7 = this;
		AppRefreshHandler.hasRefreshed -= action2;
	}

	public void DownloadDailyIfExpired()
	{
		OnPickedUpLetter += (Action)(object)this;
	}

	private void LoadDailyData()
	{
		OnPickedUpLetter += (Action)(object)this;
	}

	private IEnumerator DownloadDailyCoroutine()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		IEnumerator result = default;
		return result;
	}

	private bool IsAllowedToMakeRequest(DateTime time)
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = this;
		return flag;
	}

	private void LoadFromRawData(string[] rawData)
	{
		if (!((string)(object)rawData == "FrontScreen") || (string)(object)rawData != "GameOverScreen")
		{
			DownloadDailyIfExpired();
		}
	}

	private void CalculateAndSaveLastKnownServerTime(string year, string month, string day, string hour, string minute, string second)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_0055: Expected Obj, but got I4
		_lastRawData = null;
		object obj = this + 44;
		obj = day;
		object obj2 = this + 52;
		obj2 = minute;
		object obj3 = this + 16;
		obj3 = 0;
	}

	private bool SHA1HashCheck(string[] rawData, string key)
	{
		//IL_0012: Expected Obj, but got I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected I4, but got Unknown
		bool flag = false;
		object obj = 0;
		string text = default;
		string text2 = default;
		while (text != null)
		{
			object obj2 = text & 1;
			if (obj2 != null)
			{
				object obj3 = rawData + 16;
				object obj4 = obj << 2;
				object obj5 = obj3 + obj4;
				bool flag2 = (byte)((obj5 ^ flag) ? 1 : 0) != 0;
				flag = flag2;
			}
			text = (string)((object)text2 >> 1);
			object obj6 = obj + 1;
			obj = obj6;
		}
		return flag;
	}

	private static string RandomString(int size)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		text.m_stringLength = 0;
		object obj = text + 16;
		obj = size;
		return text;
	}

	private unsafe static int RandomNumber(int min, int max)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I4
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_00c5: Expected Obj, but got I4
		//IL_00d5: Expected Obj, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected VT, but got Unknown
		//IL_00f0: Expected I8, but got Obj
		//IL_00eb: Expected native int or pointer, but got VT
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_0113: Expected Ref, but got VT
		//IL_011f: Expected Obj, but got I8
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<System.DateTime>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v31 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 8;
		obj4 = ((int*)max)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [min @ L0 (System.Int32)+10]");
		obj2 = 0;
		DateTime dateTime = (DateTime)(obj2 + 24);
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj4;
		IFormatProvider formatProvider = (IFormatProvider)(obj2 + 32);
		formatProvider = (IFormatProvider)obj2;
		long num3 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		obj = num3;
		double num4 = (double)obj * 1E-07;
		return (num4 > 120.0) ? 1 : 0;
	}

	private static string GenerateKey()
	{
		return null;
	}

	public unsafe static WordHuntPayload GetWordHuntPayload()
	{
		//IL_00bc: Expected I, but got Obj
		//IL_00d2: Expected Obj, but got I
		//IL_010a: Expected Obj, but got I4
		//IL_0119: Expected VT, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		System.Text.StringBuilderCache.Release(stringBuilder);
		nint num = (nint)typeof(WordHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v21 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int wordHuntDaysInARow = GetWordHuntDaysInARow(out *(bool*)4);
		StringBuilder stringBuilder2 = stringBuilder.AppendLine((string)wordHuntDaysInARow);
		GameObject prefab = ((PrizeIconPrefabData)null).GetPrefab((WeeklyHuntData.PrizeData)999);
		StringBuilder stringBuilder3 = stringBuilder.Append(prefab);
		int wordHuntDaysInARow2 = GetWordHuntDaysInARow(out *(bool*)2);
		StringBuilder stringBuilder4 = stringBuilder.AppendLine((string)wordHuntDaysInARow2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		WordHuntPayload result = default;
		return result;
	}

	public static WordHuntReward GetRewardForDay(int dayIndex)
	{
		//IL_00ad: Expected Obj, but got I4
		//IL_00bb: Expected Obj, but got I4
		//IL_00c9: Expected I, but got Obj
		//IL_00df: Expected Obj, but got I
		//IL_012f: Expected Obj, but got I4
		//IL_013d: Expected Obj, but got I4
		//IL_014b: Expected Obj, but got I4
		//IL_0159: Expected Obj, but got I4
		//IL_0167: Expected Obj, but got I4
		//IL_0175: Expected Obj, but got I4
		//IL_0193: Expected I4, but got Obj
		//IL_0193: Expected I4, but got Obj
		//IL_01a1: Expected I, but got Obj
		//IL_01b7: Expected Obj, but got I
		//IL_0109: Expected I4, but got Obj
		//IL_0114: Expected VT, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected VT, but got Obj
		object obj = dayIndex + 20;
		object value = dayIndex + 52;
		nint num = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S2_v3 (Il2CppClass<System.Convert>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S2_v19 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		uint additionalOffset = Convert.ToUInt32(value);
		object obj3 = dayIndex + 24;
		object title = dayIndex + 32;
		object desc = dayIndex + 36;
		object iconName = dayIndex + 40;
		object obj4 = dayIndex + 44;
		object onClickDelegate = dayIndex + 48;
		((CoinEarnerButtonHelper)null).Init((int)obj3, (string)title, (string)desc, (string)iconName, (int)obj4, (Action)onClickDelegate);
		nint num3 = (nint)typeof(WordHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S2_v10 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			WordHuntReward wordHuntReward = (WordHuntReward)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S2_v15 (WordHunt.WordHuntManager+WordHuntReward)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		WeeklyHuntData.DebugJumpToWeek((int)obj, (int)additionalOffset);
		return (WordHuntReward)typeof(WordHuntManager);
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		//IL_0148: Expected I, but got Obj
		//IL_015e: Expected Obj, but got I
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01d5: Expected Obj, but got I4
		//IL_0189: Expected I, but got Obj
		//IL_019f: Expected Obj, but got I
		//IL_00ae: Expected I, but got Obj
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_00fb: Expected I, but got Obj
		nint num = (nint)typeof(WordHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v46 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		WordHuntReward[] rEWARDS = REWARDS;
		UnityEngine.Object obj2;
		if (rEWARDS.Length > (nint)context)
		{
			obj2 = context;
		}
		else
		{
			nint num3 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v30 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(WordHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v39 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			WordHuntReward[] rEWARDS2 = REWARDS;
			obj2 = (UnityEngine.Object)(rEWARDS2.Length - 1);
		}
		nint num5 = (nint)typeof(WordHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v17 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v23 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = REWARDS + 16;
		object obj6 = obj2 * 12;
		object obj7 = obj5 + obj6;
		string text = (string)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v10+8]");
		msg.m_stringLength = 0;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
		SDebug.LogFormat(msg, (object[])(object)context);
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	private static void InitWordHunt(string word, int secondsLeft)
	{
	}

	public static void PickedupLetter(char letter)
	{
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_0161: Expected Obj, but got I4
		//IL_017d: Expected I, but got Obj
		//IL_0193: Expected Obj, but got I
		//IL_01b0: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(WordHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate obj2 = WordHuntManager.m_OnDailyLetterCoinsRewarded;
		object obj6 = default;
		while (true)
		{
			Delegate obj3 = obj2.RemoveImpl((Delegate)letter);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag = obj4 == null;
			nint num4 = (nint)typeof(WordHuntManager);
			if (!flag)
			{
				nint num5 = (nint)typeof(WordHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(WordHuntManager);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(WordHuntManager);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<WordHunt.WordHuntManager>)+5C]");
			object obj5 = (nint)0 + (nint)16;
			if (obj5 == obj2)
			{
				obj5 = obj6;
			}
			if (obj5 != obj2)
			{
				obj2 = (Delegate)obj5;
				continue;
			}
			break;
		}
	}

	public static char GetNewDailyLetter()
	{
		//IL_0130: Expected I, but got Obj
		//IL_0146: Expected Obj, but got I
		//IL_01b2: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0078: Expected I, but got Obj
		//IL_008e: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_0179: Expected Obj, but got I
		//IL_0189: Expected I4, but got Obj
		//IL_00c7: Expected I, but got Obj
		//IL_00f7: Expected I, but got Obj
		//IL_011d: Expected I, but got Obj
		nint num = (nint)typeof(WordHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _instance == null;
		bool flag2 = !flag;
		char result = (char)(int)_instance;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			WordHuntManager wordHuntManager = default;
			wordHuntManager.DownloadDaily();
			nint num3 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v20 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			bool flag3 = obj2 == null;
			nint num4 = (nint)typeof(WordHuntManager);
			if (!flag3)
			{
				nint num5 = (nint)typeof(WordHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v28 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
				bool flag4 = (nint)0 == 0;
				bool flag5 = !flag4;
				num4 = (nint)typeof(WordHuntManager);
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(WordHuntManager);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ L0_v6 (Il2CppClass<WordHunt.WordHuntManager>)+5C]");
			object obj3 = (nint)0 + (nint)4;
			obj3 = wordHuntManager;
			result = (char)(int)wordHuntManager;
		}
		return result;
	}

	public static bool IsDailyWordComplete()
	{
		//IL_019d: Expected Obj, but got I4
		//IL_0207: Expected I, but got Obj
		//IL_021d: Expected Obj, but got I
		//IL_0065: Expected I, but got Obj
		//IL_007b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01b3: Expected Obj, but got I4
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01cf: Expected Obj, but got I4
		//IL_0114: Expected I, but got Obj
		//IL_012a: Expected Obj, but got I
		//IL_00a6: Expected I, but got Obj
		//IL_0255: Expected Obj, but got I4
		//IL_0261: Expected I4, but got Obj
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_0155: Expected I, but got Obj
		object obj = 0;
		char[] array2 = default;
		char[] array3 = default;
		while (true)
		{
			nint num = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v11 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v49 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool wordHuntPayedOut = EventsSave.wordHuntPayedOut;
			char[] array = array2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v7 (System.Boolean)+8]");
			if ((nint)array < 0)
			{
				nint num3 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v21 (Il2CppClass<Data.Save.EventsSave>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(EventsSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v44 (Il2CppClass<Data.Save.EventsSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int wordHuntWordsInRow = EventsSave.wordHuntWordsInRow;
				obj = wordHuntWordsInRow;
				object obj4 = array2 & 0x1F;
				object obj5 = 1 << (int)obj4;
				object obj6 = obj & obj5;
				if (obj6 == null)
				{
					break;
				}
				array2 = (char[])(array3 + 1);
				continue;
			}
			return false;
		}
		nint num5 = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v31 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num6 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v38 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool wordHuntPayedOut2 = EventsSave.wordHuntPayedOut;
		string[] array4 = ((string)wordHuntPayedOut2).Split(array2);
		return (byte)(int)array4 != 0;
	}

	public unsafe static int GetWordHuntDaysInARow(out bool todayCompleted)
	{
		//IL_0017: Expected Obj, but got I4
		//IL_01cf: Invalid comparison between Obj and Ref
		//IL_0034: Expected I, but got Obj
		//IL_004a: Expected Obj, but got I
		//IL_0194: Expected I, but got Obj
		//IL_01aa: Expected Obj, but got I
		//IL_0075: Expected I, but got Obj
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_00c2: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		System.Text.StringBuilderCache.Release(stringBuilder);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		RankException ex = default;
		ex._002Ector();
		object obj = 0;
		object obj3 = default;
		while (System.Runtime.CompilerServices.Unsafe.IsAddressLessThan(ref *(byte*)obj, ref System.Runtime.CompilerServices.Unsafe.As<bool, byte>(ref todayCompleted)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9E28");
			nint num = (nint)typeof(Math);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v20 (Il2CppClass<System.Math>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Math);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v40 (Il2CppClass<System.Math>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			double num3 = 26.0 * (double)obj3;
			double d = num3 + 65.0;
			nint num4 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v28 (Il2CppClass<System.Convert>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num5 = (nint)typeof(Convert);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v36 (Il2CppClass<System.Convert>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			double value = Math.Floor(d);
			uint value2 = Convert.ToUInt32(value);
			char value3 = Convert.ToChar(value2);
			StringBuilder stringBuilder2 = stringBuilder.Append((int)value3);
			object obj5 = obj + 1;
			obj = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		int result = default;
		return result;
	}

	public static void CheckIfWeShouldRemoveProgressForDailyQuestInRow()
	{
		//IL_000f: Expected I8, but got I4
		CrcCalculatorStream.UnsetLengthLimit = -99L;
	}

	public static bool IsActiveDailyLetterEvent()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0134: Expected I, but got Obj
		//IL_014a: Expected Obj, but got I
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_00a6: Expected I, but got Obj
		//IL_00bc: Expected Obj, but got I
		//IL_019f: Expected Obj, but got I4
		//IL_01bd: Expected Obj, but got I
		//IL_01cb: Expected Obj, but got I4
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected Obj, but got Unknown
		//IL_00e7: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		nint num = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v42 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 4;
		bool flag;
		if (EventsSave.wordHuntPayedOut)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v16 (System.Boolean)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			return false;
		}
		nint num3 = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v33 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool wordHuntPayedOut = EventsSave.wordHuntPayedOut;
		int wordHuntWordsInRow = EventsSave.wordHuntWordsInRow;
		obj2 = wordHuntWordsInRow;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v25 (System.Boolean)+8]");
		object obj6 = (nint)0 & (nint)0x1F;
		object obj7 = 1 << (int)obj6;
		object obj8 = obj7 - 1;
		obj = obj4;
		return obj8 == obj;
	}

	public static bool HasTimeLeft()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(WordHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = IsDailyWordComplete();
		object obj2 = (flag ? 1 : 0) & 0xFFFF;
		return obj2 != null;
	}

	private string GetDailyWordOffline()
	{
		//IL_0239: Expected Obj, but got I4
		//IL_0247: Expected I, but got Obj
		//IL_025d: Expected Obj, but got I
		//IL_0344: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0095: Expected I, but got Obj
		//IL_00ab: Expected Obj, but got I
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected Obj, but got Unknown
		//IL_0082: Expected Obj, but got I4
		//IL_032e: Expected Obj, but got I4
		//IL_00d6: Expected I, but got Obj
		//IL_0288: Expected I, but got Obj
		//IL_029e: Expected Obj, but got I
		//IL_036d: Expected Obj, but got I4
		//IL_01d4: Expected Obj, but got I4
		//IL_01ec: Expected I, but got Obj
		//IL_014b: Expected I, but got Obj
		//IL_0161: Expected Obj, but got I
		//IL_018c: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v65 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TimeSpan wordHuntTimeLeft = EventsSave.wordHuntTimeLeft;
		obj = wordHuntTimeLeft;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCC2");
		bool willShowSMBAfterDailyChallenge = EventsSave.willShowSMBAfterDailyChallenge;
		object obj3 = default;
		WordHuntManager wordHuntManager;
		if ((willShowSMBAfterDailyChallenge ? 1 : 0) == (nint)obj3)
		{
			wordHuntManager = (WordHuntManager)1;
			goto IL_027a;
		}
		nint num3 = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v34 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v60 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool willShowSMBAfterDailyChallenge2 = EventsSave.willShowSMBAfterDailyChallenge;
		object obj5 = obj3 - 1;
		if ((willShowSMBAfterDailyChallenge2 ? 1 : 0) != (nint)obj5)
		{
			if ((nint)obj3 == 1)
			{
				nint num5 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v49 (Il2CppClass<Data.Save.EventsSave>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num6 = (nint)typeof(EventsSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v56 (Il2CppClass<Data.Save.EventsSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool willShowSMBAfterDailyChallenge3 = EventsSave.willShowSMBAfterDailyChallenge;
				if ((willShowSMBAfterDailyChallenge3 ? 1 : 0) >= 365)
				{
					goto IL_0325;
				}
			}
			wordHuntManager = (WordHuntManager)0;
			return null;
		}
		goto IL_0325;
		IL_027a:
		nint num7 = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v22 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num8 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v28 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int wordHuntLastPayoutDayOfYear = EventsSave.wordHuntLastPayoutDayOfYear;
		return (string)wordHuntLastPayoutDayOfYear;
		IL_0325:
		wordHuntManager = (WordHuntManager)0;
		goto IL_027a;
	}

	private unsafe int GetRemainingSeconds()
	{
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_0139: Expected Obj, but got I4
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_0150: Expected Obj, but got I4
		//IL_0168: Expected I, but got Obj
		//IL_017e: Expected Obj, but got I
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_01ba: Expected Obj, but got I8
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected VT, but got Unknown
		//IL_01dd: Expected I8, but got Obj
		//IL_01d8: Expected native int or pointer, but got VT
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_0200: Expected Ref, but got VT
		//IL_020c: Expected Obj, but got I8
		//IL_0013: Expected I, but got Obj
		//IL_005b: Expected F8, but got I4
		//IL_0098: Expected F8, but got I4
		//IL_00d5: Expected F8, but got I4
		//IL_0289: Expected I4, but got Obj
		//IL_010f: Expected I4, but got F8
		object obj2 = default;
		object obj = obj2 + 24;
		obj = 0;
		object obj3 = obj2 + 16;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC83");
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14 (Il2CppClass<System.DateTime>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v46 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
		object obj5 = obj2 + 8;
		obj5 = systemTimeAsFileTime;
		obj2 = obj;
		DateTime dateTime = (DateTime)(obj2 + 32);
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj5;
		IFormatProvider formatProvider = (IFormatProvider)(obj2 + 40);
		formatProvider = (IFormatProvider)obj2;
		long num3 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		obj3 = num3;
		double num4 = (double)obj3 * 1.1574074074074074E-12;
		if (num4 != num4)
		{
			num4 = -2147483648.0;
		}
		else if (!(num4 < 2147483648.0))
		{
			num4 = -2147483648.0;
		}
		else if (!(num4 > -2147483649.0))
		{
			num4 = -2147483648.0;
		}
		List<string> wordHuntWords = _wordHuntWords;
		int index;
		if (wordHuntWords._size != 0)
		{
			double num5 = num4 / (double)wordHuntWords._size;
			double num6 = num5 * (double)wordHuntWords._size;
			index = (int)(num4 - num6);
		}
		else
		{
			index = 0;
		}
		return (int)_wordHuntWords.get_Item(index);
	}

	private void LoadFromOfflineData()
	{
		//IL_0ad3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad8: Expected Obj, but got Unknown
		//IL_0ae1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae6: Expected Obj, but got Unknown
		//IL_0aef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af4: Expected Obj, but got Unknown
		//IL_0afd: Expected Obj, but got I4
		//IL_0b06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0b: Expected Obj, but got Unknown
		//IL_0b14: Expected Obj, but got I4
		//IL_0b1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b22: Expected Obj, but got Unknown
		//IL_0b2b: Expected Obj, but got I4
		//IL_0b34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b39: Expected Obj, but got Unknown
		//IL_0b42: Expected Obj, but got I4
		//IL_0b51: Expected Obj, but got I4
		//IL_0c16: Expected I, but got Obj
		//IL_0c2c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_02b0: Expected I, but got Obj
		//IL_02c6: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0c9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca0: Expected Obj, but got Unknown
		//IL_0ca9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cae: Expected Obj, but got Unknown
		//IL_0b6c: Expected Obj, but got I4
		//IL_0b79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7e: Expected Obj, but got Unknown
		//IL_0b84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b89: Expected Obj, but got Unknown
		//IL_02f1: Expected I, but got Obj
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		//IL_033e: Expected I, but got Obj
		//IL_0354: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0ce3: Invalid comparison between VT and I4
		//IL_0bc1: Expected Obj, but got I4
		//IL_0bca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcf: Expected Obj, but got Unknown
		//IL_0bdd: Expected Obj, but got I4
		//IL_037f: Expected I, but got Obj
		//IL_0194: Expected I, but got Obj
		//IL_01aa: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_03cc: Expected I, but got Obj
		//IL_03e2: Expected Obj, but got I
		//IL_0c5a: Expected Obj, but got I4
		//IL_0d1d: Expected I, but got Obj
		//IL_0d33: Expected Obj, but got I
		//IL_0222: Expected I, but got Obj
		//IL_0238: Expected Obj, but got I
		//IL_01d5: Expected I, but got Obj
		//IL_0d59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5e: Expected I4, but got Unknown
		//IL_0d78: Expected Obj, but got VT
		//IL_040d: Expected I, but got Obj
		//IL_045a: Expected I, but got Obj
		//IL_0263: Expected I, but got Obj
		//IL_04f0: Expected Obj, but got I4
		//IL_04f0: Expected Obj, but got I4
		//IL_04f0: Expected Obj, but got I4
		//IL_0516: Expected Obj, but got I4
		//IL_0516: Expected Obj, but got I4
		//IL_0516: Expected Obj, but got I4
		//IL_0529: Expected I, but got Obj
		//IL_053f: Expected Obj, but got I
		//IL_0d9e: Expected I, but got Obj
		//IL_0db4: Expected Obj, but got I
		//IL_0ddf: Expected Obj, but got I4
		//IL_056a: Expected I, but got Obj
		//IL_05b7: Expected I, but got Obj
		//IL_0e3b: Expected I, but got Obj
		//IL_0e51: Expected Obj, but got I
		//IL_0ffc: Expected VT, but got I4
		//IL_1013: Expected I, but got Obj
		//IL_1029: Expected Obj, but got I
		//IL_08af: Expected I, but got Obj
		//IL_08c5: Expected Obj, but got I
		//IL_06be: Expected I, but got Obj
		//IL_06d4: Expected Obj, but got I
		//IL_0a3e: Expected I, but got Obj
		//IL_0f81: Expected Obj, but got I4
		//IL_0a8b: Expected I, but got Obj
		//IL_0954: Expected Obj, but got I4
		//IL_08f0: Expected I, but got Obj
		//IL_0ea0: Expected VT, but got I4
		//IL_0ea0: Expected Obj, but got I4
		//IL_0eb2: Expected I, but got Obj
		//IL_0ec8: Expected Obj, but got I
		//IL_06ff: Expected I, but got Obj
		//IL_0967: Expected I, but got Obj
		//IL_097d: Expected Obj, but got I
		//IL_0f3a: Expected Obj, but got I4
		//IL_079e: Expected I, but got Obj
		//IL_07b4: Expected Obj, but got I
		//IL_0751: Expected I, but got Obj
		//IL_09a8: Expected I, but got Obj
		//IL_09fd: Expected Obj, but got I
		//IL_0a0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a13: Expected Obj, but got Unknown
		//IL_0a1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a21: Expected Obj, but got Unknown
		//IL_07df: Expected I, but got Obj
		object obj = default;
		string text = (string)(obj + 56);
		object obj2 = obj + 32;
		object obj3 = obj + 52;
		obj3 = 0;
		object obj4 = obj + 48;
		obj4 = 0;
		WordHuntManager wordHuntManager = (WordHuntManager)(obj + 68);
		wordHuntManager = (WordHuntManager)0;
		object obj5 = obj + 36;
		obj5 = 0;
		_ = 0;
		obj = 0;
		char[] array2 = default;
		char[] array4 = default;
		while (true)
		{
			nint num = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v24 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v278 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool wordHuntPayedOut = EventsSave.wordHuntPayedOut;
			char[] array = array2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v18 (System.Boolean)+8]");
			if ((nint)array >= 0)
			{
				break;
			}
			nint num3 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v220 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num4 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v274 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool wordHuntPayedOut2 = EventsSave.wordHuntPayedOut;
			string[] array3 = ((string)wordHuntPayedOut2).Split(array2);
			object obj8 = array3 & 0xFFFF;
			object obj9 = this & 0xFFFF;
			if (obj8 == obj9)
			{
				nint num5 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v233 (Il2CppClass<Data.Save.EventsSave>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num6 = (nint)typeof(EventsSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v270 (Il2CppClass<Data.Save.EventsSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int wordHuntWordsInRow = EventsSave.wordHuntWordsInRow;
				obj3 = wordHuntWordsInRow;
				object obj11 = array2 & 0x1F;
				object obj12 = 1 << (int)obj11;
				object obj13 = obj3 & obj12;
				if (obj13 == null)
				{
					nint num7 = (nint)typeof(EventsSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v243 (Il2CppClass<Data.Save.EventsSave>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num8 = (nint)typeof(EventsSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S0_v266 (Il2CppClass<Data.Save.EventsSave>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int wordHuntWordsInRow2 = EventsSave.wordHuntWordsInRow;
					obj4 = wordHuntWordsInRow2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8A8C");
					obj2 = obj4;
					text = (string)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9211");
					nint num9 = (nint)typeof(WordHuntManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S0_v253 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
					object obj15 = (nint)0 & (nint)0x200;
					if (obj15 != null)
					{
						nint num10 = (nint)typeof(WordHuntManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S0_v260 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					TransformExtensions.Reset((Transform)(object)WordHuntManager.m_OnPickedUpLetter);
					break;
				}
			}
			array2 = (char[])(array4 + 1);
		}
		nint num11 = (nint)typeof(WordHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v32 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num12 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v215 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj17 = obj + 20;
		object obj18 = obj + 8;
		if (!IsActiveDailyLetterEvent())
		{
			return;
		}
		nint num13 = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v45 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num14 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v211 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IntMask wordHuntUnlockedMask = EventsSave.wordHuntUnlockedMask;
		if (wordHuntUnlockedMask != (IntMask)(object)0)
		{
			return;
		}
		nint num15 = (nint)typeof(WordHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v53 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num16 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S0_v207 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string dailyWordOffline = wordHuntManager.GetDailyWordOffline();
		nint num17 = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S1_v29 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num18 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S1_v123 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int wordHuntLastPayoutDayOfYear = (int)(dailyWordOffline + 1);
		EventsSave.wordHuntLastPayoutDayOfYear = wordHuntLastPayoutDayOfYear;
		TimeSpan wordHuntTimeLeft = EventsSave.wordHuntTimeLeft;
		obj = wordHuntTimeLeft;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCC2");
		bool willShowSMBAfterDailyChallenge = default;
		EventsSave.willShowSMBAfterDailyChallenge = willShowSMBAfterDailyChallenge;
		if (WordHuntManager.m_OnDailyWordInRowChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)19, (PersistentAwardProgress)1, (Action<Award>)(-1));
		StayInOneLaneMission stayInOneLaneMission2 = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission2)._002Ector((AwardStaticData)62, (PersistentAwardProgress)1, (Action<Award>)(-1));
		nint num19 = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ S0_v73 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj22 = (nint)0 & (nint)0x200;
		if (obj22 != null)
		{
			nint num20 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S0_v202 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int wordHuntLastPayoutDayOfYear2 = EventsSave.wordHuntLastPayoutDayOfYear;
		nint num21 = (nint)typeof(WordHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S0_v80 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num22 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ S0_v198 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object context = (UnityEngine.Object)(wordHuntLastPayoutDayOfYear2 - 1);
		LogError(text, context);
		obj5 = text;
		_ = text.m_stringLength;
		obj17 = text;
		_ = text.m_stringLength;
		if (obj17 != null)
		{
			text = (string)obj5;
			string text2 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19+8]");
			text2.m_stringLength = 0;
			if ((nint)text != 1)
			{
				text = (string)obj5;
				string text3 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19+8]");
				text3.m_stringLength = 0;
				obj17 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				string text4 = default;
				string msg = "Unhandled DailyWordRewardType: " + text4;
				SDebug.LogFormat(msg, null);
			}
			else
			{
				text = (string)obj5;
				string text5 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19+8]");
				text5.m_stringLength = 0;
				nint num23 = (nint)typeof(RewardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ S1_v94 (Il2CppClass<RewardManager>)+BA]");
				object obj24 = (nint)0 & (nint)0x200;
				if (obj24 != null)
				{
					nint num24 = (nint)typeof(RewardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ S1_v109 (Il2CppClass<RewardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (text.m_stringLength != 0)
				{
				}
				Vector3 vector = ((SSEventsPopup)7).VerifySettingOnline((string)null, (Vector3)0);
				nint num25 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ S0_v167 (Il2CppClass<UIScreenController>)+BA]");
				object obj25 = (nint)0 & (nint)0x200;
				if (obj25 != null)
				{
					nint num26 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ S0_v183 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = UIScreenController.ShouldShowOnlineScreen();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				string text6 = default;
				text6.m_stringLength = 4;
				text = (string)obj5;
				string text7 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19+8]");
				text7.m_stringLength = 0;
				_ = text.m_stringLength;
				((UIScreenController)flag)._QueueMessage(text6);
				nint num27 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ S0_v174 (Il2CppClass<Data.Save.EventsSave>)+BA]");
				object obj26 = (nint)0 & (nint)0x200;
				if (obj26 != null)
				{
					nint num28 = (nint)typeof(EventsSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ S0_v179 (Il2CppClass<Data.Save.EventsSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7E9E");
			}
		}
		else
		{
			text = (string)obj5;
			string text8 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19+8]");
			text8.m_stringLength = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.String)+4]");
			if ((nint)0 >= (nint)1)
			{
				text = (string)obj5;
				string text9 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19+8]");
				text9.m_stringLength = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.String)+4]");
				InventorySave.IncreaseKeys(0, "WeeklyHunt");
				nint num29 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ S0_v122 (Il2CppClass<UIScreenController>)+BA]");
				object obj27 = (nint)0 & (nint)0x200;
				if (obj27 != null)
				{
					nint num30 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ S0_v152 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag2 = UIScreenController.ShouldShowOnlineScreen();
				obj17 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19+8]");
				_ = 0;
				bool flag3 = flag2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v37+4]");
				((UIScreenController)flag3).OnTokenCollected(Characters.CharacterId.slick);
				bool flag4 = UIScreenController.ShouldShowOnlineScreen();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				string text10 = default;
				text10.m_stringLength = 5;
				((UIScreenController)flag4)._QueueMessage(text10);
				nint num31 = (nint)typeof(WordHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ S0_v131 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
				object obj28 = (nint)0 & (nint)0x200;
				if (obj28 != null)
				{
					nint num32 = (nint)typeof(WordHuntManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ S0_v146 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj18 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19+8]");
				_ = 0;
				if (WordHuntManager.m_OnDailyLetterCoinsRewarded != null)
				{
					nint num33 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ S2_v18 (Il2CppMethodInfo)+18]");
					object obj29 = 0;
					object obj30 = obj29;
					object obj31 = obj30 & 0x3FFF;
					object obj32 = obj31 + 97173;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v458 @ S3_v10 (should have been resolved before IL gen)");
				}
			}
		}
		nint num34 = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ S0_v93 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj33 = (nint)0 & (nint)0x200;
		if (obj33 != null)
		{
			nint num35 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ S0_v108 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventsSave.wordHuntUnlockedMask = (IntMask)1;
		bool wordHuntPayedOut3 = EventsSave.wordHuntPayedOut;
		nint num36 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ S0_v101 (Il2CppClass<Flurry>)+BA]");
		object obj34 = (nint)0 & (nint)0x200;
		if (obj34 != null)
		{
			nint num37 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ S0_v104 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	static WordHuntManager()
	{
		//IL_0078: Expected Obj, but got I4
		//IL_0086: Expected I, but got Obj
		//IL_009c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		WordHuntManager wordHuntManager = (WordHuntManager)0;
		nint num = (nint)typeof(WordHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v22 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string dailyWordOffline = wordHuntManager.GetDailyWordOffline();
		object obj2 = (object)dailyWordOffline | (object)wordHuntManager;
		if (obj2 == null)
		{
			StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
			((MissionsManager)(object)stayInOneLaneMission).ResetProgressForMissionIndex(62);
		}
	}
}

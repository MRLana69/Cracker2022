using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Kiloo;
using UnityEngine;

public class DailyWord : MonoBehaviour
{
	private enum DailyWordServerData
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

	public enum DailyWordRewardType
	{
		Coins,
		MysteryBox
	}

	public struct DailyWordReward
	{
		public DailyWordRewardType type;

		public int coins;

		public string Word;

		public MysteryBox.Type mysteryBoxType;
	}

	private sealed class _003CDownloadDailyCoroutine_003Ed__15(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public DailyWord _003C_003E4__this;

		private DateTime _003Ctime_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			_ = 0;
			DailyWord dailyWord = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_00f1;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				TimeSpan timeSpan = (_003Ctime_003E5__2 = CDateTime.UtcNow) - dailyWord._lastRequestTime;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				double num = 0.0 * 1E-07;
				if (!(num > 120.0))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					goto IL_00f1;
				}
			}
			dailyWord._lastRequestTime = _003Ctime_003E5__2;
			PlayerInfo instance = PlayerInfo.Instance;
			instance.InitDailyWord(REWARDS);
			goto IL_00f1;
			IL_00f1:
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

	public static readonly DailyWordReward[] REWARDS;

	private bool stoppingFromEditor;

	private DateTime _lastRequestTime = DateTime.MinValue;

	private static DailyWord _instance;

	public static DailyWord Instance
	{
		get
		{
			//IL_0014: Expected VT, but got Obj
			bool flag = (object)_instance == null;
			bool flag2 = !flag;
			DailyWord result = _instance;
			if (!flag2)
			{
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(DailyWord));
				UnityEngine.Object obj = UnityEngine.Object.FindObjectOfType(typeFromHandle);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				DailyWord dailyWord = default;
				_instance = dailyWord;
				result = dailyWord;
			}
			return result;
		}
	}

	private void Start()
	{
		DownloadDaily();
		UIScreenController instance = UIScreenController.Instance;
		throw new ArgumentException();
	}

	private void OnApplicationQuit()
	{
		stoppingFromEditor = true;
	}

	private void OnDestroy()
	{
		if (~(stoppingFromEditor ? 1u : 0u) != 0)
		{
			UIScreenController instance = UIScreenController.Instance;
			throw new ArgumentException();
		}
	}

	private void AutoSyncer(string screenName)
	{
		if (screenName == "FrontUI" || screenName == "GameoverUI")
		{
			DownloadDailyIfExpired();
		}
	}

	public void DownloadDaily()
	{
		IEnumerator routine = DownloadDailyCoroutine();
		Coroutine coroutine = StartCoroutine(routine);
	}

	public void DownloadDailyIfExpired()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		PlayerInfo instance = PlayerInfo.Instance;
		TimeSpan dailyWordTimeLeft = instance.dailyWordTimeLeft;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		double num = 0.0 * 1E-07;
		if (!(num > 0.0))
		{
			IEnumerator routine = DownloadDailyCoroutine();
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	private IEnumerator DownloadDailyCoroutine()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void CalculateAndSaveLastKnownServerTime(string year, string month, string day, string hour, string minute, string second)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Expected Obj, but got Unknown
		//IL_03b9: Expected Obj, but got I
		//IL_03e4: Expected Obj, but got I
		//IL_0409: Expected Obj, but got I
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected Obj, but got Unknown
		//IL_0149: Expected Obj, but got I4
		//IL_047a: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								obj = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5BA");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												return;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										}
										goto IL_02b9;
									}
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
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		goto IL_02b9;
		IL_02b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj4 = default;
		object obj5 = default;
		bool flag = obj4 != obj5;
		object obj7 = default;
		object obj6 = obj7;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj9 = default;
				object obj8 = obj9;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj10 = default;
					if (obj10 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj11 = (nint)0 << 2;
						object obj12 = obj3 + obj11;
						obj12 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj13 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj14 = (nint)0 << 2;
						object obj15 = obj14 + obj3;
						object obj16 = obj15 - 4;
						object obj17 = obj16;
						object obj18 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v360 @ S1_v45+E4] (should have been resolved before IL gen)");
						string text2 = default;
						string text = "DailyWord.CalculateAndSaveLastKnownServerTime: Was not able to parse the date received from the server. Exception: " + text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj19 = -1;
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj20 = obj9;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag2 = (nint)0 != 1;
					obj6 = obj9;
					if (flag2)
					{
						goto IL_05d4;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag3 = (nint)0 != 1;
			object obj21 = default;
			obj6 = obj21;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				obj6 = obj21;
			}
		}
		goto IL_05d4;
		IL_05d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
	}

	private bool SHA1HashCheck(string[] rawData, string key)
	{
		if (rawData.Length >= 10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
		return false;
	}

	private static string RandomString(int size)
	{
		//IL_0017: Expected Obj, but got I4
		//IL_00c6: Expected I, but got Obj
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		System.Random random = default;
		random._002Ector();
		object obj = 0;
		object obj3 = default;
		while (size > (nint)obj)
		{
			object obj2 = random - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v50 @ S1_v11+BC] (should have been resolved before IL gen)");
			double num = (double)obj3 * 26.0;
			double d = num + 65.0;
			double value = Math.Floor(d);
			int value2 = Convert.ToInt32(value);
			char value3 = Convert.ToChar(value2);
			StringBuilder stringBuilder2 = stringBuilder.Append(value3);
			object obj4 = obj + 1;
			obj = obj4;
		}
		nint num2 = (nint)stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v59 @ S1_v7 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	private static int RandomNumber(int min, int max)
	{
		//IL_0016: Expected I, but got Obj
		System.Random random = default;
		random._002Ector();
		nint num = (nint)random;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v21 @ S3_v2 (Il2CppClass<System.Random>)+EC] (should have been resolved before IL gen)");
		int result = default;
		return result;
	}

	private static string GenerateKey()
	{
		//IL_007e: Expected I, but got Obj
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		string value = RandomString(4);
		StringBuilder stringBuilder2 = stringBuilder.Append(value);
		int value2 = RandomNumber(0, 999);
		StringBuilder stringBuilder3 = stringBuilder.Append(value2);
		string value3 = RandomString(2);
		StringBuilder stringBuilder4 = stringBuilder.Append(value3);
		nint num = (nint)stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v39 @ S1_v10 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	public unsafe static DailyWordReward GetRewardForDay(int dayIndex)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_003b: Expected Obj, but got I
		//IL_0036: Expected native int or pointer, but got VT
		//IL_004b: Expected native int or pointer, but got VT
		int num2 = default;
		int num = num2 << 4;
		object obj = REWARDS + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v12+18]");
		DailyWordReward dailyWordReward = default;
		System.Runtime.CompilerServices.Unsafe.Write(&((DailyWordReward*)(nint)dailyWordReward)->Word, (string)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v12+10]");
		((DailyWordReward*)(nint)dailyWordReward)->type = DailyWordRewardType.Coins;
		return dailyWordReward;
	}

	public static void LogError(string msg, UnityEngine.Object context = null)
	{
	}

	public static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	public static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	static DailyWord()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected Obj, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_015d: Expected Obj, but got I
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 96;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj3 = obj + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = 0;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
		_ = 0;
		object obj4 = obj - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v17+8]");
		_ = 0;
		object obj5 = obj + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = 0;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
		_ = 0;
		object obj6 = obj + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = 4509715660800L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		_ = 0;
		object obj7 = obj + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = 6442450944000L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj8 = obj + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = 1;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
		obj = 0;
		DailyWordReward[] array = default;
		object obj9 = array - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		REWARDS = array;
	}
}

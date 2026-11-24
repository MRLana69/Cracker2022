using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Kiloo;
using Kiloo.Common;
using Kiloo.Common.HTTP;

namespace TopRun.Internal;

internal class Tournament : ITournament
{
	[StructLayout((LayoutKind)0, Size = 8)]
	private struct Rank
	{
		public int numberOfPlayers;

		public int bestScore;
	}

	[StructLayout((LayoutKind)0, Size = 8)]
	private struct Participant
	{
		public string publicKey;

		public int highScore;
	}

	private sealed class _003CGetPlayers_003Ed__43(int _003C_003E1__state) : IEnumerable<IPlayer>, IEnumerable, IEnumerator<IPlayer>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private IPlayer _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public Tournament _003C_003E4__this;

		private Participant[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		IPlayer IEnumerator<IPlayer>.Current
		{
			get
			{
				//IL_0224: Unknown result type (might be due to invalid IL or missing references)
				//IL_0229: Expected Obj, but got Unknown
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_0060: Expected Obj, but got I4
				//IL_0079: Expected Obj, but got I4
				//IL_00af: Expected Obj, but got I4
				//IL_0087: Expected Obj, but got I4
				//IL_0147: Unknown result type (might be due to invalid IL or missing references)
				//IL_014c: Expected Obj, but got Unknown
				//IL_0164: Unknown result type (might be due to invalid IL or missing references)
				//IL_0169: Expected Obj, but got Unknown
				//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c4: Expected Obj, but got Unknown
				//IL_01e0: Expected Obj, but got I4
				//IL_01e9: Expected Obj, but got I4
				//IL_011b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0120: Expected Obj, but got Unknown
				//IL_0129: Expected Obj, but got I4
				//IL_0137: Expected Obj, but got I4
				//IL_01b4: Expected Obj, but got I4
				object obj2 = default;
				object obj = obj2 + 8;
				Tournament tournament = _003C_003E4__this;
				object obj3;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						obj3 = 8;
					}
					else
					{
						obj3 = 11;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					object obj4 = this + 24;
					obj4 = tournament._participants;
					_003C_003E7__wrap2 = 0;
					obj3 = 9;
				}
				object obj5 = obj3;
				IPlayer result = default;
				object obj9 = default;
				while (true)
				{
					if ((nint)obj5 == 8)
					{
						int num = _003C_003E7__wrap2 + 1;
						_003C_003E7__wrap2 = num;
						obj5 = 9;
					}
					else if ((nint)obj5 == 9)
					{
						Participant[] array = _003C_003E7__wrap1;
						if (_003C_003E7__wrap2 >= array.Length)
						{
							object obj6 = this + 24;
							obj6 = 0;
							result = null;
							obj5 = 11;
							continue;
						}
						object obj7 = _003C_003E7__wrap1 + 16;
						int num2 = _003C_003E7__wrap2 << 3;
						object obj8 = obj7 + num2;
						obj = obj8;
						obj2 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
						if (obj9 == null)
						{
							obj5 = 8;
							continue;
						}
						object obj10 = this + 12;
						obj10 = obj9;
						_003C_003E1__state = 1;
						result = (IPlayer)1;
						obj5 = 11;
					}
					else if ((nint)obj5 == 11)
					{
						break;
					}
				}
				return result;
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

		IEnumerator<IPlayer> IEnumerable<IPlayer>.GetEnumerator()
		{
			return (IEnumerator<IPlayer>)_003C_003E2__current;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected Obj, but got Unknown
			if (_003C_003E1__state == -2)
			{
				bool hasShutdownStarted = Environment.HasShutdownStarted;
				if (_003C_003El__initialThreadId == (hasShutdownStarted ? 1 : 0))
				{
					_003C_003E1__state = 0;
					goto IL_0097;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8589");
			_003CGetPlayers_003Ed__43 obj2 = default;
			object obj = obj2 + 20;
			obj = _003C_003E4__this;
			goto IL_0097;
			IL_0097:
			return obj2;
		}
	}

	private sealed class _003CGetPlayersForRank_003Ed__44 : IEnumerable<IPlayer>, IEnumerable, IEnumerator<IPlayer>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private IPlayer _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private int rank;

		public int _003C_003E3__rank;

		public Tournament _003C_003E4__this;

		private int _003Clowest_003E5__2;

		private int _003Chighest_003E5__3;

		private Participant[] _003C_003E7__wrap3;

		private int _003C_003E7__wrap4;

		IPlayer IEnumerator<IPlayer>.Current
		{
			get
			{
				//IL_0325: Unknown result type (might be due to invalid IL or missing references)
				//IL_032a: Expected Obj, but got Unknown
				//IL_0051: Expected Obj, but got I4
				//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00aa: Expected Obj, but got Unknown
				//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b8: Expected Obj, but got Unknown
				//IL_036b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0370: Expected Obj, but got Unknown
				//IL_0388: Unknown result type (might be due to invalid IL or missing references)
				//IL_038d: Expected Obj, but got Unknown
				//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_03aa: Expected Obj, but got Unknown
				//IL_03cc: Expected Obj, but got I4
				//IL_00e7: Expected Obj, but got I4
				//IL_00f5: Expected Obj, but got I4
				//IL_011d: Expected Obj, but got I4
				//IL_0411: Unknown result type (might be due to invalid IL or missing references)
				//IL_0416: Expected Obj, but got Unknown
				//IL_041f: Expected Obj, but got I4
				//IL_042d: Expected Obj, but got I4
				//IL_0193: Unknown result type (might be due to invalid IL or missing references)
				//IL_0198: Expected Obj, but got Unknown
				//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b5: Expected Obj, but got Unknown
				//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b8: Expected Obj, but got Unknown
				//IL_02d4: Expected Obj, but got I4
				//IL_02dd: Expected Obj, but got I4
				//IL_02ea: Expected I4, but got Obj
				//IL_021e: Expected Obj, but got I4
				//IL_029b: Expected Obj, but got I4
				//IL_02a8: Expected I4, but got Obj
				object obj2 = default;
				object obj = obj2 + 8;
				Tournament tournament = _003C_003E4__this;
				object obj3;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						obj3 = 13;
					}
					else
					{
						obj3 = 16;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					Rank[] ranks = tournament._ranks;
					object obj4 = ranks.Length - 1;
					int num;
					if (rank == (nint)obj4)
					{
						num = 0;
					}
					else
					{
						int num2 = rank << 3;
						object obj5 = tournament._ranks + num2;
						object obj6 = obj5 + 24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v55+4]");
						num = (int)((nint)0 + (nint)1);
					}
					_003Clowest_003E5__2 = num;
					object obj7 = tournament._ranks + 16;
					int num3 = rank << 3;
					object obj8 = obj7 + num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v46+4]");
					_003Chighest_003E5__3 = 0;
					object obj9 = this + 40;
					obj9 = tournament._participants;
					_003C_003E7__wrap4 = 0;
					obj3 = 14;
				}
				object obj10 = obj3;
				object obj13 = default;
				IPlayer result = default;
				while (true)
				{
					if ((nint)obj10 == 13)
					{
						int num4 = _003C_003E7__wrap4 + 1;
						_003C_003E7__wrap4 = num4;
						obj10 = 14;
						int num3 = 1;
						continue;
					}
					if ((nint)obj10 == 14)
					{
						Participant[] array = _003C_003E7__wrap3;
						if (_003C_003E7__wrap4 < array.Length)
						{
							object obj11 = _003C_003E7__wrap3 + 16;
							int num3 = _003C_003E7__wrap4 << 3;
							object obj12 = obj11 + num3;
							obj = obj12;
							obj2 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
							if ((nint)0 > (nint)_003Chighest_003E5__3)
							{
								if (rank != 0)
								{
									obj10 = 13;
									continue;
								}
							}
							else
							{
								obj = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
								if ((nint)0 < (nint)_003Clowest_003E5__2)
								{
									goto IL_040b;
								}
							}
							obj = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
							if (obj13 == null)
							{
								obj10 = 13;
								num3 = (int)tournament._tournamentPlayerManager;
								continue;
							}
							object obj14 = this + 12;
							obj14 = obj13;
							_003C_003E1__state = 1;
							result = (IPlayer)1;
							obj10 = 16;
							num3 = (int)tournament._tournamentPlayerManager;
							continue;
						}
						goto IL_040b;
					}
					if ((nint)obj10 == 16)
					{
						break;
					}
					continue;
					IL_040b:
					object obj15 = this + 40;
					obj15 = 0;
					result = null;
					obj10 = 16;
				}
				return result;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CGetPlayersForRank_003Ed__44(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			bool hasShutdownStarted = Environment.HasShutdownStarted;
			_003C_003El__initialThreadId = (hasShutdownStarted ? 1 : 0);
		}

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_000a: Expected I4, but got Obj
			return (byte)(int)((IEnumerable)this).GetEnumerator() != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}

		IEnumerator<IPlayer> IEnumerable<IPlayer>.GetEnumerator()
		{
			return (IEnumerator<IPlayer>)_003C_003E2__current;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected Obj, but got Unknown
			_003CGetPlayersForRank_003Ed__44 obj;
			if (_003C_003E1__state == -2)
			{
				bool hasShutdownStarted = Environment.HasShutdownStarted;
				if (_003C_003El__initialThreadId == (hasShutdownStarted ? 1 : 0))
				{
					_003C_003E1__state = 0;
					obj = this;
					goto IL_00a8;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_003CGetPlayersForRank_003Ed__44 obj2 = default;
			obj2._002Ector(0);
			object obj3 = obj2 + 28;
			obj3 = _003C_003E4__this;
			obj = obj2;
			goto IL_00a8;
			IL_00a8:
			obj.rank = _003C_003E3__rank;
			return obj;
		}
	}

	private readonly ITournamentPlayerManager _tournamentPlayerManager;

	private readonly int _totalNumberOfPlayers;

	private readonly Rank[] _ranks;

	private readonly Participant[] _participants;

	private string id__BackingField;

	private int sequenceId__BackingField;

	private bool hasResult__BackingField;

	private string country__BackingField;

	private DateTime startTimeUTC__BackingField;

	private DateTime endTimeUTC__BackingField;

	public string id
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (string)_totalNumberOfPlayers;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 12;
			obj = value;
		}
	}

	public int sequenceId
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)id__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 24;
			obj = value;
		}
	}

	public bool isFinished => (byte)sequenceId__BackingField != 0;

	public bool hasResult
	{
		get
		{
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected Obj, but got Unknown
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected Obj, but got Unknown
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Expected Obj, but got Unknown
			//IL_002a: Expected I, but got Obj
			//IL_0040: Expected Obj, but got I
			//IL_00fa: Expected Obj, but got VT
			//IL_0104: Expected Obj, but got VT
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Expected Obj, but got Unknown
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Expected Obj, but got Unknown
			//IL_006b: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 24;
			object obj3 = obj2 + 16;
			object obj4 = obj2 + 8;
			if (~(hasResult__BackingField ? 1u : 0u) == 0)
			{
				return true;
			}
			DateTime today = CDateTime.Today;
			nint num = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v22 (Il2CppClass<System.DateTime>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v34 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj4 = today;
			obj2 = endTimeUTC__BackingField;
			obj3 = obj4;
			obj = obj2;
			object obj6 = obj3 & 0x3FFFFFFFFFFFFFFFL;
			object obj7 = obj & 0x3FFFFFFFFFFFFFFFL;
			return System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
		}
		private set
		{
			sequenceId__BackingField = (value ? 1 : 0);
		}
	}

	public string country
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool flag = hasResult__BackingField;
			return (string)flag;
		}
		private set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected I4, but got Unknown
			bool flag = (byte)(value & 1) != 0;
			hasResult__BackingField = flag;
		}
	}

	public unsafe DateTime startTimeUTC
	{
		get
		{
			//IL_0209: Unknown result type (might be due to invalid IL or missing references)
			//IL_020e: Expected Obj, but got Unknown
			//IL_0217: Unknown result type (might be due to invalid IL or missing references)
			//IL_021c: Expected VT, but got Unknown
			//IL_0225: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Expected Obj, but got Unknown
			//IL_0233: Unknown result type (might be due to invalid IL or missing references)
			//IL_0238: Expected Obj, but got Unknown
			//IL_0241: Unknown result type (might be due to invalid IL or missing references)
			//IL_0246: Expected Obj, but got Unknown
			//IL_024f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0254: Expected Obj, but got Unknown
			//IL_0180: Expected I, but got Obj
			//IL_0196: Expected Obj, but got I
			//IL_001d: Expected VT, but got Obj
			//IL_01c1: Expected I, but got Obj
			//IL_005b: Expected I, but got Obj
			//IL_0071: Expected Obj, but got I
			//IL_0284: Expected Obj, but got VT
			//IL_02a7: Expected Obj, but got VT
			//IL_02b4: Expected I8, but got Obj
			//IL_02af: Expected native int or pointer, but got VT
			//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e5: Expected Obj, but got Unknown
			//IL_009c: Expected I, but got Obj
			//IL_00f2: Expected I, but got Obj
			//IL_0108: Expected Obj, but got I
			//IL_0309: Expected Obj, but got VT
			//IL_031e: Expected I8, but got Obj
			//IL_0319: Expected native int or pointer, but got VT
			//IL_0333: Expected Ref, but got VT
			//IL_033f: Expected VT, but got I8
			//IL_0133: Expected I, but got Obj
			object obj = default;
			IFormatProvider formatProvider = (IFormatProvider)(obj + 48);
			DateTime dateTime = (DateTime)(obj + 40);
			object obj2 = obj + 32;
			object obj3 = obj + 24;
			object obj4 = obj + 16;
			object obj5 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj6 = default;
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				Headers headers2 = default;
				Headers headers = headers2.Add((KeyValuePair<string, string>)"Date");
				if (headers != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					nint num = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v22 (Il2CppClass<System.DateTime>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num2 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v49 (Il2CppClass<System.DateTime>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj2 = DateTime.MinValue;
					formatProvider = (IFormatProvider)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4E5");
					object obj8 = default;
					obj3 = obj8;
					obj4 = DateTime.MinValue;
					((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj3;
					formatProvider = (IFormatProvider)obj4;
					long num3 = (long)(dateTime.dateData & 0x3FFFFFFFFFFFFFFFL);
					object obj9 = formatProvider & 0x3FFFFFFFFFFFFFFFL;
					if (num3 != (long)obj9)
					{
						DateTime today = CDateTime.Today;
						nint num4 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v61 (Il2CppClass<System.DateTime>)+BA]");
						object obj10 = (nint)0 & (nint)0x200;
						if (obj10 != null)
						{
							nint num5 = (nint)typeof(DateTime);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v71 (Il2CppClass<System.DateTime>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj5 = today;
						obj = obj8;
						((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj5;
						formatProvider = (IFormatProvider)obj;
						long num6 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
						return (DateTime)num6;
					}
				}
			}
			nint num7 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v26 (Il2CppClass<System.TimeSpan>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num8 = (nint)typeof(TimeSpan);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v33 (Il2CppClass<System.TimeSpan>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (DateTime)TimeSpan.Zero;
		}
		private set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		}
	}

	public DateTime officialEndTimeUTC => startTimeUTC__BackingField;

	public DateTime endTimeUTC
	{
		get
		{
			return endTimeUTC__BackingField;
		}
		private set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		}
	}

	public DateTime nextTournamentTimeUTC
	{
		get
		{
			return endTimeUTC__BackingField;
		}
		private set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		}
	}

	public int rankCount
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)country__BackingField;
		}
	}

	public Tournament(JsonObject json, TimeSpan clientTimeOffset, string country, ITournamentPlayerManager tournamentPlayerManager)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public int FindParticipantScoreByPublicKey(string publicKey)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		int num = default;
		object obj = num + 16;
		obj = this;
		object obj2 = num + 20;
		obj2 = publicKey;
		return num;
	}

	public int GetRankForScore(int score)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0027: Expected Obj, but got I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0079: Expected Obj, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 8;
		object obj3 = _participants + 12;
		object obj4 = 0;
		while (true)
		{
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
			{
				object obj5 = _participants + 16;
				object obj6 = obj4 << 3;
				object obj7 = obj5 + obj6;
				obj = obj7;
				obj2 = obj;
				if (!((string)obj2 == (string)score))
				{
					break;
				}
				object obj8 = obj4 + 1;
				obj4 = obj8;
				continue;
			}
			return 0;
		}
		obj = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
		return 0;
	}

	public IEnumerable<IPlayer> GetPlayers()
	{
		//IL_0011: Expected Obj, but got I4
		Rank[] ranks = _ranks;
		return (IEnumerable<IPlayer>)ranks.Length;
	}

	public IEnumerable<IPlayer> GetPlayersForRank(int rank)
	{
		//IL_0014: Expected Obj, but got I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		Rank[] ranks = _ranks;
		IEnumerable<IPlayer> enumerable = (IEnumerable<IPlayer>)ranks.Length;
		IEnumerable<IPlayer> result;
		bool flag;
		do
		{
			IEnumerable<IPlayer> enumerable2 = (IEnumerable<IPlayer>)(enumerable - 1);
			if ((nint)enumerable2 < 1)
			{
				result = null;
				break;
			}
			object obj = _ranks + 16;
			object obj2 = (object)enumerable2 << 3;
			object obj3 = obj + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v13+4]");
			flag = (nint)0 <= (nint)rank;
			result = enumerable2;
			enumerable = enumerable2;
		}
		while (flag);
		return result;
	}

	public int GetBestScoreForRank(int rank)
	{
		//IL_0027: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8589");
		int num = default;
		object obj = num + 28;
		obj = this;
		return num;
	}

	public int GetNumberOfPlayersForRank(int rank)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		object obj = _ranks + 16;
		int num = rank << 3;
		object obj2 = obj + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v4+4]");
		return 0;
	}

	public int GetNumberOfPlayersForTournament()
	{
		//IL_0027: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8589");
		int num = default;
		object obj = num + 20;
		obj = this;
		return num;
	}
}

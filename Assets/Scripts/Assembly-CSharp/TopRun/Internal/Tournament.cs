using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo;
using Kiloo.Common;

namespace TopRun.Internal;

internal class Tournament : ITournament
{
	private struct Rank
	{
		public int numberOfPlayers;

		public int bestScore;
	}

	private struct Participant
	{
		public string publicKey;

		public int highScore;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<Participant> _003C_003E9__40_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal int _003C_002Ector_003Eb__40_0(Participant player1, Participant player2)
		{
			return player2.highScore - player1.highScore;
		}
	}

	private sealed class _003CGetPlayers_003Ed__43 : IEnumerable<IPlayer>, IEnumerable, IEnumerator<IPlayer>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private IPlayer _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public Tournament _003C_003E4__this;

		private Participant[] _003Cparticipants_003E5__2;

		private int _003Ci_003E5__3;

		IPlayer IEnumerator<IPlayer>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		public _003CGetPlayers_003Ed__43(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			_003C_003El__initialThreadId = currentManagedThreadId;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0078: Expected Obj, but got I4
			//IL_006a: Expected Obj, but got I4
			//IL_0096: Expected Obj, but got I4
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected Obj, but got Unknown
			//IL_0142: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 - 16;
			Tournament tournament = _003C_003E4__this;
			object obj3;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_0170;
				}
				_003C_003E1__state = -1;
				obj3 = 0;
			}
			else
			{
				_003C_003E1__state = -1;
				_003Cparticipants_003E5__2 = tournament._participants;
				obj3 = 1;
			}
			object obj4 = obj3;
			int num = default;
			IPlayer player = default;
			while (true)
			{
				if (obj4 == null)
				{
					num = _003Ci_003E5__3 + 1;
					obj4 = 1;
					continue;
				}
				_003Ci_003E5__3 = num;
				Participant[] array = _003Cparticipants_003E5__2;
				if (num >= array.Length)
				{
					break;
				}
				int num2 = num << 3;
				object obj5 = array + num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v10+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				if (player != null)
				{
					_003C_003E2__current = player;
					_003C_003E1__state = 1;
					break;
				}
				obj4 = 0;
			}
			goto IL_0170;
			IL_0170:
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

		IEnumerator<IPlayer> IEnumerable<IPlayer>.GetEnumerator()
		{
			if (_003C_003E1__state == -2)
			{
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				if (_003C_003El__initialThreadId == currentManagedThreadId)
				{
					_003C_003E1__state = 0;
					return this;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @40F");
			_ = _003C_003E4__this;
			IEnumerator<IPlayer> result = default;
			return result;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<IPlayer>)this).GetEnumerator();
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

		private Participant[] _003Cparticipants_003E5__4;

		private int _003Ci_003E5__5;

		IPlayer IEnumerator<IPlayer>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		public _003CGetPlayersForRank_003Ed__44(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			_003C_003El__initialThreadId = currentManagedThreadId;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_005f: Expected Obj, but got I4
			//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Expected Obj, but got Unknown
			//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b9: Expected Obj, but got Unknown
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Expected Obj, but got Unknown
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Expected Obj, but got Unknown
			//IL_00f8: Expected Obj, but got I4
			//IL_0106: Expected Obj, but got I4
			//IL_0124: Expected Obj, but got I4
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Expected Obj, but got Unknown
			//IL_024b: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 - 16;
			Tournament tournament = _003C_003E4__this;
			object obj3;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_0279;
				}
				_003C_003E1__state = -1;
				obj3 = 0;
			}
			else
			{
				_003C_003E1__state = -1;
				Rank[] ranks = tournament._ranks;
				object obj4 = ranks.Length - 1;
				int num2;
				if (rank != (nint)obj4)
				{
					int num = rank << 3;
					object obj5 = tournament._ranks + num;
					object obj6 = obj5 + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v41+4]");
					num2 = (int)((nint)0 + (nint)1);
				}
				else
				{
					num2 = 0;
				}
				_003Clowest_003E5__2 = num2;
				int num3 = rank << 3;
				object obj7 = tournament._ranks + num3;
				object obj8 = obj7 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v33+4]");
				_003Chighest_003E5__3 = 0;
				_003Cparticipants_003E5__4 = tournament._participants;
				obj3 = 1;
			}
			object obj9 = obj3;
			int num4 = default;
			IPlayer player = default;
			while (true)
			{
				if (obj9 == null)
				{
					num4 = _003Ci_003E5__5 + 1;
					obj9 = 1;
					continue;
				}
				_003Ci_003E5__5 = num4;
				Participant[] array = _003Cparticipants_003E5__4;
				if (num4 >= array.Length)
				{
					break;
				}
				int num5 = num4 << 3;
				object obj10 = array + num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v10+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				if ((nint)0 > (nint)_003Chighest_003E5__3)
				{
					if (rank != 0)
					{
						goto IL_0242;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
					if ((nint)0 < (nint)_003Clowest_003E5__2)
					{
						break;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				if (player != null)
				{
					_003C_003E2__current = player;
					_003C_003E1__state = 1;
					break;
				}
				goto IL_0242;
				IL_0242:
				obj9 = 0;
			}
			goto IL_0279;
			IL_0279:
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

		IEnumerator<IPlayer> IEnumerable<IPlayer>.GetEnumerator()
		{
			_003CGetPlayersForRank_003Ed__44 obj;
			if (_003C_003E1__state == -2)
			{
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				if (_003C_003El__initialThreadId == currentManagedThreadId)
				{
					_003C_003E1__state = 0;
					obj = this;
					goto IL_0095;
				}
			}
			_003CGetPlayersForRank_003Ed__44 obj2 = default;
			obj2._002Ector(0);
			obj2._003C_003E4__this = _003C_003E4__this;
			obj = obj2;
			goto IL_0095;
			IL_0095:
			obj.rank = _003C_003E3__rank;
			return obj;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<IPlayer>)this).GetEnumerator();
		}
	}

	private readonly ITournamentPlayerManager _tournamentPlayerManager;

	private readonly int _totalNumberOfPlayers;

	private readonly Rank[] _ranks;

	private readonly Participant[] _participants;

	private bool hasResult__BackingField;

	private DateTime endTimeUTC__BackingField;

	public string id
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public int sequenceId
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public bool isFinished
	{
		get
		{
			if (~(hasResult__BackingField ? 1u : 0u) == 0)
			{
				return true;
			}
			DateTime utcNow = CDateTime.UtcNow;
			return utcNow > endTimeUTC__BackingField;
		}
	}

	public bool hasResult
	{
		get
		{
			return hasResult__BackingField;
		}
		private set
		{
			hasResult__BackingField = value;
		}
	}

	public string country
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public DateTime startTimeUTC
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public DateTime officialEndTimeUTC => endTimeUTC__BackingField;

	public DateTime endTimeUTC
	{
		get
		{
			return endTimeUTC__BackingField;
		}
		private set
		{
			endTimeUTC__BackingField = value;
		}
	}

	public DateTime nextTournamentTimeUTC
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public int rankCount
	{
		get
		{
			Rank[] ranks = _ranks;
			return ranks.Length;
		}
	}

	public unsafe Tournament(JsonObject json, TimeSpan clientTimeOffset, string country, ITournamentPlayerManager tournamentPlayerManager)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected VT, but got Unknown
		//IL_002f: Expected Ref, but got VT
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected VT, but got Unknown
		//IL_007e: Expected Ref, but got VT
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected VT, but got Unknown
		//IL_00c8: Expected Ref, but got VT
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected VT, but got Unknown
		//IL_0126: Expected Ref, but got VT
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected Obj, but got Unknown
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected Obj, but got Unknown
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected Obj, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected Obj, but got Unknown
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Expected Obj, but got Unknown
		//IL_07be: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c3: Expected Obj, but got Unknown
		//IL_02f5: Expected Obj, but got I4
		//IL_0320: Expected Obj, but got I4
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected Obj, but got Unknown
		//IL_062f: Expected Obj, but got I
		//IL_063e: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		_ = 0;
		_ = 0;
		this.country__BackingField = country;
		_tournamentPlayerManager = tournamentPlayerManager;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3689");
		string text = default;
		id__BackingField = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3689");
		int num = default;
		sequenceId__BackingField = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4F42");
		DateTime dateTime = (DateTime)(obj + 72);
		DateTime dateTime2 = ((DateTime*)dateTime)->ToUniversalTime();
		DateTime dateTime3 = dateTime2 + clientTimeOffset;
		endTimeUTC__BackingField = dateTime3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4F42");
		DateTime dateTime4 = (DateTime)(obj + 72);
		DateTime dateTime5 = ((DateTime*)dateTime4)->ToUniversalTime();
		DateTime dateTime6 = dateTime5 + clientTimeOffset;
		nextTournamentTimeUTC__BackingField = dateTime6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4F42");
		DateTime dateTime7 = (DateTime)(obj + 72);
		DateTime dateTime8 = ((DateTime*)dateTime7)->ToUniversalTime();
		DateTime dateTime9 = dateTime8 + clientTimeOffset;
		startTimeUTC__BackingField = dateTime9;
		nint num2 = 0;
		nint num3 = 0;
		IntPtr intPtr = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v123 @ S6_v3 (Il2CppClass<Il2CppMethodRgctx<Kiloo.Common.JsonObject::Get>>)+4] (should have been resolved before IL gen)");
		DateTime dateTime10 = (DateTime)(obj + 72);
		DateTime dateTime11 = ((DateTime*)dateTime10)->ToUniversalTime();
		DateTime dateTime12 = dateTime11 + clientTimeOffset;
		bool flag = dateTime12 >= endTimeUTC__BackingField;
		hasResult__BackingField = flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3689");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Rank[] ranks = default;
		_ranks = ranks;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj3 = obj + 68;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		_ = 0;
		int num4 = 0;
		object obj4 = default;
		object obj10 = default;
		object obj11 = default;
		object obj13 = default;
		object obj14 = default;
		Participant[] participants = default;
		object obj18 = default;
		object obj22 = default;
		object obj23 = default;
		object obj24 = default;
		object obj25 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj4 == null)
				{
					goto IL_041d;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj5 = obj + 56;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
							_ = 0;
							object obj6 = 0 << 3;
							object obj7 = (object)_ranks + obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
							_ = 0;
							object obj8 = 0 << 3;
							object obj9 = (object)_ranks + obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ S0_v243+10]");
							int num5 = (int)((nint)0 + (nint)num4);
							num4 = num5;
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
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj10 != obj11;
			object obj12 = obj13;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_041d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj12 = obj14;
			}
			_ = 0;
			object obj15 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				break;
			}
			goto IL_07f8;
			IL_07f8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			break;
			IL_041d:
			object obj16 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
			_totalNumberOfPlayers = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3689");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			_participants = participants;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj17 = obj + 68;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
			_ = 0;
			while (true)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj18 == null)
					{
						goto IL_0723;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj19 = obj + 48;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
								obj = 0;
								object obj20 = 0 << 3;
								object obj21 = (object)_participants + obj20;
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
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag3 = obj22 != obj23;
				obj12 = obj24;
				if (flag3)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_0723;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj12 = obj25;
				break;
				IL_0723:
				object obj26 = obj + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
				bool flag4 = _003C_003Ec._003C_003E9__40_0 == null;
				bool flag5 = !flag4;
				Comparison<Participant> comparison = _003C_003Ec._003C_003E9__40_0;
				if (!flag5)
				{
					throw new ArgumentException();
				}
				Array.Sort(_participants, comparison);
				return;
			}
			_ = 0;
			object obj27 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				break;
			}
			goto IL_07f8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
	}

	public int FindParticipantScoreByPublicKey(string publicKey)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Participant[] participants = _participants;
		object obj3 = 0;
		int result;
		while (true)
		{
			if (participants.Length > (nint)obj3)
			{
				object obj4 = obj3 << 3;
				object obj5 = (object)participants + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v7+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				bool flag = (string)0 != publicKey;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				result = 0;
				if (!flag)
				{
					break;
				}
				object obj6 = obj3 + 1;
				obj3 = obj6;
				continue;
			}
			result = 0;
			break;
		}
		return result;
	}

	public int GetRankForScore(int score)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		Rank[] ranks = _ranks;
		int num = ranks.Length;
		int result;
		bool flag2;
		do
		{
			int num2 = num - 1;
			bool flag = num2 <= 0;
			result = 0;
			if (flag)
			{
				break;
			}
			int num3 = num2 << 3;
			object obj = _ranks + num3;
			object obj2 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			flag2 = (nint)0 <= (nint)score;
			result = num2;
			num = num2;
		}
		while (flag2);
		return result;
	}

	public IEnumerable<IPlayer> GetPlayers()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @40F");
		IEnumerable<IPlayer> result = default;
		return result;
	}

	public IEnumerable<IPlayer> GetPlayersForRank(int rank)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @40F");
		IEnumerable<IPlayer> result = default;
		return result;
	}

	public int GetBestScoreForRank(int rank)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		int num = rank << 3;
		object obj = _ranks + num;
		object obj2 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v4+4]");
		return 0;
	}

	public int GetNumberOfPlayersForRank(int rank)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0030: Expected I4, but got Obj
		int num = rank << 3;
		object obj = _ranks + num;
		object obj2 = obj + 16;
		return (int)obj2;
	}

	public int GetNumberOfPlayersForTournament()
	{
		return _totalNumberOfPlayers;
	}
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Cpp2ILInjected;

namespace Missions;

public class StatAward : Award
{
	private List<Stat> listActiveStats;

	private Dictionary<Stat, int> _statOffset;

	private bool _hasMigratedToUseStatOffset;

	private bool _shouldMigrateToUseStatOffset;

	private Statistics stats
	{
		get
		{
			PlayerInfo instance = PlayerInfo.Instance;
			return instance._stats;
		}
	}

	public StatAward(AwardStaticData trophyData, string savedProgress, Action<Award> handler)
	{
		List<Stat> list = default;
		list._002Ector();
		listActiveStats = list;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<Stat, System.Int32>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Stat, int> statOffset = default;
		_statOffset = statOffset;
		base._002Ector(trophyData, savedProgress, handler);
		if (!_hasMigratedToUseStatOffset && ~(trophyData.migrateToUseStatOffset__BackingField ? 1u : 0u) == 0 && ~(trophyData.useStatOffset__BackingField ? 1u : 0u) == 0)
		{
			_shouldMigrateToUseStatOffset = true;
		}
	}

	protected override int GetProgressForGoal(AwardGoal goal)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0047: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		object obj = default;
		if (obj != null)
		{
			Statistics statistics = ((StatAward)null).stats;
			object obj2 = obj + 20;
			object obj3 = obj2 << 2;
			object obj4 = (object)statistics._values + obj3;
			int num = OffsetForStat((Stat)obj2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12+10]");
			return (int)(-num);
		}
		return 0;
	}

	public override bool isGoalAccomplished(AwardGoal goal)
	{
		//IL_000f: Expected Obj, but got I4
		//IL_0029: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		object obj = default;
		bool result;
		if (obj != null)
		{
			Statistics statistics = ((StatAward)1).stats;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v6+14]");
			object obj2 = (nint)0 << 2;
			object obj3 = (object)statistics._values + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v6+14]");
			int num = OffsetForStat(Stat.NotSet);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v6+8]");
			object obj4 = (nint)0 + (nint)num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v9+10]");
			bool flag = 0 >= (nint)obj4;
			result = true;
			if (flag)
			{
				goto IL_00d0;
			}
		}
		result = false;
		goto IL_00d0;
		IL_00d0:
		return result;
	}

	private int OffsetForStat(Stat stat)
	{
		//IL_0089: Expected Obj, but got I
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Stat, System.Int32>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		bool flag = obj4 == null;
		int result = 0;
		if (!flag)
		{
			AwardStaticData awardStaticData = _awardStaticData;
			bool flag2 = (byte)(~(awardStaticData.useStatOffset__BackingField ? 1u : 0u)) != 0;
			result = 0;
			if (!flag2)
			{
				result = 0;
				if (!_shouldMigrateToUseStatOffset)
				{
					int num3 = _statOffset.get_Item(stat);
					result = num3;
				}
			}
		}
		return result;
	}

	protected unsafe override void ActivateCurrentAwardTier()
	{
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		AwardTier awardProgressTier = _awardProgressTier;
		AwardGoal[] array = awardProgressTier.listGoals__BackingField;
		StatAward statAward = null;
		object obj3 = default;
		Statistics.StatChangedDelegate statChangedDelegate = default;
		while (array.Length > (nint)statAward)
		{
			object obj = (object)statAward << 2;
			object obj2 = (object)array + obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			if (obj3 != null)
			{
				List<Stat> list = listActiveStats;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v17+14]");
				list.Add(Stat.NotSet);
				Statistics statistics = statAward.stats;
				statChangedDelegate._002Ector(this, (nint)__ldftn(StatAward.OnStatChanged));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v17+14]");
				statistics.AddStatChangedHandler(Stat.NotSet, statChangedDelegate);
			}
			StatAward statAward2 = (StatAward)(statAward + 1);
			statAward = statAward2;
		}
		CheckAndUpdateProgress();
	}

	protected override void DeactivateCurrentAwardTier()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected Obj, but got Unknown
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected Obj, but got Unknown
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got Unknown
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected Obj, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected Obj, but got Unknown
		//IL_02e1: Expected Obj, but got I
		//IL_00f4: Expected I4, but got Obj
		//IL_00f4: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @728");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7;
		Stat stat = default;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj6 == null;
				obj7 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							((StatAward)10486).OnStatChanged(stat, (int)this);
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									continue;
								}
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj8 == obj9;
			bool flag3 = !flag2;
			object obj10 = obj11;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj7 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj10 = obj12;
			}
			_ = 0;
			object obj13 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj7 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj14 = obj7 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @95D0");
	}

	protected override void RecordNewOffsets()
	{
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_006a: Expected Obj, but got I
		//IL_0098: Expected Obj, but got I
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_0130: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I
		AwardTier awardProgressTier = _awardProgressTier;
		AwardGoal[] array = awardProgressTier.listGoals__BackingField;
		StatAward statAward = null;
		object obj3 = default;
		object obj8 = default;
		while (array.Length > (nint)statAward)
		{
			object obj = (object)statAward << 2;
			object obj2 = (object)array + obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			if (obj3 != null)
			{
				Statistics statistics = statAward.stats;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v17+14]");
				object obj4 = (nint)0 << 2;
				object obj5 = (object)statistics._values + obj4;
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S3_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Stat, System.Int32>>)+54]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v115 @ S3_v6+4] (should have been resolved before IL gen)");
				object obj7 = obj8 ^ -1;
				object obj9 = obj7 >> 31;
				if (obj9 == null)
				{
					nint num3 = 0;
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S5_v10 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Stat, System.Int32>>)+5C]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v134 @ S5_v11+4] (should have been resolved before IL gen)");
				}
				else
				{
					nint num5 = 0;
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S5_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Stat, System.Int32>>)+5C]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v143 @ S5_v6+4] (should have been resolved before IL gen)");
				}
			}
			StatAward statAward2 = (StatAward)(statAward + 1);
			statAward = statAward2;
		}
		_hasMigratedToUseStatOffset = true;
	}

	public unsafe void OnStatChanged(Stat stat, int newValue)
	{
		//IL_0030: Expected Obj, but got I
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		//IL_0099: Expected Obj, but got I4
		//IL_00d3: Expected Obj, but got I
		AwardTier awardProgressTier = _awardProgressTier;
		AwardGoal[] array = awardProgressTier.listGoals__BackingField;
		StatAward statAward = null;
		object obj4 = default;
		Statistics.StatChangedDelegate statChangedDelegate = default;
		while (array.Length > (nint)statAward)
		{
			object obj = (object)statAward << 2;
			object obj2 = (object)array + obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v15+10]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v17+14]");
				if ((nint)0 == (nint)stat)
				{
					Statistics statistics = statAward.stats;
					object obj5 = (int)stat << 2;
					object obj6 = (object)statistics._values + obj5;
					int num = OffsetForStat(stat);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v16+8]");
					object obj7 = (nint)0 + (nint)num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v28+10]");
					if (0 >= (nint)obj7)
					{
						Statistics statistics2 = statAward.stats;
						statChangedDelegate._002Ector(this, (nint)__ldftn(StatAward.OnStatChanged));
						statistics2.RemoveStatChangedHandler(stat, statChangedDelegate);
					}
				}
			}
			StatAward statAward2 = (StatAward)(statAward + 1);
			statAward = statAward2;
		}
		CheckAndUpdateProgress();
	}

	public unsafe override string AwardToString()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fe: Expected Obj, but got Unknown
		//IL_0707: Expected Obj, but got I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0088: Expected Obj, but got I
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_074c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0751: Expected Obj, but got Unknown
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected Obj, but got Unknown
		//IL_03db: Expected I, but got Obj
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Expected Obj, but got Unknown
		//IL_044a: Expected I, but got Obj
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected I4, but got Unknown
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected I4, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Expected I4, but got Unknown
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Expected I4, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected VT, but got Unknown
		//IL_05d9: Expected Ref, but got VT
		//IL_064d: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		object obj3 = obj - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		if (_awardActiveTier != null && _awardProgressTier != null)
		{
			StringBuilder stringBuilder = default;
			stringBuilder._002Ector(string.Empty);
			object obj4 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BE7");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
			_ = 0;
			object obj5 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj6 = obj + 56;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj8 = default;
			object obj11 = default;
			object obj12 = default;
			object obj14 = default;
			object obj15 = default;
			string result = default;
			while (true)
			{
				_ = 0;
				object obj7 = obj + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj8 == null)
					{
						break;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+44]");
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						_ = 0;
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
							_ = 0;
							_ = 0;
							object obj9 = obj + 8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
									_ = 0;
									_ = 0;
									object obj10 = obj + 4;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag = obj11 != obj12;
				object obj13 = obj14;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj13 = obj15;
				}
				_ = 0;
				object obj16 = obj + 16;
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
				return result;
			}
			object obj17 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @95CF");
			nint num = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v230 @ S1_v36 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
			string text = default;
			int num2 = text.LastIndexOf('%');
			if (num2 >= 0)
			{
				StringBuilder stringBuilder2 = stringBuilder.Remove(num2, 1);
			}
			nint num3 = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v300 @ S1_v42 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
			StringBuilder stringBuilder3 = default;
			stringBuilder3._002Ector(string.Empty);
			AwardTier awardActiveTier = _awardActiveTier;
			_ = awardActiveTier.tierType__BackingField;
			int num4 = obj + 44;
			string text2 = ((int*)num4)->ToString();
			string value = text2 + ",";
			StringBuilder stringBuilder4 = stringBuilder3.Append(value);
			_ = _currentActiveAwardState;
			int num5 = obj + 44;
			string text3 = ((int*)num5)->ToString();
			string value2 = text3 + ",";
			StringBuilder stringBuilder5 = stringBuilder3.Append(value2);
			AwardTier awardProgressTier = _awardProgressTier;
			_ = awardProgressTier.tierType__BackingField;
			int num6 = obj + 44;
			string text4 = ((int*)num6)->ToString();
			string value3 = text4 + ",";
			StringBuilder stringBuilder6 = stringBuilder3.Append(value3);
			_ = _currentProgressAwardState;
			int num7 = obj + 44;
			string text5 = ((int*)num7)->ToString();
			string value4 = text5 + ",";
			StringBuilder stringBuilder7 = stringBuilder3.Append(value4);
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			DateTime dateTime = (DateTime)(this + 24);
			string text6 = ((DateTime*)dateTime)->ToString(invariantCulture);
			string value5 = text6 + ",";
			StringBuilder stringBuilder8 = stringBuilder3.Append(value5);
			string text7 = default;
			string value6 = text7 + ",";
			StringBuilder stringBuilder9 = stringBuilder3.Append(value6);
			StringBuilder stringBuilder10 = stringBuilder3.Append(_hasMigratedToUseStatOffset);
			nint num8 = (nint)stringBuilder3;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v500 @ S1_v80 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
		}
		string result2 = default;
		return result2;
	}

	public override void ParseSavedProgressAndCreateAwardState(string s)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0d6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6f: Expected Obj, but got Unknown
		//IL_0b9a: Expected Obj, but got I
		//IL_0bc5: Expected Obj, but got I
		//IL_0bea: Expected Obj, but got I
		//IL_0c00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c05: Expected Obj, but got Unknown
		//IL_0c1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c23: Expected Obj, but got Unknown
		//IL_0c65: Expected Obj, but got I
		//IL_01e2: Expected I4, but got Obj
		//IL_029d: Expected I4, but got Obj
		//IL_0358: Expected I4, but got Obj
		//IL_0413: Expected I4, but got Obj
		//IL_0512: Expected Obj, but got I4
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Expected Obj, but got Unknown
		//IL_0994: Unknown result type (might be due to invalid IL or missing references)
		//IL_0999: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		ResetAwardToDefaultState();
		if (s == null || s._stringLength < 1)
		{
			return;
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v21+C]");
			if ((nint)0 < (nint)6)
			{
				return;
			}
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
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
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
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
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								object obj4 = default;
								_savedActiveTierType = (AwardTierType)obj4;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											object obj5 = default;
											_currentActiveAwardState = (AwardState)obj5;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														object obj6 = default;
														_savedProgressTierType = (AwardTierType)obj6;
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																if ((nint)0 != 1)
																{
																	object obj7 = default;
																	_currentProgressAwardState = (AwardState)obj7;
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
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
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FD2");
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																			if ((nint)0 != 1)
																			{
																				DateTime lastActiveStateChangeDateTime = default;
																				_lastActiveStateChangeDateTime = lastActiveStateChangeDateTime;
																				_ = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
																				_ = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																				if ((nint)0 != 1)
																				{
																					object obj8 = 0;
																					object obj11 = default;
																					object obj13 = default;
																					object obj14 = default;
																					bool hasMigratedToUseStatOffset = default;
																					while (true)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ S0_v287+C]");
																						if (0 > (nint)obj8)
																						{
																							object obj9 = obj8 << 2;
																							object obj10 = obj11 + obj9;
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
																									_ = 0;
																									object obj12 = obj13 + 1;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
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
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
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
																															_ = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
																																	if (obj14 == null)
																																	{
																																		_ = 0;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
																																		_ = 0;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																		if ((nint)0 == 1)
																																		{
																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																			break;
																																		}
																																	}
																																	else
																																	{
																																		_ = 0;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
																																		_ = 0;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																		if ((nint)0 == 1)
																																		{
																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																			break;
																																		}
																																	}
																																	object obj15 = obj8 + 1;
																																	obj8 = obj15;
																																	continue;
																																}
																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																break;
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
																							}
																							else
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																							}
																							break;
																						}
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v21+C]");
																						if ((nint)0 >= (nint)7)
																						{
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																							if ((nint)0 == 1)
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																								break;
																							}
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																							if ((nint)0 == 1)
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																								break;
																							}
																							_hasMigratedToUseStatOffset = hasMigratedToUseStatOffset;
																						}
																						return;
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
																	goto IL_0a9a;
																}
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														}
														goto IL_0a9a;
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											}
											goto IL_0a9a;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								goto IL_0a9a;
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
		goto IL_0a9a;
		IL_0dc8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return;
		IL_0a9a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj16 = default;
		object obj17 = default;
		bool flag = obj16 != obj17;
		object obj19 = default;
		object obj18 = obj19;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj21 = default;
				object obj20 = obj21;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj22 = default;
					if (obj22 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj23 = (nint)0 << 2;
						object obj24 = obj3 + obj23;
						obj24 = obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj25 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj26 = (nint)0 << 2;
						object obj27 = obj26 + obj3;
						object obj28 = obj27 - 4;
						object obj29 = obj28;
						object obj30 = obj29;
						object obj31 = obj29 + 24;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v486 @ S1_v47+D4] (should have been resolved before IL gen)");
						string text2 = default;
						string text = "StatAward parse failed: " + text2;
						ResetAwardToDefaultState();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj32 = -1;
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj33 = obj21;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag2 = (nint)0 != 1;
					obj18 = obj21;
					if (flag2)
					{
						goto IL_0dc8;
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
			object obj34 = default;
			obj18 = obj34;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				obj18 = obj34;
			}
		}
		goto IL_0dc8;
	}
}

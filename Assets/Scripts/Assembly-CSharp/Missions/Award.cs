using System;
using Cpp2ILInjected;
using Info;
using Kiloo;
using UnityEngine;

namespace Missions;

public abstract class Award
{
	protected AwardStaticData _awardStaticData;

	protected AwardState _currentActiveAwardState;

	protected AwardTier _awardActiveTier;

	protected AwardTierType _savedActiveTierType;

	protected DateTime _lastActiveStateChangeDateTime = DateTime.MinValue;

	protected DateTime _previewDateTime = DateTime.MinValue;

	protected AwardState _currentProgressAwardState;

	protected AwardTier _awardProgressTier;

	protected AwardTierType _savedProgressTierType;

	private const string AWARD_ISNEW_KEY_PREFIX = "isAwardNew";

	public AwardTierType tierAnimationPlayed;

	private const string AWARD_HASPAYED_OUT_KEY_PREFIX = "hasPayed";

	public Action<Award> onStateChangedHandler;

	private bool isInPreview__BackingField;

	public AwardStaticData trophyData => _awardStaticData;

	public AwardGoal[] goals
	{
		get
		{
			AwardTier awardActiveTier = _awardActiveTier;
			if (_awardActiveTier == null)
			{
				return null;
			}
			return awardActiveTier.listGoals__BackingField;
		}
	}

	public DateTime lastStateChangeDateTime
	{
		get
		{
			//IL_0009: Expected Obj, but got I4
			//IL_0036: Expected VT, but got Obj
			//IL_0022: Expected Obj, but got I4
			object obj = 32;
			if (!isInPreview__BackingField)
			{
				obj = 24;
			}
			object obj2 = (object)this + obj;
			return (DateTime)obj2;
		}
	}

	public AwardState awardState
	{
		get
		{
			return _currentActiveAwardState;
		}
		set
		{
			_currentActiveAwardState = value;
		}
	}

	public bool isNew
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj2 = default;
			Enum obj = (Enum)(obj2 - 16);
			AwardStaticData awardStaticData = _awardStaticData;
			_ = awardStaticData.id__BackingField;
			_ = -1;
			obj = (Enum)(object)typeof(AwardId);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
			_ = 0;
			string text = obj.ToString();
			string key = "isAwardNew" + text;
			int num = PlayerPrefs.GetInt(key, 1);
			return num != 0;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj2 = default;
			Enum obj = (Enum)(obj2 - 16);
			AwardStaticData awardStaticData = _awardStaticData;
			_ = awardStaticData.id__BackingField;
			_ = -1;
			obj = (Enum)(object)typeof(AwardId);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
			_ = 0;
			string text = obj.ToString();
			string key = "isAwardNew" + text;
			PlayerPrefs.SetInt(key, value ? 1 : 0);
		}
	}

	public AwardTierType activeTierType
	{
		get
		{
			AwardTier awardActiveTier = _awardActiveTier;
			return awardActiveTier.tierType__BackingField;
		}
	}

	public bool isInPreview
	{
		get
		{
			return isInPreview__BackingField;
		}
		set
		{
			isInPreview__BackingField = value;
		}
	}

	public int reward
	{
		get
		{
			AwardTier awardActiveTier = _awardActiveTier;
			if (_awardActiveTier == null)
			{
				return 0;
			}
			return awardActiveTier.reward__BackingField;
		}
	}

	public bool complete => _currentActiveAwardState == AwardState.Finished;

	public Award(AwardStaticData trophyData, string savedProgress, Action<Award> handler)
	{
		//IL_0033: Expected I, but got Obj
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		Delegate obj = Delegate.Combine(onStateChangedHandler, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		Action<Award> action = default;
		onStateChangedHandler = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		_awardStaticData = trophyData;
		isInPreview__BackingField = false;
		nint num = (nint)this;
		object obj2 = this + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S2_v5 (Il2CppClass<Missions.Award>)+10C] (should have been resolved before IL gen)");
	}

	public void Activate()
	{
		//IL_02ff: Expected VT, but got Obj
		//IL_048a: Expected VT, but got Obj
		//IL_004a: Expected Obj, but got I
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_035d: Expected Obj, but got I
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected Obj, but got Unknown
		//IL_01d7: Expected Obj, but got I
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected Obj, but got Unknown
		//IL_00ff: Expected Obj, but got I
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_02e5: Expected I, but got Obj
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected Obj, but got Unknown
		if (_currentActiveAwardState != AwardState.Finished)
		{
			if (_savedProgressTierType != AwardTierType.None)
			{
				AwardStaticData awardStaticData = _awardStaticData;
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S3_v26 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Missions.AwardTierType, Missions.AwardTier>>)+54]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v40 @ S3_v27+4] (should have been resolved before IL gen)");
				object obj3 = default;
				object obj2 = obj3 ^ -1;
				object obj4 = obj2 >> 31;
				if (obj4 != null)
				{
					AwardStaticData awardStaticData2 = _awardStaticData;
					AwardTier awardProgressTier = awardStaticData2.missionTiers__BackingField.get_Item(_savedProgressTierType);
					_awardProgressTier = awardProgressTier;
					if (_savedActiveTierType != AwardTierType.None)
					{
						AwardStaticData awardStaticData3 = _awardStaticData;
						nint num3 = 0;
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S3_v34 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Missions.AwardTierType, Missions.AwardTier>>)+54]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v117 @ S3_v35+4] (should have been resolved before IL gen)");
						object obj7 = default;
						object obj6 = obj7 ^ -1;
						object obj8 = obj6 >> 31;
						if (obj8 != null)
						{
							AwardStaticData awardStaticData4 = _awardStaticData;
							AwardTier awardActiveTier = awardStaticData4.missionTiers__BackingField.get_Item(_savedActiveTierType);
							_awardActiveTier = awardActiveTier;
						}
					}
					CheckTierValues();
					goto IL_045c;
				}
			}
			AwardTierType awardTierType = AwardTierType.None;
			object obj11 = default;
			while (true)
			{
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(AwardTierType));
				string[] names = Enum.GetNames(typeFromHandle);
				if ((int)awardTierType >= names.Length)
				{
					break;
				}
				AwardStaticData awardStaticData5 = _awardStaticData;
				nint num5 = 0;
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S3_v17 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Missions.AwardTierType, Missions.AwardTier>>)+54]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v236 @ S3_v18+4] (should have been resolved before IL gen)");
				object obj10 = obj11 ^ -1;
				object obj12 = obj10 >> 31;
				if (obj12 != null)
				{
					AwardStaticData awardStaticData6 = _awardStaticData;
					AwardTier awardProgressTier2 = awardStaticData6.missionTiers__BackingField.get_Item(awardTierType);
					_awardProgressTier = awardProgressTier2;
					AwardStaticData awardStaticData7 = _awardStaticData;
					AwardTier awardActiveTier2 = awardStaticData7.missionTiers__BackingField.get_Item(awardTierType);
					_awardActiveTier = awardActiveTier2;
					_currentProgressAwardState = AwardState.InProgress;
					_currentActiveAwardState = AwardState.InProgress;
					object obj13 = this - -64;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v295 @ S1_v48+BC] (should have been resolved before IL gen)");
					break;
				}
				AwardTierType awardTierType2 = awardTierType + 1;
				awardTierType = awardTierType2;
			}
			goto IL_045c;
		}
		Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(AwardTierType));
		string[] names2 = Enum.GetNames(typeFromHandle2);
		AwardTierType awardTierType3 = (AwardTierType)(names2.Length - 1);
		AwardTierType awardTierType4 = awardTierType3;
		object obj16 = default;
		while (awardTierType4 >= AwardTierType.Bronze)
		{
			AwardStaticData awardStaticData8 = _awardStaticData;
			nint num7 = 0;
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S3_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Missions.AwardTierType, Missions.AwardTier>>)+54]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v202 @ S3_v6+4] (should have been resolved before IL gen)");
			object obj15 = obj16 ^ -1;
			object obj17 = obj15 >> 31;
			if (obj17 == null)
			{
				AwardTierType awardTierType5 = awardTierType4 - 1;
				awardTierType4 = awardTierType5;
				continue;
			}
			AwardStaticData awardStaticData9 = _awardStaticData;
			AwardTier awardActiveTier3 = awardStaticData9.missionTiers__BackingField.get_Item(awardTierType4);
			_awardActiveTier = awardActiveTier3;
			AwardStaticData awardStaticData10 = _awardStaticData;
			AwardTier awardProgressTier3 = awardStaticData10.missionTiers__BackingField.get_Item(awardTierType4);
			_awardProgressTier = awardProgressTier3;
			break;
		}
		return;
		IL_045c:
		if (_awardProgressTier != null && _currentProgressAwardState == AwardState.InProgress)
		{
			nint num9 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v266 @ S1_v24 (Il2CppClass<Missions.Award>)+EC] (should have been resolved before IL gen)");
		}
	}

	private void CheckTierValues()
	{
		AwardTier awardProgressTier = _awardProgressTier;
		AwardTier awardActiveTier = _awardActiveTier;
		if (awardProgressTier.tierType__BackingField < awardActiveTier.tierType__BackingField)
		{
			AwardStaticData awardStaticData = _awardStaticData;
			AwardTier awardActiveTier2 = awardStaticData.missionTiers__BackingField.get_Item(awardProgressTier.tierType__BackingField);
			_awardActiveTier = awardActiveTier2;
			_currentActiveAwardState = _currentProgressAwardState;
		}
	}

	public bool BelongsToState(AwardState state)
	{
		bool result;
		if (~(isInPreview__BackingField ? 1u : 0u) == 0)
		{
			if (state != AwardState.Collectible)
			{
				goto IL_006e;
			}
			result = true;
		}
		else
		{
			bool flag = _currentActiveAwardState == state;
			result = true;
			if (!flag)
			{
				goto IL_006e;
			}
		}
		goto IL_007c;
		IL_007c:
		return result;
		IL_006e:
		result = false;
		goto IL_007c;
	}

	public bool hasFinishedAnyTier()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00ff: Expected Obj, but got I4
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		object obj3 = _currentActiveAwardState - 1;
		bool result;
		if (_currentActiveAwardState != AwardState.InProgress)
		{
			bool flag = (nint)obj3 == 1;
			result = true;
			if (!flag)
			{
				bool flag2 = (nint)obj3 == 2;
				result = true;
				if (!flag2)
				{
					goto IL_00e1;
				}
			}
		}
		else
		{
			AwardStaticData awardStaticData = _awardStaticData;
			_ = awardStaticData.id__BackingField;
			_ = -1;
			obj = (Enum)(object)typeof(AwardId);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
			_ = 0;
			string text = obj.ToString();
			string key = "hasPayed" + text;
			bool flag3 = PlayerPrefs.HasKey(key);
			result = true;
			if (!flag3)
			{
				goto IL_00e1;
			}
		}
		goto IL_011e;
		IL_00e1:
		result = false;
		goto IL_011e;
		IL_011e:
		return result;
	}

	public int GetProgressAsPercentage()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I
		//IL_0090: Expected I, but got Obj
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_0164: Expected I4, but got F4
		object obj = _currentActiveAwardState & (AwardState)(-2);
		if ((nint)obj != 2)
		{
			AwardTier awardActiveTier = _awardActiveTier;
			AwardGoal[] array = awardActiveTier.listGoals__BackingField;
			object obj2 = 0;
			object obj7 = default;
			object obj8 = default;
			object obj9 = default;
			object obj10 = default;
			object obj11 = default;
			while (array.Length > (nint)obj2)
			{
				object obj3 = obj2 << 2;
				object obj4 = (object)array + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S2_v4+10]");
				object obj5 = 0;
				nint num = (nint)this;
				object obj6 = this + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v78 @ S3_v6 (Il2CppClass<Missions.Award>)+E4] (should have been resolved before IL gen)");
				obj7 = obj8 + obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S2_v5+8]");
				obj10 = 0 + obj11;
				object obj12 = obj2 + 1;
				obj2 = obj12;
			}
			float num2 = (float)obj7 * 100f;
			float num3 = num2 / (float)obj10;
			float num4 = default;
			if (!(num3 < 0f))
			{
				bool flag = num3 > 100f;
				bool flag2 = !flag;
				num4 = num3;
				if (!flag2)
				{
					num4 = 100f;
				}
			}
			double num5 = Math.Abs((double)num4);
			if (num5 < 2147483648.0)
			{
				return (int)num4;
			}
			return int.MinValue;
		}
		return 100;
	}

	protected void CheckAndUpdateProgress()
	{
		//IL_0060: Expected Obj, but got I4
		//IL_0085: Expected I, but got Obj
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		AwardStaticData awardStaticData = _awardStaticData;
		if ((~(awardStaticData.useFacebook__BackingField ? 1u : 0u) == 0 && AgeRestriction.isRestricted) || _currentProgressAwardState == AwardState.Finished)
		{
			return;
		}
		AwardTier awardProgressTier = _awardProgressTier;
		AwardGoal[] array = awardProgressTier.listGoals__BackingField;
		object obj = 0;
		object obj5 = default;
		while (true)
		{
			if (array.Length > (nint)obj)
			{
				object obj2 = obj << 2;
				object obj3 = (object)array + obj2;
				nint num = (nint)this;
				object obj4 = this + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v73 @ S2_v7 (Il2CppClass<Missions.Award>)+DC] (should have been resolved before IL gen)");
				if (obj5 != null)
				{
					object obj6 = obj + 1;
					obj = obj6;
					continue;
				}
				break;
			}
			GoToState(AwardState.Collectible);
			break;
		}
	}

	protected void GoToState(AwardState state)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_04c6: Expected Obj, but got I4
		//IL_007d: Expected I, but got Obj
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 48);
		_ = 0;
		_ = 0;
		_currentProgressAwardState = state;
		Action<Award> action = onStateChangedHandler;
		AwardState awardState;
		if (onStateChangedHandler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S0_v11 (System.Action`1<Missions.Award>)+C] (should have been resolved before IL gen)");
			awardState = _currentProgressAwardState;
		}
		else
		{
			awardState = state;
		}
		object obj3 = awardState - 1;
		if (awardState != AwardState.InProgress)
		{
			if ((nint)obj3 == 1)
			{
				if (UIScreenController.IsInstanced)
				{
					UIScreenController instance = UIScreenController.Instance;
					AwardStaticData awardStaticData = _awardStaticData;
					string payload = Strings.Get(awardStaticData.title__BackingField);
					AwardTier awardProgressTier = _awardProgressTier;
					UIScreenController.SlideIn slideIn = default;
					slideIn._002Ector(UIScreenController.SlideInType.Awards, payload, awardProgressTier.tierType__BackingField);
					instance.QueueSlideIn(slideIn);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				AwardStaticData awardStaticData2 = _awardStaticData;
				_ = awardStaticData2.id__BackingField;
				Enum obj4 = (Enum)(obj + 16);
				_ = -1;
				obj4 = (Enum)(object)typeof(AwardId);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+2C]");
				_ = 0;
				string text = obj4.ToString();
				throw new ArrayTypeMismatchException();
			}
			if ((nint)obj3 == 2)
			{
				AwardStaticData awardStaticData3 = _awardStaticData;
				_ = awardStaticData3.id__BackingField;
				Enum obj5 = (Enum)(obj + 16);
				_ = -1;
				obj5 = (Enum)(object)typeof(AwardId);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+2C]");
				_ = 0;
				string text2 = obj5.ToString();
				if (_currentActiveAwardState == AwardState.InProgress)
				{
					_currentActiveAwardState = AwardState.Collectible;
					DateTime utcNow = CDateTime.UtcNow;
					_lastActiveStateChangeDateTime = utcNow;
				}
			}
		}
		else
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v55 @ S1_v11 (Il2CppClass<Missions.Award>)+EC] (should have been resolved before IL gen)");
		}
	}

	public void RewardPayedOut()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		if (_currentActiveAwardState == AwardState.Collectible)
		{
			AwardStaticData awardStaticData = _awardStaticData;
			_ = awardStaticData.id__BackingField;
			_ = -1;
			obj = (Enum)(object)typeof(AwardId);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
			_ = 0;
			string text = obj.ToString();
			string key = "hasPayed" + text;
			if (!PlayerPrefs.HasKey(key))
			{
				AwardStaticData awardStaticData2 = _awardStaticData;
				_ = awardStaticData2.id__BackingField;
				_ = -1;
				obj = (Enum)(object)typeof(AwardId);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
				_ = 0;
				string text2 = obj.ToString();
				string key2 = "hasPayed" + text2;
				PlayerPrefs.SetInt(key2, 1);
			}
			CalculateNextActiveTier();
		}
	}

	protected void CalculateNextActiveTier()
	{
		//IL_003e: Expected Obj, but got I
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_00f8: Expected Obj, but got I4
		AwardTier awardActiveTier = _awardActiveTier;
		AwardTier awardProgressTier = _awardProgressTier;
		if (awardActiveTier.tierType__BackingField < awardProgressTier.tierType__BackingField)
		{
			AwardStaticData awardStaticData = _awardStaticData;
			AwardTierType key = awardActiveTier.tierType__BackingField + 1;
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S3_v7 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Missions.AwardTierType, Missions.AwardTier>>)+54]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ S3_v8+4] (should have been resolved before IL gen)");
			object obj3 = default;
			object obj2 = obj3 ^ -1;
			object obj4 = obj2 >> 31;
			if (obj4 != null)
			{
				AwardStaticData awardStaticData2 = _awardStaticData;
				AwardTier awardActiveTier2 = awardStaticData2.missionTiers__BackingField.get_Item(key);
				_awardActiveTier = awardActiveTier2;
				AwardTier awardActiveTier3 = _awardActiveTier;
				AwardTier awardProgressTier2 = _awardProgressTier;
				if (awardActiveTier3.tierType__BackingField == awardProgressTier2.tierType__BackingField)
				{
					object obj5 = _currentProgressAwardState & (AwardState)(-2);
					if ((nint)obj5 == 2)
					{
						if (_currentActiveAwardState != AwardState.Collectible)
						{
							DateTime utcNow = CDateTime.UtcNow;
							_previewDateTime = utcNow;
						}
						_currentActiveAwardState = AwardState.Collectible;
					}
					else
					{
						_currentActiveAwardState = AwardState.InProgress;
					}
				}
			}
		}
		else if (_currentProgressAwardState == AwardState.Finished)
		{
			DateTime utcNow2 = CDateTime.UtcNow;
			_currentActiveAwardState = AwardState.Finished;
			_lastActiveStateChangeDateTime = utcNow2;
		}
		Action<Award> action = onStateChangedHandler;
		if (onStateChangedHandler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v81 @ S0_v11 (System.Action`1<Missions.Award>)+C] (should have been resolved before IL gen)");
		}
	}

	protected void MoveToNextTierOrFinishIfLast()
	{
		//IL_013c: Expected VT, but got Obj
		//IL_0059: Expected Obj, but got I
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		AwardTier awardProgressTier = _awardProgressTier;
		AwardTierType awardTierType = awardProgressTier.tierType__BackingField + 1;
		AwardTierType awardTierType2 = awardTierType;
		object obj3 = default;
		AwardState state;
		while (true)
		{
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(AwardTierType));
			string[] names = Enum.GetNames(typeFromHandle);
			if ((int)awardTierType2 < names.Length)
			{
				AwardStaticData awardStaticData = _awardStaticData;
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S4_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Missions.AwardTierType, Missions.AwardTier>>)+54]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v66 @ S4_v6+4] (should have been resolved before IL gen)");
				object obj2 = obj3 ^ -1;
				object obj4 = obj2 >> 31;
				if (obj4 == null)
				{
					AwardTierType awardTierType3 = awardTierType2 + 1;
					awardTierType2 = awardTierType3;
					continue;
				}
				AwardStaticData awardStaticData2 = _awardStaticData;
				AwardTier awardProgressTier2 = awardStaticData2.missionTiers__BackingField.get_Item(awardTierType2);
				_awardProgressTier = awardProgressTier2;
				object obj5 = this - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v101 @ S2_v17+BC] (should have been resolved before IL gen)");
				state = AwardState.InProgress;
				break;
			}
			state = AwardState.Finished;
			break;
		}
		GoToState(state);
	}

	public void CompleteCurrentTierIfDebug()
	{
		if (~(Globals.DEBUG_POPUP ? 1u : 0u) == 0)
		{
			MoveToNextTierOrFinishIfLast();
		}
	}

	protected void ResetAwardToDefaultState()
	{
		_currentProgressAwardState = AwardState.NotSet;
		_currentActiveAwardState = AwardState.NotSet;
		_savedProgressTierType = AwardTierType.None;
		_lastActiveStateChangeDateTime = DateTime.MinValue;
	}

	public void Complete()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<Missions.Award>)+F4] (should have been resolved before IL gen)");
	}

	public bool HasCompletedTier(AwardTierType progressTierTypeToCheck)
	{
		//IL_0082: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I4
		AwardTier awardProgressTier = _awardProgressTier;
		bool result;
		if (progressTierTypeToCheck == awardProgressTier.tierType__BackingField)
		{
			object obj = _currentProgressAwardState & (AwardState)(-2);
			if ((nint)obj == 2)
			{
				result = true;
				goto IL_00dc;
			}
		}
		else
		{
			object obj2 = progressTierTypeToCheck + 1;
			if ((nint)awardProgressTier.tierType__BackingField == (nint)obj2)
			{
				bool flag = _currentProgressAwardState == AwardState.InProgress;
				result = true;
				if (flag)
				{
					goto IL_00dc;
				}
			}
		}
		result = false;
		goto IL_00dc;
		IL_00dc:
		return result;
	}

	public abstract bool isGoalAccomplished(AwardGoal goal);

	protected abstract int GetProgressForGoal(AwardGoal goal);

	protected abstract void ActivateCurrentAwardTier();

	protected abstract void DeactivateCurrentAwardTier();

	protected abstract void RecordNewOffsets();

	public abstract string AwardToString();

	public abstract void ParseSavedProgressAndCreateAwardState(string s);

	public void OnGameStarted()
	{
	}

	public void OnGameEnded()
	{
	}
}

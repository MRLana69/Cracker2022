using System;
using System.Collections.Generic;

namespace Missions;

public class PersistentAwardProgress
{
	public AwardTierType activeTierType;

	public AwardTierType progressTierType;

	public AwardState currentActiveAwardState;

	public AwardState currentProgressAwardState;

	public DateTime lastActiveStateChangeDateTime;

	public int offset;

	public Dictionary<Stat, int> statOffset;

	public bool hasMigratedToUseStatOffset;
}

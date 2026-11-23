using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo;
using UnityEngine;

public class Friend
{
	public enum Medal
	{
		none,
		bronze,
		silver,
		gold
	}

	public class Status
	{
		public DateTime lastPokeTime = DateTime.MinValue;

		public DateTime lastDuelPokeTime = DateTime.MinValue;

		public int gamesCashedIn;
	}

	public const int RELATION_FACEBOOK_MASK = 1;

	public const int RELATION_GAMECENTER_MASK = 2;

	public static readonly string[] romanRanks;

	public static readonly Dictionary<Medal, string> medalSpriteString;

	public int userid;

	public int score;

	public int meters;

	public int games;

	public int rank;

	public GameCenterProfile gcProfile;

	public FacebookProfile fbProfile;

	public OfflineProfile offlineProfile;

	public Status status;

	private Action _updatedHandler;

	public string name
	{
		get
		{
			FacebookProfile facebookProfile = fbProfile;
			if (fbProfile != null)
			{
				return facebookProfile.name;
			}
			GameCenterProfile gameCenterProfile = gcProfile;
			if (gcProfile != null)
			{
				return gameCenterProfile.alias;
			}
			OfflineProfile offlineProfile = this.offlineProfile;
			if (this.offlineProfile != null)
			{
				return offlineProfile.name;
			}
			return null;
		}
		set
		{
			if (fbProfile == null && gcProfile == null)
			{
				OfflineProfile offlineProfile = this.offlineProfile;
				if (this.offlineProfile == null)
				{
					OfflineProfile offlineProfile2 = default;
					this.offlineProfile = offlineProfile2;
					offlineProfile = this.offlineProfile;
				}
				offlineProfile.name = value;
			}
		}
	}

	public Texture2D image
	{
		get
		{
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected Obj, but got Unknown
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected Obj, but got Unknown
			if (fbProfile != null)
			{
				return (Texture2D)(fbProfile + 20);
			}
			if (gcProfile == null)
			{
				return null;
			}
			return (Texture2D)(gcProfile + 20);
		}
	}

	public int relation
	{
		get
		{
			bool flag = fbProfile != null;
			int result = (flag ? 1 : 0) | 2;
			if (gcProfile == null)
			{
				result = (flag ? 1 : 0);
			}
			return result;
		}
	}

	public string id
	{
		get
		{
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected Obj, but got Unknown
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected Obj, but got Unknown
			if (fbProfile != null)
			{
				return (string)(fbProfile + 8);
			}
			if (gcProfile == null)
			{
				return null;
			}
			return (string)(gcProfile + 8);
		}
	}

	public int gamesToCashIn
	{
		get
		{
			Status status = this.status;
			bool flag = games < status.gamesCashedIn;
			bool flag2 = !flag;
			int gamesCashedIn = status.gamesCashedIn;
			if (!flag2)
			{
				status.gamesCashedIn = games;
				gamesCashedIn = games;
			}
			return games - gamesCashedIn;
		}
	}

	public bool shouldBeDuelPoked
	{
		get
		{
			Status status = this.status;
			return isPokeTime(status.lastDuelPokeTime);
		}
	}

	public bool shouldBePoked
	{
		get
		{
			Status status = this.status;
			return isPokeTime(status.lastPokeTime);
		}
	}

	private bool isPokeTime(DateTime lastPokeTime)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0032: Expected Obj, but got I8
		object obj2 = default;
		object obj = obj2 - 16;
		DateTime utcNow = CDateTime.UtcNow;
		TimeSpan timeSpan = utcNow - lastPokeTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		object obj3 = 0 / 864000000000L;
		bool result;
		if ((nint)obj3 >= 1)
		{
			Status status = this.status;
			bool flag = status.lastPokeTime == DateTime.MinValue;
			result = true;
			if (!flag)
			{
				goto IL_00c7;
			}
		}
		result = false;
		goto IL_00c7;
		IL_00c7:
		return result;
	}

	public void AddUpdatedHandler(Action handler)
	{
		Delegate obj = Delegate.Combine(_updatedHandler, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action updatedHandler = default;
		_updatedHandler = updatedHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	public void RemoveUpdatedHandler(Action handler)
	{
		Delegate obj = Delegate.Remove(_updatedHandler, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action updatedHandler = default;
		_updatedHandler = updatedHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	public void InvokeUpdatedHandler()
	{
		Action updatedHandler = _updatedHandler;
		if (_updatedHandler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	static Friend()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}

using System;
using System.Globalization;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using UnityEngine;

public class Friend
{
	public class Status
	{
		public DateTime lastPokeTime;

		public int gamesCashedIn;

		public Status()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public const int RELATION_FACEBOOK_MASK = 1;

	public const int RELATION_GAMECENTER_MASK = 2;

	public int userid;

	public int score;

	public int meters;

	public int games;

	public int rank;

	public GameCenterProfile gcProfile;

	public FacebookProfile fbProfile;

	public OfflineProfile offlineProfile;

	public Status status;

	private Action m_updated;

	public string name
	{
		get
		{
			//IL_000e: Expected Obj, but got I4
			//IL_0047: Expected Obj, but got I4
			//IL_0080: Expected Obj, but got I4
			//IL_00ed: Expected Obj, but got I4
			//IL_00b9: Expected Obj, but got I4
			UnityEngine.Object obj = UnityEngine.Object.Instantiate((UnityEngine.Object)(object)this);
			if (((string)(object)obj).EndsWith("jetpackPickup"))
			{
				return (string)8;
			}
			if (((string)(object)obj).EndsWith("jumpBooster"))
			{
				return (string)4;
			}
			if (((string)(object)obj).EndsWith("doubleScoreMultiplier"))
			{
				return (string)32;
			}
			if (((string)(object)obj).EndsWith("magnetBooster"))
			{
				return (string)2;
			}
			object msg = ((IConvertible)"Unexpected value here: ").ToType((Type)(object)obj, (IFormatProvider)(object)". Fix immediately");
			SDebug.LogFormat((string)msg, null);
			return (string)8;
		}
		set
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = (Delegate)(object)fbProfile;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)(object)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 32;
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

	public Texture2D image
	{
		get
		{
			if (fbProfile != null)
			{
				FacebookProfile facebookProfile = fbProfile;
				return (Texture2D)(object)facebookProfile.name;
			}
			if (gcProfile != null)
			{
				GameCenterProfile gameCenterProfile = gcProfile;
				return (Texture2D)(object)gameCenterProfile.alias;
			}
			if (this.offlineProfile != null)
			{
				OfflineProfile offlineProfile = this.offlineProfile;
				return (Texture2D)(object)offlineProfile.name;
			}
			SDebug.LogFormat("Friend not initialized", null);
			return null;
		}
	}

	public int relation
	{
		get
		{
			//IL_0036: Expected I4, but got Obj
			//IL_0071: Expected I4, but got Obj
			if (fbProfile != null)
			{
				FacebookProfile facebookProfile = fbProfile;
				return (int)facebookProfile.image;
			}
			if (gcProfile != null)
			{
				GameCenterProfile gameCenterProfile = gcProfile;
				return (int)gameCenterProfile.image;
			}
			return 0;
		}
	}

	public string id
	{
		get
		{
			//IL_0022: Expected Obj, but got I4
			//IL_004e: Expected Obj, but got I4
			bool flag = fbProfile != null;
			string result = (string)((flag ? 1 : 0) | 2);
			if (gcProfile == null)
			{
				result = (string)flag;
			}
			return result;
		}
	}

	public int gamesToCashIn
	{
		get
		{
			//IL_0036: Expected I4, but got Obj
			//IL_0071: Expected I4, but got Obj
			if (fbProfile != null)
			{
				FacebookProfile facebookProfile = fbProfile;
				return (int)facebookProfile.id;
			}
			if (gcProfile != null)
			{
				GameCenterProfile gameCenterProfile = gcProfile;
				return (int)gameCenterProfile.id;
			}
			return 0;
		}
	}

	public bool shouldBePoked
	{
		get
		{
			Status status = this.status;
			if (games < status.gamesCashedIn)
			{
				Status status2 = this.status;
				status2.gamesCashedIn = games;
			}
			Status status3 = this.status;
			return (byte)(games - status3.gamesCashedIn) != 0;
		}
	}

	public event Action updated
	{
		add
		{
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected Obj, but got Unknown
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected Obj, but got Unknown
			if (fbProfile == null && gcProfile == null)
			{
				if (offlineProfile == null)
				{
					object obj = this + 36;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj2 = default;
					obj = obj2;
				}
				object obj3 = offlineProfile + 8;
				obj3 = value;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_updated;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 44;
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

	private bool IsPokeTime(DateTime lastPokeTime)
	{
		//IL_0008: Expected Obj, but got VT
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_00c1: Expected I4, but got Obj
		//IL_001b: Expected I, but got Obj
		object obj = lastPokeTime;
		nint num = (nint)typeof(CultureInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(CultureInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v16 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CultureInfo currentUICulture = CultureInfo.CurrentUICulture;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D675");
		string value = default;
		return (byte)(int)((StringBuilder)this).AppendLine(value) != 0;
	}

	public void InvokeUpdatedHandler()
	{
	}

	public Friend()
	{
		TransformExtensions.Reset((Transform)(object)this.m_updated);
	}
}

using System;

namespace TopRun.Internal;

internal class Player : IPlayer
{
	private string publicKey__BackingField;

	private int score__BackingField;

	private bool isFriend__BackingField;

	public string publicKey
	{
		get
		{
			if (this != null)
			{
				return (string)((IConvertible)"\"").ToType((Type)(object)this, (IFormatProvider)(object)"\"");
			}
			return "null";
		}
		internal set
		{
			//IL_0015: Expected I4, but got Obj
			//IL_0015: Expected Obj, but got I4
			_ = 0;
			((Rank)this)._002Ector((string)1, (int)value);
		}
	}

	public int score
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)publicKey__BackingField;
		}
		internal set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 8;
			obj = value;
		}
	}

	public bool isFriend
	{
		get
		{
			return (byte)score__BackingField != 0;
		}
		internal set
		{
			score__BackingField = (value ? 1 : 0);
		}
	}

	public FacebookProfile facebookProfile
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool flag = isFriend__BackingField;
			return (FacebookProfile)flag;
		}
		internal set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected I4, but got Unknown
			bool flag = (byte)(value & 1) != 0;
			isFriend__BackingField = flag;
		}
	}
}

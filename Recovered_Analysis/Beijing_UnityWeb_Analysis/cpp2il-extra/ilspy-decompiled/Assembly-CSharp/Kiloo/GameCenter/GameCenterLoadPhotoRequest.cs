using UnityEngine;

namespace Kiloo.GameCenter;

public class GameCenterLoadPhotoRequest : GameCenterRequest
{
	private string playerID__BackingField;

	private GameCenterPlugin.PhotoSize size__BackingField;

	private int textureWidth__BackingField;

	private int textureHeight__BackingField;

	public string playerID
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (string)size__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 24;
			obj = value;
		}
	}

	public GameCenterPlugin.PhotoSize size
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (GameCenterPlugin.PhotoSize)playerID__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 20;
			obj = value;
		}
	}

	public int textureWidth
	{
		get
		{
			return (int)size__BackingField;
		}
		set
		{
			size__BackingField = (GameCenterPlugin.PhotoSize)value;
		}
	}

	public int textureHeight
	{
		get
		{
			return textureWidth__BackingField;
		}
		set
		{
			textureWidth__BackingField = value;
		}
	}

	public Texture2D result
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (Texture2D)textureHeight__BackingField;
		}
		internal set
		{
			//IL_000a: Expected I4, but got Obj
			textureHeight__BackingField = (int)value;
		}
	}
}

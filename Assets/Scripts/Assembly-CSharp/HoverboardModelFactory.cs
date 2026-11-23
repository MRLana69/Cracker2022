using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using UnityEngine;

public class HoverboardModelFactory : SingletonMonobehavior<HoverboardModelFactory>
{
	internal HoverboardManager hoverboardManager;

	private void Awake()
	{
		HoverboardManager instance = HoverboardManager.Instance;
		hoverboardManager = instance;
	}

	public HoverboardBundle RequestHoverboardInstance(string name)
	{
		string path = "Prefabs/HoverboardAssets/" + name;
		UnityEngine.Object obj = Resources.Load(path);
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
		UnityEngine.Object obj2 = UnityEngine.Object.Instantiate(obj);
		bool flag = (object)obj2 == null;
		GameObject gameObject = null;
		if (!flag)
		{
			bool flag2 = (object)obj2.GetType() == typeof(GameObject);
			gameObject = (GameObject)obj2;
			if (!flag2)
			{
				gameObject = null;
			}
		}
		return gameObject.GetComponent<HoverboardBundle>();
	}

	public HoverboardBundle RequestEquippedHoverboardInstance()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0044: Expected Obj, but got I4
		object obj = default;
		HoverboardModelFactory hoverboardModelFactory = (HoverboardModelFactory)(obj - 16);
		PlayerInfo instance = PlayerInfo.Instance;
		hoverboardModelFactory.hoverboardManager = (HoverboardManager)instance._currentHoverboard;
		_ = -1;
		hoverboardModelFactory = (HoverboardModelFactory)(object)typeof(Hoverboards.BoardType);
		_ = hoverboardModelFactory.hoverboardManager;
		string text = ((Enum)(object)hoverboardModelFactory).ToString();
		return hoverboardModelFactory.RequestHoverboardInstance(text);
	}

	public HoverboardBundle RequestRandomHoverboardInstance()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0064: Expected Obj, but got I4
		object obj = default;
		HoverboardModelFactory hoverboardModelFactory = (HoverboardModelFactory)(obj - 16);
		List<Hoverboards.BoardType> randomBoardList = MysteryPowerup.GetRandomBoardList();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v4 (System.Collections.Generic.List`1<Hoverboards+BoardType>)+C]");
		int index = UnityEngine.Random.Range(0, 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v4 (System.Collections.Generic.List`1<Hoverboards+BoardType>)+C]");
		if ((nint)0 >= (nint)1)
		{
			Hoverboards.BoardType boardType = randomBoardList.get_Item(index);
			hoverboardModelFactory.hoverboardManager = (HoverboardManager)boardType;
			_ = -1;
			hoverboardModelFactory = (HoverboardModelFactory)(object)typeof(Hoverboards.BoardType);
			_ = hoverboardModelFactory.hoverboardManager;
			string text = ((Enum)(object)hoverboardModelFactory).ToString();
			return hoverboardModelFactory.RequestHoverboardInstance(text);
		}
		return null;
	}
}

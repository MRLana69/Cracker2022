using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Level.TrackEvents;
using UnityEngine;
using UnityEngine.U2D;

namespace SYBO.Subway.Level;

public abstract class RandomizerHold : Selector
{
	private GameObject[] children;

	private int _currentRandomizedSectionIndex;

	private GameObject _lastSelectedObject;

	protected override void Initialize()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	public override void PerformSelection(List<GameObject> objectsToVisit)
	{
		//IL_002b: Expected Obj, but got I4
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		((Activity)(object)this).Prepare((IActivityInitializer)null);
		int siblingIndex = _transform.GetSiblingIndex();
		int num = Random.RandomRangeInt(0, siblingIndex);
		Sprite sprite = null;
		while (true)
		{
			int siblingIndex2 = _transform.GetSiblingIndex();
			if ((nint)sprite < siblingIndex2)
			{
				bool flag = ((SpriteAtlas)(object)_transform).CanBindTo(sprite);
				string text = ((Component)flag).tag;
				if ((nint)sprite == num)
				{
					objectsToVisit.Add((GameObject)(object)text);
				}
				else if (((GameObject)(object)text).activeInHierarchy)
				{
					((GameObject)(object)text).tag = null;
				}
				Sprite sprite2 = (Sprite)(sprite + 1);
				sprite = sprite2;
				continue;
			}
			break;
		}
	}

	protected RandomizerHold()
	{
		InitializeCheck();
	}
}

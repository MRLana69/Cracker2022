using System;
using Cpp2ILInjected;

public class CollectCoinsCell
{
	public CollectCoinsCellType cellType;

	public Friend friend;

	public CollectCoinsDummy dummyFriend;

	public bool useDarkColour;

	public bool disableScrolling;

	public Action OnUpdateCell;

	public void UpdateCell()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_0166: Expected Obj, but got I4
		//IL_0214: Expected Obj, but got I4
		//IL_0174: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got I4
		//IL_0190: Expected Obj, but got I4
		//IL_019e: Expected Obj, but got I4
		//IL_01ac: Expected Obj, but got I4
		//IL_01ba: Expected Obj, but got I4
		//IL_01c8: Expected Obj, but got I4
		//IL_01d6: Expected Obj, but got I4
		//IL_01e4: Expected Obj, but got I4
		//IL_01f2: Expected Obj, but got I4
		object obj = this - -64;
		object obj2 = obj - 1;
		NewMonoBehaviour newMonoBehaviour2;
		if ((nint)obj != 1)
		{
			if ((nint)obj2 != 1)
			{
				if ((nint)obj2 != 2)
				{
					if ((nint)obj2 != 3)
					{
						NewMonoBehaviour newMonoBehaviour;
						if ((nint)obj2 == 4)
						{
							newMonoBehaviour = (NewMonoBehaviour)17;
						}
						else if ((nint)obj2 == 5)
						{
							newMonoBehaviour = (NewMonoBehaviour)18;
						}
						else if ((nint)obj2 == 6)
						{
							newMonoBehaviour = (NewMonoBehaviour)19;
						}
						else if ((nint)obj2 == 7)
						{
							newMonoBehaviour = (NewMonoBehaviour)20;
						}
						else if ((nint)obj2 == 8)
						{
							newMonoBehaviour = (NewMonoBehaviour)21;
						}
						else if ((nint)obj2 == 9)
						{
							newMonoBehaviour = (NewMonoBehaviour)22;
						}
						else
						{
							newMonoBehaviour = (((nint)obj2 != 10) ? null : ((NewMonoBehaviour)23));
						}
						newMonoBehaviour._002Ector();
						return;
					}
					newMonoBehaviour2 = (NewMonoBehaviour)16;
				}
				else
				{
					newMonoBehaviour2 = (NewMonoBehaviour)15;
				}
			}
			else
			{
				newMonoBehaviour2 = (NewMonoBehaviour)14;
			}
		}
		else
		{
			newMonoBehaviour2 = (NewMonoBehaviour)28;
		}
		newMonoBehaviour2._002Ector();
		((NewMonoBehaviour)24)._002Ector();
	}

	public CollectCoinsCell()
	{
		if (OnUpdateCell != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}
}

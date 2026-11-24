using System;
using Cpp2ILInjected;
using Data.Save;
using UnityEngine;

namespace Info;

public class WelcomePopupTheme : ScriptableObject
{
	public Color backgroundColor;

	public Color textColor;

	private static WelcomePopupTheme _instance;

	public static WelcomePopupTheme instance
	{
		get
		{
			//IL_000a: Expected Obj, but got I4
			//IL_0018: Expected Obj, but got I4
			//IL_002b: Expected Obj, but got I4
			//IL_0039: Expected Obj, but got I4
			CollectCoinsDummy[] array = MigrationSave.ParseDummyData((string)6);
			CollectCoinsDummy[] array2 = MigrationSave.ParseDummyData((string)7);
			CollectCoinsDummy[] array3 = MigrationSave.ParseDummyData((string)8);
			CollectCoinsDummy[] array4 = MigrationSave.ParseDummyData((string)10);
			object obj = (object)array2 + (object)array;
			object obj2 = (object)array3 + obj;
			return (WelcomePopupTheme)(object)((object)array4 + obj2);
		}
	}

	static WelcomePopupTheme()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 400f;
		_ = 0.01f;
		_ = 6f;
		throw new ArrayTypeMismatchException();
	}
}

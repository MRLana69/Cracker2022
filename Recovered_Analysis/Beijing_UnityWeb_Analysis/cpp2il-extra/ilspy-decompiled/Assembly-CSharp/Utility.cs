using Cpp2ILInjected;
using UnityEngine;

public static class Utility
{
	public static void SetLayerRecursively(Transform t, int layer)
	{
	}

	public static int NumberOfDigits(int number)
	{
		//IL_01aa: Expected Obj, but got I4
		//IL_0021: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I4
		//IL_0093: Expected Obj, but got I4
		//IL_01d5: Expected I4, but got Obj
		//IL_00cc: Expected Obj, but got I4
		//IL_01fb: Expected I4, but got Obj
		//IL_0105: Expected Obj, but got I4
		//IL_018b: Expected I4, but got Obj
		//IL_013e: Expected Obj, but got I4
		string text;
		if (((string)number).EndsWith("TutorialCollectFromFriendsPopup"))
		{
			text = "GuidelineCollectPopup";
		}
		else if (((string)number).EndsWith("TutorialEndGameMissionsPopup"))
		{
			text = "GuidelineEndGameMissionPopup";
		}
		else if (((string)number).EndsWith("TutorialFacebookPopup"))
		{
			text = "GuidelineFacebook";
		}
		else if (((string)number).EndsWith("TutorialMissionPopup"))
		{
			text = "GuidelineMissionPopup";
		}
		else if (((string)number).EndsWith("PrivacyPolicyPopup"))
		{
			text = "PrivacyPolicyPopup";
		}
		else if (((string)number).EndsWith("TopRunPopup"))
		{
			text = "TopRunPopup";
		}
		else
		{
			bool flag = ((string)number).EndsWith("UpdateAppPopup");
			bool flag2 = !flag;
			bool flag3 = !flag2;
			text = "Update App";
			if (!flag3)
			{
				text = string.Empty;
			}
		}
		if (text.get_Chars((int)string.Empty) != '\0')
		{
			string text2 = string.ConcatArray((string[])(object)"POPUP Screen ", (int)text);
			text = text2;
		}
		return (int)text;
	}

	public static string NumberToStringFormat(int numberToFormat)
	{
		//IL_005e: Expected Obj, but got I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		int num = default;
		string text;
		if (num != 0)
		{
			text = null;
			int num2 = default;
			while (num2 != 0)
			{
				num2 = num / 10;
				string text2 = text + 1;
				text = text2;
			}
		}
		else
		{
			text = (string)1;
		}
		return text;
	}

	public static int CompareVersions(string leftVersion, string rightVersion)
	{
		if (rightVersion != null)
		{
			if ((nint)rightVersion != 1)
			{
				if ((nint)rightVersion != 2)
				{
					if ((nint)rightVersion == 3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [leftVersion @ L0 (System.String)+90]");
						return 0;
					}
					if ((nint)rightVersion != 4 && (nint)rightVersion != 5)
					{
						if ((nint)rightVersion != 6)
						{
							if ((nint)rightVersion != 7)
							{
								if ((nint)rightVersion != 8)
								{
									if ((nint)rightVersion != 9)
									{
										if ((nint)rightVersion != 10)
										{
											if ((nint)rightVersion != 11)
											{
												if ((nint)rightVersion != 12)
												{
													if ((nint)rightVersion != 13)
													{
														if ((nint)rightVersion != 14)
														{
															if ((nint)rightVersion != 15)
															{
																if ((nint)rightVersion != 16)
																{
																	if ((nint)rightVersion != 17)
																	{
																		if ((nint)rightVersion != 18)
																		{
																			if ((nint)rightVersion != 19)
																			{
																				if ((nint)rightVersion == 20)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [leftVersion @ L0 (System.String)+D0]");
																					return 0;
																				}
																				return 0;
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [leftVersion @ L0 (System.String)+CC]");
																			return 0;
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [leftVersion @ L0 (System.String)+C8]");
																		return 0;
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [leftVersion @ L0 (System.String)+C4]");
																	return 0;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [leftVersion @ L0 (System.String)+C0]");
																return 0;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [leftVersion @ L0 (System.String)+BC]");
															return 0;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [leftVersion @ L0 (System.String)+B8]");
														return 0;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [leftVersion @ L0 (System.String)+B0]");
													return 0;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [leftVersion @ L0 (System.String)+AC]");
												return 0;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [leftVersion @ L0 (System.String)+A4]");
											return 0;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [leftVersion @ L0 (System.String)+A8]");
										return 0;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [leftVersion @ L0 (System.String)+9C]");
									return 0;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [leftVersion @ L0 (System.String)+A0]");
								return 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [leftVersion @ L0 (System.String)+98]");
							return 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [leftVersion @ L0 (System.String)+94]");
						return 0;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [leftVersion @ L0 (System.String)+8C]");
				return 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [leftVersion @ L0 (System.String)+88]");
			return 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [leftVersion @ L0 (System.String)+B4]");
		return 0;
	}
}

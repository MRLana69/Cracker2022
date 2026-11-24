using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace ABTest;

public class ABTestData
{
	public class ABTestDataItem
	{
		public bool forceDisable;

		public string identifier;

		public string defaultPayload;

		public TestRange testRange;

		public string debugTitle;

		public List<string> debugPayload;
	}

	public const string ABTEST_AD_DOUBLE_COINS = "doublecoins";

	public const string ABTEST_TWO_KEYS = "twokeys";

	public const string ABTEST_MAIN_SCREEN_BUTTONS = "mainscreenbuttons";

	public const string ABTEST_WELCOME_PACK_PRICEPOINTS = "welcomepackprice";

	public const string ABTEST_DOUBLE_COINS_VIDEO = "doublecoinsvideo";

	public static readonly List<ABTestDataItem> testData;

	public ABTestData()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ABTest.ABTestData)+8]");
		((PropertyAttribute)(object)string.ConcatArray((string[])(object)"debug_payload_", 0))._002Ector();
	}

	static ABTestData()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0.05f;
		_ = 0f;
		throw new ArrayTypeMismatchException();
	}
}

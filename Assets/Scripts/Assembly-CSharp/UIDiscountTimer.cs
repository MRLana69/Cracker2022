using System;
using Cpp2ILInjected;
using Kiloo;
using UnityEngine;

public class UIDiscountTimer : MonoBehaviour
{
	private UILabel _timerLabel;

	private double endTimeDouble;

	private DateTime endTime;

	private TimeSpan timeLeft;

	private void Awake()
	{
		UILabel component = GetComponent<UILabel>();
		_timerLabel = component;
	}

	private unsafe void OnEnable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0075: Expected I8, but got I4
		//IL_0070: Expected native int or pointer, but got VT
		//IL_009c: Expected native int or pointer, but got VT
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected VT, but got Unknown
		//IL_003a: Expected Ref, but got VT
		object obj = default;
		DateTime dateTime = (DateTime)(obj - 16);
		_ = 0;
		double discountEndTime = InAppManager.GetDiscountEndTime();
		endTimeDouble = discountEndTime;
		((DateTime*)(nint)dateTime)->_dateData = 0uL;
		*(DateTime*)(nint)dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
		_ = dateTime._dateData;
		DateTime dateTime2 = dateTime + 8;
		DateTime dateTime3 = ((DateTime*)dateTime2)->AddSeconds(endTimeDouble);
		endTime = dateTime3;
	}

	private void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0028: Invalid comparison between VT and I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected Obj, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected Obj, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Obj, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected Obj, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected Obj, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected Obj, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected Obj, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected Obj, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected Obj, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected Obj, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected Obj, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		DateTime utcNow = CDateTime.UtcNow;
		TimeSpan timeSpan = endTime - utcNow;
		timeLeft = timeSpan;
		if (timeLeft >= (object)1)
		{
			object obj3 = timeLeft / 864000000000L;
			if ((nint)obj3 >= 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				object obj4 = timeLeft / 864000000000L;
				object obj5 = obj + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				throw new ArrayTypeMismatchException();
			}
			object obj6 = timeLeft / 36000000000L;
			object obj7 = obj6 / 24;
			object obj8 = obj7 * 24;
			object obj9 = obj6 - obj8;
			object obj10 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object obj11 = timeLeft / 600000000;
			object obj12 = obj11 / 60;
			object obj13 = obj12 * 60;
			object obj14 = obj11 - obj13;
			object obj15 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object obj16 = timeLeft / 10000000;
			object obj17 = obj16 / 60;
			object obj18 = obj17 * 60;
			object obj19 = obj16 - obj18;
			object obj20 = obj + 4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg = default;
			object arg2 = default;
			object arg3 = default;
			string text = $"{arg:00}:{arg2:00}:{arg3:00}";
			_timerLabel.text = text;
		}
		else
		{
			SendMessageUpwards("ForceEndDiscount", SendMessageOptions.DontRequireReceiver);
		}
	}
}

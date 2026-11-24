using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using InApp;
using Info;
using UnityEngine;
using UnityEngine.UI;

public class CelebrationBackgroundHelper : MonoBehaviour
{
	public Transform backgroundRoot;

	public Transform celebrationCloner;

	private bool shouldRotate;

	private AnimationCurve _bragCelebrationAnimationCurve;

	public bool visible
	{
		get
		{
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationBackgroundHelper)+44]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationBackgroundHelper)+44]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationBackgroundHelper)+44]");
					if ((nint)0 != 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationBackgroundHelper)+44]");
						if ((nint)0 != 3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationBackgroundHelper)+44]");
							if ((nint)0 != 4)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CelebrationBackgroundHelper)+44]");
								if ((nint)0 == 5)
								{
									SDebug.LogFormat("There are no more bundles to sell", null);
									return false;
								}
								object obj = this + 68;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
								throw new NullReferenceException();
							}
							return true;
						}
						return true;
					}
					return true;
				}
				return true;
			}
			return true;
		}
		set
		{
			//IL_0022: Expected Obj, but got I4
			//IL_0030: Expected Obj, but got I4
			((GameObject)(object)backgroundRoot).tag = (string)value;
			string text = (string)((value ? 1 : 0) ^ 1);
			((GameObject)(object)celebrationCloner).tag = text;
			Collider component = GetComponent<Collider>();
			component.isTrigger = value;
		}
	}

	public void Hide()
	{
		CancelInvoke();
	}

	public void Show(Quaternion rotation, bool shouldAnimateStripes, bool shouldRotateBackground)
	{
		//IL_013c: Expected I, but got Obj
		//IL_0152: Expected Obj, but got I
		//IL_0203: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0186: Expected I, but got Obj
		//IL_019c: Expected Obj, but got I
		//IL_01c7: Expected Obj, but got VT
		//IL_01e1: Expected Obj, but got VT
		//IL_01e1: Expected I4, but got Obj
		//IL_01e1: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v26 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76FE");
		IEnumerable<string> source = default;
		if (!Enumerable.Contains(source, (string)rotation))
		{
			return;
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v15 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v22 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		nint num5 = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v7 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v17 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		InAppItemModel inAppItemModel = InAppData.inAppData.get_Item((string)rotation);
		((UIScreenController)flag).ShowUnlockAnimationForHoverboardBundle((Boards.BoardId)inAppItemModel.bundleContents, (List<HoverboardThemes.ThemeIdentifier>)rotation);
		((BundlePurchaseButton)this).ShowBundleIcon();
	}

	public void SetParticleAnimationSpeed(float speed)
	{
		((Range)(object)this)._002Ector(speed, 1f);
	}

	public void InvertParticlesDirection(bool invert)
	{
		//IL_0017: Expected Obj, but got I4
		string text = tag;
		((GameObject)(object)text).tag = (string)invert;
	}

	public float GetBragCelebrationAnimationCurveValue(float pos)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return 0f;
	}

	private void Update()
	{
		InvertParticlesDirection(invert: false);
	}

	public CelebrationBackgroundHelper()
	{
		if (~(shouldRotate ? 1u : 0u) == 0)
		{
			float unscaledTime = Time.unscaledTime;
			float end = 45f * unscaledTime;
			((Dropdown)(object)backgroundRoot).AlphaFadeList(0f, 0f, end);
		}
	}
}

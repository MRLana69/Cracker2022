using System;
using Cpp2ILInjected;
using UI.FreeStuff;
using UnityEngine;

namespace UI.SlideIns;

public class UISlideInSpinner : UISlideIn
{
	private UILabel _messageLabel;

	private UISprite _spinner;

	private Transform _cachedSpinnerTransform;

	private readonly Vector3 _singleStepRotation;

	private const float SINGLE_STEP_THRESHOLD = 0.1f;

	private int _currentStep;

	private float _currentDuration;

	private const int STEP_COUNT = 8;

	private void SetupSlidein(string message)
	{
		//IL_008f: Expected Obj, but got I4
		//IL_009d: Expected I, but got Obj
		//IL_00b3: Expected Obj, but got I
		//IL_00ed: Expected I4, but got Obj
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_006a: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		string text = tag;
		((GameObject)(object)text).tag = (string)1;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v5 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v18 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Strings.GetDefault("SLIDE_IN_PAYOUT_RECEIVED");
		_messageLabel.fontSize = (int)text2;
		object obj2 = this - -64;
		((UILabel)obj2).fontSize = message.m_firstChar;
		((RewardForVideoButton)(object)_cachedSpinnerTransform).Init((VideoButtonPayload)null);
		((RewardForVideoButton)_singleStepRotation).Init(null);
		((UISlideInAdsRemoved)this).SetupSlideIn((SlideIn)null);
	}

	private void Update()
	{
		((UISlideInAdsRemoved)this)._002Ector();
	}

	public UISlideInSpinner()
	{
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_016c: Expected Obj, but got I4
		//IL_0180: Expected I, but got Obj
		//IL_0196: Expected Obj, but got I
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected I4, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 12;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v45 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_cachedSpinnerTransform != null)
		{
			object obj4 = this + 68;
			object obj5 = this - -64;
			Camera anchorCamera = ((UIRect)obj5).anchorCamera;
			obj4 = anchorCamera;
		}
		Transform transform = (Transform)(obj2 + 24);
		float unscaledTime = Time.unscaledTime;
		float currentDuration = _currentDuration + unscaledTime;
		_currentDuration = currentDuration;
		if (_currentDuration > 0.1f)
		{
			int currentStep = _currentStep + 1;
			_currentStep = currentStep;
			int num3 = _currentStep / 8;
			object obj6 = num3 * 8;
			int currentStep2 = _currentStep - obj6;
			_currentStep = currentStep2;
			object obj7 = this + 72;
			obj2 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v26+8]");
			_ = 0;
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			transform = (Transform)obj;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			_cachedSpinnerTransform.LookAt(transform);
			float currentDuration2 = _currentDuration - 0.1f;
			_currentDuration = currentDuration2;
		}
	}
}

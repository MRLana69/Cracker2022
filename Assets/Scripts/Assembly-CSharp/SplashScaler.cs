using System;
using Cpp2ILInjected;
using UnityEngine;

public class SplashScaler : MonoBehaviour
{
	private const float Y_SCALE = 1.775f;

	private bool passed;

	private UITexture _textureToScale;

	private bool repositionNow;

	private unsafe void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00fc: Expected I4, but got F8
		//IL_011d: Expected Obj, but got I4
		//IL_02e6: Expected native int or pointer, but got VT
		//IL_02fa: Expected native int or pointer, but got VT
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Expected VT, but got Unknown
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected VT, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 128);
		if (~(repositionNow ? 1u : 0u) == 0)
		{
			repositionNow = false;
			passed = false;
		}
		else if (passed)
		{
			return;
		}
		UITexture component = GetComponent<UITexture>();
		UIRect.AnchorPoint rightAnchor = component.rightAnchor;
		rightAnchor.target = null;
		UIRect.AnchorPoint leftAnchor = component.leftAnchor;
		leftAnchor.target = null;
		UIRect.AnchorPoint topAnchor = component.topAnchor;
		topAnchor.target = null;
		UIRect.AnchorPoint bottomAnchor = component.bottomAnchor;
		bottomAnchor.target = null;
		UITexture textureToScale = _textureToScale;
		float num = (float)((UIWidget)textureToScale).mWidth * 1.775f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num3 = default;
		double num2 = Math.Abs(num3);
		int height = ((!(num2 < 2147483648.0)) ? int.MinValue : ((int)num3));
		_textureToScale.height = height;
		RuntimePlatform runtimePlatform = Application.platform;
		if (runtimePlatform <= RuntimePlatform.IPhonePlayer)
		{
			object obj2 = runtimePlatform - 7;
			if ((nint)obj2 <= 1)
			{
				runtimePlatform = RuntimePlatform.OSXEditor;
			}
			if (runtimePlatform == RuntimePlatform.OSXEditor)
			{
				DeviceInfo instance = DeviceInfo.Instance;
				if (instance.formFactor__BackingField != DeviceInfo.FormFactor.iPhone)
				{
					if (instance.formFactor__BackingField != DeviceInfo.FormFactor.iPad)
					{
						if (instance.formFactor__BackingField != DeviceInfo.FormFactor.small && instance.formFactor__BackingField != DeviceInfo.FormFactor.medium && instance.formFactor__BackingField != DeviceInfo.FormFactor.large && (instance.formFactor__BackingField == DeviceInfo.FormFactor.iPhone5 || instance.formFactor__BackingField == DeviceInfo.FormFactor.iPhone6 || instance.formFactor__BackingField == DeviceInfo.FormFactor.iPhone6Plus || instance.formFactor__BackingField == DeviceInfo.FormFactor.iPhoneUnknown))
						{
							Transform transform = base.transform;
							_ = 0;
							_ = 0;
							_ = 0;
							_ = 0;
							Vector3 localPosition = vector + 48;
							transform.localPosition = localPosition;
						}
					}
					else
					{
						Transform transform2 = base.transform;
						_ = 0;
						_ = 0;
						_ = 4751297606875873280L;
						_ = 4751297606875873280L;
						Vector3 localPosition2 = vector + 32;
						transform2.localPosition = localPosition2;
					}
				}
				else
				{
					Transform transform3 = base.transform;
					_ = 0;
					_ = 0;
					_ = 4704009810788483072L;
					_ = 4704009810788483072L;
					Vector3 localPosition3 = vector + 16;
					transform3.localPosition = localPosition3;
				}
			}
		}
		else
		{
			bool flag = runtimePlatform != RuntimePlatform.Android;
			if (runtimePlatform == RuntimePlatform.MetroPlayerARM)
			{
				flag = false;
			}
			if (!flag)
			{
				Transform transform4 = base.transform;
				_ = 0;
				((Vector3*)(nint)vector)->z = 0f;
				_ = 0;
				((Vector3*)(nint)vector)->x = 0f;
				transform4.localPosition = vector;
			}
		}
		UIRect.AnchorPoint rightAnchor2 = component.rightAnchor;
		rightAnchor2.target = rightAnchor.target;
		UIRect.AnchorPoint leftAnchor2 = component.leftAnchor;
		leftAnchor2.target = rightAnchor.target;
		UIRect.AnchorPoint topAnchor2 = component.topAnchor;
		topAnchor2.target = rightAnchor.target;
		UIRect.AnchorPoint bottomAnchor2 = component.bottomAnchor;
		bottomAnchor2.target = rightAnchor.target;
		passed = true;
	}
}

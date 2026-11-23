using UnityEngine;

public class UIScaleDown3dModels : MonoBehaviour
{
	public enum ScaleAnchorType
	{
		CharacterAnchor,
		GameOverAnchor,
		TutorialPupupAnchor
	}

	public ScaleAnchorType anchorType;

	private unsafe void OnEnable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_002c: Expected native int or pointer, but got VT
		//IL_0044: Expected native int or pointer, but got VT
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected VT, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected VT, but got Unknown
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected VT, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected VT, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected VT, but got Unknown
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected VT, but got Unknown
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected VT, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected VT, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected VT, but got Unknown
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Expected VT, but got Unknown
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Expected VT, but got Unknown
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected VT, but got Unknown
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 448);
		DeviceInfo instance = DeviceInfo.Instance;
		if (instance.formFactor__BackingField == DeviceInfo.FormFactor.iPad)
		{
			Transform transform = base.transform;
			_ = 1063675494;
			((Vector3*)(nint)vector)->z = 0.9f;
			_ = 4568451461350319718L;
			((Vector3*)(nint)vector)->x = 0.9f;
			transform.localScale = vector;
			return;
		}
		DeviceInfo instance2 = DeviceInfo.Instance;
		if (instance2.formFactor__BackingField == DeviceInfo.FormFactor.iPhone5)
		{
			Transform transform2 = base.transform;
			_ = 1061158912;
			_ = 1061158912;
			_ = 4557642823960100864L;
			_ = 4557642823960100864L;
			Vector3 localScale = vector + 16;
			transform2.localScale = localScale;
			return;
		}
		DeviceInfo instance3 = DeviceInfo.Instance;
		if (instance3.formFactor__BackingField == DeviceInfo.FormFactor.small)
		{
			if (anchorType != ScaleAnchorType.CharacterAnchor)
			{
				if (anchorType != ScaleAnchorType.GameOverAnchor)
				{
					if (anchorType == ScaleAnchorType.TutorialPupupAnchor)
					{
						Transform transform3 = base.transform;
						_ = 1106247680;
						_ = 1106247680;
						_ = 4692750812837183488L;
						_ = 4692750812837183488L;
						Vector3 localPosition = vector - -64;
						transform3.localPosition = localPosition;
					}
				}
				else
				{
					Transform transform4 = base.transform;
					_ = 1106247680;
					_ = 1106247680;
					_ = 4692750814984667136L;
					_ = 4692750814984667136L;
					Vector3 localPosition2 = vector + 80;
					transform4.localPosition = localPosition2;
				}
			}
			else
			{
				Transform transform5 = base.transform;
				_ = 1101004800;
				_ = 1101004800;
				_ = -4459689527738368000L;
				_ = -4459689527738368000L;
				Vector3 localPosition3 = vector + 48;
				transform5.localPosition = localPosition3;
			}
			Transform transform6 = base.transform;
			_ = 1062836634;
			_ = 1062836634;
			_ = 4564848585083558298L;
			_ = 4564848585083558298L;
			Vector3 localScale2 = vector + 32;
			transform6.localScale = localScale2;
			return;
		}
		DeviceInfo instance4 = DeviceInfo.Instance;
		if (instance4.formFactor__BackingField == DeviceInfo.FormFactor.medium)
		{
			if (anchorType != ScaleAnchorType.CharacterAnchor)
			{
				if (anchorType != ScaleAnchorType.GameOverAnchor)
				{
					if (anchorType == ScaleAnchorType.TutorialPupupAnchor)
					{
						Transform transform7 = base.transform;
						_ = 1106247680;
						_ = 1106247680;
						_ = 4692750812837183488L;
						_ = 4692750812837183488L;
						Vector3 localPosition4 = vector + 128;
						transform7.localPosition = localPosition4;
					}
				}
				else
				{
					Transform transform8 = base.transform;
					_ = 1106247680;
					_ = 1106247680;
					_ = 4692750814984667136L;
					_ = 4692750814984667136L;
					Vector3 localPosition5 = vector + 144;
					transform8.localPosition = localPosition5;
				}
			}
			else
			{
				Transform transform9 = base.transform;
				_ = 1101004800;
				_ = 1101004800;
				_ = -4459689527738368000L;
				_ = -4459689527738368000L;
				Vector3 localPosition6 = vector + 112;
				transform9.localPosition = localPosition6;
			}
			Transform transform10 = base.transform;
			_ = 1062836634;
			_ = 1062836634;
			_ = 4564848585083558298L;
			_ = 4564848585083558298L;
			Vector3 localScale3 = vector + 96;
			transform10.localScale = localScale3;
			return;
		}
		DeviceInfo instance5 = DeviceInfo.Instance;
		if (instance5.formFactor__BackingField != DeviceInfo.FormFactor.large)
		{
			return;
		}
		if (anchorType != ScaleAnchorType.CharacterAnchor)
		{
			if (anchorType != ScaleAnchorType.GameOverAnchor)
			{
				if (anchorType == ScaleAnchorType.TutorialPupupAnchor)
				{
					Transform transform11 = base.transform;
					_ = 1106247680;
					_ = 1106247680;
					_ = 4692750812837183488L;
					_ = 4692750812837183488L;
					Vector3 localPosition7 = vector + 192;
					transform11.localPosition = localPosition7;
				}
			}
			else
			{
				Transform transform12 = base.transform;
				_ = 1106247680;
				_ = 1106247680;
				_ = 4692750814984667136L;
				_ = 4692750814984667136L;
				Vector3 localPosition8 = vector + 208;
				transform12.localPosition = localPosition8;
			}
		}
		else
		{
			Transform transform13 = base.transform;
			_ = 1101004800;
			_ = 1101004800;
			_ = -4459689527738368000L;
			_ = -4459689527738368000L;
			Vector3 localPosition9 = vector + 176;
			transform13.localPosition = localPosition9;
		}
		Transform transform14 = base.transform;
		_ = 1062836634;
		_ = 1062836634;
		_ = 4564848585083558298L;
		_ = 4564848585083558298L;
		Vector3 localScale4 = vector + 160;
		transform14.localScale = localScale4;
	}
}

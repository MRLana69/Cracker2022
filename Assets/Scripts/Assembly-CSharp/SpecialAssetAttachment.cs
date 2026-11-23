using Cpp2ILInjected;
using UnityEngine;

public class SpecialAssetAttachment : CharacterCustomizationProp
{
	public enum AttachmentPoint
	{
		LeftHand,
		RightHand,
		Head,
		AttachmentPoint1,
		AttachmentPoint2,
		AttachmentPoint3,
		AttachmentPoint4,
		AttachmentPoint5,
		AttachmentPoint6,
		AttachmentPoint7,
		AttachmentPoint8,
		AttachmentPoint9
	}

	private AttachmentPoint attachmentPoint;

	public unsafe override void Initialize(CharacterRig characterRig, bool alternateSetup)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected Obj, but got Unknown
		//IL_0372: Expected I, but got Obj
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected VT, but got Unknown
		//IL_03e7: Expected I, but got Obj
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected VT, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_045c: Expected I, but got Obj
		//IL_0481: Expected F4, but got I
		//IL_047c: Expected native int or pointer, but got VT
		//IL_048f: Expected F4, but got VT
		//IL_048a: Expected native int or pointer, but got VT
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected Obj, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected Obj, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected Obj, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected Obj, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected Obj, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected Obj, but got Unknown
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected Obj, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		object parent;
		Transform transform2;
		if (attachmentPoint != AttachmentPoint.LeftHand)
		{
			if (attachmentPoint != AttachmentPoint.RightHand)
			{
				if (attachmentPoint != AttachmentPoint.Head)
				{
					if (attachmentPoint != AttachmentPoint.AttachmentPoint1)
					{
						if (attachmentPoint != AttachmentPoint.AttachmentPoint2)
						{
							if (attachmentPoint != AttachmentPoint.AttachmentPoint3)
							{
								if (attachmentPoint != AttachmentPoint.AttachmentPoint4)
								{
									if (attachmentPoint != AttachmentPoint.AttachmentPoint5)
									{
										if (attachmentPoint != AttachmentPoint.AttachmentPoint6)
										{
											if (attachmentPoint != AttachmentPoint.AttachmentPoint7)
											{
												if (attachmentPoint != AttachmentPoint.AttachmentPoint8)
												{
													if (attachmentPoint != AttachmentPoint.AttachmentPoint9)
													{
														goto IL_0343;
													}
													Transform transform = base.transform;
													parent = characterRig + 196;
													transform2 = transform;
												}
												else
												{
													Transform transform3 = base.transform;
													parent = characterRig + 192;
													transform2 = transform3;
												}
											}
											else
											{
												Transform transform4 = base.transform;
												parent = characterRig + 188;
												transform2 = transform4;
											}
										}
										else
										{
											Transform transform5 = base.transform;
											parent = characterRig + 184;
											transform2 = transform5;
										}
									}
									else
									{
										Transform transform6 = base.transform;
										parent = characterRig + 180;
										transform2 = transform6;
									}
								}
								else
								{
									Transform transform7 = base.transform;
									parent = characterRig + 176;
									transform2 = transform7;
								}
							}
							else
							{
								Transform transform8 = base.transform;
								parent = characterRig + 172;
								transform2 = transform8;
							}
						}
						else
						{
							Transform transform9 = base.transform;
							parent = characterRig + 168;
							transform2 = transform9;
						}
					}
					else
					{
						Transform transform10 = base.transform;
						parent = characterRig + 164;
						transform2 = transform10;
					}
				}
				else
				{
					Transform transform11 = base.transform;
					parent = characterRig + 212;
					transform2 = transform11;
				}
			}
			else
			{
				Transform transform12 = base.transform;
				parent = characterRig + 216;
				transform2 = transform12;
			}
		}
		else
		{
			Transform transform13 = base.transform;
			parent = characterRig + 204;
			transform2 = transform13;
		}
		transform2.parent = (Transform)parent;
		goto IL_0343;
		IL_0343:
		Transform transform14 = base.transform;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v15 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v16 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Vector3 localPosition = vector + 32;
		transform14.localPosition = localPosition;
		Transform transform15 = base.transform;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v30 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v31 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		_ = Quaternion.identityQuaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_ = 0;
		Quaternion localRotation = (Quaternion)(vector + 16);
		transform15.localRotation = localRotation;
		Transform transform16 = base.transform;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S1_v31 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S1_v32 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
		transform16.localScale = vector;
	}
}

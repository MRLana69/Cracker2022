using System;
using Cpp2ILInjected;
using UnityEngine;

public class Spraycan : CharacterCustomizationProp
{
	public override void Initialize(CharacterRig characterRig, bool alternateSetup)
	{
		//IL_04fb: Expected I, but got Obj
		//IL_0511: Expected Obj, but got I
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected Obj, but got Unknown
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Expected Obj, but got Unknown
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected Obj, but got Unknown
		//IL_044a: Expected VT, but got Obj
		//IL_03e6: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Spraycan)+C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Spraycan)+C]");
			if ((nint)0 == 1)
			{
				GameObject gameObject = base.gameObject;
				((Transform)(object)gameObject).parentInternal = characterRig.rightHand;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Spraycan)+C]");
				if ((nint)0 == 2)
				{
					GameObject gameObject2 = base.gameObject;
					((Transform)(object)gameObject2).parentInternal = characterRig.headJoint;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Spraycan)+C]");
					if ((nint)0 == 3)
					{
						GameObject gameObject3 = base.gameObject;
						((Transform)(object)gameObject3).parentInternal = characterRig.attachPoint1;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Spraycan)+C]");
						if ((nint)0 == 4)
						{
							GameObject gameObject4 = base.gameObject;
							((Transform)(object)gameObject4).parentInternal = characterRig.attachPoint2;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Spraycan)+C]");
							if ((nint)0 == 5)
							{
								GameObject gameObject5 = base.gameObject;
								((Transform)(object)gameObject5).parentInternal = characterRig.attachPoint3;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Spraycan)+C]");
								if ((nint)0 == 6)
								{
									GameObject gameObject6 = base.gameObject;
									((Transform)(object)gameObject6).parentInternal = characterRig.attachPoint4;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Spraycan)+C]");
									if ((nint)0 == 7)
									{
										GameObject gameObject7 = base.gameObject;
										((Transform)(object)gameObject7).parentInternal = characterRig.attachPoint5;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Spraycan)+C]");
										if ((nint)0 == 8)
										{
											GameObject gameObject8 = base.gameObject;
											((Transform)(object)gameObject8).parentInternal = characterRig.attachPoint6;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Spraycan)+C]");
											if ((nint)0 == 9)
											{
												GameObject gameObject9 = base.gameObject;
												((Transform)(object)gameObject9).parentInternal = characterRig.attachPoint7;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Spraycan)+C]");
												if ((nint)0 == 10)
												{
													GameObject gameObject10 = base.gameObject;
													((Transform)(object)gameObject10).parentInternal = characterRig.attachPoint8;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Spraycan)+C]");
													if ((nint)0 == 11)
													{
														GameObject gameObject11 = base.gameObject;
														((Transform)(object)gameObject11).parentInternal = characterRig.attachPoint9;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		else
		{
			GameObject gameObject12 = base.gameObject;
			((Transform)(object)gameObject12).parentInternal = characterRig.leftFoot;
		}
		GameObject gameObject13 = base.gameObject;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v6 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v27 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 32;
		Vector3 one = Vector3.one;
		Transform transform = (Transform)(obj3 + 48);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v11+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		GameObject gameObject14 = base.gameObject;
		Transform transform3 = (Transform)(obj3 + 16);
		GameObject gameObject15 = base.gameObject;
		transform3.rotation = (Quaternion)gameObject15;
		transform = transform3;
		((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform3).m_CachedPtr;
		Vector3 localScale = transform.localScale;
		GameObject gameObject16 = base.gameObject;
		Vector3 forward = Vector3.forward;
		transform = (Transform)obj3;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		((Transform)(object)gameObject16).parent = transform;
	}
}

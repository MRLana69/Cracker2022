using System;
using Cpp2ILInjected;
using Data.Save;
using Info;
using SYBO.Subway.Pickups;
using UnityEngine;

namespace SYBO.Subway.StateSystem.States.Settings;

public class PogostickStateSettings : ScriptableSingleton<PogostickStateSettings>
{
	[Serializable]
	public class PickupWeight
	{
		public UpgradeType UpgradeType;

		public PickupType PickupType;

		public PickupWeight()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private float _jumpHeight = 2f;

	private float _jumpDistance = 200f;

	private float _characterChangeTrackLength;

	private float _finalJumpSpeed;

	private int _rows;

	private int _startRowPosition;

	private int _endRowPosition;

	private PickupWeight[] _pickupList;

	private AnimationCurve _jumpCurve;

	private AnimationCurve _cameraCurve;

	private AnimationCurve _cameraAimFollowCurve;

	private float _fadeInPosition;

	private float _hangtimePosition;

	private float _smoothCameraXDuration;

	private Vector3 _cameraAimOffset;

	public float JumpHeight => _jumpDistance;

	public float JumpDistance => _jumpHeight;

	public float CharacterChangeTrackLength => _jumpDistance;

	public float FinalJumpSpeed => _characterChangeTrackLength;

	public int Rows
	{
		get
		{
			//IL_0007: Expected I4, but got F4
			return (int)_characterChangeTrackLength;
		}
	}

	public int StartRowPosition => _rows;

	public int EndRowPosition => _startRowPosition;

	public PickupWeight[] PickupList
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (PickupWeight[])_endRowPosition;
		}
	}

	public AnimationCurve JumpCurve => (AnimationCurve)(object)_pickupList;

	public AnimationCurve CameraCurve => _jumpCurve;

	public AnimationCurve CameraAimFollowCurve => _cameraCurve;

	public float FadeInPosition => _finalJumpSpeed;

	public float HangtimePosition => _fadeInPosition;

	public float SmoothCameraXDuration => _hangtimePosition;

	public Vector3 CameraAimOffset
	{
		get
		{
			//IL_0139: Expected I, but got Obj
			//IL_014f: Expected Obj, but got I
			//IL_0177: Expected VT, but got Obj
			//IL_00d2: Expected VT, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_005a: Expected Obj, but got I
			//IL_0085: Expected I, but got Obj
			if ((object)this != null && OnboardingSave.numberOfRunsSinceLastGuideline == 0)
			{
				nint num = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20 (Il2CppClass<Flurry>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (Il2CppClass<Flurry>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
			}
			nint num3 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v8 (Il2CppClass<Flurry>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				Vector3 vector = (Vector3)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v12 (UnityEngine.Vector3)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (Vector3)typeof(Flurry);
		}
	}

	public PogostickStateSettings()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724B");
	}
}

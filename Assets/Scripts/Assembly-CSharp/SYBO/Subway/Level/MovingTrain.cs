using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Subway.Characters;
using UnityEngine;

namespace SYBO.Subway.Level;

public class MovingTrain : MonoBehaviour
{
	private Transform _characterControllerTransform;

	private float speed = 1f;

	private float trainCount;

	private static float autoPilotActivationDistance = 200f;

	private AudioClip trianPassClip;

	private static MovingTrainUpdater _updater = null;

	private static HashSet<MovingTrain> _activeTrains;

	private Transform _transform;

	private Transform _train;

	private BoxCollider _trainCollider;

	private Vector3 _trainColliderInitialSize;

	private TrackObject _trackObject;

	private bool _active;

	private bool _autoPilot;

	private bool _initalized;

	private float _distanceToCameraZ;

	public float Speed
	{
		get
		{
			return speed;
		}
		set
		{
			if (speed != value)
			{
				speed = value;
				if (Application.isPlaying)
				{
					CheckInitialize();
					UpdateTrainCollider();
				}
			}
		}
	}

	public bool Active => _active;

	public float DistanceToCameraZ => _distanceToCameraZ;

	public static int GetActiveTrainCount()
	{
		HashSet<MovingTrain> activeTrains = _activeTrains;
		return activeTrains._count;
	}

	private void Awake()
	{
		CheckInitialize();
	}

	private unsafe void CheckInitialize()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_01cf: Expected I, but got Obj
		//IL_023a: Expected F4, but got I
		//IL_0235: Expected native int or pointer, but got VT
		//IL_0259: Expected F4, but got I
		//IL_0254: Expected native int or pointer, but got VT
		//IL_0129: Expected VT, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj + -64);
		if (!_initalized && Game.IsInstantiated)
		{
			if (_updater == null)
			{
				GameObject gameObject = default;
				gameObject._002Ector("MovingTrainUpdater");
				MovingTrainUpdater updater = gameObject.AddComponent<MovingTrainUpdater>();
				_updater = updater;
				_updater.SetAudioClip(trianPassClip);
			}
			Transform transform = base.transform;
			_transform = transform;
			int childCount = _transform.childCount;
			Transform child = _transform.GetChild(0);
			_train = child;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v40 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num2 = 0;
			float num3 = (float)Vector3.upVector * -200f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v41 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
			float num4 = 0f * -200f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v41 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
			float num5 = 0f * -200f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			((Vector3*)(nint)vector)->x = 0f;
			_train.localPosition = vector;
			BoxCollider component = GetComponent<BoxCollider>();
			_trainCollider = component;
			Vector3 size = _trainCollider.size;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			_trainColliderInitialSize = (Vector3)0;
			_active = false;
			TrackObject component2 = GetComponent<TrackObject>();
			_trackObject = component2;
			Action action = default;
			action._002Ector(this, (nint)__ldftn(MovingTrain.OnActivate));
			_trackObject.OnActivate += action;
			Action action2 = default;
			action2._002Ector(this, (nint)__ldftn(MovingTrain.OnDeactivate));
			_trackObject.OnDeactivate += action2;
			UpdateTrainCollider();
			_initalized = true;
		}
	}

	private unsafe void OnDestroy()
	{
		if (_trackObject != null)
		{
			Action action = default;
			action._002Ector(this, (nint)__ldftn(MovingTrain.OnActivate));
			_trackObject.OnActivate -= action;
			Action action2 = default;
			action2._002Ector(this, (nint)__ldftn(MovingTrain.OnDeactivate));
			_trackObject.OnDeactivate -= action2;
		}
	}

	private unsafe void UpdateTrainCollider()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected VT, but got Unknown
		//IL_00d1: Expected F4, but got I
		//IL_00cc: Expected native int or pointer, but got VT
		//IL_00e4: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj + -64);
		float num = speed + 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.MovingTrain)+30]");
		float num2 = 0f / num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		_ = _trainColliderInitialSize;
		_ = _trainColliderInitialSize;
		Vector3 size = vector + 16;
		_trainCollider.size = size;
		float num3 = trainCount * 30f;
		float num4 = num3 + 1f;
		float num5 = speed + 1f;
		float num6 = num4 / num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		((Vector3*)(nint)vector)->z = 0f;
		_ = 4716169528923389952L;
		((Vector3*)(nint)vector)->x = 0f;
		_trainCollider.center = vector;
	}

	private unsafe void OnActivate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00f7: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I
		//IL_00a7: Expected F4, but got I
		//IL_00a2: Expected native int or pointer, but got VT
		//IL_00b6: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		_trainCollider.enabled = true;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.HashSet`1<SYBO.Subway.Level.MovingTrain>>)+3C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ S3_v4+4] (should have been resolved before IL gen)");
		_updater.AddMovingTrain(this);
		_active = true;
		Vector3 position = _transform.position;
		Character instance = Character.Instance;
		Transform transform = instance._characterController.transform;
		Vector3 position2 = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		object obj3 = num3 - 0;
		float num4 = (float)obj3 * speed;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		_ = 0;
		((Vector3*)(nint)vector)->x = 0f;
		_train.localPosition = vector;
	}

	public unsafe void UpdateMovingTrain(float gameSpeed, float characterPositionZ, float cameraPositionZ)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00ce: Expected F4, but got I
		//IL_00c9: Expected native int or pointer, but got VT
		//IL_00dd: Expected native int or pointer, but got VT
		//IL_0105: Expected I, but got Obj
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		Vector3 position = _transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		float value = 0f - cameraPositionZ;
		float distanceToCameraZ = Math.Abs(value);
		_distanceToCameraZ = distanceToCameraZ;
		if (~(_autoPilot ? 1u : 0u) == 0)
		{
			Vector3 position2 = _train.position;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v33 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num2 = 0;
			float deltaTime = Time.deltaTime;
			float num3 = (float)Vector3.forwardVector * deltaTime;
			float num4 = num3 * gameSpeed;
			float num5 = num4 * speed;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v34 (Il2CppStaticFields<UnityEngine.Vector3>)+50]");
			float num6 = 0f * deltaTime;
			float num7 = num6 * gameSpeed;
			float num8 = num7 * speed;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			float num9 = 0f - num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v34 (Il2CppStaticFields<UnityEngine.Vector3>)+4C]");
			float num10 = 0f * deltaTime;
			float num11 = num10 * gameSpeed;
			float num12 = num11 * speed;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
			float num13 = 0f - num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			float num14 = 0f - num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			Vector3 position3 = vector + 16;
			_train.position = position3;
		}
		else
		{
			Vector3 position4 = _transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			float num15 = 0f - characterPositionZ;
			float num16 = num15 * speed;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			((Vector3*)(nint)vector)->z = 0f;
			_ = 0;
			((Vector3*)(nint)vector)->x = 0f;
			_train.localPosition = vector;
		}
	}

	public unsafe Vector3 GetTrainModelPosition()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0032: Expected F4, but got I
		//IL_002d: Expected native int or pointer, but got VT
		//IL_003f: Expected F4, but got Obj
		//IL_003a: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		Vector3 position = _train.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		Vector3 vector = default;
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj;
		return vector;
	}

	private unsafe void OnDeactivate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0050: Expected I, but got Obj
		//IL_00bb: Expected F4, but got I
		//IL_00b6: Expected native int or pointer, but got VT
		//IL_00da: Expected F4, but got I
		//IL_00d5: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		bool flag = _activeTrains.Remove(this);
		_updater.RemoveMovingTrain(this);
		_active = false;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v26 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		float num3 = (float)Vector3.upVector * -100f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v27 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
		float num4 = 0f * -100f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v27 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
		float num5 = 0f * -100f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		_train.localPosition = vector;
	}

	public new int GetHashCode()
	{
		int instanceID = GetInstanceID();
		return instanceID * 29;
	}

	public new bool Equals(object o)
	{
		return this == o;
	}

	public unsafe static void ActivateAutoPilot()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		//IL_075f: Expected Obj, but got Unknown
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Expected Obj, but got Unknown
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07db: Expected Obj, but got Unknown
		//IL_07b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Expected Obj, but got Unknown
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_005c: Expected Obj, but got I
		//IL_082b: Expected Obj, but got I
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected Obj, but got Unknown
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected VT, but got Unknown
		//IL_0411: Expected Ref, but got VT
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Expected Obj, but got Unknown
		//IL_051c: Expected Obj, but got I
		//IL_0525: Invalid comparison between F4 and Obj
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8A9");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj4 = obj - -64;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7;
		object obj10 = default;
		object obj11 = default;
		object obj15 = default;
		object obj16 = default;
		object obj18 = default;
		object obj19 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj6 == null;
				obj7 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				object obj8 = obj - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v71+C]");
				object obj9 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (obj10 != null)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										continue;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							else
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											if (obj11 != null)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														continue;
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											}
											else
											{
												_ = 0;
												object obj12 = obj + 8;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
													_ = 0;
													_ = 0;
													Bounds bounds = (Bounds)(obj + 40);
													Vector3 min = ((Bounds*)bounds)->min;
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															_ = 0;
															object obj13 = obj + 8;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																if ((nint)0 != 1)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
																	nint num = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
																	object obj14 = num - 0;
																	if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)autoPilotActivationDistance) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14))
																	{
																		continue;
																	}
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																	if ((nint)0 != 1)
																	{
																		_ = 1;
																		continue;
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																}
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
															}
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														}
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
													}
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												}
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj15 == obj16;
			bool flag3 = !flag2;
			object obj17 = obj18;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj7 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj17 = obj19;
			}
			_ = 0;
			object obj20 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj7 = 0;
			break;
		}
		object obj21 = obj7 + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A493");
	}

	static MovingTrain()
	{
		HashSet<MovingTrain> hashSet = default;
		hashSet._002Ector();
		_activeTrains = hashSet;
	}
}

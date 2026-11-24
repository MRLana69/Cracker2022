using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using UnityEngine;

public class BoardAnimation : MonoBehaviour
{
	private sealed class _003CBoardFloating_003Ed__20(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public BoardAnimation _003C_003E4__this;

		private float _003CcurrentxPositionSpeedDuration_003E5__2;

		private float _003CcurrentyPositionSpeedDuration_003E5__3;

		private float _003CcurrentzPositionSpeedDuration_003E5__4;

		private float _003CcurrentxRotationSpeedDuration_003E5__5;

		private float _003CcurrentyRotationSpeedDuration_003E5__6;

		private float _003CcurrentzRotationSpeedDuration_003E5__7;

		private float _003CxPositionTimeMultiplier_003E5__8;

		private float _003CyPositionTimeMultiplier_003E5__9;

		private float _003CzPositionTimeMultiplier_003E5__10;

		private float _003CxRotationTimeMultiplier_003E5__11;

		private float _003CyRotationTimeMultiplier_003E5__12;

		private float _003CzRotationTimeMultiplier_003E5__13;

		private float _003CxPositionPositionModifer_003E5__14;

		private float _003CyPositionPositionModifer_003E5__15;

		private float _003CzPositionPositionModifer_003E5__16;

		private float _003CxRotationPositionModifer_003E5__17;

		private float _003CyRotationPositionModifer_003E5__18;

		private float _003CzRotationPositionModifer_003E5__19;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_07e5: Expected VT, but got Unknown
				//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
				//IL_07f3: Expected VT, but got Unknown
				//IL_07fc: Unknown result type (might be due to invalid IL or missing references)
				//IL_0801: Expected Obj, but got Unknown
				//IL_080a: Unknown result type (might be due to invalid IL or missing references)
				//IL_080f: Expected Obj, but got Unknown
				//IL_0818: Unknown result type (might be due to invalid IL or missing references)
				//IL_081d: Expected Obj, but got Unknown
				//IL_0826: Expected Obj, but got I4
				//IL_0835: Unknown result type (might be due to invalid IL or missing references)
				//IL_083a: Expected Obj, but got Unknown
				//IL_0843: Expected Obj, but got I4
				//IL_006d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0072: Expected Obj, but got Unknown
				//IL_008e: Expected Obj, but got I4
				//IL_011d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0122: Expected Obj, but got Unknown
				//IL_012b: Expected Obj, but got F4
				//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_03cd: Expected Obj, but got Unknown
				//IL_0405: Expected I, but got Obj
				//IL_041b: Expected Obj, but got I
				//IL_09ba: Expected Obj, but got F4
				//IL_0a97: Unknown result type (might be due to invalid IL or missing references)
				//IL_0a9c: Expected Obj, but got Unknown
				//IL_0abe: Expected F4, but got Obj
				//IL_0ab9: Expected native int or pointer, but got VT
				//IL_0ad3: Expected F4, but got I
				//IL_0ace: Expected native int or pointer, but got VT
				//IL_0ae0: Expected F4, but got Obj
				//IL_0adb: Expected native int or pointer, but got VT
				//IL_0af5: Expected F4, but got I
				//IL_0af0: Expected native int or pointer, but got VT
				//IL_0b13: Expected F4, but got Obj
				//IL_0b0e: Expected native int or pointer, but got VT
				//IL_0b28: Expected F4, but got I
				//IL_0b23: Expected native int or pointer, but got VT
				//IL_0b31: Expected Obj, but got VT
				//IL_0446: Expected I, but got Obj
				//IL_058a: Unknown result type (might be due to invalid IL or missing references)
				//IL_058f: Expected Obj, but got Unknown
				//IL_0598: Expected Obj, but got F4
				//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_05d5: Expected Obj, but got Unknown
				//IL_05de: Expected Obj, but got F4
				//IL_06af: Unknown result type (might be due to invalid IL or missing references)
				//IL_06b4: Expected Obj, but got Unknown
				//IL_0700: Expected I, but got Obj
				//IL_0716: Expected Obj, but got I
				//IL_0c83: Expected Obj, but got F4
				//IL_0d60: Unknown result type (might be due to invalid IL or missing references)
				//IL_0d65: Expected Obj, but got Unknown
				//IL_0d87: Expected F4, but got Obj
				//IL_0d82: Expected native int or pointer, but got VT
				//IL_0d9c: Expected F4, but got I
				//IL_0d97: Expected native int or pointer, but got VT
				//IL_0da9: Expected F4, but got Obj
				//IL_0da4: Expected native int or pointer, but got VT
				//IL_0dbe: Expected F4, but got I
				//IL_0db9: Expected native int or pointer, but got VT
				//IL_0ddd: Expected I, but got Obj
				//IL_0df3: Expected Obj, but got I
				//IL_0e1d: Expected F4, but got Obj
				//IL_0e18: Expected native int or pointer, but got VT
				//IL_0e32: Expected F4, but got I
				//IL_0e2d: Expected native int or pointer, but got VT
				//IL_0e3f: Expected Ref, but got VT
				//IL_0e3f: Expected Ref, but got VT
				//IL_0e4c: Expected native int or pointer, but got VT
				//IL_0e5e: Expected native int or pointer, but got VT
				//IL_0e6c: Expected Obj, but got VT
				//IL_0e76: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e7b: Expected Obj, but got Unknown
				//IL_0e84: Expected Obj, but got I4
				//IL_0e98: Expected Obj, but got I4
				//IL_0741: Expected I, but got Obj
				//IL_078e: Expected I, but got Obj
				object obj = default;
				Vector3 vector = (Vector3)(obj + 80);
				Vector3 vector2 = (Vector3)(obj - -64);
				object obj2 = obj + 24;
				object obj3 = obj + 12;
				object obj4 = obj + 48;
				obj4 = 0;
				_ = 0;
				object obj5 = obj + 36;
				obj5 = 0;
				_ = 0;
				BoardAnimation boardAnimation = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							return null;
						}
						_003C_003E1__state = -1;
					}
					else
					{
						_003C_003E1__state = -1;
						_003CcurrentxPositionSpeedDuration_003E5__2 = 0f;
						_003CcurrentyPositionSpeedDuration_003E5__3 = 0f;
						_003CcurrentzPositionSpeedDuration_003E5__4 = 0f;
						_003CcurrentxRotationSpeedDuration_003E5__5 = 0f;
						_003CcurrentyRotationSpeedDuration_003E5__6 = 0f;
						_003CcurrentzRotationSpeedDuration_003E5__7 = 0f;
						_003CxPositionTimeMultiplier_003E5__8 = 1f;
						_003CyPositionTimeMultiplier_003E5__9 = 1f;
						_003CzPositionTimeMultiplier_003E5__10 = 1f;
						_003CxRotationTimeMultiplier_003E5__11 = 1f;
						_003CyRotationTimeMultiplier_003E5__12 = 1f;
						object obj6 = this - -64;
						obj6 = 1f;
						_003CxPositionPositionModifer_003E5__14 = 1f;
						_003CyPositionPositionModifer_003E5__15 = 1f;
						_003CzPositionPositionModifer_003E5__16 = 1f;
						_003CxRotationPositionModifer_003E5__17 = 1f;
						_003CyRotationPositionModifer_003E5__18 = 1f;
						_003CzRotationPositionModifer_003E5__19 = 1f;
					}
					if (~(boardAnimation._animateFloating ? 1u : 0u) == 0)
					{
						if (_003CcurrentxPositionSpeedDuration_003E5__2 > 1f)
						{
							_003CxPositionTimeMultiplier_003E5__8 = -1f;
						}
						else if (_003CcurrentxPositionSpeedDuration_003E5__2 < 0f)
						{
							_003CxPositionTimeMultiplier_003E5__8 = 1f;
							float num = _003CxPositionPositionModifer_003E5__14 * -1f;
							_003CxPositionPositionModifer_003E5__14 = num;
						}
						if (_003CcurrentyPositionSpeedDuration_003E5__3 > 1f)
						{
							_003CyPositionTimeMultiplier_003E5__9 = -1f;
						}
						else if (_003CcurrentyPositionSpeedDuration_003E5__3 < 0f)
						{
							_003CyPositionTimeMultiplier_003E5__9 = 1f;
							float num2 = _003CyPositionPositionModifer_003E5__15 * -1f;
							_003CyPositionPositionModifer_003E5__15 = num2;
						}
						if (_003CcurrentzPositionSpeedDuration_003E5__4 > 1f)
						{
							_003CzPositionTimeMultiplier_003E5__10 = -1f;
						}
						else if (_003CcurrentzPositionSpeedDuration_003E5__4 < 0f)
						{
							_003CzPositionTimeMultiplier_003E5__10 = 1f;
							float num3 = _003CzPositionPositionModifer_003E5__16 * -1f;
							_003CzPositionPositionModifer_003E5__16 = num3;
						}
						float num4 = Mathf.Clamp(_003CcurrentxPositionSpeedDuration_003E5__2, 0f, 1f);
						_003CcurrentxPositionSpeedDuration_003E5__2 = num4;
						float num5 = Mathf.Clamp(_003CcurrentyPositionSpeedDuration_003E5__3, 0f, 1f);
						_003CcurrentyPositionSpeedDuration_003E5__3 = num5;
						float num6 = Mathf.Clamp(_003CcurrentzPositionSpeedDuration_003E5__4, 0f, 1f);
						_003CcurrentzPositionSpeedDuration_003E5__4 = num6;
						float fixedDeltaTime = Time.fixedDeltaTime;
						float num7 = fixedDeltaTime * _003CxPositionTimeMultiplier_003E5__8;
						float num8 = num7 * boardAnimation.xPositionSpeed;
						float num9 = _003CcurrentxPositionSpeedDuration_003E5__2 + num8;
						_003CcurrentxPositionSpeedDuration_003E5__2 = num9;
						float fixedDeltaTime2 = Time.fixedDeltaTime;
						float num10 = fixedDeltaTime2 * _003CyPositionTimeMultiplier_003E5__9;
						float num11 = num10 * boardAnimation.yPositionSpeed;
						float num12 = _003CcurrentyPositionSpeedDuration_003E5__3 + num11;
						_003CcurrentyPositionSpeedDuration_003E5__3 = num12;
						float fixedDeltaTime3 = Time.fixedDeltaTime;
						float num13 = fixedDeltaTime3 * _003CzPositionTimeMultiplier_003E5__10;
						object obj7 = boardAnimation - -64;
						float num14 = num13 * (float)obj7;
						float num15 = _003CcurrentzPositionSpeedDuration_003E5__4 + num14;
						_003CcurrentzPositionSpeedDuration_003E5__4 = num15;
						nint num16 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S0_v60 (Il2CppClass<UnityEngine.Vector3>)+BA]");
						object obj8 = (nint)0 & (nint)0x200;
						if (obj8 != null)
						{
							nint num17 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S0_v131 (Il2CppClass<UnityEngine.Vector3>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Vector3 one = Vector3.one;
						obj4 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
						_ = 0;
						float num18 = _003CcurrentxPositionSpeedDuration_003E5__2 - 1f;
						float num19 = num18 * num18;
						float num20 = num19 * num18;
						float num21 = num20 + 1f;
						float num22 = boardAnimation.xPositiondifference * num21;
						float num23 = num22 * _003CxPositionPositionModifer_003E5__14;
						obj4 = num23;
						float num24 = _003CcurrentyPositionSpeedDuration_003E5__3 - 1f;
						float num25 = num24 * num24;
						float num26 = num25 * num24;
						float num27 = num26 + 1f;
						float num28 = boardAnimation.yPositiondifference * num27;
						float num29 = num28 * _003CyPositionPositionModifer_003E5__15;
						float num30 = _003CcurrentzPositionSpeedDuration_003E5__4 - 1f;
						float num31 = num30 * num30;
						float num32 = num31 * num30;
						float num33 = num32 + 1f;
						float num34 = boardAnimation.zPositiondifference * num33;
						float num35 = num34 * _003CzPositionPositionModifer_003E5__16;
						object obj9 = boardAnimation + 20;
						obj3 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ S2_v45+8]");
						_ = 0;
						((Vector3*)(nint)vector2)->x = (float)obj3;
						Vector3 vector3 = vector2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
						((Vector3*)(nint)vector3)->z = 0f;
						((Vector3*)(nint)vector)->x = (float)obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
						((Vector3*)(nint)vector)->z = 0f;
						Vector3 vector4 = vector2 - vector;
						((Vector3*)(nint)vector)->x = (float)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						((Vector3*)(nint)vector)->z = 0f;
						Vector3 eulerAngles = ((Transform)vector).eulerAngles;
						if (!(_003CcurrentxRotationSpeedDuration_003E5__5 < 1f))
						{
							_003CxRotationTimeMultiplier_003E5__11 = -1f;
						}
						else if (!(_003CcurrentxRotationSpeedDuration_003E5__5 > 0f))
						{
							_003CxRotationTimeMultiplier_003E5__11 = 1f;
							float num36 = _003CxRotationPositionModifer_003E5__17 * -1f;
							_003CxRotationPositionModifer_003E5__17 = num36;
						}
						if (!(_003CcurrentyRotationSpeedDuration_003E5__6 < 1f))
						{
							_003CyRotationTimeMultiplier_003E5__12 = -1f;
						}
						else if (!(_003CcurrentyRotationSpeedDuration_003E5__6 > 0f))
						{
							_003CyRotationTimeMultiplier_003E5__12 = 1f;
							float num37 = _003CyRotationPositionModifer_003E5__18 * -1f;
							_003CyRotationPositionModifer_003E5__18 = num37;
						}
						if (!(_003CcurrentzRotationSpeedDuration_003E5__7 < 1f))
						{
							object obj10 = this - -64;
							obj10 = -1f;
						}
						else if (!(_003CcurrentzRotationSpeedDuration_003E5__7 > 0f))
						{
							object obj11 = this - -64;
							obj11 = 1f;
							float num38 = _003CzRotationPositionModifer_003E5__19 * -1f;
							_003CzRotationPositionModifer_003E5__19 = num38;
						}
						float num39 = Mathf.Clamp(_003CcurrentxRotationSpeedDuration_003E5__5, 0f, 1f);
						_003CcurrentxRotationSpeedDuration_003E5__5 = num39;
						float num40 = Mathf.Clamp(_003CcurrentyRotationSpeedDuration_003E5__6, 0f, 1f);
						_003CcurrentyRotationSpeedDuration_003E5__6 = num40;
						float num41 = Mathf.Clamp(_003CcurrentzRotationSpeedDuration_003E5__7, 0f, 1f);
						_003CcurrentzRotationSpeedDuration_003E5__7 = num41;
						float fixedDeltaTime4 = Time.fixedDeltaTime;
						float num42 = fixedDeltaTime4 * _003CxRotationTimeMultiplier_003E5__11;
						float num43 = num42 * boardAnimation.xRotationSpeed;
						float num44 = _003CcurrentxRotationSpeedDuration_003E5__5 + num43;
						_003CcurrentxRotationSpeedDuration_003E5__5 = num44;
						float fixedDeltaTime5 = Time.fixedDeltaTime;
						float num45 = fixedDeltaTime5 * _003CyRotationTimeMultiplier_003E5__12;
						float num46 = num45 * boardAnimation.yRotationSpeed;
						float num47 = _003CcurrentyRotationSpeedDuration_003E5__6 + num46;
						_003CcurrentyRotationSpeedDuration_003E5__6 = num47;
						float fixedDeltaTime6 = Time.fixedDeltaTime;
						object obj12 = this - -64;
						float num48 = fixedDeltaTime6 * (float)obj12;
						float num49 = num48 * boardAnimation.zRotationSpeed;
						float num50 = _003CcurrentzRotationSpeedDuration_003E5__7 + num49;
						_003CcurrentzRotationSpeedDuration_003E5__7 = num50;
						nint num51 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ S0_v91 (Il2CppClass<UnityEngine.Vector3>)+BA]");
						object obj13 = (nint)0 & (nint)0x200;
						if (obj13 != null)
						{
							nint num52 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ S0_v107 (Il2CppClass<UnityEngine.Vector3>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Vector3 one2 = Vector3.one;
						obj5 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
						_ = 0;
						float num53 = _003CcurrentxRotationSpeedDuration_003E5__5 - 1f;
						float num54 = num53 * num53;
						float num55 = num54 * num53;
						float num56 = num55 + 1f;
						float num57 = boardAnimation.xRotationDifference * num56;
						float num58 = num57 * _003CxRotationPositionModifer_003E5__17;
						obj5 = num58;
						float num59 = _003CcurrentyRotationSpeedDuration_003E5__6 - 1f;
						float num60 = num59 * num59;
						float num61 = num60 * num59;
						float num62 = num61 + 1f;
						float num63 = boardAnimation.yRotationDifference * num62;
						float num64 = num63 * _003CyRotationPositionModifer_003E5__18;
						float num65 = _003CcurrentzRotationSpeedDuration_003E5__7 - 1f;
						float num66 = num65 * num65;
						float num67 = num66 * num65;
						float num68 = num67 + 1f;
						float num69 = boardAnimation.zRotationDifference * num68;
						float num70 = num69 * _003CzRotationPositionModifer_003E5__19;
						object obj14 = boardAnimation + 32;
						obj3 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ S2_v106+8]");
						_ = 0;
						((Vector3*)(nint)vector2)->x = (float)obj3;
						Vector3 vector5 = vector2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
						((Vector3*)(nint)vector5)->z = 0f;
						((Vector3*)(nint)vector)->x = (float)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v20+8]");
						((Vector3*)(nint)vector)->z = 0f;
						Vector3 vector6 = vector2 - vector;
						nint num71 = (nint)typeof(Quaternion);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ S1_v123 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
						object obj15 = (nint)0 & (nint)0x200;
						if (obj15 != null)
						{
							nint num72 = (nint)typeof(Quaternion);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ S1_v136 (Il2CppClass<UnityEngine.Quaternion>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						((Vector3*)(nint)vector)->x = (float)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						((Vector3*)(nint)vector)->z = 0f;
						Quaternion.Inverse_Injected(ref *(Quaternion*)vector2, out *(Quaternion*)vector);
						((Vector3*)(nint)vector)->x = vector2.x;
						((Vector3*)(nint)vector)->z = vector2.z;
						Quaternion localRotation = ((Transform)vector).localRotation;
						object obj16 = this + 12;
						obj16 = 0;
						_003C_003E1__state = 2;
						return 1;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = boardAnimation.delay;
				object obj17 = this + 12;
				object obj18 = default;
				obj17 = obj18;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private bool _animateFloating;

	private Transform boardObject;

	private Vector3 startPosition;

	private Vector3 startRotation;

	private float xPositiondifference;

	private float yPositiondifference;

	private float zPositiondifference;

	private float xPositionSpeed;

	private float yPositionSpeed;

	private float zPositionSpeed;

	private float xRotationDifference;

	private float yRotationDifference;

	private float zRotationDifference;

	private float xRotationSpeed;

	private float yRotationSpeed;

	private float zRotationSpeed;

	private float delay;

	private bool set;

	private void Start()
	{
		CancelInvoke();
	}

	private void Init(Transform transform)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001d: Expected Obj, but got I4
		//IL_003d: Expected Obj, but got VT
		string text = (string)(transform ^ 1);
		((GameObject)_animateFloating).tag = text;
		((GameObject)(object)boardObject).tag = (string)(object)transform;
		((GameObject)startPosition).tag = null;
	}

	private IEnumerator BoardFloating()
	{
		//IL_006a: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		int num = UnityEngine.Random.RandomRangeInt(250, 350);
		InventorySave.IncreaseKeys(num, "FriendReward");
		((NotificationsObserver)9).onNotificationReceived += (NotificationsObserver.NotificationHandler)num;
		if (FriendHelperCrew.OnFriendCoinsReceived != null)
		{
			FriendHelperCrew.OnFriendCoinsReceived(num);
		}
		return (IEnumerator)num;
	}

	public BoardAnimation()
	{
		//IL_0014: Expected I4, but got Obj
		GameObject gameObject = base.gameObject;
		((HUDFPS)this).DoMyWindow((int)gameObject);
	}
}

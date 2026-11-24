using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using SYBO.Subway;
using SYBO.Subway.Coins;
using SYBO.Subway.Level.Environments;
using UnityEngine;

namespace Kiloo.Common.Timer;

public abstract class BaseTimer
{
	protected readonly bool singleShot;

	protected bool _running;

	private Action m_intervalElapsed;

	public unsafe float interval
	{
		protected get
		{
			//IL_0007: Expected F4, but got I4
			return singleShot ? 1 : 0;
		}
		set
		{
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_0178: Expected Obj, but got Unknown
			//IL_0181: Expected Obj, but got I4
			//IL_0190: Unknown result type (might be due to invalid IL or missing references)
			//IL_0195: Expected Obj, but got Unknown
			//IL_019e: Expected Obj, but got I4
			//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Expected Obj, but got Unknown
			//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cc: Expected Obj, but got Unknown
			//IL_01d5: Expected Obj, but got I4
			//IL_01e3: Expected Obj, but got F4
			//IL_01fd: Expected I, but got Obj
			//IL_0213: Expected Obj, but got I
			//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e9: Expected VT, but got Unknown
			//IL_03f6: Expected F4, but got Obj
			//IL_03f1: Expected native int or pointer, but got VT
			//IL_040b: Expected F4, but got I
			//IL_0406: Expected native int or pointer, but got VT
			//IL_0414: Unknown result type (might be due to invalid IL or missing references)
			//IL_0419: Expected VT, but got Unknown
			//IL_0426: Expected F4, but got Obj
			//IL_0421: Expected native int or pointer, but got VT
			//IL_043b: Expected F4, but got I
			//IL_0436: Expected native int or pointer, but got VT
			//IL_046a: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_009c: Expected I, but got Obj
			//IL_00b2: Expected Obj, but got I
			//IL_024d: Expected Obj, but got I4
			//IL_026a: Expected Obj, but got F4
			//IL_0292: Expected I, but got Obj
			//IL_02a8: Expected Obj, but got I
			//IL_02d2: Expected F4, but got Obj
			//IL_02cd: Expected native int or pointer, but got VT
			//IL_02e7: Expected F4, but got I
			//IL_02e2: Expected native int or pointer, but got VT
			//IL_02f4: Expected F4, but got Obj
			//IL_02ef: Expected native int or pointer, but got VT
			//IL_0309: Expected F4, but got I
			//IL_0304: Expected native int or pointer, but got VT
			//IL_033c: Expected F4, but got Obj
			//IL_0337: Expected native int or pointer, but got VT
			//IL_0351: Expected F4, but got I
			//IL_034c: Expected native int or pointer, but got VT
			//IL_035e: Expected F4, but got Obj
			//IL_0359: Expected native int or pointer, but got VT
			//IL_0373: Expected F4, but got I
			//IL_036e: Expected native int or pointer, but got VT
			//IL_039e: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a3: Expected Obj, but got Unknown
			//IL_00dd: Expected I, but got Obj
			//IL_012a: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 48;
			obj = 0;
			_ = 0;
			object obj3 = obj2 + 36;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 24;
			obj4 = this;
			_ = singleShot;
			object obj5 = obj2 + 12;
			obj5 = 0;
			_ = 0;
			obj5 = value;
			_ = 0f;
			_ = 0f;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v24 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v91 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 vector = (Vector3)(obj2 + 60);
			((Vector3*)(nint)vector)->x = (float)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector2 = (Vector3)(obj2 + 72);
			((Vector3*)(nint)vector2)->x = (float)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			Vector3 vector3 = vector - vector2;
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj7 = 1;
			object obj9 = default;
			object obj10 = default;
			while ((nint)obj7 <= 16)
			{
				float num3 = (float)obj7 * 0.0625f;
				float num4 = num3 * (float)Math.PI;
				float num5 = num4 * 2f;
				obj4 = this;
				_ = singleShot;
				nint num6 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v49 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num7 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v87 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E7");
				obj5 = 0;
				_ = 0;
				float num8 = (float)obj9 * value;
				obj5 = num8;
				_ = 0f;
				float num9 = (float)obj10 * value;
				nint num10 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v63 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num11 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v83 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector)->x = (float)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
				((Vector3*)(nint)vector)->z = 0f;
				((Vector3*)(nint)vector2)->x = (float)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18+8]");
				((Vector3*)(nint)vector2)->z = 0f;
				Vector3 vector4 = vector - vector2;
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				((Vector3*)(nint)vector)->x = (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((Vector3*)(nint)vector)->z = 0f;
				((Vector3*)(nint)vector2)->x = (float)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Vector3*)(nint)vector2)->z = 0f;
				Gizmos.DrawWireCube(vector, vector2);
				obj = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				_ = 0;
				object obj12 = obj7 + 1;
				obj7 = obj12;
			}
		}
	}

	public bool isRunning
	{
		get
		{
			//IL_001d: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			bool flag = default;
			object obj = (flag ? 1 : 0) + 16;
			obj = this;
			return flag;
		}
	}

	public event Action intervalElapsed
	{
		add
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0235: Expected I4, but got Obj
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected Obj, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected Obj, but got Unknown
			//IL_00aa: Expected Obj, but got I4
			//IL_0166: Expected Obj, but got I
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a1: Expected Obj, but got Unknown
			//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d7: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 16;
			obj2 = obj;
			_ = -1;
			string tag = ((Component)this).tag;
			((GameObject)(object)tag).SetActive((byte)(int)value != 0);
			object current = ((Transform.Enumerator)this).Current;
			object obj3 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj3 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
			object obj4 = obj2 + 4;
			object obj5 = obj4 + 1;
			obj4 = obj5;
			object obj6 = obj5 << 2;
			object obj7 = obj2 + obj6;
			obj7 = 65;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
			object obj8 = default;
			if (obj8 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				object obj9 = (nint)0 << 2;
				object obj10 = obj2 + obj9;
				if ((nint)obj10 == 65)
				{
					object obj11 = obj2 + 4;
					if ((nint)obj11 > -1)
					{
						object obj12 = obj11 + -1;
						obj11 = obj12;
					}
					return;
				}
			}
			object obj13 = default;
			if (obj13 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_intervalElapsed;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 16;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	protected unsafe BaseTimer(float timerInterval, bool oneShot = false)
	{
		//IL_03fd: Invalid comparison between I and F4
		//IL_02cc: Expected Obj, but got I4
		//IL_042c: Expected Obj, but got I
		//IL_005a: Invalid comparison between F4 and I
		//IL_0087: Expected Obj, but got I
		//IL_008f: Invalid comparison between F4 and Obj
		//IL_00a5: Expected Obj, but got I4
		//IL_00cb: Expected VT, but got Obj
		//IL_00e3: Expected Obj, but got I4
		//IL_046b: Expected Obj, but got I
		//IL_03bd: Expected Obj, but got I
		//IL_00fe: Expected Obj, but got I
		//IL_0143: Expected Obj, but got I4
		//IL_022a: Expected Obj, but got I
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected Obj, but got Unknown
		//IL_0271: Expected I4, but got Obj
		//IL_0177: Expected I, but got Obj
		//IL_018d: Expected Obj, but got I
		//IL_0369: Expected Obj, but got I
		//IL_037d: Expected Obj, but got I
		//IL_038d: Invalid comparison between F4 and I
		//IL_01b8: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Timer.BaseTimer)+1C]");
		float num = 0f + timerInterval;
		CoinCurve coinCurve = default;
		bool flag3 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Timer.BaseTimer)+1C]");
			if (!(0f > 90f))
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Timer.BaseTimer)+18]");
			float num2 = 0f + timerInterval;
			float num3 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Timer.BaseTimer)+1C]");
			float num4 = num3 - 0f;
			float num5 = num4 + 1260f;
			Action action = this.m_intervalElapsed;
			bool flag = !(num5 < (float)(nint)((Delegate)action).method_ptr);
			Action action2 = this.m_intervalElapsed;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Timer.BaseTimer)+20]");
			object obj = 0 + (nint)((Delegate)action2).invoke_impl;
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num5) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
			object obj2 = flag & flag2;
			if (obj2 != null)
			{
				_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object obj3 = 0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Timer.BaseTimer)+14]");
					object obj4 = 0;
					object obj5 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S1_v39+C]");
					if ((nint)obj5 >= 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Timer.BaseTimer)+14]");
					object obj6 = (nint)0 + (nint)16;
					object obj7 = obj3 << 2;
					object obj8 = obj6 + obj7;
					string text = (string)obj8;
					int num6 = coinCurve.NumberOfCoinsIgnoringSkip(num5);
					string text2 = System.NumberFormatter.NumberToString((string)obj8, num5, (IFormatProvider)num6);
					if (text2 != null)
					{
						nint num7 = (nint)typeof(Game);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v64 (Il2CppClass<SYBO.Subway.Game>)+BA]");
						object obj9 = (nint)0 & (nint)0x200;
						if (obj9 != null)
						{
							nint num8 = (nint)typeof(Game);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v75 (Il2CppClass<SYBO.Subway.Game>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool isInstantiated = Game.IsInstantiated;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S0_v69 (System.Boolean)+CC]");
						float num9 = ((UnityRandomGen)0).NextFloat();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v58 (System.String)+10]");
						object obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S1_v64+28]");
						if (num9 < 0f)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
						}
					}
					object obj11 = obj3 + 1;
					obj3 = obj11;
				}
				int num10 = 0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Timer.BaseTimer)+28]");
					object obj12 = 0;
					int num11 = num10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S1_v43+C]");
					if ((nint)num11 >= (nint)0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Timer.BaseTimer)+28]");
					DistantEnvironmentController.DistantObjectSpawner distantObjectSpawner = ((List<DistantEnvironmentController.DistantObjectSpawner>)0).get_Item(num10);
					GameObject gameObject = ((Component)this).gameObject;
					((bool*)(flag3 ? 1 : 0))->m_value = ((bool*)(oneShot ? 1 : 0))->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [oneShot @ L2 (System.Boolean)+8]");
					_ = 0;
					((ParticleSystem)(object)distantObjectSpawner).Simulate(num5, flag3, (byte)(int)gameObject != 0);
					int num12 = num10 + 1;
					num10 = num12;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Timer.BaseTimer)+1C]");
			float num13 = 0f - 90f;
		}
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Timer.BaseTimer)+14]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S1_v10+C]");
		if ((nint)obj13 < 0)
		{
			((bool*)(flag3 ? 1 : 0))->m_value = ((bool*)(oneShot ? 1 : 0))->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [oneShot @ L2 (System.Boolean)+8]");
			_ = 0;
			throw new ArrayTypeMismatchException();
		}
	}

	public BaseTimer()
	{
	}

	public abstract void Start();

	public abstract void Stop();

	protected void TriggerIntervalElapsed()
	{
	}
}

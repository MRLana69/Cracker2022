using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
public class EventDelegate
{
	[Serializable]
	public class Parameter
	{
		public UnityEngine.Object obj;

		public string field;

		[NonSerialized]
		private object mValue;

		[NonSerialized]
		public Type expectedType;

		[NonSerialized]
		public bool cached;

		[NonSerialized]
		public PropertyInfo propInfo;

		[NonSerialized]
		public FieldInfo fieldInfo;

		public unsafe object value
		{
			get
			{
				return this.field;
			}
			set
			{
				//IL_0060: Expected I, but got Obj
				//IL_0076: Expected Obj, but got I
				//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
				//IL_00af: Expected I, but got Unknown
				//IL_00bc: Expected I, but got Obj
				//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c7: Expected Obj, but got Unknown
				//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e7: Expected Obj, but got Unknown
				//IL_0013: Expected I, but got Obj
				nint num = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<System.Type>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v23 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object typeFromHandle = typeof(void);
				nint num3 = (nint)(typeFromHandle + 4);
				((IntPtr*)num3)->m_value = (void*)(nint)typeFromHandle;
				object obj2 = this + 20;
				Type type = Type.internal_from_handle((IntPtr)num3);
				obj2 = type;
				object obj3 = this + 16;
				obj3 = value;
			}
		}

		public Type type
		{
			get
			{
				//IL_0049: Unknown result type (might be due to invalid IL or missing references)
				//IL_004e: Expected Obj, but got Unknown
				//IL_0057: Expected Obj, but got I4
				//IL_005d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0062: Expected Obj, but got Unknown
				//IL_006b: Expected Obj, but got I4
				//IL_0079: Expected I, but got Obj
				//IL_008f: Expected Obj, but got I
				//IL_0223: Expected I, but got Obj
				//IL_0239: Expected Obj, but got I
				//IL_00ba: Expected I, but got Obj
				//IL_02c0: Expected I, but got Obj
				//IL_02d6: Expected Obj, but got I
				//IL_0264: Expected I, but got Obj
				//IL_0370: Expected I, but got Obj
				//IL_0386: Expected Obj, but got I
				//IL_0301: Expected I, but got Obj
				//IL_04f0: Expected Obj, but got I4
				//IL_03b1: Expected I, but got Obj
				//IL_014f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0154: Expected Obj, but got Unknown
				//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b0: Expected Obj, but got Unknown
				Type result = default;
				if (mValue != null)
				{
					result = (Type)mValue;
				}
				else
				{
					if (~(cached ? 1u : 0u) != 0)
					{
						cached = true;
						object obj = this + 32;
						obj = 0;
						object obj2 = this + 28;
						obj2 = 0;
						nint num = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v41 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj3 = (nint)0 & (nint)0x200;
						if (obj3 != null)
						{
							nint num2 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v55 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (((ComputeShader)this.obj).FindKernel((string)null) != 0)
						{
							string text = this.field;
							if (this.field != null && text.m_stringLength != 0)
							{
								object obj4 = this + 28;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
								Type type = default;
								MemberInfo[] member = type.GetMember(this.field);
								obj4 = member;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FF48");
								object obj5 = default;
								if (obj5 != null)
								{
									object obj6 = this + 32;
									Type type2 = type.GetInterface(this.field);
									obj6 = type2;
								}
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FF49");
					object obj7 = default;
					if (obj7 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @726B");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FF49");
						object obj8 = default;
						if (obj8 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
						}
						else
						{
							nint num3 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
							object obj9 = (nint)0 & (nint)0x200;
							if (obj9 != null)
							{
								nint num4 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (((ComputeShader)this.obj).FindKernel((string)null) != 0)
							{
								result = (Type)(object)this.obj;
							}
							else
							{
								nint num5 = (nint)typeof(Type);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v13 (Il2CppClass<System.Type>)+BA]");
								object obj10 = (nint)0 & (nint)0x200;
								if (obj10 != null)
								{
									nint num6 = (nint)typeof(Type);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S1_v23 (Il2CppClass<System.Type>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								if ((object)expectedType != null)
								{
									bool isAbstract = expectedType.IsAbstract;
									result = null;
									if (isAbstract)
									{
										goto IL_0487;
									}
								}
								nint num7 = (nint)typeof(Convert);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v27 (Il2CppClass<System.Convert>)+BA]");
								object obj11 = (nint)0 & (nint)0x200;
								if (obj11 != null)
								{
									nint num8 = (nint)typeof(Convert);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v33 (Il2CppClass<System.Convert>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								bool flag = Convert.ToBoolean((object)null, (IFormatProvider)expectedType);
								result = (Type)flag;
							}
						}
					}
				}
				goto IL_0487;
				IL_0487:
				return result;
			}
		}

		public Parameter()
		{
			//IL_0015: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I
			//IL_011b: Expected Obj, but got I
			//IL_0138: Expected Obj, but got I4
			//IL_037a: Expected Obj, but got I
			//IL_0383: Unknown result type (might be due to invalid IL or missing references)
			//IL_0388: Expected Obj, but got Unknown
			//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cf: Expected Obj, but got Unknown
			//IL_01c4: Expected Obj, but got I
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Expected Obj, but got Unknown
			//IL_0190: Expected Obj, but got I
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected Obj, but got Unknown
			//IL_0257: Expected Obj, but got I
			//IL_02b1: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventDelegate+Parameter)+34]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventDelegate+Parameter)+34]");
			object obj3;
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventDelegate+Parameter)+34]");
				object obj2 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
				obj3 = 0;
				obj4 = obj2;
			}
			else
			{
				obj4 = this;
				obj3 = 1;
			}
			object obj5 = default;
			object obj23 = default;
			object obj20 = default;
			for (; obj5 != obj3; obj5 = obj23 + 1)
			{
				object obj6 = obj5 << 2;
				object obj7 = obj4 + obj6;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+14]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+28]");
				if ((nint)0 == -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+24]");
				object obj11 = (nint)0 & (nint)0x10;
				bool flag = obj11 == null;
				object obj12 = (flag ? 1 : 0) ^ 1;
				if (obj12 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+2A]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
						object obj13 = (nint)0 & (nint)0x3FFF;
						object obj14 = obj13 + 80504;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v104 @ S2_v14 (should have been resolved before IL gen)");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
						object obj15 = (nint)0 & (nint)0x7FFF;
						object obj16 = obj15 + 46824;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v111 @ S1_v33 (should have been resolved before IL gen)");
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+28]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+10]");
					bool flag2;
					if ((nint)0 != 0)
					{
						object obj17 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v59+9C]");
						object obj18 = (nint)0 & (nint)0x100;
						flag2 = obj18 != null;
					}
					else
					{
						flag2 = false;
					}
					if (!flag2 && field != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+2B]");
						object obj19 = (nint)0 & (nint)3;
						bool flag3 = (nint)obj19 == 2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
						if (flag3)
						{
							if (obj20 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B8");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B9");
							}
						}
						else if (obj20 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
						}
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
				object obj21 = (nint)0 & (nint)0x3FFF;
				object obj22 = obj21 + 80504;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v129 @ S2_v6 (should have been resolved before IL gen)");
			}
		}

		public Parameter(UnityEngine.Object obj, string field)
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected Obj, but got Unknown
			this.obj = (UnityEngine.Object)(object)field;
			expectedType = (Type)(object)field;
			object obj2 = this + 16;
			obj2 = obj;
		}

		public Parameter(object val)
		{
			throw new InvalidOperationException();
		}
	}

	public delegate void Callback();

	private MonoBehaviour mTarget;

	private string mMethodName;

	private Parameter[] mParameters;

	public bool oneShot;

	[NonSerialized]
	private Callback mCachedCallback;

	[NonSerialized]
	private bool mRawDelegate;

	[NonSerialized]
	private bool mCached;

	[NonSerialized]
	private MethodInfo mMethod;

	[NonSerialized]
	private ParameterInfo[] mParameterInfos;

	[NonSerialized]
	private object[] mArgs;

	private static int s_Hash;

	public MonoBehaviour target
	{
		get
		{
			//IL_0845: Expected I, but got Obj
			//IL_085b: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_011b: Expected Obj, but got I4
			//IL_014b: Expected I4, but got Obj
			//IL_014b: Expected I4, but got Obj
			//IL_014b: Expected Obj, but got I4
			//IL_0899: Expected Obj, but got I4
			//IL_00db: Expected I4, but got Obj
			//IL_00db: Expected I4, but got Obj
			//IL_00db: Expected Obj, but got I4
			//IL_0729: Expected I, but got Obj
			//IL_073f: Expected Obj, but got I
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Expected Obj, but got Unknown
			//IL_03af: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b4: Expected I4, but got Unknown
			//IL_07b7: Expected I, but got Obj
			//IL_07cd: Expected Obj, but got I
			//IL_076a: Expected I, but got Obj
			//IL_069b: Expected I, but got Obj
			//IL_06b1: Expected Obj, but got I
			//IL_0593: Expected Obj, but got I4
			//IL_05e2: Expected Obj, but got I4
			//IL_08a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ac: Expected Obj, but got Unknown
			//IL_07f8: Expected I, but got Obj
			//IL_06dc: Expected I, but got Obj
			//IL_05ff: Expected I, but got Obj
			//IL_0615: Expected Obj, but got I
			//IL_09ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b0: Expected I4, but got Unknown
			//IL_09d8: Expected I4, but got Obj
			//IL_09d8: Expected I4, but got Obj
			//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0403: Expected Obj, but got Unknown
			//IL_041d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0422: Expected Obj, but got Unknown
			//IL_0640: Expected I, but got Obj
			//IL_047c: Expected I, but got Obj
			//IL_0492: Expected Obj, but got I
			//IL_0923: Unknown result type (might be due to invalid IL or missing references)
			//IL_0928: Expected I4, but got Unknown
			//IL_0950: Expected I4, but got Obj
			//IL_0950: Expected I4, but got Obj
			//IL_0453: Unknown result type (might be due to invalid IL or missing references)
			//IL_0458: Expected Obj, but got Unknown
			//IL_0461: Expected Obj, but got I4
			//IL_0505: Unknown result type (might be due to invalid IL or missing references)
			//IL_050a: Expected Obj, but got Unknown
			//IL_0524: Unknown result type (might be due to invalid IL or missing references)
			//IL_0529: Expected Obj, but got Unknown
			//IL_04bd: Expected I, but got Obj
			//IL_0971: Expected I4, but got Obj
			//IL_097a: Expected Obj, but got I4
			//IL_055a: Unknown result type (might be due to invalid IL or missing references)
			//IL_055f: Expected Obj, but got Unknown
			//IL_0568: Unknown result type (might be due to invalid IL or missing references)
			//IL_056d: Expected I4, but got Unknown
			//IL_0326: Expected I, but got Obj
			//IL_033c: Expected Obj, but got I
			//IL_08ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_08d3: Expected I4, but got Unknown
			//IL_08ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0904: Expected I4, but got Unknown
			//IL_0916: Expected Obj, but got I4
			//IL_0313: Expected Obj, but got I4
			//IL_0367: Expected I, but got Obj
			nint num = (nint)typeof(ByteReader);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<ByteReader>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(ByteReader);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v184 (Il2CppClass<ByteReader>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BetterList<string> mTemp = ByteReader.mTemp;
			mTemp.size = 0;
			string text = "";
			int num3 = 0;
			object obj2 = default;
			while (true)
			{
				bool flag;
				if ((object)mTarget != null)
				{
					MonoBehaviour monoBehaviour = mTarget;
					string text2 = mMethodName;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v64 (UnityEngine.MonoBehaviour)+C]");
					flag = (nint)text2 < 0;
				}
				else
				{
					flag = false;
				}
				if (flag)
				{
					if (obj2 != null)
					{
						bool flag2 = Equals(null);
						if (!flag2)
						{
							goto IL_05e7;
						}
						string provider = ((string)flag2).Remove((int)"\\n", (int)"\n");
						object obj3 = ((IConvertible)text).ToType((Type)(object)"\n", (IFormatProvider)(object)provider);
						text = (string)obj3;
						int num4 = 0;
					}
					else
					{
						bool flag3 = Equals(1);
						if (!flag3)
						{
							goto IL_05e7;
						}
						string text3 = ((string)flag3).Remove((int)"\\n", (int)"\n");
						text = text3;
						int num4 = 0;
						num3 = 0;
					}
					char[] array7;
					for (char[] array = (char[])num3; (nint)array < text.m_stringLength; array7 = (char[])(array + 1), array = array7)
					{
						string[] array2 = text.Split(array);
						object obj4 = (object)array2 << 16;
						object obj5 = obj4 >> 16;
						object obj6 = obj5 - 34;
						if ((nint)obj5 != 34)
						{
							if ((nint)obj6 == 1 || (nint)obj6 == 2 || (nint)obj6 == 3 || (nint)obj6 == 4 || (nint)obj6 == 5 || (nint)obj6 == 6 || (nint)obj6 == 7 || (nint)obj6 == 8 || (nint)obj6 == 9 || (nint)obj6 != 10)
							{
								continue;
							}
							object obj7;
							if (obj2 != null)
							{
								obj7 = 1;
							}
							else
							{
								nint num5 = (nint)typeof(ByteReader);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ S0_v150 (Il2CppClass<ByteReader>)+BA]");
								object obj8 = (nint)0 & (nint)0x200;
								if (obj8 != null)
								{
									nint num6 = (nint)typeof(ByteReader);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ S0_v160 (Il2CppClass<ByteReader>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								int num4 = array - num3;
								string item = text.InternalSubString(num3, num4);
								ByteReader.mTemp.Add(item);
								int num7 = array + 1;
								num3 = num7;
								obj7 = 0;
							}
							obj2 = obj7;
							continue;
						}
						int num8 = array + 1;
						object obj13;
						if (obj2 != null)
						{
							if (num8 >= text.m_stringLength)
							{
								nint num9 = (nint)typeof(ByteReader);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v99 (Il2CppClass<ByteReader>)+BA]");
								object obj9 = (nint)0 & (nint)0x200;
								if (obj9 != null)
								{
									nint num10 = (nint)typeof(ByteReader);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ S0_v110 (Il2CppClass<ByteReader>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								int length = array - num3;
								string text4 = text.InternalSubString(num3, length);
								string item2 = text4.Remove((int)"\"\"", (int)"\"");
								ByteReader.mTemp.Add(item2);
								return (MonoBehaviour)(object)ByteReader.mTemp;
							}
							char[] separator = (char[])(array + 1);
							string[] array3 = text.Split(separator);
							object obj10 = array3 & 0xFFFF;
							if ((nint)obj10 == 34)
							{
								char[] array4 = (char[])(array + 1);
								obj2 = 1;
								array = array4;
								continue;
							}
							nint num11 = (nint)typeof(ByteReader);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ S0_v121 (Il2CppClass<ByteReader>)+BA]");
							object obj11 = (nint)0 & (nint)0x200;
							if (obj11 != null)
							{
								nint num12 = (nint)typeof(ByteReader);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ S0_v138 (Il2CppClass<ByteReader>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							int length2 = array - num3;
							string text5 = text.InternalSubString(num3, length2);
							string item3 = text5.Remove((int)"\"\"", (int)"\"");
							ByteReader.mTemp.Add(item3);
							char[] separator2 = (char[])(array + 1);
							string[] array5 = text.Split(separator2);
							object obj12 = array5 & 0xFFFF;
							if ((nint)obj12 == 44)
							{
								char[] array6 = (char[])(array + 1);
								int num13 = array6 + 1;
								array = array6;
								num3 = num13;
							}
							int num4 = (int)"\"";
							obj13 = 0;
						}
						else
						{
							num3 = num8;
							obj13 = 1;
						}
						obj2 = obj13;
					}
					if (num3 < text.m_stringLength)
					{
						if (obj2 != null)
						{
							obj2 = 1;
							continue;
						}
						nint num14 = (nint)typeof(ByteReader);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v68 (Il2CppClass<ByteReader>)+BA]");
						object obj14 = (nint)0 & (nint)0x200;
						if (obj14 != null)
						{
							nint num15 = (nint)typeof(ByteReader);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S0_v75 (Il2CppClass<ByteReader>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						int length3 = text.m_stringLength - num3;
						string item4 = text.InternalSubString(num3, length3);
						ByteReader.mTemp.Add(item4);
						break;
					}
					nint num16 = (nint)typeof(ByteReader);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v52 (Il2CppClass<ByteReader>)+BA]");
					object obj15 = (nint)0 & (nint)0x200;
					if (obj15 != null)
					{
						nint num17 = (nint)typeof(ByteReader);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v59 (Il2CppClass<ByteReader>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					ByteReader.mTemp.Add("");
					break;
				}
				goto IL_05e7;
				IL_05e7:
				return null;
			}
			nint num18 = (nint)typeof(ByteReader);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S0_v38 (Il2CppClass<ByteReader>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num19 = (nint)typeof(ByteReader);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S0_v45 (Il2CppClass<ByteReader>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (MonoBehaviour)(object)ByteReader.mTemp;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 8;
			string text = ((TextAsset)(object)value).ToString();
			obj = text;
		}
	}

	public string methodName
	{
		get
		{
			return (string)(object)mTarget;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected Obj, but got Unknown
			//IL_0027: Expected Obj, but got I4
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected Obj, but got Unknown
			//IL_0051: Expected Obj, but got I4
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected Obj, but got Unknown
			//IL_0065: Expected Obj, but got I4
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected Obj, but got Unknown
			//IL_0079: Expected Obj, but got I4
			object obj = this + 8;
			obj = value;
			object obj2 = this + 24;
			obj2 = 0;
			mRawDelegate = false;
			mCached = false;
			object obj3 = this + 32;
			obj3 = 0;
			object obj4 = this + 36;
			obj4 = 0;
			object obj5 = this + 16;
			obj5 = 0;
		}
	}

	public Parameter[] parameters => (Parameter[])(object)mMethodName;

	public bool isValid
	{
		get
		{
			//IL_0036: Expected I4, but got Obj
			if (~(mCached ? 1u : 0u) != 0)
			{
				Clear();
			}
			return (byte)(int)mParameters != 0;
		}
	}

	public bool isEnabled
	{
		get
		{
			//IL_0064: Expected I, but got Obj
			//IL_007a: Expected Obj, but got I
			//IL_00a5: Expected I, but got Obj
			if (~(mCached ? 1u : 0u) != 0)
			{
				Clear();
			}
			if (~(mRawDelegate ? 1u : 0u) == 0 && mCachedCallback != null)
			{
				return true;
			}
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mTarget).FindKernel((string)null) != 0)
			{
				string text = mMethodName;
				bool flag = mMethodName == null || text.m_stringLength == 0;
				return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
			}
			return false;
		}
	}

	public EventDelegate()
	{
	}

	public EventDelegate(Callback call)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0027: Expected Obj, but got I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_0065: Expected Obj, but got I4
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0079: Expected Obj, but got I4
		object obj = this + 12;
		obj = call;
		object obj2 = this + 24;
		obj2 = 0;
		mRawDelegate = false;
		mCached = false;
		object obj3 = this + 32;
		obj3 = 0;
		object obj4 = this + 36;
		obj4 = 0;
		object obj5 = this + 16;
		obj5 = 0;
	}

	public EventDelegate(MonoBehaviour target, string methodName)
	{
		//IL_0121: Expected Obj, but got I
		//IL_009a: Expected I4, but got Obj
		//IL_009a: Expected Obj, but got I
		//IL_00af: Expected I4, but got Obj
		//IL_00af: Expected Obj, but got I
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_004a: Expected Obj, but got I
		//IL_010c: Expected I4, but got Obj
		//IL_010c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventDelegate)+2C]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<int> list = default;
			list._002Ector();
			object obj = this + 44;
			obj = list;
		}
		int num = 0;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventDelegate)+2C]");
			object obj2 = 0;
			int num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v5+C]");
			if ((nint)num2 < (nint)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventDelegate)+2C]");
				int num3 = ((List<int>)0).get_Item(num);
				if (num3 == (nint)target)
				{
					break;
				}
				int num4 = num + 2;
				num = num4;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventDelegate)+2C]");
			((List<int>)0).Add((int)target);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventDelegate)+2C]");
			((List<int>)0).Add((int)methodName);
			return;
		}
		int index = num + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventDelegate)+2C]");
		((List<int>)0).set_Item(index, (int)methodName);
	}

	private static string GetMethodName(Callback callback)
	{
		//IL_0073: Expected I, but got Obj
		//IL_0089: Expected Obj, but got I
		//IL_01fc: Expected Obj, but got I
		//IL_010b: Expected I, but got Obj
		//IL_0121: Expected Obj, but got I
		//IL_00b4: Expected I, but got Obj
		//IL_0228: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I4
		//IL_01a7: Expected Obj, but got I
		//IL_01b3: Expected Obj, but got I4
		//IL_014c: Expected I, but got Obj
		//IL_0194: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ L0 (EventDelegate+Callback)+1D]");
		if ((nint)0 == 0)
		{
			((EventDelegate)(object)callback).Clear();
		}
		if (((Delegate)callback).extra_arg != (IntPtr)0 && ((Delegate)callback).delegate_trampoline != (IntPtr)0)
		{
			return (string)1;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)(nint)((Delegate)callback).method_ptr != null)
		{
			return null;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v29 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)(nint)((Delegate)callback).method_ptr != null)
		{
			return (string)1;
		}
		bool isActiveAndEnabled = ((Behaviour)(nint)((Delegate)callback).method_ptr).isActiveAndEnabled;
		return (string)isActiveAndEnabled;
	}

	private static bool IsValid(Callback callback)
	{
		MethodInfo virtualMethod_internal = ((Delegate)callback).GetVirtualMethod_internal();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		bool result = default;
		return result;
	}

	public override bool Equals(object obj)
	{
		//IL_01fb: Expected Obj, but got I
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0279: Expected I, but got Obj
		//IL_028f: Expected Obj, but got I
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected I4, but got Unknown
		//IL_02f9: Expected I4, but got Obj
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_01aa: Expected I, but got Obj
		MonoBehaviour monoBehaviour = mTarget;
		if (obj != null)
		{
			while (true)
			{
				string text = mMethodName;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (UnityEngine.MonoBehaviour)+C]");
				if ((nint)text >= 0)
				{
					break;
				}
				object obj2 = mTarget + 16;
				object obj3 = obj2 + mMethodName;
				if ((nint)obj3 > 31)
				{
					break;
				}
				string text2 = mMethodName + 1;
				mMethodName = text2;
			}
		}
		string text3 = mMethodName;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (UnityEngine.MonoBehaviour)+C]");
		bool flag = (nint)text3 < 0;
		bool flag2 = !flag;
		string text4 = mMethodName;
		if (!flag2)
		{
			string text7;
			while (true)
			{
				string text5 = text4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (UnityEngine.MonoBehaviour)+C]");
				if ((nint)text5 < 0)
				{
					string text6 = text4 + 1;
					object obj4 = mTarget + 16;
					object obj5 = obj4 + text4;
					object obj6 = obj5 - 10;
					if ((nint)obj5 != 10 && ((nint)obj6 == 1 || (nint)obj6 == 2 || (nint)obj6 != 3))
					{
						text4 = text6;
						continue;
					}
					text7 = text6;
					break;
				}
				string text8 = text4 + 1;
				text7 = text8;
				break;
			}
			nint num = (nint)typeof(ByteReader);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S2_v6 (Il2CppClass<ByteReader>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num2 = (nint)typeof(ByteReader);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S2_v14 (Il2CppClass<ByteReader>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj8 = (object)text7 - (object)mMethodName;
			bool flag3 = (byte)(obj8 - 1) != 0;
			EventDelegate eventDelegate = Add((List<EventDelegate>)(object)mTarget, (Callback)(object)mMethodName, flag3);
			mMethodName = text7;
			return (byte)(int)eventDelegate != 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (UnityEngine.MonoBehaviour)+C]");
		mMethodName = (string)0;
		return false;
	}

	public override int GetHashCode()
	{
		if (this != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BFFD");
			MethodInfo methodInfo = default;
			return methodInfo.Equals(null) ? 1 : 0;
		}
		return 0;
	}

	private void Set(Callback call)
	{
		Set((List<EventDelegate>)(object)this, (EventDelegate)(object)call);
	}

	public void Set(MonoBehaviour target, string methodName)
	{
		//IL_000e: Expected I4, but got Obj
		Add((List<EventDelegate>)(object)this, (EventDelegate)(object)target, (byte)(int)methodName != 0);
	}

	private void Cache()
	{
	}

	public bool Execute()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<EventDelegate>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (byte)s_Hash != 0;
	}

	public unsafe void Clear()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a9: Expected I, but got Unknown
		//IL_09b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b7: Expected Obj, but got Unknown
		//IL_09c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c5: Expected Obj, but got Unknown
		//IL_0a10: Expected I, but got Obj
		//IL_0a26: Expected Obj, but got I
		//IL_004a: Expected I, but got Obj
		//IL_0060: Expected Obj, but got I
		//IL_0166: Expected I, but got Obj
		//IL_008b: Expected I, but got Obj
		//IL_00d8: Expected I, but got Obj
		//IL_00ee: Expected Obj, but got I
		//IL_0aa1: Expected I4, but got Obj
		//IL_0119: Expected I, but got Obj
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_0213: Expected Obj, but got I4
		//IL_0b5f: Expected I, but got Obj
		//IL_0b75: Expected Obj, but got I
		//IL_022e: Expected I, but got Obj
		//IL_04ff: Expected I, but got Obj
		//IL_0515: Expected Obj, but got I
		//IL_0bd0: Expected I, but got Obj
		//IL_06b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Expected Obj, but got Unknown
		//IL_0540: Expected I, but got Obj
		//IL_07cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d0: Expected Obj, but got Unknown
		//IL_07d9: Expected Obj, but got I4
		//IL_083a: Unknown result type (might be due to invalid IL or missing references)
		//IL_083f: Expected Obj, but got Unknown
		//IL_086e: Expected Obj, but got I4
		//IL_0710: Expected I, but got Obj
		//IL_0726: Expected Obj, but got I
		//IL_0c36: Expected I, but got Obj
		//IL_0c3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c41: Expected Obj, but got Unknown
		//IL_0c89: Expected Obj, but got I4
		//IL_079e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a3: Expected Obj, but got Unknown
		//IL_07ac: Expected Obj, but got I4
		//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b7: Expected Obj, but got Unknown
		//IL_07c0: Expected Obj, but got I4
		//IL_0751: Expected I, but got Obj
		//IL_08ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ef: Expected Obj, but got Unknown
		//IL_0913: Unknown result type (might be due to invalid IL or missing references)
		//IL_0918: Expected Obj, but got Unknown
		//IL_0923: Unknown result type (might be due to invalid IL or missing references)
		//IL_0928: Expected Obj, but got Unknown
		//IL_095e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0963: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		nint num = (nint)(obj2 + 16);
		object obj3 = obj2 + 4;
		object obj4 = obj2 + 8;
		obj4 = obj;
		_ = -1;
		mCached = true;
		if (~(mRawDelegate ? 1u : 0u) == 0)
		{
			return;
		}
		if (mCachedCallback != null)
		{
			Callback callback = mCachedCallback;
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v163 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S1_v182 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			ComputeShader computeShader = default;
			if (computeShader.FindKernel((string)(object)mTarget) == 0)
			{
				nint num4 = (nint)typeof(EventDelegate);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S1_v171 (Il2CppClass<EventDelegate>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num5 = (nint)typeof(EventDelegate);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S1_v178 (Il2CppClass<EventDelegate>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7F6B");
				string text = default;
				if (text.get_Chars((int)mMethodName) == '\0')
				{
					return;
				}
			}
		}
		nint num6 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S1_v156 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mTarget).FindKernel((string)null) == 0)
		{
			return;
		}
		string text2 = mMethodName;
		if (mMethodName == null || text2.m_stringLength == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
		object obj8 = this + 32;
		obj8 = 0;
		object obj10 = default;
		object obj9 = obj10;
		object obj12 = default;
		object obj13 = default;
		while (true)
		{
			nint num8 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v42 (Il2CppClass<System.Type>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num9 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v219 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (obj9 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj12 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			obj9 = obj13;
		}
		if (mMethod != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			throw new ArrayTypeMismatchException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num10 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S1_v29 (Il2CppClass<System.Type>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num11 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S1_v105 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj3 = typeof(void);
		((IntPtr*)num)->m_value = (void*)(nint)obj3;
		Type type = Type.internal_from_handle((IntPtr)num);
		object obj15 = default;
		if (obj15 != type)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
			throw new ArrayTypeMismatchException();
		}
		object obj16 = this + 36;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj17 = default;
		obj16 = obj17;
		ParameterInfo[] array = mParameterInfos;
		if (array.Length == 0)
		{
			nint num12 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ S0_v110 (Il2CppClass<System.Type>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num13 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ S0_v122 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = typeof(Callback);
			((IntPtr*)num)->m_value = (void*)(nint)obj2;
			object obj19 = this + 24;
			Type type2 = Type.internal_from_handle((IntPtr)num);
			Delegate obj20 = Delegate.CreateDelegate(type2, (Type)(object)mTarget, mMethodName);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj21 = default;
			obj19 = obj21;
			object obj22 = this + 40;
			obj22 = 0;
			object obj23 = this + 16;
			obj23 = 0;
			return;
		}
		object obj24 = this + 24;
		obj24 = 0;
		if (mParameters != null)
		{
			Parameter[] array2 = mParameters;
			ParameterInfo[] array3 = mParameterInfos;
			if (array2.Length == array3.Length)
			{
				goto IL_0c76;
			}
		}
		object obj25 = this + 16;
		ParameterInfo[] array4 = mParameterInfos;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj26 = default;
		obj25 = obj26;
		Parameter[] array5 = mParameters;
		object obj27 = 0;
		if ((nint)obj27 < array5.Length)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Callback callback2 = default;
			callback2();
			throw new ArrayTypeMismatchException();
		}
		goto IL_0c76;
		IL_0c76:
		Parameter[] array6 = mParameters;
		object obj28 = 0;
		object obj36 = default;
		while ((nint)obj28 < array6.Length)
		{
			object obj29 = mParameters + 16;
			object obj30 = obj28 << 2;
			object obj31 = obj29 + obj30;
			object obj32 = obj31 + 20;
			object obj33 = mParameterInfos + 16;
			object obj34 = obj28 << 2;
			object obj35 = obj33 + obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			obj32 = obj36;
			object obj37 = obj28 + 1;
			obj28 = obj37;
		}
	}

	public override string ToString()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0050: Expected Obj, but got I4
		//IL_07f4: Expected I4, but got Obj
		//IL_0801: Expected Obj, but got I4
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_0819: Expected Obj, but got I4
		//IL_099e: Expected Obj, but got I4
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_079d: Expected Obj, but got I4
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a1: Expected Obj, but got Unknown
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0732: Expected Obj, but got Unknown
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Expected Obj, but got Unknown
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Expected Obj, but got Unknown
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		if (~(mCached ? 1u : 0u) != 0)
		{
			Clear();
		}
		if (mCachedCallback != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
			return (string)1;
		}
		if (mMethod.Equals(null))
		{
			if (mParameters != null)
			{
				Parameter[] array = mParameters;
				if (array.Length != 0)
				{
					if (mArgs != null)
					{
						object[] array2 = mArgs;
						Parameter[] array3 = mParameters;
						if (array2.Length == array3.Length)
						{
							goto IL_0806;
						}
					}
					object obj3 = this + 40;
					Parameter[] array4 = mParameters;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					object obj4 = default;
					obj3 = obj4;
					goto IL_0806;
				}
			}
			string text = MethodBase.ConstructParameters((Type[])(object)mMethod, (CallingConventions)mTarget, false);
			return (string)1;
		}
		return null;
		IL_0806:
		Parameter[] array5 = mParameters;
		object obj5 = 0;
		if ((nint)obj5 < array5.Length)
		{
			object obj6 = mParameters + 16;
			object obj7 = obj5 << 2;
			object obj8 = obj6 + obj7;
			Type type = ((Parameter)obj8).type;
			throw new ArrayTypeMismatchException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object[] array6 = mArgs;
		object obj9 = 0;
		if ((nint)obj9 < array6.Length)
		{
			object obj10 = mParameterInfos + 16;
			object obj11 = obj9 << 2;
			object obj12 = obj10 + obj11;
			if (!((ParameterInfo)obj12).IsOptional)
			{
				object obj13 = mParameterInfos + 16;
				object obj14 = obj9 << 2;
				object obj15 = obj13 + obj14;
				if (!((ParameterInfo)obj15).IsRetval)
				{
					goto IL_09a8;
				}
			}
			object obj16 = mParameters + 16;
			object obj17 = obj9 << 2;
			object obj18 = obj16 + obj17;
			object obj19 = obj18 + 16;
			object obj20 = mArgs + 16;
			object obj21 = obj9 << 2;
			object obj22 = obj20 + obj21;
			obj19 = obj22;
			goto IL_09a8;
		}
		return (string)1;
		IL_09a8:
		throw new ArrayTypeMismatchException();
	}

	public static void Execute(List<EventDelegate> list)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_002e: Expected Obj, but got I4
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		//IL_004b: Expected Obj, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0062: Expected Obj, but got I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_007f: Expected Obj, but got I4
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_0096: Expected Obj, but got I4
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00ad: Expected Obj, but got I4
		object obj = list + 8;
		obj = 0;
		object obj2 = list + 12;
		obj2 = 0;
		_ = 0;
		object obj3 = list + 24;
		obj3 = 0;
		object obj4 = list + 16;
		obj4 = 0;
		_ = 0;
		object obj5 = list + 32;
		obj5 = 0;
		object obj6 = list + 36;
		obj6 = 0;
		object obj7 = list + 40;
		obj7 = 0;
	}

	public static bool IsValid(List<EventDelegate> list)
	{
		//IL_01a1: Expected I, but got Obj
		//IL_01b7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00ba: Expected Obj, but got I4
		//IL_00ff: Expected Obj, but got I4
		//IL_0080: Expected I4, but got Obj
		//IL_017d: Expected Obj, but got I4
		//IL_0189: Expected I4, but got Obj
		//IL_0155: Expected I4, but got Obj
		//IL_0161: Expected I4, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)list._items).FindKernel((string)null) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ L0 (System.Collections.Generic.List`1<EventDelegate>)+1C]");
			if ((nint)0 != 0)
			{
				return (byte)(int)"[delegate]" != 0;
			}
			return false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string text = default;
		int num3 = text.LastIndexOfAny((char[])46);
		bool flag = num3 >= 1;
		bool flag2 = !flag;
		string text2 = text;
		if (!flag2)
		{
			char[] trimChars = (char[])(num3 + 1);
			string text3 = text.Trim(trimChars);
			text2 = text3;
		}
		int size = list._size;
		bool flag3;
		if (list._size != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v15 (System.Int32)+8]");
			flag3 = (nint)0 == 0;
		}
		else
		{
			flag3 = true;
		}
		if (flag3)
		{
			string text4 = string.ConcatArray((string[])(object)text2, (int)"/[delegate]");
			return (byte)(int)text4 != 0;
		}
		object obj2 = ((IConvertible)text2).ToType((Type)(object)"/", (IFormatProvider)list._size);
		return (byte)(int)obj2 != 0;
	}

	public static EventDelegate Set(List<EventDelegate> list, Callback callback)
	{
		//IL_032d: Expected Obj, but got I4
		//IL_01fa: Expected I, but got Obj
		//IL_0210: Expected Obj, but got I
		//IL_00b9: Expected I, but got Obj
		//IL_00cf: Expected Obj, but got I
		//IL_01dd: Expected Obj, but got I4
		//IL_0373: Expected Obj, but got I
		//IL_023b: Expected I, but got Obj
		//IL_00fa: Expected I, but got Obj
		//IL_0288: Expected I, but got Obj
		//IL_029e: Expected Obj, but got I
		//IL_0153: Expected Obj, but got I
		//IL_0153: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I4
		//IL_03ea: Expected Obj, but got I4
		//IL_03f6: Expected Obj, but got I4
		//IL_02c9: Expected I, but got Obj
		EventDelegate result;
		if (callback != null)
		{
			Callback callback2;
			if (callback == null)
			{
				callback2 = null;
			}
			else
			{
				callback2 = (((object)callback.GetType() != typeof(Callback)) ? null : callback);
			}
			if (callback2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
				object obj = default;
				bool flag = obj == null;
				result = null;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
					nint num = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v37 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v45 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					EventDelegate[] items = list._items;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v31+8]");
					bool flag2 = (UnityEngine.Object)(object)items != (UnityEngine.Object)0;
					bool flag3 = !flag2;
					result = null;
					if (!flag3)
					{
						int size = list._size;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v31+C]");
						bool flag4 = (string)size == (string)0;
						result = (EventDelegate)flag4;
					}
				}
			}
			else
			{
				if (callback != null)
				{
					if ((object)callback.GetType() == typeof(Callback))
					{
						Callback callback3 = callback;
					}
					else
					{
						Callback callback3 = null;
					}
				}
				else
				{
					Callback callback3 = null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
				object obj3 = default;
				if (obj3 != null)
				{
					result = (EventDelegate)1;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UnityEngine.Object obj5 = default;
					if ((UnityEngine.Object)(object)list._items != obj5)
					{
						nint num5 = (nint)typeof(EventDelegate);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S1_v20 (Il2CppClass<EventDelegate>)+BA]");
						object obj6 = (nint)0 & (nint)0x200;
						if (obj6 != null)
						{
							nint num6 = (nint)typeof(EventDelegate);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S1_v26 (Il2CppClass<EventDelegate>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7F6B");
						string text = default;
						bool flag5 = (string)list._size == text;
						result = (EventDelegate)flag5;
					}
					else
					{
						result = null;
					}
				}
			}
		}
		else
		{
			bool flag6 = ((EventDelegate)(object)list).isEnabled;
			result = (EventDelegate)((flag6 ? 1 : 0) ^ 1);
		}
		return result;
	}

	public static void Set(List<EventDelegate> list, EventDelegate del)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00c1: Expected I, but got Obj
		//IL_00d7: Expected Obj, but got I
		//IL_0187: Expected I, but got Obj
		//IL_019d: Expected Obj, but got I
		//IL_0102: Expected I, but got Obj
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		//IL_0174: Expected Obj, but got I4
		//IL_01c8: Expected I, but got Obj
		Execute(list);
		if (del == null)
		{
			return;
		}
		nint num = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<EventDelegate>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v37 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (del.GetHashCode() == 0)
		{
			return;
		}
		object obj2 = list + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj3 = default;
		obj2 = obj3;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)(object)list._items != null)
		{
			_ = 1;
			object obj5 = list + 24;
			obj5 = del;
			object obj6 = list + 12;
			obj6 = 0;
			return;
		}
		nint num5 = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v21 (Il2CppClass<EventDelegate>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num6 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v28 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj8 = list + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7F6B");
		object obj9 = default;
		obj8 = obj9;
		_ = 0;
	}

	public static EventDelegate Add(List<EventDelegate> list, Callback callback)
	{
		if (list != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			EventDelegate eventDelegate = default;
			eventDelegate.Set(callback);
			throw new IndexOutOfRangeException();
		}
		return null;
	}

	public static EventDelegate Add(List<EventDelegate> list, Callback callback, bool oneShot)
	{
		Encoding uTF = Encoding.UTF32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
		EventDelegate result = default;
		return result;
	}

	public static void Add(List<EventDelegate> list, EventDelegate ev)
	{
		if (list != null)
		{
			throw new IndexOutOfRangeException();
		}
	}

	public static void Add(List<EventDelegate> list, EventDelegate ev, bool oneShot)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_0035: Expected Obj, but got I4
		Execute(list);
		object obj = list + 8;
		obj = ev;
		object obj2 = list + 12;
		obj2 = oneShot;
	}

	public static bool Remove(List<EventDelegate> list, Callback callback)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<EventDelegate>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return Localization.LoadCSV((byte[])(object)list, (TextAsset)(object)callback, false);
	}

	public static bool Remove(List<EventDelegate> list, EventDelegate ev)
	{
		bool result;
		if (list != null)
		{
			int num = 0;
			object obj = default;
			while (true)
			{
				bool flag = num >= list._size;
				result = false;
				if (flag)
				{
					break;
				}
				EventDelegate eventDelegate = list.get_Item(num);
				if (eventDelegate != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
					if (obj != null)
					{
						list.RemoveAt(num);
						result = true;
						break;
					}
				}
				int num2 = num + 1;
				num = num2;
			}
		}
		else
		{
			result = false;
		}
		return result;
	}

	static EventDelegate()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		BetterList<string> mTemp = default;
		ByteReader.mTemp = mTemp;
	}
}

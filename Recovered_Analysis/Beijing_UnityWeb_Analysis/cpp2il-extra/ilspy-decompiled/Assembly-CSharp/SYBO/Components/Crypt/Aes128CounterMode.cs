using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Cpp2ILInjected;
using SYBO.Components.EditorExtensions;
using SYBO.Components.Json;
using SYBO.Components.Json.Internal;
using SYBO.Components.Logging;
using SYBO.Components.Utilities;

namespace SYBO.Components.Crypt;

public class Aes128CounterMode : SymmetricAlgorithm
{
	private readonly byte[] _counter;

	private readonly AesManaged _aes;

	public override byte[] Key
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			throw new ArrayTypeMismatchException();
		}
		set
		{
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected Obj, but got Unknown
			//IL_00cf: Expected Obj, but got I4
			//IL_00e2: Expected Obj, but got I4
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected Obj, but got Unknown
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected Obj, but got Unknown
			ModeValue = CipherMode.CBC;
			PaddingValue = PaddingMode.PKCS7;
			if (value == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ArgumentOutOfRangeException ex = default;
				ex._002Ector("counter");
				((Aes128CounterMode)(object)ex)._002Ector((byte[])null);
			}
			object obj2 = default;
			object obj = obj2 + 4;
			if (value.Length == 16)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				AesManaged aesManaged = default;
				aesManaged.GenerateIV();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
				object obj3 = this + 48;
				obj3 = aesManaged;
				object obj4 = this + 44;
				obj4 = value;
			}
			else
			{
				obj = value.Length;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				obj2 = 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				string format = default;
				object arg = default;
				string paramName = string.Format((IFormatProvider)(object)"Counter size must be same as block size (actual: {0}, expected: {1})", format, arg);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ArgumentNullException ex2 = default;
				ex2._002Ector(paramName);
				((Aes128CounterMode)(object)ex2)._002Ector((byte[])null);
			}
		}
	}

	public Aes128CounterMode(byte[] counter)
	{
		//IL_00c9: Expected I, but got Obj
		//IL_00df: Expected Obj, but got I
		//IL_0136: Expected I4, but got Obj
		//IL_0144: Expected I, but got Obj
		//IL_015a: Expected Obj, but got I
		//IL_0177: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BlockSizeValue = (int)counter;
		nint num3 = (nint)typeof(Log);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v12 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 == null;
		nint num4 = (nint)typeof(Log);
		if (!flag)
		{
			nint num5 = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v21 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num4 = (nint)typeof(Log);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num4 = (nint)typeof(Log);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ L1_v2 (Il2CppClass<SYBO.Components.Logging.Log>)+5C]");
		object obj3 = (nint)0 + (nint)20;
		obj3 = this;
		object obj4 = this + 12;
		obj4 = "EditorExtensions";
	}

	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] ignoredParameter)
	{
		//IL_008b: Expected Obj, but got I4
		//IL_0019: Expected Obj, but got I4
		JsonDict dict = ((JsonDict)ignoredParameter.Length).GetDict((string)(object)this);
		JsonDict result;
		if (dict != null)
		{
			JsonList jsonList = ((JsonCustomSerializerCollection)ignoredParameter.Length).SerializeList((Type)(object)this, rgbKey, (JsonContext)(object)ignoredParameter);
			result = (JsonDict)(object)jsonList;
		}
		else
		{
			result = JsonReflectionParser.ReflectionSerialize((Type)(object)this, rgbKey, (JsonContext)(object)ignoredParameter);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		int num = default;
		if (num != 0)
		{
			((JsonDict)(object)ignoredParameter)._002Ector(num);
		}
		return (ICryptoTransform)result;
	}

	public unsafe ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] ignoredParameter, int position)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0dcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd0: Expected I, but got Unknown
		//IL_0dd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dde: Expected Obj, but got Unknown
		//IL_0de7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dec: Expected Obj, but got Unknown
		//IL_0df5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfa: Expected Obj, but got Unknown
		//IL_0e03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e08: Expected Obj, but got Unknown
		//IL_0e11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e16: Expected Obj, but got Unknown
		//IL_0e1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e24: Expected Obj, but got Unknown
		//IL_0e2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e32: Expected Obj, but got Unknown
		//IL_0e3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e40: Expected Obj, but got Unknown
		//IL_0e49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4e: Expected Obj, but got Unknown
		//IL_0e57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5c: Expected Obj, but got Unknown
		//IL_0e65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6a: Expected Obj, but got Unknown
		//IL_0e73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e78: Expected Obj, but got Unknown
		//IL_0e81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e86: Expected Obj, but got Unknown
		//IL_0e8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e94: Expected Obj, but got Unknown
		//IL_0e9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea2: Expected Obj, but got Unknown
		//IL_0eab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb0: Expected Obj, but got Unknown
		//IL_0eb9: Expected Obj, but got I4
		//IL_0ec2: Expected Obj, but got I4
		//IL_0ecb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed0: Expected Obj, but got Unknown
		//IL_0028: Expected Obj, but got I
		//IL_0f06: Expected I, but got Obj
		//IL_0f1c: Expected Obj, but got I
		//IL_1571: Expected I, but got Obj
		//IL_01f7: Expected I, but got Obj
		//IL_020d: Expected Obj, but got I
		//IL_018f: Expected I, but got Obj
		//IL_008c: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I
		//IL_0fb2: Expected I, but got Obj
		//IL_01d8: Expected I4, but got Obj
		//IL_0f54: Expected I, but got Obj
		//IL_0f8d: Expected Obj, but got I4
		//IL_0238: Expected I, but got Obj
		//IL_00cd: Expected I, but got Obj
		//IL_0285: Expected I, but got Obj
		//IL_029b: Expected Obj, but got I
		//IL_0162: Expected Obj, but got I4
		//IL_0162: Expected Obj, but got I
		//IL_102b: Expected I, but got Obj
		//IL_0174: Expected Obj, but got I4
		//IL_013f: Expected Obj, but got I4
		//IL_013f: Expected Obj, but got I
		//IL_02c6: Expected I, but got Obj
		//IL_0313: Expected I, but got Obj
		//IL_0329: Expected Obj, but got I
		//IL_107d: Expected I, but got Obj
		//IL_0354: Expected I, but got Obj
		//IL_03a1: Expected I, but got Obj
		//IL_03b7: Expected Obj, but got I
		//IL_10cf: Expected I, but got Obj
		//IL_03e2: Expected I, but got Obj
		//IL_042f: Expected I, but got Obj
		//IL_0445: Expected Obj, but got I
		//IL_1121: Expected I, but got Obj
		//IL_0470: Expected I, but got Obj
		//IL_04bd: Expected I, but got Obj
		//IL_04d3: Expected Obj, but got I
		//IL_119a: Expected I, but got Obj
		//IL_04fe: Expected I, but got Obj
		//IL_1226: Expected I, but got Obj
		//IL_123c: Expected Obj, but got I
		//IL_1274: Expected I, but got Obj
		//IL_0592: Expected I, but got Obj
		//IL_05a8: Expected Obj, but got I
		//IL_0686: Expected I, but got Obj
		//IL_069c: Expected Obj, but got I
		//IL_0649: Expected I, but got Obj
		//IL_11ec: Expected I, but got Obj
		//IL_12c3: Expected I, but got Obj
		//IL_05d3: Expected I, but got Obj
		//IL_0704: Expected I, but got Obj
		//IL_071a: Expected Obj, but got I
		//IL_06c7: Expected I, but got Obj
		//IL_0601: Expected I4, but got Obj
		//IL_1312: Expected I, but got Obj
		//IL_07ca: Expected I, but got Obj
		//IL_07e0: Expected Obj, but got I
		//IL_0745: Expected I, but got Obj
		//IL_1361: Expected I, but got Obj
		//IL_088b: Expected I, but got Obj
		//IL_08a1: Expected Obj, but got I
		//IL_080b: Expected I, but got Obj
		//IL_13b0: Expected I, but got Obj
		//IL_0846: Expected I, but got Obj
		//IL_13f5: Expected I, but got Obj
		//IL_140b: Expected Obj, but got I
		//IL_08cc: Expected I, but got Obj
		//IL_1474: Expected I, but got Obj
		//IL_08fa: Expected Obj, but got I4
		//IL_090c: Expected Obj, but got I4
		//IL_0b0d: Expected Obj, but got I4
		//IL_0b1f: Expected Obj, but got I4
		//IL_0b28: Expected Obj, but got I4
		//IL_09ba: Expected I, but got Obj
		//IL_0b3f: Expected Obj, but got I4
		//IL_094a: Expected Obj, but got I4
		//IL_14e2: Expected Obj, but got I4
		//IL_098d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0992: Expected Obj, but got Unknown
		//IL_0c1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c24: Expected Obj, but got Unknown
		//IL_0c2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c32: Expected Obj, but got Unknown
		//IL_0c5e: Expected Obj, but got I4
		//IL_0ae5: Expected Obj, but got I4
		//IL_0a6a: Expected I4, but got Obj
		//IL_0d28: Expected Obj, but got I
		//IL_0d5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d63: Expected Obj, but got Unknown
		//IL_0d94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d99: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 112;
		nint num = (nint)(obj2 + 88);
		object obj3 = obj2 + 80;
		object obj4 = obj2 + 76;
		object obj5 = obj2 + 72;
		object obj6 = obj2 + 68;
		object obj7 = obj2 - -64;
		object obj8 = obj2 + 60;
		object obj9 = obj2 + 56;
		object obj10 = obj2 + 52;
		object obj11 = obj2 + 48;
		object obj12 = obj2 + 44;
		object obj13 = obj2 + 40;
		object obj14 = obj2 + 36;
		object obj15 = obj2 + 32;
		object obj16 = obj2 + 20;
		object obj17 = obj2 + 16;
		object obj18 = obj2 + 8;
		obj18 = 0;
		obj2 = 0;
		object obj19 = obj2 + 24;
		obj19 = obj;
		_ = -1;
		if (this != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [position @ L3 (System.Int32)+C]");
			JsonDict dict = ((JsonDict)0).GetDict((string)(object)rgbKey);
			if (dict != null && (ignoredParameter == null || ignoredParameter[0] == 0))
			{
				nint num2 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ S0_v438 (Il2CppClass<System.Type>)+BA]");
				object obj20 = (nint)0 & (nint)0x200;
				if (obj20 != null)
				{
					nint num3 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ S0_v453 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj3 = typeof(IList<>);
				((IntPtr*)num)->m_value = (void*)(nint)obj3;
				Type directoryPath = Type.internal_from_handle((IntPtr)num);
				bool flag = ((AssetLoaderPathAttribute)(object)rgbKey).ValidateDirectoryPath((string)(object)directoryPath);
				bool flag2 = flag;
				((JsonContext)position).EndSerialize();
				object result;
				if (flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [position @ L3 (System.Int32)+C]");
					result = ((JsonCustomSerializerCollection)0).DeserializeList((Type)(object)rgbKey, (JsonList)(object)this, (JsonContext)position);
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [position @ L3 (System.Int32)+C]");
					result = ((JsonCustomSerializerCollection)0).Deserialize((Type)(object)rgbKey, (JsonDict)(object)this, (JsonContext)position);
				}
				((JsonContext)position).ResolveKnownReferences();
				return (ICryptoTransform)result;
			}
			nint num4 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S0_v60 (Il2CppClass<System.Type>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num5 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S0_v429 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj4 = typeof(string);
			((IntPtr*)num)->m_value = (void*)(nint)obj4;
			Type type = Type.internal_from_handle((IntPtr)num);
			if ((object)rgbKey == type)
			{
				return (ICryptoTransform)((JsonList)(object)ignoredParameter).GetDict((int)this);
			}
			nint num6 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ S0_v71 (Il2CppClass<System.Type>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num7 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S0_v423 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj5 = typeof(IntPtr);
			((IntPtr*)num)->m_value = (void*)(nint)obj5;
			Type type2 = Type.internal_from_handle((IntPtr)num);
			if ((object)rgbKey != type2)
			{
				nint num8 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ S0_v87 (Il2CppClass<System.Type>)+BA]");
				object obj23 = (nint)0 & (nint)0x200;
				if (obj23 != null)
				{
					nint num9 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ S0_v419 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj6 = typeof(UIntPtr);
				((IntPtr*)num)->m_value = (void*)(nint)obj6;
				Type type3 = Type.internal_from_handle((IntPtr)num);
				if ((object)rgbKey != type3)
				{
					nint num10 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ S0_v98 (Il2CppClass<System.Type>)+BA]");
					object obj24 = (nint)0 & (nint)0x200;
					if (obj24 != null)
					{
						nint num11 = (nint)typeof(Type);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ S0_v415 (Il2CppClass<System.Type>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj7 = typeof(IntPtr?);
					((IntPtr*)num)->m_value = (void*)(nint)obj7;
					Type type4 = Type.internal_from_handle((IntPtr)num);
					if ((object)rgbKey != type4)
					{
						nint num12 = (nint)typeof(Type);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ S0_v109 (Il2CppClass<System.Type>)+BA]");
						object obj25 = (nint)0 & (nint)0x200;
						if (obj25 != null)
						{
							nint num13 = (nint)typeof(Type);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ S0_v411 (Il2CppClass<System.Type>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj8 = typeof(UIntPtr?);
						((IntPtr*)num)->m_value = (void*)(nint)obj8;
						Type type5 = Type.internal_from_handle((IntPtr)num);
						if ((object)rgbKey != type5)
						{
							nint num14 = (nint)typeof(Type);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ S0_v120 (Il2CppClass<System.Type>)+BA]");
							object obj26 = (nint)0 & (nint)0x200;
							if (obj26 != null)
							{
								nint num15 = (nint)typeof(Type);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ S0_v407 (Il2CppClass<System.Type>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							obj9 = typeof(ulong);
							((IntPtr*)num)->m_value = (void*)(nint)obj9;
							Type type6 = Type.internal_from_handle((IntPtr)num);
							if ((object)rgbKey != type6)
							{
								nint num16 = (nint)typeof(Type);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ S0_v136 (Il2CppClass<System.Type>)+BA]");
								object obj27 = (nint)0 & (nint)0x200;
								if (obj27 != null)
								{
									nint num17 = (nint)typeof(Type);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ S0_v404 (Il2CppClass<System.Type>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								obj10 = typeof(ulong?);
								((IntPtr*)num)->m_value = (void*)(nint)obj10;
								Type type7 = Type.internal_from_handle((IntPtr)num);
								if ((object)rgbKey != type7)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8592");
									object obj28 = default;
									if (obj28 != null)
									{
										return (ICryptoTransform)this;
									}
									if (ReflectionWrapper.IsAbstract((Type)(object)rgbKey))
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
										nint num18 = (nint)typeof(Type);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ S1_v224 (Il2CppClass<System.Type>)+BA]");
										object obj29 = (nint)0 & (nint)0x200;
										if (obj29 != null)
										{
											nint num19 = (nint)typeof(Type);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ S1_v234 (Il2CppClass<System.Type>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										obj11 = typeof(Nullable<>);
										((IntPtr*)num)->m_value = (void*)(nint)obj11;
										Type type8 = Type.internal_from_handle((IntPtr)num);
										object obj30 = default;
										if (obj30 == type8)
										{
											uint num20 = System.NumberFormatter.FastToDecHex((int)rgbKey);
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8592");
											object obj31 = default;
											if (obj31 != null)
											{
												return (ICryptoTransform)this;
											}
										}
									}
									nint num21 = (nint)typeof(Type);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ S0_v152 (Il2CppClass<System.Type>)+BA]");
									object obj32 = (nint)0 & (nint)0x200;
									if (obj32 != null)
									{
										nint num22 = (nint)typeof(Type);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ S0_v393 (Il2CppClass<System.Type>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									obj12 = typeof(JsonDict);
									((IntPtr*)num)->m_value = (void*)(nint)obj12;
									Type type9 = Type.internal_from_handle((IntPtr)num);
									if ((object)rgbKey == type9)
									{
										return (ICryptoTransform)this;
									}
									nint num23 = (nint)typeof(Type);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ S0_v163 (Il2CppClass<System.Type>)+BA]");
									object obj33 = (nint)0 & (nint)0x200;
									if (obj33 != null)
									{
										nint num24 = (nint)typeof(Type);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ S0_v389 (Il2CppClass<System.Type>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									obj13 = typeof(JsonList);
									((IntPtr*)num)->m_value = (void*)(nint)obj13;
									Type type10 = Type.internal_from_handle((IntPtr)num);
									if ((object)rgbKey == type10)
									{
										return (ICryptoTransform)this;
									}
									nint num25 = (nint)typeof(Type);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ S0_v174 (Il2CppClass<System.Type>)+BA]");
									object obj34 = (nint)0 & (nint)0x200;
									if (obj34 != null)
									{
										nint num26 = (nint)typeof(Type);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ S0_v385 (Il2CppClass<System.Type>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									obj14 = typeof(DateTime);
									((IntPtr*)num)->m_value = (void*)(nint)obj14;
									Type type11 = Type.internal_from_handle((IntPtr)num);
									if ((object)rgbKey == type11)
									{
										throw new NullReferenceException();
									}
									nint num27 = (nint)typeof(Type);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ S0_v185 (Il2CppClass<System.Type>)+BA]");
									object obj35 = (nint)0 & (nint)0x200;
									if (obj35 != null)
									{
										nint num28 = (nint)typeof(Type);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ S0_v378 (Il2CppClass<System.Type>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									obj15 = typeof(Guid);
									((IntPtr*)num)->m_value = (void*)(nint)obj15;
									Type type12 = Type.internal_from_handle((IntPtr)num);
									if ((object)rgbKey == type12)
									{
										NullReferenceException ex = new NullReferenceException();
										((IntPtr*)num)->m_value = (void*)(nint)ex;
										_ = ((Exception)ex)._className;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
										int index = default;
										return (ICryptoTransform)((JsonList)(object)ignoredParameter).GetDict(index);
									}
									nint num29 = (nint)typeof(Type);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ S0_v196 (Il2CppClass<System.Type>)+BA]");
									object obj36 = (nint)0 & (nint)0x200;
									if (obj36 != null)
									{
										nint num30 = (nint)typeof(Type);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ S0_v371 (Il2CppClass<System.Type>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									obj16 = typeof(IList<>);
									((IntPtr*)num)->m_value = (void*)(nint)obj16;
									Type directoryPath2 = Type.internal_from_handle((IntPtr)num);
									bool flag3 = ((AssetLoaderPathAttribute)(object)rgbKey).ValidateDirectoryPath((string)(object)directoryPath2);
									if (flag3)
									{
										bool flag4 = ReflectionWrapper.IsPrimitive((Type)flag3);
										object rgbKey2 = (flag4 ? 1 : 0) + 16;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
										JsonLogCategory jsonLogCategory = default;
										int categoryId = default;
										jsonLogCategory._002Ector(categoryId);
										object obj37 = 0;
										object obj38 = default;
										Aes128CounterMode aes128CounterMode = default;
										while (true)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
											if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj37) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj38))
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
											ICryptoTransform item = aes128CounterMode.CreateEncryptor((byte[])rgbKey2, ignoredParameter, position);
											((List<object>)(object)jsonLogCategory).Add((object)item);
											object obj39 = obj37 + 1;
											obj37 = obj39;
										}
										return (ICryptoTransform)jsonLogCategory;
									}
									nint num31 = (nint)typeof(Type);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ S0_v207 (Il2CppClass<System.Type>)+BA]");
									object obj40 = (nint)0 & (nint)0x200;
									if (obj40 != null)
									{
										nint num32 = (nint)typeof(Type);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v756 @ S0_v350 (Il2CppClass<System.Type>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									obj17 = typeof(IDictionary<, >);
									((IntPtr*)num)->m_value = (void*)(nint)obj17;
									Type directoryPath3 = Type.internal_from_handle((IntPtr)num);
									bool flag5 = ((AssetLoaderPathAttribute)(object)rgbKey).ValidateDirectoryPath((string)(object)directoryPath3);
									if (!flag5)
									{
										bool flag6 = ignoredParameter == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8595");
										object obj41 = default;
										if (obj41 != null)
										{
											if (!flag6 && ignoredParameter[1] != 0)
											{
												return (ICryptoTransform)((JsonList)(object)ignoredParameter).GetDict((int)this);
											}
											throw new NullReferenceException();
										}
										if (!flag6 && ignoredParameter[0] != 0)
										{
											string text = ((JsonFieldInfo)(object)ignoredParameter).ToLimitedString((object)this);
											((JsonCustomSerializerCollection)position).AddSerializer((Type)(object)ignoredParameter, (JsonCustomSerializer)(object)text);
											return (ICryptoTransform)(object)text;
										}
										return (ICryptoTransform)(object)((SimpleAES)(object)this).Encrypt((string)position);
									}
									bool flag7 = ReflectionWrapper.IsPrimitive((Type)flag5);
									object obj42 = (flag7 ? 1 : 0) + 16;
									bool flag8 = ReflectionWrapper.IsPrimitive((Type)flag5);
									object obj43 = (flag8 ? 1 : 0) + 20;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
									JsonList jsonList = default;
									int capacity = default;
									jsonList._002Ector(capacity);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
									object obj44 = default;
									object obj45 = default;
									while (true)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
										if (obj44 == null)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
										obj2 = obj45;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
									}
									object obj46 = obj19 + 4;
									object obj47 = obj46 + 1;
									obj46 = obj47;
									object obj48 = obj47 << 2;
									object obj49 = obj19 + obj48;
									obj49 = 704;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
									object obj50 = default;
									if (obj50 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v47+4]");
									if ((nint)0 != -1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v47+4]");
										object obj51 = (nint)0 << 2;
										object obj52 = obj19 + obj51;
										if ((nint)obj52 == 704)
										{
											object obj53 = obj19 + 4;
											if ((nint)obj53 > -1)
											{
												object obj54 = obj53 + -1;
												obj53 = obj54;
											}
											return (ICryptoTransform)jsonList;
										}
									}
									object obj55 = default;
									if (obj55 == null)
									{
										return (ICryptoTransform)jsonList;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							SerializedAsAttribute serializedAsAttribute = default;
							serializedAsAttribute._002Ector("ulongs are not supported.");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
						}
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			SerializedAsAttribute serializedAsAttribute2 = default;
			serializedAsAttribute2._002Ector("IntPtr types are not supported.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		ICryptoTransform result2 = default;
		return result2;
	}

	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] ignoredParameter)
	{
		//IL_0028: Expected I4, but got Obj
		//IL_0028: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		EncryptedCTRStream encryptedCTRStream = default;
		encryptedCTRStream.Write((byte[])(object)_aes, (int)rgbKey, (int)_counter);
		return (ICryptoTransform)encryptedCTRStream;
	}

	public override void GenerateKey()
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_007b: Expected Obj, but got I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0038: Expected I4, but got Obj
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		HashSet<> hashSet = default;
		((HashSet<T>)(object)hashSet).Clear();
		object obj = this + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = this + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			((EditorExtensionsLogCategory)obj5)._002Ector((int)hashSet);
			object obj6 = obj2 + 1;
			obj2 = obj6;
		}
	}

	public override void GenerateIV()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}
}

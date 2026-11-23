using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using FullSerializer.Internal;

namespace FullSerializer;

public class fsSerializer
{
	internal class fsLazyCycleDefinitionWriter
	{
		private Dictionary<int, fsData> _pendingDefinitions;

		private HashSet<int> _references;

		public unsafe void WriteDefinition(int id, fsData data)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_009f: Expected Obj, but got I
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected I4, but got Unknown
			//IL_0074: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 16;
			if (_references.Contains(id))
			{
				EnsureDictionary(data);
				Dictionary<string, fsData> asDictionary = data.AsDictionary;
				int num = obj + 12;
				string text = ((int*)num)->ToString();
				nint num2 = 0;
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S5_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+5C]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v102 @ S5_v10+4] (should have been resolved before IL gen)");
			}
			else
			{
				nint num4 = 0;
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, FullSerializer.fsData>>)+5C]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v45 @ S5_v5+4] (should have been resolved before IL gen)");
			}
		}

		public unsafe void WriteReference(int id, Dictionary<string, fsData> dict)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0129: Expected Obj, but got I
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Expected Obj, but got Unknown
			//IL_00d2: Expected Obj, but got I
			//IL_0175: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Expected I4, but got Unknown
			//IL_0102: Expected Obj, but got I
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected I4, but got Unknown
			//IL_008c: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 16;
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, FullSerializer.fsData>>)+54]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S3_v4+4] (should have been resolved before IL gen)");
			object obj5 = default;
			object obj4 = obj5 ^ -1;
			object obj6 = obj4 >> 31;
			if (obj6 != null)
			{
				fsData fsData2 = _pendingDefinitions.get_Item(id);
				EnsureDictionary(fsData2);
				Dictionary<string, fsData> asDictionary = fsData2.AsDictionary;
				int num3 = obj + 12;
				string text = ((int*)num3)->ToString();
				nint num4 = 0;
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S5_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+5C]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v162 @ S5_v10+4] (should have been resolved before IL gen)");
				Dictionary<int, fsData> pendingDefinitions = _pendingDefinitions;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				bool flag = pendingDefinitions.Remove(0);
			}
			else
			{
				nint num6 = 0;
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S3_v10 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Int32>>)+3C]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v58 @ S3_v11+4] (should have been resolved before IL gen)");
			}
			int num8 = obj + 12;
			string text2 = ((int*)num8)->ToString();
			nint num9 = 0;
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+5C]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v140 @ S5_v5+4] (should have been resolved before IL gen)");
		}

		public void Clear()
		{
			throw new IndexOutOfRangeException();
		}

		public fsLazyCycleDefinitionWriter()
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, FullSerializer.fsData>>>)+4] (should have been resolved before IL gen)");
			Dictionary<int, fsData> pendingDefinitions = default;
			_pendingDefinitions = pendingDefinitions;
			HashSet<int> hashSet = default;
			hashSet._002Ector();
			_references = hashSet;
		}
	}

	private static HashSet<string> _reservedKeywords;

	private static readonly string Key_ObjectReference;

	private static readonly string Key_ObjectDefinition;

	private static readonly string Key_InstanceType;

	private static readonly string Key_Version;

	private static readonly string Key_Content;

	private Dictionary<Type, fsBaseConverter> _cachedConverterTypeInstances;

	private Dictionary<Type, fsBaseConverter> _cachedConverters;

	private Dictionary<Type, List<fsObjectProcessor>> _cachedProcessors;

	private readonly List<fsConverter> _availableConverters;

	private readonly Dictionary<Type, fsDirectConverter> _availableDirectConverters;

	private readonly List<fsObjectProcessor> _processors;

	private readonly fsCyclicReferenceManager _references;

	private readonly fsLazyCycleDefinitionWriter _lazyReferenceWriter;

	private readonly Dictionary<Type, Type> _abstractTypeRemap;

	public fsContext Context;

	public fsConfig Config;

	static fsSerializer()
	{
		//IL_0091: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I
		//IL_00dd: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I
		//IL_0129: Expected Obj, but got I
		string key_ObjectReference = $"{fsGlobalConfig.InternalFieldPrefix}ref";
		Key_ObjectReference = key_ObjectReference;
		string key_ObjectDefinition = $"{fsGlobalConfig.InternalFieldPrefix}id";
		Key_ObjectDefinition = key_ObjectDefinition;
		string key_InstanceType = $"{fsGlobalConfig.InternalFieldPrefix}type";
		Key_InstanceType = key_InstanceType;
		string key_Version = $"{fsGlobalConfig.InternalFieldPrefix}version";
		Key_Version = key_Version;
		string key_Content = $"{fsGlobalConfig.InternalFieldPrefix}content";
		Key_Content = key_Content;
		HashSet<string> hashSet = default;
		hashSet._002Ector();
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.String>>)+3C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v120 @ S3_v4+4] (should have been resolved before IL gen)");
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S3_v8 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.String>>)+3C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v137 @ S3_v9+4] (should have been resolved before IL gen)");
		nint num5 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S3_v13 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.String>>)+3C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v154 @ S3_v14+4] (should have been resolved before IL gen)");
		nint num7 = 0;
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S3_v18 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.String>>)+3C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v171 @ S3_v19+4] (should have been resolved before IL gen)");
		nint num9 = 0;
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S3_v23 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.String>>)+3C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v188 @ S3_v24+4] (should have been resolved before IL gen)");
		_reservedKeywords = hashSet;
	}

	public static bool IsReservedKeyword(string key)
	{
		return _reservedKeywords.Contains(key);
	}

	private static bool IsObjectReference(fsData data)
	{
		//IL_0033: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0059: Expected I4, but got Obj
		if (data.IsDictionary)
		{
			Dictionary<string, fsData> asDictionary = data.AsDictionary;
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S3_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+54]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S3_v5+4] (should have been resolved before IL gen)");
			object obj3 = default;
			object obj2 = obj3 ^ -1;
			return (byte)(obj2 >> 31) != 0;
		}
		return false;
	}

	private static bool IsObjectDefinition(fsData data)
	{
		//IL_0033: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0059: Expected I4, but got Obj
		if (data.IsDictionary)
		{
			Dictionary<string, fsData> asDictionary = data.AsDictionary;
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S3_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+54]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S3_v5+4] (should have been resolved before IL gen)");
			object obj3 = default;
			object obj2 = obj3 ^ -1;
			return (byte)(obj2 >> 31) != 0;
		}
		return false;
	}

	private static bool IsVersioned(fsData data)
	{
		//IL_0033: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0059: Expected I4, but got Obj
		if (data.IsDictionary)
		{
			Dictionary<string, fsData> asDictionary = data.AsDictionary;
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S3_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+54]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S3_v5+4] (should have been resolved before IL gen)");
			object obj3 = default;
			object obj2 = obj3 ^ -1;
			return (byte)(obj2 >> 31) != 0;
		}
		return false;
	}

	private static bool IsTypeSpecified(fsData data)
	{
		//IL_0033: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0059: Expected I4, but got Obj
		if (data.IsDictionary)
		{
			Dictionary<string, fsData> asDictionary = data.AsDictionary;
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S3_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+54]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S3_v5+4] (should have been resolved before IL gen)");
			object obj3 = default;
			object obj2 = obj3 ^ -1;
			return (byte)(obj2 >> 31) != 0;
		}
		return false;
	}

	private static bool IsWrappedData(fsData data)
	{
		//IL_0033: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0059: Expected I4, but got Obj
		if (data.IsDictionary)
		{
			Dictionary<string, fsData> asDictionary = data.AsDictionary;
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S3_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+54]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S3_v5+4] (should have been resolved before IL gen)");
			object obj3 = default;
			object obj2 = obj3 ^ -1;
			return (byte)(obj2 >> 31) != 0;
		}
		return false;
	}

	public unsafe static void StripDeserializationMetadata(ref fsData data)
	{
		//IL_0034: Expected Obj, but got I
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		if (data.IsDictionary)
		{
			Dictionary<string, fsData> asDictionary = data.AsDictionary;
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S3_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+54]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v61 @ S3_v5+4] (should have been resolved before IL gen)");
			object obj3 = default;
			object obj2 = obj3 ^ -1;
			object obj4 = obj2 >> 31;
			if (obj4 != null)
			{
				Dictionary<string, fsData> asDictionary2 = data.AsDictionary;
				fsData fsData2 = asDictionary2.get_Item(Key_Content);
				ref fsData reference = ref *(fsData*)fsData2;
			}
		}
		if (data.IsDictionary)
		{
			Dictionary<string, fsData> asDictionary3 = data.AsDictionary;
			bool flag = asDictionary3.Remove(Key_ObjectReference);
			bool flag2 = asDictionary3.Remove(Key_ObjectDefinition);
			bool flag3 = asDictionary3.Remove(Key_InstanceType);
			bool flag4 = asDictionary3.Remove(Key_Version);
		}
	}

	private unsafe static void ConvertLegacyData(ref fsData data)
	{
		//IL_002a: Expected Obj, but got I4
		//IL_005e: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I4
		//IL_022a: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_0180: Expected Obj, but got I
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_0266: Expected Obj, but got I
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		//IL_00f9: Expected Obj, but got I
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_01df: Expected Obj, but got I
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected Obj, but got Unknown
		//IL_0300: Expected Obj, but got I
		//IL_0387: Expected Obj, but got I
		//IL_040a: Expected Obj, but got I
		if (!data.IsDictionary)
		{
			return;
		}
		Dictionary<string, fsData> asDictionary = data.AsDictionary;
		object obj = asDictionary._count - asDictionary._freeCount;
		if ((nint)obj > 2)
		{
			return;
		}
		object obj2 = asDictionary._count - asDictionary._freeCount;
		if ((nint)obj2 == 2)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S3_v27 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+54]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v140 @ S3_v28+4] (should have been resolved before IL gen)");
			object obj5 = default;
			object obj4 = obj5 ^ -1;
			object obj6 = obj4 >> 31;
			if (obj6 != null)
			{
				nint num3 = 0;
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S3_v32 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+54]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v175 @ S3_v33+4] (should have been resolved before IL gen)");
				object obj9 = default;
				object obj8 = obj9 ^ -1;
				object obj10 = obj8 >> 31;
				if (obj10 != null)
				{
					fsData fsData2 = asDictionary.get_Item("Data");
					ref fsData reference = ref *(fsData*)fsData2;
					EnsureDictionary(data);
					ConvertLegacyData(ref data);
					Dictionary<string, fsData> asDictionary2 = data.AsDictionary;
					fsData fsData3 = asDictionary.get_Item("Type");
					nint num5 = 0;
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S5_v14 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+5C]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v311 @ S5_v15+4] (should have been resolved before IL gen)");
					return;
				}
			}
		}
		object obj12 = asDictionary._count - asDictionary._freeCount;
		if ((nint)obj12 == 2)
		{
			nint num7 = 0;
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S3_v13 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+54]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v190 @ S3_v14+4] (should have been resolved before IL gen)");
			object obj15 = default;
			object obj14 = obj15 ^ -1;
			object obj16 = obj14 >> 31;
			if (obj16 != null)
			{
				nint num9 = 0;
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S3_v18 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+54]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v227 @ S3_v19+4] (should have been resolved before IL gen)");
				object obj19 = default;
				object obj18 = obj19 ^ -1;
				object obj20 = obj18 >> 31;
				if (obj20 != null)
				{
					fsData fsData4 = asDictionary.get_Item("Data");
					ref fsData reference = ref *(fsData*)fsData4;
					EnsureDictionary(data);
					ConvertLegacyData(ref data);
					Dictionary<string, fsData> asDictionary3 = data.AsDictionary;
					fsData fsData5 = asDictionary.get_Item("SourceId");
					nint num11 = 0;
					nint num12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S5_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+5C]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v334 @ S5_v10+4] (should have been resolved before IL gen)");
					return;
				}
			}
		}
		object obj22 = asDictionary._count - asDictionary._freeCount;
		if ((nint)obj22 == 1)
		{
			nint num13 = 0;
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S3_v6 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+54]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v240 @ S3_v7+4] (should have been resolved before IL gen)");
			object obj25 = default;
			object obj24 = obj25 ^ -1;
			object obj26 = obj24 >> 31;
			if (obj26 != null)
			{
				fsData fsData6 = fsData.CreateDictionary();
				ref fsData reference = ref *(fsData*)fsData6;
				Dictionary<string, fsData> asDictionary4 = data.AsDictionary;
				fsData fsData7 = asDictionary.get_Item("ReferenceId");
				nint num15 = 0;
				nint num16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+5C]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v326 @ S5_v5+4] (should have been resolved before IL gen)");
			}
		}
	}

	private static void Invoke_OnBeforeSerialize(List<fsObjectProcessor> processors, Type storageType, object instance)
	{
		//IL_001e: Expected I, but got Obj
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		int num = 0;
		while (num < processors._size)
		{
			fsObjectProcessor fsObjectProcessor2 = processors.get_Item(num);
			nint num2 = (nint)fsObjectProcessor2;
			object obj = fsObjectProcessor2 + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v53 @ S3_v3 (Il2CppClass<FullSerializer.fsObjectProcessor>)+E4] (should have been resolved before IL gen)");
			int num3 = num + 1;
			num = num3;
		}
	}

	private static void Invoke_OnAfterSerialize(List<fsObjectProcessor> processors, Type storageType, object instance, ref fsData data)
	{
		//IL_001e: Expected I, but got Obj
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		int num = processors._size;
		while (true)
		{
			int num2 = num - 1;
			if (num2 > -1)
			{
				fsObjectProcessor fsObjectProcessor2 = processors.get_Item(num2);
				nint num3 = (nint)fsObjectProcessor2;
				object obj = fsObjectProcessor2 + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v57 @ S4_v3 (Il2CppClass<FullSerializer.fsObjectProcessor>)+EC] (should have been resolved before IL gen)");
				num = num2;
				continue;
			}
			break;
		}
	}

	private static void Invoke_OnBeforeDeserialize(List<fsObjectProcessor> processors, Type storageType, ref fsData data)
	{
		//IL_001e: Expected I, but got Obj
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		int num = 0;
		while (num < processors._size)
		{
			fsObjectProcessor fsObjectProcessor2 = processors.get_Item(num);
			nint num2 = (nint)fsObjectProcessor2;
			object obj = fsObjectProcessor2 + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v53 @ S3_v3 (Il2CppClass<FullSerializer.fsObjectProcessor>)+F4] (should have been resolved before IL gen)");
			int num3 = num + 1;
			num = num3;
		}
	}

	private static void Invoke_OnBeforeDeserializeAfterInstanceCreation(List<fsObjectProcessor> processors, Type storageType, object instance, ref fsData data)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		int num = 0;
		while (num < processors._size)
		{
			fsObjectProcessor fsObjectProcessor2 = processors.get_Item(num);
			object obj = fsObjectProcessor2 - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v59 @ S4_v4+BC] (should have been resolved before IL gen)");
			int num2 = num + 1;
			num = num2;
		}
	}

	private static void Invoke_OnAfterDeserialize(List<fsObjectProcessor> processors, Type storageType, object instance)
	{
		//IL_001e: Expected I, but got Obj
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		int num = processors._size;
		while (true)
		{
			int num2 = num - 1;
			if (num2 > -1)
			{
				fsObjectProcessor fsObjectProcessor2 = processors.get_Item(num2);
				nint num3 = (nint)fsObjectProcessor2;
				object obj = fsObjectProcessor2 + 72;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v53 @ S3_v3 (Il2CppClass<FullSerializer.fsObjectProcessor>)+104] (should have been resolved before IL gen)");
				num = num2;
				continue;
			}
			break;
		}
	}

	private static void EnsureDictionary(fsData data)
	{
		//IL_004e: Expected Obj, but got I
		if (!data.IsDictionary)
		{
			fsData fsData2 = data.Clone();
			data.BecomeDictionary();
			Dictionary<string, fsData> asDictionary = data.AsDictionary;
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+5C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v60 @ S5_v5+4] (should have been resolved before IL gen)");
		}
	}

	private unsafe void RemapAbstractStorageTypeToDefaultType(ref Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0078: Expected I, but got Obj
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Ref, but got Unknown
		//IL_0024: Expected I, but got Obj
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_00b0: Expected I, but got Obj
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Ref, but got Unknown
		//IL_0109: Expected I, but got Obj
		//IL_0123: Expected Obj, but got I
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10FF");
		object obj3 = default;
		if (obj3 == null)
		{
			Type type = storageType;
			nint num = (nint)type;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S1_v26 (Il2CppClass<System.Type>)+274] (should have been resolved before IL gen)");
			object obj5 = default;
			object obj4 = obj5 & 0x80;
			object obj6 = obj4 >> 7;
			if (obj6 == null)
			{
				return;
			}
		}
		Type type2 = storageType;
		nint num2 = (nint)type2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v51 @ S1_v10 (Il2CppClass<System.Type>)+1FC] (should have been resolved before IL gen)");
		object obj7 = default;
		if (obj7 != null)
		{
			Type type3 = storageType;
			nint num3 = (nint)type3;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v102 @ S2_v8 (Il2CppClass<System.Type>)+23C] (should have been resolved before IL gen)");
			Type key = default;
			if (_abstractTypeRemap.TryGetValue(key, out *(Type*)(obj + 12)))
			{
				Type type4 = storageType;
				nint num4 = (nint)type4;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v120 @ S1_v20 (Il2CppClass<System.Type>)+24C] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				object obj8 = 0;
				object obj9 = obj8 + 992;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v132 @ S3_v12+BC] (should have been resolved before IL gen)");
				object obj10 = default;
				ref Type reference = ref *(Type*)obj10;
			}
		}
		else if (_abstractTypeRemap.TryGetValue(storageType, out *(Type*)(obj + 8)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			ref Type reference = ref *(Type*)null;
		}
	}

	public fsSerializer()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0275: Expected VT, but got Obj
		//IL_028d: Expected VT, but got Obj
		//IL_02b3: Expected VT, but got Obj
		//IL_02c6: Expected VT, but got Obj
		//IL_02ec: Expected VT, but got Obj
		//IL_0304: Expected VT, but got Obj
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected Obj, but got Unknown
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected Obj, but got Unknown
		//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cb: Expected Obj, but got Unknown
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ac: Expected Obj, but got Unknown
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Expected Obj, but got Unknown
		//IL_062c: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, FullSerializer.fsBaseConverter>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Type, fsBaseConverter> cachedConverterTypeInstances = default;
		_cachedConverterTypeInstances = cachedConverterTypeInstances;
		nint num3 = 0;
		nint num4 = 0;
		IntPtr intPtr2 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v57 @ S4_v9 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, FullSerializer.fsBaseConverter>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Type, fsBaseConverter> cachedConverters = default;
		_cachedConverters = cachedConverters;
		nint num5 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v78 @ S4_v14 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, System.Collections.Generic.List`1<FullSerializer.fsObjectProcessor>>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Type, List<fsObjectProcessor>> cachedProcessors = default;
		_cachedProcessors = cachedProcessors;
		fsCyclicReferenceManager fsCyclicReferenceManager2 = default;
		fsCyclicReferenceManager2._002Ector();
		_references = fsCyclicReferenceManager2;
		fsLazyCycleDefinitionWriter fsLazyCycleDefinitionWriter2 = default;
		fsLazyCycleDefinitionWriter2._002Ector();
		_lazyReferenceWriter = fsLazyCycleDefinitionWriter2;
		List<fsConverter> list = default;
		list._002Ector();
		fsConverter fsConverter2 = default;
		fsConverter2.Serializer = this;
		list.Add(fsConverter2);
		fsConverter fsConverter3 = default;
		fsConverter3.Serializer = this;
		list.Add(fsConverter3);
		fsConverter fsConverter4 = default;
		fsConverter4.Serializer = this;
		list.Add(fsConverter4);
		fsConverter fsConverter5 = default;
		fsConverter5.Serializer = this;
		list.Add(fsConverter5);
		fsConverter fsConverter6 = default;
		fsConverter6.Serializer = this;
		list.Add(fsConverter6);
		fsConverter fsConverter7 = default;
		fsConverter7.Serializer = this;
		list.Add(fsConverter7);
		fsConverter fsConverter8 = default;
		fsConverter8.Serializer = this;
		list.Add(fsConverter8);
		fsConverter fsConverter9 = default;
		fsConverter9.Serializer = this;
		list.Add(fsConverter9);
		fsConverter fsConverter10 = default;
		fsConverter10.Serializer = this;
		list.Add(fsConverter10);
		fsConverter fsConverter11 = default;
		fsConverter11.Serializer = this;
		list.Add(fsConverter11);
		fsConverter fsConverter12 = default;
		fsConverter12.Serializer = this;
		list.Add(fsConverter12);
		fsConverter fsConverter13 = default;
		fsConverter13.Serializer = this;
		list.Add(fsConverter13);
		_availableConverters = list;
		nint num7 = 0;
		nint num8 = 0;
		IntPtr intPtr3 = num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v259 @ S4_v19 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, FullSerializer.fsDirectConverter>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Type, fsDirectConverter> availableDirectConverters = default;
		_availableDirectConverters = availableDirectConverters;
		List<fsObjectProcessor> list2 = default;
		list2._002Ector();
		fsObjectProcessor item = default;
		list2.Add(item);
		_processors = list2;
		fsObjectProcessor item2 = default;
		_processors.Add(item2);
		nint num9 = 0;
		nint num10 = 0;
		IntPtr intPtr4 = num10;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v307 @ S4_v24 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, System.Type>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Type, Type> abstractTypeRemap = default;
		_abstractTypeRemap = abstractTypeRemap;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(ICollection<>));
		Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(List<>));
		SetDefaultStorageType(typeFromHandle, typeFromHandle2);
		Type typeFromHandle3 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(IList<>));
		Type typeFromHandle4 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(List<>));
		SetDefaultStorageType(typeFromHandle3, typeFromHandle4);
		Type typeFromHandle5 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(IDictionary<, >));
		Type typeFromHandle6 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Dictionary<, >));
		SetDefaultStorageType(typeFromHandle5, typeFromHandle6);
		fsContext fsContext2 = default;
		fsContext2._002Ector();
		Context = fsContext2;
		fsConfig fsConfig2 = default;
		fsConfig2._002Ector();
		Config = fsConfig2;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								continue;
							}
						}
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj8 == obj9;
			bool flag3 = !flag2;
			object obj10 = obj11;
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
				obj10 = obj12;
			}
			_ = 0;
			object obj13 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj7 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj14 = obj7 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A0D");
	}

	public void AddProcessor(fsObjectProcessor processor)
	{
		_processors.Add(processor);
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, System.Collections.Generic.List`1<FullSerializer.fsObjectProcessor>>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Type, List<fsObjectProcessor>> cachedProcessors = default;
		_cachedProcessors = cachedProcessors;
	}

	public void RemoveProcessor<TProcessor>()
	{
		int num = default;
		object obj = default;
		int num2 = default;
		while (true)
		{
			List<fsObjectProcessor> processors = _processors;
			if (num >= processors._size)
			{
				break;
			}
			fsObjectProcessor fsObjectProcessor2 = _processors.get_Item(num);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
			if (obj != null)
			{
				_processors.RemoveAt(num);
			}
			else
			{
				num = num2 + 1;
			}
		}
		nint num3 = 0;
		nint num4 = 0;
		IntPtr intPtr = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v57 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, System.Collections.Generic.List`1<FullSerializer.fsObjectProcessor>>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Type, List<fsObjectProcessor>> cachedProcessors = default;
		_cachedProcessors = cachedProcessors;
	}

	public void SetDefaultStorageType(Type abstractType, Type defaultStorageType)
	{
		//IL_00b6: Expected Obj, but got I
		//IL_000d: Expected I, but got Obj
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10FF");
		object obj = default;
		if (obj == null)
		{
			nint num = (nint)abstractType;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ S1_v6 (Il2CppClass<System.Type>)+274] (should have been resolved before IL gen)");
			object obj3 = default;
			object obj2 = obj3 & 0x80;
			object obj4 = obj2 >> 7;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				ArgumentException ex = default;
				ex._002Ector("|abstractType| must be an interface or abstract type");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			}
		}
		nint num2 = 0;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, System.Type>>)+5C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v53 @ S5_v4+4] (should have been resolved before IL gen)");
	}

	private unsafe List<fsObjectProcessor> GetProcessors(Type type)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Ref, but got Unknown
		//IL_01d4: Expected Obj, but got I
		//IL_0188: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I
		//IL_0110: Expected I, but got Obj
		//IL_014c: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		fsObjectAttribute attribute = fsPortableReflection.GetAttribute<fsObjectAttribute>(type);
		if (attribute != null && (object)attribute.Processor != null)
		{
			object obj3 = Activator.CreateInstance(attribute.Processor);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
			List<fsObjectProcessor> list = default;
			list._002Ector();
			fsObjectProcessor item = default;
			list.Add(item);
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S5_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, System.Collections.Generic.List`1<FullSerializer.fsObjectProcessor>>>)+5C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ S5_v10+4] (should have been resolved before IL gen)");
		}
		else if (!_cachedProcessors.TryGetValue(type, out *(List<fsObjectProcessor>*)(obj + 12)))
		{
			List<fsObjectProcessor> list2 = default;
			list2._002Ector();
			int num3 = 0;
			object obj5 = default;
			while (true)
			{
				List<fsObjectProcessor> processors = _processors;
				if (num3 >= processors._size)
				{
					break;
				}
				fsObjectProcessor fsObjectProcessor2 = _processors.get_Item(num3);
				nint num4 = (nint)fsObjectProcessor2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v176 @ S2_v10 (Il2CppClass<FullSerializer.fsObjectProcessor>)+DC] (should have been resolved before IL gen)");
				if (obj5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
					((List<fsObjectProcessor>)0).Add(fsObjectProcessor2);
				}
				int num5 = num3 + 1;
				num3 = num5;
			}
			nint num6 = 0;
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, System.Collections.Generic.List`1<FullSerializer.fsObjectProcessor>>>)+5C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v161 @ S5_v5+4] (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		return (List<fsObjectProcessor>)0;
	}

	public void AddConverter(fsBaseConverter converter)
	{
		//IL_00f8: Expected I, but got Obj
		//IL_0121: Expected I, but got Obj
		//IL_0064: Expected Obj, but got I
		string message;
		if (converter.Serializer == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			object obj = default;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
				object obj3 = default;
				object obj2 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v52 @ S2_v17+104] (should have been resolved before IL gen)");
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, FullSerializer.fsDirectConverter>>)+5C]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v69 @ S5_v5+4] (should have been resolved before IL gen)");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				object obj5 = default;
				if (obj5 == null)
				{
					nint num3 = (nint)converter;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v155 @ S2_v10 (Il2CppClass<FullSerializer.fsBaseConverter>)+D4] (should have been resolved before IL gen)");
					string text = default;
					message = "Unable to add converter " + text + "; the type association strategy is unknown. Please use either fsDirectConverter or fsConverter as your base type.";
					goto IL_0147;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
				fsConverter item = default;
				_availableConverters.Insert(0, item);
			}
			converter.Serializer = this;
			nint num4 = 0;
			nint num5 = 0;
			IntPtr intPtr = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v127 @ S4_v5 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, FullSerializer.fsBaseConverter>>>)+4] (should have been resolved before IL gen)");
			Dictionary<Type, fsBaseConverter> cachedConverters = default;
			_cachedConverters = cachedConverters;
			return;
		}
		nint num6 = (nint)converter;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ S2_v4 (Il2CppClass<FullSerializer.fsBaseConverter>)+D4] (should have been resolved before IL gen)");
		string text2 = default;
		message = "Cannot add a single converter instance to multiple fsConverters -- please construct a new instance for " + text2;
		goto IL_0147;
		IL_0147:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		InvalidOperationException ex = default;
		ex._002Ector(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	private unsafe fsBaseConverter GetConverter(Type type, Type overrideConverterType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Ref, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Ref, but got Unknown
		//IL_00f8: Expected Obj, but got I
		//IL_03f2: Expected Obj, but got I
		//IL_009b: Expected Obj, but got I
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Ref, but got Unknown
		//IL_020d: Expected Obj, but got I
		//IL_0227: Expected Obj, but got I
		//IL_027b: Expected Obj, but got I
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected Obj, but got Unknown
		//IL_0192: Expected Obj, but got I
		//IL_01ac: Expected Obj, but got I
		//IL_036d: Expected I, but got Obj
		//IL_045e: Expected Obj, but got I
		//IL_02d8: Expected I, but got Obj
		//IL_0333: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		if ((object)overrideConverterType != null)
		{
			if (!_cachedConverterTypeInstances.TryGetValue(overrideConverterType, out *(fsBaseConverter*)(obj + 8)))
			{
				object obj3 = Activator.CreateInstance(overrideConverterType);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S5_v25 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, FullSerializer.fsBaseConverter>>)+5C]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v159 @ S5_v26+4] (should have been resolved before IL gen)");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			return (fsBaseConverter)0;
		}
		Type type2 = default;
		if (_cachedConverters.TryGetValue(type2, out *(fsBaseConverter*)(obj + 12)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			return (fsBaseConverter)0;
		}
		fsObjectAttribute attribute = fsPortableReflection.GetAttribute<fsObjectAttribute>(type2);
		if (attribute != null && (object)attribute.Converter != null)
		{
			object obj5 = Activator.CreateInstance(attribute.Converter);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S5_v19 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, FullSerializer.fsBaseConverter>>)+5C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v214 @ S5_v20+4] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			return (fsBaseConverter)0;
		}
		fsForwardAttribute attribute2 = fsPortableReflection.GetAttribute<fsForwardAttribute>(type2);
		if (attribute2 != null)
		{
			_ = attribute2.MemberName;
			nint num5 = 0;
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S5_v14 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, FullSerializer.fsBaseConverter>>)+5C]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v232 @ S5_v15+4] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			return (fsBaseConverter)0;
		}
		if (!_cachedConverters.TryGetValue(type2, out *(fsBaseConverter*)(obj + 12)))
		{
			nint num7 = 0;
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S3_v15 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, FullSerializer.fsDirectConverter>>)+54]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v245 @ S3_v16+4] (should have been resolved before IL gen)");
			object obj10 = default;
			object obj9 = obj10 ^ -1;
			object obj11 = obj9 >> 31;
			if (obj11 != null)
			{
				goto IL_0427;
			}
			int num9 = 0;
			object obj12 = default;
			while (true)
			{
				List<fsConverter> availableConverters = _availableConverters;
				if (num9 >= availableConverters._size)
				{
					break;
				}
				fsConverter fsConverter2 = _availableConverters.get_Item(num9);
				nint num10 = (nint)fsConverter2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v347 @ S2_v24 (Il2CppClass<FullSerializer.fsConverter>)+104] (should have been resolved before IL gen)");
				if (obj12 != null)
				{
					fsConverter result = _availableConverters.get_Item(num9);
					nint num11 = 0;
					nint num12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ S5_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, FullSerializer.fsBaseConverter>>)+5C]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v369 @ S5_v10+4] (should have been resolved before IL gen)");
					return result;
				}
				int num13 = num9 + 1;
				num9 = num13;
			}
		}
		bool flag = (object)type2 == null;
		string text = "Internal error -- could not find a converter for ";
		string text2 = null;
		if (!flag)
		{
			nint num14 = (nint)type2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v339 @ S1_v25 (Il2CppClass<System.Type>)+D4] (should have been resolved before IL gen)");
			text = "Internal error -- could not find a converter for ";
			string text3 = default;
			text2 = text3;
		}
		string text4 = text + text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		InvalidOperationException ex = default;
		ex._002Ector(text4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		goto IL_0427;
		IL_0427:
		fsDirectConverter result2 = ((fsSerializer)(object)text4)._availableDirectConverters.get_Item((Type)(object)ex);
		nint num15 = 0;
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, FullSerializer.fsBaseConverter>>)+5C]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v315 @ S5_v5+4] (should have been resolved before IL gen)");
		return result2;
	}

	public unsafe fsResult TrySerialize<T>(T instance, out fsData data)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_003c: Expected VT, but got I
		//IL_0052: Expected Obj, but got VT
		//IL_0023: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		nint num = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		fsResult fsResult2 = TrySerialize(typeFromHandle, instance, out data);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		fsResult fsResult3 = default;
		((fsResult*)(nint)fsResult3)->_success = false;
		return fsResult3;
	}

	public unsafe fsResult TryDeserialize<T>(fsData data, ref T instance)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00a7: Expected VT, but got I
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Ref, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0085: Expected I4, but got Obj
		//IL_0080: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		System.Runtime.CompilerServices.Unsafe.As<T, object>(ref instance);
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v9 (Il2CppMethodRgctx<FullSerializer.fsSerializer::TryDeserialize>)+4]");
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		fsResult fsResult2 = TryDeserialize(data, typeFromHandle, ref *(object*)(obj + 12));
		object obj3 = obj & 0xFF;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
			object obj4 = default;
			ref T reference = ref *(T*)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		}
		fsResult fsResult3 = default;
		((fsResult*)(nint)fsResult3)->_success = (byte)(int)obj != 0;
		return fsResult3;
	}

	public unsafe fsResult TrySerialize(Type storageType, object instance, out fsData data)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0035: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		fsResult fsResult2 = TrySerialize(storageType, null, instance, out data);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		fsResult fsResult3 = default;
		((fsResult*)(nint)fsResult3)->_success = false;
		return fsResult3;
	}

	public unsafe fsResult TrySerialize(Type storageType, Type overrideConverterType, object instance, out fsData data)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00be: Expected native int or pointer, but got VT
		//IL_008f: Expected I4, but got VT
		//IL_008a: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		Type type = default;
		if (instance != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
		}
		else
		{
			type = storageType;
		}
		List<fsObjectProcessor> processors = GetProcessors(type);
		Invoke_OnBeforeSerialize(processors, storageType, instance);
		fsResult fsResult2 = default;
		if (instance == null)
		{
			_ = 0;
			object obj3 = default;
			ref fsData reference = ref *(fsData*)obj3;
			Invoke_OnAfterSerialize(processors, storageType, null, ref data);
			((fsResult*)(nint)fsResult2)->_success = (byte)(int)fsResult.Success != 0;
		}
		else
		{
			fsResult fsResult3 = InternalSerialize_1_ProcessCycles(storageType, overrideConverterType, instance, out data);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			((fsResult*)(nint)fsResult2)->_success = false;
			Invoke_OnAfterSerialize(processors, storageType, instance, ref data);
		}
		return fsResult2;
	}

	private unsafe fsResult InternalSerialize_1_ProcessCycles(Type storageType, Type overrideConverterType, object instance, out fsData data)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0760: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Expected Obj, but got Unknown
		//IL_0788: Expected Obj, but got I
		//IL_0798: Expected Obj, but got I
		//IL_07b4: Expected Obj, but got I
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06de: Expected Obj, but got Unknown
		//IL_06f8: Expected VT, but got I
		//IL_0692: Expected VT, but got I4
		//IL_06bd: Expected VT, but got I4
		//IL_01c1: Expected Obj, but got I
		//IL_0409: Expected Obj, but got I
		//IL_0152: Expected VT, but got Obj
		//IL_05d2: Expected VT, but got Obj
		//IL_02c3: Expected Obj, but got I
		//IL_04ec: Expected VT, but got Obj
		//IL_050a: Expected Obj, but got I
		//IL_05f8: Expected VT, but got Obj
		//IL_057d: Expected VT, but got Obj
		//IL_059d: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 - 32;
		object obj3 = obj + 28;
		obj = obj3;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12+20]");
		object obj5 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13+14]");
		object obj6 = (nint)0 + (nint)1;
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
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj7 = default;
							if (obj7 == null)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1E");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									fsResult fsResult2 = (fsResult)obj;
									goto IL_07f2;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
								object obj8 = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									object obj9 = default;
									if (obj9 != null)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												object obj10 = default;
												ref fsData reference = ref *(fsData*)obj10;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
												object obj11 = 0;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
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
																fsResult fsResult2 = fsResult.Success;
																goto IL_07f2;
															}
														}
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
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
										object obj12 = 0;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1E");
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
													bool flag = (nint)0 == 0;
													fsResult fsResult2 = (fsResult)obj;
													if (flag)
													{
														goto IL_07f2;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
													object obj13 = 0;
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														bool flag2 = (nint)0 != 1;
														fsResult2 = (fsResult)obj;
														if (flag2)
														{
															goto IL_07f2;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														fsResult2 = (fsResult)obj;
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														fsResult2 = (fsResult)obj;
													}
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
													fsResult fsResult2 = (fsResult)obj;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj14 = default;
		object obj15 = default;
		bool flag3 = obj14 == obj15;
		bool flag4 = !flag3;
		object obj17 = default;
		object obj16 = obj17;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag5 = (nint)0 != 1;
			fsResult fsResult2 = (fsResult)0;
			if (flag5)
			{
				goto IL_07f2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			fsResult2 = (fsResult)0;
			object obj18 = default;
			obj16 = obj18;
		}
		_ = 0;
		object obj19 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		fsResult fsResult3 = (fsResult)0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_07f2;
		IL_07f2:
		throw new IndexOutOfRangeException();
	}

	private unsafe fsResult InternalSerialize_2_Inheritance(Type storageType, Type overrideConverterType, object instance, out fsData data)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_013a: Expected I4, but got Obj
		//IL_0135: Expected native int or pointer, but got VT
		//IL_0058: Expected I, but got Obj
		//IL_00de: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		fsResult fsResult2 = InternalSerialize_3_ProcessVersioning(overrideConverterType, instance, out data);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
			object obj3 = default;
			if (storageType != obj3)
			{
				fsBaseConverter converter = GetConverter(storageType, overrideConverterType);
				nint num = (nint)converter;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v89 @ S2_v5 (Il2CppClass<FullSerializer.fsBaseConverter>)+EC] (should have been resolved before IL gen)");
				object obj4 = default;
				if (obj4 != null)
				{
					EnsureDictionary(data);
					Dictionary<string, fsData> asDictionary = data.AsDictionary;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
					object obj6 = default;
					object obj5 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v112 @ S1_v15+18C] (should have been resolved before IL gen)");
					nint num2 = 0;
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S5_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+5C]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v130 @ S5_v6+4] (should have been resolved before IL gen)");
				}
			}
		}
		fsResult fsResult3 = default;
		((fsResult*)(nint)fsResult3)->_success = (byte)(int)obj != 0;
		return fsResult3;
	}

	private unsafe fsResult InternalSerialize_3_ProcessVersioning(Type overrideConverterType, object instance, out fsData data)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0145: Expected native int or pointer, but got VT
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_015f: Expected native int or pointer, but got VT
		//IL_0110: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
		Type type = default;
		fsOption<fsVersionedType> versionedType = fsVersionManager.GetVersionedType(type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		fsResult fsResult3 = default;
		if ((nint)0 != 0)
		{
			object obj3 = obj + 16;
			object obj4 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @297E");
			fsResult fsResult2 = InternalSerialize_4_Converter(overrideConverterType, instance, out data);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			if ((nint)0 != 0)
			{
				EnsureDictionary(data);
				Dictionary<string, fsData> asDictionary = data.AsDictionary;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
				_ = 0;
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S5_v7 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+5C]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v158 @ S5_v8+4] (should have been resolved before IL gen)");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			((fsResult*)(nint)fsResult3)->_success = false;
		}
		else
		{
			fsResult fsResult4 = InternalSerialize_4_Converter(overrideConverterType, instance, out data);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			((fsResult*)(nint)fsResult3)->_success = false;
		}
		return fsResult3;
	}

	private unsafe fsResult InternalSerialize_4_Converter(Type overrideConverterType, object instance, out fsData data)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0045: Expected I, but got Obj
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_006d: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
		Type type = default;
		fsBaseConverter converter = GetConverter(type, overrideConverterType);
		nint num = (nint)converter;
		object obj4 = converter + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ S5_v2 (Il2CppClass<FullSerializer.fsBaseConverter>)+F4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		fsResult fsResult2 = default;
		((fsResult*)(nint)fsResult2)->_success = false;
		return fsResult2;
	}

	public unsafe fsResult TryDeserialize(fsData data, Type storageType, ref object result)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0035: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		fsResult fsResult2 = TryDeserialize(data, storageType, null, ref result);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		fsResult fsResult3 = default;
		((fsResult*)(nint)fsResult3)->_success = false;
		return fsResult3;
	}

	public unsafe fsResult TryDeserialize(fsData data, Type storageType, Type overrideConverterType, ref object result)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Ref, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_00c8: Expected Obj, but got I
		//IL_00d8: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got I
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Ref, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_0076: Expected I4, but got VT
		//IL_0071: Expected native int or pointer, but got VT
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected Obj, but got Unknown
		//IL_040c: Expected VT, but got I
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected Obj, but got Unknown
		//IL_01db: Expected I4, but got Obj
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_036c: Expected native int or pointer, but got VT
		//IL_026a: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		fsResult fsResult2 = default;
		if (data._value == null)
		{
			ref object reference = ref *(object*)null;
			List<fsObjectProcessor> processors = GetProcessors(storageType);
			Invoke_OnBeforeDeserialize(processors, storageType, ref *(fsData*)(obj + 24));
			Invoke_OnAfterDeserialize(processors, storageType, null);
			((fsResult*)(nint)fsResult2)->_success = (byte)(int)fsResult.Success != 0;
			goto IL_043f;
		}
		ConvertLegacyData(ref *(fsData*)(obj + 24));
		object obj3 = obj + 28;
		obj = obj3;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v24+20]");
		object obj5 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v25+14]");
		object obj6 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool success;
		if ((nint)0 != 1)
		{
			_ = 0;
			object obj7 = obj + 20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23");
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
					object obj8 = obj & 0xFF;
					bool flag = obj8 == null;
					success = (byte)(int)obj != 0;
					if (flag)
					{
						goto IL_034c;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag2 = (nint)0 != 1;
						success = (byte)(int)obj != 0;
						if (flag2)
						{
							goto IL_034c;
						}
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj9 = default;
		object obj10 = default;
		bool flag3 = obj9 != obj10;
		object obj12 = default;
		object obj11 = obj12;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 == 1;
			success = false;
			if (!flag4)
			{
				goto IL_034c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			object obj13 = default;
			obj11 = obj13;
		}
		_ = 0;
		object obj14 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		return (fsResult)0;
		IL_043f:
		return fsResult2;
		IL_034c:
		object obj15 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @94F7");
		((fsResult*)(nint)fsResult2)->_success = success;
		goto IL_043f;
	}

	private unsafe fsResult InternalDeserialize_1_CycleReference(Type overrideConverterType, fsData data, Type storageType, ref object result, out List<fsObjectProcessor> processors)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00dc: Expected native int or pointer, but got VT
		//IL_00a9: Expected I4, but got VT
		//IL_00a4: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		fsResult fsResult2 = default;
		if (IsObjectReference(data))
		{
			Dictionary<string, fsData> asDictionary = data.AsDictionary;
			fsData fsData2 = asDictionary.get_Item(Key_ObjectReference);
			string asString = fsData2.AsString;
			int id = int.Parse(asString);
			object referenceObject = _references.GetReferenceObject(id);
			ref object reference = ref *(object*)referenceObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
			Type type = default;
			List<fsObjectProcessor> processors2 = GetProcessors(type);
			ref List<fsObjectProcessor> reference2 = ref *(List<fsObjectProcessor>*)processors2;
			((fsResult*)(nint)fsResult2)->_success = (byte)(int)fsResult.Success != 0;
		}
		else
		{
			fsResult fsResult3 = InternalDeserialize_2_Version(overrideConverterType, data, storageType, ref result, out processors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			((fsResult*)(nint)fsResult2)->_success = false;
		}
		return fsResult2;
	}

	private unsafe fsResult InternalDeserialize_2_Version(Type overrideConverterType, fsData data, Type storageType, ref object result, out List<fsObjectProcessor> processors)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0499: Expected native int or pointer, but got VT
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00d5: Expected Obj, but got I
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected VT, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Ref, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected VT, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected VT, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected Obj, but got Unknown
		//IL_0279: Expected Obj, but got I
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected VT, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected VT, but got Unknown
		//IL_0235: Expected native int or pointer, but got VT
		//IL_0502: Expected native int or pointer, but got VT
		//IL_0316: Expected Obj, but got I4
		//IL_051c: Expected Obj, but got I
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected Obj, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected VT, but got Unknown
		//IL_0369: Expected Ref, but got VT
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected Obj, but got Unknown
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 160;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		fsResult fsResult5 = default;
		if (IsVersioned(data))
		{
			Dictionary<string, fsData> asDictionary = data.AsDictionary;
			fsData fsData2 = asDictionary.get_Item(Key_Version);
			string asString = fsData2.AsString;
			fsOption<fsVersionedType> versionedType = fsVersionManager.GetVersionedType(storageType);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
			if ((nint)0 != 0)
			{
				object obj3 = obj + 104;
				object obj4 = obj + 144;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @297E");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+6C]");
				if ((string)0 != asString)
				{
					object obj5 = obj + 88;
					object obj6 = obj + 144;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @297E");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
					_ = 0;
					fsVersionedType targetVersion = (fsVersionedType)(obj + 40);
					fsResult versionImportPath = fsVersionManager.GetVersionImportPath(asString, targetVersion, out *(List<fsVersionedType>*)(obj + 132));
					_ = fsResult.Success;
					_ = fsResult.Success;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
					_ = 0;
					fsResult fsResult2 = (fsResult)(obj + 32);
					fsResult fsResult3 = (fsResult)(obj + 24);
					fsResult fsResult4 = fsResult2 + fsResult3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
					if ((nint)0 == 0)
					{
						List<fsObjectProcessor> processors2 = GetProcessors(storageType);
						ref List<fsObjectProcessor> reference = ref *(List<fsObjectProcessor>*)processors2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
						((fsResult*)(nint)fsResult5)->_success = false;
					}
					else
					{
						object obj7 = obj + 104;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4AF");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
						fsResult fsResult6 = InternalDeserialize_3_Inheritance(overrideConverterType, data, (Type)0, ref result, out processors);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
						_ = 0;
						fsResult fsResult7 = (fsResult)(obj + 16);
						fsResult fsResult8 = (fsResult)(obj + 8);
						fsResult fsResult9 = fsResult7 + fsResult8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
						if ((nint)0 != 0)
						{
							object obj8 = 1;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+84]");
								object obj9 = 0;
								object obj10 = obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ S1_v73+C]");
								if ((nint)obj10 >= 0)
								{
									break;
								}
								object obj11 = obj + 104;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4AF");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
								_ = 0;
								fsVersionedType fsVersionedType2 = (fsVersionedType)(obj + 120);
								object obj12 = ((fsVersionedType*)fsVersionedType2)->Migrate(result);
								ref object reference2 = ref *(object*)obj12;
								object obj13 = obj8 + 1;
								obj8 = obj13;
							}
							if (IsObjectDefinition(data))
							{
								Dictionary<string, fsData> asDictionary2 = data.AsDictionary;
								fsData fsData3 = asDictionary2.get_Item(Key_ObjectDefinition);
								string asString2 = fsData3.AsString;
								int id = int.Parse(asString2);
								_references.AddReferenceWithId(id, result);
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
							_ = 0;
							object obj14 = obj + 104;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
							Type type = default;
							List<fsObjectProcessor> processors3 = GetProcessors(type);
							ref List<fsObjectProcessor> reference = ref *(List<fsObjectProcessor>*)processors3;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
						((fsResult*)(nint)fsResult5)->_success = false;
					}
					goto IL_04ed;
				}
			}
		}
		fsResult fsResult10 = InternalDeserialize_3_Inheritance(overrideConverterType, data, storageType, ref result, out processors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
		((fsResult*)(nint)fsResult5)->_success = false;
		goto IL_04ed;
		IL_04ed:
		return fsResult5;
	}

	private unsafe fsResult InternalDeserialize_3_Inheritance(Type overrideConverterType, fsData data, Type storageType, ref object result, out List<fsObjectProcessor> processors)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected Ref, but got Unknown
		//IL_0441: Expected Obj, but got I
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected Ref, but got Unknown
		//IL_02c0: Expected native int or pointer, but got VT
		//IL_0356: Expected Obj, but got I
		//IL_0362: Expected I, but got Obj
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Expected Ref, but got Unknown
		//IL_0536: Expected Obj, but got I
		//IL_0536: Expected Obj, but got I
		//IL_03b1: Expected native int or pointer, but got VT
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected VT, but got Unknown
		//IL_03ea: Expected native int or pointer, but got VT
		//IL_01b6: Expected I, but got Obj
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected Obj, but got Unknown
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected VT, but got Unknown
		//IL_0489: Expected Ref, but got VT
		//IL_00b0: Expected I, but got Obj
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected VT, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected VT, but got Unknown
		//IL_021b: Expected I, but got Obj
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected VT, but got Unknown
		//IL_04e1: Expected Ref, but got VT
		//IL_024a: Expected I, but got Obj
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected Obj, but got Unknown
		object obj = default;
		fsResult fsResult2 = (fsResult)(obj - 96);
		_ = 0;
		_ = fsResult.Success;
		if (IsTypeSpecified(data))
		{
			Dictionary<string, fsData> asDictionary = data.AsDictionary;
			fsData fsData2 = asDictionary.get_Item(Key_InstanceType);
			if (!fsData2.IsString)
			{
				string text = default;
				if ((object)data != null)
				{
					nint num = (nint)data;
					object obj2 = data + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v199 @ S3_v34 (Il2CppClass<FullSerializer.fsData>)+D4] (should have been resolved before IL gen)");
				}
				else
				{
					text = null;
				}
				string message = Key_InstanceType + " value must be a string (in " + text + ")";
				fsResult fsResult3 = fsResult2 + 80;
				((fsResult*)fsResult3)->AddMessage(message);
			}
			else
			{
				string asString = fsData2.AsString;
				Type type = fsTypeCache.GetType(asString);
				if ((object)type == null)
				{
					string warning = "Unable to locate specified type \"" + asString + "\"";
					fsResult fsResult4 = fsResult.Fail(warning);
					_ = fsResult.Success;
					_ = fsResult.Success;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+30]");
					_ = 0;
					fsResult fsResult5 = fsResult2 + 24;
					fsResult fsResult6 = fsResult2 + 16;
					fsResult fsResult7 = fsResult5 + fsResult6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+40]");
					_ = 0;
				}
				else
				{
					nint num2 = (nint)storageType;
					object obj3 = storageType + 176;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v285 @ S2_v21 (Il2CppClass<System.Type>)+16C] (should have been resolved before IL gen)");
					object obj4 = default;
					if (obj4 == null)
					{
						string text2 = default;
						if ((object)storageType != null)
						{
							nint num3 = (nint)storageType;
							object obj5 = storageType + 24;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v323 @ S2_v29 (Il2CppClass<System.Type>)+D4] (should have been resolved before IL gen)");
						}
						else
						{
							text2 = null;
						}
						string text3 = default;
						if ((object)type != null)
						{
							nint num4 = (nint)type;
							object obj6 = type + 24;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v371 @ S4_v16 (Il2CppClass<System.Type>)+D4] (should have been resolved before IL gen)");
						}
						else
						{
							text3 = null;
						}
						string message2 = "Ignoring type specifier; a field/property of type " + text2 + " cannot hold an instance of " + text3;
						fsResult fsResult8 = fsResult2 + 80;
						((fsResult*)fsResult8)->AddMessage(message2);
					}
				}
			}
		}
		RemapAbstractStorageTypeToDefaultType(ref *(Type*)(fsResult2 + 76));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+4C]");
		List<fsObjectProcessor> processors2 = GetProcessors((Type)0);
		ref List<fsObjectProcessor> reference = ref *(List<fsObjectProcessor>*)processors2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+50]");
		fsResult fsResult9 = default;
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+50]");
			((fsResult*)(nint)fsResult9)->_success = false;
			goto IL_04e6;
		}
		Invoke_OnBeforeDeserialize(processors, storageType, ref *(fsData*)(fsResult2 + 92));
		if (result != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+4C]");
			object obj7 = default;
			if (obj7 == null)
			{
				goto IL_04eb;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+4C]");
		fsBaseConverter converter = GetConverter((Type)0, overrideConverterType);
		nint num5 = (nint)converter;
		object obj8 = converter + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v247 @ S4_v10 (Il2CppClass<FullSerializer.fsBaseConverter>)+DC] (should have been resolved before IL gen)");
		object obj9 = default;
		ref object reference2 = ref *(object*)obj9;
		goto IL_04eb;
		IL_04eb:
		Invoke_OnBeforeDeserializeAfterInstanceCreation(processors, storageType, result, ref *(fsData*)(fsResult2 + 92));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+5C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+4C]");
		fsResult fsResult10 = InternalDeserialize_4_Cycles(overrideConverterType, (fsData)num6, (Type)0, ref result);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+20]");
		((fsResult*)(nint)fsResult2)->_success = false;
		fsResult fsResult11 = fsResult2 + 8;
		fsResult fsResult12 = fsResult11 + fsResult2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+40]");
		((fsResult*)(nint)fsResult9)->_success = false;
		goto IL_04e6;
		IL_04e6:
		return fsResult9;
	}

	private unsafe fsResult InternalDeserialize_4_Cycles(Type overrideConverterType, fsData data, Type resultType, ref object result)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0099: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		if (IsObjectDefinition(data))
		{
			Dictionary<string, fsData> asDictionary = data.AsDictionary;
			fsData fsData2 = asDictionary.get_Item(Key_ObjectDefinition);
			string asString = fsData2.AsString;
			int id = int.Parse(asString);
			_references.AddReferenceWithId(id, result);
		}
		fsResult fsResult2 = InternalDeserialize_5_Converter(overrideConverterType, data, resultType, ref result);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		fsResult fsResult3 = default;
		((fsResult*)(nint)fsResult3)->_success = false;
		return fsResult3;
	}

	private unsafe fsResult InternalDeserialize_5_Converter(Type overrideConverterType, fsData data, Type resultType, ref object result)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_00aa: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		fsData fsData2 = default;
		if (IsWrappedData(fsData2))
		{
			Dictionary<string, fsData> asDictionary = fsData2.AsDictionary;
			fsData fsData3 = asDictionary.get_Item(Key_Content);
		}
		fsBaseConverter converter = GetConverter(resultType, overrideConverterType);
		object obj4 = converter - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v58 @ S5_v5+BC] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		fsResult fsResult2 = default;
		((fsResult*)(nint)fsResult2)->_success = false;
		return fsResult2;
	}
}

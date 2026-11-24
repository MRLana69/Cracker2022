using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.Json.Internal;
using SYBO.Components.Utilities;
using UnityEngine;

namespace SYBO.Components.Json;

public class JsonContext
{
	public class SubtreeFileReference
	{
		public string Filename;

		public object SubObject;

		public JsonFieldInfo Field;

		public SubtreeFileReference()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private class SerializeByKeyReferenceData
	{
		public JsonFieldInfo field;

		public object json;

		public SerializeByKeyReferenceData next;
	}

	private class DeserializeByKeyReferenceData
	{
		public object obj;

		public JsonFieldInfo field;

		public object json;

		public DeserializeByKeyReferenceData next;
	}

	private class SerializationCallback
	{
		public ISerializationCallbackReceiver serializedInterface;

		public SerializationCallback next;
	}

	public const int MaximumNestingDepth = 100;

	public JsonObjectStore ObjectStore;

	public JsonCustomSerializerCollection CustomSerializers;

	public bool TolerateBlindReferencesOnSerialize;

	public bool RemoveWhitespace;

	public bool IncludeStatics;

	public Predicate<JsonFieldInfo> ShouldFilterField;

	public List<SubtreeFileReference> JsonFileReferences;

	private int nestedDeserializeCounter;

	private int nestedSerializeCounter;

	private DeserializeByKeyReferenceData _referenceDataToBeResolved;

	private SerializeByKeyReferenceData _referenceDataToBeValidated;

	private SerializationCallback _lastSerializationCallback;

	private SerializationCallback _firstSerializationCallback;

	public object Serialize<T>(T data)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x1FFF;
		object obj4 = obj3 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v14 @ S3_v4 (should have been resolved before IL gen)");
		object result = default;
		return result;
	}

	public T Deserialize<T>(object json)
	{
		//IL_0016: Expected Obj, but got I
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		EndSerialize();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x1FFF;
		object obj4 = obj3 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v16 @ S3_v4 (should have been resolved before IL gen)");
		ResolveKnownReferences();
		T result = default;
		return result;
	}

	public void BeginDeserialize()
	{
	}

	public void EndDeserialize()
	{
		//IL_007e: Expected Obj, but got I4
		if (nestedSerializeCounter != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			SerializedAsAttribute serializedAsAttribute = default;
			serializedAsAttribute._002Ector("Call to BeginDeserialize() while already doing a Serialization Batch Job.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		int num = nestedDeserializeCounter + 1;
		nestedDeserializeCounter = num;
		if (nestedDeserializeCounter > 100)
		{
			object obj = 100;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text = default;
			string serializeAsName = "Nesting depth must be less than " + text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			SerializedAsAttribute serializedAsAttribute2 = default;
			serializedAsAttribute2._002Ector(serializeAsName);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public void BeginSerialize()
	{
		if (nestedDeserializeCounter == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			SerializedAsAttribute serializedAsAttribute = default;
			serializedAsAttribute._002Ector("Call to EndDeserialize() but not doing a Deserialization Batch Job.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		int num = nestedDeserializeCounter - 1;
		nestedDeserializeCounter = num;
		if (nestedDeserializeCounter == 0)
		{
			InvokeSerializationEvents();
			ValidateReferences();
		}
	}

	public void EndSerialize()
	{
		//IL_007e: Expected Obj, but got I4
		if (nestedDeserializeCounter != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			SerializedAsAttribute serializedAsAttribute = default;
			serializedAsAttribute._002Ector("Call to BeginSerialize() while already doing a Deserialization Batch Job.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		int num = nestedSerializeCounter + 1;
		nestedSerializeCounter = num;
		if (nestedSerializeCounter > 100)
		{
			object obj = 100;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text = default;
			string serializeAsName = "Nesting depth must be less than " + text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			SerializedAsAttribute serializedAsAttribute2 = default;
			serializedAsAttribute2._002Ector(serializeAsName);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public void RegisterSerializeByKeyReference(JsonFieldInfo field, object json)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = field;
		CustomSerializers = (JsonCustomSerializerCollection)json;
	}

	public void RegisterDeserializeByKeyReference(object obj, JsonFieldInfo field, object json)
	{
		//IL_0014: Expected I4, but got Obj
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		JsonFileReferences = (List<SubtreeFileReference>)obj;
		nestedDeserializeCounter = (int)obj;
		JsonObjectStore objectStore = (JsonObjectStore)(field & 1);
		ObjectStore = objectStore;
		object obj2 = field & 1;
		object obj3 = this + 12;
		obj3 = json;
		object obj4 = this + 16;
		obj4 = json;
	}

	public void RegisterSerializationCallBack(ISerializationCallbackReceiver serializedInterface)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0029: Expected Obj, but got I4
		//IL_0035: Expected Obj, but got I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_004b: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		object obj = this + 8;
		obj = serializedInterface;
		object obj2 = this + 12;
		bool flag = ((JsonCustomSerializerCollection)this).HasSerializer((Type)52);
		obj2 = flag;
		object obj3 = this + 16;
		bool flag2 = ((JsonCustomSerializerCollection)this).HasSerializer((Type)56);
		obj3 = flag2;
	}

	public unsafe JsonContext Duplicate()
	{
		//IL_0174: Expected I, but got Obj
		//IL_018a: Expected Obj, but got I
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected Obj, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected I, but got Unknown
		//IL_01de: Expected I, but got Obj
		//IL_0076: Expected I, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0230: Expected I, but got Obj
		//IL_0063: Expected Obj, but got I4
		//IL_00b7: Expected I, but got Obj
		//IL_0122: Expected Obj, but got I4
		//IL_0134: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13 (Il2CppClass<System.Type>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v48 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 4;
		obj2 = typeof(IList<>);
		nint num3 = (nint)(obj3 + 8);
		((IntPtr*)num3)->m_value = (void*)(nint)obj2;
		Type directoryPath = Type.internal_from_handle((IntPtr)num3);
		AssetLoaderPathAttribute assetLoaderPathAttribute = default;
		bool flag = assetLoaderPathAttribute.ValidateDirectoryPath((string)(object)directoryPath);
		bool flag2;
		object obj4;
		if (flag)
		{
			flag2 = flag;
			obj4 = 0;
		}
		else
		{
			nint num4 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v33 (Il2CppClass<System.Type>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num5 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v43 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj3 = typeof(IDictionary<, >);
			((IntPtr*)num3)->m_value = (void*)(nint)obj3;
			Type directoryPath2 = Type.internal_from_handle((IntPtr)num3);
			bool flag3 = assetLoaderPathAttribute.ValidateDirectoryPath((string)(object)directoryPath2);
			if (!flag3)
			{
				return (JsonContext)(object)assetLoaderPathAttribute;
			}
			flag2 = flag3;
			obj4 = 1;
		}
		bool flag4 = ReflectionWrapper.IsPrimitive((Type)flag2);
		object obj6 = (flag4 ? 1 : 0) + 16;
		object obj7 = obj4 << 2;
		return (JsonContext)(object)(obj6 + obj7);
	}

	public Dictionary<Type, HashSet<string>> CollectUnknownReferences()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0032: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		JsonCustomSerializer jsonCustomSerializer = default;
		jsonCustomSerializer._002Ector();
		object obj = jsonCustomSerializer + 12;
		string text = ((JsonDict)(object)CustomSerializers).Serialize();
		obj = text;
		object obj2 = jsonCustomSerializer + 8;
		bool flag = ((FileStringStorage)(object)ObjectStore).SYBO_002EComponents_002EJson_002EIStringStorage_002ECanRead;
		obj2 = flag;
		bool tolerateBlindReferencesOnSerialize = TolerateBlindReferencesOnSerialize;
		return (Dictionary<Type, HashSet<string>>)(object)jsonCustomSerializer;
	}

	public void ResolveKnownReferences()
	{
		if (nestedSerializeCounter == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			SerializedAsAttribute serializedAsAttribute = default;
			serializedAsAttribute._002Ector("Call to EndSerialize() but not doing a Serialization Batch Job.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		int num = nestedSerializeCounter - 1;
		nestedSerializeCounter = num;
		if (nestedSerializeCounter == 0)
		{
			this._002Ector();
		}
	}

	private void ResolveReferences()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		DeserializeByKeyReferenceData deserializeByKeyReferenceData = null;
		while (_referenceDataToBeResolved != null)
		{
			DeserializeByKeyReferenceData referenceDataToBeResolved = _referenceDataToBeResolved;
			JsonFieldInfo field = referenceDataToBeResolved.field;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			DeserializeByKeyReferenceData referenceDataToBeResolved2 = _referenceDataToBeResolved;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			DeserializeByKeyReferenceData referenceDataToBeResolved3 = _referenceDataToBeResolved;
			JsonFieldInfo field2 = referenceDataToBeResolved3.field;
			DeserializeByKeyReferenceData referenceDataToBeResolved4 = _referenceDataToBeResolved;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			object obj3 = this + 36;
			DeserializeByKeyReferenceData referenceDataToBeResolved5 = _referenceDataToBeResolved;
			obj3 = referenceDataToBeResolved5.next;
		}
		object obj4 = this + 36;
		obj4 = deserializeByKeyReferenceData;
	}

	private void InvokeSerializationEvents()
	{
		//IL_00a2: Expected VT, but got Obj
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		Type objType = default;
		while (_referenceDataToBeResolved != null)
		{
			DeserializeByKeyReferenceData referenceDataToBeResolved = _referenceDataToBeResolved;
			JsonFieldInfo field = referenceDataToBeResolved.field;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			DeserializeByKeyReferenceData referenceDataToBeResolved2 = _referenceDataToBeResolved;
			object value = JsonReflectionParser.ReflectionDeserialize(objType, (JsonDict)referenceDataToBeResolved2.json, this);
			DeserializeByKeyReferenceData referenceDataToBeResolved3 = _referenceDataToBeResolved;
			JsonFieldInfo field2 = referenceDataToBeResolved3.field;
			DeserializeByKeyReferenceData referenceDataToBeResolved4 = _referenceDataToBeResolved;
			field2.Field.SetValueDirect((TypedReference)referenceDataToBeResolved4.obj, value);
			object obj = this + 36;
			DeserializeByKeyReferenceData referenceDataToBeResolved5 = _referenceDataToBeResolved;
			obj = referenceDataToBeResolved5.next;
		}
	}

	private void ValidateReferences()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Expected Obj, but got I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		while (_firstSerializationCallback != null)
		{
			SerializationCallback firstSerializationCallback = _firstSerializationCallback;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			object obj = this + 48;
			SerializationCallback firstSerializationCallback2 = _firstSerializationCallback;
			obj = firstSerializationCallback2.next;
		}
		object obj2 = this + 44;
		obj2 = 0;
	}

	public unsafe JsonContext()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0019: Expected Obj, but got I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		if (~(TolerateBlindReferencesOnSerialize ? 1u : 0u) == 0)
		{
			object obj = this + 40;
			obj = 0;
		}
		SerializeByKeyReferenceData referenceDataToBeValidated3;
		while (true)
		{
			if (_referenceDataToBeValidated != null)
			{
				SerializeByKeyReferenceData referenceDataToBeValidated = _referenceDataToBeValidated;
				JsonFieldInfo field = referenceDataToBeValidated.field;
				SerializeByKeyReferenceData referenceDataToBeValidated2 = _referenceDataToBeValidated;
				object obj2 = JsonParser.ParseValue((string)(object)ObjectStore, ref *(int*)field.ValueType, ref *(bool*)referenceDataToBeValidated2.json);
				referenceDataToBeValidated3 = _referenceDataToBeValidated;
				if (obj2 == null)
				{
					break;
				}
				object obj3 = this + 40;
				obj3 = referenceDataToBeValidated3.next;
				continue;
			}
			return;
		}
		JsonFieldInfo field2 = referenceDataToBeValidated3.field;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		SerializeByKeyReferenceData referenceDataToBeValidated4 = _referenceDataToBeValidated;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string format = default;
		object arg = default;
		string message = string.Format((IFormatProvider)(object)"Json references object {0} with key {1} which doesn't exist.", format, arg);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		JsonReflectionException ex = default;
		ex._002Ector(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}
}

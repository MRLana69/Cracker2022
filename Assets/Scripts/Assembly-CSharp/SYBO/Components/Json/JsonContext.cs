using System;
using System.Reflection;
using Cpp2ILInjected;
using SYBO.Components.Json.Internal;
using UnityEngine;

namespace SYBO.Components.Json;

public class JsonContext
{
	private class SerializeByKeyReferenceData
	{
		public object obj;

		public JsonFieldInfo field;

		public object json;

		public SerializeByKeyReferenceData next;
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

	private int nestedDeserializeCounter;

	private int nestedSerializeCounter;

	private SerializeByKeyReferenceData _referenceDataToBeResolved;

	private SerializationCallback _lastSerializationCallback;

	private SerializationCallback _firstSerializationCallback;

	public object Serialize<T>(T data)
	{
		BeginSerialize();
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<SYBO.Components.Json.JsonContext::Serialize>>)+4] (should have been resolved before IL gen)");
		EndSerialize();
		object result = default;
		return result;
	}

	public T Deserialize<T>(object json)
	{
		int num = nestedDeserializeCounter + 1;
		nestedDeserializeCounter = num;
		nint num2 = 0;
		nint num3 = 0;
		IntPtr intPtr = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v27 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<SYBO.Components.Json.JsonContext::Deserialize>>)+4] (should have been resolved before IL gen)");
		EndDeserialize();
		T result = default;
		return result;
	}

	public void BeginDeserialize()
	{
		int num = nestedDeserializeCounter + 1;
		nestedDeserializeCounter = num;
	}

	public void EndDeserialize()
	{
		if (--nestedDeserializeCounter == 0)
		{
			ResolveReferences();
			InvokeSerializationEvents();
		}
	}

	public unsafe void BeginSerialize()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (++nestedSerializeCounter >= 101)
		{
			_ = 100;
			int num = obj + 12;
			string text = ((int*)num)->ToString();
			string message = "Nesting depth must be less than " + text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			JsonSerializationException ex = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public void EndSerialize()
	{
		if (--nestedSerializeCounter == 0)
		{
			ValidateReferences();
		}
	}

	public void RegisterSerializeByKeyReference(object obj, JsonFieldInfo field, object json)
	{
		SerializeByKeyReferenceData serializeByKeyReferenceData = default;
		serializeByKeyReferenceData.obj = obj;
		serializeByKeyReferenceData.field = field;
		serializeByKeyReferenceData.json = json;
		serializeByKeyReferenceData.next = _referenceDataToBeResolved;
		_referenceDataToBeResolved = serializeByKeyReferenceData;
	}

	public void RegisterSerializationCallBack(ISerializationCallbackReceiver serializedInterface)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		SerializationCallback serializationCallback = default;
		serializationCallback.serializedInterface = serializedInterface;
		object obj;
		if (_firstSerializationCallback == null)
		{
			_firstSerializationCallback = serializationCallback;
			obj = this + 32;
		}
		else
		{
			SerializationCallback lastSerializationCallback = _lastSerializationCallback;
			lastSerializationCallback.next = serializationCallback;
			obj = this + 32;
		}
		obj = serializationCallback;
	}

	public JsonContext Duplicate()
	{
		JsonContext jsonContext = default;
		jsonContext._002Ector();
		JsonCustomSerializerCollection customSerializers = CustomSerializers.Duplicate();
		jsonContext.CustomSerializers = customSerializers;
		JsonObjectStore objectStore = ObjectStore.Duplicate();
		jsonContext.ObjectStore = objectStore;
		jsonContext.TolerateBlindReferencesOnSerialize = TolerateBlindReferencesOnSerialize;
		return jsonContext;
	}

	private void ResolveReferences()
	{
		//IL_0027: Expected I, but got Obj
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		Type type = default;
		while (true)
		{
			SerializeByKeyReferenceData referenceDataToBeResolved = _referenceDataToBeResolved;
			if (_referenceDataToBeResolved != null)
			{
				JsonFieldInfo field = referenceDataToBeResolved.field;
				FieldInfo field2 = field.Field;
				nint num = (nint)field2;
				object obj = field2 + 136;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S1_v3 (Il2CppClass<System.Reflection.FieldInfo>)+144] (should have been resolved before IL gen)");
				SerializeByKeyReferenceData referenceDataToBeResolved2 = _referenceDataToBeResolved;
				object value = JsonReflectionParser.ReadReference(type, referenceDataToBeResolved2.json, this);
				SerializeByKeyReferenceData referenceDataToBeResolved3 = _referenceDataToBeResolved;
				JsonFieldInfo field3 = referenceDataToBeResolved3.field;
				field3.Field.SetValue(referenceDataToBeResolved3.obj, value);
				SerializeByKeyReferenceData referenceDataToBeResolved4 = _referenceDataToBeResolved;
				_referenceDataToBeResolved = referenceDataToBeResolved4.next;
				continue;
			}
			break;
		}
	}

	private void InvokeSerializationEvents()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0027: Expected Obj, but got I
		object obj = this + 36;
		while (true)
		{
			object obj2 = obj;
			if (obj == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v8+C]");
			obj = 0;
		}
		_lastSerializationCallback = null;
	}

	private void ValidateReferences()
	{
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_0035: Expected Obj, but got I
		//IL_0058: Expected Obj, but got I
		//IL_0058: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I
		if (~(TolerateBlindReferencesOnSerialize ? 1u : 0u) == 0)
		{
			_referenceDataToBeResolved = null;
		}
		object obj = this + 28;
		while (true)
		{
			object obj2 = obj;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v8+C]");
				object obj3 = 0;
				JsonObjectStore objectStore = ObjectStore;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v6+C]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v8+10]");
				if (objectStore.HasObject((Type)num, 0))
				{
					object obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v37+14]");
					obj = 0;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				throw new ArrayTypeMismatchException();
			}
			break;
		}
	}

	public JsonContext()
	{
		JsonObjectStore jsonObjectStore = default;
		jsonObjectStore._002Ector();
		ObjectStore = jsonObjectStore;
		JsonCustomSerializerCollection jsonCustomSerializerCollection = default;
		jsonCustomSerializerCollection._002Ector();
		CustomSerializers = jsonCustomSerializerCollection;
	}
}

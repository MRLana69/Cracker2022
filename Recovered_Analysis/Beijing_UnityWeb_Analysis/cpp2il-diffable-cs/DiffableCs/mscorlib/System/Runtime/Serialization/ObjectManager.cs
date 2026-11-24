namespace System.Runtime.Serialization;

public class ObjectManager
{
	private DeserializationEventHandler m_onDeserializationHandler; //Field offset: 0x8
	private SerializationEventHandler m_onDeserializedHandler; //Field offset: 0xC
	internal ObjectHolder[] m_objects; //Field offset: 0x10
	internal object m_topObject; //Field offset: 0x14
	internal ObjectHolderList m_specialFixupObjects; //Field offset: 0x18
	internal long m_fixupCount; //Field offset: 0x20
	internal ISurrogateSelector m_selector; //Field offset: 0x28
	internal StreamingContext m_context; //Field offset: 0x2C

	internal ObjectHolderList SpecialFixupObjects
	{
		 get { } //Length: 6
	}

	internal object TopObject
	{
		 get { } //Length: 12
		 set { } //Length: 10
	}

	internal ObjectManager(ISurrogateSelector selector, StreamingContext context, bool checkSecurity, bool isCrossAppDomain) { }

	private void AddObjectHolder(ObjectHolder holder) { }

	internal virtual void AddOnDeserialization(DeserializationEventHandler handler) { }

	internal virtual void AddOnDeserialized(object obj) { }

	private bool CanCallGetType(object obj) { }

	internal void CompleteISerializableObject(object obj, SerializationInfo info, StreamingContext context) { }

	internal void CompleteObject(ObjectHolder holder, bool bObjectFullyComplete) { }

	public virtual void DoFixups() { }

	private void DoNewlyRegisteredObjectFixups(ObjectHolder holder) { }

	private bool DoValueTypeFixup(FieldInfo memberToFix, ObjectHolder holder, object value) { }

	internal ObjectHolder FindObjectHolder(long objectID) { }

	internal ObjectHolder FindOrCreateObjectHolder(long objectID) { }

	private void FixupSpecialObject(ObjectHolder holder) { }

	internal ObjectHolderList get_SpecialFixupObjects() { }

	internal object get_TopObject() { }

	private bool GetCompletionInfo(FixupHolder fixup, out ObjectHolder holder, out object member, bool bThrowIfMissing) { }

	internal static RuntimeConstructorInfo GetConstructor(RuntimeType t) { }

	public virtual object GetObject(long objectID) { }

	public virtual void RaiseDeserializationEvent() { }

	internal virtual void RaiseOnDeserializedEvent(object obj) { }

	public void RaiseOnDeserializingEvent(object obj) { }

	public virtual void RecordArrayElementFixup(long arrayToBeFixed, int[] indices, long objectRequired) { }

	public virtual void RecordDelayedFixup(long objectToBeFixed, string memberName, long objectRequired) { }

	public virtual void RecordFixup(long objectToBeFixed, MemberInfo member, long objectRequired) { }

	private void RegisterFixup(FixupHolder fixup, long objectToBeFixed, long objectRequired) { }

	public void RegisterObject(object obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member, int[] arrayIndex) { }

	internal void RegisterString(string obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member) { }

	private bool ResolveObjectReference(ObjectHolder holder) { }

	internal void set_TopObject(object value) { }

}


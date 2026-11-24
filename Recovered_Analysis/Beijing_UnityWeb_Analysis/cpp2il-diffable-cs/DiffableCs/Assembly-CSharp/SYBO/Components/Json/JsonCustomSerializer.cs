namespace SYBO.Components.Json;

public abstract class JsonCustomSerializer
{

	protected JsonCustomSerializer() { }

	public virtual object Deserialize(JsonDict json, JsonContext context) { }

	public virtual object DeserializeList(JsonList jsonList, JsonContext context) { }

	public virtual JsonDict Serialize(object obj, JsonContext context) { }

	public virtual JsonList SerializeList(object obj, JsonContext context) { }

}


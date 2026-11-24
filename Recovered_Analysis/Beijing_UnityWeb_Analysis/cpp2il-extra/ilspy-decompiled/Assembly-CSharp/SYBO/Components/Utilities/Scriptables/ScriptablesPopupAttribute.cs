using System;
using System.Collections.Generic;
using SYBO.Components.Utilities.IO;
using SYBO.Components.Utilities.Tickable;

namespace SYBO.Components.Utilities.Scriptables;

public class ScriptablesPopupAttribute : Attribute
{
	public Type Type;

	public string Namespace;

	public string PathContains;

	public bool HasNoneOption;

	public ScriptablesPopupAttribute(Type type)
	{
		//IL_0014: Expected Obj, but got I4
		string storageLocationDirectory = ((PersistentDataPathUtility)(object)this).GetStorageLocationDirectory((string)(object)type);
		bool flag = ((List<ITickable>)HasNoneOption).Remove((ITickable)type);
		throw new IndexOutOfRangeException();
	}
}

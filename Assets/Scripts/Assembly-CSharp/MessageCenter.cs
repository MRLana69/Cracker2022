using System;
using Cpp2ILInjected;
using UnityEngine;

public class MessageCenter : MonoBehaviour
{
	private static MessageCenter _instance;

	public static MessageCenter Instance
	{
		get
		{
			//IL_0014: Expected VT, but got Obj
			MessageCenter instance = default;
			while (_instance == null)
			{
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(MessageCenter));
				UnityEngine.Object obj = UnityEngine.Object.FindObjectOfType(typeFromHandle);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				_instance = instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				if (!(_instance == null))
				{
					break;
				}
			}
			return _instance;
		}
	}

	public static bool IsInstanced => _instance != null;

	private void Awake()
	{
		_instance = this;
	}
}

using System.Collections.Generic;
using UnityEngine;

public class DailyLetterPickup : LetterPickup
{
	public char Letter
	{
		set
		{
			//IL_004e: Expected Obj, but got I4
			_letterChar = value;
			if (_letterChar != '\0')
			{
				int num = _letterChar - 65;
				bool flag = num > -1;
				List<Mesh> letters = Letters;
				bool flag2 = num < letters._size;
				object obj = flag & flag2;
				if (obj != null)
				{
					Mesh sharedMesh = Letters.get_Item(num);
					((SkinnedMeshRenderer)(object)LetterMesh).sharedMesh = sharedMesh;
				}
			}
		}
	}

	private void Awake()
	{
		Awake();
	}

	protected override void OnActivate()
	{
		//IL_0013: Expected I4, but got Obj
		AndroidIncomingCallBridge androidIncomingCallBridge = AndroidIncomingCallBridge.CreatePlugin();
		((Glow)(object)androidIncomingCallBridge).IsDebugGlowEnabled = (byte)(int)this != 0;
	}

	public DailyLetterPickup()
	{
		AndroidIncomingCallBridge androidIncomingCallBridge = AndroidIncomingCallBridge.CreatePlugin();
		((DailyLetterPickupManager)(object)this).InitializePickup((DailyLetterPickup)(object)androidIncomingCallBridge.onPhoneStateChanged);
	}
}

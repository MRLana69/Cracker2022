using UnityEngine;

public class Layers
{
	public readonly int Default;

	public readonly int Hit;

	public readonly int Unremovable;

	public readonly int Character;

	public readonly int Guard;

	public readonly int Pickup;

	public readonly int Coin;

	public readonly int Background;

	public readonly int TutorialTrigger;

	public readonly int TrackEvent;

	public readonly int TrackEventTrigger;

	public readonly int SkateparkSetPiece;

	public readonly int Ramp;

	public readonly int LoadScreenLayer;

	public readonly int _3DGUI;

	public readonly int _3DCLIP;

	public readonly int CELEBRATION;

	public readonly int _2DGUI;

	public readonly int _2DOVERLAY;

	private static Layers _instance;

	public static Layers Instance
	{
		get
		{
			if (_instance == null)
			{
				Init();
			}
			return _instance;
		}
	}

	private Layers()
	{
		int num = FindLayer("Default");
		Default = num;
		int hit = FindLayer("Hit");
		Hit = hit;
		int unremovable = FindLayer("Unremovable");
		Unremovable = unremovable;
		int character = FindLayer("Character");
		Character = character;
		int guard = FindLayer("Guard");
		Guard = guard;
		int pickup = FindLayer("Pickup");
		Pickup = pickup;
		int coin = FindLayer("Coin");
		Coin = coin;
		int background = FindLayer("Background");
		Background = background;
		int tutorialTrigger = FindLayer("TutorialTrigger");
		TutorialTrigger = tutorialTrigger;
		int trackEvent = FindLayer("TrackEvent");
		TrackEvent = trackEvent;
		int trackEventTrigger = FindLayer("TrackEventTrigger");
		TrackEventTrigger = trackEventTrigger;
		int skateparkSetPiece = FindLayer("SkateparkSetPiece");
		SkateparkSetPiece = skateparkSetPiece;
		int ramp = FindLayer("Ramp");
		Ramp = ramp;
		int loadScreenLayer = FindLayer("LoadScreenLayer");
		LoadScreenLayer = loadScreenLayer;
		int num2 = FindLayer("3DGUI");
		_3DGUI = num2;
		int num3 = FindLayer("3DCLIP");
		_3DCLIP = num3;
		int cELEBRATION = FindLayer("CELEBRATION");
		CELEBRATION = cELEBRATION;
		int num4 = FindLayer("2DGUI");
		_2DGUI = num4;
		int num5 = FindLayer("2DOVERLAY");
		_2DOVERLAY = num5;
	}

	private static int FindLayer(string name)
	{
		int num = LayerMask.NameToLayer(name);
		if (num == -1)
		{
			string text = "Could not find layer '" + name + "'.";
		}
		return num;
	}

	public static void Init()
	{
		Layers layers = default;
		layers._002Ector();
		_instance = layers;
	}
}

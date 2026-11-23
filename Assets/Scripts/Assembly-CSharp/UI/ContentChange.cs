using Cpp2ILInjected;
using UnityEngine;

namespace UI;

public class ContentChange : MonoBehaviour
{
	private bool _foldedOut;

	public GameObject button;

	public GameObject openButton;

	public GameObject descriptionButton;

	private UILabel descriptionText;

	private GameObject _descriptionTextGameObject;

	private BoxCollider buyButtonCollider;

	private UISprite buyButtonSprite;

	private UILabel buyButtonLabel;

	private GameObject tweensContainer;

	private BoxCollider descButtonCollider;

	private UISprite descButtonSprite;

	private UILabel descButtonLabel;

	private GameObject expandedContent;

	private UISprite openButtonSprite;

	private TableElementAlwaysVisible tableElement;

	public PowerupType powerupType;

	private UIPlayTween[] _tweens;

	private UpgradeHelper _upgradeHelper;

	private bool _hasInited;

	private bool _wasForceOpened;

	private void Start()
	{
	}

	private void ForceExpandContent(bool expand)
	{
		//IL_004e: Expected Obj, but got I4
		//IL_0085: Expected Obj, but got I
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		_wasForceOpened = expand;
		GameObject gameObject = base.gameObject;
		Transform transform = gameObject.transform;
		Transform parent = transform.parent;
		TableElementAlwaysVisible component = parent.GetComponent<TableElementAlwaysVisible>();
		tableElement = component;
		UIPlayTween[] tweens = default;
		if (!(tableElement != null))
		{
			tweens = _tweens;
			if (_tweens == null)
			{
				return;
			}
		}
		object obj = 0;
		while ((nint)obj < tweens.Length)
		{
			object obj2 = obj << 2;
			object obj3 = (object)_tweens + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v23+10]");
			((UIPlayTween)0).Play(expand);
			object obj4 = obj + 1;
			obj = obj4;
		}
	}

	private void OnEnable()
	{
		if (~(_hasInited ? 1u : 0u) != 0)
		{
			return;
		}
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager(SSEventType.BiggerJackpot);
		if (powerupType == PowerupType.mysterybox && activeEventManager != null)
		{
			if (!_foldedOut)
			{
				ForceExpandContent(expand: true);
			}
		}
		else if (~(_wasForceOpened ? 1u : 0u) == 0)
		{
			ForceExpandContent(expand: false);
		}
		else
		{
			ContentActivation(_foldedOut);
		}
	}

	public void TriggerContent()
	{
		if (~(_foldedOut ? 1u : 0u) == 0)
		{
			ContentActivation(foldedOut: true);
		}
	}

	public void FoldClicked()
	{
		if (~(_foldedOut ? 1u : 0u) != 0)
		{
			_foldedOut = true;
			return;
		}
		_foldedOut = false;
		ContentActivation(foldedOut: false);
	}

	private unsafe void ContentActivation(bool foldedOut)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_006e: Expected native int or pointer, but got VT
		//IL_00a2: Expected F4, but got I
		//IL_009d: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		descriptionText.enabled = foldedOut;
		_descriptionTextGameObject.SetActive(foldedOut);
		if (buyButtonSprite != null)
		{
			Vector3 center = buyButtonCollider.center;
			Vector3 center2 = buyButtonCollider.center;
			_ = -1049624576;
			((Vector3*)(nint)vector)->z = -15f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			buyButtonCollider.center = vector;
			buyButtonCollider.enabled = foldedOut;
			buyButtonSprite.enabled = foldedOut;
			buyButtonLabel.enabled = foldedOut;
		}
		if (button != null)
		{
			NGUITools.SetActive(button, foldedOut);
		}
		expandedContent.SetActive(foldedOut);
		bool flag = (byte)((foldedOut ? 1u : 0u) ^ 1u) != 0;
		openButtonSprite.enabled = flag;
	}
}

using System.Text;
using UnityEngine;

namespace SYBO.Subway.UI;

public class RouteChunkDebugLabel : MonoBehaviour
{
	private UILabel _label;

	private UISprite _background;

	private StringBuilder sb;

	private int _originalWidth;

	private string _originalLabelText = string.Empty;

	private const string WAITING_FOR_CHUNKS = "Waiting for chunks...";
}

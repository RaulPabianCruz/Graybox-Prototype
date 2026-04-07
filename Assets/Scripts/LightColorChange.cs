using UnityEngine;

public class LightColorChange : MonoBehaviour
{

    public Light pointLight;

    public void ChangeToRed()
    {
        ColorUtility.TryParseHtmlString("#A43E37", out Color redColor);
        pointLight.color = redColor;
    }
}

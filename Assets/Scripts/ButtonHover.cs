using UnityEngine;
using UnityEngine.UI;

public class ButtonHover : MonoBehaviour
{
    public Button button;
    public Color wantedColor;
    Color originalColor;
    ColorBlock colorBlock;
    void Start()
    {
        colorBlock = button.colors;
        originalColor = colorBlock.selectedColor;
    }

    public void hoverOverButton()
    {
        colorBlock.selectedColor = wantedColor;
        button.colors = colorBlock;
    }
    public void Onclicked()
    {
        colorBlock.selectedColor = originalColor;
        button.colors = colorBlock;
    }
}

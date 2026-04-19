using UnityEngine;
using UnityEngine.UI;

public class CharacterResizer : MonoBehaviour
{
    public Transform characterTransform;
    public Slider widthSlider;
    public Slider heightSlider;

    public void UpdateSize()
    {
        characterTransform.localScale = new Vector2(widthSlider.value, heightSlider.value);
    }
}
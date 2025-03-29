using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Material[] colors;
    private int currentColorIndex = 0;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material = colors[currentColorIndex];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Tap to change color
        {
            ChangeColor();
        }
    }

    void ChangeColor()
    {
        currentColorIndex = (currentColorIndex + 1) % colors.Length;
        rend.material = colors[currentColorIndex];
    }
}

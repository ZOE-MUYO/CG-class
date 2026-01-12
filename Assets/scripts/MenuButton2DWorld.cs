using UnityEngine;
using TMPro;

public class MenuButton2DWorld : MonoBehaviour
{
    [Header("Renderers")]
    public SpriteRenderer[] shapes;   // 方块 / 圆
    public TMP_Text label;            // TextMeshPro

    [Header("Colors")]
    public Color normalShapeColor = Color.white;
    public Color normalTextColor = new Color(0.4f, 0f, 0.6f);
    public Color selectedShapeColor = new Color(0.6f, 0.3f, 0.8f);
    public Color selectedTextColor = Color.white;

    [Header("Neighbor Buttons")]
    public MenuButton2DWorld up;
    public MenuButton2DWorld down;
    public MenuButton2DWorld left;
    public MenuButton2DWorld right;

    [Header("Scene Name (按 Enter 跳转)")]
    public string sceneName;

    void Awake()
    {
        SetSelected(false);
    }

    public void SetSelected(bool selected)
    {
        if (shapes != null)
        {
            foreach (var r in shapes)
            {
                if (r != null)
                    r.color = selected ? selectedShapeColor : normalShapeColor;
            }
        }

        if (label != null)
        {
            label.color = selected ? selectedTextColor : normalTextColor;
        }
    }
}

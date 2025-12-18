using UnityEngine;
using TMPro;

public class MenuButton2DWorld : MonoBehaviour
{
    [Header("Renderers")]
    public SpriteRenderer[] shapes;   // 底部方块+圆
    public TMP_Text label;            // 文字

    [Header("Colors")]
    public Color normalShapeColor = Color.white;
    public Color normalTextColor = new Color(0.4f, 0f, 0.6f);
    public Color selectedShapeColor = new Color(0.6f, 0.3f, 0.8f);
    public Color selectedTextColor = Color.white;

    [Header("Scale")]
    public float normalScale = 1f;
    public float selectedScale = 1.15f;

    [Header("Neighbor Buttons")]
    public MenuButton2DWorld up;
    public MenuButton2DWorld down;
    public MenuButton2DWorld left;
    public MenuButton2DWorld right;

    // 去掉 TextEdgeWaveSmooth
    void Awake()
    {
        SetSelected(false);
    }

    public void SetSelected(bool selected)
    {
        foreach (var r in shapes)
            r.color = selected ? selectedShapeColor : normalShapeColor;

        label.color = selected ? selectedTextColor : normalTextColor;

        transform.localScale = Vector3.one * (selected ? selectedScale : normalScale);
    }
}

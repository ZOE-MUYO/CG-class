using UnityEngine;

public class ToggleTargetGroup2D : MonoBehaviour
{
    public GameObject targetGroup;

    private bool isVisible = false;

    void Start()
    {
        if (targetGroup != null)
            targetGroup.SetActive(false); // 初始隐藏
    }

    void OnMouseDown()
    {
        if (targetGroup == null) return;

        isVisible = !isVisible;
        targetGroup.SetActive(isVisible);
    }
}

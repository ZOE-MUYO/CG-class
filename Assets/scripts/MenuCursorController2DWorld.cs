using UnityEngine;

public class MenuCursorController2DWorld : MonoBehaviour
{
    public MenuButton2DWorld startButton; // 初始选中按钮
    private MenuButton2DWorld currentButton;

    void Start()
    {
        currentButton = startButton;
        UpdateSelection();
    }

    void Update()
    {
        MenuButton2DWorld nextButton = null;

        if (Input.GetKeyDown(KeyCode.UpArrow))
            nextButton = currentButton.up;
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            nextButton = currentButton.down;
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            nextButton = currentButton.left;
        else if (Input.GetKeyDown(KeyCode.RightArrow))
            nextButton = currentButton.right;

        if (nextButton != null)
        {
            currentButton.SetSelected(false);
            currentButton = nextButton;
            UpdateSelection();
        }
    }

    void UpdateSelection()
    {
        if (currentButton != null)
            currentButton.SetSelected(true);
    }
}

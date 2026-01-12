using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuCursorController2DWorld : MonoBehaviour
{
    public MenuButton2DWorld startButton; // 初始选中按钮
    private MenuButton2DWorld currentButton;

    [Header("按 Enter 延迟切换（秒）")]
    public float enterDelay = 0.2f;

    void Start()
    {
        currentButton = startButton;
        UpdateSelection();
    }

    void Update()
    {
        MenuButton2DWorld nextButton = null;

        // 光标移动
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

        // 按 Enter 跳转场景
        if (Input.GetKeyDown(KeyCode.Return) && currentButton != null)
        {
            if (!string.IsNullOrEmpty(currentButton.sceneName))
            {
                StartCoroutine(LoadSceneWithDelay(currentButton.sceneName));
            }
        }
    }

    void UpdateSelection()
    {
        if (currentButton != null)
            currentButton.SetSelected(true);
    }

    IEnumerator LoadSceneWithDelay(string sceneName)
    {
        // 可以在这里加选中音效或动画
        yield return new WaitForSeconds(enterDelay);
        SceneManager.LoadScene(sceneName);
    }
}

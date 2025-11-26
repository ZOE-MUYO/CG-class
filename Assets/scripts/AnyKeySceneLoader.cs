using UnityEngine;
using UnityEngine.SceneManagement;

public class AnyKeySceneLoader : MonoBehaviour
{
    [SerializeField] private string S2;

    private bool isLoading = false;

    void Update()
    {
        if (isLoading) return;

        // 检测键盘按下任意键
        if (Input.anyKeyDown)
        {
            foreach (KeyCode kcode in System.Enum.GetValues(typeof(KeyCode)))
            {
                // 如果按下的是鼠标按键，跳过
                if (kcode >= KeyCode.Mouse0 && kcode <= KeyCode.Mouse6) continue;

                // 如果按下的是键盘按键
                if (Input.GetKeyDown(kcode))
                {
                    isLoading = true;
                    SceneManager.LoadScene(S2);
                    break;
                }
            }
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene(0);
    }
    public void map()
    {

        SceneManager.LoadScene(1);
    }
    public void game()
    {

        SceneManager.LoadScene(2);
    }
    public void exit()
    {
        Application.Quit();
    }
    public void restart()
    {
        // โหลดฉากปัจจุบันใหม่เพื่อรีเซ็ตเกม
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

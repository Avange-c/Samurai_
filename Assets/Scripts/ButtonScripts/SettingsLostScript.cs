using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsLostScript : MonoBehaviour
{
    public void onClick()
    {
        SceneManager.LoadScene(0); // Временное решение, в будущем надо добавить экран настроек
    }
}

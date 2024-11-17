using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMenuScript : MonoBehaviour
{
    public void onClick()
    {
        SceneManager.LoadScene(0);
    }
}

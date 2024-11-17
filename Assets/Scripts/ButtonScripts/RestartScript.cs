using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    public void onClick()
    {
        SceneManager.LoadScene(1);
        moveGamePerson.Score = 0;
    }
}

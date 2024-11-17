using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    public void onClick()
    {
        SceneManager.LoadScene(1);
        moveGamePerson.Score = 0;
    }
}

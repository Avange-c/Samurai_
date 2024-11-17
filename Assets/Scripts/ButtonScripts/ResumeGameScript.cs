using UnityEngine;

public class ResumeGameScript : MonoBehaviour
{
    public void onClick()
    {
        Time.timeScale = 1f;
        PauseScript._pause = 0;
    }
}

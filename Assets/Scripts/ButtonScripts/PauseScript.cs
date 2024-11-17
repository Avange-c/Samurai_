using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public static int _pause = 0;    
    public void onClick()
    {
        Time.timeScale = 0f;
        _pause = 1;
    }
}
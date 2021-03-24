using UnityEngine;

public class DontDestroyOnLoadThisGO : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
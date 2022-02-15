using UnityEngine;
using UnityEngine.UI;

public class Core : MonoBehaviour
{
    public int score=0;
    public Text textScore;
    public static Core instance;
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il ya plus d'une instance de Score dans la scene");
            return;
        }
        instance = this;
    }
}

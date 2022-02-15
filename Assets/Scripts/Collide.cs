using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class Collide : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.tag == "Bomb" && collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("Menu");
        }
        else if(gameObject.tag == "Broken" && collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Core.instance.score -= 100;
            Core.instance.textScore.text = Core.instance.score.ToString();
        }
        else if(gameObject.tag == "Heart" && collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Core.instance.score += 10;
            Core.instance.textScore.text = Core.instance.score.ToString();
        }
    }

    

}

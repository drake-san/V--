using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Heart : MonoBehaviour
{
    public GameObject heart;
    public GameObject brokenHeart;
    public GameObject bomb;
    
    private int time = 120;
    
    public Text textTime;

    public GameObject panel;


    private void Start()
    {
        InvokeRepeating("TiateHeart", 1, Random.Range(1,7));
        InvokeRepeating("TiateBroken", 1, Random.Range(1, 5));
        InvokeRepeating("TiateBomb", 1, Random.Range(1, 2));
        
    }


    private void Update()
    {
        if (time == 0)
        {
            StartCoroutine(MyCoroutine());
        }
    }

    public void TiateHeart()
    {
        float randomPosition = Random.Range(-2.3f, 2.3f);
        Instantiate(heart,new Vector3(randomPosition,5.5f),Quaternion.identity);
        heart.GetComponent<Rigidbody2D>().velocity = new Vector3(0, Random.Range(-1.0f, -5.0f));
        
    }

    public void TiateBroken()
    {
        float randomPosition = Random.Range(-2.3f, 2.3f);
        Instantiate(brokenHeart, new Vector3(randomPosition, 5.5f), Quaternion.identity);
        
    }

    public void TiateBomb()
    {
        float randomPosition = Random.Range(-2.3f, 2.3f);
        Instantiate(bomb, new Vector3(randomPosition, 5.5f), Quaternion.identity);
        bomb.GetComponent<Rigidbody2D>().velocity = new Vector3(0, Random.Range(-1.0f, -5.0f));
        time--;
        textTime.text = time.ToString();
    }

    public IEnumerator MyCoroutine()
    {
        panel.SetActive(true);
        Destroy(GameObject.FindGameObjectWithTag("Player"));
        textTime.text = "0";
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene("Menu");
    }
}

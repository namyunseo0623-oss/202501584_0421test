using UnityEngine;
using UnityEngine.SceneManagement;
public class Goalin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public string nextSceneName = "shutdown";

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Ãæµ¹ °¨ÁöµÊ!");

        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}

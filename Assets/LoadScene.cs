using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*load to next scene with sceneName */
public class LoadScene : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(nextScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void nextScene()
    {
        SceneManager.LoadScene (sceneName);
    }
}

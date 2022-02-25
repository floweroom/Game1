using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Text PlayerName;
    public AudioSource _audio;
    public Panel _panel;
    int health=5;
    int Lives;
    public GameObject Health;
   
    // Start is called before the first frame update
    void Start()
    {
 
        PlayerName.text = PlayerPrefs.GetString("PlayerName");
        _panel.Refresh();
    }
    private void Awake()
    {
        _audio=GetComponent<AudioSource>();
        _panel = FindObjectOfType<Panel>();
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
    void SetDamage()
    {
        Lives--;
        _panel.Refresh();

    }
    void EndofGame()
    { 
    if (Lives< 0)
        {
            gameObject.SetActive(false);
            SceneManager.LoadScene(0);
        }
}

// Update is called once per frame
 void Update()
    {

    }
    

  
}


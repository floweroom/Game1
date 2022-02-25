using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel1 : MonoBehaviour
{
    public Transform[] Lives;
    public PlayerController _player;
    public Text PlayerName;




    // Start is called before the first frame update
    void Start()
    {
        _player = FindObjectOfType<PlayerController>();
        Lives = new Transform[transform.childCount];
        for (int i = 0; i < Lives.Length; i++)
        {
            Lives[i] = transform.GetChild(i);
        }
    }
    void Refresh()
    {
        for (int i = 0; i < Lives.Length; i++)
        {
            if (i < 5)
            {
                Lives[i].gameObject.SetActive(true);

            }
            else
            {
                Lives[i].gameObject.SetActive(false);
            }
        }

        


        // Update is called once per frame
        void Update()
        {

        }

    }
}

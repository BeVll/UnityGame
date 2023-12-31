using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    // Start is called before the first frame update
    static public int level = 1;
    // Start is called before the first frame update
    void Start()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = Level.level.ToString();


    }

    void Awake()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "Level " + Level.level;
        
    }
}

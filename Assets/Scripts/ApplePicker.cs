using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ApplePicker : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public int currentLevel = 1;
    public Text currentLevelText;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    public List<GameObject> basketList;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numBaskets; i++)
        {
            GameObject tBasket = Instantiate(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasket.transform.position = pos;
            basketList.Add(tBasket);
        }

        
    }

    public void AppleDestroyed()
    {
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach (GameObject tGO in tAppleArray)
        {
            Destroy(tGO);
        }
        int basketindex = basketList.Count - 1;
        GameObject tBasketGO = basketList[basketindex];
        basketList.RemoveAt(basketindex);
        Destroy(tBasketGO);

        if (basketList.Count == 0)
        {
            SceneManager.LoadScene("Menu");
        }
    }
}

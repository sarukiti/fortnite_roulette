using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RouletteGenerator : MonoBehaviour
{
        [SerializeField]
        GameObject canvas;

        [SerializeField]
        GameObject hogehoge;

        Image image;

        [SerializeField]
        int stageCount;

        float amountSize;

    // Start is called before the first frame update
    void Start()
    {
        amountSize = 1.0f / stageCount;
        int i = 1;
        float c = 0f;
        float rotateCount = 360.0f/stageCount;
        while (i<=stageCount)
        {
            GameObject prefab = (GameObject)Instantiate(hogehoge);
            prefab.transform.SetParent(canvas.transform, false);
            prefab.name = $"image{i}";
            image = GameObject.Find ($"image{i}").GetComponent<Image>();
            image.fillAmount = amountSize;
            image.transform.Rotate(0.0f, 0.0f, c);
            float R = Random.Range (0.0f, 255.0f);
            float B = Random.Range (0.0f, 255.0f);
            image.color = new Color(R/255.0f, 160.0f/255.0f, B/255.0f, 255.0f/255.0f);
            Transform tText = prefab.transform.Find("Text");
            Text text = tText.GetComponent<Text>();
            text.text = ($"{i}");
            c -= rotateCount;
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

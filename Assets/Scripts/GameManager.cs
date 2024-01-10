using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering;

public class GameManager : MonoBehaviour
{
    public string nameSaved;
    private TMP_InputField inputField;
    
    public static GameManager instance;
    public void Awake()
    {
        
        if(instance !=null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
    }

    public void Update()
    {
            if (GameObject.Find("InputField"))
            {
                inputField = GameObject.Find("InputField").GetComponent<TMP_InputField>();
                TMP_Text textMeshPro = inputField.textComponent;
                nameSaved = textMeshPro.text;
            }
            else
            { inputField = null; }
        

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomTag : MonoBehaviour
{
    public string tag;

    // Start is called before the first frame update
    void Start()
    {
        PlayercController.Instance.AddObserver(tag, gameObject);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background_move : MonoBehaviour
{
    // Start is called before the first frame update
    MeshRenderer meshrenderer;
    public float speed = 1f;
    private void Awake()
    {
        meshrenderer = GetComponent<MeshRenderer>(); 
    }
    // Update is called once per frame
    void Update()
    {
        meshrenderer.material.mainTextureOffset += new Vector2(Time.deltaTime * speed, 0);
    }
}

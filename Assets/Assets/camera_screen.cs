using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_screen : MonoBehaviour

{
    public SpriteRenderer Background1;
    // Start is called before the first frame update
    void Start()
    {
        float orthoSize = Background1.bounds.size.x * Screen.height / Screen.width * 0.5f;
        Camera.main.orthographicSize = orthoSize;
    }

  
}

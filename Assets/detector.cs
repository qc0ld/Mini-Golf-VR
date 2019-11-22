using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detector : MonoBehaviour
{
    int score = 0;
    public GameObject pref;
    public GameObject spawnPoint;
    public GameObject scoreText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        score++;
        Destroy(other.gameObject);
        GameObject buffer = Instantiate<GameObject>(pref);
        buffer.transform.position = spawnPoint.transform.position;
        scoreText.GetComponent<TextMesh>().text = score.ToString();
    }
}

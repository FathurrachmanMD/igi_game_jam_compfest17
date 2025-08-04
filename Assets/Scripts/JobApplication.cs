using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobApplication : MonoBehaviour
{

    [SerializeField]
    public GameObject Player;

    [SerializeField]
    public GameObject CameraMain;
    [SerializeField]
    public GameObject CameraSecond;

    [SerializeField]
    public GameObject JobPhoto;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Masuk");

        if (collision.gameObject == Player)
        {
            Debug.Log("Masuk controller");
            CameraMain.SetActive(false);
            CameraSecond.SetActive(true);
            JobPhoto.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsScript : MonoBehaviour
{

    [SerializeField]
    GameObject audioPrefab;

    [SerializeField]
    AudioClip bgMusic;

    // Start is called before the first frame update
    void Start()
    {
        GameObject soundPlayer = Instantiate(audioPrefab, transform.position, Quaternion.identity);
        SoundPlayerScript sp = soundPlayer.GetComponent<SoundPlayerScript>();
        sp.PlaySound(bgMusic, true, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

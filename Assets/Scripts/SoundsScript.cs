using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsScript : MonoBehaviour
{

    [SerializeField]
    GameObject audioPrefab;

    [SerializeField]
    AudioClip bgMusic;

    public AudioClip[] triggersounds;


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

    private void OnTriggerEnter(Collider other)
    {
        print("HIT " + other.tag);
        if(other.tag == "SoundTrigger")
        {
            print("HITTED  ");
            int ran = Random.Range(0, 6);
            GameObject soundPlayer = Instantiate(audioPrefab, transform.position, Quaternion.identity);
            SoundPlayerScript sp = soundPlayer.GetComponent<SoundPlayerScript>();
            sp.PlaySound(triggersounds[ran], false, 0.1f);
        }
    }
}

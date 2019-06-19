using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SoundsScript : MonoBehaviour
{

    [SerializeField]
    GameObject audioPrefab;

    [SerializeField]
    AudioClip bgMusic;

    [SerializeField]
    AudioClip endSound;

    public AudioClip[] triggersounds;

    public TextMeshProUGUI theEndText;


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
            Destroy(other.gameObject);
        } else if (other.tag == "Enemy")
        {
            GameObject soundPlayer = Instantiate(audioPrefab, transform.position, Quaternion.identity);
            SoundPlayerScript sp = soundPlayer.GetComponent<SoundPlayerScript>();
            sp.PlaySound(endSound, false, 0.1f);
            theEndText.enabled = true;
        }
    }
}

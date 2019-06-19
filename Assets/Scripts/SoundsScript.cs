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

    bool alive = true;


    // Start is called before the first frame update
    void Start()
    {
        GameObject soundPlayer = Instantiate(audioPrefab, transform.position, Quaternion.identity);
        SoundPlayerScript sp = soundPlayer.GetComponent<SoundPlayerScript>();
        sp.PlaySound(bgMusic, true, 0.5f);
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
            int ran = Random.Range(0, 5);
            GameObject soundPlayer = Instantiate(audioPrefab, transform.position, Quaternion.identity);
            SoundPlayerScript sp = soundPlayer.GetComponent<SoundPlayerScript>();
            sp.PlaySound(triggersounds[ran], false, 1f);
            Destroy(other.gameObject);
        } else if (other.tag == "Enemy" && alive)
        {
            GameObject soundPlayer = Instantiate(audioPrefab, transform.position, Quaternion.identity);
            SoundPlayerScript sp = soundPlayer.GetComponent<SoundPlayerScript>();
            sp.PlaySound(endSound, false, 1f);
            theEndText.enabled = true;
            Cursor.lockState = CursorLockMode.None;
            alive = false;
        }
    }
}

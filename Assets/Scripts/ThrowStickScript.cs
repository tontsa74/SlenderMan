using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ThrowStickScript : MonoBehaviour
{
    [SerializeField]
    GameObject glowstickPrefab;

    public Transform firingPoint;

    public float maxForce = 1;

    float forceTimer = 0;

    public float glowstickAmount = 5;

    public TextMeshProUGUI uiAmount;

    [SerializeField]
    GameObject audioPrefab;

    [SerializeField]
    AudioClip tossSound;

    [SerializeField]
    AudioClip emptySound;

    // Start is called before the first frame update
    void Start()
    {
        uiAmount.text = ""+glowstickAmount;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateFiring();
    }
    void UpdateFiring()
    {
        if (Input.GetButton("Fire1"))
        {
            if (forceTimer < maxForce)
            {
                forceTimer += Time.deltaTime;
            }

        }
        else if (forceTimer > 0)
        {
            Shoot();
            Debug.Log("forceTimer = " + forceTimer);
            forceTimer = 0;
        }
    }

    void Shoot()
    {
        if(glowstickAmount > 0)
        {
            GameObject nGlowstick = Instantiate(glowstickPrefab, firingPoint.position, Quaternion.identity);
            GlowStickScript gs = nGlowstick.GetComponent<GlowStickScript>();
            gs.SetDirection(transform.forward, forceTimer);
            glowstickAmount--;
            uiAmount.text = "" + glowstickAmount;

            GameObject soundPlayer = Instantiate(audioPrefab, firingPoint.position, Quaternion.identity);
            SoundPlayerScript sp = soundPlayer.GetComponent<SoundPlayerScript>();
            sp.PlaySound(tossSound, false, 1f);
        } else
        {
            GameObject soundPlayer = Instantiate(audioPrefab, firingPoint.position, Quaternion.identity);
            SoundPlayerScript sp = soundPlayer.GetComponent<SoundPlayerScript>();
            sp.PlaySound(emptySound, false, 1f);
        }
        
        
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesertGameController : MonoBehaviour
{
    [SerializeField] GameObject tombBlock;
    [SerializeField] GameObject DesertTF_1;
    [SerializeField] GameObject DesertTF_2;
    [SerializeField] GameObject DesertTF_3;
    [SerializeField] GameObject DesertS_0;
    [SerializeField] GameObject DesertS_1;
    [SerializeField] GameObject Path;
    [SerializeField] GameObject Sandstorm;
    [SerializeField] GameObject Corruption;
    [SerializeField] GameObject Ruby3;
    [SerializeField] GameObject Ruby4;
    [SerializeField] GameObject Ruby5;
    [SerializeField] GameObject Sapphire1;
    [SerializeField] GameObject EnchanterEnterD1;
    [SerializeField] GameObject EnchanterEnterD2;
    [SerializeField] GameObject EnchanterEnterD3;
    public ParticleSystem storm;
    private bool triggerOnce = true;
    public float timer = 0;

    private void Awake()
    {
        if(QuestTracker.desertQuestCount < 3)
        {
            DesertS_1.GetComponent<NPC_DesertStranded1>().isTalkingNPC = false;
            DesertTF_1.transform.position = new Vector3(73, -47, 0);
            DesertTF_1.GetComponent<NPC_DesertTownFolk1>().faceWest = true;
            DesertTF_1.GetComponent<NPC_DesertTownFolk1>().NPC_Number = 37;
            DesertTF_2.transform.position = new Vector3(73, -49, 0);
            DesertTF_2.GetComponent<NPC_DesertTownFolk2>().faceWest = true;
            DesertTF_2.GetComponent<NPC_DesertTownFolk2>().NPC_Number = 41;
            DesertTF_3.transform.position = new Vector3(73, -51, 0);
            DesertTF_3.GetComponent<NPC_DesertTownFolk3>().faceWest = true;
            DesertTF_3.GetComponent<NPC_DesertTownFolk3>().NPC_Number = 39;

        }

        if (QuestTracker.desertQuestCount > 4)
        {
            DesertTF_1.transform.position = new Vector3(85, -47.25f, 0);
            DesertTF_1.GetComponent<NPC_DesertTownFolk1>().disableMovement = false;
            DesertTF_1.GetComponent<NPC_DesertTownFolk1>().faceWest = false;
            DesertTF_1.GetComponent<NPC_DesertTownFolk1>().NPC_Number = 38;
            DesertTF_2.transform.position = new Vector3(92.5f, -50.5f, 0);
            DesertTF_2.GetComponent<NPC_DesertTownFolk2>().disableMovement = true;
            DesertTF_2.GetComponent<NPC_DesertTownFolk2>().faceWest = false;
            DesertTF_2.GetComponent<NPC_DesertTownFolk2>().NPC_Number = 43;
            DesertTF_3.transform.position = new Vector3(100.25f, -44.75f, 0);
            DesertTF_3.GetComponent<NPC_DesertTownFolk3>().disableMovement = false;
            DesertTF_3.GetComponent<NPC_DesertTownFolk3>().faceWest = false;
            DesertTF_3.GetComponent<NPC_DesertTownFolk3>().NPC_Number = 40;
            DesertS_0.transform.position = new Vector3(76.5f, -45.75f, 0);
            DesertS_0.GetComponent<NPC_DesertStranded0>().disableMovement = false;
            DesertS_0.GetComponent<NPC_DesertStranded0>().NPC_Number = 46;
            DesertS_1.transform.position = new Vector3(105.25f, -43.75f, 0);
            DesertS_1.GetComponent<NPC_DesertStranded1>().disableMovement = false;
            DesertS_1.GetComponent<NPC_DesertStranded1>().isTalkingNPC = true;
            DesertS_1.GetComponent<NPC_DesertStranded1>().NPC_Number = 47;
            Corruption.SetActive(false);
            Sandstorm.SetActive(false);
            Path.SetActive(true);
        }
        else
        {
            Corruption.SetActive(true);
            Sandstorm.SetActive(true);
            Path.SetActive(false);
        }
    }

    private void Start()
    {
        if (GameSavingInformation.ruby3Collected)
        {
            Ruby3.SetActive(false);
        }
        else
        {
            Ruby3.SetActive(true);
        }

        if (GameSavingInformation.ruby4Collected)
        {
            Ruby4.SetActive(false);
        }
        else
        {
            Ruby4.SetActive(true);
        }

        if (GameSavingInformation.ruby5Collected)
        {
            Ruby5.SetActive(false);
        }
        else
        {
            Ruby5.SetActive(true);
        }

        if (GameSavingInformation.sapphire1Collected)
        {
            Sapphire1.SetActive(false);
        }
        else
        {
            Sapphire1.SetActive(true);
        }
    }

    public void Update()
    {
        if (GameSavingInformation.differenceNumber == 1 || GameSavingInformation.differenceNumber == 4)
        {
            EnchanterEnterD1.SetActive(true);
        }
        else
        {
            EnchanterEnterD1.SetActive(false);
        }

        if (GameSavingInformation.differenceNumber == 2 || GameSavingInformation.differenceNumber == 5)
        {
            EnchanterEnterD2.SetActive(true);
        }
        else
        {
            EnchanterEnterD2.SetActive(false);
        }

        if (GameSavingInformation.differenceNumber == 3 || GameSavingInformation.differenceNumber == 6)
        {
            EnchanterEnterD3.SetActive(true);
        }
        else
        {
            EnchanterEnterD3.SetActive(false);
        }


        if (QuestTracker.desertQuestCount >= 3)
        {
            tombBlock.SetActive(false);
        }

        if (QuestTracker.desertQuestCount > 2 && QuestTracker.desertQuestCount < 5)
        {
            DesertS_1.GetComponent<NPC_DesertStranded1>().isTalkingNPC = false;
            DesertTF_1.transform.position = new Vector3(73, -47, 0);
            DesertTF_1.GetComponent<NPC_DesertTownFolk1>().faceWest = true;
            DesertTF_1.GetComponent<NPC_DesertTownFolk1>().NPC_Number = 37;
            DesertTF_2.transform.position = new Vector3(73, -49, 0);
            DesertTF_2.GetComponent<NPC_DesertTownFolk2>().faceWest = true;
            DesertTF_2.GetComponent<NPC_DesertTownFolk2>().NPC_Number = 42;
            DesertTF_3.transform.position = new Vector3(73, -51, 0);
            DesertTF_3.GetComponent<NPC_DesertTownFolk3>().faceWest = true;
            DesertTF_3.GetComponent<NPC_DesertTownFolk3>().NPC_Number = 40;
        }
    }

    public void FixedUpdate()
    {

        var emissionS = storm.emission;

        if (timer < 10)
        {
            timer += Time.deltaTime;
            emissionS.rateOverTime = timer * 100;
        }
        else
        {
            timer = 10;
            emissionS.rateOverTime = 1000;
        }

        if (QuestTracker.desertQuestCount == 3)
        {
            if (triggerOnce)
            {
                DesertS_0.GetComponent<Collider2D>().enabled = false;
                DesertS_1.GetComponent<Collider2D>().enabled = false;
                DesertS_0.transform.position = Vector3.MoveTowards(DesertS_0.transform.position, new Vector3(111f, -55, 0), 10f * Time.fixedDeltaTime);
                DesertS_1.transform.position = Vector3.MoveTowards(DesertS_1.transform.position, new Vector3(111f, -60, 0), 10f * Time.fixedDeltaTime);
                StartCoroutine(SetStrandedPosition());
            }
            
        }
    }

    IEnumerator SetStrandedPosition()
    {
        yield return new WaitForSeconds(5f);
        DesertS_1.transform.position = new Vector3(105.25f, -43.75f, 0);
        DesertS_1.GetComponent<NPC_DesertStranded1>().disableMovement = false;
        DesertS_1.GetComponent<NPC_DesertStranded1>().isTalkingNPC = true;
        DesertS_1.GetComponent<NPC_DesertStranded1>().NPC_Number = 47;
        DesertS_1.GetComponent<Collider2D>().enabled = true;

        DesertS_0.transform.position = new Vector3(99f, -43f, 0);
        DesertS_0.GetComponent<NPC_DesertStranded0>().disableMovement = false;
        DesertS_0.GetComponent<NPC_DesertStranded0>().NPC_Number = 46;
        DesertS_0.GetComponent<Collider2D>().enabled = true;
        triggerOnce = false;
    }
}

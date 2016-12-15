using UnityEngine;
using System.Collections;

public class GenerateRewards : MonoBehaviour
{

    // La zone de spawn
    private GameObject spawnArea;
    private int SizeX
    {
        get
        {
            return 200;
        }
    }

    private int SizeZ
    {
        get
        {
            return 80;
            
        }
    }


    // Les reward apparaissent sur les mêmes endroits


    public int nombreReward;

    // Use this for initialization
    void Start()
    {
        // Récupération de la spawnArea
        spawnArea = transform.FindChild("SpawnArea").gameObject;

        if (spawnArea != null)
        {
            Debug.Log("SpawnArea found");
        }
        else
        {
            Debug.Log("SpawnArea not found");

        }

        // Ajout des rewards
        //for (int i = 0; i < nombreReward; i++)
        //{
          //  GetRandomReward();
        //}
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Debug.Log("R appuyé");
            GetRandomReward();
        }
    }

    private void GetRandomReward()
    {
        System.Random rnd = new System.Random();
        int randomNumber = rnd.Next(1, 5);
        GameObject randomReward;
        Debug.Log(randomNumber);
        switch (randomNumber)
        {
            case 1:
                //randomReward = Resources.Load("RewardValue1") as GameObject;
                randomReward = Instantiate(Resources.Load("RewardValue1", typeof(GameObject))) as GameObject;
                break;
            case 2:
                randomReward = Instantiate(Resources.Load("RewardValue3", typeof(GameObject))) as GameObject;
                break;
            case 3:
                randomReward = Instantiate(Resources.Load("RewardValue5", typeof(GameObject))) as GameObject;
                break;
            case 4:
                randomReward = Instantiate(Resources.Load("RewardValue7", typeof(GameObject))) as GameObject;
                break;
            default:
                randomReward = Instantiate(Resources.Load("RewardValue1", typeof(GameObject))) as GameObject;
                break;
        }

        // Le positionnement de la reward ?
        // Choisir aléatoiremement la position X et Z
        int randomX = rnd.Next(-SizeX, SizeX);
        int randomZ = rnd.Next(-SizeZ, SizeZ);

        randomReward.transform. localPosition = new Vector3(randomX, randomReward.transform.localPosition.y, randomZ);  
    }
}

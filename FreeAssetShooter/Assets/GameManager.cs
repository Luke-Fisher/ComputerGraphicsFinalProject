
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private int objectiveCount = 0;
    private bool teleporterReady = false;

    public GameObject completeLevelUI;
    public void CompleteLevel()
    {
        if (teleporterReady)
        {
            completeLevelUI.SetActive(true);
        }

    }

    public void foundObjective()
    {
        objectiveCount++;
        FindObjectOfType<UpdateProgressText>().setProgress(objectiveCount.ToString() + "/3 part(s) found");

        if (objectiveCount == 3) teleporterReady = true;

    }

    public void Update()
    {
        if (teleporterReady)
        {
            FindObjectOfType<UpdateObjectiveText>().setUpdater("Teleporter is Ready!");
        }
    }



}

using UnityEngine;

public class SimplePet : MonoBehaviour
{
    [Header("Pet Info")]
    public string petName = "Buddy";
    public string petType = "Dog";
    public int petAge = 1;

    [Header("Pet Needs")]
    public int hunger = 50;      // 0-100
    public int happiness = 70;   // 0-100
    public int energy = 80;      // 0-100
    public int water = 80;       // 0-100

    [Header("Pet Status")]
    public bool isSleeping = false;
    public bool isHungry = false;
    public string mood = "Happy";
    public bool toilet = false;
    public bool thirsty = false;

    void Start()
    {
        Debug.Log("Meet your new pet: " + petName + " the " + petType);
        Debug.Log("Age: " + petAge + " years old");
        Debug.Log("Controls: F = Feed | P = Play | S = Sleep | I = Info | R = Water | T = Toilet");
        ShowPetInfo();
    }

    void Update()
    {
        // Check pet status
        if (hunger < 30)
        {
            isHungry = true;
            mood = "Hungry";
        }
        else if (energy < 20)
        {
            mood = "Tired";
        }
        else if (happiness > 80)
        {
            mood = "Very Happy";
        }
        else if (water < 30)
        {
            mood = "Thirsty";
        }
        else
        {
            mood = "Happy";
            isHungry = false;
            thirsty = false;
        }

        // Input controls
        if (Input.GetKeyDown(KeyCode.F))
        {
            // Feed pet
            if (hunger < 100)
            {
                hunger += 25;
                happiness += 10;
                Debug.Log("Fed " + petName + "! Hunger is now: " + hunger);

                if (hunger > 100) hunger = 100;
                if (hunger == 100) toilet = true;
                if (happiness > 100) happiness = 100;
            }
            else
            {
                Debug.Log(petName + " is already full!");
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (water < 100)
            {
                water += 15;
                happiness += 10;
                Debug.Log("Give water to " + petName + "! Water is now: " + water);

                if (water > 100) water = 100;
                if (water == 100) toilet = true;
                if (happiness > 100) happiness = 100;
            }
            else
            {
                Debug.Log(petName + " is already full!");
            }
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            if (toilet == true)
            {
                toilet = false;
                Debug.Log( petName + " got into the toilet");
            }
            else
            {
                Debug.Log( petName + "Does not want to the toilet");
            }
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            // Play with pet
            if (!isSleeping && energy > 10)
            {
                happiness += 20;
                energy -= 15;
                hunger -= 10;
                water -= 20;
                Debug.Log("Played with " + petName + "! Happiness: " + happiness);

                if (happiness > 100) happiness = 100;
                if (energy < 0) energy = 0;
                if (hunger < 0) hunger = 0;
                if (water  < 0) water = 0;
            }
            else if (isSleeping)
            {
                Debug.Log(petName + " is sleeping!");
            }
            else
            {
                Debug.Log(petName + " is too tired to play!");
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            // Toggle sleep
            isSleeping = !isSleeping;

            if (isSleeping)
            {
                Debug.Log(petName + " is now sleeping...");
                energy += 30;
                if (energy > 100) energy = 100;
            }
            else
            {
                Debug.Log(petName + " woke up!");
            }
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            // Show pet info
            ShowPetInfo();
        }

        // Voeg hier je eigen toets toe!
    }

    void ShowPetInfo()
    {
        Debug.Log("=== PET STATUS ===");
        Debug.Log("Name: " + petName);
        Debug.Log("Type: " + petType);
        Debug.Log("Age: " + petAge + " years");
        Debug.Log("Mood: " + mood);
        Debug.Log("Hunger: " + hunger + "/100");
        Debug.Log("Water: " + water + "/100");
        Debug.Log("Happiness: " + happiness + "/100");
        Debug.Log("Energy: " + energy + "/100");
        Debug.Log("Sleeping: " + isSleeping);
        Debug.Log("Toilet: " + toilet);
        Debug.Log("==================");
    }
}

using UnityEngine;
using System.IO;

public class ReadTextFile : MonoBehaviour
{
    void Start()
    {
        // Path to the text file
        string filePath = "Assets/testing/cat1script.txt";

        // Check if the file exists
        if (File.Exists(filePath))
        {
            try
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath);

                // Output each line to the console
                foreach (string line in lines)
                {
                    Debug.Log(line);
                }
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error reading the file: " + e.Message);
            }
        }
        else
        {
            Debug.LogError("File not found: " + filePath);
        }
    }
}

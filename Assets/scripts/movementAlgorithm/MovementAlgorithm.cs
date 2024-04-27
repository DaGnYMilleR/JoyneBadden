using UnityEngine;
using Random = System.Random;

public class MovementAlgorithm : MonoBehaviour
{
    private BucketScript[] buckets;
    private readonly Random random = new Random();
    private bool firstTry = false;

    private void Start()
    {
        buckets = FindObjectsOfType<BucketScript>();
    }
    
    private void Update()
    {
        if (!firstTry)
        {
            firstTry = true;
            ExecuteGame();
        }
    }

    public void ExecuteGame()
    {
        var turnsCount = random.Next(5, 10);
        for (var i = 0; i < turnsCount; i++)
        {
            Debug.Log($"iteration {i}");
            Shuffle();
        }
    }

    private void Shuffle()
    {
        var index = random.Next(buckets.Length);
        var otherIndex = GetIndexExceptGiven(index, buckets);
        
        var bucket = buckets[index];
        var otherBucket = buckets[otherIndex];
        
        Debug.Log($"bucket {index} initial position {bucket.transform.position}");
        Debug.Log($"bucket {otherIndex} initial position {otherBucket.transform.position}");

        var bucketPosition = bucket.transform.position;

        bucket.Move(otherBucket.transform.position);
        otherBucket.MoveParabolic(bucketPosition);

        (buckets[index], buckets[otherIndex]) = (buckets[otherIndex], buckets[index]);
        
        Debug.Log($"move bucket {index} to position {otherBucket.transform.position}");
        Debug.Log($"move bucket {otherIndex} to position {bucketPosition}");
    }

    private void MoveButtons(int first, int second)
    {
        var bucket = buckets[first];
        var otherBucket = buckets[second];
        
        
    }

    private int GetIndexExceptGiven(int exceptIndex, BucketScript[] buckets)
    {
        while (true)
        {
            var index = random.Next(buckets.Length);
            if (index != exceptIndex)
                return index;
        }
    }
}
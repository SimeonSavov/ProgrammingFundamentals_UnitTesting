List<int> firstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> secondPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();

while (firstPlayer.Count > 0 && secondPlayer.Count > 0) // Play while the two players have cards
{
    if (firstPlayer[0] > secondPlayer[0])
    {
        firstPlayer.Add(secondPlayer[0]); // First - the winner get the opponent card to his deck
        firstPlayer.Add(firstPlayer[0]); // Second - the winner get his own card to the deck
    }
    else if (firstPlayer[0] < secondPlayer[0])
    {
        secondPlayer.Add(firstPlayer[0]); // First - the winner get the opponent card to his deck
        secondPlayer.Add(secondPlayer[0]); // Second - the winner get his own card to the deck
    }

    firstPlayer.RemoveAt(0); // Remove those cards
    secondPlayer.RemoveAt(0);
}

if (firstPlayer.Count > 0) // Means the first player have cards in his deck
{
    int sum = firstPlayer.Sum();
    Console.WriteLine($"First player wins! Sum: {sum}");
}
else if (secondPlayer.Count > 0) // Second player have cards in his deck
{
    int sum = secondPlayer.Sum();
    Console.WriteLine($"Second player wins! Sum: {sum}");
}
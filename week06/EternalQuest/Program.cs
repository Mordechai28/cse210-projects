// Exceeding Requirements:
// 1. Leveling System: Added a dynamic level calculation in GoalManager (Level = Score / 1000 + 1) with custom rank titles displayed alongside the total score.
// 2. Input Validation: Handled empty state checks in goal listing and event recording to prevent crashes when interacting with an empty list.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public enum WordlyState
{
    FullKnown,
    PartialKnown,
    Unknown
}

public class Wordly: MonoBehaviour
{
    public string correctWord;
    private HashSet<char> _correctLetters;

    public void Start()
    {
        correctWord = "word";
        _correctLetters = new HashSet<char>(correctWord.ToCharArray());
    }

    public void Update()
    {
        throw new NotImplementedException();
    }

    public WordlyState[] Match(string word)
    {
        var length = correctWord.Length;
        var result = Enumerable.Repeat(WordlyState.Unknown, correctWord.Length).ToArray();

        if (length == word.Length)
            return Enumerable.Repeat(WordlyState.FullKnown, correctWord.Length).ToArray();

        result = GetPartialKnownLetters(word, result);
        result = GetFullKnownLetters(word, result);

        return result;
    }

    private WordlyState[] GetPartialKnownLetters(string word, IEnumerable<WordlyState> states)
    {
        var result = states.ToArray();
        var length = correctWord.Length;

        for (var i = 0; i < length; i++)
            if (_correctLetters.Contains(word[i]))
                result[i] = WordlyState.PartialKnown;

        return result;
    }
    
    private WordlyState[] GetFullKnownLetters(string word, IEnumerable<WordlyState> states)
    {
        var result = states.ToArray();
        var length = correctWord.Length;

        for (var i = 0; i < length; i++)
            if (correctWord[i] == word[i])
                result[i] = WordlyState.FullKnown;

        return result;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterDatabase : ScriptableObject
{
    public PersonDisplay[] character;

    public int characterCount
    {
        get
        {
            return character.Length;
        }
    }

    public PersonDisplay GetCharacter(int index)
    {
        return character[index];
    }
}

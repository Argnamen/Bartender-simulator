using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class BartenderCharacter
{
    public Animation CharacterAnim;

}

/// <summary>
/// Butilka s alkogolem
/// </summary>
interface Bottle
{
    public void Pouring();
}

/// <summary>
/// Sosud dla alkogola
/// </summary>
interface Vessel
{
    public void Filling();
}

class Man: Bartender
{
    public Animation CharacterAnim;
}

class Girl : Bartender
{
    public Animation CharacterAnim;
}
/// <summary>
/// Pivo
/// </summary>
class Beer: Bottle
{
    int FillingSpeed = 10;
    int FoamSpeed = 12;
    public void Pouring()
    {

    }
}
/// <summary>
/// Wino
/// </summary>
class Wine : Bottle
{
    int FillingSpeed = 15;
    int FoamSpeed = 0;
    public void Pouring()
    {

    }
}

/// <summary>
/// Medovuha
/// </summary>
class Mead: Bottle
{
    int FillingSpeed = 8;
    int FoamSpeed = 1;
    public void Pouring()
    {

    }
}

/// <summary>
/// Kruzka
/// </summary>
class Cup: Vessel
{
    int Volume = 10;
    public void Filling()
    {

    }
}

/// <summary>
/// Stakan
/// </summary>
class Glass: Vessel
{
    int Volume = 1;
    public void Filling()
    {

    }
}
public class Bartender : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

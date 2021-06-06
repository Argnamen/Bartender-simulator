using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class BartenderCharacter
{
    public Animation CharacterAnim;
}

class NoObject: Bottle, Vessel {
    public void Pouring() { }
    public void Filling() { }
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
    public GameManager gameManager;
    Bottle[] bottle;
    Vessel[] vessel;
    // Start is called before the first frame update
    void Start()
    {
        Bottle bear = new Beer();
        Bottle wine = new Wine();
        Bottle mead = new Mead();
        Vessel cup = new Cup();
        Vessel glass = new Glass();
        for(int i = 0; i < 10; i++) //10 vidov napitkov i iomkostei
        {
            bottle[i] = new NoObject();
            vessel[i] = new NoObject();
        }
        bottle[0] = bear;
        bottle[1] = wine;
        bottle[2] = mead;

        vessel[0] = cup;
        vessel[1] = glass;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

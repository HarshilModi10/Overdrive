using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CosmeticItem{
    private string name;
    private Mesh characterModel;
    private int price;

    public CosmeticItem(string name, Mesh characterModel, int price){
        this.name = name;
        this.characterModel = characterModel;
        this.price = price;
    }

    public string getName(){
        return this.name;
    }

    public Mesh getCharacterModel(){
        return this.characterModel;
    }

    public int getPrice(){
        return this.price;
    }

}

using System;

class Pokemon {
    public string name;
    public int hp;
    public int defense;
    public int attack;
    public int evasion;

    public Pokemon(string name, int hp, int attack, int defense, int evasion){
        this.name = name;
        this.hp = hp;
        this.attack = attack;
        this.defense = defense;
        this.evasion = evasion;
    }
    public void Scratch(Pokemon enemy){
        int damage = (this.attack - enemy.defense) * 5;
        Random random = new Random();
        int evasionSelector = random.Next(1,4);
        if(evasionSelector > 3) {
            enemy.hp = enemy.hp - this.damage;
            console.WriteLine($"{this.name} use Scratch! It makes {damage} damage to {enemy.name}.);
        }
    }

}
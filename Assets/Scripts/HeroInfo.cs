using System.Collections;
using System.Collections.Generic;

public class Hero : Character
{ 
    public Hero()
    { 
        this.setName("Hero");

        this.setHP(1000);
        this.setHP(1000);
        this.setAD(100);
        this.setArmor(50);
        this.setSpeed(120);
        this.setCrit_Per(0.05f);
        this.setCrit_Dam(150);
    }
}
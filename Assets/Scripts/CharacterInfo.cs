using System.Collections;
using System.Collections.Generic;

public class Character
{
    /// <summary>
    /// field
    /// </summary>
    // 직업, 캐릭터 이름, 속성, 레벨
    private string Class;
    private string Name;
    private string Element_Property;
    private int Level;

    // 능력치
    private int HP;
    private int AD;
    private int Armor;
    private float Speed;
    private float Crit_Per;
    private int Crit_Dam;

    // 스킬 이름
    private string Skill1_Name;
    private string Skill2_Name;
    private string Skill3_Name;
    
    // 스킬 유형
    private string Skill1_Type;
    private string Skill2_Type;
    private string Skill3_Type;

    // 스킬 계수
    private float Skill1_Coefficient;
    private float Skill2_Coefficient;
    private float Skill3_Coefficient;

    // 스킬 쿨타임 (1스킬은 쿨타임 x)
    private int Skill1_Cooldown;
    private int Skill2_Cooldown;
    private int Skill3_Cooldown;
          
    /// <summary>
    /// function
    /// </summary> 
    
    public void Initialize()
    {

    }

    // set
    // 직업, 캐릭터 이름, 속성, 레벨
    public void setClass(string Class)
    {
        this.Class = Class;
    }

    public void setName(string Name)
    {
        this.Name = Name;
    }

    public void setElement_Property(string Element_Property)
    {
        this.Element_Property = Element_Property;
    }

    public void setLevel(int Level)
    {
        this.Level = Level;
    }

    // 능력치
    public void setHP(int hp)
    {
        this.HP = hp;
    }

    public void setAD(int ad)
    {
        this.AD = ad;
    }

    public void setArmor(int armor)
    {
        this.Armor = armor;
    }

    public void setSpeed(float speed)
    {
        this.Speed = speed;
    }

    public void setCrit_Per(float crit_per)
    {
        this.Crit_Per = crit_per;
    }

    public void setCrit_Dam(int crit_dam)
    {
        this.Crit_Dam = crit_dam;
    }

    // 스킬 이름
    public void setSkill1_Name(string Skill1_Name)
    {
        this.Skill1_Name = Skill1_Name;
    }

    public void setSkill2_Name(string Skill2_Name)
    {
        this.Skill2_Name = Skill2_Name;
    }

    public void setSkill3_Name(string Skill3_Name)
    {
        this.Skill3_Name = Skill3_Name;
    }

    // 스킬 유형
    public void setSkill1_Type(string Skill1_Type)
    {
        this.Skill1_Type = Skill1_Type;
    }

    public void setSkill2_Type(string Skill2_Type)
    {
        this.Skill2_Type = Skill2_Type;
    }

    public void setSkill3_Type(string Skill3_Type)
    {
        this.Skill3_Type = Skill3_Type;
    }

    // 스킬 계수
    public void setSkill1_Coefficient(float Skill1_Coefficient)
    {
        this.Skill1_Coefficient = Skill1_Coefficient;
    }

    public void setSkill2_Coefficient(float Skill2_Coefficient)
    {
        this.Skill2_Coefficient = Skill2_Coefficient;
    }

    public void setSkill3_Coefficient(float Skill3_Coefficient)
    {
        this.Skill3_Coefficient = Skill3_Coefficient;
    }

    // 스킬 쿨타임
    public void setSkill1_Cooldown(int Skill1_Cooldown)
    {
        this.Skill1_Cooldown = Skill1_Cooldown;
    }

    public void setSkill2_Cooldown(int Skill2_Cooldown)
    {
        this.Skill2_Cooldown = Skill2_Cooldown;
    }

    public void setSkill3_Cooldown(int Skill3_Cooldown)
    {
        this.Skill3_Cooldown = Skill3_Cooldown;
    }

    
    // get
    // 직업, 캐릭터 이름, 속성, 레벨
    public string getClass()
    {
        return this.Class;
    }

    public string getName()
    {
        return this.Name;
    }

    public string getElement_Property()
    {
        return this.Element_Property;
    }

    public int getLevel()
    {
        return this.Level;
    }

    // 능력치
    public int getHP()
    {
        return this.HP;
    }

    public int getAD()
    {
        return this.AD;
    }

    public int getArmor()
    {
        return this.Armor;
    }

    public float getSpeed()
    {
        return this.Speed;
    }

    public float getCrit_Per()
    {
        return this.Crit_Per;
    }

    public int getCrit_Dam()
    {
        return this.Crit_Dam;
    }

    // 스킬 이름
    public string getSkill1_Name()
    {
        return this.Skill1_Name;
    }

    public string getSkill2_Name()
    {
        return this.Skill2_Name;
    }

    public string getSkill3_Name()
    {
        return this .Skill3_Name;
    }

    // 스킬 유형
    public string getSkill1_Type()
    {
        return this .Skill1_Type;
    }

    public string getSkill2_Type()
    {
        return this .Skill2_Type;
    }

    public string setSkill3_Type()
    {
        return this.Skill3_Type;
    }

    // 스킬 계수
    public float getSkill1_Coefficient()
    {
        return this.Skill1_Coefficient;
    }

    public float getSkill2_Coefficient()
    {
        return this.Skill2_Coefficient;
    }

    public float getSkill3_Coefficient()
    {
        return this.Skill3_Coefficient;
    }

    // 스킬 쿨타임
    public int getSkill1_Cooldown()
    {
        return this.Skill1_Cooldown;
    }

    public int getSkill2_Cooldown()
    {
        return this.Skill2_Cooldown;
    }

    public int getSkill3_Cooldown()
    {
        return this.Skill3_Cooldown;
    }
}
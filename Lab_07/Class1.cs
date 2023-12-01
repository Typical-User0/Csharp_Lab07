namespace Lab_07;

[Comment("Cow class")]
public class Cow : Animal
{
    public Cow(string Country, string HideFromOtherAnimal, string Name, string WhatAnimal) : base(Country, HideFromOtherAnimal, Name, WhatAnimal)
    {

    }
    public override void SayHello()
    {
        base.SayHello();
        Console.WriteLine(", i'm a Cow.");
    }
    public override eFavoriteFood GetFavoriteFood()
    {
        return base.GetFavoriteFood();
    }
}
[Comment("Lion class")]
public class Lion : Animal
{
    public Lion(string Country, string HideFromOtherAnimal, string Name, string WhatAnimal) : base(Country, HideFromOtherAnimal, Name, WhatAnimal)
    {

    }
    public override void SayHello()
    {
        base.SayHello();
        Console.WriteLine(", i'm a Lion.");
    }
    public override eFavoriteFood GetFavoriteFood()
    {
        return base.GetFavoriteFood();
    }
}
[Comment("Pig class")]
public class Pig : Animal
{
    public Pig(string Country, string HideFromOtherAnimal, string Name, string WhatAnimal) : base(Country, HideFromOtherAnimal, Name, WhatAnimal)
    {

    }
    public override void SayHello()
    {
        base.SayHello();
        Console.WriteLine(", i'm a Pig.");
    }
    public override eFavoriteFood GetFavoriteFood()
    {
        return base.GetFavoriteFood();
    }
}
[Comment("Animal class")]
abstract public class Animal
{
    public string Country { get; set; }
    public string HideFromOtherAnimal { get; set; }
    public string Name { get; set; }
    public string WhatAnimal { get; set; }
    public eClassificationAnimal ClassificationAnimal { get; set; }
    public eFavoriteFood FavoriteFood { get; set; }
    public Animal(string Country, string HideFromOtherAnimal, string Name, string WhatAnimal)
    {
        this.Country = Country;
        this.HideFromOtherAnimal = HideFromOtherAnimal;
        this.Name = Name;
        this.WhatAnimal = WhatAnimal;
    }
    public void Deconstruct(string Country, string HideFromOtherAnimal, string Name, string WhatAnimal)
    {
        Country = this.Country;
        HideFromOtherAnimal = this.HideFromOtherAnimal;
        Name = this.Name;
        WhatAnimal = this.WhatAnimal;
    }
    public eClassificationAnimal GetClassificationAnimal()
    {
        return this.ClassificationAnimal;
    }
    public virtual eFavoriteFood GetFavoriteFood()
    {
        return this.FavoriteFood;
    }
    public virtual void SayHello()
    {
        Console.Write("Hello ");
    }
}
public enum eClassificationAnimal
{
    Herbivores,
    Carnivores,
    Omnivores
}
public enum eFavoriteFood
{
    Meat,
    Plants,
    Everything
}
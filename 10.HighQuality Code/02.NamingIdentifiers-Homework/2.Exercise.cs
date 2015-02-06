class HumanMaker
{
  enum Sex { Male, Female };

  class Human
  {
    public Sex Gender { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
  }
  
  public void AddPerson(int age)
  {
    Human newPerson = new Human();
    newPerson.Age = age;
    if (age % 2 == 0)
    {
      newPerson.Name = "Батката";
      newPerson.Gender = Sex.Male;
    }
    else
    {
      newPerson.Name = "Мацето";
      newPerson.Gender = Sex.Female;
    }
  }
}
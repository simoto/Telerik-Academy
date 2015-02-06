class BooleanOperation
{
  const int MAX_COUNT = 6;
  class Converter 
  {
    void ConvertToString(bool boolean)   
	{
      string boolAsString = boolean.ToString();
      Console.WriteLine(boolAsString);   
	}
  } 
  
  public static void Main()  
  {
    BooleanOperation.Converter testConverter =
      new BooleanOperation.Converter();
    testConverter.ConvertToString(true); 
  }
}

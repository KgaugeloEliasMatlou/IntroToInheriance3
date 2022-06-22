using System;

public class PatientClass
{
    public string FirstName { get; set; }
    public string SecondName  { get; set; }
    public string Age { get; set; }

    public string weight { get; set; }


    public virtual void Examine()
    {
        Console.WriteLine("The patient has been examined....");
    }


   
}


using System;

class Program
{
    static void Main()
    {
        PatientClass pc = new PatientClass();
        pc.Examine();
        AdultsClass ac = new AdultsClass();
        ac.Examine();
    }
}
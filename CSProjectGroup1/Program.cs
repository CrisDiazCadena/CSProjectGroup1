using System;

class Program
{
    static void Main()
    {
        // Create a new patient
        Patient patient1 = new Patient
        {
            FirstName = "John",
            LastName = "Doe",
            Weight = 75,  // kg
            Height = 180  // cm
        };

        // Display patient info
        Console.WriteLine($"Patient: {patient1.FirstName} {patient1.LastName}");
        
        // Check blood pressure
        patient1.CheckBloodPressure(130, 85);

        // Calculate BMI
        patient1.CalculateBMI();

        Console.ReadLine(); // Keep console open
    }
}

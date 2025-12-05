public class Patient
{
    // Public properties (PascalCase)
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Weight { get; set; }  // in kilograms
    public double Height { get; set; }  // in centimeters

    // Method to check blood pressure
    public void CheckBloodPressure(double systolic, double diastolic)
    {
        // Example logic from recording
        if (systolic < 120 && diastolic < 80)
        {
            Console.WriteLine("Blood Pressure: Normal");
        }
        else if (systolic < 140 && diastolic < 90)
        {
            Console.WriteLine("Blood Pressure: Elevated");
        }
        else
        {
            Console.WriteLine("Blood Pressure: High");
        }
    }

    // Method to calculate BMI and print BMI status
    public void CalculateBMI()
    {
        double heightMeters = Height / 100;  // Convert cm to meters
        double bmi = Weight / (heightMeters * heightMeters);

        Console.WriteLine($"BMI: {bmi:F2}");

        if (bmi < 18.5)
            Console.WriteLine("BMI Status: Underweight");
        else if (bmi < 24.9)
            Console.WriteLine("BMI Status: Normal weight");
        else if (bmi < 29.9)
            Console.WriteLine("BMI Status: Overweight");
        else
            Console.WriteLine("BMI Status: Obese");
    }
}

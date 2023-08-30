// Create a class called HealthRecord
public class HealthRecord
{
    public string client { get; set; }
    public int Age { get; set; }
    public int DiagnosisScore { get; set; }
    public bool PreviousInsuranceCoverage { get; set; }

    public HealthRecord(string name, int age, int diagnosisScore, bool previousInsuranceCoverage)
    {
        client = name;
        Age = age;
        DiagnosisScore = diagnosisScore;
        PreviousInsuranceCoverage = previousInsuranceCoverage;
    }
}

// Create a function to create a new health record
public static HealthRecord CreateHealthRecord(string name, int age, int diagnosisScore, bool previousInsuranceCoverage)
{
    return new HealthRecord(name, age, diagnosisScore, previousInsuranceCoverage);
}

// Create a function to view the details of a health record
public static void ViewHealthRecord(HealthRecord healthRecord)
{
    Console.WriteLine("client: {0}", healthRecord.client);
    Console.WriteLine("Age: {0}", healthRecord.Age);
    Console.WriteLine("Diagnosis score: {0}", healthRecord.DiagnosisScore);
    Console.WriteLine("Previous insurance coverage: {0}", healthRecord.PreviousInsuranceCoverage);
}

// Create a function to update the details of a health record
public static void UpdateHealthRecord(HealthRecord healthRecord, string name, int age, int diagnosisScore, bool previousInsuranceCoverage)
{
    healthRecord.client = name;
    healthRecord.Age = age;
    healthRecord.DiagnosisScore = diagnosisScore;
    healthRecord.PreviousInsuranceCoverage = previousInsuranceCoverage;
}

// Create a function to invalidate a health record
public static void InvalidateHealthRecord(HealthRecord healthRecord)
{
    healthRecord = null;
}

// Create a function to view multiple health records
public static void ViewMultipleHealthRecords(List<HealthRecord> healthRecords)
{
    for (int i = 0; i < healthRecords.Count; i++)
    {
        ViewHealthRecord(healthRecords[i]);
    }
}

// Create a function to delete multiple health records
public static void DeleteMultipleHealthRecords(List<HealthRecord> healthRecords)
{
    for (int i = 0; i < healthRecords.Count; i++)
    {
        InvalidateHealthRecord(healthRecords[i]);
    }
}

// Create a function to calculate the annual insurance premium
public static int CalculateAnnualInsurancePremium(int age, int diagnosisScore, bool previousInsuranceCoverage)
{
    int premium = 0;
    if (age >= 65)
    {
        premium += 1000;
    }
    if (diagnosisScore >= 8)
    {
        premium += 500;
    }
    if (previousInsuranceCoverage is false)
    {
        premium += 200;
    }
    return premium;
}

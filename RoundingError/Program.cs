using var input = new StreamReader(Console.OpenStandardInput());
using var output = new StreamWriter(Console.OpenStandardOutput());

int setAll = int.Parse(input.ReadLine());
for (int i = 0; i < setAll; i++)
{
    var s = input.ReadLine().Split(' ');
    double p = double.Parse(s[1]);

    double commissionAll = 0;
    for (int j = 0; j < int.Parse(s[0]); j++)
    {
        int a = int.Parse(input.ReadLine());
        double oneCommission = a * (p / 100);
        oneCommission -= Math.Truncate(oneCommission);
        commissionAll += oneCommission;
    }

    output.WriteLine(commissionAll % 1 == 0 ? "0.00" : Math.Round(commissionAll, 2).ToString("F2").Replace(',', '.'));
}
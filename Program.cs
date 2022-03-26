decimal salario, fgts;

Console.WriteLine("Por favor, digite seu salario:");
salario = Convert.ToDecimal(Console.ReadLine());

fgts = (salario * 0.08m);

Console.WriteLine($"FGTS:{fgts:C2}");
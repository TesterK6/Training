// 3. By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13. What is the 47th prime number?

List<int> primeList = new List<int>();
List<int> nrList = Enumerable.Range(1, 500).ToList();

    foreach (int inputNr in nrList)
    {
        
            int counter = 0;
            for (int i = 2; i <= inputNr / 2; i++)
            {

                if (inputNr % i == 0)
                {
                    counter++;
                }

            }
            if (counter == 0 && inputNr != 1)
            {

                //Console.Write("{0} ", inputNr);
                primeList.Add(inputNr);
                  if (primeList.Count == 47)
                  {
                     break;
                  }
          
            }

    }
primeList.ForEach(Console.WriteLine);
Console.WriteLine($" \n The 46th prime number is {primeList[46]}");





